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
            HashList = new HashListResource(this);
            HashLists = new HashListsResource(this);
            Hashes = new HashesResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://safebrowsing.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://safebrowsing.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "safebrowsing";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Gets the HashList resource.</summary>
        public virtual HashListResource HashList { get; }

        /// <summary>Gets the HashLists resource.</summary>
        public virtual HashListsResource HashLists { get; }

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

    /// <summary>The "hashList" collection of methods.</summary>
    public class HashListResource
    {
        private const string Resource = "hashList";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public HashListResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Get the latest contents of a hash list. A hash list may either by a threat list or a non-threat list such as
        /// the Global Cache. This is a standard Get method as defined by https://google.aip.dev/131 and the HTTP method
        /// is also GET.
        /// </summary>
        /// <param name="name">
        /// Required. The name of this particular hash list. It may be a threat list, or it may be the Global Cache.
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(this.service, name);
        }

        /// <summary>
        /// Get the latest contents of a hash list. A hash list may either by a threat list or a non-threat list such as
        /// the Global Cache. This is a standard Get method as defined by https://google.aip.dev/131 and the HTTP method
        /// is also GET.
        /// </summary>
        public class GetRequest : SafebrowsingBaseServiceRequest<Google.Apis.Safebrowsing.v5.Data.GoogleSecuritySafebrowsingV5HashList>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of this particular hash list. It may be a threat list, or it may be the Global Cache.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// Sets the maximum number of entries that the client is willing to have in the local database for the
            /// list. (The server MAY cause the client to store less than this number of entries.) If omitted or zero,
            /// no database size limit is set.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("sizeConstraints.maxDatabaseEntries", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> SizeConstraintsMaxDatabaseEntries { get; set; }

            /// <summary>
            /// The maximum size in number of entries. The update will not contain more entries than this value, but it
            /// is possible that the update will contain fewer entries than this value. This MUST be at least 1024. If
            /// omitted or zero, no update size limit is set.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("sizeConstraints.maxUpdateEntries", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> SizeConstraintsMaxUpdateEntries { get; set; }

            /// <summary>
            /// The version of the hash list that the client already has. If this is the first time the client is
            /// fetching the hash list, this field MUST be left empty. Otherwise, the client SHOULD supply the version
            /// previously received from the server. The client MUST NOT manipulate those bytes. **What's new in V5**:
            /// in V4 of the API, this was called `states`; it is now renamed to `version` for clarity.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("version", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Version { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v5/hashList/{name}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sizeConstraints.maxDatabaseEntries", new Google.Apis.Discovery.Parameter
                {
                    Name = "sizeConstraints.maxDatabaseEntries",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sizeConstraints.maxUpdateEntries", new Google.Apis.Discovery.Parameter
                {
                    Name = "sizeConstraints.maxUpdateEntries",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("version", new Google.Apis.Discovery.Parameter
                {
                    Name = "version",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "hashLists" collection of methods.</summary>
    public class HashListsResource
    {
        private const string Resource = "hashLists";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public HashListsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Get multiple hash lists at once. It is very common for a client to need to get multiple hash lists. Using
        /// this method is preferred over using the regular Get method multiple times. This is a standard batch Get
        /// method as defined by https://google.aip.dev/231 and the HTTP method is also GET.
        /// </summary>
        public virtual BatchGetRequest BatchGet()
        {
            return new BatchGetRequest(this.service);
        }

        /// <summary>
        /// Get multiple hash lists at once. It is very common for a client to need to get multiple hash lists. Using
        /// this method is preferred over using the regular Get method multiple times. This is a standard batch Get
        /// method as defined by https://google.aip.dev/231 and the HTTP method is also GET.
        /// </summary>
        public class BatchGetRequest : SafebrowsingBaseServiceRequest<Google.Apis.Safebrowsing.v5.Data.GoogleSecuritySafebrowsingV5BatchGetHashListsResponse>
        {
            /// <summary>Constructs a new BatchGet request.</summary>
            public BatchGetRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Required. The names of the particular hash lists. The list MAY be a threat list, or it may be the Global
            /// Cache. The names MUST NOT contain duplicates; if they did, the client will get an error.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("names", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Names { get; set; }

            /// <summary>
            /// Sets the maximum number of entries that the client is willing to have in the local database for the
            /// list. (The server MAY cause the client to store less than this number of entries.) If omitted or zero,
            /// no database size limit is set.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("sizeConstraints.maxDatabaseEntries", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> SizeConstraintsMaxDatabaseEntries { get; set; }

            /// <summary>
            /// The maximum size in number of entries. The update will not contain more entries than this value, but it
            /// is possible that the update will contain fewer entries than this value. This MUST be at least 1024. If
            /// omitted or zero, no update size limit is set.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("sizeConstraints.maxUpdateEntries", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> SizeConstraintsMaxUpdateEntries { get; set; }

            /// <summary>
            /// The versions of the hash list that the client already has. If this is the first time the client is
            /// fetching the hash lists, the field should be left empty. Otherwise, the client should supply the
            /// versions previously received from the server. The client MUST NOT manipulate those bytes. The client
            /// need not send the versions in the same order as the corresponding list names. The client may send fewer
            /// or more versions in a request than there are names. However the client MUST NOT send multiple versions
            /// that correspond to the same name; if it did, the client will get an error. Historical note: in V4 of the
            /// API, this was called `states`; it is now renamed to `version` for clarity.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("version", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Version { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "batchGet";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v5/hashLists:batchGet";

            /// <summary>Initializes BatchGet parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("names", new Google.Apis.Discovery.Parameter
                {
                    Name = "names",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sizeConstraints.maxDatabaseEntries", new Google.Apis.Discovery.Parameter
                {
                    Name = "sizeConstraints.maxDatabaseEntries",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sizeConstraints.maxUpdateEntries", new Google.Apis.Discovery.Parameter
                {
                    Name = "sizeConstraints.maxUpdateEntries",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("version", new Google.Apis.Discovery.Parameter
                {
                    Name = "version",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// List hash lists. In the V5 API, Google will never remove a hash list that has ever been returned by this
        /// method. This enables clients to skip using this method and simply hard-code all hash lists they need. This
        /// is a standard List method as defined by https://google.aip.dev/132 and the HTTP method is GET.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>
        /// List hash lists. In the V5 API, Google will never remove a hash list that has ever been returned by this
        /// method. This enables clients to skip using this method and simply hard-code all hash lists they need. This
        /// is a standard List method as defined by https://google.aip.dev/132 and the HTTP method is GET.
        /// </summary>
        public class ListRequest : SafebrowsingBaseServiceRequest<Google.Apis.Safebrowsing.v5.Data.GoogleSecuritySafebrowsingV5ListHashListsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// The maximum number of hash lists to return. The service may return fewer than this value. If
            /// unspecified, the server will choose a page size, which may be larger than the number of hash lists so
            /// that pagination is not necessary.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// A page token, received from a previous `ListHashLists` call. Provide this to retrieve the subsequent
            /// page.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v5/hashLists";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageSize",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
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
    /// <summary>The response containing multiple hash lists.</summary>
    public class GoogleSecuritySafebrowsingV5BatchGetHashListsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The hash lists in the same order given in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hashLists")]
        public virtual System.Collections.Generic.IList<GoogleSecuritySafebrowsingV5HashList> HashLists { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

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

    /// <summary>A list of hashes identified by its name.</summary>
    public class GoogleSecuritySafebrowsingV5HashList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The 8-byte additions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionsEightBytes")]
        public virtual GoogleSecuritySafebrowsingV5RiceDeltaEncoded64Bit AdditionsEightBytes { get; set; }

        /// <summary>The 4-byte additions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionsFourBytes")]
        public virtual GoogleSecuritySafebrowsingV5RiceDeltaEncoded32Bit AdditionsFourBytes { get; set; }

        /// <summary>The 16-byte additions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionsSixteenBytes")]
        public virtual GoogleSecuritySafebrowsingV5RiceDeltaEncoded128Bit AdditionsSixteenBytes { get; set; }

        /// <summary>The 32-byte additions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionsThirtyTwoBytes")]
        public virtual GoogleSecuritySafebrowsingV5RiceDeltaEncoded256Bit AdditionsThirtyTwoBytes { get; set; }

        /// <summary>
        /// The Rice-delta encoded version of removal indices. Since each hash list definitely has less than 2^32
        /// entries, the indices are treated as 32-bit integers and encoded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compressedRemovals")]
        public virtual GoogleSecuritySafebrowsingV5RiceDeltaEncoded32Bit CompressedRemovals { get; set; }

        /// <summary>
        /// Metadata about the hash list. This is not populated by the `GetHashList` method, but this is populated by
        /// the `ListHashLists` method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual GoogleSecuritySafebrowsingV5HashListMetadata Metadata { get; set; }

        /// <summary>
        /// Clients should wait at least this long to get the hash list again. If omitted or zero, clients SHOULD fetch
        /// immediately because it indicates that the server has an additional update to be sent to the client, but
        /// could not due to the client-specified constraints.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumWaitDuration")]
        public virtual object MinimumWaitDuration { get; set; }

        /// <summary>
        /// The name of the hash list. Note that the Global Cache is also just a hash list and can be referred to here.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// When true, this is a partial diff containing additions and removals based on what the client already has.
        /// When false, this is the complete hash list. When false, the client MUST delete any locally stored version
        /// for this hash list. This means that either the version possessed by the client is seriously out-of-date or
        /// the client data is believed to be corrupt. The `compressed_removals` field will be empty. When true, the
        /// client MUST apply an incremental update by applying removals and then additions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partialUpdate")]
        public virtual System.Nullable<bool> PartialUpdate { get; set; }

        /// <summary>
        /// The sorted list of all hashes, hashed again with SHA256. This is the checksum for the sorted list of all
        /// hashes present in the database after applying the provided update. In the case that no updates were
        /// provided, the server will omit this field to indicate that the client should use the existing checksum.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha256Checksum")]
        public virtual string Sha256Checksum { get; set; }

        /// <summary>The version of the hash list. The client MUST NOT manipulate those bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata about a particular hash list.</summary>
    public class GoogleSecuritySafebrowsingV5HashListMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A human-readable description about this list. Written in English.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// The supported hash length for this hash list. Each hash list will support exactly one length. If a different
        /// hash length is introduced for the same set of threat types or safe types, it will be introduced as a
        /// separate list with a distinct name and respective hash length set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hashLength")]
        public virtual string HashLength { get; set; }

        /// <summary>
        /// Unordered list. If not empty, this specifies that the hash list represents a list of likely safe hashes, and
        /// this enumerates the ways they are considered likely safe. This field is mutually exclusive with the
        /// threat_types field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("likelySafeTypes")]
        public virtual System.Collections.Generic.IList<string> LikelySafeTypes { get; set; }

        /// <summary>
        /// Unordered list. If not empty, this specifies that the hash list is a kind of threat list, and this
        /// enumerates the kind of threats associated with hashes or hash prefixes in this hash list. May be empty if
        /// the entry does not represent a threat, i.e. in the case that it represents a likely safe type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threatTypes")]
        public virtual System.Collections.Generic.IList<string> ThreatTypes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response containing metadata about hash lists.</summary>
    public class GoogleSecuritySafebrowsingV5ListHashListsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The hash lists in an arbitrary order. Only metadata about the hash lists will be included, not the contents.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hashLists")]
        public virtual System.Collections.Generic.IList<GoogleSecuritySafebrowsingV5HashList> HashLists { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Same as `RiceDeltaEncoded32Bit` except this encodes 128-bit numbers.</summary>
    public class GoogleSecuritySafebrowsingV5RiceDeltaEncoded128Bit : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The encoded deltas that are encoded using the Golomb-Rice coder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encodedData")]
        public virtual string EncodedData { get; set; }

        /// <summary>
        /// The number of entries that are delta encoded in the encoded data. If only a single integer was encoded, this
        /// will be zero and the single value will be stored in `first_value`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entriesCount")]
        public virtual System.Nullable<int> EntriesCount { get; set; }

        /// <summary>
        /// The upper 64 bits of the first entry in the encoded data (hashes). If the field is empty, the upper 64 bits
        /// are all zero.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstValueHi")]
        public virtual System.Nullable<ulong> FirstValueHi { get; set; }

        /// <summary>
        /// The lower 64 bits of the first entry in the encoded data (hashes). If the field is empty, the lower 64 bits
        /// are all zero.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstValueLo")]
        public virtual System.Nullable<ulong> FirstValueLo { get; set; }

        /// <summary>
        /// The Golomb-Rice parameter. This parameter is guaranteed to be between 99 and 126, inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("riceParameter")]
        public virtual System.Nullable<int> RiceParameter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Same as `RiceDeltaEncoded32Bit` except this encodes 256-bit numbers.</summary>
    public class GoogleSecuritySafebrowsingV5RiceDeltaEncoded256Bit : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The encoded deltas that are encoded using the Golomb-Rice coder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encodedData")]
        public virtual string EncodedData { get; set; }

        /// <summary>
        /// The number of entries that are delta encoded in the encoded data. If only a single integer was encoded, this
        /// will be zero and the single value will be stored in `first_value`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entriesCount")]
        public virtual System.Nullable<int> EntriesCount { get; set; }

        /// <summary>
        /// The first 64 bits of the first entry in the encoded data (hashes). If the field is empty, the first 64 bits
        /// are all zero.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstValueFirstPart")]
        public virtual System.Nullable<ulong> FirstValueFirstPart { get; set; }

        /// <summary>
        /// The last 64 bits of the first entry in the encoded data (hashes). If the field is empty, the last 64 bits
        /// are all zero.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstValueFourthPart")]
        public virtual System.Nullable<ulong> FirstValueFourthPart { get; set; }

        /// <summary>
        /// The 65 through 128th bits of the first entry in the encoded data (hashes). If the field is empty, the 65
        /// through 128th bits are all zero.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstValueSecondPart")]
        public virtual System.Nullable<ulong> FirstValueSecondPart { get; set; }

        /// <summary>
        /// The 129 through 192th bits of the first entry in the encoded data (hashes). If the field is empty, the 129
        /// through 192th bits are all zero.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstValueThirdPart")]
        public virtual System.Nullable<ulong> FirstValueThirdPart { get; set; }

        /// <summary>
        /// The Golomb-Rice parameter. This parameter is guaranteed to be between 227 and 254, inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("riceParameter")]
        public virtual System.Nullable<int> RiceParameter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The Rice-Golomb encoded data. Used for either hashes or removal indices. It is guaranteed that every hash or
    /// index here has the same length, and this length is exactly 32 bits. Generally speaking, if we sort all the
    /// entries lexicographically, we will find that the higher order bits tend not to change as frequently as lower
    /// order bits. This means that if we also take the adjacent difference between entries, the higher order bits have
    /// a high probability of being zero. This exploits this high probability of zero by essentially choosing a certain
    /// number of bits; all bits more significant than this are likely to be zero so we use unary encoding. See the
    /// `rice_parameter` field. Historical note: the Rice-delta encoding was first used in V4 of this API. In V5, two
    /// significant improvements were made: firstly, the Rice-delta encoding is now available with hash prefixes longer
    /// than 4 bytes; secondly, the encoded data are now treated as big-endian so as to avoid a costly sorting step.
    /// </summary>
    public class GoogleSecuritySafebrowsingV5RiceDeltaEncoded32Bit : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The encoded deltas that are encoded using the Golomb-Rice coder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encodedData")]
        public virtual string EncodedData { get; set; }

        /// <summary>
        /// The number of entries that are delta encoded in the encoded data. If only a single integer was encoded, this
        /// will be zero and the single value will be stored in `first_value`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entriesCount")]
        public virtual System.Nullable<int> EntriesCount { get; set; }

        /// <summary>
        /// The first entry in the encoded data (hashes or indices), or, if only a single hash prefix or index was
        /// encoded, that entry's value. If the field is empty, the entry is zero.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstValue")]
        public virtual System.Nullable<long> FirstValue { get; set; }

        /// <summary>
        /// The Golomb-Rice parameter. This parameter is guaranteed to be between 3 and 30, inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("riceParameter")]
        public virtual System.Nullable<int> RiceParameter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Same as `RiceDeltaEncoded32Bit` except this encodes 64-bit numbers.</summary>
    public class GoogleSecuritySafebrowsingV5RiceDeltaEncoded64Bit : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The encoded deltas that are encoded using the Golomb-Rice coder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encodedData")]
        public virtual string EncodedData { get; set; }

        /// <summary>
        /// The number of entries that are delta encoded in the encoded data. If only a single integer was encoded, this
        /// will be zero and the single value will be stored in `first_value`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entriesCount")]
        public virtual System.Nullable<int> EntriesCount { get; set; }

        /// <summary>
        /// The first entry in the encoded data (hashes), or, if only a single hash prefix was encoded, that entry's
        /// value. If the field is empty, the entry is zero.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstValue")]
        public virtual System.Nullable<ulong> FirstValue { get; set; }

        /// <summary>
        /// The Golomb-Rice parameter. This parameter is guaranteed to be between 35 and 62, inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("riceParameter")]
        public virtual System.Nullable<int> RiceParameter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The response returned after searching threat hashes. If nothing is found, the server will return an OK status
    /// (HTTP status code 200) with the `full_hashes` field empty, rather than returning a NOT_FOUND status (HTTP status
    /// code 404). **What's new in V5**: There is a separation between `FullHash` and `FullHashDetail`. In the case when
    /// a hash represents a site having multiple threats (e.g. both MALWARE and SOCIAL_ENGINEERING), the full hash does
    /// not need to be sent twice as in V4. Furthermore, the cache duration has been simplified into a single
    /// `cache_duration` field.
    /// </summary>
    public class GoogleSecuritySafebrowsingV5SearchHashesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The client-side cache duration. The client MUST add this duration to the current time to determine the
        /// expiration time. The expiration time then applies to every hash prefix queried by the client in the request,
        /// regardless of how many full hashes are returned in the response. Even if the server returns no full hashes
        /// for a particular hash prefix, this fact MUST also be cached by the client. If and only if the field
        /// `full_hashes` is empty, the client MAY increase the `cache_duration` to determine a new expiration that is
        /// later than that specified by the server. In any case, the increased cache duration must not be longer than
        /// 24 hours. Important: the client MUST NOT assume that the server will return the same cache duration for all
        /// responses. The server MAY choose different cache durations for different responses depending on the
        /// situation.
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
