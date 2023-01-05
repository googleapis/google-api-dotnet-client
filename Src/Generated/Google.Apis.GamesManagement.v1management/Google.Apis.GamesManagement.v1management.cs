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

namespace Google.Apis.GamesManagement.v1management
{
    /// <summary>The GamesManagement Service.</summary>
    public class GamesManagementService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1management";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public GamesManagementService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public GamesManagementService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Achievements = new AchievementsResource(this);
            Applications = new ApplicationsResource(this);
            Events = new EventsResource(this);
            Players = new PlayersResource(this);
            Scores = new ScoresResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "gamesManagement";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri => BaseUriOverride ?? "https://gamesmanagement.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://gamesmanagement.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Google Play Game Management.</summary>
        public class Scope
        {
            /// <summary>Create, edit, and delete your Google Play Games activity</summary>
            public static string Games = "https://www.googleapis.com/auth/games";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Google Play Game Management.</summary>
        public static class ScopeConstants
        {
            /// <summary>Create, edit, and delete your Google Play Games activity</summary>
            public const string Games = "https://www.googleapis.com/auth/games";
        }

        /// <summary>Gets the Achievements resource.</summary>
        public virtual AchievementsResource Achievements { get; }

        /// <summary>Gets the Applications resource.</summary>
        public virtual ApplicationsResource Applications { get; }

        /// <summary>Gets the Events resource.</summary>
        public virtual EventsResource Events { get; }

        /// <summary>Gets the Players resource.</summary>
        public virtual PlayersResource Players { get; }

        /// <summary>Gets the Scores resource.</summary>
        public virtual ScoresResource Scores { get; }
    }

    /// <summary>A base abstract class for GamesManagement requests.</summary>
    public abstract class GamesManagementBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new GamesManagementBaseServiceRequest instance.</summary>
        protected GamesManagementBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes GamesManagement parameter list.</summary>
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

    /// <summary>The "achievements" collection of methods.</summary>
    public class AchievementsResource
    {
        private const string Resource = "achievements";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AchievementsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Resets the achievement with the given ID for the currently authenticated player. This method is only
        /// accessible to whitelisted tester accounts for your application.
        /// </summary>
        /// <param name="achievementId">The ID of the achievement used by this method.</param>
        public virtual ResetRequest Reset(string achievementId)
        {
            return new ResetRequest(service, achievementId);
        }

        /// <summary>
        /// Resets the achievement with the given ID for the currently authenticated player. This method is only
        /// accessible to whitelisted tester accounts for your application.
        /// </summary>
        public class ResetRequest : GamesManagementBaseServiceRequest<Google.Apis.GamesManagement.v1management.Data.AchievementResetResponse>
        {
            /// <summary>Constructs a new Reset request.</summary>
            public ResetRequest(Google.Apis.Services.IClientService service, string achievementId) : base(service)
            {
                AchievementId = achievementId;
                InitParameters();
            }

