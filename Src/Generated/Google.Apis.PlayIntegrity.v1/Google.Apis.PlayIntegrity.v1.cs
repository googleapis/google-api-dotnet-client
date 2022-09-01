// Copyright 2022 Google LLC
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
            V1 = new V1Resource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "playintegrity";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://playintegrity.googleapis.com/";
        #else
            "https://playintegrity.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://playintegrity.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

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
            return new DecodeIntegrityTokenRequest(service, body, packageName);
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
    }
}
namespace Google.Apis.PlayIntegrity.v1.Data
{
    /// <summary>Contains the account information such as the licensing status for the user in the scope.</summary>
    public class AccountDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Details about the account risk for the user in the scope. This feature is available only to selected
        /// developers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountRiskVerdict")]
        public virtual AccountRiskVerdict AccountRiskVerdict { get; set; }

        /// <summary>Required. Details about the licensing status of the user for the app in the scope.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appLicensingVerdict")]
        public virtual string AppLicensingVerdict { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains information about account risk that indicates if the current user session seems low risk, unknown, or
    /// risky before you allow important actions to proceed.
    /// </summary>
    public class AccountRiskVerdict : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Indicates the account risk level of the current user session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("risk")]
        public virtual string Risk { get; set; }

        /// <summary>Required. Indicates the account risk level of the current user session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("riskLevel")]
        public virtual string RiskLevel { get; set; }

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
        /// Hex fingerprint of the application signing certificate. e.g. “ABCE1F....” Set iff app_recognition_verdict !=
        /// UNEVALUATED.
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

    /// <summary>Contains the device attestation information.</summary>
    public class DeviceIntegrity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Details about the integrity of the device the app is running on</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceRecognitionVerdict")]
        public virtual System.Collections.Generic.IList<string> DeviceRecognitionVerdict { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains the integrity request information.</summary>
    public class RequestDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Nonce that was provided in the request (which is base64 web-safe no-wrap).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nonce")]
        public virtual string Nonce { get; set; }

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
}
