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

namespace Google.Apis.TravelImpactModel.v1
{
    /// <summary>The TravelImpactModel Service.</summary>
    public class TravelImpactModelService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public TravelImpactModelService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public TravelImpactModelService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Flights = new FlightsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://travelimpactmodel.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://travelimpactmodel.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "travelimpactmodel";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Gets the Flights resource.</summary>
        public virtual FlightsResource Flights { get; }
    }

    /// <summary>A base abstract class for TravelImpactModel requests.</summary>
    public abstract class TravelImpactModelBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new TravelImpactModelBaseServiceRequest instance.</summary>
        protected TravelImpactModelBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes TravelImpactModel parameter list.</summary>
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

    /// <summary>The "flights" collection of methods.</summary>
    public class FlightsResource
    {
        private const string Resource = "flights";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public FlightsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Stateless method to retrieve emission estimates. Details on how emission estimates are computed are in
        /// [GitHub](https://github.com/google/travel-impact-model) The response will contain all entries that match the
        /// input flight legs, in the same order. If there are no estimates available for a certain flight leg, the
        /// response will return the flight leg object with empty emission fields. The request will still be considered
        /// successful. Reasons for missing emission estimates include: * The flight is unknown to the server. * The
        /// input flight leg is missing one or more identifiers. * The flight date is in the past. * The aircraft type
        /// is not supported by the model. * Missing seat configuration. The request can contain up to 1000 flight legs.
        /// If the request has more than 1000 direct flights, if will fail with an INVALID_ARGUMENT error.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual ComputeFlightEmissionsRequest ComputeFlightEmissions(Google.Apis.TravelImpactModel.v1.Data.ComputeFlightEmissionsRequest body)
        {
            return new ComputeFlightEmissionsRequest(this.service, body);
        }

        /// <summary>
        /// Stateless method to retrieve emission estimates. Details on how emission estimates are computed are in
        /// [GitHub](https://github.com/google/travel-impact-model) The response will contain all entries that match the
        /// input flight legs, in the same order. If there are no estimates available for a certain flight leg, the
        /// response will return the flight leg object with empty emission fields. The request will still be considered
        /// successful. Reasons for missing emission estimates include: * The flight is unknown to the server. * The
        /// input flight leg is missing one or more identifiers. * The flight date is in the past. * The aircraft type
        /// is not supported by the model. * Missing seat configuration. The request can contain up to 1000 flight legs.
        /// If the request has more than 1000 direct flights, if will fail with an INVALID_ARGUMENT error.
        /// </summary>
        public class ComputeFlightEmissionsRequest : TravelImpactModelBaseServiceRequest<Google.Apis.TravelImpactModel.v1.Data.ComputeFlightEmissionsResponse>
        {
            /// <summary>Constructs a new ComputeFlightEmissions request.</summary>
            public ComputeFlightEmissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.TravelImpactModel.v1.Data.ComputeFlightEmissionsRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.TravelImpactModel.v1.Data.ComputeFlightEmissionsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "computeFlightEmissions";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/flights:computeFlightEmissions";

            /// <summary>Initializes ComputeFlightEmissions parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Stateless method to retrieve GHG emissions estimates for a set of flight segments for Scope 3 reporting. The
        /// response will contain all entries that match the input Scope3FlightSegment flight segments, in the same
        /// order provided. The estimates will be computed using the following cascading logic (using the first one that
        /// is available): 1. TIM-based emissions given origin, destination, carrier, flightNumber, departureDate, and
        /// cabinClass. 2. Typical flight emissions given origin, destination, year in departureDate, and cabinClass. 3.
        /// Distance-based emissions calculated using distanceKm, year in departureDate, and cabinClass. If there is a
        /// future flight requested in this calendar year, we do not support Tier 1 emissions and will fallback to Tier
        /// 2 or 3 emissions. If the requested future flight is in not in this calendar year, we will return an empty
        /// response. We recommend that for future flights, computeFlightEmissions API is used instead. If there are no
        /// estimates available for a certain flight with any of the three methods, the response will return a
        /// Scope3FlightEmissions object with empty emission fields. The request will still be considered successful.
        /// Generally, missing emissions estimates occur when the flight is unknown to the server (e.g. no specific
        /// flight exists, or typical flight emissions are not available for the requested pair). The request will fail
        /// with an `INVALID_ARGUMENT` error if: * The request contains more than 1,000 flight legs. * The input flight
        /// leg is missing one or more identifiers. For example, missing origin/destination without a valid distance for
        /// TIM_EMISSIONS or TYPICAL_FLIGHT_EMISSIONS type matching, or missing distance for a DISTANCE_BASED_EMISSIONS
        /// type matching (if you want to fallback to distance-based emissions or want a distance-based emissions
        /// estimate, you need to specify a distance). * The flight date is before 2019 (Scope 3 data is only available
        /// for 2019 and after). * The flight distance is 0 or lower. * Missing cabin class. Because the request is
        /// processed with fallback logic, it is possible that misconfigured requests return valid emissions estimates
        /// using fallback methods. For example, if a request has the wrong flight number but specifies the origin and
        /// destination, the request will still succeed, but the returned emissions will be based solely on the typical
        /// flight emissions. Similarly, if a request is missing the origin for a typical flight emissions request, but
        /// specifies a valid distance, the request could succeed based solely on the distance-based emissions.
        /// Consequently, one should check the source of the returned emissions (source) to confirm the results are as
        /// expected.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual ComputeScope3FlightEmissionsRequest ComputeScope3FlightEmissions(Google.Apis.TravelImpactModel.v1.Data.ComputeScope3FlightEmissionsRequest body)
        {
            return new ComputeScope3FlightEmissionsRequest(this.service, body);
        }

        /// <summary>
        /// Stateless method to retrieve GHG emissions estimates for a set of flight segments for Scope 3 reporting. The
        /// response will contain all entries that match the input Scope3FlightSegment flight segments, in the same
        /// order provided. The estimates will be computed using the following cascading logic (using the first one that
        /// is available): 1. TIM-based emissions given origin, destination, carrier, flightNumber, departureDate, and
        /// cabinClass. 2. Typical flight emissions given origin, destination, year in departureDate, and cabinClass. 3.
        /// Distance-based emissions calculated using distanceKm, year in departureDate, and cabinClass. If there is a
        /// future flight requested in this calendar year, we do not support Tier 1 emissions and will fallback to Tier
        /// 2 or 3 emissions. If the requested future flight is in not in this calendar year, we will return an empty
        /// response. We recommend that for future flights, computeFlightEmissions API is used instead. If there are no
        /// estimates available for a certain flight with any of the three methods, the response will return a
        /// Scope3FlightEmissions object with empty emission fields. The request will still be considered successful.
        /// Generally, missing emissions estimates occur when the flight is unknown to the server (e.g. no specific
        /// flight exists, or typical flight emissions are not available for the requested pair). The request will fail
        /// with an `INVALID_ARGUMENT` error if: * The request contains more than 1,000 flight legs. * The input flight
        /// leg is missing one or more identifiers. For example, missing origin/destination without a valid distance for
        /// TIM_EMISSIONS or TYPICAL_FLIGHT_EMISSIONS type matching, or missing distance for a DISTANCE_BASED_EMISSIONS
        /// type matching (if you want to fallback to distance-based emissions or want a distance-based emissions
        /// estimate, you need to specify a distance). * The flight date is before 2019 (Scope 3 data is only available
        /// for 2019 and after). * The flight distance is 0 or lower. * Missing cabin class. Because the request is
        /// processed with fallback logic, it is possible that misconfigured requests return valid emissions estimates
        /// using fallback methods. For example, if a request has the wrong flight number but specifies the origin and
        /// destination, the request will still succeed, but the returned emissions will be based solely on the typical
        /// flight emissions. Similarly, if a request is missing the origin for a typical flight emissions request, but
        /// specifies a valid distance, the request could succeed based solely on the distance-based emissions.
        /// Consequently, one should check the source of the returned emissions (source) to confirm the results are as
        /// expected.
        /// </summary>
        public class ComputeScope3FlightEmissionsRequest : TravelImpactModelBaseServiceRequest<Google.Apis.TravelImpactModel.v1.Data.ComputeScope3FlightEmissionsResponse>
        {
            /// <summary>Constructs a new ComputeScope3FlightEmissions request.</summary>
            public ComputeScope3FlightEmissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.TravelImpactModel.v1.Data.ComputeScope3FlightEmissionsRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.TravelImpactModel.v1.Data.ComputeScope3FlightEmissionsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "computeScope3FlightEmissions";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/flights:computeScope3FlightEmissions";

            /// <summary>Initializes ComputeScope3FlightEmissions parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Retrieves typical flight emissions estimates between two airports, also known as a market. If there are no
        /// estimates available for a certain market, the response will return the market object with empty emission
        /// fields. The request will still be considered successful. Details on how the typical emissions estimates are
        /// computed are on
        /// [GitHub](https://github.com/google/travel-impact-model/blob/main/projects/typical_flight_emissions.md). The
        /// request can contain up to 1000 markets. If the request has more than 1000 markets, it will fail with an
        /// INVALID_ARGUMENT error.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual ComputeTypicalFlightEmissionsRequest ComputeTypicalFlightEmissions(Google.Apis.TravelImpactModel.v1.Data.ComputeTypicalFlightEmissionsRequest body)
        {
            return new ComputeTypicalFlightEmissionsRequest(this.service, body);
        }

        /// <summary>
        /// Retrieves typical flight emissions estimates between two airports, also known as a market. If there are no
        /// estimates available for a certain market, the response will return the market object with empty emission
        /// fields. The request will still be considered successful. Details on how the typical emissions estimates are
        /// computed are on
        /// [GitHub](https://github.com/google/travel-impact-model/blob/main/projects/typical_flight_emissions.md). The
        /// request can contain up to 1000 markets. If the request has more than 1000 markets, it will fail with an
        /// INVALID_ARGUMENT error.
        /// </summary>
        public class ComputeTypicalFlightEmissionsRequest : TravelImpactModelBaseServiceRequest<Google.Apis.TravelImpactModel.v1.Data.ComputeTypicalFlightEmissionsResponse>
        {
            /// <summary>Constructs a new ComputeTypicalFlightEmissions request.</summary>
            public ComputeTypicalFlightEmissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.TravelImpactModel.v1.Data.ComputeTypicalFlightEmissionsRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.TravelImpactModel.v1.Data.ComputeTypicalFlightEmissionsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "computeTypicalFlightEmissions";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/flights:computeTypicalFlightEmissions";

            /// <summary>Initializes ComputeTypicalFlightEmissions parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }
}
namespace Google.Apis.TravelImpactModel.v1.Data
{
    /// <summary>Input definition for the ComputeFlightEmissions request.</summary>
    public class ComputeFlightEmissionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Direct flights to return emission estimates for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flights")]
        public virtual System.Collections.Generic.IList<Flight> Flights { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Output definition for the ComputeFlightEmissions response.</summary>
    public class ComputeFlightEmissionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of flight legs with emission estimates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flightEmissions")]
        public virtual System.Collections.Generic.IList<FlightWithEmissions> FlightEmissions { get; set; }

        /// <summary>
        /// The model version under which emission estimates for all flights in this response were computed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelVersion")]
        public virtual ModelVersion ModelVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of flight segments to request the Scope 3 emissions for.</summary>
    public class ComputeScope3FlightEmissionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Flights to return emission estimates for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flights")]
        public virtual System.Collections.Generic.IList<Scope3FlightSegment> Flights { get; set; }

        /// <summary>
        /// Optional. The model version under which emission estimates for all flights in this request were computed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelVersion")]
        public virtual ModelVersion ModelVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of flights with Scope 3 emission estimates.</summary>
    public class ComputeScope3FlightEmissionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of flight segments with emission estimates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flightEmissions")]
        public virtual System.Collections.Generic.IList<Scope3FlightEmissions> FlightEmissions { get; set; }

        /// <summary>
        /// The model version under which emission estimates for all flights in this response were computed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelVersion")]
        public virtual ModelVersion ModelVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of pair of airports (markets) to request the typical emissions for.</summary>
    public class ComputeTypicalFlightEmissionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Request the typical flight emissions estimates for this market pair. A maximum of 1000 markets can
        /// be requested.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("markets")]
        public virtual System.Collections.Generic.IList<Market> Markets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response includes the emissions but also the model version.</summary>
    public class ComputeTypicalFlightEmissionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The model version under which typical flight emission estimates for all flights in this response were
        /// computed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelVersion")]
        public virtual ModelVersion ModelVersion { get; set; }

        /// <summary>Market's Typical Flight Emissions requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("typicalFlightEmissions")]
        public virtual System.Collections.Generic.IList<TypicalFlightEmissions> TypicalFlightEmissions { get; set; }

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

    /// <summary>Metadata about the EASA Flight Emissions Label.</summary>
    public class EasaLabelMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The date when the label expires. The label can be displayed until the end of this date.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelExpiryDate")]
        public virtual Date LabelExpiryDate { get; set; }

        /// <summary>The date when the label was issued.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelIssueDate")]
        public virtual Date LabelIssueDate { get; set; }

        /// <summary>Version of the label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelVersion")]
        public virtual string LabelVersion { get; set; }

        /// <summary>
        /// Sustainable Aviation Fuel (SAF) emissions discount percentage applied to the label. It is a percentage as a
        /// decimal. The values are in the interval [0,1]. For example, 0.0021 means 0.21%. This discount and reduction
        /// in emissions are reported by the EASA label but they are not included in the CO2e estimates distributed by
        /// this API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("safDiscountPercentage")]
        public virtual System.Nullable<double> SafDiscountPercentage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Grouped emissions per seating class results.</summary>
    public class EmissionsGramsPerPax : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Emissions for one passenger in business class in grams. This field is always computed and populated,
        /// regardless of whether the aircraft has business class seats or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("business")]
        public virtual System.Nullable<int> Business { get; set; }

        /// <summary>
        /// Emissions for one passenger in economy class in grams. This field is always computed and populated,
        /// regardless of whether the aircraft has economy class seats or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("economy")]
        public virtual System.Nullable<int> Economy { get; set; }

        /// <summary>
        /// Emissions for one passenger in first class in grams. This field is always computed and populated, regardless
        /// of whether the aircraft has first class seats or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("first")]
        public virtual System.Nullable<int> First { get; set; }

        /// <summary>
        /// Emissions for one passenger in premium economy class in grams. This field is always computed and populated,
        /// regardless of whether the aircraft has premium economy class seats or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("premiumEconomy")]
        public virtual System.Nullable<int> PremiumEconomy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>All details related to a single request item for a direct flight emission estimates.</summary>
    public class Flight : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Date of the flight in the time zone of the origin airport. Must be a date in the present or
        /// future.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("departureDate")]
        public virtual Date DepartureDate { get; set; }

        /// <summary>Required. IATA airport code for flight destination, e.g. "JFK".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destination")]
        public virtual string Destination { get; set; }

        /// <summary>Required. Flight number, e.g. 324.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flightNumber")]
        public virtual System.Nullable<int> FlightNumber { get; set; }

        /// <summary>Required. IATA carrier code, e.g. "AA".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatingCarrierCode")]
        public virtual string OperatingCarrierCode { get; set; }

        /// <summary>Required. IATA airport code for flight origin, e.g. "LHR".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("origin")]
        public virtual string Origin { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Direct flight with emission estimates.</summary>
    public class FlightWithEmissions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The significance of contrails warming impact compared to the total CO2e emissions impact.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contrailsImpactBucket")]
        public virtual string ContrailsImpactBucket { get; set; }

        /// <summary>
        /// Optional. Metadata about the EASA Flight Emissions Label. Only set when the emissions data source is EASA.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("easaLabelMetadata")]
        public virtual EasaLabelMetadata EasaLabelMetadata { get; set; }

        /// <summary>
        /// Optional. Per-passenger emission estimate numbers. Will not be present if emissions could not be computed.
        /// For the list of reasons why emissions could not be computed, see ComputeFlightEmissions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emissionsGramsPerPax")]
        public virtual EmissionsGramsPerPax EmissionsGramsPerPax { get; set; }

        /// <summary>
        /// Required. Matches the flight identifiers in the request. Note: all IATA codes are capitalized.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flight")]
        public virtual Flight Flight { get; set; }

        /// <summary>Optional. The source of the emissions data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A pair of airports.</summary>
    public class Market : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. IATA airport code for flight destination, e.g. "JFK".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destination")]
        public virtual string Destination { get; set; }

        /// <summary>Required. IATA airport code for flight origin, e.g. "LHR".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("origin")]
        public virtual string Origin { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Travel Impact Model version. For more information about the model versioning see
    /// [GitHub](https://github.com/google/travel-impact-model/#versioning).
    /// </summary>
    public class ModelVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Dated versions: Model datasets are recreated with refreshed input data but no change to the algorithms
        /// regularly.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dated")]
        public virtual string Dated { get; set; }

        /// <summary>
        /// Major versions: Major changes to methodology (e.g. adding new data sources to the model that lead to major
        /// output changes). Such changes will be infrequent and announced well in advance. Might involve API version
        /// changes, which will respect [Google Cloud API
        /// guidelines](https://cloud.google.com/endpoints/docs/openapi/versioning-an-api#backwards-incompatible)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("major")]
        public virtual System.Nullable<int> Major { get; set; }

        /// <summary>
        /// Minor versions: Changes to the model that, while being consistent across schema versions, change the model
        /// parameters or implementation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minor")]
        public virtual System.Nullable<int> Minor { get; set; }

        /// <summary>
        /// Patch versions: Implementation changes meant to address bugs or inaccuracies in the model implementation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("patch")]
        public virtual System.Nullable<int> Patch { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Scope 3 flight with emission estimates.</summary>
    public class Scope3FlightEmissions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Matches the flight identifiers in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flight")]
        public virtual Scope3FlightSegment Flight { get; set; }

        /// <summary>Optional. The source of the emissions data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>Optional. Tank-to-wake flight emissions per passenger based on the requested info.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ttwEmissionsGramsPerPax")]
        public virtual System.Nullable<long> TtwEmissionsGramsPerPax { get; set; }

        /// <summary>Optional. Well-to-tank flight emissions per passenger based on the requested info.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wttEmissionsGramsPerPax")]
        public virtual System.Nullable<long> WttEmissionsGramsPerPax { get; set; }

        /// <summary>
        /// Optional. Total flight emissions (sum of well-to-tank and tank-to-wake) per passenger based on the requested
        /// info. This is the total emissions and unless you have specific reasons for using TTW or WTT emissions, you
        /// should use this number.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wtwEmissionsGramsPerPax")]
        public virtual System.Nullable<long> WtwEmissionsGramsPerPax { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Flight parameters with which the Scope 3 emissions are fetched.</summary>
    public class Scope3FlightSegment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The cabin class of the flight.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cabinClass")]
        public virtual string CabinClass { get; set; }

        /// <summary>
        /// Optional. 2-character [IATA carrier code](https://www.iata.org/en/publications/directories/code-search/),
        /// e.g. `KE`. This is required if specific flight matching is desired. Otherwise, this is unused for typical
        /// flight and distance-based emissions models. This could be both operating and marketing carrier code (i.e.
        /// codeshare is covered).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("carrierCode")]
        public virtual string CarrierCode { get; set; }

        /// <summary>
        /// Required. Date of the flight in the time zone of the origin airport. Only year is required for typical
        /// flight and distance-based emissions models (month and day values are ignored and therefore, can be either
        /// omitted, set to 0, or set to a valid date for those cases). Correspondingly, if a specific date is not
        /// provided for TIM emissions, we will fallback to typical flight (or distance-based) emissions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("departureDate")]
        public virtual Date DepartureDate { get; set; }

        /// <summary>
        /// Optional. 3-character [IATA airport code](https://www.iata.org/en/publications/directories/code-search/) for
        /// flight destination, e.g. `ICN`. This is used to match specific flight if provided alongside origin, carrier,
        /// and flight number. If there is no match, we will first try to match the flight to a typical flight between
        /// the provided origin and destination airports. Otherwise, we will use the distance-based emissions model if
        /// the flight distance is provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destination")]
        public virtual string Destination { get; set; }

        /// <summary>
        /// Optional. Distance in kilometers, e.g. `2423`, from [1, 2.5e16) km. This is used to match a flight to
        /// distance-based emissions when origin and destination are not provided or there are no matching typical
        /// flights.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distanceKm")]
        public virtual System.Nullable<long> DistanceKm { get; set; }

        /// <summary>
        /// Optional. Up to 4-digit [flight number](https://en.wikipedia.org/wiki/Flight_number), e.g. `71`, from [1,
        /// 9999]. This is first used to match a specific flight if a flight number is specified alongside origin,
        /// destination, and carrier. If a flight number is not specified, we will first try to match the flight to a
        /// typical flight between the provided origin and destination airports. If that fails and/or origin &amp;amp;
        /// destination are not provided, we will use the distance-based emissions model based on the flight distance
        /// provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flightNumber")]
        public virtual System.Nullable<int> FlightNumber { get; set; }

        /// <summary>
        /// Optional. 3-character [IATA airport code](https://www.iata.org/en/publications/directories/code-search/) for
        /// flight origin, e.g. `YVR`. This is used to match specific flight if provided alongside destination, carrier,
        /// and flight number. If there is no match, we will first try to match the flight to a typical flight between
        /// the provided origin and destination airports. Otherwise, we will use the distance-based emissions model if
        /// the flight distance is provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("origin")]
        public virtual string Origin { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Typical flight emission estimates for a certain market</summary>
    public class TypicalFlightEmissions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Typical flight emissions per passenger for requested market. Will not be present if a typical
        /// emissions could not be computed. For the list of reasons why typical flight emissions could not be computed,
        /// see
        /// [GitHub](https://github.com/google/travel-impact-model/blob/main/projects/typical_flight_emissions.md#step-7-validate-dataset).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emissionsGramsPerPax")]
        public virtual EmissionsGramsPerPax EmissionsGramsPerPax { get; set; }

        /// <summary>
        /// Required. Matches the flight identifiers in the request. Note: all IATA codes are capitalized.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("market")]
        public virtual Market Market { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
