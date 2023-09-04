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

namespace Google.Apis.MapsPlaces.v1
{
    /// <summary>The MapsPlaces Service.</summary>
    public class MapsPlacesService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public MapsPlacesService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public MapsPlacesService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Text = new TextResource(this);
            Places = new PlacesResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "places";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri => BaseUriOverride ?? "https://places.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://places.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Places API (New).</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>Private Service: https://www.googleapis.com/auth/maps-platform.places</summary>
            public static string MapsPlatformPlaces = "https://www.googleapis.com/auth/maps-platform.places";

            /// <summary>Private Service: https://www.googleapis.com/auth/maps-platform.places.textsearch</summary>
            public static string MapsPlatformPlacesTextsearch = "https://www.googleapis.com/auth/maps-platform.places.textsearch";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Places API (New).</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>Private Service: https://www.googleapis.com/auth/maps-platform.places</summary>
            public const string MapsPlatformPlaces = "https://www.googleapis.com/auth/maps-platform.places";

            /// <summary>Private Service: https://www.googleapis.com/auth/maps-platform.places.textsearch</summary>
            public const string MapsPlatformPlacesTextsearch = "https://www.googleapis.com/auth/maps-platform.places.textsearch";
        }

        /// <summary>Gets the Text resource.</summary>
        public virtual TextResource Text { get; }

        /// <summary>Gets the Places resource.</summary>
        public virtual PlacesResource Places { get; }
    }

    /// <summary>A base abstract class for MapsPlaces requests.</summary>
    public abstract class MapsPlacesBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new MapsPlacesBaseServiceRequest instance.</summary>
        protected MapsPlacesBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes MapsPlaces parameter list.</summary>
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

    /// <summary>The "Text" collection of methods.</summary>
    public class TextResource
    {
        private const string Resource = "text";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public TextResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Text query based place search.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual SearchRequest Search(Google.Apis.MapsPlaces.v1.Data.GoogleMapsPlacesV1SearchTextRequest body)
        {
            return new SearchRequest(service, body);
        }

        /// <summary>Text query based place search.</summary>
        public class SearchRequest : MapsPlacesBaseServiceRequest<Google.Apis.MapsPlaces.v1.Data.GoogleMapsPlacesV1SearchTextResponse>
        {
            /// <summary>Constructs a new Search request.</summary>
            public SearchRequest(Google.Apis.Services.IClientService service, Google.Apis.MapsPlaces.v1.Data.GoogleMapsPlacesV1SearchTextRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.MapsPlaces.v1.Data.GoogleMapsPlacesV1SearchTextRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "search";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/Text:search";

            /// <summary>Initializes Search parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "places" collection of methods.</summary>
    public class PlacesResource
    {
        private const string Resource = "places";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PlacesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Text query based place search.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual SearchTextRequest SearchText(Google.Apis.MapsPlaces.v1.Data.GoogleMapsPlacesV1SearchTextRequest body)
        {
            return new SearchTextRequest(service, body);
        }

        /// <summary>Text query based place search.</summary>
        public class SearchTextRequest : MapsPlacesBaseServiceRequest<Google.Apis.MapsPlaces.v1.Data.GoogleMapsPlacesV1SearchTextResponse>
        {
            /// <summary>Constructs a new SearchText request.</summary>
            public SearchTextRequest(Google.Apis.Services.IClientService service, Google.Apis.MapsPlaces.v1.Data.GoogleMapsPlacesV1SearchTextRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.MapsPlaces.v1.Data.GoogleMapsPlacesV1SearchTextRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "searchText";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/places:searchText";

            /// <summary>Initializes SearchText parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }
}
namespace Google.Apis.MapsPlaces.v1.Data
{
    /// <summary>
    /// A latitude-longitude viewport, represented as two diagonally opposite `low` and `high` points. A viewport is
    /// considered a closed region, i.e. it includes its boundary. The latitude bounds must range between -90 to 90
    /// degrees inclusive, and the longitude bounds must range between -180 to 180 degrees inclusive. Various cases
    /// include: - If `low` = `high`, the viewport consists of that single point. - If `low.longitude` &amp;gt;
    /// `high.longitude`, the longitude range is inverted (the viewport crosses the 180 degree longitude line). - If
    /// `low.longitude` = -180 degrees and `high.longitude` = 180 degrees, the viewport includes all longitudes. - If
    /// `low.longitude` = 180 degrees and `high.longitude` = -180 degrees, the longitude range is empty. - If
    /// `low.latitude` &amp;gt; `high.latitude`, the latitude range is empty. Both `low` and `high` must be populated,
    /// and the represented box cannot be empty (as specified by the definitions above). An empty viewport will result
    /// in an error. For example, this viewport fully encloses New York City: { "low": { "latitude": 40.477398,
    /// "longitude": -74.259087 }, "high": { "latitude": 40.91618, "longitude": -73.70018 } }
    /// </summary>
    public class GoogleGeoTypeViewport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The high point of the viewport.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("high")]
        public virtual GoogleTypeLatLng High { get; set; }

        /// <summary>Required. The low point of the viewport.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("low")]
        public virtual GoogleTypeLatLng Low { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the author of the UGC data. Used in Photo, and Review.</summary>
    public class GoogleMapsPlacesV1AuthorAttribution : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Name of the author of the Photo or Review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. Profile photo URI of the author of the Photo or Review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("photoUri")]
        public virtual string PhotoUri { get; set; }

        /// <summary>Output only. URI of the author of the Photo or Review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Circle with a LatLng as center and radius.</summary>
    public class GoogleMapsPlacesV1Circle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Center latitude and longitude. The range of latitude must be within [-90.0, 90.0]. The range of
        /// the longitude must be within [-180.0, 180.0].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("center")]
        public virtual GoogleTypeLatLng Center { get; set; }

        /// <summary>Required. Radius measured in meters. The radius must be within [0.0, 50000.0].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("radius")]
        public virtual System.Nullable<double> Radius { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>All the information representing a Place.</summary>
    public class GoogleMapsPlacesV1Place : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Repeated components for each locality level.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addressComponents")]
        public virtual System.Collections.Generic.IList<GoogleMapsPlacesV1PlaceAddressComponent> AddressComponents { get; set; }

        /// <summary>Output only. The place's address in adr microformat: http://microformats.org/wiki/adr.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adrFormatAddress")]
        public virtual string AdrFormatAddress { get; set; }

        /// <summary>Output only. A set of data provider that must be shown with this result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributions")]
        public virtual System.Collections.Generic.IList<GoogleMapsPlacesV1PlaceAttribution> Attributions { get; set; }

        /// <summary>Output only. The business status for the place.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("businessStatus")]
        public virtual string BusinessStatus { get; set; }

        /// <summary>Output only. Specifies if the business supports curbside pickup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("curbsidePickup")]
        public virtual System.Nullable<bool> CurbsidePickup { get; set; }

        /// <summary>
        /// Output only. The hours of operation for the next seven days (including today). The time period starts at
        /// midnight on the date of the request and ends at 11:59 pm six days later. This field includes the
        /// special_days subfield of all hours, set for dates that have exceptional hours.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentOpeningHours")]
        public virtual GoogleMapsPlacesV1PlaceOpeningHours CurrentOpeningHours { get; set; }

        /// <summary>
        /// Output only. Contains an array of entries for the next seven days including information about secondary
        /// hours of a business. Secondary hours are different from a business's main hours. For example, a restaurant
        /// can specify drive through hours or delivery hours as its secondary hours. This field populates the type
        /// subfield, which draws from a predefined list of opening hours types (such as DRIVE_THROUGH, PICKUP, or
        /// TAKEOUT) based on the types of the place. This field includes the special_days subfield of all hours, set
        /// for dates that have exceptional hours.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentSecondaryOpeningHours")]
        public virtual System.Collections.Generic.IList<GoogleMapsPlacesV1PlaceOpeningHours> CurrentSecondaryOpeningHours { get; set; }

        /// <summary>Output only. Specifies if the business supports delivery.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delivery")]
        public virtual System.Nullable<bool> Delivery { get; set; }

        /// <summary>Output only. Specifies if the business supports indoor or outdoor seating options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dineIn")]
        public virtual System.Nullable<bool> DineIn { get; set; }

        /// <summary>
        /// Output only. The localized name of the place, suitable as a short human-readable description. For example,
        /// "Google Sydney", "Starbucks", "Pyrmont", etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual GoogleTypeLocalizedText DisplayName { get; set; }

        /// <summary>
        /// Output only. Contains a summary of the place. A summary is comprised of a textual overview, and also
        /// includes the language code for these if applicable. Summary text must be presented as-is and can not be
        /// modified or altered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("editorialSummary")]
        public virtual GoogleTypeLocalizedText EditorialSummary { get; set; }

        /// <summary>Output only. A full, human-readable address for this place.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedAddress")]
        public virtual string FormattedAddress { get; set; }

        /// <summary>Output only. A URL providing more information about this place.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleMapsUri")]
        public virtual string GoogleMapsUri { get; set; }

        /// <summary>Output only. Background color for icon_mask in hex format, e.g. #909CE1.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iconBackgroundColor")]
        public virtual string IconBackgroundColor { get; set; }

        /// <summary>
        /// Output only. A truncated URL to an v2 icon mask. User can access different icon type by appending type
        /// suffix to the end (eg, ".svg" or ".png").
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iconMaskBaseUri")]
        public virtual string IconMaskBaseUri { get; set; }

        /// <summary>Output only. The unique identifier of a place.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Output only. A human-readable phone number for the place, in international format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internationalPhoneNumber")]
        public virtual string InternationalPhoneNumber { get; set; }

        /// <summary>Output only. The position of this place.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual GoogleTypeLatLng Location { get; set; }

        /// <summary>
        /// Output only. An ID representing this place which may be used to look up this place again (a.k.a. the API
        /// "resource" name: places/).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. A human-readable phone number for the place, in national format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nationalPhoneNumber")]
        public virtual string NationalPhoneNumber { get; set; }

        /// <summary>Output only. The regular hours of operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openingHours")]
        public virtual GoogleMapsPlacesV1PlaceOpeningHours OpeningHours { get; set; }

        /// <summary>Output only. Plus code of the place location lat/long.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plusCode")]
        public virtual GoogleMapsPlacesV1PlacePlusCode PlusCode { get; set; }

        /// <summary>Output only. Price level of the place.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceLevel")]
        public virtual string PriceLevel { get; set; }

        /// <summary>Output only. A rating between 1.0 and 5.0, based on user reviews of this place.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rating")]
        public virtual System.Nullable<double> Rating { get; set; }

        /// <summary>Output only. Specifies if the place supports reservations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reservable")]
        public virtual System.Nullable<bool> Reservable { get; set; }

        /// <summary>Output only. List of reviews about this place.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reviews")]
        public virtual System.Collections.Generic.IList<GoogleMapsPlacesV1Review> Reviews { get; set; }

        /// <summary>
        /// Output only. Contains an array of entries for information about regular secondary hours of a business.
        /// Secondary hours are different from a business's main hours. For example, a restaurant can specify drive
        /// through hours or delivery hours as its secondary hours. This field populates the type subfield, which draws
        /// from a predefined list of opening hours types (such as DRIVE_THROUGH, PICKUP, or TAKEOUT) based on the types
        /// of the place.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondaryOpeningHours")]
        public virtual System.Collections.Generic.IList<GoogleMapsPlacesV1PlaceOpeningHours> SecondaryOpeningHours { get; set; }

        /// <summary>Output only. Specifies if the place serves beer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servesBeer")]
        public virtual System.Nullable<bool> ServesBeer { get; set; }

        /// <summary>Output only. Specifies if the place serves breakfast.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servesBreakfast")]
        public virtual System.Nullable<bool> ServesBreakfast { get; set; }

        /// <summary>Output only. Specifies if the place serves brunch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servesBrunch")]
        public virtual System.Nullable<bool> ServesBrunch { get; set; }

        /// <summary>Output only. Specifies if the place serves dinner.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servesDinner")]
        public virtual System.Nullable<bool> ServesDinner { get; set; }

        /// <summary>Output only. Specifies if the place serves lunch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servesLunch")]
        public virtual System.Nullable<bool> ServesLunch { get; set; }

        /// <summary>Output only. Specifies if the place serves vegetarian food.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servesVegetarianFood")]
        public virtual System.Nullable<bool> ServesVegetarianFood { get; set; }

        /// <summary>Output only. Specifies if the place serves wine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servesWine")]
        public virtual System.Nullable<bool> ServesWine { get; set; }

        /// <summary>Output only. Specifies if the business supports takeout.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("takeout")]
        public virtual System.Nullable<bool> Takeout { get; set; }

        /// <summary>Output only. A set of type tags for this result. For example, "political" and "locality".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("types")]
        public virtual System.Collections.Generic.IList<string> Types { get; set; }

        /// <summary>Output only. The total number of reviews (with or without text) for this place.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userRatingCount")]
        public virtual System.Nullable<int> UserRatingCount { get; set; }

        /// <summary>
        /// Output only. Number of minutes this place's timezone is currently offset from UTC. This is expressed in
        /// minutes to support timezones that are offset by fractions of an hour, e.g. X hours and 15 minutes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utcOffsetMinutes")]
        public virtual System.Nullable<int> UtcOffsetMinutes { get; set; }

        /// <summary>Output only. A viewport suitable for displaying the place on an average-sized map.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewport")]
        public virtual GoogleGeoTypeViewport Viewport { get; set; }

        /// <summary>
        /// Output only. The authoritative website for this place, e.g. a business' homepage. Note that for places that
        /// are part of a chain (e.g. an IKEA store), this will usually be the website for the individual store, not the
        /// overall chain.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("websiteUri")]
        public virtual string WebsiteUri { get; set; }

        /// <summary>Output only. Specifies if the place has an entrance that is wheelchair-accessible.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wheelchairAccessibleEntrance")]
        public virtual System.Nullable<bool> WheelchairAccessibleEntrance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The structured components that form the formatted address, if this information is available.</summary>
    public class GoogleMapsPlacesV1PlaceAddressComponent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The language used to format this components, in CLDR notation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// Output only. The full text description or name of the address component. For example, an address component
        /// for the country Australia may have a long_name of "Australia".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longText")]
        public virtual string LongText { get; set; }

        /// <summary>
        /// Output only. An abbreviated textual name for the address component, if available. For example, an address
        /// component for the country of Australia may have a short_name of "AU".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortText")]
        public virtual string ShortText { get; set; }

        /// <summary>Output only. An array indicating the type(s) of the address component.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("types")]
        public virtual System.Collections.Generic.IList<string> Types { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about data providers of this place.</summary>
    public class GoogleMapsPlacesV1PlaceAttribution : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Name of the Place's data provider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provider")]
        public virtual string Provider { get; set; }

        /// <summary>Output only. URI to the Place's data provider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("providerUri")]
        public virtual string ProviderUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about business hour of the place.</summary>
    public class GoogleMapsPlacesV1PlaceOpeningHours : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Is this place open right now? Always present unless we lack time-of-day or timezone data for
        /// these opening hours.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openNow")]
        public virtual System.Nullable<bool> OpenNow { get; set; }

        /// <summary>
        /// Output only. The periods that this place is open during the week. The periods are in chronological order,
        /// starting with Sunday in the place-local timezone. An empty (but not absent) value indicates a place that is
        /// never open, e.g. because it is closed temporarily for renovations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("periods")]
        public virtual System.Collections.Generic.IList<GoogleMapsPlacesV1PlaceOpeningHoursPeriod> Periods { get; set; }

        /// <summary>Output only. A type string used to identify the type of secondary hours.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondaryHoursType")]
        public virtual string SecondaryHoursType { get; set; }

        /// <summary>
        /// Output only. Structured information for special days that fall within the period that the returned opening
        /// hours cover. Special days are days that could impact the business hours of a place, e.g. Christmas day. Set
        /// for current_opening_hours and current_secondary_opening_hours if there are exceptional hours.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("specialDays")]
        public virtual System.Collections.Generic.IList<GoogleMapsPlacesV1PlaceOpeningHoursSpecialDay> SpecialDays { get; set; }

        /// <summary>
        /// Output only. Localized strings describing the opening hours of this place, one string for each day of the
        /// week. Will be empty if the hours are unknown or could not be converted to localized text. Example: "Sun:
        /// 18:00–06:00"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weekdayDescriptions")]
        public virtual System.Collections.Generic.IList<string> WeekdayDescriptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A period the place remains in open_now status.</summary>
    public class GoogleMapsPlacesV1PlaceOpeningHoursPeriod : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time that the place starts to be closed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("close")]
        public virtual GoogleMapsPlacesV1PlaceOpeningHoursPeriodPoint Close { get; set; }

        /// <summary>Output only. The time that the place starts to be open.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("open")]
        public virtual GoogleMapsPlacesV1PlaceOpeningHoursPeriodPoint Open { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Status changing points.</summary>
    public class GoogleMapsPlacesV1PlaceOpeningHoursPeriodPoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Date in the local timezone for the place.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual GoogleTypeDate Date { get; set; }

        /// <summary>
        /// Output only. A day of the week, as an integer in the range 0-6. 0 is Sunday, 1 is Monday, etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual System.Nullable<int> Day { get; set; }

        /// <summary>Output only. The hour in 2 digits. Ranges from 00 to 23.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hour")]
        public virtual System.Nullable<int> Hour { get; set; }

        /// <summary>Output only. The minute in 2 digits. Ranges from 00 to 59.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minute")]
        public virtual System.Nullable<int> Minute { get; set; }

        /// <summary>
        /// Output only. Whether or not this endpoint was truncated. Truncation occurs when the real hours are outside
        /// the times we are willing to return hours between, so we truncate the hours back to these boundaries. This
        /// ensures that at most 24 * 7 hours from midnight of the day of the request are returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("truncated")]
        public virtual System.Nullable<bool> Truncated { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Structured information for special days that fall within the period that the returned opening hours cover.
    /// Special days are days that could impact the business hours of a place, e.g. Christmas day.
    /// </summary>
    public class GoogleMapsPlacesV1PlaceOpeningHoursSpecialDay : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The date of this special day.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual GoogleTypeDate Date { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Plus code (http://plus.codes) is a location reference with two formats: global code defining a 14mx14m (1/8000th
    /// of a degree) or smaller rectangle, and compound code, replacing the prefix with a reference location.
    /// </summary>
    public class GoogleMapsPlacesV1PlacePlusCode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Place's compound code, such as "33GV+HQ, Ramberg, Norway", containing the suffix of the global
        /// code and replacing the prefix with a formatted name of a reference entity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compoundCode")]
        public virtual string CompoundCode { get; set; }

        /// <summary>
        /// Output only. Place's global (full) code, such as "9FWM33GV+HQ", representing an 1/8000 by 1/8000 degree area
        /// (~14 by 14 meters).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("globalCode")]
        public virtual string GlobalCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a review of a place.</summary>
    public class GoogleMapsPlacesV1Review : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. This review's author.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorAttribution")]
        public virtual GoogleMapsPlacesV1AuthorAttribution AuthorAttribution { get; set; }

        /// <summary>Output only. The review text in its original language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalText")]
        public virtual GoogleTypeLocalizedText OriginalText { get; set; }

        private string _publishTimeRaw;

        private object _publishTime;

        /// <summary>Output only. Timestamp for the review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishTime")]
        public virtual string PublishTimeRaw
        {
            get => _publishTimeRaw;
            set
            {
                _publishTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _publishTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="PublishTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use PublishTimeDateTimeOffset instead.")]
        public virtual object PublishTime
        {
            get => _publishTime;
            set
            {
                _publishTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _publishTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="PublishTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? PublishTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(PublishTimeRaw);
            set => PublishTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>Output only. A number between 1.0 and 5.0, a.k.a. the number of stars.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rating")]
        public virtual System.Nullable<double> Rating { get; set; }

        /// <summary>
        /// Output only. A string of formatted recent time, expressing the review time relative to the current time in a
        /// form appropriate for the language and country.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relativePublishTimeDescription")]
        public virtual string RelativePublishTimeDescription { get; set; }

        /// <summary>Output only. The localized text of the review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual GoogleTypeLocalizedText Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request proto for SearchText. </summary>
    public class GoogleMapsPlacesV1SearchTextRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The requested place type. Full list of types supported:
        /// https://developers.google.com/places/supported_types. Only support one included type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedType")]
        public virtual string IncludedType { get; set; }

        /// <summary>
        /// Place details will be displayed with the preferred language if available. If the language code is
        /// unspecified or unrecognized, place details of any language may be returned, with a preference for English if
        /// such details exist. Current list of supported languages:
        /// https://developers.google.com/maps/faq#languagesupport.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// The region to search. This location serves as a bias which means results around given location might be
        /// returned. Cannot be set along with location_restriction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationBias")]
        public virtual GoogleMapsPlacesV1SearchTextRequestLocationBias LocationBias { get; set; }

        /// <summary>
        /// The region to search. This location serves as a restriction which means results outside given location will
        /// not be returned. Cannot be set along with location_bias.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationRestriction")]
        public virtual GoogleMapsPlacesV1SearchTextRequestLocationRestriction LocationRestriction { get; set; }

        /// <summary>
        /// Maximum number of results to return. It must be between 1 and 20, inclusively. If the number is unset, it
        /// falls back to the upper limit. If the number is set to negative or exceeds the upper limit, an
        /// INVALID_ARGUMENT error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxResultCount")]
        public virtual System.Nullable<int> MaxResultCount { get; set; }

        /// <summary>
        /// Filter out results whose average user rating is strictly less than this limit. A valid value must be an
        /// float between 0 and 5 (inclusively) at a 0.5 cadence i.e. [0, 0.5, 1.0, ... , 5.0] inclusively. This is to
        /// keep parity with LocalRefinement_UserRating. The input rating will round up to the nearest 0.5(ceiling). For
        /// instance, a rating of 0.6 will eliminate all results with a less than 1.0 rating.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minRating")]
        public virtual System.Nullable<double> MinRating { get; set; }

        /// <summary>
        /// Used to restrict the search to places that are open at a specific time. open_now marks if a business is
        /// currently open.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openNow")]
        public virtual System.Nullable<bool> OpenNow { get; set; }

        /// <summary>
        /// Used to restrict the search to places that are marked as certain price levels. Users can choose any
        /// combinations of price levels. Default to select all price levels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceLevels")]
        public virtual System.Collections.Generic.IList<string> PriceLevels { get; set; }

        /// <summary>How results will be ranked in the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rankPreference")]
        public virtual string RankPreference { get; set; }

        /// <summary>
        /// The Unicode country/region code (CLDR) of the location where the request is coming from. This parameter is
        /// used to display the place details, like region-specific place name, if available. The parameter can affect
        /// results based on applicable law. For more information, see
        /// http://www.unicode.org/reports/tr35/#unicode_region_subtag. Note that 3-digit region codes are not currently
        /// supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>
        /// Used to set strict type filtering for included_type. If set to true, only results of the same type will be
        /// returned. Default to false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("strictTypeFiltering")]
        public virtual System.Nullable<bool> StrictTypeFiltering { get; set; }

        /// <summary>Required. The text query for textual search.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textQuery")]
        public virtual string TextQuery { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The region to search. This location serves as a bias which means results around given location might be
    /// returned.
    /// </summary>
    public class GoogleMapsPlacesV1SearchTextRequestLocationBias : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A circle defined by center point and radius.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("circle")]
        public virtual GoogleMapsPlacesV1Circle Circle { get; set; }

        /// <summary>A rectangle box defined by northeast and southwest corner.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rectangle")]
        public virtual GoogleGeoTypeViewport Rectangle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The region to search. This location serves as a restriction which means results outside given location will not
    /// be returned.
    /// </summary>
    public class GoogleMapsPlacesV1SearchTextRequestLocationRestriction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A rectangle box defined by northeast and southwest corner.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rectangle")]
        public virtual GoogleGeoTypeViewport Rectangle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response proto for SearchText. </summary>
    public class GoogleMapsPlacesV1SearchTextResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of places that meet the user's text search criteria.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("places")]
        public virtual System.Collections.Generic.IList<GoogleMapsPlacesV1Place> Places { get; set; }

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
    public class GoogleTypeDate : Google.Apis.Requests.IDirectResponseSchema
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
    /// An object that represents a latitude/longitude pair. This is expressed as a pair of doubles to represent degrees
    /// latitude and degrees longitude. Unless specified otherwise, this object must conform to the WGS84 standard.
    /// Values must be within normalized ranges.
    /// </summary>
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

    /// <summary>Localized variant of a text in a particular language.</summary>
    public class GoogleTypeLocalizedText : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The text's BCP-47 language code, such as "en-US" or "sr-Latn". For more information, see
        /// http://www.unicode.org/reports/tr35/#Unicode_locale_identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>Localized string in the language corresponding to `language_code' below.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
