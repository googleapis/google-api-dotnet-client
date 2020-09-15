// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.FactCheckTools.v1alpha1
{
    /// <summary>The FactCheckTools Service.</summary>
    public class FactCheckToolsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1alpha1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public FactCheckToolsService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public FactCheckToolsService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Claims = new ClaimsResource(this);
            Pages = new PagesResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "factchecktools";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://factchecktools.googleapis.com/";
        #else
            "https://factchecktools.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://factchecktools.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Fact Check Tools API.</summary>
        public class Scope
        {
            /// <summary>View your email address</summary>
            public static string UserinfoEmail = "https://www.googleapis.com/auth/userinfo.email";

        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Fact Check Tools API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View your email address</summary>
            public const string UserinfoEmail = "https://www.googleapis.com/auth/userinfo.email";

        }



        /// <summary>Gets the Claims resource.</summary>
        public virtual ClaimsResource Claims { get; }

        /// <summary>Gets the Pages resource.</summary>
        public virtual PagesResource Pages { get; }
    }

    /// <summary>A base abstract class for FactCheckTools requests.</summary>
    public abstract class FactCheckToolsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new FactCheckToolsBaseServiceRequest instance.</summary>
        protected FactCheckToolsBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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
            Value1,
            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2,
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
            Json,
            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media,
            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto,
        }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string
        /// assigned to a user, but should not exceed 40 characters.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes FactCheckTools parameter list.</summary>
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

    /// <summary>The "claims" collection of methods.</summary>
    public class ClaimsResource
    {
        private const string Resource = "claims";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ClaimsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Search through fact-checked claims.</summary>
        public virtual SearchRequest Search()
        {
            return new SearchRequest(service);
        }

        /// <summary>Search through fact-checked claims.</summary>
        public class SearchRequest : FactCheckToolsBaseServiceRequest<Google.Apis.FactCheckTools.v1alpha1.Data.GoogleFactcheckingFactchecktoolsV1alpha1FactCheckedClaimSearchResponse>
        {
            /// <summary>Constructs a new Search request.</summary>
            public SearchRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }


            /// <summary>The BCP-47 language code, such as "en-US" or "sr-Latn". Can be used to restrict results by
            /// language, though we do not currently consider the region.</summary>
            [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string LanguageCode { get; set; }

            /// <summary>The maximum age of the returned search results, in days. Age is determined by either claim date
            /// or review date, whichever is newer.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxAgeDays", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxAgeDays { get; set; }

            /// <summary>An integer that specifies the current offset (that is, starting result location) in search
            /// results. This field is only considered if `page_token` is unset. For example, 0 means to return results
            /// starting from the first matching result, and 10 means to return from the 11th result.</summary>
            [Google.Apis.Util.RequestParameterAttribute("offset", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> Offset { get; set; }

            /// <summary>The pagination size. We will return up to that many results. Defaults to 10 if not
            /// set.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>The pagination token. You may provide the `next_page_token` returned from a previous List
            /// request, if any, in order to get the next page. All other fields must have the same values as in the
            /// previous request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Textual query string. Required unless `review_publisher_site_filter` is specified.</summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query { get; set; }

            /// <summary>The review publisher site to filter results by, e.g. nytimes.com.</summary>
            [Google.Apis.Util.RequestParameterAttribute("reviewPublisherSiteFilter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ReviewPublisherSiteFilter { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "search";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha1/claims:search";

            /// <summary>Initializes Search parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("languageCode", new Google.Apis.Discovery.Parameter
                {
                    Name = "languageCode",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxAgeDays", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxAgeDays",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("offset", new Google.Apis.Discovery.Parameter
                {
                    Name = "offset",
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
                RequestParameters.Add("query", new Google.Apis.Discovery.Parameter
                {
                    Name = "query",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("reviewPublisherSiteFilter", new Google.Apis.Discovery.Parameter
                {
                    Name = "reviewPublisherSiteFilter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }
    }

    /// <summary>The "pages" collection of methods.</summary>
    public class PagesResource
    {
        private const string Resource = "pages";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PagesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Create `ClaimReview` markup on a page.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.FactCheckTools.v1alpha1.Data.GoogleFactcheckingFactchecktoolsV1alpha1ClaimReviewMarkupPage body)
        {
            return new CreateRequest(service, body);
        }

        /// <summary>Create `ClaimReview` markup on a page.</summary>
        public class CreateRequest : FactCheckToolsBaseServiceRequest<Google.Apis.FactCheckTools.v1alpha1.Data.GoogleFactcheckingFactchecktoolsV1alpha1ClaimReviewMarkupPage>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.FactCheckTools.v1alpha1.Data.GoogleFactcheckingFactchecktoolsV1alpha1ClaimReviewMarkupPage body) : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.FactCheckTools.v1alpha1.Data.GoogleFactcheckingFactchecktoolsV1alpha1ClaimReviewMarkupPage Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha1/pages";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Delete all `ClaimReview` markup on a page.</summary>
        /// <param name="name">The name of the resource to delete, in the form of `pages/{page_id}`.</param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(service, name);
        }

        /// <summary>Delete all `ClaimReview` markup on a page.</summary>
        public class DeleteRequest : FactCheckToolsBaseServiceRequest<Google.Apis.FactCheckTools.v1alpha1.Data.GoogleProtobufEmpty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }


            /// <summary>The name of the resource to delete, in the form of `pages/{page_id}`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha1/{+name}";

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
                    Pattern = @"^pages/[^/]+$",
                });
            }

        }

        /// <summary>Get all `ClaimReview` markup on a page.</summary>
        /// <param name="name">The name of the resource to get, in the form of `pages/{page_id}`.</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>Get all `ClaimReview` markup on a page.</summary>
        public class GetRequest : FactCheckToolsBaseServiceRequest<Google.Apis.FactCheckTools.v1alpha1.Data.GoogleFactcheckingFactchecktoolsV1alpha1ClaimReviewMarkupPage>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }


            /// <summary>The name of the resource to get, in the form of `pages/{page_id}`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha1/{+name}";

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
                    Pattern = @"^pages/[^/]+$",
                });
            }

        }

        /// <summary>List the `ClaimReview` markup pages for a specific URL or for an organization.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>List the `ClaimReview` markup pages for a specific URL or for an organization.</summary>
        public class ListRequest : FactCheckToolsBaseServiceRequest<Google.Apis.FactCheckTools.v1alpha1.Data.GoogleFactcheckingFactchecktoolsV1alpha1ListClaimReviewMarkupPagesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }


            /// <summary>An integer that specifies the current offset (that is, starting result location) in search
            /// results. This field is only considered if `page_token` is unset, and if the request is not for a
            /// specific URL. For example, 0 means to return results starting from the first matching result, and 10
            /// means to return from the 11th result.</summary>
            [Google.Apis.Util.RequestParameterAttribute("offset", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> Offset { get; set; }

            /// <summary>The organization for which we want to fetch markups for. For instance, "site.com". Cannot be
            /// specified along with an URL.</summary>
            [Google.Apis.Util.RequestParameterAttribute("organization", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Organization { get; set; }

            /// <summary>The pagination size. We will return up to that many results. Defaults to 10 if not set. Has no
            /// effect if a URL is requested.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>The pagination token. You may provide the `next_page_token` returned from a previous List
            /// request, if any, in order to get the next page. All other fields must have the same values as in the
            /// previous request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>The URL from which to get `ClaimReview` markup. There will be at most one result. If markup is
            /// associated with a more canonical version of the URL provided, we will return that URL instead. Cannot be
            /// specified along with an organization.</summary>
            [Google.Apis.Util.RequestParameterAttribute("url", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Url { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha1/pages";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("offset", new Google.Apis.Discovery.Parameter
                {
                    Name = "offset",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("organization", new Google.Apis.Discovery.Parameter
                {
                    Name = "organization",
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
                RequestParameters.Add("url", new Google.Apis.Discovery.Parameter
                {
                    Name = "url",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Update for all `ClaimReview` markup on a page Note that this is a full update. To retain the
        /// existing `ClaimReview` markup on a page, first perform a Get operation, then modify the returned markup, and
        /// finally call Update with the entire `ClaimReview` markup as the body.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">The name of this `ClaimReview` markup page resource, in the form of `pages/{page_id}`. Except for
        /// update requests, this field is output-only and should not be set by the user.</param>
        public virtual UpdateRequest Update(Google.Apis.FactCheckTools.v1alpha1.Data.GoogleFactcheckingFactchecktoolsV1alpha1ClaimReviewMarkupPage body, string name)
        {
            return new UpdateRequest(service, body, name);
        }

        /// <summary>Update for all `ClaimReview` markup on a page Note that this is a full update. To retain the
        /// existing `ClaimReview` markup on a page, first perform a Get operation, then modify the returned markup, and
        /// finally call Update with the entire `ClaimReview` markup as the body.</summary>
        public class UpdateRequest : FactCheckToolsBaseServiceRequest<Google.Apis.FactCheckTools.v1alpha1.Data.GoogleFactcheckingFactchecktoolsV1alpha1ClaimReviewMarkupPage>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.FactCheckTools.v1alpha1.Data.GoogleFactcheckingFactchecktoolsV1alpha1ClaimReviewMarkupPage body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }


            /// <summary>The name of this `ClaimReview` markup page resource, in the form of `pages/{page_id}`. Except
            /// for update requests, this field is output-only and should not be set by the user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.FactCheckTools.v1alpha1.Data.GoogleFactcheckingFactchecktoolsV1alpha1ClaimReviewMarkupPage Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha1/{+name}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^pages/[^/]+$",
                });
            }

        }
    }
}

namespace Google.Apis.FactCheckTools.v1alpha1.Data
{    

    /// <summary>Information about the claim.</summary>
    public class GoogleFactcheckingFactchecktoolsV1alpha1Claim : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The date that the claim was made.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("claimDate")]
        public virtual object ClaimDate { get; set; } 

        /// <summary>One or more reviews of this claim (namely, a fact-checking article).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("claimReview")]
        public virtual System.Collections.Generic.IList<GoogleFactcheckingFactchecktoolsV1alpha1ClaimReview> ClaimReview { get; set; } 

        /// <summary>A person or organization stating the claim. For instance, "John Doe".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("claimant")]
        public virtual string Claimant { get; set; } 

        /// <summary>The claim text. For instance, "Crime has doubled in the last 2 years."</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Information about the claim author.</summary>
    public class GoogleFactcheckingFactchecktoolsV1alpha1ClaimAuthor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Corresponds to `ClaimReview.itemReviewed.author.image`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUrl")]
        public virtual string ImageUrl { get; set; } 

        /// <summary>Corresponds to `ClaimReview.itemReviewed.author.jobTitle`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobTitle")]
        public virtual string JobTitle { get; set; } 

        /// <summary>A person or organization stating the claim. For instance, "John Doe". Corresponds to
        /// `ClaimReview.itemReviewed.author.name`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Corresponds to `ClaimReview.itemReviewed.author.sameAs`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sameAs")]
        public virtual string SameAs { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Information about the claim rating.</summary>
    public class GoogleFactcheckingFactchecktoolsV1alpha1ClaimRating : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>For numeric ratings, the best value possible in the scale from worst to best. Corresponds to
        /// `ClaimReview.reviewRating.bestRating`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bestRating")]
        public virtual System.Nullable<int> BestRating { get; set; } 

        /// <summary>Corresponds to `ClaimReview.reviewRating.image`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUrl")]
        public virtual string ImageUrl { get; set; } 

        /// <summary>Corresponds to `ClaimReview.reviewRating.ratingExplanation`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ratingExplanation")]
        public virtual string RatingExplanation { get; set; } 

        /// <summary>A numeric rating of this claim, in the range worstRating — bestRating inclusive. Corresponds to
        /// `ClaimReview.reviewRating.ratingValue`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ratingValue")]
        public virtual System.Nullable<int> RatingValue { get; set; } 

        /// <summary>The truthfulness rating as a human-readible short word or phrase. Corresponds to
        /// `ClaimReview.reviewRating.alternateName`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textualRating")]
        public virtual string TextualRating { get; set; } 

        /// <summary>For numeric ratings, the worst value possible in the scale from worst to best. Corresponds to
        /// `ClaimReview.reviewRating.worstRating`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("worstRating")]
        public virtual System.Nullable<int> WorstRating { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Information about a claim review.</summary>
    public class GoogleFactcheckingFactchecktoolsV1alpha1ClaimReview : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The language this review was written in. For instance, "en" or "de".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; } 

        /// <summary>The publisher of this claim review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publisher")]
        public virtual GoogleFactcheckingFactchecktoolsV1alpha1Publisher Publisher { get; set; } 

        /// <summary>The date the claim was reviewed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reviewDate")]
        public virtual object ReviewDate { get; set; } 

        /// <summary>Textual rating. For instance, "Mostly false".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textualRating")]
        public virtual string TextualRating { get; set; } 

        /// <summary>The title of this claim review, if it can be determined.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The URL of this claim review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Information about the claim review author.</summary>
    public class GoogleFactcheckingFactchecktoolsV1alpha1ClaimReviewAuthor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Corresponds to `ClaimReview.author.image`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUrl")]
        public virtual string ImageUrl { get; set; } 

        /// <summary>Name of the organization that is publishing the fact check. Corresponds to
        /// `ClaimReview.author.name`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Fields for an individual `ClaimReview` element. Except for sub-messages that group fields together,
    /// each of these fields correspond those in https://schema.org/ClaimReview. We list the precise mapping for each
    /// field.</summary>
    public class GoogleFactcheckingFactchecktoolsV1alpha1ClaimReviewMarkup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of links to works in which this claim appears, aside from the one specified in
        /// `claim_first_appearance`. Corresponds to `ClaimReview.itemReviewed[@type=Claim].appearance.url`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("claimAppearances")]
        public virtual System.Collections.Generic.IList<string> ClaimAppearances { get; set; } 

        /// <summary>Info about the author of this claim.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("claimAuthor")]
        public virtual GoogleFactcheckingFactchecktoolsV1alpha1ClaimAuthor ClaimAuthor { get; set; } 

        /// <summary>The date when the claim was made or entered public discourse. Corresponds to
        /// `ClaimReview.itemReviewed.datePublished`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("claimDate")]
        public virtual string ClaimDate { get; set; } 

        /// <summary>A link to a work in which this claim first appears. Corresponds to
        /// `ClaimReview.itemReviewed[@type=Claim].firstAppearance.url`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("claimFirstAppearance")]
        public virtual string ClaimFirstAppearance { get; set; } 

        /// <summary>The location where this claim was made. Corresponds to `ClaimReview.itemReviewed.name`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("claimLocation")]
        public virtual string ClaimLocation { get; set; } 

        /// <summary>A short summary of the claim being evaluated. Corresponds to `ClaimReview.claimReviewed`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("claimReviewed")]
        public virtual string ClaimReviewed { get; set; } 

        /// <summary>Info about the rating of this claim review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rating")]
        public virtual GoogleFactcheckingFactchecktoolsV1alpha1ClaimRating Rating { get; set; } 

        /// <summary>This field is optional, and will default to the page URL. We provide this field to allow you the
        /// override the default value, but the only permitted override is the page URL plus an optional anchor link
        /// ("page jump"). Corresponds to `ClaimReview.url`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Holds one or more instances of `ClaimReview` markup for a webpage.</summary>
    public class GoogleFactcheckingFactchecktoolsV1alpha1ClaimReviewMarkupPage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Info about the author of this claim review. Similar to the above, semantically these are page-level
        /// fields, and each `ClaimReview` on this page will contain the same values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("claimReviewAuthor")]
        public virtual GoogleFactcheckingFactchecktoolsV1alpha1ClaimReviewAuthor ClaimReviewAuthor { get; set; } 

        /// <summary>A list of individual claim reviews for this page. Each item in the list corresponds to one
        /// `ClaimReview` element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("claimReviewMarkups")]
        public virtual System.Collections.Generic.IList<GoogleFactcheckingFactchecktoolsV1alpha1ClaimReviewMarkup> ClaimReviewMarkups { get; set; } 

        /// <summary>The name of this `ClaimReview` markup page resource, in the form of `pages/{page_id}`. Except for
        /// update requests, this field is output-only and should not be set by the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The URL of the page associated with this `ClaimReview` markup. While every individual `ClaimReview`
        /// has its own URL field, semantically this is a page-level field, and each `ClaimReview` on this page will use
        /// this value unless individually overridden. Corresponds to `ClaimReview.url`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageUrl")]
        public virtual string PageUrl { get; set; } 

        /// <summary>The date when the fact check was published. Similar to the URL, semantically this is a page-level
        /// field, and each `ClaimReview` on this page will contain the same value. Corresponds to
        /// `ClaimReview.datePublished`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishDate")]
        public virtual string PublishDate { get; set; } 

        /// <summary>The version ID for this markup. Except for update requests, this field is output-only and should
        /// not be set by the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionId")]
        public virtual string VersionId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response from searching fact-checked claims.</summary>
    public class GoogleFactcheckingFactchecktoolsV1alpha1FactCheckedClaimSearchResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of claims and all of their associated information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("claims")]
        public virtual System.Collections.Generic.IList<GoogleFactcheckingFactchecktoolsV1alpha1Claim> Claims { get; set; } 

        /// <summary>The next pagination token in the Search response. It should be used as the `page_token` for the
        /// following request. An empty value means no more results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response from listing `ClaimReview` markup.</summary>
    public class GoogleFactcheckingFactchecktoolsV1alpha1ListClaimReviewMarkupPagesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The result list of pages of `ClaimReview` markup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("claimReviewMarkupPages")]
        public virtual System.Collections.Generic.IList<GoogleFactcheckingFactchecktoolsV1alpha1ClaimReviewMarkupPage> ClaimReviewMarkupPages { get; set; } 

        /// <summary>The next pagination token in the Search response. It should be used as the `page_token` for the
        /// following request. An empty value means no more results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Information about the publisher.</summary>
    public class GoogleFactcheckingFactchecktoolsV1alpha1Publisher : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of this publisher. For instance, "Awesome Fact Checks".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Host-level site name, without the protocol or "www" prefix. For instance, "awesomefactchecks.com".
        /// This value of this field is based purely on the claim review URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("site")]
        public virtual string Site { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A
    /// typical example is to use it as the request or the response type of an API method. For instance: service Foo {
    /// rpc Bar(google.protobuf.Empty) returns (google.protobuf.Empty); } The JSON representation for `Empty` is empty
    /// JSON object `{}`.</summary>
    public class GoogleProtobufEmpty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
