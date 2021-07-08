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

namespace Google.Apis.Docs.v1
{
    /// <summary>The Docs Service.</summary>
    public class DocsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DocsService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DocsService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Documents = new DocumentsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "docs";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://docs.googleapis.com/";
        #else
            "https://docs.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://docs.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Google Docs API.</summary>
        public class Scope
        {
            /// <summary>See, edit, create, and delete all your Google Docs documents</summary>
            public static string Documents = "https://www.googleapis.com/auth/documents";

            /// <summary>See all your Google Docs documents</summary>
            public static string DocumentsReadonly = "https://www.googleapis.com/auth/documents.readonly";

            /// <summary>See, edit, create, and delete all of your Google Drive files</summary>
            public static string Drive = "https://www.googleapis.com/auth/drive";

            /// <summary>
            /// See, edit, create, and delete only the specific Google Drive files you use with this app
            /// </summary>
            public static string DriveFile = "https://www.googleapis.com/auth/drive.file";

            /// <summary>See and download all your Google Drive files</summary>
            public static string DriveReadonly = "https://www.googleapis.com/auth/drive.readonly";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Google Docs API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, create, and delete all your Google Docs documents</summary>
            public const string Documents = "https://www.googleapis.com/auth/documents";

            /// <summary>See all your Google Docs documents</summary>
            public const string DocumentsReadonly = "https://www.googleapis.com/auth/documents.readonly";

            /// <summary>See, edit, create, and delete all of your Google Drive files</summary>
            public const string Drive = "https://www.googleapis.com/auth/drive";

            /// <summary>
            /// See, edit, create, and delete only the specific Google Drive files you use with this app
            /// </summary>
            public const string DriveFile = "https://www.googleapis.com/auth/drive.file";

            /// <summary>See and download all your Google Drive files</summary>
            public const string DriveReadonly = "https://www.googleapis.com/auth/drive.readonly";
        }

