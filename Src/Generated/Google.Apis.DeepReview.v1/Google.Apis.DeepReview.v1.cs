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

namespace Google.Apis.DeepReview.v1
{
    /// <summary>The DeepReview Service.</summary>
    public class DeepReviewService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DeepReviewService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DeepReviewService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Documents = new DocumentsResource(this);
            Media = new MediaResource(this);
            Operations = new OperationsResource(this);
            V1 = new V1Resource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://deepreview.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://deepreview.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "deepreview";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Deep Review API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>
            /// See, edit, create, and delete only the specific Google Drive files you use with this app
            /// </summary>
            public static string DriveFile = "https://www.googleapis.com/auth/drive.file";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Deep Review API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>
            /// See, edit, create, and delete only the specific Google Drive files you use with this app
            /// </summary>
            public const string DriveFile = "https://www.googleapis.com/auth/drive.file";
        }

        /// <summary>Gets the Documents resource.</summary>
        public virtual DocumentsResource Documents { get; }

        /// <summary>Gets the Media resource.</summary>
        public virtual MediaResource Media { get; }

        /// <summary>Gets the Operations resource.</summary>
        public virtual OperationsResource Operations { get; }

        /// <summary>Gets the V1 resource.</summary>
        public virtual V1Resource V1 { get; }
    }

    /// <summary>A base abstract class for DeepReview requests.</summary>
    public abstract class DeepReviewBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new DeepReviewBaseServiceRequest instance.</summary>
        protected DeepReviewBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes DeepReview parameter list.</summary>
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

    /// <summary>The "documents" collection of methods.</summary>
    public class DocumentsResource
    {
        private const string Resource = "documents";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public DocumentsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Reviews = new ReviewsResource(service);
        }

        /// <summary>Gets the Reviews resource.</summary>
        public virtual ReviewsResource Reviews { get; }

        /// <summary>The "reviews" collection of methods.</summary>
        public class ReviewsResource
        {
            private const string Resource = "reviews";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ReviewsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates and initiates an asynchronous multi-agent review for a document. Returns a
            /// google.longrunning.Operation. When the operation completes, the `response` field contains a `Review` and
            /// the `metadata` field contains `CreateReviewMetadata`.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The parent Document resource name where this review will be created.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.DeepReview.v1.Data.Review body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Creates and initiates an asynchronous multi-agent review for a document. Returns a
            /// google.longrunning.Operation. When the operation completes, the `response` field contains a `Review` and
            /// the `metadata` field contains `CreateReviewMetadata`.
            /// </summary>
            public class CreateRequest : DeepReviewBaseServiceRequest<Google.Apis.DeepReview.v1.Data.Operation>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DeepReview.v1.Data.Review body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The parent Document resource name where this review will be created.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. Idempotency identifier for network retry safety (AIP-155). Must be a valid UUID4 string.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string RequestId { get; set; }

                /// <summary>
                /// Optional. The ID to use for the review, which will become the final component of the review's
                /// resource name. If not provided, a unique server-generated UUID will be assigned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("reviewId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ReviewId { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DeepReview.v1.Data.Review Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/reviews";

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
                        Pattern = @"^documents/[^/]+$",
                    });
                    RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "requestId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("reviewId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "reviewId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Retrieves a specific review execution result.</summary>
            /// <param name="name">Required. The resource name of the review to retrieve.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Retrieves a specific review execution result.</summary>
            public class GetRequest : DeepReviewBaseServiceRequest<Google.Apis.DeepReview.v1.Data.Review>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. The resource name of the review to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

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
                        Pattern = @"^documents/[^/]+/reviews/[^/]+$",
                    });
                }
            }

            /// <summary>Lists all review execution runs for a document.</summary>
            /// <param name="parent">Required. The parent Document resource name.</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists all review execution runs for a document.</summary>
            public class ListRequest : DeepReviewBaseServiceRequest<Google.Apis.DeepReview.v1.Data.ListReviewsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. The parent Document resource name.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. Custom filter expressions are not currently supported; non-empty values return
                /// INVALID_ARGUMENT.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Optional. Custom order_by expressions are not currently supported; non-empty values return
                /// INVALID_ARGUMENT.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>
                /// Optional. The maximum number of reviews to return in a single page. The server may return fewer than
                /// this value. If unspecified, at most 50 reviews will be returned. The maximum value is 100; values
                /// above 100 will be coerced to 100.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Optional. A page token received from a previous `ListReviews` call.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/reviews";

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
                        Pattern = @"^documents/[^/]+$",
                    });
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
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
        /// Deletes a document and its stored content. If `force` is set to `true`, any associated reviews are also
        /// deleted.
        /// </summary>
        /// <param name="name">Required. The resource name of the document to delete.</param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(this.service, name);
        }

        /// <summary>
        /// Deletes a document and its stored content. If `force` is set to `true`, any associated reviews are also
        /// deleted.
        /// </summary>
        public class DeleteRequest : DeepReviewBaseServiceRequest<Google.Apis.DeepReview.v1.Data.Empty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. The resource name of the document to delete.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Optional. If set to `true`, and the document is not found, the request succeeds.</summary>
            [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> AllowMissing { get; set; }

            /// <summary>
            /// Optional. If set to `true`, any child resources (e.g. review resources) are also deleted. If `false` and
            /// the document has existing reviews, the request fails with `FAILED_PRECONDITION`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Force { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

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
                    Pattern = @"^documents/[^/]+$",
                });
                RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                {
                    Name = "allowMissing",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
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
        /// Estimates what a review of a document would cost on the caller's Gemini API key. The estimate comes from
        /// what past reviews with the same model, depth, and thinking level cost, adjusted to this document's size and
        /// repriced at the Gemini API's current list prices. It covers one review attempt that runs to completion, and
        /// doesn't include retries after errors.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="document">Required. The document to review.</param>
        public virtual EstimateReviewCostRequest EstimateReviewCost(Google.Apis.DeepReview.v1.Data.EstimateReviewCostRequest body, string document)
        {
            return new EstimateReviewCostRequest(this.service, body, document);
        }

        /// <summary>
        /// Estimates what a review of a document would cost on the caller's Gemini API key. The estimate comes from
        /// what past reviews with the same model, depth, and thinking level cost, adjusted to this document's size and
        /// repriced at the Gemini API's current list prices. It covers one review attempt that runs to completion, and
        /// doesn't include retries after errors.
        /// </summary>
        public class EstimateReviewCostRequest : DeepReviewBaseServiceRequest<Google.Apis.DeepReview.v1.Data.EstimateReviewCostResponse>
        {
            /// <summary>Constructs a new EstimateReviewCost request.</summary>
            public EstimateReviewCostRequest(Google.Apis.Services.IClientService service, Google.Apis.DeepReview.v1.Data.EstimateReviewCostRequest body, string document) : base(service)
            {
                Document = document;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The document to review.</summary>
            [Google.Apis.Util.RequestParameterAttribute("document", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Document { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DeepReview.v1.Data.EstimateReviewCostRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "estimateReviewCost";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+document}:estimateReviewCost";

            /// <summary>Initializes EstimateReviewCost parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("document", new Google.Apis.Discovery.Parameter
                {
                    Name = "document",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^documents/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Retrieves document metadata. The returned document includes its `latest_review_summary` when a review
        /// exists.
        /// </summary>
        /// <param name="name">Required. The resource name of the document to retrieve.</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(this.service, name);
        }

        /// <summary>
        /// Retrieves document metadata. The returned document includes its `latest_review_summary` when a review
        /// exists.
        /// </summary>
        public class GetRequest : DeepReviewBaseServiceRequest<Google.Apis.DeepReview.v1.Data.Document>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. The resource name of the document to retrieve.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

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
                    Pattern = @"^documents/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Lists documents for the authenticated caller with cursor pagination. Each returned document includes its
        /// `latest_review_summary` when a review exists.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>
        /// Lists documents for the authenticated caller with cursor pagination. Each returned document includes its
        /// `latest_review_summary` when a review exists.
        /// </summary>
        public class ListRequest : DeepReviewBaseServiceRequest<Google.Apis.DeepReview.v1.Data.ListDocumentsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional. Custom filter expressions are not currently supported; non-empty values return
            /// INVALID_ARGUMENT.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>
            /// Optional. Custom order_by expressions are not currently supported; non-empty values return
            /// INVALID_ARGUMENT.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>
            /// Optional. The maximum number of documents to return in a single page. The server may return fewer than
            /// this value. If unspecified, at most 50 documents will be returned. The maximum value is 100; values
            /// above 100 will be coerced to 100.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>Optional. A page token received from a previous `ListDocuments` call.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/documents";

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
        /// Downloads the original document content (PDF binary) using media streaming. Pass `alt=media` as a query
        /// parameter to stream the binary PDF bytes. Without `alt=media`, a JSON response is returned.
        /// </summary>
        /// <param name="name">Required. The resource name of the document to download.</param>
        public virtual DownloadRequest Download(string name)
        {
            return new DownloadRequest(this.service, name);
        }

        /// <summary>
        /// Downloads the original document content (PDF binary) using media streaming. Pass `alt=media` as a query
        /// parameter to stream the binary PDF bytes. Without `alt=media`, a JSON response is returned.
        /// </summary>
        public class DownloadRequest : DeepReviewBaseServiceRequest<Google.Apis.DeepReview.v1.Data.DownloadDocumentResponse>
        {
            /// <summary>Constructs a new Download request.</summary>
            public DownloadRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                MediaDownloader = new Google.Apis.Download.MediaDownloader(service);
                InitParameters();
            }

            /// <summary>Required. The resource name of the document to download.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "download";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}:download";

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
                    Pattern = @"^documents/[^/]+$",
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
        /// Creates a new Document resource and ingests the manuscript using media upload or Google Drive.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual UploadRequest Upload(Google.Apis.DeepReview.v1.Data.Document body)
        {
            return new UploadRequest(this.service, body);
        }

        /// <summary>
        /// Creates a new Document resource and ingests the manuscript using media upload or Google Drive.
        /// </summary>
        public class UploadRequest : DeepReviewBaseServiceRequest<Google.Apis.DeepReview.v1.Data.Document>
        {
            /// <summary>Constructs a new Upload request.</summary>
            public UploadRequest(Google.Apis.Services.IClientService service, Google.Apis.DeepReview.v1.Data.Document body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Optional. The ID to use for the document, which will become the final component of the document's
            /// resource name. If not provided, a unique server-generated UUID will be assigned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("documentId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string DocumentId { get; set; }

            /// <summary>
            /// Optional. Idempotency identifier for network retry safety (AIP-155). Must be a valid UUID4 string.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string RequestId { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DeepReview.v1.Data.Document Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "upload";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/documents";

            /// <summary>Initializes Upload parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("documentId", new Google.Apis.Discovery.Parameter
                {
                    Name = "documentId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
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

        /// <summary>
        /// Creates a new Document resource and ingests the manuscript using media upload or Google Drive.
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
        /// <param name="stream">The stream to upload. See remarks for further information.</param>
        /// <param name="contentType">The content type of the stream to upload.</param>
        public virtual UploadMediaUpload Upload(Google.Apis.DeepReview.v1.Data.Document body, System.IO.Stream stream, string contentType)
        {
            return new UploadMediaUpload(service, body, stream, contentType);
        }

        /// <summary>Upload media upload which supports resumable upload.</summary>
        public class UploadMediaUpload : Google.Apis.Upload.ResumableUpload<Google.Apis.DeepReview.v1.Data.Document, Google.Apis.DeepReview.v1.Data.Document>
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
            /// Optional. The ID to use for the document, which will become the final component of the document's
            /// resource name. If not provided, a unique server-generated UUID will be assigned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("documentId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string DocumentId { get; set; }

            /// <summary>
            /// Optional. Idempotency identifier for network retry safety (AIP-155). Must be a valid UUID4 string.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string RequestId { get; set; }

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
            public UploadMediaUpload(Google.Apis.Services.IClientService service, Google.Apis.DeepReview.v1.Data.Document body, System.IO.Stream stream, string contentType)
                : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "v1/documents"), "POST", stream, contentType)
            {
                Body = body;
            }
        }
    }

    /// <summary>The "operations" collection of methods.</summary>
    public class OperationsResource
    {
        private const string Resource = "operations";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public OperationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Documents = new DocumentsResource(service);
        }

        /// <summary>Gets the Documents resource.</summary>
        public virtual DocumentsResource Documents { get; }

        /// <summary>The "documents" collection of methods.</summary>
        public class DocumentsResource
        {
            private const string Resource = "documents";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public DocumentsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Reviews = new ReviewsResource(service);
            }

            /// <summary>Gets the Reviews resource.</summary>
            public virtual ReviewsResource Reviews { get; }

            /// <summary>The "reviews" collection of methods.</summary>
            public class ReviewsResource
            {
                private const string Resource = "reviews";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ReviewsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
                /// result at intervals as recommended by the API service.
                /// </summary>
                /// <param name="name">The name of the operation resource.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>
                /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
                /// result at intervals as recommended by the API service.
                /// </summary>
                public class GetRequest : DeepReviewBaseServiceRequest<Google.Apis.DeepReview.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

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
                            Pattern = @"^operations/documents/[^/]+/reviews/[^/]+$",
                        });
                    }
                }
            }
        }
    }

    /// <summary>The "v1" collection of methods.</summary>
    public class V1Resource
    {
        private const string Resource = "v1";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public V1Resource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Retrieves the review quota limits and sliding-window usage for the authenticated caller.</summary>
        /// <param name="name">Required. The resource name of the singleton user quota to retrieve.</param>
        public virtual GetUserQuotaRequest GetUserQuota(string name)
        {
            return new GetUserQuotaRequest(this.service, name);
        }

        /// <summary>Retrieves the review quota limits and sliding-window usage for the authenticated caller.</summary>
        public class GetUserQuotaRequest : DeepReviewBaseServiceRequest<Google.Apis.DeepReview.v1.Data.UserQuota>
        {
            /// <summary>Constructs a new GetUserQuota request.</summary>
            public GetUserQuotaRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. The resource name of the singleton user quota to retrieve.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getUserQuota";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes GetUserQuota parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^userQuota$",
                });
            }
        }
    }
}
namespace Google.Apis.DeepReview.v1.Data
{
    /// <summary>A structured review comment anchored to a specific location in the document.</summary>
    public class AnchoredReviewComment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Detailed markdown explanation of the review comment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bodyMarkdown")]
        public virtual string BodyMarkdown { get; set; }

