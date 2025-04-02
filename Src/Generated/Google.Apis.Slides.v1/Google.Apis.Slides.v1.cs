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

namespace Google.Apis.Slides.v1
{
    /// <summary>The Slides Service.</summary>
    public class SlidesService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public SlidesService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public SlidesService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Presentations = new PresentationsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://slides.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://slides.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "slides";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Google Slides API.</summary>
        public class Scope
        {
            /// <summary>See, edit, create, and delete all of your Google Drive files</summary>
            public static string Drive = "https://www.googleapis.com/auth/drive";

            /// <summary>
            /// See, edit, create, and delete only the specific Google Drive files you use with this app
            /// </summary>
            public static string DriveFile = "https://www.googleapis.com/auth/drive.file";

            /// <summary>See and download all your Google Drive files</summary>
            public static string DriveReadonly = "https://www.googleapis.com/auth/drive.readonly";

            /// <summary>See, edit, create, and delete all your Google Slides presentations</summary>
            public static string Presentations = "https://www.googleapis.com/auth/presentations";

            /// <summary>See all your Google Slides presentations</summary>
            public static string PresentationsReadonly = "https://www.googleapis.com/auth/presentations.readonly";

            /// <summary>See, edit, create, and delete all your Google Sheets spreadsheets</summary>
            public static string Spreadsheets = "https://www.googleapis.com/auth/spreadsheets";

            /// <summary>See all your Google Sheets spreadsheets</summary>
            public static string SpreadsheetsReadonly = "https://www.googleapis.com/auth/spreadsheets.readonly";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Google Slides API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, create, and delete all of your Google Drive files</summary>
            public const string Drive = "https://www.googleapis.com/auth/drive";

            /// <summary>
            /// See, edit, create, and delete only the specific Google Drive files you use with this app
            /// </summary>
            public const string DriveFile = "https://www.googleapis.com/auth/drive.file";

            /// <summary>See and download all your Google Drive files</summary>
            public const string DriveReadonly = "https://www.googleapis.com/auth/drive.readonly";

            /// <summary>See, edit, create, and delete all your Google Slides presentations</summary>
            public const string Presentations = "https://www.googleapis.com/auth/presentations";

            /// <summary>See all your Google Slides presentations</summary>
            public const string PresentationsReadonly = "https://www.googleapis.com/auth/presentations.readonly";

            /// <summary>See, edit, create, and delete all your Google Sheets spreadsheets</summary>
            public const string Spreadsheets = "https://www.googleapis.com/auth/spreadsheets";

            /// <summary>See all your Google Sheets spreadsheets</summary>
            public const string SpreadsheetsReadonly = "https://www.googleapis.com/auth/spreadsheets.readonly";
        }