            /// <summary>The ID of the achievement used by this method.</summary>
            [Google.Apis.Util.RequestParameterAttribute("achievementId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string AchievementId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "reset";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1management/achievements/{achievementId}/reset";

            /// <summary>Initializes Reset parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("achievementId", new Google.Apis.Discovery.Parameter
                {
                    Name = "achievementId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Resets all achievements for the currently authenticated player for your application. This method is only
        /// accessible to whitelisted tester accounts for your application.
        /// </summary>
        public virtual ResetAllRequest ResetAll()
        {
            return new ResetAllRequest(service);
        }

        /// <summary>
        /// Resets all achievements for the currently authenticated player for your application. This method is only
        /// accessible to whitelisted tester accounts for your application.
        /// </summary>
        public class ResetAllRequest : GamesManagementBaseServiceRequest<Google.Apis.GamesManagement.v1management.Data.AchievementResetAllResponse>
        {
            /// <summary>Constructs a new ResetAll request.</summary>
            public ResetAllRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "resetAll";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1management/achievements/reset";

            /// <summary>Initializes ResetAll parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Resets all draft achievements for all players. This method is only available to user accounts for your
        /// developer console.
        /// </summary>
        public virtual ResetAllForAllPlayersRequest ResetAllForAllPlayers()
        {
            return new ResetAllForAllPlayersRequest(service);
        }

        /// <summary>
        /// Resets all draft achievements for all players. This method is only available to user accounts for your
        /// developer console.
        /// </summary>
        public class ResetAllForAllPlayersRequest : GamesManagementBaseServiceRequest<string>
        {
            /// <summary>Constructs a new ResetAllForAllPlayers request.</summary>
            public ResetAllForAllPlayersRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "resetAllForAllPlayers";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1management/achievements/resetAllForAllPlayers";

            /// <summary>Initializes ResetAllForAllPlayers parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Resets the achievement with the given ID for all players. This method is only available to user accounts for
        /// your developer console. Only draft achievements can be reset.
        /// </summary>
        /// <param name="achievementId">The ID of the achievement used by this method.</param>
        public virtual ResetForAllPlayersRequest ResetForAllPlayers(string achievementId)
        {
            return new ResetForAllPlayersRequest(service, achievementId);
        }

        /// <summary>
        /// Resets the achievement with the given ID for all players. This method is only available to user accounts for
        /// your developer console. Only draft achievements can be reset.
        /// </summary>
        public class ResetForAllPlayersRequest : GamesManagementBaseServiceRequest<string>
        {
            /// <summary>Constructs a new ResetForAllPlayers request.</summary>
            public ResetForAllPlayersRequest(Google.Apis.Services.IClientService service, string achievementId) : base(service)
            {
                AchievementId = achievementId;
                InitParameters();
            }

            /// <summary>The ID of the achievement used by this method.</summary>
            [Google.Apis.Util.RequestParameterAttribute("achievementId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string AchievementId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "resetForAllPlayers";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1management/achievements/{achievementId}/resetForAllPlayers";

            /// <summary>Initializes ResetForAllPlayers parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("achievementId", new Google.Apis.Discovery.Parameter
                {
                    Name = "achievementId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Resets achievements with the given IDs for all players. This method is only available to user accounts for
        /// your developer console. Only draft achievements may be reset.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual ResetMultipleForAllPlayersRequest ResetMultipleForAllPlayers(Google.Apis.GamesManagement.v1management.Data.AchievementResetMultipleForAllRequest body)
        {
            return new ResetMultipleForAllPlayersRequest(service, body);
        }

        /// <summary>
        /// Resets achievements with the given IDs for all players. This method is only available to user accounts for
        /// your developer console. Only draft achievements may be reset.
        /// </summary>
        public class ResetMultipleForAllPlayersRequest : GamesManagementBaseServiceRequest<string>
        {
            /// <summary>Constructs a new ResetMultipleForAllPlayers request.</summary>
            public ResetMultipleForAllPlayersRequest(Google.Apis.Services.IClientService service, Google.Apis.GamesManagement.v1management.Data.AchievementResetMultipleForAllRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.GamesManagement.v1management.Data.AchievementResetMultipleForAllRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "resetMultipleForAllPlayers";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1management/achievements/resetMultipleForAllPlayers";

            /// <summary>Initializes ResetMultipleForAllPlayers parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "applications" collection of methods.</summary>
    public class ApplicationsResource
    {
        private const string Resource = "applications";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ApplicationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Get the list of players hidden from the given application. This method is only available to user accounts
        /// for your developer console.
        /// </summary>
        /// <param name="applicationId">The application ID from the Google Play developer console.</param>
        public virtual ListHiddenRequest ListHidden(string applicationId)
        {
            return new ListHiddenRequest(service, applicationId);
        }

        /// <summary>
        /// Get the list of players hidden from the given application. This method is only available to user accounts
        /// for your developer console.
        /// </summary>
        public class ListHiddenRequest : GamesManagementBaseServiceRequest<Google.Apis.GamesManagement.v1management.Data.HiddenPlayerList>
        {
            /// <summary>Constructs a new ListHidden request.</summary>
            public ListHiddenRequest(Google.Apis.Services.IClientService service, string applicationId) : base(service)
            {
                ApplicationId = applicationId;
                InitParameters();
            }

            /// <summary>The application ID from the Google Play developer console.</summary>
            [Google.Apis.Util.RequestParameterAttribute("applicationId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ApplicationId { get; private set; }

            /// <summary>
            /// The maximum number of player resources to return in the response, used for paging. For any response, the
            /// actual number of player resources returned may be less than the specified `maxResults`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>The token returned by the previous request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "listHidden";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1management/applications/{applicationId}/players/hidden";

            /// <summary>Initializes ListHidden parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("applicationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "applicationId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
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

    /// <summary>The "events" collection of methods.</summary>
    public class EventsResource
    {
        private const string Resource = "events";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public EventsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Resets all player progress on the event with the given ID for the currently authenticated player. This
        /// method is only accessible to whitelisted tester accounts for your application.
        /// </summary>
        /// <param name="eventId">The ID of the event.</param>
        public virtual ResetRequest Reset(string eventId)
        {
            return new ResetRequest(service, eventId);
        }

        /// <summary>
        /// Resets all player progress on the event with the given ID for the currently authenticated player. This
        /// method is only accessible to whitelisted tester accounts for your application.
        /// </summary>
        public class ResetRequest : GamesManagementBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Reset request.</summary>
            public ResetRequest(Google.Apis.Services.IClientService service, string eventId) : base(service)
            {
                EventId = eventId;
                InitParameters();
            }

            /// <summary>The ID of the event.</summary>
            [Google.Apis.Util.RequestParameterAttribute("eventId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EventId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "reset";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1management/events/{eventId}/reset";

            /// <summary>Initializes Reset parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("eventId", new Google.Apis.Discovery.Parameter
                {
                    Name = "eventId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Resets all player progress on all events for the currently authenticated player. This method is only
        /// accessible to whitelisted tester accounts for your application.
        /// </summary>
        public virtual ResetAllRequest ResetAll()
        {
            return new ResetAllRequest(service);
        }

        /// <summary>
        /// Resets all player progress on all events for the currently authenticated player. This method is only
        /// accessible to whitelisted tester accounts for your application.
        /// </summary>
        public class ResetAllRequest : GamesManagementBaseServiceRequest<string>
        {
            /// <summary>Constructs a new ResetAll request.</summary>
            public ResetAllRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "resetAll";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1management/events/reset";

            /// <summary>Initializes ResetAll parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Resets all draft events for all players. This method is only available to user accounts for your developer
        /// console.
        /// </summary>
        public virtual ResetAllForAllPlayersRequest ResetAllForAllPlayers()
        {
            return new ResetAllForAllPlayersRequest(service);
        }

        /// <summary>
        /// Resets all draft events for all players. This method is only available to user accounts for your developer
        /// console.
        /// </summary>
        public class ResetAllForAllPlayersRequest : GamesManagementBaseServiceRequest<string>
        {
            /// <summary>Constructs a new ResetAllForAllPlayers request.</summary>
            public ResetAllForAllPlayersRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "resetAllForAllPlayers";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1management/events/resetAllForAllPlayers";

            /// <summary>Initializes ResetAllForAllPlayers parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Resets the event with the given ID for all players. This method is only available to user accounts for your
        /// developer console. Only draft events can be reset.
        /// </summary>
        /// <param name="eventId">The ID of the event.</param>
        public virtual ResetForAllPlayersRequest ResetForAllPlayers(string eventId)
        {
            return new ResetForAllPlayersRequest(service, eventId);
        }

        /// <summary>
        /// Resets the event with the given ID for all players. This method is only available to user accounts for your
        /// developer console. Only draft events can be reset.
        /// </summary>
        public class ResetForAllPlayersRequest : GamesManagementBaseServiceRequest<string>
        {
            /// <summary>Constructs a new ResetForAllPlayers request.</summary>
            public ResetForAllPlayersRequest(Google.Apis.Services.IClientService service, string eventId) : base(service)
            {
                EventId = eventId;
                InitParameters();
            }

            /// <summary>The ID of the event.</summary>
            [Google.Apis.Util.RequestParameterAttribute("eventId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EventId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "resetForAllPlayers";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1management/events/{eventId}/resetForAllPlayers";

            /// <summary>Initializes ResetForAllPlayers parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("eventId", new Google.Apis.Discovery.Parameter
                {
                    Name = "eventId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Resets events with the given IDs for all players. This method is only available to user accounts for your
        /// developer console. Only draft events may be reset.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual ResetMultipleForAllPlayersRequest ResetMultipleForAllPlayers(Google.Apis.GamesManagement.v1management.Data.EventsResetMultipleForAllRequest body)
        {
            return new ResetMultipleForAllPlayersRequest(service, body);
        }

        /// <summary>
        /// Resets events with the given IDs for all players. This method is only available to user accounts for your
        /// developer console. Only draft events may be reset.
        /// </summary>
        public class ResetMultipleForAllPlayersRequest : GamesManagementBaseServiceRequest<string>
        {
            /// <summary>Constructs a new ResetMultipleForAllPlayers request.</summary>
            public ResetMultipleForAllPlayersRequest(Google.Apis.Services.IClientService service, Google.Apis.GamesManagement.v1management.Data.EventsResetMultipleForAllRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.GamesManagement.v1management.Data.EventsResetMultipleForAllRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "resetMultipleForAllPlayers";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1management/events/resetMultipleForAllPlayers";

            /// <summary>Initializes ResetMultipleForAllPlayers parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "players" collection of methods.</summary>
    public class PlayersResource
    {
        private const string Resource = "players";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PlayersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Hide the given player's leaderboard scores from the given application. This method is only available to user
        /// accounts for your developer console.
        /// </summary>
        /// <param name="applicationId">The application ID from the Google Play developer console.</param>
        /// <param name="playerId">
        /// A player ID. A value of `me` may be used in place of the authenticated player's ID.
        /// </param>
        public virtual HideRequest Hide(string applicationId, string playerId)
        {
            return new HideRequest(service, applicationId, playerId);
        }

        /// <summary>
        /// Hide the given player's leaderboard scores from the given application. This method is only available to user
        /// accounts for your developer console.
        /// </summary>
        public class HideRequest : GamesManagementBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Hide request.</summary>
            public HideRequest(Google.Apis.Services.IClientService service, string applicationId, string playerId) : base(service)
            {
                ApplicationId = applicationId;
                PlayerId = playerId;
                InitParameters();
            }

            /// <summary>The application ID from the Google Play developer console.</summary>
            [Google.Apis.Util.RequestParameterAttribute("applicationId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ApplicationId { get; private set; }

            /// <summary>A player ID. A value of `me` may be used in place of the authenticated player's ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("playerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PlayerId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "hide";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1management/applications/{applicationId}/players/hidden/{playerId}";

            /// <summary>Initializes Hide parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("applicationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "applicationId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("playerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "playerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Unhide the given player's leaderboard scores from the given application. This method is only available to
        /// user accounts for your developer console.
        /// </summary>
        /// <param name="applicationId">The application ID from the Google Play developer console.</param>
        /// <param name="playerId">
        /// A player ID. A value of `me` may be used in place of the authenticated player's ID.
        /// </param>
        public virtual UnhideRequest Unhide(string applicationId, string playerId)
        {
            return new UnhideRequest(service, applicationId, playerId);
        }

        /// <summary>
        /// Unhide the given player's leaderboard scores from the given application. This method is only available to
        /// user accounts for your developer console.
        /// </summary>
        public class UnhideRequest : GamesManagementBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Unhide request.</summary>
            public UnhideRequest(Google.Apis.Services.IClientService service, string applicationId, string playerId) : base(service)
            {
                ApplicationId = applicationId;
                PlayerId = playerId;
                InitParameters();
            }

            /// <summary>The application ID from the Google Play developer console.</summary>
            [Google.Apis.Util.RequestParameterAttribute("applicationId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ApplicationId { get; private set; }

            /// <summary>A player ID. A value of `me` may be used in place of the authenticated player's ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("playerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PlayerId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "unhide";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1management/applications/{applicationId}/players/hidden/{playerId}";

            /// <summary>Initializes Unhide parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("applicationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "applicationId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("playerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "playerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "scores" collection of methods.</summary>
    public class ScoresResource
    {
        private const string Resource = "scores";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ScoresResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Resets scores for the leaderboard with the given ID for the currently authenticated player. This method is
        /// only accessible to whitelisted tester accounts for your application.
        /// </summary>
        /// <param name="leaderboardId">The ID of the leaderboard.</param>
        public virtual ResetRequest Reset(string leaderboardId)
        {
            return new ResetRequest(service, leaderboardId);
        }

        /// <summary>
        /// Resets scores for the leaderboard with the given ID for the currently authenticated player. This method is
        /// only accessible to whitelisted tester accounts for your application.
        /// </summary>
        public class ResetRequest : GamesManagementBaseServiceRequest<Google.Apis.GamesManagement.v1management.Data.PlayerScoreResetResponse>
        {
            /// <summary>Constructs a new Reset request.</summary>
            public ResetRequest(Google.Apis.Services.IClientService service, string leaderboardId) : base(service)
            {
                LeaderboardId = leaderboardId;
                InitParameters();
            }

            /// <summary>The ID of the leaderboard.</summary>
            [Google.Apis.Util.RequestParameterAttribute("leaderboardId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string LeaderboardId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "reset";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1management/leaderboards/{leaderboardId}/scores/reset";

            /// <summary>Initializes Reset parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("leaderboardId", new Google.Apis.Discovery.Parameter
                {
                    Name = "leaderboardId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Resets all scores for all leaderboards for the currently authenticated players. This method is only
        /// accessible to whitelisted tester accounts for your application.
        /// </summary>
        public virtual ResetAllRequest ResetAll()
        {
            return new ResetAllRequest(service);
        }

        /// <summary>
        /// Resets all scores for all leaderboards for the currently authenticated players. This method is only
        /// accessible to whitelisted tester accounts for your application.
        /// </summary>
        public class ResetAllRequest : GamesManagementBaseServiceRequest<Google.Apis.GamesManagement.v1management.Data.PlayerScoreResetAllResponse>
        {
            /// <summary>Constructs a new ResetAll request.</summary>
            public ResetAllRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "resetAll";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1management/scores/reset";

            /// <summary>Initializes ResetAll parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Resets scores for all draft leaderboards for all players. This method is only available to user accounts for
        /// your developer console.
        /// </summary>
        public virtual ResetAllForAllPlayersRequest ResetAllForAllPlayers()
        {
            return new ResetAllForAllPlayersRequest(service);
        }

        /// <summary>
        /// Resets scores for all draft leaderboards for all players. This method is only available to user accounts for
        /// your developer console.
        /// </summary>
        public class ResetAllForAllPlayersRequest : GamesManagementBaseServiceRequest<string>
        {
            /// <summary>Constructs a new ResetAllForAllPlayers request.</summary>
            public ResetAllForAllPlayersRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "resetAllForAllPlayers";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1management/scores/resetAllForAllPlayers";

            /// <summary>Initializes ResetAllForAllPlayers parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Resets scores for the leaderboard with the given ID for all players. This method is only available to user
        /// accounts for your developer console. Only draft leaderboards can be reset.
        /// </summary>
        /// <param name="leaderboardId">The ID of the leaderboard.</param>
        public virtual ResetForAllPlayersRequest ResetForAllPlayers(string leaderboardId)
        {
            return new ResetForAllPlayersRequest(service, leaderboardId);
        }

        /// <summary>
        /// Resets scores for the leaderboard with the given ID for all players. This method is only available to user
        /// accounts for your developer console. Only draft leaderboards can be reset.
        /// </summary>
        public class ResetForAllPlayersRequest : GamesManagementBaseServiceRequest<string>
        {
            /// <summary>Constructs a new ResetForAllPlayers request.</summary>
            public ResetForAllPlayersRequest(Google.Apis.Services.IClientService service, string leaderboardId) : base(service)
            {
                LeaderboardId = leaderboardId;
                InitParameters();
            }

            /// <summary>The ID of the leaderboard.</summary>
            [Google.Apis.Util.RequestParameterAttribute("leaderboardId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string LeaderboardId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "resetForAllPlayers";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1management/leaderboards/{leaderboardId}/scores/resetForAllPlayers";

            /// <summary>Initializes ResetForAllPlayers parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("leaderboardId", new Google.Apis.Discovery.Parameter
                {
                    Name = "leaderboardId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Resets scores for the leaderboards with the given IDs for all players. This method is only available to user
        /// accounts for your developer console. Only draft leaderboards may be reset.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual ResetMultipleForAllPlayersRequest ResetMultipleForAllPlayers(Google.Apis.GamesManagement.v1management.Data.ScoresResetMultipleForAllRequest body)
        {
            return new ResetMultipleForAllPlayersRequest(service, body);
        }

        /// <summary>
        /// Resets scores for the leaderboards with the given IDs for all players. This method is only available to user
        /// accounts for your developer console. Only draft leaderboards may be reset.
        /// </summary>
        public class ResetMultipleForAllPlayersRequest : GamesManagementBaseServiceRequest<string>
        {
            /// <summary>Constructs a new ResetMultipleForAllPlayers request.</summary>
            public ResetMultipleForAllPlayersRequest(Google.Apis.Services.IClientService service, Google.Apis.GamesManagement.v1management.Data.ScoresResetMultipleForAllRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.GamesManagement.v1management.Data.ScoresResetMultipleForAllRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "resetMultipleForAllPlayers";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1management/scores/resetMultipleForAllPlayers";

            /// <summary>Initializes ResetMultipleForAllPlayers parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }
}
namespace Google.Apis.GamesManagement.v1management.Data
{
    /// <summary>Achievement reset all response.</summary>
    public class AchievementResetAllResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Uniquely identifies the type of this resource. Value is always the fixed string
        /// `gamesManagement#achievementResetAllResponse`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The achievement reset results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<AchievementResetResponse> Results { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AchievementResetMultipleForAllRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The IDs of achievements to reset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("achievement_ids")]
        public virtual System.Collections.Generic.IList<string> AchievementIds { get; set; }

        /// <summary>
        /// Uniquely identifies the type of this resource. Value is always the fixed string
        /// `gamesManagement#achievementResetMultipleForAllRequest`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An achievement reset response.</summary>
    public class AchievementResetResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The current state of the achievement. This is the same as the initial state of the achievement. Possible
        /// values are: - "`HIDDEN`"- Achievement is hidden. - "`REVEALED`" - Achievement is revealed. - "`UNLOCKED`" -
        /// Achievement is unlocked.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentState")]
        public virtual string CurrentState { get; set; }

        /// <summary>The ID of an achievement for which player state has been updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("definitionId")]
        public virtual string DefinitionId { get; set; }

        /// <summary>
        /// Uniquely identifies the type of this resource. Value is always the fixed string
        /// `gamesManagement#achievementResetResponse`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Flag to indicate if the requested update actually occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateOccurred")]
        public virtual System.Nullable<bool> UpdateOccurred { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Multiple events reset all request.</summary>
    public class EventsResetMultipleForAllRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The IDs of events to reset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("event_ids")]
        public virtual System.Collections.Generic.IList<string> EventIds { get; set; }

        /// <summary>
        /// Uniquely identifies the type of this resource. Value is always the fixed string
        /// `gamesManagement#eventsResetMultipleForAllRequest`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>1P/3P metadata about the player's experience.</summary>
    public class GamesPlayerExperienceInfoResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The current number of experience points for the player.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentExperiencePoints")]
        public virtual System.Nullable<long> CurrentExperiencePoints { get; set; }

        /// <summary>The current level of the player.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentLevel")]
        public virtual GamesPlayerLevelResource CurrentLevel { get; set; }

        /// <summary>The timestamp when the player was leveled up, in millis since Unix epoch UTC.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastLevelUpTimestampMillis")]
        public virtual System.Nullable<long> LastLevelUpTimestampMillis { get; set; }

        /// <summary>
        /// The next level of the player. If the current level is the maximum level, this should be same as the current
        /// level.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextLevel")]
        public virtual GamesPlayerLevelResource NextLevel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>1P/3P metadata about a user's level.</summary>
    public class GamesPlayerLevelResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The level for the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("level")]
        public virtual System.Nullable<int> Level { get; set; }

        /// <summary>The maximum experience points for this level.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxExperiencePoints")]
        public virtual System.Nullable<long> MaxExperiencePoints { get; set; }

        /// <summary>The minimum experience points for this level.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minExperiencePoints")]
        public virtual System.Nullable<long> MinExperiencePoints { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The HiddenPlayer resource.</summary>
    public class HiddenPlayer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time this player was hidden.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hiddenTimeMillis")]
        public virtual System.Nullable<long> HiddenTimeMillis { get; set; }

        /// <summary>
        /// Output only. Uniquely identifies the type of this resource. Value is always the fixed string
        /// `gamesManagement#hiddenPlayer`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Output only. The player information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("player")]
        public virtual Player Player { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of hidden players.</summary>
    public class HiddenPlayerList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The players.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<HiddenPlayer> Items { get; set; }

        /// <summary>
        /// Uniquely identifies the type of this resource. Value is always the fixed string
        /// `gamesManagement#hiddenPlayerList`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The pagination token for the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Player resource.</summary>
    public class Player : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The base URL for the image that represents the player.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("avatarImageUrl")]
        public virtual string AvatarImageUrl { get; set; }

        /// <summary>The url to the landscape mode player banner image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bannerUrlLandscape")]
        public virtual string BannerUrlLandscape { get; set; }

        /// <summary>The url to the portrait mode player banner image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bannerUrlPortrait")]
        public virtual string BannerUrlPortrait { get; set; }

        /// <summary>The name to display for the player.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>An object to represent Play Game experience information for the player.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("experienceInfo")]
        public virtual GamesPlayerExperienceInfoResource ExperienceInfo { get; set; }

        /// <summary>
        /// Uniquely identifies the type of this resource. Value is always the fixed string `gamesManagement#player`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// An object representation of the individual components of the player's name. For some players, these fields
        /// may not be present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual NameData Name { get; set; }

        /// <summary>
        /// The player ID that was used for this player the first time they signed into the game in question. This is
        /// only populated for calls to player.get for the requesting player, only if the player ID has subsequently
        /// changed, and only to clients that support remapping player IDs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalPlayerId")]
        public virtual string OriginalPlayerId { get; set; }

        /// <summary>The ID of the player.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("playerId")]
        public virtual string PlayerId { get; set; }

        /// <summary>
        /// The player's profile settings. Controls whether or not the player's profile is visible to other players.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profileSettings")]
        public virtual ProfileSettings ProfileSettings { get; set; }

        /// <summary>The player's title rewarded for their game activities.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>
        /// An object representation of the individual components of the player's name. For some players, these fields
        /// may not be present.
        /// </summary>
        public class NameData
        {
            /// <summary>The family name of this player. In some places, this is known as the last name.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("familyName")]
            public virtual string FamilyName { get; set; }

            /// <summary>The given name of this player. In some places, this is known as the first name.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("givenName")]
            public virtual string GivenName { get; set; }
        }
    }

    /// <summary>A list of leaderboard reset resources.</summary>
    public class PlayerScoreResetAllResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Uniquely identifies the type of this resource. Value is always the fixed string
        /// `gamesManagement#playerScoreResetAllResponse`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The leaderboard reset results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<PlayerScoreResetResponse> Results { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of reset leaderboard entry resources.</summary>
    public class PlayerScoreResetResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of an leaderboard for which player state has been updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("definitionId")]
        public virtual string DefinitionId { get; set; }

        /// <summary>
        /// Uniquely identifies the type of this resource. Value is always the fixed string
        /// `gamesManagement#playerScoreResetResponse`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The time spans of the updated score. Possible values are: - "`ALL_TIME`" - The score is an all-time score. -
        /// "`WEEKLY`" - The score is a weekly score. - "`DAILY`" - The score is a daily score.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resetScoreTimeSpans")]
        public virtual System.Collections.Generic.IList<string> ResetScoreTimeSpans { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Profile settings</summary>
    public class ProfileSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Uniquely identifies the type of this resource. Value is always the fixed string
        /// `gamesManagement#profileSettings`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("profileVisible")]
        public virtual System.Nullable<bool> ProfileVisible { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ScoresResetMultipleForAllRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Uniquely identifies the type of this resource. Value is always the fixed string
        /// `gamesManagement#scoresResetMultipleForAllRequest`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The IDs of leaderboards to reset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("leaderboard_ids")]
        public virtual System.Collections.Generic.IList<string> LeaderboardIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
