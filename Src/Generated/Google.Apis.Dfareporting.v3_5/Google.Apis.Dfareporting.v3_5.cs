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

namespace Google.Apis.Dfareporting.v3_5
{
    /// <summary>The Dfareporting Service.</summary>
    public class DfareportingService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v3.5";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DfareportingService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DfareportingService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Media = new MediaResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "dfareporting";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri => BaseUriOverride ?? "https://dfareporting.googleapis.com/dfareporting/v3.5/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "dfareporting/v3.5/";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://dfareporting.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Campaign Manager 360 API.</summary>
        public class Scope
        {
            /// <summary>View and manage your DoubleClick Campaign Manager's (DCM) display ad campaigns</summary>
            public static string Dfatrafficking = "https://www.googleapis.com/auth/dfatrafficking";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Campaign Manager 360 API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your DoubleClick Campaign Manager's (DCM) display ad campaigns</summary>
            public const string Dfatrafficking = "https://www.googleapis.com/auth/dfatrafficking";
        }

        /// <summary>Gets the Media resource.</summary>
        public virtual MediaResource Media { get; }
    }

    /// <summary>A base abstract class for Dfareporting requests.</summary>
    public abstract class DfareportingBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new DfareportingBaseServiceRequest instance.</summary>
        protected DfareportingBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Dfareporting parameter list.</summary>
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

        /// <summary>Inserts a new creative asset.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="advertiserId">Advertiser ID of this creative. This is a required field.</param>
        public virtual UploadRequest Upload(Google.Apis.Dfareporting.v3_5.Data.CreativeAssetMetadata body, long profileId, long advertiserId)
        {
            return new UploadRequest(this.service, body, profileId, advertiserId);
        }

        /// <summary>Inserts a new creative asset.</summary>
        public class UploadRequest : DfareportingBaseServiceRequest<Google.Apis.Dfareporting.v3_5.Data.CreativeAssetMetadata>
        {
            /// <summary>Constructs a new Upload request.</summary>
            public UploadRequest(Google.Apis.Services.IClientService service, Google.Apis.Dfareporting.v3_5.Data.CreativeAssetMetadata body, long profileId, long advertiserId) : base(service)
            {
                ProfileId = profileId;
                AdvertiserId = advertiserId;
                Body = body;
                InitParameters();
            }

            /// <summary>User profile ID associated with this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("profileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long ProfileId { get; private set; }

            /// <summary>Advertiser ID of this creative. This is a required field.</summary>
            [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long AdvertiserId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Dfareporting.v3_5.Data.CreativeAssetMetadata Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "upload";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "userprofiles/{+profileId}/creativeAssets/{+advertiserId}/creativeAssets";

            /// <summary>Initializes Upload parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("profileId", new Google.Apis.Discovery.Parameter
                {
                    Name = "profileId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
                RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                {
                    Name = "advertiserId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
            }
        }

        /// <summary>Inserts a new creative asset.</summary>
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
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="advertiserId">Advertiser ID of this creative. This is a required field.</param>
        /// <param name="stream">The stream to upload. See remarks for further information.</param>
        /// <param name="contentType">The content type of the stream to upload.</param>
        public virtual UploadMediaUpload Upload(Google.Apis.Dfareporting.v3_5.Data.CreativeAssetMetadata body, long profileId, long advertiserId, System.IO.Stream stream, string contentType)
        {
            return new UploadMediaUpload(service, body, profileId, advertiserId, stream, contentType);
        }

        /// <summary>Upload media upload which supports resumable upload.</summary>
        public class UploadMediaUpload : Google.Apis.Upload.ResumableUpload<Google.Apis.Dfareporting.v3_5.Data.CreativeAssetMetadata, Google.Apis.Dfareporting.v3_5.Data.CreativeAssetMetadata>
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

            /// <summary>User profile ID associated with this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("profileId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long ProfileId { get; private set; }

            /// <summary>Advertiser ID of this creative. This is a required field.</summary>
            [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long AdvertiserId { get; private set; }

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
            public UploadMediaUpload(Google.Apis.Services.IClientService service, Google.Apis.Dfareporting.v3_5.Data.CreativeAssetMetadata body, long profileId, long advertiserId, System.IO.Stream stream, string contentType)
                : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "userprofiles/{+profileId}/creativeAssets/{+advertiserId}/creativeAssets"), "POST", stream, contentType)
            {
                ProfileId = profileId;
                AdvertiserId = advertiserId;
                Body = body;
            }
        }
    }
}
namespace Google.Apis.Dfareporting.v3_5.Data
{
    /// <summary>Creative Click Tag.</summary>
    public class ClickTag : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Parameter value for the specified click tag. This field contains a click-through url.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clickThroughUrl")]
        public virtual CreativeClickThroughUrl ClickThroughUrl { get; set; }

