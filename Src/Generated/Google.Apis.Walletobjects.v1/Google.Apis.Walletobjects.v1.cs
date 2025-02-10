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

namespace Google.Apis.Walletobjects.v1
{
    /// <summary>The Walletobjects Service.</summary>
    public class WalletobjectsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public WalletobjectsService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public WalletobjectsService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Eventticketclass = new EventticketclassResource(this);
            Eventticketobject = new EventticketobjectResource(this);
            Flightclass = new FlightclassResource(this);
            Flightobject = new FlightobjectResource(this);
            Genericclass = new GenericclassResource(this);
            Genericobject = new GenericobjectResource(this);
            Giftcardclass = new GiftcardclassResource(this);
            Giftcardobject = new GiftcardobjectResource(this);
            Issuer = new IssuerResource(this);
            Jwt = new JwtResource(this);
            Loyaltyclass = new LoyaltyclassResource(this);
            Loyaltyobject = new LoyaltyobjectResource(this);
            Media = new MediaResource(this);
            Offerclass = new OfferclassResource(this);
            Offerobject = new OfferobjectResource(this);
            Permissions = new PermissionsResource(this);
            Smarttap = new SmarttapResource(this);
            Transitclass = new TransitclassResource(this);
            Transitobject = new TransitobjectResource(this);
            Walletobjects = new WalletobjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://walletobjects.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://walletobjects.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "walletobjects";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Google Wallet API.</summary>
        public class Scope
        {
            /// <summary>Private Service: https://www.googleapis.com/auth/wallet_object.issuer</summary>
            public static string WalletObjectIssuer = "https://www.googleapis.com/auth/wallet_object.issuer";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Google Wallet API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Private Service: https://www.googleapis.com/auth/wallet_object.issuer</summary>
            public const string WalletObjectIssuer = "https://www.googleapis.com/auth/wallet_object.issuer";
        }

        /// <summary>Gets the Eventticketclass resource.</summary>
        public virtual EventticketclassResource Eventticketclass { get; }

        /// <summary>Gets the Eventticketobject resource.</summary>
        public virtual EventticketobjectResource Eventticketobject { get; }

        /// <summary>Gets the Flightclass resource.</summary>
        public virtual FlightclassResource Flightclass { get; }

        /// <summary>Gets the Flightobject resource.</summary>
        public virtual FlightobjectResource Flightobject { get; }

        /// <summary>Gets the Genericclass resource.</summary>
        public virtual GenericclassResource Genericclass { get; }

        /// <summary>Gets the Genericobject resource.</summary>
        public virtual GenericobjectResource Genericobject { get; }

        /// <summary>Gets the Giftcardclass resource.</summary>
        public virtual GiftcardclassResource Giftcardclass { get; }

        /// <summary>Gets the Giftcardobject resource.</summary>
        public virtual GiftcardobjectResource Giftcardobject { get; }

        /// <summary>Gets the Issuer resource.</summary>
        public virtual IssuerResource Issuer { get; }

        /// <summary>Gets the Jwt resource.</summary>
        public virtual JwtResource Jwt { get; }

        /// <summary>Gets the Loyaltyclass resource.</summary>
        public virtual LoyaltyclassResource Loyaltyclass { get; }

        /// <summary>Gets the Loyaltyobject resource.</summary>
        public virtual LoyaltyobjectResource Loyaltyobject { get; }

        /// <summary>Gets the Media resource.</summary>
        public virtual MediaResource Media { get; }

        /// <summary>Gets the Offerclass resource.</summary>
        public virtual OfferclassResource Offerclass { get; }

        /// <summary>Gets the Offerobject resource.</summary>
        public virtual OfferobjectResource Offerobject { get; }

        /// <summary>Gets the Permissions resource.</summary>
        public virtual PermissionsResource Permissions { get; }

        /// <summary>Gets the Smarttap resource.</summary>
        public virtual SmarttapResource Smarttap { get; }

        /// <summary>Gets the Transitclass resource.</summary>
        public virtual TransitclassResource Transitclass { get; }

        /// <summary>Gets the Transitobject resource.</summary>
        public virtual TransitobjectResource Transitobject { get; }

