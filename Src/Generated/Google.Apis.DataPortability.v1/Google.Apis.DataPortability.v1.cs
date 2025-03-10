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

namespace Google.Apis.DataPortability.v1
{
    /// <summary>The DataPortability Service.</summary>
    public class DataPortabilityService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

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
            AccessType = new AccessTypeResource(this);
            ArchiveJobs = new ArchiveJobsResource(this);
            Authorization = new AuthorizationResource(this);
            PortabilityArchive = new PortabilityArchiveResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://dataportability.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://dataportability.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "dataportability";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Data Portability API.</summary>
        public class Scope
        {
            /// <summary>Move a copy of the Google Alerts subscriptions you created</summary>
            public static string DataportabilityAlertsSubscriptions = "https://www.googleapis.com/auth/dataportability.alerts.subscriptions";

            /// <summary>
            /// Move a copy of messages between you and the businesses you have conversations with across Google
            /// services
            /// </summary>
            public static string DataportabilityBusinessmessagingConversations = "https://www.googleapis.com/auth/dataportability.businessmessaging.conversations";

            /// <summary>Move a copy of the information you entered into online forms in Chrome</summary>
            public static string DataportabilityChromeAutofill = "https://www.googleapis.com/auth/dataportability.chrome.autofill";

            /// <summary>Move a copy of pages you bookmarked in Chrome</summary>
            public static string DataportabilityChromeBookmarks = "https://www.googleapis.com/auth/dataportability.chrome.bookmarks";

            /// <summary>Move a copy of words you added to Chrome's dictionary</summary>
            public static string DataportabilityChromeDictionary = "https://www.googleapis.com/auth/dataportability.chrome.dictionary";

            /// <summary>Move a copy of extensions you installed from the Chrome Web Store</summary>
            public static string DataportabilityChromeExtensions = "https://www.googleapis.com/auth/dataportability.chrome.extensions";

            /// <summary>Move a copy of sites you visited in Chrome</summary>
            public static string DataportabilityChromeHistory = "https://www.googleapis.com/auth/dataportability.chrome.history";

            /// <summary>Move a copy of pages you added to your reading list in Chrome</summary>
            public static string DataportabilityChromeReadingList = "https://www.googleapis.com/auth/dataportability.chrome.reading_list";

            /// <summary>Move a copy of your settings in Chrome</summary>
            public static string DataportabilityChromeSettings = "https://www.googleapis.com/auth/dataportability.chrome.settings";

            /// <summary>Move a copy of searches and sites you follow, saved by Discover</summary>
            public static string DataportabilityDiscoverFollows = "https://www.googleapis.com/auth/dataportability.discover.follows";

            /// <summary>Move a copy of links to your liked documents, saved by Discover</summary>
            public static string DataportabilityDiscoverLikes = "https://www.googleapis.com/auth/dataportability.discover.likes";

            /// <summary>Move a copy of content you marked as not interested, saved by Discover</summary>
            public static string DataportabilityDiscoverNotInterested = "https://www.googleapis.com/auth/dataportability.discover.not_interested";

            /// <summary>Move a copy of the places you labeled on Maps</summary>
            public static string DataportabilityMapsAliasedPlaces = "https://www.googleapis.com/auth/dataportability.maps.aliased_places";

            /// <summary>Move a copy of your pinned trips on Maps</summary>
            public static string DataportabilityMapsCommuteRoutes = "https://www.googleapis.com/auth/dataportability.maps.commute_routes";

            /// <summary>Move a copy of your commute settings on Maps</summary>
            public static string DataportabilityMapsCommuteSettings = "https://www.googleapis.com/auth/dataportability.maps.commute_settings";

            /// <summary>Move a copy of your electric vehicle profile on Maps</summary>
            public static string DataportabilityMapsEvProfile = "https://www.googleapis.com/auth/dataportability.maps.ev_profile";

            /// <summary>Move a copy of the corrections you made to places or map information on Maps</summary>
            public static string DataportabilityMapsFactualContributions = "https://www.googleapis.com/auth/dataportability.maps.factual_contributions";

            /// <summary>Move a copy of your updates to places on Maps</summary>
            public static string DataportabilityMapsOfferingContributions = "https://www.googleapis.com/auth/dataportability.maps.offering_contributions";

            /// <summary>Move a copy of the photos and videos you posted on Maps</summary>
            public static string DataportabilityMapsPhotosVideos = "https://www.googleapis.com/auth/dataportability.maps.photos_videos";

            /// <summary>Move a copy of the questions and answers you posted on Maps</summary>
            public static string DataportabilityMapsQuestionsAnswers = "https://www.googleapis.com/auth/dataportability.maps.questions_answers";

