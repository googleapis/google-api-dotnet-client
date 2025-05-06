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

namespace Google.Apis.WorkspaceEvents.v1
{
    /// <summary>The WorkspaceEvents Service.</summary>
    public class WorkspaceEventsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public WorkspaceEventsService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public WorkspaceEventsService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Operations = new OperationsResource(this);
            Subscriptions = new SubscriptionsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://workspaceevents.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://workspaceevents.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "workspaceevents";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Google Workspace Events API.</summary>
        public class Scope
        {
            /// <summary>Private Service: https://www.googleapis.com/auth/chat.bot</summary>
            public static string ChatBot = "https://www.googleapis.com/auth/chat.bot";

            /// <summary>See, add, update, and remove members from conversations and spaces in Google Chat</summary>
            public static string ChatMemberships = "https://www.googleapis.com/auth/chat.memberships";

            /// <summary>View members in Google Chat conversations.</summary>
            public static string ChatMembershipsReadonly = "https://www.googleapis.com/auth/chat.memberships.readonly";

            /// <summary>
            /// See, compose, send, update, and delete messages as well as their message content; add, see, and delete
            /// reactions to messages.
            /// </summary>
            public static string ChatMessages = "https://www.googleapis.com/auth/chat.messages";

            /// <summary>
            /// See, add, and delete reactions as well as their reaction content to messages in Google Chat
            /// </summary>
            public static string ChatMessagesReactions = "https://www.googleapis.com/auth/chat.messages.reactions";

            /// <summary>View reactions as well as their reaction content to messages in Google Chat</summary>
            public static string ChatMessagesReactionsReadonly = "https://www.googleapis.com/auth/chat.messages.reactions.readonly";

            /// <summary>See messages as well as their reactions and message content in Google Chat</summary>
            public static string ChatMessagesReadonly = "https://www.googleapis.com/auth/chat.messages.readonly";

            /// <summary>
            /// Create conversations and spaces and see or update metadata (including history settings and access
            /// settings) in Google Chat
            /// </summary>
            public static string ChatSpaces = "https://www.googleapis.com/auth/chat.spaces";

            /// <summary>View chat and spaces in Google Chat</summary>
            public static string ChatSpacesReadonly = "https://www.googleapis.com/auth/chat.spaces.readonly";

            /// <summary>See, edit, create, and delete all of your Google Drive files</summary>
            public static string Drive = "https://www.googleapis.com/auth/drive";

            /// <summary>
            /// See, edit, create, and delete only the specific Google Drive files you use with this app
            /// </summary>
            public static string DriveFile = "https://www.googleapis.com/auth/drive.file";

            /// <summary>View and manage metadata of files in your Google Drive</summary>
            public static string DriveMetadata = "https://www.googleapis.com/auth/drive.metadata";

            /// <summary>See information about your Google Drive files</summary>
            public static string DriveMetadataReadonly = "https://www.googleapis.com/auth/drive.metadata.readonly";

            /// <summary>See and download all your Google Drive files</summary>
            public static string DriveReadonly = "https://www.googleapis.com/auth/drive.readonly";

            /// <summary>
            /// Create, edit, and see information about your Google Meet conferences created by the app.
            /// </summary>
            public static string MeetingsSpaceCreated = "https://www.googleapis.com/auth/meetings.space.created";

            /// <summary>Read information about any of your Google Meet conferences</summary>
            public static string MeetingsSpaceReadonly = "https://www.googleapis.com/auth/meetings.space.readonly";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Google Workspace Events API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Private Service: https://www.googleapis.com/auth/chat.bot</summary>
            public const string ChatBot = "https://www.googleapis.com/auth/chat.bot";

            /// <summary>See, add, update, and remove members from conversations and spaces in Google Chat</summary>
            public const string ChatMemberships = "https://www.googleapis.com/auth/chat.memberships";

            /// <summary>View members in Google Chat conversations.</summary>
            public const string ChatMembershipsReadonly = "https://www.googleapis.com/auth/chat.memberships.readonly";

            /// <summary>
            /// See, compose, send, update, and delete messages as well as their message content; add, see, and delete
            /// reactions to messages.
            /// </summary>
            public const string ChatMessages = "https://www.googleapis.com/auth/chat.messages";

            /// <summary>
            /// See, add, and delete reactions as well as their reaction content to messages in Google Chat
            /// </summary>
            public const string ChatMessagesReactions = "https://www.googleapis.com/auth/chat.messages.reactions";

