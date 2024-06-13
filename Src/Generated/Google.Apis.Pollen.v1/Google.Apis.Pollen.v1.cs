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

namespace Google.Apis.Pollen.v1
{
    /// <summary>The Pollen Service.</summary>
    public class PollenService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public PollenService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public PollenService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Forecast = new ForecastResource(this);
            MapTypes = new MapTypesResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://pollen.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://pollen.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "pollen";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Pollen API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Pollen API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Forecast resource.</summary>
        public virtual ForecastResource Forecast { get; }

        /// <summary>Gets the MapTypes resource.</summary>
        public virtual MapTypesResource MapTypes { get; }
    }

    /// <summary>A base abstract class for Pollen requests.</summary>
    public abstract class PollenBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new PollenBaseServiceRequest instance.</summary>
        protected PollenBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Pollen parameter list.</summary>
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

        /// <summary>
        /// Returns up to 5 days of daily pollen information in more than 65 countries, up to 1km resolution.
        /// </summary>
        public virtual LookupRequest Lookup()
        {
            return new LookupRequest(this.service);
        }

        /// <summary>
        /// Returns up to 5 days of daily pollen information in more than 65 countries, up to 1km resolution.
        /// </summary>
        public class LookupRequest : PollenBaseServiceRequest<Google.Apis.Pollen.v1.Data.LookupForecastResponse>
        {
            /// <summary>Constructs a new Lookup request.</summary>
            public LookupRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Required. A number that indicates how many forecast days to request (minimum value 1, maximum value is
            /// 5).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("days", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> Days { get; set; }

            /// <summary>
            /// Optional. Allows the client to choose the language for the response. If data cannot be provided for that
            /// language the API uses the closest match. Allowed values rely on the IETF BCP-47 standard. Default value
            /// is "en".
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string LanguageCode { get; set; }

            /// <summary>The latitude in degrees. It must be in the range [-90.0, +90.0].</summary>
            [Google.Apis.Util.RequestParameterAttribute("location.latitude", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<double> LocationLatitude { get; set; }

            /// <summary>The longitude in degrees. It must be in the range [-180.0, +180.0].</summary>
            [Google.Apis.Util.RequestParameterAttribute("location.longitude", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<double> LocationLongitude { get; set; }

            /// <summary>
            /// Optional. The maximum number of daily info records to return per page. The default and max value is 5 (5
            /// days of data).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. A page token received from a previous daily call. It is used to retrieve the subsequent page.
            /// Note that when providing a value for the page token all other request parameters provided must match the
            /// previous call that provided the page token.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Optional. Contains general information about plants, including details on their seasonality, special
            /// shapes and colors, information about allergic cross-reactions, and plant photos.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("plantsDescription", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> PlantsDescription { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "lookup";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/forecast:lookup";

            /// <summary>Initializes Lookup parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("days", new Google.Apis.Discovery.Parameter
                {
                    Name = "days",
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
                RequestParameters.Add("location.latitude", new Google.Apis.Discovery.Parameter
                {
                    Name = "location.latitude",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("location.longitude", new Google.Apis.Discovery.Parameter
                {
                    Name = "location.longitude",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
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
                RequestParameters.Add("plantsDescription", new Google.Apis.Discovery.Parameter
                {
                    Name = "plantsDescription",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
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

            /// <summary>Returns a byte array containing the data of the tile PNG image.</summary>
            /// <param name="mapType">
            /// Required. The type of the pollen heatmap. Defines the combination of pollen type and index that the map
            /// will graphically represent.
            /// </param>
            /// <param name="zoom">
            /// Required. The map's zoom level. Defines how large or small the contents of a map appear in a map view. *
            /// Zoom level 0 is the entire world in a single tile. * Zoom level 1 is the entire world in 4 tiles. * Zoom
            /// level 2 is the entire world in 16 tiles. * Zoom level 16 is the entire world in 65,536 tiles. Allowed
            /// values: 0-16
            /// </param>
            /// <param name="x">Required. Defines the east-west point in the requested tile.</param>
            /// <param name="y">Required. Defines the north-south point in the requested tile.</param>
            public virtual LookupHeatmapTileRequest LookupHeatmapTile(LookupHeatmapTileRequest.MapTypeEnum mapType, int zoom, int x, int y)
            {
                return new LookupHeatmapTileRequest(this.service, mapType, zoom, x, y);
            }

            /// <summary>Returns a byte array containing the data of the tile PNG image.</summary>
            public class LookupHeatmapTileRequest : PollenBaseServiceRequest<Google.Apis.Pollen.v1.Data.HttpBody>
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
                /// Required. The type of the pollen heatmap. Defines the combination of pollen type and index that the
                /// map will graphically represent.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("mapType", Google.Apis.Util.RequestParameterType.Path)]
                public virtual MapTypeEnum MapType { get; private set; }

                /// <summary>
                /// Required. The type of the pollen heatmap. Defines the combination of pollen type and index that the
                /// map will graphically represent.
                /// </summary>
                public enum MapTypeEnum
                {
                    /// <summary>Unspecified map type.</summary>
                    [Google.Apis.Util.StringValueAttribute("MAP_TYPE_UNSPECIFIED")]
                    MAPTYPEUNSPECIFIED = 0,

                    /// <summary>The heatmap type will represent a tree index graphical map.</summary>
                    [Google.Apis.Util.StringValueAttribute("TREE_UPI")]
                    TREEUPI = 1,

                    /// <summary>The heatmap type will represent a grass index graphical map.</summary>
                    [Google.Apis.Util.StringValueAttribute("GRASS_UPI")]
                    GRASSUPI = 2,

                    /// <summary>The heatmap type will represent a weed index graphically map.</summary>
                    [Google.Apis.Util.StringValueAttribute("WEED_UPI")]
                    WEEDUPI = 3,
                }

                /// <summary>
                /// Required. The map's zoom level. Defines how large or small the contents of a map appear in a map
                /// view. * Zoom level 0 is the entire world in a single tile. * Zoom level 1 is the entire world in 4
                /// tiles. * Zoom level 2 is the entire world in 16 tiles. * Zoom level 16 is the entire world in 65,536
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
namespace Google.Apis.Pollen.v1.Data
{
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

    /// <summary>
    /// Represents a whole or partial calendar date, such as a birthday. The time of day and time zone are either
    /// specified elsewhere or are insignificant. The date is relative to the Gregorian Calendar. This can represent one
    /// of the following: * A full date, with non-zero year, month, and day values. * A month and day, with a zero year
    /// (for example, an anniversary). * A year on its own, with a zero month and a zero day. * A year and month, with a
    /// zero day (for example, a credit card expiration date). Related types: * google.type.TimeOfDay *
    /// google.type.DateTime * google.protobuf.Timestamp
    /// </summary>
    public class Date : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a
        /// year and month where the day isn't significant.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual System.Nullable<int> Day { get; set; }

        /// <summary>Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("month")]
        public virtual System.Nullable<int> Month { get; set; }

        /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("year")]
        public virtual System.Nullable<int> Year { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This object contains the daily forecast information for each day requested.</summary>
    public class DayInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The date in UTC at which the pollen forecast data is represented.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual Date Date { get; set; }

        /// <summary>
        /// This list will include (up to) 15 pollen species affecting the location specified in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plantInfo")]
        public virtual System.Collections.Generic.IList<PlantInfo> PlantInfo { get; set; }

        /// <summary>
        /// This list will include (up to) three pollen types (grass, weed, tree) affecting the location specified in
        /// the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pollenTypeInfo")]
        public virtual System.Collections.Generic.IList<PollenTypeInfo> PollenTypeInfo { get; set; }

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

    /// <summary>This object contains data representing specific pollen index value, category and description.</summary>
    public class IndexInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Text classification of index numerical score interpretation. The index consists of six categories: * 0:
        /// "None" * 1: "Very low" * 2: "Low" * 3: "Moderate" * 4: "High" * 5: "Very high
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>
        /// The index's code. This field represents the index for programming purposes by using snake cases instead of
        /// spaces. Example: "UPI".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>The color used to represent the Pollen Index numeric score.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual Color Color { get; set; }

        /// <summary>A human readable representation of the index name. Example: "Universal Pollen Index".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Textual explanation of current index level.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexDescription")]
        public virtual string IndexDescription { get; set; }

        /// <summary>The index's numeric score. Numeric range is between 0 and 5.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<int> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class LookupForecastResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. This object contains the daily forecast information for each day requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dailyInfo")]
        public virtual System.Collections.Generic.IList<DayInfo> DailyInfo { get; set; }

        /// <summary>Optional. The token to retrieve the next page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

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

    /// <summary>
    /// Contains general information about plants, including details on their seasonality, special shapes and colors,
    /// information about allergic cross-reactions, and plant photos.
    /// </summary>
    public class PlantDescription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Textual description of pollen cross reaction plants. Example: Alder, Hazel, Hornbeam, Beech, Willow, and Oak
        /// pollen.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crossReaction")]
        public virtual string CrossReaction { get; set; }

        /// <summary>
        /// A human readable representation of the plant family name. Example: "Betulaceae (the Birch family)".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("family")]
        public virtual string Family { get; set; }

        /// <summary>Link to the picture of the plant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("picture")]
        public virtual string Picture { get; set; }

        /// <summary>Link to a closeup picture of the plant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pictureCloseup")]
        public virtual string PictureCloseup { get; set; }

        /// <summary>
        /// Textual list of explanations of seasons where the pollen is active. Example: "Late winter, spring".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("season")]
        public virtual string Season { get; set; }

        /// <summary>
        /// Textual description of the plants' colors of leaves, bark, flowers or seeds that helps identify the plant.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("specialColors")]
        public virtual string SpecialColors { get; set; }

        /// <summary>
        /// Textual description of the plants' shapes of leaves, bark, flowers or seeds that helps identify the plant.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("specialShapes")]
        public virtual string SpecialShapes { get; set; }

        /// <summary>
        /// The plant's pollen type. For example: "GRASS". A list of all available codes could be found here.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This object contains the daily information on specific plant.</summary>
    public class PlantInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The plant code name. For example: "COTTONWOOD". A list of all available codes could be found here.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>A human readable representation of the plant name. Example: “Cottonwood".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Indication of either the plant is in season or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inSeason")]
        public virtual System.Nullable<bool> InSeason { get; set; }

        /// <summary>
        /// This object contains data representing specific pollen index value, category and description.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexInfo")]
        public virtual IndexInfo IndexInfo { get; set; }

        /// <summary>
        /// Contains general information about plants, including details on their seasonality, special shapes and
        /// colors, information about allergic cross-reactions, and plant photos.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plantDescription")]
        public virtual PlantDescription PlantDescription { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This object contains the pollen type index and health recommendation information on specific pollen type.
    /// </summary>
    public class PollenTypeInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The pollen type's code name. For example: "GRASS"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>A human readable representation of the pollen type name. Example: "Grass"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Textual list of explanations, related to health insights based on the current pollen levels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthRecommendations")]
        public virtual System.Collections.Generic.IList<string> HealthRecommendations { get; set; }

        /// <summary>Indication whether the plant is in season or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inSeason")]
        public virtual System.Nullable<bool> InSeason { get; set; }

        /// <summary>Contains the Universal Pollen Index (UPI) data for the pollen type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexInfo")]
        public virtual IndexInfo IndexInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