            /// <summary>Move a copy of your reviews and posts on Maps</summary>
            public static string DataportabilityMapsReviews = "https://www.googleapis.com/auth/dataportability.maps.reviews";

            /// <summary>Move a copy of your Starred places list on Maps</summary>
            public static string DataportabilityMapsStarredPlaces = "https://www.googleapis.com/auth/dataportability.maps.starred_places";

            /// <summary>Move a copy of your Maps activity</summary>
            public static string DataportabilityMyactivityMaps = "https://www.googleapis.com/auth/dataportability.myactivity.maps";

            /// <summary>Move a copy of your My Ad Center activity</summary>
            public static string DataportabilityMyactivityMyadcenter = "https://www.googleapis.com/auth/dataportability.myactivity.myadcenter";

            /// <summary>Move a copy of your Google Play activity</summary>
            public static string DataportabilityMyactivityPlay = "https://www.googleapis.com/auth/dataportability.myactivity.play";

            /// <summary>Move a copy of your Google Search activity</summary>
            public static string DataportabilityMyactivitySearch = "https://www.googleapis.com/auth/dataportability.myactivity.search";

            /// <summary>Move a copy of your Shopping activity</summary>
            public static string DataportabilityMyactivityShopping = "https://www.googleapis.com/auth/dataportability.myactivity.shopping";

            /// <summary>Move a copy of your YouTube activity</summary>
            public static string DataportabilityMyactivityYoutube = "https://www.googleapis.com/auth/dataportability.myactivity.youtube";

            /// <summary>Move a copy of the maps you created in My Maps</summary>
            public static string DataportabilityMymapsMaps = "https://www.googleapis.com/auth/dataportability.mymaps.maps";

            /// <summary>Move a copy of your food purchase and reservation activity</summary>
            public static string DataportabilityOrderReservePurchasesReservations = "https://www.googleapis.com/auth/dataportability.order_reserve.purchases_reservations";

            /// <summary>Move a copy of information about your devices with Google Play Store installed</summary>
            public static string DataportabilityPlayDevices = "https://www.googleapis.com/auth/dataportability.play.devices";

            /// <summary>Move a copy of your Google Play Store Grouping tags created by app developers</summary>
            public static string DataportabilityPlayGrouping = "https://www.googleapis.com/auth/dataportability.play.grouping";

            /// <summary>Move a copy of your Google Play Store app installations</summary>
            public static string DataportabilityPlayInstalls = "https://www.googleapis.com/auth/dataportability.play.installs";

            /// <summary>Move a copy of your Google Play Store downloads, including books, games, and apps</summary>
            public static string DataportabilityPlayLibrary = "https://www.googleapis.com/auth/dataportability.play.library";

            /// <summary>Move a copy of information about your Google Play Store Points</summary>
            public static string DataportabilityPlayPlaypoints = "https://www.googleapis.com/auth/dataportability.play.playpoints";

            /// <summary>Move a copy of information about your Google Play Store promotions</summary>
            public static string DataportabilityPlayPromotions = "https://www.googleapis.com/auth/dataportability.play.promotions";

            /// <summary>Move a copy of your Google Play Store purchases</summary>
            public static string DataportabilityPlayPurchases = "https://www.googleapis.com/auth/dataportability.play.purchases";

            /// <summary>Move a copy of your Google Play Store redemption activities</summary>
            public static string DataportabilityPlayRedemptions = "https://www.googleapis.com/auth/dataportability.play.redemptions";

            /// <summary>Move a copy of your Google Play Store subscriptions</summary>
            public static string DataportabilityPlaySubscriptions = "https://www.googleapis.com/auth/dataportability.play.subscriptions";

            /// <summary>Move a copy of your Google Play Store user settings and preferences</summary>
            public static string DataportabilityPlayUsersettings = "https://www.googleapis.com/auth/dataportability.play.usersettings";

            /// <summary>
            /// Move a copy of your saved links, images, places, and collections from your use of Google services
            /// </summary>
            public static string DataportabilitySavedCollections = "https://www.googleapis.com/auth/dataportability.saved.collections";

            /// <summary>Move a copy of your comments on Google Search</summary>
            public static string DataportabilitySearchUgcComments = "https://www.googleapis.com/auth/dataportability.search_ugc.comments";

            /// <summary>Move a copy of your media reviews on Google Search</summary>
            public static string DataportabilitySearchUgcMediaReviewsAndStars = "https://www.googleapis.com/auth/dataportability.search_ugc.media.reviews_and_stars";

            /// <summary>
            /// Move a copy of your self-reported video streaming provider preferences from Google Search and Google TV
            /// </summary>
            public static string DataportabilitySearchUgcMediaStreamingVideoProviders = "https://www.googleapis.com/auth/dataportability.search_ugc.media.streaming_video_providers";

