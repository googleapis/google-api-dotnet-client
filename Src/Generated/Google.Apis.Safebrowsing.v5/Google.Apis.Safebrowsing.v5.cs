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

namespace Google.Apis.Safebrowsing.v5
{
    /// <summary>The Safebrowsing Service.</summary>
    public class SafebrowsingService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v5";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public SafebrowsingService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public SafebrowsingService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Hashes = new HashesResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "safebrowsing";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri => BaseUriOverride ?? "https://safebrowsing.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://safebrowsing.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Gets the Hashes resource.</summary>
        public virtual HashesResource Hashes { get; }
    }

    /// <summary>A base abstract class for Safebrowsing requests.</summary>
    public abstract class SafebrowsingBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new SafebrowsingBaseServiceRequest instance.</summary>
        protected SafebrowsingBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Safebrowsing parameter list.</summary>
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

    /// <summary>The "hashes" collection of methods.</summary>
    public class HashesResource
    {
        private const string Resource = "hashes";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public HashesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Search for full hashes matching the specified prefixes. This is a custom method as defined by
        /// https://google.aip.dev/136 (the custom method refers to this method having a custom name within Google's
        /// general API development nomenclature; it does not refer to using a custom HTTP method).
        /// </summary>
        public virtual SearchRequest Search()
        {
            return new SearchRequest(this.service);
        }

        /// <summary>
        /// Search for full hashes matching the specified prefixes. This is a custom method as defined by
        /// https://google.aip.dev/136 (the custom method refers to this method having a custom name within Google's
        /// general API development nomenclature; it does not refer to using a custom HTTP method).
        /// </summary>
        public class SearchRequest : SafebrowsingBaseServiceRequest<Google.Apis.Safebrowsing.v5.Data.GoogleSecuritySafebrowsingV5SearchHashesResponse>
        {
            /// <summary>Constructs a new Search request.</summary>
            public SearchRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Required. The hash prefixes to be looked up. Clients MUST NOT send more than 1000 hash prefixes.
            /// However, following the URL processing procedure, clients SHOULD NOT need to send more than 30 hash
            /// prefixes. Currently each hash prefix is required to be exactly 4 bytes long. This MAY be relaxed in the
            /// future.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("hashPrefixes", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> HashPrefixes { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "search";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v5/hashes:search";

            /// <summary>Initializes Search parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("hashPrefixes", new Google.Apis.Discovery.Parameter
                {
                    Name = "hashPrefixes",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.Safebrowsing.v5.Data
{
    /// <summary>The full hash identified with one or more matches.</summary>
    public class GoogleSecuritySafebrowsingV5FullHash : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The matching full hash. This is the SHA256 hash. The length will be exactly 32 bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullHash")]
        public virtual string FullHash { get; set; }

        /// <summary>Unordered list. A repeated field identifying the details relevant to this full hash.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullHashDetails")]
        public virtual System.Collections.Generic.IList<GoogleSecuritySafebrowsingV5FullHashFullHashDetail> FullHashDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details about a matching full hash. An important note about forward compatibility: new threat types and threat
    /// attributes may be added by the server at any time; those additions are considered minor version changes. It is
    /// Google's policy not to expose minor version numbers in APIs (see https://cloud.google.com/apis/design/versioning
    /// for the versioning policy), so clients MUST be prepared to receive `FullHashDetail` messages containing
    /// `ThreatType` enum values or `ThreatAttribute` enum values that are considered invalid by the client. Therefore,
    /// it is the client's responsibility to check for the validity of all `ThreatType` and `ThreatAttribute` enum
    /// values; if any value is considered invalid, the client MUST disregard the entire `FullHashDetail` message.
    /// </summary>
    public class GoogleSecuritySafebrowsingV5FullHashFullHashDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Unordered list. Additional attributes about those full hashes. This may be empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IList<string> Attributes { get; set; }

        /// <summary>The type of threat. This field will never be empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threatType")]
        public virtual string ThreatType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The response returned after searching threat hashes. If nothing is found, the server will return an OK status
    /// (HTTP status code 200) with the `full_hashes` field empty, rather than returning a NOT_FOUND status (HTTP status
    /// code 404). **What's new in V5**: There is a separation between FullHash and FullHashDetail. In the case when a
    /// hash represents a site having multiple threats (e.g. both MALWARE and SOCIAL_ENGINEERING), the full hash does
    /// not need to be sent twice as in V4. Furthermore, the cache duration has been simplified into a single
    /// `cache_duration` field.
    /// </summary>
    public class GoogleSecuritySafebrowsingV5SearchHashesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The client-side cache duration. The client MUST add this duration to the current time to determine the
        /// expiration time. The expiration time then applies to every hash prefix queried by the client in the request,
        /// regardless of how many full hashes are returned in the response. Even if the server returns no full hashes
        /// for a particular hash prefix, this fact MUST also be cached by the client. Important: the client MUST NOT
        /// assume that the server will return the same cache duration for all responses. The server MAY choose
        /// different cache durations for different responses depending on the situation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cacheDuration")]
        public virtual object CacheDuration { get; set; }

        /// <summary>Unordered list. The unordered list of full hashes found.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullHashes")]
        public virtual System.Collections.Generic.IList<GoogleSecuritySafebrowsingV5FullHash> FullHashes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
