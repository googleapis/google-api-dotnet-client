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

namespace Google.Apis.SemanticTile.v1
{
    /// <summary>The SemanticTile Service.</summary>
    public class SemanticTileService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public SemanticTileService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public SemanticTileService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Featuretiles = new FeaturetilesResource(this);
            Terraintiles = new TerraintilesResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "vectortile";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://vectortile.googleapis.com/";
        #else
            "https://vectortile.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://vectortile.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Gets the Featuretiles resource.</summary>
        public virtual FeaturetilesResource Featuretiles { get; }

        /// <summary>Gets the Terraintiles resource.</summary>
        public virtual TerraintilesResource Terraintiles { get; }
    }

    /// <summary>A base abstract class for SemanticTile requests.</summary>
    public abstract class SemanticTileBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new SemanticTileBaseServiceRequest instance.</summary>
        protected SemanticTileBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes SemanticTile parameter list.</summary>
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

    /// <summary>The "featuretiles" collection of methods.</summary>
    public class FeaturetilesResource
    {
        private const string Resource = "featuretiles";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public FeaturetilesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Gets a feature tile by its tile resource name.</summary>
        /// <param name="name">
        /// Required. Resource name of the tile. The tile resource name is prefixed by its collection ID `tiles/`
        /// followed by the resource ID, which encodes the tile's global x and y coordinates and zoom level as `@,,z`.
        /// For example, `tiles/@1,2,3z`.
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>Gets a feature tile by its tile resource name.</summary>
        public class GetRequest : SemanticTileBaseServiceRequest<Google.Apis.SemanticTile.v1.Data.FeatureTile>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. Resource name of the tile. The tile resource name is prefixed by its collection ID `tiles/`
            /// followed by the resource ID, which encodes the tile's global x and y coordinates and zoom level as
            /// `@,,z`. For example, `tiles/@1,2,3z`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// Flag indicating whether the returned tile will always contain 2.5D footprints for structures. If
            /// enabled_modeled_volumes is set, this will mean that structures will have both their 3D models and 2.5D
            /// footprints returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("alwaysIncludeBuildingFootprints", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> AlwaysIncludeBuildingFootprints { get; set; }

            /// <summary>
            /// API client name and version. For example, the SDK calling the API. The exact format is up to the client.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("clientInfo.apiClient", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientInfoApiClient { get; set; }

            /// <summary>
            /// Application ID, such as the package name on Android and the bundle identifier on iOS platforms.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("clientInfo.applicationId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientInfoApplicationId { get; set; }

            /// <summary>
            /// Application version number, such as "1.2.3". The exact format is application-dependent.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("clientInfo.applicationVersion", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientInfoApplicationVersion { get; set; }

            /// <summary>Device model as reported by the device. The exact format is platform-dependent.</summary>
            [Google.Apis.Util.RequestParameterAttribute("clientInfo.deviceModel", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientInfoDeviceModel { get; set; }

            /// <summary>
            /// Operating system name and version as reported by the OS. For example, "Mac OS X 10.10.4". The exact
            /// format is platform-dependent.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("clientInfo.operatingSystem", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientInfoOperatingSystem { get; set; }

            /// <summary>Platform where the application is running.</summary>
            [Google.Apis.Util.RequestParameterAttribute("clientInfo.platform", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ClientInfoPlatformEnum> ClientInfoPlatform { get; set; }

            /// <summary>Platform where the application is running.</summary>
            public enum ClientInfoPlatformEnum
            {
                /// <summary>Unspecified or unknown OS.</summary>
                [Google.Apis.Util.StringValueAttribute("PLATFORM_UNSPECIFIED")]
                PLATFORMUNSPECIFIED = 0,

                /// <summary>Development environment.</summary>
                [Google.Apis.Util.StringValueAttribute("EDITOR")]
                EDITOR = 1,

                /// <summary>macOS.</summary>
                [Google.Apis.Util.StringValueAttribute("MAC_OS")]
                MACOS = 2,

                /// <summary>Windows.</summary>
                [Google.Apis.Util.StringValueAttribute("WINDOWS")]
                WINDOWS = 3,

                /// <summary>Linux</summary>
                [Google.Apis.Util.StringValueAttribute("LINUX")]
                LINUX = 4,

                /// <summary>Android</summary>
                [Google.Apis.Util.StringValueAttribute("ANDROID")]
                ANDROID = 5,

                /// <summary>iOS</summary>
                [Google.Apis.Util.StringValueAttribute("IOS")]
                IOS = 6,

                /// <summary>WebGL.</summary>
                [Google.Apis.Util.StringValueAttribute("WEB_GL")]
                WEBGL = 7,
            }

            /// <summary>
            /// Required. A client-generated user ID. The ID should be generated and persisted during the first user
            /// session or whenever a pre-existing ID is not found. The exact format is up to the client. This must be
            /// non-empty in a GetFeatureTileRequest (whether via the header or GetFeatureTileRequest.client_info).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("clientInfo.userId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientInfoUserId { get; set; }

            /// <summary>
            /// Optional version id identifying the tile that is already in the client's cache. This field should be
            /// populated with the most recent version_id value returned by the API for the requested tile. If the
            /// version id is empty the server always returns a newly rendered tile. If it is provided the server checks
            /// if the tile contents would be identical to one that's already on the client, and if so, returns a
            /// stripped-down response tile with STATUS_OK_DATA_UNCHANGED instead.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("clientTileVersionId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientTileVersionId { get; set; }

            /// <summary>
            /// Flag indicating whether detailed highway types should be returned. If this is set, the
            /// CONTROLLED_ACCESS_HIGHWAY type may be returned. If not, then these highways will have the generic
            /// HIGHWAY type. This exists for backwards compatibility reasons.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("enableDetailedHighwayTypes", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> EnableDetailedHighwayTypes { get; set; }

            /// <summary>
            /// Flag indicating whether human-readable names should be returned for features. If this is set, the
            /// display_name field on the feature will be filled out.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("enableFeatureNames", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> EnableFeatureNames { get; set; }

            /// <summary>
            /// Flag indicating whether 3D building models should be enabled. If this is set structures will be returned
            /// as 3D modeled volumes rather than 2.5D extruded areas where possible.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("enableModeledVolumes", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> EnableModeledVolumes { get; set; }

            /// <summary>Flag indicating whether political features should be returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enablePoliticalFeatures", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> EnablePoliticalFeatures { get; set; }

            /// <summary>
            /// Flag indicating whether the returned tile will contain road features that are marked private. Private
            /// roads are indicated by the Feature.segment_info.road_info.is_private field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("enablePrivateRoads", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> EnablePrivateRoads { get; set; }

            /// <summary>
            /// Flag indicating whether unclipped buildings should be returned. If this is set, building render ops will
            /// extend beyond the tile boundary. Buildings will only be returned on the tile that contains their
            /// centroid.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("enableUnclippedBuildings", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> EnableUnclippedBuildings { get; set; }

            /// <summary>
            /// Required. The BCP-47 language code corresponding to the language in which the name was requested, such
            /// as "en-US" or "sr-Latn". For more information, see
            /// http://www.unicode.org/reports/tr35/#Unicode_locale_identifier.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string LanguageCode { get; set; }

            /// <summary>
            /// Required. The Unicode country/region code (CLDR) of the location from which the request is coming from,
            /// such as "US" and "419". For more information, see
            /// http://www.unicode.org/reports/tr35/#unicode_region_subtag.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("regionCode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string RegionCode { get; set; }

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
                    Pattern = @"^featuretiles/[^/]+$",
                });
                RequestParameters.Add("alwaysIncludeBuildingFootprints", new Google.Apis.Discovery.Parameter
                {
                    Name = "alwaysIncludeBuildingFootprints",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientInfo.apiClient", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientInfo.apiClient",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientInfo.applicationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientInfo.applicationId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientInfo.applicationVersion", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientInfo.applicationVersion",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientInfo.deviceModel", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientInfo.deviceModel",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientInfo.operatingSystem", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientInfo.operatingSystem",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientInfo.platform", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientInfo.platform",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientInfo.userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientInfo.userId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientTileVersionId", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientTileVersionId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("enableDetailedHighwayTypes", new Google.Apis.Discovery.Parameter
                {
                    Name = "enableDetailedHighwayTypes",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("enableFeatureNames", new Google.Apis.Discovery.Parameter
                {
                    Name = "enableFeatureNames",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("enableModeledVolumes", new Google.Apis.Discovery.Parameter
                {
                    Name = "enableModeledVolumes",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("enablePoliticalFeatures", new Google.Apis.Discovery.Parameter
                {
                    Name = "enablePoliticalFeatures",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("enablePrivateRoads", new Google.Apis.Discovery.Parameter
                {
                    Name = "enablePrivateRoads",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("enableUnclippedBuildings", new Google.Apis.Discovery.Parameter
                {
                    Name = "enableUnclippedBuildings",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("languageCode", new Google.Apis.Discovery.Parameter
                {
                    Name = "languageCode",
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

    /// <summary>The "terraintiles" collection of methods.</summary>
    public class TerraintilesResource
    {
        private const string Resource = "terraintiles";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public TerraintilesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Gets a terrain tile by its tile resource name.</summary>
        /// <param name="name">
        /// Required. Resource name of the tile. The tile resource name is prefixed by its collection ID `terraintiles/`
        /// followed by the resource ID, which encodes the tile's global x and y coordinates and zoom level as `@,,z`.
        /// For example, `terraintiles/@1,2,3z`.
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>Gets a terrain tile by its tile resource name.</summary>
        public class GetRequest : SemanticTileBaseServiceRequest<Google.Apis.SemanticTile.v1.Data.TerrainTile>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. Resource name of the tile. The tile resource name is prefixed by its collection ID
            /// `terraintiles/` followed by the resource ID, which encodes the tile's global x and y coordinates and
            /// zoom level as `@,,z`. For example, `terraintiles/@1,2,3z`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// The precision of terrain altitudes in centimeters. Possible values: between 1 (cm level precision) and
            /// 1,000,000 (10-kilometer level precision).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("altitudePrecisionCentimeters", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> AltitudePrecisionCentimeters { get; set; }

            /// <summary>
            /// API client name and version. For example, the SDK calling the API. The exact format is up to the client.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("clientInfo.apiClient", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientInfoApiClient { get; set; }

            /// <summary>
            /// Application ID, such as the package name on Android and the bundle identifier on iOS platforms.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("clientInfo.applicationId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientInfoApplicationId { get; set; }

            /// <summary>
            /// Application version number, such as "1.2.3". The exact format is application-dependent.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("clientInfo.applicationVersion", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientInfoApplicationVersion { get; set; }

            /// <summary>Device model as reported by the device. The exact format is platform-dependent.</summary>
            [Google.Apis.Util.RequestParameterAttribute("clientInfo.deviceModel", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientInfoDeviceModel { get; set; }

            /// <summary>
            /// Operating system name and version as reported by the OS. For example, "Mac OS X 10.10.4". The exact
            /// format is platform-dependent.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("clientInfo.operatingSystem", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientInfoOperatingSystem { get; set; }

            /// <summary>Platform where the application is running.</summary>
            [Google.Apis.Util.RequestParameterAttribute("clientInfo.platform", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ClientInfoPlatformEnum> ClientInfoPlatform { get; set; }

            /// <summary>Platform where the application is running.</summary>
            public enum ClientInfoPlatformEnum
            {
                /// <summary>Unspecified or unknown OS.</summary>
                [Google.Apis.Util.StringValueAttribute("PLATFORM_UNSPECIFIED")]
                PLATFORMUNSPECIFIED = 0,

                /// <summary>Development environment.</summary>
                [Google.Apis.Util.StringValueAttribute("EDITOR")]
                EDITOR = 1,

                /// <summary>macOS.</summary>
                [Google.Apis.Util.StringValueAttribute("MAC_OS")]
                MACOS = 2,

                /// <summary>Windows.</summary>
                [Google.Apis.Util.StringValueAttribute("WINDOWS")]
                WINDOWS = 3,

                /// <summary>Linux</summary>
                [Google.Apis.Util.StringValueAttribute("LINUX")]
                LINUX = 4,

                /// <summary>Android</summary>
                [Google.Apis.Util.StringValueAttribute("ANDROID")]
                ANDROID = 5,

                /// <summary>iOS</summary>
                [Google.Apis.Util.StringValueAttribute("IOS")]
                IOS = 6,

                /// <summary>WebGL.</summary>
                [Google.Apis.Util.StringValueAttribute("WEB_GL")]
                WEBGL = 7,
            }

            /// <summary>
            /// Required. A client-generated user ID. The ID should be generated and persisted during the first user
            /// session or whenever a pre-existing ID is not found. The exact format is up to the client. This must be
            /// non-empty in a GetFeatureTileRequest (whether via the header or GetFeatureTileRequest.client_info).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("clientInfo.userId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClientInfoUserId { get; set; }

            /// <summary>
            /// The maximum allowed resolution for the returned elevation heightmap. Possible values: between 1 and 1024
            /// (and not less than min_elevation_resolution_cells). Over-sized heightmaps will be non-uniformly
            /// down-sampled such that each edge is no longer than this value. Non-uniformity is chosen to maximise the
            /// amount of preserved data. For example: Original resolution: 100px (width) * 30px (height)
            /// max_elevation_resolution: 30 New resolution: 30px (width) * 30px (height)
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxElevationResolutionCells", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxElevationResolutionCells { get; set; }

            /// <summary>
            ///  api-linter: core::0131::request-unknown-fields=disabled aip.dev/not-precedent: Maintaining existing
            /// request parameter pattern. The minimum allowed resolution for the returned elevation heightmap. Possible
            /// values: between 0 and 1024 (and not more than max_elevation_resolution_cells). Zero is supported for
            /// backward compatibility. Under-sized heightmaps will be non-uniformly up-sampled such that each edge is
            /// no shorter than this value. Non-uniformity is chosen to maximise the amount of preserved data. For
            /// example: Original resolution: 30px (width) * 10px (height) min_elevation_resolution: 30 New resolution:
            /// 30px (width) * 30px (height)
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("minElevationResolutionCells", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MinElevationResolutionCells { get; set; }

            /// <summary>Terrain formats that the client understands.</summary>
            /// <remarks>
            /// Use this property to set a single value for the parameter, or <see cref="TerrainFormatsList"/> to set
            /// multiple values. Do not set both properties.
            /// </remarks>
            [Google.Apis.Util.RequestParameterAttribute("terrainFormats", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<TerrainFormatsEnum> TerrainFormats { get; set; }

            /// <summary>Terrain formats that the client understands.</summary>
            /// <remarks>
            /// Use this property to set one or more values for the parameter. Do not set both this property and
            /// <see cref="TerrainFormats"/>.
            /// </remarks>
            [Google.Apis.Util.RequestParameterAttribute("terrainFormats", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<TerrainFormatsEnum> TerrainFormatsList { get; set; }

            /// <summary>Terrain formats that the client understands.</summary>
            public enum TerrainFormatsEnum
            {
                /// <summary>An unknown or unspecified terrain format.</summary>
                [Google.Apis.Util.StringValueAttribute("TERRAIN_FORMAT_UNKNOWN")]
                TERRAINFORMATUNKNOWN = 0,

                /// <summary>Terrain elevation data encoded as a FirstDerivativeElevationGrid. .</summary>
                [Google.Apis.Util.StringValueAttribute("FIRST_DERIVATIVE")]
                FIRSTDERIVATIVE = 1,

                /// <summary>Terrain elevation data encoded as a SecondDerivativeElevationGrid.</summary>
                [Google.Apis.Util.StringValueAttribute("SECOND_DERIVATIVE")]
                SECONDDERIVATIVE = 2,
            }

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
                    Pattern = @"^terraintiles/[^/]+$",
                });
                RequestParameters.Add("altitudePrecisionCentimeters", new Google.Apis.Discovery.Parameter
                {
                    Name = "altitudePrecisionCentimeters",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientInfo.apiClient", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientInfo.apiClient",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientInfo.applicationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientInfo.applicationId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientInfo.applicationVersion", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientInfo.applicationVersion",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientInfo.deviceModel", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientInfo.deviceModel",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientInfo.operatingSystem", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientInfo.operatingSystem",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientInfo.platform", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientInfo.platform",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientInfo.userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientInfo.userId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxElevationResolutionCells", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxElevationResolutionCells",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("minElevationResolutionCells", new Google.Apis.Discovery.Parameter
                {
                    Name = "minElevationResolutionCells",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("terrainFormats", new Google.Apis.Discovery.Parameter
                {
                    Name = "terrainFormats",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.SemanticTile.v1.Data
{
    /// <summary>Represents an area. Used to represent regions such as water, parks, etc. Next ID: 10</summary>
    public class Area : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The z-order of this geometry when rendered on a flat basemap. Geometry with a lower z-order should be
        /// rendered beneath geometry with a higher z-order. This z-ordering does not imply anything about the altitude
        /// of the area relative to the ground, but it can be used to prevent z-fighting. Unlike Area.z_order this can
        /// be used to compare with Line.basemap_z_order, and in fact may yield more accurate rendering (where a line
        /// may be rendered beneath an area).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basemapZOrder")]
        public virtual BasemapZOrder BasemapZOrder { get; set; }

        /// <summary>
        /// True if the polygon is not entirely internal to the feature that it belongs to: that is, some of the edges
        /// are bordering another feature.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasExternalEdges")]
        public virtual System.Nullable<bool> HasExternalEdges { get; set; }

        /// <summary>
        /// When has_external_edges is true, the polygon has some edges that border another feature. This field
        /// indicates the internal edges that do not border another feature. Each value is an index into the vertices
        /// array, and denotes the start vertex of the internal edge (the next vertex in the boundary loop is the end of
        /// the edge). If the selected vertex is the last vertex in the boundary loop, then the edge between that vertex
        /// and the starting vertex of the loop is internal. This field may be used for styling. For example, building
        /// parapets could be placed only on the external edges of a building polygon, or water could be lighter colored
        /// near the external edges of a body of water. If has_external_edges is false, all edges are internal and this
        /// field will be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internalEdges")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> InternalEdges { get; set; }

        /// <summary>
        /// Identifies the boundary loops of the polygon. Only set for INDEXED_TRIANGLE polygons. Each value is an index
        /// into the vertices array indicating the beginning of a loop. For instance, values of [2, 5] would indicate
        /// loop_data contained 3 loops with indices 0-1, 2-4, and 5-end. This may be used in conjunction with the
        /// internal_edges field for styling polygon boundaries. Note that an edge may be on a polygon boundary but
        /// still internal to the feature. For example, a feature split across multiple tiles will have an internal
        /// polygon boundary edge along the edge of the tile.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loopBreaks")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> LoopBreaks { get; set; }

        /// <summary>
        /// When the polygon encoding is of type INDEXED_TRIANGLES, this contains the indices of the triangle vertices
        /// in the vertex_offsets field. There are 3 vertex indices per triangle.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triangleIndices")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> TriangleIndices { get; set; }

        /// <summary>The polygon encoding type used for this area.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The vertices present in the polygon defining the area.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vertexOffsets")]
        public virtual Vertex2DList VertexOffsets { get; set; }

        /// <summary>
        /// The z-ordering of this area. Areas with a lower z-order should be rendered beneath areas with a higher
        /// z-order. This z-ordering does not imply anything about the altitude of the line relative to the ground, but
        /// it can be used to prevent z-fighting during rendering on the client. This z-ordering can only be used to
        /// compare areas, and cannot be compared with the z_order field in the Line message. The z-order may be
        /// negative or zero. Prefer Area.basemap_z_order.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zOrder")]
        public virtual System.Nullable<int> ZOrder { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata necessary to determine the ordering of a particular basemap element relative to others. To render the
    /// basemap correctly, sort by z-plane, then z-grade, then z-within-grade.
    /// </summary>
    public class BasemapZOrder : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The second most significant component of the ordering of a component to be rendered onto the basemap.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zGrade")]
        public virtual System.Nullable<int> ZGrade { get; set; }

        /// <summary>
        /// The most significant component of the ordering of a component to be rendered onto the basemap.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zPlane")]
        public virtual System.Nullable<int> ZPlane { get; set; }

        /// <summary>
        /// The least significant component of the ordering of a component to be rendered onto the basemap.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zWithinGrade")]
        public virtual System.Nullable<int> ZWithinGrade { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a height-extruded area: a 3D prism with a constant X-Y plane cross section. Used to represent
    /// extruded buildings. A single building may consist of several extruded areas. The min_z and max_z fields are
    /// scaled to the size of the tile. An extruded area with a max_z value of 4096 has the same height as the width of
    /// the tile that it is on.
    /// </summary>
    public class ExtrudedArea : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The area representing the footprint of the extruded area.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("area")]
        public virtual Area Area { get; set; }

        /// <summary>The z-value in local tile coordinates where the extruded area ends.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxZ")]
        public virtual System.Nullable<int> MaxZ { get; set; }

        /// <summary>
        /// The z-value in local tile coordinates where the extruded area begins. This is non-zero for extruded areas
        /// that begin off the ground. For example, a building with a skybridge may have an extruded area component with
        /// a non-zero min_z.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minZ")]
        public virtual System.Nullable<int> MinZ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A feature representing a single geographic entity.</summary>
    public class Feature : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The localized name of this feature. Currently only returned for roads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The geometry of this feature, representing the space that it occupies in the world.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("geometry")]
        public virtual Geometry Geometry { get; set; }

        /// <summary>Place ID of this feature, suitable for use in Places API details requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placeId")]
        public virtual string PlaceId { get; set; }

        /// <summary>Relations to other features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relations")]
        public virtual System.Collections.Generic.IList<Relation> Relations { get; set; }

        /// <summary>Metadata for features with the SEGMENT FeatureType.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segmentInfo")]
        public virtual SegmentInfo SegmentInfo { get; set; }

        /// <summary>The type of this feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A tile containing information about the map features located in the region it covers.</summary>
    public class FeatureTile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The global tile coordinates that uniquely identify this tile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("coordinates")]
        public virtual TileCoordinates Coordinates { get; set; }

        /// <summary>Features present on this map tile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("features")]
        public virtual System.Collections.Generic.IList<Feature> Features { get; set; }

        /// <summary>
        /// Resource name of the tile. The tile resource name is prefixed by its collection ID `tiles/` followed by the
        /// resource ID, which encodes the tile's global x and y coordinates and zoom level as `@,,z`. For example,
        /// `tiles/@1,2,3z`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Data providers for the data contained in this tile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("providers")]
        public virtual System.Collections.Generic.IList<ProviderInfo> Providers { get; set; }

        /// <summary>Tile response status code to support tile caching.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>
        /// An opaque value, usually less than 30 characters, that contains version info about this tile and the data
        /// that was used to generate it. The client should store this value in its tile cache and pass it back to the
        /// API in the client_tile_version_id field of subsequent tile requests in order to enable the API to detect
        /// when the new tile would be the same as the one the client already has in its cache. Also see
        /// STATUS_OK_DATA_UNCHANGED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionId")]
        public virtual string VersionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A packed representation of a 2D grid of uniformly spaced points containing elevation data. Each point within the
    /// grid represents the altitude in meters above average sea level at that location within the tile. Elevations
    /// provided are (generally) relative to the EGM96 geoid, however some areas will be relative to NAVD88. EGM96 and
    /// NAVD88 are off by no more than 2 meters. The grid is oriented north-west to south-east, as illustrated:
    /// rows[0].a[0] rows[0].a[m] +-----------------+ | | | N | | ^ | | | | | W &amp;lt;-----&amp;gt; E | | | | | v | |
    /// S | | | +-----------------+ rows[n].a[0] rows[n].a[m] Rather than storing the altitudes directly, we store the
    /// diffs between them as integers at some requested level of precision to take advantage of integer packing. The
    /// actual altitude values a[] can be reconstructed using the scale and each row's first_altitude and altitude_diff
    /// fields. More details in go/elevation-encoding-options-for-enduro under "Recommended implementation".
    /// </summary>
    public class FirstDerivativeElevationGrid : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A multiplier applied to the altitude fields below to extract the actual altitudes in meters from the
        /// elevation grid.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("altitudeMultiplier")]
        public virtual System.Nullable<float> AltitudeMultiplier { get; set; }

        /// <summary>
        /// Rows of points containing altitude data making up the elevation grid. Each row is the same length. Rows are
        /// ordered from north to south. E.g: rows[0] is the north-most row, and rows[n] is the south-most row.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<Row> Rows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents the geometry of a feature, that is, the shape that it has on the map. The local tile coordinate
    /// system has the origin at the north-west (upper-left) corner of the tile, and is scaled to 4096 units across each
    /// edge. The height (Z) axis has the same scale factor: an extruded area with a max_z value of 4096 has the same
    /// height as the width of the tile that it is on. There is no clipping boundary, so it is possible that some
    /// coordinates will lie outside the tile boundaries.
    /// </summary>
    public class Geometry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The areas present in this geometry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("areas")]
        public virtual System.Collections.Generic.IList<Area> Areas { get; set; }

        /// <summary>
        /// The extruded areas present in this geometry. Not populated if modeled_volumes are included in this geometry
        /// unless always_include_building_footprints is set in GetFeatureTileRequest, in which case the client should
        /// decide which (extruded areas or modeled volumes) should be used (they should not be rendered together).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extrudedAreas")]
        public virtual System.Collections.Generic.IList<ExtrudedArea> ExtrudedAreas { get; set; }

        /// <summary>The lines present in this geometry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lines")]
        public virtual System.Collections.Generic.IList<Line> Lines { get; set; }

        /// <summary>
        /// The modeled volumes present in this geometry. Not populated unless enable_modeled_volumes has been set in
        /// GetFeatureTileRequest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modeledVolumes")]
        public virtual System.Collections.Generic.IList<ModeledVolume> ModeledVolumes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a 2D polyline. Used to represent segments such as roads, train tracks, etc.</summary>
    public class Line : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The z-order of this geometry when rendered on a flat basemap. Geometry with a lower z-order should be
        /// rendered beneath geometry with a higher z-order. This z-ordering does not imply anything about the altitude
        /// of the area relative to the ground, but it can be used to prevent z-fighting. Unlike Line.z_order this can
        /// be used to compare with Area.basemap_z_order, and in fact may yield more accurate rendering (where a line
        /// may be rendered beneath an area).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basemapZOrder")]
        public virtual BasemapZOrder BasemapZOrder { get; set; }

        /// <summary>The vertices present in the polyline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vertexOffsets")]
        public virtual Vertex2DList VertexOffsets { get; set; }

        /// <summary>
        /// The z-order of the line. Lines with a lower z-order should be rendered beneath lines with a higher z-order.
        /// This z-ordering does not imply anything about the altitude of the area relative to the ground, but it can be
        /// used to prevent z-fighting during rendering on the client. In general, larger and more important road
        /// features will have a higher z-order line associated with them. This z-ordering can only be used to compare
        /// lines, and cannot be compared with the z_order field in the Area message. The z-order may be negative or
        /// zero. Prefer Line.basemap_z_order.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zOrder")]
        public virtual System.Nullable<int> ZOrder { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a modeled volume in 3D space. Used to represent 3D buildings.</summary>
    public class ModeledVolume : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The triangle strips present in this mesh.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("strips")]
        public virtual System.Collections.Generic.IList<TriangleStrip> Strips { get; set; }

        /// <summary>The vertices present in the mesh defining the modeled volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vertexOffsets")]
        public virtual Vertex3DList VertexOffsets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information about the data providers that should be included in the attribution string shown by the client.
    /// </summary>
    public class ProviderInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Attribution string for this provider. This string is not localized.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a relation to another feature in the tile. For example, a building might be occupied by a given POI.
    /// The related feature can be retrieved using the related feature index.
    /// </summary>
    public class Relation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Zero-based index to look up the related feature from the list of features in the tile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relatedFeatureIndex")]
        public virtual System.Nullable<int> RelatedFeatureIndex { get; set; }

        /// <summary>Relation type between the origin feature to the related feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relationType")]
        public virtual string RelationType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Extra metadata relating to roads.</summary>
    public class RoadInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Road has signage discouraging or prohibiting use by the general public. E.g., roads with signs that say
        /// "Private", or "No trespassing."
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isPrivate")]
        public virtual System.Nullable<bool> IsPrivate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A row of altitude points in the elevation grid, ordered from west to east.</summary>
    public class Row : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The difference between each successive pair of altitudes, from west to east. The first, westmost point, is
        /// just the altitude rather than a diff. The units are specified by the altitude_multiplier parameter above;
        /// the value in meters is given by altitude_multiplier * altitude_diffs[n]. The altitude row (in metres above
        /// sea level) can be reconstructed with: a[0] = altitude_diffs[0] * altitude_multiplier when n &amp;gt; 0, a[n]
        /// = a[n-1] + altitude_diffs[n-1] * altitude_multiplier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("altitudeDiffs")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> AltitudeDiffs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A packed representation of a 2D grid of uniformly spaced points containing elevation data. Each point within the
    /// grid represents the altitude in meters above average sea level at that location within the tile. Elevations
    /// provided are (generally) relative to the EGM96 geoid, however some areas will be relative to NAVD88. EGM96 and
    /// NAVD88 are off by no more than 2 meters. The grid is oriented north-west to south-east, as illustrated:
    /// rows[0].a[0] rows[0].a[m] +-----------------+ | | | N | | ^ | | | | | W &amp;lt;-----&amp;gt; E | | | | | v | |
    /// S | | | +-----------------+ rows[n].a[0] rows[n].a[m] Rather than storing the altitudes directly, we store the
    /// diffs of the diffs between them as integers at some requested level of precision to take advantage of integer
    /// packing. Note that the data is packed in such a way that is fast to decode in Unity and that further optimizes
    /// wire size.
    /// </summary>
    public class SecondDerivativeElevationGrid : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A multiplier applied to the elements in the encoded data to extract the actual altitudes in meters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("altitudeMultiplier")]
        public virtual System.Nullable<float> AltitudeMultiplier { get; set; }

        /// <summary>
        /// The number of columns included in the encoded elevation data (i.e. the horizontal resolution of the grid).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnCount")]
        public virtual System.Nullable<int> ColumnCount { get; set; }

        /// <summary>
        /// A stream of elements each representing a point on the tile running across each row from left to right, top
        /// to bottom. There will be precisely horizontal_resolution * vertical_resolution elements in the stream. The
        /// elements are not the heights, rather the second order derivative of the values one would expect in a stream
        /// of height data. Each element is a varint with the following encoding:
        /// ------------------------------------------------------------------------| | Head Nibble |
        /// ------------------------------------------------------------------------| | Bit 0 | Bit 1 | Bits 2-3 | |
        /// Terminator| Sign (1=neg) | Least significant 2 bits of absolute error |
        /// ------------------------------------------------------------------------| | Tail Nibble #1 |
        /// ------------------------------------------------------------------------| | Bit 0 | Bit 1-3 | | Terminator|
        /// Least significant 3 bits of absolute error |
        /// ------------------------------------------------------------------------| | ... | Tail Nibble #n |
        /// ------------------------------------------------------------------------| | Bit 0 | Bit 1-3 | | Terminator|
        /// Least significant 3 bits of absolute error |
        /// ------------------------------------------------------------------------|
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encodedData")]
        public virtual string EncodedData { get; set; }

        /// <summary>
        /// The number of rows included in the encoded elevation data (i.e. the vertical resolution of the grid).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowCount")]
        public virtual System.Nullable<int> RowCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Extra metadata relating to segments.</summary>
    public class SegmentInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Metadata for features with the ROAD FeatureType.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roadInfo")]
        public virtual RoadInfo RoadInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A tile containing information about the terrain located in the region it covers.</summary>
    public class TerrainTile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The global tile coordinates that uniquely identify this tile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("coordinates")]
        public virtual TileCoordinates Coordinates { get; set; }

        /// <summary>
        /// Terrain elevation data encoded as a FirstDerivativeElevationGrid. cs/symbol:FirstDerivativeElevationGrid.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstDerivative")]
        public virtual FirstDerivativeElevationGrid FirstDerivative { get; set; }

        /// <summary>
        /// Resource name of the tile. The tile resource name is prefixed by its collection ID `terrain/` followed by
        /// the resource ID, which encodes the tile's global x and y coordinates and zoom level as `@,,z`. For example,
        /// `terrain/@1,2,3z`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Terrain elevation data encoded as a SecondDerivativeElevationGrid. cs/symbol:SecondDerivativeElevationGrid.
        /// See go/byte-encoded-terrain for more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondDerivative")]
        public virtual SecondDerivativeElevationGrid SecondDerivative { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Global tile coordinates. Global tile coordinates reference a specific tile on the map at a specific zoom level.
    /// The origin of this coordinate system is always at the northwest corner of the map, with x values increasing from
    /// west to east and y values increasing from north to south. Tiles are indexed using x, y coordinates from that
    /// origin. The zoom level containing the entire world in a tile is 0, and it increases as you zoom in. Zoom level n
    /// + 1 will contain 4 times as many tiles as zoom level n. The zoom level controls the level of detail of the data
    /// that is returned. In particular, this affects the set of feature types returned, their density, and geometry
    /// simplification. The exact tile contents may change over time, but care will be taken to keep supporting the most
    /// important use cases. For example, zoom level 15 shows roads for orientation and planning in the local
    /// neighborhood and zoom level 17 shows buildings to give users on foot a sense of situational awareness.
    /// </summary>
    public class TileCoordinates : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The x coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("x")]
        public virtual System.Nullable<int> X { get; set; }

        /// <summary>Required. The y coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("y")]
        public virtual System.Nullable<int> Y { get; set; }

        /// <summary>Required. The Google Maps API zoom level.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zoom")]
        public virtual System.Nullable<int> Zoom { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a strip of triangles. Each triangle uses the last edge of the previous one. The following diagram
    /// shows an example of a triangle strip, with each vertex labeled with its index in the vertex_index array.
    /// (1)-----(3) / \ / \ / \ / \ / \ / \ (0)-----(2)-----(4) Vertices may be in either clockwise or counter-clockwise
    /// order.
    /// </summary>
    public class TriangleStrip : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Index into the vertex_offset array representing the next vertex in the triangle strip.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vertexIndices")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> VertexIndices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// 2D vertex list used for lines and areas. Each entry represents an offset from the previous one in local tile
    /// coordinates. The first entry is offset from (0, 0). For example, the list of vertices [(1,1), (2, 2), (1, 2)]
    /// would be encoded in vertex offsets as [(1, 1), (1, 1), (-1, 0)].
    /// </summary>
    public class Vertex2DList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of x-offsets in local tile coordinates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("xOffsets")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> XOffsets { get; set; }

        /// <summary>List of y-offsets in local tile coordinates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yOffsets")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> YOffsets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// 3D vertex list used for modeled volumes. Each entry represents an offset from the previous one in local tile
    /// coordinates. The first coordinate is offset from (0, 0, 0).
    /// </summary>
    public class Vertex3DList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of x-offsets in local tile coordinates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("xOffsets")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> XOffsets { get; set; }

        /// <summary>List of y-offsets in local tile coordinates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yOffsets")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> YOffsets { get; set; }

        /// <summary>List of z-offsets in local tile coordinates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zOffsets")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> ZOffsets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
