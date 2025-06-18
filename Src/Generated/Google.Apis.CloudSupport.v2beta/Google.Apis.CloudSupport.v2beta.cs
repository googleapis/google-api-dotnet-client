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

namespace Google.Apis.CloudSupport.v2beta
{
    /// <summary>The CloudSupport Service.</summary>
    public class CloudSupportService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2beta";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudSupportService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudSupportService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            CaseClassifications = new CaseClassificationsResource(this);
            Cases = new CasesResource(this);
            Media = new MediaResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://cloudsupport.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://cloudsupport.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "cloudsupport";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Google Cloud Support API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Google Cloud Support API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the CaseClassifications resource.</summary>
        public virtual CaseClassificationsResource CaseClassifications { get; }

        /// <summary>Gets the Cases resource.</summary>
        public virtual CasesResource Cases { get; }

        /// <summary>Gets the Media resource.</summary>
        public virtual MediaResource Media { get; }
    }

    /// <summary>A base abstract class for CloudSupport requests.</summary>
    public abstract class CloudSupportBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudSupportBaseServiceRequest instance.</summary>
        protected CloudSupportBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CloudSupport parameter list.</summary>
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

    /// <summary>The "caseClassifications" collection of methods.</summary>
    public class CaseClassificationsResource
    {
        private const string Resource = "caseClassifications";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public CaseClassificationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Retrieve valid classifications to use when creating a support case. Classifications are hierarchical. Each
        /// classification is a string containing all levels of the hierarchy separated by `" &amp;gt; "`. For example,
        /// `"Technical Issue &amp;gt; Compute &amp;gt; Compute Engine"`. Classification IDs returned by this endpoint
        /// are valid for at least six months. When a classification is deactivated, this endpoint immediately stops
        /// returning it. After six months, `case.create` requests using the classification will fail. EXAMPLES: cURL:
        /// ```
        /// shell curl \ --header "Authorization: Bearer $(gcloud auth print-access-token)" \
        /// 'https://cloudsupport.googleapis.com/v2/caseClassifications:search?query=display_name:"*Compute%20Engine*"'
        /// ```
        /// Python:
        /// ```
        /// python import googleapiclient.discovery supportApiService = googleapiclient.discovery.build(
        /// serviceName="cloudsupport", version="v2",
        /// discoveryServiceUrl=f"https://cloudsupport.googleapis.com/$discovery/rest?version=v2", ) request =
        /// supportApiService.caseClassifications().search( query='display_name:"*Compute Engine*"' )
        /// print(request.execute())
        /// ```
        /// </summary>
        public virtual SearchRequest Search()
        {
            return new SearchRequest(this.service);
        }

        /// <summary>
        /// Retrieve valid classifications to use when creating a support case. Classifications are hierarchical. Each
        /// classification is a string containing all levels of the hierarchy separated by `" &amp;gt; "`. For example,
        /// `"Technical Issue &amp;gt; Compute &amp;gt; Compute Engine"`. Classification IDs returned by this endpoint
        /// are valid for at least six months. When a classification is deactivated, this endpoint immediately stops
        /// returning it. After six months, `case.create` requests using the classification will fail. EXAMPLES: cURL:
        /// ```
        /// shell curl \ --header "Authorization: Bearer $(gcloud auth print-access-token)" \
        /// 'https://cloudsupport.googleapis.com/v2/caseClassifications:search?query=display_name:"*Compute%20Engine*"'
        /// ```
        /// Python:
        /// ```
        /// python import googleapiclient.discovery supportApiService = googleapiclient.discovery.build(
        /// serviceName="cloudsupport", version="v2",
        /// discoveryServiceUrl=f"https://cloudsupport.googleapis.com/$discovery/rest?version=v2", ) request =
        /// supportApiService.caseClassifications().search( query='display_name:"*Compute Engine*"' )
        /// print(request.execute())
        /// ```
        /// </summary>
        public class SearchRequest : CloudSupportBaseServiceRequest<Google.Apis.CloudSupport.v2beta.Data.SearchCaseClassificationsResponse>
        {
            /// <summary>Constructs a new Search request.</summary>
            public SearchRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>The maximum number of classifications fetched with each request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// A token identifying the page of results to return. If unspecified, the first page is retrieved.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>The product line of the Product.</summary>
            [Google.Apis.Util.RequestParameterAttribute("product.productLine", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProductProductLineEnum> ProductProductLine { get; set; }

            /// <summary>The product line of the Product.</summary>
            public enum ProductProductLineEnum
            {
                /// <summary>Unknown product type.</summary>
                [Google.Apis.Util.StringValueAttribute("PRODUCT_LINE_UNSPECIFIED")]
                PRODUCTLINEUNSPECIFIED = 0,

                /// <summary>Google Cloud</summary>
                [Google.Apis.Util.StringValueAttribute("GOOGLE_CLOUD")]
                GOOGLECLOUD = 1,

                /// <summary>Google Maps</summary>
                [Google.Apis.Util.StringValueAttribute("GOOGLE_MAPS")]
                GOOGLEMAPS = 2,
            }

            /// <summary>
            /// An expression used to filter case classifications. If it's an empty string, then no filtering happens.
            /// Otherwise, case classifications will be returned that match the filter.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "search";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2beta/caseClassifications:search";

            /// <summary>Initializes Search parameter list.</summary>
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
                RequestParameters.Add("product.productLine", new Google.Apis.Discovery.Parameter
                {
                    Name = "product.productLine",
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
            }
        }
    }

    /// <summary>The "cases" collection of methods.</summary>
    public class CasesResource
    {
        private const string Resource = "cases";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public CasesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Attachments = new AttachmentsResource(service);
            Comments = new CommentsResource(service);
        }

        /// <summary>Gets the Attachments resource.</summary>
        public virtual AttachmentsResource Attachments { get; }

        /// <summary>The "attachments" collection of methods.</summary>
        public class AttachmentsResource
        {
            private const string Resource = "attachments";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AttachmentsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// List all the attachments associated with a support case. EXAMPLES: cURL:
            /// ```
            /// shell
            /// case="projects/some-project/cases/23598314" curl \ --header "Authorization: Bearer $(gcloud auth
            /// print-access-token)" \ "https://cloudsupport.googleapis.com/v2/$case/attachments"
            /// ```
            /// Python:
            /// ```
            /// python
            /// import googleapiclient.discovery api_version = "v2" supportApiService = googleapiclient.discovery.build(
            /// serviceName="cloudsupport", version=api_version,
            /// discoveryServiceUrl=f"https://cloudsupport.googleapis.com/$discovery/rest?version={api_version}", )
            /// request = ( supportApiService.cases() .attachments()
            /// .list(parent="projects/some-project/cases/43595344") ) print(request.execute())
            /// ```
            /// </summary>
            /// <param name="parent">Required. The name of the case for which attachments should be listed.</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>
            /// List all the attachments associated with a support case. EXAMPLES: cURL:
            /// ```
            /// shell
            /// case="projects/some-project/cases/23598314" curl \ --header "Authorization: Bearer $(gcloud auth
            /// print-access-token)" \ "https://cloudsupport.googleapis.com/v2/$case/attachments"
            /// ```
            /// Python:
            /// ```
            /// python
            /// import googleapiclient.discovery api_version = "v2" supportApiService = googleapiclient.discovery.build(
            /// serviceName="cloudsupport", version=api_version,
            /// discoveryServiceUrl=f"https://cloudsupport.googleapis.com/$discovery/rest?version={api_version}", )
            /// request = ( supportApiService.cases() .attachments()
            /// .list(parent="projects/some-project/cases/43595344") ) print(request.execute())
            /// ```
            /// </summary>
            public class ListRequest : CloudSupportBaseServiceRequest<Google.Apis.CloudSupport.v2beta.Data.ListAttachmentsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. The name of the case for which attachments should be listed.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of attachments fetched with each request. If not provided, the default is 10. The
                /// maximum page size that will be returned is 100. The size of each page can be smaller than the
                /// requested page size and can include zero. For example, you could request 100 attachments on one
                /// page, receive 0, and then on the next page, receive 90.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A token identifying the page of results to return. If unspecified, the first page is retrieved.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta/{+parent}/attachments";

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
                        Pattern = @"^[^/]+/[^/]+/cases/[^/]+$",
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

        /// <summary>Gets the Comments resource.</summary>
        public virtual CommentsResource Comments { get; }

        /// <summary>The "comments" collection of methods.</summary>
        public class CommentsResource
        {
            private const string Resource = "comments";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public CommentsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Add a new comment to a case. The comment must have the following fields set: `body`. EXAMPLES: cURL:
            /// ```
            /// shell case="projects/some-project/cases/43591344" curl \ --request POST \ --header "Authorization:
            /// Bearer $(gcloud auth print-access-token)" \ --header 'Content-Type: application/json' \ --data '{
            /// "body": "This is a test comment." }' \ "https://cloudsupport.googleapis.com/v2/$case/comments"
            /// ```
            /// Python:
            /// ```
            /// python import googleapiclient.discovery api_version = "v2" supportApiService =
            /// googleapiclient.discovery.build( serviceName="cloudsupport", version=api_version,
            /// discoveryServiceUrl=f"https://cloudsupport.googleapis.com/$discovery/rest?version={api_version}", )
            /// request = ( supportApiService.cases() .comments() .create(
            /// parent="projects/some-project/cases/43595344", body={"body": "This is a test comment."}, ) )
            /// print(request.execute())
            /// ```
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. The name of the case to which the comment should be added.</param>
            public virtual CreateRequest Create(Google.Apis.CloudSupport.v2beta.Data.Comment body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Add a new comment to a case. The comment must have the following fields set: `body`. EXAMPLES: cURL:
            /// ```
            /// shell case="projects/some-project/cases/43591344" curl \ --request POST \ --header "Authorization:
            /// Bearer $(gcloud auth print-access-token)" \ --header 'Content-Type: application/json' \ --data '{
            /// "body": "This is a test comment." }' \ "https://cloudsupport.googleapis.com/v2/$case/comments"
            /// ```
            /// Python:
            /// ```
            /// python import googleapiclient.discovery api_version = "v2" supportApiService =
            /// googleapiclient.discovery.build( serviceName="cloudsupport", version=api_version,
            /// discoveryServiceUrl=f"https://cloudsupport.googleapis.com/$discovery/rest?version={api_version}", )
            /// request = ( supportApiService.cases() .comments() .create(
            /// parent="projects/some-project/cases/43595344", body={"body": "This is a test comment."}, ) )
            /// print(request.execute())
            /// ```
            /// </summary>
            public class CreateRequest : CloudSupportBaseServiceRequest<Google.Apis.CloudSupport.v2beta.Data.Comment>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudSupport.v2beta.Data.Comment body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The name of the case to which the comment should be added.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudSupport.v2beta.Data.Comment Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta/{+parent}/comments";

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
                        Pattern = @"^[^/]+/[^/]+/cases/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// List all the comments associated with a case. EXAMPLES: cURL:
            /// ```
            /// shell
            /// case="projects/some-project/cases/43595344" curl \ --header "Authorization: Bearer $(gcloud auth
            /// print-access-token)" \ "https://cloudsupport.googleapis.com/v2/$case/comments"
            /// ```
            /// Python:
            /// ```
            /// python
            /// import googleapiclient.discovery api_version = "v2" supportApiService = googleapiclient.discovery.build(
            /// serviceName="cloudsupport", version=api_version,
            /// discoveryServiceUrl=f"https://cloudsupport.googleapis.com/$discovery/rest?version={api_version}", )
            /// request = ( supportApiService.cases() .comments() .list(parent="projects/some-project/cases/43595344") )
            /// print(request.execute())
            /// ```
            /// </summary>
            /// <param name="parent">Required. The name of the case for which to list comments.</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>
            /// List all the comments associated with a case. EXAMPLES: cURL:
            /// ```
            /// shell
            /// case="projects/some-project/cases/43595344" curl \ --header "Authorization: Bearer $(gcloud auth
            /// print-access-token)" \ "https://cloudsupport.googleapis.com/v2/$case/comments"
            /// ```
            /// Python:
            /// ```
            /// python
            /// import googleapiclient.discovery api_version = "v2" supportApiService = googleapiclient.discovery.build(
            /// serviceName="cloudsupport", version=api_version,
            /// discoveryServiceUrl=f"https://cloudsupport.googleapis.com/$discovery/rest?version={api_version}", )
            /// request = ( supportApiService.cases() .comments() .list(parent="projects/some-project/cases/43595344") )
            /// print(request.execute())
            /// ```
            /// </summary>
            public class ListRequest : CloudSupportBaseServiceRequest<Google.Apis.CloudSupport.v2beta.Data.ListCommentsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. The name of the case for which to list comments.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>The maximum number of comments to fetch. Defaults to 10.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A token identifying the page of results to return. If unspecified, the first page is returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta/{+parent}/comments";

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
                        Pattern = @"^[^/]+/[^/]+/cases/[^/]+$",
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

        /// <summary>
        /// Close a case. EXAMPLES: cURL:
        /// ```
        /// shell case="projects/some-project/cases/43595344" curl \ --request POST \
        /// --header "Authorization: Bearer $(gcloud auth print-access-token)" \
        /// "https://cloudsupport.googleapis.com/v2/$case:close"
        /// ```
        /// Python:
        /// ```
        /// python import googleapiclient.discovery
        /// api_version = "v2" supportApiService = googleapiclient.discovery.build( serviceName="cloudsupport",
        /// version=api_version,
        /// discoveryServiceUrl=f"https://cloudsupport.googleapis.com/$discovery/rest?version={api_version}", ) request
        /// = supportApiService.cases().close( name="projects/some-project/cases/43595344" ) print(request.execute())
        /// ```
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">Required. The name of the case to close.</param>
        public virtual CloseRequest Close(Google.Apis.CloudSupport.v2beta.Data.CloseCaseRequest body, string name)
        {
            return new CloseRequest(this.service, body, name);
        }

        /// <summary>
        /// Close a case. EXAMPLES: cURL:
        /// ```
        /// shell case="projects/some-project/cases/43595344" curl \ --request POST \
        /// --header "Authorization: Bearer $(gcloud auth print-access-token)" \
        /// "https://cloudsupport.googleapis.com/v2/$case:close"
        /// ```
        /// Python:
        /// ```
        /// python import googleapiclient.discovery
        /// api_version = "v2" supportApiService = googleapiclient.discovery.build( serviceName="cloudsupport",
        /// version=api_version,
        /// discoveryServiceUrl=f"https://cloudsupport.googleapis.com/$discovery/rest?version={api_version}", ) request
        /// = supportApiService.cases().close( name="projects/some-project/cases/43595344" ) print(request.execute())
        /// ```
        /// </summary>
        public class CloseRequest : CloudSupportBaseServiceRequest<Google.Apis.CloudSupport.v2beta.Data.Case>
        {
            /// <summary>Constructs a new Close request.</summary>
            public CloseRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudSupport.v2beta.Data.CloseCaseRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The name of the case to close.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudSupport.v2beta.Data.CloseCaseRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "close";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2beta/{+name}:close";

            /// <summary>Initializes Close parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+/[^/]+/cases/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Create a new case and associate it with a parent. It must have the following fields set: `display_name`,
        /// `description`, `classification`, and `priority`. If you're just testing the API and don't want to route your
        /// case to an agent, set `testCase=true`. EXAMPLES: cURL:
        /// ```
        /// shell parent="projects/some-project" curl \
        /// --request POST \ --header "Authorization: Bearer $(gcloud auth print-access-token)" \ --header
        /// 'Content-Type: application/json' \ --data '{ "display_name": "Test case created by me.", "description": "a
        /// random test case, feel free to close", "classification": { "id":
        /// "100IK2AKCLHMGRJ9CDGMOCGP8DM6UTB4BT262T31BT1M2T31DHNMENPO6KS36CPJ786L2TBFEHGN6NPI64R3CDHN8880G08I1H3MURR7DHII0GRCDTQM8"
        /// }, "time_zone": "-07:00", "subscriber_email_addresses": [ "foo@domain.com", "bar@domain.com" ], "testCase":
        /// true, "priority": "P3" }' \ "https://cloudsupport.googleapis.com/v2/$parent/cases"
        /// ```
        /// Python:
        /// ```
        /// python
        /// import googleapiclient.discovery api_version = "v2" supportApiService = googleapiclient.discovery.build(
        /// serviceName="cloudsupport", version=api_version,
        /// discoveryServiceUrl=f"https://cloudsupport.googleapis.com/$discovery/rest?version={api_version}", ) request
        /// = supportApiService.cases().create( parent="projects/some-project", body={ "displayName": "A Test Case",
        /// "description": "This is a test case.", "testCase": True, "priority": "P2", "classification": { "id":
        /// "100IK2AKCLHMGRJ9CDGMOCGP8DM6UTB4BT262T31BT1M2T31DHNMENPO6KS36CPJ786L2TBFEHGN6NPI64R3CDHN8880G08I1H3MURR7DHII0GRCDTQM8"
        /// }, }, ) print(request.execute())
        /// ```
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">Required. The name of the parent under which the case should be created.</param>
        public virtual CreateRequest Create(Google.Apis.CloudSupport.v2beta.Data.Case body, string parent)
        {
            return new CreateRequest(this.service, body, parent);
        }

        /// <summary>
        /// Create a new case and associate it with a parent. It must have the following fields set: `display_name`,
        /// `description`, `classification`, and `priority`. If you're just testing the API and don't want to route your
        /// case to an agent, set `testCase=true`. EXAMPLES: cURL:
        /// ```
        /// shell parent="projects/some-project" curl \
        /// --request POST \ --header "Authorization: Bearer $(gcloud auth print-access-token)" \ --header
        /// 'Content-Type: application/json' \ --data '{ "display_name": "Test case created by me.", "description": "a
        /// random test case, feel free to close", "classification": { "id":
        /// "100IK2AKCLHMGRJ9CDGMOCGP8DM6UTB4BT262T31BT1M2T31DHNMENPO6KS36CPJ786L2TBFEHGN6NPI64R3CDHN8880G08I1H3MURR7DHII0GRCDTQM8"
        /// }, "time_zone": "-07:00", "subscriber_email_addresses": [ "foo@domain.com", "bar@domain.com" ], "testCase":
        /// true, "priority": "P3" }' \ "https://cloudsupport.googleapis.com/v2/$parent/cases"
        /// ```
        /// Python:
        /// ```
        /// python
        /// import googleapiclient.discovery api_version = "v2" supportApiService = googleapiclient.discovery.build(
        /// serviceName="cloudsupport", version=api_version,
        /// discoveryServiceUrl=f"https://cloudsupport.googleapis.com/$discovery/rest?version={api_version}", ) request
        /// = supportApiService.cases().create( parent="projects/some-project", body={ "displayName": "A Test Case",
        /// "description": "This is a test case.", "testCase": True, "priority": "P2", "classification": { "id":
        /// "100IK2AKCLHMGRJ9CDGMOCGP8DM6UTB4BT262T31BT1M2T31DHNMENPO6KS36CPJ786L2TBFEHGN6NPI64R3CDHN8880G08I1H3MURR7DHII0GRCDTQM8"
        /// }, }, ) print(request.execute())
        /// ```
        /// </summary>
        public class CreateRequest : CloudSupportBaseServiceRequest<Google.Apis.CloudSupport.v2beta.Data.Case>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudSupport.v2beta.Data.Case body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The name of the parent under which the case should be created.</summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudSupport.v2beta.Data.Case Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2beta/{+parent}/cases";

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
                    Pattern = @"^[^/]+/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Escalate a case, starting the Google Cloud Support escalation management process. This operation is only
        /// available for some support services. Go to https://cloud.google.com/support and look for 'Technical support
        /// escalations' in the feature list to find out which ones let you do that. EXAMPLES: cURL:
        /// ```
        /// shell
        /// case="projects/some-project/cases/43595344" curl \ --request POST \ --header "Authorization: Bearer $(gcloud
        /// auth print-access-token)" \ --header "Content-Type: application/json" \ --data '{ "escalation": { "reason":
        /// "BUSINESS_IMPACT", "justification": "This is a test escalation." } }' \
        /// "https://cloudsupport.googleapis.com/v2/$case:escalate"
        /// ```
        /// Python:
        /// ```
        /// python import
        /// googleapiclient.discovery api_version = "v2" supportApiService = googleapiclient.discovery.build(
        /// serviceName="cloudsupport", version=api_version,
        /// discoveryServiceUrl=f"https://cloudsupport.googleapis.com/$discovery/rest?version={api_version}", ) request
        /// = supportApiService.cases().escalate( name="projects/some-project/cases/43595344", body={ "escalation": {
        /// "reason": "BUSINESS_IMPACT", "justification": "This is a test escalation.", }, }, ) print(request.execute())
        /// ```
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">Required. The name of the case to be escalated.</param>
        public virtual EscalateRequest Escalate(Google.Apis.CloudSupport.v2beta.Data.EscalateCaseRequest body, string name)
        {
            return new EscalateRequest(this.service, body, name);
        }

        /// <summary>
        /// Escalate a case, starting the Google Cloud Support escalation management process. This operation is only
        /// available for some support services. Go to https://cloud.google.com/support and look for 'Technical support
        /// escalations' in the feature list to find out which ones let you do that. EXAMPLES: cURL:
        /// ```
        /// shell
        /// case="projects/some-project/cases/43595344" curl \ --request POST \ --header "Authorization: Bearer $(gcloud
        /// auth print-access-token)" \ --header "Content-Type: application/json" \ --data '{ "escalation": { "reason":
        /// "BUSINESS_IMPACT", "justification": "This is a test escalation." } }' \
        /// "https://cloudsupport.googleapis.com/v2/$case:escalate"
        /// ```
        /// Python:
        /// ```
        /// python import
        /// googleapiclient.discovery api_version = "v2" supportApiService = googleapiclient.discovery.build(
        /// serviceName="cloudsupport", version=api_version,
        /// discoveryServiceUrl=f"https://cloudsupport.googleapis.com/$discovery/rest?version={api_version}", ) request
        /// = supportApiService.cases().escalate( name="projects/some-project/cases/43595344", body={ "escalation": {
        /// "reason": "BUSINESS_IMPACT", "justification": "This is a test escalation.", }, }, ) print(request.execute())
        /// ```
        /// </summary>
        public class EscalateRequest : CloudSupportBaseServiceRequest<Google.Apis.CloudSupport.v2beta.Data.Case>
        {
            /// <summary>Constructs a new Escalate request.</summary>
            public EscalateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudSupport.v2beta.Data.EscalateCaseRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The name of the case to be escalated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudSupport.v2beta.Data.EscalateCaseRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "escalate";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2beta/{+name}:escalate";

            /// <summary>Initializes Escalate parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+/[^/]+/cases/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Retrieve a case. EXAMPLES: cURL:
        /// ```
        /// shell case="projects/some-project/cases/16033687" curl \ --header
        /// "Authorization: Bearer $(gcloud auth print-access-token)" \ "https://cloudsupport.googleapis.com/v2/$case"
        /// ```
        /// Python:
        /// ```
        /// python import googleapiclient.discovery api_version = "v2" supportApiService =
        /// googleapiclient.discovery.build( serviceName="cloudsupport", version=api_version,
        /// discoveryServiceUrl=f"https://cloudsupport.googleapis.com/$discovery/rest?version={api_version}", ) request
        /// = supportApiService.cases().get( name="projects/some-project/cases/43595344", ) print(request.execute())
        /// ```
        /// </summary>
        /// <param name="name">Required. The full name of a case to be retrieved.</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(this.service, name);
        }

        /// <summary>
        /// Retrieve a case. EXAMPLES: cURL:
        /// ```
        /// shell case="projects/some-project/cases/16033687" curl \ --header
        /// "Authorization: Bearer $(gcloud auth print-access-token)" \ "https://cloudsupport.googleapis.com/v2/$case"
        /// ```
        /// Python:
        /// ```
        /// python import googleapiclient.discovery api_version = "v2" supportApiService =
        /// googleapiclient.discovery.build( serviceName="cloudsupport", version=api_version,
        /// discoveryServiceUrl=f"https://cloudsupport.googleapis.com/$discovery/rest?version={api_version}", ) request
        /// = supportApiService.cases().get( name="projects/some-project/cases/43595344", ) print(request.execute())
        /// ```
        /// </summary>
        public class GetRequest : CloudSupportBaseServiceRequest<Google.Apis.CloudSupport.v2beta.Data.Case>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. The full name of a case to be retrieved.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2beta/{+name}";

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
                    Pattern = @"^[^/]+/[^/]+/cases/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Retrieve all cases under a parent, but not its children. For example, listing cases under an organization
        /// only returns the cases that are directly parented by that organization. To retrieve cases under an
        /// organization and its projects, use `cases.search`. EXAMPLES: cURL:
        /// ```
        /// shell parent="projects/some-project"
        /// curl \ --header "Authorization: Bearer $(gcloud auth print-access-token)" \
        /// "https://cloudsupport.googleapis.com/v2/$parent/cases"
        /// ```
        /// Python:
        /// ```
        /// python import
        /// googleapiclient.discovery api_version = "v2" supportApiService = googleapiclient.discovery.build(
        /// serviceName="cloudsupport", version=api_version,
        /// discoveryServiceUrl=f"https://cloudsupport.googleapis.com/$discovery/rest?version={api_version}", ) request
        /// = supportApiService.cases().list(parent="projects/some-project") print(request.execute())
        /// ```
        /// </summary>
        /// <param name="parent">Required. The name of a parent to list cases under.</param>
        public virtual ListRequest List(string parent)
        {
            return new ListRequest(this.service, parent);
        }

        /// <summary>
        /// Retrieve all cases under a parent, but not its children. For example, listing cases under an organization
        /// only returns the cases that are directly parented by that organization. To retrieve cases under an
        /// organization and its projects, use `cases.search`. EXAMPLES: cURL:
        /// ```
        /// shell parent="projects/some-project"
        /// curl \ --header "Authorization: Bearer $(gcloud auth print-access-token)" \
        /// "https://cloudsupport.googleapis.com/v2/$parent/cases"
        /// ```
        /// Python:
        /// ```
        /// python import
        /// googleapiclient.discovery api_version = "v2" supportApiService = googleapiclient.discovery.build(
        /// serviceName="cloudsupport", version=api_version,
        /// discoveryServiceUrl=f"https://cloudsupport.googleapis.com/$discovery/rest?version={api_version}", ) request
        /// = supportApiService.cases().list(parent="projects/some-project") print(request.execute())
        /// ```
        /// </summary>
        public class ListRequest : CloudSupportBaseServiceRequest<Google.Apis.CloudSupport.v2beta.Data.ListCasesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
            {
                Parent = parent;
                InitParameters();
            }

            /// <summary>Required. The name of a parent to list cases under.</summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>
            /// An expression used to filter cases. If it's an empty string, then no filtering happens. Otherwise, the
            /// endpoint returns the cases that match the filter. Expressions use the following fields separated by
            /// `AND` and specified with `=`: - `state`: Can be `OPEN` or `CLOSED`. - `priority`: Can be `P0`, `P1`,
            /// `P2`, `P3`, or `P4`. You can specify multiple values for priority using the `OR` operator. For example,
            /// `priority=P1 OR priority=P2`. - `creator.email`: The email address of the case creator. EXAMPLES: -
            /// `state=CLOSED` - `state=OPEN AND creator.email="tester@example.com"` - `state=OPEN AND (priority=P0 OR
            /// priority=P1)`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>The maximum number of cases fetched with each request. Defaults to 10.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// A token identifying the page of results to return. If unspecified, the first page is retrieved.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// The product line to request cases for. If unspecified, only Google Cloud cases will be returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("productLine", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProductLineEnum> ProductLine { get; set; }

            /// <summary>
            /// The product line to request cases for. If unspecified, only Google Cloud cases will be returned.
            /// </summary>
            public enum ProductLineEnum
            {
                /// <summary>Unknown product type.</summary>
                [Google.Apis.Util.StringValueAttribute("PRODUCT_LINE_UNSPECIFIED")]
                PRODUCTLINEUNSPECIFIED = 0,

                /// <summary>Google Cloud</summary>
                [Google.Apis.Util.StringValueAttribute("GOOGLE_CLOUD")]
                GOOGLECLOUD = 1,

                /// <summary>Google Maps</summary>
                [Google.Apis.Util.StringValueAttribute("GOOGLE_MAPS")]
                GOOGLEMAPS = 2,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2beta/{+parent}/cases";

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
                    Pattern = @"^[^/]+/[^/]+$",
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
                RequestParameters.Add("productLine", new Google.Apis.Discovery.Parameter
                {
                    Name = "productLine",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Update a case. Only some fields can be updated. EXAMPLES: cURL:
        /// ```
        /// shell
        /// case="projects/some-project/cases/43595344" curl \ --request PATCH \ --header "Authorization: Bearer
        /// $(gcloud auth print-access-token)" \ --header "Content-Type: application/json" \ --data '{ "priority": "P1"
        /// }' \ "https://cloudsupport.googleapis.com/v2/$case?updateMask=priority"
        /// ```
        /// Python:
        /// ```
        /// python import
        /// googleapiclient.discovery api_version = "v2" supportApiService = googleapiclient.discovery.build(
        /// serviceName="cloudsupport", version=api_version,
        /// discoveryServiceUrl=f"https://cloudsupport.googleapis.com/$discovery/rest?version={api_version}", ) request
        /// = supportApiService.cases().patch( name="projects/some-project/cases/43112854", body={ "displayName": "This
        /// is Now a New Title", "priority": "P2", }, ) print(request.execute())
        /// ```
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">Identifier. The resource name for the case.</param>
        public virtual PatchRequest Patch(Google.Apis.CloudSupport.v2beta.Data.Case body, string name)
        {
            return new PatchRequest(this.service, body, name);
        }

        /// <summary>
        /// Update a case. Only some fields can be updated. EXAMPLES: cURL:
        /// ```
        /// shell
        /// case="projects/some-project/cases/43595344" curl \ --request PATCH \ --header "Authorization: Bearer
        /// $(gcloud auth print-access-token)" \ --header "Content-Type: application/json" \ --data '{ "priority": "P1"
        /// }' \ "https://cloudsupport.googleapis.com/v2/$case?updateMask=priority"
        /// ```
        /// Python:
        /// ```
        /// python import
        /// googleapiclient.discovery api_version = "v2" supportApiService = googleapiclient.discovery.build(
        /// serviceName="cloudsupport", version=api_version,
        /// discoveryServiceUrl=f"https://cloudsupport.googleapis.com/$discovery/rest?version={api_version}", ) request
        /// = supportApiService.cases().patch( name="projects/some-project/cases/43112854", body={ "displayName": "This
        /// is Now a New Title", "priority": "P2", }, ) print(request.execute())
        /// ```
        /// </summary>
        public class PatchRequest : CloudSupportBaseServiceRequest<Google.Apis.CloudSupport.v2beta.Data.Case>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudSupport.v2beta.Data.Case body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>Identifier. The resource name for the case.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// A list of attributes of the case that should be updated. Supported values are `priority`,
            /// `display_name`, and `subscriber_email_addresses`. If no fields are specified, all supported fields are
            /// updated. Be careful - if you do not provide a field mask, then you might accidentally clear some fields.
            /// For example, if you leave the field mask empty and do not provide a value for
            /// `subscriber_email_addresses`, then `subscriber_email_addresses` is updated to empty.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudSupport.v2beta.Data.Case Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2beta/{+name}";

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
                    Pattern = @"^[^/]+/[^/]+/cases/[^/]+$",
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

        /// <summary>
        /// Search for cases using a query. EXAMPLES: cURL:
        /// ```
        /// shell parent="projects/some-project" curl \ --header
        /// "Authorization: Bearer $(gcloud auth print-access-token)" \
        /// "https://cloudsupport.googleapis.com/v2/$parent/cases:search"
        /// ```
        /// Python:
        /// ```
        /// python import
        /// googleapiclient.discovery api_version = "v2" supportApiService = googleapiclient.discovery.build(
        /// serviceName="cloudsupport", version=api_version,
        /// discoveryServiceUrl=f"https://cloudsupport.googleapis.com/$discovery/rest?version={api_version}", ) request
        /// = supportApiService.cases().search( parent="projects/some-project", query="state=OPEN" )
        /// print(request.execute())
        /// ```
        /// </summary>
        public virtual SearchRequest Search()
        {
            return new SearchRequest(this.service);
        }

        /// <summary>
        /// Search for cases using a query. EXAMPLES: cURL:
        /// ```
        /// shell parent="projects/some-project" curl \ --header
        /// "Authorization: Bearer $(gcloud auth print-access-token)" \
        /// "https://cloudsupport.googleapis.com/v2/$parent/cases:search"
        /// ```
        /// Python:
        /// ```
        /// python import
        /// googleapiclient.discovery api_version = "v2" supportApiService = googleapiclient.discovery.build(
        /// serviceName="cloudsupport", version=api_version,
        /// discoveryServiceUrl=f"https://cloudsupport.googleapis.com/$discovery/rest?version={api_version}", ) request
        /// = supportApiService.cases().search( parent="projects/some-project", query="state=OPEN" )
        /// print(request.execute())
        /// ```
        /// </summary>
        public class SearchRequest : CloudSupportBaseServiceRequest<Google.Apis.CloudSupport.v2beta.Data.SearchCasesResponse>
        {
            /// <summary>Constructs a new Search request.</summary>
            public SearchRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>The maximum number of cases fetched with each request. The default page size is 10.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// A token identifying the page of results to return. If unspecified, the first page is retrieved.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>The name of the parent resource to search for cases under.</summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Parent { get; set; }

            /// <summary>
            /// An expression used to filter cases. Expressions use the following fields separated by `AND` and
            /// specified with `=`: - `organization`: An organization name in the form `organizations/`. - `project`: A
            /// project name in the form `projects/`. - `state`: Can be `OPEN` or `CLOSED`. - `priority`: Can be `P0`,
            /// `P1`, `P2`, `P3`, or `P4`. You can specify multiple values for priority using the `OR` operator. For
            /// example, `priority=P1 OR priority=P2`. - `creator.email`: The email address of the case creator. You
            /// must specify either `organization` or `project`. To search across `displayName`, `description`, and
            /// comments, use a global restriction with no keyword or operator. For example, `"my search"`. To search
            /// only cases updated after a certain date, use `update_time` restricted with that particular date, time,
            /// and timezone in ISO datetime format. For example, `update_time&amp;gt;"2020-01-01T00:00:00-05:00"`.
            /// `update_time` only supports the greater than operator (`&amp;gt;`). Examples: -
            /// `organization="organizations/123456789"` - `project="projects/my-project-id"` -
            /// `project="projects/123456789"` - `organization="organizations/123456789" AND state=CLOSED` -
            /// `project="projects/my-project-id" AND creator.email="tester@example.com"` -
            /// `project="projects/my-project-id" AND (priority=P0 OR priority=P1)`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "search";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2beta/cases:search";

            /// <summary>Initializes Search parameter list.</summary>
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
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
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
            }
        }

        /// <summary>Show items in the feed of this case, including case emails, attachments, and comments.</summary>
        /// <param name="parent">Required. The resource name of the case for which feed items should be listed.</param>
        public virtual ShowFeedRequest ShowFeed(string parent)
        {
            return new ShowFeedRequest(this.service, parent);
        }

        /// <summary>Show items in the feed of this case, including case emails, attachments, and comments.</summary>
        public class ShowFeedRequest : CloudSupportBaseServiceRequest<Google.Apis.CloudSupport.v2beta.Data.ShowFeedResponse>
        {
            /// <summary>Constructs a new ShowFeed request.</summary>
            public ShowFeedRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
            {
                Parent = parent;
                InitParameters();
            }

            /// <summary>Required. The resource name of the case for which feed items should be listed.</summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>
            /// Optional. Field to order feed items by, followed by `asc` or `desc` postfix. The only valid field is
            /// `creation_time`. This list is case-insensitive, default sorting order is ascending, and the redundant
            /// space characters are insignificant. Example: `creation_time desc`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>Optional. The maximum number of feed items fetched with each request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. A token identifying the page of results to return. If unspecified, it retrieves the first
            /// page.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "showFeed";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2beta/{+parent}:showFeed";

            /// <summary>Initializes ShowFeed parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+/[^/]+/cases/[^/]+$",
                });
                RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                {
                    Name = "orderBy",
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
        /// Download a file attached to a case. When this endpoint is called, no "response body" will be returned.
        /// Instead, the attachment's blob will be returned. Note: HTTP requests must append "?alt=media" to the URL.
        /// EXAMPLES: cURL:
        /// ```
        /// shell name="projects/some-project/cases/43594844/attachments/0674M00000WijAnZAJ" curl \
        /// --header "Authorization: Bearer $(gcloud auth print-access-token)" \
        /// "https://cloudsupport.googleapis.com/v2/$name:download?alt=media"
        /// ```
        /// Python:
        /// ```
        /// python import
        /// googleapiclient.discovery api_version = "v2" supportApiService = googleapiclient.discovery.build(
        /// serviceName="cloudsupport", version=api_version,
        /// discoveryServiceUrl=f"https://cloudsupport.googleapis.com/$discovery/rest?version={api_version}", ) request
        /// = supportApiService.media().download(
        /// name="projects/some-project/cases/43595344/attachments/0684M00000Pw6pHQAR" ) request.uri =
        /// request.uri.split("?")[0] + "?alt=media" print(request.execute())
        /// ```
        /// </summary>
        /// <param name="name">The name of the file attachment to download.</param>
        public virtual DownloadRequest Download(string name)
        {
            return new DownloadRequest(this.service, name);
        }

        /// <summary>
        /// Download a file attached to a case. When this endpoint is called, no "response body" will be returned.
        /// Instead, the attachment's blob will be returned. Note: HTTP requests must append "?alt=media" to the URL.
        /// EXAMPLES: cURL:
        /// ```
        /// shell name="projects/some-project/cases/43594844/attachments/0674M00000WijAnZAJ" curl \
        /// --header "Authorization: Bearer $(gcloud auth print-access-token)" \
        /// "https://cloudsupport.googleapis.com/v2/$name:download?alt=media"
        /// ```
        /// Python:
        /// ```
        /// python import
        /// googleapiclient.discovery api_version = "v2" supportApiService = googleapiclient.discovery.build(
        /// serviceName="cloudsupport", version=api_version,
        /// discoveryServiceUrl=f"https://cloudsupport.googleapis.com/$discovery/rest?version={api_version}", ) request
        /// = supportApiService.media().download(
        /// name="projects/some-project/cases/43595344/attachments/0684M00000Pw6pHQAR" ) request.uri =
        /// request.uri.split("?")[0] + "?alt=media" print(request.execute())
        /// ```
        /// </summary>
        public class DownloadRequest : CloudSupportBaseServiceRequest<Google.Apis.CloudSupport.v2beta.Data.Media>
        {
            /// <summary>Constructs a new Download request.</summary>
            public DownloadRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                MediaDownloader = new Google.Apis.Download.MediaDownloader(service);
                InitParameters();
            }

            /// <summary>The name of the file attachment to download.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "download";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2beta/{+name}:download";

            /// <summary>Initializes Download parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+/[^/]+/cases/[^/]+/attachments/[^/]+$",
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
        /// Create a file attachment on a case or Cloud resource. The attachment must have the following fields set:
        /// `filename`. EXAMPLES: cURL:
        /// ```
        /// shell echo "This text is in a file I'm uploading using CSAPI." \ &amp;gt;
        /// "./example_file.txt" case="projects/some-project/cases/43594844" curl \ --header "Authorization: Bearer
        /// $(gcloud auth print-access-token)" \ --data-binary @"./example_file.txt" \
        /// "https://cloudsupport.googleapis.com/upload/v2beta/$case/attachments?attachment.filename=uploaded_via_curl.txt"
        /// ```
        /// Python:
        /// ```
        /// python import googleapiclient.discovery api_version = "v2" supportApiService =
        /// googleapiclient.discovery.build( serviceName="cloudsupport", version=api_version,
        /// discoveryServiceUrl=f"https://cloudsupport.googleapis.com/$discovery/rest?version={api_version}", )
        /// file_path = "./example_file.txt" with open(file_path, "w") as file: file.write( "This text is inside a file
        /// I'm going to upload using the Cloud Support API.", ) request = supportApiService.media().upload(
        /// parent="projects/some-project/cases/43595344", media_body=file_path ) request.uri =
        /// request.uri.split("?")[0] + "?attachment.filename=uploaded_via_python.txt" print(request.execute())
        /// ```
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">
        /// Required. The name of the case or Cloud resource to which the attachment should be attached.
        /// </param>
        public virtual UploadRequest Upload(Google.Apis.CloudSupport.v2beta.Data.CreateAttachmentRequest body, string parent)
        {
            return new UploadRequest(this.service, body, parent);
        }

        /// <summary>
        /// Create a file attachment on a case or Cloud resource. The attachment must have the following fields set:
        /// `filename`. EXAMPLES: cURL:
        /// ```
        /// shell echo "This text is in a file I'm uploading using CSAPI." \ &amp;gt;
        /// "./example_file.txt" case="projects/some-project/cases/43594844" curl \ --header "Authorization: Bearer
        /// $(gcloud auth print-access-token)" \ --data-binary @"./example_file.txt" \
        /// "https://cloudsupport.googleapis.com/upload/v2beta/$case/attachments?attachment.filename=uploaded_via_curl.txt"
        /// ```
        /// Python:
        /// ```
        /// python import googleapiclient.discovery api_version = "v2" supportApiService =
        /// googleapiclient.discovery.build( serviceName="cloudsupport", version=api_version,
        /// discoveryServiceUrl=f"https://cloudsupport.googleapis.com/$discovery/rest?version={api_version}", )
        /// file_path = "./example_file.txt" with open(file_path, "w") as file: file.write( "This text is inside a file
        /// I'm going to upload using the Cloud Support API.", ) request = supportApiService.media().upload(
        /// parent="projects/some-project/cases/43595344", media_body=file_path ) request.uri =
        /// request.uri.split("?")[0] + "?attachment.filename=uploaded_via_python.txt" print(request.execute())
        /// ```
        /// </summary>
        public class UploadRequest : CloudSupportBaseServiceRequest<Google.Apis.CloudSupport.v2beta.Data.Attachment>
        {
            /// <summary>Constructs a new Upload request.</summary>
            public UploadRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudSupport.v2beta.Data.CreateAttachmentRequest body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the case or Cloud resource to which the attachment should be attached.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudSupport.v2beta.Data.CreateAttachmentRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "upload";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2beta/{+parent}/attachments";

            /// <summary>Initializes Upload parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+/[^/]+/cases/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Create a file attachment on a case or Cloud resource. The attachment must have the following fields set:
        /// `filename`. EXAMPLES: cURL:
        /// ```
        /// shell echo "This text is in a file I'm uploading using CSAPI." \ &amp;gt;
        /// "./example_file.txt" case="projects/some-project/cases/43594844" curl \ --header "Authorization: Bearer
        /// $(gcloud auth print-access-token)" \ --data-binary @"./example_file.txt" \
        /// "https://cloudsupport.googleapis.com/upload/v2beta/$case/attachments?attachment.filename=uploaded_via_curl.txt"
        /// ```
        /// Python:
        /// ```
        /// python import googleapiclient.discovery api_version = "v2" supportApiService =
        /// googleapiclient.discovery.build( serviceName="cloudsupport", version=api_version,
        /// discoveryServiceUrl=f"https://cloudsupport.googleapis.com/$discovery/rest?version={api_version}", )
        /// file_path = "./example_file.txt" with open(file_path, "w") as file: file.write( "This text is inside a file
        /// I'm going to upload using the Cloud Support API.", ) request = supportApiService.media().upload(
        /// parent="projects/some-project/cases/43595344", media_body=file_path ) request.uri =
        /// request.uri.split("?")[0] + "?attachment.filename=uploaded_via_python.txt" print(request.execute())
        /// ```
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
        /// <param name="parent">
        /// Required. The name of the case or Cloud resource to which the attachment should be attached.
        /// </param>
        /// <param name="stream">The stream to upload. See remarks for further information.</param>
        /// <param name="contentType">The content type of the stream to upload.</param>
        public virtual UploadMediaUpload Upload(Google.Apis.CloudSupport.v2beta.Data.CreateAttachmentRequest body, string parent, System.IO.Stream stream, string contentType)
        {
            return new UploadMediaUpload(service, body, parent, stream, contentType);
        }

        /// <summary>Upload media upload which supports resumable upload.</summary>
        public class UploadMediaUpload : Google.Apis.Upload.ResumableUpload<Google.Apis.CloudSupport.v2beta.Data.CreateAttachmentRequest, Google.Apis.CloudSupport.v2beta.Data.Attachment>
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
            /// Required. The name of the case or Cloud resource to which the attachment should be attached.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

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
            public UploadMediaUpload(Google.Apis.Services.IClientService service, Google.Apis.CloudSupport.v2beta.Data.CreateAttachmentRequest body, string parent, System.IO.Stream stream, string contentType)
                : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "v2beta/{+parent}/attachments"), "POST", stream, contentType)
            {
                Parent = parent;
                Body = body;
            }
        }
    }
}
namespace Google.Apis.CloudSupport.v2beta.Data
{
    /// <summary>
    /// An Actor represents an entity that performed an action. For example, an actor could be a user who posted a
    /// comment on a support case, a user who uploaded an attachment, or a service account that created a support case.
    /// </summary>
    public class Actor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name to display for the actor. If not provided, it is inferred from credentials supplied during case
        /// creation. When an email is provided, a display name must also be provided. This will be obfuscated if the
        /// user is a Google Support agent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The email address of the actor. If not provided, it is inferred from the credentials supplied during case
        /// creation. When a name is provided, an email must also be provided. If the user is a Google Support agent,
        /// this is obfuscated. This field is deprecated. Use `username` instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>Output only. Whether the actor is a Google support actor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleSupport")]
        public virtual System.Nullable<bool> GoogleSupport { get; set; }

        /// <summary>
        /// Output only. The username of the actor. It may look like an email or other format provided by the identity
        /// provider. If not provided, it is inferred from the credentials supplied. When a name is provided, a username
        /// must also be provided. If the user is a Google Support agent, this will not be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An Attachment contains metadata about a file that was uploaded to a case - it is NOT a file itself. That being
    /// said, the name of an Attachment object can be used to download its accompanying file through the
    /// `media.download` endpoint. While attachments can be uploaded in the console at the same time as a comment,
    /// they're associated on a "case" level, not a "comment" level.
    /// </summary>
    public class Attachment : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time at which the attachment was created.</summary>
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

        /// <summary>
        /// Output only. The user who uploaded the attachment. Note, the name and email will be obfuscated if the
        /// attachment was uploaded by Google support.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creator")]
        public virtual Actor Creator { get; set; }

        /// <summary>The filename of the attachment (e.g. `"graph.jpg"`).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filename")]
        public virtual string Filename { get; set; }

        /// <summary>Output only. The MIME type of the attachment (e.g. text/plain).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>Output only. Identifier. The resource name of the attachment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The size of the attachment in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeBytes")]
        public virtual System.Nullable<long> SizeBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary># gdata.* are outside protos with mising documentation</summary>
    public class Blobstore2Info : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobGeneration")]
        public virtual System.Nullable<long> BlobGeneration { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobId")]
        public virtual string BlobId { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downloadReadHandle")]
        public virtual string DownloadReadHandle { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readToken")]
        public virtual string ReadToken { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uploadMetadataContainer")]
        public virtual string UploadMetadataContainer { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Case is an object that contains the details of a support case. It contains fields for the time it was created,
    /// its priority, its classification, and more. Cases can also have comments and attachments that get added over
    /// time. A case is parented by a Google Cloud organization or project. Organizations are identified by a number, so
    /// the name of a case parented by an organization would look like this:
    /// ```
    /// organizations/123/cases/456
    /// ```
    /// Projects have two unique identifiers, an ID and a number, and they look like this:
    /// ```
    /// projects/abc/cases/456
    /// ```
    /// ```
    /// projects/123/cases/456
    /// ```
    /// You can use either of them when calling the API. To learn more about project
    /// identifiers, see [AIP-2510](https://google.aip.dev/cloud/2510).
    /// </summary>
    public class Case : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The issue classification applicable to this case.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classification")]
        public virtual CaseClassification Classification { get; set; }

        /// <summary>
        /// A user-supplied email address to send case update notifications for. This should only be used in BYOID
        /// flows, where we cannot infer the user's email address directly from their EUCs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactEmail")]
        public virtual string ContactEmail { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time this case was created.</summary>
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

        /// <summary>
        /// The user who created the case. Note: The name and email will be obfuscated if the case was created by Google
        /// Support.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creator")]
        public virtual Actor Creator { get; set; }

        /// <summary>A broad description of the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The short summary of the issue reported in this case.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Whether the case is currently escalated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("escalated")]
        public virtual System.Nullable<bool> Escalated { get; set; }

        /// <summary>
        /// The language the user has requested to receive support in. This should be a BCP 47 language code (e.g.,
        /// `"en"`, `"zh-CN"`, `"zh-TW"`, `"ja"`, `"ko"`). If no language or an unsupported language is specified, this
        /// field defaults to English (en). Language selection during case creation may affect your available support
        /// options. For a list of supported languages and their support working hours, see:
        /// https://cloud.google.com/support/docs/language-working-hours
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>Identifier. The resource name for the case.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The priority of this case.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual string Priority { get; set; }

        /// <summary>REMOVED. The severity of this case. Use priority instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>Output only. The current status of the support case.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The email addresses to receive updates on this case.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriberEmailAddresses")]
        public virtual System.Collections.Generic.IList<string> SubscriberEmailAddresses { get; set; }

        /// <summary>
        /// Whether this case was created for internal API testing and should not be acted on by the support team.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testCase")]
        public virtual System.Nullable<bool> TestCase { get; set; }

        /// <summary>
        /// The timezone of the user who created the support case. It should be in a format IANA recognizes:
        /// https://www.iana.org/time-zones. There is no additional validation done by the API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time this case was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual string UpdateTimeRaw
        {
            get => _updateTimeRaw;
            set
            {
                _updateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _updateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdateTimeDateTimeOffset instead.")]
        public virtual object UpdateTime
        {
            get => _updateTime;
            set
            {
                _updateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _updateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Case Classification represents the topic that a case is about. It's very important to use accurate
    /// classifications, because they're used to route your cases to specialists who can help you. A classification
    /// always has an ID that is its unique identifier. A valid ID is required when creating a case.
    /// </summary>
    public class CaseClassification : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A display name for the classification. The display name is not static and can change. To uniquely and
        /// consistently identify classifications, use the `CaseClassification.id` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The unique ID for a classification. Must be specified for case creation. To retrieve valid classification
        /// IDs for case creation, use `caseClassifications.search`. Classification IDs returned by
        /// `caseClassifications.search` are guaranteed to be valid for at least 6 months. If a given classification is
        /// deactiveated, it will immediately stop being returned. After 6 months, `case.create` requests using the
        /// classification ID will fail.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The full product the classification corresponds to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("product")]
        public virtual Product Product { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for the CloseCase endpoint.</summary>
    public class CloseCaseRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A comment associated with a support case. Case comments are the primary way for Google Support to communicate
    /// with a user who has opened a case. When a user responds to Google Support, the user's responses also appear as
    /// comments.
    /// </summary>
    public class Comment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The full comment body. Maximum of 12800 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("body")]
        public virtual string Body { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time when the comment was created.</summary>
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

        /// <summary>Output only. The user or Google Support agent who created the comment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creator")]
        public virtual Actor Creator { get; set; }

        /// <summary>Output only. Identifier. The resource name of the comment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. DEPRECATED. DO NOT USE. A duplicate of the `body` field. This field is only present for legacy
        /// reasons.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plainTextBody")]
        public virtual string PlainTextBody { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary># gdata.* are outside protos with mising documentation</summary>
    public class CompositeMedia : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobRef")]
        public virtual string BlobRef { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobstore2Info")]
        public virtual Blobstore2Info Blobstore2Info { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cosmoBinaryReference")]
        public virtual string CosmoBinaryReference { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crc32cHash")]
        public virtual System.Nullable<long> Crc32cHash { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inline")]
        public virtual string Inline { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("length")]
        public virtual System.Nullable<long> Length { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("md5Hash")]
        public virtual string Md5Hash { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual ObjectId ObjectId { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referenceType")]
        public virtual string ReferenceType { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha1Hash")]
        public virtual string Sha1Hash { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary># gdata.* are outside protos with mising documentation</summary>
    public class ContentTypeInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bestGuess")]
        public virtual string BestGuess { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fromBytes")]
        public virtual string FromBytes { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fromFileName")]
        public virtual string FromFileName { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fromHeader")]
        public virtual string FromHeader { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fromUrlPath")]
        public virtual string FromUrlPath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for the CreateAttachment endpoint.</summary>
    public class CreateAttachmentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The attachment to be created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachment")]
        public virtual Attachment Attachment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary># gdata.* are outside protos with mising documentation</summary>
    public class DiffChecksumsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checksumsLocation")]
        public virtual CompositeMedia ChecksumsLocation { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chunkSizeBytes")]
        public virtual System.Nullable<long> ChunkSizeBytes { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectLocation")]
        public virtual CompositeMedia ObjectLocation { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectSizeBytes")]
        public virtual System.Nullable<long> ObjectSizeBytes { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectVersion")]
        public virtual string ObjectVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary># gdata.* are outside protos with mising documentation</summary>
    public class DiffDownloadResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectLocation")]
        public virtual CompositeMedia ObjectLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary># gdata.* are outside protos with mising documentation</summary>
    public class DiffUploadRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checksumsInfo")]
        public virtual CompositeMedia ChecksumsInfo { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectInfo")]
        public virtual CompositeMedia ObjectInfo { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectVersion")]
        public virtual string ObjectVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary># gdata.* are outside protos with mising documentation</summary>
    public class DiffUploadResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectVersion")]
        public virtual string ObjectVersion { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalObject")]
        public virtual CompositeMedia OriginalObject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary># gdata.* are outside protos with mising documentation</summary>
    public class DiffVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectSizeBytes")]
        public virtual System.Nullable<long> ObjectSizeBytes { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectVersion")]
        public virtual string ObjectVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary># gdata.* are outside protos with mising documentation</summary>
    public class DownloadParameters : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowGzipCompression")]
        public virtual System.Nullable<bool> AllowGzipCompression { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoreRange")]
        public virtual System.Nullable<bool> IgnoreRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An email associated with a support case.</summary>
    public class EmailMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The user or Google Support agent that created this email message. This is inferred from the
        /// headers on the email message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actor")]
        public virtual Actor Actor { get; set; }

        /// <summary>
        /// Output only. The full email message body. A best-effort attempt is made to remove extraneous reply threads.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bodyContent")]
        public virtual TextContent BodyContent { get; set; }

        /// <summary>Output only. Email addresses CCed on the email.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ccEmailAddresses")]
        public virtual System.Collections.Generic.IList<string> CcEmailAddresses { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time when this email message object was created.</summary>
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

        /// <summary>Identifier. Resource name for the email message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Email addresses the email was sent to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recipientEmailAddresses")]
        public virtual System.Collections.Generic.IList<string> RecipientEmailAddresses { get; set; }

        /// <summary>Output only. Subject of the email.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subject")]
        public virtual string Subject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for the EscalateCase endpoint.</summary>
    public class EscalateCaseRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The escalation information to be sent with the escalation request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("escalation")]
        public virtual Escalation Escalation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An escalation of a support case.</summary>
    public class Escalation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A free text description to accompany the `reason` field above. Provides additional context on why
        /// the case is being escalated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("justification")]
        public virtual string Justification { get; set; }

        /// <summary>Required. The reason why the Case is being escalated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A feed item associated with a support case.</summary>
    public class FeedItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. An attachment attached to the case.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachment")]
        public virtual Attachment Attachment { get; set; }

        /// <summary>Output only. A comment added to the case.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("comment")]
        public virtual Comment Comment { get; set; }

        /// <summary>Output only. A deleted attachment that used to be associated with the support case.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletedAttachment")]
        public virtual Attachment DeletedAttachment { get; set; }

        /// <summary>Output only. An email message received in reply to the case.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailMessage")]
        public virtual EmailMessage EmailMessage { get; set; }

        private string _eventTimeRaw;

        private object _eventTime;

        /// <summary>Output only. Time corresponding to the event of this item.</summary>
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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for the ListAttachments endpoint.</summary>
    public class ListAttachmentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of attachments associated with a case.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachments")]
        public virtual System.Collections.Generic.IList<Attachment> Attachments { get; set; }

        /// <summary>
        /// A token to retrieve the next page of results. Set this in the `page_token` field of subsequent
        /// `cases.attachments.list` requests. If unspecified, there are no more results to retrieve.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for the ListCases endpoint.</summary>
    public class ListCasesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of cases associated with the parent after any filters have been applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cases")]
        public virtual System.Collections.Generic.IList<Case> Cases { get; set; }

        /// <summary>
        /// A token to retrieve the next page of results. Set this in the `page_token` field of subsequent `cases.list`
        /// requests. If unspecified, there are no more results to retrieve.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for the ListComments endpoint.</summary>
    public class ListCommentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of the comments associated with the case.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("comments")]
        public virtual System.Collections.Generic.IList<Comment> Comments { get; set; }

        /// <summary>
        /// A token to retrieve the next page of results. Set this in the `page_token` field of subsequent
        /// `cases.comments.list` requests. If unspecified, there are no more results to retrieve.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary># gdata.* are outside protos with mising documentation</summary>
    public class Media : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("algorithm")]
        public virtual string Algorithm { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigstoreObjectRef")]
        public virtual string BigstoreObjectRef { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobRef")]
        public virtual string BlobRef { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobstore2Info")]
        public virtual Blobstore2Info Blobstore2Info { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compositeMedia")]
        public virtual System.Collections.Generic.IList<CompositeMedia> CompositeMedia { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentType")]
        public virtual string ContentType { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentTypeInfo")]
        public virtual ContentTypeInfo ContentTypeInfo { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cosmoBinaryReference")]
        public virtual string CosmoBinaryReference { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crc32cHash")]
        public virtual System.Nullable<long> Crc32cHash { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diffChecksumsResponse")]
        public virtual DiffChecksumsResponse DiffChecksumsResponse { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diffDownloadResponse")]
        public virtual DiffDownloadResponse DiffDownloadResponse { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diffUploadRequest")]
        public virtual DiffUploadRequest DiffUploadRequest { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diffUploadResponse")]
        public virtual DiffUploadResponse DiffUploadResponse { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diffVersionResponse")]
        public virtual DiffVersionResponse DiffVersionResponse { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downloadParameters")]
        public virtual DownloadParameters DownloadParameters { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filename")]
        public virtual string Filename { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hash")]
        public virtual string Hash { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hashVerified")]
        public virtual System.Nullable<bool> HashVerified { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inline")]
        public virtual string Inline { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isPotentialRetry")]
        public virtual System.Nullable<bool> IsPotentialRetry { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("length")]
        public virtual System.Nullable<long> Length { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("md5Hash")]
        public virtual string Md5Hash { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mediaId")]
        public virtual string MediaId { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual ObjectId ObjectId { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referenceType")]
        public virtual string ReferenceType { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha1Hash")]
        public virtual string Sha1Hash { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha256Hash")]
        public virtual string Sha256Hash { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestamp")]
        public virtual System.Nullable<ulong> Timestamp { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary># gdata.* are outside protos with mising documentation</summary>
    public class ObjectId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketName")]
        public virtual string BucketName { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generation")]
        public virtual System.Nullable<long> Generation { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectName")]
        public virtual string ObjectName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The product a case may be associated with.</summary>
    public class Product : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The product line of the Product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productLine")]
        public virtual string ProductLine { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for SearchCaseClassifications endpoint.</summary>
    public class SearchCaseClassificationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The classifications retrieved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caseClassifications")]
        public virtual System.Collections.Generic.IList<CaseClassification> CaseClassifications { get; set; }

        /// <summary>
        /// A token to retrieve the next page of results. Set this in the `page_token` field of subsequent
        /// `caseClassifications.list` requests. If unspecified, there are no more results to retrieve.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for the SearchCases endpoint.</summary>
    public class SearchCasesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of cases associated with the parent after any filters have been applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cases")]
        public virtual System.Collections.Generic.IList<Case> Cases { get; set; }

        /// <summary>
        /// A token to retrieve the next page of results. Set this in the `page_token` field of subsequent
        /// `cases.search` requests. If unspecified, there are no more results to retrieve.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for the ShowFeed endpoint.</summary>
    public class ShowFeedResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of feed items associated with the given Case.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feedItems")]
        public virtual System.Collections.Generic.IList<FeedItem> FeedItems { get; set; }

        /// <summary>
        /// A token to retrieve the next page of results. This should be set in the `page_token` field of subsequent
        /// `ShowFeedRequests`. If unspecified, there are no more results to retrieve.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Stores text attached to a support object.</summary>
    public class TextContent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Content in this field should be rendered and interpreted as-is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plainText")]
        public virtual string PlainText { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
