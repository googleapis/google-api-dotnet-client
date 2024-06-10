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

namespace Google.Apis.AirQuality.v1
{
    /// <summary>The AirQuality Service.</summary>
    public class AirQualityService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AirQualityService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AirQualityService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            CurrentConditions = new CurrentConditionsResource(this);
            Forecast = new ForecastResource(this);
            History = new HistoryResource(this);
            MapTypes = new MapTypesResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://airquality.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://airquality.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "airquality";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Air Quality API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Air Quality API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the CurrentConditions resource.</summary>
        public virtual CurrentConditionsResource CurrentConditions { get; }

        /// <summary>Gets the Forecast resource.</summary>
        public virtual ForecastResource Forecast { get; }

        /// <summary>Gets the History resource.</summary>
        public virtual HistoryResource History { get; }

        /// <summary>Gets the MapTypes resource.</summary>
        public virtual MapTypesResource MapTypes { get; }
    }

    /// <summary>A base abstract class for AirQuality requests.</summary>
    public abstract class AirQualityBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new AirQualityBaseServiceRequest instance.</summary>
        protected AirQualityBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes AirQuality parameter list.</summary>
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

    /// <summary>The "currentConditions" collection of methods.</summary>
    public class CurrentConditionsResource
    {
        private const string Resource = "currentConditions";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public CurrentConditionsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// The Current Conditions endpoint provides hourly air quality information in more than 100 countries, up to a
        /// 500 x 500 meters resolution. Includes over 70 local indexes and global air quality index and categories.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual LookupRequest Lookup(Google.Apis.AirQuality.v1.Data.LookupCurrentConditionsRequest body)
        {
            return new LookupRequest(this.service, body);
        }

        /// <summary>
        /// The Current Conditions endpoint provides hourly air quality information in more than 100 countries, up to a
        /// 500 x 500 meters resolution. Includes over 70 local indexes and global air quality index and categories.
        /// </summary>
        public class LookupRequest : AirQualityBaseServiceRequest<Google.Apis.AirQuality.v1.Data.LookupCurrentConditionsResponse>
        {
            /// <summary>Constructs a new Lookup request.</summary>
            public LookupRequest(Google.Apis.Services.IClientService service, Google.Apis.AirQuality.v1.Data.LookupCurrentConditionsRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AirQuality.v1.Data.LookupCurrentConditionsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "lookup";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/currentConditions:lookup";

            /// <summary>Initializes Lookup parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "forecast" collection of methods.</summary>
    public class ForecastResource
    {
        private const string Resource = "forecast";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ForecastResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Returns air quality forecast for a specific location for a given time range.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual LookupRequest Lookup(Google.Apis.AirQuality.v1.Data.LookupForecastRequest body)
        {
            return new LookupRequest(this.service, body);
        }

        /// <summary>Returns air quality forecast for a specific location for a given time range.</summary>
        public class LookupRequest : AirQualityBaseServiceRequest<Google.Apis.AirQuality.v1.Data.LookupForecastResponse>
        {
            /// <summary>Constructs a new Lookup request.</summary>
            public LookupRequest(Google.Apis.Services.IClientService service, Google.Apis.AirQuality.v1.Data.LookupForecastRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AirQuality.v1.Data.LookupForecastRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "lookup";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/forecast:lookup";

            /// <summary>Initializes Lookup parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

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

        /// <summary>Returns air quality history for a specific location for a given time range.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual LookupRequest Lookup(Google.Apis.AirQuality.v1.Data.LookupHistoryRequest body)
        {
            return new LookupRequest(this.service, body);
        }

        /// <summary>Returns air quality history for a specific location for a given time range.</summary>
        public class LookupRequest : AirQualityBaseServiceRequest<Google.Apis.AirQuality.v1.Data.LookupHistoryResponse>
        {
            /// <summary>Constructs a new Lookup request.</summary>
            public LookupRequest(Google.Apis.Services.IClientService service, Google.Apis.AirQuality.v1.Data.LookupHistoryRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AirQuality.v1.Data.LookupHistoryRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "lookup";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/history:lookup";

            /// <summary>Initializes Lookup parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "mapTypes" collection of methods.</summary>
    public class MapTypesResource
    {
        private const string Resource = "mapTypes";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public MapTypesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            HeatmapTiles = new HeatmapTilesResource(service);
        }

        /// <summary>Gets the HeatmapTiles resource.</summary>
        public virtual HeatmapTilesResource HeatmapTiles { get; }

        /// <summary>The "heatmapTiles" collection of methods.</summary>
        public class HeatmapTilesResource
        {
            private const string Resource = "heatmapTiles";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public HeatmapTilesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Returns a bytes array containing the data of the tile PNG image.</summary>
            /// <param name="mapType">
            /// Required. The type of the air quality heatmap. Defines the pollutant that the map will graphically
            /// represent. Allowed values: - UAQI_RED_GREEN (UAQI, red-green palette) - UAQI_INDIGO_PERSIAN (UAQI,
            /// indigo-persian palette) - PM25_INDIGO_PERSIAN - GBR_DEFRA - DEU_UBA - CAN_EC - FRA_ATMO - US_AQI
            /// </param>
            /// <param name="zoom">
            /// Required. The map's zoom level. Defines how large or small the contents of a map appear in a map view.
            /// Zoom level 0 is the entire world in a single tile. Zoom level 1 is the entire world in 4 tiles. Zoom
            /// level 2 is the entire world in 16 tiles. Zoom level 16 is the entire world in 65,536 tiles. Allowed
            /// values: 0-16
            /// </param>
            /// <param name="x">Required. Defines the east-west point in the requested tile.</param>
            /// <param name="y">Required. Defines the north-south point in the requested tile.</param>
            public virtual LookupHeatmapTileRequest LookupHeatmapTile(LookupHeatmapTileRequest.MapTypeEnum mapType, int zoom, int x, int y)
            {
                return new LookupHeatmapTileRequest(this.service, mapType, zoom, x, y);
            }

            /// <summary>Returns a bytes array containing the data of the tile PNG image.</summary>
            public class LookupHeatmapTileRequest : AirQualityBaseServiceRequest<Google.Apis.AirQuality.v1.Data.HttpBody>
            {
                /// <summary>Constructs a new LookupHeatmapTile request.</summary>
                public LookupHeatmapTileRequest(Google.Apis.Services.IClientService service, MapTypeEnum mapType, int zoom, int x, int y) : base(service)
                {
                    MapType = mapType;
                    Zoom = zoom;
                    X = x;
                    Y = y;
                    InitParameters();
                }

                /// <summary>
                /// Required. The type of the air quality heatmap. Defines the pollutant that the map will graphically
                /// represent. Allowed values: - UAQI_RED_GREEN (UAQI, red-green palette) - UAQI_INDIGO_PERSIAN (UAQI,
                /// indigo-persian palette) - PM25_INDIGO_PERSIAN - GBR_DEFRA - DEU_UBA - CAN_EC - FRA_ATMO - US_AQI
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("mapType", Google.Apis.Util.RequestParameterType.Path)]
                public virtual MapTypeEnum MapType { get; private set; }

                /// <summary>
                /// Required. The type of the air quality heatmap. Defines the pollutant that the map will graphically
                /// represent. Allowed values: - UAQI_RED_GREEN (UAQI, red-green palette) - UAQI_INDIGO_PERSIAN (UAQI,
                /// indigo-persian palette) - PM25_INDIGO_PERSIAN - GBR_DEFRA - DEU_UBA - CAN_EC - FRA_ATMO - US_AQI
                /// </summary>
                public enum MapTypeEnum
                {
                    /// <summary>The default value. The server ignores it if it is passed as a parameter.</summary>
                    [Google.Apis.Util.StringValueAttribute("MAP_TYPE_UNSPECIFIED")]
                    MAPTYPEUNSPECIFIED = 0,

                    /// <summary>Universal Air Quality Index red-green palette.</summary>
                    [Google.Apis.Util.StringValueAttribute("UAQI_RED_GREEN")]
                    UAQIREDGREEN = 1,

                    /// <summary>Universal Air Quality Index indigo-persian palette.</summary>
                    [Google.Apis.Util.StringValueAttribute("UAQI_INDIGO_PERSIAN")]
                    UAQIINDIGOPERSIAN = 2,

                    /// <summary>PM2.5 index indigo-persian palette.</summary>
                    [Google.Apis.Util.StringValueAttribute("PM25_INDIGO_PERSIAN")]
                    PM25INDIGOPERSIAN = 3,

                    /// <summary>Daily Air Quality Index (UK) color palette.</summary>
                    [Google.Apis.Util.StringValueAttribute("GBR_DEFRA")]
                    GBRDEFRA = 4,

                    /// <summary>German Local Air Quality Index color palette.</summary>
                    [Google.Apis.Util.StringValueAttribute("DEU_UBA")]
                    DEUUBA = 5,

                    /// <summary>Canadian Air Quality Health Index color palette.</summary>
                    [Google.Apis.Util.StringValueAttribute("CAN_EC")]
                    CANEC = 6,

                    /// <summary>France Air Quality Index color palette.</summary>
                    [Google.Apis.Util.StringValueAttribute("FRA_ATMO")]
                    FRAATMO = 7,

                    /// <summary>US Air Quality Index color palette.</summary>
                    [Google.Apis.Util.StringValueAttribute("US_AQI")]
                    USAQI = 8,
                }

                /// <summary>
                /// Required. The map's zoom level. Defines how large or small the contents of a map appear in a map
                /// view. Zoom level 0 is the entire world in a single tile. Zoom level 1 is the entire world in 4
                /// tiles. Zoom level 2 is the entire world in 16 tiles. Zoom level 16 is the entire world in 65,536
                /// tiles. Allowed values: 0-16
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("zoom", Google.Apis.Util.RequestParameterType.Path)]
                public virtual int Zoom { get; private set; }

                /// <summary>Required. Defines the east-west point in the requested tile.</summary>
                [Google.Apis.Util.RequestParameterAttribute("x", Google.Apis.Util.RequestParameterType.Path)]
                public virtual int X { get; private set; }

                /// <summary>Required. Defines the north-south point in the requested tile.</summary>
                [Google.Apis.Util.RequestParameterAttribute("y", Google.Apis.Util.RequestParameterType.Path)]
                public virtual int Y { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "lookupHeatmapTile";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/mapTypes/{mapType}/heatmapTiles/{zoom}/{x}/{y}";

                /// <summary>Initializes LookupHeatmapTile parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("mapType", new Google.Apis.Discovery.Parameter
                    {
                        Name = "mapType",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("zoom", new Google.Apis.Discovery.Parameter
                    {
                        Name = "zoom",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("x", new Google.Apis.Discovery.Parameter
                    {
                        Name = "x",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("y", new Google.Apis.Discovery.Parameter
                    {
                        Name = "y",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }
    }
}
namespace Google.Apis.AirQuality.v1.Data
{
    /// <summary>The emission sources and health effects of a given pollutant.</summary>
    public class AdditionalInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Text representing the pollutant's main health effects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effects")]
        public virtual string Effects { get; set; }

        /// <summary>Text representing the pollutant's main emission sources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sources")]
        public virtual string Sources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The basic object for representing different air quality metrics. When brought together, these metrics provide a
    /// snapshot about the current air quality conditions. There are multiple indexes in the world serving different
    /// purposes and groups interested in measuring different aspects of air quality.
    /// </summary>
    public class AirQualityIndex : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        ///  The index's numeric score. Examples: 10, 100. The value is not normalized and should only be interpreted in
        /// the context of its related air-quality index. For non-numeric indexes, this field will not be returned.
        /// Note: This field should be used for calculations, graph display, etc. For displaying the index score, you
        /// should use the AQI display field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aqi")]
        public virtual System.Nullable<int> Aqi { get; set; }

        /// <summary>
        /// Textual representation of the index numeric score, that may include prefix or suffix symbols, which usually
        /// represents the worst index score. Example: &amp;gt;100 or 10+. Note: This field should be used when you want
        /// to display the index score. For non-numeric indexes, this field is empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aqiDisplay")]
        public virtual string AqiDisplay { get; set; }

        /// <summary>
        /// Textual classification of the index numeric score interpretation. For example: "Excellent air quality".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>
        /// The index's code. This field represents the index for programming purposes by using snake case instead of
        /// spaces. Examples: "uaqi", "fra_atmo".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>The color used to represent the AQI numeric score.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual Color Color { get; set; }

        /// <summary>A human readable representation of the index name. Example: "AQI (US)"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The chemical symbol of the dominant pollutant. For example: "CO".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dominantPollutant")]
        public virtual string DominantPollutant { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a color in the RGBA color space. This representation is designed for simplicity of conversion to and
    /// from color representations in various languages over compactness. For example, the fields of this representation
    /// can be trivially provided to the constructor of `java.awt.Color` in Java; it can also be trivially provided to
    /// UIColor's `+colorWithRed:green:blue:alpha` method in iOS; and, with just a little work, it can be easily
    /// formatted into a CSS `rgba()` string in JavaScript. This reference page doesn't have information about the
    /// absolute color space that should be used to interpret the RGB value—for example, sRGB, Adobe RGB, DCI-P3, and
    /// BT.2020. By default, applications should assume the sRGB color space. When color equality needs to be decided,
    /// implementations, unless documented otherwise, treat two colors as equal if all their red, green, blue, and alpha
    /// values each differ by at most `1e-5`. Example (Java): import com.google.type.Color; // ... public static
    /// java.awt.Color fromProto(Color protocolor) { float alpha = protocolor.hasAlpha() ?
    /// protocolor.getAlpha().getValue() : 1.0; return new java.awt.Color( protocolor.getRed(), protocolor.getGreen(),
    /// protocolor.getBlue(), alpha); } public static Color toProto(java.awt.Color color) { float red = (float)
    /// color.getRed(); float green = (float) color.getGreen(); float blue = (float) color.getBlue(); float denominator
    /// = 255.0; Color.Builder resultBuilder = Color .newBuilder() .setRed(red / denominator) .setGreen(green /
    /// denominator) .setBlue(blue / denominator); int alpha = color.getAlpha(); if (alpha != 255) { result.setAlpha(
    /// FloatValue .newBuilder() .setValue(((float) alpha) / denominator) .build()); } return resultBuilder.build(); }
    /// // ... Example (iOS / Obj-C): // ... static UIColor* fromProto(Color* protocolor) { float red = [protocolor
    /// red]; float green = [protocolor green]; float blue = [protocolor blue]; FloatValue* alpha_wrapper = [protocolor
    /// alpha]; float alpha = 1.0; if (alpha_wrapper != nil) { alpha = [alpha_wrapper value]; } return [UIColor
    /// colorWithRed:red green:green blue:blue alpha:alpha]; } static Color* toProto(UIColor* color) { CGFloat red,
    /// green, blue, alpha; if (![color getRed:&amp;amp;red green:&amp;amp;green blue:&amp;amp;blue
    /// alpha:&amp;amp;alpha]) { return nil; } Color* result = [[Color alloc] init]; [result setRed:red]; [result
    /// setGreen:green]; [result setBlue:blue]; if (alpha &amp;lt;= 0.9999) { [result
    /// setAlpha:floatWrapperWithValue(alpha)]; } [result autorelease]; return result; } // ... Example (JavaScript): //
    /// ... var protoToCssColor = function(rgb_color) { var redFrac = rgb_color.red || 0.0; var greenFrac =
    /// rgb_color.green || 0.0; var blueFrac = rgb_color.blue || 0.0; var red = Math.floor(redFrac * 255); var green =
    /// Math.floor(greenFrac * 255); var blue = Math.floor(blueFrac * 255); if (!('alpha' in rgb_color)) { return
    /// rgbToCssColor(red, green, blue); } var alphaFrac = rgb_color.alpha.value || 0.0; var rgbParams = [red, green,
    /// blue].join(','); return ['rgba(', rgbParams, ',', alphaFrac, ')'].join(''); }; var rgbToCssColor = function(red,
    /// green, blue) { var rgbNumber = new Number((red &amp;lt;&amp;lt; 16) | (green &amp;lt;&amp;lt; 8) | blue); var
    /// hexString = rgbNumber.toString(16); var missingZeros = 6 - hexString.length; var resultBuilder = ['#']; for (var
    /// i = 0; i &amp;lt; missingZeros; i++) { resultBuilder.push('0'); } resultBuilder.push(hexString); return
    /// resultBuilder.join(''); }; // ...
    /// </summary>
    public class Color : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fraction of this color that should be applied to the pixel. That is, the final pixel color is defined by
        /// the equation: `pixel color = alpha * (this color) + (1.0 - alpha) * (background color)` This means that a
        /// value of 1.0 corresponds to a solid color, whereas a value of 0.0 corresponds to a completely transparent
        /// color. This uses a wrapper message rather than a simple float scalar so that it is possible to distinguish
        /// between a default value and the value being unset. If omitted, this color object is rendered as a solid
        /// color (as if the alpha value had been explicitly given a value of 1.0).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alpha")]
        public virtual System.Nullable<float> Alpha { get; set; }

        /// <summary>The amount of blue in the color as a value in the interval [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blue")]
        public virtual System.Nullable<float> Blue { get; set; }

        /// <summary>The amount of green in the color as a value in the interval [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("green")]
        public virtual System.Nullable<float> Green { get; set; }

        /// <summary>The amount of red in the color as a value in the interval [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("red")]
        public virtual System.Nullable<float> Red { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The concentration of a given pollutant in the air.</summary>
    public class Concentration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Units for measuring this pollutant concentration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("units")]
        public virtual string Units { get; set; }

        /// <summary>Value of pollutant concentration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<float> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Expresses a 'country/region to AQI' relationship. Pairs a country/region with a desired AQI so that air quality
    /// data that is required for that country/region will be displayed according to the chosen AQI.
    /// </summary>
    public class CustomLocalAqi : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The AQI to associate the country/region with. Value should be a [valid
        /// index](/maps/documentation/air-quality/laqis) code.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aqi")]
        public virtual string Aqi { get; set; }

        /// <summary>
        /// The country/region requiring the custom AQI. Value should be provided using [ISO 3166-1
        /// alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) code.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Health recommendations for different population groups in a free text format. The recommendations are derived
    /// from their associated air quality conditions.
    /// </summary>
    public class HealthRecommendations : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Sports and other strenuous outdoor activities.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("athletes")]
        public virtual string Athletes { get; set; }

        /// <summary>Younger populations including children, toddlers, and babies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("children")]
        public virtual string Children { get; set; }

        /// <summary>Retirees and people older than the general population.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("elderly")]
        public virtual string Elderly { get; set; }

        /// <summary>No specific sensitivities.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generalPopulation")]
        public virtual string GeneralPopulation { get; set; }

        /// <summary>Heart and circulatory system diseases.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heartDiseasePopulation")]
        public virtual string HeartDiseasePopulation { get; set; }

        /// <summary>Respiratory related problems and asthma suffers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lungDiseasePopulation")]
        public virtual string LungDiseasePopulation { get; set; }

        /// <summary>Women at all stages of pregnancy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pregnantWomen")]
        public virtual string PregnantWomen { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains the air quality information for each hour in the requested range. For example, if the request is for 48
    /// hours of history there will be 48 elements of hourly info.
    /// </summary>
    public class HourInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _dateTimeRaw;

        private object _dateTime;

        /// <summary>
        /// A rounded down timestamp indicating the time the data refers to in RFC3339 UTC "Zulu" format, with
        /// nanosecond resolution and up to nine fractional digits. For example: "2014-10-02T15:00:00Z".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateTime")]
        public virtual string DateTimeRaw
        {
            get => _dateTimeRaw;
            set
            {
                _dateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _dateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DateTimeDateTimeOffset instead.")]
        public virtual object DateTime
        {
            get => _dateTime;
            set
            {
                _dateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _dateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DateTimeRaw);
            set => DateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Health advice and recommended actions related to the reported air quality conditions. Recommendations are
        /// tailored differently for populations at risk, groups with greater sensitivities to pollutants, and the
        /// general population.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthRecommendations")]
        public virtual HealthRecommendations HealthRecommendations { get; set; }

        /// <summary>
        /// Based on the request parameters, this list will include (up to) two air quality indexes: - Universal AQI.
        /// Will be returned if the universalAqi boolean is set to true. - Local AQI. Will be returned if the LOCAL_AQI
        /// extra computation is specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexes")]
        public virtual System.Collections.Generic.IList<AirQualityIndex> Indexes { get; set; }

        /// <summary>
        /// A list of pollutants affecting the location specified in the request. Note: This field will be returned only
        /// for requests that specified one or more of the following extra computations: POLLUTANT_ADDITIONAL_INFO,
        /// DOMINANT_POLLUTANT_CONCENTRATION, POLLUTANT_CONCENTRATION.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pollutants")]
        public virtual System.Collections.Generic.IList<Pollutant> Pollutants { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains the air quality information for each hour in the requested range. For example, if the request is for 48
    /// hours of forecast there will be 48 elements of hourly forecasts.
    /// </summary>
    public class HourlyForecast : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _dateTimeRaw;

        private object _dateTime;

        /// <summary>
        /// A rounded down timestamp indicating the time (hour) the data refers to in RFC3339 UTC "Zulu" format. For
        /// example: "2014-10-02T15:00:00Z".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateTime")]
        public virtual string DateTimeRaw
        {
            get => _dateTimeRaw;
            set
            {
                _dateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _dateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DateTimeDateTimeOffset instead.")]
        public virtual object DateTime
        {
            get => _dateTime;
            set
            {
                _dateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _dateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DateTimeRaw);
            set => DateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Health advice and recommended actions related to the reported air quality conditions. Recommendations are
        /// tailored differently for populations at risk, groups with greater sensitivities to pollutants, and the
        /// general population.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthRecommendations")]
        public virtual HealthRecommendations HealthRecommendations { get; set; }

        /// <summary>
        /// Based on the request parameters, this list will include (up to) two air quality indexes: - Universal AQI.
        /// Will be returned if the `universal_aqi` boolean is set to true. - Local AQI. Will be returned if the
        /// LOCAL_AQI extra computation is specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexes")]
        public virtual System.Collections.Generic.IList<AirQualityIndex> Indexes { get; set; }

        /// <summary>
        /// A list of pollutants affecting the location specified in the request. Note: This field will be returned only
        /// for requests that specified one or more of the following extra computations: POLLUTANT_ADDITIONAL_INFO,
        /// DOMINANT_POLLUTANT_CONCENTRATION, POLLUTANT_CONCENTRATION.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pollutants")]
        public virtual System.Collections.Generic.IList<Pollutant> Pollutants { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Message that represents an arbitrary HTTP body. It should only be used for payload formats that can't be
    /// represented as JSON, such as raw binary or an HTML page. This message can be used both in streaming and
    /// non-streaming API methods in the request as well as the response. It can be used as a top-level request field,
    /// which is convenient if one wants to extract parameters from either the URL or HTTP template into the request
    /// fields and also want access to the raw HTTP body. Example: message GetResourceRequest { // A unique request id.
    /// string request_id = 1; // The raw HTTP body is bound to this field. google.api.HttpBody http_body = 2; } service
    /// ResourceService { rpc GetResource(GetResourceRequest) returns (google.api.HttpBody); rpc
    /// UpdateResource(google.api.HttpBody) returns (google.protobuf.Empty); } Example with streaming methods: service
    /// CaldavService { rpc GetCalendar(stream google.api.HttpBody) returns (stream google.api.HttpBody); rpc
    /// UpdateCalendar(stream google.api.HttpBody) returns (stream google.api.HttpBody); } Use of this type only changes
    /// how the request and response bodies are handled, all other features will continue to work unchanged.
    /// </summary>
    public class HttpBody : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The HTTP Content-Type header value specifying the content type of the body.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentType")]
        public virtual string ContentType { get; set; }

        /// <summary>The HTTP request/response body as raw binary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>
        /// Application specific response metadata. Must be set in the first response for streaming APIs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extensions")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Extensions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a time interval, encoded as a Timestamp start (inclusive) and a Timestamp end (exclusive). The start
    /// must be less than or equal to the end. When the start equals the end, the interval is empty (matches no time).
    /// When both start and end are unspecified, the interval matches any time.
    /// </summary>
    public class Interval : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>
        /// Optional. Exclusive end of the interval. If specified, a Timestamp matching this interval will have to be
        /// before the end.
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

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>
        /// Optional. Inclusive start of the interval. If specified, a Timestamp matching this interval will have to be
        /// the same or after the start.
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

    /// <summary>
    /// An object that represents a latitude/longitude pair. This is expressed as a pair of doubles to represent degrees
    /// latitude and degrees longitude. Unless specified otherwise, this object must conform to the WGS84 standard.
    /// Values must be within normalized ranges.
    /// </summary>
    public class LatLng : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The latitude in degrees. It must be in the range [-90.0, +90.0].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latitude")]
        public virtual System.Nullable<double> Latitude { get; set; }

        /// <summary>The longitude in degrees. It must be in the range [-180.0, +180.0].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longitude")]
        public virtual System.Nullable<double> Longitude { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request definition of the air quality current conditions.</summary>
    public class LookupCurrentConditionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Expresses a 'country/region to AQI' relationship. Pairs a country/region with a desired AQI so
        /// that air quality data that is required for that country/region will be displayed according to the chosen
        /// AQI. This parameter can be used to specify a non-default AQI for a given country, for example, to get the US
        /// EPA index for Canada rather than the default index for Canada.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customLocalAqis")]
        public virtual System.Collections.Generic.IList<CustomLocalAqi> CustomLocalAqis { get; set; }

        /// <summary>
        /// Optional. Additional features that can be optionally enabled. Specifying extra computations will result in
        /// the relevant elements and fields to be returned in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extraComputations")]
        public virtual System.Collections.Generic.IList<string> ExtraComputations { get; set; }

        /// <summary>
        /// Optional. Allows the client to choose the language for the response. If data cannot be provided for that
        /// language the API uses the closest match. Allowed values rely on the IETF standard. Default value is en.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// Required. The longitude and latitude from which the API looks for air quality current conditions data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual LatLng Location { get; set; }

        /// <summary>
        /// Optional. Determines the color palette used for data provided by the 'Universal Air Quality Index' (UAQI).
        /// This color palette is relevant just for UAQI, other AQIs have a predetermined color palette that can't be
        /// controlled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uaqiColorPalette")]
        public virtual string UaqiColorPalette { get; set; }

        /// <summary>
        /// Optional. If set to true, the Universal AQI will be included in the 'indexes' field of the response. Default
        /// value is true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("universalAqi")]
        public virtual System.Nullable<bool> UniversalAqi { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class LookupCurrentConditionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _dateTimeRaw;

        private object _dateTime;

        /// <summary>
        /// A rounded down timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional
        /// digits. For example: "2014-10-02T15:00:00Z".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateTime")]
        public virtual string DateTimeRaw
        {
            get => _dateTimeRaw;
            set
            {
                _dateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _dateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DateTimeDateTimeOffset instead.")]
        public virtual object DateTime
        {
            get => _dateTime;
            set
            {
                _dateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _dateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DateTimeRaw);
            set => DateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Health advice and recommended actions related to the reported air quality conditions. Recommendations are
        /// tailored differently for populations at risk, groups with greater sensitivities to pollutants, and the
        /// general population.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthRecommendations")]
        public virtual HealthRecommendations HealthRecommendations { get; set; }

        /// <summary>
        /// Based on the request parameters, this list will include (up to) two air quality indexes: - Universal AQI.
        /// Will be returned if the universalAqi boolean is set to true. - Local AQI. Will be returned if the LOCAL_AQI
        /// extra computation is specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexes")]
        public virtual System.Collections.Generic.IList<AirQualityIndex> Indexes { get; set; }

        /// <summary>
        /// A list of pollutants affecting the location specified in the request. Note: This field will be returned only
        /// for requests that specified one or more of the following extra computations: POLLUTANT_ADDITIONAL_INFO,
        /// DOMINANT_POLLUTANT_CONCENTRATION, POLLUTANT_CONCENTRATION.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pollutants")]
        public virtual System.Collections.Generic.IList<Pollutant> Pollutants { get; set; }

        /// <summary>
        /// The ISO_3166-1 alpha-2 code of the country/region corresponding to the location provided in the request.
        /// This field might be omitted from the response if the location provided in the request resides in a disputed
        /// territory.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request object of the air quality forecast API.</summary>
    public class LookupForecastRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Expresses a 'country/region to AQI' relationship. Pairs a country/region with a desired AQI so
        /// that air quality data that is required for that country/region will be displayed according to the chosen
        /// AQI. This parameter can be used to specify a non-default AQI for a given country, for example, to get the US
        /// EPA index for Canada rather than the default index for Canada.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customLocalAqis")]
        public virtual System.Collections.Generic.IList<CustomLocalAqi> CustomLocalAqis { get; set; }

        private string _dateTimeRaw;

        private object _dateTime;

        /// <summary>
        /// A timestamp for which to return the data for a specific point in time. The timestamp is rounded to the
        /// previous exact hour. Note: this will return hourly data for the requested timestamp only (i.e. a single
        /// hourly info element). For example, a request sent where the date_time parameter is set to
        /// 2023-01-03T11:05:49Z will be rounded down to 2023-01-03T11:00:00Z.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateTime")]
        public virtual string DateTimeRaw
        {
            get => _dateTimeRaw;
            set
            {
                _dateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _dateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DateTimeDateTimeOffset instead.")]
        public virtual object DateTime
        {
            get => _dateTime;
            set
            {
                _dateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _dateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DateTimeRaw);
            set => DateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Optional. Additional features that can be optionally enabled. Specifying extra computations will result in
        /// the relevant elements and fields to be returned in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extraComputations")]
        public virtual System.Collections.Generic.IList<string> ExtraComputations { get; set; }

        /// <summary>
        /// Optional. Allows the client to choose the language for the response. If data cannot be provided for that
        /// language the API uses the closest match. Allowed values rely on the IETF standard (default = 'en').
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>Required. The latitude and longitude for which the API looks for air quality data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual LatLng Location { get; set; }

        /// <summary>Optional. The maximum number of hourly info records to return per page (default = 24).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// Optional. A page token received from a previous forecast call. It is used to retrieve the subsequent page.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>
        /// Indicates the start and end period for which to get the forecast data. The timestamp is rounded to the
        /// previous exact hour.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("period")]
        public virtual Interval Period { get; set; }

        /// <summary>
        /// Optional. Determines the color palette used for data provided by the 'Universal Air Quality Index' (UAQI).
        /// This color palette is relevant just for UAQI, other AQIs have a predetermined color palette that can't be
        /// controlled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uaqiColorPalette")]
        public virtual string UaqiColorPalette { get; set; }

        /// <summary>
        /// Optional. If set to true, the Universal AQI will be included in the 'indexes' field of the response (default
        /// = true).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("universalAqi")]
        public virtual System.Nullable<bool> UniversalAqi { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response object of the air quality forecast API.</summary>
    public class LookupForecastResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Contains the air quality information for each hour in the requested range. For example, if the
        /// request is for 48 hours of forecast there will be 48 elements of hourly forecasts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hourlyForecasts")]
        public virtual System.Collections.Generic.IList<HourlyForecast> HourlyForecasts { get; set; }

        /// <summary>Optional. The token to retrieve the next page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// Optional. The ISO_3166-1 alpha-2 code of the country/region corresponding to the location provided in the
        /// request. This field might be omitted from the response if the location provided in the request resides in a
        /// disputed territory.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request object of the air quality history API.</summary>
    public class LookupHistoryRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Expresses a 'country/region to AQI' relationship. Pairs a country/region with a desired AQI so
        /// that air quality data that is required for that country/region will be displayed according to the chosen
        /// AQI. This parameter can be used to specify a non-default AQI for a given country, for example, to get the US
        /// EPA index for Canada rather than the default index for Canada.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customLocalAqis")]
        public virtual System.Collections.Generic.IList<CustomLocalAqi> CustomLocalAqis { get; set; }

        private string _dateTimeRaw;

        private object _dateTime;

        /// <summary>
        /// A timestamp for which to return historical data. The timestamp is rounded to the previous exact hour. Note:
        /// this will return hourly data for the requested timestamp only (i.e. a single hourly info element). For
        /// example, a request sent where the dateTime parameter is set to 2023-01-03T11:05:49Z will be rounded down to
        /// 2023-01-03T11:00:00Z. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine
        /// fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateTime")]
        public virtual string DateTimeRaw
        {
            get => _dateTimeRaw;
            set
            {
                _dateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _dateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DateTimeDateTimeOffset instead.")]
        public virtual object DateTime
        {
            get => _dateTime;
            set
            {
                _dateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _dateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DateTimeRaw);
            set => DateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Optional. Additional features that can be optionally enabled. Specifying extra computations will result in
        /// the relevant elements and fields to be returned in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extraComputations")]
        public virtual System.Collections.Generic.IList<string> ExtraComputations { get; set; }

        /// <summary>
        /// Number from 1 to 720 that indicates the hours range for the request. For example: A value of 48 will yield
        /// data from the last 48 hours.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hours")]
        public virtual System.Nullable<int> Hours { get; set; }

        /// <summary>
        /// Optional. Allows the client to choose the language for the response. If data cannot be provided for that
        /// language the API uses the closest match. Allowed values rely on the IETF standard. Default value is en.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// Required. The latitude and longitude for which the API looks for air quality history data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual LatLng Location { get; set; }

        /// <summary>
        /// Optional. The maximum number of hourly info records to return per page. The default is 72 and the max value
        /// is 168 (7 days of data).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// Optional. A page token received from a previous history call. It is used to retrieve the subsequent page.
        /// Note that when providing a value for this parameter all other parameters provided must match the call that
        /// provided the page token (the previous call).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>
        /// Indicates the start and end period for which to get the historical data. The timestamp is rounded to the
        /// previous exact hour.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("period")]
        public virtual Interval Period { get; set; }

        /// <summary>
        /// Optional. Determines the color palette used for data provided by the 'Universal Air Quality Index' (UAQI).
        /// This color palette is relevant just for UAQI, other AQIs have a predetermined color palette that can't be
        /// controlled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uaqiColorPalette")]
        public virtual string UaqiColorPalette { get; set; }

        /// <summary>
        /// Optional. If set to true, the Universal AQI will be included in the 'indexes' field of the response. Default
        /// value is true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("universalAqi")]
        public virtual System.Nullable<bool> UniversalAqi { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class LookupHistoryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Contains the air quality information for each hour in the requested range. For example, if the
        /// request is for 48 hours of history there will be 48 elements of hourly info.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hoursInfo")]
        public virtual System.Collections.Generic.IList<HourInfo> HoursInfo { get; set; }

        /// <summary>Optional. The token to retrieve the next page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// Optional. The ISO_3166-1 alpha-2 code of the country/region corresponding to the location provided in the
        /// request. This field might be omitted from the response if the location provided in the request resides in a
        /// disputed territory.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data regarding an air quality pollutant.</summary>
    public class Pollutant : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional information about the pollutant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalInfo")]
        public virtual AdditionalInfo AdditionalInfo { get; set; }

        /// <summary>
        /// The pollutant's code name. For example: "so2". A list of all available codes could be found
        /// [here](/maps/documentation/air-quality/pollutants#reported_pollutants).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>
        /// The pollutant's concentration level measured by one of the standard air pollutation measure units.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("concentration")]
        public virtual Concentration Concentration { get; set; }

        /// <summary>The pollutant's display name. For example: "NOx".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The pollutant's full name. For chemical compounds, this is the IUPAC name. Example: "Sulfur Dioxide". For
        /// more information about the IUPAC names table, see https://iupac.org/what-we-do/periodic-table-of-elements/
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullName")]
        public virtual string FullName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
