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
    /// <summary>Information to read/write to blobstore2.</summary>
    public class Blobstore2Info : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The blob generation id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobGeneration")]
        public virtual System.Nullable<long> BlobGeneration { get; set; }

        /// <summary>The blob id, e.g., /blobstore/prod/playground/scotty</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobId")]
        public virtual string BlobId { get; set; }

        /// <summary>
        /// Read handle passed from Bigstore -&amp;gt; Scotty for a GCS download. This is a signed, serialized
        /// blobstore2.ReadHandle proto which must never be set outside of Bigstore, and is not applicable to non-GCS
        /// media downloads.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downloadReadHandle")]
        public virtual string DownloadReadHandle { get; set; }

        /// <summary>
        /// The blob read token. Needed to read blobs that have not been replicated. Might not be available until the
        /// final call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readToken")]
        public virtual string ReadToken { get; set; }

        /// <summary>
        /// Metadata passed from Blobstore -&amp;gt; Scotty for a new GCS upload. This is a signed, serialized
        /// blobstore2.BlobMetadataContainer proto which must never be consumed outside of Bigstore, and is not
        /// applicable to non-GCS media uploads.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uploadMetadataContainer")]
        public virtual string UploadMetadataContainer { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

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
    /// A sequence of media data references representing composite data. Introduced to support Bigstore composite
    /// objects. For details, visit http://go/bigstore-composites.
    /// </summary>
    public class CompositeMedia : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Blobstore v1 reference, set if reference_type is BLOBSTORE_REF This should be the byte representation of a
        /// blobstore.BlobRef. Since Blobstore is deprecating v1, use blobstore2_info instead. For now, any v2 blob will
        /// also be represented in this field as v1 BlobRef.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobRef")]
        public virtual string BlobRef { get; set; }

        /// <summary>Blobstore v2 info, set if reference_type is BLOBSTORE_REF and it refers to a v2 blob.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobstore2Info")]
        public virtual Blobstore2Info Blobstore2Info { get; set; }

        /// <summary>
        /// A binary data reference for a media download. Serves as a technology-agnostic binary reference in some
        /// Google infrastructure. This value is a serialized storage_cosmo.BinaryReference proto. Storing it as bytes
        /// is a hack to get around the fact that the cosmo proto (as well as others it includes) doesn't support
        /// JavaScript. This prevents us from including the actual type of this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cosmoBinaryReference")]
        public virtual string CosmoBinaryReference { get; set; }

        /// <summary>crc32.c hash for the payload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crc32cHash")]
        public virtual System.Nullable<long> Crc32cHash { get; set; }

        /// <summary>Media data, set if reference_type is INLINE</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inline")]
        public virtual string Inline { get; set; }

        /// <summary>Size of the data, in bytes</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("length")]
        public virtual System.Nullable<long> Length { get; set; }

        /// <summary>MD5 hash for the payload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("md5Hash")]
        public virtual string Md5Hash { get; set; }

        /// <summary>Reference to a TI Blob, set if reference_type is BIGSTORE_REF.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual ObjectId ObjectId { get; set; }

        /// <summary>Path to the data, set if reference_type is PATH</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>Describes what the field reference contains.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referenceType")]
        public virtual string ReferenceType { get; set; }

        /// <summary>SHA-1 hash for the payload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha1Hash")]
        public virtual string Sha1Hash { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Detailed Content-Type information from Scotty. The Content-Type of the media will typically be filled in by the
    /// header or Scotty's best_guess, but this extended information provides the backend with more information so that
    /// it can make a better decision if needed. This is only used on media upload requests from Scotty.
    /// </summary>
    public class ContentTypeInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Scotty's best guess of what the content type of the file is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bestGuess")]
        public virtual string BestGuess { get; set; }

        /// <summary>
        /// The content type of the file derived by looking at specific bytes (i.e. "magic bytes") of the actual file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fromBytes")]
        public virtual string FromBytes { get; set; }

        /// <summary>
        /// The content type of the file derived from the file extension of the original file name used by the client.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fromFileName")]
        public virtual string FromFileName { get; set; }

        /// <summary>
        /// The content type of the file as specified in the request headers, multipart headers, or RUPIO start request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fromHeader")]
        public virtual string FromHeader { get; set; }

        /// <summary>
        /// The content type of the file derived from the file extension of the URL path. The URL path is assumed to
        /// represent a file name (which is typically only true for agents that are providing a REST API).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fromUrlPath")]
        public virtual string FromUrlPath { get; set; }

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

    /// <summary>
    /// Backend response for a Diff get checksums response. For details on the Scotty Diff protocol, visit
    /// http://go/scotty-diff-protocol.
    /// </summary>
    public class DiffChecksumsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Exactly one of these fields must be populated. If checksums_location is filled, the server will return the
        /// corresponding contents to the user. If object_location is filled, the server will calculate the checksums
        /// based on the content there and return that to the user. For details on the format of the checksums, see
        /// http://go/scotty-diff-protocol.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checksumsLocation")]
        public virtual CompositeMedia ChecksumsLocation { get; set; }

        /// <summary>The chunk size of checksums. Must be a multiple of 256KB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chunkSizeBytes")]
        public virtual System.Nullable<long> ChunkSizeBytes { get; set; }

        /// <summary>If set, calculate the checksums based on the contents and return them to the caller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectLocation")]
        public virtual CompositeMedia ObjectLocation { get; set; }

        /// <summary>The total size of the server object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectSizeBytes")]
        public virtual System.Nullable<long> ObjectSizeBytes { get; set; }

        /// <summary>The object version of the object the checksums are being returned for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectVersion")]
        public virtual string ObjectVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Backend response for a Diff download response. For details on the Scotty Diff protocol, visit
    /// http://go/scotty-diff-protocol.
    /// </summary>
    public class DiffDownloadResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The original object location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectLocation")]
        public virtual CompositeMedia ObjectLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Diff upload request. For details on the Scotty Diff protocol, visit http://go/scotty-diff-protocol.
    /// </summary>
    public class DiffUploadRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The location of the checksums for the new object. Agents must clone the object located here, as the upload
        /// server will delete the contents once a response is received. For details on the format of the checksums, see
        /// http://go/scotty-diff-protocol.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checksumsInfo")]
        public virtual CompositeMedia ChecksumsInfo { get; set; }

        /// <summary>
        /// The location of the new object. Agents must clone the object located here, as the upload server will delete
        /// the contents once a response is received.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectInfo")]
        public virtual CompositeMedia ObjectInfo { get; set; }

        /// <summary>
        /// The object version of the object that is the base version the incoming diff script will be applied to. This
        /// field will always be filled in.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectVersion")]
        public virtual string ObjectVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Backend response for a Diff upload request. For details on the Scotty Diff protocol, visit
    /// http://go/scotty-diff-protocol.
    /// </summary>
    public class DiffUploadResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The object version of the object at the server. Must be included in the end notification response. The
        /// version in the end notification response must correspond to the new version of the object that is now stored
        /// at the server, after the upload.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectVersion")]
        public virtual string ObjectVersion { get; set; }

        /// <summary>
        /// The location of the original file for a diff upload request. Must be filled in if responding to an upload
        /// start notification.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalObject")]
        public virtual CompositeMedia OriginalObject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Backend response for a Diff get version response. For details on the Scotty Diff protocol, visit
    /// http://go/scotty-diff-protocol.
    /// </summary>
    public class DiffVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The total size of the server object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectSizeBytes")]
        public virtual System.Nullable<long> ObjectSizeBytes { get; set; }

        /// <summary>The version of the object stored at the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectVersion")]
        public virtual string ObjectVersion { get; set; }

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

    /// <summary>Parameters specific to media downloads.</summary>
    public class DownloadParameters : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A boolean to be returned in the response to Scotty. Allows/disallows gzip encoding of the payload content
        /// when the server thinks it's advantageous (hence, does not guarantee compression) which allows Scotty to GZip
        /// the response to the client.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowGzipCompression")]
        public virtual System.Nullable<bool> AllowGzipCompression { get; set; }

        /// <summary>
        /// Determining whether or not Apiary should skip the inclusion of any Content-Range header on its response to
        /// Scotty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoreRange")]
        public virtual System.Nullable<bool> IgnoreRange { get; set; }

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

    /// <summary>A reference to data stored on the filesystem, on GFS or in blobstore.</summary>
    public class Media : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Deprecated, use one of explicit hash type fields instead. Algorithm used for calculating the hash. As of
        /// 2011/01/21, "MD5" is the only possible value for this field. New values may be added at any time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("algorithm")]
        public virtual string Algorithm { get; set; }

        /// <summary>Use object_id instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigstoreObjectRef")]
        public virtual string BigstoreObjectRef { get; set; }

        /// <summary>
        /// Blobstore v1 reference, set if reference_type is BLOBSTORE_REF This should be the byte representation of a
        /// blobstore.BlobRef. Since Blobstore is deprecating v1, use blobstore2_info instead. For now, any v2 blob will
        /// also be represented in this field as v1 BlobRef.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobRef")]
        public virtual string BlobRef { get; set; }

        /// <summary>Blobstore v2 info, set if reference_type is BLOBSTORE_REF and it refers to a v2 blob.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobstore2Info")]
        public virtual Blobstore2Info Blobstore2Info { get; set; }

        /// <summary>
        /// A composite media composed of one or more media objects, set if reference_type is COMPOSITE_MEDIA. The media
        /// length field must be set to the sum of the lengths of all composite media objects. Note: All composite media
        /// must have length specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compositeMedia")]
        public virtual System.Collections.Generic.IList<CompositeMedia> CompositeMedia { get; set; }

        /// <summary>MIME type of the data</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentType")]
        public virtual string ContentType { get; set; }

        /// <summary>Extended content type information provided for Scotty uploads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentTypeInfo")]
        public virtual ContentTypeInfo ContentTypeInfo { get; set; }

        /// <summary>
        /// A binary data reference for a media download. Serves as a technology-agnostic binary reference in some
        /// Google infrastructure. This value is a serialized storage_cosmo.BinaryReference proto. Storing it as bytes
        /// is a hack to get around the fact that the cosmo proto (as well as others it includes) doesn't support
        /// JavaScript. This prevents us from including the actual type of this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cosmoBinaryReference")]
        public virtual string CosmoBinaryReference { get; set; }

        /// <summary>
        /// For Scotty Uploads: Scotty-provided hashes for uploads For Scotty Downloads: (WARNING: DO NOT USE WITHOUT
        /// PERMISSION FROM THE SCOTTY TEAM.) A Hash provided by the agent to be used to verify the data being
        /// downloaded. Currently only supported for inline payloads. Further, only crc32c_hash is currently supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crc32cHash")]
        public virtual System.Nullable<long> Crc32cHash { get; set; }

        /// <summary>Set if reference_type is DIFF_CHECKSUMS_RESPONSE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diffChecksumsResponse")]
        public virtual DiffChecksumsResponse DiffChecksumsResponse { get; set; }

        /// <summary>Set if reference_type is DIFF_DOWNLOAD_RESPONSE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diffDownloadResponse")]
        public virtual DiffDownloadResponse DiffDownloadResponse { get; set; }

        /// <summary>Set if reference_type is DIFF_UPLOAD_REQUEST.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diffUploadRequest")]
        public virtual DiffUploadRequest DiffUploadRequest { get; set; }

        /// <summary>Set if reference_type is DIFF_UPLOAD_RESPONSE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diffUploadResponse")]
        public virtual DiffUploadResponse DiffUploadResponse { get; set; }

        /// <summary>Set if reference_type is DIFF_VERSION_RESPONSE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diffVersionResponse")]
        public virtual DiffVersionResponse DiffVersionResponse { get; set; }

        /// <summary>Parameters for a media download.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downloadParameters")]
        public virtual DownloadParameters DownloadParameters { get; set; }

        /// <summary>Original file name</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filename")]
        public virtual string Filename { get; set; }

        /// <summary>
        /// Deprecated, use one of explicit hash type fields instead. These two hash related fields will only be
        /// populated on Scotty based media uploads and will contain the content of the hash group in the
        /// NotificationRequest:
        /// http://cs/#google3/blobstore2/api/scotty/service/proto/upload_listener.proto&amp;amp;q=class:Hash Hex
        /// encoded hash value of the uploaded media.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hash")]
        public virtual string Hash { get; set; }

        /// <summary>
        /// For Scotty uploads only. If a user sends a hash code and the backend has requested that Scotty verify the
        /// upload against the client hash, Scotty will perform the check on behalf of the backend and will reject it if
        /// the hashes don't match. This is set to true if Scotty performed this verification.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hashVerified")]
        public virtual System.Nullable<bool> HashVerified { get; set; }

        /// <summary>Media data, set if reference_type is INLINE</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inline")]
        public virtual string Inline { get; set; }

        /// <summary>
        /// |is_potential_retry| is set false only when Scotty is certain that it has not sent the request before. When
        /// a client resumes an upload, this field must be set true in agent calls, because Scotty cannot be certain
        /// that it has never sent the request before due to potential failure in the session state persistence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isPotentialRetry")]
        public virtual System.Nullable<bool> IsPotentialRetry { get; set; }

        /// <summary>Size of the data, in bytes</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("length")]
        public virtual System.Nullable<long> Length { get; set; }

        /// <summary>Scotty-provided MD5 hash for an upload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("md5Hash")]
        public virtual string Md5Hash { get; set; }

        /// <summary>Media id to forward to the operation GetMedia. Can be set if reference_type is GET_MEDIA.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mediaId")]
        public virtual string MediaId { get; set; }

        /// <summary>Reference to a TI Blob, set if reference_type is BIGSTORE_REF.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual ObjectId ObjectId { get; set; }

        /// <summary>Path to the data, set if reference_type is PATH</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>Describes what the field reference contains.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referenceType")]
        public virtual string ReferenceType { get; set; }

        /// <summary>Scotty-provided SHA1 hash for an upload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha1Hash")]
        public virtual string Sha1Hash { get; set; }

        /// <summary>Scotty-provided SHA256 hash for an upload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha256Hash")]
        public virtual string Sha256Hash { get; set; }

        /// <summary>Time at which the media data was last updated, in milliseconds since UNIX epoch</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestamp")]
        public virtual System.Nullable<ulong> Timestamp { get; set; }

        /// <summary>A unique fingerprint/version id for the media data</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Extra information added to operations that support Scotty media requests.</summary>
    public class MediaRequestInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of current bytes uploaded or downloaded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentBytes")]
        public virtual System.Nullable<long> CurrentBytes { get; set; }

        /// <summary>
        /// Data to be copied to backend requests. Custom data is returned to Scotty in the agent_state field, which
        /// Scotty will then provide in subsequent upload notifications.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customData")]
        public virtual string CustomData { get; set; }

        /// <summary>
        /// Set if the http request info is diff encoded. The value of this field is the version number of the base
        /// revision. This is corresponding to Apiary's mediaDiffObjectVersion
        /// (//depot/google3/java/com/google/api/server/media/variable/DiffObjectVersionVariable.java). See
        /// go/esf-scotty-diff-upload for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diffObjectVersion")]
        public virtual string DiffObjectVersion { get; set; }

        /// <summary>
        /// The existence of the final_status field indicates that this is the last call to the agent for this
        /// request_id. http://google3/uploader/agent/scotty_agent.proto?l=737&amp;amp;rcl=347601929
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finalStatus")]
        public virtual System.Nullable<int> FinalStatus { get; set; }

        /// <summary>The type of notification received from Scotty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationType")]
        public virtual string NotificationType { get; set; }

        /// <summary>
        /// The physical headers provided by RequestReceivedParameters in Scotty request. type is
        /// uploader_service.KeyValuePairs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("physicalHeaders")]
        public virtual string PhysicalHeaders { get; set; }

        /// <summary>The Scotty request ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>
        /// The partition of the Scotty server handling this request. type is
        /// uploader_service.RequestReceivedParamsServingInfo
        /// LINT.IfChange(request_received_params_serving_info_annotations) LINT.ThenChange()
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestReceivedParamsServingInfo")]
        public virtual string RequestReceivedParamsServingInfo { get; set; }

        /// <summary>The total size of the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalBytes")]
        public virtual System.Nullable<long> TotalBytes { get; set; }

        /// <summary>Whether the total bytes field contains an estimated data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalBytesIsEstimated")]
        public virtual System.Nullable<bool> TotalBytesIsEstimated { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This is a copy of the tech.blob.ObjectId proto, which could not be used directly here due to transitive closure
    /// issues with JavaScript support; see http://b/8801763.
    /// </summary>
    public class ObjectId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the bucket to which this object belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketName")]
        public virtual string BucketName { get; set; }

        /// <summary>
        /// Generation of the object. Generations are monotonically increasing across writes, allowing them to be be
        /// compared to determine which generation is newer. If this is omitted in a request, then you are requesting
        /// the live object. See http://go/bigstore-versions
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generation")]
        public virtual System.Nullable<long> Generation { get; set; }

        /// <summary>The name of the object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectName")]
        public virtual string ObjectName { get; set; }

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
        /// <summary>Reference to the uploaded media.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blob")]
        public virtual Media Blob { get; set; }

        /// <summary>Info about the media upload request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mediaRequestInfo")]
        public virtual MediaRequestInfo MediaRequestInfo { get; set; }

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
