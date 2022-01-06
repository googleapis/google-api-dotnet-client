// Copyright 2022 Google LLC
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

namespace Google.Apis.MyBusinessLodging.v1
{
    /// <summary>The MyBusinessLodging Service.</summary>
    public class MyBusinessLodgingService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public MyBusinessLodgingService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public MyBusinessLodgingService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Locations = new LocationsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "mybusinesslodging";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://mybusinesslodging.googleapis.com/";
        #else
            "https://mybusinesslodging.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://mybusinesslodging.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Gets the Locations resource.</summary>
        public virtual LocationsResource Locations { get; }
    }

    /// <summary>A base abstract class for MyBusinessLodging requests.</summary>
    public abstract class MyBusinessLodgingBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new MyBusinessLodgingBaseServiceRequest instance.</summary>
        protected MyBusinessLodgingBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes MyBusinessLodging parameter list.</summary>
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

    /// <summary>The "locations" collection of methods.</summary>
    public class LocationsResource
    {
        private const string Resource = "locations";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public LocationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Lodging = new LodgingResource(service);
        }

        /// <summary>Gets the Lodging resource.</summary>
        public virtual LodgingResource Lodging { get; }

        /// <summary>The "lodging" collection of methods.</summary>
        public class LodgingResource
        {
            private const string Resource = "lodging";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public LodgingResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Returns the Google updated Lodging of a specific location.</summary>
            /// <param name="name">
            /// Required. Google identifier for this location in the form:
            /// `accounts/{account_id}/locations/{location_id}/lodging`
            /// </param>
            public virtual GetGoogleUpdatedRequest GetGoogleUpdated(string name)
            {
                return new GetGoogleUpdatedRequest(service, name);
            }

            /// <summary>Returns the Google updated Lodging of a specific location.</summary>
            public class GetGoogleUpdatedRequest : MyBusinessLodgingBaseServiceRequest<Google.Apis.MyBusinessLodging.v1.Data.GetGoogleUpdatedLodgingResponse>
            {
                /// <summary>Constructs a new GetGoogleUpdated request.</summary>
                public GetGoogleUpdatedRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Google identifier for this location in the form:
                /// `accounts/{account_id}/locations/{location_id}/lodging`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Required. The specific fields to return. Use "*" to include all fields. Repeated field items cannot
                /// be individually specified.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("readMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object ReadMask { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getGoogleUpdated";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:getGoogleUpdated";

                /// <summary>Initializes GetGoogleUpdated parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^locations/[^/]+/lodging$",
                    });
                    RequestParameters.Add("readMask", new Google.Apis.Discovery.Parameter
                    {
                        Name = "readMask",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Returns the Lodging of a specific location.</summary>
        /// <param name="name">
        /// Required. Google identifier for this location in the form: `locations/{location_id}/lodging`
        /// </param>
        public virtual GetLodgingRequest GetLodging(string name)
        {
            return new GetLodgingRequest(service, name);
        }

        /// <summary>Returns the Lodging of a specific location.</summary>
        public class GetLodgingRequest : MyBusinessLodgingBaseServiceRequest<Google.Apis.MyBusinessLodging.v1.Data.Lodging>
        {
            /// <summary>Constructs a new GetLodging request.</summary>
            public GetLodgingRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. Google identifier for this location in the form: `locations/{location_id}/lodging`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// Required. The specific fields to return. Use "*" to include all fields. Repeated field items cannot be
            /// individually specified.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("readMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object ReadMask { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getLodging";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes GetLodging parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^locations/[^/]+/lodging$",
                });
                RequestParameters.Add("readMask", new Google.Apis.Discovery.Parameter
                {
                    Name = "readMask",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates the Lodging of a specific location.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Required. Google identifier for this location in the form: `locations/{location_id}/lodging`
        /// </param>
        public virtual UpdateLodgingRequest UpdateLodging(Google.Apis.MyBusinessLodging.v1.Data.Lodging body, string name)
        {
            return new UpdateLodgingRequest(service, body, name);
        }

        /// <summary>Updates the Lodging of a specific location.</summary>
        public class UpdateLodgingRequest : MyBusinessLodgingBaseServiceRequest<Google.Apis.MyBusinessLodging.v1.Data.Lodging>
        {
            /// <summary>Constructs a new UpdateLodging request.</summary>
            public UpdateLodgingRequest(Google.Apis.Services.IClientService service, Google.Apis.MyBusinessLodging.v1.Data.Lodging body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. Google identifier for this location in the form: `locations/{location_id}/lodging`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// Required. The specific fields to update. Use "*" to update all fields, which may include unsetting empty
            /// fields in the request. Repeated field items cannot be individually updated.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.MyBusinessLodging.v1.Data.Lodging Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateLodging";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes UpdateLodging parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^locations/[^/]+/lodging$",
                });
                RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                {
                    Name = "updateMask",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.MyBusinessLodging.v1.Data
{
    /// <summary>
    /// Physical adaptations made to the property in consideration of varying levels of human physical ability.
    /// </summary>
    public class Accessibility : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Mobility accessible. Throughout the property there are physical adaptations to ease the stay of a person in
        /// a wheelchair, such as auto-opening doors, wide elevators, wide bathrooms or ramps.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobilityAccessible")]
        public virtual System.Nullable<bool> MobilityAccessible { get; set; }

        /// <summary>
        /// Mobility accessible elevator. A lift that transports people from one level to another and is built to
        /// accommodate a wheelchair-using passenger owing to the width of its doors and placement of call buttons.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobilityAccessibleElevator")]
        public virtual System.Nullable<bool> MobilityAccessibleElevator { get; set; }

        /// <summary>Mobility accessible elevator exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobilityAccessibleElevatorException")]
        public virtual string MobilityAccessibleElevatorException { get; set; }

        /// <summary>Mobility accessible exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobilityAccessibleException")]
        public virtual string MobilityAccessibleException { get; set; }

        /// <summary>
        /// Mobility accessible parking. The presence of a marked, designated area of prescribed size in which only
        /// registered, labeled vehicles transporting a person with physical challenges may park.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobilityAccessibleParking")]
        public virtual System.Nullable<bool> MobilityAccessibleParking { get; set; }

        /// <summary>Mobility accessible parking exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobilityAccessibleParkingException")]
        public virtual string MobilityAccessibleParkingException { get; set; }

        /// <summary>
        /// Mobility accessible pool. A swimming pool equipped with a mechanical chair that can be lowered and raised
        /// for the purpose of moving physically challenged guests into and out of the pool. May be powered by
        /// electricity or water. Also known as pool lift.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobilityAccessiblePool")]
        public virtual System.Nullable<bool> MobilityAccessiblePool { get; set; }

        /// <summary>Mobility accessible pool exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobilityAccessiblePoolException")]
        public virtual string MobilityAccessiblePoolException { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Amenities and features related to leisure and play.</summary>
    public class Activities : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Beach access. The hotel property is in close proximity to a beach and offers a way to get to that beach.
        /// This can include a route to the beach such as stairs down if hotel is on a bluff, or a short trail. Not the
        /// same as beachfront (with beach access, the hotel's proximity is close to but not right on the beach).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("beachAccess")]
        public virtual System.Nullable<bool> BeachAccess { get; set; }

        /// <summary>Beach access exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("beachAccessException")]
        public virtual string BeachAccessException { get; set; }

        /// <summary>
        /// Breach front. The hotel property is physically located on the beach alongside an ocean, sea, gulf, or bay.
        /// It is not on a lake, river, stream, or pond. The hotel is not separated from the beach by a public road
        /// allowing vehicular, pedestrian, or bicycle traffic.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("beachFront")]
        public virtual System.Nullable<bool> BeachFront { get; set; }

        /// <summary>Beach front exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("beachFrontException")]
        public virtual string BeachFrontException { get; set; }

        /// <summary>
        /// Bicycle rental. The hotel owns bicycles that it permits guests to borrow and use. Can be free or for a fee.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bicycleRental")]
        public virtual System.Nullable<bool> BicycleRental { get; set; }

        /// <summary>Bicycle rental exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bicycleRentalException")]
        public virtual string BicycleRentalException { get; set; }

        /// <summary>
        /// Boutique stores. There are stores selling clothing, jewelry, art and decor either on hotel premises or very
        /// close by. Does not refer to the hotel gift shop or convenience store.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boutiqueStores")]
        public virtual System.Nullable<bool> BoutiqueStores { get; set; }

        /// <summary>Boutique stores exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boutiqueStoresException")]
        public virtual string BoutiqueStoresException { get; set; }

        /// <summary>
        /// Casino. A space designated for gambling and gaming featuring croupier-run table and card games, as well as
        /// electronic slot machines. May be on hotel premises or located nearby.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("casino")]
        public virtual System.Nullable<bool> Casino { get; set; }

        /// <summary>Casino exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("casinoException")]
        public virtual string CasinoException { get; set; }

        /// <summary>
        /// Free bicycle rental. The hotel owns bicycles that it permits guests to borrow and use for free.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeBicycleRental")]
        public virtual System.Nullable<bool> FreeBicycleRental { get; set; }

        /// <summary>Free bicycle rental exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeBicycleRentalException")]
        public virtual string FreeBicycleRentalException { get; set; }

        /// <summary>
        /// Free watercraft rental. The hotel owns watercraft that it permits guests to borrow and use for free.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeWatercraftRental")]
        public virtual System.Nullable<bool> FreeWatercraftRental { get; set; }

        /// <summary>Free Watercraft rental exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeWatercraftRentalException")]
        public virtual string FreeWatercraftRentalException { get; set; }

        /// <summary>
        /// Game room. There is a room at the hotel containing electronic machines for play such as pinball, prize
        /// machines, driving simulators, and other items commonly found at a family fun center or arcade. May also
        /// include non-electronic games like pool, foosball, darts, and more. May or may not be designed for children.
        /// Also known as arcade, fun room, or family fun center.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gameRoom")]
        public virtual System.Nullable<bool> GameRoom { get; set; }

        /// <summary>Game room exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gameRoomException")]
        public virtual string GameRoomException { get; set; }

        /// <summary>
        /// Golf. There is a golf course on hotel grounds or there is a nearby, independently run golf course that
        /// allows use by hotel guests. Can be free or for a fee.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("golf")]
        public virtual System.Nullable<bool> Golf { get; set; }

        /// <summary>Golf exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("golfException")]
        public virtual string GolfException { get; set; }

        /// <summary>
        /// Horseback riding. The hotel has a horse barn onsite or an affiliation with a nearby barn to allow for guests
        /// to sit astride a horse and direct it to walk, trot, cantor, gallop and/or jump. Can be in a riding ring, on
        /// designated paths, or in the wilderness. May or may not involve instruction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("horsebackRiding")]
        public virtual System.Nullable<bool> HorsebackRiding { get; set; }

        /// <summary>Horseback riding exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("horsebackRidingException")]
        public virtual string HorsebackRidingException { get; set; }

        /// <summary>
        /// Nightclub. There is a room at the hotel with a bar, a dance floor, and seating where designated staffers
        /// play dance music. There may also be a designated area for the performance of live music, singing and comedy
        /// acts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nightclub")]
        public virtual System.Nullable<bool> Nightclub { get; set; }

        /// <summary>Nightclub exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nightclubException")]
        public virtual string NightclubException { get; set; }

        /// <summary>Private beach. The beach which is in close proximity to the hotel is open only to guests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateBeach")]
        public virtual System.Nullable<bool> PrivateBeach { get; set; }

        /// <summary>Private beach exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateBeachException")]
        public virtual string PrivateBeachException { get; set; }

        /// <summary>
        /// Scuba. The provision for guests to dive under naturally occurring water fitted with a self-contained
        /// underwater breathing apparatus (SCUBA) for the purpose of exploring underwater life. Apparatus consists of a
        /// tank providing oxygen to the diver through a mask. Requires certification of the diver and supervision. The
        /// hotel may have the activity at its own waterfront or have an affiliation with a nearby facility. Required
        /// equipment is most often supplied to guests. Can be free or for a fee. Not snorkeling. Not done in a swimming
        /// pool.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scuba")]
        public virtual System.Nullable<bool> Scuba { get; set; }

        /// <summary>Scuba exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scubaException")]
        public virtual string ScubaException { get; set; }

        /// <summary>
        /// Snorkeling. The provision for guests to participate in a recreational water activity in which swimmers wear
        /// a diving mask, a simple, shaped breathing tube and flippers/swim fins for the purpose of exploring below the
        /// surface of an ocean, gulf or lake. Does not usually require user certification or professional supervision.
        /// Equipment may or may not be available for rent or purchase. Not scuba diving.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snorkeling")]
        public virtual System.Nullable<bool> Snorkeling { get; set; }

        /// <summary>Snorkeling exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snorkelingException")]
        public virtual string SnorkelingException { get; set; }

        /// <summary>
        /// Tennis. The hotel has the requisite court(s) on site or has an affiliation with a nearby facility for the
        /// purpose of providing guests with the opportunity to play a two-sided court-based game in which players use a
        /// stringed racquet to hit a ball across a net to the side of the opposing player. The court can be indoors or
        /// outdoors. Instructors, racquets and balls may or may not be provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tennis")]
        public virtual System.Nullable<bool> Tennis { get; set; }

        /// <summary>Tennis exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tennisException")]
        public virtual string TennisException { get; set; }

        /// <summary>
        /// Water skiing. The provision of giving guests the opportunity to be pulled across naturally occurring water
        /// while standing on skis and holding a tow rope attached to a motorboat. Can occur on hotel premises or at a
        /// nearby waterfront. Most often performed in a lake or ocean.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("waterSkiing")]
        public virtual System.Nullable<bool> WaterSkiing { get; set; }

        /// <summary>Water skiing exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("waterSkiingException")]
        public virtual string WaterSkiingException { get; set; }

        /// <summary>
        /// Watercraft rental. The hotel owns water vessels that it permits guests to borrow and use. Can be free or for
        /// a fee. Watercraft may include boats, pedal boats, rowboats, sailboats, powerboats, canoes, kayaks, or
        /// personal watercraft (such as a Jet Ski).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("watercraftRental")]
        public virtual System.Nullable<bool> WatercraftRental { get; set; }

        /// <summary>Watercraft rental exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("watercraftRentalException")]
        public virtual string WatercraftRentalException { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Features of the property of specific interest to the business traveler.</summary>
    public class Business : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Business center. A designated room at the hotel with one or more desks and equipped with guest-use
        /// computers, printers, fax machines and/or photocopiers. May or may not be open 24/7. May or may not require a
        /// key to access. Not a meeting room or conference room.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("businessCenter")]
        public virtual System.Nullable<bool> BusinessCenter { get; set; }

        /// <summary>Business center exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("businessCenterException")]
        public virtual string BusinessCenterException { get; set; }

        /// <summary>
        /// Meeting rooms. Rooms at the hotel designated for business-related gatherings. Rooms are usually equipped
        /// with tables or desks, office chairs and audio/visual facilities to allow for presentations and conference
        /// calls. Also known as conference rooms.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meetingRooms")]
        public virtual System.Nullable<bool> MeetingRooms { get; set; }

        /// <summary>Meeting rooms count. The number of meeting rooms at the property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meetingRoomsCount")]
        public virtual System.Nullable<int> MeetingRoomsCount { get; set; }

        /// <summary>Meeting rooms count exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meetingRoomsCountException")]
        public virtual string MeetingRoomsCountException { get; set; }

        /// <summary>Meeting rooms exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meetingRoomsException")]
        public virtual string MeetingRoomsException { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The ways in which the property provides guests with the ability to access the internet.</summary>
    public class Connectivity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Free wifi. The hotel offers guests wifi for free.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeWifi")]
        public virtual System.Nullable<bool> FreeWifi { get; set; }

        /// <summary>Free wifi exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeWifiException")]
        public virtual string FreeWifiException { get; set; }

        /// <summary>
        /// Public area wifi available. Guests have the ability to wirelessly connect to the internet in the areas of
        /// the hotel accessible to anyone. Can be free or for a fee.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicAreaWifiAvailable")]
        public virtual System.Nullable<bool> PublicAreaWifiAvailable { get; set; }

        /// <summary>Public area wifi available exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicAreaWifiAvailableException")]
        public virtual string PublicAreaWifiAvailableException { get; set; }

        /// <summary>
        /// Public internet terminal. An area of the hotel supplied with computers and designated for the purpose of
        /// providing guests with the ability to access the internet.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicInternetTerminal")]
        public virtual System.Nullable<bool> PublicInternetTerminal { get; set; }

        /// <summary>Public internet terminal exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicInternetTerminalException")]
        public virtual string PublicInternetTerminalException { get; set; }

        /// <summary>
        /// Wifi available. The hotel provides the ability for guests to wirelessly connect to the internet. Can be in
        /// the public areas of the hotel and/or in the guest rooms. Can be free or for a fee.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wifiAvailable")]
        public virtual System.Nullable<bool> WifiAvailable { get; set; }

        /// <summary>Wifi available exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wifiAvailableException")]
        public virtual string WifiAvailableException { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An eco certificate awarded to the hotel.</summary>
    public class EcoCertification : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the eco certificate was awarded or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("awarded")]
        public virtual System.Nullable<bool> Awarded { get; set; }

        /// <summary>Awarded exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("awardedException")]
        public virtual string AwardedException { get; set; }

        /// <summary>Required. The eco certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ecoCertificate")]
        public virtual string EcoCertificate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Energy efficiency practices implemented at the hotel.</summary>
    public class EnergyEfficiency : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Carbon free energy sources. Property sources carbon-free electricity via at least one of the following
        /// methods: on-site clean energy generation, power purchase agreement(s) with clean energy generators, green
        /// power provided by electricity supplier, or purchases of Energy Attribute Certificates (such as Renewable
        /// Energy Certificates or Guarantees of Origin).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("carbonFreeEnergySources")]
        public virtual System.Nullable<bool> CarbonFreeEnergySources { get; set; }

        /// <summary>Carbon free energy sources exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("carbonFreeEnergySourcesException")]
        public virtual string CarbonFreeEnergySourcesException { get; set; }

        /// <summary>
        /// Energy conservation program. The property tracks corporate-level Scope 1 and 2 GHG emissions, and Scope 3
        /// emissions if available. The property has a commitment to implement initiatives that reduce GHG emissions
        /// year over year. The property has shown an absolute reduction in emissions for at least 2 years. Emissions
        /// are either verfied by a third-party and/or published in external communications.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("energyConservationProgram")]
        public virtual System.Nullable<bool> EnergyConservationProgram { get; set; }

        /// <summary>Energy conservation program exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("energyConservationProgramException")]
        public virtual string EnergyConservationProgramException { get; set; }

        /// <summary>
        /// Energy efficient heating and cooling systems. The property doesn't use chlorofluorocarbon (CFC)-based
        /// refrigerants in heating, ventilating, and air-conditioning systems unless a third-party audit shows it's not
        /// economically feasible. The CFC-based refrigerants which are used should have a Global Warming Potential
        /// (GWP) ≤ 10. The property uses occupancy sensors on HVAC systems in back-of-house spaces, meeting rooms, and
        /// other low-traffic areas.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("energyEfficientHeatingAndCoolingSystems")]
        public virtual System.Nullable<bool> EnergyEfficientHeatingAndCoolingSystems { get; set; }

        /// <summary>Energy efficient heating and cooling systems exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("energyEfficientHeatingAndCoolingSystemsException")]
        public virtual string EnergyEfficientHeatingAndCoolingSystemsException { get; set; }

        /// <summary>
        /// Energy efficient lighting. At least 75% of the property's lighting is energy efficient, using lighting that
        /// is more than 45 lumens per watt – typically LED or CFL lightbulbs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("energyEfficientLighting")]
        public virtual System.Nullable<bool> EnergyEfficientLighting { get; set; }

        /// <summary>Energy efficient lighting exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("energyEfficientLightingException")]
        public virtual string EnergyEfficientLightingException { get; set; }

        /// <summary>
        /// Energy saving thermostats. The property installed energy-saving thermostats throughout the building to
        /// conserve energy when rooms or areas are not in use. Energy-saving thermostats are devices that control
        /// heating/cooling in the building by learning temperature preferences and automatically adjusting to
        /// energy-saving temperatures as the default. The thermostats are automatically set to a temperature between
        /// 68-78 degrees F (20-26 °C), depending on seasonality. In the winter, set the thermostat to 68°F (20°C) when
        /// the room is occupied, lowering room temperature when unoccupied. In the summer, set the thermostat to 78°F
        /// (26°C) when the room is occupied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("energySavingThermostats")]
        public virtual System.Nullable<bool> EnergySavingThermostats { get; set; }

        /// <summary>Energy saving thermostats exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("energySavingThermostatsException")]
        public virtual string EnergySavingThermostatsException { get; set; }

        /// <summary>Output only. Green building design. True if BREEAM-* or LEED-* certified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("greenBuildingDesign")]
        public virtual System.Nullable<bool> GreenBuildingDesign { get; set; }

        /// <summary>Output only. Green building design exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("greenBuildingDesignException")]
        public virtual string GreenBuildingDesignException { get; set; }

        /// <summary>
        /// Independent organization audits energy use. The property conducts an energy audit at least every 5 years,
        /// the results of which are either verified by a third-party and/or published in external communications. An
        /// energy audit is a detailed assessment of the facility which provides recommendations to existing operations
        /// and procedures to improve energy efficiency, available incentives or rebates,and opportunities for
        /// improvements through renovations or upgrades. Examples of organizations that conduct credible third party
        /// audits include: Engie Impact, DNV GL (EU), Dexma, and local utility providers (they often provide energy and
        /// water audits).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("independentOrganizationAuditsEnergyUse")]
        public virtual System.Nullable<bool> IndependentOrganizationAuditsEnergyUse { get; set; }

        /// <summary>Independent organization audits energy use exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("independentOrganizationAuditsEnergyUseException")]
        public virtual string IndependentOrganizationAuditsEnergyUseException { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Enhanced cleaning measures implemented by the hotel during COVID-19.</summary>
    public class EnhancedCleaning : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Commercial-grade disinfectant used to clean the property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commercialGradeDisinfectantCleaning")]
        public virtual System.Nullable<bool> CommercialGradeDisinfectantCleaning { get; set; }

        /// <summary>Commercial grade disinfectant cleaning exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commercialGradeDisinfectantCleaningException")]
        public virtual string CommercialGradeDisinfectantCleaningException { get; set; }

        /// <summary>Enhanced cleaning of common areas.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonAreasEnhancedCleaning")]
        public virtual System.Nullable<bool> CommonAreasEnhancedCleaning { get; set; }

        /// <summary>Common areas enhanced cleaning exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonAreasEnhancedCleaningException")]
        public virtual string CommonAreasEnhancedCleaningException { get; set; }

        /// <summary>Employees trained in COVID-19 cleaning procedures.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("employeesTrainedCleaningProcedures")]
        public virtual System.Nullable<bool> EmployeesTrainedCleaningProcedures { get; set; }

        /// <summary>Employees trained cleaning procedures exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("employeesTrainedCleaningProceduresException")]
        public virtual string EmployeesTrainedCleaningProceduresException { get; set; }

        /// <summary>Employees trained in thorough hand-washing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("employeesTrainedThoroughHandWashing")]
        public virtual System.Nullable<bool> EmployeesTrainedThoroughHandWashing { get; set; }

        /// <summary>Employees trained thorough hand washing exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("employeesTrainedThoroughHandWashingException")]
        public virtual string EmployeesTrainedThoroughHandWashingException { get; set; }

        /// <summary>Employees wear masks, face shields, and/or gloves.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("employeesWearProtectiveEquipment")]
        public virtual System.Nullable<bool> EmployeesWearProtectiveEquipment { get; set; }

        /// <summary>Employees wear protective equipment exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("employeesWearProtectiveEquipmentException")]
        public virtual string EmployeesWearProtectiveEquipmentException { get; set; }

        /// <summary>Enhanced cleaning of guest rooms.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("guestRoomsEnhancedCleaning")]
        public virtual System.Nullable<bool> GuestRoomsEnhancedCleaning { get; set; }

        /// <summary>Guest rooms enhanced cleaning exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("guestRoomsEnhancedCleaningException")]
        public virtual string GuestRoomsEnhancedCleaningException { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Services and amenities for families and young guests.</summary>
    public class Families : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Babysitting. Child care that is offered by hotel staffers or coordinated by hotel staffers with local child
        /// care professionals. Can be free or for a fee.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("babysitting")]
        public virtual System.Nullable<bool> Babysitting { get; set; }

        /// <summary>Babysitting exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("babysittingException")]
        public virtual string BabysittingException { get; set; }

        /// <summary>
        /// Kids activities. Recreational options such as sports, films, crafts and games designed for the enjoyment of
        /// children and offered at the hotel. May or may not be supervised. May or may not be at a designated time or
        /// place. Cab be free or for a fee.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kidsActivities")]
        public virtual System.Nullable<bool> KidsActivities { get; set; }

        /// <summary>Kids activities exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kidsActivitiesException")]
        public virtual string KidsActivitiesException { get; set; }

        /// <summary>
        /// Kids club. An organized program of group activities held at the hotel and designed for the enjoyment of
        /// children. Facilitated by hotel staff (or staff procured by the hotel) in an area(s) designated for the
        /// purpose of entertaining children without their parents. May include games, outings, water sports, team
        /// sports, arts and crafts, and films. Usually has set hours. Can be free or for a fee. Also known as Kids Camp
        /// or Kids program.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kidsClub")]
        public virtual System.Nullable<bool> KidsClub { get; set; }

        /// <summary>Kids club exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kidsClubException")]
        public virtual string KidsClubException { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Meals, snacks, and beverages available at the property.</summary>
    public class FoodAndDrink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Bar. A designated room, lounge or area of an on-site restaurant with seating at a counter behind which a
        /// hotel staffer takes the guest's order and provides the requested alcoholic drink. Can be indoors or
        /// outdoors. Also known as Pub.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bar")]
        public virtual System.Nullable<bool> Bar { get; set; }

        /// <summary>Bar exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("barException")]
        public virtual string BarException { get; set; }

        /// <summary>Breakfast available. The morning meal is offered to all guests. Can be free or for a fee.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("breakfastAvailable")]
        public virtual System.Nullable<bool> BreakfastAvailable { get; set; }

        /// <summary>Breakfast available exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("breakfastAvailableException")]
        public virtual string BreakfastAvailableException { get; set; }

        /// <summary>
        /// Breakfast buffet. Breakfast meal service where guests serve themselves from a variety of dishes/foods that
        /// are put out on a table.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("breakfastBuffet")]
        public virtual System.Nullable<bool> BreakfastBuffet { get; set; }

        /// <summary>Breakfast buffet exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("breakfastBuffetException")]
        public virtual string BreakfastBuffetException { get; set; }

        /// <summary>
        /// Buffet. A type of meal where guests serve themselves from a variety of dishes/foods that are put out on a
        /// table. Includes lunch and/or dinner meals. A breakfast-only buffet is not sufficient.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buffet")]
        public virtual System.Nullable<bool> Buffet { get; set; }

        /// <summary>Buffet exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buffetException")]
        public virtual string BuffetException { get; set; }

        /// <summary>
        /// Dinner buffet. Dinner meal service where guests serve themselves from a variety of dishes/foods that are put
        /// out on a table.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dinnerBuffet")]
        public virtual System.Nullable<bool> DinnerBuffet { get; set; }

        /// <summary>Dinner buffet exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dinnerBuffetException")]
        public virtual string DinnerBuffetException { get; set; }

        /// <summary>
        /// Free breakfast. Breakfast is offered for free to all guests. Does not apply if limited to certain room
        /// packages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeBreakfast")]
        public virtual System.Nullable<bool> FreeBreakfast { get; set; }

        /// <summary>Free breakfast exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeBreakfastException")]
        public virtual string FreeBreakfastException { get; set; }

        /// <summary>
        /// Restaurant. A business onsite at the hotel that is open to the public as well as guests, and offers meals
        /// and beverages to consume at tables or counters. May or may not include table service. Also known as cafe,
        /// buffet, eatery. A "breakfast room" where the hotel serves breakfast only to guests (not the general public)
        /// does not count as a restaurant.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restaurant")]
        public virtual System.Nullable<bool> Restaurant { get; set; }

        /// <summary>Restaurant exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restaurantException")]
        public virtual string RestaurantException { get; set; }

        /// <summary>Restaurants count. The number of restaurants at the hotel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restaurantsCount")]
        public virtual System.Nullable<int> RestaurantsCount { get; set; }

        /// <summary>Restaurants count exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restaurantsCountException")]
        public virtual string RestaurantsCountException { get; set; }

        /// <summary>
        /// Room service. A hotel staffer delivers meals prepared onsite to a guest's room as per their request. May or
        /// may not be available during specific hours. Services should be available to all guests (not based on
        /// rate/room booked/reward program, etc).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roomService")]
        public virtual System.Nullable<bool> RoomService { get; set; }

        /// <summary>Room service exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roomServiceException")]
        public virtual string RoomServiceException { get; set; }

        /// <summary>
        /// Table service. A restaurant in which a staff member is assigned to a guest's table to take their order,
        /// deliver and clear away food, and deliver the bill, if applicable. Also known as sit-down restaurant.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableService")]
        public virtual System.Nullable<bool> TableService { get; set; }

        /// <summary>Table service exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableServiceException")]
        public virtual string TableServiceException { get; set; }

        /// <summary>24hr room service. Room service is available 24 hours a day.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("twentyFourHourRoomService")]
        public virtual System.Nullable<bool> TwentyFourHourRoomService { get; set; }

        /// <summary>24hr room service exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("twentyFourHourRoomServiceException")]
        public virtual string TwentyFourHourRoomServiceException { get; set; }

        /// <summary>
        /// Vending machine. A glass-fronted mechanized cabinet displaying and dispensing snacks and beverages for
        /// purchase by coins, paper money and/or credit cards.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vendingMachine")]
        public virtual System.Nullable<bool> VendingMachine { get; set; }

        /// <summary>Vending machine exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vendingMachineException")]
        public virtual string VendingMachineException { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for LodgingService.GetGoogleUpdatedLodging</summary>
    public class GetGoogleUpdatedLodgingResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The fields in the Lodging that have been updated by Google. Repeated field items are not
        /// individually specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diffMask")]
        public virtual object DiffMask { get; set; }

        /// <summary>Required. The Google updated Lodging.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lodging")]
        public virtual Lodging Lodging { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Features and available amenities in the guest unit.</summary>
    public class GuestUnitFeatures : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Bungalow or villa. An independent structure that is part of a hotel or resort that is rented to one party
        /// for a vacation stay. The hotel or resort may be completely comprised of bungalows or villas, or they may be
        /// one of several guestroom options. Guests in the bungalows or villas most often have the same, if not more,
        /// amenities and services offered to guests in other guestroom types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bungalowOrVilla")]
        public virtual System.Nullable<bool> BungalowOrVilla { get; set; }

        /// <summary>Bungalow or villa exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bungalowOrVillaException")]
        public virtual string BungalowOrVillaException { get; set; }

        /// <summary>
        /// Connecting unit available. A guestroom type that features access to an adjacent guestroom for the purpose of
        /// booking both rooms. Most often used by families who need more than one room to accommodate the number of
        /// people in their group.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectingUnitAvailable")]
        public virtual System.Nullable<bool> ConnectingUnitAvailable { get; set; }

        /// <summary>Connecting unit available exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectingUnitAvailableException")]
        public virtual string ConnectingUnitAvailableException { get; set; }

        /// <summary>
        /// Executive floor. A floor of the hotel where the guestrooms are only bookable by members of the hotel's
        /// frequent guest membership program. Benefits of this room class include access to a designated lounge which
        /// may or may not feature free breakfast, cocktails or other perks specific to members of the program.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executiveFloor")]
        public virtual System.Nullable<bool> ExecutiveFloor { get; set; }

        /// <summary>Executive floor exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executiveFloorException")]
        public virtual string ExecutiveFloorException { get; set; }

        /// <summary>
        /// Max adult occupants count. The total number of adult guests allowed to stay overnight in the guestroom.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxAdultOccupantsCount")]
        public virtual System.Nullable<int> MaxAdultOccupantsCount { get; set; }

        /// <summary>Max adult occupants count exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxAdultOccupantsCountException")]
        public virtual string MaxAdultOccupantsCountException { get; set; }

        /// <summary>
        /// Max child occupants count. The total number of children allowed to stay overnight in the room.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxChildOccupantsCount")]
        public virtual System.Nullable<int> MaxChildOccupantsCount { get; set; }

        /// <summary>Max child occupants count exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxChildOccupantsCountException")]
        public virtual string MaxChildOccupantsCountException { get; set; }

        /// <summary>
        /// Max occupants count. The total number of guests allowed to stay overnight in the guestroom.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxOccupantsCount")]
        public virtual System.Nullable<int> MaxOccupantsCount { get; set; }

        /// <summary>Max occupants count exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxOccupantsCountException")]
        public virtual string MaxOccupantsCountException { get; set; }

        /// <summary>
        /// Private home. A privately owned home (house, townhouse, apartment, cabin, bungalow etc) that may or not
        /// serve as the owner's residence, but is rented out in its entirety or by the room(s) to paying guest(s) for
        /// vacation stays. Not for lease-based, long-term residency.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateHome")]
        public virtual System.Nullable<bool> PrivateHome { get; set; }

        /// <summary>Private home exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateHomeException")]
        public virtual string PrivateHomeException { get; set; }

        /// <summary>
        /// Suite. A guestroom category that implies both a bedroom area and a separate living area. There may or may
        /// not be full walls and doors separating the two areas, but regardless, they are very distinct. Does not mean
        /// a couch or chair in a bedroom.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suite")]
        public virtual System.Nullable<bool> Suite { get; set; }

        /// <summary>Suite exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suiteException")]
        public virtual string SuiteException { get; set; }

        /// <summary>
        /// Tier. Classification of the unit based on available features/amenities. A non-standard tier is only
        /// permitted if at least one other unit type falls under the standard tier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tier")]
        public virtual string Tier { get; set; }

        /// <summary>Tier exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tierException")]
        public virtual string TierException { get; set; }

        /// <summary>Features available in the living areas in the guest unit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalLivingAreas")]
        public virtual LivingArea TotalLivingAreas { get; set; }

        /// <summary>Views available from the guest unit itself.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("views")]
        public virtual ViewsFromUnit Views { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A specific type of unit primarily defined by its features.</summary>
    public class GuestUnitType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Unit or room code identifiers for a single GuestUnitType. Each code must be unique within a
        /// Lodging instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("codes")]
        public virtual System.Collections.Generic.IList<string> Codes { get; set; }

        /// <summary>Features and available amenities of the GuestUnitType.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("features")]
        public virtual GuestUnitFeatures Features { get; set; }

        /// <summary>Required. Short, English label or name of the GuestUnitType. Target &lt;50 chars.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Health and safety measures implemented by the hotel during COVID-19.</summary>
    public class HealthAndSafety : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Enhanced cleaning measures implemented by the hotel during COVID-19.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enhancedCleaning")]
        public virtual EnhancedCleaning EnhancedCleaning { get; set; }

        /// <summary>Increased food safety measures implemented by the hotel during COVID-19.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("increasedFoodSafety")]
        public virtual IncreasedFoodSafety IncreasedFoodSafety { get; set; }

        /// <summary>Minimized contact measures implemented by the hotel during COVID-19.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimizedContact")]
        public virtual MinimizedContact MinimizedContact { get; set; }

        /// <summary>Personal protection measures implemented by the hotel during COVID-19.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("personalProtection")]
        public virtual PersonalProtection PersonalProtection { get; set; }

        /// <summary>Physical distancing measures implemented by the hotel during COVID-19.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("physicalDistancing")]
        public virtual PhysicalDistancing PhysicalDistancing { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Conveniences provided in guest units to facilitate an easier, more comfortable stay.</summary>
    public class Housekeeping : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Daily housekeeping. Guest units are cleaned by hotel staff daily during guest's stay.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dailyHousekeeping")]
        public virtual System.Nullable<bool> DailyHousekeeping { get; set; }

        /// <summary>Daily housekeeping exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dailyHousekeepingException")]
        public virtual string DailyHousekeepingException { get; set; }

        /// <summary>
        /// Housekeeping available. Guest units are cleaned by hotel staff during guest's stay. Schedule may vary from
        /// daily, weekly, or specific days of the week.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("housekeepingAvailable")]
        public virtual System.Nullable<bool> HousekeepingAvailable { get; set; }

        /// <summary>Housekeeping available exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("housekeepingAvailableException")]
        public virtual string HousekeepingAvailableException { get; set; }

        /// <summary>
        /// Turndown service. Hotel staff enters guest units to prepare the bed for sleep use. May or may not include
        /// some light housekeeping. May or may not include an evening snack or candy. Also known as evening service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("turndownService")]
        public virtual System.Nullable<bool> TurndownService { get; set; }

        /// <summary>Turndown service exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("turndownServiceException")]
        public virtual string TurndownServiceException { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Increased food safety measures implemented by the hotel during COVID-19.</summary>
    public class IncreasedFoodSafety : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional sanitation in dining areas.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diningAreasAdditionalSanitation")]
        public virtual System.Nullable<bool> DiningAreasAdditionalSanitation { get; set; }

        /// <summary>Dining areas additional sanitation exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diningAreasAdditionalSanitationException")]
        public virtual string DiningAreasAdditionalSanitationException { get; set; }

        /// <summary>Disposable flatware.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disposableFlatware")]
        public virtual System.Nullable<bool> DisposableFlatware { get; set; }

        /// <summary>Disposable flatware exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disposableFlatwareException")]
        public virtual string DisposableFlatwareException { get; set; }

        /// <summary>Additional safety measures during food prep and serving.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("foodPreparationAndServingAdditionalSafety")]
        public virtual System.Nullable<bool> FoodPreparationAndServingAdditionalSafety { get; set; }

        /// <summary>Food preparation and serving additional safety exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("foodPreparationAndServingAdditionalSafetyException")]
        public virtual string FoodPreparationAndServingAdditionalSafetyException { get; set; }

        /// <summary>Individually-packaged meals.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("individualPackagedMeals")]
        public virtual System.Nullable<bool> IndividualPackagedMeals { get; set; }

        /// <summary>Individual packaged meals exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("individualPackagedMealsException")]
        public virtual string IndividualPackagedMealsException { get; set; }

        /// <summary>Single-use menus.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("singleUseFoodMenus")]
        public virtual System.Nullable<bool> SingleUseFoodMenus { get; set; }

        /// <summary>Single use food menus exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("singleUseFoodMenusException")]
        public virtual string SingleUseFoodMenusException { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Language spoken by at least one staff member.</summary>
    public class LanguageSpoken : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The BCP-47 language code for the spoken language. Currently accepted codes: ar, de, en, es, fil,
        /// fr, hi, id, it, ja, ko, nl, pt, ru, vi, yue, zh.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>At least one member of the staff can speak the language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spoken")]
        public virtual System.Nullable<bool> Spoken { get; set; }

        /// <summary>Spoken exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spokenException")]
        public virtual string SpokenException { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An individual room, such as kitchen, bathroom, bedroom, within a bookable guest unit.</summary>
    public class LivingArea : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Accessibility features of the living area.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessibility")]
        public virtual LivingAreaAccessibility Accessibility { get; set; }

        /// <summary>Information about eating features in the living area.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eating")]
        public virtual LivingAreaEating Eating { get; set; }

        /// <summary>Features in the living area.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("features")]
        public virtual LivingAreaFeatures Features { get; set; }

        /// <summary>Information about the layout of the living area.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual LivingAreaLayout Layout { get; set; }

        /// <summary>Information about sleeping features in the living area.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sleeping")]
        public virtual LivingAreaSleeping Sleeping { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Accessibility features of the living area.</summary>
    public class LivingAreaAccessibility : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// ADA compliant unit. A guestroom designed to accommodate the physical challenges of a guest with mobility
        /// and/or auditory and/or visual issues, as determined by legislative policy. Usually features enlarged
        /// doorways, roll-in showers with seats, bathroom grab bars, and communication equipment for the hearing and
        /// sight challenged.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adaCompliantUnit")]
        public virtual System.Nullable<bool> AdaCompliantUnit { get; set; }

        /// <summary>ADA compliant unit exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adaCompliantUnitException")]
        public virtual string AdaCompliantUnitException { get; set; }

        /// <summary>Hearing-accessible doorbell. A visual indicator(s) of a knock or ring at the door.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hearingAccessibleDoorbell")]
        public virtual System.Nullable<bool> HearingAccessibleDoorbell { get; set; }

        /// <summary>Hearing-accessible doorbell exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hearingAccessibleDoorbellException")]
        public virtual string HearingAccessibleDoorbellException { get; set; }

        /// <summary>
        /// Hearing-accessible fire alarm. A device that gives warning of a fire through flashing lights.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hearingAccessibleFireAlarm")]
        public virtual System.Nullable<bool> HearingAccessibleFireAlarm { get; set; }

        /// <summary>Hearing-accessible fire alarm exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hearingAccessibleFireAlarmException")]
        public virtual string HearingAccessibleFireAlarmException { get; set; }

        /// <summary>
        /// Hearing-accessible unit. A guestroom designed to accommodate the physical challenges of a guest with
        /// auditory issues.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hearingAccessibleUnit")]
        public virtual System.Nullable<bool> HearingAccessibleUnit { get; set; }

        /// <summary>Hearing-accessible unit exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hearingAccessibleUnitException")]
        public virtual string HearingAccessibleUnitException { get; set; }

        /// <summary>
        /// Mobility-accessible bathtub. A bathtub that accomodates the physically challenged with additional railings
        /// or hand grips, a transfer seat or lift, and/or a door to enable walking into the tub.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobilityAccessibleBathtub")]
        public virtual System.Nullable<bool> MobilityAccessibleBathtub { get; set; }

        /// <summary>Mobility-accessible bathtub exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobilityAccessibleBathtubException")]
        public virtual string MobilityAccessibleBathtubException { get; set; }

        /// <summary>
        /// Mobility-accessible shower. A shower with an enlarged door or access point to accommodate a wheelchair or a
        /// waterproof seat for the physically challenged.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobilityAccessibleShower")]
        public virtual System.Nullable<bool> MobilityAccessibleShower { get; set; }

        /// <summary>Mobility-accessible shower exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobilityAccessibleShowerException")]
        public virtual string MobilityAccessibleShowerException { get; set; }

        /// <summary>
        /// Mobility-accessible toilet. A toilet with a higher seat, grab bars, and/or a larger area around it to
        /// accommodate the physically challenged.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobilityAccessibleToilet")]
        public virtual System.Nullable<bool> MobilityAccessibleToilet { get; set; }

        /// <summary>Mobility-accessible toilet exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobilityAccessibleToiletException")]
        public virtual string MobilityAccessibleToiletException { get; set; }

        /// <summary>
        /// Mobility-accessible unit. A guestroom designed to accommodate the physical challenges of a guest with
        /// mobility and/or auditory and/or visual issues. Usually features enlarged doorways, roll-in showers with
        /// seats, bathroom grab bars, and communication equipment for the hearing and sight challenged.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobilityAccessibleUnit")]
        public virtual System.Nullable<bool> MobilityAccessibleUnit { get; set; }

        /// <summary>Mobility-accessible unit exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobilityAccessibleUnitException")]
        public virtual string MobilityAccessibleUnitException { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about eating features in the living area.</summary>
    public class LivingAreaEating : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Coffee maker. An electric appliance that brews coffee by heating and forcing water through ground coffee.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("coffeeMaker")]
        public virtual System.Nullable<bool> CoffeeMaker { get; set; }

        /// <summary>Coffee maker exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("coffeeMakerException")]
        public virtual string CoffeeMakerException { get; set; }

        /// <summary>
        /// Cookware. Kitchen pots, pans and utensils used in connection with the preparation of food.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cookware")]
        public virtual System.Nullable<bool> Cookware { get; set; }

        /// <summary>Cookware exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cookwareException")]
        public virtual string CookwareException { get; set; }

        /// <summary>
        /// Dishwasher. A counter-height electrical cabinet containing racks for dirty dishware, cookware and cutlery,
        /// and a dispenser for soap built into the pull-down door. The cabinet is attached to the plumbing system to
        /// facilitate the automatic cleaning of its contents.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dishwasher")]
        public virtual System.Nullable<bool> Dishwasher { get; set; }

        /// <summary>Dishwasher exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dishwasherException")]
        public virtual string DishwasherException { get; set; }

        /// <summary>
        /// Indoor grill. Metal grates built into an indoor cooktop on which food is cooked over an open flame or
        /// electric heat source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indoorGrill")]
        public virtual System.Nullable<bool> IndoorGrill { get; set; }

        /// <summary>Indoor grill exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indoorGrillException")]
        public virtual string IndoorGrillException { get; set; }

        /// <summary>Kettle. A covered container with a handle and a spout used for boiling water.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kettle")]
        public virtual System.Nullable<bool> Kettle { get; set; }

        /// <summary>Kettle exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kettleException")]
        public virtual string KettleException { get; set; }

        /// <summary>
        /// Kitchen available. An area of the guestroom designated for the preparation and storage of food via the
        /// presence of a refrigerator, cook top, oven and sink, as well as cutlery, dishes and cookware. Usually
        /// includes small appliances such a coffee maker and a microwave. May or may not include an automatic
        /// dishwasher.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kitchenAvailable")]
        public virtual System.Nullable<bool> KitchenAvailable { get; set; }

        /// <summary>Kitchen available exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kitchenAvailableException")]
        public virtual string KitchenAvailableException { get; set; }

        /// <summary>
        /// Microwave. An electric oven that quickly cooks and heats food by microwave energy. Smaller than a standing
        /// or wall mounted oven. Usually placed on a kitchen counter, a shelf or tabletop or mounted above a cooktop.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("microwave")]
        public virtual System.Nullable<bool> Microwave { get; set; }

        /// <summary>Microwave exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("microwaveException")]
        public virtual string MicrowaveException { get; set; }

        /// <summary>
        /// Minibar. A small refrigerated cabinet in the guestroom containing bottles/cans of soft drinks, mini bottles
        /// of alcohol, and snacks. The items are most commonly available for a fee.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minibar")]
        public virtual System.Nullable<bool> Minibar { get; set; }

        /// <summary>Minibar exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minibarException")]
        public virtual string MinibarException { get; set; }

        /// <summary>
        /// Outdoor grill. Metal grates on which food is cooked over an open flame or electric heat source. Part of an
        /// outdoor apparatus that supports the grates. Also known as barbecue grill or barbecue.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outdoorGrill")]
        public virtual System.Nullable<bool> OutdoorGrill { get; set; }

        /// <summary>Outdoor grill exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outdoorGrillException")]
        public virtual string OutdoorGrillException { get; set; }

        /// <summary>
        /// Oven. A temperature controlled, heated metal cabinet powered by gas or electricity in which food is placed
        /// for the purpose of cooking or reheating.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oven")]
        public virtual System.Nullable<bool> Oven { get; set; }

        /// <summary>Oven exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ovenException")]
        public virtual string OvenException { get; set; }

        /// <summary>
        /// Refrigerator. A large, climate-controlled electrical cabinet with vertical doors. Built for the purpose of
        /// chilling and storing perishable foods.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refrigerator")]
        public virtual System.Nullable<bool> Refrigerator { get; set; }

        /// <summary>Refrigerator exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refrigeratorException")]
        public virtual string RefrigeratorException { get; set; }

        /// <summary>
        /// Sink. A basin with a faucet attached to a water source and used for the purpose of washing and rinsing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sink")]
        public virtual System.Nullable<bool> Sink { get; set; }

        /// <summary>Sink exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sinkException")]
        public virtual string SinkException { get; set; }

        /// <summary>
        /// Snackbar. A small cabinet in the guestroom containing snacks. The items are most commonly available for a
        /// fee.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snackbar")]
        public virtual System.Nullable<bool> Snackbar { get; set; }

        /// <summary>Snackbar exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snackbarException")]
        public virtual string SnackbarException { get; set; }

        /// <summary>
        /// Stove. A kitchen appliance powered by gas or electricity for the purpose of creating a flame or hot surface
        /// on which pots of food can be cooked. Also known as cooktop or hob.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stove")]
        public virtual System.Nullable<bool> Stove { get; set; }

        /// <summary>Stove exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stoveException")]
        public virtual string StoveException { get; set; }

        /// <summary>Tea station. A small area with the supplies needed to heat water and make tea.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("teaStation")]
        public virtual System.Nullable<bool> TeaStation { get; set; }

        /// <summary>Tea station exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("teaStationException")]
        public virtual string TeaStationException { get; set; }

        /// <summary>
        /// Toaster. A small, temperature controlled electric appliance with rectangular slots at the top that are lined
        /// with heated coils for the purpose of browning slices of bread products.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toaster")]
        public virtual System.Nullable<bool> Toaster { get; set; }

        /// <summary>Toaster exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toasterException")]
        public virtual string ToasterException { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Features in the living area.</summary>
    public class LivingAreaFeatures : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Air conditioning. An electrical machine used to cool the temperature of the guestroom.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("airConditioning")]
        public virtual System.Nullable<bool> AirConditioning { get; set; }

        /// <summary>Air conditioning exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("airConditioningException")]
        public virtual string AirConditioningException { get; set; }

        /// <summary>
        /// Bathtub. A fixed plumbing feature set on the floor and consisting of a large container that accommodates the
        /// body of an adult for the purpose of seated bathing. Includes knobs or fixtures to control the temperature of
        /// the water, a faucet through which the water flows, and a drain that can be closed for filling and opened for
        /// draining.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bathtub")]
        public virtual System.Nullable<bool> Bathtub { get; set; }

        /// <summary>Bathtub exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bathtubException")]
        public virtual string BathtubException { get; set; }

        /// <summary>
        /// Bidet. A plumbing fixture attached to a toilet or a low, fixed sink designed for the purpose of washing
        /// after toilet use.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bidet")]
        public virtual System.Nullable<bool> Bidet { get; set; }

        /// <summary>Bidet exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bidetException")]
        public virtual string BidetException { get; set; }

        /// <summary>Dryer. An electrical machine designed to dry clothing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dryer")]
        public virtual System.Nullable<bool> Dryer { get; set; }

        /// <summary>Dryer exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dryerException")]
        public virtual string DryerException { get; set; }

        /// <summary>
        /// Electronic room key. A card coded by the check-in computer that is read by the lock on the hotel guestroom
        /// door to allow for entry.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("electronicRoomKey")]
        public virtual System.Nullable<bool> ElectronicRoomKey { get; set; }

        /// <summary>Electronic room key exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("electronicRoomKeyException")]
        public virtual string ElectronicRoomKeyException { get; set; }

        /// <summary>
        /// Fireplace. A framed opening (aka hearth) at the base of a chimney in which logs or an electrical fire
        /// feature are burned to provide a relaxing ambiance or to heat the room. Often made of bricks or stone.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fireplace")]
        public virtual System.Nullable<bool> Fireplace { get; set; }

        /// <summary>Fireplace exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fireplaceException")]
        public virtual string FireplaceException { get; set; }

        /// <summary>
        /// Hairdryer. A handheld electric appliance that blows temperature-controlled air for the purpose of drying wet
        /// hair. Can be mounted to a bathroom wall or a freestanding device stored in the guestroom's bathroom or
        /// closet.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hairdryer")]
        public virtual System.Nullable<bool> Hairdryer { get; set; }

        /// <summary>Hairdryer exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hairdryerException")]
        public virtual string HairdryerException { get; set; }

        /// <summary>Heating. An electrical machine used to warm the temperature of the guestroom.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heating")]
        public virtual System.Nullable<bool> Heating { get; set; }

        /// <summary>Heating exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heatingException")]
        public virtual string HeatingException { get; set; }

        /// <summary>
        /// In-unit safe. A strong fireproof cabinet with a programmable lock, used for the protected storage of
        /// valuables in a guestroom. Often built into a closet.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inunitSafe")]
        public virtual System.Nullable<bool> InunitSafe { get; set; }

        /// <summary>In-unit safe exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inunitSafeException")]
        public virtual string InunitSafeException { get; set; }

        /// <summary>
        /// In-unit Wifi available. Guests can wirelessly connect to the Internet in the guestroom. Can be free or for a
        /// fee.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inunitWifiAvailable")]
        public virtual System.Nullable<bool> InunitWifiAvailable { get; set; }

        /// <summary>In-unit Wifi available exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inunitWifiAvailableException")]
        public virtual string InunitWifiAvailableException { get; set; }

        /// <summary>
        /// Ironing equipment. A device, usually with a flat metal base, that is heated to smooth, finish, or press
        /// clothes and a flat, padded, cloth-covered surface on which the clothes are worked.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ironingEquipment")]
        public virtual System.Nullable<bool> IroningEquipment { get; set; }

        /// <summary>Ironing equipment exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ironingEquipmentException")]
        public virtual string IroningEquipmentException { get; set; }

        /// <summary>
        /// Pay per view movies. Televisions with channels that offer films that can be viewed for a fee, and have an
        /// interface to allow the viewer to accept the terms and approve payment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payPerViewMovies")]
        public virtual System.Nullable<bool> PayPerViewMovies { get; set; }

        /// <summary>Pay per view movies exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payPerViewMoviesException")]
        public virtual string PayPerViewMoviesException { get; set; }

        /// <summary>
        /// Private bathroom. A bathroom designated for the express use of the guests staying in a specific guestroom.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateBathroom")]
        public virtual System.Nullable<bool> PrivateBathroom { get; set; }

        /// <summary>Private bathroom exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateBathroomException")]
        public virtual string PrivateBathroomException { get; set; }

        /// <summary>
        /// Shower. A fixed plumbing fixture for standing bathing that features a tall spray spout or faucet through
        /// which water flows, a knob or knobs that control the water's temperature, and a drain in the floor.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shower")]
        public virtual System.Nullable<bool> Shower { get; set; }

        /// <summary>Shower exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("showerException")]
        public virtual string ShowerException { get; set; }

        /// <summary>
        /// Toilet. A fixed bathroom feature connected to a sewer or septic system and consisting of a water-flushed
        /// bowl with a seat, as well as a device that elicites the water-flushing action. Used for the process and
        /// disposal of human waste.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toilet")]
        public virtual System.Nullable<bool> Toilet { get; set; }

        /// <summary>Toilet exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toiletException")]
        public virtual string ToiletException { get; set; }

        /// <summary>TV. A television is available in the guestroom.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tv")]
        public virtual System.Nullable<bool> Tv { get; set; }

        /// <summary>
        /// TV casting. A television equipped with a device through which the video entertainment accessed on a personal
        /// computer, phone or tablet can be wirelessly delivered to and viewed on the guestroom's television.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tvCasting")]
        public virtual System.Nullable<bool> TvCasting { get; set; }

        /// <summary>TV exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tvCastingException")]
        public virtual string TvCastingException { get; set; }

        /// <summary>TV exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tvException")]
        public virtual string TvException { get; set; }

        /// <summary>
        /// TV streaming. Televisions that embed a range of web-based apps to allow for watching media from those apps.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tvStreaming")]
        public virtual System.Nullable<bool> TvStreaming { get; set; }

        /// <summary>TV streaming exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tvStreamingException")]
        public virtual string TvStreamingException { get; set; }

        /// <summary>
        /// Universal power adapters. A power supply for electronic devices which plugs into a wall for the purpose of
        /// converting AC to a single DC voltage. Also know as AC adapter or charger.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("universalPowerAdapters")]
        public virtual System.Nullable<bool> UniversalPowerAdapters { get; set; }

        /// <summary>Universal power adapters exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("universalPowerAdaptersException")]
        public virtual string UniversalPowerAdaptersException { get; set; }

        /// <summary>
        /// Washer. An electrical machine connected to a running water source designed to launder clothing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("washer")]
        public virtual System.Nullable<bool> Washer { get; set; }

        /// <summary>Washer exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("washerException")]
        public virtual string WasherException { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the layout of the living area.</summary>
    public class LivingAreaLayout : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Balcony. An outdoor platform attached to a building and surrounded by a short wall, fence or other safety
        /// railing. The balcony is accessed through a door in a guestroom or suite and is for use by the guest staying
        /// in that room. May or may not include seating or outdoor furniture. Is not located on the ground floor. Also
        /// lanai.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("balcony")]
        public virtual System.Nullable<bool> Balcony { get; set; }

        /// <summary>Balcony exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("balconyException")]
        public virtual string BalconyException { get; set; }

        /// <summary>
        /// Living area sq meters. The measurement in meters of the area of a guestroom's living space.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("livingAreaSqMeters")]
        public virtual System.Nullable<float> LivingAreaSqMeters { get; set; }

        /// <summary>Living area sq meters exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("livingAreaSqMetersException")]
        public virtual string LivingAreaSqMetersException { get; set; }

        /// <summary>
        /// Loft. A three-walled upper area accessed by stairs or a ladder that overlooks the lower area of a room.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loft")]
        public virtual System.Nullable<bool> Loft { get; set; }

        /// <summary>Loft exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loftException")]
        public virtual string LoftException { get; set; }

        /// <summary>
        /// Non smoking. A guestroom in which the smoking of cigarettes, cigars and pipes is prohibited.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nonSmoking")]
        public virtual System.Nullable<bool> NonSmoking { get; set; }

        /// <summary>Non smoking exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nonSmokingException")]
        public virtual string NonSmokingException { get; set; }

        /// <summary>
        /// Patio. A paved, outdoor area with seating attached to and accessed through a ground-floor guestroom for use
        /// by the occupants of the guestroom.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("patio")]
        public virtual System.Nullable<bool> Patio { get; set; }

        /// <summary>Patio exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("patioException")]
        public virtual string PatioException { get; set; }

        /// <summary>Stairs. There are steps leading from one level or story to another in the unit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stairs")]
        public virtual System.Nullable<bool> Stairs { get; set; }

        /// <summary>Stairs exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stairsException")]
        public virtual string StairsException { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about sleeping features in the living area.</summary>
    public class LivingAreaSleeping : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Beds count. The number of permanent beds present in a guestroom. Does not include rollaway beds, cribs or
        /// sofabeds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bedsCount")]
        public virtual System.Nullable<int> BedsCount { get; set; }

        /// <summary>Beds count exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bedsCountException")]
        public virtual string BedsCountException { get; set; }

        /// <summary>
        /// Bunk beds count. The number of furniture pieces in which one framed mattress is fixed directly above another
        /// by means of a physical frame. This allows one person(s) to sleep in the bottom bunk and one person(s) to
        /// sleep in the top bunk. Also known as double decker bed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bunkBedsCount")]
        public virtual System.Nullable<int> BunkBedsCount { get; set; }

        /// <summary>Bunk beds count exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bunkBedsCountException")]
        public virtual string BunkBedsCountException { get; set; }

        /// <summary>
        /// Cribs count. The number of small beds for an infant or toddler that the guestroom can obtain. The bed is
        /// surrounded by a high railing to prevent the child from falling or climbing out of the bed
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cribsCount")]
        public virtual System.Nullable<int> CribsCount { get; set; }

        /// <summary>Cribs count exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cribsCountException")]
        public virtual string CribsCountException { get; set; }

        /// <summary>
        /// Double beds count. The number of medium beds measuring 53"W x 75"L (135cm x 191cm). Also known as full size
        /// bed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doubleBedsCount")]
        public virtual System.Nullable<int> DoubleBedsCount { get; set; }

        /// <summary>Double beds count exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doubleBedsCountException")]
        public virtual string DoubleBedsCountException { get; set; }

        /// <summary>
        /// Feather pillows. The option for guests to obtain bed pillows that are stuffed with the feathers and down of
        /// ducks or geese.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("featherPillows")]
        public virtual System.Nullable<bool> FeatherPillows { get; set; }

        /// <summary>Feather pillows exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("featherPillowsException")]
        public virtual string FeatherPillowsException { get; set; }

        /// <summary>
        /// Hypoallergenic bedding. Bedding such as linens, pillows, mattress covers and/or mattresses that are made of
        /// materials known to be resistant to allergens such as mold, dust and dander.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hypoallergenicBedding")]
        public virtual System.Nullable<bool> HypoallergenicBedding { get; set; }

        /// <summary>Hypoallergenic bedding exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hypoallergenicBeddingException")]
        public virtual string HypoallergenicBeddingException { get; set; }

        /// <summary>
        /// King beds count. The number of large beds measuring 76"W x 80"L (193cm x 102cm). Most often meant to
        /// accompany two people. Includes California king and super king.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kingBedsCount")]
        public virtual System.Nullable<int> KingBedsCount { get; set; }

        /// <summary>King beds count exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kingBedsCountException")]
        public virtual string KingBedsCountException { get; set; }

        /// <summary>
        /// Memory foam pillows. The option for guests to obtain bed pillows that are stuffed with a man-made foam that
        /// responds to body heat by conforming to the body closely, and then recovers its shape when the pillow cools
        /// down.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryFoamPillows")]
        public virtual System.Nullable<bool> MemoryFoamPillows { get; set; }

        /// <summary>Memory foam pillows exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryFoamPillowsException")]
        public virtual string MemoryFoamPillowsException { get; set; }

        /// <summary>
        /// Other beds count. The number of beds that are not standard mattress and boxspring setups such as Japanese
        /// tatami mats, trundle beds, air mattresses and cots.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("otherBedsCount")]
        public virtual System.Nullable<int> OtherBedsCount { get; set; }

        /// <summary>Other beds count exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("otherBedsCountException")]
        public virtual string OtherBedsCountException { get; set; }

        /// <summary>Queen beds count. The number of medium-large beds measuring 60"W x 80"L (152cm x 102cm).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queenBedsCount")]
        public virtual System.Nullable<int> QueenBedsCount { get; set; }

        /// <summary>Queen beds count exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queenBedsCountException")]
        public virtual string QueenBedsCountException { get; set; }

        /// <summary>
        /// Roll away beds count. The number of mattresses on wheeled frames that can be folded in half and rolled away
        /// for easy storage that the guestroom can obtain upon request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollAwayBedsCount")]
        public virtual System.Nullable<int> RollAwayBedsCount { get; set; }

        /// <summary>Roll away beds count exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollAwayBedsCountException")]
        public virtual string RollAwayBedsCountException { get; set; }

        /// <summary>
        /// Single or twin count beds. The number of smaller beds measuring 38"W x 75"L (97cm x 191cm) that can
        /// accommodate one adult.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("singleOrTwinBedsCount")]
        public virtual System.Nullable<int> SingleOrTwinBedsCount { get; set; }

        /// <summary>Single or twin beds count exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("singleOrTwinBedsCountException")]
        public virtual string SingleOrTwinBedsCountException { get; set; }

        /// <summary>
        /// Sofa beds count. The number of specially designed sofas that can be made to serve as a bed by lowering its
        /// hinged upholstered back to horizontal position or by pulling out a concealed mattress.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sofaBedsCount")]
        public virtual System.Nullable<int> SofaBedsCount { get; set; }

        /// <summary>Sofa beds count exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sofaBedsCountException")]
        public virtual string SofaBedsCountException { get; set; }

        /// <summary>
        /// Synthetic pillows. The option for guests to obtain bed pillows stuffed with polyester material crafted to
        /// reproduce the feel of a pillow stuffed with down and feathers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syntheticPillows")]
        public virtual System.Nullable<bool> SyntheticPillows { get; set; }

        /// <summary>Synthetic pillows exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syntheticPillowsException")]
        public virtual string SyntheticPillowsException { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Lodging of a location that provides accomodations.</summary>
    public class Lodging : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Physical adaptations made to the property in consideration of varying levels of human physical ability.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessibility")]
        public virtual Accessibility Accessibility { get; set; }

        /// <summary>Amenities and features related to leisure and play.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activities")]
        public virtual Activities Activities { get; set; }

        /// <summary>Output only. All units on the property have at least these attributes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allUnits")]
        public virtual GuestUnitFeatures AllUnits { get; set; }

        /// <summary>Features of the property of specific interest to the business traveler.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("business")]
        public virtual Business Business { get; set; }

        /// <summary>Features of the shared living areas available in this Lodging.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonLivingArea")]
        public virtual LivingArea CommonLivingArea { get; set; }

        /// <summary>The ways in which the property provides guests with the ability to access the internet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectivity")]
        public virtual Connectivity Connectivity { get; set; }

        /// <summary>Services and amenities for families and young guests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("families")]
        public virtual Families Families { get; set; }

        /// <summary>Meals, snacks, and beverages available at the property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("foodAndDrink")]
        public virtual FoodAndDrink FoodAndDrink { get; set; }

        /// <summary>Individual GuestUnitTypes that are available in this Lodging.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("guestUnits")]
        public virtual System.Collections.Generic.IList<GuestUnitType> GuestUnits { get; set; }

        /// <summary>Health and safety measures implemented by the hotel during COVID-19.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthAndSafety")]
        public virtual HealthAndSafety HealthAndSafety { get; set; }

        /// <summary>Conveniences provided in guest units to facilitate an easier, more comfortable stay.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("housekeeping")]
        public virtual Housekeeping Housekeeping { get; set; }

        /// <summary>Required. Metadata for the lodging.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual LodgingMetadata Metadata { get; set; }

        /// <summary>
        /// Required. Google identifier for this location in the form: `locations/{location_id}/lodging`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Parking options at the property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parking")]
        public virtual Parking Parking { get; set; }

        /// <summary>Policies regarding guest-owned animals.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pets")]
        public virtual Pets Pets { get; set; }

        /// <summary>Property rules that impact guests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policies")]
        public virtual Policies Policies { get; set; }

        /// <summary>Swimming pool or recreational water facilities available at the hotel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pools")]
        public virtual Pools Pools { get; set; }

        /// <summary>General factual information about the property's physical structure and important dates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual Property Property { get; set; }

        /// <summary>
        /// Conveniences or help provided by the property to facilitate an easier, more comfortable stay.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("services")]
        public virtual Services Services { get; set; }

        /// <summary>Output only. Some units on the property have as much as these attributes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("someUnits")]
        public virtual GuestUnitFeatures SomeUnits { get; set; }

        /// <summary>Sustainability practices implemented at the hotel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sustainability")]
        public virtual Sustainability Sustainability { get; set; }

        /// <summary>Vehicles or vehicular services facilitated or owned by the property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transportation")]
        public virtual Transportation Transportation { get; set; }

        /// <summary>Guest facilities at the property to promote or maintain health, beauty, and fitness.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wellness")]
        public virtual Wellness Wellness { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for the Lodging.</summary>
    public class LodgingMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The latest time at which the Lodging data is asserted to be true in the real world. This is not
        /// necessarily the time at which the request is made.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Minimized contact measures implemented by the hotel during COVID-19.</summary>
    public class MinimizedContact : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>No-contact check-in and check-out.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactlessCheckinCheckout")]
        public virtual System.Nullable<bool> ContactlessCheckinCheckout { get; set; }

        /// <summary>Contactless check-in check-out exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactlessCheckinCheckoutException")]
        public virtual string ContactlessCheckinCheckoutException { get; set; }

        /// <summary>Keyless mobile entry to guest rooms.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("digitalGuestRoomKeys")]
        public virtual System.Nullable<bool> DigitalGuestRoomKeys { get; set; }

        /// <summary>Digital guest room keys exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("digitalGuestRoomKeysException")]
        public virtual string DigitalGuestRoomKeysException { get; set; }

        /// <summary>Housekeeping scheduled by request only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("housekeepingScheduledRequestOnly")]
        public virtual System.Nullable<bool> HousekeepingScheduledRequestOnly { get; set; }

        /// <summary>Housekeeping scheduled request only exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("housekeepingScheduledRequestOnlyException")]
        public virtual string HousekeepingScheduledRequestOnlyException { get; set; }

        /// <summary>High-touch items, such as magazines, removed from common areas.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noHighTouchItemsCommonAreas")]
        public virtual System.Nullable<bool> NoHighTouchItemsCommonAreas { get; set; }

        /// <summary>No high touch items common areas exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noHighTouchItemsCommonAreasException")]
        public virtual string NoHighTouchItemsCommonAreasException { get; set; }

        /// <summary>High-touch items, such as decorative pillows, removed from guest rooms.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noHighTouchItemsGuestRooms")]
        public virtual System.Nullable<bool> NoHighTouchItemsGuestRooms { get; set; }

        /// <summary>No high touch items guest rooms exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noHighTouchItemsGuestRoomsException")]
        public virtual string NoHighTouchItemsGuestRoomsException { get; set; }

        /// <summary>Plastic key cards are disinfected or discarded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plasticKeycardsDisinfected")]
        public virtual System.Nullable<bool> PlasticKeycardsDisinfected { get; set; }

        /// <summary>Plastic keycards disinfected exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plasticKeycardsDisinfectedException")]
        public virtual string PlasticKeycardsDisinfectedException { get; set; }

        /// <summary>Buffer maintained between room bookings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roomBookingsBuffer")]
        public virtual System.Nullable<bool> RoomBookingsBuffer { get; set; }

        /// <summary>Room bookings buffer exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roomBookingsBufferException")]
        public virtual string RoomBookingsBufferException { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Parking options at the property.</summary>
    public class Parking : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Electric car charging stations. Electric power stations, usually located outdoors, into which guests plug
        /// their electric cars to receive a charge.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("electricCarChargingStations")]
        public virtual System.Nullable<bool> ElectricCarChargingStations { get; set; }

        /// <summary>Electric car charging stations exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("electricCarChargingStationsException")]
        public virtual string ElectricCarChargingStationsException { get; set; }

        /// <summary>
        /// Free parking. The hotel allows the cars of guests to be parked for free. Parking facility may be an outdoor
        /// lot or an indoor garage, but must be onsite. Nearby parking does not apply. Parking may be performed by the
        /// guest or by hotel staff. Free parking must be available to all guests (limited conditions does not apply).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeParking")]
        public virtual System.Nullable<bool> FreeParking { get; set; }

        /// <summary>Free parking exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeParkingException")]
        public virtual string FreeParkingException { get; set; }

        /// <summary>
        /// Free self parking. Guests park their own cars for free. Parking facility may be an outdoor lot or an indoor
        /// garage, but must be onsite. Nearby parking does not apply.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeSelfParking")]
        public virtual System.Nullable<bool> FreeSelfParking { get; set; }

        /// <summary>Free self parking exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeSelfParkingException")]
        public virtual string FreeSelfParkingException { get; set; }

        /// <summary>
        /// Free valet parking. Hotel staff member parks the cars of guests. Parking with this service is free.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeValetParking")]
        public virtual System.Nullable<bool> FreeValetParking { get; set; }

        /// <summary>Free valet parking exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeValetParkingException")]
        public virtual string FreeValetParkingException { get; set; }

        /// <summary>
        /// Parking available. The hotel allows the cars of guests to be parked. Can be free or for a fee. Parking
        /// facility may be an outdoor lot or an indoor garage, but must be onsite. Nearby parking does not apply.
        /// Parking may be performed by the guest or by hotel staff.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parkingAvailable")]
        public virtual System.Nullable<bool> ParkingAvailable { get; set; }

        /// <summary>Parking available exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parkingAvailableException")]
        public virtual string ParkingAvailableException { get; set; }

        /// <summary>
        /// Self parking available. Guests park their own cars. Parking facility may be an outdoor lot or an indoor
        /// garage, but must be onsite. Nearby parking does not apply. Can be free or for a fee.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfParkingAvailable")]
        public virtual System.Nullable<bool> SelfParkingAvailable { get; set; }

        /// <summary>Self parking available exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfParkingAvailableException")]
        public virtual string SelfParkingAvailableException { get; set; }

        /// <summary>
        /// Valet parking available. Hotel staff member parks the cars of guests. Parking with this service can be free
        /// or for a fee.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valetParkingAvailable")]
        public virtual System.Nullable<bool> ValetParkingAvailable { get; set; }

        /// <summary>Valet parking available exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valetParkingAvailableException")]
        public virtual string ValetParkingAvailableException { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Forms of payment accepted at the property.</summary>
    public class PaymentOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Cash. The hotel accepts payment by paper/coin currency.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cash")]
        public virtual System.Nullable<bool> Cash { get; set; }

        /// <summary>Cash exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cashException")]
        public virtual string CashException { get; set; }

        /// <summary>
        /// Cheque. The hotel accepts a printed document issued by the guest's bank in the guest's name as a form of
        /// payment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cheque")]
        public virtual System.Nullable<bool> Cheque { get; set; }

        /// <summary>Cheque exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chequeException")]
        public virtual string ChequeException { get; set; }

        /// <summary>
        /// Credit card. The hotel accepts payment by a card issued by a bank or credit card company. Also known as
        /// charge card, debit card, bank card, or charge plate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creditCard")]
        public virtual System.Nullable<bool> CreditCard { get; set; }

        /// <summary>Credit card exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creditCardException")]
        public virtual string CreditCardException { get; set; }

        /// <summary>
        /// Debit card. The hotel accepts a bank-issued card that immediately deducts the charged funds from the guest's
        /// bank account upon processing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("debitCard")]
        public virtual System.Nullable<bool> DebitCard { get; set; }

        /// <summary>Debit card exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("debitCardException")]
        public virtual string DebitCardException { get; set; }

        /// <summary>
        /// Mobile nfc. The hotel has the compatible computer hardware terminal that reads and charges a payment app on
        /// the guest's smartphone without requiring the two devices to make physical contact. Also known as Apple Pay,
        /// Google Pay, Samsung Pay.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileNfc")]
        public virtual System.Nullable<bool> MobileNfc { get; set; }

        /// <summary>Mobile nfc exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileNfcException")]
        public virtual string MobileNfcException { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Personal protection measures implemented by the hotel during COVID-19.</summary>
    public class PersonalProtection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Hand-sanitizer and/or sanitizing wipes are offered in common areas.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonAreasOfferSanitizingItems")]
        public virtual System.Nullable<bool> CommonAreasOfferSanitizingItems { get; set; }

        /// <summary>Common areas offer sanitizing items exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonAreasOfferSanitizingItemsException")]
        public virtual string CommonAreasOfferSanitizingItemsException { get; set; }

        /// <summary>Masks required on the property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("faceMaskRequired")]
        public virtual System.Nullable<bool> FaceMaskRequired { get; set; }

        /// <summary>Face mask required exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("faceMaskRequiredException")]
        public virtual string FaceMaskRequiredException { get; set; }

        /// <summary>In-room hygiene kits with masks, hand sanitizer, and/or antibacterial wipes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("guestRoomHygieneKitsAvailable")]
        public virtual System.Nullable<bool> GuestRoomHygieneKitsAvailable { get; set; }

        /// <summary>Guest room hygiene kits available exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("guestRoomHygieneKitsAvailableException")]
        public virtual string GuestRoomHygieneKitsAvailableException { get; set; }

        /// <summary>Masks and/or gloves available for guests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protectiveEquipmentAvailable")]
        public virtual System.Nullable<bool> ProtectiveEquipmentAvailable { get; set; }

        /// <summary>Protective equipment available exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protectiveEquipmentAvailableException")]
        public virtual string ProtectiveEquipmentAvailableException { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Policies regarding guest-owned animals.</summary>
    public class Pets : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Cats allowed. Domesticated felines are permitted at the property and allowed to stay in the guest room of
        /// their owner. May or may not require a fee.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("catsAllowed")]
        public virtual System.Nullable<bool> CatsAllowed { get; set; }

        /// <summary>Cats allowed exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("catsAllowedException")]
        public virtual string CatsAllowedException { get; set; }

        /// <summary>
        /// Dogs allowed. Domesticated canines are permitted at the property and allowed to stay in the guest room of
        /// their owner. May or may not require a fee.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dogsAllowed")]
        public virtual System.Nullable<bool> DogsAllowed { get; set; }

        /// <summary>Dogs allowed exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dogsAllowedException")]
        public virtual string DogsAllowedException { get; set; }

        /// <summary>
        /// Pets allowed. Household animals are allowed at the property and in the specific guest room of their owner.
        /// May or may not include dogs, cats, reptiles and/or fish. May or may not require a fee. Service animals are
        /// not considered to be pets, so not governed by this policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("petsAllowed")]
        public virtual System.Nullable<bool> PetsAllowed { get; set; }

        /// <summary>Pets allowed exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("petsAllowedException")]
        public virtual string PetsAllowedException { get; set; }

        /// <summary>
        /// Pets allowed free. Household animals are allowed at the property and in the specific guest room of their
        /// owner for free. May or may not include dogs, cats, reptiles, and/or fish.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("petsAllowedFree")]
        public virtual System.Nullable<bool> PetsAllowedFree { get; set; }

        /// <summary>Pets allowed free exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("petsAllowedFreeException")]
        public virtual string PetsAllowedFreeException { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Physical distancing measures implemented by the hotel during COVID-19.</summary>
    public class PhysicalDistancing : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Common areas arranged to maintain physical distancing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonAreasPhysicalDistancingArranged")]
        public virtual System.Nullable<bool> CommonAreasPhysicalDistancingArranged { get; set; }

        /// <summary>Common areas physical distancing arranged exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonAreasPhysicalDistancingArrangedException")]
        public virtual string CommonAreasPhysicalDistancingArrangedException { get; set; }

        /// <summary>Physical distancing required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("physicalDistancingRequired")]
        public virtual System.Nullable<bool> PhysicalDistancingRequired { get; set; }

        /// <summary>Physical distancing required exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("physicalDistancingRequiredException")]
        public virtual string PhysicalDistancingRequiredException { get; set; }

        /// <summary>Safety dividers at front desk and other locations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("safetyDividers")]
        public virtual System.Nullable<bool> SafetyDividers { get; set; }

        /// <summary>Safety dividers exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("safetyDividersException")]
        public virtual string SafetyDividersException { get; set; }

        /// <summary>Guest occupancy limited within shared facilities.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sharedAreasLimitedOccupancy")]
        public virtual System.Nullable<bool> SharedAreasLimitedOccupancy { get; set; }

        /// <summary>Shared areas limited occupancy exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sharedAreasLimitedOccupancyException")]
        public virtual string SharedAreasLimitedOccupancyException { get; set; }

        /// <summary>Private spaces designated in spa and wellness areas.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wellnessAreasHavePrivateSpaces")]
        public virtual System.Nullable<bool> WellnessAreasHavePrivateSpaces { get; set; }

        /// <summary>Wellness areas have private spaces exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wellnessAreasHavePrivateSpacesException")]
        public virtual string WellnessAreasHavePrivateSpacesException { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Property rules that impact guests.</summary>
    public class Policies : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// All inclusive available. The hotel offers a rate option that includes the cost of the room, meals,
        /// activities, and other amenities that might otherwise be charged separately.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allInclusiveAvailable")]
        public virtual System.Nullable<bool> AllInclusiveAvailable { get; set; }

        /// <summary>All inclusive available exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allInclusiveAvailableException")]
        public virtual string AllInclusiveAvailableException { get; set; }

        /// <summary>
        /// All inclusive only. The only rate option offered by the hotel is a rate that includes the cost of the room,
        /// meals, activities and other amenities that might otherwise be charged separately.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allInclusiveOnly")]
        public virtual System.Nullable<bool> AllInclusiveOnly { get; set; }

        /// <summary>All inclusive only exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allInclusiveOnlyException")]
        public virtual string AllInclusiveOnlyException { get; set; }

        /// <summary>
        /// Check-in time. The time of the day at which the hotel begins providing guests access to their unit at the
        /// beginning of their stay.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checkinTime")]
        public virtual TimeOfDay CheckinTime { get; set; }

        /// <summary>Check-in time exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checkinTimeException")]
        public virtual string CheckinTimeException { get; set; }

        /// <summary>
        /// Check-out time. The time of the day on the last day of a guest's reserved stay at which the guest must
        /// vacate their room and settle their bill. Some hotels may offer late or early check out for a fee.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checkoutTime")]
        public virtual TimeOfDay CheckoutTime { get; set; }

        /// <summary>Check-out time exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checkoutTimeException")]
        public virtual string CheckoutTimeException { get; set; }

        /// <summary>
        /// Kids stay free. The children of guests are allowed to stay in the room/suite of a parent or adult without an
        /// additional fee. The policy may or may not stipulate a limit of the child's age or the overall number of
        /// children allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kidsStayFree")]
        public virtual System.Nullable<bool> KidsStayFree { get; set; }

        /// <summary>Kids stay free exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kidsStayFreeException")]
        public virtual string KidsStayFreeException { get; set; }

        /// <summary>
        /// Max child age. The hotel allows children up to a certain age to stay in the room/suite of a parent or adult
        /// without an additional fee.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxChildAge")]
        public virtual System.Nullable<int> MaxChildAge { get; set; }

        /// <summary>Max child age exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxChildAgeException")]
        public virtual string MaxChildAgeException { get; set; }

        /// <summary>
        /// Max kids stay free count. The hotel allows a specific, defined number of children to stay in the room/suite
        /// of a parent or adult without an additional fee.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxKidsStayFreeCount")]
        public virtual System.Nullable<int> MaxKidsStayFreeCount { get; set; }

        /// <summary>Max kids stay free count exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxKidsStayFreeCountException")]
        public virtual string MaxKidsStayFreeCountException { get; set; }

        /// <summary>Forms of payment accepted at the property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paymentOptions")]
        public virtual PaymentOptions PaymentOptions { get; set; }

        /// <summary>
        /// Smoke free property. Smoking is not allowed inside the building, on balconies, or in outside spaces. Hotels
        /// that offer a designated area for guests to smoke are not considered smoke-free properties.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("smokeFreeProperty")]
        public virtual System.Nullable<bool> SmokeFreeProperty { get; set; }

        /// <summary>Smoke free property exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("smokeFreePropertyException")]
        public virtual string SmokeFreePropertyException { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Swimming pool or recreational water facilities available at the hotel.</summary>
    public class Pools : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Adult pool. A pool restricted for use by adults only. Can be indoors or outdoors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adultPool")]
        public virtual System.Nullable<bool> AdultPool { get; set; }

        /// <summary>Adult pool exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adultPoolException")]
        public virtual string AdultPoolException { get; set; }

        /// <summary>
        /// Hot tub. A man-made pool containing bubbling water maintained at a higher temperature and circulated by
        /// aerating jets for the purpose of soaking, relaxation and hydrotherapy. Can be indoors or outdoors. Not used
        /// for active swimming. Also known as Jacuzzi. Hot tub must be in a common area where all guests can access it.
        /// Does not apply to room-specific hot tubs that are only accessible to guest occupying that room.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hotTub")]
        public virtual System.Nullable<bool> HotTub { get; set; }

        /// <summary>Hot tub exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hotTubException")]
        public virtual string HotTubException { get; set; }

        /// <summary>
        /// Indoor pool. A pool located inside the hotel and available for guests to use for swimming and/or soaking.
        /// Use may or may not be restricted to adults and/or children.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indoorPool")]
        public virtual System.Nullable<bool> IndoorPool { get; set; }

        /// <summary>Indoor pool exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indoorPoolException")]
        public virtual string IndoorPoolException { get; set; }

        /// <summary>Indoor pools count. The sum of all indoor pools at the hotel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indoorPoolsCount")]
        public virtual System.Nullable<int> IndoorPoolsCount { get; set; }

        /// <summary>Indoor pools count exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indoorPoolsCountException")]
        public virtual string IndoorPoolsCountException { get; set; }

        /// <summary>
        /// Lazy river. A man-made pool or several interconnected recreational pools built to mimic the shape and
        /// current of a winding river where guests float in the water on inflated rubber tubes. Can be indoors or
        /// outdoors.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lazyRiver")]
        public virtual System.Nullable<bool> LazyRiver { get; set; }

        /// <summary>Lazy river exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lazyRiverException")]
        public virtual string LazyRiverException { get; set; }

        /// <summary>
        /// Lifeguard. A trained member of the hotel staff stationed by the hotel's indoor or outdoor swimming area and
        /// responsible for the safety of swimming guests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifeguard")]
        public virtual System.Nullable<bool> Lifeguard { get; set; }

        /// <summary>Lifeguard exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifeguardException")]
        public virtual string LifeguardException { get; set; }

        /// <summary>
        /// Outdoor pool. A pool located outside on the grounds of the hotel and available for guests to use for
        /// swimming, soaking or recreation. Use may or may not be restricted to adults and/or children.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outdoorPool")]
        public virtual System.Nullable<bool> OutdoorPool { get; set; }

        /// <summary>Outdoor pool exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outdoorPoolException")]
        public virtual string OutdoorPoolException { get; set; }

        /// <summary>Outdoor pools count. The sum of all outdoor pools at the hotel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outdoorPoolsCount")]
        public virtual System.Nullable<int> OutdoorPoolsCount { get; set; }

        /// <summary>Outdoor pools count exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outdoorPoolsCountException")]
        public virtual string OutdoorPoolsCountException { get; set; }

        /// <summary>
        /// Pool. The presence of a pool, either indoors or outdoors, for guests to use for swimming and/or soaking. Use
        /// may or may not be restricted to adults and/or children.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pool")]
        public virtual System.Nullable<bool> Pool { get; set; }

        /// <summary>Pool exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("poolException")]
        public virtual string PoolException { get; set; }

        /// <summary>Pools count. The sum of all pools at the hotel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("poolsCount")]
        public virtual System.Nullable<int> PoolsCount { get; set; }

        /// <summary>Pools count exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("poolsCountException")]
        public virtual string PoolsCountException { get; set; }

        /// <summary>
        /// Wading pool. A shallow pool designed for small children to play in. Can be indoors or outdoors. Also known
        /// as kiddie pool.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wadingPool")]
        public virtual System.Nullable<bool> WadingPool { get; set; }

        /// <summary>Wading pool exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wadingPoolException")]
        public virtual string WadingPoolException { get; set; }

        /// <summary>
        /// Water park. An aquatic recreation area with a large pool or series of pools that has features such as a
        /// water slide or tube, wavepool, fountains, rope swings, and/or obstacle course. Can be indoors or outdoors.
        /// Also known as adventure pool.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("waterPark")]
        public virtual System.Nullable<bool> WaterPark { get; set; }

        /// <summary>Water park exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("waterParkException")]
        public virtual string WaterParkException { get; set; }

        /// <summary>
        /// Waterslide. A continuously wetted chute positioned by an indoor or outdoor pool which people slide down into
        /// the water.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("waterslide")]
        public virtual System.Nullable<bool> Waterslide { get; set; }

        /// <summary>Waterslide exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("waterslideException")]
        public virtual string WaterslideException { get; set; }

        /// <summary>
        /// Wave pool. A large indoor or outdoor pool with a machine that produces water currents to mimic the ocean's
        /// crests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wavePool")]
        public virtual System.Nullable<bool> WavePool { get; set; }

        /// <summary>Wave pool exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wavePoolException")]
        public virtual string WavePoolException { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>General factual information about the property's physical structure and important dates.</summary>
    public class Property : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Built year. The year that construction of the property was completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("builtYear")]
        public virtual System.Nullable<int> BuiltYear { get; set; }

        /// <summary>Built year exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("builtYearException")]
        public virtual string BuiltYearException { get; set; }

        /// <summary>
        /// Floors count. The number of stories the building has from the ground floor to the top floor that are
        /// accessible to guests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floorsCount")]
        public virtual System.Nullable<int> FloorsCount { get; set; }

        /// <summary>Floors count exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floorsCountException")]
        public virtual string FloorsCountException { get; set; }

        /// <summary>
        /// Last renovated year. The year when the most recent renovation of the property was completed. Renovation may
        /// include all or any combination of the following: the units, the public spaces, the exterior, or the
        /// interior.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastRenovatedYear")]
        public virtual System.Nullable<int> LastRenovatedYear { get; set; }

        /// <summary>Last renovated year exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastRenovatedYearException")]
        public virtual string LastRenovatedYearException { get; set; }

        /// <summary>
        /// Rooms count. The total number of rooms and suites bookable by guests for an overnight stay. Does not include
        /// event space, public spaces, conference rooms, fitness rooms, business centers, spa, salon, restaurants/bars,
        /// or shops.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roomsCount")]
        public virtual System.Nullable<int> RoomsCount { get; set; }

        /// <summary>Rooms count exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roomsCountException")]
        public virtual string RoomsCountException { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Conveniences or help provided by the property to facilitate an easier, more comfortable stay.</summary>
    public class Services : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Baggage storage. A provision for guests to leave their bags at the hotel when they arrive for their stay
        /// before the official check-in time. May or may not apply for guests who wish to leave their bags after
        /// check-out and before departing the locale. Also known as bag dropoff.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baggageStorage")]
        public virtual System.Nullable<bool> BaggageStorage { get; set; }

        /// <summary>Baggage storage exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baggageStorageException")]
        public virtual string BaggageStorageException { get; set; }

        /// <summary>
        /// Concierge. Hotel staff member(s) responsible for facilitating an easy, comfortable stay through making
        /// reservations for meals, sourcing theater tickets, arranging tours, finding a doctor, making recommendations,
        /// and answering questions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("concierge")]
        public virtual System.Nullable<bool> Concierge { get; set; }

        /// <summary>Concierge exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conciergeException")]
        public virtual string ConciergeException { get; set; }

        /// <summary>
        /// Convenience store. A shop at the hotel primarily selling snacks, drinks, non-prescription medicines, health
        /// and beauty aids, magazines and newspapers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("convenienceStore")]
        public virtual System.Nullable<bool> ConvenienceStore { get; set; }

        /// <summary>Convenience store exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("convenienceStoreException")]
        public virtual string ConvenienceStoreException { get; set; }

        /// <summary>
        /// Currency exchange. A staff member or automated machine tasked with the transaction of providing the native
        /// currency of the hotel's locale in exchange for the foreign currency provided by a guest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyExchange")]
        public virtual System.Nullable<bool> CurrencyExchange { get; set; }

        /// <summary>Currency exchange exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyExchangeException")]
        public virtual string CurrencyExchangeException { get; set; }

        /// <summary>
        /// Elevator. A passenger elevator that transports guests from one story to another. Also known as lift.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("elevator")]
        public virtual System.Nullable<bool> Elevator { get; set; }

        /// <summary>Elevator exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("elevatorException")]
        public virtual string ElevatorException { get; set; }

        /// <summary>
        /// Front desk. A counter or desk in the lobby or the immediate interior of the hotel where a member of the
        /// staff greets guests and processes the information related to their stay (including check-in and check-out).
        /// May or may not be manned and open 24/7.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frontDesk")]
        public virtual System.Nullable<bool> FrontDesk { get; set; }

        /// <summary>Front desk exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frontDeskException")]
        public virtual string FrontDeskException { get; set; }

        /// <summary>
        /// Full service laundry. Laundry and dry cleaning facilitated and handled by the hotel on behalf of the guest.
        /// Does not include the provision for guests to do their own laundry in on-site machines.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullServiceLaundry")]
        public virtual System.Nullable<bool> FullServiceLaundry { get; set; }

        /// <summary>Full service laundry exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullServiceLaundryException")]
        public virtual string FullServiceLaundryException { get; set; }

        /// <summary>
        /// Gift shop. An on-site store primarily selling souvenirs, mementos and other gift items. May or may not also
        /// sell sundries, magazines and newspapers, clothing, or snacks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("giftShop")]
        public virtual System.Nullable<bool> GiftShop { get; set; }

        /// <summary>Gift shop exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("giftShopException")]
        public virtual string GiftShopException { get; set; }

        /// <summary>Languages spoken by at least one staff member.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languagesSpoken")]
        public virtual System.Collections.Generic.IList<LanguageSpoken> LanguagesSpoken { get; set; }

        /// <summary>
        /// Self service laundry. On-site clothes washers and dryers accessible to guests for the purpose of washing and
        /// drying their own clothes. May or may not require payment to use the machines.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfServiceLaundry")]
        public virtual System.Nullable<bool> SelfServiceLaundry { get; set; }

        /// <summary>Self service laundry exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfServiceLaundryException")]
        public virtual string SelfServiceLaundryException { get; set; }

        /// <summary>
        /// Social hour. A reception with complimentary soft drinks, tea, coffee, wine and/or cocktails in the afternoon
        /// or evening. Can be hosted by hotel staff or guests may serve themselves. Also known as wine hour. The
        /// availability of coffee/tea in the lobby throughout the day does not constitute a social or wine hour.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("socialHour")]
        public virtual System.Nullable<bool> SocialHour { get; set; }

        /// <summary>Social hour exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("socialHourException")]
        public virtual string SocialHourException { get; set; }

        /// <summary>24hr front desk. Front desk is staffed 24 hours a day.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("twentyFourHourFrontDesk")]
        public virtual System.Nullable<bool> TwentyFourHourFrontDesk { get; set; }

        /// <summary>24hr front desk exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("twentyFourHourFrontDeskException")]
        public virtual string TwentyFourHourFrontDeskException { get; set; }

        /// <summary>
        /// Wake up calls. By direction of the guest, a hotel staff member will phone the guest unit at the requested
        /// hour. Also known as morning call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wakeUpCalls")]
        public virtual System.Nullable<bool> WakeUpCalls { get; set; }

        /// <summary>Wake up calls exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wakeUpCallsException")]
        public virtual string WakeUpCallsException { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Sustainability practices implemented at the hotel.</summary>
    public class Sustainability : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Energy efficiency practices implemented at the hotel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("energyEfficiency")]
        public virtual EnergyEfficiency EnergyEfficiency { get; set; }

        /// <summary>Sustainability certifications the hotel has been awarded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sustainabilityCertifications")]
        public virtual SustainabilityCertifications SustainabilityCertifications { get; set; }

        /// <summary>Sustainable sourcing practices implemented at the hotel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sustainableSourcing")]
        public virtual SustainableSourcing SustainableSourcing { get; set; }

        /// <summary>Waste reduction practices implemented at the hotel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wasteReduction")]
        public virtual WasteReduction WasteReduction { get; set; }

        /// <summary>Water conservation practices implemented at the hotel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("waterConservation")]
        public virtual WaterConservation WaterConservation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Sustainability certifications the hotel has been awarded.</summary>
    public class SustainabilityCertifications : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>BREEAM certification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("breeamCertification")]
        public virtual string BreeamCertification { get; set; }

        /// <summary>BREEAM certification exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("breeamCertificationException")]
        public virtual string BreeamCertificationException { get; set; }

        /// <summary>The eco certificates awarded to the hotel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ecoCertifications")]
        public virtual System.Collections.Generic.IList<EcoCertification> EcoCertifications { get; set; }

        /// <summary>LEED certification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("leedCertification")]
        public virtual string LeedCertification { get; set; }

        /// <summary>LEED certification exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("leedCertificationException")]
        public virtual string LeedCertificationException { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Sustainable sourcing practices implemented at the hotel.</summary>
    public class SustainableSourcing : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Eco friendly toiletries. Soap, shampoo, lotion, and other toiletries provided for guests have a nationally
        /// or internationally recognized sustainability certification, such as USDA Organic, EU Organic, or
        /// cruelty-free.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ecoFriendlyToiletries")]
        public virtual System.Nullable<bool> EcoFriendlyToiletries { get; set; }

        /// <summary>Eco friendly toiletries exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ecoFriendlyToiletriesException")]
        public virtual string EcoFriendlyToiletriesException { get; set; }

        /// <summary>
        /// Locally sourced food and beverages. Property sources locally in order to lower the environmental footprint
        /// from reduced transportation and to stimulate the local economy. Products produced less than 62 miles from
        /// the establishment are normally considered as locally produced.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locallySourcedFoodAndBeverages")]
        public virtual System.Nullable<bool> LocallySourcedFoodAndBeverages { get; set; }

        /// <summary>Locally sourced food and beverages exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locallySourcedFoodAndBeveragesException")]
        public virtual string LocallySourcedFoodAndBeveragesException { get; set; }

        /// <summary>
        /// Organic cage free eggs. The property sources 100% certified organic and cage-free eggs (shell, liquid, and
        /// egg products). Cage-free means hens are able to walk, spread their wings and lay their eggs in nests).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organicCageFreeEggs")]
        public virtual System.Nullable<bool> OrganicCageFreeEggs { get; set; }

        /// <summary>Organic cage free eggs exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organicCageFreeEggsException")]
        public virtual string OrganicCageFreeEggsException { get; set; }

        /// <summary>
        /// Organic food and beverages. At least 25% of food and beverages, by spend, are certified organic. Organic
        /// means products that are certified to one of the organic standard listed in the IFOAM family of standards.
        /// Qualifying certifications include USDA Organic and EU Organic, among others.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organicFoodAndBeverages")]
        public virtual System.Nullable<bool> OrganicFoodAndBeverages { get; set; }

        /// <summary>Organic food and beverages exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organicFoodAndBeveragesException")]
        public virtual string OrganicFoodAndBeveragesException { get; set; }

        /// <summary>
        /// Responsible purchasing policy. The property has a responsible procurement policy in place. Responsible means
        /// integration of social, ethical, and/or environmental performance factors into the procurement process when
        /// selecting suppliers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responsiblePurchasingPolicy")]
        public virtual System.Nullable<bool> ResponsiblePurchasingPolicy { get; set; }

        /// <summary>Responsible purchasing policy exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responsiblePurchasingPolicyException")]
        public virtual string ResponsiblePurchasingPolicyException { get; set; }

        /// <summary>
        /// Responsibly sources seafood. The property does not source seafood from the Monterey Bay Aquarium Seafood
        /// Watch "avoid" list, and must sustainably source seafood listed as "good alternative," "eco-certified," and
        /// "best choice". The property has a policy outlining a commitment to source Marine Stewardship Council (MSC)
        /// and/or Aquaculture Stewardship Council (ASC) Chain of Custody certified seafood.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responsiblySourcesSeafood")]
        public virtual System.Nullable<bool> ResponsiblySourcesSeafood { get; set; }

        /// <summary>Responsibly sources seafood exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responsiblySourcesSeafoodException")]
        public virtual string ResponsiblySourcesSeafoodException { get; set; }

        /// <summary>
        /// Vegan meals. The property provides vegan menu options for guests. Vegan food does not contain animal
        /// products or byproducts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("veganMeals")]
        public virtual System.Nullable<bool> VeganMeals { get; set; }

        /// <summary>Vegan meals exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("veganMealsException")]
        public virtual string VeganMealsException { get; set; }

        /// <summary>
        /// Vegetarian meals. The property provides vegetarian menu options for guests. Vegetarian food does not contain
        /// animal products.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vegetarianMeals")]
        public virtual System.Nullable<bool> VegetarianMeals { get; set; }

        /// <summary>Vegetarian meals exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vegetarianMealsException")]
        public virtual string VegetarianMealsException { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a time of day. The date and time zone are either not significant or are specified elsewhere. An API
    /// may choose to allow leap seconds. Related types are google.type.Date and `google.protobuf.Timestamp`.
    /// </summary>
    public class TimeOfDay : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for
        /// scenarios like business closing time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hours")]
        public virtual System.Nullable<int> Hours { get; set; }

        /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minutes")]
        public virtual System.Nullable<int> Minutes { get; set; }

        /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>
        /// Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows
        /// leap-seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seconds")]
        public virtual System.Nullable<int> Seconds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Vehicles or vehicular services facilitated or owned by the property.</summary>
    public class Transportation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Airport shuttle. The hotel provides guests with a chauffeured van or bus to and from the airport. Can be
        /// free or for a fee. Guests may share the vehicle with other guests unknown to them. Applies if the hotel has
        /// a third-party shuttle service (office/desk etc.) within the hotel. As long as hotel provides this service,
        /// it doesn't matter if it's directly with them or a third party they work with. Does not apply if guest has to
        /// coordinate with an entity outside/other than the hotel.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("airportShuttle")]
        public virtual System.Nullable<bool> AirportShuttle { get; set; }

        /// <summary>Airport shuttle exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("airportShuttleException")]
        public virtual string AirportShuttleException { get; set; }

        /// <summary>
        /// Car rental on property. A branch of a rental car company with a processing desk in the hotel. Available cars
        /// for rent may be awaiting at the hotel or in a nearby lot.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("carRentalOnProperty")]
        public virtual System.Nullable<bool> CarRentalOnProperty { get; set; }

        /// <summary>Car rental on property exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("carRentalOnPropertyException")]
        public virtual string CarRentalOnPropertyException { get; set; }

        /// <summary>
        /// Free airport shuttle. Airport shuttle is free to guests. Must be free to all guests without any conditions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeAirportShuttle")]
        public virtual System.Nullable<bool> FreeAirportShuttle { get; set; }

        /// <summary>Free airport shuttle exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeAirportShuttleException")]
        public virtual string FreeAirportShuttleException { get; set; }

        /// <summary>Free private car service. Private chauffeured car service is free to guests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freePrivateCarService")]
        public virtual System.Nullable<bool> FreePrivateCarService { get; set; }

        /// <summary>Free private car service exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freePrivateCarServiceException")]
        public virtual string FreePrivateCarServiceException { get; set; }

        /// <summary>
        /// Local shuttle. A car, van or bus provided by the hotel to transport guests to destinations within a
        /// specified range of distance around the hotel. Usually shopping and/or convention centers, downtown
        /// districts, or beaches. Can be free or for a fee.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localShuttle")]
        public virtual System.Nullable<bool> LocalShuttle { get; set; }

        /// <summary>Local shuttle exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localShuttleException")]
        public virtual string LocalShuttleException { get; set; }

        /// <summary>
        /// Private car service. Hotel provides a private chauffeured car to transport guests to destinations.
        /// Passengers in the car are either alone or are known to one another and have requested the car together.
        /// Service can be free or for a fee and travel distance is usually limited to a specific range. Not a taxi.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateCarService")]
        public virtual System.Nullable<bool> PrivateCarService { get; set; }

        /// <summary>Private car service exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateCarServiceException")]
        public virtual string PrivateCarServiceException { get; set; }

        /// <summary>
        /// Transfer. Hotel provides a shuttle service or car service to take guests to and from the nearest airport or
        /// train station. Can be free or for a fee. Guests may share the vehicle with other guests unknown to them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transfer")]
        public virtual System.Nullable<bool> Transfer { get; set; }

        /// <summary>Transfer exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transferException")]
        public virtual string TransferException { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Views available from the guest unit itself.</summary>
    public class ViewsFromUnit : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Beach view. A guestroom that features a window through which guests can see the beach.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("beachView")]
        public virtual System.Nullable<bool> BeachView { get; set; }

        /// <summary>Beach view exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("beachViewException")]
        public virtual string BeachViewException { get; set; }

        /// <summary>
        /// City view. A guestroom that features a window through which guests can see the buildings, parks and/or
        /// streets of the city.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cityView")]
        public virtual System.Nullable<bool> CityView { get; set; }

        /// <summary>City view exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cityViewException")]
        public virtual string CityViewException { get; set; }

        /// <summary>Garden view. A guestroom that features a window through which guests can see a garden.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gardenView")]
        public virtual System.Nullable<bool> GardenView { get; set; }

        /// <summary>Garden view exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gardenViewException")]
        public virtual string GardenViewException { get; set; }

        /// <summary>Lake view.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lakeView")]
        public virtual System.Nullable<bool> LakeView { get; set; }

        /// <summary>Lake view exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lakeViewException")]
        public virtual string LakeViewException { get; set; }

        /// <summary>
        /// Landmark view. A guestroom that features a window through which guests can see a landmark such as the
        /// countryside, a golf course, the forest, a park, a rain forst, a mountain or a slope.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("landmarkView")]
        public virtual System.Nullable<bool> LandmarkView { get; set; }

        /// <summary>Landmark view exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("landmarkViewException")]
        public virtual string LandmarkViewException { get; set; }

        /// <summary>Ocean view. A guestroom that features a window through which guests can see the ocean.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oceanView")]
        public virtual System.Nullable<bool> OceanView { get; set; }

        /// <summary>Ocean view exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oceanViewException")]
        public virtual string OceanViewException { get; set; }

        /// <summary>
        /// Pool view. A guestroom that features a window through which guests can see the hotel's swimming pool.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("poolView")]
        public virtual System.Nullable<bool> PoolView { get; set; }

        /// <summary>Pool view exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("poolViewException")]
        public virtual string PoolViewException { get; set; }

        /// <summary>
        /// Valley view. A guestroom that features a window through which guests can see over a valley.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valleyView")]
        public virtual System.Nullable<bool> ValleyView { get; set; }

        /// <summary>Valley view exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valleyViewException")]
        public virtual string ValleyViewException { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Waste reduction practices implemented at the hotel.</summary>
    public class WasteReduction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Compostable food containers and cutlery. 100% of food service containers and to-go cutlery are compostable,
        /// and reusable utensils are offered wherever possible. Compostable materials are capable of undergoing
        /// biological decomposition in a compost site, such that material is not visually distinguishable and breaks
        /// down into carbon dioxide, water, inorganic compounds, and biomass.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compostableFoodContainersAndCutlery")]
        public virtual System.Nullable<bool> CompostableFoodContainersAndCutlery { get; set; }

        /// <summary>Compostable food containers and cutlery exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compostableFoodContainersAndCutleryException")]
        public virtual string CompostableFoodContainersAndCutleryException { get; set; }

        /// <summary>
        /// Composts excess food. The property has a program and/or policy for diverting waste from landfill by
        /// composting food and yard waste, either through compost collection and off-site processing or on-site compost
        /// processing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compostsExcessFood")]
        public virtual System.Nullable<bool> CompostsExcessFood { get; set; }

        /// <summary>Composts excess food exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compostsExcessFoodException")]
        public virtual string CompostsExcessFoodException { get; set; }

        /// <summary>
        /// Donates excess food. The property has a program and/or policy for diverting waste from landfill that may
        /// include efforts to donate for human consumption or divert food for animal feed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("donatesExcessFood")]
        public virtual System.Nullable<bool> DonatesExcessFood { get; set; }

        /// <summary>Donates excess food exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("donatesExcessFoodException")]
        public virtual string DonatesExcessFoodException { get; set; }

        /// <summary>
        /// Food waste reduction program. The property has established a food waste reduction and donation program,
        /// aiming to reduce food waste by half. These programs typically use tools such as the Hotel Kitchen Toolkit
        /// and others to track waste and measure progress.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("foodWasteReductionProgram")]
        public virtual System.Nullable<bool> FoodWasteReductionProgram { get; set; }

        /// <summary>Food waste reduction program exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("foodWasteReductionProgramException")]
        public virtual string FoodWasteReductionProgramException { get; set; }

        /// <summary>No single use plastic straws. The property bans single-use plastic straws.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noSingleUsePlasticStraws")]
        public virtual System.Nullable<bool> NoSingleUsePlasticStraws { get; set; }

        /// <summary>No single use plastic straws exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noSingleUsePlasticStrawsException")]
        public virtual string NoSingleUsePlasticStrawsException { get; set; }

        /// <summary>No single use plastic water bottles. The property bans single-use plastic water bottles.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noSingleUsePlasticWaterBottles")]
        public virtual System.Nullable<bool> NoSingleUsePlasticWaterBottles { get; set; }

        /// <summary>No single use plastic water bottles exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noSingleUsePlasticWaterBottlesException")]
        public virtual string NoSingleUsePlasticWaterBottlesException { get; set; }

        /// <summary>
        /// No styrofoam food containers. The property eliminates the use of Styrofoam in disposable food service items.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noStyrofoamFoodContainers")]
        public virtual System.Nullable<bool> NoStyrofoamFoodContainers { get; set; }

        /// <summary>No styrofoam food containers exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noStyrofoamFoodContainersException")]
        public virtual string NoStyrofoamFoodContainersException { get; set; }

        /// <summary>
        /// Recycling program. The property has a recycling program, aligned with LEED waste requirements, and a policy
        /// outlining efforts to send less than 50% of waste to landfill. The recycling program includes storage
        /// locations for recyclable materials, including mixed paper, corrugated cardboard, glass, plastics, and
        /// metals.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recyclingProgram")]
        public virtual System.Nullable<bool> RecyclingProgram { get; set; }

        /// <summary>Recycling program exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recyclingProgramException")]
        public virtual string RecyclingProgramException { get; set; }

        /// <summary>
        /// Refillable toiletry containers. The property has replaced miniature individual containers with refillable
        /// amenity dispensers for shampoo, conditioner, soap, and lotion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refillableToiletryContainers")]
        public virtual System.Nullable<bool> RefillableToiletryContainers { get; set; }

        /// <summary>Refillable toiletry containers exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refillableToiletryContainersException")]
        public virtual string RefillableToiletryContainersException { get; set; }

        /// <summary>Safely disposes batteries. The property safely stores and disposes batteries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("safelyDisposesBatteries")]
        public virtual System.Nullable<bool> SafelyDisposesBatteries { get; set; }

        /// <summary>Safely disposes batteries exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("safelyDisposesBatteriesException")]
        public virtual string SafelyDisposesBatteriesException { get; set; }

        /// <summary>
        /// Safely disposes electronics. The property has a reputable recycling program that keeps hazardous electronic
        /// parts and chemical compounds out of landfills, dumps and other unauthorized abandonment sites, and
        /// recycles/reuses applicable materials. (e.g. certified electronics recyclers).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("safelyDisposesElectronics")]
        public virtual System.Nullable<bool> SafelyDisposesElectronics { get; set; }

        /// <summary>Safely disposes electronics exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("safelyDisposesElectronicsException")]
        public virtual string SafelyDisposesElectronicsException { get; set; }

        /// <summary>Safely disposes lightbulbs. The property safely stores and disposes lightbulbs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("safelyDisposesLightbulbs")]
        public virtual System.Nullable<bool> SafelyDisposesLightbulbs { get; set; }

        /// <summary>Safely disposes lightbulbs exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("safelyDisposesLightbulbsException")]
        public virtual string SafelyDisposesLightbulbsException { get; set; }

        /// <summary>
        /// Safely handles hazardous substances. The property has a hazardous waste management program aligned wit
        /// GreenSeal and LEED requirements, and meets all regulatory requirements for hazardous waste disposal and
        /// recycling. Hazardous means substances that are classified as "hazardous" by an authoritative body (such as
        /// OSHA or DOT), are labeled with signal words such as "Danger," "Caution," "Warning," or are flammable,
        /// corrosive, or ignitable. Requirements include: - The property shall maintain records of the efforts it has
        /// made to replace the hazardous substances it uses with less hazardous alternatives. - An inventory of the
        /// hazardous materials stored on-site. - Products intended for cleaning, dishwashing, laundry, and pool
        /// maintenance shall be stored in clearly labeled containers. These containers shall be checked regularly for
        /// leaks, and replaced a necessary. - Spill containment devices shall be installed to collect spills, drips, or
        /// leaching of chemicals.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("safelyHandlesHazardousSubstances")]
        public virtual System.Nullable<bool> SafelyHandlesHazardousSubstances { get; set; }

        /// <summary>Safely handles hazardous substances exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("safelyHandlesHazardousSubstancesException")]
        public virtual string SafelyHandlesHazardousSubstancesException { get; set; }

        /// <summary>
        /// Soap donation program. The property participates in a soap donation program such as Clean the World or
        /// something similar.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("soapDonationProgram")]
        public virtual System.Nullable<bool> SoapDonationProgram { get; set; }

        /// <summary>Soap donation program exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("soapDonationProgramException")]
        public virtual string SoapDonationProgramException { get; set; }

        /// <summary>
        /// Toiletry donation program. The property participates in a toiletry donation program such as Clean the World
        /// or something similar.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toiletryDonationProgram")]
        public virtual System.Nullable<bool> ToiletryDonationProgram { get; set; }

        /// <summary>Toiletry donation program exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toiletryDonationProgramException")]
        public virtual string ToiletryDonationProgramException { get; set; }

        /// <summary>
        /// Water bottle filling stations. The property offers water stations throughout the building for guest use.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("waterBottleFillingStations")]
        public virtual System.Nullable<bool> WaterBottleFillingStations { get; set; }

        /// <summary>Water bottle filling stations exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("waterBottleFillingStationsException")]
        public virtual string WaterBottleFillingStationsException { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Water conservation practices implemented at the hotel.</summary>
    public class WaterConservation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Independent organization audits water use. The property conducts a water conservation audit every 5 years,
        /// the results of which are either verified by a third-party and/or published in external communications. A
        /// water conservation audit is a detailed assessment of the facility, providing recommendations to existing
        /// operations and procedures to improve water efficiency, available incentives or rebates, and opportunities
        /// for improvements through renovations or upgrades. Examples of organizations who conduct credible third party
        /// audits include: Engie Impact, and local utility providers (they often provide energy and water audits).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("independentOrganizationAuditsWaterUse")]
        public virtual System.Nullable<bool> IndependentOrganizationAuditsWaterUse { get; set; }

        /// <summary>Independent organization audits water use exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("independentOrganizationAuditsWaterUseException")]
        public virtual string IndependentOrganizationAuditsWaterUseException { get; set; }

        /// <summary>Linen reuse program. The property offers a linen reuse program.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linenReuseProgram")]
        public virtual System.Nullable<bool> LinenReuseProgram { get; set; }

        /// <summary>Linen reuse program exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linenReuseProgramException")]
        public virtual string LinenReuseProgramException { get; set; }

        /// <summary>Towel reuse program. The property offers a towel reuse program.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("towelReuseProgram")]
        public virtual System.Nullable<bool> TowelReuseProgram { get; set; }

        /// <summary>Towel reuse program exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("towelReuseProgramException")]
        public virtual string TowelReuseProgramException { get; set; }

        /// <summary>
        /// Water saving showers. All of the property's guest rooms have shower heads that use no more than 2.0 gallons
        /// per minute (gpm).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("waterSavingShowers")]
        public virtual System.Nullable<bool> WaterSavingShowers { get; set; }

        /// <summary>Water saving showers exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("waterSavingShowersException")]
        public virtual string WaterSavingShowersException { get; set; }

        /// <summary>
        /// Water saving sinks. All of the property's guest rooms have bathroom faucets that use a maximum of 1.5
        /// gallons per minute (gpm), public restroom faucets do not exceed 0.5 gpm, and kitchen faucets (excluding
        /// faucets used exclusively for filling operations) do not exceed 2.2 gpm.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("waterSavingSinks")]
        public virtual System.Nullable<bool> WaterSavingSinks { get; set; }

        /// <summary>Water saving sinks exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("waterSavingSinksException")]
        public virtual string WaterSavingSinksException { get; set; }

        /// <summary>Water saving toilets. All of the property's toilets use 1.6 gallons per flush, or less.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("waterSavingToilets")]
        public virtual System.Nullable<bool> WaterSavingToilets { get; set; }

        /// <summary>Water saving toilets exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("waterSavingToiletsException")]
        public virtual string WaterSavingToiletsException { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Guest facilities at the property to promote or maintain health, beauty, and fitness.</summary>
    public class Wellness : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Doctor on call. The hotel has a contract with a medical professional who provides services to hotel guests
        /// should they fall ill during their stay. The doctor may or may not have an on-site office or be at the hotel
        /// at all times.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doctorOnCall")]
        public virtual System.Nullable<bool> DoctorOnCall { get; set; }

        /// <summary>Doctor on call exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doctorOnCallException")]
        public virtual string DoctorOnCallException { get; set; }

        /// <summary>
        /// Elliptical machine. An electric, stationary fitness machine with pedals that simulates climbing, walking or
        /// running and provides a user-controlled range of speeds and tensions. May not have arm-controlled levers to
        /// work out the upper body as well. Commonly found in a gym, fitness room, health center, or health club.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ellipticalMachine")]
        public virtual System.Nullable<bool> EllipticalMachine { get; set; }

        /// <summary>Elliptical machine exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ellipticalMachineException")]
        public virtual string EllipticalMachineException { get; set; }

        /// <summary>
        /// Fitness center. A room or building at the hotel containing equipment to promote physical activity, such as
        /// treadmills, elliptical machines, stationary bikes, weight machines, free weights, and/or stretching mats.
        /// Use of the fitness center can be free or for a fee. May or may not be staffed. May or may not offer
        /// instructor-led classes in various styles of physical conditioning. May or may not be open 24/7. May or may
        /// not include locker rooms and showers. Also known as health club, gym, fitness room, health center.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fitnessCenter")]
        public virtual System.Nullable<bool> FitnessCenter { get; set; }

        /// <summary>Fitness center exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fitnessCenterException")]
        public virtual string FitnessCenterException { get; set; }

        /// <summary>Free fitness center. Guests may use the fitness center for free.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeFitnessCenter")]
        public virtual System.Nullable<bool> FreeFitnessCenter { get; set; }

        /// <summary>Free fitness center exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeFitnessCenterException")]
        public virtual string FreeFitnessCenterException { get; set; }

        /// <summary>
        /// Free weights. Individual handheld fitness equipment of varied weights used for upper body strength training
        /// or bodybuilding. Also known as barbells, dumbbells, or kettlebells. Often stored on a rack with the weights
        /// arranged from light to heavy. Commonly found in a gym, fitness room, health center, or health club.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeWeights")]
        public virtual System.Nullable<bool> FreeWeights { get; set; }

        /// <summary>Free weights exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeWeightsException")]
        public virtual string FreeWeightsException { get; set; }

        /// <summary>
        /// Massage. A service provided by a trained massage therapist involving the physical manipulation of a guest's
        /// muscles in order to achieve relaxation or pain relief.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("massage")]
        public virtual System.Nullable<bool> Massage { get; set; }

        /// <summary>Massage exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("massageException")]
        public virtual string MassageException { get; set; }

        /// <summary>
        /// Salon. A room at the hotel where professionals provide hair styling services such as shampooing, blow
        /// drying, hair dos, hair cutting and hair coloring. Also known as hairdresser or beauty salon.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("salon")]
        public virtual System.Nullable<bool> Salon { get; set; }

        /// <summary>Salon exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("salonException")]
        public virtual string SalonException { get; set; }

        /// <summary>
        /// Sauna. A wood-paneled room heated to a high temperature where guests sit on built-in wood benches for the
        /// purpose of perspiring and relaxing their muscles. Can be dry or slightly wet heat. Not a steam room.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sauna")]
        public virtual System.Nullable<bool> Sauna { get; set; }

        /// <summary>Sauna exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("saunaException")]
        public virtual string SaunaException { get; set; }

        /// <summary>
        /// Spa. A designated area, room or building at the hotel offering health and beauty treatment through such
        /// means as steam baths, exercise equipment, and massage. May also offer facials, nail care, and hair care.
        /// Services are usually available by appointment and for an additional fee. Does not apply if hotel only offers
        /// a steam room; must offer other beauty and/or health treatments as well.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spa")]
        public virtual System.Nullable<bool> Spa { get; set; }

        /// <summary>Spa exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spaException")]
        public virtual string SpaException { get; set; }

        /// <summary>
        /// Treadmill. An electric stationary fitness machine that simulates a moving path to promote walking or running
        /// within a range of user-controlled speeds and inclines. Also known as running machine. Commonly found in a
        /// gym, fitness room, health center, or health club.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("treadmill")]
        public virtual System.Nullable<bool> Treadmill { get; set; }

        /// <summary>Treadmill exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("treadmillException")]
        public virtual string TreadmillException { get; set; }

        /// <summary>
        /// Weight machine. Non-electronic fitness equipment designed for the user to target the exertion of different
        /// muscles. Usually incorporates a padded seat, a stack of flat weights and various bars and pulleys. May be
        /// designed for toning a specific part of the body or may involve different user-controlled settings, hardware
        /// and pulleys so as to provide an overall workout in one machine. Commonly found in a gym, fitness center,
        /// fitness room, or health club.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weightMachine")]
        public virtual System.Nullable<bool> WeightMachine { get; set; }

        /// <summary>Weight machine exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weightMachineException")]
        public virtual string WeightMachineException { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
