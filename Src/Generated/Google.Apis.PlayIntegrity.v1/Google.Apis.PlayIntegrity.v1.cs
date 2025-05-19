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

namespace Google.Apis.PlayIntegrity.v1
{
    /// <summary>The PlayIntegrity Service.</summary>
    public class PlayIntegrityService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public PlayIntegrityService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public PlayIntegrityService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            DeviceRecall = new DeviceRecallResource(this);
            V1 = new V1Resource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://playintegrity.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://playintegrity.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "playintegrity";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Google Play Integrity API.</summary>
        public class Scope
        {
            /// <summary>Private Service: https://www.googleapis.com/auth/playintegrity</summary>
            public static string Playintegrity = "https://www.googleapis.com/auth/playintegrity";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Google Play Integrity API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Private Service: https://www.googleapis.com/auth/playintegrity</summary>
            public const string Playintegrity = "https://www.googleapis.com/auth/playintegrity";
        }

        /// <summary>Gets the DeviceRecall resource.</summary>
        public virtual DeviceRecallResource DeviceRecall { get; }

        /// <summary>Gets the V1 resource.</summary>
        public virtual V1Resource V1 { get; }
    }

    /// <summary>A base abstract class for PlayIntegrity requests.</summary>
    public abstract class PlayIntegrityBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new PlayIntegrityBaseServiceRequest instance.</summary>
        protected PlayIntegrityBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes PlayIntegrity parameter list.</summary>
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

    /// <summary>The "deviceRecall" collection of methods.</summary>
    public class DeviceRecallResource
    {
        private const string Resource = "deviceRecall";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public DeviceRecallResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Writes recall bits for the device where Play Integrity API token is obtained. The endpoint is available to
        /// select Play partners in an early access program (EAP).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="packageName">Required. Package name of the app the attached integrity token belongs to.</param>
        public virtual WriteRequest Write(Google.Apis.PlayIntegrity.v1.Data.WriteDeviceRecallRequest body, string packageName)
        {
            return new WriteRequest(this.service, body, packageName);
        }

        /// <summary>
        /// Writes recall bits for the device where Play Integrity API token is obtained. The endpoint is available to
        /// select Play partners in an early access program (EAP).
        /// </summary>
        public class WriteRequest : PlayIntegrityBaseServiceRequest<Google.Apis.PlayIntegrity.v1.Data.WriteDeviceRecallResponse>
        {
            /// <summary>Constructs a new Write request.</summary>
            public WriteRequest(Google.Apis.Services.IClientService service, Google.Apis.PlayIntegrity.v1.Data.WriteDeviceRecallRequest body, string packageName) : base(service)
            {
                PackageName = packageName;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Package name of the app the attached integrity token belongs to.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.PlayIntegrity.v1.Data.WriteDeviceRecallRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "write";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+packageName}/deviceRecall:write";

            /// <summary>Initializes Write parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
            }
        }
    }

    /// <summary>The "v1" collection of methods.</summary>
    public class V1Resource
    {
        private const string Resource = "v1";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public V1Resource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Decodes the integrity token and returns the token payload.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="packageName"> Package name of the app the attached integrity token belongs to.</param>
        public virtual DecodeIntegrityTokenRequest DecodeIntegrityToken(Google.Apis.PlayIntegrity.v1.Data.DecodeIntegrityTokenRequest body, string packageName)
        {
            return new DecodeIntegrityTokenRequest(this.service, body, packageName);
        }

        /// <summary>Decodes the integrity token and returns the token payload.</summary>
        public class DecodeIntegrityTokenRequest : PlayIntegrityBaseServiceRequest<Google.Apis.PlayIntegrity.v1.Data.DecodeIntegrityTokenResponse>
        {
            /// <summary>Constructs a new DecodeIntegrityToken request.</summary>
            public DecodeIntegrityTokenRequest(Google.Apis.Services.IClientService service, Google.Apis.PlayIntegrity.v1.Data.DecodeIntegrityTokenRequest body, string packageName) : base(service)
            {
                PackageName = packageName;
                Body = body;
                InitParameters();
            }

            /// <summary> Package name of the app the attached integrity token belongs to.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.PlayIntegrity.v1.Data.DecodeIntegrityTokenRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "decodeIntegrityToken";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+packageName}:decodeIntegrityToken";

            /// <summary>Initializes DecodeIntegrityToken parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
            }
        }

        /// <summary>Decodes the PC integrity token and returns the PC token payload.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="packageName">Package name of the app the attached integrity token belongs to.</param>
        public virtual DecodePcIntegrityTokenRequest DecodePcIntegrityToken(Google.Apis.PlayIntegrity.v1.Data.DecodePcIntegrityTokenRequest body, string packageName)
        {
            return new DecodePcIntegrityTokenRequest(this.service, body, packageName);
        }

        /// <summary>Decodes the PC integrity token and returns the PC token payload.</summary>
        public class DecodePcIntegrityTokenRequest : PlayIntegrityBaseServiceRequest<Google.Apis.PlayIntegrity.v1.Data.DecodePcIntegrityTokenResponse>
        {
            /// <summary>Constructs a new DecodePcIntegrityToken request.</summary>
            public DecodePcIntegrityTokenRequest(Google.Apis.Services.IClientService service, Google.Apis.PlayIntegrity.v1.Data.DecodePcIntegrityTokenRequest body, string packageName) : base(service)
            {
                PackageName = packageName;
                Body = body;
                InitParameters();
            }

            /// <summary>Package name of the app the attached integrity token belongs to.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.PlayIntegrity.v1.Data.DecodePcIntegrityTokenRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "decodePcIntegrityToken";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+packageName}:decodePcIntegrityToken";

            /// <summary>Initializes DecodePcIntegrityToken parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+$",
                });
            }
        }
    }
}
namespace Google.Apis.PlayIntegrity.v1.Data
{
    /// <summary>
    /// (Restricted Access) Contains a signal helping apps differentiating between likely genuine and likely non-genuine
    /// user traffic.
    /// </summary>
    public class AccountActivity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Indicates the activity level of the account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activityLevel")]
        public virtual string ActivityLevel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains the account information such as the licensing status for the user in the scope.</summary>
    public class AccountDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>(Restricted Access) Details about the account activity for the user in the scope.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountActivity")]
        public virtual AccountActivity AccountActivity { get; set; }

