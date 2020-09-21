// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.Games.v1
{
    /// <summary>The Games Service.</summary>
    public class GamesService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public GamesService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public GamesService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            AchievementDefinitions = new AchievementDefinitionsResource(this);
            Achievements = new AchievementsResource(this);
            Applications = new ApplicationsResource(this);
            Events = new EventsResource(this);
            Leaderboards = new LeaderboardsResource(this);
            Metagame = new MetagameResource(this);
            Players = new PlayersResource(this);
            Revisions = new RevisionsResource(this);
            Scores = new ScoresResource(this);
            Snapshots = new SnapshotsResource(this);
            Stats = new StatsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "games";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://games.googleapis.com/";
        #else
            "https://games.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://games.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Google Play Game Services.</summary>
        public class Scope
        {
            /// <summary>View and manage its own configuration data in your Google Drive</summary>
            public static string DriveAppdata = "https://www.googleapis.com/auth/drive.appdata";

            /// <summary>Create, edit, and delete your Google Play Games activity</summary>
            public static string Games = "https://www.googleapis.com/auth/games";

        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Google Play Game Services.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage its own configuration data in your Google Drive</summary>
            public const string DriveAppdata = "https://www.googleapis.com/auth/drive.appdata";

            /// <summary>Create, edit, and delete your Google Play Games activity</summary>
            public const string Games = "https://www.googleapis.com/auth/games";

        }



        /// <summary>Gets the AchievementDefinitions resource.</summary>
        public virtual AchievementDefinitionsResource AchievementDefinitions { get; }

        /// <summary>Gets the Achievements resource.</summary>
        public virtual AchievementsResource Achievements { get; }

        /// <summary>Gets the Applications resource.</summary>
        public virtual ApplicationsResource Applications { get; }

        /// <summary>Gets the Events resource.</summary>
        public virtual EventsResource Events { get; }

        /// <summary>Gets the Leaderboards resource.</summary>
        public virtual LeaderboardsResource Leaderboards { get; }

        /// <summary>Gets the Metagame resource.</summary>
        public virtual MetagameResource Metagame { get; }

        /// <summary>Gets the Players resource.</summary>
        public virtual PlayersResource Players { get; }

        /// <summary>Gets the Revisions resource.</summary>
        public virtual RevisionsResource Revisions { get; }

        /// <summary>Gets the Scores resource.</summary>
        public virtual ScoresResource Scores { get; }

        /// <summary>Gets the Snapshots resource.</summary>
        public virtual SnapshotsResource Snapshots { get; }

        /// <summary>Gets the Stats resource.</summary>
        public virtual StatsResource Stats { get; }
    }

    /// <summary>A base abstract class for Games requests.</summary>
    public abstract class GamesBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new GamesBaseServiceRequest instance.</summary>
        protected GamesBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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
            Value1,
            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2,
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
            Json,
            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media,
            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto,
        }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string
        /// assigned to a user, but should not exceed 40 characters.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes Games parameter list.</summary>
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

    /// <summary>The "achievementDefinitions" collection of methods.</summary>
    public class AchievementDefinitionsResource
    {
        private const string Resource = "achievementDefinitions";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AchievementDefinitionsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Lists all the achievement definitions for your application.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Lists all the achievement definitions for your application.</summary>
        public class ListRequest : GamesBaseServiceRequest<Google.Apis.Games.v1.Data.AchievementDefinitionsListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }


            /// <summary>The preferred language to use for strings returned by this method.</summary>
            [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Language { get; set; }

            /// <summary>The maximum number of achievement resources to return in the response, used for paging. For any
            /// response, the actual number of achievement resources returned may be less than the specified
            /// `maxResults`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>The token returned by the previous request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1/achievements";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("language", new Google.Apis.Discovery.Parameter
                {
                    Name = "language",
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


        /// <summary>Increments the steps of the achievement with the given ID for the currently authenticated
        /// player.</summary>
        /// <param name="achievementId">The ID of the achievement used by this method.</param>
        /// <param
        /// name="stepsToIncrement">The number of steps to increment.</param>
        public virtual IncrementRequest Increment(string achievementId, int stepsToIncrement)
        {
            return new IncrementRequest(service, achievementId, stepsToIncrement);
        }

        /// <summary>Increments the steps of the achievement with the given ID for the currently authenticated
        /// player.</summary>
        public class IncrementRequest : GamesBaseServiceRequest<Google.Apis.Games.v1.Data.AchievementIncrementResponse>
        {
            /// <summary>Constructs a new Increment request.</summary>
            public IncrementRequest(Google.Apis.Services.IClientService service, string achievementId, int stepsToIncrement) : base(service)
            {
                AchievementId = achievementId;
                StepsToIncrement = stepsToIncrement;
                InitParameters();
            }


            /// <summary>The ID of the achievement used by this method.</summary>
            [Google.Apis.Util.RequestParameterAttribute("achievementId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string AchievementId { get; private set; }

            /// <summary>The number of steps to increment.</summary>
            [Google.Apis.Util.RequestParameterAttribute("stepsToIncrement", Google.Apis.Util.RequestParameterType.Query)]
            public virtual int StepsToIncrement { get; private set; }

            /// <summary>A randomly generated numeric ID for each request specified by the caller. This number is used
            /// at the server to ensure that the request is handled correctly across retries.</summary>
            [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> RequestId { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "increment";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1/achievements/{achievementId}/increment";

            /// <summary>Initializes Increment parameter list.</summary>
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
                RequestParameters.Add("stepsToIncrement", new Google.Apis.Discovery.Parameter
                {
                    Name = "stepsToIncrement",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                {
                    Name = "requestId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Lists the progress for all your application's achievements for the currently authenticated
        /// player.</summary>
        /// <param name="playerId">A player ID. A value of `me` may be used in place of the authenticated player's
        /// ID.</param>
        public virtual ListRequest List(string playerId)
        {
            return new ListRequest(service, playerId);
        }

        /// <summary>Lists the progress for all your application's achievements for the currently authenticated
        /// player.</summary>
        public class ListRequest : GamesBaseServiceRequest<Google.Apis.Games.v1.Data.PlayerAchievementListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string playerId) : base(service)
            {
                PlayerId = playerId;
                InitParameters();
            }


            /// <summary>A player ID. A value of `me` may be used in place of the authenticated player's ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("playerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PlayerId { get; private set; }

            /// <summary>The preferred language to use for strings returned by this method.</summary>
            [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Language { get; set; }

            /// <summary>The maximum number of achievement resources to return in the response, used for paging. For any
            /// response, the actual number of achievement resources returned may be less than the specified
            /// `maxResults`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>The token returned by the previous request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Tells the server to return only achievements with the specified state. If this parameter isn't
            /// specified, all achievements are returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("state", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<StateEnum> State { get; set; }

            /// <summary>Tells the server to return only achievements with the specified state. If this parameter isn't
            /// specified, all achievements are returned.</summary>
            public enum StateEnum
            {
                /// <summary>List all achievements. This is the default.</summary>
                [Google.Apis.Util.StringValueAttribute("ALL")]
                ALL,
                /// <summary>List only hidden achievements.</summary>
                [Google.Apis.Util.StringValueAttribute("HIDDEN")]
                HIDDEN,
                /// <summary>List only revealed achievements.</summary>
                [Google.Apis.Util.StringValueAttribute("REVEALED")]
                REVEALED,
                /// <summary>List only unlocked achievements.</summary>
                [Google.Apis.Util.StringValueAttribute("UNLOCKED")]
                UNLOCKED,
            }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1/players/{playerId}/achievements";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("playerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "playerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("language", new Google.Apis.Discovery.Parameter
                {
                    Name = "language",
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
                RequestParameters.Add("state", new Google.Apis.Discovery.Parameter
                {
                    Name = "state",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Sets the state of the achievement with the given ID to `REVEALED` for the currently authenticated
        /// player.</summary>
        /// <param name="achievementId">The ID of the achievement used by this method.</param>
        public virtual RevealRequest Reveal(string achievementId)
        {
            return new RevealRequest(service, achievementId);
        }

        /// <summary>Sets the state of the achievement with the given ID to `REVEALED` for the currently authenticated
        /// player.</summary>
        public class RevealRequest : GamesBaseServiceRequest<Google.Apis.Games.v1.Data.AchievementRevealResponse>
        {
            /// <summary>Constructs a new Reveal request.</summary>
            public RevealRequest(Google.Apis.Services.IClientService service, string achievementId) : base(service)
            {
                AchievementId = achievementId;
                InitParameters();
            }


            /// <summary>The ID of the achievement used by this method.</summary>
            [Google.Apis.Util.RequestParameterAttribute("achievementId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string AchievementId { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "reveal";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1/achievements/{achievementId}/reveal";

            /// <summary>Initializes Reveal parameter list.</summary>
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

        /// <summary>Sets the steps for the currently authenticated player towards unlocking an achievement. If the
        /// steps parameter is less than the current number of steps that the player already gained for the achievement,
        /// the achievement is not modified.</summary>
        /// <param name="achievementId">The ID of the achievement used by this method.</param>
        /// <param name="steps">The
        /// minimum value to set the steps to.</param>
        public virtual SetStepsAtLeastRequest SetStepsAtLeast(string achievementId, int steps)
        {
            return new SetStepsAtLeastRequest(service, achievementId, steps);
        }

        /// <summary>Sets the steps for the currently authenticated player towards unlocking an achievement. If the
        /// steps parameter is less than the current number of steps that the player already gained for the achievement,
        /// the achievement is not modified.</summary>
        public class SetStepsAtLeastRequest : GamesBaseServiceRequest<Google.Apis.Games.v1.Data.AchievementSetStepsAtLeastResponse>
        {
            /// <summary>Constructs a new SetStepsAtLeast request.</summary>
            public SetStepsAtLeastRequest(Google.Apis.Services.IClientService service, string achievementId, int steps) : base(service)
            {
                AchievementId = achievementId;
                Steps = steps;
                InitParameters();
            }


            /// <summary>The ID of the achievement used by this method.</summary>
            [Google.Apis.Util.RequestParameterAttribute("achievementId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string AchievementId { get; private set; }

            /// <summary>The minimum value to set the steps to.</summary>
            [Google.Apis.Util.RequestParameterAttribute("steps", Google.Apis.Util.RequestParameterType.Query)]
            public virtual int Steps { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "setStepsAtLeast";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1/achievements/{achievementId}/setStepsAtLeast";

            /// <summary>Initializes SetStepsAtLeast parameter list.</summary>
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
                RequestParameters.Add("steps", new Google.Apis.Discovery.Parameter
                {
                    Name = "steps",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Unlocks this achievement for the currently authenticated player.</summary>
        /// <param name="achievementId">The ID of the achievement used by this method.</param>
        public virtual UnlockRequest Unlock(string achievementId)
        {
            return new UnlockRequest(service, achievementId);
        }

        /// <summary>Unlocks this achievement for the currently authenticated player.</summary>
        public class UnlockRequest : GamesBaseServiceRequest<Google.Apis.Games.v1.Data.AchievementUnlockResponse>
        {
            /// <summary>Constructs a new Unlock request.</summary>
            public UnlockRequest(Google.Apis.Services.IClientService service, string achievementId) : base(service)
            {
                AchievementId = achievementId;
                InitParameters();
            }


            /// <summary>The ID of the achievement used by this method.</summary>
            [Google.Apis.Util.RequestParameterAttribute("achievementId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string AchievementId { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "unlock";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1/achievements/{achievementId}/unlock";

            /// <summary>Initializes Unlock parameter list.</summary>
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

        /// <summary>Updates multiple achievements for the currently authenticated player.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual UpdateMultipleRequest UpdateMultiple(Google.Apis.Games.v1.Data.AchievementUpdateMultipleRequest body)
        {
            return new UpdateMultipleRequest(service, body);
        }

        /// <summary>Updates multiple achievements for the currently authenticated player.</summary>
        public class UpdateMultipleRequest : GamesBaseServiceRequest<Google.Apis.Games.v1.Data.AchievementUpdateMultipleResponse>
        {
            /// <summary>Constructs a new UpdateMultiple request.</summary>
            public UpdateMultipleRequest(Google.Apis.Services.IClientService service, Google.Apis.Games.v1.Data.AchievementUpdateMultipleRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Games.v1.Data.AchievementUpdateMultipleRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateMultiple";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1/achievements/updateMultiple";

            /// <summary>Initializes UpdateMultiple parameter list.</summary>
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


        /// <summary>Retrieves the metadata of the application with the given ID. If the requested application is not
        /// available for the specified `platformType`, the returned response will not include any instance
        /// data.</summary>
        /// <param name="applicationId">The application ID from the Google Play developer console.</param>
        public virtual GetRequest Get(string applicationId)
        {
            return new GetRequest(service, applicationId);
        }

        /// <summary>Retrieves the metadata of the application with the given ID. If the requested application is not
        /// available for the specified `platformType`, the returned response will not include any instance
        /// data.</summary>
        public class GetRequest : GamesBaseServiceRequest<Google.Apis.Games.v1.Data.Application>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string applicationId) : base(service)
            {
                ApplicationId = applicationId;
                InitParameters();
            }


            /// <summary>The application ID from the Google Play developer console.</summary>
            [Google.Apis.Util.RequestParameterAttribute("applicationId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ApplicationId { get; private set; }

            /// <summary>The preferred language to use for strings returned by this method.</summary>
            [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Language { get; set; }

            /// <summary>Restrict application details returned to the specific platform.</summary>
            [Google.Apis.Util.RequestParameterAttribute("platformType", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<PlatformTypeEnum> PlatformType { get; set; }

            /// <summary>Restrict application details returned to the specific platform.</summary>
            public enum PlatformTypeEnum
            {
                /// <summary>Default value, don't use.</summary>
                [Google.Apis.Util.StringValueAttribute("PLATFORM_TYPE_UNSPECIFIED")]
                PLATFORMTYPEUNSPECIFIED,
                /// <summary>Retrieve applications that can be played on Android.</summary>
                [Google.Apis.Util.StringValueAttribute("ANDROID")]
                ANDROID,
                /// <summary>Retrieve applications that can be played on iOS.</summary>
                [Google.Apis.Util.StringValueAttribute("IOS")]
                IOS,
                /// <summary>Retrieve applications that can be played on desktop web.</summary>
                [Google.Apis.Util.StringValueAttribute("WEB_APP")]
                WEBAPP,
            }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1/applications/{applicationId}";

            /// <summary>Initializes Get parameter list.</summary>
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
                RequestParameters.Add("language", new Google.Apis.Discovery.Parameter
                {
                    Name = "language",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("platformType", new Google.Apis.Discovery.Parameter
                {
                    Name = "platformType",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Indicate that the currently authenticated user is playing your application.</summary>
        public virtual PlayedRequest Played()
        {
            return new PlayedRequest(service);
        }

        /// <summary>Indicate that the currently authenticated user is playing your application.</summary>
        public class PlayedRequest : GamesBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Played request.</summary>
            public PlayedRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }



            /// <summary>Gets the method name.</summary>
            public override string MethodName => "played";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1/applications/played";

            /// <summary>Initializes Played parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Verifies the auth token provided with this request is for the application with the specified ID,
        /// and returns the ID of the player it was granted for.</summary>
        /// <param name="applicationId">The application ID from the Google Play developer console.</param>
        public virtual VerifyRequest Verify(string applicationId)
        {
            return new VerifyRequest(service, applicationId);
        }

        /// <summary>Verifies the auth token provided with this request is for the application with the specified ID,
        /// and returns the ID of the player it was granted for.</summary>
        public class VerifyRequest : GamesBaseServiceRequest<Google.Apis.Games.v1.Data.ApplicationVerifyResponse>
        {
            /// <summary>Constructs a new Verify request.</summary>
            public VerifyRequest(Google.Apis.Services.IClientService service, string applicationId) : base(service)
            {
                ApplicationId = applicationId;
                InitParameters();
            }


            /// <summary>The application ID from the Google Play developer console.</summary>
            [Google.Apis.Util.RequestParameterAttribute("applicationId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ApplicationId { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "verify";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1/applications/{applicationId}/verify";

            /// <summary>Initializes Verify parameter list.</summary>
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


        /// <summary>Returns a list showing the current progress on events in this application for the currently
        /// authenticated user.</summary>
        public virtual ListByPlayerRequest ListByPlayer()
        {
            return new ListByPlayerRequest(service);
        }

        /// <summary>Returns a list showing the current progress on events in this application for the currently
        /// authenticated user.</summary>
        public class ListByPlayerRequest : GamesBaseServiceRequest<Google.Apis.Games.v1.Data.PlayerEventListResponse>
        {
            /// <summary>Constructs a new ListByPlayer request.</summary>
            public ListByPlayerRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }


            /// <summary>The preferred language to use for strings returned by this method.</summary>
            [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Language { get; set; }

            /// <summary>The maximum number of events to return in the response, used for paging. For any response, the
            /// actual number of events to return may be less than the specified maxResults.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>The token returned by the previous request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "listByPlayer";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1/events";

            /// <summary>Initializes ListByPlayer parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("language", new Google.Apis.Discovery.Parameter
                {
                    Name = "language",
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

        /// <summary>Returns a list of the event definitions in this application.</summary>
        public virtual ListDefinitionsRequest ListDefinitions()
        {
            return new ListDefinitionsRequest(service);
        }

        /// <summary>Returns a list of the event definitions in this application.</summary>
        public class ListDefinitionsRequest : GamesBaseServiceRequest<Google.Apis.Games.v1.Data.EventDefinitionListResponse>
        {
            /// <summary>Constructs a new ListDefinitions request.</summary>
            public ListDefinitionsRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }


            /// <summary>The preferred language to use for strings returned by this method.</summary>
            [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Language { get; set; }

            /// <summary>The maximum number of event definitions to return in the response, used for paging. For any
            /// response, the actual number of event definitions to return may be less than the specified
            /// `maxResults`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>The token returned by the previous request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "listDefinitions";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1/eventDefinitions";

            /// <summary>Initializes ListDefinitions parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("language", new Google.Apis.Discovery.Parameter
                {
                    Name = "language",
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

        /// <summary>Records a batch of changes to the number of times events have occurred for the currently
        /// authenticated user of this application.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual RecordRequest Record(Google.Apis.Games.v1.Data.EventRecordRequest body)
        {
            return new RecordRequest(service, body);
        }

        /// <summary>Records a batch of changes to the number of times events have occurred for the currently
        /// authenticated user of this application.</summary>
        public class RecordRequest : GamesBaseServiceRequest<Google.Apis.Games.v1.Data.EventUpdateResponse>
        {
            /// <summary>Constructs a new Record request.</summary>
            public RecordRequest(Google.Apis.Services.IClientService service, Google.Apis.Games.v1.Data.EventRecordRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }


            /// <summary>The preferred language to use for strings returned by this method.</summary>
            [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Language { get; set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Games.v1.Data.EventRecordRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "record";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1/events";

            /// <summary>Initializes Record parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("language", new Google.Apis.Discovery.Parameter
                {
                    Name = "language",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }
    }

    /// <summary>The "leaderboards" collection of methods.</summary>
    public class LeaderboardsResource
    {
        private const string Resource = "leaderboards";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public LeaderboardsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Retrieves the metadata of the leaderboard with the given ID.</summary>
        /// <param name="leaderboardId">The ID of the leaderboard.</param>
        public virtual GetRequest Get(string leaderboardId)
        {
            return new GetRequest(service, leaderboardId);
        }

        /// <summary>Retrieves the metadata of the leaderboard with the given ID.</summary>
        public class GetRequest : GamesBaseServiceRequest<Google.Apis.Games.v1.Data.Leaderboard>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string leaderboardId) : base(service)
            {
                LeaderboardId = leaderboardId;
                InitParameters();
            }


            /// <summary>The ID of the leaderboard.</summary>
            [Google.Apis.Util.RequestParameterAttribute("leaderboardId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string LeaderboardId { get; private set; }

            /// <summary>The preferred language to use for strings returned by this method.</summary>
            [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Language { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1/leaderboards/{leaderboardId}";

            /// <summary>Initializes Get parameter list.</summary>
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
                RequestParameters.Add("language", new Google.Apis.Discovery.Parameter
                {
                    Name = "language",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Lists all the leaderboard metadata for your application.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Lists all the leaderboard metadata for your application.</summary>
        public class ListRequest : GamesBaseServiceRequest<Google.Apis.Games.v1.Data.LeaderboardListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }


            /// <summary>The preferred language to use for strings returned by this method.</summary>
            [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Language { get; set; }

            /// <summary>The maximum number of leaderboards to return in the response. For any response, the actual
            /// number of leaderboards returned may be less than the specified `maxResults`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>The token returned by the previous request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1/leaderboards";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("language", new Google.Apis.Discovery.Parameter
                {
                    Name = "language",
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

    /// <summary>The "metagame" collection of methods.</summary>
    public class MetagameResource
    {
        private const string Resource = "metagame";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public MetagameResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Return the metagame configuration data for the calling application.</summary>
        public virtual GetMetagameConfigRequest GetMetagameConfig()
        {
            return new GetMetagameConfigRequest(service);
        }

        /// <summary>Return the metagame configuration data for the calling application.</summary>
        public class GetMetagameConfigRequest : GamesBaseServiceRequest<Google.Apis.Games.v1.Data.MetagameConfig>
        {
            /// <summary>Constructs a new GetMetagameConfig request.</summary>
            public GetMetagameConfigRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }



            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getMetagameConfig";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1/metagameConfig";

            /// <summary>Initializes GetMetagameConfig parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>List play data aggregated per category for the player corresponding to `playerId`.</summary>
        /// <param name="playerId">A player ID. A value of `me` may be used in place of the authenticated player's
        /// ID.</param>
        /// <param name="collection">The collection of categories for which data will be
        /// returned.</param>
        public virtual ListCategoriesByPlayerRequest ListCategoriesByPlayer(string playerId, ListCategoriesByPlayerRequest.CollectionEnum collection)
        {
            return new ListCategoriesByPlayerRequest(service, playerId, collection);
        }

        /// <summary>List play data aggregated per category for the player corresponding to `playerId`.</summary>
        public class ListCategoriesByPlayerRequest : GamesBaseServiceRequest<Google.Apis.Games.v1.Data.CategoryListResponse>
        {
            /// <summary>Constructs a new ListCategoriesByPlayer request.</summary>
            public ListCategoriesByPlayerRequest(Google.Apis.Services.IClientService service, string playerId, ListCategoriesByPlayerRequest.CollectionEnum collection) : base(service)
            {
                PlayerId = playerId;
                Collection = collection;
                InitParameters();
            }


            /// <summary>A player ID. A value of `me` may be used in place of the authenticated player's ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("playerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PlayerId { get; private set; }

            /// <summary>The collection of categories for which data will be returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("collection", Google.Apis.Util.RequestParameterType.Path)]
            public virtual CollectionEnum Collection { get; private set; }

            /// <summary>The collection of categories for which data will be returned.</summary>
            public enum CollectionEnum
            {
                /// <summary>Default value. This value is unused.</summary>
                [Google.Apis.Util.StringValueAttribute("COLLECTION_UNSPECIFIED")]
                COLLECTIONUNSPECIFIED,
                /// <summary>Retrieve data for all categories. This is the default.</summary>
                [Google.Apis.Util.StringValueAttribute("ALL")]
                ALL,
            }

            /// <summary>The preferred language to use for strings returned by this method.</summary>
            [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Language { get; set; }

            /// <summary>The maximum number of category resources to return in the response, used for paging. For any
            /// response, the actual number of category resources returned may be less than the specified
            /// `maxResults`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>The token returned by the previous request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "listCategoriesByPlayer";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1/players/{playerId}/categories/{collection}";

            /// <summary>Initializes ListCategoriesByPlayer parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("playerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "playerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("collection", new Google.Apis.Discovery.Parameter
                {
                    Name = "collection",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("language", new Google.Apis.Discovery.Parameter
                {
                    Name = "language",
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


        /// <summary>Retrieves the Player resource with the given ID. To retrieve the player for the currently
        /// authenticated user, set `playerId` to `me`.</summary>
        /// <param name="playerId">A player ID. A value of `me` may be used in place of the authenticated player's
        /// ID.</param>
        public virtual GetRequest Get(string playerId)
        {
            return new GetRequest(service, playerId);
        }

        /// <summary>Retrieves the Player resource with the given ID. To retrieve the player for the currently
        /// authenticated user, set `playerId` to `me`.</summary>
        public class GetRequest : GamesBaseServiceRequest<Google.Apis.Games.v1.Data.Player>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string playerId) : base(service)
            {
                PlayerId = playerId;
                InitParameters();
            }


            /// <summary>A player ID. A value of `me` may be used in place of the authenticated player's ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("playerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PlayerId { get; private set; }

            /// <summary>The preferred language to use for strings returned by this method.</summary>
            [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Language { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1/players/{playerId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("playerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "playerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("language", new Google.Apis.Discovery.Parameter
                {
                    Name = "language",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Get the collection of players for the currently authenticated user.</summary>
        /// <param name="collection">Collection of players being retrieved</param>
        public virtual ListRequest List(ListRequest.CollectionEnum collection)
        {
            return new ListRequest(service, collection);
        }

        /// <summary>Get the collection of players for the currently authenticated user.</summary>
        public class ListRequest : GamesBaseServiceRequest<Google.Apis.Games.v1.Data.PlayerListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, ListRequest.CollectionEnum collection) : base(service)
            {
                Collection = collection;
                InitParameters();
            }


            /// <summary>Collection of players being retrieved</summary>
            [Google.Apis.Util.RequestParameterAttribute("collection", Google.Apis.Util.RequestParameterType.Path)]
            public virtual CollectionEnum Collection { get; private set; }

            /// <summary>Collection of players being retrieved</summary>
            public enum CollectionEnum
            {
                /// <summary>Retrieve a list of players that are also playing this game in reverse chronological
                /// order.</summary>
                [Google.Apis.Util.StringValueAttribute("CONNECTED")]
                CONNECTED,
                /// <summary>Retrieve a list of players in the user's social graph that are visible to this
                /// game.</summary>
                [Google.Apis.Util.StringValueAttribute("VISIBLE")]
                VISIBLE,
                /// <summary>Retrieve a list of players who are friends of the user in alphabetical order.</summary>
                [Google.Apis.Util.StringValueAttribute("FRIENDS_ALL")]
                FRIENDSALL,
            }

            /// <summary>The preferred language to use for strings returned by this method.</summary>
            [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Language { get; set; }

            /// <summary>The maximum number of player resources to return in the response, used for paging. For any
            /// response, the actual number of player resources returned may be less than the specified
            /// `maxResults`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>The token returned by the previous request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1/players/me/players/{collection}";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("collection", new Google.Apis.Discovery.Parameter
                {
                    Name = "collection",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("language", new Google.Apis.Discovery.Parameter
                {
                    Name = "language",
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

    /// <summary>The "revisions" collection of methods.</summary>
    public class RevisionsResource
    {
        private const string Resource = "revisions";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public RevisionsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Checks whether the games client is out of date.</summary>
        /// <param name="clientRevision">The revision of the client SDK used by your application. Format:
        /// `[PLATFORM_TYPE]:[VERSION_NUMBER]`. Possible values of `PLATFORM_TYPE` are: * `ANDROID` - Client is running the
        /// Android SDK. * `IOS` - Client is running the iOS SDK. * `WEB_APP` - Client is running as a Web App.</param>
        public virtual CheckRequest Check(string clientRevision)
        {
            return new CheckRequest(service, clientRevision);
        }

        /// <summary>Checks whether the games client is out of date.</summary>
        public class CheckRequest : GamesBaseServiceRequest<Google.Apis.Games.v1.Data.RevisionCheckResponse>
        {
            /// <summary>Constructs a new Check request.</summary>
            public CheckRequest(Google.Apis.Services.IClientService service, string clientRevision) : base(service)
            {
                ClientRevision = clientRevision;
                InitParameters();
            }


            /// <summary>The revision of the client SDK used by your application. Format:
            /// `[PLATFORM_TYPE]:[VERSION_NUMBER]`. Possible values of `PLATFORM_TYPE` are: * `ANDROID` - Client is
            /// running the Android SDK. * `IOS` - Client is running the iOS SDK. * `WEB_APP` - Client is running as a
            /// Web App.</summary>
            [Google.Apis.Util.RequestParameterAttribute("clientRevision", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientRevision { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "check";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1/revisions/check";

            /// <summary>Initializes Check parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("clientRevision", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientRevision",
                    IsRequired = true,
                    ParameterType = "query",
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


        /// <summary>Get high scores, and optionally ranks, in leaderboards for the currently authenticated player. For
        /// a specific time span, `leaderboardId` can be set to `ALL` to retrieve data for all leaderboards in a given
        /// time span. `NOTE: You cannot ask for 'ALL' leaderboards and 'ALL' timeSpans in the same request; only one
        /// parameter may be set to 'ALL'.</summary>
        /// <param name="playerId">A player ID. A value of `me` may be used in place of the authenticated player's
        /// ID.</param>
        /// <param name="leaderboardId">The ID of the leaderboard. Can be set to 'ALL' to retrieve data for
        /// all leaderboards for this application.</param>
        /// <param name="timeSpan">The time span for the scores and ranks
        /// you're requesting.</param>
        public virtual GetRequest Get(string playerId, string leaderboardId, GetRequest.TimeSpanEnum timeSpan)
        {
            return new GetRequest(service, playerId, leaderboardId, timeSpan);
        }

        /// <summary>Get high scores, and optionally ranks, in leaderboards for the currently authenticated player. For
        /// a specific time span, `leaderboardId` can be set to `ALL` to retrieve data for all leaderboards in a given
        /// time span. `NOTE: You cannot ask for 'ALL' leaderboards and 'ALL' timeSpans in the same request; only one
        /// parameter may be set to 'ALL'.</summary>
        public class GetRequest : GamesBaseServiceRequest<Google.Apis.Games.v1.Data.PlayerLeaderboardScoreListResponse>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string playerId, string leaderboardId, GetRequest.TimeSpanEnum timeSpan) : base(service)
            {
                PlayerId = playerId;
                LeaderboardId = leaderboardId;
                TimeSpan = timeSpan;
                InitParameters();
            }


            /// <summary>A player ID. A value of `me` may be used in place of the authenticated player's ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("playerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PlayerId { get; private set; }

            /// <summary>The ID of the leaderboard. Can be set to 'ALL' to retrieve data for all leaderboards for this
            /// application.</summary>
            [Google.Apis.Util.RequestParameterAttribute("leaderboardId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string LeaderboardId { get; private set; }

            /// <summary>The time span for the scores and ranks you're requesting.</summary>
            [Google.Apis.Util.RequestParameterAttribute("timeSpan", Google.Apis.Util.RequestParameterType.Path)]
            public virtual TimeSpanEnum TimeSpan { get; private set; }

            /// <summary>The time span for the scores and ranks you're requesting.</summary>
            public enum TimeSpanEnum
            {
                /// <summary>Default value. This value is unused.</summary>
                [Google.Apis.Util.StringValueAttribute("SCORE_TIME_SPAN_UNSPECIFIED")]
                SCORETIMESPANUNSPECIFIED,
                /// <summary>Get the high scores for all time spans. If this is used, maxResults values will be
                /// ignored.</summary>
                [Google.Apis.Util.StringValueAttribute("ALL")]
                ALL,
                /// <summary>Get the all time high score.</summary>
                [Google.Apis.Util.StringValueAttribute("ALL_TIME")]
                ALLTIME,
                /// <summary>List the top scores for the current day.</summary>
                [Google.Apis.Util.StringValueAttribute("WEEKLY")]
                WEEKLY,
                /// <summary>List the top scores for the current week.</summary>
                [Google.Apis.Util.StringValueAttribute("DAILY")]
                DAILY,
            }

            /// <summary>The types of ranks to return. If the parameter is omitted, no ranks will be returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("includeRankType", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<IncludeRankTypeEnum> IncludeRankType { get; set; }

            /// <summary>The types of ranks to return. If the parameter is omitted, no ranks will be returned.</summary>
            public enum IncludeRankTypeEnum
            {
                /// <summary>Default value. Should be unused.</summary>
                [Google.Apis.Util.StringValueAttribute("INCLUDE_RANK_TYPE_UNSPECIFIED")]
                INCLUDERANKTYPEUNSPECIFIED,
                /// <summary>Retrieve all supported ranks. In HTTP, this parameter value can also be specified as
                /// `ALL`.</summary>
                [Google.Apis.Util.StringValueAttribute("ALL")]
                ALL,
                /// <summary>Retrieve public ranks, if the player is sharing their gameplay activity publicly.</summary>
                [Google.Apis.Util.StringValueAttribute("PUBLIC")]
                PUBLIC__,
                /// <summary>(Obsolete) Retrieve the social rank.</summary>
                [Google.Apis.Util.StringValueAttribute("SOCIAL")]
                SOCIAL,
                /// <summary>Retrieve the rank on the friends collection.</summary>
                [Google.Apis.Util.StringValueAttribute("FRIENDS")]
                FRIENDS,
            }

            /// <summary>The preferred language to use for strings returned by this method.</summary>
            [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Language { get; set; }

            /// <summary>The maximum number of leaderboard scores to return in the response. For any response, the
            /// actual number of leaderboard scores returned may be less than the specified `maxResults`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>The token returned by the previous request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1/players/{playerId}/leaderboards/{leaderboardId}/scores/{timeSpan}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("playerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "playerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("leaderboardId", new Google.Apis.Discovery.Parameter
                {
                    Name = "leaderboardId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("timeSpan", new Google.Apis.Discovery.Parameter
                {
                    Name = "timeSpan",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("includeRankType", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeRankType",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("language", new Google.Apis.Discovery.Parameter
                {
                    Name = "language",
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

        /// <summary>Lists the scores in a leaderboard, starting from the top.</summary>
        /// <param name="leaderboardId">The ID of the leaderboard.</param>
        /// <param name="collection">The collection of
        /// scores you're requesting.</param>
        /// <param name="timeSpan">The time span for the scores and ranks you're
        /// requesting.</param>
        public virtual ListRequest List(string leaderboardId, ListRequest.CollectionEnum collection, ListRequest.TimeSpanEnum timeSpan)
        {
            return new ListRequest(service, leaderboardId, collection, timeSpan);
        }

        /// <summary>Lists the scores in a leaderboard, starting from the top.</summary>
        public class ListRequest : GamesBaseServiceRequest<Google.Apis.Games.v1.Data.LeaderboardScores>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string leaderboardId, ListRequest.CollectionEnum collection, ListRequest.TimeSpanEnum timeSpan) : base(service)
            {
                LeaderboardId = leaderboardId;
                Collection = collection;
                TimeSpan = timeSpan;
                InitParameters();
            }


            /// <summary>The ID of the leaderboard.</summary>
            [Google.Apis.Util.RequestParameterAttribute("leaderboardId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string LeaderboardId { get; private set; }

            /// <summary>The collection of scores you're requesting.</summary>
            [Google.Apis.Util.RequestParameterAttribute("collection", Google.Apis.Util.RequestParameterType.Path)]
            public virtual CollectionEnum Collection { get; private set; }

            /// <summary>The collection of scores you're requesting.</summary>
            public enum CollectionEnum
            {
                /// <summary>Default value. This value is unused.</summary>
                [Google.Apis.Util.StringValueAttribute("SCORE_COLLECTION_UNSPECIFIED")]
                SCORECOLLECTIONUNSPECIFIED,
                /// <summary>List all scores in the public leaderboard.</summary>
                [Google.Apis.Util.StringValueAttribute("PUBLIC")]
                PUBLIC__,
                /// <summary>(Obsolete) Legacy G+ social scores.</summary>
                [Google.Apis.Util.StringValueAttribute("SOCIAL")]
                SOCIAL,
                /// <summary>List only scores of friends.</summary>
                [Google.Apis.Util.StringValueAttribute("FRIENDS")]
                FRIENDS,
            }

            /// <summary>The time span for the scores and ranks you're requesting.</summary>
            [Google.Apis.Util.RequestParameterAttribute("timeSpan", Google.Apis.Util.RequestParameterType.Query)]
            public virtual TimeSpanEnum TimeSpan { get; private set; }

            /// <summary>The time span for the scores and ranks you're requesting.</summary>
            public enum TimeSpanEnum
            {
                /// <summary>Default value. This value is unused.</summary>
                [Google.Apis.Util.StringValueAttribute("SCORE_TIME_SPAN_UNSPECIFIED")]
                SCORETIMESPANUNSPECIFIED,
                /// <summary>The score is an all-time score.</summary>
                [Google.Apis.Util.StringValueAttribute("ALL_TIME")]
                ALLTIME,
                /// <summary>The score is a weekly score.</summary>
                [Google.Apis.Util.StringValueAttribute("WEEKLY")]
                WEEKLY,
                /// <summary>The score is a daily score.</summary>
                [Google.Apis.Util.StringValueAttribute("DAILY")]
                DAILY,
            }

            /// <summary>The preferred language to use for strings returned by this method.</summary>
            [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Language { get; set; }

            /// <summary>The maximum number of leaderboard scores to return in the response. For any response, the
            /// actual number of leaderboard scores returned may be less than the specified `maxResults`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>The token returned by the previous request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1/leaderboards/{leaderboardId}/scores/{collection}";

            /// <summary>Initializes List parameter list.</summary>
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
                RequestParameters.Add("collection", new Google.Apis.Discovery.Parameter
                {
                    Name = "collection",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("timeSpan", new Google.Apis.Discovery.Parameter
                {
                    Name = "timeSpan",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("language", new Google.Apis.Discovery.Parameter
                {
                    Name = "language",
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

        /// <summary>Lists the scores in a leaderboard around (and including) a player's score.</summary>
        /// <param name="leaderboardId">The ID of the leaderboard.</param>
        /// <param name="collection">The collection of
        /// scores you're requesting.</param>
        /// <param name="timeSpan">The time span for the scores and ranks you're
        /// requesting.</param>
        public virtual ListWindowRequest ListWindow(string leaderboardId, ListWindowRequest.CollectionEnum collection, ListWindowRequest.TimeSpanEnum timeSpan)
        {
            return new ListWindowRequest(service, leaderboardId, collection, timeSpan);
        }

        /// <summary>Lists the scores in a leaderboard around (and including) a player's score.</summary>
        public class ListWindowRequest : GamesBaseServiceRequest<Google.Apis.Games.v1.Data.LeaderboardScores>
        {
            /// <summary>Constructs a new ListWindow request.</summary>
            public ListWindowRequest(Google.Apis.Services.IClientService service, string leaderboardId, ListWindowRequest.CollectionEnum collection, ListWindowRequest.TimeSpanEnum timeSpan) : base(service)
            {
                LeaderboardId = leaderboardId;
                Collection = collection;
                TimeSpan = timeSpan;
                InitParameters();
            }


            /// <summary>The ID of the leaderboard.</summary>
            [Google.Apis.Util.RequestParameterAttribute("leaderboardId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string LeaderboardId { get; private set; }

            /// <summary>The collection of scores you're requesting.</summary>
            [Google.Apis.Util.RequestParameterAttribute("collection", Google.Apis.Util.RequestParameterType.Path)]
            public virtual CollectionEnum Collection { get; private set; }

            /// <summary>The collection of scores you're requesting.</summary>
            public enum CollectionEnum
            {
                /// <summary>Default value. This value is unused.</summary>
                [Google.Apis.Util.StringValueAttribute("SCORE_COLLECTION_UNSPECIFIED")]
                SCORECOLLECTIONUNSPECIFIED,
                /// <summary>List all scores in the public leaderboard.</summary>
                [Google.Apis.Util.StringValueAttribute("PUBLIC")]
                PUBLIC__,
                /// <summary>(Obsolete) Legacy G+ social scores.</summary>
                [Google.Apis.Util.StringValueAttribute("SOCIAL")]
                SOCIAL,
                /// <summary>List only scores of friends.</summary>
                [Google.Apis.Util.StringValueAttribute("FRIENDS")]
                FRIENDS,
            }

            /// <summary>The time span for the scores and ranks you're requesting.</summary>
            [Google.Apis.Util.RequestParameterAttribute("timeSpan", Google.Apis.Util.RequestParameterType.Query)]
            public virtual TimeSpanEnum TimeSpan { get; private set; }

            /// <summary>The time span for the scores and ranks you're requesting.</summary>
            public enum TimeSpanEnum
            {
                /// <summary>Default value. This value is unused.</summary>
                [Google.Apis.Util.StringValueAttribute("SCORE_TIME_SPAN_UNSPECIFIED")]
                SCORETIMESPANUNSPECIFIED,
                /// <summary>The score is an all-time score.</summary>
                [Google.Apis.Util.StringValueAttribute("ALL_TIME")]
                ALLTIME,
                /// <summary>The score is a weekly score.</summary>
                [Google.Apis.Util.StringValueAttribute("WEEKLY")]
                WEEKLY,
                /// <summary>The score is a daily score.</summary>
                [Google.Apis.Util.StringValueAttribute("DAILY")]
                DAILY,
            }

            /// <summary>The preferred language to use for strings returned by this method.</summary>
            [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Language { get; set; }

            /// <summary>The maximum number of leaderboard scores to return in the response. For any response, the
            /// actual number of leaderboard scores returned may be less than the specified `maxResults`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>The token returned by the previous request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>The preferred number of scores to return above the player's score. More scores may be returned
            /// if the player is at the bottom of the leaderboard; fewer may be returned if the player is at the top.
            /// Must be less than or equal to maxResults.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resultsAbove", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> ResultsAbove { get; set; }

            /// <summary>True if the top scores should be returned when the player is not in the leaderboard. Defaults
            /// to true.</summary>
            [Google.Apis.Util.RequestParameterAttribute("returnTopIfAbsent", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ReturnTopIfAbsent { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "listWindow";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1/leaderboards/{leaderboardId}/window/{collection}";

            /// <summary>Initializes ListWindow parameter list.</summary>
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
                RequestParameters.Add("collection", new Google.Apis.Discovery.Parameter
                {
                    Name = "collection",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("timeSpan", new Google.Apis.Discovery.Parameter
                {
                    Name = "timeSpan",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("language", new Google.Apis.Discovery.Parameter
                {
                    Name = "language",
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
                RequestParameters.Add("resultsAbove", new Google.Apis.Discovery.Parameter
                {
                    Name = "resultsAbove",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("returnTopIfAbsent", new Google.Apis.Discovery.Parameter
                {
                    Name = "returnTopIfAbsent",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Submits a score to the specified leaderboard.</summary>
        /// <param name="leaderboardId">The ID of the leaderboard.</param>
        /// <param name="score">The score you're
        /// submitting. The submitted score is ignored if it is worse than a previously submitted score, where worse depends on
        /// the leaderboard sort order. The meaning of the score value depends on the leaderboard format type. For fixed-point,
        /// the score represents the raw value. For time, the score represents elapsed time in milliseconds. For currency, the
        /// score represents a value in micro units.</param>
        public virtual SubmitRequest Submit(string leaderboardId, long score)
        {
            return new SubmitRequest(service, leaderboardId, score);
        }

        /// <summary>Submits a score to the specified leaderboard.</summary>
        public class SubmitRequest : GamesBaseServiceRequest<Google.Apis.Games.v1.Data.PlayerScoreResponse>
        {
            /// <summary>Constructs a new Submit request.</summary>
            public SubmitRequest(Google.Apis.Services.IClientService service, string leaderboardId, long score) : base(service)
            {
                LeaderboardId = leaderboardId;
                Score = score;
                InitParameters();
            }


            /// <summary>The ID of the leaderboard.</summary>
            [Google.Apis.Util.RequestParameterAttribute("leaderboardId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string LeaderboardId { get; private set; }

            /// <summary>The score you're submitting. The submitted score is ignored if it is worse than a previously
            /// submitted score, where worse depends on the leaderboard sort order. The meaning of the score value
            /// depends on the leaderboard format type. For fixed-point, the score represents the raw value. For time,
            /// the score represents elapsed time in milliseconds. For currency, the score represents a value in micro
            /// units.</summary>
            [Google.Apis.Util.RequestParameterAttribute("score", Google.Apis.Util.RequestParameterType.Query)]
            public virtual long Score { get; private set; }

            /// <summary>The preferred language to use for strings returned by this method.</summary>
            [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Language { get; set; }

            /// <summary>Additional information about the score you're submitting. Values must contain no more than 64
            /// URI-safe characters as defined by section 2.3 of RFC 3986.</summary>
            [Google.Apis.Util.RequestParameterAttribute("scoreTag", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ScoreTag { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "submit";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1/leaderboards/{leaderboardId}/scores";

            /// <summary>Initializes Submit parameter list.</summary>
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
                RequestParameters.Add("score", new Google.Apis.Discovery.Parameter
                {
                    Name = "score",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("language", new Google.Apis.Discovery.Parameter
                {
                    Name = "language",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("scoreTag", new Google.Apis.Discovery.Parameter
                {
                    Name = "scoreTag",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = @"[a-zA-Z0-9-._~]{0,64}",
                });
            }

        }

        /// <summary>Submits multiple scores to leaderboards.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual SubmitMultipleRequest SubmitMultiple(Google.Apis.Games.v1.Data.PlayerScoreSubmissionList body)
        {
            return new SubmitMultipleRequest(service, body);
        }

        /// <summary>Submits multiple scores to leaderboards.</summary>
        public class SubmitMultipleRequest : GamesBaseServiceRequest<Google.Apis.Games.v1.Data.PlayerScoreListResponse>
        {
            /// <summary>Constructs a new SubmitMultiple request.</summary>
            public SubmitMultipleRequest(Google.Apis.Services.IClientService service, Google.Apis.Games.v1.Data.PlayerScoreSubmissionList body) : base(service)
            {
                Body = body;
                InitParameters();
            }


            /// <summary>The preferred language to use for strings returned by this method.</summary>
            [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Language { get; set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Games.v1.Data.PlayerScoreSubmissionList Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "submitMultiple";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1/leaderboards/scores";

            /// <summary>Initializes SubmitMultiple parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("language", new Google.Apis.Discovery.Parameter
                {
                    Name = "language",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }
    }

    /// <summary>The "snapshots" collection of methods.</summary>
    public class SnapshotsResource
    {
        private const string Resource = "snapshots";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public SnapshotsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Retrieves the metadata for a given snapshot ID.</summary>
        /// <param name="snapshotId">The ID of the snapshot.</param>
        public virtual GetRequest Get(string snapshotId)
        {
            return new GetRequest(service, snapshotId);
        }

        /// <summary>Retrieves the metadata for a given snapshot ID.</summary>
        public class GetRequest : GamesBaseServiceRequest<Google.Apis.Games.v1.Data.Snapshot>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string snapshotId) : base(service)
            {
                SnapshotId = snapshotId;
                InitParameters();
            }


            /// <summary>The ID of the snapshot.</summary>
            [Google.Apis.Util.RequestParameterAttribute("snapshotId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SnapshotId { get; private set; }

            /// <summary>The preferred language to use for strings returned by this method.</summary>
            [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Language { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1/snapshots/{snapshotId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("snapshotId", new Google.Apis.Discovery.Parameter
                {
                    Name = "snapshotId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("language", new Google.Apis.Discovery.Parameter
                {
                    Name = "language",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Retrieves a list of snapshots created by your application for the player corresponding to the
        /// player ID.</summary>
        /// <param name="playerId">A player ID. A value of `me` may be used in place of the authenticated player's
        /// ID.</param>
        public virtual ListRequest List(string playerId)
        {
            return new ListRequest(service, playerId);
        }

        /// <summary>Retrieves a list of snapshots created by your application for the player corresponding to the
        /// player ID.</summary>
        public class ListRequest : GamesBaseServiceRequest<Google.Apis.Games.v1.Data.SnapshotListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string playerId) : base(service)
            {
                PlayerId = playerId;
                InitParameters();
            }


            /// <summary>A player ID. A value of `me` may be used in place of the authenticated player's ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("playerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PlayerId { get; private set; }

            /// <summary>The preferred language to use for strings returned by this method.</summary>
            [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Language { get; set; }

            /// <summary>The maximum number of snapshot resources to return in the response, used for paging. For any
            /// response, the actual number of snapshot resources returned may be less than the specified
            /// `maxResults`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>The token returned by the previous request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1/players/{playerId}/snapshots";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("playerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "playerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("language", new Google.Apis.Discovery.Parameter
                {
                    Name = "language",
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

    /// <summary>The "stats" collection of methods.</summary>
    public class StatsResource
    {
        private const string Resource = "stats";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public StatsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Returns engagement and spend statistics in this application for the currently authenticated
        /// user.</summary>
        public virtual GetRequest Get()
        {
            return new GetRequest(service);
        }

        /// <summary>Returns engagement and spend statistics in this application for the currently authenticated
        /// user.</summary>
        public class GetRequest : GamesBaseServiceRequest<Google.Apis.Games.v1.Data.StatsResponse>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }



            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1/stats";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }
    }
}

namespace Google.Apis.Games.v1.Data
{    

    /// <summary>An achievement definition object.</summary>
    public class AchievementDefinition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of the achievement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("achievementType")]
        public virtual string AchievementType { get; set; }

        /// <summary>The description of the achievement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Experience points which will be earned when unlocking this achievement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("experiencePoints")]
        public virtual System.Nullable<long> ExperiencePoints { get; set; }

        /// <summary>The total steps for an incremental achievement as a string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedTotalSteps")]
        public virtual string FormattedTotalSteps { get; set; }

        /// <summary>The ID of the achievement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The initial state of the achievement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initialState")]
        public virtual string InitialState { get; set; }

        /// <summary>Indicates whether the revealed icon image being returned is a default image, or is provided by the
        /// game.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isRevealedIconUrlDefault")]
        public virtual System.Nullable<bool> IsRevealedIconUrlDefault { get; set; }

        /// <summary>Indicates whether the unlocked icon image being returned is a default image, or is game-
        /// provided.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isUnlockedIconUrlDefault")]
        public virtual System.Nullable<bool> IsUnlockedIconUrlDefault { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#achievementDefinition`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The name of the achievement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The image URL for the revealed achievement icon.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revealedIconUrl")]
        public virtual string RevealedIconUrl { get; set; }

        /// <summary>The total steps for an incremental achievement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSteps")]
        public virtual System.Nullable<int> TotalSteps { get; set; }

        /// <summary>The image URL for the unlocked achievement icon.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unlockedIconUrl")]
        public virtual string UnlockedIconUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A list of achievement definition objects.</summary>
    public class AchievementDefinitionsListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The achievement definitions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<AchievementDefinition> Items { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#achievementDefinitionsListResponse`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Token corresponding to the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An achievement increment response</summary>
    public class AchievementIncrementResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The current steps recorded for this incremental achievement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentSteps")]
        public virtual System.Nullable<int> CurrentSteps { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#achievementIncrementResponse`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Whether the current steps for the achievement has reached the number of steps required to
        /// unlock.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newlyUnlocked")]
        public virtual System.Nullable<bool> NewlyUnlocked { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An achievement reveal response</summary>
    public class AchievementRevealResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The current state of the achievement for which a reveal was attempted. This might be `UNLOCKED` if
        /// the achievement was already unlocked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentState")]
        public virtual string CurrentState { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#achievementRevealResponse`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An achievement set steps at least response.</summary>
    public class AchievementSetStepsAtLeastResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The current steps recorded for this incremental achievement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentSteps")]
        public virtual System.Nullable<int> CurrentSteps { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#achievementSetStepsAtLeastResponse`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Whether the current steps for the achievement has reached the number of steps required to
        /// unlock.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newlyUnlocked")]
        public virtual System.Nullable<bool> NewlyUnlocked { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An achievement unlock response</summary>
    public class AchievementUnlockResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#achievementUnlockResponse`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Whether this achievement was newly unlocked (that is, whether the unlock request for the
        /// achievement was the first for the player).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newlyUnlocked")]
        public virtual System.Nullable<bool> NewlyUnlocked { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A list of achievement update requests.</summary>
    public class AchievementUpdateMultipleRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#achievementUpdateMultipleRequest`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The individual achievement update requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updates")]
        public virtual System.Collections.Generic.IList<AchievementUpdateRequest> Updates { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response message for UpdateMultipleAchievements rpc.</summary>
    public class AchievementUpdateMultipleResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#achievementUpdateMultipleResponse`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The updated state of the achievements.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updatedAchievements")]
        public virtual System.Collections.Generic.IList<AchievementUpdateResponse> UpdatedAchievements { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A request to update an achievement.</summary>
    public class AchievementUpdateRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The achievement this update is being applied to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("achievementId")]
        public virtual string AchievementId { get; set; }

        /// <summary>The payload if an update of type `INCREMENT` was requested for the achievement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("incrementPayload")]
        public virtual GamesAchievementIncrement IncrementPayload { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#achievementUpdateRequest`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The payload if an update of type `SET_STEPS_AT_LEAST` was requested for the achievement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("setStepsAtLeastPayload")]
        public virtual GamesAchievementSetStepsAtLeast SetStepsAtLeastPayload { get; set; }

        /// <summary>The type of update being applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateType")]
        public virtual string UpdateType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An updated achievement.</summary>
    public class AchievementUpdateResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The achievement this update is was applied to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("achievementId")]
        public virtual string AchievementId { get; set; }

        /// <summary>The current state of the achievement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentState")]
        public virtual string CurrentState { get; set; }

        /// <summary>The current steps recorded for this achievement if it is incremental.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentSteps")]
        public virtual System.Nullable<int> CurrentSteps { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#achievementUpdateResponse`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Whether this achievement was newly unlocked (that is, whether the unlock request for the
        /// achievement was the first for the player).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newlyUnlocked")]
        public virtual System.Nullable<bool> NewlyUnlocked { get; set; }

        /// <summary>Whether the requested updates actually affected the achievement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateOccurred")]
        public virtual System.Nullable<bool> UpdateOccurred { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The Application resource.</summary>
    public class Application : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of achievements visible to the currently authenticated player.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("achievement_count")]
        public virtual System.Nullable<int> AchievementCount { get; set; }

        /// <summary>The assets of the application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assets")]
        public virtual System.Collections.Generic.IList<ImageAsset> Assets { get; set; }

        /// <summary>The author of the application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("author")]
        public virtual string Author { get; set; }

        /// <summary>The category of the application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual ApplicationCategory Category { get; set; }

        /// <summary>The description of the application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>A list of features that have been enabled for the application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabledFeatures")]
        public virtual System.Collections.Generic.IList<string> EnabledFeatures { get; set; }

        /// <summary>The ID of the application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The instances of the application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instances")]
        public virtual System.Collections.Generic.IList<Instance> Instances { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#application`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The last updated timestamp of the application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdatedTimestamp")]
        public virtual System.Nullable<long> LastUpdatedTimestamp { get; set; }

        /// <summary>The number of leaderboards visible to the currently authenticated player.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("leaderboard_count")]
        public virtual System.Nullable<int> LeaderboardCount { get; set; }

        /// <summary>The name of the application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>A hint to the client UI for what color to use as an app-themed color. The color is given as an RGB
        /// triplet (e.g. "E0E0E0").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("themeColor")]
        public virtual string ThemeColor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An application category object.</summary>
    public class ApplicationCategory : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#applicationCategory`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The primary category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primary")]
        public virtual string Primary { get; set; }

        /// <summary>The secondary category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondary")]
        public virtual string Secondary { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A third party application verification response resource.</summary>
    public class ApplicationVerifyResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An alternate ID that was once used for the player that was issued the auth token used in this
        /// request. (This field is not normally populated.)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alternate_player_id")]
        public virtual string AlternatePlayerId { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#applicationVerifyResponse`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ID of the player that was issued the auth token used in this request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("player_id")]
        public virtual string PlayerId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Data related to individual game categories.</summary>
    public class Category : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The category name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string CategoryValue { get; set; }

        /// <summary>Experience points earned in this category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("experiencePoints")]
        public virtual System.Nullable<long> ExperiencePoints { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#category`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A third party list metagame categories response.</summary>
    public class CategoryListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of categories with usage data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Category> Items { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#categoryListResponse`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Token corresponding to the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A batch update failure resource.</summary>
    public class EventBatchRecordFailure : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The cause for the update failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureCause")]
        public virtual string FailureCause { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#eventBatchRecordFailure`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The time range which was rejected; empty for a request-wide failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual EventPeriodRange Range { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An event child relationship resource.</summary>
    public class EventChild : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the child event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("childId")]
        public virtual string ChildId { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#eventChild`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An event definition resource.</summary>
    public class EventDefinition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of events that are a child of this event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("childEvents")]
        public virtual System.Collections.Generic.IList<EventChild> ChildEvents { get; set; }

        /// <summary>Description of what this event represents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The name to display for the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The ID of the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The base URL for the image that represents the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUrl")]
        public virtual string ImageUrl { get; set; }

        /// <summary>Indicates whether the icon image being returned is a default image, or is game-provided.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isDefaultImageUrl")]
        public virtual System.Nullable<bool> IsDefaultImageUrl { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#eventDefinition`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The visibility of event being tracked in this definition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visibility")]
        public virtual string Visibility { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A ListDefinitions response.</summary>
    public class EventDefinitionListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The event definitions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<EventDefinition> Items { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#eventDefinitionListResponse`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The pagination token for the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An event period time range.</summary>
    public class EventPeriodRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#eventPeriodRange`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The time when this update period ends, in millis, since 1970 UTC (Unix Epoch).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("periodEndMillis")]
        public virtual System.Nullable<long> PeriodEndMillis { get; set; }

        /// <summary>The time when this update period begins, in millis, since 1970 UTC (Unix Epoch).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("periodStartMillis")]
        public virtual System.Nullable<long> PeriodStartMillis { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An event period update resource.</summary>
    public class EventPeriodUpdate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#eventPeriodUpdate`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The time period being covered by this update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timePeriod")]
        public virtual EventPeriodRange TimePeriod { get; set; }

        /// <summary>The updates being made for this time period.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updates")]
        public virtual System.Collections.Generic.IList<EventUpdateRequest> Updates { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An event update failure resource.</summary>
    public class EventRecordFailure : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the event that was not updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        /// <summary>The cause for the update failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureCause")]
        public virtual string FailureCause { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#eventRecordFailure`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An event period update resource.</summary>
    public class EventRecordRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The current time when this update was sent, in milliseconds, since 1970 UTC (Unix Epoch).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentTimeMillis")]
        public virtual System.Nullable<long> CurrentTimeMillis { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#eventRecordRequest`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The request ID used to identify this attempt to record events.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual System.Nullable<long> RequestId { get; set; }

        /// <summary>A list of the time period updates being made in this request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timePeriods")]
        public virtual System.Collections.Generic.IList<EventPeriodUpdate> TimePeriods { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An event period update resource.</summary>
    public class EventUpdateRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the event being modified in this update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("definitionId")]
        public virtual string DefinitionId { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#eventUpdateRequest`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The number of times this event occurred in this time period.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateCount")]
        public virtual System.Nullable<long> UpdateCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An event period update resource.</summary>
    public class EventUpdateResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Any batch-wide failures which occurred applying updates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchFailures")]
        public virtual System.Collections.Generic.IList<EventBatchRecordFailure> BatchFailures { get; set; }

        /// <summary>Any failures updating a particular event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventFailures")]
        public virtual System.Collections.Generic.IList<EventRecordFailure> EventFailures { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#eventUpdateResponse`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The current status of any updated events</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("playerEvents")]
        public virtual System.Collections.Generic.IList<PlayerEvent> PlayerEvents { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The payload to request to increment an achievement.</summary>
    public class GamesAchievementIncrement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#GamesAchievementIncrement`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The requestId associated with an increment to an achievement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual System.Nullable<long> RequestId { get; set; }

        /// <summary>The number of steps to be incremented.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("steps")]
        public virtual System.Nullable<int> Steps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The payload to request to increment an achievement.</summary>
    public class GamesAchievementSetStepsAtLeast : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#GamesAchievementSetStepsAtLeast`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The minimum number of steps for the achievement to be set to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("steps")]
        public virtual System.Nullable<int> Steps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An image asset object.</summary>
    public class ImageAsset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The height of the asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual System.Nullable<int> Height { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#imageAsset`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The name of the asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The URL of the asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The width of the asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<int> Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The Instance resource.</summary>
    public class Instance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>URI which shows where a user can acquire this instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acquisitionUri")]
        public virtual string AcquisitionUri { get; set; }

        /// <summary>Platform dependent details for Android.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidInstance")]
        public virtual InstanceAndroidDetails AndroidInstance { get; set; }

        /// <summary>Platform dependent details for iOS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosInstance")]
        public virtual InstanceIosDetails IosInstance { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#instance`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Localized display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The platform type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platformType")]
        public virtual string PlatformType { get; set; }

        /// <summary>Flag to show if this game instance supports realtime play.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("realtimePlay")]
        public virtual System.Nullable<bool> RealtimePlay { get; set; }

        /// <summary>Flag to show if this game instance supports turn based play.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("turnBasedPlay")]
        public virtual System.Nullable<bool> TurnBasedPlay { get; set; }

        /// <summary>Platform dependent details for Web.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webInstance")]
        public virtual InstanceWebDetails WebInstance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The Android instance details resource.</summary>
    public class InstanceAndroidDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Flag indicating whether the anti-piracy check is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enablePiracyCheck")]
        public virtual System.Nullable<bool> EnablePiracyCheck { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#instanceAndroidDetails`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Android package name which maps to Google Play URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>Indicates that this instance is the default for new installations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preferred")]
        public virtual System.Nullable<bool> Preferred { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The iOS details resource.</summary>
    public class InstanceIosDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Bundle identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bundleIdentifier")]
        public virtual string BundleIdentifier { get; set; }

        /// <summary>iTunes App ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itunesAppId")]
        public virtual string ItunesAppId { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#instanceIosDetails`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Indicates that this instance is the default for new installations on iPad devices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preferredForIpad")]
        public virtual System.Nullable<bool> PreferredForIpad { get; set; }

        /// <summary>Indicates that this instance is the default for new installations on iPhone devices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preferredForIphone")]
        public virtual System.Nullable<bool> PreferredForIphone { get; set; }

        /// <summary>Flag to indicate if this instance supports iPad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportIpad")]
        public virtual System.Nullable<bool> SupportIpad { get; set; }

        /// <summary>Flag to indicate if this instance supports iPhone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportIphone")]
        public virtual System.Nullable<bool> SupportIphone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The Web details resource.</summary>
    public class InstanceWebDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#instanceWebDetails`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Launch URL for the game.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("launchUrl")]
        public virtual string LaunchUrl { get; set; }

        /// <summary>Indicates that this instance is the default for new installations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preferred")]
        public virtual System.Nullable<bool> Preferred { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The Leaderboard resource.</summary>
    public class Leaderboard : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The icon for the leaderboard.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iconUrl")]
        public virtual string IconUrl { get; set; }

        /// <summary>The leaderboard ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Indicates whether the icon image being returned is a default image, or is game-provided.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isIconUrlDefault")]
        public virtual System.Nullable<bool> IsIconUrlDefault { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#leaderboard`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The name of the leaderboard.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>How scores are ordered.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("order")]
        public virtual string Order { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The Leaderboard Entry resource.</summary>
    public class LeaderboardEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The localized string for the numerical value of this score.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedScore")]
        public virtual string FormattedScore { get; set; }

        /// <summary>The localized string for the rank of this score for this leaderboard.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedScoreRank")]
        public virtual string FormattedScoreRank { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#leaderboardEntry`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The player who holds this score.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("player")]
        public virtual Player Player { get; set; }

        /// <summary>The rank of this score for this leaderboard.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scoreRank")]
        public virtual System.Nullable<long> ScoreRank { get; set; }

        /// <summary>Additional information about the score. Values must contain no more than 64 URI-safe characters as
        /// defined by section 2.3 of RFC 3986.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scoreTag")]
        public virtual string ScoreTag { get; set; }

        /// <summary>The numerical value of this score.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scoreValue")]
        public virtual System.Nullable<long> ScoreValue { get; set; }

        /// <summary>The time span of this high score.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeSpan")]
        public virtual string TimeSpan { get; set; }

        /// <summary>The timestamp at which this score was recorded, in milliseconds since the epoch in UTC.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writeTimestampMillis")]
        public virtual System.Nullable<long> WriteTimestampMillis { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A list of leaderboard objects.</summary>
    public class LeaderboardListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The leaderboards.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Leaderboard> Items { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#leaderboardListResponse`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Token corresponding to the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A score rank in a leaderboard.</summary>
    public class LeaderboardScoreRank : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of scores in the leaderboard as a string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedNumScores")]
        public virtual string FormattedNumScores { get; set; }

        /// <summary>The rank in the leaderboard as a string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedRank")]
        public virtual string FormattedRank { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#leaderboardScoreRank`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The number of scores in the leaderboard.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numScores")]
        public virtual System.Nullable<long> NumScores { get; set; }

        /// <summary>The rank in the leaderboard.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rank")]
        public virtual System.Nullable<long> Rank { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A ListScores response.</summary>
    public class LeaderboardScores : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The scores in the leaderboard.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<LeaderboardEntry> Items { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#leaderboardScores`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The pagination token for the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The total number of scores in the leaderboard.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numScores")]
        public virtual System.Nullable<long> NumScores { get; set; }

        /// <summary>The score of the requesting player on the leaderboard. The player's score may appear both here and
        /// in the list of scores above. If you are viewing a public leaderboard and the player is not sharing their
        /// gameplay information publicly, the `scoreRank`and `formattedScoreRank` values will not be present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("playerScore")]
        public virtual LeaderboardEntry PlayerScore { get; set; }

        /// <summary>The pagination token for the previous page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prevPageToken")]
        public virtual string PrevPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The metagame config resource</summary>
    public class MetagameConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Current version of the metagame configuration data. When this data is updated, the version number
        /// will be increased by one.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentVersion")]
        public virtual System.Nullable<int> CurrentVersion { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#metagameConfig`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The list of player levels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("playerLevels")]
        public virtual System.Collections.Generic.IList<PlayerLevel> PlayerLevels { get; set; }

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
        public virtual PlayerExperienceInfo ExperienceInfo { get; set; }

        /// <summary>The friend status of the given player, relative to the requester. This is unset if the player is
        /// not sharing their friends list with the game.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("friendStatus")]
        public virtual string FriendStatus { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#player`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>A representation of the individual components of the name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual NameData Name { get; set; }

        /// <summary>The player ID that was used for this player the first time they signed into the game in question.
        /// This is only populated for calls to player.get for the requesting player, only if the player ID has
        /// subsequently changed, and only to clients that support remapping player IDs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalPlayerId")]
        public virtual string OriginalPlayerId { get; set; }

        /// <summary>The ID of the player.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("playerId")]
        public virtual string PlayerId { get; set; }

        /// <summary>The player's profile settings. Controls whether or not the player's profile is visible to other
        /// players.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profileSettings")]
        public virtual ProfileSettings ProfileSettings { get; set; }

        /// <summary>The player's title rewarded for their game activities.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
        

        /// <summary>A representation of the individual components of the name.</summary>
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

    /// <summary>An achievement object.</summary>
    public class PlayerAchievement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The state of the achievement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("achievementState")]
        public virtual string AchievementState { get; set; }

        /// <summary>The current steps for an incremental achievement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentSteps")]
        public virtual System.Nullable<int> CurrentSteps { get; set; }

        /// <summary>Experience points earned for the achievement. This field is absent for achievements that have not
        /// yet been unlocked and 0 for achievements that have been unlocked by testers but that are
        /// unpublished.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("experiencePoints")]
        public virtual System.Nullable<long> ExperiencePoints { get; set; }

        /// <summary>The current steps for an incremental achievement as a string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedCurrentStepsString")]
        public virtual string FormattedCurrentStepsString { get; set; }

        /// <summary>The ID of the achievement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#playerAchievement`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The timestamp of the last modification to this achievement's state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdatedTimestamp")]
        public virtual System.Nullable<long> LastUpdatedTimestamp { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A list of achievement objects.</summary>
    public class PlayerAchievementListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The achievements.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<PlayerAchievement> Items { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#playerAchievementListResponse`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Token corresponding to the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An event status resource.</summary>
    public class PlayerEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the event definition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("definitionId")]
        public virtual string DefinitionId { get; set; }

        /// <summary>The current number of times this event has occurred, as a string. The formatting of this string
        /// depends on the configuration of your event in the Play Games Developer Console.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedNumEvents")]
        public virtual string FormattedNumEvents { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#playerEvent`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The current number of times this event has occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numEvents")]
        public virtual System.Nullable<long> NumEvents { get; set; }

        /// <summary>The ID of the player.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("playerId")]
        public virtual string PlayerId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A ListByPlayer response.</summary>
    public class PlayerEventListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The player events.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<PlayerEvent> Items { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#playerEventListResponse`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The pagination token for the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>1P/3P metadata about the player's experience.</summary>
    public class PlayerExperienceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The current number of experience points for the player.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentExperiencePoints")]
        public virtual System.Nullable<long> CurrentExperiencePoints { get; set; }

        /// <summary>The current level of the player.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentLevel")]
        public virtual PlayerLevel CurrentLevel { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#playerExperienceInfo`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The timestamp when the player was leveled up, in millis since Unix epoch UTC.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastLevelUpTimestampMillis")]
        public virtual System.Nullable<long> LastLevelUpTimestampMillis { get; set; }

        /// <summary>The next level of the player. If the current level is the maximum level, this should be same as the
        /// current level.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextLevel")]
        public virtual PlayerLevel NextLevel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A player leaderboard score object.</summary>
    public class PlayerLeaderboardScore : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The rank of the score in the friends collection for this leaderboard.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("friendsRank")]
        public virtual LeaderboardScoreRank FriendsRank { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#playerLeaderboardScore`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ID of the leaderboard this score is in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("leaderboard_id")]
        public virtual string LeaderboardId { get; set; }

        /// <summary>The public rank of the score in this leaderboard. This object will not be present if the user is
        /// not sharing their scores publicly.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicRank")]
        public virtual LeaderboardScoreRank PublicRank { get; set; }

        /// <summary>The formatted value of this score.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scoreString")]
        public virtual string ScoreString { get; set; }

        /// <summary>Additional information about the score. Values must contain no more than 64 URI-safe characters as
        /// defined by section 2.3 of RFC 3986.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scoreTag")]
        public virtual string ScoreTag { get; set; }

        /// <summary>The numerical value of this score.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scoreValue")]
        public virtual System.Nullable<long> ScoreValue { get; set; }

        /// <summary>The social rank of the score in this leaderboard.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("socialRank")]
        public virtual LeaderboardScoreRank SocialRank { get; set; }

        /// <summary>The time span of this score.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeSpan")]
        public virtual string TimeSpan { get; set; }

        /// <summary>The timestamp at which this score was recorded, in milliseconds since the epoch in UTC.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writeTimestamp")]
        public virtual System.Nullable<long> WriteTimestamp { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A list of player leaderboard scores.</summary>
    public class PlayerLeaderboardScoreListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The leaderboard scores.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<PlayerLeaderboardScore> Items { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#playerLeaderboardScoreListResponse`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The pagination token for the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The Player resources for the owner of this score.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("player")]
        public virtual Player Player { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>1P/3P metadata about a user's level.</summary>
    public class PlayerLevel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#playerLevel`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

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

    /// <summary>A third party player list response.</summary>
    public class PlayerListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The players.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Player> Items { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#playerListResponse`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Token corresponding to the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A player score.</summary>
    public class PlayerScore : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The formatted score for this player score.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedScore")]
        public virtual string FormattedScore { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#playerScore`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The numerical value for this player score.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<long> Score { get; set; }

        /// <summary>Additional information about this score. Values will contain no more than 64 URI-safe characters as
        /// defined by section 2.3 of RFC 3986.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scoreTag")]
        public virtual string ScoreTag { get; set; }

        /// <summary>The time span for this player score.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeSpan")]
        public virtual string TimeSpan { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A list of score submission statuses.</summary>
    public class PlayerScoreListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#playerScoreListResponse`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The score submissions statuses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("submittedScores")]
        public virtual System.Collections.Generic.IList<PlayerScoreResponse> SubmittedScores { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A list of leaderboard entry resources.</summary>
    public class PlayerScoreResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time spans where the submitted score is better than the existing score for that time
        /// span.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("beatenScoreTimeSpans")]
        public virtual System.Collections.Generic.IList<string> BeatenScoreTimeSpans { get; set; }

        /// <summary>The formatted value of the submitted score.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedScore")]
        public virtual string FormattedScore { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#playerScoreResponse`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The leaderboard ID that this score was submitted to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("leaderboardId")]
        public virtual string LeaderboardId { get; set; }

        /// <summary>Additional information about this score. Values will contain no more than 64 URI-safe characters as
        /// defined by section 2.3 of RFC 3986.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scoreTag")]
        public virtual string ScoreTag { get; set; }

        /// <summary>The scores in time spans that have not been beaten. As an example, the submitted score may be
        /// better than the player's `DAILY` score, but not better than the player's scores for the `WEEKLY` or
        /// `ALL_TIME` time spans.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unbeatenScores")]
        public virtual System.Collections.Generic.IList<PlayerScore> UnbeatenScores { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A list of score submission requests.</summary>
    public class PlayerScoreSubmissionList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#playerScoreSubmissionList`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The score submissions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scores")]
        public virtual System.Collections.Generic.IList<ScoreSubmission> Scores { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Profile settings</summary>
    public class ProfileSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("friendsListVisibility")]
        public virtual string FriendsListVisibility { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#profileSettings`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Whether the player's profile is visible to the currently signed in player.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profileVisible")]
        public virtual System.Nullable<bool> ProfileVisible { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A third party checking a revision response.</summary>
    public class RevisionCheckResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The version of the API this client revision should use when calling API methods.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#revisionCheckResponse`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The result of the revision check.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionStatus")]
        public virtual string RevisionStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A request to submit a score to leaderboards.</summary>
    public class ScoreSubmission : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#scoreSubmission`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The leaderboard this score is being submitted to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("leaderboardId")]
        public virtual string LeaderboardId { get; set; }

        /// <summary>The new score being submitted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<long> Score { get; set; }

        /// <summary>Additional information about this score. Values will contain no more than 64 URI-safe characters as
        /// defined by section 2.3 of RFC 3986.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scoreTag")]
        public virtual string ScoreTag { get; set; }

        /// <summary>Signature Values will contain URI-safe characters as defined by section 2.3 of RFC 3986.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signature")]
        public virtual string Signature { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An snapshot object.</summary>
    public class Snapshot : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The cover image of this snapshot. May be absent if there is no image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("coverImage")]
        public virtual SnapshotImage CoverImage { get; set; }

        /// <summary>The description of this snapshot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The ID of the file underlying this snapshot in the Drive API. Only present if the snapshot is a
        /// view on a Drive file and the file is owned by the caller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driveId")]
        public virtual string DriveId { get; set; }

        /// <summary>The duration associated with this snapshot, in millis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("durationMillis")]
        public virtual System.Nullable<long> DurationMillis { get; set; }

        /// <summary>The ID of the snapshot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#snapshot`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The timestamp (in millis since Unix epoch) of the last modification to this snapshot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModifiedMillis")]
        public virtual System.Nullable<long> LastModifiedMillis { get; set; }

        /// <summary>The progress value (64-bit integer set by developer) associated with this snapshot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressValue")]
        public virtual System.Nullable<long> ProgressValue { get; set; }

        /// <summary>The title of this snapshot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The type of this snapshot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The unique name provided when the snapshot was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uniqueName")]
        public virtual string UniqueName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An image of a snapshot.</summary>
    public class SnapshotImage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The height of the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual System.Nullable<int> Height { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#snapshotImage`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The MIME type of the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mime_type")]
        public virtual string MimeType { get; set; }

        /// <summary>The URL of the image. This URL may be invalidated at any time and should not be cached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The width of the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<int> Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A third party list snapshots response.</summary>
    public class SnapshotListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The snapshots.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Snapshot> Items { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#snapshotListResponse`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Token corresponding to the next page of results. If there are no more results, the token is
        /// omitted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A third party stats resource.</summary>
    public class StatsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Average session length in minutes of the player. E.g., 1, 30, 60, ... . Not populated if there is
        /// not enough information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("avg_session_length_minutes")]
        public virtual System.Nullable<float> AvgSessionLengthMinutes { get; set; }

        /// <summary>The probability of the player not returning to play the game in the next day. E.g., 0, 0.1, 0.5,
        /// ..., 1.0. Not populated if there is not enough information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("churn_probability")]
        public virtual System.Nullable<float> ChurnProbability { get; set; }

        /// <summary>Number of days since the player last played this game. E.g., 0, 1, 5, 10, ... . Not populated if
        /// there is not enough information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("days_since_last_played")]
        public virtual System.Nullable<int> DaysSinceLastPlayed { get; set; }

        /// <summary>The probability of the player going to spend beyond a threshold amount of money. E.g., 0, 0.25,
        /// 0.50, 0.75. Not populated if there is not enough information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("high_spender_probability")]
        public virtual System.Nullable<float> HighSpenderProbability { get; set; }

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// `games#statsResponse`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Number of in-app purchases made by the player in this game. E.g., 0, 1, 5, 10, ... . Not populated
        /// if there is not enough information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("num_purchases")]
        public virtual System.Nullable<int> NumPurchases { get; set; }

        /// <summary>The approximate number of sessions of the player within the last 28 days, where a session begins
        /// when the player is connected to Play Games Services and ends when they are disconnected. E.g., 0, 1, 5, 10,
        /// ... . Not populated if there is not enough information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("num_sessions")]
        public virtual System.Nullable<int> NumSessions { get; set; }

        /// <summary>The approximation of the sessions percentile of the player within the last 30 days, where a session
        /// begins when the player is connected to Play Games Services and ends when they are disconnected. E.g., 0,
        /// 0.25, 0.5, 0.75. Not populated if there is not enough information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("num_sessions_percentile")]
        public virtual System.Nullable<float> NumSessionsPercentile { get; set; }

        /// <summary>The approximate spend percentile of the player in this game. E.g., 0, 0.25, 0.5, 0.75. Not
        /// populated if there is not enough information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spend_percentile")]
        public virtual System.Nullable<float> SpendPercentile { get; set; }

        /// <summary>The probability of the player going to spend the game in the next seven days. E.g., 0, 0.25, 0.50,
        /// 0.75. Not populated if there is not enough information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spend_probability")]
        public virtual System.Nullable<float> SpendProbability { get; set; }

        /// <summary>The predicted amount of money that the player going to spend in the next 28 days. E.g., 1, 30, 60,
        /// ... . Not populated if there is not enough information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("total_spend_next_28_days")]
        public virtual System.Nullable<float> TotalSpendNext28Days { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
