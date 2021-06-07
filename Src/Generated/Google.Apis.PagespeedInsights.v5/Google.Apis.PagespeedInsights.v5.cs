// Copyright 2021 Google LLC
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

namespace Google.Apis.PagespeedInsights.v5
{
    /// <summary>The PagespeedInsights Service.</summary>
    public class PagespeedInsightsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v5";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public PagespeedInsightsService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public PagespeedInsightsService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Pagespeedapi = new PagespeedapiResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "pagespeedonline";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://pagespeedonline.googleapis.com/";
        #else
            "https://pagespeedonline.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://pagespeedonline.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the PageSpeed Insights API.</summary>
        public class Scope
        {
            /// <summary>Associate you with your personal info on Google</summary>
            public static string Openid = "openid";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the PageSpeed Insights API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Associate you with your personal info on Google</summary>
            public const string Openid = "openid";
        }

        /// <summary>Gets the Pagespeedapi resource.</summary>
        public virtual PagespeedapiResource Pagespeedapi { get; }
    }

    /// <summary>A base abstract class for PagespeedInsights requests.</summary>
    public abstract class PagespeedInsightsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new PagespeedInsightsBaseServiceRequest instance.</summary>
        protected PagespeedInsightsBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes PagespeedInsights parameter list.</summary>
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

    /// <summary>The "pagespeedapi" collection of methods.</summary>
    public class PagespeedapiResource
    {
        private const string Resource = "pagespeedapi";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PagespeedapiResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Runs PageSpeed analysis on the page at the specified URL, and returns PageSpeed scores, a list of
        /// suggestions to make that page faster, and other information.
        /// </summary>
        /// <param name="url">Required. The URL to fetch and analyze</param>
        public virtual RunpagespeedRequest Runpagespeed(string url)
        {
            return new RunpagespeedRequest(service, url);
        }

        /// <summary>
        /// Runs PageSpeed analysis on the page at the specified URL, and returns PageSpeed scores, a list of
        /// suggestions to make that page faster, and other information.
        /// </summary>
        public class RunpagespeedRequest : PagespeedInsightsBaseServiceRequest<Google.Apis.PagespeedInsights.v5.Data.PagespeedApiPagespeedResponseV5>
        {
            /// <summary>Constructs a new Runpagespeed request.</summary>
            public RunpagespeedRequest(Google.Apis.Services.IClientService service, string url) : base(service)
            {
                Url = url;
                InitParameters();
            }

            /// <summary>Required. The URL to fetch and analyze</summary>
            [Google.Apis.Util.RequestParameterAttribute("url", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Url { get; private set; }

            /// <summary>The captcha token passed when filling out a captcha.</summary>
            [Google.Apis.Util.RequestParameterAttribute("captchaToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CaptchaToken { get; set; }

            /// <summary>
            /// A Lighthouse category to run; if none are given, only Performance category will be run
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("category", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<CategoryEnum> Category { get; set; }

            /// <summary>
            /// A Lighthouse category to run; if none are given, only Performance category will be run
            /// </summary>
            public enum CategoryEnum
            {
                /// <summary>Default UNDEFINED category.</summary>
                [Google.Apis.Util.StringValueAttribute("CATEGORY_UNSPECIFIED")]
                CATEGORYUNSPECIFIED = 0,

                /// <summary>
                /// Accessibility (a11y), category pertaining to a website's capacity to be accessible to all users.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("ACCESSIBILITY")]
                ACCESSIBILITY = 1,

                /// <summary>
                /// Best Practices, category pertaining to a website's conformance to web best practice.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("BEST_PRACTICES")]
                BESTPRACTICES = 2,

                /// <summary>Performance, category pertaining to a website's performance.</summary>
                [Google.Apis.Util.StringValueAttribute("PERFORMANCE")]
                PERFORMANCE = 3,

                /// <summary>
                /// Progressive Web App (PWA), category pertaining to a website's ability to be run as a PWA.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("PWA")]
                PWA = 4,

                /// <summary>
                /// Search Engine Optimization (SEO), category pertaining to a website's ability to be indexed by search
                /// engines.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("SEO")]
                SEO = 5,
            }

            /// <summary>The locale used to localize formatted results</summary>
            [Google.Apis.Util.RequestParameterAttribute("locale", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Locale { get; set; }

            /// <summary>The analysis strategy (desktop or mobile) to use, and desktop is the default</summary>
            [Google.Apis.Util.RequestParameterAttribute("strategy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<StrategyEnum> Strategy { get; set; }

            /// <summary>The analysis strategy (desktop or mobile) to use, and desktop is the default</summary>
            public enum StrategyEnum
            {
                /// <summary>UNDEFINED.</summary>
                [Google.Apis.Util.StringValueAttribute("STRATEGY_UNSPECIFIED")]
                STRATEGYUNSPECIFIED = 0,

                /// <summary>Fetch and analyze the URL for desktop browsers.</summary>
                [Google.Apis.Util.StringValueAttribute("DESKTOP")]
                DESKTOP = 1,

                /// <summary>Fetch and analyze the URL for mobile devices.</summary>
                [Google.Apis.Util.StringValueAttribute("MOBILE")]
                MOBILE = 2,
            }

            /// <summary>Campaign name for analytics.</summary>
            [Google.Apis.Util.RequestParameterAttribute("utm_campaign", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UtmCampaign { get; set; }

            /// <summary>Campaign source for analytics.</summary>
            [Google.Apis.Util.RequestParameterAttribute("utm_source", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UtmSource { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "runpagespeed";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "pagespeedonline/v5/runPagespeed";

            /// <summary>Initializes Runpagespeed parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("url", new Google.Apis.Discovery.Parameter
                {
                    Name = "url",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = @"(?i)(url:|origin:)?http(s)?://.*",
                });
                RequestParameters.Add("captchaToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "captchaToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("category", new Google.Apis.Discovery.Parameter
                {
                    Name = "category",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("locale", new Google.Apis.Discovery.Parameter
                {
                    Name = "locale",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = @"[a-zA-Z]+((_|-)[a-zA-Z]+)?",
                });
                RequestParameters.Add("strategy", new Google.Apis.Discovery.Parameter
                {
                    Name = "strategy",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("utm_campaign", new Google.Apis.Discovery.Parameter
                {
                    Name = "utm_campaign",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("utm_source", new Google.Apis.Discovery.Parameter
                {
                    Name = "utm_source",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.PagespeedInsights.v5.Data
{
    /// <summary>A light reference to an audit by id, used to group and weight audits in a given category.</summary>
    public class AuditRefs : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The conventional acronym for the audit/metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acronym")]
        public virtual string Acronym { get; set; }

        /// <summary>The category group that the audit belongs to (optional).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("group")]
        public virtual string Group { get; set; }

        /// <summary>The audit ref id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Any audit IDs closely relevant to this one.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relevantAudits")]
        public virtual System.Collections.Generic.IList<string> RelevantAudits { get; set; }

        /// <summary>The weight this audit's score has on the overall category score.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weight")]
        public virtual System.Nullable<double> Weight { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A proportion of data in the total distribution, bucketed by a min/max percentage. Each bucket's range is bounded
    /// by min &amp;lt;= x &amp;lt; max, In millisecond.
    /// </summary>
    public class Bucket : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Upper bound for a bucket's range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("max")]
        public virtual System.Nullable<int> Max { get; set; }

        /// <summary>Lower bound for a bucket's range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("min")]
        public virtual System.Nullable<int> Min { get; set; }

        /// <summary>The proportion of data in this bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proportion")]
        public virtual System.Nullable<double> Proportion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The categories in a Lighthouse run.</summary>
    public class Categories : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The accessibility category, containing all accessibility related audits.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessibility")]
        public virtual LighthouseCategoryV5 Accessibility { get; set; }

        /// <summary>The best practices category, containing all best practices related audits.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("best-practices")]
        public virtual LighthouseCategoryV5 BestPractices { get; set; }

        /// <summary>The performance category, containing all performance related audits.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("performance")]
        public virtual LighthouseCategoryV5 Performance { get; set; }

        /// <summary>The Progressive-Web-App (PWA) category, containing all pwa related audits.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pwa")]
        public virtual LighthouseCategoryV5 Pwa { get; set; }

        /// <summary>The Search-Engine-Optimization (SEO) category, containing all seo related audits.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seo")]
        public virtual LighthouseCategoryV5 Seo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message containing a category</summary>
    public class CategoryGroupV5 : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The description of what the category is grouping</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The human readable title of the group</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message containing the configuration settings for the Lighthouse run.</summary>
    public class ConfigSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>How Lighthouse was run, e.g. from the Chrome extension or from the npm module.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channel")]
        public virtual string Channel { get; set; }

        /// <summary>
        /// The form factor the emulation should use. This field is deprecated, form_factor should be used instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emulatedFormFactor")]
        public virtual string EmulatedFormFactor { get; set; }

        /// <summary>
        /// How Lighthouse should interpret this run in regards to scoring performance metrics and skipping mobile-only
        /// tests in desktop.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formFactor")]
        public virtual string FormFactor { get; set; }

        /// <summary>The locale setting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locale")]
        public virtual string Locale { get; set; }

        /// <summary>List of categories of audits the run should conduct.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onlyCategories")]
        public virtual object OnlyCategories { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message containing environment configuration for a Lighthouse run.</summary>
    public class Environment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The benchmark index number that indicates rough device class.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("benchmarkIndex")]
        public virtual System.Nullable<double> BenchmarkIndex { get; set; }

        /// <summary>The user agent string of the version of Chrome used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostUserAgent")]
        public virtual string HostUserAgent { get; set; }

        /// <summary>The user agent string that was sent over the network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkUserAgent")]
        public virtual string NetworkUserAgent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message containing the i18n data for the LHR - Version 1.</summary>
    public class I18n : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Internationalized strings that are formatted to the locale in configSettings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rendererFormattedStrings")]
        public virtual RendererFormattedStrings RendererFormattedStrings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An audit's result object in a Lighthouse result.</summary>
    public class LighthouseAuditResultV5 : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The description of the audit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Freeform details section of the audit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IDictionary<string, object> Details { get; set; }

        /// <summary>The value that should be displayed on the UI for this audit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayValue")]
        public virtual string DisplayValue { get; set; }

        /// <summary>An error message from a thrown error inside the audit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>An explanation of the errors in the audit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("explanation")]
        public virtual string Explanation { get; set; }

        /// <summary>The audit's id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The unit of the numeric_value field. Used to format the numeric value for display.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numericUnit")]
        public virtual string NumericUnit { get; set; }

        /// <summary>
        /// A numeric value that has a meaning specific to the audit, e.g. the number of nodes in the DOM or the
        /// timestamp of a specific load event. More information can be found in the audit details, if present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numericValue")]
        public virtual System.Nullable<double> NumericValue { get; set; }

        /// <summary>The score of the audit, can be null.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual object Score { get; set; }

        /// <summary>The enumerated score display mode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scoreDisplayMode")]
        public virtual string ScoreDisplayMode { get; set; }

        /// <summary>The human readable title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>Possible warnings that occurred in the audit, can be null.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warnings")]
        public virtual object Warnings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Lighthouse category.</summary>
    public class LighthouseCategoryV5 : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An array of references to all the audit members of this category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditRefs")]
        public virtual System.Collections.Generic.IList<AuditRefs> AuditRefs { get; set; }

        /// <summary>A more detailed description of the category and its importance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The string identifier of the category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>A description for the manual audits in the category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manualDescription")]
        public virtual string ManualDescription { get; set; }

        /// <summary>
        /// The overall score of the category, the weighted average of all its audits. (The category's score, can be
        /// null.)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual object Score { get; set; }

        /// <summary>The human-friendly name of the category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Lighthouse result object.</summary>
    public class LighthouseResultV5 : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Map of audits in the LHR.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audits")]
        public virtual System.Collections.Generic.IDictionary<string, LighthouseAuditResultV5> Audits { get; set; }

        /// <summary>Map of categories in the LHR.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categories")]
        public virtual Categories Categories { get; set; }

        /// <summary>Map of category groups in the LHR.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryGroups")]
        public virtual System.Collections.Generic.IDictionary<string, CategoryGroupV5> CategoryGroups { get; set; }

        /// <summary>The configuration settings for this LHR.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configSettings")]
        public virtual ConfigSettings ConfigSettings { get; set; }

        /// <summary>Environment settings that were used when making this LHR.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environment")]
        public virtual Environment Environment { get; set; }

        /// <summary>The time that this run was fetched.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fetchTime")]
        public virtual string FetchTime { get; set; }

        /// <summary>The final resolved url that was audited.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finalUrl")]
        public virtual string FinalUrl { get; set; }

        /// <summary>The internationalization strings that are required to render the LHR.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("i18n")]
        public virtual I18n I18n { get; set; }

        /// <summary>The lighthouse version that was used to generate this LHR.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lighthouseVersion")]
        public virtual string LighthouseVersion { get; set; }

        /// <summary>The original requested url.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedUrl")]
        public virtual string RequestedUrl { get; set; }

        /// <summary>List of all run warnings in the LHR. Will always output to at least `[]`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runWarnings")]
        public virtual System.Collections.Generic.IList<object> RunWarnings { get; set; }

        /// <summary>
        /// A top-level error message that, if present, indicates a serious enough problem that this Lighthouse result
        /// may need to be discarded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeError")]
        public virtual RuntimeError RuntimeError { get; set; }

        /// <summary>The Stack Pack advice strings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stackPacks")]
        public virtual System.Collections.Generic.IList<StackPack> StackPacks { get; set; }

        /// <summary>Timing information for this LHR.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timing")]
        public virtual Timing Timing { get; set; }

        /// <summary>The user agent that was used to run this LHR.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userAgent")]
        public virtual string UserAgent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The CrUX loading experience object that contains CrUX data breakdowns.</summary>
    public class PagespeedApiLoadingExperienceV5 : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The url, pattern or origin which the metrics are on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The requested URL, which may differ from the resolved "id".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initial_url")]
        public virtual string InitialUrl { get; set; }

        /// <summary>The map of .</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IDictionary<string, UserPageLoadMetricV5> Metrics { get; set; }

        /// <summary>True if the result is an origin fallback from a page, false otherwise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("origin_fallback")]
        public virtual System.Nullable<bool> OriginFallback { get; set; }

        /// <summary>The human readable speed "category" of the id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overall_category")]
        public virtual string OverallCategory { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Pagespeed API response object.</summary>
    public class PagespeedApiPagespeedResponseV5 : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The UTC timestamp of this analysis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analysisUTCTimestamp")]
        public virtual string AnalysisUTCTimestamp { get; set; }

        /// <summary>The captcha verify result</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("captchaResult")]
        public virtual string CaptchaResult { get; set; }

        /// <summary>Canonicalized and final URL for the document, after following page redirects (if any).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Kind of result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Lighthouse response for the audit url as an object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lighthouseResult")]
        public virtual LighthouseResultV5 LighthouseResult { get; set; }

        /// <summary>Metrics of end users' page loading experience.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loadingExperience")]
        public virtual PagespeedApiLoadingExperienceV5 LoadingExperience { get; set; }

        /// <summary>Metrics of the aggregated page loading experience of the origin</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originLoadingExperience")]
        public virtual PagespeedApiLoadingExperienceV5 OriginLoadingExperience { get; set; }

        /// <summary>The version of PageSpeed used to generate these results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual PagespeedVersion Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Pagespeed Version object.</summary>
    public class PagespeedVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The major version number of PageSpeed used to generate these results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("major")]
        public virtual string Major { get; set; }

        /// <summary>The minor version number of PageSpeed used to generate these results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minor")]
        public virtual string Minor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message holding the formatted strings used in the renderer.</summary>
    public class RendererFormattedStrings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The tooltip text on an expandable chevron icon.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditGroupExpandTooltip")]
        public virtual string AuditGroupExpandTooltip { get; set; }

        /// <summary>
        /// Text link pointing to the Lighthouse scoring calculator. This link immediately follows a sentence stating
        /// the performance score is calculated from the perf metrics.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("calculatorLink")]
        public virtual string CalculatorLink { get; set; }

        /// <summary>The label for the initial request in a critical request chain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crcInitialNavigation")]
        public virtual string CrcInitialNavigation { get; set; }

        /// <summary>The label for values shown in the summary of critical request chains.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crcLongestDurationLabel")]
        public virtual string CrcLongestDurationLabel { get; set; }

        /// <summary>Option in a dropdown menu that copies the Lighthouse JSON object to the system clipboard.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dropdownCopyJSON")]
        public virtual string DropdownCopyJSON { get; set; }

        /// <summary>
        /// Option in a dropdown menu that toggles the themeing of the report between Light(default) and Dark themes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dropdownDarkTheme")]
        public virtual string DropdownDarkTheme { get; set; }

        /// <summary>Option in a dropdown menu that opens a full Lighthouse report in a print dialog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dropdownPrintExpanded")]
        public virtual string DropdownPrintExpanded { get; set; }

        /// <summary>Option in a dropdown menu that opens a small, summary report in a print dialog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dropdownPrintSummary")]
        public virtual string DropdownPrintSummary { get; set; }

        /// <summary>Option in a dropdown menu that saves the current report as a new GitHub Gist.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dropdownSaveGist")]
        public virtual string DropdownSaveGist { get; set; }

        /// <summary>
        /// Option in a dropdown menu that saves the Lighthouse report HTML locally to the system as a '.html' file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dropdownSaveHTML")]
        public virtual string DropdownSaveHTML { get; set; }

        /// <summary>
        /// Option in a dropdown menu that saves the Lighthouse JSON object to the local system as a '.json' file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dropdownSaveJSON")]
        public virtual string DropdownSaveJSON { get; set; }

        /// <summary>
        /// Option in a dropdown menu that opens the current report in the Lighthouse Viewer Application.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dropdownViewer")]
        public virtual string DropdownViewer { get; set; }

        /// <summary>The label shown next to an audit or metric that has had an error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorLabel")]
        public virtual string ErrorLabel { get; set; }

        /// <summary>The error string shown next to an erroring audit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMissingAuditInfo")]
        public virtual string ErrorMissingAuditInfo { get; set; }

        /// <summary>Label for button to create an issue against the Lighthouse GitHub project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("footerIssue")]
        public virtual string FooterIssue { get; set; }

        /// <summary>The title of the lab data performance category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labDataTitle")]
        public virtual string LabDataTitle { get; set; }

        /// <summary>The disclaimer shown under performance explaining that the network can vary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lsPerformanceCategoryDescription")]
        public virtual string LsPerformanceCategoryDescription { get; set; }

        /// <summary>The heading shown above a list of audits that were not computerd in the run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manualAuditsGroupTitle")]
        public virtual string ManualAuditsGroupTitle { get; set; }

        /// <summary>The heading shown above a list of audits that do not apply to a page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notApplicableAuditsGroupTitle")]
        public virtual string NotApplicableAuditsGroupTitle { get; set; }

        /// <summary>The heading for the estimated page load savings opportunity of an audit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("opportunityResourceColumnLabel")]
        public virtual string OpportunityResourceColumnLabel { get; set; }

        /// <summary>The heading for the estimated page load savings of opportunity audits.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("opportunitySavingsColumnLabel")]
        public virtual string OpportunitySavingsColumnLabel { get; set; }

        /// <summary>The heading that is shown above a list of audits that are passing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passedAuditsGroupTitle")]
        public virtual string PassedAuditsGroupTitle { get; set; }

        /// <summary>
        /// Descriptive explanation for emulation setting when emulating a generic desktop form factor, as opposed to a
        /// mobile-device like form factor.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeDesktopEmulation")]
        public virtual string RuntimeDesktopEmulation { get; set; }

        /// <summary>Descriptive explanation for emulation setting when emulating a Nexus 5X mobile device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeMobileEmulation")]
        public virtual string RuntimeMobileEmulation { get; set; }

        /// <summary>Descriptive explanation for emulation setting when no device emulation is set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeNoEmulation")]
        public virtual string RuntimeNoEmulation { get; set; }

        /// <summary>Label for a row in a table that shows the version of the Axe library used</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeSettingsAxeVersion")]
        public virtual string RuntimeSettingsAxeVersion { get; set; }

        /// <summary>
        /// Label for a row in a table that shows the estimated CPU power of the machine running Lighthouse. Example row
        /// values: 532, 1492, 783.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeSettingsBenchmark")]
        public virtual string RuntimeSettingsBenchmark { get; set; }

        /// <summary>
        /// Label for a row in a table that describes the CPU throttling conditions that were used during a Lighthouse
        /// run, if any.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeSettingsCPUThrottling")]
        public virtual string RuntimeSettingsCPUThrottling { get; set; }

        /// <summary>
        /// Label for a row in a table that shows in what tool Lighthouse is being run (e.g. The lighthouse CLI, Chrome
        /// DevTools, Lightrider, WebPageTest, etc).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeSettingsChannel")]
        public virtual string RuntimeSettingsChannel { get; set; }

        /// <summary>
        /// Label for a row in a table that describes the kind of device that was emulated for the Lighthouse run.
        /// Example values for row elements: 'No Emulation', 'Emulated Desktop', etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeSettingsDevice")]
        public virtual string RuntimeSettingsDevice { get; set; }

        /// <summary>
        /// Label for a row in a table that shows the time at which a Lighthouse run was conducted; formatted as a
        /// timestamp, e.g. Jan 1, 1970 12:00 AM UTC.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeSettingsFetchTime")]
        public virtual string RuntimeSettingsFetchTime { get; set; }

        /// <summary>
        /// Label for a row in a table that describes the network throttling conditions that were used during a
        /// Lighthouse run, if any.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeSettingsNetworkThrottling")]
        public virtual string RuntimeSettingsNetworkThrottling { get; set; }

        /// <summary>
        /// Title of the Runtime settings table in a Lighthouse report. Runtime settings are the environment
        /// configurations that a specific report used at auditing time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeSettingsTitle")]
        public virtual string RuntimeSettingsTitle { get; set; }

        /// <summary>
        /// Label for a row in a table that shows the User Agent that was detected on the Host machine that ran
        /// Lighthouse.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeSettingsUA")]
        public virtual string RuntimeSettingsUA { get; set; }

        /// <summary>
        /// Label for a row in a table that shows the User Agent that was used to send out all network requests during
        /// the Lighthouse run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeSettingsUANetwork")]
        public virtual string RuntimeSettingsUANetwork { get; set; }

        /// <summary>Label for a row in a table that shows the URL that was audited during a Lighthouse run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeSettingsUrl")]
        public virtual string RuntimeSettingsUrl { get; set; }

        /// <summary>Descriptive explanation for a runtime setting that is set to an unknown value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeUnknown")]
        public virtual string RuntimeUnknown { get; set; }

        /// <summary>The label that explains the score gauges scale (0-49, 50-89, 90-100).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scorescaleLabel")]
        public virtual string ScorescaleLabel { get; set; }

        /// <summary>
        /// Label preceding a radio control for filtering the list of audits. The radio choices are various performance
        /// metrics (FCP, LCP, TBT), and if chosen, the audits in the report are hidden if they are not relevant to the
        /// selected metric.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("showRelevantAudits")]
        public virtual string ShowRelevantAudits { get; set; }

        /// <summary>The label for the button to show only a few lines of a snippet</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippetCollapseButtonLabel")]
        public virtual string SnippetCollapseButtonLabel { get; set; }

        /// <summary>The label for the button to show all lines of a snippet</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippetExpandButtonLabel")]
        public virtual string SnippetExpandButtonLabel { get; set; }

        /// <summary>This label is for a filter checkbox above a table of items</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thirdPartyResourcesLabel")]
        public virtual string ThirdPartyResourcesLabel { get; set; }

        /// <summary>
        /// Descriptive explanation for environment throttling that was provided by the runtime environment instead of
        /// provided by Lighthouse throttling.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("throttlingProvided")]
        public virtual string ThrottlingProvided { get; set; }

        /// <summary>The label shown preceding important warnings that may have invalidated an entire report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toplevelWarningsMessage")]
        public virtual string ToplevelWarningsMessage { get; set; }

        /// <summary>The disclaimer shown below a performance metric value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("varianceDisclaimer")]
        public virtual string VarianceDisclaimer { get; set; }

        /// <summary>Label for a button that opens the Treemap App</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewTreemapLabel")]
        public virtual string ViewTreemapLabel { get; set; }

        /// <summary>The heading that is shown above a list of audits that have warnings</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warningAuditsGroupTitle")]
        public virtual string WarningAuditsGroupTitle { get; set; }

        /// <summary>The label shown above a bulleted list of warnings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warningHeader")]
        public virtual string WarningHeader { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message containing a runtime error config.</summary>
    public class RuntimeError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The enumerated Lighthouse Error code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>A human readable message explaining the error code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message containing Stack Pack information.</summary>
    public class StackPack : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The stack pack advice strings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("descriptions")]
        public virtual System.Collections.Generic.IDictionary<string, string> Descriptions { get; set; }

        /// <summary>The stack pack icon data uri.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iconDataURL")]
        public virtual string IconDataURL { get; set; }

        /// <summary>The stack pack id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The stack pack title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message containing the performance timing data for the Lighthouse run.</summary>
    public class Timing : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The total duration of Lighthouse's run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("total")]
        public virtual System.Nullable<double> Total { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A CrUX metric object for a single metric and form factor.</summary>
    public class UserPageLoadMetricV5 : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The category of the specific time metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>Metric distributions. Proportions should sum up to 1.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distributions")]
        public virtual System.Collections.Generic.IList<Bucket> Distributions { get; set; }

        /// <summary>Identifies the form factor of the metric being collected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formFactor")]
        public virtual string FormFactor { get; set; }

        /// <summary>The median number of the metric, in millisecond.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("median")]
        public virtual System.Nullable<int> Median { get; set; }

        /// <summary>Identifies the type of the metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricId")]
        public virtual string MetricId { get; set; }

        /// <summary>
        /// We use this field to store certain percentile value for this metric. For v4, this field contains pc50. For
        /// v5, this field contains pc90.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percentile")]
        public virtual System.Nullable<int> Percentile { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
