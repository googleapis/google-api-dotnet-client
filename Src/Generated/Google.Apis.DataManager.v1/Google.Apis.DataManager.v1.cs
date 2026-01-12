// Copyright 2026 Google LLC
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

namespace Google.Apis.DataManager.v1
{
    /// <summary>The DataManager Service.</summary>
    public class DataManagerService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DataManagerService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DataManagerService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            AudienceMembers = new AudienceMembersResource(this);
            Events = new EventsResource(this);
            RequestStatus = new RequestStatusResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://datamanager.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://datamanager.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "datamanager";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Data Manager API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, create, import, or delete your customer data in Google Ads, Google Marketing Platform
            /// (Campaign Manager 360, Search Ads 360, Display &amp;amp; Video 360), and Google Analytics
            /// </summary>
            public static string Datamanager = "https://www.googleapis.com/auth/datamanager";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Data Manager API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, create, import, or delete your customer data in Google Ads, Google Marketing Platform
            /// (Campaign Manager 360, Search Ads 360, Display &amp;amp; Video 360), and Google Analytics
            /// </summary>
            public const string Datamanager = "https://www.googleapis.com/auth/datamanager";
        }

        /// <summary>Gets the AudienceMembers resource.</summary>
        public virtual AudienceMembersResource AudienceMembers { get; }

        /// <summary>Gets the Events resource.</summary>
        public virtual EventsResource Events { get; }

        /// <summary>Gets the RequestStatus resource.</summary>
        public virtual RequestStatusResource RequestStatus { get; }
    }

    /// <summary>A base abstract class for DataManager requests.</summary>
    public abstract class DataManagerBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new DataManagerBaseServiceRequest instance.</summary>
        protected DataManagerBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes DataManager parameter list.</summary>
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

    /// <summary>The "audienceMembers" collection of methods.</summary>
    public class AudienceMembersResource
    {
        private const string Resource = "audienceMembers";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AudienceMembersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Uploads a list of AudienceMember resources to the provided Destination.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual IngestRequest Ingest(Google.Apis.DataManager.v1.Data.IngestAudienceMembersRequest body)
        {
            return new IngestRequest(this.service, body);
        }

        /// <summary>Uploads a list of AudienceMember resources to the provided Destination.</summary>
        public class IngestRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.IngestAudienceMembersResponse>
        {
            /// <summary>Constructs a new Ingest request.</summary>
            public IngestRequest(Google.Apis.Services.IClientService service, Google.Apis.DataManager.v1.Data.IngestAudienceMembersRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DataManager.v1.Data.IngestAudienceMembersRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "ingest";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/audienceMembers:ingest";

            /// <summary>Initializes Ingest parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Removes a list of AudienceMember resources from the provided Destination.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual RemoveRequest Remove(Google.Apis.DataManager.v1.Data.RemoveAudienceMembersRequest body)
        {
            return new RemoveRequest(this.service, body);
        }

        /// <summary>Removes a list of AudienceMember resources from the provided Destination.</summary>
        public class RemoveRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.RemoveAudienceMembersResponse>
        {
            /// <summary>Constructs a new Remove request.</summary>
            public RemoveRequest(Google.Apis.Services.IClientService service, Google.Apis.DataManager.v1.Data.RemoveAudienceMembersRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DataManager.v1.Data.RemoveAudienceMembersRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "remove";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/audienceMembers:remove";

            /// <summary>Initializes Remove parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "events" collection of methods.</summary>
    public class EventsResource
    {
        private const string Resource = "events";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public EventsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Uploads a list of Event resources from the provided Destination.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual IngestRequest Ingest(Google.Apis.DataManager.v1.Data.IngestEventsRequest body)
        {
            return new IngestRequest(this.service, body);
        }

        /// <summary>Uploads a list of Event resources from the provided Destination.</summary>
        public class IngestRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.IngestEventsResponse>
        {
            /// <summary>Constructs a new Ingest request.</summary>
            public IngestRequest(Google.Apis.Services.IClientService service, Google.Apis.DataManager.v1.Data.IngestEventsRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DataManager.v1.Data.IngestEventsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "ingest";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/events:ingest";

            /// <summary>Initializes Ingest parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "requestStatus" collection of methods.</summary>
    public class RequestStatusResource
    {
        private const string Resource = "requestStatus";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public RequestStatusResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Gets the status of a request given request id.</summary>
        public virtual RetrieveRequest Retrieve()
        {
            return new RetrieveRequest(this.service);
        }

        /// <summary>Gets the status of a request given request id.</summary>
        public class RetrieveRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.RetrieveRequestStatusResponse>
        {
            /// <summary>Constructs a new Retrieve request.</summary>
            public RetrieveRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Required. Required. The request ID of the Data Manager API request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string RequestId { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "retrieve";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/requestStatus:retrieve";

            /// <summary>Initializes Retrieve parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                {
                    Name = "requestId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.DataManager.v1.Data
{
    /// <summary>
    /// Identifiers and other information used to match the conversion event with other online activity (such as ad
    /// clicks).
    /// </summary>
    public class AdIdentifiers : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The click identifier for clicks associated with app events and originating from iOS devices
        /// starting with iOS14.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gbraid")]
        public virtual string Gbraid { get; set; }

        /// <summary>Optional. The Google click ID (gclid) associated with this event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gclid")]
        public virtual string Gclid { get; set; }

        /// <summary>
        /// Optional. Information gathered about the device being used (if any) at the time of landing onto the
        /// advertiser’s site after interacting with the ad.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("landingPageDeviceInfo")]
        public virtual DeviceInfo LandingPageDeviceInfo { get; set; }

        /// <summary>Optional. Session attributes for event attribution and modeling.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionAttributes")]
        public virtual string SessionAttributes { get; set; }

        /// <summary>
        /// Optional. The click identifier for clicks associated with web events and originating from iOS devices
        /// starting with iOS14.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wbraid")]
        public virtual string Wbraid { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Address information for the user.</summary>
    public class AddressInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Family (last) name of the user, all lowercase, with no punctuation, no leading or trailing
        /// whitespace, and hashed as SHA-256.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("familyName")]
        public virtual string FamilyName { get; set; }

        /// <summary>
        /// Required. Given (first) name of the user, all lowercase, with no punctuation, no leading or trailing
        /// whitespace, and hashed as SHA-256.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("givenName")]
        public virtual string GivenName { get; set; }

        /// <summary>Required. The postal code of the user's address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCode")]
        public virtual string PostalCode { get; set; }

        /// <summary>Required. The 2-letter region code in ISO-3166-1 alpha-2 of the user's address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The audience member to be operated on.</summary>
    public class AudienceMember : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The consent setting for the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consent")]
        public virtual Consent Consent { get; set; }

        /// <summary>Optional. Defines which Destination to send the audience member to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationReferences")]
        public virtual System.Collections.Generic.IList<string> DestinationReferences { get; set; }

        /// <summary>Data identifying the user's mobile devices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileData")]
        public virtual MobileData MobileData { get; set; }

        /// <summary>
        /// [Publisher Advertiser Identity Reconciliation (PAIR) IDs](//support.google.com/admanager/answer/15067908).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pairData")]
        public virtual PairData PairData { get; set; }

        /// <summary>User-provided data that identifies the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userData")]
        public virtual UserData UserData { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A data encryption key wrapped by an AWS KMS key.</summary>
    public class AwsWrappedKeyInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The base64 encoded encrypted data encryption key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptedDek")]
        public virtual string EncryptedDek { get; set; }

        /// <summary>
        /// Required. The URI of the AWS KMS key used to decrypt the DEK. Should be in the format of
        /// `arn:{partition}:kms:{region}:{account_id}:key/{key_id}` or
        /// `aws-kms://arn:{partition}:kms:{region}:{account_id}:key/{key_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kekUri")]
        public virtual string KekUri { get; set; }

        /// <summary>Required. The type of algorithm used to encrypt the data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyType")]
        public virtual string KeyType { get; set; }

        /// <summary>
        /// Required. The Amazon Resource Name of the IAM Role to assume for KMS decryption access. Should be in the
        /// format of `arn:{partition}:iam::{account_id}:role/{role_name}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roleArn")]
        public virtual string RoleArn { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The cart data associated with the event.</summary>
    public class CartData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The list of items associated with the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Item> Items { get; set; }

        /// <summary>Optional. The Merchant Center feed label associated with the feed of the items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantFeedLabel")]
        public virtual string MerchantFeedLabel { get; set; }

        /// <summary>
        /// Optional. The language code in ISO 639-1 associated with the Merchant Center feed of the items.where your
        /// items are uploaded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantFeedLanguageCode")]
        public virtual string MerchantFeedLanguageCode { get; set; }

        /// <summary>Optional. The Merchant Center ID associated with the items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantId")]
        public virtual string MerchantId { get; set; }

        /// <summary>Optional. The sum of all discounts associated with the transaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transactionDiscount")]
        public virtual System.Nullable<double> TransactionDiscount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// [Digital Markets Act (DMA)](//digital-markets-act.ec.europa.eu/index_en) consent settings for the user.
    /// </summary>
    public class Consent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Represents if the user consents to ad personalization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adPersonalization")]
        public virtual string AdPersonalization { get; set; }

        /// <summary>Optional. Represents if the user consents to ad user data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adUserData")]
        public virtual string AdUserData { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Custom variable for ads conversions.</summary>
    public class CustomVariable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Reference string used to determine which of the Event.destination_references the custom variable
        /// should be sent to. If empty, the Event.destination_references will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationReferences")]
        public virtual System.Collections.Generic.IList<string> DestinationReferences { get; set; }

        /// <summary>Optional. The value to store for the custom variable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>
        /// Optional. The name of the custom variable to set. If the variable is not found for the given destination, it
        /// will be ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variable")]
        public virtual string Variable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Google product you're sending data to. For example, a Google Ads account.</summary>
    public class Destination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. An account that the calling user's `login_account` has access to, through an established account
        /// link. For example, a data partner's `login_account` might have access to a client's `linked_account`. The
        /// partner might use this field to send data from the `linked_account` to another `operating_account`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkedAccount")]
        public virtual ProductAccount LinkedAccount { get; set; }

        /// <summary>
        /// Optional. The account used to make this API call. To add or remove data from the `operating_account`, this
        /// `login_account` must have write access to the `operating_account`. For example, a manager account of the
        /// `operating_account`, or an account with an established link to the `operating_account`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loginAccount")]
        public virtual ProductAccount LoginAccount { get; set; }

        /// <summary>Required. The account to send the data to or remove the data from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatingAccount")]
        public virtual ProductAccount OperatingAccount { get; set; }

        /// <summary>
        /// Required. The object within the product account to ingest into. For example, a Google Ads audience ID, a
        /// Display &amp;amp; Video 360 audience ID or a Google Ads conversion action ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productDestinationId")]
        public virtual string ProductDestinationId { get; set; }

        /// <summary>
        /// Optional. ID for this `Destination` resource, unique within the request. Use to reference this `Destination`
        /// in the IngestEventsRequest and IngestAudienceMembersRequest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reference")]
        public virtual string Reference { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the device being used (if any) when the event happened.</summary>
    public class DeviceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The IP address of the device for the given context. **Note:** Google Ads does not support IP
        /// address matching for end users in the European Economic Area (EEA), United Kingdom (UK), or Switzerland
        /// (CH). Add logic to conditionally exclude sharing IP addresses from users from these regions and ensure that
        /// you provide users with clear and comprehensive information about the data you collect on your sites, apps,
        /// and other properties and get consent where required by law or any applicable Google policies. See the [About
        /// offline conversion imports](https://support.google.com/google-ads/answer/2998031) page for more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
        public virtual string IpAddress { get; set; }

        /// <summary>Optional. The user-agent string of the device for the given context.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userAgent")]
        public virtual string UserAgent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encryption information for the data being ingested.</summary>
    public class EncryptionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Amazon Web Services wrapped key information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("awsWrappedKeyInfo")]
        public virtual AwsWrappedKeyInfo AwsWrappedKeyInfo { get; set; }

        /// <summary>Google Cloud Platform wrapped key information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpWrappedKeyInfo")]
        public virtual GcpWrappedKeyInfo GcpWrappedKeyInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The error count for a given error reason.</summary>
    public class ErrorCount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The error reason of the failed records.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The count of records that failed to upload for a given reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Error counts for each type of error.</summary>
    public class ErrorInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of errors and counts per error reason. May not be populated in all cases.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorCounts")]
        public virtual System.Collections.Generic.IList<ErrorCount> ErrorCounts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An event representing a user interaction with an advertiser's website or app.</summary>
    public class Event : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Identifiers and other information used to match the conversion event with other online activity
        /// (such as ad clicks).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adIdentifiers")]
        public virtual AdIdentifiers AdIdentifiers { get; set; }

        /// <summary>
        /// Optional. A bucket of any [event
        /// parameters](https://developers.google.com/analytics/devguides/collection/protocol/ga4/reference/events) to
        /// be included within the event that were not already specified using other structured fields.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalEventParameters")]
        public virtual System.Collections.Generic.IList<EventParameter> AdditionalEventParameters { get; set; }

        /// <summary>Optional. Information about the transaction and items associated with the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cartData")]
        public virtual CartData CartData { get; set; }

        /// <summary>
        /// Optional. A unique identifier for the user instance of a web client for this GA4 web stream.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>
        /// Optional. Information about whether the associated user has provided different types of consent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consent")]
        public virtual Consent Consent { get; set; }

        /// <summary>Optional. The conversion value associated with the event, for value-based conversions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionValue")]
        public virtual System.Nullable<double> ConversionValue { get; set; }

        /// <summary>Optional. The currency code associated with all monetary values within this event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currency")]
        public virtual string Currency { get; set; }

        /// <summary>
        /// Optional. Additional key/value pair information to send to the conversion containers (conversion action or
        /// FL activity).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customVariables")]
        public virtual System.Collections.Generic.IList<CustomVariable> CustomVariables { get; set; }

        /// <summary>
        /// Optional. Reference string used to determine the destination. If empty, the event will be sent to all
        /// destinations in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationReferences")]
        public virtual System.Collections.Generic.IList<string> DestinationReferences { get; set; }

        /// <summary>
        /// Optional. Information gathered about the device being used (if any) when the event happened.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventDeviceInfo")]
        public virtual DeviceInfo EventDeviceInfo { get; set; }

        /// <summary>Optional. The name of the event. Required for GA4 events.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventName")]
        public virtual string EventName { get; set; }

        /// <summary>Optional. Signal for where the event happened (web, app, in-store, etc.).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventSource")]
        public virtual string EventSource { get; set; }

        private string _eventTimestampRaw;

        private object _eventTimestamp;

        /// <summary>Required. The time the event occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTimestamp")]
        public virtual string EventTimestampRaw
        {
            get => _eventTimestampRaw;
            set
            {
                _eventTimestamp = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _eventTimestampRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EventTimestampRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EventTimestampDateTimeOffset instead.")]
        public virtual object EventTimestamp
        {
            get => _eventTimestamp;
            set
            {
                _eventTimestampRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _eventTimestamp = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="EventTimestampRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EventTimestampDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EventTimestampRaw);
            set => EventTimestampRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Optional. A list of key/value pairs for experimental fields that may eventually be promoted to be part of
        /// the API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("experimentalFields")]
        public virtual System.Collections.Generic.IList<ExperimentalField> ExperimentalFields { get; set; }

        private string _lastUpdatedTimestampRaw;

        private object _lastUpdatedTimestamp;

        /// <summary>Optional. The last time the event was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdatedTimestamp")]
        public virtual string LastUpdatedTimestampRaw
        {
            get => _lastUpdatedTimestampRaw;
            set
            {
                _lastUpdatedTimestamp = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastUpdatedTimestampRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastUpdatedTimestampRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastUpdatedTimestampDateTimeOffset instead.")]
        public virtual object LastUpdatedTimestamp
        {
            get => _lastUpdatedTimestamp;
            set
            {
                _lastUpdatedTimestampRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastUpdatedTimestamp = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastUpdatedTimestampRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastUpdatedTimestampDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastUpdatedTimestampRaw);
            set => LastUpdatedTimestampRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Optional. The unique identifier for this event. Required for conversions using multiple data sources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transactionId")]
        public virtual string TransactionId { get; set; }

        /// <summary>
        /// Optional. Pieces of user provided data, representing the user the event is associated with.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userData")]
        public virtual UserData UserData { get; set; }

        /// <summary>Optional. A unique identifier for a user, as defined by the advertiser.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        /// <summary>
        /// Optional. Advertiser-assessed information about the user at the time that the event happened.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userProperties")]
        public virtual UserProperties UserProperties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Event parameter for GA4 events.</summary>
    public class EventParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The name of the parameter to use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameterName")]
        public virtual string ParameterName { get; set; }

        /// <summary>Required. The string representation of the value of the parameter to set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Experimental field representing unofficial fields.</summary>
    public class ExperimentalField : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The name of the field to use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual string Field { get; set; }

        /// <summary>Optional. The value the field to set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the Google Cloud Platform wrapped key.</summary>
    public class GcpWrappedKeyInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The base64 encoded encrypted data encryption key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptedDek")]
        public virtual string EncryptedDek { get; set; }

        /// <summary>
        /// Required. Google Cloud Platform [Cloud Key Management Service resource
        /// ID](//cloud.google.com/kms/docs/getting-resource-ids). Should be in the format of
        /// `projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{key}` or
        /// `gcp-kms://projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{key}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kekUri")]
        public virtual string KekUri { get; set; }

        /// <summary>Required. The type of algorithm used to encrypt the data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyType")]
        public virtual string KeyType { get; set; }

        /// <summary>
        /// Required. The [Workload Identity](//cloud.google.com/iam/docs/workload-identity-federation) pool provider
        /// required to use KEK.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wipProvider")]
        public virtual string WipProvider { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Request to upload audience members to the provided destinations. Returns an IngestAudienceMembersResponse.
    /// </summary>
    public class IngestAudienceMembersRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The list of users to send to the specified destinations. At most 10000 AudienceMember resources
        /// can be sent in a single request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audienceMembers")]
        public virtual System.Collections.Generic.IList<AudienceMember> AudienceMembers { get; set; }

        /// <summary>
        /// Optional. Request-level consent to apply to all users in the request. User-level consent overrides
        /// request-level consent, and can be specified in each AudienceMember.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consent")]
        public virtual Consent Consent { get; set; }

        /// <summary>Required. The list of destinations to send the audience members to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinations")]
        public virtual System.Collections.Generic.IList<Destination> Destinations { get; set; }

        /// <summary>
        /// Optional. Required for UserData uploads. The encoding type of the user identifiers. For hashed user
        /// identifiers, this is the encoding type of the hashed string. For encrypted hashed user identifiers, this is
        /// the encoding type of the outer encrypted string, but not necessarily the inner hashed string, meaning the
        /// inner hashed string could be encoded in a different way than the outer encrypted string. For non `UserData`
        /// uploads, this field is ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encoding")]
        public virtual string Encoding { get; set; }

        /// <summary>
        /// Optional. Encryption information for UserData uploads. If not set, it's assumed that uploaded identifying
        /// information is hashed but not encrypted. For non `UserData` uploads, this field is ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionInfo")]
        public virtual EncryptionInfo EncryptionInfo { get; set; }

        /// <summary>Optional. The terms of service that the user has accepted/rejected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("termsOfService")]
        public virtual TermsOfService TermsOfService { get; set; }

        /// <summary>
        /// Optional. For testing purposes. If `true`, the request is validated but not executed. Only errors are
        /// returned, not results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response from the IngestAudienceMembersRequest.</summary>
    public class IngestAudienceMembersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The auto-generated ID of the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of the ingest audience members request.</summary>
    public class IngestAudienceMembersStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status of the mobile data ingestion to the destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileDataIngestionStatus")]
        public virtual IngestMobileDataStatus MobileDataIngestionStatus { get; set; }

        /// <summary>The status of the pair data ingestion to the destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pairDataIngestionStatus")]
        public virtual IngestPairDataStatus PairDataIngestionStatus { get; set; }

        /// <summary>The status of the user data ingestion to the destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userDataIngestionStatus")]
        public virtual IngestUserDataStatus UserDataIngestionStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Request to upload audience members to the provided destinations. Returns an IngestEventsResponse.
    /// </summary>
    public class IngestEventsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Request-level consent to apply to all users in the request. User-level consent overrides
        /// request-level consent, and can be specified in each Event.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consent")]
        public virtual Consent Consent { get; set; }

        /// <summary>Required. The list of destinations to send the events to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinations")]
        public virtual System.Collections.Generic.IList<Destination> Destinations { get; set; }

        /// <summary>
        /// Optional. Required for UserData uploads. The encoding type of the user identifiers. For hashed user
        /// identifiers, this is the encoding type of the hashed string. For encrypted hashed user identifiers, this is
        /// the encoding type of the outer encrypted string, but not necessarily the inner hashed string, meaning the
        /// inner hashed string could be encoded in a different way than the outer encrypted string. For non `UserData`
        /// uploads, this field is ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encoding")]
        public virtual string Encoding { get; set; }

        /// <summary>
        /// Optional. Encryption information for UserData uploads. If not set, it's assumed that uploaded identifying
        /// information is hashed but not encrypted. For non `UserData` uploads, this field is ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionInfo")]
        public virtual EncryptionInfo EncryptionInfo { get; set; }

        /// <summary>
        /// Required. The list of events to send to the specified destinations. At most 2000 Event resources can be sent
        /// in a single request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("events")]
        public virtual System.Collections.Generic.IList<Event> Events { get; set; }

        /// <summary>
        /// Optional. For testing purposes. If `true`, the request is validated but not executed. Only errors are
        /// returned, not results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response from the IngestEventsRequest.</summary>
    public class IngestEventsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The auto-generated ID of the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of the events ingestion to the destination.</summary>
    public class IngestEventsStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The total count of events sent in the upload request. Includes all events in the request, regardless of
        /// whether they were successfully ingested or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The status of the mobile data ingestion to the destination containing stats related to the ingestion.
    /// </summary>
    public class IngestMobileDataStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The total count of mobile ids sent in the upload request for the destination. Includes all mobile ids in the
        /// request, regardless of whether they were successfully ingested or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileIdCount")]
        public virtual System.Nullable<long> MobileIdCount { get; set; }

        /// <summary>
        /// The total count of audience members sent in the upload request for the destination. Includes all audience
        /// members in the request, regardless of whether they were successfully ingested or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The status of the pair data ingestion to the destination containing stats related to the ingestion.
    /// </summary>
    public class IngestPairDataStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The total count of pair ids sent in the upload request for the destination. Includes all pair ids in the
        /// request, regardless of whether they were successfully ingested or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pairIdCount")]
        public virtual System.Nullable<long> PairIdCount { get; set; }

        /// <summary>
        /// The total count of audience members sent in the upload request for the destination. Includes all audience
        /// members in the request, regardless of whether they were successfully ingested or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The status of the user data ingestion to the destination containing stats related to the ingestion.
    /// </summary>
    public class IngestUserDataStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The total count of audience members sent in the upload request for the destination. Includes all audience
        /// members in the request, regardless of whether they were successfully ingested or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        /// <summary>The match rate range of the upload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uploadMatchRateRange")]
        public virtual string UploadMatchRateRange { get; set; }

        /// <summary>
        /// The total count of user identifiers sent in the upload request for the destination. Includes all user
        /// identifiers in the request, regardless of whether they were successfully ingested or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userIdentifierCount")]
        public virtual System.Nullable<long> UserIdentifierCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an item in the cart associated with the event.</summary>
    public class Item : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A bucket of any [event parameters related to an
        /// item](https://developers.google.com/analytics/devguides/collection/protocol/ga4/reference/events) to be
        /// included within the event that were not already specified using other structured fields.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalItemParameters")]
        public virtual System.Collections.Generic.IList<ItemParameter> AdditionalItemParameters { get; set; }

        /// <summary>Optional. A unique identifier to reference the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemId")]
        public virtual string ItemId { get; set; }

        /// <summary>Optional. The product ID within the Merchant Center account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantProductId")]
        public virtual string MerchantProductId { get; set; }

        /// <summary>Optional. The number of this item associated with the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantity")]
        public virtual System.Nullable<long> Quantity { get; set; }

        /// <summary>Optional. The unit price excluding tax, shipping, and any transaction level discounts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unitPrice")]
        public virtual System.Nullable<double> UnitPrice { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A bucket of any [event parameters related to an
    /// item](https://developers.google.com/analytics/devguides/collection/protocol/ga4/reference/events) to be included
    /// within the event that were not already specified using other structured fields.
    /// </summary>
    public class ItemParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The name of the parameter to use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameterName")]
        public virtual string ParameterName { get; set; }

        /// <summary>Required. The string representation of the value of the parameter to set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Mobile IDs for the audience. At least one mobile ID is required.</summary>
    public class MobileData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The list of mobile device IDs (advertising ID/IDFA). At most 10 `mobileIds` can be provided in a
        /// single AudienceMember.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileIds")]
        public virtual System.Collections.Generic.IList<string> MobileIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// [PAIR](//support.google.com/admanager/answer/15067908) IDs for the audience. At least one PAIR ID is required.
    /// </summary>
    public class PairData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Cleanroom-provided PII data, hashed with SHA256, and encrypted with an EC commutative cipher using
        /// publisher key for the [PAIR]((//support.google.com/admanager/answer/15067908)) user list. At most 10
        /// `pairIds` can be provided in a single AudienceMember.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pairIds")]
        public virtual System.Collections.Generic.IList<string> PairIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a specific account.</summary>
    public class ProductAccount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The ID of the account. For example, your Google Ads account ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        /// <summary>
        /// Optional. The type of the account. For example, `GOOGLE_ADS`. Either `account_type` or the deprecated
        /// `product` is required. If both are set, the values must match.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountType")]
        public virtual string AccountType { get; set; }

        /// <summary>Deprecated. Use `account_type` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("product")]
        public virtual string Product { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Request to remove users from an audience in the provided destinations. Returns a RemoveAudienceMembersResponse.
    /// </summary>
    public class RemoveAudienceMembersRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The list of users to remove.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audienceMembers")]
        public virtual System.Collections.Generic.IList<AudienceMember> AudienceMembers { get; set; }

        /// <summary>Required. The list of destinations to remove the users from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinations")]
        public virtual System.Collections.Generic.IList<Destination> Destinations { get; set; }

        /// <summary>
        /// Optional. Required for UserData uploads. The encoding type of the user identifiers. Applies to only the
        /// outer encoding for encrypted user identifiers. For non `UserData` uploads, this field is ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encoding")]
        public virtual string Encoding { get; set; }

        /// <summary>
        /// Optional. Encryption information for UserData uploads. If not set, it's assumed that uploaded identifying
        /// information is hashed but not encrypted. For non `UserData` uploads, this field is ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionInfo")]
        public virtual EncryptionInfo EncryptionInfo { get; set; }

        /// <summary>
        /// Optional. For testing purposes. If `true`, the request is validated but not executed. Only errors are
        /// returned, not results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response from the RemoveAudienceMembersRequest.</summary>
    public class RemoveAudienceMembersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The auto-generated ID of the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of the remove audience members request.</summary>
    public class RemoveAudienceMembersStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status of the mobile data removal from the destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileDataRemovalStatus")]
        public virtual RemoveMobileDataStatus MobileDataRemovalStatus { get; set; }

        /// <summary>The status of the pair data removal from the destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pairDataRemovalStatus")]
        public virtual RemovePairDataStatus PairDataRemovalStatus { get; set; }

        /// <summary>The status of the user data removal from the destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userDataRemovalStatus")]
        public virtual RemoveUserDataStatus UserDataRemovalStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of the mobile data removal from the destination.</summary>
    public class RemoveMobileDataStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The total count of mobile Ids sent in the removal request. Includes all mobile ids in the request,
        /// regardless of whether they were successfully removed or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileIdCount")]
        public virtual System.Nullable<long> MobileIdCount { get; set; }

        /// <summary>
        /// The total count of audience members sent in the removal request. Includes all audience members in the
        /// request, regardless of whether they were successfully removed or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of the pair data removal from the destination.</summary>
    public class RemovePairDataStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The total count of pair ids sent in the removal request. Includes all pair ids in the request, regardless of
        /// whether they were successfully removed or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pairIdCount")]
        public virtual System.Nullable<long> PairIdCount { get; set; }

        /// <summary>
        /// The total count of audience members sent in the removal request. Includes all audience members in the
        /// request, regardless of whether they were successfully removed or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of the user data removal from the destination.</summary>
    public class RemoveUserDataStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The total count of audience members sent in the removal request. Includes all audience members in the
        /// request, regardless of whether they were successfully removed or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        /// <summary>
        /// The total count of user identifiers sent in the removal request. Includes all user identifiers in the
        /// request, regardless of whether they were successfully removed or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userIdentifierCount")]
        public virtual System.Nullable<long> UserIdentifierCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request status per destination.</summary>
    public class RequestStatusPerDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status of the ingest audience members request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audienceMembersIngestionStatus")]
        public virtual IngestAudienceMembersStatus AudienceMembersIngestionStatus { get; set; }

        /// <summary>The status of the remove audience members request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audienceMembersRemovalStatus")]
        public virtual RemoveAudienceMembersStatus AudienceMembersRemovalStatus { get; set; }

        /// <summary>A destination within a DM API request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destination")]
        public virtual Destination Destination { get; set; }

        /// <summary>An error info error containing the error reason and error counts related to the upload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorInfo")]
        public virtual ErrorInfo ErrorInfo { get; set; }

        /// <summary>The status of the ingest events request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventsIngestionStatus")]
        public virtual IngestEventsStatus EventsIngestionStatus { get; set; }

        /// <summary>The request status of the destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestStatus")]
        public virtual string RequestStatus { get; set; }

        /// <summary>A warning info containing the warning reason and warning counts related to the upload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warningInfo")]
        public virtual WarningInfo WarningInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response from the RetrieveRequestStatusRequest.</summary>
    public class RetrieveRequestStatusResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of request statuses per destination. The order of the statuses matches the order of the destinations
        /// in the original request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestStatusPerDestination")]
        public virtual System.Collections.Generic.IList<RequestStatusPerDestination> RequestStatusPerDestination { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The `Status` type defines a logical error model that is suitable for different programming environments,
    /// including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status` message contains
    /// three pieces of data: error code, error message, and error details. You can find out more about this error model
    /// and how to work with it in the [API Design Guide](https://cloud.google.com/apis/design/errors).
    /// </summary>
    public class Status : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status code, which should be an enum value of google.rpc.Code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<int> Code { get; set; }

        /// <summary>
        /// A list of messages that carry the error details. There is a common set of message types for APIs to use.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Details { get; set; }

        /// <summary>
        /// A developer-facing error message, which should be in English. Any user-facing error message should be
        /// localized and sent in the google.rpc.Status.details field, or localized by the client.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The terms of service that the user has accepted/rejected.</summary>
    public class TermsOfService : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The Customer Match terms of service: https://support.google.com/adspolicy/answer/6299717. This
        /// must be accepted when ingesting UserData or MobileData. This field is not required for Partner Match User
        /// list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerMatchTermsOfServiceStatus")]
        public virtual string CustomerMatchTermsOfServiceStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data that identifies the user. At least one identifier is required.</summary>
    public class UserData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The identifiers for the user. It's possible to provide multiple instances of the same type of data
        /// (for example, multiple email addresses). To increase the likelihood of a match, provide as many identifiers
        /// as possible. At most 10 `userIdentifiers` can be provided in a single AudienceMember or Event.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userIdentifiers")]
        public virtual System.Collections.Generic.IList<UserIdentifier> UserIdentifiers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single identifier for the user.</summary>
    public class UserIdentifier : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The known components of a user's address. Holds a grouping of identifiers that are matched all at once.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual AddressInfo Address { get; set; }

        /// <summary>Hashed email address using SHA-256 hash function after normalization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailAddress")]
        public virtual string EmailAddress { get; set; }

        /// <summary>Hashed phone number using SHA-256 hash function after normalization (E164 standard).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneNumber")]
        public virtual string PhoneNumber { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Advertiser-assessed information about the user at the time that the event happened. See
    /// https://support.google.com/google-ads/answer/14007601 for more details.
    /// </summary>
    public class UserProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A bucket of any additional [user
        /// properties](https://developers.google.com/analytics/devguides/collection/protocol/ga4/user-properties) for
        /// the user associated with this event.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalUserProperties")]
        public virtual System.Collections.Generic.IList<UserProperty> AdditionalUserProperties { get; set; }

        /// <summary>Optional. Type of the customer associated with the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerType")]
        public virtual string CustomerType { get; set; }

        /// <summary>Optional. The advertiser-assessed value of the customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerValueBucket")]
        public virtual string CustomerValueBucket { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A bucket of any additional [user
    /// properties](https://developers.google.com/analytics/devguides/collection/protocol/ga4/user-properties) for the
    /// user associated with this event.
    /// </summary>
    public class UserProperty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The name of the user property to use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("propertyName")]
        public virtual string PropertyName { get; set; }

        /// <summary>Required. The string representation of the value of the user property to use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The warning count for a given warning reason.</summary>
    public class WarningCount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The warning reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The count of records that have a warning.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Warning counts for each type of warning.</summary>
    public class WarningInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of warnings and counts per warning reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warningCounts")]
        public virtual System.Collections.Generic.IList<WarningCount> WarningCounts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