            /// <summary>View reactions as well as their reaction content to messages in Google Chat</summary>
            public const string ChatMessagesReactionsReadonly = "https://www.googleapis.com/auth/chat.messages.reactions.readonly";

            /// <summary>See messages as well as their reactions and message content in Google Chat</summary>
            public const string ChatMessagesReadonly = "https://www.googleapis.com/auth/chat.messages.readonly";

            /// <summary>
            /// Create conversations and spaces and see or update metadata (including history settings and access
            /// settings) in Google Chat
            /// </summary>
            public const string ChatSpaces = "https://www.googleapis.com/auth/chat.spaces";

            /// <summary>View chat and spaces in Google Chat</summary>
            public const string ChatSpacesReadonly = "https://www.googleapis.com/auth/chat.spaces.readonly";

            /// <summary>See, edit, create, and delete all of your Google Drive files</summary>
            public const string Drive = "https://www.googleapis.com/auth/drive";

            /// <summary>
            /// See, edit, create, and delete only the specific Google Drive files you use with this app
            /// </summary>
            public const string DriveFile = "https://www.googleapis.com/auth/drive.file";

            /// <summary>View and manage metadata of files in your Google Drive</summary>
            public const string DriveMetadata = "https://www.googleapis.com/auth/drive.metadata";

            /// <summary>See information about your Google Drive files</summary>
            public const string DriveMetadataReadonly = "https://www.googleapis.com/auth/drive.metadata.readonly";

            /// <summary>See and download all your Google Drive files</summary>
            public const string DriveReadonly = "https://www.googleapis.com/auth/drive.readonly";

            /// <summary>
            /// Create, edit, and see information about your Google Meet conferences created by the app.
            /// </summary>
            public const string MeetingsSpaceCreated = "https://www.googleapis.com/auth/meetings.space.created";

            /// <summary>Read information about any of your Google Meet conferences</summary>
            public const string MeetingsSpaceReadonly = "https://www.googleapis.com/auth/meetings.space.readonly";
        }

        /// <summary>Gets the Operations resource.</summary>
        public virtual OperationsResource Operations { get; }

