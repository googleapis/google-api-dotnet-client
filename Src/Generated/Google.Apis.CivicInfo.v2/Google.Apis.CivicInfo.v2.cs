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

namespace Google.Apis.CivicInfo.v2
{
    /// <summary>The CivicInfo Service.</summary>
    public class CivicInfoService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CivicInfoService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CivicInfoService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Divisions = new DivisionsResource(this);
            Elections = new ElectionsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://civicinfo.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://civicinfo.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "civicinfo";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Gets the Divisions resource.</summary>
        public virtual DivisionsResource Divisions { get; }

        /// <summary>Gets the Elections resource.</summary>
        public virtual ElectionsResource Elections { get; }
    }

    /// <summary>A base abstract class for CivicInfo requests.</summary>
    public abstract class CivicInfoBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CivicInfoBaseServiceRequest instance.</summary>
        protected CivicInfoBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CivicInfo parameter list.</summary>
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

    /// <summary>The "divisions" collection of methods.</summary>
    public class DivisionsResource
    {
        private const string Resource = "divisions";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public DivisionsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Lookup OCDIDs and names for divisions related to an address.</summary>
        public virtual QueryDivisionByAddressRequest QueryDivisionByAddress()
        {
            return new QueryDivisionByAddressRequest(this.service);
        }

        /// <summary>Lookup OCDIDs and names for divisions related to an address.</summary>
        public class QueryDivisionByAddressRequest : CivicInfoBaseServiceRequest<Google.Apis.CivicInfo.v2.Data.CivicinfoApiprotosV2DivisionByAddressResponse>
        {
            /// <summary>Constructs a new QueryDivisionByAddress request.</summary>
            public QueryDivisionByAddressRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("address", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Address { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "queryDivisionByAddress";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "civicinfo/v2/divisionsByAddress";

            /// <summary>Initializes QueryDivisionByAddress parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("address", new Google.Apis.Discovery.Parameter
                {
                    Name = "address",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Searches for political divisions by their natural name or OCD ID.</summary>
        public virtual SearchRequest Search()
        {
            return new SearchRequest(this.service);
        }

        /// <summary>Searches for political divisions by their natural name or OCD ID.</summary>
        public class SearchRequest : CivicInfoBaseServiceRequest<Google.Apis.CivicInfo.v2.Data.CivicinfoApiprotosV2DivisionSearchResponse>
        {
            /// <summary>Constructs a new Search request.</summary>
            public SearchRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// The search query. Queries can cover any parts of a OCD ID or a human readable division name. All words
            /// given in the query are treated as required patterns. In addition to that, most query operators of the
            /// Apache Lucene library are supported. See http://lucene.apache.org/core/2_9_4/queryparsersyntax.html
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "search";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "civicinfo/v2/divisions";

            /// <summary>Initializes Search parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("query", new Google.Apis.Discovery.Parameter
                {
                    Name = "query",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "elections" collection of methods.</summary>
    public class ElectionsResource
    {
        private const string Resource = "elections";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ElectionsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>List of available elections to query.</summary>
        public virtual ElectionQueryRequest ElectionQuery()
        {
            return new ElectionQueryRequest(this.service);
        }

        /// <summary>List of available elections to query.</summary>
        public class ElectionQueryRequest : CivicInfoBaseServiceRequest<Google.Apis.CivicInfo.v2.Data.CivicinfoApiprotosV2ElectionsQueryResponse>
        {
            /// <summary>Constructs a new ElectionQuery request.</summary>
            public ElectionQueryRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Whether to include data that has not been allowlisted yet</summary>
            [Google.Apis.Util.RequestParameterAttribute("productionDataOnly", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ProductionDataOnly { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "electionQuery";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "civicinfo/v2/elections";

            /// <summary>Initializes ElectionQuery parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("productionDataOnly", new Google.Apis.Discovery.Parameter
                {
                    Name = "productionDataOnly",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
            }
        }

        /// <summary>Looks up information relevant to a voter based on the voter's registered address.</summary>
        public virtual VoterInfoQueryRequest VoterInfoQuery()
        {
            return new VoterInfoQueryRequest(this.service);
        }

        /// <summary>Looks up information relevant to a voter based on the voter's registered address.</summary>
        public class VoterInfoQueryRequest : CivicInfoBaseServiceRequest<Google.Apis.CivicInfo.v2.Data.CivicinfoApiprotosV2VoterInfoResponse>
        {
            /// <summary>Constructs a new VoterInfoQuery request.</summary>
            public VoterInfoQueryRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>The registered address of the voter to look up.</summary>
            [Google.Apis.Util.RequestParameterAttribute("address", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Address { get; set; }

            /// <summary>
            /// The unique ID of the election to look up. A list of election IDs can be obtained at
            /// https://www.googleapis.com/civicinfo/{version}/elections. If no election ID is specified in the query
            /// and there is more than one election with data for the given voter, the additional elections are provided
            /// in the otherElections response field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("electionId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> ElectionId { get; set; }

            /// <summary>If set to true, only data from official state sources will be returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("officialOnly", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> OfficialOnly { get; set; }

            /// <summary>
            /// Whether to include data that has not been vetted yet. Should only be made available to internal IPs or
            /// trusted partners. This is a non-discoverable parameter in the One Platform API config.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("productionDataOnly", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ProductionDataOnly { get; set; }

            /// <summary>
            /// If set to true, the query will return the success code and include any partial information when it is
            /// unable to determine a matching address or unable to determine the election for electionId=0 queries.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("returnAllAvailableData", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ReturnAllAvailableData { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "voterInfoQuery";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "civicinfo/v2/voterinfo";

            /// <summary>Initializes VoterInfoQuery parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("address", new Google.Apis.Discovery.Parameter
                {
                    Name = "address",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("electionId", new Google.Apis.Discovery.Parameter
                {
                    Name = "electionId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "0",
                    Pattern = null,
                });
                RequestParameters.Add("officialOnly", new Google.Apis.Discovery.Parameter
                {
                    Name = "officialOnly",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("productionDataOnly", new Google.Apis.Discovery.Parameter
                {
                    Name = "productionDataOnly",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
                RequestParameters.Add("returnAllAvailableData", new Google.Apis.Discovery.Parameter
                {
                    Name = "returnAllAvailableData",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.CivicInfo.v2.Data
{
    public class CivicinfoApiprotosV2DivisionByAddressResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("divisions")]
        public virtual System.Collections.Generic.IDictionary<string, CivicinfoSchemaV2GeographicDivision> Divisions { get; set; }

        /// <summary>The normalized version of the requested address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("normalizedInput")]
        public virtual CivicinfoSchemaV2SimpleAddressType NormalizedInput { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of a division search query.</summary>
    public class CivicinfoApiprotosV2DivisionSearchResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "civicinfo#divisionSearchResponse".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<CivicinfoApiprotosV2DivisionSearchResult> Results { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a political geographic division that matches the requested query.</summary>
    public class CivicinfoApiprotosV2DivisionSearchResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Other Open Civic Data identifiers that refer to the same division -- for example, those that refer to other
        /// political divisions whose boundaries are defined to be coterminous with this one. For example,
        /// ocd-division/country:us/state:wy will include an alias of ocd-division/country:us/state:wy/cd:1, since
        /// Wyoming has only one Congressional district.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aliases")]
        public virtual System.Collections.Generic.IList<string> Aliases { get; set; }

        /// <summary>The name of the division.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The unique Open Civic Data identifier for this division</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ocdId")]
        public virtual string OcdId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The list of elections available for this version of the API.</summary>
    public class CivicinfoApiprotosV2ElectionsQueryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of available elections</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("elections")]
        public virtual System.Collections.Generic.IList<CivicinfoSchemaV2Election> Elections { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "civicinfo#electionsQueryResponse".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of a voter info lookup query.</summary>
    public class CivicinfoApiprotosV2VoterInfoResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Contests that will appear on the voter's ballot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contests")]
        public virtual System.Collections.Generic.IList<CivicinfoSchemaV2Contest> Contests { get; set; }

        /// <summary>
        /// Locations where a voter is eligible to drop off a completed ballot. The voter must have received and
        /// completed a ballot prior to arriving at the location. The location may not have ballots available on the
        /// premises. These locations could be open on or before election day as indicated in the pollingHours field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dropOffLocations")]
        public virtual System.Collections.Generic.IList<CivicinfoSchemaV2PollingLocation> DropOffLocations { get; set; }

        /// <summary>Locations where the voter is eligible to vote early, prior to election day.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("earlyVoteSites")]
        public virtual System.Collections.Generic.IList<CivicinfoSchemaV2PollingLocation> EarlyVoteSites { get; set; }

        /// <summary>The election that was queried.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("election")]
        public virtual CivicinfoSchemaV2Election Election { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "civicinfo#voterInfoResponse".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Specifies whether voters in the precinct vote only by mailing their ballots (with the possible option of
        /// dropping off their ballots as well).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mailOnly")]
        public virtual System.Nullable<bool> MailOnly { get; set; }

        /// <summary>The normalized version of the requested address</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("normalizedInput")]
        public virtual CivicinfoSchemaV2SimpleAddressType NormalizedInput { get; set; }

        /// <summary>
        /// When there are multiple elections for a voter address, the otherElections field is populated in the API
        /// response and there are two possibilities: 1. If the earliest election is not the intended election, specify
        /// the election ID of the desired election in a second API request using the electionId field. 2. If these
        /// elections occur on the same day, the API doesn?t return any polling location, contest, or election official
        /// information to ensure that an additional query is made. For user-facing applications, we recommend
        /// displaying these elections to the user to disambiguate. A second API request using the electionId field
        /// should be made for the election that is relevant to the user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("otherElections")]
        public virtual System.Collections.Generic.IList<CivicinfoSchemaV2Election> OtherElections { get; set; }

        /// <summary>Locations where the voter is eligible to vote on election day.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pollingLocations")]
        public virtual System.Collections.Generic.IList<CivicinfoSchemaV2PollingLocation> PollingLocations { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("precinctId")]
        public virtual string PrecinctId { get; set; }

        /// <summary>
        /// The precincts that match this voter's address. Will only be returned for project IDs which have been
        /// allowlisted as "partner projects".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("precincts")]
        public virtual System.Collections.Generic.IList<CivicinfoSchemaV2Precinct> Precincts { get; set; }

        /// <summary>
        /// Local Election Information for the state that the voter votes in. For the US, there will only be one element
        /// in this array.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual System.Collections.Generic.IList<CivicinfoSchemaV2AdministrationRegion> State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes information about a regional election administrative area.</summary>
    public class CivicinfoSchemaV2AdministrationRegion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The election administration body for this area.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("electionAdministrationBody")]
        public virtual CivicinfoSchemaV2AdministrativeBody ElectionAdministrationBody { get; set; }

        /// <summary>
        /// The city or county that provides election information for this voter. This object can have the same elements
        /// as state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("local_jurisdiction")]
        public virtual CivicinfoSchemaV2AdministrationRegion LocalJurisdiction { get; set; }

        /// <summary>The name of the jurisdiction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// A list of sources for this area. If multiple sources are listed the data has been aggregated from those
        /// sources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sources")]
        public virtual System.Collections.Generic.IList<CivicinfoSchemaV2Source> Sources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about an election administrative body (e.g. County Board of Elections).</summary>
    public class CivicinfoSchemaV2AdministrativeBody : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A URL provided by this administrative body for information on absentee voting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("absenteeVotingInfoUrl")]
        public virtual string AbsenteeVotingInfoUrl { get; set; }

        /// <summary>A URL provided by this administrative body to give contest information to the voter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ballotInfoUrl")]
        public virtual string BallotInfoUrl { get; set; }

        /// <summary>The mailing address of this administrative body.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("correspondenceAddress")]
        public virtual CivicinfoSchemaV2SimpleAddressType CorrespondenceAddress { get; set; }

        /// <summary>A URL provided by this administrative body for looking up general election information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("electionInfoUrl")]
        public virtual string ElectionInfoUrl { get; set; }

        /// <summary>A last minute or emergency notification text provided by this administrative body.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("electionNoticeText")]
        public virtual string ElectionNoticeText { get; set; }

        /// <summary>
        /// A URL provided by this administrative body for additional information related to the last minute or
        /// emergency notification.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("electionNoticeUrl")]
        public virtual string ElectionNoticeUrl { get; set; }

        /// <summary>The election officials for this election administrative body.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("electionOfficials")]
        public virtual System.Collections.Generic.IList<CivicinfoSchemaV2ElectionOfficial> ElectionOfficials { get; set; }

        /// <summary>
        /// A URL provided by this administrative body for confirming that the voter is registered to vote.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("electionRegistrationConfirmationUrl")]
        public virtual string ElectionRegistrationConfirmationUrl { get; set; }

        /// <summary>A URL provided by this administrative body for looking up how to register to vote.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("electionRegistrationUrl")]
        public virtual string ElectionRegistrationUrl { get; set; }

        /// <summary>A URL provided by this administrative body describing election rules to the voter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("electionRulesUrl")]
        public virtual string ElectionRulesUrl { get; set; }

        /// <summary>A description of the hours of operation for this administrative body.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hoursOfOperation")]
        public virtual string HoursOfOperation { get; set; }

        /// <summary>The name of this election administrative body.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The physical address of this administrative body.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("physicalAddress")]
        public virtual CivicinfoSchemaV2SimpleAddressType PhysicalAddress { get; set; }

        /// <summary>A description of the services this administrative body may provide.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("voter_services")]
        public virtual System.Collections.Generic.IList<string> VoterServices { get; set; }

        /// <summary>A URL provided by this administrative body for looking up where to vote.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("votingLocationFinderUrl")]
        public virtual string VotingLocationFinderUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a candidate running for elected office.</summary>
    public class CivicinfoSchemaV2Candidate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The URL for the candidate's campaign web site.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("candidateUrl")]
        public virtual string CandidateUrl { get; set; }

        /// <summary>A list of known (social) media channels for this candidate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channels")]
        public virtual System.Collections.Generic.IList<CivicinfoSchemaV2Channel> Channels { get; set; }

        /// <summary>The email address for the candidate's campaign.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>
        /// The candidate's name. If this is a joint ticket it will indicate the name of the candidate at the top of a
        /// ticket followed by a / and that name of candidate at the bottom of the ticket. e.g. "Mitt Romney / Paul
        /// Ryan"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The order the candidate appears on the ballot for this contest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderOnBallot")]
        public virtual System.Nullable<long> OrderOnBallot { get; set; }

        /// <summary>The full name of the party the candidate is a member of.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("party")]
        public virtual string Party { get; set; }

        /// <summary>The voice phone number for the candidate's campaign office.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phone")]
        public virtual string Phone { get; set; }

        /// <summary>A URL for a photo of the candidate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("photoUrl")]
        public virtual string PhotoUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A social media or web channel for a candidate.</summary>
    public class CivicinfoSchemaV2Channel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The unique public identifier for the candidate's channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// The type of channel. The following is a list of types of channels, but is not exhaustive. More channel types
        /// may be added at a later time. One of: GooglePlus, YouTube, Facebook, Twitter
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a contest that appears on a voter's ballot.</summary>
    public class CivicinfoSchemaV2Contest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A number specifying the position of this contest on the voter's ballot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ballotPlacement")]
        public virtual System.Nullable<long> BallotPlacement { get; set; }

        /// <summary>The official title on the ballot for this contest, only where available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ballotTitle")]
        public virtual string BallotTitle { get; set; }

        /// <summary>The candidate choices for this contest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("candidates")]
        public virtual System.Collections.Generic.IList<CivicinfoSchemaV2Candidate> Candidates { get; set; }

        /// <summary>Information about the electoral district that this contest is in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("district")]
        public virtual CivicinfoSchemaV2ElectoralDistrict District { get; set; }

        /// <summary>A description of any additional eligibility requirements for voting in this contest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("electorateSpecifications")]
        public virtual string ElectorateSpecifications { get; set; }

        /// <summary>
        /// The levels of government of the office for this contest. There may be more than one in cases where a
        /// jurisdiction effectively acts at two different levels of government; for example, the mayor of the District
        /// of Columbia acts at "locality" level, but also effectively at both "administrative-area-2" and
        /// "administrative-area-1".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("level")]
        public virtual System.Collections.Generic.IList<string> Level { get; set; }

        /// <summary>The number of candidates that will be elected to office in this contest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numberElected")]
        public virtual System.Nullable<long> NumberElected { get; set; }

        /// <summary>The number of candidates that a voter may vote for in this contest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numberVotingFor")]
        public virtual System.Nullable<long> NumberVotingFor { get; set; }

        /// <summary>The name of the office for this contest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("office")]
        public virtual string Office { get; set; }

        /// <summary>If this is a partisan election, the name of the party/parties it is for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryParties")]
        public virtual System.Collections.Generic.IList<string> PrimaryParties { get; set; }

        /// <summary>
        /// The set of ballot responses for the referendum. A ballot response represents a line on the ballot. Common
        /// examples might include "yes" or "no" for referenda. This field is only populated for contests of type
        /// 'Referendum'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referendumBallotResponses")]
        public virtual System.Collections.Generic.IList<string> ReferendumBallotResponses { get; set; }

        /// <summary>
        /// Specifies a short summary of the referendum that is typically on the ballot below the title but above the
        /// text. This field is only populated for contests of type 'Referendum'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referendumBrief")]
        public virtual string ReferendumBrief { get; set; }

        /// <summary>
        /// A statement in opposition to the referendum. It does not necessarily appear on the ballot. This field is
        /// only populated for contests of type 'Referendum'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referendumConStatement")]
        public virtual string ReferendumConStatement { get; set; }

        /// <summary>
        /// Specifies what effect abstaining (not voting) on the proposition will have (i.e. whether abstaining is
        /// considered a vote against it). This field is only populated for contests of type 'Referendum'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referendumEffectOfAbstain")]
        public virtual string ReferendumEffectOfAbstain { get; set; }

        /// <summary>
        /// The threshold of votes that the referendum needs in order to pass, e.g. "two-thirds". This field is only
        /// populated for contests of type 'Referendum'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referendumPassageThreshold")]
        public virtual string ReferendumPassageThreshold { get; set; }

        /// <summary>
        /// A statement in favor of the referendum. It does not necessarily appear on the ballot. This field is only
        /// populated for contests of type 'Referendum'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referendumProStatement")]
        public virtual string ReferendumProStatement { get; set; }

        /// <summary>
        /// A brief description of the referendum. This field is only populated for contests of type 'Referendum'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referendumSubtitle")]
        public virtual string ReferendumSubtitle { get; set; }

        /// <summary>
        /// The full text of the referendum. This field is only populated for contests of type 'Referendum'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referendumText")]
        public virtual string ReferendumText { get; set; }

        /// <summary>
        /// The title of the referendum (e.g. 'Proposition 42'). This field is only populated for contests of type
        /// 'Referendum'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referendumTitle")]
        public virtual string ReferendumTitle { get; set; }

        /// <summary>A link to the referendum. This field is only populated for contests of type 'Referendum'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referendumUrl")]
        public virtual string ReferendumUrl { get; set; }

        /// <summary>The roles which this office fulfills.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roles")]
        public virtual System.Collections.Generic.IList<string> Roles { get; set; }

        /// <summary>
        /// A list of sources for this contest. If multiple sources are listed, the data has been aggregated from those
        /// sources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sources")]
        public virtual System.Collections.Generic.IList<CivicinfoSchemaV2Source> Sources { get; set; }

        /// <summary>
        /// "Yes" or "No" depending on whether this a contest being held outside the normal election cycle.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("special")]
        public virtual string Special { get; set; }

        /// <summary>
        /// The type of contest. Usually this will be 'General', 'Primary', or 'Run-off' for contests with candidates.
        /// For referenda this will be 'Referendum'. For Retention contests this will typically be 'Retention'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the election that was queried.</summary>
    public class CivicinfoSchemaV2Election : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Day of the election in YYYY-MM-DD format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("electionDay")]
        public virtual string ElectionDay { get; set; }

        /// <summary>The unique ID of this election.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>A displayable name for the election.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The political division of the election. Represented as an OCD Division ID. Voters within these political
        /// jurisdictions are covered by this election. This is typically a state such as
        /// ocd-division/country:us/state:ca or for the midterms or general election the entire US (i.e.
        /// ocd-division/country:us).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ocdDivisionId")]
        public virtual string OcdDivisionId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("shapeLookupBehavior")]
        public virtual string ShapeLookupBehavior { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about individual election officials.</summary>
    public class CivicinfoSchemaV2ElectionOfficial : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The email address of the election official.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailAddress")]
        public virtual string EmailAddress { get; set; }

        /// <summary>The fax number of the election official.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("faxNumber")]
        public virtual string FaxNumber { get; set; }

        /// <summary>The full name of the election official.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The office phone number of the election official.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("officePhoneNumber")]
        public virtual string OfficePhoneNumber { get; set; }

        /// <summary>The title of the election official.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes the geographic scope of a contest.</summary>
    public class CivicinfoSchemaV2ElectoralDistrict : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An identifier for this district, relative to its scope. For example, the 34th State Senate district would
        /// have id "34" and a scope of stateUpper.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The name of the district.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The geographic scope of this district. If unspecified the district's geography is not known. One of:
        /// national, statewide, congressional, stateUpper, stateLower, countywide, judicial, schoolBoard, cityWide,
        /// township, countyCouncil, cityCouncil, ward, special
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a political geography.</summary>
    public class CivicinfoSchemaV2GeographicDivision : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Any other valid OCD IDs that refer to the same division.\n\nBecause OCD IDs are meant to be human-readable
        /// and at least somewhat predictable, there are occasionally several identifiers for a single division. These
        /// identifiers are defined to be equivalent to one another, and one is always indicated as the primary
        /// identifier. The primary identifier will be returned in ocd_id above, and any other equivalent valid
        /// identifiers will be returned in this list.\n\nFor example, if this division's OCD ID is
        /// ocd-division/country:us/district:dc, this will contain ocd-division/country:us/state:dc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alsoKnownAs")]
        public virtual System.Collections.Generic.IList<string> AlsoKnownAs { get; set; }

        /// <summary>The name of the division.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// List of indices in the offices array, one for each office elected from this division. Will only be present
        /// if includeOffices was true (or absent) in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("officeIndices")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> OfficeIndices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A location where a voter can vote. This may be an early vote site, an election day voting location, or a drop
    /// off location for a completed ballot.
    /// </summary>
    public class CivicinfoSchemaV2PollingLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The address of the location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual CivicinfoSchemaV2SimpleAddressType Address { get; set; }

        /// <summary>
        /// The last date that this early vote site or drop off location may be used. This field is not populated for
        /// polling locations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual string EndDate { get; set; }

        /// <summary>
        /// Latitude of the location, in degrees north of the equator. Note this field may not be available for some
        /// locations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latitude")]
        public virtual System.Nullable<double> Latitude { get; set; }

        /// <summary>
        /// Longitude of the location, in degrees east of the Prime Meridian. Note this field may not be available for
        /// some locations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longitude")]
        public virtual System.Nullable<double> Longitude { get; set; }

        /// <summary>
        /// The name of the early vote site or drop off location. This field is not populated for polling locations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Notes about this location (e.g. accessibility ramp or entrance to use).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notes")]
        public virtual string Notes { get; set; }

        /// <summary>A description of when this location is open.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pollingHours")]
        public virtual string PollingHours { get; set; }

        /// <summary>
        /// A list of sources for this location. If multiple sources are listed the data has been aggregated from those
        /// sources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sources")]
        public virtual System.Collections.Generic.IList<CivicinfoSchemaV2Source> Sources { get; set; }

        /// <summary>
        /// The first date that this early vote site or drop off location may be used. This field is not populated for
        /// polling locations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual string StartDate { get; set; }

        /// <summary>
        /// The services provided by this early vote site or drop off location. This field is not populated for polling
        /// locations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("voterServices")]
        public virtual string VoterServices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CivicinfoSchemaV2Precinct : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// ID of the AdministrationRegion message for this precinct. Corresponds to LocalityId xml tag.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("administrationRegionId")]
        public virtual string AdministrationRegionId { get; set; }

        /// <summary>ID(s) of the Contest message(s) for this precinct.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contestId")]
        public virtual System.Collections.Generic.IList<string> ContestId { get; set; }

        /// <summary>Required. Dataset ID. What datasets our Precincts come from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetId")]
        public virtual System.Nullable<long> DatasetId { get; set; }

        /// <summary>ID(s) of the PollingLocation message(s) for this precinct.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("earlyVoteSiteId")]
        public virtual System.Collections.Generic.IList<string> EarlyVoteSiteId { get; set; }

        /// <summary>ID(s) of the ElectoralDistrict message(s) for this precinct.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("electoralDistrictId")]
        public virtual System.Collections.Generic.IList<string> ElectoralDistrictId { get; set; }

        /// <summary>Required. A unique identifier for this precinct.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Specifies if the precinct runs mail-only elections.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mailOnly")]
        public virtual System.Nullable<bool> MailOnly { get; set; }

        /// <summary>Required. The name of the precinct.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The number of the precinct.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("number")]
        public virtual string Number { get; set; }

        /// <summary>Encouraged. The OCD ID of the precinct</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ocdId")]
        public virtual System.Collections.Generic.IList<string> OcdId { get; set; }

        /// <summary>ID(s) of the PollingLocation message(s) for this precinct.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pollingLocationId")]
        public virtual System.Collections.Generic.IList<string> PollingLocationId { get; set; }

        /// <summary>
        /// ID(s) of the SpatialBoundary message(s) for this precinct. Used to specify a geometrical boundary of the
        /// precinct.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spatialBoundaryId")]
        public virtual System.Collections.Generic.IList<string> SpatialBoundaryId { get; set; }

        /// <summary>
        /// If present, this proto corresponds to one portion of split precinct. Other portions of this precinct are
        /// guaranteed to have the same `name`. If not present, this proto represents a full precicnt.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("splitName")]
        public virtual string SplitName { get; set; }

        /// <summary>Specifies the ward the precinct is contained within.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ward")]
        public virtual string Ward { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A simple representation of an address.</summary>
    public class CivicinfoSchemaV2SimpleAddressType : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("addressLine")]
        public virtual System.Collections.Generic.IList<string> AddressLine { get; set; }

        /// <summary>The city or town for the address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("city")]
        public virtual string City { get; set; }

        /// <summary>The street name and number of this address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("line1")]
        public virtual string Line1 { get; set; }

        /// <summary>The second line the address, if needed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("line2")]
        public virtual string Line2 { get; set; }

        /// <summary>The third line of the address, if needed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("line3")]
        public virtual string Line3 { get; set; }

        /// <summary>The name of the location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationName")]
        public virtual string LocationName { get; set; }

        /// <summary>The US two letter state abbreviation of the address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The US Postal Zip Code of the address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zip")]
        public virtual string Zip { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains information about the data source for the element containing it.</summary>
    public class CivicinfoSchemaV2Source : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Whether this data comes from an official government source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("official")]
        public virtual System.Nullable<bool> Official { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
