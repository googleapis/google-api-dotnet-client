// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.PlayableLocations.v3
{
    /// <summary>The PlayableLocations Service.</summary>
    public class PlayableLocationsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v3";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public PlayableLocationsService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public PlayableLocationsService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            V3 = new V3Resource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "playablelocations";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://playablelocations.googleapis.com/";
        #else
            "https://playablelocations.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://playablelocations.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif





        /// <summary>Gets the V3 resource.</summary>
        public virtual V3Resource V3 { get; }
    }

    /// <summary>A base abstract class for PlayableLocations requests.</summary>
    public abstract class PlayableLocationsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new PlayableLocationsBaseServiceRequest instance.</summary>
        protected PlayableLocationsBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes PlayableLocations parameter list.</summary>
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


        /// <summary>Logs new events when playable locations are displayed, and when they are interacted with.
        /// Impressions are not partially saved; either all impressions are saved and this request succeeds, or no
        /// impressions are saved, and this request fails.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual LogImpressionsRequest LogImpressions(Google.Apis.PlayableLocations.v3.Data.GoogleMapsPlayablelocationsV3LogImpressionsRequest body)
        {
            return new LogImpressionsRequest(service, body);
        }

        /// <summary>Logs new events when playable locations are displayed, and when they are interacted with.
        /// Impressions are not partially saved; either all impressions are saved and this request succeeds, or no
        /// impressions are saved, and this request fails.</summary>
        public class LogImpressionsRequest : PlayableLocationsBaseServiceRequest<Google.Apis.PlayableLocations.v3.Data.GoogleMapsPlayablelocationsV3LogImpressionsResponse>
        {
            /// <summary>Constructs a new LogImpressions request.</summary>
            public LogImpressionsRequest(Google.Apis.Services.IClientService service, Google.Apis.PlayableLocations.v3.Data.GoogleMapsPlayablelocationsV3LogImpressionsRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.PlayableLocations.v3.Data.GoogleMapsPlayablelocationsV3LogImpressionsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "logImpressions";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3:logImpressions";

            /// <summary>Initializes LogImpressions parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Logs bad playable location reports submitted by players. Reports are not partially saved; either
        /// all reports are saved and this request succeeds, or no reports are saved, and this request fails.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual LogPlayerReportsRequest LogPlayerReports(Google.Apis.PlayableLocations.v3.Data.GoogleMapsPlayablelocationsV3LogPlayerReportsRequest body)
        {
            return new LogPlayerReportsRequest(service, body);
        }

        /// <summary>Logs bad playable location reports submitted by players. Reports are not partially saved; either
        /// all reports are saved and this request succeeds, or no reports are saved, and this request fails.</summary>
        public class LogPlayerReportsRequest : PlayableLocationsBaseServiceRequest<Google.Apis.PlayableLocations.v3.Data.GoogleMapsPlayablelocationsV3LogPlayerReportsResponse>
        {
            /// <summary>Constructs a new LogPlayerReports request.</summary>
            public LogPlayerReportsRequest(Google.Apis.Services.IClientService service, Google.Apis.PlayableLocations.v3.Data.GoogleMapsPlayablelocationsV3LogPlayerReportsRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.PlayableLocations.v3.Data.GoogleMapsPlayablelocationsV3LogPlayerReportsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "logPlayerReports";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3:logPlayerReports";

            /// <summary>Initializes LogPlayerReports parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Returns a set of playable locations that lie within a specified area, that satisfy optional filter
        /// criteria. Note: Identical `SamplePlayableLocations` requests can return different results as the state of
        /// the world changes over time.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual SamplePlayableLocationsRequest SamplePlayableLocations(Google.Apis.PlayableLocations.v3.Data.GoogleMapsPlayablelocationsV3SamplePlayableLocationsRequest body)
        {
            return new SamplePlayableLocationsRequest(service, body);
        }

        /// <summary>Returns a set of playable locations that lie within a specified area, that satisfy optional filter
        /// criteria. Note: Identical `SamplePlayableLocations` requests can return different results as the state of
        /// the world changes over time.</summary>
        public class SamplePlayableLocationsRequest : PlayableLocationsBaseServiceRequest<Google.Apis.PlayableLocations.v3.Data.GoogleMapsPlayablelocationsV3SamplePlayableLocationsResponse>
        {
            /// <summary>Constructs a new SamplePlayableLocations request.</summary>
            public SamplePlayableLocationsRequest(Google.Apis.Services.IClientService service, Google.Apis.PlayableLocations.v3.Data.GoogleMapsPlayablelocationsV3SamplePlayableLocationsRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.PlayableLocations.v3.Data.GoogleMapsPlayablelocationsV3SamplePlayableLocationsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "samplePlayableLocations";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3:samplePlayableLocations";

            /// <summary>Initializes SamplePlayableLocations parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }
    }
}

namespace Google.Apis.PlayableLocations.v3.Data
{    

    /// <summary>Encapsulates impression event details.</summary>
    public class GoogleMapsPlayablelocationsV3Impression : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An arbitrary, developer-defined type identifier for each type of game object used in your game.
        /// Since players interact with differ types of game objects in different ways, this field allows you to
        /// segregate impression data by type for analysis. You should assign a unique `game_object_type` ID to
        /// represent a distinct type of game object in your game. For example, 1=monster location, 2=powerup
        /// location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gameObjectType")]
        public virtual System.Nullable<int> GameObjectType { get; set; }

        /// <summary>Required. The type of impression event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("impressionType")]
        public virtual string ImpressionType { get; set; }

        /// <summary>Required. The name of the playable location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationName")]
        public virtual string LocationName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A request for logging impressions.</summary>
    public class GoogleMapsPlayablelocationsV3LogImpressionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Information about the client device. For example, device model and operating
        /// system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientInfo")]
        public virtual GoogleMapsUnityClientInfo ClientInfo { get; set; }

        /// <summary>Required. Impression event details. The maximum number of impression reports that you can log at
        /// once is 50.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("impressions")]
        public virtual System.Collections.Generic.IList<GoogleMapsPlayablelocationsV3Impression> Impressions { get; set; }

        /// <summary>Required. A string that uniquely identifies the log impressions request. This allows you to detect
        /// duplicate requests. We recommend that you use UUIDs for this value. The value must not exceed 50 characters.
        /// You should reuse the `request_id` only when retrying a request in case of failure. In this case, the request
        /// must be identical to the one that failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A response for the LogImpressions method. This method returns no data upon success.</summary>
    public class GoogleMapsPlayablelocationsV3LogImpressionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A request for logging your player's bad location reports.</summary>
    public class GoogleMapsPlayablelocationsV3LogPlayerReportsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Information about the client device (for example, device model and operating
        /// system).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientInfo")]
        public virtual GoogleMapsUnityClientInfo ClientInfo { get; set; }

        /// <summary>Required. Player reports. The maximum number of player reports that you can log at once is
        /// 50.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("playerReports")]
        public virtual System.Collections.Generic.IList<GoogleMapsPlayablelocationsV3PlayerReport> PlayerReports { get; set; }

        /// <summary>Required. A string that uniquely identifies the log player reports request. This allows you to
        /// detect duplicate requests. We recommend that you use UUIDs for this value. The value must not exceed 50
        /// characters. You should reuse the `request_id` only when retrying a request in the case of a failure. In that
        /// case, the request must be identical to the one that failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A response for the LogPlayerReports method. This method returns no data upon success.</summary>
    public class GoogleMapsPlayablelocationsV3LogPlayerReportsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A report submitted by a player about a playable location that is considered inappropriate for use in
    /// the game.</summary>
    public class GoogleMapsPlayablelocationsV3PlayerReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Language code (in BCP-47 format) indicating the language of the freeform description provided in
        /// `reason_details`. Examples are "en", "en-US" or "ja-Latn". For more information, see
        /// http://www.unicode.org/reports/tr35/#Unicode_locale_identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>Required. The name of the playable location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationName")]
        public virtual string LocationName { get; set; }

        /// <summary>Required. A free-form description detailing why the playable location is considered bad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reasonDetails")]
        public virtual string ReasonDetails { get; set; }

        /// <summary>Required. One or more reasons why this playable location is considered bad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reasons")]
        public virtual System.Collections.Generic.IList<string> Reasons { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Specifies the area to search for playable locations.</summary>
    public class GoogleMapsPlayablelocationsV3SampleAreaFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The S2 cell ID of the area you want. This must be between cell level 11 and 14
        /// (inclusive). S2 cells are 64-bit integers that identify areas on the Earth. They are hierarchical, and can
        /// therefore be used for spatial indexing. The S2 geometry library is available in a number of languages: *
        /// [C++](https://github.com/google/s2geometry) * [Java](https://github.com/google/s2-geometry-library-java) *
        /// [Go](https://github.com/golang/geo) *
        /// [Python](https://github.com/google/s2geometry/tree/master/src/python)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("s2CellId")]
        public virtual System.Nullable<ulong> S2CellId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Encapsulates a filter criterion for searching for a set of playable locations.</summary>
    public class GoogleMapsPlayablelocationsV3SampleCriterion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies which `PlayableLocation` fields are returned. `name` (which is used for logging
        /// impressions), `center_point` and `place_id` (or `plus_code`) are always returned. The following fields are
        /// omitted unless you specify them here: * snapped_point * types Note: The more fields you include, the more
        /// expensive in terms of data and associated latency your query will be.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldsToReturn")]
        public virtual object FieldsToReturn { get; set; }

        /// <summary>Specifies filtering options, and specifies what will be included in the result set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual GoogleMapsPlayablelocationsV3SampleFilter Filter { get; set; }

        /// <summary>Required. An arbitrary, developer-defined identifier of the type of game object that the playable
        /// location is used for. This field allows you to specify criteria per game object type when searching for
        /// playable locations. You should assign a unique `game_object_type` ID across all `request_criteria` to
        /// represent a distinct type of game object. For example, 1=monster location, 2=powerup location. The response
        /// contains a map.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gameObjectType")]
        public virtual System.Nullable<int> GameObjectType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Specifies the filters to use when searching for playable locations.</summary>
    public class GoogleMapsPlayablelocationsV3SampleFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Restricts the set of playable locations to just the [types](/maps/documentation/gaming/tt/types)
        /// that you want.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedTypes")]
        public virtual System.Collections.Generic.IList<string> IncludedTypes { get; set; }

        /// <summary>Specifies the maximum number of playable locations to return. This value must not be greater than
        /// 1000. The default value is 100. Only the top-ranking playable locations are returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxLocationCount")]
        public virtual System.Nullable<int> MaxLocationCount { get; set; }

        /// <summary>A set of options that control the spacing between playable locations. By default the minimum
        /// distance between locations is 200m.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spacing")]
        public virtual GoogleMapsPlayablelocationsV3SampleSpacingOptions Spacing { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A geographical point suitable for placing game objects in location-based games.</summary>
    public class GoogleMapsPlayablelocationsV3SamplePlayableLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The latitude and longitude associated with the center of the playable location. By
        /// default, the set of playable locations returned from SamplePlayableLocations use center-point
        /// coordinates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("centerPoint")]
        public virtual GoogleTypeLatLng CenterPoint { get; set; }

        /// <summary>Required. The name of this playable location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>A [place ID] (https://developers.google.com/places/place-id)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placeId")]
        public virtual string PlaceId { get; set; }

        /// <summary>A [plus code] (http://openlocationcode.com)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plusCode")]
        public virtual string PlusCode { get; set; }

        /// <summary>The playable location's coordinates, snapped to the sidewalk of the nearest road, if a nearby road
        /// exists.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snappedPoint")]
        public virtual GoogleTypeLatLng SnappedPoint { get; set; }

        /// <summary>A collection of [Playable Location Types](/maps/documentation/gaming/tt/types) for this playable
        /// location. The first type in the collection is the primary type. Type information might not be available for
        /// all playable locations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("types")]
        public virtual System.Collections.Generic.IList<string> Types { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A list of PlayableLocation objects that satisfies a single Criterion.</summary>
    public class GoogleMapsPlayablelocationsV3SamplePlayableLocationList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of playable locations for this game object type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<GoogleMapsPlayablelocationsV3SamplePlayableLocation> Locations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary> Life of a query: - When a game starts in a new location, your game server issues a
    /// SamplePlayableLocations request. The request specifies the S2 cell, and contains one or more "criteria" for
    /// filtering: - Criterion 0: i locations for long-lived bases, or level 0 monsters, or... - Criterion 1: j
    /// locations for short-lived bases, or level 1 monsters, ... - Criterion 2: k locations for random objects. - etc
    /// (up to 5 criterion may be specified). `PlayableLocationList` will then contain mutually exclusive lists of
    /// `PlayableLocation` objects that satisfy each of the criteria. Think of it as a collection of real-world
    /// locations that you can then associate with your game state. Note: These points are impermanent in nature. E.g,
    /// parks can close, and places can be removed. The response specifies how long you can expect the playable
    /// locations to last. Once they expire, you should query the `samplePlayableLocations` API again to get a fresh
    /// view of the real world.</summary>
    public class GoogleMapsPlayablelocationsV3SamplePlayableLocationsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Specifies the area to search within for playable locations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("areaFilter")]
        public virtual GoogleMapsPlayablelocationsV3SampleAreaFilter AreaFilter { get; set; }

        /// <summary>Required. Specifies one or more (up to 5) criteria for filtering the returned playable
        /// locations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("criteria")]
        public virtual System.Collections.Generic.IList<GoogleMapsPlayablelocationsV3SampleCriterion> Criteria { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary> Response for the SamplePlayableLocations method.</summary>
    public class GoogleMapsPlayablelocationsV3SamplePlayableLocationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Each PlayableLocation object corresponds to a game_object_type specified in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationsPerGameObjectType")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleMapsPlayablelocationsV3SamplePlayableLocationList> LocationsPerGameObjectType { get; set; }

        /// <summary>Required. Specifies the "time-to-live" for the set of playable locations. You can use this value to
        /// determine how long to cache the set of playable locations. After this length of time, your back-end game
        /// server should issue a new SamplePlayableLocations request to get a fresh set of playable locations (because
        /// for example, they might have been removed, a park might have closed for the day, a business might have
        /// closed permanently).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ttl")]
        public virtual object Ttl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A set of options that specifies the separation between playable locations.</summary>
    public class GoogleMapsPlayablelocationsV3SampleSpacingOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The minimum spacing between any two playable locations, measured in meters. The minimum
        /// value is 30. The maximum value is 1000. Inputs will be rounded up to the next 10 meter interval. The default
        /// value is 200m. Set this field to remove tight clusters of playable locations. Note: The spacing is a greedy
        /// algorithm. It optimizes for selecting the highest ranking locations first, not to maximize the number of
        /// locations selected. Consider the following scenario: * Rank: A: 2, B: 1, C: 3. * Distance: A--200m--B--200m
        /// --C If spacing=250, it will pick the highest ranked location [B], not [A, C]. Note: Spacing works within the
        /// game object type itself, as well as the previous ones. Suppose three game object types, each with the
        /// following spacing: * X: 400m, Y: undefined, Z: 200m. 1. Add locations for X, within 400m of each other. 2.
        /// Add locations for Y, without any spacing. 3. Finally, add locations for Z within 200m of each other as well
        /// X and Y. The distance diagram between those locations end up as: * From->To. * X->X: 400m * Y->X, Y->Y:
        /// unspecified. * Z->X, Z->Y, Z->Z: 200m.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minSpacingMeters")]
        public virtual System.Nullable<double> MinSpacingMeters { get; set; }

        /// <summary>Specifies whether the minimum spacing constraint applies to the center-point or to the snapped
        /// point of playable locations. The default value is `CENTER_POINT`. If a snapped point is not available for a
        /// playable location, its center-point is used instead. Set this to the point type used in your game.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pointType")]
        public virtual string PointType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Client information.</summary>
    public class GoogleMapsUnityClientInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>API client name and version. For example, the SDK calling the API. The exact format is up to the
        /// client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiClient")]
        public virtual string ApiClient { get; set; }

        /// <summary>Application ID, such as the package name on Android and the bundle identifier on iOS
        /// platforms.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicationId")]
        public virtual string ApplicationId { get; set; }

        /// <summary>Application version number, such as "1.2.3". The exact format is application-dependent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicationVersion")]
        public virtual string ApplicationVersion { get; set; }

        /// <summary>Device model as reported by the device. The exact format is platform-dependent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceModel")]
        public virtual string DeviceModel { get; set; }

        /// <summary>Language code (in BCP-47 format) indicating the UI language of the client. Examples are "en", "en-
        /// US" or "ja-Latn". For more information, see
        /// http://www.unicode.org/reports/tr35/#Unicode_locale_identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>Operating system name and version as reported by the OS. For example, "Mac OS X 10.10.4". The exact
        /// format is platform-dependent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatingSystem")]
        public virtual string OperatingSystem { get; set; }

        /// <summary>Build number/version of the operating system. e.g., the contents of android.os.Build.ID in Android,
        /// or the contents of sysctl "kern.osversion" in iOS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatingSystemBuild")]
        public virtual string OperatingSystemBuild { get; set; }

        /// <summary>Platform where the application is running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platform")]
        public virtual string Platform { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An object representing a latitude/longitude pair. This is expressed as a pair of doubles representing
    /// degrees latitude and degrees longitude. Unless specified otherwise, this must conform to the WGS84 standard.
    /// Values must be within normalized ranges.</summary>
    public class GoogleTypeLatLng : Google.Apis.Requests.IDirectResponseSchema
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
}
