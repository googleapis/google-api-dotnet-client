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

namespace Google.Apis.AuthorizedBuyersMarketplace.v1
{
    /// <summary>The AuthorizedBuyersMarketplace Service.</summary>
    public class AuthorizedBuyersMarketplaceService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AuthorizedBuyersMarketplaceService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AuthorizedBuyersMarketplaceService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Bidders = new BiddersResource(this);
            Buyers = new BuyersResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "authorizedbuyersmarketplace";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://authorizedbuyersmarketplace.googleapis.com/";
        #else
            "https://authorizedbuyersmarketplace.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://authorizedbuyersmarketplace.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Authorized Buyers Marketplace API.</summary>
        public class Scope
        {
            /// <summary>See, create, edit, and delete your Authorized Buyers Marketplace entities.</summary>
            public static string AuthorizedBuyersMarketplace = "https://www.googleapis.com/auth/authorized-buyers-marketplace";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Authorized Buyers Marketplace API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, create, edit, and delete your Authorized Buyers Marketplace entities.</summary>
            public const string AuthorizedBuyersMarketplace = "https://www.googleapis.com/auth/authorized-buyers-marketplace";
        }

        /// <summary>Gets the Bidders resource.</summary>
        public virtual BiddersResource Bidders { get; }

        /// <summary>Gets the Buyers resource.</summary>
        public virtual BuyersResource Buyers { get; }
    }

    /// <summary>A base abstract class for AuthorizedBuyersMarketplace requests.</summary>
    public abstract class AuthorizedBuyersMarketplaceBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new AuthorizedBuyersMarketplaceBaseServiceRequest instance.</summary>
        protected AuthorizedBuyersMarketplaceBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes AuthorizedBuyersMarketplace parameter list.</summary>
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

    /// <summary>The "bidders" collection of methods.</summary>
    public class BiddersResource
    {
        private const string Resource = "bidders";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public BiddersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            FinalizedDeals = new FinalizedDealsResource(service);
        }

        /// <summary>Gets the FinalizedDeals resource.</summary>
        public virtual FinalizedDealsResource FinalizedDeals { get; }

        /// <summary>The "finalizedDeals" collection of methods.</summary>
        public class FinalizedDealsResource
        {
            private const string Resource = "finalizedDeals";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public FinalizedDealsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Lists finalized deals. Use the URL path "/v1/buyers/{accountId}/finalizedDeals" to list finalized deals
            /// for the current buyer and its clients. Bidders can use the URL path
            /// "/v1/bidders/{accountId}/finalizedDeals" to list finalized deals for the bidder, its buyers and all
            /// their clients.
            /// </summary>
            /// <param name="parent">
            /// Required. The buyer to list the finalized deals for, in the format: `buyers/{accountId}`. When used to
            /// list finalized deals for a bidder, its buyers and clients, in the format `bidders/{accountId}`.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Lists finalized deals. Use the URL path "/v1/buyers/{accountId}/finalizedDeals" to list finalized deals
            /// for the current buyer and its clients. Bidders can use the URL path
            /// "/v1/bidders/{accountId}/finalizedDeals" to list finalized deals for the bidder, its buyers and all
            /// their clients.
            /// </summary>
            public class ListRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1.Data.ListFinalizedDealsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The buyer to list the finalized deals for, in the format: `buyers/{accountId}`. When used
                /// to list finalized deals for a bidder, its buyers and clients, in the format `bidders/{accountId}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional query string using the [Cloud API list filtering
                /// syntax](https://developers.google.com/authorized-buyers/apis/guides/v2/list-filters) Supported
                /// columns for filtering are: * deal.displayName * deal.dealType * deal.createTime * deal.updateTime *
                /// deal.flightStartTime * deal.flightEndTime * dealServingStatus
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// An optional query string to sort finalized deals using the [Cloud API sorting
                /// syntax](https://cloud.google.com/apis/design/design_patterns#sorting_order). If no sort order is
                /// specified, results will be returned in an arbitrary order. Supported columns for sorting are: *
                /// deal.displayName * deal.createTime * deal.updateTime * deal.flightStartTime * deal.flightEndTime *
                /// rtbMetrics.bidRequests7Days * rtbMetrics.bids7Days * rtbMetrics.adImpressions7Days *
                /// rtbMetrics.bidRate7Days * rtbMetrics.filteredBidRate7Days * rtbMetrics.mustBidRateCurrentMonth
                /// Example: 'deal.displayName, deal.updateTime desc'
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>
                /// Requested page size. The server may return fewer results than requested. If requested more than 500,
                /// the server will return 500 results per page. If unspecified, the server will pick a default page
                /// size of 100.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>The page token as returned from ListFinalizedDealsResponse.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/finalizedDeals";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^bidders/[^/]+$",
                    });
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderBy",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
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
    }

    /// <summary>The "buyers" collection of methods.</summary>
    public class BuyersResource
    {
        private const string Resource = "buyers";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public BuyersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            AuctionPackages = new AuctionPackagesResource(service);
            Clients = new ClientsResource(service);
            FinalizedDeals = new FinalizedDealsResource(service);
            Proposals = new ProposalsResource(service);
            PublisherProfiles = new PublisherProfilesResource(service);
        }

        /// <summary>Gets the AuctionPackages resource.</summary>
        public virtual AuctionPackagesResource AuctionPackages { get; }

        /// <summary>The "auctionPackages" collection of methods.</summary>
        public class AuctionPackagesResource
        {
            private const string Resource = "auctionPackages";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AuctionPackagesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Gets an auction package given its name.</summary>
            /// <param name="name">
            /// Required. Name of auction package to get. Format:
            /// `buyers/{accountId}/auctionPackages/{auctionPackageId}`
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets an auction package given its name.</summary>
            public class GetRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1.Data.AuctionPackage>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of auction package to get. Format:
                /// `buyers/{accountId}/auctionPackages/{auctionPackageId}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

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
                        Pattern = @"^buyers/[^/]+/auctionPackages/[^/]+$",
                    });
                }
            }

            /// <summary>List the auction packages subscribed by a buyer and its clients.</summary>
            /// <param name="parent">
            /// Required. Name of the parent buyer that can access the auction package. Format: `buyers/{accountId}`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>List the auction packages subscribed by a buyer and its clients.</summary>
            public class ListRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1.Data.ListAuctionPackagesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the parent buyer that can access the auction package. Format: `buyers/{accountId}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Requested page size. The server may return fewer results than requested. Max allowed page size is
                /// 500.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>The page token as returned. ListAuctionPackagesResponse.nextPageToken</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/auctionPackages";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^buyers/[^/]+$",
                    });
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

            /// <summary>
            /// Subscribe to the auction package for the specified buyer. Once subscribed, the bidder will receive a
            /// call out for inventory matching the auction package targeting criteria with the auction package deal ID
            /// and the specified buyer.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Name of the auction package. Format: `buyers/{accountId}/auctionPackages/{auctionPackageId}`
            /// </param>
            public virtual SubscribeRequest Subscribe(Google.Apis.AuthorizedBuyersMarketplace.v1.Data.SubscribeAuctionPackageRequest body, string name)
            {
                return new SubscribeRequest(service, body, name);
            }

            /// <summary>
            /// Subscribe to the auction package for the specified buyer. Once subscribed, the bidder will receive a
            /// call out for inventory matching the auction package targeting criteria with the auction package deal ID
            /// and the specified buyer.
            /// </summary>
            public class SubscribeRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1.Data.AuctionPackage>
            {
                /// <summary>Constructs a new Subscribe request.</summary>
                public SubscribeRequest(Google.Apis.Services.IClientService service, Google.Apis.AuthorizedBuyersMarketplace.v1.Data.SubscribeAuctionPackageRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the auction package. Format:
                /// `buyers/{accountId}/auctionPackages/{auctionPackageId}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AuthorizedBuyersMarketplace.v1.Data.SubscribeAuctionPackageRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "subscribe";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:subscribe";

                /// <summary>Initializes Subscribe parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^buyers/[^/]+/auctionPackages/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Subscribe the specified clients of the buyer to the auction package. If a client in the list does not
            /// belong to the buyer, an error response will be returned, and all of the following clients in the list
            /// will not be subscribed. Subscribing an already subscribed client will have no effect.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="auctionPackage">
            /// Required. Name of the auction package. Format: `buyers/{accountId}/auctionPackages/{auctionPackageId}`
            /// </param>
            public virtual SubscribeClientsRequest SubscribeClients(Google.Apis.AuthorizedBuyersMarketplace.v1.Data.SubscribeClientsRequest body, string auctionPackage)
            {
                return new SubscribeClientsRequest(service, body, auctionPackage);
            }

            /// <summary>
            /// Subscribe the specified clients of the buyer to the auction package. If a client in the list does not
            /// belong to the buyer, an error response will be returned, and all of the following clients in the list
            /// will not be subscribed. Subscribing an already subscribed client will have no effect.
            /// </summary>
            public class SubscribeClientsRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1.Data.AuctionPackage>
            {
                /// <summary>Constructs a new SubscribeClients request.</summary>
                public SubscribeClientsRequest(Google.Apis.Services.IClientService service, Google.Apis.AuthorizedBuyersMarketplace.v1.Data.SubscribeClientsRequest body, string auctionPackage) : base(service)
                {
                    AuctionPackage = auctionPackage;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the auction package. Format:
                /// `buyers/{accountId}/auctionPackages/{auctionPackageId}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("auctionPackage", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AuctionPackage { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AuthorizedBuyersMarketplace.v1.Data.SubscribeClientsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "subscribeClients";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+auctionPackage}:subscribeClients";

                /// <summary>Initializes SubscribeClients parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("auctionPackage", new Google.Apis.Discovery.Parameter
                    {
                        Name = "auctionPackage",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^buyers/[^/]+/auctionPackages/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Unsubscribe from the auction package for the specified buyer. Once unsubscribed, the bidder will no
            /// longer receive a call out for the auction package deal ID and the specified buyer.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Name of the auction package. Format: `buyers/{accountId}/auctionPackages/{auctionPackageId}`
            /// </param>
            public virtual UnsubscribeRequest Unsubscribe(Google.Apis.AuthorizedBuyersMarketplace.v1.Data.UnsubscribeAuctionPackageRequest body, string name)
            {
                return new UnsubscribeRequest(service, body, name);
            }

            /// <summary>
            /// Unsubscribe from the auction package for the specified buyer. Once unsubscribed, the bidder will no
            /// longer receive a call out for the auction package deal ID and the specified buyer.
            /// </summary>
            public class UnsubscribeRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1.Data.AuctionPackage>
            {
                /// <summary>Constructs a new Unsubscribe request.</summary>
                public UnsubscribeRequest(Google.Apis.Services.IClientService service, Google.Apis.AuthorizedBuyersMarketplace.v1.Data.UnsubscribeAuctionPackageRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the auction package. Format:
                /// `buyers/{accountId}/auctionPackages/{auctionPackageId}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AuthorizedBuyersMarketplace.v1.Data.UnsubscribeAuctionPackageRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "unsubscribe";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:unsubscribe";

                /// <summary>Initializes Unsubscribe parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^buyers/[^/]+/auctionPackages/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Unsubscribe from the auction package for the specified clients of the buyer. Unsubscribing a client that
            /// is not subscribed will have no effect.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="auctionPackage">
            /// Required. Name of the auction package. Format: `buyers/{accountId}/auctionPackages/{auctionPackageId}`
            /// </param>
            public virtual UnsubscribeClientsRequest UnsubscribeClients(Google.Apis.AuthorizedBuyersMarketplace.v1.Data.UnsubscribeClientsRequest body, string auctionPackage)
            {
                return new UnsubscribeClientsRequest(service, body, auctionPackage);
            }

            /// <summary>
            /// Unsubscribe from the auction package for the specified clients of the buyer. Unsubscribing a client that
            /// is not subscribed will have no effect.
            /// </summary>
            public class UnsubscribeClientsRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1.Data.AuctionPackage>
            {
                /// <summary>Constructs a new UnsubscribeClients request.</summary>
                public UnsubscribeClientsRequest(Google.Apis.Services.IClientService service, Google.Apis.AuthorizedBuyersMarketplace.v1.Data.UnsubscribeClientsRequest body, string auctionPackage) : base(service)
                {
                    AuctionPackage = auctionPackage;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the auction package. Format:
                /// `buyers/{accountId}/auctionPackages/{auctionPackageId}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("auctionPackage", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AuctionPackage { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AuthorizedBuyersMarketplace.v1.Data.UnsubscribeClientsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "unsubscribeClients";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+auctionPackage}:unsubscribeClients";

                /// <summary>Initializes UnsubscribeClients parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("auctionPackage", new Google.Apis.Discovery.Parameter
                    {
                        Name = "auctionPackage",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^buyers/[^/]+/auctionPackages/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the Clients resource.</summary>
        public virtual ClientsResource Clients { get; }

        /// <summary>The "clients" collection of methods.</summary>
        public class ClientsResource
        {
            private const string Resource = "clients";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ClientsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Users = new UsersResource(service);
            }

            /// <summary>Gets the Users resource.</summary>
            public virtual UsersResource Users { get; }

            /// <summary>The "users" collection of methods.</summary>
            public class UsersResource
            {
                private const string Resource = "users";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public UsersResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Activates an existing client user. The state of the client user will be updated from "INACTIVE" to
                /// "ACTIVE". This method has no effect if the client user is already in "ACTIVE" state. An error will
                /// be returned if the client user to activate is still in "INVITED" state.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Format: `buyers/{buyerAccountId}/clients/{clientAccountId}/clientUsers/{userId}`
                /// </param>
                public virtual ActivateRequest Activate(Google.Apis.AuthorizedBuyersMarketplace.v1.Data.ActivateClientUserRequest body, string name)
                {
                    return new ActivateRequest(service, body, name);
                }

                /// <summary>
                /// Activates an existing client user. The state of the client user will be updated from "INACTIVE" to
                /// "ACTIVE". This method has no effect if the client user is already in "ACTIVE" state. An error will
                /// be returned if the client user to activate is still in "INVITED" state.
                /// </summary>
                public class ActivateRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1.Data.ClientUser>
                {
                    /// <summary>Constructs a new Activate request.</summary>
                    public ActivateRequest(Google.Apis.Services.IClientService service, Google.Apis.AuthorizedBuyersMarketplace.v1.Data.ActivateClientUserRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `buyers/{buyerAccountId}/clients/{clientAccountId}/clientUsers/{userId}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AuthorizedBuyersMarketplace.v1.Data.ActivateClientUserRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "activate";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:activate";

                    /// <summary>Initializes Activate parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^buyers/[^/]+/clients/[^/]+/users/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Creates a new client user in "INVITED" state. An email invitation will be sent to the new user, once
                /// accepted the user will become active.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The name of the client. Format: `buyers/{accountId}/clients/{clientAccountId}`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.AuthorizedBuyersMarketplace.v1.Data.ClientUser body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Creates a new client user in "INVITED" state. An email invitation will be sent to the new user, once
                /// accepted the user will become active.
                /// </summary>
                public class CreateRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1.Data.ClientUser>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AuthorizedBuyersMarketplace.v1.Data.ClientUser body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the client. Format: `buyers/{accountId}/clients/{clientAccountId}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AuthorizedBuyersMarketplace.v1.Data.ClientUser Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/users";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^buyers/[^/]+/clients/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Deactivates an existing client user. The state of the client user will be updated from "ACTIVE" to
                /// "INACTIVE". This method has no effect if the client user is already in "INACTIVE" state. An error
                /// will be returned if the client user to deactivate is still in "INVITED" state.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Format: `buyers/{buyerAccountId}/clients/{clientAccountId}/clientUsers/{userId}`
                /// </param>
                public virtual DeactivateRequest Deactivate(Google.Apis.AuthorizedBuyersMarketplace.v1.Data.DeactivateClientUserRequest body, string name)
                {
                    return new DeactivateRequest(service, body, name);
                }

                /// <summary>
                /// Deactivates an existing client user. The state of the client user will be updated from "ACTIVE" to
                /// "INACTIVE". This method has no effect if the client user is already in "INACTIVE" state. An error
                /// will be returned if the client user to deactivate is still in "INVITED" state.
                /// </summary>
                public class DeactivateRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1.Data.ClientUser>
                {
                    /// <summary>Constructs a new Deactivate request.</summary>
                    public DeactivateRequest(Google.Apis.Services.IClientService service, Google.Apis.AuthorizedBuyersMarketplace.v1.Data.DeactivateClientUserRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `buyers/{buyerAccountId}/clients/{clientAccountId}/clientUsers/{userId}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AuthorizedBuyersMarketplace.v1.Data.DeactivateClientUserRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "deactivate";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:deactivate";

                    /// <summary>Initializes Deactivate parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^buyers/[^/]+/clients/[^/]+/users/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Deletes an existing client user. The client user will lose access to the Authorized Buyers UI. Note
                /// that if a client user is deleted, the user's access to the UI can't be restored unless a new client
                /// user is created and activated.
                /// </summary>
                /// <param name="name">
                /// Required. Format: `buyers/{buyerAccountId}/clients/{clientAccountId}/clientUsers/{userId}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes an existing client user. The client user will lose access to the Authorized Buyers UI. Note
                /// that if a client user is deleted, the user's access to the UI can't be restored unless a new client
                /// user is created and activated.
                /// </summary>
                public class DeleteRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `buyers/{buyerAccountId}/clients/{clientAccountId}/clientUsers/{userId}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

                    /// <summary>Initializes Delete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^buyers/[^/]+/clients/[^/]+/users/[^/]+$",
                        });
                    }
                }

                /// <summary>Retrieves an existing client user.</summary>
                /// <param name="name">
                /// Required. Format: `buyers/{buyerAccountId}/clients/{clientAccountId}/clientUsers/{userId}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Retrieves an existing client user.</summary>
                public class GetRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1.Data.ClientUser>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `buyers/{buyerAccountId}/clients/{clientAccountId}/clientUsers/{userId}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

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
                            Pattern = @"^buyers/[^/]+/clients/[^/]+/users/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists all client users for a specified client.</summary>
                /// <param name="parent">
                /// Required. The name of the client. Format: `buyers/{buyerAccountId}/clients/{clientAccountId}`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists all client users for a specified client.</summary>
                public class ListRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1.Data.ListClientUsersResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the client. Format: `buyers/{buyerAccountId}/clients/{clientAccountId}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Requested page size. If left blank, a default page size of 500 will be applied.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A token identifying a page of results the server should return. Typically, this is the value of
                    /// ListClientUsersResponse.nextPageToken returned from the previous call to the list method.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/users";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^buyers/[^/]+/clients/[^/]+$",
                        });
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

            /// <summary>
            /// Activates an existing client. The state of the client will be updated to "ACTIVE". This method has no
            /// effect if the client is already in "ACTIVE" state.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. Format: `buyers/{buyerAccountId}/clients/{clientAccountId}`</param>
            public virtual ActivateRequest Activate(Google.Apis.AuthorizedBuyersMarketplace.v1.Data.ActivateClientRequest body, string name)
            {
                return new ActivateRequest(service, body, name);
            }

            /// <summary>
            /// Activates an existing client. The state of the client will be updated to "ACTIVE". This method has no
            /// effect if the client is already in "ACTIVE" state.
            /// </summary>
            public class ActivateRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1.Data.Client>
            {
                /// <summary>Constructs a new Activate request.</summary>
                public ActivateRequest(Google.Apis.Services.IClientService service, Google.Apis.AuthorizedBuyersMarketplace.v1.Data.ActivateClientRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Format: `buyers/{buyerAccountId}/clients/{clientAccountId}`</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AuthorizedBuyersMarketplace.v1.Data.ActivateClientRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "activate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:activate";

                /// <summary>Initializes Activate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^buyers/[^/]+/clients/[^/]+$",
                    });
                }
            }

            /// <summary>Creates a new client.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. The name of the buyer. Format: `buyers/{accountId}`</param>
            public virtual CreateRequest Create(Google.Apis.AuthorizedBuyersMarketplace.v1.Data.Client body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a new client.</summary>
            public class CreateRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1.Data.Client>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AuthorizedBuyersMarketplace.v1.Data.Client body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The name of the buyer. Format: `buyers/{accountId}`</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AuthorizedBuyersMarketplace.v1.Data.Client Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/clients";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^buyers/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Deactivates an existing client. The state of the client will be updated to "INACTIVE". This method has
            /// no effect if the client is already in "INACTIVE" state.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. Format: `buyers/{buyerAccountId}/clients/{clientAccountId}`</param>
            public virtual DeactivateRequest Deactivate(Google.Apis.AuthorizedBuyersMarketplace.v1.Data.DeactivateClientRequest body, string name)
            {
                return new DeactivateRequest(service, body, name);
            }

            /// <summary>
            /// Deactivates an existing client. The state of the client will be updated to "INACTIVE". This method has
            /// no effect if the client is already in "INACTIVE" state.
            /// </summary>
            public class DeactivateRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1.Data.Client>
            {
                /// <summary>Constructs a new Deactivate request.</summary>
                public DeactivateRequest(Google.Apis.Services.IClientService service, Google.Apis.AuthorizedBuyersMarketplace.v1.Data.DeactivateClientRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Format: `buyers/{buyerAccountId}/clients/{clientAccountId}`</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AuthorizedBuyersMarketplace.v1.Data.DeactivateClientRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "deactivate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:deactivate";

                /// <summary>Initializes Deactivate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^buyers/[^/]+/clients/[^/]+$",
                    });
                }
            }

            /// <summary>Gets a client with a given resource name.</summary>
            /// <param name="name">Required. Format: `buyers/{accountId}/clients/{clientAccountId}`</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets a client with a given resource name.</summary>
            public class GetRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1.Data.Client>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. Format: `buyers/{accountId}/clients/{clientAccountId}`</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

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
                        Pattern = @"^buyers/[^/]+/clients/[^/]+$",
                    });
                }
            }

            /// <summary>Lists all the clients for the current buyer.</summary>
            /// <param name="parent">Required. The name of the buyer. Format: `buyers/{accountId}`</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists all the clients for the current buyer.</summary>
            public class ListRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1.Data.ListClientsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. The name of the buyer. Format: `buyers/{accountId}`</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Query string using the [Filtering
                /// Syntax](https://developers.google.com/authorized-buyers/apis/guides/v2/list-filters) Supported
                /// fields for filtering are: * partnerClientId Use this field to filter the clients by the
                /// partnerClientId. For example, if the partnerClientId of the client is "1234", the value of this
                /// field should be `partnerClientId = "1234"`, in order to get only the client whose partnerClientId is
                /// "1234" in the response.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>Requested page size. If left blank, a default page size of 500 will be applied.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A token identifying a page of results the server should return. Typically, this is the value of
                /// ListClientsResponse.nextPageToken returned from the previous call to the list method.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/clients";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^buyers/[^/]+$",
                    });
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
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

            /// <summary>Updates an existing client.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Output only. The resource name of the client. Format: `buyers/{accountId}/clients/{clientAccountId}`
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.AuthorizedBuyersMarketplace.v1.Data.Client body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates an existing client.</summary>
            public class PatchRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1.Data.Client>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AuthorizedBuyersMarketplace.v1.Data.Client body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Output only. The resource name of the client. Format: `buyers/{accountId}/clients/{clientAccountId}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// List of fields to be updated. If empty or unspecified, the service will update all fields populated
                /// in the update request excluding the output only fields and primitive fields with default value. Note
                /// that explicit field mask is required in order to reset a primitive field back to its default value,
                /// for example, false for boolean fields, 0 for integer fields. A special field mask consisting of a
                /// single path "*" can be used to indicate full replacement(the equivalent of PUT method), updatable
                /// fields unset or unspecified in the input will be cleared or set to default value. Output only fields
                /// will be ignored regardless of the value of updateMask.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AuthorizedBuyersMarketplace.v1.Data.Client Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^buyers/[^/]+/clients/[^/]+$",
                    });
                    RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                    {
                        Name = "updateMask",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the FinalizedDeals resource.</summary>
        public virtual FinalizedDealsResource FinalizedDeals { get; }

        /// <summary>The "finalizedDeals" collection of methods.</summary>
        public class FinalizedDealsResource
        {
            private const string Resource = "finalizedDeals";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public FinalizedDealsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Add creative to be used in the bidding process for a finalized deal. For programmatic guaranteed deals,
            /// it's recommended that you associate at least one approved creative with the deal before calling
            /// SetReadyToServe, to help reduce the number of bid responses filtered because they don't contain approved
            /// creatives. Creatives successfully added to a deal can be found in the Realtime-bidding Creatives API
            /// creative.deal_ids. This method only applies to programmatic guaranteed deals. Maximum number of 1000
            /// creatives can be added to a finalized deal.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="deal">
            /// Required. Name of the finalized deal in the format of: `buyers/{accountId}/finalizedDeals/{dealId}`
            /// </param>
            public virtual AddCreativeRequest AddCreative(Google.Apis.AuthorizedBuyersMarketplace.v1.Data.AddCreativeRequest body, string deal)
            {
                return new AddCreativeRequest(service, body, deal);
            }

            /// <summary>
            /// Add creative to be used in the bidding process for a finalized deal. For programmatic guaranteed deals,
            /// it's recommended that you associate at least one approved creative with the deal before calling
            /// SetReadyToServe, to help reduce the number of bid responses filtered because they don't contain approved
            /// creatives. Creatives successfully added to a deal can be found in the Realtime-bidding Creatives API
            /// creative.deal_ids. This method only applies to programmatic guaranteed deals. Maximum number of 1000
            /// creatives can be added to a finalized deal.
            /// </summary>
            public class AddCreativeRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1.Data.FinalizedDeal>
            {
                /// <summary>Constructs a new AddCreative request.</summary>
                public AddCreativeRequest(Google.Apis.Services.IClientService service, Google.Apis.AuthorizedBuyersMarketplace.v1.Data.AddCreativeRequest body, string deal) : base(service)
                {
                    Deal = deal;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the finalized deal in the format of: `buyers/{accountId}/finalizedDeals/{dealId}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("deal", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Deal { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AuthorizedBuyersMarketplace.v1.Data.AddCreativeRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "addCreative";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+deal}:addCreative";

                /// <summary>Initializes AddCreative parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("deal", new Google.Apis.Discovery.Parameter
                    {
                        Name = "deal",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^buyers/[^/]+/finalizedDeals/[^/]+$",
                    });
                }
            }

            /// <summary>Gets a finalized deal given its name.</summary>
            /// <param name="name">Required. Format: `buyers/{accountId}/finalizedDeals/{dealId}`</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets a finalized deal given its name.</summary>
            public class GetRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1.Data.FinalizedDeal>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. Format: `buyers/{accountId}/finalizedDeals/{dealId}`</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

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
                        Pattern = @"^buyers/[^/]+/finalizedDeals/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists finalized deals. Use the URL path "/v1/buyers/{accountId}/finalizedDeals" to list finalized deals
            /// for the current buyer and its clients. Bidders can use the URL path
            /// "/v1/bidders/{accountId}/finalizedDeals" to list finalized deals for the bidder, its buyers and all
            /// their clients.
            /// </summary>
            /// <param name="parent">
            /// Required. The buyer to list the finalized deals for, in the format: `buyers/{accountId}`. When used to
            /// list finalized deals for a bidder, its buyers and clients, in the format `bidders/{accountId}`.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Lists finalized deals. Use the URL path "/v1/buyers/{accountId}/finalizedDeals" to list finalized deals
            /// for the current buyer and its clients. Bidders can use the URL path
            /// "/v1/bidders/{accountId}/finalizedDeals" to list finalized deals for the bidder, its buyers and all
            /// their clients.
            /// </summary>
            public class ListRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1.Data.ListFinalizedDealsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The buyer to list the finalized deals for, in the format: `buyers/{accountId}`. When used
                /// to list finalized deals for a bidder, its buyers and clients, in the format `bidders/{accountId}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional query string using the [Cloud API list filtering
                /// syntax](https://developers.google.com/authorized-buyers/apis/guides/v2/list-filters) Supported
                /// columns for filtering are: * deal.displayName * deal.dealType * deal.createTime * deal.updateTime *
                /// deal.flightStartTime * deal.flightEndTime * dealServingStatus
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// An optional query string to sort finalized deals using the [Cloud API sorting
                /// syntax](https://cloud.google.com/apis/design/design_patterns#sorting_order). If no sort order is
                /// specified, results will be returned in an arbitrary order. Supported columns for sorting are: *
                /// deal.displayName * deal.createTime * deal.updateTime * deal.flightStartTime * deal.flightEndTime *
                /// rtbMetrics.bidRequests7Days * rtbMetrics.bids7Days * rtbMetrics.adImpressions7Days *
                /// rtbMetrics.bidRate7Days * rtbMetrics.filteredBidRate7Days * rtbMetrics.mustBidRateCurrentMonth
                /// Example: 'deal.displayName, deal.updateTime desc'
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>
                /// Requested page size. The server may return fewer results than requested. If requested more than 500,
                /// the server will return 500 results per page. If unspecified, the server will pick a default page
                /// size of 100.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>The page token as returned from ListFinalizedDealsResponse.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/finalizedDeals";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^buyers/[^/]+$",
                    });
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderBy",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
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

            /// <summary>
            /// Pauses serving of the given finalized deal. This call only pauses the serving status, and does not
            /// affect other fields of the finalized deal. Calling this method for an already paused deal has no effect.
            /// This method only applies to programmatic guaranteed deals.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. Format: `buyers/{accountId}/finalizedDeals/{dealId}`</param>
            public virtual PauseRequest Pause(Google.Apis.AuthorizedBuyersMarketplace.v1.Data.PauseFinalizedDealRequest body, string name)
            {
                return new PauseRequest(service, body, name);
            }

            /// <summary>
            /// Pauses serving of the given finalized deal. This call only pauses the serving status, and does not
            /// affect other fields of the finalized deal. Calling this method for an already paused deal has no effect.
            /// This method only applies to programmatic guaranteed deals.
            /// </summary>
            public class PauseRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1.Data.FinalizedDeal>
            {
                /// <summary>Constructs a new Pause request.</summary>
                public PauseRequest(Google.Apis.Services.IClientService service, Google.Apis.AuthorizedBuyersMarketplace.v1.Data.PauseFinalizedDealRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Format: `buyers/{accountId}/finalizedDeals/{dealId}`</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AuthorizedBuyersMarketplace.v1.Data.PauseFinalizedDealRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "pause";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:pause";

                /// <summary>Initializes Pause parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^buyers/[^/]+/finalizedDeals/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Resumes serving of the given finalized deal. Calling this method for an running deal has no effect. If a
            /// deal is initially paused by the seller, calling this method will not resume serving of the deal until
            /// the seller also resumes the deal. This method only applies to programmatic guaranteed deals.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. Format: `buyers/{accountId}/finalizedDeals/{dealId}`</param>
            public virtual ResumeRequest Resume(Google.Apis.AuthorizedBuyersMarketplace.v1.Data.ResumeFinalizedDealRequest body, string name)
            {
                return new ResumeRequest(service, body, name);
            }

            /// <summary>
            /// Resumes serving of the given finalized deal. Calling this method for an running deal has no effect. If a
            /// deal is initially paused by the seller, calling this method will not resume serving of the deal until
            /// the seller also resumes the deal. This method only applies to programmatic guaranteed deals.
            /// </summary>
            public class ResumeRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1.Data.FinalizedDeal>
            {
                /// <summary>Constructs a new Resume request.</summary>
                public ResumeRequest(Google.Apis.Services.IClientService service, Google.Apis.AuthorizedBuyersMarketplace.v1.Data.ResumeFinalizedDealRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Format: `buyers/{accountId}/finalizedDeals/{dealId}`</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AuthorizedBuyersMarketplace.v1.Data.ResumeFinalizedDealRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "resume";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:resume";

                /// <summary>Initializes Resume parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^buyers/[^/]+/finalizedDeals/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Sets the given finalized deal as ready to serve. By default, deals are ready to serve as soon as they're
            /// finalized. A bidder can opt out of this feature by asking to be included in an allowlist. Once opted
            /// out, finalized deals belonging to the bidder and its child seats will not start serving until this
            /// method is called. This method is useful to the bidders who prefer to not receive bid requests before the
            /// creative is ready. This method only applies to programmatic guaranteed deals.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="deal">Required. Format: `buyers/{accountId}/finalizedDeals/{dealId}`</param>
            public virtual SetReadyToServeRequest SetReadyToServe(Google.Apis.AuthorizedBuyersMarketplace.v1.Data.SetReadyToServeRequest body, string deal)
            {
                return new SetReadyToServeRequest(service, body, deal);
            }

            /// <summary>
            /// Sets the given finalized deal as ready to serve. By default, deals are ready to serve as soon as they're
            /// finalized. A bidder can opt out of this feature by asking to be included in an allowlist. Once opted
            /// out, finalized deals belonging to the bidder and its child seats will not start serving until this
            /// method is called. This method is useful to the bidders who prefer to not receive bid requests before the
            /// creative is ready. This method only applies to programmatic guaranteed deals.
            /// </summary>
            public class SetReadyToServeRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1.Data.FinalizedDeal>
            {
                /// <summary>Constructs a new SetReadyToServe request.</summary>
                public SetReadyToServeRequest(Google.Apis.Services.IClientService service, Google.Apis.AuthorizedBuyersMarketplace.v1.Data.SetReadyToServeRequest body, string deal) : base(service)
                {
                    Deal = deal;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Format: `buyers/{accountId}/finalizedDeals/{dealId}`</summary>
                [Google.Apis.Util.RequestParameterAttribute("deal", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Deal { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AuthorizedBuyersMarketplace.v1.Data.SetReadyToServeRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "setReadyToServe";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+deal}:setReadyToServe";

                /// <summary>Initializes SetReadyToServe parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("deal", new Google.Apis.Discovery.Parameter
                    {
                        Name = "deal",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^buyers/[^/]+/finalizedDeals/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the Proposals resource.</summary>
        public virtual ProposalsResource Proposals { get; }

        /// <summary>The "proposals" collection of methods.</summary>
        public class ProposalsResource
        {
            private const string Resource = "proposals";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ProposalsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Deals = new DealsResource(service);
            }

            /// <summary>Gets the Deals resource.</summary>
            public virtual DealsResource Deals { get; }

            /// <summary>The "deals" collection of methods.</summary>
            public class DealsResource
            {
                private const string Resource = "deals";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DealsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Batch updates multiple deals in the same proposal.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The name of the proposal containing the deals to batch update. Format:
                /// buyers/{accountId}/proposals/{proposalId}
                /// </param>
                public virtual BatchUpdateRequest BatchUpdate(Google.Apis.AuthorizedBuyersMarketplace.v1.Data.BatchUpdateDealsRequest body, string parent)
                {
                    return new BatchUpdateRequest(service, body, parent);
                }

                /// <summary>Batch updates multiple deals in the same proposal.</summary>
                public class BatchUpdateRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1.Data.BatchUpdateDealsResponse>
                {
                    /// <summary>Constructs a new BatchUpdate request.</summary>
                    public BatchUpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AuthorizedBuyersMarketplace.v1.Data.BatchUpdateDealsRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the proposal containing the deals to batch update. Format:
                    /// buyers/{accountId}/proposals/{proposalId}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AuthorizedBuyersMarketplace.v1.Data.BatchUpdateDealsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "batchUpdate";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/deals:batchUpdate";

                    /// <summary>Initializes BatchUpdate parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^buyers/[^/]+/proposals/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets a deal given its name. The deal is returned at its head revision.</summary>
                /// <param name="name">
                /// Required. Format: buyers/{accountId}/proposals/{proposalId}/deals/{dealId}
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets a deal given its name. The deal is returned at its head revision.</summary>
                public class GetRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1.Data.Deal>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Format: buyers/{accountId}/proposals/{proposalId}/deals/{dealId}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

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
                            Pattern = @"^buyers/[^/]+/proposals/[^/]+/deals/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists all deals in a proposal. To retrieve only the finalized revision deals regardless if a deal is
                /// being renegotiated, see the FinalizedDeals resource.
                /// </summary>
                /// <param name="parent">
                /// Required. The name of the proposal containing the deals to retrieve. Format:
                /// buyers/{accountId}/proposals/{proposalId}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Lists all deals in a proposal. To retrieve only the finalized revision deals regardless if a deal is
                /// being renegotiated, see the FinalizedDeals resource.
                /// </summary>
                public class ListRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1.Data.ListDealsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the proposal containing the deals to retrieve. Format:
                    /// buyers/{accountId}/proposals/{proposalId}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Requested page size. The server may return fewer results than requested. If requested more than
                    /// 500, the server will return 500 results per page. If unspecified, the server will pick a default
                    /// page size of 100.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The page token as returned from ListDealsResponse.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/deals";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^buyers/[^/]+/proposals/[^/]+$",
                        });
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

                /// <summary>
                /// Updates the given deal at the buyer known revision number. If the server revision has advanced since
                /// the passed-in proposal.proposal_revision an ABORTED error message will be returned. The revision
                /// number is incremented by the server whenever the proposal or its constituent deals are updated.
                /// Note: The revision number is kept at a proposal level. The buyer of the API is expected to keep
                /// track of the revision number after the last update operation and send it in as part of the next
                /// update request. This way, if there are further changes on the server (for example, seller making new
                /// updates), then the server can detect conflicts and reject the proposed changes.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Immutable. The unique identifier of the deal. Auto-generated by the server when a deal is created.
                /// Format: buyers/{accountId}/proposals/{proposalId}/deals/{dealId}
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.AuthorizedBuyersMarketplace.v1.Data.Deal body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Updates the given deal at the buyer known revision number. If the server revision has advanced since
                /// the passed-in proposal.proposal_revision an ABORTED error message will be returned. The revision
                /// number is incremented by the server whenever the proposal or its constituent deals are updated.
                /// Note: The revision number is kept at a proposal level. The buyer of the API is expected to keep
                /// track of the revision number after the last update operation and send it in as part of the next
                /// update request. This way, if there are further changes on the server (for example, seller making new
                /// updates), then the server can detect conflicts and reject the proposed changes.
                /// </summary>
                public class PatchRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1.Data.Deal>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AuthorizedBuyersMarketplace.v1.Data.Deal body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Immutable. The unique identifier of the deal. Auto-generated by the server when a deal is
                    /// created. Format: buyers/{accountId}/proposals/{proposalId}/deals/{dealId}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// List of fields to be updated. If empty or unspecified, the service will update all fields
                    /// populated in the update request excluding the output only fields and primitive fields with
                    /// default value. Note that explicit field mask is required in order to reset a primitive field
                    /// back to its default value, for example, false for boolean fields, 0 for integer fields. A
                    /// special field mask consisting of a single path "*" can be used to indicate full replacement(the
                    /// equivalent of PUT method), updatable fields unset or unspecified in the input will be cleared or
                    /// set to default value. Output only fields will be ignored regardless of the value of updateMask.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AuthorizedBuyersMarketplace.v1.Data.Deal Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

                    /// <summary>Initializes Patch parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^buyers/[^/]+/proposals/[^/]+/deals/[^/]+$",
                        });
                        RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                        {
                            Name = "updateMask",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>
            /// Accepts the proposal at the given revision number. If the revision number in the request is behind the
            /// latest from the server, an error message will be returned. This call updates the Proposal.state from
            /// `BUYER_ACCEPTANCE_REQUESTED` to `FINALIZED`; it has no side effect if the Proposal.state is already
            /// `FINALIZED` and throws exception if the Proposal.state is not either `BUYER_ACCEPTANCE_REQUESTED` or
            /// `FINALIZED`. Accepting a proposal means the buyer understands and accepts the
            /// Proposal.terms_and_conditions proposed by the seller.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Name of the proposal. Format: `buyers/{accountId}/proposals/{proposalId}`</param>
            public virtual AcceptRequest Accept(Google.Apis.AuthorizedBuyersMarketplace.v1.Data.AcceptProposalRequest body, string name)
            {
                return new AcceptRequest(service, body, name);
            }

            /// <summary>
            /// Accepts the proposal at the given revision number. If the revision number in the request is behind the
            /// latest from the server, an error message will be returned. This call updates the Proposal.state from
            /// `BUYER_ACCEPTANCE_REQUESTED` to `FINALIZED`; it has no side effect if the Proposal.state is already
            /// `FINALIZED` and throws exception if the Proposal.state is not either `BUYER_ACCEPTANCE_REQUESTED` or
            /// `FINALIZED`. Accepting a proposal means the buyer understands and accepts the
            /// Proposal.terms_and_conditions proposed by the seller.
            /// </summary>
            public class AcceptRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1.Data.Proposal>
            {
                /// <summary>Constructs a new Accept request.</summary>
                public AcceptRequest(Google.Apis.Services.IClientService service, Google.Apis.AuthorizedBuyersMarketplace.v1.Data.AcceptProposalRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Name of the proposal. Format: `buyers/{accountId}/proposals/{proposalId}`</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AuthorizedBuyersMarketplace.v1.Data.AcceptProposalRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "accept";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:accept";

                /// <summary>Initializes Accept parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^buyers/[^/]+/proposals/[^/]+$",
                    });
                }
            }

            /// <summary>Creates a note for this proposal and sends to the seller.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="proposal">Name of the proposal. Format: `buyers/{accountId}/proposals/{proposalId}`</param>
            public virtual AddNoteRequest AddNote(Google.Apis.AuthorizedBuyersMarketplace.v1.Data.AddNoteRequest body, string proposal)
            {
                return new AddNoteRequest(service, body, proposal);
            }

            /// <summary>Creates a note for this proposal and sends to the seller.</summary>
            public class AddNoteRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1.Data.Proposal>
            {
                /// <summary>Constructs a new AddNote request.</summary>
                public AddNoteRequest(Google.Apis.Services.IClientService service, Google.Apis.AuthorizedBuyersMarketplace.v1.Data.AddNoteRequest body, string proposal) : base(service)
                {
                    Proposal = proposal;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Name of the proposal. Format: `buyers/{accountId}/proposals/{proposalId}`</summary>
                [Google.Apis.Util.RequestParameterAttribute("proposal", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Proposal { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AuthorizedBuyersMarketplace.v1.Data.AddNoteRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "addNote";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+proposal}:addNote";

                /// <summary>Initializes AddNote parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("proposal", new Google.Apis.Discovery.Parameter
                    {
                        Name = "proposal",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^buyers/[^/]+/proposals/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Cancels an ongoing negotiation on a proposal. This does not cancel or end serving for the deals if the
            /// proposal has been finalized. If the proposal has not been finalized before, calling this method will set
            /// the Proposal.state to `TERMINATED` and increment the Proposal.proposal_revision. If the proposal has
            /// been finalized before and is under renegotiation now, calling this method will reset the Proposal.state
            /// to `FINALIZED` and increment the Proposal.proposal_revision. This method does not support private
            /// auction proposals whose Proposal.deal_type is 'PRIVATE_AUCTION'.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="proposal">Name of the proposal. Format: `buyers/{accountId}/proposals/{proposalId}`</param>
            public virtual CancelNegotiationRequest CancelNegotiation(Google.Apis.AuthorizedBuyersMarketplace.v1.Data.CancelNegotiationRequest body, string proposal)
            {
                return new CancelNegotiationRequest(service, body, proposal);
            }

            /// <summary>
            /// Cancels an ongoing negotiation on a proposal. This does not cancel or end serving for the deals if the
            /// proposal has been finalized. If the proposal has not been finalized before, calling this method will set
            /// the Proposal.state to `TERMINATED` and increment the Proposal.proposal_revision. If the proposal has
            /// been finalized before and is under renegotiation now, calling this method will reset the Proposal.state
            /// to `FINALIZED` and increment the Proposal.proposal_revision. This method does not support private
            /// auction proposals whose Proposal.deal_type is 'PRIVATE_AUCTION'.
            /// </summary>
            public class CancelNegotiationRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1.Data.Proposal>
            {
                /// <summary>Constructs a new CancelNegotiation request.</summary>
                public CancelNegotiationRequest(Google.Apis.Services.IClientService service, Google.Apis.AuthorizedBuyersMarketplace.v1.Data.CancelNegotiationRequest body, string proposal) : base(service)
                {
                    Proposal = proposal;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Name of the proposal. Format: `buyers/{accountId}/proposals/{proposalId}`</summary>
                [Google.Apis.Util.RequestParameterAttribute("proposal", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Proposal { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AuthorizedBuyersMarketplace.v1.Data.CancelNegotiationRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "cancelNegotiation";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+proposal}:cancelNegotiation";

                /// <summary>Initializes CancelNegotiation parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("proposal", new Google.Apis.Discovery.Parameter
                    {
                        Name = "proposal",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^buyers/[^/]+/proposals/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Gets a proposal using its name. The proposal is returned at most recent revision. revision.
            /// </summary>
            /// <param name="name">
            /// Required. Name of the proposal. Format: `buyers/{accountId}/proposals/{proposalId}`
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>
            /// Gets a proposal using its name. The proposal is returned at most recent revision. revision.
            /// </summary>
            public class GetRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1.Data.Proposal>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the proposal. Format: `buyers/{accountId}/proposals/{proposalId}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

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
                        Pattern = @"^buyers/[^/]+/proposals/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists proposals. A filter expression (list filter syntax) may be specified to filter the results. This
            /// will not list finalized versions of proposals that are being renegotiated; to retrieve these use the
            /// finalizedProposals resource.
            /// </summary>
            /// <param name="parent">
            /// Required. Parent that owns the collection of proposals Format: `buyers/{accountId}`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Lists proposals. A filter expression (list filter syntax) may be specified to filter the results. This
            /// will not list finalized versions of proposals that are being renegotiated; to retrieve these use the
            /// finalizedProposals resource.
            /// </summary>
            public class ListRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1.Data.ListProposalsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Parent that owns the collection of proposals Format: `buyers/{accountId}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional query string using the [Cloud API list filtering
                /// syntax](https://developers.google.com/authorized-buyers/apis/guides/v2/list-filters) Supported
                /// columns for filtering are: * displayName * dealType * updateTime * state
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Requested page size. The server may return fewer results than requested. If unspecified, the server
                /// will put a size of 500.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>The page token as returned from ListProposalsResponse.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/proposals";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^buyers/[^/]+$",
                    });
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
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

            /// <summary>
            /// Updates the proposal at the given revision number. If the revision number in the request is behind the
            /// latest from the server, an error message will be returned. See FieldMask for how to use FieldMask. Only
            /// fields specified in the UpdateProposalRequest.update_mask will be updated; Fields noted as 'Immutable'
            /// or 'Output only' yet specified in the UpdateProposalRequest.update_mask will be ignored and left
            /// unchanged. Updating a private auction proposal is not allowed and will result in an error.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Immutable. The name of the proposal serving as a unique identifier. Format:
            /// buyers/{accountId}/proposals/{proposalId}
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.AuthorizedBuyersMarketplace.v1.Data.Proposal body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>
            /// Updates the proposal at the given revision number. If the revision number in the request is behind the
            /// latest from the server, an error message will be returned. See FieldMask for how to use FieldMask. Only
            /// fields specified in the UpdateProposalRequest.update_mask will be updated; Fields noted as 'Immutable'
            /// or 'Output only' yet specified in the UpdateProposalRequest.update_mask will be ignored and left
            /// unchanged. Updating a private auction proposal is not allowed and will result in an error.
            /// </summary>
            public class PatchRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1.Data.Proposal>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AuthorizedBuyersMarketplace.v1.Data.Proposal body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Immutable. The name of the proposal serving as a unique identifier. Format:
                /// buyers/{accountId}/proposals/{proposalId}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// List of fields to be updated. If empty or unspecified, the service will update all fields populated
                /// in the update request excluding the output only fields and primitive fields with default value. Note
                /// that explicit field mask is required in order to reset a primitive field back to its default value,
                /// for example, false for boolean fields, 0 for integer fields. A special field mask consisting of a
                /// single path "*" can be used to indicate full replacement(the equivalent of PUT method), updatable
                /// fields unset or unspecified in the input will be cleared or set to default value. Output only fields
                /// will be ignored regardless of the value of updateMask.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AuthorizedBuyersMarketplace.v1.Data.Proposal Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^buyers/[^/]+/proposals/[^/]+$",
                    });
                    RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                    {
                        Name = "updateMask",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Sends a request for proposal (RFP) to a publisher to initiate the negotiation regarding certain
            /// inventory. In the RFP, buyers can specify the deal type, deal terms, start and end dates, targeting, and
            /// a message to the publisher. Once the RFP is sent, a proposal in `SELLER_REVIEW_REQUESTED` state will be
            /// created and returned in the response. The publisher may review your request and respond with detailed
            /// deals in the proposal.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="buyer">
            /// Required. The current buyer who is sending the RFP in the format: `buyers/{accountId}`.
            /// </param>
            public virtual SendRfpRequest SendRfp(Google.Apis.AuthorizedBuyersMarketplace.v1.Data.SendRfpRequest body, string buyer)
            {
                return new SendRfpRequest(service, body, buyer);
            }

            /// <summary>
            /// Sends a request for proposal (RFP) to a publisher to initiate the negotiation regarding certain
            /// inventory. In the RFP, buyers can specify the deal type, deal terms, start and end dates, targeting, and
            /// a message to the publisher. Once the RFP is sent, a proposal in `SELLER_REVIEW_REQUESTED` state will be
            /// created and returned in the response. The publisher may review your request and respond with detailed
            /// deals in the proposal.
            /// </summary>
            public class SendRfpRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1.Data.Proposal>
            {
                /// <summary>Constructs a new SendRfp request.</summary>
                public SendRfpRequest(Google.Apis.Services.IClientService service, Google.Apis.AuthorizedBuyersMarketplace.v1.Data.SendRfpRequest body, string buyer) : base(service)
                {
                    Buyer = buyer;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The current buyer who is sending the RFP in the format: `buyers/{accountId}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("buyer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Buyer { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AuthorizedBuyersMarketplace.v1.Data.SendRfpRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "sendRfp";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+buyer}/proposals:sendRfp";

                /// <summary>Initializes SendRfp parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("buyer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "buyer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^buyers/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the PublisherProfiles resource.</summary>
        public virtual PublisherProfilesResource PublisherProfiles { get; }

        /// <summary>The "publisherProfiles" collection of methods.</summary>
        public class PublisherProfilesResource
        {
            private const string Resource = "publisherProfiles";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public PublisherProfilesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Gets the requested publisher profile by name.</summary>
            /// <param name="name">
            /// Required. Name of the publisher profile. Format:
            /// `buyers/{buyerId}/publisherProfiles/{publisherProfileId}`
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets the requested publisher profile by name.</summary>
            public class GetRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1.Data.PublisherProfile>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the publisher profile. Format:
                /// `buyers/{buyerId}/publisherProfiles/{publisherProfileId}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

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
                        Pattern = @"^buyers/[^/]+/publisherProfiles/[^/]+$",
                    });
                }
            }

            /// <summary>Lists publisher profiles</summary>
            /// <param name="parent">
            /// Required. Parent that owns the collection of publisher profiles Format: `buyers/{buyerId}`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists publisher profiles</summary>
            public class ListRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1.Data.ListPublisherProfilesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Parent that owns the collection of publisher profiles Format: `buyers/{buyerId}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional query string using the [Cloud API list filtering]
                /// (https://developers.google.com/authorized-buyers/apis/guides/v2/list-filters) syntax.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Requested page size. The server may return fewer results than requested. If requested more than 500,
                /// the server will return 500 results per page. If unspecified, the server will pick a default page
                /// size of 100.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>The page token as returned from a previous ListPublisherProfilesResponse.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/publisherProfiles";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^buyers/[^/]+$",
                    });
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
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
    }
}
namespace Google.Apis.AuthorizedBuyersMarketplace.v1.Data
{
    /// <summary>
    /// Request to accept a proposal. Accepting a proposal implies acceptance of the publisher terms_and_conditions, if
    /// any.
    /// </summary>
    public class AcceptProposalRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The last known client revision number of the proposal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proposalRevision")]
        public virtual System.Nullable<long> ProposalRevision { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for activating a client.</summary>
    public class ActivateClientRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for activating a client user.</summary>
    public class ActivateClientUserRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents size of a single ad slot, or a creative.</summary>
    public class AdSize : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The height of the ad slot in pixels. This field will be present only when size type is `PIXEL`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual System.Nullable<long> Height { get; set; }

        /// <summary>The type of the ad slot size.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// The width of the ad slot in pixels. This field will be present only when size type is `PIXEL`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<long> Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for adding creative to be used in the bidding process for the finalized deal.</summary>
    public class AddCreativeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Name of the creative to add to the finalized deal, in the format
        /// `buyers/{buyerAccountId}/creatives/{creativeId}`. See creative.name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creative")]
        public virtual string Creative { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to add a note.</summary>
    public class AddNoteRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The note to add.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("note")]
        public virtual Note Note { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines a segment of inventory that buyer wants to buy. It's created by buyer and could be shared with multiple
    /// buyers.
    /// </summary>
    public class AuctionPackage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Time the auction package was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Output only. The buyer that created this auction package. Format: `buyers/{buyerAccountId}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creator")]
        public virtual string Creator { get; set; }

        /// <summary>Output only. A description of the auction package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The display_name assigned to the auction package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Immutable. The unique identifier for the auction package. Format:
        /// `buyers/{accountId}/auctionPackages/{auctionPackageId}` The auction_package_id part of name is sent in the
        /// BidRequest to all RTB bidders and is returned as deal_id by the bidder in the BidResponse.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The list of clients of the current buyer that are subscribed to the AuctionPackage. Format:
        /// `buyers/{buyerAccountId}/clients/{clientAccountId}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscribedClients")]
        public virtual System.Collections.Generic.IList<string> SubscribedClients { get; set; }

        /// <summary>
        /// Output only. Time the auction package was last updated. This value is only increased when this auction
        /// package is updated but never when a buyer subscribed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for batch updating deals.</summary>
    public class BatchUpdateDealsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. List of request messages to update deals.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<UpdateDealRequest> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for batch updating deals.</summary>
    public class BatchUpdateDealsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Deals updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deals")]
        public virtual System.Collections.Generic.IList<Deal> Deals { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to cancel an ongoing negotiation.</summary>
    public class CancelNegotiationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A client represents an agency, a brand, or an advertiser customer of the buyer. Based on the client's role, its
    /// client users will have varying levels of restricted access to the Marketplace and certain other sections of the
    /// Authorized Buyers UI.
    /// </summary>
    public class Client : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Display name shown to publishers. Must be unique for clients without partnerClientId specified.
        /// Maximum length of 255 characters is allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. The resource name of the client. Format: `buyers/{accountId}/clients/{clientAccountId}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Arbitrary unique identifier provided by the buyer. This field can be used to associate a client with an
        /// identifier in the namespace of the buyer, lookup clients by that identifier and verify whether an Authorized
        /// Buyers account of the client already exists. If present, must be unique across all the clients.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partnerClientId")]
        public virtual string PartnerClientId { get; set; }

        /// <summary>
        /// Required. The role assigned to the client. Each role implies a set of permissions granted to the client.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>Whether the client will be visible to sellers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sellerVisible")]
        public virtual System.Nullable<bool> SellerVisible { get; set; }

        /// <summary>Output only. The state of the client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A user of a client who has restricted access to the Marketplace and certain other sections of the Authorized
    /// Buyers UI based on the role granted to the associated client.
    /// </summary>
    public class ClientUser : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The client user's email address that has to be unique across all users for the same client.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>
        /// Output only. The resource name of the client user. Format:
        /// `buyers/{accountId}/clients/{clientAccountId}/users/{userId}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The state of the client user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains information on how a buyer or seller can be reached.</summary>
    public class Contact : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The display_name of the contact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Email address for the contact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message captures data about the creatives in the deal.</summary>
    public class CreativeRequirements : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The format of the creative, only applicable for programmatic guaranteed and preferred deals.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativeFormat")]
        public virtual string CreativeFormat { get; set; }

        /// <summary>Output only. Specifies the creative pre-approval policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativePreApprovalPolicy")]
        public virtual string CreativePreApprovalPolicy { get; set; }

        /// <summary>Output only. Specifies whether the creative is safeFrame compatible.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativeSafeFrameCompatibility")]
        public virtual string CreativeSafeFrameCompatibility { get; set; }

        /// <summary>
        /// Output only. The max duration of the video creative in milliseconds. only applicable for deals with video
        /// creatives.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxAdDurationMs")]
        public virtual System.Nullable<long> MaxAdDurationMs { get; set; }

        /// <summary>
        /// Output only. Specifies the creative source for programmatic deals. PUBLISHER means creative is provided by
        /// seller and ADVERTISER means creative is provided by the buyer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("programmaticCreativeSource")]
        public virtual string ProgrammaticCreativeSource { get; set; }

        /// <summary>
        /// Output only. Skippable video ads allow viewers to skip ads after 5 seconds. Only applicable for deals with
        /// video creatives.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skippableAdType")]
        public virtual string SkippableAdType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Generic targeting used for targeting dimensions that contains a list of included and excluded numeric IDs. This
    /// cannot be filtered using list filter syntax.
    /// </summary>
    public class CriteriaTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of numeric IDs to be excluded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedCriteriaIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> ExcludedCriteriaIds { get; set; }

        /// <summary>A list of numeric IDs to be included.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetedCriteriaIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> TargetedCriteriaIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines targeting for a period of time on a specific week day.</summary>
    public class DayPart : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Day of week for the period.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dayOfWeek")]
        public virtual string DayOfWeek { get; set; }

        /// <summary>
        /// Hours in 24 hour time between 0 and 24, inclusive. Note: 24 is logically equivalent to 0, but is supported
        /// since in some cases there may need to be differentiation made between midnight on one day and midnight on
        /// the next day. Accepted values for minutes are [0, 15, 30, 45]. 0 is the only acceptable minute value for
        /// hour 24. Seconds and nanos are ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual TimeOfDay EndTime { get; set; }

        /// <summary>
        /// Hours in 24 hour time between 0 and 24, inclusive. Note: 24 is logically equivalent to 0, but is supported
        /// since in some cases there may need to be differentiation made between midnight on one day and midnight on
        /// the next day. Accepted values for minutes are [0, 15, 30, 45]. 0 is the only acceptable minute value for
        /// hour 24. Seconds and nanos are ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual TimeOfDay StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents Daypart targeting.</summary>
    public class DayPartTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The targeted weekdays and times</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dayParts")]
        public virtual System.Collections.Generic.IList<DayPart> DayParts { get; set; }

        /// <summary>The time zone type of the day parts</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZoneType")]
        public virtual string TimeZoneType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for disabling a client.</summary>
    public class DeactivateClientRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for deactivating a client user.</summary>
    public class DeactivateClientUserRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A deal represents a segment of inventory for displaying ads that contains the terms and targeting information
    /// that is used for serving as well as the deal stats and status. Note: A proposal may contain multiple deals.
    /// </summary>
    public class Deal : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. When the client field is populated, this field refers to the buyer who creates and manages the
        /// client buyer and gets billed on behalf of the client buyer; when the buyer field is populated, this field is
        /// the same value as buyer. Format : `buyers/{buyerAccountId}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billedBuyer")]
        public virtual string BilledBuyer { get; set; }

        /// <summary>
        /// Output only. Refers to a buyer in The Realtime-bidding API. Format: `buyers/{buyerAccountId}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buyer")]
        public virtual string Buyer { get; set; }

        /// <summary>
        /// Output only. Refers to a Client. Format: `buyers/{buyerAccountId}/clients/{clientAccountid}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("client")]
        public virtual string Client { get; set; }

        /// <summary>Output only. The time of the deal creation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. Metadata about the creatives of this deal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativeRequirements")]
        public virtual CreativeRequirements CreativeRequirements { get; set; }

        /// <summary>Output only. Type of deal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dealType")]
        public virtual string DealType { get; set; }

        /// <summary>Output only. Specifies the pacing set by the publisher.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliveryControl")]
        public virtual DeliveryControl DeliveryControl { get; set; }

        /// <summary>Output only. Free text description for the deal terms.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Output only. The name of the deal. Maximum length of 255 unicode characters is allowed. Control characters
        /// are not allowed. Buyers cannot update this field. Note: Not to be confused with name, which is a unique
        /// identifier of the deal.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Specified by buyers in request for proposal (RFP) to notify publisher the total estimated spend for the
        /// proposal. Publishers will receive this information and send back proposed deals accordingly.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("estimatedGrossSpend")]
        public virtual Money EstimatedGrossSpend { get; set; }

        /// <summary>
        /// Proposed flight end time of the deal. This will generally be stored in a granularity of a second. A value is
        /// not necessary for Private Auction deals.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flightEndTime")]
        public virtual object FlightEndTime { get; set; }

        /// <summary>
        /// Proposed flight start time of the deal. This will generally be stored in the granularity of one second since
        /// deal serving starts at seconds boundary. Any time specified with more granularity (for example, in
        /// milliseconds) will be truncated towards the start of time in seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flightStartTime")]
        public virtual object FlightStartTime { get; set; }

        /// <summary>
        /// Immutable. The unique identifier of the deal. Auto-generated by the server when a deal is created. Format:
        /// buyers/{accountId}/proposals/{proposalId}/deals/{dealId}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The terms for preferred deals.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preferredDealTerms")]
        public virtual PreferredDealTerms PreferredDealTerms { get; set; }

        /// <summary>The terms for private auction deals.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateAuctionTerms")]
        public virtual PrivateAuctionTerms PrivateAuctionTerms { get; set; }

        /// <summary>The terms for programmatic guaranteed deals.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("programmaticGuaranteedTerms")]
        public virtual ProgrammaticGuaranteedTerms ProgrammaticGuaranteedTerms { get; set; }

        /// <summary>
        /// Output only. The revision number for the proposal and is the same value as proposal.proposal_revision. Each
        /// update to deal causes the proposal revision number to auto-increment. The buyer keeps track of the last
        /// revision number they know of and pass it in when making an update. If the head revision number on the server
        /// has since incremented, then an ABORTED error is returned during the update operation to let the buyer know
        /// that a subsequent update was made.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proposalRevision")]
        public virtual System.Nullable<long> ProposalRevision { get; set; }

        /// <summary>
        /// Immutable. Reference to the seller on the deal. Format:
        /// `buyers/{buyerAccountId}/publisherProfiles/{publisherProfileId}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publisherProfile")]
        public virtual string PublisherProfile { get; set; }

        /// <summary>
        /// Output only. Time zone of the seller used to mark the boundaries of a day for daypart targeting and CPD
        /// billing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sellerTimeZone")]
        public virtual TimeZone SellerTimeZone { get; set; }

        /// <summary>
        /// Specifies the subset of inventory targeted by the deal. Can be updated by the buyer before the deal is
        /// finalized.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targeting")]
        public virtual MarketplaceTargeting Targeting { get; set; }

        /// <summary>Output only. The time when the deal was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information related to deal pausing.</summary>
    public class DealPausingInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The reason for the pausing of the deal; empty for active deals.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pauseReason")]
        public virtual string PauseReason { get; set; }

        /// <summary>The party that first paused the deal; unspecified for active deals.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pauseRole")]
        public virtual string PauseRole { get; set; }

        /// <summary>Whether pausing is consented between buyer and seller for the deal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pausingConsented")]
        public virtual System.Nullable<bool> PausingConsented { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message contains details about how the deal will be paced.</summary>
    public class DeliveryControl : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Specifies roadblocking in a main companion lineitem.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("companionDeliveryType")]
        public virtual string CompanionDeliveryType { get; set; }

        /// <summary>
        /// Output only. Specifies strategy to use for selecting a creative when multiple creatives of the same size are
        /// available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativeRotationType")]
        public virtual string CreativeRotationType { get; set; }

        /// <summary>Output only. Specifies how the impression delivery will be paced.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliveryRateType")]
        public virtual string DeliveryRateType { get; set; }

        /// <summary>Output only. Specifies any frequency caps. Cannot be filtered within ListDealsRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frequencyCap")]
        public virtual System.Collections.Generic.IList<FrequencyCap> FrequencyCap { get; set; }

        /// <summary>Output only. Specifies the roadblocking type in display creatives.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roadblockingType")]
        public virtual string RoadblockingType { get; set; }

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

    /// <summary>
    /// A finalized deal is a snapshot of the deal when both buyer and seller accept the deal. The buyer or seller can
    /// update the deal after it's been finalized and renegotiate on the deal targeting, terms and other fields, while
    /// at the same time the finalized snapshot of the deal can still be retrieved using this API. The finalized deal
    /// contains a copy of the deal as it existed when most recently finalized, as well as fields related to deal
    /// serving such as pause/resume status, RTB metrics, and more.
    /// </summary>
    public class FinalizedDeal : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A copy of the Deal made upon finalization. During renegotiation, this will reflect the last finalized deal
        /// before renegotiation was initiated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deal")]
        public virtual Deal Deal { get; set; }

        /// <summary>Information related to deal pausing for the deal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dealPausingInfo")]
        public virtual DealPausingInfo DealPausingInfo { get; set; }

        /// <summary>Serving status of the deal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dealServingStatus")]
        public virtual string DealServingStatus { get; set; }

        /// <summary>
        /// The resource name of the finalized deal. Format: `buyers/{accountId}/finalizeddeals/{finalizedDealId}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Whether the Programmatic Guaranteed deal is ready for serving.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readyToServe")]
        public virtual System.Nullable<bool> ReadyToServe { get; set; }

        /// <summary>Real-time bidding metrics for this deal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rtbMetrics")]
        public virtual RtbMetrics RtbMetrics { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a list of targeted and excluded mobile application IDs that publishers own. Android App ID, for
    /// example, com.google.android.apps.maps, can be found in Google Play Store URL. iOS App ID (which is a number) can
    /// be found at the end of iTunes store URL. First party mobile applications is either included or excluded.
    /// </summary>
    public class FirstPartyMobileApplicationTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of application IDs to be excluded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedAppIds")]
        public virtual System.Collections.Generic.IList<string> ExcludedAppIds { get; set; }

        /// <summary>A list of application IDs to be included.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetedAppIds")]
        public virtual System.Collections.Generic.IList<string> TargetedAppIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message contains details about publisher-set frequency caps of the delivery.</summary>
    public class FrequencyCap : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The maximum number of impressions that can be served to a user within the specified time period.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxImpressions")]
        public virtual System.Nullable<int> MaxImpressions { get; set; }

        /// <summary>
        /// The time unit. Along with num_time_units defines the amount of time over which impressions per user are
        /// counted and capped.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeUnitType")]
        public virtual string TimeUnitType { get; set; }

        /// <summary>
        /// The amount of time, in the units specified by time_unit_type. Defines the amount of time over which
        /// impressions per user are counted and capped.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeUnitsCount")]
        public virtual System.Nullable<int> TimeUnitsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the size of an ad unit that can be targeted on a bid request.</summary>
    public class InventorySizeTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of inventory sizes to be excluded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedInventorySizes")]
        public virtual System.Collections.Generic.IList<AdSize> ExcludedInventorySizes { get; set; }

        /// <summary>A list of inventory sizes to be included.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetedInventorySizes")]
        public virtual System.Collections.Generic.IList<AdSize> TargetedInventorySizes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing auction packages.</summary>
    public class ListAuctionPackagesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of auction packages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auctionPackages")]
        public virtual System.Collections.Generic.IList<AuctionPackage> AuctionPackages { get; set; }

        /// <summary>
        /// Continuation token for fetching the next page of results. Pass this value in the
        /// ListAuctionPackagesRequest.pageToken field in the subsequent call to the `ListAuctionPackages` method to
        /// retrieve the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the list method.</summary>
    public class ListClientUsersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The returned list of client users.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientUsers")]
        public virtual System.Collections.Generic.IList<ClientUser> ClientUsers { get; set; }

        /// <summary>
        /// A token to retrieve the next page of results. Pass this value in the ListClientUsersRequest.pageToken field
        /// in the subsequent call to the list method to retrieve the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the list method.</summary>
    public class ListClientsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The returned list of clients.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clients")]
        public virtual System.Collections.Generic.IList<Client> Clients { get; set; }

        /// <summary>
        /// A token to retrieve the next page of results. Pass this value in the ListClientsRequest.pageToken field in
        /// the subsequent call to the list method to retrieve the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing deals in a proposal.</summary>
    public class ListDealsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of deals.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deals")]
        public virtual System.Collections.Generic.IList<Deal> Deals { get; set; }

        /// <summary>Token to fetch the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing finalized deals.</summary>
    public class ListFinalizedDealsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of finalized deals.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finalizedDeals")]
        public virtual System.Collections.Generic.IList<FinalizedDeal> FinalizedDeals { get; set; }

        /// <summary>Token to fetch the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing proposals.</summary>
    public class ListProposalsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Continuation token for fetching the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of proposals.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proposals")]
        public virtual System.Collections.Generic.IList<Proposal> Proposals { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for profiles visible to the buyer.</summary>
    public class ListPublisherProfilesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Token to fetch the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of matching publisher profiles.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publisherProfiles")]
        public virtual System.Collections.Generic.IList<PublisherProfile> PublisherProfiles { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Targeting represents different criteria that can be used to target inventory. For example, they can choose to
    /// target inventory only if the user is in the US. Multiple types of targeting are always applied as a logical AND,
    /// unless noted otherwise.
    /// </summary>
    public class MarketplaceTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Daypart targeting information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("daypartTargeting")]
        public virtual DayPartTargeting DaypartTargeting { get; set; }

        /// <summary>Output only. Geo criteria IDs to be included/excluded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("geoTargeting")]
        public virtual CriteriaTargeting GeoTargeting { get; set; }

        /// <summary>Output only. Inventory sizes to be included/excluded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inventorySizeTargeting")]
        public virtual InventorySizeTargeting InventorySizeTargeting { get; set; }

        /// <summary>Output only. Placement targeting information, for example, URL, mobile applications.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placementTargeting")]
        public virtual PlacementTargeting PlacementTargeting { get; set; }

        /// <summary>
        /// Output only. Technology targeting information, for example, operating system, device category.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("technologyTargeting")]
        public virtual TechnologyTargeting TechnologyTargeting { get; set; }

        /// <summary>
        /// Buyer user list targeting information. User lists can be uploaded using
        /// https://developers.google.com/authorized-buyers/rtb/bulk-uploader.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userListTargeting")]
        public virtual CriteriaTargeting UserListTargeting { get; set; }

        /// <summary>Output only. Video targeting information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoTargeting")]
        public virtual VideoTargeting VideoTargeting { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Mobile application targeting settings.</summary>
    public class MobileApplicationTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Publisher owned apps to be targeted or excluded by the publisher to display the ads in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstPartyTargeting")]
        public virtual FirstPartyMobileApplicationTargeting FirstPartyTargeting { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an amount of money with its currency type.</summary>
    public class Money : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The three-letter currency code defined in ISO 4217.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>
        /// Number of nano (10^-9) units of the amount. The value must be between -999,999,999 and +999,999,999
        /// inclusive. If `units` is positive, `nanos` must be positive or zero. If `units` is zero, `nanos` can be
        /// positive, zero, or negative. If `units` is negative, `nanos` must be negative or zero. For example $-1.75 is
        /// represented as `units`=-1 and `nanos`=-750,000,000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>
        /// The whole units of the amount. For example if `currencyCode` is `"USD"`, then 1 unit is one US dollar.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("units")]
        public virtual System.Nullable<long> Units { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A text note attached to the proposal to facilitate the communication between buyers and sellers.
    /// </summary>
    public class Note : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. When this note was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The role who created the note.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creatorRole")]
        public virtual string CreatorRole { get; set; }

        /// <summary>The text of the note. Maximum length is 1024 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("note")]
        public virtual string NoteValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents targeting information for operating systems.</summary>
    public class OperatingSystemTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>IDs of operating systems to be included/excluded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatingSystemCriteria")]
        public virtual CriteriaTargeting OperatingSystemCriteria { get; set; }

        /// <summary>IDs of operating system versions to be included/excluded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatingSystemVersionCriteria")]
        public virtual CriteriaTargeting OperatingSystemVersionCriteria { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for pausing a finalized deal.</summary>
    public class PauseFinalizedDealRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The reason to pause the finalized deal, will be displayed to the seller. Maximum length is 1000 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents targeting about where the ads can appear, for example, certain sites or mobile applications.
    /// Different placement targeting types will be logically OR'ed.
    /// </summary>
    public class PlacementTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Mobile application targeting information in a deal. This doesn't apply to Auction Packages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileApplicationTargeting")]
        public virtual MobileApplicationTargeting MobileApplicationTargeting { get; set; }

        /// <summary>URLs to be included/excluded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uriTargeting")]
        public virtual UriTargeting UriTargeting { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Pricing terms for Preferred Deals.</summary>
    public class PreferredDealTerms : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Fixed price for the deal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixedPrice")]
        public virtual Price FixedPrice { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a price and a pricing type for a deal.</summary>
    public class Price : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The actual price with currency specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amount")]
        public virtual Money Amount { get; set; }

        /// <summary>The pricing type for the deal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Pricing terms for Private Auctions.</summary>
    public class PrivateAuctionTerms : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The minimum price buyer has to bid to compete in the private auction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floorPrice")]
        public virtual Price FloorPrice { get; set; }

        /// <summary>
        /// Output only. True if open auction buyers are allowed to compete with invited buyers in this private auction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openAuctionAllowed")]
        public virtual System.Nullable<bool> OpenAuctionAllowed { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Buyers are allowed to store certain types of private data in a proposal or deal.</summary>
    public class PrivateData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A buyer specified reference ID. This can be queried in the list operations (max-length: 1024 unicode code
        /// units).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referenceId")]
        public virtual string ReferenceId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Pricing terms for Programmatic Guaranteed Deals.</summary>
    public class ProgrammaticGuaranteedTerms : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Fixed price for the deal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixedPrice")]
        public virtual Price FixedPrice { get; set; }

        /// <summary>Count of guaranteed looks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("guaranteedLooks")]
        public virtual System.Nullable<long> GuaranteedLooks { get; set; }

        /// <summary>
        /// The lifetime impression cap for CPM Sponsorship deals. Deal will stop serving when cap is reached.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("impressionCap")]
        public virtual System.Nullable<long> ImpressionCap { get; set; }

        /// <summary>Daily minimum looks for CPD deal types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumDailyLooks")]
        public virtual System.Nullable<long> MinimumDailyLooks { get; set; }

        /// <summary>
        /// For sponsorship deals, this is the percentage of the seller's eligible impressions that the deal will serve
        /// until the cap is reached. Valid value is within range 0~100.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percentShareOfVoice")]
        public virtual System.Nullable<long> PercentShareOfVoice { get; set; }

        /// <summary>
        /// The reservation type for a Programmatic Guaranteed deal. This indicates whether the number of impressions is
        /// fixed, or a percent of available impressions. If not specified, the default reservation type is STANDARD.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reservationType")]
        public virtual string ReservationType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a proposal in the Marketplace. A proposal is the unit of negotiation between a seller and a buyer.
    /// </summary>
    public class Proposal : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. When the client field is populated, this field refers to the buyer who creates and manages the
        /// client buyer and gets billed on behalf of the client buyer; when the buyer field is populated, this field is
        /// the same value as buyer. Format : `buyers/{buyerAccountId}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billedBuyer")]
        public virtual string BilledBuyer { get; set; }

        /// <summary>
        /// Output only. Refers to a buyer in The Realtime-bidding API. Format: `buyers/{buyerAccountId}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buyer")]
        public virtual string Buyer { get; set; }

        /// <summary>Contact information for the buyer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buyerContacts")]
        public virtual System.Collections.Generic.IList<Contact> BuyerContacts { get; set; }

        /// <summary>Buyer private data (hidden from seller).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buyerPrivateData")]
        public virtual PrivateData BuyerPrivateData { get; set; }

        /// <summary>
        /// Output only. Refers to a Client. Format: `buyers/{buyerAccountId}/clients/{clientAccountid}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("client")]
        public virtual string Client { get; set; }

        /// <summary>Output only. Type of deal the proposal contains.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dealType")]
        public virtual string DealType { get; set; }

        /// <summary>
        /// Output only. The descriptive name for the proposal. Maximum length of 255 unicode characters is allowed.
        /// Control characters are not allowed. Buyers cannot update this field. Note: Not to be confused with name,
        /// which is a unique identifier of the proposal.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. True if the proposal was previously finalized and is now being renegotiated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isRenegotiating")]
        public virtual System.Nullable<bool> IsRenegotiating { get; set; }

        /// <summary>
        /// Output only. The role of the last user that either updated the proposal or left a comment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdaterOrCommentorRole")]
        public virtual string LastUpdaterOrCommentorRole { get; set; }

        /// <summary>
        /// Immutable. The name of the proposal serving as a unique identifier. Format:
        /// buyers/{accountId}/proposals/{proposalId}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>A list of notes from the buyer and the seller attached to this proposal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notes")]
        public virtual System.Collections.Generic.IList<Note> Notes { get; set; }

        /// <summary>Output only. Indicates whether the buyer/seller created the proposal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originatorRole")]
        public virtual string OriginatorRole { get; set; }

        /// <summary>
        /// Whether pausing is allowed for the proposal. This is a negotiable term between buyers and publishers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pausingConsented")]
        public virtual System.Nullable<bool> PausingConsented { get; set; }

        /// <summary>
        /// Output only. The revision number for the proposal. Each update to the proposal or deal causes the proposal
        /// revision number to auto-increment. The buyer keeps track of the last revision number they know of and pass
        /// it in when making an update. If the head revision number on the server has since incremented, then an
        /// ABORTED error is returned during the update operation to let the buyer know that a subsequent update was
        /// made.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proposalRevision")]
        public virtual System.Nullable<long> ProposalRevision { get; set; }

        /// <summary>
        /// Immutable. Reference to the seller on the proposal. Format:
        /// `buyers/{buyerAccountId}/publisherProfiles/{publisherProfileId}` Note: This field may be set only when
        /// creating the resource. Modifying this field while updating the resource will result in an error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publisherProfile")]
        public virtual string PublisherProfile { get; set; }

        /// <summary>Output only. Contact information for the seller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sellerContacts")]
        public virtual System.Collections.Generic.IList<Contact> SellerContacts { get; set; }

        /// <summary>Output only. Indicates the state of the proposal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Output only. The terms and conditions associated with this proposal. Accepting a proposal implies acceptance
        /// of this field. This is created by the seller, the buyer can only view it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("termsAndConditions")]
        public virtual string TermsAndConditions { get; set; }

        /// <summary>Output only. The time when the proposal was last revised.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The values in the publisher profile are supplied by the publisher. All fields are not filterable unless stated
    /// otherwise.
    /// </summary>
    public class PublisherProfile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description on the publisher's audience.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audienceDescription")]
        public virtual string AudienceDescription { get; set; }

        /// <summary>
        /// Contact information for direct reservation deals. This is free text entered by the publisher and may include
        /// information like names, phone numbers and email addresses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("directDealsContact")]
        public virtual string DirectDealsContact { get; set; }

        /// <summary>
        /// Display name of the publisher profile. Can be used to filter the response of the publisherProfiles.list
        /// method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The list of domains represented in this publisher profile. Empty if this is a parent profile. These are top
        /// private domains, meaning that these will not contain a string like "photos.google.co.uk/123", but will
        /// instead contain "google.co.uk". Can be used to filter the response of the publisherProfiles.list method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domains")]
        public virtual System.Collections.Generic.IList<string> Domains { get; set; }

        /// <summary>
        /// Indicates if this profile is the parent profile of the seller. A parent profile represents all the inventory
        /// from the seller, as opposed to child profile that is created to brand a portion of inventory. One seller has
        /// only one parent publisher profile, and can have multiple child profiles. See
        /// https://support.google.com/admanager/answer/6035806 for details. Can be used to filter the response of the
        /// publisherProfiles.list method by setting the filter to "is_parent: true".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isParent")]
        public virtual System.Nullable<bool> IsParent { get; set; }

        /// <summary>
        /// A Google public URL to the logo for this publisher profile. The logo is stored as a PNG, JPG, or GIF image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logoUrl")]
        public virtual string LogoUrl { get; set; }

        /// <summary>URL to additional marketing and sales materials.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mediaKitUrl")]
        public virtual string MediaKitUrl { get; set; }

        /// <summary>
        /// The list of apps represented in this publisher profile. Empty if this is a parent profile.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileApps")]
        public virtual System.Collections.Generic.IList<PublisherProfileMobileApplication> MobileApps { get; set; }

        /// <summary>
        /// Name of the publisher profile. Format: `buyers/{buyer}/publisherProfiles/{publisher_profile}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Overview of the publisher.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overview")]
        public virtual string Overview { get; set; }

        /// <summary>
        /// Statement explaining what's unique about publisher's business, and why buyers should partner with the
        /// publisher.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pitchStatement")]
        public virtual string PitchStatement { get; set; }

        /// <summary>
        /// Contact information for programmatic deals. This is free text entered by the publisher and may include
        /// information like names, phone numbers and email addresses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("programmaticDealsContact")]
        public virtual string ProgrammaticDealsContact { get; set; }

        /// <summary>
        /// A unique identifying code for the seller. This value is the same for all of the seller's parent and child
        /// publisher profiles. Can be used to filter the response of the publisherProfiles.list method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publisherCode")]
        public virtual string PublisherCode { get; set; }

        /// <summary>URL to a sample content page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("samplePageUrl")]
        public virtual string SamplePageUrl { get; set; }

        /// <summary>
        /// Up to three key metrics and rankings. For example, "#1 Mobile News Site for 20 Straight Months".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topHeadlines")]
        public virtual System.Collections.Generic.IList<string> TopHeadlines { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A mobile application that contains a external app ID, name, and app store.</summary>
    public class PublisherProfileMobileApplication : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The app store the app belongs to. Can be used to filter the response of the publisherProfiles.list method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appStore")]
        public virtual string AppStore { get; set; }

        /// <summary>
        /// The external ID for the app from its app store. Can be used to filter the response of the
        /// publisherProfiles.list method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalAppId")]
        public virtual string ExternalAppId { get; set; }

        /// <summary>The name of the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for resuming a finalized deal.</summary>
    public class ResumeFinalizedDealRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Real-time bidding metrics. For what each metric means refer to [Report
    /// metrics](https://support.google.com/adxbuyer/answer/6115195#report-metrics)
    /// </summary>
    public class RtbMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Ad impressions in last 7 days.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adImpressions7Days")]
        public virtual System.Nullable<long> AdImpressions7Days { get; set; }

        /// <summary>Bid rate in last 7 days, calculated by (bids / bid requests).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bidRate7Days")]
        public virtual System.Nullable<double> BidRate7Days { get; set; }

        /// <summary>Bid requests in last 7 days.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bidRequests7Days")]
        public virtual System.Nullable<long> BidRequests7Days { get; set; }

        /// <summary>Bids in last 7 days.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bids7Days")]
        public virtual System.Nullable<long> Bids7Days { get; set; }

        /// <summary>Filtered bid rate in last 7 days, calculated by (filtered bids / bids).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filteredBidRate7Days")]
        public virtual System.Nullable<double> FilteredBidRate7Days { get; set; }

        /// <summary>Must bid rate for current month.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mustBidRateCurrentMonth")]
        public virtual System.Nullable<double> MustBidRateCurrentMonth { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Request to send an RFP. All fields in this request are proposed to publisher and subject to changes by publisher
    /// during later negotiation.
    /// </summary>
    public class SendRfpRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Contact information for the buyer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buyerContacts")]
        public virtual System.Collections.Generic.IList<Contact> BuyerContacts { get; set; }

        /// <summary>
        /// If the current buyer is sending the RFP on behalf of its client, use this field to specify the name of the
        /// client in the format: `buyers/{accountId}/clients/{clientAccountid}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("client")]
        public virtual string Client { get; set; }

        /// <summary>Required. The display name of the proposal being created by this RFP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Specified by buyers in request for proposal (RFP) to notify publisher the total estimated spend for the
        /// proposal. Publishers will receive this information and send back proposed deals accordingly.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("estimatedGrossSpend")]
        public virtual Money EstimatedGrossSpend { get; set; }

        /// <summary>
        /// Required. Proposed flight end time of the RFP. A timestamp in RFC3339 UTC "Zulu" format. Note that the
        /// specified value will be truncated to a granularity of one second.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flightEndTime")]
        public virtual object FlightEndTime { get; set; }

        /// <summary>
        /// Required. Proposed flight start time of the RFP. A timestamp in RFC3339 UTC "Zulu" format. Note that the
        /// specified value will be truncated to a granularity of one second.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flightStartTime")]
        public virtual object FlightStartTime { get; set; }

        /// <summary>Geo criteria IDs to be targeted. Refer to Geo tables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("geoTargeting")]
        public virtual CriteriaTargeting GeoTargeting { get; set; }

        /// <summary>Inventory sizes to be targeted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inventorySizeTargeting")]
        public virtual InventorySizeTargeting InventorySizeTargeting { get; set; }

        /// <summary>A message that is sent to the publisher. Maximum length is 1024 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("note")]
        public virtual string Note { get; set; }

        /// <summary>The terms for preferred deals.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preferredDealTerms")]
        public virtual PreferredDealTerms PreferredDealTerms { get; set; }

        /// <summary>The terms for programmatic guaranteed deals.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("programmaticGuaranteedTerms")]
        public virtual ProgrammaticGuaranteedTerms ProgrammaticGuaranteedTerms { get; set; }

        /// <summary>
        /// Required. The profile of the publisher who will receive this RFP in the format:
        /// `buyers/{accountId}/publisherProfiles/{publisherProfileId}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publisherProfile")]
        public virtual string PublisherProfile { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for setting ready to serve for a finalized deal.</summary>
    public class SetReadyToServeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for SubscribeAuctionPackage.</summary>
    public class SubscribeAuctionPackageRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for SubscribeAuctionPackageClients.</summary>
    public class SubscribeClientsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A list of client buyers to subscribe to the auction package, with client buyer in the format
        /// `buyers/{accountId}/clients/{clientAccountId}`. The current buyer will be subscribed to the auction package
        /// regardless of the list contents if not already.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clients")]
        public virtual System.Collections.Generic.IList<string> Clients { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents targeting about various types of technology.</summary>
    public class TechnologyTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>IDs of device capabilities to be included/excluded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceCapabilityTargeting")]
        public virtual CriteriaTargeting DeviceCapabilityTargeting { get; set; }

        /// <summary>IDs of device categories to be included/excluded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceCategoryTargeting")]
        public virtual CriteriaTargeting DeviceCategoryTargeting { get; set; }

        /// <summary>Operating system related targeting information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatingSystemTargeting")]
        public virtual OperatingSystemTargeting OperatingSystemTargeting { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a time of day. The date and time zone are either not significant or are specified elsewhere. An API
    /// may choose to allow leap seconds. Related types are google.type.Date and `google.protobuf.Timestamp`.
    /// </summary>
    public class TimeOfDay : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for
        /// scenarios like business closing time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hours")]
        public virtual System.Nullable<int> Hours { get; set; }

        /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minutes")]
        public virtual System.Nullable<int> Minutes { get; set; }

        /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>
        /// Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows
        /// leap-seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seconds")]
        public virtual System.Nullable<int> Seconds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a time zone from the [IANA Time Zone Database](https://www.iana.org/time-zones).</summary>
    public class TimeZone : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>IANA Time Zone Database time zone, e.g. "America/New_York".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Optional. IANA Time Zone Database version number, e.g. "2019a".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for UnsubscribeAuctionPackage.</summary>
    public class UnsubscribeAuctionPackageRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for UnsubscribeAuctionPackage.</summary>
    public class UnsubscribeClientsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A list of client buyers to unsubscribe from the auction package, with client buyer in the format
        /// `buyers/{accountId}/clients/{clientAccountId}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clients")]
        public virtual System.Collections.Generic.IList<string> Clients { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for updating the deal at the given revision number.</summary>
    public class UpdateDealRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The deal to update. The deal's `name` field is used to identify the deal to be updated. Note:
        /// proposal_revision will have to be provided within the resource or else an error will be thrown. Format:
        /// buyers/{accountId}/proposals/{proposalId}/deals/{dealId}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deal")]
        public virtual Deal Deal { get; set; }

        /// <summary>
        /// List of fields to be updated. If empty or unspecified, the service will update all fields populated in the
        /// update request excluding the output only fields and primitive fields with default value. Note that explicit
        /// field mask is required in order to reset a primitive field back to its default value, for example, false for
        /// boolean fields, 0 for integer fields. A special field mask consisting of a single path "*" can be used to
        /// indicate full replacement(the equivalent of PUT method), updatable fields unset or unspecified in the input
        /// will be cleared or set to default value. Output only fields will be ignored regardless of the value of
        /// updateMask.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a list of targeted and excluded URLs (for example, google.com). For Private Auction Deals, URLs are
    /// either included or excluded. For Programmatic Guaranteed and Preferred Deals, this doesn't apply.
    /// </summary>
    public class UriTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of URLs to be excluded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedUris")]
        public virtual System.Collections.Generic.IList<string> ExcludedUris { get; set; }

        /// <summary>A list of URLs to be included.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetedUris")]
        public virtual System.Collections.Generic.IList<string> TargetedUris { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents targeting information about video.</summary>
    public class VideoTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of video positions to be excluded. When this field is populated, the targeted_position_types field
        /// must be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedPositionTypes")]
        public virtual System.Collections.Generic.IList<string> ExcludedPositionTypes { get; set; }

        /// <summary>
        /// A list of video positions to be included. When this field is populated, the excluded_position_types field
        /// must be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetedPositionTypes")]
        public virtual System.Collections.Generic.IList<string> TargetedPositionTypes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
