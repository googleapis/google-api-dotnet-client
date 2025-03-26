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

namespace Google.Apis.Verifiedaccess.v2
{
    /// <summary>The Verifiedaccess Service.</summary>
    public class VerifiedaccessService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public VerifiedaccessService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public VerifiedaccessService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Challenge = new ChallengeResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://verifiedaccess.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://verifiedaccess.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "verifiedaccess";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Chrome Verified Access API.</summary>
        public class Scope
        {
            /// <summary>Verify your enterprise credentials</summary>
            public static string Verifiedaccess = "https://www.googleapis.com/auth/verifiedaccess";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Chrome Verified Access API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Verify your enterprise credentials</summary>
            public const string Verifiedaccess = "https://www.googleapis.com/auth/verifiedaccess";
        }

        /// <summary>Gets the Challenge resource.</summary>
        public virtual ChallengeResource Challenge { get; }
    }

    /// <summary>A base abstract class for Verifiedaccess requests.</summary>
    public abstract class VerifiedaccessBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new VerifiedaccessBaseServiceRequest instance.</summary>
        protected VerifiedaccessBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Verifiedaccess parameter list.</summary>
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

    /// <summary>The "challenge" collection of methods.</summary>
    public class ChallengeResource
    {
        private const string Resource = "challenge";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ChallengeResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Generates a new challenge.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual GenerateRequest Generate(Google.Apis.Verifiedaccess.v2.Data.Empty body)
        {
            return new GenerateRequest(this.service, body);
        }

        /// <summary>Generates a new challenge.</summary>
        public class GenerateRequest : VerifiedaccessBaseServiceRequest<Google.Apis.Verifiedaccess.v2.Data.Challenge>
        {
            /// <summary>Constructs a new Generate request.</summary>
            public GenerateRequest(Google.Apis.Services.IClientService service, Google.Apis.Verifiedaccess.v2.Data.Empty body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Verifiedaccess.v2.Data.Empty Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "generate";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/challenge:generate";

            /// <summary>Initializes Generate parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Verifies the challenge response.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual VerifyRequest Verify(Google.Apis.Verifiedaccess.v2.Data.VerifyChallengeResponseRequest body)
        {
            return new VerifyRequest(this.service, body);
        }

        /// <summary>Verifies the challenge response.</summary>
        public class VerifyRequest : VerifiedaccessBaseServiceRequest<Google.Apis.Verifiedaccess.v2.Data.VerifyChallengeResponseResult>
        {
            /// <summary>Constructs a new Verify request.</summary>
            public VerifyRequest(Google.Apis.Services.IClientService service, Google.Apis.Verifiedaccess.v2.Data.VerifyChallengeResponseRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Verifiedaccess.v2.Data.VerifyChallengeResponseRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "verify";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/challenge:verify";

            /// <summary>Initializes Verify parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }
}
namespace Google.Apis.Verifiedaccess.v2.Data
{
    /// <summary>Antivirus information on a device.</summary>
    public class Antivirus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The state of the antivirus on the device. Introduced in Chrome M136.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Result message for VerifiedAccess.GenerateChallenge.</summary>
    public class Challenge : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Generated challenge, the bytes representation of SignedData.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("challenge")]
        public virtual string ChallengeValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Properties of the CrowdStrike agent installed on a device.</summary>
    public class CrowdStrikeAgent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The Agent ID of the Crowdstrike agent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agentId")]
        public virtual string AgentId { get; set; }

        /// <summary>Output only. The Customer ID to which the agent belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerId")]
        public virtual string CustomerId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The device signals as reported by Chrome. Unless otherwise specified, signals are available on all platforms.
    /// </summary>
    public class DeviceSignals : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Value of the AllowScreenLock policy on the device. See
        /// https://chromeenterprise.google/policies/?policy=AllowScreenLock for more details. Available on ChromeOS
        /// only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowScreenLock")]
        public virtual System.Nullable<bool> AllowScreenLock { get; set; }

        /// <summary>
        /// Output only. Information about Antivirus software on the device. Available on Windows only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("antivirus")]
        public virtual Antivirus Antivirus { get; set; }

        /// <summary>
        /// Output only. Current version of the Chrome browser which generated this set of signals. Example value:
        /// "107.0.5286.0".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("browserVersion")]
        public virtual string BrowserVersion { get; set; }

        /// <summary>
        /// Output only. Whether Chrome's built-in DNS client is used. The OS DNS client is otherwise used. This value
        /// may be controlled by an enterprise policy:
        /// https://chromeenterprise.google/policies/#BuiltInDnsClientEnabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("builtInDnsClientEnabled")]
        public virtual System.Nullable<bool> BuiltInDnsClientEnabled { get; set; }

        /// <summary>
        /// Output only. Whether access to the Chrome Remote Desktop application is blocked via a policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chromeRemoteDesktopAppBlocked")]
        public virtual System.Nullable<bool> ChromeRemoteDesktopAppBlocked { get; set; }

        /// <summary>
        /// Output only. Crowdstrike agent properties installed on the device, if any. Available on Windows and MacOS
        /// only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crowdStrikeAgent")]
        public virtual CrowdStrikeAgent CrowdStrikeAgent { get; set; }

        /// <summary>
        /// Output only. Affiliation IDs of the organizations that are affiliated with the organization that is
        /// currently managing the device. When the sets of device and profile affiliation IDs overlap, it means that
        /// the organizations managing the device and user are affiliated. To learn more about user affiliation, visit
        /// https://support.google.com/chrome/a/answer/12801245?ref_topic=9027936.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceAffiliationIds")]
        public virtual System.Collections.Generic.IList<string> DeviceAffiliationIds { get; set; }

        /// <summary>Output only. Enrollment domain of the customer which is currently managing the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceEnrollmentDomain")]
        public virtual string DeviceEnrollmentDomain { get; set; }

        /// <summary>Output only. The name of the device's manufacturer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceManufacturer")]
        public virtual string DeviceManufacturer { get; set; }

        /// <summary>Output only. The name of the device's model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceModel")]
        public virtual string DeviceModel { get; set; }

        /// <summary>
        /// Output only. The encryption state of the disk. On ChromeOS, the main disk is always ENCRYPTED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskEncryption")]
        public virtual string DiskEncryption { get; set; }

        /// <summary>Output only. The display name of the device, as defined by the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Hostname of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostname")]
        public virtual string Hostname { get; set; }

        /// <summary>
        /// Output only. International Mobile Equipment Identity (IMEI) of the device. Available on ChromeOS only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imei")]
        public virtual System.Collections.Generic.IList<string> Imei { get; set; }

        /// <summary>Output only. MAC addresses of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("macAddresses")]
        public virtual System.Collections.Generic.IList<string> MacAddresses { get; set; }

        /// <summary>
        /// Output only. Mobile Equipment Identifier (MEID) of the device. Available on ChromeOS only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meid")]
        public virtual System.Collections.Generic.IList<string> Meid { get; set; }

        /// <summary>Output only. The type of the Operating System currently running on the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatingSystem")]
        public virtual string OperatingSystem { get; set; }

        /// <summary>
        /// Output only. The state of the OS level firewall. On ChromeOS, the value will always be ENABLED on regular
        /// devices and UNKNOWN on devices in developer mode. Support for MacOS 15 (Sequoia) and later has been
        /// introduced in Chrome M131.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osFirewall")]
        public virtual string OsFirewall { get; set; }

        /// <summary>
        /// Output only. The current version of the Operating System. On Windows and linux, the value will also include
        /// the security patch information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osVersion")]
        public virtual string OsVersion { get; set; }

        /// <summary>
        /// Output only. Whether the Password Protection Warning feature is enabled or not. Password protection alerts
        /// users when they reuse their protected password on potentially suspicious sites. This setting is controlled
        /// by an enterprise policy: https://chromeenterprise.google/policies/#PasswordProtectionWarningTrigger. Note
        /// that the policy unset does not have the same effects as having the policy explicitly set to
        /// `PASSWORD_PROTECTION_OFF`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordProtectionWarningTrigger")]
        public virtual string PasswordProtectionWarningTrigger { get; set; }

        /// <summary>
        /// Output only. Affiliation IDs of the organizations that are affiliated with the organization that is
        /// currently managing the Chrome Profile’s user or ChromeOS user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profileAffiliationIds")]
        public virtual System.Collections.Generic.IList<string> ProfileAffiliationIds { get; set; }

        /// <summary>Output only. Enrollment domain of the customer which is currently managing the profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profileEnrollmentDomain")]
        public virtual string ProfileEnrollmentDomain { get; set; }

        /// <summary>
        /// Output only. Whether Enterprise-grade (i.e. custom) unsafe URL scanning is enabled or not. This setting may
        /// be controlled by an enterprise policy:
        /// https://chromeenterprise.google/policies/#EnterpriseRealTimeUrlCheckMode
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("realtimeUrlCheckMode")]
        public virtual string RealtimeUrlCheckMode { get; set; }

        /// <summary>
        /// Output only. Safe Browsing Protection Level. That setting may be controlled by an enterprise policy:
        /// https://chromeenterprise.google/policies/#SafeBrowsingProtectionLevel.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("safeBrowsingProtectionLevel")]
        public virtual string SafeBrowsingProtectionLevel { get; set; }

        /// <summary>
        /// Output only. The state of the Screen Lock password protection. On ChromeOS, this value will always be
        /// ENABLED as there is not way to disable requiring a password or pin when unlocking the device.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenLockSecured")]
        public virtual string ScreenLockSecured { get; set; }

        /// <summary>
        /// Output only. Whether the device's startup software has its Secure Boot feature enabled. Available on Windows
        /// only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secureBootMode")]
        public virtual string SecureBootMode { get; set; }

        /// <summary>
        /// Output only. The serial number of the device. On Windows, this represents the BIOS's serial number. Not
        /// available on most Linux distributions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serialNumber")]
        public virtual string SerialNumber { get; set; }

        /// <summary>
        /// Output only. Whether the Site Isolation (a.k.a Site Per Process) setting is enabled. That setting may be
        /// controlled by an enterprise policy: https://chromeenterprise.google/policies/#SitePerProcess
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("siteIsolationEnabled")]
        public virtual System.Nullable<bool> SiteIsolationEnabled { get; set; }

        /// <summary>
        /// List of the addesses of all OS level DNS servers configured in the device's network settings.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemDnsServers")]
        public virtual System.Collections.Generic.IList<string> SystemDnsServers { get; set; }

        /// <summary>
        /// Output only. Deprecated. The corresponding policy is now deprecated. Whether Chrome is blocking third-party
        /// software injection or not. This setting may be controlled by an enterprise policy:
        /// https://chromeenterprise.google/policies/?policy=ThirdPartyBlockingEnabled. Available on Windows only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thirdPartyBlockingEnabled")]
        public virtual System.Nullable<bool> ThirdPartyBlockingEnabled { get; set; }

        /// <summary>Output only. The trigger which generated this set of signals.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trigger")]
        public virtual string Trigger { get; set; }

        /// <summary>
        /// Output only. Windows domain that the current machine has joined. Available on Windows only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("windowsMachineDomain")]
        public virtual string WindowsMachineDomain { get; set; }

        /// <summary>Output only. Windows domain for the current OS user. Available on Windows only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("windowsUserDomain")]
        public virtual string WindowsUserDomain { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); }
    /// </summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Signed ChallengeResponse.</summary>
    public class VerifyChallengeResponseRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The generated response to the challenge, the bytes representation of SignedData.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("challengeResponse")]
        public virtual string ChallengeResponse { get; set; }

        /// <summary>
        /// Optional. Service can optionally provide identity information about the device or user associated with the
        /// key. For an EMK, this value is the enrolled domain. For an EUK, this value is the user's email address. If
        /// present, this value will be checked against contents of the response, and verification will fail if there is
        /// no match.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expectedIdentity")]
        public virtual string ExpectedIdentity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Result message for VerifiedAccess.VerifyChallengeResponse. The response returned when successful for Managed
    /// profiles on Unmanaged browsers will NOT have devicePermanentId, keyTrustLevel, virtualDeviceId and customerId
    /// fields. Managed profiles will INSTEAD have the profileCustomerId, virtualProfileId, profilePermanentId and
    /// profileKeyTrustLevel fields.
    /// </summary>
    public class VerifyChallengeResponseResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Attested device ID (ADID).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attestedDeviceId")]
        public virtual string AttestedDeviceId { get; set; }

        /// <summary>
        /// Output only. Unique customer id that this device belongs to, as defined by the Google Admin SDK at
        /// https://developers.google.com/admin-sdk/directory/v1/guides/manage-customers
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerId")]
        public virtual string CustomerId { get; set; }

        /// <summary>Output only. Device enrollment id for ChromeOS devices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceEnrollmentId")]
        public virtual string DeviceEnrollmentId { get; set; }

        /// <summary>
        /// Output only. Device permanent id is returned in this field (for the machine response only).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("devicePermanentId")]
        public virtual string DevicePermanentId { get; set; }

        /// <summary>
        /// Output only. Deprecated. Device signal in json string representation. Prefer using `device_signals` instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceSignal")]
        public virtual string DeviceSignal { get; set; }

        /// <summary>Output only. Device signals.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceSignals")]
        public virtual DeviceSignals DeviceSignals { get; set; }

        /// <summary>Output only. Device attested key trust level.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyTrustLevel")]
        public virtual string KeyTrustLevel { get; set; }

        /// <summary>
        /// Output only. Unique customer id that this profile belongs to, as defined by the Google Admin SDK at
        /// https://developers.google.com/admin-sdk/directory/v1/guides/manage-customers
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profileCustomerId")]
        public virtual string ProfileCustomerId { get; set; }

        /// <summary>Output only. Profile attested key trust level.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profileKeyTrustLevel")]
        public virtual string ProfileKeyTrustLevel { get; set; }

        /// <summary>Output only. The unique server-side ID of a profile on the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profilePermanentId")]
        public virtual string ProfilePermanentId { get; set; }

        /// <summary>
        /// Output only. Certificate Signing Request (in the SPKAC format, base64 encoded) is returned in this field.
        /// This field will be set only if device has included CSR in its challenge response. (the option to include CSR
        /// is now available for both user and machine responses)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signedPublicKeyAndChallenge")]
        public virtual string SignedPublicKeyAndChallenge { get; set; }

        /// <summary>
        /// Output only. Virtual device id of the device. The definition of virtual device id is platform-specific.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("virtualDeviceId")]
        public virtual string VirtualDeviceId { get; set; }

        /// <summary>Output only. The client-provided ID of a profile on the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("virtualProfileId")]
        public virtual string VirtualProfileId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
