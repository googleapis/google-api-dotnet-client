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

namespace Google.Apis.CloudNaturalLanguage.v2
{
    /// <summary>The CloudNaturalLanguage Service.</summary>
    public class CloudNaturalLanguageService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudNaturalLanguageService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudNaturalLanguageService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Documents = new DocumentsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://language.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://language.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "language";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Natural Language API.</summary>
        public class Scope
        {
            /// <summary>Apply machine learning models to reveal the structure and meaning of text</summary>
            public static string CloudLanguage = "https://www.googleapis.com/auth/cloud-language";

            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Natural Language API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Apply machine learning models to reveal the structure and meaning of text</summary>
            public const string CloudLanguage = "https://www.googleapis.com/auth/cloud-language";

            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Documents resource.</summary>
        public virtual DocumentsResource Documents { get; }
    }

    /// <summary>A base abstract class for CloudNaturalLanguage requests.</summary>
    public abstract class CloudNaturalLanguageBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudNaturalLanguageBaseServiceRequest instance.</summary>
        protected CloudNaturalLanguageBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CloudNaturalLanguage parameter list.</summary>
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
        /// Finds named entities (currently proper names and common nouns) in the text along with entity types,
        /// probability, mentions for each entity, and other properties.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual AnalyzeEntitiesRequest AnalyzeEntities(Google.Apis.CloudNaturalLanguage.v2.Data.AnalyzeEntitiesRequest body)
        {
            return new AnalyzeEntitiesRequest(this.service, body);
        }

        /// <summary>
        /// Finds named entities (currently proper names and common nouns) in the text along with entity types,
        /// probability, mentions for each entity, and other properties.
        /// </summary>
        public class AnalyzeEntitiesRequest : CloudNaturalLanguageBaseServiceRequest<Google.Apis.CloudNaturalLanguage.v2.Data.AnalyzeEntitiesResponse>
        {
            /// <summary>Constructs a new AnalyzeEntities request.</summary>
            public AnalyzeEntitiesRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudNaturalLanguage.v2.Data.AnalyzeEntitiesRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudNaturalLanguage.v2.Data.AnalyzeEntitiesRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "analyzeEntities";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/documents:analyzeEntities";

            /// <summary>Initializes AnalyzeEntities parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Analyzes the sentiment of the provided text.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual AnalyzeSentimentRequest AnalyzeSentiment(Google.Apis.CloudNaturalLanguage.v2.Data.AnalyzeSentimentRequest body)
        {
            return new AnalyzeSentimentRequest(this.service, body);
        }

        /// <summary>Analyzes the sentiment of the provided text.</summary>
        public class AnalyzeSentimentRequest : CloudNaturalLanguageBaseServiceRequest<Google.Apis.CloudNaturalLanguage.v2.Data.AnalyzeSentimentResponse>
        {
            /// <summary>Constructs a new AnalyzeSentiment request.</summary>
            public AnalyzeSentimentRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudNaturalLanguage.v2.Data.AnalyzeSentimentRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudNaturalLanguage.v2.Data.AnalyzeSentimentRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "analyzeSentiment";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/documents:analyzeSentiment";

            /// <summary>Initializes AnalyzeSentiment parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>A convenience method that provides all features in one call.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual AnnotateTextRequest AnnotateText(Google.Apis.CloudNaturalLanguage.v2.Data.AnnotateTextRequest body)
        {
            return new AnnotateTextRequest(this.service, body);
        }

        /// <summary>A convenience method that provides all features in one call.</summary>
        public class AnnotateTextRequest : CloudNaturalLanguageBaseServiceRequest<Google.Apis.CloudNaturalLanguage.v2.Data.AnnotateTextResponse>
        {
            /// <summary>Constructs a new AnnotateText request.</summary>
            public AnnotateTextRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudNaturalLanguage.v2.Data.AnnotateTextRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudNaturalLanguage.v2.Data.AnnotateTextRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "annotateText";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/documents:annotateText";

            /// <summary>Initializes AnnotateText parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Classifies a document into categories.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual ClassifyTextRequest ClassifyText(Google.Apis.CloudNaturalLanguage.v2.Data.ClassifyTextRequest body)
        {
            return new ClassifyTextRequest(this.service, body);
        }

        /// <summary>Classifies a document into categories.</summary>
        public class ClassifyTextRequest : CloudNaturalLanguageBaseServiceRequest<Google.Apis.CloudNaturalLanguage.v2.Data.ClassifyTextResponse>
        {
            /// <summary>Constructs a new ClassifyText request.</summary>
            public ClassifyTextRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudNaturalLanguage.v2.Data.ClassifyTextRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudNaturalLanguage.v2.Data.ClassifyTextRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "classifyText";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/documents:classifyText";

            /// <summary>Initializes ClassifyText parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Moderates a document for harmful and sensitive categories.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual ModerateTextRequest ModerateText(Google.Apis.CloudNaturalLanguage.v2.Data.ModerateTextRequest body)
        {
            return new ModerateTextRequest(this.service, body);
        }

        /// <summary>Moderates a document for harmful and sensitive categories.</summary>
        public class ModerateTextRequest : CloudNaturalLanguageBaseServiceRequest<Google.Apis.CloudNaturalLanguage.v2.Data.ModerateTextResponse>
        {
            /// <summary>Constructs a new ModerateText request.</summary>
            public ModerateTextRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudNaturalLanguage.v2.Data.ModerateTextRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudNaturalLanguage.v2.Data.ModerateTextRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "moderateText";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/documents:moderateText";

            /// <summary>Initializes ModerateText parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }
}
namespace Google.Apis.CloudNaturalLanguage.v2.Data
{
    /// <summary>The entity analysis request message.</summary>
    public class AnalyzeEntitiesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Input document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("document")]
        public virtual Document Document { get; set; }

        /// <summary>The encoding type used by the API to calculate offsets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encodingType")]
        public virtual string EncodingType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The entity analysis response message.</summary>
    public class AnalyzeEntitiesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The recognized entities in the input document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entities")]
        public virtual System.Collections.Generic.IList<Entity> Entities { get; set; }

        /// <summary>
        /// The language of the text, which will be the same as the language specified in the request or, if not
        /// specified, the automatically-detected language. See Document.language_code field for more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// Whether the language is officially supported. The API may still return a response when the language is not
        /// supported, but it is on a best effort basis.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageSupported")]
        public virtual System.Nullable<bool> LanguageSupported { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The sentiment analysis request message.</summary>
    public class AnalyzeSentimentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Input document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("document")]
        public virtual Document Document { get; set; }

        /// <summary>The encoding type used by the API to calculate sentence offsets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encodingType")]
        public virtual string EncodingType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The sentiment analysis response message.</summary>
    public class AnalyzeSentimentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The overall sentiment of the input document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentSentiment")]
        public virtual Sentiment DocumentSentiment { get; set; }

        /// <summary>
        /// The language of the text, which will be the same as the language specified in the request or, if not
        /// specified, the automatically-detected language. See Document.language_code field for more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// Whether the language is officially supported. The API may still return a response when the language is not
        /// supported, but it is on a best effort basis.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageSupported")]
        public virtual System.Nullable<bool> LanguageSupported { get; set; }

        /// <summary>The sentiment for all the sentences in the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sentences")]
        public virtual System.Collections.Generic.IList<Sentence> Sentences { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The request message for the text annotation API, which can perform multiple analysis types in one call.
    /// </summary>
    public class AnnotateTextRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Input document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("document")]
        public virtual Document Document { get; set; }

        /// <summary>The encoding type used by the API to calculate offsets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encodingType")]
        public virtual string EncodingType { get; set; }

