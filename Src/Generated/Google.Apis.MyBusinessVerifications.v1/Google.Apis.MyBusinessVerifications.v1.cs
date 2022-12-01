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

namespace Google.Apis.MyBusinessVerifications.v1
{
    /// <summary>The MyBusinessVerifications Service.</summary>
    public class MyBusinessVerificationsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public MyBusinessVerificationsService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public MyBusinessVerificationsService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Locations = new LocationsResource(this);
            VerificationTokens = new VerificationTokensResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "mybusinessverifications";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri => BaseUriOverride ?? "https://mybusinessverifications.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://mybusinessverifications.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Gets the Locations resource.</summary>
        public virtual LocationsResource Locations { get; }

        /// <summary>Gets the VerificationTokens resource.</summary>
        public virtual VerificationTokensResource VerificationTokens { get; }
    }

    /// <summary>A base abstract class for MyBusinessVerifications requests.</summary>
    public abstract class MyBusinessVerificationsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new MyBusinessVerificationsBaseServiceRequest instance.</summary>
        protected MyBusinessVerificationsBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes MyBusinessVerifications parameter list.</summary>
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
            Verifications = new VerificationsResource(service);
        }

        /// <summary>Gets the Verifications resource.</summary>
        public virtual VerificationsResource Verifications { get; }

        /// <summary>The "verifications" collection of methods.</summary>
        public class VerificationsResource
        {
            private const string Resource = "verifications";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public VerificationsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Completes a `PENDING` verification. It is only necessary for non `AUTO` verification methods. `AUTO`
            /// verification request is instantly `VERIFIED` upon creation.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. Resource name of the verification to complete.</param>
            public virtual CompleteRequest Complete(Google.Apis.MyBusinessVerifications.v1.Data.CompleteVerificationRequest body, string name)
            {
                return new CompleteRequest(service, body, name);
            }

            /// <summary>
            /// Completes a `PENDING` verification. It is only necessary for non `AUTO` verification methods. `AUTO`
            /// verification request is instantly `VERIFIED` upon creation.
            /// </summary>
            public class CompleteRequest : MyBusinessVerificationsBaseServiceRequest<Google.Apis.MyBusinessVerifications.v1.Data.CompleteVerificationResponse>
            {
                /// <summary>Constructs a new Complete request.</summary>
                public CompleteRequest(Google.Apis.Services.IClientService service, Google.Apis.MyBusinessVerifications.v1.Data.CompleteVerificationRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Resource name of the verification to complete.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.MyBusinessVerifications.v1.Data.CompleteVerificationRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "complete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:complete";

                /// <summary>Initializes Complete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^locations/[^/]+/verifications/[^/]+$",
                    });
                }
            }

            /// <summary>List verifications of a location, ordered by create time.</summary>
            /// <param name="parent">
            /// Required. Resource name of the location that verification requests belong to.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>List verifications of a location, ordered by create time.</summary>
            public class ListRequest : MyBusinessVerificationsBaseServiceRequest<Google.Apis.MyBusinessVerifications.v1.Data.ListVerificationsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. Resource name of the location that verification requests belong to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// How many verification to include per page. Minimum is 1, and the default and maximum page size is
                /// 100.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>If specified, returns the next page of verifications.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/verifications";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^locations/[^/]+$",
                    });
                    RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Reports all eligible verification options for a location in a specific language.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="location">Required. The location to verify.</param>
        public virtual FetchVerificationOptionsRequest FetchVerificationOptions(Google.Apis.MyBusinessVerifications.v1.Data.FetchVerificationOptionsRequest body, string location)
        {
            return new FetchVerificationOptionsRequest(service, body, location);
        }

        /// <summary>Reports all eligible verification options for a location in a specific language.</summary>
        public class FetchVerificationOptionsRequest : MyBusinessVerificationsBaseServiceRequest<Google.Apis.MyBusinessVerifications.v1.Data.FetchVerificationOptionsResponse>
        {
            /// <summary>Constructs a new FetchVerificationOptions request.</summary>
            public FetchVerificationOptionsRequest(Google.Apis.Services.IClientService service, Google.Apis.MyBusinessVerifications.v1.Data.FetchVerificationOptionsRequest body, string location) : base(service)
            {
                Location = location;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The location to verify.</summary>
            [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Location { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.MyBusinessVerifications.v1.Data.FetchVerificationOptionsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "fetchVerificationOptions";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+location}:fetchVerificationOptions";

            /// <summary>Initializes FetchVerificationOptions parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                {
                    Name = "location",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^locations/[^/]+$",
                });
            }
        }

        /// <summary>Gets the VoiceOfMerchant state.</summary>
        /// <param name="name">Required. Resource name of the location.</param>
        public virtual GetVoiceOfMerchantStateRequest GetVoiceOfMerchantState(string name)
        {
            return new GetVoiceOfMerchantStateRequest(service, name);
        }

        /// <summary>Gets the VoiceOfMerchant state.</summary>
        public class GetVoiceOfMerchantStateRequest : MyBusinessVerificationsBaseServiceRequest<Google.Apis.MyBusinessVerifications.v1.Data.VoiceOfMerchantState>
        {
            /// <summary>Constructs a new GetVoiceOfMerchantState request.</summary>
            public GetVoiceOfMerchantStateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. Resource name of the location.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getVoiceOfMerchantState";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}/VoiceOfMerchantState";

            /// <summary>Initializes GetVoiceOfMerchantState parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^locations/[^/]+$",
                });
            }
        }

        /// <summary>Starts the verification process for a location.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">Required. Resource name of the location to verify.</param>
        public virtual VerifyRequest Verify(Google.Apis.MyBusinessVerifications.v1.Data.VerifyLocationRequest body, string name)
        {
            return new VerifyRequest(service, body, name);
        }

        /// <summary>Starts the verification process for a location.</summary>
        public class VerifyRequest : MyBusinessVerificationsBaseServiceRequest<Google.Apis.MyBusinessVerifications.v1.Data.VerifyLocationResponse>
        {
            /// <summary>Constructs a new Verify request.</summary>
            public VerifyRequest(Google.Apis.Services.IClientService service, Google.Apis.MyBusinessVerifications.v1.Data.VerifyLocationRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Resource name of the location to verify.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.MyBusinessVerifications.v1.Data.VerifyLocationRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "verify";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}:verify";

            /// <summary>Initializes Verify parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^locations/[^/]+$",
                });
            }
        }
    }

    /// <summary>The "verificationTokens" collection of methods.</summary>
    public class VerificationTokensResource
    {
        private const string Resource = "verificationTokens";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public VerificationTokensResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Generates a token for the provided location data as a vetted
        /// [partner](https://support.google.com/business/answer/7674102). Throws PERMISSION_DENIED if the caller is not
        /// a vetted partner account. Throws FAILED_PRECONDITION if the caller's VettedStatus is INVALID.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual GenerateRequest Generate(Google.Apis.MyBusinessVerifications.v1.Data.GenerateVerificationTokenRequest body)
        {
            return new GenerateRequest(service, body);
        }

        /// <summary>
        /// Generates a token for the provided location data as a vetted
        /// [partner](https://support.google.com/business/answer/7674102). Throws PERMISSION_DENIED if the caller is not
        /// a vetted partner account. Throws FAILED_PRECONDITION if the caller's VettedStatus is INVALID.
        /// </summary>
        public class GenerateRequest : MyBusinessVerificationsBaseServiceRequest<Google.Apis.MyBusinessVerifications.v1.Data.GenerateVerificationTokenResponse>
        {
            /// <summary>Constructs a new Generate request.</summary>
            public GenerateRequest(Google.Apis.Services.IClientService service, Google.Apis.MyBusinessVerifications.v1.Data.GenerateVerificationTokenRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.MyBusinessVerifications.v1.Data.GenerateVerificationTokenRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "generate";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/verificationTokens:generate";

            /// <summary>Initializes Generate parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }
}
namespace Google.Apis.MyBusinessVerifications.v1.Data
{
    /// <summary>Display data for verifications through postcard.</summary>
    public class AddressVerificationData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Address that a postcard can be sent to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual PostalAddress Address { get; set; }

        /// <summary>Merchant's business name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("business")]
        public virtual string Business { get; set; }

        /// <summary>Expected number of days it takes to deliver a postcard to the address's region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expectedDeliveryDaysRegion")]
        public virtual System.Nullable<int> ExpectedDeliveryDaysRegion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for Verifications.CompleteVerificationAction.</summary>
    public class CompleteVerificationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. PIN code received by the merchant to complete the verification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pin")]
        public virtual string Pin { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for Verifications.CompleteVerificationAction.</summary>
    public class CompleteVerificationResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The completed verification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verification")]
        public virtual Verification Verification { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Indicates that the location fails to comply with our
    /// [guidelines](https://support.google.com/business/answer/3038177).
    /// </summary>
    public class ComplyWithGuidelines : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The reason why the location is being recommended to comply with guidelines.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recommendationReason")]
        public virtual string RecommendationReason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Display data for verifications through email.</summary>
    public class EmailVerificationData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Domain name in the email address. e.g. "gmail.com" in foo@gmail.com</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>Whether client is allowed to provide a different user name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isUserNameEditable")]
        public virtual System.Nullable<bool> IsUserNameEditable { get; set; }

        /// <summary>User name in the email address. e.g. "foo" in foo@gmail.com</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual string User { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for Verifications.FetchVerificationOptions.</summary>
    public class FetchVerificationOptionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Extra context information for the verification of service businesses. Can only be applied to the
        /// locations whose business type is CUSTOMER_LOCATION_ONLY. Specifying an accurate address could enable more
        /// options. INVALID_ARGUMENT will be thrown if it is set for other business types of locations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("context")]
        public virtual ServiceBusinessContext Context { get; set; }

        /// <summary>
        /// Required. The BCP 47 language code representing the language that is to be used for the verification
        /// process. Available options vary by language.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for Verifications.FetchVerificationOptions.</summary>
    public class FetchVerificationOptionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The available verification options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual System.Collections.Generic.IList<VerificationOption> Options { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for Verifications.GenerateVerificationToken.</summary>
    public class GenerateVerificationTokenRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The target location. Note: The location information should exactly match the target Location,
        /// otherwise the generated verification token won't be able to verify the target Location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual Location Location { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for Verifications.GenerateVerificationToken.</summary>
    public class GenerateVerificationTokenResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The generated token to verify the location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual VerificationToken Token { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for Verifications.ListVerifications.</summary>
    public class ListVerificationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the number of verifications exceeded the requested page size, this field will be populated with a token
        /// to fetch the next page of verification on a subsequent call. If there are no more attributes, this field
        /// will not be present in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of the verifications.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verifications")]
        public virtual System.Collections.Generic.IList<Verification> Verifications { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A subset of location info. See the [help center article] (https://support.google.com/business/answer/3038177)
    /// for a detailed description of these fields, or the [category
    /// endpoint](/my-business/reference/rest/v4/categories) for a list of valid business categories.
    /// </summary>
    public class Location : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A precise, accurate address to describe your business location. PO boxes or mailboxes located at
        /// remote locations are not acceptable. At this time, you can specify a maximum of five `address_lines` values
        /// in the address.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual PostalAddress Address { get; set; }

        /// <summary>
        /// Required. Location name should reflect your business's real-world name, as used consistently on your
        /// storefront, website, and stationery, and as known to customers. Any additional information, when relevant,
        /// can be included in other fields of the resource (for example, `Address`, `Categories`). Don't add
        /// unnecessary information to your name (for example, prefer "Google" over "Google Inc. - Mountain View
        /// Corporate Headquarters"). Don't include marketing taglines, store codes, special characters, hours or
        /// closed/open status, phone numbers, website URLs, service/product information, location/address or
        /// directions, or containment information (for example, "Chase ATM in Duane Reade").
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. Id of the category that best describes the core business this location engages in. e.g.
        /// gcid:bakery.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryCategoryId")]
        public virtual string PrimaryCategoryId { get; set; }

        /// <summary>
        /// Optional. A phone number that connects to your individual business location as directly as possible. Use a
        /// local phone number instead of a central, call center helpline number whenever possible.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryPhone")]
        public virtual string PrimaryPhone { get; set; }

        /// <summary>
        /// Optional. A URL for this business. If possible, use a URL that represents this individual business location
        /// instead of a generic website/URL that represents all locations, or the brand.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("websiteUri")]
        public virtual string WebsiteUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a postal address, e.g. for postal delivery or payments addresses. Given a postal address, a postal
    /// service can deliver items to a premise, P.O. Box or similar. It is not intended to model geographical locations
    /// (roads, towns, mountains). In typical usage an address would be created via user input or from importing
    /// existing data, depending on the type of process. Advice on address input / editing: - Use an
    /// internationalization-ready address widget such as https://github.com/google/libaddressinput) - Users should not
    /// be presented with UI elements for input or editing of fields outside countries where that field is used. For
    /// more guidance on how to use this schema, please see: https://support.google.com/business/answer/6397478
    /// </summary>
    public class PostalAddress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Unstructured address lines describing the lower levels of an address. Because values in address_lines do not
        /// have type information and may sometimes contain multiple values in a single field (e.g. "Austin, TX"), it is
        /// important that the line order is clear. The order of address lines should be "envelope order" for the
        /// country/region of the address. In places where this can vary (e.g. Japan), address_language is used to make
        /// it explicit (e.g. "ja" for large-to-small ordering and "ja-Latn" or "en" for small-to-large). This way, the
        /// most specific line of an address can be selected based on the language. The minimum permitted structural
        /// representation of an address consists of a region_code with all remaining information placed in the
        /// address_lines. It would be possible to format such an address very approximately without geocoding, but no
        /// semantic reasoning could be made about any of the address components until it was at least partially
        /// resolved. Creating an address only containing a region_code and address_lines, and then geocoding is the
        /// recommended way to handle completely unstructured addresses (as opposed to guessing which parts of the
        /// address should be localities or administrative areas).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addressLines")]
        public virtual System.Collections.Generic.IList<string> AddressLines { get; set; }

        /// <summary>
        /// Optional. Highest administrative subdivision which is used for postal addresses of a country or region. For
        /// example, this can be a state, a province, an oblast, or a prefecture. Specifically, for Spain this is the
        /// province and not the autonomous community (e.g. "Barcelona" and not "Catalonia"). Many countries don't use
        /// an administrative area in postal addresses. E.g. in Switzerland this should be left unpopulated.
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
        /// Optional. Generally refers to the city/town portion of the address. Examples: US city, IT comune, UK post
        /// town. In regions of the world where localities are not well defined or do not fit into this structure well,
        /// leave locality empty and use address_lines.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locality")]
        public virtual string Locality { get; set; }

        /// <summary>Optional. The name of the organization at the address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organization")]
        public virtual string Organization { get; set; }

        /// <summary>
        /// Optional. Postal code of the address. Not all countries use or require postal codes to be present, but where
        /// they are used, they may trigger additional validation with other parts of the address (e.g. state/zip
        /// validation in the U.S.A.).
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
        /// the value is either a string like "CEDEX", optionally followed by a number (e.g. "CEDEX 7"), or just a
        /// number alone, representing the "sector code" (Jamaica), "delivery area indicator" (Malawi) or "post office
        /// indicator" (e.g. Côte d'Ivoire).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sortingCode")]
        public virtual string SortingCode { get; set; }

        /// <summary>
        /// Optional. Sublocality of the address. For example, this can be neighborhoods, boroughs, districts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sublocality")]
        public virtual string Sublocality { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Indicates that the location duplicates another location that is in good standing.</summary>
    public class ResolveOwnershipConflict : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional data for service business verification.</summary>
    public class ServiceBusinessContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The verification address of the location. It is used to either enable more verification options or send a
        /// postcard.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual PostalAddress Address { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A verification represents a verification attempt on a location.</summary>
    public class Verification : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The timestamp when the verification is requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The method of the verification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual string Method { get; set; }

        /// <summary>Resource name of the verification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The state of the verification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The verification option represents how to verify the location (indicated by verification method) and where the
    /// verification will be sent to (indicated by display data).
    /// </summary>
    public class VerificationOption : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Set only if the method is MAIL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addressData")]
        public virtual AddressVerificationData AddressData { get; set; }

        /// <summary>Set only if the method is EMAIL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailData")]
        public virtual EmailVerificationData EmailData { get; set; }

        /// <summary>Set only if the method is PHONE_CALL or SMS. Phone number that the PIN will be sent to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneNumber")]
        public virtual string PhoneNumber { get; set; }

        /// <summary>Method to verify the location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verificationMethod")]
        public virtual string VerificationMethod { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Token generated by a vetted [partner](https://support.google.com/business/answer/7674102).</summary>
    public class VerificationToken : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The token string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokenString")]
        public virtual string TokenString { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Indicates that the location requires verification. Contains information about the current verification actions
    /// performed on the location.
    /// </summary>
    public class Verify : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Indicates whether a verification process has already started, and can be completed by the location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasPendingVerification")]
        public virtual System.Nullable<bool> HasPendingVerification { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for Verifications.VerifyLocation.</summary>
    public class VerifyLocationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Extra context information for the verification of service businesses. It is only required for the
        /// locations whose business type is CUSTOMER_LOCATION_ONLY. For ADDRESS verification, the address will be used
        /// to send out postcard. For other methods, it should be the same as the one that is passed to
        /// GetVerificationOptions. INVALID_ARGUMENT will be thrown if it is set for other types of business locations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("context")]
        public virtual ServiceBusinessContext Context { get; set; }

        /// <summary>
        /// Optional. The input for EMAIL method. Email address where the PIN should be sent to. An email address is
        /// accepted only if it is one of the addresses provided by FetchVerificationOptions. If the
        /// EmailVerificationData has is_user_name_editable set to true, the client may specify a different user name
        /// (local-part) but must match the domain name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailAddress")]
        public virtual string EmailAddress { get; set; }

        /// <summary>
        /// Optional. The BCP 47 language code representing the language that is to be used for the verification
        /// process.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>Optional. The input for ADDRESS method. Contact name the mail should be sent to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mailerContact")]
        public virtual string MailerContact { get; set; }

        /// <summary>Required. Verification method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual string Method { get; set; }

        /// <summary>
        /// Optional. The input for PHONE_CALL/SMS method The phone number that should be called or be sent SMS to. It
        /// must be one of the phone numbers in the eligible options.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneNumber")]
        public virtual string PhoneNumber { get; set; }

        /// <summary>
        /// Optional. The input for VETTED_PARTNER method available to select
        /// [partners.](https://support.google.com/business/answer/7674102) The input is not needed for a vetted
        /// account. Token that is associated to the location. Token that is associated to the location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual VerificationToken Token { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for Verifications.VerifyLocation.</summary>
    public class VerifyLocationResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The created verification request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verification")]
        public virtual Verification Verification { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for VoiceOfMerchant.GetVoiceOfMerchantState.</summary>
    public class VoiceOfMerchantState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The location fails to comply with our [guidelines](https://support.google.com/business/answer/3038177) and
        /// requires additional steps for reinstatement. To fix this issue, consult the [Help Center
        /// Article](https://support.google.com/business/answer/4569145).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("complyWithGuidelines")]
        public virtual ComplyWithGuidelines ComplyWithGuidelines { get; set; }

        /// <summary>
        /// Indicates whether the location has the authority (ownership) over the business on Google. If true, another
        /// location cannot take over and become the dominant listing on Maps. However, edits will not become live
        /// unless Voice of Merchant is gained (i.e. has_voice_of_merchant is true).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasBusinessAuthority")]
        public virtual System.Nullable<bool> HasBusinessAuthority { get; set; }

        /// <summary>
        /// Indicates whether the location is in good standing and has control over the business on Google. Any edits
        /// made to the location will propagate to Maps after passing the review phase.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasVoiceOfMerchant")]
        public virtual System.Nullable<bool> HasVoiceOfMerchant { get; set; }

        /// <summary>
        /// This location duplicates another location that is in good standing. If you have access to the location in
        /// good standing, use that location's id to perform operations. Otherwise, request access from the current
        /// owner.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolveOwnershipConflict")]
        public virtual ResolveOwnershipConflict ResolveOwnershipConflict { get; set; }

        /// <summary>Start or continue the verification process.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verify")]
        public virtual Verify Verify { get; set; }

        /// <summary>Wait to gain Voice of Merchant. The location is under review for quality purposes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("waitForVoiceOfMerchant")]
        public virtual WaitForVoiceOfMerchant WaitForVoiceOfMerchant { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Indicates that the location will gain voice of merchant after passing review.</summary>
    public class WaitForVoiceOfMerchant : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