            /// <summary>
            /// Move a copy of your indicated thumbs up and thumbs down on media in Google Search and Google TV
            /// </summary>
            public static string DataportabilitySearchUgcMediaThumbs = "https://www.googleapis.com/auth/dataportability.search_ugc.media.thumbs";

            /// <summary>
            /// Move a copy of information about the movies and TV shows you marked as watched on Google Search and
            /// Google TV
            /// </summary>
            public static string DataportabilitySearchUgcMediaWatched = "https://www.googleapis.com/auth/dataportability.search_ugc.media.watched";

            /// <summary>Move a copy of your notification settings on the Google Search app</summary>
            public static string DataportabilitySearchnotificationsSettings = "https://www.googleapis.com/auth/dataportability.searchnotifications.settings";

            /// <summary>Move a copy of your notification subscriptions on Google Search app</summary>
            public static string DataportabilitySearchnotificationsSubscriptions = "https://www.googleapis.com/auth/dataportability.searchnotifications.subscriptions";

            /// <summary>Move a copy of your shipping information on Shopping</summary>
            public static string DataportabilityShoppingAddresses = "https://www.googleapis.com/auth/dataportability.shopping.addresses";

            /// <summary>Move a copy of reviews you wrote about products or online stores on Google Search</summary>
            public static string DataportabilityShoppingReviews = "https://www.googleapis.com/auth/dataportability.shopping.reviews";

            /// <summary>Move a copy of the images and videos you uploaded to Street View</summary>
            public static string DataportabilityStreetviewImagery = "https://www.googleapis.com/auth/dataportability.streetview.imagery";

            /// <summary>Move a copy of information about your YouTube channel</summary>
            public static string DataportabilityYoutubeChannel = "https://www.googleapis.com/auth/dataportability.youtube.channel";

            /// <summary>Move a copy of your YouTube clips metadata</summary>
            public static string DataportabilityYoutubeClips = "https://www.googleapis.com/auth/dataportability.youtube.clips";

            /// <summary>Move a copy of your YouTube comments</summary>
            public static string DataportabilityYoutubeComments = "https://www.googleapis.com/auth/dataportability.youtube.comments";

            /// <summary>Move a copy of your YouTube messages in live chat</summary>
            public static string DataportabilityYoutubeLiveChat = "https://www.googleapis.com/auth/dataportability.youtube.live_chat";

            /// <summary>Move a copy of your uploaded YouTube music tracks and your YouTube music library</summary>
            public static string DataportabilityYoutubeMusic = "https://www.googleapis.com/auth/dataportability.youtube.music";

            /// <summary>Move a copy of your YouTube playables saved game progress files</summary>
            public static string DataportabilityYoutubePlayable = "https://www.googleapis.com/auth/dataportability.youtube.playable";

            /// <summary>Move a copy of your YouTube posts</summary>
            public static string DataportabilityYoutubePosts = "https://www.googleapis.com/auth/dataportability.youtube.posts";

            /// <summary>Move a copy of your YouTube private playlists</summary>
            public static string DataportabilityYoutubePrivatePlaylists = "https://www.googleapis.com/auth/dataportability.youtube.private_playlists";

            /// <summary>Move a copy of your private YouTube videos and information about them</summary>
            public static string DataportabilityYoutubePrivateVideos = "https://www.googleapis.com/auth/dataportability.youtube.private_videos";

            /// <summary>Move a copy of your public YouTube playlists</summary>
            public static string DataportabilityYoutubePublicPlaylists = "https://www.googleapis.com/auth/dataportability.youtube.public_playlists";

            /// <summary>Move a copy of your public YouTube videos and information about them</summary>
            public static string DataportabilityYoutubePublicVideos = "https://www.googleapis.com/auth/dataportability.youtube.public_videos";

            /// <summary>Move a copy of your YouTube shopping wishlists, and wishlist items</summary>
            public static string DataportabilityYoutubeShopping = "https://www.googleapis.com/auth/dataportability.youtube.shopping";

            /// <summary>Move a copy of your YouTube channel subscriptions, even if they're private</summary>
            public static string DataportabilityYoutubeSubscriptions = "https://www.googleapis.com/auth/dataportability.youtube.subscriptions";

            /// <summary>Move a copy of your unlisted YouTube playlists</summary>
            public static string DataportabilityYoutubeUnlistedPlaylists = "https://www.googleapis.com/auth/dataportability.youtube.unlisted_playlists";