        /// <summary>Required. The enabled features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("features")]
        public virtual AnnotateTextRequestFeatures Features { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// All available features. Setting each one to true will enable that specific analysis for the input.
    /// </summary>
    public class AnnotateTextRequestFeatures : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Classify the full document into categories.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classifyText")]
        public virtual System.Nullable<bool> ClassifyText { get; set; }

        /// <summary>Optional. Extract document-level sentiment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extractDocumentSentiment")]
        public virtual System.Nullable<bool> ExtractDocumentSentiment { get; set; }

        /// <summary>Optional. Extract entities.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extractEntities")]
        public virtual System.Nullable<bool> ExtractEntities { get; set; }

        /// <summary>Optional. Moderate the document for harmful and sensitive categories.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moderateText")]
        public virtual System.Nullable<bool> ModerateText { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The text annotations response message.</summary>
    public class AnnotateTextResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Categories identified in the input document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categories")]
        public virtual System.Collections.Generic.IList<ClassificationCategory> Categories { get; set; }

        /// <summary>
        /// The overall sentiment for the document. Populated if the user enables
        /// AnnotateTextRequest.Features.extract_document_sentiment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentSentiment")]
        public virtual Sentiment DocumentSentiment { get; set; }

        /// <summary>
        /// Entities, along with their semantic information, in the input document. Populated if the user enables
        /// AnnotateTextRequest.Features.extract_entities .
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entities")]
        public virtual System.Collections.Generic.IList<Entity> Entities { get; set; }

        /// <summary>
        /// The language of the text, which will be the same as the language specified in the request or, if not
        /// specified, the automatically-detected language. See Document.language_code field for more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// Whether the language is officially supported by all requested features. The API may still return a response
        /// when the language is not supported, but it is on a best effort basis.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageSupported")]
        public virtual System.Nullable<bool> LanguageSupported { get; set; }

        /// <summary>Harmful and sensitive categories identified in the input document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moderationCategories")]
        public virtual System.Collections.Generic.IList<ClassificationCategory> ModerationCategories { get; set; }

        /// <summary>
        /// Sentences in the input document. Populated if the user enables
        /// AnnotateTextRequest.Features.extract_document_sentiment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sentences")]
        public virtual System.Collections.Generic.IList<Sentence> Sentences { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a category returned from the text classifier.</summary>
    public class ClassificationCategory : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The classifier's confidence of the category. Number represents how certain the classifier is that this
        /// category represents the given text.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>The name of the category representing the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. The classifier's severity of the category. This is only present when the
        /// ModerateTextRequest.ModelVersion is set to MODEL_VERSION_2, and the corresponding category has a severity
        /// score.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual System.Nullable<float> Severity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The document classification request message.</summary>
    public class ClassifyTextRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Input document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("document")]
        public virtual Document Document { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The document classification response message.</summary>
    public class ClassifyTextResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Categories representing the input document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categories")]
        public virtual System.Collections.Generic.IList<ClassificationCategory> Categories { get; set; }

        /// <summary>
        /// The language of the text, which will be the same as the language specified in the request or, if not
        /// specified, the automatically-detected language. See Document.language_code field for more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// Whether the language is officially supported. The API may still return a response when the language is not
        /// supported, but it is on a best effort basis.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageSupported")]
        public virtual System.Nullable<bool> LanguageSupported { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a color in the RGBA color space. This representation is designed for simplicity of conversion to and
    /// from color representations in various languages over compactness. For example, the fields of this representation
    /// can be trivially provided to the constructor of `java.awt.Color` in Java; it can also be trivially provided to
    /// UIColor's `+colorWithRed:green:blue:alpha` method in iOS; and, with just a little work, it can be easily
    /// formatted into a CSS `rgba()` string in JavaScript. This reference page doesn't have information about the
    /// absolute color space that should be used to interpret the RGB value—for example, sRGB, Adobe RGB, DCI-P3, and
    /// BT.2020. By default, applications should assume the sRGB color space. When color equality needs to be decided,
    /// implementations, unless documented otherwise, treat two colors as equal if all their red, green, blue, and alpha
    /// values each differ by at most `1e-5`. Example (Java): import com.google.type.Color; // ... public static
    /// java.awt.Color fromProto(Color protocolor) { float alpha = protocolor.hasAlpha() ?
    /// protocolor.getAlpha().getValue() : 1.0; return new java.awt.Color( protocolor.getRed(), protocolor.getGreen(),
    /// protocolor.getBlue(), alpha); } public static Color toProto(java.awt.Color color) { float red = (float)
    /// color.getRed(); float green = (float) color.getGreen(); float blue = (float) color.getBlue(); float denominator
    /// = 255.0; Color.Builder resultBuilder = Color .newBuilder() .setRed(red / denominator) .setGreen(green /
    /// denominator) .setBlue(blue / denominator); int alpha = color.getAlpha(); if (alpha != 255) { result.setAlpha(
    /// FloatValue .newBuilder() .setValue(((float) alpha) / denominator) .build()); } return resultBuilder.build(); }
    /// // ... Example (iOS / Obj-C): // ... static UIColor* fromProto(Color* protocolor) { float red = [protocolor
    /// red]; float green = [protocolor green]; float blue = [protocolor blue]; FloatValue* alpha_wrapper = [protocolor
    /// alpha]; float alpha = 1.0; if (alpha_wrapper != nil) { alpha = [alpha_wrapper value]; } return [UIColor
    /// colorWithRed:red green:green blue:blue alpha:alpha]; } static Color* toProto(UIColor* color) { CGFloat red,
    /// green, blue, alpha; if (![color getRed:&amp;amp;red green:&amp;amp;green blue:&amp;amp;blue
    /// alpha:&amp;amp;alpha]) { return nil; } Color* result = [[Color alloc] init]; [result setRed:red]; [result
    /// setGreen:green]; [result setBlue:blue]; if (alpha &amp;lt;= 0.9999) { [result
    /// setAlpha:floatWrapperWithValue(alpha)]; } [result autorelease]; return result; } // ... Example (JavaScript): //
    /// ... var protoToCssColor = function(rgb_color) { var redFrac = rgb_color.red || 0.0; var greenFrac =
    /// rgb_color.green || 0.0; var blueFrac = rgb_color.blue || 0.0; var red = Math.floor(redFrac * 255); var green =
    /// Math.floor(greenFrac * 255); var blue = Math.floor(blueFrac * 255); if (!('alpha' in rgb_color)) { return
    /// rgbToCssColor(red, green, blue); } var alphaFrac = rgb_color.alpha.value || 0.0; var rgbParams = [red, green,
    /// blue].join(','); return ['rgba(', rgbParams, ',', alphaFrac, ')'].join(''); }; var rgbToCssColor = function(red,
    /// green, blue) { var rgbNumber = new Number((red &amp;lt;&amp;lt; 16) | (green &amp;lt;&amp;lt; 8) | blue); var
    /// hexString = rgbNumber.toString(16); var missingZeros = 6 - hexString.length; var resultBuilder = ['#']; for (var
    /// i = 0; i &amp;lt; missingZeros; i++) { resultBuilder.push('0'); } resultBuilder.push(hexString); return
    /// resultBuilder.join(''); }; // ...
    /// </summary>
    public class Color : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fraction of this color that should be applied to the pixel. That is, the final pixel color is defined by
        /// the equation: `pixel color = alpha * (this color) + (1.0 - alpha) * (background color)` This means that a
        /// value of 1.0 corresponds to a solid color, whereas a value of 0.0 corresponds to a completely transparent
        /// color. This uses a wrapper message rather than a simple float scalar so that it is possible to distinguish
        /// between a default value and the value being unset. If omitted, this color object is rendered as a solid
        /// color (as if the alpha value had been explicitly given a value of 1.0).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alpha")]
        public virtual System.Nullable<float> Alpha { get; set; }

        /// <summary>The amount of blue in the color as a value in the interval [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blue")]
        public virtual System.Nullable<float> Blue { get; set; }

        /// <summary>The amount of green in the color as a value in the interval [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("green")]
        public virtual System.Nullable<float> Green { get; set; }

        /// <summary>The amount of red in the color as a value in the interval [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("red")]
        public virtual System.Nullable<float> Red { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metric for billing reports.</summary>
    public class CpuMetric : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Number of CPU cores.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("coreNumber")]
        public virtual System.Nullable<long> CoreNumber { get; set; }

        /// <summary>Required. Total seconds of core usage, e.g. 4.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("coreSec")]
        public virtual System.Nullable<long> CoreSec { get; set; }

        /// <summary>Required. Type of cpu, e.g. N2.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuType")]
        public virtual string CpuType { get; set; }

        /// <summary>Required. Machine spec, e.g. N1_STANDARD_4.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineSpec")]
        public virtual string MachineSpec { get; set; }

        /// <summary>
        /// Billing tracking labels. They do not contain any user data but only the labels set by Vertex Core Infra
        /// itself. Tracking labels' keys are defined with special format: goog-[\p{Ll}\p{N}]+ E.g. "key":
        /// "goog-k8s-cluster-name","value": "us-east1-b4rk"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackingLabels")]
        public virtual System.Collections.Generic.IDictionary<string, string> TrackingLabels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DiskMetric : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Type of Disk, e.g. REGIONAL_SSD.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskType")]
        public virtual string DiskType { get; set; }

        /// <summary>Required. Seconds of physical disk usage, e.g. 3600.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gibSec")]
        public virtual System.Nullable<long> GibSec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the input to API methods.</summary>
    public class Document : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The content of the input in string format. Cloud audit logging exempt since it is based on user data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>
        /// The Google Cloud Storage URI where the file content is located. This URI must be of the form:
        /// gs://bucket_name/object_name. For more details, see https://cloud.google.com/storage/docs/reference-uris.
        /// NOTE: Cloud Storage object versioning is not supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsContentUri")]
        public virtual string GcsContentUri { get; set; }

        /// <summary>
        /// Optional. The language of the document (if not specified, the language is automatically detected). Both ISO
        /// and BCP-47 language codes are accepted. [Language
        /// Support](https://cloud.google.com/natural-language/docs/languages) lists currently supported languages for
        /// each API method. If the language (either specified by the caller or automatically detected) is not supported
        /// by the called API method, an `INVALID_ARGUMENT` error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// Required. If the type is not set or is `TYPE_UNSPECIFIED`, returns an `INVALID_ARGUMENT` error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a phrase in the text that is a known entity, such as a person, an organization, or location. The API
    /// associates information, such as probability and mentions, with entities.
    /// </summary>
    public class Entity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The mentions of this entity in the input document. The API currently supports proper noun mentions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mentions")]
        public virtual System.Collections.Generic.IList<EntityMention> Mentions { get; set; }

        /// <summary>
        /// Metadata associated with the entity. For the metadata associated with other entity types, see the Type table
        /// below.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata { get; set; }

        /// <summary>The representative name for the entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// For calls to AnalyzeEntitySentiment this field will contain the aggregate sentiment expressed for this
        /// entity in the provided document.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sentiment")]
        public virtual Sentiment Sentiment { get; set; }

        /// <summary>The entity type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a mention for an entity in the text. Currently, proper noun mentions are supported.
    /// </summary>
    public class EntityMention : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Probability score associated with the entity. The score shows the probability of the entity mention being
        /// the entity type. The score is in (0, 1] range.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("probability")]
        public virtual System.Nullable<float> Probability { get; set; }

        /// <summary>
        /// For calls to AnalyzeEntitySentiment this field will contain the sentiment expressed for this mention of the
        /// entity in the provided document.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sentiment")]
        public virtual Sentiment Sentiment { get; set; }

        /// <summary>The mention text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual TextSpan Text { get; set; }

        /// <summary>The type of the entity mention.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GpuMetric : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Seconds of GPU usage, e.g. 3600.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gpuSec")]
        public virtual System.Nullable<long> GpuSec { get; set; }

        /// <summary>Required. Type of GPU, e.g. NVIDIA_TESLA_V100.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gpuType")]
        public virtual string GpuType { get; set; }

        /// <summary>Required. Machine spec, e.g. N1_STANDARD_4.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineSpec")]
        public virtual string MachineSpec { get; set; }

        /// <summary>
        /// Billing tracking labels. They do not contain any user data but only the labels set by Vertex Core Infra
        /// itself. Tracking labels' keys are defined with special format: goog-[\p{Ll}\p{N}]+ E.g. "key":
        /// "goog-k8s-cluster-name","value": "us-east1-b4rk"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackingLabels")]
        public virtual System.Collections.Generic.IDictionary<string, string> TrackingLabels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>LINT: LEGACY_NAMES Infra Usage of billing metrics.</summary>
    public class InfraUsage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Aggregated core metrics since requested start_time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuMetrics")]
        public virtual System.Collections.Generic.IList<CpuMetric> CpuMetrics { get; set; }

        /// <summary>Aggregated persistent disk metrics since requested start_time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskMetrics")]
        public virtual System.Collections.Generic.IList<DiskMetric> DiskMetrics { get; set; }

        /// <summary>Aggregated gpu metrics since requested start_time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gpuMetrics")]
        public virtual System.Collections.Generic.IList<GpuMetric> GpuMetrics { get; set; }

        /// <summary>Aggregated ram metrics since requested start_time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ramMetrics")]
        public virtual System.Collections.Generic.IList<RamMetric> RamMetrics { get; set; }

        /// <summary>Aggregated tpu metrics since requested start_time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tpuMetrics")]
        public virtual System.Collections.Generic.IList<TpuMetric> TpuMetrics { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The document moderation request message.</summary>
    public class ModerateTextRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Input document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("document")]
        public virtual Document Document { get; set; }

        /// <summary>Optional. The model version to use for ModerateText.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelVersion")]
        public virtual string ModelVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The document moderation response message.</summary>
    public class ModerateTextResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The language of the text, which will be the same as the language specified in the request or, if not
        /// specified, the automatically-detected language. See Document.language_code field for more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// Whether the language is officially supported. The API may still return a response when the language is not
        /// supported, but it is on a best effort basis.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageSupported")]
        public virtual System.Nullable<bool> LanguageSupported { get; set; }

        /// <summary>Harmful and sensitive categories representing the input document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moderationCategories")]
        public virtual System.Collections.Generic.IList<ClassificationCategory> ModerationCategories { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class RamMetric : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. VM memory in Gigabyte second, e.g. 3600. Using int64 type to match billing metrics definition.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gibSec")]
        public virtual System.Nullable<long> GibSec { get; set; }

        /// <summary>Required. Machine spec, e.g. N1_STANDARD_4.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineSpec")]
        public virtual string MachineSpec { get; set; }

        /// <summary>Required. VM memory in gb.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memories")]
        public virtual System.Nullable<double> Memories { get; set; }

        /// <summary>Required. Type of ram.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ramType")]
        public virtual string RamType { get; set; }

        /// <summary>
        /// Billing tracking labels. They do not contain any user data but only the labels set by Vertex Core Infra
        /// itself. Tracking labels' keys are defined with special format: goog-[\p{Ll}\p{N}]+ E.g. "key":
        /// "goog-k8s-cluster-name","value": "us-east1-b4rk"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackingLabels")]
        public virtual System.Collections.Generic.IDictionary<string, string> TrackingLabels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a sentence in the input document.</summary>
    public class Sentence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// For calls to AnalyzeSentiment or if AnnotateTextRequest.Features.extract_document_sentiment is set to true,
        /// this field will contain the sentiment for the sentence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sentiment")]
        public virtual Sentiment Sentiment { get; set; }

        /// <summary>The sentence text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual TextSpan Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the feeling associated with the entire text or entities in the text.</summary>
    public class Sentiment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A non-negative number in the [0, +inf] range, which represents the absolute magnitude of sentiment
        /// regardless of score (positive or negative).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("magnitude")]
        public virtual System.Nullable<float> Magnitude { get; set; }

        /// <summary>Sentiment score between -1.0 (negative sentiment) and 1.0 (positive sentiment).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

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

    /// <summary>Represents a text span in the input document.</summary>
    public class TextSpan : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The API calculates the beginning offset of the content in the original document according to the
        /// EncodingType specified in the API request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("beginOffset")]
        public virtual System.Nullable<int> BeginOffset { get; set; }

        /// <summary>The content of the text span, which is a substring of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class TpuMetric : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Seconds of TPU usage, e.g. 3600.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tpuSec")]
        public virtual System.Nullable<long> TpuSec { get; set; }

        /// <summary>Required. Type of TPU, e.g. TPU_V2, TPU_V3_POD.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tpuType")]
        public virtual string TpuType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The data statistics of a series of ARRAY values.</summary>
    public class XPSArrayStats : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("commonStats")]
        public virtual XPSCommonStats CommonStats { get; set; }

        /// <summary>
        /// Stats of all the values of all arrays, as if they were a single long series of data. The type depends on the
        /// element type of the array.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memberStats")]
        public virtual XPSDataStats MemberStats { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class XPSBatchPredictResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Examples for batch prediction result. Under full API implementation, results are stored in shared RecordIO
        /// of AnnotatedExample protobufs, the annotations field of which is populated by XPS backend.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exampleSet")]
        public virtual XPSExampleSet ExampleSet { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Bounding box matching model metrics for a single intersection-over-union threshold and multiple label match
    /// confidence thresholds.
    /// </summary>
    public class XPSBoundingBoxMetricsEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Metrics for each label-match confidence_threshold from 0.05,0.10,...,0.95,0.96,0.97,0.98,0.99.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidenceMetricsEntries")]
        public virtual System.Collections.Generic.IList<XPSBoundingBoxMetricsEntryConfidenceMetricsEntry> ConfidenceMetricsEntries { get; set; }

        /// <summary>The intersection-over-union threshold value used to compute this metrics entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iouThreshold")]
        public virtual System.Nullable<float> IouThreshold { get; set; }

        /// <summary>The mean average precision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meanAveragePrecision")]
        public virtual System.Nullable<float> MeanAveragePrecision { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metrics for a single confidence threshold.</summary>
    public class XPSBoundingBoxMetricsEntryConfidenceMetricsEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The confidence threshold value used to compute the metrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidenceThreshold")]
        public virtual System.Nullable<float> ConfidenceThreshold { get; set; }

        /// <summary>The harmonic mean of recall and precision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("f1Score")]
        public virtual System.Nullable<float> F1Score { get; set; }

        /// <summary>Precision for the given confidence threshold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("precision")]
        public virtual System.Nullable<float> Precision { get; set; }

        /// <summary>Recall for the given confidence threshold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recall")]
        public virtual System.Nullable<float> Recall { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The data statistics of a series of CATEGORY values.</summary>
    public class XPSCategoryStats : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("commonStats")]
        public virtual XPSCommonStats CommonStats { get; set; }

        /// <summary>
        /// The statistics of the top 20 CATEGORY values, ordered by CategoryStats.SingleCategoryStats.count.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topCategoryStats")]
        public virtual System.Collections.Generic.IList<XPSCategoryStatsSingleCategoryStats> TopCategoryStats { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The statistics of a single CATEGORY value.</summary>
    public class XPSCategoryStatsSingleCategoryStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of occurrences of this value in the series.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>The CATEGORY value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Model evaluation metrics for classification problems. It can be used for image and video classification. Next
    /// tag: 9.
    /// </summary>
    public class XPSClassificationEvaluationMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Area under precision recall curve metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auPrc")]
        public virtual System.Nullable<float> AuPrc { get; set; }

        /// <summary>
        /// The Area Under Receiver Operating Characteristic curve metric. Micro-averaged for the overall evaluation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auRoc")]
        public virtual System.Nullable<float> AuRoc { get; set; }

        /// <summary>The Area under precision recall curve metric based on priors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseAuPrc")]
        public virtual System.Nullable<float> BaseAuPrc { get; set; }

        /// <summary>Metrics that have confidence thresholds. Precision-recall curve can be derived from it.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidenceMetricsEntries")]
        public virtual System.Collections.Generic.IList<XPSConfidenceMetricsEntry> ConfidenceMetricsEntries { get; set; }

        /// <summary>
        /// Confusion matrix of the evaluation. Only set for MULTICLASS classification problems where number of
        /// annotation specs is no more than 10. Only set for model level evaluation, not for evaluation per label.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confusionMatrix")]
        public virtual XPSConfusionMatrix ConfusionMatrix { get; set; }

        /// <summary>The number of examples used for model evaluation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluatedExamplesCount")]
        public virtual System.Nullable<int> EvaluatedExamplesCount { get; set; }

        /// <summary>The Log Loss metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logLoss")]
        public virtual System.Nullable<float> LogLoss { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Map from color to display name. Will only be used by Image Segmentation for uCAIP.</summary>
    public class XPSColorMap : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Should be used during training.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationSpecIdToken")]
        public virtual string AnnotationSpecIdToken { get; set; }

        /// <summary>
        /// This type is deprecated in favor of the IntColor below. This is because google.type.Color represent color
        /// has a float which semantically does not reflect discrete classes/categories concept. Moreover, to handle it
        /// well we need to have some tolerance when converting to a discretized color. As such, the recommendation is
        /// to have API surface still use google.type.Color while internally IntColor is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual Color Color { get; set; }

        /// <summary>Should be used during preprocessing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("intColor")]
        public virtual XPSColorMapIntColor IntColor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>RGB color and each channel is represented by an integer.</summary>
    public class XPSColorMapIntColor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The value should be in range of [0, 255].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blue")]
        public virtual System.Nullable<int> Blue { get; set; }

        /// <summary>The value should be in range of [0, 255].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("green")]
        public virtual System.Nullable<int> Green { get; set; }

        /// <summary>The value should be in range of [0, 255].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("red")]
        public virtual System.Nullable<int> Red { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class XPSColumnSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The unique id of the column. When Preprocess, the Tables BE will popuate the order id of the column, which
        /// reflects the order of the column inside the table, i.e. 0 means the first column in the table, N-1 means the
        /// last column. AutoML BE will persist this order id in Spanner and set the order id here when calling
        /// RefreshTablesStats and Train. Note: it's different than the column_spec_id that is generated in AutoML BE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnId")]
        public virtual System.Nullable<int> ColumnId { get; set; }

        /// <summary>
        /// The data stats of the column. It's outputed in RefreshTablesStats and a required input for Train.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataStats")]
        public virtual XPSDataStats DataStats { get; set; }

        /// <summary>
        /// The data type of the column. It's outputed in Preprocess rpc and a required input for RefreshTablesStats and
        /// Train.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataType")]
        public virtual XPSDataType DataType { get; set; }

        /// <summary>
        /// The display name of the column. It's outputed in Preprocess and a required input for RefreshTablesStats and
        /// Train.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("forecastingMetadata")]
        public virtual XPSColumnSpecForecastingMetadata ForecastingMetadata { get; set; }

        /// <summary>It's outputed in RefreshTablesStats, and a required input in Train.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topCorrelatedColumns")]
        public virtual System.Collections.Generic.IList<XPSColumnSpecCorrelatedColumn> TopCorrelatedColumns { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Identifies a table's column, and its correlation with the column this ColumnSpec describes.</summary>
    public class XPSColumnSpecCorrelatedColumn : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("columnId")]
        public virtual System.Nullable<int> ColumnId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("correlationStats")]
        public virtual XPSCorrelationStats CorrelationStats { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class XPSColumnSpecForecastingMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of the column for FORECASTING model training purposes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnType")]
        public virtual string ColumnType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Common statistics for a column with a specified data type.</summary>
    public class XPSCommonStats : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("distinctValueCount")]
        public virtual System.Nullable<long> DistinctValueCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("nullValueCount")]
        public virtual System.Nullable<long> NullValueCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("validValueCount")]
        public virtual System.Nullable<long> ValidValueCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ConfidenceMetricsEntry includes generic precision, recall, f1 score etc. Next tag: 16.</summary>
    public class XPSConfidenceMetricsEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Metrics are computed with an assumption that the model never return predictions with score lower than this
        /// value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidenceThreshold")]
        public virtual System.Nullable<float> ConfidenceThreshold { get; set; }

        /// <summary>The harmonic mean of recall and precision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("f1Score")]
        public virtual System.Nullable<float> F1Score { get; set; }

        /// <summary>The harmonic mean of recall_at1 and precision_at1.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("f1ScoreAt1")]
        public virtual System.Nullable<float> F1ScoreAt1 { get; set; }

        /// <summary>The number of ground truth labels that are not matched by a model created label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("falseNegativeCount")]
        public virtual System.Nullable<long> FalseNegativeCount { get; set; }

        /// <summary>The number of model created labels that do not match a ground truth label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("falsePositiveCount")]
        public virtual System.Nullable<long> FalsePositiveCount { get; set; }

        /// <summary>False Positive Rate for the given confidence threshold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("falsePositiveRate")]
        public virtual System.Nullable<float> FalsePositiveRate { get; set; }

        /// <summary>
        /// The False Positive Rate when only considering the label that has the highest prediction score and not below
        /// the confidence threshold for each example.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("falsePositiveRateAt1")]
        public virtual System.Nullable<float> FalsePositiveRateAt1 { get; set; }

        /// <summary>
        /// Metrics are computed with an assumption that the model always returns at most this many predictions (ordered
        /// by their score, descendingly), but they all still need to meet the confidence_threshold.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("positionThreshold")]
        public virtual System.Nullable<int> PositionThreshold { get; set; }

        /// <summary>Precision for the given confidence threshold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("precision")]
        public virtual System.Nullable<float> Precision { get; set; }

        /// <summary>
        /// The precision when only considering the label that has the highest prediction score and not below the
        /// confidence threshold for each example.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("precisionAt1")]
        public virtual System.Nullable<float> PrecisionAt1 { get; set; }

        /// <summary>Recall (true positive rate) for the given confidence threshold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recall")]
        public virtual System.Nullable<float> Recall { get; set; }

        /// <summary>
        /// The recall (true positive rate) when only considering the label that has the highest prediction score and
        /// not below the confidence threshold for each example.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recallAt1")]
        public virtual System.Nullable<float> RecallAt1 { get; set; }

        /// <summary>
        /// The number of labels that were not created by the model, but if they would, they would not match a ground
        /// truth label.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trueNegativeCount")]
        public virtual System.Nullable<long> TrueNegativeCount { get; set; }

        /// <summary>The number of model created labels that match a ground truth label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("truePositiveCount")]
        public virtual System.Nullable<long> TruePositiveCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Confusion matrix of the model running the classification.</summary>
    public class XPSConfusionMatrix : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// For the following three repeated fields, only one is intended to be set. annotation_spec_id_token is
        /// preferable to be set. ID tokens of the annotation specs used in the confusion matrix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationSpecIdToken")]
        public virtual System.Collections.Generic.IList<string> AnnotationSpecIdToken { get; set; }

        /// <summary>
        /// Category (mainly for segmentation). Set only for image segmentation models. Note: uCAIP Image Segmentation
        /// should use annotation_spec_id_token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> Category { get; set; }

        /// <summary>
        /// Rows in the confusion matrix. The number of rows is equal to the size of `annotation_spec_id_token`.
        /// `row[i].value[j]` is the number of examples that have ground truth of the `annotation_spec_id_token[i]` and
        /// are predicted as `annotation_spec_id_token[j]` by the model being evaluated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("row")]
        public virtual System.Collections.Generic.IList<XPSConfusionMatrixRow> Row { get; set; }

        /// <summary>
        /// Sentiment labels used in the confusion matrix. Set only for text sentiment models. For AutoML Text Revamp,
        /// use `annotation_spec_id_token` instead and leave this field empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sentimentLabel")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> SentimentLabel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A row in the confusion matrix.</summary>
    public class XPSConfusionMatrixRow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Same as above except intended to represent other counts (for e.g. for segmentation this is pixel count).
        /// NOTE(params): Only example_count or count is set (oneoff does not support repeated fields unless they are
        /// embedded inside another message).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> Count { get; set; }

        /// <summary>
        /// Value of the specific cell in the confusion matrix. The number of values each row has (i.e. the length of
        /// the row) is equal to the length of the annotation_spec_id_token field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exampleCount")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> ExampleCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A model format used for iOS mobile devices.</summary>
    public class XPSCoreMlFormat : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A correlation statistics between two series of DataType values. The series may have differing DataType-s, but
    /// within a single series the DataType must be the same.
    /// </summary>
    public class XPSCorrelationStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The correlation value using the Cramer's V measure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cramersV")]
        public virtual System.Nullable<double> CramersV { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Different types of errors and the stats associatesd with each error.</summary>
    public class XPSDataErrors : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of records having errors associated with the enum.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<int> Count { get; set; }

        /// <summary>Type of the error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorType")]
        public virtual string ErrorType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The data statistics of a series of values that share the same DataType.</summary>
    public class XPSDataStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The statistics for ARRAY DataType.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("arrayStats")]
        public virtual XPSArrayStats ArrayStats { get; set; }

        /// <summary>The statistics for CATEGORY DataType.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryStats")]
        public virtual XPSCategoryStats CategoryStats { get; set; }

        /// <summary>The number of distinct values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distinctValueCount")]
        public virtual System.Nullable<long> DistinctValueCount { get; set; }

        /// <summary>The statistics for FLOAT64 DataType.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("float64Stats")]
        public virtual XPSFloat64Stats Float64Stats { get; set; }

        /// <summary>The number of values that are null.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nullValueCount")]
        public virtual System.Nullable<long> NullValueCount { get; set; }

        /// <summary>The statistics for STRING DataType.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringStats")]
        public virtual XPSStringStats StringStats { get; set; }

        /// <summary>The statistics for STRUCT DataType.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("structStats")]
        public virtual XPSStructStats StructStats { get; set; }

        /// <summary>The statistics for TIMESTAMP DataType.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestampStats")]
        public virtual XPSTimestampStats TimestampStats { get; set; }

        /// <summary>The number of values that are valid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validValueCount")]
        public virtual System.Nullable<long> ValidValueCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Indicated the type of data that can be stored in a structured data entity (e.g. a table).</summary>
    public class XPSDataType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The highly compatible data types to this data type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compatibleDataTypes")]
        public virtual System.Collections.Generic.IList<XPSDataType> CompatibleDataTypes { get; set; }

        /// <summary>If type_code == ARRAY, then `list_element_type` is the type of the elements.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listElementType")]
        public virtual XPSDataType ListElementType { get; set; }

        /// <summary>If true, this DataType can also be `null`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nullable")]
        public virtual System.Nullable<bool> Nullable { get; set; }

        /// <summary>
        /// If type_code == STRUCT, then `struct_type` provides type information for the struct's fields.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("structType")]
        public virtual XPSStructType StructType { get; set; }

        /// <summary>
        /// If type_code == TIMESTAMP then `time_format` provides the format in which that time field is expressed. The
        /// time_format must be written in `strftime` syntax. If time_format is not set, then the default format as
        /// described on the field is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeFormat")]
        public virtual string TimeFormat { get; set; }

        /// <summary>Required. The TypeCode for this type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("typeCode")]
        public virtual string TypeCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A model format used for Docker containers. Use the params field to customize the container. The container is
    /// verified to work correctly on ubuntu 16.04 operating system.
    /// </summary>
    public class XPSDockerFormat : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Additional cpu information describing the requirements for the to be exported model files.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuArchitecture")]
        public virtual string CpuArchitecture { get; set; }

        /// <summary>
        /// Optional. Additional gpu information describing the requirements for the to be exported model files.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gpuArchitecture")]
        public virtual string GpuArchitecture { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A model format used for [Edge TPU](https://cloud.google.com/edge-tpu/) devices.</summary>
    public class XPSEdgeTpuTfLiteFormat : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains xPS-specific model evaluation metrics either for a single annotation spec (label), or for the model
    /// overall. Next tag: 18.
    /// </summary>
    public class XPSEvaluationMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The annotation_spec for which this evaluation metrics instance had been created. Empty iff this is an
        /// overall model evaluation (like Tables evaluation metrics), i.e. aggregated across all labels. The value
        /// comes from the input annotations in AnnotatedExample. For MVP product or for text sentiment models where
        /// annotation_spec_id_token is not available, set label instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationSpecIdToken")]
        public virtual string AnnotationSpecIdToken { get; set; }

        /// <summary>
        /// The integer category label for which this evaluation metric instance had been created. Valid categories are
        /// 0 or higher. Overall model evaluation should set this to negative values (rather than implicit zero). Only
        /// used for Image Segmentation (prefer to set annotation_spec_id_token instead). Note: uCAIP Image Segmentation
        /// should use annotation_spec_id_token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual System.Nullable<int> Category { get; set; }

        /// <summary>The number of examples used to create this evaluation metrics instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluatedExampleCount")]
        public virtual System.Nullable<int> EvaluatedExampleCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("imageClassificationEvalMetrics")]
        public virtual XPSClassificationEvaluationMetrics ImageClassificationEvalMetrics { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("imageObjectDetectionEvalMetrics")]
        public virtual XPSImageObjectDetectionEvaluationMetrics ImageObjectDetectionEvalMetrics { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("imageSegmentationEvalMetrics")]
        public virtual XPSImageSegmentationEvaluationMetrics ImageSegmentationEvalMetrics { get; set; }

        /// <summary>
        /// The label for which this evaluation metrics instance had been created. Empty iff this is an overall model
        /// evaluation (like Tables evaluation metrics), i.e. aggregated across all labels. The label maps to
        /// AnnotationSpec.display_name in Public API protos. Only used by MVP implementation and text sentiment FULL
        /// implementation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("regressionEvalMetrics")]
        public virtual XPSRegressionEvaluationMetrics RegressionEvalMetrics { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("tablesClassificationEvalMetrics")]
        public virtual XPSClassificationEvaluationMetrics TablesClassificationEvalMetrics { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("tablesEvalMetrics")]
        public virtual XPSTablesEvaluationMetrics TablesEvalMetrics { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("textClassificationEvalMetrics")]
        public virtual XPSClassificationEvaluationMetrics TextClassificationEvalMetrics { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("textExtractionEvalMetrics")]
        public virtual XPSTextExtractionEvaluationMetrics TextExtractionEvalMetrics { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("textSentimentEvalMetrics")]
        public virtual XPSTextSentimentEvaluationMetrics TextSentimentEvalMetrics { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("translationEvalMetrics")]
        public virtual XPSTranslationEvaluationMetrics TranslationEvalMetrics { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("videoActionRecognitionEvalMetrics")]
        public virtual XPSVideoActionRecognitionEvaluationMetrics VideoActionRecognitionEvalMetrics { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("videoClassificationEvalMetrics")]
        public virtual XPSClassificationEvaluationMetrics VideoClassificationEvalMetrics { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("videoObjectTrackingEvalMetrics")]
        public virtual XPSVideoObjectTrackingEvaluationMetrics VideoObjectTrackingEvalMetrics { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies location of model evaluation metrics.</summary>
    public class XPSEvaluationMetricsSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Inline EvaluationMetrics - should be relatively small. For passing large quantities of exhaustive metrics,
        /// use file_spec.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluationMetrics")]
        public virtual System.Collections.Generic.IList<XPSEvaluationMetrics> EvaluationMetrics { get; set; }

        /// <summary>
        /// File spec containing evaluation metrics of a model, must point to RecordIO file(s) of
        /// intelligence.cloud.automl.xps.EvaluationMetrics messages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileSpec")]
        public virtual XPSFileSpec FileSpec { get; set; }

        /// <summary>Number of the evaluation metrics (usually one per label plus overall).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numEvaluationMetrics")]
        public virtual System.Nullable<long> NumEvaluationMetrics { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Set of examples or input sources.</summary>
    public class XPSExampleSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>File spec of the examples or input sources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileSpec")]
        public virtual XPSFileSpec FileSpec { get; set; }

        /// <summary>Fingerprint of the example set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual System.Nullable<long> Fingerprint { get; set; }

        /// <summary>Number of examples.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numExamples")]
        public virtual System.Nullable<long> NumExamples { get; set; }

        /// <summary>Number of input sources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numInputSources")]
        public virtual System.Nullable<long> NumInputSources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class XPSExportModelOutputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("coreMlFormat")]
        public virtual XPSCoreMlFormat CoreMlFormat { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("dockerFormat")]
        public virtual XPSDockerFormat DockerFormat { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("edgeTpuTfLiteFormat")]
        public virtual XPSEdgeTpuTfLiteFormat EdgeTpuTfLiteFormat { get; set; }

        /// <summary>
        /// For any model and format: If true, will additionally export FirebaseExportedModelInfo in a firebase.txt
        /// file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exportFirebaseAuxiliaryInfo")]
        public virtual System.Nullable<bool> ExportFirebaseAuxiliaryInfo { get; set; }

        /// <summary>
        /// The Google Contained Registry path the exported files to be pushed to. This location is set if the exported
        /// format is DOCKDER.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputGcrUri")]
        public virtual string OutputGcrUri { get; set; }

        /// <summary>
        /// The Google Cloud Storage directory where XPS will output the exported models and related files. Format:
        /// gs://bucket/directory
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputGcsUri")]
        public virtual string OutputGcsUri { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("tfJsFormat")]
        public virtual XPSTfJsFormat TfJsFormat { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("tfLiteFormat")]
        public virtual XPSTfLiteFormat TfLiteFormat { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("tfSavedModelFormat")]
        public virtual XPSTfSavedModelFormat TfSavedModelFormat { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Spec of input and output files, on external file systems (for example, Colossus Namespace System or Google Cloud
    /// Storage).
    /// </summary>
    public class XPSFileSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Deprecated. Use file_spec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("directoryPath")]
        public virtual string DirectoryPath { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("fileFormat")]
        public virtual string FileFormat { get; set; }

        /// <summary>
        /// Single file path, or file pattern of format "/path/to/file@shard_count". E.g. /cns/cell-d/somewhere/file@2
        /// is expanded to two files: /cns/cell-d/somewhere/file-00000-of-00002 and
        /// /cns/cell-d/somewhere/file-00001-of-00002.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileSpec")]
        public virtual string FileSpec { get; set; }

        /// <summary>Deprecated. Use file_spec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("singleFilePath")]
        public virtual string SingleFilePath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The data statistics of a series of FLOAT64 values.</summary>
    public class XPSFloat64Stats : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("commonStats")]
        public virtual XPSCommonStats CommonStats { get; set; }

        /// <summary>
        /// Histogram buckets of the data series. Sorted by the min value of the bucket, ascendingly, and the number of
        /// the buckets is dynamically generated. The buckets are non-overlapping and completely cover whole FLOAT64
        /// range with min of first bucket being `"-Infinity"`, and max of the last one being `"Infinity"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("histogramBuckets")]
        public virtual System.Collections.Generic.IList<XPSFloat64StatsHistogramBucket> HistogramBuckets { get; set; }

        /// <summary>The mean of the series.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mean")]
        public virtual System.Nullable<double> Mean { get; set; }

        /// <summary>
        /// Ordered from 0 to k k-quantile values of the data series of n values. The value at index i is,
        /// approximately, the i*n/k-th smallest value in the series; for i = 0 and i = k these are, respectively, the
        /// min and max values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantiles")]
        public virtual System.Collections.Generic.IList<System.Nullable<double>> Quantiles { get; set; }

        /// <summary>The standard deviation of the series.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("standardDeviation")]
        public virtual System.Nullable<double> StandardDeviation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A bucket of a histogram.</summary>
    public class XPSFloat64StatsHistogramBucket : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of data values that are in the bucket, i.e. are between min and max values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>
        /// The maximum value of the bucket, exclusive unless max = `"Infinity"`, in which case it's inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("max")]
        public virtual System.Nullable<double> Max { get; set; }

        /// <summary>The minimum value of the bucket, inclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("min")]
        public virtual System.Nullable<double> Min { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class XPSImageClassificationTrainResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Total number of classes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classCount")]
        public virtual System.Nullable<long> ClassCount { get; set; }

        /// <summary>
        /// Information of downloadable models that are pre-generated as part of training flow and will be persisted in
        /// AutoMl backend. Populated for AutoMl requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exportModelSpec")]
        public virtual XPSImageExportModelSpec ExportModelSpec { get; set; }

        /// <summary>## The fields below are only populated under uCAIP request scope.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelArtifactSpec")]
        public virtual XPSImageModelArtifactSpec ModelArtifactSpec { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("modelServingSpec")]
        public virtual XPSImageModelServingSpec ModelServingSpec { get; set; }

        /// <summary>
        /// Stop reason for training job, e.g. 'TRAIN_BUDGET_REACHED', 'MODEL_CONVERGED', 'MODEL_EARLY_STOPPED'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stopReason")]
        public virtual string StopReason { get; set; }

        /// <summary>
        /// The actual cost to create this model. - For edge type model, the cost is expressed in node hour. - For cloud
        /// type model,the cost is expressed in compute hour. - Populated for models created before GA. To be deprecated
        /// after GA.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainCostInNodeTime")]
        public virtual object TrainCostInNodeTime { get; set; }

        /// <summary>
        /// The actual training cost, expressed in node seconds. Populated for models trained in node time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainCostNodeSeconds")]
        public virtual System.Nullable<long> TrainCostNodeSeconds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information of downloadable models that are pre-generated as part of training flow and will be persisted in
    /// AutoMl backend. Upon receiving ExportModel request from user, AutoMl backend can serve the pre-generated models
    /// to user if exists (by copying the files from internal path to user provided location), otherwise, AutoMl backend
    /// will call xPS ExportModel API to generate the model on the fly with the requesting format.
    /// </summary>
    public class XPSImageExportModelSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Contains the model format and internal location of the model files to be exported/downloaded. Use the Google
        /// Cloud Storage bucket name which is provided via TrainRequest.gcs_bucket_name to store the model files.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exportModelOutputConfig")]
        public virtual System.Collections.Generic.IList<XPSExportModelOutputConfig> ExportModelOutputConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Stores the locations and related metadata of the model artifacts. Populated for uCAIP requests only.
    /// </summary>
    public class XPSImageModelArtifactSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Tensorflow checkpoint files. e.g. Used for resumable training.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checkpointArtifact")]
        public virtual XPSModelArtifactItem CheckpointArtifact { get; set; }

        /// <summary>The model binary files in different formats for model export.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exportArtifact")]
        public virtual System.Collections.Generic.IList<XPSModelArtifactItem> ExportArtifact { get; set; }

        /// <summary>Google Cloud Storage URI of decoded labels file for model export 'dict.txt'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelGcsUri")]
        public virtual string LabelGcsUri { get; set; }

        /// <summary>
        /// The default model binary file used for serving (e.g. online predict, batch predict) via public Cloud AI
        /// Platform API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servingArtifact")]
        public virtual XPSModelArtifactItem ServingArtifact { get; set; }

        /// <summary>
        /// Google Cloud Storage URI prefix of Tensorflow JavaScript binary files 'groupX-shardXofX.bin'. Deprecated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tfJsBinaryGcsPrefix")]
        public virtual string TfJsBinaryGcsPrefix { get; set; }

        /// <summary>Google Cloud Storage URI of Tensorflow Lite metadata 'tflite_metadata.json'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tfLiteMetadataGcsUri")]
        public virtual string TfLiteMetadataGcsUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Serving specification for image models.</summary>
    public class XPSImageModelServingSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Populate under uCAIP request scope.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelThroughputEstimation")]
        public virtual System.Collections.Generic.IList<XPSImageModelServingSpecModelThroughputEstimation> ModelThroughputEstimation { get; set; }

        /// <summary>
        /// An estimated value of how much traffic a node can serve. Populated for AutoMl request only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeQps")]
        public virtual System.Nullable<double> NodeQps { get; set; }

        /// <summary>
        /// ## The fields below are only populated under uCAIP request scope.
        /// https://cloud.google.com/ml-engine/docs/runtime-version-list
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tfRuntimeVersion")]
        public virtual string TfRuntimeVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class XPSImageModelServingSpecModelThroughputEstimation : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("computeEngineAcceleratorType")]
        public virtual string ComputeEngineAcceleratorType { get; set; }

        /// <summary>Estimated latency.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latencyInMilliseconds")]
        public virtual System.Nullable<double> LatencyInMilliseconds { get; set; }

        /// <summary>The approximate qps a deployed node can serve.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeQps")]
        public virtual System.Nullable<double> NodeQps { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("servomaticPartitionType")]
        public virtual string ServomaticPartitionType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Model evaluation metrics for image object detection problems. Evaluates prediction quality of labeled bounding
    /// boxes.
    /// </summary>
    public class XPSImageObjectDetectionEvaluationMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The single metric for bounding boxes evaluation: the mean_average_precision averaged over all
        /// bounding_box_metrics_entries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingBoxMeanAveragePrecision")]
        public virtual System.Nullable<float> BoundingBoxMeanAveragePrecision { get; set; }

        /// <summary>
        /// The bounding boxes match metrics for each Intersection-over-union threshold
        /// 0.05,0.10,...,0.95,0.96,0.97,0.98,0.99 and each label confidence threshold
        /// 0.05,0.10,...,0.95,0.96,0.97,0.98,0.99 pair.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingBoxMetricsEntries")]
        public virtual System.Collections.Generic.IList<XPSBoundingBoxMetricsEntry> BoundingBoxMetricsEntries { get; set; }

        /// <summary>
        /// The total number of bounding boxes (i.e. summed over all images) the ground truth used to create this
        /// evaluation had.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluatedBoundingBoxCount")]
        public virtual System.Nullable<int> EvaluatedBoundingBoxCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class XPSImageObjectDetectionModelSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Total number of classes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classCount")]
        public virtual System.Nullable<long> ClassCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("exportModelSpec")]
        public virtual XPSImageExportModelSpec ExportModelSpec { get; set; }

        /// <summary>Max number of bounding box.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxBoundingBoxCount")]
        public virtual System.Nullable<long> MaxBoundingBoxCount { get; set; }

        /// <summary>## The fields below are only populated under uCAIP request scope.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelArtifactSpec")]
        public virtual XPSImageModelArtifactSpec ModelArtifactSpec { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("modelServingSpec")]
        public virtual XPSImageModelServingSpec ModelServingSpec { get; set; }

        /// <summary>Stop reason for training job, e.g. 'TRAIN_BUDGET_REACHED', 'MODEL_CONVERGED'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stopReason")]
        public virtual string StopReason { get; set; }

        /// <summary>
        /// The actual train cost of creating this model, expressed in node seconds, i.e. 3,600 value in this field
        /// means 1 node hour.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainCostNodeSeconds")]
        public virtual System.Nullable<long> TrainCostNodeSeconds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Model evaluation metrics for image segmentation problems. Next tag: 4.</summary>
    public class XPSImageSegmentationEvaluationMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Metrics that have confidence thresholds. Precision-recall curve can be derived from it.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidenceMetricsEntries")]
        public virtual System.Collections.Generic.IList<XPSImageSegmentationEvaluationMetricsConfidenceMetricsEntry> ConfidenceMetricsEntries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metrics for a single confidence threshold.</summary>
    public class XPSImageSegmentationEvaluationMetricsConfidenceMetricsEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The confidence threshold value used to compute the metrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidenceThreshold")]
        public virtual System.Nullable<float> ConfidenceThreshold { get; set; }

        /// <summary>
        /// Confusion matrix of the per confidence_threshold evaluation. Pixel counts are set here. Only set for model
        /// level evaluation, not for evaluation per label.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confusionMatrix")]
        public virtual XPSConfusionMatrix ConfusionMatrix { get; set; }

        /// <summary>DSC or the F1 score: The harmonic mean of recall and precision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diceScoreCoefficient")]
        public virtual System.Nullable<float> DiceScoreCoefficient { get; set; }

        /// <summary>IOU score.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iouScore")]
        public virtual System.Nullable<float> IouScore { get; set; }

        /// <summary>Precision for the given confidence threshold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("precision")]
        public virtual System.Nullable<float> Precision { get; set; }

        /// <summary>Recall for the given confidence threshold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recall")]
        public virtual System.Nullable<float> Recall { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class XPSImageSegmentationTrainResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Color map of the model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colorMaps")]
        public virtual System.Collections.Generic.IList<XPSColorMap> ColorMaps { get; set; }

        /// <summary>NOTE: These fields are not used/needed in EAP but will be set later.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exportModelSpec")]
        public virtual XPSImageExportModelSpec ExportModelSpec { get; set; }

        /// <summary>
        /// ## The fields below are only populated under uCAIP request scope. Model artifact spec stores and model gcs
        /// pathes and related metadata
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelArtifactSpec")]
        public virtual XPSImageModelArtifactSpec ModelArtifactSpec { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("modelServingSpec")]
        public virtual XPSImageModelServingSpec ModelServingSpec { get; set; }

        /// <summary>Stop reason for training job, e.g. 'TRAIN_BUDGET_REACHED', 'MODEL_CONVERGED'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stopReason")]
        public virtual string StopReason { get; set; }

        /// <summary>
        /// The actual train cost of creating this model, expressed in node seconds, i.e. 3,600 value in this field
        /// means 1 node hour.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainCostNodeSeconds")]
        public virtual System.Nullable<long> TrainCostNodeSeconds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An attribution method that computes the Aumann-Shapley value taking advantage of the model's fully
    /// differentiable structure. Refer to this paper for more details: https://arxiv.org/abs/1703.01365
    /// </summary>
    public class XPSIntegratedGradientsAttribution : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The number of steps for approximating the path integral. A good value to start is 50 and gradually increase
        /// until the sum to diff property is within the desired error range. Valid range of its value is [1, 100],
        /// inclusively.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stepCount")]
        public virtual System.Nullable<int> StepCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class XPSMetricEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// For billing metrics that are using legacy sku's, set the legacy billing metric id here. This will be sent to
        /// Chemist as the "cloudbilling.googleapis.com/argentum_metric_id" label. Otherwise leave empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("argentumMetricId")]
        public virtual string ArgentumMetricId { get; set; }

        /// <summary>A double value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doubleValue")]
        public virtual System.Nullable<double> DoubleValue { get; set; }

        /// <summary>A signed 64-bit integer value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("int64Value")]
        public virtual System.Nullable<long> Int64Value { get; set; }

        /// <summary>The metric name defined in the service configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricName")]
        public virtual string MetricName { get; set; }

        /// <summary>Billing system labels for this (metric, value) pair.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemLabels")]
        public virtual System.Collections.Generic.IList<XPSMetricEntryLabel> SystemLabels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class XPSMetricEntryLabel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelName")]
        public virtual string LabelName { get; set; }

        /// <summary>The value of the label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelValue")]
        public virtual string LabelValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single model artifact item.</summary>
    public class XPSModelArtifactItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The model artifact format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifactFormat")]
        public virtual string ArtifactFormat { get; set; }

        /// <summary>The Google Cloud Storage URI that stores the model binary files.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsUri")]
        public virtual string GcsUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class XPSPreprocessResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Preprocessed examples, that are to be imported into AutoML storage. This should point to RecordIO file(s) of
        /// PreprocessedExample messages. The PreprocessedExample.mvp_training_data-s returned here are later verbatim
        /// passed to Train() call in TrainExample.mvp_training_data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputExampleSet")]
        public virtual XPSExampleSet OutputExampleSet { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("speechPreprocessResp")]
        public virtual XPSSpeechPreprocessResponse SpeechPreprocessResp { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("tablesPreprocessResponse")]
        public virtual XPSTablesPreprocessResponse TablesPreprocessResponse { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("translationPreprocessResp")]
        public virtual XPSTranslationPreprocessResponse TranslationPreprocessResp { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Model evaluation metrics for regression problems. It can be used for Tables.</summary>
    public class XPSRegressionEvaluationMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Mean Absolute Error (MAE).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meanAbsoluteError")]
        public virtual System.Nullable<float> MeanAbsoluteError { get; set; }

        /// <summary>Mean absolute percentage error. Only set if all ground truth values are positive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meanAbsolutePercentageError")]
        public virtual System.Nullable<float> MeanAbsolutePercentageError { get; set; }

        /// <summary>R squared.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rSquared")]
        public virtual System.Nullable<float> RSquared { get; set; }

        /// <summary>A list of actual versus predicted points for the model being evaluated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regressionMetricsEntries")]
        public virtual System.Collections.Generic.IList<XPSRegressionMetricsEntry> RegressionMetricsEntries { get; set; }

        /// <summary>Root Mean Squared Error (RMSE).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rootMeanSquaredError")]
        public virtual System.Nullable<float> RootMeanSquaredError { get; set; }

        /// <summary>Root mean squared log error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rootMeanSquaredLogError")]
        public virtual System.Nullable<float> RootMeanSquaredLogError { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A pair of actual &amp; observed values for the model being evaluated.</summary>
    public class XPSRegressionMetricsEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The observed value for a row in the dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("predictedValue")]
        public virtual System.Nullable<float> PredictedValue { get; set; }

        /// <summary>The actual target value for a row in the dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trueValue")]
        public virtual System.Nullable<float> TrueValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class XPSReportingMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The effective time training used. If set, this is used for quota management and billing. Deprecated. AutoML
        /// BE doesn't use this. Don't set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectiveTrainingDuration")]
        public virtual object EffectiveTrainingDuration { get; set; }

        /// <summary>One entry per metric name. The values must be aggregated per metric name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricEntries")]
        public virtual System.Collections.Generic.IList<XPSMetricEntry> MetricEntries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class XPSResponseExplanationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Metadata of the input.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputs")]
        public virtual System.Collections.Generic.IDictionary<string, XPSResponseExplanationMetadataInputMetadata> Inputs { get; set; }

        /// <summary>Metadata of the output.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputs")]
        public virtual System.Collections.Generic.IDictionary<string, XPSResponseExplanationMetadataOutputMetadata> Outputs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata of the input of a feature.</summary>
    public class XPSResponseExplanationMetadataInputMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the input tensor for this model. Only needed in train response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputTensorName")]
        public virtual string InputTensorName { get; set; }

        /// <summary>Modality of the feature. Valid values are: numeric, image. Defaults to numeric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modality")]
        public virtual string Modality { get; set; }

        /// <summary>Visualization configurations for image explanation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visualizationConfig")]
        public virtual XPSVisualization VisualizationConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata of the prediction output to be explained.</summary>
    public class XPSResponseExplanationMetadataOutputMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the output tensor. Only needed in train response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputTensorName")]
        public virtual string OutputTensorName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class XPSResponseExplanationParameters : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An attribution method that computes Aumann-Shapley values taking advantage of the model's fully
        /// differentiable structure. Refer to this paper for more details: https://arxiv.org/abs/1703.01365
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integratedGradientsAttribution")]
        public virtual XPSIntegratedGradientsAttribution IntegratedGradientsAttribution { get; set; }

        /// <summary>
        /// An attribution method that redistributes Integrated Gradients attribution to segmented regions, taking
        /// advantage of the model's fully differentiable structure. Refer to this paper for more details:
        /// https://arxiv.org/abs/1906.02825 XRAI currently performs better on natural images, like a picture of a house
        /// or an animal. If the images are taken in artificial environments, like a lab or manufacturing line, or from
        /// diagnostic equipment, like x-rays or quality-control cameras, use Integrated Gradients instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("xraiAttribution")]
        public virtual XPSXraiAttribution XraiAttribution { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specification of Model explanation. Feature-based XAI in AutoML Vision ICN is deprecated.</summary>
    public class XPSResponseExplanationSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Explanation type. For AutoML Image Classification models, possible values are: *
        /// `image-integrated-gradients` * `image-xrai`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("explanationType")]
        public virtual string ExplanationType { get; set; }

        /// <summary>Metadata describing the Model's input and output for explanation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual XPSResponseExplanationMetadata Metadata { get; set; }

        /// <summary>Parameters that configure explaining of the Model's predictions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual XPSResponseExplanationParameters Parameters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class XPSRow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The ids of the columns. Note: The below `values` field must match order of this field, if this field is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> ColumnIds { get; set; }

        /// <summary>
        /// The values of the row cells, given in the same order as the column_ids. If column_ids is not set, then in
        /// the same order as the input_feature_column_ids in TablesModelMetadata.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<object> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class XPSSpeechEvaluationMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Evaluation metrics for all submodels contained in this model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subModelEvaluationMetrics")]
        public virtual System.Collections.Generic.IList<XPSSpeechEvaluationMetricsSubModelEvaluationMetric> SubModelEvaluationMetrics { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class XPSSpeechEvaluationMetricsSubModelEvaluationMetric : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Type of the biasing model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("biasingModelType")]
        public virtual string BiasingModelType { get; set; }

        /// <summary>If true then it means we have an enhanced version of the biasing models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isEnhancedModel")]
        public virtual System.Nullable<bool> IsEnhancedModel { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("numDeletions")]
        public virtual System.Nullable<int> NumDeletions { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("numInsertions")]
        public virtual System.Nullable<int> NumInsertions { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("numSubstitutions")]
        public virtual System.Nullable<int> NumSubstitutions { get; set; }

        /// <summary>Number of utterances used in the wer computation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numUtterances")]
        public virtual System.Nullable<int> NumUtterances { get; set; }

        /// <summary>Number of words over which the word error rate was computed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numWords")]
        public virtual System.Nullable<int> NumWords { get; set; }

        /// <summary>Below fields are used for debugging purposes</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sentenceAccuracy")]
        public virtual System.Nullable<double> SentenceAccuracy { get; set; }

        /// <summary>Word error rate (standard error metric used for speech recognition).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wer")]
        public virtual System.Nullable<double> Wer { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class XPSSpeechModelSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required for speech xps backend. Speech xps has to use dataset_id and model_id as the primary key in db so
        /// that speech API can query the db directly.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetId")]
        public virtual System.Nullable<long> DatasetId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("language")]
        public virtual string Language { get; set; }

        /// <summary>Model specs for all submodels contained in this model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subModelSpecs")]
        public virtual System.Collections.Generic.IList<XPSSpeechModelSpecSubModelSpec> SubModelSpecs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class XPSSpeechModelSpecSubModelSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Type of the biasing model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("biasingModelType")]
        public virtual string BiasingModelType { get; set; }

        /// <summary>In S3, Recognition ClientContextId.client_id</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>In S3, Recognition ClientContextId.context_id</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contextId")]
        public virtual string ContextId { get; set; }

        /// <summary>If true then it means we have an enhanced version of the biasing models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isEnhancedModel")]
        public virtual System.Nullable<bool> IsEnhancedModel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class XPSSpeechPreprocessResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Location od shards of sstables (test data) of DataUtterance protos.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cnsTestDataPath")]
        public virtual string CnsTestDataPath { get; set; }

        /// <summary>Location of shards of sstables (training data) of DataUtterance protos.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cnsTrainDataPath")]
        public virtual string CnsTrainDataPath { get; set; }

        /// <summary>
        /// The metrics for prebuilt speech models. They are included here because there is no prebuilt speech models
        /// stored in the AutoML.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prebuiltModelEvaluationMetrics")]
        public virtual XPSSpeechEvaluationMetrics PrebuiltModelEvaluationMetrics { get; set; }

        /// <summary>Stats associated with the data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("speechPreprocessStats")]
        public virtual XPSSpeechPreprocessStats SpeechPreprocessStats { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class XPSSpeechPreprocessStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Different types of data errors and the counts associated with them.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataErrors")]
        public virtual System.Collections.Generic.IList<XPSDataErrors> DataErrors { get; set; }

        /// <summary>The number of rows marked HUMAN_LABELLED</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numHumanLabeledExamples")]
        public virtual System.Nullable<int> NumHumanLabeledExamples { get; set; }

        /// <summary>The number of samples found in the previously recorded logs data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numLogsExamples")]
        public virtual System.Nullable<int> NumLogsExamples { get; set; }

        /// <summary>The number of rows marked as MACHINE_TRANSCRIBED</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numMachineTranscribedExamples")]
        public virtual System.Nullable<int> NumMachineTranscribedExamples { get; set; }

        /// <summary>The number of examples labelled as TEST by Speech xps server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testExamplesCount")]
        public virtual System.Nullable<int> TestExamplesCount { get; set; }

        /// <summary>The number of sentences in the test data set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testSentencesCount")]
        public virtual System.Nullable<int> TestSentencesCount { get; set; }

        /// <summary>The number of words in the test data set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testWordsCount")]
        public virtual System.Nullable<int> TestWordsCount { get; set; }

        /// <summary>The number of examples labeled as TRAIN by Speech xps server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainExamplesCount")]
        public virtual System.Nullable<int> TrainExamplesCount { get; set; }

        /// <summary>The number of sentences in the training data set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainSentencesCount")]
        public virtual System.Nullable<int> TrainSentencesCount { get; set; }

        /// <summary>The number of words in the training data set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainWordsCount")]
        public virtual System.Nullable<int> TrainWordsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The data statistics of a series of STRING values.</summary>
    public class XPSStringStats : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("commonStats")]
        public virtual XPSCommonStats CommonStats { get; set; }

        /// <summary>The statistics of the top 20 unigrams, ordered by StringStats.UnigramStats.count.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topUnigramStats")]
        public virtual System.Collections.Generic.IList<XPSStringStatsUnigramStats> TopUnigramStats { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The statistics of a unigram.</summary>
    public class XPSStringStatsUnigramStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of occurrences of this unigram in the series.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>The unigram.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The data statistics of a series of STRUCT values.</summary>
    public class XPSStructStats : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("commonStats")]
        public virtual XPSCommonStats CommonStats { get; set; }

        /// <summary>
        /// Map from a field name of the struct to data stats aggregated over series of all data in that field across
        /// all the structs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldStats")]
        public virtual System.Collections.Generic.IDictionary<string, XPSDataStats> FieldStats { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`StructType` defines the DataType-s of a STRUCT type.</summary>
    public class XPSStructType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Unordered map of struct field names to their data types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IDictionary<string, XPSDataType> Fields { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class XPSTableSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Mapping from column id to column spec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnSpecs")]
        public virtual System.Collections.Generic.IDictionary<string, XPSColumnSpec> ColumnSpecs { get; set; }

        /// <summary>The total size of imported data of the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importedDataSizeInBytes")]
        public virtual System.Nullable<long> ImportedDataSizeInBytes { get; set; }

        /// <summary>The number of rows in the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowCount")]
        public virtual System.Nullable<long> RowCount { get; set; }

        /// <summary>The id of the time column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeColumnId")]
        public virtual System.Nullable<int> TimeColumnId { get; set; }

        /// <summary>The number of valid rows.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validRowCount")]
        public virtual System.Nullable<long> ValidRowCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metrics for Tables classification problems.</summary>
    public class XPSTablesClassificationMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Metrics building a curve.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("curveMetrics")]
        public virtual System.Collections.Generic.IList<XPSTablesClassificationMetricsCurveMetrics> CurveMetrics { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metrics curve data point for a single value.</summary>
    public class XPSTablesClassificationMetricsCurveMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The area under the precision-recall curve.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aucPr")]
        public virtual System.Nullable<double> AucPr { get; set; }

        /// <summary>The area under receiver operating characteristic curve.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aucRoc")]
        public virtual System.Nullable<double> AucRoc { get; set; }

        /// <summary>
        /// Metrics that have confidence thresholds. Precision-recall curve and ROC curve can be derived from them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidenceMetricsEntries")]
        public virtual System.Collections.Generic.IList<XPSTablesConfidenceMetricsEntry> ConfidenceMetricsEntries { get; set; }

        /// <summary>The Log loss metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logLoss")]
        public virtual System.Nullable<double> LogLoss { get; set; }

        /// <summary>The position threshold value used to compute the metrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("positionThreshold")]
        public virtual System.Nullable<int> PositionThreshold { get; set; }

        /// <summary>The CATEGORY row value (for ARRAY unnested) the curve metrics are for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metrics for a single confidence threshold.</summary>
    public class XPSTablesConfidenceMetricsEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The confidence threshold value used to compute the metrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidenceThreshold")]
        public virtual System.Nullable<double> ConfidenceThreshold { get; set; }

        /// <summary>
        /// The harmonic mean of recall and precision. (2 * precision * recall) / (precision + recall)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("f1Score")]
        public virtual System.Nullable<double> F1Score { get; set; }

        /// <summary>False negative count.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("falseNegativeCount")]
        public virtual System.Nullable<long> FalseNegativeCount { get; set; }

        /// <summary>False positive count.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("falsePositiveCount")]
        public virtual System.Nullable<long> FalsePositiveCount { get; set; }

        /// <summary>FPR = #false positives / (#false positives + #true negatives)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("falsePositiveRate")]
        public virtual System.Nullable<double> FalsePositiveRate { get; set; }

        /// <summary>Precision = #true positives / (#true positives + #false positives).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("precision")]
        public virtual System.Nullable<double> Precision { get; set; }

        /// <summary>Recall = #true positives / (#true positives + #false negatives).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recall")]
        public virtual System.Nullable<double> Recall { get; set; }

        /// <summary>True negative count.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trueNegativeCount")]
        public virtual System.Nullable<long> TrueNegativeCount { get; set; }

        /// <summary>True positive count.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("truePositiveCount")]
        public virtual System.Nullable<long> TruePositiveCount { get; set; }

        /// <summary>TPR = #true positives / (#true positives + #false negatvies)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("truePositiveRate")]
        public virtual System.Nullable<double> TruePositiveRate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for a dataset used for AutoML Tables.</summary>
    public class XPSTablesDatasetMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Id the column to split the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mlUseColumnId")]
        public virtual System.Nullable<int> MlUseColumnId { get; set; }

        /// <summary>Primary table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryTableSpec")]
        public virtual XPSTableSpec PrimaryTableSpec { get; set; }

        /// <summary>(the column id : its CorrelationStats with target column).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetColumnCorrelations")]
        public virtual System.Collections.Generic.IDictionary<string, XPSCorrelationStats> TargetColumnCorrelations { get; set; }

        /// <summary>Id of the primary table column that should be used as the training label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetColumnId")]
        public virtual System.Nullable<int> TargetColumnId { get; set; }

        /// <summary>Id of the primary table column that should be used as the weight column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weightColumnId")]
        public virtual System.Nullable<int> WeightColumnId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class XPSTablesEvaluationMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Classification metrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classificationMetrics")]
        public virtual XPSTablesClassificationMetrics ClassificationMetrics { get; set; }

        /// <summary>Regression metrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regressionMetrics")]
        public virtual XPSTablesRegressionMetrics RegressionMetrics { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An information specific to given column and Tables Model, in context of the Model and the predictions created by
    /// it.
    /// </summary>
    public class XPSTablesModelColumnInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnId")]
        public virtual System.Nullable<int> ColumnId { get; set; }

        /// <summary>
        /// When given as part of a Model: Measurement of how much model predictions correctness on the TEST data depend
        /// on values in this column. A value between 0 and 1, higher means higher influence. These values are
        /// normalized - for all input feature columns of a given model they add to 1. When given back by Predict or
        /// Batch Predict: Measurement of how impactful for the prediction returned for the given row the value in this
        /// column was. Specifically, the feature importance specifies the marginal contribution that the feature made
        /// to the prediction score compared to the baseline score. These values are computed using the Sampled Shapley
        /// method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("featureImportance")]
        public virtual System.Nullable<float> FeatureImportance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A description of Tables model structure.</summary>
    public class XPSTablesModelStructure : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelParameters")]
        public virtual System.Collections.Generic.IList<XPSTablesModelStructureModelParameters> ModelParameters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Model hyper-parameters for a model.</summary>
    public class XPSTablesModelStructureModelParameters : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("hyperparameters")]
        public virtual System.Collections.Generic.IList<XPSTablesModelStructureModelParametersParameter> Hyperparameters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class XPSTablesModelStructureModelParametersParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Float type parameter value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floatValue")]
        public virtual System.Nullable<double> FloatValue { get; set; }

        /// <summary>Integer type parameter value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intValue")]
        public virtual System.Nullable<long> IntValue { get; set; }

        /// <summary>Parameter name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>String type parameter value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class XPSTablesPreprocessResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The table/column id, column_name and the DataTypes of the columns will be populated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tablesDatasetMetadata")]
        public virtual XPSTablesDatasetMetadata TablesDatasetMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metrics for Tables regression problems.</summary>
    public class XPSTablesRegressionMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Mean absolute error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meanAbsoluteError")]
        public virtual System.Nullable<double> MeanAbsoluteError { get; set; }

        /// <summary>
        /// Mean absolute percentage error, only set if all of the target column's values are positive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meanAbsolutePercentageError")]
        public virtual System.Nullable<double> MeanAbsolutePercentageError { get; set; }

        /// <summary>R squared.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rSquared")]
        public virtual System.Nullable<double> RSquared { get; set; }

        /// <summary>A list of actual versus predicted points for the model being evaluated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regressionMetricsEntries")]
        public virtual System.Collections.Generic.IList<XPSRegressionMetricsEntry> RegressionMetricsEntries { get; set; }

        /// <summary>Root mean squared error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rootMeanSquaredError")]
        public virtual System.Nullable<double> RootMeanSquaredError { get; set; }

        /// <summary>Root mean squared log error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rootMeanSquaredLogError")]
        public virtual System.Nullable<double> RootMeanSquaredLogError { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class XPSTablesTrainResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("modelStructure")]
        public virtual XPSTablesModelStructure ModelStructure { get; set; }

        /// <summary>Sample rows from the dataset this model was trained.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("predictionSampleRows")]
        public virtual System.Collections.Generic.IList<XPSRow> PredictionSampleRows { get; set; }

        /// <summary>
        /// Output only. Auxiliary information for each of the input_feature_column_specs, with respect to this
        /// particular model.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tablesModelColumnInfo")]
        public virtual System.Collections.Generic.IList<XPSTablesModelColumnInfo> TablesModelColumnInfo { get; set; }

        /// <summary>
        /// The actual training cost of the model, expressed in milli node hours, i.e. 1,000 value in this field means 1
        /// node hour. Guaranteed to not exceed the train budget.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainCostMilliNodeHours")]
        public virtual System.Nullable<long> TrainCostMilliNodeHours { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class XPSTablesTrainingOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Current stage of creating model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createModelStage")]
        public virtual string CreateModelStage { get; set; }

        /// <summary>The optimization objective for model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optimizationObjective")]
        public virtual string OptimizationObjective { get; set; }

        /// <summary>
        /// This field is for training. When the operation is terminated successfully, AutoML Backend post this field to
        /// operation metadata in spanner. If the metadata has no trials returned, the training operation is supposed to
        /// be a failure.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topTrials")]
        public virtual System.Collections.Generic.IList<XPSTuningTrial> TopTrials { get; set; }

        /// <summary>Creating model budget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainBudgetMilliNodeHours")]
        public virtual System.Nullable<long> TrainBudgetMilliNodeHours { get; set; }

        /// <summary>
        /// This field records the training objective value with respect to time, giving insight into how the model
        /// architecture search is performing as training time elapses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingObjectivePoints")]
        public virtual System.Collections.Generic.IList<XPSTrainingObjectivePoint> TrainingObjectivePoints { get; set; }

        private string _trainingStartTimeRaw;

        private object _trainingStartTime;

        /// <summary>Timestamp when training process starts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingStartTime")]
        public virtual string TrainingStartTimeRaw
        {
            get => _trainingStartTimeRaw;
            set
            {
                _trainingStartTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _trainingStartTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="TrainingStartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use TrainingStartTimeDateTimeOffset instead.")]
        public virtual object TrainingStartTime
        {
            get => _trainingStartTime;
            set
            {
                _trainingStartTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _trainingStartTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="TrainingStartTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? TrainingStartTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(TrainingStartTimeRaw);
            set => TrainingStartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Component model.</summary>
    public class XPSTextComponentModel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Cloud Storage resource path to hold batch prediction model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batchPredictionModelGcsUri")]
        public virtual string BatchPredictionModelGcsUri { get; set; }

        /// <summary>The Cloud Storage resource path to hold online prediction model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onlinePredictionModelGcsUri")]
        public virtual string OnlinePredictionModelGcsUri { get; set; }

        /// <summary>
        /// The partition where the model is deployed. Populated by uCAIP BE as part of online PredictRequest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partition")]
        public virtual string Partition { get; set; }

        /// <summary>
        /// The default model binary file used for serving (e.g. online predict, batch predict) via public Cloud Ai
        /// Platform API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servingArtifact")]
        public virtual XPSModelArtifactItem ServingArtifact { get; set; }

        /// <summary>The name of servo model. Populated by uCAIP BE as part of online PredictRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servoModelName")]
        public virtual string ServoModelName { get; set; }

        /// <summary>The name of the trained NL submodel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("submodelName")]
        public virtual string SubmodelName { get; set; }

        /// <summary>The type of trained NL submodel</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("submodelType")]
        public virtual string SubmodelType { get; set; }

        /// <summary>
        /// ## The fields below are only populated under uCAIP request scope.
        /// https://cloud.google.com/ml-engine/docs/runtime-version-list
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tfRuntimeVersion")]
        public virtual string TfRuntimeVersion { get; set; }

        /// <summary>
        /// The servomatic model version number. Populated by uCAIP BE as part of online PredictRequest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionNumber")]
        public virtual System.Nullable<long> VersionNumber { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class XPSTextExtractionEvaluationMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Values are at the highest F1 score on the precision-recall curve. Only confidence_threshold, recall,
        /// precision, and f1_score will be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bestF1ConfidenceMetrics")]
        public virtual XPSConfidenceMetricsEntry BestF1ConfidenceMetrics { get; set; }

        /// <summary>
        /// If the enclosing EvaluationMetrics.label is empty, confidence_metrics_entries is an evaluation of the entire
        /// model across all labels. If the enclosing EvaluationMetrics.label is set, confidence_metrics_entries applies
        /// to that label.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidenceMetricsEntries")]
        public virtual System.Collections.Generic.IList<XPSConfidenceMetricsEntry> ConfidenceMetricsEntries { get; set; }

        /// <summary>
        /// Confusion matrix of the model, at the default confidence threshold (0.0). Only set for whole-model
        /// evaluation, not for evaluation per label.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confusionMatrix")]
        public virtual XPSConfusionMatrix ConfusionMatrix { get; set; }

        /// <summary>Only recall, precision, and f1_score will be set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("perLabelConfidenceMetrics")]
        public virtual System.Collections.Generic.IDictionary<string, XPSConfidenceMetricsEntry> PerLabelConfidenceMetrics { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Model evaluation metrics for text sentiment problems.</summary>
    public class XPSTextSentimentEvaluationMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Confusion matrix of the evaluation. Only set for the overall model evaluation, not for
        /// evaluation of a single annotation spec.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confusionMatrix")]
        public virtual XPSConfusionMatrix ConfusionMatrix { get; set; }

        /// <summary>Output only. The harmonic mean of recall and precision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("f1Score")]
        public virtual System.Nullable<float> F1Score { get; set; }

        /// <summary>
        /// Output only. Linear weighted kappa. Only set for the overall model evaluation, not for evaluation of a
        /// single annotation spec.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linearKappa")]
        public virtual System.Nullable<float> LinearKappa { get; set; }

        /// <summary>
        /// Output only. Mean absolute error. Only set for the overall model evaluation, not for evaluation of a single
        /// annotation spec.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meanAbsoluteError")]
        public virtual System.Nullable<float> MeanAbsoluteError { get; set; }

        /// <summary>
        /// Output only. Mean squared error. Only set for the overall model evaluation, not for evaluation of a single
        /// annotation spec.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meanSquaredError")]
        public virtual System.Nullable<float> MeanSquaredError { get; set; }

        /// <summary>Output only. Precision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("precision")]
        public virtual System.Nullable<float> Precision { get; set; }

        /// <summary>
        /// Output only. Quadratic weighted kappa. Only set for the overall model evaluation, not for evaluation of a
        /// single annotation spec.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quadraticKappa")]
        public virtual System.Nullable<float> QuadraticKappa { get; set; }

        /// <summary>Output only. Recall.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recall")]
        public virtual System.Nullable<float> Recall { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>TextToSpeech train response</summary>
    public class XPSTextToSpeechTrainResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class XPSTextTrainResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Component submodels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("componentModel")]
        public virtual System.Collections.Generic.IList<XPSTextComponentModel> ComponentModel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A [TensorFlow.js](https://www.tensorflow.org/js) model that can be used in the browser and in Node.js using
    /// JavaScript.
    /// </summary>
    public class XPSTfJsFormat : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// LINT.IfChange A model format used for mobile and IoT devices. See https://www.tensorflow.org/lite.
    /// </summary>
    public class XPSTfLiteFormat : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A tensorflow model format in SavedModel format.</summary>
    public class XPSTfSavedModelFormat : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The data statistics of a series of TIMESTAMP values.</summary>
    public class XPSTimestampStats : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("commonStats")]
        public virtual XPSCommonStats CommonStats { get; set; }

        /// <summary>
        /// The string key is the pre-defined granularity. Currently supported: hour_of_day, day_of_week, month_of_year.
        /// Granularities finer that the granularity of timestamp data are not populated (e.g. if timestamps are at day
        /// granularity, then hour_of_day is not populated).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("granularStats")]
        public virtual System.Collections.Generic.IDictionary<string, XPSTimestampStatsGranularStats> GranularStats { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("medianTimestampNanos")]
        public virtual System.Nullable<long> MedianTimestampNanos { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Stats split by a defined in context granularity.</summary>
    public class XPSTimestampStatsGranularStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A map from granularity key to example count for that key. E.g. for hour_of_day `13` means 1pm, or for
        /// month_of_year `5` means May).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buckets")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<long>> Buckets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Track matching model metrics for a single track match threshold and multiple label match confidence thresholds.
    /// Next tag: 6.
    /// </summary>
    public class XPSTrackMetricsEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Metrics for each label-match confidence_threshold from 0.05,0.10,...,0.95,0.96,0.97,0.98,0.99.
        /// Precision-recall curve is derived from them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidenceMetricsEntries")]
        public virtual System.Collections.Generic.IList<XPSTrackMetricsEntryConfidenceMetricsEntry> ConfidenceMetricsEntries { get; set; }

        /// <summary>
        /// Output only. The intersection-over-union threshold value between bounding boxes across frames used to
        /// compute this metric entry.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iouThreshold")]
        public virtual System.Nullable<float> IouThreshold { get; set; }

        /// <summary>Output only. The mean bounding box iou over all confidence thresholds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meanBoundingBoxIou")]
        public virtual System.Nullable<float> MeanBoundingBoxIou { get; set; }

        /// <summary>Output only. The mean mismatch rate over all confidence thresholds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meanMismatchRate")]
        public virtual System.Nullable<float> MeanMismatchRate { get; set; }

        /// <summary>Output only. The mean average precision over all confidence thresholds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meanTrackingAveragePrecision")]
        public virtual System.Nullable<float> MeanTrackingAveragePrecision { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metrics for a single confidence threshold. Next tag: 6.</summary>
    public class XPSTrackMetricsEntryConfidenceMetricsEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Bounding box intersection-over-union precision. Measures how well the bounding boxes overlap
        /// between each other (e.g. complete overlap or just barely above iou_threshold).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingBoxIou")]
        public virtual System.Nullable<float> BoundingBoxIou { get; set; }

        /// <summary>Output only. The confidence threshold value used to compute the metrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidenceThreshold")]
        public virtual System.Nullable<float> ConfidenceThreshold { get; set; }

        /// <summary>
        /// Output only. Mismatch rate, which measures the tracking consistency, i.e. correctness of instance ID
        /// continuity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mismatchRate")]
        public virtual System.Nullable<float> MismatchRate { get; set; }

        /// <summary>Output only. Tracking precision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackingPrecision")]
        public virtual System.Nullable<float> TrackingPrecision { get; set; }

        /// <summary>Output only. Tracking recall.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackingRecall")]
        public virtual System.Nullable<float> TrackingRecall { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class XPSTrainResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Estimated model size in bytes once deployed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployedModelSizeBytes")]
        public virtual System.Nullable<long> DeployedModelSizeBytes { get; set; }

        /// <summary>
        /// Optional vision model error analysis configuration. The field is set when model error analysis is enabled in
        /// the training request. The results of error analysis will be binded together with evaluation results (in the
        /// format of AnnotatedExample).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorAnalysisConfigs")]
        public virtual System.Collections.Generic.IList<XPSVisionErrorAnalysisConfig> ErrorAnalysisConfigs { get; set; }

        /// <summary>
        /// Examples used to evaluate the model (usually the test set), with the predicted annotations. The file_spec
        /// should point to recordio file(s) of AnnotatedExample. For each returned example, the example_id_token and
        /// annotations predicted by the model must be set. The example payload can and is recommended to be omitted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluatedExampleSet")]
        public virtual XPSExampleSet EvaluatedExampleSet { get; set; }

        /// <summary>The trained model evaluation metrics. This can be optionally returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluationMetricsSet")]
        public virtual XPSEvaluationMetricsSet EvaluationMetricsSet { get; set; }

        /// <summary>
        /// VisionExplanationConfig for XAI on test set. Optional for when XAI is enable in training request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("explanationConfigs")]
        public virtual System.Collections.Generic.IList<XPSResponseExplanationSpec> ExplanationConfigs { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("imageClassificationTrainResp")]
        public virtual XPSImageClassificationTrainResponse ImageClassificationTrainResp { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("imageObjectDetectionTrainResp")]
        public virtual XPSImageObjectDetectionModelSpec ImageObjectDetectionTrainResp { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("imageSegmentationTrainResp")]
        public virtual XPSImageSegmentationTrainResponse ImageSegmentationTrainResp { get; set; }

        /// <summary>
        /// Token that represents the trained model. This is considered immutable and is persisted in AutoML. xPS can
        /// put their own proto in the byte string, to e.g. point to the model checkpoints. The token is passed to other
        /// xPS APIs to refer to the model.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelToken")]
        public virtual string ModelToken { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("speechTrainResp")]
        public virtual XPSSpeechModelSpec SpeechTrainResp { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("tablesTrainResp")]
        public virtual XPSTablesTrainResponse TablesTrainResp { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("textToSpeechTrainResp")]
        public virtual XPSTextToSpeechTrainResponse TextToSpeechTrainResp { get; set; }

        /// <summary>Will only be needed for uCAIP from Beta.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textTrainResp")]
        public virtual XPSTextTrainResponse TextTrainResp { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("translationTrainResp")]
        public virtual XPSTranslationTrainResponse TranslationTrainResp { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("videoActionRecognitionTrainResp")]
        public virtual XPSVideoActionRecognitionTrainResponse VideoActionRecognitionTrainResp { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("videoClassificationTrainResp")]
        public virtual XPSVideoClassificationTrainResponse VideoClassificationTrainResp { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("videoObjectTrackingTrainResp")]
        public virtual XPSVideoObjectTrackingTrainResponse VideoObjectTrackingTrainResp { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class XPSTrainingObjectivePoint : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>The time at which this point was recorded.</summary>
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

        /// <summary>The objective value when this point was recorded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<float> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Evaluation metrics for the dataset.</summary>
    public class XPSTranslationEvaluationMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>BLEU score for base model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseBleuScore")]
        public virtual System.Nullable<double> BaseBleuScore { get; set; }

        /// <summary>BLEU score.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bleuScore")]
        public virtual System.Nullable<double> BleuScore { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Translation preprocess response.</summary>
    public class XPSTranslationPreprocessResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Total example count parsed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parsedExampleCount")]
        public virtual System.Nullable<long> ParsedExampleCount { get; set; }

        /// <summary>Total valid example count.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validExampleCount")]
        public virtual System.Nullable<long> ValidExampleCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Train response for translation.</summary>
    public class XPSTranslationTrainResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Type of the model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelType")]
        public virtual string ModelType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metrics for a tuning job generated, will get forwarded to Stackdriver as model tuning logs. Setting this as a
    /// standalone message out of CreateModelMetadata to avoid confusion as we expose this message only to users.
    /// </summary>
    public class XPSTuningTrial : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Model parameters for the trial.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelStructure")]
        public virtual XPSTablesModelStructure ModelStructure { get; set; }

        /// <summary>The optimization objective evaluation of the eval split data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingObjectivePoint")]
        public virtual XPSTrainingObjectivePoint TrainingObjectivePoint { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Evaluation metrics entry given a specific precision_window_length.</summary>
    public class XPSVideoActionMetricsEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Metrics for each label-match confidence_threshold from 0.05,0.10,...,0.95,0.96,0.97,0.98,0.99.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidenceMetricsEntries")]
        public virtual System.Collections.Generic.IList<XPSVideoActionMetricsEntryConfidenceMetricsEntry> ConfidenceMetricsEntries { get; set; }

        /// <summary>The mean average precision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meanAveragePrecision")]
        public virtual System.Nullable<float> MeanAveragePrecision { get; set; }

        /// <summary>
        /// This VideoActionMetricsEntry is calculated based on this prediction window length. If the predicted action's
        /// timestamp is inside the time window whose center is the ground truth action's timestamp with this specific
        /// length, the prediction result is treated as a true positive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("precisionWindowLength")]
        public virtual object PrecisionWindowLength { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metrics for a single confidence threshold.</summary>
    public class XPSVideoActionMetricsEntryConfidenceMetricsEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The confidence threshold value used to compute the metrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidenceThreshold")]
        public virtual System.Nullable<float> ConfidenceThreshold { get; set; }

        /// <summary>Output only. The harmonic mean of recall and precision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("f1Score")]
        public virtual System.Nullable<float> F1Score { get; set; }

        /// <summary>Output only. Precision for the given confidence threshold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("precision")]
        public virtual System.Nullable<float> Precision { get; set; }

        /// <summary>Output only. Recall for the given confidence threshold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recall")]
        public virtual System.Nullable<float> Recall { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Model evaluation metrics for video action recognition.</summary>
    public class XPSVideoActionRecognitionEvaluationMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The number of ground truth actions used to create this evaluation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluatedActionCount")]
        public virtual System.Nullable<int> EvaluatedActionCount { get; set; }

        /// <summary>Output only. The metric entries for precision window lengths: 1s,2s,3s,4s, 5s.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoActionMetricsEntries")]
        public virtual System.Collections.Generic.IList<XPSVideoActionMetricsEntry> VideoActionMetricsEntries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class XPSVideoActionRecognitionTrainResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>## The fields below are only populated under uCAIP request scope.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelArtifactSpec")]
        public virtual XPSVideoModelArtifactSpec ModelArtifactSpec { get; set; }

        /// <summary>
        /// The actual train cost of creating this model, expressed in node seconds, i.e. 3,600 value in this field
        /// means 1 node hour.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainCostNodeSeconds")]
        public virtual System.Nullable<long> TrainCostNodeSeconds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class XPSVideoBatchPredictOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// All the partial batch prediction results that are completed at the moment. Output examples are sorted by
        /// completion time. The order will not be changed. Each output example should be the path of a single RecordIO
        /// file of AnnotatedExamples.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputExamples")]
        public virtual System.Collections.Generic.IList<string> OutputExamples { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class XPSVideoClassificationTrainResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>## The fields below are only populated under uCAIP request scope.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelArtifactSpec")]
        public virtual XPSVideoModelArtifactSpec ModelArtifactSpec { get; set; }

        /// <summary>
        /// The actual train cost of creating this model, expressed in node seconds, i.e. 3,600 value in this field
        /// means 1 node hour.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainCostNodeSeconds")]
        public virtual System.Nullable<long> TrainCostNodeSeconds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information of downloadable models that are pre-generated as part of training flow and will be persisted in
    /// AutoMl backend. Upon receiving ExportModel request from user, AutoMl backend can serve the pre-generated models
    /// to user if exists (by copying the files from internal path to user provided location), otherwise, AutoMl backend
    /// will call xPS ExportModel API to generate the model on the fly with the requesting format.
    /// </summary>
    public class XPSVideoExportModelSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Contains the model format and internal location of the model files to be exported/downloaded. Use the Google
        /// Cloud Storage bucket name which is provided via TrainRequest.gcs_bucket_name to store the model files.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exportModelOutputConfig")]
        public virtual System.Collections.Generic.IList<XPSExportModelOutputConfig> ExportModelOutputConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class XPSVideoModelArtifactSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The model binary files in different formats for model export.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exportArtifact")]
        public virtual System.Collections.Generic.IList<XPSModelArtifactItem> ExportArtifact { get; set; }

        /// <summary>
        /// The default model binary file used for serving (e.g. batch predict) via public Cloud AI Platform API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servingArtifact")]
        public virtual XPSModelArtifactItem ServingArtifact { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Model evaluation metrics for ObjectTracking problems. Next tag: 10.</summary>
    public class XPSVideoObjectTrackingEvaluationMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The single metric for bounding boxes evaluation: the mean_average_precision averaged over all
        /// bounding_box_metrics_entries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingBoxMeanAveragePrecision")]
        public virtual System.Nullable<float> BoundingBoxMeanAveragePrecision { get; set; }

        /// <summary>
        /// Output only. The bounding boxes match metrics for each Intersection-over-union threshold
        /// 0.05,0.10,...,0.95,0.96,0.97,0.98,0.99.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingBoxMetricsEntries")]
        public virtual System.Collections.Generic.IList<XPSBoundingBoxMetricsEntry> BoundingBoxMetricsEntries { get; set; }

        /// <summary>The number of bounding boxes used for model evaluation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluatedBoundingboxCount")]
        public virtual System.Nullable<int> EvaluatedBoundingboxCount { get; set; }

        /// <summary>The number of video frames used for model evaluation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluatedFrameCount")]
        public virtual System.Nullable<int> EvaluatedFrameCount { get; set; }

        /// <summary>The number of tracks used for model evaluation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluatedTrackCount")]
        public virtual System.Nullable<int> EvaluatedTrackCount { get; set; }

        /// <summary>
        /// Output only. The single metric for tracks accuracy evaluation: the mean_average_precision averaged over all
        /// track_metrics_entries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackMeanAveragePrecision")]
        public virtual System.Nullable<float> TrackMeanAveragePrecision { get; set; }

        /// <summary>
        /// Output only. The single metric for tracks bounding box iou evaluation: the mean_bounding_box_iou averaged
        /// over all track_metrics_entries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackMeanBoundingBoxIou")]
        public virtual System.Nullable<float> TrackMeanBoundingBoxIou { get; set; }

        /// <summary>
        /// Output only. The single metric for tracking consistency evaluation: the mean_mismatch_rate averaged over all
        /// track_metrics_entries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackMeanMismatchRate")]
        public virtual System.Nullable<float> TrackMeanMismatchRate { get; set; }

        /// <summary>
        /// Output only. The tracks match metrics for each Intersection-over-union threshold
        /// 0.05,0.10,...,0.95,0.96,0.97,0.98,0.99.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackMetricsEntries")]
        public virtual System.Collections.Generic.IList<XPSTrackMetricsEntry> TrackMetricsEntries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class XPSVideoObjectTrackingTrainResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Populated for AutoML request only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exportModelSpec")]
        public virtual XPSVideoExportModelSpec ExportModelSpec { get; set; }

        /// <summary>## The fields below are only populated under uCAIP request scope.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelArtifactSpec")]
        public virtual XPSVideoModelArtifactSpec ModelArtifactSpec { get; set; }

        /// <summary>
        /// The actual train cost of creating this model, expressed in node seconds, i.e. 3,600 value in this field
        /// means 1 node hour.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainCostNodeSeconds")]
        public virtual System.Nullable<long> TrainCostNodeSeconds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class XPSVideoTrainingOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This is an estimation of the node hours necessary for training a model, expressed in milli node hours (i.e.
        /// 1,000 value in this field means 1 node hour). A node hour represents the time a virtual machine spends
        /// running your training job. The cost of one node running for one hour is a node hour.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainCostMilliNodeHour")]
        public virtual System.Nullable<long> TrainCostMilliNodeHour { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The vision model error analysis configuration. Next tag: 3</summary>
    public class XPSVisionErrorAnalysisConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of query examples in error analysis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exampleCount")]
        public virtual System.Nullable<int> ExampleCount { get; set; }

        /// <summary>The query type used in retrieval. The enum values are frozen in the foreseeable future.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryType")]
        public virtual string QueryType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class XPSVisionTrainingOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Aggregated infra usage within certain time period, for billing report purpose if XAI is enable in training
        /// request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("explanationUsage")]
        public virtual InfraUsage ExplanationUsage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Visualization configurations for image explanation.</summary>
    public class XPSVisualization : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Excludes attributions below the specified percentile, from the highlighted areas. Defaults to 62.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clipPercentLowerbound")]
        public virtual System.Nullable<float> ClipPercentLowerbound { get; set; }

        /// <summary>
        /// Excludes attributions above the specified percentile from the highlighted areas. Using the
        /// clip_percent_upperbound and clip_percent_lowerbound together can be useful for filtering out noise and
        /// making it easier to see areas of strong attribution. Defaults to 99.9.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clipPercentUpperbound")]
        public virtual System.Nullable<float> ClipPercentUpperbound { get; set; }

        /// <summary>
        /// The color scheme used for the highlighted areas. Defaults to PINK_GREEN for Integrated Gradients
        /// attribution, which shows positive attributions in green and negative in pink. Defaults to VIRIDIS for XRAI
        /// attribution, which highlights the most influential regions in yellow and the least influential in blue.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colorMap")]
        public virtual string ColorMap { get; set; }

        /// <summary>
        /// How the original image is displayed in the visualization. Adjusting the overlay can help increase visual
        /// clarity if the original image makes it difficult to view the visualization. Defaults to NONE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overlayType")]
        public virtual string OverlayType { get; set; }

        /// <summary>
        /// Whether to only highlight pixels with positive contributions, negative or both. Defaults to POSITIVE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("polarity")]
        public virtual string Polarity { get; set; }

        /// <summary>
        /// Type of the image visualization. Only applicable to Integrated Gradients attribution. OUTLINES shows regions
        /// of attribution, while PIXELS shows per-pixel attribution. Defaults to OUTLINES.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class XPSXpsOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. XPS server can opt to provide example count of the long running operation (e.g. training, data
        /// importing, batch prediction).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exampleCount")]
        public virtual System.Nullable<long> ExampleCount { get; set; }

        /// <summary>
        /// Metrics for the operation. By the time the operation is terminated (whether succeeded or failed) as returned
        /// from XPS, AutoML BE assumes the metrics are finalized. AutoML BE transparently posts the metrics to Chemist
        /// if it's not empty, regardless of the response content or error type. If user is supposed to be charged in
        /// case of cancellation/error, this field should be set. In the case where the type of LRO doesn't require any
        /// billing, this field should be left unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportingMetrics")]
        public virtual XPSReportingMetrics ReportingMetrics { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("tablesTrainingOperationMetadata")]
        public virtual XPSTablesTrainingOperationMetadata TablesTrainingOperationMetadata { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("videoBatchPredictOperationMetadata")]
        public virtual XPSVideoBatchPredictOperationMetadata VideoBatchPredictOperationMetadata { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("videoTrainingOperationMetadata")]
        public virtual XPSVideoTrainingOperationMetadata VideoTrainingOperationMetadata { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("visionTrainingOperationMetadata")]
        public virtual XPSVisionTrainingOperationMetadata VisionTrainingOperationMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An explanation method that redistributes Integrated Gradients attributions to segmented regions, taking
    /// advantage of the model's fully differentiable structure. Refer to this paper for more details:
    /// https://arxiv.org/abs/1906.02825 Only supports image Models (modality is IMAGE).
    /// </summary>
    public class XPSXraiAttribution : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The number of steps for approximating the path integral. A good value to start is 50 and gradually increase
        /// until the sum to diff property is met within the desired error range. Valid range of its value is [1, 100],
        /// inclusively.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stepCount")]
        public virtual System.Nullable<int> StepCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