        /// <summary>
        /// Advertiser event name associated with the click tag. This field is used by DISPLAY_IMAGE_GALLERY and
        /// HTML5_BANNER creatives. Applicable to DISPLAY when the primary asset type is not HTML_IMAGE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventName")]
        public virtual string EventName { get; set; }

        /// <summary>
        /// Parameter name for the specified click tag. For DISPLAY_IMAGE_GALLERY creative assets, this field must match
        /// the value of the creative asset's creativeAssetId.name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Creative Asset ID.</summary>
    public class CreativeAssetId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Name of the creative asset. This is a required field while inserting an asset. After insertion, this
        /// assetIdentifier is used to identify the uploaded asset. Characters in the name must be alphanumeric or one
        /// of the following: ".-_ ". Spaces are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Type of asset to upload. This is a required field. FLASH and IMAGE are no longer supported for new uploads.
        /// All image assets should use HTML_IMAGE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// CreativeAssets contains properties of a creative asset file which will be uploaded or has already been uploaded.
    /// Refer to the creative sample code for how to upload assets and insert a creative.
    /// </summary>
    public class CreativeAssetMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ID of the creative asset. This is a required field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetIdentifier")]
        public virtual CreativeAssetId AssetIdentifier { get; set; }

        /// <summary>
        /// List of detected click tags for assets. This is a read-only, auto-generated field. This field is empty for a
        /// rich media asset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clickTags")]
        public virtual System.Collections.Generic.IList<ClickTag> ClickTags { get; set; }

        /// <summary>
        /// List of counter events configured for the asset. This is a read-only, auto-generated field and only
        /// applicable to a rich media asset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("counterCustomEvents")]
        public virtual System.Collections.Generic.IList<CreativeCustomEvent> CounterCustomEvents { get; set; }

        /// <summary>
        /// List of feature dependencies for the creative asset that are detected by Campaign Manager. Feature
        /// dependencies are features that a browser must be able to support in order to render your HTML5 creative
        /// correctly. This is a read-only, auto-generated field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedFeatures")]
        public virtual System.Collections.Generic.IList<string> DetectedFeatures { get; set; }

        /// <summary>
        /// List of exit events configured for the asset. This is a read-only, auto-generated field and only applicable
        /// to a rich media asset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exitCustomEvents")]
        public virtual System.Collections.Generic.IList<CreativeCustomEvent> ExitCustomEvents { get; set; }

        /// <summary>Numeric ID of the asset. This is a read-only, auto-generated field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>
        /// Dimension value for the numeric ID of the asset. This is a read-only, auto-generated field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("idDimensionValue")]
        public virtual DimensionValue IdDimensionValue { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "dfareporting#creativeAssetMetadata".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("mediaRequestInfo")]
        public virtual MediaRequestInfo MediaRequestInfo { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("mediaResponseInfo")]
        public virtual MediaResponseInfo MediaResponseInfo { get; set; }

        /// <summary>
        /// True if the uploaded asset is a rich media asset. This is a read-only, auto-generated field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("richMedia")]
        public virtual System.Nullable<bool> RichMedia { get; set; }

        /// <summary>
        /// List of timer events configured for the asset. This is a read-only, auto-generated field and only applicable
        /// to a rich media asset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timerCustomEvents")]
        public virtual System.Collections.Generic.IList<CreativeCustomEvent> TimerCustomEvents { get; set; }

