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

namespace Google.Apis.Solar.v1
{
    /// <summary>The Solar Service.</summary>
    public class SolarService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public SolarService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public SolarService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            BuildingInsights = new BuildingInsightsResource(this);
            DataLayers = new DataLayersResource(this);
            GeoTiff = new GeoTiffResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://solar.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://solar.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "solar";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Solar API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Solar API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the BuildingInsights resource.</summary>
        public virtual BuildingInsightsResource BuildingInsights { get; }

        /// <summary>Gets the DataLayers resource.</summary>
        public virtual DataLayersResource DataLayers { get; }

        /// <summary>Gets the GeoTiff resource.</summary>
        public virtual GeoTiffResource GeoTiff { get; }
    }

    /// <summary>A base abstract class for Solar requests.</summary>
    public abstract class SolarBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new SolarBaseServiceRequest instance.</summary>
        protected SolarBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Solar parameter list.</summary>
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

    /// <summary>The "buildingInsights" collection of methods.</summary>
    public class BuildingInsightsResource
    {
        private const string Resource = "buildingInsights";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public BuildingInsightsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Locates the building whose centroid is closest to a query point. Returns an error with code `NOT_FOUND` if
        /// there are no buildings within approximately 50m of the query point.
        /// </summary>
        public virtual FindClosestRequest FindClosest()
        {
            return new FindClosestRequest(this.service);
        }

        /// <summary>
        /// Locates the building whose centroid is closest to a query point. Returns an error with code `NOT_FOUND` if
        /// there are no buildings within approximately 50m of the query point.
        /// </summary>
        public class FindClosestRequest : SolarBaseServiceRequest<Google.Apis.Solar.v1.Data.BuildingInsights>
        {
            /// <summary>Constructs a new FindClosest request.</summary>
            public FindClosestRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Optional. Specifies the pre-GA features to enable.</summary>
            /// <remarks>
            /// Use this property to set a single value for the parameter, or <see cref="ExperimentsList"/> to set
            /// multiple values. Do not set both properties.
            /// </remarks>
            [Google.Apis.Util.RequestParameterAttribute("experiments", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ExperimentsEnum> Experiments { get; set; }

            /// <summary>Optional. Specifies the pre-GA features to enable.</summary>
            /// <remarks>
            /// Use this property to set one or more values for the parameter. Do not set both this property and
            /// <see cref="Experiments"/>.
            /// </remarks>
            [Google.Apis.Util.RequestParameterAttribute("experiments", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<ExperimentsEnum> ExperimentsList { get; set; }

            /// <summary>Optional. Specifies the pre-GA features to enable.</summary>
            public enum ExperimentsEnum
            {
                /// <summary>No experiments are specified.</summary>
                [Google.Apis.Util.StringValueAttribute("EXPERIMENT_UNSPECIFIED")]
                EXPERIMENTUNSPECIFIED = 0,

                /// <summary>
                /// Expands the geographic region available for querying solar data. For more information, see [Expanded
                /// Coverage](https://developers.google.com/maps/documentation/solar/expanded-coverage).
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("EXPANDED_COVERAGE")]
                EXPANDEDCOVERAGE = 1,
            }

            /// <summary>The latitude in degrees. It must be in the range [-90.0, +90.0].</summary>
            [Google.Apis.Util.RequestParameterAttribute("location.latitude", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<double> LocationLatitude { get; set; }

            /// <summary>The longitude in degrees. It must be in the range [-180.0, +180.0].</summary>
            [Google.Apis.Util.RequestParameterAttribute("location.longitude", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<double> LocationLongitude { get; set; }

            /// <summary>
            /// Optional. The minimum quality level allowed in the results. No result with lower quality than this will
            /// be returned. Not specifying this is equivalent to restricting to HIGH quality only.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("requiredQuality", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<RequiredQualityEnum> RequiredQuality { get; set; }

            /// <summary>
            /// Optional. The minimum quality level allowed in the results. No result with lower quality than this will
            /// be returned. Not specifying this is equivalent to restricting to HIGH quality only.
            /// </summary>
            public enum RequiredQualityEnum
            {
                /// <summary>No quality is known.</summary>
                [Google.Apis.Util.StringValueAttribute("IMAGERY_QUALITY_UNSPECIFIED")]
                IMAGERYQUALITYUNSPECIFIED = 0,

                /// <summary>
                /// Solar data is derived from aerial imagery captured at low-altitude and processed at 0.1 m/pixel.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("HIGH")]
                HIGH = 1,

                /// <summary>
                /// Solar data is derived from enhanced aerial imagery captured at high-altitude and processed at 0.25
                /// m/pixel.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("MEDIUM")]
                MEDIUM = 2,

                /// <summary>Solar data is derived from enhanced satellite imagery processed at 0.25 m/pixel.</summary>
                [Google.Apis.Util.StringValueAttribute("LOW")]
                LOW = 3,

                /// <summary>
                /// Solar data is derived from enhanced satellite imagery processed at 0.25 m/pixel. **Note:** This enum
                /// is only available if `experiments=EXPANDED_COVERAGE` is set in the request. For more information,
                /// see [Expanded Coverage](https://developers.google.com/maps/documentation/solar/expanded-coverage).
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("BASE")]
                BASE__ = 4,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "findClosest";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/buildingInsights:findClosest";

            /// <summary>Initializes FindClosest parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("experiments", new Google.Apis.Discovery.Parameter
                {
                    Name = "experiments",
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
                RequestParameters.Add("requiredQuality", new Google.Apis.Discovery.Parameter
                {
                    Name = "requiredQuality",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "dataLayers" collection of methods.</summary>
    public class DataLayersResource
    {
        private const string Resource = "dataLayers";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public DataLayersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Gets solar information for a region surrounding a location. Returns an error with code `NOT_FOUND` if the
        /// location is outside the coverage area.
        /// </summary>
        public virtual GetRequest Get()
        {
            return new GetRequest(this.service);
        }

        /// <summary>
        /// Gets solar information for a region surrounding a location. Returns an error with code `NOT_FOUND` if the
        /// location is outside the coverage area.
        /// </summary>
        public class GetRequest : SolarBaseServiceRequest<Google.Apis.Solar.v1.Data.DataLayers>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional. Whether to require exact quality of the imagery. If set to false, the `required_quality` field
            /// is interpreted as the minimum required quality, such that HIGH quality imagery may be returned when
            /// `required_quality` is set to MEDIUM. If set to true, `required_quality` is interpreted as the exact
            /// required quality and only `MEDIUM` quality imagery is returned if `required_quality` is set to `MEDIUM`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("exactQualityRequired", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ExactQualityRequired { get; set; }

            /// <summary>Optional. Specifies the pre-GA experiments to enable.</summary>
            /// <remarks>
            /// Use this property to set a single value for the parameter, or <see cref="ExperimentsList"/> to set
            /// multiple values. Do not set both properties.
            /// </remarks>
            [Google.Apis.Util.RequestParameterAttribute("experiments", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ExperimentsEnum> Experiments { get; set; }

            /// <summary>Optional. Specifies the pre-GA experiments to enable.</summary>
            /// <remarks>
            /// Use this property to set one or more values for the parameter. Do not set both this property and
            /// <see cref="Experiments"/>.
            /// </remarks>
            [Google.Apis.Util.RequestParameterAttribute("experiments", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<ExperimentsEnum> ExperimentsList { get; set; }

            /// <summary>Optional. Specifies the pre-GA experiments to enable.</summary>
            public enum ExperimentsEnum
            {
                /// <summary>No experiments are specified.</summary>
                [Google.Apis.Util.StringValueAttribute("EXPERIMENT_UNSPECIFIED")]
                EXPERIMENTUNSPECIFIED = 0,

                /// <summary>
                /// Expands the geographic region available for querying solar data. For more information, see [Expanded
                /// Coverage](https://developers.google.com/maps/documentation/solar/expanded-coverage).
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("EXPANDED_COVERAGE")]
                EXPANDEDCOVERAGE = 1,
            }

            /// <summary>The latitude in degrees. It must be in the range [-90.0, +90.0].</summary>
            [Google.Apis.Util.RequestParameterAttribute("location.latitude", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<double> LocationLatitude { get; set; }

            /// <summary>The longitude in degrees. It must be in the range [-180.0, +180.0].</summary>
            [Google.Apis.Util.RequestParameterAttribute("location.longitude", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<double> LocationLongitude { get; set; }

            /// <summary>
            /// Optional. The minimum scale, in meters per pixel, of the data to return. Values of 0.1 (the default, if
            /// this field is not set explicitly), 0.25, 0.5, and 1.0 are supported. Imagery components whose normal
            /// resolution is less than `pixel_size_meters` will be returned at the resolution specified by
            /// `pixel_size_meters`; imagery components whose normal resolution is equal to or greater than
            /// `pixel_size_meters` will be returned at that normal resolution.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pixelSizeMeters", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<float> PixelSizeMeters { get; set; }

            /// <summary>
            /// Required. The radius, in meters, defining the region surrounding that centre point for which data should
            /// be returned. The limitations on this value are: * Any value up to 100m can always be specified. * Values
            /// over 100m can be specified, as long as `radius_meters` &amp;lt;= `pixel_size_meters * 1000`. * However,
            /// for values over 175m, the `DataLayerView` in the request must not include monthly flux or hourly shade.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("radiusMeters", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<float> RadiusMeters { get; set; }

            /// <summary>
            /// Optional. The minimum quality level allowed in the results. No result with lower quality than this will
            /// be returned. Not specifying this is equivalent to restricting to HIGH quality only.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("requiredQuality", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<RequiredQualityEnum> RequiredQuality { get; set; }

            /// <summary>
            /// Optional. The minimum quality level allowed in the results. No result with lower quality than this will
            /// be returned. Not specifying this is equivalent to restricting to HIGH quality only.
            /// </summary>
            public enum RequiredQualityEnum
            {
                /// <summary>No quality is known.</summary>
                [Google.Apis.Util.StringValueAttribute("IMAGERY_QUALITY_UNSPECIFIED")]
                IMAGERYQUALITYUNSPECIFIED = 0,

                /// <summary>
                /// Solar data is derived from aerial imagery captured at low-altitude and processed at 0.1 m/pixel.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("HIGH")]
                HIGH = 1,

                /// <summary>
                /// Solar data is derived from enhanced aerial imagery captured at high-altitude and processed at 0.25
                /// m/pixel.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("MEDIUM")]
                MEDIUM = 2,

                /// <summary>Solar data is derived from enhanced satellite imagery processed at 0.25 m/pixel.</summary>
                [Google.Apis.Util.StringValueAttribute("LOW")]
                LOW = 3,

                /// <summary>
                /// Solar data is derived from enhanced satellite imagery processed at 0.25 m/pixel. **Note:** This enum
                /// is only available if `experiments=EXPANDED_COVERAGE` is set in the request. For more information,
                /// see [Expanded Coverage](https://developers.google.com/maps/documentation/solar/expanded-coverage).
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("BASE")]
                BASE__ = 4,
            }

            /// <summary>Optional. The desired subset of the data to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewEnum> View { get; set; }

            /// <summary>Optional. The desired subset of the data to return.</summary>
            public enum ViewEnum
            {
                /// <summary>Equivalent to FULL.</summary>
                [Google.Apis.Util.StringValueAttribute("DATA_LAYER_VIEW_UNSPECIFIED")]
                DATALAYERVIEWUNSPECIFIED = 0,

                /// <summary>Get the DSM only.</summary>
                [Google.Apis.Util.StringValueAttribute("DSM_LAYER")]
                DSMLAYER = 1,

                /// <summary>Get the DSM, RGB, and mask.</summary>
                [Google.Apis.Util.StringValueAttribute("IMAGERY_LAYERS")]
                IMAGERYLAYERS = 2,

                /// <summary>Get the DSM, RGB, mask, and annual flux.</summary>
                [Google.Apis.Util.StringValueAttribute("IMAGERY_AND_ANNUAL_FLUX_LAYERS")]
                IMAGERYANDANNUALFLUXLAYERS = 3,

                /// <summary>Get the DSM, RGB, mask, annual flux, and monthly flux.</summary>
                [Google.Apis.Util.StringValueAttribute("IMAGERY_AND_ALL_FLUX_LAYERS")]
                IMAGERYANDALLFLUXLAYERS = 4,

                /// <summary>Get all data.</summary>
                [Google.Apis.Util.StringValueAttribute("FULL_LAYERS")]
                FULLLAYERS = 5,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/dataLayers:get";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("exactQualityRequired", new Google.Apis.Discovery.Parameter
                {
                    Name = "exactQualityRequired",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("experiments", new Google.Apis.Discovery.Parameter
                {
                    Name = "experiments",
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
                RequestParameters.Add("pixelSizeMeters", new Google.Apis.Discovery.Parameter
                {
                    Name = "pixelSizeMeters",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("radiusMeters", new Google.Apis.Discovery.Parameter
                {
                    Name = "radiusMeters",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("requiredQuality", new Google.Apis.Discovery.Parameter
                {
                    Name = "requiredQuality",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                {
                    Name = "view",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "geoTiff" collection of methods.</summary>
    public class GeoTiffResource
    {
        private const string Resource = "geoTiff";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public GeoTiffResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Returns an image by its ID.</summary>
        public virtual GetRequest Get()
        {
            return new GetRequest(this.service);
        }

        /// <summary>Returns an image by its ID.</summary>
        public class GetRequest : SolarBaseServiceRequest<Google.Apis.Solar.v1.Data.HttpBody>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Required. The ID of the asset being requested.</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Id { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/geoTiff:get";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.Solar.v1.Data
{
    /// <summary>
    /// Response message for `Solar.FindClosestBuildingInsights`. Information about the location, dimensions, and solar
    /// potential of a building.
    /// </summary>
    public class BuildingInsights : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Administrative area 1 (e.g., in the US, the state) that contains this building. For example, in the US, the
        /// abbreviation might be "MA" or "CA."
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("administrativeArea")]
        public virtual string AdministrativeArea { get; set; }

        /// <summary>The bounding box of the building.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingBox")]
        public virtual LatLngBox BoundingBox { get; set; }

        /// <summary>A point near the center of the building.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("center")]
        public virtual LatLng Center { get; set; }

        /// <summary>Date that the underlying imagery was acquired. This is approximate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageryDate")]
        public virtual Date ImageryDate { get; set; }

        /// <summary>When processing was completed on this imagery.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageryProcessedDate")]
        public virtual Date ImageryProcessedDate { get; set; }

        /// <summary>The quality of the imagery used to compute the data for this building.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageryQuality")]
        public virtual string ImageryQuality { get; set; }

        /// <summary>The resource name for the building, of the format `buildings/{place_id}`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Postal code (e.g., US zip code) this building is contained by.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCode")]
        public virtual string PostalCode { get; set; }

        /// <summary>Region code for the country (or region) this building is in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>Solar potential of the building.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("solarPotential")]
        public virtual SolarPotential SolarPotential { get; set; }

        /// <summary>Statistical area (e.g., US census tract) this building is in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statisticalArea")]
        public virtual string StatisticalArea { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Cost and benefit of an outright purchase of a particular configuration of solar panels with a particular
    /// electricity usage.
    /// </summary>
    public class CashPurchaseSavings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Initial cost before tax incentives: the amount that must be paid out-of-pocket. Contrast with
        /// `upfront_cost`, which is after tax incentives.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outOfPocketCost")]
        public virtual Money OutOfPocketCost { get; set; }

        /// <summary>
        /// Number of years until payback occurs. A negative value means payback never occurs within the lifetime
        /// period.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paybackYears")]
        public virtual System.Nullable<float> PaybackYears { get; set; }

        /// <summary>The value of all tax rebates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rebateValue")]
        public virtual Money RebateValue { get; set; }

        /// <summary>How much is saved (or not) over the lifetime period.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("savings")]
        public virtual SavingsOverTime Savings { get; set; }

        /// <summary>
        /// Initial cost after tax incentives: it's the amount that must be paid during first year. Contrast with
        /// `out_of_pocket_cost`, which is before tax incentives.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upfrontCost")]
        public virtual Money UpfrontCost { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information about the solar potential of a region. The actual data are contained in a number of GeoTIFF files
    /// covering the requested region, for which this message contains URLs: Each string in the `DataLayers` message
    /// contains a URL from which the corresponding GeoTIFF can be fetched. These URLs are valid for a few hours after
    /// they've been generated. Most of the GeoTIFF files are at a resolution of 0.1m/pixel, but the monthly flux file
    /// is at 0.5m/pixel, and the hourly shade files are at 1m/pixel. If a `pixel_size_meters` value was specified in
    /// the `GetDataLayersRequest`, then the minimum resolution in the GeoTIFF files will be that value.
    /// </summary>
    public class DataLayers : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The URL for the annual flux map (annual sunlight on roofs) of the region. Values are kWh/kW/year. This is
        /// *unmasked flux*: flux is computed for every location, not just building rooftops. Invalid locations are
        /// stored as -9999: locations outside our coverage area will be invalid, and a few locations inside the
        /// coverage area, where we were unable to calculate flux, will also be invalid.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annualFluxUrl")]
        public virtual string AnnualFluxUrl { get; set; }

        /// <summary>
        /// The URL for an image of the DSM (Digital Surface Model) of the region. Values are in meters above EGM96
        /// geoid (i.e., sea level). Invalid locations (where we don't have data) are stored as -9999.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dsmUrl")]
        public virtual string DsmUrl { get; set; }

        /// <summary>
        /// Twelve URLs for hourly shade, corresponding to January...December, in order. Each GeoTIFF will contain 24
        /// bands, corresponding to the 24 hours of the day. Each pixel is a 32 bit integer, corresponding to the (up
        /// to) 31 days of that month; a 1 bit means that the corresponding location is able to see the sun at that day,
        /// of that hour, of that month. Invalid locations are stored as -9999 (since this is negative, it has bit 31
        /// set, and no valid value could have bit 31 set as that would correspond to the 32nd day of the month). An
        /// example may be useful. If you want to know whether a point (at pixel location (x, y)) saw sun at 4pm on the
        /// 22nd of June you would: 1. fetch the sixth URL in this list (corresponding to June). 1. look up the 17th
        /// channel (corresponding to 4pm). 1. read the 32-bit value at (x, y). 1. read bit 21 of the value
        /// (corresponding to the 22nd of the month). 1. if that bit is a 1, then that spot saw the sun at 4pm 22 June.
        /// More formally: Given `month` (1-12), `day` (1...month max; February has 28 days) and `hour` (0-23), the
        /// shade/sun for that month/day/hour at a position `(x, y)` is the bit
        /// ```
        /// (hourly_shade[month - 1])(x,
        /// y)[hour] &amp;amp; (1 &amp;lt;&amp;lt; (day - 1))
        /// ```
        /// where `(x, y)` is spatial indexing, `[month - 1]`
        /// refers to fetching the `month - 1`st URL (indexing from zero), `[hour]` is indexing into the channels, and a
        /// final non-zero result means "sunny". There are no leap days, and DST doesn't exist (all days are 24 hours
        /// long; noon is always "standard time" noon).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hourlyShadeUrls")]
        public virtual System.Collections.Generic.IList<string> HourlyShadeUrls { get; set; }

        /// <summary>
        /// When the source imagery (from which all the other data are derived) in this region was taken. It is
        /// necessarily somewhat approximate, as the images may have been taken over more than one day.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageryDate")]
        public virtual Date ImageryDate { get; set; }

        /// <summary>When processing was completed on this imagery.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageryProcessedDate")]
        public virtual Date ImageryProcessedDate { get; set; }

        /// <summary>The quality of the result's imagery.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageryQuality")]
        public virtual string ImageryQuality { get; set; }

        /// <summary>
        /// The URL for the building mask image: one bit per pixel saying whether that pixel is considered to be part of
        /// a rooftop or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maskUrl")]
        public virtual string MaskUrl { get; set; }

        /// <summary>
        /// The URL for the monthly flux map (sunlight on roofs, broken down by month) of the region. Values are
        /// kWh/kW/year. The GeoTIFF pointed to by this URL will contain twelve bands, corresponding to
        /// January...December, in order.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monthlyFluxUrl")]
        public virtual string MonthlyFluxUrl { get; set; }

        /// <summary>The URL for an image of RGB data (aerial photo) of the region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rgbUrl")]
        public virtual string RgbUrl { get; set; }

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

    /// <summary>
    /// Cost and benefit of using a loan to buy a particular configuration of solar panels with a particular electricity
    /// usage.
    /// </summary>
    public class FinancedPurchaseSavings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Annual loan payments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annualLoanPayment")]
        public virtual Money AnnualLoanPayment { get; set; }

        /// <summary>The interest rate on loans assumed in this set of calculations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loanInterestRate")]
        public virtual System.Nullable<float> LoanInterestRate { get; set; }

        /// <summary>The value of all tax rebates (including Federal Investment Tax Credit (ITC)).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rebateValue")]
        public virtual Money RebateValue { get; set; }

        /// <summary>How much is saved (or not) over the lifetime period.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("savings")]
        public virtual SavingsOverTime Savings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Analysis of the cost and benefits of the optimum solar layout for a particular electric bill size.
    /// </summary>
    public class FinancialAnalysis : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// How much electricity the house uses in an average month, based on the bill size and the local electricity
        /// rates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("averageKwhPerMonth")]
        public virtual System.Nullable<float> AverageKwhPerMonth { get; set; }

        /// <summary>Cost and benefit of buying the solar panels with cash.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cashPurchaseSavings")]
        public virtual CashPurchaseSavings CashPurchaseSavings { get; set; }

        /// <summary>
        /// Whether this is the bill size selected to be the default bill for the area this building is in. Exactly one
        /// `FinancialAnalysis` in `BuildingSolarPotential` should have `default_bill` set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultBill")]
        public virtual System.Nullable<bool> DefaultBill { get; set; }

        /// <summary>Cost and benefit of buying the solar panels by financing the purchase.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("financedPurchaseSavings")]
        public virtual FinancedPurchaseSavings FinancedPurchaseSavings { get; set; }

        /// <summary>Financial information that applies regardless of the financing method used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("financialDetails")]
        public virtual FinancialDetails FinancialDetails { get; set; }

        /// <summary>Cost and benefit of leasing the solar panels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("leasingSavings")]
        public virtual LeasingSavings LeasingSavings { get; set; }

        /// <summary>The monthly electric bill this analysis assumes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monthlyBill")]
        public virtual Money MonthlyBill { get; set; }

        /// <summary>
        /// Index in solar_panel_configs of the optimum solar layout for this bill size. This can be -1 indicating that
        /// there is no layout. In this case, the remaining submessages will be omitted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("panelConfigIndex")]
        public virtual System.Nullable<int> PanelConfigIndex { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details of a financial analysis. Some of these details are already stored at higher levels (e.g., out of pocket
    /// cost). Total money amounts are over a lifetime period defined by the panel_lifetime_years field in
    /// SolarPotential. Note: The out of pocket cost of purchasing the panels is given in the out_of_pocket_cost field
    /// in CashPurchaseSavings.
    /// </summary>
    public class FinancialDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Total cost of electricity the user would have paid over the lifetime period if they didn't install solar.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("costOfElectricityWithoutSolar")]
        public virtual Money CostOfElectricityWithoutSolar { get; set; }

        /// <summary>
        /// Amount of money available from federal incentives; this applies if the user buys (with or without a loan)
        /// the panels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("federalIncentive")]
        public virtual Money FederalIncentive { get; set; }

        /// <summary>How many AC kWh we think the solar panels will generate in their first year.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initialAcKwhPerYear")]
        public virtual System.Nullable<float> InitialAcKwhPerYear { get; set; }

        /// <summary>
        /// Amount of money the user will receive from Solar Renewable Energy Credits over the panel lifetime; this
        /// applies if the user buys (with or without a loan) the panels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifetimeSrecTotal")]
        public virtual Money LifetimeSrecTotal { get; set; }

        /// <summary>Whether net metering is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("netMeteringAllowed")]
        public virtual System.Nullable<bool> NetMeteringAllowed { get; set; }

        /// <summary>
        /// The percentage (0-100) of solar electricity production we assumed was exported to the grid, based on the
        /// first quarter of production. This affects the calculations if net metering is not allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percentageExportedToGrid")]
        public virtual System.Nullable<float> PercentageExportedToGrid { get; set; }

        /// <summary>Utility bill for electricity not produced by solar, for the lifetime of the panels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remainingLifetimeUtilityBill")]
        public virtual Money RemainingLifetimeUtilityBill { get; set; }

        /// <summary>
        /// Percentage (0-100) of the user's power supplied by solar. Valid for the first year but approximately correct
        /// for future years.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("solarPercentage")]
        public virtual System.Nullable<float> SolarPercentage { get; set; }

        /// <summary>
        /// Amount of money available from state incentives; this applies if the user buys (with or without a loan) the
        /// panels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateIncentive")]
        public virtual Money StateIncentive { get; set; }

        /// <summary>
        /// Amount of money available from utility incentives; this applies if the user buys (with or without a loan)
        /// the panels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utilityIncentive")]
        public virtual Money UtilityIncentive { get; set; }

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

    /// <summary>A bounding box in lat/lng coordinates.</summary>
    public class LatLngBox : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The northeast corner of the box.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ne")]
        public virtual LatLng Ne { get; set; }

        /// <summary>The southwest corner of the box.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sw")]
        public virtual LatLng Sw { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Cost and benefit of leasing a particular configuration of solar panels with a particular electricity usage.
    /// </summary>
    public class LeasingSavings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Estimated annual leasing cost.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annualLeasingCost")]
        public virtual Money AnnualLeasingCost { get; set; }

        /// <summary>
        /// Whether leases are allowed in this juristiction (leases are not allowed in some states). If this field is
        /// false, then the values in this message should probably be ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("leasesAllowed")]
        public virtual System.Nullable<bool> LeasesAllowed { get; set; }

        /// <summary>
        /// Whether leases are supported in this juristiction by the financial calculation engine. If this field is
        /// false, then the values in this message should probably be ignored. This is independent of `leases_allowed`:
        /// in some areas leases are allowed, but under conditions that aren't handled by the financial models.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("leasesSupported")]
        public virtual System.Nullable<bool> LeasesSupported { get; set; }

        /// <summary>How much is saved (or not) over the lifetime period.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("savings")]
        public virtual SavingsOverTime Savings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an amount of money with its currency type.</summary>
    public class Money : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The three-letter currency code defined in ISO 4217.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>
        /// Number of nano (10^-9) units of the amount. The value must be between -999,999,999 and +999,999,999
        /// inclusive. If `units` is positive, `nanos` must be positive or zero. If `units` is zero, `nanos` can be
        /// positive, zero, or negative. If `units` is negative, `nanos` must be negative or zero. For example $-1.75 is
        /// represented as `units`=-1 and `nanos`=-750,000,000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>
        /// The whole units of the amount. For example if `currencyCode` is `"USD"`, then 1 unit is one US dollar.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("units")]
        public virtual System.Nullable<long> Units { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the size and sunniness quantiles of a roof segment.</summary>
    public class RoofSegmentSizeAndSunshineStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Compass direction the roof segment is pointing in. 0 = North, 90 = East, 180 = South. For a "flat" roof
        /// segment (`pitch_degrees` very near 0), azimuth is not well defined, so for consistency, we define it
        /// arbitrarily to be 0 (North).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("azimuthDegrees")]
        public virtual System.Nullable<float> AzimuthDegrees { get; set; }

        /// <summary>The bounding box of the roof segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingBox")]
        public virtual LatLngBox BoundingBox { get; set; }

        /// <summary>A point near the center of the roof segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("center")]
        public virtual LatLng Center { get; set; }

        /// <summary>
        /// Angle of the roof segment relative to the theoretical ground plane. 0 = parallel to the ground, 90 =
        /// perpendicular to the ground.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pitchDegrees")]
        public virtual System.Nullable<float> PitchDegrees { get; set; }

        /// <summary>
        /// The height of the roof segment plane, in meters above sea level, at the point designated by `center`.
        /// Together with the pitch, azimuth, and center location, this fully defines the roof segment plane.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("planeHeightAtCenterMeters")]
        public virtual System.Nullable<float> PlaneHeightAtCenterMeters { get; set; }

        /// <summary>Total size and sunlight quantiles for the roof segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stats")]
        public virtual SizeAndSunshineStats Stats { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a roof segment on the building, with some number of panels placed on it.</summary>
    public class RoofSegmentSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Compass direction the roof segment is pointing in. 0 = North, 90 = East, 180 = South. For a "flat" roof
        /// segment (`pitch_degrees` very near 0), azimuth is not well defined, so for consistency, we define it
        /// arbitrarily to be 0 (North).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("azimuthDegrees")]
        public virtual System.Nullable<float> AzimuthDegrees { get; set; }

        /// <summary>The total number of panels on this segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("panelsCount")]
        public virtual System.Nullable<int> PanelsCount { get; set; }

        /// <summary>
        /// Angle of the roof segment relative to the theoretical ground plane. 0 = parallel to the ground, 90 =
        /// perpendicular to the ground.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pitchDegrees")]
        public virtual System.Nullable<float> PitchDegrees { get; set; }

        /// <summary>Index in roof_segment_stats of the corresponding `RoofSegmentSizeAndSunshineStats`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segmentIndex")]
        public virtual System.Nullable<int> SegmentIndex { get; set; }

        /// <summary>
        /// How much sunlight energy this part of the layout captures over the course of a year, in DC kWh, assuming the
        /// panels described above.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yearlyEnergyDcKwh")]
        public virtual System.Nullable<float> YearlyEnergyDcKwh { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Financial information that's shared between different financing methods.</summary>
    public class SavingsOverTime : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Indicates whether this scenario is financially viable. Will be false for scenarios with poor financial
        /// viability (e.g., money-losing).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("financiallyViable")]
        public virtual System.Nullable<bool> FinanciallyViable { get; set; }

        /// <summary>
        /// Using the assumed discount rate, what is the present value of the cumulative lifetime savings?
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("presentValueOfSavingsLifetime")]
        public virtual Money PresentValueOfSavingsLifetime { get; set; }

        /// <summary>
        /// Using the assumed discount rate, what is the present value of the cumulative 20-year savings?
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("presentValueOfSavingsYear20")]
        public virtual Money PresentValueOfSavingsYear20 { get; set; }

        /// <summary>Savings in the entire panel lifetime.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("savingsLifetime")]
        public virtual Money SavingsLifetime { get; set; }

        /// <summary>Savings in the first year after panel installation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("savingsYear1")]
        public virtual Money SavingsYear1 { get; set; }

        /// <summary>Savings in the first twenty years after panel installation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("savingsYear20")]
        public virtual Money SavingsYear20 { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Size and sunniness quantiles of a roof, or part of a roof.</summary>
    public class SizeAndSunshineStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The area of the roof or roof segment, in m^2. This is the roof area (accounting for tilt), not the ground
        /// footprint area.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("areaMeters2")]
        public virtual System.Nullable<float> AreaMeters2 { get; set; }

        /// <summary>The ground footprint area covered by the roof or roof segment, in m^2.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groundAreaMeters2")]
        public virtual System.Nullable<float> GroundAreaMeters2 { get; set; }

        /// <summary>
        /// Quantiles of the pointwise sunniness across the area. If there are N values here, this represents the
        /// (N-1)-iles. For example, if there are 5 values, then they would be the quartiles (min, 25%, 50%, 75%, max).
        /// Values are in annual kWh/kW like max_sunshine_hours_per_year.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sunshineQuantiles")]
        public virtual System.Collections.Generic.IList<System.Nullable<float>> SunshineQuantiles { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// SolarPanel describes the position, orientation, and production of a single solar panel. See the
    /// panel_height_meters, panel_width_meters, and panel_capacity_watts fields in SolarPotential for information on
    /// the parameters of the panel.
    /// </summary>
    public class SolarPanel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The centre of the panel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("center")]
        public virtual LatLng Center { get; set; }

        /// <summary>The orientation of the panel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orientation")]
        public virtual string Orientation { get; set; }

        /// <summary>
        /// Index in roof_segment_stats of the `RoofSegmentSizeAndSunshineStats` which corresponds to the roof segment
        /// that this panel is placed on.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segmentIndex")]
        public virtual System.Nullable<int> SegmentIndex { get; set; }

        /// <summary>How much sunlight energy this layout captures over the course of a year, in DC kWh.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yearlyEnergyDcKwh")]
        public virtual System.Nullable<float> YearlyEnergyDcKwh { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SolarPanelConfig describes a particular placement of solar panels on the roof.</summary>
    public class SolarPanelConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Total number of panels. Note that this is redundant to (the sum of) the corresponding fields in
        /// roof_segment_summaries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("panelsCount")]
        public virtual System.Nullable<int> PanelsCount { get; set; }

        /// <summary>
        /// Information about the production of each roof segment that is carrying at least one panel in this layout.
        /// `roof_segment_summaries[i]` describes the i-th roof segment, including its size, expected production and
        /// orientation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roofSegmentSummaries")]
        public virtual System.Collections.Generic.IList<RoofSegmentSummary> RoofSegmentSummaries { get; set; }

        /// <summary>
        /// How much sunlight energy this layout captures over the course of a year, in DC kWh, assuming the panels
        /// described above.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yearlyEnergyDcKwh")]
        public virtual System.Nullable<float> YearlyEnergyDcKwh { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information about the solar potential of a building. A number of fields in this are defined in terms of
    /// "panels". The fields panel_capacity_watts, panel_height_meters, and panel_width_meters describe the parameters
    /// of the model of panel used in these calculations.
    /// </summary>
    public class SolarPotential : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Size and sunlight quantiles for the entire building, including parts of the roof that were not assigned to
        /// some roof segment. Because the orientations of these parts are not well characterised, the roof area
        /// estimate is unreliable, but the ground area estimate is reliable. It may be that a more reliable whole
        /// building roof area can be obtained by scaling the roof area from whole_roof_stats by the ratio of the ground
        /// areas of `building_stats` and `whole_roof_stats`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildingStats")]
        public virtual SizeAndSunshineStats BuildingStats { get; set; }

        /// <summary>
        /// Equivalent amount of CO2 produced per MWh of grid electricity. This is a measure of the carbon intensity of
        /// grid electricity displaced by solar electricity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("carbonOffsetFactorKgPerMwh")]
        public virtual System.Nullable<float> CarbonOffsetFactorKgPerMwh { get; set; }

        /// <summary>
        /// A FinancialAnalysis gives the savings from going solar assuming a given monthly bill and a given electricity
        /// provider. They are in order of increasing order of monthly bill amount. This field will be empty for
        /// buildings in areas for which the Solar API does not have enough information to perform financial
        /// computations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("financialAnalyses")]
        public virtual System.Collections.Generic.IList<FinancialAnalysis> FinancialAnalyses { get; set; }

        /// <summary>Size, in square meters, of the maximum array.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxArrayAreaMeters2")]
        public virtual System.Nullable<float> MaxArrayAreaMeters2 { get; set; }

        /// <summary>
        /// Size of the maximum array - that is, the maximum number of panels that can fit on the roof.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxArrayPanelsCount")]
        public virtual System.Nullable<int> MaxArrayPanelsCount { get; set; }

        /// <summary>
        /// Maximum number of sunshine hours received per year, by any point on the roof. Sunshine hours are a measure
        /// of the total amount of insolation (energy) received per year. 1 sunshine hour = 1 kWh per kW (where kW
        /// refers to kW of capacity under Standard Testing Conditions).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxSunshineHoursPerYear")]
        public virtual System.Nullable<float> MaxSunshineHoursPerYear { get; set; }

        /// <summary>Capacity, in watts, of the panel used in the calculations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("panelCapacityWatts")]
        public virtual System.Nullable<float> PanelCapacityWatts { get; set; }

        /// <summary>Height, in meters in portrait orientation, of the panel used in the calculations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("panelHeightMeters")]
        public virtual System.Nullable<float> PanelHeightMeters { get; set; }

        /// <summary>
        /// The expected lifetime, in years, of the solar panels. This is used in the financial calculations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("panelLifetimeYears")]
        public virtual System.Nullable<int> PanelLifetimeYears { get; set; }

        /// <summary>Width, in meters in portrait orientation, of the panel used in the calculations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("panelWidthMeters")]
        public virtual System.Nullable<float> PanelWidthMeters { get; set; }

        /// <summary>Size and sunlight quantiles for each roof segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roofSegmentStats")]
        public virtual System.Collections.Generic.IList<RoofSegmentSizeAndSunshineStats> RoofSegmentStats { get; set; }

        /// <summary>
        /// Each SolarPanelConfig describes a different arrangement of solar panels on the roof. They are in order of
        /// increasing number of panels. The `SolarPanelConfig` with panels_count=N is based on the first N panels in
        /// the `solar_panels` list. This field is only populated if at least 4 panels can fit on a roof.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("solarPanelConfigs")]
        public virtual System.Collections.Generic.IList<SolarPanelConfig> SolarPanelConfigs { get; set; }

        /// <summary>
        /// Each SolarPanel describes a single solar panel. They are listed in the order that the panel layout algorithm
        /// placed this. This is usually, though not always, in decreasing order of annual energy production.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("solarPanels")]
        public virtual System.Collections.Generic.IList<SolarPanel> SolarPanels { get; set; }

        /// <summary>
        /// Total size and sunlight quantiles for the part of the roof that was assigned to some roof segment. Despite
        /// the name, this may not include the entire building. See building_stats.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wholeRoofStats")]
        public virtual SizeAndSunshineStats WholeRoofStats { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
