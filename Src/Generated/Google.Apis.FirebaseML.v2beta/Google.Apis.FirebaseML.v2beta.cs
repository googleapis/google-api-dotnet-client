// Copyright 2024 Google LLC
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

namespace Google.Apis.FirebaseML.v2beta
{
    /// <summary>The FirebaseML Service.</summary>
    public class FirebaseMLService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2beta";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public FirebaseMLService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public FirebaseMLService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://firebaseml.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://firebaseml.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "firebaseml";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Firebase ML API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Firebase ML API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for FirebaseML requests.</summary>
    public abstract class FirebaseMLBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new FirebaseMLBaseServiceRequest instance.</summary>
        protected FirebaseMLBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes FirebaseML parameter list.</summary>
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

    /// <summary>The "projects" collection of methods.</summary>
    public class ProjectsResource
    {
        private const string Resource = "projects";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ProjectsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Locations = new LocationsResource(service);
        }

        /// <summary>Gets the Locations resource.</summary>
        public virtual LocationsResource Locations { get; }

        /// <summary>The "locations" collection of methods.</summary>
        public class LocationsResource
        {
            private const string Resource = "locations";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public LocationsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Publishers = new PublishersResource(service);
            }

            /// <summary>Gets the Publishers resource.</summary>
            public virtual PublishersResource Publishers { get; }

            /// <summary>The "publishers" collection of methods.</summary>
            public class PublishersResource
            {
                private const string Resource = "publishers";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public PublishersResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Models = new ModelsResource(service);
                }

                /// <summary>Gets the Models resource.</summary>
                public virtual ModelsResource Models { get; }

                /// <summary>The "models" collection of methods.</summary>
                public class ModelsResource
                {
                    private const string Resource = "models";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ModelsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Perform a token counting.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="endpoint">
                    /// Required. The name of the Endpoint requested to perform token counting. Format:
                    /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
                    /// </param>
                    public virtual CountTokensRequest CountTokens(Google.Apis.FirebaseML.v2beta.Data.CountTokensRequest body, string endpoint)
                    {
                        return new CountTokensRequest(this.service, body, endpoint);
                    }

                    /// <summary>Perform a token counting.</summary>
                    public class CountTokensRequest : FirebaseMLBaseServiceRequest<Google.Apis.FirebaseML.v2beta.Data.CountTokensResponse>
                    {
                        /// <summary>Constructs a new CountTokens request.</summary>
                        public CountTokensRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseML.v2beta.Data.CountTokensRequest body, string endpoint) : base(service)
                        {
                            Endpoint = endpoint;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the Endpoint requested to perform token counting. Format:
                        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("endpoint", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Endpoint { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.FirebaseML.v2beta.Data.CountTokensRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "countTokens";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2beta/{+endpoint}:countTokens";

                        /// <summary>Initializes CountTokens parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("endpoint", new Google.Apis.Discovery.Parameter
                            {
                                Name = "endpoint",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/publishers/[^/]+/models/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Generate content with multimodal inputs.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="model">
                    /// Required. The name of the publisher model requested to serve the prediction. Format:
                    /// `projects/{project}/locations/{location}/publishers/*/models/*`
                    /// </param>
                    public virtual GenerateContentRequest GenerateContent(Google.Apis.FirebaseML.v2beta.Data.GenerateContentRequest body, string model)
                    {
                        return new GenerateContentRequest(this.service, body, model);
                    }

                    /// <summary>Generate content with multimodal inputs.</summary>
                    public class GenerateContentRequest : FirebaseMLBaseServiceRequest<Google.Apis.FirebaseML.v2beta.Data.GenerateContentResponse>
                    {
                        /// <summary>Constructs a new GenerateContent request.</summary>
                        public GenerateContentRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseML.v2beta.Data.GenerateContentRequest body, string model) : base(service)
                        {
                            Model = model;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the publisher model requested to serve the prediction. Format:
                        /// `projects/{project}/locations/{location}/publishers/*/models/*`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("model", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Model { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.FirebaseML.v2beta.Data.GenerateContentRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "generateContent";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2beta/{+model}:generateContent";

                        /// <summary>Initializes GenerateContent parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("model", new Google.Apis.Discovery.Parameter
                            {
                                Name = "model",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/publishers/[^/]+/models/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Generate content with multimodal inputs with streaming support.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="model">
                    /// Required. The name of the publisher model requested to serve the prediction. Format:
                    /// `projects/{project}/locations/{location}/publishers/*/models/*`
                    /// </param>
                    public virtual StreamGenerateContentRequest StreamGenerateContent(Google.Apis.FirebaseML.v2beta.Data.GenerateContentRequest body, string model)
                    {
                        return new StreamGenerateContentRequest(this.service, body, model);
                    }

                    /// <summary>Generate content with multimodal inputs with streaming support.</summary>
                    public class StreamGenerateContentRequest : FirebaseMLBaseServiceRequest<Google.Apis.FirebaseML.v2beta.Data.GenerateContentResponse>
                    {
                        /// <summary>Constructs a new StreamGenerateContent request.</summary>
                        public StreamGenerateContentRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseML.v2beta.Data.GenerateContentRequest body, string model) : base(service)
                        {
                            Model = model;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the publisher model requested to serve the prediction. Format:
                        /// `projects/{project}/locations/{location}/publishers/*/models/*`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("model", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Model { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.FirebaseML.v2beta.Data.GenerateContentRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "streamGenerateContent";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2beta/{+model}:streamGenerateContent";

                        /// <summary>Initializes StreamGenerateContent parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("model", new Google.Apis.Discovery.Parameter
                            {
                                Name = "model",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/publishers/[^/]+/models/[^/]+$",
                            });
                        }
                    }
                }
            }
        }
    }
}
namespace Google.Apis.FirebaseML.v2beta.Data
{
    /// <summary>Content blob. It's preferred to send as text directly rather than raw bytes.</summary>
    public class Blob : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Raw bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>Required. The IANA standard MIME type of the source data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response candidate generated from the model.</summary>
    public class Candidate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Source attribution of the generated content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("citationMetadata")]
        public virtual CitationMetadata CitationMetadata { get; set; }