            /// <summary>Move a copy of your unlisted YouTube videos and information about them</summary>
            public static string DataportabilityYoutubeUnlistedVideos = "https://www.googleapis.com/auth/dataportability.youtube.unlisted_videos";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Data Portability API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Move a copy of the Google Alerts subscriptions you created</summary>
            public const string DataportabilityAlertsSubscriptions = "https://www.googleapis.com/auth/dataportability.alerts.subscriptions";

            /// <summary>
            /// Move a copy of messages between you and the businesses you have conversations with across Google
            /// services
            /// </summary>
            public const string DataportabilityBusinessmessagingConversations = "https://www.googleapis.com/auth/dataportability.businessmessaging.conversations";

            /// <summary>Move a copy of the information you entered into online forms in Chrome</summary>
            public const string DataportabilityChromeAutofill = "https://www.googleapis.com/auth/dataportability.chrome.autofill";

            /// <summary>Move a copy of pages you bookmarked in Chrome</summary>
            public const string DataportabilityChromeBookmarks = "https://www.googleapis.com/auth/dataportability.chrome.bookmarks";

            /// <summary>Move a copy of words you added to Chrome's dictionary</summary>
            public const string DataportabilityChromeDictionary = "https://www.googleapis.com/auth/dataportability.chrome.dictionary";

            /// <summary>Move a copy of extensions you installed from the Chrome Web Store</summary>
            public const string DataportabilityChromeExtensions = "https://www.googleapis.com/auth/dataportability.chrome.extensions";

            /// <summary>Move a copy of sites you visited in Chrome</summary>
            public const string DataportabilityChromeHistory = "https://www.googleapis.com/auth/dataportability.chrome.history";

            /// <summary>Move a copy of pages you added to your reading list in Chrome</summary>
            public const string DataportabilityChromeReadingList = "https://www.googleapis.com/auth/dataportability.chrome.reading_list";

            /// <summary>Move a copy of your settings in Chrome</summary>
            public const string DataportabilityChromeSettings = "https://www.googleapis.com/auth/dataportability.chrome.settings";

            /// <summary>Move a copy of searches and sites you follow, saved by Discover</summary>
            public const string DataportabilityDiscoverFollows = "https://www.googleapis.com/auth/dataportability.discover.follows";

            /// <summary>Move a copy of links to your liked documents, saved by Discover</summary>
            public const string DataportabilityDiscoverLikes = "https://www.googleapis.com/auth/dataportability.discover.likes";

            /// <summary>Move a copy of content you marked as not interested, saved by Discover</summary>
            public const string DataportabilityDiscoverNotInterested = "https://www.googleapis.com/auth/dataportability.discover.not_interested";

            /// <summary>Move a copy of the places you labeled on Maps</summary>
            public const string DataportabilityMapsAliasedPlaces = "https://www.googleapis.com/auth/dataportability.maps.aliased_places";

            /// <summary>Move a copy of your pinned trips on Maps</summary>
            public const string DataportabilityMapsCommuteRoutes = "https://www.googleapis.com/auth/dataportability.maps.commute_routes";

            /// <summary>Move a copy of your commute settings on Maps</summary>
            public const string DataportabilityMapsCommuteSettings = "https://www.googleapis.com/auth/dataportability.maps.commute_settings";

            /// <summary>Move a copy of your electric vehicle profile on Maps</summary>
            public const string DataportabilityMapsEvProfile = "https://www.googleapis.com/auth/dataportability.maps.ev_profile";

            /// <summary>Move a copy of the corrections you made to places or map information on Maps</summary>
            public const string DataportabilityMapsFactualContributions = "https://www.googleapis.com/auth/dataportability.maps.factual_contributions";

            /// <summary>Move a copy of your updates to places on Maps</summary>
            public const string DataportabilityMapsOfferingContributions = "https://www.googleapis.com/auth/dataportability.maps.offering_contributions";

            /// <summary>Move a copy of the photos and videos you posted on Maps</summary>
            public const string DataportabilityMapsPhotosVideos = "https://www.googleapis.com/auth/dataportability.maps.photos_videos";

            /// <summary>Move a copy of the questions and answers you posted on Maps</summary>
            public const string DataportabilityMapsQuestionsAnswers = "https://www.googleapis.com/auth/dataportability.maps.questions_answers";

            /// <summary>Move a copy of your reviews and posts on Maps</summary>
            public const string DataportabilityMapsReviews = "https://www.googleapis.com/auth/dataportability.maps.reviews";

            /// <summary>Move a copy of your Starred places list on Maps</summary>
            public const string DataportabilityMapsStarredPlaces = "https://www.googleapis.com/auth/dataportability.maps.starred_places";

            /// <summary>Move a copy of your Maps activity</summary>
            public const string DataportabilityMyactivityMaps = "https://www.googleapis.com/auth/dataportability.myactivity.maps";