        /// <summary>
        /// Rules validated during code generation that generated a warning. This is a read-only, auto-generated field.
        /// Possible values are: - "ADMOB_REFERENCED" - "ASSET_FORMAT_UNSUPPORTED_DCM" - "ASSET_INVALID" -
        /// "CLICK_TAG_HARD_CODED" - "CLICK_TAG_INVALID" - "CLICK_TAG_IN_GWD" - "CLICK_TAG_MISSING" -
        /// "CLICK_TAG_MORE_THAN_ONE" - "CLICK_TAG_NON_TOP_LEVEL" - "COMPONENT_UNSUPPORTED_DCM" -
        /// "ENABLER_UNSUPPORTED_METHOD_DCM" - "EXTERNAL_FILE_REFERENCED" - "FILE_DETAIL_EMPTY" - "FILE_TYPE_INVALID" -
        /// "GWD_PROPERTIES_INVALID" - "HTML5_FEATURE_UNSUPPORTED" - "LINKED_FILE_NOT_FOUND" - "MAX_FLASH_VERSION_11" -
        /// "MRAID_REFERENCED" - "NOT_SSL_COMPLIANT" - "ORPHANED_ASSET" - "PRIMARY_HTML_MISSING" - "SVG_INVALID" -
        /// "ZIP_INVALID"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warnedValidationRules")]
        public virtual System.Collections.Generic.IList<string> WarnedValidationRules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Click-through URL</summary>
    public class CreativeClickThroughUrl : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Read-only convenience field representing the actual URL that will be used for this click-through. The URL is
        /// computed as follows: - If landingPageId is specified then that landing page's URL is assigned to this field.
        /// - Otherwise, the customClickThroughUrl is assigned to this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computedClickThroughUrl")]
        public virtual string ComputedClickThroughUrl { get; set; }

        /// <summary>Custom click-through URL. Applicable if the landingPageId field is left unset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customClickThroughUrl")]
        public virtual string CustomClickThroughUrl { get; set; }

        /// <summary>ID of the landing page for the click-through URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("landingPageId")]
        public virtual System.Nullable<long> LandingPageId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Creative Custom Event.</summary>
    public class CreativeCustomEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Unique ID of this event used by Reporting and Data Transfer. This is a read-only field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserCustomEventId")]
        public virtual System.Nullable<long> AdvertiserCustomEventId { get; set; }

        /// <summary>User-entered name for the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserCustomEventName")]
        public virtual string AdvertiserCustomEventName { get; set; }

        /// <summary>Type of the event. This is a read-only field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserCustomEventType")]
        public virtual string AdvertiserCustomEventType { get; set; }

        /// <summary>
        /// Artwork label column, used to link events in Campaign Manager back to events in Studio. This is a required
        /// field and should not be modified after insertion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artworkLabel")]
        public virtual string ArtworkLabel { get; set; }

        /// <summary>Artwork type used by the creative.This is a read-only field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artworkType")]
        public virtual string ArtworkType { get; set; }

        /// <summary>Exit click-through URL for the event. This field is used only for exit events.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exitClickThroughUrl")]
        public virtual CreativeClickThroughUrl ExitClickThroughUrl { get; set; }

        /// <summary>ID of this event. This is a required field and should not be modified after insertion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>Properties for rich media popup windows. This field is used only for exit events.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("popupWindowProperties")]
        public virtual PopupWindowProperties PopupWindowProperties { get; set; }

        /// <summary>Target type used by the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetType")]
        public virtual string TargetType { get; set; }

        /// <summary>
        /// Video reporting ID, used to differentiate multiple videos in a single creative. This is a read-only field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoReportingId")]
        public virtual string VideoReportingId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a DimensionValue resource.</summary>
    public class DimensionValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the dimension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionName")]
        public virtual string DimensionName { get; set; }

        /// <summary>The eTag of this response for caching purposes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The ID associated with the value if available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The kind of resource this is, in this case dfareporting#dimensionValue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Determines how the 'value' field is matched when filtering. If not specified, defaults to EXACT. If set to
        /// WILDCARD_EXPRESSION, '*' is allowed as a placeholder for variable length character sequences, and it can be
        /// escaped with a backslash. Note, only paid search dimensions ('dfa:paidSearch*') allow a matchType other than
        /// EXACT.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchType")]
        public virtual string MatchType { get; set; }

        /// <summary>The value of the dimension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }
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
    /// This message is for backends to pass their scotty media specific fields to ESF. Backend will include this in
    /// their response message to ESF. Example: ExportFile is an rpc defined for upload using scotty from ESF. rpc
    /// ExportFile(ExportFileRequest) returns (ExportFileResponse) Message ExportFileResponse will include
    /// apiserving.MediaResponseInfo to tell ESF about data like dynamic_dropzone it needs to pass to Scotty. message
    /// ExportFileResponse { optional gdata.Media blob = 1; optional apiserving.MediaResponseInfo media_response_info =
    /// 2 }
    /// </summary>
    public class MediaResponseInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Data to copy from backend response to the next backend requests. Custom data is returned to Scotty in the
        /// agent_state field, which Scotty will then provide in subsequent upload notifications.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customData")]
        public virtual string CustomData { get; set; }

