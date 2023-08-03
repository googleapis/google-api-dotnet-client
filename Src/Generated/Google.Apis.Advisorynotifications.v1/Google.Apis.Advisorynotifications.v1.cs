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

namespace Google.Apis.Advisorynotifications.v1
{
    /// <summary>The Advisorynotifications Service.</summary>
    public class AdvisorynotificationsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AdvisorynotificationsService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AdvisorynotificationsService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Organizations = new OrganizationsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "advisorynotifications";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri => BaseUriOverride ?? "https://advisorynotifications.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://advisorynotifications.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Advisory Notifications API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Advisory Notifications API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Organizations resource.</summary>
        public virtual OrganizationsResource Organizations { get; }
    }

    /// <summary>A base abstract class for Advisorynotifications requests.</summary>
    public abstract class AdvisorynotificationsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new AdvisorynotificationsBaseServiceRequest instance.</summary>
        protected AdvisorynotificationsBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Advisorynotifications parameter list.</summary>
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

    /// <summary>The "organizations" collection of methods.</summary>
    public class OrganizationsResource
    {
        private const string Resource = "organizations";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public OrganizationsResource(Google.Apis.Services.IClientService service)
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
                Notifications = new NotificationsResource(service);
            }

            /// <summary>Gets the Notifications resource.</summary>
            public virtual NotificationsResource Notifications { get; }

            /// <summary>The "notifications" collection of methods.</summary>
            public class NotificationsResource
            {
                private const string Resource = "notifications";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public NotificationsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Gets a notification.</summary>
                /// <param name="name">
                /// Required. A name of the notification to retrieve. Format:
                /// organizations/{organization}/locations/{location}/notifications/{notification}.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets a notification.</summary>
                public class GetRequest : AdvisorynotificationsBaseServiceRequest<Google.Apis.Advisorynotifications.v1.Data.GoogleCloudAdvisorynotificationsV1Notification>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the notification to retrieve. Format:
                    /// organizations/{organization}/locations/{location}/notifications/{notification}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// ISO code for requested localization language. If unset, will be interpereted as "en". If the
                    /// requested language is valid, but not supported for this notification, English will be returned
                    /// with an "Not applicable" LocalizationState. If the ISO code is invalid (i.e. not a real
                    /// language), this RPC will throw an error.
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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/notifications/[^/]+$",
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

                /// <summary>Lists notifications under a given parent.</summary>
                /// <param name="parent">
                /// Required. The parent, which owns this collection of notifications. Must be of the form
                /// "organizations/{organization}/locations/{location}".
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists notifications under a given parent.</summary>
                public class ListRequest : AdvisorynotificationsBaseServiceRequest<Google.Apis.Advisorynotifications.v1.Data.GoogleCloudAdvisorynotificationsV1ListNotificationsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent, which owns this collection of notifications. Must be of the form
                    /// "organizations/{organization}/locations/{location}".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// ISO code for requested localization language. If unset, will be interpereted as "en". If the
                    /// requested language is valid, but not supported for this notification, English will be returned
                    /// with an "Not applicable" LocalizationState. If the ISO code is invalid (i.e. not a real
                    /// language), this RPC will throw an error.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string LanguageCode { get; set; }

                    /// <summary>
                    /// The maximum number of notifications to return. The service may return fewer than this value. If
                    /// unspecified or equal to 0, at most 50 notifications will be returned. The maximum value is 50;
                    /// values above 50 will be coerced to 50.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token returned from a previous request. When paginating, all other parameters provided in
                    /// the request must match the call that returned the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>
                    /// Specifies which parts of the notification resource should be returned in the response.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ViewEnum> View { get; set; }

                    /// <summary>
                    /// Specifies which parts of the notification resource should be returned in the response.
                    /// </summary>
                    public enum ViewEnum
                    {
                        /// <summary>Not specified, equivalent to BASIC.</summary>
                        [Google.Apis.Util.StringValueAttribute("NOTIFICATION_VIEW_UNSPECIFIED")]
                        NOTIFICATIONVIEWUNSPECIFIED = 0,

                        /// <summary>
                        /// Server responses only include title, creation time and Notification ID. Note: for internal
                        /// use responses also include the last update time, the latest message text and whether
                        /// notification has attachments.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("BASIC")]
                        BASIC = 1,

                        /// <summary>Include everything.</summary>
                        [Google.Apis.Util.StringValueAttribute("FULL")]
                        FULL = 2,
                    }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/notifications";

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("languageCode", new Google.Apis.Discovery.Parameter
                        {
                            Name = "languageCode",
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
        }
    }
}
namespace Google.Apis.Advisorynotifications.v1.Data
{
    /// <summary>Attachment with specific information about the issue.</summary>
    public class GoogleCloudAdvisorynotificationsV1Attachment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A CSV file attachment. Max size is 10 MB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("csv")]
        public virtual GoogleCloudAdvisorynotificationsV1Csv Csv { get; set; }

        /// <summary>The title of the attachment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A representation of a CSV file attachment, as a list of column headers and a list of data rows.
    /// </summary>
    public class GoogleCloudAdvisorynotificationsV1Csv : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of data rows in a CSV file, as string arrays rather than as a single comma-separated string.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataRows")]
        public virtual System.Collections.Generic.IList<GoogleCloudAdvisorynotificationsV1CsvCsvRow> DataRows { get; set; }

        /// <summary>The list of headers for data columns in a CSV file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headers")]
        public virtual System.Collections.Generic.IList<string> Headers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A representation of a single data row in a CSV file.</summary>
    public class GoogleCloudAdvisorynotificationsV1CsvCsvRow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The data entries in a CSV file row, as a string array rather than a single comma-separated string.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<string> Entries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of ListNotifications endpoint.</summary>
    public class GoogleCloudAdvisorynotificationsV1ListNotificationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of notifications under a given parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notifications")]
        public virtual System.Collections.Generic.IList<GoogleCloudAdvisorynotificationsV1Notification> Notifications { get; set; }

        /// <summary>Estimation of a total number of notifications.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message which contains notification details.</summary>
    public class GoogleCloudAdvisorynotificationsV1Message : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The attachments to download.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachments")]
        public virtual System.Collections.Generic.IList<GoogleCloudAdvisorynotificationsV1Attachment> Attachments { get; set; }

        /// <summary>The message content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("body")]
        public virtual GoogleCloudAdvisorynotificationsV1MessageBody Body { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>The Message creation timestamp.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        private string _localizationTimeRaw;

        private object _localizationTime;

        /// <summary>Time when Message was localized</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizationTime")]
        public virtual string LocalizationTimeRaw
        {
            get => _localizationTimeRaw;
            set
            {
                _localizationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _localizationTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LocalizationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LocalizationTimeDateTimeOffset instead.")]
        public virtual object LocalizationTime
        {
            get => _localizationTime;
            set
            {
                _localizationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _localizationTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LocalizationTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LocalizationTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(LocalizationTimeRaw);
            set => LocalizationTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message body containing text.</summary>
    public class GoogleCloudAdvisorynotificationsV1MessageBody : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The text content of the message body.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual GoogleCloudAdvisorynotificationsV1Text Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A notification object for notifying customers about security and privacy issues.</summary>
    public class GoogleCloudAdvisorynotificationsV1Notification : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time the notification was created.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>A list of messages in the notification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<GoogleCloudAdvisorynotificationsV1Message> Messages { get; set; }

        /// <summary>
        /// The resource name of the notification. Format:
        /// organizations/{organization}/locations/{location}/notifications/{notification}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Type of notification</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationType")]
        public virtual string NotificationType { get; set; }

        /// <summary>The subject line of the notification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subject")]
        public virtual GoogleCloudAdvisorynotificationsV1Subject Subject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A subject line of a notification.</summary>
    public class GoogleCloudAdvisorynotificationsV1Subject : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The text content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual GoogleCloudAdvisorynotificationsV1Text Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A text object containing the English text and its localized copies.</summary>
    public class GoogleCloudAdvisorynotificationsV1Text : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The English copy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enText")]
        public virtual string EnText { get; set; }

        /// <summary>Status of the localization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizationState")]
        public virtual string LocalizationState { get; set; }

        /// <summary>The requested localized copy (if applicable).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedText")]
        public virtual string LocalizedText { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
