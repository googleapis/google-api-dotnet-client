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

namespace Google.Apis.Chromewebstore.v1_1
{
    /// <summary>The Chromewebstore Service.</summary>
    public class ChromewebstoreService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1.1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public ChromewebstoreService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public ChromewebstoreService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Items = new ItemsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://chromewebstore.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://chromewebstore.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "chromewebstore";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Chrome Web Store API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, update, or publish your Chrome Web Store extensions, themes, apps, and licences you have
            /// access to
            /// </summary>
            public static string Chromewebstore = "https://www.googleapis.com/auth/chromewebstore";

            /// <summary>
            /// See and download your Chrome Web Store extensions and apps, and see licenses you have access to
            /// </summary>
            public static string ChromewebstoreReadonly = "https://www.googleapis.com/auth/chromewebstore.readonly";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Chrome Web Store API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, update, or publish your Chrome Web Store extensions, themes, apps, and licences you have
            /// access to
            /// </summary>
            public const string Chromewebstore = "https://www.googleapis.com/auth/chromewebstore";

            /// <summary>
            /// See and download your Chrome Web Store extensions and apps, and see licenses you have access to
            /// </summary>
            public const string ChromewebstoreReadonly = "https://www.googleapis.com/auth/chromewebstore.readonly";
        }

        /// <summary>Gets the Items resource.</summary>
        public virtual ItemsResource Items { get; }
    }

    /// <summary>A base abstract class for Chromewebstore requests.</summary>
    public abstract class ChromewebstoreBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new ChromewebstoreBaseServiceRequest instance.</summary>
        protected ChromewebstoreBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Chromewebstore parameter list.</summary>
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

    /// <summary>The "items" collection of methods.</summary>
    public class ItemsResource
    {
        private const string Resource = "items";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ItemsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Gets your own Chrome Web Store item.</summary>
        /// <param name="itemId">
        /// Unique identifier representing the Chrome App, Chrome Extension, or the Chrome Theme.
        /// </param>
        public virtual GetRequest Get(string itemId)
        {
            return new GetRequest(this.service, itemId);
        }

        /// <summary>Gets your own Chrome Web Store item.</summary>
        public class GetRequest : ChromewebstoreBaseServiceRequest<Google.Apis.Chromewebstore.v1_1.Data.Item>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string itemId) : base(service)
            {
                ItemId = itemId;
                InitParameters();
            }

            /// <summary>Unique identifier representing the Chrome App, Chrome Extension, or the Chrome Theme.</summary>
            [Google.Apis.Util.RequestParameterAttribute("itemId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ItemId { get; private set; }

            /// <summary>Determines which subset of the item information to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>Determines which subset of the item information to return.</summary>
            public enum ProjectionEnum
            {
                /// <summary>Return information extracted from the current draft.</summary>
                [Google.Apis.Util.StringValueAttribute("DRAFT")]
                DRAFT = 0,

                /// <summary>Return information extracted from the published item draft.</summary>
                [Google.Apis.Util.StringValueAttribute("PUBLISHED")]
                PUBLISHED = 1,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "chromewebstore/v1.1/items/{itemId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("itemId", new Google.Apis.Discovery.Parameter
                {
                    Name = "itemId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("projection", new Google.Apis.Discovery.Parameter
                {
                    Name = "projection",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts a new item.</summary>
        public virtual InsertRequest Insert()
        {
            return new InsertRequest(this.service);
        }

        /// <summary>Inserts a new item.</summary>
        public class InsertRequest : ChromewebstoreBaseServiceRequest<Google.Apis.Chromewebstore.v1_1.Data.Item>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// The email of the publisher who owns the items. Defaults to the caller's email address.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("publisherEmail", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PublisherEmail { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "chromewebstore/v1.1/items";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("publisherEmail", new Google.Apis.Discovery.Parameter
                {
                    Name = "publisherEmail",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts a new item.</summary>
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
        /// <param name="stream">The stream to upload. See remarks for further information.</param>
        /// <param name="contentType">The content type of the stream to upload.</param>
        public virtual InsertMediaUpload Insert(System.IO.Stream stream, string contentType)
        {
            return new InsertMediaUpload(service, stream, contentType);
        }

        /// <summary>Insert media upload which supports resumable upload.</summary>
        public class InsertMediaUpload : Google.Apis.Upload.ResumableUpload<string, Google.Apis.Chromewebstore.v1_1.Data.Item>
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
            /// The email of the publisher who owns the items. Defaults to the caller's email address.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("publisherEmail", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PublisherEmail { get; set; }

            /// <summary>Constructs a new Insert media upload instance.</summary>
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
            public InsertMediaUpload(Google.Apis.Services.IClientService service, System.IO.Stream stream, string contentType)
                : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "chromewebstore/v1.1/items"), "POST", stream, contentType)
            {
            }
        }

        /// <summary>Publishes an item.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="itemId">The ID of the item to publish.</param>
        public virtual PublishRequest Publish(Google.Apis.Chromewebstore.v1_1.Data.PublishRequest body, string itemId)
        {
            return new PublishRequest(this.service, body, itemId);
        }

        /// <summary>Publishes an item.</summary>
        public class PublishRequest : ChromewebstoreBaseServiceRequest<Google.Apis.Chromewebstore.v1_1.Data.Item2>
        {
            /// <summary>Constructs a new Publish request.</summary>
            public PublishRequest(Google.Apis.Services.IClientService service, Google.Apis.Chromewebstore.v1_1.Data.PublishRequest body, string itemId) : base(service)
            {
                ItemId = itemId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the item to publish.</summary>
            [Google.Apis.Util.RequestParameterAttribute("itemId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ItemId { get; private set; }

            /// <summary>
            /// The deploy percentage you want to set for your item. Valid values are [0, 100]. If set to any number
            /// less than 100, only that many percentage of users will be allowed to get the update.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("deployPercentage", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> DeployPercentage { get; set; }

            /// <summary>
            /// Provide defined publishTarget in URL (case sensitive): publishTarget="trustedTesters" or
            /// publishTarget="default". Defaults to publishTarget="default".
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("publishTarget", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PublishTarget { get; set; }

            /// <summary>
            /// Optional. The caller request to exempt the review and directly publish because the update is within the
            /// list that we can automatically validate. The API will check if the exemption can be granted using real
            /// time data.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("reviewExemption", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ReviewExemption { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Chromewebstore.v1_1.Data.PublishRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "publish";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "chromewebstore/v1.1/items/{itemId}/publish";

            /// <summary>Initializes Publish parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("itemId", new Google.Apis.Discovery.Parameter
                {
                    Name = "itemId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("deployPercentage", new Google.Apis.Discovery.Parameter
                {
                    Name = "deployPercentage",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("publishTarget", new Google.Apis.Discovery.Parameter
                {
                    Name = "publishTarget",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("reviewExemption", new Google.Apis.Discovery.Parameter
                {
                    Name = "reviewExemption",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates an existing item.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="itemId">The ID of the item to upload.</param>
        public virtual UpdateRequest Update(Google.Apis.Chromewebstore.v1_1.Data.Item body, string itemId)
        {
            return new UpdateRequest(this.service, body, itemId);
        }

        /// <summary>Updates an existing item.</summary>
        public class UpdateRequest : ChromewebstoreBaseServiceRequest<Google.Apis.Chromewebstore.v1_1.Data.Item>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Chromewebstore.v1_1.Data.Item body, string itemId) : base(service)
            {
                ItemId = itemId;
                Body = body;
                InitParameters();
            }

            /// <summary>The ID of the item to upload.</summary>
            [Google.Apis.Util.RequestParameterAttribute("itemId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ItemId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Chromewebstore.v1_1.Data.Item Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "chromewebstore/v1.1/items/{itemId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("itemId", new Google.Apis.Discovery.Parameter
                {
                    Name = "itemId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates an existing item.</summary>
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
        /// <param name="itemId">The ID of the item to upload.</param>
        /// <param name="stream">The stream to upload. See remarks for further information.</param>
        /// <param name="contentType">The content type of the stream to upload.</param>
        public virtual UpdateMediaUpload Update(Google.Apis.Chromewebstore.v1_1.Data.Item body, string itemId, System.IO.Stream stream, string contentType)
        {
            return new UpdateMediaUpload(service, body, itemId, stream, contentType);
        }

        /// <summary>Update media upload which supports resumable upload.</summary>
        public class UpdateMediaUpload : Google.Apis.Upload.ResumableUpload<Google.Apis.Chromewebstore.v1_1.Data.Item, Google.Apis.Chromewebstore.v1_1.Data.Item>
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

            /// <summary>The ID of the item to upload.</summary>
            [Google.Apis.Util.RequestParameterAttribute("itemId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ItemId { get; private set; }

            /// <summary>Constructs a new Update media upload instance.</summary>
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
            public UpdateMediaUpload(Google.Apis.Services.IClientService service, Google.Apis.Chromewebstore.v1_1.Data.Item body, string itemId, System.IO.Stream stream, string contentType)
                : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "chromewebstore/v1.1/items/{itemId}"), "PUT", stream, contentType)
            {
                ItemId = itemId;
                Body = body;
            }
        }
    }
}
namespace Google.Apis.Chromewebstore.v1_1.Data
{
    public class Item : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The CRX version of the item. If the projection is draft, then it is the draft's CRX version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crxVersion")]
        public virtual string CrxVersion { get; set; }

        /// <summary>Unique ID of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Detail human-readable status of the operation, in English only. Same error messages are displayed when you
        /// upload your app to the Chrome Web Store.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemError")]
        public virtual System.Collections.Generic.IList<ItemError> ItemError { get; set; }

        /// <summary>Identifies this resource as an Item. Value: the fixed string "chromewebstore#item".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Public key of this item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicKey")]
        public virtual string PublicKey { get; set; }

        /// <summary>
        /// Status of the operation. Possible values are: - \"FAILURE\" - \"IN_PROGRESS\" - \"NOT_FOUND\" - \"SUCCESS\"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uploadState")]
        public virtual string UploadState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Item2 : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of this item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("item_id")]
        public virtual string ItemId { get; set; }

        /// <summary>Static string value is always "chromewebstore#item".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The status code of this publish operation. It may contain multiple elements from the following list:
        /// NOT_AUTHORIZED, INVALID_DEVELOPER, DEVELOPER_NO_OWNERSHIP, DEVELOPER_SUSPENDED, ITEM_NOT_FOUND,
        /// ITEM_PENDING_REVIEW, ITEM_TAKEN_DOWN, PUBLISHER_SUSPENDED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual System.Collections.Generic.IList<string> Status { get; set; }

        /// <summary>Detailed human-comprehensible explanation of the status code above.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusDetail")]
        public virtual System.Collections.Generic.IList<string> StatusDetail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Error of the item</summary>
    public class ItemError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The error code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error_code")]
        public virtual string ErrorCode { get; set; }

        /// <summary>The human-readable detail message of the error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error_detail")]
        public virtual string ErrorDetail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PublishRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The target deploy percentage of the item. It's only useful for items with big user base.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployPercentage")]
        public virtual System.Nullable<int> DeployPercentage { get; set; }

        /// <summary>
        /// Optional. The caller request to exempt the review and directly publish because the update is within the list
        /// that we can automatically validate. The API will check if the exemption can be granted using real time data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reviewExemption")]
        public virtual System.Nullable<bool> ReviewExemption { get; set; }

        /// <summary>
        /// The publish target of this publish operation. This is the same as using publishTarget as a URL query
        /// parameter. The string value can either be target="trustedTesters" or target="default". The default value, if
        /// none is supplied, is target="default". Recommended usage is to use the URL query parameter to specificy the
        /// value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
