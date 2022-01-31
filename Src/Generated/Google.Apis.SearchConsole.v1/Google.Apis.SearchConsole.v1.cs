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

namespace Google.Apis.SearchConsole.v1
{
    /// <summary>The SearchConsole Service.</summary>
    public class SearchConsoleService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public SearchConsoleService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public SearchConsoleService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Searchanalytics = new SearchanalyticsResource(this);
            Sitemaps = new SitemapsResource(this);
            Sites = new SitesResource(this);
            UrlInspection = new UrlInspectionResource(this);
            UrlTestingTools = new UrlTestingToolsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "searchconsole";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://searchconsole.googleapis.com/";
        #else
            "https://searchconsole.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://searchconsole.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Google Search Console API.</summary>
        public class Scope
        {
            /// <summary>View and manage Search Console data for your verified sites</summary>
            public static string Webmasters = "https://www.googleapis.com/auth/webmasters";

            /// <summary>View Search Console data for your verified sites</summary>
            public static string WebmastersReadonly = "https://www.googleapis.com/auth/webmasters.readonly";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Google Search Console API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage Search Console data for your verified sites</summary>
            public const string Webmasters = "https://www.googleapis.com/auth/webmasters";

            /// <summary>View Search Console data for your verified sites</summary>
            public const string WebmastersReadonly = "https://www.googleapis.com/auth/webmasters.readonly";
        }

        /// <summary>Gets the Searchanalytics resource.</summary>
        public virtual SearchanalyticsResource Searchanalytics { get; }

        /// <summary>Gets the Sitemaps resource.</summary>
        public virtual SitemapsResource Sitemaps { get; }

        /// <summary>Gets the Sites resource.</summary>
        public virtual SitesResource Sites { get; }

        /// <summary>Gets the UrlInspection resource.</summary>
        public virtual UrlInspectionResource UrlInspection { get; }

