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

namespace Google.Apis.Merchant.accounts_v1beta
{
    /// <summary>The Merchant Service.</summary>
    public class MerchantService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "accounts_v1beta";

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
            TermsOfService = new TermsOfServiceResource(this);
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

        /// <summary>Gets the TermsOfService resource.</summary>
        public virtual TermsOfServiceResource TermsOfService { get; }
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
            AutofeedSettings = new AutofeedSettingsResource(service);
            AutomaticImprovements = new AutomaticImprovementsResource(service);
            BusinessIdentity = new BusinessIdentityResource(service);
            BusinessInfo = new BusinessInfoResource(service);
            EmailPreferences = new EmailPreferencesResource(service);
            Homepage = new HomepageResource(service);
            Issues = new IssuesResource(service);
            OnlineReturnPolicies = new OnlineReturnPoliciesResource(service);
            Programs = new ProgramsResource(service);
            Regions = new RegionsResource(service);
            Relationships = new RelationshipsResource(service);
            Services = new ServicesResource(service);
            ShippingSettings = new ShippingSettingsResource(service);
            TermsOfServiceAgreementStates = new TermsOfServiceAgreementStatesResource(service);
            Users = new UsersResource(service);
        }

        /// <summary>Gets the AutofeedSettings resource.</summary>
        public virtual AutofeedSettingsResource AutofeedSettings { get; }

        /// <summary>The "autofeedSettings" collection of methods.</summary>
        public class AutofeedSettingsResource
        {
            private const string Resource = "autofeedSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AutofeedSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Retrieves the autofeed settings of an account.</summary>
            /// <param name="name">
            /// Required. The resource name of the autofeed settings. Format: `accounts/{account}/autofeedSettings`
            /// </param>
            public virtual GetAutofeedSettingsRequest GetAutofeedSettings(string name)
            {
                return new GetAutofeedSettingsRequest(this.service, name);
            }

            /// <summary>Retrieves the autofeed settings of an account.</summary>
            public class GetAutofeedSettingsRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.AutofeedSettings>
            {
                /// <summary>Constructs a new GetAutofeedSettings request.</summary>
                public GetAutofeedSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the autofeed settings. Format: `accounts/{account}/autofeedSettings`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getAutofeedSettings";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+name}";

                /// <summary>Initializes GetAutofeedSettings parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+/autofeedSettings$",
                    });
                }
            }

            /// <summary>Updates the autofeed settings of an account.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Identifier. The resource name of the autofeed settings. Format: `accounts/{account}/autofeedSettings`.
            /// </param>
            public virtual UpdateAutofeedSettingsRequest UpdateAutofeedSettings(Google.Apis.Merchant.accounts_v1beta.Data.AutofeedSettings body, string name)
            {
                return new UpdateAutofeedSettingsRequest(this.service, body, name);
            }

            /// <summary>Updates the autofeed settings of an account.</summary>
            public class UpdateAutofeedSettingsRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.AutofeedSettings>
            {
                /// <summary>Constructs a new UpdateAutofeedSettings request.</summary>
                public UpdateAutofeedSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.Merchant.accounts_v1beta.Data.AutofeedSettings body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifier. The resource name of the autofeed settings. Format:
                /// `accounts/{account}/autofeedSettings`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Required. List of fields being updated.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Merchant.accounts_v1beta.Data.AutofeedSettings Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "updateAutofeedSettings";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+name}";

                /// <summary>Initializes UpdateAutofeedSettings parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+/autofeedSettings$",
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

        /// <summary>Gets the AutomaticImprovements resource.</summary>
        public virtual AutomaticImprovementsResource AutomaticImprovements { get; }

        /// <summary>The "automaticImprovements" collection of methods.</summary>
        public class AutomaticImprovementsResource
        {
            private const string Resource = "automaticImprovements";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AutomaticImprovementsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Retrieves the automatic improvements of an account.</summary>
            /// <param name="name">
            /// Required. The resource name of the automatic improvements. Format:
            /// `accounts/{account}/automaticImprovements`
            /// </param>
            public virtual GetAutomaticImprovementsRequest GetAutomaticImprovements(string name)
            {
                return new GetAutomaticImprovementsRequest(this.service, name);
            }

            /// <summary>Retrieves the automatic improvements of an account.</summary>
            public class GetAutomaticImprovementsRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.AutomaticImprovements>
            {
                /// <summary>Constructs a new GetAutomaticImprovements request.</summary>
                public GetAutomaticImprovementsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the automatic improvements. Format:
                /// `accounts/{account}/automaticImprovements`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getAutomaticImprovements";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+name}";

                /// <summary>Initializes GetAutomaticImprovements parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+/automaticImprovements$",
                    });
                }
            }

            /// <summary>Updates the automatic improvements of an account.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Identifier. The resource name of the automatic improvements. Format:
            /// `accounts/{account}/automaticImprovements`.
            /// </param>
            public virtual UpdateAutomaticImprovementsRequest UpdateAutomaticImprovements(Google.Apis.Merchant.accounts_v1beta.Data.AutomaticImprovements body, string name)
            {
                return new UpdateAutomaticImprovementsRequest(this.service, body, name);
            }

            /// <summary>Updates the automatic improvements of an account.</summary>
            public class UpdateAutomaticImprovementsRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.AutomaticImprovements>
            {
                /// <summary>Constructs a new UpdateAutomaticImprovements request.</summary>
                public UpdateAutomaticImprovementsRequest(Google.Apis.Services.IClientService service, Google.Apis.Merchant.accounts_v1beta.Data.AutomaticImprovements body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifier. The resource name of the automatic improvements. Format:
                /// `accounts/{account}/automaticImprovements`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Required. List of fields being updated. The following fields are supported (in both `snake_case` and
                /// `lowerCamelCase`): - `item_updates` - `item_updates.account_level_settings` - `image_improvements` -
                /// `image_improvements.account_level_settings` - `shipping_improvements` -
                /// `shipping_improvements.allow_shipping_improvements`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Merchant.accounts_v1beta.Data.AutomaticImprovements Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "updateAutomaticImprovements";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+name}";

                /// <summary>Initializes UpdateAutomaticImprovements parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+/automaticImprovements$",
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

        /// <summary>Gets the BusinessIdentity resource.</summary>
        public virtual BusinessIdentityResource BusinessIdentity { get; }

        /// <summary>The "businessIdentity" collection of methods.</summary>
        public class BusinessIdentityResource
        {
            private const string Resource = "businessIdentity";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public BusinessIdentityResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Retrieves the business identity of an account.</summary>
            /// <param name="name">
            /// Required. The resource name of the business identity. Format: `accounts/{account}/businessIdentity`
            /// </param>
            public virtual GetBusinessIdentityRequest GetBusinessIdentity(string name)
            {
                return new GetBusinessIdentityRequest(this.service, name);
            }

            /// <summary>Retrieves the business identity of an account.</summary>
            public class GetBusinessIdentityRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.BusinessIdentity>
            {
                /// <summary>Constructs a new GetBusinessIdentity request.</summary>
                public GetBusinessIdentityRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the business identity. Format: `accounts/{account}/businessIdentity`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getBusinessIdentity";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+name}";

                /// <summary>Initializes GetBusinessIdentity parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+/businessIdentity$",
                    });
                }
            }

            /// <summary>
            /// Updates the business identity of an account. Executing this method requires admin access.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Identifier. The resource name of the business identity. Format: `accounts/{account}/businessIdentity`
            /// </param>
            public virtual UpdateBusinessIdentityRequest UpdateBusinessIdentity(Google.Apis.Merchant.accounts_v1beta.Data.BusinessIdentity body, string name)
            {
                return new UpdateBusinessIdentityRequest(this.service, body, name);
            }

            /// <summary>
            /// Updates the business identity of an account. Executing this method requires admin access.
            /// </summary>
            public class UpdateBusinessIdentityRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.BusinessIdentity>
            {
                /// <summary>Constructs a new UpdateBusinessIdentity request.</summary>
                public UpdateBusinessIdentityRequest(Google.Apis.Services.IClientService service, Google.Apis.Merchant.accounts_v1beta.Data.BusinessIdentity body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifier. The resource name of the business identity. Format:
                /// `accounts/{account}/businessIdentity`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. List of fields being updated. The following fields are supported (in both `snake_case` and
                /// `lowerCamelCase`): - `black_owned` - `latino_owned` - `promotions_consent` - `small_business` -
                /// `veteran_owned` - `women_owned`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Merchant.accounts_v1beta.Data.BusinessIdentity Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "updateBusinessIdentity";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+name}";

                /// <summary>Initializes UpdateBusinessIdentity parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+/businessIdentity$",
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

        /// <summary>Gets the BusinessInfo resource.</summary>
        public virtual BusinessInfoResource BusinessInfo { get; }

        /// <summary>The "businessInfo" collection of methods.</summary>
        public class BusinessInfoResource
        {
            private const string Resource = "businessInfo";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public BusinessInfoResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Retrieves the business info of an account.</summary>
            /// <param name="name">
            /// Required. The resource name of the business info. Format: `accounts/{account}/businessInfo`
            /// </param>
            public virtual GetBusinessInfoRequest GetBusinessInfo(string name)
            {
                return new GetBusinessInfoRequest(this.service, name);
            }

            /// <summary>Retrieves the business info of an account.</summary>
            public class GetBusinessInfoRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.BusinessInfo>
            {
                /// <summary>Constructs a new GetBusinessInfo request.</summary>
                public GetBusinessInfoRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the business info. Format: `accounts/{account}/businessInfo`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getBusinessInfo";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+name}";

                /// <summary>Initializes GetBusinessInfo parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+/businessInfo$",
                    });
                }
            }

            /// <summary>Updates the business info of an account. Executing this method requires admin access.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Identifier. The resource name of the business info. Format: `accounts/{account}/businessInfo`
            /// </param>
            public virtual UpdateBusinessInfoRequest UpdateBusinessInfo(Google.Apis.Merchant.accounts_v1beta.Data.BusinessInfo body, string name)
            {
                return new UpdateBusinessInfoRequest(this.service, body, name);
            }

            /// <summary>Updates the business info of an account. Executing this method requires admin access.</summary>
            public class UpdateBusinessInfoRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.BusinessInfo>
            {
                /// <summary>Constructs a new UpdateBusinessInfo request.</summary>
                public UpdateBusinessInfoRequest(Google.Apis.Services.IClientService service, Google.Apis.Merchant.accounts_v1beta.Data.BusinessInfo body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifier. The resource name of the business info. Format: `accounts/{account}/businessInfo`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. List of fields being updated. The following fields are supported (in both `snake_case` and
                /// `lowerCamelCase`): - `address` - `customer_service` - `korean_business_registration_number`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Merchant.accounts_v1beta.Data.BusinessInfo Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "updateBusinessInfo";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+name}";

                /// <summary>Initializes UpdateBusinessInfo parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+/businessInfo$",
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

        /// <summary>Gets the EmailPreferences resource.</summary>
        public virtual EmailPreferencesResource EmailPreferences { get; }

        /// <summary>The "emailPreferences" collection of methods.</summary>
        public class EmailPreferencesResource
        {
            private const string Resource = "emailPreferences";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public EmailPreferencesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Returns the email preferences for a Merchant Center account user. This service only permits retrieving
            /// and updating email preferences for the authenticated user. Use the
            /// name=accounts/*/users/me/emailPreferences alias to get preferences for the authenticated user.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the `EmailPreferences` resource. Format:
            /// `accounts/{account}/users/{email}/emailPreferences`
            /// </param>
            public virtual GetEmailPreferencesRequest GetEmailPreferences(string name)
            {
                return new GetEmailPreferencesRequest(this.service, name);
            }

            /// <summary>
            /// Returns the email preferences for a Merchant Center account user. This service only permits retrieving
            /// and updating email preferences for the authenticated user. Use the
            /// name=accounts/*/users/me/emailPreferences alias to get preferences for the authenticated user.
            /// </summary>
            public class GetEmailPreferencesRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.EmailPreferences>
            {
                /// <summary>Constructs a new GetEmailPreferences request.</summary>
                public GetEmailPreferencesRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the `EmailPreferences` resource. Format:
                /// `accounts/{account}/users/{email}/emailPreferences`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getEmailPreferences";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+name}";

                /// <summary>Initializes GetEmailPreferences parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+/users/[^/]+/emailPreferences$",
                    });
                }
            }

            /// <summary>
            /// Updates the email preferences for a Merchant Center account user. MCA users should specify the MCA
            /// account rather than a sub-account of the MCA. Preferences which are not explicitly selected in the
            /// update mask will not be updated. It is invalid for updates to specify an UNCONFIRMED opt-in status
            /// value. Use the name=accounts/*/users/me/emailPreferences alias to update preferences for the
            /// authenticated user.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Identifier. The name of the EmailPreferences. The endpoint is only supported for the authenticated user.
            /// </param>
            public virtual UpdateEmailPreferencesRequest UpdateEmailPreferences(Google.Apis.Merchant.accounts_v1beta.Data.EmailPreferences body, string name)
            {
                return new UpdateEmailPreferencesRequest(this.service, body, name);
            }

            /// <summary>
            /// Updates the email preferences for a Merchant Center account user. MCA users should specify the MCA
            /// account rather than a sub-account of the MCA. Preferences which are not explicitly selected in the
            /// update mask will not be updated. It is invalid for updates to specify an UNCONFIRMED opt-in status
            /// value. Use the name=accounts/*/users/me/emailPreferences alias to update preferences for the
            /// authenticated user.
            /// </summary>
            public class UpdateEmailPreferencesRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.EmailPreferences>
            {
                /// <summary>Constructs a new UpdateEmailPreferences request.</summary>
                public UpdateEmailPreferencesRequest(Google.Apis.Services.IClientService service, Google.Apis.Merchant.accounts_v1beta.Data.EmailPreferences body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifier. The name of the EmailPreferences. The endpoint is only supported for the authenticated
                /// user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Required. List of fields being updated. The following fields are supported (in both `snake_case` and
                /// `lowerCamelCase`): - `news_and_tips`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Merchant.accounts_v1beta.Data.EmailPreferences Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "updateEmailPreferences";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+name}";

                /// <summary>Initializes UpdateEmailPreferences parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+/users/[^/]+/emailPreferences$",
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

        /// <summary>Gets the Homepage resource.</summary>
        public virtual HomepageResource Homepage { get; }

        /// <summary>The "homepage" collection of methods.</summary>
        public class HomepageResource
        {
            private const string Resource = "homepage";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public HomepageResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Claims a store's homepage. Executing this method requires admin access. If the homepage is already
            /// claimed, this will recheck the verification (unless the merchant is exempted from claiming, which also
            /// exempts from verification) and return a successful response. If ownership can no longer be verified, it
            /// will return an error, but it won't clear the claim. In case of failure, a canonical error message is
            /// returned: * PERMISSION_DENIED: User doesn't have the necessary permissions on this Merchant Center
            /// account. * FAILED_PRECONDITION: - The account is not a Merchant Center account. - Merchant Center
            /// account doesn't have a homepage. - Claiming failed (in this case the error message contains more
            /// details).
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The name of the homepage to claim. Format: `accounts/{account}/homepage`
            /// </param>
            public virtual ClaimRequest Claim(Google.Apis.Merchant.accounts_v1beta.Data.ClaimHomepageRequest body, string name)
            {
                return new ClaimRequest(this.service, body, name);
            }

            /// <summary>
            /// Claims a store's homepage. Executing this method requires admin access. If the homepage is already
            /// claimed, this will recheck the verification (unless the merchant is exempted from claiming, which also
            /// exempts from verification) and return a successful response. If ownership can no longer be verified, it
            /// will return an error, but it won't clear the claim. In case of failure, a canonical error message is
            /// returned: * PERMISSION_DENIED: User doesn't have the necessary permissions on this Merchant Center
            /// account. * FAILED_PRECONDITION: - The account is not a Merchant Center account. - Merchant Center
            /// account doesn't have a homepage. - Claiming failed (in this case the error message contains more
            /// details).
            /// </summary>
            public class ClaimRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.Homepage>
            {
                /// <summary>Constructs a new Claim request.</summary>
                public ClaimRequest(Google.Apis.Services.IClientService service, Google.Apis.Merchant.accounts_v1beta.Data.ClaimHomepageRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the homepage to claim. Format: `accounts/{account}/homepage`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Merchant.accounts_v1beta.Data.ClaimHomepageRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "claim";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+name}:claim";

                /// <summary>Initializes Claim parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+/homepage$",
                    });
                }
            }

            /// <summary>Retrieves a store's homepage.</summary>
            /// <param name="name">
            /// Required. The name of the homepage to retrieve. Format: `accounts/{account}/homepage`
            /// </param>
            public virtual GetHomepageRequest GetHomepage(string name)
            {
                return new GetHomepageRequest(this.service, name);
            }

            /// <summary>Retrieves a store's homepage.</summary>
            public class GetHomepageRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.Homepage>
            {
                /// <summary>Constructs a new GetHomepage request.</summary>
                public GetHomepageRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the homepage to retrieve. Format: `accounts/{account}/homepage`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getHomepage";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+name}";

                /// <summary>Initializes GetHomepage parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+/homepage$",
                    });
                }
            }

            /// <summary>Unclaims a store's homepage. Executing this method requires admin access.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The name of the homepage to unclaim. Format: `accounts/{account}/homepage`
            /// </param>
            public virtual UnclaimRequest Unclaim(Google.Apis.Merchant.accounts_v1beta.Data.UnclaimHomepageRequest body, string name)
            {
                return new UnclaimRequest(this.service, body, name);
            }

            /// <summary>Unclaims a store's homepage. Executing this method requires admin access.</summary>
            public class UnclaimRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.Homepage>
            {
                /// <summary>Constructs a new Unclaim request.</summary>
                public UnclaimRequest(Google.Apis.Services.IClientService service, Google.Apis.Merchant.accounts_v1beta.Data.UnclaimHomepageRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the homepage to unclaim. Format: `accounts/{account}/homepage`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Merchant.accounts_v1beta.Data.UnclaimHomepageRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "unclaim";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+name}:unclaim";

                /// <summary>Initializes Unclaim parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+/homepage$",
                    });
                }
            }

            /// <summary>Updates a store's homepage. Executing this method requires admin access.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Identifier. The resource name of the store's homepage. Format: `accounts/{account}/homepage`
            /// </param>
            public virtual UpdateHomepageRequest UpdateHomepage(Google.Apis.Merchant.accounts_v1beta.Data.Homepage body, string name)
            {
                return new UpdateHomepageRequest(this.service, body, name);
            }

            /// <summary>Updates a store's homepage. Executing this method requires admin access.</summary>
            public class UpdateHomepageRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.Homepage>
            {
                /// <summary>Constructs a new UpdateHomepage request.</summary>
                public UpdateHomepageRequest(Google.Apis.Services.IClientService service, Google.Apis.Merchant.accounts_v1beta.Data.Homepage body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifier. The resource name of the store's homepage. Format: `accounts/{account}/homepage`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. List of fields being updated. The following fields are supported (in both `snake_case` and
                /// `lowerCamelCase`): - `uri`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Merchant.accounts_v1beta.Data.Homepage Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "updateHomepage";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+name}";

                /// <summary>Initializes UpdateHomepage parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+/homepage$",
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

        /// <summary>Gets the Issues resource.</summary>
        public virtual IssuesResource Issues { get; }

        /// <summary>The "issues" collection of methods.</summary>
        public class IssuesResource
        {
            private const string Resource = "issues";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public IssuesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Lists all account issues of a Merchant Center account. When called on a multi-client account, this
            /// method only returns issues belonging to that account, not its sub-accounts. To retrieve issues for
            /// sub-accounts, you must first call the accounts.listSubaccounts method to obtain a list of sub-accounts,
            /// and then call `accounts.issues.list` for each sub-account individually.
            /// </summary>
            /// <param name="parent">
            /// Required. The parent, which owns this collection of issues. Format: `accounts/{account}`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>
            /// Lists all account issues of a Merchant Center account. When called on a multi-client account, this
            /// method only returns issues belonging to that account, not its sub-accounts. To retrieve issues for
            /// sub-accounts, you must first call the accounts.listSubaccounts method to obtain a list of sub-accounts,
            /// and then call `accounts.issues.list` for each sub-account individually.
            /// </summary>
            public class ListRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.ListAccountIssuesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent, which owns this collection of issues. Format: `accounts/{account}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The issues in the response will have human-readable fields in the given language. The
                /// format is [BCP-47](https://tools.ietf.org/html/bcp47), such as `en-US` or `sr-Latn`. If not value is
                /// provided, `en-US` will be used.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string LanguageCode { get; set; }

                /// <summary>
                /// Optional. The maximum number of issues to return. The service may return fewer than this value. If
                /// unspecified, at most 50 issues will be returned. The maximum value is 100; values above 100 will be
                /// coerced to 100
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A page token, received from a previous `ListAccountIssues` call. Provide this to retrieve
                /// the subsequent page. When paginating, all other parameters provided to `ListAccountIssues` must
                /// match the call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// Optional. The [IANA](https://www.iana.org/time-zones) timezone used to localize times in
                /// human-readable fields. For example 'America/Los_Angeles'. If not set, 'America/Los_Angeles' will be
                /// used.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("timeZone", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string TimeZone { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+parent}/issues";

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
                        Pattern = @"^accounts/[^/]+$",
                    });
                    RequestParameters.Add("languageCode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "languageCode",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
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
                    RequestParameters.Add("timeZone", new Google.Apis.Discovery.Parameter
                    {
                        Name = "timeZone",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the OnlineReturnPolicies resource.</summary>
        public virtual OnlineReturnPoliciesResource OnlineReturnPolicies { get; }

        /// <summary>The "onlineReturnPolicies" collection of methods.</summary>
        public class OnlineReturnPoliciesResource
        {
            private const string Resource = "onlineReturnPolicies";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public OnlineReturnPoliciesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Gets an existing return policy for a given merchant.</summary>
            /// <param name="name">
            /// Required. The name of the return policy to retrieve. Format:
            /// `accounts/{account}/onlineReturnPolicies/{return_policy}`
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets an existing return policy for a given merchant.</summary>
            public class GetRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.OnlineReturnPolicy>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the return policy to retrieve. Format:
                /// `accounts/{account}/onlineReturnPolicies/{return_policy}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+name}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+/onlineReturnPolicies/[^/]+$",
                    });
                }
            }

            /// <summary>Lists all existing return policies for a given merchant.</summary>
            /// <param name="parent">
            /// Required. The merchant account for which to list return policies. Format: `accounts/{account}`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists all existing return policies for a given merchant.</summary>
            public class ListRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.ListOnlineReturnPoliciesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The merchant account for which to list return policies. Format: `accounts/{account}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of `OnlineReturnPolicy` resources to return. The service returns fewer
                /// than this value if the number of return policies for the given merchant is less that than the
                /// `pageSize`. The default value is 10. The maximum value is 100; If a value higher than the maximum is
                /// specified, then the `pageSize` will default to the maximum
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A page token, received from a previous `ListOnlineReturnPolicies` call. Provide the page
                /// token to retrieve the subsequent page. When paginating, all other parameters provided to
                /// `ListOnlineReturnPolicies` must match the call that provided the page token. The token returned as
                /// nextPageToken in the response to the previous request.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+parent}/onlineReturnPolicies";

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
                        Pattern = @"^accounts/[^/]+$",
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

        /// <summary>Gets the Programs resource.</summary>
        public virtual ProgramsResource Programs { get; }

        /// <summary>The "programs" collection of methods.</summary>
        public class ProgramsResource
        {
            private const string Resource = "programs";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ProgramsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Disable participation in the specified program for the account. Executing this method requires admin
            /// access.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The name of the program for which to disable participation for the given account. Format:
            /// `accounts/{account}/programs/{program}`
            /// </param>
            public virtual DisableRequest Disable(Google.Apis.Merchant.accounts_v1beta.Data.DisableProgramRequest body, string name)
            {
                return new DisableRequest(this.service, body, name);
            }

            /// <summary>
            /// Disable participation in the specified program for the account. Executing this method requires admin
            /// access.
            /// </summary>
            public class DisableRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.Program>
            {
                /// <summary>Constructs a new Disable request.</summary>
                public DisableRequest(Google.Apis.Services.IClientService service, Google.Apis.Merchant.accounts_v1beta.Data.DisableProgramRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the program for which to disable participation for the given account. Format:
                /// `accounts/{account}/programs/{program}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Merchant.accounts_v1beta.Data.DisableProgramRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "disable";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+name}:disable";

                /// <summary>Initializes Disable parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+/programs/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Enable participation in the specified program for the account. Executing this method requires admin
            /// access.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The name of the program for which to enable participation for the given account. Format:
            /// `accounts/{account}/programs/{program}`
            /// </param>
            public virtual EnableRequest Enable(Google.Apis.Merchant.accounts_v1beta.Data.EnableProgramRequest body, string name)
            {
                return new EnableRequest(this.service, body, name);
            }

            /// <summary>
            /// Enable participation in the specified program for the account. Executing this method requires admin
            /// access.
            /// </summary>
            public class EnableRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.Program>
            {
                /// <summary>Constructs a new Enable request.</summary>
                public EnableRequest(Google.Apis.Services.IClientService service, Google.Apis.Merchant.accounts_v1beta.Data.EnableProgramRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the program for which to enable participation for the given account. Format:
                /// `accounts/{account}/programs/{program}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Merchant.accounts_v1beta.Data.EnableProgramRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "enable";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+name}:enable";

                /// <summary>Initializes Enable parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+/programs/[^/]+$",
                    });
                }
            }

            /// <summary>Retrieves the specified program for the account.</summary>
            /// <param name="name">
            /// Required. The name of the program to retrieve. Format: `accounts/{account}/programs/{program}`
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Retrieves the specified program for the account.</summary>
            public class GetRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.Program>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the program to retrieve. Format: `accounts/{account}/programs/{program}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+name}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+/programs/[^/]+$",
                    });
                }
            }

            /// <summary>Retrieves all programs for the account.</summary>
            /// <param name="parent">
            /// Required. The name of the account for which to retrieve all programs. Format: `accounts/{account}`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Retrieves all programs for the account.</summary>
            public class ListRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.ListProgramsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the account for which to retrieve all programs. Format: `accounts/{account}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of programs to return in a single response. If unspecified (or 0), a
                /// default size of 1000 is used. The maximum value is 1000; values above 1000 will be coerced to 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A continuation token, received from a previous `ListPrograms` call. Provide this to
                /// retrieve the next page.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+parent}/programs";

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
                        Pattern = @"^accounts/[^/]+$",
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

        /// <summary>Gets the Regions resource.</summary>
        public virtual RegionsResource Regions { get; }

        /// <summary>The "regions" collection of methods.</summary>
        public class RegionsResource
        {
            private const string Resource = "regions";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public RegionsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a region definition in your Merchant Center account. Executing this method requires admin
            /// access.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. The account to create a region for. Format: `accounts/{account}`</param>
            public virtual CreateRequest Create(Google.Apis.Merchant.accounts_v1beta.Data.Region body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Creates a region definition in your Merchant Center account. Executing this method requires admin
            /// access.
            /// </summary>
            public class CreateRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.Region>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Merchant.accounts_v1beta.Data.Region body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The account to create a region for. Format: `accounts/{account}`</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Required. The identifier for the region, unique over all regions of the same account.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("regionId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string RegionId { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Merchant.accounts_v1beta.Data.Region Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+parent}/regions";

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
                    RequestParameters.Add("regionId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "regionId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Deletes a region definition from your Merchant Center account. Executing this method requires admin
            /// access.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the region to delete. Format: `accounts/{account}/regions/{region}`
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>
            /// Deletes a region definition from your Merchant Center account. Executing this method requires admin
            /// access.
            /// </summary>
            public class DeleteRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the region to delete. Format: `accounts/{account}/regions/{region}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+name}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+/regions/[^/]+$",
                    });
                }
            }

            /// <summary>Retrieves a region defined in your Merchant Center account.</summary>
            /// <param name="name">
            /// Required. The name of the region to retrieve. Format: `accounts/{account}/regions/{region}`
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Retrieves a region defined in your Merchant Center account.</summary>
            public class GetRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.Region>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the region to retrieve. Format: `accounts/{account}/regions/{region}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+name}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+/regions/[^/]+$",
                    });
                }
            }

            /// <summary>Lists the regions in your Merchant Center account.</summary>
            /// <param name="parent">Required. The account to list regions for. Format: `accounts/{account}`</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists the regions in your Merchant Center account.</summary>
            public class ListRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.ListRegionsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. The account to list regions for. Format: `accounts/{account}`</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of regions to return. The service may return fewer than this value. If
                /// unspecified, at most 50 regions will be returned. The maximum value is 1000; values above 1000 will
                /// be coerced to 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A page token, received from a previous `ListRegions` call. Provide this to retrieve the
                /// subsequent page. When paginating, all other parameters provided to `ListRegions` must match the call
                /// that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+parent}/regions";

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
                        Pattern = @"^accounts/[^/]+$",
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

            /// <summary>
            /// Updates a region definition in your Merchant Center account. Executing this method requires admin
            /// access.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Identifier. The resource name of the region. Format: `accounts/{account}/regions/{region}`
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.Merchant.accounts_v1beta.Data.Region body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>
            /// Updates a region definition in your Merchant Center account. Executing this method requires admin
            /// access.
            /// </summary>
            public class PatchRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.Region>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Merchant.accounts_v1beta.Data.Region body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifier. The resource name of the region. Format: `accounts/{account}/regions/{region}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. The comma-separated field mask indicating the fields to update. Example:
                /// `"displayName,postalCodeArea.regionCode"`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Merchant.accounts_v1beta.Data.Region Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+name}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+/regions/[^/]+$",
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

        /// <summary>Gets the Relationships resource.</summary>
        public virtual RelationshipsResource Relationships { get; }

        /// <summary>The "relationships" collection of methods.</summary>
        public class RelationshipsResource
        {
            private const string Resource = "relationships";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public RelationshipsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Retrieve an account relationship.</summary>
            /// <param name="name">Required. The resource name of the account relationship to get.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Retrieve an account relationship.</summary>
            public class GetRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.AccountRelationship>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. The resource name of the account relationship to get.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+name}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+/relationships/[^/]+$",
                    });
                }
            }

            /// <summary>List account relationships for the specified account.</summary>
            /// <param name="parent">Required. The parent account of the account relationship to filter by.</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>List account relationships for the specified account.</summary>
            public class ListRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.ListAccountRelationshipsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. The parent account of the account relationship to filter by.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of elements to return in the response. Use for paging. If no
                /// `page_size` is specified, `100` is used as the default value. The maximum allowed value is `1000`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Optional. The token returned by the previous `list` request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+parent}/relationships";

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
                        Pattern = @"^accounts/[^/]+$",
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

            /// <summary>Updates the account relationship. Executing this method requires admin access.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Identifier. The resource name of the account relationship.</param>
            public virtual PatchRequest Patch(Google.Apis.Merchant.accounts_v1beta.Data.AccountRelationship body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>Updates the account relationship. Executing this method requires admin access.</summary>
            public class PatchRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.AccountRelationship>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Merchant.accounts_v1beta.Data.AccountRelationship body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Identifier. The resource name of the account relationship.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. List of fields being updated. The following fields are supported (in both `snake_case` and
                /// `lowerCamelCase`): - `account_id_alias`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Merchant.accounts_v1beta.Data.AccountRelationship Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+name}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+/relationships/[^/]+$",
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

        /// <summary>Gets the Services resource.</summary>
        public virtual ServicesResource Services { get; }

        /// <summary>The "services" collection of methods.</summary>
        public class ServicesResource
        {
            private const string Resource = "services";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ServicesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Approve an account service proposal.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. The resource name of the account service to approve.</param>
            public virtual ApproveRequest Approve(Google.Apis.Merchant.accounts_v1beta.Data.ApproveAccountServiceRequest body, string name)
            {
                return new ApproveRequest(this.service, body, name);
            }

            /// <summary>Approve an account service proposal.</summary>
            public class ApproveRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.AccountService>
            {
                /// <summary>Constructs a new Approve request.</summary>
                public ApproveRequest(Google.Apis.Services.IClientService service, Google.Apis.Merchant.accounts_v1beta.Data.ApproveAccountServiceRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The resource name of the account service to approve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Merchant.accounts_v1beta.Data.ApproveAccountServiceRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "approve";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+name}:approve";

                /// <summary>Initializes Approve parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+/services/[^/]+$",
                    });
                }
            }

            /// <summary>Retrieve an account service.</summary>
            /// <param name="name">Required. The resource name of the account service to get.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Retrieve an account service.</summary>
            public class GetRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.AccountService>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. The resource name of the account service to get.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+name}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+/services/[^/]+$",
                    });
                }
            }

            /// <summary>List account services for the specified accounts. Supports filtering.</summary>
            /// <param name="parent">Required. The parent account of the account service to filter by.</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>List account services for the specified accounts. Supports filtering.</summary>
            public class ListRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.ListAccountServicesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. The parent account of the account service to filter by.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of elements to return in the response. Use for paging. If no
                /// `page_size` is specified, `100` is used as the default value. The maximum allowed value is `1000`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Optional. The token returned by the previous `list` request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+parent}/services";

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
                        Pattern = @"^accounts/[^/]+$",
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

            /// <summary>Propose an account service.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. The resource name of the parent account for the service.</param>
            public virtual ProposeRequest Propose(Google.Apis.Merchant.accounts_v1beta.Data.ProposeAccountServiceRequest body, string parent)
            {
                return new ProposeRequest(this.service, body, parent);
            }

            /// <summary>Propose an account service.</summary>
            public class ProposeRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.AccountService>
            {
                /// <summary>Constructs a new Propose request.</summary>
                public ProposeRequest(Google.Apis.Services.IClientService service, Google.Apis.Merchant.accounts_v1beta.Data.ProposeAccountServiceRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The resource name of the parent account for the service.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Merchant.accounts_v1beta.Data.ProposeAccountServiceRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "propose";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+parent}/services:propose";

                /// <summary>Initializes Propose parameter list.</summary>
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
                }
            }

            /// <summary>Reject an account service (both proposed and approve services can be rejected).</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. The resource name of the account service to reject.</param>
            public virtual RejectRequest Reject(Google.Apis.Merchant.accounts_v1beta.Data.RejectAccountServiceRequest body, string name)
            {
                return new RejectRequest(this.service, body, name);
            }

            /// <summary>Reject an account service (both proposed and approve services can be rejected).</summary>
            public class RejectRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.Empty>
            {
                /// <summary>Constructs a new Reject request.</summary>
                public RejectRequest(Google.Apis.Services.IClientService service, Google.Apis.Merchant.accounts_v1beta.Data.RejectAccountServiceRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The resource name of the account service to reject.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Merchant.accounts_v1beta.Data.RejectAccountServiceRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "reject";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+name}:reject";

                /// <summary>Initializes Reject parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+/services/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the ShippingSettings resource.</summary>
        public virtual ShippingSettingsResource ShippingSettings { get; }

        /// <summary>The "shippingSettings" collection of methods.</summary>
        public class ShippingSettingsResource
        {
            private const string Resource = "shippingSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ShippingSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Retrieve shipping setting information.</summary>
            /// <param name="name">
            /// Required. The name of the shipping setting to retrieve. Format: `accounts/{account}/shippingsettings`
            /// </param>
            public virtual GetShippingSettingsRequest GetShippingSettings(string name)
            {
                return new GetShippingSettingsRequest(this.service, name);
            }

            /// <summary>Retrieve shipping setting information.</summary>
            public class GetShippingSettingsRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.ShippingSettings>
            {
                /// <summary>Constructs a new GetShippingSettings request.</summary>
                public GetShippingSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the shipping setting to retrieve. Format:
                /// `accounts/{account}/shippingsettings`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getShippingSettings";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+name}";

                /// <summary>Initializes GetShippingSettings parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+/shippingSettings$",
                    });
                }
            }

            /// <summary>
            /// Replace the shipping setting of a merchant with the request shipping setting. Executing this method
            /// requires admin access.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The account for which this shipping setting will be inserted. If you are using an advanced
            /// account, you must specify the unique identifier of the sub-account for which you want to insert the
            /// shipping setting. Format: `accounts/{ACCOUNT_ID}`
            /// </param>
            public virtual InsertRequest Insert(Google.Apis.Merchant.accounts_v1beta.Data.ShippingSettings body, string parent)
            {
                return new InsertRequest(this.service, body, parent);
            }

            /// <summary>
            /// Replace the shipping setting of a merchant with the request shipping setting. Executing this method
            /// requires admin access.
            /// </summary>
            public class InsertRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.ShippingSettings>
            {
                /// <summary>Constructs a new Insert request.</summary>
                public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Merchant.accounts_v1beta.Data.ShippingSettings body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The account for which this shipping setting will be inserted. If you are using an advanced
                /// account, you must specify the unique identifier of the sub-account for which you want to insert the
                /// shipping setting. Format: `accounts/{ACCOUNT_ID}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Merchant.accounts_v1beta.Data.ShippingSettings Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "insert";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+parent}/shippingSettings:insert";

                /// <summary>Initializes Insert parameter list.</summary>
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
                }
            }
        }

        /// <summary>Gets the TermsOfServiceAgreementStates resource.</summary>
        public virtual TermsOfServiceAgreementStatesResource TermsOfServiceAgreementStates { get; }

        /// <summary>The "termsOfServiceAgreementStates" collection of methods.</summary>
        public class TermsOfServiceAgreementStatesResource
        {
            private const string Resource = "termsOfServiceAgreementStates";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public TermsOfServiceAgreementStatesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Returns the state of a terms of service agreement.</summary>
            /// <param name="name">
            /// Required. The resource name of the terms of service version. Format:
            /// `accounts/{account}/termsOfServiceAgreementStates/{identifier}` The identifier format is:
            /// `{TermsOfServiceKind}-{country}`
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Returns the state of a terms of service agreement.</summary>
            public class GetRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.TermsOfServiceAgreementState>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the terms of service version. Format:
                /// `accounts/{account}/termsOfServiceAgreementStates/{identifier}` The identifier format is:
                /// `{TermsOfServiceKind}-{country}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+name}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+/termsOfServiceAgreementStates/[^/]+$",
                    });
                }
            }

            /// <summary>Retrieves the state of the agreement for the application terms of service.</summary>
            /// <param name="parent">
            /// Required. The account for which to get a TermsOfServiceAgreementState Format: `accounts/{account}`
            /// </param>
            public virtual RetrieveForApplicationRequest RetrieveForApplication(string parent)
            {
                return new RetrieveForApplicationRequest(this.service, parent);
            }

            /// <summary>Retrieves the state of the agreement for the application terms of service.</summary>
            public class RetrieveForApplicationRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.TermsOfServiceAgreementState>
            {
                /// <summary>Constructs a new RetrieveForApplication request.</summary>
                public RetrieveForApplicationRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The account for which to get a TermsOfServiceAgreementState Format: `accounts/{account}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "retrieveForApplication";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+parent}/termsOfServiceAgreementStates:retrieveForApplication";

                /// <summary>Initializes RetrieveForApplication parameter list.</summary>
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
                }
            }
        }

        /// <summary>Gets the Users resource.</summary>
        public virtual UsersResource Users { get; }

        /// <summary>The "users" collection of methods.</summary>
        public class UsersResource
        {
            private const string Resource = "users";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public UsersResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a Merchant Center account user. Executing this method requires admin access.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The resource name of the account for which a user will be created. Format:
            /// `accounts/{account}`
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Merchant.accounts_v1beta.Data.User body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>Creates a Merchant Center account user. Executing this method requires admin access.</summary>
            public class CreateRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.User>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Merchant.accounts_v1beta.Data.User body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the account for which a user will be created. Format:
                /// `accounts/{account}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Required. The email address of the user (for example, `john.doe@gmail.com`).</summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UserId { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Merchant.accounts_v1beta.Data.User Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+parent}/users";

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
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Deletes a Merchant Center account user. Executing this method requires admin access. The user to be
            /// deleted can't be the last admin user of that account. Also a user is protected from deletion if it is
            /// managed by Business Manager"
            /// </summary>
            /// <param name="name">
            /// Required. The name of the user to delete. Format: `accounts/{account}/users/{email}` It is also possible
            /// to delete the user corresponding to the caller by using `me` rather than an email address as in
            /// `accounts/{account}/users/me`.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>
            /// Deletes a Merchant Center account user. Executing this method requires admin access. The user to be
            /// deleted can't be the last admin user of that account. Also a user is protected from deletion if it is
            /// managed by Business Manager"
            /// </summary>
            public class DeleteRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the user to delete. Format: `accounts/{account}/users/{email}` It is also
                /// possible to delete the user corresponding to the caller by using `me` rather than an email address
                /// as in `accounts/{account}/users/me`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+name}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+/users/[^/]+$",
                    });
                }
            }

            /// <summary>Retrieves a Merchant Center account user.</summary>
            /// <param name="name">
            /// Required. The name of the user to retrieve. Format: `accounts/{account}/users/{email}` It is also
            /// possible to retrieve the user corresponding to the caller by using `me` rather than an email address as
            /// in `accounts/{account}/users/me`.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Retrieves a Merchant Center account user.</summary>
            public class GetRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.User>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the user to retrieve. Format: `accounts/{account}/users/{email}` It is also
                /// possible to retrieve the user corresponding to the caller by using `me` rather than an email address
                /// as in `accounts/{account}/users/me`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+name}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+/users/[^/]+$",
                    });
                }
            }

            /// <summary>Lists all users of a Merchant Center account.</summary>
            /// <param name="parent">
            /// Required. The parent, which owns this collection of users. Format: `accounts/{account}`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists all users of a Merchant Center account.</summary>
            public class ListRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.ListUsersResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent, which owns this collection of users. Format: `accounts/{account}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of users to return. The service may return fewer than this value. If
                /// unspecified, at most 50 users will be returned. The maximum value is 100; values above 100 will be
                /// coerced to 100
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A page token, received from a previous `ListUsers` call. Provide this to retrieve the
                /// subsequent page. When paginating, all other parameters provided to `ListUsers` must match the call
                /// that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+parent}/users";

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
                        Pattern = @"^accounts/[^/]+$",
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

            /// <summary>Updates a Merchant Center account user. Executing this method requires admin access.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Identifier. The resource name of the user. Format: `accounts/{account}/user/{email}` Use `me` to refer
            /// to your own email address, for example `accounts/{account}/users/me`.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.Merchant.accounts_v1beta.Data.User body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>Updates a Merchant Center account user. Executing this method requires admin access.</summary>
            public class PatchRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.User>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Merchant.accounts_v1beta.Data.User body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifier. The resource name of the user. Format: `accounts/{account}/user/{email}` Use `me` to
                /// refer to your own email address, for example `accounts/{account}/users/me`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. List of fields being updated. The following fields are supported (in both `snake_case` and
                /// `lowerCamelCase`): - `access_rights`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Merchant.accounts_v1beta.Data.User Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/v1beta/{+name}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+/users/[^/]+$",
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

        /// <summary>
        /// Creates a Merchant Center account with additional configuration. Adds the user that makes the request as an
        /// admin for the new account.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateAndConfigureRequest CreateAndConfigure(Google.Apis.Merchant.accounts_v1beta.Data.CreateAndConfigureAccountRequest body)
        {
            return new CreateAndConfigureRequest(this.service, body);
        }

        /// <summary>
        /// Creates a Merchant Center account with additional configuration. Adds the user that makes the request as an
        /// admin for the new account.
        /// </summary>
        public class CreateAndConfigureRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.Account>
        {
            /// <summary>Constructs a new CreateAndConfigure request.</summary>
            public CreateAndConfigureRequest(Google.Apis.Services.IClientService service, Google.Apis.Merchant.accounts_v1beta.Data.CreateAndConfigureAccountRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Merchant.accounts_v1beta.Data.CreateAndConfigureAccountRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "createAndConfigure";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "accounts/v1beta/accounts:createAndConfigure";

            /// <summary>Initializes CreateAndConfigure parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Deletes the specified account regardless of its type: standalone, MCA or sub-account. Deleting an MCA leads
        /// to the deletion of all of its sub-accounts. Executing this method requires admin access. The deletion
        /// succeeds only if the account does not provide services to any other account and has no processed offers. You
        /// can use the `force` parameter to override this.
        /// </summary>
        /// <param name="name">Required. The name of the account to delete. Format: `accounts/{account}`</param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(this.service, name);
        }

        /// <summary>
        /// Deletes the specified account regardless of its type: standalone, MCA or sub-account. Deleting an MCA leads
        /// to the deletion of all of its sub-accounts. Executing this method requires admin access. The deletion
        /// succeeds only if the account does not provide services to any other account and has no processed offers. You
        /// can use the `force` parameter to override this.
        /// </summary>
        public class DeleteRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.Empty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. The name of the account to delete. Format: `accounts/{account}`</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// Optional. If set to `true`, the account is deleted even if it provides services to other accounts or has
            /// processed offers.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Force { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "accounts/v1beta/{+name}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^accounts/[^/]+$",
                });
                RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                {
                    Name = "force",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Retrieves an account from your Merchant Center account. After inserting, updating, or deleting an account,
        /// it may take several minutes before changes take effect.
        /// </summary>
        /// <param name="name">Required. The name of the account to retrieve. Format: `accounts/{account}`</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(this.service, name);
        }

        /// <summary>
        /// Retrieves an account from your Merchant Center account. After inserting, updating, or deleting an account,
        /// it may take several minutes before changes take effect.
        /// </summary>
        public class GetRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.Account>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. The name of the account to retrieve. Format: `accounts/{account}`</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "accounts/v1beta/{+name}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^accounts/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Lists accounts accessible to the calling user and matching the constraints of the request such as page size
        /// or filters. This is not just listing the sub-accounts of an MCA, but all accounts the calling user has
        /// access to including other MCAs, linked accounts, standalone accounts and so on. If no filter is provided,
        /// then it returns all the accounts the user has access to. This method is eventually consistent, meaning
        /// changes such as creating, updating an account or a change of relationships between accounts may not show up
        /// in the results immediately. Instead, these changes propagate over a short period, after which the updated
        /// information can match the associated predicates. That means, that searching by account name might not return
        /// a recently changed account even though it satisfies the predicate.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>
        /// Lists accounts accessible to the calling user and matching the constraints of the request such as page size
        /// or filters. This is not just listing the sub-accounts of an MCA, but all accounts the calling user has
        /// access to including other MCAs, linked accounts, standalone accounts and so on. If no filter is provided,
        /// then it returns all the accounts the user has access to. This method is eventually consistent, meaning
        /// changes such as creating, updating an account or a change of relationships between accounts may not show up
        /// in the results immediately. Instead, these changes propagate over a short period, after which the updated
        /// information can match the associated predicates. That means, that searching by account name might not return
        /// a recently changed account even though it satisfies the predicate.
        /// </summary>
        public class ListRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.ListAccountsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional. Returns only accounts that match the
            /// [filter](https://developers.google.com/merchant/api/guides/accounts/filter). For more details, see the
            /// [filter syntax reference](https://developers.google.com/merchant/api/guides/accounts/filter-syntax).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>
            /// Optional. The maximum number of accounts to return. The service may return fewer than this value. If
            /// unspecified, at most 250 accounts are returned. The maximum value is 500; values above 500 are coerced
            /// to 500.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. A page token, received from a previous `ListAccounts` call. Provide this to retrieve the
            /// subsequent page. When paginating, all other parameters provided to `ListAccounts` must match the call
            /// that provided the page token.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "accounts/v1beta/accounts";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
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

        /// <summary>
        /// List all sub-accounts for a given multi client account. This is a convenience wrapper for the more powerful
        /// `ListAccounts` method. This method will produce the same results as calling `ListsAccounts` with the
        /// following filter: `relationship(providerId={parent} AND service(type="ACCOUNT_AGGREGATION"))`
        /// </summary>
        /// <param name="provider">Required. The aggregation service provider. Format: `accounts/{accountId}`</param>
        public virtual ListSubaccountsRequest ListSubaccounts(string provider)
        {
            return new ListSubaccountsRequest(this.service, provider);
        }

        /// <summary>
        /// List all sub-accounts for a given multi client account. This is a convenience wrapper for the more powerful
        /// `ListAccounts` method. This method will produce the same results as calling `ListsAccounts` with the
        /// following filter: `relationship(providerId={parent} AND service(type="ACCOUNT_AGGREGATION"))`
        /// </summary>
        public class ListSubaccountsRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.ListSubAccountsResponse>
        {
            /// <summary>Constructs a new ListSubaccounts request.</summary>
            public ListSubaccountsRequest(Google.Apis.Services.IClientService service, string provider) : base(service)
            {
                Provider = provider;
                InitParameters();
            }

            /// <summary>Required. The aggregation service provider. Format: `accounts/{accountId}`</summary>
            [Google.Apis.Util.RequestParameterAttribute("provider", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Provider { get; private set; }

            /// <summary>
            /// Optional. The maximum number of accounts to return. The service may return fewer than this value. If
            /// unspecified, at most 250 accounts are returned. The maximum value is 500; values above 500 are coerced
            /// to 500.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. A page token, received from a previous `ListAccounts` call. Provide this to retrieve the
            /// subsequent page. When paginating, all other parameters provided to `ListAccounts` must match the call
            /// that provided the page token.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "listSubaccounts";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "accounts/v1beta/{+provider}:listSubaccounts";

            /// <summary>Initializes ListSubaccounts parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("provider", new Google.Apis.Discovery.Parameter
                {
                    Name = "provider",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^accounts/[^/]+$",
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

        /// <summary>
        /// Updates an account regardless of its type: standalone, MCA or sub-account. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">Identifier. The resource name of the account. Format: `accounts/{account}`</param>
        public virtual PatchRequest Patch(Google.Apis.Merchant.accounts_v1beta.Data.Account body, string name)
        {
            return new PatchRequest(this.service, body, name);
        }

        /// <summary>
        /// Updates an account regardless of its type: standalone, MCA or sub-account. Executing this method requires
        /// admin access.
        /// </summary>
        public class PatchRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.Account>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Merchant.accounts_v1beta.Data.Account body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>Identifier. The resource name of the account. Format: `accounts/{account}`</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// Optional. List of fields being updated. The following fields are supported (in both `snake_case` and
            /// `lowerCamelCase`): - `account_name` - `adult_content` - `language_code` - `time_zone`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Merchant.accounts_v1beta.Data.Account Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "accounts/v1beta/{+name}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^accounts/[^/]+$",
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

    /// <summary>The "termsOfService" collection of methods.</summary>
    public class TermsOfServiceResource
    {
        private const string Resource = "termsOfService";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public TermsOfServiceResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Accepts a `TermsOfService`. Executing this method requires admin access.</summary>
        /// <param name="name">
        /// Required. The resource name of the terms of service version. Format: `termsOfService/{version}`
        /// </param>
        public virtual AcceptRequest Accept(string name)
        {
            return new AcceptRequest(this.service, name);
        }

        /// <summary>Accepts a `TermsOfService`. Executing this method requires admin access.</summary>
        public class AcceptRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.AcceptTermsOfServiceResponse>
        {
            /// <summary>Constructs a new Accept request.</summary>
            public AcceptRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The resource name of the terms of service version. Format: `termsOfService/{version}`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Required. The account for which to accept the ToS. Format: `accounts/{account}`</summary>
            [Google.Apis.Util.RequestParameterAttribute("account", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Account { get; set; }

            /// <summary>
            /// Required. Region code as defined by [CLDR](https://cldr.unicode.org/). This is either a country when the
            /// ToS applies specifically to that country or 001 when it applies globally.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("regionCode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string RegionCode { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "accept";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "accounts/v1beta/{+name}:accept";

            /// <summary>Initializes Accept parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^termsOfService/[^/]+$",
                });
                RequestParameters.Add("account", new Google.Apis.Discovery.Parameter
                {
                    Name = "account",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("regionCode", new Google.Apis.Discovery.Parameter
                {
                    Name = "regionCode",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves the `TermsOfService` associated with the provided version.</summary>
        /// <param name="name">
        /// Required. The resource name of the terms of service version. Format: `termsOfService/{version}`
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(this.service, name);
        }

        /// <summary>Retrieves the `TermsOfService` associated with the provided version.</summary>
        public class GetRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.TermsOfService>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The resource name of the terms of service version. Format: `termsOfService/{version}`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "accounts/v1beta/{+name}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^termsOfService/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Retrieves the latest version of the `TermsOfService` for a given `kind` and `region_code`.
        /// </summary>
        public virtual RetrieveLatestRequest RetrieveLatest()
        {
            return new RetrieveLatestRequest(this.service);
        }

        /// <summary>
        /// Retrieves the latest version of the `TermsOfService` for a given `kind` and `region_code`.
        /// </summary>
        public class RetrieveLatestRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.accounts_v1beta.Data.TermsOfService>
        {
            /// <summary>Constructs a new RetrieveLatest request.</summary>
            public RetrieveLatestRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Required. The Kind this terms of service version applies to.</summary>
            [Google.Apis.Util.RequestParameterAttribute("kind", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<KindEnum> Kind { get; set; }

            /// <summary>Required. The Kind this terms of service version applies to.</summary>
            public enum KindEnum
            {
                /// <summary>Default value. This value is unused.</summary>
                [Google.Apis.Util.StringValueAttribute("TERMS_OF_SERVICE_KIND_UNSPECIFIED")]
                TERMSOFSERVICEKINDUNSPECIFIED = 0,

                /// <summary>Merchant Center application.</summary>
                [Google.Apis.Util.StringValueAttribute("MERCHANT_CENTER")]
                MERCHANTCENTER = 1,
            }

            /// <summary>
            /// Required. Region code as defined by [CLDR](https://cldr.unicode.org/). This is either a country when the
            /// ToS applies specifically to that country or 001 when it applies globally.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("regionCode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string RegionCode { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "retrieveLatest";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "accounts/v1beta/termsOfService:retrieveLatest";

            /// <summary>Initializes RetrieveLatest parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("kind", new Google.Apis.Discovery.Parameter
                {
                    Name = "kind",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("regionCode", new Google.Apis.Discovery.Parameter
                {
                    Name = "regionCode",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.Merchant.accounts_v1beta.Data
{
    /// <summary>Response message for the `AcceptTermsOfService` method.</summary>
    public class AcceptTermsOfServiceResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The agreement state after accepting the ToS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("termsOfServiceAgreementState")]
        public virtual TermsOfServiceAgreementState TermsOfServiceAgreementState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes the accepted terms of service.</summary>
    public class Accepted : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The account where the acceptance was recorded. This can be the account itself or, in the case of
        /// subaccounts, the MCA account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acceptedBy")]
        public virtual string AcceptedBy { get; set; }

        /// <summary>The accepted termsOfService.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("termsOfService")]
        public virtual string TermsOfService { get; set; }

        /// <summary>
        /// When set, it states that the accepted `TermsOfService` is only valid until the end of this date (in UTC). A
        /// new one must be accepted before then. The information of the required `TermsOfService` is found in the
        /// `Required` message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validUntil")]
        public virtual Date ValidUntil { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The `Account` message represents a merchant's account within Shopping Ads. It's the primary entity for managing
    /// product data, settings, and interactions with Google's services and external providers. Accounts can operate as
    /// standalone entities or be part of a multi-client account (MCA) structure. In an MCA setup the parent account
    /// manages multiple sub-accounts. Establishing an account involves configuring attributes like the account name,
    /// time zone, and language preferences. The `Account` message is the parent entity for many other resources, for
    /// example, `AccountRelationship`, `Homepage`, `BusinessInfo` and so on.
    /// </summary>
    public class Account : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The ID of the account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual System.Nullable<long> AccountId { get; set; }

        /// <summary>
        /// Required. A human-readable name of the account. See [store
        /// name](https://support.google.com/merchants/answer/160556) and [business
        /// name](https://support.google.com/merchants/answer/12159159) for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountName")]
        public virtual string AccountName { get; set; }

        /// <summary>Optional. Whether this account contains adult content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adultContent")]
        public virtual System.Nullable<bool> AdultContent { get; set; }

        /// <summary>
        /// Required. The account's [BCP-47 language code](https://tools.ietf.org/html/bcp47), such as `en-US` or
        /// `sr-Latn`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>Identifier. The resource name of the account. Format: `accounts/{account}`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Whether this is a test account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testAccount")]
        public virtual System.Nullable<bool> TestAccount { get; set; }

        /// <summary>
        /// Required. The time zone of the account. On writes, `time_zone` sets both the `reporting_time_zone` and the
        /// `display_time_zone`. For reads, `time_zone` always returns the `display_time_zone`. If `display_time_zone`
        /// doesn't exist for your account, `time_zone` is empty. The `version` field is not supported, won't be set in
        /// responses and will be silently ignored if specified in requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual TimeZone TimeZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`AccountAggregation` payload.</summary>
    public class AccountAggregation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An [`AccountIssue`](https://support.google.com/merchants/answer/12153802?sjid=17798438912526418908-EU#account).
    /// </summary>
    public class AccountIssue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Further localized details about the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detail")]
        public virtual string Detail { get; set; }

        /// <summary>
        /// Link to Merchant Center Help Center providing further information about the issue and how to fix it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentationUri")]
        public virtual string DocumentationUri { get; set; }

        /// <summary>The impact this issue has on various destinations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("impactedDestinations")]
        public virtual System.Collections.Generic.IList<ImpactedDestination> ImpactedDestinations { get; set; }

        /// <summary>
        /// Identifier. The resource name of the account issue. Format: `accounts/{account}/issues/{id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The overall severity of the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The localized title of the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`AccountManagement` payload.</summary>
    public class AccountManagement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The `AccountRelationship` message defines a formal connection between a merchant's account and a service
    /// provider's account. This relationship enables the provider to offer specific services to the merchant, such as
    /// product management or campaign management. It specifies the access rights and permissions to the merchant's data
    /// relevant to those services. Establishing an account relationship involves linking the merchant's account with a
    /// provider's account. The provider could be another Google account (like Google Ads or Google My Business) or a
    /// third-party platform (such as Shopify or WooCommerce).
    /// </summary>
    public class AccountRelationship : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. An optional alias you can assign to this account relationship. This alias acts as a convenient
        /// identifier for your own reference and management. It must be unique among all your account relationships
        /// with the same provider. For example, you might use `account_id_alias` to assign a friendly name to this
        /// relationship for easier identification in your systems.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountIdAlias")]
        public virtual string AccountIdAlias { get; set; }

        /// <summary>Identifier. The resource name of the account relationship.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Immutable. The provider of the service. Either the reference to an account such as `providers/123` or a
        /// well-known service provider (one of `providers/GOOGLE_ADS` or `providers/GOOGLE_BUSINESS_PROFILE`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provider")]
        public virtual string Provider { get; set; }

        /// <summary>Output only. The human-readable display name of the provider account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("providerDisplayName")]
        public virtual string ProviderDisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The `AccountService` message represents a specific service that a provider account offers to a merchant account.
    /// `AccountService` defines the permissions and capabilities granted to the provider, allowing for operations such
    /// as product management or campaign management. The lifecycle of an `AccountService` involves a proposal phase,
    /// where one party suggests the service, and an approval phase, where the other party accepts or rejects it. This
    /// handshake mechanism ensures mutual consent before any access is granted. This mechanism safeguards both parties
    /// by ensuring that access rights are granted appropriately and that both the merchant and provider are aware of
    /// the services enabled. In scenarios where a user is an admin of both accounts, the approval can happen
    /// automatically. The mutability of a service is also managed through `AccountService`. Some services might be
    /// immutable, for example, if they were established through other systems or APIs, and you cannot alter them
    /// through this API.
    /// </summary>
    public class AccountService : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Service type for account aggregation. This enables the provider, which is a Multi-Client Account (MCA), to
        /// manage multiple sub-accounts (client accounts). Through this service, the MCA provider can perform
        /// administrative and operational tasks across all linked sub-accounts. This is useful for agencies,
        /// aggregators, or large retailers that need centralized control over many merchant accounts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountAggregation")]
        public virtual AccountAggregation AccountAggregation { get; set; }

        /// <summary>
        /// Service type for account management. Enables the provider to perform administrative actions on the
        /// merchant's account, such as configuring account settings, managing users, or updating business information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountManagement")]
        public virtual AccountManagement AccountManagement { get; set; }

        /// <summary>
        /// Service type for managing advertising campaigns. Grants the provider access to create and manage the
        /// merchant's ad campaigns, including setting up campaigns, adjusting bids, and optimizing performance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("campaignsManagement")]
        public virtual CampaignsManagement CampaignsManagement { get; set; }

        /// <summary>
        /// Immutable. An optional, immutable identifier that Google uses to refer to this account when communicating
        /// with the provider. This should be the unique account ID within the provider's system (for example, your shop
        /// ID in Shopify). If you have multiple accounts with the same provider - for instance, different accounts for
        /// various regions — the `external_account_id` differentiates between them, ensuring accurate linking and
        /// integration between Google and the provider.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalAccountId")]
        public virtual string ExternalAccountId { get; set; }

        /// <summary>
        /// Output only. Information about the state of the service in terms of establishing it (e.g. is it pending
        /// approval or approved).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("handshake")]
        public virtual Handshake Handshake { get; set; }

        /// <summary>
        /// Output only. Whether the service is mutable (e.g. through Approve / Reject RPCs). A service that was created
        /// through another system or API might be immutable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mutability")]
        public virtual string Mutability { get; set; }

        /// <summary>Identifier. The resource name of the account service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Service type for managing products. This allows the provider to handle product data on behalf of the
        /// merchant, including reading and writing product listings. It's commonly used when the provider offers
        /// inventory management or catalog synchronization services to keep the merchant's product information
        /// up-to-date across platforms.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productsManagement")]
        public virtual ProductsManagement ProductsManagement { get; set; }

        /// <summary>
        /// Output only. The provider of the service. Either the reference to an account such as `providers/123` or a
        /// well-known service provider (one of `providers/GOOGLE_ADS` or `providers/GOOGLE_BUSINESS_PROFILE`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provider")]
        public virtual string Provider { get; set; }

        /// <summary>Output only. The human-readable display name of the provider account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("providerDisplayName")]
        public virtual string ProviderDisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional instructions to add account services during creation of the account.</summary>
    public class AddAccountService : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The provider is an [aggregator](https://support.google.com/merchants/answer/188487) for the account. Payload
        /// for service type Account Aggregation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountAggregation")]
        public virtual AccountAggregation AccountAggregation { get; set; }

        /// <summary>
        /// Required. The provider of the service. Either the reference to an account such as `providers/123` or a
        /// well-known service provider (one of `providers/GOOGLE_ADS` or `providers/GOOGLE_BUSINESS_PROFILE`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provider")]
        public virtual string Provider { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Instruction for adding a user to the account during creation.</summary>
    public class AddUser : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Details about the user to be added. At the moment, only access rights may be specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual User User { get; set; }

        /// <summary>Required. The email address of the user (for example, `john.doe@gmail.com`).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Shipping address of the warehouse.</summary>
    public class Address : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Top-level administrative subdivision of the country. For example, a state like California ("CA")
        /// or a province like Quebec ("QC").
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("administrativeArea")]
        public virtual string AdministrativeArea { get; set; }

        /// <summary>
        /// Required. City, town or commune. May also include dependent localities or sublocalities (For example
        /// neighborhoods or suburbs).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("city")]
        public virtual string City { get; set; }

        /// <summary>Required. Postal code or ZIP (For example "94043").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCode")]
        public virtual string PostalCode { get; set; }

        /// <summary>
        /// Required. [CLDR country code](http://www.unicode.org/repos/cldr/tags/latest/common/main/en.xml) (For example
        /// "US").
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>Street-level part of the address. For example: `111w 31st Street`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("streetAddress")]
        public virtual string StreetAddress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to approve an account service.</summary>
    public class ApproveAccountServiceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Collection of information related to the [autofeed](https://support.google.com/merchants/answer/7538732)
    /// settings.
    /// </summary>
    public class AutofeedSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Determines whether merchant is eligible for being enrolled into an autofeed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eligible")]
        public virtual System.Nullable<bool> Eligible { get; set; }

        /// <summary>
        /// Required. Enables or disables product crawling through the autofeed for the given account. Autofeed accounts
        /// must meet [certain
        /// conditions](https://support.google.com/merchants/answer/7538732#Configure_automated_feeds_Standard_Experience),
        /// which can be checked through the `eligible` field. The account must **not** be a marketplace. When the
        /// autofeed is enabled for the first time, the products usually appear instantly. When re-enabling, it might
        /// take up to 24 hours for products to appear.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableProducts")]
        public virtual System.Nullable<bool> EnableProducts { get; set; }

        /// <summary>
        /// Identifier. The resource name of the autofeed settings. Format: `accounts/{account}/autofeedSettings`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This improvement will attempt to automatically correct submitted images if they don't meet the [image
    /// requirements](https://support.google.com/merchants/answer/6324350), for example, removing overlays. If
    /// successful, the image will be replaced and approved. This improvement is only applied to images of disapproved
    /// offers. For more information see: [Automatic image
    /// improvements](https://support.google.com/merchants/answer/9242973)
    /// </summary>
    public class AutomaticImageImprovements : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Determines how the images should be automatically updated. If this field is not present and
        /// provided in the update mask, then the settings will be deleted. If there are no settings for subaccount,
        /// they are inherited from aggregator.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountImageImprovementsSettings")]
        public virtual ImageImprovementsAccountLevelSettings AccountImageImprovementsSettings { get; set; }

        /// <summary>
        /// Output only. The effective value of allow_automatic_image_improvements. If
        /// account_image_improvements_settings is present, then this value is the same. Otherwise, it represents the
        /// inherited value of the parent account. Read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectiveAllowAutomaticImageImprovements")]
        public virtual System.Nullable<bool> EffectiveAllowAutomaticImageImprovements { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Collection of information related to the [automatic
    /// improvements](https://developers.google.com/shopping-content/guides/automatic-improvements) of an account.
    /// </summary>
    public class AutomaticImprovements : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This improvement will attempt to automatically correct submitted images if they don't meet the [image
        /// requirements](https://support.google.com/merchants/answer/6324350), for example, removing overlays. If
        /// successful, the image will be replaced and approved. This improvement is only applied to images of
        /// disapproved offers. For more information see: [Automatic image
        /// improvements](https://support.google.com/merchants/answer/9242973) This field is only updated (cleared) if
        /// provided in the update mask.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageImprovements")]
        public virtual AutomaticImageImprovements ImageImprovements { get; set; }

        /// <summary>
        /// Turning on [item updates](https://support.google.com/merchants/answer/3246284) allows Google to
        /// automatically update items for you. When item updates are on, Google uses the structured data markup on the
        /// website and advanced data extractors to update the price and availability of the items. When the item
        /// updates are off, items with mismatched data aren't shown. This field is only updated (cleared) if provided
        /// in the update mask.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemUpdates")]
        public virtual AutomaticItemUpdates ItemUpdates { get; set; }

        /// <summary>
        /// Identifier. The resource name of the automatic improvements. Format:
        /// `accounts/{account}/automaticImprovements`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Not available for MCAs [accounts](https://support.google.com/merchants/answer/188487). By turning on
        /// [automatic shipping improvements](https://support.google.com/merchants/answer/10027038), you are allowing
        /// Google to improve the accuracy of your delivery times shown to shoppers using Google. More accurate delivery
        /// times, especially when faster, typically lead to better conversion rates. Google will improve your estimated
        /// delivery times based on various factors: * Delivery address of an order * Current handling time and shipping
        /// time settings * Estimated weekdays or business days * Parcel tracking data This field is only updated
        /// (cleared) if provided in the update mask.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shippingImprovements")]
        public virtual AutomaticShippingImprovements ShippingImprovements { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Turning on [item updates](https://support.google.com/merchants/answer/3246284) allows Google to automatically
    /// update items for you. When item updates are on, Google uses the structured data markup on the website and
    /// advanced data extractors to update the price and availability of the items. When the item updates are off, items
    /// with mismatched data aren't shown.
    /// </summary>
    public class AutomaticItemUpdates : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Determines which attributes of the items should be automatically updated. If this field is not
        /// present and provided in the update mask, then the settings will be deleted. If there are no settings for
        /// subaccount, they are inherited from aggregator.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountItemUpdatesSettings")]
        public virtual ItemUpdatesAccountLevelSettings AccountItemUpdatesSettings { get; set; }

        /// <summary>
        /// Output only. The effective value of allow_availability_updates. If account_item_updates_settings is present,
        /// then this value is the same. Otherwise, it represents the inherited value of the parent account. The default
        /// value is true if no settings are present. Read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectiveAllowAvailabilityUpdates")]
        public virtual System.Nullable<bool> EffectiveAllowAvailabilityUpdates { get; set; }

        /// <summary>
        /// Output only. The effective value of allow_condition_updates. If account_item_updates_settings is present,
        /// then this value is the same. Otherwise, it represents the inherited value of the parent account. The default
        /// value is true if no settings are present. Read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectiveAllowConditionUpdates")]
        public virtual System.Nullable<bool> EffectiveAllowConditionUpdates { get; set; }

        /// <summary>
        /// Output only. The effective value of allow_price_updates. If account_item_updates_settings is present, then
        /// this value is the same. Otherwise, it represents the inherited value of the parent account. The default
        /// value is true if no settings are present. Read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectiveAllowPriceUpdates")]
        public virtual System.Nullable<bool> EffectiveAllowPriceUpdates { get; set; }

        /// <summary>
        /// Output only. The effective value of allow_strict_availability_updates. If account_item_updates_settings is
        /// present, then this value is the same. Otherwise, it represents the inherited value of the parent account.
        /// The default value is true if no settings are present. Read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectiveAllowStrictAvailabilityUpdates")]
        public virtual System.Nullable<bool> EffectiveAllowStrictAvailabilityUpdates { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Not available for MCAs [accounts](https://support.google.com/merchants/answer/188487). By turning on [automatic
    /// shipping improvements](https://support.google.com/merchants/answer/10027038), you are allowing Google to improve
    /// the accuracy of your delivery times shown to shoppers using Google. More accurate delivery times, especially
    /// when faster, typically lead to better conversion rates. Google will improve your estimated delivery times based
    /// on various factors: * Delivery address of an order * Current handling time and shipping time settings *
    /// Estimated weekdays or business days * Parcel tracking data
    /// </summary>
    public class AutomaticShippingImprovements : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Enables automatic shipping improvements.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowShippingImprovements")]
        public virtual System.Nullable<bool> AllowShippingImprovements { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Business days of the warehouse.</summary>
    public class BusinessDayConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Regular business days. May not be empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("businessDays")]
        public virtual System.Collections.Generic.IList<string> BusinessDays { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Collection of information related to the [identity of a
    /// business](https://support.google.com/merchants/answer/12564247).
    /// </summary>
    public class BusinessIdentity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Specifies whether the business identifies itself as being black-owned. This optional field will
        /// only be available for merchants with a business country set to `US`. It is also not applicable for
        /// marketplaces or marketplace sellers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blackOwned")]
        public virtual IdentityAttribute BlackOwned { get; set; }

        /// <summary>
        /// Optional. Specifies whether the business identifies itself as being latino-owned. This optional field will
        /// only be available for merchants with a business country set to `US`. It is also not applicable for
        /// marketplaces or marketplace sellers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latinoOwned")]
        public virtual IdentityAttribute LatinoOwned { get; set; }

        /// <summary>
        /// Identifier. The resource name of the business identity. Format: `accounts/{account}/businessIdentity`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. Whether the identity attributes may be used for promotions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promotionsConsent")]
        public virtual string PromotionsConsent { get; set; }

        /// <summary>
        /// Optional. Specifies whether the business identifies itself as a small business. This optional field will
        /// only be available for merchants with a business country set to `US`. It is also not applicable for
        /// marketplaces.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("smallBusiness")]
        public virtual IdentityAttribute SmallBusiness { get; set; }

        /// <summary>
        /// Optional. Specifies whether the business identifies itself as being veteran-owned. This optional field will
        /// only be available for merchants with a business country set to `US`. It is also not applicable for
        /// marketplaces or marketplace sellers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("veteranOwned")]
        public virtual IdentityAttribute VeteranOwned { get; set; }

        /// <summary>
        /// Optional. Specifies whether the business identifies itself as being women-owned. This optional field will
        /// only be available for merchants with a business country set to `US`. It is also not applicable for
        /// marketplaces or marketplace sellers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("womenOwned")]
        public virtual IdentityAttribute WomenOwned { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The `BusinessInfo` message contains essential information about a merchant's business. This message captures key
    /// business details such as physical address, customer service contacts, and region-specific identifiers.
    /// </summary>
    public class BusinessInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The address of the business. Only `region_code`, `address_lines`, `postal_code`,
        /// `administrative_area` and `locality` fields are supported. All other fields are ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual PostalAddress Address { get; set; }

        /// <summary>Optional. The customer service of the business.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerService")]
        public virtual CustomerService CustomerService { get; set; }

        /// <summary>
        /// Optional. The 10-digit [Korean business registration
        /// number](https://support.google.com/merchants/answer/9037766) separated with dashes in the format:
        /// XXX-XX-XXXXX.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("koreanBusinessRegistrationNumber")]
        public virtual string KoreanBusinessRegistrationNumber { get; set; }

        /// <summary>
        /// Identifier. The resource name of the business info. Format: `accounts/{account}/businessInfo`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The phone number of the business.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phone")]
        public virtual PhoneNumber Phone { get; set; }

        /// <summary>Output only. The phone verification state of the business.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneVerificationState")]
        public virtual string PhoneVerificationState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`CampaignManagement` payload.</summary>
    public class CampaignsManagement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A list of carrier rates that can be referred to by `main_table` or `single_value`. Supported carrier services
    /// are defined in
    /// https://support.google.com/merchants/answer/12577710?ref_topic=12570808&amp;amp;sjid=10662598224319463032-NC#zippy=%2Cdelivery-cost-rate-type%2Ccarrier-rate-au-de-uk-and-us-only.
    /// </summary>
    public class CarrierRate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Carrier service, such as `"UPS"` or `"Fedex"`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("carrier")]
        public virtual string Carrier { get; set; }

        /// <summary>Required. Carrier service, such as `"ground"` or `"2 days"`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("carrierService")]
        public virtual string CarrierService { get; set; }

        /// <summary>
        /// Optional. Additive shipping rate modifier. Can be negative. For example `{ "amount_micros": 1,
        /// "currency_code" : "USD" }` adds $1 to the rate, `{ "amount_micros": -3, "currency_code" : "USD" }` removes
        /// $3 from the rate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flatAdjustment")]
        public virtual Price FlatAdjustment { get; set; }

        /// <summary>Required. Name of the carrier rate. Must be unique per rate group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. Shipping origin for this carrier rate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originPostalCode")]
        public virtual string OriginPostalCode { get; set; }

        /// <summary>
        /// Optional. Multiplicative shipping rate modifier as a number in decimal notation. Can be negative. For
        /// example `"5.4"` increases the rate by 5.4%, `"-3"` decreases the rate by 3%.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percentageAdjustment")]
        public virtual string PercentageAdjustment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the `ClaimHomepage` method.</summary>
    public class ClaimHomepageRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. When set to `true`, this option removes any existing claim on the requested website from any other
        /// account to the account making the request, effectively replacing the previous claim.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overwrite")]
        public virtual System.Nullable<bool> Overwrite { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the `CreateAndConfigureAccount` method.</summary>
    public class CreateAndConfigureAccountRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The account to be created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("account")]
        public virtual Account Account { get; set; }

        /// <summary>
        /// Required. An account service between the account to be created and the provider account is initialized as
        /// part of the creation. At least one such service needs to be provided. Currently exactly one of these needs
        /// to be `account_aggregation`, which means you can only create sub accounts, not standalone account through
        /// this method. Additional `account_management` or `product_management` services may be provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual System.Collections.Generic.IList<AddAccountService> Service { get; set; }

        /// <summary>Optional. Users to be added to the account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual System.Collections.Generic.IList<AddUser> User { get; set; }

        /// <summary>
        /// Optional. Users to be added to the account. This field is deprecated and will not exist after the API
        /// evolves out of beta. Use the `user` field instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("users")]
        public virtual System.Collections.Generic.IList<CreateUserRequest> Users { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the `CreateUser` method.</summary>
    public class CreateUserRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The resource name of the account for which a user will be created. Format: `accounts/{account}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>Optional. The user to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual User User { get; set; }

        /// <summary>Required. The email address of the user (for example, `john.doe@gmail.com`).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Customer service information.</summary>
    public class CustomerService : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The email address where customer service may be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>Optional. The phone number where customer service may be called.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phone")]
        public virtual PhoneNumber Phone { get; set; }

        /// <summary>Optional. The URI where customer service may be found.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configs related to local delivery ends for the day.</summary>
    public class CutoffConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Time that local delivery ends for the day.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localCutoffTime")]
        public virtual LocalCutoffTime LocalCutoffTime { get; set; }

        /// <summary>
        /// Merchants can opt-out of showing n+1 day local delivery when they have a shipping service configured to n
        /// day local delivery. For example, if the shipping service defines same-day delivery, and it's past the
        /// cut-off, setting this field to `true` results in the calculated shipping service rate returning
        /// `NO_DELIVERY_POST_CUTOFF`. In the same example, setting this field to `false` results in the calculated
        /// shipping time being one day. This is only for local delivery.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noDeliveryPostCutoff")]
        public virtual System.Nullable<bool> NoDeliveryPostCutoff { get; set; }

        /// <summary>
        /// Only valid with local delivery fulfillment. Represents cutoff time as the number of hours before store
        /// closing. Mutually exclusive with `local_cutoff_time`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storeCloseOffsetHours")]
        public virtual System.Nullable<long> StoreCloseOffsetHours { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Business days cutoff time definition.</summary>
    public class CutoffTime : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Hour of the cutoff time until which an order has to be placed to be processed in the same day.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hour")]
        public virtual System.Nullable<int> Hour { get; set; }

        /// <summary>
        /// Required. Minute of the cutoff time until which an order has to be placed to be processed in the same day.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minute")]
        public virtual System.Nullable<int> Minute { get; set; }

        /// <summary>
        /// Required. [Timezone
        /// identifier](https://developers.google.com/adwords/api/docs/appendix/codes-formats#timezone-ids) For example
        /// "Europe/Zurich".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

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

    /// <summary>Time spent in various aspects from order to the delivery of the product.</summary>
    public class DeliveryTime : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Business days cutoff time definition. If not configured the cutoff time will be defaulted to 8AM PST.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cutoffTime")]
        public virtual CutoffTime CutoffTime { get; set; }

        /// <summary>
        /// The business days during which orders can be handled. If not provided, Monday to Friday business days will
        /// be assumed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("handlingBusinessDayConfig")]
        public virtual BusinessDayConfig HandlingBusinessDayConfig { get; set; }

        /// <summary>
        /// Maximum number of business days spent before an order is shipped. 0 means same day shipped, 1 means next day
        /// shipped. Must be greater than or equal to `min_handling_days`. 'min_handling_days' and 'max_handling_days'
        /// should be either set or not set at the same time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxHandlingDays")]
        public virtual System.Nullable<int> MaxHandlingDays { get; set; }

        /// <summary>
        /// Maximum number of business days that is spent in transit. 0 means same day delivery, 1 means next day
        /// delivery. Must be greater than or equal to `min_transit_days`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxTransitDays")]
        public virtual System.Nullable<int> MaxTransitDays { get; set; }

        /// <summary>
        /// Minimum number of business days spent before an order is shipped. 0 means same day shipped, 1 means next day
        /// shipped. 'min_handling_days' and 'max_handling_days' should be either set or not set at the same time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minHandlingDays")]
        public virtual System.Nullable<int> MinHandlingDays { get; set; }

        /// <summary>
        /// Minimum number of business days that is spent in transit. 0 means same day delivery, 1 means next day
        /// delivery. Either `min_transit_days`, `max_transit_days` or `transit_time_table` must be set, but not both.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minTransitDays")]
        public virtual System.Nullable<int> MinTransitDays { get; set; }

        /// <summary>
        /// The business days during which orders can be in-transit. If not provided, Monday to Friday business days
        /// will be assumed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transitBusinessDayConfig")]
        public virtual BusinessDayConfig TransitBusinessDayConfig { get; set; }

        /// <summary>
        /// Transit time table, number of business days spent in transit based on row and column dimensions. Either
        /// `min_transit_days`, `max_transit_days` or `transit_time_table` can be set, but not both.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transitTimeTable")]
        public virtual TransitTable TransitTimeTable { get; set; }

        /// <summary>
        /// Optional. Indicates that the delivery time should be calculated per warehouse (shipping origin location)
        /// based on the settings of the selected carrier. When set, no other transit time related field in delivery
        /// time should be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warehouseBasedDeliveryTimes")]
        public virtual System.Collections.Generic.IList<WarehouseBasedDeliveryTime> WarehouseBasedDeliveryTimes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the DisableProgram method.</summary>
    public class DisableProgramRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Maximum delivery radius. This is only required for the local delivery shipment type.</summary>
    public class Distance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Unit can differ based on country, it is parameterized to include miles and kilometers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; }

        /// <summary>Integer value of distance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<long> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The categories of notifications the user opted into / opted out of. The email preferences do not include
    /// mandatory announcements as users can't opt out of them.
    /// </summary>
    public class EmailPreferences : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Identifier. The name of the EmailPreferences. The endpoint is only supported for the authenticated user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. Updates on new features, tips and best practices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newsAndTips")]
        public virtual string NewsAndTips { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); }
    /// </summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the EnableProgram method.</summary>
    public class EnableProgramRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of geotargets that defines the region area.</summary>
    public class GeoTargetArea : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A non-empty list of [location
        /// IDs](https://developers.google.com/adwords/api/docs/appendix/geotargeting). They must all be of the same
        /// location type (for example, state).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("geotargetCriteriaIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> GeotargetCriteriaIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The current status of establishing of the service. (for example, pending approval or approved).
    /// </summary>
    public class Handshake : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The most recent account to modify the account service's `approval_status`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actor")]
        public virtual string Actor { get; set; }

        /// <summary>Output only. The approval state of this handshake.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approvalState")]
        public virtual string ApprovalState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A non-empty list of row or column headers for a table. Exactly one of `prices`, `weights`, `num_items`,
    /// `postal_code_group_names`, or `location` must be set.
    /// </summary>
    public class Headers : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A list of location ID sets. Must be non-empty. Can only be set if all other fields are not set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<LocationIdSet> Locations { get; set; }

        /// <summary>
        /// Required. A list of inclusive number of items upper bounds. The last value can be `"infinity"`. For example
        /// `["10", "50", "infinity"]` represents the headers "&amp;lt;= 10 items", "&amp;lt;= 50 items", and "&amp;gt;
        /// 50 items". Must be non-empty. Can only be set if all other fields are not set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numberOfItems")]
        public virtual System.Collections.Generic.IList<string> NumberOfItems { get; set; }

        /// <summary>
        /// Required. A list of postal group names. The last value can be `"all other locations"`. Example: `["zone 1",
        /// "zone 2", "all other locations"]`. The referred postal code groups must match the delivery country of the
        /// service. Must be non-empty. Can only be set if all other fields are not set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCodeGroupNames")]
        public virtual System.Collections.Generic.IList<string> PostalCodeGroupNames { get; set; }

        /// <summary>
        /// Required. A list of inclusive order price upper bounds. The last price's value can be infinity by setting
        /// price amount_micros = -1. For example `[{"amount_micros": 10000000, "currency_code": "USD"},
        /// {"amount_micros": 500000000, "currency_code": "USD"}, {"amount_micros": -1, "currency_code": "USD"}]`
        /// represents the headers "&amp;lt;= $10", "&amp;lt;= $500", and "&amp;gt; $500". All prices within a service
        /// must have the same currency. Must be non-empty. Must be positive except -1. Can only be set if all other
        /// fields are not set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prices")]
        public virtual System.Collections.Generic.IList<Price> Prices { get; set; }

        /// <summary>
        /// Required. A list of inclusive order weight upper bounds. The last weight's value can be infinity by setting
        /// price amount_micros = -1. For example `[{"amount_micros": 10000000, "unit": "kg"}, {"amount_micros":
        /// 50000000, "unit": "kg"}, {"amount_micros": -1, "unit": "kg"}]` represents the headers "&amp;lt;= 10kg",
        /// "&amp;lt;= 50kg", and "&amp;gt; 50kg". All weights within a service must have the same unit. Must be
        /// non-empty. Must be positive except -1. Can only be set if all other fields are not set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weights")]
        public virtual System.Collections.Generic.IList<Weight> Weights { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The `Homepage` message represents a merchant's store homepage within the system. A merchant's homepage is the
    /// primary domain where customers interact with their store. The homepage can be claimed and verified as a proof of
    /// ownership and allows the merchant to unlock features that require a verified website. For more information, see
    /// [Understanding online store URL verification](//support.google.com/merchants/answer/176793).
    /// </summary>
    public class Homepage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Whether the homepage is claimed. See https://support.google.com/merchants/answer/176793.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("claimed")]
        public virtual System.Nullable<bool> Claimed { get; set; }

        /// <summary>
        /// Identifier. The resource name of the store's homepage. Format: `accounts/{account}/homepage`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. The URI (typically a URL) of the store's homepage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>All information related to an identity attribute.</summary>
    public class IdentityAttribute : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The declaration of identity for this attribute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identityDeclaration")]
        public virtual string IdentityDeclaration { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings for the Automatic Image Improvements.</summary>
    public class ImageImprovementsAccountLevelSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Enables automatic image improvements.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowAutomaticImageImprovements")]
        public virtual System.Nullable<bool> AllowAutomaticImageImprovements { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The impact of the issue on a region.</summary>
    public class Impact : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The [CLDR region code](https://cldr.unicode.org/) where this issue applies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>The severity of the issue on the destination and region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The impact of the issue on a destination.</summary>
    public class ImpactedDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The (negative) impact for various regions on the given destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("impacts")]
        public virtual System.Collections.Generic.IList<Impact> Impacts { get; set; }

        /// <summary>The impacted reporting context.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportingContext")]
        public virtual string ReportingContext { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings for the Automatic Item Updates.</summary>
    public class ItemUpdatesAccountLevelSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If availability updates are enabled, any previous availability values get overwritten if Google finds an
        /// out-of-stock annotation on the offer's page. If additionally `allow_strict_availability_updates` field is
        /// set to true, values get overwritten if Google finds an in-stock annotation on the offer’s page.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowAvailabilityUpdates")]
        public virtual System.Nullable<bool> AllowAvailabilityUpdates { get; set; }

        /// <summary>
        /// If condition updates are enabled, Google always updates item condition with the condition detected from the
        /// details of your product.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowConditionUpdates")]
        public virtual System.Nullable<bool> AllowConditionUpdates { get; set; }

        /// <summary>
        /// If price updates are enabled, Google always updates the active price with the crawled information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowPriceUpdates")]
        public virtual System.Nullable<bool> AllowPriceUpdates { get; set; }

        /// <summary>
        /// If `allow_availability_updates` is enabled, items are automatically updated in all your Shopping target
        /// countries. By default, availability updates will only be applied to items that are 'out of stock' on your
        /// website but 'in stock' on Shopping. Set this to true to also update items that are 'in stock' on your
        /// website, but 'out of stock' on Google Shopping. In order for this field to have an effect, you must also set
        /// `allow_availability_updates`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowStrictAvailabilityUpdates")]
        public virtual System.Nullable<bool> AllowStrictAvailabilityUpdates { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the `ListAccountIssues` method.</summary>
    public class ListAccountIssuesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The issues from the specified account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountIssues")]
        public virtual System.Collections.Generic.IList<AccountIssue> AccountIssues { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response after trying to list account relationships.</summary>
    public class ListAccountRelationshipsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The account relationships that match your filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountRelationships")]
        public virtual System.Collections.Generic.IList<AccountRelationship> AccountRelationships { get; set; }

        /// <summary>
        /// A page token. You can send the `page_token` to get the next page. Only included in the `list` response if
        /// there are more pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response after trying to list account services.</summary>
    public class ListAccountServicesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The account services that match your filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountServices")]
        public virtual System.Collections.Generic.IList<AccountService> AccountServices { get; set; }

        /// <summary>
        /// A page token. You can send the `page_token` to get the next page. Only included in the `list` response if
        /// there are more pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the `ListAccounts` method.</summary>
    public class ListAccountsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The accounts matching the `ListAccountsRequest`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accounts")]
        public virtual System.Collections.Generic.IList<Account> Accounts { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the `ListOnlineReturnPolicies` method.</summary>
    public class ListOnlineReturnPoliciesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `pageToken` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The retrieved return policies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onlineReturnPolicies")]
        public virtual System.Collections.Generic.IList<OnlineReturnPolicy> OnlineReturnPolicies { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the ListPrograms method.</summary>
    public class ListProgramsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token that can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The programs for the given account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("programs")]
        public virtual System.Collections.Generic.IList<Program> Programs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the `ListRegions` method.</summary>
    public class ListRegionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The regions from the specified merchant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regions")]
        public virtual System.Collections.Generic.IList<Region> Regions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the `ListSubAccounts` method.</summary>
    public class ListSubAccountsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The accounts for which the given parent account is an aggregator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accounts")]
        public virtual System.Collections.Generic.IList<Account> Accounts { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the `ListUsers` method.</summary>
    public class ListUsersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The users from the specified account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("users")]
        public virtual System.Collections.Generic.IList<User> Users { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Time that local delivery ends for the day.</summary>
    public class LocalCutoffTime : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Hour local delivery orders must be placed by to process the same day.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hour")]
        public virtual System.Nullable<long> Hour { get; set; }

        /// <summary>Minute local delivery orders must be placed by to process the same day.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minute")]
        public virtual System.Nullable<long> Minute { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A list of location ID sets. Must be non-empty. Can only be set if all other fields are not set.
    /// </summary>
    public class LocationIdSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A non-empty list of [location
        /// IDs](https://developers.google.com/adwords/api/docs/appendix/geotargeting). They must all be of the same
        /// location type (For example, state).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationIds")]
        public virtual System.Collections.Generic.IList<string> LocationIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// [Loyalty program](https://support.google.com/merchants/answer/12922446) provided by a merchant.
    /// </summary>
    public class LoyaltyProgram : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Loyalty program tier of this shipping service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loyaltyProgramTiers")]
        public virtual System.Collections.Generic.IList<LoyaltyProgramTiers> LoyaltyProgramTiers { get; set; }

        /// <summary>
        /// This is the loyalty program label set in your loyalty program settings in Merchant Center. This
        /// sub-attribute allows Google to map your loyalty program to eligible offers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("programLabel")]
        public virtual string ProgramLabel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Subset of a merchants loyalty program.</summary>
    public class LoyaltyProgramTiers : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The tier label [tier_label] sub-attribute differentiates offer level benefits between each tier. This value
        /// is also set in your program settings in Merchant Center, and is required for data source changes even if
        /// your loyalty program only has 1 tier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tierLabel")]
        public virtual string TierLabel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Table of per store minimum order values for the pickup fulfillment type.</summary>
    public class MinimumOrderValueTable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A list of store code sets sharing the same minimum order value (MOV). At least two sets are
        /// required and the last one must be empty, which signifies 'MOV for all other stores'. Each store code can
        /// only appear once across all the sets. All prices within a service must have the same currency.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storeCodeSetWithMovs")]
        public virtual System.Collections.Generic.IList<StoreCodeSetWithMov> StoreCodeSetWithMovs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// [Online return policy](https://support.google.com/merchants/answer/10220642) object. This is currently used to
    /// represent return policies for ads and free listings programs.
    /// </summary>
    public class OnlineReturnPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. This field specifies if merchant only accepts defective products for returns.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acceptDefectiveOnly")]
        public virtual System.Nullable<bool> AcceptDefectiveOnly { get; set; }

        /// <summary>Optional. This field specifies if merchant allows customers to exchange products.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acceptExchange")]
        public virtual System.Nullable<bool> AcceptExchange { get; set; }

        /// <summary>
        /// Required. Immutable. The countries of sale where the return policy applies. The values must be a valid 2
        /// letter ISO 3166 code.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countries")]
        public virtual System.Collections.Generic.IList<string> Countries { get; set; }

        /// <summary>
        /// Optional. The item conditions accepted for returns must not be empty unless the type of return policy is
        /// 'noReturns'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemConditions")]
        public virtual System.Collections.Generic.IList<string> ItemConditions { get; set; }

        /// <summary>
        /// Required. Immutable. This field represents the unique user-defined label of the return policy. It is
        /// important to note that the same label cannot be used in different return policies for the same country.
        /// Unless a product specifies a specific label attribute, policies will be automatically labeled as 'default'.
        /// To assign a custom return policy to certain product groups, follow the instructions provided in the [Return
        /// policy label] (https://support.google.com/merchants/answer/9445425). The label can contain up to 50
        /// characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>
        /// Identifier. The name of the `OnlineReturnPolicy` resource. Format:
        /// `accounts/{account}/onlineReturnPolicies/{return_policy}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. The return policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual Policy Policy { get; set; }

        /// <summary>
        /// Optional. The field specifies the number of days it takes for merchants to process refunds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processRefundDays")]
        public virtual System.Nullable<int> ProcessRefundDays { get; set; }

        /// <summary>
        /// Optional. The restocking fee that applies to all return reason categories. This would be treated as a free
        /// restocking fee if the value is not set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restockingFee")]
        public virtual RestockingFee RestockingFee { get; set; }

        /// <summary>Optional. The field specifies the return label source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnLabelSource")]
        public virtual string ReturnLabelSource { get; set; }

        /// <summary>
        /// Optional. The return methods of how customers can return an item. This value is required to not be empty
        /// unless the type of return policy is noReturns.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnMethods")]
        public virtual System.Collections.Generic.IList<string> ReturnMethods { get; set; }

        /// <summary>Output only. Return policy ID generated by Google.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnPolicyId")]
        public virtual string ReturnPolicyId { get; set; }

        /// <summary>
        /// Required. The return policy uri. This can used by Google to do a sanity check for the policy. It must be a
        /// valid URL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnPolicyUri")]
        public virtual string ReturnPolicyUri { get; set; }

        /// <summary>
        /// Optional. The return shipping fee. Should be set only when customer need to download and print the return
        /// label.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnShippingFee")]
        public virtual ReturnShippingFee ReturnShippingFee { get; set; }

        /// <summary>
        /// Optional. Overrides to the general policy for orders placed during a specific set of time intervals.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seasonalOverrides")]
        public virtual System.Collections.Generic.IList<SeasonalOverride> SeasonalOverrides { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An object representing a phone number, suitable as an API wire format. This representation: - should not be used
    /// for locale-specific formatting of a phone number, such as "+1 (650) 253-0000 ext. 123" - is not designed for
    /// efficient storage - may not be suitable for dialing - specialized libraries (see references) should be used to
    /// parse the number for that purpose To do something meaningful with this number, such as format it for various
    /// use-cases, convert it to an `i18n.phonenumbers.PhoneNumber` object first. For instance, in Java this would be:
    /// com.google.type.PhoneNumber wireProto = com.google.type.PhoneNumber.newBuilder().build();
    /// com.google.i18n.phonenumbers.Phonenumber.PhoneNumber phoneNumber =
    /// PhoneNumberUtil.getInstance().parse(wireProto.getE164Number(), "ZZ"); if (!wireProto.getExtension().isEmpty()) {
    /// phoneNumber.setExtension(wireProto.getExtension()); } Reference(s): - https://github.com/google/libphonenumber
    /// </summary>
    public class PhoneNumber : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The phone number, represented as a leading plus sign ('+'), followed by a phone number that uses a relaxed
        /// ITU E.164 format consisting of the country calling code (1 to 3 digits) and the subscriber number, with no
        /// additional spaces or formatting. For example: - correct: "+15552220123" - incorrect: "+1 (555) 222-01234
        /// x123". The ITU E.164 format limits the latter to 12 digits, but in practice not all countries respect that,
        /// so we relax that restriction here. National-only numbers are not allowed. References: -
        /// https://www.itu.int/rec/T-REC-E.164-201011-I - https://en.wikipedia.org/wiki/E.164. -
        /// https://en.wikipedia.org/wiki/List_of_country_calling_codes
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("e164Number")]
        public virtual string E164Number { get; set; }

        /// <summary>
        /// The phone number's extension. The extension is not standardized in ITU recommendations, except for being
        /// defined as a series of numbers with a maximum length of 40 digits. Other than digits, some other dialing
        /// characters such as ',' (indicating a wait) or '#' may be stored here. Note that no regions currently use
        /// extensions with short codes, so this field is normally only set in conjunction with an E.164 number. It is
        /// held separately from the E.164 number to allow for short code extensions in the future.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extension")]
        public virtual string Extension { get; set; }

        /// <summary>A short code. Reference(s): - https://en.wikipedia.org/wiki/Short_code</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortCode")]
        public virtual ShortCode ShortCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The available policies.</summary>
    public class Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The number of days items can be returned after delivery, where one day is defined as 24 hours after the
        /// delivery timestamp. Required for `NUMBER_OF_DAYS_AFTER_DELIVERY` returns.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("days")]
        public virtual System.Nullable<long> Days { get; set; }

        /// <summary>Policy type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

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
    public class PostalAddress : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>
    /// A list of postal codes that defines the region area. Note: All regions defined using postal codes are accessible
    /// through the account's `ShippingSettings.postalCodeGroups` resource.
    /// </summary>
    public class PostalCodeArea : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. A range of postal codes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCodes")]
        public virtual System.Collections.Generic.IList<PostalCodeRange> PostalCodes { get; set; }

        /// <summary>
        /// Required. [CLDR territory code](http://www.unicode.org/repos/cldr/tags/latest/common/main/en.xml) or the
        /// country the postal code group applies to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A range of postal codes that defines the region area.</summary>
    public class PostalCodeRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A postal code or a pattern of the form prefix* denoting the inclusive lower bound of the range
        /// defining the area. Examples values: `94108`, `9410*`, `9*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("begin")]
        public virtual string Begin { get; set; }

        /// <summary>
        /// Optional. A postal code or a pattern of the form `prefix*` denoting the inclusive upper bound of the range
        /// defining the area. It must have the same length as postalCodeRangeBegin: if postalCodeRangeBegin is a postal
        /// code then postalCodeRangeEnd must be a postal code too; if postalCodeRangeBegin is a pattern then
        /// postalCodeRangeEnd must be a pattern with the same prefix length. Optional: if not set, then the area is
        /// defined as being all the postal codes matching postalCodeRangeBegin.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("end")]
        public virtual string End { get; set; }

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

    /// <summary>`ProductsManagement` payload.</summary>
    public class ProductsManagement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines participation in a given program for the specified account. Programs provide a mechanism for adding
    /// functionality to merchant accounts. A typical example of this is the [Free product
    /// listings](https://support.google.com/merchants/answer/13889434) program, which enables products from a
    /// merchant's store to be shown across Google for free. The following list is the available set of program resource
    /// IDs accessible through the API: * `free-listings` * `shopping-ads` * `youtube-shopping-checkout`
    /// </summary>
    public class Program : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The regions in which the account is actively participating in the program. Active regions are
        /// defined as those where all program requirements affecting the regions have been met. Region codes are
        /// defined by [CLDR](https://cldr.unicode.org/). This is either a country where the program applies
        /// specifically to that country or `001` when the program applies globally.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeRegionCodes")]
        public virtual System.Collections.Generic.IList<string> ActiveRegionCodes { get; set; }

        /// <summary>Output only. The URL of a Merchant Center help page describing the program.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentationUri")]
        public virtual string DocumentationUri { get; set; }

        /// <summary>
        /// Identifier. The resource name of the program. Format: `accounts/{account}/programs/{program}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The participation state of the account in the program.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Output only. The requirements that the account has not yet satisfied that are affecting participation in the
        /// program.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unmetRequirements")]
        public virtual System.Collections.Generic.IList<Requirement> UnmetRequirements { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to propose an account service.</summary>
    public class ProposeAccountServiceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The account service to propose.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountService")]
        public virtual AccountService AccountService { get; set; }

        /// <summary>
        /// Required. The provider of the service. Either the reference to an account such as `providers/123` or a
        /// well-known service provider (one of `providers/GOOGLE_ADS` or `providers/GOOGLE_BUSINESS_PROFILE`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provider")]
        public virtual string Provider { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Shipping rate group definitions. Only the last one is allowed to have an empty `applicable_shipping_labels`,
    /// which means "everything else". The other `applicable_shipping_labels` must not overlap.
    /// </summary>
    public class RateGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A list of [shipping labels](https://support.google.com/merchants/answer/6324504) defining the
        /// products to which this rate group applies to. This is a disjunction: only one of the labels has to match for
        /// the rate group to apply. May only be empty for the last rate group of a service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicableShippingLabels")]
        public virtual System.Collections.Generic.IList<string> ApplicableShippingLabels { get; set; }

        /// <summary>
        /// Optional. A list of carrier rates that can be referred to by `main_table` or `single_value`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("carrierRates")]
        public virtual System.Collections.Generic.IList<CarrierRate> CarrierRates { get; set; }

        /// <summary>
        /// A table defining the rate group, when `single_value` is not expressive enough. Can only be set if
        /// `single_value` is not set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mainTable")]
        public virtual Table MainTable { get; set; }

        /// <summary>Optional. Name of the rate group. If set has to be unique within shipping service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The value of the rate group (For example flat rate $10). Can only be set if `main_table` and `subtables` are
        /// not set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("singleValue")]
        public virtual Value SingleValue { get; set; }

        /// <summary>
        /// Optional. A list of subtables referred to by `main_table`. Can only be set if `main_table` is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subtables")]
        public virtual System.Collections.Generic.IList<Table> Subtables { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a geographic region that you can use as a target with both the `RegionalInventory` and
    /// `ShippingSettings` services. You can define regions as collections of either postal codes or, in some countries,
    /// using predefined geotargets. For more information, see [Set up regions
    /// ](https://support.google.com/merchants/answer/7410946#zippy=%2Ccreate-a-new-region) for more information.
    /// </summary>
    public class Region : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The display name of the region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Optional. A list of geotargets that defines the region area.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("geotargetArea")]
        public virtual GeoTargetArea GeotargetArea { get; set; }

        /// <summary>
        /// Identifier. The resource name of the region. Format: `accounts/{account}/regions/{region}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. A list of postal codes that defines the region area.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCodeArea")]
        public virtual PostalCodeArea PostalCodeArea { get; set; }

        /// <summary>
        /// Output only. Indicates if the region is eligible for use in the Regional Inventory configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionalInventoryEligible")]
        public virtual System.Nullable<bool> RegionalInventoryEligible { get; set; }

        /// <summary>
        /// Output only. Indicates if the region is eligible for use in the Shipping Services configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shippingEligible")]
        public virtual System.Nullable<bool> ShippingEligible { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to reject an account service.</summary>
    public class RejectAccountServiceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes the terms of service which are required to be accepted.</summary>
    public class Required : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The `TermsOfService` that need to be accepted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("termsOfService")]
        public virtual string TermsOfService { get; set; }

        /// <summary>
        /// Full URL to the terms of service file. This field is the same as `TermsOfService.file_uri`, it is added here
        /// for convenience only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tosFileUri")]
        public virtual string TosFileUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines a requirement specified for participation in the program.</summary>
    public class Requirement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The regions that are currently affected by this requirement not being met. Region codes are
        /// defined by [CLDR](https://cldr.unicode.org/). This is either a country where the program applies
        /// specifically to that country or `001` when the program applies globally.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("affectedRegionCodes")]
        public virtual System.Collections.Generic.IList<string> AffectedRegionCodes { get; set; }

        /// <summary>Output only. The URL of a help page describing the requirement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentationUri")]
        public virtual string DocumentationUri { get; set; }

        /// <summary>Output only. Name of the requirement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The restocking fee. This can be a flat fee or a micro percent.</summary>
    public class RestockingFee : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Fixed restocking fee.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixedFee")]
        public virtual Price FixedFee { get; set; }

        /// <summary>
        /// Percent of total price in micros. 15,000,000 means 15% of the total price would be charged.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("microPercent")]
        public virtual System.Nullable<int> MicroPercent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The return shipping fee. This can either be a fixed fee or a boolean to indicate that the customer pays the
    /// actual shipping cost.
    /// </summary>
    public class ReturnShippingFee : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Fixed return shipping fee amount. This value is only applicable when type is `FIXED`. We will treat the
        /// return shipping fee as free if type is `FIXED` and this value is not set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixedFee")]
        public virtual Price FixedFee { get; set; }

        /// <summary>Required. Type of return shipping fee.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Include a list of cells.</summary>
    public class Row : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The list of cells that constitute the row. Must have the same length as `columnHeaders` for
        /// two-dimensional tables, a length of 1 for one-dimensional tables.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cells")]
        public virtual System.Collections.Generic.IList<Value> Cells { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SeasonalOverride : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. seasonal override end date (inclusive).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual Date EndDate { get; set; }

        /// <summary>Required. Display name of this seasonal override in Merchant Center.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>Number of days (from the delivery date) that the product can be returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnDays")]
        public virtual System.Nullable<int> ReturnDays { get; set; }

        /// <summary>Fixed end date until which the product can be returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnUntilDate")]
        public virtual Date ReturnUntilDate { get; set; }

        /// <summary>
        /// Required. Defines the date range when this seasonal override applies. Both start_date and end_date are
        /// inclusive. The dates of the seasonal overrides should not overlap.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual Date StartDate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Shipping service.</summary>
    public class Service : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. A boolean exposing the active status of the shipping service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("active")]
        public virtual System.Nullable<bool> Active { get; set; }

        /// <summary>
        /// Required. The CLDR code of the currency to which this service applies. Must match that of the prices in rate
        /// groups.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>Required. The CLDR territory code of the countries to which the service applies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliveryCountries")]
        public virtual System.Collections.Generic.IList<string> DeliveryCountries { get; set; }

        /// <summary>Required. Time spent in various aspects from order to the delivery of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliveryTime")]
        public virtual DeliveryTime DeliveryTime { get; set; }

        /// <summary>Optional. Loyalty programs that this shipping service is limited to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loyaltyPrograms")]
        public virtual System.Collections.Generic.IList<LoyaltyProgram> LoyaltyPrograms { get; set; }

        /// <summary>
        /// Minimum order value for this service. If set, indicates that customers will have to spend at least this
        /// amount. All prices within a service must have the same currency. Cannot be set together with
        /// minimum_order_value_table.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumOrderValue")]
        public virtual Price MinimumOrderValue { get; set; }

        /// <summary>
        /// Table of per store minimum order values for the pickup fulfillment type. Cannot be set together with
        /// minimum_order_value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumOrderValueTable")]
        public virtual MinimumOrderValueTable MinimumOrderValueTable { get; set; }

        /// <summary>
        /// Optional. Shipping rate group definitions. Only the last one is allowed to have an empty
        /// `applicable_shipping_labels`, which means "everything else". The other `applicable_shipping_labels` must not
        /// overlap.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rateGroups")]
        public virtual System.Collections.Generic.IList<RateGroup> RateGroups { get; set; }

        /// <summary>Required. Free-form name of the service. Must be unique within target account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceName")]
        public virtual string ServiceName { get; set; }

        /// <summary>Type of locations this service ships orders to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shipmentType")]
        public virtual string ShipmentType { get; set; }

        /// <summary>
        /// A list of stores your products are delivered from. This is only valid for the local delivery shipment type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storeConfig")]
        public virtual StoreConfig StoreConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The merchant account's [shipping settings](https://support.google.com/merchants/answer/6069284).
    /// </summary>
    public class ShippingSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. This field is used for avoid async issue. Make sure shipping setting data didn't change between
        /// get call and insert call. The user should do following steps： 1. Set etag field as empty string for initial
        /// shipping setting creation. 2. After initial creation, call get method to obtain an etag and current shipping
        /// setting data before call insert. 3. Modify to wanted shipping setting information. 4. Call insert method
        /// with the wanted shipping setting information with the etag obtained from step 2. 5. If shipping setting data
        /// changed between step 2 and step 4. Insert request will fail because the etag changes every time the shipping
        /// setting data changes. User should repeate step 2-4 with the new etag.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Identifier. The resource name of the shipping settings. Format: `accounts/{account}/shippingSettings`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. The target account's list of services.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("services")]
        public virtual System.Collections.Generic.IList<Service> Services { get; set; }

        /// <summary>Optional. A list of warehouses which can be referred to in `services`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warehouses")]
        public virtual System.Collections.Generic.IList<Warehouse> Warehouses { get; set; }
    }

    /// <summary>
    /// An object representing a short code, which is a phone number that is typically much shorter than regular phone
    /// numbers and can be used to address messages in MMS and SMS systems, as well as for abbreviated dialing (For
    /// example "Text 611 to see how many minutes you have remaining on your plan."). Short codes are restricted to a
    /// region and are not internationally dialable, which means the same short code can exist in different regions,
    /// with different usage and pricing, even if those regions share the same country calling code (For example: US and
    /// CA).
    /// </summary>
    public class ShortCode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The short code digits, without a leading plus ('+') or country calling code. For example "611".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("number")]
        public virtual string Number { get; set; }

        /// <summary>
        /// Required. The BCP-47 region code of the location where calls to this short code can be made, such as "US"
        /// and "BB". Reference(s): - http://www.unicode.org/reports/tr35/#unicode_region_subtag
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A list of store code sets sharing the same minimum order value. At least two sets are required and the last one
    /// must be empty, which signifies 'MOV for all other stores'. Each store code can only appear once across all the
    /// sets. All prices within a service must have the same currency.
    /// </summary>
    public class StoreCodeSetWithMov : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. A list of unique store codes or empty for the catch all.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storeCodes")]
        public virtual System.Collections.Generic.IList<string> StoreCodes { get; set; }

        /// <summary>The minimum order value for the given stores.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual Price Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A list of stores your products are delivered from. This is only valid for the local delivery shipment type.
    /// </summary>
    public class StoreConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Configs related to local delivery ends for the day.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cutoffConfig")]
        public virtual CutoffConfig CutoffConfig { get; set; }

        /// <summary>Maximum delivery radius. This is only required for the local delivery shipment type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceRadius")]
        public virtual Distance ServiceRadius { get; set; }

        /// <summary>
        /// Optional. A list of store codes that provide local delivery. If empty, then `all_stores` must be true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storeCodes")]
        public virtual System.Collections.Generic.IList<string> StoreCodes { get; set; }

        /// <summary>
        /// Indicates whether all stores, or selected stores, listed by this merchant provide local delivery.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storeServiceType")]
        public virtual string StoreServiceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A table defining the rate group, when `single_value` is not expressive enough.</summary>
    public class Table : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Headers of the table's columns. Optional: if not set then the table has only one dimension.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnHeaders")]
        public virtual Headers ColumnHeaders { get; set; }

        /// <summary>Name of the table. Required for subtables, ignored for the main table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. Headers of the table's rows.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowHeaders")]
        public virtual Headers RowHeaders { get; set; }

        /// <summary>
        /// Required. The list of rows that constitute the table. Must have the same length as `row_headers`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<Row> Rows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The `TermsOfService` message represents a specific version of the terms of service that merchants must accept to
    /// access certain features or services. For more information, see [Terms of
    /// Service](https://support.google.com/merchants/answer/160173). This message is important for the onboarding
    /// process, ensuring that merchants agree to the necessary legal agreements for using the service. Merchants can
    /// retrieve the latest terms of service for a given `kind` and `region` through `RetrieveLatestTermsOfService`, and
    /// accept them as required through `AcceptTermsOfService`.
    /// </summary>
    public class TermsOfService : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether this terms of service version is external. External terms of service versions can only be agreed
        /// through external processes and not directly by the merchant through UI or API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("external")]
        public virtual System.Nullable<bool> External { get; set; }

        /// <summary>URI for terms of service file that needs to be displayed to signing users.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileUri")]
        public virtual string FileUri { get; set; }

        /// <summary>The Kind this terms of service version applies to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Identifier. The resource name of the terms of service version. Format: `termsOfService/{version}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Region code as defined by [CLDR](https://cldr.unicode.org/). This is either a country where the ToS applies
        /// specifically to that country or `001` when the same `TermsOfService` can be signed in any country. However
        /// note that when signing a ToS that applies globally we still expect that a specific country is provided (this
        /// should be merchant business country or program country of participation).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This resource represents the agreement state for a given account and terms of service kind. The state is as
    /// follows: * If the merchant has accepted a terms of service, `accepted` will be populated, otherwise it will be
    /// empty * If the merchant must sign a terms of service, `required` will be populated, otherwise it will be empty.
    /// Note that both `required` and `accepted` can be present. In this case the `accepted` terms of services will have
    /// an expiration date set in the `valid_until` field. The `required` terms of services need to be accepted before
    /// `valid_until` in order for the account to continue having a valid agreement. When accepting new terms of
    /// services we expect 3Ps to display the text associated with the given terms of service agreement (the url to the
    /// file containing the text is added in the Required message below as `tos_file_uri`). The actual acceptance of the
    /// terms of service is done by calling accept on the `TermsOfService` resource.
    /// </summary>
    public class TermsOfServiceAgreementState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The accepted terms of service of this kind and for the associated region_code</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accepted")]
        public virtual Accepted Accepted { get; set; }

        /// <summary>
        /// Identifier. The resource name of the terms of service version. Format:
        /// `accounts/{account}/termsOfServiceAgreementState/{identifier}` The identifier format is:
        /// `{TermsOfServiceKind}-{country}` For example, an identifier could be: `MERCHANT_CENTER-US`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Region code as defined by https://cldr.unicode.org/. This is the country the current state applies to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>The required terms of service</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("required")]
        public virtual Required Required { get; set; }

        /// <summary>Terms of Service kind associated with the particular version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("termsOfServiceKind")]
        public virtual string TermsOfServiceKind { get; set; }

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

    /// <summary>
    /// Transit time table, number of business days spent in transit based on row and column dimensions. Either
    /// `min_transit_days`, `max_transit_days` or `transit_time_table` can be set, but not both.
    /// </summary>
    public class TransitTable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A list of region names Region.name . The last value can be `"all other locations"`. Example:
        /// `["zone 1", "zone 2", "all other locations"]`. The referred postal code groups must match the delivery
        /// country of the service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCodeGroupNames")]
        public virtual System.Collections.Generic.IList<string> PostalCodeGroupNames { get; set; }

        /// <summary>
        /// Required. If there's only one dimension set of `postal_code_group_names` or `transit_time_labels`, there are
        /// multiple rows each with one value for that dimension. If there are two dimensions, each row corresponds to a
        /// `postal_code_group_names`, and columns (values) to a `transit_time_labels`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<TransitTimeRow> Rows { get; set; }

        /// <summary>
        /// Required. A list of transit time labels. The last value can be `"all other labels"`. Example: `["food",
        /// "electronics", "all other labels"]`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transitTimeLabels")]
        public virtual System.Collections.Generic.IList<string> TransitTimeLabels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// If there's only one dimension set of `postal_code_group_names` or `transit_time_labels`, there are multiple rows
    /// each with one value for that dimension. If there are two dimensions, each row corresponds to a
    /// `postal_code_group_names`, and columns (values) to a `transit_time_labels`.
    /// </summary>
    public class TransitTimeRow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Transit time range (min-max) in business days.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<TransitTimeValue> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Transit time range (min-max) in business days.</summary>
    public class TransitTimeValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Must be greater than or equal to `min_transit_days`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxTransitDays")]
        public virtual System.Nullable<int> MaxTransitDays { get; set; }

        /// <summary>
        /// Minimum transit time range in business days. 0 means same day delivery, 1 means next day delivery.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minTransitDays")]
        public virtual System.Nullable<int> MinTransitDays { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the `UnclaimHomepage` method.</summary>
    public class UnclaimHomepageRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The `User` message represents a user associated with a Merchant Center account. It is used to manage user
    /// permissions and access rights within the account. For more information, see [Frequently asked questions about
    /// people and access levels](//support.google.com/merchants/answer/12160472).
    /// </summary>
    public class User : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The [access
        /// rights](https://support.google.com/merchants/answer/12160472?sjid=6789834943175119429-EU#accesstypes) the
        /// user has.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessRights")]
        public virtual System.Collections.Generic.IList<string> AccessRights { get; set; }

        /// <summary>
        /// Identifier. The resource name of the user. Format: `accounts/{account}/user/{email}` Use `me` to refer to
        /// your own email address, for example `accounts/{account}/users/me`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The state of the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The single value of a rate group or the value of a rate group table's cell. Exactly one of `no_shipping`,
    /// `flat_rate`, `price_percentage`, `carrier_rateName`, `subtable_name` must be set.
    /// </summary>
    public class Value : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of a carrier rate referring to a carrier rate defined in the same rate group. Can only be set if
        /// all other fields are not set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("carrierRate")]
        public virtual string CarrierRate { get; set; }

        /// <summary>A flat rate. Can only be set if all other fields are not set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flatRate")]
        public virtual Price FlatRate { get; set; }

        /// <summary>
        /// If true, then the product can't be shipped. Must be true when set, can only be set if all other fields are
        /// not set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noShipping")]
        public virtual System.Nullable<bool> NoShipping { get; set; }

        /// <summary>
        /// A percentage of the price represented as a number in decimal notation (For example, `"5.4"`). Can only be
        /// set if all other fields are not set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pricePercentage")]
        public virtual string PricePercentage { get; set; }

        /// <summary>
        /// The name of a subtable. Can only be set in table cells (For example, not for single values), and only if all
        /// other fields are not set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subtable")]
        public virtual string Subtable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A fulfillment warehouse, which stores and handles inventory.</summary>
    public class Warehouse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Business days of the warehouse. If not set, will be Monday to Friday by default.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("businessDayConfig")]
        public virtual BusinessDayConfig BusinessDayConfig { get; set; }

        /// <summary>
        /// Required. The latest time of day that an order can be accepted and begin processing. Later orders will be
        /// processed in the next day. The time is based on the warehouse postal code.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cutoffTime")]
        public virtual WarehouseCutoffTime CutoffTime { get; set; }

        /// <summary>
        /// Required. The number of days it takes for this warehouse to pack up and ship an item. This is on the
        /// warehouse level, but can be overridden on the offer level based on the attributes of an item.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("handlingDays")]
        public virtual System.Nullable<long> HandlingDays { get; set; }

        /// <summary>Required. The name of the warehouse. Must be unique within account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. Shipping address of the warehouse.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shippingAddress")]
        public virtual Address ShippingAddress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Indicates that the delivery time should be calculated per warehouse (shipping origin location) based on the
    /// settings of the selected carrier. When set, no other transit time related field in `delivery_time` should be
    /// set.
    /// </summary>
    public class WarehouseBasedDeliveryTime : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Carrier, such as `"UPS"` or `"Fedex"`. [supported
        /// carriers](https://support.google.com/merchants/answer/7050921#zippy=%2Ccarrier-rates-au-de-uk-and-us-only)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("carrier")]
        public virtual string Carrier { get; set; }

        /// <summary>
        /// Required. Carrier service, such as `"ground"` or `"2 days"`. The name of the service must be in the
        /// eddSupportedServices list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("carrierService")]
        public virtual string CarrierService { get; set; }

        /// <summary>Required. Warehouse name. This should match warehouse</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warehouse")]
        public virtual string Warehouse { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The latest time of day that an order can be accepted and begin processing. Later orders will be processed in the
    /// next day. The time is based on the warehouse postal code.
    /// </summary>
    public class WarehouseCutoffTime : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Hour of the cutoff time until which an order has to be placed to be processed in the same day by
        /// the warehouse. Hour is based on the timezone of warehouse.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hour")]
        public virtual System.Nullable<int> Hour { get; set; }

        /// <summary>
        /// Required. Minute of the cutoff time until which an order has to be placed to be processed in the same day by
        /// the warehouse. Minute is based on the timezone of warehouse.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minute")]
        public virtual System.Nullable<int> Minute { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The weight represented as the value in string and the unit.</summary>
    public class Weight : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The weight represented as a number in micros (1 million micros is an equivalent to one's currency
        /// standard unit, for example, 1 kg = 1000000 micros). This field can also be set as infinity by setting to -1.
        /// This field only support -1 and positive value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amountMicros")]
        public virtual System.Nullable<long> AmountMicros { get; set; }

        /// <summary>Required. The weight unit. Acceptable values are: kg and lb</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
