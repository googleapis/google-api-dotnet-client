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

namespace Google.Apis.FirebaseCloudMessaging.v1
{
    /// <summary>The FirebaseCloudMessaging Service.</summary>
    public class FirebaseCloudMessagingService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public FirebaseCloudMessagingService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public FirebaseCloudMessagingService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "fcm";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://fcm.googleapis.com/";
        #else
            "https://fcm.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://fcm.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Firebase Cloud Messaging API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Firebase Cloud Messaging API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for FirebaseCloudMessaging requests.</summary>
    public abstract class FirebaseCloudMessagingBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new FirebaseCloudMessagingBaseServiceRequest instance.</summary>
        protected FirebaseCloudMessagingBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes FirebaseCloudMessaging parameter list.</summary>
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
            Messages = new MessagesResource(service);
        }

        /// <summary>Gets the Messages resource.</summary>
        public virtual MessagesResource Messages { get; }

        /// <summary>The "messages" collection of methods.</summary>
        public class MessagesResource
        {
            private const string Resource = "messages";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public MessagesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Send a message to specified target (a registration token, topic or condition).</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. It contains the Firebase project id (i.e. the unique identifier for your Firebase project), in
            /// the format of `projects/{project_id}`. For legacy support, the numeric project number with no padding is
            /// also supported in the format of `projects/{project_number}`.
            /// </param>
            public virtual SendRequest Send(Google.Apis.FirebaseCloudMessaging.v1.Data.SendMessageRequest body, string parent)
            {
                return new SendRequest(service, body, parent);
            }

            /// <summary>Send a message to specified target (a registration token, topic or condition).</summary>
            public class SendRequest : FirebaseCloudMessagingBaseServiceRequest<Google.Apis.FirebaseCloudMessaging.v1.Data.Message>
            {
                /// <summary>Constructs a new Send request.</summary>
                public SendRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseCloudMessaging.v1.Data.SendMessageRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. It contains the Firebase project id (i.e. the unique identifier for your Firebase
                /// project), in the format of `projects/{project_id}`. For legacy support, the numeric project number
                /// with no padding is also supported in the format of `projects/{project_number}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseCloudMessaging.v1.Data.SendMessageRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "send";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/messages:send";

                /// <summary>Initializes Send parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                }
            }
        }
    }
}
namespace Google.Apis.FirebaseCloudMessaging.v1.Data
{
    /// <summary>
    /// Android specific options for messages sent through [FCM connection server](https://goo.gl/4GLdUl).
    /// </summary>
    public class AndroidConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An identifier of a group of messages that can be collapsed, so that only the last message gets sent when
        /// delivery can be resumed. A maximum of 4 different collapse keys is allowed at any given time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collapseKey")]
        public virtual string CollapseKey { get; set; }

        /// <summary>
        /// Arbitrary key/value payload. If present, it will override google.firebase.fcm.v1.Message.data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual System.Collections.Generic.IDictionary<string, string> Data { get; set; }

        /// <summary>
        /// If set to true, messages will be allowed to be delivered to the app while the device is in direct boot mode.
        /// See [Support Direct Boot mode](https://developer.android.com/training/articles/direct-boot).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("directBootOk")]
        public virtual System.Nullable<bool> DirectBootOk { get; set; }

        /// <summary>Options for features provided by the FCM SDK for Android.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fcmOptions")]
        public virtual AndroidFcmOptions FcmOptions { get; set; }

        /// <summary>Notification to send to android devices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notification")]
        public virtual AndroidNotification Notification { get; set; }

        /// <summary>
        /// Message priority. Can take "normal" and "high" values. For more information, see [Setting the priority of a
        /// message](https://goo.gl/GjONJv).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual string Priority { get; set; }

        /// <summary>
        /// Package name of the application where the registration token must match in order to receive the message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictedPackageName")]
        public virtual string RestrictedPackageName { get; set; }

