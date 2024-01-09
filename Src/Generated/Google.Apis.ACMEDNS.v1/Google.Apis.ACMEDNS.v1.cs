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

namespace Google.Apis.ACMEDNS.v1
{
    /// <summary>The ACMEDNS Service.</summary>
    public class ACMEDNSService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public ACMEDNSService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public ACMEDNSService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            AcmeChallengeSets = new AcmeChallengeSetsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "acmedns";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri => BaseUriOverride ?? "https://acmedns.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://acmedns.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Gets the AcmeChallengeSets resource.</summary>
        public virtual AcmeChallengeSetsResource AcmeChallengeSets { get; }
    }

    /// <summary>A base abstract class for ACMEDNS requests.</summary>
    public abstract class ACMEDNSBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new ACMEDNSBaseServiceRequest instance.</summary>
        protected ACMEDNSBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes ACMEDNS parameter list.</summary>
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

    /// <summary>The "acmeChallengeSets" collection of methods.</summary>
    public class AcmeChallengeSetsResource
    {
        private const string Resource = "acmeChallengeSets";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AcmeChallengeSetsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Gets the ACME challenge set for a given domain name. Domain names must be provided in Punycode.
        /// </summary>
        /// <param name="rootDomain">
        /// Required. SLD + TLD domain name to list challenges. For example, this would be "google.com" for any FQDN
        /// under "google.com". That includes challenges for "subdomain.google.com". This MAY be Unicode or Punycode.
        /// </param>
        public virtual GetRequest Get(string rootDomain)
        {
            return new GetRequest(this.service, rootDomain);
        }

        /// <summary>
        /// Gets the ACME challenge set for a given domain name. Domain names must be provided in Punycode.
        /// </summary>
        public class GetRequest : ACMEDNSBaseServiceRequest<Google.Apis.ACMEDNS.v1.Data.AcmeChallengeSet>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string rootDomain) : base(service)
            {
                RootDomain = rootDomain;
                InitParameters();
            }

            /// <summary>
            /// Required. SLD + TLD domain name to list challenges. For example, this would be "google.com" for any FQDN
            /// under "google.com". That includes challenges for "subdomain.google.com". This MAY be Unicode or
            /// Punycode.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("rootDomain", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string RootDomain { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/acmeChallengeSets/{rootDomain}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("rootDomain", new Google.Apis.Discovery.Parameter
                {
                    Name = "rootDomain",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Rotate the ACME challenges for a given domain name. By default, removes any challenges that are older than
        /// 30 days. Domain names must be provided in Punycode.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="rootDomain">
        /// Required. SLD + TLD domain name to update records for. For example, this would be "google.com" for any FQDN
        /// under "google.com". That includes challenges for "subdomain.google.com". This MAY be Unicode or Punycode.
        /// </param>
        public virtual RotateChallengesRequest RotateChallenges(Google.Apis.ACMEDNS.v1.Data.RotateChallengesRequest body, string rootDomain)
        {
            return new RotateChallengesRequest(this.service, body, rootDomain);
        }

        /// <summary>
        /// Rotate the ACME challenges for a given domain name. By default, removes any challenges that are older than
        /// 30 days. Domain names must be provided in Punycode.
        /// </summary>
        public class RotateChallengesRequest : ACMEDNSBaseServiceRequest<Google.Apis.ACMEDNS.v1.Data.AcmeChallengeSet>
        {
            /// <summary>Constructs a new RotateChallenges request.</summary>
            public RotateChallengesRequest(Google.Apis.Services.IClientService service, Google.Apis.ACMEDNS.v1.Data.RotateChallengesRequest body, string rootDomain) : base(service)
            {
                RootDomain = rootDomain;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. SLD + TLD domain name to update records for. For example, this would be "google.com" for any
            /// FQDN under "google.com". That includes challenges for "subdomain.google.com". This MAY be Unicode or
            /// Punycode.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("rootDomain", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string RootDomain { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ACMEDNS.v1.Data.RotateChallengesRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "rotateChallenges";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/acmeChallengeSets/{rootDomain}:rotateChallenges";

            /// <summary>Initializes RotateChallenges parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("rootDomain", new Google.Apis.Discovery.Parameter
                {
                    Name = "rootDomain",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.ACMEDNS.v1.Data
{
    /// <summary>
    /// The up-to-date ACME challenge set on a domain for an RPC. This contains all of the ACME TXT records that exist
    /// on the domain.
    /// </summary>
    public class AcmeChallengeSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ACME challenges on the requested domain represented as individual TXT records.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("record")]
        public virtual System.Collections.Generic.IList<AcmeTxtRecord> Record { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The TXT record message that represents an ACME DNS-01 challenge.</summary>
    public class AcmeTxtRecord : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Holds the ACME challenge data put in the TXT record. This will be checked to be a valid TXT record data
        /// entry.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("digest")]
        public virtual string Digest { get; set; }

        /// <summary>
        /// The domain/subdomain for the record. In a request, this MAY be Unicode or Punycode. In a response, this will
        /// be in Unicode. The fqdn MUST contain the root_domain field on the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fqdn")]
        public virtual string Fqdn { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time when this record was last updated. This will be in UTC time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual string UpdateTimeRaw
        {
            get => _updateTimeRaw;
            set
            {
                _updateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _updateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdateTimeDateTimeOffset instead.")]
        public virtual object UpdateTime
        {
            get => _updateTime;
            set
            {
                _updateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _updateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The request message for the RotateChallenges RPC. Requires an access token, a root domain, and either
    /// records_to_add or records_to_remove to be populated. Records may be set for multiple subdomains at once to
    /// support SAN requests for multiple subdomains in a single domain. By default, ACME TXT record challenges that are
    /// older than 30 days will be removed. Set `keep_expired_records` to false if this behavior is undesired. There is
    /// a record maximum of 100 records per domain including expired records. Any request sent that would exceed this
    /// maximum will result in a FAILED_PRECONDITION error. NEXT ID: 6
    /// </summary>
    public class RotateChallengesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. ACME DNS access token. This is a base64 token secret that is procured from the Google Domains
        /// website. It authorizes ACME TXT record updates for a domain.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessToken")]
        public virtual string AccessToken { get; set; }

        /// <summary>Keep records older than 30 days that were used for previous requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keepExpiredRecords")]
        public virtual System.Nullable<bool> KeepExpiredRecords { get; set; }

        /// <summary>ACME TXT record challenges to add. Supports multiple challenges on the same FQDN.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordsToAdd")]
        public virtual System.Collections.Generic.IList<AcmeTxtRecord> RecordsToAdd { get; set; }

        /// <summary>ACME TXT record challenges to remove.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordsToRemove")]
        public virtual System.Collections.Generic.IList<AcmeTxtRecord> RecordsToRemove { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
