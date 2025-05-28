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

namespace Google.Apis.AreaInsights.v1
{
    /// <summary>The AreaInsights Service.</summary>
    public class AreaInsightsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AreaInsightsService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AreaInsightsService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            V1 = new V1Resource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://areainsights.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://areainsights.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "areainsights";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Places Aggregate API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Places Aggregate API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the V1 resource.</summary>
        public virtual V1Resource V1 { get; }
    }

    /// <summary>A base abstract class for AreaInsights requests.</summary>
    public abstract class AreaInsightsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new AreaInsightsBaseServiceRequest instance.</summary>
        protected AreaInsightsBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes AreaInsights parameter list.</summary>
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

    /// <summary>The "v1" collection of methods.</summary>
    public class V1Resource
    {
        private const string Resource = "v1";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public V1Resource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// This method lets you retrieve insights about areas using a variety of filter such as: area, place type,
        /// operating status, price level and ratings. Currently "count" and "places" insights are supported. With
        /// "count" insights you can answer questions such as "How many restaurant are located in California that are
        /// operational, are inexpensive and have an average rating of at least 4 stars" (see `insight` enum for more
        /// details). With "places" insights, you can determine which places match the requested filter. Clients can
        /// then use those place resource names to fetch more details about each individual place using the Places API.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual ComputeInsightsRequest ComputeInsights(Google.Apis.AreaInsights.v1.Data.ComputeInsightsRequest body)
        {
            return new ComputeInsightsRequest(this.service, body);
        }

        /// <summary>
        /// This method lets you retrieve insights about areas using a variety of filter such as: area, place type,
        /// operating status, price level and ratings. Currently "count" and "places" insights are supported. With
        /// "count" insights you can answer questions such as "How many restaurant are located in California that are
        /// operational, are inexpensive and have an average rating of at least 4 stars" (see `insight` enum for more
        /// details). With "places" insights, you can determine which places match the requested filter. Clients can
        /// then use those place resource names to fetch more details about each individual place using the Places API.
        /// </summary>
        public class ComputeInsightsRequest : AreaInsightsBaseServiceRequest<Google.Apis.AreaInsights.v1.Data.ComputeInsightsResponse>
        {
            /// <summary>Constructs a new ComputeInsights request.</summary>
            public ComputeInsightsRequest(Google.Apis.Services.IClientService service, Google.Apis.AreaInsights.v1.Data.ComputeInsightsRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AreaInsights.v1.Data.ComputeInsightsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "computeInsights";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1:computeInsights";

            /// <summary>Initializes ComputeInsights parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }
}
namespace Google.Apis.AreaInsights.v1.Data
{
    /// <summary>A circle is defined by a center point and radius in meters.</summary>
    public class Circle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The latitude and longitude of the center of the circle.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latLng")]
        public virtual LatLng LatLng { get; set; }

        /// <summary>
        /// **Format:** Must be in the format `places/PLACE_ID`, where `PLACE_ID` is the unique identifier of a place.
        /// For example: `places/ChIJgUbEo8cfqokR5lP9_Wh_DaM`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("place")]
        public virtual string Place { get; set; }

        /// <summary>Optional. The radius of the circle in meters</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("radius")]
        public virtual System.Nullable<int> Radius { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the ComputeInsights RPC.</summary>
    public class ComputeInsightsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Insight filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual Filter Filter { get; set; }

        /// <summary>
        /// Required. Insights to compute. Currently only INSIGHT_COUNT and INSIGHT_PLACES are supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insights")]
        public virtual System.Collections.Generic.IList<string> Insights { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the ComputeInsights RPC.</summary>
    public class ComputeInsightsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Result for Insights.INSIGHT_COUNT.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>Result for Insights.INSIGHT_PLACES.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placeInsights")]
        public virtual System.Collections.Generic.IList<PlaceInsight> PlaceInsights { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Custom Area.</summary>
    public class CustomArea : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The custom area represented as a polygon</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("polygon")]
        public virtual Polygon Polygon { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Filters for the ComputeInsights RPC.</summary>
    public class Filter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Restricts results to places which are located in the area specified by location filters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationFilter")]
        public virtual LocationFilter LocationFilter { get; set; }

        /// <summary>
        /// Optional. Restricts results to places whose operating status is included on this list. If operating_status
        /// is not set, OPERATING_STATUS_OPERATIONAL is used as default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatingStatus")]
        public virtual System.Collections.Generic.IList<string> OperatingStatus { get; set; }

        /// <summary>
        /// Optional. Restricts results to places whose price level is included on this list. If `price_levels` is not
        /// set, all price levels are included in the results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceLevels")]
        public virtual System.Collections.Generic.IList<string> PriceLevels { get; set; }

        /// <summary>
        /// Optional. Restricts results to places whose average user ratings are in the range specified by
        /// rating_filter. If rating_filter is not set, all ratings are included in the result.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ratingFilter")]
        public virtual RatingFilter RatingFilter { get; set; }

        /// <summary>Required. Place type filters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("typeFilter")]
        public virtual TypeFilter TypeFilter { get; set; }

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

    /// <summary>Location filters. Specifies the area of interest for the insight.</summary>
    public class LocationFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Area as a circle.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("circle")]
        public virtual Circle Circle { get; set; }

        /// <summary>Custom area specified by a polygon.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customArea")]
        public virtual CustomArea CustomArea { get; set; }

        /// <summary>Area as region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual Region Region { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Holds information about a place</summary>
    public class PlaceInsight : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The unique identifier of the place. This resource name can be used to retrieve details about the place using
        /// the [Places
        /// API](https://developers.google.com/maps/documentation/places/web-service/reference/rest/v1/places/get).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("place")]
        public virtual string Place { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A polygon is represented by a series of connected coordinates in an counterclockwise ordered sequence. The
    /// coordinates form a closed loop and define a filled region. The first and last coordinates are equivalent, and
    /// they must contain identical values. The format is a simplified version of GeoJSON polygons (we only support one
    /// counterclockwise exterior ring).
    /// </summary>
    public class Polygon : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The coordinates that define the polygon.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("coordinates")]
        public virtual System.Collections.Generic.IList<LatLng> Coordinates { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Average user rating filters.</summary>
    public class RatingFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Restricts results to places whose average user rating is strictly less than or equal to
        /// max_rating. Values must be between 1.0 and 5.0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxRating")]
        public virtual System.Nullable<float> MaxRating { get; set; }

        /// <summary>
        /// Optional. Restricts results to places whose average user rating is greater than or equal to min_rating.
        /// Values must be between 1.0 and 5.0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minRating")]
        public virtual System.Nullable<float> MinRating { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A region is a geographic boundary such as: cities, postal codes, counties, states, etc.</summary>
    public class Region : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The [place ID](https://developers.google.com/maps/documentation/places/web-service/place-id) of the
        /// geographic region. Not all region types are supported; see documentation for details. **Format:** Must be in
        /// the format `places/PLACE_ID`, where `PLACE_ID` is the unique identifier of a place. For example:
        /// `places/ChIJPV4oX_65j4ARVW8IJ6IJUYs`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("place")]
        public virtual string Place { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Place type filters. Only Place types from [Table
    /// a](https://developers.google.com/maps/documentation/places/web-service/place-types#table-a) are supported. A
    /// place can only have a single primary type associated with it. For example, the primary type might be
    /// "mexican_restaurant" or "steak_house". Use included_primary_types and excluded_primary_types to filter the
    /// results on a place's primary type. A place can also have multiple type values associated with it. For example a
    /// restaurant might have the following types: "seafood_restaurant", "restaurant", "food", "point_of_interest",
    /// "establishment". Use included_types and excluded_types to filter the results on the list of types associated
    /// with a place. If a search is specified with multiple type restrictions, only places that satisfy all of the
    /// restrictions are returned. For example, if you specify {"included_types": ["restaurant"],
    /// "excluded_primary_types": ["steak_house"]}, the returned places provide "restaurant" related services but do not
    /// operate primarily as a "steak_house". If there are any conflicting types, i.e. a type appears in both
    /// included_types and excluded_types types or included_primary_types and excluded_primary_types, an
    /// INVALID_ARGUMENT error is returned. One of included_types or included_primary_types must be set.
    /// </summary>
    public class TypeFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Excluded primary Place types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedPrimaryTypes")]
        public virtual System.Collections.Generic.IList<string> ExcludedPrimaryTypes { get; set; }

        /// <summary>Optional. Excluded Place types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedTypes")]
        public virtual System.Collections.Generic.IList<string> ExcludedTypes { get; set; }

        /// <summary>Optional. Included primary Place types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedPrimaryTypes")]
        public virtual System.Collections.Generic.IList<string> IncludedPrimaryTypes { get; set; }

        /// <summary>Optional. Included Place types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedTypes")]
        public virtual System.Collections.Generic.IList<string> IncludedTypes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
