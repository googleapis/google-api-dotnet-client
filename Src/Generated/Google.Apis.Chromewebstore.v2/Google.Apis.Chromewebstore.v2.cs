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

namespace Google.Apis.Chromewebstore.v2
{
    /// <summary>The Chromewebstore Service.</summary>
    public class ChromewebstoreService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2";

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
            Media = new MediaResource(this);
            Publishers = new PublishersResource(this);
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

        /// <summary>Gets the Media resource.</summary>
        public virtual MediaResource Media { get; }

        /// <summary>Gets the Publishers resource.</summary>
        public virtual PublishersResource Publishers { get; }
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

        /// <summary>Upload a new package to an existing item.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Required. Name of the item to upload the new package to in the form
        /// `publishers/{publisherId}/items/{itemId}`
        /// </param>
        public virtual UploadRequest Upload(Google.Apis.Chromewebstore.v2.Data.UploadItemPackageRequest body, string name)
        {
            return new UploadRequest(this.service, body, name);
        }

        /// <summary>Upload a new package to an existing item.</summary>
        public class UploadRequest : ChromewebstoreBaseServiceRequest<Google.Apis.Chromewebstore.v2.Data.UploadItemPackageResponse>
        {
            /// <summary>Constructs a new Upload request.</summary>
            public UploadRequest(Google.Apis.Services.IClientService service, Google.Apis.Chromewebstore.v2.Data.UploadItemPackageRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. Name of the item to upload the new package to in the form
            /// `publishers/{publisherId}/items/{itemId}`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Chromewebstore.v2.Data.UploadItemPackageRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "upload";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/{+name}:upload";

            /// <summary>Initializes Upload parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^publishers/[^/]+/items/[^/]+$",
                });
            }
        }

        /// <summary>Upload a new package to an existing item.</summary>
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
        /// <param name="name">
        /// Required. Name of the item to upload the new package to in the form
        /// `publishers/{publisherId}/items/{itemId}`
        /// </param>
        /// <param name="stream">The stream to upload. See remarks for further information.</param>
        /// <param name="contentType">The content type of the stream to upload.</param>
        public virtual UploadMediaUpload Upload(Google.Apis.Chromewebstore.v2.Data.UploadItemPackageRequest body, string name, System.IO.Stream stream, string contentType)
        {
            return new UploadMediaUpload(service, body, name, stream, contentType);
        }

        /// <summary>Upload media upload which supports resumable upload.</summary>
        public class UploadMediaUpload : Google.Apis.Upload.ResumableUpload<Google.Apis.Chromewebstore.v2.Data.UploadItemPackageRequest, Google.Apis.Chromewebstore.v2.Data.UploadItemPackageResponse>
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
            /// Required. Name of the item to upload the new package to in the form
            /// `publishers/{publisherId}/items/{itemId}`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

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
            public UploadMediaUpload(Google.Apis.Services.IClientService service, Google.Apis.Chromewebstore.v2.Data.UploadItemPackageRequest body, string name, System.IO.Stream stream, string contentType)
                : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "v2/{+name}:upload"), "POST", stream, contentType)
            {
                Name = name;
                Body = body;
            }
        }
    }

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
            Items = new ItemsResource(service);
        }

        /// <summary>Gets the Items resource.</summary>
        public virtual ItemsResource Items { get; }

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

            /// <summary>
            /// Cancel the current active submission of an item if present. This can be used to cancel the review of a
            /// pending submission.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Name of the item to cancel the submission of in the form
            /// `publishers/{publisherId}/items/{itemId}`
            /// </param>
            public virtual CancelSubmissionRequest CancelSubmission(Google.Apis.Chromewebstore.v2.Data.CancelSubmissionRequest body, string name)
            {
                return new CancelSubmissionRequest(this.service, body, name);
            }

            /// <summary>
            /// Cancel the current active submission of an item if present. This can be used to cancel the review of a
            /// pending submission.
            /// </summary>
            public class CancelSubmissionRequest : ChromewebstoreBaseServiceRequest<Google.Apis.Chromewebstore.v2.Data.CancelSubmissionResponse>
            {
                /// <summary>Constructs a new CancelSubmission request.</summary>
                public CancelSubmissionRequest(Google.Apis.Services.IClientService service, Google.Apis.Chromewebstore.v2.Data.CancelSubmissionRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the item to cancel the submission of in the form
                /// `publishers/{publisherId}/items/{itemId}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Chromewebstore.v2.Data.CancelSubmissionRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "cancelSubmission";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}:cancelSubmission";

                /// <summary>Initializes CancelSubmission parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^publishers/[^/]+/items/[^/]+$",
                    });
                }
            }

            /// <summary>Fetch the status of an item.</summary>
            /// <param name="name">
            /// Required. Name of the item to retrieve the status of in the form
            /// `publishers/{publisherId}/items/{itemId}`
            /// </param>
            public virtual FetchStatusRequest FetchStatus(string name)
            {
                return new FetchStatusRequest(this.service, name);
            }

            /// <summary>Fetch the status of an item.</summary>
            public class FetchStatusRequest : ChromewebstoreBaseServiceRequest<Google.Apis.Chromewebstore.v2.Data.FetchItemStatusResponse>
            {
                /// <summary>Constructs a new FetchStatus request.</summary>
                public FetchStatusRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the item to retrieve the status of in the form
                /// `publishers/{publisherId}/items/{itemId}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "fetchStatus";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}:fetchStatus";

                /// <summary>Initializes FetchStatus parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^publishers/[^/]+/items/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Submit the item to be published in the store. The item will be submitted for review unless `skip_review`
            /// is set to true, or the item is staged from a previous submission with `publish_type` set to
            /// `STAGED_PUBLISH`.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Name of the item in the form `publishers/{publisherId}/items/{itemId}`
            /// </param>
            public virtual PublishRequest Publish(Google.Apis.Chromewebstore.v2.Data.PublishItemRequest body, string name)
            {
                return new PublishRequest(this.service, body, name);
            }

            /// <summary>
            /// Submit the item to be published in the store. The item will be submitted for review unless `skip_review`
            /// is set to true, or the item is staged from a previous submission with `publish_type` set to
            /// `STAGED_PUBLISH`.
            /// </summary>
            public class PublishRequest : ChromewebstoreBaseServiceRequest<Google.Apis.Chromewebstore.v2.Data.PublishItemResponse>
            {
                /// <summary>Constructs a new Publish request.</summary>
                public PublishRequest(Google.Apis.Services.IClientService service, Google.Apis.Chromewebstore.v2.Data.PublishItemRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Name of the item in the form `publishers/{publisherId}/items/{itemId}`</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Chromewebstore.v2.Data.PublishItemRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "publish";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}:publish";

                /// <summary>Initializes Publish parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^publishers/[^/]+/items/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Set a higher target deploy percentage for the item's published revision. This will be updated without
            /// the item being submitted for review. This is only available to items with over 10,000 seven-day active
            /// users.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Name of the item to update the published revision of in the form
            /// `publishers/{publisherId}/items/{itemId}`
            /// </param>
            public virtual SetPublishedDeployPercentageRequest SetPublishedDeployPercentage(Google.Apis.Chromewebstore.v2.Data.SetPublishedDeployPercentageRequest body, string name)
            {
                return new SetPublishedDeployPercentageRequest(this.service, body, name);
            }

            /// <summary>
            /// Set a higher target deploy percentage for the item's published revision. This will be updated without
            /// the item being submitted for review. This is only available to items with over 10,000 seven-day active
            /// users.
            /// </summary>
            public class SetPublishedDeployPercentageRequest : ChromewebstoreBaseServiceRequest<Google.Apis.Chromewebstore.v2.Data.SetPublishedDeployPercentageResponse>
            {
                /// <summary>Constructs a new SetPublishedDeployPercentage request.</summary>
                public SetPublishedDeployPercentageRequest(Google.Apis.Services.IClientService service, Google.Apis.Chromewebstore.v2.Data.SetPublishedDeployPercentageRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the item to update the published revision of in the form
                /// `publishers/{publisherId}/items/{itemId}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Chromewebstore.v2.Data.SetPublishedDeployPercentageRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "setPublishedDeployPercentage";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}:setPublishedDeployPercentage";

                /// <summary>Initializes SetPublishedDeployPercentage parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^publishers/[^/]+/items/[^/]+$",
                    });
                }
            }
        }
    }
}
namespace Google.Apis.Chromewebstore.v2.Data
{
    /// <summary>Request message for CancelSubmission.</summary>
    public class CancelSubmissionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for `CancelSubmission`.</summary>
    public class CancelSubmissionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Deployment information for a specific release channel. Used in requests to update deployment parameters.
    /// </summary>
    public class DeployInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The current deploy percentage for the release channel (nonnegative number between 0 and 100).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployPercentage")]
        public virtual System.Nullable<int> DeployPercentage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Deployment information for a specific release channel</summary>
    public class DistributionChannel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The extension version provided in the manifest of the uploaded package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crxVersion")]
        public virtual string CrxVersion { get; set; }