        /// <summary>Gets the Subscriptions resource.</summary>
        public virtual SubscriptionsResource Subscriptions { get; }
    }

    /// <summary>A base abstract class for WorkspaceEvents requests.</summary>
    public abstract class WorkspaceEventsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new WorkspaceEventsBaseServiceRequest instance.</summary>
        protected WorkspaceEventsBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes WorkspaceEvents parameter list.</summary>
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
            return new GetRequest(this.service, name);
        }

        /// <summary>
        /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation result
        /// at intervals as recommended by the API service.
        /// </summary>
        public class GetRequest : WorkspaceEventsBaseServiceRequest<Google.Apis.WorkspaceEvents.v1.Data.Operation>
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

    /// <summary>The "subscriptions" collection of methods.</summary>
    public class SubscriptionsResource
    {
        private const string Resource = "subscriptions";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public SubscriptionsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Creates a Google Workspace subscription. To learn how to use this method, see [Create a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/create-subscription).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.WorkspaceEvents.v1.Data.Subscription body)
        {
            return new CreateRequest(this.service, body);
        }

        /// <summary>
        /// Creates a Google Workspace subscription. To learn how to use this method, see [Create a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/create-subscription).
        /// </summary>
        public class CreateRequest : WorkspaceEventsBaseServiceRequest<Google.Apis.WorkspaceEvents.v1.Data.Operation>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.WorkspaceEvents.v1.Data.Subscription body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Optional. If set to `true`, validates and previews the request, but doesn't create the subscription.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ValidateOnly { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.WorkspaceEvents.v1.Data.Subscription Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/subscriptions";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                {
                    Name = "validateOnly",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Deletes a Google Workspace subscription. To learn how to use this method, see [Delete a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/delete-subscription).
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the subscription to delete. Format: `subscriptions/{subscription}`
        /// </param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(this.service, name);
        }

        /// <summary>
        /// Deletes a Google Workspace subscription. To learn how to use this method, see [Delete a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/delete-subscription).
        /// </summary>
        public class DeleteRequest : WorkspaceEventsBaseServiceRequest<Google.Apis.WorkspaceEvents.v1.Data.Operation>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. Resource name of the subscription to delete. Format: `subscriptions/{subscription}`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// Optional. If set to `true` and the subscription isn't found, the request succeeds but doesn't delete the
            /// subscription.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> AllowMissing { get; set; }

            /// <summary>
            /// Optional. Etag of the subscription. If present, it must match with the server's etag. Otherwise, request
            /// fails with the status `ABORTED`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Etag { get; set; }

            /// <summary>
            /// Optional. If set to `true`, validates and previews the request, but doesn't delete the subscription.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ValidateOnly { get; set; }

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
                    Pattern = @"^subscriptions/[^/]+$",
                });
                RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                {
                    Name = "allowMissing",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                {
                    Name = "etag",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                {
                    Name = "validateOnly",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Gets details about a Google Workspace subscription. To learn how to use this method, see [Get details about
        /// a Google Workspace subscription](https://developers.google.com/workspace/events/guides/get-subscription).
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the subscription. Format: `subscriptions/{subscription}`
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(this.service, name);
        }

        /// <summary>
        /// Gets details about a Google Workspace subscription. To learn how to use this method, see [Get details about
        /// a Google Workspace subscription](https://developers.google.com/workspace/events/guides/get-subscription).
        /// </summary>
        public class GetRequest : WorkspaceEventsBaseServiceRequest<Google.Apis.WorkspaceEvents.v1.Data.Subscription>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. Resource name of the subscription. Format: `subscriptions/{subscription}`</summary>
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
                    Pattern = @"^subscriptions/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Lists Google Workspace subscriptions. To learn how to use this method, see [List Google Workspace
        /// subscriptions](https://developers.google.com/workspace/events/guides/list-subscriptions).
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>
        /// Lists Google Workspace subscriptions. To learn how to use this method, see [List Google Workspace
        /// subscriptions](https://developers.google.com/workspace/events/guides/list-subscriptions).
        /// </summary>
        public class ListRequest : WorkspaceEventsBaseServiceRequest<Google.Apis.WorkspaceEvents.v1.Data.ListSubscriptionsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Required. A query filter. You can filter subscriptions by event type (`event_types`) and target resource
            /// (`target_resource`). You must specify at least one event type in your query. To filter for multiple
            /// event types, use the `OR` operator. To filter by both event type and target resource, use the `AND`
            /// operator and specify the full resource name, such as `//chat.googleapis.com/spaces/{space}`. For
            /// example, the following queries are valid:
            /// ```
            /// event_types:"google.workspace.chat.membership.v1.updated"
            /// OR event_types:"google.workspace.chat.message.v1.created"
            /// event_types:"google.workspace.chat.message.v1.created" AND
            /// target_resource="//chat.googleapis.com/spaces/{space}" (
            /// event_types:"google.workspace.chat.membership.v1.updated" OR
            /// event_types:"google.workspace.chat.message.v1.created" ) AND
            /// target_resource="//chat.googleapis.com/spaces/{space}"
            /// ```
            /// The server rejects invalid queries with an
            /// `INVALID_ARGUMENT` error.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>
            /// Optional. The maximum number of subscriptions to return. The service might return fewer than this value.
            /// If unspecified or set to `0`, up to 50 subscriptions are returned. The maximum value is 100. If you
            /// specify a value more than 100, the system only returns 100 subscriptions.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. A page token, received from a previous list subscriptions call. Provide this parameter to
            /// retrieve the subsequent page. When paginating, the filter value should match the call that provided the
            /// page token. Passing a different value might lead to unexpected results.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/subscriptions";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
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

        /// <summary>
        /// Updates or renews a Google Workspace subscription. To learn how to use this method, see [Update or renew a
        /// Google Workspace subscription](https://developers.google.com/workspace/events/guides/update-subscription).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Identifier. Resource name of the subscription. Format: `subscriptions/{subscription}`
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.WorkspaceEvents.v1.Data.Subscription body, string name)
        {
            return new PatchRequest(this.service, body, name);
        }

        /// <summary>
        /// Updates or renews a Google Workspace subscription. To learn how to use this method, see [Update or renew a
        /// Google Workspace subscription](https://developers.google.com/workspace/events/guides/update-subscription).
        /// </summary>
        public class PatchRequest : WorkspaceEventsBaseServiceRequest<Google.Apis.WorkspaceEvents.v1.Data.Operation>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.WorkspaceEvents.v1.Data.Subscription body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>Identifier. Resource name of the subscription. Format: `subscriptions/{subscription}`</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// Optional. The field to update. If omitted, updates any fields included in the request. You can update
            /// one of the following fields in a subscription: * `expire_time`: The timestamp when the subscription
            /// expires. * `ttl`: The time-to-live (TTL) or duration of the subscription. * `event_types`: The list of
            /// event types to receive about the target resource. To fully replace the subscription (the equivalent of
            /// `PUT`), use `*`. Any omitted fields are updated with empty values.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>
            /// Optional. If set to `true`, validates and previews the request, but doesn't update the subscription.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ValidateOnly { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.WorkspaceEvents.v1.Data.Subscription Body { get; set; }

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
                    Pattern = @"^subscriptions/[^/]+$",
                });
                RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                {
                    Name = "updateMask",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                {
                    Name = "validateOnly",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Reactivates a suspended Google Workspace subscription. This method resets your subscription's `State` field
        /// to `ACTIVE`. Before you use this method, you must fix the error that suspended the subscription. This method
        /// will ignore or reject any subscription that isn't currently in a suspended state. To learn how to use this
        /// method, see [Reactivate a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/reactivate-subscription).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Required. Resource name of the subscription. Format: `subscriptions/{subscription}`
        /// </param>
        public virtual ReactivateRequest Reactivate(Google.Apis.WorkspaceEvents.v1.Data.ReactivateSubscriptionRequest body, string name)
        {
            return new ReactivateRequest(this.service, body, name);
        }

        /// <summary>
        /// Reactivates a suspended Google Workspace subscription. This method resets your subscription's `State` field
        /// to `ACTIVE`. Before you use this method, you must fix the error that suspended the subscription. This method
        /// will ignore or reject any subscription that isn't currently in a suspended state. To learn how to use this
        /// method, see [Reactivate a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/reactivate-subscription).
        /// </summary>
        public class ReactivateRequest : WorkspaceEventsBaseServiceRequest<Google.Apis.WorkspaceEvents.v1.Data.Operation>
        {
            /// <summary>Constructs a new Reactivate request.</summary>
            public ReactivateRequest(Google.Apis.Services.IClientService service, Google.Apis.WorkspaceEvents.v1.Data.ReactivateSubscriptionRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Resource name of the subscription. Format: `subscriptions/{subscription}`</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.WorkspaceEvents.v1.Data.ReactivateSubscriptionRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "reactivate";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}:reactivate";

            /// <summary>Initializes Reactivate parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^subscriptions/[^/]+$",
                });
            }
        }
    }
}
namespace Google.Apis.WorkspaceEvents.v1.Data
{
    /// <summary>The response message for SubscriptionsService.ListSubscriptions.</summary>
    public class ListSubscriptionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of subscriptions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriptions")]
        public virtual System.Collections.Generic.IList<Subscription> Subscriptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The endpoint where the subscription delivers events.</summary>
    public class NotificationEndpoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Immutable. The Pub/Sub topic that receives events for the subscription. Format:
        /// `projects/{project}/topics/{topic}` You must create the topic in the same Google Cloud project where you
        /// create this subscription. Note: The Workspace Events API uses [ordering
        /// keys](https://cloud.google.com/pubsub/docs/ordering) for the benefit of sequential events. If the Cloud
        /// Pub/Sub topic has a [message storage
        /// policy](https://cloud.google.com/pubsub/docs/resource-location-restriction#exceptions) configured to exclude
        /// the nearest Google Cloud region, publishing events with ordering keys will fail. When the topic receives
        /// events, the events are encoded as Pub/Sub messages. For details, see the [Google Cloud Pub/Sub Protocol
        /// Binding for CloudEvents](https://github.com/googleapis/google-cloudevents/blob/main/docs/spec/pubsub.md).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pubsubTopic")]
        public virtual string PubsubTopic { get; set; }

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

