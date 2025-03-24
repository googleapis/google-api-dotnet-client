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

namespace Google.Apis.AddressValidation.v1
{
    /// <summary>The AddressValidation Service.</summary>
    public class AddressValidationService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AddressValidationService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AddressValidationService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            V1 = new V1Resource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://addressvalidation.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://addressvalidation.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "addressvalidation";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Address Validation API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>Private Service: https://www.googleapis.com/auth/maps-platform.addressvalidation</summary>
            public static string MapsPlatformAddressvalidation = "https://www.googleapis.com/auth/maps-platform.addressvalidation";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Address Validation API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>Private Service: https://www.googleapis.com/auth/maps-platform.addressvalidation</summary>
            public const string MapsPlatformAddressvalidation = "https://www.googleapis.com/auth/maps-platform.addressvalidation";
        }

        /// <summary>Gets the V1 resource.</summary>
        public virtual V1Resource V1 { get; }
    }

    /// <summary>A base abstract class for AddressValidation requests.</summary>
    public abstract class AddressValidationBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new AddressValidationBaseServiceRequest instance.</summary>
        protected AddressValidationBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes AddressValidation parameter list.</summary>
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
        /// Feedback about the outcome of the sequence of validation attempts. This should be the last call made after a
        /// sequence of validation calls for the same address, and should be called once the transaction is concluded.
        /// This should only be sent once for the sequence of `ValidateAddress` requests needed to validate an address
        /// fully.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual ProvideValidationFeedbackRequest ProvideValidationFeedback(Google.Apis.AddressValidation.v1.Data.GoogleMapsAddressvalidationV1ProvideValidationFeedbackRequest body)
        {
            return new ProvideValidationFeedbackRequest(this.service, body);
        }

        /// <summary>
        /// Feedback about the outcome of the sequence of validation attempts. This should be the last call made after a
        /// sequence of validation calls for the same address, and should be called once the transaction is concluded.
        /// This should only be sent once for the sequence of `ValidateAddress` requests needed to validate an address
        /// fully.
        /// </summary>
        public class ProvideValidationFeedbackRequest : AddressValidationBaseServiceRequest<Google.Apis.AddressValidation.v1.Data.GoogleMapsAddressvalidationV1ProvideValidationFeedbackResponse>
        {
            /// <summary>Constructs a new ProvideValidationFeedback request.</summary>
            public ProvideValidationFeedbackRequest(Google.Apis.Services.IClientService service, Google.Apis.AddressValidation.v1.Data.GoogleMapsAddressvalidationV1ProvideValidationFeedbackRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AddressValidation.v1.Data.GoogleMapsAddressvalidationV1ProvideValidationFeedbackRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "provideValidationFeedback";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1:provideValidationFeedback";

            /// <summary>Initializes ProvideValidationFeedback parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Validates an address.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual ValidateAddressRequest ValidateAddress(Google.Apis.AddressValidation.v1.Data.GoogleMapsAddressvalidationV1ValidateAddressRequest body)
        {
            return new ValidateAddressRequest(this.service, body);
        }

        /// <summary>Validates an address.</summary>
        public class ValidateAddressRequest : AddressValidationBaseServiceRequest<Google.Apis.AddressValidation.v1.Data.GoogleMapsAddressvalidationV1ValidateAddressResponse>
        {
            /// <summary>Constructs a new ValidateAddress request.</summary>
            public ValidateAddressRequest(Google.Apis.Services.IClientService service, Google.Apis.AddressValidation.v1.Data.GoogleMapsAddressvalidationV1ValidateAddressRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AddressValidation.v1.Data.GoogleMapsAddressvalidationV1ValidateAddressRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "validateAddress";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1:validateAddress";

            /// <summary>Initializes ValidateAddress parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }
}
namespace Google.Apis.AddressValidation.v1.Data
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

    /// <summary>
    /// Details of the post-processed address. Post-processing includes correcting misspelled parts of the address,
    /// replacing incorrect parts, and inferring missing parts.
    /// </summary>
    public class GoogleMapsAddressvalidationV1Address : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Unordered list. The individual address components of the formatted and corrected address, along with
        /// validation information. This provides information on the validation status of the individual components.
        /// Address components are not ordered in a particular way. Do not make any assumptions on the ordering of the
        /// address components in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addressComponents")]
        public virtual System.Collections.Generic.IList<GoogleMapsAddressvalidationV1AddressComponent> AddressComponents { get; set; }

        /// <summary>
        /// The post-processed address, formatted as a single-line address following the address formatting rules of the
        /// region where the address is located. Note: the format of this address may not match the format of the
        /// address in the `postal_address` field. For example, the `postal_address` always represents the country as a
        /// 2 letter `region_code`, such as "US" or "NZ". By contrast, this field uses a longer form of the country
        /// name, such as "USA" or "New Zealand".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedAddress")]
        public virtual string FormattedAddress { get; set; }

        /// <summary>
        /// The types of components that were expected to be present in a correctly formatted mailing address but were
        /// not found in the input AND could not be inferred. Components of this type are not present in
        /// `formatted_address`, `postal_address`, or `address_components`. An example might be `['street_number',
        /// 'route']` for an input like "Boulder, Colorado, 80301, USA". The list of possible types can be found
        /// [here](https://developers.google.com/maps/documentation/geocoding/requests-geocoding#Types).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("missingComponentTypes")]
        public virtual System.Collections.Generic.IList<string> MissingComponentTypes { get; set; }

        /// <summary>The post-processed address represented as a postal address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalAddress")]
        public virtual GoogleTypePostalAddress PostalAddress { get; set; }

        /// <summary>
        /// The types of the components that are present in the `address_components` but could not be confirmed to be
        /// correct. This field is provided for the sake of convenience: its contents are equivalent to iterating
        /// through the `address_components` to find the types of all the components where the confirmation_level is not
        /// CONFIRMED or the inferred flag is not set to `true`. The list of possible types can be found
        /// [here](https://developers.google.com/maps/documentation/geocoding/requests-geocoding#Types).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unconfirmedComponentTypes")]
        public virtual System.Collections.Generic.IList<string> UnconfirmedComponentTypes { get; set; }

        /// <summary>
        /// Any tokens in the input that could not be resolved. This might be an input that was not recognized as a
        /// valid part of an address. For example, for an input such as "Parcel 0000123123 &amp;amp; 0000456456 Str #
        /// Guthrie Center IA 50115 US", the unresolved tokens might look like `["Parcel", "0000123123", "&amp;amp;",
        /// "0000456456"]`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unresolvedTokens")]
        public virtual System.Collections.Generic.IList<string> UnresolvedTokens { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an address component, such as a street, city, or state.</summary>
    public class GoogleMapsAddressvalidationV1AddressComponent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name for this component.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("componentName")]
        public virtual GoogleMapsAddressvalidationV1ComponentName ComponentName { get; set; }

        /// <summary>
        /// The type of the address component. See [Table 2: Additional types returned by the Places
        /// service](https://developers.google.com/places/web-service/supported_types#table2) for a list of possible
        /// types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("componentType")]
        public virtual string ComponentType { get; set; }

        /// <summary>Indicates the level of certainty that we have that the component is correct.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confirmationLevel")]
        public virtual string ConfirmationLevel { get; set; }

        /// <summary>
        /// Indicates that the component was not part of the input, but we inferred it for the address location and
        /// believe it should be provided for a complete address.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inferred")]
        public virtual System.Nullable<bool> Inferred { get; set; }

        /// <summary>
        /// Indicates the name of the component was replaced with a completely different one, for example a wrong postal
        /// code being replaced with one that is correct for the address. This is not a cosmetic change, the input
        /// component has been changed to a different one.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replaced")]
        public virtual System.Nullable<bool> Replaced { get; set; }

        /// <summary>
        /// Indicates a correction to a misspelling in the component name. The API does not always flag changes from one
        /// spelling variant to another, such as when changing "centre" to "center". It also does not always flag common
        /// misspellings, such as when changing "Amphitheater Pkwy" to "Amphitheatre Pkwy".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spellCorrected")]
        public virtual System.Nullable<bool> SpellCorrected { get; set; }

        /// <summary>
        /// Indicates an address component that is not expected to be present in a postal address for the given region.
        /// We have retained it only because it was part of the input.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unexpected")]
        public virtual System.Nullable<bool> Unexpected { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The metadata for the address. `metadata` is not guaranteed to be fully populated for every address sent to the
    /// Address Validation API.
    /// </summary>
    public class GoogleMapsAddressvalidationV1AddressMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Indicates that this is the address of a business. If unset, indicates that the value is unknown.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("business")]
        public virtual System.Nullable<bool> Business { get; set; }

        /// <summary>Indicates that the address of a PO box. If unset, indicates that the value is unknown.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("poBox")]
        public virtual System.Nullable<bool> PoBox { get; set; }

        /// <summary>
        /// Indicates that this is the address of a residence. If unset, indicates that the value is unknown.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("residential")]
        public virtual System.Nullable<bool> Residential { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A wrapper for the name of the component.</summary>
    public class GoogleMapsAddressvalidationV1ComponentName : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The BCP-47 language code. This will not be present if the component name is not associated with a language,
        /// such as a street number.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>The name text. For example, "5th Avenue" for a street name or "1253" for a street number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains information about the place the input was geocoded to.</summary>
    public class GoogleMapsAddressvalidationV1Geocode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The bounds of the geocoded place.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bounds")]
        public virtual GoogleGeoTypeViewport Bounds { get; set; }

        /// <summary>
        /// The size of the geocoded place, in meters. This is another measure of the coarseness of the geocoded
        /// location, but in physical size rather than in semantic meaning.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("featureSizeMeters")]
        public virtual System.Nullable<float> FeatureSizeMeters { get; set; }

        /// <summary>
        /// The geocoded location of the input. Using place IDs is preferred over using addresses, latitude/longitude
        /// coordinates, or plus codes. Using coordinates when routing or calculating driving directions will always
        /// result in the point being snapped to the road nearest to those coordinates. This may not be a road that will
        /// quickly or safely lead to the destination and may not be near an access point to the property. Additionally,
        /// when a location is reverse geocoded, there is no guarantee that the returned address will match the
        /// original.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual GoogleTypeLatLng Location { get; set; }

        /// <summary>
        /// The PlaceID of the place this input geocodes to. For more information about Place IDs see
        /// [here](https://developers.google.com/maps/documentation/places/web-service/place-id).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placeId")]
        public virtual string PlaceId { get; set; }

        /// <summary>
        /// The type(s) of place that the input geocoded to. For example, `['locality', 'political']`. The full list of
        /// types can be found
        /// [here](https://developers.google.com/maps/documentation/geocoding/requests-geocoding#Types).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placeTypes")]
        public virtual System.Collections.Generic.IList<string> PlaceTypes { get; set; }

        /// <summary>The plus code corresponding to the `location`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plusCode")]
        public virtual GoogleMapsAddressvalidationV1PlusCode PlusCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Preview: This feature is in Preview (pre-GA). Pre-GA products and features might have limited support, and
    /// changes to pre-GA products and features might not be compatible with other pre-GA versions. Pre-GA Offerings are
    /// covered by the [Google Maps Platform Service Specific
    /// Terms](https://cloud.google.com/maps-platform/terms/maps-service-terms). For more information, see the [launch
    /// stage descriptions](https://developers.google.com/maps/launch-stages). Enables the Address Validation API to
    /// include additional information in the response.
    /// </summary>
    public class GoogleMapsAddressvalidationV1LanguageOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Preview: Return a [google.maps.addressvalidation.v1.Address] in English. See
        /// [google.maps.addressvalidation.v1.ValidationResult.english_latin_address] for details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnEnglishLatinAddress")]
        public virtual System.Nullable<bool> ReturnEnglishLatinAddress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Plus code (http://plus.codes) is a location reference with two formats: global code defining a 14mx14m (1/8000th
    /// of a degree) or smaller rectangle, and compound code, replacing the prefix with a reference location.
    /// </summary>
    public class GoogleMapsAddressvalidationV1PlusCode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Place's compound code, such as "33GV+HQ, Ramberg, Norway", containing the suffix of the global code and
        /// replacing the prefix with a formatted name of a reference entity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compoundCode")]
        public virtual string CompoundCode { get; set; }

        /// <summary>
        /// Place's global (full) code, such as "9FWM33GV+HQ", representing an 1/8000 by 1/8000 degree area (~14 by 14
        /// meters).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("globalCode")]
        public virtual string GlobalCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for sending validation feedback.</summary>
    public class GoogleMapsAddressvalidationV1ProvideValidationFeedbackRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The outcome of the sequence of validation attempts. If this field is set to
        /// `VALIDATION_CONCLUSION_UNSPECIFIED`, an `INVALID_ARGUMENT` error will be returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conclusion")]
        public virtual string Conclusion { get; set; }

        /// <summary>
        /// Required. The ID of the response that this feedback is for. This should be the response_id from the first
        /// response in a series of address validation attempts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseId")]
        public virtual string ResponseId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The response for validation feedback. The response is empty if the feedback is sent successfully.
    /// </summary>
    public class GoogleMapsAddressvalidationV1ProvideValidationFeedbackResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>USPS representation of a US address.</summary>
    public class GoogleMapsAddressvalidationV1UspsAddress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>City name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("city")]
        public virtual string City { get; set; }

        /// <summary>City + state + postal code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cityStateZipAddressLine")]
        public virtual string CityStateZipAddressLine { get; set; }

        /// <summary>Firm name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firm")]
        public virtual string Firm { get; set; }

        /// <summary>First address line.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstAddressLine")]
        public virtual string FirstAddressLine { get; set; }

        /// <summary>Second address line.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondAddressLine")]
        public virtual string SecondAddressLine { get; set; }

        /// <summary>2 letter state code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Puerto Rican urbanization name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("urbanization")]
        public virtual string Urbanization { get; set; }

        /// <summary>Postal code e.g. 10009.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zipCode")]
        public virtual string ZipCode { get; set; }

        /// <summary>4-digit postal code extension e.g. 5023.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zipCodeExtension")]
        public virtual string ZipCodeExtension { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The USPS data for the address. `uspsData` is not guaranteed to be fully populated for every US or PR address
    /// sent to the Address Validation API. It's recommended to integrate the backup address fields in the response if
    /// you utilize uspsData as the primary part of the response.
    /// </summary>
    public class GoogleMapsAddressvalidationV1UspsData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Abbreviated city.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("abbreviatedCity")]
        public virtual string AbbreviatedCity { get; set; }

        /// <summary>
        /// Type of the address record that matches the input address. * `F`: FIRM. This is a match to a Firm Record,
        /// which is the finest level of match available for an address. * `G`: GENERAL DELIVERY. This is a match to a
        /// General Delivery record. * `H`: BUILDING / APARTMENT. This is a match to a Building or Apartment record. *
        /// `P`: POST OFFICE BOX. This is a match to a Post Office Box. * `R`: RURAL ROUTE or HIGHWAY CONTRACT: This is
        /// a match to either a Rural Route or a Highway Contract record, both of which may have associated Box Number
        /// ranges. * `S`: STREET RECORD: This is a match to a Street record containing a valid primary number range.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addressRecordType")]
        public virtual string AddressRecordType { get; set; }

        /// <summary>
        /// The carrier route code. A four character code consisting of a one letter prefix and a three digit route
        /// designator. Prefixes: * `C`: Carrier route (or city route) * `R`: Rural route * `H`: Highway Contract Route
        /// * `B`: Post Office Box Section * `G`: General delivery unit
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("carrierRoute")]
        public virtual string CarrierRoute { get; set; }

        /// <summary>Carrier route rate sort indicator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("carrierRouteIndicator")]
        public virtual string CarrierRouteIndicator { get; set; }

        /// <summary>Indicator that the request has been CASS processed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cassProcessed")]
        public virtual System.Nullable<bool> CassProcessed { get; set; }

        /// <summary>County name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("county")]
        public virtual string County { get; set; }

        /// <summary>Indicator that a default address was found, but more specific addresses exists.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultAddress")]
        public virtual System.Nullable<bool> DefaultAddress { get; set; }

        /// <summary>
        /// The delivery point check digit. This number is added to the end of the delivery_point_barcode for
        /// mechanically scanned mail. Adding all the digits of the delivery_point_barcode, delivery_point_check_digit,
        /// postal code, and ZIP+4 together should yield a number divisible by 10.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliveryPointCheckDigit")]
        public virtual string DeliveryPointCheckDigit { get; set; }

        /// <summary>2 digit delivery point code</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliveryPointCode")]
        public virtual string DeliveryPointCode { get; set; }

        /// <summary>
        /// Indicates if the address is a CMRA (Commercial Mail Receiving Agency)--a private business receiving mail for
        /// clients. Returns a single character. * `Y`: The address is a CMRA * `N`: The address is not a CMRA
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dpvCmra")]
        public virtual string DpvCmra { get; set; }

        /// <summary>
        /// The possible values for DPV confirmation. Returns a single character or returns no value. * `N`: Primary and
        /// any secondary number information failed to DPV confirm. * `D`: Address was DPV confirmed for the primary
        /// number only, and the secondary number information was missing. * `S`: Address was DPV confirmed for the
        /// primary number only, and the secondary number information was present but not confirmed. * `Y`: Address was
        /// DPV confirmed for primary and any secondary numbers. * Empty: If the response does not contain a
        /// `dpv_confirmation` value, the address was not submitted for DPV confirmation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dpvConfirmation")]
        public virtual string DpvConfirmation { get; set; }

        /// <summary>
        /// Flag indicates addresses where USPS cannot knock on a door to deliver mail. Returns a single character. *
        /// `Y`: The door is not accessible. * `N`: No indication the door is not accessible.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dpvDoorNotAccessible")]
        public virtual string DpvDoorNotAccessible { get; set; }

        /// <summary>
        /// Flag indicates mail is delivered to a single receptable at a site. Returns a single character. * `Y`: The
        /// mail is delivered to a single receptable at a site. * `N`: The mail is not delivered to a single receptable
        /// at a site.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dpvDrop")]
        public virtual string DpvDrop { get; set; }

        /// <summary>
        /// Indicates that more than one DPV return code is valid for the address. Returns a single character. * `Y`:
        /// Address was DPV confirmed for primary and any secondary numbers. * `N`: Primary and any secondary number
        /// information failed to DPV confirm. * `S`: Address was DPV confirmed for the primary number only, and the
        /// secondary number information was present but not confirmed, or a single trailing alpha on a primary number
        /// was dropped to make a DPV match and secondary information required. * `D`: Address was DPV confirmed for the
        /// primary number only, and the secondary number information was missing. * `R`: Address confirmed but assigned
        /// to phantom route R777 and R779 and USPS delivery is not provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dpvEnhancedDeliveryCode")]
        public virtual string DpvEnhancedDeliveryCode { get; set; }

        /// <summary>
        /// The footnotes from delivery point validation. Multiple footnotes may be strung together in the same string.
        /// * `AA`: Input address matched to the ZIP+4 file * `A1`: Input address was not matched to the ZIP+4 file *
        /// `BB`: Matched to DPV (all components) * `CC`: Secondary number not matched and not required * `C1`:
        /// Secondary number not matched but required * `N1`: High-rise address missing secondary number * `M1`: Primary
        /// number missing * `M3`: Primary number invalid * `P1`: Input address PO, RR or HC box number missing * `P3`:
        /// Input address PO, RR, or HC Box number invalid * `F1`: Input address matched to a military address * `G1`:
        /// Input address matched to a general delivery address * `U1`: Input address matched to a unique ZIP code *
        /// `PB`: Input address matched to PBSA record * `RR`: DPV confirmed address with PMB information * `R1`: DPV
        /// confirmed address without PMB information * `R7`: Carrier Route R777 or R779 record * `IA`: Informed Address
        /// identified * `TA`: Primary number matched by dropping a trailing alpha
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dpvFootnote")]
        public virtual string DpvFootnote { get; set; }

        /// <summary>
        /// Flag indicates door is accessible, but package will not be left due to security concerns. Returns a single
        /// character. * `Y`: The package will not be left due to security concerns. * `N`: No indication the package
        /// will not be left due to security concerns.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dpvNoSecureLocation")]
        public virtual string DpvNoSecureLocation { get; set; }

        /// <summary>
        /// Is this a no stat address or an active address? No stat addresses are ones which are not continuously
        /// occupied or addresses that the USPS does not service. Returns a single character. * `Y`: The address is not
        /// active * `N`: The address is active
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dpvNoStat")]
        public virtual string DpvNoStat { get; set; }

        /// <summary>
        /// Indicates the NoStat type. Returns a reason code as int. * `1`: IDA (Internal Drop Address) – Addresses that
        /// do not receive mail directly from the USPS but are delivered to a drop address that services them. * `2`:
        /// CDS - Addresses that have not yet become deliverable. For example, a new subdivision where lots and primary
        /// numbers have been determined, but no structure exists yet for occupancy. * `3`: Collision - Addresses that
        /// do not actually DPV confirm. * `4`: CMZ (College, Military and Other Types) - ZIP + 4 records USPS has
        /// incorporated into the data. * `5`: Regular - Indicates addresses not receiving delivery and the addresses
        /// are not counted as possible deliveries. * `6`: Secondary Required - The address requires secondary
        /// information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dpvNoStatReasonCode")]
        public virtual System.Nullable<int> DpvNoStatReasonCode { get; set; }

        /// <summary>
        /// Flag indicates mail delivery is not performed every day of the week. Returns a single character. * `Y`: The
        /// mail delivery is not performed every day of the week. * `N`: No indication the mail delivery is not
        /// performed every day of the week.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dpvNonDeliveryDays")]
        public virtual string DpvNonDeliveryDays { get; set; }

        /// <summary>
        /// Integer identifying non-delivery days. It can be interrogated using bit flags: 0x40 – Sunday is a
        /// non-delivery day 0x20 – Monday is a non-delivery day 0x10 – Tuesday is a non-delivery day 0x08 – Wednesday
        /// is a non-delivery day 0x04 – Thursday is a non-delivery day 0x02 – Friday is a non-delivery day 0x01 –
        /// Saturday is a non-delivery day
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dpvNonDeliveryDaysValues")]
        public virtual System.Nullable<int> DpvNonDeliveryDaysValues { get; set; }

        /// <summary>
        /// Indicates the address was matched to PBSA record. Returns a single character. * `Y`: The address was matched
        /// to PBSA record. * `N`: The address was not matched to PBSA record.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dpvPbsa")]
        public virtual string DpvPbsa { get; set; }

        /// <summary>
        /// Indicates that mail is not delivered to the street address. Returns a single character. * `Y`: The mail is
        /// not delivered to the street address. * `N`: The mail is delivered to the street address.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dpvThrowback")]
        public virtual string DpvThrowback { get; set; }

        /// <summary>
        /// Is this place vacant? Returns a single character. * `Y`: The address is vacant * `N`: The address is not
        /// vacant
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dpvVacant")]
        public virtual string DpvVacant { get; set; }

        /// <summary>eLOT Ascending/Descending Flag (A/D).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("elotFlag")]
        public virtual string ElotFlag { get; set; }

        /// <summary>Enhanced Line of Travel (eLOT) number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("elotNumber")]
        public virtual string ElotNumber { get; set; }

        /// <summary>
        /// Error message for USPS data retrieval. This is populated when USPS processing is suspended because of the
        /// detection of artificially created addresses. The USPS data fields might not be populated when this error is
        /// present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>
        /// The delivery address is matchable, but the EWS file indicates that an exact match will be available soon.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ewsNoMatch")]
        public virtual System.Nullable<bool> EwsNoMatch { get; set; }

        /// <summary>FIPS county code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fipsCountyCode")]
        public virtual string FipsCountyCode { get; set; }

        /// <summary>LACSLink indicator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lacsLinkIndicator")]
        public virtual string LacsLinkIndicator { get; set; }

        /// <summary>LACSLink return code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lacsLinkReturnCode")]
        public virtual string LacsLinkReturnCode { get; set; }

        /// <summary>PMB (Private Mail Box) unit designator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pmbDesignator")]
        public virtual string PmbDesignator { get; set; }

        /// <summary>PMB (Private Mail Box) number;</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pmbNumber")]
        public virtual string PmbNumber { get; set; }

        /// <summary>PO Box only postal code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("poBoxOnlyPostalCode")]
        public virtual System.Nullable<bool> PoBoxOnlyPostalCode { get; set; }

        /// <summary>Main post office city.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postOfficeCity")]
        public virtual string PostOfficeCity { get; set; }

        /// <summary>Main post office state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postOfficeState")]
        public virtual string PostOfficeState { get; set; }

        /// <summary>USPS standardized address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("standardizedAddress")]
        public virtual GoogleMapsAddressvalidationV1UspsAddress StandardizedAddress { get; set; }

        /// <summary>
        /// Footnotes from matching a street or highrise record to suite information. If business name match is found,
        /// the secondary number is returned. * `A`: SuiteLink record match, business address improved. * `00`: No
        /// match, business address is not improved.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suitelinkFootnote")]
        public virtual string SuitelinkFootnote { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for validating an address.</summary>
    public class GoogleMapsAddressvalidationV1ValidateAddressRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The address being validated. Unformatted addresses should be submitted via `address_lines`. The
        /// total length of the fields in this input must not exceed 280 characters. Supported regions can be found
        /// [here](https://developers.google.com/maps/documentation/address-validation/coverage). The language_code
        /// value in the input address is reserved for future uses and is ignored today. The validated address result
        /// will be populated based on the preferred language for the given address, as identified by the system. The
        /// Address Validation API ignores the values in recipients and organization. Any values in those fields will be
        /// discarded and not returned. Please do not set them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual GoogleTypePostalAddress Address { get; set; }

        /// <summary>
        /// Enables USPS CASS compatible mode. This affects _only_ the
        /// [google.maps.addressvalidation.v1.ValidationResult.usps_data] field of
        /// [google.maps.addressvalidation.v1.ValidationResult]. Note: for USPS CASS enabled requests for addresses in
        /// Puerto Rico, a [google.type.PostalAddress.region_code] of the `address` must be provided as "PR", or an
        /// [google.type.PostalAddress.administrative_area] of the `address` must be provided as "Puerto Rico"
        /// (case-insensitive) or "PR". It's recommended to use a componentized `address`, or alternatively specify at
        /// least two [google.type.PostalAddress.address_lines] where the first line contains the street number and name
        /// and the second line contains the city, state, and zip code.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableUspsCass")]
        public virtual System.Nullable<bool> EnableUspsCass { get; set; }

        /// <summary>
        /// Optional. Preview: This feature is in Preview (pre-GA). Pre-GA products and features might have limited
        /// support, and changes to pre-GA products and features might not be compatible with other pre-GA versions.
        /// Pre-GA Offerings are covered by the [Google Maps Platform Service Specific
        /// Terms](https://cloud.google.com/maps-platform/terms/maps-service-terms). For more information, see the
        /// [launch stage descriptions](https://developers.google.com/maps/launch-stages). Enables the Address
        /// Validation API to include additional information in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageOptions")]
        public virtual GoogleMapsAddressvalidationV1LanguageOptions LanguageOptions { get; set; }

        /// <summary>
        /// This field must be empty for the first address validation request. If more requests are necessary to fully
        /// validate a single address (for example if the changes the user makes after the initial validation need to be
        /// re-validated), then each followup request must populate this field with the response_id from the very first
        /// response in the validation sequence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousResponseId")]
        public virtual string PreviousResponseId { get; set; }

        /// <summary>
        /// Optional. A string which identifies an Autocomplete session for billing purposes. Must be a URL and filename
        /// safe base64 string with at most 36 ASCII characters in length. Otherwise an INVALID_ARGUMENT error is
        /// returned. The session begins when the user makes an Autocomplete query, and concludes when they select a
        /// place and a call to Place Details or Address Validation is made. Each session can have multiple Autocomplete
        /// queries, followed by one Place Details or Address Validation request. The credentials used for each request
        /// within a session must belong to the same Google Cloud Console project. Once a session has concluded, the
        /// token is no longer valid; your app must generate a fresh token for each session. If the `sessionToken`
        /// parameter is omitted, or if you reuse a session token, the session is charged as if no session token was
        /// provided (each request is billed separately). Note: Address Validation can only be used in sessions with the
        /// Autocomplete (New) API, not the Autocomplete API. See
        /// https://developers.google.com/maps/documentation/places/web-service/session-pricing for more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionToken")]
        public virtual string SessionToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response to an address validation request.</summary>
    public class GoogleMapsAddressvalidationV1ValidateAddressResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The UUID that identifies this response. If the address needs to be re-validated, this UUID *must* accompany
        /// the new request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseId")]
        public virtual string ResponseId { get; set; }

        /// <summary>The result of the address validation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("result")]
        public virtual GoogleMapsAddressvalidationV1ValidationResult Result { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of validating an address.</summary>
    public class GoogleMapsAddressvalidationV1ValidationResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Information about the address itself as opposed to the geocode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual GoogleMapsAddressvalidationV1Address Address { get; set; }

        /// <summary>
        /// Preview: This feature is in Preview (pre-GA). Pre-GA products and features might have limited support, and
        /// changes to pre-GA products and features might not be compatible with other pre-GA versions. Pre-GA Offerings
        /// are covered by the [Google Maps Platform Service Specific
        /// Terms](https://cloud.google.com/maps-platform/terms/maps-service-terms). For more information, see the
        /// [launch stage descriptions](https://developers.google.com/maps/launch-stages). The address translated to
        /// English. Translated addresses are not reusable as API input. The service provides them so that the user can
        /// use their native language to confirm or deny the validation of the originally-provided address. If part of
        /// the address doesn't have an English translation, the service returns that part in an alternate language that
        /// uses a Latin script. See
        /// [here](https://developers.google.com/maps/documentation/address-validation/convert-addresses-english) for an
        /// explanation of how the alternate language is selected. If part of the address doesn't have any translations
        /// or transliterations in a language that uses a Latin script, the service returns that part in the local
        /// language associated with the address. Enable this output by using the
        /// [google.maps.addressvalidation.v1.LanguageOptions.return_english_latin_address] flag. Note: the
        /// [google.maps.addressvalidation.v1.Address.unconfirmed_component_types] field in the `english_latin_address`
        /// and the [google.maps.addressvalidation.v1.AddressComponent.confirmation_level] fields in
        /// `english_latin_address.address_components` are not populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("englishLatinAddress")]
        public virtual GoogleMapsAddressvalidationV1Address EnglishLatinAddress { get; set; }

        /// <summary>Information about the location and place that the address geocoded to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("geocode")]
        public virtual GoogleMapsAddressvalidationV1Geocode Geocode { get; set; }

        /// <summary>
        /// Other information relevant to deliverability. `metadata` is not guaranteed to be fully populated for every
        /// address sent to the Address Validation API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual GoogleMapsAddressvalidationV1AddressMetadata Metadata { get; set; }

        /// <summary>Extra deliverability flags provided by USPS. Only provided in region `US` and `PR`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uspsData")]
        public virtual GoogleMapsAddressvalidationV1UspsData UspsData { get; set; }

        /// <summary>Overall verdict flags</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verdict")]
        public virtual GoogleMapsAddressvalidationV1Verdict Verdict { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>High level overview of the address validation result and geocode.</summary>
    public class GoogleMapsAddressvalidationV1Verdict : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The address is considered complete if there are no unresolved tokens, no unexpected or missing address
        /// components. If unset, indicates that the value is `false`. See `missing_component_types`,
        /// `unresolved_tokens` or `unexpected` fields for more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addressComplete")]
        public virtual System.Nullable<bool> AddressComplete { get; set; }

        /// <summary>
        /// Information about the granularity of the `geocode`. This can be understood as the semantic meaning of how
        /// coarse or fine the geocoded location is. This can differ from the `validation_granularity` above
        /// occasionally. For example, our database might record the existence of an apartment number but do not have a
        /// precise location for the apartment within a big apartment complex. In that case, the
        /// `validation_granularity` will be `SUB_PREMISE` but the `geocode_granularity` will be `PREMISE`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("geocodeGranularity")]
        public virtual string GeocodeGranularity { get; set; }

        /// <summary>
        /// At least one address component was inferred (added) that wasn't in the input, see
        /// [google.maps.addressvalidation.v1.Address.address_components] for details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasInferredComponents")]
        public virtual System.Nullable<bool> HasInferredComponents { get; set; }

        /// <summary>
        /// At least one address component was replaced, see
        /// [google.maps.addressvalidation.v1.Address.address_components] for details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasReplacedComponents")]
        public virtual System.Nullable<bool> HasReplacedComponents { get; set; }

        /// <summary>
        /// At least one address component cannot be categorized or validated, see
        /// [google.maps.addressvalidation.v1.Address.address_components] for details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasUnconfirmedComponents")]
        public virtual System.Nullable<bool> HasUnconfirmedComponents { get; set; }

        /// <summary>
        /// The granularity of the **input** address. This is the result of parsing the input address and does not give
        /// any validation signals. For validation signals, refer to `validation_granularity` below. For example, if the
        /// input address includes a specific apartment number, then the `input_granularity` here will be `SUB_PREMISE`.
        /// If we cannot match the apartment number in the databases or the apartment number is invalid, the
        /// `validation_granularity` will likely be `PREMISE` or below.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputGranularity")]
        public virtual string InputGranularity { get; set; }

        /// <summary>
        /// The granularity level that the API can fully **validate** the address to. For example, an
        /// `validation_granularity` of `PREMISE` indicates all address components at the level of `PREMISE` or more
        /// coarse can be validated. Per address component validation result can be found in
        /// [google.maps.addressvalidation.v1.Address.address_components].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validationGranularity")]
        public virtual string ValidationGranularity { get; set; }

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

    /// <summary>
    /// Represents a postal address (for example, for postal delivery or payments addresses). Given a postal address, a
    /// postal service can deliver items to a premise, P.O. box or similar. It is not intended to model geographical
    /// locations (roads, towns, mountains). In typical usage, an address would be created by user input or from
    /// importing existing data, depending on the type of process. Advice on address input or editing: - Use an
    /// internationalization-ready address widget such as https://github.com/google/libaddressinput. - Users should not
    /// be presented with UI elements for input or editing of fields outside countries where that field is used. For
    /// more guidance on how to use this schema, see: https://support.google.com/business/answer/6397478.
    /// </summary>
    public class GoogleTypePostalAddress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Unstructured address lines describing the lower levels of an address. Because values in `address_lines` do
        /// not have type information and may sometimes contain multiple values in a single field (for example, "Austin,
        /// TX"), it is important that the line order is clear. The order of address lines should be "envelope order"
        /// for the country or region of the address. In places where this can vary (for example, Japan),
        /// `address_language` is used to make it explicit (for example, "ja" for large-to-small ordering and "ja-Latn"
        /// or "en" for small-to-large). In this way, the most specific line of an address can be selected based on the
        /// language. The minimum permitted structural representation of an address consists of a `region_code` with all
        /// remaining information placed in the `address_lines`. It would be possible to format such an address very
        /// approximately without geocoding, but no semantic reasoning could be made about any of the address components
        /// until it was at least partially resolved. Creating an address only containing a `region_code` and
        /// `address_lines` and then geocoding is the recommended way to handle completely unstructured addresses (as
        /// opposed to guessing which parts of the address should be localities or administrative areas).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addressLines")]
        public virtual System.Collections.Generic.IList<string> AddressLines { get; set; }

        /// <summary>
        /// Optional. Highest administrative subdivision which is used for postal addresses of a country or region. For
        /// example, this can be a state, a province, an oblast, or a prefecture. For Spain, this is the province and
        /// not the autonomous community (for example, "Barcelona" and not "Catalonia"). Many countries don't use an
        /// administrative area in postal addresses. For example, in Switzerland, this should be left unpopulated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("administrativeArea")]
        public virtual string AdministrativeArea { get; set; }

        /// <summary>
        /// Optional. BCP-47 language code of the contents of this address (if known). This is often the UI language of
        /// the input form or is expected to match one of the languages used in the address' country/region, or their
        /// transliterated equivalents. This can affect formatting in certain countries, but is not critical to the
        /// correctness of the data and will never affect any validation or other non-formatting related operations. If
        /// this value is not known, it should be omitted (rather than specifying a possibly incorrect default).
        /// Examples: "zh-Hant", "ja", "ja-Latn", "en".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// Optional. Generally refers to the city or town portion of the address. Examples: US city, IT comune, UK post
        /// town. In regions of the world where localities are not well defined or do not fit into this structure well,
        /// leave `locality` empty and use `address_lines`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locality")]
        public virtual string Locality { get; set; }

        /// <summary>Optional. The name of the organization at the address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organization")]
        public virtual string Organization { get; set; }

        /// <summary>
        /// Optional. Postal code of the address. Not all countries use or require postal codes to be present, but where
        /// they are used, they may trigger additional validation with other parts of the address (for example, state or
        /// zip code validation in the United States).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCode")]
        public virtual string PostalCode { get; set; }

        /// <summary>
        /// Optional. The recipient at the address. This field may, under certain circumstances, contain multiline
        /// information. For example, it might contain "care of" information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recipients")]
        public virtual System.Collections.Generic.IList<string> Recipients { get; set; }

        /// <summary>
        /// Required. CLDR region code of the country/region of the address. This is never inferred and it is up to the
        /// user to ensure the value is correct. See https://cldr.unicode.org/ and
        /// https://www.unicode.org/cldr/charts/30/supplemental/territory_information.html for details. Example: "CH"
        /// for Switzerland.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>
        /// The schema revision of the `PostalAddress`. This must be set to 0, which is the latest revision. All new
        /// revisions **must** be backward compatible with old revisions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual System.Nullable<int> Revision { get; set; }

        /// <summary>
        /// Optional. Additional, country-specific, sorting code. This is not used in most regions. Where it is used,
        /// the value is either a string like "CEDEX", optionally followed by a number (for example, "CEDEX 7"), or just
        /// a number alone, representing the "sector code" (Jamaica), "delivery area indicator" (Malawi) or "post office
        /// indicator" (Côte d'Ivoire).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sortingCode")]
        public virtual string SortingCode { get; set; }

        /// <summary>
        /// Optional. Sublocality of the address. For example, this can be a neighborhood, borough, or district.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sublocality")]
        public virtual string Sublocality { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
