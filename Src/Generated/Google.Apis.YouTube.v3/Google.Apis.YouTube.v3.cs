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

namespace Google.Apis.YouTube.v3
{
    /// <summary>The YouTube Service.</summary>
    public class YouTubeService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v3";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public YouTubeService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public YouTubeService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            AbuseReports = new AbuseReportsResource(this);
            Activities = new ActivitiesResource(this);
            Captions = new CaptionsResource(this);
            ChannelBanners = new ChannelBannersResource(this);
            ChannelSections = new ChannelSectionsResource(this);
            Channels = new ChannelsResource(this);
            CommentThreads = new CommentThreadsResource(this);
            Comments = new CommentsResource(this);
            I18nLanguages = new I18nLanguagesResource(this);
            I18nRegions = new I18nRegionsResource(this);
            LiveBroadcasts = new LiveBroadcastsResource(this);
            LiveChatBans = new LiveChatBansResource(this);
            LiveChatMessages = new LiveChatMessagesResource(this);
            LiveChatModerators = new LiveChatModeratorsResource(this);
            LiveStreams = new LiveStreamsResource(this);
            Members = new MembersResource(this);
            MembershipsLevels = new MembershipsLevelsResource(this);
            PlaylistItems = new PlaylistItemsResource(this);
            Playlists = new PlaylistsResource(this);
            Search = new SearchResource(this);
            Subscriptions = new SubscriptionsResource(this);
            SuperChatEvents = new SuperChatEventsResource(this);
            Tests = new TestsResource(this);
            ThirdPartyLinks = new ThirdPartyLinksResource(this);
            Thumbnails = new ThumbnailsResource(this);
            VideoAbuseReportReasons = new VideoAbuseReportReasonsResource(this);
            VideoCategories = new VideoCategoriesResource(this);
            Videos = new VideosResource(this);
            Watermarks = new WatermarksResource(this);
            Youtube = new YoutubeResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "youtube";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://youtube.googleapis.com/";
        #else
            "https://youtube.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://youtube.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the YouTube Data API v3.</summary>
        public class Scope
        {
            /// <summary>Manage your YouTube account</summary>
            public static string Youtube = "https://www.googleapis.com/auth/youtube";

            /// <summary>
            /// See a list of your current active channel members, their current level, and when they became a member
            /// </summary>
            public static string YoutubeChannelMembershipsCreator = "https://www.googleapis.com/auth/youtube.channel-memberships.creator";

            /// <summary>See, edit, and permanently delete your YouTube videos, ratings, comments and captions</summary>
            public static string YoutubeForceSsl = "https://www.googleapis.com/auth/youtube.force-ssl";

            /// <summary>View your YouTube account</summary>
            public static string YoutubeReadonly = "https://www.googleapis.com/auth/youtube.readonly";

            /// <summary>Manage your YouTube videos</summary>
            public static string YoutubeUpload = "https://www.googleapis.com/auth/youtube.upload";

            /// <summary>View and manage your assets and associated content on YouTube</summary>
            public static string Youtubepartner = "https://www.googleapis.com/auth/youtubepartner";

            /// <summary>
            /// View private information of your YouTube channel relevant during the audit process with a YouTube
            /// partner
            /// </summary>
            public static string YoutubepartnerChannelAudit = "https://www.googleapis.com/auth/youtubepartner-channel-audit";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the YouTube Data API v3.</summary>
        public static class ScopeConstants
        {
            /// <summary>Manage your YouTube account</summary>
            public const string Youtube = "https://www.googleapis.com/auth/youtube";

            /// <summary>
            /// See a list of your current active channel members, their current level, and when they became a member
            /// </summary>
            public const string YoutubeChannelMembershipsCreator = "https://www.googleapis.com/auth/youtube.channel-memberships.creator";

            /// <summary>See, edit, and permanently delete your YouTube videos, ratings, comments and captions</summary>
            public const string YoutubeForceSsl = "https://www.googleapis.com/auth/youtube.force-ssl";

            /// <summary>View your YouTube account</summary>
            public const string YoutubeReadonly = "https://www.googleapis.com/auth/youtube.readonly";

            /// <summary>Manage your YouTube videos</summary>
            public const string YoutubeUpload = "https://www.googleapis.com/auth/youtube.upload";

            /// <summary>View and manage your assets and associated content on YouTube</summary>
            public const string Youtubepartner = "https://www.googleapis.com/auth/youtubepartner";

            /// <summary>
            /// View private information of your YouTube channel relevant during the audit process with a YouTube
            /// partner
            /// </summary>
            public const string YoutubepartnerChannelAudit = "https://www.googleapis.com/auth/youtubepartner-channel-audit";
        }

        /// <summary>Gets the AbuseReports resource.</summary>
        public virtual AbuseReportsResource AbuseReports { get; }

        /// <summary>Gets the Activities resource.</summary>
        public virtual ActivitiesResource Activities { get; }

        /// <summary>Gets the Captions resource.</summary>
        public virtual CaptionsResource Captions { get; }

        /// <summary>Gets the ChannelBanners resource.</summary>
        public virtual ChannelBannersResource ChannelBanners { get; }

        /// <summary>Gets the ChannelSections resource.</summary>
        public virtual ChannelSectionsResource ChannelSections { get; }

        /// <summary>Gets the Channels resource.</summary>
        public virtual ChannelsResource Channels { get; }

        /// <summary>Gets the CommentThreads resource.</summary>
        public virtual CommentThreadsResource CommentThreads { get; }

        /// <summary>Gets the Comments resource.</summary>
        public virtual CommentsResource Comments { get; }

        /// <summary>Gets the I18nLanguages resource.</summary>
        public virtual I18nLanguagesResource I18nLanguages { get; }

        /// <summary>Gets the I18nRegions resource.</summary>
        public virtual I18nRegionsResource I18nRegions { get; }

        /// <summary>Gets the LiveBroadcasts resource.</summary>
        public virtual LiveBroadcastsResource LiveBroadcasts { get; }

        /// <summary>Gets the LiveChatBans resource.</summary>
        public virtual LiveChatBansResource LiveChatBans { get; }

        /// <summary>Gets the LiveChatMessages resource.</summary>
        public virtual LiveChatMessagesResource LiveChatMessages { get; }

        /// <summary>Gets the LiveChatModerators resource.</summary>
        public virtual LiveChatModeratorsResource LiveChatModerators { get; }

        /// <summary>Gets the LiveStreams resource.</summary>
        public virtual LiveStreamsResource LiveStreams { get; }

        /// <summary>Gets the Members resource.</summary>
        public virtual MembersResource Members { get; }

        /// <summary>Gets the MembershipsLevels resource.</summary>
        public virtual MembershipsLevelsResource MembershipsLevels { get; }

        /// <summary>Gets the PlaylistItems resource.</summary>
        public virtual PlaylistItemsResource PlaylistItems { get; }

        /// <summary>Gets the Playlists resource.</summary>
        public virtual PlaylistsResource Playlists { get; }

        /// <summary>Gets the Search resource.</summary>
        public virtual SearchResource Search { get; }

        /// <summary>Gets the Subscriptions resource.</summary>
        public virtual SubscriptionsResource Subscriptions { get; }

        /// <summary>Gets the SuperChatEvents resource.</summary>
        public virtual SuperChatEventsResource SuperChatEvents { get; }

        /// <summary>Gets the Tests resource.</summary>
        public virtual TestsResource Tests { get; }

        /// <summary>Gets the ThirdPartyLinks resource.</summary>
        public virtual ThirdPartyLinksResource ThirdPartyLinks { get; }

        /// <summary>Gets the Thumbnails resource.</summary>
        public virtual ThumbnailsResource Thumbnails { get; }

        /// <summary>Gets the VideoAbuseReportReasons resource.</summary>
        public virtual VideoAbuseReportReasonsResource VideoAbuseReportReasons { get; }

        /// <summary>Gets the VideoCategories resource.</summary>
        public virtual VideoCategoriesResource VideoCategories { get; }

        /// <summary>Gets the Videos resource.</summary>
        public virtual VideosResource Videos { get; }

        /// <summary>Gets the Watermarks resource.</summary>
        public virtual WatermarksResource Watermarks { get; }

        /// <summary>Gets the Youtube resource.</summary>
        public virtual YoutubeResource Youtube { get; }
    }

    /// <summary>A base abstract class for YouTube requests.</summary>
    public abstract class YouTubeBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new YouTubeBaseServiceRequest instance.</summary>
        protected YouTubeBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes YouTube parameter list.</summary>
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

    /// <summary>The "abuseReports" collection of methods.</summary>
    public class AbuseReportsResource
    {
        private const string Resource = "abuseReports";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AbuseReportsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Inserts a new resource into this collection.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="part">
        /// The *part* parameter serves two purposes in this operation. It identifies the properties that the write
        /// operation will set as well as the properties that the API response will include.
        /// </param>
        public virtual InsertRequest Insert(Google.Apis.YouTube.v3.Data.AbuseReport body, Google.Apis.Util.Repeatable<string> part)
        {
            return new InsertRequest(service, body, part);
        }

        /// <summary>Inserts a new resource into this collection.</summary>
        public class InsertRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.AbuseReport>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.YouTube.v3.Data.AbuseReport body, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter serves two purposes in this operation. It identifies the properties that the write
            /// operation will set as well as the properties that the API response will include.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.YouTube.v3.Data.AbuseReport Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/abuseReports";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "activities" collection of methods.</summary>
    public class ActivitiesResource
    {
        private const string Resource = "activities";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ActivitiesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Retrieves a list of resources, possibly filtered.</summary>
        /// <param name="part">
        /// The *part* parameter specifies a comma-separated list of one or more activity resource properties that the
        /// API response will include. If the parameter identifies a property that contains child properties, the child
        /// properties will be included in the response. For example, in an activity resource, the snippet property
        /// contains other properties that identify the type of activity, a display title for the activity, and so
        /// forth. If you set *part=snippet*, the API response will also contain all of those nested properties.
        /// </param>
        public virtual ListRequest List(Google.Apis.Util.Repeatable<string> part)
        {
            return new ListRequest(service, part);
        }

        /// <summary>Retrieves a list of resources, possibly filtered.</summary>
        public class ListRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.ActivityListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter specifies a comma-separated list of one or more activity resource properties that
            /// the API response will include. If the parameter identifies a property that contains child properties,
            /// the child properties will be included in the response. For example, in an activity resource, the snippet
            /// property contains other properties that identify the type of activity, a display title for the activity,
            /// and so forth. If you set *part=snippet*, the API response will also contain all of those nested
            /// properties.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("channelId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ChannelId { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("home", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Home { get; set; }

            /// <summary>
            /// The *maxResults* parameter specifies the maximum number of items that should be returned in the result
            /// set.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("mine", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Mine { get; set; }