        /// <summary>Gets the Walletobjects resource.</summary>
        public virtual WalletobjectsResource Walletobjects { get; }
    }

    /// <summary>A base abstract class for Walletobjects requests.</summary>
    public abstract class WalletobjectsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new WalletobjectsBaseServiceRequest instance.</summary>
        protected WalletobjectsBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Walletobjects parameter list.</summary>
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

    /// <summary>The "eventticketclass" collection of methods.</summary>
    public class EventticketclassResource
    {
        private const string Resource = "eventticketclass";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public EventticketclassResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Adds a message to the event ticket class referenced by the given class ID.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual AddmessageRequest Addmessage(Google.Apis.Walletobjects.v1.Data.AddMessageRequest body, string resourceId)
        {
            return new AddmessageRequest(this.service, body, resourceId);
        }

        /// <summary>Adds a message to the event ticket class referenced by the given class ID.</summary>
        public class AddmessageRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.EventTicketClassAddMessageResponse>
        {
            /// <summary>Constructs a new Addmessage request.</summary>
            public AddmessageRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.AddMessageRequest body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
            /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen
            /// by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.AddMessageRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "addmessage";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/eventTicketClass/{resourceId}/addMessage";

            /// <summary>Initializes Addmessage parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Returns the event ticket class with the given class ID.</summary>
        /// <param name="resourceId">
        /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual GetRequest Get(string resourceId)
        {
            return new GetRequest(this.service, resourceId);
        }

        /// <summary>Returns the event ticket class with the given class ID.</summary>
        public class GetRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.EventTicketClass>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
            /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen
            /// by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/eventTicketClass/{resourceId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts an event ticket class with the given ID and properties.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual InsertRequest Insert(Google.Apis.Walletobjects.v1.Data.EventTicketClass body)
        {
            return new InsertRequest(this.service, body);
        }

        /// <summary>Inserts an event ticket class with the given ID and properties.</summary>
        public class InsertRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.EventTicketClass>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.EventTicketClass body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.EventTicketClass Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/eventTicketClass";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Returns a list of all event ticket classes for a given issuer ID.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Returns a list of all event ticket classes for a given issuer ID.</summary>
        public class ListRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.EventTicketClassListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>The ID of the issuer authorized to list classes.</summary>
            [Google.Apis.Util.RequestParameterAttribute("issuerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IssuerId { get; set; }

            /// <summary>
            /// Identifies the max number of results returned by a list. All results are returned if `maxResults` isn't
            /// defined.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>
            /// Used to get the next set of results if `maxResults` is specified, but more than `maxResults` classes are
            /// available in a list. For example, if you have a list of 200 classes and you call list with `maxResults`
            /// set to 20, list will return the first 20 classes and a token. Call list again with `maxResults` set to
            /// 20 and the token to get the next 20 classes.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Token { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/eventTicketClass";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("issuerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "issuerId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                {
                    Name = "token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates the event ticket class referenced by the given class ID. This method supports patch semantics.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.Walletobjects.v1.Data.EventTicketClass body, string resourceId)
        {
            return new PatchRequest(this.service, body, resourceId);
        }

        /// <summary>
        /// Updates the event ticket class referenced by the given class ID. This method supports patch semantics.
        /// </summary>
        public class PatchRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.EventTicketClass>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.EventTicketClass body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
            /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen
            /// by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.EventTicketClass Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/eventTicketClass/{resourceId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates the event ticket class referenced by the given class ID.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.Walletobjects.v1.Data.EventTicketClass body, string resourceId)
        {
            return new UpdateRequest(this.service, body, resourceId);
        }

        /// <summary>Updates the event ticket class referenced by the given class ID.</summary>
        public class UpdateRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.EventTicketClass>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.EventTicketClass body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
            /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen
            /// by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.EventTicketClass Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/eventTicketClass/{resourceId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "eventticketobject" collection of methods.</summary>
    public class EventticketobjectResource
    {
        private const string Resource = "eventticketobject";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public EventticketobjectResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Adds a message to the event ticket object referenced by the given object ID.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual AddmessageRequest Addmessage(Google.Apis.Walletobjects.v1.Data.AddMessageRequest body, string resourceId)
        {
            return new AddmessageRequest(this.service, body, resourceId);
        }

        /// <summary>Adds a message to the event ticket object referenced by the given object ID.</summary>
        public class AddmessageRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.EventTicketObjectAddMessageResponse>
        {
            /// <summary>Constructs a new Addmessage request.</summary>
            public AddmessageRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.AddMessageRequest body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This
            /// value should follow the format issuer ID. identifier where the former is issued by Google and latter is
            /// chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.AddMessageRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "addmessage";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/eventTicketObject/{resourceId}/addMessage";

            /// <summary>Initializes Addmessage parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Returns the event ticket object with the given object ID.</summary>
        /// <param name="resourceId">
        /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual GetRequest Get(string resourceId)
        {
            return new GetRequest(this.service, resourceId);
        }

        /// <summary>Returns the event ticket object with the given object ID.</summary>
        public class GetRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.EventTicketObject>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This
            /// value should follow the format issuer ID. identifier where the former is issued by Google and latter is
            /// chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/eventTicketObject/{resourceId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts an event ticket object with the given ID and properties.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual InsertRequest Insert(Google.Apis.Walletobjects.v1.Data.EventTicketObject body)
        {
            return new InsertRequest(this.service, body);
        }

        /// <summary>Inserts an event ticket object with the given ID and properties.</summary>
        public class InsertRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.EventTicketObject>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.EventTicketObject body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.EventTicketObject Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/eventTicketObject";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Returns a list of all event ticket objects for a given issuer ID.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Returns a list of all event ticket objects for a given issuer ID.</summary>
        public class ListRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.EventTicketObjectListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>The ID of the class whose objects will be listed.</summary>
            [Google.Apis.Util.RequestParameterAttribute("classId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClassId { get; set; }

            /// <summary>
            /// Identifies the max number of results returned by a list. All results are returned if `maxResults` isn't
            /// defined.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>
            /// Used to get the next set of results if `maxResults` is specified, but more than `maxResults` objects are
            /// available in a list. For example, if you have a list of 200 objects and you call list with `maxResults`
            /// set to 20, list will return the first 20 objects and a token. Call list again with `maxResults` set to
            /// 20 and the token to get the next 20 objects.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Token { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/eventTicketObject";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("classId", new Google.Apis.Discovery.Parameter
                {
                    Name = "classId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                {
                    Name = "token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Modifies linked offer objects for the event ticket object with the given ID.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual ModifylinkedofferobjectsRequest Modifylinkedofferobjects(Google.Apis.Walletobjects.v1.Data.ModifyLinkedOfferObjectsRequest body, string resourceId)
        {
            return new ModifylinkedofferobjectsRequest(this.service, body, resourceId);
        }

        /// <summary>Modifies linked offer objects for the event ticket object with the given ID.</summary>
        public class ModifylinkedofferobjectsRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.EventTicketObject>
        {
            /// <summary>Constructs a new Modifylinkedofferobjects request.</summary>
            public ModifylinkedofferobjectsRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.ModifyLinkedOfferObjectsRequest body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This
            /// value should follow the format issuer ID. identifier where the former is issued by Google and latter is
            /// chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.ModifyLinkedOfferObjectsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "modifylinkedofferobjects";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/eventTicketObject/{resourceId}/modifyLinkedOfferObjects";

            /// <summary>Initializes Modifylinkedofferobjects parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates the event ticket object referenced by the given object ID. This method supports patch semantics.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.Walletobjects.v1.Data.EventTicketObject body, string resourceId)
        {
            return new PatchRequest(this.service, body, resourceId);
        }

        /// <summary>
        /// Updates the event ticket object referenced by the given object ID. This method supports patch semantics.
        /// </summary>
        public class PatchRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.EventTicketObject>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.EventTicketObject body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This
            /// value should follow the format issuer ID. identifier where the former is issued by Google and latter is
            /// chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.EventTicketObject Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/eventTicketObject/{resourceId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates the event ticket object referenced by the given object ID.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.Walletobjects.v1.Data.EventTicketObject body, string resourceId)
        {
            return new UpdateRequest(this.service, body, resourceId);
        }

        /// <summary>Updates the event ticket object referenced by the given object ID.</summary>
        public class UpdateRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.EventTicketObject>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.EventTicketObject body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This
            /// value should follow the format issuer ID. identifier where the former is issued by Google and latter is
            /// chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.EventTicketObject Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/eventTicketObject/{resourceId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "flightclass" collection of methods.</summary>
    public class FlightclassResource
    {
        private const string Resource = "flightclass";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public FlightclassResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Adds a message to the flight class referenced by the given class ID.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual AddmessageRequest Addmessage(Google.Apis.Walletobjects.v1.Data.AddMessageRequest body, string resourceId)
        {
            return new AddmessageRequest(this.service, body, resourceId);
        }

        /// <summary>Adds a message to the flight class referenced by the given class ID.</summary>
        public class AddmessageRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.FlightClassAddMessageResponse>
        {
            /// <summary>Constructs a new Addmessage request.</summary>
            public AddmessageRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.AddMessageRequest body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
            /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen
            /// by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.AddMessageRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "addmessage";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/flightClass/{resourceId}/addMessage";

            /// <summary>Initializes Addmessage parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Returns the flight class with the given class ID.</summary>
        /// <param name="resourceId">
        /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual GetRequest Get(string resourceId)
        {
            return new GetRequest(this.service, resourceId);
        }

        /// <summary>Returns the flight class with the given class ID.</summary>
        public class GetRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.FlightClass>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
            /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen
            /// by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/flightClass/{resourceId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts an flight class with the given ID and properties.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual InsertRequest Insert(Google.Apis.Walletobjects.v1.Data.FlightClass body)
        {
            return new InsertRequest(this.service, body);
        }

        /// <summary>Inserts an flight class with the given ID and properties.</summary>
        public class InsertRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.FlightClass>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.FlightClass body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.FlightClass Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/flightClass";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Returns a list of all flight classes for a given issuer ID.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Returns a list of all flight classes for a given issuer ID.</summary>
        public class ListRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.FlightClassListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>The ID of the issuer authorized to list classes.</summary>
            [Google.Apis.Util.RequestParameterAttribute("issuerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IssuerId { get; set; }

            /// <summary>
            /// Identifies the max number of results returned by a list. All results are returned if `maxResults` isn't
            /// defined.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>
            /// Used to get the next set of results if `maxResults` is specified, but more than `maxResults` classes are
            /// available in a list. For example, if you have a list of 200 classes and you call list with `maxResults`
            /// set to 20, list will return the first 20 classes and a token. Call list again with `maxResults` set to
            /// 20 and the token to get the next 20 classes.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Token { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/flightClass";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("issuerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "issuerId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                {
                    Name = "token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates the flight class referenced by the given class ID. This method supports patch semantics.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.Walletobjects.v1.Data.FlightClass body, string resourceId)
        {
            return new PatchRequest(this.service, body, resourceId);
        }

        /// <summary>
        /// Updates the flight class referenced by the given class ID. This method supports patch semantics.
        /// </summary>
        public class PatchRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.FlightClass>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.FlightClass body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
            /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen
            /// by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.FlightClass Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/flightClass/{resourceId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates the flight class referenced by the given class ID.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.Walletobjects.v1.Data.FlightClass body, string resourceId)
        {
            return new UpdateRequest(this.service, body, resourceId);
        }

        /// <summary>Updates the flight class referenced by the given class ID.</summary>
        public class UpdateRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.FlightClass>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.FlightClass body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
            /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen
            /// by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.FlightClass Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/flightClass/{resourceId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "flightobject" collection of methods.</summary>
    public class FlightobjectResource
    {
        private const string Resource = "flightobject";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public FlightobjectResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Adds a message to the flight object referenced by the given object ID.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual AddmessageRequest Addmessage(Google.Apis.Walletobjects.v1.Data.AddMessageRequest body, string resourceId)
        {
            return new AddmessageRequest(this.service, body, resourceId);
        }

        /// <summary>Adds a message to the flight object referenced by the given object ID.</summary>
        public class AddmessageRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.FlightObjectAddMessageResponse>
        {
            /// <summary>Constructs a new Addmessage request.</summary>
            public AddmessageRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.AddMessageRequest body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This
            /// value should follow the format issuer ID. identifier where the former is issued by Google and latter is
            /// chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.AddMessageRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "addmessage";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/flightObject/{resourceId}/addMessage";

            /// <summary>Initializes Addmessage parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Returns the flight object with the given object ID.</summary>
        /// <param name="resourceId">
        /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual GetRequest Get(string resourceId)
        {
            return new GetRequest(this.service, resourceId);
        }

        /// <summary>Returns the flight object with the given object ID.</summary>
        public class GetRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.FlightObject>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This
            /// value should follow the format issuer ID. identifier where the former is issued by Google and latter is
            /// chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/flightObject/{resourceId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts an flight object with the given ID and properties.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual InsertRequest Insert(Google.Apis.Walletobjects.v1.Data.FlightObject body)
        {
            return new InsertRequest(this.service, body);
        }

        /// <summary>Inserts an flight object with the given ID and properties.</summary>
        public class InsertRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.FlightObject>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.FlightObject body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.FlightObject Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/flightObject";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Returns a list of all flight objects for a given issuer ID.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Returns a list of all flight objects for a given issuer ID.</summary>
        public class ListRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.FlightObjectListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>The ID of the class whose objects will be listed.</summary>
            [Google.Apis.Util.RequestParameterAttribute("classId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClassId { get; set; }

            /// <summary>
            /// Identifies the max number of results returned by a list. All results are returned if `maxResults` isn't
            /// defined.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>
            /// Used to get the next set of results if `maxResults` is specified, but more than `maxResults` objects are
            /// available in a list. For example, if you have a list of 200 objects and you call list with `maxResults`
            /// set to 20, list will return the first 20 objects and a token. Call list again with `maxResults` set to
            /// 20 and the token to get the next 20 objects.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Token { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/flightObject";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("classId", new Google.Apis.Discovery.Parameter
                {
                    Name = "classId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                {
                    Name = "token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates the flight object referenced by the given object ID. This method supports patch semantics.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.Walletobjects.v1.Data.FlightObject body, string resourceId)
        {
            return new PatchRequest(this.service, body, resourceId);
        }

        /// <summary>
        /// Updates the flight object referenced by the given object ID. This method supports patch semantics.
        /// </summary>
        public class PatchRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.FlightObject>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.FlightObject body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This
            /// value should follow the format issuer ID. identifier where the former is issued by Google and latter is
            /// chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.FlightObject Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/flightObject/{resourceId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates the flight object referenced by the given object ID.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.Walletobjects.v1.Data.FlightObject body, string resourceId)
        {
            return new UpdateRequest(this.service, body, resourceId);
        }

        /// <summary>Updates the flight object referenced by the given object ID.</summary>
        public class UpdateRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.FlightObject>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.FlightObject body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This
            /// value should follow the format issuer ID. identifier where the former is issued by Google and latter is
            /// chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.FlightObject Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/flightObject/{resourceId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "genericclass" collection of methods.</summary>
    public class GenericclassResource
    {
        private const string Resource = "genericclass";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public GenericclassResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Adds a message to the generic class referenced by the given class ID.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual AddmessageRequest Addmessage(Google.Apis.Walletobjects.v1.Data.AddMessageRequest body, string resourceId)
        {
            return new AddmessageRequest(this.service, body, resourceId);
        }

        /// <summary>Adds a message to the generic class referenced by the given class ID.</summary>
        public class AddmessageRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.GenericClassAddMessageResponse>
        {
            /// <summary>Constructs a new Addmessage request.</summary>
            public AddmessageRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.AddMessageRequest body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
            /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen
            /// by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.AddMessageRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "addmessage";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/genericClass/{resourceId}/addMessage";

            /// <summary>Initializes Addmessage parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Returns the generic class with the given class ID.</summary>
        /// <param name="resourceId">
        /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
        /// needs to follow the format `issuerID.identifier` where `issuerID` is issued by Google and `identifier` is
        /// chosen by you. The unique identifier can only include alphanumeric characters, `.`, `_`, or `-`.
        /// </param>
        public virtual GetRequest Get(string resourceId)
        {
            return new GetRequest(this.service, resourceId);
        }

        /// <summary>Returns the generic class with the given class ID.</summary>
        public class GetRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.GenericClass>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
            /// needs to follow the format `issuerID.identifier` where `issuerID` is issued by Google and `identifier`
            /// is chosen by you. The unique identifier can only include alphanumeric characters, `.`, `_`, or `-`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/genericClass/{resourceId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts a generic class with the given ID and properties.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual InsertRequest Insert(Google.Apis.Walletobjects.v1.Data.GenericClass body)
        {
            return new InsertRequest(this.service, body);
        }

        /// <summary>Inserts a generic class with the given ID and properties.</summary>
        public class InsertRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.GenericClass>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.GenericClass body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.GenericClass Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/genericClass";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Returns a list of all generic classes for a given issuer ID.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Returns a list of all generic classes for a given issuer ID.</summary>
        public class ListRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.GenericClassListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>The ID of the issuer authorized to list classes.</summary>
            [Google.Apis.Util.RequestParameterAttribute("issuerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IssuerId { get; set; }

            /// <summary>
            /// Identifies the max number of results returned by a list. All results are returned if `maxResults` isn't
            /// defined.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>
            /// Used to get the next set of results if `maxResults` is specified, but more than `maxResults` classes are
            /// available in a list. For example, if you have a list of 200 classes and you call list with `maxResults`
            /// set to 20, list will return the first 20 classes and a token. Call list again with `maxResults` set to
            /// 20 and the token to get the next 20 classes.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Token { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/genericClass";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("issuerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "issuerId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                {
                    Name = "token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates the generic class referenced by the given class ID. This method supports patch semantics.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
        /// needs to follow the format `issuerID.identifier` where `issuerID` is issued by Google and `identifier` is
        /// chosen by you. The unique identifier can only include alphanumeric characters, `.`, `_`, or `-`.
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.Walletobjects.v1.Data.GenericClass body, string resourceId)
        {
            return new PatchRequest(this.service, body, resourceId);
        }

        /// <summary>
        /// Updates the generic class referenced by the given class ID. This method supports patch semantics.
        /// </summary>
        public class PatchRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.GenericClass>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.GenericClass body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
            /// needs to follow the format `issuerID.identifier` where `issuerID` is issued by Google and `identifier`
            /// is chosen by you. The unique identifier can only include alphanumeric characters, `.`, `_`, or `-`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.GenericClass Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/genericClass/{resourceId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates the Generic class referenced by the given class ID.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
        /// needs to follow the format `issuerID.identifier` where `issuerID` is issued by Google and `identifier` is
        /// chosen by you. The unique identifier can only include alphanumeric characters, `.`, `_`, or `-`.
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.Walletobjects.v1.Data.GenericClass body, string resourceId)
        {
            return new UpdateRequest(this.service, body, resourceId);
        }

        /// <summary>Updates the Generic class referenced by the given class ID.</summary>
        public class UpdateRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.GenericClass>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.GenericClass body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
            /// needs to follow the format `issuerID.identifier` where `issuerID` is issued by Google and `identifier`
            /// is chosen by you. The unique identifier can only include alphanumeric characters, `.`, `_`, or `-`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.GenericClass Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/genericClass/{resourceId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "genericobject" collection of methods.</summary>
    public class GenericobjectResource
    {
        private const string Resource = "genericobject";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public GenericobjectResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Adds a message to the generic object referenced by the given object ID.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for an object. This ID must be unique across all classes from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual AddmessageRequest Addmessage(Google.Apis.Walletobjects.v1.Data.AddMessageRequest body, string resourceId)
        {
            return new AddmessageRequest(this.service, body, resourceId);
        }

        /// <summary>Adds a message to the generic object referenced by the given object ID.</summary>
        public class AddmessageRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.GenericObjectAddMessageResponse>
        {
            /// <summary>Constructs a new Addmessage request.</summary>
            public AddmessageRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.AddMessageRequest body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for an object. This ID must be unique across all classes from an issuer. This
            /// value should follow the format issuer ID. identifier where the former is issued by Google and latter is
            /// chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.AddMessageRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "addmessage";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/genericObject/{resourceId}/addMessage";

            /// <summary>Initializes Addmessage parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Returns the generic object with the given object ID.</summary>
        /// <param name="resourceId">
        /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This value
        /// needs to follow the format `issuerID.identifier` where `issuerID` is issued by Google and `identifier` is
        /// chosen by you. The unique identifier can only include alphanumeric characters, `.`, `_`, or `-`.
        /// </param>
        public virtual GetRequest Get(string resourceId)
        {
            return new GetRequest(this.service, resourceId);
        }

        /// <summary>Returns the generic object with the given object ID.</summary>
        public class GetRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.GenericObject>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This
            /// value needs to follow the format `issuerID.identifier` where `issuerID` is issued by Google and
            /// `identifier` is chosen by you. The unique identifier can only include alphanumeric characters, `.`, `_`,
            /// or `-`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/genericObject/{resourceId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts a generic object with the given ID and properties.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual InsertRequest Insert(Google.Apis.Walletobjects.v1.Data.GenericObject body)
        {
            return new InsertRequest(this.service, body);
        }

        /// <summary>Inserts a generic object with the given ID and properties.</summary>
        public class InsertRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.GenericObject>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.GenericObject body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.GenericObject Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/genericObject";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Returns a list of all generic objects for a given issuer ID.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Returns a list of all generic objects for a given issuer ID.</summary>
        public class ListRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.GenericObjectListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>The ID of the class whose objects will be listed.</summary>
            [Google.Apis.Util.RequestParameterAttribute("classId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClassId { get; set; }

            /// <summary>
            /// Identifies the max number of results returned by a list. All results are returned if `maxResults` isn't
            /// defined.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>
            /// Used to get the next set of results if `maxResults` is specified, but more than `maxResults` objects are
            /// available in a list. For example, if you have a list of 200 objects and you call list with `maxResults`
            /// set to 20, list will return the first 20 objects and a token. Call list again with `maxResults` set to
            /// 20 and the token to get the next 20 objects.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Token { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/genericObject";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("classId", new Google.Apis.Discovery.Parameter
                {
                    Name = "classId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                {
                    Name = "token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates the generic object referenced by the given object ID. This method supports patch semantics.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This value
        /// needs to follow the format `issuerID.identifier` where `issuerID` is issued by Google and `identifier` is
        /// chosen by you. The unique identifier can only include alphanumeric characters, `.`, `_`, or `-`.
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.Walletobjects.v1.Data.GenericObject body, string resourceId)
        {
            return new PatchRequest(this.service, body, resourceId);
        }

        /// <summary>
        /// Updates the generic object referenced by the given object ID. This method supports patch semantics.
        /// </summary>
        public class PatchRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.GenericObject>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.GenericObject body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This
            /// value needs to follow the format `issuerID.identifier` where `issuerID` is issued by Google and
            /// `identifier` is chosen by you. The unique identifier can only include alphanumeric characters, `.`, `_`,
            /// or `-`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.GenericObject Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/genericObject/{resourceId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates the generic object referenced by the given object ID.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This value
        /// needs to follow the format `issuerID.identifier` where `issuerID` is issued by Google and `identifier` is
        /// chosen by you. The unique identifier can only include alphanumeric characters, `.`, `_`, or `-`.
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.Walletobjects.v1.Data.GenericObject body, string resourceId)
        {
            return new UpdateRequest(this.service, body, resourceId);
        }

        /// <summary>Updates the generic object referenced by the given object ID.</summary>
        public class UpdateRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.GenericObject>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.GenericObject body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This
            /// value needs to follow the format `issuerID.identifier` where `issuerID` is issued by Google and
            /// `identifier` is chosen by you. The unique identifier can only include alphanumeric characters, `.`, `_`,
            /// or `-`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.GenericObject Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/genericObject/{resourceId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "giftcardclass" collection of methods.</summary>
    public class GiftcardclassResource
    {
        private const string Resource = "giftcardclass";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public GiftcardclassResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Adds a message to the gift card class referenced by the given class ID.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual AddmessageRequest Addmessage(Google.Apis.Walletobjects.v1.Data.AddMessageRequest body, string resourceId)
        {
            return new AddmessageRequest(this.service, body, resourceId);
        }

        /// <summary>Adds a message to the gift card class referenced by the given class ID.</summary>
        public class AddmessageRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.GiftCardClassAddMessageResponse>
        {
            /// <summary>Constructs a new Addmessage request.</summary>
            public AddmessageRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.AddMessageRequest body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
            /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen
            /// by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.AddMessageRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "addmessage";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/giftCardClass/{resourceId}/addMessage";

            /// <summary>Initializes Addmessage parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Returns the gift card class with the given class ID.</summary>
        /// <param name="resourceId">
        /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual GetRequest Get(string resourceId)
        {
            return new GetRequest(this.service, resourceId);
        }

        /// <summary>Returns the gift card class with the given class ID.</summary>
        public class GetRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.GiftCardClass>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
            /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen
            /// by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/giftCardClass/{resourceId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts an gift card class with the given ID and properties.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual InsertRequest Insert(Google.Apis.Walletobjects.v1.Data.GiftCardClass body)
        {
            return new InsertRequest(this.service, body);
        }

        /// <summary>Inserts an gift card class with the given ID and properties.</summary>
        public class InsertRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.GiftCardClass>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.GiftCardClass body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.GiftCardClass Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/giftCardClass";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Returns a list of all gift card classes for a given issuer ID.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Returns a list of all gift card classes for a given issuer ID.</summary>
        public class ListRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.GiftCardClassListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>The ID of the issuer authorized to list classes.</summary>
            [Google.Apis.Util.RequestParameterAttribute("issuerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IssuerId { get; set; }

            /// <summary>
            /// Identifies the max number of results returned by a list. All results are returned if `maxResults` isn't
            /// defined.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>
            /// Used to get the next set of results if `maxResults` is specified, but more than `maxResults` classes are
            /// available in a list. For example, if you have a list of 200 classes and you call list with `maxResults`
            /// set to 20, list will return the first 20 classes and a token. Call list again with `maxResults` set to
            /// 20 and the token to get the next 20 classes.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Token { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/giftCardClass";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("issuerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "issuerId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                {
                    Name = "token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates the gift card class referenced by the given class ID. This method supports patch semantics.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.Walletobjects.v1.Data.GiftCardClass body, string resourceId)
        {
            return new PatchRequest(this.service, body, resourceId);
        }

        /// <summary>
        /// Updates the gift card class referenced by the given class ID. This method supports patch semantics.
        /// </summary>
        public class PatchRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.GiftCardClass>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.GiftCardClass body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
            /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen
            /// by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.GiftCardClass Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/giftCardClass/{resourceId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates the gift card class referenced by the given class ID.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.Walletobjects.v1.Data.GiftCardClass body, string resourceId)
        {
            return new UpdateRequest(this.service, body, resourceId);
        }

        /// <summary>Updates the gift card class referenced by the given class ID.</summary>
        public class UpdateRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.GiftCardClass>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.GiftCardClass body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
            /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen
            /// by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.GiftCardClass Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/giftCardClass/{resourceId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "giftcardobject" collection of methods.</summary>
    public class GiftcardobjectResource
    {
        private const string Resource = "giftcardobject";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public GiftcardobjectResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Adds a message to the gift card object referenced by the given object ID.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual AddmessageRequest Addmessage(Google.Apis.Walletobjects.v1.Data.AddMessageRequest body, string resourceId)
        {
            return new AddmessageRequest(this.service, body, resourceId);
        }

        /// <summary>Adds a message to the gift card object referenced by the given object ID.</summary>
        public class AddmessageRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.GiftCardObjectAddMessageResponse>
        {
            /// <summary>Constructs a new Addmessage request.</summary>
            public AddmessageRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.AddMessageRequest body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This
            /// value should follow the format issuer ID. identifier where the former is issued by Google and latter is
            /// chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.AddMessageRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "addmessage";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/giftCardObject/{resourceId}/addMessage";

            /// <summary>Initializes Addmessage parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Returns the gift card object with the given object ID.</summary>
        /// <param name="resourceId">
        /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual GetRequest Get(string resourceId)
        {
            return new GetRequest(this.service, resourceId);
        }

        /// <summary>Returns the gift card object with the given object ID.</summary>
        public class GetRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.GiftCardObject>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This
            /// value should follow the format issuer ID. identifier where the former is issued by Google and latter is
            /// chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/giftCardObject/{resourceId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts an gift card object with the given ID and properties.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual InsertRequest Insert(Google.Apis.Walletobjects.v1.Data.GiftCardObject body)
        {
            return new InsertRequest(this.service, body);
        }

        /// <summary>Inserts an gift card object with the given ID and properties.</summary>
        public class InsertRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.GiftCardObject>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.GiftCardObject body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.GiftCardObject Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/giftCardObject";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Returns a list of all gift card objects for a given issuer ID.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Returns a list of all gift card objects for a given issuer ID.</summary>
        public class ListRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.GiftCardObjectListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>The ID of the class whose objects will be listed.</summary>
            [Google.Apis.Util.RequestParameterAttribute("classId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClassId { get; set; }

            /// <summary>
            /// Identifies the max number of results returned by a list. All results are returned if `maxResults` isn't
            /// defined.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>
            /// Used to get the next set of results if `maxResults` is specified, but more than `maxResults` objects are
            /// available in a list. For example, if you have a list of 200 objects and you call list with `maxResults`
            /// set to 20, list will return the first 20 objects and a token. Call list again with `maxResults` set to
            /// 20 and the token to get the next 20 objects.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Token { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/giftCardObject";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("classId", new Google.Apis.Discovery.Parameter
                {
                    Name = "classId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                {
                    Name = "token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates the gift card object referenced by the given object ID. This method supports patch semantics.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.Walletobjects.v1.Data.GiftCardObject body, string resourceId)
        {
            return new PatchRequest(this.service, body, resourceId);
        }

        /// <summary>
        /// Updates the gift card object referenced by the given object ID. This method supports patch semantics.
        /// </summary>
        public class PatchRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.GiftCardObject>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.GiftCardObject body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This
            /// value should follow the format issuer ID. identifier where the former is issued by Google and latter is
            /// chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.GiftCardObject Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/giftCardObject/{resourceId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates the gift card object referenced by the given object ID.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.Walletobjects.v1.Data.GiftCardObject body, string resourceId)
        {
            return new UpdateRequest(this.service, body, resourceId);
        }

        /// <summary>Updates the gift card object referenced by the given object ID.</summary>
        public class UpdateRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.GiftCardObject>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.GiftCardObject body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This
            /// value should follow the format issuer ID. identifier where the former is issued by Google and latter is
            /// chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.GiftCardObject Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/giftCardObject/{resourceId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "issuer" collection of methods.</summary>
    public class IssuerResource
    {
        private const string Resource = "issuer";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public IssuerResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Returns the issuer with the given issuer ID.</summary>
        /// <param name="resourceId">The unique identifier for an issuer.</param>
        public virtual GetRequest Get(long resourceId)
        {
            return new GetRequest(this.service, resourceId);
        }

        /// <summary>Returns the issuer with the given issuer ID.</summary>
        public class GetRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.Issuer>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, long resourceId) : base(service)
            {
                ResourceId = resourceId;
                InitParameters();
            }

            /// <summary>The unique identifier for an issuer.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long ResourceId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/issuer/{resourceId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts an issuer with the given ID and properties.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual InsertRequest Insert(Google.Apis.Walletobjects.v1.Data.Issuer body)
        {
            return new InsertRequest(this.service, body);
        }

        /// <summary>Inserts an issuer with the given ID and properties.</summary>
        public class InsertRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.Issuer>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.Issuer body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.Issuer Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/issuer";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Returns a list of all issuers shared to the caller.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Returns a list of all issuers shared to the caller.</summary>
        public class ListRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.IssuerListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/issuer";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Updates the issuer referenced by the given issuer ID. This method supports patch semantics.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">The unique identifier for an issuer.</param>
        public virtual PatchRequest Patch(Google.Apis.Walletobjects.v1.Data.Issuer body, long resourceId)
        {
            return new PatchRequest(this.service, body, resourceId);
        }

        /// <summary>
        /// Updates the issuer referenced by the given issuer ID. This method supports patch semantics.
        /// </summary>
        public class PatchRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.Issuer>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.Issuer body, long resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>The unique identifier for an issuer.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.Issuer Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/issuer/{resourceId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates the issuer referenced by the given issuer ID.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">The unique identifier for an issuer.</param>
        public virtual UpdateRequest Update(Google.Apis.Walletobjects.v1.Data.Issuer body, long resourceId)
        {
            return new UpdateRequest(this.service, body, resourceId);
        }

        /// <summary>Updates the issuer referenced by the given issuer ID.</summary>
        public class UpdateRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.Issuer>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.Issuer body, long resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>The unique identifier for an issuer.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.Issuer Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/issuer/{resourceId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "jwt" collection of methods.</summary>
    public class JwtResource
    {
        private const string Resource = "jwt";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public JwtResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Inserts the resources in the JWT.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual InsertRequest Insert(Google.Apis.Walletobjects.v1.Data.JwtResource body)
        {
            return new InsertRequest(this.service, body);
        }

        /// <summary>Inserts the resources in the JWT.</summary>
        public class InsertRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.JwtInsertResponse>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.JwtResource body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.JwtResource Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/jwt";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "loyaltyclass" collection of methods.</summary>
    public class LoyaltyclassResource
    {
        private const string Resource = "loyaltyclass";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public LoyaltyclassResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Adds a message to the loyalty class referenced by the given class ID.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual AddmessageRequest Addmessage(Google.Apis.Walletobjects.v1.Data.AddMessageRequest body, string resourceId)
        {
            return new AddmessageRequest(this.service, body, resourceId);
        }

        /// <summary>Adds a message to the loyalty class referenced by the given class ID.</summary>
        public class AddmessageRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.LoyaltyClassAddMessageResponse>
        {
            /// <summary>Constructs a new Addmessage request.</summary>
            public AddmessageRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.AddMessageRequest body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
            /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen
            /// by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.AddMessageRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "addmessage";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/loyaltyClass/{resourceId}/addMessage";

            /// <summary>Initializes Addmessage parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Returns the loyalty class with the given class ID.</summary>
        /// <param name="resourceId">
        /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual GetRequest Get(string resourceId)
        {
            return new GetRequest(this.service, resourceId);
        }

        /// <summary>Returns the loyalty class with the given class ID.</summary>
        public class GetRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.LoyaltyClass>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
            /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen
            /// by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/loyaltyClass/{resourceId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts an loyalty class with the given ID and properties.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual InsertRequest Insert(Google.Apis.Walletobjects.v1.Data.LoyaltyClass body)
        {
            return new InsertRequest(this.service, body);
        }

        /// <summary>Inserts an loyalty class with the given ID and properties.</summary>
        public class InsertRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.LoyaltyClass>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.LoyaltyClass body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.LoyaltyClass Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/loyaltyClass";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Returns a list of all loyalty classes for a given issuer ID.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Returns a list of all loyalty classes for a given issuer ID.</summary>
        public class ListRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.LoyaltyClassListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>The ID of the issuer authorized to list classes.</summary>
            [Google.Apis.Util.RequestParameterAttribute("issuerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IssuerId { get; set; }

            /// <summary>
            /// Identifies the max number of results returned by a list. All results are returned if `maxResults` isn't
            /// defined.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>
            /// Used to get the next set of results if `maxResults` is specified, but more than `maxResults` classes are
            /// available in a list. For example, if you have a list of 200 classes and you call list with `maxResults`
            /// set to 20, list will return the first 20 classes and a token. Call list again with `maxResults` set to
            /// 20 and the token to get the next 20 classes.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Token { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/loyaltyClass";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("issuerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "issuerId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                {
                    Name = "token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates the loyalty class referenced by the given class ID. This method supports patch semantics.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.Walletobjects.v1.Data.LoyaltyClass body, string resourceId)
        {
            return new PatchRequest(this.service, body, resourceId);
        }

        /// <summary>
        /// Updates the loyalty class referenced by the given class ID. This method supports patch semantics.
        /// </summary>
        public class PatchRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.LoyaltyClass>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.LoyaltyClass body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
            /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen
            /// by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.LoyaltyClass Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/loyaltyClass/{resourceId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates the loyalty class referenced by the given class ID.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.Walletobjects.v1.Data.LoyaltyClass body, string resourceId)
        {
            return new UpdateRequest(this.service, body, resourceId);
        }

        /// <summary>Updates the loyalty class referenced by the given class ID.</summary>
        public class UpdateRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.LoyaltyClass>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.LoyaltyClass body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
            /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen
            /// by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.LoyaltyClass Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/loyaltyClass/{resourceId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "loyaltyobject" collection of methods.</summary>
    public class LoyaltyobjectResource
    {
        private const string Resource = "loyaltyobject";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public LoyaltyobjectResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Adds a message to the loyalty object referenced by the given object ID.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual AddmessageRequest Addmessage(Google.Apis.Walletobjects.v1.Data.AddMessageRequest body, string resourceId)
        {
            return new AddmessageRequest(this.service, body, resourceId);
        }

        /// <summary>Adds a message to the loyalty object referenced by the given object ID.</summary>
        public class AddmessageRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.LoyaltyObjectAddMessageResponse>
        {
            /// <summary>Constructs a new Addmessage request.</summary>
            public AddmessageRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.AddMessageRequest body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This
            /// value should follow the format issuer ID. identifier where the former is issued by Google and latter is
            /// chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.AddMessageRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "addmessage";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/loyaltyObject/{resourceId}/addMessage";

            /// <summary>Initializes Addmessage parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Returns the loyalty object with the given object ID.</summary>
        /// <param name="resourceId">
        /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual GetRequest Get(string resourceId)
        {
            return new GetRequest(this.service, resourceId);
        }

        /// <summary>Returns the loyalty object with the given object ID.</summary>
        public class GetRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.LoyaltyObject>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This
            /// value should follow the format issuer ID. identifier where the former is issued by Google and latter is
            /// chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/loyaltyObject/{resourceId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts an loyalty object with the given ID and properties.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual InsertRequest Insert(Google.Apis.Walletobjects.v1.Data.LoyaltyObject body)
        {
            return new InsertRequest(this.service, body);
        }

        /// <summary>Inserts an loyalty object with the given ID and properties.</summary>
        public class InsertRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.LoyaltyObject>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.LoyaltyObject body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.LoyaltyObject Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/loyaltyObject";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Returns a list of all loyalty objects for a given issuer ID.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Returns a list of all loyalty objects for a given issuer ID.</summary>
        public class ListRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.LoyaltyObjectListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>The ID of the class whose objects will be listed.</summary>
            [Google.Apis.Util.RequestParameterAttribute("classId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClassId { get; set; }

            /// <summary>
            /// Identifies the max number of results returned by a list. All results are returned if `maxResults` isn't
            /// defined.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>
            /// Used to get the next set of results if `maxResults` is specified, but more than `maxResults` objects are
            /// available in a list. For example, if you have a list of 200 objects and you call list with `maxResults`
            /// set to 20, list will return the first 20 objects and a token. Call list again with `maxResults` set to
            /// 20 and the token to get the next 20 objects.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Token { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/loyaltyObject";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("classId", new Google.Apis.Discovery.Parameter
                {
                    Name = "classId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                {
                    Name = "token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Modifies linked offer objects for the loyalty object with the given ID.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual ModifylinkedofferobjectsRequest Modifylinkedofferobjects(Google.Apis.Walletobjects.v1.Data.ModifyLinkedOfferObjectsRequest body, string resourceId)
        {
            return new ModifylinkedofferobjectsRequest(this.service, body, resourceId);
        }

        /// <summary>Modifies linked offer objects for the loyalty object with the given ID.</summary>
        public class ModifylinkedofferobjectsRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.LoyaltyObject>
        {
            /// <summary>Constructs a new Modifylinkedofferobjects request.</summary>
            public ModifylinkedofferobjectsRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.ModifyLinkedOfferObjectsRequest body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This
            /// value should follow the format issuer ID. identifier where the former is issued by Google and latter is
            /// chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.ModifyLinkedOfferObjectsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "modifylinkedofferobjects";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/loyaltyObject/{resourceId}/modifyLinkedOfferObjects";

            /// <summary>Initializes Modifylinkedofferobjects parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates the loyalty object referenced by the given object ID. This method supports patch semantics.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.Walletobjects.v1.Data.LoyaltyObject body, string resourceId)
        {
            return new PatchRequest(this.service, body, resourceId);
        }

        /// <summary>
        /// Updates the loyalty object referenced by the given object ID. This method supports patch semantics.
        /// </summary>
        public class PatchRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.LoyaltyObject>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.LoyaltyObject body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This
            /// value should follow the format issuer ID. identifier where the former is issued by Google and latter is
            /// chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.LoyaltyObject Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/loyaltyObject/{resourceId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates the loyalty object referenced by the given object ID.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.Walletobjects.v1.Data.LoyaltyObject body, string resourceId)
        {
            return new UpdateRequest(this.service, body, resourceId);
        }

        /// <summary>Updates the loyalty object referenced by the given object ID.</summary>
        public class UpdateRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.LoyaltyObject>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.LoyaltyObject body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This
            /// value should follow the format issuer ID. identifier where the former is issued by Google and latter is
            /// chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.LoyaltyObject Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/loyaltyObject/{resourceId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "media" collection of methods.</summary>
    public class MediaResource
    {
        private const string Resource = "media";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public MediaResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Downloads rotating barcode values for the transit object referenced by the given object ID.
        /// </summary>
        /// <param name="resourceId">
        /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual DownloadRequest Download(string resourceId)
        {
            return new DownloadRequest(this.service, resourceId);
        }

        /// <summary>
        /// Downloads rotating barcode values for the transit object referenced by the given object ID.
        /// </summary>
        public class DownloadRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.Media>
        {
            /// <summary>Constructs a new Download request.</summary>
            public DownloadRequest(Google.Apis.Services.IClientService service, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                MediaDownloader = new Google.Apis.Download.MediaDownloader(service);
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This
            /// value should follow the format issuer ID. identifier where the former is issued by Google and latter is
            /// chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "download";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/transitObject/{resourceId}/downloadRotatingBarcodeValues";

            /// <summary>Initializes Download parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

            /// <summary>Gets the media downloader.</summary>
            public Google.Apis.Download.IMediaDownloader MediaDownloader { get; private set; }

            /// <summary>
            /// <para>Synchronously download the media into the given stream.</para>
            /// <para>
            /// Warning: This method hides download errors; use <see cref="DownloadWithStatus(System.IO.Stream)"/>
            /// instead.
            /// </para>
            /// </summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual void Download(System.IO.Stream stream)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = null;
                mediaDownloader.Download(this.GenerateRequestUri(), stream);
            }

            /// <summary>Synchronously download the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            /// <returns>The final status of the download; including whether the download succeeded or failed.</returns>
            public virtual Google.Apis.Download.IDownloadProgress DownloadWithStatus(System.IO.Stream stream)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = null;
                return mediaDownloader.Download(this.GenerateRequestUri(), stream);
            }

            /// <summary>Asynchronously download the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadAsync(System.IO.Stream stream)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = null;
                return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream);
            }

            /// <summary>Asynchronously download the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadAsync(System.IO.Stream stream,
                System.Threading.CancellationToken cancellationToken)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = null;
                return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream, cancellationToken);
            }

            /// <summary>Synchronously download a range of the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual Google.Apis.Download.IDownloadProgress DownloadRange(System.IO.Stream stream, System.Net.Http.Headers.RangeHeaderValue range)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = range;
                return mediaDownloader.Download(this.GenerateRequestUri(), stream);
            }

            /// <summary>Asynchronously download a range of the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadRangeAsync(System.IO.Stream stream,
                System.Net.Http.Headers.RangeHeaderValue range,
                System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = range;
                return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream, cancellationToken);
            }
        }

        /// <summary>
        /// Uploads rotating barcode values for the transit object referenced by the given object ID. Note the max
        /// upload size is specified in
        /// google3/production/config/cdd/apps-upload/customers/payments-consumer-passes/config.gcl and enforced by
        /// Scotty.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual UploadRequest Upload(Google.Apis.Walletobjects.v1.Data.TransitObjectUploadRotatingBarcodeValuesRequest body, string resourceId)
        {
            return new UploadRequest(this.service, body, resourceId);
        }

        /// <summary>
        /// Uploads rotating barcode values for the transit object referenced by the given object ID. Note the max
        /// upload size is specified in
        /// google3/production/config/cdd/apps-upload/customers/payments-consumer-passes/config.gcl and enforced by
        /// Scotty.
        /// </summary>
        public class UploadRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.TransitObjectUploadRotatingBarcodeValuesResponse>
        {
            /// <summary>Constructs a new Upload request.</summary>
            public UploadRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.TransitObjectUploadRotatingBarcodeValuesRequest body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This
            /// value should follow the format issuer ID. identifier where the former is issued by Google and latter is
            /// chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.TransitObjectUploadRotatingBarcodeValuesRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "upload";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/transitObject/{resourceId}/uploadRotatingBarcodeValues";

            /// <summary>Initializes Upload parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Uploads rotating barcode values for the transit object referenced by the given object ID. Note the max
        /// upload size is specified in
        /// google3/production/config/cdd/apps-upload/customers/payments-consumer-passes/config.gcl and enforced by
        /// Scotty.
        /// </summary>
        /// <remarks>
        /// Considerations regarding <paramref name="stream"/>:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before reading
        /// commences. If <paramref name="stream"/> is not seekable, then it will be read from its current position
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is completed
        /// </description>
        /// </item>
        /// <item><description>Caller is responsible for closing the <paramref name="stream"/></description></item>
        /// </list>
        /// </remarks>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        /// <param name="stream">The stream to upload. See remarks for further information.</param>
        /// <param name="contentType">The content type of the stream to upload.</param>
        public virtual UploadMediaUpload Upload(Google.Apis.Walletobjects.v1.Data.TransitObjectUploadRotatingBarcodeValuesRequest body, string resourceId, System.IO.Stream stream, string contentType)
        {
            return new UploadMediaUpload(service, body, resourceId, stream, contentType);
        }

        /// <summary>Upload media upload which supports resumable upload.</summary>
        public class UploadMediaUpload : Google.Apis.Upload.ResumableUpload<Google.Apis.Walletobjects.v1.Data.TransitObjectUploadRotatingBarcodeValuesRequest, Google.Apis.Walletobjects.v1.Data.TransitObjectUploadRotatingBarcodeValuesResponse>
        {
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
            /// API key. Your API key identifies your project and provides you with API access, quota, and reports.
            /// Required unless you provide an OAuth 2.0 token.
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
            /// Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned
            /// to a user, but should not exceed 40 characters.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string QuotaUser { get; set; }

            /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
            [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UploadType { get; set; }

            /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
            [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UploadProtocol { get; set; }

            /// <summary>
            /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This
            /// value should follow the format issuer ID. identifier where the former is issued by Google and latter is
            /// chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Constructs a new Upload media upload instance.</summary>
            /// <remarks>
            /// Considerations regarding <paramref name="stream"/>:
            /// <list type="bullet">
            /// <item>
            /// <description>
            /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before
            /// reading commences. If <paramref name="stream"/> is not seekable, then it will be read from its current
            /// position
            /// </description>
            /// </item>
            /// <item>
            /// <description>
            /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is completed
            /// </description>
            /// </item>
            /// <item><description>Caller is responsible for closing the <paramref name="stream"/></description></item>
            /// </list>
            /// </remarks>
            public UploadMediaUpload(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.TransitObjectUploadRotatingBarcodeValuesRequest body, string resourceId, System.IO.Stream stream, string contentType)
                : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "walletobjects/v1/transitObject/{resourceId}/uploadRotatingBarcodeValues"), "POST", stream, contentType)
            {
                ResourceId = resourceId;
                Body = body;
            }
        }
    }

    /// <summary>The "offerclass" collection of methods.</summary>
    public class OfferclassResource
    {
        private const string Resource = "offerclass";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public OfferclassResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Adds a message to the offer class referenced by the given class ID.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual AddmessageRequest Addmessage(Google.Apis.Walletobjects.v1.Data.AddMessageRequest body, string resourceId)
        {
            return new AddmessageRequest(this.service, body, resourceId);
        }

        /// <summary>Adds a message to the offer class referenced by the given class ID.</summary>
        public class AddmessageRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.OfferClassAddMessageResponse>
        {
            /// <summary>Constructs a new Addmessage request.</summary>
            public AddmessageRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.AddMessageRequest body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
            /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen
            /// by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.AddMessageRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "addmessage";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/offerClass/{resourceId}/addMessage";

            /// <summary>Initializes Addmessage parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Returns the offer class with the given class ID.</summary>
        /// <param name="resourceId">
        /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual GetRequest Get(string resourceId)
        {
            return new GetRequest(this.service, resourceId);
        }

        /// <summary>Returns the offer class with the given class ID.</summary>
        public class GetRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.OfferClass>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
            /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen
            /// by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/offerClass/{resourceId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts an offer class with the given ID and properties.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual InsertRequest Insert(Google.Apis.Walletobjects.v1.Data.OfferClass body)
        {
            return new InsertRequest(this.service, body);
        }

        /// <summary>Inserts an offer class with the given ID and properties.</summary>
        public class InsertRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.OfferClass>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.OfferClass body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.OfferClass Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/offerClass";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Returns a list of all offer classes for a given issuer ID.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Returns a list of all offer classes for a given issuer ID.</summary>
        public class ListRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.OfferClassListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>The ID of the issuer authorized to list classes.</summary>
            [Google.Apis.Util.RequestParameterAttribute("issuerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IssuerId { get; set; }

            /// <summary>
            /// Identifies the max number of results returned by a list. All results are returned if `maxResults` isn't
            /// defined.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>
            /// Used to get the next set of results if `maxResults` is specified, but more than `maxResults` classes are
            /// available in a list. For example, if you have a list of 200 classes and you call list with `maxResults`
            /// set to 20, list will return the first 20 classes and a token. Call list again with `maxResults` set to
            /// 20 and the token to get the next 20 classes.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Token { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/offerClass";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("issuerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "issuerId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                {
                    Name = "token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates the offer class referenced by the given class ID. This method supports patch semantics.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.Walletobjects.v1.Data.OfferClass body, string resourceId)
        {
            return new PatchRequest(this.service, body, resourceId);
        }

        /// <summary>
        /// Updates the offer class referenced by the given class ID. This method supports patch semantics.
        /// </summary>
        public class PatchRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.OfferClass>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.OfferClass body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
            /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen
            /// by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.OfferClass Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/offerClass/{resourceId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates the offer class referenced by the given class ID.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.Walletobjects.v1.Data.OfferClass body, string resourceId)
        {
            return new UpdateRequest(this.service, body, resourceId);
        }

        /// <summary>Updates the offer class referenced by the given class ID.</summary>
        public class UpdateRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.OfferClass>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.OfferClass body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
            /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen
            /// by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.OfferClass Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/offerClass/{resourceId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "offerobject" collection of methods.</summary>
    public class OfferobjectResource
    {
        private const string Resource = "offerobject";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public OfferobjectResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Adds a message to the offer object referenced by the given object ID.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual AddmessageRequest Addmessage(Google.Apis.Walletobjects.v1.Data.AddMessageRequest body, string resourceId)
        {
            return new AddmessageRequest(this.service, body, resourceId);
        }

        /// <summary>Adds a message to the offer object referenced by the given object ID.</summary>
        public class AddmessageRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.OfferObjectAddMessageResponse>
        {
            /// <summary>Constructs a new Addmessage request.</summary>
            public AddmessageRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.AddMessageRequest body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This
            /// value should follow the format issuer ID. identifier where the former is issued by Google and latter is
            /// chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.AddMessageRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "addmessage";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/offerObject/{resourceId}/addMessage";

            /// <summary>Initializes Addmessage parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Returns the offer object with the given object ID.</summary>
        /// <param name="resourceId">
        /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual GetRequest Get(string resourceId)
        {
            return new GetRequest(this.service, resourceId);
        }

        /// <summary>Returns the offer object with the given object ID.</summary>
        public class GetRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.OfferObject>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This
            /// value should follow the format issuer ID. identifier where the former is issued by Google and latter is
            /// chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/offerObject/{resourceId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts an offer object with the given ID and properties.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual InsertRequest Insert(Google.Apis.Walletobjects.v1.Data.OfferObject body)
        {
            return new InsertRequest(this.service, body);
        }

        /// <summary>Inserts an offer object with the given ID and properties.</summary>
        public class InsertRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.OfferObject>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.OfferObject body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.OfferObject Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/offerObject";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Returns a list of all offer objects for a given issuer ID.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Returns a list of all offer objects for a given issuer ID.</summary>
        public class ListRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.OfferObjectListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>The ID of the class whose objects will be listed.</summary>
            [Google.Apis.Util.RequestParameterAttribute("classId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClassId { get; set; }

            /// <summary>
            /// Identifies the max number of results returned by a list. All results are returned if `maxResults` isn't
            /// defined.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>
            /// Used to get the next set of results if `maxResults` is specified, but more than `maxResults` objects are
            /// available in a list. For example, if you have a list of 200 objects and you call list with `maxResults`
            /// set to 20, list will return the first 20 objects and a token. Call list again with `maxResults` set to
            /// 20 and the token to get the next 20 objects.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Token { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/offerObject";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("classId", new Google.Apis.Discovery.Parameter
                {
                    Name = "classId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                {
                    Name = "token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates the offer object referenced by the given object ID. This method supports patch semantics.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.Walletobjects.v1.Data.OfferObject body, string resourceId)
        {
            return new PatchRequest(this.service, body, resourceId);
        }

        /// <summary>
        /// Updates the offer object referenced by the given object ID. This method supports patch semantics.
        /// </summary>
        public class PatchRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.OfferObject>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.OfferObject body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This
            /// value should follow the format issuer ID. identifier where the former is issued by Google and latter is
            /// chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.OfferObject Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/offerObject/{resourceId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates the offer object referenced by the given object ID.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.Walletobjects.v1.Data.OfferObject body, string resourceId)
        {
            return new UpdateRequest(this.service, body, resourceId);
        }

        /// <summary>Updates the offer object referenced by the given object ID.</summary>
        public class UpdateRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.OfferObject>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.OfferObject body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This
            /// value should follow the format issuer ID. identifier where the former is issued by Google and latter is
            /// chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.OfferObject Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/offerObject/{resourceId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "permissions" collection of methods.</summary>
    public class PermissionsResource
    {
        private const string Resource = "permissions";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PermissionsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Returns the permissions for the given issuer id.</summary>
        /// <param name="resourceId">
        /// The unique identifier for an issuer. This ID must be unique across all issuers.
        /// </param>
        public virtual GetRequest Get(long resourceId)
        {
            return new GetRequest(this.service, resourceId);
        }

        /// <summary>Returns the permissions for the given issuer id.</summary>
        public class GetRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.Permissions>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, long resourceId) : base(service)
            {
                ResourceId = resourceId;
                InitParameters();
            }

            /// <summary>The unique identifier for an issuer. This ID must be unique across all issuers.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long ResourceId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/permissions/{resourceId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates the permissions for the given issuer.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for an issuer. This ID must be unique across all issuers.
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.Walletobjects.v1.Data.Permissions body, long resourceId)
        {
            return new UpdateRequest(this.service, body, resourceId);
        }

        /// <summary>Updates the permissions for the given issuer.</summary>
        public class UpdateRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.Permissions>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.Permissions body, long resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>The unique identifier for an issuer. This ID must be unique across all issuers.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.Permissions Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/permissions/{resourceId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "smarttap" collection of methods.</summary>
    public class SmarttapResource
    {
        private const string Resource = "smarttap";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public SmarttapResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Inserts the smart tap.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual InsertRequest Insert(Google.Apis.Walletobjects.v1.Data.SmartTap body)
        {
            return new InsertRequest(this.service, body);
        }

        /// <summary>Inserts the smart tap.</summary>
        public class InsertRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.SmartTap>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.SmartTap body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.SmartTap Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/smartTap";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "transitclass" collection of methods.</summary>
    public class TransitclassResource
    {
        private const string Resource = "transitclass";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public TransitclassResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Adds a message to the transit class referenced by the given class ID.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual AddmessageRequest Addmessage(Google.Apis.Walletobjects.v1.Data.AddMessageRequest body, string resourceId)
        {
            return new AddmessageRequest(this.service, body, resourceId);
        }

        /// <summary>Adds a message to the transit class referenced by the given class ID.</summary>
        public class AddmessageRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.TransitClassAddMessageResponse>
        {
            /// <summary>Constructs a new Addmessage request.</summary>
            public AddmessageRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.AddMessageRequest body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
            /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen
            /// by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.AddMessageRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "addmessage";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/transitClass/{resourceId}/addMessage";

            /// <summary>Initializes Addmessage parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Returns the transit class with the given class ID.</summary>
        /// <param name="resourceId">
        /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual GetRequest Get(string resourceId)
        {
            return new GetRequest(this.service, resourceId);
        }

        /// <summary>Returns the transit class with the given class ID.</summary>
        public class GetRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.TransitClass>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
            /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen
            /// by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/transitClass/{resourceId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts a transit class with the given ID and properties.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual InsertRequest Insert(Google.Apis.Walletobjects.v1.Data.TransitClass body)
        {
            return new InsertRequest(this.service, body);
        }

        /// <summary>Inserts a transit class with the given ID and properties.</summary>
        public class InsertRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.TransitClass>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.TransitClass body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.TransitClass Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/transitClass";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Returns a list of all transit classes for a given issuer ID.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Returns a list of all transit classes for a given issuer ID.</summary>
        public class ListRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.TransitClassListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>The ID of the issuer authorized to list classes.</summary>
            [Google.Apis.Util.RequestParameterAttribute("issuerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IssuerId { get; set; }

            /// <summary>
            /// Identifies the max number of results returned by a list. All results are returned if `maxResults` isn't
            /// defined.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>
            /// Used to get the next set of results if `maxResults` is specified, but more than `maxResults` classes are
            /// available in a list. For example, if you have a list of 200 classes and you call list with `maxResults`
            /// set to 20, list will return the first 20 classes and a token. Call list again with `maxResults` set to
            /// 20 and the token to get the next 20 classes.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Token { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/transitClass";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("issuerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "issuerId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                {
                    Name = "token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates the transit class referenced by the given class ID. This method supports patch semantics.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.Walletobjects.v1.Data.TransitClass body, string resourceId)
        {
            return new PatchRequest(this.service, body, resourceId);
        }

        /// <summary>
        /// Updates the transit class referenced by the given class ID. This method supports patch semantics.
        /// </summary>
        public class PatchRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.TransitClass>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.TransitClass body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
            /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen
            /// by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.TransitClass Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/transitClass/{resourceId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates the transit class referenced by the given class ID.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.Walletobjects.v1.Data.TransitClass body, string resourceId)
        {
            return new UpdateRequest(this.service, body, resourceId);
        }

        /// <summary>Updates the transit class referenced by the given class ID.</summary>
        public class UpdateRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.TransitClass>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.TransitClass body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for a class. This ID must be unique across all classes from an issuer. This value
            /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen
            /// by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.TransitClass Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/transitClass/{resourceId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "transitobject" collection of methods.</summary>
    public class TransitobjectResource
    {
        private const string Resource = "transitobject";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public TransitobjectResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Adds a message to the transit object referenced by the given object ID.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual AddmessageRequest Addmessage(Google.Apis.Walletobjects.v1.Data.AddMessageRequest body, string resourceId)
        {
            return new AddmessageRequest(this.service, body, resourceId);
        }

        /// <summary>Adds a message to the transit object referenced by the given object ID.</summary>
        public class AddmessageRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.TransitObjectAddMessageResponse>
        {
            /// <summary>Constructs a new Addmessage request.</summary>
            public AddmessageRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.AddMessageRequest body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This
            /// value should follow the format issuer ID. identifier where the former is issued by Google and latter is
            /// chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.AddMessageRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "addmessage";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/transitObject/{resourceId}/addMessage";

            /// <summary>Initializes Addmessage parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Returns the transit object with the given object ID.</summary>
        /// <param name="resourceId">
        /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual GetRequest Get(string resourceId)
        {
            return new GetRequest(this.service, resourceId);
        }

        /// <summary>Returns the transit object with the given object ID.</summary>
        public class GetRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.TransitObject>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This
            /// value should follow the format issuer ID. identifier where the former is issued by Google and latter is
            /// chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/transitObject/{resourceId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts an transit object with the given ID and properties.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual InsertRequest Insert(Google.Apis.Walletobjects.v1.Data.TransitObject body)
        {
            return new InsertRequest(this.service, body);
        }

        /// <summary>Inserts an transit object with the given ID and properties.</summary>
        public class InsertRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.TransitObject>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.TransitObject body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.TransitObject Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/transitObject";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Returns a list of all transit objects for a given issuer ID.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Returns a list of all transit objects for a given issuer ID.</summary>
        public class ListRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.TransitObjectListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>The ID of the class whose objects will be listed.</summary>
            [Google.Apis.Util.RequestParameterAttribute("classId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ClassId { get; set; }

            /// <summary>
            /// Identifies the max number of results returned by a list. All results are returned if `maxResults` isn't
            /// defined.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>
            /// Used to get the next set of results if `maxResults` is specified, but more than `maxResults` objects are
            /// available in a list. For example, if you have a list of 200 objects and you call list with `maxResults`
            /// set to 20, list will return the first 20 objects and a token. Call list again with `maxResults` set to
            /// 20 and the token to get the next 20 objects.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Token { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/transitObject";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("classId", new Google.Apis.Discovery.Parameter
                {
                    Name = "classId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                {
                    Name = "token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates the transit object referenced by the given object ID. This method supports patch semantics.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.Walletobjects.v1.Data.TransitObject body, string resourceId)
        {
            return new PatchRequest(this.service, body, resourceId);
        }

        /// <summary>
        /// Updates the transit object referenced by the given object ID. This method supports patch semantics.
        /// </summary>
        public class PatchRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.TransitObject>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.TransitObject body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This
            /// value should follow the format issuer ID. identifier where the former is issued by Google and latter is
            /// chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.TransitObject Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/transitObject/{resourceId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates the transit object referenced by the given object ID.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceId">
        /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This value
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.Walletobjects.v1.Data.TransitObject body, string resourceId)
        {
            return new UpdateRequest(this.service, body, resourceId);
        }

        /// <summary>Updates the transit object referenced by the given object ID.</summary>
        public class UpdateRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.TransitObject>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.TransitObject body, string resourceId) : base(service)
            {
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique identifier for an object. This ID must be unique across all objects from an issuer. This
            /// value should follow the format issuer ID. identifier where the former is issued by Google and latter is
            /// chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Walletobjects.v1.Data.TransitObject Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "walletobjects/v1/transitObject/{resourceId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "walletobjects" collection of methods.</summary>
    public class WalletobjectsResource
    {
        private const string Resource = "walletobjects";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public WalletobjectsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            V1 = new V1Resource(service);
        }

        /// <summary>Gets the V1 resource.</summary>
        public virtual V1Resource V1 { get; }

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
                PrivateContent = new PrivateContentResource(service);
            }

            /// <summary>Gets the PrivateContent resource.</summary>
            public virtual PrivateContentResource PrivateContent { get; }

            /// <summary>The "privateContent" collection of methods.</summary>
            public class PrivateContentResource
            {
                private const string Resource = "privateContent";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public PrivateContentResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Provide Google with information about awaiting private pass update. This will allow Google to
                /// provide the update notification to the device that currently holds this pass.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                public virtual SetPassUpdateNoticeRequest SetPassUpdateNotice(Google.Apis.Walletobjects.v1.Data.SetPassUpdateNoticeRequest body)
                {
                    return new SetPassUpdateNoticeRequest(this.service, body);
                }

                /// <summary>
                /// Provide Google with information about awaiting private pass update. This will allow Google to
                /// provide the update notification to the device that currently holds this pass.
                /// </summary>
                public class SetPassUpdateNoticeRequest : WalletobjectsBaseServiceRequest<Google.Apis.Walletobjects.v1.Data.SetPassUpdateNoticeResponse>
                {
                    /// <summary>Constructs a new SetPassUpdateNotice request.</summary>
                    public SetPassUpdateNoticeRequest(Google.Apis.Services.IClientService service, Google.Apis.Walletobjects.v1.Data.SetPassUpdateNoticeRequest body) : base(service)
                    {
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Walletobjects.v1.Data.SetPassUpdateNoticeRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setPassUpdateNotice";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "walletobjects/v1/privateContent/setPassUpdateNotice";

                    /// <summary>Initializes SetPassUpdateNotice parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                    }
                }
            }
        }
    }
}
namespace Google.Apis.Walletobjects.v1.Data
{
    /// <summary>ActivationOptions for the class</summary>
    public class ActivationOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// HTTPS URL that supports REST semantics. Would be used for requesting activation from partners for given
        /// valuable, triggered by the users.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activationUrl")]
        public virtual string ActivationUrl { get; set; }

        /// <summary>
        /// Flag to allow users to make activation call from different device. This allows client to render the
        /// activation button enabled even if the activationStatus is ACTIVATED but the requested device is different
        /// than the current device.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowReactivation")]
        public virtual System.Nullable<bool> AllowReactivation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The activation status of the object. This field includes activation status if valuable supports activation.
    /// </summary>
    public class ActivationStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource used when the AddMessage endpoints are called.</summary>
    public class AddMessageRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual Message Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AirportInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Three character IATA airport code. This is a required field for `origin` and `destination`. Eg: "SFO"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("airportIataCode")]
        public virtual string AirportIataCode { get; set; }

        /// <summary>
        /// Optional field that overrides the airport city name defined by IATA. By default, Google takes the
        /// `airportIataCode` provided and maps it to the official airport city name defined by IATA. Official IATA
        /// airport city names can be found at IATA airport city names website. For example, for the airport IATA code
        /// "LTN", IATA website tells us that the corresponding airport city is "London". If this field is not
        /// populated, Google would display "London". However, populating this field with a custom name (eg: "London
        /// Luton") would override it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("airportNameOverride")]
        public virtual LocalizedString AirportNameOverride { get; set; }

        /// <summary>A name of the gate. Eg: "B59" or "59"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gate")]
        public virtual string Gate { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string `"walletobjects#airportInfo"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Terminal name. Eg: "INTL" or "I"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("terminal")]
        public virtual string Terminal { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AppLinkData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional information about the partner app link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidAppLinkInfo")]
        public virtual AppLinkDataAppLinkInfo AndroidAppLinkInfo { get; set; }

        /// <summary>Optional display text for the app link button. Character limit is 30.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayText")]
        public virtual LocalizedString DisplayText { get; set; }

        /// <summary>Deprecated. Links to open iOS apps are not supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosAppLinkInfo")]
        public virtual AppLinkDataAppLinkInfo IosAppLinkInfo { get; set; }

        /// <summary>Optional information about the partner web link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webAppLinkInfo")]
        public virtual AppLinkDataAppLinkInfo WebAppLinkInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AppLinkDataAppLinkInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Deprecated. Image isn't supported in the app link module.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appLogoImage")]
        public virtual Image AppLogoImage { get; set; }

        /// <summary>
        /// Target to follow when opening the app link on clients. It will be used by partners to open their app or
        /// webpage.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appTarget")]
        public virtual AppLinkDataAppLinkInfoAppTarget AppTarget { get; set; }

        /// <summary>Deprecated. Description isn't supported in the app link module.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual LocalizedString Description { get; set; }

        /// <summary>Deprecated. Title isn't supported in the app link module.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual LocalizedString Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AppLinkDataAppLinkInfoAppTarget : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Package name for AppTarget. For example: com.google.android.gm</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>
        /// URI for AppTarget. The description on the URI must be set. Prefer setting package field instead, if this
        /// target is defined for your application.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetUri")]
        public virtual Uri TargetUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AuthenticationKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Available only to Smart Tap enabled partners. Contact support for additional guidance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<int> Id { get; set; }

        /// <summary>Available only to Smart Tap enabled partners. Contact support for additional guidance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicKeyPem")]
        public virtual string PublicKeyPem { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Barcode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An optional text that will override the default text that shows under the barcode. This field is intended
        /// for a human readable equivalent of the barcode value, used when the barcode cannot be scanned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alternateText")]
        public virtual string AlternateText { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string `"walletobjects#barcode"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The render encoding for the barcode. When specified, barcode is rendered in the given encoding. Otherwise
        /// best known encoding is chosen by Google.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("renderEncoding")]
        public virtual string RenderEncoding { get; set; }

        /// <summary>
        /// Optional text that will be shown when the barcode is hidden behind a click action. This happens in cases
        /// where a pass has Smart Tap enabled. If not specified, a default is chosen by Google.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("showCodeText")]
        public virtual LocalizedString ShowCodeText { get; set; }

        /// <summary>The type of barcode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The value encoded in the barcode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class BarcodeSectionDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A reference to an existing text-based or image field to display.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldSelector")]
        public virtual FieldSelector FieldSelector { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information to read/write to blobstore2.</summary>
    public class Blobstore2Info : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The blob generation id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobGeneration")]
        public virtual System.Nullable<long> BlobGeneration { get; set; }

        /// <summary>The blob id, e.g., /blobstore/prod/playground/scotty</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobId")]
        public virtual string BlobId { get; set; }

        /// <summary>
        /// Read handle passed from Bigstore -&amp;gt; Scotty for a GCS download. This is a signed, serialized
        /// blobstore2.ReadHandle proto which must never be set outside of Bigstore, and is not applicable to non-GCS
        /// media downloads.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downloadReadHandle")]
        public virtual string DownloadReadHandle { get; set; }

        /// <summary>
        /// The blob read token. Needed to read blobs that have not been replicated. Might not be available until the
        /// final call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readToken")]
        public virtual string ReadToken { get; set; }

        /// <summary>
        /// Metadata passed from Blobstore -&amp;gt; Scotty for a new GCS upload. This is a signed, serialized
        /// blobstore2.BlobMetadataContainer proto which must never be consumed outside of Bigstore, and is not
        /// applicable to non-GCS media uploads.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uploadMetadataContainer")]
        public virtual string UploadMetadataContainer { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class BoardingAndSeatingInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Set this field only if this flight boards through more than one door or bridge and you want to explicitly
        /// print the door location on the boarding pass. Most airlines route their passengers to the right door or
        /// bridge by refering to doors/bridges by the `seatClass`. In those cases `boardingDoor` should not be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boardingDoor")]
        public virtual string BoardingDoor { get; set; }

        /// <summary>
        /// The value of boarding group (or zone) this passenger shall board with. eg: "B" The label for this value will
        /// be determined by the `boardingPolicy` field in the `flightClass` referenced by this object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boardingGroup")]
        public virtual string BoardingGroup { get; set; }

        /// <summary>The value of boarding position. eg: "76"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boardingPosition")]
        public virtual string BoardingPosition { get; set; }

        /// <summary>
        /// A small image shown above the boarding barcode. Airlines can use it to communicate any special boarding
        /// privileges. In the event the security program logo is also set, this image might be rendered alongside the
        /// logo for that security program.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boardingPrivilegeImage")]
        public virtual Image BoardingPrivilegeImage { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string `"walletobjects#boardingAndSeatingInfo"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The passenger's seat assignment. To be used when there is no specific identifier to use in `seatNumber`. eg:
        /// "assigned at gate"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seatAssignment")]
        public virtual LocalizedString SeatAssignment { get; set; }

        /// <summary>The value of the seat class. eg: "Economy" or "Economy Plus"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seatClass")]
        public virtual string SeatClass { get; set; }

        /// <summary>
        /// The value of passenger seat. If there is no specific identifier, use `seatAssignment` instead. eg: "25A"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seatNumber")]
        public virtual string SeatNumber { get; set; }

        /// <summary>
        /// The sequence number on the boarding pass. This usually matches the sequence in which the passengers checked
        /// in. Airline might use the number for manual boarding and bag tags. eg: "49"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sequenceNumber")]
        public virtual string SequenceNumber { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class BoardingAndSeatingPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Indicates the policy the airline uses for boarding. If unset, Google will default to `zoneBased`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boardingPolicy")]
        public virtual string BoardingPolicy { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string
        /// `"walletobjects#boardingAndSeatingPolicy"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Seating policy which dictates how we display the seat class. If unset, Google will default to `cabinBased`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seatClassPolicy")]
        public virtual string SeatClassPolicy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CallbackOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// URL for the merchant endpoint that would be called to request updates. The URL should be hosted on HTTPS and
        /// robots.txt should allow the URL path to be accessible by UserAgent:Googlebot. Deprecated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateRequestUrl")]
        public virtual string UpdateRequestUrl { get; set; }

        /// <summary>
        /// The HTTPS url configured by the merchant. The URL should be hosted on HTTPS and robots.txt should allow the
        /// URL path to be accessible by UserAgent:Googlebot.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CardBarcodeSectionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional information to display below the barcode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstBottomDetail")]
        public virtual BarcodeSectionDetail FirstBottomDetail { get; set; }

        /// <summary>
        /// Optional information to display above the barcode. If `secondTopDetail` is defined, this will be displayed
        /// to the start side of this detail section.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstTopDetail")]
        public virtual BarcodeSectionDetail FirstTopDetail { get; set; }

        /// <summary>
        /// Optional second piece of information to display above the barcode. If `firstTopDetail` is defined, this will
        /// be displayed to the end side of this detail section.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondTopDetail")]
        public virtual BarcodeSectionDetail SecondTopDetail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CardRowOneItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The item to be displayed in the row. This item will be automatically centered.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("item")]
        public virtual TemplateItem Item { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CardRowTemplateInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Template for a row containing one item. Exactly one of "one_item", "two_items", "three_items" must be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oneItem")]
        public virtual CardRowOneItem OneItem { get; set; }

        /// <summary>
        /// Template for a row containing three items. Exactly one of "one_item", "two_items", "three_items" must be
        /// set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threeItems")]
        public virtual CardRowThreeItems ThreeItems { get; set; }

        /// <summary>
        /// Template for a row containing two items. Exactly one of "one_item", "two_items", "three_items" must be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("twoItems")]
        public virtual CardRowTwoItems TwoItems { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CardRowThreeItems : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The item to be displayed at the end of the row. This item will be aligned to the right.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endItem")]
        public virtual TemplateItem EndItem { get; set; }

        /// <summary>
        /// The item to be displayed in the middle of the row. This item will be centered between the start and end
        /// items.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("middleItem")]
        public virtual TemplateItem MiddleItem { get; set; }

        /// <summary>The item to be displayed at the start of the row. This item will be aligned to the left.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startItem")]
        public virtual TemplateItem StartItem { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CardRowTwoItems : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The item to be displayed at the end of the row. This item will be aligned to the right.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endItem")]
        public virtual TemplateItem EndItem { get; set; }

        /// <summary>The item to be displayed at the start of the row. This item will be aligned to the left.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startItem")]
        public virtual TemplateItem StartItem { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CardTemplateOverride : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Template information for rows in the card view. At most three rows are allowed to be specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardRowTemplateInfos")]
        public virtual System.Collections.Generic.IList<CardRowTemplateInfo> CardRowTemplateInfos { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ClassTemplateInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies extra information to be displayed above and below the barcode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardBarcodeSectionDetails")]
        public virtual CardBarcodeSectionDetails CardBarcodeSectionDetails { get; set; }

        /// <summary>Override for the card view.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardTemplateOverride")]
        public virtual CardTemplateOverride CardTemplateOverride { get; set; }

        /// <summary>Override for the details view (beneath the card view).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detailsTemplateOverride")]
        public virtual DetailsTemplateOverride DetailsTemplateOverride { get; set; }

        /// <summary>Override for the passes list view.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listTemplateOverride")]
        public virtual ListTemplateOverride ListTemplateOverride { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A sequence of media data references representing composite data. Introduced to support Bigstore composite
    /// objects. For details, visit http://go/bigstore-composites.
    /// </summary>
    public class CompositeMedia : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Blobstore v1 reference, set if reference_type is BLOBSTORE_REF This should be the byte representation of a
        /// blobstore.BlobRef. Since Blobstore is deprecating v1, use blobstore2_info instead. For now, any v2 blob will
        /// also be represented in this field as v1 BlobRef.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobRef")]
        public virtual string BlobRef { get; set; }

        /// <summary>Blobstore v2 info, set if reference_type is BLOBSTORE_REF and it refers to a v2 blob.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobstore2Info")]
        public virtual Blobstore2Info Blobstore2Info { get; set; }

        /// <summary>
        /// A binary data reference for a media download. Serves as a technology-agnostic binary reference in some
        /// Google infrastructure. This value is a serialized storage_cosmo.BinaryReference proto. Storing it as bytes
        /// is a hack to get around the fact that the cosmo proto (as well as others it includes) doesn't support
        /// JavaScript. This prevents us from including the actual type of this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cosmoBinaryReference")]
        public virtual string CosmoBinaryReference { get; set; }

        /// <summary>crc32.c hash for the payload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crc32cHash")]
        public virtual System.Nullable<long> Crc32cHash { get; set; }

        /// <summary>Media data, set if reference_type is INLINE</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inline")]
        public virtual string Inline { get; set; }

        /// <summary>Size of the data, in bytes</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("length")]
        public virtual System.Nullable<long> Length { get; set; }

        /// <summary>MD5 hash for the payload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("md5Hash")]
        public virtual string Md5Hash { get; set; }

        /// <summary>Reference to a TI Blob, set if reference_type is BIGSTORE_REF.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual ObjectId ObjectId { get; set; }

        /// <summary>Path to the data, set if reference_type is PATH</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>Describes what the field reference contains.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referenceType")]
        public virtual string ReferenceType { get; set; }

        /// <summary>SHA-1 hash for the payload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha1Hash")]
        public virtual string Sha1Hash { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Detailed Content-Type information from Scotty. The Content-Type of the media will typically be filled in by the
    /// header or Scotty's best_guess, but this extended information provides the backend with more information so that
    /// it can make a better decision if needed. This is only used on media upload requests from Scotty.
    /// </summary>
    public class ContentTypeInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Scotty's best guess of what the content type of the file is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bestGuess")]
        public virtual string BestGuess { get; set; }

        /// <summary>
        /// The content type of the file derived by looking at specific bytes (i.e. "magic bytes") of the actual file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fromBytes")]
        public virtual string FromBytes { get; set; }

        /// <summary>
        /// The content type of the file derived from the file extension of the original file name used by the client.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fromFileName")]
        public virtual string FromFileName { get; set; }

        /// <summary>
        /// The content type of the file as specified in the request headers, multipart headers, or RUPIO start request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fromHeader")]
        public virtual string FromHeader { get; set; }

        /// <summary>
        /// The content type of the file derived from the file extension of the URL path. The URL path is assumed to
        /// represent a file name (which is typically only true for agents that are providing a REST API).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fromUrlPath")]
        public virtual string FromUrlPath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DateTime : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An ISO 8601 extended format date/time. Offset may or may not be required (refer to the parent field's
        /// documentation). Time may be specified up to nanosecond precision. Offsets may be specified with seconds
        /// precision (even though offset seconds is not part of ISO 8601). For example: `1985-04-12T23:20:50.52Z` would
        /// be 20 minutes and 50.52 seconds after the 23rd hour of April 12th, 1985 in UTC.
        /// `1985-04-12T19:20:50.52-04:00` would be 20 minutes and 50.52 seconds after the 19th hour of April 12th,
        /// 1985, 4 hours before UTC (same instant in time as the above example). If the date/time is intended for a
        /// physical location in New York, this would be the equivalent of Eastern Daylight Time (EDT). Remember that
        /// offset varies in regions that observe Daylight Saving Time (or Summer Time), depending on the time of the
        /// year. `1985-04-12T19:20:50.52` would be 20 minutes and 50.52 seconds after the 19th hour of April 12th, 1985
        /// with no offset information. Providing an offset makes this an absolute instant in time around the world. The
        /// date/time will be adjusted based on the user's time zone. For example, a time of `2018-06-19T18:30:00-04:00`
        /// will be 18:30:00 for a user in New York and 15:30:00 for a user in Los Angeles. Omitting the offset makes
        /// this a local date/time, representing several instants in time around the world. The date/time will always be
        /// in the user's current time zone. For example, a time of `2018-06-19T18:30:00` will be 18:30:00 for a user in
        /// New York and also 18:30:00 for a user in Los Angeles. This is useful when the same local date/time should
        /// apply to many physical locations across several time zones.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual string Date { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DetailsItemInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The item to be displayed in the details list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("item")]
        public virtual TemplateItem Item { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DetailsTemplateOverride : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Information for the "nth" item displayed in the details list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detailsItemInfos")]
        public virtual System.Collections.Generic.IList<DetailsItemInfo> DetailsItemInfos { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Device context associated with the object.</summary>
    public class DeviceContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If set, redemption information will only be returned to the given device upon activation of the object. This
        /// should not be used as a stable identifier to trace a user's device. It can change across different passes
        /// for the same device or even across different activations for the same device. When setting this, callers
        /// must also set has_linked_device on the object being activated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceToken")]
        public virtual string DeviceToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Backend response for a Diff get checksums response. For details on the Scotty Diff protocol, visit
    /// http://go/scotty-diff-protocol.
    /// </summary>
    public class DiffChecksumsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Exactly one of these fields must be populated. If checksums_location is filled, the server will return the
        /// corresponding contents to the user. If object_location is filled, the server will calculate the checksums
        /// based on the content there and return that to the user. For details on the format of the checksums, see
        /// http://go/scotty-diff-protocol.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checksumsLocation")]
        public virtual CompositeMedia ChecksumsLocation { get; set; }

        /// <summary>The chunk size of checksums. Must be a multiple of 256KB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chunkSizeBytes")]
        public virtual System.Nullable<long> ChunkSizeBytes { get; set; }

        /// <summary>If set, calculate the checksums based on the contents and return them to the caller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectLocation")]
        public virtual CompositeMedia ObjectLocation { get; set; }

        /// <summary>The total size of the server object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectSizeBytes")]
        public virtual System.Nullable<long> ObjectSizeBytes { get; set; }

        /// <summary>The object version of the object the checksums are being returned for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectVersion")]
        public virtual string ObjectVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Backend response for a Diff download response. For details on the Scotty Diff protocol, visit
    /// http://go/scotty-diff-protocol.
    /// </summary>
    public class DiffDownloadResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The original object location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectLocation")]
        public virtual CompositeMedia ObjectLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Diff upload request. For details on the Scotty Diff protocol, visit http://go/scotty-diff-protocol.
    /// </summary>
    public class DiffUploadRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The location of the checksums for the new object. Agents must clone the object located here, as the upload
        /// server will delete the contents once a response is received. For details on the format of the checksums, see
        /// http://go/scotty-diff-protocol.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checksumsInfo")]
        public virtual CompositeMedia ChecksumsInfo { get; set; }

        /// <summary>
        /// The location of the new object. Agents must clone the object located here, as the upload server will delete
        /// the contents once a response is received.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectInfo")]
        public virtual CompositeMedia ObjectInfo { get; set; }

        /// <summary>
        /// The object version of the object that is the base version the incoming diff script will be applied to. This
        /// field will always be filled in.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectVersion")]
        public virtual string ObjectVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Backend response for a Diff upload request. For details on the Scotty Diff protocol, visit
    /// http://go/scotty-diff-protocol.
    /// </summary>
    public class DiffUploadResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The object version of the object at the server. Must be included in the end notification response. The
        /// version in the end notification response must correspond to the new version of the object that is now stored
        /// at the server, after the upload.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectVersion")]
        public virtual string ObjectVersion { get; set; }

        /// <summary>
        /// The location of the original file for a diff upload request. Must be filled in if responding to an upload
        /// start notification.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalObject")]
        public virtual CompositeMedia OriginalObject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Backend response for a Diff get version response. For details on the Scotty Diff protocol, visit
    /// http://go/scotty-diff-protocol.
    /// </summary>
    public class DiffVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The total size of the server object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectSizeBytes")]
        public virtual System.Nullable<long> ObjectSizeBytes { get; set; }

        /// <summary>The version of the object stored at the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectVersion")]
        public virtual string ObjectVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information about how a class may be discovered and instantiated from within the Google Wallet app. This is done
    /// by searching for a loyalty or gift card program and scanning or manually entering.
    /// </summary>
    public class DiscoverableProgram : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Information about the ability to signin and add a valuable for this program through a merchant site. Used
        /// when MERCHANT_HOSTED_SIGNIN is enabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantSigninInfo")]
        public virtual DiscoverableProgramMerchantSigninInfo MerchantSigninInfo { get; set; }

        /// <summary>
        /// Information about the ability to signup and add a valuable for this program through a merchant site. Used
        /// when MERCHANT_HOSTED_SIGNUP is enabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantSignupInfo")]
        public virtual DiscoverableProgramMerchantSignupInfo MerchantSignupInfo { get; set; }

        /// <summary>Visibility state of the discoverable program.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the merchant hosted signin flow for a program.</summary>
    public class DiscoverableProgramMerchantSigninInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The URL to direct the user to for the merchant's signin site.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signinWebsite")]
        public virtual Uri SigninWebsite { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the merchant hosted signup flow for a program.</summary>
    public class DiscoverableProgramMerchantSignupInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        ///  User data that is sent in a POST request to the signup website URL. This information is encoded and then
        /// shared so that the merchant's website can prefill fields used to enroll the user for the discoverable
        /// program.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signupSharedDatas")]
        public virtual System.Collections.Generic.IList<string> SignupSharedDatas { get; set; }

        /// <summary>The URL to direct the user to for the merchant's signup site.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signupWebsite")]
        public virtual Uri SignupWebsite { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Parameters specific to media downloads.</summary>
    public class DownloadParameters : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A boolean to be returned in the response to Scotty. Allows/disallows gzip encoding of the payload content
        /// when the server thinks it's advantageous (hence, does not guarantee compression) which allows Scotty to GZip
        /// the response to the client.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowGzipCompression")]
        public virtual System.Nullable<bool> AllowGzipCompression { get; set; }

        /// <summary>
        /// Determining whether or not Apiary should skip the inclusion of any Content-Range header on its response to
        /// Scotty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoreRange")]
        public virtual System.Nullable<bool> IgnoreRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EventDateTime : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A custom label to use for the doors open value (`doorsOpen`) on the card detail view. This should only be
        /// used if the default "Doors Open" label or one of the `doorsOpenLabel` options is not sufficient. Both
        /// `doorsOpenLabel` and `customDoorsOpenLabel` may not be set. If neither is set, the label will default to
        /// "Doors Open", localized. If the doors open field is unset, this label will not be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customDoorsOpenLabel")]
        public virtual LocalizedString CustomDoorsOpenLabel { get; set; }

        /// <summary>
        /// The date/time when the doors open at the venue. This is an ISO 8601 extended format date/time, with or
        /// without an offset. Time may be specified up to nanosecond precision. Offsets may be specified with seconds
        /// precision (even though offset seconds is not part of ISO 8601). For example: `1985-04-12T23:20:50.52Z` would
        /// be 20 minutes and 50.52 seconds after the 23rd hour of April 12th, 1985 in UTC.
        /// `1985-04-12T19:20:50.52-04:00` would be 20 minutes and 50.52 seconds after the 19th hour of April 12th,
        /// 1985, 4 hours before UTC (same instant in time as the above example). If the event were in New York, this
        /// would be the equivalent of Eastern Daylight Time (EDT). Remember that offset varies in regions that observe
        /// Daylight Saving Time (or Summer Time), depending on the time of the year. `1985-04-12T19:20:50.52` would be
        /// 20 minutes and 50.52 seconds after the 19th hour of April 12th, 1985 with no offset information. The portion
        /// of the date/time without the offset is considered the "local date/time". This should be the local date/time
        /// at the venue. For example, if the event occurs at the 20th hour of June 5th, 2018 at the venue, the local
        /// date/time portion should be `2018-06-05T20:00:00`. If the local date/time at the venue is 4 hours before
        /// UTC, an offset of `-04:00` may be appended. Without offset information, some rich features may not be
        /// available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doorsOpen")]
        public virtual string DoorsOpen { get; set; }

        /// <summary>
        /// The label to use for the doors open value (`doorsOpen`) on the card detail view. Each available option maps
        /// to a set of localized strings, so that translations are shown to the user based on their locale. Both
        /// `doorsOpenLabel` and `customDoorsOpenLabel` may not be set. If neither is set, the label will default to
        /// "Doors Open", localized. If the doors open field is unset, this label will not be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doorsOpenLabel")]
        public virtual string DoorsOpenLabel { get; set; }

        /// <summary>
        /// The date/time when the event ends. If the event spans multiple days, it should be the end date/time on the
        /// last day. This is an ISO 8601 extended format date/time, with or without an offset. Time may be specified up
        /// to nanosecond precision. Offsets may be specified with seconds precision (even though offset seconds is not
        /// part of ISO 8601). For example: `1985-04-12T23:20:50.52Z` would be 20 minutes and 50.52 seconds after the
        /// 23rd hour of April 12th, 1985 in UTC. `1985-04-12T19:20:50.52-04:00` would be 20 minutes and 50.52 seconds
        /// after the 19th hour of April 12th, 1985, 4 hours before UTC (same instant in time as the above example). If
        /// the event were in New York, this would be the equivalent of Eastern Daylight Time (EDT). Remember that
        /// offset varies in regions that observe Daylight Saving Time (or Summer Time), depending on the time of the
        /// year. `1985-04-12T19:20:50.52` would be 20 minutes and 50.52 seconds after the 19th hour of April 12th, 1985
        /// with no offset information. The portion of the date/time without the offset is considered the "local
        /// date/time". This should be the local date/time at the venue. For example, if the event occurs at the 20th
        /// hour of June 5th, 2018 at the venue, the local date/time portion should be `2018-06-05T20:00:00`. If the
        /// local date/time at the venue is 4 hours before UTC, an offset of `-04:00` may be appended. Without offset
        /// information, some rich features may not be available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("end")]
        public virtual string End { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string `"walletobjects#eventDateTime"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The date/time when the event starts. If the event spans multiple days, it should be the start date/time on
        /// the first day. This is an ISO 8601 extended format date/time, with or without an offset. Time may be
        /// specified up to nanosecond precision. Offsets may be specified with seconds precision (even though offset
        /// seconds is not part of ISO 8601). For example: `1985-04-12T23:20:50.52Z` would be 20 minutes and 50.52
        /// seconds after the 23rd hour of April 12th, 1985 in UTC. `1985-04-12T19:20:50.52-04:00` would be 20 minutes
        /// and 50.52 seconds after the 19th hour of April 12th, 1985, 4 hours before UTC (same instant in time as the
        /// above example). If the event were in New York, this would be the equivalent of Eastern Daylight Time (EDT).
        /// Remember that offset varies in regions that observe Daylight Saving Time (or Summer Time), depending on the
        /// time of the year. `1985-04-12T19:20:50.52` would be 20 minutes and 50.52 seconds after the 19th hour of
        /// April 12th, 1985 with no offset information. The portion of the date/time without the offset is considered
        /// the "local date/time". This should be the local date/time at the venue. For example, if the event occurs at
        /// the 20th hour of June 5th, 2018 at the venue, the local date/time portion should be `2018-06-05T20:00:00`.
        /// If the local date/time at the venue is 4 hours before UTC, an offset of `-04:00` may be appended. Without
        /// offset information, some rich features may not be available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("start")]
        public virtual string Start { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EventReservationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The confirmation code of the event reservation. This may also take the form of an "order number",
        /// "confirmation number", "reservation number", or other equivalent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confirmationCode")]
        public virtual string ConfirmationCode { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string `"walletobjects#eventReservationInfo"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EventSeat : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The gate the ticket holder should enter to get to their seat, such as "A" or "West". This field is
        /// localizable so you may translate words or use different alphabets for the characters in an identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gate")]
        public virtual LocalizedString Gate { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string `"walletobjects#eventSeat"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The row of the seat, such as "1", E", "BB", or "A5". This field is localizable so you may translate words or
        /// use different alphabets for the characters in an identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("row")]
        public virtual LocalizedString Row { get; set; }

        /// <summary>
        /// The seat number, such as "1", "2", "3", or any other seat identifier. This field is localizable so you may
        /// translate words or use different alphabets for the characters in an identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seat")]
        public virtual LocalizedString Seat { get; set; }

        /// <summary>
        /// The section of the seat, such as "121". This field is localizable so you may translate words or use
        /// different alphabets for the characters in an identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("section")]
        public virtual LocalizedString Section { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EventTicketClass : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Deprecated. Use `multipleDevicesAndHoldersAllowedStatus` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowMultipleUsersPerObject")]
        public virtual System.Nullable<bool> AllowMultipleUsersPerObject { get; set; }

        /// <summary>
        /// Optional app or website link that will be displayed as a button on the front of the pass. If AppLinkData is
        /// provided for the corresponding object that will be used instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appLinkData")]
        public virtual AppLinkData AppLinkData { get; set; }

        /// <summary>
        /// Callback options to be used to call the issuer back for every save/delete of an object for this class by the
        /// end-user. All objects of this class are eligible for the callback.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callbackOptions")]
        public virtual CallbackOptions CallbackOptions { get; set; }

        /// <summary>
        /// Template information about how the class should be displayed. If unset, Google will fallback to a default
        /// set of fields to display.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classTemplateInfo")]
        public virtual ClassTemplateInfo ClassTemplateInfo { get; set; }

        /// <summary>
        /// The label to use for the confirmation code value (`eventTicketObject.reservationInfo.confirmationCode`) on
        /// the card detail view. Each available option maps to a set of localized strings, so that translations are
        /// shown to the user based on their locale. Both `confirmationCodeLabel` and `customConfirmationCodeLabel` may
        /// not be set. If neither is set, the label will default to "Confirmation Code", localized. If the confirmation
        /// code field is unset, this label will not be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confirmationCodeLabel")]
        public virtual string ConfirmationCodeLabel { get; set; }

        /// <summary>
        /// Country code used to display the card's country (when the user is not in that country), as well as to
        /// display localized content when content is not available in the user's locale.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countryCode")]
        public virtual string CountryCode { get; set; }

        /// <summary>
        /// A custom label to use for the confirmation code value (`eventTicketObject.reservationInfo.confirmationCode`)
        /// on the card detail view. This should only be used if the default "Confirmation Code" label or one of the
        /// `confirmationCodeLabel` options is not sufficient. Both `confirmationCodeLabel` and
        /// `customConfirmationCodeLabel` may not be set. If neither is set, the label will default to "Confirmation
        /// Code", localized. If the confirmation code field is unset, this label will not be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customConfirmationCodeLabel")]
        public virtual LocalizedString CustomConfirmationCodeLabel { get; set; }

        /// <summary>
        /// A custom label to use for the gate value (`eventTicketObject.seatInfo.gate`) on the card detail view. This
        /// should only be used if the default "Gate" label or one of the `gateLabel` options is not sufficient. Both
        /// `gateLabel` and `customGateLabel` may not be set. If neither is set, the label will default to "Gate",
        /// localized. If the gate field is unset, this label will not be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customGateLabel")]
        public virtual LocalizedString CustomGateLabel { get; set; }

        /// <summary>
        /// A custom label to use for the row value (`eventTicketObject.seatInfo.row`) on the card detail view. This
        /// should only be used if the default "Row" label or one of the `rowLabel` options is not sufficient. Both
        /// `rowLabel` and `customRowLabel` may not be set. If neither is set, the label will default to "Row",
        /// localized. If the row field is unset, this label will not be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customRowLabel")]
        public virtual LocalizedString CustomRowLabel { get; set; }

        /// <summary>
        /// A custom label to use for the seat value (`eventTicketObject.seatInfo.seat`) on the card detail view. This
        /// should only be used if the default "Seat" label or one of the `seatLabel` options is not sufficient. Both
        /// `seatLabel` and `customSeatLabel` may not be set. If neither is set, the label will default to "Seat",
        /// localized. If the seat field is unset, this label will not be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customSeatLabel")]
        public virtual LocalizedString CustomSeatLabel { get; set; }

        /// <summary>
        /// A custom label to use for the section value (`eventTicketObject.seatInfo.section`) on the card detail view.
        /// This should only be used if the default "Section" label or one of the `sectionLabel` options is not
        /// sufficient. Both `sectionLabel` and `customSectionLabel` may not be set. If neither is set, the label will
        /// default to "Section", localized. If the section field is unset, this label will not be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customSectionLabel")]
        public virtual LocalizedString CustomSectionLabel { get; set; }

        /// <summary>The date &amp; time information of the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateTime")]
        public virtual EventDateTime DateTime { get; set; }

        /// <summary>
        /// Identifies whether this class supports Smart Tap. The `redemptionIssuers` and object level
        /// `smartTapRedemptionLevel` fields must also be set up correctly in order for a pass to support Smart Tap.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableSmartTap")]
        public virtual System.Nullable<bool> EnableSmartTap { get; set; }

        /// <summary>
        /// The ID of the event. This ID should be unique for every event in an account. It is used to group tickets
        /// together if the user has saved multiple tickets for the same event. It can be at most 64 characters. If
        /// provided, the grouping will be stable. Be wary of unintentional collision to avoid grouping tickets that
        /// should not be grouped. If you use only one class per event, you can simply set this to the `classId` (with
        /// or without the issuer ID portion). If not provided, the platform will attempt to use other data to group
        /// tickets (potentially unstable).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        /// <summary>Required. The name of the event, such as "LA Dodgers at SF Giants".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventName")]
        public virtual LocalizedString EventName { get; set; }

        /// <summary>The fine print, terms, or conditions of the ticket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finePrint")]
        public virtual LocalizedString FinePrint { get; set; }

        /// <summary>
        /// The label to use for the gate value (`eventTicketObject.seatInfo.gate`) on the card detail view. Each
        /// available option maps to a set of localized strings, so that translations are shown to the user based on
        /// their locale. Both `gateLabel` and `customGateLabel` may not be set. If neither is set, the label will
        /// default to "Gate", localized. If the gate field is unset, this label will not be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gateLabel")]
        public virtual string GateLabel { get; set; }

        /// <summary>
        /// Optional banner image displayed on the front of the card. If none is present, nothing will be displayed. The
        /// image will display at 100% width.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heroImage")]
        public virtual Image HeroImage { get; set; }

        /// <summary>
        /// The background color for the card. If not set the dominant color of the hero image is used, and if no hero
        /// image is set, the dominant color of the logo is used. The format is #rrggbb where rrggbb is a hex RGB
        /// triplet, such as `#ffcc00`. You can also use the shorthand version of the RGB triplet which is #rgb, such as
        /// `#fc0`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hexBackgroundColor")]
        public virtual string HexBackgroundColor { get; set; }

        /// <summary>
        /// The URI of your application's home page. Populating the URI in this field results in the exact same behavior
        /// as populating an URI in linksModuleData (when an object is rendered, a link to the homepage is shown in what
        /// would usually be thought of as the linksModuleData section of the object).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("homepageUri")]
        public virtual Uri HomepageUri { get; set; }

        /// <summary>
        /// Required. The unique identifier for a class. This ID must be unique across all classes from an issuer. This
        /// value should follow the format issuer ID. identifier where the former is issued by Google and latter is
        /// chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Image module data. The maximum number of these fields displayed is 1 from object level and 1 for class
        /// object level.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageModulesData")]
        public virtual System.Collections.Generic.IList<ImageModuleData> ImageModulesData { get; set; }

        /// <summary>Deprecated. Use textModulesData instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infoModuleData")]
        public virtual InfoModuleData InfoModuleData { get; set; }

        /// <summary>
        /// Required. The issuer name. Recommended maximum length is 20 characters to ensure full string is displayed on
        /// smaller screens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issuerName")]
        public virtual string IssuerName { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string `"walletobjects#eventTicketClass"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Links module data. If links module data is also defined on the object, both will be displayed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linksModuleData")]
        public virtual LinksModuleData LinksModuleData { get; set; }

        /// <summary>
        /// Translated strings for the issuer_name. Recommended maximum length is 20 characters to ensure full string is
        /// displayed on smaller screens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedIssuerName")]
        public virtual LocalizedString LocalizedIssuerName { get; set; }

        /// <summary>Note: This field is currently not supported to trigger geo notifications.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<LatLongPoint> Locations { get; set; }

        /// <summary>The logo image of the ticket. This image is displayed in the card detail view of the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logo")]
        public virtual Image Logo { get; set; }

        /// <summary>
        /// Merchant locations. There is a maximum of ten on the class. Any additional MerchantLocations added beyond
        /// the 10 will be rejected. These locations will trigger a notification when a user enters within a Google-set
        /// radius of the point. This field replaces the deprecated LatLongPoints.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantLocations")]
        public virtual System.Collections.Generic.IList<MerchantLocation> MerchantLocations { get; set; }

        /// <summary>
        /// An array of messages displayed in the app. All users of this object will receive its associated messages.
        /// The maximum number of these fields is 10.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<Message> Messages { get; set; }

        /// <summary>
        /// Identifies whether multiple users and devices will save the same object referencing this class.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multipleDevicesAndHoldersAllowedStatus")]
        public virtual string MultipleDevicesAndHoldersAllowedStatus { get; set; }

        /// <summary>
        /// Whether or not field updates to this class should trigger notifications. When set to NOTIFY, we will attempt
        /// to trigger a field update notification to users. These notifications will only be sent to users if the field
        /// is part of an allowlist. If not specified, no notification will be triggered. This setting is ephemeral and
        /// needs to be set with each PATCH or UPDATE request, otherwise a notification will not be triggered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notifyPreference")]
        public virtual string NotifyPreference { get; set; }

        /// <summary>
        /// Identifies which redemption issuers can redeem the pass over Smart Tap. Redemption issuers are identified by
        /// their issuer ID. Redemption issuers must have at least one Smart Tap key configured. The `enableSmartTap`
        /// and object level `smartTapRedemptionLevel` fields must also be set up correctly in order for a pass to
        /// support Smart Tap.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redemptionIssuers")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> RedemptionIssuers { get; set; }

        /// <summary>The review comments set by the platform when a class is marked `approved` or `rejected`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("review")]
        public virtual Review Review { get; set; }

        /// <summary>
        /// Required. The status of the class. This field can be set to `draft` or `underReview` using the insert,
        /// patch, or update API calls. Once the review state is changed from `draft` it may not be changed back to
        /// `draft`. You should keep this field to `draft` when the class is under development. A `draft` class cannot
        /// be used to create any object. You should set this field to `underReview` when you believe the class is ready
        /// for use. The platform will automatically set this field to `approved` and it can be immediately used to
        /// create or migrate objects. When updating an already `approved` class you should keep setting this field to
        /// `underReview`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reviewStatus")]
        public virtual string ReviewStatus { get; set; }

        /// <summary>
        /// The label to use for the row value (`eventTicketObject.seatInfo.row`) on the card detail view. Each
        /// available option maps to a set of localized strings, so that translations are shown to the user based on
        /// their locale. Both `rowLabel` and `customRowLabel` may not be set. If neither is set, the label will default
        /// to "Row", localized. If the row field is unset, this label will not be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowLabel")]
        public virtual string RowLabel { get; set; }

        /// <summary>
        /// The label to use for the seat value (`eventTicketObject.seatInfo.seat`) on the card detail view. Each
        /// available option maps to a set of localized strings, so that translations are shown to the user based on
        /// their locale. Both `seatLabel` and `customSeatLabel` may not be set. If neither is set, the label will
        /// default to "Seat", localized. If the seat field is unset, this label will not be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seatLabel")]
        public virtual string SeatLabel { get; set; }

        /// <summary>
        /// The label to use for the section value (`eventTicketObject.seatInfo.section`) on the card detail view. Each
        /// available option maps to a set of localized strings, so that translations are shown to the user based on
        /// their locale. Both `sectionLabel` and `customSectionLabel` may not be set. If neither is set, the label will
        /// default to "Section", localized. If the section field is unset, this label will not be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sectionLabel")]
        public virtual string SectionLabel { get; set; }

        /// <summary>
        /// Optional information about the security animation. If this is set a security animation will be rendered on
        /// pass details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityAnimation")]
        public virtual SecurityAnimation SecurityAnimation { get; set; }

        /// <summary>
        /// Text module data. If text module data is also defined on the class, both will be displayed. The maximum
        /// number of these fields displayed is 10 from the object and 10 from the class.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textModulesData")]
        public virtual System.Collections.Generic.IList<TextModuleData> TextModulesData { get; set; }

        /// <summary>
        /// Optional value added module data. Maximum of ten on the class. For a pass only ten will be displayed,
        /// prioritizing those from the object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueAddedModuleData")]
        public virtual System.Collections.Generic.IList<ValueAddedModuleData> ValueAddedModuleData { get; set; }

        /// <summary>Event venue details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("venue")]
        public virtual EventVenue Venue { get; set; }

        /// <summary>Deprecated</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<long> Version { get; set; }

        /// <summary>View Unlock Requirement options for the event ticket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewUnlockRequirement")]
        public virtual string ViewUnlockRequirement { get; set; }

        /// <summary>
        /// The wide logo of the ticket. When provided, this will be used in place of the logo in the top left of the
        /// card view.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wideLogo")]
        public virtual Image WideLogo { get; set; }

        /// <summary>Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wordMark")]
        public virtual Image WordMark { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EventTicketClassAddMessageResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The updated EventTicketClass resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual EventTicketClass Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EventTicketClassListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Pagination of the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pagination")]
        public virtual Pagination Pagination { get; set; }

        /// <summary>Resources corresponding to the list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<EventTicketClass> Resources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EventTicketObject : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional app or website link that will be displayed as a button on the front of the pass. If AppLinkData is
        /// provided for the corresponding class only object AppLinkData will be displayed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appLinkData")]
        public virtual AppLinkData AppLinkData { get; set; }

        /// <summary>The barcode type and value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("barcode")]
        public virtual Barcode Barcode { get; set; }

        /// <summary>
        /// Required. The class associated with this object. The class must be of the same type as this object, must
        /// already exist, and must be approved. Class IDs should follow the format issuer ID.identifier where the
        /// former is issued by Google and latter is chosen by you.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classId")]
        public virtual string ClassId { get; set; }

        /// <summary>
        /// A copy of the inherited fields of the parent class. These fields are retrieved during a GET.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classReference")]
        public virtual EventTicketClass ClassReference { get; set; }

        /// <summary>
        /// Indicates if notifications should explicitly be suppressed. If this field is set to true, regardless of the
        /// `messages` field, expiration notifications to the user will be suppressed. By default, this field is set to
        /// false. Currently, this can only be set for offers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableExpirationNotification")]
        public virtual System.Nullable<bool> DisableExpirationNotification { get; set; }

        /// <summary>
        /// The face value of the ticket, matching what would be printed on a physical version of the ticket.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("faceValue")]
        public virtual Money FaceValue { get; set; }

        /// <summary>Information that controls how passes are grouped together.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupingInfo")]
        public virtual GroupingInfo GroupingInfo { get; set; }

        /// <summary>
        /// Whether this object is currently linked to a single device. This field is set by the platform when a user
        /// saves the object, linking it to their device. Intended for use by select partners. Contact support for
        /// additional information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasLinkedDevice")]
        public virtual System.Nullable<bool> HasLinkedDevice { get; set; }

        /// <summary>Indicates if the object has users. This field is set by the platform.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasUsers")]
        public virtual System.Nullable<bool> HasUsers { get; set; }

        /// <summary>
        /// Optional banner image displayed on the front of the card. If none is present, hero image of the class, if
        /// present, will be displayed. If hero image of the class is also not present, nothing will be displayed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heroImage")]
        public virtual Image HeroImage { get; set; }

        /// <summary>
        /// The background color for the card. If not set the dominant color of the hero image is used, and if no hero
        /// image is set, the dominant color of the logo is used. The format is #rrggbb where rrggbb is a hex RGB
        /// triplet, such as `#ffcc00`. You can also use the shorthand version of the RGB triplet which is #rgb, such as
        /// `#fc0`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hexBackgroundColor")]
        public virtual string HexBackgroundColor { get; set; }

        /// <summary>
        /// Required. The unique identifier for an object. This ID must be unique across all objects from an issuer.
        /// This value should follow the format issuer ID.identifier where the former is issued by Google and latter is
        /// chosen by you. The unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Image module data. The maximum number of these fields displayed is 1 from object level and 1 for class
        /// object level.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageModulesData")]
        public virtual System.Collections.Generic.IList<ImageModuleData> ImageModulesData { get; set; }

        /// <summary>Deprecated. Use textModulesData instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infoModuleData")]
        public virtual InfoModuleData InfoModuleData { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string `"walletobjects#eventTicketObject"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// linked_object_ids are a list of other objects such as event ticket, loyalty, offer, generic, giftcard,
        /// transit and boarding pass that should be automatically attached to this event ticket object. If a user had
        /// saved this event ticket, then these linked_object_ids would be automatically pushed to the user's wallet
        /// (unless they turned off the setting to receive such linked passes). Make sure that objects present in
        /// linked_object_ids are already inserted - if not, calls would fail. Once linked, the linked objects cannot be
        /// unlinked. You cannot link objects belonging to another issuer. There is a limit to the number of objects
        /// that can be linked to a single object. After the limit is reached, new linked objects in the call will be
        /// ignored silently. Object IDs should follow the format issuer ID. identifier where the former is issued by
        /// Google and the latter is chosen by you.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkedObjectIds")]
        public virtual System.Collections.Generic.IList<string> LinkedObjectIds { get; set; }

        /// <summary>
        /// A list of offer objects linked to this event ticket. The offer objects must already exist. Offer object IDs
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkedOfferIds")]
        public virtual System.Collections.Generic.IList<string> LinkedOfferIds { get; set; }

        /// <summary>
        /// Links module data. If links module data is also defined on the class, both will be displayed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linksModuleData")]
        public virtual LinksModuleData LinksModuleData { get; set; }

        /// <summary>Note: This field is currently not supported to trigger geo notifications.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<LatLongPoint> Locations { get; set; }

        /// <summary>
        /// Merchant locations. There is a maximum of ten on the object. Any additional MerchantLocations added beyond
        /// the 10 will be rejected. These locations will trigger a notification when a user enters within a Google-set
        /// radius of the point. This field replaces the deprecated LatLongPoints.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantLocations")]
        public virtual System.Collections.Generic.IList<MerchantLocation> MerchantLocations { get; set; }

        /// <summary>
        /// An array of messages displayed in the app. All users of this object will receive its associated messages.
        /// The maximum number of these fields is 10.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<Message> Messages { get; set; }

        /// <summary>
        /// Whether or not field updates to this object should trigger notifications. When set to NOTIFY, we will
        /// attempt to trigger a field update notification to users. These notifications will only be sent to users if
        /// the field is part of an allowlist. If set to DO_NOT_NOTIFY or NOTIFICATION_SETTINGS_UNSPECIFIED, no
        /// notification will be triggered. This setting is ephemeral and needs to be set with each PATCH or UPDATE
        /// request, otherwise a notification will not be triggered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notifyPreference")]
        public virtual string NotifyPreference { get; set; }

        /// <summary>Pass constraints for the object. Includes limiting NFC and screenshot behaviors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passConstraints")]
        public virtual PassConstraints PassConstraints { get; set; }

        /// <summary>
        /// Reservation details for this ticket. This is expected to be shared amongst all tickets that were purchased
        /// in the same order.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reservationInfo")]
        public virtual EventReservationInfo ReservationInfo { get; set; }

        /// <summary>The rotating barcode type and value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rotatingBarcode")]
        public virtual RotatingBarcode RotatingBarcode { get; set; }

        /// <summary>
        /// Restrictions on the object that needs to be verified before the user tries to save the pass. Note that this
        /// restrictions will only be applied during save time. If the restrictions changed after a user saves the pass,
        /// the new restrictions will not be applied to an already saved pass.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("saveRestrictions")]
        public virtual SaveRestrictions SaveRestrictions { get; set; }

        /// <summary>Seating details for this ticket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seatInfo")]
        public virtual EventSeat SeatInfo { get; set; }

        /// <summary>
        /// The value that will be transmitted to a Smart Tap certified terminal over NFC for this object. The class
        /// level fields `enableSmartTap` and `redemptionIssuers` must also be set up correctly in order for the pass to
        /// support Smart Tap. Only ASCII characters are supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("smartTapRedemptionValue")]
        public virtual string SmartTapRedemptionValue { get; set; }

        /// <summary>
        /// Required. The state of the object. This field is used to determine how an object is displayed in the app.
        /// For example, an `inactive` object is moved to the "Expired passes" section.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Text module data. If text module data is also defined on the class, both will be displayed. The maximum
        /// number of these fields displayed is 10 from the object and 10 from the class.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textModulesData")]
        public virtual System.Collections.Generic.IList<TextModuleData> TextModulesData { get; set; }

        /// <summary>
        /// Name of the ticket holder, if the ticket is assigned to a person. E.g. "John Doe" or "Jane Doe".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ticketHolderName")]
        public virtual string TicketHolderName { get; set; }

        /// <summary>
        /// The number of the ticket. This can be a unique identifier across all tickets in an issuer's system, all
        /// tickets for the event (e.g. XYZ1234512345), or all tickets in the order (1, 2, 3, etc.).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ticketNumber")]
        public virtual string TicketNumber { get; set; }

        /// <summary>The type of the ticket, such as "Adult" or "Child", or "VIP" or "Standard".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ticketType")]
        public virtual LocalizedString TicketType { get; set; }

        /// <summary>
        /// The time period this object will be `active` and object can be used. An object's state will be changed to
        /// `expired` when this time period has passed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validTimeInterval")]
        public virtual TimeInterval ValidTimeInterval { get; set; }

        /// <summary>Optional value added module data. Maximum of ten on the object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueAddedModuleData")]
        public virtual System.Collections.Generic.IList<ValueAddedModuleData> ValueAddedModuleData { get; set; }

        /// <summary>Deprecated</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<long> Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EventTicketObjectAddMessageResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The updated EventTicketObject resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual EventTicketObject Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EventTicketObjectListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Pagination of the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pagination")]
        public virtual Pagination Pagination { get; set; }

        /// <summary>Resources corresponding to the list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<EventTicketObject> Resources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EventVenue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The address of the venue, such as "24 Willie Mays Plaza\nSan Francisco, CA 94107". Address lines are
        /// separated by line feed (`\n`) characters. This is required.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual LocalizedString Address { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string `"walletobjects#eventVenue"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The name of the venue, such as "AT&amp;T Park". This is required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual LocalizedString Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Indicates that the issuer would like Google Wallet to send expiry notifications 2 days prior to the card
    /// expiration.
    /// </summary>
    public class ExpiryNotification : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates if the object needs to have expiry notification enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableNotification")]
        public virtual System.Nullable<bool> EnableNotification { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Reference definition to use with field overrides.</summary>
    public class FieldReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Only valid if the `fieldPath` references a date field. Chooses how the date field will be formatted and
        /// displayed in the UI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateFormat")]
        public virtual string DateFormat { get; set; }

        /// <summary>
        /// Path to the field being referenced, prefixed with "object" or "class" and separated with dots. For example,
        /// it may be the string "object.purchaseDetails.purchasePrice".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldPath")]
        public virtual string FieldPath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Custom field selector to use with field overrides.</summary>
    public class FieldSelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If more than one reference is supplied, then the first one that references a non-empty field will be
        /// displayed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IList<FieldReference> Fields { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class FirstRowOption : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A reference to the field to be displayed in the first row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldOption")]
        public virtual FieldSelector FieldOption { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("transitOption")]
        public virtual string TransitOption { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class FlightCarrier : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A logo for the airline alliance, displayed below the QR code that the passenger scans to board.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("airlineAllianceLogo")]
        public virtual Image AirlineAllianceLogo { get; set; }

        /// <summary>
        /// A logo for the airline described by carrierIataCode and localizedAirlineName. This logo will be rendered at
        /// the top of the detailed card view.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("airlineLogo")]
        public virtual Image AirlineLogo { get; set; }

        /// <summary>
        /// A localized name of the airline specified by carrierIataCode. If unset, `issuer_name` or
        /// `localized_issuer_name` from `FlightClass` will be used for display purposes. eg: "Swiss Air" for "LX"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("airlineName")]
        public virtual LocalizedString AirlineName { get; set; }

        /// <summary>
        /// Two character IATA airline code of the marketing carrier (as opposed to operating carrier). Exactly one of
        /// this or `carrierIcaoCode` needs to be provided for `carrier` and `operatingCarrier`. eg: "LX" for Swiss Air
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("carrierIataCode")]
        public virtual string CarrierIataCode { get; set; }

        /// <summary>
        /// Three character ICAO airline code of the marketing carrier (as opposed to operating carrier). Exactly one of
        /// this or `carrierIataCode` needs to be provided for `carrier` and `operatingCarrier`. eg: "EZY" for Easy Jet
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("carrierIcaoCode")]
        public virtual string CarrierIcaoCode { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string `"walletobjects#flightCarrier"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The wide logo of the airline. When provided, this will be used in place of the airline logo in the top left
        /// of the card view.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wideAirlineLogo")]
        public virtual Image WideAirlineLogo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class FlightClass : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Deprecated. Use `multipleDevicesAndHoldersAllowedStatus` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowMultipleUsersPerObject")]
        public virtual System.Nullable<bool> AllowMultipleUsersPerObject { get; set; }

        /// <summary>
        /// Optional app or website link that will be displayed as a button on the front of the pass. If AppLinkData is
        /// provided for the corresponding object that will be used instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appLinkData")]
        public virtual AppLinkData AppLinkData { get; set; }

        /// <summary>Policies for boarding and seating. These will inform which labels will be shown to users.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boardingAndSeatingPolicy")]
        public virtual BoardingAndSeatingPolicy BoardingAndSeatingPolicy { get; set; }

        /// <summary>
        /// Callback options to be used to call the issuer back for every save/delete of an object for this class by the
        /// end-user. All objects of this class are eligible for the callback.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callbackOptions")]
        public virtual CallbackOptions CallbackOptions { get; set; }

        /// <summary>
        /// Template information about how the class should be displayed. If unset, Google will fallback to a default
        /// set of fields to display.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classTemplateInfo")]
        public virtual ClassTemplateInfo ClassTemplateInfo { get; set; }

        /// <summary>
        /// Country code used to display the card's country (when the user is not in that country), as well as to
        /// display localized content when content is not available in the user's locale.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countryCode")]
        public virtual string CountryCode { get; set; }

        /// <summary>Required. Destination airport.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destination")]
        public virtual AirportInfo Destination { get; set; }

        /// <summary>
        /// Identifies whether this class supports Smart Tap. The `redemptionIssuers` and object level
        /// `smartTapRedemptionLevel` fields must also be set up correctly in order for a pass to support Smart Tap.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableSmartTap")]
        public virtual System.Nullable<bool> EnableSmartTap { get; set; }

        /// <summary>Required. Information about the flight carrier and number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flightHeader")]
        public virtual FlightHeader FlightHeader { get; set; }

        /// <summary>
        /// Status of this flight. If unset, Google will compute status based on data from other sources, such as
        /// FlightStats, etc. Note: Google-computed status will not be returned in API responses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flightStatus")]
        public virtual string FlightStatus { get; set; }

        /// <summary>
        /// Optional banner image displayed on the front of the card. If none is present, nothing will be displayed. The
        /// image will display at 100% width.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heroImage")]
        public virtual Image HeroImage { get; set; }

        /// <summary>
        /// The background color for the card. If not set the dominant color of the hero image is used, and if no hero
        /// image is set, the dominant color of the logo is used. The format is #rrggbb where rrggbb is a hex RGB
        /// triplet, such as `#ffcc00`. You can also use the shorthand version of the RGB triplet which is #rgb, such as
        /// `#fc0`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hexBackgroundColor")]
        public virtual string HexBackgroundColor { get; set; }

        /// <summary>
        /// The URI of your application's home page. Populating the URI in this field results in the exact same behavior
        /// as populating an URI in linksModuleData (when an object is rendered, a link to the homepage is shown in what
        /// would usually be thought of as the linksModuleData section of the object).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("homepageUri")]
        public virtual Uri HomepageUri { get; set; }

        /// <summary>
        /// Required. The unique identifier for a class. This ID must be unique across all classes from an issuer. This
        /// value should follow the format issuer ID. identifier where the former is issued by Google and latter is
        /// chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Image module data. The maximum number of these fields displayed is 1 from object level and 1 for class
        /// object level.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageModulesData")]
        public virtual System.Collections.Generic.IList<ImageModuleData> ImageModulesData { get; set; }

        /// <summary>Deprecated. Use textModulesData instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infoModuleData")]
        public virtual InfoModuleData InfoModuleData { get; set; }

        /// <summary>
        /// Required. The issuer name. Recommended maximum length is 20 characters to ensure full string is displayed on
        /// smaller screens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issuerName")]
        public virtual string IssuerName { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string `"walletobjects#flightClass"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// If this field is present, boarding passes served to a user's device will always be in this language.
        /// Represents the BCP 47 language tag. Example values are "en-US", "en-GB", "de", or "de-AT".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageOverride")]
        public virtual string LanguageOverride { get; set; }

        /// <summary>
        /// Links module data. If links module data is also defined on the object, both will be displayed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linksModuleData")]
        public virtual LinksModuleData LinksModuleData { get; set; }

        /// <summary>
        /// The boarding time as it would be printed on the boarding pass. This is an ISO 8601 extended format date/time
        /// without an offset. Time may be specified up to millisecond precision. eg: `2027-03-05T06:30:00` This should
        /// be the local date/time at the airport (not a UTC time). Google will reject the request if UTC offset is
        /// provided. Time zones will be calculated by Google based on departure airport.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localBoardingDateTime")]
        public virtual string LocalBoardingDateTime { get; set; }

        /// <summary>
        /// The estimated time the aircraft plans to reach the destination gate (not the runway) or the actual time it
        /// reached the gate. This field should be set if at least one of the below is true: - It differs from the
        /// scheduled time. Google will use it to calculate the delay. - The aircraft already arrived at the gate.
        /// Google will use it to inform the user that the flight has arrived at the gate. This is an ISO 8601 extended
        /// format date/time without an offset. Time may be specified up to millisecond precision. eg:
        /// `2027-03-05T06:30:00` This should be the local date/time at the airport (not a UTC time). Google will reject
        /// the request if UTC offset is provided. Time zones will be calculated by Google based on arrival airport.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localEstimatedOrActualArrivalDateTime")]
        public virtual string LocalEstimatedOrActualArrivalDateTime { get; set; }

        /// <summary>
        /// The estimated time the aircraft plans to pull from the gate or the actual time the aircraft already pulled
        /// from the gate. Note: This is not the runway time. This field should be set if at least one of the below is
        /// true: - It differs from the scheduled time. Google will use it to calculate the delay. - The aircraft
        /// already pulled from the gate. Google will use it to inform the user when the flight actually departed. This
        /// is an ISO 8601 extended format date/time without an offset. Time may be specified up to millisecond
        /// precision. eg: `2027-03-05T06:30:00` This should be the local date/time at the airport (not a UTC time).
        /// Google will reject the request if UTC offset is provided. Time zones will be calculated by Google based on
        /// departure airport.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localEstimatedOrActualDepartureDateTime")]
        public virtual string LocalEstimatedOrActualDepartureDateTime { get; set; }

        /// <summary>
        /// The gate closing time as it would be printed on the boarding pass. Do not set this field if you do not want
        /// to print it in the boarding pass. This is an ISO 8601 extended format date/time without an offset. Time may
        /// be specified up to millisecond precision. eg: `2027-03-05T06:30:00` This should be the local date/time at
        /// the airport (not a UTC time). Google will reject the request if UTC offset is provided. Time zones will be
        /// calculated by Google based on departure airport.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localGateClosingDateTime")]
        public virtual string LocalGateClosingDateTime { get; set; }

        /// <summary>
        /// The scheduled time the aircraft plans to reach the destination gate (not the runway). Note: This field
        /// should not change too close to the flight time. For updates to departure times (delays, etc), please set
        /// `localEstimatedOrActualArrivalDateTime`. This is an ISO 8601 extended format date/time without an offset.
        /// Time may be specified up to millisecond precision. eg: `2027-03-05T06:30:00` This should be the local
        /// date/time at the airport (not a UTC time). Google will reject the request if UTC offset is provided. Time
        /// zones will be calculated by Google based on arrival airport.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localScheduledArrivalDateTime")]
        public virtual string LocalScheduledArrivalDateTime { get; set; }

        /// <summary>
        /// Required. The scheduled date and time when the aircraft is expected to depart the gate (not the runway)
        /// Note: This field should not change too close to the departure time. For updates to departure times (delays,
        /// etc), please set `localEstimatedOrActualDepartureDateTime`. This is an ISO 8601 extended format date/time
        /// without an offset. Time may be specified up to millisecond precision. eg: `2027-03-05T06:30:00` This should
        /// be the local date/time at the airport (not a UTC time). Google will reject the request if UTC offset is
        /// provided. Time zones will be calculated by Google based on departure airport.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localScheduledDepartureDateTime")]
        public virtual string LocalScheduledDepartureDateTime { get; set; }

        /// <summary>
        /// Translated strings for the issuer_name. Recommended maximum length is 20 characters to ensure full string is
        /// displayed on smaller screens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedIssuerName")]
        public virtual LocalizedString LocalizedIssuerName { get; set; }

        /// <summary>Note: This field is currently not supported to trigger geo notifications.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<LatLongPoint> Locations { get; set; }

        /// <summary>
        /// Merchant locations. There is a maximum of ten on the class. Any additional MerchantLocations added beyond
        /// the 10 will be rejected by the validator. These locations will trigger a notification when a user enters
        /// within a Google-set radius of the point. This field replaces the deprecated LatLongPoints.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantLocations")]
        public virtual System.Collections.Generic.IList<MerchantLocation> MerchantLocations { get; set; }

        /// <summary>
        /// An array of messages displayed in the app. All users of this object will receive its associated messages.
        /// The maximum number of these fields is 10.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<Message> Messages { get; set; }

        /// <summary>
        /// Identifies whether multiple users and devices will save the same object referencing this class.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multipleDevicesAndHoldersAllowedStatus")]
        public virtual string MultipleDevicesAndHoldersAllowedStatus { get; set; }

        /// <summary>
        /// Whether or not field updates to this class should trigger notifications. When set to NOTIFY, we will attempt
        /// to trigger a field update notification to users. These notifications will only be sent to users if the field
        /// is part of an allowlist. If not specified, no notification will be triggered. This setting is ephemeral and
        /// needs to be set with each PATCH or UPDATE request, otherwise a notification will not be triggered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notifyPreference")]
        public virtual string NotifyPreference { get; set; }

        /// <summary>Required. Origin airport.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("origin")]
        public virtual AirportInfo Origin { get; set; }

        /// <summary>
        /// Identifies which redemption issuers can redeem the pass over Smart Tap. Redemption issuers are identified by
        /// their issuer ID. Redemption issuers must have at least one Smart Tap key configured. The `enableSmartTap`
        /// and object level `smartTapRedemptionLevel` fields must also be set up correctly in order for a pass to
        /// support Smart Tap.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redemptionIssuers")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> RedemptionIssuers { get; set; }

        /// <summary>The review comments set by the platform when a class is marked `approved` or `rejected`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("review")]
        public virtual Review Review { get; set; }

        /// <summary>
        /// Required. The status of the class. This field can be set to `draft` or `underReview` using the insert,
        /// patch, or update API calls. Once the review state is changed from `draft` it may not be changed back to
        /// `draft`. You should keep this field to `draft` when the class is under development. A `draft` class cannot
        /// be used to create any object. You should set this field to `underReview` when you believe the class is ready
        /// for use. The platform will automatically set this field to `approved` and it can be immediately used to
        /// create or migrate objects. When updating an already `approved` class you should keep setting this field to
        /// `underReview`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reviewStatus")]
        public virtual string ReviewStatus { get; set; }

        /// <summary>
        /// Optional information about the security animation. If this is set a security animation will be rendered on
        /// pass details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityAnimation")]
        public virtual SecurityAnimation SecurityAnimation { get; set; }

        /// <summary>
        /// Text module data. If text module data is also defined on the class, both will be displayed. The maximum
        /// number of these fields displayed is 10 from the object and 10 from the class.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textModulesData")]
        public virtual System.Collections.Generic.IList<TextModuleData> TextModulesData { get; set; }

        /// <summary>
        /// Optional value added module data. Maximum of ten on the class. For a pass only ten will be displayed,
        /// prioritizing those from the object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueAddedModuleData")]
        public virtual System.Collections.Generic.IList<ValueAddedModuleData> ValueAddedModuleData { get; set; }

        /// <summary>Deprecated</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<long> Version { get; set; }

        /// <summary>View Unlock Requirement options for the boarding pass.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewUnlockRequirement")]
        public virtual string ViewUnlockRequirement { get; set; }

        /// <summary>Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wordMark")]
        public virtual Image WordMark { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class FlightClassAddMessageResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The updated FlightClass resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual FlightClass Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class FlightClassListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Pagination of the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pagination")]
        public virtual Pagination Pagination { get; set; }

        /// <summary>Resources corresponding to the list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<FlightClass> Resources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class FlightHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Information about airline carrier. This is a required property of `flightHeader`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("carrier")]
        public virtual FlightCarrier Carrier { get; set; }

        /// <summary>
        /// The flight number without IATA carrier code. This field should contain only digits. This is a required
        /// property of `flightHeader`. eg: "123"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flightNumber")]
        public virtual string FlightNumber { get; set; }

        /// <summary>
        /// Override value to use for flight number. The default value used for display purposes is carrier +
        /// flight_number. If a different value needs to be shown to passengers, use this field to override the default
        /// behavior. eg: "XX1234 / YY576"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flightNumberDisplayOverride")]
        public virtual string FlightNumberDisplayOverride { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string `"walletobjects#flightHeader"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Information about operating airline carrier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatingCarrier")]
        public virtual FlightCarrier OperatingCarrier { get; set; }

        /// <summary>
        /// The flight number used by the operating carrier without IATA carrier code. This field should contain only
        /// digits. eg: "234"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatingFlightNumber")]
        public virtual string OperatingFlightNumber { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class FlightObject : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional app or website link that will be displayed as a button on the front of the pass. If AppLinkData is
        /// provided for the corresponding class only object AppLinkData will be displayed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appLinkData")]
        public virtual AppLinkData AppLinkData { get; set; }

        /// <summary>The barcode type and value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("barcode")]
        public virtual Barcode Barcode { get; set; }

        /// <summary>Passenger specific information about boarding and seating.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boardingAndSeatingInfo")]
        public virtual BoardingAndSeatingInfo BoardingAndSeatingInfo { get; set; }

        /// <summary>
        /// Required. The class associated with this object. The class must be of the same type as this object, must
        /// already exist, and must be approved. Class IDs should follow the format issuer ID.identifier where the
        /// former is issued by Google and latter is chosen by you.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classId")]
        public virtual string ClassId { get; set; }

        /// <summary>
        /// A copy of the inherited fields of the parent class. These fields are retrieved during a GET.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classReference")]
        public virtual FlightClass ClassReference { get; set; }

        /// <summary>
        /// Indicates if notifications should explicitly be suppressed. If this field is set to true, regardless of the
        /// `messages` field, expiration notifications to the user will be suppressed. By default, this field is set to
        /// false. Currently, this can only be set for Flights.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableExpirationNotification")]
        public virtual System.Nullable<bool> DisableExpirationNotification { get; set; }

        /// <summary>Information that controls how passes are grouped together.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupingInfo")]
        public virtual GroupingInfo GroupingInfo { get; set; }

        /// <summary>
        /// Whether this object is currently linked to a single device. This field is set by the platform when a user
        /// saves the object, linking it to their device. Intended for use by select partners. Contact support for
        /// additional information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasLinkedDevice")]
        public virtual System.Nullable<bool> HasLinkedDevice { get; set; }

        /// <summary>Indicates if the object has users. This field is set by the platform.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasUsers")]
        public virtual System.Nullable<bool> HasUsers { get; set; }

        /// <summary>
        /// Optional banner image displayed on the front of the card. If none is present, hero image of the class, if
        /// present, will be displayed. If hero image of the class is also not present, nothing will be displayed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heroImage")]
        public virtual Image HeroImage { get; set; }

        /// <summary>
        /// The background color for the card. If not set the dominant color of the hero image is used, and if no hero
        /// image is set, the dominant color of the logo is used. The format is #rrggbb where rrggbb is a hex RGB
        /// triplet, such as `#ffcc00`. You can also use the shorthand version of the RGB triplet which is #rgb, such as
        /// `#fc0`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hexBackgroundColor")]
        public virtual string HexBackgroundColor { get; set; }

        /// <summary>
        /// Required. The unique identifier for an object. This ID must be unique across all objects from an issuer.
        /// This value should follow the format issuer ID.identifier where the former is issued by Google and latter is
        /// chosen by you. The unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Image module data. The maximum number of these fields displayed is 1 from object level and 1 for class
        /// object level.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageModulesData")]
        public virtual System.Collections.Generic.IList<ImageModuleData> ImageModulesData { get; set; }

        /// <summary>Deprecated. Use textModulesData instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infoModuleData")]
        public virtual InfoModuleData InfoModuleData { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string `"walletobjects#flightObject"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// linked_object_ids are a list of other objects such as event ticket, loyalty, offer, generic, giftcard,
        /// transit and boarding pass that should be automatically attached to this flight object. If a user had saved
        /// this boarding pass, then these linked_object_ids would be automatically pushed to the user's wallet (unless
        /// they turned off the setting to receive such linked passes). Make sure that objects present in
        /// linked_object_ids are already inserted - if not, calls would fail. Once linked, the linked objects cannot be
        /// unlinked. You cannot link objects belonging to another issuer. There is a limit to the number of objects
        /// that can be linked to a single object. After the limit is reached, new linked objects in the call will be
        /// ignored silently. Object IDs should follow the format issuer ID. identifier where the former is issued by
        /// Google and the latter is chosen by you.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkedObjectIds")]
        public virtual System.Collections.Generic.IList<string> LinkedObjectIds { get; set; }

        /// <summary>
        /// Links module data. If links module data is also defined on the class, both will be displayed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linksModuleData")]
        public virtual LinksModuleData LinksModuleData { get; set; }

        /// <summary>Note: This field is currently not supported to trigger geo notifications.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<LatLongPoint> Locations { get; set; }

        /// <summary>
        /// Merchant locations. There is a maximum of ten on the object. Any additional MerchantLocations added beyond
        /// the 10 will be rejected. These locations will trigger a notification when a user enters within a Google-set
        /// radius of the point. This field replaces the deprecated LatLongPoints.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantLocations")]
        public virtual System.Collections.Generic.IList<MerchantLocation> MerchantLocations { get; set; }

        /// <summary>
        /// An array of messages displayed in the app. All users of this object will receive its associated messages.
        /// The maximum number of these fields is 10.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<Message> Messages { get; set; }

        /// <summary>
        /// Whether or not field updates to this object should trigger notifications. When set to NOTIFY, we will
        /// attempt to trigger a field update notification to users. These notifications will only be sent to users if
        /// the field is part of an allowlist. If set to DO_NOT_NOTIFY or NOTIFICATION_SETTINGS_UNSPECIFIED, no
        /// notification will be triggered. This setting is ephemeral and needs to be set with each PATCH or UPDATE
        /// request, otherwise a notification will not be triggered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notifyPreference")]
        public virtual string NotifyPreference { get; set; }

        /// <summary>Pass constraints for the object. Includes limiting NFC and screenshot behaviors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passConstraints")]
        public virtual PassConstraints PassConstraints { get; set; }

        /// <summary>
        /// Required. Passenger name as it would appear on the boarding pass. eg: "Dave M Gahan" or "Gahan/Dave" or
        /// "GAHAN/DAVEM"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passengerName")]
        public virtual string PassengerName { get; set; }

        /// <summary>Required. Information about flight reservation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reservationInfo")]
        public virtual ReservationInfo ReservationInfo { get; set; }

        /// <summary>The rotating barcode type and value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rotatingBarcode")]
        public virtual RotatingBarcode RotatingBarcode { get; set; }

        /// <summary>
        /// Restrictions on the object that needs to be verified before the user tries to save the pass. Note that this
        /// restrictions will only be applied during save time. If the restrictions changed after a user saves the pass,
        /// the new restrictions will not be applied to an already saved pass.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("saveRestrictions")]
        public virtual SaveRestrictions SaveRestrictions { get; set; }

        /// <summary>An image for the security program that applies to the passenger.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityProgramLogo")]
        public virtual Image SecurityProgramLogo { get; set; }

        /// <summary>
        /// The value that will be transmitted to a Smart Tap certified terminal over NFC for this object. The class
        /// level fields `enableSmartTap` and `redemptionIssuers` must also be set up correctly in order for the pass to
        /// support Smart Tap. Only ASCII characters are supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("smartTapRedemptionValue")]
        public virtual string SmartTapRedemptionValue { get; set; }

        /// <summary>
        /// Required. The state of the object. This field is used to determine how an object is displayed in the app.
        /// For example, an `inactive` object is moved to the "Expired passes" section.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Text module data. If text module data is also defined on the class, both will be displayed. The maximum
        /// number of these fields displayed is 10 from the object and 10 from the class.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textModulesData")]
        public virtual System.Collections.Generic.IList<TextModuleData> TextModulesData { get; set; }

        /// <summary>
        /// The time period this object will be `active` and object can be used. An object's state will be changed to
        /// `expired` when this time period has passed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validTimeInterval")]
        public virtual TimeInterval ValidTimeInterval { get; set; }

        /// <summary>Optional value added module data. Maximum of ten on the object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueAddedModuleData")]
        public virtual System.Collections.Generic.IList<ValueAddedModuleData> ValueAddedModuleData { get; set; }

        /// <summary>Deprecated</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<long> Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class FlightObjectAddMessageResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The updated FlightObject resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual FlightObject Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class FlightObjectListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Pagination of the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pagination")]
        public virtual Pagination Pagination { get; set; }

        /// <summary>Resources corresponding to the list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<FlightObject> Resources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class FrequentFlyerInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Frequent flyer number. Required for each nested object of kind `walletobjects#frequentFlyerInfo`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frequentFlyerNumber")]
        public virtual string FrequentFlyerNumber { get; set; }

        /// <summary>Frequent flyer program name. eg: "Lufthansa Miles &amp; More"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frequentFlyerProgramName")]
        public virtual LocalizedString FrequentFlyerProgramName { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string `"walletobjects#frequentFlyerInfo"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Generic Class</summary>
    public class GenericClass : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional app or website link that will be displayed as a button on the front of the pass. If AppLinkData is
        /// provided for the corresponding object that will be used instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appLinkData")]
        public virtual AppLinkData AppLinkData { get; set; }

        /// <summary>
        /// Callback options to be used to call the issuer back for every save/delete of an object for this class by the
        /// end-user. All objects of this class are eligible for the callback.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callbackOptions")]
        public virtual CallbackOptions CallbackOptions { get; set; }

        /// <summary>
        /// Template information about how the class should be displayed. If unset, Google will fallback to a default
        /// set of fields to display.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classTemplateInfo")]
        public virtual ClassTemplateInfo ClassTemplateInfo { get; set; }

        /// <summary>Available only to Smart Tap enabled partners. Contact support for additional guidance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableSmartTap")]
        public virtual System.Nullable<bool> EnableSmartTap { get; set; }

        /// <summary>
        /// Required. The unique identifier for the class. This ID must be unique across all from an issuer. This value
        /// needs to follow the format `issuerID.identifier` where `issuerID` is issued by Google and `identifier` is
        /// chosen by you. The unique identifier can only include alphanumeric characters, `.`, `_`, or `-`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Image module data. If `imageModulesData` is also defined on the object, both will be displayed. Only one of
        /// the image from class and one from object level will be rendered when both set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageModulesData")]
        public virtual System.Collections.Generic.IList<ImageModuleData> ImageModulesData { get; set; }

        /// <summary>
        /// Links module data. If `linksModuleData` is also defined on the object, both will be displayed. The maximum
        /// number of these fields displayed is 10 from class and 10 from object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linksModuleData")]
        public virtual LinksModuleData LinksModuleData { get; set; }

        /// <summary>
        /// Merchant locations. There is a maximum of ten on the class. Any additional MerchantLocations added beyond
        /// the 10 will be rejected. These locations will trigger a notification when a user enters within a Google-set
        /// radius of the point. This field replaces the deprecated LatLongPoints.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantLocations")]
        public virtual System.Collections.Generic.IList<MerchantLocation> MerchantLocations { get; set; }

        /// <summary>
        /// An array of messages displayed in the app. All users of this object will receive its associated messages.
        /// The maximum number of these fields is 10.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<Message> Messages { get; set; }

        /// <summary>
        /// Identifies whether multiple users and devices will save the same object referencing this class.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multipleDevicesAndHoldersAllowedStatus")]
        public virtual string MultipleDevicesAndHoldersAllowedStatus { get; set; }

        /// <summary>
        /// Identifies which redemption issuers can redeem the pass over Smart Tap. Redemption issuers are identified by
        /// their issuer ID. Redemption issuers must have at least one Smart Tap key configured. The `enableSmartTap`
        /// and object level `smartTapRedemptionLevel` fields must also be set up correctly in order for a pass to
        /// support Smart Tap.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redemptionIssuers")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> RedemptionIssuers { get; set; }

        /// <summary>
        /// Optional information about the security animation. If this is set a security animation will be rendered on
        /// pass details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityAnimation")]
        public virtual SecurityAnimation SecurityAnimation { get; set; }

        /// <summary>
        /// Text module data. If `textModulesData` is also defined on the object, both will be displayed. The maximum
        /// number of these fields displayed is 10 from class and 10 from object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textModulesData")]
        public virtual System.Collections.Generic.IList<TextModuleData> TextModulesData { get; set; }

        /// <summary>
        /// Optional value added module data. Maximum of ten on the class. For a pass only ten will be displayed,
        /// prioritizing those from the object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueAddedModuleData")]
        public virtual System.Collections.Generic.IList<ValueAddedModuleData> ValueAddedModuleData { get; set; }

        /// <summary>View Unlock Requirement options for the generic pass.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewUnlockRequirement")]
        public virtual string ViewUnlockRequirement { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response to adding a new issuer message to the class. This contains the entire updated GenericClass.
    /// </summary>
    public class GenericClassAddMessageResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The updated EventTicketClass resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual GenericClass Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List response which contains the list of all generic classes for a given issuer ID.</summary>
    public class GenericClassListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Pagination of the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pagination")]
        public virtual Pagination Pagination { get; set; }

        /// <summary>Resources corresponding to the list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<GenericClass> Resources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Generic Object</summary>
    public class GenericObject : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional app or website link that will be displayed as a button on the front of the pass. If AppLinkData is
        /// provided for the corresponding class only object AppLinkData will be displayed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appLinkData")]
        public virtual AppLinkData AppLinkData { get; set; }

        /// <summary>
        /// The barcode type and value. If pass does not have a barcode, we can allow the issuer to set
        /// Barcode.alternate_text and display just that.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("barcode")]
        public virtual Barcode Barcode { get; set; }

        /// <summary>
        /// Required. The header of the pass. This is usually the Business name such as "XXX Gym", "AAA Insurance". This
        /// field is required and appears in the header row at the very top of the pass.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardTitle")]
        public virtual LocalizedString CardTitle { get; set; }

        /// <summary>
        /// Required. The class associated with this object. The class must be of the same type as this object, must
        /// already exist, and must be approved. Class IDs should follow the format `issuerID.identifier` where
        /// `issuerID` is issued by Google and `identifier` is chosen by you.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classId")]
        public virtual string ClassId { get; set; }

        /// <summary>Specify which `GenericType` the card belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("genericType")]
        public virtual string GenericType { get; set; }

        /// <summary>Information that controls how passes are grouped together.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupingInfo")]
        public virtual GroupingInfo GroupingInfo { get; set; }

        /// <summary>Indicates if the object has users. This field is set by the platform.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasUsers")]
        public virtual System.Nullable<bool> HasUsers { get; set; }

        /// <summary>
        /// Required. The title of the pass, such as "50% off coupon" or "Library card" or "Voucher". This field is
        /// required and appears in the title row of the pass detail view.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual LocalizedString Header { get; set; }

        /// <summary>
        /// Banner image displayed on the front of the card if present. The image will be displayed at 100% width.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heroImage")]
        public virtual Image HeroImage { get; set; }

        /// <summary>
        /// The background color for the card. If not set, the dominant color of the hero image is used, and if no hero
        /// image is set, the dominant color of the logo is used and if logo is not set, a color would be chosen by
        /// Google.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hexBackgroundColor")]
        public virtual string HexBackgroundColor { get; set; }

        /// <summary>
        /// Required. The unique identifier for an object. This ID must be unique across all objects from an issuer.
        /// This value needs to follow the format `issuerID.identifier` where `issuerID` is issued by Google and
        /// `identifier` is chosen by you. The unique identifier can only include alphanumeric characters, `.`, `_`, or
        /// `-`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Image module data. Only one of the image from class and one from object level will be rendered when both
        /// set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageModulesData")]
        public virtual System.Collections.Generic.IList<ImageModuleData> ImageModulesData { get; set; }

        /// <summary>
        /// linked_object_ids are a list of other objects such as event ticket, loyalty, offer, generic, giftcard,
        /// transit and boarding pass that should be automatically attached to this generic object. If a user had saved
        /// this generic card, then these linked_object_ids would be automatically pushed to the user's wallet (unless
        /// they turned off the setting to receive such linked passes). Make sure that objects present in
        /// linked_object_ids are already inserted - if not, calls would fail. Once linked, the linked objects cannot be
        /// unlinked. You cannot link objects belonging to another issuer. There is a limit to the number of objects
        /// that can be linked to a single object. After the limit is reached, new linked objects in the call will be
        /// ignored silently. Object IDs should follow the format issuer ID. identifier where the former is issued by
        /// Google and the latter is chosen by you.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkedObjectIds")]
        public virtual System.Collections.Generic.IList<string> LinkedObjectIds { get; set; }

        /// <summary>
        /// Links module data. If `linksModuleData` is also defined on the class, both will be displayed. The maximum
        /// number of these fields displayed is 10 from class and 10 from object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linksModuleData")]
        public virtual LinksModuleData LinksModuleData { get; set; }

        /// <summary>
        /// The logo image of the pass. This image is displayed in the card detail view in upper left, and also on the
        /// list/thumbnail view. If the logo is not present, the first letter of `cardTitle` would be shown as logo.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logo")]
        public virtual Image Logo { get; set; }

        /// <summary>
        /// Merchant locations. There is a maximum of ten on the object. Any additional MerchantLocations added beyond
        /// the 10 will be rejected. These locations will trigger a notification when a user enters within a Google-set
        /// radius of the point. This field replaces the deprecated LatLongPoints.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantLocations")]
        public virtual System.Collections.Generic.IList<MerchantLocation> MerchantLocations { get; set; }

        /// <summary>
        /// An array of messages displayed in the app. All users of this object will receive its associated messages.
        /// The maximum number of these fields is 10.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<Message> Messages { get; set; }

        /// <summary>The notification settings that are enabled for this object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notifications")]
        public virtual Notifications Notifications { get; set; }

        /// <summary>Pass constraints for the object. Includes limiting NFC and screenshot behaviors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passConstraints")]
        public virtual PassConstraints PassConstraints { get; set; }

        /// <summary>The rotating barcode settings/details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rotatingBarcode")]
        public virtual RotatingBarcode RotatingBarcode { get; set; }

        /// <summary>
        /// Restrictions on the object that needs to be verified before the user tries to save the pass. Note that this
        /// restrictions will only be applied during save time. If the restrictions changed after a user saves the pass,
        /// the new restrictions will not be applied to an already saved pass.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("saveRestrictions")]
        public virtual SaveRestrictions SaveRestrictions { get; set; }

        /// <summary>
        /// The value that will be transmitted to a Smart Tap certified terminal over NFC for this object. The class
        /// level fields `enableSmartTap` and `redemptionIssuers` must also be set up correctly in order for the pass to
        /// support Smart Tap. Only ASCII characters are supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("smartTapRedemptionValue")]
        public virtual string SmartTapRedemptionValue { get; set; }

        /// <summary>
        /// The state of the object. This field is used to determine how an object is displayed in the app. For example,
        /// an `inactive` object is moved to the "Expired passes" section. If this is not provided, the object would be
        /// considered `ACTIVE`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// The title label of the pass, such as location where this pass can be used. Appears right above the title in
        /// the title row in the pass detail view.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subheader")]
        public virtual LocalizedString Subheader { get; set; }

        /// <summary>
        /// Text module data. If `textModulesData` is also defined on the class, both will be displayed. The maximum
        /// number of these fields displayed is 10 from class and 10 from object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textModulesData")]
        public virtual System.Collections.Generic.IList<TextModuleData> TextModulesData { get; set; }

        /// <summary>
        /// The time period this object will be considered valid or usable. When the time period is passed, the object
        /// will be considered expired, which will affect the rendering on user's devices.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validTimeInterval")]
        public virtual TimeInterval ValidTimeInterval { get; set; }

        /// <summary>Optional value added module data. Maximum of ten on the object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueAddedModuleData")]
        public virtual System.Collections.Generic.IList<ValueAddedModuleData> ValueAddedModuleData { get; set; }

        /// <summary>
        /// The wide logo of the pass. When provided, this will be used in place of the logo in the top left of the card
        /// view.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wideLogo")]
        public virtual Image WideLogo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response to adding a new issuer message to the object. This contains the entire updated GenericObject.
    /// </summary>
    public class GenericObjectAddMessageResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The updated GenericObject resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual GenericObject Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List response which contains the list of all generic objects for a given issuer ID.</summary>
    public class GenericObjectListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Pagination of the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pagination")]
        public virtual Pagination Pagination { get; set; }

        /// <summary>Resources corresponding to the list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<GenericObject> Resources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GiftCardClass : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Determines whether the merchant supports gift card redemption using barcode. If true, app displays a barcode
        /// for the gift card on the Gift card details screen. If false, a barcode is not displayed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowBarcodeRedemption")]
        public virtual System.Nullable<bool> AllowBarcodeRedemption { get; set; }

        /// <summary>Deprecated. Use `multipleDevicesAndHoldersAllowedStatus` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowMultipleUsersPerObject")]
        public virtual System.Nullable<bool> AllowMultipleUsersPerObject { get; set; }

        /// <summary>
        /// Optional app or website link that will be displayed as a button on the front of the pass. If AppLinkData is
        /// provided for the corresponding object that will be used instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appLinkData")]
        public virtual AppLinkData AppLinkData { get; set; }

        /// <summary>
        /// Callback options to be used to call the issuer back for every save/delete of an object for this class by the
        /// end-user. All objects of this class are eligible for the callback.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callbackOptions")]
        public virtual CallbackOptions CallbackOptions { get; set; }

        /// <summary>The label to display for the card number, such as "Card Number".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardNumberLabel")]
        public virtual string CardNumberLabel { get; set; }

        /// <summary>
        /// Template information about how the class should be displayed. If unset, Google will fallback to a default
        /// set of fields to display.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classTemplateInfo")]
        public virtual ClassTemplateInfo ClassTemplateInfo { get; set; }

        /// <summary>
        /// Country code used to display the card's country (when the user is not in that country), as well as to
        /// display localized content when content is not available in the user's locale.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countryCode")]
        public virtual string CountryCode { get; set; }

        /// <summary>
        /// Identifies whether this class supports Smart Tap. The `redemptionIssuers` and object level
        /// `smartTapRedemptionLevel` fields must also be set up correctly in order for a pass to support Smart Tap.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableSmartTap")]
        public virtual System.Nullable<bool> EnableSmartTap { get; set; }

        /// <summary>The label to display for event number, such as "Target Event #".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventNumberLabel")]
        public virtual string EventNumberLabel { get; set; }

        /// <summary>
        /// Optional banner image displayed on the front of the card. If none is present, nothing will be displayed. The
        /// image will display at 100% width.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heroImage")]
        public virtual Image HeroImage { get; set; }

        /// <summary>
        /// The background color for the card. If not set the dominant color of the hero image is used, and if no hero
        /// image is set, the dominant color of the logo is used. The format is #rrggbb where rrggbb is a hex RGB
        /// triplet, such as `#ffcc00`. You can also use the shorthand version of the RGB triplet which is #rgb, such as
        /// `#fc0`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hexBackgroundColor")]
        public virtual string HexBackgroundColor { get; set; }

        /// <summary>
        /// The URI of your application's home page. Populating the URI in this field results in the exact same behavior
        /// as populating an URI in linksModuleData (when an object is rendered, a link to the homepage is shown in what
        /// would usually be thought of as the linksModuleData section of the object).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("homepageUri")]
        public virtual Uri HomepageUri { get; set; }

        /// <summary>
        /// Required. The unique identifier for a class. This ID must be unique across all classes from an issuer. This
        /// value should follow the format issuer ID. identifier where the former is issued by Google and latter is
        /// chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Image module data. The maximum number of these fields displayed is 1 from object level and 1 for class
        /// object level.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageModulesData")]
        public virtual System.Collections.Generic.IList<ImageModuleData> ImageModulesData { get; set; }

        /// <summary>Deprecated. Use textModulesData instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infoModuleData")]
        public virtual InfoModuleData InfoModuleData { get; set; }

        /// <summary>
        /// Required. The issuer name. Recommended maximum length is 20 characters to ensure full string is displayed on
        /// smaller screens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issuerName")]
        public virtual string IssuerName { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string `"walletobjects#giftCardClass"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Links module data. If links module data is also defined on the object, both will be displayed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linksModuleData")]
        public virtual LinksModuleData LinksModuleData { get; set; }

        /// <summary>Translated strings for the card_number_label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedCardNumberLabel")]
        public virtual LocalizedString LocalizedCardNumberLabel { get; set; }

        /// <summary>Translated strings for the event_number_label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedEventNumberLabel")]
        public virtual LocalizedString LocalizedEventNumberLabel { get; set; }

        /// <summary>
        /// Translated strings for the issuer_name. Recommended maximum length is 20 characters to ensure full string is
        /// displayed on smaller screens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedIssuerName")]
        public virtual LocalizedString LocalizedIssuerName { get; set; }

        /// <summary>
        /// Translated strings for the merchant_name. The app may display an ellipsis after the first 20 characters to
        /// ensure full string is displayed on smaller screens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedMerchantName")]
        public virtual LocalizedString LocalizedMerchantName { get; set; }

        /// <summary>Translated strings for the pin_label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedPinLabel")]
        public virtual LocalizedString LocalizedPinLabel { get; set; }

        /// <summary>Note: This field is currently not supported to trigger geo notifications.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<LatLongPoint> Locations { get; set; }

        /// <summary>
        /// Merchant locations. There is a maximum of ten on the class. Any additional MerchantLocations added beyond
        /// the 10 will be rejected. These locations will trigger a notification when a user enters within a Google-set
        /// radius of the point. This field replaces the deprecated LatLongPoints.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantLocations")]
        public virtual System.Collections.Generic.IList<MerchantLocation> MerchantLocations { get; set; }

        /// <summary>
        /// Merchant name, such as "Adam's Apparel". The app may display an ellipsis after the first 20 characters to
        /// ensure full string is displayed on smaller screens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantName")]
        public virtual string MerchantName { get; set; }

        /// <summary>
        /// An array of messages displayed in the app. All users of this object will receive its associated messages.
        /// The maximum number of these fields is 10.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<Message> Messages { get; set; }

        /// <summary>
        /// Identifies whether multiple users and devices will save the same object referencing this class.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multipleDevicesAndHoldersAllowedStatus")]
        public virtual string MultipleDevicesAndHoldersAllowedStatus { get; set; }

        /// <summary>
        /// Whether or not field updates to this class should trigger notifications. When set to NOTIFY, we will attempt
        /// to trigger a field update notification to users. These notifications will only be sent to users if the field
        /// is part of an allowlist. If not specified, no notification will be triggered. This setting is ephemeral and
        /// needs to be set with each PATCH or UPDATE request, otherwise a notification will not be triggered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notifyPreference")]
        public virtual string NotifyPreference { get; set; }

        /// <summary>The label to display for the PIN, such as "4-digit PIN".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pinLabel")]
        public virtual string PinLabel { get; set; }

        /// <summary>
        /// The logo of the gift card program or company. This logo is displayed in both the details and list views of
        /// the app.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("programLogo")]
        public virtual Image ProgramLogo { get; set; }

        /// <summary>
        /// Identifies which redemption issuers can redeem the pass over Smart Tap. Redemption issuers are identified by
        /// their issuer ID. Redemption issuers must have at least one Smart Tap key configured. The `enableSmartTap`
        /// and object level `smartTapRedemptionLevel` fields must also be set up correctly in order for a pass to
        /// support Smart Tap.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redemptionIssuers")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> RedemptionIssuers { get; set; }

        /// <summary>The review comments set by the platform when a class is marked `approved` or `rejected`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("review")]
        public virtual Review Review { get; set; }

        /// <summary>
        /// Required. The status of the class. This field can be set to `draft` or `underReview` using the insert,
        /// patch, or update API calls. Once the review state is changed from `draft` it may not be changed back to
        /// `draft`. You should keep this field to `draft` when the class is under development. A `draft` class cannot
        /// be used to create any object. You should set this field to `underReview` when you believe the class is ready
        /// for use. The platform will automatically set this field to `approved` and it can be immediately used to
        /// create or migrate objects. When updating an already `approved` class you should keep setting this field to
        /// `underReview`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reviewStatus")]
        public virtual string ReviewStatus { get; set; }

        /// <summary>
        /// Optional information about the security animation. If this is set a security animation will be rendered on
        /// pass details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityAnimation")]
        public virtual SecurityAnimation SecurityAnimation { get; set; }

        /// <summary>
        /// Text module data. If text module data is also defined on the class, both will be displayed. The maximum
        /// number of these fields displayed is 10 from the object and 10 from the class.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textModulesData")]
        public virtual System.Collections.Generic.IList<TextModuleData> TextModulesData { get; set; }

        /// <summary>
        /// Optional value added module data. Maximum of ten on the class. For a pass only ten will be displayed,
        /// prioritizing those from the object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueAddedModuleData")]
        public virtual System.Collections.Generic.IList<ValueAddedModuleData> ValueAddedModuleData { get; set; }

        /// <summary>Deprecated</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<long> Version { get; set; }

        /// <summary>View Unlock Requirement options for the gift card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewUnlockRequirement")]
        public virtual string ViewUnlockRequirement { get; set; }

        /// <summary>
        /// The wide logo of the gift card program or company. When provided, this will be used in place of the program
        /// logo in the top left of the card view.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wideProgramLogo")]
        public virtual Image WideProgramLogo { get; set; }

        /// <summary>Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wordMark")]
        public virtual Image WordMark { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GiftCardClassAddMessageResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The updated GiftCardClass resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual GiftCardClass Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GiftCardClassListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Pagination of the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pagination")]
        public virtual Pagination Pagination { get; set; }

        /// <summary>Resources corresponding to the list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<GiftCardClass> Resources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GiftCardObject : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional app or website link that will be displayed as a button on the front of the pass. If AppLinkData is
        /// provided for the corresponding class only object AppLinkData will be displayed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appLinkData")]
        public virtual AppLinkData AppLinkData { get; set; }

        /// <summary>The card's monetary balance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("balance")]
        public virtual Money Balance { get; set; }

        /// <summary>
        /// The date and time when the balance was last updated. Offset is required. If balance is updated and this
        /// property is not provided, system will default to the current time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("balanceUpdateTime")]
        public virtual DateTime BalanceUpdateTime { get; set; }

        /// <summary>The barcode type and value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("barcode")]
        public virtual Barcode Barcode { get; set; }

        /// <summary>Required. The card's number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardNumber")]
        public virtual string CardNumber { get; set; }

        /// <summary>
        /// Required. The class associated with this object. The class must be of the same type as this object, must
        /// already exist, and must be approved. Class IDs should follow the format issuer ID.identifier where the
        /// former is issued by Google and latter is chosen by you.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classId")]
        public virtual string ClassId { get; set; }

        /// <summary>
        /// A copy of the inherited fields of the parent class. These fields are retrieved during a GET.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classReference")]
        public virtual GiftCardClass ClassReference { get; set; }

        /// <summary>
        /// Indicates if notifications should explicitly be suppressed. If this field is set to true, regardless of the
        /// `messages` field, expiration notifications to the user will be suppressed. By default, this field is set to
        /// false. Currently, this can only be set for offers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableExpirationNotification")]
        public virtual System.Nullable<bool> DisableExpirationNotification { get; set; }

        /// <summary>The card's event number, an optional field used by some gift cards.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventNumber")]
        public virtual string EventNumber { get; set; }

        /// <summary>Information that controls how passes are grouped together.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupingInfo")]
        public virtual GroupingInfo GroupingInfo { get; set; }

        /// <summary>
        /// Whether this object is currently linked to a single device. This field is set by the platform when a user
        /// saves the object, linking it to their device. Intended for use by select partners. Contact support for
        /// additional information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasLinkedDevice")]
        public virtual System.Nullable<bool> HasLinkedDevice { get; set; }

        /// <summary>Indicates if the object has users. This field is set by the platform.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasUsers")]
        public virtual System.Nullable<bool> HasUsers { get; set; }

        /// <summary>
        /// Optional banner image displayed on the front of the card. If none is present, hero image of the class, if
        /// present, will be displayed. If hero image of the class is also not present, nothing will be displayed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heroImage")]
        public virtual Image HeroImage { get; set; }

        /// <summary>
        /// Required. The unique identifier for an object. This ID must be unique across all objects from an issuer.
        /// This value should follow the format issuer ID.identifier where the former is issued by Google and latter is
        /// chosen by you. The unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Image module data. The maximum number of these fields displayed is 1 from object level and 1 for class
        /// object level.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageModulesData")]
        public virtual System.Collections.Generic.IList<ImageModuleData> ImageModulesData { get; set; }

        /// <summary>Deprecated. Use textModulesData instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infoModuleData")]
        public virtual InfoModuleData InfoModuleData { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string `"walletobjects#giftCardObject"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// linked_object_ids are a list of other objects such as event ticket, loyalty, offer, generic, giftcard,
        /// transit and boarding pass that should be automatically attached to this giftcard object. If a user had saved
        /// this gift card, then these linked_object_ids would be automatically pushed to the user's wallet (unless they
        /// turned off the setting to receive such linked passes). Make sure that objects present in linked_object_ids
        /// are already inserted - if not, calls would fail. Once linked, the linked objects cannot be unlinked. You
        /// cannot link objects belonging to another issuer. There is a limit to the number of objects that can be
        /// linked to a single object. After the limit is reached, new linked objects in the call will be ignored
        /// silently. Object IDs should follow the format issuer ID. identifier where the former is issued by Google and
        /// the latter is chosen by you.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkedObjectIds")]
        public virtual System.Collections.Generic.IList<string> LinkedObjectIds { get; set; }

        /// <summary>
        /// Links module data. If links module data is also defined on the class, both will be displayed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linksModuleData")]
        public virtual LinksModuleData LinksModuleData { get; set; }

        /// <summary>Note: This field is currently not supported to trigger geo notifications.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<LatLongPoint> Locations { get; set; }

        /// <summary>
        /// Merchant locations. There is a maximum of ten on the object. Any additional MerchantLocations added beyond
        /// the 10 will be rejected. These locations will trigger a notification when a user enters within a Google-set
        /// radius of the point. This field replaces the deprecated LatLongPoints.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantLocations")]
        public virtual System.Collections.Generic.IList<MerchantLocation> MerchantLocations { get; set; }

        /// <summary>
        /// An array of messages displayed in the app. All users of this object will receive its associated messages.
        /// The maximum number of these fields is 10.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<Message> Messages { get; set; }

        /// <summary>
        /// Whether or not field updates to this object should trigger notifications. When set to NOTIFY, we will
        /// attempt to trigger a field update notification to users. These notifications will only be sent to users if
        /// the field is part of an allowlist. If set to DO_NOT_NOTIFY or NOTIFICATION_SETTINGS_UNSPECIFIED, no
        /// notification will be triggered. This setting is ephemeral and needs to be set with each PATCH or UPDATE
        /// request, otherwise a notification will not be triggered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notifyPreference")]
        public virtual string NotifyPreference { get; set; }

        /// <summary>Pass constraints for the object. Includes limiting NFC and screenshot behaviors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passConstraints")]
        public virtual PassConstraints PassConstraints { get; set; }

        /// <summary>The card's PIN.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pin")]
        public virtual string Pin { get; set; }

        /// <summary>The rotating barcode type and value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rotatingBarcode")]
        public virtual RotatingBarcode RotatingBarcode { get; set; }

        /// <summary>
        /// Restrictions on the object that needs to be verified before the user tries to save the pass. Note that this
        /// restrictions will only be applied during save time. If the restrictions changed after a user saves the pass,
        /// the new restrictions will not be applied to an already saved pass.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("saveRestrictions")]
        public virtual SaveRestrictions SaveRestrictions { get; set; }

        /// <summary>
        /// The value that will be transmitted to a Smart Tap certified terminal over NFC for this object. The class
        /// level fields `enableSmartTap` and `redemptionIssuers` must also be set up correctly in order for the pass to
        /// support Smart Tap. Only ASCII characters are supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("smartTapRedemptionValue")]
        public virtual string SmartTapRedemptionValue { get; set; }

        /// <summary>
        /// Required. The state of the object. This field is used to determine how an object is displayed in the app.
        /// For example, an `inactive` object is moved to the "Expired passes" section.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Text module data. If text module data is also defined on the class, both will be displayed. The maximum
        /// number of these fields displayed is 10 from the object and 10 from the class.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textModulesData")]
        public virtual System.Collections.Generic.IList<TextModuleData> TextModulesData { get; set; }

        /// <summary>
        /// The time period this object will be `active` and object can be used. An object's state will be changed to
        /// `expired` when this time period has passed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validTimeInterval")]
        public virtual TimeInterval ValidTimeInterval { get; set; }

        /// <summary>Optional value added module data. Maximum of ten on the object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueAddedModuleData")]
        public virtual System.Collections.Generic.IList<ValueAddedModuleData> ValueAddedModuleData { get; set; }

        /// <summary>Deprecated</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<long> Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GiftCardObjectAddMessageResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The updated GiftCardObject resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual GiftCardObject Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GiftCardObjectListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Pagination of the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pagination")]
        public virtual Pagination Pagination { get; set; }

        /// <summary>Resources corresponding to the list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<GiftCardObject> Resources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GroupingInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional grouping ID for grouping the passes with the same ID visually together. Grouping with different
        /// types of passes is allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupingId")]
        public virtual string GroupingId { get; set; }

        /// <summary>
        /// Optional index for sorting the passes when they are grouped with other passes. Passes with lower sort index
        /// are shown before passes with higher sort index. If unspecified, the value is assumed to be INT_MAX. For two
        /// passes with the same sort index, the sorting behavior is undefined.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sortIndex")]
        public virtual System.Nullable<int> SortIndex { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Wrapping type for Google hosted images. Next ID: 7</summary>
    public class Image : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description of the image used for accessibility.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentDescription")]
        public virtual LocalizedString ContentDescription { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string `"walletobjects#image"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The URI for the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceUri")]
        public virtual ImageUri SourceUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ImageModuleData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The ID associated with an image module. This field is here to enable ease of management of image modules.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>A 100% width image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mainImage")]
        public virtual Image MainImage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ImageUri : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Additional information about the image, which is unused and retained only for backward compatibility.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Translated strings for the description, which are unused and retained only for backward compatibility.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedDescription")]
        public virtual LocalizedString LocalizedDescription { get; set; }

        /// <summary>The location of the image. URIs must have a scheme.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class InfoModuleData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of collections of labels and values. These will be displayed one after the other in a singular
        /// column.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelValueRows")]
        public virtual System.Collections.Generic.IList<LabelValueRow> LabelValueRows { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("showLastUpdateTime")]
        public virtual System.Nullable<bool> ShowLastUpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Issuer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Allows the issuer to provide their callback settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callbackOptions")]
        public virtual CallbackOptions CallbackOptions { get; set; }

        /// <summary>Issuer contact information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactInfo")]
        public virtual IssuerContactInfo ContactInfo { get; set; }

        /// <summary>URL for the issuer's home page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("homepageUrl")]
        public virtual string HomepageUrl { get; set; }

        /// <summary>
        /// The unique identifier for an issuer account. This is automatically generated when the issuer is inserted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issuerId")]
        public virtual System.Nullable<long> IssuerId { get; set; }

        /// <summary>The account name of the issuer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Available only to Smart Tap enabled partners. Contact support for additional guidance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("smartTapMerchantData")]
        public virtual SmartTapMerchantData SmartTapMerchantData { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class IssuerContactInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Email addresses which will receive alerts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alertsEmails")]
        public virtual System.Collections.Generic.IList<string> AlertsEmails { get; set; }

        /// <summary>The primary contact email address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>The primary contact name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The primary contact phone number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phone")]
        public virtual string Phone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class IssuerListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resources corresponding to the list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<Issuer> Resources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class IssuerToUserInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("signUpInfo")]
        public virtual SignUpInfo SignUpInfo { get; set; }

        /// <summary>Currently not used, consider deprecating.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>JSON web token for action S2AP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class JwtInsertResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Data that corresponds to the ids of the provided classes and objects in the JWT. resources will only include
        /// the non-empty arrays (i.e. if the JWT only includes eventTicketObjects, then that is the only field that
        /// will be present in resources).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual Resources Resources { get; set; }

        /// <summary>
        /// A URI that, when opened, will allow the end user to save the object(s) identified in the JWT to their Google
        /// account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("saveUri")]
        public virtual string SaveUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class JwtResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A string representing a JWT of the format described at
        /// https://developers.google.com/wallet/reference/rest/v1/Jwt
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jwt")]
        public virtual string Jwt { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A pair of text strings to be displayed in the details view. Note we no longer display LabelValue/LabelValueRow
    /// as a table, instead a list of items.
    /// </summary>
    public class LabelValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The label for a specific row and column. Recommended maximum is 15 characters for a two-column layout and 30
        /// characters for a one-column layout.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>
        /// Translated strings for the label. Recommended maximum is 15 characters for a two-column layout and 30
        /// characters for a one-column layout.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedLabel")]
        public virtual LocalizedString LocalizedLabel { get; set; }

        /// <summary>
        /// Translated strings for the value. Recommended maximum is 15 characters for a two-column layout and 30
        /// characters for a one-column layout.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedValue")]
        public virtual LocalizedString LocalizedValue { get; set; }

        /// <summary>
        /// The value for a specific row and column. Recommended maximum is 15 characters for a two-column layout and 30
        /// characters for a one-column layout.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class LabelValueRow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of labels and values. These will be displayed in a singular column, one after the other, not in
        /// multiple columns, despite the field name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columns")]
        public virtual System.Collections.Generic.IList<LabelValue> Columns { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class LatLongPoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string `"walletobjects#latLongPoint"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The latitude specified as any value in the range of -90.0 through +90.0, both inclusive. Values outside
        /// these bounds will be rejected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latitude")]
        public virtual System.Nullable<double> Latitude { get; set; }

        /// <summary>
        /// The longitude specified in the range -180.0 through +180.0, both inclusive. Values outside these bounds will
        /// be rejected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longitude")]
        public virtual System.Nullable<double> Longitude { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class LinksModuleData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of URIs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uris")]
        public virtual System.Collections.Generic.IList<Uri> Uris { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListTemplateOverride : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies from a predefined set of options or from a reference to the field what will be displayed in the
        /// first row. To set this override, set the FirstRowOption.fieldOption to the FieldSelector of your choice.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstRowOption")]
        public virtual FirstRowOption FirstRowOption { get; set; }

        /// <summary>
        /// A reference to the field to be displayed in the second row. This option is only displayed if there are not
        /// multiple user objects in a group. If there is a group, the second row will always display a field shared by
        /// all objects. To set this override, please set secondRowOption to the FieldSelector of you choice.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondRowOption")]
        public virtual FieldSelector SecondRowOption { get; set; }

        /// <summary>An unused/deprecated field. Setting it will have no effect on what the user sees.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thirdRowOption")]
        public virtual FieldSelector ThirdRowOption { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class LocalizedString : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Contains the string to be displayed if no appropriate translation is available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultValue")]
        public virtual TranslatedString DefaultValue { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string `"walletobjects#localizedString"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Contains the translations for the string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("translatedValues")]
        public virtual System.Collections.Generic.IList<TranslatedString> TranslatedValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class LoyaltyClass : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The account ID label, such as "Member ID." Recommended maximum length is 15 characters to ensure full string
        /// is displayed on smaller screens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountIdLabel")]
        public virtual string AccountIdLabel { get; set; }

        /// <summary>
        /// The account name label, such as "Member Name." Recommended maximum length is 15 characters to ensure full
        /// string is displayed on smaller screens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountNameLabel")]
        public virtual string AccountNameLabel { get; set; }

        /// <summary>Deprecated. Use `multipleDevicesAndHoldersAllowedStatus` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowMultipleUsersPerObject")]
        public virtual System.Nullable<bool> AllowMultipleUsersPerObject { get; set; }

        /// <summary>
        /// Optional app or website link that will be displayed as a button on the front of the pass. If AppLinkData is
        /// provided for the corresponding object that will be used instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appLinkData")]
        public virtual AppLinkData AppLinkData { get; set; }

        /// <summary>
        /// Callback options to be used to call the issuer back for every save/delete of an object for this class by the
        /// end-user. All objects of this class are eligible for the callback.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callbackOptions")]
        public virtual CallbackOptions CallbackOptions { get; set; }

        /// <summary>
        /// Template information about how the class should be displayed. If unset, Google will fallback to a default
        /// set of fields to display.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classTemplateInfo")]
        public virtual ClassTemplateInfo ClassTemplateInfo { get; set; }

        /// <summary>
        /// Country code used to display the card's country (when the user is not in that country), as well as to
        /// display localized content when content is not available in the user's locale.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countryCode")]
        public virtual string CountryCode { get; set; }

        /// <summary>
        /// Information about how the class may be discovered and instantiated from within the Google Pay app.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discoverableProgram")]
        public virtual DiscoverableProgram DiscoverableProgram { get; set; }

        /// <summary>
        /// Identifies whether this class supports Smart Tap. The `redemptionIssuers` and one of object level
        /// `smartTapRedemptionLevel`, barcode.value`, or `accountId` fields must also be set up correctly in order for
        /// a pass to support Smart Tap.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableSmartTap")]
        public virtual System.Nullable<bool> EnableSmartTap { get; set; }

        /// <summary>
        /// Optional banner image displayed on the front of the card. If none is present, nothing will be displayed. The
        /// image will display at 100% width.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heroImage")]
        public virtual Image HeroImage { get; set; }

        /// <summary>
        /// The background color for the card. If not set the dominant color of the hero image is used, and if no hero
        /// image is set, the dominant color of the logo is used. The format is #rrggbb where rrggbb is a hex RGB
        /// triplet, such as `#ffcc00`. You can also use the shorthand version of the RGB triplet which is #rgb, such as
        /// `#fc0`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hexBackgroundColor")]
        public virtual string HexBackgroundColor { get; set; }

        /// <summary>
        /// The URI of your application's home page. Populating the URI in this field results in the exact same behavior
        /// as populating an URI in linksModuleData (when an object is rendered, a link to the homepage is shown in what
        /// would usually be thought of as the linksModuleData section of the object).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("homepageUri")]
        public virtual Uri HomepageUri { get; set; }

        /// <summary>
        /// Required. The unique identifier for a class. This ID must be unique across all classes from an issuer. This
        /// value should follow the format issuer ID. identifier where the former is issued by Google and latter is
        /// chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Image module data. The maximum number of these fields displayed is 1 from object level and 1 for class
        /// object level.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageModulesData")]
        public virtual System.Collections.Generic.IList<ImageModuleData> ImageModulesData { get; set; }

        /// <summary>Deprecated. Use textModulesData instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infoModuleData")]
        public virtual InfoModuleData InfoModuleData { get; set; }

        /// <summary>
        /// Required. The issuer name. Recommended maximum length is 20 characters to ensure full string is displayed on
        /// smaller screens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issuerName")]
        public virtual string IssuerName { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string `"walletobjects#loyaltyClass"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Links module data. If links module data is also defined on the object, both will be displayed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linksModuleData")]
        public virtual LinksModuleData LinksModuleData { get; set; }

        /// <summary>
        /// Translated strings for the account_id_label. Recommended maximum length is 15 characters to ensure full
        /// string is displayed on smaller screens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedAccountIdLabel")]
        public virtual LocalizedString LocalizedAccountIdLabel { get; set; }

        /// <summary>
        /// Translated strings for the account_name_label. Recommended maximum length is 15 characters to ensure full
        /// string is displayed on smaller screens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedAccountNameLabel")]
        public virtual LocalizedString LocalizedAccountNameLabel { get; set; }

        /// <summary>
        /// Translated strings for the issuer_name. Recommended maximum length is 20 characters to ensure full string is
        /// displayed on smaller screens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedIssuerName")]
        public virtual LocalizedString LocalizedIssuerName { get; set; }

        /// <summary>
        /// Translated strings for the program_name. The app may display an ellipsis after the first 20 characters to
        /// ensure full string is displayed on smaller screens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedProgramName")]
        public virtual LocalizedString LocalizedProgramName { get; set; }

        /// <summary>
        /// Translated strings for the rewards_tier. Recommended maximum length is 7 characters to ensure full string is
        /// displayed on smaller screens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedRewardsTier")]
        public virtual LocalizedString LocalizedRewardsTier { get; set; }

        /// <summary>
        /// Translated strings for the rewards_tier_label. Recommended maximum length is 9 characters to ensure full
        /// string is displayed on smaller screens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedRewardsTierLabel")]
        public virtual LocalizedString LocalizedRewardsTierLabel { get; set; }

        /// <summary>Translated strings for the secondary_rewards_tier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedSecondaryRewardsTier")]
        public virtual LocalizedString LocalizedSecondaryRewardsTier { get; set; }

        /// <summary>Translated strings for the secondary_rewards_tier_label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedSecondaryRewardsTierLabel")]
        public virtual LocalizedString LocalizedSecondaryRewardsTierLabel { get; set; }

        /// <summary>Note: This field is currently not supported to trigger geo notifications.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<LatLongPoint> Locations { get; set; }

        /// <summary>
        /// Merchant locations. There is a maximum of ten on the class. Any additional MerchantLocations added beyond
        /// the 10 will be rejected. These locations will trigger a notification when a user enters within a Google-set
        /// radius of the point. This field replaces the deprecated LatLongPoints.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantLocations")]
        public virtual System.Collections.Generic.IList<MerchantLocation> MerchantLocations { get; set; }

        /// <summary>
        /// An array of messages displayed in the app. All users of this object will receive its associated messages.
        /// The maximum number of these fields is 10.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<Message> Messages { get; set; }

        /// <summary>
        /// Identifies whether multiple users and devices will save the same object referencing this class.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multipleDevicesAndHoldersAllowedStatus")]
        public virtual string MultipleDevicesAndHoldersAllowedStatus { get; set; }

        /// <summary>
        /// Whether or not field updates to this class should trigger notifications. When set to NOTIFY, we will attempt
        /// to trigger a field update notification to users. These notifications will only be sent to users if the field
        /// is part of an allowlist. If not specified, no notification will be triggered. This setting is ephemeral and
        /// needs to be set with each PATCH or UPDATE request, otherwise a notification will not be triggered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notifyPreference")]
        public virtual string NotifyPreference { get; set; }

        /// <summary>
        /// Required. The logo of the loyalty program or company. This logo is displayed in both the details and list
        /// views of the app.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("programLogo")]
        public virtual Image ProgramLogo { get; set; }

        /// <summary>
        /// Required. The program name, such as "Adam's Apparel". The app may display an ellipsis after the first 20
        /// characters to ensure full string is displayed on smaller screens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("programName")]
        public virtual string ProgramName { get; set; }

        /// <summary>
        /// Identifies which redemption issuers can redeem the pass over Smart Tap. Redemption issuers are identified by
        /// their issuer ID. Redemption issuers must have at least one Smart Tap key configured. The `enableSmartTap`
        /// and one of object level `smartTapRedemptionValue`, barcode.value`, or `accountId` fields must also be set up
        /// correctly in order for a pass to support Smart Tap.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redemptionIssuers")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> RedemptionIssuers { get; set; }

        /// <summary>The review comments set by the platform when a class is marked `approved` or `rejected`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("review")]
        public virtual Review Review { get; set; }

        /// <summary>
        /// Required. The status of the class. This field can be set to `draft` or `underReview` using the insert,
        /// patch, or update API calls. Once the review state is changed from `draft` it may not be changed back to
        /// `draft`. You should keep this field to `draft` when the class is under development. A `draft` class cannot
        /// be used to create any object. You should set this field to `underReview` when you believe the class is ready
        /// for use. The platform will automatically set this field to `approved` and it can be immediately used to
        /// create or migrate objects. When updating an already `approved` class you should keep setting this field to
        /// `underReview`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reviewStatus")]
        public virtual string ReviewStatus { get; set; }

        /// <summary>
        /// The rewards tier, such as "Gold" or "Platinum." Recommended maximum length is 7 characters to ensure full
        /// string is displayed on smaller screens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rewardsTier")]
        public virtual string RewardsTier { get; set; }

        /// <summary>
        /// The rewards tier label, such as "Rewards Tier." Recommended maximum length is 9 characters to ensure full
        /// string is displayed on smaller screens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rewardsTierLabel")]
        public virtual string RewardsTierLabel { get; set; }

        /// <summary>The secondary rewards tier, such as "Gold" or "Platinum."</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondaryRewardsTier")]
        public virtual string SecondaryRewardsTier { get; set; }

        /// <summary>The secondary rewards tier label, such as "Rewards Tier."</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondaryRewardsTierLabel")]
        public virtual string SecondaryRewardsTierLabel { get; set; }

        /// <summary>
        /// Optional information about the security animation. If this is set a security animation will be rendered on
        /// pass details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityAnimation")]
        public virtual SecurityAnimation SecurityAnimation { get; set; }

        /// <summary>
        /// Text module data. If text module data is also defined on the class, both will be displayed. The maximum
        /// number of these fields displayed is 10 from the object and 10 from the class.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textModulesData")]
        public virtual System.Collections.Generic.IList<TextModuleData> TextModulesData { get; set; }

        /// <summary>
        /// Optional value added module data. Maximum of ten on the class. For a pass only ten will be displayed,
        /// prioritizing those from the object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueAddedModuleData")]
        public virtual System.Collections.Generic.IList<ValueAddedModuleData> ValueAddedModuleData { get; set; }

        /// <summary>Deprecated</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<long> Version { get; set; }

        /// <summary>View Unlock Requirement options for the loyalty card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewUnlockRequirement")]
        public virtual string ViewUnlockRequirement { get; set; }

        /// <summary>
        /// The wide logo of the loyalty program or company. When provided, this will be used in place of the program
        /// logo in the top left of the card view.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wideProgramLogo")]
        public virtual Image WideProgramLogo { get; set; }

        /// <summary>Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wordMark")]
        public virtual Image WordMark { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class LoyaltyClassAddMessageResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The updated LoyaltyClass resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual LoyaltyClass Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class LoyaltyClassListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Pagination of the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pagination")]
        public virtual Pagination Pagination { get; set; }

        /// <summary>Resources corresponding to the list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<LoyaltyClass> Resources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class LoyaltyObject : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The loyalty account identifier. Recommended maximum length is 20 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        /// <summary>
        /// The loyalty account holder name, such as "John Smith." Recommended maximum length is 20 characters to ensure
        /// full string is displayed on smaller screens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountName")]
        public virtual string AccountName { get; set; }

        /// <summary>
        /// Optional app or website link that will be displayed as a button on the front of the pass. If AppLinkData is
        /// provided for the corresponding class only object AppLinkData will be displayed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appLinkData")]
        public virtual AppLinkData AppLinkData { get; set; }

        /// <summary>The barcode type and value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("barcode")]
        public virtual Barcode Barcode { get; set; }

        /// <summary>
        /// Required. The class associated with this object. The class must be of the same type as this object, must
        /// already exist, and must be approved. Class IDs should follow the format issuer ID.identifier where the
        /// former is issued by Google and latter is chosen by you.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classId")]
        public virtual string ClassId { get; set; }

        /// <summary>
        /// A copy of the inherited fields of the parent class. These fields are retrieved during a GET.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classReference")]
        public virtual LoyaltyClass ClassReference { get; set; }

        /// <summary>
        /// Indicates if notifications should explicitly be suppressed. If this field is set to true, regardless of the
        /// `messages` field, expiration notifications to the user will be suppressed. By default, this field is set to
        /// false. Currently, this can only be set for offers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableExpirationNotification")]
        public virtual System.Nullable<bool> DisableExpirationNotification { get; set; }

        /// <summary>Information that controls how passes are grouped together.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupingInfo")]
        public virtual GroupingInfo GroupingInfo { get; set; }

        /// <summary>
        /// Whether this object is currently linked to a single device. This field is set by the platform when a user
        /// saves the object, linking it to their device. Intended for use by select partners. Contact support for
        /// additional information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasLinkedDevice")]
        public virtual System.Nullable<bool> HasLinkedDevice { get; set; }

        /// <summary>Indicates if the object has users. This field is set by the platform.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasUsers")]
        public virtual System.Nullable<bool> HasUsers { get; set; }

        /// <summary>
        /// Optional banner image displayed on the front of the card. If none is present, hero image of the class, if
        /// present, will be displayed. If hero image of the class is also not present, nothing will be displayed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heroImage")]
        public virtual Image HeroImage { get; set; }

        /// <summary>
        /// Required. The unique identifier for an object. This ID must be unique across all objects from an issuer.
        /// This value should follow the format issuer ID.identifier where the former is issued by Google and latter is
        /// chosen by you. The unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Image module data. The maximum number of these fields displayed is 1 from object level and 1 for class
        /// object level.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageModulesData")]
        public virtual System.Collections.Generic.IList<ImageModuleData> ImageModulesData { get; set; }

        /// <summary>Deprecated. Use textModulesData instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infoModuleData")]
        public virtual InfoModuleData InfoModuleData { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string `"walletobjects#loyaltyObject"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// linked_object_ids are a list of other objects such as event ticket, loyalty, offer, generic, giftcard,
        /// transit and boarding pass that should be automatically attached to this loyalty object. If a user had saved
        /// this loyalty card, then these linked_object_ids would be automatically pushed to the user's wallet (unless
        /// they turned off the setting to receive such linked passes). Make sure that objects present in
        /// linked_object_ids are already inserted - if not, calls would fail. Once linked, the linked objects cannot be
        /// unlinked. You cannot link objects belonging to another issuer. There is a limit to the number of objects
        /// that can be linked to a single object. After the limit is reached, new linked objects in the call will be
        /// ignored silently. Object IDs should follow the format issuer ID. identifier where the former is issued by
        /// Google and the latter is chosen by you.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkedObjectIds")]
        public virtual System.Collections.Generic.IList<string> LinkedObjectIds { get; set; }

        /// <summary>
        /// A list of offer objects linked to this loyalty card. The offer objects must already exist. Offer object IDs
        /// should follow the format issuer ID. identifier where the former is issued by Google and latter is chosen by
        /// you.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkedOfferIds")]
        public virtual System.Collections.Generic.IList<string> LinkedOfferIds { get; set; }

        /// <summary>
        /// Links module data. If links module data is also defined on the class, both will be displayed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linksModuleData")]
        public virtual LinksModuleData LinksModuleData { get; set; }

        /// <summary>Note: This field is currently not supported to trigger geo notifications.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<LatLongPoint> Locations { get; set; }

        /// <summary>The loyalty reward points label, balance, and type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loyaltyPoints")]
        public virtual LoyaltyPoints LoyaltyPoints { get; set; }

        /// <summary>
        /// Merchant locations. There is a maximum of ten on the object. Any additional MerchantLocations added beyond
        /// the 10 will be rejected. These locations will trigger a notification when a user enters within a Google-set
        /// radius of the point. This field replaces the deprecated LatLongPoints.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantLocations")]
        public virtual System.Collections.Generic.IList<MerchantLocation> MerchantLocations { get; set; }

        /// <summary>
        /// An array of messages displayed in the app. All users of this object will receive its associated messages.
        /// The maximum number of these fields is 10.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<Message> Messages { get; set; }

        /// <summary>
        /// Whether or not field updates to this object should trigger notifications. When set to NOTIFY, we will
        /// attempt to trigger a field update notification to users. These notifications will only be sent to users if
        /// the field is part of an allowlist. If set to DO_NOT_NOTIFY or NOTIFICATION_SETTINGS_UNSPECIFIED, no
        /// notification will be triggered. This setting is ephemeral and needs to be set with each PATCH or UPDATE
        /// request, otherwise a notification will not be triggered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notifyPreference")]
        public virtual string NotifyPreference { get; set; }

        /// <summary>Pass constraints for the object. Includes limiting NFC and screenshot behaviors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passConstraints")]
        public virtual PassConstraints PassConstraints { get; set; }

        /// <summary>The rotating barcode type and value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rotatingBarcode")]
        public virtual RotatingBarcode RotatingBarcode { get; set; }

        /// <summary>
        /// Restrictions on the object that needs to be verified before the user tries to save the pass. Note that this
        /// restrictions will only be applied during save time. If the restrictions changed after a user saves the pass,
        /// the new restrictions will not be applied to an already saved pass.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("saveRestrictions")]
        public virtual SaveRestrictions SaveRestrictions { get; set; }

        /// <summary>
        /// The secondary loyalty reward points label, balance, and type. Shown in addition to the primary loyalty
        /// points.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondaryLoyaltyPoints")]
        public virtual LoyaltyPoints SecondaryLoyaltyPoints { get; set; }

        /// <summary>
        /// The value that will be transmitted to a Smart Tap certified terminal over NFC for this object. The class
        /// level fields `enableSmartTap` and `redemptionIssuers` must also be set up correctly in order for the pass to
        /// support Smart Tap. Only ASCII characters are supported. If this value is not set but the class level fields
        /// `enableSmartTap` and `redemptionIssuers` are set up correctly, the `barcode.value` or the `accountId` fields
        /// are used as fallback if present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("smartTapRedemptionValue")]
        public virtual string SmartTapRedemptionValue { get; set; }

        /// <summary>
        /// Required. The state of the object. This field is used to determine how an object is displayed in the app.
        /// For example, an `inactive` object is moved to the "Expired passes" section.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Text module data. If text module data is also defined on the class, both will be displayed. The maximum
        /// number of these fields displayed is 10 from the object and 10 from the class.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textModulesData")]
        public virtual System.Collections.Generic.IList<TextModuleData> TextModulesData { get; set; }

        /// <summary>
        /// The time period this object will be `active` and object can be used. An object's state will be changed to
        /// `expired` when this time period has passed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validTimeInterval")]
        public virtual TimeInterval ValidTimeInterval { get; set; }

        /// <summary>Optional value added module data. Maximum of ten on the object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueAddedModuleData")]
        public virtual System.Collections.Generic.IList<ValueAddedModuleData> ValueAddedModuleData { get; set; }

        /// <summary>Deprecated</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<long> Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class LoyaltyObjectAddMessageResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The updated LoyaltyObject resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual LoyaltyObject Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class LoyaltyObjectListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Pagination of the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pagination")]
        public virtual Pagination Pagination { get; set; }

        /// <summary>Resources corresponding to the list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<LoyaltyObject> Resources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class LoyaltyPoints : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The account holder's loyalty point balance, such as "500" or "$10.00". Recommended maximum length is 7
        /// characters. This is a required field of `loyaltyPoints` and `secondaryLoyaltyPoints`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("balance")]
        public virtual LoyaltyPointsBalance Balance { get; set; }

        /// <summary>The loyalty points label, such as "Points". Recommended maximum length is 9 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>Translated strings for the label. Recommended maximum length is 9 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedLabel")]
        public virtual LocalizedString LocalizedLabel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class LoyaltyPointsBalance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The double form of a balance. Only one of these subtypes (string, int, double, money) should be populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("double")]
        public virtual System.Nullable<double> Double__ { get; set; }

        /// <summary>
        /// The integer form of a balance. Only one of these subtypes (string, int, double, money) should be populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("int")]
        public virtual System.Nullable<int> Int__ { get; set; }

        /// <summary>
        /// The money form of a balance. Only one of these subtypes (string, int, double, money) should be populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("money")]
        public virtual Money Money { get; set; }

        /// <summary>
        /// The string form of a balance. Only one of these subtypes (string, int, double, money) should be populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("string")]
        public virtual string String__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A reference to data stored on the filesystem, on GFS or in blobstore.</summary>
    public class Media : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Deprecated, use one of explicit hash type fields instead. Algorithm used for calculating the hash. As of
        /// 2011/01/21, "MD5" is the only possible value for this field. New values may be added at any time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("algorithm")]
        public virtual string Algorithm { get; set; }

        /// <summary>Use object_id instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigstoreObjectRef")]
        public virtual string BigstoreObjectRef { get; set; }

        /// <summary>
        /// Blobstore v1 reference, set if reference_type is BLOBSTORE_REF This should be the byte representation of a
        /// blobstore.BlobRef. Since Blobstore is deprecating v1, use blobstore2_info instead. For now, any v2 blob will
        /// also be represented in this field as v1 BlobRef.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobRef")]
        public virtual string BlobRef { get; set; }

        /// <summary>Blobstore v2 info, set if reference_type is BLOBSTORE_REF and it refers to a v2 blob.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobstore2Info")]
        public virtual Blobstore2Info Blobstore2Info { get; set; }

        /// <summary>
        /// A composite media composed of one or more media objects, set if reference_type is COMPOSITE_MEDIA. The media
        /// length field must be set to the sum of the lengths of all composite media objects. Note: All composite media
        /// must have length specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compositeMedia")]
        public virtual System.Collections.Generic.IList<CompositeMedia> CompositeMedia { get; set; }

        /// <summary>MIME type of the data</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentType")]
        public virtual string ContentType { get; set; }

        /// <summary>Extended content type information provided for Scotty uploads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentTypeInfo")]
        public virtual ContentTypeInfo ContentTypeInfo { get; set; }

        /// <summary>
        /// A binary data reference for a media download. Serves as a technology-agnostic binary reference in some
        /// Google infrastructure. This value is a serialized storage_cosmo.BinaryReference proto. Storing it as bytes
        /// is a hack to get around the fact that the cosmo proto (as well as others it includes) doesn't support
        /// JavaScript. This prevents us from including the actual type of this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cosmoBinaryReference")]
        public virtual string CosmoBinaryReference { get; set; }

        /// <summary>
        /// For Scotty Uploads: Scotty-provided hashes for uploads For Scotty Downloads: (WARNING: DO NOT USE WITHOUT
        /// PERMISSION FROM THE SCOTTY TEAM.) A Hash provided by the agent to be used to verify the data being
        /// downloaded. Currently only supported for inline payloads. Further, only crc32c_hash is currently supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crc32cHash")]
        public virtual System.Nullable<long> Crc32cHash { get; set; }

        /// <summary>Set if reference_type is DIFF_CHECKSUMS_RESPONSE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diffChecksumsResponse")]
        public virtual DiffChecksumsResponse DiffChecksumsResponse { get; set; }

        /// <summary>Set if reference_type is DIFF_DOWNLOAD_RESPONSE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diffDownloadResponse")]
        public virtual DiffDownloadResponse DiffDownloadResponse { get; set; }

        /// <summary>Set if reference_type is DIFF_UPLOAD_REQUEST.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diffUploadRequest")]
        public virtual DiffUploadRequest DiffUploadRequest { get; set; }

        /// <summary>Set if reference_type is DIFF_UPLOAD_RESPONSE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diffUploadResponse")]
        public virtual DiffUploadResponse DiffUploadResponse { get; set; }

        /// <summary>Set if reference_type is DIFF_VERSION_RESPONSE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diffVersionResponse")]
        public virtual DiffVersionResponse DiffVersionResponse { get; set; }

        /// <summary>Parameters for a media download.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downloadParameters")]
        public virtual DownloadParameters DownloadParameters { get; set; }

        /// <summary>Original file name</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filename")]
        public virtual string Filename { get; set; }

        /// <summary>
        /// Deprecated, use one of explicit hash type fields instead. These two hash related fields will only be
        /// populated on Scotty based media uploads and will contain the content of the hash group in the
        /// NotificationRequest:
        /// http://cs/#google3/blobstore2/api/scotty/service/proto/upload_listener.proto&amp;amp;q=class:Hash Hex
        /// encoded hash value of the uploaded media.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hash")]
        public virtual string Hash { get; set; }

        /// <summary>
        /// For Scotty uploads only. If a user sends a hash code and the backend has requested that Scotty verify the
        /// upload against the client hash, Scotty will perform the check on behalf of the backend and will reject it if
        /// the hashes don't match. This is set to true if Scotty performed this verification.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hashVerified")]
        public virtual System.Nullable<bool> HashVerified { get; set; }

        /// <summary>Media data, set if reference_type is INLINE</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inline")]
        public virtual string Inline { get; set; }

        /// <summary>
        /// |is_potential_retry| is set false only when Scotty is certain that it has not sent the request before. When
        /// a client resumes an upload, this field must be set true in agent calls, because Scotty cannot be certain
        /// that it has never sent the request before due to potential failure in the session state persistence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isPotentialRetry")]
        public virtual System.Nullable<bool> IsPotentialRetry { get; set; }

        /// <summary>Size of the data, in bytes</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("length")]
        public virtual System.Nullable<long> Length { get; set; }

        /// <summary>Scotty-provided MD5 hash for an upload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("md5Hash")]
        public virtual string Md5Hash { get; set; }

        /// <summary>Media id to forward to the operation GetMedia. Can be set if reference_type is GET_MEDIA.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mediaId")]
        public virtual string MediaId { get; set; }

        /// <summary>Reference to a TI Blob, set if reference_type is BIGSTORE_REF.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual ObjectId ObjectId { get; set; }

        /// <summary>Path to the data, set if reference_type is PATH</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>Describes what the field reference contains.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referenceType")]
        public virtual string ReferenceType { get; set; }

        /// <summary>Scotty-provided SHA1 hash for an upload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha1Hash")]
        public virtual string Sha1Hash { get; set; }

        /// <summary>Scotty-provided SHA256 hash for an upload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha256Hash")]
        public virtual string Sha256Hash { get; set; }

        /// <summary>Time at which the media data was last updated, in milliseconds since UNIX epoch</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestamp")]
        public virtual System.Nullable<ulong> Timestamp { get; set; }

        /// <summary>A unique fingerprint/version id for the media data</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Extra information added to operations that support Scotty media requests.</summary>
    public class MediaRequestInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of current bytes uploaded or downloaded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentBytes")]
        public virtual System.Nullable<long> CurrentBytes { get; set; }

        /// <summary>
        /// Data to be copied to backend requests. Custom data is returned to Scotty in the agent_state field, which
        /// Scotty will then provide in subsequent upload notifications.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customData")]
        public virtual string CustomData { get; set; }

        /// <summary>
        /// Set if the http request info is diff encoded. The value of this field is the version number of the base
        /// revision. This is corresponding to Apiary's mediaDiffObjectVersion
        /// (//depot/google3/java/com/google/api/server/media/variable/DiffObjectVersionVariable.java). See
        /// go/esf-scotty-diff-upload for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diffObjectVersion")]
        public virtual string DiffObjectVersion { get; set; }

        /// <summary>
        /// The existence of the final_status field indicates that this is the last call to the agent for this
        /// request_id. http://google3/uploader/agent/scotty_agent.proto?l=737&amp;amp;rcl=347601929
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finalStatus")]
        public virtual System.Nullable<int> FinalStatus { get; set; }

        /// <summary>The type of notification received from Scotty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationType")]
        public virtual string NotificationType { get; set; }

        /// <summary>The Scotty request ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>
        /// The partition of the Scotty server handling this request. type is
        /// uploader_service.RequestReceivedParamsServingInfo
        /// LINT.IfChange(request_received_params_serving_info_annotations) LINT.ThenChange()
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestReceivedParamsServingInfo")]
        public virtual string RequestReceivedParamsServingInfo { get; set; }

        /// <summary>The total size of the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalBytes")]
        public virtual System.Nullable<long> TotalBytes { get; set; }

        /// <summary>Whether the total bytes field contains an estimated data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalBytesIsEstimated")]
        public virtual System.Nullable<bool> TotalBytesIsEstimated { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Locations of interest for this class or object. Currently, this location is used for geofenced notifications.
    /// When a user is within a set radius of this lat/long, and dwells there, Google will trigger a notification. When
    /// a user exits this radius, the notification will be hidden.
    /// </summary>
    public class MerchantLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The latitude specified as any value in the range of -90.0 through +90.0, both inclusive. Values outside
        /// these bounds will be rejected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latitude")]
        public virtual System.Nullable<double> Latitude { get; set; }

        /// <summary>
        /// The longitude specified in the range -180.0 through +180.0, both inclusive. Values outside these bounds will
        /// be rejected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longitude")]
        public virtual System.Nullable<double> Longitude { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message that will be displayed with a Valuable</summary>
    public class Message : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The message body.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("body")]
        public virtual string Body { get; set; }

        /// <summary>
        /// The period of time that the message will be displayed to users. You can define both a `startTime` and
        /// `endTime` for each message. A message is displayed immediately after a Wallet Object is inserted unless a
        /// `startTime` is set. The message will appear in a list of messages indefinitely if `endTime` is not provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayInterval")]
        public virtual TimeInterval DisplayInterval { get; set; }

        /// <summary>The message header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual string Header { get; set; }

        /// <summary>
        /// The ID associated with a message. This field is here to enable ease of management of messages. Notice ID
        /// values could possibly duplicate across multiple messages in the same class/instance, and care must be taken
        /// to select a reasonable ID for each message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string `"walletobjects#walletObjectMessage"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Translated strings for the message body.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedBody")]
        public virtual LocalizedString LocalizedBody { get; set; }

        /// <summary>Translated strings for the message header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedHeader")]
        public virtual LocalizedString LocalizedHeader { get; set; }

        /// <summary>The message type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageType")]
        public virtual string MessageType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ModifyLinkedOfferObjects : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The linked offer object ids to add to the object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addLinkedOfferObjectIds")]
        public virtual System.Collections.Generic.IList<string> AddLinkedOfferObjectIds { get; set; }

        /// <summary>The linked offer object ids to remove from the object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("removeLinkedOfferObjectIds")]
        public virtual System.Collections.Generic.IList<string> RemoveLinkedOfferObjectIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ModifyLinkedOfferObjectsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The linked offer object ids to add or remove from the object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkedOfferObjectIds")]
        public virtual ModifyLinkedOfferObjects LinkedOfferObjectIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Constraints that all must be met for the module to be shown.</summary>
    public class ModuleViewConstraints : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The period of time that the module will be displayed to users. Can define both a `startTime` and `endTime`.
        /// The module is displayed immediately after insertion unless a `startTime` is set. The module is displayed
        /// indefinitely if `endTime` is not set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayInterval")]
        public virtual TimeInterval DisplayInterval { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Money : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The currency code, such as "USD" or "EUR."</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string `"walletobjects#money"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The unit of money amount in micros. For example, $1 USD would be represented as 1000000 micros.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("micros")]
        public virtual System.Nullable<long> Micros { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Indicates if the object needs to have notification enabled. We support only one of
    /// ExpiryNotification/UpcomingNotification. `expiryNotification` takes precedence over `upcomingNotification`. In
    /// other words if `expiryNotification` is set, we ignore the `upcomingNotification` field.
    /// </summary>
    public class Notifications : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A notification would be triggered at a specific time before the card expires.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expiryNotification")]
        public virtual ExpiryNotification ExpiryNotification { get; set; }

        /// <summary>A notification would be triggered at a specific time before the card becomes usable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upcomingNotification")]
        public virtual UpcomingNotification UpcomingNotification { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This is a copy of the tech.blob.ObjectId proto, which could not be used directly here due to transitive closure
    /// issues with JavaScript support; see http://b/8801763.
    /// </summary>
    public class ObjectId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the bucket to which this object belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketName")]
        public virtual string BucketName { get; set; }

        /// <summary>
        /// Generation of the object. Generations are monotonically increasing across writes, allowing them to be be
        /// compared to determine which generation is newer. If this is omitted in a request, then you are requesting
        /// the live object. See http://go/bigstore-versions
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generation")]
        public virtual System.Nullable<long> Generation { get; set; }

        /// <summary>The name of the object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectName")]
        public virtual string ObjectName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class OfferClass : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Deprecated. Use `multipleDevicesAndHoldersAllowedStatus` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowMultipleUsersPerObject")]
        public virtual System.Nullable<bool> AllowMultipleUsersPerObject { get; set; }

        /// <summary>
        /// Optional app or website link that will be displayed as a button on the front of the pass. If AppLinkData is
        /// provided for the corresponding object that will be used instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appLinkData")]
        public virtual AppLinkData AppLinkData { get; set; }

        /// <summary>
        /// Callback options to be used to call the issuer back for every save/delete of an object for this class by the
        /// end-user. All objects of this class are eligible for the callback.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callbackOptions")]
        public virtual CallbackOptions CallbackOptions { get; set; }

        /// <summary>
        /// Template information about how the class should be displayed. If unset, Google will fallback to a default
        /// set of fields to display.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classTemplateInfo")]
        public virtual ClassTemplateInfo ClassTemplateInfo { get; set; }

        /// <summary>
        /// Country code used to display the card's country (when the user is not in that country), as well as to
        /// display localized content when content is not available in the user's locale.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countryCode")]
        public virtual string CountryCode { get; set; }

        /// <summary>The details of the offer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual string Details { get; set; }

        /// <summary>
        /// Identifies whether this class supports Smart Tap. The `redemptionIssuers` and object level
        /// `smartTapRedemptionLevel` fields must also be set up correctly in order for a pass to support Smart Tap.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableSmartTap")]
        public virtual System.Nullable<bool> EnableSmartTap { get; set; }

        /// <summary>The fine print or terms of the offer, such as "20% off any t-shirt at Adam's Apparel."</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finePrint")]
        public virtual string FinePrint { get; set; }

        /// <summary>The help link for the offer, such as `http://myownpersonaldomain.com/help`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("helpUri")]
        public virtual Uri HelpUri { get; set; }

        /// <summary>
        /// Optional banner image displayed on the front of the card. If none is present, nothing will be displayed. The
        /// image will display at 100% width.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heroImage")]
        public virtual Image HeroImage { get; set; }

        /// <summary>
        /// The background color for the card. If not set the dominant color of the hero image is used, and if no hero
        /// image is set, the dominant color of the logo is used. The format is #rrggbb where rrggbb is a hex RGB
        /// triplet, such as `#ffcc00`. You can also use the shorthand version of the RGB triplet which is #rgb, such as
        /// `#fc0`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hexBackgroundColor")]
        public virtual string HexBackgroundColor { get; set; }

        /// <summary>
        /// The URI of your application's home page. Populating the URI in this field results in the exact same behavior
        /// as populating an URI in linksModuleData (when an object is rendered, a link to the homepage is shown in what
        /// would usually be thought of as the linksModuleData section of the object).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("homepageUri")]
        public virtual Uri HomepageUri { get; set; }

        /// <summary>
        /// Required. The unique identifier for a class. This ID must be unique across all classes from an issuer. This
        /// value should follow the format issuer ID. identifier where the former is issued by Google and latter is
        /// chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Image module data. The maximum number of these fields displayed is 1 from object level and 1 for class
        /// object level.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageModulesData")]
        public virtual System.Collections.Generic.IList<ImageModuleData> ImageModulesData { get; set; }

        /// <summary>Deprecated. Use textModulesData instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infoModuleData")]
        public virtual InfoModuleData InfoModuleData { get; set; }

        /// <summary>
        /// Required. The issuer name. Recommended maximum length is 20 characters to ensure full string is displayed on
        /// smaller screens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issuerName")]
        public virtual string IssuerName { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string `"walletobjects#offerClass"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Links module data. If links module data is also defined on the object, both will be displayed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linksModuleData")]
        public virtual LinksModuleData LinksModuleData { get; set; }

        /// <summary>Translated strings for the details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedDetails")]
        public virtual LocalizedString LocalizedDetails { get; set; }

        /// <summary>Translated strings for the fine_print.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedFinePrint")]
        public virtual LocalizedString LocalizedFinePrint { get; set; }

        /// <summary>
        /// Translated strings for the issuer_name. Recommended maximum length is 20 characters to ensure full string is
        /// displayed on smaller screens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedIssuerName")]
        public virtual LocalizedString LocalizedIssuerName { get; set; }

        /// <summary>
        /// Translated strings for the provider. Recommended maximum length is 12 characters to ensure full string is
        /// displayed on smaller screens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedProvider")]
        public virtual LocalizedString LocalizedProvider { get; set; }

        /// <summary>Translated strings for the short title. Recommended maximum length is 20 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedShortTitle")]
        public virtual LocalizedString LocalizedShortTitle { get; set; }

        /// <summary>
        /// Translated strings for the title. Recommended maximum length is 60 characters to ensure full string is
        /// displayed on smaller screens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedTitle")]
        public virtual LocalizedString LocalizedTitle { get; set; }

        /// <summary>Note: This field is currently not supported to trigger geo notifications.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<LatLongPoint> Locations { get; set; }

        /// <summary>
        /// Merchant locations. There is a maximum of ten on the class. Any additional MerchantLocations added beyond
        /// the 10 will be rejected. These locations will trigger a notification when a user enters within a Google-set
        /// radius of the point. This field replaces the deprecated LatLongPoints.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantLocations")]
        public virtual System.Collections.Generic.IList<MerchantLocation> MerchantLocations { get; set; }

        /// <summary>
        /// An array of messages displayed in the app. All users of this object will receive its associated messages.
        /// The maximum number of these fields is 10.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<Message> Messages { get; set; }

        /// <summary>
        /// Identifies whether multiple users and devices will save the same object referencing this class.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multipleDevicesAndHoldersAllowedStatus")]
        public virtual string MultipleDevicesAndHoldersAllowedStatus { get; set; }

        /// <summary>
        /// Whether or not field updates to this class should trigger notifications. When set to NOTIFY, we will attempt
        /// to trigger a field update notification to users. These notifications will only be sent to users if the field
        /// is part of an allowlist. If not specified, no notification will be triggered. This setting is ephemeral and
        /// needs to be set with each PATCH or UPDATE request, otherwise a notification will not be triggered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notifyPreference")]
        public virtual string NotifyPreference { get; set; }

        /// <summary>
        /// Required. The offer provider (either the aggregator name or merchant name). Recommended maximum length is 12
        /// characters to ensure full string is displayed on smaller screens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provider")]
        public virtual string Provider { get; set; }

        /// <summary>Required. The redemption channels applicable to this offer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redemptionChannel")]
        public virtual string RedemptionChannel { get; set; }

        /// <summary>
        /// Identifies which redemption issuers can redeem the pass over Smart Tap. Redemption issuers are identified by
        /// their issuer ID. Redemption issuers must have at least one Smart Tap key configured. The `enableSmartTap`
        /// and object level `smartTapRedemptionLevel` fields must also be set up correctly in order for a pass to
        /// support Smart Tap.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redemptionIssuers")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> RedemptionIssuers { get; set; }

        /// <summary>The review comments set by the platform when a class is marked `approved` or `rejected`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("review")]
        public virtual Review Review { get; set; }

        /// <summary>
        /// Required. The status of the class. This field can be set to `draft` or The status of the class. This field
        /// can be set to `draft` or `underReview` using the insert, patch, or update API calls. Once the review state
        /// is changed from `draft` it may not be changed back to `draft`. You should keep this field to `draft` when
        /// the class is under development. A `draft` class cannot be used to create any object. You should set this
        /// field to `underReview` when you believe the class is ready for use. The platform will automatically set this
        /// field to `approved` and it can be immediately used to create or migrate objects. When updating an already
        /// `approved` class you should keep setting this field to `underReview`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reviewStatus")]
        public virtual string ReviewStatus { get; set; }

        /// <summary>
        /// Optional information about the security animation. If this is set a security animation will be rendered on
        /// pass details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityAnimation")]
        public virtual SecurityAnimation SecurityAnimation { get; set; }

        /// <summary>
        /// A shortened version of the title of the offer, such as "20% off," shown to users as a quick reference to the
        /// offer contents. Recommended maximum length is 20 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortTitle")]
        public virtual string ShortTitle { get; set; }

        /// <summary>
        /// Text module data. If text module data is also defined on the class, both will be displayed. The maximum
        /// number of these fields displayed is 10 from the object and 10 from the class.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textModulesData")]
        public virtual System.Collections.Generic.IList<TextModuleData> TextModulesData { get; set; }

        /// <summary>
        /// Required. The title of the offer, such as "20% off any t-shirt." Recommended maximum length is 60 characters
        /// to ensure full string is displayed on smaller screens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>
        /// The title image of the offer. This image is displayed in both the details and list views of the app.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("titleImage")]
        public virtual Image TitleImage { get; set; }

        /// <summary>
        /// Optional value added module data. Maximum of ten on the class. For a pass only ten will be displayed,
        /// prioritizing those from the object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueAddedModuleData")]
        public virtual System.Collections.Generic.IList<ValueAddedModuleData> ValueAddedModuleData { get; set; }

        /// <summary>Deprecated</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<long> Version { get; set; }

        /// <summary>View Unlock Requirement options for the offer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewUnlockRequirement")]
        public virtual string ViewUnlockRequirement { get; set; }

        /// <summary>
        /// The wide title image of the offer. When provided, this will be used in place of the title image in the top
        /// left of the card view.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wideTitleImage")]
        public virtual Image WideTitleImage { get; set; }

        /// <summary>Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wordMark")]
        public virtual Image WordMark { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class OfferClassAddMessageResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The updated OfferClass resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual OfferClass Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class OfferClassListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Pagination of the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pagination")]
        public virtual Pagination Pagination { get; set; }

        /// <summary>Resources corresponding to the list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<OfferClass> Resources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class OfferObject : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional app or website link that will be displayed as a button on the front of the pass. If AppLinkData is
        /// provided for the corresponding class only object AppLinkData will be displayed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appLinkData")]
        public virtual AppLinkData AppLinkData { get; set; }

        /// <summary>The barcode type and value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("barcode")]
        public virtual Barcode Barcode { get; set; }

        /// <summary>
        /// Required. The class associated with this object. The class must be of the same type as this object, must
        /// already exist, and must be approved. Class IDs should follow the format issuer ID.identifier where the
        /// former is issued by Google and latter is chosen by you.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classId")]
        public virtual string ClassId { get; set; }

        /// <summary>
        /// A copy of the inherited fields of the parent class. These fields are retrieved during a GET.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classReference")]
        public virtual OfferClass ClassReference { get; set; }

        /// <summary>
        /// Indicates if notifications should explicitly be suppressed. If this field is set to true, regardless of the
        /// `messages` field, expiration notifications to the user will be suppressed. By default, this field is set to
        /// false. Currently, this can only be set for offers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableExpirationNotification")]
        public virtual System.Nullable<bool> DisableExpirationNotification { get; set; }

        /// <summary>Information that controls how passes are grouped together.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupingInfo")]
        public virtual GroupingInfo GroupingInfo { get; set; }

        /// <summary>
        /// Whether this object is currently linked to a single device. This field is set by the platform when a user
        /// saves the object, linking it to their device. Intended for use by select partners. Contact support for
        /// additional information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasLinkedDevice")]
        public virtual System.Nullable<bool> HasLinkedDevice { get; set; }

        /// <summary>Indicates if the object has users. This field is set by the platform.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasUsers")]
        public virtual System.Nullable<bool> HasUsers { get; set; }

        /// <summary>
        /// Optional banner image displayed on the front of the card. If none is present, hero image of the class, if
        /// present, will be displayed. If hero image of the class is also not present, nothing will be displayed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heroImage")]
        public virtual Image HeroImage { get; set; }

        /// <summary>
        /// Required. The unique identifier for an object. This ID must be unique across all objects from an issuer.
        /// This value should follow the format issuer ID.identifier where the former is issued by Google and latter is
        /// chosen by you. The unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Image module data. The maximum number of these fields displayed is 1 from object level and 1 for class
        /// object level.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageModulesData")]
        public virtual System.Collections.Generic.IList<ImageModuleData> ImageModulesData { get; set; }

        /// <summary>Deprecated. Use textModulesData instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infoModuleData")]
        public virtual InfoModuleData InfoModuleData { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string `"walletobjects#offerObject"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// linked_object_ids are a list of other objects such as event ticket, loyalty, offer, generic, giftcard,
        /// transit and boarding pass that should be automatically attached to this offer object. If a user had saved
        /// this offer, then these linked_object_ids would be automatically pushed to the user's wallet (unless they
        /// turned off the setting to receive such linked passes). Make sure that objects present in linked_object_ids
        /// are already inserted - if not, calls would fail. Once linked, the linked objects cannot be unlinked. You
        /// cannot link objects belonging to another issuer. There is a limit to the number of objects that can be
        /// linked to a single object. After the limit is reached, new linked objects in the call will be ignored
        /// silently. Object IDs should follow the format issuer ID.identifier where the former is issued by Google and
        /// the latter is chosen by you.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkedObjectIds")]
        public virtual System.Collections.Generic.IList<string> LinkedObjectIds { get; set; }

        /// <summary>
        /// Links module data. If links module data is also defined on the class, both will be displayed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linksModuleData")]
        public virtual LinksModuleData LinksModuleData { get; set; }

        /// <summary>Note: This field is currently not supported to trigger geo notifications.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<LatLongPoint> Locations { get; set; }

        /// <summary>
        /// Merchant locations. There is a maximum of ten on the object. Any additional MerchantLocations added beyond
        /// the 10 will be rejected. These locations will trigger a notification when a user enters within a Google-set
        /// radius of the point. This field replaces the deprecated LatLongPoints.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantLocations")]
        public virtual System.Collections.Generic.IList<MerchantLocation> MerchantLocations { get; set; }

        /// <summary>
        /// An array of messages displayed in the app. All users of this object will receive its associated messages.
        /// The maximum number of these fields is 10.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<Message> Messages { get; set; }

        /// <summary>
        /// Whether or not field updates to this object should trigger notifications. When set to NOTIFY, we will
        /// attempt to trigger a field update notification to users. These notifications will only be sent to users if
        /// the field is part of an allowlist. If set to DO_NOT_NOTIFY or NOTIFICATION_SETTINGS_UNSPECIFIED, no
        /// notification will be triggered. This setting is ephemeral and needs to be set with each PATCH or UPDATE
        /// request, otherwise a notification will not be triggered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notifyPreference")]
        public virtual string NotifyPreference { get; set; }

        /// <summary>Pass constraints for the object. Includes limiting NFC and screenshot behaviors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passConstraints")]
        public virtual PassConstraints PassConstraints { get; set; }

        /// <summary>The rotating barcode type and value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rotatingBarcode")]
        public virtual RotatingBarcode RotatingBarcode { get; set; }

        /// <summary>
        /// Restrictions on the object that needs to be verified before the user tries to save the pass. Note that this
        /// restrictions will only be applied during save time. If the restrictions changed after a user saves the pass,
        /// the new restrictions will not be applied to an already saved pass.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("saveRestrictions")]
        public virtual SaveRestrictions SaveRestrictions { get; set; }

        /// <summary>
        /// The value that will be transmitted to a Smart Tap certified terminal over NFC for this object. The class
        /// level fields `enableSmartTap` and `redemptionIssuers` must also be set up correctly in order for the pass to
        /// support Smart Tap. Only ASCII characters are supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("smartTapRedemptionValue")]
        public virtual string SmartTapRedemptionValue { get; set; }

        /// <summary>
        /// Required. The state of the object. This field is used to determine how an object is displayed in the app.
        /// For example, an `inactive` object is moved to the "Expired passes" section.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Text module data. If text module data is also defined on the class, both will be displayed. The maximum
        /// number of these fields displayed is 10 from the object and 10 from the class.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textModulesData")]
        public virtual System.Collections.Generic.IList<TextModuleData> TextModulesData { get; set; }

        /// <summary>
        /// The time period this object will be `active` and object can be used. An object's state will be changed to
        /// `expired` when this time period has passed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validTimeInterval")]
        public virtual TimeInterval ValidTimeInterval { get; set; }

        /// <summary>Optional value added module data. Maximum of ten on the object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueAddedModuleData")]
        public virtual System.Collections.Generic.IList<ValueAddedModuleData> ValueAddedModuleData { get; set; }

        /// <summary>Deprecated</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<long> Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class OfferObjectAddMessageResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The updated OfferObject resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual OfferObject Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class OfferObjectListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Pagination of the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pagination")]
        public virtual Pagination Pagination { get; set; }

        /// <summary>Resources corresponding to the list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<OfferObject> Resources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Pagination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string `"walletobjects#pagination"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Page token to send to fetch the next page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Number of results returned in this page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultsPerPage")]
        public virtual System.Nullable<int> ResultsPerPage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Container for any constraints that may be placed on passes.</summary>
    public class PassConstraints : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The NFC constraints for the pass.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nfcConstraint")]
        public virtual System.Collections.Generic.IList<string> NfcConstraint { get; set; }

        /// <summary>The screenshot eligibility for the pass.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenshotEligibility")]
        public virtual string ScreenshotEligibility { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Permission : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The email address of the user, group, or service account to which this permission refers to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailAddress")]
        public virtual string EmailAddress { get; set; }

        /// <summary>The role granted by this permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Permissions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ID of the issuer the list of permissions refer to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issuerId")]
        public virtual System.Nullable<long> IssuerId { get; set; }

        /// <summary>The complete list of permissions for the issuer account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<Permission> PermissionsValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PurchaseDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ID of the account used to purchase the ticket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        /// <summary>
        /// The confirmation code for the purchase. This may be the same for multiple different tickets and is used to
        /// group tickets together.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confirmationCode")]
        public virtual string ConfirmationCode { get; set; }

        /// <summary>
        /// The purchase date/time of the ticket. This is an ISO 8601 extended format date/time, with or without an
        /// offset. Time may be specified up to nanosecond precision. Offsets may be specified with seconds precision
        /// (even though offset seconds is not part of ISO 8601). For example: `1985-04-12T23:20:50.52Z` would be 20
        /// minutes and 50.52 seconds after the 23rd hour of April 12th, 1985 in UTC. `1985-04-12T19:20:50.52-04:00`
        /// would be 20 minutes and 50.52 seconds after the 19th hour of April 12th, 1985, 4 hours before UTC (same
        /// instant in time as the above example). If the event were in New York, this would be the equivalent of
        /// Eastern Daylight Time (EDT). Remember that offset varies in regions that observe Daylight Saving Time (or
        /// Summer Time), depending on the time of the year. `1985-04-12T19:20:50.52` would be 20 minutes and 50.52
        /// seconds after the 19th hour of April 12th, 1985 with no offset information. Without offset information, some
        /// rich features may not be available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purchaseDateTime")]
        public virtual string PurchaseDateTime { get; set; }

        /// <summary>
        /// Receipt number/identifier for tracking the ticket purchase via the body that sold the ticket.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purchaseReceiptNumber")]
        public virtual string PurchaseReceiptNumber { get; set; }

        /// <summary>The cost of the ticket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ticketCost")]
        public virtual TicketCost TicketCost { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ReservationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Confirmation code needed to check into this flight. This is the number that the passenger would enter into a
        /// kiosk at the airport to look up the flight and print a boarding pass.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confirmationCode")]
        public virtual string ConfirmationCode { get; set; }

        /// <summary>E-ticket number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eticketNumber")]
        public virtual string EticketNumber { get; set; }

        /// <summary>Frequent flyer membership information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frequentFlyerInfo")]
        public virtual FrequentFlyerInfo FrequentFlyerInfo { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string `"walletobjects#reservationInfo"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Resources : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of event ticket classes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTicketClasses")]
        public virtual System.Collections.Generic.IList<EventTicketClass> EventTicketClasses { get; set; }

        /// <summary>A list of event ticket objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTicketObjects")]
        public virtual System.Collections.Generic.IList<EventTicketObject> EventTicketObjects { get; set; }

        /// <summary>A list of flight classes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flightClasses")]
        public virtual System.Collections.Generic.IList<FlightClass> FlightClasses { get; set; }

        /// <summary>A list of flight objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flightObjects")]
        public virtual System.Collections.Generic.IList<FlightObject> FlightObjects { get; set; }

        /// <summary>A list of generic classes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("genericClasses")]
        public virtual System.Collections.Generic.IList<GenericClass> GenericClasses { get; set; }

        /// <summary>A list of generic objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("genericObjects")]
        public virtual System.Collections.Generic.IList<GenericObject> GenericObjects { get; set; }

        /// <summary>A list of gift card classes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("giftCardClasses")]
        public virtual System.Collections.Generic.IList<GiftCardClass> GiftCardClasses { get; set; }

        /// <summary>A list of gift card objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("giftCardObjects")]
        public virtual System.Collections.Generic.IList<GiftCardObject> GiftCardObjects { get; set; }

        /// <summary>A list of loyalty classes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loyaltyClasses")]
        public virtual System.Collections.Generic.IList<LoyaltyClass> LoyaltyClasses { get; set; }

        /// <summary>A list of loyalty objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loyaltyObjects")]
        public virtual System.Collections.Generic.IList<LoyaltyObject> LoyaltyObjects { get; set; }

        /// <summary>A list of offer classes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offerClasses")]
        public virtual System.Collections.Generic.IList<OfferClass> OfferClasses { get; set; }

        /// <summary>A list of offer objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offerObjects")]
        public virtual System.Collections.Generic.IList<OfferObject> OfferObjects { get; set; }

        /// <summary>A list of transit classes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transitClasses")]
        public virtual System.Collections.Generic.IList<TransitClass> TransitClasses { get; set; }

        /// <summary>A list of transit objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transitObjects")]
        public virtual System.Collections.Generic.IList<TransitObject> TransitObjects { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Review : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("comments")]
        public virtual string Comments { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class RotatingBarcode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An optional text that will override the default text that shows under the barcode. This field is intended
        /// for a human readable equivalent of the barcode value, used when the barcode cannot be scanned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alternateText")]
        public virtual string AlternateText { get; set; }

        /// <summary>
        /// Input only. NOTE: This feature is only available for the transit vertical. Optional set of initial rotating
        /// barcode values. This allows a small subset of barcodes to be included with the object. Further rotating
        /// barcode values must be uploaded with the UploadRotatingBarcodeValues endpoint.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initialRotatingBarcodeValues")]
        public virtual RotatingBarcodeValues InitialRotatingBarcodeValues { get; set; }

        /// <summary>
        /// The render encoding for the barcode. When specified, barcode is rendered in the given encoding. Otherwise
        /// best known encoding is chosen by Google.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("renderEncoding")]
        public virtual string RenderEncoding { get; set; }

        /// <summary>
        /// Optional text that will be shown when the barcode is hidden behind a click action. This happens in cases
        /// where a pass has Smart Tap enabled. If not specified, a default is chosen by Google.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("showCodeText")]
        public virtual LocalizedString ShowCodeText { get; set; }

        /// <summary>Details used to evaluate the {totp_value_n} substitutions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totpDetails")]
        public virtual RotatingBarcodeTotpDetails TotpDetails { get; set; }

        /// <summary>The type of this barcode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// String encoded barcode value. This string supports the following substitutions: * {totp_value_n}: Replaced
        /// with the TOTP value (see TotpDetails.parameters). * {totp_timestamp_millis}: Replaced with the timestamp
        /// (millis since epoch) at which the barcode was generated. * {totp_timestamp_seconds}: Replaced with the
        /// timestamp (seconds since epoch) at which the barcode was generated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valuePattern")]
        public virtual string ValuePattern { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for the time-based OTP substitutions. See https://tools.ietf.org/html/rfc6238</summary>
    public class RotatingBarcodeTotpDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The TOTP algorithm used to generate the OTP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("algorithm")]
        public virtual string Algorithm { get; set; }

        /// <summary>
        /// The TOTP parameters for each of the {totp_value_*} substitutions. The TotpParameters at index n is used for
        /// the {totp_value_n} substitution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IList<RotatingBarcodeTotpDetailsTotpParameters> Parameters { get; set; }

        /// <summary>The time interval used for the TOTP value generation, in milliseconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("periodMillis")]
        public virtual System.Nullable<long> PeriodMillis { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration for the key and value length. See https://www.rfc-editor.org/rfc/rfc4226#section-5.3
    /// </summary>
    public class RotatingBarcodeTotpDetailsTotpParameters : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The secret key used for the TOTP value generation, encoded as a Base16 string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The length of the TOTP value in decimal digits.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueLength")]
        public virtual System.Nullable<int> ValueLength { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A payload containing many barcode values and start date/time.</summary>
    public class RotatingBarcodeValues : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The amount of time each barcode is valid for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("periodMillis")]
        public virtual System.Nullable<long> PeriodMillis { get; set; }

        /// <summary>
        /// Required. The date/time the first barcode is valid from. Barcodes will be rotated through using
        /// period_millis defined on the object's RotatingBarcodeValueInfo. This is an ISO 8601 extended format
        /// date/time, with an offset. Time may be specified up to nanosecond precision. Offsets may be specified with
        /// seconds precision (even though offset seconds is not part of ISO 8601). For example:
        /// `1985-04-12T23:20:50.52Z` would be 20 minutes and 50.52 seconds after the 23rd hour of April 12th, 1985 in
        /// UTC. `1985-04-12T19:20:50.52-04:00` would be 20 minutes and 50.52 seconds after the 19th hour of April 12th,
        /// 1985, 4 hours before UTC (same instant in time as the above example). If the event were in New York, this
        /// would be the equivalent of Eastern Daylight Time (EDT). Remember that offset varies in regions that observe
        /// Daylight Saving Time (or Summer Time), depending on the time of the year.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDateTime")]
        public virtual string StartDateTime { get; set; }

        /// <summary>Required. The values to encode in the barcode. At least one value is required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines restrictions on the object that will be verified during save. Note: this is an advanced feature, please
    /// contact Google for implementation support.
    /// </summary>
    public class SaveRestrictions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Restrict the save of the referencing object to the given email address only. This is the hex output of
        /// SHA256 sum of the email address, all lowercase and without any notations like "." or "+", except "@". For
        /// example, for example@example.com, this value will be
        /// 31c5543c1734d25c7206f5fd591525d0295bec6fe84ff82f946a34fe970a1e66 and for Example@example.com, this value
        /// will be bc34f262c93ad7122763684ccea6f07fb7f5d8a2d11e60ce15a6f43fe70ce632 If email address of the logged-in
        /// user who tries to save this pass does not match with the defined value here, users won't be allowed to save
        /// this pass. They will instead be prompted with an error to contact the issuer. This information should be
        /// gathered from the user with an explicit consent via Sign in with Google integration
        /// https://developers.google.com/identity/authentication. Please contact with support before using Save
        /// Restrictions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictToEmailSha256")]
        public virtual string RestrictToEmailSha256 { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SecurityAnimation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Type of animation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("animationType")]
        public virtual string AnimationType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Request to send a private pass update notice information to Google, so that devices can then fetch the notice
    /// prompting the user to update a pass.
    /// </summary>
    public class SetPassUpdateNoticeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A fully qualified identifier of the pass that the issuer wants to notify the pass holder(s) about.
        /// Formatted as .
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalPassId")]
        public virtual string ExternalPassId { get; set; }

        /// <summary>
        /// Required. The issuer endpoint URI the pass holder needs to follow in order to receive an updated pass JWT.
        /// It can not contain any sensitive information. The endpoint needs to authenticate the user before giving the
        /// user the updated JWT. Example update URI https://someissuer.com/update/passId=someExternalPassId
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateUri")]
        public virtual string UpdateUri { get; set; }

        /// <summary>
        /// Required. The JWT signature of the updated pass that the issuer wants to notify Google about. Only devices
        /// that report a different JWT signature than this JWT signature will receive the update notification.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updatedPassJwtSignature")]
        public virtual string UpdatedPassJwtSignature { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response to a request to notify Google of an awaiting update to a private pass.</summary>
    public class SetPassUpdateNoticeResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SignUpInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ID of the class the user can sign up for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classId")]
        public virtual string ClassId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SmartTap : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The unique identifier for a smart tap. This value should follow the format issuer ID.identifier where the
        /// former is issued by Google and latter is the Smart Tap id. The Smart Tap id is a Base64 encoded string which
        /// represents the id which was generated by the Google Pay app.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Communication from merchant to user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infos")]
        public virtual System.Collections.Generic.IList<IssuerToUserInfo> Infos { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string `"walletobjects#smartTap"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Smart Tap merchant ID of who engaged in the Smart Tap interaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantId")]
        public virtual System.Nullable<long> MerchantId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SmartTapMerchantData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Available only to Smart Tap enabled partners. Contact support for additional guidance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authenticationKeys")]
        public virtual System.Collections.Generic.IList<AuthenticationKey> AuthenticationKeys { get; set; }

        /// <summary>Available only to Smart Tap enabled partners. Contact support for additional guidance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("smartTapMerchantId")]
        public virtual System.Nullable<long> SmartTapMerchantId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class TemplateItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A reference to a field to display. If both `firstValue` and `secondValue` are populated, they will both
        /// appear as one item with a slash between them. For example, values A and B would be shown as "A / B".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstValue")]
        public virtual FieldSelector FirstValue { get; set; }

        /// <summary>A predefined item to display. Only one of `firstValue` or `predefinedItem` may be set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("predefinedItem")]
        public virtual string PredefinedItem { get; set; }

        /// <summary>
        /// A reference to a field to display. This may only be populated if the `firstValue` field is populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondValue")]
        public virtual FieldSelector SecondValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Data for Text module. All fields are optional. Header will be displayed if available, different types of bodies
    /// will be concatenated if they are defined.
    /// </summary>
    public class TextModuleData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The body of the Text Module, which is defined as an uninterrupted string. Recommended maximum length is 500
        /// characters to ensure full string is displayed on smaller screens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("body")]
        public virtual string Body { get; set; }

        /// <summary>
        /// The header of the Text Module. Recommended maximum length is 35 characters to ensure full string is
        /// displayed on smaller screens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual string Header { get; set; }

        /// <summary>
        /// The ID associated with a text module. This field is here to enable ease of management of text modules and
        /// referencing them in template overrides. The ID should only include alphanumeric characters, '_', or '-'. It
        /// can not include dots, as dots are used to separate fields within FieldReference.fieldPaths in template
        /// overrides.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Translated strings for the body. Recommended maximum length is 500 characters to ensure full string is
        /// displayed on smaller screens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedBody")]
        public virtual LocalizedString LocalizedBody { get; set; }

        /// <summary>
        /// Translated strings for the header. Recommended maximum length is 35 characters to ensure full string is
        /// displayed on smaller screens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedHeader")]
        public virtual LocalizedString LocalizedHeader { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class TicketCost : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A message describing any kind of discount that was applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discountMessage")]
        public virtual LocalizedString DiscountMessage { get; set; }

        /// <summary>The face value of the ticket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("faceValue")]
        public virtual Money FaceValue { get; set; }

        /// <summary>The actual purchase price of the ticket, after tax and/or discounts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purchasePrice")]
        public virtual Money PurchasePrice { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class TicketLeg : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The date/time of arrival. This is an ISO 8601 extended format date/time, with or without an offset. Time may
        /// be specified up to nanosecond precision. Offsets may be specified with seconds precision (even though offset
        /// seconds is not part of ISO 8601). For example: `1985-04-12T23:20:50.52Z` would be 20 minutes and 50.52
        /// seconds after the 23rd hour of April 12th, 1985 in UTC. `1985-04-12T19:20:50.52-04:00` would be 20 minutes
        /// and 50.52 seconds after the 19th hour of April 12th, 1985, 4 hours before UTC (same instant in time as the
        /// above example). If the event were in New York, this would be the equivalent of Eastern Daylight Time (EDT).
        /// Remember that offset varies in regions that observe Daylight Saving Time (or Summer Time), depending on the
        /// time of the year. `1985-04-12T19:20:50.52` would be 20 minutes and 50.52 seconds after the 19th hour of
        /// April 12th, 1985 with no offset information. The portion of the date/time without the offset is considered
        /// the "local date/time". This should be the local date/time at the destination station. For example, if the
        /// event occurs at the 20th hour of June 5th, 2018 at the destination station, the local date/time portion
        /// should be `2018-06-05T20:00:00`. If the local date/time at the destination station is 4 hours before UTC, an
        /// offset of `-04:00` may be appended. Without offset information, some rich features may not be available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("arrivalDateTime")]
        public virtual string ArrivalDateTime { get; set; }

        /// <summary>The train or ship name/number that the passsenger needs to board.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("carriage")]
        public virtual string Carriage { get; set; }

        /// <summary>
        /// The date/time of departure. This is required if there is no validity time interval set on the transit
        /// object. This is an ISO 8601 extended format date/time, with or without an offset. Time may be specified up
        /// to nanosecond precision. Offsets may be specified with seconds precision (even though offset seconds is not
        /// part of ISO 8601). For example: `1985-04-12T23:20:50.52Z` would be 20 minutes and 50.52 seconds after the
        /// 23rd hour of April 12th, 1985 in UTC. `1985-04-12T19:20:50.52-04:00` would be 20 minutes and 50.52 seconds
        /// after the 19th hour of April 12th, 1985, 4 hours before UTC (same instant in time as the above example). If
        /// the event were in New York, this would be the equivalent of Eastern Daylight Time (EDT). Remember that
        /// offset varies in regions that observe Daylight Saving Time (or Summer Time), depending on the time of the
        /// year. `1985-04-12T19:20:50.52` would be 20 minutes and 50.52 seconds after the 19th hour of April 12th, 1985
        /// with no offset information. The portion of the date/time without the offset is considered the "local
        /// date/time". This should be the local date/time at the origin station. For example, if the departure occurs
        /// at the 20th hour of June 5th, 2018 at the origin station, the local date/time portion should be
        /// `2018-06-05T20:00:00`. If the local date/time at the origin station is 4 hours before UTC, an offset of
        /// `-04:00` may be appended. Without offset information, some rich features may not be available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("departureDateTime")]
        public virtual string DepartureDateTime { get; set; }

        /// <summary>The destination name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationName")]
        public virtual LocalizedString DestinationName { get; set; }

        /// <summary>The destination station code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationStationCode")]
        public virtual string DestinationStationCode { get; set; }

        /// <summary>Short description/name of the fare for this leg of travel. Eg "Anytime Single Use".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fareName")]
        public virtual LocalizedString FareName { get; set; }

        /// <summary>
        /// The name of the origin station. This is required if `desinationName` is present or if `originStationCode` is
        /// not present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originName")]
        public virtual LocalizedString OriginName { get; set; }

        /// <summary>
        /// The origin station code. This is required if `destinationStationCode` is present or if `originName` is not
        /// present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originStationCode")]
        public virtual string OriginStationCode { get; set; }

        /// <summary>The platform or gate where the passenger can board the carriage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platform")]
        public virtual string Platform { get; set; }

        /// <summary>
        /// The reserved seat for the passenger(s). If more than one seat is to be specified then use the `ticketSeats`
        /// field instead. Both `ticketSeat` and `ticketSeats` may not be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ticketSeat")]
        public virtual TicketSeat TicketSeat { get; set; }

        /// <summary>
        /// The reserved seat for the passenger(s). If only one seat is to be specified then use the `ticketSeat` field
        /// instead. Both `ticketSeat` and `ticketSeats` may not be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ticketSeats")]
        public virtual System.Collections.Generic.IList<TicketSeat> TicketSeats { get; set; }

        /// <summary>The name of the transit operator that is operating this leg of a trip.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transitOperatorName")]
        public virtual LocalizedString TransitOperatorName { get; set; }

        /// <summary>Terminus station or destination of the train/bus/etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transitTerminusName")]
        public virtual LocalizedString TransitTerminusName { get; set; }

        /// <summary>The zone of boarding within the platform.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class TicketRestrictions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Extra restrictions that don't fall under the "route" or "time" categories.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("otherRestrictions")]
        public virtual LocalizedString OtherRestrictions { get; set; }

        /// <summary>
        /// Restrictions about routes that may be taken. For example, this may be the string "Reserved CrossCountry
        /// trains only".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routeRestrictions")]
        public virtual LocalizedString RouteRestrictions { get; set; }

        /// <summary>More details about the above `routeRestrictions`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routeRestrictionsDetails")]
        public virtual LocalizedString RouteRestrictionsDetails { get; set; }

        /// <summary>Restrictions about times this ticket may be used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeRestrictions")]
        public virtual LocalizedString TimeRestrictions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class TicketSeat : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The identifier of the train car or coach in which the ticketed seat is located. Eg. "10"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("coach")]
        public virtual string Coach { get; set; }

        /// <summary>
        /// A custome fare class to be used if no `fareClass` applies. Both `fareClass` and `customFareClass` may not be
        /// set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customFareClass")]
        public virtual LocalizedString CustomFareClass { get; set; }

        /// <summary>The fare class of the ticketed seat.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fareClass")]
        public virtual string FareClass { get; set; }

        /// <summary>
        /// The identifier of where the ticketed seat is located. Eg. "42". If there is no specific identifier, use
        /// `seatAssigment` instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seat")]
        public virtual string Seat { get; set; }

        /// <summary>
        /// The passenger's seat assignment. Eg. "no specific seat". To be used when there is no specific identifier to
        /// use in `seat`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seatAssignment")]
        public virtual LocalizedString SeatAssignment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class TimeInterval : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// End time of the interval. Offset is not required. If an offset is provided and `start` time is set, `start`
        /// must also include an offset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("end")]
        public virtual DateTime End { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string `"walletobjects#timeInterval"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Start time of the interval. Offset is not required. If an offset is provided and `end` time is set, `end`
        /// must also include an offset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("start")]
        public virtual DateTime Start { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class TransitClass : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Activation options for an activatable ticket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activationOptions")]
        public virtual ActivationOptions ActivationOptions { get; set; }

        /// <summary>Deprecated. Use `multipleDevicesAndHoldersAllowedStatus` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowMultipleUsersPerObject")]
        public virtual System.Nullable<bool> AllowMultipleUsersPerObject { get; set; }

        /// <summary>
        /// Optional app or website link that will be displayed as a button on the front of the pass. If AppLinkData is
        /// provided for the corresponding object that will be used instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appLinkData")]
        public virtual AppLinkData AppLinkData { get; set; }

        /// <summary>
        /// Callback options to be used to call the issuer back for every save/delete of an object for this class by the
        /// end-user. All objects of this class are eligible for the callback.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callbackOptions")]
        public virtual CallbackOptions CallbackOptions { get; set; }

        /// <summary>
        /// Template information about how the class should be displayed. If unset, Google will fallback to a default
        /// set of fields to display.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classTemplateInfo")]
        public virtual ClassTemplateInfo ClassTemplateInfo { get; set; }

        /// <summary>
        /// Country code used to display the card's country (when the user is not in that country), as well as to
        /// display localized content when content is not available in the user's locale.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countryCode")]
        public virtual string CountryCode { get; set; }

        /// <summary>A custom label to use for the carriage value (`transitObject.ticketLeg.carriage`).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customCarriageLabel")]
        public virtual LocalizedString CustomCarriageLabel { get; set; }

        /// <summary>A custom label to use for the coach value (`transitObject.ticketLeg.ticketSeat.coach`).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customCoachLabel")]
        public virtual LocalizedString CustomCoachLabel { get; set; }

        /// <summary>
        /// A custom label to use for the transit concession category value (`transitObject.concessionCategory`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customConcessionCategoryLabel")]
        public virtual LocalizedString CustomConcessionCategoryLabel { get; set; }

        /// <summary>
        /// A custom label to use for the confirmation code value (`transitObject.purchaseDetails.confirmationCode`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customConfirmationCodeLabel")]
        public virtual LocalizedString CustomConfirmationCodeLabel { get; set; }

        /// <summary>
        /// A custom label to use for the transit discount message value
        /// (`transitObject.purchaseDetails.ticketCost.discountMessage`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customDiscountMessageLabel")]
        public virtual LocalizedString CustomDiscountMessageLabel { get; set; }

        /// <summary>
        /// A custom label to use for the fare class value (`transitObject.ticketLeg.ticketSeat.fareClass`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customFareClassLabel")]
        public virtual LocalizedString CustomFareClassLabel { get; set; }

        /// <summary>
        /// A custom label to use for the transit fare name value (`transitObject.ticketLeg.fareName`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customFareNameLabel")]
        public virtual LocalizedString CustomFareNameLabel { get; set; }

        /// <summary>
        /// A custom label to use for the other restrictions value
        /// (`transitObject.ticketRestrictions.otherRestrictions`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customOtherRestrictionsLabel")]
        public virtual LocalizedString CustomOtherRestrictionsLabel { get; set; }

        /// <summary>
        /// A custom label to use for the boarding platform value (`transitObject.ticketLeg.platform`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customPlatformLabel")]
        public virtual LocalizedString CustomPlatformLabel { get; set; }

        /// <summary>
        /// A custom label to use for the purchase face value (`transitObject.purchaseDetails.ticketCost.faceValue`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customPurchaseFaceValueLabel")]
        public virtual LocalizedString CustomPurchaseFaceValueLabel { get; set; }

        /// <summary>
        /// A custom label to use for the purchase price value
        /// (`transitObject.purchaseDetails.ticketCost.purchasePrice`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customPurchasePriceLabel")]
        public virtual LocalizedString CustomPurchasePriceLabel { get; set; }

        /// <summary>
        /// A custom label to use for the purchase receipt number value
        /// (`transitObject.purchaseDetails.purchaseReceiptNumber`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customPurchaseReceiptNumberLabel")]
        public virtual LocalizedString CustomPurchaseReceiptNumberLabel { get; set; }

        /// <summary>
        /// A custom label to use for the route restrictions details value
        /// (`transitObject.ticketRestrictions.routeRestrictionsDetails`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customRouteRestrictionsDetailsLabel")]
        public virtual LocalizedString CustomRouteRestrictionsDetailsLabel { get; set; }

        /// <summary>
        /// A custom label to use for the route restrictions value
        /// (`transitObject.ticketRestrictions.routeRestrictions`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customRouteRestrictionsLabel")]
        public virtual LocalizedString CustomRouteRestrictionsLabel { get; set; }

        /// <summary>
        /// A custom label to use for the seat location value (`transitObject.ticketLeg.ticketSeat.seat`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customSeatLabel")]
        public virtual LocalizedString CustomSeatLabel { get; set; }

        /// <summary>A custom label to use for the ticket number value (`transitObject.ticketNumber`).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customTicketNumberLabel")]
        public virtual LocalizedString CustomTicketNumberLabel { get; set; }

        /// <summary>
        /// A custom label to use for the time restrictions details value
        /// (`transitObject.ticketRestrictions.timeRestrictions`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customTimeRestrictionsLabel")]
        public virtual LocalizedString CustomTimeRestrictionsLabel { get; set; }

        /// <summary>
        /// A custom label to use for the transit terminus name value (`transitObject.ticketLeg.transitTerminusName`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customTransitTerminusNameLabel")]
        public virtual LocalizedString CustomTransitTerminusNameLabel { get; set; }

        /// <summary>A custom label to use for the boarding zone value (`transitObject.ticketLeg.zone`).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customZoneLabel")]
        public virtual LocalizedString CustomZoneLabel { get; set; }

        /// <summary>
        /// Controls the display of the single-leg itinerary for this class. By default, an itinerary will only display
        /// for multi-leg trips.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableSingleLegItinerary")]
        public virtual System.Nullable<bool> EnableSingleLegItinerary { get; set; }

        /// <summary>
        /// Identifies whether this class supports Smart Tap. The `redemptionIssuers` and object level
        /// `smartTapRedemptionLevel` fields must also be set up correctly in order for a pass to support Smart Tap.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableSmartTap")]
        public virtual System.Nullable<bool> EnableSmartTap { get; set; }

        /// <summary>
        /// Optional banner image displayed on the front of the card. If none is present, nothing will be displayed. The
        /// image will display at 100% width.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heroImage")]
        public virtual Image HeroImage { get; set; }

        /// <summary>
        /// The background color for the card. If not set the dominant color of the hero image is used, and if no hero
        /// image is set, the dominant color of the logo is used. The format is #rrggbb where rrggbb is a hex RGB
        /// triplet, such as `#ffcc00`. You can also use the shorthand version of the RGB triplet which is #rgb, such as
        /// `#fc0`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hexBackgroundColor")]
        public virtual string HexBackgroundColor { get; set; }

        /// <summary>
        /// The URI of your application's home page. Populating the URI in this field results in the exact same behavior
        /// as populating an URI in linksModuleData (when an object is rendered, a link to the homepage is shown in what
        /// would usually be thought of as the linksModuleData section of the object).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("homepageUri")]
        public virtual Uri HomepageUri { get; set; }

        /// <summary>
        /// Required. The unique identifier for a class. This ID must be unique across all classes from an issuer. This
        /// value should follow the format issuer ID. identifier where the former is issued by Google and latter is
        /// chosen by you. Your unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Image module data. The maximum number of these fields displayed is 1 from object level and 1 for class
        /// object level.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageModulesData")]
        public virtual System.Collections.Generic.IList<ImageModuleData> ImageModulesData { get; set; }

        /// <summary>Deprecated. Use textModulesData instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infoModuleData")]
        public virtual InfoModuleData InfoModuleData { get; set; }

        /// <summary>
        /// Required. The issuer name. Recommended maximum length is 20 characters to ensure full string is displayed on
        /// smaller screens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issuerName")]
        public virtual string IssuerName { get; set; }

        /// <summary>
        /// If this field is present, transit tickets served to a user's device will always be in this language.
        /// Represents the BCP 47 language tag. Example values are "en-US", "en-GB", "de", or "de-AT".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageOverride")]
        public virtual string LanguageOverride { get; set; }

        /// <summary>
        /// Links module data. If links module data is also defined on the object, both will be displayed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linksModuleData")]
        public virtual LinksModuleData LinksModuleData { get; set; }

        /// <summary>
        /// Translated strings for the issuer_name. Recommended maximum length is 20 characters to ensure full string is
        /// displayed on smaller screens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedIssuerName")]
        public virtual LocalizedString LocalizedIssuerName { get; set; }

        /// <summary>Note: This field is currently not supported to trigger geo notifications.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<LatLongPoint> Locations { get; set; }

        /// <summary>
        /// Required. The logo image of the ticket. This image is displayed in the card detail view of the app.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logo")]
        public virtual Image Logo { get; set; }

        /// <summary>
        /// Merchant locations. There is a maximum of ten on the class. Any additional MerchantLocations added beyond
        /// the 10 will be rejected. These locations will trigger a notification when a user enters within a Google-set
        /// radius of the point. This field replaces the deprecated LatLongPoints.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantLocations")]
        public virtual System.Collections.Generic.IList<MerchantLocation> MerchantLocations { get; set; }

        /// <summary>
        /// An array of messages displayed in the app. All users of this object will receive its associated messages.
        /// The maximum number of these fields is 10.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<Message> Messages { get; set; }

        /// <summary>
        /// Identifies whether multiple users and devices will save the same object referencing this class.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multipleDevicesAndHoldersAllowedStatus")]
        public virtual string MultipleDevicesAndHoldersAllowedStatus { get; set; }

        /// <summary>
        /// Whether or not field updates to this class should trigger notifications. When set to NOTIFY, we will attempt
        /// to trigger a field update notification to users. These notifications will only be sent to users if the field
        /// is part of an allowlist. If set to DO_NOT_NOTIFY or NOTIFICATION_SETTINGS_UNSPECIFIED, no notification will
        /// be triggered. This setting is ephemeral and needs to be set with each PATCH or UPDATE request, otherwise a
        /// notification will not be triggered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notifyPreference")]
        public virtual string NotifyPreference { get; set; }

        /// <summary>
        /// Identifies which redemption issuers can redeem the pass over Smart Tap. Redemption issuers are identified by
        /// their issuer ID. Redemption issuers must have at least one Smart Tap key configured. The `enableSmartTap`
        /// and object level `smartTapRedemptionLevel` fields must also be set up correctly in order for a pass to
        /// support Smart Tap.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redemptionIssuers")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> RedemptionIssuers { get; set; }

        /// <summary>The review comments set by the platform when a class is marked `approved` or `rejected`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("review")]
        public virtual Review Review { get; set; }

        /// <summary>
        /// Required. The status of the class. This field can be set to `draft` or `underReview` using the insert,
        /// patch, or update API calls. Once the review state is changed from `draft` it may not be changed back to
        /// `draft`. You should keep this field to `draft` when the class is under development. A `draft` class cannot
        /// be used to create any object. You should set this field to `underReview` when you believe the class is ready
        /// for use. The platform will automatically set this field to `approved` and it can be immediately used to
        /// create or migrate objects. When updating an already `approved` class you should keep setting this field to
        /// `underReview`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reviewStatus")]
        public virtual string ReviewStatus { get; set; }

        /// <summary>
        /// Optional information about the security animation. If this is set a security animation will be rendered on
        /// pass details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityAnimation")]
        public virtual SecurityAnimation SecurityAnimation { get; set; }

        /// <summary>
        /// Text module data. If text module data is also defined on the class, both will be displayed. The maximum
        /// number of these fields displayed is 10 from the object and 10 from the class.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textModulesData")]
        public virtual System.Collections.Generic.IList<TextModuleData> TextModulesData { get; set; }

        /// <summary>The name of the transit operator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transitOperatorName")]
        public virtual LocalizedString TransitOperatorName { get; set; }

        /// <summary>Required. The type of transit this class represents, such as "bus".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transitType")]
        public virtual string TransitType { get; set; }

        /// <summary>
        /// Optional value added module data. Maximum of ten on the class. For a pass only ten will be displayed,
        /// prioritizing those from the object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueAddedModuleData")]
        public virtual System.Collections.Generic.IList<ValueAddedModuleData> ValueAddedModuleData { get; set; }

        /// <summary>Deprecated</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<long> Version { get; set; }

        /// <summary>View Unlock Requirement options for the transit ticket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewUnlockRequirement")]
        public virtual string ViewUnlockRequirement { get; set; }

        /// <summary>Watermark image to display on the user's device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("watermark")]
        public virtual Image Watermark { get; set; }

        /// <summary>
        /// The wide logo of the ticket. When provided, this will be used in place of the logo in the top left of the
        /// card view.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wideLogo")]
        public virtual Image WideLogo { get; set; }

        /// <summary>Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wordMark")]
        public virtual Image WordMark { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class TransitClassAddMessageResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The updated TransitClass resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual TransitClass Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class TransitClassListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Pagination of the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pagination")]
        public virtual Pagination Pagination { get; set; }

        /// <summary>Resources corresponding to the list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<TransitClass> Resources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class TransitObject : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The activation status for the object. Required if the class has `activationOptions` set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activationStatus")]
        public virtual ActivationStatus ActivationStatus { get; set; }

        /// <summary>
        /// Optional app or website link that will be displayed as a button on the front of the pass. If AppLinkData is
        /// provided for the corresponding class only object AppLinkData will be displayed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appLinkData")]
        public virtual AppLinkData AppLinkData { get; set; }

        /// <summary>The barcode type and value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("barcode")]
        public virtual Barcode Barcode { get; set; }

        /// <summary>
        /// Required. The class associated with this object. The class must be of the same type as this object, must
        /// already exist, and must be approved. Class IDs should follow the format issuer ID.identifier where the
        /// former is issued by Google and latter is chosen by you.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classId")]
        public virtual string ClassId { get; set; }

        /// <summary>
        /// A copy of the inherited fields of the parent class. These fields are retrieved during a GET.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classReference")]
        public virtual TransitClass ClassReference { get; set; }

        /// <summary>The concession category for the ticket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("concessionCategory")]
        public virtual string ConcessionCategory { get; set; }

        /// <summary>
        /// A custom concession category to use when `concessionCategory` does not provide the right option. Both
        /// `concessionCategory` and `customConcessionCategory` may not be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customConcessionCategory")]
        public virtual LocalizedString CustomConcessionCategory { get; set; }

        /// <summary>
        /// A custom status to use for the ticket status value when `ticketStatus` does not provide the right option.
        /// Both `ticketStatus` and `customTicketStatus` may not be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customTicketStatus")]
        public virtual LocalizedString CustomTicketStatus { get; set; }

        /// <summary>Device context associated with the object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceContext")]
        public virtual DeviceContext DeviceContext { get; set; }

        /// <summary>
        /// Indicates if notifications should explicitly be suppressed. If this field is set to true, regardless of the
        /// `messages` field, expiration notifications to the user will be suppressed. By default, this field is set to
        /// false. Currently, this can only be set for offers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableExpirationNotification")]
        public virtual System.Nullable<bool> DisableExpirationNotification { get; set; }

        /// <summary>Information that controls how passes are grouped together.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupingInfo")]
        public virtual GroupingInfo GroupingInfo { get; set; }

        /// <summary>
        /// Whether this object is currently linked to a single device. This field is set by the platform when a user
        /// saves the object, linking it to their device. Intended for use by select partners. Contact support for
        /// additional information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasLinkedDevice")]
        public virtual System.Nullable<bool> HasLinkedDevice { get; set; }

        /// <summary>Indicates if the object has users. This field is set by the platform.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasUsers")]
        public virtual System.Nullable<bool> HasUsers { get; set; }

        /// <summary>
        /// Optional banner image displayed on the front of the card. If none is present, hero image of the class, if
        /// present, will be displayed. If hero image of the class is also not present, nothing will be displayed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heroImage")]
        public virtual Image HeroImage { get; set; }

        /// <summary>
        /// The background color for the card. If not set the dominant color of the hero image is used, and if no hero
        /// image is set, the dominant color of the logo is used. The format is #rrggbb where rrggbb is a hex RGB
        /// triplet, such as `#ffcc00`. You can also use the shorthand version of the RGB triplet which is #rgb, such as
        /// `#fc0`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hexBackgroundColor")]
        public virtual string HexBackgroundColor { get; set; }

        /// <summary>
        /// Required. The unique identifier for an object. This ID must be unique across all objects from an issuer.
        /// This value should follow the format issuer ID.identifier where the former is issued by Google and latter is
        /// chosen by you. The unique identifier should only include alphanumeric characters, '.', '_', or '-'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Image module data. The maximum number of these fields displayed is 1 from object level and 1 for class
        /// object level.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageModulesData")]
        public virtual System.Collections.Generic.IList<ImageModuleData> ImageModulesData { get; set; }

        /// <summary>Deprecated. Use textModulesData instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infoModuleData")]
        public virtual InfoModuleData InfoModuleData { get; set; }

        /// <summary>
        /// linked_object_ids are a list of other objects such as event ticket, loyalty, offer, generic, giftcard,
        /// transit and boarding pass that should be automatically attached to this transit object. If a user had saved
        /// this transit card, then these linked_object_ids would be automatically pushed to the user's wallet (unless
        /// they turned off the setting to receive such linked passes). Make sure that objects present in
        /// linked_object_ids are already inserted - if not, calls would fail. Once linked, the linked objects cannot be
        /// unlinked. You cannot link objects belonging to another issuer. There is a limit to the number of objects
        /// that can be linked to a single object. After the limit is reached, new linked objects in the call will be
        /// ignored silently. Object IDs should follow the format issuer ID. identifier where the former is issued by
        /// Google and the latter is chosen by you.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkedObjectIds")]
        public virtual System.Collections.Generic.IList<string> LinkedObjectIds { get; set; }

        /// <summary>
        /// Links module data. If links module data is also defined on the class, both will be displayed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linksModuleData")]
        public virtual LinksModuleData LinksModuleData { get; set; }

        /// <summary>Note: This field is currently not supported to trigger geo notifications.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<LatLongPoint> Locations { get; set; }

        /// <summary>
        /// Merchant locations. There is a maximum of ten on the object. Any additional MerchantLocations added beyond
        /// the 10 will be rejected. These locations will trigger a notification when a user enters within a Google-set
        /// radius of the point. This field replaces the deprecated LatLongPoints.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantLocations")]
        public virtual System.Collections.Generic.IList<MerchantLocation> MerchantLocations { get; set; }

        /// <summary>
        /// An array of messages displayed in the app. All users of this object will receive its associated messages.
        /// The maximum number of these fields is 10.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<Message> Messages { get; set; }

        /// <summary>
        /// Whether or not field updates to this object should trigger notifications. When set to NOTIFY, we will
        /// attempt to trigger a field update notification to users. These notifications will only be sent to users if
        /// the field is part of an allowlist. If set to DO_NOT_NOTIFY or NOTIFICATION_SETTINGS_UNSPECIFIED, no
        /// notification will be triggered. This setting is ephemeral and needs to be set with each PATCH or UPDATE
        /// request, otherwise a notification will not be triggered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notifyPreference")]
        public virtual string NotifyPreference { get; set; }

        /// <summary>Pass constraints for the object. Includes limiting NFC and screenshot behaviors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passConstraints")]
        public virtual PassConstraints PassConstraints { get; set; }

        /// <summary>
        /// The name(s) of the passengers the ticket is assigned to. The above `passengerType` field is meant to give
        /// Google context on this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passengerNames")]
        public virtual string PassengerNames { get; set; }

        /// <summary>The number of passengers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passengerType")]
        public virtual string PassengerType { get; set; }

        /// <summary>Purchase details for this ticket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purchaseDetails")]
        public virtual PurchaseDetails PurchaseDetails { get; set; }

        /// <summary>The rotating barcode type and value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rotatingBarcode")]
        public virtual RotatingBarcode RotatingBarcode { get; set; }

        /// <summary>
        /// Restrictions on the object that needs to be verified before the user tries to save the pass. Note that this
        /// restrictions will only be applied during save time. If the restrictions changed after a user saves the pass,
        /// the new restrictions will not be applied to an already saved pass.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("saveRestrictions")]
        public virtual SaveRestrictions SaveRestrictions { get; set; }

        /// <summary>
        /// The value that will be transmitted to a Smart Tap certified terminal over NFC for this object. The class
        /// level fields `enableSmartTap` and `redemptionIssuers` must also be set up correctly in order for the pass to
        /// support Smart Tap. Only ASCII characters are supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("smartTapRedemptionValue")]
        public virtual string SmartTapRedemptionValue { get; set; }

        /// <summary>
        /// Required. The state of the object. This field is used to determine how an object is displayed in the app.
        /// For example, an `inactive` object is moved to the "Expired passes" section.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Text module data. If text module data is also defined on the class, both will be displayed. The maximum
        /// number of these fields displayed is 10 from the object and 10 from the class.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textModulesData")]
        public virtual System.Collections.Generic.IList<TextModuleData> TextModulesData { get; set; }

        /// <summary>
        /// A single ticket leg contains departure and arrival information along with boarding and seating information.
        /// If more than one leg is to be specified then use the `ticketLegs` field instead. Both `ticketLeg` and
        /// `ticketLegs` may not be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ticketLeg")]
        public virtual TicketLeg TicketLeg { get; set; }

        /// <summary>
        /// Each ticket may contain one or more legs. Each leg contains departure and arrival information along with
        /// boarding and seating information. If only one leg is to be specified then use the `ticketLeg` field instead.
        /// Both `ticketLeg` and `ticketLegs` may not be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ticketLegs")]
        public virtual System.Collections.Generic.IList<TicketLeg> TicketLegs { get; set; }

        /// <summary>
        /// The number of the ticket. This is a unique identifier for the ticket in the transit operator's system.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ticketNumber")]
        public virtual string TicketNumber { get; set; }

        /// <summary>
        /// Information about what kind of restrictions there are on using this ticket. For example, which days of the
        /// week it must be used, or which routes are allowed to be taken.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ticketRestrictions")]
        public virtual TicketRestrictions TicketRestrictions { get; set; }

        /// <summary>The status of the ticket. For states which affect display, use the `state` field instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ticketStatus")]
        public virtual string TicketStatus { get; set; }

        /// <summary>
        /// This id is used to group tickets together if the user has saved multiple tickets for the same trip.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tripId")]
        public virtual string TripId { get; set; }

        /// <summary>
        /// Required. The type of trip this transit object represents. Used to determine the pass title and/or which
        /// symbol to use between the origin and destination.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tripType")]
        public virtual string TripType { get; set; }

        /// <summary>
        /// The time period this object will be `active` and object can be used. An object's state will be changed to
        /// `expired` when this time period has passed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validTimeInterval")]
        public virtual TimeInterval ValidTimeInterval { get; set; }

        /// <summary>Optional value added module data. Maximum of ten on the object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueAddedModuleData")]
        public virtual System.Collections.Generic.IList<ValueAddedModuleData> ValueAddedModuleData { get; set; }

        /// <summary>Deprecated</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<long> Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class TransitObjectAddMessageResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The updated TransitObject resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual TransitObject Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class TransitObjectListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Pagination of the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pagination")]
        public virtual Pagination Pagination { get; set; }

        /// <summary>Resources corresponding to the list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<TransitObject> Resources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to upload rotating barcode values.</summary>
    public class TransitObjectUploadRotatingBarcodeValuesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A reference to the rotating barcode values payload that was uploaded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blob")]
        public virtual Media Blob { get; set; }

        /// <summary>Extra information about the uploaded media.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mediaRequestInfo")]
        public virtual MediaRequestInfo MediaRequestInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for uploading rotating barcode values.</summary>
    public class TransitObjectUploadRotatingBarcodeValuesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class TranslatedString : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string `"walletobjects#translatedString"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Represents the BCP 47 language tag. Example values are "en-US", "en-GB", "de", or "de-AT".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("language")]
        public virtual string Language { get; set; }

        /// <summary>The UTF-8 encoded translated string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Indicates that the issuer would like Google Wallet to send an upcoming card validity notification 1 day before
    /// card becomes valid/usable.
    /// </summary>
    public class UpcomingNotification : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates if the object needs to have upcoming notification enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableNotification")]
        public virtual System.Nullable<bool> EnableNotification { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Uri : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The URI's title appearing in the app as text. Recommended maximum is 20 characters to ensure full string is
        /// displayed on smaller screens. Note that in some contexts this text is not used, such as when `description`
        /// is part of an image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The ID associated with a uri. This field is here to enable ease of management of uris.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Identifies what kind of resource this is. Value: the fixed string `"walletobjects#uri"`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Translated strings for the description. Recommended maximum is 20 characters to ensure full string is
        /// displayed on smaller screens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedDescription")]
        public virtual LocalizedString LocalizedDescription { get; set; }

        /// <summary>
        /// The location of a web page, image, or other resource. URIs in the `LinksModuleData` module can have
        /// different prefixes indicating the type of URI (a link to a web page, a link to a map, a telephone number, or
        /// an email address). URIs must have a scheme.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string UriValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data for Value Added module. Required fields are header and uri.</summary>
    public class ValueAddedModuleData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Body to be displayed on the module. Character limit is 50 and longer strings will be truncated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("body")]
        public virtual LocalizedString Body { get; set; }

        /// <summary>
        /// Header to be displayed on the module. Character limit is 60 and longer strings will be truncated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual LocalizedString Header { get; set; }

        /// <summary>
        /// Image to be displayed on the module. Recommended image ratio is 1:1. Images will be resized to fit this
        /// ratio.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual Image Image { get; set; }

        /// <summary>
        /// The index for sorting the modules. Modules with a lower sort index are shown before modules with a higher
        /// sort index. If unspecified, the sort index is assumed to be INT_MAX. For two modules with the same index,
        /// the sorting behavior is undefined.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sortIndex")]
        public virtual System.Nullable<int> SortIndex { get; set; }

        /// <summary>
        /// URI that the module leads to on click. This can be a web link or a deep link as mentioned in
        /// https://developer.android.com/training/app-links/deep-linking.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>Constraints that all must be met for the module to be shown.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewConstraints")]
        public virtual ModuleViewConstraints ViewConstraints { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
