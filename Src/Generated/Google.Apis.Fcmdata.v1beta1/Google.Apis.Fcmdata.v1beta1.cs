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

namespace Google.Apis.Fcmdata.v1beta1
{
    /// <summary>The Fcmdata Service.</summary>
    public class FcmdataService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public FcmdataService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public FcmdataService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "fcmdata";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://fcmdata.googleapis.com/";
        #else
            "https://fcmdata.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://fcmdata.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Firebase Cloud Messaging Data API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Firebase Cloud Messaging Data API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for Fcmdata requests.</summary>
    public abstract class FcmdataBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new FcmdataBaseServiceRequest instance.</summary>
        protected FcmdataBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Fcmdata parameter list.</summary>
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
            AndroidApps = new AndroidAppsResource(service);
        }

        /// <summary>Gets the AndroidApps resource.</summary>
        public virtual AndroidAppsResource AndroidApps { get; }

        /// <summary>The "androidApps" collection of methods.</summary>
        public class AndroidAppsResource
        {
            private const string Resource = "androidApps";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AndroidAppsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                DeliveryData = new DeliveryDataResource(service);
            }

            /// <summary>Gets the DeliveryData resource.</summary>
            public virtual DeliveryDataResource DeliveryData { get; }

            /// <summary>The "deliveryData" collection of methods.</summary>
            public class DeliveryDataResource
            {
                private const string Resource = "deliveryData";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DeliveryDataResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>List aggregate delivery data for the given Android application.</summary>
                /// <param name="parent">
                /// Required. The application for which to list delivery data. Format:
                /// `projects/{project_id}/androidApps/{app_id}`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>List aggregate delivery data for the given Android application.</summary>
                public class ListRequest : FcmdataBaseServiceRequest<Google.Apis.Fcmdata.v1beta1.Data.GoogleFirebaseFcmDataV1beta1ListAndroidDeliveryDataResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The application for which to list delivery data. Format:
                    /// `projects/{project_id}/androidApps/{app_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of entries to return. The service may return fewer than this value. If
                    /// unspecified, at most 1,000 entries will be returned. The maximum value is 10,000; values above
                    /// 10,000 will be capped to 10,000. This default may change over time.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `ListAndroidDeliveryDataRequest` call. Provide this to
                    /// retrieve the subsequent page. When paginating, all other parameters provided to
                    /// `ListAndroidDeliveryDataRequest` must match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/deliveryData";

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
                            Pattern = @"^projects/[^/]+/androidApps/[^/]+$",
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
}
namespace Google.Apis.Fcmdata.v1beta1.Data
{
    /// <summary>Message delivery data for a given date, app, and analytics label combination.</summary>
    public class GoogleFirebaseFcmDataV1beta1AndroidDeliveryData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The analytics label associated with the messages sent. All messages sent without an analytics label will be
        /// grouped together in a single entry.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analyticsLabel")]
        public virtual string AnalyticsLabel { get; set; }

        /// <summary>The app ID to which the messages were sent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appId")]
        public virtual string AppId { get; set; }

        /// <summary>The data for the specified appId, date, and analyticsLabel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual GoogleFirebaseFcmDataV1beta1Data Data { get; set; }

        /// <summary>The date represented by this entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual GoogleTypeDate Date { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data detailing messaging delivery</summary>
    public class GoogleFirebaseFcmDataV1beta1Data : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Count of messages accepted by FCM intended to Android devices. The targeted device must have opted in to the
        /// collection of usage and diagnostic information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countMessagesAccepted")]
        public virtual System.Nullable<long> CountMessagesAccepted { get; set; }

        /// <summary>
        /// Additional information about delivery performance for messages that were successfully delivered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliveryPerformancePercents")]
        public virtual GoogleFirebaseFcmDataV1beta1DeliveryPerformancePercents DeliveryPerformancePercents { get; set; }

        /// <summary>Additional general insights about message delivery.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageInsightPercents")]
        public virtual GoogleFirebaseFcmDataV1beta1MessageInsightPercents MessageInsightPercents { get; set; }

