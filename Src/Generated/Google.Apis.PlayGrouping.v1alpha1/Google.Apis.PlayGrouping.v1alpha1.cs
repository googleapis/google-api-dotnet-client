// Copyright 2023 Google LLC
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

namespace Google.Apis.PlayGrouping.v1alpha1
{
    /// <summary>The PlayGrouping Service.</summary>
    public class PlayGroupingService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1alpha1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public PlayGroupingService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public PlayGroupingService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Apps = new AppsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "playgrouping";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri => BaseUriOverride ?? "https://playgrouping.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://playgrouping.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Gets the Apps resource.</summary>
        public virtual AppsResource Apps { get; }
    }

    /// <summary>A base abstract class for PlayGrouping requests.</summary>
    public abstract class PlayGroupingBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new PlayGroupingBaseServiceRequest instance.</summary>
        protected PlayGroupingBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes PlayGrouping parameter list.</summary>
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

    /// <summary>The "apps" collection of methods.</summary>
    public class AppsResource
    {
        private const string Resource = "apps";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AppsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Tokens = new TokensResource(service);
        }

        /// <summary>Gets the Tokens resource.</summary>
        public virtual TokensResource Tokens { get; }

        /// <summary>The "tokens" collection of methods.</summary>
        public class TokensResource
        {
            private const string Resource = "tokens";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public TokensResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Tags = new TagsResource(service);
            }

            /// <summary>Gets the Tags resource.</summary>
            public virtual TagsResource Tags { get; }

            /// <summary>The "tags" collection of methods.</summary>
            public class TagsResource
            {
                private const string Resource = "tags";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public TagsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Create or update tags for the user and app that are represented by the given token.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="appPackage">
                /// Required. App whose tags are being manipulated. Format: apps/{package_name}
                /// </param>
                /// <param name="token">
                /// Required. Token for which the tags are being inserted or updated. Format: tokens/{token}
                /// </param>
                public virtual CreateOrUpdateRequest CreateOrUpdate(Google.Apis.PlayGrouping.v1alpha1.Data.CreateOrUpdateTagsRequest body, string appPackage, string token)
                {
                    return new CreateOrUpdateRequest(service, body, appPackage, token);
                }

                /// <summary>
                /// Create or update tags for the user and app that are represented by the given token.
                /// </summary>
                public class CreateOrUpdateRequest : PlayGroupingBaseServiceRequest<Google.Apis.PlayGrouping.v1alpha1.Data.CreateOrUpdateTagsResponse>
                {
                    /// <summary>Constructs a new CreateOrUpdate request.</summary>
                    public CreateOrUpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.PlayGrouping.v1alpha1.Data.CreateOrUpdateTagsRequest body, string appPackage, string token) : base(service)
                    {
                        AppPackage = appPackage;
                        Token = token;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. App whose tags are being manipulated. Format: apps/{package_name}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("appPackage", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AppPackage { get; private set; }

                    /// <summary>
                    /// Required. Token for which the tags are being inserted or updated. Format: tokens/{token}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Token { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.PlayGrouping.v1alpha1.Data.CreateOrUpdateTagsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "createOrUpdate";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha1/{+appPackage}/{+token}/tags:createOrUpdate";

                    /// <summary>Initializes CreateOrUpdate parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("appPackage", new Google.Apis.Discovery.Parameter
                        {
                            Name = "appPackage",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^apps/[^/]+$",
                        });
                        RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                        {
                            Name = "token",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^tokens/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>
            /// Verify an API token by asserting the app and persona it belongs to. The verification is a protection
            /// against client-side attacks and will fail if the contents of the token don't match the provided values.
            /// A token must be verified before it can be used to manipulate user tags.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="appPackage">Required. App the token belongs to. Format: apps/{package_name}</param>
            /// <param name="token">Required. The token to be verified. Format: tokens/{token}</param>
            public virtual VerifyRequest Verify(Google.Apis.PlayGrouping.v1alpha1.Data.VerifyTokenRequest body, string appPackage, string token)
            {
                return new VerifyRequest(service, body, appPackage, token);
            }

            /// <summary>
            /// Verify an API token by asserting the app and persona it belongs to. The verification is a protection
            /// against client-side attacks and will fail if the contents of the token don't match the provided values.
            /// A token must be verified before it can be used to manipulate user tags.
            /// </summary>
            public class VerifyRequest : PlayGroupingBaseServiceRequest<Google.Apis.PlayGrouping.v1alpha1.Data.VerifyTokenResponse>
            {
                /// <summary>Constructs a new Verify request.</summary>
                public VerifyRequest(Google.Apis.Services.IClientService service, Google.Apis.PlayGrouping.v1alpha1.Data.VerifyTokenRequest body, string appPackage, string token) : base(service)
                {
                    AppPackage = appPackage;
                    Token = token;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. App the token belongs to. Format: apps/{package_name}</summary>
                [Google.Apis.Util.RequestParameterAttribute("appPackage", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AppPackage { get; private set; }

                /// <summary>Required. The token to be verified. Format: tokens/{token}</summary>
                [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Token { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.PlayGrouping.v1alpha1.Data.VerifyTokenRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "verify";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha1/{+appPackage}/{+token}:verify";

                /// <summary>Initializes Verify parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("appPackage", new Google.Apis.Discovery.Parameter
                    {
                        Name = "appPackage",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^apps/[^/]+$",
                    });
                    RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                    {
                        Name = "token",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^tokens/[^/]+$",
                    });
                }
            }
        }
    }
}
namespace Google.Apis.PlayGrouping.v1alpha1.Data
{
    /// <summary>Request message for CreateOrUpdateTags. VerifyToken.</summary>
    public class CreateOrUpdateTagsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Tags to be inserted or updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<Tag> Tags { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for CreateOrUpdateTags.</summary>
    public class CreateOrUpdateTagsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All requested tags are returned, including pre-existing ones.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<Tag> Tags { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A tag is associated with exactly one package name and user.</summary>
    public class Tag : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A boolean value of the tag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("booleanValue")]
        public virtual System.Nullable<bool> BooleanValue { get; set; }

        /// <summary>A signed 64-bit integer value of the tag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("int64Value")]
        public virtual System.Nullable<long> Int64Value { get; set; }

        /// <summary>Required. Key for the tag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>A string value of the tag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        private string _timeValueRaw;

        private object _timeValue;

        /// <summary>A time value of the tag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeValue")]
        public virtual string TimeValueRaw
        {
            get => _timeValueRaw;
            set
            {
                _timeValue = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _timeValueRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="TimeValueRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use TimeValueDateTimeOffset instead.")]
        public virtual object TimeValue
        {
            get => _timeValue;
            set
            {
                _timeValueRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _timeValue = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="TimeValueRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? TimeValueDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(TimeValueRaw);
            set => TimeValueRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for VerifyToken.</summary>
    public class VerifyTokenRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Persona represented by the token. Format: personas/{persona}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("persona")]
        public virtual string Persona { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for VerifyToken.</summary>
    public class VerifyTokenResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
