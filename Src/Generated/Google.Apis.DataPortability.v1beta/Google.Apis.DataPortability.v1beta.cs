// Copyright 2024 Google LLC
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

namespace Google.Apis.DataPortability.v1beta
{
    /// <summary>The DataPortability Service.</summary>
    public class DataPortabilityService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DataPortabilityService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DataPortabilityService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            ArchiveJobs = new ArchiveJobsResource(this);
            Authorization = new AuthorizationResource(this);
            PortabilityArchive = new PortabilityArchiveResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "dataportability";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri => BaseUriOverride ?? "https://dataportability.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://dataportability.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Data Portability API.</summary>
        public class Scope
        {
            /// <summary>
            /// Move a copy of messages between you and the businesses you have conversations with across Google
            /// services.
            /// </summary>
            public static string DataportabilityBusinessmessagingConversations = "https://www.googleapis.com/auth/dataportability.businessmessaging.conversations";

            /// <summary>Move a copy of your pinned trips on Maps.</summary>
            public static string DataportabilityMapsCommuteRoutes = "https://www.googleapis.com/auth/dataportability.maps.commute_routes";

            /// <summary>Move a copy of your commute settings on Maps.</summary>
            public static string DataportabilityMapsCommuteSettings = "https://www.googleapis.com/auth/dataportability.maps.commute_settings";

            /// <summary>Move a copy of your electric vehicle profile on Maps.</summary>
            public static string DataportabilityMapsEvProfile = "https://www.googleapis.com/auth/dataportability.maps.ev_profile";

            /// <summary>Move a copy of your updates to places on Maps.</summary>
            public static string DataportabilityMapsOfferingContributions = "https://www.googleapis.com/auth/dataportability.maps.offering_contributions";

            /// <summary>Move a copy of the photos and videos you posted on Maps.</summary>
            public static string DataportabilityMapsPhotosVideos = "https://www.googleapis.com/auth/dataportability.maps.photos_videos";

            /// <summary>Move a copy of your reviews and posts on Maps.</summary>
            public static string DataportabilityMapsReviews = "https://www.googleapis.com/auth/dataportability.maps.reviews";

            /// <summary>Move a copy of your Starred places list on Maps.</summary>
            public static string DataportabilityMapsStarredPlaces = "https://www.googleapis.com/auth/dataportability.maps.starred_places";

            /// <summary>Move a copy of your Maps activity.</summary>
            public static string DataportabilityMyactivityMaps = "https://www.googleapis.com/auth/dataportability.myactivity.maps";

            /// <summary>Move a copy of your Google Search activity.</summary>
            public static string DataportabilityMyactivitySearch = "https://www.googleapis.com/auth/dataportability.myactivity.search";

            /// <summary>Move a copy of your Shopping activity.</summary>
            public static string DataportabilityMyactivityShopping = "https://www.googleapis.com/auth/dataportability.myactivity.shopping";

            /// <summary>Move a copy of your YouTube activity.</summary>
            public static string DataportabilityMyactivityYoutube = "https://www.googleapis.com/auth/dataportability.myactivity.youtube";

            /// <summary>Move a copy of your shipping information on Shopping.</summary>
            public static string DataportabilityShoppingAddresses = "https://www.googleapis.com/auth/dataportability.shopping.addresses";

            /// <summary>Move a copy of reviews you wrote about products or online stores on Google Search.</summary>
            public static string DataportabilityShoppingReviews = "https://www.googleapis.com/auth/dataportability.shopping.reviews";

            /// <summary>Move a copy of information about your YouTube channel.</summary>
            public static string DataportabilityYoutubeChannel = "https://www.googleapis.com/auth/dataportability.youtube.channel";

            /// <summary>Move a copy of your YouTube comments.</summary>
            public static string DataportabilityYoutubeComments = "https://www.googleapis.com/auth/dataportability.youtube.comments";

            /// <summary>Move a copy of your YouTube messages in live chat.</summary>
            public static string DataportabilityYoutubeLiveChat = "https://www.googleapis.com/auth/dataportability.youtube.live_chat";

            /// <summary>Move a copy of your uploaded YouTube music tracks and your YouTube music library.</summary>
            public static string DataportabilityYoutubeMusic = "https://www.googleapis.com/auth/dataportability.youtube.music";

            /// <summary>Move a copy of your YouTube private playlists.</summary>
            public static string DataportabilityYoutubePrivatePlaylists = "https://www.googleapis.com/auth/dataportability.youtube.private_playlists";

            /// <summary>Move a copy of your private YouTube videos and information about them.</summary>
            public static string DataportabilityYoutubePrivateVideos = "https://www.googleapis.com/auth/dataportability.youtube.private_videos";