        /// <summary>
        /// Output only. Optional structured citation verification report when this comment corresponds to a
        /// bibliography reference.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("citationReport")]
        public virtual CitationReport CitationReport { get; set; }

        /// <summary>Output only. Unique identifier for the comment within the review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commentId")]
        public virtual string CommentId { get; set; }

        /// <summary>Output only. Polymorphic location in the document where this comment is anchored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual DocumentLocation Location { get; set; }

        /// <summary>Output only. Severity classification of the comment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>Output only. Optional suggested replacement text or edit for the anchored span.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedEdit")]
        public virtual string SuggestedEdit { get; set; }

        /// <summary>Output only. Short one-line summary of the review comment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("summary")]
        public virtual string Summary { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Author name components.</summary>
    public class Author : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Author family name / surname (or organization name).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("familyName")]
        public virtual string FamilyName { get; set; }

        /// <summary>Output only. Author given name / initials.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("givenName")]
        public virtual string GivenName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Structured bibliographic metadata for an extracted or retrieved work.</summary>
    public class CitationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Ordered list of authors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authors")]
        public virtual System.Collections.Generic.IList<Author> Authors { get; set; }

        /// <summary>Output only. Digital Object Identifier (DOI).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doi")]
        public virtual string Doi { get; set; }

        /// <summary>Output only. Journal, conference, or venue name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("journal")]
        public virtual string Journal { get; set; }