        /// <summary>
        /// Specifies any transformation to be applied to data before persisting it or retrieving from storage. E.g.,
        /// encryption options for blobstore2. This should be of the form uploader_service.DataStorageTransform.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataStorageTransform")]
        public virtual string DataStorageTransform { get; set; }

        /// <summary>
        /// Specifies the Scotty Drop Target to use for uploads. If present in a media response, Scotty does not upload
        /// to a standard drop zone. Instead, Scotty saves the upload directly to the location specified in this drop
        /// target. Unlike drop zones, the drop target is the final storage location for an upload. So, the agent does
        /// not need to clone the blob at the end of the upload. The agent is responsible for garbage collecting any
        /// orphaned blobs that may occur due to aborted uploads. For more information, see the drop target design doc
        /// here: http://goto/ScottyDropTarget This field will be preferred to dynamicDropzone. If provided, the
        /// identified field in the response must be of the type uploader.agent.DropTarget.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dynamicDropTarget")]
        public virtual string DynamicDropTarget { get; set; }

        /// <summary>Specifies the Scotty dropzone to use for uploads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dynamicDropzone")]
        public virtual string DynamicDropzone { get; set; }

        /// <summary>Request class to use for all Blobstore operations for this request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestClass")]
        public virtual string RequestClass { get; set; }

        /// <summary>Requester ID passed along to be recorded in the Scotty logs</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scottyAgentUserId")]
        public virtual System.Nullable<long> ScottyAgentUserId { get; set; }

        /// <summary>
        /// Customer-specific data to be recorded in the Scotty logs type is logs_proto_scotty.CustomerLog
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scottyCustomerLog")]
        public virtual string ScottyCustomerLog { get; set; }

        /// <summary>
        /// Specifies the TrafficClass that Scotty should use for any RPCs to fetch the response bytes. Will override
        /// the traffic class GTOS of the incoming http request. This is a temporary field to facilitate whitelisting
        /// and experimentation by the bigstore agent only. For instance, this does not apply to RTMP reads. WARNING: DO
        /// NOT USE WITHOUT PERMISSION FROM THE SCOTTY TEAM.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trafficClassField")]
        public virtual string TrafficClassField { get; set; }

        /// <summary>
        /// Tells Scotty to verify hashes on the agent's behalf by parsing out the X-Goog-Hash header.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verifyHashFromHeader")]
        public virtual System.Nullable<bool> VerifyHashFromHeader { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Offset Position.</summary>
    public class OffsetPosition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Offset distance from left side of an asset or a window.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("left")]
        public virtual System.Nullable<int> Left { get; set; }

        /// <summary>Offset distance from top side of an asset or a window.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("top")]
        public virtual System.Nullable<int> Top { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Popup Window Properties.</summary>
    public class PopupWindowProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Popup dimension for a creative. This is a read-only field. Applicable to the following creative types: all
        /// RICH_MEDIA and all VPAID
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimension")]
        public virtual Size Dimension { get; set; }

        /// <summary>
        /// Upper-left corner coordinates of the popup window. Applicable if positionType is COORDINATES.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offset")]
        public virtual OffsetPosition Offset { get; set; }

        /// <summary>Popup window position either centered or at specific coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("positionType")]
        public virtual string PositionType { get; set; }

        /// <summary>Whether to display the browser address bar.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("showAddressBar")]
        public virtual System.Nullable<bool> ShowAddressBar { get; set; }

        /// <summary>Whether to display the browser menu bar.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("showMenuBar")]
        public virtual System.Nullable<bool> ShowMenuBar { get; set; }

        /// <summary>Whether to display the browser scroll bar.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("showScrollBar")]
        public virtual System.Nullable<bool> ShowScrollBar { get; set; }

        /// <summary>Whether to display the browser status bar.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("showStatusBar")]
        public virtual System.Nullable<bool> ShowStatusBar { get; set; }

        /// <summary>Whether to display the browser tool bar.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("showToolBar")]
        public virtual System.Nullable<bool> ShowToolBar { get; set; }

        /// <summary>Title of popup window.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the dimensions of ads, placements, creatives, or creative assets.</summary>
    public class Size : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Height of this size. Acceptable values are 0 to 32767, inclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual System.Nullable<int> Height { get; set; }

        /// <summary>IAB standard size. This is a read-only, auto-generated field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iab")]
        public virtual System.Nullable<bool> Iab { get; set; }

        /// <summary>ID of this size. This is a read-only, auto-generated field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>Identifies what kind of resource this is. Value: the fixed string "dfareporting#size".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Width of this size. Acceptable values are 0 to 32767, inclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<int> Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