            /// <summary>
            /// The *pageToken* parameter identifies a specific page in the result set that should be returned. In an
            /// API response, the nextPageToken and prevPageToken properties identify other pages that could be
            /// retrieved.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("publishedAfter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object PublishedAfter { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("publishedBefore", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object PublishedBefore { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("regionCode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string RegionCode { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/activities";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("channelId", new Google.Apis.Discovery.Parameter
                {
                    Name = "channelId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("home", new Google.Apis.Discovery.Parameter
                {
                    Name = "home",
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
                    DefaultValue = "5",
                    Pattern = null,
                });
                RequestParameters.Add("mine", new Google.Apis.Discovery.Parameter
                {
                    Name = "mine",
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
                RequestParameters.Add("publishedAfter", new Google.Apis.Discovery.Parameter
                {
                    Name = "publishedAfter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("publishedBefore", new Google.Apis.Discovery.Parameter
                {
                    Name = "publishedBefore",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("regionCode", new Google.Apis.Discovery.Parameter
                {
                    Name = "regionCode",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "captions" collection of methods.</summary>
    public class CaptionsResource
    {
        private const string Resource = "captions";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public CaptionsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Deletes a resource.</summary>
        /// <param name="id"><c>null</c></param>
        public virtual DeleteRequest Delete(string id)
        {
            return new DeleteRequest(service, id);
        }

        /// <summary>Deletes a resource.</summary>
        public class DeleteRequest : YouTubeBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string id) : base(service)
            {
                Id = id;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Id { get; private set; }

            /// <summary>ID of the Google+ Page for the channel that the request is be on behalf of</summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOf", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOf { get; set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The actual CMS account
            /// that the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/captions";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOf", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOf",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Downloads a caption track.</summary>
        /// <param name="id">The ID of the caption track to download, required for One Platform.</param>
        public virtual DownloadRequest Download(string id)
        {
            return new DownloadRequest(service, id);
        }

        /// <summary>Downloads a caption track.</summary>
        public class DownloadRequest : YouTubeBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Download request.</summary>
            public DownloadRequest(Google.Apis.Services.IClientService service, string id) : base(service)
            {
                Id = id;
                MediaDownloader = new Google.Apis.Download.MediaDownloader(service);
                InitParameters();
            }

            /// <summary>The ID of the caption track to download, required for One Platform.</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Id { get; private set; }

            /// <summary>ID of the Google+ Page for the channel that the request is be on behalf of</summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOf", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOf { get; set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The actual CMS account
            /// that the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>Convert the captions into this format. Supported options are sbv, srt, and vtt.</summary>
            [Google.Apis.Util.RequestParameterAttribute("tfmt", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Tfmt { get; set; }

            /// <summary>tlang is the language code; machine translate the captions into this language.</summary>
            [Google.Apis.Util.RequestParameterAttribute("tlang", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Tlang { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "download";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/captions/{id}";

            /// <summary>Initializes Download parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOf", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOf",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("tfmt", new Google.Apis.Discovery.Parameter
                {
                    Name = "tfmt",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("tlang", new Google.Apis.Discovery.Parameter
                {
                    Name = "tlang",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
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

        /// <summary>Inserts a new resource into this collection.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="part">
        /// The *part* parameter specifies the caption resource parts that the API response will include. Set the
        /// parameter value to snippet.
        /// </param>
        public virtual InsertRequest Insert(Google.Apis.YouTube.v3.Data.Caption body, Google.Apis.Util.Repeatable<string> part)
        {
            return new InsertRequest(service, body, part);
        }

        /// <summary>Inserts a new resource into this collection.</summary>
        public class InsertRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.Caption>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.YouTube.v3.Data.Caption body, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter specifies the caption resource parts that the API response will include. Set the
            /// parameter value to snippet.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>ID of the Google+ Page for the channel that the request is be on behalf of</summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOf", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOf { get; set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The actual CMS account
            /// that the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>
            /// Extra parameter to allow automatically syncing the uploaded caption/transcript with the audio.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("sync", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Sync { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.YouTube.v3.Data.Caption Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/captions";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOf", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOf",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sync", new Google.Apis.Discovery.Parameter
                {
                    Name = "sync",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts a new resource into this collection.</summary>
        /// <remarks>
        /// Considerations regarding <paramref name="stream"/>:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before reading
        /// commences. If <paramref name="stream"/> is not seekable, then it will be read from its current position
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
        /// <param name="part">
        /// The *part* parameter specifies the caption resource parts that the API response will include. Set the
        /// parameter value to snippet.
        /// </param>
        /// <param name="stream">The stream to upload. See remarks for further information.</param>
        /// <param name="contentType">The content type of the stream to upload.</param>
        public virtual InsertMediaUpload Insert(Google.Apis.YouTube.v3.Data.Caption body, Google.Apis.Util.Repeatable<string> part, System.IO.Stream stream, string contentType)
        {
            return new InsertMediaUpload(service, body, part, stream, contentType);
        }

        /// <summary>Insert media upload which supports resumable upload.</summary>
        public class InsertMediaUpload : Google.Apis.Upload.ResumableUpload<Google.Apis.YouTube.v3.Data.Caption, Google.Apis.YouTube.v3.Data.Caption>
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
            /// Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned
            /// to a user, but should not exceed 40 characters.
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
            /// The *part* parameter specifies the caption resource parts that the API response will include. Set the
            /// parameter value to snippet.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>ID of the Google+ Page for the channel that the request is be on behalf of</summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOf", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOf { get; set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The actual CMS account
            /// that the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>
            /// Extra parameter to allow automatically syncing the uploaded caption/transcript with the audio.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("sync", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Sync { get; set; }

            /// <summary>Constructs a new Insert media upload instance.</summary>
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
            public InsertMediaUpload(Google.Apis.Services.IClientService service, Google.Apis.YouTube.v3.Data.Caption body, Google.Apis.Util.Repeatable<string> part, System.IO.Stream stream, string contentType)
                : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "youtube/v3/captions"), "POST", stream, contentType)
            {
                Part = part;
                Body = body;
            }
        }

        /// <summary>Retrieves a list of resources, possibly filtered.</summary>
        /// <param name="part">
        /// The *part* parameter specifies a comma-separated list of one or more caption resource parts that the API
        /// response will include. The part names that you can include in the parameter value are id and snippet.
        /// </param>
        /// <param name="videoId">Returns the captions for the specified video.</param>
        public virtual ListRequest List(Google.Apis.Util.Repeatable<string> part, string videoId)
        {
            return new ListRequest(service, part, videoId);
        }

        /// <summary>Retrieves a list of resources, possibly filtered.</summary>
        public class ListRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.CaptionListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, Google.Apis.Util.Repeatable<string> part, string videoId) : base(service)
            {
                Part = part;
                VideoId = videoId;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter specifies a comma-separated list of one or more caption resource parts that the API
            /// response will include. The part names that you can include in the parameter value are id and snippet.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>Returns the captions for the specified video.</summary>
            [Google.Apis.Util.RequestParameterAttribute("videoId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string VideoId { get; private set; }

            /// <summary>Returns the captions with the given IDs for Stubby or Apiary.</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Id { get; set; }

            /// <summary>ID of the Google+ Page for the channel that the request is on behalf of.</summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOf", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOf { get; set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The actual CMS account
            /// that the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/captions";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("videoId", new Google.Apis.Discovery.Parameter
                {
                    Name = "videoId",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOf", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOf",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates an existing resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="part">
        /// The *part* parameter specifies a comma-separated list of one or more caption resource parts that the API
        /// response will include. The part names that you can include in the parameter value are id and snippet.
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.YouTube.v3.Data.Caption body, Google.Apis.Util.Repeatable<string> part)
        {
            return new UpdateRequest(service, body, part);
        }

        /// <summary>Updates an existing resource.</summary>
        public class UpdateRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.Caption>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.YouTube.v3.Data.Caption body, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter specifies a comma-separated list of one or more caption resource parts that the API
            /// response will include. The part names that you can include in the parameter value are id and snippet.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>ID of the Google+ Page for the channel that the request is on behalf of.</summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOf", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOf { get; set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The actual CMS account
            /// that the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>
            /// Extra parameter to allow automatically syncing the uploaded caption/transcript with the audio.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("sync", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Sync { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.YouTube.v3.Data.Caption Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/captions";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOf", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOf",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sync", new Google.Apis.Discovery.Parameter
                {
                    Name = "sync",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates an existing resource.</summary>
        /// <remarks>
        /// Considerations regarding <paramref name="stream"/>:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before reading
        /// commences. If <paramref name="stream"/> is not seekable, then it will be read from its current position
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
        /// <param name="part">
        /// The *part* parameter specifies a comma-separated list of one or more caption resource parts that the API
        /// response will include. The part names that you can include in the parameter value are id and snippet.
        /// </param>
        /// <param name="stream">The stream to upload. See remarks for further information.</param>
        /// <param name="contentType">The content type of the stream to upload.</param>
        public virtual UpdateMediaUpload Update(Google.Apis.YouTube.v3.Data.Caption body, Google.Apis.Util.Repeatable<string> part, System.IO.Stream stream, string contentType)
        {
            return new UpdateMediaUpload(service, body, part, stream, contentType);
        }

        /// <summary>Update media upload which supports resumable upload.</summary>
        public class UpdateMediaUpload : Google.Apis.Upload.ResumableUpload<Google.Apis.YouTube.v3.Data.Caption, Google.Apis.YouTube.v3.Data.Caption>
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
            /// Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned
            /// to a user, but should not exceed 40 characters.
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
            /// The *part* parameter specifies a comma-separated list of one or more caption resource parts that the API
            /// response will include. The part names that you can include in the parameter value are id and snippet.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>ID of the Google+ Page for the channel that the request is on behalf of.</summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOf", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOf { get; set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The actual CMS account
            /// that the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>
            /// Extra parameter to allow automatically syncing the uploaded caption/transcript with the audio.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("sync", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Sync { get; set; }

            /// <summary>Constructs a new Update media upload instance.</summary>
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
            public UpdateMediaUpload(Google.Apis.Services.IClientService service, Google.Apis.YouTube.v3.Data.Caption body, Google.Apis.Util.Repeatable<string> part, System.IO.Stream stream, string contentType)
                : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "youtube/v3/captions"), "PUT", stream, contentType)
            {
                Part = part;
                Body = body;
            }
        }
    }

    /// <summary>The "channelBanners" collection of methods.</summary>
    public class ChannelBannersResource
    {
        private const string Resource = "channelBanners";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ChannelBannersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Inserts a new resource into this collection.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual InsertRequest Insert(Google.Apis.YouTube.v3.Data.ChannelBannerResource body)
        {
            return new InsertRequest(service, body);
        }

        /// <summary>Inserts a new resource into this collection.</summary>
        public class InsertRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.ChannelBannerResource>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.YouTube.v3.Data.ChannelBannerResource body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Unused, channel_id is currently derived from the security context of the requestor.</summary>
            [Google.Apis.Util.RequestParameterAttribute("channelId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ChannelId { get; set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The actual CMS account
            /// that the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>
            /// This parameter can only be used in a properly authorized request. *Note:* This parameter is intended
            /// exclusively for YouTube content partners. The *onBehalfOfContentOwnerChannel* parameter specifies the
            /// YouTube channel ID of the channel to which a video is being added. This parameter is required when a
            /// request specifies a value for the onBehalfOfContentOwner parameter, and it can only be used in
            /// conjunction with that parameter. In addition, the request must be authorized using a CMS account that is
            /// linked to the content owner that the onBehalfOfContentOwner parameter specifies. Finally, the channel
            /// that the onBehalfOfContentOwnerChannel parameter value specifies must be linked to the content owner
            /// that the onBehalfOfContentOwner parameter specifies. This parameter is intended for YouTube content
            /// partners that own and manage many different YouTube channels. It allows content owners to authenticate
            /// once and perform actions on behalf of the channel specified in the parameter value, without having to
            /// provide authentication credentials for each separate channel.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwnerChannel", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwnerChannel { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.YouTube.v3.Data.ChannelBannerResource Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/channelBanners/insert";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("channelId", new Google.Apis.Discovery.Parameter
                {
                    Name = "channelId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwnerChannel", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwnerChannel",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts a new resource into this collection.</summary>
        /// <remarks>
        /// Considerations regarding <paramref name="stream"/>:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before reading
        /// commences. If <paramref name="stream"/> is not seekable, then it will be read from its current position
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
        /// <param name="stream">The stream to upload. See remarks for further information.</param>
        /// <param name="contentType">The content type of the stream to upload.</param>
        public virtual InsertMediaUpload Insert(Google.Apis.YouTube.v3.Data.ChannelBannerResource body, System.IO.Stream stream, string contentType)
        {
            return new InsertMediaUpload(service, body, stream, contentType);
        }

        /// <summary>Insert media upload which supports resumable upload.</summary>
        public class InsertMediaUpload : Google.Apis.Upload.ResumableUpload<Google.Apis.YouTube.v3.Data.ChannelBannerResource, Google.Apis.YouTube.v3.Data.ChannelBannerResource>
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
            /// Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned
            /// to a user, but should not exceed 40 characters.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string QuotaUser { get; set; }

            /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
            [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UploadType { get; set; }

            /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
            [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UploadProtocol { get; set; }

            /// <summary>Unused, channel_id is currently derived from the security context of the requestor.</summary>
            [Google.Apis.Util.RequestParameterAttribute("channelId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ChannelId { get; set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The actual CMS account
            /// that the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>
            /// This parameter can only be used in a properly authorized request. *Note:* This parameter is intended
            /// exclusively for YouTube content partners. The *onBehalfOfContentOwnerChannel* parameter specifies the
            /// YouTube channel ID of the channel to which a video is being added. This parameter is required when a
            /// request specifies a value for the onBehalfOfContentOwner parameter, and it can only be used in
            /// conjunction with that parameter. In addition, the request must be authorized using a CMS account that is
            /// linked to the content owner that the onBehalfOfContentOwner parameter specifies. Finally, the channel
            /// that the onBehalfOfContentOwnerChannel parameter value specifies must be linked to the content owner
            /// that the onBehalfOfContentOwner parameter specifies. This parameter is intended for YouTube content
            /// partners that own and manage many different YouTube channels. It allows content owners to authenticate
            /// once and perform actions on behalf of the channel specified in the parameter value, without having to
            /// provide authentication credentials for each separate channel.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwnerChannel", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwnerChannel { get; set; }

            /// <summary>Constructs a new Insert media upload instance.</summary>
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
            public InsertMediaUpload(Google.Apis.Services.IClientService service, Google.Apis.YouTube.v3.Data.ChannelBannerResource body, System.IO.Stream stream, string contentType)
                : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "youtube/v3/channelBanners/insert"), "POST", stream, contentType)
            {
                Body = body;
            }
        }
    }

    /// <summary>The "channelSections" collection of methods.</summary>
    public class ChannelSectionsResource
    {
        private const string Resource = "channelSections";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ChannelSectionsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Deletes a resource.</summary>
        /// <param name="id"><c>null</c></param>
        public virtual DeleteRequest Delete(string id)
        {
            return new DeleteRequest(service, id);
        }

        /// <summary>Deletes a resource.</summary>
        public class DeleteRequest : YouTubeBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string id) : base(service)
            {
                Id = id;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Id { get; private set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The CMS account that
            /// the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/channelSections";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts a new resource into this collection.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="part">
        /// The *part* parameter serves two purposes in this operation. It identifies the properties that the write
        /// operation will set as well as the properties that the API response will include. The part names that you can
        /// include in the parameter value are snippet and contentDetails.
        /// </param>
        public virtual InsertRequest Insert(Google.Apis.YouTube.v3.Data.ChannelSection body, Google.Apis.Util.Repeatable<string> part)
        {
            return new InsertRequest(service, body, part);
        }

        /// <summary>Inserts a new resource into this collection.</summary>
        public class InsertRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.ChannelSection>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.YouTube.v3.Data.ChannelSection body, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter serves two purposes in this operation. It identifies the properties that the write
            /// operation will set as well as the properties that the API response will include. The part names that you
            /// can include in the parameter value are snippet and contentDetails.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The CMS account that
            /// the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>
            /// This parameter can only be used in a properly authorized request. *Note:* This parameter is intended
            /// exclusively for YouTube content partners. The *onBehalfOfContentOwnerChannel* parameter specifies the
            /// YouTube channel ID of the channel to which a video is being added. This parameter is required when a
            /// request specifies a value for the onBehalfOfContentOwner parameter, and it can only be used in
            /// conjunction with that parameter. In addition, the request must be authorized using a CMS account that is
            /// linked to the content owner that the onBehalfOfContentOwner parameter specifies. Finally, the channel
            /// that the onBehalfOfContentOwnerChannel parameter value specifies must be linked to the content owner
            /// that the onBehalfOfContentOwner parameter specifies. This parameter is intended for YouTube content
            /// partners that own and manage many different YouTube channels. It allows content owners to authenticate
            /// once and perform actions on behalf of the channel specified in the parameter value, without having to
            /// provide authentication credentials for each separate channel.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwnerChannel", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwnerChannel { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.YouTube.v3.Data.ChannelSection Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/channelSections";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwnerChannel", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwnerChannel",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves a list of resources, possibly filtered.</summary>
        /// <param name="part">
        /// The *part* parameter specifies a comma-separated list of one or more channelSection resource properties that
        /// the API response will include. The part names that you can include in the parameter value are id, snippet,
        /// and contentDetails. If the parameter identifies a property that contains child properties, the child
        /// properties will be included in the response. For example, in a channelSection resource, the snippet property
        /// contains other properties, such as a display title for the channelSection. If you set *part=snippet*, the
        /// API response will also contain all of those nested properties.
        /// </param>
        public virtual ListRequest List(Google.Apis.Util.Repeatable<string> part)
        {
            return new ListRequest(service, part);
        }

        /// <summary>Retrieves a list of resources, possibly filtered.</summary>
        public class ListRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.ChannelSectionListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter specifies a comma-separated list of one or more channelSection resource properties
            /// that the API response will include. The part names that you can include in the parameter value are id,
            /// snippet, and contentDetails. If the parameter identifies a property that contains child properties, the
            /// child properties will be included in the response. For example, in a channelSection resource, the
            /// snippet property contains other properties, such as a display title for the channelSection. If you set
            /// *part=snippet*, the API response will also contain all of those nested properties.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>Return the ChannelSections owned by the specified channel ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("channelId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ChannelId { get; set; }

            /// <summary>Return content in specified language</summary>
            [Google.Apis.Util.RequestParameterAttribute("hl", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Hl { get; set; }

            /// <summary>Return the ChannelSections with the given IDs for Stubby or Apiary.</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Id { get; set; }

            /// <summary>Return the ChannelSections owned by the authenticated user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("mine", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Mine { get; set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The CMS account that
            /// the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/channelSections";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("channelId", new Google.Apis.Discovery.Parameter
                {
                    Name = "channelId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("hl", new Google.Apis.Discovery.Parameter
                {
                    Name = "hl",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("mine", new Google.Apis.Discovery.Parameter
                {
                    Name = "mine",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates an existing resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="part">
        /// The *part* parameter serves two purposes in this operation. It identifies the properties that the write
        /// operation will set as well as the properties that the API response will include. The part names that you can
        /// include in the parameter value are snippet and contentDetails.
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.YouTube.v3.Data.ChannelSection body, Google.Apis.Util.Repeatable<string> part)
        {
            return new UpdateRequest(service, body, part);
        }

        /// <summary>Updates an existing resource.</summary>
        public class UpdateRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.ChannelSection>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.YouTube.v3.Data.ChannelSection body, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter serves two purposes in this operation. It identifies the properties that the write
            /// operation will set as well as the properties that the API response will include. The part names that you
            /// can include in the parameter value are snippet and contentDetails.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The CMS account that
            /// the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.YouTube.v3.Data.ChannelSection Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/channelSections";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "channels" collection of methods.</summary>
    public class ChannelsResource
    {
        private const string Resource = "channels";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ChannelsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Retrieves a list of resources, possibly filtered.</summary>
        /// <param name="part">
        /// The *part* parameter specifies a comma-separated list of one or more channel resource properties that the
        /// API response will include. If the parameter identifies a property that contains child properties, the child
        /// properties will be included in the response. For example, in a channel resource, the contentDetails property
        /// contains other properties, such as the uploads properties. As such, if you set *part=contentDetails*, the
        /// API response will also contain all of those nested properties.
        /// </param>
        public virtual ListRequest List(Google.Apis.Util.Repeatable<string> part)
        {
            return new ListRequest(service, part);
        }

        /// <summary>Retrieves a list of resources, possibly filtered.</summary>
        public class ListRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.ChannelListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter specifies a comma-separated list of one or more channel resource properties that
            /// the API response will include. If the parameter identifies a property that contains child properties,
            /// the child properties will be included in the response. For example, in a channel resource, the
            /// contentDetails property contains other properties, such as the uploads properties. As such, if you set
            /// *part=contentDetails*, the API response will also contain all of those nested properties.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>Return the channels within the specified guide category ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("categoryId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CategoryId { get; set; }

            /// <summary>Return the channel associated with a YouTube username.</summary>
            [Google.Apis.Util.RequestParameterAttribute("forUsername", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ForUsername { get; set; }

            /// <summary>
            /// Stands for "host language". Specifies the localization language of the metadata to be filled into
            /// snippet.localized. The field is filled with the default metadata if there is no localization in the
            /// specified language. The parameter value must be a language code included in the list returned by the
            /// i18nLanguages.list method (e.g. en_US, es_MX).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("hl", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Hl { get; set; }

            /// <summary>Return the channels with the specified IDs.</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Id { get; set; }

            /// <summary>Return the channels managed by the authenticated user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("managedByMe", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ManagedByMe { get; set; }

            /// <summary>
            /// The *maxResults* parameter specifies the maximum number of items that should be returned in the result
            /// set.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>Return the ids of channels owned by the authenticated user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("mine", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Mine { get; set; }

            /// <summary>Return the channels subscribed to the authenticated user</summary>
            [Google.Apis.Util.RequestParameterAttribute("mySubscribers", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> MySubscribers { get; set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The CMS account that
            /// the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>
            /// The *pageToken* parameter identifies a specific page in the result set that should be returned. In an
            /// API response, the nextPageToken and prevPageToken properties identify other pages that could be
            /// retrieved.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/channels";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("categoryId", new Google.Apis.Discovery.Parameter
                {
                    Name = "categoryId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("forUsername", new Google.Apis.Discovery.Parameter
                {
                    Name = "forUsername",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("hl", new Google.Apis.Discovery.Parameter
                {
                    Name = "hl",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("managedByMe", new Google.Apis.Discovery.Parameter
                {
                    Name = "managedByMe",
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
                    DefaultValue = "5",
                    Pattern = null,
                });
                RequestParameters.Add("mine", new Google.Apis.Discovery.Parameter
                {
                    Name = "mine",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("mySubscribers", new Google.Apis.Discovery.Parameter
                {
                    Name = "mySubscribers",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
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

        /// <summary>Updates an existing resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="part">
        /// The *part* parameter serves two purposes in this operation. It identifies the properties that the write
        /// operation will set as well as the properties that the API response will include. The API currently only
        /// allows the parameter value to be set to either brandingSettings or invideoPromotion. (You cannot update both
        /// of those parts with a single request.) Note that this method overrides the existing values for all of the
        /// mutable properties that are contained in any parts that the parameter value specifies.
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.YouTube.v3.Data.Channel body, Google.Apis.Util.Repeatable<string> part)
        {
            return new UpdateRequest(service, body, part);
        }

        /// <summary>Updates an existing resource.</summary>
        public class UpdateRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.Channel>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.YouTube.v3.Data.Channel body, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter serves two purposes in this operation. It identifies the properties that the write
            /// operation will set as well as the properties that the API response will include. The API currently only
            /// allows the parameter value to be set to either brandingSettings or invideoPromotion. (You cannot update
            /// both of those parts with a single request.) Note that this method overrides the existing values for all
            /// of the mutable properties that are contained in any parts that the parameter value specifies.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>
            /// The *onBehalfOfContentOwner* parameter indicates that the authenticated user is acting on behalf of the
            /// content owner specified in the parameter value. This parameter is intended for YouTube content partners
            /// that own and manage many different YouTube channels. It allows content owners to authenticate once and
            /// get access to all their video and channel data, without having to provide authentication credentials for
            /// each individual channel. The actual CMS account that the user authenticates with needs to be linked to
            /// the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.YouTube.v3.Data.Channel Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/channels";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "commentThreads" collection of methods.</summary>
    public class CommentThreadsResource
    {
        private const string Resource = "commentThreads";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public CommentThreadsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Inserts a new resource into this collection.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="part">
        /// The *part* parameter identifies the properties that the API response will include. Set the parameter value
        /// to snippet. The snippet part has a quota cost of 2 units.
        /// </param>
        public virtual InsertRequest Insert(Google.Apis.YouTube.v3.Data.CommentThread body, Google.Apis.Util.Repeatable<string> part)
        {
            return new InsertRequest(service, body, part);
        }

        /// <summary>Inserts a new resource into this collection.</summary>
        public class InsertRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.CommentThread>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.YouTube.v3.Data.CommentThread body, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter identifies the properties that the API response will include. Set the parameter
            /// value to snippet. The snippet part has a quota cost of 2 units.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.YouTube.v3.Data.CommentThread Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/commentThreads";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves a list of resources, possibly filtered.</summary>
        /// <param name="part">
        /// The *part* parameter specifies a comma-separated list of one or more commentThread resource properties that
        /// the API response will include.
        /// </param>
        public virtual ListRequest List(Google.Apis.Util.Repeatable<string> part)
        {
            return new ListRequest(service, part);
        }

        /// <summary>Retrieves a list of resources, possibly filtered.</summary>
        public class ListRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.CommentThreadListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter specifies a comma-separated list of one or more commentThread resource properties
            /// that the API response will include.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>
            /// Returns the comment threads of all videos of the channel and the channel comments as well.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("allThreadsRelatedToChannelId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string AllThreadsRelatedToChannelId { get; set; }

            /// <summary>
            /// Returns the comment threads for all the channel comments (ie does not include comments left on videos).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("channelId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ChannelId { get; set; }

            /// <summary>Returns the comment threads with the given IDs for Stubby or Apiary.</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Id { get; set; }

            /// <summary>
            /// The *maxResults* parameter specifies the maximum number of items that should be returned in the result
            /// set.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>
            /// Limits the returned comment threads to those with the specified moderation status. Not compatible with
            /// the 'id' filter. Valid values: published, heldForReview, likelySpam.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("moderationStatus", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ModerationStatusEnum> ModerationStatus { get; set; }

            /// <summary>
            /// Limits the returned comment threads to those with the specified moderation status. Not compatible with
            /// the 'id' filter. Valid values: published, heldForReview, likelySpam.
            /// </summary>
            public enum ModerationStatusEnum
            {
                /// <summary>The comment is available for public display.</summary>
                [Google.Apis.Util.StringValueAttribute("published")]
                Published = 0,

                /// <summary>The comment is awaiting review by a moderator.</summary>
                [Google.Apis.Util.StringValueAttribute("heldForReview")]
                HeldForReview = 1,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("likelySpam")]
                LikelySpam = 2,

                /// <summary>The comment is unfit for display.</summary>
                [Google.Apis.Util.StringValueAttribute("rejected")]
                Rejected = 3,
            }

            [Google.Apis.Util.RequestParameterAttribute("order", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<OrderEnum> Order { get; set; }

            public enum OrderEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("orderUnspecified")]
                OrderUnspecified = 0,

                /// <summary>Order by time.</summary>
                [Google.Apis.Util.StringValueAttribute("time")]
                Time = 1,

                /// <summary>Order by relevance.</summary>
                [Google.Apis.Util.StringValueAttribute("relevance")]
                Relevance = 2,
            }

            /// <summary>
            /// The *pageToken* parameter identifies a specific page in the result set that should be returned. In an
            /// API response, the nextPageToken and prevPageToken properties identify other pages that could be
            /// retrieved.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Limits the returned comment threads to those matching the specified key words. Not compatible with the
            /// 'id' filter.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("searchTerms", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string SearchTerms { get; set; }

            /// <summary>The requested text format for the returned comments.</summary>
            [Google.Apis.Util.RequestParameterAttribute("textFormat", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<TextFormatEnum> TextFormat { get; set; }

            /// <summary>The requested text format for the returned comments.</summary>
            public enum TextFormatEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("textFormatUnspecified")]
                TextFormatUnspecified = 0,

                /// <summary>Returns the comments in HTML format. This is the default value.</summary>
                [Google.Apis.Util.StringValueAttribute("html")]
                Html = 1,

                /// <summary>Returns the comments in plain text format.</summary>
                [Google.Apis.Util.StringValueAttribute("plainText")]
                PlainText = 2,
            }

            /// <summary>Returns the comment threads of the specified video.</summary>
            [Google.Apis.Util.RequestParameterAttribute("videoId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string VideoId { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/commentThreads";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("allThreadsRelatedToChannelId", new Google.Apis.Discovery.Parameter
                {
                    Name = "allThreadsRelatedToChannelId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("channelId", new Google.Apis.Discovery.Parameter
                {
                    Name = "channelId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
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
                    DefaultValue = "20",
                    Pattern = null,
                });
                RequestParameters.Add("moderationStatus", new Google.Apis.Discovery.Parameter
                {
                    Name = "moderationStatus",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "published",
                    Pattern = null,
                });
                RequestParameters.Add("order", new Google.Apis.Discovery.Parameter
                {
                    Name = "order",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "time",
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
                RequestParameters.Add("searchTerms", new Google.Apis.Discovery.Parameter
                {
                    Name = "searchTerms",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("textFormat", new Google.Apis.Discovery.Parameter
                {
                    Name = "textFormat",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "html",
                    Pattern = null,
                });
                RequestParameters.Add("videoId", new Google.Apis.Discovery.Parameter
                {
                    Name = "videoId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "comments" collection of methods.</summary>
    public class CommentsResource
    {
        private const string Resource = "comments";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public CommentsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Deletes a resource.</summary>
        /// <param name="id"><c>null</c></param>
        public virtual DeleteRequest Delete(string id)
        {
            return new DeleteRequest(service, id);
        }

        /// <summary>Deletes a resource.</summary>
        public class DeleteRequest : YouTubeBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string id) : base(service)
            {
                Id = id;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Id { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/comments";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts a new resource into this collection.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="part">
        /// The *part* parameter identifies the properties that the API response will include. Set the parameter value
        /// to snippet. The snippet part has a quota cost of 2 units.
        /// </param>
        public virtual InsertRequest Insert(Google.Apis.YouTube.v3.Data.Comment body, Google.Apis.Util.Repeatable<string> part)
        {
            return new InsertRequest(service, body, part);
        }

        /// <summary>Inserts a new resource into this collection.</summary>
        public class InsertRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.Comment>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.YouTube.v3.Data.Comment body, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter identifies the properties that the API response will include. Set the parameter
            /// value to snippet. The snippet part has a quota cost of 2 units.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.YouTube.v3.Data.Comment Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/comments";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves a list of resources, possibly filtered.</summary>
        /// <param name="part">
        /// The *part* parameter specifies a comma-separated list of one or more comment resource properties that the
        /// API response will include.
        /// </param>
        public virtual ListRequest List(Google.Apis.Util.Repeatable<string> part)
        {
            return new ListRequest(service, part);
        }

        /// <summary>Retrieves a list of resources, possibly filtered.</summary>
        public class ListRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.CommentListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter specifies a comma-separated list of one or more comment resource properties that
            /// the API response will include.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>Returns the comments with the given IDs for One Platform.</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Id { get; set; }

            /// <summary>
            /// The *maxResults* parameter specifies the maximum number of items that should be returned in the result
            /// set.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>
            /// The *pageToken* parameter identifies a specific page in the result set that should be returned. In an
            /// API response, the nextPageToken and prevPageToken properties identify other pages that could be
            /// retrieved.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Returns replies to the specified comment. Note, currently YouTube features only one level of replies (ie
            /// replies to top level comments). However replies to replies may be supported in the future.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parentId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ParentId { get; set; }

            /// <summary>The requested text format for the returned comments.</summary>
            [Google.Apis.Util.RequestParameterAttribute("textFormat", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<TextFormatEnum> TextFormat { get; set; }

            /// <summary>The requested text format for the returned comments.</summary>
            public enum TextFormatEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("textFormatUnspecified")]
                TextFormatUnspecified = 0,

                /// <summary>Returns the comments in HTML format. This is the default value.</summary>
                [Google.Apis.Util.StringValueAttribute("html")]
                Html = 1,

                /// <summary>Returns the comments in plain text format.</summary>
                [Google.Apis.Util.StringValueAttribute("plainText")]
                PlainText = 2,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/comments";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
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
                RequestParameters.Add("parentId", new Google.Apis.Discovery.Parameter
                {
                    Name = "parentId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("textFormat", new Google.Apis.Discovery.Parameter
                {
                    Name = "textFormat",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "html",
                    Pattern = null,
                });
            }
        }

        /// <summary>Expresses the caller's opinion that one or more comments should be flagged as spam.</summary>
        /// <param name="id">Flags the comments with the given IDs as spam in the caller's opinion.</param>
        public virtual MarkAsSpamRequest MarkAsSpam(Google.Apis.Util.Repeatable<string> id)
        {
            return new MarkAsSpamRequest(service, id);
        }

        /// <summary>Expresses the caller's opinion that one or more comments should be flagged as spam.</summary>
        public class MarkAsSpamRequest : YouTubeBaseServiceRequest<string>
        {
            /// <summary>Constructs a new MarkAsSpam request.</summary>
            public MarkAsSpamRequest(Google.Apis.Services.IClientService service, Google.Apis.Util.Repeatable<string> id) : base(service)
            {
                Id = id;
                InitParameters();
            }

            /// <summary>Flags the comments with the given IDs as spam in the caller's opinion.</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Id { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "markAsSpam";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/comments/markAsSpam";

            /// <summary>Initializes MarkAsSpam parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Sets the moderation status of one or more comments.</summary>
        /// <param name="id">Modifies the moderation status of the comments with the given IDs</param>
        /// <param name="moderationStatus">
        /// Specifies the requested moderation status. Note, comments can be in statuses, which are not available
        /// through this call. For example, this call does not allow to mark a comment as 'likely spam'. Valid values:
        /// MODERATION_STATUS_PUBLISHED, MODERATION_STATUS_HELD_FOR_REVIEW, MODERATION_STATUS_REJECTED.
        /// </param>
        public virtual SetModerationStatusRequest SetModerationStatus(Google.Apis.Util.Repeatable<string> id, SetModerationStatusRequest.ModerationStatusEnum moderationStatus)
        {
            return new SetModerationStatusRequest(service, id, moderationStatus);
        }

        /// <summary>Sets the moderation status of one or more comments.</summary>
        public class SetModerationStatusRequest : YouTubeBaseServiceRequest<string>
        {
            /// <summary>Constructs a new SetModerationStatus request.</summary>
            public SetModerationStatusRequest(Google.Apis.Services.IClientService service, Google.Apis.Util.Repeatable<string> id, ModerationStatusEnum moderationStatus) : base(service)
            {
                Id = id;
                ModerationStatus = moderationStatus;
                InitParameters();
            }

            /// <summary>Modifies the moderation status of the comments with the given IDs</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Id { get; private set; }

            /// <summary>
            /// Specifies the requested moderation status. Note, comments can be in statuses, which are not available
            /// through this call. For example, this call does not allow to mark a comment as 'likely spam'. Valid
            /// values: MODERATION_STATUS_PUBLISHED, MODERATION_STATUS_HELD_FOR_REVIEW, MODERATION_STATUS_REJECTED.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("moderationStatus", Google.Apis.Util.RequestParameterType.Query)]
            public virtual ModerationStatusEnum ModerationStatus { get; private set; }

            /// <summary>
            /// Specifies the requested moderation status. Note, comments can be in statuses, which are not available
            /// through this call. For example, this call does not allow to mark a comment as 'likely spam'. Valid
            /// values: MODERATION_STATUS_PUBLISHED, MODERATION_STATUS_HELD_FOR_REVIEW, MODERATION_STATUS_REJECTED.
            /// </summary>
            public enum ModerationStatusEnum
            {
                /// <summary>The comment is available for public display.</summary>
                [Google.Apis.Util.StringValueAttribute("published")]
                Published = 0,

                /// <summary>The comment is awaiting review by a moderator.</summary>
                [Google.Apis.Util.StringValueAttribute("heldForReview")]
                HeldForReview = 1,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("likelySpam")]
                LikelySpam = 2,

                /// <summary>The comment is unfit for display.</summary>
                [Google.Apis.Util.StringValueAttribute("rejected")]
                Rejected = 3,
            }

            /// <summary>
            /// If set to true the author of the comment gets added to the ban list. This means all future comments of
            /// the author will autmomatically be rejected. Only valid in combination with STATUS_REJECTED.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("banAuthor", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> BanAuthor { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "setModerationStatus";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/comments/setModerationStatus";

            /// <summary>Initializes SetModerationStatus parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("moderationStatus", new Google.Apis.Discovery.Parameter
                {
                    Name = "moderationStatus",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("banAuthor", new Google.Apis.Discovery.Parameter
                {
                    Name = "banAuthor",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates an existing resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="part">
        /// The *part* parameter identifies the properties that the API response will include. You must at least include
        /// the snippet part in the parameter value since that part contains all of the properties that the API request
        /// can update.
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.YouTube.v3.Data.Comment body, Google.Apis.Util.Repeatable<string> part)
        {
            return new UpdateRequest(service, body, part);
        }

        /// <summary>Updates an existing resource.</summary>
        public class UpdateRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.Comment>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.YouTube.v3.Data.Comment body, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter identifies the properties that the API response will include. You must at least
            /// include the snippet part in the parameter value since that part contains all of the properties that the
            /// API request can update.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.YouTube.v3.Data.Comment Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/comments";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "i18nLanguages" collection of methods.</summary>
    public class I18nLanguagesResource
    {
        private const string Resource = "i18nLanguages";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public I18nLanguagesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Retrieves a list of resources, possibly filtered.</summary>
        /// <param name="part">
        /// The *part* parameter specifies the i18nLanguage resource properties that the API response will include. Set
        /// the parameter value to snippet.
        /// </param>
        public virtual ListRequest List(Google.Apis.Util.Repeatable<string> part)
        {
            return new ListRequest(service, part);
        }

        /// <summary>Retrieves a list of resources, possibly filtered.</summary>
        public class ListRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.I18nLanguageListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter specifies the i18nLanguage resource properties that the API response will include.
            /// Set the parameter value to snippet.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("hl", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Hl { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/i18nLanguages";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("hl", new Google.Apis.Discovery.Parameter
                {
                    Name = "hl",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "en_US",
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "i18nRegions" collection of methods.</summary>
    public class I18nRegionsResource
    {
        private const string Resource = "i18nRegions";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public I18nRegionsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Retrieves a list of resources, possibly filtered.</summary>
        /// <param name="part">
        /// The *part* parameter specifies the i18nRegion resource properties that the API response will include. Set
        /// the parameter value to snippet.
        /// </param>
        public virtual ListRequest List(Google.Apis.Util.Repeatable<string> part)
        {
            return new ListRequest(service, part);
        }

        /// <summary>Retrieves a list of resources, possibly filtered.</summary>
        public class ListRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.I18nRegionListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter specifies the i18nRegion resource properties that the API response will include.
            /// Set the parameter value to snippet.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("hl", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Hl { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/i18nRegions";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("hl", new Google.Apis.Discovery.Parameter
                {
                    Name = "hl",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "en_US",
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "liveBroadcasts" collection of methods.</summary>
    public class LiveBroadcastsResource
    {
        private const string Resource = "liveBroadcasts";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public LiveBroadcastsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Bind a broadcast to a stream.</summary>
        /// <param name="id">Broadcast to bind to the stream</param>
        /// <param name="part">
        /// The *part* parameter specifies a comma-separated list of one or more liveBroadcast resource properties that
        /// the API response will include. The part names that you can include in the parameter value are id, snippet,
        /// contentDetails, and status.
        /// </param>
        public virtual BindRequest Bind(string id, Google.Apis.Util.Repeatable<string> part)
        {
            return new BindRequest(service, id, part);
        }

        /// <summary>Bind a broadcast to a stream.</summary>
        public class BindRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.LiveBroadcast>
        {
            /// <summary>Constructs a new Bind request.</summary>
            public BindRequest(Google.Apis.Services.IClientService service, string id, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Id = id;
                Part = part;
                InitParameters();
            }

            /// <summary>Broadcast to bind to the stream</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Id { get; private set; }

            /// <summary>
            /// The *part* parameter specifies a comma-separated list of one or more liveBroadcast resource properties
            /// that the API response will include. The part names that you can include in the parameter value are id,
            /// snippet, contentDetails, and status.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The CMS account that
            /// the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>
            /// This parameter can only be used in a properly authorized request. *Note:* This parameter is intended
            /// exclusively for YouTube content partners. The *onBehalfOfContentOwnerChannel* parameter specifies the
            /// YouTube channel ID of the channel to which a video is being added. This parameter is required when a
            /// request specifies a value for the onBehalfOfContentOwner parameter, and it can only be used in
            /// conjunction with that parameter. In addition, the request must be authorized using a CMS account that is
            /// linked to the content owner that the onBehalfOfContentOwner parameter specifies. Finally, the channel
            /// that the onBehalfOfContentOwnerChannel parameter value specifies must be linked to the content owner
            /// that the onBehalfOfContentOwner parameter specifies. This parameter is intended for YouTube content
            /// partners that own and manage many different YouTube channels. It allows content owners to authenticate
            /// once and perform actions on behalf of the channel specified in the parameter value, without having to
            /// provide authentication credentials for each separate channel.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwnerChannel", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwnerChannel { get; set; }

            /// <summary>Stream to bind, if not set unbind the current one.</summary>
            [Google.Apis.Util.RequestParameterAttribute("streamId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string StreamId { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "bind";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/liveBroadcasts/bind";

            /// <summary>Initializes Bind parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwnerChannel", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwnerChannel",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("streamId", new Google.Apis.Discovery.Parameter
                {
                    Name = "streamId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Delete a given broadcast.</summary>
        /// <param name="id">Broadcast to delete.</param>
        public virtual DeleteRequest Delete(string id)
        {
            return new DeleteRequest(service, id);
        }

        /// <summary>Delete a given broadcast.</summary>
        public class DeleteRequest : YouTubeBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string id) : base(service)
            {
                Id = id;
                InitParameters();
            }

            /// <summary>Broadcast to delete.</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Id { get; private set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The CMS account that
            /// the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>
            /// This parameter can only be used in a properly authorized request. *Note:* This parameter is intended
            /// exclusively for YouTube content partners. The *onBehalfOfContentOwnerChannel* parameter specifies the
            /// YouTube channel ID of the channel to which a video is being added. This parameter is required when a
            /// request specifies a value for the onBehalfOfContentOwner parameter, and it can only be used in
            /// conjunction with that parameter. In addition, the request must be authorized using a CMS account that is
            /// linked to the content owner that the onBehalfOfContentOwner parameter specifies. Finally, the channel
            /// that the onBehalfOfContentOwnerChannel parameter value specifies must be linked to the content owner
            /// that the onBehalfOfContentOwner parameter specifies. This parameter is intended for YouTube content
            /// partners that own and manage many different YouTube channels. It allows content owners to authenticate
            /// once and perform actions on behalf of the channel specified in the parameter value, without having to
            /// provide authentication credentials for each separate channel.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwnerChannel", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwnerChannel { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/liveBroadcasts";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwnerChannel", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwnerChannel",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts a new stream for the authenticated user.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="part">
        /// The *part* parameter serves two purposes in this operation. It identifies the properties that the write
        /// operation will set as well as the properties that the API response will include. The part properties that
        /// you can include in the parameter value are id, snippet, contentDetails, and status.
        /// </param>
        public virtual InsertRequest Insert(Google.Apis.YouTube.v3.Data.LiveBroadcast body, Google.Apis.Util.Repeatable<string> part)
        {
            return new InsertRequest(service, body, part);
        }

        /// <summary>Inserts a new stream for the authenticated user.</summary>
        public class InsertRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.LiveBroadcast>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.YouTube.v3.Data.LiveBroadcast body, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter serves two purposes in this operation. It identifies the properties that the write
            /// operation will set as well as the properties that the API response will include. The part properties
            /// that you can include in the parameter value are id, snippet, contentDetails, and status.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The CMS account that
            /// the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>
            /// This parameter can only be used in a properly authorized request. *Note:* This parameter is intended
            /// exclusively for YouTube content partners. The *onBehalfOfContentOwnerChannel* parameter specifies the
            /// YouTube channel ID of the channel to which a video is being added. This parameter is required when a
            /// request specifies a value for the onBehalfOfContentOwner parameter, and it can only be used in
            /// conjunction with that parameter. In addition, the request must be authorized using a CMS account that is
            /// linked to the content owner that the onBehalfOfContentOwner parameter specifies. Finally, the channel
            /// that the onBehalfOfContentOwnerChannel parameter value specifies must be linked to the content owner
            /// that the onBehalfOfContentOwner parameter specifies. This parameter is intended for YouTube content
            /// partners that own and manage many different YouTube channels. It allows content owners to authenticate
            /// once and perform actions on behalf of the channel specified in the parameter value, without having to
            /// provide authentication credentials for each separate channel.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwnerChannel", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwnerChannel { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.YouTube.v3.Data.LiveBroadcast Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/liveBroadcasts";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwnerChannel", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwnerChannel",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieve the list of broadcasts associated with the given channel.</summary>
        /// <param name="part">
        /// The *part* parameter specifies a comma-separated list of one or more liveBroadcast resource properties that
        /// the API response will include. The part names that you can include in the parameter value are id, snippet,
        /// contentDetails, status and statistics.
        /// </param>
        public virtual ListRequest List(Google.Apis.Util.Repeatable<string> part)
        {
            return new ListRequest(service, part);
        }

        /// <summary>Retrieve the list of broadcasts associated with the given channel.</summary>
        public class ListRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.LiveBroadcastListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter specifies a comma-separated list of one or more liveBroadcast resource properties
            /// that the API response will include. The part names that you can include in the parameter value are id,
            /// snippet, contentDetails, status and statistics.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>Return broadcasts with a certain status, e.g. active broadcasts.</summary>
            [Google.Apis.Util.RequestParameterAttribute("broadcastStatus", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<BroadcastStatusEnum> BroadcastStatus { get; set; }

            /// <summary>Return broadcasts with a certain status, e.g. active broadcasts.</summary>
            public enum BroadcastStatusEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("broadcastStatusFilterUnspecified")]
                BroadcastStatusFilterUnspecified = 0,

                /// <summary>Return all broadcasts.</summary>
                [Google.Apis.Util.StringValueAttribute("all")]
                All = 1,

                /// <summary>Return current live broadcasts.</summary>
                [Google.Apis.Util.StringValueAttribute("active")]
                Active = 2,

                /// <summary>Return broadcasts that have not yet started.</summary>
                [Google.Apis.Util.StringValueAttribute("upcoming")]
                Upcoming = 3,

                /// <summary>Return broadcasts that have already ended.</summary>
                [Google.Apis.Util.StringValueAttribute("completed")]
                Completed = 4,
            }

            /// <summary>Return only broadcasts with the selected type.</summary>
            [Google.Apis.Util.RequestParameterAttribute("broadcastType", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<BroadcastTypeEnum> BroadcastType { get; set; }

            /// <summary>Return only broadcasts with the selected type.</summary>
            public enum BroadcastTypeEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("broadcastTypeFilterUnspecified")]
                BroadcastTypeFilterUnspecified = 0,

                /// <summary>Return all broadcasts.</summary>
                [Google.Apis.Util.StringValueAttribute("all")]
                All = 1,

                /// <summary>Return only scheduled event broadcasts.</summary>
                [Google.Apis.Util.StringValueAttribute("event")]
                Event__ = 2,

                /// <summary>Return only persistent broadcasts.</summary>
                [Google.Apis.Util.StringValueAttribute("persistent")]
                Persistent = 3,
            }

            /// <summary>Return broadcasts with the given ids from Stubby or Apiary.</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Id { get; set; }

            /// <summary>
            /// The *maxResults* parameter specifies the maximum number of items that should be returned in the result
            /// set.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("mine", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Mine { get; set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The CMS account that
            /// the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>
            /// This parameter can only be used in a properly authorized request. *Note:* This parameter is intended
            /// exclusively for YouTube content partners. The *onBehalfOfContentOwnerChannel* parameter specifies the
            /// YouTube channel ID of the channel to which a video is being added. This parameter is required when a
            /// request specifies a value for the onBehalfOfContentOwner parameter, and it can only be used in
            /// conjunction with that parameter. In addition, the request must be authorized using a CMS account that is
            /// linked to the content owner that the onBehalfOfContentOwner parameter specifies. Finally, the channel
            /// that the onBehalfOfContentOwnerChannel parameter value specifies must be linked to the content owner
            /// that the onBehalfOfContentOwner parameter specifies. This parameter is intended for YouTube content
            /// partners that own and manage many different YouTube channels. It allows content owners to authenticate
            /// once and perform actions on behalf of the channel specified in the parameter value, without having to
            /// provide authentication credentials for each separate channel.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwnerChannel", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwnerChannel { get; set; }

            /// <summary>
            /// The *pageToken* parameter identifies a specific page in the result set that should be returned. In an
            /// API response, the nextPageToken and prevPageToken properties identify other pages that could be
            /// retrieved.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/liveBroadcasts";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("broadcastStatus", new Google.Apis.Discovery.Parameter
                {
                    Name = "broadcastStatus",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("broadcastType", new Google.Apis.Discovery.Parameter
                {
                    Name = "broadcastType",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "event",
                    Pattern = null,
                });
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
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
                    DefaultValue = "5",
                    Pattern = null,
                });
                RequestParameters.Add("mine", new Google.Apis.Discovery.Parameter
                {
                    Name = "mine",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwnerChannel", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwnerChannel",
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

        /// <summary>Transition a broadcast to a given status.</summary>
        /// <param name="broadcastStatus">The status to which the broadcast is going to transition.</param>
        /// <param name="id">Broadcast to transition.</param>
        /// <param name="part">
        /// The *part* parameter specifies a comma-separated list of one or more liveBroadcast resource properties that
        /// the API response will include. The part names that you can include in the parameter value are id, snippet,
        /// contentDetails, and status.
        /// </param>
        public virtual TransitionRequest Transition(TransitionRequest.BroadcastStatusEnum broadcastStatus, string id, Google.Apis.Util.Repeatable<string> part)
        {
            return new TransitionRequest(service, broadcastStatus, id, part);
        }

        /// <summary>Transition a broadcast to a given status.</summary>
        public class TransitionRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.LiveBroadcast>
        {
            /// <summary>Constructs a new Transition request.</summary>
            public TransitionRequest(Google.Apis.Services.IClientService service, BroadcastStatusEnum broadcastStatus, string id, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                BroadcastStatus = broadcastStatus;
                Id = id;
                Part = part;
                InitParameters();
            }

            /// <summary>The status to which the broadcast is going to transition.</summary>
            [Google.Apis.Util.RequestParameterAttribute("broadcastStatus", Google.Apis.Util.RequestParameterType.Query)]
            public virtual BroadcastStatusEnum BroadcastStatus { get; private set; }

            /// <summary>The status to which the broadcast is going to transition.</summary>
            public enum BroadcastStatusEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("statusUnspecified")]
                StatusUnspecified = 0,

                /// <summary>
                /// Start testing the broadcast. YouTube transmits video to the broadcast's monitor stream. Note that
                /// you can only transition a broadcast to the testing state if its
                /// contentDetails.monitorStream.enableMonitorStream property is set to true.",
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("testing")]
                Testing = 1,

                /// <summary>Return only persistent broadcasts.</summary>
                [Google.Apis.Util.StringValueAttribute("live")]
                Live = 2,

                /// <summary>The broadcast is over. YouTube stops transmitting video.</summary>
                [Google.Apis.Util.StringValueAttribute("complete")]
                Complete = 3,
            }

            /// <summary>Broadcast to transition.</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Id { get; private set; }

            /// <summary>
            /// The *part* parameter specifies a comma-separated list of one or more liveBroadcast resource properties
            /// that the API response will include. The part names that you can include in the parameter value are id,
            /// snippet, contentDetails, and status.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The CMS account that
            /// the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>
            /// This parameter can only be used in a properly authorized request. *Note:* This parameter is intended
            /// exclusively for YouTube content partners. The *onBehalfOfContentOwnerChannel* parameter specifies the
            /// YouTube channel ID of the channel to which a video is being added. This parameter is required when a
            /// request specifies a value for the onBehalfOfContentOwner parameter, and it can only be used in
            /// conjunction with that parameter. In addition, the request must be authorized using a CMS account that is
            /// linked to the content owner that the onBehalfOfContentOwner parameter specifies. Finally, the channel
            /// that the onBehalfOfContentOwnerChannel parameter value specifies must be linked to the content owner
            /// that the onBehalfOfContentOwner parameter specifies. This parameter is intended for YouTube content
            /// partners that own and manage many different YouTube channels. It allows content owners to authenticate
            /// once and perform actions on behalf of the channel specified in the parameter value, without having to
            /// provide authentication credentials for each separate channel.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwnerChannel", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwnerChannel { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "transition";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/liveBroadcasts/transition";

            /// <summary>Initializes Transition parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("broadcastStatus", new Google.Apis.Discovery.Parameter
                {
                    Name = "broadcastStatus",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwnerChannel", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwnerChannel",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates an existing broadcast for the authenticated user.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="part">
        /// The *part* parameter serves two purposes in this operation. It identifies the properties that the write
        /// operation will set as well as the properties that the API response will include. The part properties that
        /// you can include in the parameter value are id, snippet, contentDetails, and status. Note that this method
        /// will override the existing values for all of the mutable properties that are contained in any parts that the
        /// parameter value specifies. For example, a broadcast's privacy status is defined in the status part. As such,
        /// if your request is updating a private or unlisted broadcast, and the request's part parameter value includes
        /// the status part, the broadcast's privacy setting will be updated to whatever value the request body
        /// specifies. If the request body does not specify a value, the existing privacy setting will be removed and
        /// the broadcast will revert to the default privacy setting.
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.YouTube.v3.Data.LiveBroadcast body, Google.Apis.Util.Repeatable<string> part)
        {
            return new UpdateRequest(service, body, part);
        }

        /// <summary>Updates an existing broadcast for the authenticated user.</summary>
        public class UpdateRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.LiveBroadcast>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.YouTube.v3.Data.LiveBroadcast body, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter serves two purposes in this operation. It identifies the properties that the write
            /// operation will set as well as the properties that the API response will include. The part properties
            /// that you can include in the parameter value are id, snippet, contentDetails, and status. Note that this
            /// method will override the existing values for all of the mutable properties that are contained in any
            /// parts that the parameter value specifies. For example, a broadcast's privacy status is defined in the
            /// status part. As such, if your request is updating a private or unlisted broadcast, and the request's
            /// part parameter value includes the status part, the broadcast's privacy setting will be updated to
            /// whatever value the request body specifies. If the request body does not specify a value, the existing
            /// privacy setting will be removed and the broadcast will revert to the default privacy setting.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The CMS account that
            /// the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>
            /// This parameter can only be used in a properly authorized request. *Note:* This parameter is intended
            /// exclusively for YouTube content partners. The *onBehalfOfContentOwnerChannel* parameter specifies the
            /// YouTube channel ID of the channel to which a video is being added. This parameter is required when a
            /// request specifies a value for the onBehalfOfContentOwner parameter, and it can only be used in
            /// conjunction with that parameter. In addition, the request must be authorized using a CMS account that is
            /// linked to the content owner that the onBehalfOfContentOwner parameter specifies. Finally, the channel
            /// that the onBehalfOfContentOwnerChannel parameter value specifies must be linked to the content owner
            /// that the onBehalfOfContentOwner parameter specifies. This parameter is intended for YouTube content
            /// partners that own and manage many different YouTube channels. It allows content owners to authenticate
            /// once and perform actions on behalf of the channel specified in the parameter value, without having to
            /// provide authentication credentials for each separate channel.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwnerChannel", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwnerChannel { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.YouTube.v3.Data.LiveBroadcast Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/liveBroadcasts";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwnerChannel", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwnerChannel",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "liveChatBans" collection of methods.</summary>
    public class LiveChatBansResource
    {
        private const string Resource = "liveChatBans";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public LiveChatBansResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Deletes a chat ban.</summary>
        /// <param name="id"><c>null</c></param>
        public virtual DeleteRequest Delete(string id)
        {
            return new DeleteRequest(service, id);
        }

        /// <summary>Deletes a chat ban.</summary>
        public class DeleteRequest : YouTubeBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string id) : base(service)
            {
                Id = id;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Id { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/liveChat/bans";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts a new resource into this collection.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="part">
        /// The *part* parameter serves two purposes in this operation. It identifies the properties that the write
        /// operation will set as well as the properties that the API response returns. Set the parameter value to
        /// snippet.
        /// </param>
        public virtual InsertRequest Insert(Google.Apis.YouTube.v3.Data.LiveChatBan body, Google.Apis.Util.Repeatable<string> part)
        {
            return new InsertRequest(service, body, part);
        }

        /// <summary>Inserts a new resource into this collection.</summary>
        public class InsertRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.LiveChatBan>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.YouTube.v3.Data.LiveChatBan body, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter serves two purposes in this operation. It identifies the properties that the write
            /// operation will set as well as the properties that the API response returns. Set the parameter value to
            /// snippet.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.YouTube.v3.Data.LiveChatBan Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/liveChat/bans";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "liveChatMessages" collection of methods.</summary>
    public class LiveChatMessagesResource
    {
        private const string Resource = "liveChatMessages";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public LiveChatMessagesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Deletes a chat message.</summary>
        /// <param name="id"><c>null</c></param>
        public virtual DeleteRequest Delete(string id)
        {
            return new DeleteRequest(service, id);
        }

        /// <summary>Deletes a chat message.</summary>
        public class DeleteRequest : YouTubeBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string id) : base(service)
            {
                Id = id;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Id { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/liveChat/messages";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts a new resource into this collection.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="part">
        /// The *part* parameter serves two purposes. It identifies the properties that the write operation will set as
        /// well as the properties that the API response will include. Set the parameter value to snippet.
        /// </param>
        public virtual InsertRequest Insert(Google.Apis.YouTube.v3.Data.LiveChatMessage body, Google.Apis.Util.Repeatable<string> part)
        {
            return new InsertRequest(service, body, part);
        }

        /// <summary>Inserts a new resource into this collection.</summary>
        public class InsertRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.LiveChatMessage>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.YouTube.v3.Data.LiveChatMessage body, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter serves two purposes. It identifies the properties that the write operation will set
            /// as well as the properties that the API response will include. Set the parameter value to snippet.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.YouTube.v3.Data.LiveChatMessage Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/liveChat/messages";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves a list of resources, possibly filtered.</summary>
        /// <param name="liveChatId">The id of the live chat for which comments should be returned.</param>
        /// <param name="part">
        /// The *part* parameter specifies the liveChatComment resource parts that the API response will include.
        /// Supported values are id and snippet.
        /// </param>
        public virtual ListRequest List(string liveChatId, Google.Apis.Util.Repeatable<string> part)
        {
            return new ListRequest(service, liveChatId, part);
        }

        /// <summary>Retrieves a list of resources, possibly filtered.</summary>
        public class ListRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.LiveChatMessageListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string liveChatId, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                LiveChatId = liveChatId;
                Part = part;
                InitParameters();
            }

            /// <summary>The id of the live chat for which comments should be returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("liveChatId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string LiveChatId { get; private set; }

            /// <summary>
            /// The *part* parameter specifies the liveChatComment resource parts that the API response will include.
            /// Supported values are id and snippet.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>Specifies the localization language in which the system messages should be returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("hl", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Hl { get; set; }

            /// <summary>
            /// The *maxResults* parameter specifies the maximum number of items that should be returned in the result
            /// set.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>
            /// The *pageToken* parameter identifies a specific page in the result set that should be returned. In an
            /// API response, the nextPageToken property identify other pages that could be retrieved.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Specifies the size of the profile image that should be returned for each user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("profileImageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> ProfileImageSize { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/liveChat/messages";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("liveChatId", new Google.Apis.Discovery.Parameter
                {
                    Name = "liveChatId",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("hl", new Google.Apis.Discovery.Parameter
                {
                    Name = "hl",
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
                    DefaultValue = "500",
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
                RequestParameters.Add("profileImageSize", new Google.Apis.Discovery.Parameter
                {
                    Name = "profileImageSize",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "liveChatModerators" collection of methods.</summary>
    public class LiveChatModeratorsResource
    {
        private const string Resource = "liveChatModerators";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public LiveChatModeratorsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Deletes a chat moderator.</summary>
        /// <param name="id"><c>null</c></param>
        public virtual DeleteRequest Delete(string id)
        {
            return new DeleteRequest(service, id);
        }

        /// <summary>Deletes a chat moderator.</summary>
        public class DeleteRequest : YouTubeBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string id) : base(service)
            {
                Id = id;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Id { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/liveChat/moderators";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts a new resource into this collection.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="part">
        /// The *part* parameter serves two purposes in this operation. It identifies the properties that the write
        /// operation will set as well as the properties that the API response returns. Set the parameter value to
        /// snippet.
        /// </param>
        public virtual InsertRequest Insert(Google.Apis.YouTube.v3.Data.LiveChatModerator body, Google.Apis.Util.Repeatable<string> part)
        {
            return new InsertRequest(service, body, part);
        }

        /// <summary>Inserts a new resource into this collection.</summary>
        public class InsertRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.LiveChatModerator>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.YouTube.v3.Data.LiveChatModerator body, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter serves two purposes in this operation. It identifies the properties that the write
            /// operation will set as well as the properties that the API response returns. Set the parameter value to
            /// snippet.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.YouTube.v3.Data.LiveChatModerator Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/liveChat/moderators";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves a list of resources, possibly filtered.</summary>
        /// <param name="liveChatId">The id of the live chat for which moderators should be returned.</param>
        /// <param name="part">
        /// The *part* parameter specifies the liveChatModerator resource parts that the API response will include.
        /// Supported values are id and snippet.
        /// </param>
        public virtual ListRequest List(string liveChatId, Google.Apis.Util.Repeatable<string> part)
        {
            return new ListRequest(service, liveChatId, part);
        }

        /// <summary>Retrieves a list of resources, possibly filtered.</summary>
        public class ListRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.LiveChatModeratorListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string liveChatId, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                LiveChatId = liveChatId;
                Part = part;
                InitParameters();
            }

            /// <summary>The id of the live chat for which moderators should be returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("liveChatId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string LiveChatId { get; private set; }

            /// <summary>
            /// The *part* parameter specifies the liveChatModerator resource parts that the API response will include.
            /// Supported values are id and snippet.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>
            /// The *maxResults* parameter specifies the maximum number of items that should be returned in the result
            /// set.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>
            /// The *pageToken* parameter identifies a specific page in the result set that should be returned. In an
            /// API response, the nextPageToken and prevPageToken properties identify other pages that could be
            /// retrieved.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/liveChat/moderators";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("liveChatId", new Google.Apis.Discovery.Parameter
                {
                    Name = "liveChatId",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "5",
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

    /// <summary>The "liveStreams" collection of methods.</summary>
    public class LiveStreamsResource
    {
        private const string Resource = "liveStreams";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public LiveStreamsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Deletes an existing stream for the authenticated user.</summary>
        /// <param name="id"><c>null</c></param>
        public virtual DeleteRequest Delete(string id)
        {
            return new DeleteRequest(service, id);
        }

        /// <summary>Deletes an existing stream for the authenticated user.</summary>
        public class DeleteRequest : YouTubeBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string id) : base(service)
            {
                Id = id;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Id { get; private set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The CMS account that
            /// the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>
            /// This parameter can only be used in a properly authorized request. *Note:* This parameter is intended
            /// exclusively for YouTube content partners. The *onBehalfOfContentOwnerChannel* parameter specifies the
            /// YouTube channel ID of the channel to which a video is being added. This parameter is required when a
            /// request specifies a value for the onBehalfOfContentOwner parameter, and it can only be used in
            /// conjunction with that parameter. In addition, the request must be authorized using a CMS account that is
            /// linked to the content owner that the onBehalfOfContentOwner parameter specifies. Finally, the channel
            /// that the onBehalfOfContentOwnerChannel parameter value specifies must be linked to the content owner
            /// that the onBehalfOfContentOwner parameter specifies. This parameter is intended for YouTube content
            /// partners that own and manage many different YouTube channels. It allows content owners to authenticate
            /// once and perform actions on behalf of the channel specified in the parameter value, without having to
            /// provide authentication credentials for each separate channel.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwnerChannel", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwnerChannel { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/liveStreams";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwnerChannel", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwnerChannel",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts a new stream for the authenticated user.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="part">
        /// The *part* parameter serves two purposes in this operation. It identifies the properties that the write
        /// operation will set as well as the properties that the API response will include. The part properties that
        /// you can include in the parameter value are id, snippet, cdn, content_details, and status.
        /// </param>
        public virtual InsertRequest Insert(Google.Apis.YouTube.v3.Data.LiveStream body, Google.Apis.Util.Repeatable<string> part)
        {
            return new InsertRequest(service, body, part);
        }

        /// <summary>Inserts a new stream for the authenticated user.</summary>
        public class InsertRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.LiveStream>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.YouTube.v3.Data.LiveStream body, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter serves two purposes in this operation. It identifies the properties that the write
            /// operation will set as well as the properties that the API response will include. The part properties
            /// that you can include in the parameter value are id, snippet, cdn, content_details, and status.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The CMS account that
            /// the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>
            /// This parameter can only be used in a properly authorized request. *Note:* This parameter is intended
            /// exclusively for YouTube content partners. The *onBehalfOfContentOwnerChannel* parameter specifies the
            /// YouTube channel ID of the channel to which a video is being added. This parameter is required when a
            /// request specifies a value for the onBehalfOfContentOwner parameter, and it can only be used in
            /// conjunction with that parameter. In addition, the request must be authorized using a CMS account that is
            /// linked to the content owner that the onBehalfOfContentOwner parameter specifies. Finally, the channel
            /// that the onBehalfOfContentOwnerChannel parameter value specifies must be linked to the content owner
            /// that the onBehalfOfContentOwner parameter specifies. This parameter is intended for YouTube content
            /// partners that own and manage many different YouTube channels. It allows content owners to authenticate
            /// once and perform actions on behalf of the channel specified in the parameter value, without having to
            /// provide authentication credentials for each separate channel.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwnerChannel", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwnerChannel { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.YouTube.v3.Data.LiveStream Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/liveStreams";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwnerChannel", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwnerChannel",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieve the list of streams associated with the given channel. --</summary>
        /// <param name="part">
        /// The *part* parameter specifies a comma-separated list of one or more liveStream resource properties that the
        /// API response will include. The part names that you can include in the parameter value are id, snippet, cdn,
        /// and status.
        /// </param>
        public virtual ListRequest List(Google.Apis.Util.Repeatable<string> part)
        {
            return new ListRequest(service, part);
        }

        /// <summary>Retrieve the list of streams associated with the given channel. --</summary>
        public class ListRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.LiveStreamListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter specifies a comma-separated list of one or more liveStream resource properties that
            /// the API response will include. The part names that you can include in the parameter value are id,
            /// snippet, cdn, and status.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>Return LiveStreams with the given ids from Stubby or Apiary.</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Id { get; set; }

            /// <summary>
            /// The *maxResults* parameter specifies the maximum number of items that should be returned in the result
            /// set.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("mine", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Mine { get; set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The CMS account that
            /// the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>
            /// This parameter can only be used in a properly authorized request. *Note:* This parameter is intended
            /// exclusively for YouTube content partners. The *onBehalfOfContentOwnerChannel* parameter specifies the
            /// YouTube channel ID of the channel to which a video is being added. This parameter is required when a
            /// request specifies a value for the onBehalfOfContentOwner parameter, and it can only be used in
            /// conjunction with that parameter. In addition, the request must be authorized using a CMS account that is
            /// linked to the content owner that the onBehalfOfContentOwner parameter specifies. Finally, the channel
            /// that the onBehalfOfContentOwnerChannel parameter value specifies must be linked to the content owner
            /// that the onBehalfOfContentOwner parameter specifies. This parameter is intended for YouTube content
            /// partners that own and manage many different YouTube channels. It allows content owners to authenticate
            /// once and perform actions on behalf of the channel specified in the parameter value, without having to
            /// provide authentication credentials for each separate channel.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwnerChannel", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwnerChannel { get; set; }

            /// <summary>
            /// The *pageToken* parameter identifies a specific page in the result set that should be returned. In an
            /// API response, the nextPageToken and prevPageToken properties identify other pages that could be
            /// retrieved.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/liveStreams";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
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
                    DefaultValue = "5",
                    Pattern = null,
                });
                RequestParameters.Add("mine", new Google.Apis.Discovery.Parameter
                {
                    Name = "mine",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwnerChannel", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwnerChannel",
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

        /// <summary>Updates an existing stream for the authenticated user.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="part">
        /// The *part* parameter serves two purposes in this operation. It identifies the properties that the write
        /// operation will set as well as the properties that the API response will include. The part properties that
        /// you can include in the parameter value are id, snippet, cdn, and status. Note that this method will override
        /// the existing values for all of the mutable properties that are contained in any parts that the parameter
        /// value specifies. If the request body does not specify a value for a mutable property, the existing value for
        /// that property will be removed.
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.YouTube.v3.Data.LiveStream body, Google.Apis.Util.Repeatable<string> part)
        {
            return new UpdateRequest(service, body, part);
        }

        /// <summary>Updates an existing stream for the authenticated user.</summary>
        public class UpdateRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.LiveStream>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.YouTube.v3.Data.LiveStream body, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter serves two purposes in this operation. It identifies the properties that the write
            /// operation will set as well as the properties that the API response will include. The part properties
            /// that you can include in the parameter value are id, snippet, cdn, and status. Note that this method will
            /// override the existing values for all of the mutable properties that are contained in any parts that the
            /// parameter value specifies. If the request body does not specify a value for a mutable property, the
            /// existing value for that property will be removed.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The CMS account that
            /// the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>
            /// This parameter can only be used in a properly authorized request. *Note:* This parameter is intended
            /// exclusively for YouTube content partners. The *onBehalfOfContentOwnerChannel* parameter specifies the
            /// YouTube channel ID of the channel to which a video is being added. This parameter is required when a
            /// request specifies a value for the onBehalfOfContentOwner parameter, and it can only be used in
            /// conjunction with that parameter. In addition, the request must be authorized using a CMS account that is
            /// linked to the content owner that the onBehalfOfContentOwner parameter specifies. Finally, the channel
            /// that the onBehalfOfContentOwnerChannel parameter value specifies must be linked to the content owner
            /// that the onBehalfOfContentOwner parameter specifies. This parameter is intended for YouTube content
            /// partners that own and manage many different YouTube channels. It allows content owners to authenticate
            /// once and perform actions on behalf of the channel specified in the parameter value, without having to
            /// provide authentication credentials for each separate channel.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwnerChannel", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwnerChannel { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.YouTube.v3.Data.LiveStream Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/liveStreams";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwnerChannel", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwnerChannel",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

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

        /// <summary>Retrieves a list of members that match the request criteria for a channel.</summary>
        /// <param name="part">
        /// The *part* parameter specifies the member resource parts that the API response will include. Set the
        /// parameter value to snippet.
        /// </param>
        public virtual ListRequest List(Google.Apis.Util.Repeatable<string> part)
        {
            return new ListRequest(service, part);
        }

        /// <summary>Retrieves a list of members that match the request criteria for a channel.</summary>
        public class ListRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.MemberListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter specifies the member resource parts that the API response will include. Set the
            /// parameter value to snippet.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>
            /// Comma separated list of channel IDs. Only data about members that are part of this list will be included
            /// in the response.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filterByMemberChannelId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string FilterByMemberChannelId { get; set; }

            /// <summary>Filter members in the results set to the ones that have access to a level.</summary>
            [Google.Apis.Util.RequestParameterAttribute("hasAccessToLevel", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string HasAccessToLevel { get; set; }

            /// <summary>
            /// The *maxResults* parameter specifies the maximum number of items that should be returned in the result
            /// set.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>Parameter that specifies which channel members to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("mode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ModeEnum> Mode { get; set; }

            /// <summary>Parameter that specifies which channel members to return.</summary>
            public enum ModeEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("listMembersModeUnknown")]
                ListMembersModeUnknown = 0,

                /// <summary>Return only members that joined after the first call with this mode was made.</summary>
                [Google.Apis.Util.StringValueAttribute("updates")]
                Updates = 1,

                /// <summary>Return all current members, from newest to oldest.</summary>
                [Google.Apis.Util.StringValueAttribute("all_current")]
                AllCurrent = 2,
            }

            /// <summary>
            /// The *pageToken* parameter identifies a specific page in the result set that should be returned. In an
            /// API response, the nextPageToken and prevPageToken properties identify other pages that could be
            /// retrieved.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/members";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("filterByMemberChannelId", new Google.Apis.Discovery.Parameter
                {
                    Name = "filterByMemberChannelId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("hasAccessToLevel", new Google.Apis.Discovery.Parameter
                {
                    Name = "hasAccessToLevel",
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
                    DefaultValue = "5",
                    Pattern = null,
                });
                RequestParameters.Add("mode", new Google.Apis.Discovery.Parameter
                {
                    Name = "mode",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "all_current",
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

    /// <summary>The "membershipsLevels" collection of methods.</summary>
    public class MembershipsLevelsResource
    {
        private const string Resource = "membershipsLevels";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public MembershipsLevelsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Retrieves a list of all pricing levels offered by a creator to the fans.</summary>
        /// <param name="part">
        /// The *part* parameter specifies the membershipsLevel resource parts that the API response will include.
        /// Supported values are id and snippet.
        /// </param>
        public virtual ListRequest List(Google.Apis.Util.Repeatable<string> part)
        {
            return new ListRequest(service, part);
        }

        /// <summary>Retrieves a list of all pricing levels offered by a creator to the fans.</summary>
        public class ListRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.MembershipsLevelListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter specifies the membershipsLevel resource parts that the API response will include.
            /// Supported values are id and snippet.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/membershipsLevels";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "playlistItems" collection of methods.</summary>
    public class PlaylistItemsResource
    {
        private const string Resource = "playlistItems";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PlaylistItemsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Deletes a resource.</summary>
        /// <param name="id"><c>null</c></param>
        public virtual DeleteRequest Delete(string id)
        {
            return new DeleteRequest(service, id);
        }

        /// <summary>Deletes a resource.</summary>
        public class DeleteRequest : YouTubeBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string id) : base(service)
            {
                Id = id;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Id { get; private set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The CMS account that
            /// the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/playlistItems";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts a new resource into this collection.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="part">
        /// The *part* parameter serves two purposes in this operation. It identifies the properties that the write
        /// operation will set as well as the properties that the API response will include.
        /// </param>
        public virtual InsertRequest Insert(Google.Apis.YouTube.v3.Data.PlaylistItem body, Google.Apis.Util.Repeatable<string> part)
        {
            return new InsertRequest(service, body, part);
        }

        /// <summary>Inserts a new resource into this collection.</summary>
        public class InsertRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.PlaylistItem>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.YouTube.v3.Data.PlaylistItem body, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter serves two purposes in this operation. It identifies the properties that the write
            /// operation will set as well as the properties that the API response will include.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The CMS account that
            /// the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.YouTube.v3.Data.PlaylistItem Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/playlistItems";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves a list of resources, possibly filtered.</summary>
        /// <param name="part">
        /// The *part* parameter specifies a comma-separated list of one or more playlistItem resource properties that
        /// the API response will include. If the parameter identifies a property that contains child properties, the
        /// child properties will be included in the response. For example, in a playlistItem resource, the snippet
        /// property contains numerous fields, including the title, description, position, and resourceId properties. As
        /// such, if you set *part=snippet*, the API response will contain all of those properties.
        /// </param>
        public virtual ListRequest List(Google.Apis.Util.Repeatable<string> part)
        {
            return new ListRequest(service, part);
        }

        /// <summary>Retrieves a list of resources, possibly filtered.</summary>
        public class ListRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.PlaylistItemListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter specifies a comma-separated list of one or more playlistItem resource properties
            /// that the API response will include. If the parameter identifies a property that contains child
            /// properties, the child properties will be included in the response. For example, in a playlistItem
            /// resource, the snippet property contains numerous fields, including the title, description, position, and
            /// resourceId properties. As such, if you set *part=snippet*, the API response will contain all of those
            /// properties.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Id { get; set; }

            /// <summary>
            /// The *maxResults* parameter specifies the maximum number of items that should be returned in the result
            /// set.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The CMS account that
            /// the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>
            /// The *pageToken* parameter identifies a specific page in the result set that should be returned. In an
            /// API response, the nextPageToken and prevPageToken properties identify other pages that could be
            /// retrieved.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Return the playlist items within the given playlist.</summary>
            [Google.Apis.Util.RequestParameterAttribute("playlistId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PlaylistId { get; set; }

            /// <summary>Return the playlist items associated with the given video ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("videoId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string VideoId { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/playlistItems";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
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
                    DefaultValue = "5",
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
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
                RequestParameters.Add("playlistId", new Google.Apis.Discovery.Parameter
                {
                    Name = "playlistId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("videoId", new Google.Apis.Discovery.Parameter
                {
                    Name = "videoId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates an existing resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="part">
        /// The *part* parameter serves two purposes in this operation. It identifies the properties that the write
        /// operation will set as well as the properties that the API response will include. Note that this method will
        /// override the existing values for all of the mutable properties that are contained in any parts that the
        /// parameter value specifies. For example, a playlist item can specify a start time and end time, which
        /// identify the times portion of the video that should play when users watch the video in the playlist. If your
        /// request is updating a playlist item that sets these values, and the request's part parameter value includes
        /// the contentDetails part, the playlist item's start and end times will be updated to whatever value the
        /// request body specifies. If the request body does not specify values, the existing start and end times will
        /// be removed and replaced with the default settings.
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.YouTube.v3.Data.PlaylistItem body, Google.Apis.Util.Repeatable<string> part)
        {
            return new UpdateRequest(service, body, part);
        }

        /// <summary>Updates an existing resource.</summary>
        public class UpdateRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.PlaylistItem>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.YouTube.v3.Data.PlaylistItem body, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter serves two purposes in this operation. It identifies the properties that the write
            /// operation will set as well as the properties that the API response will include. Note that this method
            /// will override the existing values for all of the mutable properties that are contained in any parts that
            /// the parameter value specifies. For example, a playlist item can specify a start time and end time, which
            /// identify the times portion of the video that should play when users watch the video in the playlist. If
            /// your request is updating a playlist item that sets these values, and the request's part parameter value
            /// includes the contentDetails part, the playlist item's start and end times will be updated to whatever
            /// value the request body specifies. If the request body does not specify values, the existing start and
            /// end times will be removed and replaced with the default settings.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The CMS account that
            /// the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.YouTube.v3.Data.PlaylistItem Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/playlistItems";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "playlists" collection of methods.</summary>
    public class PlaylistsResource
    {
        private const string Resource = "playlists";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PlaylistsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Deletes a resource.</summary>
        /// <param name="id"><c>null</c></param>
        public virtual DeleteRequest Delete(string id)
        {
            return new DeleteRequest(service, id);
        }

        /// <summary>Deletes a resource.</summary>
        public class DeleteRequest : YouTubeBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string id) : base(service)
            {
                Id = id;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Id { get; private set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The CMS account that
            /// the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/playlists";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts a new resource into this collection.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="part">
        /// The *part* parameter serves two purposes in this operation. It identifies the properties that the write
        /// operation will set as well as the properties that the API response will include.
        /// </param>
        public virtual InsertRequest Insert(Google.Apis.YouTube.v3.Data.Playlist body, Google.Apis.Util.Repeatable<string> part)
        {
            return new InsertRequest(service, body, part);
        }

        /// <summary>Inserts a new resource into this collection.</summary>
        public class InsertRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.Playlist>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.YouTube.v3.Data.Playlist body, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter serves two purposes in this operation. It identifies the properties that the write
            /// operation will set as well as the properties that the API response will include.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The CMS account that
            /// the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>
            /// This parameter can only be used in a properly authorized request. *Note:* This parameter is intended
            /// exclusively for YouTube content partners. The *onBehalfOfContentOwnerChannel* parameter specifies the
            /// YouTube channel ID of the channel to which a video is being added. This parameter is required when a
            /// request specifies a value for the onBehalfOfContentOwner parameter, and it can only be used in
            /// conjunction with that parameter. In addition, the request must be authorized using a CMS account that is
            /// linked to the content owner that the onBehalfOfContentOwner parameter specifies. Finally, the channel
            /// that the onBehalfOfContentOwnerChannel parameter value specifies must be linked to the content owner
            /// that the onBehalfOfContentOwner parameter specifies. This parameter is intended for YouTube content
            /// partners that own and manage many different YouTube channels. It allows content owners to authenticate
            /// once and perform actions on behalf of the channel specified in the parameter value, without having to
            /// provide authentication credentials for each separate channel.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwnerChannel", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwnerChannel { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.YouTube.v3.Data.Playlist Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/playlists";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwnerChannel", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwnerChannel",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves a list of resources, possibly filtered.</summary>
        /// <param name="part">
        /// The *part* parameter specifies a comma-separated list of one or more playlist resource properties that the
        /// API response will include. If the parameter identifies a property that contains child properties, the child
        /// properties will be included in the response. For example, in a playlist resource, the snippet property
        /// contains properties like author, title, description, tags, and timeCreated. As such, if you set
        /// *part=snippet*, the API response will contain all of those properties.
        /// </param>
        public virtual ListRequest List(Google.Apis.Util.Repeatable<string> part)
        {
            return new ListRequest(service, part);
        }

        /// <summary>Retrieves a list of resources, possibly filtered.</summary>
        public class ListRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.PlaylistListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter specifies a comma-separated list of one or more playlist resource properties that
            /// the API response will include. If the parameter identifies a property that contains child properties,
            /// the child properties will be included in the response. For example, in a playlist resource, the snippet
            /// property contains properties like author, title, description, tags, and timeCreated. As such, if you set
            /// *part=snippet*, the API response will contain all of those properties.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>Return the playlists owned by the specified channel ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("channelId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ChannelId { get; set; }

            /// <summary>Returen content in specified language</summary>
            [Google.Apis.Util.RequestParameterAttribute("hl", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Hl { get; set; }

            /// <summary>Return the playlists with the given IDs for Stubby or Apiary.</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Id { get; set; }

            /// <summary>
            /// The *maxResults* parameter specifies the maximum number of items that should be returned in the result
            /// set.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>Return the playlists owned by the authenticated user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("mine", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Mine { get; set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The CMS account that
            /// the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>
            /// This parameter can only be used in a properly authorized request. *Note:* This parameter is intended
            /// exclusively for YouTube content partners. The *onBehalfOfContentOwnerChannel* parameter specifies the
            /// YouTube channel ID of the channel to which a video is being added. This parameter is required when a
            /// request specifies a value for the onBehalfOfContentOwner parameter, and it can only be used in
            /// conjunction with that parameter. In addition, the request must be authorized using a CMS account that is
            /// linked to the content owner that the onBehalfOfContentOwner parameter specifies. Finally, the channel
            /// that the onBehalfOfContentOwnerChannel parameter value specifies must be linked to the content owner
            /// that the onBehalfOfContentOwner parameter specifies. This parameter is intended for YouTube content
            /// partners that own and manage many different YouTube channels. It allows content owners to authenticate
            /// once and perform actions on behalf of the channel specified in the parameter value, without having to
            /// provide authentication credentials for each separate channel.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwnerChannel", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwnerChannel { get; set; }

            /// <summary>
            /// The *pageToken* parameter identifies a specific page in the result set that should be returned. In an
            /// API response, the nextPageToken and prevPageToken properties identify other pages that could be
            /// retrieved.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/playlists";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("channelId", new Google.Apis.Discovery.Parameter
                {
                    Name = "channelId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("hl", new Google.Apis.Discovery.Parameter
                {
                    Name = "hl",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
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
                    DefaultValue = "5",
                    Pattern = null,
                });
                RequestParameters.Add("mine", new Google.Apis.Discovery.Parameter
                {
                    Name = "mine",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwnerChannel", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwnerChannel",
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

        /// <summary>Updates an existing resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="part">
        /// The *part* parameter serves two purposes in this operation. It identifies the properties that the write
        /// operation will set as well as the properties that the API response will include. Note that this method will
        /// override the existing values for mutable properties that are contained in any parts that the request body
        /// specifies. For example, a playlist's description is contained in the snippet part, which must be included in
        /// the request body. If the request does not specify a value for the snippet.description property, the
        /// playlist's existing description will be deleted.
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.YouTube.v3.Data.Playlist body, Google.Apis.Util.Repeatable<string> part)
        {
            return new UpdateRequest(service, body, part);
        }

        /// <summary>Updates an existing resource.</summary>
        public class UpdateRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.Playlist>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.YouTube.v3.Data.Playlist body, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter serves two purposes in this operation. It identifies the properties that the write
            /// operation will set as well as the properties that the API response will include. Note that this method
            /// will override the existing values for mutable properties that are contained in any parts that the
            /// request body specifies. For example, a playlist's description is contained in the snippet part, which
            /// must be included in the request body. If the request does not specify a value for the
            /// snippet.description property, the playlist's existing description will be deleted.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The CMS account that
            /// the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.YouTube.v3.Data.Playlist Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/playlists";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "search" collection of methods.</summary>
    public class SearchResource
    {
        private const string Resource = "search";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public SearchResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Retrieves a list of search resources</summary>
        /// <param name="part">
        /// The *part* parameter specifies a comma-separated list of one or more search resource properties that the API
        /// response will include. Set the parameter value to snippet.
        /// </param>
        public virtual ListRequest List(Google.Apis.Util.Repeatable<string> part)
        {
            return new ListRequest(service, part);
        }

        /// <summary>Retrieves a list of search resources</summary>
        public class ListRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.SearchListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter specifies a comma-separated list of one or more search resource properties that the
            /// API response will include. Set the parameter value to snippet.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>Filter on resources belonging to this channelId.</summary>
            [Google.Apis.Util.RequestParameterAttribute("channelId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ChannelId { get; set; }

            /// <summary>Add a filter on the channel search.</summary>
            [Google.Apis.Util.RequestParameterAttribute("channelType", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ChannelTypeEnum> ChannelType { get; set; }

            /// <summary>Add a filter on the channel search.</summary>
            public enum ChannelTypeEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("channelTypeUnspecified")]
                ChannelTypeUnspecified = 0,

                /// <summary>Return all channels.</summary>
                [Google.Apis.Util.StringValueAttribute("any")]
                Any = 1,

                /// <summary>Only retrieve shows.</summary>
                [Google.Apis.Util.StringValueAttribute("show")]
                Show = 2,
            }

            /// <summary>Filter on the livestream status of the videos.</summary>
            [Google.Apis.Util.RequestParameterAttribute("eventType", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<EventTypeEnum> EventType { get; set; }

            /// <summary>Filter on the livestream status of the videos.</summary>
            public enum EventTypeEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("none")]
                None = 0,

                /// <summary>The live broadcast is upcoming.</summary>
                [Google.Apis.Util.StringValueAttribute("upcoming")]
                Upcoming = 1,

                /// <summary>The live broadcast is active.</summary>
                [Google.Apis.Util.StringValueAttribute("live")]
                Live = 2,

                /// <summary>The live broadcast has been completed.</summary>
                [Google.Apis.Util.StringValueAttribute("completed")]
                Completed = 3,
            }

            /// <summary>Search owned by a content owner.</summary>
            [Google.Apis.Util.RequestParameterAttribute("forContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ForContentOwner { get; set; }

            /// <summary>
            /// Restrict the search to only retrieve videos uploaded using the project id of the authenticated user.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("forDeveloper", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ForDeveloper { get; set; }

            /// <summary>Search for the private videos of the authenticated user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("forMine", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ForMine { get; set; }

            /// <summary>Filter on location of the video</summary>
            [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Location { get; set; }

            /// <summary>Filter on distance from the location (specified above).</summary>
            [Google.Apis.Util.RequestParameterAttribute("locationRadius", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string LocationRadius { get; set; }

            /// <summary>
            /// The *maxResults* parameter specifies the maximum number of items that should be returned in the result
            /// set.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The CMS account that
            /// the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>Sort order of the results.</summary>
            [Google.Apis.Util.RequestParameterAttribute("order", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<OrderEnum> Order { get; set; }

            /// <summary>Sort order of the results.</summary>
            public enum OrderEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("searchSortUnspecified")]
                SearchSortUnspecified = 0,

                /// <summary>
                /// Resources are sorted in reverse chronological order based on the date they were created.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("date")]
                Date = 1,

                /// <summary>Resources are sorted from highest to lowest rating.</summary>
                [Google.Apis.Util.StringValueAttribute("rating")]
                Rating = 2,

                /// <summary>Resources are sorted from highest to lowest number of views.</summary>
                [Google.Apis.Util.StringValueAttribute("viewCount")]
                ViewCount = 3,

                /// <summary>
                /// Resources are sorted based on their relevance to the search query. This is the default value for
                /// this parameter.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("relevance")]
                Relevance = 4,

                /// <summary>Resources are sorted alphabetically by title.</summary>
                [Google.Apis.Util.StringValueAttribute("title")]
                Title = 5,

                /// <summary>Channels are sorted in descending order of their number of uploaded videos.</summary>
                [Google.Apis.Util.StringValueAttribute("videoCount")]
                VideoCount = 6,
            }

            /// <summary>
            /// The *pageToken* parameter identifies a specific page in the result set that should be returned. In an
            /// API response, the nextPageToken and prevPageToken properties identify other pages that could be
            /// retrieved.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Filter on resources published after this date.</summary>
            [Google.Apis.Util.RequestParameterAttribute("publishedAfter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object PublishedAfter { get; set; }

            /// <summary>Filter on resources published before this date.</summary>
            [Google.Apis.Util.RequestParameterAttribute("publishedBefore", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object PublishedBefore { get; set; }

            /// <summary>Textual search terms to match.</summary>
            [Google.Apis.Util.RequestParameterAttribute("q", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Q { get; set; }

            /// <summary>Display the content as seen by viewers in this country.</summary>
            [Google.Apis.Util.RequestParameterAttribute("regionCode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string RegionCode { get; set; }

            /// <summary>Search related to a resource.</summary>
            [Google.Apis.Util.RequestParameterAttribute("relatedToVideoId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string RelatedToVideoId { get; set; }

            /// <summary>Return results relevant to this language.</summary>
            [Google.Apis.Util.RequestParameterAttribute("relevanceLanguage", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string RelevanceLanguage { get; set; }

            /// <summary>
            /// Indicates whether the search results should include restricted content as well as standard content.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("safeSearch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<SafeSearchEnum> SafeSearch { get; set; }

            /// <summary>
            /// Indicates whether the search results should include restricted content as well as standard content.
            /// </summary>
            public enum SafeSearchEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("safeSearchSettingUnspecified")]
                SafeSearchSettingUnspecified = 0,

                /// <summary>YouTube will not filter the search result set.</summary>
                [Google.Apis.Util.StringValueAttribute("none")]
                None = 1,

                /// <summary>
                /// YouTube will filter some content from search results and, at the least, will filter content that is
                /// restricted in your locale. Based on their content, search results could be removed from search
                /// results or demoted in search results. This is the default parameter value.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("moderate")]
                Moderate = 2,

                /// <summary>
                /// YouTube will try to exclude all restricted content from the search result set. Based on their
                /// content, search results could be removed from search results or demoted in search results.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("strict")]
                Strict = 3,
            }

            /// <summary>Restrict results to a particular topic.</summary>
            [Google.Apis.Util.RequestParameterAttribute("topicId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string TopicId { get; set; }

            /// <summary>Restrict results to a particular set of resource types from One Platform.</summary>
            [Google.Apis.Util.RequestParameterAttribute("type", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Type { get; set; }

            /// <summary>Filter on the presence of captions on the videos.</summary>
            [Google.Apis.Util.RequestParameterAttribute("videoCaption", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<VideoCaptionEnum> VideoCaption { get; set; }

            /// <summary>Filter on the presence of captions on the videos.</summary>
            public enum VideoCaptionEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("videoCaptionUnspecified")]
                VideoCaptionUnspecified = 0,

                /// <summary>Do not filter results based on caption availability.</summary>
                [Google.Apis.Util.StringValueAttribute("any")]
                Any = 1,

                /// <summary>Only include videos that have captions.</summary>
                [Google.Apis.Util.StringValueAttribute("closedCaption")]
                ClosedCaption = 2,

                /// <summary>Only include videos that do not have captions.</summary>
                [Google.Apis.Util.StringValueAttribute("none")]
                None = 3,
            }

            /// <summary>Filter on videos in a specific category.</summary>
            [Google.Apis.Util.RequestParameterAttribute("videoCategoryId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string VideoCategoryId { get; set; }

            /// <summary>Filter on the definition of the videos.</summary>
            [Google.Apis.Util.RequestParameterAttribute("videoDefinition", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<VideoDefinitionEnum> VideoDefinition { get; set; }

            /// <summary>Filter on the definition of the videos.</summary>
            public enum VideoDefinitionEnum
            {
                /// <summary>Return all videos, regardless of their resolution.</summary>
                [Google.Apis.Util.StringValueAttribute("any")]
                Any = 0,

                /// <summary>Only retrieve videos in standard definition.</summary>
                [Google.Apis.Util.StringValueAttribute("standard")]
                Standard = 1,

                /// <summary>Only retrieve HD videos.</summary>
                [Google.Apis.Util.StringValueAttribute("high")]
                High = 2,
            }

            /// <summary>Filter on 3d videos.</summary>
            [Google.Apis.Util.RequestParameterAttribute("videoDimension", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<VideoDimensionEnum> VideoDimension { get; set; }

            /// <summary>Filter on 3d videos.</summary>
            public enum VideoDimensionEnum
            {
                /// <summary>Include both 3D and non-3D videos in returned results. This is the default value.</summary>
                [Google.Apis.Util.StringValueAttribute("any")]
                Any = 0,

                /// <summary>Restrict search results to exclude 3D videos.</summary>
                [Google.Apis.Util.StringValueAttribute("2d")]
                Value2d = 1,

                /// <summary>Restrict search results to only include 3D videos.</summary>
                [Google.Apis.Util.StringValueAttribute("3d")]
                Value3d = 2,
            }

            /// <summary>Filter on the duration of the videos.</summary>
            [Google.Apis.Util.RequestParameterAttribute("videoDuration", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<VideoDurationEnum> VideoDuration { get; set; }

            /// <summary>Filter on the duration of the videos.</summary>
            public enum VideoDurationEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("videoDurationUnspecified")]
                VideoDurationUnspecified = 0,

                /// <summary>
                /// Do not filter video search results based on their duration. This is the default value.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("any")]
                Any = 1,

                /// <summary>Only include videos that are less than four minutes long.</summary>
                [Google.Apis.Util.StringValueAttribute("short")]
                Short__ = 2,

                /// <summary>Only include videos that are between four and 20 minutes long (inclusive).</summary>
                [Google.Apis.Util.StringValueAttribute("medium")]
                Medium = 3,

                /// <summary>Only include videos longer than 20 minutes.</summary>
                [Google.Apis.Util.StringValueAttribute("long")]
                Long__ = 4,
            }

            /// <summary>Filter on embeddable videos.</summary>
            [Google.Apis.Util.RequestParameterAttribute("videoEmbeddable", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<VideoEmbeddableEnum> VideoEmbeddable { get; set; }

            /// <summary>Filter on embeddable videos.</summary>
            public enum VideoEmbeddableEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("videoEmbeddableUnspecified")]
                VideoEmbeddableUnspecified = 0,

                /// <summary>Return all videos, embeddable or not.</summary>
                [Google.Apis.Util.StringValueAttribute("any")]
                Any = 1,

                /// <summary>Only retrieve embeddable videos.</summary>
                [Google.Apis.Util.StringValueAttribute("true")]
                True__ = 2,
            }

            /// <summary>Filter on the license of the videos.</summary>
            [Google.Apis.Util.RequestParameterAttribute("videoLicense", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<VideoLicenseEnum> VideoLicense { get; set; }

            /// <summary>Filter on the license of the videos.</summary>
            public enum VideoLicenseEnum
            {
                /// <summary>
                /// Return all videos, regardless of which license they have, that match the query parameters.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("any")]
                Any = 0,

                /// <summary>Only return videos that have the standard YouTube license.</summary>
                [Google.Apis.Util.StringValueAttribute("youtube")]
                Youtube = 1,

                /// <summary>
                /// Only return videos that have a Creative Commons license. Users can reuse videos with this license in
                /// other videos that they create. Learn more.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("creativeCommon")]
                CreativeCommon = 2,
            }

            /// <summary>Filter on syndicated videos.</summary>
            [Google.Apis.Util.RequestParameterAttribute("videoSyndicated", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<VideoSyndicatedEnum> VideoSyndicated { get; set; }

            /// <summary>Filter on syndicated videos.</summary>
            public enum VideoSyndicatedEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("videoSyndicatedUnspecified")]
                VideoSyndicatedUnspecified = 0,

                /// <summary>Return all videos, syndicated or not.</summary>
                [Google.Apis.Util.StringValueAttribute("any")]
                Any = 1,

                /// <summary>Only retrieve syndicated videos.</summary>
                [Google.Apis.Util.StringValueAttribute("true")]
                True__ = 2,
            }

            /// <summary>Filter on videos of a specific type.</summary>
            [Google.Apis.Util.RequestParameterAttribute("videoType", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<VideoTypeEnum> VideoType { get; set; }

            /// <summary>Filter on videos of a specific type.</summary>
            public enum VideoTypeEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("videoTypeUnspecified")]
                VideoTypeUnspecified = 0,

                /// <summary>Return all videos.</summary>
                [Google.Apis.Util.StringValueAttribute("any")]
                Any = 1,

                /// <summary>Only retrieve movies.</summary>
                [Google.Apis.Util.StringValueAttribute("movie")]
                Movie = 2,

                /// <summary>Only retrieve episodes of shows.</summary>
                [Google.Apis.Util.StringValueAttribute("episode")]
                Episode = 3,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/search";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("channelId", new Google.Apis.Discovery.Parameter
                {
                    Name = "channelId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("channelType", new Google.Apis.Discovery.Parameter
                {
                    Name = "channelType",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("eventType", new Google.Apis.Discovery.Parameter
                {
                    Name = "eventType",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("forContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "forContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("forDeveloper", new Google.Apis.Discovery.Parameter
                {
                    Name = "forDeveloper",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("forMine", new Google.Apis.Discovery.Parameter
                {
                    Name = "forMine",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                {
                    Name = "location",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("locationRadius", new Google.Apis.Discovery.Parameter
                {
                    Name = "locationRadius",
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
                    DefaultValue = "5",
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("order", new Google.Apis.Discovery.Parameter
                {
                    Name = "order",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "relevance",
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
                RequestParameters.Add("publishedAfter", new Google.Apis.Discovery.Parameter
                {
                    Name = "publishedAfter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("publishedBefore", new Google.Apis.Discovery.Parameter
                {
                    Name = "publishedBefore",
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
                RequestParameters.Add("regionCode", new Google.Apis.Discovery.Parameter
                {
                    Name = "regionCode",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("relatedToVideoId", new Google.Apis.Discovery.Parameter
                {
                    Name = "relatedToVideoId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("relevanceLanguage", new Google.Apis.Discovery.Parameter
                {
                    Name = "relevanceLanguage",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("safeSearch", new Google.Apis.Discovery.Parameter
                {
                    Name = "safeSearch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "moderate",
                    Pattern = null,
                });
                RequestParameters.Add("topicId", new Google.Apis.Discovery.Parameter
                {
                    Name = "topicId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("type", new Google.Apis.Discovery.Parameter
                {
                    Name = "type",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("videoCaption", new Google.Apis.Discovery.Parameter
                {
                    Name = "videoCaption",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("videoCategoryId", new Google.Apis.Discovery.Parameter
                {
                    Name = "videoCategoryId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("videoDefinition", new Google.Apis.Discovery.Parameter
                {
                    Name = "videoDefinition",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("videoDimension", new Google.Apis.Discovery.Parameter
                {
                    Name = "videoDimension",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("videoDuration", new Google.Apis.Discovery.Parameter
                {
                    Name = "videoDuration",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("videoEmbeddable", new Google.Apis.Discovery.Parameter
                {
                    Name = "videoEmbeddable",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("videoLicense", new Google.Apis.Discovery.Parameter
                {
                    Name = "videoLicense",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("videoSyndicated", new Google.Apis.Discovery.Parameter
                {
                    Name = "videoSyndicated",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("videoType", new Google.Apis.Discovery.Parameter
                {
                    Name = "videoType",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
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

        /// <summary>Deletes a resource.</summary>
        /// <param name="id"><c>null</c></param>
        public virtual DeleteRequest Delete(string id)
        {
            return new DeleteRequest(service, id);
        }

        /// <summary>Deletes a resource.</summary>
        public class DeleteRequest : YouTubeBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string id) : base(service)
            {
                Id = id;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Id { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/subscriptions";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts a new resource into this collection.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="part">
        /// The *part* parameter serves two purposes in this operation. It identifies the properties that the write
        /// operation will set as well as the properties that the API response will include.
        /// </param>
        public virtual InsertRequest Insert(Google.Apis.YouTube.v3.Data.Subscription body, Google.Apis.Util.Repeatable<string> part)
        {
            return new InsertRequest(service, body, part);
        }

        /// <summary>Inserts a new resource into this collection.</summary>
        public class InsertRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.Subscription>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.YouTube.v3.Data.Subscription body, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter serves two purposes in this operation. It identifies the properties that the write
            /// operation will set as well as the properties that the API response will include.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.YouTube.v3.Data.Subscription Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/subscriptions";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves a list of resources, possibly filtered.</summary>
        /// <param name="part">
        /// The *part* parameter specifies a comma-separated list of one or more subscription resource properties that
        /// the API response will include. If the parameter identifies a property that contains child properties, the
        /// child properties will be included in the response. For example, in a subscription resource, the snippet
        /// property contains other properties, such as a display title for the subscription. If you set *part=snippet*,
        /// the API response will also contain all of those nested properties.
        /// </param>
        public virtual ListRequest List(Google.Apis.Util.Repeatable<string> part)
        {
            return new ListRequest(service, part);
        }

        /// <summary>Retrieves a list of resources, possibly filtered.</summary>
        public class ListRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.SubscriptionListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter specifies a comma-separated list of one or more subscription resource properties
            /// that the API response will include. If the parameter identifies a property that contains child
            /// properties, the child properties will be included in the response. For example, in a subscription
            /// resource, the snippet property contains other properties, such as a display title for the subscription.
            /// If you set *part=snippet*, the API response will also contain all of those nested properties.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>Return the subscriptions of the given channel owner.</summary>
            [Google.Apis.Util.RequestParameterAttribute("channelId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ChannelId { get; set; }

            /// <summary>
            /// Return the subscriptions to the subset of these channels that the authenticated user is subscribed to.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("forChannelId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ForChannelId { get; set; }

            /// <summary>Return the subscriptions with the given IDs for Stubby or Apiary.</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Id { get; set; }

            /// <summary>
            /// The *maxResults* parameter specifies the maximum number of items that should be returned in the result
            /// set.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>Flag for returning the subscriptions of the authenticated user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("mine", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Mine { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("myRecentSubscribers", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> MyRecentSubscribers { get; set; }

            /// <summary>Return the subscribers of the given channel owner.</summary>
            [Google.Apis.Util.RequestParameterAttribute("mySubscribers", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> MySubscribers { get; set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The CMS account that
            /// the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>
            /// This parameter can only be used in a properly authorized request. *Note:* This parameter is intended
            /// exclusively for YouTube content partners. The *onBehalfOfContentOwnerChannel* parameter specifies the
            /// YouTube channel ID of the channel to which a video is being added. This parameter is required when a
            /// request specifies a value for the onBehalfOfContentOwner parameter, and it can only be used in
            /// conjunction with that parameter. In addition, the request must be authorized using a CMS account that is
            /// linked to the content owner that the onBehalfOfContentOwner parameter specifies. Finally, the channel
            /// that the onBehalfOfContentOwnerChannel parameter value specifies must be linked to the content owner
            /// that the onBehalfOfContentOwner parameter specifies. This parameter is intended for YouTube content
            /// partners that own and manage many different YouTube channels. It allows content owners to authenticate
            /// once and perform actions on behalf of the channel specified in the parameter value, without having to
            /// provide authentication credentials for each separate channel.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwnerChannel", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwnerChannel { get; set; }

            /// <summary>The order of the returned subscriptions</summary>
            [Google.Apis.Util.RequestParameterAttribute("order", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<OrderEnum> Order { get; set; }

            /// <summary>The order of the returned subscriptions</summary>
            public enum OrderEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("subscriptionOrderUnspecified")]
                SubscriptionOrderUnspecified = 0,

                /// <summary>Sort by relevance.</summary>
                [Google.Apis.Util.StringValueAttribute("relevance")]
                Relevance = 1,

                /// <summary>Sort by order of activity.</summary>
                [Google.Apis.Util.StringValueAttribute("unread")]
                Unread = 2,

                /// <summary>Sort alphabetically.</summary>
                [Google.Apis.Util.StringValueAttribute("alphabetical")]
                Alphabetical = 3,
            }

            /// <summary>
            /// The *pageToken* parameter identifies a specific page in the result set that should be returned. In an
            /// API response, the nextPageToken and prevPageToken properties identify other pages that could be
            /// retrieved.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/subscriptions";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("channelId", new Google.Apis.Discovery.Parameter
                {
                    Name = "channelId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("forChannelId", new Google.Apis.Discovery.Parameter
                {
                    Name = "forChannelId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
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
                    DefaultValue = "5",
                    Pattern = null,
                });
                RequestParameters.Add("mine", new Google.Apis.Discovery.Parameter
                {
                    Name = "mine",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("myRecentSubscribers", new Google.Apis.Discovery.Parameter
                {
                    Name = "myRecentSubscribers",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("mySubscribers", new Google.Apis.Discovery.Parameter
                {
                    Name = "mySubscribers",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwnerChannel", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwnerChannel",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("order", new Google.Apis.Discovery.Parameter
                {
                    Name = "order",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "relevance",
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

    /// <summary>The "superChatEvents" collection of methods.</summary>
    public class SuperChatEventsResource
    {
        private const string Resource = "superChatEvents";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public SuperChatEventsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Retrieves a list of resources, possibly filtered.</summary>
        /// <param name="part">
        /// The *part* parameter specifies the superChatEvent resource parts that the API response will include. This
        /// parameter is currently not supported.
        /// </param>
        public virtual ListRequest List(Google.Apis.Util.Repeatable<string> part)
        {
            return new ListRequest(service, part);
        }

        /// <summary>Retrieves a list of resources, possibly filtered.</summary>
        public class ListRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.SuperChatEventListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter specifies the superChatEvent resource parts that the API response will include.
            /// This parameter is currently not supported.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>Return rendered funding amounts in specified language.</summary>
            [Google.Apis.Util.RequestParameterAttribute("hl", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Hl { get; set; }

            /// <summary>
            /// The *maxResults* parameter specifies the maximum number of items that should be returned in the result
            /// set.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>
            /// The *pageToken* parameter identifies a specific page in the result set that should be returned. In an
            /// API response, the nextPageToken and prevPageToken properties identify other pages that could be
            /// retrieved.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/superChatEvents";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("hl", new Google.Apis.Discovery.Parameter
                {
                    Name = "hl",
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
                    DefaultValue = "5",
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

    /// <summary>The "tests" collection of methods.</summary>
    public class TestsResource
    {
        private const string Resource = "tests";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public TestsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>POST method.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="part"><c>null</c></param>
        public virtual InsertRequest Insert(Google.Apis.YouTube.v3.Data.TestItem body, Google.Apis.Util.Repeatable<string> part)
        {
            return new InsertRequest(service, body, part);
        }

        /// <summary>POST method.</summary>
        public class InsertRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.TestItem>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.YouTube.v3.Data.TestItem body, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                Body = body;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.YouTube.v3.Data.TestItem Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/tests";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "thirdPartyLinks" collection of methods.</summary>
    public class ThirdPartyLinksResource
    {
        private const string Resource = "thirdPartyLinks";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ThirdPartyLinksResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Deletes a resource.</summary>
        /// <param name="linkingToken">Delete the partner links with the given linking token.</param>
        /// <param name="type">Type of the link to be deleted.</param>
        public virtual DeleteRequest Delete(string linkingToken, DeleteRequest.TypeEnum type)
        {
            return new DeleteRequest(service, linkingToken, type);
        }

        /// <summary>Deletes a resource.</summary>
        public class DeleteRequest : YouTubeBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string linkingToken, TypeEnum type) : base(service)
            {
                LinkingToken = linkingToken;
                Type = type;
                InitParameters();
            }

            /// <summary>Delete the partner links with the given linking token.</summary>
            [Google.Apis.Util.RequestParameterAttribute("linkingToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string LinkingToken { get; private set; }

            /// <summary>Type of the link to be deleted.</summary>
            [Google.Apis.Util.RequestParameterAttribute("type", Google.Apis.Util.RequestParameterType.Query)]
            public virtual TypeEnum Type { get; private set; }

            /// <summary>Type of the link to be deleted.</summary>
            public enum TypeEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("linkUnspecified")]
                LinkUnspecified = 0,

                /// <summary>
                /// A link that is connecting (or about to connect) a channel with a store on a merchandising platform
                /// in order to enable retail commerce capabilities for that channel on YouTube.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("channelToStoreLink")]
                ChannelToStoreLink = 1,
            }

            /// <summary>Do not use. Required for compatibility.</summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/thirdPartyLinks";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("linkingToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "linkingToken",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("type", new Google.Apis.Discovery.Parameter
                {
                    Name = "type",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts a new resource into this collection.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="part">
        /// The *part* parameter specifies the thirdPartyLink resource parts that the API request and response will
        /// include. Supported values are linkingToken, status, and snippet.
        /// </param>
        public virtual InsertRequest Insert(Google.Apis.YouTube.v3.Data.ThirdPartyLink body, Google.Apis.Util.Repeatable<string> part)
        {
            return new InsertRequest(service, body, part);
        }

        /// <summary>Inserts a new resource into this collection.</summary>
        public class InsertRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.ThirdPartyLink>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.YouTube.v3.Data.ThirdPartyLink body, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter specifies the thirdPartyLink resource parts that the API request and response will
            /// include. Supported values are linkingToken, status, and snippet.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.YouTube.v3.Data.ThirdPartyLink Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/thirdPartyLinks";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves a list of resources, possibly filtered.</summary>
        /// <param name="part">
        /// The *part* parameter specifies the thirdPartyLink resource parts that the API response will include.
        /// Supported values are linkingToken, status, and snippet.
        /// </param>
        public virtual ListRequest List(Google.Apis.Util.Repeatable<string> part)
        {
            return new ListRequest(service, part);
        }

        /// <summary>Retrieves a list of resources, possibly filtered.</summary>
        public class ListRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.ThirdPartyLink>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter specifies the thirdPartyLink resource parts that the API response will include.
            /// Supported values are linkingToken, status, and snippet.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>Get a third party link with the given linking token.</summary>
            [Google.Apis.Util.RequestParameterAttribute("linkingToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string LinkingToken { get; set; }

            /// <summary>Get a third party link of the given type.</summary>
            [Google.Apis.Util.RequestParameterAttribute("type", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<TypeEnum> Type { get; set; }

            /// <summary>Get a third party link of the given type.</summary>
            public enum TypeEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("linkUnspecified")]
                LinkUnspecified = 0,

                /// <summary>
                /// A link that is connecting (or about to connect) a channel with a store on a merchandising platform
                /// in order to enable retail commerce capabilities for that channel on YouTube.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("channelToStoreLink")]
                ChannelToStoreLink = 1,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/thirdPartyLinks";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("linkingToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "linkingToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("type", new Google.Apis.Discovery.Parameter
                {
                    Name = "type",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates an existing resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="part">
        /// The *part* parameter specifies the thirdPartyLink resource parts that the API request and response will
        /// include. Supported values are linkingToken, status, and snippet.
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.YouTube.v3.Data.ThirdPartyLink body, Google.Apis.Util.Repeatable<string> part)
        {
            return new UpdateRequest(service, body, part);
        }

        /// <summary>Updates an existing resource.</summary>
        public class UpdateRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.ThirdPartyLink>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.YouTube.v3.Data.ThirdPartyLink body, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter specifies the thirdPartyLink resource parts that the API request and response will
            /// include. Supported values are linkingToken, status, and snippet.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.YouTube.v3.Data.ThirdPartyLink Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/thirdPartyLinks";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "thumbnails" collection of methods.</summary>
    public class ThumbnailsResource
    {
        private const string Resource = "thumbnails";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ThumbnailsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// As this is not an insert in a strict sense (it supports uploading/setting of a thumbnail for multiple
        /// videos, which doesn't result in creation of a single resource), I use a custom verb here.
        /// </summary>
        /// <param name="videoId">Returns the Thumbnail with the given video IDs for Stubby or Apiary.</param>
        public virtual SetRequest Set(string videoId)
        {
            return new SetRequest(service, videoId);
        }

        /// <summary>
        /// As this is not an insert in a strict sense (it supports uploading/setting of a thumbnail for multiple
        /// videos, which doesn't result in creation of a single resource), I use a custom verb here.
        /// </summary>
        public class SetRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.ThumbnailSetResponse>
        {
            /// <summary>Constructs a new Set request.</summary>
            public SetRequest(Google.Apis.Services.IClientService service, string videoId) : base(service)
            {
                VideoId = videoId;
                InitParameters();
            }

            /// <summary>Returns the Thumbnail with the given video IDs for Stubby or Apiary.</summary>
            [Google.Apis.Util.RequestParameterAttribute("videoId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string VideoId { get; private set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The actual CMS account
            /// that the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "set";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/thumbnails/set";

            /// <summary>Initializes Set parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("videoId", new Google.Apis.Discovery.Parameter
                {
                    Name = "videoId",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// As this is not an insert in a strict sense (it supports uploading/setting of a thumbnail for multiple
        /// videos, which doesn't result in creation of a single resource), I use a custom verb here.
        /// </summary>
        /// <remarks>
        /// Considerations regarding <paramref name="stream"/>:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before reading
        /// commences. If <paramref name="stream"/> is not seekable, then it will be read from its current position
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
        /// <param name="videoId">Returns the Thumbnail with the given video IDs for Stubby or Apiary.</param>
        /// <param name="stream">The stream to upload. See remarks for further information.</param>
        /// <param name="contentType">The content type of the stream to upload.</param>
        public virtual SetMediaUpload Set(string videoId, System.IO.Stream stream, string contentType)
        {
            return new SetMediaUpload(service, videoId, stream, contentType);
        }

        /// <summary>Set media upload which supports resumable upload.</summary>
        public class SetMediaUpload : Google.Apis.Upload.ResumableUpload<string, Google.Apis.YouTube.v3.Data.ThumbnailSetResponse>
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
            /// Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned
            /// to a user, but should not exceed 40 characters.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string QuotaUser { get; set; }

            /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
            [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UploadType { get; set; }

            /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
            [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UploadProtocol { get; set; }

            /// <summary>Returns the Thumbnail with the given video IDs for Stubby or Apiary.</summary>
            [Google.Apis.Util.RequestParameterAttribute("videoId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string VideoId { get; private set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The actual CMS account
            /// that the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>Constructs a new Set media upload instance.</summary>
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
            public SetMediaUpload(Google.Apis.Services.IClientService service, string videoId, System.IO.Stream stream, string contentType)
                : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "youtube/v3/thumbnails/set"), "POST", stream, contentType)
            {
                VideoId = videoId;
            }
        }
    }

    /// <summary>The "videoAbuseReportReasons" collection of methods.</summary>
    public class VideoAbuseReportReasonsResource
    {
        private const string Resource = "videoAbuseReportReasons";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public VideoAbuseReportReasonsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Retrieves a list of resources, possibly filtered.</summary>
        /// <param name="part">
        /// The *part* parameter specifies the videoCategory resource parts that the API response will include.
        /// Supported values are id and snippet.
        /// </param>
        public virtual ListRequest List(Google.Apis.Util.Repeatable<string> part)
        {
            return new ListRequest(service, part);
        }

        /// <summary>Retrieves a list of resources, possibly filtered.</summary>
        public class ListRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.VideoAbuseReportReasonListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter specifies the videoCategory resource parts that the API response will include.
            /// Supported values are id and snippet.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("hl", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Hl { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/videoAbuseReportReasons";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("hl", new Google.Apis.Discovery.Parameter
                {
                    Name = "hl",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "en-US",
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "videoCategories" collection of methods.</summary>
    public class VideoCategoriesResource
    {
        private const string Resource = "videoCategories";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public VideoCategoriesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Retrieves a list of resources, possibly filtered.</summary>
        /// <param name="part">
        /// The *part* parameter specifies the videoCategory resource properties that the API response will include. Set
        /// the parameter value to snippet.
        /// </param>
        public virtual ListRequest List(Google.Apis.Util.Repeatable<string> part)
        {
            return new ListRequest(service, part);
        }

        /// <summary>Retrieves a list of resources, possibly filtered.</summary>
        public class ListRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.VideoCategoryListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter specifies the videoCategory resource properties that the API response will include.
            /// Set the parameter value to snippet.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("hl", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Hl { get; set; }

            /// <summary>Returns the video categories with the given IDs for Stubby or Apiary.</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Id { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("regionCode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string RegionCode { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/videoCategories";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("hl", new Google.Apis.Discovery.Parameter
                {
                    Name = "hl",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "en-US",
                    Pattern = null,
                });
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("regionCode", new Google.Apis.Discovery.Parameter
                {
                    Name = "regionCode",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "videos" collection of methods.</summary>
    public class VideosResource
    {
        private const string Resource = "videos";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public VideosResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Deletes a resource.</summary>
        /// <param name="id"><c>null</c></param>
        public virtual DeleteRequest Delete(string id)
        {
            return new DeleteRequest(service, id);
        }

        /// <summary>Deletes a resource.</summary>
        public class DeleteRequest : YouTubeBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string id) : base(service)
            {
                Id = id;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Id { get; private set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The actual CMS account
            /// that the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/videos";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves the ratings that the authorized user gave to a list of specified videos.</summary>
        /// <param name="id"><c>null</c></param>
        public virtual GetRatingRequest GetRating(Google.Apis.Util.Repeatable<string> id)
        {
            return new GetRatingRequest(service, id);
        }

        /// <summary>Retrieves the ratings that the authorized user gave to a list of specified videos.</summary>
        public class GetRatingRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.VideoGetRatingResponse>
        {
            /// <summary>Constructs a new GetRating request.</summary>
            public GetRatingRequest(Google.Apis.Services.IClientService service, Google.Apis.Util.Repeatable<string> id) : base(service)
            {
                Id = id;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Id { get; private set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The CMS account that
            /// the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getRating";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/videos/getRating";

            /// <summary>Initializes GetRating parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts a new resource into this collection.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="part">
        /// The *part* parameter serves two purposes in this operation. It identifies the properties that the write
        /// operation will set as well as the properties that the API response will include. Note that not all parts
        /// contain properties that can be set when inserting or updating a video. For example, the statistics object
        /// encapsulates statistics that YouTube calculates for a video and does not contain values that you can set or
        /// modify. If the parameter value specifies a part that does not contain mutable values, that part will still
        /// be included in the API response.
        /// </param>
        public virtual InsertRequest Insert(Google.Apis.YouTube.v3.Data.Video body, Google.Apis.Util.Repeatable<string> part)
        {
            return new InsertRequest(service, body, part);
        }

        /// <summary>Inserts a new resource into this collection.</summary>
        public class InsertRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.Video>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.YouTube.v3.Data.Video body, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter serves two purposes in this operation. It identifies the properties that the write
            /// operation will set as well as the properties that the API response will include. Note that not all parts
            /// contain properties that can be set when inserting or updating a video. For example, the statistics
            /// object encapsulates statistics that YouTube calculates for a video and does not contain values that you
            /// can set or modify. If the parameter value specifies a part that does not contain mutable values, that
            /// part will still be included in the API response.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>Should auto-levels be applied to the upload.</summary>
            [Google.Apis.Util.RequestParameterAttribute("autoLevels", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> AutoLevels { get; set; }

            /// <summary>
            /// Notify the channel subscribers about the new video. As default, the notification is enabled.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("notifySubscribers", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> NotifySubscribers { get; set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The CMS account that
            /// the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>
            /// This parameter can only be used in a properly authorized request. *Note:* This parameter is intended
            /// exclusively for YouTube content partners. The *onBehalfOfContentOwnerChannel* parameter specifies the
            /// YouTube channel ID of the channel to which a video is being added. This parameter is required when a
            /// request specifies a value for the onBehalfOfContentOwner parameter, and it can only be used in
            /// conjunction with that parameter. In addition, the request must be authorized using a CMS account that is
            /// linked to the content owner that the onBehalfOfContentOwner parameter specifies. Finally, the channel
            /// that the onBehalfOfContentOwnerChannel parameter value specifies must be linked to the content owner
            /// that the onBehalfOfContentOwner parameter specifies. This parameter is intended for YouTube content
            /// partners that own and manage many different YouTube channels. It allows content owners to authenticate
            /// once and perform actions on behalf of the channel specified in the parameter value, without having to
            /// provide authentication credentials for each separate channel.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwnerChannel", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwnerChannel { get; set; }

            /// <summary>Should stabilize be applied to the upload.</summary>
            [Google.Apis.Util.RequestParameterAttribute("stabilize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Stabilize { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.YouTube.v3.Data.Video Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/videos";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("autoLevels", new Google.Apis.Discovery.Parameter
                {
                    Name = "autoLevels",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("notifySubscribers", new Google.Apis.Discovery.Parameter
                {
                    Name = "notifySubscribers",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwnerChannel", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwnerChannel",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("stabilize", new Google.Apis.Discovery.Parameter
                {
                    Name = "stabilize",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts a new resource into this collection.</summary>
        /// <remarks>
        /// Considerations regarding <paramref name="stream"/>:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before reading
        /// commences. If <paramref name="stream"/> is not seekable, then it will be read from its current position
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
        /// <param name="part">
        /// The *part* parameter serves two purposes in this operation. It identifies the properties that the write
        /// operation will set as well as the properties that the API response will include. Note that not all parts
        /// contain properties that can be set when inserting or updating a video. For example, the statistics object
        /// encapsulates statistics that YouTube calculates for a video and does not contain values that you can set or
        /// modify. If the parameter value specifies a part that does not contain mutable values, that part will still
        /// be included in the API response.
        /// </param>
        /// <param name="stream">The stream to upload. See remarks for further information.</param>
        /// <param name="contentType">The content type of the stream to upload.</param>
        public virtual InsertMediaUpload Insert(Google.Apis.YouTube.v3.Data.Video body, Google.Apis.Util.Repeatable<string> part, System.IO.Stream stream, string contentType)
        {
            return new InsertMediaUpload(service, body, part, stream, contentType);
        }

        /// <summary>Insert media upload which supports resumable upload.</summary>
        public class InsertMediaUpload : Google.Apis.Upload.ResumableUpload<Google.Apis.YouTube.v3.Data.Video, Google.Apis.YouTube.v3.Data.Video>
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
            /// Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned
            /// to a user, but should not exceed 40 characters.
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
            /// The *part* parameter serves two purposes in this operation. It identifies the properties that the write
            /// operation will set as well as the properties that the API response will include. Note that not all parts
            /// contain properties that can be set when inserting or updating a video. For example, the statistics
            /// object encapsulates statistics that YouTube calculates for a video and does not contain values that you
            /// can set or modify. If the parameter value specifies a part that does not contain mutable values, that
            /// part will still be included in the API response.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>Should auto-levels be applied to the upload.</summary>
            [Google.Apis.Util.RequestParameterAttribute("autoLevels", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> AutoLevels { get; set; }

            /// <summary>
            /// Notify the channel subscribers about the new video. As default, the notification is enabled.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("notifySubscribers", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> NotifySubscribers { get; set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The CMS account that
            /// the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>
            /// This parameter can only be used in a properly authorized request. *Note:* This parameter is intended
            /// exclusively for YouTube content partners. The *onBehalfOfContentOwnerChannel* parameter specifies the
            /// YouTube channel ID of the channel to which a video is being added. This parameter is required when a
            /// request specifies a value for the onBehalfOfContentOwner parameter, and it can only be used in
            /// conjunction with that parameter. In addition, the request must be authorized using a CMS account that is
            /// linked to the content owner that the onBehalfOfContentOwner parameter specifies. Finally, the channel
            /// that the onBehalfOfContentOwnerChannel parameter value specifies must be linked to the content owner
            /// that the onBehalfOfContentOwner parameter specifies. This parameter is intended for YouTube content
            /// partners that own and manage many different YouTube channels. It allows content owners to authenticate
            /// once and perform actions on behalf of the channel specified in the parameter value, without having to
            /// provide authentication credentials for each separate channel.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwnerChannel", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwnerChannel { get; set; }

            /// <summary>Should stabilize be applied to the upload.</summary>
            [Google.Apis.Util.RequestParameterAttribute("stabilize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Stabilize { get; set; }

            /// <summary>Constructs a new Insert media upload instance.</summary>
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
            public InsertMediaUpload(Google.Apis.Services.IClientService service, Google.Apis.YouTube.v3.Data.Video body, Google.Apis.Util.Repeatable<string> part, System.IO.Stream stream, string contentType)
                : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "youtube/v3/videos"), "POST", stream, contentType)
            {
                Part = part;
                Body = body;
            }
        }

        /// <summary>Retrieves a list of resources, possibly filtered.</summary>
        /// <param name="part">
        /// The *part* parameter specifies a comma-separated list of one or more video resource properties that the API
        /// response will include. If the parameter identifies a property that contains child properties, the child
        /// properties will be included in the response. For example, in a video resource, the snippet property contains
        /// the channelId, title, description, tags, and categoryId properties. As such, if you set *part=snippet*, the
        /// API response will contain all of those properties.
        /// </param>
        public virtual ListRequest List(Google.Apis.Util.Repeatable<string> part)
        {
            return new ListRequest(service, part);
        }

        /// <summary>Retrieves a list of resources, possibly filtered.</summary>
        public class ListRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.VideoListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter specifies a comma-separated list of one or more video resource properties that the
            /// API response will include. If the parameter identifies a property that contains child properties, the
            /// child properties will be included in the response. For example, in a video resource, the snippet
            /// property contains the channelId, title, description, tags, and categoryId properties. As such, if you
            /// set *part=snippet*, the API response will contain all of those properties.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>Return the videos that are in the specified chart.</summary>
            [Google.Apis.Util.RequestParameterAttribute("chart", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ChartEnum> Chart { get; set; }

            /// <summary>Return the videos that are in the specified chart.</summary>
            public enum ChartEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("chartUnspecified")]
                ChartUnspecified = 0,

                /// <summary>
                /// Return the most popular videos for the specified content region and video category.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("mostPopular")]
                MostPopular = 1,
            }

            /// <summary>
            /// Stands for "host language". Specifies the localization language of the metadata to be filled into
            /// snippet.localized. The field is filled with the default metadata if there is no localization in the
            /// specified language. The parameter value must be a language code included in the list returned by the
            /// i18nLanguages.list method (e.g. en_US, es_MX).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("hl", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Hl { get; set; }

            /// <summary>Return videos with the given ids.</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Id { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("locale", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Locale { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("maxHeight", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxHeight { get; set; }

            /// <summary>
            /// The *maxResults* parameter specifies the maximum number of items that should be returned in the result
            /// set. *Note:* This parameter is supported for use in conjunction with the myRating and chart parameters,
            /// but it is not supported for use in conjunction with the id parameter.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>Return the player with maximum height specified in</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxWidth", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxWidth { get; set; }

            /// <summary>
            /// Return videos liked/disliked by the authenticated user. Does not support RateType.RATED_TYPE_NONE.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("myRating", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<MyRatingEnum> MyRating { get; set; }

            /// <summary>
            /// Return videos liked/disliked by the authenticated user. Does not support RateType.RATED_TYPE_NONE.
            /// </summary>
            public enum MyRatingEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("none")]
                None = 0,

                /// <summary>The entity is liked.</summary>
                [Google.Apis.Util.StringValueAttribute("like")]
                Like = 1,

                /// <summary>The entity is disliked.</summary>
                [Google.Apis.Util.StringValueAttribute("dislike")]
                Dislike = 2,
            }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The CMS account that
            /// the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>
            /// The *pageToken* parameter identifies a specific page in the result set that should be returned. In an
            /// API response, the nextPageToken and prevPageToken properties identify other pages that could be
            /// retrieved. *Note:* This parameter is supported for use in conjunction with the myRating and chart
            /// parameters, but it is not supported for use in conjunction with the id parameter.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Use a chart that is specific to the specified region</summary>
            [Google.Apis.Util.RequestParameterAttribute("regionCode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string RegionCode { get; set; }

            /// <summary>Use chart that is specific to the specified video category</summary>
            [Google.Apis.Util.RequestParameterAttribute("videoCategoryId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string VideoCategoryId { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/videos";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("chart", new Google.Apis.Discovery.Parameter
                {
                    Name = "chart",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("hl", new Google.Apis.Discovery.Parameter
                {
                    Name = "hl",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("locale", new Google.Apis.Discovery.Parameter
                {
                    Name = "locale",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxHeight", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxHeight",
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
                    DefaultValue = "5",
                    Pattern = null,
                });
                RequestParameters.Add("maxWidth", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxWidth",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("myRating", new Google.Apis.Discovery.Parameter
                {
                    Name = "myRating",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
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
                RequestParameters.Add("regionCode", new Google.Apis.Discovery.Parameter
                {
                    Name = "regionCode",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("videoCategoryId", new Google.Apis.Discovery.Parameter
                {
                    Name = "videoCategoryId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "0",
                    Pattern = null,
                });
            }
        }

        /// <summary>Adds a like or dislike rating to a video or removes a rating from a video.</summary>
        /// <param name="id"><c>null</c></param>
        /// <param name="rating"><c>null</c></param>
        public virtual RateRequest Rate(string id, RateRequest.RatingEnum rating)
        {
            return new RateRequest(service, id, rating);
        }

        /// <summary>Adds a like or dislike rating to a video or removes a rating from a video.</summary>
        public class RateRequest : YouTubeBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Rate request.</summary>
            public RateRequest(Google.Apis.Services.IClientService service, string id, RatingEnum rating) : base(service)
            {
                Id = id;
                Rating = rating;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Id { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("rating", Google.Apis.Util.RequestParameterType.Query)]
            public virtual RatingEnum Rating { get; private set; }

            public enum RatingEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("none")]
                None = 0,

                /// <summary>The entity is liked.</summary>
                [Google.Apis.Util.StringValueAttribute("like")]
                Like = 1,

                /// <summary>The entity is disliked.</summary>
                [Google.Apis.Util.StringValueAttribute("dislike")]
                Dislike = 2,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "rate";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/videos/rate";

            /// <summary>Initializes Rate parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("rating", new Google.Apis.Discovery.Parameter
                {
                    Name = "rating",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Report abuse for a video.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual ReportAbuseRequest ReportAbuse(Google.Apis.YouTube.v3.Data.VideoAbuseReport body)
        {
            return new ReportAbuseRequest(service, body);
        }

        /// <summary>Report abuse for a video.</summary>
        public class ReportAbuseRequest : YouTubeBaseServiceRequest<string>
        {
            /// <summary>Constructs a new ReportAbuse request.</summary>
            public ReportAbuseRequest(Google.Apis.Services.IClientService service, Google.Apis.YouTube.v3.Data.VideoAbuseReport body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The CMS account that
            /// the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.YouTube.v3.Data.VideoAbuseReport Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "reportAbuse";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/videos/reportAbuse";

            /// <summary>Initializes ReportAbuse parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates an existing resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="part">
        /// The *part* parameter serves two purposes in this operation. It identifies the properties that the write
        /// operation will set as well as the properties that the API response will include. Note that this method will
        /// override the existing values for all of the mutable properties that are contained in any parts that the
        /// parameter value specifies. For example, a video's privacy setting is contained in the status part. As such,
        /// if your request is updating a private video, and the request's part parameter value includes the status
        /// part, the video's privacy setting will be updated to whatever value the request body specifies. If the
        /// request body does not specify a value, the existing privacy setting will be removed and the video will
        /// revert to the default privacy setting. In addition, not all parts contain properties that can be set when
        /// inserting or updating a video. For example, the statistics object encapsulates statistics that YouTube
        /// calculates for a video and does not contain values that you can set or modify. If the parameter value
        /// specifies a part that does not contain mutable values, that part will still be included in the API response.
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.YouTube.v3.Data.Video body, Google.Apis.Util.Repeatable<string> part)
        {
            return new UpdateRequest(service, body, part);
        }

        /// <summary>Updates an existing resource.</summary>
        public class UpdateRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.Video>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.YouTube.v3.Data.Video body, Google.Apis.Util.Repeatable<string> part) : base(service)
            {
                Part = part;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The *part* parameter serves two purposes in this operation. It identifies the properties that the write
            /// operation will set as well as the properties that the API response will include. Note that this method
            /// will override the existing values for all of the mutable properties that are contained in any parts that
            /// the parameter value specifies. For example, a video's privacy setting is contained in the status part.
            /// As such, if your request is updating a private video, and the request's part parameter value includes
            /// the status part, the video's privacy setting will be updated to whatever value the request body
            /// specifies. If the request body does not specify a value, the existing privacy setting will be removed
            /// and the video will revert to the default privacy setting. In addition, not all parts contain properties
            /// that can be set when inserting or updating a video. For example, the statistics object encapsulates
            /// statistics that YouTube calculates for a video and does not contain values that you can set or modify.
            /// If the parameter value specifies a part that does not contain mutable values, that part will still be
            /// included in the API response.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Part { get; private set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The actual CMS account
            /// that the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.YouTube.v3.Data.Video Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/videos";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                {
                    Name = "part",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "watermarks" collection of methods.</summary>
    public class WatermarksResource
    {
        private const string Resource = "watermarks";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public WatermarksResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Allows upload of watermark image and setting it for a channel.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="channelId"><c>null</c></param>
        public virtual SetRequest Set(Google.Apis.YouTube.v3.Data.InvideoBranding body, string channelId)
        {
            return new SetRequest(service, body, channelId);
        }

        /// <summary>Allows upload of watermark image and setting it for a channel.</summary>
        public class SetRequest : YouTubeBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Set request.</summary>
            public SetRequest(Google.Apis.Services.IClientService service, Google.Apis.YouTube.v3.Data.InvideoBranding body, string channelId) : base(service)
            {
                ChannelId = channelId;
                Body = body;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("channelId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ChannelId { get; private set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The CMS account that
            /// the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.YouTube.v3.Data.InvideoBranding Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "set";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/watermarks/set";

            /// <summary>Initializes Set parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("channelId", new Google.Apis.Discovery.Parameter
                {
                    Name = "channelId",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Allows upload of watermark image and setting it for a channel.</summary>
        /// <remarks>
        /// Considerations regarding <paramref name="stream"/>:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before reading
        /// commences. If <paramref name="stream"/> is not seekable, then it will be read from its current position
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
        /// <param name="channelId"><c>null</c></param>
        /// <param name="stream">The stream to upload. See remarks for further information.</param>
        /// <param name="contentType">The content type of the stream to upload.</param>
        public virtual SetMediaUpload Set(Google.Apis.YouTube.v3.Data.InvideoBranding body, string channelId, System.IO.Stream stream, string contentType)
        {
            return new SetMediaUpload(service, body, channelId, stream, contentType);
        }

        /// <summary>Set media upload which supports resumable upload.</summary>
        public class SetMediaUpload : Google.Apis.Upload.ResumableUpload<Google.Apis.YouTube.v3.Data.InvideoBranding>
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
            /// Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned
            /// to a user, but should not exceed 40 characters.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string QuotaUser { get; set; }

            /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
            [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UploadType { get; set; }

            /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
            [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UploadProtocol { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("channelId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ChannelId { get; private set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The CMS account that
            /// the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>Constructs a new Set media upload instance.</summary>
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
            public SetMediaUpload(Google.Apis.Services.IClientService service, Google.Apis.YouTube.v3.Data.InvideoBranding body, string channelId, System.IO.Stream stream, string contentType)
                : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "youtube/v3/watermarks/set"), "POST", stream, contentType)
            {
                ChannelId = channelId;
                Body = body;
            }
        }

        /// <summary>Allows removal of channel watermark.</summary>
        /// <param name="channelId"><c>null</c></param>
        public virtual UnsetRequest Unset(string channelId)
        {
            return new UnsetRequest(service, channelId);
        }

        /// <summary>Allows removal of channel watermark.</summary>
        public class UnsetRequest : YouTubeBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Unset request.</summary>
            public UnsetRequest(Google.Apis.Services.IClientService service, string channelId) : base(service)
            {
                ChannelId = channelId;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("channelId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ChannelId { get; private set; }

            /// <summary>
            /// *Note:* This parameter is intended exclusively for YouTube content partners. The
            /// *onBehalfOfContentOwner* parameter indicates that the request's authorization credentials identify a
            /// YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This
            /// parameter is intended for YouTube content partners that own and manage many different YouTube channels.
            /// It allows content owners to authenticate once and get access to all their video and channel data,
            /// without having to provide authentication credentials for each individual channel. The CMS account that
            /// the user authenticates with must be linked to the specified YouTube content owner.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("onBehalfOfContentOwner", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OnBehalfOfContentOwner { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "unset";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "youtube/v3/watermarks/unset";

            /// <summary>Initializes Unset parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("channelId", new Google.Apis.Discovery.Parameter
                {
                    Name = "channelId",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("onBehalfOfContentOwner", new Google.Apis.Discovery.Parameter
                {
                    Name = "onBehalfOfContentOwner",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "youtube" collection of methods.</summary>
    public class YoutubeResource
    {
        private const string Resource = "youtube";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public YoutubeResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            V3 = new V3Resource(service);
        }

        /// <summary>Gets the V3 resource.</summary>
        public virtual V3Resource V3 { get; }

        /// <summary>The "v3" collection of methods.</summary>
        public class V3Resource
        {
            private const string Resource = "v3";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public V3Resource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Updates an existing resource.</summary>
            /// <param name="body">The body of the request.</param>
            public virtual UpdateCommentThreadsRequest UpdateCommentThreads(Google.Apis.YouTube.v3.Data.CommentThread body)
            {
                return new UpdateCommentThreadsRequest(service, body);
            }

            /// <summary>Updates an existing resource.</summary>
            public class UpdateCommentThreadsRequest : YouTubeBaseServiceRequest<Google.Apis.YouTube.v3.Data.CommentThread>
            {
                /// <summary>Constructs a new UpdateCommentThreads request.</summary>
                public UpdateCommentThreadsRequest(Google.Apis.Services.IClientService service, Google.Apis.YouTube.v3.Data.CommentThread body) : base(service)
                {
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The *part* parameter specifies a comma-separated list of commentThread resource properties that the
                /// API response will include. You must at least include the snippet part in the parameter value since
                /// that part contains all of the properties that the API request can update.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("part", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> Part { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.YouTube.v3.Data.CommentThread Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "updateCommentThreads";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "youtube/v3/commentThreads";

                /// <summary>Initializes UpdateCommentThreads parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("part", new Google.Apis.Discovery.Parameter
                    {
                        Name = "part",
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
namespace Google.Apis.YouTube.v3.Data
{
    public class AbuseReport : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("abuseTypes")]
        public virtual System.Collections.Generic.IList<AbuseType> AbuseTypes { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("relatedEntities")]
        public virtual System.Collections.Generic.IList<RelatedEntity> RelatedEntities { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("subject")]
        public virtual Entity Subject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AbuseType : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Rights management policy for YouTube resources.</summary>
    public class AccessPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The value of allowed indicates whether the access to the policy is allowed or denied by default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowed")]
        public virtual System.Nullable<bool> Allowed { get; set; }

        /// <summary>A list of region codes that identify countries where the default policy do not apply.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exception")]
        public virtual System.Collections.Generic.IList<string> Exception { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An *activity* resource contains information about an action that a particular channel, or user, has taken on
    /// YouTube.The actions reported in activity feeds include rating a video, sharing a video, marking a video as a
    /// favorite, commenting on a video, uploading a video, and so forth. Each activity resource identifies the type of
    /// action, the channel associated with the action, and the resource(s) associated with the action, such as the
    /// video that was rated or uploaded.
    /// </summary>
    public class Activity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The contentDetails object contains information about the content associated with the activity. For example,
        /// if the snippet.type value is videoRated, then the contentDetails object's content identifies the rated
        /// video.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentDetails")]
        public virtual ActivityContentDetails ContentDetails { get; set; }

        /// <summary>Etag of this resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The ID that YouTube uses to uniquely identify the activity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Identifies what kind of resource this is. Value: the fixed string "youtube#activity".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The snippet object contains basic details about the activity, including the activity's type and group ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
        public virtual ActivitySnippet Snippet { get; set; }
    }

    /// <summary>
    /// Details about the content of an activity: the video that was shared, the channel that was subscribed to, etc.
    /// </summary>
    public class ActivityContentDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The bulletin object contains details about a channel bulletin post. This object is only present if the
        /// snippet.type is bulletin.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bulletin")]
        public virtual ActivityContentDetailsBulletin Bulletin { get; set; }

        /// <summary>
        /// The channelItem object contains details about a resource which was added to a channel. This property is only
        /// present if the snippet.type is channelItem.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelItem")]
        public virtual ActivityContentDetailsChannelItem ChannelItem { get; set; }

        /// <summary>
        /// The comment object contains information about a resource that received a comment. This property is only
        /// present if the snippet.type is comment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("comment")]
        public virtual ActivityContentDetailsComment Comment { get; set; }

        /// <summary>
        /// The favorite object contains information about a video that was marked as a favorite video. This property is
        /// only present if the snippet.type is favorite.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("favorite")]
        public virtual ActivityContentDetailsFavorite Favorite { get; set; }

        /// <summary>
        /// The like object contains information about a resource that received a positive (like) rating. This property
        /// is only present if the snippet.type is like.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("like")]
        public virtual ActivityContentDetailsLike Like { get; set; }

        /// <summary>
        /// The playlistItem object contains information about a new playlist item. This property is only present if the
        /// snippet.type is playlistItem.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("playlistItem")]
        public virtual ActivityContentDetailsPlaylistItem PlaylistItem { get; set; }

        /// <summary>
        /// The promotedItem object contains details about a resource which is being promoted. This property is only
        /// present if the snippet.type is promotedItem.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promotedItem")]
        public virtual ActivityContentDetailsPromotedItem PromotedItem { get; set; }

        /// <summary>
        /// The recommendation object contains information about a recommended resource. This property is only present
        /// if the snippet.type is recommendation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recommendation")]
        public virtual ActivityContentDetailsRecommendation Recommendation { get; set; }

        /// <summary>
        /// The social object contains details about a social network post. This property is only present if the
        /// snippet.type is social.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("social")]
        public virtual ActivityContentDetailsSocial Social { get; set; }

        /// <summary>
        /// The subscription object contains information about a channel that a user subscribed to. This property is
        /// only present if the snippet.type is subscription.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscription")]
        public virtual ActivityContentDetailsSubscription Subscription { get; set; }

        /// <summary>
        /// The upload object contains information about the uploaded video. This property is only present if the
        /// snippet.type is upload.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upload")]
        public virtual ActivityContentDetailsUpload Upload { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about a channel bulletin post.</summary>
    public class ActivityContentDetailsBulletin : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resourceId object contains information that identifies the resource associated with a bulletin post.
        /// @mutable youtube.activities.insert
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual ResourceId ResourceId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about a resource which was added to a channel.</summary>
    public class ActivityContentDetailsChannelItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resourceId object contains information that identifies the resource that was added to the channel.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual ResourceId ResourceId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a resource that received a comment.</summary>
    public class ActivityContentDetailsComment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resourceId object contains information that identifies the resource associated with the comment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual ResourceId ResourceId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a video that was marked as a favorite video.</summary>
    public class ActivityContentDetailsFavorite : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resourceId object contains information that identifies the resource that was marked as a favorite.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual ResourceId ResourceId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a resource that received a positive (like) rating.</summary>
    public class ActivityContentDetailsLike : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resourceId object contains information that identifies the rated resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual ResourceId ResourceId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a new playlist item.</summary>
    public class ActivityContentDetailsPlaylistItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The value that YouTube uses to uniquely identify the playlist.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("playlistId")]
        public virtual string PlaylistId { get; set; }

        /// <summary>ID of the item within the playlist.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("playlistItemId")]
        public virtual string PlaylistItemId { get; set; }

        /// <summary>
        /// The resourceId object contains information about the resource that was added to the playlist.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual ResourceId ResourceId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about a resource which is being promoted.</summary>
    public class ActivityContentDetailsPromotedItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The URL the client should fetch to request a promoted item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adTag")]
        public virtual string AdTag { get; set; }

        /// <summary>
        /// The URL the client should ping to indicate that the user clicked through on this promoted item.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clickTrackingUrl")]
        public virtual string ClickTrackingUrl { get; set; }

        /// <summary>The URL the client should ping to indicate that the user was shown this promoted item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativeViewUrl")]
        public virtual string CreativeViewUrl { get; set; }

        /// <summary>The type of call-to-action, a message to the user indicating action that can be taken.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ctaType")]
        public virtual string CtaType { get; set; }

        /// <summary>
        /// The custom call-to-action button text. If specified, it will override the default button text for the
        /// cta_type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customCtaButtonText")]
        public virtual string CustomCtaButtonText { get; set; }

        /// <summary>The text description to accompany the promoted item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("descriptionText")]
        public virtual string DescriptionText { get; set; }

        /// <summary>
        /// The URL the client should direct the user to, if the user chooses to visit the advertiser's website.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationUrl")]
        public virtual string DestinationUrl { get; set; }

        /// <summary>
        /// The list of forecasting URLs. The client should ping all of these URLs when a promoted item is not
        /// available, to indicate that a promoted item could have been shown.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forecastingUrl")]
        public virtual System.Collections.Generic.IList<string> ForecastingUrl { get; set; }

        /// <summary>
        /// The list of impression URLs. The client should ping all of these URLs to indicate that the user was shown
        /// this promoted item.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("impressionUrl")]
        public virtual System.Collections.Generic.IList<string> ImpressionUrl { get; set; }

        /// <summary>The ID that YouTube uses to uniquely identify the promoted video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoId")]
        public virtual string VideoId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information that identifies the recommended resource.</summary>
    public class ActivityContentDetailsRecommendation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The reason that the resource is recommended to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The resourceId object contains information that identifies the recommended resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual ResourceId ResourceId { get; set; }

        /// <summary>
        /// The seedResourceId object contains information about the resource that caused the recommendation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seedResourceId")]
        public virtual ResourceId SeedResourceId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about a social network post.</summary>
    public class ActivityContentDetailsSocial : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The author of the social network post.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("author")]
        public virtual string Author { get; set; }

        /// <summary>An image of the post's author.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUrl")]
        public virtual string ImageUrl { get; set; }

        /// <summary>The URL of the social network post.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referenceUrl")]
        public virtual string ReferenceUrl { get; set; }

        /// <summary>
        /// The resourceId object encapsulates information that identifies the resource associated with a social network
        /// post.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual ResourceId ResourceId { get; set; }

        /// <summary>The name of the social network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a channel that a user subscribed to.</summary>
    public class ActivityContentDetailsSubscription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resourceId object contains information that identifies the resource that the user subscribed to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual ResourceId ResourceId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the uploaded video.</summary>
    public class ActivityContentDetailsUpload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID that YouTube uses to uniquely identify the uploaded video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoId")]
        public virtual string VideoId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ActivityListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Serialized EventId of the request which produced this response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Activity> Items { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "youtube#activityListResponse".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The token that can be used as the value of the pageToken parameter to retrieve the next page in the result
        /// set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>General pagination information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageInfo")]
        public virtual PageInfo PageInfo { get; set; }

        /// <summary>
        /// The token that can be used as the value of the pageToken parameter to retrieve the previous page in the
        /// result set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prevPageToken")]
        public virtual string PrevPageToken { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("tokenPagination")]
        public virtual TokenPagination TokenPagination { get; set; }

        /// <summary>The visitorId identifies the visitor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visitorId")]
        public virtual string VisitorId { get; set; }
    }

    /// <summary>
    /// Basic details about an activity, including title, description, thumbnails, activity type and group. Next ID: 12
    /// </summary>
    public class ActivitySnippet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID that YouTube uses to uniquely identify the channel associated with the activity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelId")]
        public virtual string ChannelId { get; set; }

        /// <summary>Channel title for the channel responsible for this activity</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelTitle")]
        public virtual string ChannelTitle { get; set; }

        /// <summary>
        /// The description of the resource primarily associated with the activity. @mutable youtube.activities.insert
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// The group ID associated with the activity. A group ID identifies user events that are associated with the
        /// same user and resource. For example, if a user rates a video and marks the same video as a favorite, the
        /// entries for those events would have the same group ID in the user's activity feed. In your user interface,
        /// you can avoid repetition by grouping events with the same groupId value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupId")]
        public virtual string GroupId { get; set; }

        /// <summary>The date and time that the video was uploaded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishedAt")]
        public virtual string PublishedAtRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="PublishedAtRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> PublishedAt
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(PublishedAtRaw);
            set => PublishedAtRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// A map of thumbnail images associated with the resource that is primarily associated with the activity. For
        /// each object in the map, the key is the name of the thumbnail image, and the value is an object that contains
        /// other information about the thumbnail.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnails")]
        public virtual ThumbnailDetails Thumbnails { get; set; }

        /// <summary>The title of the resource primarily associated with the activity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The type of activity that the resource describes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A *caption* resource represents a YouTube caption track. A caption track is associated with exactly one YouTube
    /// video.
    /// </summary>
    public class Caption : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The ID that YouTube uses to uniquely identify the caption track.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Identifies what kind of resource this is. Value: the fixed string "youtube#caption".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The snippet object contains basic details about the caption.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
        public virtual CaptionSnippet Snippet { get; set; }
    }

    public class CaptionListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Serialized EventId of the request which produced this response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        /// <summary>A list of captions that match the request criteria.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Caption> Items { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "youtube#captionListResponse".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The visitorId identifies the visitor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visitorId")]
        public virtual string VisitorId { get; set; }
    }

    /// <summary>Basic details about a caption track, such as its language and name.</summary>
    public class CaptionSnippet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of audio track associated with the caption track.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audioTrackType")]
        public virtual string AudioTrackType { get; set; }

        /// <summary>
        /// The reason that YouTube failed to process the caption track. This property is only present if the state
        /// property's value is failed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureReason")]
        public virtual string FailureReason { get; set; }

        /// <summary>
        /// Indicates whether YouTube synchronized the caption track to the audio track in the video. The value will be
        /// true if a sync was explicitly requested when the caption track was uploaded. For example, when calling the
        /// captions.insert or captions.update methods, you can set the sync parameter to true to instruct YouTube to
        /// sync the uploaded track to the video. If the value is false, YouTube uses the time codes in the uploaded
        /// caption track to determine when to display captions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isAutoSynced")]
        public virtual System.Nullable<bool> IsAutoSynced { get; set; }

        /// <summary>
        /// Indicates whether the track contains closed captions for the deaf and hard of hearing. The default value is
        /// false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isCC")]
        public virtual System.Nullable<bool> IsCC { get; set; }

        /// <summary>
        /// Indicates whether the caption track is a draft. If the value is true, then the track is not publicly
        /// visible. The default value is false. @mutable youtube.captions.insert youtube.captions.update
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isDraft")]
        public virtual System.Nullable<bool> IsDraft { get; set; }

        /// <summary>
        /// Indicates whether caption track is formatted for "easy reader," meaning it is at a third-grade level for
        /// language learners. The default value is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isEasyReader")]
        public virtual System.Nullable<bool> IsEasyReader { get; set; }

        /// <summary>
        /// Indicates whether the caption track uses large text for the vision-impaired. The default value is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isLarge")]
        public virtual System.Nullable<bool> IsLarge { get; set; }

        /// <summary>The language of the caption track. The property value is a BCP-47 language tag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("language")]
        public virtual string Language { get; set; }

        /// <summary>The date and time when the caption track was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdated")]
        public virtual string LastUpdatedRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="LastUpdatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> LastUpdated
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(LastUpdatedRaw);
            set => LastUpdatedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// The name of the caption track. The name is intended to be visible to the user as an option during playback.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The caption track's status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The caption track's type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackKind")]
        public virtual string TrackKind { get; set; }

        /// <summary>
        /// The ID that YouTube uses to uniquely identify the video associated with the caption track. @mutable
        /// youtube.captions.insert
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoId")]
        public virtual string VideoId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Brief description of the live stream cdn settings.</summary>
    public class CdnSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The format of the video stream that you are sending to Youtube. </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("format")]
        public virtual string Format { get; set; }

        /// <summary>The frame rate of the inbound video data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frameRate")]
        public virtual string FrameRate { get; set; }

        /// <summary>
        /// The ingestionInfo object contains information that YouTube provides that you need to transmit your RTMP or
        /// HTTP stream to YouTube.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingestionInfo")]
        public virtual IngestionInfo IngestionInfo { get; set; }

        /// <summary> The method or protocol used to transmit the video stream.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingestionType")]
        public virtual string IngestionType { get; set; }

        /// <summary>The resolution of the inbound video data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolution")]
        public virtual string Resolution { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A *channel* resource contains information about a YouTube channel.</summary>
    public class Channel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The auditionDetails object encapsulates channel data that is relevant for YouTube Partners during the
        /// audition process.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditDetails")]
        public virtual ChannelAuditDetails AuditDetails { get; set; }

        /// <summary>The brandingSettings object encapsulates information about the branding of the channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("brandingSettings")]
        public virtual ChannelBrandingSettings BrandingSettings { get; set; }

        /// <summary>The contentDetails object encapsulates information about the channel's content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentDetails")]
        public virtual ChannelContentDetails ContentDetails { get; set; }

        /// <summary>
        /// The contentOwnerDetails object encapsulates channel data that is relevant for YouTube Partners linked with
        /// the channel.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentOwnerDetails")]
        public virtual ChannelContentOwnerDetails ContentOwnerDetails { get; set; }

        /// <summary>
        /// The conversionPings object encapsulates information about conversion pings that need to be respected by the
        /// channel.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionPings")]
        public virtual ChannelConversionPings ConversionPings { get; set; }

        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The ID that YouTube uses to uniquely identify the channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Identifies what kind of resource this is. Value: the fixed string "youtube#channel".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Localizations for different languages</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizations")]
        public virtual System.Collections.Generic.IDictionary<string, ChannelLocalization> Localizations { get; set; }

        /// <summary>
        /// The snippet object contains basic details about the channel, such as its title, description, and thumbnail
        /// images.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
        public virtual ChannelSnippet Snippet { get; set; }

        /// <summary>The statistics object encapsulates statistics for the channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statistics")]
        public virtual ChannelStatistics Statistics { get; set; }

        /// <summary>The status object encapsulates information about the privacy status of the channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual ChannelStatus Status { get; set; }

        /// <summary>
        /// The topicDetails object encapsulates information about Freebase topics associated with the channel.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topicDetails")]
        public virtual ChannelTopicDetails TopicDetails { get; set; }
    }

    /// <summary>
    /// The auditDetails object encapsulates channel data that is relevant for YouTube Partners during the audit
    /// process.
    /// </summary>
    public class ChannelAuditDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether or not the channel respects the community guidelines.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("communityGuidelinesGoodStanding")]
        public virtual System.Nullable<bool> CommunityGuidelinesGoodStanding { get; set; }

        /// <summary>Whether or not the channel has any unresolved claims.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentIdClaimsGoodStanding")]
        public virtual System.Nullable<bool> ContentIdClaimsGoodStanding { get; set; }

        /// <summary>Whether or not the channel has any copyright strikes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("copyrightStrikesGoodStanding")]
        public virtual System.Nullable<bool> CopyrightStrikesGoodStanding { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A channel banner returned as the response to a channel_banner.insert call.</summary>
    public class ChannelBannerResource : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "youtube#channelBannerResource".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The URL of this banner image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }
    }

    /// <summary>Branding properties of a YouTube channel.</summary>
    public class ChannelBrandingSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Branding properties for the channel view.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channel")]
        public virtual ChannelSettings Channel { get; set; }

        /// <summary>Additional experimental branding properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hints")]
        public virtual System.Collections.Generic.IList<PropertyValue> Hints { get; set; }

        /// <summary>Branding properties for branding images.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual ImageSettings Image { get; set; }

        /// <summary>Branding properties for the watch page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("watch")]
        public virtual WatchSettings Watch { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about the content of a channel.</summary>
    public class ChannelContentDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("relatedPlaylists")]
        public virtual RelatedPlaylistsData RelatedPlaylists { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        public class RelatedPlaylistsData
        {
            /// <summary>
            /// The ID of the playlist that contains the channel"s favorite videos. Use the playlistItems.insert and
            /// playlistItems.delete to add or remove items from that list.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("favorites")]
            public virtual string Favorites { get; set; }

            /// <summary>
            /// The ID of the playlist that contains the channel"s liked videos. Use the playlistItems.insert and
            /// playlistItems.delete to add or remove items from that list.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("likes")]
            public virtual string Likes { get; set; }

            /// <summary>
            /// The ID of the playlist that contains the channel"s uploaded videos. Use the videos.insert method to
            /// upload new videos and the videos.delete method to delete previously uploaded videos.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("uploads")]
            public virtual string Uploads { get; set; }

            /// <summary>
            /// The ID of the playlist that contains the channel"s watch history. Use the playlistItems.insert and
            /// playlistItems.delete to add or remove items from that list.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("watchHistory")]
            public virtual string WatchHistory { get; set; }

            /// <summary>
            /// The ID of the playlist that contains the channel"s watch later playlist. Use the playlistItems.insert
            /// and playlistItems.delete to add or remove items from that list.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("watchLater")]
            public virtual string WatchLater { get; set; }
        }
    }

    /// <summary>
    /// The contentOwnerDetails object encapsulates channel data that is relevant for YouTube Partners linked with the
    /// channel.
    /// </summary>
    public class ChannelContentOwnerDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the content owner linked to the channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentOwner")]
        public virtual string ContentOwner { get; set; }

        /// <summary>The date and time when the channel was linked to the content owner.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeLinked")]
        public virtual string TimeLinkedRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="TimeLinkedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> TimeLinked
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(TimeLinkedRaw);
            set => TimeLinkedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Pings that the app shall fire (authenticated by biscotti cookie). Each ping has a context, in which the app must
    /// fire the ping, and a url identifying the ping.
    /// </summary>
    public class ChannelConversionPing : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Defines the context of the ping.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("context")]
        public virtual string Context { get; set; }

        /// <summary>
        /// The url (without the schema) that the player shall send the ping to. It's at caller's descretion to decide
        /// which schema to use (http vs https) Example of a returned url: //googleads.g.doubleclick.net/pagead/
        /// viewthroughconversion/962985656/?data=path%3DtHe_path%3Btype%3D
        /// cview%3Butuid%3DGISQtTNGYqaYl4sKxoVvKA&amp;amp;labe=default The caller must append biscotti authentication
        /// (ms param in case of mobile, for example) to this ping.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionUrl")]
        public virtual string ConversionUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The conversionPings object encapsulates information about conversion pings that need to be respected by the
    /// channel.
    /// </summary>
    public class ChannelConversionPings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Pings that the app shall fire (authenticated by biscotti cookie). Each ping has a context, in which the app
        /// must fire the ping, and a url identifying the ping.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pings")]
        public virtual System.Collections.Generic.IList<ChannelConversionPing> Pings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ChannelListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Serialized EventId of the request which produced this response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Channel> Items { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "youtube#channelListResponse".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The token that can be used as the value of the pageToken parameter to retrieve the next page in the result
        /// set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>General pagination information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageInfo")]
        public virtual PageInfo PageInfo { get; set; }

        /// <summary>
        /// The token that can be used as the value of the pageToken parameter to retrieve the previous page in the
        /// result set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prevPageToken")]
        public virtual string PrevPageToken { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("tokenPagination")]
        public virtual TokenPagination TokenPagination { get; set; }

        /// <summary>The visitorId identifies the visitor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visitorId")]
        public virtual string VisitorId { get; set; }
    }

    /// <summary>Channel localization setting</summary>
    public class ChannelLocalization : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The localized strings for channel's description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The localized strings for channel's title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ChannelProfileDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The YouTube channel ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelId")]
        public virtual string ChannelId { get; set; }

        /// <summary>The channel's URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelUrl")]
        public virtual string ChannelUrl { get; set; }

        /// <summary>The channel's display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The channels's avatar URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profileImageUrl")]
        public virtual string ProfileImageUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ChannelSection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The contentDetails object contains details about the channel section content, such as a list of playlists or
        /// channels featured in the section.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentDetails")]
        public virtual ChannelSectionContentDetails ContentDetails { get; set; }

        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The ID that YouTube uses to uniquely identify the channel section.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "youtube#channelSection".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Localizations for different languages</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizations")]
        public virtual System.Collections.Generic.IDictionary<string, ChannelSectionLocalization> Localizations { get; set; }

        /// <summary>
        /// The snippet object contains basic details about the channel section, such as its type, style and title.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
        public virtual ChannelSectionSnippet Snippet { get; set; }

        /// <summary>The targeting object contains basic targeting settings about the channel section.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targeting")]
        public virtual ChannelSectionTargeting Targeting { get; set; }
    }

    /// <summary>Details about a channelsection, including playlists and channels.</summary>
    public class ChannelSectionContentDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The channel ids for type multiple_channels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channels")]
        public virtual System.Collections.Generic.IList<string> Channels { get; set; }

        /// <summary>
        /// The playlist ids for type single_playlist and multiple_playlists. For singlePlaylist, only one playlistId is
        /// allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("playlists")]
        public virtual System.Collections.Generic.IList<string> Playlists { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ChannelSectionListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Serialized EventId of the request which produced this response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        /// <summary>A list of ChannelSections that match the request criteria.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<ChannelSection> Items { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "youtube#channelSectionListResponse".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The visitorId identifies the visitor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visitorId")]
        public virtual string VisitorId { get; set; }
    }

    /// <summary>ChannelSection localization setting</summary>
    public class ChannelSectionLocalization : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The localized strings for channel section's title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Basic details about a channel section, including title, style and position.</summary>
    public class ChannelSectionSnippet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The ID that YouTube uses to uniquely identify the channel that published the channel section.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelId")]
        public virtual string ChannelId { get; set; }

        /// <summary>The language of the channel section's default title and description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultLanguage")]
        public virtual string DefaultLanguage { get; set; }

        /// <summary>Localized title, read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localized")]
        public virtual ChannelSectionLocalization Localized { get; set; }

        /// <summary>The position of the channel section in the channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("position")]
        public virtual System.Nullable<long> Position { get; set; }

        /// <summary>The style of the channel section.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("style")]
        public virtual string Style { get; set; }

        /// <summary>The channel section's title for multiple_playlists and multiple_channels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The type of the channel section.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ChannelSection targeting setting.</summary>
    public class ChannelSectionTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The country the channel section is targeting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countries")]
        public virtual System.Collections.Generic.IList<string> Countries { get; set; }

        /// <summary>The language the channel section is targeting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languages")]
        public virtual System.Collections.Generic.IList<string> Languages { get; set; }

        /// <summary>The region the channel section is targeting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regions")]
        public virtual System.Collections.Generic.IList<string> Regions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Branding properties for the channel view.</summary>
    public class ChannelSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The country of the channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("country")]
        public virtual string Country { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("defaultLanguage")]
        public virtual string DefaultLanguage { get; set; }

        /// <summary>Which content tab users should see when viewing the channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultTab")]
        public virtual string DefaultTab { get; set; }

        /// <summary>Specifies the channel description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Title for the featured channels tab.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("featuredChannelsTitle")]
        public virtual string FeaturedChannelsTitle { get; set; }

        /// <summary>The list of featured channels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("featuredChannelsUrls")]
        public virtual System.Collections.Generic.IList<string> FeaturedChannelsUrls { get; set; }

        /// <summary>Lists keywords associated with the channel, comma-separated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keywords")]
        public virtual string Keywords { get; set; }

        /// <summary>
        /// Whether user-submitted comments left on the channel page need to be approved by the channel owner to be
        /// publicly visible.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moderateComments")]
        public virtual System.Nullable<bool> ModerateComments { get; set; }

        /// <summary>A prominent color that can be rendered on this channel page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profileColor")]
        public virtual string ProfileColor { get; set; }

        /// <summary>Whether the tab to browse the videos should be displayed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("showBrowseView")]
        public virtual System.Nullable<bool> ShowBrowseView { get; set; }

        /// <summary>Whether related channels should be proposed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("showRelatedChannels")]
        public virtual System.Nullable<bool> ShowRelatedChannels { get; set; }

        /// <summary>Specifies the channel title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ID for a Google Analytics account to track and measure traffic to the channels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackingAnalyticsAccountId")]
        public virtual string TrackingAnalyticsAccountId { get; set; }

        /// <summary>The trailer of the channel, for users that are not subscribers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unsubscribedTrailer")]
        public virtual string UnsubscribedTrailer { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Basic details about a channel, including title, description and thumbnails.</summary>
    public class ChannelSnippet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The country of the channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("country")]
        public virtual string Country { get; set; }

        /// <summary>The custom url of the channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customUrl")]
        public virtual string CustomUrl { get; set; }

        /// <summary>The language of the channel's default title and description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultLanguage")]
        public virtual string DefaultLanguage { get; set; }

        /// <summary>The description of the channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Localized title and description, read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localized")]
        public virtual ChannelLocalization Localized { get; set; }

        /// <summary>The date and time that the channel was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishedAt")]
        public virtual string PublishedAtRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="PublishedAtRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> PublishedAt
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(PublishedAtRaw);
            set => PublishedAtRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// A map of thumbnail images associated with the channel. For each object in the map, the key is the name of
        /// the thumbnail image, and the value is an object that contains other information about the thumbnail. When
        /// displaying thumbnails in your application, make sure that your code uses the image URLs exactly as they are
        /// returned in API responses. For example, your application should not use the http domain instead of the https
        /// domain in a URL returned in an API response. Beginning in July 2018, channel thumbnail URLs will only be
        /// available in the https domain, which is how the URLs appear in API responses. After that time, you might see
        /// broken images in your application if it tries to load YouTube images from the http domain. Thumbnail images
        /// might be empty for newly created channels and might take up to one day to populate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnails")]
        public virtual ThumbnailDetails Thumbnails { get; set; }

        /// <summary>The channel's title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Statistics about a channel: number of subscribers, number of videos in the channel, etc.</summary>
    public class ChannelStatistics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of comments for the channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commentCount")]
        public virtual System.Nullable<ulong> CommentCount { get; set; }

        /// <summary>Whether or not the number of subscribers is shown for this user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hiddenSubscriberCount")]
        public virtual System.Nullable<bool> HiddenSubscriberCount { get; set; }

        /// <summary>The number of subscribers that the channel has.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriberCount")]
        public virtual System.Nullable<ulong> SubscriberCount { get; set; }

        /// <summary>The number of videos uploaded to the channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoCount")]
        public virtual System.Nullable<ulong> VideoCount { get; set; }

        /// <summary>The number of times the channel has been viewed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewCount")]
        public virtual System.Nullable<ulong> ViewCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for the status part of a channel.</summary>
    public class ChannelStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If true, then the user is linked to either a YouTube username or G+ account. Otherwise, the user doesn't
        /// have a public YouTube identity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isLinked")]
        public virtual System.Nullable<bool> IsLinked { get; set; }

        /// <summary>
        /// The long uploads status of this channel. See https://support.google.com/youtube/answer/71673 for more
        /// information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longUploadsStatus")]
        public virtual string LongUploadsStatus { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("madeForKids")]
        public virtual System.Nullable<bool> MadeForKids { get; set; }

        /// <summary>Privacy status of the channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privacyStatus")]
        public virtual string PrivacyStatus { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("selfDeclaredMadeForKids")]
        public virtual System.Nullable<bool> SelfDeclaredMadeForKids { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information specific to a store on a merchandising platform linked to a YouTube channel.</summary>
    public class ChannelToStoreLinkDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the store.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storeName")]
        public virtual string StoreName { get; set; }

        /// <summary>Landing page of the store.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storeUrl")]
        public virtual string StoreUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Freebase topic information related to the channel.</summary>
    public class ChannelTopicDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of Wikipedia URLs that describe the channel's content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topicCategories")]
        public virtual System.Collections.Generic.IList<string> TopicCategories { get; set; }

        /// <summary>
        /// A list of Freebase topic IDs associated with the channel. You can retrieve information about each topic
        /// using the Freebase Topic API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topicIds")]
        public virtual System.Collections.Generic.IList<string> TopicIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A *comment* represents a single YouTube comment.</summary>
    public class Comment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The ID that YouTube uses to uniquely identify the comment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Identifies what kind of resource this is. Value: the fixed string "youtube#comment".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The snippet object contains basic details about the comment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
        public virtual CommentSnippet Snippet { get; set; }
    }

    public class CommentListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Serialized EventId of the request which produced this response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        /// <summary>A list of comments that match the request criteria.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Comment> Items { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "youtube#commentListResponse".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The token that can be used as the value of the pageToken parameter to retrieve the next page in the result
        /// set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>General pagination information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageInfo")]
        public virtual PageInfo PageInfo { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("tokenPagination")]
        public virtual TokenPagination TokenPagination { get; set; }

        /// <summary>The visitorId identifies the visitor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visitorId")]
        public virtual string VisitorId { get; set; }
    }

    /// <summary>Basic details about a comment, such as its author and text.</summary>
    public class CommentSnippet : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("authorChannelId")]
        public virtual CommentSnippetAuthorChannelId AuthorChannelId { get; set; }

        /// <summary>Link to the author's YouTube channel, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorChannelUrl")]
        public virtual string AuthorChannelUrl { get; set; }

        /// <summary>The name of the user who posted the comment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorDisplayName")]
        public virtual string AuthorDisplayName { get; set; }

        /// <summary>The URL for the avatar of the user who posted the comment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorProfileImageUrl")]
        public virtual string AuthorProfileImageUrl { get; set; }

        /// <summary>Whether the current viewer can rate this comment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canRate")]
        public virtual System.Nullable<bool> CanRate { get; set; }

        /// <summary>
        /// The id of the corresponding YouTube channel. In case of a channel comment this is the channel the comment
        /// refers to. In case of a video comment it's the video's channel.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelId")]
        public virtual string ChannelId { get; set; }

        /// <summary>The total number of likes this comment has received.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("likeCount")]
        public virtual System.Nullable<long> LikeCount { get; set; }

        /// <summary>
        /// The comment's moderation status. Will not be set if the comments were requested through the id filter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moderationStatus")]
        public virtual string ModerationStatus { get; set; }

        /// <summary>The unique id of the parent comment, only set for replies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentId")]
        public virtual string ParentId { get; set; }

        /// <summary>The date and time when the comment was originally published.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishedAt")]
        public virtual string PublishedAtRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="PublishedAtRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> PublishedAt
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(PublishedAtRaw);
            set => PublishedAtRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// The comment's text. The format is either plain text or HTML dependent on what has been requested. Even the
        /// plain text representation may differ from the text originally posted in that it may replace video links with
        /// video titles etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textDisplay")]
        public virtual string TextDisplay { get; set; }

        /// <summary>
        /// The comment's original raw text as initially posted or last updated. The original text will only be returned
        /// if it is accessible to the viewer, which is only guaranteed if the viewer is the comment's author.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textOriginal")]
        public virtual string TextOriginal { get; set; }

        /// <summary>The date and time when the comment was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updatedAt")]
        public virtual string UpdatedAtRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="UpdatedAtRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> UpdatedAt
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(UpdatedAtRaw);
            set => UpdatedAtRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>The ID of the video the comment refers to, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoId")]
        public virtual string VideoId { get; set; }

        /// <summary>
        /// The rating the viewer has given to this comment. For the time being this will never return RATE_TYPE_DISLIKE
        /// and instead return RATE_TYPE_NONE. This may change in the future.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewerRating")]
        public virtual string ViewerRating { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The id of the author's YouTube channel, if any.</summary>
    public class CommentSnippetAuthorChannelId : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A *comment thread* represents information that applies to a top level comment and all its replies. It can also
    /// include the top level comment itself and some of the replies.
    /// </summary>
    public class CommentThread : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The ID that YouTube uses to uniquely identify the comment thread.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "youtube#commentThread".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The replies object contains a limited number of replies (if any) to the top level comment found in the
        /// snippet.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replies")]
        public virtual CommentThreadReplies Replies { get; set; }

        /// <summary>
        /// The snippet object contains basic details about the comment thread and also the top level comment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
        public virtual CommentThreadSnippet Snippet { get; set; }
    }

    public class CommentThreadListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Serialized EventId of the request which produced this response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        /// <summary>A list of comment threads that match the request criteria.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<CommentThread> Items { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "youtube#commentThreadListResponse".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The token that can be used as the value of the pageToken parameter to retrieve the next page in the result
        /// set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>General pagination information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageInfo")]
        public virtual PageInfo PageInfo { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("tokenPagination")]
        public virtual TokenPagination TokenPagination { get; set; }

        /// <summary>The visitorId identifies the visitor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visitorId")]
        public virtual string VisitorId { get; set; }
    }

    /// <summary>Comments written in (direct or indirect) reply to the top level comment.</summary>
    public class CommentThreadReplies : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A limited number of replies. Unless the number of replies returned equals total_reply_count in the snippet
        /// the returned replies are only a subset of the total number of replies.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("comments")]
        public virtual System.Collections.Generic.IList<Comment> Comments { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Basic details about a comment thread.</summary>
    public class CommentThreadSnippet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether the current viewer of the thread can reply to it. This is viewer specific - other viewers may see a
        /// different value for this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canReply")]
        public virtual System.Nullable<bool> CanReply { get; set; }

        /// <summary>
        /// The YouTube channel the comments in the thread refer to or the channel with the video the comments refer to.
        /// If video_id isn't set the comments refer to the channel itself.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelId")]
        public virtual string ChannelId { get; set; }

        /// <summary>Whether the thread (and therefore all its comments) is visible to all YouTube users.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isPublic")]
        public virtual System.Nullable<bool> IsPublic { get; set; }

        /// <summary>The top level comment of this thread.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topLevelComment")]
        public virtual Comment TopLevelComment { get; set; }

        /// <summary>The total number of replies (not including the top level comment).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalReplyCount")]
        public virtual System.Nullable<long> TotalReplyCount { get; set; }

        /// <summary>
        /// The ID of the video the comments refer to, if any. No video_id implies a channel discussion comment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoId")]
        public virtual string VideoId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Ratings schemes. The country-specific ratings are mostly for movies and shows. LINT.IfChange</summary>
    public class ContentRating : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The video's Australian Classification Board (ACB) or Australian Communications and Media Authority (ACMA)
        /// rating. ACMA ratings are used to classify children's television programming.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acbRating")]
        public virtual string AcbRating { get; set; }

        /// <summary>The video's rating from Italy's Autorità per le Garanzie nelle Comunicazioni (AGCOM).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agcomRating")]
        public virtual string AgcomRating { get; set; }

        /// <summary>The video's Anatel (Asociación Nacional de Televisión) rating for Chilean television.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("anatelRating")]
        public virtual string AnatelRating { get; set; }

        /// <summary>The video's British Board of Film Classification (BBFC) rating.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bbfcRating")]
        public virtual string BbfcRating { get; set; }

        /// <summary>The video's rating from Thailand's Board of Film and Video Censors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bfvcRating")]
        public virtual string BfvcRating { get; set; }

        /// <summary>
        /// The video's rating from the Austrian Board of Media Classification (Bundesministerium für Unterricht, Kunst
        /// und Kultur).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bmukkRating")]
        public virtual string BmukkRating { get; set; }

        /// <summary>
        /// Rating system for Canadian TV - Canadian TV Classification System The video's rating from the Canadian
        /// Radio-Television and Telecommunications Commission (CRTC) for Canadian English-language broadcasts. For more
        /// information, see the Canadian Broadcast Standards Council website.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("catvRating")]
        public virtual string CatvRating { get; set; }

        /// <summary>
        /// The video's rating from the Canadian Radio-Television and Telecommunications Commission (CRTC) for Canadian
        /// French-language broadcasts. For more information, see the Canadian Broadcast Standards Council website.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("catvfrRating")]
        public virtual string CatvfrRating { get; set; }

        /// <summary>The video's Central Board of Film Certification (CBFC - India) rating.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cbfcRating")]
        public virtual string CbfcRating { get; set; }

        /// <summary>The video's Consejo de Calificación Cinematográfica (Chile) rating.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cccRating")]
        public virtual string CccRating { get; set; }

        /// <summary>The video's rating from Portugal's Comissão de Classificação de Espect´culos.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cceRating")]
        public virtual string CceRating { get; set; }

        /// <summary>The video's rating in Switzerland.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chfilmRating")]
        public virtual string ChfilmRating { get; set; }

        /// <summary>The video's Canadian Home Video Rating System (CHVRS) rating.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chvrsRating")]
        public virtual string ChvrsRating { get; set; }

        /// <summary>The video's rating from the Commission de Contrôle des Films (Belgium).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cicfRating")]
        public virtual string CicfRating { get; set; }

        /// <summary>The video's rating from Romania's CONSILIUL NATIONAL AL AUDIOVIZUALULUI (CNA).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cnaRating")]
        public virtual string CnaRating { get; set; }

        /// <summary>Rating system in France - Commission de classification cinematographique</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cncRating")]
        public virtual string CncRating { get; set; }

        /// <summary>
        /// The video's rating from France's Conseil supérieur de l’audiovisuel, which rates broadcast content.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("csaRating")]
        public virtual string CsaRating { get; set; }

        /// <summary>
        /// The video's rating from Luxembourg's Commission de surveillance de la classification des films (CSCF).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cscfRating")]
        public virtual string CscfRating { get; set; }

        /// <summary>The video's rating in the Czech Republic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("czfilmRating")]
        public virtual string CzfilmRating { get; set; }

        /// <summary>
        /// The video's Departamento de Justiça, Classificação, Qualificação e Títulos (DJCQT - Brazil) rating.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("djctqRating")]
        public virtual string DjctqRating { get; set; }

        /// <summary>Reasons that explain why the video received its DJCQT (Brazil) rating.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("djctqRatingReasons")]
        public virtual System.Collections.Generic.IList<string> DjctqRatingReasons { get; set; }

        /// <summary>
        /// Rating system in Turkey - Evaluation and Classification Board of the Ministry of Culture and Tourism
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ecbmctRating")]
        public virtual string EcbmctRating { get; set; }

        /// <summary>The video's rating in Estonia.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eefilmRating")]
        public virtual string EefilmRating { get; set; }

        /// <summary>The video's rating in Egypt.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("egfilmRating")]
        public virtual string EgfilmRating { get; set; }

        /// <summary>The video's Eirin (映倫) rating. Eirin is the Japanese rating system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eirinRating")]
        public virtual string EirinRating { get; set; }

        /// <summary>The video's rating from Malaysia's Film Censorship Board.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fcbmRating")]
        public virtual string FcbmRating { get; set; }

        /// <summary>
        /// The video's rating from Hong Kong's Office for Film, Newspaper and Article Administration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fcoRating")]
        public virtual string FcoRating { get; set; }

        /// <summary>
        /// This property has been deprecated. Use the contentDetails.contentRating.cncRating instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fmocRating")]
        public virtual string FmocRating { get; set; }

        /// <summary>The video's rating from South Africa's Film and Publication Board.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fpbRating")]
        public virtual string FpbRating { get; set; }

        /// <summary>Reasons that explain why the video received its FPB (South Africa) rating.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fpbRatingReasons")]
        public virtual System.Collections.Generic.IList<string> FpbRatingReasons { get; set; }

        /// <summary>The video's Freiwillige Selbstkontrolle der Filmwirtschaft (FSK - Germany) rating.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fskRating")]
        public virtual string FskRating { get; set; }

        /// <summary>The video's rating in Greece.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("grfilmRating")]
        public virtual string GrfilmRating { get; set; }

        /// <summary>
        /// The video's Instituto de la Cinematografía y de las Artes Audiovisuales (ICAA - Spain) rating.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("icaaRating")]
        public virtual string IcaaRating { get; set; }

        /// <summary>
        /// The video's Irish Film Classification Office (IFCO - Ireland) rating. See the IFCO website for more
        /// information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ifcoRating")]
        public virtual string IfcoRating { get; set; }

        /// <summary>The video's rating in Israel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ilfilmRating")]
        public virtual string IlfilmRating { get; set; }

        /// <summary>The video's INCAA (Instituto Nacional de Cine y Artes Audiovisuales - Argentina) rating.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("incaaRating")]
        public virtual string IncaaRating { get; set; }

        /// <summary>The video's rating from the Kenya Film Classification Board.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kfcbRating")]
        public virtual string KfcbRating { get; set; }

        /// <summary>
        /// The video's NICAM/Kijkwijzer rating from the Nederlands Instituut voor de Classificatie van Audiovisuele
        /// Media (Netherlands).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kijkwijzerRating")]
        public virtual string KijkwijzerRating { get; set; }

        /// <summary>
        /// The video's Korea Media Rating Board (영상물등급위원회) rating. The KMRB rates videos in South Korea.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmrbRating")]
        public virtual string KmrbRating { get; set; }

        /// <summary>The video's rating from Indonesia's Lembaga Sensor Film.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lsfRating")]
        public virtual string LsfRating { get; set; }

        /// <summary>The video's rating from Malta's Film Age-Classification Board.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mccaaRating")]
        public virtual string MccaaRating { get; set; }

        /// <summary>
        /// The video's rating from the Danish Film Institute's (Det Danske Filminstitut) Media Council for Children and
        /// Young People.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mccypRating")]
        public virtual string MccypRating { get; set; }

        /// <summary>The video's rating system for Vietnam - MCST</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mcstRating")]
        public virtual string McstRating { get; set; }

        /// <summary>
        /// The video's rating from Singapore's Media Development Authority (MDA) and, specifically, it's Board of Film
        /// Censors (BFC).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mdaRating")]
        public virtual string MdaRating { get; set; }

        /// <summary>The video's rating from Medietilsynet, the Norwegian Media Authority.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("medietilsynetRating")]
        public virtual string MedietilsynetRating { get; set; }

        /// <summary>
        /// The video's rating from Finland's Kansallinen Audiovisuaalinen Instituutti (National Audiovisual Institute).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mekuRating")]
        public virtual string MekuRating { get; set; }

        /// <summary>
        /// The rating system for MENA countries, a clone of MPAA. It is needed to prevent titles go live w/o additional
        /// QC check, since some of them can be inappropriate for the countries at all. See b/33408548 for more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("menaMpaaRating")]
        public virtual string MenaMpaaRating { get; set; }

        /// <summary>
        /// The video's rating from the Ministero dei Beni e delle Attività Culturali e del Turismo (Italy).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mibacRating")]
        public virtual string MibacRating { get; set; }

        /// <summary>The video's Ministerio de Cultura (Colombia) rating.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mocRating")]
        public virtual string MocRating { get; set; }

        /// <summary>The video's rating from Taiwan's Ministry of Culture (文化部).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moctwRating")]
        public virtual string MoctwRating { get; set; }

        /// <summary>The video's Motion Picture Association of America (MPAA) rating.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mpaaRating")]
        public virtual string MpaaRating { get; set; }

        /// <summary>
        /// The rating system for trailer, DVD, and Ad in the US. See
        /// http://movielabs.com/md/ratings/v2.3/html/US_MPAAT_Ratings.html.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mpaatRating")]
        public virtual string MpaatRating { get; set; }

        /// <summary>
        /// The video's rating from the Movie and Television Review and Classification Board (Philippines).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mtrcbRating")]
        public virtual string MtrcbRating { get; set; }

        /// <summary>The video's rating from the Maldives National Bureau of Classification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nbcRating")]
        public virtual string NbcRating { get; set; }

        /// <summary>The video's rating in Poland.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nbcplRating")]
        public virtual string NbcplRating { get; set; }

        /// <summary>The video's rating from the Bulgarian National Film Center.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nfrcRating")]
        public virtual string NfrcRating { get; set; }

        /// <summary>The video's rating from Nigeria's National Film and Video Censors Board.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nfvcbRating")]
        public virtual string NfvcbRating { get; set; }

        /// <summary>The video's rating from the Nacionãlais Kino centrs (National Film Centre of Latvia).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nkclvRating")]
        public virtual string NkclvRating { get; set; }

        /// <summary>The National Media Council ratings system for United Arab Emirates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nmcRating")]
        public virtual string NmcRating { get; set; }

        /// <summary>The video's Office of Film and Literature Classification (OFLC - New Zealand) rating.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oflcRating")]
        public virtual string OflcRating { get; set; }

        /// <summary>The video's rating in Peru.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pefilmRating")]
        public virtual string PefilmRating { get; set; }

        /// <summary>
        /// The video's rating from the Hungarian Nemzeti Filmiroda, the Rating Committee of the National Office of
        /// Film.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rcnofRating")]
        public virtual string RcnofRating { get; set; }

        /// <summary>The video's rating in Venezuela.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resorteviolenciaRating")]
        public virtual string ResorteviolenciaRating { get; set; }

        /// <summary>The video's General Directorate of Radio, Television and Cinematography (Mexico) rating.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rtcRating")]
        public virtual string RtcRating { get; set; }

        /// <summary>The video's rating from Ireland's Raidió Teilifís Éireann.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rteRating")]
        public virtual string RteRating { get; set; }

        /// <summary>The video's National Film Registry of the Russian Federation (MKRF - Russia) rating.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("russiaRating")]
        public virtual string RussiaRating { get; set; }

        /// <summary>The video's rating in Slovakia.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skfilmRating")]
        public virtual string SkfilmRating { get; set; }

        /// <summary>The video's rating in Iceland.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("smaisRating")]
        public virtual string SmaisRating { get; set; }

        /// <summary>The video's rating from Statens medieråd (Sweden's National Media Council).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("smsaRating")]
        public virtual string SmsaRating { get; set; }

        /// <summary>The video's TV Parental Guidelines (TVPG) rating.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tvpgRating")]
        public virtual string TvpgRating { get; set; }

        /// <summary>A rating that YouTube uses to identify age-restricted content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ytRating")]
        public virtual string YtRating { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Entity : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("typeId")]
        public virtual string TypeId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Geographical coordinates of a point, in WGS84.</summary>
    public class GeoPoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Altitude above the reference ellipsoid, in meters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("altitude")]
        public virtual System.Nullable<double> Altitude { get; set; }

        /// <summary>Latitude in degrees.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latitude")]
        public virtual System.Nullable<double> Latitude { get; set; }

        /// <summary>Longitude in degrees.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longitude")]
        public virtual System.Nullable<double> Longitude { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An *i18nLanguage* resource identifies a UI language currently supported by YouTube.</summary>
    public class I18nLanguage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The ID that YouTube uses to uniquely identify the i18n language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Identifies what kind of resource this is. Value: the fixed string "youtube#i18nLanguage".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The snippet object contains basic details about the i18n language, such as language code and human-readable
        /// name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
        public virtual I18nLanguageSnippet Snippet { get; set; }
    }

    public class I18nLanguageListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Serialized EventId of the request which produced this response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        /// <summary>
        /// A list of supported i18n languages. In this map, the i18n language ID is the map key, and its value is the
        /// corresponding i18nLanguage resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<I18nLanguage> Items { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "youtube#i18nLanguageListResponse".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The visitorId identifies the visitor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visitorId")]
        public virtual string VisitorId { get; set; }
    }

    /// <summary>Basic details about an i18n language, such as language code and human-readable name.</summary>
    public class I18nLanguageSnippet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A short BCP-47 code that uniquely identifies a language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hl")]
        public virtual string Hl { get; set; }

        /// <summary>The human-readable name of the language in the language itself.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A *i18nRegion* resource identifies a region where YouTube is available.</summary>
    public class I18nRegion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The ID that YouTube uses to uniquely identify the i18n region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Identifies what kind of resource this is. Value: the fixed string "youtube#i18nRegion".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The snippet object contains basic details about the i18n region, such as region code and human-readable
        /// name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
        public virtual I18nRegionSnippet Snippet { get; set; }
    }

    public class I18nRegionListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Serialized EventId of the request which produced this response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        /// <summary>
        /// A list of regions where YouTube is available. In this map, the i18n region ID is the map key, and its value
        /// is the corresponding i18nRegion resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<I18nRegion> Items { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "youtube#i18nRegionListResponse".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The visitorId identifies the visitor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visitorId")]
        public virtual string VisitorId { get; set; }
    }

    /// <summary>Basic details about an i18n region, such as region code and human-readable name.</summary>
    public class I18nRegionSnippet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The region code as a 2-letter ISO country code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gl")]
        public virtual string Gl { get; set; }

        /// <summary>The human-readable name of the region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Branding properties for images associated with the channel.</summary>
    public class ImageSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The URL for the background image shown on the video watch page. The image should be 1200px by 615px, with a
        /// maximum file size of 128k.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backgroundImageUrl")]
        public virtual LocalizedProperty BackgroundImageUrl { get; set; }

        /// <summary>
        /// This is generated when a ChannelBanner.Insert request has succeeded for the given channel.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bannerExternalUrl")]
        public virtual string BannerExternalUrl { get; set; }

        /// <summary>Banner image. Desktop size (1060x175).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bannerImageUrl")]
        public virtual string BannerImageUrl { get; set; }

        /// <summary>Banner image. Mobile size high resolution (1440x395).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bannerMobileExtraHdImageUrl")]
        public virtual string BannerMobileExtraHdImageUrl { get; set; }

        /// <summary>Banner image. Mobile size high resolution (1280x360).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bannerMobileHdImageUrl")]
        public virtual string BannerMobileHdImageUrl { get; set; }

        /// <summary>Banner image. Mobile size (640x175).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bannerMobileImageUrl")]
        public virtual string BannerMobileImageUrl { get; set; }

        /// <summary>Banner image. Mobile size low resolution (320x88).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bannerMobileLowImageUrl")]
        public virtual string BannerMobileLowImageUrl { get; set; }

        /// <summary>Banner image. Mobile size medium/high resolution (960x263).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bannerMobileMediumHdImageUrl")]
        public virtual string BannerMobileMediumHdImageUrl { get; set; }

        /// <summary>Banner image. Tablet size extra high resolution (2560x424).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bannerTabletExtraHdImageUrl")]
        public virtual string BannerTabletExtraHdImageUrl { get; set; }

        /// <summary>Banner image. Tablet size high resolution (2276x377).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bannerTabletHdImageUrl")]
        public virtual string BannerTabletHdImageUrl { get; set; }

        /// <summary>Banner image. Tablet size (1707x283).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bannerTabletImageUrl")]
        public virtual string BannerTabletImageUrl { get; set; }

        /// <summary>Banner image. Tablet size low resolution (1138x188).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bannerTabletLowImageUrl")]
        public virtual string BannerTabletLowImageUrl { get; set; }

        /// <summary>Banner image. TV size high resolution (1920x1080).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bannerTvHighImageUrl")]
        public virtual string BannerTvHighImageUrl { get; set; }

        /// <summary>Banner image. TV size extra high resolution (2120x1192).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bannerTvImageUrl")]
        public virtual string BannerTvImageUrl { get; set; }

        /// <summary>Banner image. TV size low resolution (854x480).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bannerTvLowImageUrl")]
        public virtual string BannerTvLowImageUrl { get; set; }

        /// <summary>Banner image. TV size medium resolution (1280x720).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bannerTvMediumImageUrl")]
        public virtual string BannerTvMediumImageUrl { get; set; }

        /// <summary>The image map script for the large banner image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("largeBrandedBannerImageImapScript")]
        public virtual LocalizedProperty LargeBrandedBannerImageImapScript { get; set; }

        /// <summary>
        /// The URL for the 854px by 70px image that appears below the video player in the expanded video view of the
        /// video watch page.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("largeBrandedBannerImageUrl")]
        public virtual LocalizedProperty LargeBrandedBannerImageUrl { get; set; }

        /// <summary>The image map script for the small banner image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("smallBrandedBannerImageImapScript")]
        public virtual LocalizedProperty SmallBrandedBannerImageImapScript { get; set; }

        /// <summary>
        /// The URL for the 640px by 70px banner image that appears below the video player in the default view of the
        /// video watch page. The URL for the image that appears above the top-left corner of the video player. This is
        /// a 25-pixel-high image with a flexible width that cannot exceed 170 pixels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("smallBrandedBannerImageUrl")]
        public virtual LocalizedProperty SmallBrandedBannerImageUrl { get; set; }

        /// <summary>
        /// The URL for a 1px by 1px tracking pixel that can be used to collect statistics for views of the channel or
        /// video pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackingImageUrl")]
        public virtual string TrackingImageUrl { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("watchIconImageUrl")]
        public virtual string WatchIconImageUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes information necessary for ingesting an RTMP or an HTTP stream.</summary>
    public class IngestionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The backup ingestion URL that you should use to stream video to YouTube. You have the option of
        /// simultaneously streaming the content that you are sending to the ingestionAddress to this URL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupIngestionAddress")]
        public virtual string BackupIngestionAddress { get; set; }

        /// <summary>
        /// The primary ingestion URL that you should use to stream video to YouTube. You must stream video to this URL.
        /// Depending on which application or tool you use to encode your video stream, you may need to enter the stream
        /// URL and stream name separately or you may need to concatenate them in the following format:
        /// *STREAM_URL/STREAM_NAME*
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingestionAddress")]
        public virtual string IngestionAddress { get; set; }

        /// <summary>
        /// This ingestion url may be used instead of backupIngestionAddress in order to stream via RTMPS. Not
        /// applicable to non-RTMP streams.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rtmpsBackupIngestionAddress")]
        public virtual string RtmpsBackupIngestionAddress { get; set; }

        /// <summary>
        /// This ingestion url may be used instead of ingestionAddress in order to stream via RTMPS. Not applicable to
        /// non-RTMP streams.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rtmpsIngestionAddress")]
        public virtual string RtmpsIngestionAddress { get; set; }

        /// <summary>The HTTP or RTMP stream name that YouTube assigns to the video stream.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("streamName")]
        public virtual string StreamName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>LINT.IfChange Describes an invideo branding.</summary>
    public class InvideoBranding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The bytes the uploaded image. Only used in api to youtube communication.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageBytes")]
        public virtual string ImageBytes { get; set; }

        /// <summary>The url of the uploaded image. Only used in apiary to api communication.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUrl")]
        public virtual string ImageUrl { get; set; }

        /// <summary>The spatial position within the video where the branding watermark will be displayed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("position")]
        public virtual InvideoPosition Position { get; set; }

        /// <summary>
        /// The channel to which this branding links. If not present it defaults to the current channel.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetChannelId")]
        public virtual string TargetChannelId { get; set; }

        /// <summary>The temporal position within the video where watermark will be displayed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timing")]
        public virtual InvideoTiming Timing { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Describes the spatial position of a visual widget inside a video. It is a union of various position types, out
    /// of which only will be set one.
    /// </summary>
    public class InvideoPosition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Describes in which corner of the video the visual widget will appear.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cornerPosition")]
        public virtual string CornerPosition { get; set; }

        /// <summary>Defines the position type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a temporal position of a visual widget inside a video.</summary>
    public class InvideoTiming : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Defines the duration in milliseconds for which the promotion should be displayed. If missing, the client
        /// should use the default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("durationMs")]
        public virtual System.Nullable<ulong> DurationMs { get; set; }

        /// <summary>
        /// Defines the time at which the promotion will appear. Depending on the value of type the value of the
        /// offsetMs field will represent a time offset from the start or from the end of the video, expressed in
        /// milliseconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offsetMs")]
        public virtual System.Nullable<ulong> OffsetMs { get; set; }

        /// <summary>
        /// Describes a timing type. If the value is offsetFromStart, then the offsetMs field represents an offset from
        /// the start of the video. If the value is offsetFromEnd, then the offsetMs field represents an offset from the
        /// end of the video.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class LanguageTag : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class LevelDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name that should be used when referring to this level.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A *liveBroadcast* resource represents an event that will be streamed, via live video, on YouTube.
    /// </summary>
    public class LiveBroadcast : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The contentDetails object contains information about the event's video content, such as whether the content
        /// can be shown in an embedded video player or if it will be archived and therefore available for viewing after
        /// the event has concluded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentDetails")]
        public virtual LiveBroadcastContentDetails ContentDetails { get; set; }

        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The ID that YouTube assigns to uniquely identify the broadcast.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "youtube#liveBroadcast".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The snippet object contains basic details about the event, including its title, description, start time, and
        /// end time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
        public virtual LiveBroadcastSnippet Snippet { get; set; }

        /// <summary>
        /// The statistics object contains info about the event's current stats. These include concurrent viewers and
        /// total chat count. Statistics can change (in either direction) during the lifetime of an event. Statistics
        /// are only returned while the event is live.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statistics")]
        public virtual LiveBroadcastStatistics Statistics { get; set; }

        /// <summary>The status object contains information about the event's status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual LiveBroadcastStatus Status { get; set; }
    }

    /// <summary>Detailed settings of a broadcast.</summary>
    public class LiveBroadcastContentDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This value uniquely identifies the live stream bound to the broadcast.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundStreamId")]
        public virtual string BoundStreamId { get; set; }

        /// <summary>The date and time that the live stream referenced by boundStreamId was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundStreamLastUpdateTimeMs")]
        public virtual string BoundStreamLastUpdateTimeMsRaw { get; set; }

        /// <summary>
        /// <seealso cref="System.DateTime"/> representation of <see cref="BoundStreamLastUpdateTimeMsRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> BoundStreamLastUpdateTimeMs
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(BoundStreamLastUpdateTimeMsRaw);
            set => BoundStreamLastUpdateTimeMsRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        [Newtonsoft.Json.JsonPropertyAttribute("closedCaptionsType")]
        public virtual string ClosedCaptionsType { get; set; }

        /// <summary>
        /// This setting indicates whether auto start is enabled for this broadcast. The default value for this property
        /// is false. This setting can only be used by Events.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableAutoStart")]
        public virtual System.Nullable<bool> EnableAutoStart { get; set; }

        /// <summary>
        /// This setting indicates whether auto stop is enabled for this broadcast. The default value for this property
        /// is false. This setting can only be used by Events.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableAutoStop")]
        public virtual System.Nullable<bool> EnableAutoStop { get; set; }

        /// <summary>
        /// This setting indicates whether HTTP POST closed captioning is enabled for this broadcast. The ingestion URL
        /// of the closed captions is returned through the liveStreams API. This is mutually exclusive with using the
        /// closed_captions_type property, and is equivalent to setting closed_captions_type to
        /// CLOSED_CAPTIONS_HTTP_POST.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableClosedCaptions")]
        public virtual System.Nullable<bool> EnableClosedCaptions { get; set; }

        /// <summary>
        /// This setting indicates whether YouTube should enable content encryption for the broadcast.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableContentEncryption")]
        public virtual System.Nullable<bool> EnableContentEncryption { get; set; }

        /// <summary>
        /// This setting determines whether viewers can access DVR controls while watching the video. DVR controls
        /// enable the viewer to control the video playback experience by pausing, rewinding, or fast forwarding
        /// content. The default value for this property is true. *Important:* You must set the value to true and also
        /// set the enableArchive property's value to true if you want to make playback available immediately after the
        /// broadcast ends.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableDvr")]
        public virtual System.Nullable<bool> EnableDvr { get; set; }

        /// <summary>
        /// This setting indicates whether the broadcast video can be played in an embedded player. If you choose to
        /// archive the video (using the enableArchive property), this setting will also apply to the archived video.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableEmbed")]
        public virtual System.Nullable<bool> EnableEmbed { get; set; }

        /// <summary>Indicates whether this broadcast has low latency enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableLowLatency")]
        public virtual System.Nullable<bool> EnableLowLatency { get; set; }

        /// <summary>
        /// If both this and enable_low_latency are set, they must match. LATENCY_NORMAL should match
        /// enable_low_latency=false LATENCY_LOW should match enable_low_latency=true LATENCY_ULTRA_LOW should have
        /// enable_low_latency omitted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latencyPreference")]
        public virtual string LatencyPreference { get; set; }

        /// <summary>
        /// The mesh for projecting the video if projection is mesh. The mesh value must be a UTF-8 string containing
        /// the base-64 encoding of 3D mesh data that follows the Spherical Video V2 RFC specification for an mshp box,
        /// excluding the box size and type but including the following four reserved zero bytes for the version and
        /// flags.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mesh")]
        public virtual string Mesh { get; set; }

        /// <summary>
        /// The monitorStream object contains information about the monitor stream, which the broadcaster can use to
        /// review the event content before the broadcast stream is shown publicly.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monitorStream")]
        public virtual MonitorStreamInfo MonitorStream { get; set; }

        /// <summary>The projection format of this broadcast. This defaults to rectangular.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projection")]
        public virtual string Projection { get; set; }

        /// <summary>
        /// Automatically start recording after the event goes live. The default value for this property is true.
        /// *Important:* You must also set the enableDvr property's value to true if you want the playback to be
        /// available immediately after the broadcast ends. If you set this property's value to true but do not also set
        /// the enableDvr property to true, there may be a delay of around one day before the archived video will be
        /// available for playback.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordFromStart")]
        public virtual System.Nullable<bool> RecordFromStart { get; set; }

        /// <summary>
        /// This setting indicates whether the broadcast should automatically begin with an in-stream slate when you
        /// update the broadcast's status to live. After updating the status, you then need to send a
        /// liveCuepoints.insert request that sets the cuepoint's eventState to end to remove the in-stream slate and
        /// make your broadcast stream visible to viewers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startWithSlate")]
        public virtual System.Nullable<bool> StartWithSlate { get; set; }

        /// <summary>The 3D stereo layout of this broadcast. This defaults to mono.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stereoLayout")]
        public virtual string StereoLayout { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class LiveBroadcastListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Serialized EventId of the request which produced this response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        /// <summary>A list of broadcasts that match the request criteria.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<LiveBroadcast> Items { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "youtube#liveBroadcastListResponse".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The token that can be used as the value of the pageToken parameter to retrieve the next page in the result
        /// set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>General pagination information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageInfo")]
        public virtual PageInfo PageInfo { get; set; }

        /// <summary>
        /// The token that can be used as the value of the pageToken parameter to retrieve the previous page in the
        /// result set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prevPageToken")]
        public virtual string PrevPageToken { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("tokenPagination")]
        public virtual TokenPagination TokenPagination { get; set; }

        /// <summary>The visitorId identifies the visitor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visitorId")]
        public virtual string VisitorId { get; set; }
    }

    /// <summary>Basic broadcast information.</summary>
    public class LiveBroadcastSnippet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The date and time that the broadcast actually ended. This information is only available once the broadcast's
        /// state is complete.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actualEndTime")]
        public virtual string ActualEndTimeRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="ActualEndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> ActualEndTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(ActualEndTimeRaw);
            set => ActualEndTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// The date and time that the broadcast actually started. This information is only available once the
        /// broadcast's state is live.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actualStartTime")]
        public virtual string ActualStartTimeRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="ActualStartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> ActualStartTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(ActualStartTimeRaw);
            set => ActualStartTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// The ID that YouTube uses to uniquely identify the channel that is publishing the broadcast.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelId")]
        public virtual string ChannelId { get; set; }

        /// <summary>
        /// The broadcast's description. As with the title, you can set this field by modifying the broadcast resource
        /// or by setting the description field of the corresponding video resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Indicates whether this broadcast is the default broadcast. Internal only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isDefaultBroadcast")]
        public virtual System.Nullable<bool> IsDefaultBroadcast { get; set; }

        /// <summary>The id of the live chat for this broadcast.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("liveChatId")]
        public virtual string LiveChatId { get; set; }

        /// <summary>The date and time that the broadcast was added to YouTube's live broadcast schedule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishedAt")]
        public virtual string PublishedAtRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="PublishedAtRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> PublishedAt
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(PublishedAtRaw);
            set => PublishedAtRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>The date and time that the broadcast is scheduled to end.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduledEndTime")]
        public virtual string ScheduledEndTimeRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="ScheduledEndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> ScheduledEndTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(ScheduledEndTimeRaw);
            set => ScheduledEndTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>The date and time that the broadcast is scheduled to start.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduledStartTime")]
        public virtual string ScheduledStartTimeRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="ScheduledStartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> ScheduledStartTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(ScheduledStartTimeRaw);
            set => ScheduledStartTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// A map of thumbnail images associated with the broadcast. For each nested object in this object, the key is
        /// the name of the thumbnail image, and the value is an object that contains other information about the
        /// thumbnail.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnails")]
        public virtual ThumbnailDetails Thumbnails { get; set; }

        /// <summary>
        /// The broadcast's title. Note that the broadcast represents exactly one YouTube video. You can set this field
        /// by modifying the broadcast resource or by setting the title field of the corresponding video resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Statistics about the live broadcast. These represent a snapshot of the values at the time of the request.
    /// Statistics are only returned for live broadcasts.
    /// </summary>
    public class LiveBroadcastStatistics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The total number of live chat messages currently on the broadcast. The property and its value will be
        /// present if the broadcast is public, has the live chat feature enabled, and has at least one message. Note
        /// that this field will not be filled after the broadcast ends. So this property would not identify the number
        /// of chat messages for an archived video of a completed live broadcast.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalChatCount")]
        public virtual System.Nullable<ulong> TotalChatCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Live broadcast state.</summary>
    public class LiveBroadcastStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The broadcast's status. The status can be updated using the API's liveBroadcasts.transition method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifeCycleStatus")]
        public virtual string LifeCycleStatus { get; set; }

        /// <summary>Priority of the live broadcast event (internal state).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("liveBroadcastPriority")]
        public virtual string LiveBroadcastPriority { get; set; }

        /// <summary>
        /// Whether the broadcast is made for kids or not, decided by YouTube instead of the creator. This field is read
        /// only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("madeForKids")]
        public virtual System.Nullable<bool> MadeForKids { get; set; }

        /// <summary>
        /// The broadcast's privacy status. Note that the broadcast represents exactly one YouTube video, so the privacy
        /// settings are identical to those supported for videos. In addition, you can set this field by modifying the
        /// broadcast resource or by setting the privacyStatus field of the corresponding video resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privacyStatus")]
        public virtual string PrivacyStatus { get; set; }

        /// <summary>The broadcast's recording status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordingStatus")]
        public virtual string RecordingStatus { get; set; }

        /// <summary>
        /// This field will be set to True if the creator declares the broadcast to be kids only: go/live-cw-work.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfDeclaredMadeForKids")]
        public virtual System.Nullable<bool> SelfDeclaredMadeForKids { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A `__liveChatBan__` resource represents a ban for a YouTube live chat.</summary>
    public class LiveChatBan : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The ID that YouTube assigns to uniquely identify the ban.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string `"youtube#liveChatBan"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The `snippet` object contains basic details about the ban.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
        public virtual LiveChatBanSnippet Snippet { get; set; }
    }

    public class LiveChatBanSnippet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The duration of a ban, only filled if the ban has type TEMPORARY.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("banDurationSeconds")]
        public virtual System.Nullable<ulong> BanDurationSeconds { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("bannedUserDetails")]
        public virtual ChannelProfileDetails BannedUserDetails { get; set; }

        /// <summary>The chat this ban is pertinent to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("liveChatId")]
        public virtual string LiveChatId { get; set; }

        /// <summary>The type of ban.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class LiveChatFanFundingEventDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A rendered string that displays the fund amount and currency to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amountDisplayString")]
        public virtual string AmountDisplayString { get; set; }

        /// <summary>The amount of the fund.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amountMicros")]
        public virtual System.Nullable<ulong> AmountMicros { get; set; }

        /// <summary>The currency in which the fund was made.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currency")]
        public virtual string Currency { get; set; }

        /// <summary>The comment added by the user to this fan funding event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userComment")]
        public virtual string UserComment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A *liveChatMessage* resource represents a chat message in a YouTube Live Chat.</summary>
    public class LiveChatMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The authorDetails object contains basic details about the user that posted this message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorDetails")]
        public virtual LiveChatMessageAuthorDetails AuthorDetails { get; set; }

        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The ID that YouTube assigns to uniquely identify the message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "youtube#liveChatMessage".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The snippet object contains basic details about the message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
        public virtual LiveChatMessageSnippet Snippet { get; set; }
    }

    public class LiveChatMessageAuthorDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The YouTube channel ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelId")]
        public virtual string ChannelId { get; set; }

        /// <summary>The channel's URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelUrl")]
        public virtual string ChannelUrl { get; set; }

        /// <summary>The channel's display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Whether the author is a moderator of the live chat.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isChatModerator")]
        public virtual System.Nullable<bool> IsChatModerator { get; set; }

        /// <summary>Whether the author is the owner of the live chat.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isChatOwner")]
        public virtual System.Nullable<bool> IsChatOwner { get; set; }

        /// <summary>Whether the author is a sponsor of the live chat.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isChatSponsor")]
        public virtual System.Nullable<bool> IsChatSponsor { get; set; }

        /// <summary>Whether the author's identity has been verified by YouTube.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isVerified")]
        public virtual System.Nullable<bool> IsVerified { get; set; }

        /// <summary>The channels's avatar URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profileImageUrl")]
        public virtual string ProfileImageUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class LiveChatMessageDeletedDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("deletedMessageId")]
        public virtual string DeletedMessageId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class LiveChatMessageListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Serialized EventId of the request which produced this response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<LiveChatMessage> Items { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "youtube#liveChatMessageListResponse".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The date and time when the underlying stream went offline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offlineAt")]
        public virtual string OfflineAtRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="OfflineAtRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> OfflineAt
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(OfflineAtRaw);
            set => OfflineAtRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>General pagination information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageInfo")]
        public virtual PageInfo PageInfo { get; set; }

        /// <summary>The amount of time the client should wait before polling again.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pollingIntervalMillis")]
        public virtual System.Nullable<long> PollingIntervalMillis { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("tokenPagination")]
        public virtual TokenPagination TokenPagination { get; set; }

        /// <summary>The visitorId identifies the visitor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visitorId")]
        public virtual string VisitorId { get; set; }
    }

    public class LiveChatMessageRetractedDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("retractedMessageId")]
        public virtual string RetractedMessageId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class LiveChatMessageSnippet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The ID of the user that authored this message, this field is not always filled. textMessageEvent - the user
        /// that wrote the message fanFundingEvent - the user that funded the broadcast newSponsorEvent - the user that
        /// just became a sponsor messageDeletedEvent - the moderator that took the action messageRetractedEvent - the
        /// author that retracted their message userBannedEvent - the moderator that took the action superChatEvent -
        /// the user that made the purchase
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorChannelId")]
        public virtual string AuthorChannelId { get; set; }

        /// <summary>
        /// Contains a string that can be displayed to the user. If this field is not present the message is silent, at
        /// the moment only messages of type TOMBSTONE and CHAT_ENDED_EVENT are silent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayMessage")]
        public virtual string DisplayMessage { get; set; }

        /// <summary>Details about the funding event, this is only set if the type is 'fanFundingEvent'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fanFundingEventDetails")]
        public virtual LiveChatFanFundingEventDetails FanFundingEventDetails { get; set; }

        /// <summary>Whether the message has display content that should be displayed to users.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasDisplayContent")]
        public virtual System.Nullable<bool> HasDisplayContent { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("liveChatId")]
        public virtual string LiveChatId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("messageDeletedDetails")]
        public virtual LiveChatMessageDeletedDetails MessageDeletedDetails { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("messageRetractedDetails")]
        public virtual LiveChatMessageRetractedDetails MessageRetractedDetails { get; set; }

        /// <summary>The date and time when the message was orignally published.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishedAt")]
        public virtual string PublishedAtRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="PublishedAtRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> PublishedAt
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(PublishedAtRaw);
            set => PublishedAtRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>Details about the Super Chat event, this is only set if the type is 'superChatEvent'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("superChatDetails")]
        public virtual LiveChatSuperChatDetails SuperChatDetails { get; set; }

        /// <summary>
        /// Details about the Super Sticker event, this is only set if the type is 'superStickerEvent'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("superStickerDetails")]
        public virtual LiveChatSuperStickerDetails SuperStickerDetails { get; set; }

        /// <summary>Details about the text message, this is only set if the type is 'textMessageEvent'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textMessageDetails")]
        public virtual LiveChatTextMessageDetails TextMessageDetails { get; set; }

        /// <summary>
        /// The type of message, this will always be present, it determines the contents of the message as well as which
        /// fields will be present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userBannedDetails")]
        public virtual LiveChatUserBannedMessageDetails UserBannedDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A *liveChatModerator* resource represents a moderator for a YouTube live chat. A chat moderator has the ability
    /// to ban/unban users from a chat, remove message, etc.
    /// </summary>
    public class LiveChatModerator : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The ID that YouTube assigns to uniquely identify the moderator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "youtube#liveChatModerator".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The snippet object contains basic details about the moderator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
        public virtual LiveChatModeratorSnippet Snippet { get; set; }
    }

    public class LiveChatModeratorListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Serialized EventId of the request which produced this response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        /// <summary>A list of moderators that match the request criteria.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<LiveChatModerator> Items { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "youtube#liveChatModeratorListResponse".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The token that can be used as the value of the pageToken parameter to retrieve the next page in the result
        /// set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>General pagination information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageInfo")]
        public virtual PageInfo PageInfo { get; set; }

        /// <summary>
        /// The token that can be used as the value of the pageToken parameter to retrieve the previous page in the
        /// result set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prevPageToken")]
        public virtual string PrevPageToken { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("tokenPagination")]
        public virtual TokenPagination TokenPagination { get; set; }

        /// <summary>The visitorId identifies the visitor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visitorId")]
        public virtual string VisitorId { get; set; }
    }

    public class LiveChatModeratorSnippet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the live chat this moderator can act on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("liveChatId")]
        public virtual string LiveChatId { get; set; }

        /// <summary>Details about the moderator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moderatorDetails")]
        public virtual ChannelProfileDetails ModeratorDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class LiveChatSuperChatDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A rendered string that displays the fund amount and currency to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amountDisplayString")]
        public virtual string AmountDisplayString { get; set; }

        /// <summary>The amount purchased by the user, in micros (1,750,000 micros = 1.75).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amountMicros")]
        public virtual System.Nullable<ulong> AmountMicros { get; set; }

        /// <summary>The currency in which the purchase was made.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currency")]
        public virtual string Currency { get; set; }

        /// <summary>
        /// The tier in which the amount belongs. Lower amounts belong to lower tiers. The lowest tier is 1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tier")]
        public virtual System.Nullable<long> Tier { get; set; }

        /// <summary>The comment added by the user to this Super Chat event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userComment")]
        public virtual string UserComment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class LiveChatSuperStickerDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A rendered string that displays the fund amount and currency to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amountDisplayString")]
        public virtual string AmountDisplayString { get; set; }

        /// <summary>The amount purchased by the user, in micros (1,750,000 micros = 1.75).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amountMicros")]
        public virtual System.Nullable<ulong> AmountMicros { get; set; }

        /// <summary>The currency in which the purchase was made.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currency")]
        public virtual string Currency { get; set; }

        /// <summary>Information about the Super Sticker.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("superStickerMetadata")]
        public virtual SuperStickerMetadata SuperStickerMetadata { get; set; }

        /// <summary>
        /// The tier in which the amount belongs. Lower amounts belong to lower tiers. The lowest tier is 1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tier")]
        public virtual System.Nullable<long> Tier { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class LiveChatTextMessageDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The user's message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageText")]
        public virtual string MessageText { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class LiveChatUserBannedMessageDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The duration of the ban. This property is only present if the banType is temporary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("banDurationSeconds")]
        public virtual System.Nullable<ulong> BanDurationSeconds { get; set; }

        /// <summary>The type of ban.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("banType")]
        public virtual string BanType { get; set; }

        /// <summary>The details of the user that was banned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bannedUserDetails")]
        public virtual ChannelProfileDetails BannedUserDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A live stream describes a live ingestion point.</summary>
    public class LiveStream : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The cdn object defines the live stream's content delivery network (CDN) settings. These settings provide
        /// details about the manner in which you stream your content to YouTube.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cdn")]
        public virtual CdnSettings Cdn { get; set; }

        /// <summary>
        /// The content_details object contains information about the stream, including the closed captions ingestion
        /// URL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentDetails")]
        public virtual LiveStreamContentDetails ContentDetails { get; set; }

        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The ID that YouTube assigns to uniquely identify the stream.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Identifies what kind of resource this is. Value: the fixed string "youtube#liveStream".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The snippet object contains basic details about the stream, including its channel, title, and description.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
        public virtual LiveStreamSnippet Snippet { get; set; }

        /// <summary>The status object contains information about live stream's status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual LiveStreamStatus Status { get; set; }
    }

    public class LiveStreamConfigurationIssue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The long-form description of the issue and how to resolve it.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The short-form reason for this issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>How severe this issue is to the stream.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The kind of error happening.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detailed settings of a stream.</summary>
    public class LiveStreamContentDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ingestion URL where the closed captions of this stream are sent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("closedCaptionsIngestionUrl")]
        public virtual string ClosedCaptionsIngestionUrl { get; set; }

        /// <summary>
        /// Indicates whether the stream is reusable, which means that it can be bound to multiple broadcasts. It is
        /// common for broadcasters to reuse the same stream for many different broadcasts if those broadcasts occur at
        /// different times. If you set this value to false, then the stream will not be reusable, which means that it
        /// can only be bound to one broadcast. Non-reusable streams differ from reusable streams in the following ways:
        /// - A non-reusable stream can only be bound to one broadcast. - A non-reusable stream might be deleted by an
        /// automated process after the broadcast ends. - The liveStreams.list method does not list non-reusable streams
        /// if you call the method and set the mine parameter to true. The only way to use that method to retrieve the
        /// resource for a non-reusable stream is to use the id parameter to identify the stream.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isReusable")]
        public virtual System.Nullable<bool> IsReusable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class LiveStreamHealthStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The configurations issues on this stream</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configurationIssues")]
        public virtual System.Collections.Generic.IList<LiveStreamConfigurationIssue> ConfigurationIssues { get; set; }

        /// <summary>The last time this status was updated (in seconds)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdateTimeSeconds")]
        public virtual System.Nullable<ulong> LastUpdateTimeSeconds { get; set; }

        /// <summary>The status code of this stream</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class LiveStreamListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Serialized EventId of the request which produced this response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        /// <summary>A list of live streams that match the request criteria.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<LiveStream> Items { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "youtube#liveStreamListResponse".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The token that can be used as the value of the pageToken parameter to retrieve the next page in the result
        /// set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("pageInfo")]
        public virtual PageInfo PageInfo { get; set; }

        /// <summary>
        /// The token that can be used as the value of the pageToken parameter to retrieve the previous page in the
        /// result set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prevPageToken")]
        public virtual string PrevPageToken { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("tokenPagination")]
        public virtual TokenPagination TokenPagination { get; set; }

        /// <summary>The visitorId identifies the visitor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visitorId")]
        public virtual string VisitorId { get; set; }
    }

    public class LiveStreamSnippet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The ID that YouTube uses to uniquely identify the channel that is transmitting the stream.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelId")]
        public virtual string ChannelId { get; set; }

        /// <summary>The stream's description. The value cannot be longer than 10000 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("isDefaultStream")]
        public virtual System.Nullable<bool> IsDefaultStream { get; set; }

        /// <summary>The date and time that the stream was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishedAt")]
        public virtual string PublishedAtRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="PublishedAtRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> PublishedAt
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(PublishedAtRaw);
            set => PublishedAtRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>The stream's title. The value must be between 1 and 128 characters long.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Brief description of the live stream status.</summary>
    public class LiveStreamStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The health status of the stream.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthStatus")]
        public virtual LiveStreamHealthStatus HealthStatus { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("streamStatus")]
        public virtual string StreamStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class LocalizedProperty : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("default")]
        public virtual string Default__ { get; set; }

        /// <summary>The language of the default property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultLanguage")]
        public virtual LanguageTag DefaultLanguage { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("localized")]
        public virtual System.Collections.Generic.IList<LocalizedString> Localized { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class LocalizedString : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("language")]
        public virtual string Language { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A *member* resource represents a member for a YouTube channel. A member provides recurring monetary support to a
    /// creator and receives special benefits.
    /// </summary>
    public class Member : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Identifies what kind of resource this is. Value: the fixed string "youtube#member".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The snippet object contains basic details about the member.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
        public virtual MemberSnippet Snippet { get; set; }
    }

    public class MemberListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Serialized EventId of the request which produced this response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        /// <summary>A list of members that match the request criteria.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Member> Items { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "youtube#memberListResponse".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The token that can be used as the value of the pageToken parameter to retrieve the next page in the result
        /// set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("pageInfo")]
        public virtual PageInfo PageInfo { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("tokenPagination")]
        public virtual TokenPagination TokenPagination { get; set; }

        /// <summary>The visitorId identifies the visitor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visitorId")]
        public virtual string VisitorId { get; set; }
    }

    public class MemberSnippet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The id of the channel that's offering memberships.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creatorChannelId")]
        public virtual string CreatorChannelId { get; set; }

        /// <summary>Details about the member.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memberDetails")]
        public virtual ChannelProfileDetails MemberDetails { get; set; }

        /// <summary>Details about the user's membership.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membershipsDetails")]
        public virtual MembershipsDetails MembershipsDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class MembershipsDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Ids of all levels that the user has access to. This includes the currently active level and all other levels
        /// that are included because of a higher purchase.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessibleLevels")]
        public virtual System.Collections.Generic.IList<string> AccessibleLevels { get; set; }

        /// <summary>Id of the highest level that the user has access to at the moment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("highestAccessibleLevel")]
        public virtual string HighestAccessibleLevel { get; set; }

        /// <summary>Display name for the highest level that the user has access to at the moment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("highestAccessibleLevelDisplayName")]
        public virtual string HighestAccessibleLevelDisplayName { get; set; }

        /// <summary>Data about memberships duration without taking into consideration pricing levels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membershipsDuration")]
        public virtual MembershipsDuration MembershipsDuration { get; set; }

        /// <summary>Data about memberships duration on particular pricing levels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membershipsDurationAtLevels")]
        public virtual System.Collections.Generic.IList<MembershipsDurationAtLevel> MembershipsDurationAtLevels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class MembershipsDuration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The date and time when the user became a continuous member across all levels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memberSince")]
        public virtual string MemberSince { get; set; }

        /// <summary>
        /// The cumulative time the user has been a member across all levels in complete months (the time is rounded
        /// down to the nearest integer).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memberTotalDurationMonths")]
        public virtual System.Nullable<int> MemberTotalDurationMonths { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class MembershipsDurationAtLevel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Pricing level ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("level")]
        public virtual string Level { get; set; }

        /// <summary>The date and time when the user became a continuous member for the given level.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memberSince")]
        public virtual string MemberSince { get; set; }

        /// <summary>
        /// The cumulative time the user has been a member for the given level in complete months (the time is rounded
        /// down to the nearest integer).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memberTotalDurationMonths")]
        public virtual System.Nullable<int> MemberTotalDurationMonths { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A *membershipsLevel* resource represents an offer made by YouTube creators for their fans. Users can become
    /// members of the channel by joining one of the available levels. They will provide recurring monetary support and
    /// receives special benefits.
    /// </summary>
    public class MembershipsLevel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The ID that YouTube assigns to uniquely identify the memberships level.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "youtube#membershipsLevelListResponse".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The snippet object contains basic details about the level.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
        public virtual MembershipsLevelSnippet Snippet { get; set; }
    }

    public class MembershipsLevelListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Serialized EventId of the request which produced this response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        /// <summary>A list of pricing levels offered by a creator to the fans.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<MembershipsLevel> Items { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "youtube#membershipsLevelListResponse".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The visitorId identifies the visitor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visitorId")]
        public virtual string VisitorId { get; set; }
    }

    public class MembershipsLevelSnippet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The id of the channel that's offering channel memberships.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creatorChannelId")]
        public virtual string CreatorChannelId { get; set; }

        /// <summary>Details about the pricing level.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("levelDetails")]
        public virtual LevelDetails LevelDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings and Info of the monitor stream</summary>
    public class MonitorStreamInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If you have set the enableMonitorStream property to true, then this property determines the length of the
        /// live broadcast delay.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("broadcastStreamDelayMs")]
        public virtual System.Nullable<long> BroadcastStreamDelayMs { get; set; }

        /// <summary>HTML code that embeds a player that plays the monitor stream.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("embedHtml")]
        public virtual string EmbedHtml { get; set; }

        /// <summary>
        /// This value determines whether the monitor stream is enabled for the broadcast. If the monitor stream is
        /// enabled, then YouTube will broadcast the event content on a special stream intended only for the
        /// broadcaster's consumption. The broadcaster can use the stream to review the event content and also to
        /// identify the optimal times to insert cuepoints. You need to set this value to true if you intend to have a
        /// broadcast delay for your event. *Note:* This property cannot be updated once the broadcast is in the testing
        /// or live state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableMonitorStream")]
        public virtual System.Nullable<bool> EnableMonitorStream { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Paging details for lists of resources, including total number of items available and number of resources
    /// returned in a single page.
    /// </summary>
    public class PageInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of results included in the API response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultsPerPage")]
        public virtual System.Nullable<int> ResultsPerPage { get; set; }

        /// <summary>The total number of results in the result set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalResults")]
        public virtual System.Nullable<int> TotalResults { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A *playlist* resource represents a YouTube playlist. A playlist is a collection of videos that can be viewed
    /// sequentially and shared with other users. A playlist can contain up to 200 videos, and YouTube does not limit
    /// the number of playlists that each user creates. By default, playlists are publicly visible to other users, but
    /// playlists can be public or private. YouTube also uses playlists to identify special collections of videos for a
    /// channel, such as: - uploaded videos - favorite videos - positively rated (liked) videos - watch history - watch
    /// later To be more specific, these lists are associated with a channel, which is a collection of a person, group,
    /// or company's videos, playlists, and other YouTube information. You can retrieve the playlist IDs for each of
    /// these lists from the channel resource for a given channel. You can then use the playlistItems.list method to
    /// retrieve any of those lists. You can also add or remove items from those lists by calling the
    /// playlistItems.insert and playlistItems.delete methods.
    /// </summary>
    public class Playlist : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The contentDetails object contains information like video count.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentDetails")]
        public virtual PlaylistContentDetails ContentDetails { get; set; }

        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The ID that YouTube uses to uniquely identify the playlist.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Identifies what kind of resource this is. Value: the fixed string "youtube#playlist".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Localizations for different languages</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizations")]
        public virtual System.Collections.Generic.IDictionary<string, PlaylistLocalization> Localizations { get; set; }

        /// <summary>
        /// The player object contains information that you would use to play the playlist in an embedded player.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("player")]
        public virtual PlaylistPlayer Player { get; set; }

        /// <summary>
        /// The snippet object contains basic details about the playlist, such as its title and description.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
        public virtual PlaylistSnippet Snippet { get; set; }

        /// <summary>The status object contains status information for the playlist.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual PlaylistStatus Status { get; set; }
    }

    public class PlaylistContentDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of videos in the playlist.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemCount")]
        public virtual System.Nullable<long> ItemCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A *playlistItem* resource identifies another resource, such as a video, that is included in a playlist. In
    /// addition, the playlistItem resource contains details about the included resource that pertain specifically to
    /// how that resource is used in that playlist. YouTube uses playlists to identify special collections of videos for
    /// a channel, such as: - uploaded videos - favorite videos - positively rated (liked) videos - watch history -
    /// watch later To be more specific, these lists are associated with a channel, which is a collection of a person,
    /// group, or company's videos, playlists, and other YouTube information. You can retrieve the playlist IDs for each
    /// of these lists from the channel resource for a given channel. You can then use the playlistItems.list method to
    /// retrieve any of those lists. You can also add or remove items from those lists by calling the
    /// playlistItems.insert and playlistItems.delete methods. For example, if a user gives a positive rating to a
    /// video, you would insert that video into the liked videos playlist for that user's channel.
    /// </summary>
    public class PlaylistItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The contentDetails object is included in the resource if the included item is a YouTube video. The object
        /// contains additional information about the video.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentDetails")]
        public virtual PlaylistItemContentDetails ContentDetails { get; set; }

        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The ID that YouTube uses to uniquely identify the playlist item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Identifies what kind of resource this is. Value: the fixed string "youtube#playlistItem".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The snippet object contains basic details about the playlist item, such as its title and position in the
        /// playlist.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
        public virtual PlaylistItemSnippet Snippet { get; set; }

        /// <summary>The status object contains information about the playlist item's privacy status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual PlaylistItemStatus Status { get; set; }
    }

    public class PlaylistItemContentDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The time, measured in seconds from the start of the video, when the video should stop playing. (The playlist
        /// owner can specify the times when the video should start and stop playing when the video is played in the
        /// context of the playlist.) By default, assume that the video.endTime is the end of the video.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endAt")]
        public virtual string EndAt { get; set; }

        /// <summary>A user-generated note for this item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("note")]
        public virtual string Note { get; set; }

        /// <summary>
        /// The time, measured in seconds from the start of the video, when the video should start playing. (The
        /// playlist owner can specify the times when the video should start and stop playing when the video is played
        /// in the context of the playlist.) The default value is 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startAt")]
        public virtual string StartAt { get; set; }

        /// <summary>
        /// The ID that YouTube uses to uniquely identify a video. To retrieve the video resource, set the id query
        /// parameter to this value in your API request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoId")]
        public virtual string VideoId { get; set; }

        /// <summary>The date and time that the video was published to YouTube.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoPublishedAt")]
        public virtual string VideoPublishedAtRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="VideoPublishedAtRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> VideoPublishedAt
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(VideoPublishedAtRaw);
            set => VideoPublishedAtRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PlaylistItemListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Serialized EventId of the request which produced this response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        /// <summary>A list of playlist items that match the request criteria.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<PlaylistItem> Items { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "youtube#playlistItemListResponse". Etag
        /// of this resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The token that can be used as the value of the pageToken parameter to retrieve the next page in the result
        /// set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>General pagination information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageInfo")]
        public virtual PageInfo PageInfo { get; set; }

        /// <summary>
        /// The token that can be used as the value of the pageToken parameter to retrieve the previous page in the
        /// result set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prevPageToken")]
        public virtual string PrevPageToken { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("tokenPagination")]
        public virtual TokenPagination TokenPagination { get; set; }

        /// <summary>The visitorId identifies the visitor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visitorId")]
        public virtual string VisitorId { get; set; }
    }

    /// <summary>
    /// Basic details about a playlist, including title, description and thumbnails. Basic details of a YouTube Playlist
    /// item provided by the author. Next ID: 15
    /// </summary>
    public class PlaylistItemSnippet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The ID that YouTube uses to uniquely identify the user that added the item to the playlist.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelId")]
        public virtual string ChannelId { get; set; }

        /// <summary>Channel title for the channel that the playlist item belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelTitle")]
        public virtual string ChannelTitle { get; set; }

        /// <summary>The item's description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The ID that YouTube uses to uniquely identify thGe playlist that the playlist item is in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("playlistId")]
        public virtual string PlaylistId { get; set; }

        /// <summary>
        /// The order in which the item appears in the playlist. The value uses a zero-based index, so the first item
        /// has a position of 0, the second item has a position of 1, and so forth.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("position")]
        public virtual System.Nullable<long> Position { get; set; }

        /// <summary>The date and time that the item was added to the playlist.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishedAt")]
        public virtual string PublishedAtRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="PublishedAtRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> PublishedAt
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(PublishedAtRaw);
            set => PublishedAtRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// The id object contains information that can be used to uniquely identify the resource that is included in
        /// the playlist as the playlist item.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual ResourceId ResourceId { get; set; }

        /// <summary>
        /// A map of thumbnail images associated with the playlist item. For each object in the map, the key is the name
        /// of the thumbnail image, and the value is an object that contains other information about the thumbnail.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnails")]
        public virtual ThumbnailDetails Thumbnails { get; set; }

        /// <summary>The item's title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>Channel id for the channel this video belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoOwnerChannelId")]
        public virtual string VideoOwnerChannelId { get; set; }

        /// <summary>Channel title for the channel this video belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoOwnerChannelTitle")]
        public virtual string VideoOwnerChannelTitle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the playlist item's privacy status.</summary>
    public class PlaylistItemStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This resource's privacy status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privacyStatus")]
        public virtual string PrivacyStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PlaylistListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Serialized EventId of the request which produced this response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        /// <summary>A list of playlists that match the request criteria</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Playlist> Items { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "youtube#playlistListResponse".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The token that can be used as the value of the pageToken parameter to retrieve the next page in the result
        /// set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>General pagination information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageInfo")]
        public virtual PageInfo PageInfo { get; set; }

        /// <summary>
        /// The token that can be used as the value of the pageToken parameter to retrieve the previous page in the
        /// result set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prevPageToken")]
        public virtual string PrevPageToken { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("tokenPagination")]
        public virtual TokenPagination TokenPagination { get; set; }

        /// <summary>The visitorId identifies the visitor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visitorId")]
        public virtual string VisitorId { get; set; }
    }

    /// <summary>Playlist localization setting</summary>
    public class PlaylistLocalization : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The localized strings for playlist's description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The localized strings for playlist's title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PlaylistPlayer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An &lt;iframe&gt; tag that embeds a player that will play the playlist.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("embedHtml")]
        public virtual string EmbedHtml { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Basic details about a playlist, including title, description and thumbnails.</summary>
    public class PlaylistSnippet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID that YouTube uses to uniquely identify the channel that published the playlist.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelId")]
        public virtual string ChannelId { get; set; }

        /// <summary>The channel title of the channel that the video belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelTitle")]
        public virtual string ChannelTitle { get; set; }

        /// <summary>The language of the playlist's default title and description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultLanguage")]
        public virtual string DefaultLanguage { get; set; }

        /// <summary>The playlist's description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Localized title and description, read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localized")]
        public virtual PlaylistLocalization Localized { get; set; }

        /// <summary>The date and time that the playlist was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishedAt")]
        public virtual string PublishedAtRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="PublishedAtRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> PublishedAt
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(PublishedAtRaw);
            set => PublishedAtRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>Keyword tags associated with the playlist.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// Note: if the playlist has a custom thumbnail, this field will not be populated. The video id selected by the
        /// user that will be used as the thumbnail of this playlist. This field defaults to the first publicly viewable
        /// video in the playlist, if: 1. The user has never selected a video to be the thumbnail of the playlist. 2.
        /// The user selects a video to be the thumbnail, and then removes that video from the playlist. 3. The user
        /// selects a non-owned video to be the thumbnail, but that video becomes private, or gets deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnailVideoId")]
        public virtual string ThumbnailVideoId { get; set; }

        /// <summary>
        /// A map of thumbnail images associated with the playlist. For each object in the map, the key is the name of
        /// the thumbnail image, and the value is an object that contains other information about the thumbnail.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnails")]
        public virtual ThumbnailDetails Thumbnails { get; set; }

        /// <summary>The playlist's title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PlaylistStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The playlist's privacy status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privacyStatus")]
        public virtual string PrivacyStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A pair Property / Value.</summary>
    public class PropertyValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual string Property { get; set; }

        /// <summary>The property's value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class RelatedEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("entity")]
        public virtual Entity Entity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource id is a generic reference that points to another YouTube resource.</summary>
    public class ResourceId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The ID that YouTube uses to uniquely identify the referred resource, if that resource is a channel. This
        /// property is only present if the resourceId.kind value is youtube#channel.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelId")]
        public virtual string ChannelId { get; set; }

        /// <summary>The type of the API resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The ID that YouTube uses to uniquely identify the referred resource, if that resource is a playlist. This
        /// property is only present if the resourceId.kind value is youtube#playlist.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("playlistId")]
        public virtual string PlaylistId { get; set; }

        /// <summary>
        /// The ID that YouTube uses to uniquely identify the referred resource, if that resource is a video. This
        /// property is only present if the resourceId.kind value is youtube#video.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoId")]
        public virtual string VideoId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SearchListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Serialized EventId of the request which produced this response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        /// <summary>Pagination information for token pagination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<SearchResult> Items { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "youtube#searchListResponse".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The token that can be used as the value of the pageToken parameter to retrieve the next page in the result
        /// set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>General pagination information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageInfo")]
        public virtual PageInfo PageInfo { get; set; }

        /// <summary>
        /// The token that can be used as the value of the pageToken parameter to retrieve the previous page in the
        /// result set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prevPageToken")]
        public virtual string PrevPageToken { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("tokenPagination")]
        public virtual TokenPagination TokenPagination { get; set; }

        /// <summary>The visitorId identifies the visitor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visitorId")]
        public virtual string VisitorId { get; set; }
    }

    /// <summary>
    /// A search result contains information about a YouTube video, channel, or playlist that matches the search
    /// parameters specified in an API request. While a search result points to a uniquely identifiable resource, like a
    /// video, it does not have its own persistent data.
    /// </summary>
    public class SearchResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// The id object contains information that can be used to uniquely identify the resource that matches the
        /// search request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual ResourceId Id { get; set; }

        /// <summary>Identifies what kind of resource this is. Value: the fixed string "youtube#searchResult".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The snippet object contains basic details about a search result, such as its title or description. For
        /// example, if the search result is a video, then the title will be the video's title and the description will
        /// be the video's description.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
        public virtual SearchResultSnippet Snippet { get; set; }
    }

    /// <summary>
    /// Basic details about a search result, including title, description and thumbnails of the item referenced by the
    /// search result.
    /// </summary>
    public class SearchResultSnippet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The value that YouTube uses to uniquely identify the channel that published the resource that the search
        /// result identifies.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelId")]
        public virtual string ChannelId { get; set; }

        /// <summary>The title of the channel that published the resource that the search result identifies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelTitle")]
        public virtual string ChannelTitle { get; set; }

        /// <summary>A description of the search result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// It indicates if the resource (video or channel) has upcoming/active live broadcast content. Or it's "none"
        /// if there is not any upcoming/active live broadcasts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("liveBroadcastContent")]
        public virtual string LiveBroadcastContent { get; set; }

        /// <summary>The creation date and time of the resource that the search result identifies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishedAt")]
        public virtual string PublishedAtRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="PublishedAtRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> PublishedAt
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(PublishedAtRaw);
            set => PublishedAtRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// A map of thumbnail images associated with the search result. For each object in the map, the key is the name
        /// of the thumbnail image, and the value is an object that contains other information about the thumbnail.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnails")]
        public virtual ThumbnailDetails Thumbnails { get; set; }

        /// <summary>The title of the search result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A *subscription* resource contains information about a YouTube user subscription. A subscription notifies a user
    /// when new videos are added to a channel or when another user takes one of several actions on YouTube, such as
    /// uploading a video, rating a video, or commenting on a video.
    /// </summary>
    public class Subscription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The contentDetails object contains basic statistics about the subscription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentDetails")]
        public virtual SubscriptionContentDetails ContentDetails { get; set; }

        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The ID that YouTube uses to uniquely identify the subscription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Identifies what kind of resource this is. Value: the fixed string "youtube#subscription".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The snippet object contains basic details about the subscription, including its title and the channel that
        /// the user subscribed to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
        public virtual SubscriptionSnippet Snippet { get; set; }

        /// <summary>The subscriberSnippet object contains basic details about the subscriber.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriberSnippet")]
        public virtual SubscriptionSubscriberSnippet SubscriberSnippet { get; set; }
    }

    /// <summary>Details about the content to witch a subscription refers.</summary>
    public class SubscriptionContentDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of activity this subscription is for (only uploads, everything).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activityType")]
        public virtual string ActivityType { get; set; }

        /// <summary>The number of new items in the subscription since its content was last read.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newItemCount")]
        public virtual System.Nullable<long> NewItemCount { get; set; }

        /// <summary>The approximate number of items that the subscription points to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalItemCount")]
        public virtual System.Nullable<long> TotalItemCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SubscriptionListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Serialized EventId of the request which produced this response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        /// <summary>A list of subscriptions that match the request criteria.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Subscription> Items { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "youtube#subscriptionListResponse".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The token that can be used as the value of the pageToken parameter to retrieve the next page in the result
        /// set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("pageInfo")]
        public virtual PageInfo PageInfo { get; set; }

        /// <summary>
        /// The token that can be used as the value of the pageToken parameter to retrieve the previous page in the
        /// result set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prevPageToken")]
        public virtual string PrevPageToken { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("tokenPagination")]
        public virtual TokenPagination TokenPagination { get; set; }

        /// <summary>The visitorId identifies the visitor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visitorId")]
        public virtual string VisitorId { get; set; }
    }

    /// <summary>
    /// Basic details about a subscription, including title, description and thumbnails of the subscribed item.
    /// </summary>
    public class SubscriptionSnippet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID that YouTube uses to uniquely identify the subscriber's channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelId")]
        public virtual string ChannelId { get; set; }

        /// <summary>Channel title for the channel that the subscription belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelTitle")]
        public virtual string ChannelTitle { get; set; }

        /// <summary>The subscription's details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The date and time that the subscription was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishedAt")]
        public virtual string PublishedAtRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="PublishedAtRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> PublishedAt
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(PublishedAtRaw);
            set => PublishedAtRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>The id object contains information about the channel that the user subscribed to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual ResourceId ResourceId { get; set; }

        /// <summary>
        /// A map of thumbnail images associated with the video. For each object in the map, the key is the name of the
        /// thumbnail image, and the value is an object that contains other information about the thumbnail.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnails")]
        public virtual ThumbnailDetails Thumbnails { get; set; }

        /// <summary>The subscription's title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Basic details about a subscription's subscriber including title, description, channel ID and thumbnails.
    /// </summary>
    public class SubscriptionSubscriberSnippet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The channel ID of the subscriber.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelId")]
        public virtual string ChannelId { get; set; }

        /// <summary>The description of the subscriber.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Thumbnails for this subscriber.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnails")]
        public virtual ThumbnailDetails Thumbnails { get; set; }

        /// <summary>The title of the subscriber.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A `__superChatEvent__` resource represents a Super Chat purchase on a YouTube channel.</summary>
    public class SuperChatEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The ID that YouTube assigns to uniquely identify the Super Chat event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string `"youtube#superChatEvent"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The `snippet` object contains basic details about the Super Chat event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
        public virtual SuperChatEventSnippet Snippet { get; set; }
    }

    public class SuperChatEventListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Serialized EventId of the request which produced this response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        /// <summary>A list of Super Chat purchases that match the request criteria.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<SuperChatEvent> Items { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "youtube#superChatEventListResponse".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The token that can be used as the value of the pageToken parameter to retrieve the next page in the result
        /// set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("pageInfo")]
        public virtual PageInfo PageInfo { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("tokenPagination")]
        public virtual TokenPagination TokenPagination { get; set; }

        /// <summary>The visitorId identifies the visitor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visitorId")]
        public virtual string VisitorId { get; set; }
    }

    public class SuperChatEventSnippet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The purchase amount, in micros of the purchase currency. e.g., 1 is represented as 1000000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amountMicros")]
        public virtual System.Nullable<ulong> AmountMicros { get; set; }

        /// <summary>Channel id where the event occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelId")]
        public virtual string ChannelId { get; set; }

        /// <summary>The text contents of the comment left by the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commentText")]
        public virtual string CommentText { get; set; }

        /// <summary>The date and time when the event occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createdAt")]
        public virtual string CreatedAtRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="CreatedAtRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> CreatedAt
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(CreatedAtRaw);
            set => CreatedAtRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>The currency in which the purchase was made. ISO 4217.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currency")]
        public virtual string Currency { get; set; }

        /// <summary>
        /// A rendered string that displays the purchase amount and currency (e.g., "$1.00"). The string is rendered for
        /// the given language.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayString")]
        public virtual string DisplayString { get; set; }

        /// <summary>True if this event is a Super Sticker event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isSuperStickerEvent")]
        public virtual System.Nullable<bool> IsSuperStickerEvent { get; set; }

        /// <summary>
        /// The tier for the paid message, which is based on the amount of money spent to purchase the message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageType")]
        public virtual System.Nullable<long> MessageType { get; set; }

        /// <summary>
        /// If this event is a Super Sticker event, this field will contain metadata about the Super Sticker.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("superStickerMetadata")]
        public virtual SuperStickerMetadata SuperStickerMetadata { get; set; }

        /// <summary>Details about the supporter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supporterDetails")]
        public virtual ChannelProfileDetails SupporterDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SuperStickerMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Internationalized alt text that describes the sticker image and any animation associated with it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("altText")]
        public virtual string AltText { get; set; }

        /// <summary>Specifies the localization language in which the alt text is returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("altTextLanguage")]
        public virtual string AltTextLanguage { get; set; }

        /// <summary>
        /// Unique identifier of the Super Sticker. This is a shorter form of the alt_text that includes pack name and a
        /// recognizable characteristic of the sticker.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stickerId")]
        public virtual string StickerId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class TestItem : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("featuredPart")]
        public virtual System.Nullable<bool> FeaturedPart { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("gaia")]
        public virtual System.Nullable<long> Gaia { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
        public virtual TestItemTestItemSnippet Snippet { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class TestItemTestItemSnippet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A *third party account link* resource represents a link between a YouTube account or a channel and an account on
    /// a third-party service.
    /// </summary>
    public class ThirdPartyLink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of this resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "youtube#thirdPartyLink".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The linking_token identifies a YouTube account and channel with which the third party account is linked.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkingToken")]
        public virtual string LinkingToken { get; set; }

        /// <summary>The snippet object contains basic details about the third- party account link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
        public virtual ThirdPartyLinkSnippet Snippet { get; set; }

        /// <summary>The status object contains information about the status of the link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual ThirdPartyLinkStatus Status { get; set; }
    }

    /// <summary>
    /// Basic information about a third party account link, including its type and type-specific information.
    /// </summary>
    public class ThirdPartyLinkSnippet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Information specific to a link between a channel and a store on a merchandising platform.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelToStoreLink")]
        public virtual ChannelToStoreLinkDetails ChannelToStoreLink { get; set; }

        /// <summary>Type of the link named after the entities that are being linked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The third-party link status object contains information about the status of the link.</summary>
    public class ThirdPartyLinkStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("linkStatus")]
        public virtual string LinkStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A thumbnail is an image representing a YouTube resource.</summary>
    public class Thumbnail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>(Optional) Height of the thumbnail image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual System.Nullable<long> Height { get; set; }

        /// <summary>The thumbnail image's URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>(Optional) Width of the thumbnail image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<long> Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Internal representation of thumbnails for a YouTube resource.</summary>
    public class ThumbnailDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The default image for this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("default")]
        public virtual Thumbnail Default__ { get; set; }

        /// <summary>The high quality image for this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("high")]
        public virtual Thumbnail High { get; set; }

        /// <summary>The maximum resolution quality image for this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxres")]
        public virtual Thumbnail Maxres { get; set; }

        /// <summary>The medium quality image for this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("medium")]
        public virtual Thumbnail Medium { get; set; }

        /// <summary>The standard quality image for this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("standard")]
        public virtual Thumbnail Standard { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ThumbnailSetResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Serialized EventId of the request which produced this response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        /// <summary>A list of thumbnails.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<ThumbnailDetails> Items { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "youtube#thumbnailSetResponse".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The visitorId identifies the visitor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visitorId")]
        public virtual string VisitorId { get; set; }
    }

    /// <summary>Stub token pagination template to suppress results.</summary>
    public class TokenPagination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A *video* resource represents a YouTube video.</summary>
    public class Video : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Age restriction details related to a video. This data can only be retrieved by the video owner.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ageGating")]
        public virtual VideoAgeGating AgeGating { get; set; }

        /// <summary>
        /// The contentDetails object contains information about the video content, including the length of the video
        /// and its aspect ratio.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentDetails")]
        public virtual VideoContentDetails ContentDetails { get; set; }

        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// The fileDetails object encapsulates information about the video file that was uploaded to YouTube, including
        /// the file's resolution, duration, audio and video codecs, stream bitrates, and more. This data can only be
        /// retrieved by the video owner.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileDetails")]
        public virtual VideoFileDetails FileDetails { get; set; }

        /// <summary>The ID that YouTube uses to uniquely identify the video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Identifies what kind of resource this is. Value: the fixed string "youtube#video".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The liveStreamingDetails object contains metadata about a live video broadcast. The object will only be
        /// present in a video resource if the video is an upcoming, live, or completed live broadcast.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("liveStreamingDetails")]
        public virtual VideoLiveStreamingDetails LiveStreamingDetails { get; set; }

        /// <summary>
        /// The localizations object contains localized versions of the basic details about the video, such as its title
        /// and description.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizations")]
        public virtual System.Collections.Generic.IDictionary<string, VideoLocalization> Localizations { get; set; }

        /// <summary>
        /// The monetizationDetails object encapsulates information about the monetization status of the video.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monetizationDetails")]
        public virtual VideoMonetizationDetails MonetizationDetails { get; set; }

        /// <summary>
        /// The player object contains information that you would use to play the video in an embedded player.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("player")]
        public virtual VideoPlayer Player { get; set; }

        /// <summary>
        /// The processingDetails object encapsulates information about YouTube's progress in processing the uploaded
        /// video file. The properties in the object identify the current processing status and an estimate of the time
        /// remaining until YouTube finishes processing the video. This part also indicates whether different types of
        /// data or content, such as file details or thumbnail images, are available for the video. The
        /// processingProgress object is designed to be polled so that the video uploaded can track the progress that
        /// YouTube has made in processing the uploaded video file. This data can only be retrieved by the video owner.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processingDetails")]
        public virtual VideoProcessingDetails ProcessingDetails { get; set; }

        /// <summary>
        /// The projectDetails object contains information about the project specific video metadata. b/157517979: This
        /// part was never populated after it was added. However, it sees non-zero traffic because there is generated
        /// client code in the wild that refers to it [1]. We keep this field and do NOT remove it because otherwise V3
        /// would return an error when this part gets requested [2]. [1]
        /// https://developers.google.com/resources/api-libraries/documentation/youtube/v3/csharp/latest/classGoogle_1_1Apis_1_1YouTube_1_1v3_1_1Data_1_1VideoProjectDetails.html
        /// [2] http://google3/video/youtube/src/python/servers/data_api/common.py?l=1565-1569&amp;amp;rcl=344141677
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectDetails")]
        public virtual VideoProjectDetails ProjectDetails { get; set; }

        /// <summary>
        /// The recordingDetails object encapsulates information about the location, date and address where the video
        /// was recorded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordingDetails")]
        public virtual VideoRecordingDetails RecordingDetails { get; set; }

        /// <summary>
        /// The snippet object contains basic details about the video, such as its title, description, and category.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
        public virtual VideoSnippet Snippet { get; set; }

        /// <summary>The statistics object contains statistics about the video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statistics")]
        public virtual VideoStatistics Statistics { get; set; }

        /// <summary>
        /// The status object contains information about the video's uploading, processing, and privacy statuses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual VideoStatus Status { get; set; }

        /// <summary>
        /// The suggestions object encapsulates suggestions that identify opportunities to improve the video quality or
        /// the metadata for the uploaded video. This data can only be retrieved by the video owner.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestions")]
        public virtual VideoSuggestions Suggestions { get; set; }

        /// <summary>
        /// The topicDetails object encapsulates information about Freebase topics associated with the video.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topicDetails")]
        public virtual VideoTopicDetails TopicDetails { get; set; }
    }

    public class VideoAbuseReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional comments regarding the abuse report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("comments")]
        public virtual string Comments { get; set; }

        /// <summary>The language that the content was viewed in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("language")]
        public virtual string Language { get; set; }

        /// <summary>
        /// The high-level, or primary, reason that the content is abusive. The value is an abuse report reason ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reasonId")]
        public virtual string ReasonId { get; set; }

        /// <summary>
        /// The specific, or secondary, reason that this content is abusive (if available). The value is an abuse report
        /// reason ID that is a valid secondary reason for the primary reason.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondaryReasonId")]
        public virtual string SecondaryReasonId { get; set; }

        /// <summary>The ID that YouTube uses to uniquely identify the video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoId")]
        public virtual string VideoId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A `__videoAbuseReportReason__` resource identifies a reason that a video could be reported as abusive. Video
    /// abuse report reasons are used with `video.ReportAbuse`.
    /// </summary>
    public class VideoAbuseReportReason : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The ID of this abuse report reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string `"youtube#videoAbuseReportReason"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The `snippet` object contains basic details about the abuse report reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
        public virtual VideoAbuseReportReasonSnippet Snippet { get; set; }
    }

    public class VideoAbuseReportReasonListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Serialized EventId of the request which produced this response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        /// <summary>A list of valid abuse reasons that are used with `video.ReportAbuse`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<VideoAbuseReportReason> Items { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string
        /// `"youtube#videoAbuseReportReasonListResponse"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The `visitorId` identifies the visitor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visitorId")]
        public virtual string VisitorId { get; set; }
    }

    /// <summary>Basic details about a video category, such as its localized title.</summary>
    public class VideoAbuseReportReasonSnippet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The localized label belonging to this abuse report reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>
        /// The secondary reasons associated with this reason, if any are available. (There might be 0 or more.)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondaryReasons")]
        public virtual System.Collections.Generic.IList<VideoAbuseReportSecondaryReason> SecondaryReasons { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class VideoAbuseReportSecondaryReason : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of this abuse report secondary reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The localized label for this abuse report secondary reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class VideoAgeGating : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Indicates whether or not the video has alcoholic beverage content. Only users of legal purchasing age in a
        /// particular country, as identified by ICAP, can view the content.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alcoholContent")]
        public virtual System.Nullable<bool> AlcoholContent { get; set; }

        /// <summary>
        /// Age-restricted trailers. For redband trailers and adult-rated video-games. Only users aged 18+ can view the
        /// content. The the field is true the content is restricted to viewers aged 18+. Otherwise The field won't be
        /// present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restricted")]
        public virtual System.Nullable<bool> Restricted { get; set; }

        /// <summary>Video game rating, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoGameRating")]
        public virtual string VideoGameRating { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A *videoCategory* resource identifies a category that has been or could be associated with uploaded videos.
    /// </summary>
    public class VideoCategory : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The ID that YouTube uses to uniquely identify the video category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "youtube#videoCategory".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The snippet object contains basic details about the video category, including its title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
        public virtual VideoCategorySnippet Snippet { get; set; }
    }

    public class VideoCategoryListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Serialized EventId of the request which produced this response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        /// <summary>
        /// A list of video categories that can be associated with YouTube videos. In this map, the video category ID is
        /// the map key, and its value is the corresponding videoCategory resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<VideoCategory> Items { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "youtube#videoCategoryListResponse".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The token that can be used as the value of the pageToken parameter to retrieve the next page in the result
        /// set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>General pagination information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageInfo")]
        public virtual PageInfo PageInfo { get; set; }

        /// <summary>
        /// The token that can be used as the value of the pageToken parameter to retrieve the previous page in the
        /// result set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prevPageToken")]
        public virtual string PrevPageToken { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("tokenPagination")]
        public virtual TokenPagination TokenPagination { get; set; }

        /// <summary>The visitorId identifies the visitor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visitorId")]
        public virtual string VisitorId { get; set; }
    }

    /// <summary>Basic details about a video category, such as its localized title.</summary>
    public class VideoCategorySnippet : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("assignable")]
        public virtual System.Nullable<bool> Assignable { get; set; }

        /// <summary>The YouTube channel that created the video category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelId")]
        public virtual string ChannelId { get; set; }

        /// <summary>The video category's title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about the content of a YouTube Video.</summary>
    public class VideoContentDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The value of captions indicates whether the video has captions or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caption")]
        public virtual string Caption { get; set; }

        /// <summary>Specifies the ratings that the video received under various rating schemes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentRating")]
        public virtual ContentRating ContentRating { get; set; }

        /// <summary>
        /// The countryRestriction object contains information about the countries where a video is (or is not)
        /// viewable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countryRestriction")]
        public virtual AccessPolicy CountryRestriction { get; set; }

        /// <summary>
        /// The value of definition indicates whether the video is available in high definition or only in standard
        /// definition.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("definition")]
        public virtual string Definition { get; set; }

        /// <summary>The value of dimension indicates whether the video is available in 3D or in 2D.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimension")]
        public virtual string Dimension { get; set; }

        /// <summary>
        /// The length of the video. The tag value is an ISO 8601 duration in the format PT#M#S, in which the letters PT
        /// indicate that the value specifies a period of time, and the letters M and S refer to length in minutes and
        /// seconds, respectively. The # characters preceding the M and S letters are both integers that specify the
        /// number of minutes (or seconds) of the video. For example, a value of PT15M51S indicates that the video is 15
        /// minutes and 51 seconds long.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual string Duration { get; set; }

        /// <summary>
        /// Indicates whether the video uploader has provided a custom thumbnail image for the video. This property is
        /// only visible to the video uploader.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasCustomThumbnail")]
        public virtual System.Nullable<bool> HasCustomThumbnail { get; set; }

        /// <summary>The value of is_license_content indicates whether the video is licensed content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("licensedContent")]
        public virtual System.Nullable<bool> LicensedContent { get; set; }

        /// <summary>Specifies the projection format of the video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projection")]
        public virtual string Projection { get; set; }

        /// <summary>
        /// The regionRestriction object contains information about the countries where a video is (or is not) viewable.
        /// The object will contain either the contentDetails.regionRestriction.allowed property or the
        /// contentDetails.regionRestriction.blocked property.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionRestriction")]
        public virtual VideoContentDetailsRegionRestriction RegionRestriction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>DEPRECATED Region restriction of the video.</summary>
    public class VideoContentDetailsRegionRestriction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of region codes that identify countries where the video is viewable. If this property is present and
        /// a country is not listed in its value, then the video is blocked from appearing in that country. If this
        /// property is present and contains an empty list, the video is blocked in all countries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowed")]
        public virtual System.Collections.Generic.IList<string> Allowed { get; set; }

        /// <summary>
        /// A list of region codes that identify countries where the video is blocked. If this property is present and a
        /// country is not listed in its value, then the video is viewable in that country. If this property is present
        /// and contains an empty list, the video is viewable in all countries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blocked")]
        public virtual System.Collections.Generic.IList<string> Blocked { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Describes original video file properties, including technical details about audio and video streams, but also
    /// metadata information like content length, digitization time, or geotagging information.
    /// </summary>
    public class VideoFileDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of audio streams contained in the uploaded video file. Each item in the list contains detailed
        /// metadata about an audio stream.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audioStreams")]
        public virtual System.Collections.Generic.IList<VideoFileDetailsAudioStream> AudioStreams { get; set; }

        /// <summary>The uploaded video file's combined (video and audio) bitrate in bits per second.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bitrateBps")]
        public virtual System.Nullable<ulong> BitrateBps { get; set; }

        /// <summary>The uploaded video file's container format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("container")]
        public virtual string Container { get; set; }

        /// <summary>
        /// The date and time when the uploaded video file was created. The value is specified in ISO 8601 format.
        /// Currently, the following ISO 8601 formats are supported: - Date only: YYYY-MM-DD - Naive time:
        /// YYYY-MM-DDTHH:MM:SS - Time with timezone: YYYY-MM-DDTHH:MM:SS+HH:MM
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual string CreationTime { get; set; }

        /// <summary>The length of the uploaded video in milliseconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("durationMs")]
        public virtual System.Nullable<ulong> DurationMs { get; set; }

        /// <summary>
        /// The uploaded file's name. This field is present whether a video file or another type of file was uploaded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileName")]
        public virtual string FileName { get; set; }

        /// <summary>
        /// The uploaded file's size in bytes. This field is present whether a video file or another type of file was
        /// uploaded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileSize")]
        public virtual System.Nullable<ulong> FileSize { get; set; }

        /// <summary>
        /// The uploaded file's type as detected by YouTube's video processing engine. Currently, YouTube only processes
        /// video files, but this field is present whether a video file or another type of file was uploaded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileType")]
        public virtual string FileType { get; set; }

        /// <summary>
        /// A list of video streams contained in the uploaded video file. Each item in the list contains detailed
        /// metadata about a video stream.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoStreams")]
        public virtual System.Collections.Generic.IList<VideoFileDetailsVideoStream> VideoStreams { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about an audio stream.</summary>
    public class VideoFileDetailsAudioStream : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The audio stream's bitrate, in bits per second.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bitrateBps")]
        public virtual System.Nullable<ulong> BitrateBps { get; set; }

        /// <summary>The number of audio channels that the stream contains.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelCount")]
        public virtual System.Nullable<long> ChannelCount { get; set; }

        /// <summary>The audio codec that the stream uses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("codec")]
        public virtual string Codec { get; set; }

        /// <summary>
        /// A value that uniquely identifies a video vendor. Typically, the value is a four-letter vendor code.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vendor")]
        public virtual string Vendor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a video stream.</summary>
    public class VideoFileDetailsVideoStream : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The video content's display aspect ratio, which specifies the aspect ratio in which the video should be
        /// displayed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aspectRatio")]
        public virtual System.Nullable<double> AspectRatio { get; set; }

        /// <summary>The video stream's bitrate, in bits per second.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bitrateBps")]
        public virtual System.Nullable<ulong> BitrateBps { get; set; }

        /// <summary>The video codec that the stream uses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("codec")]
        public virtual string Codec { get; set; }

        /// <summary>The video stream's frame rate, in frames per second.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frameRateFps")]
        public virtual System.Nullable<double> FrameRateFps { get; set; }

        /// <summary>The encoded video content's height in pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heightPixels")]
        public virtual System.Nullable<long> HeightPixels { get; set; }

        /// <summary>
        /// The amount that YouTube needs to rotate the original source content to properly display the video.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rotation")]
        public virtual string Rotation { get; set; }

        /// <summary>
        /// A value that uniquely identifies a video vendor. Typically, the value is a four-letter vendor code.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vendor")]
        public virtual string Vendor { get; set; }

        /// <summary>
        /// The encoded video content's width in pixels. You can calculate the video's encoding aspect ratio as
        /// width_pixels / height_pixels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("widthPixels")]
        public virtual System.Nullable<long> WidthPixels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class VideoGetRatingResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Serialized EventId of the request which produced this response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        /// <summary>A list of ratings that match the request criteria.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<VideoRating> Items { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "youtube#videoGetRatingResponse".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The visitorId identifies the visitor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visitorId")]
        public virtual string VisitorId { get; set; }
    }

    public class VideoListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Serialized EventId of the request which produced this response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Video> Items { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "youtube#videoListResponse".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The token that can be used as the value of the pageToken parameter to retrieve the next page in the result
        /// set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>General pagination information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageInfo")]
        public virtual PageInfo PageInfo { get; set; }

        /// <summary>
        /// The token that can be used as the value of the pageToken parameter to retrieve the previous page in the
        /// result set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prevPageToken")]
        public virtual string PrevPageToken { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("tokenPagination")]
        public virtual TokenPagination TokenPagination { get; set; }

        /// <summary>The visitorId identifies the visitor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visitorId")]
        public virtual string VisitorId { get; set; }
    }

    /// <summary>Details about the live streaming metadata.</summary>
    public class VideoLiveStreamingDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The ID of the currently active live chat attached to this video. This field is filled only if the video is a
        /// currently live broadcast that has live chat. Once the broadcast transitions to complete this field will be
        /// removed and the live chat closed down. For persistent broadcasts that live chat id will no longer be tied to
        /// this video but rather to the new video being displayed at the persistent page.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeLiveChatId")]
        public virtual string ActiveLiveChatId { get; set; }

        /// <summary>
        /// The time that the broadcast actually ended. This value will not be available until the broadcast is over.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actualEndTime")]
        public virtual string ActualEndTimeRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="ActualEndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> ActualEndTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(ActualEndTimeRaw);
            set => ActualEndTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// The time that the broadcast actually started. This value will not be available until the broadcast begins.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actualStartTime")]
        public virtual string ActualStartTimeRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="ActualStartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> ActualStartTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(ActualStartTimeRaw);
            set => ActualStartTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// The number of viewers currently watching the broadcast. The property and its value will be present if the
        /// broadcast has current viewers and the broadcast owner has not hidden the viewcount for the video. Note that
        /// YouTube stops tracking the number of concurrent viewers for a broadcast when the broadcast ends. So, this
        /// property would not identify the number of viewers watching an archived video of a live broadcast that
        /// already ended.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("concurrentViewers")]
        public virtual System.Nullable<ulong> ConcurrentViewers { get; set; }

        /// <summary>
        /// The time that the broadcast is scheduled to end. If the value is empty or the property is not present, then
        /// the broadcast is scheduled to contiue indefinitely.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduledEndTime")]
        public virtual string ScheduledEndTimeRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="ScheduledEndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> ScheduledEndTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(ScheduledEndTimeRaw);
            set => ScheduledEndTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>The time that the broadcast is scheduled to begin.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduledStartTime")]
        public virtual string ScheduledStartTimeRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="ScheduledStartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> ScheduledStartTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(ScheduledStartTimeRaw);
            set => ScheduledStartTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Localized versions of certain video properties (e.g. title).</summary>
    public class VideoLocalization : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Localized version of the video's description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Localized version of the video's title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about monetization of a YouTube Video.</summary>
    public class VideoMonetizationDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The value of access indicates whether the video can be monetized or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("access")]
        public virtual AccessPolicy Access { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Player to be used for a video playback.</summary>
    public class VideoPlayer : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("embedHeight")]
        public virtual System.Nullable<long> EmbedHeight { get; set; }

        /// <summary>An &lt;iframe&gt; tag that embeds a player that will play the video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("embedHtml")]
        public virtual string EmbedHtml { get; set; }

        /// <summary>The embed width</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("embedWidth")]
        public virtual System.Nullable<long> EmbedWidth { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes processing status and progress and availability of some other Video resource parts.</summary>
    public class VideoProcessingDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This value indicates whether video editing suggestions, which might improve video quality or the playback
        /// experience, are available for the video. You can retrieve these suggestions by requesting the suggestions
        /// part in your videos.list() request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("editorSuggestionsAvailability")]
        public virtual string EditorSuggestionsAvailability { get; set; }

        /// <summary>
        /// This value indicates whether file details are available for the uploaded video. You can retrieve a video's
        /// file details by requesting the fileDetails part in your videos.list() request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileDetailsAvailability")]
        public virtual string FileDetailsAvailability { get; set; }

        /// <summary>
        /// The reason that YouTube failed to process the video. This property will only have a value if the
        /// processingStatus property's value is failed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processingFailureReason")]
        public virtual string ProcessingFailureReason { get; set; }

        /// <summary>
        /// This value indicates whether the video processing engine has generated suggestions that might improve
        /// YouTube's ability to process the the video, warnings that explain video processing problems, or errors that
        /// cause video processing problems. You can retrieve these suggestions by requesting the suggestions part in
        /// your videos.list() request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processingIssuesAvailability")]
        public virtual string ProcessingIssuesAvailability { get; set; }

        /// <summary>
        /// The processingProgress object contains information about the progress YouTube has made in processing the
        /// video. The values are really only relevant if the video's processing status is processing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processingProgress")]
        public virtual VideoProcessingDetailsProcessingProgress ProcessingProgress { get; set; }

        /// <summary>
        /// The video's processing status. This value indicates whether YouTube was able to process the video or if the
        /// video is still being processed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processingStatus")]
        public virtual string ProcessingStatus { get; set; }

        /// <summary>
        /// This value indicates whether keyword (tag) suggestions are available for the video. Tags can be added to a
        /// video's metadata to make it easier for other users to find the video. You can retrieve these suggestions by
        /// requesting the suggestions part in your videos.list() request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagSuggestionsAvailability")]
        public virtual string TagSuggestionsAvailability { get; set; }

        /// <summary>This value indicates whether thumbnail images have been generated for the video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnailsAvailability")]
        public virtual string ThumbnailsAvailability { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Video processing progress and completion time estimate.</summary>
    public class VideoProcessingDetailsProcessingProgress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The number of parts of the video that YouTube has already processed. You can estimate the percentage of the
        /// video that YouTube has already processed by calculating: 100 * parts_processed / parts_total Note that since
        /// the estimated number of parts could increase without a corresponding increase in the number of parts that
        /// have already been processed, it is possible that the calculated progress could periodically decrease while
        /// YouTube processes a video.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partsProcessed")]
        public virtual System.Nullable<ulong> PartsProcessed { get; set; }

        /// <summary>
        /// An estimate of the total number of parts that need to be processed for the video. The number may be updated
        /// with more precise estimates while YouTube processes the video.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partsTotal")]
        public virtual System.Nullable<ulong> PartsTotal { get; set; }

        /// <summary>
        /// An estimate of the amount of time, in millseconds, that YouTube needs to finish processing the video.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeLeftMs")]
        public virtual System.Nullable<ulong> TimeLeftMs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// DEPRECATED. b/157517979: This part was never populated after it was added. However, it sees non-zero traffic
    /// because there is generated client code in the wild that refers to it [1]. We keep this field and do NOT remove
    /// it because otherwise V3 would return an error when this part gets requested [2]. [1]
    /// https://developers.google.com/resources/api-libraries/documentation/youtube/v3/csharp/latest/classGoogle_1_1Apis_1_1YouTube_1_1v3_1_1Data_1_1VideoProjectDetails.html
    /// [2] http://google3/video/youtube/src/python/servers/data_api/common.py?l=1565-1569&amp;amp;rcl=344141677
    /// </summary>
    public class VideoProjectDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Basic details about rating of a video.</summary>
    public class VideoRating : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Rating of a video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rating")]
        public virtual string Rating { get; set; }

        /// <summary>The ID that YouTube uses to uniquely identify the video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoId")]
        public virtual string VideoId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Recording information associated with the video.</summary>
    public class VideoRecordingDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The geolocation information associated with the video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual GeoPoint Location { get; set; }

        /// <summary>The text description of the location where the video was recorded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationDescription")]
        public virtual string LocationDescription { get; set; }

        /// <summary>The date and time when the video was recorded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordingDate")]
        public virtual string RecordingDateRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="RecordingDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> RecordingDate
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(RecordingDateRaw);
            set => RecordingDateRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Basic details about a video, including title, description, uploader, thumbnails and category.</summary>
    public class VideoSnippet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The YouTube video category associated with the video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryId")]
        public virtual string CategoryId { get; set; }

        /// <summary>The ID that YouTube uses to uniquely identify the channel that the video was uploaded to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelId")]
        public virtual string ChannelId { get; set; }

        /// <summary>Channel title for the channel that the video belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelTitle")]
        public virtual string ChannelTitle { get; set; }

        /// <summary>
        /// The default_audio_language property specifies the language spoken in the video's default audio track.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultAudioLanguage")]
        public virtual string DefaultAudioLanguage { get; set; }

        /// <summary>The language of the videos's default snippet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultLanguage")]
        public virtual string DefaultLanguage { get; set; }

        /// <summary>The video's description. @mutable youtube.videos.insert youtube.videos.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Indicates if the video is an upcoming/active live broadcast. Or it's "none" if the video is not an
        /// upcoming/active live broadcast.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("liveBroadcastContent")]
        public virtual string LiveBroadcastContent { get; set; }

        /// <summary>
        /// Localized snippet selected with the hl parameter. If no such localization exists, this field is populated
        /// with the default snippet. (Read-only)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localized")]
        public virtual VideoLocalization Localized { get; set; }

        /// <summary>The date and time when the video was uploaded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishedAt")]
        public virtual string PublishedAtRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="PublishedAtRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> PublishedAt
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(PublishedAtRaw);
            set => PublishedAtRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>A list of keyword tags associated with the video. Tags may contain spaces.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// A map of thumbnail images associated with the video. For each object in the map, the key is the name of the
        /// thumbnail image, and the value is an object that contains other information about the thumbnail.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnails")]
        public virtual ThumbnailDetails Thumbnails { get; set; }

        /// <summary>The video's title. @mutable youtube.videos.insert youtube.videos.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Statistics about the video, such as the number of times the video was viewed or liked.</summary>
    public class VideoStatistics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of comments for the video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commentCount")]
        public virtual System.Nullable<ulong> CommentCount { get; set; }

        /// <summary>
        /// The number of users who have indicated that they disliked the video by giving it a negative rating.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dislikeCount")]
        public virtual System.Nullable<ulong> DislikeCount { get; set; }

        /// <summary>The number of users who currently have the video marked as a favorite video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("favoriteCount")]
        public virtual System.Nullable<ulong> FavoriteCount { get; set; }

        /// <summary>
        /// The number of users who have indicated that they liked the video by giving it a positive rating.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("likeCount")]
        public virtual System.Nullable<ulong> LikeCount { get; set; }

        /// <summary>The number of times the video has been viewed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewCount")]
        public virtual System.Nullable<ulong> ViewCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Basic details about a video category, such as its localized title. Next Id: 17</summary>
    public class VideoStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This value indicates if the video can be embedded on another website. @mutable youtube.videos.insert
        /// youtube.videos.update
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("embeddable")]
        public virtual System.Nullable<bool> Embeddable { get; set; }

        /// <summary>
        /// This value explains why a video failed to upload. This property is only present if the uploadStatus property
        /// indicates that the upload failed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureReason")]
        public virtual string FailureReason { get; set; }

        /// <summary>The video's license. @mutable youtube.videos.insert youtube.videos.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("license")]
        public virtual string License { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("madeForKids")]
        public virtual System.Nullable<bool> MadeForKids { get; set; }

        /// <summary>The video's privacy status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privacyStatus")]
        public virtual string PrivacyStatus { get; set; }

        /// <summary>
        /// This value indicates if the extended video statistics on the watch page can be viewed by everyone. Note that
        /// the view count, likes, etc will still be visible if this is disabled. @mutable youtube.videos.insert
        /// youtube.videos.update
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicStatsViewable")]
        public virtual System.Nullable<bool> PublicStatsViewable { get; set; }

        /// <summary>
        /// The date and time when the video is scheduled to publish. It can be set only if the privacy status of the
        /// video is private..
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishAt")]
        public virtual string PublishAtRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="PublishAtRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> PublishAt
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(PublishAtRaw);
            set => PublishAtRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// This value explains why YouTube rejected an uploaded video. This property is only present if the
        /// uploadStatus property indicates that the upload was rejected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rejectionReason")]
        public virtual string RejectionReason { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("selfDeclaredMadeForKids")]
        public virtual System.Nullable<bool> SelfDeclaredMadeForKids { get; set; }

        /// <summary>The status of the uploaded video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uploadStatus")]
        public virtual string UploadStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies suggestions on how to improve video content, including encoding hints, tag suggestions, and editor
    /// suggestions.
    /// </summary>
    public class VideoSuggestions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of video editing operations that might improve the video quality or playback experience of the
        /// uploaded video.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("editorSuggestions")]
        public virtual System.Collections.Generic.IList<string> EditorSuggestions { get; set; }

        /// <summary>
        /// A list of errors that will prevent YouTube from successfully processing the uploaded video video. These
        /// errors indicate that, regardless of the video's current processing status, eventually, that status will
        /// almost certainly be failed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processingErrors")]
        public virtual System.Collections.Generic.IList<string> ProcessingErrors { get; set; }

        /// <summary>A list of suggestions that may improve YouTube's ability to process the video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processingHints")]
        public virtual System.Collections.Generic.IList<string> ProcessingHints { get; set; }

        /// <summary>
        /// A list of reasons why YouTube may have difficulty transcoding the uploaded video or that might result in an
        /// erroneous transcoding. These warnings are generated before YouTube actually processes the uploaded video
        /// file. In addition, they identify issues that are unlikely to cause the video processing to fail but that
        /// might cause problems such as sync issues, video artifacts, or a missing audio track.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processingWarnings")]
        public virtual System.Collections.Generic.IList<string> ProcessingWarnings { get; set; }

        /// <summary>
        /// A list of keyword tags that could be added to the video's metadata to increase the likelihood that users
        /// will locate your video when searching or browsing on YouTube.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagSuggestions")]
        public virtual System.Collections.Generic.IList<VideoSuggestionsTagSuggestion> TagSuggestions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single tag suggestion with it's relevance information.</summary>
    public class VideoSuggestionsTagSuggestion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A set of video categories for which the tag is relevant. You can use this information to display appropriate
        /// tag suggestions based on the video category that the video uploader associates with the video. By default,
        /// tag suggestions are relevant for all categories if there are no restricts defined for the keyword.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryRestricts")]
        public virtual System.Collections.Generic.IList<string> CategoryRestricts { get; set; }

        /// <summary>The keyword tag suggested for the video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tag")]
        public virtual string Tag { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Freebase topic information related to the video.</summary>
    public class VideoTopicDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Similar to topic_id, except that these topics are merely relevant to the video. These are topics that may be
        /// mentioned in, or appear in the video. You can retrieve information about each topic using Freebase Topic
        /// API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relevantTopicIds")]
        public virtual System.Collections.Generic.IList<string> RelevantTopicIds { get; set; }

        /// <summary>A list of Wikipedia URLs that provide a high-level description of the video's content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topicCategories")]
        public virtual System.Collections.Generic.IList<string> TopicCategories { get; set; }

        /// <summary>
        /// A list of Freebase topic IDs that are centrally associated with the video. These are topics that are
        /// centrally featured in the video, and it can be said that the video is mainly about each of these. You can
        /// retrieve information about each topic using the &amp;lt; a
        /// href="http://wiki.freebase.com/wiki/Topic_API"&amp;gt;Freebase Topic API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topicIds")]
        public virtual System.Collections.Generic.IList<string> TopicIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Branding properties for the watch. All deprecated.</summary>
    public class WatchSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The text color for the video watch page's branded area.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backgroundColor")]
        public virtual string BackgroundColor { get; set; }

        /// <summary>An ID that uniquely identifies a playlist that displays next to the video player.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("featuredPlaylistId")]
        public virtual string FeaturedPlaylistId { get; set; }

        /// <summary>The background color for the video watch page's branded area.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textColor")]
        public virtual string TextColor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
