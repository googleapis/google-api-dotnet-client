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

namespace Google.Apis.SubscriptionLinking.v1
{
    /// <summary>The SubscriptionLinking Service.</summary>
    public class SubscriptionLinkingService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public SubscriptionLinkingService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public SubscriptionLinkingService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Publications = new PublicationsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://readerrevenuesubscriptionlinking.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://readerrevenuesubscriptionlinking.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "readerrevenuesubscriptionlinking";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Gets the Publications resource.</summary>
        public virtual PublicationsResource Publications { get; }
    }

    /// <summary>A base abstract class for SubscriptionLinking requests.</summary>
    public abstract class SubscriptionLinkingBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new SubscriptionLinkingBaseServiceRequest instance.</summary>
        protected SubscriptionLinkingBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes SubscriptionLinking parameter list.</summary>
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

    /// <summary>The "publications" collection of methods.</summary>
    public class PublicationsResource
    {
        private const string Resource = "publications";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PublicationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Readers = new ReadersResource(service);
        }

        /// <summary>Gets the Readers resource.</summary>
        public virtual ReadersResource Readers { get; }

        /// <summary>The "readers" collection of methods.</summary>
        public class ReadersResource
        {
            private const string Resource = "readers";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ReadersResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Removes a publication reader, effectively severing the association with a Google user. If `force` is set
            /// to true, any entitlements for this reader will also be deleted. (Otherwise, the request will only work
            /// if the reader has no entitlements.) - If the reader does not exist, return NOT_FOUND. - Return
            /// FAILED_PRECONDITION if the force field is false (or unset) and entitlements are present.
            /// </summary>
            /// <param name="name">
            /// Required. The resource name of the reader. Format: publications/{publication_id}/readers/{ppid}
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>
            /// Removes a publication reader, effectively severing the association with a Google user. If `force` is set
            /// to true, any entitlements for this reader will also be deleted. (Otherwise, the request will only work
            /// if the reader has no entitlements.) - If the reader does not exist, return NOT_FOUND. - Return
            /// FAILED_PRECONDITION if the force field is false (or unset) and entitlements are present.
            /// </summary>
            public class DeleteRequest : SubscriptionLinkingBaseServiceRequest<Google.Apis.SubscriptionLinking.v1.Data.DeleteReaderResponse>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the reader. Format: publications/{publication_id}/readers/{ppid}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>If set to true, any entitlements under the reader will also be purged.</summary>
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
                        Pattern = @"^publications/[^/]+/readers/[^/]+$",
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

            /// <summary>Gets a reader of a publication. Returns NOT_FOUND if the reader does not exist.</summary>
            /// <param name="name">
            /// Required. The resource name of the reader. Format: publications/{publication_id}/readers/{ppid}
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets a reader of a publication. Returns NOT_FOUND if the reader does not exist.</summary>
            public class GetRequest : SubscriptionLinkingBaseServiceRequest<Google.Apis.SubscriptionLinking.v1.Data.Reader>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the reader. Format: publications/{publication_id}/readers/{ppid}
                /// </summary>
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
                        Pattern = @"^publications/[^/]+/readers/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Gets the reader entitlements for a publication reader. - Returns PERMISSION_DENIED if the caller does
            /// not have access. - Returns NOT_FOUND if the reader does not exist.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the reader entitlements to retrieve. Format:
            /// publications/{publication_id}/readers/{reader_id}/entitlements
            /// </param>
            public virtual GetEntitlementsRequest GetEntitlements(string name)
            {
                return new GetEntitlementsRequest(this.service, name);
            }

            /// <summary>
            /// Gets the reader entitlements for a publication reader. - Returns PERMISSION_DENIED if the caller does
            /// not have access. - Returns NOT_FOUND if the reader does not exist.
            /// </summary>
            public class GetEntitlementsRequest : SubscriptionLinkingBaseServiceRequest<Google.Apis.SubscriptionLinking.v1.Data.ReaderEntitlements>
            {
                /// <summary>Constructs a new GetEntitlements request.</summary>
                public GetEntitlementsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the reader entitlements to retrieve. Format:
                /// publications/{publication_id}/readers/{reader_id}/entitlements
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getEntitlements";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes GetEntitlements parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^publications/[^/]+/readers/[^/]+/entitlements$",
                    });
                }
            }

            /// <summary>
            /// Updates the reader entitlements for a publication reader. The entire reader entitlements will be
            /// overwritten by the new reader entitlements in the payload, like a PUT. - Returns PERMISSION_DENIED if
            /// the caller does not have access. - Returns NOT_FOUND if the reader does not exist.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Output only. The resource name of the singleton.</param>
            public virtual UpdateEntitlementsRequest UpdateEntitlements(Google.Apis.SubscriptionLinking.v1.Data.ReaderEntitlements body, string name)
            {
                return new UpdateEntitlementsRequest(this.service, body, name);
            }

            /// <summary>
            /// Updates the reader entitlements for a publication reader. The entire reader entitlements will be
            /// overwritten by the new reader entitlements in the payload, like a PUT. - Returns PERMISSION_DENIED if
            /// the caller does not have access. - Returns NOT_FOUND if the reader does not exist.
            /// </summary>
            public class UpdateEntitlementsRequest : SubscriptionLinkingBaseServiceRequest<Google.Apis.SubscriptionLinking.v1.Data.ReaderEntitlements>
            {
                /// <summary>Constructs a new UpdateEntitlements request.</summary>
                public UpdateEntitlementsRequest(Google.Apis.Services.IClientService service, Google.Apis.SubscriptionLinking.v1.Data.ReaderEntitlements body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Output only. The resource name of the singleton.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Optional. The list of fields to update. Defaults to all fields.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SubscriptionLinking.v1.Data.ReaderEntitlements Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "updateEntitlements";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes UpdateEntitlements parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^publications/[^/]+/readers/[^/]+/entitlements$",
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
        }
    }
}
namespace Google.Apis.SubscriptionLinking.v1.Data
{
    /// <summary>Response to deleting a reader of a publication.</summary>
    public class DeleteReaderResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single entitlement for a publication reader</summary>
    public class Entitlement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The detail field can carry a description of the SKU that corresponds to what the user has been granted
        /// access to. This description, which is opaque to Google, can be displayed in the Google user subscription
        /// console for users who linked the subscription to a Google Account. Max 80 character limit.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detail")]
        public virtual string Detail { get; set; }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// Required. Expiration time of the entitlement. Entitlements that have expired over 30 days will be purged.
        /// The max expire_time is 398 days from now().
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual string ExpireTimeRaw
        {
            get => _expireTimeRaw;
            set
            {
                _expireTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expireTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpireTimeDateTimeOffset instead.")]
        public virtual object ExpireTime
        {
            get => _expireTime;
            set
            {
                _expireTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expireTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpireTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpireTimeRaw);
            set => ExpireTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Required. The publication's product ID that the user has access to. This is the same product ID as can be
        /// found in Schema.org markup (http://schema.org/productID). E.g. "dailybugle.com:basic"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; }

        /// <summary>
        /// A source-specific subscription token. This is an opaque string that the publisher provides to Google. This
        /// token is opaque and has no meaning to Google.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriptionToken")]
        public virtual string SubscriptionToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A reader of a publication.</summary>
    public class Reader : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time the publication reader was created and associated with a Google user.</summary>
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
        /// Output only. The resource name of the reader. The last part of ppid in the resource name is the publisher
        /// provided id.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The SwG publication id that the reader's subscription linking was originating from.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originatingPublicationId")]
        public virtual string OriginatingPublicationId { get; set; }

        /// <summary>Output only. The publisher provided id of the reader.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ppid")]
        public virtual string Ppid { get; set; }

        /// <summary>Output only. The SwG publication id that the reader has linked their subscription to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicationId")]
        public virtual string PublicationId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A singleton containing all of a reader's entitlements for a publication.</summary>
    public class ReaderEntitlements : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All of the entitlements for a publication reader.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entitlements")]
        public virtual System.Collections.Generic.IList<Entitlement> Entitlements { get; set; }

        /// <summary>Output only. The resource name of the singleton.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