        /// <summary>Mutually exclusive breakdown of message delivery outcomes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageOutcomePercents")]
        public virtual GoogleFirebaseFcmDataV1beta1MessageOutcomePercents MessageOutcomePercents { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Overview of delivery performance for messages that were successfully delivered. All percentages are calculated
    /// with countMessagesAccepted as the denominator. These categories are not mutually exclusive; a message can be
    /// delayed for multiple reasons.
    /// </summary>
    public class GoogleFirebaseFcmDataV1beta1DeliveryPerformancePercents : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The percentage of accepted messages that were delayed because the device was in doze mode. Only [normal
        /// priority
        /// messages](https://firebase.google.com/docs/cloud-messaging/concept-options#setting-the-priority-of-a-message)
        /// should be delayed due to doze mode.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delayedDeviceDoze")]
        public virtual System.Nullable<float> DelayedDeviceDoze { get; set; }

        /// <summary>
        /// The percentage of accepted messages that were delayed because the target device was not connected at the
        /// time of sending. These messages were eventually delivered when the device reconnected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delayedDeviceOffline")]
        public virtual System.Nullable<float> DelayedDeviceOffline { get; set; }

        /// <summary>
        /// The percentage of accepted messages that were delayed due to message throttling, such as [collapsible
        /// message throttling](https://firebase.google.com/docs/cloud-messaging/concept-options#collapsible_throttling)
        /// or [maximum message rate
        /// throttling](https://firebase.google.com/docs/cloud-messaging/concept-options#device_throttling).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delayedMessageThrottled")]
        public virtual System.Nullable<float> DelayedMessageThrottled { get; set; }

        /// <summary>
        /// The percentage of accepted messages that were delayed because the intended device user-profile was
        /// [stopped](https://firebase.google.com/docs/cloud-messaging/android/receive#handling_messages) on the target
        /// device at the time of the send. The messages were eventually delivered when the user-profile was started
        /// again.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delayedUserStopped")]
        public virtual System.Nullable<float> DelayedUserStopped { get; set; }

        /// <summary>
        /// The percentage of accepted messages that were delivered to the device without delay from the FCM system.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliveredNoDelay")]
        public virtual System.Nullable<float> DeliveredNoDelay { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListAndroidDeliveryData.</summary>
    public class GoogleFirebaseFcmDataV1beta1ListAndroidDeliveryDataResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The delivery data for the provided app. There will be one entry per combination of app, date, and analytics
        /// label.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidDeliveryData")]
        public virtual System.Collections.Generic.IList<GoogleFirebaseFcmDataV1beta1AndroidDeliveryData> AndroidDeliveryData { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Additional information about message delivery. All percentages are calculated with countMessagesAccepted as the
    /// denominator.
    /// </summary>
    public class GoogleFirebaseFcmDataV1beta1MessageInsightPercents : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The percentage of accepted messages that had their priority lowered from high to normal due to [app standby
        /// buckets](https://firebase.google.com/docs/cloud-messaging/concept-options#setting-the-priority-of-a-message).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priorityLowered")]
        public virtual System.Nullable<float> PriorityLowered { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Percentage breakdown of message delivery outcomes. These categories are mutually exclusive. All percentages are
    /// calculated with countMessagesAccepted as the denominator. These categories may not account for all message
    /// outcomes.
    /// </summary>
    public class GoogleFirebaseFcmDataV1beta1MessageOutcomePercents : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The percentage of all accepted messages that were successfully delivered to the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delivered")]
        public virtual System.Nullable<float> Delivered { get; set; }

        /// <summary>
        /// The percentage of accepted messages that were dropped because the application was force stopped on the
        /// device at the time of delivery and retries were unsuccessful.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("droppedAppForceStopped")]
        public virtual System.Nullable<float> DroppedAppForceStopped { get; set; }

        /// <summary>
        /// The percentage of accepted messages that were dropped because the target device is inactive. FCM will drop
        /// messages if the target device is deemed inactive by our servers. If a device does reconnect, we call
        /// [OnDeletedMessages()](https://firebase.google.com/docs/cloud-messaging/android/receive#override-ondeletedmessages)
        /// in our SDK instead of delivering the messages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("droppedDeviceInactive")]
        public virtual System.Nullable<float> DroppedDeviceInactive { get; set; }

        /// <summary>
        /// The percentage of accepted messages that were dropped due to [too many undelivered non-collapsible
        /// messages](https://firebase.google.com/docs/cloud-messaging/concept-options#collapsible_and_non-collapsible_messages).
        /// Specifically, each app instance can only have 100 pending messages stored on our servers for a device which
        /// is disconnected. When that device reconnects, those messages are delivered. When there are more than the
        /// maximum pending messages, we call
        /// [OnDeletedMessages()](https://firebase.google.com/docs/cloud-messaging/android/receive#override-ondeletedmessages)
        /// in our SDK instead of delivering the messages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("droppedTooManyPendingMessages")]
        public virtual System.Nullable<float> DroppedTooManyPendingMessages { get; set; }

        /// <summary>
        /// The percentage of messages accepted on this day that were not dropped and not delivered, due to the device
        /// being disconnected (as of the end of the America/Los_Angeles day when the message was sent to FCM). A
        /// portion of these messages will be delivered the next day when the device connects but others may be destined
        /// to devices that ultimately never reconnect.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pending")]
        public virtual System.Nullable<float> Pending { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a whole or partial calendar date, such as a birthday. The time of day and time zone are either
    /// specified elsewhere or are insignificant. The date is relative to the Gregorian Calendar. This can represent one
    /// of the following: * A full date, with non-zero year, month, and day values * A month and day value, with a zero
    /// year, such as an anniversary * A year on its own, with zero month and day values * A year and month value, with
    /// a zero day, such as a credit card expiration date Related types are google.type.TimeOfDay and
    /// `google.protobuf.Timestamp`.
    /// </summary>
    public class GoogleTypeDate : Google.Apis.Requests.IDirectResponseSchema
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
}