            /// <summary>Move a copy of your public YouTube playlists.</summary>
            public static string DataportabilityYoutubePublicPlaylists = "https://www.googleapis.com/auth/dataportability.youtube.public_playlists";

            /// <summary>Move a copy of your public YouTube videos and information about them.</summary>
            public static string DataportabilityYoutubePublicVideos = "https://www.googleapis.com/auth/dataportability.youtube.public_videos";

            /// <summary>Move a copy of your YouTube shopping wishlists, and wishlist items.</summary>
            public static string DataportabilityYoutubeShopping = "https://www.googleapis.com/auth/dataportability.youtube.shopping";

            /// <summary>Move a copy of your YouTube channel subscriptions, even if they're private.</summary>
            public static string DataportabilityYoutubeSubscriptions = "https://www.googleapis.com/auth/dataportability.youtube.subscriptions";

            /// <summary>Move a copy of your unlisted YouTube playlists.</summary>
            public static string DataportabilityYoutubeUnlistedPlaylists = "https://www.googleapis.com/auth/dataportability.youtube.unlisted_playlists";

            /// <summary>Move a copy of your unlisted YouTube videos and information about them.</summary>
            public static string DataportabilityYoutubeUnlistedVideos = "https://www.googleapis.com/auth/dataportability.youtube.unlisted_videos";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Data Portability API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// Move a copy of messages between you and the businesses you have conversations with across Google
            /// services.
            /// </summary>
            public const string DataportabilityBusinessmessagingConversations = "https://www.googleapis.com/auth/dataportability.businessmessaging.conversations";

            /// <summary>Move a copy of your pinned trips on Maps.</summary>
            public const string DataportabilityMapsCommuteRoutes = "https://www.googleapis.com/auth/dataportability.maps.commute_routes";

            /// <summary>Move a copy of your commute settings on Maps.</summary>
            public const string DataportabilityMapsCommuteSettings = "https://www.googleapis.com/auth/dataportability.maps.commute_settings";

            /// <summary>Move a copy of your electric vehicle profile on Maps.</summary>
            public const string DataportabilityMapsEvProfile = "https://www.googleapis.com/auth/dataportability.maps.ev_profile";

            /// <summary>Move a copy of your updates to places on Maps.</summary>
            public const string DataportabilityMapsOfferingContributions = "https://www.googleapis.com/auth/dataportability.maps.offering_contributions";

            /// <summary>Move a copy of the photos and videos you posted on Maps.</summary>
            public const string DataportabilityMapsPhotosVideos = "https://www.googleapis.com/auth/dataportability.maps.photos_videos";

            /// <summary>Move a copy of your reviews and posts on Maps.</summary>
            public const string DataportabilityMapsReviews = "https://www.googleapis.com/auth/dataportability.maps.reviews";

            /// <summary>Move a copy of your Starred places list on Maps.</summary>
            public const string DataportabilityMapsStarredPlaces = "https://www.googleapis.com/auth/dataportability.maps.starred_places";

            /// <summary>Move a copy of your Maps activity.</summary>
            public const string DataportabilityMyactivityMaps = "https://www.googleapis.com/auth/dataportability.myactivity.maps";

            /// <summary>Move a copy of your Google Search activity.</summary>
            public const string DataportabilityMyactivitySearch = "https://www.googleapis.com/auth/dataportability.myactivity.search";

            /// <summary>Move a copy of your Shopping activity.</summary>
            public const string DataportabilityMyactivityShopping = "https://www.googleapis.com/auth/dataportability.myactivity.shopping";

            /// <summary>Move a copy of your YouTube activity.</summary>
            public const string DataportabilityMyactivityYoutube = "https://www.googleapis.com/auth/dataportability.myactivity.youtube";

            /// <summary>Move a copy of your shipping information on Shopping.</summary>
            public const string DataportabilityShoppingAddresses = "https://www.googleapis.com/auth/dataportability.shopping.addresses";

            /// <summary>Move a copy of reviews you wrote about products or online stores on Google Search.</summary>
            public const string DataportabilityShoppingReviews = "https://www.googleapis.com/auth/dataportability.shopping.reviews";

            /// <summary>Move a copy of information about your YouTube channel.</summary>
            public const string DataportabilityYoutubeChannel = "https://www.googleapis.com/auth/dataportability.youtube.channel";

            /// <summary>Move a copy of your YouTube comments.</summary>
            public const string DataportabilityYoutubeComments = "https://www.googleapis.com/auth/dataportability.youtube.comments";

            /// <summary>Move a copy of your YouTube messages in live chat.</summary>
            public const string DataportabilityYoutubeLiveChat = "https://www.googleapis.com/auth/dataportability.youtube.live_chat";

