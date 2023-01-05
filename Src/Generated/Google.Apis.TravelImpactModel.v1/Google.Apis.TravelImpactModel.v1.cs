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
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "travelimpactmodel";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri => BaseUriOverride ?? "https://travelimpactmodel.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://travelimpactmodel.googleapis.com/batch";

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
        /// Stateless method to retrieve emission estimates. Details on how emission estimates are computed:
        /// https://github.com/google/travel-impact-model The response will contain all entries that match the input
        /// flight legs, in the same order. If there are no estimates available for a certain flight leg, the response
        /// will return the flight leg object with empty emission fields. The request will still be considered
        /// successful. Reasons for missing emission estimates include: - The flight is unknown to the server. - The
        /// input flight leg is missing one or more identifiers. - The flight date is in the past. - The aircraft type
        /// is not supported by the model. - Missing seat configuration. The request can contain up to 1000 flight legs.
        /// If the request has more than 1000 direct flights, if will fail with an INVALID_ARGUMENT error.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual ComputeFlightEmissionsRequest ComputeFlightEmissions(Google.Apis.TravelImpactModel.v1.Data.ComputeFlightEmissionsRequest body)
        {
            return new ComputeFlightEmissionsRequest(service, body);
        }

        /// <summary>
        /// Stateless method to retrieve emission estimates. Details on how emission estimates are computed:
        /// https://github.com/google/travel-impact-model The response will contain all entries that match the input
        /// flight legs, in the same order. If there are no estimates available for a certain flight leg, the response
        /// will return the flight leg object with empty emission fields. The request will still be considered
        /// successful. Reasons for missing emission estimates include: - The flight is unknown to the server. - The
        /// input flight leg is missing one or more identifiers. - The flight date is in the past. - The aircraft type
        /// is not supported by the model. - Missing seat configuration. The request can contain up to 1000 flight legs.
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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Travel Impact Model version. For more information about the model versioning see
    /// https://github.com/google/travel-impact-model/#versioning.
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
        /// changes, which will respect guidelines in
        /// https://cloud.google.com/endpoints/docs/openapi/versioning-an-api#backwards-incompatible
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
}
