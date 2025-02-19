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

namespace Google.Apis.AndroidEnterprise.v1
{
    /// <summary>The AndroidEnterprise Service.</summary>
    public class AndroidEnterpriseService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AndroidEnterpriseService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AndroidEnterpriseService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Devices = new DevicesResource(this);
            EnrollmentTokens = new EnrollmentTokensResource(this);
            Enterprises = new EnterprisesResource(this);
            Entitlements = new EntitlementsResource(this);
            Grouplicenses = new GrouplicensesResource(this);
            Grouplicenseusers = new GrouplicenseusersResource(this);
            Installs = new InstallsResource(this);
            Managedconfigurationsfordevice = new ManagedconfigurationsfordeviceResource(this);
            Managedconfigurationsforuser = new ManagedconfigurationsforuserResource(this);
            Managedconfigurationssettings = new ManagedconfigurationssettingsResource(this);
            Permissions = new PermissionsResource(this);
            Products = new ProductsResource(this);
            Serviceaccountkeys = new ServiceaccountkeysResource(this);
            Storelayoutclusters = new StorelayoutclustersResource(this);
            Storelayoutpages = new StorelayoutpagesResource(this);
            Users = new UsersResource(this);
            Webapps = new WebappsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://androidenterprise.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://androidenterprise.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "androidenterprise";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Google Play EMM API.</summary>
        public class Scope
        {
            /// <summary>Manage corporate Android devices</summary>
            public static string Androidenterprise = "https://www.googleapis.com/auth/androidenterprise";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Google Play EMM API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Manage corporate Android devices</summary>
            public const string Androidenterprise = "https://www.googleapis.com/auth/androidenterprise";
        }

        /// <summary>Gets the Devices resource.</summary>
        public virtual DevicesResource Devices { get; }

        /// <summary>Gets the EnrollmentTokens resource.</summary>
        public virtual EnrollmentTokensResource EnrollmentTokens { get; }

        /// <summary>Gets the Enterprises resource.</summary>
        public virtual EnterprisesResource Enterprises { get; }

        /// <summary>Gets the Entitlements resource.</summary>
        public virtual EntitlementsResource Entitlements { get; }

        /// <summary>Gets the Grouplicenses resource.</summary>
        public virtual GrouplicensesResource Grouplicenses { get; }

        /// <summary>Gets the Grouplicenseusers resource.</summary>
        public virtual GrouplicenseusersResource Grouplicenseusers { get; }

        /// <summary>Gets the Installs resource.</summary>
        public virtual InstallsResource Installs { get; }

        /// <summary>Gets the Managedconfigurationsfordevice resource.</summary>
        public virtual ManagedconfigurationsfordeviceResource Managedconfigurationsfordevice { get; }

        /// <summary>Gets the Managedconfigurationsforuser resource.</summary>
        public virtual ManagedconfigurationsforuserResource Managedconfigurationsforuser { get; }

        /// <summary>Gets the Managedconfigurationssettings resource.</summary>
        public virtual ManagedconfigurationssettingsResource Managedconfigurationssettings { get; }

        /// <summary>Gets the Permissions resource.</summary>
        public virtual PermissionsResource Permissions { get; }

        /// <summary>Gets the Products resource.</summary>
        public virtual ProductsResource Products { get; }

        /// <summary>Gets the Serviceaccountkeys resource.</summary>
        public virtual ServiceaccountkeysResource Serviceaccountkeys { get; }

        /// <summary>Gets the Storelayoutclusters resource.</summary>
        public virtual StorelayoutclustersResource Storelayoutclusters { get; }

        /// <summary>Gets the Storelayoutpages resource.</summary>
        public virtual StorelayoutpagesResource Storelayoutpages { get; }

        /// <summary>Gets the Users resource.</summary>
        public virtual UsersResource Users { get; }

