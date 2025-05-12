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

namespace Google.Apis.Merchant.ordertracking_v1beta
{
    /// <summary>The Merchant Service.</summary>
    public class MerchantService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "ordertracking_v1beta";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public MerchantService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public MerchantService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Accounts = new AccountsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://merchantapi.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://merchantapi.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "merchantapi";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Merchant API.</summary>
        public class Scope
        {
            /// <summary>Manage your product listings and accounts for Google Shopping</summary>
            public static string Content = "https://www.googleapis.com/auth/content";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Merchant API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Manage your product listings and accounts for Google Shopping</summary>
            public const string Content = "https://www.googleapis.com/auth/content";
        }

        /// <summary>Gets the Accounts resource.</summary>
        public virtual AccountsResource Accounts { get; }
    }

    /// <summary>A base abstract class for Merchant requests.</summary>
    public abstract class MerchantBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new MerchantBaseServiceRequest instance.</summary>
        protected MerchantBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Merchant parameter list.</summary>
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

    /// <summary>The "accounts" collection of methods.</summary>
    public class AccountsResource
    {
        private const string Resource = "accounts";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AccountsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Ordertrackingsignals = new OrdertrackingsignalsResource(service);
        }

        /// <summary>Gets the Ordertrackingsignals resource.</summary>
        public virtual OrdertrackingsignalsResource Ordertrackingsignals { get; }

        /// <summary>The "ordertrackingsignals" collection of methods.</summary>
        public class OrdertrackingsignalsResource
        {
            private const string Resource = "ordertrackingsignals";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public OrdertrackingsignalsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates new order tracking signal.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The account of the business for which the order signal is created. Format: accounts/{account}
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Merchant.ordertracking_v1beta.Data.OrderTrackingSignal body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>Creates new order tracking signal.</summary>
            public class CreateRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.ordertracking_v1beta.Data.OrderTrackingSignal>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Merchant.ordertracking_v1beta.Data.OrderTrackingSignal body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The account of the business for which the order signal is created. Format:
                /// accounts/{account}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Output only. The ID that uniquely identifies this order tracking signal.</summary>
                [Google.Apis.Util.RequestParameterAttribute("orderTrackingSignalId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderTrackingSignalId { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Merchant.ordertracking_v1beta.Data.OrderTrackingSignal Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "ordertracking/v1beta/{+parent}/ordertrackingsignals";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+$",
                    });
                    RequestParameters.Add("orderTrackingSignalId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderTrackingSignalId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }
    }
}
namespace Google.Apis.Merchant.ordertracking_v1beta.Data
{
    /// <summary>
    /// Represents civil time (or occasionally physical time). This type can represent a civil time in one of a few
    /// possible ways: * When utc_offset is set and time_zone is unset: a civil time on a calendar day with a particular
    /// offset from UTC. * When time_zone is set and utc_offset is unset: a civil time on a calendar day in a particular
    /// time zone. * When neither time_zone nor utc_offset is set: a civil time on a calendar day in local time. The
    /// date is relative to the Proleptic Gregorian Calendar. If year, month, or day are 0, the DateTime is considered
    /// not to have a specific year, month, or day respectively. This type may also be used to represent a physical time
    /// if all the date and time fields are set and either case of the `time_offset` oneof is set. Consider using
    /// `Timestamp` message for physical time instead. If your use case also would like to store the user's timezone,
    /// that can be done in another field. This type is more flexible than some applications may want. Make sure to
    /// document and validate your application's limitations.
    /// </summary>
    public class DateTime : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a datetime
        /// without a day.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual System.Nullable<int> Day { get; set; }

        /// <summary>
        /// Optional. Hours of day in 24 hour format. Should be from 0 to 23, defaults to 0 (midnight). An API may
        /// choose to allow the value "24:00:00" for scenarios like business closing time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hours")]
        public virtual System.Nullable<int> Hours { get; set; }

        /// <summary>Optional. Minutes of hour of day. Must be from 0 to 59, defaults to 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minutes")]
        public virtual System.Nullable<int> Minutes { get; set; }

        /// <summary>
        /// Optional. Month of year. Must be from 1 to 12, or 0 if specifying a datetime without a month.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("month")]
        public virtual System.Nullable<int> Month { get; set; }

        /// <summary>
        /// Optional. Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999, defaults to 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>
        /// Optional. Seconds of minutes of the time. Must normally be from 0 to 59, defaults to 0. An API may allow the
        /// value 60 if it allows leap-seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seconds")]
        public virtual System.Nullable<int> Seconds { get; set; }

        /// <summary>Time zone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual TimeZone TimeZone { get; set; }

        /// <summary>
        /// UTC offset. Must be whole seconds, between -18 hours and +18 hours. For example, a UTC offset of -4:00 would
        /// be represented as { seconds: -14400 }.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utcOffset")]
        public virtual object UtcOffset { get; set; }

        /// <summary>
        /// Optional. Year of date. Must be from 1 to 9999, or 0 if specifying a datetime without a year.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("year")]
        public virtual System.Nullable<int> Year { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The line items of the order.</summary>
    public class LineItemDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Brand of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("brand")]
        public virtual string Brand { get; set; }