            /// <summary>Move a copy of your My Ad Center activity</summary>
            public const string DataportabilityMyactivityMyadcenter = "https://www.googleapis.com/auth/dataportability.myactivity.myadcenter";

            /// <summary>Move a copy of your Google Play activity</summary>
            public const string DataportabilityMyactivityPlay = "https://www.googleapis.com/auth/dataportability.myactivity.play";

            /// <summary>Move a copy of your Google Search activity</summary>
            public const string DataportabilityMyactivitySearch = "https://www.googleapis.com/auth/dataportability.myactivity.search";

            /// <summary>Move a copy of your Shopping activity</summary>
            public const string DataportabilityMyactivityShopping = "https://www.googleapis.com/auth/dataportability.myactivity.shopping";

            /// <summary>Move a copy of your YouTube activity</summary>
            public const string DataportabilityMyactivityYoutube = "https://www.googleapis.com/auth/dataportability.myactivity.youtube";

            /// <summary>Move a copy of the maps you created in My Maps</summary>
            public const string DataportabilityMymapsMaps = "https://www.googleapis.com/auth/dataportability.mymaps.maps";

            /// <summary>Move a copy of your food purchase and reservation activity</summary>
            public const string DataportabilityOrderReservePurchasesReservations = "https://www.googleapis.com/auth/dataportability.order_reserve.purchases_reservations";

            /// <summary>Move a copy of information about your devices with Google Play Store installed</summary>
            public const string DataportabilityPlayDevices = "https://www.googleapis.com/auth/dataportability.play.devices";

            /// <summary>Move a copy of your Google Play Store Grouping tags created by app developers</summary>
            public const string DataportabilityPlayGrouping = "https://www.googleapis.com/auth/dataportability.play.grouping";

            /// <summary>Move a copy of your Google Play Store app installations</summary>
            public const string DataportabilityPlayInstalls = "https://www.googleapis.com/auth/dataportability.play.installs";

            /// <summary>Move a copy of your Google Play Store downloads, including books, games, and apps</summary>
            public const string DataportabilityPlayLibrary = "https://www.googleapis.com/auth/dataportability.play.library";

            /// <summary>Move a copy of information about your Google Play Store Points</summary>
            public const string DataportabilityPlayPlaypoints = "https://www.googleapis.com/auth/dataportability.play.playpoints";

            /// <summary>Move a copy of information about your Google Play Store promotions</summary>
            public const string DataportabilityPlayPromotions = "https://www.googleapis.com/auth/dataportability.play.promotions";

            /// <summary>Move a copy of your Google Play Store purchases</summary>
            public const string DataportabilityPlayPurchases = "https://www.googleapis.com/auth/dataportability.play.purchases";

            /// <summary>Move a copy of your Google Play Store redemption activities</summary>
            public const string DataportabilityPlayRedemptions = "https://www.googleapis.com/auth/dataportability.play.redemptions";

            /// <summary>Move a copy of your Google Play Store subscriptions</summary>
            public const string DataportabilityPlaySubscriptions = "https://www.googleapis.com/auth/dataportability.play.subscriptions";

            /// <summary>Move a copy of your Google Play Store user settings and preferences</summary>
            public const string DataportabilityPlayUsersettings = "https://www.googleapis.com/auth/dataportability.play.usersettings";

            /// <summary>
            /// Move a copy of your saved links, images, places, and collections from your use of Google services
            /// </summary>
            public const string DataportabilitySavedCollections = "https://www.googleapis.com/auth/dataportability.saved.collections";

            /// <summary>Move a copy of your comments on Google Search</summary>
            public const string DataportabilitySearchUgcComments = "https://www.googleapis.com/auth/dataportability.search_ugc.comments";

            /// <summary>Move a copy of your media reviews on Google Search</summary>
            public const string DataportabilitySearchUgcMediaReviewsAndStars = "https://www.googleapis.com/auth/dataportability.search_ugc.media.reviews_and_stars";

            /// <summary>
            /// Move a copy of your self-reported video streaming provider preferences from Google Search and Google TV
            /// </summary>
            public const string DataportabilitySearchUgcMediaStreamingVideoProviders = "https://www.googleapis.com/auth/dataportability.search_ugc.media.streaming_video_providers";

            /// <summary>
            /// Move a copy of your indicated thumbs up and thumbs down on media in Google Search and Google TV
            /// </summary>
            public const string DataportabilitySearchUgcMediaThumbs = "https://www.googleapis.com/auth/dataportability.search_ugc.media.thumbs";