        /// <summary>The error result of the operation in case of failure or cancellation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>
        /// Service-specific metadata associated with the operation. It typically contains progress information and
        /// common metadata such as create time. Some services might not provide such metadata. Any method that returns
        /// a long-running operation should document the metadata type, if any.
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
        /// The normal, successful response of the operation. If the original method returns no data on success, such as
        /// `Delete`, the response is `google.protobuf.Empty`. If the original method is standard
        /// `Get`/`Create`/`Update`, the response should be the resource. For other methods, the response should have
        /// the type `XxxResponse`, where `Xxx` is the original method name. For example, if the original method name is
        /// `TakeSnapshot()`, the inferred response type is `TakeSnapshotResponse`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string, object> Response { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Options about what data to include in the event payload. Only supported for Google Chat events.
    /// </summary>
    public class PayloadOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If `include_resource` is set to `true`, the list of fields to include in the event payload.
        /// Separate fields with a comma. For example, to include a Google Chat message's sender and create time, enter
        /// `message.sender,message.createTime`. If omitted, the payload includes all fields for the resource. If you
        /// specify a field that doesn't exist for the resource, the system ignores the field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldMask")]
        public virtual object FieldMask { get; set; }

        /// <summary>
        /// Optional. Whether the event payload includes data about the resource that changed. For example, for an event
        /// where a Google Chat message was created, whether the payload contains data about the
        /// [`Message`](https://developers.google.com/chat/api/reference/rest/v1/spaces.messages) resource. If false,
        /// the event payload only includes the name of the changed resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeResource")]
        public virtual System.Nullable<bool> IncludeResource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for SubscriptionsService.ReactivateSubscription.</summary>
    public class ReactivateSubscriptionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
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

