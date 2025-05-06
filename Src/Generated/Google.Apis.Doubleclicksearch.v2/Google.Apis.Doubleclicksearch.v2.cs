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

namespace Google.Apis.Doubleclicksearch.v2
{
    /// <summary>The Doubleclicksearch Service.</summary>
    public class DoubleclicksearchService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DoubleclicksearchService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DoubleclicksearchService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Conversion = new ConversionResource(this);
            Reports = new ReportsResource(this);
            SavedColumns = new SavedColumnsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://doubleclicksearch.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://doubleclicksearch.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "doubleclicksearch";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Search Ads 360 API.</summary>
        public class Scope
        {
            /// <summary>View and manage your advertising data in DoubleClick Search</summary>
            public static string Doubleclicksearch = "https://www.googleapis.com/auth/doubleclicksearch";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Search Ads 360 API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your advertising data in DoubleClick Search</summary>
            public const string Doubleclicksearch = "https://www.googleapis.com/auth/doubleclicksearch";
        }

        /// <summary>Gets the Conversion resource.</summary>
        public virtual ConversionResource Conversion { get; }

        /// <summary>Gets the Reports resource.</summary>
        public virtual ReportsResource Reports { get; }

        /// <summary>Gets the SavedColumns resource.</summary>
        public virtual SavedColumnsResource SavedColumns { get; }
    }

    /// <summary>A base abstract class for Doubleclicksearch requests.</summary>
    public abstract class DoubleclicksearchBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new DoubleclicksearchBaseServiceRequest instance.</summary>
        protected DoubleclicksearchBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Doubleclicksearch parameter list.</summary>
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

    /// <summary>The "conversion" collection of methods.</summary>
    public class ConversionResource
    {
        private const string Resource = "conversion";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ConversionResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Retrieves a list of conversions from a DoubleClick Search engine account.</summary>
        /// <param name="agencyId">Numeric ID of the agency.</param>
        /// <param name="advertiserId">Numeric ID of the advertiser.</param>
        /// <param name="engineAccountId">Numeric ID of the engine account.</param>
        /// <param name="endDate">Last date (inclusive) on which to retrieve conversions. Format is yyyymmdd.</param>
        /// <param name="rowCount">The number of conversions to return per call.</param>
        /// <param name="startDate">First date (inclusive) on which to retrieve conversions. Format is yyyymmdd.</param>
        /// <param name="startRow">The 0-based starting index for retrieving conversions results.</param>
        public virtual GetRequest Get(long agencyId, long advertiserId, long engineAccountId, int endDate, int rowCount, int startDate, long startRow)
        {
            return new GetRequest(this.service, agencyId, advertiserId, engineAccountId, endDate, rowCount, startDate, startRow);
        }

        /// <summary>Retrieves a list of conversions from a DoubleClick Search engine account.</summary>
        public class GetRequest : DoubleclicksearchBaseServiceRequest<Google.Apis.Doubleclicksearch.v2.Data.ConversionList>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, long agencyId, long advertiserId, long engineAccountId, int endDate, int rowCount, int startDate, long startRow) : base(service)
            {
                AgencyId = agencyId;
                AdvertiserId = advertiserId;
                EngineAccountId = engineAccountId;
                EndDate = endDate;
                RowCount = rowCount;
                StartDate = startDate;
                StartRow = startRow;
                InitParameters();
            }

            /// <summary>Numeric ID of the agency.</summary>
            [Google.Apis.Util.RequestParameterAttribute("agencyId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long AgencyId { get; private set; }

            /// <summary>Numeric ID of the advertiser.</summary>
            [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long AdvertiserId { get; private set; }

            /// <summary>Numeric ID of the engine account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("engineAccountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long EngineAccountId { get; private set; }

            /// <summary>Last date (inclusive) on which to retrieve conversions. Format is yyyymmdd.</summary>
            [Google.Apis.Util.RequestParameterAttribute("endDate", Google.Apis.Util.RequestParameterType.Query)]
            public virtual int EndDate { get; private set; }

            /// <summary>The number of conversions to return per call.</summary>
            [Google.Apis.Util.RequestParameterAttribute("rowCount", Google.Apis.Util.RequestParameterType.Query)]
            public virtual int RowCount { get; private set; }

            /// <summary>First date (inclusive) on which to retrieve conversions. Format is yyyymmdd.</summary>
            [Google.Apis.Util.RequestParameterAttribute("startDate", Google.Apis.Util.RequestParameterType.Query)]
            public virtual int StartDate { get; private set; }

            /// <summary>The 0-based starting index for retrieving conversions results.</summary>
            [Google.Apis.Util.RequestParameterAttribute("startRow", Google.Apis.Util.RequestParameterType.Query)]
            public virtual long StartRow { get; private set; }

            /// <summary>Numeric ID of the ad group.</summary>
            [Google.Apis.Util.RequestParameterAttribute("adGroupId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> AdGroupId { get; set; }

            /// <summary>Numeric ID of the ad.</summary>
            [Google.Apis.Util.RequestParameterAttribute("adId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> AdId { get; set; }

            /// <summary>Numeric ID of the campaign.</summary>
            [Google.Apis.Util.RequestParameterAttribute("campaignId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> CampaignId { get; set; }

            /// <summary>Numeric ID of the criterion.</summary>
            [Google.Apis.Util.RequestParameterAttribute("criterionId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> CriterionId { get; set; }

            /// <summary>Customer ID of a client account in the new Search Ads 360 experience.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CustomerId { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "doubleclicksearch/v2/agency/{agencyId}/advertiser/{advertiserId}/engine/{engineAccountId}/conversion";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("agencyId", new Google.Apis.Discovery.Parameter
                {
                    Name = "agencyId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                {
                    Name = "advertiserId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("engineAccountId", new Google.Apis.Discovery.Parameter
                {
                    Name = "engineAccountId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("endDate", new Google.Apis.Discovery.Parameter
                {
                    Name = "endDate",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("rowCount", new Google.Apis.Discovery.Parameter
                {
                    Name = "rowCount",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("startDate", new Google.Apis.Discovery.Parameter
                {
                    Name = "startDate",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("startRow", new Google.Apis.Discovery.Parameter
                {
                    Name = "startRow",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("adGroupId", new Google.Apis.Discovery.Parameter
                {
                    Name = "adGroupId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("adId", new Google.Apis.Discovery.Parameter
                {
                    Name = "adId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("campaignId", new Google.Apis.Discovery.Parameter
                {
                    Name = "campaignId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("criterionId", new Google.Apis.Discovery.Parameter
                {
                    Name = "criterionId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves a list of conversions from a DoubleClick Search engine account.</summary>
        /// <param name="customerId">Customer ID of a client account in the new Search Ads 360 experience.</param>
        /// <param name="endDate">Last date (inclusive) on which to retrieve conversions. Format is yyyymmdd.</param>
        /// <param name="rowCount">The number of conversions to return per call.</param>
        /// <param name="startDate">First date (inclusive) on which to retrieve conversions. Format is yyyymmdd.</param>
        /// <param name="startRow">The 0-based starting index for retrieving conversions results.</param>
        public virtual GetByCustomerIdRequest GetByCustomerId(string customerId, int endDate, int rowCount, int startDate, long startRow)
        {
            return new GetByCustomerIdRequest(this.service, customerId, endDate, rowCount, startDate, startRow);
        }

        /// <summary>Retrieves a list of conversions from a DoubleClick Search engine account.</summary>
        public class GetByCustomerIdRequest : DoubleclicksearchBaseServiceRequest<Google.Apis.Doubleclicksearch.v2.Data.ConversionList>
        {
            /// <summary>Constructs a new GetByCustomerId request.</summary>
            public GetByCustomerIdRequest(Google.Apis.Services.IClientService service, string customerId, int endDate, int rowCount, int startDate, long startRow) : base(service)
            {
                CustomerId = customerId;
                EndDate = endDate;
                RowCount = rowCount;
                StartDate = startDate;
                StartRow = startRow;
                InitParameters();
            }

            /// <summary>Customer ID of a client account in the new Search Ads 360 experience.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>Last date (inclusive) on which to retrieve conversions. Format is yyyymmdd.</summary>
            [Google.Apis.Util.RequestParameterAttribute("endDate", Google.Apis.Util.RequestParameterType.Query)]
            public virtual int EndDate { get; private set; }

            /// <summary>The number of conversions to return per call.</summary>
            [Google.Apis.Util.RequestParameterAttribute("rowCount", Google.Apis.Util.RequestParameterType.Query)]
            public virtual int RowCount { get; private set; }

            /// <summary>First date (inclusive) on which to retrieve conversions. Format is yyyymmdd.</summary>
            [Google.Apis.Util.RequestParameterAttribute("startDate", Google.Apis.Util.RequestParameterType.Query)]
            public virtual int StartDate { get; private set; }

            /// <summary>The 0-based starting index for retrieving conversions results.</summary>
            [Google.Apis.Util.RequestParameterAttribute("startRow", Google.Apis.Util.RequestParameterType.Query)]
            public virtual long StartRow { get; private set; }

            /// <summary>Numeric ID of the ad group.</summary>
            [Google.Apis.Util.RequestParameterAttribute("adGroupId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> AdGroupId { get; set; }

            /// <summary>Numeric ID of the ad.</summary>
            [Google.Apis.Util.RequestParameterAttribute("adId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> AdId { get; set; }

            /// <summary>Numeric ID of the advertiser.</summary>
            [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> AdvertiserId { get; set; }

            /// <summary>Numeric ID of the agency.</summary>
            [Google.Apis.Util.RequestParameterAttribute("agencyId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> AgencyId { get; set; }

            /// <summary>Numeric ID of the campaign.</summary>
            [Google.Apis.Util.RequestParameterAttribute("campaignId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> CampaignId { get; set; }

            /// <summary>Numeric ID of the criterion.</summary>
            [Google.Apis.Util.RequestParameterAttribute("criterionId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> CriterionId { get; set; }

            /// <summary>Numeric ID of the engine account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("engineAccountId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> EngineAccountId { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getByCustomerId";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "doubleclicksearch/v2/customer/{customerId}/conversion";

            /// <summary>Initializes GetByCustomerId parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("endDate", new Google.Apis.Discovery.Parameter
                {
                    Name = "endDate",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("rowCount", new Google.Apis.Discovery.Parameter
                {
                    Name = "rowCount",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("startDate", new Google.Apis.Discovery.Parameter
                {
                    Name = "startDate",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("startRow", new Google.Apis.Discovery.Parameter
                {
                    Name = "startRow",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("adGroupId", new Google.Apis.Discovery.Parameter
                {
                    Name = "adGroupId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("adId", new Google.Apis.Discovery.Parameter
                {
                    Name = "adId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                {
                    Name = "advertiserId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("agencyId", new Google.Apis.Discovery.Parameter
                {
                    Name = "agencyId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("campaignId", new Google.Apis.Discovery.Parameter
                {
                    Name = "campaignId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("criterionId", new Google.Apis.Discovery.Parameter
                {
                    Name = "criterionId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("engineAccountId", new Google.Apis.Discovery.Parameter
                {
                    Name = "engineAccountId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts a batch of new conversions into DoubleClick Search.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual InsertRequest Insert(Google.Apis.Doubleclicksearch.v2.Data.ConversionList body)
        {
            return new InsertRequest(this.service, body);
        }

        /// <summary>Inserts a batch of new conversions into DoubleClick Search.</summary>
        public class InsertRequest : DoubleclicksearchBaseServiceRequest<Google.Apis.Doubleclicksearch.v2.Data.ConversionList>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Doubleclicksearch.v2.Data.ConversionList body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Doubleclicksearch.v2.Data.ConversionList Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "doubleclicksearch/v2/conversion";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Updates a batch of conversions in DoubleClick Search.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual UpdateRequest Update(Google.Apis.Doubleclicksearch.v2.Data.ConversionList body)
        {
            return new UpdateRequest(this.service, body);
        }

        /// <summary>Updates a batch of conversions in DoubleClick Search.</summary>
        public class UpdateRequest : DoubleclicksearchBaseServiceRequest<Google.Apis.Doubleclicksearch.v2.Data.ConversionList>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Doubleclicksearch.v2.Data.ConversionList body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Doubleclicksearch.v2.Data.ConversionList Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "doubleclicksearch/v2/conversion";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Updates the availabilities of a batch of floodlight activities in DoubleClick Search.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual UpdateAvailabilityRequest UpdateAvailability(Google.Apis.Doubleclicksearch.v2.Data.UpdateAvailabilityRequest body)
        {
            return new UpdateAvailabilityRequest(this.service, body);
        }

        /// <summary>Updates the availabilities of a batch of floodlight activities in DoubleClick Search.</summary>
        public class UpdateAvailabilityRequest : DoubleclicksearchBaseServiceRequest<Google.Apis.Doubleclicksearch.v2.Data.UpdateAvailabilityResponse>
        {
            /// <summary>Constructs a new UpdateAvailability request.</summary>
            public UpdateAvailabilityRequest(Google.Apis.Services.IClientService service, Google.Apis.Doubleclicksearch.v2.Data.UpdateAvailabilityRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Doubleclicksearch.v2.Data.UpdateAvailabilityRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateAvailability";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "doubleclicksearch/v2/conversion/updateAvailability";

            /// <summary>Initializes UpdateAvailability parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "reports" collection of methods.</summary>
    public class ReportsResource
    {
        private const string Resource = "reports";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ReportsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Generates and returns a report immediately.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual GenerateRequest Generate(Google.Apis.Doubleclicksearch.v2.Data.ReportRequest body)
        {
            return new GenerateRequest(this.service, body);
        }

        /// <summary>Generates and returns a report immediately.</summary>
        public class GenerateRequest : DoubleclicksearchBaseServiceRequest<Google.Apis.Doubleclicksearch.v2.Data.Report>
        {
            /// <summary>Constructs a new Generate request.</summary>
            public GenerateRequest(Google.Apis.Services.IClientService service, Google.Apis.Doubleclicksearch.v2.Data.ReportRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Doubleclicksearch.v2.Data.ReportRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "generate";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "doubleclicksearch/v2/reports/generate";

            /// <summary>Initializes Generate parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Polls for the status of a report request.</summary>
        /// <param name="reportId">ID of the report request being polled.</param>
        public virtual GetRequest Get(string reportId)
        {
            return new GetRequest(this.service, reportId);
        }

        /// <summary>Polls for the status of a report request.</summary>
        public class GetRequest : DoubleclicksearchBaseServiceRequest<Google.Apis.Doubleclicksearch.v2.Data.Report>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string reportId) : base(service)
            {
                ReportId = reportId;
                InitParameters();
            }

            /// <summary>ID of the report request being polled.</summary>
            [Google.Apis.Util.RequestParameterAttribute("reportId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ReportId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "doubleclicksearch/v2/reports/{reportId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("reportId", new Google.Apis.Discovery.Parameter
                {
                    Name = "reportId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Downloads a report file encoded in UTF-8.</summary>
        /// <param name="reportId">ID of the report.</param>
        /// <param name="reportFragment">The index of the report fragment to download.</param>
        public virtual GetFileRequest GetFile(string reportId, int reportFragment)
        {
            return new GetFileRequest(this.service, reportId, reportFragment);
        }

        /// <summary>Downloads a report file encoded in UTF-8.</summary>
        public class GetFileRequest : DoubleclicksearchBaseServiceRequest<string>
        {
            /// <summary>Constructs a new GetFile request.</summary>
            public GetFileRequest(Google.Apis.Services.IClientService service, string reportId, int reportFragment) : base(service)
            {
                ReportId = reportId;
                ReportFragment = reportFragment;
                MediaDownloader = new Google.Apis.Download.MediaDownloader(service);
                InitParameters();
            }

            /// <summary>ID of the report.</summary>
            [Google.Apis.Util.RequestParameterAttribute("reportId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ReportId { get; private set; }

            /// <summary>The index of the report fragment to download.</summary>
            [Google.Apis.Util.RequestParameterAttribute("reportFragment", Google.Apis.Util.RequestParameterType.Path)]
            public virtual int ReportFragment { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getFile";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "doubleclicksearch/v2/reports/{reportId}/files/{reportFragment}";

            /// <summary>Initializes GetFile parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("reportId", new Google.Apis.Discovery.Parameter
                {
                    Name = "reportId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("reportFragment", new Google.Apis.Discovery.Parameter
                {
                    Name = "reportFragment",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

            /// <summary>Gets the media downloader.</summary>
            public Google.Apis.Download.IMediaDownloader MediaDownloader { get; private set; }

            /// <summary>
            /// <para>Synchronously download the media into the given stream.</para>
            /// <para>
            /// Warning: This method hides download errors; use <see cref="DownloadWithStatus(System.IO.Stream)"/>
            /// instead.
            /// </para>
            /// </summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual void Download(System.IO.Stream stream)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = null;
                mediaDownloader.Download(this.GenerateRequestUri(), stream);
            }

            /// <summary>Synchronously download the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            /// <returns>The final status of the download; including whether the download succeeded or failed.</returns>
            public virtual Google.Apis.Download.IDownloadProgress DownloadWithStatus(System.IO.Stream stream)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = null;
                return mediaDownloader.Download(this.GenerateRequestUri(), stream);
            }

            /// <summary>Asynchronously download the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadAsync(System.IO.Stream stream)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = null;
                return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream);
            }

            /// <summary>Asynchronously download the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadAsync(System.IO.Stream stream,
                System.Threading.CancellationToken cancellationToken)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = null;
                return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream, cancellationToken);
            }

            /// <summary>Synchronously download a range of the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual Google.Apis.Download.IDownloadProgress DownloadRange(System.IO.Stream stream, System.Net.Http.Headers.RangeHeaderValue range)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = range;
                return mediaDownloader.Download(this.GenerateRequestUri(), stream);
            }

            /// <summary>Asynchronously download a range of the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadRangeAsync(System.IO.Stream stream,
                System.Net.Http.Headers.RangeHeaderValue range,
                System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = range;
                return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream, cancellationToken);
            }
        }

        /// <summary>
        /// Downloads a csv file(encoded in UTF-8) that contains ID mappings between legacy SA360 and new SA360. The
        /// file includes all children entities of the given advertiser(e.g. engine accounts, campaigns, ad groups,
        /// etc.) that exist in both legacy SA360 and new SA360.
        /// </summary>
        /// <param name="agencyId">Legacy SA360 agency ID.</param>
        /// <param name="advertiserId">Legacy SA360 advertiser ID.</param>
        public virtual GetIdMappingFileRequest GetIdMappingFile(long agencyId, long advertiserId)
        {
            return new GetIdMappingFileRequest(this.service, agencyId, advertiserId);
        }

        /// <summary>
        /// Downloads a csv file(encoded in UTF-8) that contains ID mappings between legacy SA360 and new SA360. The
        /// file includes all children entities of the given advertiser(e.g. engine accounts, campaigns, ad groups,
        /// etc.) that exist in both legacy SA360 and new SA360.
        /// </summary>
        public class GetIdMappingFileRequest : DoubleclicksearchBaseServiceRequest<Google.Apis.Doubleclicksearch.v2.Data.IdMappingFile>
        {
            /// <summary>Constructs a new GetIdMappingFile request.</summary>
            public GetIdMappingFileRequest(Google.Apis.Services.IClientService service, long agencyId, long advertiserId) : base(service)
            {
                AgencyId = agencyId;
                AdvertiserId = advertiserId;
                MediaDownloader = new Google.Apis.Download.MediaDownloader(service);
                InitParameters();
            }

            /// <summary>Legacy SA360 agency ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("agencyId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long AgencyId { get; private set; }

            /// <summary>Legacy SA360 advertiser ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long AdvertiserId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getIdMappingFile";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "doubleclicksearch/v2/agency/{agencyId}/advertiser/{advertiserId}/idmapping";

            /// <summary>Initializes GetIdMappingFile parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("agencyId", new Google.Apis.Discovery.Parameter
                {
                    Name = "agencyId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                {
                    Name = "advertiserId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

            /// <summary>Gets the media downloader.</summary>
            public Google.Apis.Download.IMediaDownloader MediaDownloader { get; private set; }

            /// <summary>
            /// <para>Synchronously download the media into the given stream.</para>
            /// <para>
            /// Warning: This method hides download errors; use <see cref="DownloadWithStatus(System.IO.Stream)"/>
            /// instead.
            /// </para>
            /// </summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual void Download(System.IO.Stream stream)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = null;
                mediaDownloader.Download(this.GenerateRequestUri(), stream);
            }

            /// <summary>Synchronously download the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            /// <returns>The final status of the download; including whether the download succeeded or failed.</returns>
            public virtual Google.Apis.Download.IDownloadProgress DownloadWithStatus(System.IO.Stream stream)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = null;
                return mediaDownloader.Download(this.GenerateRequestUri(), stream);
            }

            /// <summary>Asynchronously download the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadAsync(System.IO.Stream stream)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = null;
                return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream);
            }

            /// <summary>Asynchronously download the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadAsync(System.IO.Stream stream,
                System.Threading.CancellationToken cancellationToken)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = null;
                return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream, cancellationToken);
            }

            /// <summary>Synchronously download a range of the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual Google.Apis.Download.IDownloadProgress DownloadRange(System.IO.Stream stream, System.Net.Http.Headers.RangeHeaderValue range)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = range;
                return mediaDownloader.Download(this.GenerateRequestUri(), stream);
            }

            /// <summary>Asynchronously download a range of the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadRangeAsync(System.IO.Stream stream,
                System.Net.Http.Headers.RangeHeaderValue range,
                System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = range;
                return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream, cancellationToken);
            }
        }

        /// <summary>Inserts a report request into the reporting system.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual RequestRequest Request(Google.Apis.Doubleclicksearch.v2.Data.ReportRequest body)
        {
            return new RequestRequest(this.service, body);
        }

        /// <summary>Inserts a report request into the reporting system.</summary>
        public class RequestRequest : DoubleclicksearchBaseServiceRequest<Google.Apis.Doubleclicksearch.v2.Data.Report>
        {
            /// <summary>Constructs a new Request request.</summary>
            public RequestRequest(Google.Apis.Services.IClientService service, Google.Apis.Doubleclicksearch.v2.Data.ReportRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Doubleclicksearch.v2.Data.ReportRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "request";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "doubleclicksearch/v2/reports";

            /// <summary>Initializes Request parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "savedColumns" collection of methods.</summary>
    public class SavedColumnsResource
    {
        private const string Resource = "savedColumns";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public SavedColumnsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Retrieve the list of saved columns for a specified advertiser.</summary>
        /// <param name="agencyId">DS ID of the agency.</param>
        /// <param name="advertiserId">DS ID of the advertiser.</param>
        public virtual ListRequest List(long agencyId, long advertiserId)
        {
            return new ListRequest(this.service, agencyId, advertiserId);
        }

        /// <summary>Retrieve the list of saved columns for a specified advertiser.</summary>
        public class ListRequest : DoubleclicksearchBaseServiceRequest<Google.Apis.Doubleclicksearch.v2.Data.SavedColumnList>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, long agencyId, long advertiserId) : base(service)
            {
                AgencyId = agencyId;
                AdvertiserId = advertiserId;
                InitParameters();
            }

            /// <summary>DS ID of the agency.</summary>
            [Google.Apis.Util.RequestParameterAttribute("agencyId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long AgencyId { get; private set; }

            /// <summary>DS ID of the advertiser.</summary>
            [Google.Apis.Util.RequestParameterAttribute("advertiserId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long AdvertiserId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "doubleclicksearch/v2/agency/{agencyId}/advertiser/{advertiserId}/savedcolumns";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("agencyId", new Google.Apis.Discovery.Parameter
                {
                    Name = "agencyId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("advertiserId", new Google.Apis.Discovery.Parameter
                {
                    Name = "advertiserId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.Doubleclicksearch.v2.Data
{
    /// <summary>A message containing availability data relevant to DoubleClick Search.</summary>
    public class Availability : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>DS advertiser ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserId")]
        public virtual System.Nullable<long> AdvertiserId { get; set; }

        /// <summary>DS agency ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agencyId")]
        public virtual System.Nullable<long> AgencyId { get; set; }

        /// <summary>The time by which all conversions have been uploaded, in epoch millis UTC.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availabilityTimestamp")]
        public virtual System.Nullable<long> AvailabilityTimestamp { get; set; }

        /// <summary>Customer ID of a client account in the new Search Ads 360 experience.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerId")]
        public virtual string CustomerId { get; set; }

        /// <summary>
        /// The numeric segmentation identifier (for example, DoubleClick Search Floodlight activity ID).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segmentationId")]
        public virtual System.Nullable<long> SegmentationId { get; set; }

        /// <summary>
        /// The friendly segmentation identifier (for example, DoubleClick Search Floodlight activity name).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segmentationName")]
        public virtual string SegmentationName { get; set; }

        /// <summary>The segmentation type that this availability is for (its default value is `FLOODLIGHT`).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segmentationType")]
        public virtual string SegmentationType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A conversion containing data relevant to DoubleClick Search. Common DS3 API conversion fields: Id Range [1 -
    /// 2800]. Next Id to use: 33
    /// </summary>
    public class Conversion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>DS ad group ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adGroupId")]
        public virtual System.Nullable<long> AdGroupId { get; set; }

        /// <summary>DS ad ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adId")]
        public virtual System.Nullable<long> AdId { get; set; }

        /// <summary>
        /// Represents consent for core platform services (CPS) preferences in settings. No default value. Acceptable
        /// values are: GRANTED: The desired consent status is to grant. Read the CPS preferences from GTE settings.
        /// DENIED: The desired consent status is to deny; CPS list is empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adUserDataConsent")]
        public virtual string AdUserDataConsent { get; set; }

        /// <summary>DS advertiser ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserId")]
        public virtual System.Nullable<long> AdvertiserId { get; set; }

        /// <summary>DS agency ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agencyId")]
        public virtual System.Nullable<long> AgencyId { get; set; }

        /// <summary>Available to advertisers only after contacting DoubleClick Search customer support.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributionModel")]
        public virtual string AttributionModel { get; set; }

        /// <summary>DS campaign ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("campaignId")]
        public virtual System.Nullable<long> CampaignId { get; set; }

        /// <summary>
        /// Sales channel for the product. Acceptable values are: - "`local`": a physical store - "`online`": an online
        /// store
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channel")]
        public virtual string Channel { get; set; }

        /// <summary>DS click ID for the conversion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clickId")]
        public virtual string ClickId { get; set; }

        /// <summary>
        /// For offline conversions, advertisers provide this ID. Advertisers can specify any ID that is meaningful to
        /// them. Each conversion in a request must specify a unique ID, and the combination of ID and timestamp must be
        /// unique amongst all conversions within the advertiser. For online conversions, DS copies the `dsConversionId`
        /// or `floodlightOrderId` into this property depending on the advertiser's Floodlight instructions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionId")]
        public virtual string ConversionId { get; set; }

        /// <summary>The time at which the conversion was last modified, in epoch millis UTC.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionModifiedTimestamp")]
        public virtual System.Nullable<long> ConversionModifiedTimestamp { get; set; }

        /// <summary>The time at which the conversion took place, in epoch millis UTC.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionTimestamp")]
        public virtual string ConversionTimestamp { get; set; }

        /// <summary>Available to advertisers only after contacting DoubleClick Search customer support.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countMillis")]
        public virtual System.Nullable<long> CountMillis { get; set; }

        /// <summary>DS criterion (keyword) ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("criterionId")]
        public virtual System.Nullable<long> CriterionId { get; set; }

        /// <summary>
        /// The currency code for the conversion's revenue. Should be in ISO 4217 alphabetic (3-char) format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>Custom dimensions for the conversion, which can be used to filter data in a report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customDimension")]
        public virtual System.Collections.Generic.IList<CustomDimension> CustomDimension { get; set; }

        /// <summary>Custom metrics for the conversion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customMetric")]
        public virtual System.Collections.Generic.IList<CustomMetric> CustomMetric { get; set; }

        /// <summary>Customer ID of a client account in the new Search Ads 360 experience.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerId")]
        public virtual string CustomerId { get; set; }

        /// <summary>The type of device on which the conversion occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceType")]
        public virtual string DeviceType { get; set; }

        /// <summary>ID that DoubleClick Search generates for each conversion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dsConversionId")]
        public virtual System.Nullable<long> DsConversionId { get; set; }

        /// <summary>DS engine account ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("engineAccountId")]
        public virtual System.Nullable<long> EngineAccountId { get; set; }

        /// <summary>The Floodlight order ID provided by the advertiser for the conversion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floodlightOrderId")]
        public virtual string FloodlightOrderId { get; set; }

        /// <summary>
        /// ID that DS generates and uses to uniquely identify the inventory account that contains the product.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inventoryAccountId")]
        public virtual System.Nullable<long> InventoryAccountId { get; set; }

        /// <summary>
        /// The country registered for the Merchant Center feed that contains the product. Use an ISO 3166 code to
        /// specify a country.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productCountry")]
        public virtual string ProductCountry { get; set; }

        /// <summary>DS product group ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productGroupId")]
        public virtual System.Nullable<long> ProductGroupId { get; set; }

        /// <summary>The product ID (SKU).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; }

        /// <summary>
        /// The language registered for the Merchant Center feed that contains the product. Use an ISO 639 code to
        /// specify a language.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productLanguage")]
        public virtual string ProductLanguage { get; set; }

        /// <summary>The quantity of this conversion, in millis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantityMillis")]
        public virtual System.Nullable<long> QuantityMillis { get; set; }

        /// <summary>
        /// The revenue amount of this `TRANSACTION` conversion, in micros (value multiplied by 1000000, no decimal).
        /// For example, to specify a revenue value of "10" enter "10000000" (10 million) in your request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revenueMicros")]
        public virtual string RevenueMicros { get; set; }

        /// <summary>
        /// The numeric segmentation identifier (for example, DoubleClick Search Floodlight activity ID).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segmentationId")]
        public virtual System.Nullable<long> SegmentationId { get; set; }

        /// <summary>
        /// The friendly segmentation identifier (for example, DoubleClick Search Floodlight activity name).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segmentationName")]
        public virtual string SegmentationName { get; set; }

        /// <summary>The segmentation type of this conversion (for example, `FLOODLIGHT`).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segmentationType")]
        public virtual string SegmentationType { get; set; }

        /// <summary>
        /// The state of the conversion, that is, either `ACTIVE` or `REMOVED`. Note: state DELETED is deprecated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// The ID of the local store for which the product was advertised. Applicable only when the channel is
        /// "`local`".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storeId")]
        public virtual string StoreId { get; set; }

        /// <summary>
        /// The type of the conversion, that is, either `ACTION` or `TRANSACTION`. An `ACTION` conversion is an action
        /// by the user that has no monetarily quantifiable value, while a `TRANSACTION` conversion is an action that
        /// does have a monetarily quantifiable value. Examples are email list signups (`ACTION`) versus ecommerce
        /// purchases (`TRANSACTION`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of conversions.</summary>
    public class ConversionList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The conversions being requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversion")]
        public virtual System.Collections.Generic.IList<Conversion> Conversion { get; set; }

        /// <summary>
        /// Identifies this as a ConversionList resource. Value: the fixed string doubleclicksearch#conversionList.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message containing the custom dimension.</summary>
    public class CustomDimension : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Custom dimension name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Custom dimension value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message containing the custom metric.</summary>
    public class CustomMetric : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Custom metric name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Custom metric numeric value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<double> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// File returned to https://developers.google.com/search-ads/v2/reference/reports/getIdMappingFile.
    /// </summary>
    public class IdMappingFile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A DoubleClick Search report. This object contains the report request, some report metadata such as currency
    /// code, and the generated report rows or report files.
    /// </summary>
    public class Report : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Asynchronous report only. Contains a list of generated report files once the report has successfully
        /// completed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("files")]
        public virtual System.Collections.Generic.IList<FilesData> Files { get; set; }

        /// <summary>Asynchronous report only. Id of the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Asynchronous report only. True if and only if the report has completed successfully and the report files are
        /// ready to be downloaded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isReportReady")]
        public virtual System.Nullable<bool> IsReportReady { get; set; }

        /// <summary>Identifies this as a Report resource. Value: the fixed string `doubleclicksearch#report`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The request that created the report. Optional fields not specified in the original request are filled with
        /// default values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("request")]
        public virtual ReportRequest Request { get; set; }

        /// <summary>The number of report rows generated by the report, not including headers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowCount")]
        public virtual System.Nullable<int> RowCount { get; set; }

        /// <summary>Synchronous report only. Generated report rows.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Rows { get; set; }

        /// <summary>
        /// The currency code of all monetary values produced in the report, including values that are set by users
        /// (e.g., keyword bid settings) and metrics (e.g., cost and revenue). The currency code of a report is
        /// determined by the `statisticsCurrency` field of the report request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statisticsCurrencyCode")]
        public virtual string StatisticsCurrencyCode { get; set; }

        /// <summary>
        /// If all statistics of the report are sourced from the same time zone, this would be it. Otherwise the field
        /// is unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statisticsTimeZone")]
        public virtual string StatisticsTimeZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>
        /// Asynchronous report only. Contains a list of generated report files once the report has successfully
        /// completed.
        /// </summary>
        public class FilesData
        {
            /// <summary>The size of this report file in bytes.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("byteCount")]
            public virtual System.Nullable<long> ByteCount { get; set; }

            /// <summary>Use this url to download the report file.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("url")]
            public virtual string Url { get; set; }
        }
    }

    /// <summary>A request object used to create a DoubleClick Search report.</summary>
    public class ReportApiColumnSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of a DoubleClick Search column to include in the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnName")]
        public virtual string ColumnName { get; set; }

        /// <summary>
        /// Segments a report by a custom dimension. The report must be scoped to an advertiser or lower, and the custom
        /// dimension must already be set up in DoubleClick Search. The custom dimension name, which appears in
        /// DoubleClick Search, is case sensitive.\ If used in a conversion report, returns the value of the specified
        /// custom dimension for the given conversion, if set. This column does not segment the conversion report.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customDimensionName")]
        public virtual string CustomDimensionName { get; set; }

        /// <summary>
        /// Name of a custom metric to include in the report. The report must be scoped to an advertiser or lower, and
        /// the custom metric must already be set up in DoubleClick Search. The custom metric name, which appears in
        /// DoubleClick Search, is case sensitive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customMetricName")]
        public virtual string CustomMetricName { get; set; }

        /// <summary>
        /// Inclusive day in YYYY-MM-DD format. When provided, this overrides the overall time range of the report for
        /// this column only. Must be provided together with `startDate`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual string EndDate { get; set; }

        /// <summary>Synchronous report only. Set to `true` to group by this column. Defaults to `false`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupByColumn")]
        public virtual System.Nullable<bool> GroupByColumn { get; set; }

        /// <summary>
        /// Text used to identify this column in the report output; defaults to `columnName` or `savedColumnName` when
        /// not specified. This can be used to prevent collisions between DoubleClick Search columns and saved columns
        /// with the same name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headerText")]
        public virtual string HeaderText { get; set; }

        /// <summary>
        /// The platform that is used to provide data for the custom dimension. Acceptable values are "floodlight".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platformSource")]
        public virtual string PlatformSource { get; set; }

        /// <summary>
        /// Returns metrics only for a specific type of product activity. Accepted values are: - "`sold`": returns
        /// metrics only for products that were sold - "`advertised`": returns metrics only for products that were
        /// advertised in a Shopping campaign, and that might or might not have been sold
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productReportPerspective")]
        public virtual string ProductReportPerspective { get; set; }

        /// <summary>
        /// Name of a saved column to include in the report. The report must be scoped at advertiser or lower, and this
        /// saved column must already be created in the DoubleClick Search UI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("savedColumnName")]
        public virtual string SavedColumnName { get; set; }

        /// <summary>
        /// Inclusive date in YYYY-MM-DD format. When provided, this overrides the overall time range of the report for
        /// this column only. Must be provided together with `endDate`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual string StartDate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request object used to create a DoubleClick Search report.</summary>
    public class ReportRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The columns to include in the report. This includes both DoubleClick Search columns and saved columns. For
        /// DoubleClick Search columns, only the `columnName` parameter is required. For saved columns only the
        /// `savedColumnName` parameter is required. Both `columnName` and `savedColumnName` cannot be set in the same
        /// stanza.\ The maximum number of columns per request is 300.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columns")]
        public virtual System.Collections.Generic.IList<ReportApiColumnSpec> Columns { get; set; }

        /// <summary>Format that the report should be returned in. Currently `csv` or `tsv` is supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downloadFormat")]
        public virtual string DownloadFormat { get; set; }

        /// <summary>
        /// A list of filters to be applied to the report.\ The maximum number of filters per request is 300.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filters")]
        public virtual System.Collections.Generic.IList<FiltersData> Filters { get; set; }

        /// <summary>
        /// Determines if removed entities should be included in the report. Defaults to `false`. Deprecated, please use
        /// `includeRemovedEntities` instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeDeletedEntities")]
        public virtual System.Nullable<bool> IncludeDeletedEntities { get; set; }

        /// <summary>Determines if removed entities should be included in the report. Defaults to `false`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeRemovedEntities")]
        public virtual System.Nullable<bool> IncludeRemovedEntities { get; set; }

        /// <summary>
        /// Asynchronous report only. The maximum number of rows per report file. A large report is split into many
        /// files based on this field. Acceptable values are `1000000` to `100000000`, inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxRowsPerFile")]
        public virtual System.Nullable<int> MaxRowsPerFile { get; set; }

        /// <summary>
        /// Synchronous report only. A list of columns and directions defining sorting to be performed on the report
        /// rows.\ The maximum number of orderings per request is 300.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderBy")]
        public virtual System.Collections.Generic.IList<OrderByData> OrderBy { get; set; }

        /// <summary>
        /// The reportScope is a set of IDs that are used to determine which subset of entities will be returned in the
        /// report. The full lineage of IDs from the lowest scoped level desired up through agency is required.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportScope")]
        public virtual ReportScopeData ReportScope { get; set; }

        /// <summary>
        /// Determines the type of rows that are returned in the report. For example, if you specify `reportType:
        /// keyword`, each row in the report will contain data about a keyword. See the [Types of
        /// Reports](/search-ads/v2/report-types/) reference for the columns that are available for each type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportType")]
        public virtual string ReportType { get; set; }

        /// <summary>
        /// Synchronous report only. The maximum number of rows to return; additional rows are dropped. Acceptable
        /// values are `0` to `10000`, inclusive. Defaults to `10000`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowCount")]
        public virtual System.Nullable<int> RowCount { get; set; }

        /// <summary>
        /// Synchronous report only. Zero-based index of the first row to return. Acceptable values are `0` to `50000`,
        /// inclusive. Defaults to `0`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startRow")]
        public virtual System.Nullable<int> StartRow { get; set; }

        /// <summary>
        /// Specifies the currency in which monetary will be returned. Possible values are: `usd`, `agency` (valid if
        /// the report is scoped to agency or lower), `advertiser` (valid if the report is scoped to * advertiser or
        /// lower), or `account` (valid if the report is scoped to engine account or lower).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statisticsCurrency")]
        public virtual string StatisticsCurrency { get; set; }

        /// <summary>
        /// If metrics are requested in a report, this argument will be used to restrict the metrics to a specific time
        /// range.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeRange")]
        public virtual TimeRangeData TimeRange { get; set; }

        /// <summary>
        /// If `true`, the report would only be created if all the requested stat data are sourced from a single
        /// timezone. Defaults to `false`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verifySingleTimeZone")]
        public virtual System.Nullable<bool> VerifySingleTimeZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>
        /// A list of filters to be applied to the report.\ The maximum number of filters per request is 300.
        /// </summary>
        public class FiltersData
        {
            /// <summary>
            /// Column to perform the filter on. This can be a DoubleClick Search column or a saved column.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("column")]
            public virtual ReportApiColumnSpec Column { get; set; }

            /// <summary>
            /// Operator to use in the filter. See the filter reference for a list of available operators.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("operator")]
            public virtual string Operator__ { get; set; }

            /// <summary>
            /// A list of values to filter the column value against.\ The maximum number of filter values per request is
            /// 300.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("values")]
            public virtual System.Collections.Generic.IList<object> Values { get; set; }
        }

        /// <summary>
        /// Synchronous report only. A list of columns and directions defining sorting to be performed on the report
        /// rows.\ The maximum number of orderings per request is 300.
        /// </summary>
        public class OrderByData
        {
            /// <summary>
            /// Column to perform the sort on. This can be a DoubleClick Search-defined column or a saved column.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("column")]
            public virtual ReportApiColumnSpec Column { get; set; }

            /// <summary>The sort direction, which is either `ascending` or `descending`.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("sortOrder")]
            public virtual string SortOrder { get; set; }
        }

        /// <summary>
        /// The reportScope is a set of IDs that are used to determine which subset of entities will be returned in the
        /// report. The full lineage of IDs from the lowest scoped level desired up through agency is required.
        /// </summary>
        public class ReportScopeData
        {
            /// <summary>DS ad group ID.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("adGroupId")]
            public virtual System.Nullable<long> AdGroupId { get; set; }

            /// <summary>DS ad ID.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("adId")]
            public virtual System.Nullable<long> AdId { get; set; }

            /// <summary>DS advertiser ID.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("advertiserId")]
            public virtual System.Nullable<long> AdvertiserId { get; set; }

            /// <summary>DS agency ID.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("agencyId")]
            public virtual System.Nullable<long> AgencyId { get; set; }

            /// <summary>DS campaign ID.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("campaignId")]
            public virtual System.Nullable<long> CampaignId { get; set; }

            /// <summary>DS engine account ID.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("engineAccountId")]
            public virtual System.Nullable<long> EngineAccountId { get; set; }

            /// <summary>DS keyword ID.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("keywordId")]
            public virtual System.Nullable<long> KeywordId { get; set; }
        }

        /// <summary>
        /// If metrics are requested in a report, this argument will be used to restrict the metrics to a specific time
        /// range.
        /// </summary>
        public class TimeRangeData
        {
            /// <summary>
            /// Inclusive UTC timestamp in RFC format, e.g., `2013-07-16T10:16:23.555Z`. See additional references on
            /// how changed attribute reports work.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("changedAttributesSinceTimestamp")]
            public virtual string ChangedAttributesSinceTimestamp { get; set; }

            /// <summary>
            /// Inclusive UTC timestamp in RFC format, e.g., `2013-07-16T10:16:23.555Z`. See additional references on
            /// how changed metrics reports work.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("changedMetricsSinceTimestamp")]
            public virtual string ChangedMetricsSinceTimestamp { get; set; }

            /// <summary>Inclusive date in YYYY-MM-DD format.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
            public virtual string EndDate { get; set; }

            /// <summary>Inclusive date in YYYY-MM-DD format.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
            public virtual string StartDate { get; set; }
        }
    }

    /// <summary>A saved column</summary>
    public class SavedColumn : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Identifies this as a SavedColumn resource. Value: the fixed string doubleclicksearch#savedColumn.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The name of the saved column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("savedColumnName")]
        public virtual string SavedColumnName { get; set; }

        /// <summary>The type of data this saved column will produce.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A list of saved columns. Advertisers create saved columns to report on Floodlight activities, Google Analytics
    /// goals, or custom KPIs. To request reports with saved columns, you'll need the saved column names that are
    /// available from this list.
    /// </summary>
    public class SavedColumnList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The saved columns being requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<SavedColumn> Items { get; set; }

        /// <summary>
        /// Identifies this as a SavedColumnList resource. Value: the fixed string doubleclicksearch#savedColumnList.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request to update availability.</summary>
    public class UpdateAvailabilityRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The availabilities being requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availabilities")]
        public virtual System.Collections.Generic.IList<Availability> Availabilities { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response to a update availability request.</summary>
    public class UpdateAvailabilityResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The availabilities being returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availabilities")]
        public virtual System.Collections.Generic.IList<Availability> Availabilities { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