            /// <summary>
            /// Move a copy of information about the movies and TV shows you marked as watched on Google Search and
            /// Google TV
            /// </summary>
            public const string DataportabilitySearchUgcMediaWatched = "https://www.googleapis.com/auth/dataportability.search_ugc.media.watched";

            /// <summary>Move a copy of your notification settings on the Google Search app</summary>
            public const string DataportabilitySearchnotificationsSettings = "https://www.googleapis.com/auth/dataportability.searchnotifications.settings";

            /// <summary>Move a copy of your notification subscriptions on Google Search app</summary>
            public const string DataportabilitySearchnotificationsSubscriptions = "https://www.googleapis.com/auth/dataportability.searchnotifications.subscriptions";

            /// <summary>Move a copy of your shipping information on Shopping</summary>
            public const string DataportabilityShoppingAddresses = "https://www.googleapis.com/auth/dataportability.shopping.addresses";

            /// <summary>Move a copy of reviews you wrote about products or online stores on Google Search</summary>
            public const string DataportabilityShoppingReviews = "https://www.googleapis.com/auth/dataportability.shopping.reviews";

            /// <summary>Move a copy of the images and videos you uploaded to Street View</summary>
            public const string DataportabilityStreetviewImagery = "https://www.googleapis.com/auth/dataportability.streetview.imagery";

            /// <summary>Move a copy of information about your YouTube channel</summary>
            public const string DataportabilityYoutubeChannel = "https://www.googleapis.com/auth/dataportability.youtube.channel";

            /// <summary>Move a copy of your YouTube clips metadata</summary>
            public const string DataportabilityYoutubeClips = "https://www.googleapis.com/auth/dataportability.youtube.clips";

            /// <summary>Move a copy of your YouTube comments</summary>
            public const string DataportabilityYoutubeComments = "https://www.googleapis.com/auth/dataportability.youtube.comments";

            /// <summary>Move a copy of your YouTube messages in live chat</summary>
            public const string DataportabilityYoutubeLiveChat = "https://www.googleapis.com/auth/dataportability.youtube.live_chat";

            /// <summary>Move a copy of your uploaded YouTube music tracks and your YouTube music library</summary>
            public const string DataportabilityYoutubeMusic = "https://www.googleapis.com/auth/dataportability.youtube.music";

            /// <summary>Move a copy of your YouTube playables saved game progress files</summary>
            public const string DataportabilityYoutubePlayable = "https://www.googleapis.com/auth/dataportability.youtube.playable";

            /// <summary>Move a copy of your YouTube posts</summary>
            public const string DataportabilityYoutubePosts = "https://www.googleapis.com/auth/dataportability.youtube.posts";

            /// <summary>Move a copy of your YouTube private playlists</summary>
            public const string DataportabilityYoutubePrivatePlaylists = "https://www.googleapis.com/auth/dataportability.youtube.private_playlists";

            /// <summary>Move a copy of your private YouTube videos and information about them</summary>
            public const string DataportabilityYoutubePrivateVideos = "https://www.googleapis.com/auth/dataportability.youtube.private_videos";

            /// <summary>Move a copy of your public YouTube playlists</summary>
            public const string DataportabilityYoutubePublicPlaylists = "https://www.googleapis.com/auth/dataportability.youtube.public_playlists";

            /// <summary>Move a copy of your public YouTube videos and information about them</summary>
            public const string DataportabilityYoutubePublicVideos = "https://www.googleapis.com/auth/dataportability.youtube.public_videos";

            /// <summary>Move a copy of your YouTube shopping wishlists, and wishlist items</summary>
            public const string DataportabilityYoutubeShopping = "https://www.googleapis.com/auth/dataportability.youtube.shopping";

            /// <summary>Move a copy of your YouTube channel subscriptions, even if they're private</summary>
            public const string DataportabilityYoutubeSubscriptions = "https://www.googleapis.com/auth/dataportability.youtube.subscriptions";

            /// <summary>Move a copy of your unlisted YouTube playlists</summary>
            public const string DataportabilityYoutubeUnlistedPlaylists = "https://www.googleapis.com/auth/dataportability.youtube.unlisted_playlists";

            /// <summary>Move a copy of your unlisted YouTube videos and information about them</summary>
            public const string DataportabilityYoutubeUnlistedVideos = "https://www.googleapis.com/auth/dataportability.youtube.unlisted_videos";
        }

        /// <summary>Gets the AccessType resource.</summary>
        public virtual AccessTypeResource AccessType { get; }

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

    /// <summary>The "accessType" collection of methods.</summary>
    public class AccessTypeResource
    {
        private const string Resource = "accessType";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AccessTypeResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Gets the access type of the token.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CheckRequest Check(Google.Apis.DataPortability.v1.Data.CheckAccessTypeRequest body)
        {
            return new CheckRequest(this.service, body);
        }

