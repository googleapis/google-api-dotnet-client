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

namespace Google.Apis.DriveActivity.v2
{
    /// <summary>The DriveActivity Service.</summary>
    public class DriveActivityService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DriveActivityService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DriveActivityService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Activity = new ActivityResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://driveactivity.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://driveactivity.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "driveactivity";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Drive Activity API.</summary>
        public class Scope
        {
            /// <summary>View and add to the activity record of files in your Google Drive</summary>
            public static string DriveActivity = "https://www.googleapis.com/auth/drive.activity";

            /// <summary>View the activity record of files in your Google Drive</summary>
            public static string DriveActivityReadonly = "https://www.googleapis.com/auth/drive.activity.readonly";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Drive Activity API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and add to the activity record of files in your Google Drive</summary>
            public const string DriveActivity = "https://www.googleapis.com/auth/drive.activity";

            /// <summary>View the activity record of files in your Google Drive</summary>
            public const string DriveActivityReadonly = "https://www.googleapis.com/auth/drive.activity.readonly";
        }

        /// <summary>Gets the Activity resource.</summary>
        public virtual ActivityResource Activity { get; }
    }

    /// <summary>A base abstract class for DriveActivity requests.</summary>
    public abstract class DriveActivityBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new DriveActivityBaseServiceRequest instance.</summary>
        protected DriveActivityBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes DriveActivity parameter list.</summary>
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

    /// <summary>The "activity" collection of methods.</summary>
    public class ActivityResource
    {
        private const string Resource = "activity";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ActivityResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Query past activity in Google Drive.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual QueryRequest Query(Google.Apis.DriveActivity.v2.Data.QueryDriveActivityRequest body)
        {
            return new QueryRequest(this.service, body);
        }

        /// <summary>Query past activity in Google Drive.</summary>
        public class QueryRequest : DriveActivityBaseServiceRequest<Google.Apis.DriveActivity.v2.Data.QueryDriveActivityResponse>
        {
            /// <summary>Constructs a new Query request.</summary>
            public QueryRequest(Google.Apis.Services.IClientService service, Google.Apis.DriveActivity.v2.Data.QueryDriveActivityRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DriveActivity.v2.Data.QueryDriveActivityRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "query";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/activity:query";

            /// <summary>Initializes Query parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }
}
namespace Google.Apis.DriveActivity.v2.Data
{
    /// <summary>Information about the action.</summary>
    public class Action : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The actor responsible for this action (or empty if all actors are responsible).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actor")]
        public virtual Actor Actor { get; set; }

        /// <summary>The type and detailed information about the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detail")]
        public virtual ActionDetail Detail { get; set; }

        /// <summary>
        /// The target this action affects (or empty if affecting all targets). This represents the state of the target
        /// immediately after this action occurred.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual Target Target { get; set; }

        /// <summary>The action occurred over this time range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeRange")]
        public virtual TimeRange TimeRange { get; set; }

        private string _timestampRaw;

        private object _timestamp;

        /// <summary>The action occurred at this specific time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestamp")]
        public virtual string TimestampRaw
        {
            get => _timestampRaw;
            set
            {
                _timestamp = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _timestampRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="TimestampRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use TimestampDateTimeOffset instead.")]
        public virtual object Timestamp
        {
            get => _timestamp;
            set
            {
                _timestampRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _timestamp = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="TimestampRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? TimestampDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(TimestampRaw);
            set => TimestampRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data describing the type and additional information of an action.</summary>
    public class ActionDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Label was changed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appliedLabelChange")]
        public virtual AppliedLabelChange AppliedLabelChange { get; set; }

        /// <summary>A change about comments was made.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("comment")]
        public virtual Comment Comment { get; set; }

        /// <summary>An object was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("create")]
        public virtual Create Create { get; set; }

        /// <summary>An object was deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delete")]
        public virtual Delete Delete { get; set; }

        /// <summary>A change happened in data leak prevention status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dlpChange")]
        public virtual DataLeakPreventionChange DlpChange { get; set; }

        /// <summary>An object was edited.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("edit")]
        public virtual Edit Edit { get; set; }

        /// <summary>An object was moved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("move")]
        public virtual Move Move { get; set; }

        /// <summary>The permission on an object was changed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissionChange")]
        public virtual PermissionChange PermissionChange { get; set; }

        /// <summary>An object was referenced in an application outside of Drive/Docs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reference")]
        public virtual ApplicationReference Reference { get; set; }

        /// <summary>An object was renamed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rename")]
        public virtual Rename Rename { get; set; }

        /// <summary>A deleted object was restored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restore")]
        public virtual Restore Restore { get; set; }

        /// <summary>Settings were changed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("settingsChange")]
        public virtual SettingsChange SettingsChange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The actor of a Drive activity.</summary>
    public class Actor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An administrator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("administrator")]
        public virtual Administrator Administrator { get; set; }

        /// <summary>An anonymous user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("anonymous")]
        public virtual AnonymousUser Anonymous { get; set; }

        /// <summary>An account acting on behalf of another.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("impersonation")]
        public virtual Impersonation Impersonation { get; set; }

        /// <summary>A non-user actor (i.e. system triggered).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("system")]
        public virtual SystemEvent System { get; set; }

        /// <summary>An end user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual User User { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Empty message representing an administrator.</summary>
    public class Administrator : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Empty message representing an anonymous user or indicating the authenticated user should be anonymized.
    /// </summary>
    public class AnonymousUser : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents any user (including a logged out user).</summary>
    public class Anyone : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Activity in applications other than Drive.</summary>
    public class ApplicationReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The reference type corresponding to this event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Label changes that were made on the Target.</summary>
    public class AppliedLabelChange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Changes that were made to the Label on the Target.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("changes")]
        public virtual System.Collections.Generic.IList<AppliedLabelChangeDetail> Changes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A change made to a Label on the Target.</summary>
    public class AppliedLabelChangeDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Field Changes. Only present if `types` contains `LABEL_FIELD_VALUE_CHANGED`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldChanges")]
        public virtual System.Collections.Generic.IList<FieldValueChange> FieldChanges { get; set; }

        /// <summary>
        /// The Label name representing the Label that changed. This name always contains the revision of the Label that
        /// was used when this Action occurred. The format is `labels/id@revision`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>The human-readable title of the label that changed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The types of changes made to the Label on the Target.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("types")]
        public virtual System.Collections.Generic.IList<string> Types { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A comment with an assignment.</summary>
    public class Assignment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The user to whom the comment was assigned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignedUser")]
        public virtual User AssignedUser { get; set; }

        /// <summary>The sub-type of this event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subtype")]
        public virtual string Subtype { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A change about comments on an object.</summary>
    public class Comment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A change on an assignment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignment")]
        public virtual Assignment Assignment { get; set; }

        /// <summary>Users who are mentioned in this comment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mentionedUsers")]
        public virtual System.Collections.Generic.IList<User> MentionedUsers { get; set; }

        /// <summary>A change on a regular posted comment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("post")]
        public virtual Post Post { get; set; }

        /// <summary>A change on a suggestion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestion")]
        public virtual Suggestion Suggestion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// How the individual activities are consolidated. If a set of activities is related they can be consolidated into
    /// one combined activity, such as one actor performing the same action on multiple targets, or multiple actors
    /// performing the same action on a single target. The strategy defines the rules for which activities are related.
    /// </summary>
    public class ConsolidationStrategy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The individual activities are consolidated using the legacy strategy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("legacy")]
        public virtual Legacy Legacy { get; set; }

        /// <summary>The individual activities are not consolidated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("none")]
        public virtual NoConsolidation None { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An object was created by copying an existing object.</summary>
    public class Copy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The original object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalObject")]
        public virtual TargetReference OriginalObject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An object was created.</summary>
    public class Create : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If present, indicates the object was created by copying an existing Drive object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("copy")]
        public virtual Copy Copy { get; set; }

        /// <summary>
        /// If present, indicates the object was newly created (e.g. as a blank document), not derived from a Drive
        /// object or external object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("new")]
        public virtual New New__ { get; set; }

        /// <summary>If present, indicates the object originated externally and was uploaded to Drive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upload")]
        public virtual Upload Upload { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A change in the object's data leak prevention status.</summary>
    public class DataLeakPreventionChange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of Data Leak Prevention (DLP) change.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Wrapper for Date Field value.</summary>
    public class Date : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _valueRaw;

        private object _value;

        /// <summary>Date value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string ValueRaw
        {
            get => _valueRaw;
            set
            {
                _value = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _valueRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ValueRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ValueDateTimeOffset instead.")]
        public virtual object Value
        {
            get => _value;
            set
            {
                _valueRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _value = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ValueRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ValueDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ValueRaw);
            set => ValueRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An object was deleted.</summary>
    public class Delete : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of delete action taken.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A user whose account has since been deleted.</summary>
    public class DeletedUser : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a domain.</summary>
    public class Domain : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An opaque string used to identify this domain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("legacyId")]
        public virtual string LegacyId { get; set; }

        /// <summary>The name of the domain, e.g. `google.com`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a shared drive.</summary>
    public class Drive : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource name of the shared drive. The format is `COLLECTION_ID/DRIVE_ID`. Clients should not assume a
        /// specific collection ID for this resource name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The root of this shared drive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("root")]
        public virtual DriveItem Root { get; set; }

        /// <summary>The title of the shared drive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A single Drive activity comprising one or more Actions by one or more Actors on one or more Targets. Some Action
    /// groupings occur spontaneously, such as moving an item into a shared folder triggering a permission change. Other
    /// groupings of related Actions, such as multiple Actors editing one item or moving multiple files into a new
    /// folder, are controlled by the selection of a ConsolidationStrategy in the QueryDriveActivityRequest.
    /// </summary>
    public class DriveActivity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Details on all actions in this activity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actions")]
        public virtual System.Collections.Generic.IList<Action> Actions { get; set; }

        /// <summary>All actor(s) responsible for the activity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actors")]
        public virtual System.Collections.Generic.IList<Actor> Actors { get; set; }

        /// <summary>
        /// Key information about the primary action for this activity. This is either representative, or the most
        /// important, of all actions in the activity, according to the ConsolidationStrategy in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryActionDetail")]
        public virtual ActionDetail PrimaryActionDetail { get; set; }

        /// <summary>
        /// All Google Drive objects this activity is about (e.g. file, folder, drive). This represents the state of the
        /// target immediately after the actions occurred.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targets")]
        public virtual System.Collections.Generic.IList<Target> Targets { get; set; }

        /// <summary>The activity occurred over this time range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeRange")]
        public virtual TimeRange TimeRange { get; set; }

        private string _timestampRaw;

        private object _timestamp;

        /// <summary>The activity occurred at this specific time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestamp")]
        public virtual string TimestampRaw
        {
            get => _timestampRaw;
            set
            {
                _timestamp = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _timestampRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="TimestampRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use TimestampDateTimeOffset instead.")]
        public virtual object Timestamp
        {
            get => _timestamp;
            set
            {
                _timestampRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _timestamp = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="TimestampRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? TimestampDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(TimestampRaw);
            set => TimestampRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Drive item which is a file.</summary>
    public class DriveFile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Drive item which is a folder.</summary>
    public class DriveFolder : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of Drive folder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Drive item, such as a file or folder.</summary>
    public class DriveItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Drive item is a file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driveFile")]
        public virtual DriveFile DriveFile { get; set; }

        /// <summary>The Drive item is a folder. Includes information about the type of folder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driveFolder")]
        public virtual DriveFolder DriveFolder { get; set; }

        /// <summary>This field is deprecated; please use the `driveFile` field instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("file")]
        public virtual File File { get; set; }

        /// <summary>This field is deprecated; please use the `driveFolder` field instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folder")]
        public virtual Folder Folder { get; set; }

        /// <summary>
        /// The MIME type of the Drive item. See https://developers.google.com/workspace/drive/v3/web/mime-types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>The target Drive item. The format is `items/ITEM_ID`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Information about the owner of this Drive item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("owner")]
        public virtual Owner Owner { get; set; }

        /// <summary>The title of the Drive item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A lightweight reference to a Drive item, such as a file or folder.</summary>
    public class DriveItemReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Drive item is a file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driveFile")]
        public virtual DriveFile DriveFile { get; set; }

        /// <summary>The Drive item is a folder. Includes information about the type of folder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driveFolder")]
        public virtual DriveFolder DriveFolder { get; set; }

        /// <summary>This field is deprecated; please use the `driveFile` field instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("file")]
        public virtual File File { get; set; }

        /// <summary>This field is deprecated; please use the `driveFolder` field instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folder")]
        public virtual Folder Folder { get; set; }

        /// <summary>The target Drive item. The format is `items/ITEM_ID`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The title of the Drive item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A lightweight reference to a shared drive.</summary>
    public class DriveReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource name of the shared drive. The format is `COLLECTION_ID/DRIVE_ID`. Clients should not assume a
        /// specific collection ID for this resource name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The title of the shared drive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An empty message indicating an object was edited.</summary>
    public class Edit : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains a value of a Field.</summary>
    public class FieldValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Date Field value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual Date Date { get; set; }

        /// <summary>Integer Field value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integer")]
        public virtual Integer Integer { get; set; }

        /// <summary>Selection Field value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selection")]
        public virtual Selection Selection { get; set; }

        /// <summary>Selection List Field value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectionList")]
        public virtual SelectionList SelectionList { get; set; }

        /// <summary>Text Field value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual Text Text { get; set; }

        /// <summary>Text List Field value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textList")]
        public virtual TextList TextList { get; set; }

        /// <summary>User Field value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual SingleUser User { get; set; }

        /// <summary>User List Field value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userList")]
        public virtual UserList UserList { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Change to a Field value.</summary>
    public class FieldValueChange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The human-readable display name for this field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The ID of this field. Field IDs are unique within a Label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldId")]
        public virtual string FieldId { get; set; }

        /// <summary>
        /// The value that is now set on the field. If not present, the field was cleared. At least one of
        /// {old_value|new_value} is always set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newValue")]
        public virtual FieldValue NewValue { get; set; }

        /// <summary>
        /// The value that was previously set on the field. If not present, the field was newly set. At least one of
        /// {old_value|new_value} is always set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oldValue")]
        public virtual FieldValue OldValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This item is deprecated; please see `DriveFile` instead.</summary>
    public class File : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A comment on a file.</summary>
    public class FileComment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The comment in the discussion thread. This identifier is an opaque string compatible with the Drive API; see
        /// https://developers.google.com/workspace/drive/v3/reference/comments/get
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("legacyCommentId")]
        public virtual string LegacyCommentId { get; set; }

        /// <summary>
        /// The discussion thread to which the comment was added. This identifier is an opaque string compatible with
        /// the Drive API and references the first comment in a discussion; see
        /// https://developers.google.com/workspace/drive/v3/reference/comments/get
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("legacyDiscussionId")]
        public virtual string LegacyDiscussionId { get; set; }

        /// <summary>
        /// The link to the discussion thread containing this comment, for example,
        /// `https://docs.google.com/DOCUMENT_ID/edit?disco=THREAD_ID`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkToDiscussion")]
        public virtual string LinkToDiscussion { get; set; }

        /// <summary>The Drive item containing this comment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual DriveItem Parent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This item is deprecated; please see `DriveFolder` instead.</summary>
    public class Folder : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This field is deprecated; please see `DriveFolder.type` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a group.</summary>
    public class Group : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The email address of the group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>The title of the group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information about an impersonation, where an admin acts on behalf of an end user. Information about the acting
    /// admin is not currently available.
    /// </summary>
    public class Impersonation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The impersonated user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("impersonatedUser")]
        public virtual User ImpersonatedUser { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Wrapper for Integer Field value.</summary>
    public class Integer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Integer value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<long> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A known user.</summary>
    public class KnownUser : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>True if this is the user making the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isCurrentUser")]
        public virtual System.Nullable<bool> IsCurrentUser { get; set; }

        /// <summary>
        /// The identifier for this user that can be used with the People API to get more information. The format is
        /// `people/ACCOUNT_ID`. See https://developers.google.com/people/.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("personName")]
        public virtual string PersonName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A strategy that consolidates activities using the grouping rules from the legacy V1 Activity API. Similar
    /// actions occurring within a window of time can be grouped across multiple targets (such as moving a set of files
    /// at once) or multiple actors (such as several users editing the same item). Grouping rules for this strategy are
    /// specific to each type of action.
    /// </summary>
    public class Legacy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An object was moved.</summary>
    public class Move : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The added parent object(s).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addedParents")]
        public virtual System.Collections.Generic.IList<TargetReference> AddedParents { get; set; }

        /// <summary>The removed parent object(s).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("removedParents")]
        public virtual System.Collections.Generic.IList<TargetReference> RemovedParents { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An object was created from scratch.</summary>
    public class New : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A strategy that does no consolidation of individual activities.</summary>
    public class NoConsolidation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the owner of a Drive item.</summary>
    public class Owner : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The domain of the Drive item owner.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual Domain Domain { get; set; }

        /// <summary>The drive that owns the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("drive")]
        public virtual DriveReference Drive { get; set; }

        /// <summary>This field is deprecated; please use the `drive` field instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("teamDrive")]
        public virtual TeamDriveReference TeamDrive { get; set; }

        /// <summary>The user that owns the Drive item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual User User { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The permission setting of an object.</summary>
    public class Permission : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If true, the item can be discovered (e.g. in the user's "Shared with me" collection) without needing a link
        /// to the item.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowDiscovery")]
        public virtual System.Nullable<bool> AllowDiscovery { get; set; }

        /// <summary>If set, this permission applies to anyone, even logged out users.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("anyone")]
        public virtual Anyone Anyone { get; set; }

        /// <summary>The domain to whom this permission applies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual Domain Domain { get; set; }

        /// <summary>The group to whom this permission applies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("group")]
        public virtual Group Group { get; set; }

        /// <summary>
        /// Indicates the [Google Drive permissions
        /// role](https://developers.google.com/workspace/drive/web/manage-sharing#roles). The role determines a user's
        /// ability to read, write, and comment on items.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The user to whom this permission applies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual User User { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A change of the permission setting on an item.</summary>
    public class PermissionChange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The set of permissions added by this change.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addedPermissions")]
        public virtual System.Collections.Generic.IList<Permission> AddedPermissions { get; set; }

        /// <summary>The set of permissions removed by this change.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("removedPermissions")]
        public virtual System.Collections.Generic.IList<Permission> RemovedPermissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A regular posted comment.</summary>
    public class Post : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The sub-type of this event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subtype")]
        public virtual string Subtype { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for querying Drive activity.</summary>
    public class QueryDriveActivityRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Return activities for this Drive folder, plus all children and descendants. The format is `items/ITEM_ID`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ancestorName")]
        public virtual string AncestorName { get; set; }

        /// <summary>
        /// Details on how to consolidate related actions that make up the activity. If not set, then related actions
        /// aren't consolidated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consolidationStrategy")]
        public virtual ConsolidationStrategy ConsolidationStrategy { get; set; }

        /// <summary>
        /// The filtering for items returned from this query request. The format of the filter string is a sequence of
        /// expressions, joined by an optional "AND", where each expression is of the form "field operator value".
        /// Supported fields: - `time`: Uses numerical operators on date values either in terms of milliseconds since
        /// Jan 1, 1970 or in RFC 3339 format. Examples: - `time &amp;gt; 1452409200000 AND time &amp;lt;=
        /// 1492812924310` - `time &amp;gt;= "2016-01-10T01:02:03-05:00"` - `detail.action_detail_case`: Uses the "has"
        /// operator (:) and either a singular value or a list of allowed action types enclosed in parentheses,
        /// separated by a space. To exclude a result from the response, prepend a hyphen (`-`) to the beginning of the
        /// filter string. Examples: - `detail.action_detail_case:RENAME` - `detail.action_detail_case:(CREATE RESTORE)`
        /// - `-detail.action_detail_case:MOVE`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>Return activities for this Drive item. The format is `items/ITEM_ID`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemName")]
        public virtual string ItemName { get; set; }

        /// <summary>
        /// The minimum number of activities desired in the response; the server attempts to return at least this
        /// quantity. The server may also return fewer activities if it has a partial response ready before the request
        /// times out. If not set, a default value is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// The token identifies which page of results to return. Set this to the next_page_token value returned from a
        /// previous query to obtain the following page of results. If not set, the first page of results is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for querying Drive activity.</summary>
    public class QueryDriveActivityResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of activity requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activities")]
        public virtual System.Collections.Generic.IList<DriveActivity> Activities { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An object was renamed.</summary>
    public class Rename : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The new title of the drive object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newTitle")]
        public virtual string NewTitle { get; set; }

        /// <summary>The previous title of the drive object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oldTitle")]
        public virtual string OldTitle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A deleted object was restored.</summary>
    public class Restore : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of restore action taken.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about restriction policy changes to a feature.</summary>
    public class RestrictionChange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The feature which had a change in restriction policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feature")]
        public virtual string Feature { get; set; }

        /// <summary>The restriction in place after the change.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newRestriction")]
        public virtual string NewRestriction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Wrapper for Selection Field value as combined value/display_name pair for selected choice.</summary>
    public class Selection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Selection value as human-readable display string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Selection value as Field Choice ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Wrapper for SelectionList Field value.</summary>
    public class SelectionList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Selection values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<Selection> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about settings changes.</summary>
    public class SettingsChange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The set of changes made to restrictions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictionChanges")]
        public virtual System.Collections.Generic.IList<RestrictionChange> RestrictionChanges { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Wrapper for User Field value.</summary>
    public class SingleUser : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>User value as email.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A suggestion.</summary>
    public class Suggestion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The sub-type of this event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subtype")]
        public virtual string Subtype { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Event triggered by system operations instead of end users.</summary>
    public class SystemEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of the system event that may triggered activity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information about the target of activity. For more information on how activity history is shared with users, see
    /// [Activity history visibility](https://developers.google.com/workspace/drive/activity/v2#activityhistory).
    /// </summary>
    public class Target : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The target is a shared drive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("drive")]
        public virtual Drive Drive { get; set; }

        /// <summary>The target is a Drive item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driveItem")]
        public virtual DriveItem DriveItem { get; set; }

        /// <summary>The target is a comment on a Drive file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileComment")]
        public virtual FileComment FileComment { get; set; }

        /// <summary>This field is deprecated; please use the `drive` field instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("teamDrive")]
        public virtual TeamDrive TeamDrive { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A lightweight reference to the target of activity.</summary>
    public class TargetReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The target is a shared drive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("drive")]
        public virtual DriveReference Drive { get; set; }

        /// <summary>The target is a Drive item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driveItem")]
        public virtual DriveItemReference DriveItem { get; set; }

        /// <summary>This field is deprecated; please use the `drive` field instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("teamDrive")]
        public virtual TeamDriveReference TeamDrive { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This item is deprecated; please see `Drive` instead.</summary>
    public class TeamDrive : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This field is deprecated; please see `Drive.name` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>This field is deprecated; please see `Drive.root` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("root")]
        public virtual DriveItem Root { get; set; }

        /// <summary>This field is deprecated; please see `Drive.title` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This item is deprecated; please see `DriveReference` instead.</summary>
    public class TeamDriveReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This field is deprecated; please see `DriveReference.name` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>This field is deprecated; please see `DriveReference.title` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Wrapper for Text Field value.</summary>
    public class Text : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Value of Text Field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Wrapper for Text List Field value.</summary>
    public class TextList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Text values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<Text> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about time ranges.</summary>
    public class TimeRange : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>The end of the time range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual string EndTimeRaw
        {
            get => _endTimeRaw;
            set
            {
                _endTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _endTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EndTimeDateTimeOffset instead.")]
        public virtual object EndTime
        {
            get => _endTime;
            set
            {
                _endTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _endTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="EndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EndTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EndTimeRaw);
            set => EndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>The start of the time range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual string StartTimeRaw
        {
            get => _startTimeRaw;
            set
            {
                _startTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _startTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="StartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use StartTimeDateTimeOffset instead.")]
        public virtual object StartTime
        {
            get => _startTime;
            set
            {
                _startTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _startTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="StartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? StartTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(StartTimeRaw);
            set => StartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A user about whom nothing is currently known.</summary>
    public class UnknownUser : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An object was uploaded into Drive.</summary>
    public class Upload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about an end user.</summary>
    public class User : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A user whose account has since been deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletedUser")]
        public virtual DeletedUser DeletedUser { get; set; }

        /// <summary>A known user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("knownUser")]
        public virtual KnownUser KnownUser { get; set; }

        /// <summary>A user about whom nothing is currently known.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unknownUser")]
        public virtual UnknownUser UnknownUser { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Wrapper for UserList Field value.</summary>
    public class UserList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>User values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<SingleUser> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
