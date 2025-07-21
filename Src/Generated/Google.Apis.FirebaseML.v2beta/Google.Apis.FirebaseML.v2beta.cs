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

    /// <summary>Content blob.</summary>
    public class GoogleCloudAiplatformV1beta1Blob : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>A response candidate generated from the model.</summary>
    public class GoogleCloudAiplatformV1beta1Candidate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Average log probability score of the candidate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("avgLogprobs")]
        public virtual System.Nullable<double> AvgLogprobs { get; set; }

        /// <summary>Output only. Source attribution of the generated content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("citationMetadata")]
        public virtual GoogleCloudAiplatformV1beta1CitationMetadata CitationMetadata { get; set; }

        /// <summary>Output only. Content parts of the candidate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual GoogleCloudAiplatformV1beta1Content Content { get; set; }

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
        public virtual GoogleCloudAiplatformV1beta1GroundingMetadata GroundingMetadata { get; set; }

        /// <summary>Output only. Index of the candidate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual System.Nullable<int> Index { get; set; }

        /// <summary>Output only. Log-likelihood scores for the response tokens and top tokens</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logprobsResult")]
        public virtual GoogleCloudAiplatformV1beta1LogprobsResult LogprobsResult { get; set; }

        /// <summary>
        /// Output only. List of ratings for the safety of a response candidate. There is at most one rating per
        /// category.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("safetyRatings")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1SafetyRating> SafetyRatings { get; set; }

        /// <summary>Output only. Metadata related to url context retrieval tool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("urlContextMetadata")]
        public virtual GoogleCloudAiplatformV1beta1UrlContextMetadata UrlContextMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Source attributions for content.</summary>
    public class GoogleCloudAiplatformV1beta1Citation : Google.Apis.Requests.IDirectResponseSchema
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
    public class GoogleCloudAiplatformV1beta1CitationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. List of citations.</summary>
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
    /// The base structured datatype containing multi-part content of a message. A `Content` includes a `role` field
    /// designating the producer of the `Content` and a `parts` field containing multi-part data that contains the
    /// content of the message turn.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1Content : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Ordered `Parts` that constitute a single message. Parts may have different IANA MIME types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parts")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1Part> Parts { get; set; }

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

    /// <summary>URI based data.</summary>
    public class GoogleCloudAiplatformV1beta1FileData : Google.Apis.Requests.IDirectResponseSchema
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

        /// <summary>Required. The name of the function to call. Matches [FunctionDeclaration.name].</summary>
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
        /// Required. The function response in JSON object format. Use "output" key to specify function output and
        /// "error" key to specify error details (if any). If "output" and "error" keys are not specified, then whole
        /// "response" is treated as function output.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string, object> Response { get; set; }

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

    /// <summary>Content filter results for a prompt sent in the request.</summary>
    public class GoogleCloudAiplatformV1beta1GenerateContentResponsePromptFeedback : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Blocked reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockReason")]
        public virtual string BlockReason { get; set; }

        /// <summary>Output only. A readable block reason message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockReasonMessage")]
        public virtual string BlockReasonMessage { get; set; }

        /// <summary>Output only. Safety ratings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("safetyRatings")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1SafetyRating> SafetyRatings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Usage metadata about response(s).</summary>
    public class GoogleCloudAiplatformV1beta1GenerateContentResponseUsageMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. List of modalities of the cached content in the request input.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cacheTokensDetails")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1ModalityTokenCount> CacheTokensDetails { get; set; }

        /// <summary>Output only. Number of tokens in the cached part in the input (the cached content).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cachedContentTokenCount")]
        public virtual System.Nullable<int> CachedContentTokenCount { get; set; }

        /// <summary>Number of tokens in the response(s).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("candidatesTokenCount")]
        public virtual System.Nullable<int> CandidatesTokenCount { get; set; }

        /// <summary>Output only. List of modalities that were returned in the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("candidatesTokensDetails")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1ModalityTokenCount> CandidatesTokensDetails { get; set; }

        /// <summary>
        /// Number of tokens in the request. When `cached_content` is set, this is still the total effective prompt size
        /// meaning this includes the number of tokens in the cached content.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promptTokenCount")]
        public virtual System.Nullable<int> PromptTokenCount { get; set; }

        /// <summary>Output only. List of modalities that were processed in the request input.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promptTokensDetails")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1ModalityTokenCount> PromptTokensDetails { get; set; }

        /// <summary>Output only. Number of tokens present in thoughts output.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thoughtsTokenCount")]
        public virtual System.Nullable<int> ThoughtsTokenCount { get; set; }

        /// <summary>Output only. Number of tokens present in tool-use prompt(s).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolUsePromptTokenCount")]
        public virtual System.Nullable<int> ToolUsePromptTokenCount { get; set; }

        /// <summary>Output only. List of modalities that were processed for tool-use request inputs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolUsePromptTokensDetails")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1ModalityTokenCount> ToolUsePromptTokensDetails { get; set; }

        /// <summary>Total token count for prompt, response candidates, and tool-use prompts (if present).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalTokenCount")]
        public virtual System.Nullable<int> TotalTokenCount { get; set; }

        /// <summary>
        /// Output only. Traffic type. This shows whether a request consumes Pay-As-You-Go or Provisioned Throughput
        /// quota.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trafficType")]
        public virtual string TrafficType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Generation config.</summary>
    public class GoogleCloudAiplatformV1beta1GenerationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. If enabled, audio timestamp will be included in the request to the model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audioTimestamp")]
        public virtual System.Nullable<bool> AudioTimestamp { get; set; }

        /// <summary>Optional. Number of candidates to generate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("candidateCount")]
        public virtual System.Nullable<int> CandidateCount { get; set; }

        /// <summary>Optional. If enabled, the model will detect emotions and adapt its responses accordingly.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableAffectiveDialog")]
        public virtual System.Nullable<bool> EnableAffectiveDialog { get; set; }

        /// <summary>Optional. Frequency penalties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frequencyPenalty")]
        public virtual System.Nullable<float> FrequencyPenalty { get; set; }

        /// <summary>Optional. Logit probabilities.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logprobs")]
        public virtual System.Nullable<int> Logprobs { get; set; }

        /// <summary>Optional. The maximum number of output tokens to generate per message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxOutputTokens")]
        public virtual System.Nullable<int> MaxOutputTokens { get; set; }

        /// <summary>Optional. If specified, the media resolution specified will be used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mediaResolution")]
        public virtual string MediaResolution { get; set; }

        /// <summary>Optional. Config for model selection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelConfig")]
        public virtual GoogleCloudAiplatformV1beta1GenerationConfigModelConfig ModelConfig { get; set; }

        /// <summary>Optional. Positive penalties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("presencePenalty")]
        public virtual System.Nullable<float> PresencePenalty { get; set; }

        /// <summary>
        /// Optional. Output schema of the generated response. This is an alternative to `response_schema` that accepts
        /// [JSON Schema](https://json-schema.org/). If set, `response_schema` must be omitted, but `response_mime_type`
        /// is required. While the full JSON Schema may be sent, not all features are supported. Specifically, only the
        /// following properties are supported: - `$id` - `$defs` - `$ref` - `$anchor` - `type` - `format` - `title` -
        /// `description` - `enum` (for strings and numbers) - `items` - `prefixItems` - `minItems` - `maxItems` -
        /// `minimum` - `maximum` - `anyOf` - `oneOf` (interpreted the same as `anyOf`) - `properties` -
        /// `additionalProperties` - `required` The non-standard `propertyOrdering` property may also be set. Cyclic
        /// references are unrolled to a limited degree and, as such, may only be used within non-required properties.
        /// (Nullable properties are not sufficient.) If `$ref` is set on a sub-schema, no other properties, except for
        /// than those starting as a `$`, may be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseJsonSchema")]
        public virtual object ResponseJsonSchema { get; set; }

        /// <summary>Optional. If true, export the logprobs results in response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseLogprobs")]
        public virtual System.Nullable<bool> ResponseLogprobs { get; set; }

        /// <summary>
        /// Optional. Output response mimetype of the generated candidate text. Supported mimetype: - `text/plain`:
        /// (default) Text output. - `application/json`: JSON response in the candidates. The model needs to be prompted
        /// to output the appropriate response type, otherwise the behavior is undefined. This is a preview feature.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseMimeType")]
        public virtual string ResponseMimeType { get; set; }

        /// <summary>Optional. The modalities of the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseModalities")]
        public virtual System.Collections.Generic.IList<string> ResponseModalities { get; set; }

        /// <summary>
        /// Optional. The `Schema` object allows the definition of input and output data types. These types can be
        /// objects, but also primitives and arrays. Represents a select subset of an [OpenAPI 3.0 schema
        /// object](https://spec.openapis.org/oas/v3.0.3#schema). If set, a compatible response_mime_type must also be
        /// set. Compatible mimetypes: `application/json`: Schema for JSON response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseSchema")]
        public virtual GoogleCloudAiplatformV1beta1Schema ResponseSchema { get; set; }

        /// <summary>Optional. Routing configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routingConfig")]
        public virtual GoogleCloudAiplatformV1beta1GenerationConfigRoutingConfig RoutingConfig { get; set; }

        /// <summary>Optional. Seed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seed")]
        public virtual System.Nullable<int> Seed { get; set; }

        /// <summary>Optional. The speech generation config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("speechConfig")]
        public virtual GoogleCloudAiplatformV1beta1SpeechConfig SpeechConfig { get; set; }

        /// <summary>Optional. Stop sequences.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stopSequences")]
        public virtual System.Collections.Generic.IList<string> StopSequences { get; set; }

        /// <summary>Optional. Controls the randomness of predictions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("temperature")]
        public virtual System.Nullable<float> Temperature { get; set; }

        /// <summary>
        /// Optional. Config for thinking features. An error will be returned if this field is set for models that don't
        /// support thinking.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thinkingConfig")]
        public virtual GoogleCloudAiplatformV1beta1GenerationConfigThinkingConfig ThinkingConfig { get; set; }

        /// <summary>Optional. If specified, top-k sampling will be used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topK")]
        public virtual System.Nullable<float> TopK { get; set; }

        /// <summary>Optional. If specified, nucleus sampling will be used.</summary>
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

    /// <summary>The configuration for routing the request to a specific model.</summary>
    public class GoogleCloudAiplatformV1beta1GenerationConfigRoutingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Automated routing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoMode")]
        public virtual GoogleCloudAiplatformV1beta1GenerationConfigRoutingConfigAutoRoutingMode AutoMode { get; set; }

        /// <summary>Manual routing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manualMode")]
        public virtual GoogleCloudAiplatformV1beta1GenerationConfigRoutingConfigManualRoutingMode ManualMode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// When automated routing is specified, the routing will be determined by the pretrained routing model and customer
    /// provided model routing preference.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1GenerationConfigRoutingConfigAutoRoutingMode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The model routing preference.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelRoutingPreference")]
        public virtual string ModelRoutingPreference { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>When manual routing is set, the specified model will be used directly.</summary>
    public class GoogleCloudAiplatformV1beta1GenerationConfigRoutingConfigManualRoutingMode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The model name to use. Only the public LLM models are accepted. See [Supported
        /// models](https://cloud.google.com/vertex-ai/generative-ai/docs/model-reference/inference#supported-models).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelName")]
        public virtual string ModelName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Config for thinking features.</summary>
    public class GoogleCloudAiplatformV1beta1GenerationConfigThinkingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Indicates whether to include thoughts in the response. If true, thoughts are returned only when
        /// available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeThoughts")]
        public virtual System.Nullable<bool> IncludeThoughts { get; set; }

        /// <summary>Optional. Indicates the thinking budget in tokens.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thinkingBudget")]
        public virtual System.Nullable<int> ThinkingBudget { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Tool to retrieve public maps data for grounding, powered by Google.</summary>
    public class GoogleCloudAiplatformV1beta1GoogleMaps : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The authentication config to access the API. Deprecated. Please use auth_config instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiAuth")]
        public virtual GoogleCloudAiplatformV1beta1ApiAuth ApiAuth { get; set; }

        /// <summary>The authentication config to access the API. Only API key is supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authConfig")]
        public virtual GoogleCloudAiplatformV1beta1AuthConfig AuthConfig { get; set; }

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

    /// <summary>Grounding chunk.</summary>
    public class GoogleCloudAiplatformV1beta1GroundingChunk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Grounding chunk from Google Maps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maps")]
        public virtual GoogleCloudAiplatformV1beta1GroundingChunkMaps Maps { get; set; }

        /// <summary>Grounding chunk from context retrieved by the retrieval tools.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retrievedContext")]
        public virtual GoogleCloudAiplatformV1beta1GroundingChunkRetrievedContext RetrievedContext { get; set; }

        /// <summary>Grounding chunk from the web.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("web")]
        public virtual GoogleCloudAiplatformV1beta1GroundingChunkWeb Web { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Chunk from Google Maps.</summary>
    public class GoogleCloudAiplatformV1beta1GroundingChunkMaps : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This Place's resource name, in `places/{place_id}` format. Can be used to look up the Place.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placeId")]
        public virtual string PlaceId { get; set; }

        /// <summary>Text of the chunk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>Title of the chunk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>URI reference of the chunk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Chunk from context retrieved by the retrieval tools.</summary>
    public class GoogleCloudAiplatformV1beta1GroundingChunkRetrievedContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Additional context for the RAG retrieval result. This is only populated when using the RAG retrieval tool.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ragChunk")]
        public virtual GoogleCloudAiplatformV1beta1RagChunk RagChunk { get; set; }

        /// <summary>Text of the attribution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>Title of the attribution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>URI reference of the attribution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Chunk from the web.</summary>
    public class GoogleCloudAiplatformV1beta1GroundingChunkWeb : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Domain of the (original) URI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>Title of the chunk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>URI reference of the chunk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata returned to client when grounding is enabled.</summary>
    public class GoogleCloudAiplatformV1beta1GroundingMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Output only. Resource name of the Google Maps widget context token to be used with the
        /// PlacesContextElement widget to render contextual data. This is populated only for Google Maps grounding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleMapsWidgetContextToken")]
        public virtual string GoogleMapsWidgetContextToken { get; set; }

        /// <summary>List of supporting references retrieved from specified grounding source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groundingChunks")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1GroundingChunk> GroundingChunks { get; set; }

        /// <summary>Optional. List of grounding support.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groundingSupports")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1GroundingSupport> GroundingSupports { get; set; }

        /// <summary>Optional. Output only. Retrieval metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retrievalMetadata")]
        public virtual GoogleCloudAiplatformV1beta1RetrievalMetadata RetrievalMetadata { get; set; }

        /// <summary>Optional. Queries executed by the retrieval tools.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retrievalQueries")]
        public virtual System.Collections.Generic.IList<string> RetrievalQueries { get; set; }

        /// <summary>Optional. Google search entry for the following-up web searches.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchEntryPoint")]
        public virtual GoogleCloudAiplatformV1beta1SearchEntryPoint SearchEntryPoint { get; set; }

        /// <summary>Optional. Web search queries for the following-up web search.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webSearchQueries")]
        public virtual System.Collections.Generic.IList<string> WebSearchQueries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Grounding support.</summary>
    public class GoogleCloudAiplatformV1beta1GroundingSupport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Confidence score of the support references. Ranges from 0 to 1. 1 is the most confident. For Gemini 2.0 and
        /// before, this list must have the same size as the grounding_chunk_indices. For Gemini 2.5 and after, this
        /// list will be empty and should be ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidenceScores")]
        public virtual System.Collections.Generic.IList<System.Nullable<float>> ConfidenceScores { get; set; }

        /// <summary>
        /// A list of indices (into 'grounding_chunk') specifying the citations associated with the claim. For instance
        /// [1,3,4] means that grounding_chunk[1], grounding_chunk[3], grounding_chunk[4] are the retrieved content
        /// attributed to the claim.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groundingChunkIndices")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> GroundingChunkIndices { get; set; }

        /// <summary>Segment of the content this support belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual GoogleCloudAiplatformV1beta1Segment Segment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Logprobs Result</summary>
    public class GoogleCloudAiplatformV1beta1LogprobsResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Length = total number of decoding steps. The chosen candidates may or may not be in top_candidates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chosenCandidates")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1LogprobsResultCandidate> ChosenCandidates { get; set; }

        /// <summary>Length = total number of decoding steps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topCandidates")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1LogprobsResultTopCandidates> TopCandidates { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Candidate for the logprobs token and score.</summary>
    public class GoogleCloudAiplatformV1beta1LogprobsResultCandidate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The candidate's log probability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logProbability")]
        public virtual System.Nullable<float> LogProbability { get; set; }

        /// <summary>The candidate's token string value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>The candidate's token id value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokenId")]
        public virtual System.Nullable<int> TokenId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Candidates with top log probabilities at each decoding step.</summary>
    public class GoogleCloudAiplatformV1beta1LogprobsResultTopCandidates : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Sorted by log probability in descending order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("candidates")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1LogprobsResultCandidate> Candidates { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents token counting info for a single modality.</summary>
    public class GoogleCloudAiplatformV1beta1ModalityTokenCount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The modality associated with this token count.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modality")]
        public virtual string Modality { get; set; }

        /// <summary>Number of tokens.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokenCount")]
        public virtual System.Nullable<int> TokenCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A datatype containing media that is part of a multi-part `Content` message. A `Part` consists of data which has
    /// an associated datatype. A `Part` can only contain one of the accepted types in `Part.data`. A `Part` must have a
    /// fixed IANA MIME type identifying the type and subtype of the media if `inline_data` or `file_data` field is
    /// filled with raw bytes.
    /// </summary>
    public class GoogleCloudAiplatformV1beta1Part : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Result of executing the [ExecutableCode].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("codeExecutionResult")]
        public virtual GoogleCloudAiplatformV1beta1CodeExecutionResult CodeExecutionResult { get; set; }

        /// <summary>Optional. Code generated by the model that is meant to be executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executableCode")]
        public virtual GoogleCloudAiplatformV1beta1ExecutableCode ExecutableCode { get; set; }

        /// <summary>Optional. URI based data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileData")]
        public virtual GoogleCloudAiplatformV1beta1FileData FileData { get; set; }

        /// <summary>
        /// Optional. A predicted [FunctionCall] returned from the model that contains a string representing the
        /// [FunctionDeclaration.name] with the parameters and their values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("functionCall")]
        public virtual GoogleCloudAiplatformV1beta1FunctionCall FunctionCall { get; set; }

        /// <summary>
        /// Optional. The result output of a [FunctionCall] that contains a string representing the
        /// [FunctionDeclaration.name] and a structured JSON object containing any output from the function call. It is
        /// used as context to the model.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("functionResponse")]
        public virtual GoogleCloudAiplatformV1beta1FunctionResponse FunctionResponse { get; set; }

        /// <summary>Optional. Inlined bytes data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inlineData")]
        public virtual GoogleCloudAiplatformV1beta1Blob InlineData { get; set; }

        /// <summary>Optional. Text part (can be code).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>Optional. Indicates if the part is thought from the model.</summary>
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

    /// <summary>The configuration for the prebuilt speaker to use.</summary>
    public class GoogleCloudAiplatformV1beta1PrebuiltVoiceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the preset voice to use.</summary>
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

    /// <summary>Metadata related to retrieval in the grounding flow.</summary>
    public class GoogleCloudAiplatformV1beta1RetrievalMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Score indicating how likely information from Google Search could help answer the prompt. The score
        /// is in the range `[0, 1]`, where 0 is the least likely and 1 is the most likely. This score is only populated
        /// when Google Search grounding and dynamic retrieval is enabled. It will be compared to the threshold to
        /// determine whether to trigger Google Search.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleSearchDynamicRetrievalScore")]
        public virtual System.Nullable<float> GoogleSearchDynamicRetrievalScore { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Safety rating corresponding to the generated content.</summary>
    public class GoogleCloudAiplatformV1beta1SafetyRating : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Indicates whether the content was filtered out because of this rating.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blocked")]
        public virtual System.Nullable<bool> Blocked { get; set; }

        /// <summary>Output only. Harm category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>
        /// Output only. The overwritten threshold for the safety category of Gemini 2.0 image out. If minors are
        /// detected in the output image, the threshold of each safety category will be overwritten if user sets a lower
        /// threshold.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overwrittenThreshold")]
        public virtual string OverwrittenThreshold { get; set; }

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
    public class GoogleCloudAiplatformV1beta1SafetySetting : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Google search entry point.</summary>
    public class GoogleCloudAiplatformV1beta1SearchEntryPoint : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Segment of the content.</summary>
    public class GoogleCloudAiplatformV1beta1Segment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. End index in the given Part, measured in bytes. Offset from the start of the Part, exclusive,
        /// starting at zero.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endIndex")]
        public virtual System.Nullable<int> EndIndex { get; set; }

        /// <summary>Output only. The index of a Part object within its parent Content object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partIndex")]
        public virtual System.Nullable<int> PartIndex { get; set; }

        /// <summary>
        /// Output only. Start index in the given Part, measured in bytes. Offset from the start of the Part, inclusive,
        /// starting at zero.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; }

        /// <summary>Output only. The text corresponding to the segment from the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The speech generation config.</summary>
    public class GoogleCloudAiplatformV1beta1SpeechConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Language code (ISO 639. e.g. en-US) for the speech synthesization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>The configuration for the speaker to use.</summary>
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

        /// <summary>
        /// Optional. GoogleSearchRetrieval tool type. Specialized retrieval tool that is powered by Google search.
        /// </summary>
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
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Tool to support URL context.</summary>
    public class GoogleCloudAiplatformV1beta1UrlContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata related to url context retrieval tool.</summary>
    public class GoogleCloudAiplatformV1beta1UrlContextMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. List of url context.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("urlMetadata")]
        public virtual System.Collections.Generic.IList<GoogleCloudAiplatformV1beta1UrlMetadata> UrlMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Context of the a single url retrieval.</summary>
    public class GoogleCloudAiplatformV1beta1UrlMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Retrieved url by the tool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retrievedUrl")]
        public virtual string RetrievedUrl { get; set; }

        /// <summary>Status of the url retrieval.</summary>
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

    /// <summary>Metadata describes the input video content.</summary>
    public class GoogleCloudAiplatformV1beta1VideoMetadata : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>The configuration for the voice to use.</summary>
    public class GoogleCloudAiplatformV1beta1VoiceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The configuration for the prebuilt voice to use.</summary>
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
