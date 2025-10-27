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
                    public virtual CountTokensRequest CountTokens(Google.Apis.FirebaseML.v2beta.Data.GoogleCloudAiplatformV1beta1CountTokensRequest body, string endpoint)
                    {
                        return new CountTokensRequest(this.service, body, endpoint);
                    }

                    /// <summary>Perform a token counting.</summary>
                    public class CountTokensRequest : FirebaseMLBaseServiceRequest<Google.Apis.FirebaseML.v2beta.Data.GoogleCloudAiplatformV1beta1CountTokensResponse>
                    {
                        /// <summary>Constructs a new CountTokens request.</summary>
                        public CountTokensRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseML.v2beta.Data.GoogleCloudAiplatformV1beta1CountTokensRequest body, string endpoint) : base(service)
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
                        Google.Apis.FirebaseML.v2beta.Data.GoogleCloudAiplatformV1beta1CountTokensRequest Body { get; set; }

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
                    /// Required. The fully qualified name of the publisher model or tuned model endpoint to use.
                    /// Publisher model format: `projects/{project}/locations/{location}/publishers/*/models/*` Tuned
                    /// model endpoint format: `projects/{project}/locations/{location}/endpoints/{endpoint}`
                    /// </param>
                    public virtual GenerateContentRequest GenerateContent(Google.Apis.FirebaseML.v2beta.Data.GoogleCloudAiplatformV1beta1GenerateContentRequest body, string model)
                    {
                        return new GenerateContentRequest(this.service, body, model);
                    }

                    /// <summary>Generate content with multimodal inputs.</summary>
                    public class GenerateContentRequest : FirebaseMLBaseServiceRequest<Google.Apis.FirebaseML.v2beta.Data.GoogleCloudAiplatformV1beta1GenerateContentResponse>
                    {
                        /// <summary>Constructs a new GenerateContent request.</summary>
                        public GenerateContentRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseML.v2beta.Data.GoogleCloudAiplatformV1beta1GenerateContentRequest body, string model) : base(service)
                        {
                            Model = model;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The fully qualified name of the publisher model or tuned model endpoint to use.
                        /// Publisher model format: `projects/{project}/locations/{location}/publishers/*/models/*`
                        /// Tuned model endpoint format: `projects/{project}/locations/{location}/endpoints/{endpoint}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("model", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Model { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.FirebaseML.v2beta.Data.GoogleCloudAiplatformV1beta1GenerateContentRequest Body { get; set; }

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
                    /// Required. The fully qualified name of the publisher model or tuned model endpoint to use.
                    /// Publisher model format: `projects/{project}/locations/{location}/publishers/*/models/*` Tuned
                    /// model endpoint format: `projects/{project}/locations/{location}/endpoints/{endpoint}`
                    /// </param>
                    public virtual StreamGenerateContentRequest StreamGenerateContent(Google.Apis.FirebaseML.v2beta.Data.GoogleCloudAiplatformV1beta1GenerateContentRequest body, string model)
                    {
                        return new StreamGenerateContentRequest(this.service, body, model);
                    }

                    /// <summary>Generate content with multimodal inputs with streaming support.</summary>
                    public class StreamGenerateContentRequest : FirebaseMLBaseServiceRequest<Google.Apis.FirebaseML.v2beta.Data.GoogleCloudAiplatformV1beta1GenerateContentResponse>
                    {
                        /// <summary>Constructs a new StreamGenerateContent request.</summary>
                        public StreamGenerateContentRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseML.v2beta.Data.GoogleCloudAiplatformV1beta1GenerateContentRequest body, string model) : base(service)
                        {
                            Model = model;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The fully qualified name of the publisher model or tuned model endpoint to use.
                        /// Publisher model format: `projects/{project}/locations/{location}/publishers/*/models/*`
                        /// Tuned model endpoint format: `projects/{project}/locations/{location}/endpoints/{endpoint}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("model", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Model { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.FirebaseML.v2beta.Data.GoogleCloudAiplatformV1beta1GenerateContentRequest Body { get; set; }

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

    /// <summary>
    /// The generic reusable api auth config. Deprecated. Please use AuthConfig
    /// (google/cloud/aiplatform/master/auth.proto) instead.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1ApiAuth : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The API secret.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiKeyConfig")]
        public virtual GoogleCloudAiplatformV1beta1ApiAuthApiKeyConfig ApiKeyConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The API secret.</summary>
    public class GoogleCloudAiplatformV1beta1ApiAuthApiKeyConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The SecretManager secret version resource name storing API key. e.g.
        /// projects/{project}/secrets/{secret}/versions/{version}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiKeySecretVersion")]
        public virtual string ApiKeySecretVersion { get; set; }

        /// <summary>The API key string. Either this or `api_key_secret_version` must be set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiKeyString")]
        public virtual string ApiKeyString { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Auth configuration to run the extension.</summary>
    public class GoogleCloudAiplatformV1beta1AuthConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Config for API key auth.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiKeyConfig")]
        public virtual GoogleCloudAiplatformV1beta1AuthConfigApiKeyConfig ApiKeyConfig { get; set; }

        /// <summary>Type of auth scheme.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authType")]
        public virtual string AuthType { get; set; }

        /// <summary>Config for Google Service Account auth.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleServiceAccountConfig")]
        public virtual GoogleCloudAiplatformV1beta1AuthConfigGoogleServiceAccountConfig GoogleServiceAccountConfig { get; set; }

        /// <summary>Config for HTTP Basic auth.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpBasicAuthConfig")]
        public virtual GoogleCloudAiplatformV1beta1AuthConfigHttpBasicAuthConfig HttpBasicAuthConfig { get; set; }

        /// <summary>Config for user oauth.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauthConfig")]
        public virtual GoogleCloudAiplatformV1beta1AuthConfigOauthConfig OauthConfig { get; set; }

        /// <summary>Config for user OIDC auth.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oidcConfig")]
        public virtual GoogleCloudAiplatformV1beta1AuthConfigOidcConfig OidcConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Config for authentication with API key.</summary>
    public class GoogleCloudAiplatformV1beta1AuthConfigApiKeyConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The name of the SecretManager secret version resource storing the API key. Format:
        /// `projects/{project}/secrets/{secrete}/versions/{version}` - If both `api_key_secret` and `api_key_string`
        /// are specified, this field takes precedence over `api_key_string`. - If specified, the
        /// `secretmanager.versions.access` permission should be granted to Vertex AI Extension Service Agent
        /// (https://cloud.google.com/vertex-ai/docs/general/access-control#service-agents) on the specified resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiKeySecret")]
        public virtual string ApiKeySecret { get; set; }

        /// <summary>Optional. The API key to be used in the request directly.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiKeyString")]
        public virtual string ApiKeyString { get; set; }

        /// <summary>Optional. The location of the API key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpElementLocation")]
        public virtual string HttpElementLocation { get; set; }

        /// <summary>
        /// Optional. The parameter name of the API key. E.g. If the API request is "https://example.com/act?api_key=",
        /// "api_key" would be the parameter name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Config for Google Service Account Authentication.</summary>
    public class GoogleCloudAiplatformV1beta1AuthConfigGoogleServiceAccountConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The service account that the extension execution service runs as. - If the service account is
        /// specified, the `iam.serviceAccounts.getAccessToken` permission should be granted to Vertex AI Extension
        /// Service Agent (https://cloud.google.com/vertex-ai/docs/general/access-control#service-agents) on the
        /// specified service account. - If not specified, the Vertex AI Extension Service Agent will be used to execute
        /// the Extension.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Config for HTTP Basic Authentication.</summary>
    public class GoogleCloudAiplatformV1beta1AuthConfigHttpBasicAuthConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The name of the SecretManager secret version resource storing the base64 encoded credentials.
        /// Format: `projects/{project}/secrets/{secrete}/versions/{version}` - If specified, the
        /// `secretmanager.versions.access` permission should be granted to Vertex AI Extension Service Agent
        /// (https://cloud.google.com/vertex-ai/docs/general/access-control#service-agents) on the specified resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("credentialSecret")]
        public virtual string CredentialSecret { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Config for user oauth.</summary>
    public class GoogleCloudAiplatformV1beta1AuthConfigOauthConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Access token for extension endpoint. Only used to propagate token from
        /// [[ExecuteExtensionRequest.runtime_auth_config]] at request time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessToken")]
        public virtual string AccessToken { get; set; }

        /// <summary>
        /// The service account used to generate access tokens for executing the Extension. - If the service account is
        /// specified, the `iam.serviceAccounts.getAccessToken` permission should be granted to Vertex AI Extension
        /// Service Agent (https://cloud.google.com/vertex-ai/docs/general/access-control#service-agents) on the
        /// provided service account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Config for user OIDC auth.</summary>
    public class GoogleCloudAiplatformV1beta1AuthConfigOidcConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// OpenID Connect formatted ID token for extension endpoint. Only used to propagate token from
        /// [[ExecuteExtensionRequest.runtime_auth_config]] at request time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("idToken")]
        public virtual string IdToken { get; set; }

        /// <summary>
        /// The service account used to generate an OpenID Connect (OIDC)-compatible JWT token signed by the Google OIDC
        /// Provider (accounts.google.com) for extension endpoint
        /// (https://cloud.google.com/iam/docs/create-short-lived-credentials-direct#sa-credentials-oidc). - The
        /// audience for the token will be set to the URL in the server url defined in the OpenApi spec. - If the
        /// service account is provided, the service account should grant `iam.serviceAccounts.getOpenIdToken`
        /// permission to Vertex AI Extension Service Agent
        /// (https://cloud.google.com/vertex-ai/docs/general/access-control#service-agents).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A content blob. A Blob contains data of a specific media type. It is used to represent images, audio, and video.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1Blob : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The raw bytes of the data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>
        /// Optional. The display name of the blob. Used to provide a label or filename to distinguish blobs. This field
        /// is only returned in `PromptMessage` for prompt management. It is used in the Gemini calls only when
        /// server-side tools (`code_execution`, `google_search`, and `url_context`) are enabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Required. The IANA standard MIME type of the source data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response candidate generated from the model.</summary>
    public class GoogleCloudAiplatformV1beta1Candidate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The average log probability of the tokens in this candidate. This is a length-normalized score
        /// that can be used to compare the quality of candidates of different lengths. A higher average log probability
        /// suggests a more confident and coherent response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("avgLogprobs")]
        public virtual System.Nullable<double> AvgLogprobs { get; set; }

        /// <summary>Output only. A collection of citations that apply to the generated content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("citationMetadata")]
        public virtual GoogleCloudAiplatformV1beta1CitationMetadata CitationMetadata { get; set; }

        /// <summary>Output only. The content of the candidate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual GoogleCloudAiplatformV1beta1Content Content { get; set; }

        /// <summary>
        /// Output only. Describes the reason the model stopped generating tokens in more detail. This field is returned
        /// only when `finish_reason` is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finishMessage")]
        public virtual string FinishMessage { get; set; }

        /// <summary>
        /// Output only. The reason why the model stopped generating tokens. If empty, the model has not stopped
        /// generating.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finishReason")]
        public virtual string FinishReason { get; set; }

        /// <summary>
        /// Output only. Metadata returned when grounding is enabled. It contains the sources used to ground the
        /// generated content.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groundingMetadata")]
        public virtual GoogleCloudAiplatformV1beta1GroundingMetadata GroundingMetadata { get; set; }

        /// <summary>
        /// Output only. The 0-based index of this candidate in the list of generated responses. This is useful for
        /// distinguishing between multiple candidates when `candidate_count` &amp;gt; 1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual System.Nullable<int> Index { get; set; }

        /// <summary>
        /// Output only. The detailed log probability information for the tokens in this candidate. This is useful for
        /// debugging, understanding model uncertainty, and identifying potential "hallucinations".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logprobsResult")]
        public virtual GoogleCloudAiplatformV1beta1LogprobsResult LogprobsResult { get; set; }

        /// <summary>
        /// Output only. A list of ratings for the safety of a response candidate. There is at most one rating per
        /// category.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("safetyRatings")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1SafetyRating> SafetyRatings { get; set; }

        /// <summary>
        /// Output only. Metadata returned when the model uses the `url_context` tool to get information from a
        /// user-provided URL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("urlContextMetadata")]
        public virtual GoogleCloudAiplatformV1beta1UrlContextMetadata UrlContextMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A citation for a piece of generatedcontent.</summary>
    public class GoogleCloudAiplatformV1beta1Citation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The end index of the citation in the content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endIndex")]
        public virtual System.Nullable<int> EndIndex { get; set; }

        /// <summary>Output only. The license of the source of the citation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("license")]
        public virtual string License { get; set; }

        /// <summary>Output only. The publication date of the source of the citation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicationDate")]
        public virtual Date PublicationDate { get; set; }

        /// <summary>Output only. The start index of the citation in the content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; }

        /// <summary>Output only. The title of the source of the citation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>Output only. The URI of the source of the citation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A collection of citations that apply to a piece of generated content.</summary>
    public class GoogleCloudAiplatformV1beta1CitationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. A list of citations for the content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("citations")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1Citation> Citations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Result of executing the [ExecutableCode]. Only generated when using the [CodeExecution] tool, and always follows
    /// a `part` containing the [ExecutableCode].
    /// </summary>
    public class GoogleCloudAiplatformV1beta1CodeExecutionResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Outcome of the code execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outcome")]
        public virtual string Outcome { get; set; }

        /// <summary>
        /// Optional. Contains stdout when code execution is successful, stderr or other description otherwise.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("output")]
        public virtual string Output { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The structured data content of a message. A Content message contains a `role` field, which indicates the
    /// producer of the content, and a `parts` field, which contains the multi-part data of the message.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1Content : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A list of Part objects that make up a single message. Parts of a message can have different MIME
        /// types. A Content message must have at least one Part.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parts")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1Part> Parts { get; set; }

        /// <summary>
        /// Optional. The producer of the content. Must be either 'user' or 'model'. If not set, the service will
        /// default to 'user'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for PredictionService.CountTokens.</summary>
    public class GoogleCloudAiplatformV1beta1CountTokensRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Input content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contents")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1Content> Contents { get; set; }

        /// <summary>Optional. Generation config that the model will use to generate the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generationConfig")]
        public virtual GoogleCloudAiplatformV1beta1GenerationConfig GenerationConfig { get; set; }

        /// <summary>
        /// Optional. The instances that are the input to token counting call. Schema is identical to the prediction
        /// schema of the underlying model.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instances")]
        public virtual System.Collections.Generic.IList<object> Instances { get; set; }

        /// <summary>
        /// Optional. The name of the publisher model requested to serve the prediction. Format:
        /// `projects/{project}/locations/{location}/publishers/*/models/*`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; }

        /// <summary>
        /// Optional. The user provided system instructions for the model. Note: only text should be used in parts and
        /// content in each part will be in a separate paragraph.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemInstruction")]
        public virtual GoogleCloudAiplatformV1beta1Content SystemInstruction { get; set; }

        /// <summary>
        /// Optional. A list of `Tools` the model may use to generate the next response. A `Tool` is a piece of code
        /// that enables the system to interact with external systems to perform an action, or set of actions, outside
        /// of knowledge and scope of the model.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tools")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1Tool> Tools { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for PredictionService.CountTokens.</summary>
    public class GoogleCloudAiplatformV1beta1CountTokensResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. List of modalities that were processed in the request input.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promptTokensDetails")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1ModalityTokenCount> PromptTokensDetails { get; set; }

        /// <summary>The total number of billable characters counted across all instances from the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalBillableCharacters")]
        public virtual System.Nullable<int> TotalBillableCharacters { get; set; }

        /// <summary>The total number of tokens counted across all instances from the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalTokens")]
        public virtual System.Nullable<int> TotalTokens { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes the options to customize dynamic retrieval.</summary>
    public class GoogleCloudAiplatformV1beta1DynamicRetrievalConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The threshold to be used in dynamic retrieval. If not set, a system default value is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dynamicThreshold")]
        public virtual System.Nullable<float> DynamicThreshold { get; set; }

        /// <summary>The mode of the predictor to be used in dynamic retrieval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual string Mode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Tool to search public web data, powered by Vertex AI Search and Sec4 compliance.</summary>
    public class GoogleCloudAiplatformV1beta1EnterpriseWebSearch : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Sites with confidence level chosen &amp;amp; above this value will be blocked from the search
        /// results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockingConfidence")]
        public virtual string BlockingConfidence { get; set; }

        /// <summary>
        /// Optional. List of domains to be excluded from the search results. The default limit is 2000 domains.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludeDomains")]
        public virtual System.Collections.Generic.IList<string> ExcludeDomains { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Code generated by the model that is meant to be executed, and the result returned to the model. Generated when
    /// using the [CodeExecution] tool, in which the code will be automatically executed, and a corresponding
    /// [CodeExecutionResult] will also be generated.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1ExecutableCode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The code to be executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>Required. Programming language of the `code`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("language")]
        public virtual string Language { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Retrieve from data source powered by external API for grounding. The external API is not owned by Google, but
    /// need to follow the pre-defined API spec.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1ExternalApi : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The authentication config to access the API. Deprecated. Please use auth_config instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiAuth")]
        public virtual GoogleCloudAiplatformV1beta1ApiAuth ApiAuth { get; set; }

        /// <summary>The API spec that the external API implements.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiSpec")]
        public virtual string ApiSpec { get; set; }

        /// <summary>The authentication config to access the API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authConfig")]
        public virtual GoogleCloudAiplatformV1beta1AuthConfig AuthConfig { get; set; }

        /// <summary>Parameters for the elastic search API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("elasticSearchParams")]
        public virtual GoogleCloudAiplatformV1beta1ExternalApiElasticSearchParams ElasticSearchParams { get; set; }

        /// <summary>
        /// The endpoint of the external API. The system will call the API at this endpoint to retrieve the data for
        /// grounding. Example: https://acme.com:443/search
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpoint")]
        public virtual string Endpoint { get; set; }

        /// <summary>Parameters for the simple search API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("simpleSearchParams")]
        public virtual GoogleCloudAiplatformV1beta1ExternalApiSimpleSearchParams SimpleSearchParams { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The search parameters to use for the ELASTIC_SEARCH spec.</summary>
    public class GoogleCloudAiplatformV1beta1ExternalApiElasticSearchParams : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ElasticSearch index to use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual string Index { get; set; }

        /// <summary>
        /// Optional. Number of hits (chunks) to request. When specified, it is passed to Elasticsearch as the
        /// `num_hits` param.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numHits")]
        public virtual System.Nullable<int> NumHits { get; set; }

        /// <summary>The ElasticSearch search template to use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchTemplate")]
        public virtual string SearchTemplate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The search parameters to use for SIMPLE_SEARCH spec.</summary>
    public class GoogleCloudAiplatformV1beta1ExternalApiSimpleSearchParams : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// URI-based data. A FileData message contains a URI pointing to data of a specific media type. It is used to
    /// represent images, audio, and video stored in Google Cloud Storage.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1FileData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The display name of the file. Used to provide a label or filename to distinguish files. This field
        /// is only returned in `PromptMessage` for prompt management. It is used in the Gemini calls only when server
        /// side tools (`code_execution`, `google_search`, and `url_context`) are enabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Required. The URI of the file in Google Cloud Storage.</summary>
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
    public class GoogleCloudAiplatformV1beta1FunctionCall : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The function parameters and values in JSON object format. See [FunctionDeclaration.parameters] for
        /// parameter details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IDictionary<string, object> Args { get; set; }

        /// <summary>
        /// Optional. The unique id of the function call. If populated, the client to execute the `function_call` and
        /// return the response with the matching `id`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Optional. The name of the function to call. Matches [FunctionDeclaration.name].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Function calling config.</summary>
    public class GoogleCloudAiplatformV1beta1FunctionCallingConfig : Google.Apis.Requests.IDirectResponseSchema
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
    /// specification](https://spec.openapis.org/oas/v3.0.3). Included in this declaration are the function name,
    /// description, parameters and response type. This FunctionDeclaration is a representation of a block of code that
    /// can be used as a `Tool` by the model and executed by the client.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1FunctionDeclaration : Google.Apis.Requests.IDirectResponseSchema
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
        public virtual GoogleCloudAiplatformV1beta1Schema Parameters { get; set; }

        /// <summary>
        /// Optional. Describes the parameters to the function in JSON Schema format. The schema must describe an object
        /// where the properties are the parameters to the function. For example:
        /// ```
        /// { "type": "object", "properties":
        /// { "name": { "type": "string" }, "age": { "type": "integer" } }, "additionalProperties": false, "required":
        /// ["name", "age"], "propertyOrdering": ["name", "age"] }
        /// ```
        /// This field is mutually exclusive with
        /// `parameters`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parametersJsonSchema")]
        public virtual object ParametersJsonSchema { get; set; }

        /// <summary>
        /// Optional. Describes the output from this function in JSON Schema format. Reflects the Open API 3.03 Response
        /// Object. The Schema defines the type used for the response value of the function.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual GoogleCloudAiplatformV1beta1Schema Response { get; set; }

        /// <summary>
        /// Optional. Describes the output from this function in JSON Schema format. The value specified by the schema
        /// is the response value of the function. This field is mutually exclusive with `response`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseJsonSchema")]
        public virtual object ResponseJsonSchema { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The result output from a [FunctionCall] that contains a string representing the [FunctionDeclaration.name] and a
    /// structured JSON object containing any output from the function is used as context to the model. This should
    /// contain the result of a [FunctionCall] made based on model prediction.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1FunctionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The id of the function call this response is for. Populated by the client to match the
        /// corresponding function call `id`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Required. The name of the function to call. Matches [FunctionDeclaration.name] and [FunctionCall.name].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. Ordered `Parts` that constitute a function response. Parts may have different IANA MIME types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parts")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1FunctionResponsePart> Parts { get; set; }

        /// <summary>
        /// Required. The function response in JSON object format. Use "output" key to specify function output and
        /// "error" key to specify error details (if any). If "output" and "error" keys are not specified, then whole
        /// "response" is treated as function output.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string, object> Response { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Raw media bytes for function response. Text should not be sent as raw bytes, use the 'text' field.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1FunctionResponseBlob : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Raw bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>
        /// Optional. Display name of the blob. Used to provide a label or filename to distinguish blobs. This field is
        /// only returned in PromptMessage for prompt management. It is currently used in the Gemini GenerateContent
        /// calls only when server side tools (code_execution, google_search, and url_context) are enabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Required. The IANA standard MIME type of the source data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>URI based data for function response.</summary>
    public class GoogleCloudAiplatformV1beta1FunctionResponseFileData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Display name of the file data. Used to provide a label or filename to distinguish file datas. This
        /// field is only returned in PromptMessage for prompt management. It is currently used in the Gemini
        /// GenerateContent calls only when server side tools (code_execution, google_search, and url_context) are
        /// enabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

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
    /// A datatype containing media that is part of a `FunctionResponse` message. A `FunctionResponsePart` consists of
    /// data which has an associated datatype. A `FunctionResponsePart` can only contain one of the accepted types in
    /// `FunctionResponsePart.data`. A `FunctionResponsePart` must have a fixed IANA MIME type identifying the type and
    /// subtype of the media if the `inline_data` field is filled with raw bytes.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1FunctionResponsePart : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>URI based data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileData")]
        public virtual GoogleCloudAiplatformV1beta1FunctionResponseFileData FileData { get; set; }

        /// <summary>Inline media bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inlineData")]
        public virtual GoogleCloudAiplatformV1beta1FunctionResponseBlob InlineData { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for [PredictionService.GenerateContent].</summary>
    public class GoogleCloudAiplatformV1beta1GenerateContentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The name of the cached content used as context to serve the prediction. Note: only used in
        /// explicit caching, where users can have control over caching (e.g. what content to cache) and enjoy
        /// guaranteed cost savings. Format: `projects/{project}/locations/{location}/cachedContents/{cachedContent}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cachedContent")]
        public virtual string CachedContent { get; set; }

        /// <summary>
        /// Required. The content of the current conversation with the model. For single-turn queries, this is a single
        /// instance. For multi-turn queries, this is a repeated field that contains conversation history + latest
        /// request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contents")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1Content> Contents { get; set; }

        /// <summary>Optional. Generation config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generationConfig")]
        public virtual GoogleCloudAiplatformV1beta1GenerationConfig GenerationConfig { get; set; }

        /// <summary>
        /// Optional. The labels with user-defined metadata for the request. It is used for billing and reporting only.
        /// Label keys and values can be no longer than 63 characters (Unicode codepoints) and can only contain
        /// lowercase letters, numeric characters, underscores, and dashes. International characters are allowed. Label
        /// values are optional. Label keys must start with a letter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Optional. Settings for prompt and response sanitization using the Model Armor service. If supplied,
        /// safety_settings must not be supplied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelArmorConfig")]
        public virtual GoogleCloudAiplatformV1beta1ModelArmorConfig ModelArmorConfig { get; set; }

        /// <summary>
        /// Optional. Per request settings for blocking unsafe content. Enforced on GenerateContentResponse.candidates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("safetySettings")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1SafetySetting> SafetySettings { get; set; }

        /// <summary>
        /// Optional. The user provided system instructions for the model. Note: only text should be used in parts and
        /// content in each part will be in a separate paragraph.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemInstruction")]
        public virtual GoogleCloudAiplatformV1beta1Content SystemInstruction { get; set; }

        /// <summary>Optional. Tool config. This config is shared for all tools provided in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolConfig")]
        public virtual GoogleCloudAiplatformV1beta1ToolConfig ToolConfig { get; set; }

        /// <summary>
        /// Optional. A list of `Tools` the model may use to generate the next response. A `Tool` is a piece of code
        /// that enables the system to interact with external systems to perform an action, or set of actions, outside
        /// of knowledge and scope of the model.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tools")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1Tool> Tools { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for [PredictionService.GenerateContent].</summary>
    public class GoogleCloudAiplatformV1beta1GenerateContentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Generated candidates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("candidates")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1Candidate> Candidates { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Timestamp when the request is made to the server.</summary>
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

        /// <summary>Output only. The model version used to generate the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelVersion")]
        public virtual string ModelVersion { get; set; }

        /// <summary>
        /// Output only. Content filter results for a prompt sent in the request. Note: Sent only in the first stream
        /// chunk. Only happens when no candidates were generated due to content violations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promptFeedback")]
        public virtual GoogleCloudAiplatformV1beta1GenerateContentResponsePromptFeedback PromptFeedback { get; set; }

        /// <summary>
        /// Output only. response_id is used to identify each response. It is the encoding of the event_id.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseId")]
        public virtual string ResponseId { get; set; }

        /// <summary>Usage metadata about the response(s).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usageMetadata")]
        public virtual GoogleCloudAiplatformV1beta1GenerateContentResponseUsageMetadata UsageMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Content filter results for a prompt sent in the request. Note: This is sent only in the first stream chunk and
    /// only if no candidates were generated due to content violations.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1GenerateContentResponsePromptFeedback : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The reason why the prompt was blocked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockReason")]
        public virtual string BlockReason { get; set; }

        /// <summary>Output only. A readable message that explains the reason why the prompt was blocked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockReasonMessage")]
        public virtual string BlockReasonMessage { get; set; }

        /// <summary>Output only. A list of safety ratings for the prompt. There is one rating per category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("safetyRatings")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1SafetyRating> SafetyRatings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Usage metadata about the content generation request and response. This message provides a detailed breakdown of
    /// token usage and other relevant metrics.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1GenerateContentResponseUsageMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. A detailed breakdown of the token count for each modality in the cached content.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cacheTokensDetails")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1ModalityTokenCount> CacheTokensDetails { get; set; }

        /// <summary>Output only. The number of tokens in the cached content that was used for this request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cachedContentTokenCount")]
        public virtual System.Nullable<int> CachedContentTokenCount { get; set; }

        /// <summary>The total number of tokens in the generated candidates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("candidatesTokenCount")]
        public virtual System.Nullable<int> CandidatesTokenCount { get; set; }

        /// <summary>
        /// Output only. A detailed breakdown of the token count for each modality in the generated candidates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("candidatesTokensDetails")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1ModalityTokenCount> CandidatesTokensDetails { get; set; }

        /// <summary>
        /// The total number of tokens in the prompt. This includes any text, images, or other media provided in the
        /// request. When `cached_content` is set, this also includes the number of tokens in the cached content.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promptTokenCount")]
        public virtual System.Nullable<int> PromptTokenCount { get; set; }

        /// <summary>Output only. A detailed breakdown of the token count for each modality in the prompt.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promptTokensDetails")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1ModalityTokenCount> PromptTokensDetails { get; set; }

        /// <summary>
        /// Output only. The number of tokens that were part of the model's generated "thoughts" output, if applicable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thoughtsTokenCount")]
        public virtual System.Nullable<int> ThoughtsTokenCount { get; set; }

        /// <summary>
        /// Output only. The number of tokens in the results from tool executions, which are provided back to the model
        /// as input, if applicable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolUsePromptTokenCount")]
        public virtual System.Nullable<int> ToolUsePromptTokenCount { get; set; }

        /// <summary>
        /// Output only. A detailed breakdown by modality of the token counts from the results of tool executions, which
        /// are provided back to the model as input.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolUsePromptTokensDetails")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1ModalityTokenCount> ToolUsePromptTokensDetails { get; set; }

        /// <summary>
        /// The total number of tokens for the entire request. This is the sum of `prompt_token_count`,
        /// `candidates_token_count`, `tool_use_prompt_token_count`, and `thoughts_token_count`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalTokenCount")]
        public virtual System.Nullable<int> TotalTokenCount { get; set; }

        /// <summary>Output only. The traffic type for this request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trafficType")]
        public virtual string TrafficType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration for content generation. This message contains all the parameters that control how the model
    /// generates content. It allows you to influence the randomness, length, and structure of the output.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1GenerationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If enabled, audio timestamps will be included in the request to the model. This can be useful for
        /// synchronizing audio with other modalities in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audioTimestamp")]
        public virtual System.Nullable<bool> AudioTimestamp { get; set; }

        /// <summary>
        /// Optional. The number of candidate responses to generate. A higher `candidate_count` can provide more options
        /// to choose from, but it also consumes more resources. This can be useful for generating a variety of
        /// responses and selecting the best one.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("candidateCount")]
        public virtual System.Nullable<int> CandidateCount { get; set; }

        /// <summary>
        /// Optional. If enabled, the model will detect emotions and adapt its responses accordingly. For example, if
        /// the model detects that the user is frustrated, it may provide a more empathetic response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableAffectiveDialog")]
        public virtual System.Nullable<bool> EnableAffectiveDialog { get; set; }

        /// <summary>
        /// Optional. Penalizes tokens based on their frequency in the generated text. A positive value helps to reduce
        /// the repetition of words and phrases. Valid values can range from [-2.0, 2.0].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frequencyPenalty")]
        public virtual System.Nullable<float> FrequencyPenalty { get; set; }

        /// <summary>Optional. Config for image generation features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageConfig")]
        public virtual GoogleCloudAiplatformV1beta1ImageConfig ImageConfig { get; set; }

        /// <summary>
        /// Optional. The number of top log probabilities to return for each token. This can be used to see which other
        /// tokens were considered likely candidates for a given position. A higher value will return more options, but
        /// it will also increase the size of the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logprobs")]
        public virtual System.Nullable<int> Logprobs { get; set; }

        /// <summary>
        /// Optional. The maximum number of tokens to generate in the response. A token is approximately four
        /// characters. The default value varies by model. This parameter can be used to control the length of the
        /// generated text and prevent overly long responses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxOutputTokens")]
        public virtual System.Nullable<int> MaxOutputTokens { get; set; }

        /// <summary>
        /// Optional. The token resolution at which input media content is sampled. This is used to control the
        /// trade-off between the quality of the response and the number of tokens used to represent the media. A higher
        /// resolution allows the model to perceive more detail, which can lead to a more nuanced response, but it will
        /// also use more tokens. This does not affect the image dimensions sent to the model.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mediaResolution")]
        public virtual string MediaResolution { get; set; }

        /// <summary>Optional. Config for model selection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelConfig")]
        public virtual GoogleCloudAiplatformV1beta1GenerationConfigModelConfig ModelConfig { get; set; }

        /// <summary>
        /// Optional. Penalizes tokens that have already appeared in the generated text. A positive value encourages the
        /// model to generate more diverse and less repetitive text. Valid values can range from [-2.0, 2.0].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("presencePenalty")]
        public virtual System.Nullable<float> PresencePenalty { get; set; }

        /// <summary>
        /// Optional. When this field is set, response_schema must be omitted and response_mime_type must be set to
        /// `application/json`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseJsonSchema")]
        public virtual object ResponseJsonSchema { get; set; }

        /// <summary>
        /// Optional. If set to true, the log probabilities of the output tokens are returned. Log probabilities are the
        /// logarithm of the probability of a token appearing in the output. A higher log probability means the token is
        /// more likely to be generated. This can be useful for analyzing the model's confidence in its own output and
        /// for debugging.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseLogprobs")]
        public virtual System.Nullable<bool> ResponseLogprobs { get; set; }

        /// <summary>
        /// Optional. The IANA standard MIME type of the response. The model will generate output that conforms to this
        /// MIME type. Supported values include 'text/plain' (default) and 'application/json'. The model needs to be
        /// prompted to output the appropriate response type, otherwise the behavior is undefined. This is a preview
        /// feature.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseMimeType")]
        public virtual string ResponseMimeType { get; set; }

        /// <summary>
        /// Optional. The modalities of the response. The model will generate a response that includes all the specified
        /// modalities. For example, if this is set to `[TEXT, IMAGE]`, the response will include both text and an
        /// image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseModalities")]
        public virtual System.Collections.Generic.IList<string> ResponseModalities { get; set; }

        /// <summary>
        /// Optional. Lets you to specify a schema for the model's response, ensuring that the output conforms to a
        /// particular structure. This is useful for generating structured data such as JSON. The schema is a subset of
        /// the [OpenAPI 3.0 schema object](https://spec.openapis.org/oas/v3.0.3#schema) object. When this field is set,
        /// you must also set the `response_mime_type` to `application/json`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseSchema")]
        public virtual GoogleCloudAiplatformV1beta1Schema ResponseSchema { get; set; }

        /// <summary>Optional. Routing configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routingConfig")]
        public virtual GoogleCloudAiplatformV1beta1GenerationConfigRoutingConfig RoutingConfig { get; set; }

        /// <summary>
        /// Optional. A seed for the random number generator. By setting a seed, you can make the model's output mostly
        /// deterministic. For a given prompt and parameters (like temperature, top_p, etc.), the model will produce the
        /// same response every time. However, it's not a guaranteed absolute deterministic behavior. This is different
        /// from parameters like `temperature`, which control the *level* of randomness. `seed` ensures that the
        /// "random" choices the model makes are the same on every run, making it essential for testing and ensuring
        /// reproducible results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seed")]
        public virtual System.Nullable<int> Seed { get; set; }

        /// <summary>Optional. The speech generation config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("speechConfig")]
        public virtual GoogleCloudAiplatformV1beta1SpeechConfig SpeechConfig { get; set; }

        /// <summary>
        /// Optional. A list of character sequences that will stop the model from generating further tokens. If a stop
        /// sequence is generated, the output will end at that point. This is useful for controlling the length and
        /// structure of the output. For example, you can use ["\n", "###"] to stop generation at a new line or a
        /// specific marker.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stopSequences")]
        public virtual System.Collections.Generic.IList<string> StopSequences { get; set; }

        /// <summary>
        /// Optional. Controls the randomness of the output. A higher temperature results in more creative and diverse
        /// responses, while a lower temperature makes the output more predictable and focused. The valid range is (0.0,
        /// 2.0].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("temperature")]
        public virtual System.Nullable<float> Temperature { get; set; }

        /// <summary>
        /// Optional. Configuration for thinking features. An error will be returned if this field is set for models
        /// that don't support thinking.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thinkingConfig")]
        public virtual GoogleCloudAiplatformV1beta1GenerationConfigThinkingConfig ThinkingConfig { get; set; }

        /// <summary>
        /// Optional. Specifies the top-k sampling threshold. The model considers only the top k most probable tokens
        /// for the next token. This can be useful for generating more coherent and less random text. For example, a
        /// `top_k` of 40 means the model will choose the next word from the 40 most likely words.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topK")]
        public virtual System.Nullable<float> TopK { get; set; }

        /// <summary>
        /// Optional. Specifies the nucleus sampling threshold. The model considers only the smallest set of tokens
        /// whose cumulative probability is at least `top_p`. This helps generate more diverse and less repetitive
        /// responses. For example, a `top_p` of 0.9 means the model considers tokens until the cumulative probability
        /// of the tokens to select from reaches 0.9. It's recommended to adjust either temperature or `top_p`, but not
        /// both.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topP")]
        public virtual System.Nullable<float> TopP { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Config for model selection.</summary>
    public class GoogleCloudAiplatformV1beta1GenerationConfigModelConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Feature selection preference.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("featureSelectionPreference")]
        public virtual string FeatureSelectionPreference { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The configuration for routing the request to a specific model. This can be used to control which model is used
    /// for the generation, either automatically or by specifying a model name.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1GenerationConfigRoutingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>In this mode, the model is selected automatically based on the content of the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoMode")]
        public virtual GoogleCloudAiplatformV1beta1GenerationConfigRoutingConfigAutoRoutingMode AutoMode { get; set; }

        /// <summary>In this mode, the model is specified manually.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manualMode")]
        public virtual GoogleCloudAiplatformV1beta1GenerationConfigRoutingConfigManualRoutingMode ManualMode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The configuration for automated routing. When automated routing is specified, the routing will be determined by
    /// the pretrained routing model and customer provided model routing preference.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1GenerationConfigRoutingConfigAutoRoutingMode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The model routing preference.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelRoutingPreference")]
        public virtual string ModelRoutingPreference { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The configuration for manual routing. When manual routing is specified, the model will be selected based on the
    /// model name provided.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1GenerationConfigRoutingConfigManualRoutingMode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the model to use. Only public LLM models are accepted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelName")]
        public virtual string ModelName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration for the model's thinking features. "Thinking" is a process where the model breaks down a complex
    /// task into smaller, manageable steps. This allows the model to reason about the task, plan its approach, and
    /// execute the plan to generate a high-quality response.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1GenerationConfigThinkingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If true, the model will include its thoughts in the response. "Thoughts" are the intermediate
        /// steps the model takes to arrive at the final response. They can provide insights into the model's reasoning
        /// process and help with debugging. If this is true, thoughts are returned only when available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeThoughts")]
        public virtual System.Nullable<bool> IncludeThoughts { get; set; }

        /// <summary>
        /// Optional. The token budget for the model's thinking process. The model will make a best effort to stay
        /// within this budget. This can be used to control the trade-off between response quality and latency.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thinkingBudget")]
        public virtual System.Nullable<int> ThinkingBudget { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Tool to retrieve public maps data for grounding, powered by Google.</summary>
    public class GoogleCloudAiplatformV1beta1GoogleMaps : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. If true, include the widget context token in the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableWidget")]
        public virtual System.Nullable<bool> EnableWidget { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Tool to retrieve public web data for grounding, powered by Google.</summary>
    public class GoogleCloudAiplatformV1beta1GoogleSearchRetrieval : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies the dynamic retrieval configuration for the given source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dynamicRetrievalConfig")]
        public virtual GoogleCloudAiplatformV1beta1DynamicRetrievalConfig DynamicRetrievalConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A piece of evidence that supports a claim made by the model. This is used to show a citation for a claim made by
    /// the model. When grounding is enabled, the model returns a `GroundingChunk` that contains a reference to the
    /// source of the information.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1GroundingChunk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A grounding chunk from Google Maps. See the `Maps` message for details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maps")]
        public virtual GoogleCloudAiplatformV1beta1GroundingChunkMaps Maps { get; set; }

        /// <summary>
        /// A grounding chunk from a data source retrieved by a retrieval tool, such as Vertex AI Search. See the
        /// `RetrievedContext` message for details
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retrievedContext")]
        public virtual GoogleCloudAiplatformV1beta1GroundingChunkRetrievedContext RetrievedContext { get; set; }

        /// <summary>
        /// A grounding chunk from a web page, typically from Google Search. See the `Web` message for details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("web")]
        public virtual GoogleCloudAiplatformV1beta1GroundingChunkWeb Web { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A `Maps` chunk is a piece of evidence that comes from Google Maps. It contains information about a place, such
    /// as its name, address, and reviews. This is used to provide the user with rich, location-based information.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1GroundingChunkMaps : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The sources that were used to generate the place answer. This includes review snippets and photos that were
        /// used to generate the answer, as well as URIs to flag content.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placeAnswerSources")]
        public virtual GoogleCloudAiplatformV1beta1GroundingChunkMapsPlaceAnswerSources PlaceAnswerSources { get; set; }

        /// <summary>
        /// This Place's resource name, in `places/{place_id}` format. This can be used to look up the place in the
        /// Google Maps API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placeId")]
        public virtual string PlaceId { get; set; }

        /// <summary>The text of the place answer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The title of the place.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The URI of the place.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The sources that were used to generate the place answer. This includes review snippets and photos that were used
    /// to generate the answer, as well as URIs to flag content.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1GroundingChunkMapsPlaceAnswerSources : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Snippets of reviews that were used to generate the answer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reviewSnippets")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1GroundingChunkMapsPlaceAnswerSourcesReviewSnippet> ReviewSnippets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A review snippet that is used to generate the answer.</summary>
    public class GoogleCloudAiplatformV1beta1GroundingChunkMapsPlaceAnswerSourcesReviewSnippet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A link to show the review on Google Maps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleMapsUri")]
        public virtual string GoogleMapsUri { get; set; }

        /// <summary>The ID of the review that is being referenced.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reviewId")]
        public virtual string ReviewId { get; set; }

        /// <summary>The title of the review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Context retrieved from a data source to ground the model's response. This is used when a retrieval tool fetches
    /// information from a user-provided corpus or a public dataset.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1GroundingChunkRetrievedContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The full resource name of the referenced Vertex AI Search document. This is used to identify
        /// the specific document that was retrieved. The format is
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}/documents/{document}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentName")]
        public virtual string DocumentName { get; set; }

        /// <summary>
        /// Additional context for a Retrieval-Augmented Generation (RAG) retrieval result. This is populated only when
        /// the RAG retrieval tool is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ragChunk")]
        public virtual GoogleCloudAiplatformV1beta1RagChunk RagChunk { get; set; }

        /// <summary>The content of the retrieved data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The title of the retrieved data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The URI of the retrieved data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A `Web` chunk is a piece of evidence that comes from a web page. It contains the URI of the web page, the title
    /// of the page, and the domain of the page. This is used to provide the user with a link to the source of the
    /// information.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1GroundingChunkWeb : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The domain of the web page that contains the evidence. This can be used to filter out low-quality sources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>The title of the web page that contains the evidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The URI of the web page that contains the evidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information about the sources that support the content of a response. When grounding is enabled, the model
    /// returns citations for claims in the response. This object contains the retrieved sources.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1GroundingMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Output only. A token that can be used to render a Google Maps widget with the contextual data.
        /// This field is populated only when the grounding source is Google Maps.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleMapsWidgetContextToken")]
        public virtual string GoogleMapsWidgetContextToken { get; set; }

        /// <summary>
        /// A list of supporting references retrieved from the grounding source. This field is populated when the
        /// grounding source is Google Search, Vertex AI Search, or Google Maps.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groundingChunks")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1GroundingChunk> GroundingChunks { get; set; }

        /// <summary>
        /// Optional. A list of grounding supports that connect the generated content to the grounding chunks. This
        /// field is populated when the grounding source is Google Search or Vertex AI Search.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groundingSupports")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1GroundingSupport> GroundingSupports { get; set; }

        /// <summary>Optional. Output only. Metadata related to the retrieval grounding source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retrievalMetadata")]
        public virtual GoogleCloudAiplatformV1beta1RetrievalMetadata RetrievalMetadata { get; set; }

        /// <summary>
        /// Optional. The queries that were executed by the retrieval tools. This field is populated only when the
        /// grounding source is a retrieval tool, such as Vertex AI Search.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retrievalQueries")]
        public virtual System.Collections.Generic.IList<string> RetrievalQueries { get; set; }

        /// <summary>
        /// Optional. A web search entry point that can be used to display search results. This field is populated only
        /// when the grounding source is Google Search.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchEntryPoint")]
        public virtual GoogleCloudAiplatformV1beta1SearchEntryPoint SearchEntryPoint { get; set; }

        /// <summary>
        /// Optional. Output only. A list of URIs that can be used to flag a place or review for inappropriate content.
        /// This field is populated only when the grounding source is Google Maps.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceFlaggingUris")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1GroundingMetadataSourceFlaggingUri> SourceFlaggingUris { get; set; }

        /// <summary>
        /// Optional. The web search queries that were used to generate the content. This field is populated only when
        /// the grounding source is Google Search.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webSearchQueries")]
        public virtual System.Collections.Generic.IList<string> WebSearchQueries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A URI that can be used to flag a place or review for inappropriate content. This is populated only when the
    /// grounding source is Google Maps.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1GroundingMetadataSourceFlaggingUri : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The URI that can be used to flag the content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flagContentUri")]
        public virtual string FlagContentUri { get; set; }

        /// <summary>The ID of the place or review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceId")]
        public virtual string SourceId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A collection of supporting references for a segment of the model's response.</summary>
    public class GoogleCloudAiplatformV1beta1GroundingSupport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The confidence scores for the support references. This list is parallel to the `grounding_chunk_indices`
        /// list. A score is a value between 0.0 and 1.0, with a higher score indicating a higher confidence that the
        /// reference supports the claim. For Gemini 2.0 and before, this list has the same size as
        /// `grounding_chunk_indices`. For Gemini 2.5 and later, this list is empty and should be ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidenceScores")]
        public virtual System.Collections.Generic.IList<System.Nullable<float>> ConfidenceScores { get; set; }

        /// <summary>
        /// A list of indices into the `grounding_chunks` field of the `GroundingMetadata` message. These indices
        /// specify which grounding chunks support the claim made in the content segment. For example, if this field has
        /// the values `[1, 3]`, it means that `grounding_chunks[1]` and `grounding_chunks[3]` are the sources for the
        /// claim in the content segment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groundingChunkIndices")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> GroundingChunkIndices { get; set; }

        /// <summary>The content segment that this support message applies to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual GoogleCloudAiplatformV1beta1Segment Segment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration for image generation. This message allows you to control various aspects of image generation, such
    /// as the output format, aspect ratio, and whether the model can generate images of people.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1ImageConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The desired aspect ratio for the generated images. The following aspect ratios are supported:
        /// "1:1" "2:3", "3:2" "3:4", "4:3" "4:5", "5:4" "9:16", "16:9" "21:9"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aspectRatio")]
        public virtual string AspectRatio { get; set; }

        /// <summary>Optional. The image output format for generated images.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageOutputOptions")]
        public virtual GoogleCloudAiplatformV1beta1ImageConfigImageOutputOptions ImageOutputOptions { get; set; }

        /// <summary>Optional. Controls whether the model can generate people.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("personGeneration")]
        public virtual string PersonGeneration { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The image output format for generated images.</summary>
    public class GoogleCloudAiplatformV1beta1ImageConfigImageOutputOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The compression quality of the output image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compressionQuality")]
        public virtual System.Nullable<int> CompressionQuality { get; set; }

        /// <summary>Optional. The image format that the output should be saved as.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The log probabilities of the tokens generated by the model. This is useful for understanding the model's
    /// confidence in its predictions and for debugging. For example, you can use log probabilities to identify when the
    /// model is making a less confident prediction or to explore alternative responses that the model considered. A low
    /// log probability can also indicate that the model is "hallucinating" or generating factually incorrect
    /// information.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1LogprobsResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of the chosen candidate tokens at each decoding step. The length of this list is equal to the total
        /// number of decoding steps. Note that the chosen candidate might not be in `top_candidates`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chosenCandidates")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1LogprobsResultCandidate> ChosenCandidates { get; set; }

        /// <summary>
        /// A list of the top candidate tokens at each decoding step. The length of this list is equal to the total
        /// number of decoding steps.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topCandidates")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1LogprobsResultTopCandidates> TopCandidates { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single token and its associated log probability.</summary>
    public class GoogleCloudAiplatformV1beta1LogprobsResultCandidate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The log probability of this token. A higher value indicates that the model was more confident in this token.
        /// The log probability can be used to assess the relative likelihood of different tokens and to identify when
        /// the model is uncertain.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logProbability")]
        public virtual System.Nullable<float> LogProbability { get; set; }

        /// <summary>The token's string representation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>
        /// The token's numerical ID. While the `token` field provides the string representation of the token, the
        /// `token_id` is the numerical representation that the model uses internally. This can be useful for developers
        /// who want to build custom logic based on the model's vocabulary.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokenId")]
        public virtual System.Nullable<int> TokenId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A list of the top candidate tokens and their log probabilities at each decoding step. This can be used to see
    /// what other tokens the model considered.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1LogprobsResultTopCandidates : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of candidate tokens, sorted by log probability in descending order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("candidates")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1LogprobsResultCandidate> Candidates { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a breakdown of token usage by modality. This message is used in CountTokensResponse and
    /// GenerateContentResponse.UsageMetadata to provide a detailed view of how many tokens are used by each modality
    /// (e.g., text, image, video) in a request. This is particularly useful for multimodal models, allowing you to
    /// track and manage token consumption for billing and quota purposes.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1ModalityTokenCount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The modality that this token count applies to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modality")]
        public virtual string Modality { get; set; }

        /// <summary>The number of tokens counted for this modality.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokenCount")]
        public virtual System.Nullable<int> TokenCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration for Model Armor. Model Armor is a Google Cloud service that provides safety and security filtering
    /// for prompts and responses. It helps protect your AI applications from risks such as harmful content, sensitive
    /// data leakage, and prompt injection attacks.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1ModelArmorConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The resource name of the Model Armor template to use for prompt screening. A Model Armor template
        /// is a set of customized filters and thresholds that define how Model Armor screens content. If specified,
        /// Model Armor will use this template to check the user's prompt for safety and security risks before it is
        /// sent to the model. The name must be in the format
        /// `projects/{project}/locations/{location}/templates/{template}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promptTemplateName")]
        public virtual string PromptTemplateName { get; set; }

        /// <summary>
        /// Optional. The resource name of the Model Armor template to use for response screening. A Model Armor
        /// template is a set of customized filters and thresholds that define how Model Armor screens content. If
        /// specified, Model Armor will use this template to check the model's response for safety and security risks
        /// before it is returned to the user. The name must be in the format
        /// `projects/{project}/locations/{location}/templates/{template}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseTemplateName")]
        public virtual string ResponseTemplateName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for a multi-speaker text-to-speech request.</summary>
    public class GoogleCloudAiplatformV1beta1MultiSpeakerVoiceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A list of configurations for the voices of the speakers. Exactly two speaker voice configurations
        /// must be provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("speakerVoiceConfigs")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1SpeakerVoiceConfig> SpeakerVoiceConfigs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A datatype containing media that is part of a multi-part Content message. A `Part` consists of data which has an
    /// associated datatype. A `Part` can only contain one of the accepted types in `Part.data`. For media types that
    /// are not text, `Part` must have a fixed IANA MIME type identifying the type and subtype of the media if
    /// `inline_data` or `file_data` field is filled with raw bytes.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1Part : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The result of executing the ExecutableCode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("codeExecutionResult")]
        public virtual GoogleCloudAiplatformV1beta1CodeExecutionResult CodeExecutionResult { get; set; }

        /// <summary>Optional. Code generated by the model that is intended to be executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executableCode")]
        public virtual GoogleCloudAiplatformV1beta1ExecutableCode ExecutableCode { get; set; }

        /// <summary>
        /// Optional. The URI-based data of the part. This can be used to include files from Google Cloud Storage.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileData")]
        public virtual GoogleCloudAiplatformV1beta1FileData FileData { get; set; }

        /// <summary>
        /// Optional. A predicted function call returned from the model. This contains the name of the function to call
        /// and the arguments to pass to the function.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("functionCall")]
        public virtual GoogleCloudAiplatformV1beta1FunctionCall FunctionCall { get; set; }

        /// <summary>
        /// Optional. The result of a function call. This is used to provide the model with the result of a function
        /// call that it predicted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("functionResponse")]
        public virtual GoogleCloudAiplatformV1beta1FunctionResponse FunctionResponse { get; set; }

        /// <summary>
        /// Optional. The inline data content of the part. This can be used to include images, audio, or video in a
        /// request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inlineData")]
        public virtual GoogleCloudAiplatformV1beta1Blob InlineData { get; set; }

        /// <summary>Optional. The text content of the part.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>
        /// Optional. Indicates whether the `part` represents the model's thought process or reasoning.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thought")]
        public virtual System.Nullable<bool> Thought { get; set; }

        /// <summary>Optional. An opaque signature for the thought so it can be reused in subsequent requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thoughtSignature")]
        public virtual string ThoughtSignature { get; set; }

        /// <summary>
        /// Optional. Video metadata. The metadata should only be specified while the video data is presented in
        /// inline_data or file_data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoMetadata")]
        public virtual GoogleCloudAiplatformV1beta1VideoMetadata VideoMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for a prebuilt voice.</summary>
    public class GoogleCloudAiplatformV1beta1PrebuiltVoiceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the prebuilt voice to use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("voiceName")]
        public virtual string VoiceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A RagChunk includes the content of a chunk of a RagFile, and associated metadata.</summary>
    public class GoogleCloudAiplatformV1beta1RagChunk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If populated, represents where the chunk starts and ends in the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSpan")]
        public virtual GoogleCloudAiplatformV1beta1RagChunkPageSpan PageSpan { get; set; }

        /// <summary>The content of the chunk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents where the chunk starts and ends in the document.</summary>
    public class GoogleCloudAiplatformV1beta1RagChunkPageSpan : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Page where chunk starts in the document. Inclusive. 1-indexed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstPage")]
        public virtual System.Nullable<int> FirstPage { get; set; }

        /// <summary>Page where chunk ends in the document. Inclusive. 1-indexed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastPage")]
        public virtual System.Nullable<int> LastPage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the context retrieval config.</summary>
    public class GoogleCloudAiplatformV1beta1RagRetrievalConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Config for filters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual GoogleCloudAiplatformV1beta1RagRetrievalConfigFilter Filter { get; set; }

        /// <summary>Optional. Config for Hybrid Search.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hybridSearch")]
        public virtual GoogleCloudAiplatformV1beta1RagRetrievalConfigHybridSearch HybridSearch { get; set; }

        /// <summary>Optional. Config for ranking and reranking.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ranking")]
        public virtual GoogleCloudAiplatformV1beta1RagRetrievalConfigRanking Ranking { get; set; }

        /// <summary>Optional. The number of contexts to retrieve.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topK")]
        public virtual System.Nullable<int> TopK { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Config for filters.</summary>
    public class GoogleCloudAiplatformV1beta1RagRetrievalConfigFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. String for metadata filtering.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadataFilter")]
        public virtual string MetadataFilter { get; set; }

        /// <summary>Optional. Only returns contexts with vector distance smaller than the threshold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vectorDistanceThreshold")]
        public virtual System.Nullable<double> VectorDistanceThreshold { get; set; }

        /// <summary>Optional. Only returns contexts with vector similarity larger than the threshold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vectorSimilarityThreshold")]
        public virtual System.Nullable<double> VectorSimilarityThreshold { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Config for Hybrid Search.</summary>
    public class GoogleCloudAiplatformV1beta1RagRetrievalConfigHybridSearch : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Alpha value controls the weight between dense and sparse vector search results. The range is [0,
        /// 1], while 0 means sparse vector search only and 1 means dense vector search only. The default value is 0.5
        /// which balances sparse and dense vector search equally.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alpha")]
        public virtual System.Nullable<float> Alpha { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Config for ranking and reranking.</summary>
    public class GoogleCloudAiplatformV1beta1RagRetrievalConfigRanking : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Config for LlmRanker.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("llmRanker")]
        public virtual GoogleCloudAiplatformV1beta1RagRetrievalConfigRankingLlmRanker LlmRanker { get; set; }

        /// <summary>Optional. Config for Rank Service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rankService")]
        public virtual GoogleCloudAiplatformV1beta1RagRetrievalConfigRankingRankService RankService { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Config for LlmRanker.</summary>
    public class GoogleCloudAiplatformV1beta1RagRetrievalConfigRankingLlmRanker : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The model name used for ranking. See [Supported
        /// models](https://cloud.google.com/vertex-ai/generative-ai/docs/model-reference/inference#supported-models).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelName")]
        public virtual string ModelName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Config for Rank Service.</summary>
    public class GoogleCloudAiplatformV1beta1RagRetrievalConfigRankingRankService : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The model name of the rank service. Format: `semantic-ranker-512@latest`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelName")]
        public virtual string ModelName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines a retrieval tool that model can call to access external knowledge.</summary>
    public class GoogleCloudAiplatformV1beta1Retrieval : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Deprecated. This option is no longer supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableAttribution")]
        public virtual System.Nullable<bool> DisableAttribution { get; set; }

        /// <summary>Use data source powered by external API for grounding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalApi")]
        public virtual GoogleCloudAiplatformV1beta1ExternalApi ExternalApi { get; set; }

        /// <summary>Set to use data source powered by Vertex AI Search.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vertexAiSearch")]
        public virtual GoogleCloudAiplatformV1beta1VertexAISearch VertexAiSearch { get; set; }

        /// <summary>
        /// Set to use data source powered by Vertex RAG store. User data is uploaded via the VertexRagDataService.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vertexRagStore")]
        public virtual GoogleCloudAiplatformV1beta1VertexRagStore VertexRagStore { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Retrieval config.</summary>
    public class GoogleCloudAiplatformV1beta1RetrievalConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The language code of the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>The location of the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latLng")]
        public virtual LatLng LatLng { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata related to the retrieval grounding source. This is part of the `GroundingMetadata` returned when
    /// grounding is enabled.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1RetrievalMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A score indicating how likely it is that a Google Search query could help answer the prompt. The
        /// score is in the range of `[0, 1]`. A score of 1 means the model is confident that a search will be helpful,
        /// and 0 means it is not. This score is populated only when Google Search grounding and dynamic retrieval are
        /// enabled. The score is used to determine whether to trigger a search.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleSearchDynamicRetrievalScore")]
        public virtual System.Nullable<float> GoogleSearchDynamicRetrievalScore { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A safety rating for a piece of content. The safety rating contains the harm category and the harm probability
    /// level.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1SafetyRating : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Indicates whether the content was blocked because of this rating.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blocked")]
        public virtual System.Nullable<bool> Blocked { get; set; }

        /// <summary>Output only. The harm category of this rating.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>
        /// Output only. The overwritten threshold for the safety category of Gemini 2.0 image out. If minors are
        /// detected in the output image, the threshold of each safety category will be overwritten if user sets a lower
        /// threshold.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overwrittenThreshold")]
        public virtual string OverwrittenThreshold { get; set; }

        /// <summary>Output only. The probability of harm for this category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("probability")]
        public virtual string Probability { get; set; }

        /// <summary>Output only. The probability score of harm for this category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("probabilityScore")]
        public virtual System.Nullable<float> ProbabilityScore { get; set; }

        /// <summary>Output only. The severity of harm for this category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>Output only. The severity score of harm for this category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severityScore")]
        public virtual System.Nullable<float> SeverityScore { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A safety setting that affects the safety-blocking behavior. A SafetySetting consists of a harm category and a
    /// threshold for that category.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1SafetySetting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The harm category to be blocked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>
        /// Optional. The method for blocking content. If not specified, the default behavior is to use the probability
        /// score.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual string Method { get; set; }

        /// <summary>
        /// Required. The threshold for blocking content. If the harm probability exceeds this threshold, the content
        /// will be blocked.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threshold")]
        public virtual string Threshold { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Schema is used to define the format of input/output data. Represents a select subset of an [OpenAPI 3.0 schema
    /// object](https://spec.openapis.org/oas/v3.0.3#schema-object). More fields may be added in the future as needed.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1Schema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Can either be a boolean or an object; controls the presence of additional properties.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalProperties")]
        public virtual object AdditionalProperties { get; set; }

        /// <summary>
        /// Optional. The value should be validated against any (one or more) of the subschemas in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("anyOf")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1Schema> AnyOf { get; set; }

        /// <summary>Optional. Default value of the data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("default")]
        public virtual object Default__ { get; set; }

        /// <summary>Optional. A map of definitions for use by `ref` Only allowed at the root of the schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defs")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudAiplatformV1beta1Schema> Defs { get; set; }

        /// <summary>Optional. The description of the data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. Possible values of the element of primitive type with enum format. Examples: 1. We can define
        /// direction as : {type:STRING, format:enum, enum:["EAST", NORTH", "SOUTH", "WEST"]} 2. We can define apartment
        /// number as : {type:INTEGER, format:enum, enum:["101", "201", "301"]}
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
        public virtual GoogleCloudAiplatformV1beta1Schema Items { get; set; }

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
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudAiplatformV1beta1Schema> Properties { get; set; }

        /// <summary>
        /// Optional. The order of the properties. Not a standard field in open api spec. Only used to support the order
        /// of the properties.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("propertyOrdering")]
        public virtual System.Collections.Generic.IList<string> PropertyOrdering { get; set; }

        /// <summary>
        /// Optional. Allows indirect references between schema nodes. The value should be a valid reference to a child
        /// of the root `defs`. For example, the following schema defines a reference to a schema node named "Pet":
        /// type: object properties: pet: ref: #/defs/Pet defs: Pet: type: object properties: name: type: string The
        /// value of the "pet" property is a reference to the schema node named "Pet". See details in
        /// https://json-schema.org/understanding-json-schema/structuring
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ref")]
        public virtual string Ref__ { get; set; }

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

    /// <summary>
    /// An entry point for displaying Google Search results. A `SearchEntryPoint` is populated when the grounding source
    /// for a model's response is Google Search. It provides information that you can use to display the search results
    /// in your application.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1SearchEntryPoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. An HTML snippet that can be embedded in a web page or an application's webview. This snippet
        /// displays a search result, including the title, URL, and a brief description of the search result.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("renderedContent")]
        public virtual string RenderedContent { get; set; }

        /// <summary>
        /// Optional. A base64-encoded JSON object that contains a list of search queries and their corresponding search
        /// URLs. This information can be used to build a custom search UI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sdkBlob")]
        public virtual string SdkBlob { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A segment of the content.</summary>
    public class GoogleCloudAiplatformV1beta1Segment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The end index of the segment in the `Part`, measured in bytes. This marks the end of the
        /// segment and is exclusive, meaning the segment includes content up to, but not including, the byte at this
        /// index.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endIndex")]
        public virtual System.Nullable<int> EndIndex { get; set; }

        /// <summary>
        /// Output only. The index of the `Part` object that this segment belongs to. This is useful for associating the
        /// segment with a specific part of the content.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partIndex")]
        public virtual System.Nullable<int> PartIndex { get; set; }

        /// <summary>
        /// Output only. The start index of the segment in the `Part`, measured in bytes. This marks the beginning of
        /// the segment and is inclusive, meaning the byte at this index is the first byte of the segment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; }

        /// <summary>Output only. The text of the segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for a single speaker in a multi-speaker setup.</summary>
    public class GoogleCloudAiplatformV1beta1SpeakerVoiceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The name of the speaker. This should be the same as the speaker name used in the prompt.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("speaker")]
        public virtual string Speaker { get; set; }

        /// <summary>Required. The configuration for the voice of this speaker.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("voiceConfig")]
        public virtual GoogleCloudAiplatformV1beta1VoiceConfig VoiceConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for speech generation.</summary>
    public class GoogleCloudAiplatformV1beta1SpeechConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The language code (ISO 639-1) for the speech synthesis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// The configuration for a multi-speaker text-to-speech request. This field is mutually exclusive with
        /// `voice_config`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiSpeakerVoiceConfig")]
        public virtual GoogleCloudAiplatformV1beta1MultiSpeakerVoiceConfig MultiSpeakerVoiceConfig { get; set; }

        /// <summary>The configuration for the voice to use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("voiceConfig")]
        public virtual GoogleCloudAiplatformV1beta1VoiceConfig VoiceConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Tool details that the model may use to generate response. A `Tool` is a piece of code that enables the system to
    /// interact with external systems to perform an action, or set of actions, outside of knowledge and scope of the
    /// model. A Tool object should contain exactly one type of Tool (e.g FunctionDeclaration, Retrieval or
    /// GoogleSearchRetrieval).
    /// </summary>
    public class GoogleCloudAiplatformV1beta1Tool : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. CodeExecution tool type. Enables the model to execute code as part of generation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("codeExecution")]
        public virtual GoogleCloudAiplatformV1beta1ToolCodeExecution CodeExecution { get; set; }

        /// <summary>
        /// Optional. Tool to support the model interacting directly with the computer. If enabled, it automatically
        /// populates computer-use specific Function Declarations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computerUse")]
        public virtual GoogleCloudAiplatformV1beta1ToolComputerUse ComputerUse { get; set; }

        /// <summary>
        /// Optional. Tool to support searching public web data, powered by Vertex AI Search and Sec4 compliance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enterpriseWebSearch")]
        public virtual GoogleCloudAiplatformV1beta1EnterpriseWebSearch EnterpriseWebSearch { get; set; }

        /// <summary>
        /// Optional. Function tool type. One or more function declarations to be passed to the model along with the
        /// current user query. Model may decide to call a subset of these functions by populating FunctionCall in the
        /// response. User should provide a FunctionResponse for each function call in the next turn. Based on the
        /// function responses, Model will generate the final response back to the user. Maximum 512 function
        /// declarations can be provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("functionDeclarations")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1FunctionDeclaration> FunctionDeclarations { get; set; }

        /// <summary>Optional. GoogleMaps tool type. Tool to support Google Maps in Model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleMaps")]
        public virtual GoogleCloudAiplatformV1beta1GoogleMaps GoogleMaps { get; set; }

        /// <summary>
        /// Optional. GoogleSearch tool type. Tool to support Google Search in Model. Powered by Google.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleSearch")]
        public virtual GoogleCloudAiplatformV1beta1ToolGoogleSearch GoogleSearch { get; set; }

        /// <summary>Optional. Specialized retrieval tool that is powered by Google Search.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleSearchRetrieval")]
        public virtual GoogleCloudAiplatformV1beta1GoogleSearchRetrieval GoogleSearchRetrieval { get; set; }

        /// <summary>
        /// Optional. Retrieval tool type. System will always execute the provided retrieval tool(s) to get external
        /// knowledge to answer the prompt. Retrieval results are presented to the model for generation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retrieval")]
        public virtual GoogleCloudAiplatformV1beta1Retrieval Retrieval { get; set; }

        /// <summary>Optional. Tool to support URL context retrieval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("urlContext")]
        public virtual GoogleCloudAiplatformV1beta1UrlContext UrlContext { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Tool that executes code generated by the model, and automatically returns the result to the model. See also
    /// [ExecutableCode]and [CodeExecutionResult] which are input and output to this tool.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1ToolCodeExecution : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Tool to support computer use.</summary>
    public class GoogleCloudAiplatformV1beta1ToolComputerUse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The environment being operated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environment")]
        public virtual string Environment { get; set; }

        /// <summary>
        /// Optional. By default, [predefined
        /// functions](https://cloud.google.com/vertex-ai/generative-ai/docs/computer-use#supported-actions) are
        /// included in the final model call. Some of them can be explicitly excluded from being automatically included.
        /// This can serve two purposes: 1. Using a more restricted / different action space. 2. Improving the
        /// definitions / instructions of predefined functions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedPredefinedFunctions")]
        public virtual System.Collections.Generic.IList<string> ExcludedPredefinedFunctions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Tool config. This config is shared for all tools provided in the request.</summary>
    public class GoogleCloudAiplatformV1beta1ToolConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Function calling config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("functionCallingConfig")]
        public virtual GoogleCloudAiplatformV1beta1FunctionCallingConfig FunctionCallingConfig { get; set; }

        /// <summary>Optional. Retrieval config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retrievalConfig")]
        public virtual GoogleCloudAiplatformV1beta1RetrievalConfig RetrievalConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>GoogleSearch tool type. Tool to support Google Search in Model. Powered by Google.</summary>
    public class GoogleCloudAiplatformV1beta1ToolGoogleSearch : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Sites with confidence level chosen &amp;amp; above this value will be blocked from the search
        /// results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockingConfidence")]
        public virtual string BlockingConfidence { get; set; }

        /// <summary>
        /// Optional. List of domains to be excluded from the search results. The default limit is 2000 domains.
        /// Example: ["amazon.com", "facebook.com"].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludeDomains")]
        public virtual System.Collections.Generic.IList<string> ExcludeDomains { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Tool to support URL context.</summary>
    public class GoogleCloudAiplatformV1beta1UrlContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata returned when the model uses the `url_context` tool to get information from a user-provided URL.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1UrlContextMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. A list of URL metadata, with one entry for each URL retrieved by the tool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("urlMetadata")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1UrlMetadata> UrlMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metadata for a single URL retrieval.</summary>
    public class GoogleCloudAiplatformV1beta1UrlMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The URL retrieved by the tool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retrievedUrl")]
        public virtual string RetrievedUrl { get; set; }

        /// <summary>The status of the URL retrieval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("urlRetrievalStatus")]
        public virtual string UrlRetrievalStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Retrieve from Vertex AI Search datastore or engine for grounding. datastore and engine are mutually exclusive.
    /// See https://cloud.google.com/products/agent-builder
    /// </summary>
    public class GoogleCloudAiplatformV1beta1VertexAISearch : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifications that define the specific DataStores to be searched, along with configurations for those data
        /// stores. This is only considered for Engines with multiple data stores. It should only be set if engine is
        /// used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataStoreSpecs")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1VertexAISearchDataStoreSpec> DataStoreSpecs { get; set; }

        /// <summary>
        /// Optional. Fully-qualified Vertex AI Search data store resource ID. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{dataStore}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datastore")]
        public virtual string Datastore { get; set; }

        /// <summary>
        /// Optional. Fully-qualified Vertex AI Search engine resource ID. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/engines/{engine}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("engine")]
        public virtual string Engine { get; set; }

        /// <summary>Optional. Filter strings to be passed to the search API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Optional. Number of search results to return per query. The default value is 10. The maximumm allowed value
        /// is 10.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxResults")]
        public virtual System.Nullable<int> MaxResults { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Define data stores within engine to filter on in a search call and configurations for those data stores. For
    /// more information, see
    /// https://cloud.google.com/generative-ai-app-builder/docs/reference/rpc/google.cloud.discoveryengine.v1#datastorespec
    /// </summary>
    public class GoogleCloudAiplatformV1beta1VertexAISearchDataStoreSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Full resource name of DataStore, such as Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{dataStore}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataStore")]
        public virtual string DataStore { get; set; }

        /// <summary>
        /// Optional. Filter specification to filter documents in the data store specified by data_store field. For more
        /// information on filtering, see
        /// [Filtering](https://cloud.google.com/generative-ai-app-builder/docs/filter-search-metadata)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Retrieve from Vertex RAG Store for grounding.</summary>
    public class GoogleCloudAiplatformV1beta1VertexRagStore : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Deprecated. Please use rag_resources instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ragCorpora")]
        public virtual System.Collections.Generic.IList<string> RagCorpora { get; set; }

        /// <summary>
        /// Optional. The representation of the rag source. It can be used to specify corpus only or ragfiles. Currently
        /// only support one corpus or multiple files from one corpus. In the future we may open up multiple corpora
        /// support.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ragResources")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1VertexRagStoreRagResource> RagResources { get; set; }

        /// <summary>Optional. The retrieval config for the Rag query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ragRetrievalConfig")]
        public virtual GoogleCloudAiplatformV1beta1RagRetrievalConfig RagRetrievalConfig { get; set; }

        /// <summary>Optional. Number of top k results to return from the selected corpora.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("similarityTopK")]
        public virtual System.Nullable<int> SimilarityTopK { get; set; }

        /// <summary>
        /// Optional. Currently only supported for Gemini Multimodal Live API. In Gemini Multimodal Live API, if
        /// `store_context` bool is specified, Gemini will leverage it to automatically memorize the interactions
        /// between the client and Gemini, and retrieve context when needed to augment the response generation for
        /// users' ongoing and future interactions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storeContext")]
        public virtual System.Nullable<bool> StoreContext { get; set; }

        /// <summary>Optional. Only return results with vector distance smaller than the threshold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vectorDistanceThreshold")]
        public virtual System.Nullable<double> VectorDistanceThreshold { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The definition of the Rag resource.</summary>
    public class GoogleCloudAiplatformV1beta1VertexRagStoreRagResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. RagCorpora resource name. Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ragCorpus")]
        public virtual string RagCorpus { get; set; }

        /// <summary>
        /// Optional. rag_file_id. The files should be in the same rag_corpus set in rag_corpus field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ragFileIds")]
        public virtual System.Collections.Generic.IList<string> RagFileIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Provides metadata for a video, including the start and end offsets for clipping and the frame rate.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1VideoMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The end offset of the video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endOffset")]
        public virtual object EndOffset { get; set; }

        /// <summary>
        /// Optional. The frame rate of the video sent to the model. If not specified, the default value is 1.0. The
        /// valid range is (0.0, 24.0].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fps")]
        public virtual System.Nullable<double> Fps { get; set; }

        /// <summary>Optional. The start offset of the video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startOffset")]
        public virtual object StartOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for a voice.</summary>
    public class GoogleCloudAiplatformV1beta1VoiceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The configuration for a prebuilt voice.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prebuiltVoiceConfig")]
        public virtual GoogleCloudAiplatformV1beta1PrebuiltVoiceConfig PrebuiltVoiceConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An object that represents a latitude/longitude pair. This is expressed as a pair of doubles to represent degrees
    /// latitude and degrees longitude. Unless specified otherwise, this object must conform to the WGS84 standard.
    /// Values must be within normalized ranges.
    /// </summary>
    public class LatLng : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The latitude in degrees. It must be in the range [-90.0, +90.0].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latitude")]
        public virtual System.Nullable<double> Latitude { get; set; }

        /// <summary>The longitude in degrees. It must be in the range [-180.0, +180.0].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longitude")]
        public virtual System.Nullable<double> Longitude { get; set; }

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
}