        /// <summary>Gets the Presentations resource.</summary>
        public virtual PresentationsResource Presentations { get; }
    }

    /// <summary>A base abstract class for Slides requests.</summary>
    public abstract class SlidesBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new SlidesBaseServiceRequest instance.</summary>
        protected SlidesBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Slides parameter list.</summary>
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

    /// <summary>The "presentations" collection of methods.</summary>
    public class PresentationsResource
    {
        private const string Resource = "presentations";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PresentationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Pages = new PagesResource(service);
        }

        /// <summary>Gets the Pages resource.</summary>
        public virtual PagesResource Pages { get; }

        /// <summary>The "pages" collection of methods.</summary>
        public class PagesResource
        {
            private const string Resource = "pages";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public PagesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Gets the latest version of the specified page in the presentation.</summary>
            /// <param name="presentationId">The ID of the presentation to retrieve.</param>
            /// <param name="pageObjectId">The object ID of the page to retrieve.</param>
            public virtual GetRequest Get(string presentationId, string pageObjectId)
            {
                return new GetRequest(this.service, presentationId, pageObjectId);
            }

            /// <summary>Gets the latest version of the specified page in the presentation.</summary>
            public class GetRequest : SlidesBaseServiceRequest<Google.Apis.Slides.v1.Data.Page>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string presentationId, string pageObjectId) : base(service)
                {
                    PresentationId = presentationId;
                    PageObjectId = pageObjectId;
                    InitParameters();
                }

                /// <summary>The ID of the presentation to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("presentationId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PresentationId { get; private set; }

                /// <summary>The object ID of the page to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageObjectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PageObjectId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/presentations/{presentationId}/pages/{pageObjectId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("presentationId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "presentationId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageObjectId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageObjectId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Generates a thumbnail of the latest version of the specified page in the presentation and returns a URL
            /// to the thumbnail image. This request counts as an [expensive read request](/slides/limits) for quota
            /// purposes.
            /// </summary>
            /// <param name="presentationId">The ID of the presentation to retrieve.</param>
            /// <param name="pageObjectId">The object ID of the page whose thumbnail to retrieve.</param>
            public virtual GetThumbnailRequest GetThumbnail(string presentationId, string pageObjectId)
            {
                return new GetThumbnailRequest(this.service, presentationId, pageObjectId);
            }

            /// <summary>
            /// Generates a thumbnail of the latest version of the specified page in the presentation and returns a URL
            /// to the thumbnail image. This request counts as an [expensive read request](/slides/limits) for quota
            /// purposes.
            /// </summary>
            public class GetThumbnailRequest : SlidesBaseServiceRequest<Google.Apis.Slides.v1.Data.Thumbnail>
            {
                /// <summary>Constructs a new GetThumbnail request.</summary>
                public GetThumbnailRequest(Google.Apis.Services.IClientService service, string presentationId, string pageObjectId) : base(service)
                {
                    PresentationId = presentationId;
                    PageObjectId = pageObjectId;
                    InitParameters();
                }

                /// <summary>The ID of the presentation to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("presentationId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PresentationId { get; private set; }

                /// <summary>The object ID of the page whose thumbnail to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageObjectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PageObjectId { get; private set; }

                /// <summary>
                /// The optional mime type of the thumbnail image. If you don't specify the mime type, the mime type
                /// defaults to PNG.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("thumbnailProperties.mimeType", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ThumbnailPropertiesMimeTypeEnum> ThumbnailPropertiesMimeType { get; set; }

                /// <summary>
                /// The optional mime type of the thumbnail image. If you don't specify the mime type, the mime type
                /// defaults to PNG.
                /// </summary>
                public enum ThumbnailPropertiesMimeTypeEnum
                {
                    /// <summary>The default mime type.</summary>
                    [Google.Apis.Util.StringValueAttribute("PNG")]
                    PNG = 0,
                }

                /// <summary>
                /// The optional thumbnail image size. If you don't specify the size, the server chooses a default size
                /// of the image.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("thumbnailProperties.thumbnailSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ThumbnailPropertiesThumbnailSizeEnum> ThumbnailPropertiesThumbnailSize { get; set; }

                /// <summary>
                /// The optional thumbnail image size. If you don't specify the size, the server chooses a default size
                /// of the image.
                /// </summary>
                public enum ThumbnailPropertiesThumbnailSizeEnum
                {
                    /// <summary>
                    /// The default thumbnail image size. The unspecified thumbnail size implies that the server chooses
                    /// the size of the image in a way that might vary in the future.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("THUMBNAIL_SIZE_UNSPECIFIED")]
                    THUMBNAILSIZEUNSPECIFIED = 0,

                    /// <summary>The thumbnail image width of 1600px.</summary>
                    [Google.Apis.Util.StringValueAttribute("LARGE")]
                    LARGE = 1,

                    /// <summary>The thumbnail image width of 800px.</summary>
                    [Google.Apis.Util.StringValueAttribute("MEDIUM")]
                    MEDIUM = 2,

                    /// <summary>The thumbnail image width of 200px.</summary>
                    [Google.Apis.Util.StringValueAttribute("SMALL")]
                    SMALL = 3,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getThumbnail";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/presentations/{presentationId}/pages/{pageObjectId}/thumbnail";

                /// <summary>Initializes GetThumbnail parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("presentationId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "presentationId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageObjectId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageObjectId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("thumbnailProperties.mimeType", new Google.Apis.Discovery.Parameter
                    {
                        Name = "thumbnailProperties.mimeType",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("thumbnailProperties.thumbnailSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "thumbnailProperties.thumbnailSize",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>
        /// Applies one or more updates to the presentation. Each request is validated before being applied. If any
        /// request is not valid, then the entire request will fail and nothing will be applied. Some requests have
        /// replies to give you some information about how they are applied. Other requests do not need to return
        /// information; these each return an empty reply. The order of replies matches that of the requests. For
        /// example, suppose you call batchUpdate with four updates, and only the third one returns information. The
        /// response would have two empty replies: the reply to the third request, and another empty reply, in that
        /// order. Because other users may be editing the presentation, the presentation might not exactly reflect your
        /// changes: your changes may be altered with respect to collaborator changes. If there are no collaborators,
        /// the presentation should reflect your changes. In any case, the updates in your request are guaranteed to be
        /// applied together atomically.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="presentationId">The presentation to apply the updates to.</param>
        public virtual BatchUpdateRequest BatchUpdate(Google.Apis.Slides.v1.Data.BatchUpdatePresentationRequest body, string presentationId)
        {
            return new BatchUpdateRequest(this.service, body, presentationId);
        }

        /// <summary>
        /// Applies one or more updates to the presentation. Each request is validated before being applied. If any
        /// request is not valid, then the entire request will fail and nothing will be applied. Some requests have
        /// replies to give you some information about how they are applied. Other requests do not need to return
        /// information; these each return an empty reply. The order of replies matches that of the requests. For
        /// example, suppose you call batchUpdate with four updates, and only the third one returns information. The
        /// response would have two empty replies: the reply to the third request, and another empty reply, in that
        /// order. Because other users may be editing the presentation, the presentation might not exactly reflect your
        /// changes: your changes may be altered with respect to collaborator changes. If there are no collaborators,
        /// the presentation should reflect your changes. In any case, the updates in your request are guaranteed to be
        /// applied together atomically.
        /// </summary>
        public class BatchUpdateRequest : SlidesBaseServiceRequest<Google.Apis.Slides.v1.Data.BatchUpdatePresentationResponse>
        {
            /// <summary>Constructs a new BatchUpdate request.</summary>
            public BatchUpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Slides.v1.Data.BatchUpdatePresentationRequest body, string presentationId) : base(service)
            {
                PresentationId = presentationId;
                Body = body;
                InitParameters();
            }

            /// <summary>The presentation to apply the updates to.</summary>
            [Google.Apis.Util.RequestParameterAttribute("presentationId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PresentationId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Slides.v1.Data.BatchUpdatePresentationRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "batchUpdate";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/presentations/{presentationId}:batchUpdate";

            /// <summary>Initializes BatchUpdate parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("presentationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "presentationId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Creates a blank presentation using the title given in the request. If a `presentationId` is provided, it is
        /// used as the ID of the new presentation. Otherwise, a new ID is generated. Other fields in the request,
        /// including any provided content, are ignored. Returns the created presentation.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.Slides.v1.Data.Presentation body)
        {
            return new CreateRequest(this.service, body);
        }

        /// <summary>
        /// Creates a blank presentation using the title given in the request. If a `presentationId` is provided, it is
        /// used as the ID of the new presentation. Otherwise, a new ID is generated. Other fields in the request,
        /// including any provided content, are ignored. Returns the created presentation.
        /// </summary>
        public class CreateRequest : SlidesBaseServiceRequest<Google.Apis.Slides.v1.Data.Presentation>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Slides.v1.Data.Presentation body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Slides.v1.Data.Presentation Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/presentations";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Gets the latest version of the specified presentation.</summary>
        /// <param name="presentationId">The ID of the presentation to retrieve.</param>
        public virtual GetRequest Get(string presentationId)
        {
            return new GetRequest(this.service, presentationId);
        }

        /// <summary>Gets the latest version of the specified presentation.</summary>
        public class GetRequest : SlidesBaseServiceRequest<Google.Apis.Slides.v1.Data.Presentation>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string presentationId) : base(service)
            {
                PresentationId = presentationId;
                InitParameters();
            }

            /// <summary>The ID of the presentation to retrieve.</summary>
            [Google.Apis.Util.RequestParameterAttribute("presentationId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PresentationId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/presentations/{+presentationId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("presentationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "presentationId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
            }
        }
    }
}
namespace Google.Apis.Slides.v1.Data
{
    /// <summary>
    /// AffineTransform uses a 3x3 matrix with an implied last row of [ 0 0 1 ] to transform source coordinates (x,y)
    /// into destination coordinates (x', y') according to: x' x = shear_y scale_y translate_y 1 [ 1 ] After
    /// transformation, x' = scale_x * x + shear_x * y + translate_x; y' = scale_y * y + shear_y * x + translate_y; This
    /// message is therefore composed of these six matrix elements.
    /// </summary>
    public class AffineTransform : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The X coordinate scaling element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scaleX")]
        public virtual System.Nullable<double> ScaleX { get; set; }

        /// <summary>The Y coordinate scaling element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scaleY")]
        public virtual System.Nullable<double> ScaleY { get; set; }

        /// <summary>The X coordinate shearing element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shearX")]
        public virtual System.Nullable<double> ShearX { get; set; }

        /// <summary>The Y coordinate shearing element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shearY")]
        public virtual System.Nullable<double> ShearY { get; set; }

        /// <summary>The X coordinate translation element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("translateX")]
        public virtual System.Nullable<double> TranslateX { get; set; }

        /// <summary>The Y coordinate translation element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("translateY")]
        public virtual System.Nullable<double> TranslateY { get; set; }

        /// <summary>The units for translate elements.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A TextElement kind that represents auto text.</summary>
    public class AutoText : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The rendered content of this auto text, if available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>The styling applied to this auto text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("style")]
        public virtual TextStyle Style { get; set; }

        /// <summary>The type of this auto text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The autofit properties of a Shape. This property is only set for shapes that allow text.</summary>
    public class Autofit : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The autofit type of the shape. If the autofit type is AUTOFIT_TYPE_UNSPECIFIED, the autofit type is
        /// inherited from a parent placeholder if it exists. The field is automatically set to NONE if a request is
        /// made that might affect text fitting within its bounding text box. In this case, the font_scale is applied to
        /// the font_size and the line_spacing_reduction is applied to the line_spacing. Both properties are also reset
        /// to default values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autofitType")]
        public virtual string AutofitType { get; set; }

        /// <summary>
        /// The font scale applied to the shape. For shapes with autofit_type NONE or SHAPE_AUTOFIT, this value is the
        /// default value of 1. For TEXT_AUTOFIT, this value multiplied by the font_size gives the font size that's
        /// rendered in the editor. This property is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fontScale")]
        public virtual System.Nullable<float> FontScale { get; set; }

        /// <summary>
        /// The line spacing reduction applied to the shape. For shapes with autofit_type NONE or SHAPE_AUTOFIT, this
        /// value is the default value of 0. For TEXT_AUTOFIT, this value subtracted from the line_spacing gives the
        /// line spacing that's rendered in the editor. This property is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineSpacingReduction")]
        public virtual System.Nullable<float> LineSpacingReduction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for PresentationsService.BatchUpdatePresentation.</summary>
    public class BatchUpdatePresentationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of updates to apply to the presentation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<Request> Requests { get; set; }

        /// <summary>Provides control over how write requests are executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writeControl")]
        public virtual WriteControl WriteControl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message from a batch update.</summary>
    public class BatchUpdatePresentationResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The presentation the updates were applied to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("presentationId")]
        public virtual string PresentationId { get; set; }

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

    /// <summary>Describes the bullet of a paragraph.</summary>
    public class Bullet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The paragraph specific text style applied to this bullet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bulletStyle")]
        public virtual TextStyle BulletStyle { get; set; }

        /// <summary>The rendered bullet glyph for this paragraph.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("glyph")]
        public virtual string Glyph { get; set; }

        /// <summary>The ID of the list this paragraph belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listId")]
        public virtual string ListId { get; set; }

        /// <summary>The nesting level of this paragraph in the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nestingLevel")]
        public virtual System.Nullable<int> NestingLevel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The palette of predefined colors for a page.</summary>
    public class ColorScheme : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ThemeColorType and corresponding concrete color pairs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colors")]
        public virtual System.Collections.Generic.IList<ThemeColorPair> Colors { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A color and position in a gradient band.</summary>
    public class ColorStop : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The alpha value of this color in the gradient band. Defaults to 1.0, fully opaque.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alpha")]
        public virtual System.Nullable<float> Alpha { get; set; }

        /// <summary>The color of the gradient stop.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual OpaqueColor Color { get; set; }

        /// <summary>
        /// The relative position of the color stop in the gradient band measured in percentage. The value should be in
        /// the interval [0.0, 1.0].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("position")]
        public virtual System.Nullable<float> Position { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Creates an image.</summary>
    public class CreateImageRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The element properties for the image. When the aspect ratio of the provided size does not match the image
        /// aspect ratio, the image is scaled and centered with respect to the size in order to maintain the aspect
        /// ratio. The provided transform is applied after this operation. The PageElementProperties.size property is
        /// optional. If you don't specify the size, the default size of the image is used. The
        /// PageElementProperties.transform property is optional. If you don't specify a transform, the image will be
        /// placed at the top-left corner of the page.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("elementProperties")]
        public virtual PageElementProperties ElementProperties { get; set; }

        /// <summary>
        /// A user-supplied object ID. If you specify an ID, it must be unique among all pages and page elements in the
        /// presentation. The ID must start with an alphanumeric character or an underscore (matches regex
        /// `[a-zA-Z0-9_]`); remaining characters may include those as well as a hyphen or colon (matches regex
        /// `[a-zA-Z0-9_-:]`). The length of the ID must not be less than 5 or greater than 50. If you don't specify an
        /// ID, a unique one is generated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>
        /// The image URL. The image is fetched once at insertion time and a copy is stored for display inside the
        /// presentation. Images must be less than 50 MB in size, can't exceed 25 megapixels, and must be in one of PNG,
        /// JPEG, or GIF formats. The provided URL must be publicly accessible and up to 2 KB in length. The URL is
        /// saved with the image, and exposed through the Image.source_url field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of creating an image.</summary>
    public class CreateImageResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The object ID of the created image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Creates a line.</summary>
    public class CreateLineRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The category of the line to be created. The exact line type created is determined based on the category and
        /// how it's routed to connect to other page elements. If you specify both a `category` and a `line_category`,
        /// the `category` takes precedence. If you do not specify a value for `category`, but specify a value for
        /// `line_category`, then the specified `line_category` value is used. If you do not specify either, then
        /// STRAIGHT is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>The element properties for the line.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("elementProperties")]
        public virtual PageElementProperties ElementProperties { get; set; }

        /// <summary>
        /// The category of the line to be created. *Deprecated*: use `category` instead. The exact line type created is
        /// determined based on the category and how it's routed to connect to other page elements. If you specify both
        /// a `category` and a `line_category`, the `category` takes precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineCategory")]
        public virtual string LineCategory { get; set; }

        /// <summary>
        /// A user-supplied object ID. If you specify an ID, it must be unique among all pages and page elements in the
        /// presentation. The ID must start with an alphanumeric character or an underscore (matches regex
        /// `[a-zA-Z0-9_]`); remaining characters may include those as well as a hyphen or colon (matches regex
        /// `[a-zA-Z0-9_-:]`). The length of the ID must not be less than 5 or greater than 50. If you don't specify an
        /// ID, a unique one is generated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of creating a line.</summary>
    public class CreateLineResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The object ID of the created line.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Creates bullets for all of the paragraphs that overlap with the given text index range. The nesting level of
    /// each paragraph will be determined by counting leading tabs in front of each paragraph. To avoid excess space
    /// between the bullet and the corresponding paragraph, these leading tabs are removed by this request. This may
    /// change the indices of parts of the text. If the paragraph immediately before paragraphs being updated is in a
    /// list with a matching preset, the paragraphs being updated are added to that preceding list.
    /// </summary>
    public class CreateParagraphBulletsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The kinds of bullet glyphs to be used. Defaults to the `BULLET_DISC_CIRCLE_SQUARE` preset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bulletPreset")]
        public virtual string BulletPreset { get; set; }

        /// <summary>
        /// The optional table cell location if the text to be modified is in a table cell. If present, the object_id
        /// must refer to a table.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cellLocation")]
        public virtual TableCellLocation CellLocation { get; set; }

        /// <summary>The object ID of the shape or table containing the text to add bullets to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>The range of text to apply the bullet presets to, based on TextElement indexes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textRange")]
        public virtual Range TextRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Creates a new shape.</summary>
    public class CreateShapeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The element properties for the shape.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("elementProperties")]
        public virtual PageElementProperties ElementProperties { get; set; }

        /// <summary>
        /// A user-supplied object ID. If you specify an ID, it must be unique among all pages and page elements in the
        /// presentation. The ID must start with an alphanumeric character or an underscore (matches regex
        /// `[a-zA-Z0-9_]`); remaining characters may include those as well as a hyphen or colon (matches regex
        /// `[a-zA-Z0-9_-:]`). The length of the ID must not be less than 5 or greater than 50. If empty, a unique
        /// identifier will be generated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>The shape type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shapeType")]
        public virtual string ShapeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of creating a shape.</summary>
    public class CreateShapeResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The object ID of the created shape.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Creates an embedded Google Sheets chart. NOTE: Chart creation requires at least one of the
    /// spreadsheets.readonly, spreadsheets, drive.readonly, drive.file, or drive OAuth scopes.
    /// </summary>
    public class CreateSheetsChartRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the specific chart in the Google Sheets spreadsheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chartId")]
        public virtual System.Nullable<int> ChartId { get; set; }

        /// <summary>
        /// The element properties for the chart. When the aspect ratio of the provided size does not match the chart
        /// aspect ratio, the chart is scaled and centered with respect to the size in order to maintain aspect ratio.
        /// The provided transform is applied after this operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("elementProperties")]
        public virtual PageElementProperties ElementProperties { get; set; }

        /// <summary>
        /// The mode with which the chart is linked to the source spreadsheet. When not specified, the chart will be an
        /// image that is not linked.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkingMode")]
        public virtual string LinkingMode { get; set; }

        /// <summary>
        /// A user-supplied object ID. If specified, the ID must be unique among all pages and page elements in the
        /// presentation. The ID should start with a word character [a-zA-Z0-9_] and then followed by any number of the
        /// following characters [a-zA-Z0-9_-:]. The length of the ID should not be less than 5 or greater than 50. If
        /// empty, a unique identifier will be generated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>
        /// The ID of the Google Sheets spreadsheet that contains the chart. You might need to add a resource key to the
        /// HTTP header for a subset of old files. For more information, see [Access link-shared files using resource
        /// keys](https://developers.google.com/drive/api/v3/resource-keys).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spreadsheetId")]
        public virtual string SpreadsheetId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of creating an embedded Google Sheets chart.</summary>
    public class CreateSheetsChartResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The object ID of the created chart.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Creates a slide.</summary>
    public class CreateSlideRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The optional zero-based index indicating where to insert the slides. If you don't specify an index, the
        /// slide is created at the end.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertionIndex")]
        public virtual System.Nullable<int> InsertionIndex { get; set; }

        /// <summary>
        /// A user-supplied object ID. If you specify an ID, it must be unique among all pages and page elements in the
        /// presentation. The ID must start with an alphanumeric character or an underscore (matches regex
        /// `[a-zA-Z0-9_]`); remaining characters may include those as well as a hyphen or colon (matches regex
        /// `[a-zA-Z0-9_-:]`). The ID length must be between 5 and 50 characters, inclusive. If you don't specify an ID,
        /// a unique one is generated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>
        /// An optional list of object ID mappings from the placeholder(s) on the layout to the placeholders that are
        /// created on the slide from the specified layout. Can only be used when `slide_layout_reference` is specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placeholderIdMappings")]
        public virtual System.Collections.Generic.IList<LayoutPlaceholderIdMapping> PlaceholderIdMappings { get; set; }

        /// <summary>
        /// Layout reference of the slide to be inserted, based on the *current master*, which is one of the following:
        /// - The master of the previous slide index. - The master of the first slide, if the insertion_index is zero. -
        /// The first master in the presentation, if there are no slides. If the LayoutReference is not found in the
        /// current master, a 400 bad request error is returned. If you don't specify a layout reference, the slide uses
        /// the predefined `BLANK` layout.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slideLayoutReference")]
        public virtual LayoutReference SlideLayoutReference { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of creating a slide.</summary>
    public class CreateSlideResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The object ID of the created slide.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Creates a new table.</summary>
    public class CreateTableRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of columns in the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columns")]
        public virtual System.Nullable<int> Columns { get; set; }

        /// <summary>
        /// The element properties for the table. The table will be created at the provided size, subject to a minimum
        /// size. If no size is provided, the table will be automatically sized. Table transforms must have a scale of 1
        /// and no shear components. If no transform is provided, the table will be centered on the page.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("elementProperties")]
        public virtual PageElementProperties ElementProperties { get; set; }

        /// <summary>
        /// A user-supplied object ID. If you specify an ID, it must be unique among all pages and page elements in the
        /// presentation. The ID must start with an alphanumeric character or an underscore (matches regex
        /// `[a-zA-Z0-9_]`); remaining characters may include those as well as a hyphen or colon (matches regex
        /// `[a-zA-Z0-9_-:]`). The length of the ID must not be less than 5 or greater than 50. If you don't specify an
        /// ID, a unique one is generated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>Number of rows in the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Nullable<int> Rows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of creating a table.</summary>
    public class CreateTableResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The object ID of the created table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Creates a video. NOTE: Creating a video from Google Drive requires that the requesting app have at least one of
    /// the drive, drive.readonly, or drive.file OAuth scopes.
    /// </summary>
    public class CreateVideoRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The element properties for the video. The PageElementProperties.size property is optional. If you don't
        /// specify a size, a default size is chosen by the server. The PageElementProperties.transform property is
        /// optional. The transform must not have shear components. If you don't specify a transform, the video will be
        /// placed at the top left corner of the page.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("elementProperties")]
        public virtual PageElementProperties ElementProperties { get; set; }

        /// <summary>
        /// The video source's unique identifier for this video. e.g. For YouTube video
        /// https://www.youtube.com/watch?v=7U3axjORYZ0, the ID is 7U3axjORYZ0. For a Google Drive video
        /// https://drive.google.com/file/d/1xCgQLFTJi5_Xl8DgW_lcUYq5e-q6Hi5Q the ID is
        /// 1xCgQLFTJi5_Xl8DgW_lcUYq5e-q6Hi5Q. To access a Google Drive video file, you might need to add a resource key
        /// to the HTTP header for a subset of old files. For more information, see [Access link-shared files using
        /// resource keys](https://developers.google.com/drive/api/v3/resource-keys).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// A user-supplied object ID. If you specify an ID, it must be unique among all pages and page elements in the
        /// presentation. The ID must start with an alphanumeric character or an underscore (matches regex
        /// `[a-zA-Z0-9_]`); remaining characters may include those as well as a hyphen or colon (matches regex
        /// `[a-zA-Z0-9_-:]`). The length of the ID must not be less than 5 or greater than 50. If you don't specify an
        /// ID, a unique one is generated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>The video source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of creating a video.</summary>
    public class CreateVideoResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The object ID of the created video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The crop properties of an object enclosed in a container. For example, an Image. The crop properties is
    /// represented by the offsets of four edges which define a crop rectangle. The offsets are measured in percentage
    /// from the corresponding edges of the object's original bounding rectangle towards inside, relative to the
    /// object's original dimensions. - If the offset is in the interval (0, 1), the corresponding edge of crop
    /// rectangle is positioned inside of the object's original bounding rectangle. - If the offset is negative or
    /// greater than 1, the corresponding edge of crop rectangle is positioned outside of the object's original bounding
    /// rectangle. - If the left edge of the crop rectangle is on the right side of its right edge, the object will be
    /// flipped horizontally. - If the top edge of the crop rectangle is below its bottom edge, the object will be
    /// flipped vertically. - If all offsets and rotation angle is 0, the object is not cropped. After cropping, the
    /// content in the crop rectangle will be stretched to fit its container.
    /// </summary>
    public class CropProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The rotation angle of the crop window around its center, in radians. Rotation angle is applied after the
        /// offset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("angle")]
        public virtual System.Nullable<float> Angle { get; set; }

        /// <summary>
        /// The offset specifies the bottom edge of the crop rectangle that is located above the original bounding
        /// rectangle bottom edge, relative to the object's original height.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bottomOffset")]
        public virtual System.Nullable<float> BottomOffset { get; set; }

        /// <summary>
        /// The offset specifies the left edge of the crop rectangle that is located to the right of the original
        /// bounding rectangle left edge, relative to the object's original width.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("leftOffset")]
        public virtual System.Nullable<float> LeftOffset { get; set; }

        /// <summary>
        /// The offset specifies the right edge of the crop rectangle that is located to the left of the original
        /// bounding rectangle right edge, relative to the object's original width.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rightOffset")]
        public virtual System.Nullable<float> RightOffset { get; set; }

        /// <summary>
        /// The offset specifies the top edge of the crop rectangle that is located below the original bounding
        /// rectangle top edge, relative to the object's original height.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topOffset")]
        public virtual System.Nullable<float> TopOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Deletes an object, either pages or page elements, from the presentation.</summary>
    public class DeleteObjectRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The object ID of the page or page element to delete. If after a delete operation a group contains only 1 or
        /// no page elements, the group is also deleted. If a placeholder is deleted on a layout, any empty inheriting
        /// placeholders are also deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Deletes bullets from all of the paragraphs that overlap with the given text index range. The nesting level of
    /// each paragraph will be visually preserved by adding indent to the start of the corresponding paragraph.
    /// </summary>
    public class DeleteParagraphBulletsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The optional table cell location if the text to be modified is in a table cell. If present, the object_id
        /// must refer to a table.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cellLocation")]
        public virtual TableCellLocation CellLocation { get; set; }

        /// <summary>The object ID of the shape or table containing the text to delete bullets from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>The range of text to delete bullets from, based on TextElement indexes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textRange")]
        public virtual Range TextRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Deletes a column from a table.</summary>
    public class DeleteTableColumnRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The reference table cell location from which a column will be deleted. The column this cell spans will be
        /// deleted. If this is a merged cell, multiple columns will be deleted. If no columns remain in the table after
        /// this deletion, the whole table is deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cellLocation")]
        public virtual TableCellLocation CellLocation { get; set; }

        /// <summary>The table to delete columns from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableObjectId")]
        public virtual string TableObjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Deletes a row from a table.</summary>
    public class DeleteTableRowRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The reference table cell location from which a row will be deleted. The row this cell spans will be deleted.
        /// If this is a merged cell, multiple rows will be deleted. If no rows remain in the table after this deletion,
        /// the whole table is deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cellLocation")]
        public virtual TableCellLocation CellLocation { get; set; }

        /// <summary>The table to delete rows from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableObjectId")]
        public virtual string TableObjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Deletes text from a shape or a table cell.</summary>
    public class DeleteTextRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The optional table cell location if the text is to be deleted from a table cell. If present, the object_id
        /// must refer to a table.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cellLocation")]
        public virtual TableCellLocation CellLocation { get; set; }

        /// <summary>The object ID of the shape or table from which the text will be deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>
        /// The range of text to delete, based on TextElement indexes. There is always an implicit newline character at
        /// the end of a shape's or table cell's text that cannot be deleted. `Range.Type.ALL` will use the correct
        /// bounds, but care must be taken when specifying explicit bounds for range types `FROM_START_INDEX` and
        /// `FIXED_RANGE`. For example, if the text is "ABC", followed by an implicit newline, then the maximum value is
        /// 2 for `text_range.start_index` and 3 for `text_range.end_index`. Deleting text that crosses a paragraph
        /// boundary may result in changes to paragraph styles and lists as the two paragraphs are merged. Ranges that
        /// include only one code unit of a surrogate pair are expanded to include both code units.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textRange")]
        public virtual Range TextRange { get; set; }

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

    /// <summary>
    /// Duplicates a slide or page element. When duplicating a slide, the duplicate slide will be created immediately
    /// following the specified slide. When duplicating a page element, the duplicate will be placed on the same page at
    /// the same position as the original.
    /// </summary>
    public class DuplicateObjectRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the object to duplicate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>
        /// The object being duplicated may contain other objects, for example when duplicating a slide or a group page
        /// element. This map defines how the IDs of duplicated objects are generated: the keys are the IDs of the
        /// original objects and its values are the IDs that will be assigned to the corresponding duplicate object. The
        /// ID of the source object's duplicate may be specified in this map as well, using the same value of the
        /// `object_id` field as a key and the newly desired ID as the value. All keys must correspond to existing IDs
        /// in the presentation. All values must be unique in the presentation and must start with an alphanumeric
        /// character or an underscore (matches regex `[a-zA-Z0-9_]`); remaining characters may include those as well as
        /// a hyphen or colon (matches regex `[a-zA-Z0-9_-:]`). The length of the new ID must not be less than 5 or
        /// greater than 50. If any IDs of source objects are omitted from the map, a new random ID will be assigned. If
        /// the map is empty or unset, all duplicate objects will receive a new random ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectIds")]
        public virtual System.Collections.Generic.IDictionary<string, string> ObjectIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response of duplicating an object.</summary>
    public class DuplicateObjectResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the new duplicate object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A PageElement kind representing a joined collection of PageElements.</summary>
    public class Group : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The collection of elements in the group. The minimum size of a group is 2.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("children")]
        public virtual System.Collections.Generic.IList<PageElement> Children { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Groups objects to create an object group. For example, groups PageElements to create a Group on the same page as
    /// all the children.
    /// </summary>
    public class GroupObjectsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The object IDs of the objects to group. Only page elements can be grouped. There should be at least two page
        /// elements on the same page that are not already in another group. Some page elements, such as videos, tables
        /// and placeholders cannot be grouped.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("childrenObjectIds")]
        public virtual System.Collections.Generic.IList<string> ChildrenObjectIds { get; set; }

        /// <summary>
        /// A user-supplied object ID for the group to be created. If you specify an ID, it must be unique among all
        /// pages and page elements in the presentation. The ID must start with an alphanumeric character or an
        /// underscore (matches regex `[a-zA-Z0-9_]`); remaining characters may include those as well as a hyphen or
        /// colon (matches regex `[a-zA-Z0-9_-:]`). The length of the ID must not be less than 5 or greater than 50. If
        /// you don't specify an ID, a unique one is generated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupObjectId")]
        public virtual string GroupObjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of grouping objects.</summary>
    public class GroupObjectsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The object ID of the created group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A PageElement kind representing an image.</summary>
    public class Image : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An URL to an image with a default lifetime of 30 minutes. This URL is tagged with the account of the
        /// requester. Anyone with the URL effectively accesses the image as the original requester. Access to the image
        /// may be lost if the presentation's sharing settings change.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentUrl")]
        public virtual string ContentUrl { get; set; }

        /// <summary>The properties of the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageProperties")]
        public virtual ImageProperties ImageProperties { get; set; }

        /// <summary>
        /// Placeholders are page elements that inherit from corresponding placeholders on layouts and masters. If set,
        /// the image is a placeholder image and any inherited properties can be resolved by looking at the parent
        /// placeholder identified by the Placeholder.parent_object_id field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placeholder")]
        public virtual Placeholder Placeholder { get; set; }

        /// <summary>The source URL is the URL used to insert the image. The source URL can be empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceUrl")]
        public virtual string SourceUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of the Image.</summary>
    public class ImageProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The brightness effect of the image. The value should be in the interval [-1.0, 1.0], where 0 means no
        /// effect. This property is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("brightness")]
        public virtual System.Nullable<float> Brightness { get; set; }

        /// <summary>
        /// The contrast effect of the image. The value should be in the interval [-1.0, 1.0], where 0 means no effect.
        /// This property is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contrast")]
        public virtual System.Nullable<float> Contrast { get; set; }

        /// <summary>
        /// The crop properties of the image. If not set, the image is not cropped. This property is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cropProperties")]
        public virtual CropProperties CropProperties { get; set; }

        /// <summary>The hyperlink destination of the image. If unset, there is no link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("link")]
        public virtual Link Link { get; set; }

        /// <summary>The outline of the image. If not set, the image has no outline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outline")]
        public virtual Outline Outline { get; set; }

        /// <summary>
        /// The recolor effect of the image. If not set, the image is not recolored. This property is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recolor")]
        public virtual Recolor Recolor { get; set; }

        /// <summary>The shadow of the image. If not set, the image has no shadow. This property is read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shadow")]
        public virtual Shadow Shadow { get; set; }

        /// <summary>
        /// The transparency effect of the image. The value should be in the interval [0.0, 1.0], where 0 means no
        /// effect and 1 means completely transparent. This property is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transparency")]
        public virtual System.Nullable<float> Transparency { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Inserts columns into a table. Other columns in the table will be resized to fit the new column.
    /// </summary>
    public class InsertTableColumnsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The reference table cell location from which columns will be inserted. A new column will be inserted to the
        /// left (or right) of the column where the reference cell is. If the reference cell is a merged cell, a new
        /// column will be inserted to the left (or right) of the merged cell.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cellLocation")]
        public virtual TableCellLocation CellLocation { get; set; }

        /// <summary>
        /// Whether to insert new columns to the right of the reference cell location. - `True`: insert to the right. -
        /// `False`: insert to the left.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertRight")]
        public virtual System.Nullable<bool> InsertRight { get; set; }

        /// <summary>The number of columns to be inserted. Maximum 20 per request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("number")]
        public virtual System.Nullable<int> Number { get; set; }

        /// <summary>The table to insert columns into.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableObjectId")]
        public virtual string TableObjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Inserts rows into a table.</summary>
    public class InsertTableRowsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The reference table cell location from which rows will be inserted. A new row will be inserted above (or
        /// below) the row where the reference cell is. If the reference cell is a merged cell, a new row will be
        /// inserted above (or below) the merged cell.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cellLocation")]
        public virtual TableCellLocation CellLocation { get; set; }

        /// <summary>
        /// Whether to insert new rows below the reference cell location. - `True`: insert below the cell. - `False`:
        /// insert above the cell.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertBelow")]
        public virtual System.Nullable<bool> InsertBelow { get; set; }

        /// <summary>The number of rows to be inserted. Maximum 20 per request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("number")]
        public virtual System.Nullable<int> Number { get; set; }

        /// <summary>The table to insert rows into.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableObjectId")]
        public virtual string TableObjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Inserts text into a shape or a table cell.</summary>
    public class InsertTextRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The optional table cell location if the text is to be inserted into a table cell. If present, the object_id
        /// must refer to a table.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cellLocation")]
        public virtual TableCellLocation CellLocation { get; set; }

        /// <summary>
        /// The index where the text will be inserted, in Unicode code units, based on TextElement indexes. The index is
        /// zero-based and is computed from the start of the string. The index may be adjusted to prevent insertions
        /// inside Unicode grapheme clusters. In these cases, the text will be inserted immediately after the grapheme
        /// cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertionIndex")]
        public virtual System.Nullable<int> InsertionIndex { get; set; }

        /// <summary>The object ID of the shape or table where the text will be inserted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>
        /// The text to be inserted. Inserting a newline character will implicitly create a new ParagraphMarker at that
        /// index. The paragraph style of the new paragraph will be copied from the paragraph at the current insertion
        /// index, including lists and bullets. Text styles for inserted text will be determined automatically,
        /// generally preserving the styling of neighboring text. In most cases, the text will be added to the TextRun
        /// that exists at the insertion index. Some control characters (U+0000-U+0008, U+000C-U+001F) and characters
        /// from the Unicode Basic Multilingual Plane Private Use Area (U+E000-U+F8FF) will be stripped out of the
        /// inserted text.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The user-specified ID mapping for a placeholder that will be created on a slide from a specified layout.
    /// </summary>
    public class LayoutPlaceholderIdMapping : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The placeholder on a layout that will be applied to a slide. Only type and index are needed. For example, a
        /// predefined `TITLE_AND_BODY` layout may usually have a TITLE placeholder with index 0 and a BODY placeholder
        /// with index 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layoutPlaceholder")]
        public virtual Placeholder LayoutPlaceholder { get; set; }

        /// <summary>The object ID of the placeholder on a layout that will be applied to a slide.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layoutPlaceholderObjectId")]
        public virtual string LayoutPlaceholderObjectId { get; set; }

        /// <summary>
        /// A user-supplied object ID for the placeholder identified above that to be created onto a slide. If you
        /// specify an ID, it must be unique among all pages and page elements in the presentation. The ID must start
        /// with an alphanumeric character or an underscore (matches regex `[a-zA-Z0-9_]`); remaining characters may
        /// include those as well as a hyphen or colon (matches regex `[a-zA-Z0-9_-:]`). The length of the ID must not
        /// be less than 5 or greater than 50. If you don't specify an ID, a unique one is generated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of Page are only relevant for pages with page_type LAYOUT.</summary>
    public class LayoutProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The human-readable name of the layout.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The object ID of the master that this layout is based on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("masterObjectId")]
        public virtual string MasterObjectId { get; set; }

        /// <summary>The name of the layout.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Slide layout reference. This may reference either: - A predefined layout - One of the layouts in the
    /// presentation.
    /// </summary>
    public class LayoutReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Layout ID: the object ID of one of the layouts in the presentation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layoutId")]
        public virtual string LayoutId { get; set; }

        /// <summary>Predefined layout.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("predefinedLayout")]
        public virtual string PredefinedLayout { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A PageElement kind representing a non-connector line, straight connector, curved connector, or bent connector.
    /// </summary>
    public class Line : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The category of the line. It matches the `category` specified in CreateLineRequest, and can be updated with
        /// UpdateLineCategoryRequest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineCategory")]
        public virtual string LineCategory { get; set; }

        /// <summary>The properties of the line.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineProperties")]
        public virtual LineProperties LineProperties { get; set; }

        /// <summary>The type of the line.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineType")]
        public virtual string LineType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties for one end of a Line connection.</summary>
    public class LineConnection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The object ID of the connected page element. Some page elements, such as groups, tables, and lines do not
        /// have connection sites and therefore cannot be connected to a connector line.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectedObjectId")]
        public virtual string ConnectedObjectId { get; set; }

        /// <summary>
        /// The index of the connection site on the connected page element. In most cases, it corresponds to the
        /// predefined connection site index from the ECMA-376 standard. More information on those connection sites can
        /// be found in both the description of the "cxn" attribute in section 20.1.9.9 and "Annex H. Example Predefined
        /// DrawingML Shape and Text Geometries" of "Office Open XML File Formats - Fundamentals and Markup Language
        /// Reference", part 1 of [ECMA-376 5th
        /// edition](https://ecma-international.org/publications-and-standards/standards/ecma-376/). The position of
        /// each connection site can also be viewed from Slides editor.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionSiteIndex")]
        public virtual System.Nullable<int> ConnectionSiteIndex { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The fill of the line.</summary>
    public class LineFill : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Solid color fill.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("solidFill")]
        public virtual SolidFill SolidFill { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The properties of the Line. When unset, these fields default to values that match the appearance of new lines
    /// created in the Slides editor.
    /// </summary>
    public class LineProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The dash style of the line.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dashStyle")]
        public virtual string DashStyle { get; set; }

        /// <summary>The style of the arrow at the end of the line.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endArrow")]
        public virtual string EndArrow { get; set; }

        /// <summary>
        /// The connection at the end of the line. If unset, there is no connection. Only lines with a Type indicating
        /// it is a "connector" can have an `end_connection`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endConnection")]
        public virtual LineConnection EndConnection { get; set; }

        /// <summary>
        /// The fill of the line. The default line fill matches the defaults for new lines created in the Slides editor.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineFill")]
        public virtual LineFill LineFill { get; set; }

        /// <summary>The hyperlink destination of the line. If unset, there is no link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("link")]
        public virtual Link Link { get; set; }

        /// <summary>The style of the arrow at the beginning of the line.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startArrow")]
        public virtual string StartArrow { get; set; }

        /// <summary>
        /// The connection at the beginning of the line. If unset, there is no connection. Only lines with a Type
        /// indicating it is a "connector" can have a `start_connection`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startConnection")]
        public virtual LineConnection StartConnection { get; set; }

        /// <summary>The thickness of the line.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weight")]
        public virtual Dimension Weight { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A hypertext link.</summary>
    public class Link : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If set, indicates this is a link to the specific page in this presentation with this ID. A page with this ID
        /// may not exist.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageObjectId")]
        public virtual string PageObjectId { get; set; }

        /// <summary>
        /// If set, indicates this is a link to a slide in this presentation, addressed by its position.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relativeLink")]
        public virtual string RelativeLink { get; set; }

        /// <summary>
        /// If set, indicates this is a link to the slide at this zero-based index in the presentation. There may not be
        /// a slide at this index.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slideIndex")]
        public virtual System.Nullable<int> SlideIndex { get; set; }

        /// <summary>If set, indicates this is a link to the external web page at this URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A List describes the look and feel of bullets belonging to paragraphs associated with a list. A paragraph that
    /// is part of a list has an implicit reference to that list's ID.
    /// </summary>
    public class List : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listId")]
        public virtual string ListId { get; set; }

        /// <summary>
        /// A map of nesting levels to the properties of bullets at the associated level. A list has at most nine levels
        /// of nesting, so the possible values for the keys of this map are 0 through 8, inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nestingLevel")]
        public virtual System.Collections.Generic.IDictionary<string, NestingLevel> NestingLevel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of Page that are only relevant for pages with page_type MASTER.</summary>
    public class MasterProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The human-readable name of the master.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Merges cells in a Table.</summary>
    public class MergeTableCellsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The object ID of the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>
        /// The table range specifying which cells of the table to merge. Any text in the cells being merged will be
        /// concatenated and stored in the upper-left ("head") cell of the range. If the range is non-rectangular (which
        /// can occur in some cases where the range covers cells that are already merged), a 400 bad request error is
        /// returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableRange")]
        public virtual TableRange TableRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains properties describing the look and feel of a list bullet at a given level of nesting.
    /// </summary>
    public class NestingLevel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The style of a bullet at this level of nesting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bulletStyle")]
        public virtual TextStyle BulletStyle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of Page that are only relevant for pages with page_type NOTES.</summary>
    public class NotesProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The object ID of the shape on this notes page that contains the speaker notes for the corresponding slide.
        /// The actual shape may not always exist on the notes page. Inserting text using this object ID will
        /// automatically create the shape. In this case, the actual shape may have different object ID. The
        /// `GetPresentation` or `GetPage` action will always return the latest object ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("speakerNotesObjectId")]
        public virtual string SpeakerNotesObjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A themeable solid color value.</summary>
    public class OpaqueColor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An opaque RGB color.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rgbColor")]
        public virtual RgbColor RgbColor { get; set; }

        /// <summary>An opaque theme color.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("themeColor")]
        public virtual string ThemeColor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A color that can either be fully opaque or fully transparent.</summary>
    public class OptionalColor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If set, this will be used as an opaque color. If unset, this represents a transparent color.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("opaqueColor")]
        public virtual OpaqueColor OpaqueColor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The outline of a PageElement. If these fields are unset, they may be inherited from a parent placeholder if it
    /// exists. If there is no parent, the fields will default to the value used for new page elements created in the
    /// Slides editor, which may depend on the page element kind.
    /// </summary>
    public class Outline : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The dash style of the outline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dashStyle")]
        public virtual string DashStyle { get; set; }

        /// <summary>The fill of the outline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outlineFill")]
        public virtual OutlineFill OutlineFill { get; set; }

        /// <summary>
        /// The outline property state. Updating the outline on a page element will implicitly update this field to
        /// `RENDERED`, unless another value is specified in the same request. To have no outline on a page element, set
        /// this field to `NOT_RENDERED`. In this case, any other outline fields set in the same request will be
        /// ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("propertyState")]
        public virtual string PropertyState { get; set; }

        /// <summary>The thickness of the outline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weight")]
        public virtual Dimension Weight { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The fill of the outline.</summary>
    public class OutlineFill : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Solid color fill.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("solidFill")]
        public virtual SolidFill SolidFill { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A page in a presentation.</summary>
    public class Page : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Layout specific properties. Only set if page_type = LAYOUT.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layoutProperties")]
        public virtual LayoutProperties LayoutProperties { get; set; }

        /// <summary>Master specific properties. Only set if page_type = MASTER.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("masterProperties")]
        public virtual MasterProperties MasterProperties { get; set; }

        /// <summary>Notes specific properties. Only set if page_type = NOTES.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notesProperties")]
        public virtual NotesProperties NotesProperties { get; set; }

        /// <summary>
        /// The object ID for this page. Object IDs used by Page and PageElement share the same namespace.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>The page elements rendered on the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageElements")]
        public virtual System.Collections.Generic.IList<PageElement> PageElements { get; set; }

        /// <summary>The properties of the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageProperties")]
        public virtual PageProperties PageProperties { get; set; }

        /// <summary>The type of the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageType")]
        public virtual string PageType { get; set; }

        /// <summary>
        /// Output only. The revision ID of the presentation. Can be used in update requests to assert the presentation
        /// revision hasn't changed since the last read operation. Only populated if the user has edit access to the
        /// presentation. The revision ID is not a sequential number but an opaque string. The format of the revision ID
        /// might change over time. A returned revision ID is only guaranteed to be valid for 24 hours after it has been
        /// returned and cannot be shared across users. If the revision ID is unchanged between calls, then the
        /// presentation has not changed. Conversely, a changed ID (for the same presentation and user) usually means
        /// the presentation has been updated. However, a changed ID can also be due to internal factors such as ID
        /// format changes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>Slide specific properties. Only set if page_type = SLIDE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slideProperties")]
        public virtual SlideProperties SlideProperties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The page background fill.</summary>
    public class PageBackgroundFill : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The background fill property state. Updating the fill on a page will implicitly update this field to
        /// `RENDERED`, unless another value is specified in the same request. To have no fill on a page, set this field
        /// to `NOT_RENDERED`. In this case, any other fill fields set in the same request will be ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("propertyState")]
        public virtual string PropertyState { get; set; }

        /// <summary>Solid color fill.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("solidFill")]
        public virtual SolidFill SolidFill { get; set; }

        /// <summary>Stretched picture fill.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stretchedPictureFill")]
        public virtual StretchedPictureFill StretchedPictureFill { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A visual element rendered on a page.</summary>
    public class PageElement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The description of the page element. Combined with title to display alt text. The field is not supported for
        /// Group elements.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>A collection of page elements joined as a single unit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("elementGroup")]
        public virtual Group ElementGroup { get; set; }

        /// <summary>An image page element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual Image Image { get; set; }

        /// <summary>A line page element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("line")]
        public virtual Line Line { get; set; }

        /// <summary>
        /// The object ID for this page element. Object IDs used by google.apps.slides.v1.Page and
        /// google.apps.slides.v1.PageElement share the same namespace.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>A generic shape.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shape")]
        public virtual Shape Shape { get; set; }

        /// <summary>A linked chart embedded from Google Sheets. Unlinked charts are represented as images.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sheetsChart")]
        public virtual SheetsChart SheetsChart { get; set; }

        /// <summary>The size of the page element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("size")]
        public virtual Size Size { get; set; }

        /// <summary>A Speaker Spotlight.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("speakerSpotlight")]
        public virtual SpeakerSpotlight SpeakerSpotlight { get; set; }

        /// <summary>A table page element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("table")]
        public virtual Table Table { get; set; }

        /// <summary>
        /// The title of the page element. Combined with description to display alt text. The field is not supported for
        /// Group elements.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>
        /// The transform of the page element. The visual appearance of the page element is determined by its absolute
        /// transform. To compute the absolute transform, preconcatenate a page element's transform with the transforms
        /// of all of its parent groups. If the page element is not in a group, its absolute transform is the same as
        /// the value in this field. The initial transform for the newly created Group is always the identity transform.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transform")]
        public virtual AffineTransform Transform { get; set; }

        /// <summary>A video page element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("video")]
        public virtual Video Video { get; set; }

        /// <summary>A word art page element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wordArt")]
        public virtual WordArt WordArt { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Common properties for a page element. Note: When you initially create a PageElement, the API may modify the
    /// values of both `size` and `transform`, but the visual size will be unchanged.
    /// </summary>
    public class PageElementProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The object ID of the page where the element is located.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageObjectId")]
        public virtual string PageObjectId { get; set; }

        /// <summary>The size of the element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("size")]
        public virtual Size Size { get; set; }

        /// <summary>The transform for the element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transform")]
        public virtual AffineTransform Transform { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The properties of the Page. The page will inherit properties from the parent page. Depending on the page type
    /// the hierarchy is defined in either SlideProperties or LayoutProperties.
    /// </summary>
    public class PageProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The color scheme of the page. If unset, the color scheme is inherited from a parent page. If the page has no
        /// parent, the color scheme uses a default Slides color scheme, matching the defaults in the Slides editor.
        /// Only the concrete colors of the first 12 ThemeColorTypes are editable. In addition, only the color scheme on
        /// `Master` pages can be updated. To update the field, a color scheme containing mappings from all the first 12
        /// ThemeColorTypes to their concrete colors must be provided. Colors for the remaining ThemeColorTypes will be
        /// ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colorScheme")]
        public virtual ColorScheme ColorScheme { get; set; }

        /// <summary>
        /// The background fill of the page. If unset, the background fill is inherited from a parent page if it exists.
        /// If the page has no parent, then the background fill defaults to the corresponding fill in the Slides editor.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageBackgroundFill")]
        public virtual PageBackgroundFill PageBackgroundFill { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A TextElement kind that represents the beginning of a new paragraph.</summary>
    public class ParagraphMarker : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The bullet for this paragraph. If not present, the paragraph does not belong to a list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bullet")]
        public virtual Bullet Bullet { get; set; }

        /// <summary>The paragraph's style</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("style")]
        public virtual ParagraphStyle Style { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Styles that apply to a whole paragraph. If this text is contained in a shape with a parent placeholder, then
    /// these paragraph styles may be inherited from the parent. Which paragraph styles are inherited depend on the
    /// nesting level of lists: * A paragraph not in a list will inherit its paragraph style from the paragraph at the 0
    /// nesting level of the list inside the parent placeholder. * A paragraph in a list will inherit its paragraph
    /// style from the paragraph at its corresponding nesting level of the list inside the parent placeholder. Inherited
    /// paragraph styles are represented as unset fields in this message.
    /// </summary>
    public class ParagraphStyle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The text alignment for this paragraph.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alignment")]
        public virtual string Alignment { get; set; }

        /// <summary>
        /// The text direction of this paragraph. If unset, the value defaults to LEFT_TO_RIGHT since text direction is
        /// not inherited.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("direction")]
        public virtual string Direction { get; set; }

        /// <summary>
        /// The amount indentation for the paragraph on the side that corresponds to the end of the text, based on the
        /// current text direction. If unset, the value is inherited from the parent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indentEnd")]
        public virtual Dimension IndentEnd { get; set; }

        /// <summary>
        /// The amount of indentation for the start of the first line of the paragraph. If unset, the value is inherited
        /// from the parent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indentFirstLine")]
        public virtual Dimension IndentFirstLine { get; set; }

        /// <summary>
        /// The amount indentation for the paragraph on the side that corresponds to the start of the text, based on the
        /// current text direction. If unset, the value is inherited from the parent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indentStart")]
        public virtual Dimension IndentStart { get; set; }

        /// <summary>
        /// The amount of space between lines, as a percentage of normal, where normal is represented as 100.0. If
        /// unset, the value is inherited from the parent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineSpacing")]
        public virtual System.Nullable<float> LineSpacing { get; set; }

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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The placeholder information that uniquely identifies a placeholder shape.</summary>
    public class Placeholder : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The index of the placeholder. If the same placeholder types are present in the same page, they would have
        /// different index values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual System.Nullable<int> Index { get; set; }

        /// <summary>
        /// The object ID of this shape's parent placeholder. If unset, the parent placeholder shape does not exist, so
        /// the shape does not inherit properties from any other shape.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentObjectId")]
        public virtual string ParentObjectId { get; set; }

        /// <summary>The type of the placeholder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Google Slides presentation.</summary>
    public class Presentation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The layouts in the presentation. A layout is a template that determines how content is arranged and styled
        /// on the slides that inherit from that layout.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layouts")]
        public virtual System.Collections.Generic.IList<Page> Layouts { get; set; }

        /// <summary>The locale of the presentation, as an IETF BCP 47 language tag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locale")]
        public virtual string Locale { get; set; }

        /// <summary>
        /// The slide masters in the presentation. A slide master contains all common page elements and the common
        /// properties for a set of layouts. They serve three purposes: - Placeholder shapes on a master contain the
        /// default text styles and shape properties of all placeholder shapes on pages that use that master. - The
        /// master page properties define the common page properties inherited by its layouts. - Any other shapes on the
        /// master slide appear on all slides using that master, regardless of their layout.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("masters")]
        public virtual System.Collections.Generic.IList<Page> Masters { get; set; }

        /// <summary>
        /// The notes master in the presentation. It serves three purposes: - Placeholder shapes on a notes master
        /// contain the default text styles and shape properties of all placeholder shapes on notes pages. Specifically,
        /// a `SLIDE_IMAGE` placeholder shape contains the slide thumbnail, and a `BODY` placeholder shape contains the
        /// speaker notes. - The notes master page properties define the common page properties inherited by all notes
        /// pages. - Any other shapes on the notes master appear on all notes pages. The notes master is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notesMaster")]
        public virtual Page NotesMaster { get; set; }

        /// <summary>The size of pages in the presentation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual Size PageSize { get; set; }

        /// <summary>The ID of the presentation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("presentationId")]
        public virtual string PresentationId { get; set; }

        /// <summary>
        /// Output only. The revision ID of the presentation. Can be used in update requests to assert the presentation
        /// revision hasn't changed since the last read operation. Only populated if the user has edit access to the
        /// presentation. The revision ID is not a sequential number but a nebulous string. The format of the revision
        /// ID may change over time, so it should be treated opaquely. A returned revision ID is only guaranteed to be
        /// valid for 24 hours after it has been returned and cannot be shared across users. If the revision ID is
        /// unchanged between calls, then the presentation has not changed. Conversely, a changed ID (for the same
        /// presentation and user) usually means the presentation has been updated. However, a changed ID can also be
        /// due to internal factors such as ID format changes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>The slides in the presentation. A slide inherits properties from a slide layout.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slides")]
        public virtual System.Collections.Generic.IList<Page> Slides { get; set; }

        /// <summary>The title of the presentation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies a contiguous range of an indexed collection, such as characters in text.</summary>
    public class Range : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The optional zero-based index of the end of the collection. Required for `FIXED_RANGE` ranges.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endIndex")]
        public virtual System.Nullable<int> EndIndex { get; set; }

        /// <summary>
        /// The optional zero-based index of the beginning of the collection. Required for `FIXED_RANGE` and
        /// `FROM_START_INDEX` ranges.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; }

        /// <summary>The type of range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A recolor effect applied on an image.</summary>
    public class Recolor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the recolor effect. The name is determined from the `recolor_stops` by matching the gradient
        /// against the colors in the page's current color scheme. This property is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The recolor effect is represented by a gradient, which is a list of color stops. The colors in the gradient
        /// will replace the corresponding colors at the same position in the color palette and apply to the image. This
        /// property is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recolorStops")]
        public virtual System.Collections.Generic.IList<ColorStop> RecolorStops { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Refreshes an embedded Google Sheets chart by replacing it with the latest version of the chart from Google
    /// Sheets. NOTE: Refreshing charts requires at least one of the spreadsheets.readonly, spreadsheets,
    /// drive.readonly, or drive OAuth scopes.
    /// </summary>
    public class RefreshSheetsChartRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The object ID of the chart to refresh.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Replaces all shapes that match the given criteria with the provided image. The images replacing the shapes are
    /// rectangular after being inserted into the presentation and do not take on the forms of the shapes.
    /// </summary>
    public class ReplaceAllShapesWithImageRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If set, this request will replace all of the shapes that contain the given text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containsText")]
        public virtual SubstringMatchCriteria ContainsText { get; set; }

        /// <summary>
        /// The image replace method. If you specify both a `replace_method` and an `image_replace_method`, the
        /// `image_replace_method` takes precedence. If you do not specify a value for `image_replace_method`, but
        /// specify a value for `replace_method`, then the specified `replace_method` value is used. If you do not
        /// specify either, then CENTER_INSIDE is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageReplaceMethod")]
        public virtual string ImageReplaceMethod { get; set; }

        /// <summary>
        /// The image URL. The image is fetched once at insertion time and a copy is stored for display inside the
        /// presentation. Images must be less than 50MB in size, cannot exceed 25 megapixels, and must be in one of PNG,
        /// JPEG, or GIF format. The provided URL can be at most 2 kB in length. The URL itself is saved with the image,
        /// and exposed via the Image.source_url field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUrl")]
        public virtual string ImageUrl { get; set; }

        /// <summary>
        /// If non-empty, limits the matches to page elements only on the given pages. Returns a 400 bad request error
        /// if given the page object ID of a notes page or a notes master, or if a page with that object ID doesn't
        /// exist in the presentation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageObjectIds")]
        public virtual System.Collections.Generic.IList<string> PageObjectIds { get; set; }

        /// <summary>
        /// The replace method. *Deprecated*: use `image_replace_method` instead. If you specify both a `replace_method`
        /// and an `image_replace_method`, the `image_replace_method` takes precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replaceMethod")]
        public virtual string ReplaceMethod { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of replacing shapes with an image.</summary>
    public class ReplaceAllShapesWithImageResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of shapes replaced with images.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("occurrencesChanged")]
        public virtual System.Nullable<int> OccurrencesChanged { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Replaces all shapes that match the given criteria with the provided Google Sheets chart. The chart will be
    /// scaled and centered to fit within the bounds of the original shape. NOTE: Replacing shapes with a chart requires
    /// at least one of the spreadsheets.readonly, spreadsheets, drive.readonly, or drive OAuth scopes.
    /// </summary>
    public class ReplaceAllShapesWithSheetsChartRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the specific chart in the Google Sheets spreadsheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chartId")]
        public virtual System.Nullable<int> ChartId { get; set; }

        /// <summary>
        /// The criteria that the shapes must match in order to be replaced. The request will replace all of the shapes
        /// that contain the given text.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containsText")]
        public virtual SubstringMatchCriteria ContainsText { get; set; }

        /// <summary>
        /// The mode with which the chart is linked to the source spreadsheet. When not specified, the chart will be an
        /// image that is not linked.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkingMode")]
        public virtual string LinkingMode { get; set; }

        /// <summary>
        /// If non-empty, limits the matches to page elements only on the given pages. Returns a 400 bad request error
        /// if given the page object ID of a notes page or a notes master, or if a page with that object ID doesn't
        /// exist in the presentation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageObjectIds")]
        public virtual System.Collections.Generic.IList<string> PageObjectIds { get; set; }

        /// <summary>The ID of the Google Sheets spreadsheet that contains the chart.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spreadsheetId")]
        public virtual string SpreadsheetId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of replacing shapes with a Google Sheets chart.</summary>
    public class ReplaceAllShapesWithSheetsChartResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of shapes replaced with charts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("occurrencesChanged")]
        public virtual System.Nullable<int> OccurrencesChanged { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Replaces all instances of text matching a criteria with replace text.</summary>
    public class ReplaceAllTextRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Finds text in a shape matching this substring.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containsText")]
        public virtual SubstringMatchCriteria ContainsText { get; set; }

        /// <summary>
        /// If non-empty, limits the matches to page elements only on the given pages. Returns a 400 bad request error
        /// if given the page object ID of a notes master, or if a page with that object ID doesn't exist in the
        /// presentation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageObjectIds")]
        public virtual System.Collections.Generic.IList<string> PageObjectIds { get; set; }

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
    /// image.
    /// </summary>
    public class ReplaceImageRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The ID of the existing image that will be replaced. The ID can be retrieved from the response of a get
        /// request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageObjectId")]
        public virtual string ImageObjectId { get; set; }

        /// <summary>The replacement method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageReplaceMethod")]
        public virtual string ImageReplaceMethod { get; set; }

        /// <summary>
        /// The image URL. The image is fetched once at insertion time and a copy is stored for display inside the
        /// presentation. Images must be less than 50MB, cannot exceed 25 megapixels, and must be in PNG, JPEG, or GIF
        /// format. The provided URL can't surpass 2 KB in length. The URL is saved with the image, and exposed through
        /// the Image.source_url field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single kind of update to apply to a presentation.</summary>
    public class Request : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Creates an image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createImage")]
        public virtual CreateImageRequest CreateImage { get; set; }

        /// <summary>Creates a line.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createLine")]
        public virtual CreateLineRequest CreateLine { get; set; }

        /// <summary>Creates bullets for paragraphs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createParagraphBullets")]
        public virtual CreateParagraphBulletsRequest CreateParagraphBullets { get; set; }

        /// <summary>Creates a new shape.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createShape")]
        public virtual CreateShapeRequest CreateShape { get; set; }

        /// <summary>Creates an embedded Google Sheets chart.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createSheetsChart")]
        public virtual CreateSheetsChartRequest CreateSheetsChart { get; set; }

        /// <summary>Creates a new slide.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createSlide")]
        public virtual CreateSlideRequest CreateSlide { get; set; }

        /// <summary>Creates a new table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTable")]
        public virtual CreateTableRequest CreateTable { get; set; }

        /// <summary>Creates a video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createVideo")]
        public virtual CreateVideoRequest CreateVideo { get; set; }

        /// <summary>Deletes a page or page element from the presentation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteObject")]
        public virtual DeleteObjectRequest DeleteObject { get; set; }

        /// <summary>Deletes bullets from paragraphs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteParagraphBullets")]
        public virtual DeleteParagraphBulletsRequest DeleteParagraphBullets { get; set; }

        /// <summary>Deletes a column from a table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTableColumn")]
        public virtual DeleteTableColumnRequest DeleteTableColumn { get; set; }

        /// <summary>Deletes a row from a table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTableRow")]
        public virtual DeleteTableRowRequest DeleteTableRow { get; set; }

        /// <summary>Deletes text from a shape or a table cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteText")]
        public virtual DeleteTextRequest DeleteText { get; set; }

        /// <summary>Duplicates a slide or page element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duplicateObject")]
        public virtual DuplicateObjectRequest DuplicateObject { get; set; }

        /// <summary>Groups objects, such as page elements.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupObjects")]
        public virtual GroupObjectsRequest GroupObjects { get; set; }

        /// <summary>Inserts columns into a table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertTableColumns")]
        public virtual InsertTableColumnsRequest InsertTableColumns { get; set; }

        /// <summary>Inserts rows into a table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertTableRows")]
        public virtual InsertTableRowsRequest InsertTableRows { get; set; }

        /// <summary>Inserts text into a shape or table cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertText")]
        public virtual InsertTextRequest InsertText { get; set; }

        /// <summary>Merges cells in a Table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mergeTableCells")]
        public virtual MergeTableCellsRequest MergeTableCells { get; set; }

        /// <summary>Refreshes a Google Sheets chart.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refreshSheetsChart")]
        public virtual RefreshSheetsChartRequest RefreshSheetsChart { get; set; }

        /// <summary>Replaces all shapes matching some criteria with an image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replaceAllShapesWithImage")]
        public virtual ReplaceAllShapesWithImageRequest ReplaceAllShapesWithImage { get; set; }

        /// <summary>Replaces all shapes matching some criteria with a Google Sheets chart.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replaceAllShapesWithSheetsChart")]
        public virtual ReplaceAllShapesWithSheetsChartRequest ReplaceAllShapesWithSheetsChart { get; set; }

        /// <summary>Replaces all instances of specified text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replaceAllText")]
        public virtual ReplaceAllTextRequest ReplaceAllText { get; set; }

        /// <summary>Replaces an existing image with a new image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replaceImage")]
        public virtual ReplaceImageRequest ReplaceImage { get; set; }

        /// <summary>
        /// Reroutes a line such that it's connected at the two closest connection sites on the connected page elements.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rerouteLine")]
        public virtual RerouteLineRequest RerouteLine { get; set; }

        /// <summary>Ungroups objects, such as groups.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ungroupObjects")]
        public virtual UngroupObjectsRequest UngroupObjects { get; set; }

        /// <summary>Unmerges cells in a Table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unmergeTableCells")]
        public virtual UnmergeTableCellsRequest UnmergeTableCells { get; set; }

        /// <summary>Updates the properties of an Image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateImageProperties")]
        public virtual UpdateImagePropertiesRequest UpdateImageProperties { get; set; }

        /// <summary>Updates the category of a line.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateLineCategory")]
        public virtual UpdateLineCategoryRequest UpdateLineCategory { get; set; }

        /// <summary>Updates the properties of a Line.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateLineProperties")]
        public virtual UpdateLinePropertiesRequest UpdateLineProperties { get; set; }

        /// <summary>Updates the alt text title and/or description of a page element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updatePageElementAltText")]
        public virtual UpdatePageElementAltTextRequest UpdatePageElementAltText { get; set; }

        /// <summary>Updates the transform of a page element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updatePageElementTransform")]
        public virtual UpdatePageElementTransformRequest UpdatePageElementTransform { get; set; }

        /// <summary>Updates the Z-order of page elements.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updatePageElementsZOrder")]
        public virtual UpdatePageElementsZOrderRequest UpdatePageElementsZOrder { get; set; }

        /// <summary>Updates the properties of a Page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updatePageProperties")]
        public virtual UpdatePagePropertiesRequest UpdatePageProperties { get; set; }

        /// <summary>Updates the styling of paragraphs within a Shape or Table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateParagraphStyle")]
        public virtual UpdateParagraphStyleRequest UpdateParagraphStyle { get; set; }

        /// <summary>Updates the properties of a Shape.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateShapeProperties")]
        public virtual UpdateShapePropertiesRequest UpdateShapeProperties { get; set; }

        /// <summary>Updates the properties of a Slide</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateSlideProperties")]
        public virtual UpdateSlidePropertiesRequest UpdateSlideProperties { get; set; }

        /// <summary>Updates the position of a set of slides in the presentation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateSlidesPosition")]
        public virtual UpdateSlidesPositionRequest UpdateSlidesPosition { get; set; }

        /// <summary>Updates the properties of the table borders in a Table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTableBorderProperties")]
        public virtual UpdateTableBorderPropertiesRequest UpdateTableBorderProperties { get; set; }

        /// <summary>Updates the properties of a TableCell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTableCellProperties")]
        public virtual UpdateTableCellPropertiesRequest UpdateTableCellProperties { get; set; }

        /// <summary>Updates the properties of a Table column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTableColumnProperties")]
        public virtual UpdateTableColumnPropertiesRequest UpdateTableColumnProperties { get; set; }

        /// <summary>Updates the properties of a Table row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTableRowProperties")]
        public virtual UpdateTableRowPropertiesRequest UpdateTableRowProperties { get; set; }

        /// <summary>Updates the styling of text within a Shape or Table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTextStyle")]
        public virtual UpdateTextStyleRequest UpdateTextStyle { get; set; }

        /// <summary>Updates the properties of a Video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateVideoProperties")]
        public virtual UpdateVideoPropertiesRequest UpdateVideoProperties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Reroutes a line such that it's connected at the two closest connection sites on the connected page elements.
    /// </summary>
    public class RerouteLineRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The object ID of the line to reroute. Only a line with a category indicating it is a "connector" can be
        /// rerouted. The start and end connections of the line must be on different page elements.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single response from an update.</summary>
    public class Response : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The result of creating an image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createImage")]
        public virtual CreateImageResponse CreateImage { get; set; }

        /// <summary>The result of creating a line.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createLine")]
        public virtual CreateLineResponse CreateLine { get; set; }

        /// <summary>The result of creating a shape.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createShape")]
        public virtual CreateShapeResponse CreateShape { get; set; }

        /// <summary>The result of creating a Google Sheets chart.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createSheetsChart")]
        public virtual CreateSheetsChartResponse CreateSheetsChart { get; set; }

        /// <summary>The result of creating a slide.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createSlide")]
        public virtual CreateSlideResponse CreateSlide { get; set; }

        /// <summary>The result of creating a table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTable")]
        public virtual CreateTableResponse CreateTable { get; set; }

        /// <summary>The result of creating a video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createVideo")]
        public virtual CreateVideoResponse CreateVideo { get; set; }

        /// <summary>The result of duplicating an object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duplicateObject")]
        public virtual DuplicateObjectResponse DuplicateObject { get; set; }

        /// <summary>The result of grouping objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupObjects")]
        public virtual GroupObjectsResponse GroupObjects { get; set; }

        /// <summary>The result of replacing all shapes matching some criteria with an image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replaceAllShapesWithImage")]
        public virtual ReplaceAllShapesWithImageResponse ReplaceAllShapesWithImage { get; set; }

        /// <summary>The result of replacing all shapes matching some criteria with a Google Sheets chart.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replaceAllShapesWithSheetsChart")]
        public virtual ReplaceAllShapesWithSheetsChartResponse ReplaceAllShapesWithSheetsChart { get; set; }

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

    /// <summary>
    /// The shadow properties of a page element. If these fields are unset, they may be inherited from a parent
    /// placeholder if it exists. If there is no parent, the fields will default to the value used for new page elements
    /// created in the Slides editor, which may depend on the page element kind.
    /// </summary>
    public class Shadow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The alignment point of the shadow, that sets the origin for translate, scale and skew of the shadow. This
        /// property is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alignment")]
        public virtual string Alignment { get; set; }

        /// <summary>The alpha of the shadow's color, from 0.0 to 1.0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alpha")]
        public virtual System.Nullable<float> Alpha { get; set; }

        /// <summary>
        /// The radius of the shadow blur. The larger the radius, the more diffuse the shadow becomes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blurRadius")]
        public virtual Dimension BlurRadius { get; set; }

        /// <summary>The shadow color value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual OpaqueColor Color { get; set; }

        /// <summary>
        /// The shadow property state. Updating the shadow on a page element will implicitly update this field to
        /// `RENDERED`, unless another value is specified in the same request. To have no shadow on a page element, set
        /// this field to `NOT_RENDERED`. In this case, any other shadow fields set in the same request will be ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("propertyState")]
        public virtual string PropertyState { get; set; }

        /// <summary>Whether the shadow should rotate with the shape. This property is read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rotateWithShape")]
        public virtual System.Nullable<bool> RotateWithShape { get; set; }

        /// <summary>
        /// Transform that encodes the translate, scale, and skew of the shadow, relative to the alignment position.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transform")]
        public virtual AffineTransform Transform { get; set; }

        /// <summary>The type of the shadow. This property is read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A PageElement kind representing a generic shape that doesn't have a more specific classification. For more
    /// information, see [Size and position page
    /// elements](https://developers.google.com/workspace/slides/api/guides/transform).
    /// </summary>
    public class Shape : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Placeholders are page elements that inherit from corresponding placeholders on layouts and masters. If set,
        /// the shape is a placeholder shape and any inherited properties can be resolved by looking at the parent
        /// placeholder identified by the Placeholder.parent_object_id field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placeholder")]
        public virtual Placeholder Placeholder { get; set; }

        /// <summary>The properties of the shape.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shapeProperties")]
        public virtual ShapeProperties ShapeProperties { get; set; }

        /// <summary>The type of the shape.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shapeType")]
        public virtual string ShapeType { get; set; }

        /// <summary>The text content of the shape.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual TextContent Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The shape background fill.</summary>
    public class ShapeBackgroundFill : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The background fill property state. Updating the fill on a shape will implicitly update this field to
        /// `RENDERED`, unless another value is specified in the same request. To have no fill on a shape, set this
        /// field to `NOT_RENDERED`. In this case, any other fill fields set in the same request will be ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("propertyState")]
        public virtual string PropertyState { get; set; }

        /// <summary>Solid color fill.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("solidFill")]
        public virtual SolidFill SolidFill { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The properties of a Shape. If the shape is a placeholder shape as determined by the placeholder field, then
    /// these properties may be inherited from a parent placeholder shape. Determining the rendered value of the
    /// property depends on the corresponding property_state field value. Any text autofit settings on the shape are
    /// automatically deactivated by requests that can impact how text fits in the shape.
    /// </summary>
    public class ShapeProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The autofit properties of the shape. This property is only set for shapes that allow text.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autofit")]
        public virtual Autofit Autofit { get; set; }

        /// <summary>
        /// The alignment of the content in the shape. If unspecified, the alignment is inherited from a parent
        /// placeholder if it exists. If the shape has no parent, the default alignment matches the alignment for new
        /// shapes created in the Slides editor.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentAlignment")]
        public virtual string ContentAlignment { get; set; }

        /// <summary>
        /// The hyperlink destination of the shape. If unset, there is no link. Links are not inherited from parent
        /// placeholders.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("link")]
        public virtual Link Link { get; set; }

        /// <summary>
        /// The outline of the shape. If unset, the outline is inherited from a parent placeholder if it exists. If the
        /// shape has no parent, then the default outline depends on the shape type, matching the defaults for new
        /// shapes created in the Slides editor.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outline")]
        public virtual Outline Outline { get; set; }

        /// <summary>
        /// The shadow properties of the shape. If unset, the shadow is inherited from a parent placeholder if it
        /// exists. If the shape has no parent, then the default shadow matches the defaults for new shapes created in
        /// the Slides editor. This property is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shadow")]
        public virtual Shadow Shadow { get; set; }

        /// <summary>
        /// The background fill of the shape. If unset, the background fill is inherited from a parent placeholder if it
        /// exists. If the shape has no parent, then the default background fill depends on the shape type, matching the
        /// defaults for new shapes created in the Slides editor.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shapeBackgroundFill")]
        public virtual ShapeBackgroundFill ShapeBackgroundFill { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A PageElement kind representing a linked chart embedded from Google Sheets.</summary>
    public class SheetsChart : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the specific chart in the Google Sheets spreadsheet that is embedded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chartId")]
        public virtual System.Nullable<int> ChartId { get; set; }

        /// <summary>
        /// The URL of an image of the embedded chart, with a default lifetime of 30 minutes. This URL is tagged with
        /// the account of the requester. Anyone with the URL effectively accesses the image as the original requester.
        /// Access to the image may be lost if the presentation's sharing settings change.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentUrl")]
        public virtual string ContentUrl { get; set; }

        /// <summary>The properties of the Sheets chart.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sheetsChartProperties")]
        public virtual SheetsChartProperties SheetsChartProperties { get; set; }

        /// <summary>The ID of the Google Sheets spreadsheet that contains the source chart.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spreadsheetId")]
        public virtual string SpreadsheetId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of the SheetsChart.</summary>
    public class SheetsChartProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The properties of the embedded chart image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chartImageProperties")]
        public virtual ImageProperties ChartImageProperties { get; set; }

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

    /// <summary>The properties of Page that are only relevant for pages with page_type SLIDE.</summary>
    public class SlideProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the slide is skipped in the presentation mode. Defaults to false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isSkipped")]
        public virtual System.Nullable<bool> IsSkipped { get; set; }

        /// <summary>The object ID of the layout that this slide is based on. This property is read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layoutObjectId")]
        public virtual string LayoutObjectId { get; set; }

        /// <summary>The object ID of the master that this slide is based on. This property is read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("masterObjectId")]
        public virtual string MasterObjectId { get; set; }

        /// <summary>
        /// The notes page that this slide is associated with. It defines the visual appearance of a notes page when
        /// printing or exporting slides with speaker notes. A notes page inherits properties from the notes master. The
        /// placeholder shape with type BODY on the notes page contains the speaker notes for this slide. The ID of this
        /// shape is identified by the speakerNotesObjectId field. The notes page is read-only except for the text
        /// content and styles of the speaker notes shape. This property is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notesPage")]
        public virtual Page NotesPage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A solid color fill. The page or page element is filled entirely with the specified color value. If any field is
    /// unset, its value may be inherited from a parent placeholder if it exists.
    /// </summary>
    public class SolidFill : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fraction of this `color` that should be applied to the pixel. That is, the final pixel color is defined
        /// by the equation: pixel color = alpha * (color) + (1.0 - alpha) * (background color) This means that a value
        /// of 1.0 corresponds to a solid color, whereas a value of 0.0 corresponds to a completely transparent color.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alpha")]
        public virtual System.Nullable<float> Alpha { get; set; }

        /// <summary>The color value of the solid fill.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual OpaqueColor Color { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A PageElement kind representing a Speaker Spotlight.</summary>
    public class SpeakerSpotlight : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The properties of the Speaker Spotlight.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("speakerSpotlightProperties")]
        public virtual SpeakerSpotlightProperties SpeakerSpotlightProperties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of the SpeakerSpotlight.</summary>
    public class SpeakerSpotlightProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The outline of the Speaker Spotlight. If not set, it has no outline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outline")]
        public virtual Outline Outline { get; set; }

        /// <summary>The shadow of the Speaker Spotlight. If not set, it has no shadow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shadow")]
        public virtual Shadow Shadow { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The stretched picture fill. The page or page element is filled entirely with the specified picture. The picture
    /// is stretched to fit its container.
    /// </summary>
    public class StretchedPictureFill : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Reading the content_url: An URL to a picture with a default lifetime of 30 minutes. This URL is tagged with
        /// the account of the requester. Anyone with the URL effectively accesses the picture as the original
        /// requester. Access to the picture may be lost if the presentation's sharing settings change. Writing the
        /// content_url: The picture is fetched once at insertion time and a copy is stored for display inside the
        /// presentation. Pictures must be less than 50MB in size, cannot exceed 25 megapixels, and must be in one of
        /// PNG, JPEG, or GIF format. The provided URL can be at most 2 kB in length.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentUrl")]
        public virtual string ContentUrl { get; set; }

        /// <summary>The original size of the picture fill. This field is read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("size")]
        public virtual Size Size { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A criteria that matches a specific string of text in a shape or table.</summary>
    public class SubstringMatchCriteria : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Indicates whether the search should respect case: - `True`: the search is case sensitive. - `False`: the
        /// search is case insensitive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchCase")]
        public virtual System.Nullable<bool> MatchCase { get; set; }

        /// <summary>
        /// Optional. True if the find value should be treated as a regular expression. Any backslashes in the pattern
        /// should be escaped. - `True`: the search text is treated as a regular expressions. - `False`: the search text
        /// is treated as a substring for matching.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchByRegex")]
        public virtual System.Nullable<bool> SearchByRegex { get; set; }

        /// <summary>The text to search for in the shape or table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A PageElement kind representing a table.</summary>
    public class Table : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of columns in the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columns")]
        public virtual System.Nullable<int> Columns { get; set; }

        /// <summary>
        /// Properties of horizontal cell borders. A table's horizontal cell borders are represented as a grid. The grid
        /// has one more row than the number of rows in the table and the same number of columns as the table. For
        /// example, if the table is 3 x 3, its horizontal borders will be represented as a grid with 4 rows and 3
        /// columns.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("horizontalBorderRows")]
        public virtual System.Collections.Generic.IList<TableBorderRow> HorizontalBorderRows { get; set; }

        /// <summary>Number of rows in the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Nullable<int> Rows { get; set; }

        /// <summary>Properties of each column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableColumns")]
        public virtual System.Collections.Generic.IList<TableColumnProperties> TableColumns { get; set; }

        /// <summary>
        /// Properties and contents of each row. Cells that span multiple rows are contained in only one of these rows
        /// and have a row_span greater than 1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableRows")]
        public virtual System.Collections.Generic.IList<TableRow> TableRows { get; set; }

        /// <summary>
        /// Properties of vertical cell borders. A table's vertical cell borders are represented as a grid. The grid has
        /// the same number of rows as the table and one more column than the number of columns in the table. For
        /// example, if the table is 3 x 3, its vertical borders will be represented as a grid with 3 rows and 4
        /// columns.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verticalBorderRows")]
        public virtual System.Collections.Generic.IList<TableBorderRow> VerticalBorderRows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of each border cell.</summary>
    public class TableBorderCell : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The location of the border within the border table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual TableCellLocation Location { get; set; }

        /// <summary>The border properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableBorderProperties")]
        public virtual TableBorderProperties TableBorderProperties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The fill of the border.</summary>
    public class TableBorderFill : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Solid fill.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("solidFill")]
        public virtual SolidFill SolidFill { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The border styling properties of the TableBorderCell.</summary>
    public class TableBorderProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The dash style of the border.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dashStyle")]
        public virtual string DashStyle { get; set; }

        /// <summary>The fill of the table border.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableBorderFill")]
        public virtual TableBorderFill TableBorderFill { get; set; }

        /// <summary>The thickness of the border.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weight")]
        public virtual Dimension Weight { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contents of each border row in a table.</summary>
    public class TableBorderRow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Properties of each border cell. When a border's adjacent table cells are merged, it is not included in the
        /// response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableBorderCells")]
        public virtual System.Collections.Generic.IList<TableBorderCell> TableBorderCells { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Properties and contents of each table cell.</summary>
    public class TableCell : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Column span of the cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnSpan")]
        public virtual System.Nullable<int> ColumnSpan { get; set; }

        /// <summary>The location of the cell within the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual TableCellLocation Location { get; set; }

        /// <summary>Row span of the cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowSpan")]
        public virtual System.Nullable<int> RowSpan { get; set; }

        /// <summary>The properties of the table cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableCellProperties")]
        public virtual TableCellProperties TableCellProperties { get; set; }

        /// <summary>The text content of the cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual TextContent Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The table cell background fill.</summary>
    public class TableCellBackgroundFill : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The background fill property state. Updating the fill on a table cell will implicitly update this field to
        /// `RENDERED`, unless another value is specified in the same request. To have no fill on a table cell, set this
        /// field to `NOT_RENDERED`. In this case, any other fill fields set in the same request will be ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("propertyState")]
        public virtual string PropertyState { get; set; }

        /// <summary>Solid color fill.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("solidFill")]
        public virtual SolidFill SolidFill { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A location of a single table cell within a table.</summary>
    public class TableCellLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The 0-based column index.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnIndex")]
        public virtual System.Nullable<int> ColumnIndex { get; set; }

        /// <summary>The 0-based row index.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowIndex")]
        public virtual System.Nullable<int> RowIndex { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of the TableCell.</summary>
    public class TableCellProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The alignment of the content in the table cell. The default alignment matches the alignment for newly
        /// created table cells in the Slides editor.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentAlignment")]
        public virtual string ContentAlignment { get; set; }

        /// <summary>
        /// The background fill of the table cell. The default fill matches the fill for newly created table cells in
        /// the Slides editor.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableCellBackgroundFill")]
        public virtual TableCellBackgroundFill TableCellBackgroundFill { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Properties of each column in a table.</summary>
    public class TableColumnProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Width of a column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnWidth")]
        public virtual Dimension ColumnWidth { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A table range represents a reference to a subset of a table. It's important to note that the cells specified by
    /// a table range do not necessarily form a rectangle. For example, let's say we have a 3 x 3 table where all the
    /// cells of the last row are merged together. The table looks like this: [ ] A table range with location = (0, 0),
    /// row span = 3 and column span = 2 specifies the following cells: x x [ x x x ]
    /// </summary>
    public class TableRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The column span of the table range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnSpan")]
        public virtual System.Nullable<int> ColumnSpan { get; set; }

        /// <summary>The starting location of the table range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual TableCellLocation Location { get; set; }

        /// <summary>The row span of the table range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowSpan")]
        public virtual System.Nullable<int> RowSpan { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Properties and contents of each row in a table.</summary>
    public class TableRow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Height of a row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowHeight")]
        public virtual Dimension RowHeight { get; set; }

        /// <summary>
        /// Properties and contents of each cell. Cells that span multiple columns are represented only once with a
        /// column_span greater than 1. As a result, the length of this collection does not always match the number of
        /// columns of the entire table.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableCells")]
        public virtual System.Collections.Generic.IList<TableCell> TableCells { get; set; }

        /// <summary>Properties of the row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableRowProperties")]
        public virtual TableRowProperties TableRowProperties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Properties of each row in a table.</summary>
    public class TableRowProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Minimum height of the row. The row will be rendered in the Slides editor at a height equal to or greater
        /// than this value in order to show all the text in the row's cell(s).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minRowHeight")]
        public virtual Dimension MinRowHeight { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The general text content. The text must reside in a compatible shape (e.g. text box or rectangle) or a table
    /// cell in a page.
    /// </summary>
    public class TextContent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The bulleted lists contained in this text, keyed by list ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lists")]
        public virtual System.Collections.Generic.IDictionary<string, List> Lists { get; set; }

        /// <summary>
        /// The text contents broken down into its component parts, including styling information. This property is
        /// read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textElements")]
        public virtual System.Collections.Generic.IList<TextElement> TextElements { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A TextElement describes the content of a range of indices in the text content of a Shape or TableCell.
    /// </summary>
    public class TextElement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A TextElement representing a spot in the text that is dynamically replaced with content that can change over
        /// time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoText")]
        public virtual AutoText AutoText { get; set; }

        /// <summary>The zero-based end index of this text element, exclusive, in Unicode code units.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endIndex")]
        public virtual System.Nullable<int> EndIndex { get; set; }

        /// <summary>
        /// A marker representing the beginning of a new paragraph. The `start_index` and `end_index` of this
        /// TextElement represent the range of the paragraph. Other TextElements with an index range contained inside
        /// this paragraph's range are considered to be part of this paragraph. The range of indices of two separate
        /// paragraphs will never overlap.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paragraphMarker")]
        public virtual ParagraphMarker ParagraphMarker { get; set; }

        /// <summary>The zero-based start index of this text element, in Unicode code units.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; }

        /// <summary>
        /// A TextElement representing a run of text where all of the characters in the run have the same TextStyle. The
        /// `start_index` and `end_index` of TextRuns will always be fully contained in the index range of a single
        /// `paragraph_marker` TextElement. In other words, a TextRun will never span multiple paragraphs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textRun")]
        public virtual TextRun TextRun { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A TextElement kind that represents a run of text that all has the same styling.</summary>
    public class TextRun : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The text of this run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>The styling applied to this run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("style")]
        public virtual TextStyle Style { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents the styling that can be applied to a TextRun. If this text is contained in a shape with a parent
    /// placeholder, then these text styles may be inherited from the parent. Which text styles are inherited depend on
    /// the nesting level of lists: * A text run in a paragraph that is not in a list will inherit its text style from
    /// the the newline character in the paragraph at the 0 nesting level of the list inside the parent placeholder. * A
    /// text run in a paragraph that is in a list will inherit its text style from the newline character in the
    /// paragraph at its corresponding nesting level of the list inside the parent placeholder. Inherited text styles
    /// are represented as unset fields in this message. If text is contained in a shape without a parent placeholder,
    /// unsetting these fields will revert the style to a value matching the defaults in the Slides editor.
    /// </summary>
    public class TextStyle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The background color of the text. If set, the color is either opaque or transparent, depending on if the
        /// `opaque_color` field in it is set.
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

        /// <summary>
        /// The font family of the text. The font family can be any font from the Font menu in Slides or from [Google
        /// Fonts] (https://fonts.google.com/). If the font name is unrecognized, the text is rendered in `Arial`. Some
        /// fonts can affect the weight of the text. If an update request specifies values for both `font_family` and
        /// `bold`, the explicitly-set `bold` value is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fontFamily")]
        public virtual string FontFamily { get; set; }

        /// <summary>The size of the text's font. When read, the `font_size` will specified in points.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fontSize")]
        public virtual Dimension FontSize { get; set; }

        /// <summary>
        /// The color of the text itself. If set, the color is either opaque or transparent, depending on if the
        /// `opaque_color` field in it is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("foregroundColor")]
        public virtual OptionalColor ForegroundColor { get; set; }

        /// <summary>Whether or not the text is italicized.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("italic")]
        public virtual System.Nullable<bool> Italic { get; set; }

        /// <summary>
        /// The hyperlink destination of the text. If unset, there is no link. Links are not inherited from parent text.
        /// Changing the link in an update request causes some other changes to the text style of the range: * When
        /// setting a link, the text foreground color will be set to ThemeColorType.HYPERLINK and the text will be
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
        /// The font family and rendered weight of the text. This field is an extension of `font_family` meant to
        /// support explicit font weights without breaking backwards compatibility. As such, when reading the style of a
        /// range of text, the value of `weighted_font_family#font_family` will always be equal to that of
        /// `font_family`. However, when writing, if both fields are included in the field mask (either explicitly or
        /// through the wildcard `"*"`), their values are reconciled as follows: * If `font_family` is set and
        /// `weighted_font_family` is not, the value of `font_family` is applied with weight `400` ("normal"). * If both
        /// fields are set, the value of `font_family` must match that of `weighted_font_family#font_family`. If so, the
        /// font family and weight of `weighted_font_family` is applied. Otherwise, a 400 bad request error is returned.
        /// * If `weighted_font_family` is set and `font_family` is not, the font family and weight of
        /// `weighted_font_family` is applied. * If neither field is set, the font family and weight of the text inherit
        /// from the parent. Note that these properties cannot inherit separately from each other. If an update request
        /// specifies values for both `weighted_font_family` and `bold`, the `weighted_font_family` is applied first,
        /// then `bold`. If `weighted_font_family#weight` is not set, it defaults to `400`. If `weighted_font_family` is
        /// set, then `weighted_font_family#font_family` must also be set with a non-empty value. Otherwise, a 400 bad
        /// request error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weightedFontFamily")]
        public virtual WeightedFontFamily WeightedFontFamily { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A pair mapping a theme color type to the concrete color it represents.</summary>
    public class ThemeColorPair : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The concrete color corresponding to the theme color type above.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual RgbColor Color { get; set; }

        /// <summary>The type of the theme color.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The thumbnail of a page.</summary>
    public class Thumbnail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The content URL of the thumbnail image. The URL to the image has a default lifetime of 30 minutes. This URL
        /// is tagged with the account of the requester. Anyone with the URL effectively accesses the image as the
        /// original requester. Access to the image may be lost if the presentation's sharing settings change. The mime
        /// type of the thumbnail image is the same as specified in the `GetPageThumbnailRequest`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentUrl")]
        public virtual string ContentUrl { get; set; }

        /// <summary>The positive height in pixels of the thumbnail image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual System.Nullable<int> Height { get; set; }

        /// <summary>The positive width in pixels of the thumbnail image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<int> Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Ungroups objects, such as groups.</summary>
    public class UngroupObjectsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The object IDs of the objects to ungroup. Only groups that are not inside other groups can be ungrouped. All
        /// the groups should be on the same page. The group itself is deleted. The visual sizes and positions of all
        /// the children are preserved.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectIds")]
        public virtual System.Collections.Generic.IList<string> ObjectIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Unmerges cells in a Table.</summary>
    public class UnmergeTableCellsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The object ID of the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>
        /// The table range specifying which cells of the table to unmerge. All merged cells in this range will be
        /// unmerged, and cells that are already unmerged will not be affected. If the range has no merged cells, the
        /// request will do nothing. If there is text in any of the merged cells, the text will remain in the upper-left
        /// ("head") cell of the resulting block of unmerged cells.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableRange")]
        public virtual TableRange TableRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Update the properties of an Image.</summary>
    public class UpdateImagePropertiesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fields that should be updated. At least one field must be specified. The root `imageProperties` is
        /// implied and should not be specified. A single `"*"` can be used as short-hand for listing every field. For
        /// example to update the image outline color, set `fields` to `"outline.outlineFill.solidFill.color"`. To reset
        /// a property to its default value, include its field name in the field mask but leave the field itself unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual object Fields { get; set; }

        /// <summary>The image properties to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageProperties")]
        public virtual ImageProperties ImageProperties { get; set; }

        /// <summary>The object ID of the image the updates are applied to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Updates the category of a line.</summary>
    public class UpdateLineCategoryRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The line category to update to. The exact line type is determined based on the category to update to and how
        /// it's routed to connect to other page elements.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineCategory")]
        public virtual string LineCategory { get; set; }

        /// <summary>
        /// The object ID of the line the update is applied to. Only a line with a category indicating it is a
        /// "connector" can be updated. The line may be rerouted after updating its category.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Updates the properties of a Line.</summary>
    public class UpdateLinePropertiesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fields that should be updated. At least one field must be specified. The root `lineProperties` is
        /// implied and should not be specified. A single `"*"` can be used as short-hand for listing every field. For
        /// example to update the line solid fill color, set `fields` to `"lineFill.solidFill.color"`. To reset a
        /// property to its default value, include its field name in the field mask but leave the field itself unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual object Fields { get; set; }

        /// <summary>The line properties to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineProperties")]
        public virtual LineProperties LineProperties { get; set; }

        /// <summary>The object ID of the line the update is applied to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Updates the alt text title and/or description of a page element.</summary>
    public class UpdatePageElementAltTextRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The updated alt text description of the page element. If unset the existing value will be maintained. The
        /// description is exposed to screen readers and other accessibility interfaces. Only use human readable values
        /// related to the content of the page element.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The object ID of the page element the updates are applied to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>
        /// The updated alt text title of the page element. If unset the existing value will be maintained. The title is
        /// exposed to screen readers and other accessibility interfaces. Only use human readable values related to the
        /// content of the page element.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Updates the transform of a page element. Updating the transform of a group will change the absolute transform of
    /// the page elements in that group, which can change their visual appearance. See the documentation for
    /// PageElement.transform for more details.
    /// </summary>
    public class UpdatePageElementTransformRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The apply mode of the transform update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applyMode")]
        public virtual string ApplyMode { get; set; }

        /// <summary>The object ID of the page element to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>The input transform matrix used to update the page element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transform")]
        public virtual AffineTransform Transform { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Updates the Z-order of page elements. Z-order is an ordering of the elements on the page from back to front. The
    /// page element in the front may cover the elements that are behind it.
    /// </summary>
    public class UpdatePageElementsZOrderRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The Z-order operation to apply on the page elements. When applying the operation on multiple page elements,
        /// the relative Z-orders within these page elements before the operation is maintained.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual string Operation { get; set; }

        /// <summary>
        /// The object IDs of the page elements to update. All the page elements must be on the same page and must not
        /// be grouped.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageElementObjectIds")]
        public virtual System.Collections.Generic.IList<string> PageElementObjectIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Updates the properties of a Page.</summary>
    public class UpdatePagePropertiesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fields that should be updated. At least one field must be specified. The root `pageProperties` is
        /// implied and should not be specified. A single `"*"` can be used as short-hand for listing every field. For
        /// example to update the page background solid fill color, set `fields` to
        /// `"pageBackgroundFill.solidFill.color"`. To reset a property to its default value, include its field name in
        /// the field mask but leave the field itself unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual object Fields { get; set; }

        /// <summary>The object ID of the page the update is applied to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>The page properties to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageProperties")]
        public virtual PageProperties PageProperties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Updates the styling for all of the paragraphs within a Shape or Table that overlap with the given text index
    /// range.
    /// </summary>
    public class UpdateParagraphStyleRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The location of the cell in the table containing the paragraph(s) to style. If `object_id` refers to a
        /// table, `cell_location` must have a value. Otherwise, it must not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cellLocation")]
        public virtual TableCellLocation CellLocation { get; set; }

        /// <summary>
        /// The fields that should be updated. At least one field must be specified. The root `style` is implied and
        /// should not be specified. A single `"*"` can be used as short-hand for listing every field. For example, to
        /// update the paragraph alignment, set `fields` to `"alignment"`. To reset a property to its default value,
        /// include its field name in the field mask but leave the field itself unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual object Fields { get; set; }

        /// <summary>The object ID of the shape or table with the text to be styled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>The paragraph's style.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("style")]
        public virtual ParagraphStyle Style { get; set; }

        /// <summary>The range of text containing the paragraph(s) to style.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textRange")]
        public virtual Range TextRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Update the properties of a Shape.</summary>
    public class UpdateShapePropertiesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fields that should be updated. At least one field must be specified. The root `shapeProperties` is
        /// implied and should not be specified. A single `"*"` can be used as short-hand for listing every field. For
        /// example to update the shape background solid fill color, set `fields` to
        /// `"shapeBackgroundFill.solidFill.color"`. To reset a property to its default value, include its field name in
        /// the field mask but leave the field itself unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual object Fields { get; set; }

        /// <summary>The object ID of the shape the updates are applied to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>The shape properties to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shapeProperties")]
        public virtual ShapeProperties ShapeProperties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Updates the properties of a Slide.</summary>
    public class UpdateSlidePropertiesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fields that should be updated. At least one field must be specified. The root 'slideProperties' is
        /// implied and should not be specified. A single `"*"` can be used as short-hand for listing every field. For
        /// example to update whether a slide is skipped, set `fields` to `"isSkipped"`. To reset a property to its
        /// default value, include its field name in the field mask but leave the field itself unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual object Fields { get; set; }

        /// <summary>The object ID of the slide the update is applied to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>The slide properties to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slideProperties")]
        public virtual SlideProperties SlideProperties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Updates the position of slides in the presentation.</summary>
    public class UpdateSlidesPositionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The index where the slides should be inserted, based on the slide arrangement before the move takes place.
        /// Must be between zero and the number of slides in the presentation, inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertionIndex")]
        public virtual System.Nullable<int> InsertionIndex { get; set; }

        /// <summary>
        /// The IDs of the slides in the presentation that should be moved. The slides in this list must be in existing
        /// presentation order, without duplicates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slideObjectIds")]
        public virtual System.Collections.Generic.IList<string> SlideObjectIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Updates the properties of the table borders in a Table.</summary>
    public class UpdateTableBorderPropertiesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The border position in the table range the updates should apply to. If a border position is not specified,
        /// the updates will apply to all borders in the table range.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("borderPosition")]
        public virtual string BorderPosition { get; set; }

        /// <summary>
        /// The fields that should be updated. At least one field must be specified. The root `tableBorderProperties` is
        /// implied and should not be specified. A single `"*"` can be used as short-hand for listing every field. For
        /// example to update the table border solid fill color, set `fields` to `"tableBorderFill.solidFill.color"`. To
        /// reset a property to its default value, include its field name in the field mask but leave the field itself
        /// unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual object Fields { get; set; }

        /// <summary>The object ID of the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>The table border properties to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableBorderProperties")]
        public virtual TableBorderProperties TableBorderProperties { get; set; }

        /// <summary>
        /// The table range representing the subset of the table to which the updates are applied. If a table range is
        /// not specified, the updates will apply to the entire table.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableRange")]
        public virtual TableRange TableRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Update the properties of a TableCell.</summary>
    public class UpdateTableCellPropertiesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fields that should be updated. At least one field must be specified. The root `tableCellProperties` is
        /// implied and should not be specified. A single `"*"` can be used as short-hand for listing every field. For
        /// example to update the table cell background solid fill color, set `fields` to
        /// `"tableCellBackgroundFill.solidFill.color"`. To reset a property to its default value, include its field
        /// name in the field mask but leave the field itself unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual object Fields { get; set; }

        /// <summary>The object ID of the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>The table cell properties to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableCellProperties")]
        public virtual TableCellProperties TableCellProperties { get; set; }

        /// <summary>
        /// The table range representing the subset of the table to which the updates are applied. If a table range is
        /// not specified, the updates will apply to the entire table.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableRange")]
        public virtual TableRange TableRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Updates the properties of a Table column.</summary>
    public class UpdateTableColumnPropertiesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of zero-based indices specifying which columns to update. If no indices are provided, all columns
        /// in the table will be updated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnIndices")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> ColumnIndices { get; set; }

        /// <summary>
        /// The fields that should be updated. At least one field must be specified. The root `tableColumnProperties` is
        /// implied and should not be specified. A single `"*"` can be used as short-hand for listing every field. For
        /// example to update the column width, set `fields` to `"column_width"`. If '"column_width"' is included in the
        /// field mask but the property is left unset, the column width will default to 406,400 EMU (32 points).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual object Fields { get; set; }

        /// <summary>The object ID of the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>
        /// The table column properties to update. If the value of `table_column_properties#column_width` in the request
        /// is less than 406,400 EMU (32 points), a 400 bad request error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableColumnProperties")]
        public virtual TableColumnProperties TableColumnProperties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Updates the properties of a Table row.</summary>
    public class UpdateTableRowPropertiesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fields that should be updated. At least one field must be specified. The root `tableRowProperties` is
        /// implied and should not be specified. A single `"*"` can be used as short-hand for listing every field. For
        /// example to update the minimum row height, set `fields` to `"min_row_height"`. If '"min_row_height"' is
        /// included in the field mask but the property is left unset, the minimum row height will default to 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual object Fields { get; set; }

        /// <summary>The object ID of the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>
        /// The list of zero-based indices specifying which rows to update. If no indices are provided, all rows in the
        /// table will be updated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowIndices")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> RowIndices { get; set; }

        /// <summary>The table row properties to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableRowProperties")]
        public virtual TableRowProperties TableRowProperties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Update the styling of text in a Shape or Table.</summary>
    public class UpdateTextStyleRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The location of the cell in the table containing the text to style. If `object_id` refers to a table,
        /// `cell_location` must have a value. Otherwise, it must not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cellLocation")]
        public virtual TableCellLocation CellLocation { get; set; }

        /// <summary>
        /// The fields that should be updated. At least one field must be specified. The root `style` is implied and
        /// should not be specified. A single `"*"` can be used as short-hand for listing every field. For example, to
        /// update the text style to bold, set `fields` to `"bold"`. To reset a property to its default value, include
        /// its field name in the field mask but leave the field itself unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual object Fields { get; set; }

        /// <summary>The object ID of the shape or table with the text to be styled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>
        /// The style(s) to set on the text. If the value for a particular style matches that of the parent, that style
        /// will be set to inherit. Certain text style changes may cause other changes meant to mirror the behavior of
        /// the Slides editor. See the documentation of TextStyle for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("style")]
        public virtual TextStyle Style { get; set; }

        /// <summary>
        /// The range of text to style. The range may be extended to include adjacent newlines. If the range fully
        /// contains a paragraph belonging to a list, the paragraph's bullet is also updated with the matching text
        /// style.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textRange")]
        public virtual Range TextRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Update the properties of a Video.</summary>
    public class UpdateVideoPropertiesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fields that should be updated. At least one field must be specified. The root `videoProperties` is
        /// implied and should not be specified. A single `"*"` can be used as short-hand for listing every field. For
        /// example to update the video outline color, set `fields` to `"outline.outlineFill.solidFill.color"`. To reset
        /// a property to its default value, include its field name in the field mask but leave the field itself unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual object Fields { get; set; }

        /// <summary>The object ID of the video the updates are applied to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>The video properties to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoProperties")]
        public virtual VideoProperties VideoProperties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A PageElement kind representing a video.</summary>
    public class Video : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The video source's unique identifier for this video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The video source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>
        /// An URL to a video. The URL is valid as long as the source video exists and sharing settings do not change.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The properties of the video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoProperties")]
        public virtual VideoProperties VideoProperties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of the Video.</summary>
    public class VideoProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether to enable video autoplay when the page is displayed in present mode. Defaults to false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoPlay")]
        public virtual System.Nullable<bool> AutoPlay { get; set; }

        /// <summary>
        /// The time at which to end playback, measured in seconds from the beginning of the video. If set, the end time
        /// should be after the start time. If not set or if you set this to a value that exceeds the video's length,
        /// the video will be played until its end.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("end")]
        public virtual System.Nullable<long> End { get; set; }

        /// <summary>Whether to mute the audio during video playback. Defaults to false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mute")]
        public virtual System.Nullable<bool> Mute { get; set; }

        /// <summary>
        /// The outline of the video. The default outline matches the defaults for new videos created in the Slides
        /// editor.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outline")]
        public virtual Outline Outline { get; set; }

        /// <summary>
        /// The time at which to start playback, measured in seconds from the beginning of the video. If set, the start
        /// time should be before the end time. If you set this to a value that exceeds the video's length in seconds,
        /// the video will be played from the last second. If not set, the video will be played from the beginning.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("start")]
        public virtual System.Nullable<long> Start { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a font family and weight used to style a TextRun.</summary>
    public class WeightedFontFamily : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The font family of the text. The font family can be any font from the Font menu in Slides or from [Google
        /// Fonts] (https://fonts.google.com/). If the font name is unrecognized, the text is rendered in `Arial`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fontFamily")]
        public virtual string FontFamily { get; set; }

        /// <summary>
        /// The rendered weight of the text. This field can have any value that is a multiple of `100` between `100` and
        /// `900`, inclusive. This range corresponds to the numerical values described in the CSS 2.1 Specification,
        /// [section 15.6](https://www.w3.org/TR/CSS21/fonts.html#font-boldness), with non-numerical values disallowed.
        /// Weights greater than or equal to `700` are considered bold, and weights less than `700`are not bold. The
        /// default value is `400` ("normal").
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weight")]
        public virtual System.Nullable<int> Weight { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A PageElement kind representing word art.</summary>
    public class WordArt : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The text rendered as word art.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("renderedText")]
        public virtual string RenderedText { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Provides control over how write requests are executed.</summary>
    public class WriteControl : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The revision ID of the presentation required for the write request. If specified and the required revision
        /// ID doesn't match the presentation's current revision ID, the request is not processed and returns a 400 bad
        /// request error. When a required revision ID is returned in a response, it indicates the revision ID of the
        /// document after the request was applied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requiredRevisionId")]
        public virtual string RequiredRevisionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