        /// <summary>Gets the Webapps resource.</summary>
        public virtual WebappsResource Webapps { get; }
    }

    /// <summary>A base abstract class for AndroidEnterprise requests.</summary>
    public abstract class AndroidEnterpriseBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new AndroidEnterpriseBaseServiceRequest instance.</summary>
        protected AndroidEnterpriseBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes AndroidEnterprise parameter list.</summary>
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
        /// Uploads a report containing any changes in app states on the device since the last report was generated. You
        /// can call this method up to 3 times every 24 hours for a given device. If you exceed the quota, then the
        /// Google Play EMM API returns HTTP 429 Too Many Requests.
        /// </summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        /// <param name="deviceId">The ID of the device.</param>
        public virtual ForceReportUploadRequest ForceReportUpload(string enterpriseId, string userId, string deviceId)
        {
            return new ForceReportUploadRequest(this.service, enterpriseId, userId, deviceId);
        }

        /// <summary>
        /// Uploads a report containing any changes in app states on the device since the last report was generated. You
        /// can call this method up to 3 times every 24 hours for a given device. If you exceed the quota, then the
        /// Google Play EMM API returns HTTP 429 Too Many Requests.
        /// </summary>
        public class ForceReportUploadRequest : AndroidEnterpriseBaseServiceRequest<string>
        {
            /// <summary>Constructs a new ForceReportUpload request.</summary>
            public ForceReportUploadRequest(Google.Apis.Services.IClientService service, string enterpriseId, string userId, string deviceId) : base(service)
            {
                EnterpriseId = enterpriseId;
                UserId = userId;
                DeviceId = deviceId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            /// <summary>The ID of the device.</summary>
            [Google.Apis.Util.RequestParameterAttribute("deviceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DeviceId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "forceReportUpload";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/users/{userId}/devices/{deviceId}/forceReportUpload";

            /// <summary>Initializes ForceReportUpload parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("deviceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "deviceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves the details of a device.</summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        /// <param name="deviceId">The ID of the device.</param>
        public virtual GetRequest Get(string enterpriseId, string userId, string deviceId)
        {
            return new GetRequest(this.service, enterpriseId, userId, deviceId);
        }

        /// <summary>Retrieves the details of a device.</summary>
        public class GetRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.Device>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string enterpriseId, string userId, string deviceId) : base(service)
            {
                EnterpriseId = enterpriseId;
                UserId = userId;
                DeviceId = deviceId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            /// <summary>The ID of the device.</summary>
            [Google.Apis.Util.RequestParameterAttribute("deviceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DeviceId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/users/{userId}/devices/{deviceId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("deviceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "deviceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Retrieves whether a device's access to Google services is enabled or disabled. The device state takes effect
        /// only if enforcing EMM policies on Android devices is enabled in the Google Admin Console. Otherwise, the
        /// device state is ignored and all devices are allowed access to Google services. This is only supported for
        /// Google-managed users.
        /// </summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        /// <param name="deviceId">The ID of the device.</param>
        public virtual GetStateRequest GetState(string enterpriseId, string userId, string deviceId)
        {
            return new GetStateRequest(this.service, enterpriseId, userId, deviceId);
        }

        /// <summary>
        /// Retrieves whether a device's access to Google services is enabled or disabled. The device state takes effect
        /// only if enforcing EMM policies on Android devices is enabled in the Google Admin Console. Otherwise, the
        /// device state is ignored and all devices are allowed access to Google services. This is only supported for
        /// Google-managed users.
        /// </summary>
        public class GetStateRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.DeviceState>
        {
            /// <summary>Constructs a new GetState request.</summary>
            public GetStateRequest(Google.Apis.Services.IClientService service, string enterpriseId, string userId, string deviceId) : base(service)
            {
                EnterpriseId = enterpriseId;
                UserId = userId;
                DeviceId = deviceId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            /// <summary>The ID of the device.</summary>
            [Google.Apis.Util.RequestParameterAttribute("deviceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DeviceId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getState";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/users/{userId}/devices/{deviceId}/state";

            /// <summary>Initializes GetState parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("deviceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "deviceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves the IDs of all of a user's devices.</summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        public virtual ListRequest List(string enterpriseId, string userId)
        {
            return new ListRequest(this.service, enterpriseId, userId);
        }

        /// <summary>Retrieves the IDs of all of a user's devices.</summary>
        public class ListRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.DevicesListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string enterpriseId, string userId) : base(service)
            {
                EnterpriseId = enterpriseId;
                UserId = userId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/users/{userId}/devices";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Sets whether a device's access to Google services is enabled or disabled. The device state takes effect only
        /// if enforcing EMM policies on Android devices is enabled in the Google Admin Console. Otherwise, the device
        /// state is ignored and all devices are allowed access to Google services. This is only supported for
        /// Google-managed users.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        /// <param name="deviceId">The ID of the device.</param>
        public virtual SetStateRequest SetState(Google.Apis.AndroidEnterprise.v1.Data.DeviceState body, string enterpriseId, string userId, string deviceId)
        {
            return new SetStateRequest(this.service, body, enterpriseId, userId, deviceId);
        }

        /// <summary>
        /// Sets whether a device's access to Google services is enabled or disabled. The device state takes effect only
        /// if enforcing EMM policies on Android devices is enabled in the Google Admin Console. Otherwise, the device
        /// state is ignored and all devices are allowed access to Google services. This is only supported for
        /// Google-managed users.
        /// </summary>
        public class SetStateRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.DeviceState>
        {
            /// <summary>Constructs a new SetState request.</summary>
            public SetStateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidEnterprise.v1.Data.DeviceState body, string enterpriseId, string userId, string deviceId) : base(service)
            {
                EnterpriseId = enterpriseId;
                UserId = userId;
                DeviceId = deviceId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            /// <summary>The ID of the device.</summary>
            [Google.Apis.Util.RequestParameterAttribute("deviceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DeviceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidEnterprise.v1.Data.DeviceState Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "setState";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/users/{userId}/devices/{deviceId}/state";

            /// <summary>Initializes SetState parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("deviceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "deviceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates the device policy. To ensure the policy is properly enforced, you need to prevent unmanaged accounts
        /// from accessing Google Play by setting the allowed_accounts in the managed configuration for the Google Play
        /// package. See restrict accounts in Google Play. When provisioning a new device, you should set the device
        /// policy using this method before adding the managed Google Play Account to the device, otherwise the policy
        /// will not be applied for a short period of time after adding the account to the device.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        /// <param name="deviceId">The ID of the device.</param>
        public virtual UpdateRequest Update(Google.Apis.AndroidEnterprise.v1.Data.Device body, string enterpriseId, string userId, string deviceId)
        {
            return new UpdateRequest(this.service, body, enterpriseId, userId, deviceId);
        }

        /// <summary>
        /// Updates the device policy. To ensure the policy is properly enforced, you need to prevent unmanaged accounts
        /// from accessing Google Play by setting the allowed_accounts in the managed configuration for the Google Play
        /// package. See restrict accounts in Google Play. When provisioning a new device, you should set the device
        /// policy using this method before adding the managed Google Play Account to the device, otherwise the policy
        /// will not be applied for a short period of time after adding the account to the device.
        /// </summary>
        public class UpdateRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.Device>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidEnterprise.v1.Data.Device body, string enterpriseId, string userId, string deviceId) : base(service)
            {
                EnterpriseId = enterpriseId;
                UserId = userId;
                DeviceId = deviceId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            /// <summary>The ID of the device.</summary>
            [Google.Apis.Util.RequestParameterAttribute("deviceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DeviceId { get; private set; }

            /// <summary>
            /// Mask that identifies which fields to update. If not set, all modifiable fields will be modified. When
            /// set in a query parameter, this field should be specified as
            /// updateMask=&amp;lt;field1&amp;gt;,&amp;lt;field2&amp;gt;,...
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidEnterprise.v1.Data.Device Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/users/{userId}/devices/{deviceId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("deviceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "deviceId",
                    IsRequired = true,
                    ParameterType = "path",
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

        /// <summary>
        /// Returns a token for device enrollment. The DPC can encode this token within the QR/NFC/zero-touch enrollment
        /// payload or fetch it before calling the on-device API to authenticate the user. The token can be generated
        /// for each device or reused across multiple devices.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="enterpriseId">Required. The ID of the enterprise.</param>
        public virtual CreateRequest Create(Google.Apis.AndroidEnterprise.v1.Data.EnrollmentToken body, string enterpriseId)
        {
            return new CreateRequest(this.service, body, enterpriseId);
        }

        /// <summary>
        /// Returns a token for device enrollment. The DPC can encode this token within the QR/NFC/zero-touch enrollment
        /// payload or fetch it before calling the on-device API to authenticate the user. The token can be generated
        /// for each device or reused across multiple devices.
        /// </summary>
        public class CreateRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.EnrollmentToken>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidEnterprise.v1.Data.EnrollmentToken body, string enterpriseId) : base(service)
            {
                EnterpriseId = enterpriseId;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidEnterprise.v1.Data.EnrollmentToken Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/enrollmentTokens";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
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
        }

        /// <summary>
        /// Acknowledges notifications that were received from Enterprises.PullNotificationSet to prevent subsequent
        /// calls from returning the same notifications.
        /// </summary>
        public virtual AcknowledgeNotificationSetRequest AcknowledgeNotificationSet()
        {
            return new AcknowledgeNotificationSetRequest(this.service);
        }

        /// <summary>
        /// Acknowledges notifications that were received from Enterprises.PullNotificationSet to prevent subsequent
        /// calls from returning the same notifications.
        /// </summary>
        public class AcknowledgeNotificationSetRequest : AndroidEnterpriseBaseServiceRequest<string>
        {
            /// <summary>Constructs a new AcknowledgeNotificationSet request.</summary>
            public AcknowledgeNotificationSetRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// The notification set ID as returned by Enterprises.PullNotificationSet. This must be provided.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("notificationSetId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string NotificationSetId { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "acknowledgeNotificationSet";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/acknowledgeNotificationSet";

            /// <summary>Initializes AcknowledgeNotificationSet parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("notificationSetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "notificationSetId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Completes the signup flow, by specifying the Completion token and Enterprise token. This request must not be
        /// called multiple times for a given Enterprise Token.
        /// </summary>
        public virtual CompleteSignupRequest CompleteSignup()
        {
            return new CompleteSignupRequest(this.service);
        }

        /// <summary>
        /// Completes the signup flow, by specifying the Completion token and Enterprise token. This request must not be
        /// called multiple times for a given Enterprise Token.
        /// </summary>
        public class CompleteSignupRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.Enterprise>
        {
            /// <summary>Constructs a new CompleteSignup request.</summary>
            public CompleteSignupRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>The Completion token initially returned by GenerateSignupUrl.</summary>
            [Google.Apis.Util.RequestParameterAttribute("completionToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CompletionToken { get; set; }

            /// <summary>The Enterprise token appended to the Callback URL.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string EnterpriseToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "completeSignup";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/completeSignup";

            /// <summary>Initializes CompleteSignup parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("completionToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "completionToken",
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
            }
        }

        /// <summary>
        /// Returns a unique token to access an embeddable UI. To generate a web UI, pass the generated token into the
        /// managed Google Play javascript API. Each token may only be used to start one UI session. See the JavaScript
        /// API documentation for further information.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        public virtual CreateWebTokenRequest CreateWebToken(Google.Apis.AndroidEnterprise.v1.Data.AdministratorWebTokenSpec body, string enterpriseId)
        {
            return new CreateWebTokenRequest(this.service, body, enterpriseId);
        }

        /// <summary>
        /// Returns a unique token to access an embeddable UI. To generate a web UI, pass the generated token into the
        /// managed Google Play javascript API. Each token may only be used to start one UI session. See the JavaScript
        /// API documentation for further information.
        /// </summary>
        public class CreateWebTokenRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.AdministratorWebToken>
        {
            /// <summary>Constructs a new CreateWebToken request.</summary>
            public CreateWebTokenRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidEnterprise.v1.Data.AdministratorWebTokenSpec body, string enterpriseId) : base(service)
            {
                EnterpriseId = enterpriseId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidEnterprise.v1.Data.AdministratorWebTokenSpec Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "createWebToken";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/createWebToken";

            /// <summary>Initializes CreateWebToken parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Enrolls an enterprise with the calling EMM.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="token">Required. The token provided by the enterprise to register the EMM.</param>
        public virtual EnrollRequest Enroll(Google.Apis.AndroidEnterprise.v1.Data.Enterprise body, string token)
        {
            return new EnrollRequest(this.service, body, token);
        }

        /// <summary>Enrolls an enterprise with the calling EMM.</summary>
        public class EnrollRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.Enterprise>
        {
            /// <summary>Constructs a new Enroll request.</summary>
            public EnrollRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidEnterprise.v1.Data.Enterprise body, string token) : base(service)
            {
                Token = token;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The token provided by the enterprise to register the EMM.</summary>
            [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Token { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidEnterprise.v1.Data.Enterprise Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "enroll";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/enroll";

            /// <summary>Initializes Enroll parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                {
                    Name = "token",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Generates a sign-up URL.</summary>
        public virtual GenerateSignupUrlRequest GenerateSignupUrl()
        {
            return new GenerateSignupUrlRequest(this.service);
        }

        /// <summary>Generates a sign-up URL.</summary>
        public class GenerateSignupUrlRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.SignupInfo>
        {
            /// <summary>Constructs a new GenerateSignupUrl request.</summary>
            public GenerateSignupUrlRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional. Email address used to prefill the admin field of the enterprise signup form. This value is a
            /// hint only and can be altered by the user. If `allowedDomains` is non-empty then this must belong to one
            /// of the `allowedDomains`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("adminEmail", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string AdminEmail { get; set; }

            /// <summary>
            /// Optional. A list of domains that are permitted for the admin email. The IT admin cannot enter an email
            /// address with a domain name that is not in this list. Subdomains of domains in this list are not allowed
            /// but can be allowed by adding a second entry which has `*.` prefixed to the domain name (e.g.
            /// *.example.com). If the field is not present or is an empty list then the IT admin is free to use any
            /// valid domain name. Personal email domains are always allowed, but will result in the creation of a
            /// managed Google Play Accounts enterprise.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("allowedDomains", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> AllowedDomains { get; set; }

            /// <summary>
            /// The callback URL to which the Admin will be redirected after successfully creating an enterprise. Before
            /// redirecting there the system will add a single query parameter to this URL named "enterpriseToken" which
            /// will contain an opaque token to be used for the CompleteSignup request. Beware that this means that the
            /// URL will be parsed, the parameter added and then a new URL formatted, i.e. there may be some minor
            /// formatting changes and, more importantly, the URL must be well-formed so that it can be parsed.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("callbackUrl", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CallbackUrl { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "generateSignupUrl";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/signupUrl";

            /// <summary>Initializes GenerateSignupUrl parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("adminEmail", new Google.Apis.Discovery.Parameter
                {
                    Name = "adminEmail",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("allowedDomains", new Google.Apis.Discovery.Parameter
                {
                    Name = "allowedDomains",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("callbackUrl", new Google.Apis.Discovery.Parameter
                {
                    Name = "callbackUrl",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves the name and domain of an enterprise.</summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        public virtual GetRequest Get(string enterpriseId)
        {
            return new GetRequest(this.service, enterpriseId);
        }

        /// <summary>Retrieves the name and domain of an enterprise.</summary>
        public class GetRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.Enterprise>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string enterpriseId) : base(service)
            {
                EnterpriseId = enterpriseId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Returns a service account and credentials. The service account can be bound to the enterprise by calling
        /// setAccount. The service account is unique to this enterprise and EMM, and will be deleted if the enterprise
        /// is unbound. The credentials contain private key data and are not stored server-side. This method can only be
        /// called after calling Enterprises.Enroll or Enterprises.CompleteSignup, and before Enterprises.SetAccount; at
        /// other times it will return an error. Subsequent calls after the first will generate a new, unique set of
        /// credentials, and invalidate the previously generated credentials. Once the service account is bound to the
        /// enterprise, it can be managed using the serviceAccountKeys resource.
        /// </summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        public virtual GetServiceAccountRequest GetServiceAccount(string enterpriseId)
        {
            return new GetServiceAccountRequest(this.service, enterpriseId);
        }

        /// <summary>
        /// Returns a service account and credentials. The service account can be bound to the enterprise by calling
        /// setAccount. The service account is unique to this enterprise and EMM, and will be deleted if the enterprise
        /// is unbound. The credentials contain private key data and are not stored server-side. This method can only be
        /// called after calling Enterprises.Enroll or Enterprises.CompleteSignup, and before Enterprises.SetAccount; at
        /// other times it will return an error. Subsequent calls after the first will generate a new, unique set of
        /// credentials, and invalidate the previously generated credentials. Once the service account is bound to the
        /// enterprise, it can be managed using the serviceAccountKeys resource.
        /// </summary>
        public class GetServiceAccountRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.ServiceAccount>
        {
            /// <summary>Constructs a new GetServiceAccount request.</summary>
            public GetServiceAccountRequest(Google.Apis.Services.IClientService service, string enterpriseId) : base(service)
            {
                EnterpriseId = enterpriseId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The type of credential to return with the service account. Required.</summary>
            [Google.Apis.Util.RequestParameterAttribute("keyType", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<KeyTypeEnum> KeyType { get; set; }

            /// <summary>The type of credential to return with the service account. Required.</summary>
            public enum KeyTypeEnum
            {
                /// <summary>Google Credentials File format.</summary>
                [Google.Apis.Util.StringValueAttribute("googleCredentials")]
                GoogleCredentials = 0,

                /// <summary>
                /// PKCS12 format. The password for the PKCS12 file is 'notasecret'. For more information, see
                /// https://tools.ietf.org/html/rfc7292. The data for keys of this type are base64 encoded according to
                /// RFC 4648 Section 4. See http://tools.ietf.org/html/rfc4648#section-4.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("pkcs12")]
                Pkcs12 = 1,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getServiceAccount";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/serviceAccount";

            /// <summary>Initializes GetServiceAccount parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("keyType", new Google.Apis.Discovery.Parameter
                {
                    Name = "keyType",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Returns the store layout for the enterprise. If the store layout has not been set, returns "basic" as the
        /// store layout type and no homepage.
        /// </summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        public virtual GetStoreLayoutRequest GetStoreLayout(string enterpriseId)
        {
            return new GetStoreLayoutRequest(this.service, enterpriseId);
        }

        /// <summary>
        /// Returns the store layout for the enterprise. If the store layout has not been set, returns "basic" as the
        /// store layout type and no homepage.
        /// </summary>
        public class GetStoreLayoutRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.StoreLayout>
        {
            /// <summary>Constructs a new GetStoreLayout request.</summary>
            public GetStoreLayoutRequest(Google.Apis.Services.IClientService service, string enterpriseId) : base(service)
            {
                EnterpriseId = enterpriseId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getStoreLayout";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/storeLayout";

            /// <summary>Initializes GetStoreLayout parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Looks up an enterprise by domain name. This is only supported for enterprises created via the
        /// Google-initiated creation flow. Lookup of the id is not needed for enterprises created via the EMM-initiated
        /// flow since the EMM learns the enterprise ID in the callback specified in the Enterprises.generateSignupUrl
        /// call.
        /// </summary>
        /// <param name="domain">Required. The exact primary domain name of the enterprise to look up.</param>
        public virtual ListRequest List(string domain)
        {
            return new ListRequest(this.service, domain);
        }

        /// <summary>
        /// Looks up an enterprise by domain name. This is only supported for enterprises created via the
        /// Google-initiated creation flow. Lookup of the id is not needed for enterprises created via the EMM-initiated
        /// flow since the EMM learns the enterprise ID in the callback specified in the Enterprises.generateSignupUrl
        /// call.
        /// </summary>
        public class ListRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.EnterprisesListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string domain) : base(service)
            {
                Domain = domain;
                InitParameters();
            }

            /// <summary>Required. The exact primary domain name of the enterprise to look up.</summary>
            [Google.Apis.Util.RequestParameterAttribute("domain", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Domain { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("domain", new Google.Apis.Discovery.Parameter
                {
                    Name = "domain",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Pulls and returns a notification set for the enterprises associated with the service account authenticated
        /// for the request. The notification set may be empty if no notification are pending. A notification set
        /// returned needs to be acknowledged within 20 seconds by calling Enterprises.AcknowledgeNotificationSet,
        /// unless the notification set is empty. Notifications that are not acknowledged within the 20 seconds will
        /// eventually be included again in the response to another PullNotificationSet request, and those that are
        /// never acknowledged will ultimately be deleted according to the Google Cloud Platform Pub/Sub system policy.
        /// Multiple requests might be performed concurrently to retrieve notifications, in which case the pending
        /// notifications (if any) will be split among each caller, if any are pending. If no notifications are present,
        /// an empty notification list is returned. Subsequent requests may return more notifications once they become
        /// available.
        /// </summary>
        public virtual PullNotificationSetRequest PullNotificationSet()
        {
            return new PullNotificationSetRequest(this.service);
        }

        /// <summary>
        /// Pulls and returns a notification set for the enterprises associated with the service account authenticated
        /// for the request. The notification set may be empty if no notification are pending. A notification set
        /// returned needs to be acknowledged within 20 seconds by calling Enterprises.AcknowledgeNotificationSet,
        /// unless the notification set is empty. Notifications that are not acknowledged within the 20 seconds will
        /// eventually be included again in the response to another PullNotificationSet request, and those that are
        /// never acknowledged will ultimately be deleted according to the Google Cloud Platform Pub/Sub system policy.
        /// Multiple requests might be performed concurrently to retrieve notifications, in which case the pending
        /// notifications (if any) will be split among each caller, if any are pending. If no notifications are present,
        /// an empty notification list is returned. Subsequent requests may return more notifications once they become
        /// available.
        /// </summary>
        public class PullNotificationSetRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.NotificationSet>
        {
            /// <summary>Constructs a new PullNotificationSet request.</summary>
            public PullNotificationSetRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// The request mode for pulling notifications. Specifying waitForNotifications will cause the request to
            /// block and wait until one or more notifications are present, or return an empty notification list if no
            /// notifications are present after some time. Specifying returnImmediately will cause the request to
            /// immediately return the pending notifications, or an empty list if no notifications are present. If
            /// omitted, defaults to waitForNotifications.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("requestMode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<RequestModeEnum> RequestMode { get; set; }

            /// <summary>
            /// The request mode for pulling notifications. Specifying waitForNotifications will cause the request to
            /// block and wait until one or more notifications are present, or return an empty notification list if no
            /// notifications are present after some time. Specifying returnImmediately will cause the request to
            /// immediately return the pending notifications, or an empty list if no notifications are present. If
            /// omitted, defaults to waitForNotifications.
            /// </summary>
            public enum RequestModeEnum
            {
                /// <summary>Wait until one or more notifications are present.</summary>
                [Google.Apis.Util.StringValueAttribute("waitForNotifications")]
                WaitForNotifications = 0,

                /// <summary>Returns immediately whether notifications are present or not.</summary>
                [Google.Apis.Util.StringValueAttribute("returnImmediately")]
                ReturnImmediately = 1,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "pullNotificationSet";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/pullNotificationSet";

            /// <summary>Initializes PullNotificationSet parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("requestMode", new Google.Apis.Discovery.Parameter
                {
                    Name = "requestMode",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Sends a test notification to validate the EMM integration with the Google Cloud Pub/Sub service for this
        /// enterprise.
        /// </summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        public virtual SendTestPushNotificationRequest SendTestPushNotification(string enterpriseId)
        {
            return new SendTestPushNotificationRequest(this.service, enterpriseId);
        }

        /// <summary>
        /// Sends a test notification to validate the EMM integration with the Google Cloud Pub/Sub service for this
        /// enterprise.
        /// </summary>
        public class SendTestPushNotificationRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.EnterprisesSendTestPushNotificationResponse>
        {
            /// <summary>Constructs a new SendTestPushNotification request.</summary>
            public SendTestPushNotificationRequest(Google.Apis.Services.IClientService service, string enterpriseId) : base(service)
            {
                EnterpriseId = enterpriseId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "sendTestPushNotification";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/sendTestPushNotification";

            /// <summary>Initializes SendTestPushNotification parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Sets the account that will be used to authenticate to the API as the enterprise.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        public virtual SetAccountRequest SetAccount(Google.Apis.AndroidEnterprise.v1.Data.EnterpriseAccount body, string enterpriseId)
        {
            return new SetAccountRequest(this.service, body, enterpriseId);
        }

        /// <summary>Sets the account that will be used to authenticate to the API as the enterprise.</summary>
        public class SetAccountRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.EnterpriseAccount>
        {
            /// <summary>Constructs a new SetAccount request.</summary>
            public SetAccountRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidEnterprise.v1.Data.EnterpriseAccount body, string enterpriseId) : base(service)
            {
                EnterpriseId = enterpriseId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidEnterprise.v1.Data.EnterpriseAccount Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "setAccount";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/account";

            /// <summary>Initializes SetAccount parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Sets the store layout for the enterprise. By default, storeLayoutType is set to "basic" and the basic store
        /// layout is enabled. The basic layout only contains apps approved by the admin, and that have been added to
        /// the available product set for a user (using the setAvailableProductSet call). Apps on the page are sorted in
        /// order of their product ID value. If you create a custom store layout (by setting storeLayoutType = "custom"
        /// and setting a homepage), the basic store layout is disabled.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        public virtual SetStoreLayoutRequest SetStoreLayout(Google.Apis.AndroidEnterprise.v1.Data.StoreLayout body, string enterpriseId)
        {
            return new SetStoreLayoutRequest(this.service, body, enterpriseId);
        }

        /// <summary>
        /// Sets the store layout for the enterprise. By default, storeLayoutType is set to "basic" and the basic store
        /// layout is enabled. The basic layout only contains apps approved by the admin, and that have been added to
        /// the available product set for a user (using the setAvailableProductSet call). Apps on the page are sorted in
        /// order of their product ID value. If you create a custom store layout (by setting storeLayoutType = "custom"
        /// and setting a homepage), the basic store layout is disabled.
        /// </summary>
        public class SetStoreLayoutRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.StoreLayout>
        {
            /// <summary>Constructs a new SetStoreLayout request.</summary>
            public SetStoreLayoutRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidEnterprise.v1.Data.StoreLayout body, string enterpriseId) : base(service)
            {
                EnterpriseId = enterpriseId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidEnterprise.v1.Data.StoreLayout Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "setStoreLayout";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/storeLayout";

            /// <summary>Initializes SetStoreLayout parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Unenrolls an enterprise from the calling EMM.</summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        public virtual UnenrollRequest Unenroll(string enterpriseId)
        {
            return new UnenrollRequest(this.service, enterpriseId);
        }

        /// <summary>Unenrolls an enterprise from the calling EMM.</summary>
        public class UnenrollRequest : AndroidEnterpriseBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Unenroll request.</summary>
            public UnenrollRequest(Google.Apis.Services.IClientService service, string enterpriseId) : base(service)
            {
                EnterpriseId = enterpriseId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "unenroll";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/unenroll";

            /// <summary>Initializes Unenroll parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "entitlements" collection of methods.</summary>
    public class EntitlementsResource
    {
        private const string Resource = "entitlements";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public EntitlementsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Removes an entitlement to an app for a user. **Note:** This item has been deprecated. New integrations
        /// cannot use this method and can refer to our new recommendations.
        /// </summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        /// <param name="entitlementId">
        /// The ID of the entitlement (a product ID), e.g. "app:com.google.android.gm".
        /// </param>
        public virtual DeleteRequest Delete(string enterpriseId, string userId, string entitlementId)
        {
            return new DeleteRequest(this.service, enterpriseId, userId, entitlementId);
        }

        /// <summary>
        /// Removes an entitlement to an app for a user. **Note:** This item has been deprecated. New integrations
        /// cannot use this method and can refer to our new recommendations.
        /// </summary>
        public class DeleteRequest : AndroidEnterpriseBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string enterpriseId, string userId, string entitlementId) : base(service)
            {
                EnterpriseId = enterpriseId;
                UserId = userId;
                EntitlementId = entitlementId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            /// <summary>The ID of the entitlement (a product ID), e.g. "app:com.google.android.gm".</summary>
            [Google.Apis.Util.RequestParameterAttribute("entitlementId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EntitlementId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/users/{userId}/entitlements/{entitlementId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("entitlementId", new Google.Apis.Discovery.Parameter
                {
                    Name = "entitlementId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Retrieves details of an entitlement. **Note:** This item has been deprecated. New integrations cannot use
        /// this method and can refer to our new recommendations.
        /// </summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        /// <param name="entitlementId">
        /// The ID of the entitlement (a product ID), e.g. "app:com.google.android.gm".
        /// </param>
        public virtual GetRequest Get(string enterpriseId, string userId, string entitlementId)
        {
            return new GetRequest(this.service, enterpriseId, userId, entitlementId);
        }

        /// <summary>
        /// Retrieves details of an entitlement. **Note:** This item has been deprecated. New integrations cannot use
        /// this method and can refer to our new recommendations.
        /// </summary>
        public class GetRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.Entitlement>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string enterpriseId, string userId, string entitlementId) : base(service)
            {
                EnterpriseId = enterpriseId;
                UserId = userId;
                EntitlementId = entitlementId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            /// <summary>The ID of the entitlement (a product ID), e.g. "app:com.google.android.gm".</summary>
            [Google.Apis.Util.RequestParameterAttribute("entitlementId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EntitlementId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/users/{userId}/entitlements/{entitlementId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("entitlementId", new Google.Apis.Discovery.Parameter
                {
                    Name = "entitlementId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Lists all entitlements for the specified user. Only the ID is set. **Note:** This item has been deprecated.
        /// New integrations cannot use this method and can refer to our new recommendations.
        /// </summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        public virtual ListRequest List(string enterpriseId, string userId)
        {
            return new ListRequest(this.service, enterpriseId, userId);
        }

        /// <summary>
        /// Lists all entitlements for the specified user. Only the ID is set. **Note:** This item has been deprecated.
        /// New integrations cannot use this method and can refer to our new recommendations.
        /// </summary>
        public class ListRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.EntitlementsListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string enterpriseId, string userId) : base(service)
            {
                EnterpriseId = enterpriseId;
                UserId = userId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/users/{userId}/entitlements";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Adds or updates an entitlement to an app for a user. **Note:** This item has been deprecated. New
        /// integrations cannot use this method and can refer to our new recommendations.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        /// <param name="entitlementId">
        /// The ID of the entitlement (a product ID), e.g. "app:com.google.android.gm".
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.AndroidEnterprise.v1.Data.Entitlement body, string enterpriseId, string userId, string entitlementId)
        {
            return new UpdateRequest(this.service, body, enterpriseId, userId, entitlementId);
        }

        /// <summary>
        /// Adds or updates an entitlement to an app for a user. **Note:** This item has been deprecated. New
        /// integrations cannot use this method and can refer to our new recommendations.
        /// </summary>
        public class UpdateRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.Entitlement>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidEnterprise.v1.Data.Entitlement body, string enterpriseId, string userId, string entitlementId) : base(service)
            {
                EnterpriseId = enterpriseId;
                UserId = userId;
                EntitlementId = entitlementId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            /// <summary>The ID of the entitlement (a product ID), e.g. "app:com.google.android.gm".</summary>
            [Google.Apis.Util.RequestParameterAttribute("entitlementId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EntitlementId { get; private set; }

            /// <summary>
            /// Set to true to also install the product on all the user's devices where possible. Failure to install on
            /// one or more devices will not prevent this operation from returning successfully, as long as the
            /// entitlement was successfully assigned to the user.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("install", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Install { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidEnterprise.v1.Data.Entitlement Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/users/{userId}/entitlements/{entitlementId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("entitlementId", new Google.Apis.Discovery.Parameter
                {
                    Name = "entitlementId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("install", new Google.Apis.Discovery.Parameter
                {
                    Name = "install",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "grouplicenses" collection of methods.</summary>
    public class GrouplicensesResource
    {
        private const string Resource = "grouplicenses";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public GrouplicensesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Retrieves details of an enterprise's group license for a product. **Note:** This item has been deprecated.
        /// New integrations cannot use this method and can refer to our new recommendations.
        /// </summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="groupLicenseId">
        /// The ID of the product the group license is for, e.g. "app:com.google.android.gm".
        /// </param>
        public virtual GetRequest Get(string enterpriseId, string groupLicenseId)
        {
            return new GetRequest(this.service, enterpriseId, groupLicenseId);
        }

        /// <summary>
        /// Retrieves details of an enterprise's group license for a product. **Note:** This item has been deprecated.
        /// New integrations cannot use this method and can refer to our new recommendations.
        /// </summary>
        public class GetRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.GroupLicense>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string enterpriseId, string groupLicenseId) : base(service)
            {
                EnterpriseId = enterpriseId;
                GroupLicenseId = groupLicenseId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the product the group license is for, e.g. "app:com.google.android.gm".</summary>
            [Google.Apis.Util.RequestParameterAttribute("groupLicenseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string GroupLicenseId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/groupLicenses/{groupLicenseId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("groupLicenseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "groupLicenseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Retrieves IDs of all products for which the enterprise has a group license. **Note:** This item has been
        /// deprecated. New integrations cannot use this method and can refer to our new recommendations.
        /// </summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        public virtual ListRequest List(string enterpriseId)
        {
            return new ListRequest(this.service, enterpriseId);
        }

        /// <summary>
        /// Retrieves IDs of all products for which the enterprise has a group license. **Note:** This item has been
        /// deprecated. New integrations cannot use this method and can refer to our new recommendations.
        /// </summary>
        public class ListRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.GroupLicensesListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string enterpriseId) : base(service)
            {
                EnterpriseId = enterpriseId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/groupLicenses";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "grouplicenseusers" collection of methods.</summary>
    public class GrouplicenseusersResource
    {
        private const string Resource = "grouplicenseusers";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public GrouplicenseusersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Retrieves the IDs of the users who have been granted entitlements under the license. **Note:** This item has
        /// been deprecated. New integrations cannot use this method and can refer to our new recommendations.
        /// </summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="groupLicenseId">
        /// The ID of the product the group license is for, e.g. "app:com.google.android.gm".
        /// </param>
        public virtual ListRequest List(string enterpriseId, string groupLicenseId)
        {
            return new ListRequest(this.service, enterpriseId, groupLicenseId);
        }

        /// <summary>
        /// Retrieves the IDs of the users who have been granted entitlements under the license. **Note:** This item has
        /// been deprecated. New integrations cannot use this method and can refer to our new recommendations.
        /// </summary>
        public class ListRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.GroupLicenseUsersListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string enterpriseId, string groupLicenseId) : base(service)
            {
                EnterpriseId = enterpriseId;
                GroupLicenseId = groupLicenseId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the product the group license is for, e.g. "app:com.google.android.gm".</summary>
            [Google.Apis.Util.RequestParameterAttribute("groupLicenseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string GroupLicenseId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/groupLicenses/{groupLicenseId}/users";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("groupLicenseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "groupLicenseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "installs" collection of methods.</summary>
    public class InstallsResource
    {
        private const string Resource = "installs";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public InstallsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Requests to remove an app from a device. A call to get or list will still show the app as installed on the
        /// device until it is actually removed. A successful response indicates that a removal request has been sent to
        /// the device. The call will be considered successful even if the app is not present on the device (e.g. it was
        /// never installed, or was removed by the user).
        /// </summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        /// <param name="deviceId">The Android ID of the device.</param>
        /// <param name="installId">
        /// The ID of the product represented by the install, e.g. "app:com.google.android.gm".
        /// </param>
        public virtual DeleteRequest Delete(string enterpriseId, string userId, string deviceId, string installId)
        {
            return new DeleteRequest(this.service, enterpriseId, userId, deviceId, installId);
        }

        /// <summary>
        /// Requests to remove an app from a device. A call to get or list will still show the app as installed on the
        /// device until it is actually removed. A successful response indicates that a removal request has been sent to
        /// the device. The call will be considered successful even if the app is not present on the device (e.g. it was
        /// never installed, or was removed by the user).
        /// </summary>
        public class DeleteRequest : AndroidEnterpriseBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string enterpriseId, string userId, string deviceId, string installId) : base(service)
            {
                EnterpriseId = enterpriseId;
                UserId = userId;
                DeviceId = deviceId;
                InstallId = installId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            /// <summary>The Android ID of the device.</summary>
            [Google.Apis.Util.RequestParameterAttribute("deviceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DeviceId { get; private set; }

            /// <summary>The ID of the product represented by the install, e.g. "app:com.google.android.gm".</summary>
            [Google.Apis.Util.RequestParameterAttribute("installId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string InstallId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/users/{userId}/devices/{deviceId}/installs/{installId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("deviceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "deviceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("installId", new Google.Apis.Discovery.Parameter
                {
                    Name = "installId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves details of an installation of an app on a device.</summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        /// <param name="deviceId">The Android ID of the device.</param>
        /// <param name="installId">
        /// The ID of the product represented by the install, e.g. "app:com.google.android.gm".
        /// </param>
        public virtual GetRequest Get(string enterpriseId, string userId, string deviceId, string installId)
        {
            return new GetRequest(this.service, enterpriseId, userId, deviceId, installId);
        }

        /// <summary>Retrieves details of an installation of an app on a device.</summary>
        public class GetRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.Install>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string enterpriseId, string userId, string deviceId, string installId) : base(service)
            {
                EnterpriseId = enterpriseId;
                UserId = userId;
                DeviceId = deviceId;
                InstallId = installId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            /// <summary>The Android ID of the device.</summary>
            [Google.Apis.Util.RequestParameterAttribute("deviceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DeviceId { get; private set; }

            /// <summary>The ID of the product represented by the install, e.g. "app:com.google.android.gm".</summary>
            [Google.Apis.Util.RequestParameterAttribute("installId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string InstallId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/users/{userId}/devices/{deviceId}/installs/{installId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("deviceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "deviceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("installId", new Google.Apis.Discovery.Parameter
                {
                    Name = "installId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves the details of all apps installed on the specified device.</summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        /// <param name="deviceId">The Android ID of the device.</param>
        public virtual ListRequest List(string enterpriseId, string userId, string deviceId)
        {
            return new ListRequest(this.service, enterpriseId, userId, deviceId);
        }

        /// <summary>Retrieves the details of all apps installed on the specified device.</summary>
        public class ListRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.InstallsListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string enterpriseId, string userId, string deviceId) : base(service)
            {
                EnterpriseId = enterpriseId;
                UserId = userId;
                DeviceId = deviceId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            /// <summary>The Android ID of the device.</summary>
            [Google.Apis.Util.RequestParameterAttribute("deviceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DeviceId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/users/{userId}/devices/{deviceId}/installs";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("deviceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "deviceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Requests to install the latest version of an app to a device. If the app is already installed, then it is
        /// updated to the latest version if necessary.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        /// <param name="deviceId">The Android ID of the device.</param>
        /// <param name="installId">
        /// The ID of the product represented by the install, e.g. "app:com.google.android.gm".
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.AndroidEnterprise.v1.Data.Install body, string enterpriseId, string userId, string deviceId, string installId)
        {
            return new UpdateRequest(this.service, body, enterpriseId, userId, deviceId, installId);
        }

        /// <summary>
        /// Requests to install the latest version of an app to a device. If the app is already installed, then it is
        /// updated to the latest version if necessary.
        /// </summary>
        public class UpdateRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.Install>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidEnterprise.v1.Data.Install body, string enterpriseId, string userId, string deviceId, string installId) : base(service)
            {
                EnterpriseId = enterpriseId;
                UserId = userId;
                DeviceId = deviceId;
                InstallId = installId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            /// <summary>The Android ID of the device.</summary>
            [Google.Apis.Util.RequestParameterAttribute("deviceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DeviceId { get; private set; }

            /// <summary>The ID of the product represented by the install, e.g. "app:com.google.android.gm".</summary>
            [Google.Apis.Util.RequestParameterAttribute("installId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string InstallId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidEnterprise.v1.Data.Install Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/users/{userId}/devices/{deviceId}/installs/{installId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("deviceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "deviceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("installId", new Google.Apis.Discovery.Parameter
                {
                    Name = "installId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "managedconfigurationsfordevice" collection of methods.</summary>
    public class ManagedconfigurationsfordeviceResource
    {
        private const string Resource = "managedconfigurationsfordevice";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ManagedconfigurationsfordeviceResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Removes a per-device managed configuration for an app for the specified device.</summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        /// <param name="deviceId">The Android ID of the device.</param>
        /// <param name="managedConfigurationForDeviceId">
        /// The ID of the managed configuration (a product ID), e.g. "app:com.google.android.gm".
        /// </param>
        public virtual DeleteRequest Delete(string enterpriseId, string userId, string deviceId, string managedConfigurationForDeviceId)
        {
            return new DeleteRequest(this.service, enterpriseId, userId, deviceId, managedConfigurationForDeviceId);
        }

        /// <summary>Removes a per-device managed configuration for an app for the specified device.</summary>
        public class DeleteRequest : AndroidEnterpriseBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string enterpriseId, string userId, string deviceId, string managedConfigurationForDeviceId) : base(service)
            {
                EnterpriseId = enterpriseId;
                UserId = userId;
                DeviceId = deviceId;
                ManagedConfigurationForDeviceId = managedConfigurationForDeviceId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            /// <summary>The Android ID of the device.</summary>
            [Google.Apis.Util.RequestParameterAttribute("deviceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DeviceId { get; private set; }

            /// <summary>The ID of the managed configuration (a product ID), e.g. "app:com.google.android.gm".</summary>
            [Google.Apis.Util.RequestParameterAttribute("managedConfigurationForDeviceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ManagedConfigurationForDeviceId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/users/{userId}/devices/{deviceId}/managedConfigurationsForDevice/{managedConfigurationForDeviceId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("deviceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "deviceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("managedConfigurationForDeviceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "managedConfigurationForDeviceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves details of a per-device managed configuration.</summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        /// <param name="deviceId">The Android ID of the device.</param>
        /// <param name="managedConfigurationForDeviceId">
        /// The ID of the managed configuration (a product ID), e.g. "app:com.google.android.gm".
        /// </param>
        public virtual GetRequest Get(string enterpriseId, string userId, string deviceId, string managedConfigurationForDeviceId)
        {
            return new GetRequest(this.service, enterpriseId, userId, deviceId, managedConfigurationForDeviceId);
        }

        /// <summary>Retrieves details of a per-device managed configuration.</summary>
        public class GetRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.ManagedConfiguration>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string enterpriseId, string userId, string deviceId, string managedConfigurationForDeviceId) : base(service)
            {
                EnterpriseId = enterpriseId;
                UserId = userId;
                DeviceId = deviceId;
                ManagedConfigurationForDeviceId = managedConfigurationForDeviceId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            /// <summary>The Android ID of the device.</summary>
            [Google.Apis.Util.RequestParameterAttribute("deviceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DeviceId { get; private set; }

            /// <summary>The ID of the managed configuration (a product ID), e.g. "app:com.google.android.gm".</summary>
            [Google.Apis.Util.RequestParameterAttribute("managedConfigurationForDeviceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ManagedConfigurationForDeviceId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/users/{userId}/devices/{deviceId}/managedConfigurationsForDevice/{managedConfigurationForDeviceId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("deviceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "deviceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("managedConfigurationForDeviceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "managedConfigurationForDeviceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Lists all the per-device managed configurations for the specified device. Only the ID is set.
        /// </summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        /// <param name="deviceId">The Android ID of the device.</param>
        public virtual ListRequest List(string enterpriseId, string userId, string deviceId)
        {
            return new ListRequest(this.service, enterpriseId, userId, deviceId);
        }

        /// <summary>
        /// Lists all the per-device managed configurations for the specified device. Only the ID is set.
        /// </summary>
        public class ListRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.ManagedConfigurationsForDeviceListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string enterpriseId, string userId, string deviceId) : base(service)
            {
                EnterpriseId = enterpriseId;
                UserId = userId;
                DeviceId = deviceId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            /// <summary>The Android ID of the device.</summary>
            [Google.Apis.Util.RequestParameterAttribute("deviceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DeviceId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/users/{userId}/devices/{deviceId}/managedConfigurationsForDevice";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("deviceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "deviceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Adds or updates a per-device managed configuration for an app for the specified device.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        /// <param name="deviceId">The Android ID of the device.</param>
        /// <param name="managedConfigurationForDeviceId">
        /// The ID of the managed configuration (a product ID), e.g. "app:com.google.android.gm".
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.AndroidEnterprise.v1.Data.ManagedConfiguration body, string enterpriseId, string userId, string deviceId, string managedConfigurationForDeviceId)
        {
            return new UpdateRequest(this.service, body, enterpriseId, userId, deviceId, managedConfigurationForDeviceId);
        }

        /// <summary>Adds or updates a per-device managed configuration for an app for the specified device.</summary>
        public class UpdateRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.ManagedConfiguration>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidEnterprise.v1.Data.ManagedConfiguration body, string enterpriseId, string userId, string deviceId, string managedConfigurationForDeviceId) : base(service)
            {
                EnterpriseId = enterpriseId;
                UserId = userId;
                DeviceId = deviceId;
                ManagedConfigurationForDeviceId = managedConfigurationForDeviceId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            /// <summary>The Android ID of the device.</summary>
            [Google.Apis.Util.RequestParameterAttribute("deviceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DeviceId { get; private set; }

            /// <summary>The ID of the managed configuration (a product ID), e.g. "app:com.google.android.gm".</summary>
            [Google.Apis.Util.RequestParameterAttribute("managedConfigurationForDeviceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ManagedConfigurationForDeviceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidEnterprise.v1.Data.ManagedConfiguration Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/users/{userId}/devices/{deviceId}/managedConfigurationsForDevice/{managedConfigurationForDeviceId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("deviceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "deviceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("managedConfigurationForDeviceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "managedConfigurationForDeviceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "managedconfigurationsforuser" collection of methods.</summary>
    public class ManagedconfigurationsforuserResource
    {
        private const string Resource = "managedconfigurationsforuser";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ManagedconfigurationsforuserResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Removes a per-user managed configuration for an app for the specified user.</summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        /// <param name="managedConfigurationForUserId">
        /// The ID of the managed configuration (a product ID), e.g. "app:com.google.android.gm".
        /// </param>
        public virtual DeleteRequest Delete(string enterpriseId, string userId, string managedConfigurationForUserId)
        {
            return new DeleteRequest(this.service, enterpriseId, userId, managedConfigurationForUserId);
        }

        /// <summary>Removes a per-user managed configuration for an app for the specified user.</summary>
        public class DeleteRequest : AndroidEnterpriseBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string enterpriseId, string userId, string managedConfigurationForUserId) : base(service)
            {
                EnterpriseId = enterpriseId;
                UserId = userId;
                ManagedConfigurationForUserId = managedConfigurationForUserId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            /// <summary>The ID of the managed configuration (a product ID), e.g. "app:com.google.android.gm".</summary>
            [Google.Apis.Util.RequestParameterAttribute("managedConfigurationForUserId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ManagedConfigurationForUserId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/users/{userId}/managedConfigurationsForUser/{managedConfigurationForUserId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("managedConfigurationForUserId", new Google.Apis.Discovery.Parameter
                {
                    Name = "managedConfigurationForUserId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves details of a per-user managed configuration for an app for the specified user.</summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        /// <param name="managedConfigurationForUserId">
        /// The ID of the managed configuration (a product ID), e.g. "app:com.google.android.gm".
        /// </param>
        public virtual GetRequest Get(string enterpriseId, string userId, string managedConfigurationForUserId)
        {
            return new GetRequest(this.service, enterpriseId, userId, managedConfigurationForUserId);
        }

        /// <summary>Retrieves details of a per-user managed configuration for an app for the specified user.</summary>
        public class GetRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.ManagedConfiguration>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string enterpriseId, string userId, string managedConfigurationForUserId) : base(service)
            {
                EnterpriseId = enterpriseId;
                UserId = userId;
                ManagedConfigurationForUserId = managedConfigurationForUserId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            /// <summary>The ID of the managed configuration (a product ID), e.g. "app:com.google.android.gm".</summary>
            [Google.Apis.Util.RequestParameterAttribute("managedConfigurationForUserId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ManagedConfigurationForUserId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/users/{userId}/managedConfigurationsForUser/{managedConfigurationForUserId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("managedConfigurationForUserId", new Google.Apis.Discovery.Parameter
                {
                    Name = "managedConfigurationForUserId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists all the per-user managed configurations for the specified user. Only the ID is set.</summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        public virtual ListRequest List(string enterpriseId, string userId)
        {
            return new ListRequest(this.service, enterpriseId, userId);
        }

        /// <summary>Lists all the per-user managed configurations for the specified user. Only the ID is set.</summary>
        public class ListRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.ManagedConfigurationsForUserListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string enterpriseId, string userId) : base(service)
            {
                EnterpriseId = enterpriseId;
                UserId = userId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/users/{userId}/managedConfigurationsForUser";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Adds or updates the managed configuration settings for an app for the specified user. If you support the
        /// Managed configurations iframe, you can apply managed configurations to a user by specifying an mcmId and its
        /// associated configuration variables (if any) in the request. Alternatively, all EMMs can apply managed
        /// configurations by passing a list of managed properties.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        /// <param name="managedConfigurationForUserId">
        /// The ID of the managed configuration (a product ID), e.g. "app:com.google.android.gm".
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.AndroidEnterprise.v1.Data.ManagedConfiguration body, string enterpriseId, string userId, string managedConfigurationForUserId)
        {
            return new UpdateRequest(this.service, body, enterpriseId, userId, managedConfigurationForUserId);
        }

        /// <summary>
        /// Adds or updates the managed configuration settings for an app for the specified user. If you support the
        /// Managed configurations iframe, you can apply managed configurations to a user by specifying an mcmId and its
        /// associated configuration variables (if any) in the request. Alternatively, all EMMs can apply managed
        /// configurations by passing a list of managed properties.
        /// </summary>
        public class UpdateRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.ManagedConfiguration>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidEnterprise.v1.Data.ManagedConfiguration body, string enterpriseId, string userId, string managedConfigurationForUserId) : base(service)
            {
                EnterpriseId = enterpriseId;
                UserId = userId;
                ManagedConfigurationForUserId = managedConfigurationForUserId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            /// <summary>The ID of the managed configuration (a product ID), e.g. "app:com.google.android.gm".</summary>
            [Google.Apis.Util.RequestParameterAttribute("managedConfigurationForUserId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ManagedConfigurationForUserId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidEnterprise.v1.Data.ManagedConfiguration Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/users/{userId}/managedConfigurationsForUser/{managedConfigurationForUserId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("managedConfigurationForUserId", new Google.Apis.Discovery.Parameter
                {
                    Name = "managedConfigurationForUserId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "managedconfigurationssettings" collection of methods.</summary>
    public class ManagedconfigurationssettingsResource
    {
        private const string Resource = "managedconfigurationssettings";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ManagedconfigurationssettingsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Lists all the managed configurations settings for the specified app.</summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="productId">
        /// The ID of the product for which the managed configurations settings applies to.
        /// </param>
        public virtual ListRequest List(string enterpriseId, string productId)
        {
            return new ListRequest(this.service, enterpriseId, productId);
        }

        /// <summary>Lists all the managed configurations settings for the specified app.</summary>
        public class ListRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.ManagedConfigurationsSettingsListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string enterpriseId, string productId) : base(service)
            {
                EnterpriseId = enterpriseId;
                ProductId = productId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the product for which the managed configurations settings applies to.</summary>
            [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProductId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/products/{productId}/managedConfigurationsSettings";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                {
                    Name = "productId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "permissions" collection of methods.</summary>
    public class PermissionsResource
    {
        private const string Resource = "permissions";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PermissionsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Retrieves details of an Android app permission for display to an enterprise admin.</summary>
        /// <param name="permissionId">The ID of the permission.</param>
        public virtual GetRequest Get(string permissionId)
        {
            return new GetRequest(this.service, permissionId);
        }

        /// <summary>Retrieves details of an Android app permission for display to an enterprise admin.</summary>
        public class GetRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.Permission>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string permissionId) : base(service)
            {
                PermissionId = permissionId;
                InitParameters();
            }

            /// <summary>The ID of the permission.</summary>
            [Google.Apis.Util.RequestParameterAttribute("permissionId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PermissionId { get; private set; }

            /// <summary>The BCP47 tag for the user's preferred language (e.g. "en-US", "de")</summary>
            [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Language { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/permissions/{permissionId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("permissionId", new Google.Apis.Discovery.Parameter
                {
                    Name = "permissionId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("language", new Google.Apis.Discovery.Parameter
                {
                    Name = "language",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "products" collection of methods.</summary>
    public class ProductsResource
    {
        private const string Resource = "products";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ProductsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        ///  Approves the specified product and the relevant app permissions, if any. The maximum number of products
        /// that you can approve per enterprise customer is 1,000. To learn how to use managed Google Play to design and
        /// create a store layout to display approved products to your users, see Store Layout Design. **Note:** This
        /// item has been deprecated. New integrations cannot use this method and can refer to our new recommendations.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="productId">The ID of the product.</param>
        public virtual ApproveRequest Approve(Google.Apis.AndroidEnterprise.v1.Data.ProductsApproveRequest body, string enterpriseId, string productId)
        {
            return new ApproveRequest(this.service, body, enterpriseId, productId);
        }

        /// <summary>
        ///  Approves the specified product and the relevant app permissions, if any. The maximum number of products
        /// that you can approve per enterprise customer is 1,000. To learn how to use managed Google Play to design and
        /// create a store layout to display approved products to your users, see Store Layout Design. **Note:** This
        /// item has been deprecated. New integrations cannot use this method and can refer to our new recommendations.
        /// </summary>
        public class ApproveRequest : AndroidEnterpriseBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Approve request.</summary>
            public ApproveRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidEnterprise.v1.Data.ProductsApproveRequest body, string enterpriseId, string productId) : base(service)
            {
                EnterpriseId = enterpriseId;
                ProductId = productId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the product.</summary>
            [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProductId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidEnterprise.v1.Data.ProductsApproveRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "approve";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/products/{productId}/approve";

            /// <summary>Initializes Approve parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                {
                    Name = "productId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Generates a URL that can be rendered in an iframe to display the permissions (if any) of a product. An
        /// enterprise admin must view these permissions and accept them on behalf of their organization in order to
        /// approve that product. Admins should accept the displayed permissions by interacting with a separate UI
        /// element in the EMM console, which in turn should trigger the use of this URL as the
        /// approvalUrlInfo.approvalUrl property in a Products.approve call to approve the product. This URL can only be
        /// used to display permissions for up to 1 day. **Note:** This item has been deprecated. New integrations
        /// cannot use this method and can refer to our new recommendations.
        /// </summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="productId">The ID of the product.</param>
        public virtual GenerateApprovalUrlRequest GenerateApprovalUrl(string enterpriseId, string productId)
        {
            return new GenerateApprovalUrlRequest(this.service, enterpriseId, productId);
        }

        /// <summary>
        /// Generates a URL that can be rendered in an iframe to display the permissions (if any) of a product. An
        /// enterprise admin must view these permissions and accept them on behalf of their organization in order to
        /// approve that product. Admins should accept the displayed permissions by interacting with a separate UI
        /// element in the EMM console, which in turn should trigger the use of this URL as the
        /// approvalUrlInfo.approvalUrl property in a Products.approve call to approve the product. This URL can only be
        /// used to display permissions for up to 1 day. **Note:** This item has been deprecated. New integrations
        /// cannot use this method and can refer to our new recommendations.
        /// </summary>
        public class GenerateApprovalUrlRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.ProductsGenerateApprovalUrlResponse>
        {
            /// <summary>Constructs a new GenerateApprovalUrl request.</summary>
            public GenerateApprovalUrlRequest(Google.Apis.Services.IClientService service, string enterpriseId, string productId) : base(service)
            {
                EnterpriseId = enterpriseId;
                ProductId = productId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the product.</summary>
            [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProductId { get; private set; }

            /// <summary>
            /// The BCP 47 language code used for permission names and descriptions in the returned iframe, for instance
            /// "en-US".
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string LanguageCode { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "generateApprovalUrl";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/products/{productId}/generateApprovalUrl";

            /// <summary>Initializes GenerateApprovalUrl parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                {
                    Name = "productId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
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

        /// <summary>Retrieves details of a product for display to an enterprise admin.</summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="productId">The ID of the product, e.g. "app:com.google.android.gm".</param>
        public virtual GetRequest Get(string enterpriseId, string productId)
        {
            return new GetRequest(this.service, enterpriseId, productId);
        }

        /// <summary>Retrieves details of a product for display to an enterprise admin.</summary>
        public class GetRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.Product>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string enterpriseId, string productId) : base(service)
            {
                EnterpriseId = enterpriseId;
                ProductId = productId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the product, e.g. "app:com.google.android.gm".</summary>
            [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProductId { get; private set; }

            /// <summary>The BCP47 tag for the user's preferred language (e.g. "en-US", "de").</summary>
            [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Language { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/products/{productId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                {
                    Name = "productId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("language", new Google.Apis.Discovery.Parameter
                {
                    Name = "language",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Retrieves the schema that defines the configurable properties for this product. All products have a schema,
        /// but this schema may be empty if no managed configurations have been defined. This schema can be used to
        /// populate a UI that allows an admin to configure the product. To apply a managed configuration based on the
        /// schema obtained using this API, see Managed Configurations through Play.
        /// </summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="productId">The ID of the product.</param>
        public virtual GetAppRestrictionsSchemaRequest GetAppRestrictionsSchema(string enterpriseId, string productId)
        {
            return new GetAppRestrictionsSchemaRequest(this.service, enterpriseId, productId);
        }

        /// <summary>
        /// Retrieves the schema that defines the configurable properties for this product. All products have a schema,
        /// but this schema may be empty if no managed configurations have been defined. This schema can be used to
        /// populate a UI that allows an admin to configure the product. To apply a managed configuration based on the
        /// schema obtained using this API, see Managed Configurations through Play.
        /// </summary>
        public class GetAppRestrictionsSchemaRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.AppRestrictionsSchema>
        {
            /// <summary>Constructs a new GetAppRestrictionsSchema request.</summary>
            public GetAppRestrictionsSchemaRequest(Google.Apis.Services.IClientService service, string enterpriseId, string productId) : base(service)
            {
                EnterpriseId = enterpriseId;
                ProductId = productId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the product.</summary>
            [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProductId { get; private set; }

            /// <summary>The BCP47 tag for the user's preferred language (e.g. "en-US", "de").</summary>
            [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Language { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getAppRestrictionsSchema";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/products/{productId}/appRestrictionsSchema";

            /// <summary>Initializes GetAppRestrictionsSchema parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                {
                    Name = "productId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("language", new Google.Apis.Discovery.Parameter
                {
                    Name = "language",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves the Android app permissions required by this app.</summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="productId">The ID of the product.</param>
        public virtual GetPermissionsRequest GetPermissions(string enterpriseId, string productId)
        {
            return new GetPermissionsRequest(this.service, enterpriseId, productId);
        }

        /// <summary>Retrieves the Android app permissions required by this app.</summary>
        public class GetPermissionsRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.ProductPermissions>
        {
            /// <summary>Constructs a new GetPermissions request.</summary>
            public GetPermissionsRequest(Google.Apis.Services.IClientService service, string enterpriseId, string productId) : base(service)
            {
                EnterpriseId = enterpriseId;
                ProductId = productId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the product.</summary>
            [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProductId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getPermissions";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/products/{productId}/permissions";

            /// <summary>Initializes GetPermissions parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                {
                    Name = "productId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Finds approved products that match a query, or all approved products if there is no query. **Note:** This
        /// item has been deprecated. New integrations cannot use this method and can refer to our new recommendations.
        /// </summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        public virtual ListRequest List(string enterpriseId)
        {
            return new ListRequest(this.service, enterpriseId);
        }

        /// <summary>
        /// Finds approved products that match a query, or all approved products if there is no query. **Note:** This
        /// item has been deprecated. New integrations cannot use this method and can refer to our new recommendations.
        /// </summary>
        public class ListRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.ProductsListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string enterpriseId) : base(service)
            {
                EnterpriseId = enterpriseId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>
            /// Specifies whether to search among all products (false) or among only products that have been approved
            /// (true). Only "true" is supported, and should be specified.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("approved", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Approved { get; set; }

            /// <summary>
            /// The BCP47 tag for the user's preferred language (e.g. "en-US", "de"). Results are returned in the
            /// language best matching the preferred language.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Language { get; set; }

            /// <summary>
            /// Defines how many results the list operation should return. The default number depends on the resource
            /// collection.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>
            /// The search query as typed in the Google Play store search box. If omitted, all approved apps will be
            /// returned (using the pagination parameters), including apps that are not available in the store (e.g.
            /// unpublished apps).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query { get; set; }

            /// <summary>
            /// Defines the token of the page to return, usually taken from TokenPagination. This can only be used if
            /// token paging is enabled.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Token { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/products";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("approved", new Google.Apis.Discovery.Parameter
                {
                    Name = "approved",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("language", new Google.Apis.Discovery.Parameter
                {
                    Name = "language",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("query", new Google.Apis.Discovery.Parameter
                {
                    Name = "query",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                {
                    Name = "token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Unapproves the specified product (and the relevant app permissions, if any) **Note:** This item has been
        /// deprecated. New integrations cannot use this method and can refer to our new recommendations.
        /// </summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="productId">The ID of the product.</param>
        public virtual UnapproveRequest Unapprove(string enterpriseId, string productId)
        {
            return new UnapproveRequest(this.service, enterpriseId, productId);
        }

        /// <summary>
        /// Unapproves the specified product (and the relevant app permissions, if any) **Note:** This item has been
        /// deprecated. New integrations cannot use this method and can refer to our new recommendations.
        /// </summary>
        public class UnapproveRequest : AndroidEnterpriseBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Unapprove request.</summary>
            public UnapproveRequest(Google.Apis.Services.IClientService service, string enterpriseId, string productId) : base(service)
            {
                EnterpriseId = enterpriseId;
                ProductId = productId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the product.</summary>
            [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProductId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "unapprove";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/products/{productId}/unapprove";

            /// <summary>Initializes Unapprove parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                {
                    Name = "productId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "serviceaccountkeys" collection of methods.</summary>
    public class ServiceaccountkeysResource
    {
        private const string Resource = "serviceaccountkeys";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ServiceaccountkeysResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Removes and invalidates the specified credentials for the service account associated with this enterprise.
        /// The calling service account must have been retrieved by calling Enterprises.GetServiceAccount and must have
        /// been set as the enterprise service account by calling Enterprises.SetAccount.
        /// </summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="keyId">The ID of the key.</param>
        public virtual DeleteRequest Delete(string enterpriseId, string keyId)
        {
            return new DeleteRequest(this.service, enterpriseId, keyId);
        }

        /// <summary>
        /// Removes and invalidates the specified credentials for the service account associated with this enterprise.
        /// The calling service account must have been retrieved by calling Enterprises.GetServiceAccount and must have
        /// been set as the enterprise service account by calling Enterprises.SetAccount.
        /// </summary>
        public class DeleteRequest : AndroidEnterpriseBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string enterpriseId, string keyId) : base(service)
            {
                EnterpriseId = enterpriseId;
                KeyId = keyId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the key.</summary>
            [Google.Apis.Util.RequestParameterAttribute("keyId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string KeyId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/serviceAccountKeys/{keyId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("keyId", new Google.Apis.Discovery.Parameter
                {
                    Name = "keyId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Generates new credentials for the service account associated with this enterprise. The calling service
        /// account must have been retrieved by calling Enterprises.GetServiceAccount and must have been set as the
        /// enterprise service account by calling Enterprises.SetAccount. Only the type of the key should be populated
        /// in the resource to be inserted.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        public virtual InsertRequest Insert(Google.Apis.AndroidEnterprise.v1.Data.ServiceAccountKey body, string enterpriseId)
        {
            return new InsertRequest(this.service, body, enterpriseId);
        }

        /// <summary>
        /// Generates new credentials for the service account associated with this enterprise. The calling service
        /// account must have been retrieved by calling Enterprises.GetServiceAccount and must have been set as the
        /// enterprise service account by calling Enterprises.SetAccount. Only the type of the key should be populated
        /// in the resource to be inserted.
        /// </summary>
        public class InsertRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.ServiceAccountKey>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidEnterprise.v1.Data.ServiceAccountKey body, string enterpriseId) : base(service)
            {
                EnterpriseId = enterpriseId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidEnterprise.v1.Data.ServiceAccountKey Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/serviceAccountKeys";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Lists all active credentials for the service account associated with this enterprise. Only the ID and key
        /// type are returned. The calling service account must have been retrieved by calling
        /// Enterprises.GetServiceAccount and must have been set as the enterprise service account by calling
        /// Enterprises.SetAccount.
        /// </summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        public virtual ListRequest List(string enterpriseId)
        {
            return new ListRequest(this.service, enterpriseId);
        }

        /// <summary>
        /// Lists all active credentials for the service account associated with this enterprise. Only the ID and key
        /// type are returned. The calling service account must have been retrieved by calling
        /// Enterprises.GetServiceAccount and must have been set as the enterprise service account by calling
        /// Enterprises.SetAccount.
        /// </summary>
        public class ListRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.ServiceAccountKeysListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string enterpriseId) : base(service)
            {
                EnterpriseId = enterpriseId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/serviceAccountKeys";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "storelayoutclusters" collection of methods.</summary>
    public class StorelayoutclustersResource
    {
        private const string Resource = "storelayoutclusters";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public StorelayoutclustersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Deletes a cluster.</summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="pageId">The ID of the page.</param>
        /// <param name="clusterId">The ID of the cluster.</param>
        public virtual DeleteRequest Delete(string enterpriseId, string pageId, string clusterId)
        {
            return new DeleteRequest(this.service, enterpriseId, pageId, clusterId);
        }

        /// <summary>Deletes a cluster.</summary>
        public class DeleteRequest : AndroidEnterpriseBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string enterpriseId, string pageId, string clusterId) : base(service)
            {
                EnterpriseId = enterpriseId;
                PageId = pageId;
                ClusterId = clusterId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the page.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PageId { get; private set; }

            /// <summary>The ID of the cluster.</summary>
            [Google.Apis.Util.RequestParameterAttribute("clusterId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ClusterId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/storeLayout/pages/{pageId}/clusters/{clusterId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pageId", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clusterId", new Google.Apis.Discovery.Parameter
                {
                    Name = "clusterId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves details of a cluster.</summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="pageId">The ID of the page.</param>
        /// <param name="clusterId">The ID of the cluster.</param>
        public virtual GetRequest Get(string enterpriseId, string pageId, string clusterId)
        {
            return new GetRequest(this.service, enterpriseId, pageId, clusterId);
        }

        /// <summary>Retrieves details of a cluster.</summary>
        public class GetRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.StoreCluster>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string enterpriseId, string pageId, string clusterId) : base(service)
            {
                EnterpriseId = enterpriseId;
                PageId = pageId;
                ClusterId = clusterId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the page.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PageId { get; private set; }

            /// <summary>The ID of the cluster.</summary>
            [Google.Apis.Util.RequestParameterAttribute("clusterId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ClusterId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/storeLayout/pages/{pageId}/clusters/{clusterId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pageId", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clusterId", new Google.Apis.Discovery.Parameter
                {
                    Name = "clusterId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts a new cluster in a page.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="pageId">The ID of the page.</param>
        public virtual InsertRequest Insert(Google.Apis.AndroidEnterprise.v1.Data.StoreCluster body, string enterpriseId, string pageId)
        {
            return new InsertRequest(this.service, body, enterpriseId, pageId);
        }

        /// <summary>Inserts a new cluster in a page.</summary>
        public class InsertRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.StoreCluster>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidEnterprise.v1.Data.StoreCluster body, string enterpriseId, string pageId) : base(service)
            {
                EnterpriseId = enterpriseId;
                PageId = pageId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the page.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PageId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidEnterprise.v1.Data.StoreCluster Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/storeLayout/pages/{pageId}/clusters";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pageId", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves the details of all clusters on the specified page.</summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="pageId">The ID of the page.</param>
        public virtual ListRequest List(string enterpriseId, string pageId)
        {
            return new ListRequest(this.service, enterpriseId, pageId);
        }

        /// <summary>Retrieves the details of all clusters on the specified page.</summary>
        public class ListRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.StoreLayoutClustersListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string enterpriseId, string pageId) : base(service)
            {
                EnterpriseId = enterpriseId;
                PageId = pageId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the page.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PageId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/storeLayout/pages/{pageId}/clusters";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pageId", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates a cluster.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="pageId">The ID of the page.</param>
        /// <param name="clusterId">The ID of the cluster.</param>
        public virtual UpdateRequest Update(Google.Apis.AndroidEnterprise.v1.Data.StoreCluster body, string enterpriseId, string pageId, string clusterId)
        {
            return new UpdateRequest(this.service, body, enterpriseId, pageId, clusterId);
        }

        /// <summary>Updates a cluster.</summary>
        public class UpdateRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.StoreCluster>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidEnterprise.v1.Data.StoreCluster body, string enterpriseId, string pageId, string clusterId) : base(service)
            {
                EnterpriseId = enterpriseId;
                PageId = pageId;
                ClusterId = clusterId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the page.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PageId { get; private set; }

            /// <summary>The ID of the cluster.</summary>
            [Google.Apis.Util.RequestParameterAttribute("clusterId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ClusterId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidEnterprise.v1.Data.StoreCluster Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/storeLayout/pages/{pageId}/clusters/{clusterId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pageId", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clusterId", new Google.Apis.Discovery.Parameter
                {
                    Name = "clusterId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "storelayoutpages" collection of methods.</summary>
    public class StorelayoutpagesResource
    {
        private const string Resource = "storelayoutpages";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public StorelayoutpagesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Deletes a store page.</summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="pageId">The ID of the page.</param>
        public virtual DeleteRequest Delete(string enterpriseId, string pageId)
        {
            return new DeleteRequest(this.service, enterpriseId, pageId);
        }

        /// <summary>Deletes a store page.</summary>
        public class DeleteRequest : AndroidEnterpriseBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string enterpriseId, string pageId) : base(service)
            {
                EnterpriseId = enterpriseId;
                PageId = pageId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the page.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PageId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/storeLayout/pages/{pageId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pageId", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves details of a store page.</summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="pageId">The ID of the page.</param>
        public virtual GetRequest Get(string enterpriseId, string pageId)
        {
            return new GetRequest(this.service, enterpriseId, pageId);
        }

        /// <summary>Retrieves details of a store page.</summary>
        public class GetRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.StorePage>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string enterpriseId, string pageId) : base(service)
            {
                EnterpriseId = enterpriseId;
                PageId = pageId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the page.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PageId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/storeLayout/pages/{pageId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pageId", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts a new store page.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        public virtual InsertRequest Insert(Google.Apis.AndroidEnterprise.v1.Data.StorePage body, string enterpriseId)
        {
            return new InsertRequest(this.service, body, enterpriseId);
        }

        /// <summary>Inserts a new store page.</summary>
        public class InsertRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.StorePage>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidEnterprise.v1.Data.StorePage body, string enterpriseId) : base(service)
            {
                EnterpriseId = enterpriseId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidEnterprise.v1.Data.StorePage Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/storeLayout/pages";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves the details of all pages in the store.</summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        public virtual ListRequest List(string enterpriseId)
        {
            return new ListRequest(this.service, enterpriseId);
        }

        /// <summary>Retrieves the details of all pages in the store.</summary>
        public class ListRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.StoreLayoutPagesListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string enterpriseId) : base(service)
            {
                EnterpriseId = enterpriseId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/storeLayout/pages";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates the content of a store page.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="pageId">The ID of the page.</param>
        public virtual UpdateRequest Update(Google.Apis.AndroidEnterprise.v1.Data.StorePage body, string enterpriseId, string pageId)
        {
            return new UpdateRequest(this.service, body, enterpriseId, pageId);
        }

        /// <summary>Updates the content of a store page.</summary>
        public class UpdateRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.StorePage>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidEnterprise.v1.Data.StorePage body, string enterpriseId, string pageId) : base(service)
            {
                EnterpriseId = enterpriseId;
                PageId = pageId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the page.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PageId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidEnterprise.v1.Data.StorePage Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/storeLayout/pages/{pageId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pageId", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "users" collection of methods.</summary>
    public class UsersResource
    {
        private const string Resource = "users";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public UsersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Deleted an EMM-managed user.</summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        public virtual DeleteRequest Delete(string enterpriseId, string userId)
        {
            return new DeleteRequest(this.service, enterpriseId, userId);
        }

        /// <summary>Deleted an EMM-managed user.</summary>
        public class DeleteRequest : AndroidEnterpriseBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string enterpriseId, string userId) : base(service)
            {
                EnterpriseId = enterpriseId;
                UserId = userId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/users/{userId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Generates an authentication token which the device policy client can use to provision the given EMM-managed
        /// user account on a device. The generated token is single-use and expires after a few minutes. You can
        /// provision a maximum of 10 devices per user. This call only works with EMM-managed accounts.
        /// </summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        public virtual GenerateAuthenticationTokenRequest GenerateAuthenticationToken(string enterpriseId, string userId)
        {
            return new GenerateAuthenticationTokenRequest(this.service, enterpriseId, userId);
        }

        /// <summary>
        /// Generates an authentication token which the device policy client can use to provision the given EMM-managed
        /// user account on a device. The generated token is single-use and expires after a few minutes. You can
        /// provision a maximum of 10 devices per user. This call only works with EMM-managed accounts.
        /// </summary>
        public class GenerateAuthenticationTokenRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.AuthenticationToken>
        {
            /// <summary>Constructs a new GenerateAuthenticationToken request.</summary>
            public GenerateAuthenticationTokenRequest(Google.Apis.Services.IClientService service, string enterpriseId, string userId) : base(service)
            {
                EnterpriseId = enterpriseId;
                UserId = userId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "generateAuthenticationToken";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/users/{userId}/authenticationToken";

            /// <summary>Initializes GenerateAuthenticationToken parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves a user's details.</summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        public virtual GetRequest Get(string enterpriseId, string userId)
        {
            return new GetRequest(this.service, enterpriseId, userId);
        }

        /// <summary>Retrieves a user's details.</summary>
        public class GetRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.User>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string enterpriseId, string userId) : base(service)
            {
                EnterpriseId = enterpriseId;
                UserId = userId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/users/{userId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Retrieves the set of products a user is entitled to access. **Note:** This item has been deprecated. New
        /// integrations cannot use this method and can refer to our new recommendations.
        /// </summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        public virtual GetAvailableProductSetRequest GetAvailableProductSet(string enterpriseId, string userId)
        {
            return new GetAvailableProductSetRequest(this.service, enterpriseId, userId);
        }

        /// <summary>
        /// Retrieves the set of products a user is entitled to access. **Note:** This item has been deprecated. New
        /// integrations cannot use this method and can refer to our new recommendations.
        /// </summary>
        public class GetAvailableProductSetRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.ProductSet>
        {
            /// <summary>Constructs a new GetAvailableProductSet request.</summary>
            public GetAvailableProductSetRequest(Google.Apis.Services.IClientService service, string enterpriseId, string userId) : base(service)
            {
                EnterpriseId = enterpriseId;
                UserId = userId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getAvailableProductSet";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/users/{userId}/availableProductSet";

            /// <summary>Initializes GetAvailableProductSet parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Creates a new EMM-managed user. The Users resource passed in the body of the request should include an
        /// accountIdentifier and an accountType. If a corresponding user already exists with the same account
        /// identifier, the user will be updated with the resource. In this case only the displayName field can be
        /// changed.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        public virtual InsertRequest Insert(Google.Apis.AndroidEnterprise.v1.Data.User body, string enterpriseId)
        {
            return new InsertRequest(this.service, body, enterpriseId);
        }

        /// <summary>
        /// Creates a new EMM-managed user. The Users resource passed in the body of the request should include an
        /// accountIdentifier and an accountType. If a corresponding user already exists with the same account
        /// identifier, the user will be updated with the resource. In this case only the displayName field can be
        /// changed.
        /// </summary>
        public class InsertRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.User>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidEnterprise.v1.Data.User body, string enterpriseId) : base(service)
            {
                EnterpriseId = enterpriseId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidEnterprise.v1.Data.User Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/users";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Looks up a user by primary email address. This is only supported for Google-managed users. Lookup of the id
        /// is not needed for EMM-managed users because the id is already returned in the result of the Users.insert
        /// call.
        /// </summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="email">Required. The exact primary email address of the user to look up.</param>
        public virtual ListRequest List(string enterpriseId, string email)
        {
            return new ListRequest(this.service, enterpriseId, email);
        }

        /// <summary>
        /// Looks up a user by primary email address. This is only supported for Google-managed users. Lookup of the id
        /// is not needed for EMM-managed users because the id is already returned in the result of the Users.insert
        /// call.
        /// </summary>
        public class ListRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.UsersListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string enterpriseId, string email) : base(service)
            {
                EnterpriseId = enterpriseId;
                Email = email;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>Required. The exact primary email address of the user to look up.</summary>
            [Google.Apis.Util.RequestParameterAttribute("email", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Email { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/users";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("email", new Google.Apis.Discovery.Parameter
                {
                    Name = "email",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Revokes access to all devices currently provisioned to the user. The user will no longer be able to use the
        /// managed Play store on any of their managed devices. This call only works with EMM-managed accounts.
        /// </summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        public virtual RevokeDeviceAccessRequest RevokeDeviceAccess(string enterpriseId, string userId)
        {
            return new RevokeDeviceAccessRequest(this.service, enterpriseId, userId);
        }

        /// <summary>
        /// Revokes access to all devices currently provisioned to the user. The user will no longer be able to use the
        /// managed Play store on any of their managed devices. This call only works with EMM-managed accounts.
        /// </summary>
        public class RevokeDeviceAccessRequest : AndroidEnterpriseBaseServiceRequest<string>
        {
            /// <summary>Constructs a new RevokeDeviceAccess request.</summary>
            public RevokeDeviceAccessRequest(Google.Apis.Services.IClientService service, string enterpriseId, string userId) : base(service)
            {
                EnterpriseId = enterpriseId;
                UserId = userId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "revokeDeviceAccess";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/users/{userId}/deviceAccess";

            /// <summary>Initializes RevokeDeviceAccess parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Modifies the set of products that a user is entitled to access (referred to as *whitelisted* products). Only
        /// products that are approved or products that were previously approved (products with revoked approval) can be
        /// whitelisted. **Note:** This item has been deprecated. New integrations cannot use this method and can refer
        /// to our new recommendations.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        public virtual SetAvailableProductSetRequest SetAvailableProductSet(Google.Apis.AndroidEnterprise.v1.Data.ProductSet body, string enterpriseId, string userId)
        {
            return new SetAvailableProductSetRequest(this.service, body, enterpriseId, userId);
        }

        /// <summary>
        /// Modifies the set of products that a user is entitled to access (referred to as *whitelisted* products). Only
        /// products that are approved or products that were previously approved (products with revoked approval) can be
        /// whitelisted. **Note:** This item has been deprecated. New integrations cannot use this method and can refer
        /// to our new recommendations.
        /// </summary>
        public class SetAvailableProductSetRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.ProductSet>
        {
            /// <summary>Constructs a new SetAvailableProductSet request.</summary>
            public SetAvailableProductSetRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidEnterprise.v1.Data.ProductSet body, string enterpriseId, string userId) : base(service)
            {
                EnterpriseId = enterpriseId;
                UserId = userId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidEnterprise.v1.Data.ProductSet Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "setAvailableProductSet";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/users/{userId}/availableProductSet";

            /// <summary>Initializes SetAvailableProductSet parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates the details of an EMM-managed user. Can be used with EMM-managed users only (not Google managed
        /// users). Pass the new details in the Users resource in the request body. Only the displayName field can be
        /// changed. Other fields must either be unset or have the currently active value.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        public virtual UpdateRequest Update(Google.Apis.AndroidEnterprise.v1.Data.User body, string enterpriseId, string userId)
        {
            return new UpdateRequest(this.service, body, enterpriseId, userId);
        }

        /// <summary>
        /// Updates the details of an EMM-managed user. Can be used with EMM-managed users only (not Google managed
        /// users). Pass the new details in the Users resource in the request body. Only the displayName field can be
        /// changed. Other fields must either be unset or have the currently active value.
        /// </summary>
        public class UpdateRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.User>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidEnterprise.v1.Data.User body, string enterpriseId, string userId) : base(service)
            {
                EnterpriseId = enterpriseId;
                UserId = userId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidEnterprise.v1.Data.User Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/users/{userId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "webapps" collection of methods.</summary>
    public class WebappsResource
    {
        private const string Resource = "webapps";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public WebappsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Deletes an existing web app.</summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="webAppId">The ID of the web app.</param>
        public virtual DeleteRequest Delete(string enterpriseId, string webAppId)
        {
            return new DeleteRequest(this.service, enterpriseId, webAppId);
        }

        /// <summary>Deletes an existing web app.</summary>
        public class DeleteRequest : AndroidEnterpriseBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string enterpriseId, string webAppId) : base(service)
            {
                EnterpriseId = enterpriseId;
                WebAppId = webAppId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the web app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("webAppId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string WebAppId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/webApps/{webAppId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("webAppId", new Google.Apis.Discovery.Parameter
                {
                    Name = "webAppId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Gets an existing web app.</summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="webAppId">The ID of the web app.</param>
        public virtual GetRequest Get(string enterpriseId, string webAppId)
        {
            return new GetRequest(this.service, enterpriseId, webAppId);
        }

        /// <summary>Gets an existing web app.</summary>
        public class GetRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.WebApp>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string enterpriseId, string webAppId) : base(service)
            {
                EnterpriseId = enterpriseId;
                WebAppId = webAppId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the web app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("webAppId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string WebAppId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/webApps/{webAppId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("webAppId", new Google.Apis.Discovery.Parameter
                {
                    Name = "webAppId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Creates a new web app for the enterprise.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        public virtual InsertRequest Insert(Google.Apis.AndroidEnterprise.v1.Data.WebApp body, string enterpriseId)
        {
            return new InsertRequest(this.service, body, enterpriseId);
        }

        /// <summary>Creates a new web app for the enterprise.</summary>
        public class InsertRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.WebApp>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidEnterprise.v1.Data.WebApp body, string enterpriseId) : base(service)
            {
                EnterpriseId = enterpriseId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidEnterprise.v1.Data.WebApp Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/webApps";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves the details of all web apps for a given enterprise.</summary>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        public virtual ListRequest List(string enterpriseId)
        {
            return new ListRequest(this.service, enterpriseId);
        }

        /// <summary>Retrieves the details of all web apps for a given enterprise.</summary>
        public class ListRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.WebAppsListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string enterpriseId) : base(service)
            {
                EnterpriseId = enterpriseId;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/webApps";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates an existing web app.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="webAppId">The ID of the web app.</param>
        public virtual UpdateRequest Update(Google.Apis.AndroidEnterprise.v1.Data.WebApp body, string enterpriseId, string webAppId)
        {
            return new UpdateRequest(this.service, body, enterpriseId, webAppId);
        }

        /// <summary>Updates an existing web app.</summary>
        public class UpdateRequest : AndroidEnterpriseBaseServiceRequest<Google.Apis.AndroidEnterprise.v1.Data.WebApp>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidEnterprise.v1.Data.WebApp body, string enterpriseId, string webAppId) : base(service)
            {
                EnterpriseId = enterpriseId;
                WebAppId = webAppId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EnterpriseId { get; private set; }

            /// <summary>The ID of the web app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("webAppId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string WebAppId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidEnterprise.v1.Data.WebApp Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidenterprise/v1/enterprises/{enterpriseId}/webApps/{webAppId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("enterpriseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("webAppId", new Google.Apis.Discovery.Parameter
                {
                    Name = "webAppId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.AndroidEnterprise.v1.Data
{
    /// <summary>
    /// This represents an enterprise admin who can manage the enterprise in the managed Google Play store.
    /// </summary>
    public class Administrator : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The admin's email address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A token authorizing an admin to access an iframe.</summary>
    public class AdministratorWebToken : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An opaque token to be passed to the Play front-end to generate an iframe.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specification for a token used to generate iframes. The token specifies what data the admin is allowed to modify
    /// and the URI the iframe is allowed to communiate with.
    /// </summary>
    public class AdministratorWebTokenSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Options for displaying the Managed Configuration page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managedConfigurations")]
        public virtual AdministratorWebTokenSpecManagedConfigurations ManagedConfigurations { get; set; }

        /// <summary>
        /// The URI of the parent frame hosting the iframe. To prevent XSS, the iframe may not be hosted at other URIs.
        /// This URI must be https. Use whitespaces to separate multiple parent URIs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>Deprecated. Use PlaySearch.approveApps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permission")]
        public virtual System.Collections.Generic.IList<string> Permission { get; set; }

        /// <summary>Options for displaying the managed Play Search apps page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("playSearch")]
        public virtual AdministratorWebTokenSpecPlaySearch PlaySearch { get; set; }

        /// <summary>Options for displaying the Private Apps page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateApps")]
        public virtual AdministratorWebTokenSpecPrivateApps PrivateApps { get; set; }

        /// <summary>Options for displaying the Organize apps page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storeBuilder")]
        public virtual AdministratorWebTokenSpecStoreBuilder StoreBuilder { get; set; }

        /// <summary>Options for displaying the Web Apps page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webApps")]
        public virtual AdministratorWebTokenSpecWebApps WebApps { get; set; }

        /// <summary>Options for displaying the Zero Touch page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zeroTouch")]
        public virtual AdministratorWebTokenSpecZeroTouch ZeroTouch { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AdministratorWebTokenSpecManagedConfigurations : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the Managed Configuration page is displayed. Default is true.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AdministratorWebTokenSpecPlaySearch : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Allow access to the iframe in approve mode. Default is false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approveApps")]
        public virtual System.Nullable<bool> ApproveApps { get; set; }

        /// <summary>Whether the managed Play Search apps page is displayed. Default is true.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AdministratorWebTokenSpecPrivateApps : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the Private Apps page is displayed. Default is true.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AdministratorWebTokenSpecStoreBuilder : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the Organize apps page is displayed. Default is true.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AdministratorWebTokenSpecWebApps : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the Web Apps page is displayed. Default is true.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AdministratorWebTokenSpecZeroTouch : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether zero-touch embedded UI is usable with this token. If enabled, the admin can link zero-touch
        /// customers to this enterprise.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the list of app restrictions available to be pre-configured for the product.</summary>
    public class AppRestrictionsSchema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The set of restrictions that make up this schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictions")]
        public virtual System.Collections.Generic.IList<AppRestrictionsSchemaRestriction> Restrictions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An event generated when a new app version is uploaded to Google Play and its app restrictions schema changed. To
    /// fetch the app restrictions schema for an app, use Products.getAppRestrictionsSchema on the EMM API.
    /// </summary>
    public class AppRestrictionsSchemaChangeEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The id of the product (e.g. "app:com.google.android.gm") for which the app restriction schema changed. This
        /// field will always be present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A restriction in the App Restriction Schema represents a piece of configuration that may be pre-applied.
    /// </summary>
    public class AppRestrictionsSchemaRestriction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The default value of the restriction. bundle and bundleArray restrictions never have a default value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultValue")]
        public virtual AppRestrictionsSchemaRestrictionRestrictionValue DefaultValue { get; set; }

        /// <summary>A longer description of the restriction, giving more detail of what it affects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// For choice or multiselect restrictions, the list of possible entries' human-readable names.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entry")]
        public virtual System.Collections.Generic.IList<string> Entry { get; set; }

        /// <summary>
        /// For choice or multiselect restrictions, the list of possible entries' machine-readable values. These values
        /// should be used in the configuration, either as a single string value for a choice restriction or in a
        /// stringArray for a multiselect restriction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entryValue")]
        public virtual System.Collections.Generic.IList<string> EntryValue { get; set; }

        /// <summary>
        /// The unique key that the product uses to identify the restriction, e.g. "com.google.android.gm.fieldname".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>
        /// For bundle or bundleArray restrictions, the list of nested restrictions. A bundle restriction is always
        /// nested within a bundleArray restriction, and a bundleArray restriction is at most two levels deep.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nestedRestriction")]
        public virtual System.Collections.Generic.IList<AppRestrictionsSchemaRestriction> NestedRestriction { get; set; }

        /// <summary>The type of the restriction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictionType")]
        public virtual string RestrictionType { get; set; }

        /// <summary>The name of the restriction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A typed value for the restriction.</summary>
    public class AppRestrictionsSchemaRestrictionRestrictionValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of the value being provided.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The boolean value - this will only be present if type is bool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueBool")]
        public virtual System.Nullable<bool> ValueBool { get; set; }

        /// <summary>The integer value - this will only be present if type is integer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueInteger")]
        public virtual System.Nullable<int> ValueInteger { get; set; }

        /// <summary>The list of string values - this will only be present if type is multiselect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueMultiselect")]
        public virtual System.Collections.Generic.IList<string> ValueMultiselect { get; set; }

        /// <summary>The string value - this will be present for types string, choice and hidden.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueString")]
        public virtual string ValueString { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List of states set by the app.</summary>
    public class AppState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of keyed app states. This field will always be present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyedAppState")]
        public virtual System.Collections.Generic.IList<KeyedAppState> KeyedAppState { get; set; }

        /// <summary>The package name of the app. This field will always be present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An event generated when a new version of an app is uploaded to Google Play. Notifications are sent for new
    /// public versions only: alpha, beta, or canary versions do not generate this event. To fetch up-to-date version
    /// history for an app, use Products.Get on the EMM API.
    /// </summary>
    public class AppUpdateEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The id of the product (e.g. "app:com.google.android.gm") that was updated. This field will always be
        /// present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This represents a single version of the app.</summary>
    public class AppVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>True if this version is a production APK.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isProduction")]
        public virtual System.Nullable<bool> IsProduction { get; set; }

        /// <summary>
        /// The SDK version this app targets, as specified in the manifest of the APK. See
        /// http://developer.android.com/guide/topics/manifest/uses-sdk-element.html
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetSdkVersion")]
        public virtual System.Nullable<int> TargetSdkVersion { get; set; }

        /// <summary>Deprecated, use trackId instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("track")]
        public virtual string Track { get; set; }

        /// <summary>
        /// Track ids that the app version is published in. Replaces the track field (deprecated), but doesn't include
        /// the production track (see isProduction instead).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackId")]
        public virtual System.Collections.Generic.IList<string> TrackId { get; set; }

        /// <summary>Unique increasing identifier for the app version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionCode")]
        public virtual System.Nullable<int> VersionCode { get; set; }

        /// <summary>
        /// The string used in the Play store by the app developer to identify the version. The string is not
        /// necessarily unique or localized (for example, the string could be "1.4").
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionString")]
        public virtual string VersionString { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information on an approval URL.</summary>
    public class ApprovalUrlInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A URL that displays a product's permissions and that can also be used to approve the product with the
        /// Products.approve call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approvalUrl")]
        public virtual string ApprovalUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An AuthenticationToken is used by the EMM's device policy client on a device to provision the given EMM-managed
    /// user on that device.
    /// </summary>
    public class AuthenticationToken : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The authentication token to be passed to the device policy client on the device where it can be used to
        /// provision the account for which this token was generated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The auto-install constraint. Defines a set of restrictions for installation. At least one of the fields must be
    /// set.
    /// </summary>
    public class AutoInstallConstraint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Charging state constraint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chargingStateConstraint")]
        public virtual string ChargingStateConstraint { get; set; }

        /// <summary>Device idle state constraint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceIdleStateConstraint")]
        public virtual string DeviceIdleStateConstraint { get; set; }

        /// <summary>Network type constraint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkTypeConstraint")]
        public virtual string NetworkTypeConstraint { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AutoInstallPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The constraints for auto-installing the app. You can specify a maximum of one constraint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoInstallConstraint")]
        public virtual System.Collections.Generic.IList<AutoInstallConstraint> AutoInstallConstraint { get; set; }

        /// <summary>
        /// The auto-install mode. If unset, defaults to "doNotAutoInstall". An app is automatically installed
        /// regardless of a set maintenance window.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoInstallMode")]
        public virtual string AutoInstallMode { get; set; }

        /// <summary>
        /// The priority of the install, as an unsigned integer. A lower number means higher priority.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoInstallPriority")]
        public virtual System.Nullable<int> AutoInstallPriority { get; set; }

        /// <summary>
        /// The minimum version of the app. If a lower version of the app is installed, then the app will be
        /// auto-updated according to the auto-install constraints, instead of waiting for the regular auto-update. You
        /// can set a minimum version code for at most 20 apps per device.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumVersionCode")]
        public virtual System.Nullable<int> MinimumVersionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A configuration variables resource contains the managed configuration settings ID to be applied to a single
    /// user, as well as the variable set that is attributed to the user. The variable set will be used to replace
    /// placeholders in the managed configuration settings.
    /// </summary>
    public class ConfigurationVariables : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the managed configurations settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mcmId")]
        public virtual string McmId { get; set; }

        /// <summary>The variable set that is attributed to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variableSet")]
        public virtual System.Collections.Generic.IList<VariableSet> VariableSet { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Devices resource represents a mobile device managed by the EMM and belonging to a specific enterprise user.
    /// </summary>
    public class Device : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The Google Play Services Android ID for the device encoded as a lowercase hex string. For example,
        /// "123456789abcdef0".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidId")]
        public virtual string AndroidId { get; set; }

        /// <summary>
        /// The internal hardware codename of the device. This comes from android.os.Build.DEVICE. (field named "device"
        /// per logs/wireless/android/android_checkin.proto)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("device")]
        public virtual string DeviceValue { get; set; }

        /// <summary>The build fingerprint of the device if known.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestBuildFingerprint")]
        public virtual string LatestBuildFingerprint { get; set; }

        /// <summary>The manufacturer of the device. This comes from android.os.Build.MANUFACTURER.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maker")]
        public virtual string Maker { get; set; }

        /// <summary>
        /// Identifies the extent to which the device is controlled by a managed Google Play EMM in various deployment
        /// configurations. Possible values include: - "managedDevice", a device that has the EMM's device policy
        /// controller (DPC) as the device owner. - "managedProfile", a device that has a profile managed by the DPC
        /// (DPC is profile owner) in addition to a separate, personal profile that is unavailable to the DPC. -
        /// "containerApp", no longer used (deprecated). - "unmanagedProfile", a device that has been allowed (by the
        /// domain's admin, using the Admin Console to enable the privilege) to use managed Google Play, but the profile
        /// is itself not owned by a DPC.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managementType")]
        public virtual string ManagementType { get; set; }

        /// <summary>The model name of the device. This comes from android.os.Build.MODEL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; }

        /// <summary>The policy enforced on the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual Policy Policy { get; set; }

        /// <summary>The product name of the device. This comes from android.os.Build.PRODUCT.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("product")]
        public virtual string Product { get; set; }

        /// <summary>The device report updated with the latest app states.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("report")]
        public virtual DeviceReport Report { get; set; }

        /// <summary>Retail brand for the device, if set. See android.os.Build.BRAND</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retailBrand")]
        public virtual string RetailBrand { get; set; }

        /// <summary>API compatibility version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sdkVersion")]
        public virtual System.Nullable<int> SdkVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Device report updated with the latest app states for managed apps on the device.</summary>
    public class DeviceReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of app states set by managed apps on the device. App states are defined by the app's developers. This
        /// field will always be present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appState")]
        public virtual System.Collections.Generic.IList<AppState> AppState { get; set; }

        /// <summary>
        /// The timestamp of the last report update in milliseconds since epoch. This field will always be present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdatedTimestampMillis")]
        public virtual System.Nullable<long> LastUpdatedTimestampMillis { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An event generated when an updated device report is available.</summary>
    public class DeviceReportUpdateEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Android ID of the device. This field will always be present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceId")]
        public virtual string DeviceId { get; set; }

        /// <summary>The device report updated with the latest app states. This field will always be present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("report")]
        public virtual DeviceReport Report { get; set; }

        /// <summary>The ID of the user. This field will always be present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The state of a user's device, as accessed by the getState and setState methods on device resources.
    /// </summary>
    public class DeviceState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The state of the Google account on the device. "enabled" indicates that the Google account on the device can
        /// be used to access Google services (including Google Play), while "disabled" means that it cannot. A new
        /// device is initially in the "disabled" state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountState")]
        public virtual string AccountState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DevicesListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A managed device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("device")]
        public virtual System.Collections.Generic.IList<Device> Device { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A token used to enroll a device.</summary>
    public class EnrollmentToken : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Optional] The length of time the enrollment token is valid, ranging from 1 minute to
        /// [`Durations.MAX_VALUE`](https://developers.google.com/protocol-buffers/docs/reference/java/com/google/protobuf/util/Durations.html#MAX_VALUE),
        /// approximately 10,000 years. If not specified, the default duration is 1 hour.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>[Required] The type of the enrollment token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enrollmentTokenType")]
        public virtual string EnrollmentTokenType { get; set; }

        /// <summary>
        /// The token value that's passed to the device and authorizes the device to enroll. This is a read-only field
        /// generated by the server.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An Enterprises resource represents the binding between an EMM and a specific organization. That binding can be
    /// instantiated in one of two different ways using this API as follows: - For Google managed domain customers, the
    /// process involves using Enterprises.enroll and Enterprises.setAccount (in conjunction with artifacts obtained
    /// from the Admin console and the Google API Console) and submitted to the EMM through a more-or-less manual
    /// process. - For managed Google Play Accounts customers, the process involves using Enterprises.generateSignupUrl
    /// and Enterprises.completeSignup in conjunction with the managed Google Play sign-up UI (Google-provided
    /// mechanism) to create the binding without manual steps. As an EMM, you can support either or both approaches in
    /// your EMM console. See Create an Enterprise for details.
    /// </summary>
    public class Enterprise : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Admins of the enterprise. This is only supported for enterprises created via the EMM-initiated flow.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("administrator")]
        public virtual System.Collections.Generic.IList<Administrator> Administrator { get; set; }

        /// <summary>The type of the enterprise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enterpriseType")]
        public virtual string EnterpriseType { get; set; }

        /// <summary>Output only. Settings for Google-provided user authentication.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleAuthenticationSettings")]
        public virtual GoogleAuthenticationSettings GoogleAuthenticationSettings { get; set; }

        /// <summary>The unique ID for the enterprise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The type of managed Google domain</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managedGoogleDomainType")]
        public virtual string ManagedGoogleDomainType { get; set; }

        /// <summary>The name of the enterprise, for example, "Example, Inc".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The enterprise's primary domain, such as "example.com".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryDomain")]
        public virtual string PrimaryDomain { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A service account that can be used to authenticate as the enterprise to API calls that require such
    /// authentication.
    /// </summary>
    public class EnterpriseAccount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The email address of the service account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountEmail")]
        public virtual string AccountEmail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An authentication URL configuration for the authenticator app of an identity provider.</summary>
    public class EnterpriseAuthenticationAppLinkConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An authentication url.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterprisesListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An enterprise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enterprise")]
        public virtual System.Collections.Generic.IList<Enterprise> Enterprise { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterprisesSendTestPushNotificationResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The message ID of the test push notification that was sent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageId")]
        public virtual string MessageId { get; set; }

        /// <summary>
        /// The name of the Cloud Pub/Sub topic to which notifications for this enterprise's enrolled account will be
        /// sent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topicName")]
        public virtual string TopicName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    ///  *Deprecated:* New integrations cannot use this method and can refer to our new recommendations.
    /// </summary>
    public class Entitlement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The ID of the product that the entitlement is for. For example, "app:com.google.android.gm".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; }

        /// <summary>
        /// The reason for the entitlement. For example, "free" for free apps. This property is temporary: it will be
        /// replaced by the acquisition kind field of group licenses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EntitlementsListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An entitlement of a user to a product (e.g. an app). For example, a free app that they have installed, or a
        /// paid app that they have been allocated a license to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entitlement")]
        public virtual System.Collections.Generic.IList<Entitlement> Entitlement { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains settings for Google-provided user authentication.</summary>
    public class GoogleAuthenticationSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether dedicated devices are allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dedicatedDevicesAllowed")]
        public virtual string DedicatedDevicesAllowed { get; set; }

        /// <summary>Whether Google authentication is required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleAuthenticationRequired")]
        public virtual string GoogleAuthenticationRequired { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    ///  *Deprecated:* New integrations cannot use this method and can refer to our new recommendations
    /// </summary>
    public class GroupLicense : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// How this group license was acquired. "bulkPurchase" means that this Grouplicenses resource was created
        /// because the enterprise purchased licenses for this product; otherwise, the value is "free" (for free
        /// products).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acquisitionKind")]
        public virtual string AcquisitionKind { get; set; }

        /// <summary>
        /// Whether the product to which this group license relates is currently approved by the enterprise. Products
        /// are approved when a group license is first created, but this approval may be revoked by an enterprise admin
        /// via Google Play. Unapproved products will not be visible to end users in collections, and new entitlements
        /// to them should not normally be created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approval")]
        public virtual string Approval { get; set; }

        /// <summary>
        /// The total number of provisioned licenses for this product. Returned by read operations, but ignored in write
        /// operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numProvisioned")]
        public virtual System.Nullable<int> NumProvisioned { get; set; }

        /// <summary>
        /// The number of purchased licenses (possibly in multiple purchases). If this field is omitted, then there is
        /// no limit on the number of licenses that can be provisioned (for example, if the acquisition kind is "free").
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numPurchased")]
        public virtual System.Nullable<int> NumPurchased { get; set; }

        /// <summary>
        /// The permission approval status of the product. This field is only set if the product is approved. Possible
        /// states are: - "currentApproved", the current set of permissions is approved, but additional permissions will
        /// require the administrator to reapprove the product (If the product was approved without specifying the
        /// approved permissions setting, then this is the default behavior.), - "needsReapproval", the product has
        /// unapproved permissions. No additional product licenses can be assigned until the product is reapproved, -
        /// "allCurrentAndFutureApproved", the current permissions are approved and any future permission updates will
        /// be automatically approved without administrator review.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual string Permissions { get; set; }

        /// <summary>The ID of the product that the license is for. For example, "app:com.google.android.gm".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GroupLicenseUsersListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A user of an enterprise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual System.Collections.Generic.IList<User> User { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GroupLicensesListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A group license for a product approved for use in the enterprise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupLicense")]
        public virtual System.Collections.Generic.IList<GroupLicense> GroupLicense { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The existence of an Installs resource indicates that an app is installed on a particular device (or that an
    /// install is pending). The API can be used to create an install resource using the update method. This triggers
    /// the actual install of the app on the device. If the user does not already have an entitlement for the app, then
    /// an attempt is made to create one. If this fails (for example, because the app is not free and there is no
    /// available license), then the creation of the install fails. The API can also be used to update an installed app.
    /// If the update method is used on an existing install, then the app will be updated to the latest available
    /// version. Note that it is not possible to force the installation of a specific version of an app: the version
    /// code is read-only. If a user installs an app themselves (as permitted by the enterprise), then again an install
    /// resource and possibly an entitlement resource are automatically created. The API can also be used to delete an
    /// install resource, which triggers the removal of the app from the device. Note that deleting an install does not
    /// automatically remove the corresponding entitlement, even if there are no remaining installs. The install
    /// resource will also be deleted if the user uninstalls the app themselves.
    /// </summary>
    public class Install : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Install state. The state "installPending" means that an install request has recently been made and download
        /// to the device is in progress. The state "installed" means that the app has been installed. This field is
        /// read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installState")]
        public virtual string InstallState { get; set; }

        /// <summary>The ID of the product that the install is for. For example, "app:com.google.android.gm".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; }

        /// <summary>
        /// The version of the installed product. Guaranteed to be set only if the install state is "installed".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionCode")]
        public virtual System.Nullable<int> VersionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An event generated when an app installation failed on a device</summary>
    public class InstallFailureEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Android ID of the device. This field will always be present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceId")]
        public virtual string DeviceId { get; set; }

        /// <summary>Additional details on the failure if applicable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureDetails")]
        public virtual string FailureDetails { get; set; }

        /// <summary>The reason for the installation failure. This field will always be present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureReason")]
        public virtual string FailureReason { get; set; }

        /// <summary>
        /// The id of the product (e.g. "app:com.google.android.gm") for which the install failure event occured. This
        /// field will always be present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; }

        /// <summary>The ID of the user. This field will always be present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class InstallsListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An installation of an app for a user on a specific device. The existence of an install implies that the user
        /// must have an entitlement to the app.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("install")]
        public virtual System.Collections.Generic.IList<Install> Install { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a keyed app state containing a key, timestamp, severity level, optional description, and optional
    /// data.
    /// </summary>
    public class KeyedAppState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Additional field intended for machine-readable data. For example, a number or JSON object. To prevent XSS,
        /// we recommend removing any HTML from the data before displaying it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>
        /// Key indicating what the app is providing a state for. The content of the key is set by the app's developer.
        /// To prevent XSS, we recommend removing any HTML from the key before displaying it. This field will always be
        /// present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>
        /// Free-form, human-readable message describing the app state. For example, an error message. To prevent XSS,
        /// we recommend removing any HTML from the message before displaying it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>Severity of the app state. This field will always be present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>
        /// Timestamp of when the app set the state in milliseconds since epoch. This field will always be present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateTimestampMillis")]
        public virtual System.Nullable<long> StateTimestampMillis { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A localized string with its locale.</summary>
    public class LocalizedText : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The BCP47 tag for a locale. (e.g. "en-US", "de").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locale")]
        public virtual string Locale { get; set; }

        /// <summary>The text localized in the associated locale.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Maintenance window for managed Google Play Accounts. This allows Play store to update the apps on the foreground
    /// in the designated window.
    /// </summary>
    public class MaintenanceWindow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Duration of the maintenance window, in milliseconds. The duration must be between 30 minutes and 24 hours
        /// (inclusive).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("durationMs")]
        public virtual System.Nullable<long> DurationMs { get; set; }

        /// <summary>
        /// Start time of the maintenance window, in milliseconds after midnight on the device. Windows can span
        /// midnight.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTimeAfterMidnightMs")]
        public virtual System.Nullable<long> StartTimeAfterMidnightMs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    ///  *Deprecated:* New integrations cannot use this method and can refer to our new recommendations
    /// </summary>
    public class ManagedConfiguration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Contains the ID of the managed configuration profile and the set of configuration variables (if any) defined
        /// for the user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configurationVariables")]
        public virtual ConfigurationVariables ConfigurationVariables { get; set; }

        /// <summary>Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The set of managed properties for this configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managedProperty")]
        public virtual System.Collections.Generic.IList<ManagedProperty> ManagedProperty { get; set; }

        /// <summary>
        /// The ID of the product that the managed configuration is for, e.g. "app:com.google.android.gm".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ManagedConfigurationsForDeviceListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A managed configuration for an app on a specific device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managedConfigurationForDevice")]
        public virtual System.Collections.Generic.IList<ManagedConfiguration> ManagedConfigurationForDevice { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ManagedConfigurationsForUserListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A managed configuration for an app for a specific user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managedConfigurationForUser")]
        public virtual System.Collections.Generic.IList<ManagedConfiguration> ManagedConfigurationForUser { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A managed configurations settings resource contains the set of managed properties that have been configured for
    /// an Android app to be applied to a set of users. The app's developer would have defined configurable properties
    /// in the managed configurations schema.
    /// </summary>
    public class ManagedConfigurationsSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The last updated time of the managed configuration settings in milliseconds since 1970-01-01T00:00:00Z.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdatedTimestampMillis")]
        public virtual System.Nullable<long> LastUpdatedTimestampMillis { get; set; }

        /// <summary>The ID of the managed configurations settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mcmId")]
        public virtual string McmId { get; set; }

        /// <summary>The name of the managed configurations settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ManagedConfigurationsSettingsListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A managed configurations settings for an app that may be assigned to a group of users in an enterprise.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managedConfigurationsSettings")]
        public virtual System.Collections.Generic.IList<ManagedConfigurationsSettings> ManagedConfigurationsSettings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A managed property of a managed configuration. The property must match one of the properties in the app
    /// restrictions schema of the product. Exactly one of the value fields must be populated, and it must match the
    /// property's type in the app restrictions schema.
    /// </summary>
    public class ManagedProperty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The unique key that identifies the property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The boolean value - this will only be present if type of the property is bool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueBool")]
        public virtual System.Nullable<bool> ValueBool { get; set; }

        /// <summary>
        /// The bundle of managed properties - this will only be present if type of the property is bundle.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueBundle")]
        public virtual ManagedPropertyBundle ValueBundle { get; set; }

        /// <summary>
        /// The list of bundles of properties - this will only be present if type of the property is bundle_array.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueBundleArray")]
        public virtual System.Collections.Generic.IList<ManagedPropertyBundle> ValueBundleArray { get; set; }

        /// <summary>The integer value - this will only be present if type of the property is integer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueInteger")]
        public virtual System.Nullable<int> ValueInteger { get; set; }

        /// <summary>
        /// The string value - this will only be present if type of the property is string, choice or hidden.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueString")]
        public virtual string ValueString { get; set; }

        /// <summary>
        /// The list of string values - this will only be present if type of the property is multiselect.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueStringArray")]
        public virtual System.Collections.Generic.IList<string> ValueStringArray { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A bundle of managed properties.</summary>
    public class ManagedPropertyBundle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of managed properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managedProperty")]
        public virtual System.Collections.Generic.IList<ManagedProperty> ManagedProperty { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An event generated when a new device is ready to be managed.</summary>
    public class NewDeviceEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Android ID of the device. This field will always be present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceId")]
        public virtual string DeviceId { get; set; }

        /// <summary>Policy app on the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dpcPackageName")]
        public virtual string DpcPackageName { get; set; }

        /// <summary>
        /// Identifies the extent to which the device is controlled by an Android EMM in various deployment
        /// configurations. Possible values include: - "managedDevice", a device where the DPC is set as device owner, -
        /// "managedProfile", a device where the DPC is set as profile owner.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managementType")]
        public virtual string ManagementType { get; set; }

        /// <summary>The ID of the user. This field will always be present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An event generated when new permissions are added to an app.</summary>
    public class NewPermissionsEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The set of permissions that the enterprise admin has already approved for this application. Use
        /// Permissions.Get on the EMM API to retrieve details about these permissions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approvedPermissions")]
        public virtual System.Collections.Generic.IList<string> ApprovedPermissions { get; set; }

        /// <summary>
        /// The id of the product (e.g. "app:com.google.android.gm") for which new permissions were added. This field
        /// will always be present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; }

        /// <summary>
        /// The set of permissions that the app is currently requesting. Use Permissions.Get on the EMM API to retrieve
        /// details about these permissions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedPermissions")]
        public virtual System.Collections.Generic.IList<string> RequestedPermissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A notification of one event relating to an enterprise.</summary>
    public class Notification : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Notifications about new app restrictions schema changes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appRestrictionsSchemaChangeEvent")]
        public virtual AppRestrictionsSchemaChangeEvent AppRestrictionsSchemaChangeEvent { get; set; }

        /// <summary>Notifications about app updates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appUpdateEvent")]
        public virtual AppUpdateEvent AppUpdateEvent { get; set; }

        /// <summary>Notifications about device report updates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceReportUpdateEvent")]
        public virtual DeviceReportUpdateEvent DeviceReportUpdateEvent { get; set; }

        /// <summary>The ID of the enterprise for which the notification is sent. This will always be present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enterpriseId")]
        public virtual string EnterpriseId { get; set; }

        /// <summary>Notifications about an app installation failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installFailureEvent")]
        public virtual InstallFailureEvent InstallFailureEvent { get; set; }

        /// <summary>Notifications about new devices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newDeviceEvent")]
        public virtual NewDeviceEvent NewDeviceEvent { get; set; }

        /// <summary>Notifications about new app permissions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newPermissionsEvent")]
        public virtual NewPermissionsEvent NewPermissionsEvent { get; set; }

        /// <summary>Type of the notification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationType")]
        public virtual string NotificationType { get; set; }

        /// <summary>Notifications about changes to a product's approval status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productApprovalEvent")]
        public virtual ProductApprovalEvent ProductApprovalEvent { get; set; }

        /// <summary>Notifications about product availability changes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productAvailabilityChangeEvent")]
        public virtual ProductAvailabilityChangeEvent ProductAvailabilityChangeEvent { get; set; }

        /// <summary>
        /// The time when the notification was published in milliseconds since 1970-01-01T00:00:00Z. This will always be
        /// present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestampMillis")]
        public virtual System.Nullable<long> TimestampMillis { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A resource returned by the PullNotificationSet API, which contains a collection of notifications for enterprises
    /// associated with the service account authenticated for the request.
    /// </summary>
    public class NotificationSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The notifications received, or empty if no notifications are present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notification")]
        public virtual System.Collections.Generic.IList<Notification> Notification { get; set; }

        /// <summary>
        /// The notification set ID, required to mark the notification as received with the
        /// Enterprises.AcknowledgeNotification API. This will be omitted if no notifications are present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationSetId")]
        public virtual string NotificationSetId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information about the current page. List operations that supports paging return only one "page" of results. This
    /// protocol buffer message describes the page that has been returned.
    /// </summary>
    public class PageInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Maximum number of results returned in one page. ! The number of results included in the API response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultPerPage")]
        public virtual System.Nullable<int> ResultPerPage { get; set; }

        /// <summary>Index of the first result returned in the current page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; }

        /// <summary>
        /// Total number of results available on the backend ! The total number of results in the result set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalResults")]
        public virtual System.Nullable<int> TotalResults { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Permissions resource represents some extra capability, to be granted to an Android app, which requires
    /// explicit consent. An enterprise admin must consent to these permissions on behalf of their users before an
    /// entitlement for the app can be created. The permissions collection is read-only. The information provided for
    /// each permission (localized name and description) is intended to be used in the MDM user interface when obtaining
    /// consent from the enterprise.
    /// </summary>
    public class Permission : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A longer description of the Permissions resource, giving more details of what it affects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The name of the permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>An opaque string uniquely identifying the permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissionId")]
        public virtual string PermissionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The device policy for a given managed device.</summary>
    public class Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Controls when automatic app updates on the device can be applied. Recommended alternative: autoUpdateMode
        /// which is set per app, provides greater flexibility around update frequency. When autoUpdateMode is set to
        /// AUTO_UPDATE_POSTPONED or AUTO_UPDATE_HIGH_PRIORITY, autoUpdatePolicy has no effect. - choiceToTheUser allows
        /// the device's user to configure the app update policy. - always enables auto updates. - never disables auto
        /// updates. - wifiOnly enables auto updates only when the device is connected to wifi. *Important:* Changes to
        /// app update policies don't affect updates that are in progress. Any policy changes will apply to subsequent
        /// app updates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoUpdatePolicy")]
        public virtual string AutoUpdatePolicy { get; set; }

        /// <summary>
        /// Whether the device reports app states to the EMM. The default value is "deviceReportDisabled".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceReportPolicy")]
        public virtual string DeviceReportPolicy { get; set; }

        /// <summary>The maintenance window defining when apps running in the foreground should be updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenanceWindow")]
        public virtual MaintenanceWindow MaintenanceWindow { get; set; }

        /// <summary>
        /// An identifier for the policy that will be passed with the app install feedback sent from the Play Store.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyId")]
        public virtual string PolicyId { get; set; }

        /// <summary>
        /// The availability granted to the device for the specified products. "all" gives the device access to all
        /// products, regardless of approval status. "all" does not enable automatic visibility of "alpha" or "beta"
        /// tracks. "whitelist" grants the device access the products specified in productPolicy[]. Only products that
        /// are approved or products that were previously approved (products with revoked approval) by the enterprise
        /// can be whitelisted. If no value is provided, the availability set at the user level is applied by default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productAvailabilityPolicy")]
        public virtual string ProductAvailabilityPolicy { get; set; }

        /// <summary>
        /// The list of product policies. The productAvailabilityPolicy needs to be set to WHITELIST or ALL for the
        /// product policies to be applied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productPolicy")]
        public virtual System.Collections.Generic.IList<ProductPolicy> ProductPolicy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Products resource represents an app in the Google Play store that is available to at least some users in the
    /// enterprise. (Some apps are restricted to a single enterprise, and no information about them is made available
    /// outside that enterprise.) The information provided for each product (localized name, icon, link to the full
    /// Google Play details page) is intended to allow a basic representation of the product within an EMM user
    /// interface.
    /// </summary>
    public class Product : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The app restriction schema</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appRestrictionsSchema")]
        public virtual AppRestrictionsSchema AppRestrictionsSchema { get; set; }

        /// <summary>The tracks visible to the enterprise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appTracks")]
        public virtual System.Collections.Generic.IList<TrackInfo> AppTracks { get; set; }

        /// <summary>App versions currently available for this product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appVersion")]
        public virtual System.Collections.Generic.IList<AppVersion> AppVersion { get; set; }

        /// <summary>The name of the author of the product (for example, the app developer).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorName")]
        public virtual string AuthorName { get; set; }

        /// <summary>The countries which this app is available in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableCountries")]
        public virtual System.Collections.Generic.IList<string> AvailableCountries { get; set; }

        /// <summary>Deprecated, use appTracks instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableTracks")]
        public virtual System.Collections.Generic.IList<string> AvailableTracks { get; set; }

        /// <summary>The app category (e.g. RACING, SOCIAL, etc.)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>The content rating for this app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentRating")]
        public virtual string ContentRating { get; set; }

        /// <summary>The localized promotional description, if available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>A link to the (consumer) Google Play details page for the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detailsUrl")]
        public virtual string DetailsUrl { get; set; }

        /// <summary>
        /// How and to whom the package is made available. The value publicGoogleHosted means that the package is
        /// available through the Play store and not restricted to a specific enterprise. The value privateGoogleHosted
        /// means that the package is a private app (restricted to an enterprise) but hosted by Google. The value
        /// privateSelfHosted means that the package is a private app (restricted to an enterprise) and is privately
        /// hosted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distributionChannel")]
        public virtual string DistributionChannel { get; set; }

        /// <summary>Noteworthy features (if any) of this product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("features")]
        public virtual System.Collections.Generic.IList<string> Features { get; set; }

        /// <summary>The localized full app store description, if available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullDescription")]
        public virtual string FullDescription { get; set; }

        /// <summary>
        /// A link to an image that can be used as an icon for the product. This image is suitable for use at up to
        /// 512px x 512px.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iconUrl")]
        public virtual string IconUrl { get; set; }

        /// <summary>
        /// The approximate time (within 7 days) the app was last published, expressed in milliseconds since epoch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdatedTimestampMillis")]
        public virtual System.Nullable<long> LastUpdatedTimestampMillis { get; set; }

        /// <summary>The minimum Android SDK necessary to run the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minAndroidSdkVersion")]
        public virtual System.Nullable<int> MinAndroidSdkVersion { get; set; }

        /// <summary>A list of permissions required by the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<ProductPermission> Permissions { get; set; }

        /// <summary>
        /// A string of the form *app:&amp;lt;package name&amp;gt;*. For example, app:com.google.android.gm represents
        /// the Gmail app.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; }

        /// <summary>
        /// Whether this product is free, free with in-app purchases, or paid. If the pricing is unknown, this means the
        /// product is not generally available anymore (even though it might still be available to people who own it).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productPricing")]
        public virtual string ProductPricing { get; set; }

        /// <summary>A description of the recent changes made to the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recentChanges")]
        public virtual string RecentChanges { get; set; }

        /// <summary>Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requiresContainerApp")]
        public virtual System.Nullable<bool> RequiresContainerApp { get; set; }

        /// <summary>A list of screenshot links representing the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenshotUrls")]
        public virtual System.Collections.Generic.IList<string> ScreenshotUrls { get; set; }

        /// <summary>The certificate used to sign this product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signingCertificate")]
        public virtual ProductSigningCertificate SigningCertificate { get; set; }

        /// <summary>
        /// A link to a smaller image that can be used as an icon for the product. This image is suitable for use at up
        /// to 128px x 128px.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("smallIconUrl")]
        public virtual string SmallIconUrl { get; set; }

        /// <summary>The name of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>
        /// A link to the managed Google Play details page for the product, for use by an Enterprise admin.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workDetailsUrl")]
        public virtual string WorkDetailsUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An event generated when a product's approval status is changed.</summary>
    public class ProductApprovalEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the product was approved or unapproved. This field will always be present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approved")]
        public virtual string Approved { get; set; }

        /// <summary>
        /// The id of the product (e.g. "app:com.google.android.gm") for which the approval status has changed. This
        /// field will always be present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An event generated whenever a product's availability changes.</summary>
    public class ProductAvailabilityChangeEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The new state of the product. This field will always be present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availabilityStatus")]
        public virtual string AvailabilityStatus { get; set; }

        /// <summary>
        /// The id of the product (e.g. "app:com.google.android.gm") for which the product availability changed. This
        /// field will always be present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A product permissions resource represents the set of permissions required by a specific app and whether or not
    /// they have been accepted by an enterprise admin. The API can be used to read the set of permissions, and also to
    /// update the set to indicate that permissions have been accepted.
    /// </summary>
    public class ProductPermission : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An opaque string uniquely identifying the permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissionId")]
        public virtual string PermissionId { get; set; }

        /// <summary>Whether the permission has been accepted or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information about the permissions required by a specific app and whether they have been accepted by the
    /// enterprise.
    /// </summary>
    public class ProductPermissions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The permissions required by the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permission")]
        public virtual System.Collections.Generic.IList<ProductPermission> Permission { get; set; }

        /// <summary>The ID of the app that the permissions relate to, e.g. "app:com.google.android.gm".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The policy for a product.</summary>
    public class ProductPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The auto-install policy for the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoInstallPolicy")]
        public virtual AutoInstallPolicy AutoInstallPolicy { get; set; }

        /// <summary>
        /// The auto-update mode for the product. When autoUpdateMode is used, it always takes precedence over the
        /// user's choice. So when a user makes changes to the device settings manually, these changes are ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoUpdateMode")]
        public virtual string AutoUpdateMode { get; set; }

        /// <summary>
        /// An authentication URL configuration for the authenticator app of an identity provider. This helps to launch
        /// the identity provider's authenticator app during the authentication happening in a private app using Android
        /// WebView. Authenticator app should already be the default handler for the authentication url on the device.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enterpriseAuthenticationAppLinkConfigs")]
        public virtual System.Collections.Generic.IList<EnterpriseAuthenticationAppLinkConfig> EnterpriseAuthenticationAppLinkConfigs { get; set; }

        /// <summary>The managed configuration for the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managedConfiguration")]
        public virtual ManagedConfiguration ManagedConfiguration { get; set; }

        /// <summary>The ID of the product. For example, "app:com.google.android.gm".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; }

        /// <summary>
        /// Grants the device visibility to the specified product release track(s), identified by trackIds. The list of
        /// release tracks of a product can be obtained by calling Products.Get.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackIds")]
        public virtual System.Collections.Generic.IList<string> TrackIds { get; set; }

        /// <summary>Deprecated. Use trackIds instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tracks")]
        public virtual System.Collections.Generic.IList<string> Tracks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A set of products.</summary>
    public class ProductSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of product IDs making up the set of products.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual System.Collections.Generic.IList<string> ProductId { get; set; }

        /// <summary>
        /// The interpretation of this product set. "unknown" should never be sent and is ignored if received.
        /// "whitelist" means that the user is entitled to access the product set. "includeAll" means that all products
        /// are accessible, including products that are approved, products with revoked approval, and products that have
        /// never been approved. "allApproved" means that the user is entitled to access all products that are approved
        /// for the enterprise. If the value is "allApproved" or "includeAll", the productId field is ignored. If no
        /// value is provided, it is interpreted as "whitelist" for backwards compatibility. Further "allApproved" or
        /// "includeAll" does not enable automatic visibility of "alpha" or "beta" tracks for Android app. Use
        /// ProductVisibility to enable "alpha" or "beta" tracks per user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productSetBehavior")]
        public virtual string ProductSetBehavior { get; set; }

        /// <summary>
        /// Additional list of product IDs making up the product set. Unlike the productID array, in this list It's
        /// possible to specify which tracks (alpha, beta, production) of a product are visible to the user. See
        /// ProductVisibility and its fields for more information. Specifying the same product ID both here and in the
        /// productId array is not allowed and it will result in an error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productVisibility")]
        public virtual System.Collections.Generic.IList<ProductVisibility> ProductVisibility { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ProductSigningCertificate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The base64 urlsafe encoded SHA1 hash of the certificate. (This field is deprecated in favor of SHA2-256. It
        /// should not be used and may be removed at any time.)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificateHashSha1")]
        public virtual string CertificateHashSha1 { get; set; }

        /// <summary>The base64 urlsafe encoded SHA2-256 hash of the certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificateHashSha256")]
        public virtual string CertificateHashSha256 { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A product to be made visible to a user.</summary>
    public class ProductVisibility : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The product ID to make visible to the user. Required for each item in the productVisibility list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; }

        /// <summary>Grants the user visibility to the specified product track(s), identified by trackIds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackIds")]
        public virtual System.Collections.Generic.IList<string> TrackIds { get; set; }

        /// <summary>Deprecated. Use trackIds instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tracks")]
        public virtual System.Collections.Generic.IList<string> Tracks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ProductsApproveRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The approval URL that was shown to the user. Only the permissions shown to the user with that URL will be
        /// accepted, which may not be the product's entire set of permissions. For example, the URL may only display
        /// new permissions from an update after the product was approved, or not include new permissions if the product
        /// was updated since the URL was generated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approvalUrlInfo")]
        public virtual ApprovalUrlInfo ApprovalUrlInfo { get; set; }

        /// <summary>
        /// Sets how new permission requests for the product are handled. "allPermissions" automatically approves all
        /// current and future permissions for the product. "currentPermissionsOnly" approves the current set of
        /// permissions for the product, but any future permissions added through updates will require manual
        /// reapproval. If not specified, only the current set of permissions will be approved.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approvedPermissions")]
        public virtual string ApprovedPermissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ProductsGenerateApprovalUrlResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A URL that can be rendered in an iframe to display the permissions (if any) of a product. This URL can be
        /// used to approve the product only once and only within 24 hours of being generated, using the
        /// Products.approve call. If the product is currently unapproved and has no permissions, this URL will point to
        /// an empty page. If the product is currently approved, a URL will only be generated if that product has added
        /// permissions since it was last approved, and the URL will only display those new permissions that have not
        /// yet been accepted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ProductsListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>General pagination information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageInfo")]
        public virtual PageInfo PageInfo { get; set; }

        /// <summary>
        /// Information about a product (e.g. an app) in the Google Play store, for display to an enterprise admin.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("product")]
        public virtual System.Collections.Generic.IList<Product> Product { get; set; }

        /// <summary>Pagination information for token pagination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokenPagination")]
        public virtual TokenPagination TokenPagination { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A service account identity, including the name and credentials that can be used to authenticate as the service
    /// account.
    /// </summary>
    public class ServiceAccount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Credentials that can be used to authenticate as this ServiceAccount.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual ServiceAccountKey Key { get; set; }

        /// <summary>
        /// The account name of the service account, in the form of an email address. Assigned by the server.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    ///  *Deprecated:* New integrations cannot use this method and can refer to our new recommendations
    /// </summary>
    public class ServiceAccountKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The body of the private key credentials file, in string format. This is only populated when the
        /// ServiceAccountKey is created, and is not stored by Google.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>An opaque, unique identifier for this ServiceAccountKey. Assigned by the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Public key data for the credentials file. This is an X.509 cert. If you are using the googleCredentials key
        /// type, this is identical to the cert that can be retrieved by using the X.509 cert url inside of the
        /// credentials file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicData")]
        public virtual string PublicData { get; set; }

        /// <summary>The file format of the generated key data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ServiceAccountKeysListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The service account credentials.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountKey")]
        public virtual System.Collections.Generic.IList<ServiceAccountKey> ServiceAccountKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A resource returned by the GenerateSignupUrl API, which contains the Signup URL and Completion Token.
    /// </summary>
    public class SignupInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An opaque token that will be required, along with the Enterprise Token, for obtaining the enterprise
        /// resource from CompleteSignup.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completionToken")]
        public virtual string CompletionToken { get; set; }

        /// <summary>Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// A URL under which the Admin can sign up for an enterprise. The page pointed to cannot be rendered in an
        /// iframe.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Definition of a managed Google Play store cluster, a list of products displayed as part of a store page.
    /// </summary>
    public class StoreCluster : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Unique ID of this cluster. Assigned by the server. Immutable once assigned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Ordered list of localized strings giving the name of this page. The text displayed is the one that best
        /// matches the user locale, or the first entry if there is no good match. There needs to be at least one entry.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual System.Collections.Generic.IList<LocalizedText> Name { get; set; }

        /// <summary>
        /// String (US-ASCII only) used to determine order of this cluster within the parent page's elements. Page
        /// elements are sorted in lexicographic order of this field. Duplicated values are allowed, but ordering
        /// between elements with duplicate order is undefined. The value of this field is never visible to a user, it
        /// is used solely for the purpose of defining an ordering. Maximum length is 256 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderInPage")]
        public virtual string OrderInPage { get; set; }

        /// <summary>
        /// List of products in the order they are displayed in the cluster. There should not be duplicates within a
        /// cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual System.Collections.Generic.IList<string> ProductId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// General setting for the managed Google Play store layout, currently only specifying the page to display the
    /// first time the store is opened.
    /// </summary>
    public class StoreLayout : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The ID of the store page to be used as the homepage. The homepage is the first page shown in the managed
        /// Google Play Store. Not specifying a homepage is equivalent to setting the store layout type to "basic".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("homepageId")]
        public virtual string HomepageId { get; set; }

        /// <summary>
        /// The store layout type. By default, this value is set to "basic" if the homepageId field is not set, and to
        /// "custom" otherwise. If set to "basic", the layout will consist of all approved apps that have been
        /// whitelisted for the user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storeLayoutType")]
        public virtual string StoreLayoutType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class StoreLayoutClustersListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A store cluster of an enterprise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cluster")]
        public virtual System.Collections.Generic.IList<StoreCluster> Cluster { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class StoreLayoutPagesListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A store page of an enterprise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("page")]
        public virtual System.Collections.Generic.IList<StorePage> Page { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Definition of a managed Google Play store page, made of a localized name and links to other pages. A page also
    /// contains clusters defined as a subcollection.
    /// </summary>
    public class StorePage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Unique ID of this page. Assigned by the server. Immutable once assigned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Ordered list of pages a user should be able to reach from this page. The list can't include this page. It is
        /// recommended that the basic pages are created first, before adding the links between pages. The API doesn't
        /// verify that the pages exist or the pages are reachable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("link")]
        public virtual System.Collections.Generic.IList<string> Link { get; set; }

        /// <summary>
        /// Ordered list of localized strings giving the name of this page. The text displayed is the one that best
        /// matches the user locale, or the first entry if there is no good match. There needs to be at least one entry.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual System.Collections.Generic.IList<LocalizedText> Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Pagination information returned by a List operation when token pagination is enabled. List operations that
    /// supports paging return only one "page" of results. This protocol buffer message describes the page that has been
    /// returned. When using token pagination, clients should use the next/previous token to get another page of the
    /// result. The presence or absence of next/previous token indicates whether a next/previous page is available and
    /// provides a mean of accessing this page. ListRequest.page_token should be set to either next_page_token or
    /// previous_page_token to access another page.
    /// </summary>
    public class TokenPagination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Tokens to pass to the standard list field 'page_token'. Whenever available, tokens are preferred over
        /// manipulating start_index.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("previousPageToken")]
        public virtual string PreviousPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Id to name association of a track.</summary>
    public class TrackInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A modifiable name for a track. This is the visible name in the play developer console.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackAlias")]
        public virtual string TrackAlias { get; set; }

        /// <summary>
        /// Unmodifiable, unique track identifier. This identifier is the releaseTrackId in the url of the play
        /// developer console page that displays the track information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackId")]
        public virtual string TrackId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Users resource represents an account associated with an enterprise. The account may be specific to a device or
    /// to an individual user (who can then use the account across multiple devices). The account may provide access to
    /// managed Google Play only, or to other Google services, depending on the identity model: - The Google managed
    /// domain identity model requires synchronization to Google account sources (via primaryEmail). - The managed
    /// Google Play Accounts identity model provides a dynamic means for enterprises to create user or device accounts
    /// as needed. These accounts provide access to managed Google Play.
    /// </summary>
    public class User : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A unique identifier you create for this user, such as "user342" or "asset#44418". Do not use personally
        /// identifiable information (PII) for this property. Must always be set for EMM-managed users. Not set for
        /// Google-managed users.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountIdentifier")]
        public virtual string AccountIdentifier { get; set; }

        /// <summary>
        /// The type of account that this user represents. A userAccount can be installed on multiple devices, but a
        /// deviceAccount is specific to a single device. An EMM-managed user (emmManaged) can be either type
        /// (userAccount, deviceAccount), but a Google-managed user (googleManaged) is always a userAccount.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountType")]
        public virtual string AccountType { get; set; }

        /// <summary>
        /// The name that will appear in user interfaces. Setting this property is optional when creating EMM-managed
        /// users. If you do set this property, use something generic about the organization (such as "Example, Inc.")
        /// or your name (as EMM). Not used for Google-managed user accounts. @mutable androidenterprise.users.update
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The unique ID for the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// The entity that manages the user. With googleManaged users, the source of truth is Google so EMMs have to
        /// make sure a Google Account exists for the user. With emmManaged users, the EMM is in charge.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managementType")]
        public virtual string ManagementType { get; set; }

        /// <summary>
        /// The user's primary email address, for example, "jsmith@example.com". Will always be set for Google managed
        /// users and not set for EMM managed users.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryEmail")]
        public virtual string PrimaryEmail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class UsersListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A user of an enterprise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual System.Collections.Generic.IList<User> User { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A variable set is a key-value pair of EMM-provided placeholders and its corresponding value, which is attributed
    /// to a user. For example, $FIRSTNAME could be a placeholder, and its value could be Alice. Placeholders should
    /// start with a '$' sign and should be alphanumeric only.
    /// </summary>
    public class VariableSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The placeholder string; defined by EMM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placeholder")]
        public virtual string Placeholder { get; set; }

        /// <summary>The value of the placeholder, specific to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userValue")]
        public virtual string UserValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A WebApps resource represents a web app created for an enterprise. Web apps are published to managed Google Play
    /// and can be distributed like other Android apps. On a user's device, a web app opens its specified URL.
    /// </summary>
    public class WebApp : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The display mode of the web app. Possible values include: - "minimalUi", the device's status bar, navigation
        /// bar, the app's URL, and a refresh button are visible when the app is open. For HTTP URLs, you can only
        /// select this option. - "standalone", the device's status bar and navigation bar are visible when the app is
        /// open. - "fullScreen", the app opens in full screen mode, hiding the device's status and navigation bars. All
        /// browser UI elements, page URL, system status bar and back button are not visible, and the web app takes up
        /// the entirety of the available display area.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayMode")]
        public virtual string DisplayMode { get; set; }

        /// <summary>
        /// A list of icons representing this website. If absent, a default icon (for create) or the current icon (for
        /// update) will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("icons")]
        public virtual System.Collections.Generic.IList<WebAppIcon> Icons { get; set; }

        /// <summary>A flag whether the app has been published to the Play store yet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isPublished")]
        public virtual System.Nullable<bool> IsPublished { get; set; }

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
        /// The current version of the app. Note that the version can automatically increase during the lifetime of the
        /// web app, while Google does internal housekeeping to keep the web app up-to-date.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionCode")]
        public virtual System.Nullable<long> VersionCode { get; set; }

        /// <summary>
        /// The ID of the application. A string of the form "app:&amp;lt;package name&amp;gt;" where the package name
        /// always starts with the prefix "com.google.enterprise.webapp." followed by a random id.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webAppId")]
        public virtual string WebAppId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Icon for a web app.</summary>
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

    public class WebAppsListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The manifest describing a web app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webApp")]
        public virtual System.Collections.Generic.IList<WebApp> WebApp { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
