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

namespace Google.Apis.Gmail.v1
{
    /// <summary>The Gmail Service.</summary>
    public class GmailService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public GmailService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public GmailService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Users = new UsersResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://gmail.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://gmail.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "gmail";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Gmail API.</summary>
        public class Scope
        {
            /// <summary>Read, compose, send, and permanently delete all your email from Gmail</summary>
            public static string MailGoogleCom = "https://mail.google.com/";

            /// <summary>Manage drafts and send emails when you interact with the add-on</summary>
            public static string GmailAddonsCurrentActionCompose = "https://www.googleapis.com/auth/gmail.addons.current.action.compose";

            /// <summary>View your email messages when you interact with the add-on</summary>
            public static string GmailAddonsCurrentMessageAction = "https://www.googleapis.com/auth/gmail.addons.current.message.action";

            /// <summary>View your email message metadata when the add-on is running</summary>
            public static string GmailAddonsCurrentMessageMetadata = "https://www.googleapis.com/auth/gmail.addons.current.message.metadata";

            /// <summary>View your email messages when the add-on is running</summary>
            public static string GmailAddonsCurrentMessageReadonly = "https://www.googleapis.com/auth/gmail.addons.current.message.readonly";

            /// <summary>Manage drafts and send emails</summary>
            public static string GmailCompose = "https://www.googleapis.com/auth/gmail.compose";

            /// <summary>Add emails into your Gmail mailbox</summary>
            public static string GmailInsert = "https://www.googleapis.com/auth/gmail.insert";

            /// <summary>See and edit your email labels</summary>
            public static string GmailLabels = "https://www.googleapis.com/auth/gmail.labels";

            /// <summary>View your email message metadata such as labels and headers, but not the email body</summary>
            public static string GmailMetadata = "https://www.googleapis.com/auth/gmail.metadata";

            /// <summary>Read, compose, and send emails from your Gmail account</summary>
            public static string GmailModify = "https://www.googleapis.com/auth/gmail.modify";

            /// <summary>View your email messages and settings</summary>
            public static string GmailReadonly = "https://www.googleapis.com/auth/gmail.readonly";

            /// <summary>Send email on your behalf</summary>
            public static string GmailSend = "https://www.googleapis.com/auth/gmail.send";

            /// <summary>See, edit, create, or change your email settings and filters in Gmail</summary>
            public static string GmailSettingsBasic = "https://www.googleapis.com/auth/gmail.settings.basic";

            /// <summary>Manage your sensitive mail settings, including who can manage your mail</summary>
            public static string GmailSettingsSharing = "https://www.googleapis.com/auth/gmail.settings.sharing";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Gmail API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Read, compose, send, and permanently delete all your email from Gmail</summary>
            public const string MailGoogleCom = "https://mail.google.com/";

            /// <summary>Manage drafts and send emails when you interact with the add-on</summary>
            public const string GmailAddonsCurrentActionCompose = "https://www.googleapis.com/auth/gmail.addons.current.action.compose";

            /// <summary>View your email messages when you interact with the add-on</summary>
            public const string GmailAddonsCurrentMessageAction = "https://www.googleapis.com/auth/gmail.addons.current.message.action";

            /// <summary>View your email message metadata when the add-on is running</summary>
            public const string GmailAddonsCurrentMessageMetadata = "https://www.googleapis.com/auth/gmail.addons.current.message.metadata";

            /// <summary>View your email messages when the add-on is running</summary>
            public const string GmailAddonsCurrentMessageReadonly = "https://www.googleapis.com/auth/gmail.addons.current.message.readonly";

            /// <summary>Manage drafts and send emails</summary>
            public const string GmailCompose = "https://www.googleapis.com/auth/gmail.compose";

            /// <summary>Add emails into your Gmail mailbox</summary>
            public const string GmailInsert = "https://www.googleapis.com/auth/gmail.insert";

            /// <summary>See and edit your email labels</summary>
            public const string GmailLabels = "https://www.googleapis.com/auth/gmail.labels";

            /// <summary>View your email message metadata such as labels and headers, but not the email body</summary>
            public const string GmailMetadata = "https://www.googleapis.com/auth/gmail.metadata";

            /// <summary>Read, compose, and send emails from your Gmail account</summary>
            public const string GmailModify = "https://www.googleapis.com/auth/gmail.modify";

            /// <summary>View your email messages and settings</summary>
            public const string GmailReadonly = "https://www.googleapis.com/auth/gmail.readonly";

            /// <summary>Send email on your behalf</summary>
            public const string GmailSend = "https://www.googleapis.com/auth/gmail.send";

            /// <summary>See, edit, create, or change your email settings and filters in Gmail</summary>
            public const string GmailSettingsBasic = "https://www.googleapis.com/auth/gmail.settings.basic";

            /// <summary>Manage your sensitive mail settings, including who can manage your mail</summary>
            public const string GmailSettingsSharing = "https://www.googleapis.com/auth/gmail.settings.sharing";
        }