        /// <summary>Output only. Page range or article number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pages")]
        public virtual string Pages { get; set; }

        /// <summary>Output only. Publication date (month and day left as 0 if just year).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicationDate")]
        public virtual Date PublicationDate { get; set; }

        /// <summary>
        /// Output only. Source database for retrieved metadata (e.g., "openalex", "crossref"). Empty on
        /// `extracted_metadata`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>Output only. Work title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>Output only. URLs associated with the reference.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("urls")]
        public virtual System.Collections.Generic.IList<string> Urls { get; set; }

        /// <summary>Output only. Volume identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volume")]
        public virtual string Volume { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Structured citation verification report for a single bibliography reference.</summary>
    public class CitationReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Generated BibTeX citation key (e.g., "smith2023deep").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("citationKey")]
        public virtual string CitationKey { get; set; }

        /// <summary>Output only. BibTeX entry type (e.g., "article", "inproceedings", "misc").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entryType")]
        public virtual string EntryType { get; set; }

        /// <summary>Output only. Metadata parsed from the paper's bibliography entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extractedMetadata")]
        public virtual CitationMetadata ExtractedMetadata { get; set; }

        /// <summary>Output only. Per-field comparisons (populated only when `retrieved_metadata` is present).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldComparisons")]
        public virtual System.Collections.Generic.IList<FieldComparison> FieldComparisons { get; set; }