        /// <summary>Required. Details about the licensing status of the user for the app in the scope.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appLicensingVerdict")]
        public virtual string AppLicensingVerdict { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains signals about others apps on the device which could be used to access or control the requesting app.
    /// </summary>
    public class AppAccessRiskVerdict : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of detected app types signalled for App Access Risk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appsDetected")]
        public virtual System.Collections.Generic.IList<string> AppsDetected { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains the application integrity information.</summary>
    public class AppIntegrity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Details about the app recognition verdict</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appRecognitionVerdict")]
        public virtual string AppRecognitionVerdict { get; set; }

        /// <summary>
        /// The SHA256 hash of the requesting app's signing certificates (base64 web-safe encoded). Set iff
        /// app_recognition_verdict != UNEVALUATED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificateSha256Digest")]
        public virtual System.Collections.Generic.IList<string> CertificateSha256Digest { get; set; }

        /// <summary>
        /// Package name of the application under attestation. Set iff app_recognition_verdict != UNEVALUATED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>Version code of the application. Set iff app_recognition_verdict != UNEVALUATED.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionCode")]
        public virtual System.Nullable<long> VersionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to decode the integrity token.</summary>
    public class DecodeIntegrityTokenRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Encoded integrity token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integrityToken")]
        public virtual string IntegrityToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response containing the decoded integrity payload.</summary>
    public class DecodeIntegrityTokenResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Plain token payload generated from the decoded integrity token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokenPayloadExternal")]
        public virtual TokenPayloadExternal TokenPayloadExternal { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to decode the PC integrity token.</summary>
    public class DecodePcIntegrityTokenRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Encoded integrity token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integrityToken")]
        public virtual string IntegrityToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response containing the decoded PC integrity payload.</summary>
    public class DecodePcIntegrityTokenResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Plain token payload generated from the decoded integrity token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokenPayloadExternal")]
        public virtual PcTokenPayloadExternal TokenPayloadExternal { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains information about the device for which the integrity token was generated, e.g. Android SDK version.
    /// </summary>
    public class DeviceAttributes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Android SDK version of the device, as defined in the public Android documentation:
        /// https://developer.android.com/reference/android/os/Build.VERSION_CODES. It won't be set if a necessary
        /// requirement was missed. For example DeviceIntegrity did not meet the minimum bar.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sdkVersion")]
        public virtual System.Nullable<int> SdkVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains the device attestation information.</summary>
    public class DeviceIntegrity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Attributes of the device where the integrity token was generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceAttributes")]
        public virtual DeviceAttributes DeviceAttributes { get; set; }

        /// <summary>Details about the device recall bits set by the developer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceRecall")]
        public virtual DeviceRecall DeviceRecall { get; set; }

        /// <summary>Details about the integrity of the device the app is running on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceRecognitionVerdict")]
        public virtual System.Collections.Generic.IList<string> DeviceRecognitionVerdict { get; set; }

        /// <summary>
        /// Contains legacy details about the integrity of the device the app is running on. Only for devices with
        /// Android version T or higher and only for apps opted in to the new verdicts. Only available during the
        /// transition period to the new verdicts system and will be removed afterwards.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("legacyDeviceRecognitionVerdict")]
        public virtual System.Collections.Generic.IList<string> LegacyDeviceRecognitionVerdict { get; set; }

        /// <summary>Details about the device activity of the device the app is running on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recentDeviceActivity")]
        public virtual RecentDeviceActivity RecentDeviceActivity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains the recall bits per device set by the developer.</summary>
    public class DeviceRecall : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Contains the recall bits values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual Values Values { get; set; }

        /// <summary>Required. Contains the recall bits write dates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writeDates")]
        public virtual WriteDates WriteDates { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains information about the environment Play Integrity API runs in, e.g. Play Protect verdict.
    /// </summary>
    public class EnvironmentDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The evaluation of the App Access Risk verdicts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appAccessRiskVerdict")]
        public virtual AppAccessRiskVerdict AppAccessRiskVerdict { get; set; }

        /// <summary>The evaluation of Play Protect verdict.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("playProtectVerdict")]
        public virtual string PlayProtectVerdict { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains the device attestation information.</summary>
    public class PcDeviceIntegrity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Details about the integrity of the device the app is running on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceRecognitionVerdict")]
        public virtual System.Collections.Generic.IList<string> DeviceRecognitionVerdict { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains the integrity request information.</summary>
    public class PcRequestDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Request hash that was provided in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestHash")]
        public virtual string RequestHash { get; set; }

        /// <summary>
        /// Required. Application package name this attestation was requested for. Note: This field makes no guarantees
        /// or promises on the caller integrity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestPackageName")]
        public virtual string RequestPackageName { get; set; }

        private string _requestTimeRaw;

        private object _requestTime;

        /// <summary>Required. Timestamp, of the integrity application request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestTime")]
        public virtual string RequestTimeRaw
        {
            get => _requestTimeRaw;
            set
            {
                _requestTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _requestTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RequestTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RequestTimeDateTimeOffset instead.")]
        public virtual object RequestTime
        {
            get => _requestTime;
            set
            {
                _requestTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _requestTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="RequestTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RequestTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RequestTimeRaw);
            set => RequestTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains PC device attestation details.</summary>
    public class PcTokenPayloadExternal : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Details about the device integrity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceIntegrity")]
        public virtual PcDeviceIntegrity DeviceIntegrity { get; set; }

        /// <summary>Required. Details about the integrity request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestDetails")]
        public virtual PcRequestDetails RequestDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Recent device activity can help developers identify devices that have exhibited hyperactive attestation
    /// activity, which could be a sign of an attack or token farming.
    /// </summary>
    public class RecentDeviceActivity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Indicates the activity level of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceActivityLevel")]
        public virtual string DeviceActivityLevel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains the integrity request information.</summary>
    public class RequestDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Nonce that was provided in the request (which is base64 web-safe no-wrap).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nonce")]
        public virtual string Nonce { get; set; }

        /// <summary>Request hash that was provided in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestHash")]
        public virtual string RequestHash { get; set; }

        /// <summary>
        /// Required. Application package name this attestation was requested for. Note: This field makes no guarantees
        /// or promises on the caller integrity. For details on application integrity, check application_integrity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestPackageName")]
        public virtual string RequestPackageName { get; set; }

        /// <summary>Required. Timestamp, in milliseconds, of the integrity application request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestampMillis")]
        public virtual System.Nullable<long> TimestampMillis { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains additional information generated for testing responses.</summary>
    public class TestingDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Indicates that the information contained in this payload is a testing response that is statically
        /// overridden for a tester.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isTestingResponse")]
        public virtual System.Nullable<bool> IsTestingResponse { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains basic app information and integrity signals like device attestation and licensing details.
    /// </summary>
    public class TokenPayloadExternal : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Details about the Play Store account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountDetails")]
        public virtual AccountDetails AccountDetails { get; set; }

        /// <summary>Required. Details about the application integrity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appIntegrity")]
        public virtual AppIntegrity AppIntegrity { get; set; }

        /// <summary>Required. Details about the device integrity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceIntegrity")]
        public virtual DeviceIntegrity DeviceIntegrity { get; set; }

        /// <summary>Details of the environment Play Integrity API runs in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environmentDetails")]
        public virtual EnvironmentDetails EnvironmentDetails { get; set; }

        /// <summary>Required. Details about the integrity request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestDetails")]
        public virtual RequestDetails RequestDetails { get; set; }

        /// <summary>
        /// Indicates that this payload is generated for testing purposes and contains any additional data that is
        /// linked with testing status.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testingDetails")]
        public virtual TestingDetails TestingDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains the recall bits values.</summary>
    public class Values : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. First recall bit value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bitFirst")]
        public virtual System.Nullable<bool> BitFirst { get; set; }

        /// <summary>Required. Second recall bit value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bitSecond")]
        public virtual System.Nullable<bool> BitSecond { get; set; }

        /// <summary>Required. Third recall bit value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bitThird")]
        public virtual System.Nullable<bool> BitThird { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains the recall bits write dates.</summary>
    public class WriteDates : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Write time in YYYYMM format (in UTC, e.g. 202402) for the first bit. Note that this value won't be
        /// set if the first bit is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yyyymmFirst")]
        public virtual System.Nullable<int> YyyymmFirst { get; set; }

        /// <summary>
        /// Optional. Write time in YYYYMM format (in UTC, e.g. 202402) for the second bit. Note that this value won't
        /// be set if the second bit is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yyyymmSecond")]
        public virtual System.Nullable<int> YyyymmSecond { get; set; }

        /// <summary>
        /// Optional. Write time in YYYYMM format (in UTC, e.g. 202402) for the third bit. Note that this value won't be
        /// set if the third bit is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yyyymmThird")]
        public virtual System.Nullable<int> YyyymmThird { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to write device recall bits.</summary>
    public class WriteDeviceRecallRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Integrity token obtained from calling Play Integrity API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integrityToken")]
        public virtual string IntegrityToken { get; set; }

        /// <summary>Required. The new values for the device recall bits to be written.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newValues")]
        public virtual Values NewValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the Write Device Recall action. Currently empty.</summary>
    public class WriteDeviceRecallResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