        /// <summary>Gets the Users resource.</summary>
        public virtual UsersResource Users { get; }
    }

    /// <summary>A base abstract class for Gmail requests.</summary>
    public abstract class GmailBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new GmailBaseServiceRequest instance.</summary>
        protected GmailBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Gmail parameter list.</summary>
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
            Drafts = new DraftsResource(service);
            History = new HistoryResource(service);
            Labels = new LabelsResource(service);
            Messages = new MessagesResource(service);
            Settings = new SettingsResource(service);
            Threads = new ThreadsResource(service);
        }

        /// <summary>Gets the Drafts resource.</summary>
        public virtual DraftsResource Drafts { get; }

        /// <summary>The "drafts" collection of methods.</summary>
        public class DraftsResource
        {
            private const string Resource = "drafts";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public DraftsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a new draft with the `DRAFT` label.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="userId">
            /// The user's email address. The special value `me` can be used to indicate the authenticated user.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Gmail.v1.Data.Draft body, string userId)
            {
                return new CreateRequest(this.service, body, userId);
            }

            /// <summary>Creates a new draft with the `DRAFT` label.</summary>
            public class CreateRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.Draft>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Gmail.v1.Data.Draft body, string userId) : base(service)
                {
                    UserId = userId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Gmail.v1.Data.Draft Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "gmail/v1/users/{userId}/drafts";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = "me",
                        Pattern = null,
                    });
                }
            }

            /// <summary>Creates a new draft with the `DRAFT` label.</summary>
            /// <remarks>
            /// Considerations regarding <paramref name="stream"/>:
            /// <list type="bullet">
            /// <item>
            /// <description>
            /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before
            /// reading commences. If <paramref name="stream"/> is not seekable, then it will be read from its current
            /// position
            /// </description>
            /// </item>
            /// <item>
            /// <description>
            /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is completed
            /// </description>
            /// </item>
            /// <item><description>Caller is responsible for closing the <paramref name="stream"/></description></item>
            /// </list>
            /// </remarks>
            /// <param name="body">The body of the request.</param>
            /// <param name="userId">
            /// The user's email address. The special value `me` can be used to indicate the authenticated user.
            /// </param>
            /// <param name="stream">The stream to upload. See remarks for further information.</param>
            /// <param name="contentType">The content type of the stream to upload.</param>
            public virtual CreateMediaUpload Create(Google.Apis.Gmail.v1.Data.Draft body, string userId, System.IO.Stream stream, string contentType)
            {
                return new CreateMediaUpload(service, body, userId, stream, contentType);
            }

            /// <summary>Create media upload which supports resumable upload.</summary>
            public class CreateMediaUpload : Google.Apis.Upload.ResumableUpload<Google.Apis.Gmail.v1.Data.Draft, Google.Apis.Gmail.v1.Data.Draft>
            {
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
                /// API key. Your API key identifies your project and provides you with API access, quota, and reports.
                /// Required unless you provide an OAuth 2.0 token.
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
                /// Available to use for quota purposes for server-side applications. Can be any arbitrary string
                /// assigned to a user, but should not exceed 40 characters.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string QuotaUser { get; set; }

                /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
                [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UploadType { get; set; }

                /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
                [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UploadProtocol { get; set; }

                /// <summary>
                /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>Constructs a new Create media upload instance.</summary>
                /// <remarks>
                /// Considerations regarding <paramref name="stream"/>:
                /// <list type="bullet">
                /// <item>
                /// <description>
                /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before
                /// reading commences. If <paramref name="stream"/> is not seekable, then it will be read from its
                /// current position
                /// </description>
                /// </item>
                /// <item>
                /// <description>
                /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is
                /// completed
                /// </description>
                /// </item>
                /// <item>
                /// <description>Caller is responsible for closing the <paramref name="stream"/></description>
                /// </item>
                /// </list>
                /// </remarks>
                public CreateMediaUpload(Google.Apis.Services.IClientService service, Google.Apis.Gmail.v1.Data.Draft body, string userId, System.IO.Stream stream, string contentType)
                    : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "gmail/v1/users/{userId}/drafts"), "POST", stream, contentType)
                {
                    UserId = userId;
                    Body = body;
                }
            }

            /// <summary>Immediately and permanently deletes the specified draft. Does not simply trash it.</summary>
            /// <param name="userId">
            /// The user's email address. The special value `me` can be used to indicate the authenticated user.
            /// </param>
            /// <param name="id">The ID of the draft to delete.</param>
            public virtual DeleteRequest Delete(string userId, string id)
            {
                return new DeleteRequest(this.service, userId, id);
            }

            /// <summary>Immediately and permanently deletes the specified draft. Does not simply trash it.</summary>
            public class DeleteRequest : GmailBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string userId, string id) : base(service)
                {
                    UserId = userId;
                    Id = id;
                    InitParameters();
                }

                /// <summary>
                /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>The ID of the draft to delete.</summary>
                [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Id { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "gmail/v1/users/{userId}/drafts/{id}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = "me",
                        Pattern = null,
                    });
                    RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Gets the specified draft.</summary>
            /// <param name="userId">
            /// The user's email address. The special value `me` can be used to indicate the authenticated user.
            /// </param>
            /// <param name="id">The ID of the draft to retrieve.</param>
            public virtual GetRequest Get(string userId, string id)
            {
                return new GetRequest(this.service, userId, id);
            }

            /// <summary>Gets the specified draft.</summary>
            public class GetRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.Draft>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string userId, string id) : base(service)
                {
                    UserId = userId;
                    Id = id;
                    InitParameters();
                }

                /// <summary>
                /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>The ID of the draft to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Id { get; private set; }

                /// <summary>The format to return the draft in.</summary>
                [Google.Apis.Util.RequestParameterAttribute("format", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<FormatEnum> Format { get; set; }

                /// <summary>The format to return the draft in.</summary>
                public enum FormatEnum
                {
                    /// <summary>
                    /// Returns only email message ID and labels; does not return the email headers, body, or payload.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("minimal")]
                    Minimal = 0,

                    /// <summary>
                    /// Returns the full email message data with body content parsed in the `payload` field; the `raw`
                    /// field is not used. Format cannot be used when accessing the api using the gmail.metadata scope.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("full")]
                    Full = 1,

                    /// <summary>
                    /// Returns the full email message data with body content in the `raw` field as a base64url encoded
                    /// string; the `payload` field is not used. Format cannot be used when accessing the api using the
                    /// gmail.metadata scope.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("raw")]
                    Raw = 2,

                    /// <summary>Returns only email message ID, labels, and email headers.</summary>
                    [Google.Apis.Util.StringValueAttribute("metadata")]
                    Metadata = 3,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "gmail/v1/users/{userId}/drafts/{id}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = "me",
                        Pattern = null,
                    });
                    RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("format", new Google.Apis.Discovery.Parameter
                    {
                        Name = "format",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = "full",
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists the drafts in the user's mailbox.</summary>
            /// <param name="userId">
            /// The user's email address. The special value `me` can be used to indicate the authenticated user.
            /// </param>
            public virtual ListRequest List(string userId)
            {
                return new ListRequest(this.service, userId);
            }

            /// <summary>Lists the drafts in the user's mailbox.</summary>
            public class ListRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.ListDraftsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string userId) : base(service)
                {
                    UserId = userId;
                    InitParameters();
                }

                /// <summary>
                /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>Include drafts from `SPAM` and `TRASH` in the results.</summary>
                [Google.Apis.Util.RequestParameterAttribute("includeSpamTrash", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> IncludeSpamTrash { get; set; }

                /// <summary>
                /// Maximum number of drafts to return. This field defaults to 100. The maximum allowed value for this
                /// field is 500.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> MaxResults { get; set; }

                /// <summary>Page token to retrieve a specific page of results in the list.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// Only return draft messages matching the specified query. Supports the same query format as the Gmail
                /// search box. For example, `"from:someuser@example.com rfc822msgid: is:unread"`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("q", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Q { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "gmail/v1/users/{userId}/drafts";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = "me",
                        Pattern = null,
                    });
                    RequestParameters.Add("includeSpamTrash", new Google.Apis.Discovery.Parameter
                    {
                        Name = "includeSpamTrash",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = "false",
                        Pattern = null,
                    });
                    RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                    {
                        Name = "maxResults",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = "100",
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
                    RequestParameters.Add("q", new Google.Apis.Discovery.Parameter
                    {
                        Name = "q",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Sends the specified, existing draft to the recipients in the `To`, `Cc`, and `Bcc` headers.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="userId">
            /// The user's email address. The special value `me` can be used to indicate the authenticated user.
            /// </param>
            public virtual SendRequest Send(Google.Apis.Gmail.v1.Data.Draft body, string userId)
            {
                return new SendRequest(this.service, body, userId);
            }

            /// <summary>
            /// Sends the specified, existing draft to the recipients in the `To`, `Cc`, and `Bcc` headers.
            /// </summary>
            public class SendRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.Message>
            {
                /// <summary>Constructs a new Send request.</summary>
                public SendRequest(Google.Apis.Services.IClientService service, Google.Apis.Gmail.v1.Data.Draft body, string userId) : base(service)
                {
                    UserId = userId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Gmail.v1.Data.Draft Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "send";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "gmail/v1/users/{userId}/drafts/send";

                /// <summary>Initializes Send parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = "me",
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Sends the specified, existing draft to the recipients in the `To`, `Cc`, and `Bcc` headers.
            /// </summary>
            /// <remarks>
            /// Considerations regarding <paramref name="stream"/>:
            /// <list type="bullet">
            /// <item>
            /// <description>
            /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before
            /// reading commences. If <paramref name="stream"/> is not seekable, then it will be read from its current
            /// position
            /// </description>
            /// </item>
            /// <item>
            /// <description>
            /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is completed
            /// </description>
            /// </item>
            /// <item><description>Caller is responsible for closing the <paramref name="stream"/></description></item>
            /// </list>
            /// </remarks>
            /// <param name="body">The body of the request.</param>
            /// <param name="userId">
            /// The user's email address. The special value `me` can be used to indicate the authenticated user.
            /// </param>
            /// <param name="stream">The stream to upload. See remarks for further information.</param>
            /// <param name="contentType">The content type of the stream to upload.</param>
            public virtual SendMediaUpload Send(Google.Apis.Gmail.v1.Data.Draft body, string userId, System.IO.Stream stream, string contentType)
            {
                return new SendMediaUpload(service, body, userId, stream, contentType);
            }

            /// <summary>Send media upload which supports resumable upload.</summary>
            public class SendMediaUpload : Google.Apis.Upload.ResumableUpload<Google.Apis.Gmail.v1.Data.Draft, Google.Apis.Gmail.v1.Data.Message>
            {
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
                /// API key. Your API key identifies your project and provides you with API access, quota, and reports.
                /// Required unless you provide an OAuth 2.0 token.
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
                /// Available to use for quota purposes for server-side applications. Can be any arbitrary string
                /// assigned to a user, but should not exceed 40 characters.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string QuotaUser { get; set; }

                /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
                [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UploadType { get; set; }

                /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
                [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UploadProtocol { get; set; }

                /// <summary>
                /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>Constructs a new Send media upload instance.</summary>
                /// <remarks>
                /// Considerations regarding <paramref name="stream"/>:
                /// <list type="bullet">
                /// <item>
                /// <description>
                /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before
                /// reading commences. If <paramref name="stream"/> is not seekable, then it will be read from its
                /// current position
                /// </description>
                /// </item>
                /// <item>
                /// <description>
                /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is
                /// completed
                /// </description>
                /// </item>
                /// <item>
                /// <description>Caller is responsible for closing the <paramref name="stream"/></description>
                /// </item>
                /// </list>
                /// </remarks>
                public SendMediaUpload(Google.Apis.Services.IClientService service, Google.Apis.Gmail.v1.Data.Draft body, string userId, System.IO.Stream stream, string contentType)
                    : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "gmail/v1/users/{userId}/drafts/send"), "POST", stream, contentType)
                {
                    UserId = userId;
                    Body = body;
                }
            }

            /// <summary>Replaces a draft's content.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="userId">
            /// The user's email address. The special value `me` can be used to indicate the authenticated user.
            /// </param>
            /// <param name="id">The ID of the draft to update.</param>
            public virtual UpdateRequest Update(Google.Apis.Gmail.v1.Data.Draft body, string userId, string id)
            {
                return new UpdateRequest(this.service, body, userId, id);
            }

            /// <summary>Replaces a draft's content.</summary>
            public class UpdateRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.Draft>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Gmail.v1.Data.Draft body, string userId, string id) : base(service)
                {
                    UserId = userId;
                    Id = id;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>The ID of the draft to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Id { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Gmail.v1.Data.Draft Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "gmail/v1/users/{userId}/drafts/{id}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = "me",
                        Pattern = null,
                    });
                    RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Replaces a draft's content.</summary>
            /// <remarks>
            /// Considerations regarding <paramref name="stream"/>:
            /// <list type="bullet">
            /// <item>
            /// <description>
            /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before
            /// reading commences. If <paramref name="stream"/> is not seekable, then it will be read from its current
            /// position
            /// </description>
            /// </item>
            /// <item>
            /// <description>
            /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is completed
            /// </description>
            /// </item>
            /// <item><description>Caller is responsible for closing the <paramref name="stream"/></description></item>
            /// </list>
            /// </remarks>
            /// <param name="body">The body of the request.</param>
            /// <param name="userId">
            /// The user's email address. The special value `me` can be used to indicate the authenticated user.
            /// </param>
            /// <param name="id">The ID of the draft to update.</param>
            /// <param name="stream">The stream to upload. See remarks for further information.</param>
            /// <param name="contentType">The content type of the stream to upload.</param>
            public virtual UpdateMediaUpload Update(Google.Apis.Gmail.v1.Data.Draft body, string userId, string id, System.IO.Stream stream, string contentType)
            {
                return new UpdateMediaUpload(service, body, userId, id, stream, contentType);
            }

            /// <summary>Update media upload which supports resumable upload.</summary>
            public class UpdateMediaUpload : Google.Apis.Upload.ResumableUpload<Google.Apis.Gmail.v1.Data.Draft, Google.Apis.Gmail.v1.Data.Draft>
            {
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
                /// API key. Your API key identifies your project and provides you with API access, quota, and reports.
                /// Required unless you provide an OAuth 2.0 token.
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
                /// Available to use for quota purposes for server-side applications. Can be any arbitrary string
                /// assigned to a user, but should not exceed 40 characters.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string QuotaUser { get; set; }

                /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
                [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UploadType { get; set; }

                /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
                [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UploadProtocol { get; set; }

                /// <summary>
                /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>The ID of the draft to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Id { get; private set; }

                /// <summary>Constructs a new Update media upload instance.</summary>
                /// <remarks>
                /// Considerations regarding <paramref name="stream"/>:
                /// <list type="bullet">
                /// <item>
                /// <description>
                /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before
                /// reading commences. If <paramref name="stream"/> is not seekable, then it will be read from its
                /// current position
                /// </description>
                /// </item>
                /// <item>
                /// <description>
                /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is
                /// completed
                /// </description>
                /// </item>
                /// <item>
                /// <description>Caller is responsible for closing the <paramref name="stream"/></description>
                /// </item>
                /// </list>
                /// </remarks>
                public UpdateMediaUpload(Google.Apis.Services.IClientService service, Google.Apis.Gmail.v1.Data.Draft body, string userId, string id, System.IO.Stream stream, string contentType)
                    : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "gmail/v1/users/{userId}/drafts/{id}"), "PUT", stream, contentType)
                {
                    UserId = userId;
                    Id = id;
                    Body = body;
                }
            }
        }

        /// <summary>Gets the History resource.</summary>
        public virtual HistoryResource History { get; }

        /// <summary>The "history" collection of methods.</summary>
        public class HistoryResource
        {
            private const string Resource = "history";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public HistoryResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Lists the history of all changes to the given mailbox. History results are returned in chronological
            /// order (increasing `historyId`).
            /// </summary>
            /// <param name="userId">
            /// The user's email address. The special value `me` can be used to indicate the authenticated user.
            /// </param>
            public virtual ListRequest List(string userId)
            {
                return new ListRequest(this.service, userId);
            }

            /// <summary>
            /// Lists the history of all changes to the given mailbox. History results are returned in chronological
            /// order (increasing `historyId`).
            /// </summary>
            public class ListRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.ListHistoryResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string userId) : base(service)
                {
                    UserId = userId;
                    InitParameters();
                }

                /// <summary>
                /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>History types to be returned by the function</summary>
                /// <remarks>
                /// Use this property to set a single value for the parameter, or <see cref="HistoryTypesList"/> to set
                /// multiple values. Do not set both properties.
                /// </remarks>
                [Google.Apis.Util.RequestParameterAttribute("historyTypes", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<HistoryTypesEnum> HistoryTypes { get; set; }

                /// <summary>History types to be returned by the function</summary>
                /// <remarks>
                /// Use this property to set one or more values for the parameter. Do not set both this property and
                /// <see cref="HistoryTypes"/>.
                /// </remarks>
                [Google.Apis.Util.RequestParameterAttribute("historyTypes", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<HistoryTypesEnum> HistoryTypesList { get; set; }

                /// <summary>History types to be returned by the function</summary>
                public enum HistoryTypesEnum
                {
                    /// <summary></summary>
                    [Google.Apis.Util.StringValueAttribute("messageAdded")]
                    MessageAdded = 0,

                    /// <summary></summary>
                    [Google.Apis.Util.StringValueAttribute("messageDeleted")]
                    MessageDeleted = 1,

                    /// <summary></summary>
                    [Google.Apis.Util.StringValueAttribute("labelAdded")]
                    LabelAdded = 2,

                    /// <summary></summary>
                    [Google.Apis.Util.StringValueAttribute("labelRemoved")]
                    LabelRemoved = 3,
                }

                /// <summary>Only return messages with a label matching the ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("labelId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string LabelId { get; set; }

                /// <summary>
                /// Maximum number of history records to return. This field defaults to 100. The maximum allowed value
                /// for this field is 500.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> MaxResults { get; set; }

                /// <summary>Page token to retrieve a specific page of results in the list.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// Required. Returns history records after the specified `startHistoryId`. The supplied
                /// `startHistoryId` should be obtained from the `historyId` of a message, thread, or previous `list`
                /// response. History IDs increase chronologically but are not contiguous with random gaps in between
                /// valid IDs. Supplying an invalid or out of date `startHistoryId` typically returns an `HTTP 404`
                /// error code. A `historyId` is typically valid for at least a week, but in some rare circumstances may
                /// be valid for only a few hours. If you receive an `HTTP 404` error response, your application should
                /// perform a full sync. If you receive no `nextPageToken` in the response, there are no updates to
                /// retrieve and you can store the returned `historyId` for a future request.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("startHistoryId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ulong> StartHistoryId { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "gmail/v1/users/{userId}/history";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = "me",
                        Pattern = null,
                    });
                    RequestParameters.Add("historyTypes", new Google.Apis.Discovery.Parameter
                    {
                        Name = "historyTypes",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("labelId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "labelId",
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
                        DefaultValue = "100",
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
                    RequestParameters.Add("startHistoryId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "startHistoryId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Labels resource.</summary>
        public virtual LabelsResource Labels { get; }

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

            /// <summary>Creates a new label.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="userId">
            /// The user's email address. The special value `me` can be used to indicate the authenticated user.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Gmail.v1.Data.Label body, string userId)
            {
                return new CreateRequest(this.service, body, userId);
            }

            /// <summary>Creates a new label.</summary>
            public class CreateRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.Label>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Gmail.v1.Data.Label body, string userId) : base(service)
                {
                    UserId = userId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Gmail.v1.Data.Label Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "gmail/v1/users/{userId}/labels";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = "me",
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Immediately and permanently deletes the specified label and removes it from any messages and threads
            /// that it is applied to.
            /// </summary>
            /// <param name="userId">
            /// The user's email address. The special value `me` can be used to indicate the authenticated user.
            /// </param>
            /// <param name="id">The ID of the label to delete.</param>
            public virtual DeleteRequest Delete(string userId, string id)
            {
                return new DeleteRequest(this.service, userId, id);
            }

            /// <summary>
            /// Immediately and permanently deletes the specified label and removes it from any messages and threads
            /// that it is applied to.
            /// </summary>
            public class DeleteRequest : GmailBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string userId, string id) : base(service)
                {
                    UserId = userId;
                    Id = id;
                    InitParameters();
                }

                /// <summary>
                /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>The ID of the label to delete.</summary>
                [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Id { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "gmail/v1/users/{userId}/labels/{id}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = "me",
                        Pattern = null,
                    });
                    RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Gets the specified label.</summary>
            /// <param name="userId">
            /// The user's email address. The special value `me` can be used to indicate the authenticated user.
            /// </param>
            /// <param name="id">The ID of the label to retrieve.</param>
            public virtual GetRequest Get(string userId, string id)
            {
                return new GetRequest(this.service, userId, id);
            }

            /// <summary>Gets the specified label.</summary>
            public class GetRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.Label>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string userId, string id) : base(service)
                {
                    UserId = userId;
                    Id = id;
                    InitParameters();
                }

                /// <summary>
                /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>The ID of the label to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Id { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "gmail/v1/users/{userId}/labels/{id}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = "me",
                        Pattern = null,
                    });
                    RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists all labels in the user's mailbox.</summary>
            /// <param name="userId">
            /// The user's email address. The special value `me` can be used to indicate the authenticated user.
            /// </param>
            public virtual ListRequest List(string userId)
            {
                return new ListRequest(this.service, userId);
            }

            /// <summary>Lists all labels in the user's mailbox.</summary>
            public class ListRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.ListLabelsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string userId) : base(service)
                {
                    UserId = userId;
                    InitParameters();
                }

                /// <summary>
                /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "gmail/v1/users/{userId}/labels";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = "me",
                        Pattern = null,
                    });
                }
            }

            /// <summary>Patch the specified label.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="userId">
            /// The user's email address. The special value `me` can be used to indicate the authenticated user.
            /// </param>
            /// <param name="id">The ID of the label to update.</param>
            public virtual PatchRequest Patch(Google.Apis.Gmail.v1.Data.Label body, string userId, string id)
            {
                return new PatchRequest(this.service, body, userId, id);
            }

            /// <summary>Patch the specified label.</summary>
            public class PatchRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.Label>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Gmail.v1.Data.Label body, string userId, string id) : base(service)
                {
                    UserId = userId;
                    Id = id;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>The ID of the label to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Id { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Gmail.v1.Data.Label Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "gmail/v1/users/{userId}/labels/{id}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = "me",
                        Pattern = null,
                    });
                    RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates the specified label.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="userId">
            /// The user's email address. The special value `me` can be used to indicate the authenticated user.
            /// </param>
            /// <param name="id">The ID of the label to update.</param>
            public virtual UpdateRequest Update(Google.Apis.Gmail.v1.Data.Label body, string userId, string id)
            {
                return new UpdateRequest(this.service, body, userId, id);
            }

            /// <summary>Updates the specified label.</summary>
            public class UpdateRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.Label>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Gmail.v1.Data.Label body, string userId, string id) : base(service)
                {
                    UserId = userId;
                    Id = id;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>The ID of the label to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Id { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Gmail.v1.Data.Label Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "gmail/v1/users/{userId}/labels/{id}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = "me",
                        Pattern = null,
                    });
                    RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
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
                Attachments = new AttachmentsResource(service);
            }

            /// <summary>Gets the Attachments resource.</summary>
            public virtual AttachmentsResource Attachments { get; }

            /// <summary>The "attachments" collection of methods.</summary>
            public class AttachmentsResource
            {
                private const string Resource = "attachments";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AttachmentsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Gets the specified message attachment.</summary>
                /// <param name="userId">
                /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                /// </param>
                /// <param name="messageId">The ID of the message containing the attachment.</param>
                /// <param name="id">The ID of the attachment.</param>
                public virtual GetRequest Get(string userId, string messageId, string id)
                {
                    return new GetRequest(this.service, userId, messageId, id);
                }

                /// <summary>Gets the specified message attachment.</summary>
                public class GetRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.MessagePartBody>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string userId, string messageId, string id) : base(service)
                    {
                        UserId = userId;
                        MessageId = messageId;
                        Id = id;
                        InitParameters();
                    }

                    /// <summary>
                    /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string UserId { get; private set; }

                    /// <summary>The ID of the message containing the attachment.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("messageId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string MessageId { get; private set; }

                    /// <summary>The ID of the attachment.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Id { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "gmail/v1/users/{userId}/messages/{messageId}/attachments/{id}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "userId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = "me",
                            Pattern = null,
                        });
                        RequestParameters.Add("messageId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "messageId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                        {
                            Name = "id",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>
            /// Deletes many messages by message ID. Provides no guarantees that messages were not already deleted or
            /// even existed at all.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="userId">
            /// The user's email address. The special value `me` can be used to indicate the authenticated user.
            /// </param>
            public virtual BatchDeleteRequest BatchDelete(Google.Apis.Gmail.v1.Data.BatchDeleteMessagesRequest body, string userId)
            {
                return new BatchDeleteRequest(this.service, body, userId);
            }

            /// <summary>
            /// Deletes many messages by message ID. Provides no guarantees that messages were not already deleted or
            /// even existed at all.
            /// </summary>
            public class BatchDeleteRequest : GmailBaseServiceRequest<string>
            {
                /// <summary>Constructs a new BatchDelete request.</summary>
                public BatchDeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.Gmail.v1.Data.BatchDeleteMessagesRequest body, string userId) : base(service)
                {
                    UserId = userId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Gmail.v1.Data.BatchDeleteMessagesRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchDelete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "gmail/v1/users/{userId}/messages/batchDelete";

                /// <summary>Initializes BatchDelete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = "me",
                        Pattern = null,
                    });
                }
            }

            /// <summary>Modifies the labels on the specified messages.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="userId">
            /// The user's email address. The special value `me` can be used to indicate the authenticated user.
            /// </param>
            public virtual BatchModifyRequest BatchModify(Google.Apis.Gmail.v1.Data.BatchModifyMessagesRequest body, string userId)
            {
                return new BatchModifyRequest(this.service, body, userId);
            }

            /// <summary>Modifies the labels on the specified messages.</summary>
            public class BatchModifyRequest : GmailBaseServiceRequest<string>
            {
                /// <summary>Constructs a new BatchModify request.</summary>
                public BatchModifyRequest(Google.Apis.Services.IClientService service, Google.Apis.Gmail.v1.Data.BatchModifyMessagesRequest body, string userId) : base(service)
                {
                    UserId = userId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Gmail.v1.Data.BatchModifyMessagesRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchModify";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "gmail/v1/users/{userId}/messages/batchModify";

                /// <summary>Initializes BatchModify parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = "me",
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Immediately and permanently deletes the specified message. This operation cannot be undone. Prefer
            /// `messages.trash` instead.
            /// </summary>
            /// <param name="userId">
            /// The user's email address. The special value `me` can be used to indicate the authenticated user.
            /// </param>
            /// <param name="id">The ID of the message to delete.</param>
            public virtual DeleteRequest Delete(string userId, string id)
            {
                return new DeleteRequest(this.service, userId, id);
            }

            /// <summary>
            /// Immediately and permanently deletes the specified message. This operation cannot be undone. Prefer
            /// `messages.trash` instead.
            /// </summary>
            public class DeleteRequest : GmailBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string userId, string id) : base(service)
                {
                    UserId = userId;
                    Id = id;
                    InitParameters();
                }

                /// <summary>
                /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>The ID of the message to delete.</summary>
                [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Id { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "gmail/v1/users/{userId}/messages/{id}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = "me",
                        Pattern = null,
                    });
                    RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Gets the specified message.</summary>
            /// <param name="userId">
            /// The user's email address. The special value `me` can be used to indicate the authenticated user.
            /// </param>
            /// <param name="id">
            /// The ID of the message to retrieve. This ID is usually retrieved using `messages.list`. The ID is also
            /// contained in the result when a message is inserted (`messages.insert`) or imported (`messages.import`).
            /// </param>
            public virtual GetRequest Get(string userId, string id)
            {
                return new GetRequest(this.service, userId, id);
            }

            /// <summary>Gets the specified message.</summary>
            public class GetRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.Message>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string userId, string id) : base(service)
                {
                    UserId = userId;
                    Id = id;
                    InitParameters();
                }

                /// <summary>
                /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>
                /// The ID of the message to retrieve. This ID is usually retrieved using `messages.list`. The ID is
                /// also contained in the result when a message is inserted (`messages.insert`) or imported
                /// (`messages.import`).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Id { get; private set; }

                /// <summary>The format to return the message in.</summary>
                [Google.Apis.Util.RequestParameterAttribute("format", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<FormatEnum> Format { get; set; }

                /// <summary>The format to return the message in.</summary>
                public enum FormatEnum
                {
                    /// <summary>
                    /// Returns only email message ID and labels; does not return the email headers, body, or payload.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("minimal")]
                    Minimal = 0,

                    /// <summary>
                    /// Returns the full email message data with body content parsed in the `payload` field; the `raw`
                    /// field is not used. Format cannot be used when accessing the api using the gmail.metadata scope.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("full")]
                    Full = 1,

                    /// <summary>
                    /// Returns the full email message data with body content in the `raw` field as a base64url encoded
                    /// string; the `payload` field is not used. Format cannot be used when accessing the api using the
                    /// gmail.metadata scope.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("raw")]
                    Raw = 2,

                    /// <summary>Returns only email message ID, labels, and email headers.</summary>
                    [Google.Apis.Util.StringValueAttribute("metadata")]
                    Metadata = 3,
                }

                /// <summary>When given and format is `METADATA`, only include headers specified.</summary>
                [Google.Apis.Util.RequestParameterAttribute("metadataHeaders", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> MetadataHeaders { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "gmail/v1/users/{userId}/messages/{id}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = "me",
                        Pattern = null,
                    });
                    RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("format", new Google.Apis.Discovery.Parameter
                    {
                        Name = "format",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = "full",
                        Pattern = null,
                    });
                    RequestParameters.Add("metadataHeaders", new Google.Apis.Discovery.Parameter
                    {
                        Name = "metadataHeaders",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Imports a message into only this user's mailbox, with standard email delivery scanning and
            /// classification similar to receiving via SMTP. This method doesn't perform SPF checks, so it might not
            /// work for some spam messages, such as those attempting to perform domain spoofing. This method does not
            /// send a message.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="userId">
            /// The user's email address. The special value `me` can be used to indicate the authenticated user.
            /// </param>
            public virtual ImportRequest Import(Google.Apis.Gmail.v1.Data.Message body, string userId)
            {
                return new ImportRequest(this.service, body, userId);
            }

            /// <summary>
            /// Imports a message into only this user's mailbox, with standard email delivery scanning and
            /// classification similar to receiving via SMTP. This method doesn't perform SPF checks, so it might not
            /// work for some spam messages, such as those attempting to perform domain spoofing. This method does not
            /// send a message.
            /// </summary>
            public class ImportRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.Message>
            {
                /// <summary>Constructs a new Import request.</summary>
                public ImportRequest(Google.Apis.Services.IClientService service, Google.Apis.Gmail.v1.Data.Message body, string userId) : base(service)
                {
                    UserId = userId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>
                /// Mark the email as permanently deleted (not TRASH) and only visible in Google Vault to a Vault
                /// administrator. Only used for Google Workspace accounts.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("deleted", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> Deleted { get; set; }

                /// <summary>Source for Gmail's internal date of the message.</summary>
                [Google.Apis.Util.RequestParameterAttribute("internalDateSource", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<InternalDateSourceEnum> InternalDateSource { get; set; }

                /// <summary>Source for Gmail's internal date of the message.</summary>
                public enum InternalDateSourceEnum
                {
                    /// <summary>Internal message date set to current time when received by Gmail.</summary>
                    [Google.Apis.Util.StringValueAttribute("receivedTime")]
                    ReceivedTime = 0,

                    /// <summary>Internal message time based on 'Date' header in email, when valid.</summary>
                    [Google.Apis.Util.StringValueAttribute("dateHeader")]
                    DateHeader = 1,
                }

                /// <summary>
                /// Ignore the Gmail spam classifier decision and never mark this email as SPAM in the mailbox.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("neverMarkSpam", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> NeverMarkSpam { get; set; }

                /// <summary>
                /// Process calendar invites in the email and add any extracted meetings to the Google Calendar for this
                /// user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("processForCalendar", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ProcessForCalendar { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Gmail.v1.Data.Message Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "import";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "gmail/v1/users/{userId}/messages/import";

                /// <summary>Initializes Import parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = "me",
                        Pattern = null,
                    });
                    RequestParameters.Add("deleted", new Google.Apis.Discovery.Parameter
                    {
                        Name = "deleted",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = "false",
                        Pattern = null,
                    });
                    RequestParameters.Add("internalDateSource", new Google.Apis.Discovery.Parameter
                    {
                        Name = "internalDateSource",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = "dateHeader",
                        Pattern = null,
                    });
                    RequestParameters.Add("neverMarkSpam", new Google.Apis.Discovery.Parameter
                    {
                        Name = "neverMarkSpam",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = "false",
                        Pattern = null,
                    });
                    RequestParameters.Add("processForCalendar", new Google.Apis.Discovery.Parameter
                    {
                        Name = "processForCalendar",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = "false",
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Imports a message into only this user's mailbox, with standard email delivery scanning and
            /// classification similar to receiving via SMTP. This method doesn't perform SPF checks, so it might not
            /// work for some spam messages, such as those attempting to perform domain spoofing. This method does not
            /// send a message.
            /// </summary>
            /// <remarks>
            /// Considerations regarding <paramref name="stream"/>:
            /// <list type="bullet">
            /// <item>
            /// <description>
            /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before
            /// reading commences. If <paramref name="stream"/> is not seekable, then it will be read from its current
            /// position
            /// </description>
            /// </item>
            /// <item>
            /// <description>
            /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is completed
            /// </description>
            /// </item>
            /// <item><description>Caller is responsible for closing the <paramref name="stream"/></description></item>
            /// </list>
            /// </remarks>
            /// <param name="body">The body of the request.</param>
            /// <param name="userId">
            /// The user's email address. The special value `me` can be used to indicate the authenticated user.
            /// </param>
            /// <param name="stream">The stream to upload. See remarks for further information.</param>
            /// <param name="contentType">The content type of the stream to upload.</param>
            public virtual ImportMediaUpload Import(Google.Apis.Gmail.v1.Data.Message body, string userId, System.IO.Stream stream, string contentType)
            {
                return new ImportMediaUpload(service, body, userId, stream, contentType);
            }

            /// <summary>Import media upload which supports resumable upload.</summary>
            public class ImportMediaUpload : Google.Apis.Upload.ResumableUpload<Google.Apis.Gmail.v1.Data.Message, Google.Apis.Gmail.v1.Data.Message>
            {
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
                /// API key. Your API key identifies your project and provides you with API access, quota, and reports.
                /// Required unless you provide an OAuth 2.0 token.
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
                /// Available to use for quota purposes for server-side applications. Can be any arbitrary string
                /// assigned to a user, but should not exceed 40 characters.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string QuotaUser { get; set; }

                /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
                [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UploadType { get; set; }

                /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
                [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UploadProtocol { get; set; }

                /// <summary>
                /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>
                /// Mark the email as permanently deleted (not TRASH) and only visible in Google Vault to a Vault
                /// administrator. Only used for Google Workspace accounts.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("deleted", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> Deleted { get; set; }

                /// <summary>Source for Gmail's internal date of the message.</summary>
                [Google.Apis.Util.RequestParameterAttribute("internalDateSource", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<InternalDateSourceEnum> InternalDateSource { get; set; }

                /// <summary>Source for Gmail's internal date of the message.</summary>
                public enum InternalDateSourceEnum
                {
                    /// <summary>Internal message date set to current time when received by Gmail.</summary>
                    [Google.Apis.Util.StringValueAttribute("receivedTime")]
                    ReceivedTime = 0,

                    /// <summary>Internal message time based on 'Date' header in email, when valid.</summary>
                    [Google.Apis.Util.StringValueAttribute("dateHeader")]
                    DateHeader = 1,
                }

                /// <summary>
                /// Ignore the Gmail spam classifier decision and never mark this email as SPAM in the mailbox.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("neverMarkSpam", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> NeverMarkSpam { get; set; }

                /// <summary>
                /// Process calendar invites in the email and add any extracted meetings to the Google Calendar for this
                /// user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("processForCalendar", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ProcessForCalendar { get; set; }

                /// <summary>Constructs a new Import media upload instance.</summary>
                /// <remarks>
                /// Considerations regarding <paramref name="stream"/>:
                /// <list type="bullet">
                /// <item>
                /// <description>
                /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before
                /// reading commences. If <paramref name="stream"/> is not seekable, then it will be read from its
                /// current position
                /// </description>
                /// </item>
                /// <item>
                /// <description>
                /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is
                /// completed
                /// </description>
                /// </item>
                /// <item>
                /// <description>Caller is responsible for closing the <paramref name="stream"/></description>
                /// </item>
                /// </list>
                /// </remarks>
                public ImportMediaUpload(Google.Apis.Services.IClientService service, Google.Apis.Gmail.v1.Data.Message body, string userId, System.IO.Stream stream, string contentType)
                    : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "gmail/v1/users/{userId}/messages/import"), "POST", stream, contentType)
                {
                    UserId = userId;
                    Body = body;
                }
            }

            /// <summary>
            /// Directly inserts a message into only this user's mailbox similar to `IMAP APPEND`, bypassing most
            /// scanning and classification. Does not send a message.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="userId">
            /// The user's email address. The special value `me` can be used to indicate the authenticated user.
            /// </param>
            public virtual InsertRequest Insert(Google.Apis.Gmail.v1.Data.Message body, string userId)
            {
                return new InsertRequest(this.service, body, userId);
            }

            /// <summary>
            /// Directly inserts a message into only this user's mailbox similar to `IMAP APPEND`, bypassing most
            /// scanning and classification. Does not send a message.
            /// </summary>
            public class InsertRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.Message>
            {
                /// <summary>Constructs a new Insert request.</summary>
                public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Gmail.v1.Data.Message body, string userId) : base(service)
                {
                    UserId = userId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>
                /// Mark the email as permanently deleted (not TRASH) and only visible in Google Vault to a Vault
                /// administrator. Only used for Google Workspace accounts.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("deleted", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> Deleted { get; set; }

                /// <summary>Source for Gmail's internal date of the message.</summary>
                [Google.Apis.Util.RequestParameterAttribute("internalDateSource", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<InternalDateSourceEnum> InternalDateSource { get; set; }

                /// <summary>Source for Gmail's internal date of the message.</summary>
                public enum InternalDateSourceEnum
                {
                    /// <summary>Internal message date set to current time when received by Gmail.</summary>
                    [Google.Apis.Util.StringValueAttribute("receivedTime")]
                    ReceivedTime = 0,

                    /// <summary>Internal message time based on 'Date' header in email, when valid.</summary>
                    [Google.Apis.Util.StringValueAttribute("dateHeader")]
                    DateHeader = 1,
                }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Gmail.v1.Data.Message Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "insert";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "gmail/v1/users/{userId}/messages";

                /// <summary>Initializes Insert parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = "me",
                        Pattern = null,
                    });
                    RequestParameters.Add("deleted", new Google.Apis.Discovery.Parameter
                    {
                        Name = "deleted",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = "false",
                        Pattern = null,
                    });
                    RequestParameters.Add("internalDateSource", new Google.Apis.Discovery.Parameter
                    {
                        Name = "internalDateSource",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = "receivedTime",
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Directly inserts a message into only this user's mailbox similar to `IMAP APPEND`, bypassing most
            /// scanning and classification. Does not send a message.
            /// </summary>
            /// <remarks>
            /// Considerations regarding <paramref name="stream"/>:
            /// <list type="bullet">
            /// <item>
            /// <description>
            /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before
            /// reading commences. If <paramref name="stream"/> is not seekable, then it will be read from its current
            /// position
            /// </description>
            /// </item>
            /// <item>
            /// <description>
            /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is completed
            /// </description>
            /// </item>
            /// <item><description>Caller is responsible for closing the <paramref name="stream"/></description></item>
            /// </list>
            /// </remarks>
            /// <param name="body">The body of the request.</param>
            /// <param name="userId">
            /// The user's email address. The special value `me` can be used to indicate the authenticated user.
            /// </param>
            /// <param name="stream">The stream to upload. See remarks for further information.</param>
            /// <param name="contentType">The content type of the stream to upload.</param>
            public virtual InsertMediaUpload Insert(Google.Apis.Gmail.v1.Data.Message body, string userId, System.IO.Stream stream, string contentType)
            {
                return new InsertMediaUpload(service, body, userId, stream, contentType);
            }

            /// <summary>Insert media upload which supports resumable upload.</summary>
            public class InsertMediaUpload : Google.Apis.Upload.ResumableUpload<Google.Apis.Gmail.v1.Data.Message, Google.Apis.Gmail.v1.Data.Message>
            {
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
                /// API key. Your API key identifies your project and provides you with API access, quota, and reports.
                /// Required unless you provide an OAuth 2.0 token.
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
                /// Available to use for quota purposes for server-side applications. Can be any arbitrary string
                /// assigned to a user, but should not exceed 40 characters.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string QuotaUser { get; set; }

                /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
                [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UploadType { get; set; }

                /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
                [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UploadProtocol { get; set; }

                /// <summary>
                /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>
                /// Mark the email as permanently deleted (not TRASH) and only visible in Google Vault to a Vault
                /// administrator. Only used for Google Workspace accounts.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("deleted", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> Deleted { get; set; }

                /// <summary>Source for Gmail's internal date of the message.</summary>
                [Google.Apis.Util.RequestParameterAttribute("internalDateSource", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<InternalDateSourceEnum> InternalDateSource { get; set; }

                /// <summary>Source for Gmail's internal date of the message.</summary>
                public enum InternalDateSourceEnum
                {
                    /// <summary>Internal message date set to current time when received by Gmail.</summary>
                    [Google.Apis.Util.StringValueAttribute("receivedTime")]
                    ReceivedTime = 0,

                    /// <summary>Internal message time based on 'Date' header in email, when valid.</summary>
                    [Google.Apis.Util.StringValueAttribute("dateHeader")]
                    DateHeader = 1,
                }

                /// <summary>Constructs a new Insert media upload instance.</summary>
                /// <remarks>
                /// Considerations regarding <paramref name="stream"/>:
                /// <list type="bullet">
                /// <item>
                /// <description>
                /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before
                /// reading commences. If <paramref name="stream"/> is not seekable, then it will be read from its
                /// current position
                /// </description>
                /// </item>
                /// <item>
                /// <description>
                /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is
                /// completed
                /// </description>
                /// </item>
                /// <item>
                /// <description>Caller is responsible for closing the <paramref name="stream"/></description>
                /// </item>
                /// </list>
                /// </remarks>
                public InsertMediaUpload(Google.Apis.Services.IClientService service, Google.Apis.Gmail.v1.Data.Message body, string userId, System.IO.Stream stream, string contentType)
                    : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "gmail/v1/users/{userId}/messages"), "POST", stream, contentType)
                {
                    UserId = userId;
                    Body = body;
                }
            }

            /// <summary>Lists the messages in the user's mailbox.</summary>
            /// <param name="userId">
            /// The user's email address. The special value `me` can be used to indicate the authenticated user.
            /// </param>
            public virtual ListRequest List(string userId)
            {
                return new ListRequest(this.service, userId);
            }

            /// <summary>Lists the messages in the user's mailbox.</summary>
            public class ListRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.ListMessagesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string userId) : base(service)
                {
                    UserId = userId;
                    InitParameters();
                }

                /// <summary>
                /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>Include messages from `SPAM` and `TRASH` in the results.</summary>
                [Google.Apis.Util.RequestParameterAttribute("includeSpamTrash", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> IncludeSpamTrash { get; set; }

                /// <summary>
                /// Only return messages with labels that match all of the specified label IDs. Messages in a thread
                /// might have labels that other messages in the same thread don't have. To learn more, see [Manage
                /// labels on messages and
                /// threads](https://developers.google.com/workspace/gmail/api/guides/labels#manage_labels_on_messages_threads).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("labelIds", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> LabelIds { get; set; }

                /// <summary>
                /// Maximum number of messages to return. This field defaults to 100. The maximum allowed value for this
                /// field is 500.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> MaxResults { get; set; }

                /// <summary>Page token to retrieve a specific page of results in the list.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// Only return messages matching the specified query. Supports the same query format as the Gmail
                /// search box. For example, `"from:someuser@example.com rfc822msgid: is:unread"`. Parameter cannot be
                /// used when accessing the api using the gmail.metadata scope.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("q", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Q { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "gmail/v1/users/{userId}/messages";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = "me",
                        Pattern = null,
                    });
                    RequestParameters.Add("includeSpamTrash", new Google.Apis.Discovery.Parameter
                    {
                        Name = "includeSpamTrash",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = "false",
                        Pattern = null,
                    });
                    RequestParameters.Add("labelIds", new Google.Apis.Discovery.Parameter
                    {
                        Name = "labelIds",
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
                        DefaultValue = "100",
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
                    RequestParameters.Add("q", new Google.Apis.Discovery.Parameter
                    {
                        Name = "q",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Modifies the labels on the specified message.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="userId">
            /// The user's email address. The special value `me` can be used to indicate the authenticated user.
            /// </param>
            /// <param name="id">The ID of the message to modify.</param>
            public virtual ModifyRequest Modify(Google.Apis.Gmail.v1.Data.ModifyMessageRequest body, string userId, string id)
            {
                return new ModifyRequest(this.service, body, userId, id);
            }

            /// <summary>Modifies the labels on the specified message.</summary>
            public class ModifyRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.Message>
            {
                /// <summary>Constructs a new Modify request.</summary>
                public ModifyRequest(Google.Apis.Services.IClientService service, Google.Apis.Gmail.v1.Data.ModifyMessageRequest body, string userId, string id) : base(service)
                {
                    UserId = userId;
                    Id = id;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>The ID of the message to modify.</summary>
                [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Id { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Gmail.v1.Data.ModifyMessageRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "modify";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "gmail/v1/users/{userId}/messages/{id}/modify";

                /// <summary>Initializes Modify parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = "me",
                        Pattern = null,
                    });
                    RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Sends the specified message to the recipients in the `To`, `Cc`, and `Bcc` headers. For example usage,
            /// see [Sending email](https://developers.google.com/workspace/gmail/api/guides/sending).
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="userId">
            /// The user's email address. The special value `me` can be used to indicate the authenticated user.
            /// </param>
            public virtual SendRequest Send(Google.Apis.Gmail.v1.Data.Message body, string userId)
            {
                return new SendRequest(this.service, body, userId);
            }

            /// <summary>
            /// Sends the specified message to the recipients in the `To`, `Cc`, and `Bcc` headers. For example usage,
            /// see [Sending email](https://developers.google.com/workspace/gmail/api/guides/sending).
            /// </summary>
            public class SendRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.Message>
            {
                /// <summary>Constructs a new Send request.</summary>
                public SendRequest(Google.Apis.Services.IClientService service, Google.Apis.Gmail.v1.Data.Message body, string userId) : base(service)
                {
                    UserId = userId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Gmail.v1.Data.Message Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "send";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "gmail/v1/users/{userId}/messages/send";

                /// <summary>Initializes Send parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = "me",
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Sends the specified message to the recipients in the `To`, `Cc`, and `Bcc` headers. For example usage,
            /// see [Sending email](https://developers.google.com/workspace/gmail/api/guides/sending).
            /// </summary>
            /// <remarks>
            /// Considerations regarding <paramref name="stream"/>:
            /// <list type="bullet">
            /// <item>
            /// <description>
            /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before
            /// reading commences. If <paramref name="stream"/> is not seekable, then it will be read from its current
            /// position
            /// </description>
            /// </item>
            /// <item>
            /// <description>
            /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is completed
            /// </description>
            /// </item>
            /// <item><description>Caller is responsible for closing the <paramref name="stream"/></description></item>
            /// </list>
            /// </remarks>
            /// <param name="body">The body of the request.</param>
            /// <param name="userId">
            /// The user's email address. The special value `me` can be used to indicate the authenticated user.
            /// </param>
            /// <param name="stream">The stream to upload. See remarks for further information.</param>
            /// <param name="contentType">The content type of the stream to upload.</param>
            public virtual SendMediaUpload Send(Google.Apis.Gmail.v1.Data.Message body, string userId, System.IO.Stream stream, string contentType)
            {
                return new SendMediaUpload(service, body, userId, stream, contentType);
            }

            /// <summary>Send media upload which supports resumable upload.</summary>
            public class SendMediaUpload : Google.Apis.Upload.ResumableUpload<Google.Apis.Gmail.v1.Data.Message, Google.Apis.Gmail.v1.Data.Message>
            {
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
                /// API key. Your API key identifies your project and provides you with API access, quota, and reports.
                /// Required unless you provide an OAuth 2.0 token.
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
                /// Available to use for quota purposes for server-side applications. Can be any arbitrary string
                /// assigned to a user, but should not exceed 40 characters.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string QuotaUser { get; set; }

                /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
                [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UploadType { get; set; }

                /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
                [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UploadProtocol { get; set; }

                /// <summary>
                /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>Constructs a new Send media upload instance.</summary>
                /// <remarks>
                /// Considerations regarding <paramref name="stream"/>:
                /// <list type="bullet">
                /// <item>
                /// <description>
                /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before
                /// reading commences. If <paramref name="stream"/> is not seekable, then it will be read from its
                /// current position
                /// </description>
                /// </item>
                /// <item>
                /// <description>
                /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is
                /// completed
                /// </description>
                /// </item>
                /// <item>
                /// <description>Caller is responsible for closing the <paramref name="stream"/></description>
                /// </item>
                /// </list>
                /// </remarks>
                public SendMediaUpload(Google.Apis.Services.IClientService service, Google.Apis.Gmail.v1.Data.Message body, string userId, System.IO.Stream stream, string contentType)
                    : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "gmail/v1/users/{userId}/messages/send"), "POST", stream, contentType)
                {
                    UserId = userId;
                    Body = body;
                }
            }

            /// <summary>Moves the specified message to the trash.</summary>
            /// <param name="userId">
            /// The user's email address. The special value `me` can be used to indicate the authenticated user.
            /// </param>
            /// <param name="id">The ID of the message to Trash.</param>
            public virtual TrashRequest Trash(string userId, string id)
            {
                return new TrashRequest(this.service, userId, id);
            }

            /// <summary>Moves the specified message to the trash.</summary>
            public class TrashRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.Message>
            {
                /// <summary>Constructs a new Trash request.</summary>
                public TrashRequest(Google.Apis.Services.IClientService service, string userId, string id) : base(service)
                {
                    UserId = userId;
                    Id = id;
                    InitParameters();
                }

                /// <summary>
                /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>The ID of the message to Trash.</summary>
                [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Id { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "trash";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "gmail/v1/users/{userId}/messages/{id}/trash";

                /// <summary>Initializes Trash parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = "me",
                        Pattern = null,
                    });
                    RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Removes the specified message from the trash.</summary>
            /// <param name="userId">
            /// The user's email address. The special value `me` can be used to indicate the authenticated user.
            /// </param>
            /// <param name="id">The ID of the message to remove from Trash.</param>
            public virtual UntrashRequest Untrash(string userId, string id)
            {
                return new UntrashRequest(this.service, userId, id);
            }

            /// <summary>Removes the specified message from the trash.</summary>
            public class UntrashRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.Message>
            {
                /// <summary>Constructs a new Untrash request.</summary>
                public UntrashRequest(Google.Apis.Services.IClientService service, string userId, string id) : base(service)
                {
                    UserId = userId;
                    Id = id;
                    InitParameters();
                }

                /// <summary>
                /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>The ID of the message to remove from Trash.</summary>
                [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Id { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "untrash";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "gmail/v1/users/{userId}/messages/{id}/untrash";

                /// <summary>Initializes Untrash parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = "me",
                        Pattern = null,
                    });
                    RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Settings resource.</summary>
        public virtual SettingsResource Settings { get; }

        /// <summary>The "settings" collection of methods.</summary>
        public class SettingsResource
        {
            private const string Resource = "settings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Cse = new CseResource(service);
                Delegates = new DelegatesResource(service);
                Filters = new FiltersResource(service);
                ForwardingAddresses = new ForwardingAddressesResource(service);
                SendAs = new SendAsResource(service);
            }

            /// <summary>Gets the Cse resource.</summary>
            public virtual CseResource Cse { get; }

            /// <summary>The "cse" collection of methods.</summary>
            public class CseResource
            {
                private const string Resource = "cse";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public CseResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Identities = new IdentitiesResource(service);
                    Keypairs = new KeypairsResource(service);
                }

                /// <summary>Gets the Identities resource.</summary>
                public virtual IdentitiesResource Identities { get; }

                /// <summary>The "identities" collection of methods.</summary>
                public class IdentitiesResource
                {
                    private const string Resource = "identities";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public IdentitiesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Creates and configures a client-side encryption identity that's authorized to send mail from the
                    /// user account. Google publishes the S/MIME certificate to a shared domain-wide directory so that
                    /// people within a Google Workspace organization can encrypt and send mail to the identity. For
                    /// administrators managing identities and keypairs for users in their organization, requests
                    /// require authorization with a [service
                    /// account](https://developers.google.com/identity/protocols/OAuth2ServiceAccount) that has
                    /// [domain-wide delegation
                    /// authority](https://developers.google.com/identity/protocols/OAuth2ServiceAccount#delegatingauthority)
                    /// to impersonate users with the `https://www.googleapis.com/auth/gmail.settings.basic` scope. For
                    /// users managing their own identities and keypairs, requests require [hardware key
                    /// encryption](https://support.google.com/a/answer/14153163) turned on and configured.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="userId">
                    /// The requester's primary email address. To indicate the authenticated user, you can use the
                    /// special value `me`.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.Gmail.v1.Data.CseIdentity body, string userId)
                    {
                        return new CreateRequest(this.service, body, userId);
                    }

                    /// <summary>
                    /// Creates and configures a client-side encryption identity that's authorized to send mail from the
                    /// user account. Google publishes the S/MIME certificate to a shared domain-wide directory so that
                    /// people within a Google Workspace organization can encrypt and send mail to the identity. For
                    /// administrators managing identities and keypairs for users in their organization, requests
                    /// require authorization with a [service
                    /// account](https://developers.google.com/identity/protocols/OAuth2ServiceAccount) that has
                    /// [domain-wide delegation
                    /// authority](https://developers.google.com/identity/protocols/OAuth2ServiceAccount#delegatingauthority)
                    /// to impersonate users with the `https://www.googleapis.com/auth/gmail.settings.basic` scope. For
                    /// users managing their own identities and keypairs, requests require [hardware key
                    /// encryption](https://support.google.com/a/answer/14153163) turned on and configured.
                    /// </summary>
                    public class CreateRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.CseIdentity>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Gmail.v1.Data.CseIdentity body, string userId) : base(service)
                        {
                            UserId = userId;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// The requester's primary email address. To indicate the authenticated user, you can use the
                        /// special value `me`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string UserId { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Gmail.v1.Data.CseIdentity Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "gmail/v1/users/{userId}/settings/cse/identities";

                        /// <summary>Initializes Create parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "userId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = "me",
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Deletes a client-side encryption identity. The authenticated user can no longer use the identity
                    /// to send encrypted messages. You cannot restore the identity after you delete it. Instead, use
                    /// the CreateCseIdentity method to create another identity with the same configuration. For
                    /// administrators managing identities and keypairs for users in their organization, requests
                    /// require authorization with a [service
                    /// account](https://developers.google.com/identity/protocols/OAuth2ServiceAccount) that has
                    /// [domain-wide delegation
                    /// authority](https://developers.google.com/identity/protocols/OAuth2ServiceAccount#delegatingauthority)
                    /// to impersonate users with the `https://www.googleapis.com/auth/gmail.settings.basic` scope. For
                    /// users managing their own identities and keypairs, requests require [hardware key
                    /// encryption](https://support.google.com/a/answer/14153163) turned on and configured.
                    /// </summary>
                    /// <param name="userId">
                    /// The requester's primary email address. To indicate the authenticated user, you can use the
                    /// special value `me`.
                    /// </param>
                    /// <param name="cseEmailAddress">
                    /// The primary email address associated with the client-side encryption identity configuration
                    /// that's removed.
                    /// </param>
                    public virtual DeleteRequest Delete(string userId, string cseEmailAddress)
                    {
                        return new DeleteRequest(this.service, userId, cseEmailAddress);
                    }

                    /// <summary>
                    /// Deletes a client-side encryption identity. The authenticated user can no longer use the identity
                    /// to send encrypted messages. You cannot restore the identity after you delete it. Instead, use
                    /// the CreateCseIdentity method to create another identity with the same configuration. For
                    /// administrators managing identities and keypairs for users in their organization, requests
                    /// require authorization with a [service
                    /// account](https://developers.google.com/identity/protocols/OAuth2ServiceAccount) that has
                    /// [domain-wide delegation
                    /// authority](https://developers.google.com/identity/protocols/OAuth2ServiceAccount#delegatingauthority)
                    /// to impersonate users with the `https://www.googleapis.com/auth/gmail.settings.basic` scope. For
                    /// users managing their own identities and keypairs, requests require [hardware key
                    /// encryption](https://support.google.com/a/answer/14153163) turned on and configured.
                    /// </summary>
                    public class DeleteRequest : GmailBaseServiceRequest<string>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string userId, string cseEmailAddress) : base(service)
                        {
                            UserId = userId;
                            CseEmailAddress = cseEmailAddress;
                            InitParameters();
                        }

                        /// <summary>
                        /// The requester's primary email address. To indicate the authenticated user, you can use the
                        /// special value `me`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string UserId { get; private set; }

                        /// <summary>
                        /// The primary email address associated with the client-side encryption identity configuration
                        /// that's removed.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("cseEmailAddress", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string CseEmailAddress { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "gmail/v1/users/{userId}/settings/cse/identities/{cseEmailAddress}";

                        /// <summary>Initializes Delete parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "userId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = "me",
                                Pattern = null,
                            });
                            RequestParameters.Add("cseEmailAddress", new Google.Apis.Discovery.Parameter
                            {
                                Name = "cseEmailAddress",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Retrieves a client-side encryption identity configuration. For administrators managing
                    /// identities and keypairs for users in their organization, requests require authorization with a
                    /// [service account](https://developers.google.com/identity/protocols/OAuth2ServiceAccount) that
                    /// has [domain-wide delegation
                    /// authority](https://developers.google.com/identity/protocols/OAuth2ServiceAccount#delegatingauthority)
                    /// to impersonate users with the `https://www.googleapis.com/auth/gmail.settings.basic` scope. For
                    /// users managing their own identities and keypairs, requests require [hardware key
                    /// encryption](https://support.google.com/a/answer/14153163) turned on and configured.
                    /// </summary>
                    /// <param name="userId">
                    /// The requester's primary email address. To indicate the authenticated user, you can use the
                    /// special value `me`.
                    /// </param>
                    /// <param name="cseEmailAddress">
                    /// The primary email address associated with the client-side encryption identity configuration
                    /// that's retrieved.
                    /// </param>
                    public virtual GetRequest Get(string userId, string cseEmailAddress)
                    {
                        return new GetRequest(this.service, userId, cseEmailAddress);
                    }

                    /// <summary>
                    /// Retrieves a client-side encryption identity configuration. For administrators managing
                    /// identities and keypairs for users in their organization, requests require authorization with a
                    /// [service account](https://developers.google.com/identity/protocols/OAuth2ServiceAccount) that
                    /// has [domain-wide delegation
                    /// authority](https://developers.google.com/identity/protocols/OAuth2ServiceAccount#delegatingauthority)
                    /// to impersonate users with the `https://www.googleapis.com/auth/gmail.settings.basic` scope. For
                    /// users managing their own identities and keypairs, requests require [hardware key
                    /// encryption](https://support.google.com/a/answer/14153163) turned on and configured.
                    /// </summary>
                    public class GetRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.CseIdentity>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string userId, string cseEmailAddress) : base(service)
                        {
                            UserId = userId;
                            CseEmailAddress = cseEmailAddress;
                            InitParameters();
                        }

                        /// <summary>
                        /// The requester's primary email address. To indicate the authenticated user, you can use the
                        /// special value `me`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string UserId { get; private set; }

                        /// <summary>
                        /// The primary email address associated with the client-side encryption identity configuration
                        /// that's retrieved.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("cseEmailAddress", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string CseEmailAddress { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "gmail/v1/users/{userId}/settings/cse/identities/{cseEmailAddress}";

                        /// <summary>Initializes Get parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "userId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = "me",
                                Pattern = null,
                            });
                            RequestParameters.Add("cseEmailAddress", new Google.Apis.Discovery.Parameter
                            {
                                Name = "cseEmailAddress",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Lists the client-side encrypted identities for an authenticated user. For administrators
                    /// managing identities and keypairs for users in their organization, requests require authorization
                    /// with a [service account](https://developers.google.com/identity/protocols/OAuth2ServiceAccount)
                    /// that has [domain-wide delegation
                    /// authority](https://developers.google.com/identity/protocols/OAuth2ServiceAccount#delegatingauthority)
                    /// to impersonate users with the `https://www.googleapis.com/auth/gmail.settings.basic` scope. For
                    /// users managing their own identities and keypairs, requests require [hardware key
                    /// encryption](https://support.google.com/a/answer/14153163) turned on and configured.
                    /// </summary>
                    /// <param name="userId">
                    /// The requester's primary email address. To indicate the authenticated user, you can use the
                    /// special value `me`.
                    /// </param>
                    public virtual ListRequest List(string userId)
                    {
                        return new ListRequest(this.service, userId);
                    }

                    /// <summary>
                    /// Lists the client-side encrypted identities for an authenticated user. For administrators
                    /// managing identities and keypairs for users in their organization, requests require authorization
                    /// with a [service account](https://developers.google.com/identity/protocols/OAuth2ServiceAccount)
                    /// that has [domain-wide delegation
                    /// authority](https://developers.google.com/identity/protocols/OAuth2ServiceAccount#delegatingauthority)
                    /// to impersonate users with the `https://www.googleapis.com/auth/gmail.settings.basic` scope. For
                    /// users managing their own identities and keypairs, requests require [hardware key
                    /// encryption](https://support.google.com/a/answer/14153163) turned on and configured.
                    /// </summary>
                    public class ListRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.ListCseIdentitiesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string userId) : base(service)
                        {
                            UserId = userId;
                            InitParameters();
                        }

                        /// <summary>
                        /// The requester's primary email address. To indicate the authenticated user, you can use the
                        /// special value `me`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string UserId { get; private set; }

                        /// <summary>
                        /// The number of identities to return. If not provided, the page size will default to 20
                        /// entries.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Pagination token indicating which page of identities to return. If the token is not
                        /// supplied, then the API will return the first page of results.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "gmail/v1/users/{userId}/settings/cse/identities";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "userId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = "me",
                                Pattern = null,
                            });
                            RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                            {
                                Name = "pageSize",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = "20",
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
                    /// Associates a different key pair with an existing client-side encryption identity. The updated
                    /// key pair must validate against Google's [S/MIME certificate
                    /// profiles](https://support.google.com/a/answer/7300887). For administrators managing identities
                    /// and keypairs for users in their organization, requests require authorization with a [service
                    /// account](https://developers.google.com/identity/protocols/OAuth2ServiceAccount) that has
                    /// [domain-wide delegation
                    /// authority](https://developers.google.com/identity/protocols/OAuth2ServiceAccount#delegatingauthority)
                    /// to impersonate users with the `https://www.googleapis.com/auth/gmail.settings.basic` scope. For
                    /// users managing their own identities and keypairs, requests require [hardware key
                    /// encryption](https://support.google.com/a/answer/14153163) turned on and configured.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="userId">
                    /// The requester's primary email address. To indicate the authenticated user, you can use the
                    /// special value `me`.
                    /// </param>
                    /// <param name="emailAddress">
                    /// The email address of the client-side encryption identity to update.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.Gmail.v1.Data.CseIdentity body, string userId, string emailAddress)
                    {
                        return new PatchRequest(this.service, body, userId, emailAddress);
                    }

                    /// <summary>
                    /// Associates a different key pair with an existing client-side encryption identity. The updated
                    /// key pair must validate against Google's [S/MIME certificate
                    /// profiles](https://support.google.com/a/answer/7300887). For administrators managing identities
                    /// and keypairs for users in their organization, requests require authorization with a [service
                    /// account](https://developers.google.com/identity/protocols/OAuth2ServiceAccount) that has
                    /// [domain-wide delegation
                    /// authority](https://developers.google.com/identity/protocols/OAuth2ServiceAccount#delegatingauthority)
                    /// to impersonate users with the `https://www.googleapis.com/auth/gmail.settings.basic` scope. For
                    /// users managing their own identities and keypairs, requests require [hardware key
                    /// encryption](https://support.google.com/a/answer/14153163) turned on and configured.
                    /// </summary>
                    public class PatchRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.CseIdentity>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Gmail.v1.Data.CseIdentity body, string userId, string emailAddress) : base(service)
                        {
                            UserId = userId;
                            EmailAddress = emailAddress;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// The requester's primary email address. To indicate the authenticated user, you can use the
                        /// special value `me`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string UserId { get; private set; }

                        /// <summary>The email address of the client-side encryption identity to update.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("emailAddress", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string EmailAddress { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Gmail.v1.Data.CseIdentity Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "gmail/v1/users/{userId}/settings/cse/identities/{emailAddress}";

                        /// <summary>Initializes Patch parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "userId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = "me",
                                Pattern = null,
                            });
                            RequestParameters.Add("emailAddress", new Google.Apis.Discovery.Parameter
                            {
                                Name = "emailAddress",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }
                }

                /// <summary>Gets the Keypairs resource.</summary>
                public virtual KeypairsResource Keypairs { get; }

                /// <summary>The "keypairs" collection of methods.</summary>
                public class KeypairsResource
                {
                    private const string Resource = "keypairs";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public KeypairsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Creates and uploads a client-side encryption S/MIME public key certificate chain and private key
                    /// metadata for the authenticated user. For administrators managing identities and keypairs for
                    /// users in their organization, requests require authorization with a [service
                    /// account](https://developers.google.com/identity/protocols/OAuth2ServiceAccount) that has
                    /// [domain-wide delegation
                    /// authority](https://developers.google.com/identity/protocols/OAuth2ServiceAccount#delegatingauthority)
                    /// to impersonate users with the `https://www.googleapis.com/auth/gmail.settings.basic` scope. For
                    /// users managing their own identities and keypairs, requests require [hardware key
                    /// encryption](https://support.google.com/a/answer/14153163) turned on and configured.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="userId">
                    /// The requester's primary email address. To indicate the authenticated user, you can use the
                    /// special value `me`.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.Gmail.v1.Data.CseKeyPair body, string userId)
                    {
                        return new CreateRequest(this.service, body, userId);
                    }

                    /// <summary>
                    /// Creates and uploads a client-side encryption S/MIME public key certificate chain and private key
                    /// metadata for the authenticated user. For administrators managing identities and keypairs for
                    /// users in their organization, requests require authorization with a [service
                    /// account](https://developers.google.com/identity/protocols/OAuth2ServiceAccount) that has
                    /// [domain-wide delegation
                    /// authority](https://developers.google.com/identity/protocols/OAuth2ServiceAccount#delegatingauthority)
                    /// to impersonate users with the `https://www.googleapis.com/auth/gmail.settings.basic` scope. For
                    /// users managing their own identities and keypairs, requests require [hardware key
                    /// encryption](https://support.google.com/a/answer/14153163) turned on and configured.
                    /// </summary>
                    public class CreateRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.CseKeyPair>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Gmail.v1.Data.CseKeyPair body, string userId) : base(service)
                        {
                            UserId = userId;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// The requester's primary email address. To indicate the authenticated user, you can use the
                        /// special value `me`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string UserId { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Gmail.v1.Data.CseKeyPair Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "gmail/v1/users/{userId}/settings/cse/keypairs";

                        /// <summary>Initializes Create parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "userId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = "me",
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Turns off a client-side encryption key pair. The authenticated user can no longer use the key
                    /// pair to decrypt incoming CSE message texts or sign outgoing CSE mail. To regain access, use the
                    /// EnableCseKeyPair to turn on the key pair. After 30 days, you can permanently delete the key pair
                    /// by using the ObliterateCseKeyPair method. For administrators managing identities and keypairs
                    /// for users in their organization, requests require authorization with a [service
                    /// account](https://developers.google.com/identity/protocols/OAuth2ServiceAccount) that has
                    /// [domain-wide delegation
                    /// authority](https://developers.google.com/identity/protocols/OAuth2ServiceAccount#delegatingauthority)
                    /// to impersonate users with the `https://www.googleapis.com/auth/gmail.settings.basic` scope. For
                    /// users managing their own identities and keypairs, requests require [hardware key
                    /// encryption](https://support.google.com/a/answer/14153163) turned on and configured.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="userId">
                    /// The requester's primary email address. To indicate the authenticated user, you can use the
                    /// special value `me`.
                    /// </param>
                    /// <param name="keyPairId">The identifier of the key pair to turn off.</param>
                    public virtual DisableRequest Disable(Google.Apis.Gmail.v1.Data.DisableCseKeyPairRequest body, string userId, string keyPairId)
                    {
                        return new DisableRequest(this.service, body, userId, keyPairId);
                    }

                    /// <summary>
                    /// Turns off a client-side encryption key pair. The authenticated user can no longer use the key
                    /// pair to decrypt incoming CSE message texts or sign outgoing CSE mail. To regain access, use the
                    /// EnableCseKeyPair to turn on the key pair. After 30 days, you can permanently delete the key pair
                    /// by using the ObliterateCseKeyPair method. For administrators managing identities and keypairs
                    /// for users in their organization, requests require authorization with a [service
                    /// account](https://developers.google.com/identity/protocols/OAuth2ServiceAccount) that has
                    /// [domain-wide delegation
                    /// authority](https://developers.google.com/identity/protocols/OAuth2ServiceAccount#delegatingauthority)
                    /// to impersonate users with the `https://www.googleapis.com/auth/gmail.settings.basic` scope. For
                    /// users managing their own identities and keypairs, requests require [hardware key
                    /// encryption](https://support.google.com/a/answer/14153163) turned on and configured.
                    /// </summary>
                    public class DisableRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.CseKeyPair>
                    {
                        /// <summary>Constructs a new Disable request.</summary>
                        public DisableRequest(Google.Apis.Services.IClientService service, Google.Apis.Gmail.v1.Data.DisableCseKeyPairRequest body, string userId, string keyPairId) : base(service)
                        {
                            UserId = userId;
                            KeyPairId = keyPairId;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// The requester's primary email address. To indicate the authenticated user, you can use the
                        /// special value `me`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string UserId { get; private set; }

                        /// <summary>The identifier of the key pair to turn off.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("keyPairId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string KeyPairId { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Gmail.v1.Data.DisableCseKeyPairRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "disable";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "gmail/v1/users/{userId}/settings/cse/keypairs/{keyPairId}:disable";

                        /// <summary>Initializes Disable parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "userId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = "me",
                                Pattern = null,
                            });
                            RequestParameters.Add("keyPairId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "keyPairId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Turns on a client-side encryption key pair that was turned off. The key pair becomes active
                    /// again for any associated client-side encryption identities. For administrators managing
                    /// identities and keypairs for users in their organization, requests require authorization with a
                    /// [service account](https://developers.google.com/identity/protocols/OAuth2ServiceAccount) that
                    /// has [domain-wide delegation
                    /// authority](https://developers.google.com/identity/protocols/OAuth2ServiceAccount#delegatingauthority)
                    /// to impersonate users with the `https://www.googleapis.com/auth/gmail.settings.basic` scope. For
                    /// users managing their own identities and keypairs, requests require [hardware key
                    /// encryption](https://support.google.com/a/answer/14153163) turned on and configured.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="userId">
                    /// The requester's primary email address. To indicate the authenticated user, you can use the
                    /// special value `me`.
                    /// </param>
                    /// <param name="keyPairId">The identifier of the key pair to turn on.</param>
                    public virtual EnableRequest Enable(Google.Apis.Gmail.v1.Data.EnableCseKeyPairRequest body, string userId, string keyPairId)
                    {
                        return new EnableRequest(this.service, body, userId, keyPairId);
                    }

                    /// <summary>
                    /// Turns on a client-side encryption key pair that was turned off. The key pair becomes active
                    /// again for any associated client-side encryption identities. For administrators managing
                    /// identities and keypairs for users in their organization, requests require authorization with a
                    /// [service account](https://developers.google.com/identity/protocols/OAuth2ServiceAccount) that
                    /// has [domain-wide delegation
                    /// authority](https://developers.google.com/identity/protocols/OAuth2ServiceAccount#delegatingauthority)
                    /// to impersonate users with the `https://www.googleapis.com/auth/gmail.settings.basic` scope. For
                    /// users managing their own identities and keypairs, requests require [hardware key
                    /// encryption](https://support.google.com/a/answer/14153163) turned on and configured.
                    /// </summary>
                    public class EnableRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.CseKeyPair>
                    {
                        /// <summary>Constructs a new Enable request.</summary>
                        public EnableRequest(Google.Apis.Services.IClientService service, Google.Apis.Gmail.v1.Data.EnableCseKeyPairRequest body, string userId, string keyPairId) : base(service)
                        {
                            UserId = userId;
                            KeyPairId = keyPairId;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// The requester's primary email address. To indicate the authenticated user, you can use the
                        /// special value `me`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string UserId { get; private set; }

                        /// <summary>The identifier of the key pair to turn on.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("keyPairId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string KeyPairId { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Gmail.v1.Data.EnableCseKeyPairRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "enable";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "gmail/v1/users/{userId}/settings/cse/keypairs/{keyPairId}:enable";

                        /// <summary>Initializes Enable parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "userId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = "me",
                                Pattern = null,
                            });
                            RequestParameters.Add("keyPairId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "keyPairId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Retrieves an existing client-side encryption key pair. For administrators managing identities
                    /// and keypairs for users in their organization, requests require authorization with a [service
                    /// account](https://developers.google.com/identity/protocols/OAuth2ServiceAccount) that has
                    /// [domain-wide delegation
                    /// authority](https://developers.google.com/identity/protocols/OAuth2ServiceAccount#delegatingauthority)
                    /// to impersonate users with the `https://www.googleapis.com/auth/gmail.settings.basic` scope. For
                    /// users managing their own identities and keypairs, requests require [hardware key
                    /// encryption](https://support.google.com/a/answer/14153163) turned on and configured.
                    /// </summary>
                    /// <param name="userId">
                    /// The requester's primary email address. To indicate the authenticated user, you can use the
                    /// special value `me`.
                    /// </param>
                    /// <param name="keyPairId">The identifier of the key pair to retrieve.</param>
                    public virtual GetRequest Get(string userId, string keyPairId)
                    {
                        return new GetRequest(this.service, userId, keyPairId);
                    }

                    /// <summary>
                    /// Retrieves an existing client-side encryption key pair. For administrators managing identities
                    /// and keypairs for users in their organization, requests require authorization with a [service
                    /// account](https://developers.google.com/identity/protocols/OAuth2ServiceAccount) that has
                    /// [domain-wide delegation
                    /// authority](https://developers.google.com/identity/protocols/OAuth2ServiceAccount#delegatingauthority)
                    /// to impersonate users with the `https://www.googleapis.com/auth/gmail.settings.basic` scope. For
                    /// users managing their own identities and keypairs, requests require [hardware key
                    /// encryption](https://support.google.com/a/answer/14153163) turned on and configured.
                    /// </summary>
                    public class GetRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.CseKeyPair>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string userId, string keyPairId) : base(service)
                        {
                            UserId = userId;
                            KeyPairId = keyPairId;
                            InitParameters();
                        }

                        /// <summary>
                        /// The requester's primary email address. To indicate the authenticated user, you can use the
                        /// special value `me`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string UserId { get; private set; }

                        /// <summary>The identifier of the key pair to retrieve.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("keyPairId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string KeyPairId { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "gmail/v1/users/{userId}/settings/cse/keypairs/{keyPairId}";

                        /// <summary>Initializes Get parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "userId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = "me",
                                Pattern = null,
                            });
                            RequestParameters.Add("keyPairId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "keyPairId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Lists client-side encryption key pairs for an authenticated user. For administrators managing
                    /// identities and keypairs for users in their organization, requests require authorization with a
                    /// [service account](https://developers.google.com/identity/protocols/OAuth2ServiceAccount) that
                    /// has [domain-wide delegation
                    /// authority](https://developers.google.com/identity/protocols/OAuth2ServiceAccount#delegatingauthority)
                    /// to impersonate users with the `https://www.googleapis.com/auth/gmail.settings.basic` scope. For
                    /// users managing their own identities and keypairs, requests require [hardware key
                    /// encryption](https://support.google.com/a/answer/14153163) turned on and configured.
                    /// </summary>
                    /// <param name="userId">
                    /// The requester's primary email address. To indicate the authenticated user, you can use the
                    /// special value `me`.
                    /// </param>
                    public virtual ListRequest List(string userId)
                    {
                        return new ListRequest(this.service, userId);
                    }

                    /// <summary>
                    /// Lists client-side encryption key pairs for an authenticated user. For administrators managing
                    /// identities and keypairs for users in their organization, requests require authorization with a
                    /// [service account](https://developers.google.com/identity/protocols/OAuth2ServiceAccount) that
                    /// has [domain-wide delegation
                    /// authority](https://developers.google.com/identity/protocols/OAuth2ServiceAccount#delegatingauthority)
                    /// to impersonate users with the `https://www.googleapis.com/auth/gmail.settings.basic` scope. For
                    /// users managing their own identities and keypairs, requests require [hardware key
                    /// encryption](https://support.google.com/a/answer/14153163) turned on and configured.
                    /// </summary>
                    public class ListRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.ListCseKeyPairsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string userId) : base(service)
                        {
                            UserId = userId;
                            InitParameters();
                        }

                        /// <summary>
                        /// The requester's primary email address. To indicate the authenticated user, you can use the
                        /// special value `me`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string UserId { get; private set; }

                        /// <summary>
                        /// The number of key pairs to return. If not provided, the page size will default to 20
                        /// entries.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Pagination token indicating which page of key pairs to return. If the token is not supplied,
                        /// then the API will return the first page of results.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "gmail/v1/users/{userId}/settings/cse/keypairs";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "userId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = "me",
                                Pattern = null,
                            });
                            RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                            {
                                Name = "pageSize",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = "20",
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
                    /// Deletes a client-side encryption key pair permanently and immediately. You can only permanently
                    /// delete key pairs that have been turned off for more than 30 days. To turn off a key pair, use
                    /// the DisableCseKeyPair method. Gmail can't restore or decrypt any messages that were encrypted by
                    /// an obliterated key. Authenticated users and Google Workspace administrators lose access to
                    /// reading the encrypted messages. For administrators managing identities and keypairs for users in
                    /// their organization, requests require authorization with a [service
                    /// account](https://developers.google.com/identity/protocols/OAuth2ServiceAccount) that has
                    /// [domain-wide delegation
                    /// authority](https://developers.google.com/identity/protocols/OAuth2ServiceAccount#delegatingauthority)
                    /// to impersonate users with the `https://www.googleapis.com/auth/gmail.settings.basic` scope. For
                    /// users managing their own identities and keypairs, requests require [hardware key
                    /// encryption](https://support.google.com/a/answer/14153163) turned on and configured.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="userId">
                    /// The requester's primary email address. To indicate the authenticated user, you can use the
                    /// special value `me`.
                    /// </param>
                    /// <param name="keyPairId">The identifier of the key pair to obliterate.</param>
                    public virtual ObliterateRequest Obliterate(Google.Apis.Gmail.v1.Data.ObliterateCseKeyPairRequest body, string userId, string keyPairId)
                    {
                        return new ObliterateRequest(this.service, body, userId, keyPairId);
                    }

                    /// <summary>
                    /// Deletes a client-side encryption key pair permanently and immediately. You can only permanently
                    /// delete key pairs that have been turned off for more than 30 days. To turn off a key pair, use
                    /// the DisableCseKeyPair method. Gmail can't restore or decrypt any messages that were encrypted by
                    /// an obliterated key. Authenticated users and Google Workspace administrators lose access to
                    /// reading the encrypted messages. For administrators managing identities and keypairs for users in
                    /// their organization, requests require authorization with a [service
                    /// account](https://developers.google.com/identity/protocols/OAuth2ServiceAccount) that has
                    /// [domain-wide delegation
                    /// authority](https://developers.google.com/identity/protocols/OAuth2ServiceAccount#delegatingauthority)
                    /// to impersonate users with the `https://www.googleapis.com/auth/gmail.settings.basic` scope. For
                    /// users managing their own identities and keypairs, requests require [hardware key
                    /// encryption](https://support.google.com/a/answer/14153163) turned on and configured.
                    /// </summary>
                    public class ObliterateRequest : GmailBaseServiceRequest<string>
                    {
                        /// <summary>Constructs a new Obliterate request.</summary>
                        public ObliterateRequest(Google.Apis.Services.IClientService service, Google.Apis.Gmail.v1.Data.ObliterateCseKeyPairRequest body, string userId, string keyPairId) : base(service)
                        {
                            UserId = userId;
                            KeyPairId = keyPairId;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// The requester's primary email address. To indicate the authenticated user, you can use the
                        /// special value `me`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string UserId { get; private set; }

                        /// <summary>The identifier of the key pair to obliterate.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("keyPairId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string KeyPairId { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Gmail.v1.Data.ObliterateCseKeyPairRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "obliterate";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "gmail/v1/users/{userId}/settings/cse/keypairs/{keyPairId}:obliterate";

                        /// <summary>Initializes Obliterate parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "userId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = "me",
                                Pattern = null,
                            });
                            RequestParameters.Add("keyPairId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "keyPairId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }
                }
            }

            /// <summary>Gets the Delegates resource.</summary>
            public virtual DelegatesResource Delegates { get; }

            /// <summary>The "delegates" collection of methods.</summary>
            public class DelegatesResource
            {
                private const string Resource = "delegates";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DelegatesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Adds a delegate with its verification status set directly to `accepted`, without sending any
                /// verification email. The delegate user must be a member of the same Google Workspace organization as
                /// the delegator user. Gmail imposes limitations on the number of delegates and delegators each user in
                /// a Google Workspace organization can have. These limits depend on your organization, but in general
                /// each user can have up to 25 delegates and up to 10 delegators. Note that a delegate user must be
                /// referred to by their primary email address, and not an email alias. Also note that when a new
                /// delegate is created, there may be up to a one minute delay before the new delegate is available for
                /// use. This method is only available to service account clients that have been delegated domain-wide
                /// authority.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="userId">
                /// User's email address. The special value "me" can be used to indicate the authenticated user.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Gmail.v1.Data.Delegate body, string userId)
                {
                    return new CreateRequest(this.service, body, userId);
                }

                /// <summary>
                /// Adds a delegate with its verification status set directly to `accepted`, without sending any
                /// verification email. The delegate user must be a member of the same Google Workspace organization as
                /// the delegator user. Gmail imposes limitations on the number of delegates and delegators each user in
                /// a Google Workspace organization can have. These limits depend on your organization, but in general
                /// each user can have up to 25 delegates and up to 10 delegators. Note that a delegate user must be
                /// referred to by their primary email address, and not an email alias. Also note that when a new
                /// delegate is created, there may be up to a one minute delay before the new delegate is available for
                /// use. This method is only available to service account clients that have been delegated domain-wide
                /// authority.
                /// </summary>
                public class CreateRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.Delegate>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Gmail.v1.Data.Delegate body, string userId) : base(service)
                    {
                        UserId = userId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// User's email address. The special value "me" can be used to indicate the authenticated user.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string UserId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Gmail.v1.Data.Delegate Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "gmail/v1/users/{userId}/settings/delegates";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "userId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = "me",
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Removes the specified delegate (which can be of any verification status), and revokes any
                /// verification that may have been required for using it. Note that a delegate user must be referred to
                /// by their primary email address, and not an email alias. This method is only available to service
                /// account clients that have been delegated domain-wide authority.
                /// </summary>
                /// <param name="userId">
                /// User's email address. The special value "me" can be used to indicate the authenticated user.
                /// </param>
                /// <param name="delegateEmail">The email address of the user to be removed as a delegate.</param>
                public virtual DeleteRequest Delete(string userId, string delegateEmail)
                {
                    return new DeleteRequest(this.service, userId, delegateEmail);
                }

                /// <summary>
                /// Removes the specified delegate (which can be of any verification status), and revokes any
                /// verification that may have been required for using it. Note that a delegate user must be referred to
                /// by their primary email address, and not an email alias. This method is only available to service
                /// account clients that have been delegated domain-wide authority.
                /// </summary>
                public class DeleteRequest : GmailBaseServiceRequest<string>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string userId, string delegateEmail) : base(service)
                    {
                        UserId = userId;
                        DelegateEmail = delegateEmail;
                        InitParameters();
                    }

                    /// <summary>
                    /// User's email address. The special value "me" can be used to indicate the authenticated user.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string UserId { get; private set; }

                    /// <summary>The email address of the user to be removed as a delegate.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("delegateEmail", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string DelegateEmail { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "gmail/v1/users/{userId}/settings/delegates/{delegateEmail}";

                    /// <summary>Initializes Delete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "userId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = "me",
                            Pattern = null,
                        });
                        RequestParameters.Add("delegateEmail", new Google.Apis.Discovery.Parameter
                        {
                            Name = "delegateEmail",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Gets the specified delegate. Note that a delegate user must be referred to by their primary email
                /// address, and not an email alias. This method is only available to service account clients that have
                /// been delegated domain-wide authority.
                /// </summary>
                /// <param name="userId">
                /// User's email address. The special value "me" can be used to indicate the authenticated user.
                /// </param>
                /// <param name="delegateEmail">
                /// The email address of the user whose delegate relationship is to be retrieved.
                /// </param>
                public virtual GetRequest Get(string userId, string delegateEmail)
                {
                    return new GetRequest(this.service, userId, delegateEmail);
                }

                /// <summary>
                /// Gets the specified delegate. Note that a delegate user must be referred to by their primary email
                /// address, and not an email alias. This method is only available to service account clients that have
                /// been delegated domain-wide authority.
                /// </summary>
                public class GetRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.Delegate>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string userId, string delegateEmail) : base(service)
                    {
                        UserId = userId;
                        DelegateEmail = delegateEmail;
                        InitParameters();
                    }

                    /// <summary>
                    /// User's email address. The special value "me" can be used to indicate the authenticated user.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string UserId { get; private set; }

                    /// <summary>The email address of the user whose delegate relationship is to be retrieved.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("delegateEmail", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string DelegateEmail { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "gmail/v1/users/{userId}/settings/delegates/{delegateEmail}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "userId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = "me",
                            Pattern = null,
                        });
                        RequestParameters.Add("delegateEmail", new Google.Apis.Discovery.Parameter
                        {
                            Name = "delegateEmail",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Lists the delegates for the specified account. This method is only available to service account
                /// clients that have been delegated domain-wide authority.
                /// </summary>
                /// <param name="userId">
                /// User's email address. The special value "me" can be used to indicate the authenticated user.
                /// </param>
                public virtual ListRequest List(string userId)
                {
                    return new ListRequest(this.service, userId);
                }

                /// <summary>
                /// Lists the delegates for the specified account. This method is only available to service account
                /// clients that have been delegated domain-wide authority.
                /// </summary>
                public class ListRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.ListDelegatesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string userId) : base(service)
                    {
                        UserId = userId;
                        InitParameters();
                    }

                    /// <summary>
                    /// User's email address. The special value "me" can be used to indicate the authenticated user.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string UserId { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "gmail/v1/users/{userId}/settings/delegates";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "userId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = "me",
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Gets the Filters resource.</summary>
            public virtual FiltersResource Filters { get; }

            /// <summary>The "filters" collection of methods.</summary>
            public class FiltersResource
            {
                private const string Resource = "filters";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public FiltersResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a filter. Note: you can only create a maximum of 1,000 filters.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="userId">
                /// User's email address. The special value "me" can be used to indicate the authenticated user.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Gmail.v1.Data.Filter body, string userId)
                {
                    return new CreateRequest(this.service, body, userId);
                }

                /// <summary>Creates a filter. Note: you can only create a maximum of 1,000 filters.</summary>
                public class CreateRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.Filter>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Gmail.v1.Data.Filter body, string userId) : base(service)
                    {
                        UserId = userId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// User's email address. The special value "me" can be used to indicate the authenticated user.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string UserId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Gmail.v1.Data.Filter Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "gmail/v1/users/{userId}/settings/filters";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "userId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = "me",
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Immediately and permanently deletes the specified filter.</summary>
                /// <param name="userId">
                /// User's email address. The special value "me" can be used to indicate the authenticated user.
                /// </param>
                /// <param name="id">The ID of the filter to be deleted.</param>
                public virtual DeleteRequest Delete(string userId, string id)
                {
                    return new DeleteRequest(this.service, userId, id);
                }

                /// <summary>Immediately and permanently deletes the specified filter.</summary>
                public class DeleteRequest : GmailBaseServiceRequest<string>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string userId, string id) : base(service)
                    {
                        UserId = userId;
                        Id = id;
                        InitParameters();
                    }

                    /// <summary>
                    /// User's email address. The special value "me" can be used to indicate the authenticated user.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string UserId { get; private set; }

                    /// <summary>The ID of the filter to be deleted.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Id { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "gmail/v1/users/{userId}/settings/filters/{id}";

                    /// <summary>Initializes Delete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "userId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = "me",
                            Pattern = null,
                        });
                        RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                        {
                            Name = "id",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets a filter.</summary>
                /// <param name="userId">
                /// User's email address. The special value "me" can be used to indicate the authenticated user.
                /// </param>
                /// <param name="id">The ID of the filter to be fetched.</param>
                public virtual GetRequest Get(string userId, string id)
                {
                    return new GetRequest(this.service, userId, id);
                }

                /// <summary>Gets a filter.</summary>
                public class GetRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.Filter>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string userId, string id) : base(service)
                    {
                        UserId = userId;
                        Id = id;
                        InitParameters();
                    }

                    /// <summary>
                    /// User's email address. The special value "me" can be used to indicate the authenticated user.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string UserId { get; private set; }

                    /// <summary>The ID of the filter to be fetched.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Id { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "gmail/v1/users/{userId}/settings/filters/{id}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "userId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = "me",
                            Pattern = null,
                        });
                        RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                        {
                            Name = "id",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Lists the message filters of a Gmail user.</summary>
                /// <param name="userId">
                /// User's email address. The special value "me" can be used to indicate the authenticated user.
                /// </param>
                public virtual ListRequest List(string userId)
                {
                    return new ListRequest(this.service, userId);
                }

                /// <summary>Lists the message filters of a Gmail user.</summary>
                public class ListRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.ListFiltersResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string userId) : base(service)
                    {
                        UserId = userId;
                        InitParameters();
                    }

                    /// <summary>
                    /// User's email address. The special value "me" can be used to indicate the authenticated user.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string UserId { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "gmail/v1/users/{userId}/settings/filters";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "userId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = "me",
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Gets the ForwardingAddresses resource.</summary>
            public virtual ForwardingAddressesResource ForwardingAddresses { get; }

            /// <summary>The "forwardingAddresses" collection of methods.</summary>
            public class ForwardingAddressesResource
            {
                private const string Resource = "forwardingAddresses";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ForwardingAddressesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Creates a forwarding address. If ownership verification is required, a message will be sent to the
                /// recipient and the resource's verification status will be set to `pending`; otherwise, the resource
                /// will be created with verification status set to `accepted`. This method is only available to service
                /// account clients that have been delegated domain-wide authority.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="userId">
                /// User's email address. The special value "me" can be used to indicate the authenticated user.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Gmail.v1.Data.ForwardingAddress body, string userId)
                {
                    return new CreateRequest(this.service, body, userId);
                }

                /// <summary>
                /// Creates a forwarding address. If ownership verification is required, a message will be sent to the
                /// recipient and the resource's verification status will be set to `pending`; otherwise, the resource
                /// will be created with verification status set to `accepted`. This method is only available to service
                /// account clients that have been delegated domain-wide authority.
                /// </summary>
                public class CreateRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.ForwardingAddress>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Gmail.v1.Data.ForwardingAddress body, string userId) : base(service)
                    {
                        UserId = userId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// User's email address. The special value "me" can be used to indicate the authenticated user.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string UserId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Gmail.v1.Data.ForwardingAddress Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "gmail/v1/users/{userId}/settings/forwardingAddresses";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "userId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = "me",
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Deletes the specified forwarding address and revokes any verification that may have been required.
                /// This method is only available to service account clients that have been delegated domain-wide
                /// authority.
                /// </summary>
                /// <param name="userId">
                /// User's email address. The special value "me" can be used to indicate the authenticated user.
                /// </param>
                /// <param name="forwardingEmail">The forwarding address to be deleted.</param>
                public virtual DeleteRequest Delete(string userId, string forwardingEmail)
                {
                    return new DeleteRequest(this.service, userId, forwardingEmail);
                }

                /// <summary>
                /// Deletes the specified forwarding address and revokes any verification that may have been required.
                /// This method is only available to service account clients that have been delegated domain-wide
                /// authority.
                /// </summary>
                public class DeleteRequest : GmailBaseServiceRequest<string>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string userId, string forwardingEmail) : base(service)
                    {
                        UserId = userId;
                        ForwardingEmail = forwardingEmail;
                        InitParameters();
                    }

                    /// <summary>
                    /// User's email address. The special value "me" can be used to indicate the authenticated user.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string UserId { get; private set; }

                    /// <summary>The forwarding address to be deleted.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("forwardingEmail", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ForwardingEmail { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "gmail/v1/users/{userId}/settings/forwardingAddresses/{forwardingEmail}";

                    /// <summary>Initializes Delete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "userId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = "me",
                            Pattern = null,
                        });
                        RequestParameters.Add("forwardingEmail", new Google.Apis.Discovery.Parameter
                        {
                            Name = "forwardingEmail",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets the specified forwarding address.</summary>
                /// <param name="userId">
                /// User's email address. The special value "me" can be used to indicate the authenticated user.
                /// </param>
                /// <param name="forwardingEmail">The forwarding address to be retrieved.</param>
                public virtual GetRequest Get(string userId, string forwardingEmail)
                {
                    return new GetRequest(this.service, userId, forwardingEmail);
                }

                /// <summary>Gets the specified forwarding address.</summary>
                public class GetRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.ForwardingAddress>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string userId, string forwardingEmail) : base(service)
                    {
                        UserId = userId;
                        ForwardingEmail = forwardingEmail;
                        InitParameters();
                    }

                    /// <summary>
                    /// User's email address. The special value "me" can be used to indicate the authenticated user.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string UserId { get; private set; }

                    /// <summary>The forwarding address to be retrieved.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("forwardingEmail", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ForwardingEmail { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "gmail/v1/users/{userId}/settings/forwardingAddresses/{forwardingEmail}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "userId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = "me",
                            Pattern = null,
                        });
                        RequestParameters.Add("forwardingEmail", new Google.Apis.Discovery.Parameter
                        {
                            Name = "forwardingEmail",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Lists the forwarding addresses for the specified account.</summary>
                /// <param name="userId">
                /// User's email address. The special value "me" can be used to indicate the authenticated user.
                /// </param>
                public virtual ListRequest List(string userId)
                {
                    return new ListRequest(this.service, userId);
                }

                /// <summary>Lists the forwarding addresses for the specified account.</summary>
                public class ListRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.ListForwardingAddressesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string userId) : base(service)
                    {
                        UserId = userId;
                        InitParameters();
                    }

                    /// <summary>
                    /// User's email address. The special value "me" can be used to indicate the authenticated user.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string UserId { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "gmail/v1/users/{userId}/settings/forwardingAddresses";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "userId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = "me",
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Gets the SendAs resource.</summary>
            public virtual SendAsResource SendAs { get; }

            /// <summary>The "sendAs" collection of methods.</summary>
            public class SendAsResource
            {
                private const string Resource = "sendAs";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public SendAsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    SmimeInfo = new SmimeInfoResource(service);
                }

                /// <summary>Gets the SmimeInfo resource.</summary>
                public virtual SmimeInfoResource SmimeInfo { get; }

                /// <summary>The "smimeInfo" collection of methods.</summary>
                public class SmimeInfoResource
                {
                    private const string Resource = "smimeInfo";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public SmimeInfoResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Deletes the specified S/MIME config for the specified send-as alias.</summary>
                    /// <param name="userId">
                    /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                    /// </param>
                    /// <param name="sendAsEmail">
                    /// The email address that appears in the "From:" header for mail sent using this alias.
                    /// </param>
                    /// <param name="id">The immutable ID for the SmimeInfo.</param>
                    public virtual DeleteRequest Delete(string userId, string sendAsEmail, string id)
                    {
                        return new DeleteRequest(this.service, userId, sendAsEmail, id);
                    }

                    /// <summary>Deletes the specified S/MIME config for the specified send-as alias.</summary>
                    public class DeleteRequest : GmailBaseServiceRequest<string>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string userId, string sendAsEmail, string id) : base(service)
                        {
                            UserId = userId;
                            SendAsEmail = sendAsEmail;
                            Id = id;
                            InitParameters();
                        }

                        /// <summary>
                        /// The user's email address. The special value `me` can be used to indicate the authenticated
                        /// user.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string UserId { get; private set; }

                        /// <summary>
                        /// The email address that appears in the "From:" header for mail sent using this alias.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("sendAsEmail", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string SendAsEmail { get; private set; }

                        /// <summary>The immutable ID for the SmimeInfo.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Id { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "gmail/v1/users/{userId}/settings/sendAs/{sendAsEmail}/smimeInfo/{id}";

                        /// <summary>Initializes Delete parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "userId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = "me",
                                Pattern = null,
                            });
                            RequestParameters.Add("sendAsEmail", new Google.Apis.Discovery.Parameter
                            {
                                Name = "sendAsEmail",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                            {
                                Name = "id",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Gets the specified S/MIME config for the specified send-as alias.</summary>
                    /// <param name="userId">
                    /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                    /// </param>
                    /// <param name="sendAsEmail">
                    /// The email address that appears in the "From:" header for mail sent using this alias.
                    /// </param>
                    /// <param name="id">The immutable ID for the SmimeInfo.</param>
                    public virtual GetRequest Get(string userId, string sendAsEmail, string id)
                    {
                        return new GetRequest(this.service, userId, sendAsEmail, id);
                    }

                    /// <summary>Gets the specified S/MIME config for the specified send-as alias.</summary>
                    public class GetRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.SmimeInfo>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string userId, string sendAsEmail, string id) : base(service)
                        {
                            UserId = userId;
                            SendAsEmail = sendAsEmail;
                            Id = id;
                            InitParameters();
                        }

                        /// <summary>
                        /// The user's email address. The special value `me` can be used to indicate the authenticated
                        /// user.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string UserId { get; private set; }

                        /// <summary>
                        /// The email address that appears in the "From:" header for mail sent using this alias.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("sendAsEmail", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string SendAsEmail { get; private set; }

                        /// <summary>The immutable ID for the SmimeInfo.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Id { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "gmail/v1/users/{userId}/settings/sendAs/{sendAsEmail}/smimeInfo/{id}";

                        /// <summary>Initializes Get parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "userId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = "me",
                                Pattern = null,
                            });
                            RequestParameters.Add("sendAsEmail", new Google.Apis.Discovery.Parameter
                            {
                                Name = "sendAsEmail",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                            {
                                Name = "id",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Insert (upload) the given S/MIME config for the specified send-as alias. Note that pkcs12 format
                    /// is required for the key.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="userId">
                    /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                    /// </param>
                    /// <param name="sendAsEmail">
                    /// The email address that appears in the "From:" header for mail sent using this alias.
                    /// </param>
                    public virtual InsertRequest Insert(Google.Apis.Gmail.v1.Data.SmimeInfo body, string userId, string sendAsEmail)
                    {
                        return new InsertRequest(this.service, body, userId, sendAsEmail);
                    }

                    /// <summary>
                    /// Insert (upload) the given S/MIME config for the specified send-as alias. Note that pkcs12 format
                    /// is required for the key.
                    /// </summary>
                    public class InsertRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.SmimeInfo>
                    {
                        /// <summary>Constructs a new Insert request.</summary>
                        public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Gmail.v1.Data.SmimeInfo body, string userId, string sendAsEmail) : base(service)
                        {
                            UserId = userId;
                            SendAsEmail = sendAsEmail;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// The user's email address. The special value `me` can be used to indicate the authenticated
                        /// user.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string UserId { get; private set; }

                        /// <summary>
                        /// The email address that appears in the "From:" header for mail sent using this alias.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("sendAsEmail", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string SendAsEmail { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Gmail.v1.Data.SmimeInfo Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "insert";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "gmail/v1/users/{userId}/settings/sendAs/{sendAsEmail}/smimeInfo";

                        /// <summary>Initializes Insert parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "userId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = "me",
                                Pattern = null,
                            });
                            RequestParameters.Add("sendAsEmail", new Google.Apis.Discovery.Parameter
                            {
                                Name = "sendAsEmail",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Lists S/MIME configs for the specified send-as alias.</summary>
                    /// <param name="userId">
                    /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                    /// </param>
                    /// <param name="sendAsEmail">
                    /// The email address that appears in the "From:" header for mail sent using this alias.
                    /// </param>
                    public virtual ListRequest List(string userId, string sendAsEmail)
                    {
                        return new ListRequest(this.service, userId, sendAsEmail);
                    }

                    /// <summary>Lists S/MIME configs for the specified send-as alias.</summary>
                    public class ListRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.ListSmimeInfoResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string userId, string sendAsEmail) : base(service)
                        {
                            UserId = userId;
                            SendAsEmail = sendAsEmail;
                            InitParameters();
                        }

                        /// <summary>
                        /// The user's email address. The special value `me` can be used to indicate the authenticated
                        /// user.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string UserId { get; private set; }

                        /// <summary>
                        /// The email address that appears in the "From:" header for mail sent using this alias.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("sendAsEmail", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string SendAsEmail { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "gmail/v1/users/{userId}/settings/sendAs/{sendAsEmail}/smimeInfo";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "userId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = "me",
                                Pattern = null,
                            });
                            RequestParameters.Add("sendAsEmail", new Google.Apis.Discovery.Parameter
                            {
                                Name = "sendAsEmail",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Sets the default S/MIME config for the specified send-as alias.</summary>
                    /// <param name="userId">
                    /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                    /// </param>
                    /// <param name="sendAsEmail">
                    /// The email address that appears in the "From:" header for mail sent using this alias.
                    /// </param>
                    /// <param name="id">The immutable ID for the SmimeInfo.</param>
                    public virtual SetDefaultRequest SetDefault(string userId, string sendAsEmail, string id)
                    {
                        return new SetDefaultRequest(this.service, userId, sendAsEmail, id);
                    }

                    /// <summary>Sets the default S/MIME config for the specified send-as alias.</summary>
                    public class SetDefaultRequest : GmailBaseServiceRequest<string>
                    {
                        /// <summary>Constructs a new SetDefault request.</summary>
                        public SetDefaultRequest(Google.Apis.Services.IClientService service, string userId, string sendAsEmail, string id) : base(service)
                        {
                            UserId = userId;
                            SendAsEmail = sendAsEmail;
                            Id = id;
                            InitParameters();
                        }

                        /// <summary>
                        /// The user's email address. The special value `me` can be used to indicate the authenticated
                        /// user.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string UserId { get; private set; }

                        /// <summary>
                        /// The email address that appears in the "From:" header for mail sent using this alias.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("sendAsEmail", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string SendAsEmail { get; private set; }

                        /// <summary>The immutable ID for the SmimeInfo.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Id { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "setDefault";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "gmail/v1/users/{userId}/settings/sendAs/{sendAsEmail}/smimeInfo/{id}/setDefault";

                        /// <summary>Initializes SetDefault parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "userId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = "me",
                                Pattern = null,
                            });
                            RequestParameters.Add("sendAsEmail", new Google.Apis.Discovery.Parameter
                            {
                                Name = "sendAsEmail",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                            {
                                Name = "id",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }
                }

                /// <summary>
                /// Creates a custom "from" send-as alias. If an SMTP MSA is specified, Gmail will attempt to connect to
                /// the SMTP service to validate the configuration before creating the alias. If ownership verification
                /// is required for the alias, a message will be sent to the email address and the resource's
                /// verification status will be set to `pending`; otherwise, the resource will be created with
                /// verification status set to `accepted`. If a signature is provided, Gmail will sanitize the HTML
                /// before saving it with the alias. This method is only available to service account clients that have
                /// been delegated domain-wide authority.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="userId">
                /// User's email address. The special value "me" can be used to indicate the authenticated user.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Gmail.v1.Data.SendAs body, string userId)
                {
                    return new CreateRequest(this.service, body, userId);
                }

                /// <summary>
                /// Creates a custom "from" send-as alias. If an SMTP MSA is specified, Gmail will attempt to connect to
                /// the SMTP service to validate the configuration before creating the alias. If ownership verification
                /// is required for the alias, a message will be sent to the email address and the resource's
                /// verification status will be set to `pending`; otherwise, the resource will be created with
                /// verification status set to `accepted`. If a signature is provided, Gmail will sanitize the HTML
                /// before saving it with the alias. This method is only available to service account clients that have
                /// been delegated domain-wide authority.
                /// </summary>
                public class CreateRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.SendAs>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Gmail.v1.Data.SendAs body, string userId) : base(service)
                    {
                        UserId = userId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// User's email address. The special value "me" can be used to indicate the authenticated user.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string UserId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Gmail.v1.Data.SendAs Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "gmail/v1/users/{userId}/settings/sendAs";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "userId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = "me",
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Deletes the specified send-as alias. Revokes any verification that may have been required for using
                /// it. This method is only available to service account clients that have been delegated domain-wide
                /// authority.
                /// </summary>
                /// <param name="userId">
                /// User's email address. The special value "me" can be used to indicate the authenticated user.
                /// </param>
                /// <param name="sendAsEmail">The send-as alias to be deleted.</param>
                public virtual DeleteRequest Delete(string userId, string sendAsEmail)
                {
                    return new DeleteRequest(this.service, userId, sendAsEmail);
                }

                /// <summary>
                /// Deletes the specified send-as alias. Revokes any verification that may have been required for using
                /// it. This method is only available to service account clients that have been delegated domain-wide
                /// authority.
                /// </summary>
                public class DeleteRequest : GmailBaseServiceRequest<string>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string userId, string sendAsEmail) : base(service)
                    {
                        UserId = userId;
                        SendAsEmail = sendAsEmail;
                        InitParameters();
                    }

                    /// <summary>
                    /// User's email address. The special value "me" can be used to indicate the authenticated user.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string UserId { get; private set; }

                    /// <summary>The send-as alias to be deleted.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("sendAsEmail", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string SendAsEmail { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "gmail/v1/users/{userId}/settings/sendAs/{sendAsEmail}";

                    /// <summary>Initializes Delete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "userId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = "me",
                            Pattern = null,
                        });
                        RequestParameters.Add("sendAsEmail", new Google.Apis.Discovery.Parameter
                        {
                            Name = "sendAsEmail",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Gets the specified send-as alias. Fails with an HTTP 404 error if the specified address is not a
                /// member of the collection.
                /// </summary>
                /// <param name="userId">
                /// User's email address. The special value "me" can be used to indicate the authenticated user.
                /// </param>
                /// <param name="sendAsEmail">The send-as alias to be retrieved.</param>
                public virtual GetRequest Get(string userId, string sendAsEmail)
                {
                    return new GetRequest(this.service, userId, sendAsEmail);
                }

                /// <summary>
                /// Gets the specified send-as alias. Fails with an HTTP 404 error if the specified address is not a
                /// member of the collection.
                /// </summary>
                public class GetRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.SendAs>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string userId, string sendAsEmail) : base(service)
                    {
                        UserId = userId;
                        SendAsEmail = sendAsEmail;
                        InitParameters();
                    }

                    /// <summary>
                    /// User's email address. The special value "me" can be used to indicate the authenticated user.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string UserId { get; private set; }

                    /// <summary>The send-as alias to be retrieved.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("sendAsEmail", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string SendAsEmail { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "gmail/v1/users/{userId}/settings/sendAs/{sendAsEmail}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "userId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = "me",
                            Pattern = null,
                        });
                        RequestParameters.Add("sendAsEmail", new Google.Apis.Discovery.Parameter
                        {
                            Name = "sendAsEmail",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Lists the send-as aliases for the specified account. The result includes the primary send-as address
                /// associated with the account as well as any custom "from" aliases.
                /// </summary>
                /// <param name="userId">
                /// User's email address. The special value "me" can be used to indicate the authenticated user.
                /// </param>
                public virtual ListRequest List(string userId)
                {
                    return new ListRequest(this.service, userId);
                }

                /// <summary>
                /// Lists the send-as aliases for the specified account. The result includes the primary send-as address
                /// associated with the account as well as any custom "from" aliases.
                /// </summary>
                public class ListRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.ListSendAsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string userId) : base(service)
                    {
                        UserId = userId;
                        InitParameters();
                    }

                    /// <summary>
                    /// User's email address. The special value "me" can be used to indicate the authenticated user.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string UserId { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "gmail/v1/users/{userId}/settings/sendAs";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "userId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = "me",
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Patch the specified send-as alias.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="userId">
                /// User's email address. The special value "me" can be used to indicate the authenticated user.
                /// </param>
                /// <param name="sendAsEmail">The send-as alias to be updated.</param>
                public virtual PatchRequest Patch(Google.Apis.Gmail.v1.Data.SendAs body, string userId, string sendAsEmail)
                {
                    return new PatchRequest(this.service, body, userId, sendAsEmail);
                }

                /// <summary>Patch the specified send-as alias.</summary>
                public class PatchRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.SendAs>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Gmail.v1.Data.SendAs body, string userId, string sendAsEmail) : base(service)
                    {
                        UserId = userId;
                        SendAsEmail = sendAsEmail;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// User's email address. The special value "me" can be used to indicate the authenticated user.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string UserId { get; private set; }

                    /// <summary>The send-as alias to be updated.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("sendAsEmail", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string SendAsEmail { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Gmail.v1.Data.SendAs Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "gmail/v1/users/{userId}/settings/sendAs/{sendAsEmail}";

                    /// <summary>Initializes Patch parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "userId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = "me",
                            Pattern = null,
                        });
                        RequestParameters.Add("sendAsEmail", new Google.Apis.Discovery.Parameter
                        {
                            Name = "sendAsEmail",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Updates a send-as alias. If a signature is provided, Gmail will sanitize the HTML before saving it
                /// with the alias. Addresses other than the primary address for the account can only be updated by
                /// service account clients that have been delegated domain-wide authority.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="userId">
                /// User's email address. The special value "me" can be used to indicate the authenticated user.
                /// </param>
                /// <param name="sendAsEmail">The send-as alias to be updated.</param>
                public virtual UpdateRequest Update(Google.Apis.Gmail.v1.Data.SendAs body, string userId, string sendAsEmail)
                {
                    return new UpdateRequest(this.service, body, userId, sendAsEmail);
                }

                /// <summary>
                /// Updates a send-as alias. If a signature is provided, Gmail will sanitize the HTML before saving it
                /// with the alias. Addresses other than the primary address for the account can only be updated by
                /// service account clients that have been delegated domain-wide authority.
                /// </summary>
                public class UpdateRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.SendAs>
                {
                    /// <summary>Constructs a new Update request.</summary>
                    public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Gmail.v1.Data.SendAs body, string userId, string sendAsEmail) : base(service)
                    {
                        UserId = userId;
                        SendAsEmail = sendAsEmail;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// User's email address. The special value "me" can be used to indicate the authenticated user.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string UserId { get; private set; }

                    /// <summary>The send-as alias to be updated.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("sendAsEmail", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string SendAsEmail { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Gmail.v1.Data.SendAs Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "update";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PUT";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "gmail/v1/users/{userId}/settings/sendAs/{sendAsEmail}";

                    /// <summary>Initializes Update parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "userId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = "me",
                            Pattern = null,
                        });
                        RequestParameters.Add("sendAsEmail", new Google.Apis.Discovery.Parameter
                        {
                            Name = "sendAsEmail",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Sends a verification email to the specified send-as alias address. The verification status must be
                /// `pending`. This method is only available to service account clients that have been delegated
                /// domain-wide authority.
                /// </summary>
                /// <param name="userId">
                /// User's email address. The special value "me" can be used to indicate the authenticated user.
                /// </param>
                /// <param name="sendAsEmail">The send-as alias to be verified.</param>
                public virtual VerifyRequest Verify(string userId, string sendAsEmail)
                {
                    return new VerifyRequest(this.service, userId, sendAsEmail);
                }

                /// <summary>
                /// Sends a verification email to the specified send-as alias address. The verification status must be
                /// `pending`. This method is only available to service account clients that have been delegated
                /// domain-wide authority.
                /// </summary>
                public class VerifyRequest : GmailBaseServiceRequest<string>
                {
                    /// <summary>Constructs a new Verify request.</summary>
                    public VerifyRequest(Google.Apis.Services.IClientService service, string userId, string sendAsEmail) : base(service)
                    {
                        UserId = userId;
                        SendAsEmail = sendAsEmail;
                        InitParameters();
                    }

                    /// <summary>
                    /// User's email address. The special value "me" can be used to indicate the authenticated user.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string UserId { get; private set; }

                    /// <summary>The send-as alias to be verified.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("sendAsEmail", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string SendAsEmail { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "verify";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "gmail/v1/users/{userId}/settings/sendAs/{sendAsEmail}/verify";

                    /// <summary>Initializes Verify parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "userId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = "me",
                            Pattern = null,
                        });
                        RequestParameters.Add("sendAsEmail", new Google.Apis.Discovery.Parameter
                        {
                            Name = "sendAsEmail",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Gets the auto-forwarding setting for the specified account.</summary>
            /// <param name="userId">
            /// User's email address. The special value "me" can be used to indicate the authenticated user.
            /// </param>
            public virtual GetAutoForwardingRequest GetAutoForwarding(string userId)
            {
                return new GetAutoForwardingRequest(this.service, userId);
            }

            /// <summary>Gets the auto-forwarding setting for the specified account.</summary>
            public class GetAutoForwardingRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.AutoForwarding>
            {
                /// <summary>Constructs a new GetAutoForwarding request.</summary>
                public GetAutoForwardingRequest(Google.Apis.Services.IClientService service, string userId) : base(service)
                {
                    UserId = userId;
                    InitParameters();
                }

                /// <summary>
                /// User's email address. The special value "me" can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getAutoForwarding";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "gmail/v1/users/{userId}/settings/autoForwarding";

                /// <summary>Initializes GetAutoForwarding parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = "me",
                        Pattern = null,
                    });
                }
            }

            /// <summary>Gets IMAP settings.</summary>
            /// <param name="userId">
            /// User's email address. The special value "me" can be used to indicate the authenticated user.
            /// </param>
            public virtual GetImapRequest GetImap(string userId)
            {
                return new GetImapRequest(this.service, userId);
            }

            /// <summary>Gets IMAP settings.</summary>
            public class GetImapRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.ImapSettings>
            {
                /// <summary>Constructs a new GetImap request.</summary>
                public GetImapRequest(Google.Apis.Services.IClientService service, string userId) : base(service)
                {
                    UserId = userId;
                    InitParameters();
                }

                /// <summary>
                /// User's email address. The special value "me" can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getImap";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "gmail/v1/users/{userId}/settings/imap";

                /// <summary>Initializes GetImap parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = "me",
                        Pattern = null,
                    });
                }
            }

            /// <summary>Gets language settings.</summary>
            /// <param name="userId">
            /// User's email address. The special value "me" can be used to indicate the authenticated user.
            /// </param>
            public virtual GetLanguageRequest GetLanguage(string userId)
            {
                return new GetLanguageRequest(this.service, userId);
            }

            /// <summary>Gets language settings.</summary>
            public class GetLanguageRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.LanguageSettings>
            {
                /// <summary>Constructs a new GetLanguage request.</summary>
                public GetLanguageRequest(Google.Apis.Services.IClientService service, string userId) : base(service)
                {
                    UserId = userId;
                    InitParameters();
                }

                /// <summary>
                /// User's email address. The special value "me" can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getLanguage";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "gmail/v1/users/{userId}/settings/language";

                /// <summary>Initializes GetLanguage parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = "me",
                        Pattern = null,
                    });
                }
            }

            /// <summary>Gets POP settings.</summary>
            /// <param name="userId">
            /// User's email address. The special value "me" can be used to indicate the authenticated user.
            /// </param>
            public virtual GetPopRequest GetPop(string userId)
            {
                return new GetPopRequest(this.service, userId);
            }

            /// <summary>Gets POP settings.</summary>
            public class GetPopRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.PopSettings>
            {
                /// <summary>Constructs a new GetPop request.</summary>
                public GetPopRequest(Google.Apis.Services.IClientService service, string userId) : base(service)
                {
                    UserId = userId;
                    InitParameters();
                }

                /// <summary>
                /// User's email address. The special value "me" can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getPop";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "gmail/v1/users/{userId}/settings/pop";

                /// <summary>Initializes GetPop parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = "me",
                        Pattern = null,
                    });
                }
            }

            /// <summary>Gets vacation responder settings.</summary>
            /// <param name="userId">
            /// User's email address. The special value "me" can be used to indicate the authenticated user.
            /// </param>
            public virtual GetVacationRequest GetVacation(string userId)
            {
                return new GetVacationRequest(this.service, userId);
            }

            /// <summary>Gets vacation responder settings.</summary>
            public class GetVacationRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.VacationSettings>
            {
                /// <summary>Constructs a new GetVacation request.</summary>
                public GetVacationRequest(Google.Apis.Services.IClientService service, string userId) : base(service)
                {
                    UserId = userId;
                    InitParameters();
                }

                /// <summary>
                /// User's email address. The special value "me" can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getVacation";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "gmail/v1/users/{userId}/settings/vacation";

                /// <summary>Initializes GetVacation parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = "me",
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Updates the auto-forwarding setting for the specified account. A verified forwarding address must be
            /// specified when auto-forwarding is enabled. This method is only available to service account clients that
            /// have been delegated domain-wide authority.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="userId">
            /// User's email address. The special value "me" can be used to indicate the authenticated user.
            /// </param>
            public virtual UpdateAutoForwardingRequest UpdateAutoForwarding(Google.Apis.Gmail.v1.Data.AutoForwarding body, string userId)
            {
                return new UpdateAutoForwardingRequest(this.service, body, userId);
            }

            /// <summary>
            /// Updates the auto-forwarding setting for the specified account. A verified forwarding address must be
            /// specified when auto-forwarding is enabled. This method is only available to service account clients that
            /// have been delegated domain-wide authority.
            /// </summary>
            public class UpdateAutoForwardingRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.AutoForwarding>
            {
                /// <summary>Constructs a new UpdateAutoForwarding request.</summary>
                public UpdateAutoForwardingRequest(Google.Apis.Services.IClientService service, Google.Apis.Gmail.v1.Data.AutoForwarding body, string userId) : base(service)
                {
                    UserId = userId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// User's email address. The special value "me" can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Gmail.v1.Data.AutoForwarding Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "updateAutoForwarding";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "gmail/v1/users/{userId}/settings/autoForwarding";

                /// <summary>Initializes UpdateAutoForwarding parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = "me",
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates IMAP settings.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="userId">
            /// User's email address. The special value "me" can be used to indicate the authenticated user.
            /// </param>
            public virtual UpdateImapRequest UpdateImap(Google.Apis.Gmail.v1.Data.ImapSettings body, string userId)
            {
                return new UpdateImapRequest(this.service, body, userId);
            }

            /// <summary>Updates IMAP settings.</summary>
            public class UpdateImapRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.ImapSettings>
            {
                /// <summary>Constructs a new UpdateImap request.</summary>
                public UpdateImapRequest(Google.Apis.Services.IClientService service, Google.Apis.Gmail.v1.Data.ImapSettings body, string userId) : base(service)
                {
                    UserId = userId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// User's email address. The special value "me" can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Gmail.v1.Data.ImapSettings Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "updateImap";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "gmail/v1/users/{userId}/settings/imap";

                /// <summary>Initializes UpdateImap parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = "me",
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Updates language settings. If successful, the return object contains the `displayLanguage` that was
            /// saved for the user, which may differ from the value passed into the request. This is because the
            /// requested `displayLanguage` may not be directly supported by Gmail but have a close variant that is, and
            /// so the variant may be chosen and saved instead.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="userId">
            /// User's email address. The special value "me" can be used to indicate the authenticated user.
            /// </param>
            public virtual UpdateLanguageRequest UpdateLanguage(Google.Apis.Gmail.v1.Data.LanguageSettings body, string userId)
            {
                return new UpdateLanguageRequest(this.service, body, userId);
            }

            /// <summary>
            /// Updates language settings. If successful, the return object contains the `displayLanguage` that was
            /// saved for the user, which may differ from the value passed into the request. This is because the
            /// requested `displayLanguage` may not be directly supported by Gmail but have a close variant that is, and
            /// so the variant may be chosen and saved instead.
            /// </summary>
            public class UpdateLanguageRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.LanguageSettings>
            {
                /// <summary>Constructs a new UpdateLanguage request.</summary>
                public UpdateLanguageRequest(Google.Apis.Services.IClientService service, Google.Apis.Gmail.v1.Data.LanguageSettings body, string userId) : base(service)
                {
                    UserId = userId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// User's email address. The special value "me" can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Gmail.v1.Data.LanguageSettings Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "updateLanguage";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "gmail/v1/users/{userId}/settings/language";

                /// <summary>Initializes UpdateLanguage parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = "me",
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates POP settings.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="userId">
            /// User's email address. The special value "me" can be used to indicate the authenticated user.
            /// </param>
            public virtual UpdatePopRequest UpdatePop(Google.Apis.Gmail.v1.Data.PopSettings body, string userId)
            {
                return new UpdatePopRequest(this.service, body, userId);
            }

            /// <summary>Updates POP settings.</summary>
            public class UpdatePopRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.PopSettings>
            {
                /// <summary>Constructs a new UpdatePop request.</summary>
                public UpdatePopRequest(Google.Apis.Services.IClientService service, Google.Apis.Gmail.v1.Data.PopSettings body, string userId) : base(service)
                {
                    UserId = userId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// User's email address. The special value "me" can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Gmail.v1.Data.PopSettings Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "updatePop";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "gmail/v1/users/{userId}/settings/pop";

                /// <summary>Initializes UpdatePop parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = "me",
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates vacation responder settings.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="userId">
            /// User's email address. The special value "me" can be used to indicate the authenticated user.
            /// </param>
            public virtual UpdateVacationRequest UpdateVacation(Google.Apis.Gmail.v1.Data.VacationSettings body, string userId)
            {
                return new UpdateVacationRequest(this.service, body, userId);
            }

            /// <summary>Updates vacation responder settings.</summary>
            public class UpdateVacationRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.VacationSettings>
            {
                /// <summary>Constructs a new UpdateVacation request.</summary>
                public UpdateVacationRequest(Google.Apis.Services.IClientService service, Google.Apis.Gmail.v1.Data.VacationSettings body, string userId) : base(service)
                {
                    UserId = userId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// User's email address. The special value "me" can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Gmail.v1.Data.VacationSettings Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "updateVacation";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "gmail/v1/users/{userId}/settings/vacation";

                /// <summary>Initializes UpdateVacation parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = "me",
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Threads resource.</summary>
        public virtual ThreadsResource Threads { get; }

        /// <summary>The "threads" collection of methods.</summary>
        public class ThreadsResource
        {
            private const string Resource = "threads";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ThreadsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Immediately and permanently deletes the specified thread. Any messages that belong to the thread are
            /// also deleted. This operation cannot be undone. Prefer `threads.trash` instead.
            /// </summary>
            /// <param name="userId">
            /// The user's email address. The special value `me` can be used to indicate the authenticated user.
            /// </param>
            /// <param name="id">ID of the Thread to delete.</param>
            public virtual DeleteRequest Delete(string userId, string id)
            {
                return new DeleteRequest(this.service, userId, id);
            }

            /// <summary>
            /// Immediately and permanently deletes the specified thread. Any messages that belong to the thread are
            /// also deleted. This operation cannot be undone. Prefer `threads.trash` instead.
            /// </summary>
            public class DeleteRequest : GmailBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string userId, string id) : base(service)
                {
                    UserId = userId;
                    Id = id;
                    InitParameters();
                }

                /// <summary>
                /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>ID of the Thread to delete.</summary>
                [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Id { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "gmail/v1/users/{userId}/threads/{id}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = "me",
                        Pattern = null,
                    });
                    RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Gets the specified thread.</summary>
            /// <param name="userId">
            /// The user's email address. The special value `me` can be used to indicate the authenticated user.
            /// </param>
            /// <param name="id">The ID of the thread to retrieve.</param>
            public virtual GetRequest Get(string userId, string id)
            {
                return new GetRequest(this.service, userId, id);
            }

            /// <summary>Gets the specified thread.</summary>
            public class GetRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.Thread>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string userId, string id) : base(service)
                {
                    UserId = userId;
                    Id = id;
                    InitParameters();
                }

                /// <summary>
                /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>The ID of the thread to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Id { get; private set; }

                /// <summary>The format to return the messages in.</summary>
                [Google.Apis.Util.RequestParameterAttribute("format", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<FormatEnum> Format { get; set; }

                /// <summary>The format to return the messages in.</summary>
                public enum FormatEnum
                {
                    /// <summary>
                    /// Returns the full email message data with body content parsed in the `payload` field; the `raw`
                    /// field is not used. Format cannot be used when accessing the api using the gmail.metadata scope.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("full")]
                    Full = 0,

                    /// <summary>Returns only email message IDs, labels, and email headers.</summary>
                    [Google.Apis.Util.StringValueAttribute("metadata")]
                    Metadata = 1,

                    /// <summary>
                    /// Returns only email message IDs and labels; does not return the email headers, body, or payload.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("minimal")]
                    Minimal = 2,
                }

                /// <summary>When given and format is METADATA, only include headers specified.</summary>
                [Google.Apis.Util.RequestParameterAttribute("metadataHeaders", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> MetadataHeaders { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "gmail/v1/users/{userId}/threads/{id}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = "me",
                        Pattern = null,
                    });
                    RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("format", new Google.Apis.Discovery.Parameter
                    {
                        Name = "format",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = "full",
                        Pattern = null,
                    });
                    RequestParameters.Add("metadataHeaders", new Google.Apis.Discovery.Parameter
                    {
                        Name = "metadataHeaders",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists the threads in the user's mailbox.</summary>
            /// <param name="userId">
            /// The user's email address. The special value `me` can be used to indicate the authenticated user.
            /// </param>
            public virtual ListRequest List(string userId)
            {
                return new ListRequest(this.service, userId);
            }

            /// <summary>Lists the threads in the user's mailbox.</summary>
            public class ListRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.ListThreadsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string userId) : base(service)
                {
                    UserId = userId;
                    InitParameters();
                }

                /// <summary>
                /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>Include threads from `SPAM` and `TRASH` in the results.</summary>
                [Google.Apis.Util.RequestParameterAttribute("includeSpamTrash", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> IncludeSpamTrash { get; set; }

                /// <summary>Only return threads with labels that match all of the specified label IDs.</summary>
                [Google.Apis.Util.RequestParameterAttribute("labelIds", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> LabelIds { get; set; }

                /// <summary>
                /// Maximum number of threads to return. This field defaults to 100. The maximum allowed value for this
                /// field is 500.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> MaxResults { get; set; }

                /// <summary>Page token to retrieve a specific page of results in the list.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// Only return threads matching the specified query. Supports the same query format as the Gmail search
                /// box. For example, `"from:someuser@example.com rfc822msgid: is:unread"`. Parameter cannot be used
                /// when accessing the api using the gmail.metadata scope.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("q", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Q { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "gmail/v1/users/{userId}/threads";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = "me",
                        Pattern = null,
                    });
                    RequestParameters.Add("includeSpamTrash", new Google.Apis.Discovery.Parameter
                    {
                        Name = "includeSpamTrash",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = "false",
                        Pattern = null,
                    });
                    RequestParameters.Add("labelIds", new Google.Apis.Discovery.Parameter
                    {
                        Name = "labelIds",
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
                        DefaultValue = "100",
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
                    RequestParameters.Add("q", new Google.Apis.Discovery.Parameter
                    {
                        Name = "q",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Modifies the labels applied to the thread. This applies to all messages in the thread.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="userId">
            /// The user's email address. The special value `me` can be used to indicate the authenticated user.
            /// </param>
            /// <param name="id">The ID of the thread to modify.</param>
            public virtual ModifyRequest Modify(Google.Apis.Gmail.v1.Data.ModifyThreadRequest body, string userId, string id)
            {
                return new ModifyRequest(this.service, body, userId, id);
            }

            /// <summary>
            /// Modifies the labels applied to the thread. This applies to all messages in the thread.
            /// </summary>
            public class ModifyRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.Thread>
            {
                /// <summary>Constructs a new Modify request.</summary>
                public ModifyRequest(Google.Apis.Services.IClientService service, Google.Apis.Gmail.v1.Data.ModifyThreadRequest body, string userId, string id) : base(service)
                {
                    UserId = userId;
                    Id = id;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>The ID of the thread to modify.</summary>
                [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Id { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Gmail.v1.Data.ModifyThreadRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "modify";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "gmail/v1/users/{userId}/threads/{id}/modify";

                /// <summary>Initializes Modify parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = "me",
                        Pattern = null,
                    });
                    RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Moves the specified thread to the trash. Any messages that belong to the thread are also moved to the
            /// trash.
            /// </summary>
            /// <param name="userId">
            /// The user's email address. The special value `me` can be used to indicate the authenticated user.
            /// </param>
            /// <param name="id">The ID of the thread to Trash.</param>
            public virtual TrashRequest Trash(string userId, string id)
            {
                return new TrashRequest(this.service, userId, id);
            }

            /// <summary>
            /// Moves the specified thread to the trash. Any messages that belong to the thread are also moved to the
            /// trash.
            /// </summary>
            public class TrashRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.Thread>
            {
                /// <summary>Constructs a new Trash request.</summary>
                public TrashRequest(Google.Apis.Services.IClientService service, string userId, string id) : base(service)
                {
                    UserId = userId;
                    Id = id;
                    InitParameters();
                }

                /// <summary>
                /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>The ID of the thread to Trash.</summary>
                [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Id { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "trash";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "gmail/v1/users/{userId}/threads/{id}/trash";

                /// <summary>Initializes Trash parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = "me",
                        Pattern = null,
                    });
                    RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Removes the specified thread from the trash. Any messages that belong to the thread are also removed
            /// from the trash.
            /// </summary>
            /// <param name="userId">
            /// The user's email address. The special value `me` can be used to indicate the authenticated user.
            /// </param>
            /// <param name="id">The ID of the thread to remove from Trash.</param>
            public virtual UntrashRequest Untrash(string userId, string id)
            {
                return new UntrashRequest(this.service, userId, id);
            }

            /// <summary>
            /// Removes the specified thread from the trash. Any messages that belong to the thread are also removed
            /// from the trash.
            /// </summary>
            public class UntrashRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.Thread>
            {
                /// <summary>Constructs a new Untrash request.</summary>
                public UntrashRequest(Google.Apis.Services.IClientService service, string userId, string id) : base(service)
                {
                    UserId = userId;
                    Id = id;
                    InitParameters();
                }

                /// <summary>
                /// The user's email address. The special value `me` can be used to indicate the authenticated user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>The ID of the thread to remove from Trash.</summary>
                [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Id { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "untrash";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "gmail/v1/users/{userId}/threads/{id}/untrash";

                /// <summary>Initializes Untrash parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = "me",
                        Pattern = null,
                    });
                    RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the current user's Gmail profile.</summary>
        /// <param name="userId">
        /// The user's email address. The special value `me` can be used to indicate the authenticated user.
        /// </param>
        public virtual GetProfileRequest GetProfile(string userId)
        {
            return new GetProfileRequest(this.service, userId);
        }

        /// <summary>Gets the current user's Gmail profile.</summary>
        public class GetProfileRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.Profile>
        {
            /// <summary>Constructs a new GetProfile request.</summary>
            public GetProfileRequest(Google.Apis.Services.IClientService service, string userId) : base(service)
            {
                UserId = userId;
                InitParameters();
            }

            /// <summary>
            /// The user's email address. The special value `me` can be used to indicate the authenticated user.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getProfile";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "gmail/v1/users/{userId}/profile";

            /// <summary>Initializes GetProfile parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = "me",
                    Pattern = null,
                });
            }
        }

        /// <summary>Stop receiving push notifications for the given user mailbox.</summary>
        /// <param name="userId">
        /// The user's email address. The special value `me` can be used to indicate the authenticated user.
        /// </param>
        public virtual StopRequest Stop(string userId)
        {
            return new StopRequest(this.service, userId);
        }

        /// <summary>Stop receiving push notifications for the given user mailbox.</summary>
        public class StopRequest : GmailBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Stop request.</summary>
            public StopRequest(Google.Apis.Services.IClientService service, string userId) : base(service)
            {
                UserId = userId;
                InitParameters();
            }

            /// <summary>
            /// The user's email address. The special value `me` can be used to indicate the authenticated user.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "stop";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "gmail/v1/users/{userId}/stop";

            /// <summary>Initializes Stop parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = "me",
                    Pattern = null,
                });
            }
        }

        /// <summary>Set up or update a push notification watch on the given user mailbox.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="userId">
        /// The user's email address. The special value `me` can be used to indicate the authenticated user.
        /// </param>
        public virtual WatchRequest Watch(Google.Apis.Gmail.v1.Data.WatchRequest body, string userId)
        {
            return new WatchRequest(this.service, body, userId);
        }

        /// <summary>Set up or update a push notification watch on the given user mailbox.</summary>
        public class WatchRequest : GmailBaseServiceRequest<Google.Apis.Gmail.v1.Data.WatchResponse>
        {
            /// <summary>Constructs a new Watch request.</summary>
            public WatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Gmail.v1.Data.WatchRequest body, string userId) : base(service)
            {
                UserId = userId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The user's email address. The special value `me` can be used to indicate the authenticated user.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Gmail.v1.Data.WatchRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "watch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "gmail/v1/users/{userId}/watch";

            /// <summary>Initializes Watch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = "me",
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.Gmail.v1.Data
{
    /// <summary>Auto-forwarding settings for an account.</summary>
    public class AutoForwarding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The state that a message should be left in after it has been forwarded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disposition")]
        public virtual string Disposition { get; set; }

        /// <summary>
        /// Email address to which all incoming messages are forwarded. This email address must be a verified member of
        /// the forwarding addresses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailAddress")]
        public virtual string EmailAddress { get; set; }

        /// <summary>Whether all incoming mail is automatically forwarded to another address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class BatchDeleteMessagesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The IDs of the messages to delete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ids")]
        public virtual System.Collections.Generic.IList<string> Ids { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class BatchModifyMessagesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of label IDs to add to messages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addLabelIds")]
        public virtual System.Collections.Generic.IList<string> AddLabelIds { get; set; }

        /// <summary>The IDs of the messages to modify. There is a limit of 1000 ids per request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ids")]
        public virtual System.Collections.Generic.IList<string> Ids { get; set; }

        /// <summary>A list of label IDs to remove from messages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("removeLabelIds")]
        public virtual System.Collections.Generic.IList<string> RemoveLabelIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The client-side encryption (CSE) configuration for the email address of an authenticated user. Gmail uses CSE
    /// configurations to save drafts of client-side encrypted email messages, and to sign and send encrypted email
    /// messages. For administrators managing identities and keypairs for users in their organization, requests require
    /// authorization with a [service account](https://developers.google.com/identity/protocols/OAuth2ServiceAccount)
    /// that has [domain-wide delegation
    /// authority](https://developers.google.com/identity/protocols/OAuth2ServiceAccount#delegatingauthority) to
    /// impersonate users with the `https://www.googleapis.com/auth/gmail.settings.basic` scope. For users managing
    /// their own identities and keypairs, requests require [hardware key
    /// encryption](https://support.google.com/a/answer/14153163) turned on and configured.
    /// </summary>
    public class CseIdentity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The email address for the sending identity. The email address must be the primary email address of the
        /// authenticated user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailAddress")]
        public virtual string EmailAddress { get; set; }

        /// <summary>If a key pair is associated, the ID of the key pair, CseKeyPair.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryKeyPairId")]
        public virtual string PrimaryKeyPairId { get; set; }

        /// <summary>
        /// The configuration of a CSE identity that uses different key pairs for signing and encryption.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signAndEncryptKeyPairs")]
        public virtual SignAndEncryptKeyPairs SignAndEncryptKeyPairs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A client-side encryption S/MIME key pair, which is comprised of a public key, its certificate chain, and
    /// metadata for its paired private key. Gmail uses the key pair to complete the following tasks: - Sign outgoing
    /// client-side encrypted messages. - Save and reopen drafts of client-side encrypted messages. - Save and reopen
    /// sent messages. - Decrypt incoming or archived S/MIME messages. For administrators managing identities and
    /// keypairs for users in their organization, requests require authorization with a [service
    /// account](https://developers.google.com/identity/protocols/OAuth2ServiceAccount) that has [domain-wide delegation
    /// authority](https://developers.google.com/identity/protocols/OAuth2ServiceAccount#delegatingauthority) to
    /// impersonate users with the `https://www.googleapis.com/auth/gmail.settings.basic` scope. For users managing
    /// their own identities and keypairs, requests require [hardware key
    /// encryption](https://support.google.com/a/answer/14153163) turned on and configured.
    /// </summary>
    public class CseKeyPair : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _disableTimeRaw;

        private object _disableTime;

        /// <summary>
        /// Output only. If a key pair is set to `DISABLED`, the time that the key pair's state changed from `ENABLED`
        /// to `DISABLED`. This field is present only when the key pair is in state `DISABLED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableTime")]
        public virtual string DisableTimeRaw
        {
            get => _disableTimeRaw;
            set
            {
                _disableTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _disableTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DisableTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DisableTimeDateTimeOffset instead.")]
        public virtual object DisableTime
        {
            get => _disableTime;
            set
            {
                _disableTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _disableTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DisableTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DisableTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DisableTimeRaw);
            set => DisableTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. The current state of the key pair.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enablementState")]
        public virtual string EnablementState { get; set; }

        /// <summary>Output only. The immutable ID for the client-side encryption S/MIME key pair.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyPairId")]
        public virtual string KeyPairId { get; set; }

        /// <summary>
        /// Output only. The public key and its certificate chain, in
        /// [PEM](https://en.wikipedia.org/wiki/Privacy-Enhanced_Mail) format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pem")]
        public virtual string Pem { get; set; }

        /// <summary>
        /// Input only. The public key and its certificate chain. The chain must be in
        /// [PKCS#7](https://en.wikipedia.org/wiki/PKCS_7) format and use PEM encoding and ASCII armor.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pkcs7")]
        public virtual string Pkcs7 { get; set; }

        /// <summary>Metadata for instances of this key pair's private key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateKeyMetadata")]
        public virtual System.Collections.Generic.IList<CsePrivateKeyMetadata> PrivateKeyMetadata { get; set; }

        /// <summary>Output only. The email address identities that are specified on the leaf certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subjectEmailAddresses")]
        public virtual System.Collections.Generic.IList<string> SubjectEmailAddresses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for a private key instance.</summary>
    public class CsePrivateKeyMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Metadata for hardware keys.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hardwareKeyMetadata")]
        public virtual HardwareKeyMetadata HardwareKeyMetadata { get; set; }

        /// <summary>
        /// Metadata for a private key instance managed by an external key access control list service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kaclsKeyMetadata")]
        public virtual KaclsKeyMetadata KaclsKeyMetadata { get; set; }

        /// <summary>Output only. The immutable ID for the private key metadata instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateKeyMetadataId")]
        public virtual string PrivateKeyMetadataId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Settings for a delegate. Delegates can read, send, and delete messages, as well as view and add contacts, for
    /// the delegator's account. See "Set up mail delegation" for more information about delegates.
    /// </summary>
    public class Delegate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The email address of the delegate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delegateEmail")]
        public virtual string DelegateEmail { get; set; }

        /// <summary>
        /// Indicates whether this address has been verified and can act as a delegate for the account. Read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verificationStatus")]
        public virtual string VerificationStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Requests to turn off a client-side encryption key pair.</summary>
    public class DisableCseKeyPairRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A draft email in the user's mailbox.</summary>
    public class Draft : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The immutable ID of the draft.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The message content of the draft.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual Message Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Requests to turn on a client-side encryption key pair.</summary>
    public class EnableCseKeyPairRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Resource definition for Gmail filters. Filters apply to specific messages instead of an entire email thread.
    /// </summary>
    public class Filter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Action that the filter performs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual FilterAction Action { get; set; }

        /// <summary>Matching criteria for the filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("criteria")]
        public virtual FilterCriteria Criteria { get; set; }

        /// <summary>The server assigned ID of the filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A set of actions to perform on a message.</summary>
    public class FilterAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of labels to add to the message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addLabelIds")]
        public virtual System.Collections.Generic.IList<string> AddLabelIds { get; set; }

        /// <summary>Email address that the message should be forwarded to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forward")]
        public virtual string Forward { get; set; }

        /// <summary>List of labels to remove from the message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("removeLabelIds")]
        public virtual System.Collections.Generic.IList<string> RemoveLabelIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message matching criteria.</summary>
    public class FilterCriteria : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the response should exclude chats.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludeChats")]
        public virtual System.Nullable<bool> ExcludeChats { get; set; }

        /// <summary>The sender's display name or email address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("from")]
        public virtual string From { get; set; }

        /// <summary>Whether the message has any attachment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasAttachment")]
        public virtual System.Nullable<bool> HasAttachment { get; set; }

        /// <summary>
        /// Only return messages not matching the specified query. Supports the same query format as the Gmail search
        /// box. For example, `"from:someuser@example.com rfc822msgid: is:unread"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("negatedQuery")]
        public virtual string NegatedQuery { get; set; }

        /// <summary>
        /// Only return messages matching the specified query. Supports the same query format as the Gmail search box.
        /// For example, `"from:someuser@example.com rfc822msgid: is:unread"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>The size of the entire RFC822 message in bytes, including all headers and attachments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("size")]
        public virtual System.Nullable<int> Size { get; set; }

        /// <summary>How the message size in bytes should be in relation to the size field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeComparison")]
        public virtual string SizeComparison { get; set; }

        /// <summary>
        /// Case-insensitive phrase found in the message's subject. Trailing and leading whitespace are be trimmed and
        /// adjacent spaces are collapsed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subject")]
        public virtual string Subject { get; set; }

        /// <summary>
        /// The recipient's display name or email address. Includes recipients in the "to", "cc", and "bcc" header
        /// fields. You can use simply the local part of the email address. For example, "example" and "example@" both
        /// match "example@gmail.com". This field is case-insensitive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("to")]
        public virtual string To { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings for a forwarding address.</summary>
    public class ForwardingAddress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An email address to which messages can be forwarded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forwardingEmail")]
        public virtual string ForwardingEmail { get; set; }

        /// <summary>Indicates whether this address has been verified and is usable for forwarding. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verificationStatus")]
        public virtual string VerificationStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata for hardware keys. If [hardware key encryption](https://support.google.com/a/answer/14153163) is set up
    /// for the Google Workspace organization, users can optionally store their private key on their smart card and use
    /// it to sign and decrypt email messages in Gmail by inserting their smart card into a reader attached to their
    /// Windows device.
    /// </summary>
    public class HardwareKeyMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description about the hardware key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A record of a change to the user's mailbox. Each history change may affect multiple messages in multiple ways.
    /// </summary>
    public class History : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The mailbox sequence ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<ulong> Id { get; set; }

        /// <summary>Labels added to messages in this history record.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelsAdded")]
        public virtual System.Collections.Generic.IList<HistoryLabelAdded> LabelsAdded { get; set; }

        /// <summary>Labels removed from messages in this history record.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelsRemoved")]
        public virtual System.Collections.Generic.IList<HistoryLabelRemoved> LabelsRemoved { get; set; }

        /// <summary>
        /// List of messages changed in this history record. The fields for specific change types, such as
        /// `messagesAdded` may duplicate messages in this field. We recommend using the specific change-type fields
        /// instead of this.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<Message> Messages { get; set; }

        /// <summary>Messages added to the mailbox in this history record.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messagesAdded")]
        public virtual System.Collections.Generic.IList<HistoryMessageAdded> MessagesAdded { get; set; }

        /// <summary>Messages deleted (not Trashed) from the mailbox in this history record.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messagesDeleted")]
        public virtual System.Collections.Generic.IList<HistoryMessageDeleted> MessagesDeleted { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class HistoryLabelAdded : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Label IDs added to the message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelIds")]
        public virtual System.Collections.Generic.IList<string> LabelIds { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual Message Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class HistoryLabelRemoved : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Label IDs removed from the message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelIds")]
        public virtual System.Collections.Generic.IList<string> LabelIds { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual Message Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class HistoryMessageAdded : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual Message Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class HistoryMessageDeleted : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual Message Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>IMAP settings for an account.</summary>
    public class ImapSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If this value is true, Gmail will immediately expunge a message when it is marked as deleted in IMAP.
        /// Otherwise, Gmail will wait for an update from the client before expunging messages marked as deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoExpunge")]
        public virtual System.Nullable<bool> AutoExpunge { get; set; }

        /// <summary>Whether IMAP is enabled for the account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>
        /// The action that will be executed on a message when it is marked as deleted and expunged from the last
        /// visible IMAP folder.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expungeBehavior")]
        public virtual string ExpungeBehavior { get; set; }

        /// <summary>
        /// An optional limit on the number of messages that an IMAP folder may contain. Legal values are 0, 1000, 2000,
        /// 5000 or 10000. A value of zero is interpreted to mean that there is no limit.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxFolderSize")]
        public virtual System.Nullable<int> MaxFolderSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata for private keys managed by an external key access control list service. For details about managing key
    /// access, see [Google Workspace CSE API Reference](https://developers.google.com/workspace/cse/reference).
    /// </summary>
    public class KaclsKeyMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Opaque data generated and used by the key access control list service. Maximum size: 8 KiB.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kaclsData")]
        public virtual string KaclsData { get; set; }

        /// <summary>The URI of the key access control list service that manages the private key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kaclsUri")]
        public virtual string KaclsUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Labels are used to categorize messages and threads within the user's mailbox. The maximum number of labels
    /// supported for a user's mailbox is 10,000.
    /// </summary>
    public class Label : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The color to assign to the label. Color is only available for labels that have their `type` set to `user`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual LabelColor Color { get; set; }

        /// <summary>The immutable ID of the label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The visibility of the label in the label list in the Gmail web interface.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelListVisibility")]
        public virtual string LabelListVisibility { get; set; }

        /// <summary>
        /// The visibility of messages with this label in the message list in the Gmail web interface.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageListVisibility")]
        public virtual string MessageListVisibility { get; set; }

        /// <summary>The total number of messages with the label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messagesTotal")]
        public virtual System.Nullable<int> MessagesTotal { get; set; }

        /// <summary>The number of unread messages with the label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messagesUnread")]
        public virtual System.Nullable<int> MessagesUnread { get; set; }

        /// <summary>The display name of the label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The total number of threads with the label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threadsTotal")]
        public virtual System.Nullable<int> ThreadsTotal { get; set; }

        /// <summary>The number of unread threads with the label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threadsUnread")]
        public virtual System.Nullable<int> ThreadsUnread { get; set; }

        /// <summary>
        /// The owner type for the label. User labels are created by the user and can be modified and deleted by the
        /// user and can be applied to any message or thread. System labels are internally created and cannot be added,
        /// modified, or deleted. System labels may be able to be applied to or removed from messages and threads under
        /// some circumstances but this is not guaranteed. For example, users can apply and remove the `INBOX` and
        /// `UNREAD` labels from messages and threads, but cannot apply or remove the `DRAFTS` or `SENT` labels from
        /// messages or threads.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class LabelColor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The background color represented as hex string #RRGGBB (ex #000000). This field is required in order to set
        /// the color of a label. Only the following predefined set of color values are allowed: \#000000, #434343,
        /// #666666, #999999, #cccccc, #efefef, #f3f3f3, #ffffff, \#fb4c2f, #ffad47, #fad165, #16a766, #43d692, #4a86e8,
        /// #a479e2, #f691b3, \#f6c5be, #ffe6c7, #fef1d1, #b9e4d0, #c6f3de, #c9daf8, #e4d7f5, #fcdee8, \#efa093,
        /// #ffd6a2, #fce8b3, #89d3b2, #a0eac9, #a4c2f4, #d0bcf1, #fbc8d9, \#e66550, #ffbc6b, #fcda83, #44b984, #68dfa9,
        /// #6d9eeb, #b694e8, #f7a7c0, \#cc3a21, #eaa041, #f2c960, #149e60, #3dc789, #3c78d8, #8e63ce, #e07798,
        /// \#ac2b16, #cf8933, #d5ae49, #0b804b, #2a9c68, #285bac, #653e9b, #b65775, \#822111, #a46a21, #aa8831,
        /// #076239, #1a764d, #1c4587, #41236d, #83334c \#464646, #e7e7e7, #0d3472, #b6cff5, #0d3b44, #98d7e4, #3d188e,
        /// #e3d7ff, \#711a36, #fbd3e0, #8a1c0a, #f2b2a8, #7a2e0b, #ffc8af, #7a4706, #ffdeb5, \#594c05, #fbe983,
        /// #684e07, #fdedc1, #0b4f30, #b3efd3, #04502e, #a2dcc1, \#c2c2c2, #4986e7, #2da2bb, #b99aff, #994a64, #f691b2,
        /// #ff7537, #ffad46, \#662e37, #ebdbde, #cca6ac, #094228, #42d692, #16a765
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backgroundColor")]
        public virtual string BackgroundColor { get; set; }

        /// <summary>
        /// The text color of the label, represented as hex string. This field is required in order to set the color of
        /// a label. Only the following predefined set of color values are allowed: \#000000, #434343, #666666, #999999,
        /// #cccccc, #efefef, #f3f3f3, #ffffff, \#fb4c2f, #ffad47, #fad165, #16a766, #43d692, #4a86e8, #a479e2, #f691b3,
        /// \#f6c5be, #ffe6c7, #fef1d1, #b9e4d0, #c6f3de, #c9daf8, #e4d7f5, #fcdee8, \#efa093, #ffd6a2, #fce8b3,
        /// #89d3b2, #a0eac9, #a4c2f4, #d0bcf1, #fbc8d9, \#e66550, #ffbc6b, #fcda83, #44b984, #68dfa9, #6d9eeb, #b694e8,
        /// #f7a7c0, \#cc3a21, #eaa041, #f2c960, #149e60, #3dc789, #3c78d8, #8e63ce, #e07798, \#ac2b16, #cf8933,
        /// #d5ae49, #0b804b, #2a9c68, #285bac, #653e9b, #b65775, \#822111, #a46a21, #aa8831, #076239, #1a764d, #1c4587,
        /// #41236d, #83334c \#464646, #e7e7e7, #0d3472, #b6cff5, #0d3b44, #98d7e4, #3d188e, #e3d7ff, \#711a36, #fbd3e0,
        /// #8a1c0a, #f2b2a8, #7a2e0b, #ffc8af, #7a4706, #ffdeb5, \#594c05, #fbe983, #684e07, #fdedc1, #0b4f30, #b3efd3,
        /// #04502e, #a2dcc1, \#c2c2c2, #4986e7, #2da2bb, #b99aff, #994a64, #f691b2, #ff7537, #ffad46, \#662e37,
        /// #ebdbde, #cca6ac, #094228, #42d692, #16a765
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textColor")]
        public virtual string TextColor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Language settings for an account. These settings correspond to the "Language settings" feature in the web
    /// interface.
    /// </summary>
    public class LanguageSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The language to display Gmail in, formatted as an RFC 3066 Language Tag (for example `en-GB`, `fr` or `ja`
        /// for British English, French, or Japanese respectively). The set of languages supported by Gmail evolves over
        /// time, so please refer to the "Language" dropdown in the Gmail settings for all available options, as
        /// described in the language settings help article. For a table of sample values, see [Manage language
        /// settings](https://developers.google.com/workspace/gmail/api/guides/language-settings). Not all Gmail clients
        /// can display the same set of languages. In the case that a user's display language is not available for use
        /// on a particular client, said client automatically chooses to display in the closest supported variant (or a
        /// reasonable default).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayLanguage")]
        public virtual string DisplayLanguage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListCseIdentitiesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>One page of the list of CSE identities configured for the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cseIdentities")]
        public virtual System.Collections.Generic.IList<CseIdentity> CseIdentities { get; set; }

        /// <summary>
        /// Pagination token to be passed to a subsequent ListCseIdentities call in order to retrieve the next page of
        /// identities. If this value is not returned or is the empty string, then no further pages remain.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListCseKeyPairsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>One page of the list of CSE key pairs installed for the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cseKeyPairs")]
        public virtual System.Collections.Generic.IList<CseKeyPair> CseKeyPairs { get; set; }

        /// <summary>
        /// Pagination token to be passed to a subsequent ListCseKeyPairs call in order to retrieve the next page of key
        /// pairs. If this value is not returned, then no further pages remain.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the ListDelegates method.</summary>
    public class ListDelegatesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of the user's delegates (with any verification status). If an account doesn't have delegates, this
        /// field doesn't appear.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delegates")]
        public virtual System.Collections.Generic.IList<Delegate> Delegates { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListDraftsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of drafts. Note that the `Message` property in each `Draft` resource only contains an `id` and a
        /// `threadId`. The
        /// [`messages.get`](https://developers.google.com/workspace/gmail/api/v1/reference/users/messages/get) method
        /// can fetch additional message details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("drafts")]
        public virtual System.Collections.Generic.IList<Draft> Drafts { get; set; }

        /// <summary>Token to retrieve the next page of results in the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Estimated total number of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultSizeEstimate")]
        public virtual System.Nullable<long> ResultSizeEstimate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the ListFilters method.</summary>
    public class ListFiltersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of a user's filters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual System.Collections.Generic.IList<Filter> Filter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the ListForwardingAddresses method.</summary>
    public class ListForwardingAddressesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of addresses that may be used for forwarding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forwardingAddresses")]
        public virtual System.Collections.Generic.IList<ForwardingAddress> ForwardingAddresses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListHistoryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of history records. Any `messages` contained in the response will typically only have `id` and
        /// `threadId` fields populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("history")]
        public virtual System.Collections.Generic.IList<History> History { get; set; }

        /// <summary>The ID of the mailbox's current history record.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("historyId")]
        public virtual System.Nullable<ulong> HistoryId { get; set; }

        /// <summary>Page token to retrieve the next page of results in the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListLabelsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of labels. Note that each label resource only contains an `id`, `name`, `messageListVisibility`,
        /// `labelListVisibility`, and `type`. The
        /// [`labels.get`](https://developers.google.com/workspace/gmail/api/v1/reference/users/labels/get) method can
        /// fetch additional label details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<Label> Labels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListMessagesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of messages. Note that each message resource contains only an `id` and a `threadId`. Additional message
        /// details can be fetched using the messages.get method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<Message> Messages { get; set; }

        /// <summary>Token to retrieve the next page of results in the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Estimated total number of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultSizeEstimate")]
        public virtual System.Nullable<long> ResultSizeEstimate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the ListSendAs method.</summary>
    public class ListSendAsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of send-as aliases.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sendAs")]
        public virtual System.Collections.Generic.IList<SendAs> SendAs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListSmimeInfoResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of SmimeInfo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("smimeInfo")]
        public virtual System.Collections.Generic.IList<SmimeInfo> SmimeInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListThreadsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Page token to retrieve the next page of results in the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Estimated total number of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultSizeEstimate")]
        public virtual System.Nullable<long> ResultSizeEstimate { get; set; }

        /// <summary>
        /// List of threads. Note that each thread resource does not contain a list of `messages`. The list of
        /// `messages` for a given thread can be fetched using the
        /// [`threads.get`](https://developers.google.com/workspace/gmail/api/v1/reference/users/threads/get) method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threads")]
        public virtual System.Collections.Generic.IList<Thread> Threads { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An email message.</summary>
    public class Message : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the last history record that modified this message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("historyId")]
        public virtual System.Nullable<ulong> HistoryId { get; set; }

        /// <summary>The immutable ID of the message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// The internal message creation timestamp (epoch ms), which determines ordering in the inbox. For normal
        /// SMTP-received email, this represents the time the message was originally accepted by Google, which is more
        /// reliable than the `Date` header. However, for API-migrated mail, it can be configured by client to be based
        /// on the `Date` header.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internalDate")]
        public virtual System.Nullable<long> InternalDate { get; set; }

        /// <summary>List of IDs of labels applied to this message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelIds")]
        public virtual System.Collections.Generic.IList<string> LabelIds { get; set; }

        /// <summary>The parsed email structure in the message parts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payload")]
        public virtual MessagePart Payload { get; set; }

        /// <summary>
        /// The entire email message in an RFC 2822 formatted and base64url encoded string. Returned in `messages.get`
        /// and `drafts.get` responses when the `format=RAW` parameter is supplied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("raw")]
        public virtual string Raw { get; set; }

        /// <summary>Estimated size in bytes of the message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeEstimate")]
        public virtual System.Nullable<int> SizeEstimate { get; set; }

        /// <summary>A short part of the message text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
        public virtual string Snippet { get; set; }

        /// <summary>
        /// The ID of the thread the message belongs to. To add a message or draft to a thread, the following criteria
        /// must be met: 1. The requested `threadId` must be specified on the `Message` or `Draft.Message` you supply
        /// with your request. 2. The `References` and `In-Reply-To` headers must be set in compliance with the [RFC
        /// 2822](https://tools.ietf.org/html/rfc2822) standard. 3. The `Subject` headers must match.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threadId")]
        public virtual string ThreadId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single MIME message part.</summary>
    public class MessagePart : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The message part body for this part, which may be empty for container MIME message parts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("body")]
        public virtual MessagePartBody Body { get; set; }

        /// <summary>
        /// The filename of the attachment. Only present if this message part represents an attachment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filename")]
        public virtual string Filename { get; set; }

        /// <summary>
        /// List of headers on this message part. For the top-level message part, representing the entire message
        /// payload, it will contain the standard RFC 2822 email headers such as `To`, `From`, and `Subject`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headers")]
        public virtual System.Collections.Generic.IList<MessagePartHeader> Headers { get; set; }

        /// <summary>The MIME type of the message part.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>The immutable ID of the message part.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partId")]
        public virtual string PartId { get; set; }

        /// <summary>
        /// The child MIME message parts of this part. This only applies to container MIME message parts, for example
        /// `multipart/*`. For non- container MIME message part types, such as `text/plain`, this field is empty. For
        /// more information, see RFC 1521.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parts")]
        public virtual System.Collections.Generic.IList<MessagePart> Parts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The body of a single MIME message part.</summary>
    public class MessagePartBody : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// When present, contains the ID of an external attachment that can be retrieved in a separate
        /// `messages.attachments.get` request. When not present, the entire content of the message part body is
        /// contained in the data field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachmentId")]
        public virtual string AttachmentId { get; set; }

        /// <summary>
        /// The body data of a MIME message part as a base64url encoded string. May be empty for MIME container types
        /// that have no message body or when the body data is sent as a separate attachment. An attachment ID is
        /// present if the body data is contained in a separate attachment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>Number of bytes for the message part data (encoding notwithstanding).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("size")]
        public virtual System.Nullable<int> Size { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class MessagePartHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the header before the `:` separator. For example, `To`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The value of the header after the `:` separator. For example, `someuser@example.com`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ModifyMessageRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of IDs of labels to add to this message. You can add up to 100 labels with each update.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addLabelIds")]
        public virtual System.Collections.Generic.IList<string> AddLabelIds { get; set; }

        /// <summary>
        /// A list IDs of labels to remove from this message. You can remove up to 100 labels with each update.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("removeLabelIds")]
        public virtual System.Collections.Generic.IList<string> RemoveLabelIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ModifyThreadRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of IDs of labels to add to this thread. You can add up to 100 labels with each update.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addLabelIds")]
        public virtual System.Collections.Generic.IList<string> AddLabelIds { get; set; }

        /// <summary>
        /// A list of IDs of labels to remove from this thread. You can remove up to 100 labels with each update.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("removeLabelIds")]
        public virtual System.Collections.Generic.IList<string> RemoveLabelIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to obliterate a CSE key pair.</summary>
    public class ObliterateCseKeyPairRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>POP settings for an account.</summary>
    public class PopSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The range of messages which are accessible via POP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessWindow")]
        public virtual string AccessWindow { get; set; }

        /// <summary>The action that will be executed on a message after it has been fetched via POP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disposition")]
        public virtual string Disposition { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Profile for a Gmail user.</summary>
    public class Profile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The user's email address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailAddress")]
        public virtual string EmailAddress { get; set; }

        /// <summary>The ID of the mailbox's current history record.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("historyId")]
        public virtual System.Nullable<ulong> HistoryId { get; set; }

        /// <summary>The total number of messages in the mailbox.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messagesTotal")]
        public virtual System.Nullable<int> MessagesTotal { get; set; }

        /// <summary>The total number of threads in the mailbox.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threadsTotal")]
        public virtual System.Nullable<int> ThreadsTotal { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Settings associated with a send-as alias, which can be either the primary login address associated with the
    /// account or a custom "from" address. Send-as aliases correspond to the "Send Mail As" feature in the web
    /// interface.
    /// </summary>
    public class SendAs : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A name that appears in the "From:" header for mail sent using this alias. For custom "from" addresses, when
        /// this is empty, Gmail will populate the "From:" header with the name that is used for the primary address
        /// associated with the account. If the admin has disabled the ability for users to update their name format,
        /// requests to update this field for the primary login will silently fail.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Whether this address is selected as the default "From:" address in situations such as composing a new
        /// message or sending a vacation auto-reply. Every Gmail account has exactly one default send-as address, so
        /// the only legal value that clients may write to this field is `true`. Changing this from `false` to `true`
        /// for an address will result in this field becoming `false` for the other previous default address.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isDefault")]
        public virtual System.Nullable<bool> IsDefault { get; set; }

        /// <summary>
        /// Whether this address is the primary address used to login to the account. Every Gmail account has exactly
        /// one primary address, and it cannot be deleted from the collection of send-as aliases. This field is
        /// read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isPrimary")]
        public virtual System.Nullable<bool> IsPrimary { get; set; }

        /// <summary>
        /// An optional email address that is included in a "Reply-To:" header for mail sent using this alias. If this
        /// is empty, Gmail will not generate a "Reply-To:" header.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replyToAddress")]
        public virtual string ReplyToAddress { get; set; }

        /// <summary>
        /// The email address that appears in the "From:" header for mail sent using this alias. This is read-only for
        /// all operations except create.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sendAsEmail")]
        public virtual string SendAsEmail { get; set; }

        /// <summary>
        /// An optional HTML signature that is included in messages composed with this alias in the Gmail web UI. This
        /// signature is added to new emails only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signature")]
        public virtual string Signature { get; set; }

        /// <summary>
        /// An optional SMTP service that will be used as an outbound relay for mail sent using this alias. If this is
        /// empty, outbound mail will be sent directly from Gmail's servers to the destination SMTP service. This
        /// setting only applies to custom "from" aliases.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("smtpMsa")]
        public virtual SmtpMsa SmtpMsa { get; set; }

        /// <summary>
        /// Whether Gmail should treat this address as an alias for the user's primary email address. This setting only
        /// applies to custom "from" aliases.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("treatAsAlias")]
        public virtual System.Nullable<bool> TreatAsAlias { get; set; }

        /// <summary>
        /// Indicates whether this address has been verified for use as a send-as alias. Read-only. This setting only
        /// applies to custom "from" aliases.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verificationStatus")]
        public virtual string VerificationStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration of a CSE identity that uses different key pairs for signing and encryption.</summary>
    public class SignAndEncryptKeyPairs : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the CseKeyPair that encrypts signed outgoing mail.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionKeyPairId")]
        public virtual string EncryptionKeyPairId { get; set; }

        /// <summary>The ID of the CseKeyPair that signs outgoing mail.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signingKeyPairId")]
        public virtual string SigningKeyPairId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An S/MIME email config.</summary>
    public class SmimeInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Encrypted key password, when key is encrypted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptedKeyPassword")]
        public virtual string EncryptedKeyPassword { get; set; }

        /// <summary>When the certificate expires (in milliseconds since epoch).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expiration")]
        public virtual System.Nullable<long> Expiration { get; set; }

        /// <summary>The immutable ID for the SmimeInfo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Whether this SmimeInfo is the default one for this user's send-as address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isDefault")]
        public virtual System.Nullable<bool> IsDefault { get; set; }

        /// <summary>The S/MIME certificate issuer's common name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issuerCn")]
        public virtual string IssuerCn { get; set; }

        /// <summary>
        /// PEM formatted X509 concatenated certificate string (standard base64 encoding). Format used for returning
        /// key, which includes public key as well as certificate chain (not private key).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pem")]
        public virtual string Pem { get; set; }

        /// <summary>
        /// PKCS#12 format containing a single private/public key pair and certificate chain. This format is only
        /// accepted from client for creating a new SmimeInfo and is never returned, because the private key is not
        /// intended to be exported. PKCS#12 may be encrypted, in which case encryptedKeyPassword should be set
        /// appropriately.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pkcs12")]
        public virtual string Pkcs12 { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for communication with an SMTP service.</summary>
    public class SmtpMsa : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The hostname of the SMTP service. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        /// <summary>
        /// The password that will be used for authentication with the SMTP service. This is a write-only field that can
        /// be specified in requests to create or update SendAs settings; it is never populated in responses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>The port of the SMTP service. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>The protocol that will be used to secure communication with the SMTP service. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityMode")]
        public virtual string SecurityMode { get; set; }

        /// <summary>
        /// The username that will be used for authentication with the SMTP service. This is a write-only field that can
        /// be specified in requests to create or update SendAs settings; it is never populated in responses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A collection of messages representing a conversation.</summary>
    public class Thread : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the last history record that modified this thread.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("historyId")]
        public virtual System.Nullable<ulong> HistoryId { get; set; }

        /// <summary>The unique ID of the thread.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The list of messages in the thread.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<Message> Messages { get; set; }

        /// <summary>A short part of the message text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
        public virtual string Snippet { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Vacation auto-reply settings for an account. These settings correspond to the "Vacation responder" feature in
    /// the web interface.
    /// </summary>
    public class VacationSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Flag that controls whether Gmail automatically replies to messages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableAutoReply")]
        public virtual System.Nullable<bool> EnableAutoReply { get; set; }

        /// <summary>
        /// An optional end time for sending auto-replies (epoch ms). When this is specified, Gmail will automatically
        /// reply only to messages that it receives before the end time. If both `startTime` and `endTime` are
        /// specified, `startTime` must precede `endTime`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual System.Nullable<long> EndTime { get; set; }

        /// <summary>
        /// Response body in HTML format. Gmail will sanitize the HTML before storing it. If both
        /// `response_body_plain_text` and `response_body_html` are specified, `response_body_html` will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseBodyHtml")]
        public virtual string ResponseBodyHtml { get; set; }

        /// <summary>
        /// Response body in plain text format. If both `response_body_plain_text` and `response_body_html` are
        /// specified, `response_body_html` will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseBodyPlainText")]
        public virtual string ResponseBodyPlainText { get; set; }

        /// <summary>
        /// Optional text to prepend to the subject line in vacation responses. In order to enable auto-replies, either
        /// the response subject or the response body must be nonempty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseSubject")]
        public virtual string ResponseSubject { get; set; }

        /// <summary>
        /// Flag that determines whether responses are sent to recipients who are not in the user's list of contacts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictToContacts")]
        public virtual System.Nullable<bool> RestrictToContacts { get; set; }

        /// <summary>
        /// Flag that determines whether responses are sent to recipients who are outside of the user's domain. This
        /// feature is only available for Google Workspace users.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictToDomain")]
        public virtual System.Nullable<bool> RestrictToDomain { get; set; }

        /// <summary>
        /// An optional start time for sending auto-replies (epoch ms). When this is specified, Gmail will automatically
        /// reply only to messages that it receives after the start time. If both `startTime` and `endTime` are
        /// specified, `startTime` must precede `endTime`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual System.Nullable<long> StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Set up or update a new push notification watch on this user's mailbox.</summary>
    public class WatchRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Filtering behavior of `labelIds list` specified. This field is deprecated because it caused incorrect
        /// behavior in some cases; use `label_filter_behavior` instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelFilterAction")]
        public virtual string LabelFilterAction { get; set; }

        /// <summary>
        /// Filtering behavior of `labelIds list` specified. This field replaces `label_filter_action`; if set,
        /// `label_filter_action` is ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelFilterBehavior")]
        public virtual string LabelFilterBehavior { get; set; }

        /// <summary>
        /// List of label_ids to restrict notifications about. By default, if unspecified, all changes are pushed out.
        /// If specified then dictates which labels are required for a push notification to be generated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelIds")]
        public virtual System.Collections.Generic.IList<string> LabelIds { get; set; }

        /// <summary>
        /// A fully qualified Google Cloud Pub/Sub API topic name to publish the events to. This topic name **must**
        /// already exist in Cloud Pub/Sub and you **must** have already granted gmail "publish" permission on it. For
        /// example, "projects/my-project-identifier/topics/my-topic-name" (using the Cloud Pub/Sub "v1" topic naming
        /// format). Note that the "my-project-identifier" portion must exactly match your Google developer project id
        /// (the one executing this watch request).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topicName")]
        public virtual string TopicName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Push notification watch response.</summary>
    public class WatchResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// When Gmail will stop sending notifications for mailbox updates (epoch millis). Call `watch` again before
        /// this time to renew the watch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expiration")]
        public virtual System.Nullable<long> Expiration { get; set; }

        /// <summary>The ID of the mailbox's current history record.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("historyId")]
        public virtual System.Nullable<ulong> HistoryId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