        /// <summary>
        /// The current deploy percentage for the release channel (nonnegative number between 0 and 100).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployPercentage")]
        public virtual System.Nullable<int> DeployPercentage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for `FetchItemStatus`.</summary>
    public class FetchItemStatusResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The ID of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemId")]
        public virtual string ItemId { get; set; }

        /// <summary>
        /// Output only. The state of the last async upload for an item. Only set when there has been an async upload
        /// for the item in the past 24 hours.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastAsyncUploadState")]
        public virtual string LastAsyncUploadState { get; set; }

        /// <summary>The name of the requested item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The public key of the item, which may be generated by the store.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicKey")]
        public virtual string PublicKey { get; set; }

        /// <summary>
        /// Output only. Status of the current published revision of the item. Will be unset if the item is not
        /// published.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishedItemRevisionStatus")]
        public virtual ItemRevisionStatus PublishedItemRevisionStatus { get; set; }

        /// <summary>
        /// Status of the item revision submitted to be published. Will be unset if the item has not been submitted for
        /// publishing since the last successful publish.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("submittedItemRevisionStatus")]
        public virtual ItemRevisionStatus SubmittedItemRevisionStatus { get; set; }

        /// <summary>
        /// If true, the item has been taken down for a policy violation. Check the developer dashboard for details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("takenDown")]
        public virtual System.Nullable<bool> TakenDown { get; set; }

