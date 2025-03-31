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

namespace Google.Apis.GamesConfiguration.v1configuration
{
    /// <summary>The GamesConfiguration Service.</summary>
    public class GamesConfigurationService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1configuration";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public GamesConfigurationService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public GamesConfigurationService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            AchievementConfigurations = new AchievementConfigurationsResource(this);
            LeaderboardConfigurations = new LeaderboardConfigurationsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://gamesconfiguration.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://gamesconfiguration.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "gamesConfiguration";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Google Play Games Services Publishing API.</summary>
        public class Scope
        {
            /// <summary>View and manage your Google Play Developer account</summary>
            public static string Androidpublisher = "https://www.googleapis.com/auth/androidpublisher";
        }

        /// <summary>
        /// Available OAuth 2.0 scope constants for use with the Google Play Games Services Publishing API.
        /// </summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your Google Play Developer account</summary>
            public const string Androidpublisher = "https://www.googleapis.com/auth/androidpublisher";
        }

        /// <summary>Gets the AchievementConfigurations resource.</summary>
        public virtual AchievementConfigurationsResource AchievementConfigurations { get; }

        /// <summary>Gets the LeaderboardConfigurations resource.</summary>
        public virtual LeaderboardConfigurationsResource LeaderboardConfigurations { get; }
    }

    /// <summary>A base abstract class for GamesConfiguration requests.</summary>
    public abstract class GamesConfigurationBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new GamesConfigurationBaseServiceRequest instance.</summary>
        protected GamesConfigurationBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes GamesConfiguration parameter list.</summary>
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

    /// <summary>The "achievementConfigurations" collection of methods.</summary>
    public class AchievementConfigurationsResource
    {
        private const string Resource = "achievementConfigurations";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AchievementConfigurationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Delete the achievement configuration with the given ID.</summary>
        /// <param name="achievementId">The ID of the achievement used by this method.</param>
        public virtual DeleteRequest Delete(string achievementId)
        {
            return new DeleteRequest(this.service, achievementId);
        }

        /// <summary>Delete the achievement configuration with the given ID.</summary>
        public class DeleteRequest : GamesConfigurationBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string achievementId) : base(service)
            {
                AchievementId = achievementId;
                InitParameters();
            }

            /// <summary>The ID of the achievement used by this method.</summary>
            [Google.Apis.Util.RequestParameterAttribute("achievementId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string AchievementId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1configuration/achievements/{achievementId}";

            /// <summary>Initializes Delete parameter list.</summary>
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

        /// <summary>Retrieves the metadata of the achievement configuration with the given ID.</summary>
        /// <param name="achievementId">The ID of the achievement used by this method.</param>
        public virtual GetRequest Get(string achievementId)
        {
            return new GetRequest(this.service, achievementId);
        }

        /// <summary>Retrieves the metadata of the achievement configuration with the given ID.</summary>
        public class GetRequest : GamesConfigurationBaseServiceRequest<Google.Apis.GamesConfiguration.v1configuration.Data.AchievementConfiguration>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string achievementId) : base(service)
            {
                AchievementId = achievementId;
                InitParameters();
            }

            /// <summary>The ID of the achievement used by this method.</summary>
            [Google.Apis.Util.RequestParameterAttribute("achievementId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string AchievementId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1configuration/achievements/{achievementId}";

            /// <summary>Initializes Get parameter list.</summary>
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

        /// <summary>Insert a new achievement configuration in this application.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="applicationId">The application ID from the Google Play developer console.</param>
        public virtual InsertRequest Insert(Google.Apis.GamesConfiguration.v1configuration.Data.AchievementConfiguration body, string applicationId)
        {
            return new InsertRequest(this.service, body, applicationId);
        }

        /// <summary>Insert a new achievement configuration in this application.</summary>
        public class InsertRequest : GamesConfigurationBaseServiceRequest<Google.Apis.GamesConfiguration.v1configuration.Data.AchievementConfiguration>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.GamesConfiguration.v1configuration.Data.AchievementConfiguration body, string applicationId) : base(service)
            {
                ApplicationId = applicationId;
                Body = body;
                InitParameters();
            }

            /// <summary>The application ID from the Google Play developer console.</summary>
            [Google.Apis.Util.RequestParameterAttribute("applicationId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ApplicationId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.GamesConfiguration.v1configuration.Data.AchievementConfiguration Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1configuration/applications/{applicationId}/achievements";

            /// <summary>Initializes Insert parameter list.</summary>
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

        /// <summary>Returns a list of the achievement configurations in this application.</summary>
        /// <param name="applicationId">The application ID from the Google Play developer console.</param>
        public virtual ListRequest List(string applicationId)
        {
            return new ListRequest(this.service, applicationId);
        }

        /// <summary>Returns a list of the achievement configurations in this application.</summary>
        public class ListRequest : GamesConfigurationBaseServiceRequest<Google.Apis.GamesConfiguration.v1configuration.Data.AchievementConfigurationListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string applicationId) : base(service)
            {
                ApplicationId = applicationId;
                InitParameters();
            }

            /// <summary>The application ID from the Google Play developer console.</summary>
            [Google.Apis.Util.RequestParameterAttribute("applicationId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ApplicationId { get; private set; }

            /// <summary>
            /// The maximum number of resource configurations to return in the response, used for paging. For any
            /// response, the actual number of resources returned may be less than the specified `maxResults`.
            /// </summary>
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
            public override string RestPath => "games/v1configuration/applications/{applicationId}/achievements";

            /// <summary>Initializes List parameter list.</summary>
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

        /// <summary>Update the metadata of the achievement configuration with the given ID.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="achievementId">The ID of the achievement used by this method.</param>
        public virtual UpdateRequest Update(Google.Apis.GamesConfiguration.v1configuration.Data.AchievementConfiguration body, string achievementId)
        {
            return new UpdateRequest(this.service, body, achievementId);
        }

        /// <summary>Update the metadata of the achievement configuration with the given ID.</summary>
        public class UpdateRequest : GamesConfigurationBaseServiceRequest<Google.Apis.GamesConfiguration.v1configuration.Data.AchievementConfiguration>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.GamesConfiguration.v1configuration.Data.AchievementConfiguration body, string achievementId) : base(service)
            {
                AchievementId = achievementId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the achievement used by this method.</summary>
            [Google.Apis.Util.RequestParameterAttribute("achievementId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string AchievementId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.GamesConfiguration.v1configuration.Data.AchievementConfiguration Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1configuration/achievements/{achievementId}";

            /// <summary>Initializes Update parameter list.</summary>
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
    }

    /// <summary>The "leaderboardConfigurations" collection of methods.</summary>
    public class LeaderboardConfigurationsResource
    {
        private const string Resource = "leaderboardConfigurations";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public LeaderboardConfigurationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Delete the leaderboard configuration with the given ID.</summary>
        /// <param name="leaderboardId">The ID of the leaderboard.</param>
        public virtual DeleteRequest Delete(string leaderboardId)
        {
            return new DeleteRequest(this.service, leaderboardId);
        }

        /// <summary>Delete the leaderboard configuration with the given ID.</summary>
        public class DeleteRequest : GamesConfigurationBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string leaderboardId) : base(service)
            {
                LeaderboardId = leaderboardId;
                InitParameters();
            }

            /// <summary>The ID of the leaderboard.</summary>
            [Google.Apis.Util.RequestParameterAttribute("leaderboardId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string LeaderboardId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1configuration/leaderboards/{leaderboardId}";

            /// <summary>Initializes Delete parameter list.</summary>
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

        /// <summary>Retrieves the metadata of the leaderboard configuration with the given ID.</summary>
        /// <param name="leaderboardId">The ID of the leaderboard.</param>
        public virtual GetRequest Get(string leaderboardId)
        {
            return new GetRequest(this.service, leaderboardId);
        }

        /// <summary>Retrieves the metadata of the leaderboard configuration with the given ID.</summary>
        public class GetRequest : GamesConfigurationBaseServiceRequest<Google.Apis.GamesConfiguration.v1configuration.Data.LeaderboardConfiguration>
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

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1configuration/leaderboards/{leaderboardId}";

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
            }
        }

        /// <summary>Insert a new leaderboard configuration in this application.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="applicationId">The application ID from the Google Play developer console.</param>
        public virtual InsertRequest Insert(Google.Apis.GamesConfiguration.v1configuration.Data.LeaderboardConfiguration body, string applicationId)
        {
            return new InsertRequest(this.service, body, applicationId);
        }

        /// <summary>Insert a new leaderboard configuration in this application.</summary>
        public class InsertRequest : GamesConfigurationBaseServiceRequest<Google.Apis.GamesConfiguration.v1configuration.Data.LeaderboardConfiguration>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.GamesConfiguration.v1configuration.Data.LeaderboardConfiguration body, string applicationId) : base(service)
            {
                ApplicationId = applicationId;
                Body = body;
                InitParameters();
            }

            /// <summary>The application ID from the Google Play developer console.</summary>
            [Google.Apis.Util.RequestParameterAttribute("applicationId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ApplicationId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.GamesConfiguration.v1configuration.Data.LeaderboardConfiguration Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1configuration/applications/{applicationId}/leaderboards";

            /// <summary>Initializes Insert parameter list.</summary>
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

        /// <summary>Returns a list of the leaderboard configurations in this application.</summary>
        /// <param name="applicationId">The application ID from the Google Play developer console.</param>
        public virtual ListRequest List(string applicationId)
        {
            return new ListRequest(this.service, applicationId);
        }

        /// <summary>Returns a list of the leaderboard configurations in this application.</summary>
        public class ListRequest : GamesConfigurationBaseServiceRequest<Google.Apis.GamesConfiguration.v1configuration.Data.LeaderboardConfigurationListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string applicationId) : base(service)
            {
                ApplicationId = applicationId;
                InitParameters();
            }

            /// <summary>The application ID from the Google Play developer console.</summary>
            [Google.Apis.Util.RequestParameterAttribute("applicationId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ApplicationId { get; private set; }

            /// <summary>
            /// The maximum number of resource configurations to return in the response, used for paging. For any
            /// response, the actual number of resources returned may be less than the specified `maxResults`.
            /// </summary>
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
            public override string RestPath => "games/v1configuration/applications/{applicationId}/leaderboards";

            /// <summary>Initializes List parameter list.</summary>
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

        /// <summary>Update the metadata of the leaderboard configuration with the given ID.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="leaderboardId">The ID of the leaderboard.</param>
        public virtual UpdateRequest Update(Google.Apis.GamesConfiguration.v1configuration.Data.LeaderboardConfiguration body, string leaderboardId)
        {
            return new UpdateRequest(this.service, body, leaderboardId);
        }

        /// <summary>Update the metadata of the leaderboard configuration with the given ID.</summary>
        public class UpdateRequest : GamesConfigurationBaseServiceRequest<Google.Apis.GamesConfiguration.v1configuration.Data.LeaderboardConfiguration>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.GamesConfiguration.v1configuration.Data.LeaderboardConfiguration body, string leaderboardId) : base(service)
            {
                LeaderboardId = leaderboardId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the leaderboard.</summary>
            [Google.Apis.Util.RequestParameterAttribute("leaderboardId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string LeaderboardId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.GamesConfiguration.v1configuration.Data.LeaderboardConfiguration Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "games/v1configuration/leaderboards/{leaderboardId}";

            /// <summary>Initializes Update parameter list.</summary>
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
    }
}
namespace Google.Apis.GamesConfiguration.v1configuration.Data
{
    /// <summary>An achievement configuration resource.</summary>
    public class AchievementConfiguration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of the achievement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("achievementType")]
        public virtual string AchievementType { get; set; }

        /// <summary>The draft data of the achievement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("draft")]
        public virtual AchievementConfigurationDetail Draft { get; set; }

        /// <summary>The ID of the achievement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The initial state of the achievement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initialState")]
        public virtual string InitialState { get; set; }

        /// <summary>
        /// Uniquely identifies the type of this resource. Value is always the fixed string
        /// `gamesConfiguration#achievementConfiguration`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The read-only published data of the achievement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("published")]
        public virtual AchievementConfigurationDetail Published { get; set; }

        /// <summary>Steps to unlock. Only applicable to incremental achievements.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stepsToUnlock")]
        public virtual System.Nullable<int> StepsToUnlock { get; set; }

        /// <summary>The token for this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An achievement configuration detail.</summary>
    public class AchievementConfigurationDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Localized strings for the achievement description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual LocalizedStringBundle Description { get; set; }

        /// <summary>The icon url of this achievement. Writes to this field are ignored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iconUrl")]
        public virtual string IconUrl { get; set; }

        /// <summary>
        /// Uniquely identifies the type of this resource. Value is always the fixed string
        /// `gamesConfiguration#achievementConfigurationDetail`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Localized strings for the achievement name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual LocalizedStringBundle Name { get; set; }

        /// <summary>Point value for the achievement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pointValue")]
        public virtual System.Nullable<int> PointValue { get; set; }

        /// <summary>The sort rank of this achievement. Writes to this field are ignored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sortRank")]
        public virtual System.Nullable<int> SortRank { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A ListConfigurations response.</summary>
    public class AchievementConfigurationListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The achievement configurations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<AchievementConfiguration> Items { get; set; }

        /// <summary>
        /// Uniquely identifies the type of this resource. Value is always the fixed string
        /// `gamesConfiguration#achievementConfigurationListResponse`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The pagination token for the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A number affix resource.</summary>
    public class GamesNumberAffixConfiguration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// When the language requires special treatment of "small" numbers (as with 2, 3, and 4 in Czech; or numbers
        /// ending 2, 3, or 4 but not 12, 13, or 14 in Polish).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("few")]
        public virtual LocalizedStringBundle Few { get; set; }

        /// <summary>
        /// When the language requires special treatment of "large" numbers (as with numbers ending 11-99 in Maltese).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("many")]
        public virtual LocalizedStringBundle Many { get; set; }

        /// <summary>
        /// When the language requires special treatment of numbers like one (as with the number 1 in English and most
        /// other languages; in Russian, any number ending in 1 but not ending in 11 is in this class).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("one")]
        public virtual LocalizedStringBundle One { get; set; }

        /// <summary>
        /// When the language does not require special treatment of the given quantity (as with all numbers in Chinese,
        /// or 42 in English).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("other")]
        public virtual LocalizedStringBundle Other { get; set; }

        /// <summary>
        /// When the language requires special treatment of numbers like two (as with 2 in Welsh, or 102 in Slovenian).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("two")]
        public virtual LocalizedStringBundle Two { get; set; }

        /// <summary>When the language requires special treatment of the number 0 (as in Arabic).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zero")]
        public virtual LocalizedStringBundle Zero { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A number format resource.</summary>
    public class GamesNumberFormatConfiguration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The curreny code string. Only used for CURRENCY format type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>The number of decimal places for number. Only used for NUMERIC format type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numDecimalPlaces")]
        public virtual System.Nullable<int> NumDecimalPlaces { get; set; }

        /// <summary>The formatting for the number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numberFormatType")]
        public virtual string NumberFormatType { get; set; }

        /// <summary>
        /// An optional suffix for the NUMERIC format type. These strings follow the same plural rules as all Android
        /// string resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suffix")]
        public virtual GamesNumberAffixConfiguration Suffix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An leaderboard configuration resource.</summary>
    public class LeaderboardConfiguration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The draft data of the leaderboard.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("draft")]
        public virtual LeaderboardConfigurationDetail Draft { get; set; }

        /// <summary>The ID of the leaderboard.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Uniquely identifies the type of this resource. Value is always the fixed string
        /// `gamesConfiguration#leaderboardConfiguration`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The read-only published data of the leaderboard.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("published")]
        public virtual LeaderboardConfigurationDetail Published { get; set; }

        /// <summary>Maximum score that can be posted to this leaderboard.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scoreMax")]
        public virtual System.Nullable<long> ScoreMax { get; set; }

        /// <summary>Minimum score that can be posted to this leaderboard.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scoreMin")]
        public virtual System.Nullable<long> ScoreMin { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("scoreOrder")]
        public virtual string ScoreOrder { get; set; }

        /// <summary>The token for this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A leaderboard configuration detail.</summary>
    public class LeaderboardConfigurationDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The icon url of this leaderboard. Writes to this field are ignored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iconUrl")]
        public virtual string IconUrl { get; set; }

        /// <summary>
        /// Uniquely identifies the type of this resource. Value is always the fixed string
        /// `gamesConfiguration#leaderboardConfigurationDetail`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Localized strings for the leaderboard name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual LocalizedStringBundle Name { get; set; }

        /// <summary>The score formatting for the leaderboard.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scoreFormat")]
        public virtual GamesNumberFormatConfiguration ScoreFormat { get; set; }

        /// <summary>The sort rank of this leaderboard. Writes to this field are ignored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sortRank")]
        public virtual System.Nullable<int> SortRank { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A ListConfigurations response.</summary>
    public class LeaderboardConfigurationListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The leaderboard configurations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<LeaderboardConfiguration> Items { get; set; }

        /// <summary>
        /// Uniquely identifies the type of this resource. Value is always the fixed string
        /// `gamesConfiguration#leaderboardConfigurationListResponse`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The pagination token for the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A localized string resource.</summary>
    public class LocalizedString : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Uniquely identifies the type of this resource. Value is always the fixed string
        /// `gamesConfiguration#localizedString`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The locale string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locale")]
        public virtual string Locale { get; set; }

        /// <summary>The string value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A localized string bundle resource.</summary>
    public class LocalizedStringBundle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Uniquely identifies the type of this resource. Value is always the fixed string
        /// `gamesConfiguration#localizedStringBundle`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The locale strings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("translations")]
        public virtual System.Collections.Generic.IList<LocalizedString> Translations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
