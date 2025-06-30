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

namespace Google.Apis.Adsense.v2
{
    /// <summary>The Adsense Service.</summary>
    public class AdsenseService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AdsenseService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AdsenseService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Accounts = new AccountsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://adsense.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://adsense.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "adsense";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the AdSense Management API.</summary>
        public class Scope
        {
            /// <summary>View and manage your AdSense data</summary>
            public static string Adsense = "https://www.googleapis.com/auth/adsense";

            /// <summary>View your AdSense data</summary>
            public static string AdsenseReadonly = "https://www.googleapis.com/auth/adsense.readonly";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the AdSense Management API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your AdSense data</summary>
            public const string Adsense = "https://www.googleapis.com/auth/adsense";

            /// <summary>View your AdSense data</summary>
            public const string AdsenseReadonly = "https://www.googleapis.com/auth/adsense.readonly";
        }

        /// <summary>Gets the Accounts resource.</summary>
        public virtual AccountsResource Accounts { get; }
    }

    /// <summary>A base abstract class for Adsense requests.</summary>
    public abstract class AdsenseBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new AdsenseBaseServiceRequest instance.</summary>
        protected AdsenseBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Adsense parameter list.</summary>
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
            Adclients = new AdclientsResource(service);
            Alerts = new AlertsResource(service);
            Payments = new PaymentsResource(service);
            PolicyIssues = new PolicyIssuesResource(service);
            Reports = new ReportsResource(service);
            Sites = new SitesResource(service);
        }

        /// <summary>Gets the Adclients resource.</summary>
        public virtual AdclientsResource Adclients { get; }

        /// <summary>The "adclients" collection of methods.</summary>
        public class AdclientsResource
        {
            private const string Resource = "adclients";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AdclientsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Adunits = new AdunitsResource(service);
                Customchannels = new CustomchannelsResource(service);
                Urlchannels = new UrlchannelsResource(service);
            }

            /// <summary>Gets the Adunits resource.</summary>
            public virtual AdunitsResource Adunits { get; }

            /// <summary>The "adunits" collection of methods.</summary>
            public class AdunitsResource
            {
                private const string Resource = "adunits";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AdunitsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Creates an ad unit. This method can be called only by a restricted set of projects, which are
                /// usually owned by [AdSense for Platforms](https://developers.google.com/adsense/platforms/)
                /// publishers. Contact your account manager if you need to use this method. Note that ad units can only
                /// be created for ad clients with an "AFC" product code. For more info see the [AdClient
                /// resource](/adsense/management/reference/rest/v2/accounts.adclients). For now, this method can only
                /// be used to create `DISPLAY` ad units. See: https://support.google.com/adsense/answer/9183566
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Ad client to create an ad unit under. Format: accounts/{account}/adclients/{adclient}
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Adsense.v2.Data.AdUnit body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Creates an ad unit. This method can be called only by a restricted set of projects, which are
                /// usually owned by [AdSense for Platforms](https://developers.google.com/adsense/platforms/)
                /// publishers. Contact your account manager if you need to use this method. Note that ad units can only
                /// be created for ad clients with an "AFC" product code. For more info see the [AdClient
                /// resource](/adsense/management/reference/rest/v2/accounts.adclients). For now, this method can only
                /// be used to create `DISPLAY` ad units. See: https://support.google.com/adsense/answer/9183566
                /// </summary>
                public class CreateRequest : AdsenseBaseServiceRequest<Google.Apis.Adsense.v2.Data.AdUnit>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Adsense.v2.Data.AdUnit body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Ad client to create an ad unit under. Format: accounts/{account}/adclients/{adclient}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Adsense.v2.Data.AdUnit Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/adunits";

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
                            Pattern = @"^accounts/[^/]+/adclients/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets an ad unit from a specified account and ad client.</summary>
                /// <param name="name">
                /// Required. AdUnit to get information about. Format:
                /// accounts/{account}/adclients/{adclient}/adunits/{adunit}
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets an ad unit from a specified account and ad client.</summary>
                public class GetRequest : AdsenseBaseServiceRequest<Google.Apis.Adsense.v2.Data.AdUnit>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. AdUnit to get information about. Format:
                    /// accounts/{account}/adclients/{adclient}/adunits/{adunit}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^accounts/[^/]+/adclients/[^/]+/adunits/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets the ad unit code for a given ad unit. For more information, see [About the AdSense
                /// code](https://support.google.com/adsense/answer/9274634) and [Where to place the ad code in your
                /// HTML](https://support.google.com/adsense/answer/9190028).
                /// </summary>
                /// <param name="name">
                /// Required. Name of the adunit for which to get the adcode. Format:
                /// accounts/{account}/adclients/{adclient}/adunits/{adunit}
                /// </param>
                public virtual GetAdcodeRequest GetAdcode(string name)
                {
                    return new GetAdcodeRequest(this.service, name);
                }

                /// <summary>
                /// Gets the ad unit code for a given ad unit. For more information, see [About the AdSense
                /// code](https://support.google.com/adsense/answer/9274634) and [Where to place the ad code in your
                /// HTML](https://support.google.com/adsense/answer/9190028).
                /// </summary>
                public class GetAdcodeRequest : AdsenseBaseServiceRequest<Google.Apis.Adsense.v2.Data.AdUnitAdCode>
                {
                    /// <summary>Constructs a new GetAdcode request.</summary>
                    public GetAdcodeRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the adunit for which to get the adcode. Format:
                    /// accounts/{account}/adclients/{adclient}/adunits/{adunit}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getAdcode";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}/adcode";

                    /// <summary>Initializes GetAdcode parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^accounts/[^/]+/adclients/[^/]+/adunits/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists all ad units under a specified account and ad client.</summary>
                /// <param name="parent">
                /// Required. The ad client which owns the collection of ad units. Format:
                /// accounts/{account}/adclients/{adclient}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists all ad units under a specified account and ad client.</summary>
                public class ListRequest : AdsenseBaseServiceRequest<Google.Apis.Adsense.v2.Data.ListAdUnitsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The ad client which owns the collection of ad units. Format:
                    /// accounts/{account}/adclients/{adclient}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of ad units to include in the response, used for paging. If unspecified, at
                    /// most 10000 ad units will be returned. The maximum value is 10000; values above 10000 will be
                    /// coerced to 10000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `ListAdUnits` call. Provide this to retrieve the
                    /// subsequent page. When paginating, all other parameters provided to `ListAdUnits` must match the
                    /// call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/adunits";

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
                            Pattern = @"^accounts/[^/]+/adclients/[^/]+$",
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

                /// <summary>Lists all the custom channels available for an ad unit.</summary>
                /// <param name="parent">
                /// Required. The ad unit which owns the collection of custom channels. Format:
                /// accounts/{account}/adclients/{adclient}/adunits/{adunit}
                /// </param>
                public virtual ListLinkedCustomChannelsRequest ListLinkedCustomChannels(string parent)
                {
                    return new ListLinkedCustomChannelsRequest(this.service, parent);
                }

                /// <summary>Lists all the custom channels available for an ad unit.</summary>
                public class ListLinkedCustomChannelsRequest : AdsenseBaseServiceRequest<Google.Apis.Adsense.v2.Data.ListLinkedCustomChannelsResponse>
                {
                    /// <summary>Constructs a new ListLinkedCustomChannels request.</summary>
                    public ListLinkedCustomChannelsRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The ad unit which owns the collection of custom channels. Format:
                    /// accounts/{account}/adclients/{adclient}/adunits/{adunit}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of custom channels to include in the response, used for paging. If
                    /// unspecified, at most 10000 custom channels will be returned. The maximum value is 10000; values
                    /// above 10000 will be coerced to 10000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `ListLinkedCustomChannels` call. Provide this to retrieve
                    /// the subsequent page. When paginating, all other parameters provided to
                    /// `ListLinkedCustomChannels` must match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "listLinkedCustomChannels";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}:listLinkedCustomChannels";

                    /// <summary>Initializes ListLinkedCustomChannels parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^accounts/[^/]+/adclients/[^/]+/adunits/[^/]+$",
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
                /// Updates an ad unit. This method can be called only by a restricted set of projects, which are
                /// usually owned by [AdSense for Platforms](https://developers.google.com/adsense/platforms/)
                /// publishers. Contact your account manager if you need to use this method. For now, this method can
                /// only be used to update `DISPLAY` ad units. See: https://support.google.com/adsense/answer/9183566
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. Resource name of the ad unit. Format:
                /// accounts/{account}/adclients/{adclient}/adunits/{adunit}
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Adsense.v2.Data.AdUnit body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>
                /// Updates an ad unit. This method can be called only by a restricted set of projects, which are
                /// usually owned by [AdSense for Platforms](https://developers.google.com/adsense/platforms/)
                /// publishers. Contact your account manager if you need to use this method. For now, this method can
                /// only be used to update `DISPLAY` ad units. See: https://support.google.com/adsense/answer/9183566
                /// </summary>
                public class PatchRequest : AdsenseBaseServiceRequest<Google.Apis.Adsense.v2.Data.AdUnit>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Adsense.v2.Data.AdUnit body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. Resource name of the ad unit. Format:
                    /// accounts/{account}/adclients/{adclient}/adunits/{adunit}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>The list of fields to update. If empty, a full update is performed.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Adsense.v2.Data.AdUnit Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^accounts/[^/]+/adclients/[^/]+/adunits/[^/]+$",
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

            /// <summary>Gets the Customchannels resource.</summary>
            public virtual CustomchannelsResource Customchannels { get; }

            /// <summary>The "customchannels" collection of methods.</summary>
            public class CustomchannelsResource
            {
                private const string Resource = "customchannels";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public CustomchannelsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Creates a custom channel. This method can be called only by a restricted set of projects, which are
                /// usually owned by [AdSense for Platforms](https://developers.google.com/adsense/platforms/)
                /// publishers. Contact your account manager if you need to use this method.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The ad client to create a custom channel under. Format:
                /// accounts/{account}/adclients/{adclient}
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Adsense.v2.Data.CustomChannel body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Creates a custom channel. This method can be called only by a restricted set of projects, which are
                /// usually owned by [AdSense for Platforms](https://developers.google.com/adsense/platforms/)
                /// publishers. Contact your account manager if you need to use this method.
                /// </summary>
                public class CreateRequest : AdsenseBaseServiceRequest<Google.Apis.Adsense.v2.Data.CustomChannel>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Adsense.v2.Data.CustomChannel body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The ad client to create a custom channel under. Format:
                    /// accounts/{account}/adclients/{adclient}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Adsense.v2.Data.CustomChannel Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/customchannels";

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
                            Pattern = @"^accounts/[^/]+/adclients/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Deletes a custom channel. This method can be called only by a restricted set of projects, which are
                /// usually owned by [AdSense for Platforms](https://developers.google.com/adsense/platforms/)
                /// publishers. Contact your account manager if you need to use this method.
                /// </summary>
                /// <param name="name">
                /// Required. Name of the custom channel to delete. Format:
                /// accounts/{account}/adclients/{adclient}/customchannels/{customchannel}
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes a custom channel. This method can be called only by a restricted set of projects, which are
                /// usually owned by [AdSense for Platforms](https://developers.google.com/adsense/platforms/)
                /// publishers. Contact your account manager if you need to use this method.
                /// </summary>
                public class DeleteRequest : AdsenseBaseServiceRequest<Google.Apis.Adsense.v2.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the custom channel to delete. Format:
                    /// accounts/{account}/adclients/{adclient}/customchannels/{customchannel}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^accounts/[^/]+/adclients/[^/]+/customchannels/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets information about the selected custom channel.</summary>
                /// <param name="name">
                /// Required. Name of the custom channel. Format:
                /// accounts/{account}/adclients/{adclient}/customchannels/{customchannel}
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets information about the selected custom channel.</summary>
                public class GetRequest : AdsenseBaseServiceRequest<Google.Apis.Adsense.v2.Data.CustomChannel>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the custom channel. Format:
                    /// accounts/{account}/adclients/{adclient}/customchannels/{customchannel}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^accounts/[^/]+/adclients/[^/]+/customchannels/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists all the custom channels available in an ad client.</summary>
                /// <param name="parent">
                /// Required. The ad client which owns the collection of custom channels. Format:
                /// accounts/{account}/adclients/{adclient}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists all the custom channels available in an ad client.</summary>
                public class ListRequest : AdsenseBaseServiceRequest<Google.Apis.Adsense.v2.Data.ListCustomChannelsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The ad client which owns the collection of custom channels. Format:
                    /// accounts/{account}/adclients/{adclient}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of custom channels to include in the response, used for paging. If
                    /// unspecified, at most 10000 custom channels will be returned. The maximum value is 10000; values
                    /// above 10000 will be coerced to 10000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `ListCustomChannels` call. Provide this to retrieve the
                    /// subsequent page. When paginating, all other parameters provided to `ListCustomChannels` must
                    /// match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/customchannels";

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
                            Pattern = @"^accounts/[^/]+/adclients/[^/]+$",
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

                /// <summary>Lists all the ad units available for a custom channel.</summary>
                /// <param name="parent">
                /// Required. The custom channel which owns the collection of ad units. Format:
                /// accounts/{account}/adclients/{adclient}/customchannels/{customchannel}
                /// </param>
                public virtual ListLinkedAdUnitsRequest ListLinkedAdUnits(string parent)
                {
                    return new ListLinkedAdUnitsRequest(this.service, parent);
                }

                /// <summary>Lists all the ad units available for a custom channel.</summary>
                public class ListLinkedAdUnitsRequest : AdsenseBaseServiceRequest<Google.Apis.Adsense.v2.Data.ListLinkedAdUnitsResponse>
                {
                    /// <summary>Constructs a new ListLinkedAdUnits request.</summary>
                    public ListLinkedAdUnitsRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The custom channel which owns the collection of ad units. Format:
                    /// accounts/{account}/adclients/{adclient}/customchannels/{customchannel}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of ad units to include in the response, used for paging. If unspecified, at
                    /// most 10000 ad units will be returned. The maximum value is 10000; values above 10000 will be
                    /// coerced to 10000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `ListLinkedAdUnits` call. Provide this to retrieve the
                    /// subsequent page. When paginating, all other parameters provided to `ListLinkedAdUnits` must
                    /// match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "listLinkedAdUnits";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}:listLinkedAdUnits";

                    /// <summary>Initializes ListLinkedAdUnits parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^accounts/[^/]+/adclients/[^/]+/customchannels/[^/]+$",
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
                /// Updates a custom channel. This method can be called only by a restricted set of projects, which are
                /// usually owned by [AdSense for Platforms](https://developers.google.com/adsense/platforms/)
                /// publishers. Contact your account manager if you need to use this method.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. Resource name of the custom channel. Format:
                /// accounts/{account}/adclients/{adclient}/customchannels/{customchannel}
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Adsense.v2.Data.CustomChannel body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>
                /// Updates a custom channel. This method can be called only by a restricted set of projects, which are
                /// usually owned by [AdSense for Platforms](https://developers.google.com/adsense/platforms/)
                /// publishers. Contact your account manager if you need to use this method.
                /// </summary>
                public class PatchRequest : AdsenseBaseServiceRequest<Google.Apis.Adsense.v2.Data.CustomChannel>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Adsense.v2.Data.CustomChannel body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. Resource name of the custom channel. Format:
                    /// accounts/{account}/adclients/{adclient}/customchannels/{customchannel}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>The list of fields to update. If empty, a full update is performed.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Adsense.v2.Data.CustomChannel Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^accounts/[^/]+/adclients/[^/]+/customchannels/[^/]+$",
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

            /// <summary>Gets the Urlchannels resource.</summary>
            public virtual UrlchannelsResource Urlchannels { get; }

            /// <summary>The "urlchannels" collection of methods.</summary>
            public class UrlchannelsResource
            {
                private const string Resource = "urlchannels";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public UrlchannelsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Gets information about the selected url channel.</summary>
                /// <param name="name">
                /// Required. The name of the url channel to retrieve. Format:
                /// accounts/{account}/adclients/{adclient}/urlchannels/{urlchannel}
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets information about the selected url channel.</summary>
                public class GetRequest : AdsenseBaseServiceRequest<Google.Apis.Adsense.v2.Data.UrlChannel>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the url channel to retrieve. Format:
                    /// accounts/{account}/adclients/{adclient}/urlchannels/{urlchannel}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^accounts/[^/]+/adclients/[^/]+/urlchannels/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists active url channels.</summary>
                /// <param name="parent">
                /// Required. The ad client which owns the collection of url channels. Format:
                /// accounts/{account}/adclients/{adclient}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists active url channels.</summary>
                public class ListRequest : AdsenseBaseServiceRequest<Google.Apis.Adsense.v2.Data.ListUrlChannelsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The ad client which owns the collection of url channels. Format:
                    /// accounts/{account}/adclients/{adclient}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of url channels to include in the response, used for paging. If unspecified,
                    /// at most 10000 url channels will be returned. The maximum value is 10000; values above 10000 will
                    /// be coerced to 10000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `ListUrlChannels` call. Provide this to retrieve the
                    /// subsequent page. When paginating, all other parameters provided to `ListUrlChannels` must match
                    /// the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/urlchannels";

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
                            Pattern = @"^accounts/[^/]+/adclients/[^/]+$",
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

            /// <summary>Gets the ad client from the given resource name.</summary>
            /// <param name="name">
            /// Required. The name of the ad client to retrieve. Format: accounts/{account}/adclients/{adclient}
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets the ad client from the given resource name.</summary>
            public class GetRequest : AdsenseBaseServiceRequest<Google.Apis.Adsense.v2.Data.AdClient>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the ad client to retrieve. Format: accounts/{account}/adclients/{adclient}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^accounts/[^/]+/adclients/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Gets the AdSense code for a given ad client. This returns what was previously known as the 'auto ad
            /// code'. This is only supported for ad clients with a product_code of AFC. For more information, see
            /// [About the AdSense code](https://support.google.com/adsense/answer/9274634).
            /// </summary>
            /// <param name="name">
            /// Required. Name of the ad client for which to get the adcode. Format:
            /// accounts/{account}/adclients/{adclient}
            /// </param>
            public virtual GetAdcodeRequest GetAdcode(string name)
            {
                return new GetAdcodeRequest(this.service, name);
            }

            /// <summary>
            /// Gets the AdSense code for a given ad client. This returns what was previously known as the 'auto ad
            /// code'. This is only supported for ad clients with a product_code of AFC. For more information, see
            /// [About the AdSense code](https://support.google.com/adsense/answer/9274634).
            /// </summary>
            public class GetAdcodeRequest : AdsenseBaseServiceRequest<Google.Apis.Adsense.v2.Data.AdClientAdCode>
            {
                /// <summary>Constructs a new GetAdcode request.</summary>
                public GetAdcodeRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the ad client for which to get the adcode. Format:
                /// accounts/{account}/adclients/{adclient}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getAdcode";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}/adcode";

                /// <summary>Initializes GetAdcode parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+/adclients/[^/]+$",
                    });
                }
            }

            /// <summary>Lists all the ad clients available in an account.</summary>
            /// <param name="parent">
            /// Required. The account which owns the collection of ad clients. Format: accounts/{account}
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists all the ad clients available in an account.</summary>
            public class ListRequest : AdsenseBaseServiceRequest<Google.Apis.Adsense.v2.Data.ListAdClientsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The account which owns the collection of ad clients. Format: accounts/{account}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of ad clients to include in the response, used for paging. If unspecified, at
                /// most 10000 ad clients will be returned. The maximum value is 10000; values above 10000 will be
                /// coerced to 10000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token, received from a previous `ListAdClients` call. Provide this to retrieve the subsequent
                /// page. When paginating, all other parameters provided to `ListAdClients` must match the call that
                /// provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/adclients";

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

        /// <summary>Gets the Alerts resource.</summary>
        public virtual AlertsResource Alerts { get; }

        /// <summary>The "alerts" collection of methods.</summary>
        public class AlertsResource
        {
            private const string Resource = "alerts";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AlertsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Lists all the alerts available in an account.</summary>
            /// <param name="parent">
            /// Required. The account which owns the collection of alerts. Format: accounts/{account}
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists all the alerts available in an account.</summary>
            public class ListRequest : AdsenseBaseServiceRequest<Google.Apis.Adsense.v2.Data.ListAlertsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The account which owns the collection of alerts. Format: accounts/{account}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The language to use for translating alert messages. If unspecified, this defaults to the user's
                /// display language. If the given language is not supported, alerts will be returned in English. The
                /// language is specified as an [IETF BCP-47 language
                /// code](https://en.wikipedia.org/wiki/IETF_language_tag).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string LanguageCode { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/alerts";

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
                }
            }
        }

        /// <summary>Gets the Payments resource.</summary>
        public virtual PaymentsResource Payments { get; }

        /// <summary>The "payments" collection of methods.</summary>
        public class PaymentsResource
        {
            private const string Resource = "payments";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public PaymentsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Lists all the payments available for an account.</summary>
            /// <param name="parent">
            /// Required. The account which owns the collection of payments. Format: accounts/{account}
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists all the payments available for an account.</summary>
            public class ListRequest : AdsenseBaseServiceRequest<Google.Apis.Adsense.v2.Data.ListPaymentsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The account which owns the collection of payments. Format: accounts/{account}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/payments";

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
                }
            }
        }

        /// <summary>Gets the PolicyIssues resource.</summary>
        public virtual PolicyIssuesResource PolicyIssues { get; }

        /// <summary>The "policyIssues" collection of methods.</summary>
        public class PolicyIssuesResource
        {
            private const string Resource = "policyIssues";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public PolicyIssuesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Gets information about the selected policy issue.</summary>
            /// <param name="name">
            /// Required. Name of the policy issue. Format: accounts/{account}/policyIssues/{policy_issue}
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets information about the selected policy issue.</summary>
            public class GetRequest : AdsenseBaseServiceRequest<Google.Apis.Adsense.v2.Data.PolicyIssue>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the policy issue. Format: accounts/{account}/policyIssues/{policy_issue}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^accounts/[^/]+/policyIssues/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists all the policy issues where the specified account is involved, both directly and through any AFP
            /// child accounts.
            /// </summary>
            /// <param name="parent">
            /// Required. The account for which policy issues are being retrieved. Format: accounts/{account}
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>
            /// Lists all the policy issues where the specified account is involved, both directly and through any AFP
            /// child accounts.
            /// </summary>
            public class ListRequest : AdsenseBaseServiceRequest<Google.Apis.Adsense.v2.Data.ListPolicyIssuesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The account for which policy issues are being retrieved. Format: accounts/{account}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of policy issues to include in the response, used for paging. If unspecified, at
                /// most 10000 policy issues will be returned. The maximum value is 10000; values above 10000 will be
                /// coerced to 10000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token, received from a previous `ListPolicyIssues` call. Provide this to retrieve the
                /// subsequent page. When paginating, all other parameters provided to `ListPolicyIssues` must match the
                /// call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/policyIssues";

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

        /// <summary>Gets the Reports resource.</summary>
        public virtual ReportsResource Reports { get; }

        /// <summary>The "reports" collection of methods.</summary>
        public class ReportsResource
        {
            private const string Resource = "reports";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ReportsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Saved = new SavedResource(service);
            }

            /// <summary>Gets the Saved resource.</summary>
            public virtual SavedResource Saved { get; }

            /// <summary>The "saved" collection of methods.</summary>
            public class SavedResource
            {
                private const string Resource = "saved";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public SavedResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Generates a saved report.</summary>
                /// <param name="name">
                /// Required. Name of the saved report. Format: accounts/{account}/reports/{report}
                /// </param>
                public virtual GenerateRequest Generate(string name)
                {
                    return new GenerateRequest(this.service, name);
                }

                /// <summary>Generates a saved report.</summary>
                public class GenerateRequest : AdsenseBaseServiceRequest<Google.Apis.Adsense.v2.Data.ReportResult>
                {
                    /// <summary>Constructs a new Generate request.</summary>
                    public GenerateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the saved report. Format: accounts/{account}/reports/{report}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The [ISO-4217 currency code](https://en.wikipedia.org/wiki/ISO_4217) to use when reporting on
                    /// monetary metrics. Defaults to the account's currency if not set.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("currencyCode", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string CurrencyCode { get; set; }

                    /// <summary>Date range of the report, if unset the range will be considered CUSTOM.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("dateRange", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<DateRangeEnum> DateRange { get; set; }

                    /// <summary>Date range of the report, if unset the range will be considered CUSTOM.</summary>
                    public enum DateRangeEnum
                    {
                        /// <summary>Unspecified date range.</summary>
                        [Google.Apis.Util.StringValueAttribute("REPORTING_DATE_RANGE_UNSPECIFIED")]
                        REPORTINGDATERANGEUNSPECIFIED = 0,

                        /// <summary>
                        /// A custom date range specified using the `start_date` and `end_date` fields. This is the
                        /// default if no ReportingDateRange is provided.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("CUSTOM")]
                        CUSTOM = 1,

                        /// <summary>Current day.</summary>
                        [Google.Apis.Util.StringValueAttribute("TODAY")]
                        TODAY = 2,

                        /// <summary>Yesterday.</summary>
                        [Google.Apis.Util.StringValueAttribute("YESTERDAY")]
                        YESTERDAY = 3,

                        /// <summary>
                        /// From the start of the current month to the current day. e.g. if the current date is
                        /// 2020-03-12 then the range will be [2020-03-01, 2020-03-12].
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("MONTH_TO_DATE")]
                        MONTHTODATE = 4,

                        /// <summary>
                        /// From the start of the current year to the current day. e.g. if the current date is
                        /// 2020-03-12 then the range will be [2020-01-01, 2020-03-12].
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("YEAR_TO_DATE")]
                        YEARTODATE = 5,

                        /// <summary>Last 7 days, excluding current day.</summary>
                        [Google.Apis.Util.StringValueAttribute("LAST_7_DAYS")]
                        LAST7DAYS = 6,

                        /// <summary>Last 30 days, excluding current day.</summary>
                        [Google.Apis.Util.StringValueAttribute("LAST_30_DAYS")]
                        LAST30DAYS = 7,
                    }

                    /// <summary>
                    /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by
                    /// itself or a year and month where the day isn't significant.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("endDate.day", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> EndDateDay { get; set; }

                    /// <summary>
                    /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("endDate.month", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> EndDateMonth { get; set; }

                    /// <summary>
                    /// Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("endDate.year", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> EndDateYear { get; set; }

                    /// <summary>
                    /// The language to use for translating report output. If unspecified, this defaults to English
                    /// ("en"). If the given language is not supported, report output will be returned in English. The
                    /// language is specified as an [IETF BCP-47 language
                    /// code](https://en.wikipedia.org/wiki/IETF_language_tag).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string LanguageCode { get; set; }

                    /// <summary>
                    /// Timezone in which to generate the report. If unspecified, this defaults to the account timezone.
                    /// For more information, see [changing the time zone of your
                    /// reports](https://support.google.com/adsense/answer/9830725).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("reportingTimeZone", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ReportingTimeZoneEnum> ReportingTimeZone { get; set; }

                    /// <summary>
                    /// Timezone in which to generate the report. If unspecified, this defaults to the account timezone.
                    /// For more information, see [changing the time zone of your
                    /// reports](https://support.google.com/adsense/answer/9830725).
                    /// </summary>
                    public enum ReportingTimeZoneEnum
                    {
                        /// <summary>Unspecified timezone.</summary>
                        [Google.Apis.Util.StringValueAttribute("REPORTING_TIME_ZONE_UNSPECIFIED")]
                        REPORTINGTIMEZONEUNSPECIFIED = 0,

                        /// <summary>Use the account timezone in the report.</summary>
                        [Google.Apis.Util.StringValueAttribute("ACCOUNT_TIME_ZONE")]
                        ACCOUNTTIMEZONE = 1,

                        /// <summary>Use the Google timezone in the report (America/Los_Angeles).</summary>
                        [Google.Apis.Util.StringValueAttribute("GOOGLE_TIME_ZONE")]
                        GOOGLETIMEZONE = 2,
                    }

                    /// <summary>
                    /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by
                    /// itself or a year and month where the day isn't significant.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("startDate.day", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> StartDateDay { get; set; }

                    /// <summary>
                    /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("startDate.month", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> StartDateMonth { get; set; }

                    /// <summary>
                    /// Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("startDate.year", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> StartDateYear { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "generate";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}/saved:generate";

                    /// <summary>Initializes Generate parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^accounts/[^/]+/reports/[^/]+$",
                        });
                        RequestParameters.Add("currencyCode", new Google.Apis.Discovery.Parameter
                        {
                            Name = "currencyCode",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("dateRange", new Google.Apis.Discovery.Parameter
                        {
                            Name = "dateRange",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("endDate.day", new Google.Apis.Discovery.Parameter
                        {
                            Name = "endDate.day",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("endDate.month", new Google.Apis.Discovery.Parameter
                        {
                            Name = "endDate.month",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("endDate.year", new Google.Apis.Discovery.Parameter
                        {
                            Name = "endDate.year",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("languageCode", new Google.Apis.Discovery.Parameter
                        {
                            Name = "languageCode",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("reportingTimeZone", new Google.Apis.Discovery.Parameter
                        {
                            Name = "reportingTimeZone",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("startDate.day", new Google.Apis.Discovery.Parameter
                        {
                            Name = "startDate.day",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("startDate.month", new Google.Apis.Discovery.Parameter
                        {
                            Name = "startDate.month",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("startDate.year", new Google.Apis.Discovery.Parameter
                        {
                            Name = "startDate.year",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Generates a csv formatted saved report.</summary>
                /// <param name="name">
                /// Required. Name of the saved report. Format: accounts/{account}/reports/{report}
                /// </param>
                public virtual GenerateCsvRequest GenerateCsv(string name)
                {
                    return new GenerateCsvRequest(this.service, name);
                }

                /// <summary>Generates a csv formatted saved report.</summary>
                public class GenerateCsvRequest : AdsenseBaseServiceRequest<Google.Apis.Adsense.v2.Data.HttpBody>
                {
                    /// <summary>Constructs a new GenerateCsv request.</summary>
                    public GenerateCsvRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the saved report. Format: accounts/{account}/reports/{report}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The [ISO-4217 currency code](https://en.wikipedia.org/wiki/ISO_4217) to use when reporting on
                    /// monetary metrics. Defaults to the account's currency if not set.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("currencyCode", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string CurrencyCode { get; set; }

                    /// <summary>Date range of the report, if unset the range will be considered CUSTOM.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("dateRange", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<DateRangeEnum> DateRange { get; set; }

                    /// <summary>Date range of the report, if unset the range will be considered CUSTOM.</summary>
                    public enum DateRangeEnum
                    {
                        /// <summary>Unspecified date range.</summary>
                        [Google.Apis.Util.StringValueAttribute("REPORTING_DATE_RANGE_UNSPECIFIED")]
                        REPORTINGDATERANGEUNSPECIFIED = 0,

                        /// <summary>
                        /// A custom date range specified using the `start_date` and `end_date` fields. This is the
                        /// default if no ReportingDateRange is provided.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("CUSTOM")]
                        CUSTOM = 1,

                        /// <summary>Current day.</summary>
                        [Google.Apis.Util.StringValueAttribute("TODAY")]
                        TODAY = 2,

                        /// <summary>Yesterday.</summary>
                        [Google.Apis.Util.StringValueAttribute("YESTERDAY")]
                        YESTERDAY = 3,

                        /// <summary>
                        /// From the start of the current month to the current day. e.g. if the current date is
                        /// 2020-03-12 then the range will be [2020-03-01, 2020-03-12].
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("MONTH_TO_DATE")]
                        MONTHTODATE = 4,

                        /// <summary>
                        /// From the start of the current year to the current day. e.g. if the current date is
                        /// 2020-03-12 then the range will be [2020-01-01, 2020-03-12].
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("YEAR_TO_DATE")]
                        YEARTODATE = 5,

                        /// <summary>Last 7 days, excluding current day.</summary>
                        [Google.Apis.Util.StringValueAttribute("LAST_7_DAYS")]
                        LAST7DAYS = 6,

                        /// <summary>Last 30 days, excluding current day.</summary>
                        [Google.Apis.Util.StringValueAttribute("LAST_30_DAYS")]
                        LAST30DAYS = 7,
                    }

                    /// <summary>
                    /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by
                    /// itself or a year and month where the day isn't significant.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("endDate.day", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> EndDateDay { get; set; }

                    /// <summary>
                    /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("endDate.month", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> EndDateMonth { get; set; }

                    /// <summary>
                    /// Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("endDate.year", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> EndDateYear { get; set; }

                    /// <summary>
                    /// The language to use for translating report output. If unspecified, this defaults to English
                    /// ("en"). If the given language is not supported, report output will be returned in English. The
                    /// language is specified as an [IETF BCP-47 language
                    /// code](https://en.wikipedia.org/wiki/IETF_language_tag).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string LanguageCode { get; set; }

                    /// <summary>
                    /// Timezone in which to generate the report. If unspecified, this defaults to the account timezone.
                    /// For more information, see [changing the time zone of your
                    /// reports](https://support.google.com/adsense/answer/9830725).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("reportingTimeZone", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ReportingTimeZoneEnum> ReportingTimeZone { get; set; }

                    /// <summary>
                    /// Timezone in which to generate the report. If unspecified, this defaults to the account timezone.
                    /// For more information, see [changing the time zone of your
                    /// reports](https://support.google.com/adsense/answer/9830725).
                    /// </summary>
                    public enum ReportingTimeZoneEnum
                    {
                        /// <summary>Unspecified timezone.</summary>
                        [Google.Apis.Util.StringValueAttribute("REPORTING_TIME_ZONE_UNSPECIFIED")]
                        REPORTINGTIMEZONEUNSPECIFIED = 0,

                        /// <summary>Use the account timezone in the report.</summary>
                        [Google.Apis.Util.StringValueAttribute("ACCOUNT_TIME_ZONE")]
                        ACCOUNTTIMEZONE = 1,

                        /// <summary>Use the Google timezone in the report (America/Los_Angeles).</summary>
                        [Google.Apis.Util.StringValueAttribute("GOOGLE_TIME_ZONE")]
                        GOOGLETIMEZONE = 2,
                    }

                    /// <summary>
                    /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by
                    /// itself or a year and month where the day isn't significant.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("startDate.day", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> StartDateDay { get; set; }

                    /// <summary>
                    /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("startDate.month", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> StartDateMonth { get; set; }

                    /// <summary>
                    /// Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("startDate.year", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> StartDateYear { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "generateCsv";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}/saved:generateCsv";

                    /// <summary>Initializes GenerateCsv parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^accounts/[^/]+/reports/[^/]+$",
                        });
                        RequestParameters.Add("currencyCode", new Google.Apis.Discovery.Parameter
                        {
                            Name = "currencyCode",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("dateRange", new Google.Apis.Discovery.Parameter
                        {
                            Name = "dateRange",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("endDate.day", new Google.Apis.Discovery.Parameter
                        {
                            Name = "endDate.day",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("endDate.month", new Google.Apis.Discovery.Parameter
                        {
                            Name = "endDate.month",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("endDate.year", new Google.Apis.Discovery.Parameter
                        {
                            Name = "endDate.year",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("languageCode", new Google.Apis.Discovery.Parameter
                        {
                            Name = "languageCode",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("reportingTimeZone", new Google.Apis.Discovery.Parameter
                        {
                            Name = "reportingTimeZone",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("startDate.day", new Google.Apis.Discovery.Parameter
                        {
                            Name = "startDate.day",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("startDate.month", new Google.Apis.Discovery.Parameter
                        {
                            Name = "startDate.month",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("startDate.year", new Google.Apis.Discovery.Parameter
                        {
                            Name = "startDate.year",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Lists saved reports.</summary>
                /// <param name="parent">
                /// Required. The account which owns the collection of reports. Format: accounts/{account}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists saved reports.</summary>
                public class ListRequest : AdsenseBaseServiceRequest<Google.Apis.Adsense.v2.Data.ListSavedReportsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The account which owns the collection of reports. Format: accounts/{account}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of reports to include in the response, used for paging. If unspecified, at
                    /// most 10000 reports will be returned. The maximum value is 10000; values above 10000 will be
                    /// coerced to 10000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `ListSavedReports` call. Provide this to retrieve the
                    /// subsequent page. When paginating, all other parameters provided to `ListSavedReports` must match
                    /// the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/reports/saved";

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

            /// <summary>Generates an ad hoc report.</summary>
            /// <param name="account">
            /// Required. The account which owns the collection of reports. Format: accounts/{account}
            /// </param>
            public virtual GenerateRequest Generate(string account)
            {
                return new GenerateRequest(this.service, account);
            }

            /// <summary>Generates an ad hoc report.</summary>
            public class GenerateRequest : AdsenseBaseServiceRequest<Google.Apis.Adsense.v2.Data.ReportResult>
            {
                /// <summary>Constructs a new Generate request.</summary>
                public GenerateRequest(Google.Apis.Services.IClientService service, string account) : base(service)
                {
                    Account = account;
                    InitParameters();
                }

                /// <summary>
                /// Required. The account which owns the collection of reports. Format: accounts/{account}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("account", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Account { get; private set; }

                /// <summary>
                /// The [ISO-4217 currency code](https://en.wikipedia.org/wiki/ISO_4217) to use when reporting on
                /// monetary metrics. Defaults to the account's currency if not set.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("currencyCode", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string CurrencyCode { get; set; }

                /// <summary>Date range of the report, if unset the range will be considered CUSTOM.</summary>
                [Google.Apis.Util.RequestParameterAttribute("dateRange", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<DateRangeEnum> DateRange { get; set; }

                /// <summary>Date range of the report, if unset the range will be considered CUSTOM.</summary>
                public enum DateRangeEnum
                {
                    /// <summary>Unspecified date range.</summary>
                    [Google.Apis.Util.StringValueAttribute("REPORTING_DATE_RANGE_UNSPECIFIED")]
                    REPORTINGDATERANGEUNSPECIFIED = 0,

                    /// <summary>
                    /// A custom date range specified using the `start_date` and `end_date` fields. This is the default
                    /// if no ReportingDateRange is provided.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("CUSTOM")]
                    CUSTOM = 1,

                    /// <summary>Current day.</summary>
                    [Google.Apis.Util.StringValueAttribute("TODAY")]
                    TODAY = 2,

                    /// <summary>Yesterday.</summary>
                    [Google.Apis.Util.StringValueAttribute("YESTERDAY")]
                    YESTERDAY = 3,

                    /// <summary>
                    /// From the start of the current month to the current day. e.g. if the current date is 2020-03-12
                    /// then the range will be [2020-03-01, 2020-03-12].
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("MONTH_TO_DATE")]
                    MONTHTODATE = 4,

                    /// <summary>
                    /// From the start of the current year to the current day. e.g. if the current date is 2020-03-12
                    /// then the range will be [2020-01-01, 2020-03-12].
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("YEAR_TO_DATE")]
                    YEARTODATE = 5,

                    /// <summary>Last 7 days, excluding current day.</summary>
                    [Google.Apis.Util.StringValueAttribute("LAST_7_DAYS")]
                    LAST7DAYS = 6,

                    /// <summary>Last 30 days, excluding current day.</summary>
                    [Google.Apis.Util.StringValueAttribute("LAST_30_DAYS")]
                    LAST30DAYS = 7,
                }

                /// <summary>Dimensions to base the report on.</summary>
                /// <remarks>
                /// Use this property to set a single value for the parameter, or <see cref="DimensionsList"/> to set
                /// multiple values. Do not set both properties.
                /// </remarks>
                [Google.Apis.Util.RequestParameterAttribute("dimensions", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<DimensionsEnum> Dimensions { get; set; }

                /// <summary>Dimensions to base the report on.</summary>
                /// <remarks>
                /// Use this property to set one or more values for the parameter. Do not set both this property and
                /// <see cref="Dimensions"/>.
                /// </remarks>
                [Google.Apis.Util.RequestParameterAttribute("dimensions", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<DimensionsEnum> DimensionsList { get; set; }

                /// <summary>Dimensions to base the report on.</summary>
                public enum DimensionsEnum
                {
                    /// <summary>Unspecified dimension.</summary>
                    [Google.Apis.Util.StringValueAttribute("DIMENSION_UNSPECIFIED")]
                    DIMENSIONUNSPECIFIED = 0,

                    /// <summary>Date dimension in YYYY-MM-DD format (e.g. "2010-02-10").</summary>
                    [Google.Apis.Util.StringValueAttribute("DATE")]
                    DATE = 1,

                    /// <summary>
                    /// Week dimension in YYYY-MM-DD format, representing the first day of each week (e.g.
                    /// "2010-02-08"). The first day of the week is determined by the language_code specified in a
                    /// report generation request (so e.g. this would be a Monday for "en-GB" or "es", but a Sunday for
                    /// "en" or "fr-CA").
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("WEEK")]
                    WEEK = 2,

                    /// <summary>Month dimension in YYYY-MM format (e.g. "2010-02").</summary>
                    [Google.Apis.Util.StringValueAttribute("MONTH")]
                    MONTH = 3,

                    /// <summary>
                    /// Account name. The members of this dimension match the values from Account.display_name.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ACCOUNT_NAME")]
                    ACCOUNTNAME = 4,

                    /// <summary>
                    /// Unique ID of an ad client. The members of this dimension match the values from
                    /// AdClient.reporting_dimension_id.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("AD_CLIENT_ID")]
                    ADCLIENTID = 5,

                    /// <summary>
                    /// Unique ID of a sub-account's ad client. The members of this dimension match the values from
                    /// AdClient.reporting_dimension_id (for the sub-account).
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("HOSTED_AD_CLIENT_ID")]
                    HOSTEDADCLIENTID = 46,

                    /// <summary>Localized product name (e.g. "AdSense for Content", "AdSense for Search").</summary>
                    [Google.Apis.Util.StringValueAttribute("PRODUCT_NAME")]
                    PRODUCTNAME = 6,

                    /// <summary>
                    /// Product code (e.g. "AFC", "AFS"). The members of this dimension match the values from
                    /// AdClient.product_code.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("PRODUCT_CODE")]
                    PRODUCTCODE = 7,

                    /// <summary>
                    /// Ad unit name (within which an ad was served). The members of this dimension match the values
                    /// from AdUnit.display_name.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("AD_UNIT_NAME")]
                    ADUNITNAME = 8,

                    /// <summary>
                    /// Unique ID of an ad unit (within which an ad was served). The members of this dimension match the
                    /// values from AdUnit.reporting_dimension_id.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("AD_UNIT_ID")]
                    ADUNITID = 9,

                    /// <summary>Localized size of an ad unit (e.g. "728x90", "Responsive").</summary>
                    [Google.Apis.Util.StringValueAttribute("AD_UNIT_SIZE_NAME")]
                    ADUNITSIZENAME = 10,

                    /// <summary>The size code of an ad unit (e.g. "728x90", "responsive").</summary>
                    [Google.Apis.Util.StringValueAttribute("AD_UNIT_SIZE_CODE")]
                    ADUNITSIZECODE = 11,

                    /// <summary>
                    /// Custom channel name. The members of this dimension match the values from
                    /// CustomChannel.display_name.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("CUSTOM_CHANNEL_NAME")]
                    CUSTOMCHANNELNAME = 12,

                    /// <summary>
                    /// Unique ID of a custom channel. The members of this dimension match the values from
                    /// CustomChannel.reporting_dimension_id.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("CUSTOM_CHANNEL_ID")]
                    CUSTOMCHANNELID = 13,

                    /// <summary>Not supported.</summary>
                    [Google.Apis.Util.StringValueAttribute("HOSTED_CUSTOM_CHANNEL_ID")]
                    HOSTEDCUSTOMCHANNELID = 48,

                    /// <summary>
                    /// Domain name of a verified site (e.g. "example.com"). The members of this dimension match the
                    /// values from Site.domain.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("OWNED_SITE_DOMAIN_NAME")]
                    OWNEDSITEDOMAINNAME = 14,

                    /// <summary>
                    /// Unique ID of a verified site. The members of this dimension match the values from
                    /// Site.reporting_dimension_id.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("OWNED_SITE_ID")]
                    OWNEDSITEID = 15,

                    /// <summary>
                    /// URL of the page upon which the ad was served. This is a complete URL including scheme and query
                    /// parameters. Note that the URL that appears in this dimension may be a canonicalized version of
                    /// the one that was used in the original request, and so may not exactly match the URL that a user
                    /// might have seen. Note that there are also some caveats to be aware of when using this dimension.
                    /// For more information, see [Page URL
                    /// breakdown](https://support.google.com/adsense/answer/11988478).
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("PAGE_URL")]
                    PAGEURL = 47,

                    /// <summary>
                    /// Name of a URL channel. The members of this dimension match the values from
                    /// UrlChannel.uri_pattern.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("URL_CHANNEL_NAME")]
                    URLCHANNELNAME = 16,

                    /// <summary>
                    /// Unique ID of a URL channel. The members of this dimension match the values from
                    /// UrlChannel.reporting_dimension_id.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("URL_CHANNEL_ID")]
                    URLCHANNELID = 17,

                    /// <summary>
                    /// Name of an ad network that returned the winning ads for an ad request (e.g. "Google AdWords").
                    /// Note that unlike other "NAME" dimensions, the members of this dimensions are not localized.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("BUYER_NETWORK_NAME")]
                    BUYERNETWORKNAME = 18,

                    /// <summary>
                    /// Unique (opaque) ID of an ad network that returned the winning ads for an ad request.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("BUYER_NETWORK_ID")]
                    BUYERNETWORKID = 19,

                    /// <summary>Localized bid type name (e.g. "CPC bids", "CPM bids") for a served ad.</summary>
                    [Google.Apis.Util.StringValueAttribute("BID_TYPE_NAME")]
                    BIDTYPENAME = 20,

                    /// <summary>Type of a bid (e.g. "cpc", "cpm") for a served ad.</summary>
                    [Google.Apis.Util.StringValueAttribute("BID_TYPE_CODE")]
                    BIDTYPECODE = 21,

                    /// <summary>Localized creative size name (e.g. "728x90", "Dynamic") of a served ad.</summary>
                    [Google.Apis.Util.StringValueAttribute("CREATIVE_SIZE_NAME")]
                    CREATIVESIZENAME = 22,

                    /// <summary>Creative size code (e.g. "728x90", "dynamic") of a served ad.</summary>
                    [Google.Apis.Util.StringValueAttribute("CREATIVE_SIZE_CODE")]
                    CREATIVESIZECODE = 23,

                    /// <summary>
                    /// Localized name of a host on which an ad was served, after IDNA decoding (e.g. "www.google.com",
                    /// "Web caches and other", "bücher.example").
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("DOMAIN_NAME")]
                    DOMAINNAME = 24,

                    /// <summary>
                    /// Name of a host on which an ad was served (e.g. "www.google.com", "webcaches",
                    /// "xn--bcher-kva.example").
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("DOMAIN_CODE")]
                    DOMAINCODE = 25,

                    /// <summary>
                    /// Localized region name of a user viewing an ad (e.g. "United States", "France").
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("COUNTRY_NAME")]
                    COUNTRYNAME = 26,

                    /// <summary>CLDR region code of a user viewing an ad (e.g. "US", "FR").</summary>
                    [Google.Apis.Util.StringValueAttribute("COUNTRY_CODE")]
                    COUNTRYCODE = 27,

                    /// <summary>Localized platform type name (e.g. "High-end mobile devices", "Desktop").</summary>
                    [Google.Apis.Util.StringValueAttribute("PLATFORM_TYPE_NAME")]
                    PLATFORMTYPENAME = 28,

                    /// <summary>Platform type code (e.g. "HighEndMobile", "Desktop").</summary>
                    [Google.Apis.Util.StringValueAttribute("PLATFORM_TYPE_CODE")]
                    PLATFORMTYPECODE = 29,

                    /// <summary>
                    /// Localized targeting type name (e.g. "Contextual", "Personalized", "Run of Network").
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_NAME")]
                    TARGETINGTYPENAME = 30,

                    /// <summary>Targeting type code (e.g. "Keyword", "UserInterest", "RunOfNetwork").</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CODE")]
                    TARGETINGTYPECODE = 31,

                    /// <summary>
                    /// Localized content platform name an ad request was made from (e.g. "AMP", "Web").
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("CONTENT_PLATFORM_NAME")]
                    CONTENTPLATFORMNAME = 32,

                    /// <summary>Content platform code an ad request was made from (e.g. "AMP", "HTML").</summary>
                    [Google.Apis.Util.StringValueAttribute("CONTENT_PLATFORM_CODE")]
                    CONTENTPLATFORMCODE = 33,

                    /// <summary>Localized ad placement name (e.g. "Ad unit", "Global settings", "Manual").</summary>
                    [Google.Apis.Util.StringValueAttribute("AD_PLACEMENT_NAME")]
                    ADPLACEMENTNAME = 34,

                    /// <summary>Ad placement code (e.g. "AD_UNIT", "ca-pub-123456:78910", "OTHER").</summary>
                    [Google.Apis.Util.StringValueAttribute("AD_PLACEMENT_CODE")]
                    ADPLACEMENTCODE = 35,

                    /// <summary>Localized requested ad type name (e.g. "Display", "Link unit", "Other").</summary>
                    [Google.Apis.Util.StringValueAttribute("REQUESTED_AD_TYPE_NAME")]
                    REQUESTEDADTYPENAME = 36,

                    /// <summary>Requested ad type code (e.g. "IMAGE", "RADLINK", "OTHER").</summary>
                    [Google.Apis.Util.StringValueAttribute("REQUESTED_AD_TYPE_CODE")]
                    REQUESTEDADTYPECODE = 37,

                    /// <summary>Localized served ad type name (e.g. "Display", "Link unit", "Other").</summary>
                    [Google.Apis.Util.StringValueAttribute("SERVED_AD_TYPE_NAME")]
                    SERVEDADTYPENAME = 38,

                    /// <summary>Served ad type code (e.g. "IMAGE", "RADLINK", "OTHER").</summary>
                    [Google.Apis.Util.StringValueAttribute("SERVED_AD_TYPE_CODE")]
                    SERVEDADTYPECODE = 39,

                    /// <summary>
                    /// Localized ad format name indicating the way an ad is shown to the users on your site (e.g.
                    /// "In-page", "Anchor", "Vignette").
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("AD_FORMAT_NAME")]
                    ADFORMATNAME = 44,

                    /// <summary>
                    /// Ad format code indicating the way an ad is shown to the users on your site (e.g. "ON_PAGE",
                    /// "ANCHOR", "INTERSTITIAL").
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("AD_FORMAT_CODE")]
                    ADFORMATCODE = 45,

                    /// <summary>Custom search style name.</summary>
                    [Google.Apis.Util.StringValueAttribute("CUSTOM_SEARCH_STYLE_NAME")]
                    CUSTOMSEARCHSTYLENAME = 40,

                    /// <summary>Custom search style id.</summary>
                    [Google.Apis.Util.StringValueAttribute("CUSTOM_SEARCH_STYLE_ID")]
                    CUSTOMSEARCHSTYLEID = 41,

                    /// <summary>Domain registrants.</summary>
                    [Google.Apis.Util.StringValueAttribute("DOMAIN_REGISTRANT")]
                    DOMAINREGISTRANT = 42,

                    /// <summary>Query strings for web searches.</summary>
                    [Google.Apis.Util.StringValueAttribute("WEBSEARCH_QUERY_STRING")]
                    WEBSEARCHQUERYSTRING = 43,
                }

                /// <summary>
                /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by
                /// itself or a year and month where the day isn't significant.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("endDate.day", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> EndDateDay { get; set; }

                /// <summary>
                /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("endDate.month", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> EndDateMonth { get; set; }

                /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
                [Google.Apis.Util.RequestParameterAttribute("endDate.year", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> EndDateYear { get; set; }

                /// <summary>
                /// A list of [filters](/adsense/management/reporting/filtering) to apply to the report. All provided
                /// filters must match in order for the data to be included in the report.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filters", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> Filters { get; set; }

                /// <summary>
                /// The language to use for translating report output. If unspecified, this defaults to English ("en").
                /// If the given language is not supported, report output will be returned in English. The language is
                /// specified as an [IETF BCP-47 language code](https://en.wikipedia.org/wiki/IETF_language_tag).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string LanguageCode { get; set; }

                /// <summary>
                /// The maximum number of rows of report data to return. Reports producing more rows than the requested
                /// limit will be truncated. If unset, this defaults to 100,000 rows for `Reports.GenerateReport` and
                /// 1,000,000 rows for `Reports.GenerateCsvReport`, which are also the maximum values permitted here.
                /// Report truncation can be identified (for `Reports.GenerateReport` only) by comparing the number of
                /// rows returned to the value returned in `total_matched_rows`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("limit", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> Limit { get; set; }

                /// <summary>Required. Reporting metrics.</summary>
                /// <remarks>
                /// Use this property to set a single value for the parameter, or <see cref="MetricsList"/> to set
                /// multiple values. Do not set both properties.
                /// </remarks>
                [Google.Apis.Util.RequestParameterAttribute("metrics", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<MetricsEnum> Metrics { get; set; }

                /// <summary>Required. Reporting metrics.</summary>
                /// <remarks>
                /// Use this property to set one or more values for the parameter. Do not set both this property and
                /// <see cref="Metrics"/>.
                /// </remarks>
                [Google.Apis.Util.RequestParameterAttribute("metrics", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<MetricsEnum> MetricsList { get; set; }

                /// <summary>Required. Reporting metrics.</summary>
                public enum MetricsEnum
                {
                    /// <summary>Unspecified metric.</summary>
                    [Google.Apis.Util.StringValueAttribute("METRIC_UNSPECIFIED")]
                    METRICUNSPECIFIED = 0,

                    /// <summary>Number of page views.</summary>
                    [Google.Apis.Util.StringValueAttribute("PAGE_VIEWS")]
                    PAGEVIEWS = 1,

                    /// <summary>
                    /// Number of ad units that requested ads (for content ads) or search queries (for search ads). An
                    /// ad request may result in zero, one, or multiple individual ad impressions depending on the size
                    /// of the ad unit and whether any ads were available.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("AD_REQUESTS")]
                    ADREQUESTS = 2,

                    /// <summary>Requests that returned at least one ad.</summary>
                    [Google.Apis.Util.StringValueAttribute("MATCHED_AD_REQUESTS")]
                    MATCHEDADREQUESTS = 3,

                    /// <summary>
                    /// Impressions. An impression is counted for each ad request where at least one ad has been
                    /// downloaded to the user's device and has begun to load. It is the number of ad units (for content
                    /// ads) or search queries (for search ads) that showed ads.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("TOTAL_IMPRESSIONS")]
                    TOTALIMPRESSIONS = 4,

                    /// <summary>
                    /// Impressions. An impression is counted for each ad request where at least one ad has been
                    /// downloaded to the user's device and has begun to load. It is the number of ad units (for content
                    /// ads) or search queries (for search ads) that showed ads.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("IMPRESSIONS")]
                    IMPRESSIONS = 5,

                    /// <summary>
                    /// Ads shown. Different ad formats will display varying numbers of ads. For example, a vertical
                    /// banner may consist of 2 or more ads. Also, the number of ads in an ad unit may vary depending on
                    /// whether the ad unit is displaying standard text ads, expanded text ads or image ads.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("INDIVIDUAL_AD_IMPRESSIONS")]
                    INDIVIDUALADIMPRESSIONS = 6,

                    /// <summary>Number of times a user clicked on a standard content ad.</summary>
                    [Google.Apis.Util.StringValueAttribute("CLICKS")]
                    CLICKS = 7,

                    /// <summary>
                    /// Fraction of page views considered to be spam. Only available to [premium
                    /// accounts](https://developers.google.com/adsense/management/reference/rest/v2/accounts#Account.FIELDS.premium).
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("PAGE_VIEWS_SPAM_RATIO")]
                    PAGEVIEWSSPAMRATIO = 8,

                    /// <summary>
                    /// Fraction of ad requests considered to be spam. Only available to [premium
                    /// accounts](https://developers.google.com/adsense/management/reference/rest/v2/accounts#Account.FIELDS.premium).
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("AD_REQUESTS_SPAM_RATIO")]
                    ADREQUESTSSPAMRATIO = 9,

                    /// <summary>
                    /// Fraction of ad requests that returned ads considered to be spam. Only available to [premium
                    /// accounts](https://developers.google.com/adsense/management/reference/rest/v2/accounts#Account.FIELDS.premium).
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("MATCHED_AD_REQUESTS_SPAM_RATIO")]
                    MATCHEDADREQUESTSSPAMRATIO = 10,

                    /// <summary>
                    /// Fraction of impressions considered to be spam. Only available to [premium
                    /// accounts](https://developers.google.com/adsense/management/reference/rest/v2/accounts#Account.FIELDS.premium).
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("IMPRESSIONS_SPAM_RATIO")]
                    IMPRESSIONSSPAMRATIO = 11,

                    /// <summary>
                    /// Fraction of ad impressions considered to be spam. Only available to [premium
                    /// accounts](https://developers.google.com/adsense/management/reference/rest/v2/accounts#Account.FIELDS.premium).
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("INDIVIDUAL_AD_IMPRESSIONS_SPAM_RATIO")]
                    INDIVIDUALADIMPRESSIONSSPAMRATIO = 12,

                    /// <summary>
                    /// Fraction of clicks considered to be spam. Only available to [premium
                    /// accounts](https://developers.google.com/adsense/management/reference/rest/v2/accounts#Account.FIELDS.premium).
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("CLICKS_SPAM_RATIO")]
                    CLICKSSPAMRATIO = 13,

                    /// <summary>Ratio of requested ad units or queries to the number returned to the site.</summary>
                    [Google.Apis.Util.StringValueAttribute("AD_REQUESTS_COVERAGE")]
                    ADREQUESTSCOVERAGE = 14,

                    /// <summary>Ratio of individual page views that resulted in a click.</summary>
                    [Google.Apis.Util.StringValueAttribute("PAGE_VIEWS_CTR")]
                    PAGEVIEWSCTR = 15,

                    /// <summary>Ratio of ad requests that resulted in a click.</summary>
                    [Google.Apis.Util.StringValueAttribute("AD_REQUESTS_CTR")]
                    ADREQUESTSCTR = 16,

                    /// <summary>Ratio of clicks to matched requests.</summary>
                    [Google.Apis.Util.StringValueAttribute("MATCHED_AD_REQUESTS_CTR")]
                    MATCHEDADREQUESTSCTR = 17,

                    /// <summary>Ratio of IMPRESSIONS that resulted in a click.</summary>
                    [Google.Apis.Util.StringValueAttribute("IMPRESSIONS_CTR")]
                    IMPRESSIONSCTR = 18,

                    /// <summary>Ratio of individual ad impressions that resulted in a click.</summary>
                    [Google.Apis.Util.StringValueAttribute("INDIVIDUAL_AD_IMPRESSIONS_CTR")]
                    INDIVIDUALADIMPRESSIONSCTR = 19,

                    /// <summary>Ratio of requests that were measurable for viewability.</summary>
                    [Google.Apis.Util.StringValueAttribute("ACTIVE_VIEW_MEASURABILITY")]
                    ACTIVEVIEWMEASURABILITY = 20,

                    /// <summary>Ratio of requests that were viewable.</summary>
                    [Google.Apis.Util.StringValueAttribute("ACTIVE_VIEW_VIEWABILITY")]
                    ACTIVEVIEWVIEWABILITY = 21,

                    /// <summary>Mean time an ad was displayed on screen.</summary>
                    [Google.Apis.Util.StringValueAttribute("ACTIVE_VIEW_TIME")]
                    ACTIVEVIEWTIME = 22,

                    /// <summary>
                    /// Estimated earnings of the publisher. Note that earnings up to yesterday are accurate, more
                    /// recent earnings are estimated due to the possibility of spam, or exchange rate fluctuations.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ESTIMATED_EARNINGS")]
                    ESTIMATEDEARNINGS = 23,

                    /// <summary>
                    /// Revenue per thousand page views. This is calculated by dividing the estimated revenue by the
                    /// number of page views multiplied by 1000.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("PAGE_VIEWS_RPM")]
                    PAGEVIEWSRPM = 24,

                    /// <summary>
                    /// Revenue per thousand ad requests. This is calculated by dividing estimated revenue by the number
                    /// of ad requests multiplied by 1000.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("AD_REQUESTS_RPM")]
                    ADREQUESTSRPM = 25,

                    /// <summary>
                    /// Revenue per thousand matched ad requests. This is calculated by dividing estimated revenue by
                    /// the number of matched ad requests multiplied by 1000.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("MATCHED_AD_REQUESTS_RPM")]
                    MATCHEDADREQUESTSRPM = 26,

                    /// <summary>
                    /// Revenue per thousand ad impressions. This is calculated by dividing estimated revenue by the
                    /// number of ad impressions multiplied by 1000.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("IMPRESSIONS_RPM")]
                    IMPRESSIONSRPM = 27,

                    /// <summary>
                    /// Revenue per thousand individual ad impressions. This is calculated by dividing estimated revenue
                    /// by the number of individual ad impressions multiplied by 1000.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("INDIVIDUAL_AD_IMPRESSIONS_RPM")]
                    INDIVIDUALADIMPRESSIONSRPM = 28,

                    /// <summary>
                    /// Amount the publisher earns each time a user clicks on an ad. CPC is calculated by dividing the
                    /// estimated revenue by the number of clicks received.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("COST_PER_CLICK")]
                    COSTPERCLICK = 29,

                    /// <summary>Number of ad views per impression.</summary>
                    [Google.Apis.Util.StringValueAttribute("ADS_PER_IMPRESSION")]
                    ADSPERIMPRESSION = 30,

                    /// <summary>
                    /// Total earnings are the gross estimated earnings from revenue shared traffic before any parent
                    /// and child account revenue share is applied.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("TOTAL_EARNINGS")]
                    TOTALEARNINGS = 31,

                    /// <summary>
                    /// Number of results pages. This metric can only be used when generating a report in the Google
                    /// timezone, not the account timezone. Since the account timezone is the default for report
                    /// generation, this metric can only be used by explicitly specifying
                    /// `reportingTimeZone=GOOGLE_TIME_ZONE`.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("WEBSEARCH_RESULT_PAGES")]
                    WEBSEARCHRESULTPAGES = 32,

                    /// <summary>
                    /// Number of requests for non-ad units (for example a related search unit). For more information,
                    /// see [Funnel requests](https://support.google.com/adsense/answer/11586959).
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("FUNNEL_REQUESTS")]
                    FUNNELREQUESTS = 33,

                    /// <summary>
                    /// Number of requests for non-ad units ads that returned content that was shown to the user. For
                    /// more information, see [Funnel impressions](https://support.google.com/adsense/answer/11585767).
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("FUNNEL_IMPRESSIONS")]
                    FUNNELIMPRESSIONS = 34,

                    /// <summary>
                    /// Number of times a user clicked on a non-ad unit, triggering further ad requests. For more
                    /// information, see [Funnel clicks](https://support.google.com/adsense/answer/11586382).
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("FUNNEL_CLICKS")]
                    FUNNELCLICKS = 35,

                    /// <summary>
                    /// Revenue per thousand funnel impressions. This is calculated by dividing estimated revenue by the
                    /// number of funnel impressions multiplied by 1000. For more information, see [Funnel
                    /// RPM](https://support.google.com/adsense/answer/11585979).
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("FUNNEL_RPM")]
                    FUNNELRPM = 36,
                }

                /// <summary>
                /// The name of a dimension or metric to sort the resulting report on, can be prefixed with "+" to sort
                /// ascending or "-" to sort descending. If no prefix is specified, the column is sorted ascending.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> OrderBy { get; set; }

                /// <summary>
                /// Timezone in which to generate the report. If unspecified, this defaults to the account timezone. For
                /// more information, see [changing the time zone of your
                /// reports](https://support.google.com/adsense/answer/9830725).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("reportingTimeZone", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ReportingTimeZoneEnum> ReportingTimeZone { get; set; }

                /// <summary>
                /// Timezone in which to generate the report. If unspecified, this defaults to the account timezone. For
                /// more information, see [changing the time zone of your
                /// reports](https://support.google.com/adsense/answer/9830725).
                /// </summary>
                public enum ReportingTimeZoneEnum
                {
                    /// <summary>Unspecified timezone.</summary>
                    [Google.Apis.Util.StringValueAttribute("REPORTING_TIME_ZONE_UNSPECIFIED")]
                    REPORTINGTIMEZONEUNSPECIFIED = 0,

                    /// <summary>Use the account timezone in the report.</summary>
                    [Google.Apis.Util.StringValueAttribute("ACCOUNT_TIME_ZONE")]
                    ACCOUNTTIMEZONE = 1,

                    /// <summary>Use the Google timezone in the report (America/Los_Angeles).</summary>
                    [Google.Apis.Util.StringValueAttribute("GOOGLE_TIME_ZONE")]
                    GOOGLETIMEZONE = 2,
                }

                /// <summary>
                /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by
                /// itself or a year and month where the day isn't significant.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("startDate.day", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> StartDateDay { get; set; }

                /// <summary>
                /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("startDate.month", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> StartDateMonth { get; set; }

                /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
                [Google.Apis.Util.RequestParameterAttribute("startDate.year", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> StartDateYear { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "generate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+account}/reports:generate";

                /// <summary>Initializes Generate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("account", new Google.Apis.Discovery.Parameter
                    {
                        Name = "account",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+$",
                    });
                    RequestParameters.Add("currencyCode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "currencyCode",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("dateRange", new Google.Apis.Discovery.Parameter
                    {
                        Name = "dateRange",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("dimensions", new Google.Apis.Discovery.Parameter
                    {
                        Name = "dimensions",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("endDate.day", new Google.Apis.Discovery.Parameter
                    {
                        Name = "endDate.day",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("endDate.month", new Google.Apis.Discovery.Parameter
                    {
                        Name = "endDate.month",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("endDate.year", new Google.Apis.Discovery.Parameter
                    {
                        Name = "endDate.year",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("filters", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filters",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("languageCode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "languageCode",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("limit", new Google.Apis.Discovery.Parameter
                    {
                        Name = "limit",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("metrics", new Google.Apis.Discovery.Parameter
                    {
                        Name = "metrics",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderBy",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("reportingTimeZone", new Google.Apis.Discovery.Parameter
                    {
                        Name = "reportingTimeZone",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("startDate.day", new Google.Apis.Discovery.Parameter
                    {
                        Name = "startDate.day",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("startDate.month", new Google.Apis.Discovery.Parameter
                    {
                        Name = "startDate.month",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("startDate.year", new Google.Apis.Discovery.Parameter
                    {
                        Name = "startDate.year",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Generates a csv formatted ad hoc report.</summary>
            /// <param name="account">
            /// Required. The account which owns the collection of reports. Format: accounts/{account}
            /// </param>
            public virtual GenerateCsvRequest GenerateCsv(string account)
            {
                return new GenerateCsvRequest(this.service, account);
            }

            /// <summary>Generates a csv formatted ad hoc report.</summary>
            public class GenerateCsvRequest : AdsenseBaseServiceRequest<Google.Apis.Adsense.v2.Data.HttpBody>
            {
                /// <summary>Constructs a new GenerateCsv request.</summary>
                public GenerateCsvRequest(Google.Apis.Services.IClientService service, string account) : base(service)
                {
                    Account = account;
                    InitParameters();
                }

                /// <summary>
                /// Required. The account which owns the collection of reports. Format: accounts/{account}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("account", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Account { get; private set; }

                /// <summary>
                /// The [ISO-4217 currency code](https://en.wikipedia.org/wiki/ISO_4217) to use when reporting on
                /// monetary metrics. Defaults to the account's currency if not set.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("currencyCode", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string CurrencyCode { get; set; }

                /// <summary>Date range of the report, if unset the range will be considered CUSTOM.</summary>
                [Google.Apis.Util.RequestParameterAttribute("dateRange", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<DateRangeEnum> DateRange { get; set; }

                /// <summary>Date range of the report, if unset the range will be considered CUSTOM.</summary>
                public enum DateRangeEnum
                {
                    /// <summary>Unspecified date range.</summary>
                    [Google.Apis.Util.StringValueAttribute("REPORTING_DATE_RANGE_UNSPECIFIED")]
                    REPORTINGDATERANGEUNSPECIFIED = 0,

                    /// <summary>
                    /// A custom date range specified using the `start_date` and `end_date` fields. This is the default
                    /// if no ReportingDateRange is provided.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("CUSTOM")]
                    CUSTOM = 1,

                    /// <summary>Current day.</summary>
                    [Google.Apis.Util.StringValueAttribute("TODAY")]
                    TODAY = 2,

                    /// <summary>Yesterday.</summary>
                    [Google.Apis.Util.StringValueAttribute("YESTERDAY")]
                    YESTERDAY = 3,

                    /// <summary>
                    /// From the start of the current month to the current day. e.g. if the current date is 2020-03-12
                    /// then the range will be [2020-03-01, 2020-03-12].
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("MONTH_TO_DATE")]
                    MONTHTODATE = 4,

                    /// <summary>
                    /// From the start of the current year to the current day. e.g. if the current date is 2020-03-12
                    /// then the range will be [2020-01-01, 2020-03-12].
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("YEAR_TO_DATE")]
                    YEARTODATE = 5,

                    /// <summary>Last 7 days, excluding current day.</summary>
                    [Google.Apis.Util.StringValueAttribute("LAST_7_DAYS")]
                    LAST7DAYS = 6,

                    /// <summary>Last 30 days, excluding current day.</summary>
                    [Google.Apis.Util.StringValueAttribute("LAST_30_DAYS")]
                    LAST30DAYS = 7,
                }

                /// <summary>Dimensions to base the report on.</summary>
                /// <remarks>
                /// Use this property to set a single value for the parameter, or <see cref="DimensionsList"/> to set
                /// multiple values. Do not set both properties.
                /// </remarks>
                [Google.Apis.Util.RequestParameterAttribute("dimensions", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<DimensionsEnum> Dimensions { get; set; }

                /// <summary>Dimensions to base the report on.</summary>
                /// <remarks>
                /// Use this property to set one or more values for the parameter. Do not set both this property and
                /// <see cref="Dimensions"/>.
                /// </remarks>
                [Google.Apis.Util.RequestParameterAttribute("dimensions", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<DimensionsEnum> DimensionsList { get; set; }

                /// <summary>Dimensions to base the report on.</summary>
                public enum DimensionsEnum
                {
                    /// <summary>Unspecified dimension.</summary>
                    [Google.Apis.Util.StringValueAttribute("DIMENSION_UNSPECIFIED")]
                    DIMENSIONUNSPECIFIED = 0,

                    /// <summary>Date dimension in YYYY-MM-DD format (e.g. "2010-02-10").</summary>
                    [Google.Apis.Util.StringValueAttribute("DATE")]
                    DATE = 1,

                    /// <summary>
                    /// Week dimension in YYYY-MM-DD format, representing the first day of each week (e.g.
                    /// "2010-02-08"). The first day of the week is determined by the language_code specified in a
                    /// report generation request (so e.g. this would be a Monday for "en-GB" or "es", but a Sunday for
                    /// "en" or "fr-CA").
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("WEEK")]
                    WEEK = 2,

                    /// <summary>Month dimension in YYYY-MM format (e.g. "2010-02").</summary>
                    [Google.Apis.Util.StringValueAttribute("MONTH")]
                    MONTH = 3,

                    /// <summary>
                    /// Account name. The members of this dimension match the values from Account.display_name.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ACCOUNT_NAME")]
                    ACCOUNTNAME = 4,

                    /// <summary>
                    /// Unique ID of an ad client. The members of this dimension match the values from
                    /// AdClient.reporting_dimension_id.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("AD_CLIENT_ID")]
                    ADCLIENTID = 5,

                    /// <summary>
                    /// Unique ID of a sub-account's ad client. The members of this dimension match the values from
                    /// AdClient.reporting_dimension_id (for the sub-account).
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("HOSTED_AD_CLIENT_ID")]
                    HOSTEDADCLIENTID = 46,

                    /// <summary>Localized product name (e.g. "AdSense for Content", "AdSense for Search").</summary>
                    [Google.Apis.Util.StringValueAttribute("PRODUCT_NAME")]
                    PRODUCTNAME = 6,

                    /// <summary>
                    /// Product code (e.g. "AFC", "AFS"). The members of this dimension match the values from
                    /// AdClient.product_code.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("PRODUCT_CODE")]
                    PRODUCTCODE = 7,

                    /// <summary>
                    /// Ad unit name (within which an ad was served). The members of this dimension match the values
                    /// from AdUnit.display_name.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("AD_UNIT_NAME")]
                    ADUNITNAME = 8,

                    /// <summary>
                    /// Unique ID of an ad unit (within which an ad was served). The members of this dimension match the
                    /// values from AdUnit.reporting_dimension_id.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("AD_UNIT_ID")]
                    ADUNITID = 9,

                    /// <summary>Localized size of an ad unit (e.g. "728x90", "Responsive").</summary>
                    [Google.Apis.Util.StringValueAttribute("AD_UNIT_SIZE_NAME")]
                    ADUNITSIZENAME = 10,

                    /// <summary>The size code of an ad unit (e.g. "728x90", "responsive").</summary>
                    [Google.Apis.Util.StringValueAttribute("AD_UNIT_SIZE_CODE")]
                    ADUNITSIZECODE = 11,

                    /// <summary>
                    /// Custom channel name. The members of this dimension match the values from
                    /// CustomChannel.display_name.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("CUSTOM_CHANNEL_NAME")]
                    CUSTOMCHANNELNAME = 12,

                    /// <summary>
                    /// Unique ID of a custom channel. The members of this dimension match the values from
                    /// CustomChannel.reporting_dimension_id.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("CUSTOM_CHANNEL_ID")]
                    CUSTOMCHANNELID = 13,

                    /// <summary>Not supported.</summary>
                    [Google.Apis.Util.StringValueAttribute("HOSTED_CUSTOM_CHANNEL_ID")]
                    HOSTEDCUSTOMCHANNELID = 48,

                    /// <summary>
                    /// Domain name of a verified site (e.g. "example.com"). The members of this dimension match the
                    /// values from Site.domain.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("OWNED_SITE_DOMAIN_NAME")]
                    OWNEDSITEDOMAINNAME = 14,

                    /// <summary>
                    /// Unique ID of a verified site. The members of this dimension match the values from
                    /// Site.reporting_dimension_id.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("OWNED_SITE_ID")]
                    OWNEDSITEID = 15,

                    /// <summary>
                    /// URL of the page upon which the ad was served. This is a complete URL including scheme and query
                    /// parameters. Note that the URL that appears in this dimension may be a canonicalized version of
                    /// the one that was used in the original request, and so may not exactly match the URL that a user
                    /// might have seen. Note that there are also some caveats to be aware of when using this dimension.
                    /// For more information, see [Page URL
                    /// breakdown](https://support.google.com/adsense/answer/11988478).
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("PAGE_URL")]
                    PAGEURL = 47,

                    /// <summary>
                    /// Name of a URL channel. The members of this dimension match the values from
                    /// UrlChannel.uri_pattern.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("URL_CHANNEL_NAME")]
                    URLCHANNELNAME = 16,

                    /// <summary>
                    /// Unique ID of a URL channel. The members of this dimension match the values from
                    /// UrlChannel.reporting_dimension_id.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("URL_CHANNEL_ID")]
                    URLCHANNELID = 17,

                    /// <summary>
                    /// Name of an ad network that returned the winning ads for an ad request (e.g. "Google AdWords").
                    /// Note that unlike other "NAME" dimensions, the members of this dimensions are not localized.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("BUYER_NETWORK_NAME")]
                    BUYERNETWORKNAME = 18,

                    /// <summary>
                    /// Unique (opaque) ID of an ad network that returned the winning ads for an ad request.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("BUYER_NETWORK_ID")]
                    BUYERNETWORKID = 19,

                    /// <summary>Localized bid type name (e.g. "CPC bids", "CPM bids") for a served ad.</summary>
                    [Google.Apis.Util.StringValueAttribute("BID_TYPE_NAME")]
                    BIDTYPENAME = 20,

                    /// <summary>Type of a bid (e.g. "cpc", "cpm") for a served ad.</summary>
                    [Google.Apis.Util.StringValueAttribute("BID_TYPE_CODE")]
                    BIDTYPECODE = 21,

                    /// <summary>Localized creative size name (e.g. "728x90", "Dynamic") of a served ad.</summary>
                    [Google.Apis.Util.StringValueAttribute("CREATIVE_SIZE_NAME")]
                    CREATIVESIZENAME = 22,

                    /// <summary>Creative size code (e.g. "728x90", "dynamic") of a served ad.</summary>
                    [Google.Apis.Util.StringValueAttribute("CREATIVE_SIZE_CODE")]
                    CREATIVESIZECODE = 23,

                    /// <summary>
                    /// Localized name of a host on which an ad was served, after IDNA decoding (e.g. "www.google.com",
                    /// "Web caches and other", "bücher.example").
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("DOMAIN_NAME")]
                    DOMAINNAME = 24,

                    /// <summary>
                    /// Name of a host on which an ad was served (e.g. "www.google.com", "webcaches",
                    /// "xn--bcher-kva.example").
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("DOMAIN_CODE")]
                    DOMAINCODE = 25,

                    /// <summary>
                    /// Localized region name of a user viewing an ad (e.g. "United States", "France").
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("COUNTRY_NAME")]
                    COUNTRYNAME = 26,

                    /// <summary>CLDR region code of a user viewing an ad (e.g. "US", "FR").</summary>
                    [Google.Apis.Util.StringValueAttribute("COUNTRY_CODE")]
                    COUNTRYCODE = 27,

                    /// <summary>Localized platform type name (e.g. "High-end mobile devices", "Desktop").</summary>
                    [Google.Apis.Util.StringValueAttribute("PLATFORM_TYPE_NAME")]
                    PLATFORMTYPENAME = 28,

                    /// <summary>Platform type code (e.g. "HighEndMobile", "Desktop").</summary>
                    [Google.Apis.Util.StringValueAttribute("PLATFORM_TYPE_CODE")]
                    PLATFORMTYPECODE = 29,

                    /// <summary>
                    /// Localized targeting type name (e.g. "Contextual", "Personalized", "Run of Network").
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_NAME")]
                    TARGETINGTYPENAME = 30,

                    /// <summary>Targeting type code (e.g. "Keyword", "UserInterest", "RunOfNetwork").</summary>
                    [Google.Apis.Util.StringValueAttribute("TARGETING_TYPE_CODE")]
                    TARGETINGTYPECODE = 31,

                    /// <summary>
                    /// Localized content platform name an ad request was made from (e.g. "AMP", "Web").
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("CONTENT_PLATFORM_NAME")]
                    CONTENTPLATFORMNAME = 32,

                    /// <summary>Content platform code an ad request was made from (e.g. "AMP", "HTML").</summary>
                    [Google.Apis.Util.StringValueAttribute("CONTENT_PLATFORM_CODE")]
                    CONTENTPLATFORMCODE = 33,

                    /// <summary>Localized ad placement name (e.g. "Ad unit", "Global settings", "Manual").</summary>
                    [Google.Apis.Util.StringValueAttribute("AD_PLACEMENT_NAME")]
                    ADPLACEMENTNAME = 34,

                    /// <summary>Ad placement code (e.g. "AD_UNIT", "ca-pub-123456:78910", "OTHER").</summary>
                    [Google.Apis.Util.StringValueAttribute("AD_PLACEMENT_CODE")]
                    ADPLACEMENTCODE = 35,

                    /// <summary>Localized requested ad type name (e.g. "Display", "Link unit", "Other").</summary>
                    [Google.Apis.Util.StringValueAttribute("REQUESTED_AD_TYPE_NAME")]
                    REQUESTEDADTYPENAME = 36,

                    /// <summary>Requested ad type code (e.g. "IMAGE", "RADLINK", "OTHER").</summary>
                    [Google.Apis.Util.StringValueAttribute("REQUESTED_AD_TYPE_CODE")]
                    REQUESTEDADTYPECODE = 37,

                    /// <summary>Localized served ad type name (e.g. "Display", "Link unit", "Other").</summary>
                    [Google.Apis.Util.StringValueAttribute("SERVED_AD_TYPE_NAME")]
                    SERVEDADTYPENAME = 38,

                    /// <summary>Served ad type code (e.g. "IMAGE", "RADLINK", "OTHER").</summary>
                    [Google.Apis.Util.StringValueAttribute("SERVED_AD_TYPE_CODE")]
                    SERVEDADTYPECODE = 39,

                    /// <summary>
                    /// Localized ad format name indicating the way an ad is shown to the users on your site (e.g.
                    /// "In-page", "Anchor", "Vignette").
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("AD_FORMAT_NAME")]
                    ADFORMATNAME = 44,

                    /// <summary>
                    /// Ad format code indicating the way an ad is shown to the users on your site (e.g. "ON_PAGE",
                    /// "ANCHOR", "INTERSTITIAL").
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("AD_FORMAT_CODE")]
                    ADFORMATCODE = 45,

                    /// <summary>Custom search style name.</summary>
                    [Google.Apis.Util.StringValueAttribute("CUSTOM_SEARCH_STYLE_NAME")]
                    CUSTOMSEARCHSTYLENAME = 40,

                    /// <summary>Custom search style id.</summary>
                    [Google.Apis.Util.StringValueAttribute("CUSTOM_SEARCH_STYLE_ID")]
                    CUSTOMSEARCHSTYLEID = 41,

                    /// <summary>Domain registrants.</summary>
                    [Google.Apis.Util.StringValueAttribute("DOMAIN_REGISTRANT")]
                    DOMAINREGISTRANT = 42,

                    /// <summary>Query strings for web searches.</summary>
                    [Google.Apis.Util.StringValueAttribute("WEBSEARCH_QUERY_STRING")]
                    WEBSEARCHQUERYSTRING = 43,
                }

                /// <summary>
                /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by
                /// itself or a year and month where the day isn't significant.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("endDate.day", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> EndDateDay { get; set; }

                /// <summary>
                /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("endDate.month", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> EndDateMonth { get; set; }

                /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
                [Google.Apis.Util.RequestParameterAttribute("endDate.year", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> EndDateYear { get; set; }

                /// <summary>
                /// A list of [filters](/adsense/management/reporting/filtering) to apply to the report. All provided
                /// filters must match in order for the data to be included in the report.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filters", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> Filters { get; set; }

                /// <summary>
                /// The language to use for translating report output. If unspecified, this defaults to English ("en").
                /// If the given language is not supported, report output will be returned in English. The language is
                /// specified as an [IETF BCP-47 language code](https://en.wikipedia.org/wiki/IETF_language_tag).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string LanguageCode { get; set; }

                /// <summary>
                /// The maximum number of rows of report data to return. Reports producing more rows than the requested
                /// limit will be truncated. If unset, this defaults to 100,000 rows for `Reports.GenerateReport` and
                /// 1,000,000 rows for `Reports.GenerateCsvReport`, which are also the maximum values permitted here.
                /// Report truncation can be identified (for `Reports.GenerateReport` only) by comparing the number of
                /// rows returned to the value returned in `total_matched_rows`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("limit", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> Limit { get; set; }

                /// <summary>Required. Reporting metrics.</summary>
                /// <remarks>
                /// Use this property to set a single value for the parameter, or <see cref="MetricsList"/> to set
                /// multiple values. Do not set both properties.
                /// </remarks>
                [Google.Apis.Util.RequestParameterAttribute("metrics", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<MetricsEnum> Metrics { get; set; }

                /// <summary>Required. Reporting metrics.</summary>
                /// <remarks>
                /// Use this property to set one or more values for the parameter. Do not set both this property and
                /// <see cref="Metrics"/>.
                /// </remarks>
                [Google.Apis.Util.RequestParameterAttribute("metrics", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<MetricsEnum> MetricsList { get; set; }

                /// <summary>Required. Reporting metrics.</summary>
                public enum MetricsEnum
                {
                    /// <summary>Unspecified metric.</summary>
                    [Google.Apis.Util.StringValueAttribute("METRIC_UNSPECIFIED")]
                    METRICUNSPECIFIED = 0,

                    /// <summary>Number of page views.</summary>
                    [Google.Apis.Util.StringValueAttribute("PAGE_VIEWS")]
                    PAGEVIEWS = 1,

                    /// <summary>
                    /// Number of ad units that requested ads (for content ads) or search queries (for search ads). An
                    /// ad request may result in zero, one, or multiple individual ad impressions depending on the size
                    /// of the ad unit and whether any ads were available.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("AD_REQUESTS")]
                    ADREQUESTS = 2,

                    /// <summary>Requests that returned at least one ad.</summary>
                    [Google.Apis.Util.StringValueAttribute("MATCHED_AD_REQUESTS")]
                    MATCHEDADREQUESTS = 3,

                    /// <summary>
                    /// Impressions. An impression is counted for each ad request where at least one ad has been
                    /// downloaded to the user's device and has begun to load. It is the number of ad units (for content
                    /// ads) or search queries (for search ads) that showed ads.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("TOTAL_IMPRESSIONS")]
                    TOTALIMPRESSIONS = 4,

                    /// <summary>
                    /// Impressions. An impression is counted for each ad request where at least one ad has been
                    /// downloaded to the user's device and has begun to load. It is the number of ad units (for content
                    /// ads) or search queries (for search ads) that showed ads.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("IMPRESSIONS")]
                    IMPRESSIONS = 5,

                    /// <summary>
                    /// Ads shown. Different ad formats will display varying numbers of ads. For example, a vertical
                    /// banner may consist of 2 or more ads. Also, the number of ads in an ad unit may vary depending on
                    /// whether the ad unit is displaying standard text ads, expanded text ads or image ads.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("INDIVIDUAL_AD_IMPRESSIONS")]
                    INDIVIDUALADIMPRESSIONS = 6,

                    /// <summary>Number of times a user clicked on a standard content ad.</summary>
                    [Google.Apis.Util.StringValueAttribute("CLICKS")]
                    CLICKS = 7,

                    /// <summary>
                    /// Fraction of page views considered to be spam. Only available to [premium
                    /// accounts](https://developers.google.com/adsense/management/reference/rest/v2/accounts#Account.FIELDS.premium).
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("PAGE_VIEWS_SPAM_RATIO")]
                    PAGEVIEWSSPAMRATIO = 8,

                    /// <summary>
                    /// Fraction of ad requests considered to be spam. Only available to [premium
                    /// accounts](https://developers.google.com/adsense/management/reference/rest/v2/accounts#Account.FIELDS.premium).
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("AD_REQUESTS_SPAM_RATIO")]
                    ADREQUESTSSPAMRATIO = 9,

                    /// <summary>
                    /// Fraction of ad requests that returned ads considered to be spam. Only available to [premium
                    /// accounts](https://developers.google.com/adsense/management/reference/rest/v2/accounts#Account.FIELDS.premium).
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("MATCHED_AD_REQUESTS_SPAM_RATIO")]
                    MATCHEDADREQUESTSSPAMRATIO = 10,

                    /// <summary>
                    /// Fraction of impressions considered to be spam. Only available to [premium
                    /// accounts](https://developers.google.com/adsense/management/reference/rest/v2/accounts#Account.FIELDS.premium).
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("IMPRESSIONS_SPAM_RATIO")]
                    IMPRESSIONSSPAMRATIO = 11,

                    /// <summary>
                    /// Fraction of ad impressions considered to be spam. Only available to [premium
                    /// accounts](https://developers.google.com/adsense/management/reference/rest/v2/accounts#Account.FIELDS.premium).
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("INDIVIDUAL_AD_IMPRESSIONS_SPAM_RATIO")]
                    INDIVIDUALADIMPRESSIONSSPAMRATIO = 12,

                    /// <summary>
                    /// Fraction of clicks considered to be spam. Only available to [premium
                    /// accounts](https://developers.google.com/adsense/management/reference/rest/v2/accounts#Account.FIELDS.premium).
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("CLICKS_SPAM_RATIO")]
                    CLICKSSPAMRATIO = 13,

                    /// <summary>Ratio of requested ad units or queries to the number returned to the site.</summary>
                    [Google.Apis.Util.StringValueAttribute("AD_REQUESTS_COVERAGE")]
                    ADREQUESTSCOVERAGE = 14,

                    /// <summary>Ratio of individual page views that resulted in a click.</summary>
                    [Google.Apis.Util.StringValueAttribute("PAGE_VIEWS_CTR")]
                    PAGEVIEWSCTR = 15,

                    /// <summary>Ratio of ad requests that resulted in a click.</summary>
                    [Google.Apis.Util.StringValueAttribute("AD_REQUESTS_CTR")]
                    ADREQUESTSCTR = 16,

                    /// <summary>Ratio of clicks to matched requests.</summary>
                    [Google.Apis.Util.StringValueAttribute("MATCHED_AD_REQUESTS_CTR")]
                    MATCHEDADREQUESTSCTR = 17,

                    /// <summary>Ratio of IMPRESSIONS that resulted in a click.</summary>
                    [Google.Apis.Util.StringValueAttribute("IMPRESSIONS_CTR")]
                    IMPRESSIONSCTR = 18,

                    /// <summary>Ratio of individual ad impressions that resulted in a click.</summary>
                    [Google.Apis.Util.StringValueAttribute("INDIVIDUAL_AD_IMPRESSIONS_CTR")]
                    INDIVIDUALADIMPRESSIONSCTR = 19,

                    /// <summary>Ratio of requests that were measurable for viewability.</summary>
                    [Google.Apis.Util.StringValueAttribute("ACTIVE_VIEW_MEASURABILITY")]
                    ACTIVEVIEWMEASURABILITY = 20,

                    /// <summary>Ratio of requests that were viewable.</summary>
                    [Google.Apis.Util.StringValueAttribute("ACTIVE_VIEW_VIEWABILITY")]
                    ACTIVEVIEWVIEWABILITY = 21,

                    /// <summary>Mean time an ad was displayed on screen.</summary>
                    [Google.Apis.Util.StringValueAttribute("ACTIVE_VIEW_TIME")]
                    ACTIVEVIEWTIME = 22,

                    /// <summary>
                    /// Estimated earnings of the publisher. Note that earnings up to yesterday are accurate, more
                    /// recent earnings are estimated due to the possibility of spam, or exchange rate fluctuations.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ESTIMATED_EARNINGS")]
                    ESTIMATEDEARNINGS = 23,

                    /// <summary>
                    /// Revenue per thousand page views. This is calculated by dividing the estimated revenue by the
                    /// number of page views multiplied by 1000.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("PAGE_VIEWS_RPM")]
                    PAGEVIEWSRPM = 24,

                    /// <summary>
                    /// Revenue per thousand ad requests. This is calculated by dividing estimated revenue by the number
                    /// of ad requests multiplied by 1000.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("AD_REQUESTS_RPM")]
                    ADREQUESTSRPM = 25,

                    /// <summary>
                    /// Revenue per thousand matched ad requests. This is calculated by dividing estimated revenue by
                    /// the number of matched ad requests multiplied by 1000.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("MATCHED_AD_REQUESTS_RPM")]
                    MATCHEDADREQUESTSRPM = 26,

                    /// <summary>
                    /// Revenue per thousand ad impressions. This is calculated by dividing estimated revenue by the
                    /// number of ad impressions multiplied by 1000.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("IMPRESSIONS_RPM")]
                    IMPRESSIONSRPM = 27,

                    /// <summary>
                    /// Revenue per thousand individual ad impressions. This is calculated by dividing estimated revenue
                    /// by the number of individual ad impressions multiplied by 1000.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("INDIVIDUAL_AD_IMPRESSIONS_RPM")]
                    INDIVIDUALADIMPRESSIONSRPM = 28,

                    /// <summary>
                    /// Amount the publisher earns each time a user clicks on an ad. CPC is calculated by dividing the
                    /// estimated revenue by the number of clicks received.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("COST_PER_CLICK")]
                    COSTPERCLICK = 29,

                    /// <summary>Number of ad views per impression.</summary>
                    [Google.Apis.Util.StringValueAttribute("ADS_PER_IMPRESSION")]
                    ADSPERIMPRESSION = 30,

                    /// <summary>
                    /// Total earnings are the gross estimated earnings from revenue shared traffic before any parent
                    /// and child account revenue share is applied.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("TOTAL_EARNINGS")]
                    TOTALEARNINGS = 31,

                    /// <summary>
                    /// Number of results pages. This metric can only be used when generating a report in the Google
                    /// timezone, not the account timezone. Since the account timezone is the default for report
                    /// generation, this metric can only be used by explicitly specifying
                    /// `reportingTimeZone=GOOGLE_TIME_ZONE`.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("WEBSEARCH_RESULT_PAGES")]
                    WEBSEARCHRESULTPAGES = 32,

                    /// <summary>
                    /// Number of requests for non-ad units (for example a related search unit). For more information,
                    /// see [Funnel requests](https://support.google.com/adsense/answer/11586959).
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("FUNNEL_REQUESTS")]
                    FUNNELREQUESTS = 33,

                    /// <summary>
                    /// Number of requests for non-ad units ads that returned content that was shown to the user. For
                    /// more information, see [Funnel impressions](https://support.google.com/adsense/answer/11585767).
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("FUNNEL_IMPRESSIONS")]
                    FUNNELIMPRESSIONS = 34,

                    /// <summary>
                    /// Number of times a user clicked on a non-ad unit, triggering further ad requests. For more
                    /// information, see [Funnel clicks](https://support.google.com/adsense/answer/11586382).
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("FUNNEL_CLICKS")]
                    FUNNELCLICKS = 35,

                    /// <summary>
                    /// Revenue per thousand funnel impressions. This is calculated by dividing estimated revenue by the
                    /// number of funnel impressions multiplied by 1000. For more information, see [Funnel
                    /// RPM](https://support.google.com/adsense/answer/11585979).
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("FUNNEL_RPM")]
                    FUNNELRPM = 36,
                }

                /// <summary>
                /// The name of a dimension or metric to sort the resulting report on, can be prefixed with "+" to sort
                /// ascending or "-" to sort descending. If no prefix is specified, the column is sorted ascending.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> OrderBy { get; set; }

                /// <summary>
                /// Timezone in which to generate the report. If unspecified, this defaults to the account timezone. For
                /// more information, see [changing the time zone of your
                /// reports](https://support.google.com/adsense/answer/9830725).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("reportingTimeZone", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ReportingTimeZoneEnum> ReportingTimeZone { get; set; }

                /// <summary>
                /// Timezone in which to generate the report. If unspecified, this defaults to the account timezone. For
                /// more information, see [changing the time zone of your
                /// reports](https://support.google.com/adsense/answer/9830725).
                /// </summary>
                public enum ReportingTimeZoneEnum
                {
                    /// <summary>Unspecified timezone.</summary>
                    [Google.Apis.Util.StringValueAttribute("REPORTING_TIME_ZONE_UNSPECIFIED")]
                    REPORTINGTIMEZONEUNSPECIFIED = 0,

                    /// <summary>Use the account timezone in the report.</summary>
                    [Google.Apis.Util.StringValueAttribute("ACCOUNT_TIME_ZONE")]
                    ACCOUNTTIMEZONE = 1,

                    /// <summary>Use the Google timezone in the report (America/Los_Angeles).</summary>
                    [Google.Apis.Util.StringValueAttribute("GOOGLE_TIME_ZONE")]
                    GOOGLETIMEZONE = 2,
                }

                /// <summary>
                /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by
                /// itself or a year and month where the day isn't significant.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("startDate.day", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> StartDateDay { get; set; }

                /// <summary>
                /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("startDate.month", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> StartDateMonth { get; set; }

                /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
                [Google.Apis.Util.RequestParameterAttribute("startDate.year", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> StartDateYear { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "generateCsv";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+account}/reports:generateCsv";

                /// <summary>Initializes GenerateCsv parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("account", new Google.Apis.Discovery.Parameter
                    {
                        Name = "account",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+$",
                    });
                    RequestParameters.Add("currencyCode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "currencyCode",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("dateRange", new Google.Apis.Discovery.Parameter
                    {
                        Name = "dateRange",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("dimensions", new Google.Apis.Discovery.Parameter
                    {
                        Name = "dimensions",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("endDate.day", new Google.Apis.Discovery.Parameter
                    {
                        Name = "endDate.day",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("endDate.month", new Google.Apis.Discovery.Parameter
                    {
                        Name = "endDate.month",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("endDate.year", new Google.Apis.Discovery.Parameter
                    {
                        Name = "endDate.year",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("filters", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filters",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("languageCode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "languageCode",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("limit", new Google.Apis.Discovery.Parameter
                    {
                        Name = "limit",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("metrics", new Google.Apis.Discovery.Parameter
                    {
                        Name = "metrics",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderBy",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("reportingTimeZone", new Google.Apis.Discovery.Parameter
                    {
                        Name = "reportingTimeZone",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("startDate.day", new Google.Apis.Discovery.Parameter
                    {
                        Name = "startDate.day",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("startDate.month", new Google.Apis.Discovery.Parameter
                    {
                        Name = "startDate.month",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("startDate.year", new Google.Apis.Discovery.Parameter
                    {
                        Name = "startDate.year",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Gets the saved report from the given resource name.</summary>
            /// <param name="name">
            /// Required. The name of the saved report to retrieve. Format: accounts/{account}/reports/{report}
            /// </param>
            public virtual GetSavedRequest GetSaved(string name)
            {
                return new GetSavedRequest(this.service, name);
            }

            /// <summary>Gets the saved report from the given resource name.</summary>
            public class GetSavedRequest : AdsenseBaseServiceRequest<Google.Apis.Adsense.v2.Data.SavedReport>
            {
                /// <summary>Constructs a new GetSaved request.</summary>
                public GetSavedRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the saved report to retrieve. Format: accounts/{account}/reports/{report}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getSaved";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}/saved";

                /// <summary>Initializes GetSaved parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+/reports/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the Sites resource.</summary>
        public virtual SitesResource Sites { get; }

        /// <summary>The "sites" collection of methods.</summary>
        public class SitesResource
        {
            private const string Resource = "sites";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SitesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Gets information about the selected site.</summary>
            /// <param name="name">Required. Name of the site. Format: accounts/{account}/sites/{site}</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets information about the selected site.</summary>
            public class GetRequest : AdsenseBaseServiceRequest<Google.Apis.Adsense.v2.Data.Site>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. Name of the site. Format: accounts/{account}/sites/{site}</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^accounts/[^/]+/sites/[^/]+$",
                    });
                }
            }

            /// <summary>Lists all the sites available in an account.</summary>
            /// <param name="parent">
            /// Required. The account which owns the collection of sites. Format: accounts/{account}
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists all the sites available in an account.</summary>
            public class ListRequest : AdsenseBaseServiceRequest<Google.Apis.Adsense.v2.Data.ListSitesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The account which owns the collection of sites. Format: accounts/{account}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of sites to include in the response, used for paging. If unspecified, at most
                /// 10000 sites will be returned. The maximum value is 10000; values above 10000 will be coerced to
                /// 10000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token, received from a previous `ListSites` call. Provide this to retrieve the subsequent
                /// page. When paginating, all other parameters provided to `ListSites` must match the call that
                /// provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/sites";

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

        /// <summary>Gets information about the selected AdSense account.</summary>
        /// <param name="name">Required. Account to get information about. Format: accounts/{account}</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(this.service, name);
        }

        /// <summary>Gets information about the selected AdSense account.</summary>
        public class GetRequest : AdsenseBaseServiceRequest<Google.Apis.Adsense.v2.Data.Account>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. Account to get information about. Format: accounts/{account}</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/{+name}";

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

        /// <summary>Gets the ad blocking recovery tag of an account.</summary>
        /// <param name="name">Required. The name of the account to get the tag for. Format: accounts/{account}</param>
        public virtual GetAdBlockingRecoveryTagRequest GetAdBlockingRecoveryTag(string name)
        {
            return new GetAdBlockingRecoveryTagRequest(this.service, name);
        }

        /// <summary>Gets the ad blocking recovery tag of an account.</summary>
        public class GetAdBlockingRecoveryTagRequest : AdsenseBaseServiceRequest<Google.Apis.Adsense.v2.Data.AdBlockingRecoveryTag>
        {
            /// <summary>Constructs a new GetAdBlockingRecoveryTag request.</summary>
            public GetAdBlockingRecoveryTagRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. The name of the account to get the tag for. Format: accounts/{account}</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getAdBlockingRecoveryTag";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/{+name}/adBlockingRecoveryTag";

            /// <summary>Initializes GetAdBlockingRecoveryTag parameter list.</summary>
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

        /// <summary>Lists all accounts available to this user.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Lists all accounts available to this user.</summary>
        public class ListRequest : AdsenseBaseServiceRequest<Google.Apis.Adsense.v2.Data.ListAccountsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// The maximum number of accounts to include in the response, used for paging. If unspecified, at most
            /// 10000 accounts will be returned. The maximum value is 10000; values above 10000 will be coerced to
            /// 10000.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// A page token, received from a previous `ListAccounts` call. Provide this to retrieve the subsequent
            /// page. When paginating, all other parameters provided to `ListAccounts` must match the call that provided
            /// the page token.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/accounts";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
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

        /// <summary>Lists all accounts directly managed by the given AdSense account.</summary>
        /// <param name="parent">
        /// Required. The parent account, which owns the child accounts. Format: accounts/{account}
        /// </param>
        public virtual ListChildAccountsRequest ListChildAccounts(string parent)
        {
            return new ListChildAccountsRequest(this.service, parent);
        }

        /// <summary>Lists all accounts directly managed by the given AdSense account.</summary>
        public class ListChildAccountsRequest : AdsenseBaseServiceRequest<Google.Apis.Adsense.v2.Data.ListChildAccountsResponse>
        {
            /// <summary>Constructs a new ListChildAccounts request.</summary>
            public ListChildAccountsRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
            {
                Parent = parent;
                InitParameters();
            }

            /// <summary>
            /// Required. The parent account, which owns the child accounts. Format: accounts/{account}
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>
            /// The maximum number of accounts to include in the response, used for paging. If unspecified, at most
            /// 10000 accounts will be returned. The maximum value is 10000; values above 10000 will be coerced to
            /// 10000.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// A page token, received from a previous `ListChildAccounts` call. Provide this to retrieve the subsequent
            /// page. When paginating, all other parameters provided to `ListChildAccounts` must match the call that
            /// provided the page token.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "listChildAccounts";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/{+parent}:listChildAccounts";

            /// <summary>Initializes ListChildAccounts parameter list.</summary>
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
}
namespace Google.Apis.Adsense.v2.Data
{
    /// <summary>Representation of an account.</summary>
    public class Account : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Creation time of the account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual string CreateTimeRaw
        {
            get => _createTimeRaw;
            set
            {
                _createTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _createTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreateTimeDateTimeOffset instead.")]
        public virtual object CreateTime
        {
            get => _createTime;
            set
            {
                _createTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _createTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. Display name of this account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. Resource name of the account. Format: accounts/pub-[0-9]+</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Outstanding tasks that need to be completed as part of the sign-up process for a new account.
        /// e.g. "billing-profile-creation", "phone-pin-verification".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pendingTasks")]
        public virtual System.Collections.Generic.IList<string> PendingTasks { get; set; }

        /// <summary>
        /// Output only. Whether this account is premium. Premium accounts have access to additional spam-related
        /// metrics.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("premium")]
        public virtual System.Nullable<bool> Premium { get; set; }

        /// <summary>Output only. State of the account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// The account time zone, as used by reporting. For more information, see [changing the time zone of your
        /// reports](https://support.google.com/adsense/answer/9830725).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual TimeZone TimeZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Representation of an ad blocking recovery tag. See https://support.google.com/adsense/answer/11575177.
    /// </summary>
    public class AdBlockingRecoveryTag : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Error protection code that can be used in conjunction with the tag. It'll display a message to users if an
        /// [ad blocking extension blocks their access to your
        /// site](https://support.google.com/adsense/answer/11575480).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorProtectionCode")]
        public virtual string ErrorProtectionCode { get; set; }

        /// <summary>
        /// The ad blocking recovery tag. Note that the message generated by the tag can be blocked by an ad blocking
        /// extension. If this is not your desired outcome, then you'll need to use it in conjunction with the error
        /// protection code.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tag")]
        public virtual string Tag { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Representation of an ad client. An ad client represents a user's subscription with a specific AdSense product.
    /// </summary>
    public class AdClient : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Resource name of the ad client. Format: accounts/{account}/adclients/{adclient}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Reporting product code of the ad client. For example, "AFC" for AdSense for Content.
        /// Corresponds to the `PRODUCT_CODE` dimension, and present only if the ad client supports reporting.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productCode")]
        public virtual string ProductCode { get; set; }

        /// <summary>
        /// Output only. Unique ID of the ad client as used in the `AD_CLIENT_ID` reporting dimension. Present only if
        /// the ad client supports reporting.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportingDimensionId")]
        public virtual string ReportingDimensionId { get; set; }

        /// <summary>Output only. State of the ad client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Representation of the AdSense code for a given ad client. For more information, see [About the AdSense
    /// code](https://support.google.com/adsense/answer/9274634).
    /// </summary>
    public class AdClientAdCode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The AdSense code snippet to add to the head of an HTML page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adCode")]
        public virtual string AdCode { get; set; }

        /// <summary>Output only. The AdSense code snippet to add to the body of an AMP page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ampBody")]
        public virtual string AmpBody { get; set; }

        /// <summary>Output only. The AdSense code snippet to add to the head of an AMP page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ampHead")]
        public virtual string AmpHead { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Representation of an ad unit. An ad unit represents a saved ad unit with a specific set of ad settings that have
    /// been customized within an account.
    /// </summary>
    public class AdUnit : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Settings specific to content ads (AFC).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentAdsSettings")]
        public virtual ContentAdsSettings ContentAdsSettings { get; set; }

        /// <summary>Required. Display name of the ad unit, as provided when the ad unit was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. Resource name of the ad unit. Format: accounts/{account}/adclients/{adclient}/adunits/{adunit}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Unique ID of the ad unit as used in the `AD_UNIT_ID` reporting dimension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportingDimensionId")]
        public virtual string ReportingDimensionId { get; set; }

        /// <summary>Required. State of the ad unit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Representation of the ad unit code for a given ad unit. For more information, see [About the AdSense
    /// code](https://support.google.com/adsense/answer/9274634) and [Where to place the ad code in your
    /// HTML](https://support.google.com/adsense/answer/9190028).
    /// </summary>
    public class AdUnitAdCode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The code snippet to add to the body of an HTML page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adCode")]
        public virtual string AdCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Representation of an alert.</summary>
    public class Alert : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The localized alert message. This may contain HTML markup, such as phrase elements or links.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>Output only. Resource name of the alert. Format: accounts/{account}/alerts/{alert}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Severity of this alert.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>
        /// Output only. Type of alert. This identifies the broad type of this alert, and provides a stable
        /// machine-readable identifier that will not be translated. For example, "payment-hold".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Cell representation.</summary>
    public class Cell : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Value in the cell. The dimension cells contain strings, and the metric cells contain numbers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings specific to content ads (AFC).</summary>
    public class ContentAdsSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Size of the ad unit. e.g. "728x90", "1x3" (for responsive ad units).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("size")]
        public virtual string Size { get; set; }

        /// <summary>Required. Type of the ad unit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Representation of a custom channel.</summary>
    public class CustomChannel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether the custom channel is active and collecting data. See
        /// https://support.google.com/adsense/answer/10077192.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("active")]
        public virtual System.Nullable<bool> Active { get; set; }

        /// <summary>Required. Display name of the custom channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. Resource name of the custom channel. Format:
        /// accounts/{account}/adclients/{adclient}/customchannels/{customchannel}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Unique ID of the custom channel as used in the `CUSTOM_CHANNEL_ID` reporting dimension.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportingDimensionId")]
        public virtual string ReportingDimensionId { get; set; }

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

    /// <summary>The header information of the columns requested in the report.</summary>
    public class Header : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The [ISO-4217 currency code](https://en.wikipedia.org/wiki/ISO_4217) of this column. Only present if the
        /// header type is METRIC_CURRENCY.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>Required. Name of the header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. Type of the header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Message that represents an arbitrary HTTP body. It should only be used for payload formats that can't be
    /// represented as JSON, such as raw binary or an HTML page. This message can be used both in streaming and
    /// non-streaming API methods in the request as well as the response. It can be used as a top-level request field,
    /// which is convenient if one wants to extract parameters from either the URL or HTTP template into the request
    /// fields and also want access to the raw HTTP body. Example: message GetResourceRequest { // A unique request id.
    /// string request_id = 1; // The raw HTTP body is bound to this field. google.api.HttpBody http_body = 2; } service
    /// ResourceService { rpc GetResource(GetResourceRequest) returns (google.api.HttpBody); rpc
    /// UpdateResource(google.api.HttpBody) returns (google.protobuf.Empty); } Example with streaming methods: service
    /// CaldavService { rpc GetCalendar(stream google.api.HttpBody) returns (stream google.api.HttpBody); rpc
    /// UpdateCalendar(stream google.api.HttpBody) returns (stream google.api.HttpBody); } Use of this type only changes
    /// how the request and response bodies are handled, all other features will continue to work unchanged.
    /// </summary>
    public class HttpBody : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The HTTP Content-Type header value specifying the content type of the body.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentType")]
        public virtual string ContentType { get; set; }

        /// <summary>The HTTP request/response body as raw binary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>
        /// Application specific response metadata. Must be set in the first response for streaming APIs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extensions")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Extensions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response definition for the account list rpc.</summary>
    public class ListAccountsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The accounts returned in this list response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accounts")]
        public virtual System.Collections.Generic.IList<Account> Accounts { get; set; }

        /// <summary>
        /// Continuation token used to page through accounts. To retrieve the next page of the results, set the next
        /// request's "page_token" value to this.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response definition for the ad client list rpc.</summary>
    public class ListAdClientsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ad clients returned in this list response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adClients")]
        public virtual System.Collections.Generic.IList<AdClient> AdClients { get; set; }

        /// <summary>
        /// Continuation token used to page through ad clients. To retrieve the next page of the results, set the next
        /// request's "page_token" value to this.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response definition for the adunit list rpc.</summary>
    public class ListAdUnitsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ad units returned in the list response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adUnits")]
        public virtual System.Collections.Generic.IList<AdUnit> AdUnits { get; set; }

        /// <summary>
        /// Continuation token used to page through ad units. To retrieve the next page of the results, set the next
        /// request's "page_token" value to this.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response definition for the alerts list rpc.</summary>
    public class ListAlertsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The alerts returned in this list response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alerts")]
        public virtual System.Collections.Generic.IList<Alert> Alerts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response definition for the child account list rpc.</summary>
    public class ListChildAccountsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The accounts returned in this list response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accounts")]
        public virtual System.Collections.Generic.IList<Account> Accounts { get; set; }

        /// <summary>
        /// Continuation token used to page through accounts. To retrieve the next page of the results, set the next
        /// request's "page_token" value to this.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response definition for the custom channel list rpc.</summary>
    public class ListCustomChannelsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The custom channels returned in this list response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customChannels")]
        public virtual System.Collections.Generic.IList<CustomChannel> CustomChannels { get; set; }

        /// <summary>
        /// Continuation token used to page through alerts. To retrieve the next page of the results, set the next
        /// request's "page_token" value to this.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response definition for the ad units linked to a custom channel list rpc.</summary>
    public class ListLinkedAdUnitsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ad units returned in the list response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adUnits")]
        public virtual System.Collections.Generic.IList<AdUnit> AdUnits { get; set; }

        /// <summary>
        /// Continuation token used to page through ad units. To retrieve the next page of the results, set the next
        /// request's "page_token" value to this.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response definition for the custom channels linked to an adunit list rpc.</summary>
    public class ListLinkedCustomChannelsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The custom channels returned in this list response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customChannels")]
        public virtual System.Collections.Generic.IList<CustomChannel> CustomChannels { get; set; }

        /// <summary>
        /// Continuation token used to page through alerts. To retrieve the next page of the results, set the next
        /// request's "page_token" value to this.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response definition for the payments list rpc.</summary>
    public class ListPaymentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The payments returned in this list response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payments")]
        public virtual System.Collections.Generic.IList<Payment> Payments { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response definition for the policy issues list rpc. Policy issues are reported only if the publisher has at
    /// least one AFC ad client in READY or GETTING_READY state. If the publisher has no such AFC ad client, the
    /// response will be an empty list.
    /// </summary>
    public class ListPolicyIssuesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Continuation token used to page through policy issues. To retrieve the next page of the results, set the
        /// next request's "page_token" value to this.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The policy issues returned in the list response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyIssues")]
        public virtual System.Collections.Generic.IList<PolicyIssue> PolicyIssues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response definition for the saved reports list rpc.</summary>
    public class ListSavedReportsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Continuation token used to page through reports. To retrieve the next page of the results, set the next
        /// request's "page_token" value to this.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The reports returned in this list response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("savedReports")]
        public virtual System.Collections.Generic.IList<SavedReport> SavedReports { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response definition for the sites list rpc.</summary>
    public class ListSitesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Continuation token used to page through sites. To retrieve the next page of the results, set the next
        /// request's "page_token" value to this.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The sites returned in this list response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sites")]
        public virtual System.Collections.Generic.IList<Site> Sites { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response definition for the url channels list rpc.</summary>
    public class ListUrlChannelsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Continuation token used to page through url channels. To retrieve the next page of the results, set the next
        /// request's "page_token" value to this.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The url channels returned in this list response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("urlChannels")]
        public virtual System.Collections.Generic.IList<UrlChannel> UrlChannels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Representation of an unpaid or paid payment. See [Payment timelines for
    /// AdSense](https://support.google.com/adsense/answer/7164703) for more information about payments and the [YouTube
    /// homepage and payments account](https://support.google.com/adsense/answer/11622510) article for information about
    /// dedicated payments accounts for YouTube.
    /// </summary>
    public class Payment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The amount of unpaid or paid earnings, as a formatted string, including the currency. E.g.
        /// "¥1,235 JPY", "$1,234.57", "£87.65".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amount")]
        public virtual string Amount { get; set; }

        /// <summary>
        /// Output only. For paid earnings, the date that the payment was credited. For unpaid earnings, this field is
        /// empty. Payment dates are always returned in the billing timezone (America/Los_Angeles).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual Date Date { get; set; }

        /// <summary>
        /// Output only. Resource name of the payment. Format: - accounts/{account}/payments/unpaid for unpaid (current)
        /// AdSense earnings. - accounts/{account}/payments/youtube-unpaid for unpaid (current) YouTube earnings. -
        /// accounts/{account}/payments/yyyy-MM-dd for paid AdSense earnings. -
        /// accounts/{account}/payments/youtube-yyyy-MM-dd for paid YouTube earnings.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Representation of a policy issue for a single entity (site, site-section, or page). All issues for a single
    /// entity are represented by a single PolicyIssue resource, though that PolicyIssue can have multiple causes (or
    /// "topics") that can change over time. Policy issues are removed if there are no issues detected recently or if
    /// there's a recent successful appeal for the entity.
    /// </summary>
    public class PolicyIssue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The most severe action taken on the entity over the past seven days.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        /// <summary>
        /// Optional. List of ad clients associated with the policy issue (either as the primary ad client or an
        /// associated host/secondary ad client). In the latter case, this will be an ad client that is not owned by the
        /// current account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adClients")]
        public virtual System.Collections.Generic.IList<string> AdClients { get; set; }

        /// <summary>
        /// Required. Total number of ad requests affected by the policy violations over the past seven days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adRequestCount")]
        public virtual System.Nullable<long> AdRequestCount { get; set; }

        /// <summary>Required. Type of the entity indicating if the entity is a site, site-section, or page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityType")]
        public virtual string EntityType { get; set; }

        /// <summary>
        /// Required. The date (in the America/Los_Angeles timezone) when policy violations were first detected on the
        /// entity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstDetectedDate")]
        public virtual Date FirstDetectedDate { get; set; }

        /// <summary>
        /// Required. The date (in the America/Los_Angeles timezone) when policy violations were last detected on the
        /// entity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastDetectedDate")]
        public virtual Date LastDetectedDate { get; set; }

        /// <summary>
        /// Required. Resource name of the entity with policy issues. Format:
        /// accounts/{account}/policyIssues/{policy_issue}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. Unordered list. The policy topics that this entity was found to violate over the past seven days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyTopics")]
        public virtual System.Collections.Generic.IList<PolicyTopic> PolicyTopics { get; set; }

        /// <summary>
        /// Required. Hostname/domain of the entity (for example "foo.com" or "www.foo.com"). This _should_ be a bare
        /// domain/host name without any protocol. This will be present for all policy issues.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("site")]
        public virtual string Site { get; set; }

        /// <summary>
        /// Optional. Prefix of the site-section having policy issues (For example "foo.com/bar-section"). This will be
        /// present if the `entity_type` is `SITE_SECTION` and will be absent for other entity types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("siteSection")]
        public virtual string SiteSection { get; set; }

        /// <summary>
        /// Optional. URI of the page having policy violations (for example "foo.com/bar" or "www.foo.com/bar"). This
        /// will be present if the `entity_type` is `PAGE` and will be absent for other entity types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>
        /// Optional. The date (in the America/Los_Angeles timezone) when the entity will have ad serving demand
        /// restricted or ad serving disabled. This is present only for issues with a `WARNED` enforcement action. See
        /// https://support.google.com/adsense/answer/11066888.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warningEscalationDate")]
        public virtual Date WarningEscalationDate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information about a particular policy topic. A policy topic represents a single class of policy issue that can
    /// impact ad serving for your site. For example, sexual content or having ads that obscure your content. A single
    /// policy issue can have multiple policy topics for a single entity.
    /// </summary>
    public class PolicyTopic : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Deprecated. Always set to false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mustFix")]
        public virtual System.Nullable<bool> MustFix { get; set; }

        /// <summary>Required. The policy topic. For example, "sexual-content" or "ads-obscuring-content"."</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topic")]
        public virtual string Topic { get; set; }

        /// <summary>
        /// Optional. The type of policy topic. For example, "POLICY" represents all the policy topics that are related
        /// to the Google Publisher Policy (GPP). See https://support.google.com/adsense/answer/15689616.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Result of a generated report.</summary>
    public class ReportResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The averages of the report. This is the same length as any other row in the report; cells corresponding to
        /// dimension columns are empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("averages")]
        public virtual Row Averages { get; set; }

        /// <summary>Required. End date of the range (inclusive).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual Date EndDate { get; set; }

        /// <summary>
        /// The header information; one for each dimension in the request, followed by one for each metric in the
        /// request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headers")]
        public virtual System.Collections.Generic.IList<Header> Headers { get; set; }

        /// <summary>
        /// The output rows of the report. Each row is a list of cells; one for each dimension in the request, followed
        /// by one for each metric in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<Row> Rows { get; set; }

        /// <summary>Required. Start date of the range (inclusive).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual Date StartDate { get; set; }

        /// <summary>The total number of rows matched by the report request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalMatchedRows")]
        public virtual System.Nullable<long> TotalMatchedRows { get; set; }

        /// <summary>
        /// The totals of the report. This is the same length as any other row in the report; cells corresponding to
        /// dimension columns are empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totals")]
        public virtual Row Totals { get; set; }

        /// <summary>
        /// Any warnings associated with generation of the report. These warnings are always returned in English.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warnings")]
        public virtual System.Collections.Generic.IList<string> Warnings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Row representation.</summary>
    public class Row : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Cells in the row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cells")]
        public virtual System.Collections.Generic.IList<Cell> Cells { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Representation of a saved report.</summary>
    public class SavedReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Resource name of the report. Format: accounts/{account}/reports/{report}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Report title as specified by publisher.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Representation of a Site.</summary>
    public class Site : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether auto ads is turned on for the site.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoAdsEnabled")]
        public virtual System.Nullable<bool> AutoAdsEnabled { get; set; }

        /// <summary>
        /// Domain (or subdomain) of the site, e.g. "example.com" or "www.example.com". This is used in the
        /// `OWNED_SITE_DOMAIN_NAME` reporting dimension.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>Output only. Resource name of a site. Format: accounts/{account}/sites/{site}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Unique ID of the site as used in the `OWNED_SITE_ID` reporting dimension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportingDimensionId")]
        public virtual string ReportingDimensionId { get; set; }

        /// <summary>Output only. State of a site.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

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
    /// Representation of a URL channel. URL channels allow you to track the performance of particular pages in your
    /// site; see [URL channels](https://support.google.com/adsense/answer/2923836) for more information.
    /// </summary>
    public class UrlChannel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Resource name of the URL channel. Format:
        /// accounts/{account}/adclients/{adclient}/urlchannels/{urlchannel}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Unique ID of the custom channel as used in the `URL_CHANNEL_ID` reporting dimension.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportingDimensionId")]
        public virtual string ReportingDimensionId { get; set; }

        /// <summary>
        /// URI pattern of the channel. Does not include "http://" or "https://". Example: www.example.com/home
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uriPattern")]
        public virtual string UriPattern { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