        /// <summary>Optional. The Global Trade Item Number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gtin")]
        public virtual string Gtin { get; set; }

        /// <summary>Required. The ID for this line item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineItemId")]
        public virtual string LineItemId { get; set; }

        /// <summary>Optional. The manufacturer part number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mpn")]
        public virtual string Mpn { get; set; }

        /// <summary>
        /// Required. The Content API REST ID of the product, in the form channel:contentLanguage:targetCountry:offerId.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; }

        /// <summary>Optional. Plain text title of this product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productTitle")]
        public virtual string ProductTitle { get; set; }

        /// <summary>Required. The quantity of the line item in the order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantity")]
        public virtual System.Nullable<long> Quantity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a business trade from which signals are extracted, such as shipping.</summary>
    public class OrderTrackingSignal : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The shipping fee of the order; this value should be set to zero in the case of free shipping.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerShippingFee")]
        public virtual Price CustomerShippingFee { get; set; }

        /// <summary>
        /// Optional. The delivery postal code, as a continuous string without spaces or dashes, for example "95016".
        /// This field will be anonymized in returned OrderTrackingSignal creation response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliveryPostalCode")]
        public virtual string DeliveryPostalCode { get; set; }

        /// <summary>
        /// Optional. The [CLDR territory code] (http://www.unicode.org/repos/cldr/tags/latest/common/main/en.xml) for
        /// the shipping destination.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliveryRegionCode")]
        public virtual string DeliveryRegionCode { get; set; }

        /// <summary>Required. Information about line items in the order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineItems")]
        public virtual System.Collections.Generic.IList<LineItemDetails> LineItems { get; set; }

        /// <summary>
        /// Optional. The Google Merchant Center ID of this order tracking signal. This value is optional. If left
        /// unset, the caller's Merchant Center ID is used. You must request access in order to provide data on behalf
        /// of another business. For more information, see [Submitting Order Tracking
        /// Signals](/shopping-content/guides/order-tracking-signals).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantId")]
        public virtual System.Nullable<long> MerchantId { get; set; }

        /// <summary>
        /// Required. The time when the order was created on the businesses side. Include the year and timezone string,
        /// if available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderCreatedTime")]
        public virtual DateTime OrderCreatedTime { get; set; }

        /// <summary>
        /// Required. The ID of the order on the businesses side. This field will be hashed in returned
        /// OrderTrackingSignal creation response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderId")]
        public virtual string OrderId { get; set; }

        /// <summary>Output only. The ID that uniquely identifies this order tracking signal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderTrackingSignalId")]
        public virtual System.Nullable<long> OrderTrackingSignalId { get; set; }

        /// <summary>Optional. The mapping of the line items to the shipment information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shipmentLineItemMapping")]
        public virtual System.Collections.Generic.IList<ShipmentLineItemMapping> ShipmentLineItemMapping { get; set; }