            /// <summary>Move a copy of your uploaded YouTube music tracks and your YouTube music library.</summary>
            public const string DataportabilityYoutubeMusic = "https://www.googleapis.com/auth/dataportability.youtube.music";

            /// <summary>Move a copy of your YouTube private playlists.</summary>
            public const string DataportabilityYoutubePrivatePlaylists = "https://www.googleapis.com/auth/dataportability.youtube.private_playlists";

            /// <summary>Move a copy of your private YouTube videos and information about them.</summary>
            public const string DataportabilityYoutubePrivateVideos = "https://www.googleapis.com/auth/dataportability.youtube.private_videos";

            /// <summary>Move a copy of your public YouTube playlists.</summary>
            public const string DataportabilityYoutubePublicPlaylists = "https://www.googleapis.com/auth/dataportability.youtube.public_playlists";

            /// <summary>Move a copy of your public YouTube videos and information about them.</summary>
            public const string DataportabilityYoutubePublicVideos = "https://www.googleapis.com/auth/dataportability.youtube.public_videos";

            /// <summary>Move a copy of your YouTube shopping wishlists, and wishlist items.</summary>
            public const string DataportabilityYoutubeShopping = "https://www.googleapis.com/auth/dataportability.youtube.shopping";

            /// <summary>Move a copy of your YouTube channel subscriptions, even if they're private.</summary>
            public const string DataportabilityYoutubeSubscriptions = "https://www.googleapis.com/auth/dataportability.youtube.subscriptions";

            /// <summary>Move a copy of your unlisted YouTube playlists.</summary>
            public const string DataportabilityYoutubeUnlistedPlaylists = "https://www.googleapis.com/auth/dataportability.youtube.unlisted_playlists";

            /// <summary>Move a copy of your unlisted YouTube videos and information about them.</summary>
            public const string DataportabilityYoutubeUnlistedVideos = "https://www.googleapis.com/auth/dataportability.youtube.unlisted_videos";
        }

        /// <summary>Gets the ArchiveJobs resource.</summary>
        public virtual ArchiveJobsResource ArchiveJobs { get; }

        /// <summary>Gets the Authorization resource.</summary>
        public virtual AuthorizationResource Authorization { get; }