        /// <summary>Output only. Final combined verdict after database lookup and search grounding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finalVerdict")]
        public virtual string FinalVerdict { get; set; }

        /// <summary>
        /// Output only. Whether the first author's family name matched between extracted and retrieved metadata.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstAuthorFamilyNameMatch")]
        public virtual System.Nullable<bool> FirstAuthorFamilyNameMatch { get; set; }

        /// <summary>Output only. Web sources surfaced during Google Search grounding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groundingUrls")]
        public virtual System.Collections.Generic.IList<GroundingUrl> GroundingUrls { get; set; }

        /// <summary>
        /// Output only. Verdict from scholarly database lookup (OpenAlex / Crossref) before search grounding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lookupVerdict")]
        public virtual string LookupVerdict { get; set; }

        /// <summary>Output only. Verbatim reference string extracted from the paper's bibliography.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rawReference")]
        public virtual string RawReference { get; set; }

        /// <summary>Output only. 1-indexed bibliography reference number in the paper.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refNum")]
        public virtual System.Nullable<int> RefNum { get; set; }

        /// <summary>
        /// Output only. Formatted BibTeX entry for the verified `retrieved_metadata` when present. Empty when
        /// `retrieved_metadata` is absent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retrievedBibtex")]
        public virtual string RetrievedBibtex { get; set; }