        /// <summary>
        /// How long (in seconds) the message should be kept in FCM storage if the device is offline. The maximum time
        /// to live supported is 4 weeks, and the default value is 4 weeks if not set. Set it to 0 if want to send the
        /// message immediately. In JSON format, the Duration type is encoded as a string rather than an object, where
        /// the string ends in the suffix "s" (indicating seconds) and is preceded by the number of seconds, with
        /// nanoseconds expressed as fractional seconds. For example, 3 seconds with 0 nanoseconds should be encoded in
        /// JSON format as "3s", while 3 seconds and 1 nanosecond should be expressed in JSON format as "3.000000001s".
        /// The ttl will be rounded down to the nearest second.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ttl")]
        public virtual object Ttl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options for features provided by the FCM SDK for Android.</summary>
    public class AndroidFcmOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Label associated with the message's analytics data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analyticsLabel")]
        public virtual string AnalyticsLabel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Notification to send to android devices.</summary>
    public class AndroidNotification : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The notification's body text. If present, it will override google.firebase.fcm.v1.Notification.body.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("body")]
        public virtual string Body { get; set; }

        /// <summary>
        /// Variable string values to be used in place of the format specifiers in body_loc_key to use to localize the
        /// body text to the user's current localization. See [Formatting and Styling](https://goo.gl/MalYE3) for more
        /// information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bodyLocArgs")]
        public virtual System.Collections.Generic.IList<string> BodyLocArgs { get; set; }

        /// <summary>
        /// The key to the body string in the app's string resources to use to localize the body text to the user's
        /// current localization. See [String Resources](https://goo.gl/NdFZGI) for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bodyLocKey")]
        public virtual string BodyLocKey { get; set; }

        /// <summary>
        /// The [notification's channel
        /// id](https://developer.android.com/guide/topics/ui/notifiers/notifications#ManageChannels) (new in Android
        /// O). The app must create a channel with this channel ID before any notification with this channel ID is
        /// received. If you don't send this channel ID in the request, or if the channel ID provided has not yet been
        /// created by the app, FCM uses the channel ID specified in the app manifest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelId")]
        public virtual string ChannelId { get; set; }

        /// <summary>
        /// The action associated with a user click on the notification. If specified, an activity with a matching
        /// intent filter is launched when a user clicks on the notification.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clickAction")]
        public virtual string ClickAction { get; set; }

        /// <summary>The notification's icon color, expressed in #rrggbb format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual string Color { get; set; }

        /// <summary>
        /// If set to true, use the Android framework's default LED light settings for the notification. Default values
        /// are specified in
        /// [config.xml](https://android.googlesource.com/platform/frameworks/base/+/master/core/res/res/values/config.xml).
        /// If `default_light_settings` is set to true and `light_settings` is also set, the user-specified
        /// `light_settings` is used instead of the default value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultLightSettings")]
        public virtual System.Nullable<bool> DefaultLightSettings { get; set; }

        /// <summary>
        /// If set to true, use the Android framework's default sound for the notification. Default values are specified
        /// in
        /// [config.xml](https://android.googlesource.com/platform/frameworks/base/+/master/core/res/res/values/config.xml).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultSound")]
        public virtual System.Nullable<bool> DefaultSound { get; set; }

        /// <summary>
        /// If set to true, use the Android framework's default vibrate pattern for the notification. Default values are
        /// specified in
        /// [config.xml](https://android.googlesource.com/platform/frameworks/base/+/master/core/res/res/values/config.xml).
        /// If `default_vibrate_timings` is set to true and `vibrate_timings` is also set, the default value is used
        /// instead of the user-specified `vibrate_timings`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultVibrateTimings")]
        public virtual System.Nullable<bool> DefaultVibrateTimings { get; set; }

        /// <summary>
        /// Set the time that the event in the notification occurred. Notifications in the panel are sorted by this
        /// time. A point in time is represented using
        /// [protobuf.Timestamp](https://developers.google.com/protocol-buffers/docs/reference/java/com/google/protobuf/Timestamp).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTime")]
        public virtual object EventTime { get; set; }

        /// <summary>
        /// The notification's icon. Sets the notification icon to myicon for drawable resource myicon. If you don't
        /// send this key in the request, FCM displays the launcher icon specified in your app manifest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("icon")]
        public virtual string Icon { get; set; }