        /// <summary>Gets the Documents resource.</summary>
        public virtual DocumentsResource Documents { get; }
    }

    /// <summary>A base abstract class for Docs requests.</summary>
    public abstract class DocsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new DocsBaseServiceRequest instance.</summary>
        protected DocsBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Docs parameter list.</summary>
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

        /// <summary>
        /// Applies one or more updates to the document. Each request is validated before being applied. If any request
        /// is not valid, then the entire request will fail and nothing will be applied. Some requests have replies to
        /// give you some information about how they are applied. Other requests do not need to return information;
        /// these each return an empty reply. The order of replies matches that of the requests. For example, suppose
        /// you call batchUpdate with four updates, and only the third one returns information. The response would have
        /// two empty replies, the reply to the third request, and another empty reply, in that order. Because other
        /// users may be editing the document, the document might not exactly reflect your changes: your changes may be
        /// altered with respect to collaborator changes. If there are no collaborators, the document should reflect
        /// your changes. In any case, the updates in your request are guaranteed to be applied together atomically.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="documentId">The ID of the document to update.</param>
        public virtual BatchUpdateRequest BatchUpdate(Google.Apis.Docs.v1.Data.BatchUpdateDocumentRequest body, string documentId)
        {
            return new BatchUpdateRequest(service, body, documentId);
        }

        /// <summary>
        /// Applies one or more updates to the document. Each request is validated before being applied. If any request
        /// is not valid, then the entire request will fail and nothing will be applied. Some requests have replies to
        /// give you some information about how they are applied. Other requests do not need to return information;
        /// these each return an empty reply. The order of replies matches that of the requests. For example, suppose
        /// you call batchUpdate with four updates, and only the third one returns information. The response would have
        /// two empty replies, the reply to the third request, and another empty reply, in that order. Because other
        /// users may be editing the document, the document might not exactly reflect your changes: your changes may be
        /// altered with respect to collaborator changes. If there are no collaborators, the document should reflect
        /// your changes. In any case, the updates in your request are guaranteed to be applied together atomically.
        /// </summary>
        public class BatchUpdateRequest : DocsBaseServiceRequest<Google.Apis.Docs.v1.Data.BatchUpdateDocumentResponse>
        {
            /// <summary>Constructs a new BatchUpdate request.</summary>
            public BatchUpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Docs.v1.Data.BatchUpdateDocumentRequest body, string documentId) : base(service)
            {
                DocumentId = documentId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the document to update.</summary>
            [Google.Apis.Util.RequestParameterAttribute("documentId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DocumentId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Docs.v1.Data.BatchUpdateDocumentRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "batchUpdate";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/documents/{documentId}:batchUpdate";

            /// <summary>Initializes BatchUpdate parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("documentId", new Google.Apis.Discovery.Parameter
                {
                    Name = "documentId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Creates a blank document using the title given in the request. Other fields in the request, including any
        /// provided content, are ignored. Returns the created document.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.Docs.v1.Data.Document body)
        {
            return new CreateRequest(service, body);
        }

        /// <summary>
        /// Creates a blank document using the title given in the request. Other fields in the request, including any
        /// provided content, are ignored. Returns the created document.
        /// </summary>
        public class CreateRequest : DocsBaseServiceRequest<Google.Apis.Docs.v1.Data.Document>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Docs.v1.Data.Document body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Docs.v1.Data.Document Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/documents";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Gets the latest version of the specified document.</summary>
        /// <param name="documentId">The ID of the document to retrieve.</param>
        public virtual GetRequest Get(string documentId)
        {
            return new GetRequest(service, documentId);
        }

        /// <summary>Gets the latest version of the specified document.</summary>
        public class GetRequest : DocsBaseServiceRequest<Google.Apis.Docs.v1.Data.Document>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string documentId) : base(service)
            {
                DocumentId = documentId;
                InitParameters();
            }

            /// <summary>The ID of the document to retrieve.</summary>
            [Google.Apis.Util.RequestParameterAttribute("documentId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DocumentId { get; private set; }

            /// <summary>
            /// The suggestions view mode to apply to the document. This allows viewing the document with all
            /// suggestions inline, accepted or rejected. If one is not specified, DEFAULT_FOR_CURRENT_ACCESS is used.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("suggestionsViewMode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<SuggestionsViewModeEnum> SuggestionsViewMode { get; set; }

            /// <summary>
            /// The suggestions view mode to apply to the document. This allows viewing the document with all
            /// suggestions inline, accepted or rejected. If one is not specified, DEFAULT_FOR_CURRENT_ACCESS is used.
            /// </summary>
            public enum SuggestionsViewModeEnum
            {
                /// <summary>
                /// The SuggestionsViewMode applied to the returned document depends on the user's current access level.
                /// If the user only has view access, PREVIEW_WITHOUT_SUGGESTIONS is applied. Otherwise,
                /// SUGGESTIONS_INLINE is applied. This is the default suggestions view mode.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("DEFAULT_FOR_CURRENT_ACCESS")]
                DEFAULTFORCURRENTACCESS = 0,

                /// <summary>
                /// The returned document has suggestions inline. Suggested changes will be differentiated from base
                /// content within the document. Requests to retrieve a document using this mode will return a 403 error
                /// if the user does not have permission to view suggested changes.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("SUGGESTIONS_INLINE")]
                SUGGESTIONSINLINE = 1,

                /// <summary>
                /// The returned document is a preview with all suggested changes accepted. Requests to retrieve a
                /// document using this mode will return a 403 error if the user does not have permission to view
                /// suggested changes.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("PREVIEW_SUGGESTIONS_ACCEPTED")]
                PREVIEWSUGGESTIONSACCEPTED = 2,

                /// <summary>
                /// The returned document is a preview with all suggested changes rejected if there are any suggestions
                /// in the document.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("PREVIEW_WITHOUT_SUGGESTIONS")]
                PREVIEWWITHOUTSUGGESTIONS = 3,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/documents/{documentId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("documentId", new Google.Apis.Discovery.Parameter
                {
                    Name = "documentId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("suggestionsViewMode", new Google.Apis.Discovery.Parameter
                {
                    Name = "suggestionsViewMode",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.Docs.v1.Data
{
    /// <summary>
    /// A ParagraphElement representing a spot in the text that is dynamically replaced with content that can change
    /// over time, like a page number.
    /// </summary>
    public class AutoText : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The suggested deletion IDs. If empty, then there are no suggested deletions of this content.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedDeletionIds")]
        public virtual System.Collections.Generic.IList<string> SuggestedDeletionIds { get; set; }

        /// <summary>
        /// The suggested insertion IDs. An AutoText may have multiple insertion IDs if it is a nested suggested change.
        /// If empty, then this is not a suggested insertion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedInsertionIds")]
        public virtual System.Collections.Generic.IList<string> SuggestedInsertionIds { get; set; }

        /// <summary>The suggested text style changes to this AutoText, keyed by suggestion ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedTextStyleChanges")]
        public virtual System.Collections.Generic.IDictionary<string, SuggestedTextStyle> SuggestedTextStyleChanges { get; set; }

        /// <summary>The text style of this AutoText.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textStyle")]
        public virtual TextStyle TextStyle { get; set; }

        /// <summary>The type of this auto text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the background of a document.</summary>
    public class Background : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The background color.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual OptionalColor Color { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A mask that indicates which of the fields on the base Background have been changed in this suggestion. For any
    /// field set to true, the Backgound has a new suggested value.
    /// </summary>
    public class BackgroundSuggestionState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates whether the current background color has been modified in this suggestion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backgroundColorSuggested")]
        public virtual System.Nullable<bool> BackgroundColorSuggested { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for BatchUpdateDocument.</summary>
    public class BatchUpdateDocumentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of updates to apply to the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<Request> Requests { get; set; }

        /// <summary>Provides control over how write requests are executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writeControl")]
        public virtual WriteControl WriteControl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message from a BatchUpdateDocument request.</summary>
    public class BatchUpdateDocumentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the document to which the updates were applied to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentId")]
        public virtual string DocumentId { get; set; }

        /// <summary>
        /// The reply of the updates. This maps 1:1 with the updates, although replies to some requests may be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replies")]
        public virtual System.Collections.Generic.IList<Response> Replies { get; set; }

        /// <summary>The updated write control after applying the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writeControl")]
        public virtual WriteControl WriteControl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The document body. The body typically contains the full document contents except for headers, footers and
    /// footnotes.
    /// </summary>
    public class Body : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The contents of the body. The indexes for the body's content begin at zero.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual System.Collections.Generic.IList<StructuralElement> Content { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes the bullet of a paragraph.</summary>
    public class Bullet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the list this paragraph belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listId")]
        public virtual string ListId { get; set; }

        /// <summary>The nesting level of this paragraph in the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nestingLevel")]
        public virtual System.Nullable<int> NestingLevel { get; set; }

        /// <summary>The paragraph specific text style applied to this bullet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textStyle")]
        public virtual TextStyle TextStyle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A mask that indicates which of the fields on the base Bullet have been changed in this suggestion. For any field
    /// set to true, there is a new suggested value.
    /// </summary>
    public class BulletSuggestionState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates if there was a suggested change to the list_id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listIdSuggested")]
        public virtual System.Nullable<bool> ListIdSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to the nesting_level.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nestingLevelSuggested")]
        public virtual System.Nullable<bool> NestingLevelSuggested { get; set; }

        /// <summary>
        /// A mask that indicates which of the fields in text style have been changed in this suggestion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textStyleSuggestionState")]
        public virtual TextStyleSuggestionState TextStyleSuggestionState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A solid color.</summary>
    public class Color : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The RGB color value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rgbColor")]
        public virtual RgbColor RgbColor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A ParagraphElement representing a column break. A column break makes the subsequent text start at the top of the
    /// next column.
    /// </summary>
    public class ColumnBreak : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The suggested deletion IDs. If empty, then there are no suggested deletions of this content.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedDeletionIds")]
        public virtual System.Collections.Generic.IList<string> SuggestedDeletionIds { get; set; }

        /// <summary>
        /// The suggested insertion IDs. A ColumnBreak may have multiple insertion IDs if it is a nested suggested
        /// change. If empty, then this is not a suggested insertion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedInsertionIds")]
        public virtual System.Collections.Generic.IList<string> SuggestedInsertionIds { get; set; }

        /// <summary>The suggested text style changes to this ColumnBreak, keyed by suggestion ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedTextStyleChanges")]
        public virtual System.Collections.Generic.IDictionary<string, SuggestedTextStyle> SuggestedTextStyleChanges { get; set; }

        /// <summary>
        /// The text style of this ColumnBreak. Similar to text content, like text runs and footnote references, the
        /// text style of a column break can affect content layout as well as the styling of text inserted adjacent to
        /// it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textStyle")]
        public virtual TextStyle TextStyle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Creates a Footer. The new footer is applied to the SectionStyle at the location of the SectionBreak if
    /// specificed, otherwise it is applied to the DocumentStyle. If a footer of the specified type already exists, a
    /// 400 bad request error is returned.
    /// </summary>
    public class CreateFooterRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The location of the SectionBreak immediately preceding the section whose SectionStyle this footer should
        /// belong to. If this is unset or refers to the first section break in the document, the footer applies to the
        /// document style.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sectionBreakLocation")]
        public virtual Location SectionBreakLocation { get; set; }

        /// <summary>The type of footer to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of creating a footer.</summary>
    public class CreateFooterResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the created footer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("footerId")]
        public virtual string FooterId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Creates a Footnote segment and inserts a new FootnoteReference to it at the given location. The new Footnote
    /// segment will contain a space followed by a newline character.
    /// </summary>
    public class CreateFootnoteRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Inserts the footnote reference at the end of the document body. Footnote references cannot be inserted
        /// inside a header, footer or footnote. Since footnote references can only be inserted in the body, the segment
        /// ID field must be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endOfSegmentLocation")]
        public virtual EndOfSegmentLocation EndOfSegmentLocation { get; set; }

        /// <summary>
        /// Inserts the footnote reference at a specific index in the document. The footnote reference must be inserted
        /// inside the bounds of an existing Paragraph. For instance, it cannot be inserted at a table's start index
        /// (i.e. between the table and its preceding paragraph). Footnote references cannot be inserted inside an
        /// equation, header, footer or footnote. Since footnote references can only be inserted in the body, the
        /// segment ID field must be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual Location Location { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of creating a footnote.</summary>
    public class CreateFootnoteResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the created footnote.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("footnoteId")]
        public virtual string FootnoteId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Creates a Header. The new header is applied to the SectionStyle at the location of the SectionBreak if
    /// specificed, otherwise it is applied to the DocumentStyle. If a header of the specified type already exists, a
    /// 400 bad request error is returned.
    /// </summary>
    public class CreateHeaderRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The location of the SectionBreak which begins the section this header should belong to. If
        /// `section_break_location' is unset or if it refers to the first section break in the document body, the
        /// header applies to the DocumentStyle
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sectionBreakLocation")]
        public virtual Location SectionBreakLocation { get; set; }

        /// <summary>The type of header to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of creating a header.</summary>
    public class CreateHeaderResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the created header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headerId")]
        public virtual string HeaderId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Creates a NamedRange referencing the given range.</summary>
    public class CreateNamedRangeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the NamedRange. Names do not need to be unique. Names must be at least 1 character and no more
        /// than 256 characters, measured in UTF-16 code units.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The range to apply the name to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual Range Range { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of creating a named range.</summary>
    public class CreateNamedRangeResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the created named range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namedRangeId")]
        public virtual string NamedRangeId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Creates bullets for all of the paragraphs that overlap with the given range. The nesting level of each paragraph
    /// will be determined by counting leading tabs in front of each paragraph. To avoid excess space between the bullet
    /// and the corresponding paragraph, these leading tabs are removed by this request. This may change the indices of
    /// parts of the text. If the paragraph immediately before paragraphs being updated is in a list with a matching
    /// preset, the paragraphs being updated are added to that preceding list.
    /// </summary>
    public class CreateParagraphBulletsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The kinds of bullet glyphs to be used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bulletPreset")]
        public virtual string BulletPreset { get; set; }

        /// <summary>The range to apply the bullet preset to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual Range Range { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The crop properties of an image. The crop rectangle is represented using fractional offsets from the original
    /// content's four edges. - If the offset is in the interval (0, 1), the corresponding edge of crop rectangle is
    /// positioned inside of the image's original bounding rectangle. - If the offset is negative or greater than 1, the
    /// corresponding edge of crop rectangle is positioned outside of the image's original bounding rectangle. - If all
    /// offsets and rotation angle are 0, the image is not cropped.
    /// </summary>
    public class CropProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The clockwise rotation angle of the crop rectangle around its center, in radians. Rotation is applied after
        /// the offsets.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("angle")]
        public virtual System.Nullable<float> Angle { get; set; }

        /// <summary>
        /// The offset specifies how far inwards the bottom edge of the crop rectangle is from the bottom edge of the
        /// original content as a fraction of the original content's height.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offsetBottom")]
        public virtual System.Nullable<float> OffsetBottom { get; set; }

        /// <summary>
        /// The offset specifies how far inwards the left edge of the crop rectangle is from the left edge of the
        /// original content as a fraction of the original content's width.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offsetLeft")]
        public virtual System.Nullable<float> OffsetLeft { get; set; }

        /// <summary>
        /// The offset specifies how far inwards the right edge of the crop rectangle is from the right edge of the
        /// original content as a fraction of the original content's width.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offsetRight")]
        public virtual System.Nullable<float> OffsetRight { get; set; }

        /// <summary>
        /// The offset specifies how far inwards the top edge of the crop rectangle is from the top edge of the original
        /// content as a fraction of the original content's height.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offsetTop")]
        public virtual System.Nullable<float> OffsetTop { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A mask that indicates which of the fields on the base CropProperties have been changed in this suggestion. For
    /// any field set to true, there is a new suggested value.
    /// </summary>
    public class CropPropertiesSuggestionState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates if there was a suggested change to angle.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("angleSuggested")]
        public virtual System.Nullable<bool> AngleSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to offset_bottom.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offsetBottomSuggested")]
        public virtual System.Nullable<bool> OffsetBottomSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to offset_left.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offsetLeftSuggested")]
        public virtual System.Nullable<bool> OffsetLeftSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to offset_right.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offsetRightSuggested")]
        public virtual System.Nullable<bool> OffsetRightSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to offset_top.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offsetTopSuggested")]
        public virtual System.Nullable<bool> OffsetTopSuggested { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Deletes content from the document.</summary>
    public class DeleteContentRangeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The range of content to delete. Deleting text that crosses a paragraph boundary may result in changes to
        /// paragraph styles, lists, positioned objects and bookmarks as the two paragraphs are merged. Attempting to
        /// delete certain ranges can result in an invalid document structure in which case a 400 bad request error is
        /// returned. Some examples of invalid delete requests include: * Deleting one code unit of a surrogate pair. *
        /// Deleting the last newline character of a Body, Header, Footer, Footnote, TableCell or TableOfContents. *
        /// Deleting the start or end of a Table, TableOfContents or Equation without deleting the entire element. *
        /// Deleting the newline character before a Table, TableOfContents or SectionBreak without deleting the element.
        /// * Deleting individual rows or cells of a table. Deleting the content within a table cell is allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual Range Range { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Deletes a Footer from the document.</summary>
    public class DeleteFooterRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The id of the footer to delete. If this footer is defined on DocumentStyle, the reference to this footer is
        /// removed, resulting in no footer of that type for the first section of the document. If this footer is
        /// defined on a SectionStyle, the reference to this footer is removed and the footer of that type is now
        /// continued from the previous section.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("footerId")]
        public virtual string FooterId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Deletes a Header from the document.</summary>
    public class DeleteHeaderRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The id of the header to delete. If this header is defined on DocumentStyle, the reference to this header is
        /// removed, resulting in no header of that type for the first section of the document. If this header is
        /// defined on a SectionStyle, the reference to this header is removed and the header of that type is now
        /// continued from the previous section.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headerId")]
        public virtual string HeaderId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Deletes a NamedRange.</summary>
    public class DeleteNamedRangeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the range(s) to delete. All named ranges with the given name will be deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ID of the named range to delete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namedRangeId")]
        public virtual string NamedRangeId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Deletes bullets from all of the paragraphs that overlap with the given range. The nesting level of each
    /// paragraph will be visually preserved by adding indent to the start of the corresponding paragraph.
    /// </summary>
    public class DeleteParagraphBulletsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The range to delete bullets from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual Range Range { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Deletes a PositionedObject from the document.</summary>
    public class DeletePositionedObjectRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the positioned object to delete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Deletes a column from a table.</summary>
    public class DeleteTableColumnRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The reference table cell location from which the column will be deleted. The column this cell spans will be
        /// deleted. If this is a merged cell that spans multiple columns, all columns that the cell spans will be
        /// deleted. If no columns remain in the table after this deletion, the whole table is deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableCellLocation")]
        public virtual TableCellLocation TableCellLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Deletes a row from a table.</summary>
    public class DeleteTableRowRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The reference table cell location from which the row will be deleted. The row this cell spans will be
        /// deleted. If this is a merged cell that spans multiple rows, all rows that the cell spans will be deleted. If
        /// no rows remain in the table after this deletion, the whole table is deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableCellLocation")]
        public virtual TableCellLocation TableCellLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A magnitude in a single direction in the specified units.</summary>
    public class Dimension : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The magnitude.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("magnitude")]
        public virtual System.Nullable<double> Magnitude { get; set; }

        /// <summary>The units for magnitude.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Google Docs document.</summary>
    public class Document : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The main body of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("body")]
        public virtual Body Body { get; set; }

        /// <summary>Output only. The ID of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentId")]
        public virtual string DocumentId { get; set; }

        /// <summary>Output only. The style of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentStyle")]
        public virtual DocumentStyle DocumentStyle { get; set; }

        /// <summary>Output only. The footers in the document, keyed by footer ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("footers")]
        public virtual System.Collections.Generic.IDictionary<string, Footer> Footers { get; set; }

        /// <summary>Output only. The footnotes in the document, keyed by footnote ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("footnotes")]
        public virtual System.Collections.Generic.IDictionary<string, Footnote> Footnotes { get; set; }

        /// <summary>Output only. The headers in the document, keyed by header ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headers")]
        public virtual System.Collections.Generic.IDictionary<string, Header> Headers { get; set; }

        /// <summary>Output only. The inline objects in the document, keyed by object ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inlineObjects")]
        public virtual System.Collections.Generic.IDictionary<string, InlineObject> InlineObjects { get; set; }

        /// <summary>Output only. The lists in the document, keyed by list ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lists")]
        public virtual System.Collections.Generic.IDictionary<string, List> Lists { get; set; }

        /// <summary>Output only. The named ranges in the document, keyed by name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namedRanges")]
        public virtual System.Collections.Generic.IDictionary<string, NamedRanges> NamedRanges { get; set; }

        /// <summary>Output only. The named styles of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namedStyles")]
        public virtual NamedStyles NamedStyles { get; set; }

        /// <summary>Output only. The positioned objects in the document, keyed by object ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("positionedObjects")]
        public virtual System.Collections.Generic.IDictionary<string, PositionedObject> PositionedObjects { get; set; }

        /// <summary>
        /// Output only. The revision ID of the document. Can be used in update requests to specify which revision of a
        /// document to apply updates to and how the request should behave if the document has been edited since that
        /// revision. Only populated if the user has edit access to the document. The format of the revision ID may
        /// change over time, so it should be treated opaquely. A returned revision ID is only guaranteed to be valid
        /// for 24 hours after it has been returned and cannot be shared across users. If the revision ID is unchanged
        /// between calls, then the document has not changed. Conversely, a changed ID (for the same document and user)
        /// usually means the document has been updated; however, a changed ID can also be due to internal factors such
        /// as ID format changes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>Output only. The suggested changes to the style of the document, keyed by suggestion ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedDocumentStyleChanges")]
        public virtual System.Collections.Generic.IDictionary<string, SuggestedDocumentStyle> SuggestedDocumentStyleChanges { get; set; }

        /// <summary>
        /// Output only. The suggested changes to the named styles of the document, keyed by suggestion ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedNamedStylesChanges")]
        public virtual System.Collections.Generic.IDictionary<string, SuggestedNamedStyles> SuggestedNamedStylesChanges { get; set; }

        /// <summary>
        /// Output only. The suggestions view mode applied to the document. Note: When editing a document, changes must
        /// be based on a document with SUGGESTIONS_INLINE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestionsViewMode")]
        public virtual string SuggestionsViewMode { get; set; }

        /// <summary>The title of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The style of the document.</summary>
    public class DocumentStyle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The background of the document. Documents cannot have a transparent background color.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("background")]
        public virtual Background Background { get; set; }

        /// <summary>
        /// The ID of the default footer. If not set, there is no default footer. This property is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultFooterId")]
        public virtual string DefaultFooterId { get; set; }

        /// <summary>
        /// The ID of the default header. If not set, there is no default header. This property is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultHeaderId")]
        public virtual string DefaultHeaderId { get; set; }

        /// <summary>
        /// The ID of the footer used only for even pages. The value of use_even_page_header_footer determines whether
        /// to use the default_footer_id or this value for the footer on even pages. If not set, there is no even page
        /// footer. This property is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evenPageFooterId")]
        public virtual string EvenPageFooterId { get; set; }

        /// <summary>
        /// The ID of the header used only for even pages. The value of use_even_page_header_footer determines whether
        /// to use the default_header_id or this value for the header on even pages. If not set, there is no even page
        /// header. This property is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evenPageHeaderId")]
        public virtual string EvenPageHeaderId { get; set; }

        /// <summary>
        /// The ID of the footer used only for the first page. If not set then a unique footer for the first page does
        /// not exist. The value of use_first_page_header_footer determines whether to use the default_footer_id or this
        /// value for the footer on the first page. If not set, there is no first page footer. This property is
        /// read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstPageFooterId")]
        public virtual string FirstPageFooterId { get; set; }

        /// <summary>
        /// The ID of the header used only for the first page. If not set then a unique header for the first page does
        /// not exist. The value of use_first_page_header_footer determines whether to use the default_header_id or this
        /// value for the header on the first page. If not set, there is no first page header. This property is
        /// read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstPageHeaderId")]
        public virtual string FirstPageHeaderId { get; set; }

        /// <summary>
        /// The bottom page margin. Updating the bottom page margin on the document style clears the bottom page margin
        /// on all section styles.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marginBottom")]
        public virtual Dimension MarginBottom { get; set; }

        /// <summary>The amount of space between the bottom of the page and the contents of the footer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marginFooter")]
        public virtual Dimension MarginFooter { get; set; }

        /// <summary>The amount of space between the top of the page and the contents of the header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marginHeader")]
        public virtual Dimension MarginHeader { get; set; }

        /// <summary>
        /// The left page margin. Updating the left page margin on the document style clears the left page margin on all
        /// section styles. It may also cause columns to resize in all sections.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marginLeft")]
        public virtual Dimension MarginLeft { get; set; }

        /// <summary>
        /// The right page margin. Updating the right page margin on the document style clears the right page margin on
        /// all section styles. It may also cause columns to resize in all sections.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marginRight")]
        public virtual Dimension MarginRight { get; set; }

        /// <summary>
        /// The top page margin. Updating the top page margin on the document style clears the top page margin on all
        /// section styles.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marginTop")]
        public virtual Dimension MarginTop { get; set; }

        /// <summary>The page number from which to start counting the number of pages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageNumberStart")]
        public virtual System.Nullable<int> PageNumberStart { get; set; }

        /// <summary>The size of a page in the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual Size PageSize { get; set; }

        /// <summary>
        /// Indicates whether DocumentStyle margin_header, SectionStyle margin_header and DocumentStyle margin_footer,
        /// SectionStyle margin_footer are respected. When false, the default values in the Docs editor for header and
        /// footer margin are used. This property is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useCustomHeaderFooterMargins")]
        public virtual System.Nullable<bool> UseCustomHeaderFooterMargins { get; set; }

        /// <summary>Indicates whether to use the even page header / footer IDs for the even pages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useEvenPageHeaderFooter")]
        public virtual System.Nullable<bool> UseEvenPageHeaderFooter { get; set; }

        /// <summary>Indicates whether to use the first page header / footer IDs for the first page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useFirstPageHeaderFooter")]
        public virtual System.Nullable<bool> UseFirstPageHeaderFooter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A mask that indicates which of the fields on the base DocumentStyle have been changed in this suggestion. For
    /// any field set to true, there is a new suggested value.
    /// </summary>
    public class DocumentStyleSuggestionState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A mask that indicates which of the fields in background have been changed in this suggestion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backgroundSuggestionState")]
        public virtual BackgroundSuggestionState BackgroundSuggestionState { get; set; }

        /// <summary>Indicates if there was a suggested change to default_footer_id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultFooterIdSuggested")]
        public virtual System.Nullable<bool> DefaultFooterIdSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to default_header_id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultHeaderIdSuggested")]
        public virtual System.Nullable<bool> DefaultHeaderIdSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to even_page_footer_id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evenPageFooterIdSuggested")]
        public virtual System.Nullable<bool> EvenPageFooterIdSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to even_page_header_id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evenPageHeaderIdSuggested")]
        public virtual System.Nullable<bool> EvenPageHeaderIdSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to first_page_footer_id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstPageFooterIdSuggested")]
        public virtual System.Nullable<bool> FirstPageFooterIdSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to first_page_header_id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstPageHeaderIdSuggested")]
        public virtual System.Nullable<bool> FirstPageHeaderIdSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to margin_bottom.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marginBottomSuggested")]
        public virtual System.Nullable<bool> MarginBottomSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to margin_footer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marginFooterSuggested")]
        public virtual System.Nullable<bool> MarginFooterSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to margin_header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marginHeaderSuggested")]
        public virtual System.Nullable<bool> MarginHeaderSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to margin_left.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marginLeftSuggested")]
        public virtual System.Nullable<bool> MarginLeftSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to margin_right.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marginRightSuggested")]
        public virtual System.Nullable<bool> MarginRightSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to margin_top.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marginTopSuggested")]
        public virtual System.Nullable<bool> MarginTopSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to page_number_start.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageNumberStartSuggested")]
        public virtual System.Nullable<bool> PageNumberStartSuggested { get; set; }

        /// <summary>A mask that indicates which of the fields in size have been changed in this suggestion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSizeSuggestionState")]
        public virtual SizeSuggestionState PageSizeSuggestionState { get; set; }

        /// <summary>Indicates if there was a suggested change to use_custom_header_footer_margins.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useCustomHeaderFooterMarginsSuggested")]
        public virtual System.Nullable<bool> UseCustomHeaderFooterMarginsSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to use_even_page_header_footer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useEvenPageHeaderFooterSuggested")]
        public virtual System.Nullable<bool> UseEvenPageHeaderFooterSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to use_first_page_header_footer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useFirstPageHeaderFooterSuggested")]
        public virtual System.Nullable<bool> UseFirstPageHeaderFooterSuggested { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of an embedded drawing.</summary>
    public class EmbeddedDrawingProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A mask that indicates which of the fields on the base EmbeddedDrawingProperties have been changed in this
    /// suggestion. For any field set to true, there is a new suggested value.
    /// </summary>
    public class EmbeddedDrawingPropertiesSuggestionState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An embedded object in the document.</summary>
    public class EmbeddedObject : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The description of the embedded object. The `title` and `description` are both combined to display alt text.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The properties of an embedded drawing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("embeddedDrawingProperties")]
        public virtual EmbeddedDrawingProperties EmbeddedDrawingProperties { get; set; }

        /// <summary>The border of the embedded object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("embeddedObjectBorder")]
        public virtual EmbeddedObjectBorder EmbeddedObjectBorder { get; set; }

        /// <summary>The properties of an image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageProperties")]
        public virtual ImageProperties ImageProperties { get; set; }

        /// <summary>
        /// A reference to the external linked source content. For example, it contains a reference to the source Sheets
        /// chart when the embedded object is a linked chart. If unset, then the embedded object is not linked.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkedContentReference")]
        public virtual LinkedContentReference LinkedContentReference { get; set; }

        /// <summary>The bottom margin of the embedded object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marginBottom")]
        public virtual Dimension MarginBottom { get; set; }

        /// <summary>The left margin of the embedded object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marginLeft")]
        public virtual Dimension MarginLeft { get; set; }

        /// <summary>The right margin of the embedded object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marginRight")]
        public virtual Dimension MarginRight { get; set; }

        /// <summary>The top margin of the embedded object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marginTop")]
        public virtual Dimension MarginTop { get; set; }

        /// <summary>The visible size of the image after cropping.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("size")]
        public virtual Size Size { get; set; }

        /// <summary>
        /// The title of the embedded object. The `title` and `description` are both combined to display alt text.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A border around an EmbeddedObject.</summary>
    public class EmbeddedObjectBorder : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The color of the border.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual OptionalColor Color { get; set; }

        /// <summary>The dash style of the border.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dashStyle")]
        public virtual string DashStyle { get; set; }

        /// <summary>The property state of the border property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("propertyState")]
        public virtual string PropertyState { get; set; }

        /// <summary>The width of the border.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual Dimension Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A mask that indicates which of the fields on the base EmbeddedObjectBorder have been changed in this suggestion.
    /// For any field set to true, there is a new suggested value.
    /// </summary>
    public class EmbeddedObjectBorderSuggestionState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates if there was a suggested change to color.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colorSuggested")]
        public virtual System.Nullable<bool> ColorSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to dash_style.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dashStyleSuggested")]
        public virtual System.Nullable<bool> DashStyleSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to property_state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("propertyStateSuggested")]
        public virtual System.Nullable<bool> PropertyStateSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to width.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("widthSuggested")]
        public virtual System.Nullable<bool> WidthSuggested { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A mask that indicates which of the fields on the base EmbeddedObject have been changed in this suggestion. For
    /// any field set to true, there is a new suggested value.
    /// </summary>
    public class EmbeddedObjectSuggestionState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates if there was a suggested change to description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("descriptionSuggested")]
        public virtual System.Nullable<bool> DescriptionSuggested { get; set; }

        /// <summary>
        /// A mask that indicates which of the fields in embedded_drawing_properties have been changed in this
        /// suggestion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("embeddedDrawingPropertiesSuggestionState")]
        public virtual EmbeddedDrawingPropertiesSuggestionState EmbeddedDrawingPropertiesSuggestionState { get; set; }

        /// <summary>
        /// A mask that indicates which of the fields in embedded_object_border have been changed in this suggestion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("embeddedObjectBorderSuggestionState")]
        public virtual EmbeddedObjectBorderSuggestionState EmbeddedObjectBorderSuggestionState { get; set; }

        /// <summary>
        /// A mask that indicates which of the fields in image_properties have been changed in this suggestion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imagePropertiesSuggestionState")]
        public virtual ImagePropertiesSuggestionState ImagePropertiesSuggestionState { get; set; }

        /// <summary>
        /// A mask that indicates which of the fields in linked_content_reference have been changed in this suggestion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkedContentReferenceSuggestionState")]
        public virtual LinkedContentReferenceSuggestionState LinkedContentReferenceSuggestionState { get; set; }

        /// <summary>Indicates if there was a suggested change to margin_bottom.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marginBottomSuggested")]
        public virtual System.Nullable<bool> MarginBottomSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to margin_left.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marginLeftSuggested")]
        public virtual System.Nullable<bool> MarginLeftSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to margin_right.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marginRightSuggested")]
        public virtual System.Nullable<bool> MarginRightSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to margin_top.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marginTopSuggested")]
        public virtual System.Nullable<bool> MarginTopSuggested { get; set; }

        /// <summary>A mask that indicates which of the fields in size have been changed in this suggestion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeSuggestionState")]
        public virtual SizeSuggestionState SizeSuggestionState { get; set; }

        /// <summary>Indicates if there was a suggested change to title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("titleSuggested")]
        public virtual System.Nullable<bool> TitleSuggested { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Location at the end of a body, header, footer or footnote. The location is immediately before the last newline
    /// in the document segment.
    /// </summary>
    public class EndOfSegmentLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The ID of the header, footer or footnote the location is in. An empty segment ID signifies the document's
        /// body.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segmentId")]
        public virtual string SegmentId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A ParagraphElement representing an equation.</summary>
    public class Equation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The suggested deletion IDs. If empty, then there are no suggested deletions of this content.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedDeletionIds")]
        public virtual System.Collections.Generic.IList<string> SuggestedDeletionIds { get; set; }

        /// <summary>
        /// The suggested insertion IDs. A Equation may have multiple insertion IDs if it is a nested suggested change.
        /// If empty, then this is not a suggested insertion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedInsertionIds")]
        public virtual System.Collections.Generic.IList<string> SuggestedInsertionIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A document footer.</summary>
    public class Footer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The contents of the footer. The indexes for a footer's content begin at zero.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual System.Collections.Generic.IList<StructuralElement> Content { get; set; }

        /// <summary>The ID of the footer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("footerId")]
        public virtual string FooterId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A document footnote.</summary>
    public class Footnote : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The contents of the footnote. The indexes for a footnote's content begin at zero.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual System.Collections.Generic.IList<StructuralElement> Content { get; set; }

        /// <summary>The ID of the footnote.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("footnoteId")]
        public virtual string FootnoteId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A ParagraphElement representing a footnote reference. A footnote reference is the inline content rendered with a
    /// number and is used to identify the footnote.
    /// </summary>
    public class FootnoteReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the footnote that contains the content of this footnote reference.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("footnoteId")]
        public virtual string FootnoteId { get; set; }

        /// <summary>The rendered number of this footnote.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("footnoteNumber")]
        public virtual string FootnoteNumber { get; set; }

        /// <summary>
        /// The suggested deletion IDs. If empty, then there are no suggested deletions of this content.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedDeletionIds")]
        public virtual System.Collections.Generic.IList<string> SuggestedDeletionIds { get; set; }

        /// <summary>
        /// The suggested insertion IDs. A FootnoteReference may have multiple insertion IDs if it is a nested suggested
        /// change. If empty, then this is not a suggested insertion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedInsertionIds")]
        public virtual System.Collections.Generic.IList<string> SuggestedInsertionIds { get; set; }

        /// <summary>The suggested text style changes to this FootnoteReference, keyed by suggestion ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedTextStyleChanges")]
        public virtual System.Collections.Generic.IDictionary<string, SuggestedTextStyle> SuggestedTextStyleChanges { get; set; }

        /// <summary>The text style of this FootnoteReference.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textStyle")]
        public virtual TextStyle TextStyle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A document header.</summary>
    public class Header : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The contents of the header. The indexes for a header's content begin at zero.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual System.Collections.Generic.IList<StructuralElement> Content { get; set; }

        /// <summary>The ID of the header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headerId")]
        public virtual string HeaderId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A ParagraphElement representing a horizontal line.</summary>
    public class HorizontalRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The suggested deletion IDs. If empty, then there are no suggested deletions of this content.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedDeletionIds")]
        public virtual System.Collections.Generic.IList<string> SuggestedDeletionIds { get; set; }

        /// <summary>
        /// The suggested insertion IDs. A HorizontalRule may have multiple insertion IDs if it is a nested suggested
        /// change. If empty, then this is not a suggested insertion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedInsertionIds")]
        public virtual System.Collections.Generic.IList<string> SuggestedInsertionIds { get; set; }

        /// <summary>The suggested text style changes to this HorizontalRule, keyed by suggestion ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedTextStyleChanges")]
        public virtual System.Collections.Generic.IDictionary<string, SuggestedTextStyle> SuggestedTextStyleChanges { get; set; }

        /// <summary>
        /// The text style of this HorizontalRule. Similar to text content, like text runs and footnote references, the
        /// text style of a horizontal rule can affect content layout as well as the styling of text inserted adjacent
        /// to it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textStyle")]
        public virtual TextStyle TextStyle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of an image.</summary>
    public class ImageProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The clockwise rotation angle of the image, in radians.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("angle")]
        public virtual System.Nullable<float> Angle { get; set; }

        /// <summary>
        /// The brightness effect of the image. The value should be in the interval [-1.0, 1.0], where 0 means no
        /// effect.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("brightness")]
        public virtual System.Nullable<float> Brightness { get; set; }

        /// <summary>
        /// A URI to the image with a default lifetime of 30 minutes. This URI is tagged with the account of the
        /// requester. Anyone with the URI effectively accesses the image as the original requester. Access to the image
        /// may be lost if the document's sharing settings change.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentUri")]
        public virtual string ContentUri { get; set; }

        /// <summary>
        /// The contrast effect of the image. The value should be in the interval [-1.0, 1.0], where 0 means no effect.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contrast")]
        public virtual System.Nullable<float> Contrast { get; set; }

        /// <summary>The crop properties of the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cropProperties")]
        public virtual CropProperties CropProperties { get; set; }

        /// <summary>The source URI is the URI used to insert the image. The source URI can be empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceUri")]
        public virtual string SourceUri { get; set; }

        /// <summary>
        /// The transparency effect of the image. The value should be in the interval [0.0, 1.0], where 0 means no
        /// effect and 1 means completely transparent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transparency")]
        public virtual System.Nullable<float> Transparency { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A mask that indicates which of the fields on the base ImageProperties have been changed in this suggestion. For
    /// any field set to true, there is a new suggested value.
    /// </summary>
    public class ImagePropertiesSuggestionState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates if there was a suggested change to angle.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("angleSuggested")]
        public virtual System.Nullable<bool> AngleSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to brightness.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("brightnessSuggested")]
        public virtual System.Nullable<bool> BrightnessSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to content_uri.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentUriSuggested")]
        public virtual System.Nullable<bool> ContentUriSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to contrast.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contrastSuggested")]
        public virtual System.Nullable<bool> ContrastSuggested { get; set; }

        /// <summary>
        /// A mask that indicates which of the fields in crop_properties have been changed in this suggestion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cropPropertiesSuggestionState")]
        public virtual CropPropertiesSuggestionState CropPropertiesSuggestionState { get; set; }

        /// <summary>Indicates if there was a suggested change to source_uri.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceUriSuggested")]
        public virtual System.Nullable<bool> SourceUriSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to transparency.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transparencySuggested")]
        public virtual System.Nullable<bool> TransparencySuggested { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An object that appears inline with text. An InlineObject contains an EmbeddedObject such as an image.
    /// </summary>
    public class InlineObject : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The properties of this inline object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inlineObjectProperties")]
        public virtual InlineObjectProperties InlineObjectProperties { get; set; }

        /// <summary>The ID of this inline object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>
        /// The suggested deletion IDs. If empty, then there are no suggested deletions of this content.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedDeletionIds")]
        public virtual System.Collections.Generic.IList<string> SuggestedDeletionIds { get; set; }

        /// <summary>The suggested changes to the inline object properties, keyed by suggestion ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedInlineObjectPropertiesChanges")]
        public virtual System.Collections.Generic.IDictionary<string, SuggestedInlineObjectProperties> SuggestedInlineObjectPropertiesChanges { get; set; }

        /// <summary>The suggested insertion ID. If empty, then this is not a suggested insertion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedInsertionId")]
        public virtual string SuggestedInsertionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A ParagraphElement that contains an InlineObject.</summary>
    public class InlineObjectElement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the InlineObject this element contains.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inlineObjectId")]
        public virtual string InlineObjectId { get; set; }

        /// <summary>
        /// The suggested deletion IDs. If empty, then there are no suggested deletions of this content.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedDeletionIds")]
        public virtual System.Collections.Generic.IList<string> SuggestedDeletionIds { get; set; }

        /// <summary>
        /// The suggested insertion IDs. An InlineObjectElement may have multiple insertion IDs if it is a nested
        /// suggested change. If empty, then this is not a suggested insertion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedInsertionIds")]
        public virtual System.Collections.Generic.IList<string> SuggestedInsertionIds { get; set; }

        /// <summary>The suggested text style changes to this InlineObject, keyed by suggestion ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedTextStyleChanges")]
        public virtual System.Collections.Generic.IDictionary<string, SuggestedTextStyle> SuggestedTextStyleChanges { get; set; }

        /// <summary>
        /// The text style of this InlineObjectElement. Similar to text content, like text runs and footnote references,
        /// the text style of an inline object element can affect content layout as well as the styling of text inserted
        /// adjacent to it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textStyle")]
        public virtual TextStyle TextStyle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Properties of an InlineObject.</summary>
    public class InlineObjectProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The embedded object of this inline object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("embeddedObject")]
        public virtual EmbeddedObject EmbeddedObject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A mask that indicates which of the fields on the base InlineObjectProperties have been changed in this
    /// suggestion. For any field set to true, there is a new suggested value.
    /// </summary>
    public class InlineObjectPropertiesSuggestionState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A mask that indicates which of the fields in embedded_object have been changed in this suggestion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("embeddedObjectSuggestionState")]
        public virtual EmbeddedObjectSuggestionState EmbeddedObjectSuggestionState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Inserts an InlineObject containing an image at the given location.</summary>
    public class InsertInlineImageRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Inserts the text at the end of a header, footer or the document body. Inline images cannot be inserted
        /// inside a footnote.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endOfSegmentLocation")]
        public virtual EndOfSegmentLocation EndOfSegmentLocation { get; set; }

        /// <summary>
        /// Inserts the image at a specific index in the document. The image must be inserted inside the bounds of an
        /// existing Paragraph. For instance, it cannot be inserted at a table's start index (i.e. between the table and
        /// its preceding paragraph). Inline images cannot be inserted inside a footnote or equation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual Location Location { get; set; }

        /// <summary>
        /// The size that the image should appear as in the document. This property is optional and the final size of
        /// the image in the document is determined by the following rules: * If neither width nor height is specified,
        /// then a default size of the image is calculated based on its resolution. * If one dimension is specified then
        /// the other dimension is calculated to preserve the aspect ratio of the image. * If both width and height are
        /// specified, the image is scaled to fit within the provided dimensions while maintaining its aspect ratio.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectSize")]
        public virtual Size ObjectSize { get; set; }

        /// <summary>
        /// The image URI. The image is fetched once at insertion time and a copy is stored for display inside the
        /// document. Images must be less than 50MB in size, cannot exceed 25 megapixels, and must be in one of PNG,
        /// JPEG, or GIF format. The provided URI can be at most 2 kB in length. The URI itself is saved with the image,
        /// and exposed via the ImageProperties.content_uri field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of inserting an inline image.</summary>
    public class InsertInlineImageResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the created InlineObject.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of inserting an embedded Google Sheets chart.</summary>
    public class InsertInlineSheetsChartResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The object ID of the inserted chart.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Inserts a page break followed by a newline at the specified location.</summary>
    public class InsertPageBreakRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Inserts the page break at the end of the document body. Page breaks cannot be inserted inside a footnote,
        /// header or footer. Since page breaks can only be inserted inside the body, the segment ID field must be
        /// empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endOfSegmentLocation")]
        public virtual EndOfSegmentLocation EndOfSegmentLocation { get; set; }

        /// <summary>
        /// Inserts the page break at a specific index in the document. The page break must be inserted inside the
        /// bounds of an existing Paragraph. For instance, it cannot be inserted at a table's start index (i.e. between
        /// the table and its preceding paragraph). Page breaks cannot be inserted inside a table, equation, footnote,
        /// header or footer. Since page breaks can only be inserted inside the body, the segment ID field must be
        /// empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual Location Location { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Inserts a section break at the given location. A newline character will be inserted before the section break.
    /// </summary>
    public class InsertSectionBreakRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Inserts a newline and a section break at the end of the document body. Section breaks cannot be inserted
        /// inside a footnote, header or footer. Because section breaks can only be inserted inside the body, the
        /// segment ID field must be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endOfSegmentLocation")]
        public virtual EndOfSegmentLocation EndOfSegmentLocation { get; set; }

        /// <summary>
        /// Inserts a newline and a section break at a specific index in the document. The section break must be
        /// inserted inside the bounds of an existing Paragraph. For instance, it cannot be inserted at a table's start
        /// index (i.e. between the table and its preceding paragraph). Section breaks cannot be inserted inside a
        /// table, equation, footnote, header, or footer. Since section breaks can only be inserted inside the body, the
        /// segment ID field must be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual Location Location { get; set; }

        /// <summary>The type of section to insert.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sectionType")]
        public virtual string SectionType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Inserts an empty column into a table.</summary>
    public class InsertTableColumnRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether to insert new column to the right of the reference cell location. - `True`: insert to the right. -
        /// `False`: insert to the left.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertRight")]
        public virtual System.Nullable<bool> InsertRight { get; set; }

        /// <summary>
        /// The reference table cell location from which columns will be inserted. A new column will be inserted to the
        /// left (or right) of the column where the reference cell is. If the reference cell is a merged cell, a new
        /// column will be inserted to the left (or right) of the merged cell.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableCellLocation")]
        public virtual TableCellLocation TableCellLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Inserts a table at the specified location. A newline character will be inserted before the inserted table.
    /// </summary>
    public class InsertTableRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of columns in the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columns")]
        public virtual System.Nullable<int> Columns { get; set; }

        /// <summary>
        /// Inserts the table at the end of the given header, footer or document body. A newline character will be
        /// inserted before the inserted table. Tables cannot be inserted inside a footnote.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endOfSegmentLocation")]
        public virtual EndOfSegmentLocation EndOfSegmentLocation { get; set; }

        /// <summary>
        /// Inserts the table at a specific model index. A newline character will be inserted before the inserted table,
        /// therefore the table start index will be at the specified location index + 1. The table must be inserted
        /// inside the bounds of an existing Paragraph. For instance, it cannot be inserted at a table's start index
        /// (i.e. between an existing table and its preceding paragraph). Tables cannot be inserted inside a footnote or
        /// equation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual Location Location { get; set; }

        /// <summary>The number of rows in the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Nullable<int> Rows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Inserts an empty row into a table.</summary>
    public class InsertTableRowRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether to insert new row below the reference cell location. - `True`: insert below the cell. - `False`:
        /// insert above the cell.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertBelow")]
        public virtual System.Nullable<bool> InsertBelow { get; set; }

        /// <summary>
        /// The reference table cell location from which rows will be inserted. A new row will be inserted above (or
        /// below) the row where the reference cell is. If the reference cell is a merged cell, a new row will be
        /// inserted above (or below) the merged cell.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableCellLocation")]
        public virtual TableCellLocation TableCellLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Inserts text at the specified location.</summary>
    public class InsertTextRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Inserts the text at the end of a header, footer, footnote or the document body.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endOfSegmentLocation")]
        public virtual EndOfSegmentLocation EndOfSegmentLocation { get; set; }

        /// <summary>
        /// Inserts the text at a specific index in the document. Text must be inserted inside the bounds of an existing
        /// Paragraph. For instance, text cannot be inserted at a table's start index (i.e. between the table and its
        /// preceding paragraph). The text must be inserted in the preceding paragraph.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual Location Location { get; set; }

        /// <summary>
        /// The text to be inserted. Inserting a newline character will implicitly create a new Paragraph at that index.
        /// The paragraph style of the new paragraph will be copied from the paragraph at the current insertion index,
        /// including lists and bullets. Text styles for inserted text will be determined automatically, generally
        /// preserving the styling of neighboring text. In most cases, the text style for the inserted text will match
        /// the text immediately before the insertion index. Some control characters (U+0000-U+0008, U+000C-U+001F) and
        /// characters from the Unicode Basic Multilingual Plane Private Use Area (U+E000-U+F8FF) will be stripped out
        /// of the inserted text.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A reference to another portion of a document or an external URL resource.</summary>
    public class Link : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of a bookmark in this document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bookmarkId")]
        public virtual string BookmarkId { get; set; }

        /// <summary>The ID of a heading in this document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headingId")]
        public virtual string HeadingId { get; set; }

        /// <summary>An external URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A reference to the external linked source content.</summary>
    public class LinkedContentReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A reference to the linked chart.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sheetsChartReference")]
        public virtual SheetsChartReference SheetsChartReference { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A mask that indicates which of the fields on the base LinkedContentReference have been changed in this
    /// suggestion. For any field set to true, there is a new suggested value.
    /// </summary>
    public class LinkedContentReferenceSuggestionState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A mask that indicates which of the fields in sheets_chart_reference have been changed in this suggestion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sheetsChartReferenceSuggestionState")]
        public virtual SheetsChartReferenceSuggestionState SheetsChartReferenceSuggestionState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A List represents the list attributes for a group of paragraphs that all belong to the same list. A paragraph
    /// that is part of a list has a reference to the list's ID in its bullet.
    /// </summary>
    public class List : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The properties of the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listProperties")]
        public virtual ListProperties ListProperties { get; set; }

        /// <summary>The suggested deletion IDs. If empty, then there are no suggested deletions of this list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedDeletionIds")]
        public virtual System.Collections.Generic.IList<string> SuggestedDeletionIds { get; set; }

        /// <summary>The suggested insertion ID. If empty, then this is not a suggested insertion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedInsertionId")]
        public virtual string SuggestedInsertionId { get; set; }

        /// <summary>The suggested changes to the list properties, keyed by suggestion ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedListPropertiesChanges")]
        public virtual System.Collections.Generic.IDictionary<string, SuggestedListProperties> SuggestedListPropertiesChanges { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The properties of a list which describe the look and feel of bullets belonging to paragraphs associated with a
    /// list.
    /// </summary>
    public class ListProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Describes the properties of the bullets at the associated level. A list has at most nine levels of nesting
        /// with nesting level 0 corresponding to the top-most level and nesting level 8 corresponding to the most
        /// nested level. The nesting levels are returned in ascending order with the least nested returned first.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nestingLevels")]
        public virtual System.Collections.Generic.IList<NestingLevel> NestingLevels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A mask that indicates which of the fields on the base ListProperties have been changed in this suggestion. For
    /// any field set to true, there is a new suggested value.
    /// </summary>
    public class ListPropertiesSuggestionState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A mask that indicates which of the fields on the corresponding NestingLevel in nesting_levels have been
        /// changed in this suggestion. The nesting level suggestion states are returned in ascending order of the
        /// nesting level with the least nested returned first.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nestingLevelsSuggestionStates")]
        public virtual System.Collections.Generic.IList<NestingLevelSuggestionState> NestingLevelsSuggestionStates { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A particular location in the document.</summary>
    public class Location : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The zero-based index, in UTF-16 code units. The index is relative to the beginning of the segment specified
        /// by segment_id.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual System.Nullable<int> Index { get; set; }

        /// <summary>
        /// The ID of the header, footer or footnote the location is in. An empty segment ID signifies the document's
        /// body.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segmentId")]
        public virtual string SegmentId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Merges cells in a Table.</summary>
    public class MergeTableCellsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The table range specifying which cells of the table to merge. Any text in the cells being merged will be
        /// concatenated and stored in the "head" cell of the range. This is the upper-left cell of the range when the
        /// content direction is left to right, and the upper-right cell of the range otherwise. If the range is
        /// non-rectangular (which can occur in some cases where the range covers cells that are already merged or where
        /// the table is non-rectangular), a 400 bad request error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableRange")]
        public virtual TableRange TableRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A collection of Ranges with the same named range ID. Named ranges allow developers to associate parts of a
    /// document with an arbitrary user-defined label so their contents can be programmatically read or edited at a
    /// later time. A document can contain multiple named ranges with the same name, but every named range has a unique
    /// ID. A named range is created with a single Range, and content inserted inside a named range generally expands
    /// that range. However, certain document changes can cause the range to be split into multiple ranges. Named ranges
    /// are not private. All applications and collaborators that have access to the document can see its named ranges.
    /// </summary>
    public class NamedRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the named range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ID of the named range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namedRangeId")]
        public virtual string NamedRangeId { get; set; }

        /// <summary>The ranges that belong to this named range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ranges")]
        public virtual System.Collections.Generic.IList<Range> Ranges { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A collection of all the NamedRanges in the document that share a given name.</summary>
    public class NamedRanges : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name that all the named ranges share.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The NamedRanges that share the same name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namedRanges")]
        public virtual System.Collections.Generic.IList<NamedRange> NamedRangesValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A named style. Paragraphs in the document can inherit their TextStyle and ParagraphStyle from this named style
    /// when they have the same named style type.
    /// </summary>
    public class NamedStyle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of this named style.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namedStyleType")]
        public virtual string NamedStyleType { get; set; }

        /// <summary>The paragraph style of this named style.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paragraphStyle")]
        public virtual ParagraphStyle ParagraphStyle { get; set; }

        /// <summary>The text style of this named style.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textStyle")]
        public virtual TextStyle TextStyle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A suggestion state of a NamedStyle message.</summary>
    public class NamedStyleSuggestionState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The named style type that this suggestion state corresponds to. This field is provided as a convenience for
        /// matching the NamedStyleSuggestionState with its corresponding NamedStyle.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namedStyleType")]
        public virtual string NamedStyleType { get; set; }

        /// <summary>
        /// A mask that indicates which of the fields in paragraph style have been changed in this suggestion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paragraphStyleSuggestionState")]
        public virtual ParagraphStyleSuggestionState ParagraphStyleSuggestionState { get; set; }

        /// <summary>
        /// A mask that indicates which of the fields in text style have been changed in this suggestion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textStyleSuggestionState")]
        public virtual TextStyleSuggestionState TextStyleSuggestionState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The named styles. Paragraphs in the document can inherit their TextStyle and ParagraphStyle from these named
    /// styles.
    /// </summary>
    public class NamedStyles : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The named styles. There is an entry for each of the possible named style types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("styles")]
        public virtual System.Collections.Generic.IList<NamedStyle> Styles { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The suggestion state of a NamedStyles message.</summary>
    public class NamedStylesSuggestionState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A mask that indicates which of the fields on the corresponding NamedStyle in styles have been changed in
        /// this suggestion. The order of these named style suggestion states match the order of the corresponding named
        /// style within the named styles suggestion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stylesSuggestionStates")]
        public virtual System.Collections.Generic.IList<NamedStyleSuggestionState> StylesSuggestionStates { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains properties describing the look and feel of a list bullet at a given level of nesting.
    /// </summary>
    public class NestingLevel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The alignment of the bullet within the space allotted for rendering the bullet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bulletAlignment")]
        public virtual string BulletAlignment { get; set; }

        /// <summary>
        /// The format string used by bullets at this level of nesting. The glyph format contains one or more
        /// placeholders, and these placeholder are replaced with the appropriate values depending on the glyph_type or
        /// glyph_symbol. The placeholders follow the pattern `%[nesting_level]`. Furthermore, placeholders can have
        /// prefixes and suffixes. Thus, the glyph format follows the pattern `%[nesting_level]`. Note that the prefix
        /// and suffix are optional and can be arbitrary strings. For example, the glyph format `%0.` indicates that the
        /// rendered glyph will replace the placeholder with the corresponding glyph for nesting level 0 followed by a
        /// period as the suffix. So a list with a glyph type of UPPER_ALPHA and glyph format `%0.` at nesting level 0
        /// will result in a list with rendered glyphs `A.` `B.` `C.` The glyph format can contain placeholders for the
        /// current nesting level as well as placeholders for parent nesting levels. For example, a list can have a
        /// glyph format of `%0.` at nesting level 0 and a glyph format of `%0.%1.` at nesting level 1. Assuming both
        /// nesting levels have DECIMAL glyph types, this would result in a list with rendered glyphs `1.` `2.` ` 2.1.`
        /// ` 2.2.` `3.` For nesting levels that are ordered, the string that replaces a placeholder in the glyph format
        /// for a particular paragraph depends on the paragraph's order within the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("glyphFormat")]
        public virtual string GlyphFormat { get; set; }

        /// <summary>
        /// A custom glyph symbol used by bullets when paragraphs at this level of nesting are unordered. The glyph
        /// symbol replaces placeholders within the glyph_format. For example, if the glyph_symbol is the solid circle
        /// corresponding to Unicode U+25cf code point and the glyph_format is `%0`, the rendered glyph would be the
        /// solid circle.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("glyphSymbol")]
        public virtual string GlyphSymbol { get; set; }

        /// <summary>
        /// The type of glyph used by bullets when paragraphs at this level of nesting are ordered. The glyph type
        /// determines the type of glyph used to replace placeholders within the glyph_format when paragraphs at this
        /// level of nesting are ordered. For example, if the nesting level is 0, the glyph_format is `%0.` and the
        /// glyph type is DECIMAL, then the rendered glyph would replace the placeholder `%0` in the glyph format with a
        /// number corresponding to list item's order within the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("glyphType")]
        public virtual string GlyphType { get; set; }

        /// <summary>The amount of indentation for the first line of paragraphs at this level of nesting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indentFirstLine")]
        public virtual Dimension IndentFirstLine { get; set; }

        /// <summary>
        /// The amount of indentation for paragraphs at this level of nesting. Applied to the side that corresponds to
        /// the start of the text, based on the paragraph's content direction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indentStart")]
        public virtual Dimension IndentStart { get; set; }

        /// <summary>
        /// The number of the first list item at this nesting level. A value of 0 is treated as a value of 1 for
        /// lettered lists and roman numeraled lists, i.e. for values of both 0 and 1, lettered and roman numeraled
        /// lists will begin at `a` and `i` respectively. This value is ignored for nesting levels with unordered
        /// glyphs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startNumber")]
        public virtual System.Nullable<int> StartNumber { get; set; }

        /// <summary>The text style of bullets at this level of nesting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textStyle")]
        public virtual TextStyle TextStyle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A mask that indicates which of the fields on the base NestingLevel have been changed in this suggestion. For any
    /// field set to true, there is a new suggested value.
    /// </summary>
    public class NestingLevelSuggestionState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates if there was a suggested change to bullet_alignment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bulletAlignmentSuggested")]
        public virtual System.Nullable<bool> BulletAlignmentSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to glyph_format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("glyphFormatSuggested")]
        public virtual System.Nullable<bool> GlyphFormatSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to glyph_symbol.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("glyphSymbolSuggested")]
        public virtual System.Nullable<bool> GlyphSymbolSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to glyph_type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("glyphTypeSuggested")]
        public virtual System.Nullable<bool> GlyphTypeSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to indent_first_line.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indentFirstLineSuggested")]
        public virtual System.Nullable<bool> IndentFirstLineSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to indent_start.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indentStartSuggested")]
        public virtual System.Nullable<bool> IndentStartSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to start_number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startNumberSuggested")]
        public virtual System.Nullable<bool> StartNumberSuggested { get; set; }

        /// <summary>
        /// A mask that indicates which of the fields in text style have been changed in this suggestion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textStyleSuggestionState")]
        public virtual TextStyleSuggestionState TextStyleSuggestionState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A collection of object IDs.</summary>
    public class ObjectReferences : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The object IDs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectIds")]
        public virtual System.Collections.Generic.IList<string> ObjectIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A color that can either be fully opaque or fully transparent.</summary>
    public class OptionalColor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If set, this will be used as an opaque color. If unset, this represents a transparent color.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual Color Color { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A ParagraphElement representing a page break. A page break makes the subsequent text start at the top of the
    /// next page.
    /// </summary>
    public class PageBreak : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The suggested deletion IDs. If empty, then there are no suggested deletions of this content.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedDeletionIds")]
        public virtual System.Collections.Generic.IList<string> SuggestedDeletionIds { get; set; }

        /// <summary>
        /// The suggested insertion IDs. A PageBreak may have multiple insertion IDs if it is a nested suggested change.
        /// If empty, then this is not a suggested insertion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedInsertionIds")]
        public virtual System.Collections.Generic.IList<string> SuggestedInsertionIds { get; set; }

        /// <summary>The suggested text style changes to this PageBreak, keyed by suggestion ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedTextStyleChanges")]
        public virtual System.Collections.Generic.IDictionary<string, SuggestedTextStyle> SuggestedTextStyleChanges { get; set; }

        /// <summary>
        /// The text style of this PageBreak. Similar to text content, like text runs and footnote references, the text
        /// style of a page break can affect content layout as well as the styling of text inserted adjacent to it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textStyle")]
        public virtual TextStyle TextStyle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A StructuralElement representing a paragraph. A paragraph is a range of content that is terminated with a
    /// newline character.
    /// </summary>
    public class Paragraph : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The bullet for this paragraph. If not present, the paragraph does not belong to a list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bullet")]
        public virtual Bullet Bullet { get; set; }

        /// <summary>The content of the paragraph broken down into its component parts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("elements")]
        public virtual System.Collections.Generic.IList<ParagraphElement> Elements { get; set; }

        /// <summary>The style of this paragraph.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paragraphStyle")]
        public virtual ParagraphStyle ParagraphStyle { get; set; }

        /// <summary>The IDs of the positioned objects tethered to this paragraph.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("positionedObjectIds")]
        public virtual System.Collections.Generic.IList<string> PositionedObjectIds { get; set; }

        /// <summary>The suggested changes to this paragraph's bullet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedBulletChanges")]
        public virtual System.Collections.Generic.IDictionary<string, SuggestedBullet> SuggestedBulletChanges { get; set; }

        /// <summary>The suggested paragraph style changes to this paragraph, keyed by suggestion ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedParagraphStyleChanges")]
        public virtual System.Collections.Generic.IDictionary<string, SuggestedParagraphStyle> SuggestedParagraphStyleChanges { get; set; }

        /// <summary>
        /// The IDs of the positioned objects that are suggested to be attached to this paragraph, keyed by suggestion
        /// ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedPositionedObjectIds")]
        public virtual System.Collections.Generic.IDictionary<string, ObjectReferences> SuggestedPositionedObjectIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A border around a paragraph.</summary>
    public class ParagraphBorder : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The color of the border.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual OptionalColor Color { get; set; }

        /// <summary>The dash style of the border.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dashStyle")]
        public virtual string DashStyle { get; set; }

        /// <summary>The padding of the border.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("padding")]
        public virtual Dimension Padding { get; set; }

        /// <summary>The width of the border.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual Dimension Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A ParagraphElement describes content within a Paragraph.</summary>
    public class ParagraphElement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An auto text paragraph element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoText")]
        public virtual AutoText AutoText { get; set; }

        /// <summary>A column break paragraph element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnBreak")]
        public virtual ColumnBreak ColumnBreak { get; set; }

        /// <summary>The zero-base end index of this paragraph element, exclusive, in UTF-16 code units.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endIndex")]
        public virtual System.Nullable<int> EndIndex { get; set; }

        /// <summary>An equation paragraph element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("equation")]
        public virtual Equation Equation { get; set; }

        /// <summary>A footnote reference paragraph element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("footnoteReference")]
        public virtual FootnoteReference FootnoteReference { get; set; }

        /// <summary>A horizontal rule paragraph element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("horizontalRule")]
        public virtual HorizontalRule HorizontalRule { get; set; }

        /// <summary>An inline object paragraph element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inlineObjectElement")]
        public virtual InlineObjectElement InlineObjectElement { get; set; }

        /// <summary>A page break paragraph element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageBreak")]
        public virtual PageBreak PageBreak { get; set; }

        /// <summary>A paragraph element that links to a person or email address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("person")]
        public virtual Person Person { get; set; }

        /// <summary>
        /// A paragraph element that links to a Google resource (such as a file in Drive, a Youtube video, a Calendar
        /// event, etc.)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("richLink")]
        public virtual RichLink RichLink { get; set; }

        /// <summary>The zero-based start index of this paragraph element, in UTF-16 code units.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; }

        /// <summary>A text run paragraph element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textRun")]
        public virtual TextRun TextRun { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Styles that apply to a whole paragraph. Inherited paragraph styles are represented as unset fields in this
    /// message. A paragraph style's parent depends on where the paragraph style is defined: * The ParagraphStyle on a
    /// Paragraph inherits from the paragraph's corresponding named style type. * The ParagraphStyle on a named style
    /// inherits from the normal text named style. * The ParagraphStyle of the normal text named style inherits from the
    /// default paragraph style in the Docs editor. * The ParagraphStyle on a Paragraph element that is contained in a
    /// table may inherit its paragraph style from the table style. If the paragraph style does not inherit from a
    /// parent, unsetting fields will revert the style to a value matching the defaults in the Docs editor.
    /// </summary>
    public class ParagraphStyle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The text alignment for this paragraph.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alignment")]
        public virtual string Alignment { get; set; }

        /// <summary>
        /// Whether to avoid widows and orphans for the paragraph. If unset, the value is inherited from the parent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("avoidWidowAndOrphan")]
        public virtual System.Nullable<bool> AvoidWidowAndOrphan { get; set; }

        /// <summary>
        /// The border between this paragraph and the next and previous paragraphs. If unset, the value is inherited
        /// from the parent. The between border is rendered when the adjacent paragraph has the same border and indent
        /// properties. Paragraph borders cannot be partially updated. When making changes to a paragraph border the new
        /// border must be specified in its entirety.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("borderBetween")]
        public virtual ParagraphBorder BorderBetween { get; set; }

        /// <summary>
        /// The border at the bottom of this paragraph. If unset, the value is inherited from the parent. The bottom
        /// border is rendered when the paragraph below has different border and indent properties. Paragraph borders
        /// cannot be partially updated. When making changes to a paragraph border the new border must be specified in
        /// its entirety.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("borderBottom")]
        public virtual ParagraphBorder BorderBottom { get; set; }

        /// <summary>
        /// The border to the left of this paragraph. If unset, the value is inherited from the parent. Paragraph
        /// borders cannot be partially updated. When making changes to a paragraph border the new border must be
        /// specified in its entirety.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("borderLeft")]
        public virtual ParagraphBorder BorderLeft { get; set; }

        /// <summary>
        /// The border to the right of this paragraph. If unset, the value is inherited from the parent. Paragraph
        /// borders cannot be partially updated. When making changes to a paragraph border the new border must be
        /// specified in its entirety.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("borderRight")]
        public virtual ParagraphBorder BorderRight { get; set; }

        /// <summary>
        /// The border at the top of this paragraph. If unset, the value is inherited from the parent. The top border is
        /// rendered when the paragraph above has different border and indent properties. Paragraph borders cannot be
        /// partially updated. When making changes to a paragraph border the new border must be specified in its
        /// entirety.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("borderTop")]
        public virtual ParagraphBorder BorderTop { get; set; }

        /// <summary>
        /// The text direction of this paragraph. If unset, the value defaults to LEFT_TO_RIGHT since paragraph
        /// direction is not inherited.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("direction")]
        public virtual string Direction { get; set; }

        /// <summary>
        /// The heading ID of the paragraph. If empty, then this paragraph is not a heading. This property is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headingId")]
        public virtual string HeadingId { get; set; }

        /// <summary>
        /// The amount of indentation for the paragraph on the side that corresponds to the end of the text, based on
        /// the current paragraph direction. If unset, the value is inherited from the parent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indentEnd")]
        public virtual Dimension IndentEnd { get; set; }

        /// <summary>
        /// The amount of indentation for the first line of the paragraph. If unset, the value is inherited from the
        /// parent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indentFirstLine")]
        public virtual Dimension IndentFirstLine { get; set; }

        /// <summary>
        /// The amount of indentation for the paragraph on the side that corresponds to the start of the text, based on
        /// the current paragraph direction. If unset, the value is inherited from the parent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indentStart")]
        public virtual Dimension IndentStart { get; set; }

        /// <summary>
        /// Whether all lines of the paragraph should be laid out on the same page or column if possible. If unset, the
        /// value is inherited from the parent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keepLinesTogether")]
        public virtual System.Nullable<bool> KeepLinesTogether { get; set; }

        /// <summary>
        /// Whether at least a part of this paragraph should be laid out on the same page or column as the next
        /// paragraph if possible. If unset, the value is inherited from the parent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keepWithNext")]
        public virtual System.Nullable<bool> KeepWithNext { get; set; }

        /// <summary>
        /// The amount of space between lines, as a percentage of normal, where normal is represented as 100.0. If
        /// unset, the value is inherited from the parent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineSpacing")]
        public virtual System.Nullable<float> LineSpacing { get; set; }

        /// <summary>
        /// The named style type of the paragraph. Since updating the named style type affects other properties within
        /// ParagraphStyle, the named style type is applied before the other properties are updated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namedStyleType")]
        public virtual string NamedStyleType { get; set; }

        /// <summary>The shading of the paragraph. If unset, the value is inherited from the parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shading")]
        public virtual Shading Shading { get; set; }

        /// <summary>
        /// The amount of extra space above the paragraph. If unset, the value is inherited from the parent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spaceAbove")]
        public virtual Dimension SpaceAbove { get; set; }

        /// <summary>
        /// The amount of extra space below the paragraph. If unset, the value is inherited from the parent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spaceBelow")]
        public virtual Dimension SpaceBelow { get; set; }

        /// <summary>The spacing mode for the paragraph.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spacingMode")]
        public virtual string SpacingMode { get; set; }

        /// <summary>
        /// A list of the tab stops for this paragraph. The list of tab stops is not inherited. This property is
        /// read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tabStops")]
        public virtual System.Collections.Generic.IList<TabStop> TabStops { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A mask that indicates which of the fields on the base ParagraphStyle have been changed in this suggestion. For
    /// any field set to true, there is a new suggested value.
    /// </summary>
    public class ParagraphStyleSuggestionState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates if there was a suggested change to alignment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alignmentSuggested")]
        public virtual System.Nullable<bool> AlignmentSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to avoid_widow_and_orphan.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("avoidWidowAndOrphanSuggested")]
        public virtual System.Nullable<bool> AvoidWidowAndOrphanSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to border_between.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("borderBetweenSuggested")]
        public virtual System.Nullable<bool> BorderBetweenSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to border_bottom.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("borderBottomSuggested")]
        public virtual System.Nullable<bool> BorderBottomSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to border_left.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("borderLeftSuggested")]
        public virtual System.Nullable<bool> BorderLeftSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to border_right.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("borderRightSuggested")]
        public virtual System.Nullable<bool> BorderRightSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to border_top.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("borderTopSuggested")]
        public virtual System.Nullable<bool> BorderTopSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to direction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("directionSuggested")]
        public virtual System.Nullable<bool> DirectionSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to heading_id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headingIdSuggested")]
        public virtual System.Nullable<bool> HeadingIdSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to indent_end.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indentEndSuggested")]
        public virtual System.Nullable<bool> IndentEndSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to indent_first_line.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indentFirstLineSuggested")]
        public virtual System.Nullable<bool> IndentFirstLineSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to indent_start.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indentStartSuggested")]
        public virtual System.Nullable<bool> IndentStartSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to keep_lines_together.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keepLinesTogetherSuggested")]
        public virtual System.Nullable<bool> KeepLinesTogetherSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to keep_with_next.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keepWithNextSuggested")]
        public virtual System.Nullable<bool> KeepWithNextSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to line_spacing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineSpacingSuggested")]
        public virtual System.Nullable<bool> LineSpacingSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to named_style_type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namedStyleTypeSuggested")]
        public virtual System.Nullable<bool> NamedStyleTypeSuggested { get; set; }

        /// <summary>
        /// A mask that indicates which of the fields in shading have been changed in this suggestion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shadingSuggestionState")]
        public virtual ShadingSuggestionState ShadingSuggestionState { get; set; }

        /// <summary>Indicates if there was a suggested change to space_above.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spaceAboveSuggested")]
        public virtual System.Nullable<bool> SpaceAboveSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to space_below.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spaceBelowSuggested")]
        public virtual System.Nullable<bool> SpaceBelowSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to spacing_mode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spacingModeSuggested")]
        public virtual System.Nullable<bool> SpacingModeSuggested { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A person or email address mentioned in a document. These mentions behave as a single, immutable element
    /// containing the person's name or email address.
    /// </summary>
    public class Person : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The unique ID of this link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("personId")]
        public virtual string PersonId { get; set; }

        /// <summary>Output only. The properties of this Person. This field is always present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("personProperties")]
        public virtual PersonProperties PersonProperties { get; set; }

        /// <summary>
        /// IDs for suggestions that remove this person link from the document. A Person might have multiple deletion
        /// IDs if, for example, multiple users suggest to delete it. If empty, then this person link isn't suggested
        /// for deletion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedDeletionIds")]
        public virtual System.Collections.Generic.IList<string> SuggestedDeletionIds { get; set; }

        /// <summary>
        /// IDs for suggestions that insert this person link into the document. A Person might have multiple insertion
        /// IDs if it is a nested suggested change (a suggestion within a suggestion made by a different user, for
        /// example). If empty, then this person link isn't a suggested insertion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedInsertionIds")]
        public virtual System.Collections.Generic.IList<string> SuggestedInsertionIds { get; set; }

        /// <summary>The suggested text style changes to this Person, keyed by suggestion ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedTextStyleChanges")]
        public virtual System.Collections.Generic.IDictionary<string, SuggestedTextStyle> SuggestedTextStyleChanges { get; set; }

        /// <summary>The text style of this Person.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textStyle")]
        public virtual TextStyle TextStyle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Properties specific to a linked Person.</summary>
    public class PersonProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The email address linked to this Person. This field is always present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>
        /// Output only. The name of the person if it is displayed in the link text instead of the person's email
        /// address.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An object that is tethered to a Paragraph and positioned relative to the beginning of the paragraph. A
    /// PositionedObject contains an EmbeddedObject such as an image.
    /// </summary>
    public class PositionedObject : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of this positioned object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>The properties of this positioned object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("positionedObjectProperties")]
        public virtual PositionedObjectProperties PositionedObjectProperties { get; set; }

        /// <summary>
        /// The suggested deletion IDs. If empty, then there are no suggested deletions of this content.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedDeletionIds")]
        public virtual System.Collections.Generic.IList<string> SuggestedDeletionIds { get; set; }

        /// <summary>The suggested insertion ID. If empty, then this is not a suggested insertion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedInsertionId")]
        public virtual string SuggestedInsertionId { get; set; }

        /// <summary>The suggested changes to the positioned object properties, keyed by suggestion ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedPositionedObjectPropertiesChanges")]
        public virtual System.Collections.Generic.IDictionary<string, SuggestedPositionedObjectProperties> SuggestedPositionedObjectPropertiesChanges { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The positioning of a PositionedObject. The positioned object is positioned relative to the beginning of the
    /// Paragraph it is tethered to.
    /// </summary>
    public class PositionedObjectPositioning : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The layout of this positioned object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual string Layout { get; set; }

        /// <summary>
        /// The offset of the left edge of the positioned object relative to the beginning of the Paragraph it is
        /// tethered to. The exact positioning of the object can depend on other content in the document and the
        /// document's styling.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("leftOffset")]
        public virtual Dimension LeftOffset { get; set; }

        /// <summary>
        /// The offset of the top edge of the positioned object relative to the beginning of the Paragraph it is
        /// tethered to. The exact positioning of the object can depend on other content in the document and the
        /// document's styling.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topOffset")]
        public virtual Dimension TopOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A mask that indicates which of the fields on the base PositionedObjectPositioning have been changed in this
    /// suggestion. For any field set to true, there is a new suggested value.
    /// </summary>
    public class PositionedObjectPositioningSuggestionState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates if there was a suggested change to layout.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layoutSuggested")]
        public virtual System.Nullable<bool> LayoutSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to left_offset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("leftOffsetSuggested")]
        public virtual System.Nullable<bool> LeftOffsetSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to top_offset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topOffsetSuggested")]
        public virtual System.Nullable<bool> TopOffsetSuggested { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Properties of a PositionedObject.</summary>
    public class PositionedObjectProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The embedded object of this positioned object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("embeddedObject")]
        public virtual EmbeddedObject EmbeddedObject { get; set; }

        /// <summary>
        /// The positioning of this positioned object relative to the newline of the Paragraph that references this
        /// positioned object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("positioning")]
        public virtual PositionedObjectPositioning Positioning { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A mask that indicates which of the fields on the base PositionedObjectProperties have been changed in this
    /// suggestion. For any field set to true, there is a new suggested value.
    /// </summary>
    public class PositionedObjectPropertiesSuggestionState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A mask that indicates which of the fields in embedded_object have been changed in this suggestion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("embeddedObjectSuggestionState")]
        public virtual EmbeddedObjectSuggestionState EmbeddedObjectSuggestionState { get; set; }

        /// <summary>
        /// A mask that indicates which of the fields in positioning have been changed in this suggestion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("positioningSuggestionState")]
        public virtual PositionedObjectPositioningSuggestionState PositioningSuggestionState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies a contiguous range of text.</summary>
    public class Range : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The zero-based end index of this range, exclusive, in UTF-16 code units. In all current uses, an end index
        /// must be provided. This field is an Int32Value in order to accommodate future use cases with open-ended
        /// ranges.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endIndex")]
        public virtual System.Nullable<int> EndIndex { get; set; }

        /// <summary>
        /// The ID of the header, footer or footnote that this range is contained in. An empty segment ID signifies the
        /// document's body.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segmentId")]
        public virtual string SegmentId { get; set; }

        /// <summary>
        /// The zero-based start index of this range, in UTF-16 code units. In all current uses, a start index must be
        /// provided. This field is an Int32Value in order to accommodate future use cases with open-ended ranges.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Replaces all instances of text matching a criteria with replace text.</summary>
    public class ReplaceAllTextRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Finds text in the document matching this substring.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containsText")]
        public virtual SubstringMatchCriteria ContainsText { get; set; }

        /// <summary>The text that will replace the matched text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replaceText")]
        public virtual string ReplaceText { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of replacing text.</summary>
    public class ReplaceAllTextResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of occurrences changed by replacing all text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("occurrencesChanged")]
        public virtual System.Nullable<int> OccurrencesChanged { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Replaces an existing image with a new image. Replacing an image removes some image effects from the existing
    /// image in order to mirror the behavior of the Docs editor.
    /// </summary>
    public class ReplaceImageRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the existing image that will be replaced.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageObjectId")]
        public virtual string ImageObjectId { get; set; }

        /// <summary>The replacement method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageReplaceMethod")]
        public virtual string ImageReplaceMethod { get; set; }

        /// <summary>
        /// The URI of the new image. The image is fetched once at insertion time and a copy is stored for display
        /// inside the document. Images must be less than 50MB in size, cannot exceed 25 megapixels, and must be in one
        /// of PNG, JPEG, or GIF format. The provided URI can be at most 2 kB in length. The URI itself is saved with
        /// the image, and exposed via the ImageProperties.source_uri field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Replaces the contents of the specified NamedRange or NamedRanges with the given replacement content. Note that
    /// an individual NamedRange may consist of multiple discontinuous ranges. In this case, only the content in the
    /// first range will be replaced. The other ranges and their content will be deleted. In cases where replacing or
    /// deleting any ranges would result in an invalid document structure, a 400 bad request error is returned.
    /// </summary>
    public class ReplaceNamedRangeContentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The ID of the named range whose content will be replaced. If there is no named range with the given ID a 400
        /// bad request error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namedRangeId")]
        public virtual string NamedRangeId { get; set; }

        /// <summary>
        /// The name of the NamedRanges whose content will be replaced. If there are multiple named ranges with the
        /// given name, then the content of each one will be replaced. If there are no named ranges with the given name,
        /// then the request will be a no-op.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namedRangeName")]
        public virtual string NamedRangeName { get; set; }

        /// <summary>Replaces the content of the specified named range(s) with the given text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single update to apply to a document.</summary>
    public class Request : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Creates a footer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createFooter")]
        public virtual CreateFooterRequest CreateFooter { get; set; }

        /// <summary>Creates a footnote.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createFootnote")]
        public virtual CreateFootnoteRequest CreateFootnote { get; set; }

        /// <summary>Creates a header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createHeader")]
        public virtual CreateHeaderRequest CreateHeader { get; set; }

        /// <summary>Creates a named range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createNamedRange")]
        public virtual CreateNamedRangeRequest CreateNamedRange { get; set; }

        /// <summary>Creates bullets for paragraphs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createParagraphBullets")]
        public virtual CreateParagraphBulletsRequest CreateParagraphBullets { get; set; }

        /// <summary>Deletes content from the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteContentRange")]
        public virtual DeleteContentRangeRequest DeleteContentRange { get; set; }

        /// <summary>Deletes a footer from the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteFooter")]
        public virtual DeleteFooterRequest DeleteFooter { get; set; }

        /// <summary>Deletes a header from the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteHeader")]
        public virtual DeleteHeaderRequest DeleteHeader { get; set; }

        /// <summary>Deletes a named range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteNamedRange")]
        public virtual DeleteNamedRangeRequest DeleteNamedRange { get; set; }

        /// <summary>Deletes bullets from paragraphs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteParagraphBullets")]
        public virtual DeleteParagraphBulletsRequest DeleteParagraphBullets { get; set; }

        /// <summary>Deletes a positioned object from the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletePositionedObject")]
        public virtual DeletePositionedObjectRequest DeletePositionedObject { get; set; }

        /// <summary>Deletes a column from a table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTableColumn")]
        public virtual DeleteTableColumnRequest DeleteTableColumn { get; set; }

        /// <summary>Deletes a row from a table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTableRow")]
        public virtual DeleteTableRowRequest DeleteTableRow { get; set; }

        /// <summary>Inserts an inline image at the specified location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertInlineImage")]
        public virtual InsertInlineImageRequest InsertInlineImage { get; set; }

        /// <summary>Inserts a page break at the specified location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertPageBreak")]
        public virtual InsertPageBreakRequest InsertPageBreak { get; set; }

        /// <summary>Inserts a section break at the specified location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertSectionBreak")]
        public virtual InsertSectionBreakRequest InsertSectionBreak { get; set; }

        /// <summary>Inserts a table at the specified location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertTable")]
        public virtual InsertTableRequest InsertTable { get; set; }

        /// <summary>Inserts an empty column into a table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertTableColumn")]
        public virtual InsertTableColumnRequest InsertTableColumn { get; set; }

        /// <summary>Inserts an empty row into a table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertTableRow")]
        public virtual InsertTableRowRequest InsertTableRow { get; set; }

        /// <summary>Inserts text at the specified location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertText")]
        public virtual InsertTextRequest InsertText { get; set; }

        /// <summary>Merges cells in a table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mergeTableCells")]
        public virtual MergeTableCellsRequest MergeTableCells { get; set; }

        /// <summary>Replaces all instances of the specified text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replaceAllText")]
        public virtual ReplaceAllTextRequest ReplaceAllText { get; set; }

        /// <summary>Replaces an image in the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replaceImage")]
        public virtual ReplaceImageRequest ReplaceImage { get; set; }

        /// <summary>Replaces the content in a named range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replaceNamedRangeContent")]
        public virtual ReplaceNamedRangeContentRequest ReplaceNamedRangeContent { get; set; }

        /// <summary>Unmerges cells in a table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unmergeTableCells")]
        public virtual UnmergeTableCellsRequest UnmergeTableCells { get; set; }

        /// <summary>Updates the style of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateDocumentStyle")]
        public virtual UpdateDocumentStyleRequest UpdateDocumentStyle { get; set; }

        /// <summary>Updates the paragraph style at the specified range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateParagraphStyle")]
        public virtual UpdateParagraphStyleRequest UpdateParagraphStyle { get; set; }

        /// <summary>Updates the section style of the specified range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateSectionStyle")]
        public virtual UpdateSectionStyleRequest UpdateSectionStyle { get; set; }

        /// <summary>Updates the style of table cells.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTableCellStyle")]
        public virtual UpdateTableCellStyleRequest UpdateTableCellStyle { get; set; }

        /// <summary>Updates the properties of columns in a table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTableColumnProperties")]
        public virtual UpdateTableColumnPropertiesRequest UpdateTableColumnProperties { get; set; }

        /// <summary>Updates the row style in a table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTableRowStyle")]
        public virtual UpdateTableRowStyleRequest UpdateTableRowStyle { get; set; }

        /// <summary>Updates the text style at the specified range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTextStyle")]
        public virtual UpdateTextStyleRequest UpdateTextStyle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single response from an update.</summary>
    public class Response : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The result of creating a footer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createFooter")]
        public virtual CreateFooterResponse CreateFooter { get; set; }

        /// <summary>The result of creating a footnote.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createFootnote")]
        public virtual CreateFootnoteResponse CreateFootnote { get; set; }

        /// <summary>The result of creating a header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createHeader")]
        public virtual CreateHeaderResponse CreateHeader { get; set; }

        /// <summary>The result of creating a named range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createNamedRange")]
        public virtual CreateNamedRangeResponse CreateNamedRange { get; set; }

        /// <summary>The result of inserting an inline image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertInlineImage")]
        public virtual InsertInlineImageResponse InsertInlineImage { get; set; }

        /// <summary>The result of inserting an inline Google Sheets chart.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertInlineSheetsChart")]
        public virtual InsertInlineSheetsChartResponse InsertInlineSheetsChart { get; set; }

        /// <summary>The result of replacing text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replaceAllText")]
        public virtual ReplaceAllTextResponse ReplaceAllText { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An RGB color.</summary>
    public class RgbColor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The blue component of the color, from 0.0 to 1.0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blue")]
        public virtual System.Nullable<float> Blue { get; set; }

        /// <summary>The green component of the color, from 0.0 to 1.0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("green")]
        public virtual System.Nullable<float> Green { get; set; }

        /// <summary>The red component of the color, from 0.0 to 1.0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("red")]
        public virtual System.Nullable<float> Red { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A link to a Google resource (e.g., a file in Drive, a YouTube video, a Calendar event, etc.).</summary>
    public class RichLink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The ID of this link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("richLinkId")]
        public virtual string RichLinkId { get; set; }

        /// <summary>Output only. The properties of this RichLink. This field is always present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("richLinkProperties")]
        public virtual RichLinkProperties RichLinkProperties { get; set; }

        /// <summary>
        /// IDs for suggestions that remove this link from the document. A RichLink might have multiple deletion IDs if,
        /// for example, multiple users suggest to delete it. If empty, then this person link isn't suggested for
        /// deletion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedDeletionIds")]
        public virtual System.Collections.Generic.IList<string> SuggestedDeletionIds { get; set; }

        /// <summary>
        /// IDs for suggestions that insert this link into the document. A RichLink might have multiple insertion IDs if
        /// it is a nested suggested change (a suggestion within a suggestion made by a different user, for example). If
        /// empty, then this person link isn't a suggested insertion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedInsertionIds")]
        public virtual System.Collections.Generic.IList<string> SuggestedInsertionIds { get; set; }

        /// <summary>The suggested text style changes to this RichLink, keyed by suggestion ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedTextStyleChanges")]
        public virtual System.Collections.Generic.IDictionary<string, SuggestedTextStyle> SuggestedTextStyleChanges { get; set; }

        /// <summary>The text style of this RichLink.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textStyle")]
        public virtual TextStyle TextStyle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Properties specific to a RichLink.</summary>
    public class RichLinkProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The [MIME type](https://developers.google.com/drive/api/v3/mime-types) of the RichLink, if
        /// there is one (i.e., when it is a file in Drive).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>
        /// Output only. The title of the RichLink as displayed in the link. This title matches the title of the linked
        /// resource at the time of the insertion or last update of the link. This field is always present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>Output only. The URI to the RichLink. This is always present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A StructuralElement representing a section break. A section is a range of content which has the same
    /// SectionStyle. A section break represents the start of a new section, and the section style applies to the
    /// section after the section break. The document body always begins with a section break.
    /// </summary>
    public class SectionBreak : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The style of the section after this section break.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sectionStyle")]
        public virtual SectionStyle SectionStyle { get; set; }

        /// <summary>
        /// The suggested deletion IDs. If empty, then there are no suggested deletions of this content.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedDeletionIds")]
        public virtual System.Collections.Generic.IList<string> SuggestedDeletionIds { get; set; }

        /// <summary>
        /// The suggested insertion IDs. A SectionBreak may have multiple insertion IDs if it is a nested suggested
        /// change. If empty, then this is not a suggested insertion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedInsertionIds")]
        public virtual System.Collections.Generic.IList<string> SuggestedInsertionIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Properties that apply to a section's column.</summary>
    public class SectionColumnProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The padding at the end of the column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paddingEnd")]
        public virtual Dimension PaddingEnd { get; set; }

        /// <summary>Output only. The width of the column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual Dimension Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The styling that applies to a section.</summary>
    public class SectionStyle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The section's columns properties. If empty, the section contains one column with the default properties in
        /// the Docs editor. A section can be updated to have no more than three columns. When updating this property,
        /// setting a concrete value is required. Unsetting this property will result in a 400 bad request error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnProperties")]
        public virtual System.Collections.Generic.IList<SectionColumnProperties> ColumnProperties { get; set; }

        /// <summary>
        /// The style of column separators. This style can be set even when there is one column in the section. When
        /// updating this property, setting a concrete value is required. Unsetting this property results in a 400 bad
        /// request error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnSeparatorStyle")]
        public virtual string ColumnSeparatorStyle { get; set; }

        /// <summary>
        /// The content direction of this section. If unset, the value defaults to LEFT_TO_RIGHT. When updating this
        /// property, setting a concrete value is required. Unsetting this property results in a 400 bad request error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentDirection")]
        public virtual string ContentDirection { get; set; }

        /// <summary>
        /// The ID of the default footer. If unset, the value inherits from the previous SectionBreak's SectionStyle. If
        /// the value is unset in the first SectionBreak, it inherits from DocumentStyle's default_footer_id. This
        /// property is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultFooterId")]
        public virtual string DefaultFooterId { get; set; }

        /// <summary>
        /// The ID of the default header. If unset, the value inherits from the previous SectionBreak's SectionStyle. If
        /// the value is unset in the first SectionBreak, it inherits from DocumentStyle's default_header_id. This
        /// property is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultHeaderId")]
        public virtual string DefaultHeaderId { get; set; }

        /// <summary>
        /// The ID of the footer used only for even pages. If the value of DocumentStyle's use_even_page_header_footer
        /// is true, this value is used for the footers on even pages in the section. If it is false, the footers on
        /// even pages uses the default_footer_id. If unset, the value inherits from the previous SectionBreak's
        /// SectionStyle. If the value is unset in the first SectionBreak, it inherits from DocumentStyle's
        /// even_page_footer_id. This property is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evenPageFooterId")]
        public virtual string EvenPageFooterId { get; set; }

        /// <summary>
        /// The ID of the header used only for even pages. If the value of DocumentStyle's use_even_page_header_footer
        /// is true, this value is used for the headers on even pages in the section. If it is false, the headers on
        /// even pages uses the default_header_id. If unset, the value inherits from the previous SectionBreak's
        /// SectionStyle. If the value is unset in the first SectionBreak, it inherits from DocumentStyle's
        /// even_page_header_id. This property is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evenPageHeaderId")]
        public virtual string EvenPageHeaderId { get; set; }

        /// <summary>
        /// The ID of the footer used only for the first page of the section. If use_first_page_header_footer is true,
        /// this value is used for the footer on the first page of the section. If it is false, the footer on the first
        /// page of the section uses the default_footer_id. If unset, the value inherits from the previous
        /// SectionBreak's SectionStyle. If the value is unset in the first SectionBreak, it inherits from
        /// DocumentStyle's first_page_footer_id. This property is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstPageFooterId")]
        public virtual string FirstPageFooterId { get; set; }

        /// <summary>
        /// The ID of the header used only for the first page of the section. If use_first_page_header_footer is true,
        /// this value is used for the header on the first page of the section. If it is false, the header on the first
        /// page of the section uses the default_header_id. If unset, the value inherits from the previous
        /// SectionBreak's SectionStyle. If the value is unset in the first SectionBreak, it inherits from
        /// DocumentStyle's first_page_header_id. This property is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstPageHeaderId")]
        public virtual string FirstPageHeaderId { get; set; }

        /// <summary>
        /// The bottom page margin of the section. If unset, uses margin_bottom from DocumentStyle. When updating this
        /// property, setting a concrete value is required. Unsetting this property results in a 400 bad request error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marginBottom")]
        public virtual Dimension MarginBottom { get; set; }

        /// <summary>
        /// The footer margin of the section. If unset, uses margin_footer from DocumentStyle. If updated,
        /// use_custom_header_footer_margins is set to true on DocumentStyle. The value of
        /// use_custom_header_footer_margins on DocumentStyle indicates if a footer margin is being respected for this
        /// section When updating this property, setting a concrete value is required. Unsetting this property results
        /// in a 400 bad request error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marginFooter")]
        public virtual Dimension MarginFooter { get; set; }

        /// <summary>
        /// The header margin of the section. If unset, uses margin_header from DocumentStyle. If updated,
        /// use_custom_header_footer_margins is set to true on DocumentStyle. The value of
        /// use_custom_header_footer_margins on DocumentStyle indicates if a header margin is being respected for this
        /// section. When updating this property, setting a concrete value is required. Unsetting this property results
        /// in a 400 bad request error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marginHeader")]
        public virtual Dimension MarginHeader { get; set; }

        /// <summary>
        /// The left page margin of the section. If unset, uses margin_left from DocumentStyle. Updating left margin
        /// causes columns in this section to resize. Since the margin affects column width, it is applied before column
        /// properties. When updating this property, setting a concrete value is required. Unsetting this property
        /// results in a 400 bad request error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marginLeft")]
        public virtual Dimension MarginLeft { get; set; }

        /// <summary>
        /// The right page margin of the section. If unset, uses margin_right from DocumentStyle. Updating right margin
        /// causes columns in this section to resize. Since the margin affects column width, it is applied before column
        /// properties. When updating this property, setting a concrete value is required. Unsetting this property
        /// results in a 400 bad request error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marginRight")]
        public virtual Dimension MarginRight { get; set; }

        /// <summary>
        /// The top page margin of the section. If unset, uses margin_top from DocumentStyle. When updating this
        /// property, setting a concrete value is required. Unsetting this property results in a 400 bad request error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marginTop")]
        public virtual Dimension MarginTop { get; set; }

        /// <summary>
        /// The page number from which to start counting the number of pages for this section. If unset, page numbering
        /// continues from the previous section. If the value is unset in the first SectionBreak, refer to
        /// DocumentStyle's page_number_start. When updating this property, setting a concrete value is required.
        /// Unsetting this property results in a 400 bad request error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageNumberStart")]
        public virtual System.Nullable<int> PageNumberStart { get; set; }

        /// <summary>Output only. The type of section.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sectionType")]
        public virtual string SectionType { get; set; }

        /// <summary>
        /// Indicates whether to use the first page header / footer IDs for the first page of the section. If unset, it
        /// inherits from DocumentStyle's use_first_page_header_footer for the first section. If the value is unset for
        /// subsequent sectors, it should be interpreted as false. When updating this property, setting a concrete value
        /// is required. Unsetting this property results in a 400 bad request error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useFirstPageHeaderFooter")]
        public virtual System.Nullable<bool> UseFirstPageHeaderFooter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The shading of a paragraph.</summary>
    public class Shading : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The background color of this paragraph shading.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backgroundColor")]
        public virtual OptionalColor BackgroundColor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A mask that indicates which of the fields on the base Shading have been changed in this suggested change. For
    /// any field set to true, there is a new suggested value.
    /// </summary>
    public class ShadingSuggestionState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates if there was a suggested change to the Shading.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backgroundColorSuggested")]
        public virtual System.Nullable<bool> BackgroundColorSuggested { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A reference to a linked chart embedded from Google Sheets.</summary>
    public class SheetsChartReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the specific chart in the Google Sheets spreadsheet that is embedded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chartId")]
        public virtual System.Nullable<int> ChartId { get; set; }

        /// <summary>The ID of the Google Sheets spreadsheet that contains the source chart.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spreadsheetId")]
        public virtual string SpreadsheetId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A mask that indicates which of the fields on the base SheetsChartReference have been changed in this suggestion.
    /// For any field set to true, there is a new suggested value.
    /// </summary>
    public class SheetsChartReferenceSuggestionState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates if there was a suggested change to chart_id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chartIdSuggested")]
        public virtual System.Nullable<bool> ChartIdSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to spreadsheet_id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spreadsheetIdSuggested")]
        public virtual System.Nullable<bool> SpreadsheetIdSuggested { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A width and height.</summary>
    public class Size : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The height of the object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual Dimension Height { get; set; }

        /// <summary>The width of the object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual Dimension Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A mask that indicates which of the fields on the base Size have been changed in this suggestion. For any field
    /// set to true, the Size has a new suggested value.
    /// </summary>
    public class SizeSuggestionState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates if there was a suggested change to height.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heightSuggested")]
        public virtual System.Nullable<bool> HeightSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to width.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("widthSuggested")]
        public virtual System.Nullable<bool> WidthSuggested { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A StructuralElement describes content that provides structure to the document.</summary>
    public class StructuralElement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The zero-based end index of this structural element, exclusive, in UTF-16 code units.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endIndex")]
        public virtual System.Nullable<int> EndIndex { get; set; }

        /// <summary>A paragraph type of structural element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paragraph")]
        public virtual Paragraph Paragraph { get; set; }

        /// <summary>A section break type of structural element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sectionBreak")]
        public virtual SectionBreak SectionBreak { get; set; }

        /// <summary>The zero-based start index of this structural element, in UTF-16 code units.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; }

        /// <summary>A table type of structural element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("table")]
        public virtual Table Table { get; set; }

        /// <summary>A table of contents type of structural element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableOfContents")]
        public virtual TableOfContents TableOfContents { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A criteria that matches a specific string of text in the document.</summary>
    public class SubstringMatchCriteria : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Indicates whether the search should respect case: - `True`: the search is case sensitive. - `False`: the
        /// search is case insensitive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchCase")]
        public virtual System.Nullable<bool> MatchCase { get; set; }

        /// <summary>The text to search for in the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A suggested change to a Bullet.</summary>
    public class SuggestedBullet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A Bullet that only includes the changes made in this suggestion. This can be used along with the
        /// bullet_suggestion_state to see which fields have changed and their new values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bullet")]
        public virtual Bullet Bullet { get; set; }

        /// <summary>
        /// A mask that indicates which of the fields on the base Bullet have been changed in this suggestion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bulletSuggestionState")]
        public virtual BulletSuggestionState BulletSuggestionState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A suggested change to the DocumentStyle.</summary>
    public class SuggestedDocumentStyle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A DocumentStyle that only includes the changes made in this suggestion. This can be used along with the
        /// document_style_suggestion_state to see which fields have changed and their new values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentStyle")]
        public virtual DocumentStyle DocumentStyle { get; set; }

        /// <summary>
        /// A mask that indicates which of the fields on the base DocumentStyle have been changed in this suggestion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentStyleSuggestionState")]
        public virtual DocumentStyleSuggestionState DocumentStyleSuggestionState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A suggested change to InlineObjectProperties.</summary>
    public class SuggestedInlineObjectProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An InlineObjectProperties that only includes the changes made in this suggestion. This can be used along
        /// with the inline_object_properties_suggestion_state to see which fields have changed and their new values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inlineObjectProperties")]
        public virtual InlineObjectProperties InlineObjectProperties { get; set; }

        /// <summary>
        /// A mask that indicates which of the fields on the base InlineObjectProperties have been changed in this
        /// suggestion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inlineObjectPropertiesSuggestionState")]
        public virtual InlineObjectPropertiesSuggestionState InlineObjectPropertiesSuggestionState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A suggested change to ListProperties.</summary>
    public class SuggestedListProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A ListProperties that only includes the changes made in this suggestion. This can be used along with the
        /// list_properties_suggestion_state to see which fields have changed and their new values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listProperties")]
        public virtual ListProperties ListProperties { get; set; }

        /// <summary>
        /// A mask that indicates which of the fields on the base ListProperties have been changed in this suggestion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listPropertiesSuggestionState")]
        public virtual ListPropertiesSuggestionState ListPropertiesSuggestionState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A suggested change to the NamedStyles.</summary>
    public class SuggestedNamedStyles : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A NamedStyles that only includes the changes made in this suggestion. This can be used along with the
        /// named_styles_suggestion_state to see which fields have changed and their new values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namedStyles")]
        public virtual NamedStyles NamedStyles { get; set; }

        /// <summary>
        /// A mask that indicates which of the fields on the base NamedStyles have been changed in this suggestion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namedStylesSuggestionState")]
        public virtual NamedStylesSuggestionState NamedStylesSuggestionState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A suggested change to a ParagraphStyle.</summary>
    public class SuggestedParagraphStyle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A ParagraphStyle that only includes the changes made in this suggestion. This can be used along with the
        /// paragraph_suggestion_state to see which fields have changed and their new values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paragraphStyle")]
        public virtual ParagraphStyle ParagraphStyle { get; set; }

        /// <summary>
        /// A mask that indicates which of the fields on the base ParagraphStyle have been changed in this suggestion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paragraphStyleSuggestionState")]
        public virtual ParagraphStyleSuggestionState ParagraphStyleSuggestionState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A suggested change to PositionedObjectProperties.</summary>
    public class SuggestedPositionedObjectProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A PositionedObjectProperties that only includes the changes made in this suggestion. This can be used along
        /// with the positioned_object_properties_suggestion_state to see which fields have changed and their new
        /// values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("positionedObjectProperties")]
        public virtual PositionedObjectProperties PositionedObjectProperties { get; set; }

        /// <summary>
        /// A mask that indicates which of the fields on the base PositionedObjectProperties have been changed in this
        /// suggestion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("positionedObjectPropertiesSuggestionState")]
        public virtual PositionedObjectPropertiesSuggestionState PositionedObjectPropertiesSuggestionState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A suggested change to a TableCellStyle.</summary>
    public class SuggestedTableCellStyle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A TableCellStyle that only includes the changes made in this suggestion. This can be used along with the
        /// table_cell_style_suggestion_state to see which fields have changed and their new values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableCellStyle")]
        public virtual TableCellStyle TableCellStyle { get; set; }

        /// <summary>
        /// A mask that indicates which of the fields on the base TableCellStyle have been changed in this suggestion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableCellStyleSuggestionState")]
        public virtual TableCellStyleSuggestionState TableCellStyleSuggestionState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A suggested change to a TableRowStyle.</summary>
    public class SuggestedTableRowStyle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A TableRowStyle that only includes the changes made in this suggestion. This can be used along with the
        /// table_row_style_suggestion_state to see which fields have changed and their new values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableRowStyle")]
        public virtual TableRowStyle TableRowStyle { get; set; }

        /// <summary>
        /// A mask that indicates which of the fields on the base TableRowStyle have been changed in this suggestion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableRowStyleSuggestionState")]
        public virtual TableRowStyleSuggestionState TableRowStyleSuggestionState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A suggested change to a TextStyle.</summary>
    public class SuggestedTextStyle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A TextStyle that only includes the changes made in this suggestion. This can be used along with the
        /// text_style_suggestion_state to see which fields have changed and their new values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textStyle")]
        public virtual TextStyle TextStyle { get; set; }

        /// <summary>
        /// A mask that indicates which of the fields on the base TextStyle have been changed in this suggestion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textStyleSuggestionState")]
        public virtual TextStyleSuggestionState TextStyleSuggestionState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A tab stop within a paragraph.</summary>
    public class TabStop : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The alignment of this tab stop. If unset, the value defaults to START.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alignment")]
        public virtual string Alignment { get; set; }

        /// <summary>The offset between this tab stop and the start margin.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offset")]
        public virtual Dimension Offset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A StructuralElement representing a table.</summary>
    public class Table : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Number of columns in the table. It is possible for a table to be non-rectangular, so some rows may have a
        /// different number of cells.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columns")]
        public virtual System.Nullable<int> Columns { get; set; }

        /// <summary>Number of rows in the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Nullable<int> Rows { get; set; }

        /// <summary>
        /// The suggested deletion IDs. If empty, then there are no suggested deletions of this content.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedDeletionIds")]
        public virtual System.Collections.Generic.IList<string> SuggestedDeletionIds { get; set; }

        /// <summary>
        /// The suggested insertion IDs. A Table may have multiple insertion IDs if it is a nested suggested change. If
        /// empty, then this is not a suggested insertion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedInsertionIds")]
        public virtual System.Collections.Generic.IList<string> SuggestedInsertionIds { get; set; }

        /// <summary>The contents and style of each row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableRows")]
        public virtual System.Collections.Generic.IList<TableRow> TableRows { get; set; }

        /// <summary>The style of the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableStyle")]
        public virtual TableStyle TableStyle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The contents and style of a cell in a Table.</summary>
    public class TableCell : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The content of the cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual System.Collections.Generic.IList<StructuralElement> Content { get; set; }

        /// <summary>The zero-based end index of this cell, exclusive, in UTF-16 code units.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endIndex")]
        public virtual System.Nullable<int> EndIndex { get; set; }

        /// <summary>The zero-based start index of this cell, in UTF-16 code units.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; }

        /// <summary>
        /// The suggested deletion IDs. If empty, then there are no suggested deletions of this content.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedDeletionIds")]
        public virtual System.Collections.Generic.IList<string> SuggestedDeletionIds { get; set; }

        /// <summary>
        /// The suggested insertion IDs. A TableCell may have multiple insertion IDs if it is a nested suggested change.
        /// If empty, then this is not a suggested insertion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedInsertionIds")]
        public virtual System.Collections.Generic.IList<string> SuggestedInsertionIds { get; set; }

        /// <summary>The suggested changes to the table cell style, keyed by suggestion ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedTableCellStyleChanges")]
        public virtual System.Collections.Generic.IDictionary<string, SuggestedTableCellStyle> SuggestedTableCellStyleChanges { get; set; }

        /// <summary>The style of the cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableCellStyle")]
        public virtual TableCellStyle TableCellStyle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A border around a table cell. Table cell borders cannot be transparent. To hide a table cell border, make its
    /// width 0.
    /// </summary>
    public class TableCellBorder : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The color of the border. This color cannot be transparent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual OptionalColor Color { get; set; }

        /// <summary>The dash style of the border.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dashStyle")]
        public virtual string DashStyle { get; set; }

        /// <summary>The width of the border.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual Dimension Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Location of a single cell within a table.</summary>
    public class TableCellLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The zero-based column index. For example, the second column in the table has a column index of 1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnIndex")]
        public virtual System.Nullable<int> ColumnIndex { get; set; }

        /// <summary>The zero-based row index. For example, the second row in the table has a row index of 1.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowIndex")]
        public virtual System.Nullable<int> RowIndex { get; set; }

        /// <summary>The location where the table starts in the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableStartLocation")]
        public virtual Location TableStartLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The style of a TableCell. Inherited table cell styles are represented as unset fields in this message. A table
    /// cell style can inherit from the table's style.
    /// </summary>
    public class TableCellStyle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The background color of the cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backgroundColor")]
        public virtual OptionalColor BackgroundColor { get; set; }

        /// <summary>The bottom border of the cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("borderBottom")]
        public virtual TableCellBorder BorderBottom { get; set; }

        /// <summary>The left border of the cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("borderLeft")]
        public virtual TableCellBorder BorderLeft { get; set; }

        /// <summary>The right border of the cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("borderRight")]
        public virtual TableCellBorder BorderRight { get; set; }

        /// <summary>The top border of the cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("borderTop")]
        public virtual TableCellBorder BorderTop { get; set; }

        /// <summary>The column span of the cell. This property is read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnSpan")]
        public virtual System.Nullable<int> ColumnSpan { get; set; }

        /// <summary>
        /// The alignment of the content in the table cell. The default alignment matches the alignment for newly
        /// created table cells in the Docs editor.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentAlignment")]
        public virtual string ContentAlignment { get; set; }

        /// <summary>The bottom padding of the cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paddingBottom")]
        public virtual Dimension PaddingBottom { get; set; }

        /// <summary>The left padding of the cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paddingLeft")]
        public virtual Dimension PaddingLeft { get; set; }

        /// <summary>The right padding of the cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paddingRight")]
        public virtual Dimension PaddingRight { get; set; }

        /// <summary>The top padding of the cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paddingTop")]
        public virtual Dimension PaddingTop { get; set; }

        /// <summary>The row span of the cell. This property is read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowSpan")]
        public virtual System.Nullable<int> RowSpan { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A mask that indicates which of the fields on the base TableCellStyle have been changed in this suggestion. For
    /// any field set to true, there is a new suggested value.
    /// </summary>
    public class TableCellStyleSuggestionState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates if there was a suggested change to background_color.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backgroundColorSuggested")]
        public virtual System.Nullable<bool> BackgroundColorSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to border_bottom.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("borderBottomSuggested")]
        public virtual System.Nullable<bool> BorderBottomSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to border_left.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("borderLeftSuggested")]
        public virtual System.Nullable<bool> BorderLeftSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to border_right.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("borderRightSuggested")]
        public virtual System.Nullable<bool> BorderRightSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to border_top.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("borderTopSuggested")]
        public virtual System.Nullable<bool> BorderTopSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to column_span.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnSpanSuggested")]
        public virtual System.Nullable<bool> ColumnSpanSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to content_alignment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentAlignmentSuggested")]
        public virtual System.Nullable<bool> ContentAlignmentSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to padding_bottom.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paddingBottomSuggested")]
        public virtual System.Nullable<bool> PaddingBottomSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to padding_left.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paddingLeftSuggested")]
        public virtual System.Nullable<bool> PaddingLeftSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to padding_right.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paddingRightSuggested")]
        public virtual System.Nullable<bool> PaddingRightSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to padding_top.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paddingTopSuggested")]
        public virtual System.Nullable<bool> PaddingTopSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to row_span.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowSpanSuggested")]
        public virtual System.Nullable<bool> RowSpanSuggested { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of a column in a table.</summary>
    public class TableColumnProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The width of the column. Set when the column's `width_type` is FIXED_WIDTH.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual Dimension Width { get; set; }

        /// <summary>The width type of the column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("widthType")]
        public virtual string WidthType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A StructuralElement representing a table of contents.</summary>
    public class TableOfContents : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The content of the table of contents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual System.Collections.Generic.IList<StructuralElement> Content { get; set; }

        /// <summary>
        /// The suggested deletion IDs. If empty, then there are no suggested deletions of this content.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedDeletionIds")]
        public virtual System.Collections.Generic.IList<string> SuggestedDeletionIds { get; set; }

        /// <summary>
        /// The suggested insertion IDs. A TableOfContents may have multiple insertion IDs if it is a nested suggested
        /// change. If empty, then this is not a suggested insertion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedInsertionIds")]
        public virtual System.Collections.Generic.IList<string> SuggestedInsertionIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A table range represents a reference to a subset of a table. It's important to note that the cells specified by
    /// a table range do not necessarily form a rectangle. For example, let's say we have a 3 x 3 table where all the
    /// cells of the last row are merged together. The table looks like this: [ ] A table range with table cell location
    /// = (table_start_location, row = 0, column = 0), row span = 3 and column span = 2 specifies the following cells: x
    /// x [ x x x ]
    /// </summary>
    public class TableRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The column span of the table range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnSpan")]
        public virtual System.Nullable<int> ColumnSpan { get; set; }

        /// <summary>The row span of the table range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowSpan")]
        public virtual System.Nullable<int> RowSpan { get; set; }

        /// <summary>The cell location where the table range starts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableCellLocation")]
        public virtual TableCellLocation TableCellLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The contents and style of a row in a Table.</summary>
    public class TableRow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The zero-based end index of this row, exclusive, in UTF-16 code units.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endIndex")]
        public virtual System.Nullable<int> EndIndex { get; set; }

        /// <summary>The zero-based start index of this row, in UTF-16 code units.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; }

        /// <summary>
        /// The suggested deletion IDs. If empty, then there are no suggested deletions of this content.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedDeletionIds")]
        public virtual System.Collections.Generic.IList<string> SuggestedDeletionIds { get; set; }

        /// <summary>
        /// The suggested insertion IDs. A TableRow may have multiple insertion IDs if it is a nested suggested change.
        /// If empty, then this is not a suggested insertion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedInsertionIds")]
        public virtual System.Collections.Generic.IList<string> SuggestedInsertionIds { get; set; }

        /// <summary>The suggested style changes to this row, keyed by suggestion ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedTableRowStyleChanges")]
        public virtual System.Collections.Generic.IDictionary<string, SuggestedTableRowStyle> SuggestedTableRowStyleChanges { get; set; }

        /// <summary>
        /// The contents and style of each cell in this row. It is possible for a table to be non-rectangular, so some
        /// rows may have a different number of cells than other rows in the same table.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableCells")]
        public virtual System.Collections.Generic.IList<TableCell> TableCells { get; set; }

        /// <summary>The style of the table row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableRowStyle")]
        public virtual TableRowStyle TableRowStyle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Styles that apply to a table row.</summary>
    public class TableRowStyle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The minimum height of the row. The row will be rendered in the Docs editor at a height equal to or greater
        /// than this value in order to show all the content in the row's cells.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minRowHeight")]
        public virtual Dimension MinRowHeight { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A mask that indicates which of the fields on the base TableRowStyle have been changed in this suggestion. For
    /// any field set to true, there is a new suggested value.
    /// </summary>
    public class TableRowStyleSuggestionState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates if there was a suggested change to min_row_height.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minRowHeightSuggested")]
        public virtual System.Nullable<bool> MinRowHeightSuggested { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Styles that apply to a table.</summary>
    public class TableStyle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The properties of each column. Note that in Docs, tables contain rows and rows contain cells, similar to
        /// HTML. So the properties for a row can be found on the row's table_row_style.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableColumnProperties")]
        public virtual System.Collections.Generic.IList<TableColumnProperties> TableColumnProperties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A ParagraphElement that represents a run of text that all has the same styling.</summary>
    public class TextRun : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The text of this run. Any non-text elements in the run are replaced with the Unicode character U+E907.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>
        /// The suggested deletion IDs. If empty, then there are no suggested deletions of this content.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedDeletionIds")]
        public virtual System.Collections.Generic.IList<string> SuggestedDeletionIds { get; set; }

        /// <summary>
        /// The suggested insertion IDs. A TextRun may have multiple insertion IDs if it is a nested suggested change.
        /// If empty, then this is not a suggested insertion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedInsertionIds")]
        public virtual System.Collections.Generic.IList<string> SuggestedInsertionIds { get; set; }

        /// <summary>The suggested text style changes to this run, keyed by suggestion ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedTextStyleChanges")]
        public virtual System.Collections.Generic.IDictionary<string, SuggestedTextStyle> SuggestedTextStyleChanges { get; set; }

        /// <summary>The text style of this run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textStyle")]
        public virtual TextStyle TextStyle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents the styling that can be applied to text. Inherited text styles are represented as unset fields in
    /// this message. A text style's parent depends on where the text style is defined: * The TextStyle of text in a
    /// Paragraph inherits from the paragraph's corresponding named style type. * The TextStyle on a named style
    /// inherits from the normal text named style. * The TextStyle of the normal text named style inherits from the
    /// default text style in the Docs editor. * The TextStyle on a Paragraph element that is contained in a table may
    /// inherit its text style from the table style. If the text style does not inherit from a parent, unsetting fields
    /// will revert the style to a value matching the defaults in the Docs editor.
    /// </summary>
    public class TextStyle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The background color of the text. If set, the color is either an RGB color or transparent, depending on the
        /// `color` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backgroundColor")]
        public virtual OptionalColor BackgroundColor { get; set; }

        /// <summary>
        /// The text's vertical offset from its normal position. Text with `SUPERSCRIPT` or `SUBSCRIPT` baseline offsets
        /// is automatically rendered in a smaller font size, computed based on the `font_size` field. The `font_size`
        /// itself is not affected by changes in this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baselineOffset")]
        public virtual string BaselineOffset { get; set; }

        /// <summary>Whether or not the text is rendered as bold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bold")]
        public virtual System.Nullable<bool> Bold { get; set; }

        /// <summary>The size of the text's font.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fontSize")]
        public virtual Dimension FontSize { get; set; }

        /// <summary>
        /// The foreground color of the text. If set, the color is either an RGB color or transparent, depending on the
        /// `color` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("foregroundColor")]
        public virtual OptionalColor ForegroundColor { get; set; }

        /// <summary>Whether or not the text is italicized.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("italic")]
        public virtual System.Nullable<bool> Italic { get; set; }

        /// <summary>
        /// The hyperlink destination of the text. If unset, there is no link. Links are not inherited from parent text.
        /// Changing the link in an update request causes some other changes to the text style of the range: * When
        /// setting a link, the text foreground color will be updated to the default link color and the text will be
        /// underlined. If these fields are modified in the same request, those values will be used instead of the link
        /// defaults. * Setting a link on a text range that overlaps with an existing link will also update the existing
        /// link to point to the new URL. * Links are not settable on newline characters. As a result, setting a link on
        /// a text range that crosses a paragraph boundary, such as `"ABC\n123"`, will separate the newline character(s)
        /// into their own text runs. The link will be applied separately to the runs before and after the newline. *
        /// Removing a link will update the text style of the range to match the style of the preceding text (or the
        /// default text styles if the preceding text is another link) unless different styles are being set in the same
        /// request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("link")]
        public virtual Link Link { get; set; }

        /// <summary>Whether or not the text is in small capital letters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("smallCaps")]
        public virtual System.Nullable<bool> SmallCaps { get; set; }

        /// <summary>Whether or not the text is struck through.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("strikethrough")]
        public virtual System.Nullable<bool> Strikethrough { get; set; }

        /// <summary>Whether or not the text is underlined.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("underline")]
        public virtual System.Nullable<bool> Underline { get; set; }

        /// <summary>
        /// The font family and rendered weight of the text. If an update request specifies values for both
        /// `weighted_font_family` and `bold`, the `weighted_font_family` is applied first, then `bold`. If
        /// `weighted_font_family#weight` is not set, it defaults to `400`. If `weighted_font_family` is set, then
        /// `weighted_font_family#font_family` must also be set with a non-empty value. Otherwise, a 400 bad request
        /// error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weightedFontFamily")]
        public virtual WeightedFontFamily WeightedFontFamily { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A mask that indicates which of the fields on the base TextStyle have been changed in this suggestion. For any
    /// field set to true, there is a new suggested value.
    /// </summary>
    public class TextStyleSuggestionState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates if there was a suggested change to background_color.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backgroundColorSuggested")]
        public virtual System.Nullable<bool> BackgroundColorSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to baseline_offset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baselineOffsetSuggested")]
        public virtual System.Nullable<bool> BaselineOffsetSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to bold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boldSuggested")]
        public virtual System.Nullable<bool> BoldSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to font_size.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fontSizeSuggested")]
        public virtual System.Nullable<bool> FontSizeSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to foreground_color.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("foregroundColorSuggested")]
        public virtual System.Nullable<bool> ForegroundColorSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to italic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("italicSuggested")]
        public virtual System.Nullable<bool> ItalicSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkSuggested")]
        public virtual System.Nullable<bool> LinkSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to small_caps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("smallCapsSuggested")]
        public virtual System.Nullable<bool> SmallCapsSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to strikethrough.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("strikethroughSuggested")]
        public virtual System.Nullable<bool> StrikethroughSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to underline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("underlineSuggested")]
        public virtual System.Nullable<bool> UnderlineSuggested { get; set; }

        /// <summary>Indicates if there was a suggested change to weighted_font_family.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weightedFontFamilySuggested")]
        public virtual System.Nullable<bool> WeightedFontFamilySuggested { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Unmerges cells in a Table.</summary>
    public class UnmergeTableCellsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The table range specifying which cells of the table to unmerge. All merged cells in this range will be
        /// unmerged, and cells that are already unmerged will not be affected. If the range has no merged cells, the
        /// request will do nothing. If there is text in any of the merged cells, the text will remain in the "head"
        /// cell of the resulting block of unmerged cells. The "head" cell is the upper-left cell when the content
        /// direction is from left to right, and the upper-right otherwise.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableRange")]
        public virtual TableRange TableRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Updates the DocumentStyle.</summary>
    public class UpdateDocumentStyleRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The styles to set on the document. Certain document style changes may cause other changes in order to mirror
        /// the behavior of the Docs editor. See the documentation of DocumentStyle for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentStyle")]
        public virtual DocumentStyle DocumentStyle { get; set; }

        /// <summary>
        /// The fields that should be updated. At least one field must be specified. The root `document_style` is
        /// implied and should not be specified. A single `"*"` can be used as short-hand for listing every field. For
        /// example to update the background, set `fields` to `"background"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual object Fields { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Update the styling of all paragraphs that overlap with the given range.</summary>
    public class UpdateParagraphStyleRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fields that should be updated. At least one field must be specified. The root `paragraph_style` is
        /// implied and should not be specified. For example, to update the paragraph style's alignment property, set
        /// `fields` to `"alignment"`. To reset a property to its default value, include its field name in the field
        /// mask but leave the field itself unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual object Fields { get; set; }

        /// <summary>
        /// The styles to set on the paragraphs. Certain paragraph style changes may cause other changes in order to
        /// mirror the behavior of the Docs editor. See the documentation of ParagraphStyle for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paragraphStyle")]
        public virtual ParagraphStyle ParagraphStyle { get; set; }

        /// <summary>The range overlapping the paragraphs to style.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual Range Range { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Updates the SectionStyle.</summary>
    public class UpdateSectionStyleRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fields that should be updated. At least one field must be specified. The root `section_style` is implied
        /// and must not be specified. A single `"*"` can be used as short-hand for listing every field. For example to
        /// update the left margin, set `fields` to `"margin_left"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual object Fields { get; set; }

        /// <summary>
        /// The range overlapping the sections to style. Because section breaks can only be inserted inside the body,
        /// the segment ID field must be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual Range Range { get; set; }

        /// <summary>
        /// The styles to be set on the section. Certain section style changes may cause other changes in order to
        /// mirror the behavior of the Docs editor. See the documentation of SectionStyle for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sectionStyle")]
        public virtual SectionStyle SectionStyle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Updates the style of a range of table cells.</summary>
    public class UpdateTableCellStyleRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fields that should be updated. At least one field must be specified. The root `tableCellStyle` is
        /// implied and should not be specified. A single `"*"` can be used as short-hand for listing every field. For
        /// example to update the table cell background color, set `fields` to `"backgroundColor"`. To reset a property
        /// to its default value, include its field name in the field mask but leave the field itself unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual object Fields { get; set; }

        /// <summary>
        /// The style to set on the table cells. When updating borders, if a cell shares a border with an adjacent cell,
        /// the corresponding border property of the adjacent cell is updated as well. Borders that are merged and
        /// invisible are not updated. Since updating a border shared by adjacent cells in the same request can cause
        /// conflicting border updates, border updates are applied in the following order: - `border_right` -
        /// `border_left` - `border_bottom` - `border_top`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableCellStyle")]
        public virtual TableCellStyle TableCellStyle { get; set; }

        /// <summary>The table range representing the subset of the table to which the updates are applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableRange")]
        public virtual TableRange TableRange { get; set; }

        /// <summary>
        /// The location where the table starts in the document. When specified, the updates are applied to all the
        /// cells in the table.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableStartLocation")]
        public virtual Location TableStartLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Updates the TableColumnProperties of columns in a table.</summary>
    public class UpdateTableColumnPropertiesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of zero-based column indices whose property should be updated. If no indices are specified, all
        /// columns will be updated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnIndices")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> ColumnIndices { get; set; }

        /// <summary>
        /// The fields that should be updated. At least one field must be specified. The root `tableColumnProperties` is
        /// implied and should not be specified. A single `"*"` can be used as short-hand for listing every field. For
        /// example to update the column width, set `fields` to `"width"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual object Fields { get; set; }

        /// <summary>
        /// The table column properties to update. If the value of `table_column_properties#width` is less than 5 points
        /// (5/72 inch), a 400 bad request error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableColumnProperties")]
        public virtual TableColumnProperties TableColumnProperties { get; set; }

        /// <summary>The location where the table starts in the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableStartLocation")]
        public virtual Location TableStartLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Updates the TableRowStyle of rows in a table.</summary>
    public class UpdateTableRowStyleRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fields that should be updated. At least one field must be specified. The root `tableRowStyle` is implied
        /// and should not be specified. A single `"*"` can be used as short-hand for listing every field. For example
        /// to update the minimum row height, set `fields` to `"min_row_height"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual object Fields { get; set; }

        /// <summary>
        /// The list of zero-based row indices whose style should be updated. If no indices are specified, all rows will
        /// be updated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowIndices")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> RowIndices { get; set; }

        /// <summary>The styles to be set on the rows.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableRowStyle")]
        public virtual TableRowStyle TableRowStyle { get; set; }

        /// <summary>The location where the table starts in the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableStartLocation")]
        public virtual Location TableStartLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Update the styling of text.</summary>
    public class UpdateTextStyleRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fields that should be updated. At least one field must be specified. The root `text_style` is implied
        /// and should not be specified. A single `"*"` can be used as short-hand for listing every field. For example,
        /// to update the text style to bold, set `fields` to `"bold"`. To reset a property to its default value,
        /// include its field name in the field mask but leave the field itself unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual object Fields { get; set; }

        /// <summary>
        /// The range of text to style. The range may be extended to include adjacent newlines. If the range fully
        /// contains a paragraph belonging to a list, the paragraph's bullet is also updated with the matching text
        /// style. Ranges cannot be inserted inside a relative UpdateTextStyleRequest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual Range Range { get; set; }

        /// <summary>
        /// The styles to set on the text. If the value for a particular style matches that of the parent, that style
        /// will be set to inherit. Certain text style changes may cause other changes in order to to mirror the
        /// behavior of the Docs editor. See the documentation of TextStyle for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textStyle")]
        public virtual TextStyle TextStyle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a font family and weight of text.</summary>
    public class WeightedFontFamily : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The font family of the text. The font family can be any font from the Font menu in Docs or from [Google
        /// Fonts] (https://fonts.google.com/). If the font name is unrecognized, the text is rendered in `Arial`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fontFamily")]
        public virtual string FontFamily { get; set; }

        /// <summary>
        /// The weight of the font. This field can have any value that is a multiple of `100` between `100` and `900`,
        /// inclusive. This range corresponds to the numerical values described in the CSS 2.1 Specification, [section
        /// 15.6](https://www.w3.org/TR/CSS21/fonts.html#font-boldness), with non-numerical values disallowed. The
        /// default value is `400` ("normal"). The font weight makes up just one component of the rendered font weight.
        /// The rendered weight is determined by a combination of the `weight` and the text style's resolved `bold`
        /// value, after accounting for inheritance: * If the text is bold and the weight is less than `400`, the
        /// rendered weight is 400. * If the text is bold and the weight is greater than or equal to `400` but is less
        /// than `700`, the rendered weight is `700`. * If the weight is greater than or equal to `700`, the rendered
        /// weight is equal to the weight. * If the text is not bold, the rendered weight is equal to the weight.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weight")]
        public virtual System.Nullable<int> Weight { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Provides control over how write requests are executed.</summary>
    public class WriteControl : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The revision ID of the document that the write request will be applied to. If this is not the latest
        /// revision of the document, the request will not be processed and will return a 400 bad request error. When a
        /// required revision ID is returned in a response, it indicates the revision ID of the document after the
        /// request was applied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requiredRevisionId")]
        public virtual string RequiredRevisionId { get; set; }

        /// <summary>
        /// The target revision ID of the document that the write request will be applied to. If collaborator changes
        /// have occurred after the document was read using the API, the changes produced by this write request will be
        /// transformed against the collaborator changes. This results in a new revision of the document which
        /// incorporates both the changes in the request and the collaborator changes, and the Docs server will resolve
        /// conflicting changes. When using `target_revision_id`, the API client can be thought of as another
        /// collaborator of the document. The target revision ID may only be used to write to recent versions of a
        /// document. If the target revision is too far behind the latest revision, the request will not be processed
        /// and will return a 400 bad request error and the request should be retried after reading the latest version
        /// of the document. In most cases a `revision_id` will remain valid for use as a target revision for several
        /// minutes after it is read, but for frequently-edited documents this window may be shorter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetRevisionId")]
        public virtual string TargetRevisionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
