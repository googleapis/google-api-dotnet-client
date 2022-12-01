// Copyright 2022 Google LLC
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

namespace Google.Apis.DriveLabels.v2
{
    /// <summary>The DriveLabels Service.</summary>
    public class DriveLabelsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DriveLabelsService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DriveLabelsService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Labels = new LabelsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "drivelabels";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri => BaseUriOverride ?? "https://drivelabels.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://drivelabels.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Gets the Labels resource.</summary>
        public virtual LabelsResource Labels { get; }
    }

    /// <summary>A base abstract class for DriveLabels requests.</summary>
    public abstract class DriveLabelsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new DriveLabelsBaseServiceRequest instance.</summary>
        protected DriveLabelsBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes DriveLabels parameter list.</summary>
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

    /// <summary>The "labels" collection of methods.</summary>
    public class LabelsResource
    {
        private const string Resource = "labels";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public LabelsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Get a label by its resource name. Resource name may be any of: * `labels/{id}` - See `labels/{id}@latest` *
        /// `labels/{id}@latest` - Gets the latest revision of the label. * `labels/{id}@published` - Gets the current
        /// published revision of the label. * `labels/{id}@{revision_id}` - Gets the label at the specified revision
        /// ID.
        /// </summary>
        /// <param name="name">
        /// Required. Label resource name. May be any of: * `labels/{id}` (equivalent to labels/{id}@latest) *
        /// `labels/{id}@latest` * `labels/{id}@published` * `labels/{id}@{revision_id}`
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>
        /// Get a label by its resource name. Resource name may be any of: * `labels/{id}` - See `labels/{id}@latest` *
        /// `labels/{id}@latest` - Gets the latest revision of the label. * `labels/{id}@published` - Gets the current
        /// published revision of the label. * `labels/{id}@{revision_id}` - Gets the label at the specified revision
        /// ID.
        /// </summary>
        public class GetRequest : DriveLabelsBaseServiceRequest<Google.Apis.DriveLabels.v2.Data.GoogleAppsDriveLabelsV2Label>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. Label resource name. May be any of: * `labels/{id}` (equivalent to labels/{id}@latest) *
            /// `labels/{id}@latest` * `labels/{id}@published` * `labels/{id}@{revision_id}`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// The BCP-47 language code to use for evaluating localized field labels. When not specified, values in the
            /// default configured language are used.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string LanguageCode { get; set; }

            /// <summary>
            /// Set to `true` in order to use the user's admin credentials. The server verifies that the user is an
            /// admin for the label before allowing access.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("useAdminAccess", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> UseAdminAccess { get; set; }

            /// <summary>When specified, only certain fields belonging to the indicated view are returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewEnum> View { get; set; }

            /// <summary>When specified, only certain fields belonging to the indicated view are returned.</summary>
            public enum ViewEnum
            {
                /// <summary>Implies the field mask: `name,id,revision_id,label_type,properties.*`</summary>
                [Google.Apis.Util.StringValueAttribute("LABEL_VIEW_BASIC")]
                LABELVIEWBASIC = 0,

                /// <summary>All possible fields.</summary>
                [Google.Apis.Util.StringValueAttribute("LABEL_VIEW_FULL")]
                LABELVIEWFULL = 1,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/{+name}";

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
                    Pattern = @"^labels/[^/]+$",
                });
                RequestParameters.Add("languageCode", new Google.Apis.Discovery.Parameter
                {
                    Name = "languageCode",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("useAdminAccess", new Google.Apis.Discovery.Parameter
                {
                    Name = "useAdminAccess",
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

        /// <summary>List labels.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>List labels.</summary>
        public class ListRequest : DriveLabelsBaseServiceRequest<Google.Apis.DriveLabels.v2.Data.GoogleAppsDriveLabelsV2ListLabelsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// The BCP-47 language code to use for evaluating localized field labels. When not specified, values in the
            /// default configured language are used.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string LanguageCode { get; set; }

            /// <summary>
            /// Specifies the level of access the user must have on the returned Labels. The minimum role a user must
            /// have on a label. Defaults to `READER`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("minimumRole", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<MinimumRoleEnum> MinimumRole { get; set; }

            /// <summary>
            /// Specifies the level of access the user must have on the returned Labels. The minimum role a user must
            /// have on a label. Defaults to `READER`.
            /// </summary>
            public enum MinimumRoleEnum
            {
                /// <summary>Unknown role.</summary>
                [Google.Apis.Util.StringValueAttribute("LABEL_ROLE_UNSPECIFIED")]
                LABELROLEUNSPECIFIED = 0,

                /// <summary>A reader can read the label and associated metadata applied to Drive items.</summary>
                [Google.Apis.Util.StringValueAttribute("READER")]
                READER = 1,

                /// <summary>
                /// An applier can write associated metadata on Drive items in which they also have write access to.
                /// Implies `READER`.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("APPLIER")]
                APPLIER = 2,

                /// <summary>
                /// An organizer can pin this label in shared drives they manage and add new appliers to the label.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("ORGANIZER")]
                ORGANIZER = 3,

                /// <summary>
                /// Editors can make any update including deleting the label which also deletes the associated Drive
                /// item metadata. Implies `APPLIER`.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("EDITOR")]
                EDITOR = 4,
            }

            /// <summary>Maximum number of labels to return per page. Default: 50. Max: 200.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>The token of the page to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Whether to include only published labels in the results. * When `true`, only the current published label
            /// revisions are returned. Disabled labels are included. Returned label resource names reference the
            /// published revision (`labels/{id}/{revision_id}`). * When `false`, the current label revisions are
            /// returned, which might not be published. Returned label resource names don't reference a specific
            /// revision (`labels/{id}`).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("publishedOnly", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> PublishedOnly { get; set; }

            /// <summary>
            /// Set to `true` in order to use the user's admin credentials. This will return all Labels within the
            /// customer.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("useAdminAccess", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> UseAdminAccess { get; set; }

            /// <summary>When specified, only certain fields belonging to the indicated view are returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewEnum> View { get; set; }

            /// <summary>When specified, only certain fields belonging to the indicated view are returned.</summary>
            public enum ViewEnum
            {
                /// <summary>Implies the field mask: `name,id,revision_id,label_type,properties.*`</summary>
                [Google.Apis.Util.StringValueAttribute("LABEL_VIEW_BASIC")]
                LABELVIEWBASIC = 0,

                /// <summary>All possible fields.</summary>
                [Google.Apis.Util.StringValueAttribute("LABEL_VIEW_FULL")]
                LABELVIEWFULL = 1,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/labels";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("languageCode", new Google.Apis.Discovery.Parameter
                {
                    Name = "languageCode",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("minimumRole", new Google.Apis.Discovery.Parameter
                {
                    Name = "minimumRole",
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
                RequestParameters.Add("publishedOnly", new Google.Apis.Discovery.Parameter
                {
                    Name = "publishedOnly",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("useAdminAccess", new Google.Apis.Discovery.Parameter
                {
                    Name = "useAdminAccess",
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
namespace Google.Apis.DriveLabels.v2.Data
{
    /// <summary>The color derived from BadgeConfig and changed to the closest recommended supported color.</summary>
    public class GoogleAppsDriveLabelsV2BadgeColors : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Badge background that pairs with the foreground.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backgroundColor")]
        public virtual GoogleTypeColor BackgroundColor { get; set; }

        /// <summary>Output only. Badge foreground that pairs with the background.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("foregroundColor")]
        public virtual GoogleTypeColor ForegroundColor { get; set; }

        /// <summary>Output only. Color that can be used for text without a background.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("soloColor")]
        public virtual GoogleTypeColor SoloColor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Badge status of the label.</summary>
    public class GoogleAppsDriveLabelsV2BadgeConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The color of the badge. When not specified, no badge is rendered. The background, foreground, and solo
        /// (light and dark mode) colors set here are changed in the Drive UI into the closest recommended supported
        /// color.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual GoogleTypeColor Color { get; set; }

        /// <summary>
        /// Override the default global priority of this badge. When set to 0, the default priority heuristic is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priorityOverride")]
        public virtual System.Nullable<long> PriorityOverride { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines a field that has a display name, data type, and other configuration options. This field defines the kind
    /// of metadata that may be set on a Drive item.
    /// </summary>
    public class GoogleAppsDriveLabelsV2Field : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The capabilities this user has on this field and its value when the label is applied on Drive
        /// items.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appliedCapabilities")]
        public virtual GoogleAppsDriveLabelsV2FieldAppliedCapabilities AppliedCapabilities { get; set; }

        /// <summary>Output only. The time this field was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The user who created this field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creator")]
        public virtual GoogleAppsDriveLabelsV2UserInfo Creator { get; set; }

        /// <summary>Date field options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateOptions")]
        public virtual GoogleAppsDriveLabelsV2FieldDateOptions DateOptions { get; set; }

        /// <summary>
        /// Output only. The time this field was disabled. This value has no meaning when the field is not disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableTime")]
        public virtual object DisableTime { get; set; }

        /// <summary>
        /// Output only. The user who disabled this field. This value has no meaning when the field is not disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabler")]
        public virtual GoogleAppsDriveLabelsV2UserInfo Disabler { get; set; }

        /// <summary>Output only. UI display hints for rendering a field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayHints")]
        public virtual GoogleAppsDriveLabelsV2FieldDisplayHints DisplayHints { get; set; }

        /// <summary>
        /// Output only. The key of a field, unique within a label or library. This value is autogenerated. Matches the
        /// regex: `([a-zA-Z0-9])+`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Integer field options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integerOptions")]
        public virtual GoogleAppsDriveLabelsV2FieldIntegerOptions IntegerOptions { get; set; }

        /// <summary>Output only. The lifecycle of this field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifecycle")]
        public virtual GoogleAppsDriveLabelsV2Lifecycle Lifecycle { get; set; }

        /// <summary>Output only. The LockStatus of this field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lockStatus")]
        public virtual GoogleAppsDriveLabelsV2LockStatus LockStatus { get; set; }

        /// <summary>The basic properties of the field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual GoogleAppsDriveLabelsV2FieldProperties Properties { get; set; }

        /// <summary>
        /// Output only. The user who published this field. This value has no meaning when the field is not published.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publisher")]
        public virtual GoogleAppsDriveLabelsV2UserInfo Publisher { get; set; }

        /// <summary>
        /// Output only. The key to use when constructing Drive search queries to find files based on values defined for
        /// this field on files. For example, "`{query_key}` &amp;gt; 2001-01-01".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryKey")]
        public virtual string QueryKey { get; set; }

        /// <summary>Output only. The capabilities this user has when editing this field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemaCapabilities")]
        public virtual GoogleAppsDriveLabelsV2FieldSchemaCapabilities SchemaCapabilities { get; set; }

        /// <summary>Selection field options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectionOptions")]
        public virtual GoogleAppsDriveLabelsV2FieldSelectionOptions SelectionOptions { get; set; }

        /// <summary>Text field options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textOptions")]
        public virtual GoogleAppsDriveLabelsV2FieldTextOptions TextOptions { get; set; }

        /// <summary>Output only. The time this field was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>Output only. The user who modified this field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updater")]
        public virtual GoogleAppsDriveLabelsV2UserInfo Updater { get; set; }

        /// <summary>User field options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userOptions")]
        public virtual GoogleAppsDriveLabelsV2FieldUserOptions UserOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The capabilities related to this field on applied metadata.</summary>
    public class GoogleAppsDriveLabelsV2FieldAppliedCapabilities : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the user can read related applied metadata on items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canRead")]
        public virtual System.Nullable<bool> CanRead { get; set; }

        /// <summary>Whether the user can search for Drive items referencing this field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canSearch")]
        public virtual System.Nullable<bool> CanSearch { get; set; }

        /// <summary>Whether the user can set this field on Drive items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canWrite")]
        public virtual System.Nullable<bool> CanWrite { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options for the date field type.</summary>
    public class GoogleAppsDriveLabelsV2FieldDateOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. ICU date format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateFormat")]
        public virtual string DateFormat { get; set; }

        /// <summary>
        /// Localized date formatting option. Field values are rendered in this format according to their locale.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateFormatType")]
        public virtual string DateFormatType { get; set; }

        /// <summary>Output only. Maximum valid value (year, month, day).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxValue")]
        public virtual GoogleTypeDate MaxValue { get; set; }

        /// <summary>Output only. Minimum valid value (year, month, day).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minValue")]
        public virtual GoogleTypeDate MinValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>UI display hints for rendering a field.</summary>
    public class GoogleAppsDriveLabelsV2FieldDisplayHints : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the field should be shown in the UI as disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>This field should be hidden in the search menu when searching for Drive items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hiddenInSearch")]
        public virtual System.Nullable<bool> HiddenInSearch { get; set; }

        /// <summary>Whether the field should be shown as required in the UI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("required")]
        public virtual System.Nullable<bool> Required { get; set; }

        /// <summary>This field should be shown in the apply menu when applying values to a Drive item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shownInApply")]
        public virtual System.Nullable<bool> ShownInApply { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options for the Integer field type.</summary>
    public class GoogleAppsDriveLabelsV2FieldIntegerOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The maximum valid value for the integer field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxValue")]
        public virtual System.Nullable<long> MaxValue { get; set; }

        /// <summary>Output only. The minimum valid value for the integer field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minValue")]
        public virtual System.Nullable<long> MinValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options for a multi-valued variant of an associated field type.</summary>
    public class GoogleAppsDriveLabelsV2FieldListOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Maximum number of entries permitted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxEntries")]
        public virtual System.Nullable<int> MaxEntries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The basic properties of the field.</summary>
    public class GoogleAppsDriveLabelsV2FieldProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The display text to show in the UI identifying this field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Input only. Insert or move this field before the indicated field. If empty, the field is placed at the end
        /// of the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertBeforeField")]
        public virtual string InsertBeforeField { get; set; }

        /// <summary>Whether the field should be marked as required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("required")]
        public virtual System.Nullable<bool> Required { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The capabilities related to this field when editing the field.</summary>
    public class GoogleAppsDriveLabelsV2FieldSchemaCapabilities : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether the user can delete this field. The user must have permission and the field must be deprecated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canDelete")]
        public virtual System.Nullable<bool> CanDelete { get; set; }

        /// <summary>
        /// Whether the user can disable this field. The user must have permission and this field must not already be
        /// disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canDisable")]
        public virtual System.Nullable<bool> CanDisable { get; set; }

        /// <summary>
        /// Whether the user can enable this field. The user must have permission and this field must be disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canEnable")]
        public virtual System.Nullable<bool> CanEnable { get; set; }

        /// <summary>Whether the user can change this field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canUpdate")]
        public virtual System.Nullable<bool> CanUpdate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options for the selection field type.</summary>
    public class GoogleAppsDriveLabelsV2FieldSelectionOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The options available for this selection field. The list order is consistent, and modified with
        /// `insert_before_choice`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("choices")]
        public virtual System.Collections.Generic.IList<GoogleAppsDriveLabelsV2FieldSelectionOptionsChoice> Choices { get; set; }

        /// <summary>
        /// When specified, indicates this field supports a list of values. Once the field is published, this cannot be
        /// changed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listOptions")]
        public virtual GoogleAppsDriveLabelsV2FieldListOptions ListOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Selection field choice.</summary>
    public class GoogleAppsDriveLabelsV2FieldSelectionOptionsChoice : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The capabilities related to this choice on applied metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appliedCapabilities")]
        public virtual GoogleAppsDriveLabelsV2FieldSelectionOptionsChoiceAppliedCapabilities AppliedCapabilities { get; set; }

        /// <summary>Output only. The time this choice was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The user who created this choice.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creator")]
        public virtual GoogleAppsDriveLabelsV2UserInfo Creator { get; set; }

        /// <summary>
        /// Output only. The time this choice was disabled. This value has no meaning when the choice is not disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableTime")]
        public virtual object DisableTime { get; set; }

        /// <summary>
        /// Output only. The user who disabled this choice. This value has no meaning when the option is not disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabler")]
        public virtual GoogleAppsDriveLabelsV2UserInfo Disabler { get; set; }

        /// <summary>Output only. UI display hints for rendering a choice.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayHints")]
        public virtual GoogleAppsDriveLabelsV2FieldSelectionOptionsChoiceDisplayHints DisplayHints { get; set; }

        /// <summary>
        /// The unique value of the choice. This ID is autogenerated. Matches the regex: `([a-zA-Z0-9_])+`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Output only. Lifecycle of the choice.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifecycle")]
        public virtual GoogleAppsDriveLabelsV2Lifecycle Lifecycle { get; set; }

        /// <summary>Output only. The LockStatus of this choice.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lockStatus")]
        public virtual GoogleAppsDriveLabelsV2LockStatus LockStatus { get; set; }

        /// <summary>Basic properties of the choice.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual GoogleAppsDriveLabelsV2FieldSelectionOptionsChoiceProperties Properties { get; set; }

        /// <summary>
        /// Output only. The time this choice was published. This value has no meaning when the choice is not published.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishTime")]
        public virtual object PublishTime { get; set; }

        /// <summary>
        /// Output only. The user who published this choice. This value has no meaning when the choice is not published.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publisher")]
        public virtual GoogleAppsDriveLabelsV2UserInfo Publisher { get; set; }

        /// <summary>Output only. The capabilities related to this option when editing the option.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemaCapabilities")]
        public virtual GoogleAppsDriveLabelsV2FieldSelectionOptionsChoiceSchemaCapabilities SchemaCapabilities { get; set; }

        /// <summary>Output only. The time this choice was updated last.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>Output only. The user who updated this choice last.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updater")]
        public virtual GoogleAppsDriveLabelsV2UserInfo Updater { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The capabilities related to this choice on applied metadata.</summary>
    public class GoogleAppsDriveLabelsV2FieldSelectionOptionsChoiceAppliedCapabilities : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the user can read related applied metadata on items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canRead")]
        public virtual System.Nullable<bool> CanRead { get; set; }

        /// <summary>Whether the user can use this choice in search queries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canSearch")]
        public virtual System.Nullable<bool> CanSearch { get; set; }

        /// <summary>Whether the user can select this choice on an item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canSelect")]
        public virtual System.Nullable<bool> CanSelect { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>UI display hints for rendering an option.</summary>
    public class GoogleAppsDriveLabelsV2FieldSelectionOptionsChoiceDisplayHints : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The colors to use for the badge. Changed to Google Material colors based on the chosen
        /// `properties.badge_config.color`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("badgeColors")]
        public virtual GoogleAppsDriveLabelsV2BadgeColors BadgeColors { get; set; }

        /// <summary>
        /// The priority of this badge. Used to compare and sort between multiple badges. A lower number means the badge
        /// should be shown first. When a badging configuration is not present, this will be 0. Otherwise, this will be
        /// set to `BadgeConfig.priority_override` or the default heuristic which prefers creation date of the label,
        /// and field and option priority.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("badgePriority")]
        public virtual System.Nullable<long> BadgePriority { get; set; }

        /// <summary>
        /// The dark-mode color to use for the badge. Changed to Google Material colors based on the chosen
        /// `properties.badge_config.color`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("darkBadgeColors")]
        public virtual GoogleAppsDriveLabelsV2BadgeColors DarkBadgeColors { get; set; }

        /// <summary>Whether the option should be shown in the UI as disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>This option should be hidden in the search menu when searching for Drive items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hiddenInSearch")]
        public virtual System.Nullable<bool> HiddenInSearch { get; set; }

        /// <summary>This option should be shown in the apply menu when applying values to a Drive item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shownInApply")]
        public virtual System.Nullable<bool> ShownInApply { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Basic properties of the choice.</summary>
    public class GoogleAppsDriveLabelsV2FieldSelectionOptionsChoiceProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The badge configuration for this choice. When set, the label that owns this choice is considered a "badged
        /// label".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("badgeConfig")]
        public virtual GoogleAppsDriveLabelsV2BadgeConfig BadgeConfig { get; set; }

        /// <summary>The description of this label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. The display text to show in the UI identifying this field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Input only. Insert or move this choice before the indicated choice. If empty, the choice is placed at the
        /// end of the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertBeforeChoice")]
        public virtual string InsertBeforeChoice { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The capabilities related to this choice when editing the choice.</summary>
    public class GoogleAppsDriveLabelsV2FieldSelectionOptionsChoiceSchemaCapabilities : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the user can delete this choice.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canDelete")]
        public virtual System.Nullable<bool> CanDelete { get; set; }

        /// <summary>Whether the user can disable this choice.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canDisable")]
        public virtual System.Nullable<bool> CanDisable { get; set; }

        /// <summary>Whether the user can enable this choice.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canEnable")]
        public virtual System.Nullable<bool> CanEnable { get; set; }

        /// <summary>Whether the user can update this choice.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canUpdate")]
        public virtual System.Nullable<bool> CanUpdate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options for the Text field type.</summary>
    public class GoogleAppsDriveLabelsV2FieldTextOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The maximum valid length of values for the text field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxLength")]
        public virtual System.Nullable<int> MaxLength { get; set; }

        /// <summary>Output only. The minimum valid length of values for the text field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minLength")]
        public virtual System.Nullable<int> MinLength { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options for the user field type.</summary>
    public class GoogleAppsDriveLabelsV2FieldUserOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// When specified, indicates that this field supports a list of values. Once the field is published, this
        /// cannot be changed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listOptions")]
        public virtual GoogleAppsDriveLabelsV2FieldListOptions ListOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A label defines a taxonomy that can be applied to Drive items in order to organize and search across items.
    /// Labels can be simple strings, or can contain fields that describe additional metadata that can be further used
    /// to organize and search Drive items.
    /// </summary>
    public class GoogleAppsDriveLabelsV2Label : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The capabilities related to this label on applied metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appliedCapabilities")]
        public virtual GoogleAppsDriveLabelsV2LabelAppliedCapabilities AppliedCapabilities { get; set; }

        /// <summary>Output only. Behavior of this label when it's applied to Drive items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appliedLabelPolicy")]
        public virtual GoogleAppsDriveLabelsV2LabelAppliedLabelPolicy AppliedLabelPolicy { get; set; }

        /// <summary>Output only. The time this label was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The user who created this label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creator")]
        public virtual GoogleAppsDriveLabelsV2UserInfo Creator { get; set; }

        /// <summary>
        /// Output only. The time this label was disabled. This value has no meaning when the label is not disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableTime")]
        public virtual object DisableTime { get; set; }

        /// <summary>
        /// Output only. The user who disabled this label. This value has no meaning when the label is not disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabler")]
        public virtual GoogleAppsDriveLabelsV2UserInfo Disabler { get; set; }

        /// <summary>Output only. UI display hints for rendering the label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayHints")]
        public virtual GoogleAppsDriveLabelsV2LabelDisplayHints DisplayHints { get; set; }

        /// <summary>List of fields in descending priority order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IList<GoogleAppsDriveLabelsV2Field> Fields { get; set; }

        /// <summary>
        /// Output only. Globally unique identifier of this label. ID makes up part of the label `name`, but unlike
        /// `name`, ID is consistent between revisions. Matches the regex: `([a-zA-Z0-9])+`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Required. The type of label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelType")]
        public virtual string LabelType { get; set; }

        /// <summary>
        /// Custom URL to present to users to allow them to learn more about this label and how it should be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("learnMoreUri")]
        public virtual string LearnMoreUri { get; set; }

        /// <summary>
        /// Output only. The lifecycle state of the label including whether it's published, deprecated, and has draft
        /// changes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifecycle")]
        public virtual GoogleAppsDriveLabelsV2Lifecycle Lifecycle { get; set; }

        /// <summary>Output only. The LockStatus of this label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lockStatus")]
        public virtual GoogleAppsDriveLabelsV2LockStatus LockStatus { get; set; }

        /// <summary>
        /// Output only. Resource name of the label. Will be in the form of either: `labels/{id}` or
        /// `labels/{id}@{revision_id}` depending on the request. See `id` and `revision_id` below.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. The basic properties of the label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual GoogleAppsDriveLabelsV2LabelProperties Properties { get; set; }

        /// <summary>
        /// Output only. The time this label was published. This value has no meaning when the label is not published.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishTime")]
        public virtual object PublishTime { get; set; }

        /// <summary>
        /// Output only. The user who published this label. This value has no meaning when the label is not published.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publisher")]
        public virtual GoogleAppsDriveLabelsV2UserInfo Publisher { get; set; }

        /// <summary>Output only. The time this label revision was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionCreateTime")]
        public virtual object RevisionCreateTime { get; set; }

        /// <summary>Output only. The user who created this label revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionCreator")]
        public virtual GoogleAppsDriveLabelsV2UserInfo RevisionCreator { get; set; }

        /// <summary>
        /// Output only. Revision ID of the label. Revision ID might be part of the label `name` depending on the
        /// request issued. A new revision is created whenever revisioned properties of a label are changed. Matches the
        /// regex: `([a-zA-Z0-9])+`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>Output only. The capabilities the user has on this label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemaCapabilities")]
        public virtual GoogleAppsDriveLabelsV2LabelSchemaCapabilities SchemaCapabilities { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The capabilities a user has on this label's applied metadata.</summary>
    public class GoogleAppsDriveLabelsV2LabelAppliedCapabilities : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the user can apply this label to items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canApply")]
        public virtual System.Nullable<bool> CanApply { get; set; }

        /// <summary>Whether the user can read applied metadata related to this label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canRead")]
        public virtual System.Nullable<bool> CanRead { get; set; }

        /// <summary>Whether the user can remove this label from items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canRemove")]
        public virtual System.Nullable<bool> CanRemove { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Behavior of this label when it's applied to Drive items.</summary>
    public class GoogleAppsDriveLabelsV2LabelAppliedLabelPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Indicates how the applied label and field values should be copied when a Drive item is copied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("copyMode")]
        public virtual string CopyMode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>UI display hints for rendering the label.</summary>
    public class GoogleAppsDriveLabelsV2LabelDisplayHints : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the label should be shown in the UI as disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>This label should be hidden in the search menu when searching for Drive items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hiddenInSearch")]
        public virtual System.Nullable<bool> HiddenInSearch { get; set; }

        /// <summary>Order to display label in a list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual System.Nullable<long> Priority { get; set; }

        /// <summary>This label should be shown in the apply menu when applying values to a Drive item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shownInApply")]
        public virtual System.Nullable<bool> ShownInApply { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Basic properties of the label.</summary>
    public class GoogleAppsDriveLabelsV2LabelProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The description of the label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. Title of the label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The capabilities related to this label when editing the label.</summary>
    public class GoogleAppsDriveLabelsV2LabelSchemaCapabilities : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether the user can delete this label. The user must have permission and the label must be disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canDelete")]
        public virtual System.Nullable<bool> CanDelete { get; set; }

        /// <summary>
        /// Whether the user can disable this label. The user must have permission and this label must not already be
        /// disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canDisable")]
        public virtual System.Nullable<bool> CanDisable { get; set; }

        /// <summary>
        /// Whether the user can enable this label. The user must have permission and this label must be disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canEnable")]
        public virtual System.Nullable<bool> CanEnable { get; set; }

        /// <summary>Whether the user can change this label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canUpdate")]
        public virtual System.Nullable<bool> CanUpdate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The lifecycle state of an object, such as label, field, or choice. The lifecycle enforces the following
    /// transitions: * `UNPUBLISHED_DRAFT` (starting state) * `UNPUBLISHED_DRAFT` -&amp;gt; `PUBLISHED` *
    /// `UNPUBLISHED_DRAFT` -&amp;gt; (Deleted) * `PUBLISHED` -&amp;gt; `DISABLED` * `DISABLED` -&amp;gt; `PUBLISHED` *
    /// `DISABLED` -&amp;gt; (Deleted) The published and disabled states have some distinct characteristics: *
    /// Published—Some kinds of changes might be made to an object in this state, in which case
    /// `has_unpublished_changes` will be true. Also, some kinds of changes are not permitted. Generally, any change
    /// that would invalidate or cause new restrictions on existing metadata related to the label are rejected. *
    /// Disabled—When disabled, the configured `DisabledPolicy` takes effect.
    /// </summary>
    public class GoogleAppsDriveLabelsV2Lifecycle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The policy that governs how to show a disabled label, field, or selection choice.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabledPolicy")]
        public virtual GoogleAppsDriveLabelsV2LifecycleDisabledPolicy DisabledPolicy { get; set; }

        /// <summary>Output only. Whether the object associated with this lifecycle has unpublished changes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasUnpublishedChanges")]
        public virtual System.Nullable<bool> HasUnpublishedChanges { get; set; }

        /// <summary>Output only. The state of the object associated with this lifecycle.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The policy that governs how to treat a disabled label, field, or selection choice in different contexts.
    /// </summary>
    public class GoogleAppsDriveLabelsV2LifecycleDisabledPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether to hide this disabled object in the search menu for Drive items. * When `false`, the object is
        /// generally shown in the UI as disabled but it appears in the search results when searching for Drive items. *
        /// When `true`, the object is generally hidden in the UI when searching for Drive items.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hideInSearch")]
        public virtual System.Nullable<bool> HideInSearch { get; set; }

        /// <summary>
        /// Whether to show this disabled object in the apply menu on Drive items. * When `true`, the object is
        /// generally shown in the UI as disabled and is unselectable. * When `false`, the object is generally hidden in
        /// the UI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("showInApply")]
        public virtual System.Nullable<bool> ShowInApply { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for listing Labels.</summary>
    public class GoogleAppsDriveLabelsV2ListLabelsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Labels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<GoogleAppsDriveLabelsV2Label> Labels { get; set; }

        /// <summary>The token of the next page in the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains information about whether a label component should be considered locked.</summary>
    public class GoogleAppsDriveLabelsV2LockStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Indicates whether this label component is the (direct) target of a LabelLock. A label component
        /// can be implicitly locked even if it's not the direct target of a LabelLock, in which case this field is set
        /// to false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locked")]
        public virtual System.Nullable<bool> Locked { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a user.</summary>
    public class GoogleAppsDriveLabelsV2UserInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The identifier for this user that can be used with the People API to get more information. For example,
        /// people/12345678.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("person")]
        public virtual string Person { get; set; }

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
    public class GoogleTypeColor : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>
    /// Represents a whole or partial calendar date, such as a birthday. The time of day and time zone are either
    /// specified elsewhere or are insignificant. The date is relative to the Gregorian Calendar. This can represent one
    /// of the following: * A full date, with non-zero year, month, and day values. * A month and day, with a zero year
    /// (for example, an anniversary). * A year on its own, with a zero month and a zero day. * A year and month, with a
    /// zero day (for example, a credit card expiration date). Related types: * google.type.TimeOfDay *
    /// google.type.DateTime * google.protobuf.Timestamp
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