        /// <summary>Output only. Content parts of the candidate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual Content Content { get; set; }

        /// <summary>
        /// Output only. Describes the reason the mode stopped generating tokens in more detail. This is only filled
        /// when `finish_reason` is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finishMessage")]
        public virtual string FinishMessage { get; set; }

        /// <summary>
        /// Output only. The reason why the model stopped generating tokens. If empty, the model has not stopped
        /// generating the tokens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finishReason")]
        public virtual string FinishReason { get; set; }

        /// <summary>Output only. Metadata specifies sources used to ground generated content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groundingMetadata")]
        public virtual GroundingMetadata GroundingMetadata { get; set; }

        /// <summary>Output only. Index of the candidate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual System.Nullable<int> Index { get; set; }

        /// <summary>
        /// Output only. List of ratings for the safety of a response candidate. There is at most one rating per
        /// category.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("safetyRatings")]
        public virtual System.Collections.Generic.IList<SafetyRating> SafetyRatings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Source attributions for content.</summary>
    public class Citation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. End index into the content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endIndex")]
        public virtual System.Nullable<int> EndIndex { get; set; }

        /// <summary>Output only. License of the attribution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("license")]
        public virtual string License { get; set; }

        /// <summary>Output only. Publication date of the attribution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicationDate")]
        public virtual Date PublicationDate { get; set; }

        /// <summary>Output only. Start index into the content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; }