    /// <summary>
    /// A subscription to receive events about a Google Workspace resource. To learn more about subscriptions, see the
    /// [Google Workspace Events API overview](https://developers.google.com/workspace/events).
    /// </summary>
    public class Subscription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The user who authorized the creation of the subscription. Format: `users/{user}` For Google
        /// Workspace users, the `{user}` value is the
        /// [`user.id`](https://developers.google.com/admin-sdk/directory/reference/rest/v1/users#User.FIELDS.ids) field
        /// from the Directory API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authority")]
        public virtual string Authority { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time when the subscription is created.</summary>
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
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Optional. This checksum is computed by the server based on the value of other fields, and might be sent on
        /// update requests to ensure the client has an up-to-date value before proceeding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Required. Unordered list. Input for creating a subscription. Otherwise, output only. One or more types of
        /// events to receive about the target resource. Formatted according to the CloudEvents specification. The
        /// supported event types depend on the target resource of your subscription. For details, see [Supported Google
        /// Workspace events](https://developers.google.com/workspace/events/guides#supported-events). By default, you
        /// also receive events about the [lifecycle of your
        /// subscription](https://developers.google.com/workspace/events/guides/events-lifecycle). You don't need to
        /// specify lifecycle events for this field. If you specify an event type that doesn't exist for the target
        /// resource, the request returns an HTTP `400 Bad Request` status code.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTypes")]
        public virtual System.Collections.Generic.IList<string> EventTypes { get; set; }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// Non-empty default. The timestamp in UTC when the subscription expires. Always displayed on output,
        /// regardless of what was used on input.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual string ExpireTimeRaw
        {
            get => _expireTimeRaw;
            set
            {
                _expireTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expireTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpireTimeDateTimeOffset instead.")]
        public virtual object ExpireTime
        {
            get => _expireTime;
            set
            {
                _expireTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expireTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpireTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpireTimeRaw);
            set => ExpireTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Identifier. Resource name of the subscription. Format: `subscriptions/{subscription}`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. Immutable. The endpoint where the subscription delivers events, such as a Pub/Sub topic.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationEndpoint")]
        public virtual NotificationEndpoint NotificationEndpoint { get; set; }

        /// <summary>
        /// Optional. Options about what data to include in the event payload. Only supported for Google Chat events.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payloadOptions")]
        public virtual PayloadOptions PayloadOptions { get; set; }

        /// <summary>Output only. If `true`, the subscription is in the process of being updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reconciling")]
        public virtual System.Nullable<bool> Reconciling { get; set; }

        /// <summary>
        /// Output only. The state of the subscription. Determines whether the subscription can receive events and
        /// deliver them to the notification endpoint.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Output only. The error that suspended the subscription. To reactivate the subscription, resolve the error
        /// and call the `ReactivateSubscription` method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suspensionReason")]
        public virtual string SuspensionReason { get; set; }

        /// <summary>
        /// Required. Immutable. The Google Workspace resource that's monitored for events, formatted as the [full
        /// resource name](https://google.aip.dev/122#full-resource-names). To learn about target resources and the
        /// events that they support, see [Supported Google Workspace
        /// events](https://developers.google.com/workspace/events#supported-events). A user can only authorize your app
        /// to create one subscription for a given target resource. If your app tries to create another subscription
        /// with the same user credentials, the request returns an `ALREADY_EXISTS` error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetResource")]
        public virtual string TargetResource { get; set; }

        /// <summary>
        /// Input only. The time-to-live (TTL) or duration for the subscription. If unspecified or set to `0`, uses the
        /// maximum possible duration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ttl")]
        public virtual object Ttl { get; set; }

        /// <summary>Output only. System-assigned unique identifier for the subscription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The last time that the subscription is updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual string UpdateTimeRaw
        {
            get => _updateTimeRaw;
            set
            {
                _updateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _updateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdateTimeDateTimeOffset instead.")]
        public virtual object UpdateTime
        {
            get => _updateTime;
            set
            {
                _updateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _updateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }
    }
}