        /// <summary>Gets the PortabilityArchive resource.</summary>
        public virtual PortabilityArchiveResource PortabilityArchive { get; }
    }

    /// <summary>A base abstract class for DataPortability requests.</summary>
    public abstract class DataPortabilityBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new DataPortabilityBaseServiceRequest instance.</summary>
        protected DataPortabilityBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes DataPortability parameter list.</summary>
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

    /// <summary>The "archiveJobs" collection of methods.</summary>
    public class ArchiveJobsResource
    {
        private const string Resource = "archiveJobs";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ArchiveJobsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Retrieves the state of a Takeout Archive job for the Portability API.</summary>
        /// <param name="name">
        /// Required. The archive job ID that is returned when you request the state of the job from Takeout. The format
        /// is: archiveJobs/{archive_job}/portabilityArchiveState. archive_job is the job ID returned by the
        /// InitiatePortabilityArchiveResponse.
        /// </param>
        public virtual GetPortabilityArchiveStateRequest GetPortabilityArchiveState(string name)
        {
            return new GetPortabilityArchiveStateRequest(this.service, name);
        }

        /// <summary>Retrieves the state of a Takeout Archive job for the Portability API.</summary>
        public class GetPortabilityArchiveStateRequest : DataPortabilityBaseServiceRequest<Google.Apis.DataPortability.v1beta.Data.PortabilityArchiveState>
        {
            /// <summary>Constructs a new GetPortabilityArchiveState request.</summary>
            public GetPortabilityArchiveStateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The archive job ID that is returned when you request the state of the job from Takeout. The
            /// format is: archiveJobs/{archive_job}/portabilityArchiveState. archive_job is the job ID returned by the
            /// InitiatePortabilityArchiveResponse.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getPortabilityArchiveState";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/{+name}";

            /// <summary>Initializes GetPortabilityArchiveState parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^archiveJobs/[^/]+/portabilityArchiveState$",
                });
            }
        }

        /// <summary>Retries a failed Portability Archive job.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Required. The archive job ID returned by the InitiatePortabilityArchiveResponse to be retried. Retrying is
        /// only executed if the initial job failed.
        /// </param>
        public virtual RetryRequest Retry(Google.Apis.DataPortability.v1beta.Data.RetryPortabilityArchiveRequest body, string name)
        {
            return new RetryRequest(this.service, body, name);
        }

        /// <summary>Retries a failed Portability Archive job.</summary>
        public class RetryRequest : DataPortabilityBaseServiceRequest<Google.Apis.DataPortability.v1beta.Data.RetryPortabilityArchiveResponse>
        {
            /// <summary>Constructs a new Retry request.</summary>
            public RetryRequest(Google.Apis.Services.IClientService service, Google.Apis.DataPortability.v1beta.Data.RetryPortabilityArchiveRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. The archive job ID returned by the InitiatePortabilityArchiveResponse to be retried. Retrying
            /// is only executed if the initial job failed.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DataPortability.v1beta.Data.RetryPortabilityArchiveRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "retry";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/{+name}:retry";

            /// <summary>Initializes Retry parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^archiveJobs/[^/]+$",
                });
            }
        }
    }

    /// <summary>The "authorization" collection of methods.</summary>
    public class AuthorizationResource
    {
        private const string Resource = "authorization";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AuthorizationResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Revokes OAuth tokens and resets exhausted scopes for a user/project pair. This method allows you to initiate
        /// a Takeout request after a new consent is granted. This method also indicates that previous archives can be
        /// garbage collected. You should call this method when all jobs are complete and all archives are downloaded.
        /// Do not call it only when you start a new job.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual ResetRequest Reset(Google.Apis.DataPortability.v1beta.Data.ResetAuthorizationRequest body)
        {
            return new ResetRequest(this.service, body);
        }

        /// <summary>
        /// Revokes OAuth tokens and resets exhausted scopes for a user/project pair. This method allows you to initiate
        /// a Takeout request after a new consent is granted. This method also indicates that previous archives can be
        /// garbage collected. You should call this method when all jobs are complete and all archives are downloaded.
        /// Do not call it only when you start a new job.
        /// </summary>
        public class ResetRequest : DataPortabilityBaseServiceRequest<Google.Apis.DataPortability.v1beta.Data.Empty>
        {
            /// <summary>Constructs a new Reset request.</summary>
            public ResetRequest(Google.Apis.Services.IClientService service, Google.Apis.DataPortability.v1beta.Data.ResetAuthorizationRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DataPortability.v1beta.Data.ResetAuthorizationRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "reset";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/authorization:reset";

            /// <summary>Initializes Reset parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "portabilityArchive" collection of methods.</summary>
    public class PortabilityArchiveResource
    {
        private const string Resource = "portabilityArchive";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PortabilityArchiveResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Initiates a new Takeout Archive job for the Portability API.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual InitiateRequest Initiate(Google.Apis.DataPortability.v1beta.Data.InitiatePortabilityArchiveRequest body)
        {
            return new InitiateRequest(this.service, body);
        }

        /// <summary>Initiates a new Takeout Archive job for the Portability API.</summary>
        public class InitiateRequest : DataPortabilityBaseServiceRequest<Google.Apis.DataPortability.v1beta.Data.InitiatePortabilityArchiveResponse>
        {
            /// <summary>Constructs a new Initiate request.</summary>
            public InitiateRequest(Google.Apis.Services.IClientService service, Google.Apis.DataPortability.v1beta.Data.InitiatePortabilityArchiveRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DataPortability.v1beta.Data.InitiatePortabilityArchiveRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "initiate";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/portabilityArchive:initiate";

            /// <summary>Initializes Initiate parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }
}
namespace Google.Apis.DataPortability.v1beta.Data
{
    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); }
    /// </summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to kick off a Takeout Archive job.</summary>
    public class InitiatePortabilityArchiveRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resources from which you're exporting data. These values have a 1:1 correspondence with the OAuth
        /// scopes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<string> Resources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response from initiating a Take Archive job.</summary>
    public class InitiatePortabilityArchiveResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The archive job ID that is initiated in the Takeout API. This can be used to get the state of the job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("archiveJobId")]
        public virtual string ArchiveJobId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource that contains the state of a Takeout Archive job.</summary>
    public class PortabilityArchiveState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource name of ArchiveJob's PortabilityArchiveState singleton. The format is:
        /// archiveJobs/{archive_job}/portabilityArchiveState. archive_job is the job ID provided in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Resource that represents the state of the Takeout Archive job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// If the state is complete, this method returns the signed URLs of the objects in the Cloud Storage bucket.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("urls")]
        public virtual System.Collections.Generic.IList<string> Urls { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to reset exhausted OAuth scopes.</summary>
    public class ResetAuthorizationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to retry a failed Portability Archive job.</summary>
    public class RetryPortabilityArchiveRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response from retrying a Portability Archive.</summary>
    public class RetryPortabilityArchiveResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The archive job ID that is initiated by the retry endpoint. This can be used to get the state of the new job
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("archiveJobId")]
        public virtual string ArchiveJobId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