        /// <summary>
        /// Output only. Metadata retrieved from OpenAlex / Crossref. Populated only when the retrieved work's title
        /// matches the extracted title. Omitted when no candidate matches the title so unrelated papers are never
        /// displayed as candidates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retrievedMetadata")]
        public virtual CitationMetadata RetrievedMetadata { get; set; }

        /// <summary>
        /// Output only. Strategy that produced the scholarly database match (e.g., "doi", "title", "title_author",
        /// "autocomplete"). Empty when no title-matching candidate was found.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchMethod")]
        public virtual string SearchMethod { get; set; }

        /// <summary>Output only. Explanation from the Google Search grounding verification step (when run).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchRationale")]
        public virtual string SearchRationale { get; set; }

        /// <summary>Output only. Verdict from Google Search grounding verification (when run).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchVerdict")]
        public virtual string SearchVerdict { get; set; }

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

    /// <summary>Configuration options for the multi-agent document review execution pipeline.</summary>
    public class DeepReviewRunConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Input only. Developer Bring-Your-Own-Key Gemini API key. When provided, requests are billed to the
        /// caller's Gemini API project. Input only; forwarded to the asynchronous review runner in the task payload and
        /// never persisted in database records or returned in review resources (see companion field
        /// `gemini_api_key_set`, AIP-147).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("geminiApiKey")]
        public virtual string GeminiApiKey { get; set; }

        /// <summary>
        /// Output only. Indicates whether a developer Bring-Your-Own-Key Gemini API key was provided for this review
        /// run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("geminiApiKeySet")]
        public virtual System.Nullable<bool> GeminiApiKeySet { get; set; }

        /// <summary>
        /// Optional. The Gemini model identifier to use for the review. If omitted, the server uses its default model.
        /// Unsupported values return INVALID_ARGUMENT.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; }

        /// <summary>
        /// Optional. Reasoning effort level for model calls in the review pipeline. Defaults to `THINKING_LEVEL_MEDIUM`
        /// when omitted or `THINKING_LEVEL_UNSPECIFIED`. Non-`THINKING_LEVEL_MEDIUM` thinking levels require
        /// `gemini_api_key` when calling `CreateReview`; otherwise `CreateReview` returns `INVALID_ARGUMENT`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thinkingLevel")]
        public virtual string ThinkingLevel { get; set; }

        /// <summary>Optional. Review execution topology profile to use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topology")]
        public virtual string Topology { get; set; }

