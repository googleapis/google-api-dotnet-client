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

namespace Google.Apis.DeveloperKnowledge.v1alpha
{
    /// <summary>The DeveloperKnowledge Service.</summary>
    public class DeveloperKnowledgeService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1alpha";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DeveloperKnowledgeService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DeveloperKnowledgeService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Documents = new DocumentsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://developerknowledge.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://developerknowledge.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "developerknowledge";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Developer Knowledge API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Developer Knowledge API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Documents resource.</summary>
        public virtual DocumentsResource Documents { get; }
    }

    /// <summary>A base abstract class for DeveloperKnowledge requests.</summary>
    public abstract class DeveloperKnowledgeBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new DeveloperKnowledgeBaseServiceRequest instance.</summary>
        protected DeveloperKnowledgeBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes DeveloperKnowledge parameter list.</summary>
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
        }

        /// <summary>Retrieves multiple documents, each with its full Markdown content.</summary>
        public virtual BatchGetRequest BatchGet()
        {
            return new BatchGetRequest(this.service);
        }

        /// <summary>Retrieves multiple documents, each with its full Markdown content.</summary>
        public class BatchGetRequest : DeveloperKnowledgeBaseServiceRequest<Google.Apis.DeveloperKnowledge.v1alpha.Data.BatchGetDocumentsResponse>
        {
            /// <summary>Constructs a new BatchGet request.</summary>
            public BatchGetRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Required. The names of the documents to retrieve. A maximum of 20 documents can be retrieved in a batch.
            /// The documents are returned in the same order as the `names` in the request. Format:
            /// `documents/{uri_without_scheme}` Example:
            /// `documents/docs.cloud.google.com/storage/docs/creating-buckets`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("names", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Names { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "batchGet";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/documents:batchGet";

            /// <summary>Initializes BatchGet parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("names", new Google.Apis.Discovery.Parameter
                {
                    Name = "names",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves a single document with its full Markdown content.</summary>
        /// <param name="name">
        /// Required. The name of the document to retrieve. Format: `documents/{uri_without_scheme}` Example:
        /// `documents/docs.cloud.google.com/storage/docs/creating-buckets`
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(this.service, name);
        }

        /// <summary>Retrieves a single document with its full Markdown content.</summary>
        public class GetRequest : DeveloperKnowledgeBaseServiceRequest<Google.Apis.DeveloperKnowledge.v1alpha.Data.Document>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the document to retrieve. Format: `documents/{uri_without_scheme}` Example:
            /// `documents/docs.cloud.google.com/storage/docs/creating-buckets`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/{+name}";

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
                    Pattern = @"^documents/.*$",
                });
            }
        }

        /// <summary>
        /// Searches for developer knowledge across Google's developer documentation. This method returns document
        /// chunks based on the user's query. There can be many chunks of the same Document. To retrieve full documents,
        /// use DeveloperKnowledge.GetDocument or DeveloperKnowledge.BatchGetDocuments with the DocumentChunk.parent
        /// returned in the SearchDocumentChunksResponse.results.
        /// </summary>
        public virtual SearchDocumentChunksRequest SearchDocumentChunks()
        {
            return new SearchDocumentChunksRequest(this.service);
        }

        /// <summary>
        /// Searches for developer knowledge across Google's developer documentation. This method returns document
        /// chunks based on the user's query. There can be many chunks of the same Document. To retrieve full documents,
        /// use DeveloperKnowledge.GetDocument or DeveloperKnowledge.BatchGetDocuments with the DocumentChunk.parent
        /// returned in the SearchDocumentChunksResponse.results.
        /// </summary>
        public class SearchDocumentChunksRequest : DeveloperKnowledgeBaseServiceRequest<Google.Apis.DeveloperKnowledge.v1alpha.Data.SearchDocumentChunksResponse>
        {
            /// <summary>Constructs a new SearchDocumentChunks request.</summary>
            public SearchDocumentChunksRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional. The maximum number of results to return. The service may return fewer than this value. If
            /// unspecified, at most 5 results will be returned. The maximum value is 20; values above 20 will result in
            /// an INVALID_ARGUMENT error.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. A page token, received from a previous `SearchDocumentChunks` call. Provide this to retrieve
            /// the subsequent page.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Required. The raw query string provided by the user, such as "How to create a Cloud Storage bucket?".
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "searchDocumentChunks";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/documents:searchDocumentChunks";

            /// <summary>Initializes SearchDocumentChunks parameter list.</summary>
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
}
namespace Google.Apis.DeveloperKnowledge.v1alpha.Data
{
    /// <summary>Response message for DeveloperKnowledge.BatchGetDocuments.</summary>
    public class BatchGetDocumentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Documents requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documents")]
        public virtual System.Collections.Generic.IList<Document> Documents { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Document represents a piece of content from the Developer Knowledge corpus.</summary>
    public class Document : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The full content of the document in Markdown format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>Output only. A description of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Identifier. The resource name of the document. Format: `documents/{uri_without_scheme}` Example:
        /// `documents/docs.cloud.google.com/storage/docs/creating-buckets`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The URI of the content, such as `docs.cloud.google.com/storage/docs/creating-buckets`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A DocumentChunk represents a piece of content from a Document in the DeveloperKnowledge corpus. To fetch the
    /// entire document content, pass the `parent` to DeveloperKnowledge.GetDocument or
    /// DeveloperKnowledge.BatchGetDocuments.
    /// </summary>
    public class DocumentChunk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The content of the document chunk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>
        /// Output only. The ID of this chunk within the document. The chunk ID is unique within a document, but not
        /// globally unique across documents. The chunk ID is not stable and may change over time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Output only. The resource name of the document this chunk is from. Format: `documents/{uri_without_scheme}`
        /// Example: `documents/docs.cloud.google.com/storage/docs/creating-buckets`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for DeveloperKnowledge.SearchDocumentChunks.</summary>
    public class SearchDocumentChunksResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A token that can be sent as `page_token` to retrieve the next page. If this field is omitted,
        /// there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// The search results for the given query. Each DocumentChunk in this list contains a snippet of content
        /// relevant to the search query. Use the DocumentChunk.parent field of each result with
        /// DeveloperKnowledge.GetDocument or DeveloperKnowledge.BatchGetDocuments to retrieve the full document
        /// content.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<DocumentChunk> Results { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