        /// <summary>Gets the UrlTestingTools resource.</summary>
        public virtual UrlTestingToolsResource UrlTestingTools { get; }
    }

    /// <summary>A base abstract class for SearchConsole requests.</summary>
    public abstract class SearchConsoleBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new SearchConsoleBaseServiceRequest instance.</summary>
        protected SearchConsoleBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes SearchConsole parameter list.</summary>
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

    /// <summary>The "searchanalytics" collection of methods.</summary>
    public class SearchanalyticsResource
    {
        private const string Resource = "searchanalytics";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public SearchanalyticsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Query your data with filters and parameters that you define. Returns zero or more rows grouped by the row
        /// keys that you define. You must define a date range of one or more days. When date is one of the group by
        /// values, any days without data are omitted from the result list. If you need to know which days have data,
        /// issue a broad date range query grouped by date for any metric, and see which day rows are returned.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="siteUrl">The site's URL, including protocol. For example: `http://www.example.com/`.</param>
        public virtual QueryRequest Query(Google.Apis.SearchConsole.v1.Data.SearchAnalyticsQueryRequest body, string siteUrl)
        {
            return new QueryRequest(service, body, siteUrl);
        }

        /// <summary>
        /// Query your data with filters and parameters that you define. Returns zero or more rows grouped by the row
        /// keys that you define. You must define a date range of one or more days. When date is one of the group by
        /// values, any days without data are omitted from the result list. If you need to know which days have data,
        /// issue a broad date range query grouped by date for any metric, and see which day rows are returned.
        /// </summary>
        public class QueryRequest : SearchConsoleBaseServiceRequest<Google.Apis.SearchConsole.v1.Data.SearchAnalyticsQueryResponse>
        {
            /// <summary>Constructs a new Query request.</summary>
            public QueryRequest(Google.Apis.Services.IClientService service, Google.Apis.SearchConsole.v1.Data.SearchAnalyticsQueryRequest body, string siteUrl) : base(service)
            {
                SiteUrl = siteUrl;
                Body = body;
                InitParameters();
            }

            /// <summary>The site's URL, including protocol. For example: `http://www.example.com/`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("siteUrl", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SiteUrl { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SearchConsole.v1.Data.SearchAnalyticsQueryRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "query";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "webmasters/v3/sites/{siteUrl}/searchAnalytics/query";

            /// <summary>Initializes Query parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("siteUrl", new Google.Apis.Discovery.Parameter
                {
                    Name = "siteUrl",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "sitemaps" collection of methods.</summary>
    public class SitemapsResource
    {
        private const string Resource = "sitemaps";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public SitemapsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Deletes a sitemap from the Sitemaps report. Does not stop Google from crawling this sitemap or the URLs that
        /// were previously crawled in the deleted sitemap.
        /// </summary>
        /// <param name="siteUrl">The site's URL, including protocol. For example: `http://www.example.com/`.</param>
        /// <param name="feedpath">
        /// The URL of the actual sitemap. For example: `http://www.example.com/sitemap.xml`.
        /// </param>
        public virtual DeleteRequest Delete(string siteUrl, string feedpath)
        {
            return new DeleteRequest(service, siteUrl, feedpath);
        }

        /// <summary>
        /// Deletes a sitemap from the Sitemaps report. Does not stop Google from crawling this sitemap or the URLs that
        /// were previously crawled in the deleted sitemap.
        /// </summary>
        public class DeleteRequest : SearchConsoleBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string siteUrl, string feedpath) : base(service)
            {
                SiteUrl = siteUrl;
                Feedpath = feedpath;
                InitParameters();
            }

            /// <summary>The site's URL, including protocol. For example: `http://www.example.com/`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("siteUrl", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SiteUrl { get; private set; }

            /// <summary>The URL of the actual sitemap. For example: `http://www.example.com/sitemap.xml`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("feedpath", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Feedpath { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "webmasters/v3/sites/{siteUrl}/sitemaps/{feedpath}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("siteUrl", new Google.Apis.Discovery.Parameter
                {
                    Name = "siteUrl",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("feedpath", new Google.Apis.Discovery.Parameter
                {
                    Name = "feedpath",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves information about a specific sitemap.</summary>
        /// <param name="siteUrl">The site's URL, including protocol. For example: `http://www.example.com/`.</param>
        /// <param name="feedpath">
        /// The URL of the actual sitemap. For example: `http://www.example.com/sitemap.xml`.
        /// </param>
        public virtual GetRequest Get(string siteUrl, string feedpath)
        {
            return new GetRequest(service, siteUrl, feedpath);
        }

        /// <summary>Retrieves information about a specific sitemap.</summary>
        public class GetRequest : SearchConsoleBaseServiceRequest<Google.Apis.SearchConsole.v1.Data.WmxSitemap>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string siteUrl, string feedpath) : base(service)
            {
                SiteUrl = siteUrl;
                Feedpath = feedpath;
                InitParameters();
            }

            /// <summary>The site's URL, including protocol. For example: `http://www.example.com/`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("siteUrl", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SiteUrl { get; private set; }

            /// <summary>The URL of the actual sitemap. For example: `http://www.example.com/sitemap.xml`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("feedpath", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Feedpath { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "webmasters/v3/sites/{siteUrl}/sitemaps/{feedpath}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("siteUrl", new Google.Apis.Discovery.Parameter
                {
                    Name = "siteUrl",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("feedpath", new Google.Apis.Discovery.Parameter
                {
                    Name = "feedpath",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        ///  Lists the [sitemaps-entries](/webmaster-tools/v3/sitemaps) submitted for this site, or included in the
        /// sitemap index file (if `sitemapIndex` is specified in the request).
        /// </summary>
        /// <param name="siteUrl">The site's URL, including protocol. For example: `http://www.example.com/`.</param>
        public virtual ListRequest List(string siteUrl)
        {
            return new ListRequest(service, siteUrl);
        }

        /// <summary>
        ///  Lists the [sitemaps-entries](/webmaster-tools/v3/sitemaps) submitted for this site, or included in the
        /// sitemap index file (if `sitemapIndex` is specified in the request).
        /// </summary>
        public class ListRequest : SearchConsoleBaseServiceRequest<Google.Apis.SearchConsole.v1.Data.SitemapsListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string siteUrl) : base(service)
            {
                SiteUrl = siteUrl;
                InitParameters();
            }

            /// <summary>The site's URL, including protocol. For example: `http://www.example.com/`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("siteUrl", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SiteUrl { get; private set; }

            /// <summary>
            ///  A URL of a site's sitemap index. For example: `http://www.example.com/sitemapindex.xml`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("sitemapIndex", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string SitemapIndex { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "webmasters/v3/sites/{siteUrl}/sitemaps";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("siteUrl", new Google.Apis.Discovery.Parameter
                {
                    Name = "siteUrl",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sitemapIndex", new Google.Apis.Discovery.Parameter
                {
                    Name = "sitemapIndex",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Submits a sitemap for a site.</summary>
        /// <param name="siteUrl">The site's URL, including protocol. For example: `http://www.example.com/`.</param>
        /// <param name="feedpath">
        /// The URL of the actual sitemap. For example: `http://www.example.com/sitemap.xml`.
        /// </param>
        public virtual SubmitRequest Submit(string siteUrl, string feedpath)
        {
            return new SubmitRequest(service, siteUrl, feedpath);
        }

        /// <summary>Submits a sitemap for a site.</summary>
        public class SubmitRequest : SearchConsoleBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Submit request.</summary>
            public SubmitRequest(Google.Apis.Services.IClientService service, string siteUrl, string feedpath) : base(service)
            {
                SiteUrl = siteUrl;
                Feedpath = feedpath;
                InitParameters();
            }

            /// <summary>The site's URL, including protocol. For example: `http://www.example.com/`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("siteUrl", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SiteUrl { get; private set; }

            /// <summary>The URL of the actual sitemap. For example: `http://www.example.com/sitemap.xml`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("feedpath", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Feedpath { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "submit";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "webmasters/v3/sites/{siteUrl}/sitemaps/{feedpath}";

            /// <summary>Initializes Submit parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("siteUrl", new Google.Apis.Discovery.Parameter
                {
                    Name = "siteUrl",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("feedpath", new Google.Apis.Discovery.Parameter
                {
                    Name = "feedpath",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

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

        /// <summary> Adds a site to the set of the user's sites in Search Console.</summary>
        /// <param name="siteUrl">The URL of the site to add.</param>
        public virtual AddRequest Add(string siteUrl)
        {
            return new AddRequest(service, siteUrl);
        }

        /// <summary> Adds a site to the set of the user's sites in Search Console.</summary>
        public class AddRequest : SearchConsoleBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Add request.</summary>
            public AddRequest(Google.Apis.Services.IClientService service, string siteUrl) : base(service)
            {
                SiteUrl = siteUrl;
                InitParameters();
            }

            /// <summary>The URL of the site to add.</summary>
            [Google.Apis.Util.RequestParameterAttribute("siteUrl", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SiteUrl { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "add";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "webmasters/v3/sites/{siteUrl}";

            /// <summary>Initializes Add parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("siteUrl", new Google.Apis.Discovery.Parameter
                {
                    Name = "siteUrl",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary> Removes a site from the set of the user's Search Console sites.</summary>
        /// <param name="siteUrl">
        /// The URI of the property as defined in Search Console. **Examples:** `http://www.example.com/` or
        /// `sc-domain:example.com`.
        /// </param>
        public virtual DeleteRequest Delete(string siteUrl)
        {
            return new DeleteRequest(service, siteUrl);
        }

        /// <summary> Removes a site from the set of the user's Search Console sites.</summary>
        public class DeleteRequest : SearchConsoleBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string siteUrl) : base(service)
            {
                SiteUrl = siteUrl;
                InitParameters();
            }

            /// <summary>
            /// The URI of the property as defined in Search Console. **Examples:** `http://www.example.com/` or
            /// `sc-domain:example.com`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("siteUrl", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SiteUrl { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "webmasters/v3/sites/{siteUrl}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("siteUrl", new Google.Apis.Discovery.Parameter
                {
                    Name = "siteUrl",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary> Retrieves information about specific site.</summary>
        /// <param name="siteUrl">
        /// The URI of the property as defined in Search Console. **Examples:** `http://www.example.com/` or
        /// `sc-domain:example.com`.
        /// </param>
        public virtual GetRequest Get(string siteUrl)
        {
            return new GetRequest(service, siteUrl);
        }

        /// <summary> Retrieves information about specific site.</summary>
        public class GetRequest : SearchConsoleBaseServiceRequest<Google.Apis.SearchConsole.v1.Data.WmxSite>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string siteUrl) : base(service)
            {
                SiteUrl = siteUrl;
                InitParameters();
            }

            /// <summary>
            /// The URI of the property as defined in Search Console. **Examples:** `http://www.example.com/` or
            /// `sc-domain:example.com`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("siteUrl", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SiteUrl { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "webmasters/v3/sites/{siteUrl}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("siteUrl", new Google.Apis.Discovery.Parameter
                {
                    Name = "siteUrl",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary> Lists the user's Search Console sites.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary> Lists the user's Search Console sites.</summary>
        public class ListRequest : SearchConsoleBaseServiceRequest<Google.Apis.SearchConsole.v1.Data.SitesListResponse>
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
            public override string RestPath => "webmasters/v3/sites";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "urlInspection" collection of methods.</summary>
    public class UrlInspectionResource
    {
        private const string Resource = "urlInspection";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public UrlInspectionResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Index = new IndexResource(service);
        }

        /// <summary>Gets the Index resource.</summary>
        public virtual IndexResource Index { get; }

        /// <summary>The "index" collection of methods.</summary>
        public class IndexResource
        {
            private const string Resource = "index";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public IndexResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Index inspection.</summary>
            /// <param name="body">The body of the request.</param>
            public virtual InspectRequest Inspect(Google.Apis.SearchConsole.v1.Data.InspectUrlIndexRequest body)
            {
                return new InspectRequest(service, body);
            }

            /// <summary>Index inspection.</summary>
            public class InspectRequest : SearchConsoleBaseServiceRequest<Google.Apis.SearchConsole.v1.Data.InspectUrlIndexResponse>
            {
                /// <summary>Constructs a new Inspect request.</summary>
                public InspectRequest(Google.Apis.Services.IClientService service, Google.Apis.SearchConsole.v1.Data.InspectUrlIndexRequest body) : base(service)
                {
                    Body = body;
                    InitParameters();
                }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SearchConsole.v1.Data.InspectUrlIndexRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "inspect";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/urlInspection/index:inspect";

                /// <summary>Initializes Inspect parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                }
            }
        }
    }

    /// <summary>The "urlTestingTools" collection of methods.</summary>
    public class UrlTestingToolsResource
    {
        private const string Resource = "urlTestingTools";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public UrlTestingToolsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            MobileFriendlyTest = new MobileFriendlyTestResource(service);
        }

        /// <summary>Gets the MobileFriendlyTest resource.</summary>
        public virtual MobileFriendlyTestResource MobileFriendlyTest { get; }

        /// <summary>The "mobileFriendlyTest" collection of methods.</summary>
        public class MobileFriendlyTestResource
        {
            private const string Resource = "mobileFriendlyTest";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public MobileFriendlyTestResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Runs Mobile-Friendly Test for a given URL.</summary>
            /// <param name="body">The body of the request.</param>
            public virtual RunRequest Run(Google.Apis.SearchConsole.v1.Data.RunMobileFriendlyTestRequest body)
            {
                return new RunRequest(service, body);
            }

            /// <summary>Runs Mobile-Friendly Test for a given URL.</summary>
            public class RunRequest : SearchConsoleBaseServiceRequest<Google.Apis.SearchConsole.v1.Data.RunMobileFriendlyTestResponse>
            {
                /// <summary>Constructs a new Run request.</summary>
                public RunRequest(Google.Apis.Services.IClientService service, Google.Apis.SearchConsole.v1.Data.RunMobileFriendlyTestRequest body) : base(service)
                {
                    Body = body;
                    InitParameters();
                }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SearchConsole.v1.Data.RunMobileFriendlyTestRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "run";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/urlTestingTools/mobileFriendlyTest:run";

                /// <summary>Initializes Run parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                }
            }
        }
    }
}
namespace Google.Apis.SearchConsole.v1.Data
{
    /// <summary>
    /// AMP inspection result of the live page or the current information from Google's index, depending on whether you
    /// requested a live inspection or not.
    /// </summary>
    public class AmpInspectionResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Index status of the AMP URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ampIndexStatusVerdict")]
        public virtual string AmpIndexStatusVerdict { get; set; }

        /// <summary>
        /// URL of the AMP that was inspected. If the submitted URL is a desktop page that refers to an AMP version, the
        /// AMP version will be inspected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ampUrl")]
        public virtual string AmpUrl { get; set; }

        /// <summary>Whether or not the page blocks indexing through a noindex rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexingState")]
        public virtual string IndexingState { get; set; }

        /// <summary>A list of zero or more AMP issues found for the inspected URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issues")]
        public virtual System.Collections.Generic.IList<AmpIssue> Issues { get; set; }

        /// <summary>
        /// Last time this AMP version was crawled by Google. Absent if the URL was never crawled successfully.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastCrawlTime")]
        public virtual object LastCrawlTime { get; set; }

        /// <summary>Whether or not Google could fetch the AMP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageFetchState")]
        public virtual string PageFetchState { get; set; }

        /// <summary>Whether or not the page is blocked to Google by a robots.txt rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("robotsTxtState")]
        public virtual string RobotsTxtState { get; set; }

        /// <summary>
        /// The status of the most severe error on the page. If a page has both warnings and errors, the page status is
        /// error. Error status means the page cannot be shown in Search results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verdict")]
        public virtual string Verdict { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>AMP issue.</summary>
    public class AmpIssue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Brief description of this issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issueMessage")]
        public virtual string IssueMessage { get; set; }

        /// <summary>Severity of this issue: WARNING or ERROR.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ApiDataRow : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("clicks")]
        public virtual System.Nullable<double> Clicks { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("ctr")]
        public virtual System.Nullable<double> Ctr { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("impressions")]
        public virtual System.Nullable<double> Impressions { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("keys")]
        public virtual System.Collections.Generic.IList<string> Keys { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("position")]
        public virtual System.Nullable<double> Position { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A filter test to be applied to each row in the data set, where a match can return the row. Filters are string
    /// comparisons, and values and dimension names are not case-sensitive. Individual filters are either AND'ed or
    /// OR'ed within their parent filter group, according to the group's group type. You do not need to group by a
    /// specified dimension to filter against it.
    /// </summary>
    public class ApiDimensionFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("dimension")]
        public virtual string Dimension { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("expression")]
        public virtual string Expression { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("operator")]
        public virtual string Operator__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A set of dimension value filters to test against each row. Only rows that pass all filter groups will be
    /// returned. All results within a filter group are either AND'ed or OR'ed together, depending on the group type
    /// selected. All filter groups are AND'ed together.
    /// </summary>
    public class ApiDimensionFilterGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("filters")]
        public virtual System.Collections.Generic.IList<ApiDimensionFilter> Filters { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("groupType")]
        public virtual string GroupType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Blocked resource.</summary>
    public class BlockedResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>URL of the blocked resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Rich Results items grouped by type.</summary>
    public class DetectedItems : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of Rich Results items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Item> Items { get; set; }

        /// <summary>Rich Results type</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("richResultType")]
        public virtual string RichResultType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describe image data.</summary>
    public class Image : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Image data in format determined by the mime type. Currently, the format will always be "image/png", but this
        /// might change in the future.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>The mime-type of the image data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Results of index status inspection for either the live page or the version in Google's index, depending on
    /// whether you requested a live inspection or not. For more information, see the [Index coverage report
    /// documentation](https://support.google.com/webmasters/answer/7440203).
    /// </summary>
    public class IndexStatusInspectionResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Could Google find and index the page. More details about page indexing appear in 'indexing_state'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("coverageState")]
        public virtual string CoverageState { get; set; }

        /// <summary>Primary crawler that was used by Google to crawl your site.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crawledAs")]
        public virtual string CrawledAs { get; set; }

        /// <summary>
        /// The URL of the page that Google selected as canonical. If the page was not indexed, this field is absent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleCanonical")]
        public virtual string GoogleCanonical { get; set; }

        /// <summary>Whether or not the page blocks indexing through a noindex rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexingState")]
        public virtual string IndexingState { get; set; }

        /// <summary>
        /// Last time this URL was crawled by Google using the [primary
        /// crawler](https://support.google.com/webmasters/answer/7440203#primary_crawler). Absent if the URL was never
        /// crawled successfully.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastCrawlTime")]
        public virtual object LastCrawlTime { get; set; }

        /// <summary>
        /// Whether or not Google could retrieve the page from your server. Equivalent to ["page
        /// fetch"](https://support.google.com/webmasters/answer/9012289#index_coverage) in the URL inspection report.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageFetchState")]
        public virtual string PageFetchState { get; set; }

        /// <summary>URLs that link to the inspected URL, directly and indirectly.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referringUrls")]
        public virtual System.Collections.Generic.IList<string> ReferringUrls { get; set; }

        /// <summary>Whether or not the page is blocked to Google by a robots.txt rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("robotsTxtState")]
        public virtual string RobotsTxtState { get; set; }

        /// <summary>
        /// Any sitemaps that this URL was listed in, as known by Google. Not guaranteed to be an exhaustive list,
        /// especially if Google did not discover this URL through a sitemap. Absent if no sitemaps were found.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sitemap")]
        public virtual System.Collections.Generic.IList<string> Sitemap { get; set; }

        /// <summary>
        /// The URL that your page or site [declares as
        /// canonical](https://developers.google.com/search/docs/advanced/crawling/consolidate-duplicate-urls?#define-canonical).
        /// If you did not declare a canonical URL, this field is absent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userCanonical")]
        public virtual string UserCanonical { get; set; }

        /// <summary>
        /// High level verdict about whether the URL *is* indexed (indexed status), or *can be* indexed (live
        /// inspection).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verdict")]
        public virtual string Verdict { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Index inspection request.</summary>
    public class InspectUrlIndexRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. URL to inspect. Must be under the property specified in "site_url".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inspectionUrl")]
        public virtual string InspectionUrl { get; set; }

        /// <summary>
        /// Optional. An [IETF BCP-47](https://en.wikipedia.org/wiki/IETF_language_tag) language code representing the
        /// requested language for translated issue messages, e.g. "en-US", "or "de-CH". Default value is "en-US".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// Required. The URL of the property as defined in Search Console. **Examples:** `http://www.example.com/` for
        /// a URL-prefix property, or `sc-domain:example.com` for a Domain property.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("siteUrl")]
        public virtual string SiteUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Index-Status inspection response.</summary>
    public class InspectUrlIndexResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>URL inspection results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inspectionResult")]
        public virtual UrlInspectionResult InspectionResult { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A specific rich result found on the page.</summary>
    public class Item : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of zero or more rich result issues found for this instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issues")]
        public virtual System.Collections.Generic.IList<RichResultsIssue> Issues { get; set; }

        /// <summary>The user-provided name of this item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Mobile-friendly issue.</summary>
    public class MobileFriendlyIssue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Rule violated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rule")]
        public virtual string Rule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Mobile-usability inspection results.</summary>
    public class MobileUsabilityInspectionResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of zero or more mobile-usability issues detected for this URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issues")]
        public virtual System.Collections.Generic.IList<MobileUsabilityIssue> Issues { get; set; }

        /// <summary>High-level mobile-usability inspection result for this URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verdict")]
        public virtual string Verdict { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Mobile-usability issue.</summary>
    public class MobileUsabilityIssue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Mobile-usability issue type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issueType")]
        public virtual string IssueType { get; set; }

        /// <summary>Additional information regarding the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>Not returned; reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a resource with issue.</summary>
    public class ResourceIssue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Describes a blocked resource issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockedResource")]
        public virtual BlockedResource BlockedResource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Rich-Results inspection result, including any rich results found at this URL.</summary>
    public class RichResultsInspectionResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of zero or more rich results detected on this page. Rich results that cannot even be parsed due to
        /// syntactic issues will not be listed here.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedItems")]
        public virtual System.Collections.Generic.IList<DetectedItems> DetectedItems { get; set; }

        /// <summary>High-level rich results inspection result for this URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verdict")]
        public virtual string Verdict { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Severity and status of a single issue affecting a single rich result instance on a page.</summary>
    public class RichResultsIssue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Rich Results issue type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issueMessage")]
        public virtual string IssueMessage { get; set; }

        /// <summary>
        /// Severity of this issue: WARNING, or ERROR. Items with an issue of status ERROR cannot appear with rich
        /// result features in Google Search results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Mobile-friendly test request.</summary>
    public class RunMobileFriendlyTestRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether or not screenshot is requested. Default is false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestScreenshot")]
        public virtual System.Nullable<bool> RequestScreenshot { get; set; }

        /// <summary>URL for inspection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Mobile-friendly test response, including mobile-friendly issues and resource issues.</summary>
    public class RunMobileFriendlyTestResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Test verdict, whether the page is mobile friendly or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileFriendliness")]
        public virtual string MobileFriendliness { get; set; }

        /// <summary>List of mobile-usability issues.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileFriendlyIssues")]
        public virtual System.Collections.Generic.IList<MobileFriendlyIssue> MobileFriendlyIssues { get; set; }

        /// <summary>Information about embedded resources issues.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceIssues")]
        public virtual System.Collections.Generic.IList<ResourceIssue> ResourceIssues { get; set; }

        /// <summary>Screenshot of the requested URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenshot")]
        public virtual Image Screenshot { get; set; }

        /// <summary>Final state of the test, can be either complete or an error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testStatus")]
        public virtual TestStatus TestStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SearchAnalyticsQueryRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Optional; Default is \"auto\"] How data is aggregated. If aggregated by property, all data for the same
        /// property is aggregated; if aggregated by page, all data is aggregated by canonical URI. If you filter or
        /// group by page, choose AUTO; otherwise you can aggregate either by property or by page, depending on how you
        /// want your data calculated; see the help documentation to learn how data is calculated differently by site
        /// versus by page. **Note:** If you group or filter by page, you cannot aggregate by property. If you specify
        /// any value other than AUTO, the aggregation type in the result will match the requested type, or if you
        /// request an invalid type, you will get an error. The API will never change your aggregation type if the
        /// requested type is invalid.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregationType")]
        public virtual string AggregationType { get; set; }

        /// <summary>
        /// The data state to be fetched, can be full or all, the latter including full and partial data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataState")]
        public virtual string DataState { get; set; }

        /// <summary>
        /// [Optional] Zero or more filters to apply to the dimension grouping values; for example, 'query contains
        /// \"buy\"' to see only data where the query string contains the substring \"buy\" (not case-sensitive). You
        /// can filter by a dimension without grouping by it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionFilterGroups")]
        public virtual System.Collections.Generic.IList<ApiDimensionFilterGroup> DimensionFilterGroups { get; set; }

        /// <summary>
        /// [Optional] Zero or more dimensions to group results by. Dimensions are the group-by values in the Search
        /// Analytics page. Dimensions are combined to create a unique row key for each row. Results are grouped in the
        /// order that you supply these dimensions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
        public virtual System.Collections.Generic.IList<string> Dimensions { get; set; }

        /// <summary>
        /// [Required] End date of the requested date range, in YYYY-MM-DD format, in PST (UTC - 8:00). Must be greater
        /// than or equal to the start date. This value is included in the range.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual string EndDate { get; set; }

        /// <summary>
        /// [Optional; Default is 1000] The maximum number of rows to return. Must be a number from 1 to 25,000
        /// (inclusive).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowLimit")]
        public virtual System.Nullable<int> RowLimit { get; set; }

        /// <summary>[Optional; Default is \"web\"] The search type to filter for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchType")]
        public virtual string SearchType { get; set; }

        /// <summary>
        ///  [Required] Start date of the requested date range, in YYYY-MM-DD format, in PST time (UTC - 8:00). Must be
        /// less than or equal to the end date. This value is included in the range.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual string StartDate { get; set; }

        /// <summary>
        /// [Optional; Default is 0] Zero-based index of the first row in the response. Must be a non-negative number.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startRow")]
        public virtual System.Nullable<int> StartRow { get; set; }

        /// <summary>
        /// Optional. [Optional; Default is \"web\"] Type of report: search type, or either Discover or Gnews.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A list of rows, one per result, grouped by key. Metrics in each row are aggregated for all data grouped by that
    /// key either by page or property, as specified by the aggregation type parameter.
    /// </summary>
    public class SearchAnalyticsQueryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>How the results were aggregated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseAggregationType")]
        public virtual string ResponseAggregationType { get; set; }

        /// <summary>A list of rows grouped by the key values in the order given in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<ApiDataRow> Rows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List of sitemaps.</summary>
    public class SitemapsListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Contains detailed information about a specific URL submitted as a
        /// [sitemap](https://support.google.com/webmasters/answer/156184).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sitemap")]
        public virtual System.Collections.Generic.IList<WmxSitemap> Sitemap { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List of sites with access level information.</summary>
    public class SitesListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Contains permission level information about a Search Console site. For more information, see [Permissions in
        /// Search Console](https://support.google.com/webmasters/answer/2451999).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("siteEntry")]
        public virtual System.Collections.Generic.IList<WmxSite> SiteEntry { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Final state of the test, including error details if necessary.</summary>
    public class TestStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Error details if applicable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual string Details { get; set; }

        /// <summary>Status of the test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>URL inspection result, including all inspection results.</summary>
    public class UrlInspectionResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Result of the AMP analysis. Absent if the page is not an AMP page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ampResult")]
        public virtual AmpInspectionResult AmpResult { get; set; }

        /// <summary>Result of the index status analysis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexStatusResult")]
        public virtual IndexStatusInspectionResult IndexStatusResult { get; set; }

        /// <summary>Link to Search Console URL inspection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inspectionResultLink")]
        public virtual string InspectionResultLink { get; set; }

        /// <summary>Result of the Mobile usability analysis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileUsabilityResult")]
        public virtual MobileUsabilityInspectionResult MobileUsabilityResult { get; set; }

        /// <summary>Result of the Rich Results analysis. Absent if there are no rich results found.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("richResultsResult")]
        public virtual RichResultsInspectionResult RichResultsResult { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains permission level information about a Search Console site. For more information, see [Permissions in
    /// Search Console](https://support.google.com/webmasters/answer/2451999).
    /// </summary>
    public class WmxSite : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The user's permission level for the site.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissionLevel")]
        public virtual string PermissionLevel { get; set; }

        /// <summary>The URL of the site.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("siteUrl")]
        public virtual string SiteUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains detailed information about a specific URL submitted as a
    /// [sitemap](https://support.google.com/webmasters/answer/156184).
    /// </summary>
    public class WmxSitemap : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The various content types in the sitemap.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contents")]
        public virtual System.Collections.Generic.IList<WmxSitemapContent> Contents { get; set; }

        /// <summary>
        /// Number of errors in the sitemap. These are issues with the sitemap itself that need to be fixed before it
        /// can be processed correctly.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Nullable<long> Errors { get; set; }

        /// <summary>If true, the sitemap has not been processed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isPending")]
        public virtual System.Nullable<bool> IsPending { get; set; }

        /// <summary>If true, the sitemap is a collection of sitemaps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isSitemapsIndex")]
        public virtual System.Nullable<bool> IsSitemapsIndex { get; set; }

        /// <summary>
        /// Date &amp;amp; time in which this sitemap was last downloaded. Date format is in RFC 3339 format
        /// (yyyy-mm-dd).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastDownloaded")]
        public virtual object LastDownloaded { get; set; }

        /// <summary>
        /// Date &amp;amp; time in which this sitemap was submitted. Date format is in RFC 3339 format (yyyy-mm-dd).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastSubmitted")]
        public virtual object LastSubmitted { get; set; }

        /// <summary>The url of the sitemap.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>The type of the sitemap. For example: `rssFeed`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// Number of warnings for the sitemap. These are generally non-critical issues with URLs in the sitemaps.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warnings")]
        public virtual System.Nullable<long> Warnings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the various content types in the sitemap.</summary>
    public class WmxSitemapContent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>*Deprecated; do not use.*</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexed")]
        public virtual System.Nullable<long> Indexed { get; set; }

        /// <summary>The number of URLs in the sitemap (of the content type).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("submitted")]
        public virtual System.Nullable<long> Submitted { get; set; }

        /// <summary>The specific type of content in this sitemap. For example: `web`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
