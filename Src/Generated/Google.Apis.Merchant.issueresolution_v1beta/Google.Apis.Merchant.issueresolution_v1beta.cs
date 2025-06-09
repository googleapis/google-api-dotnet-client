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

namespace Google.Apis.Merchant.issueresolution_v1beta
{
    /// <summary>The Merchant Service.</summary>
    public class MerchantService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "issueresolution_v1beta";

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
            Issueresolution = new IssueresolutionResource(this);
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

        /// <summary>Gets the Issueresolution resource.</summary>
        public virtual IssueresolutionResource Issueresolution { get; }
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
            AggregateProductStatuses = new AggregateProductStatusesResource(service);
        }

        /// <summary>Gets the AggregateProductStatuses resource.</summary>
        public virtual AggregateProductStatusesResource AggregateProductStatuses { get; }

        /// <summary>The "aggregateProductStatuses" collection of methods.</summary>
        public class AggregateProductStatusesResource
        {
            private const string Resource = "aggregateProductStatuses";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AggregateProductStatusesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Lists the `AggregateProductStatuses` resources for your merchant account. The response might contain
            /// fewer items than specified by `pageSize`. If `pageToken` was returned in previous request, it can be
            /// used to obtain additional results.
            /// </summary>
            /// <param name="parent">
            /// Required. The account to list aggregate product statuses for. Format: `accounts/{account}`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>
            /// Lists the `AggregateProductStatuses` resources for your merchant account. The response might contain
            /// fewer items than specified by `pageSize`. If `pageToken` was returned in previous request, it can be
            /// used to obtain additional results.
            /// </summary>
            public class ListRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.issueresolution_v1beta.Data.ListAggregateProductStatusesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The account to list aggregate product statuses for. Format: `accounts/{account}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. A filter expression that filters the aggregate product statuses. Filtering is only
                /// supported by the `reporting_context` and `country` field. For example: `reporting_context =
                /// "SHOPPING_ADS" AND country = "US"`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Optional. The maximum number of aggregate product statuses to return. The service may return fewer
                /// than this value. If unspecified, at most 25 aggregate product statuses are returned. The maximum
                /// value is 250; values above 250 are coerced to 250.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A page token, received from a previous `ListAggregateProductStatuses` call. Provide this
                /// to retrieve the subsequent page. When paginating, all other parameters provided to
                /// `ListAggregateProductStatuses` must match the call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "issueresolution/v1beta/{+parent}/aggregateProductStatuses";

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
        }
    }

    /// <summary>The "issueresolution" collection of methods.</summary>
    public class IssueresolutionResource
    {
        private const string Resource = "issueresolution";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public IssueresolutionResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Provide a list of business's account issues with an issue resolution content and available actions. This
        /// content and actions are meant to be rendered and shown in third-party applications.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">Required. The account to fetch issues for. Format: `accounts/{account}`</param>
        public virtual RenderaccountissuesRequest Renderaccountissues(Google.Apis.Merchant.issueresolution_v1beta.Data.RenderIssuesRequestPayload body, string name)
        {
            return new RenderaccountissuesRequest(this.service, body, name);
        }

        /// <summary>
        /// Provide a list of business's account issues with an issue resolution content and available actions. This
        /// content and actions are meant to be rendered and shown in third-party applications.
        /// </summary>
        public class RenderaccountissuesRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.issueresolution_v1beta.Data.RenderAccountIssuesResponse>
        {
            /// <summary>Constructs a new Renderaccountissues request.</summary>
            public RenderaccountissuesRequest(Google.Apis.Services.IClientService service, Google.Apis.Merchant.issueresolution_v1beta.Data.RenderIssuesRequestPayload body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The account to fetch issues for. Format: `accounts/{account}`</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// Optional. The [IETF BCP-47](https://tools.ietf.org/html/bcp47) language code used to localize issue
            /// resolution content. If not set, the result will be in default language `en-US`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string LanguageCode { get; set; }

            /// <summary>
            /// Optional. The [IANA](https://www.iana.org/time-zones) timezone used to localize times in an issue
            /// resolution content. For example 'America/Los_Angeles'. If not set, results will use as a default UTC.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("timeZone", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string TimeZone { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Merchant.issueresolution_v1beta.Data.RenderIssuesRequestPayload Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "renderaccountissues";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "issueresolution/v1beta/{+name}:renderaccountissues";

            /// <summary>Initializes Renderaccountissues parameter list.</summary>
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
                RequestParameters.Add("languageCode", new Google.Apis.Discovery.Parameter
                {
                    Name = "languageCode",
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

        /// <summary>
        /// Provide a list of issues for business's product with an issue resolution content and available actions. This
        /// content and actions are meant to be rendered and shown in third-party applications.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Required. The name of the product to fetch issues for. Format: `accounts/{account}/products/{product}`
        /// </param>
        public virtual RenderproductissuesRequest Renderproductissues(Google.Apis.Merchant.issueresolution_v1beta.Data.RenderIssuesRequestPayload body, string name)
        {
            return new RenderproductissuesRequest(this.service, body, name);
        }

        /// <summary>
        /// Provide a list of issues for business's product with an issue resolution content and available actions. This
        /// content and actions are meant to be rendered and shown in third-party applications.
        /// </summary>
        public class RenderproductissuesRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.issueresolution_v1beta.Data.RenderProductIssuesResponse>
        {
            /// <summary>Constructs a new Renderproductissues request.</summary>
            public RenderproductissuesRequest(Google.Apis.Services.IClientService service, Google.Apis.Merchant.issueresolution_v1beta.Data.RenderIssuesRequestPayload body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the product to fetch issues for. Format: `accounts/{account}/products/{product}`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// Optional. The [IETF BCP-47](https://tools.ietf.org/html/bcp47) language code used to localize an issue
            /// resolution content. If not set, the result will be in default language `en-US`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string LanguageCode { get; set; }

            /// <summary>
            /// Optional. The [IANA](https://www.iana.org/time-zones) timezone used to localize times in an issue
            /// resolution content. For example 'America/Los_Angeles'. If not set, results will use as a default UTC.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("timeZone", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string TimeZone { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Merchant.issueresolution_v1beta.Data.RenderIssuesRequestPayload Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "renderproductissues";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "issueresolution/v1beta/{+name}:renderproductissues";

            /// <summary>Initializes Renderproductissues parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^accounts/[^/]+/products/[^/]+$",
                });
                RequestParameters.Add("languageCode", new Google.Apis.Discovery.Parameter
                {
                    Name = "languageCode",
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

        /// <summary>
        /// Start an action. The action can be requested by a business in third-party application. Before the business
        /// can request the action, the third-party application needs to show them action specific content and display a
        /// user input form. The action can be successfully started only once all `required` inputs are provided. If any
        /// `required` input is missing, or invalid value was provided, the service will return 400 error. Validation
        /// errors will contain Ids for all problematic field together with translated, human readable error messages
        /// that can be shown to the user.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Required. The business's account that is triggering the action. Format: `accounts/{account}`
        /// </param>
        public virtual TriggeractionRequest Triggeraction(Google.Apis.Merchant.issueresolution_v1beta.Data.TriggerActionPayload body, string name)
        {
            return new TriggeractionRequest(this.service, body, name);
        }

        /// <summary>
        /// Start an action. The action can be requested by a business in third-party application. Before the business
        /// can request the action, the third-party application needs to show them action specific content and display a
        /// user input form. The action can be successfully started only once all `required` inputs are provided. If any
        /// `required` input is missing, or invalid value was provided, the service will return 400 error. Validation
        /// errors will contain Ids for all problematic field together with translated, human readable error messages
        /// that can be shown to the user.
        /// </summary>
        public class TriggeractionRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.issueresolution_v1beta.Data.TriggerActionResponse>
        {
            /// <summary>Constructs a new Triggeraction request.</summary>
            public TriggeractionRequest(Google.Apis.Services.IClientService service, Google.Apis.Merchant.issueresolution_v1beta.Data.TriggerActionPayload body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. The business's account that is triggering the action. Format: `accounts/{account}`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// Optional. Language code [IETF BCP 47 syntax](https://tools.ietf.org/html/bcp47) used to localize the
            /// response. If not set, the result will be in default language `en-US`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string LanguageCode { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Merchant.issueresolution_v1beta.Data.TriggerActionPayload Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "triggeraction";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "issueresolution/v1beta/{+name}:triggeraction";

            /// <summary>Initializes Triggeraction parameter list.</summary>
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
}
namespace Google.Apis.Merchant.issueresolution_v1beta.Data
{
    /// <summary>An actionable step that can be executed to solve the issue.</summary>
    public class Action : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Action implemented and performed in (your) third-party application. The application should point the
        /// business to the place, where they can access the corresponding functionality or provide instructions, if the
        /// specific functionality is not available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("builtinSimpleAction")]
        public virtual BuiltInSimpleAction BuiltinSimpleAction { get; set; }

        /// <summary>
        /// Action implemented and performed in (your) third-party application. The application needs to show an
        /// additional content and input form to the business as specified for given action. They can trigger the action
        /// only when they provided all required inputs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("builtinUserInputAction")]
        public virtual BuiltInUserInputAction BuiltinUserInputAction { get; set; }

        /// <summary>Label of the action button.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buttonLabel")]
        public virtual string ButtonLabel { get; set; }

        /// <summary>
        /// Action that is implemented and performed outside of (your) third-party application. The application needs to
        /// redirect the business to the external location where they can perform the action.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalAction")]
        public virtual ExternalAction ExternalAction { get; set; }

        /// <summary>
        /// Controlling whether the button is active or disabled. The value is 'false' when the action was already
        /// requested or is not available. If the action is not available then a reason will be present. If (your)
        /// third-party application shows a disabled button for action that is not available, then it should also show
        /// reasons.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isAvailable")]
        public virtual System.Nullable<bool> IsAvailable { get; set; }

        /// <summary>
        /// List of reasons why the action is not available. The list of reasons is empty if the action is available. If
        /// there is only one reason, it can be displayed next to the disabled button. If there are more reasons, all of
        /// them should be displayed, for example in a pop-up dialog.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reasons")]
        public virtual System.Collections.Generic.IList<Reason> Reasons { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Flow that can be selected for an action. When a business selects a flow, application should open a dialog with
    /// more information and input form.
    /// </summary>
    public class ActionFlow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Label for the button to trigger the action from the action dialog. For example: "Request review"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dialogButtonLabel")]
        public virtual string DialogButtonLabel { get; set; }

        /// <summary>
        /// Important message to be highlighted in the request dialog. For example: "You can only request a review for
        /// disagreeing with this issue once. If it's not approved, you'll need to fix the issue and wait a few days
        /// before you can request another review."
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dialogCallout")]
        public virtual Callout DialogCallout { get; set; }

        /// <summary>
        /// Message displayed in the request dialog. For example: "Make sure you've fixed all your country-specific
        /// issues. If not, you may have to wait 7 days to request another review". There may be an more information to
        /// be shown in a tooltip.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dialogMessage")]
        public virtual TextWithTooltip DialogMessage { get; set; }

        /// <summary>Title of the request dialog. For example: "Before you request a review"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dialogTitle")]
        public virtual string DialogTitle { get; set; }

        /// <summary>Not for display but need to be sent back for the selected action flow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>A list of input fields.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputs")]
        public virtual System.Collections.Generic.IList<InputField> Inputs { get; set; }

        /// <summary>
        /// Text value describing the intent for the action flow. It can be used as an input label if business needs to
        /// pick one of multiple flows. For example: "I disagree with the issue"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Input provided by the business.</summary>
    public class ActionInput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Id of the selected action flow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionFlowId")]
        public virtual string ActionFlowId { get; set; }

        /// <summary>Required. Values for input fields.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputValues")]
        public virtual System.Collections.Generic.IList<InputValue> InputValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Long text from external source.</summary>
    public class AdditionalContent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Long text organized into paragraphs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paragraphs")]
        public virtual System.Collections.Generic.IList<string> Paragraphs { get; set; }

        /// <summary>Title of the additional content;</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Aggregate product statuses for a given reporting context and country.</summary>
    public class AggregateProductStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The country of the aggregate product statuses. Represented as a [CLDR territory
        /// code](https://github.com/unicode-org/cldr/blob/latest/common/main/en.xml).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("country")]
        public virtual string Country { get; set; }

        /// <summary>The product issues that affect the given reporting context and country.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemLevelIssues")]
        public virtual System.Collections.Generic.IList<ItemLevelIssue> ItemLevelIssues { get; set; }

        /// <summary>
        /// Identifier. The name of the `AggregateProductStatuses` resource. Format:
        /// `accounts/{account}/aggregateProductStatuses/{aggregateProductStatuses}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The reporting context of the aggregate product statuses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportingContext")]
        public virtual string ReportingContext { get; set; }

        /// <summary>Products statistics for the given reporting context and country.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stats")]
        public virtual Stats Stats { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A detailed impact breakdown for a group of regions where the impact of the issue on different shopping
    /// destinations is the same.
    /// </summary>
    public class Breakdown : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Human readable, localized description of issue's effect on different targets. Should be rendered as a list.
        /// For example: * "Products not showing in ads" * "Products not showing organically"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<string> Details { get; set; }

        /// <summary>
        /// Lists of regions. Should be rendered as a title for this group of details. The full list should be shown to
        /// the business. If the list is too long, it is recommended to make it expandable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regions")]
        public virtual System.Collections.Generic.IList<Region> Regions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Action that is implemented and performed in (your) third-party application. Represents various functionality
    /// that is expected to be available to business and will help them with resolving the issue. The application should
    /// point the business to the place, where they can access the corresponding functionality. If the functionality is
    /// not supported, it is recommended to explain the situation to the business and provide them with instructions how
    /// to solve the issue.
    /// </summary>
    public class BuiltInSimpleAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Long text from an external source that should be available to the business. Present when the type is
        /// `SHOW_ADDITIONAL_CONTENT`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalContent")]
        public virtual AdditionalContent AdditionalContent { get; set; }

        /// <summary>
        /// The attribute that needs to be updated. Present when the type is `EDIT_ITEM_ATTRIBUTE`. This field contains
        /// a code for attribute, represented in snake_case. You can find a list of product's attributes, with their
        /// codes [here](https://support.google.com/merchants/answer/7052112).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributeCode")]
        public virtual string AttributeCode { get; set; }

        /// <summary>
        /// The type of action that represents a functionality that is expected to be available in third-party
        /// application.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Action that is implemented and performed in (your) third-party application. The application needs to show an
    /// additional content and input form to the business. They can start the action only when they provided all
    /// required inputs. The application will request processing of the action by calling the [triggeraction
    /// method](https://developers.google.com/merchant/api/reference/rest/issueresolution_v1beta/issueresolution/triggeraction).
    /// </summary>
    public class BuiltInUserInputAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Contains the action's context that must be included as part of the TriggerActionPayload.action_context in
        /// TriggerActionRequest.payload to call the `triggeraction` method. The content should be treated as opaque and
        /// must not be modified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionContext")]
        public virtual string ActionContext { get; set; }

        /// <summary>
        /// Actions may provide multiple different flows. Business selects one that fits best to their intent. Selecting
        /// the flow is the first step in user's interaction with the action. It affects what input fields will be
        /// available and required and also how the request will be processed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flows")]
        public virtual System.Collections.Generic.IList<ActionFlow> Flows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An important message that should be highlighted. Usually displayed as a banner.</summary>
    public class Callout : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A full message that needs to be shown to the business.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullMessage")]
        public virtual TextWithTooltip FullMessage { get; set; }

        /// <summary>
        /// Can be used to render messages with different severity in different styles. Snippets off all types contain
        /// important information that should be displayed to the business.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("styleHint")]
        public virtual string StyleHint { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Checkbox input allows the business to provide a boolean value. Corresponds to the [html input
    /// type=checkbox](https://www.w3.org/TR/2012/WD-html-markup-20121025/input.checkbox.html#input.checkbox). If the
    /// business checks the box, the input value for the field is `true`, otherwise it is `false`. This type of input is
    /// often used as a confirmation that the business completed required steps before they are allowed to start the
    /// action. In such a case, the input field is marked as required and the button to trigger the action should stay
    /// disabled until the business checks the box.
    /// </summary>
    public class CheckboxInput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Value for checkbox input field.</summary>
    public class CheckboxInputValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. True if the business checked the box field. False otherwise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<bool> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Choice input allows the business to select one of the offered choices. Some choices may be linked to additional
    /// input fields that should be displayed under or next to the choice option. The value for the additional input
    /// field needs to be provided only when the specific choice is selected by the the business. For example,
    /// additional input field can be hidden or disabled until the business selects the specific choice.
    /// </summary>
    public class ChoiceInput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of choices. Only one option can be selected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual System.Collections.Generic.IList<ChoiceInputOption> Options { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A choice that the business can select.</summary>
    public class ChoiceInputOption : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Input that should be displayed when this option is selected. The additional input will not contain a
        /// `ChoiceInput`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalInput")]
        public virtual InputField AdditionalInput { get; set; }

        /// <summary>Not for display but need to be sent back for the selected choice option.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Short description of the choice option. There may be more information to be shown as a tooltip.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual TextWithTooltip Label { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Value for choice input field.</summary>
    public class ChoiceInputValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Id of the option that was selected by the business.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("choiceInputOptionId")]
        public virtual string ChoiceInputOptionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Action that is implemented and performed outside of the third-party application. It should redirect the business
    /// to the provided URL of an external system where they can perform the action. For example to request a review in
    /// the Merchant Center.
    /// </summary>
    public class ExternalAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of external action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// URL to external system, for example Merchant Center, where the business can perform the action.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Overall impact of the issue.</summary>
    public class Impact : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Detailed impact breakdown. Explains the types of restriction the issue has in different shopping
        /// destinations and territory. If present, it should be rendered to the business. Can be shown as a mouse over
        /// dropdown or a dialog. Each breakdown item represents a group of regions with the same impact details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("breakdowns")]
        public virtual System.Collections.Generic.IList<Breakdown> Breakdowns { get; set; }

        /// <summary>
        /// Optional. Message summarizing the overall impact of the issue. If present, it should be rendered to the
        /// business. For example: "Disapproves 90k offers in 25 countries"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The severity of the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Input field that needs to be available to the business. If the field is marked as required, then a value needs
    /// to be provided for a successful processing of the request.
    /// </summary>
    public class InputField : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Input field to provide a boolean value. Corresponds to the [html input
        /// type=checkbox](https://www.w3.org/TR/2012/WD-html-markup-20121025/input.checkbox.html#input.checkbox).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checkboxInput")]
        public virtual CheckboxInput CheckboxInput { get; set; }

        /// <summary>
        /// Input field to select one of the offered choices. Corresponds to the [html input
        /// type=radio](https://www.w3.org/TR/2012/WD-html-markup-20121025/input.radio.html#input.radio).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("choiceInput")]
        public virtual ChoiceInput ChoiceInput { get; set; }

        /// <summary>Not for display but need to be sent back for the given input field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Input field label. There may be more information to be shown in a tooltip.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual TextWithTooltip Label { get; set; }

        /// <summary>
        /// Whether the field is required. The action button needs to stay disabled till values for all required fields
        /// are provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("required")]
        public virtual System.Nullable<bool> Required { get; set; }

        /// <summary>
        /// Input field to provide text information. Corresponds to the [html input
        /// type=text](https://www.w3.org/TR/2012/WD-html-markup-20121025/input.text.html#input.text) or [html
        /// textarea](https://www.w3.org/TR/2012/WD-html-markup-20121025/textarea.html#textarea).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textInput")]
        public virtual TextInput TextInput { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Input provided by the business for input field.</summary>
    public class InputValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Value for checkbox input field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checkboxInputValue")]
        public virtual CheckboxInputValue CheckboxInputValue { get; set; }

        /// <summary>Value for choice input field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("choiceInputValue")]
        public virtual ChoiceInputValue ChoiceInputValue { get; set; }

        /// <summary>Required. Id of the corresponding input field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputFieldId")]
        public virtual string InputFieldId { get; set; }

        /// <summary>Value for text input field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textInputValue")]
        public virtual TextInputValue TextInputValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The ItemLevelIssue of the product status.</summary>
    public class ItemLevelIssue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The attribute's name, if the issue is caused by a single attribute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attribute")]
        public virtual string Attribute { get; set; }

        /// <summary>The error code of the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>A short issue description in English.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>A detailed issue description in English.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detail")]
        public virtual string Detail { get; set; }

        /// <summary>The URL of a web page to help with resolving this issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentationUri")]
        public virtual string DocumentationUri { get; set; }

        /// <summary>The number of products affected by this issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productCount")]
        public virtual System.Nullable<long> ProductCount { get; set; }

        /// <summary>Whether the issue can be resolved by the merchant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolution")]
        public virtual string Resolution { get; set; }

        /// <summary>How this issue affects serving of the offer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the `ListAggregateProductStatuses` method.</summary>
    public class ListAggregateProductStatusesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The `AggregateProductStatuses` resources for the given account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregateProductStatuses")]
        public virtual System.Collections.Generic.IList<AggregateProductStatus> AggregateProductStatuses { get; set; }

        /// <summary>
        /// A token, which can be sent as `pageToken` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

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

    /// <summary>A single reason why the action is not available.</summary>
    public class Reason : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. An action that needs to be performed to solve the problem represented by this reason. This action
        /// will always be available. Should be rendered as a link or button next to the summarizing message. For
        /// example, the review may be available only once the business configure all required attributes. In such a
        /// situation this action can be a link to the form, where they can fill the missing attribute to unblock the
        /// main action.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual Action Action { get; set; }

        /// <summary>Detailed explanation of the reason. Should be displayed as a hint if present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detail")]
        public virtual string Detail { get; set; }

        /// <summary>
        /// Messages summarizing the reason, why the action is not available. For example: "Review requested on Jan 03.
        /// Review requests can take a few days to complete."
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Region with code and localized name.</summary>
    public class Region : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The [CLDR territory code] (http://www.unicode.org/repos/cldr/tags/latest/common/main/en.xml)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>
        /// The localized name of the region. For region with code='001' the value is 'All countries' or the equivalent
        /// in other languages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response containing an issue resolution content and actions for listed account issues.</summary>
    public class RenderAccountIssuesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of account issues for a given account. This list can be shown with compressed, expandable items. In the
        /// compressed form, the title and impact should be shown for each issue. Once the issue is expanded, the
        /// detailed content and available actions should be rendered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("renderedIssues")]
        public virtual System.Collections.Generic.IList<RenderedIssue> RenderedIssues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The payload for configuring how the content should be rendered.</summary>
    public class RenderIssuesRequestPayload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. How the detailed content should be returned. Default option is to return the content as a
        /// pre-rendered HTML text.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentOption")]
        public virtual string ContentOption { get; set; }

        /// <summary>
        /// Optional. How actions with user input form should be handled. If not provided, actions will be returned as
        /// links that points the business to Merchant Center where they can request the action.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userInputActionOption")]
        public virtual string UserInputActionOption { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response containing an issue resolution content and actions for listed product issues.</summary>
    public class RenderProductIssuesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of issues for a given product. This list can be shown with compressed, expandable items. In the
        /// compressed form, the title and impact should be shown for each issue. Once the issue is expanded, the
        /// detailed content and available actions should be rendered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("renderedIssues")]
        public virtual System.Collections.Generic.IList<RenderedIssue> RenderedIssues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An issue affecting specific business or their product.</summary>
    public class RenderedIssue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of actionable steps that can be executed to solve the issue. An example is requesting a re-review or
        /// providing arguments when business disagrees with the issue. Actions that are supported in (your) third-party
        /// application can be rendered as buttons and should be available to the business when they expand the issue.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actions")]
        public virtual System.Collections.Generic.IList<Action> Actions { get; set; }

        /// <summary>
        /// Clarifies the severity of the issue. The summarizing message, if present, should be shown right under the
        /// title for each issue. It helps business to quickly understand the impact of the issue. The detailed
        /// breakdown helps the business to fully understand the impact of the issue. It can be rendered as dialog that
        /// opens when the business mouse over the summarized impact statement. Issues with different severity can be
        /// styled differently. They may use a different color or icon to signal the difference between `ERROR`,
        /// `WARNING` and `INFO`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("impact")]
        public virtual Impact Impact { get; set; }

        /// <summary>
        /// Details of the issue as a pre-rendered HTML. HTML elements contain CSS classes that can be used to customize
        /// the style of the content. Always sanitize the HTML before embedding it directly to your application. The
        /// sanitizer needs to allow basic HTML tags, such as: `div`, `span`, `p`, `a`, `ul`, `li`, `table`, `tr`, `td`.
        /// For example, you can use [DOMPurify](https://www.npmjs.com/package/dompurify). CSS classes: * `issue-detail`
        /// - top level container for the detail of the issue * `callout-banners` - section of the `issue-detail` with
        /// callout banners * `callout-banner` - single callout banner, inside `callout-banners` * `callout-banner-info`
        /// - callout with important information (default) * `callout-banner-warning` - callout with a warning *
        /// `callout-banner-error` - callout informing about an error (most severe) * `issue-content` - section of the
        /// `issue-detail`, contains multiple `content-element` * `content-element` - content element such as a list,
        /// link or paragraph, inside `issue-content` * `root-causes` - unordered list with items describing root causes
        /// of the issue, inside `issue-content` * `root-causes-intro` - intro text before the `root-causes` list,
        /// inside `issue-content` * `segment` - section of the text, `span` inside paragraph * `segment-attribute` -
        /// section of the text that represents a product attribute, for example 'image\_link' * `segment-literal` -
        /// section of the text that contains a special value, for example '0-1000 kg' * `segment-bold` - section of the
        /// text that should be rendered as bold * `segment-italic` - section of the text that should be rendered as
        /// italic * `tooltip` - used on paragraphs that should be rendered with a tooltip. A section of the text in
        /// such a paragraph will have a class `tooltip-text` and is intended to be shown in a mouse over dialog. If the
        /// style is not used, the `tooltip-text` section would be shown on a new line, after the main part of the text.
        /// * `tooltip-text` - marks a section of the text within a `tooltip`, that is intended to be shown in a mouse
        /// over dialog. * `tooltip-icon` - marks a section of the text within a `tooltip`, that can be replaced with a
        /// tooltip icon, for example '?' or 'i'. By default, this section contains a `br` tag, that is separating the
        /// main text and the tooltip text when the style is not used. * `tooltip-style-question` - the tooltip shows
        /// helpful information, can use the '?' as an icon. * `tooltip-style-info` - the tooltip adds additional
        /// information fitting to the context, can use the 'i' as an icon. * `content-moderation` - marks the paragraph
        /// that explains how the issue was identified. * `new-element` - Present for new elements added to the
        /// pre-rendered content in the future. To make sure that a new content element does not break your style, you
        /// can hide everything with this class.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prerenderedContent")]
        public virtual string PrerenderedContent { get; set; }

        /// <summary>
        /// Pre-rendered HTML that contains a link to the external location where the ODS can be requested and
        /// instructions for how to request it. HTML elements contain CSS classes that can be used to customize the
        /// style of this snippet. Always sanitize the HTML before embedding it directly to your application. The
        /// sanitizer needs to allow basic HTML tags, such as: `div`, `span`, `p`, `a`, `ul`, `li`, `table`, `tr`, `td`.
        /// For example, you can use [DOMPurify](https://www.npmjs.com/package/dompurify). CSS classes: * `ods-section`*
        /// - wrapper around the out-of-court dispute resolution section * `ods-description`* - intro text for the
        /// out-of-court dispute resolution. It may contain multiple segments and a link. * `ods-param`* - wrapper
        /// around the header-value pair for parameters that the business may need to provide during the ODS process. *
        /// `ods-routing-id`* - ods param for the Routing ID. * `ods-reference-id`* - ods param for the Routing ID. *
        /// `ods-param-header`* - header for the ODS parameter * `ods-param-value`* - value of the ODS parameter. This
        /// value should be rendered in a way that it is easy for the user to identify and copy. * `segment` - section
        /// of the text, `span` inside paragraph * `segment-attribute` - section of the text that represents a product
        /// attribute, for example 'image\_link' * `segment-literal` - section of the text that contains a special
        /// value, for example '0-1000 kg' * `segment-bold` - section of the text that should be rendered as bold *
        /// `segment-italic` - section of the text that should be rendered as italic * `tooltip` - used on paragraphs
        /// that should be rendered with a tooltip. A section of the text in such a paragraph will have a class
        /// `tooltip-text` and is intended to be shown in a mouse over dialog. If the style is not used, the
        /// `tooltip-text` section would be shown on a new line, after the main part of the text. * `tooltip-text` -
        /// marks a section of the text within a `tooltip`, that is intended to be shown in a mouse over dialog. *
        /// `tooltip-icon` - marks a section of the text within a `tooltip`, that can be replaced with a tooltip icon,
        /// for example '?' or 'i'. By default, this section contains a `br` tag, that is separating the main text and
        /// the tooltip text when the style is not used. * `tooltip-style-question` - the tooltip shows helpful
        /// information, can use the '?' as an icon. * `tooltip-style-info` - the tooltip adds additional information
        /// fitting to the context, can use the 'i' as an icon.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prerenderedOutOfCourtDisputeSettlement")]
        public virtual string PrerenderedOutOfCourtDisputeSettlement { get; set; }

        /// <summary>Title of the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Products statistics.</summary>
    public class Stats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of products that are active.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeCount")]
        public virtual System.Nullable<long> ActiveCount { get; set; }

        /// <summary>The number of products that are disapproved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disapprovedCount")]
        public virtual System.Nullable<long> DisapprovedCount { get; set; }

        /// <summary>The number of products that are expiring.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expiringCount")]
        public virtual System.Nullable<long> ExpiringCount { get; set; }

        /// <summary>The number of products that are pending.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pendingCount")]
        public virtual System.Nullable<long> PendingCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Text input allows the business to provide a text value.</summary>
    public class TextInput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Additional info regarding the field to be displayed to the business. For example, warning to not include
        /// personal identifiable information. There may be more information to be shown in a tooltip.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalInfo")]
        public virtual TextWithTooltip AdditionalInfo { get; set; }

        /// <summary>
        /// Text to be used as the [aria-label](https://www.w3.org/TR/WCAG20-TECHS/ARIA14.html) for the input.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ariaLabel")]
        public virtual string AriaLabel { get; set; }

        /// <summary>
        /// Information about the required format. If present, it should be shown close to the input field to help the
        /// business to provide a correct value. For example: "VAT numbers should be in a format similar to
        /// SK9999999999"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formatInfo")]
        public virtual string FormatInfo { get; set; }

        /// <summary>Type of the text input</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Value for text input field.</summary>
    public class TextInputValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Text provided by the business.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Block of text that may contain a tooltip with more information.</summary>
    public class TextWithTooltip : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Value of the tooltip as a simple text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("simpleTooltipValue")]
        public virtual string SimpleTooltipValue { get; set; }

        /// <summary>Value of the message as a simple text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("simpleValue")]
        public virtual string SimpleValue { get; set; }

        /// <summary>The suggested type of an icon for tooltip, if a tooltip is present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tooltipIconStyle")]
        public virtual string TooltipIconStyle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The payload for the triggered action.</summary>
    public class TriggerActionPayload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The context from the selected action. The value is obtained from rendered issues and needs to be
        /// sent back to identify the action that is being triggered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionContext")]
        public virtual string ActionContext { get; set; }

        /// <summary>Required. Input provided by the business.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionInput")]
        public virtual ActionInput ActionInput { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response informing about the started action.</summary>
    public class TriggerActionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The message for the business.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