        /// <summary>
        /// If true, the item has been warned for a policy violation and will be taken down if not resolved. Check the
        /// developer dashboard for details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warned")]
        public virtual System.Nullable<bool> Warned { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details on the status of an item revision.</summary>
    public class ItemRevisionStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Details on the package of the item</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distributionChannels")]
        public virtual System.Collections.Generic.IList<DistributionChannel> DistributionChannels { get; set; }

        /// <summary>Output only. Current state of the item</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for PublishItem.</summary>
    public class PublishItemRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Additional deploy information including the desired initial percentage rollout. Defaults to the
        /// current value saved in the developer dashboard if unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployInfos")]
        public virtual System.Collections.Generic.IList<DeployInfo> DeployInfos { get; set; }

        /// <summary>
        /// Optional. Use this to control if the item is published immediately on approval or staged for publishing in
        /// the future. Defaults to `DEFAULT_PUBLISH` if unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishType")]
        public virtual string PublishType { get; set; }

        /// <summary>
        /// Optional. Whether to attempt to skip item review. The API will validate if the item qualifies and return a
        /// validation error if the item requires review. Defaults to `false` if unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skipReview")]
        public virtual System.Nullable<bool> SkipReview { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for `PublishItem`.</summary>
    public class PublishItemResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The ID of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemId")]
        public virtual string ItemId { get; set; }

        /// <summary>The name of the item that was submitted</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The current state of the submission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for SetPublishedDeployPercentage.</summary>
    public class SetPublishedDeployPercentageRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Unscaled percentage value for the publised revision (nonnegative number between 0 and 100). It
        /// must be larger than the existing target percentage.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployPercentage")]
        public virtual System.Nullable<int> DeployPercentage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for `SetPublishedDeployPercentage`.</summary>
    public class SetPublishedDeployPercentageResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for UploadItemPackage.</summary>
    public class UploadItemPackageRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for `UploadItemPackage`.</summary>
    public class UploadItemPackageResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The extension version provided in the manifest of the uploaded package. This will not be set if the upload
        /// is still in progress (`upload_state` is `UPLOAD_IN_PROGRESS`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crxVersion")]
        public virtual string CrxVersion { get; set; }

        /// <summary>Output only. The ID of the item the package was uploaded to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemId")]
        public virtual string ItemId { get; set; }

        /// <summary>The name of the item the package was uploaded to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The state of the upload. If `upload_state` is `UPLOAD_IN_PROGRESS`, you can poll for updates
        /// using the fetchStatus method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uploadState")]
        public virtual string UploadState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
