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

namespace Google.Apis.HomeGraphService.v1
{
    /// <summary>The HomeGraphService Service.</summary>
    public class HomeGraphServiceService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public HomeGraphServiceService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public HomeGraphServiceService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            AgentUsers = new AgentUsersResource(this);
            Devices = new DevicesResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "homegraph";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://homegraph.googleapis.com/";
        #else
            "https://homegraph.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://homegraph.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the HomeGraph API.</summary>
        public class Scope
        {
            /// <summary>Private Service: https://www.googleapis.com/auth/homegraph</summary>
            public static string Homegraph = "https://www.googleapis.com/auth/homegraph";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the HomeGraph API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Private Service: https://www.googleapis.com/auth/homegraph</summary>
            public const string Homegraph = "https://www.googleapis.com/auth/homegraph";
        }

        /// <summary>Gets the AgentUsers resource.</summary>
        public virtual AgentUsersResource AgentUsers { get; }

        /// <summary>Gets the Devices resource.</summary>
        public virtual DevicesResource Devices { get; }
    }

    /// <summary>A base abstract class for HomeGraphService requests.</summary>
    public abstract class HomeGraphServiceBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new HomeGraphServiceBaseServiceRequest instance.</summary>
        protected HomeGraphServiceBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes HomeGraphService parameter list.</summary>
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

    /// <summary>The "agentUsers" collection of methods.</summary>
    public class AgentUsersResource
    {
        private const string Resource = "agentUsers";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AgentUsersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Unlinks the given third-party user from your smart home Action. All data related to this user will be
        /// deleted. For more details on how users link their accounts, see [fulfillment and
        /// authentication](https://developers.google.com/assistant/smarthome/concepts/fulfillment-authentication). The
        /// third-party user's identity is passed in via the `agent_user_id` (see DeleteAgentUserRequest). This request
        /// must be authorized using service account credentials from your Actions console project.
        /// </summary>
        /// <param name="agentUserId">Required. Third-party user ID.</param>
        public virtual DeleteRequest Delete(string agentUserId)
        {
            return new DeleteRequest(service, agentUserId);
        }

        /// <summary>
        /// Unlinks the given third-party user from your smart home Action. All data related to this user will be
        /// deleted. For more details on how users link their accounts, see [fulfillment and
        /// authentication](https://developers.google.com/assistant/smarthome/concepts/fulfillment-authentication). The
        /// third-party user's identity is passed in via the `agent_user_id` (see DeleteAgentUserRequest). This request
        /// must be authorized using service account credentials from your Actions console project.
        /// </summary>
        public class DeleteRequest : HomeGraphServiceBaseServiceRequest<Google.Apis.HomeGraphService.v1.Data.Empty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string agentUserId) : base(service)
            {
                AgentUserId = agentUserId;
                InitParameters();
            }

            /// <summary>Required. Third-party user ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("agentUserId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string AgentUserId { get; private set; }

            /// <summary>Request ID used for debugging.</summary>
            [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string RequestId { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+agentUserId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("agentUserId", new Google.Apis.Discovery.Parameter
                {
                    Name = "agentUserId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^agentUsers/.*$",
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
        /// Gets the current states in Home Graph for the given set of the third-party user's devices. The third-party
        /// user's identity is passed in via the `agent_user_id` (see QueryRequest). This request must be authorized
        /// using service account credentials from your Actions console project.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual QueryRequest Query(Google.Apis.HomeGraphService.v1.Data.QueryRequest body)
        {
            return new QueryRequest(service, body);
        }

        /// <summary>
        /// Gets the current states in Home Graph for the given set of the third-party user's devices. The third-party
        /// user's identity is passed in via the `agent_user_id` (see QueryRequest). This request must be authorized
        /// using service account credentials from your Actions console project.
        /// </summary>
        public class QueryRequest : HomeGraphServiceBaseServiceRequest<Google.Apis.HomeGraphService.v1.Data.QueryResponse>
        {
            /// <summary>Constructs a new Query request.</summary>
            public QueryRequest(Google.Apis.Services.IClientService service, Google.Apis.HomeGraphService.v1.Data.QueryRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.HomeGraphService.v1.Data.QueryRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "query";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/devices:query";

            /// <summary>Initializes Query parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Reports device state and optionally sends device notifications. Called by your smart home Action when the
        /// state of a third-party device changes or you need to send a notification about the device. See [Implement
        /// Report State](https://developers.google.com/assistant/smarthome/develop/report-state) for more information.
        /// This method updates the device state according to its declared
        /// [traits](https://developers.google.com/assistant/smarthome/concepts/devices-traits). Publishing a new state
        /// value outside of these traits will result in an `INVALID_ARGUMENT` error response. The third-party user's
        /// identity is passed in via the `agent_user_id` (see ReportStateAndNotificationRequest). This request must be
        /// authorized using service account credentials from your Actions console project.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual ReportStateAndNotificationRequest ReportStateAndNotification(Google.Apis.HomeGraphService.v1.Data.ReportStateAndNotificationRequest body)
        {
            return new ReportStateAndNotificationRequest(service, body);
        }

        /// <summary>
        /// Reports device state and optionally sends device notifications. Called by your smart home Action when the
        /// state of a third-party device changes or you need to send a notification about the device. See [Implement
        /// Report State](https://developers.google.com/assistant/smarthome/develop/report-state) for more information.
        /// This method updates the device state according to its declared
        /// [traits](https://developers.google.com/assistant/smarthome/concepts/devices-traits). Publishing a new state
        /// value outside of these traits will result in an `INVALID_ARGUMENT` error response. The third-party user's
        /// identity is passed in via the `agent_user_id` (see ReportStateAndNotificationRequest). This request must be
        /// authorized using service account credentials from your Actions console project.
        /// </summary>
        public class ReportStateAndNotificationRequest : HomeGraphServiceBaseServiceRequest<Google.Apis.HomeGraphService.v1.Data.ReportStateAndNotificationResponse>
        {
            /// <summary>Constructs a new ReportStateAndNotification request.</summary>
            public ReportStateAndNotificationRequest(Google.Apis.Services.IClientService service, Google.Apis.HomeGraphService.v1.Data.ReportStateAndNotificationRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.HomeGraphService.v1.Data.ReportStateAndNotificationRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "reportStateAndNotification";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/devices:reportStateAndNotification";

            /// <summary>Initializes ReportStateAndNotification parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Requests Google to send an `action.devices.SYNC`
        /// [intent](https://developers.google.com/assistant/smarthome/reference/intent/sync) to your smart home Action
        /// to update device metadata for the given user. The third-party user's identity is passed via the
        /// `agent_user_id` (see RequestSyncDevicesRequest). This request must be authorized using service account
        /// credentials from your Actions console project.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual RequestSyncRequest RequestSync(Google.Apis.HomeGraphService.v1.Data.RequestSyncDevicesRequest body)
        {
            return new RequestSyncRequest(service, body);
        }

        /// <summary>
        /// Requests Google to send an `action.devices.SYNC`
        /// [intent](https://developers.google.com/assistant/smarthome/reference/intent/sync) to your smart home Action
        /// to update device metadata for the given user. The third-party user's identity is passed via the
        /// `agent_user_id` (see RequestSyncDevicesRequest). This request must be authorized using service account
        /// credentials from your Actions console project.
        /// </summary>
        public class RequestSyncRequest : HomeGraphServiceBaseServiceRequest<Google.Apis.HomeGraphService.v1.Data.RequestSyncDevicesResponse>
        {
            /// <summary>Constructs a new RequestSync request.</summary>
            public RequestSyncRequest(Google.Apis.Services.IClientService service, Google.Apis.HomeGraphService.v1.Data.RequestSyncDevicesRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.HomeGraphService.v1.Data.RequestSyncDevicesRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "requestSync";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/devices:requestSync";

            /// <summary>Initializes RequestSync parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Gets all the devices associated with the given third-party user. The third-party user's identity is passed
        /// in via the `agent_user_id` (see SyncRequest). This request must be authorized using service account
        /// credentials from your Actions console project.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual SyncRequest Sync(Google.Apis.HomeGraphService.v1.Data.SyncRequest body)
        {
            return new SyncRequest(service, body);
        }

        /// <summary>
        /// Gets all the devices associated with the given third-party user. The third-party user's identity is passed
        /// in via the `agent_user_id` (see SyncRequest). This request must be authorized using service account
        /// credentials from your Actions console project.
        /// </summary>
        public class SyncRequest : HomeGraphServiceBaseServiceRequest<Google.Apis.HomeGraphService.v1.Data.SyncResponse>
        {
            /// <summary>Constructs a new Sync request.</summary>
            public SyncRequest(Google.Apis.Services.IClientService service, Google.Apis.HomeGraphService.v1.Data.SyncRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.HomeGraphService.v1.Data.SyncRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "sync";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/devices:sync";

            /// <summary>Initializes Sync parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }
}
namespace Google.Apis.HomeGraphService.v1.Data
{
    /// <summary>Third-party device ID for one device.</summary>
    public class AgentDeviceId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Third-party device ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Alternate third-party device ID.</summary>
    public class AgentOtherDeviceId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Project ID for your smart home Action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agentId")]
        public virtual string AgentId { get; set; }

        /// <summary>Unique third-party device ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceId")]
        public virtual string DeviceId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Third-party device definition. Next ID = 14</summary>
    public class Device : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Attributes for the traits supported by the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IDictionary<string, object> Attributes { get; set; }

        /// <summary>
        /// Custom device attributes stored in Home Graph and provided to your smart home Action in each
        /// [QUERY](https://developers.google.com/assistant/smarthome/reference/intent/query) and
        /// [EXECUTE](https://developers.google.com/assistant/smarthome/reference/intent/execute) intent. Data in this
        /// object has a few constraints: No sensitive information, including but not limited to Personally Identifiable
        /// Information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customData")]
        public virtual System.Collections.Generic.IDictionary<string, object> CustomData { get; set; }

        /// <summary>Device manufacturer, model, hardware version, and software version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceInfo")]
        public virtual DeviceInfo DeviceInfo { get; set; }

        /// <summary>Third-party device ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Names given to this device by your smart home Action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual DeviceNames Name { get; set; }

        /// <summary>
        /// Indicates whether your smart home Action will report notifications to Google for this device via
        /// ReportStateAndNotification. If your smart home Action enables users to control device notifications, you
        /// should update this field and call RequestSyncDevices.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationSupportedByAgent")]
        public virtual System.Nullable<bool> NotificationSupportedByAgent { get; set; }

        /// <summary>
        /// Alternate IDs associated with this device. This is used to identify cloud synced devices enabled for [local
        /// fulfillment](https://developers.google.com/assistant/smarthome/concepts/local).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("otherDeviceIds")]
        public virtual System.Collections.Generic.IList<AgentOtherDeviceId> OtherDeviceIds { get; set; }

        /// <summary>
        /// Suggested name for the room where this device is installed. Google attempts to use this value during user
        /// setup.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roomHint")]
        public virtual string RoomHint { get; set; }

        /// <summary>
        /// Suggested name for the structure where this device is installed. Google attempts to use this value during
        /// user setup.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("structureHint")]
        public virtual string StructureHint { get; set; }

        /// <summary>
        /// Traits supported by the device. See [device
        /// traits](https://developers.google.com/assistant/smarthome/traits).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("traits")]
        public virtual System.Collections.Generic.IList<string> Traits { get; set; }

        /// <summary>
        /// Hardware type of the device. See [device types](https://developers.google.com/assistant/smarthome/guides).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// Indicates whether your smart home Action will report state of this device to Google via
        /// ReportStateAndNotification.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("willReportState")]
        public virtual System.Nullable<bool> WillReportState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Device information.</summary>
    public class DeviceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Device hardware version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hwVersion")]
        public virtual string HwVersion { get; set; }

        /// <summary>Device manufacturer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manufacturer")]
        public virtual string Manufacturer { get; set; }

        /// <summary>Device model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; }

        /// <summary>Device software version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("swVersion")]
        public virtual string SwVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Identifiers used to describe the device.</summary>
    public class DeviceNames : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of names provided by the manufacturer rather than the user, such as serial numbers, SKUs, etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultNames")]
        public virtual System.Collections.Generic.IList<string> DefaultNames { get; set; }

        /// <summary>Primary name of the device, generally provided by the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Additional names provided by the user for the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nicknames")]
        public virtual System.Collections.Generic.IList<string> Nicknames { get; set; }

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

    /// <summary>Request type for the [`Query`](#google.home.graph.v1.HomeGraphApiService.Query) call.</summary>
    public class QueryRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Third-party user ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agentUserId")]
        public virtual string AgentUserId { get; set; }

        /// <summary>Required. Inputs containing third-party device IDs for which to get the device states.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputs")]
        public virtual System.Collections.Generic.IList<QueryRequestInput> Inputs { get; set; }

        /// <summary>Request ID used for debugging.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Device ID inputs to QueryRequest.</summary>
    public class QueryRequestInput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Payload containing third-party device IDs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payload")]
        public virtual QueryRequestPayload Payload { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Payload containing device IDs.</summary>
    public class QueryRequestPayload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Third-party device IDs for which to get the device states.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("devices")]
        public virtual System.Collections.Generic.IList<AgentDeviceId> Devices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response type for the [`Query`](#google.home.graph.v1.HomeGraphApiService.Query) call. This should follow the
    /// same format as the Google smart home `action.devices.QUERY`
    /// [response](https://developers.google.com/assistant/smarthome/reference/intent/query). # Example ```json {
    /// "requestId": "ff36a3cc-ec34-11e6-b1a0-64510650abcf", "payload": { "devices": { "123": { "on": true, "online":
    /// true }, "456": { "on": true, "online": true, "brightness": 80, "color": { "name": "cerulean", "spectrumRGB":
    /// 31655 } } } } } ```
    /// </summary>
    public class QueryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Device states for the devices given in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payload")]
        public virtual QueryResponsePayload Payload { get; set; }

        /// <summary>Request ID used for debugging. Copied from the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Payload containing device states information.</summary>
    public class QueryResponsePayload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>States of the devices. Map of third-party device ID to struct of device states.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("devices")]
        public virtual System.Collections.Generic.IDictionary<string, System.Collections.Generic.IDictionary<string, object>> Devices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The states and notifications specific to a device.</summary>
    public class ReportStateAndNotificationDevice : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Notifications metadata for devices. See the **Device NOTIFICATIONS** section of the individual trait
        /// [reference guides](https://developers.google.com/assistant/smarthome/traits).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notifications")]
        public virtual System.Collections.Generic.IDictionary<string, object> Notifications { get; set; }

        /// <summary>
        /// States of devices to update. See the **Device STATES** section of the individual trait [reference
        /// guides](https://developers.google.com/assistant/smarthome/traits).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("states")]
        public virtual System.Collections.Generic.IDictionary<string, object> States { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Request type for the
    /// [`ReportStateAndNotification`](#google.home.graph.v1.HomeGraphApiService.ReportStateAndNotification) call. It
    /// may include states, notifications, or both. States and notifications are defined per `device_id` (for example,
    /// "123" and "456" in the following example). # Example ```json { "requestId":
    /// "ff36a3cc-ec34-11e6-b1a0-64510650abcf", "agentUserId": "1234", "payload": { "devices": { "states": { "123": {
    /// "on": true }, "456": { "on": true, "brightness": 10 } }, } } } ```
    /// </summary>
    public class ReportStateAndNotificationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Third-party user ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agentUserId")]
        public virtual string AgentUserId { get; set; }

        /// <summary>Unique identifier per event (for example, a doorbell press).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        /// <summary>Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("followUpToken")]
        public virtual string FollowUpToken { get; set; }

        /// <summary>Required. State of devices to update and notification metadata for devices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payload")]
        public virtual StateAndNotificationPayload Payload { get; set; }

        /// <summary>Request ID used for debugging.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response type for the
    /// [`ReportStateAndNotification`](#google.home.graph.v1.HomeGraphApiService.ReportStateAndNotification) call.
    /// </summary>
    public class ReportStateAndNotificationResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Request ID copied from ReportStateAndNotificationRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Request type for the [`RequestSyncDevices`](#google.home.graph.v1.HomeGraphApiService.RequestSyncDevices) call.
    /// </summary>
    public class RequestSyncDevicesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Third-party user ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agentUserId")]
        public virtual string AgentUserId { get; set; }

        /// <summary>
        /// Optional. If set, the request will be added to a queue and a response will be returned immediately. This
        /// enables concurrent requests for the given `agent_user_id`, but the caller will not receive any error
        /// responses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("async")]
        public virtual System.Nullable<bool> Async__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response type for the [`RequestSyncDevices`](#google.home.graph.v1.HomeGraphApiService.RequestSyncDevices) call.
    /// Intentionally empty upon success. An HTTP response code is returned with more details upon failure.
    /// </summary>
    public class RequestSyncDevicesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Payload containing the state and notification information for devices.</summary>
    public class StateAndNotificationPayload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The devices for updating state and sending notifications.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("devices")]
        public virtual ReportStateAndNotificationDevice Devices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request type for the [`Sync`](#google.home.graph.v1.HomeGraphApiService.Sync) call.</summary>
    public class SyncRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Third-party user ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agentUserId")]
        public virtual string AgentUserId { get; set; }

        /// <summary>Request ID used for debugging.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response type for the [`Sync`](#google.home.graph.v1.HomeGraphApiService.Sync) call. This should follow the same
    /// format as the Google smart home `action.devices.SYNC`
    /// [response](https://developers.google.com/assistant/smarthome/reference/intent/sync). # Example ```json {
    /// "requestId": "ff36a3cc-ec34-11e6-b1a0-64510650abcf", "payload": { "agentUserId": "1836.15267389", "devices": [{
    /// "id": "123", "type": "action.devices.types.OUTLET", "traits": [ "action.devices.traits.OnOff" ], "name": {
    /// "defaultNames": ["My Outlet 1234"], "name": "Night light", "nicknames": ["wall plug"] }, "willReportState":
    /// false, "deviceInfo": { "manufacturer": "lights-out-inc", "model": "hs1234", "hwVersion": "3.2", "swVersion":
    /// "11.4" }, "customData": { "fooValue": 74, "barValue": true, "bazValue": "foo" } }] } } ```
    /// </summary>
    public class SyncResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Devices associated with the third-party user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payload")]
        public virtual SyncResponsePayload Payload { get; set; }

        /// <summary>Request ID used for debugging. Copied from the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Payload containing device information.</summary>
    public class SyncResponsePayload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Third-party user ID</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agentUserId")]
        public virtual string AgentUserId { get; set; }

        /// <summary>Devices associated with the third-party user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("devices")]
        public virtual System.Collections.Generic.IList<Device> Devices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