        /// <summary>Required. The shipping information for the order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shippingInfo")]
        public virtual System.Collections.Generic.IList<ShippingInfo> ShippingInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The price represented as a number and currency.</summary>
    public class Price : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The price represented as a number in micros (1 million micros is an equivalent to one's currency standard
        /// unit, for example, 1 USD = 1000000 micros).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amountMicros")]
        public virtual System.Nullable<long> AmountMicros { get; set; }

        /// <summary>
        /// The currency of the price using three-letter acronyms according to [ISO
        /// 4217](http://en.wikipedia.org/wiki/ISO_4217).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The change that happened to the product including old value, new value, country code as the region code and
    /// reporting context.
    /// </summary>
    public class ProductChange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The new value of the changed resource or attribute. If empty, it means that the product was deleted. Will
        /// have one of these values : (`approved`, `pending`, `disapproved`, ``)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newValue")]
        public virtual string NewValue { get; set; }

        /// <summary>
        /// The old value of the changed resource or attribute. If empty, it means that the product was created. Will
        /// have one of these values : (`approved`, `pending`, `disapproved`, ``)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oldValue")]
        public virtual string OldValue { get; set; }

        /// <summary>Countries that have the change (if applicable). Represented in the ISO 3166 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>
        /// Reporting contexts that have the change (if applicable). Currently this field supports only (`SHOPPING_ADS`,
        /// `LOCAL_INVENTORY_ADS`, `YOUTUBE_SHOPPING`, `YOUTUBE_CHECKOUT`, `YOUTUBE_AFFILIATE`) from the enum value
        /// [ReportingContextEnum](/merchant/api/reference/rest/Shared.Types/ReportingContextEnum)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportingContext")]
        public virtual string ReportingContext { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The message that the merchant will receive to notify about product status change event</summary>
    public class ProductStatusChangeMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The target account that owns the entity that changed. Format : `accounts/{merchant_id}`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("account")]
        public virtual string Account { get; set; }

        /// <summary>The attribute in the resource that changed, in this case it will be always `Status`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attribute")]
        public virtual string Attribute { get; set; }

        /// <summary>A message to describe the change that happened to the product</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("changes")]
        public virtual System.Collections.Generic.IList<ProductChange> Changes { get; set; }

        private string _eventTimeRaw;

        private object _eventTime;

        /// <summary>
        /// The time at which the event was generated. If you want to order the notification messages you receive you
        /// should rely on this field not on the order of receiving the notifications.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTime")]
        public virtual string EventTimeRaw
        {
            get => _eventTimeRaw;
            set
            {
                _eventTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _eventTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EventTimeDateTimeOffset instead.")]
        public virtual object EventTime
        {
            get => _eventTime;
            set
            {
                _eventTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _eventTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EventTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EventTimeRaw);
            set => EventTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _expirationTimeRaw;

        private object _expirationTime;

        /// <summary>
        /// Optional. The product expiration time. This field will not bet set if the notification is sent for a product
        /// deletion event.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expirationTime")]
        public virtual string ExpirationTimeRaw
        {
            get => _expirationTimeRaw;
            set
            {
                _expirationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expirationTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpirationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpirationTimeDateTimeOffset instead.")]
        public virtual object ExpirationTime
        {
            get => _expirationTime;
            set
            {
                _expirationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expirationTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpirationTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpirationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpirationTimeRaw);
            set => ExpirationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The account that manages the merchant's account. can be the same as merchant id if it is standalone account.
        /// Format : `accounts/{service_provider_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managingAccount")]
        public virtual string ManagingAccount { get; set; }

        /// <summary>The product name. Format: `accounts/{account}/products/{product}`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        /// <summary>The product id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual string ResourceId { get; set; }

        /// <summary>The resource that changed, in this case it will always be `Product`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents how many items are in the shipment for the given shipment_id and line_item_id.</summary>
    public class ShipmentLineItemMapping : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The line item ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineItemId")]
        public virtual string LineItemId { get; set; }

        /// <summary>Required. The line item quantity in the shipment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantity")]
        public virtual System.Nullable<long> Quantity { get; set; }

        /// <summary>
        /// Required. The shipment ID. This field will be hashed in returned OrderTrackingSignal creation response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shipmentId")]
        public virtual string ShipmentId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The shipping information for the order.</summary>
    public class ShippingInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The time when the shipment was actually delivered. Include the year and timezone string, if
        /// available. This field is required, if one of the following fields is absent: tracking_id or carrier_name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actualDeliveryTime")]
        public virtual DateTime ActualDeliveryTime { get; set; }

        /// <summary>
        /// Optional. The name of the shipping carrier for the delivery. This field is required if one of the following
        /// fields is absent: earliest_delivery_promise_time, latest_delivery_promise_time, and actual_delivery_time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("carrier")]
        public virtual string Carrier { get; set; }

        /// <summary>Optional. The service type for fulfillment, such as GROUND, FIRST_CLASS, etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("carrierService")]
        public virtual string CarrierService { get; set; }

        /// <summary>
        /// Optional. The earliest delivery promised time. Include the year and timezone string, if available. This
        /// field is required, if one of the following fields is absent: tracking_id or carrier_name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("earliestDeliveryPromiseTime")]
        public virtual DateTime EarliestDeliveryPromiseTime { get; set; }

        /// <summary>
        /// Optional. The latest delivery promised time. Include the year and timezone string, if available. This field
        /// is required, if one of the following fields is absent: tracking_id or carrier_name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestDeliveryPromiseTime")]
        public virtual DateTime LatestDeliveryPromiseTime { get; set; }

        /// <summary>
        /// Required. The origin postal code, as a continuous string without spaces or dashes, for example "95016". This
        /// field will be anonymized in returned OrderTrackingSignal creation response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originPostalCode")]
        public virtual string OriginPostalCode { get; set; }

        /// <summary>
        /// Required. The [CLDR territory code] (http://www.unicode.org/repos/cldr/tags/latest/common/main/en.xml) for
        /// the shipping origin.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originRegionCode")]
        public virtual string OriginRegionCode { get; set; }

        /// <summary>
        /// Required. The shipment ID. This field will be hashed in returned OrderTrackingSignal creation response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shipmentId")]
        public virtual string ShipmentId { get; set; }

        /// <summary>
        /// Optional. The time when the shipment was shipped. Include the year and timezone string, if available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shippedTime")]
        public virtual DateTime ShippedTime { get; set; }

        /// <summary>Required. The status of the shipment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shippingStatus")]
        public virtual string ShippingStatus { get; set; }

        /// <summary>
        /// Optional. The tracking ID of the shipment. This field is required if one of the following fields is absent:
        /// earliest_delivery_promise_time, latest_delivery_promise_time, and actual_delivery_time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackingId")]
        public virtual string TrackingId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a time zone from the [IANA Time Zone Database](https://www.iana.org/time-zones).</summary>
    public class TimeZone : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>IANA Time Zone Database time zone. For example "America/New_York".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Optional. IANA Time Zone Database version number. For example "2019a".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