        /// <summary>Gets the access type of the token.</summary>
        public class CheckRequest : DataPortabilityBaseServiceRequest<Google.Apis.DataPortability.v1.Data.CheckAccessTypeResponse>
        {
            /// <summary>Constructs a new Check request.</summary>
            public CheckRequest(Google.Apis.Services.IClientService service, Google.Apis.DataPortability.v1.Data.CheckAccessTypeRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DataPortability.v1.Data.CheckAccessTypeRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "check";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/accessType:check";

            /// <summary>Initializes Check parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
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

        /// <summary>Cancels a Portability Archive job.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Required. The Archive job ID you're canceling. This is returned by the InitiatePortabilityArchive response.
        /// The format is: archiveJobs/{archive_job}. Canceling is only executed if the job is in progress.
        /// </param>
        public virtual CancelRequest Cancel(Google.Apis.DataPortability.v1.Data.CancelPortabilityArchiveRequest body, string name)
        {
            return new CancelRequest(this.service, body, name);
        }

        /// <summary>Cancels a Portability Archive job.</summary>
        public class CancelRequest : DataPortabilityBaseServiceRequest<Google.Apis.DataPortability.v1.Data.CancelPortabilityArchiveResponse>
        {
            /// <summary>Constructs a new Cancel request.</summary>
            public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.DataPortability.v1.Data.CancelPortabilityArchiveRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. The Archive job ID you're canceling. This is returned by the InitiatePortabilityArchive
            /// response. The format is: archiveJobs/{archive_job}. Canceling is only executed if the job is in
            /// progress.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DataPortability.v1.Data.CancelPortabilityArchiveRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "cancel";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}:cancel";

            /// <summary>Initializes Cancel parameter list.</summary>
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

        /// <summary>Retrieves the state of an Archive job for the Portability API.</summary>
        /// <param name="name">
        /// Required. The archive job ID that is returned when you request the state of the job. The format is:
        /// archiveJobs/{archive_job}/portabilityArchiveState. archive_job is the job ID returned by the
        /// InitiatePortabilityArchiveResponse.
        /// </param>
        public virtual GetPortabilityArchiveStateRequest GetPortabilityArchiveState(string name)
        {
            return new GetPortabilityArchiveStateRequest(this.service, name);
        }

        /// <summary>Retrieves the state of an Archive job for the Portability API.</summary>
        public class GetPortabilityArchiveStateRequest : DataPortabilityBaseServiceRequest<Google.Apis.DataPortability.v1.Data.PortabilityArchiveState>
        {
            /// <summary>Constructs a new GetPortabilityArchiveState request.</summary>
            public GetPortabilityArchiveStateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The archive job ID that is returned when you request the state of the job. The format is:
            /// archiveJobs/{archive_job}/portabilityArchiveState. archive_job is the job ID returned by the
            /// InitiatePortabilityArchiveResponse.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getPortabilityArchiveState";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

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
        /// Required. The Archive job ID you're retrying. This is returned by the InitiatePortabilityArchiveResponse.
        /// Retrying is only executed if the initial job failed.
        /// </param>
        public virtual RetryRequest Retry(Google.Apis.DataPortability.v1.Data.RetryPortabilityArchiveRequest body, string name)
        {
            return new RetryRequest(this.service, body, name);
        }

        /// <summary>Retries a failed Portability Archive job.</summary>
        public class RetryRequest : DataPortabilityBaseServiceRequest<Google.Apis.DataPortability.v1.Data.RetryPortabilityArchiveResponse>
        {
            /// <summary>Constructs a new Retry request.</summary>
            public RetryRequest(Google.Apis.Services.IClientService service, Google.Apis.DataPortability.v1.Data.RetryPortabilityArchiveRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. The Archive job ID you're retrying. This is returned by the
            /// InitiatePortabilityArchiveResponse. Retrying is only executed if the initial job failed.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DataPortability.v1.Data.RetryPortabilityArchiveRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "retry";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}:retry";

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
        /// a request after a new consent is granted. This method also indicates that previous archives can be garbage
        /// collected. You should call this method when all jobs are complete and all archives are downloaded. Do not
        /// call it only when you start a new job.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual ResetRequest Reset(Google.Apis.DataPortability.v1.Data.ResetAuthorizationRequest body)
        {
            return new ResetRequest(this.service, body);
        }

        /// <summary>
        /// Revokes OAuth tokens and resets exhausted scopes for a user/project pair. This method allows you to initiate
        /// a request after a new consent is granted. This method also indicates that previous archives can be garbage
        /// collected. You should call this method when all jobs are complete and all archives are downloaded. Do not
        /// call it only when you start a new job.
        /// </summary>
        public class ResetRequest : DataPortabilityBaseServiceRequest<Google.Apis.DataPortability.v1.Data.Empty>
        {
            /// <summary>Constructs a new Reset request.</summary>
            public ResetRequest(Google.Apis.Services.IClientService service, Google.Apis.DataPortability.v1.Data.ResetAuthorizationRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DataPortability.v1.Data.ResetAuthorizationRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "reset";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/authorization:reset";

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

        /// <summary>Initiates a new Archive job for the Portability API.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual InitiateRequest Initiate(Google.Apis.DataPortability.v1.Data.InitiatePortabilityArchiveRequest body)
        {
            return new InitiateRequest(this.service, body);
        }

        /// <summary>Initiates a new Archive job for the Portability API.</summary>
        public class InitiateRequest : DataPortabilityBaseServiceRequest<Google.Apis.DataPortability.v1.Data.InitiatePortabilityArchiveResponse>
        {
            /// <summary>Constructs a new Initiate request.</summary>
            public InitiateRequest(Google.Apis.Services.IClientService service, Google.Apis.DataPortability.v1.Data.InitiatePortabilityArchiveRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DataPortability.v1.Data.InitiatePortabilityArchiveRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "initiate";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/portabilityArchive:initiate";

            /// <summary>Initializes Initiate parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }
}
namespace Google.Apis.DataPortability.v1.Data
{
    /// <summary>Request to cancel a Portability Archive job.</summary>
    public class CancelPortabilityArchiveRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to canceling a Data Portability Archive job.</summary>
    public class CancelPortabilityArchiveResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Request to check the token's access type. All required information is derived from the attached OAuth token.
    /// </summary>
    public class CheckAccessTypeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to checking the token's access type.</summary>
    public class CheckAccessTypeResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Jobs initiated with this token will be one-time if any requested resources have one-time access.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oneTimeResources")]
        public virtual System.Collections.Generic.IList<string> OneTimeResources { get; set; }

        /// <summary>
        /// Jobs initiated with this token will be time-based if all requested resources have time-based access.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeBasedResources")]
        public virtual System.Collections.Generic.IList<string> TimeBasedResources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

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

    /// <summary>Request to kick off an Archive job.</summary>
    public class InitiatePortabilityArchiveRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>
        /// Optional. The timestamp that represents the end point for the data you are exporting. If the end_time is not
        /// specified in the InitiatePortabilityArchiveRequest, this field is set to the latest available data.
        /// </summary>
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

        /// <summary>
        /// The resources from which you're exporting data. These values have a 1:1 correspondence with the OAuth
        /// scopes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<string> Resources { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>
        /// Optional. The timestamp that represents the starting point for the data you are exporting. If the start_time
        /// is not specified in the InitiatePortabilityArchiveRequest, the field is set to the earliest available data.
        /// </summary>
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

    /// <summary>Response from initiating an Archive job.</summary>
    public class InitiatePortabilityArchiveResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The access type of the Archive job initiated by the API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessType")]
        public virtual string AccessType { get; set; }

        /// <summary>
        /// The archive job ID that is initiated in the API. This can be used to get the state of the job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("archiveJobId")]
        public virtual string ArchiveJobId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource that contains the state of an Archive job.</summary>
    public class PortabilityArchiveState : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _exportTimeRaw;

        private object _exportTime;

        /// <summary>
        /// The timestamp that represents the end point for the data you are exporting. If the end_time value is set in
        /// the InitiatePortabilityArchiveRequest, this field is set to that value. If end_time is not set, this value
        /// is set to the time the export was requested.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exportTime")]
        public virtual string ExportTimeRaw
        {
            get => _exportTimeRaw;
            set
            {
                _exportTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _exportTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExportTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExportTimeDateTimeOffset instead.")]
        public virtual object ExportTime
        {
            get => _exportTime;
            set
            {
                _exportTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _exportTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ExportTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExportTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExportTimeRaw);
            set => ExportTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The resource name of ArchiveJob's PortabilityArchiveState singleton. The format is:
        /// archiveJobs/{archive_job}/portabilityArchiveState. archive_job is the job ID provided in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>
        /// The timestamp that represents the starting point for the data you are exporting. This field is set only if
        /// the start_time field is specified in the InitiatePortabilityArchiveRequest.
        /// </summary>
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

        /// <summary>Resource that represents the state of the Archive job.</summary>
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
        /// The archive job ID that is initiated by the retry endpoint. This can be used to get the state of the new
        /// job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("archiveJobId")]
        public virtual string ArchiveJobId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
