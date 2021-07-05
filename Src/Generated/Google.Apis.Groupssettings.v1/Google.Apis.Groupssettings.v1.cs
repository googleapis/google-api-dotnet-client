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

namespace Google.Apis.Groupssettings.v1
{
    /// <summary>The Groupssettings Service.</summary>
    public class GroupssettingsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public GroupssettingsService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public GroupssettingsService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Groups = new GroupsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "groupssettings";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://www.googleapis.com/groups/v1/groups/";
        #else
            "https://www.googleapis.com/groups/v1/groups/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "groups/v1/groups/";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://www.googleapis.com/batch/groupssettings/v1";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch/groupssettings/v1";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Groups Settings API.</summary>
        public class Scope
        {
            /// <summary>View and manage the settings of a G Suite group</summary>
            public static string AppsGroupsSettings = "https://www.googleapis.com/auth/apps.groups.settings";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Groups Settings API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage the settings of a G Suite group</summary>
            public const string AppsGroupsSettings = "https://www.googleapis.com/auth/apps.groups.settings";
        }

        /// <summary>Gets the Groups resource.</summary>
        public virtual GroupsResource Groups { get; }
    }

    /// <summary>A base abstract class for Groupssettings requests.</summary>
    public abstract class GroupssettingsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new GroupssettingsBaseServiceRequest instance.</summary>
        protected GroupssettingsBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
        {
        }

        /// <summary>Data format for the response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for the response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/atom+xml</summary>
            [Google.Apis.Util.StringValueAttribute("atom")]
            Atom = 0,

            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json = 1,
        }

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
        /// An opaque string that represents a user for quota purposes. Must not exceed 40 characters.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Deprecated. Please use quotaUser instead.</summary>
        [Google.Apis.Util.RequestParameterAttribute("userIp", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UserIp { get; set; }

        /// <summary>Initializes Groupssettings parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();
            RequestParameters.Add("alt", new Google.Apis.Discovery.Parameter
            {
                Name = "alt",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "atom",
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
            RequestParameters.Add("userIp", new Google.Apis.Discovery.Parameter
            {
                Name = "userIp",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
        }
    }

    /// <summary>The "groups" collection of methods.</summary>
    public class GroupsResource
    {
        private const string Resource = "groups";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public GroupsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Gets one resource by id.</summary>
        /// <param name="groupUniqueId">The group's email address.</param>
        public virtual GetRequest Get(string groupUniqueId)
        {
            return new GetRequest(service, groupUniqueId);
        }

        /// <summary>Gets one resource by id.</summary>
        public class GetRequest : GroupssettingsBaseServiceRequest<Google.Apis.Groupssettings.v1.Data.Groups>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string groupUniqueId) : base(service)
            {
                GroupUniqueId = groupUniqueId;
                InitParameters();
            }

            /// <summary>The group's email address.</summary>
            [Google.Apis.Util.RequestParameterAttribute("groupUniqueId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string GroupUniqueId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{groupUniqueId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("groupUniqueId", new Google.Apis.Discovery.Parameter
                {
                    Name = "groupUniqueId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates an existing resource. This method supports patch semantics.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="groupUniqueId">The group's email address.</param>
        public virtual PatchRequest Patch(Google.Apis.Groupssettings.v1.Data.Groups body, string groupUniqueId)
        {
            return new PatchRequest(service, body, groupUniqueId);
        }

        /// <summary>Updates an existing resource. This method supports patch semantics.</summary>
        public class PatchRequest : GroupssettingsBaseServiceRequest<Google.Apis.Groupssettings.v1.Data.Groups>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Groupssettings.v1.Data.Groups body, string groupUniqueId) : base(service)
            {
                GroupUniqueId = groupUniqueId;
                Body = body;
                InitParameters();
            }

            /// <summary>The group's email address.</summary>
            [Google.Apis.Util.RequestParameterAttribute("groupUniqueId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string GroupUniqueId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Groupssettings.v1.Data.Groups Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{groupUniqueId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("groupUniqueId", new Google.Apis.Discovery.Parameter
                {
                    Name = "groupUniqueId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates an existing resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="groupUniqueId">The group's email address.</param>
        public virtual UpdateRequest Update(Google.Apis.Groupssettings.v1.Data.Groups body, string groupUniqueId)
        {
            return new UpdateRequest(service, body, groupUniqueId);
        }

        /// <summary>Updates an existing resource.</summary>
        public class UpdateRequest : GroupssettingsBaseServiceRequest<Google.Apis.Groupssettings.v1.Data.Groups>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Groupssettings.v1.Data.Groups body, string groupUniqueId) : base(service)
            {
                GroupUniqueId = groupUniqueId;
                Body = body;
                InitParameters();
            }

            /// <summary>The group's email address.</summary>
            [Google.Apis.Util.RequestParameterAttribute("groupUniqueId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string GroupUniqueId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Groupssettings.v1.Data.Groups Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "{groupUniqueId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("groupUniqueId", new Google.Apis.Discovery.Parameter
                {
                    Name = "groupUniqueId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.Groupssettings.v1.Data
{
    /// <summary>JSON template for Group resource</summary>
    public class Groups : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Identifies whether members external to your organization can join the group. Possible values are:   - true:
        /// G Suite users external to your organization can become members of this group.  - false: Users not belonging
        /// to the organization are not allowed to become members of this group.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowExternalMembers")]
        public virtual string AllowExternalMembers { get; set; }

        /// <summary>
        /// Deprecated. Allows Google to contact administrator of the group.   - true: Allow Google to contact managers
        /// of this group. Occasionally Google may send updates on the latest features, ask for input on new features,
        /// or ask for permission to highlight your group.  - false: Google can not contact managers of this group.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowGoogleCommunication")]
        public virtual string AllowGoogleCommunication { get; set; }

        /// <summary>
        /// Allows posting from web. Possible values are:   - true: Allows any member to post to the group forum.  -
        /// false: Members only use Gmail to communicate with the group.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowWebPosting")]
        public virtual string AllowWebPosting { get; set; }

        /// <summary>
        /// Allows the group to be archived only. Possible values are:   - true: Group is archived and the group is
        /// inactive. New messages to this group are rejected. The older archived messages are browseable and
        /// searchable.   - If true, the whoCanPostMessage property is set to NONE_CAN_POST.   - If reverted from true
        /// to false, whoCanPostMessages is set to ALL_MANAGERS_CAN_POST.   - false: The group is active and can receive
        /// messages.   - When false, updating whoCanPostMessage to NONE_CAN_POST, results in an error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("archiveOnly")]
        public virtual string ArchiveOnly { get; set; }

        /// <summary>Set the content of custom footer text. The maximum number of characters is 1,000.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customFooterText")]
        public virtual string CustomFooterText { get; set; }

        /// <summary>
        /// An email address used when replying to a message if the replyTo property is set to REPLY_TO_CUSTOM. This
        /// address is defined by an account administrator.   - When the group's ReplyTo property is set to
        /// REPLY_TO_CUSTOM, the customReplyTo property holds a custom email address used when replying to a message.  -
        /// If the group's ReplyTo property is set to REPLY_TO_CUSTOM, the customReplyTo property must have a text value
        /// or an error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customReplyTo")]
        public virtual string CustomReplyTo { get; set; }

        /// <summary>
        /// Specifies whether the group has a custom role that's included in one of the settings being merged. This
        /// field is read-only and update/patch requests to it are ignored. Possible values are:   - true  - false
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customRolesEnabledForSettingsToBeMerged")]
        public virtual string CustomRolesEnabledForSettingsToBeMerged { get; set; }

        /// <summary>
        /// When a message is rejected, this is text for the rejection notification sent to the message's author. By
        /// default, this property is empty and has no value in the API's response body. The maximum notification text
        /// size is 10,000 characters. Note: Requires sendMessageDenyNotification property to be true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultMessageDenyNotificationText")]
        public virtual string DefaultMessageDenyNotificationText { get; set; }

        /// <summary>
        /// Default sender for members who can post messages as the group. Possible values are: - `DEFAULT_SELF`: By
        /// default messages will be sent from the user - `GROUP`: By default messages will be sent from the group
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("default_sender")]
        public virtual string DefaultSender { get; set; }

        /// <summary>
        /// Description of the group. This property value may be an empty string if no group description has been
        /// entered. If entered, the maximum group description is no more than 300 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// The group's email address. This property can be updated using the Directory API. Note: Only a group owner
        /// can change a group's email address. A group manager can't do this. When you change your group's address
        /// using the Directory API or the control panel, you are changing the address your subscribers use to send
        /// email and the web address people use to access your group. People can't reach your group by visiting the old
        /// address.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>
        /// Specifies whether a collaborative inbox will remain turned on for the group. Possible values are:   - true
        /// - false
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableCollaborativeInbox")]
        public virtual string EnableCollaborativeInbox { get; set; }

        /// <summary>
        /// Indicates if favorite replies should be displayed above other replies.   - true: Favorite replies will be
        /// displayed above other replies.  - false: Favorite replies will not be displayed above other replies.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("favoriteRepliesOnTop")]
        public virtual string FavoriteRepliesOnTop { get; set; }

        /// <summary>Whether to include custom footer. Possible values are:   - true  - false</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeCustomFooter")]
        public virtual string IncludeCustomFooter { get; set; }

        /// <summary>
        /// Enables the group to be included in the Global Address List. For more information, see the help center.
        /// Possible values are:   - true: Group is included in the Global Address List.  - false: Group is not included
        /// in the Global Address List.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeInGlobalAddressList")]
        public virtual string IncludeInGlobalAddressList { get; set; }

        /// <summary>
        /// Allows the Group contents to be archived. Possible values are:   - true: Archive messages sent to the group.
        ///  - false: Do not keep an archive of messages sent to this group. If false, previously archived messages
        /// remain in the archive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isArchived")]
        public virtual string IsArchived { get; set; }

        /// <summary>The type of the resource. It is always groupsSettings#groups.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Deprecated. The maximum size of a message is 25Mb.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxMessageBytes")]
        public virtual System.Nullable<int> MaxMessageBytes { get; set; }

        /// <summary>
        /// Enables members to post messages as the group. Possible values are:   - true: Group member can post messages
        /// using the group's email address instead of their own email address. Message appear to originate from the
        /// group itself. Note: When true, any message moderation settings on individual users or new members do not
        /// apply to posts made on behalf of the group.  - false: Members can not post in behalf of the group's email
        /// address.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membersCanPostAsTheGroup")]
        public virtual string MembersCanPostAsTheGroup { get; set; }

        /// <summary>Deprecated. The default message display font always has a value of "DEFAULT_FONT".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageDisplayFont")]
        public virtual string MessageDisplayFont { get; set; }

        /// <summary>
        /// Moderation level of incoming messages. Possible values are:   - MODERATE_ALL_MESSAGES: All messages are sent
        /// to the group owner's email address for approval. If approved, the message is sent to the group.  -
        /// MODERATE_NON_MEMBERS: All messages from non group members are sent to the group owner's email address for
        /// approval. If approved, the message is sent to the group.  - MODERATE_NEW_MEMBERS: All messages from new
        /// members are sent to the group owner's email address for approval. If approved, the message is sent to the
        /// group.  - MODERATE_NONE: No moderator approval is required. Messages are delivered directly to the group.
        /// Note: When the whoCanPostMessage is set to ANYONE_CAN_POST, we recommend the messageModerationLevel be set
        /// to MODERATE_NON_MEMBERS to protect the group from possible spam. When memberCanPostAsTheGroup is true, any
        /// message moderation settings on individual users or new members will not apply to posts made on behalf of the
        /// group.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageModerationLevel")]
        public virtual string MessageModerationLevel { get; set; }

        /// <summary>Name of the group, which has a maximum size of 75 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The primary language for group. For a group's primary language use the language tags from the G Suite
        /// languages found at G Suite Email Settings API Email Language Tags.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryLanguage")]
        public virtual string PrimaryLanguage { get; set; }

        /// <summary>
        /// Specifies who receives the default reply. Possible values are:   - REPLY_TO_CUSTOM: For replies to messages,
        /// use the group's custom email address. When the group's ReplyTo property is set to REPLY_TO_CUSTOM, the
        /// customReplyTo property holds the custom email address used when replying to a message. If the group's
        /// ReplyTo property is set to REPLY_TO_CUSTOM, the customReplyTo property must have a value. Otherwise an error
        /// is returned.   - REPLY_TO_SENDER: The reply sent to author of message.  - REPLY_TO_LIST: This reply message
        /// is sent to the group.  - REPLY_TO_OWNER: The reply is sent to the owner(s) of the group. This does not
        /// include the group's managers.  - REPLY_TO_IGNORE: Group users individually decide where the message reply is
        /// sent.  - REPLY_TO_MANAGERS: This reply message is sent to the group's managers, which includes all managers
        /// and the group owner.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replyTo")]
        public virtual string ReplyTo { get; set; }

        /// <summary>
        /// Allows a member to be notified if the member's message to the group is denied by the group owner. Possible
        /// values are:   - true: When a message is rejected, send the deny message notification to the message author.
        /// The defaultMessageDenyNotificationText property is dependent on the sendMessageDenyNotification property
        /// being true.   - false: When a message is rejected, no notification is sent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sendMessageDenyNotification")]
        public virtual string SendMessageDenyNotification { get; set; }

        /// <summary>
        /// Deprecated. This is merged into the new whoCanDiscoverGroup setting. Allows the group to be visible in the
        /// Groups Directory. Possible values are:   - true: All groups in the account are listed in the Groups
        /// directory.  - false: All groups in the account are not listed in the directory.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("showInGroupDirectory")]
        public virtual string ShowInGroupDirectory { get; set; }

        /// <summary>
        /// Specifies moderation levels for messages detected as spam. Possible values are:   - ALLOW: Post the message
        /// to the group.  - MODERATE: Send the message to the moderation queue. This is the default.  -
        /// SILENTLY_MODERATE: Send the message to the moderation queue, but do not send notification to moderators.  -
        /// REJECT: Immediately reject the message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spamModerationLevel")]
        public virtual string SpamModerationLevel { get; set; }

        /// <summary>
        /// Deprecated. This is merged into the new whoCanModerateMembers setting. Permissions to add members. Possible
        /// values are:   - ALL_MEMBERS_CAN_ADD: Managers and members can directly add new members.  -
        /// ALL_MANAGERS_CAN_ADD: Only managers can directly add new members. this includes the group's owner.  -
        /// ALL_OWNERS_CAN_ADD: Only owners can directly add new members.  - NONE_CAN_ADD: No one can directly add new
        /// members.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanAdd")]
        public virtual string WhoCanAdd { get; set; }

        /// <summary>
        /// Deprecated. This functionality is no longer supported in the Google Groups UI. The value is always "NONE".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanAddReferences")]
        public virtual string WhoCanAddReferences { get; set; }

        /// <summary>
        /// Specifies who can approve members who ask to join groups. This permission will be deprecated once it is
        /// merged into the new whoCanModerateMembers setting. Possible values are:   - ALL_MEMBERS_CAN_APPROVE  -
        /// ALL_MANAGERS_CAN_APPROVE  - ALL_OWNERS_CAN_APPROVE  - NONE_CAN_APPROVE
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanApproveMembers")]
        public virtual string WhoCanApproveMembers { get; set; }

        /// <summary>
        /// Deprecated. This is merged into the new whoCanModerateContent setting. Specifies who can approve pending
        /// messages in the moderation queue. Possible values are:   - ALL_MEMBERS  - OWNERS_AND_MANAGERS  - OWNERS_ONLY
        ///  - NONE
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanApproveMessages")]
        public virtual string WhoCanApproveMessages { get; set; }

        /// <summary>
        /// Deprecated. This is merged into the new whoCanAssistContent setting. Permission to assign topics in a forum
        /// to another user. Possible values are:   - ALL_MEMBERS  - OWNERS_AND_MANAGERS  - MANAGERS_ONLY  - OWNERS_ONLY
        ///  - NONE
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanAssignTopics")]
        public virtual string WhoCanAssignTopics { get; set; }

        /// <summary>
        /// Specifies who can moderate metadata. Possible values are:   - ALL_MEMBERS  - OWNERS_AND_MANAGERS  -
        /// MANAGERS_ONLY  - OWNERS_ONLY  - NONE
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanAssistContent")]
        public virtual string WhoCanAssistContent { get; set; }

        /// <summary>
        /// Specifies who can deny membership to users. This permission will be deprecated once it is merged into the
        /// new whoCanModerateMembers setting. Possible values are:   - ALL_MEMBERS  - OWNERS_AND_MANAGERS  -
        /// OWNERS_ONLY  - NONE
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanBanUsers")]
        public virtual string WhoCanBanUsers { get; set; }

        /// <summary>
        /// Permission to contact owner of the group via web UI. Possible values are:   - ALL_IN_DOMAIN_CAN_CONTACT  -
        /// ALL_MANAGERS_CAN_CONTACT  - ALL_MEMBERS_CAN_CONTACT  - ANYONE_CAN_CONTACT  - ALL_OWNERS_CAN_CONTACT
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanContactOwner")]
        public virtual string WhoCanContactOwner { get; set; }

        /// <summary>
        /// Deprecated. This is merged into the new whoCanModerateContent setting. Specifies who can delete replies to
        /// topics. (Authors can always delete their own posts). Possible values are:   - ALL_MEMBERS  -
        /// OWNERS_AND_MANAGERS  - OWNERS_ONLY  - NONE
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanDeleteAnyPost")]
        public virtual string WhoCanDeleteAnyPost { get; set; }

        /// <summary>
        /// Deprecated. This is merged into the new whoCanModerateContent setting. Specifies who can delete topics.
        /// Possible values are:   - ALL_MEMBERS  - OWNERS_AND_MANAGERS  - OWNERS_ONLY  - NONE
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanDeleteTopics")]
        public virtual string WhoCanDeleteTopics { get; set; }

        /// <summary>
        /// Specifies the set of users for whom this group is discoverable. Possible values are:   - ANYONE_CAN_DISCOVER
        ///  - ALL_IN_DOMAIN_CAN_DISCOVER  - ALL_MEMBERS_CAN_DISCOVER
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanDiscoverGroup")]
        public virtual string WhoCanDiscoverGroup { get; set; }

        /// <summary>
        /// Deprecated. This is merged into the new whoCanAssistContent setting. Permission to enter free form tags for
        /// topics in a forum. Possible values are:   - ALL_MEMBERS  - OWNERS_AND_MANAGERS  - MANAGERS_ONLY  -
        /// OWNERS_ONLY  - NONE
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanEnterFreeFormTags")]
        public virtual string WhoCanEnterFreeFormTags { get; set; }

        /// <summary>
        /// Deprecated. This is merged into the new whoCanModerateContent setting. Specifies who can hide posts by
        /// reporting them as abuse. Possible values are:   - ALL_MEMBERS  - OWNERS_AND_MANAGERS  - OWNERS_ONLY  - NONE
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanHideAbuse")]
        public virtual string WhoCanHideAbuse { get; set; }

        /// <summary>
        /// Deprecated. This is merged into the new whoCanModerateMembers setting. Permissions to invite new members.
        /// Possible values are:   - ALL_MEMBERS_CAN_INVITE: Managers and members can invite a new member candidate.  -
        /// ALL_MANAGERS_CAN_INVITE: Only managers can invite a new member. This includes the group's owner.  -
        /// ALL_OWNERS_CAN_INVITE: Only owners can invite a new member.  - NONE_CAN_INVITE: No one can invite a new
        /// member candidate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanInvite")]
        public virtual string WhoCanInvite { get; set; }

        /// <summary>
        /// Permission to join group. Possible values are:   - ANYONE_CAN_JOIN: Anyone in the account domain can join.
        /// This includes accounts with multiple domains.  - ALL_IN_DOMAIN_CAN_JOIN: Any Internet user who is outside
        /// your domain can access your Google Groups service and view the list of groups in your Groups directory.
        /// Warning: Group owners can add external addresses, outside of the domain to their groups. They can also allow
        /// people outside your domain to join their groups. If you later disable this option, any external addresses
        /// already added to users' groups remain in those groups.  - INVITED_CAN_JOIN: Candidates for membership can be
        /// invited to join.   - CAN_REQUEST_TO_JOIN: Non members can request an invitation to join.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanJoin")]
        public virtual string WhoCanJoin { get; set; }

        /// <summary>
        /// Permission to leave the group. Possible values are:   - ALL_MANAGERS_CAN_LEAVE  - ALL_MEMBERS_CAN_LEAVE  -
        /// NONE_CAN_LEAVE
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanLeaveGroup")]
        public virtual string WhoCanLeaveGroup { get; set; }

        /// <summary>
        /// Deprecated. This is merged into the new whoCanModerateContent setting. Specifies who can prevent users from
        /// posting replies to topics. Possible values are:   - ALL_MEMBERS  - OWNERS_AND_MANAGERS  - OWNERS_ONLY  -
        /// NONE
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanLockTopics")]
        public virtual string WhoCanLockTopics { get; set; }

        /// <summary>
        /// Deprecated. This is merged into the new whoCanModerateContent setting. Specifies who can make topics appear
        /// at the top of the topic list. Possible values are:   - ALL_MEMBERS  - OWNERS_AND_MANAGERS  - OWNERS_ONLY  -
        /// NONE
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanMakeTopicsSticky")]
        public virtual string WhoCanMakeTopicsSticky { get; set; }

        /// <summary>
        /// Deprecated. This is merged into the new whoCanAssistContent setting. Permission to mark a topic as a
        /// duplicate of another topic. Possible values are:   - ALL_MEMBERS  - OWNERS_AND_MANAGERS  - MANAGERS_ONLY  -
        /// OWNERS_ONLY  - NONE
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanMarkDuplicate")]
        public virtual string WhoCanMarkDuplicate { get; set; }

        /// <summary>
        /// Deprecated. This is merged into the new whoCanAssistContent setting. Permission to mark any other user's
        /// post as a favorite reply. Possible values are:   - ALL_MEMBERS  - OWNERS_AND_MANAGERS  - MANAGERS_ONLY  -
        /// OWNERS_ONLY  - NONE
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanMarkFavoriteReplyOnAnyTopic")]
        public virtual string WhoCanMarkFavoriteReplyOnAnyTopic { get; set; }

        /// <summary>
        /// Deprecated. This is merged into the new whoCanAssistContent setting. Permission to mark a post for a topic
        /// they started as a favorite reply. Possible values are:   - ALL_MEMBERS  - OWNERS_AND_MANAGERS  -
        /// MANAGERS_ONLY  - OWNERS_ONLY  - NONE
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanMarkFavoriteReplyOnOwnTopic")]
        public virtual string WhoCanMarkFavoriteReplyOnOwnTopic { get; set; }

        /// <summary>
        /// Deprecated. This is merged into the new whoCanAssistContent setting. Permission to mark a topic as not
        /// needing a response. Possible values are:   - ALL_MEMBERS  - OWNERS_AND_MANAGERS  - MANAGERS_ONLY  -
        /// OWNERS_ONLY  - NONE
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanMarkNoResponseNeeded")]
        public virtual string WhoCanMarkNoResponseNeeded { get; set; }

        /// <summary>
        /// Specifies who can moderate content. Possible values are:   - ALL_MEMBERS  - OWNERS_AND_MANAGERS  -
        /// OWNERS_ONLY  - NONE
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanModerateContent")]
        public virtual string WhoCanModerateContent { get; set; }

        /// <summary>
        /// Specifies who can manage members. Possible values are:   - ALL_MEMBERS  - OWNERS_AND_MANAGERS  - OWNERS_ONLY
        ///  - NONE
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanModerateMembers")]
        public virtual string WhoCanModerateMembers { get; set; }

        /// <summary>
        /// Deprecated. This is merged into the new whoCanModerateMembers setting. Specifies who can change group
        /// members' roles. Possible values are:   - ALL_MEMBERS  - OWNERS_AND_MANAGERS  - OWNERS_ONLY  - NONE
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanModifyMembers")]
        public virtual string WhoCanModifyMembers { get; set; }

        /// <summary>
        /// Deprecated. This is merged into the new whoCanAssistContent setting. Permission to change tags and
        /// categories. Possible values are:   - ALL_MEMBERS  - OWNERS_AND_MANAGERS  - MANAGERS_ONLY  - OWNERS_ONLY  -
        /// NONE
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanModifyTagsAndCategories")]
        public virtual string WhoCanModifyTagsAndCategories { get; set; }

        /// <summary>
        /// Deprecated. This is merged into the new whoCanModerateContent setting. Specifies who can move topics into
        /// the group or forum. Possible values are:   - ALL_MEMBERS  - OWNERS_AND_MANAGERS  - OWNERS_ONLY  - NONE
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanMoveTopicsIn")]
        public virtual string WhoCanMoveTopicsIn { get; set; }

        /// <summary>
        /// Deprecated. This is merged into the new whoCanModerateContent setting. Specifies who can move topics out of
        /// the group or forum. Possible values are:   - ALL_MEMBERS  - OWNERS_AND_MANAGERS  - OWNERS_ONLY  - NONE
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanMoveTopicsOut")]
        public virtual string WhoCanMoveTopicsOut { get; set; }

        /// <summary>
        /// Deprecated. This is merged into the new whoCanModerateContent setting. Specifies who can post announcements,
        /// a special topic type. Possible values are:   - ALL_MEMBERS  - OWNERS_AND_MANAGERS  - OWNERS_ONLY  - NONE
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanPostAnnouncements")]
        public virtual string WhoCanPostAnnouncements { get; set; }

        /// <summary>
        /// Permissions to post messages. Possible values are:   - NONE_CAN_POST: The group is disabled and archived. No
        /// one can post a message to this group.   - When archiveOnly is false, updating whoCanPostMessage to
        /// NONE_CAN_POST, results in an error.  - If archiveOnly is reverted from true to false, whoCanPostMessages is
        /// set to ALL_MANAGERS_CAN_POST.   - ALL_MANAGERS_CAN_POST: Managers, including group owners, can post
        /// messages.  - ALL_MEMBERS_CAN_POST: Any group member can post a message.  - ALL_OWNERS_CAN_POST: Only group
        /// owners can post a message.  - ALL_IN_DOMAIN_CAN_POST: Anyone in the account can post a message.   -
        /// ANYONE_CAN_POST: Any Internet user who outside your account can access your Google Groups service and post a
        /// message. Note: When whoCanPostMessage is set to ANYONE_CAN_POST, we recommend the messageModerationLevel be
        /// set to MODERATE_NON_MEMBERS to protect the group from possible spam.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanPostMessage")]
        public virtual string WhoCanPostMessage { get; set; }

        /// <summary>
        /// Deprecated. This is merged into the new whoCanAssistContent setting. Permission to take topics in a forum.
        /// Possible values are:   - ALL_MEMBERS  - OWNERS_AND_MANAGERS  - MANAGERS_ONLY  - OWNERS_ONLY  - NONE
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanTakeTopics")]
        public virtual string WhoCanTakeTopics { get; set; }

        /// <summary>
        /// Deprecated. This is merged into the new whoCanAssistContent setting. Permission to unassign any topic in a
        /// forum. Possible values are:   - ALL_MEMBERS  - OWNERS_AND_MANAGERS  - MANAGERS_ONLY  - OWNERS_ONLY  - NONE
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanUnassignTopic")]
        public virtual string WhoCanUnassignTopic { get; set; }

        /// <summary>
        /// Deprecated. This is merged into the new whoCanAssistContent setting. Permission to unmark any post from a
        /// favorite reply. Possible values are:   - ALL_MEMBERS  - OWNERS_AND_MANAGERS  - MANAGERS_ONLY  - OWNERS_ONLY
        /// - NONE
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanUnmarkFavoriteReplyOnAnyTopic")]
        public virtual string WhoCanUnmarkFavoriteReplyOnAnyTopic { get; set; }

        /// <summary>
        /// Permissions to view group messages. Possible values are:   - ANYONE_CAN_VIEW: Any Internet user can view the
        /// group's messages.   - ALL_IN_DOMAIN_CAN_VIEW: Anyone in your account can view this group's messages.  -
        /// ALL_MEMBERS_CAN_VIEW: All group members can view the group's messages.  - ALL_MANAGERS_CAN_VIEW: Any group
        /// manager can view this group's messages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanViewGroup")]
        public virtual string WhoCanViewGroup { get; set; }

        /// <summary>
        /// Permissions to view membership. Possible values are:   - ALL_IN_DOMAIN_CAN_VIEW: Anyone in the account can
        /// view the group members list. If a group already has external members, those members can still send email to
        /// this group.   - ALL_MEMBERS_CAN_VIEW: The group members can view the group members list.  -
        /// ALL_MANAGERS_CAN_VIEW: The group managers can view group members list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanViewMembership")]
        public virtual string WhoCanViewMembership { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