        /// <summary>
        /// Contains the URL of an image that is going to be displayed in a notification. If present, it will override
        /// google.firebase.fcm.v1.Notification.image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual string Image { get; set; }

        /// <summary>
        /// Settings to control the notification's LED blinking rate and color if LED is available on the device. The
        /// total blinking time is controlled by the OS.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lightSettings")]
        public virtual LightSettings LightSettings { get; set; }

        /// <summary>
        /// Set whether or not this notification is relevant only to the current device. Some notifications can be
        /// bridged to other devices for remote display, such as a Wear OS watch. This hint can be set to recommend this
        /// notification not be bridged. See [Wear OS
        /// guides](https://developer.android.com/training/wearables/notifications/bridger#existing-method-of-preventing-bridging)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localOnly")]
        public virtual System.Nullable<bool> LocalOnly { get; set; }

        /// <summary>
        /// Sets the number of items this notification represents. May be displayed as a badge count for launchers that
        /// support badging.See [Notification Badge](https://developer.android.com/training/notify-user/badges). For
        /// example, this might be useful if you're using just one notification to represent multiple new messages but
        /// you want the count here to represent the number of total new messages. If zero or unspecified, systems that
        /// support badging use the default, which is to increment a number displayed on the long-press menu each time a
        /// new notification arrives.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationCount")]
        public virtual System.Nullable<int> NotificationCount { get; set; }

        /// <summary>
        /// Set the relative priority for this notification. Priority is an indication of how much of the user's
        /// attention should be consumed by this notification. Low-priority notifications may be hidden from the user in
        /// certain situations, while the user might be interrupted for a higher-priority notification. The effect of
        /// setting the same priorities may differ slightly on different platforms. Note this priority differs from
        /// `AndroidMessagePriority`. This priority is processed by the client after the message has been delivered,
        /// whereas
        /// [AndroidMessagePriority](https://firebase.google.com/docs/reference/fcm/rest/v1/projects.messages#androidmessagepriority)
        /// is an FCM concept that controls when the message is delivered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationPriority")]
        public virtual string NotificationPriority { get; set; }

        /// <summary>
        /// The sound to play when the device receives the notification. Supports "default" or the filename of a sound
        /// resource bundled in the app. Sound files must reside in /res/raw/.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sound")]
        public virtual string Sound { get; set; }

        /// <summary>
        /// When set to false or unset, the notification is automatically dismissed when the user clicks it in the
        /// panel. When set to true, the notification persists even when the user clicks it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sticky")]
        public virtual System.Nullable<bool> Sticky { get; set; }

        /// <summary>
        /// Identifier used to replace existing notifications in the notification drawer. If not specified, each request
        /// creates a new notification. If specified and a notification with the same tag is already being shown, the
        /// new notification replaces the existing one in the notification drawer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tag")]
        public virtual string Tag { get; set; }

        /// <summary>
        /// Sets the "ticker" text, which is sent to accessibility services. Prior to API level 21 (`Lollipop`), sets
        /// the text that is displayed in the status bar when the notification first arrives.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ticker")]
        public virtual string Ticker { get; set; }

        /// <summary>
        /// The notification's title. If present, it will override google.firebase.fcm.v1.Notification.title.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>
        /// Variable string values to be used in place of the format specifiers in title_loc_key to use to localize the
        /// title text to the user's current localization. See [Formatting and Styling](https://goo.gl/MalYE3) for more
        /// information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("titleLocArgs")]
        public virtual System.Collections.Generic.IList<string> TitleLocArgs { get; set; }

        /// <summary>
        /// The key to the title string in the app's string resources to use to localize the title text to the user's
        /// current localization. See [String Resources](https://goo.gl/NdFZGI) for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("titleLocKey")]
        public virtual string TitleLocKey { get; set; }

