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

namespace Google.Apis.HangoutsChat.v1
{
    /// <summary>The HangoutsChat Service.</summary>
    public class HangoutsChatService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public HangoutsChatService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public HangoutsChatService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Dms = new DmsResource(this);
            Media = new MediaResource(this);
            Rooms = new RoomsResource(this);
            Spaces = new SpacesResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "chat";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://chat.googleapis.com/";
        #else
            "https://chat.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://chat.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Gets the Dms resource.</summary>
        public virtual DmsResource Dms { get; }

        /// <summary>Gets the Media resource.</summary>
        public virtual MediaResource Media { get; }

        /// <summary>Gets the Rooms resource.</summary>
        public virtual RoomsResource Rooms { get; }

        /// <summary>Gets the Spaces resource.</summary>
        public virtual SpacesResource Spaces { get; }
    }

    /// <summary>A base abstract class for HangoutsChat requests.</summary>
    public abstract class HangoutsChatBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new HangoutsChatBaseServiceRequest instance.</summary>
        protected HangoutsChatBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes HangoutsChat parameter list.</summary>
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

    /// <summary>The "dms" collection of methods.</summary>
    public class DmsResource
    {
        private const string Resource = "dms";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public DmsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Conversations = new ConversationsResource(service);
        }

        /// <summary>Gets the Conversations resource.</summary>
        public virtual ConversationsResource Conversations { get; }

        /// <summary>The "conversations" collection of methods.</summary>
        public class ConversationsResource
        {
            private const string Resource = "conversations";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ConversationsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Legacy path for creating message. Calling these will result in a BadRequest response.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Space resource name, in the form "spaces/*". Example: spaces/AAAAMpdlehY
            /// </param>
            public virtual MessagesRequest Messages(Google.Apis.HangoutsChat.v1.Data.Message body, string parent)
            {
                return new MessagesRequest(service, body, parent);
            }

            /// <summary>Legacy path for creating message. Calling these will result in a BadRequest response.</summary>
            public class MessagesRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Message>
            {
                /// <summary>Constructs a new Messages request.</summary>
                public MessagesRequest(Google.Apis.Services.IClientService service, Google.Apis.HangoutsChat.v1.Data.Message body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Space resource name, in the form "spaces/*". Example: spaces/AAAAMpdlehY
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Opaque thread identifier string that can be specified to group messages into a single thread. If
                /// this is the first message with a given thread identifier, a new thread is created. Subsequent
                /// messages with the same thread identifier will be posted into the same thread. This relieves bots and
                /// webhooks from having to store the Hangouts Chat thread ID of a thread (created earlier by them) to
                /// post further updates to it. Has no effect if thread field, corresponding to an existing thread, is
                /// set in message.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("threadKey", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ThreadKey { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.HangoutsChat.v1.Data.Message Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "messages";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/messages";

                /// <summary>Initializes Messages parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^dms/[^/]+/conversations/[^/]+$",
                    });
                    RequestParameters.Add("threadKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "threadKey",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Legacy path for creating message. Calling these will result in a BadRequest response.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">
        /// Required. Space resource name, in the form "spaces/*". Example: spaces/AAAAMpdlehY
        /// </param>
        public virtual MessagesRequest Messages(Google.Apis.HangoutsChat.v1.Data.Message body, string parent)
        {
            return new MessagesRequest(service, body, parent);
        }

        /// <summary>Legacy path for creating message. Calling these will result in a BadRequest response.</summary>
        public class MessagesRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Message>
        {
            /// <summary>Constructs a new Messages request.</summary>
            public MessagesRequest(Google.Apis.Services.IClientService service, Google.Apis.HangoutsChat.v1.Data.Message body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Space resource name, in the form "spaces/*". Example: spaces/AAAAMpdlehY</summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>
            /// Opaque thread identifier string that can be specified to group messages into a single thread. If this is
            /// the first message with a given thread identifier, a new thread is created. Subsequent messages with the
            /// same thread identifier will be posted into the same thread. This relieves bots and webhooks from having
            /// to store the Hangouts Chat thread ID of a thread (created earlier by them) to post further updates to
            /// it. Has no effect if thread field, corresponding to an existing thread, is set in message.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("threadKey", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ThreadKey { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.HangoutsChat.v1.Data.Message Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "messages";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+parent}/messages";

            /// <summary>Initializes Messages parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^dms/[^/]+$",
                });
                RequestParameters.Add("threadKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "threadKey",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Legacy path for creating message. Calling these will result in a BadRequest response.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">
        /// Required. Space resource name, in the form "spaces/*". Example: spaces/AAAAMpdlehY
        /// </param>
        public virtual WebhooksRequest Webhooks(Google.Apis.HangoutsChat.v1.Data.Message body, string parent)
        {
            return new WebhooksRequest(service, body, parent);
        }

        /// <summary>Legacy path for creating message. Calling these will result in a BadRequest response.</summary>
        public class WebhooksRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Message>
        {
            /// <summary>Constructs a new Webhooks request.</summary>
            public WebhooksRequest(Google.Apis.Services.IClientService service, Google.Apis.HangoutsChat.v1.Data.Message body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Space resource name, in the form "spaces/*". Example: spaces/AAAAMpdlehY</summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>
            /// Opaque thread identifier string that can be specified to group messages into a single thread. If this is
            /// the first message with a given thread identifier, a new thread is created. Subsequent messages with the
            /// same thread identifier will be posted into the same thread. This relieves bots and webhooks from having
            /// to store the Hangouts Chat thread ID of a thread (created earlier by them) to post further updates to
            /// it. Has no effect if thread field, corresponding to an existing thread, is set in message.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("threadKey", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ThreadKey { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.HangoutsChat.v1.Data.Message Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "webhooks";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+parent}/webhooks";

            /// <summary>Initializes Webhooks parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^dms/[^/]+$",
                });
                RequestParameters.Add("threadKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "threadKey",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "media" collection of methods.</summary>
    public class MediaResource
    {
        private const string Resource = "media";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public MediaResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Downloads media. Download is supported on the URI `/v1/media/{+name}?alt=media`.</summary>
        /// <param name="resourceName">
        /// Name of the media that is being downloaded. See ReadRequest.resource_name.
        /// </param>
        public virtual DownloadRequest Download(string resourceName)
        {
            return new DownloadRequest(service, resourceName);
        }

        /// <summary>Downloads media. Download is supported on the URI `/v1/media/{+name}?alt=media`.</summary>
        public class DownloadRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Media>
        {
            /// <summary>Constructs a new Download request.</summary>
            public DownloadRequest(Google.Apis.Services.IClientService service, string resourceName) : base(service)
            {
                ResourceName = resourceName;
                MediaDownloader = new Google.Apis.Download.MediaDownloader(service);
                InitParameters();
            }

            /// <summary>Name of the media that is being downloaded. See ReadRequest.resource_name.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceName { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "download";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/media/{+resourceName}";

            /// <summary>Initializes Download parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceName", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^.*$",
                });
            }

            /// <summary>Gets the media downloader.</summary>
            public Google.Apis.Download.IMediaDownloader MediaDownloader { get; private set; }

            /// <summary>
            /// <para>Synchronously download the media into the given stream.</para>
            /// <para>
            /// Warning: This method hides download errors; use <see cref="DownloadWithStatus(System.IO.Stream)"/>
            /// instead.
            /// </para>
            /// </summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual void Download(System.IO.Stream stream)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                #if !NET40
                mediaDownloader.Range = null;
                #endif
                mediaDownloader.Download(this.GenerateRequestUri(), stream);
            }

            /// <summary>Synchronously download the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            /// <returns>The final status of the download; including whether the download succeeded or failed.</returns>
            public virtual Google.Apis.Download.IDownloadProgress DownloadWithStatus(System.IO.Stream stream)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                #if !NET40
                mediaDownloader.Range = null;
                #endif
                return mediaDownloader.Download(this.GenerateRequestUri(), stream);
            }

            /// <summary>Asynchronously download the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadAsync(System.IO.Stream stream)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                #if !NET40
                mediaDownloader.Range = null;
                #endif
                return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream);
            }

            /// <summary>Asynchronously download the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadAsync(System.IO.Stream stream,
                System.Threading.CancellationToken cancellationToken)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                #if !NET40
                mediaDownloader.Range = null;
                #endif
                return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream, cancellationToken);
            }

            #if !NET40
            /// <summary>Synchronously download a range of the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual Google.Apis.Download.IDownloadProgress DownloadRange(System.IO.Stream stream, System.Net.Http.Headers.RangeHeaderValue range)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = range;
                return mediaDownloader.Download(this.GenerateRequestUri(), stream);
            }

            /// <summary>Asynchronously download a range of the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadRangeAsync(System.IO.Stream stream,
                System.Net.Http.Headers.RangeHeaderValue range,
                System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = range;
                return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream, cancellationToken);
            }
            #endif
        }
    }

    /// <summary>The "rooms" collection of methods.</summary>
    public class RoomsResource
    {
        private const string Resource = "rooms";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public RoomsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Conversations = new ConversationsResource(service);
        }

        /// <summary>Gets the Conversations resource.</summary>
        public virtual ConversationsResource Conversations { get; }

        /// <summary>The "conversations" collection of methods.</summary>
        public class ConversationsResource
        {
            private const string Resource = "conversations";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ConversationsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Legacy path for creating message. Calling these will result in a BadRequest response.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Space resource name, in the form "spaces/*". Example: spaces/AAAAMpdlehY
            /// </param>
            public virtual MessagesRequest Messages(Google.Apis.HangoutsChat.v1.Data.Message body, string parent)
            {
                return new MessagesRequest(service, body, parent);
            }

            /// <summary>Legacy path for creating message. Calling these will result in a BadRequest response.</summary>
            public class MessagesRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Message>
            {
                /// <summary>Constructs a new Messages request.</summary>
                public MessagesRequest(Google.Apis.Services.IClientService service, Google.Apis.HangoutsChat.v1.Data.Message body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Space resource name, in the form "spaces/*". Example: spaces/AAAAMpdlehY
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Opaque thread identifier string that can be specified to group messages into a single thread. If
                /// this is the first message with a given thread identifier, a new thread is created. Subsequent
                /// messages with the same thread identifier will be posted into the same thread. This relieves bots and
                /// webhooks from having to store the Hangouts Chat thread ID of a thread (created earlier by them) to
                /// post further updates to it. Has no effect if thread field, corresponding to an existing thread, is
                /// set in message.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("threadKey", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ThreadKey { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.HangoutsChat.v1.Data.Message Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "messages";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/messages";

                /// <summary>Initializes Messages parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^rooms/[^/]+/conversations/[^/]+$",
                    });
                    RequestParameters.Add("threadKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "threadKey",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Legacy path for creating message. Calling these will result in a BadRequest response.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">
        /// Required. Space resource name, in the form "spaces/*". Example: spaces/AAAAMpdlehY
        /// </param>
        public virtual MessagesRequest Messages(Google.Apis.HangoutsChat.v1.Data.Message body, string parent)
        {
            return new MessagesRequest(service, body, parent);
        }

        /// <summary>Legacy path for creating message. Calling these will result in a BadRequest response.</summary>
        public class MessagesRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Message>
        {
            /// <summary>Constructs a new Messages request.</summary>
            public MessagesRequest(Google.Apis.Services.IClientService service, Google.Apis.HangoutsChat.v1.Data.Message body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Space resource name, in the form "spaces/*". Example: spaces/AAAAMpdlehY</summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>
            /// Opaque thread identifier string that can be specified to group messages into a single thread. If this is
            /// the first message with a given thread identifier, a new thread is created. Subsequent messages with the
            /// same thread identifier will be posted into the same thread. This relieves bots and webhooks from having
            /// to store the Hangouts Chat thread ID of a thread (created earlier by them) to post further updates to
            /// it. Has no effect if thread field, corresponding to an existing thread, is set in message.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("threadKey", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ThreadKey { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.HangoutsChat.v1.Data.Message Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "messages";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+parent}/messages";

            /// <summary>Initializes Messages parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^rooms/[^/]+$",
                });
                RequestParameters.Add("threadKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "threadKey",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Legacy path for creating message. Calling these will result in a BadRequest response.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">
        /// Required. Space resource name, in the form "spaces/*". Example: spaces/AAAAMpdlehY
        /// </param>
        public virtual WebhooksRequest Webhooks(Google.Apis.HangoutsChat.v1.Data.Message body, string parent)
        {
            return new WebhooksRequest(service, body, parent);
        }

        /// <summary>Legacy path for creating message. Calling these will result in a BadRequest response.</summary>
        public class WebhooksRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Message>
        {
            /// <summary>Constructs a new Webhooks request.</summary>
            public WebhooksRequest(Google.Apis.Services.IClientService service, Google.Apis.HangoutsChat.v1.Data.Message body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Space resource name, in the form "spaces/*". Example: spaces/AAAAMpdlehY</summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>
            /// Opaque thread identifier string that can be specified to group messages into a single thread. If this is
            /// the first message with a given thread identifier, a new thread is created. Subsequent messages with the
            /// same thread identifier will be posted into the same thread. This relieves bots and webhooks from having
            /// to store the Hangouts Chat thread ID of a thread (created earlier by them) to post further updates to
            /// it. Has no effect if thread field, corresponding to an existing thread, is set in message.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("threadKey", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ThreadKey { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.HangoutsChat.v1.Data.Message Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "webhooks";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+parent}/webhooks";

            /// <summary>Initializes Webhooks parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^rooms/[^/]+$",
                });
                RequestParameters.Add("threadKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "threadKey",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "spaces" collection of methods.</summary>
    public class SpacesResource
    {
        private const string Resource = "spaces";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public SpacesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Members = new MembersResource(service);
            Messages = new MessagesResource(service);
        }

        /// <summary>Gets the Members resource.</summary>
        public virtual MembersResource Members { get; }

        /// <summary>The "members" collection of methods.</summary>
        public class MembersResource
        {
            private const string Resource = "members";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public MembersResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Returns a membership.</summary>
            /// <param name="name">
            /// Required. Resource name of the membership to be retrieved, in the form "spaces/*/members/*". Example:
            /// spaces/AAAAMpdlehY/members/105115627578887013105
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Returns a membership.</summary>
            public class GetRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Membership>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the membership to be retrieved, in the form "spaces/*/members/*".
                /// Example: spaces/AAAAMpdlehY/members/105115627578887013105
                /// </summary>
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
                        Pattern = @"^spaces/[^/]+/members/[^/]+$",
                    });
                }
            }

            /// <summary>Lists human memberships in a space.</summary>
            /// <param name="parent">
            /// Required. The resource name of the space for which membership list is to be fetched, in the form
            /// "spaces/*". Example: spaces/AAAAMpdlehY
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists human memberships in a space.</summary>
            public class ListRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.ListMembershipsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the space for which membership list is to be fetched, in the form
                /// "spaces/*". Example: spaces/AAAAMpdlehY
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Requested page size. The value is capped at 1000. Server may return fewer results than requested. If
                /// unspecified, server will default to 100.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>A token identifying a page of results the server should return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/members";

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
                        Pattern = @"^spaces/[^/]+$",
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

                /// <summary>
                /// Gets the metadata of a message attachment. The attachment data is fetched using the media API.
                /// </summary>
                /// <param name="name">
                /// Resource name of the attachment, in the form "spaces/*/messages/*/attachments/*".
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Gets the metadata of a message attachment. The attachment data is fetched using the media API.
                /// </summary>
                public class GetRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Attachment>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Resource name of the attachment, in the form "spaces/*/messages/*/attachments/*".
                    /// </summary>
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
                            Pattern = @"^spaces/[^/]+/messages/[^/]+/attachments/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Creates a message.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Space resource name, in the form "spaces/*". Example: spaces/AAAAMpdlehY
            /// </param>
            public virtual CreateRequest Create(Google.Apis.HangoutsChat.v1.Data.Message body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a message.</summary>
            public class CreateRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Message>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.HangoutsChat.v1.Data.Message body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Space resource name, in the form "spaces/*". Example: spaces/AAAAMpdlehY
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Opaque thread identifier string that can be specified to group messages into a single thread. If
                /// this is the first message with a given thread identifier, a new thread is created. Subsequent
                /// messages with the same thread identifier will be posted into the same thread. This relieves bots and
                /// webhooks from having to store the Hangouts Chat thread ID of a thread (created earlier by them) to
                /// post further updates to it. Has no effect if thread field, corresponding to an existing thread, is
                /// set in message.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("threadKey", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ThreadKey { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.HangoutsChat.v1.Data.Message Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/messages";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^spaces/[^/]+$",
                    });
                    RequestParameters.Add("threadKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "threadKey",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Deletes a message.</summary>
            /// <param name="name">
            /// Required. Resource name of the message to be deleted, in the form "spaces/*/messages/*" Example:
            /// spaces/AAAAMpdlehY/messages/UMxbHmzDlr4.UMxbHmzDlr4
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes a message.</summary>
            public class DeleteRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the message to be deleted, in the form "spaces/*/messages/*" Example:
                /// spaces/AAAAMpdlehY/messages/UMxbHmzDlr4.UMxbHmzDlr4
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

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
                        Pattern = @"^spaces/[^/]+/messages/[^/]+$",
                    });
                }
            }

            /// <summary>Returns a message.</summary>
            /// <param name="name">
            /// Required. Resource name of the message to be retrieved, in the form "spaces/*/messages/*". Example:
            /// spaces/AAAAMpdlehY/messages/UMxbHmzDlr4.UMxbHmzDlr4
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Returns a message.</summary>
            public class GetRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Message>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the message to be retrieved, in the form "spaces/*/messages/*". Example:
                /// spaces/AAAAMpdlehY/messages/UMxbHmzDlr4.UMxbHmzDlr4
                /// </summary>
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
                        Pattern = @"^spaces/[^/]+/messages/[^/]+$",
                    });
                }
            }

            /// <summary>Updates a message.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name"><c>null</c></param>
            public virtual UpdateRequest Update(Google.Apis.HangoutsChat.v1.Data.Message body, string name)
            {
                return new UpdateRequest(service, body, name);
            }

            /// <summary>Updates a message.</summary>
            public class UpdateRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Message>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.HangoutsChat.v1.Data.Message body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Required. The field paths to be updated, comma separated if there are multiple. Currently supported
                /// field paths: * text * cards
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.HangoutsChat.v1.Data.Message Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^spaces/[^/]+/messages/[^/]+$",
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

        /// <summary>Returns a space.</summary>
        /// <param name="name">
        /// Required. Resource name of the space, in the form "spaces/*". Example: spaces/AAAAMpdlehY
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>Returns a space.</summary>
        public class GetRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Space>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. Resource name of the space, in the form "spaces/*". Example: spaces/AAAAMpdlehY
            /// </summary>
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
                    Pattern = @"^spaces/[^/]+$",
                });
            }
        }

        /// <summary>Lists spaces the caller is a member of.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Lists spaces the caller is a member of.</summary>
        public class ListRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.ListSpacesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Requested page size. The value is capped at 1000. Server may return fewer results than requested. If
            /// unspecified, server will default to 100.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>A token identifying a page of results the server should return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/spaces";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
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

        /// <summary>Legacy path for creating message. Calling these will result in a BadRequest response.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">
        /// Required. Space resource name, in the form "spaces/*". Example: spaces/AAAAMpdlehY
        /// </param>
        public virtual WebhooksRequest Webhooks(Google.Apis.HangoutsChat.v1.Data.Message body, string parent)
        {
            return new WebhooksRequest(service, body, parent);
        }

        /// <summary>Legacy path for creating message. Calling these will result in a BadRequest response.</summary>
        public class WebhooksRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Message>
        {
            /// <summary>Constructs a new Webhooks request.</summary>
            public WebhooksRequest(Google.Apis.Services.IClientService service, Google.Apis.HangoutsChat.v1.Data.Message body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Space resource name, in the form "spaces/*". Example: spaces/AAAAMpdlehY</summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>
            /// Opaque thread identifier string that can be specified to group messages into a single thread. If this is
            /// the first message with a given thread identifier, a new thread is created. Subsequent messages with the
            /// same thread identifier will be posted into the same thread. This relieves bots and webhooks from having
            /// to store the Hangouts Chat thread ID of a thread (created earlier by them) to post further updates to
            /// it. Has no effect if thread field, corresponding to an existing thread, is set in message.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("threadKey", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ThreadKey { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.HangoutsChat.v1.Data.Message Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "webhooks";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+parent}/webhooks";

            /// <summary>Initializes Webhooks parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^spaces/[^/]+$",
                });
                RequestParameters.Add("threadKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "threadKey",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.HangoutsChat.v1.Data
{
    /// <summary>
    /// List of string parameters to supply when the action method is invoked. For example, consider three snooze
    /// buttons: snooze now, snooze 1 day, snooze next week. You might use action method = snooze(), passing the snooze
    /// type and snooze time in the list of string parameters.
    /// </summary>
    public class ActionParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the parameter for the action script.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The value of the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Parameters that a bot can use to configure how it's response is posted.</summary>
    public class ActionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of bot response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>URL for users to auth or config. (Only for REQUEST_CONFIG response types.)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Annotations associated with the plain-text body of the message. Example plain-text message body: ``` Hello
    /// @FooBot how are you!" ``` The corresponding annotations metadata: ``` "annotations":[{ "type":"USER_MENTION",
    /// "startIndex":6, "length":7, "userMention": { "user": { "name":"users/107946847022116401880",
    /// "displayName":"FooBot", "avatarUrl":"https://goo.gl/aeDtrS", "type":"BOT" }, "type":"MENTION" } }] ```
    /// </summary>
    public class Annotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Length of the substring in the plain-text message body this annotation corresponds to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("length")]
        public virtual System.Nullable<int> Length { get; set; }

        /// <summary>The metadata for a slash command.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slashCommand")]
        public virtual SlashCommandMetadata SlashCommand { get; set; }

        /// <summary>
        /// Start index (0-based, inclusive) in the plain-text message body this annotation corresponds to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; }

        /// <summary>The type of this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The metadata of user mention.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userMention")]
        public virtual UserMentionMetadata UserMention { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An attachment in Hangouts Chat.</summary>
    public class Attachment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A reference to the attachment data. This is used with the media API to download the attachment data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachmentDataRef")]
        public virtual AttachmentDataRef AttachmentDataRef { get; set; }

        /// <summary>The original file name for the content, not the full path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentName")]
        public virtual string ContentName { get; set; }

        /// <summary>The content type (MIME type) of the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentType")]
        public virtual string ContentType { get; set; }

        /// <summary>
        /// Output only. The download URL which should be used to allow a human user to download the attachment. Bots
        /// should not use this URL to download attachment content.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downloadUri")]
        public virtual string DownloadUri { get; set; }

        /// <summary>A reference to the drive attachment. This is used with the Drive API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driveDataRef")]
        public virtual DriveDataRef DriveDataRef { get; set; }

        /// <summary>Resource name of the attachment, in the form "spaces/*/messages/*/attachments/*".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The source of the attachment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>
        /// Output only. The thumbnail URL which should be used to preview the attachment to a human user. Bots should
        /// not use this URL to download attachment content.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnailUri")]
        public virtual string ThumbnailUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A reference to the data of an attachment.</summary>
    public class AttachmentDataRef : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource name of the attachment data. This is used with the media API to download the attachment data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A button. Can be a text button or an image button.</summary>
    public class Button : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A button with image and onclick action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageButton")]
        public virtual ImageButton ImageButton { get; set; }

        /// <summary>A button with text and onclick action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textButton")]
        public virtual TextButton TextButton { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A card is a UI element that can contain UI widgets such as texts, images.</summary>
    public class Card : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The actions of this card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardActions")]
        public virtual System.Collections.Generic.IList<CardAction> CardActions { get; set; }

        /// <summary>The header of the card. A header usually contains a title and an image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual CardHeader Header { get; set; }

        /// <summary>Name of the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Sections are separated by a line divider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sections")]
        public virtual System.Collections.Generic.IList<Section> Sections { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A card action is the action associated with the card. For an invoice card, a typical action would be: delete
    /// invoice, email invoice or open the invoice in browser.
    /// </summary>
    public class CardAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The label used to be displayed in the action menu item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionLabel")]
        public virtual string ActionLabel { get; set; }

        /// <summary>The onclick action for this action item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual OnClick OnClick { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CardHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The image's type (e.g. square border or circular border).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageStyle")]
        public virtual string ImageStyle { get; set; }

        /// <summary>The URL of the image in the card header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUrl")]
        public virtual string ImageUrl { get; set; }

        /// <summary>The subtitle of the card header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subtitle")]
        public virtual string Subtitle { get; set; }

        /// <summary>
        /// The title must be specified. The header has a fixed height: if both a title and subtitle is specified, each
        /// will take up 1 line. If only the title is specified, it will take up both lines.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Google Chat events.</summary>
    public class DeprecatedEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The form action data associated with an interactive card that was clicked. Only populated for CARD_CLICKED
        /// events. See the [Interactive Cards guide](/chat/how-tos/cards-onclick) for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual FormAction Action { get; set; }

        /// <summary>
        /// The URL the bot should redirect the user to after they have completed an authorization or configuration flow
        /// outside of Google Chat. See the [Authorizing access to 3p services guide](/chat/how-tos/auth-3p) for more
        /// information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configCompleteRedirectUrl")]
        public virtual string ConfigCompleteRedirectUrl { get; set; }

        /// <summary>The timestamp indicating when the event was dispatched.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTime")]
        public virtual object EventTime { get; set; }

        /// <summary>The message that triggered the event, if applicable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual Message Message { get; set; }

        /// <summary>The room or DM in which the event occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("space")]
        public virtual Space Space { get; set; }

        /// <summary>
        /// The bot-defined key for the thread related to the event. See the thread_key field of the
        /// `spaces.message.create` request for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threadKey")]
        public virtual string ThreadKey { get; set; }

        /// <summary>
        /// A secret value that bots can use to verify if a request is from Google. The token is randomly generated by
        /// Google, remains static, and can be obtained from the Google Chat API configuration page in the Cloud
        /// Console. Developers can revoke/regenerate it if needed from the same page.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>The type of the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The user that triggered the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual User User { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A reference to the data of a drive attachment.</summary>
    public class DriveDataRef : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The id for the drive file, for use with the Drive API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driveFileId")]
        public virtual string DriveFileId { get; set; }

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

    /// <summary>
    /// A form action describes the behavior when the form is submitted. For example, an Apps Script can be invoked to
    /// handle the form.
    /// </summary>
    public class FormAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The method name is used to identify which part of the form triggered the form submission. This information
        /// is echoed back to the bot as part of the card click event. The same method name can be used for several
        /// elements that trigger a common behavior if desired.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionMethodName")]
        public virtual string ActionMethodName { get; set; }

        /// <summary>List of action parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IList<ActionParameter> Parameters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An image that is specified by a URL and can have an onclick action.</summary>
    public class Image : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The aspect ratio of this image (width/height). This field allows clients to reserve the right height for the
        /// image while waiting for it to load. It's not meant to override the native aspect ratio of the image. If
        /// unset, the server fills it by prefetching the image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aspectRatio")]
        public virtual System.Nullable<double> AspectRatio { get; set; }

        /// <summary>The URL of the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUrl")]
        public virtual string ImageUrl { get; set; }

        /// <summary>The onclick action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual OnClick OnClick { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An image button with an onclick action.</summary>
    public class ImageButton : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The icon specified by an enum that indices to an icon provided by Chat API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("icon")]
        public virtual string Icon { get; set; }

        /// <summary>The icon specified by a URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iconUrl")]
        public virtual string IconUrl { get; set; }

        /// <summary>
        /// The name of this image_button which will be used for accessibility. Default value will be provided if
        /// developers don't specify.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The onclick action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual OnClick OnClick { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A UI element contains a key (label) and a value (content). And this element may also contain some actions such
    /// as onclick button.
    /// </summary>
    public class KeyValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The text of the bottom label. Formatted text supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bottomLabel")]
        public virtual string BottomLabel { get; set; }

        /// <summary>A button that can be clicked to trigger an action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("button")]
        public virtual Button Button { get; set; }

        /// <summary>The text of the content. Formatted text supported and always required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>If the content should be multiline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentMultiline")]
        public virtual System.Nullable<bool> ContentMultiline { get; set; }

        /// <summary>An enum value that will be replaced by the Chat API with the corresponding icon image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("icon")]
        public virtual string Icon { get; set; }

        /// <summary>The icon specified by a URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iconUrl")]
        public virtual string IconUrl { get; set; }

        /// <summary>The onclick action. Only the top label, bottom label and content region are clickable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual OnClick OnClick { get; set; }

        /// <summary>The text of the top label. Formatted text supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topLabel")]
        public virtual string TopLabel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListMembershipsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of memberships in the requested (or first) page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memberships")]
        public virtual System.Collections.Generic.IList<Membership> Memberships { get; set; }

        /// <summary>
        /// Continuation token to retrieve the next page of results. It will be empty for the last page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListSpacesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Continuation token to retrieve the next page of results. It will be empty for the last page of results.
        /// Tokens expire in an hour. An error is thrown if an expired token is passed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of spaces in the requested (or first) page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spaces")]
        public virtual System.Collections.Generic.IList<Space> Spaces { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Media resource.</summary>
    public class Media : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the media resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a membership relation in Hangouts Chat.</summary>
    public class Membership : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The creation time of the membership a.k.a the time at which the member joined the space, if applicable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>A User in Hangout Chat</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("member")]
        public virtual User Member { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>State of the membership.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message in Hangouts Chat.</summary>
    public class Message : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Input only. Parameters that a bot can use to configure how its response is posted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionResponse")]
        public virtual ActionResponse ActionResponse { get; set; }

        /// <summary>Output only. Annotations associated with the text in this message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IList<Annotation> Annotations { get; set; }

        /// <summary>Plain-text body of the message with all bot mentions stripped out.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("argumentText")]
        public virtual string ArgumentText { get; set; }

        /// <summary>User uploaded attachment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachment")]
        public virtual System.Collections.Generic.IList<Attachment> Attachment { get; set; }

        /// <summary>
        /// Rich, formatted and interactive cards that can be used to display UI elements such as: formatted texts,
        /// buttons, clickable images. Cards are normally displayed below the plain-text body of the message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cards")]
        public virtual System.Collections.Generic.IList<Card> Cards { get; set; }

        /// <summary>Output only. The time at which the message was created in Hangouts Chat server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// A plain-text description of the message's cards, used when the actual cards cannot be displayed (e.g. mobile
        /// notifications).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fallbackText")]
        public virtual string FallbackText { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Text for generating preview chips. This text will not be displayed to the user, but any links to images, web
        /// pages, videos, etc. included here will generate preview chips.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previewText")]
        public virtual string PreviewText { get; set; }

        /// <summary>The user who created the message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sender")]
        public virtual User Sender { get; set; }

        /// <summary>Slash command information, if applicable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slashCommand")]
        public virtual SlashCommand SlashCommand { get; set; }

        /// <summary>The space the message belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("space")]
        public virtual Space Space { get; set; }

        /// <summary>Plain-text body of the message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The thread the message belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thread")]
        public virtual Thread Thread { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An onclick action (e.g. open a link).</summary>
    public class OnClick : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A form action will be triggered by this onclick if specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual FormAction Action { get; set; }

        /// <summary>This onclick triggers an open link action if specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openLink")]
        public virtual OpenLink OpenLink { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A link that opens a new window.</summary>
    public class OpenLink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The URL to open.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A section contains a collection of widgets that are rendered (vertically) in the order that they are specified.
    /// Across all platforms, cards have a narrow fixed width, so there is currently no need for layout properties (e.g.
    /// float).
    /// </summary>
    public class Section : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The header of the section, text formatted supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual string Header { get; set; }

        /// <summary>A section must contain at least 1 widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("widgets")]
        public virtual System.Collections.Generic.IList<WidgetMarkup> Widgets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Slash Command in Chat.</summary>
    public class SlashCommand : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The id of the slash command invoked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commandId")]
        public virtual System.Nullable<long> CommandId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Annotation metadata for slash commands (/).</summary>
    public class SlashCommandMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The bot whose command was invoked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bot")]
        public virtual User Bot { get; set; }

        /// <summary>The command id of the invoked slash command.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commandId")]
        public virtual System.Nullable<long> CommandId { get; set; }

        /// <summary>The name of the invoked slash command.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commandName")]
        public virtual string CommandName { get; set; }

        /// <summary>Indicating whether the slash command is for a dialog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggersDialog")]
        public virtual System.Nullable<bool> TriggersDialog { get; set; }

        /// <summary>The type of slash command.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A room or DM in Hangouts Chat.</summary>
    public class Space : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The display name (only if the space is a room). Please note that this field might not be
        /// populated in direct messages between humans.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Resource name of the space, in the form "spaces/*". Example: spaces/AAAAMpdlehYs</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Whether the space is a DM between a bot and a single human.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("singleUserBotDm")]
        public virtual System.Nullable<bool> SingleUserBotDm { get; set; }

        /// <summary>Whether the messages are threaded in this space.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threaded")]
        public virtual System.Nullable<bool> Threaded { get; set; }

        /// <summary>Output only. The type of a space. This is deprecated. Use `single_user_bot_dm` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A button with text and onclick action.</summary>
    public class TextButton : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The onclick action of the button.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual OnClick OnClick { get; set; }

        /// <summary>The text of the button.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A paragraph of text. Formatted text supported.</summary>
    public class TextParagraph : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A thread in Hangouts Chat.</summary>
    public class Thread : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Resource name, in the form "spaces/*/threads/*". Example: spaces/AAAAMpdlehY/threads/UMxbHmzDlr4
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A user in Google Chat.</summary>
    public class User : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The user's display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Obfuscated domain information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainId")]
        public virtual string DomainId { get; set; }

        /// <summary>True when the user is deleted or the user's profile is not visible.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isAnonymous")]
        public virtual System.Nullable<bool> IsAnonymous { get; set; }

        /// <summary>Resource name, in the format "users/*".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>User type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Annotation metadata for user mentions (@).</summary>
    public class UserMentionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of user mention.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The user mentioned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual User User { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A widget is a UI element that presents texts, images, etc.</summary>
    public class WidgetMarkup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of buttons. Buttons is also oneof data and only one of these fields should be set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buttons")]
        public virtual System.Collections.Generic.IList<Button> Buttons { get; set; }

        /// <summary>Display an image in this widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual Image Image { get; set; }

        /// <summary>Display a key value item in this widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyValue")]
        public virtual KeyValue KeyValue { get; set; }

        /// <summary>Display a text paragraph in this widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textParagraph")]
        public virtual TextParagraph TextParagraph { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