        /// <summary>
        /// Optional. User-provided guidance, focus areas, or custom evaluation instructions passed to the review
        /// agents.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userPrompt")]
        public virtual string UserPrompt { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A document uploaded for automated review. Documents are immutable post-creation; to review a new version, create
    /// a new Document.
    /// </summary>
    public class Document : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Timestamp when the document was initially created.</summary>
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

        /// <summary>Optional. User-provided display title or filename for the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Optional. Reference to a Google Drive file to import.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driveSource")]
        public virtual DriveSource DriveSource { get; set; }

        /// <summary>
        /// Output only. Summary of the most recent review run for this document, if any. Populated by `GetDocument` and
        /// `ListDocuments`; unset on the document returned by `CreateDocument`, which has no reviews yet.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestReviewSummary")]
        public virtual ReviewSummary LatestReviewSummary { get; set; }

        /// <summary>Identifier. Resource name in format `documents/{document}`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A location targeting either a PDF page region/quote or text lines in the document.</summary>
    public class DocumentLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Location within a rendered PDF document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pdf")]
        public virtual PdfLocation Pdf { get; set; }

        /// <summary>Output only. Location within a plain-text, Markdown, or LaTeX source document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual TextLocation Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for downloading a Document's raw content using media download.</summary>
    public class DownloadDocumentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for importing a document directly from Google Drive.</summary>
    public class DriveSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Immutable. The Google Drive file ID (e.g. "1BxiMVs0XRA5nFMdKvBdBZjgmUUqptlbs74OgvE2upms"). For
        /// Google Drive shortcuts, callers must pass the resolved target file's `file_id` and `resource_key`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileId")]
        public virtual string FileId { get; set; }

        /// <summary>
        /// Optional. Input only. Immutable. Resource key (`^[a-zA-Z0-9_-]{1,128}$`) required to access certain older
        /// link-shared Google Drive files returned by the Google Drive Picker (for shortcuts, pass the resolved target
        /// file's resource key). Never persisted in database records or returned in Document resources (see companion
        /// field `resource_key_set`, AIP-147).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceKey")]
        public virtual string ResourceKey { get; set; }

        /// <summary>Output only. Indicates whether a resource key was provided for this Drive source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceKeySet")]
        public virtual System.Nullable<bool> ResourceKeySet { get; set; }

        /// <summary>
        /// Optional. Input only. Immutable. Importing a specific revision is not currently supported; non-empty values
        /// return INVALID_ARGUMENT.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

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

    /// <summary>Request message for estimating what a review would cost.</summary>
    public class EstimateReviewCostRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The review to estimate, as it would be passed to `CreateReview`. Only its `run_config` is read,
        /// and `gemini_api_key` is ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("review")]
        public virtual Review Review { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response message for estimating what a review would cost. When the cost can't be estimated, for example because
    /// too few past reviews used the same model, depth, and thinking level, the costs are unset and `past_review_count`
    /// is 0.
    /// </summary>
    public class EstimateReviewCostResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The 95th percentile of what comparable past reviews would cost for this document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("highCost")]
        public virtual Money HighCost { get; set; }

        /// <summary>The 20th percentile of what comparable past reviews would cost for this document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lowCost")]
        public virtual Money LowCost { get; set; }

        /// <summary>The median of what comparable past reviews would cost for this document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("medianCost")]
        public virtual Money MedianCost { get; set; }

        /// <summary>Number of past reviews the estimate is based on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pastReviewCount")]
        public virtual System.Nullable<int> PastReviewCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Per-field comparison result between extracted and retrieved metadata.</summary>
    public class FieldComparison : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Human-readable comparison detail (e.g., "extracted=2023, found=2024 (diff=1)").
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detail")]
        public virtual string Detail { get; set; }

        /// <summary>Output only. Field key ("title", "authors", "year", "journal", "volume", "pages", "doi").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldKey")]
        public virtual string FieldKey { get; set; }

        /// <summary>Output only. Whether the extracted and retrieved values matched.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("match")]
        public virtual System.Nullable<bool> Match { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Web source URL surfaced during Google Search grounding verification.</summary>
    public class GroundingUrl : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Source page title or domain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>Output only. Source URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing Document resources.</summary>
    public class ListDocumentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of Document resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documents")]
        public virtual System.Collections.Generic.IList<Document> Documents { get; set; }

        /// <summary>A token to retrieve the next page of results, or empty if no further pages exist.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing Review resources.</summary>
    public class ListReviewsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A token to retrieve the next page of results, or empty if no further pages exist.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of Review resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reviews")]
        public virtual System.Collections.Generic.IList<Review> Reviews { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an amount of money with its currency type.</summary>
    public class Money : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The three-letter currency code defined in ISO 4217.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>
        /// Number of nano (10^-9) units of the amount. The value must be between -999,999,999 and +999,999,999
        /// inclusive. If `units` is positive, `nanos` must be positive or zero. If `units` is zero, `nanos` can be
        /// positive, zero, or negative. If `units` is negative, `nanos` must be negative or zero. For example $-1.75 is
        /// represented as `units`=-1 and `nanos`=-750,000,000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>
        /// The whole units of the amount. For example if `currencyCode` is `"USD"`, then 1 unit is one US dollar.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("units")]
        public virtual System.Nullable<long> Units { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Bounding box in normalized [0.0, 1.0] page coordinates (origin top-left).</summary>
    public class NormalizedBoundingBox : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Bottom coordinate in [0.0, 1.0].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bottom")]
        public virtual System.Nullable<float> Bottom { get; set; }

        /// <summary>Output only. Left coordinate in [0.0, 1.0].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("left")]
        public virtual System.Nullable<float> Left { get; set; }

        /// <summary>Output only. Right coordinate in [0.0, 1.0].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("right")]
        public virtual System.Nullable<float> Right { get; set; }

        /// <summary>Output only. Top coordinate in [0.0, 1.0].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("top")]
        public virtual System.Nullable<float> Top { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This resource represents a long-running operation that is the result of a network API call.</summary>
    public class Operation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the value is `false`, it means the operation is still in progress. If `true`, the operation is completed,
        /// and either `error` or `response` is available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("done")]
        public virtual System.Nullable<bool> Done { get; set; }

        /// <summary>The error result of the operation in case of failure or cancellation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>
        /// Service-specific metadata associated with the operation. It typically contains progress information and
        /// common metadata such as create time. Some services might not provide such metadata. Any method that returns
        /// a long-running operation should document the metadata type, if any.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// The server-assigned name, which is only unique within the same service that originally returns it. If you
        /// use the default HTTP mapping, the `name` should be a resource name ending with `operations/{unique_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The normal, successful response of the operation. If the original method returns no data on success, such as
        /// `Delete`, the response is `google.protobuf.Empty`. If the original method is standard
        /// `Get`/`Create`/`Update`, the response should be the resource. For other methods, the response should have
        /// the type `XxxResponse`, where `Xxx` is the original method name. For example, if the original method name is
        /// `TakeSnapshot()`, the inferred response type is `TakeSnapshotResponse`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string, object> Response { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Location anchor within a PDF document.</summary>
    public class PdfLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Normalized bounding boxes [0.0, 1.0] relative to page width and height. At most 50 bounding
        /// boxes are returned per anchored span.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingBoxes")]
        public virtual System.Collections.Generic.IList<NormalizedBoundingBox> BoundingBoxes { get; set; }

        /// <summary>Output only. 1-indexed page number within the PDF document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageNumber")]
        public virtual System.Nullable<int> PageNumber { get; set; }

        /// <summary>
        /// Output only. W3C Web Annotation TextQuoteSelector
        /// (https://www.w3.org/TR/annotation-model/#text-quote-selector) for exact text span highlighting.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quoteSelector")]
        public virtual TextQuoteSelector QuoteSelector { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates the synthesized output or failure details of a single review execution.</summary>
    public class Result : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Structured review comments anchored to specific locations in the document. At most 300 anchored
        /// comments are returned per review.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("anchoredComments")]
        public virtual System.Collections.Generic.IList<AnchoredReviewComment> AnchoredComments { get; set; }

        /// <summary>Output only. Failure status details if review execution failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>Output only. Synthesized review report markdown.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reviewMarkdown")]
        public virtual string ReviewMarkdown { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An evaluation run of a document.</summary>
    public class Review : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Timestamp when this review attempt was initiated.</summary>
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

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Output only. Timestamp when the review reached a terminal state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual string EndTimeRaw
        {
            get => _endTimeRaw;
            set
            {
                _endTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _endTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EndTimeDateTimeOffset instead.")]
        public virtual object EndTime
        {
            get => _endTime;
            set
            {
                _endTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _endTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="EndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EndTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EndTimeRaw);
            set => EndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Identifier. Resource name in format `documents/{document}/reviews/{review}`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Estimated completion progress percentage of the review in [0, 100].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressPercent")]
        public virtual System.Nullable<int> ProgressPercent { get; set; }

        /// <summary>Output only. Review output (markdown, errors, and future modalities).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("result")]
        public virtual Result Result { get; set; }

        /// <summary>Optional. Run configuration parameters used for this review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runConfig")]
        public virtual DeepReviewRunConfig RunConfig { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Output only. Timestamp when the worker started evaluation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual string StartTimeRaw
        {
            get => _startTimeRaw;
            set
            {
                _startTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _startTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="StartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use StartTimeDateTimeOffset instead.")]
        public virtual object StartTime
        {
            get => _startTime;
            set
            {
                _startTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _startTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="StartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? StartTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(StartTimeRaw);
            set => StartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. Current review lifecycle state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Lightweight summary of a Review execution run for display in Document views.</summary>
    public class ReviewSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Timestamp when this review attempt was initiated.</summary>
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

        /// <summary>Output only. Resource name of the Review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("review")]
        public virtual string Review { get; set; }

        /// <summary>Output only. Current review lifecycle state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

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

    /// <summary>Location anchor within a plain-text, Markdown, or LaTeX source document.</summary>
    public class TextLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Optional 1-indexed inclusive first column offset within `first_line`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstColumn")]
        public virtual System.Nullable<int> FirstColumn { get; set; }

        /// <summary>Output only. 1-indexed inclusive first line number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstLine")]
        public virtual System.Nullable<int> FirstLine { get; set; }

        /// <summary>Output only. Optional 1-indexed inclusive last column offset within `last_line`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastColumn")]
        public virtual System.Nullable<int> LastColumn { get; set; }

        /// <summary>Output only. 1-indexed inclusive last line number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastLine")]
        public virtual System.Nullable<int> LastLine { get; set; }

        /// <summary>Output only. Verbatim snippet of the anchored source line(s).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotedLinePreview")]
        public virtual string QuotedLinePreview { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// W3C Web Annotation TextQuoteSelector for resilient text anchoring (see
    /// https://www.w3.org/TR/annotation-model/#text-quote-selector for details).
    /// </summary>
    public class TextQuoteSelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Verbatim substring extracted from the document character stream.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exact")]
        public virtual string Exact { get; set; }

        /// <summary>Output only. Characters immediately preceding `exact` for disambiguation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prefix")]
        public virtual string Prefix { get; set; }

        /// <summary>Output only. Characters immediately following `exact` for disambiguation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suffix")]
        public virtual string Suffix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Singleton resource representing the authenticated caller's review quota limits and sliding-window usage.
    /// </summary>
    public class UserQuota : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Whether a custom per-user quota override is active for this user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customLimitEnabled")]
        public virtual System.Nullable<bool> CustomLimitEnabled { get; set; }

        /// <summary>Output only. Maximum free-tier reviews allowed per rolling 7-day window.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxReviewCountPerWeek")]
        public virtual System.Nullable<int> MaxReviewCountPerWeek { get; set; }

        /// <summary>Identifier. Resource name of the singleton user quota (`userQuota`).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _nextAvailableTimeRaw;

        private object _nextAvailableTime;

        /// <summary>
        /// Output only. Timestamp when the next review quota slot becomes available if `remaining_review_count` is 0;
        /// unset when quota is currently available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextAvailableTime")]
        public virtual string NextAvailableTimeRaw
        {
            get => _nextAvailableTimeRaw;
            set
            {
                _nextAvailableTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _nextAvailableTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="NextAvailableTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use NextAvailableTimeDateTimeOffset instead.")]
        public virtual object NextAvailableTime
        {
            get => _nextAvailableTime;
            set
            {
                _nextAvailableTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _nextAvailableTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="NextAvailableTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? NextAvailableTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(NextAvailableTimeRaw);
            set => NextAvailableTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. Remaining free-tier reviews available in the current rolling 7-day window (`max(0,
        /// max_review_count_per_week - used_review_count)`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remainingReviewCount")]
        public virtual System.Nullable<int> RemainingReviewCount { get; set; }

        /// <summary>Output only. Number of free-tier reviews used in the past 7 days.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usedReviewCount")]
        public virtual System.Nullable<int> UsedReviewCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