        /// <summary>
        /// Set the vibration pattern to use. Pass in an array of
        /// [protobuf.Duration](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.Duration)
        /// to turn on or off the vibrator. The first value indicates the `Duration` to wait before turning the vibrator
        /// on. The next value indicates the `Duration` to keep the vibrator on. Subsequent values alternate between
        /// `Duration` to turn the vibrator off and to turn the vibrator on. If `vibrate_timings` is set and
        /// `default_vibrate_timings` is set to `true`, the default value is used instead of the user-specified
        /// `vibrate_timings`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vibrateTimings")]
        public virtual System.Collections.Generic.IList<object> VibrateTimings { get; set; }

        /// <summary>
        /// Set the
        /// [Notification.visibility](https://developer.android.com/reference/android/app/Notification.html#visibility)
        /// of the notification.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visibility")]
        public virtual string Visibility { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>[Apple Push Notification Service](https://goo.gl/MXRTPa) specific options.</summary>
    public class ApnsConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Options for features provided by the FCM SDK for iOS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fcmOptions")]
        public virtual ApnsFcmOptions FcmOptions { get; set; }

        /// <summary>
        /// HTTP request headers defined in Apple Push Notification Service. Refer to [APNs request
        /// headers](https://developer.apple.com/documentation/usernotifications/setting_up_a_remote_notification_server/sending_notification_requests_to_apns)
        /// for supported headers such as `apns-expiration` and `apns-priority`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headers")]
        public virtual System.Collections.Generic.IDictionary<string, string> Headers { get; set; }

        /// <summary>
        /// APNs payload as a JSON object, including both `aps` dictionary and custom payload. See [Payload Key
        /// Reference](https://developer.apple.com/documentation/usernotifications/setting_up_a_remote_notification_server/generating_a_remote_notification).
        /// If present, it overrides google.firebase.fcm.v1.Notification.title and
        /// google.firebase.fcm.v1.Notification.body. The backend sets a default value for `apns-expiration` of 30 days
        /// and a default value for `apns-priority` of 10 if not explicitly set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payload")]
        public virtual System.Collections.Generic.IDictionary<string, object> Payload { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options for features provided by the FCM SDK for iOS.</summary>
    public class ApnsFcmOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Label associated with the message's analytics data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analyticsLabel")]
        public virtual string AnalyticsLabel { get; set; }

        /// <summary>
        /// Contains the URL of an image that is going to be displayed in a notification. If present, it will override
        /// google.firebase.fcm.v1.Notification.image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual string Image { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a color in the RGBA color space. This representation is designed for simplicity of conversion to/from
    /// color representations in various languages over compactness. For example, the fields of this representation can
    /// be trivially provided to the constructor of `java.awt.Color` in Java; it can also be trivially provided to
    /// UIColor's `+colorWithRed:green:blue:alpha` method in iOS; and, with just a little work, it can be easily
    /// formatted into a CSS `rgba()` string in JavaScript. This reference page doesn't carry information about the
    /// absolute color space that should be used to interpret the RGB value (e.g. sRGB, Adobe RGB, DCI-P3, BT.2020,
    /// etc.). By default, applications should assume the sRGB color space. When color equality needs to be decided,
    /// implementations, unless documented otherwise, treat two colors as equal if all their red, green, blue, and alpha
    /// values each differ by at most 1e-5. Example (Java): import com.google.type.Color; // ... public static
    /// java.awt.Color fromProto(Color protocolor) { float alpha = protocolor.hasAlpha() ?
    /// protocolor.getAlpha().getValue() : 1.0; return new java.awt.Color( protocolor.getRed(), protocolor.getGreen(),
    /// protocolor.getBlue(), alpha); } public static Color toProto(java.awt.Color color) { float red = (float)
    /// color.getRed(); float green = (float) color.getGreen(); float blue = (float) color.getBlue(); float denominator
    /// = 255.0; Color.Builder resultBuilder = Color .newBuilder() .setRed(red / denominator) .setGreen(green /
    /// denominator) .setBlue(blue / denominator); int alpha = color.getAlpha(); if (alpha != 255) { result.setAlpha(
    /// FloatValue .newBuilder() .setValue(((float) alpha) / denominator) .build()); } return resultBuilder.build(); }
    /// // ... Example (iOS / Obj-C): // ... static UIColor* fromProto(Color* protocolor) { float red = [protocolor
    /// red]; float green = [protocolor green]; float blue = [protocolor blue]; FloatValue* alpha_wrapper = [protocolor
    /// alpha]; float alpha = 1.0; if (alpha_wrapper != nil) { alpha = [alpha_wrapper value]; } return [UIColor
    /// colorWithRed:red green:green blue:blue alpha:alpha]; } static Color* toProto(UIColor* color) { CGFloat red,
    /// green, blue, alpha; if (![color getRed:&amp;amp;red green:&amp;amp;green blue:&amp;amp;blue
    /// alpha:&amp;amp;alpha]) { return nil; } Color* result = [[Color alloc] init]; [result setRed:red]; [result
    /// setGreen:green]; [result setBlue:blue]; if (alpha &amp;lt;= 0.9999) { [result
    /// setAlpha:floatWrapperWithValue(alpha)]; } [result autorelease]; return result; } // ... Example (JavaScript): //
    /// ... var protoToCssColor = function(rgb_color) { var redFrac = rgb_color.red || 0.0; var greenFrac =
    /// rgb_color.green || 0.0; var blueFrac = rgb_color.blue || 0.0; var red = Math.floor(redFrac * 255); var green =
    /// Math.floor(greenFrac * 255); var blue = Math.floor(blueFrac * 255); if (!('alpha' in rgb_color)) { return
    /// rgbToCssColor(red, green, blue); } var alphaFrac = rgb_color.alpha.value || 0.0; var rgbParams = [red, green,
    /// blue].join(','); return ['rgba(', rgbParams, ',', alphaFrac, ')'].join(''); }; var rgbToCssColor = function(red,
    /// green, blue) { var rgbNumber = new Number((red &amp;lt;&amp;lt; 16) | (green &amp;lt;&amp;lt; 8) | blue); var
    /// hexString = rgbNumber.toString(16); var missingZeros = 6 - hexString.length; var resultBuilder = ['#']; for (var
    /// i = 0; i &amp;lt; missingZeros; i++) { resultBuilder.push('0'); } resultBuilder.push(hexString); return
    /// resultBuilder.join(''); }; // ...
    /// </summary>
    public class Color : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fraction of this color that should be applied to the pixel. That is, the final pixel color is defined by
        /// the equation: `pixel color = alpha * (this color) + (1.0 - alpha) * (background color)` This means that a
        /// value of 1.0 corresponds to a solid color, whereas a value of 0.0 corresponds to a completely transparent
        /// color. This uses a wrapper message rather than a simple float scalar so that it is possible to distinguish
        /// between a default value and the value being unset. If omitted, this color object is rendered as a solid
        /// color (as if the alpha value had been explicitly given a value of 1.0).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alpha")]
        public virtual System.Nullable<float> Alpha { get; set; }

        /// <summary>The amount of blue in the color as a value in the interval [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blue")]
        public virtual System.Nullable<float> Blue { get; set; }

        /// <summary>The amount of green in the color as a value in the interval [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("green")]
        public virtual System.Nullable<float> Green { get; set; }

        /// <summary>The amount of red in the color as a value in the interval [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("red")]
        public virtual System.Nullable<float> Red { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Platform independent options for features provided by the FCM SDKs.</summary>
    public class FcmOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Label associated with the message's analytics data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analyticsLabel")]
        public virtual string AnalyticsLabel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings to control notification LED.</summary>
    public class LightSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Set `color` of the LED with
        /// [google.type.Color](https://github.com/googleapis/googleapis/blob/master/google/type/color.proto).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual Color Color { get; set; }

        /// <summary>
        /// Required. Along with `light_on_duration `, define the blink rate of LED flashes. Resolution defined by
        /// [proto.Duration](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.Duration)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lightOffDuration")]
        public virtual object LightOffDuration { get; set; }

        /// <summary>
        /// Required. Along with `light_off_duration`, define the blink rate of LED flashes. Resolution defined by
        /// [proto.Duration](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.Duration)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lightOnDuration")]
        public virtual object LightOnDuration { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message to send by Firebase Cloud Messaging Service.</summary>
    public class Message : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Input only. Android specific options for messages sent through [FCM connection
        /// server](https://goo.gl/4GLdUl).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("android")]
        public virtual AndroidConfig Android { get; set; }

        /// <summary>Input only. [Apple Push Notification Service](https://goo.gl/MXRTPa) specific options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apns")]
        public virtual ApnsConfig Apns { get; set; }

        /// <summary>Condition to send a message to, e.g. "'foo' in topics &amp;&amp; 'bar' in topics".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual string Condition { get; set; }

        /// <summary>
        /// Input only. Arbitrary key/value payload, which must be UTF-8 encoded. The key should not be a reserved word
        /// ("from", "message_type", or any word starting with "google" or "gcm"). When sending payloads containing only
        /// data fields to iOS devices, only normal priority (`"apns-priority": "5"`) is allowed in
        /// [`ApnsConfig`](/docs/reference/fcm/rest/v1/projects.messages#apnsconfig).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual System.Collections.Generic.IDictionary<string, string> Data { get; set; }

        /// <summary>Input only. Template for FCM SDK feature options to use across all platforms.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fcmOptions")]
        public virtual FcmOptions FcmOptions { get; set; }

        /// <summary>
        /// Output Only. The identifier of the message sent, in the format of `projects/*/messages/{message_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Input only. Basic notification template to use across all platforms.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notification")]
        public virtual Notification Notification { get; set; }

        /// <summary>Registration token to send a message to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>
        /// Topic name to send a message to, e.g. "weather". Note: "/topics/" prefix should not be provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topic")]
        public virtual string Topic { get; set; }

        /// <summary>Input only. [Webpush protocol](https://tools.ietf.org/html/rfc8030) options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webpush")]
        public virtual WebpushConfig Webpush { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Basic notification template to use across all platforms.</summary>
    public class Notification : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The notification's body text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("body")]
        public virtual string Body { get; set; }

        /// <summary>
        /// Contains the URL of an image that is going to be downloaded on the device and displayed in a notification.
        /// JPEG, PNG, BMP have full support across platforms. Animated GIF and video only work on iOS. WebP and HEIF
        /// have varying levels of support across platforms and platform versions. Android has 1MB image size limit.
        /// Quota usage and implications/costs for hosting image on Firebase Storage:
        /// https://firebase.google.com/pricing
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual string Image { get; set; }

        /// <summary>The notification's title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to send a message to specified target.</summary>
    public class SendMessageRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Message to send.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual Message Message { get; set; }

        /// <summary>Flag for testing the request without actually delivering the message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>[Webpush protocol](https://tools.ietf.org/html/rfc8030) options.</summary>
    public class WebpushConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Arbitrary key/value payload. If present, it will override google.firebase.fcm.v1.Message.data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual System.Collections.Generic.IDictionary<string, string> Data { get; set; }

        /// <summary>Options for features provided by the FCM SDK for Web.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fcmOptions")]
        public virtual WebpushFcmOptions FcmOptions { get; set; }

        /// <summary>
        /// HTTP headers defined in webpush protocol. Refer to [Webpush
        /// protocol](https://tools.ietf.org/html/rfc8030#section-5) for supported headers, e.g. "TTL": "15".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headers")]
        public virtual System.Collections.Generic.IDictionary<string, string> Headers { get; set; }

        /// <summary>
        /// Web Notification options as a JSON object. Supports Notification instance properties as defined in [Web
        /// Notification API](https://developer.mozilla.org/en-US/docs/Web/API/Notification). If present, "title" and
        /// "body" fields override [google.firebase.fcm.v1.Notification.title] and
        /// [google.firebase.fcm.v1.Notification.body].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notification")]
        public virtual System.Collections.Generic.IDictionary<string, object> Notification { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options for features provided by the FCM SDK for Web.</summary>
    public class WebpushFcmOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Label associated with the message's analytics data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analyticsLabel")]
        public virtual string AnalyticsLabel { get; set; }

        /// <summary>
        /// The link to open when the user clicks on the notification. For all URL values, HTTPS is required.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("link")]
        public virtual string Link { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