        /// <summary>Output only. Title of the attribution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>Output only. Url reference of the attribution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A collection of source attributions for a piece of content.</summary>
    public class CitationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. List of citations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("citations")]
        public virtual System.Collections.Generic.IList<Citation> Citations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The base structured datatype containing multi-part content of a message. A `Content` includes a `role` field
    /// designating the producer of the `Content` and a `parts` field containing multi-part data that contains the
    /// content of the message turn.
    /// </summary>
    public class Content : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Ordered `Parts` that constitute a single message. Parts may have different IANA MIME types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parts")]
        public virtual System.Collections.Generic.IList<Part> Parts { get; set; }

        /// <summary>
        /// Optional. The producer of the content. Must be either 'user' or 'model'. Useful to set for multi-turn
        /// conversations, otherwise can be left blank or unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for PredictionService.CountTokens.</summary>
    public class CountTokensRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Input content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contents")]
        public virtual System.Collections.Generic.IList<Content> Contents { get; set; }

        /// <summary>
        /// Required. The instances that are the input to token counting call. Schema is identical to the prediction
        /// schema of the underlying model.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instances")]
        public virtual System.Collections.Generic.IList<object> Instances { get; set; }

        /// <summary>
        /// Required. The name of the publisher model requested to serve the prediction. Format:
        /// `projects/{project}/locations/{location}/publishers/*/models/*`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for PredictionService.CountTokens.</summary>
    public class CountTokensResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The total number of billable characters counted across all instances from the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalBillableCharacters")]
        public virtual System.Nullable<int> TotalBillableCharacters { get; set; }

        /// <summary>The total number of tokens counted across all instances from the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalTokens")]
        public virtual System.Nullable<int> TotalTokens { get; set; }

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

    /// <summary>URI based data.</summary>
    public class FileData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. URI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileUri")]
        public virtual string FileUri { get; set; }

        /// <summary>Required. The IANA standard MIME type of the source data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A predicted [FunctionCall] returned from the model that contains a string representing the
    /// [FunctionDeclaration.name] and a structured JSON object containing the parameters and their values.
    /// </summary>
    public class FunctionCall : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Required. The function parameters and values in JSON object format. See
        /// [FunctionDeclaration.parameters] for parameter details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IDictionary<string, object> Args { get; set; }

        /// <summary>Required. The name of the function to call. Matches [FunctionDeclaration.name].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Function calling config.</summary>
    public class FunctionCallingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Function names to call. Only set when the Mode is ANY. Function names should match
        /// [FunctionDeclaration.name]. With mode set to ANY, model will predict a function call from the set of
        /// function names provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedFunctionNames")]
        public virtual System.Collections.Generic.IList<string> AllowedFunctionNames { get; set; }

        /// <summary>Optional. Function calling mode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual string Mode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Structured representation of a function declaration as defined by the [OpenAPI 3.0
    /// specification](https://spec.openapis.org/oas/v3.0.3). Included in this declaration are the function name and
    /// parameters. This FunctionDeclaration is a representation of a block of code that can be used as a `Tool` by the
    /// model and executed by the client.
    /// </summary>
    public class FunctionDeclaration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Description and purpose of the function. Model uses it to decide how and whether to call the
        /// function.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Required. The name of the function to call. Must start with a letter or an underscore. Must be a-z, A-Z,
        /// 0-9, or contain underscores, dots and dashes, with a maximum length of 64.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. Describes the parameters to this function in JSON Schema Object format. Reflects the Open API 3.03
        /// Parameter Object. string Key: the name of the parameter. Parameter names are case sensitive. Schema Value:
        /// the Schema defining the type used for the parameter. For function with no parameters, this can be left
        /// unset. Parameter names must start with a letter or an underscore and must only contain chars a-z, A-Z, 0-9,
        /// or underscores with a maximum length of 64. Example with 1 required and 1 optional parameter: type: OBJECT
        /// properties: param1: type: STRING param2: type: INTEGER required: - param1
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual Schema Parameters { get; set; }

        /// <summary>
        /// Optional. Describes the output from this function in JSON Schema format. Reflects the Open API 3.03 Response
        /// Object. The Schema defines the type used for the response value of the function.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual Schema Response { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The result output from a [FunctionCall] that contains a string representing the [FunctionDeclaration.name] and a
    /// structured JSON object containing any output from the function is used as context to the model. This should
    /// contain the result of a [FunctionCall] made based on model prediction.
    /// </summary>
    public class FunctionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The name of the function to call. Matches [FunctionDeclaration.name] and [FunctionCall.name].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. The function response in JSON object format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string, object> Response { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for [PredictionService.GenerateContent].</summary>
    public class GenerateContentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The content of the current conversation with the model. For single-turn queries, this is a single
        /// instance. For multi-turn queries, this is a repeated field that contains conversation history + latest
        /// request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contents")]
        public virtual System.Collections.Generic.IList<Content> Contents { get; set; }

        /// <summary>Optional. Generation config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generationConfig")]
        public virtual GenerationConfig GenerationConfig { get; set; }

        /// <summary>
        /// Optional. Per request settings for blocking unsafe content. Enforced on GenerateContentResponse.candidates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("safetySettings")]
        public virtual System.Collections.Generic.IList<SafetySetting> SafetySettings { get; set; }

        /// <summary>
        /// Optional. The user provided system instructions for the model. Note: only text should be used in parts and
        /// content in each part will be in a separate paragraph.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemInstruction")]
        public virtual Content SystemInstruction { get; set; }

        /// <summary>Optional. Tool config. This config is shared for all tools provided in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolConfig")]
        public virtual ToolConfig ToolConfig { get; set; }

        /// <summary>
        /// Optional. A list of `Tools` the model may use to generate the next response. A `Tool` is a piece of code
        /// that enables the system to interact with external systems to perform an action, or set of actions, outside
        /// of knowledge and scope of the model.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tools")]
        public virtual System.Collections.Generic.IList<Tool> Tools { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for [PredictionService.GenerateContent].</summary>
    public class GenerateContentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Generated candidates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("candidates")]
        public virtual System.Collections.Generic.IList<Candidate> Candidates { get; set; }

        /// <summary>
        /// Output only. Content filter results for a prompt sent in the request. Note: Sent only in the first stream
        /// chunk. Only happens when no candidates were generated due to content violations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promptFeedback")]
        public virtual PromptFeedback PromptFeedback { get; set; }

        /// <summary>Usage metadata about the response(s).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usageMetadata")]
        public virtual UsageMetadata UsageMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Generation config.</summary>
    public class GenerationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Number of candidates to generate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("candidateCount")]
        public virtual System.Nullable<int> CandidateCount { get; set; }

        /// <summary>Optional. Frequency penalties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frequencyPenalty")]
        public virtual System.Nullable<float> FrequencyPenalty { get; set; }

        /// <summary>Optional. The maximum number of output tokens to generate per message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxOutputTokens")]
        public virtual System.Nullable<int> MaxOutputTokens { get; set; }

        /// <summary>Optional. Positive penalties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("presencePenalty")]
        public virtual System.Nullable<float> PresencePenalty { get; set; }

        /// <summary>
        /// Optional. Output response mimetype of the generated candidate text. Supported mimetype: - `text/plain`:
        /// (default) Text output. - `application/json`: JSON response in the candidates. The model needs to be prompted
        /// to output the appropriate response type, otherwise the behavior is undefined. This is a preview feature.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseMimeType")]
        public virtual string ResponseMimeType { get; set; }

        /// <summary>Optional. Stop sequences.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stopSequences")]
        public virtual System.Collections.Generic.IList<string> StopSequences { get; set; }

        /// <summary>Optional. Controls the randomness of predictions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("temperature")]
        public virtual System.Nullable<float> Temperature { get; set; }

        /// <summary>Optional. If specified, top-k sampling will be used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topK")]
        public virtual System.Nullable<float> TopK { get; set; }

        /// <summary>Optional. If specified, nucleus sampling will be used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topP")]
        public virtual System.Nullable<float> TopP { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata returned to client when grounding is enabled.</summary>
    public class GroundingMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Queries executed by the retrieval tools.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retrievalQueries")]
        public virtual System.Collections.Generic.IList<string> RetrievalQueries { get; set; }

        /// <summary>Optional. Google search entry for the following-up web searches.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchEntryPoint")]
        public virtual SearchEntryPoint SearchEntryPoint { get; set; }

        /// <summary>Optional. Web search queries for the following-up web search.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webSearchQueries")]
        public virtual System.Collections.Generic.IList<string> WebSearchQueries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This is returned in the longrunning operations for create/update.</summary>
    public class ModelOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("basicOperationStatus")]
        public virtual string BasicOperationStatus { get; set; }

        /// <summary>
        /// The name of the model we are creating/updating The name must have the form
        /// `projects/{project_id}/models/{model_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A datatype containing media that is part of a multi-part `Content` message. A `Part` consists of data which has
    /// an associated datatype. A `Part` can only contain one of the accepted types in `Part.data`. A `Part` must have a
    /// fixed IANA MIME type identifying the type and subtype of the media if `inline_data` or `file_data` field is
    /// filled with raw bytes.
    /// </summary>
    public class Part : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. URI based data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileData")]
        public virtual FileData FileData { get; set; }

        /// <summary>
        /// Optional. A predicted [FunctionCall] returned from the model that contains a string representing the
        /// [FunctionDeclaration.name] with the parameters and their values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("functionCall")]
        public virtual FunctionCall FunctionCall { get; set; }

        /// <summary>
        /// Optional. The result output of a [FunctionCall] that contains a string representing the
        /// [FunctionDeclaration.name] and a structured JSON object containing any output from the function call. It is
        /// used as context to the model.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("functionResponse")]
        public virtual FunctionResponse FunctionResponse { get; set; }

        /// <summary>Optional. Inlined bytes data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inlineData")]
        public virtual Blob InlineData { get; set; }

        /// <summary>Optional. Text part (can be code).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>
        /// Optional. Video metadata. The metadata should only be specified while the video data is presented in
        /// inline_data or file_data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoMetadata")]
        public virtual VideoMetadata VideoMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Content filter results for a prompt sent in the request.</summary>
    public class PromptFeedback : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Blocked reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockReason")]
        public virtual string BlockReason { get; set; }

        /// <summary>Output only. A readable block reason message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockReasonMessage")]
        public virtual string BlockReasonMessage { get; set; }

        /// <summary>Output only. Safety ratings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("safetyRatings")]
        public virtual System.Collections.Generic.IList<SafetyRating> SafetyRatings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines a retrieval tool that model can call to access external knowledge.</summary>
    public class Retrieval : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Disable using the result from this tool in detecting grounding attribution. This does not affect
        /// how the result is given to the model for generation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableAttribution")]
        public virtual System.Nullable<bool> DisableAttribution { get; set; }

        /// <summary>Set to use data source powered by Vertex AI Search.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vertexAiSearch")]
        public virtual VertexAISearch VertexAiSearch { get; set; }

        /// <summary>
        /// Set to use data source powered by Vertex RAG store. User data is uploaded via the VertexRagDataService.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vertexRagStore")]
        public virtual VertexRagStore VertexRagStore { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Safety rating corresponding to the generated content.</summary>
    public class SafetyRating : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Indicates whether the content was filtered out because of this rating.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blocked")]
        public virtual System.Nullable<bool> Blocked { get; set; }

        /// <summary>Output only. Harm category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>Output only. Harm probability levels in the content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("probability")]
        public virtual string Probability { get; set; }

        /// <summary>Output only. Harm probability score.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("probabilityScore")]
        public virtual System.Nullable<float> ProbabilityScore { get; set; }

        /// <summary>Output only. Harm severity levels in the content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>Output only. Harm severity score.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severityScore")]
        public virtual System.Nullable<float> SeverityScore { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Safety settings.</summary>
    public class SafetySetting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Harm category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>
        /// Optional. Specify if the threshold is used for probability or severity score. If not specified, the
        /// threshold is used for probability score.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual string Method { get; set; }

        /// <summary>Required. The harm block threshold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threshold")]
        public virtual string Threshold { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Schema is used to define the format of input/output data. Represents a select subset of an [OpenAPI 3.0 schema
    /// object](https://spec.openapis.org/oas/v3.0.3#schema). More fields may be added in the future as needed.
    /// </summary>
    public class Schema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Default value of the data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("default")]
        public virtual object Default__ { get; set; }

        /// <summary>Optional. The description of the data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. Possible values of the element of Type.STRING with enum format. For example we can define an Enum
        /// Direction as : {type:STRING, format:enum, enum:["EAST", NORTH", "SOUTH", "WEST"]}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enum")]
        public virtual System.Collections.Generic.IList<string> Enum__ { get; set; }

        /// <summary>Optional. Example of the object. Will only populated when the object is the root.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("example")]
        public virtual object Example { get; set; }

        /// <summary>
        /// Optional. The format of the data. Supported formats: for NUMBER type: "float", "double" for INTEGER type:
        /// "int32", "int64" for STRING type: "email", "byte", etc
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("format")]
        public virtual string Format { get; set; }

        /// <summary>Optional. SCHEMA FIELDS FOR TYPE ARRAY Schema of the elements of Type.ARRAY.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual Schema Items { get; set; }

        /// <summary>Optional. Maximum number of the elements for Type.ARRAY.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxItems")]
        public virtual System.Nullable<long> MaxItems { get; set; }

        /// <summary>Optional. Maximum length of the Type.STRING</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxLength")]
        public virtual System.Nullable<long> MaxLength { get; set; }

        /// <summary>Optional. Maximum number of the properties for Type.OBJECT.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxProperties")]
        public virtual System.Nullable<long> MaxProperties { get; set; }

        /// <summary>Optional. Maximum value of the Type.INTEGER and Type.NUMBER</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximum")]
        public virtual System.Nullable<double> Maximum { get; set; }

        /// <summary>Optional. Minimum number of the elements for Type.ARRAY.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minItems")]
        public virtual System.Nullable<long> MinItems { get; set; }

        /// <summary>Optional. SCHEMA FIELDS FOR TYPE STRING Minimum length of the Type.STRING</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minLength")]
        public virtual System.Nullable<long> MinLength { get; set; }

        /// <summary>Optional. Minimum number of the properties for Type.OBJECT.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minProperties")]
        public virtual System.Nullable<long> MinProperties { get; set; }

        /// <summary>
        /// Optional. SCHEMA FIELDS FOR TYPE INTEGER and NUMBER Minimum value of the Type.INTEGER and Type.NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimum")]
        public virtual System.Nullable<double> Minimum { get; set; }

        /// <summary>Optional. Indicates if the value may be null.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nullable")]
        public virtual System.Nullable<bool> Nullable { get; set; }

        /// <summary>Optional. Pattern of the Type.STRING to restrict a string to a regular expression.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pattern")]
        public virtual string Pattern { get; set; }

        /// <summary>Optional. SCHEMA FIELDS FOR TYPE OBJECT Properties of Type.OBJECT.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IDictionary<string, Schema> Properties { get; set; }

        /// <summary>Optional. Required properties of Type.OBJECT.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("required")]
        public virtual System.Collections.Generic.IList<string> Required { get; set; }

        /// <summary>Optional. The title of the Schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>Optional. The type of the data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Google search entry point.</summary>
    public class SearchEntryPoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Web content snippet that can be embedded in a web page or an app webview.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("renderedContent")]
        public virtual string RenderedContent { get; set; }

        /// <summary>Optional. Base64 encoded JSON representing array of tuple.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sdkBlob")]
        public virtual string SdkBlob { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Tool details that the model may use to generate response. A `Tool` is a piece of code that enables the system to
    /// interact with external systems to perform an action, or set of actions, outside of knowledge and scope of the
    /// model. A Tool object should contain exactly one type of Tool (e.g FunctionDeclaration, Retrieval or
    /// GoogleSearchRetrieval).
    /// </summary>
    public class Tool : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Function tool type. One or more function declarations to be passed to the model along with the
        /// current user query. Model may decide to call a subset of these functions by populating FunctionCall in the
        /// response. User should provide a FunctionResponse for each function call in the next turn. Based on the
        /// function responses, Model will generate the final response back to the user. Maximum 64 function
        /// declarations can be provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("functionDeclarations")]
        public virtual System.Collections.Generic.IList<FunctionDeclaration> FunctionDeclarations { get; set; }

        /// <summary>
        /// Optional. Retrieval tool type. System will always execute the provided retrieval tool(s) to get external
        /// knowledge to answer the prompt. Retrieval results are presented to the model for generation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retrieval")]
        public virtual Retrieval Retrieval { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Tool config. This config is shared for all tools provided in the request.</summary>
    public class ToolConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Function calling config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("functionCallingConfig")]
        public virtual FunctionCallingConfig FunctionCallingConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Usage metadata about response(s).</summary>
    public class UsageMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of tokens in the response(s).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("candidatesTokenCount")]
        public virtual System.Nullable<int> CandidatesTokenCount { get; set; }

        /// <summary>Number of tokens in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promptTokenCount")]
        public virtual System.Nullable<int> PromptTokenCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("totalTokenCount")]
        public virtual System.Nullable<int> TotalTokenCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Retrieve from Vertex AI Search datastore for grounding. See
    /// https://cloud.google.com/vertex-ai-search-and-conversation
    /// </summary>
    public class VertexAISearch : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Fully-qualified Vertex AI Search's datastore resource ID. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{dataStore}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datastore")]
        public virtual string Datastore { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Retrieve from Vertex RAG Store for grounding.</summary>
    public class VertexRagStore : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Vertex RAG Store corpus resource name:
        /// `projects/{project}/locations/{location}/ragCorpora/{ragCorpus}` Currently only one corpus is allowed. In
        /// the future we may open up multiple corpora support. However, they should be from the same project and
        /// location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ragCorpora")]
        public virtual System.Collections.Generic.IList<string> RagCorpora { get; set; }

        /// <summary>Optional. Number of top k results to return from the selected corpora.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("similarityTopK")]
        public virtual System.Nullable<int> SimilarityTopK { get; set; }

        /// <summary>Optional. Only return results with vector distance smaller than the threshold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vectorDistanceThreshold")]
        public virtual System.Nullable<double> VectorDistanceThreshold { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata describes the input video content.</summary>
    public class VideoMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The end offset of the video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endOffset")]
        public virtual object EndOffset { get; set; }

        /// <summary>Optional. The start offset of the video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startOffset")]
        public virtual object StartOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
