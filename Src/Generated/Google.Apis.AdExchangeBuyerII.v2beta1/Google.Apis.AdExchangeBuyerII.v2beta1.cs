// Copyright 2021 Google LLC
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

namespace Google.Apis.AdExchangeBuyerII.v2beta1
{
    /// <summary>The AdExchangeBuyerII Service.</summary>
    public class AdExchangeBuyerIIService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2beta1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AdExchangeBuyerIIService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AdExchangeBuyerIIService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Accounts = new AccountsResource(this);
            Bidders = new BiddersResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "adexchangebuyer2";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://adexchangebuyer.googleapis.com/";
        #else
            "https://adexchangebuyer.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://adexchangebuyer.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Ad Exchange Buyer API II.</summary>
        public class Scope
        {
            /// <summary>Manage your Ad Exchange buyer account configuration</summary>
            public static string AdexchangeBuyer = "https://www.googleapis.com/auth/adexchange.buyer";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Ad Exchange Buyer API II.</summary>
        public static class ScopeConstants
        {
            /// <summary>Manage your Ad Exchange buyer account configuration</summary>
            public const string AdexchangeBuyer = "https://www.googleapis.com/auth/adexchange.buyer";
        }

        /// <summary>Gets the Accounts resource.</summary>
        public virtual AccountsResource Accounts { get; }

        /// <summary>Gets the Bidders resource.</summary>
        public virtual BiddersResource Bidders { get; }
    }

    /// <summary>A base abstract class for AdExchangeBuyerII requests.</summary>
    public abstract class AdExchangeBuyerIIBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new AdExchangeBuyerIIBaseServiceRequest instance.</summary>
        protected AdExchangeBuyerIIBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes AdExchangeBuyerII parameter list.</summary>
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

    /// <summary>The "accounts" collection of methods.</summary>
    public class AccountsResource
    {
        private const string Resource = "accounts";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AccountsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Clients = new ClientsResource(service);
            Creatives = new CreativesResource(service);
            FinalizedProposals = new FinalizedProposalsResource(service);
            Products = new ProductsResource(service);
            Proposals = new ProposalsResource(service);
            PublisherProfiles = new PublisherProfilesResource(service);
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
                Invitations = new InvitationsResource(service);
                Users = new UsersResource(service);
            }

            /// <summary>Gets the Invitations resource.</summary>
            public virtual InvitationsResource Invitations { get; }

            /// <summary>The "invitations" collection of methods.</summary>
            public class InvitationsResource
            {
                private const string Resource = "invitations";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public InvitationsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Creates and sends out an email invitation to access an Ad Exchange client buyer account.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="accountId">Numerical account ID of the client's sponsor buyer. (required)</param>
                /// <param name="clientAccountId">
                /// Numerical account ID of the client buyer that the user should be associated with. (required)
                /// </param>
                public virtual CreateRequest Create(Google.Apis.AdExchangeBuyerII.v2beta1.Data.ClientUserInvitation body, long accountId, long clientAccountId)
                {
                    return new CreateRequest(service, body, accountId, clientAccountId);
                }

                /// <summary>
                /// Creates and sends out an email invitation to access an Ad Exchange client buyer account.
                /// </summary>
                public class CreateRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.ClientUserInvitation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyerII.v2beta1.Data.ClientUserInvitation body, long accountId, long clientAccountId) : base(service)
                    {
                        AccountId = accountId;
                        ClientAccountId = clientAccountId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Numerical account ID of the client's sponsor buyer. (required)</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long AccountId { get; private set; }

                    /// <summary>
                    /// Numerical account ID of the client buyer that the user should be associated with. (required)
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clientAccountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long ClientAccountId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AdExchangeBuyerII.v2beta1.Data.ClientUserInvitation Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2beta1/accounts/{accountId}/clients/{clientAccountId}/invitations";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clientAccountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clientAccountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Retrieves an existing client user invitation.</summary>
                /// <param name="accountId">Numerical account ID of the client's sponsor buyer. (required)</param>
                /// <param name="clientAccountId">
                /// Numerical account ID of the client buyer that the user invitation to be retrieved is associated
                /// with. (required)
                /// </param>
                /// <param name="invitationId">
                /// Numerical identifier of the user invitation to retrieve. (required)
                /// </param>
                public virtual GetRequest Get(long accountId, long clientAccountId, long invitationId)
                {
                    return new GetRequest(service, accountId, clientAccountId, invitationId);
                }

                /// <summary>Retrieves an existing client user invitation.</summary>
                public class GetRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.ClientUserInvitation>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, long accountId, long clientAccountId, long invitationId) : base(service)
                    {
                        AccountId = accountId;
                        ClientAccountId = clientAccountId;
                        InvitationId = invitationId;
                        InitParameters();
                    }

                    /// <summary>Numerical account ID of the client's sponsor buyer. (required)</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long AccountId { get; private set; }

                    /// <summary>
                    /// Numerical account ID of the client buyer that the user invitation to be retrieved is associated
                    /// with. (required)
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clientAccountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long ClientAccountId { get; private set; }

                    /// <summary>Numerical identifier of the user invitation to retrieve. (required)</summary>
                    [Google.Apis.Util.RequestParameterAttribute("invitationId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long InvitationId { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2beta1/accounts/{accountId}/clients/{clientAccountId}/invitations/{invitationId}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clientAccountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clientAccountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("invitationId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "invitationId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Lists all the client users invitations for a client with a given account ID.</summary>
                /// <param name="accountId">Numerical account ID of the client's sponsor buyer. (required)</param>
                /// <param name="clientAccountId">
                /// Numerical account ID of the client buyer to list invitations for. (required) You must either specify
                /// a string representation of a numerical account identifier or the `-` character to list all the
                /// invitations for all the clients of a given sponsor buyer.
                /// </param>
                public virtual ListRequest List(long accountId, string clientAccountId)
                {
                    return new ListRequest(service, accountId, clientAccountId);
                }

                /// <summary>Lists all the client users invitations for a client with a given account ID.</summary>
                public class ListRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.ListClientUserInvitationsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, long accountId, string clientAccountId) : base(service)
                    {
                        AccountId = accountId;
                        ClientAccountId = clientAccountId;
                        InitParameters();
                    }

                    /// <summary>Numerical account ID of the client's sponsor buyer. (required)</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long AccountId { get; private set; }

                    /// <summary>
                    /// Numerical account ID of the client buyer to list invitations for. (required) You must either
                    /// specify a string representation of a numerical account identifier or the `-` character to list
                    /// all the invitations for all the clients of a given sponsor buyer.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clientAccountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ClientAccountId { get; private set; }

                    /// <summary>
                    /// Requested page size. Server may return fewer clients than requested. If unspecified, server will
                    /// pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A token identifying a page of results the server should return. Typically, this is the value of
                    /// ListClientUserInvitationsResponse.nextPageToken returned from the previous call to the
                    /// clients.invitations.list method.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2beta1/accounts/{accountId}/clients/{clientAccountId}/invitations";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clientAccountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clientAccountId",
                            IsRequired = true,
                            ParameterType = "path",
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

                /// <summary>Retrieves an existing client user.</summary>
                /// <param name="accountId">Numerical account ID of the client's sponsor buyer. (required)</param>
                /// <param name="clientAccountId">
                /// Numerical account ID of the client buyer that the user to be retrieved is associated with.
                /// (required)
                /// </param>
                /// <param name="userId">Numerical identifier of the user to retrieve. (required)</param>
                public virtual GetRequest Get(long accountId, long clientAccountId, long userId)
                {
                    return new GetRequest(service, accountId, clientAccountId, userId);
                }

                /// <summary>Retrieves an existing client user.</summary>
                public class GetRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.ClientUser>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, long accountId, long clientAccountId, long userId) : base(service)
                    {
                        AccountId = accountId;
                        ClientAccountId = clientAccountId;
                        UserId = userId;
                        InitParameters();
                    }

                    /// <summary>Numerical account ID of the client's sponsor buyer. (required)</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long AccountId { get; private set; }

                    /// <summary>
                    /// Numerical account ID of the client buyer that the user to be retrieved is associated with.
                    /// (required)
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clientAccountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long ClientAccountId { get; private set; }

                    /// <summary>Numerical identifier of the user to retrieve. (required)</summary>
                    [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long UserId { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2beta1/accounts/{accountId}/clients/{clientAccountId}/users/{userId}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clientAccountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clientAccountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "userId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Lists all the known client users for a specified sponsor buyer account ID.</summary>
                /// <param name="accountId">
                /// Numerical account ID of the sponsor buyer of the client to list users for. (required)
                /// </param>
                /// <param name="clientAccountId">
                /// The account ID of the client buyer to list users for. (required) You must specify either a string
                /// representation of a numerical account identifier or the `-` character to list all the client users
                /// for all the clients of a given sponsor buyer.
                /// </param>
                public virtual ListRequest List(long accountId, string clientAccountId)
                {
                    return new ListRequest(service, accountId, clientAccountId);
                }

                /// <summary>Lists all the known client users for a specified sponsor buyer account ID.</summary>
                public class ListRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.ListClientUsersResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, long accountId, string clientAccountId) : base(service)
                    {
                        AccountId = accountId;
                        ClientAccountId = clientAccountId;
                        InitParameters();
                    }

                    /// <summary>
                    /// Numerical account ID of the sponsor buyer of the client to list users for. (required)
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long AccountId { get; private set; }

                    /// <summary>
                    /// The account ID of the client buyer to list users for. (required) You must specify either a
                    /// string representation of a numerical account identifier or the `-` character to list all the
                    /// client users for all the clients of a given sponsor buyer.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clientAccountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ClientAccountId { get; private set; }

                    /// <summary>
                    /// Requested page size. The server may return fewer clients than requested. If unspecified, the
                    /// server will pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A token identifying a page of results the server should return. Typically, this is the value of
                    /// ListClientUsersResponse.nextPageToken returned from the previous call to the
                    /// accounts.clients.users.list method.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2beta1/accounts/{accountId}/clients/{clientAccountId}/users";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clientAccountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clientAccountId",
                            IsRequired = true,
                            ParameterType = "path",
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

                /// <summary>Updates an existing client user. Only the user status can be changed on update.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="accountId">Numerical account ID of the client's sponsor buyer. (required)</param>
                /// <param name="clientAccountId">
                /// Numerical account ID of the client buyer that the user to be retrieved is associated with.
                /// (required)
                /// </param>
                /// <param name="userId">Numerical identifier of the user to retrieve. (required)</param>
                public virtual UpdateRequest Update(Google.Apis.AdExchangeBuyerII.v2beta1.Data.ClientUser body, long accountId, long clientAccountId, long userId)
                {
                    return new UpdateRequest(service, body, accountId, clientAccountId, userId);
                }

                /// <summary>Updates an existing client user. Only the user status can be changed on update.</summary>
                public class UpdateRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.ClientUser>
                {
                    /// <summary>Constructs a new Update request.</summary>
                    public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyerII.v2beta1.Data.ClientUser body, long accountId, long clientAccountId, long userId) : base(service)
                    {
                        AccountId = accountId;
                        ClientAccountId = clientAccountId;
                        UserId = userId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Numerical account ID of the client's sponsor buyer. (required)</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long AccountId { get; private set; }

                    /// <summary>
                    /// Numerical account ID of the client buyer that the user to be retrieved is associated with.
                    /// (required)
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clientAccountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long ClientAccountId { get; private set; }

                    /// <summary>Numerical identifier of the user to retrieve. (required)</summary>
                    [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual long UserId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AdExchangeBuyerII.v2beta1.Data.ClientUser Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "update";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PUT";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2beta1/accounts/{accountId}/clients/{clientAccountId}/users/{userId}";

                    /// <summary>Initializes Update parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clientAccountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clientAccountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "userId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Creates a new client buyer.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">
            /// Unique numerical account ID for the buyer of which the client buyer is a customer; the sponsor buyer to
            /// create a client for. (required)
            /// </param>
            public virtual CreateRequest Create(Google.Apis.AdExchangeBuyerII.v2beta1.Data.Client body, long accountId)
            {
                return new CreateRequest(service, body, accountId);
            }

            /// <summary>Creates a new client buyer.</summary>
            public class CreateRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.Client>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyerII.v2beta1.Data.Client body, long accountId) : base(service)
                {
                    AccountId = accountId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Unique numerical account ID for the buyer of which the client buyer is a customer; the sponsor buyer
                /// to create a client for. (required)
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AccountId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AdExchangeBuyerII.v2beta1.Data.Client Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta1/accounts/{accountId}/clients";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Gets a client buyer with a given client account ID.</summary>
            /// <param name="accountId">Numerical account ID of the client's sponsor buyer. (required)</param>
            /// <param name="clientAccountId">Numerical account ID of the client buyer to retrieve. (required)</param>
            public virtual GetRequest Get(long accountId, long clientAccountId)
            {
                return new GetRequest(service, accountId, clientAccountId);
            }

            /// <summary>Gets a client buyer with a given client account ID.</summary>
            public class GetRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.Client>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, long accountId, long clientAccountId) : base(service)
                {
                    AccountId = accountId;
                    ClientAccountId = clientAccountId;
                    InitParameters();
                }

                /// <summary>Numerical account ID of the client's sponsor buyer. (required)</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AccountId { get; private set; }

                /// <summary>Numerical account ID of the client buyer to retrieve. (required)</summary>
                [Google.Apis.Util.RequestParameterAttribute("clientAccountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long ClientAccountId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta1/accounts/{accountId}/clients/{clientAccountId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("clientAccountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "clientAccountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists all the clients for the current sponsor buyer.</summary>
            /// <param name="accountId">
            /// Unique numerical account ID of the sponsor buyer to list the clients for.
            /// </param>
            public virtual ListRequest List(long accountId)
            {
                return new ListRequest(service, accountId);
            }

            /// <summary>Lists all the clients for the current sponsor buyer.</summary>
            public class ListRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.ListClientsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, long accountId) : base(service)
                {
                    AccountId = accountId;
                    InitParameters();
                }

                /// <summary>Unique numerical account ID of the sponsor buyer to list the clients for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AccountId { get; private set; }

                /// <summary>
                /// Requested page size. The server may return fewer clients than requested. If unspecified, the server
                /// will pick an appropriate default.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A token identifying a page of results the server should return. Typically, this is the value of
                /// ListClientsResponse.nextPageToken returned from the previous call to the accounts.clients.list
                /// method.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// Optional unique identifier (from the standpoint of an Ad Exchange sponsor buyer partner) of the
                /// client to return. If specified, at most one client will be returned in the response.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("partnerClientId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PartnerClientId { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta1/accounts/{accountId}/clients";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
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
                    RequestParameters.Add("partnerClientId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "partnerClientId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates an existing client buyer.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">
            /// Unique numerical account ID for the buyer of which the client buyer is a customer; the sponsor buyer to
            /// update a client for. (required)
            /// </param>
            /// <param name="clientAccountId">Unique numerical account ID of the client to update. (required)</param>
            public virtual UpdateRequest Update(Google.Apis.AdExchangeBuyerII.v2beta1.Data.Client body, long accountId, long clientAccountId)
            {
                return new UpdateRequest(service, body, accountId, clientAccountId);
            }

            /// <summary>Updates an existing client buyer.</summary>
            public class UpdateRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.Client>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyerII.v2beta1.Data.Client body, long accountId, long clientAccountId) : base(service)
                {
                    AccountId = accountId;
                    ClientAccountId = clientAccountId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Unique numerical account ID for the buyer of which the client buyer is a customer; the sponsor buyer
                /// to update a client for. (required)
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long AccountId { get; private set; }

                /// <summary>Unique numerical account ID of the client to update. (required)</summary>
                [Google.Apis.Util.RequestParameterAttribute("clientAccountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long ClientAccountId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AdExchangeBuyerII.v2beta1.Data.Client Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta1/accounts/{accountId}/clients/{clientAccountId}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("clientAccountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "clientAccountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Creatives resource.</summary>
        public virtual CreativesResource Creatives { get; }

        /// <summary>The "creatives" collection of methods.</summary>
        public class CreativesResource
        {
            private const string Resource = "creatives";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public CreativesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                DealAssociations = new DealAssociationsResource(service);
            }

            /// <summary>Gets the DealAssociations resource.</summary>
            public virtual DealAssociationsResource DealAssociations { get; }

            /// <summary>The "dealAssociations" collection of methods.</summary>
            public class DealAssociationsResource
            {
                private const string Resource = "dealAssociations";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DealAssociationsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Associate an existing deal with a creative.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="accountId">The account the creative belongs to.</param>
                /// <param name="creativeId">The ID of the creative associated with the deal.</param>
                public virtual AddRequest Add(Google.Apis.AdExchangeBuyerII.v2beta1.Data.AddDealAssociationRequest body, string accountId, string creativeId)
                {
                    return new AddRequest(service, body, accountId, creativeId);
                }

                /// <summary>Associate an existing deal with a creative.</summary>
                public class AddRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.Empty>
                {
                    /// <summary>Constructs a new Add request.</summary>
                    public AddRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyerII.v2beta1.Data.AddDealAssociationRequest body, string accountId, string creativeId) : base(service)
                    {
                        AccountId = accountId;
                        CreativeId = creativeId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The account the creative belongs to.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AccountId { get; private set; }

                    /// <summary>The ID of the creative associated with the deal.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("creativeId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string CreativeId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AdExchangeBuyerII.v2beta1.Data.AddDealAssociationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "add";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2beta1/accounts/{accountId}/creatives/{creativeId}/dealAssociations:add";

                    /// <summary>Initializes Add parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("creativeId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "creativeId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>List all creative-deal associations.</summary>
                /// <param name="accountId">
                /// The account to list the associations from. Specify "-" to list all creatives the current user has
                /// access to.
                /// </param>
                /// <param name="creativeId">
                /// The creative ID to list the associations from. Specify "-" to list all creatives under the above
                /// account.
                /// </param>
                public virtual ListRequest List(string accountId, string creativeId)
                {
                    return new ListRequest(service, accountId, creativeId);
                }

                /// <summary>List all creative-deal associations.</summary>
                public class ListRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.ListDealAssociationsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string accountId, string creativeId) : base(service)
                    {
                        AccountId = accountId;
                        CreativeId = creativeId;
                        InitParameters();
                    }

                    /// <summary>
                    /// The account to list the associations from. Specify "-" to list all creatives the current user
                    /// has access to.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AccountId { get; private set; }

                    /// <summary>
                    /// The creative ID to list the associations from. Specify "-" to list all creatives under the above
                    /// account.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("creativeId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string CreativeId { get; private set; }

                    /// <summary>
                    /// Requested page size. Server may return fewer associations than requested. If unspecified, server
                    /// will pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A token identifying a page of results the server should return. Typically, this is the value of
                    /// ListDealAssociationsResponse.next_page_token returned from the previous call to
                    /// 'ListDealAssociations' method.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>
                    /// An optional query string to filter deal associations. If no filter is specified, all
                    /// associations will be returned. Supported queries are: - accountId=*account_id_string* -
                    /// creativeId=*creative_id_string* - dealsId=*deals_id_string* - dealsStatus:{approved,
                    /// conditionally_approved, disapproved, not_checked} - openAuctionStatus:{approved,
                    /// conditionally_approved, disapproved, not_checked} Example: 'dealsId=12345 AND
                    /// dealsStatus:disapproved'
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Query { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2beta1/accounts/{accountId}/creatives/{creativeId}/dealAssociations";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("creativeId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "creativeId",
                            IsRequired = true,
                            ParameterType = "path",
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

                /// <summary>Remove the association between a deal and a creative.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="accountId">The account the creative belongs to.</param>
                /// <param name="creativeId">The ID of the creative associated with the deal.</param>
                public virtual RemoveRequest Remove(Google.Apis.AdExchangeBuyerII.v2beta1.Data.RemoveDealAssociationRequest body, string accountId, string creativeId)
                {
                    return new RemoveRequest(service, body, accountId, creativeId);
                }

                /// <summary>Remove the association between a deal and a creative.</summary>
                public class RemoveRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.Empty>
                {
                    /// <summary>Constructs a new Remove request.</summary>
                    public RemoveRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyerII.v2beta1.Data.RemoveDealAssociationRequest body, string accountId, string creativeId) : base(service)
                    {
                        AccountId = accountId;
                        CreativeId = creativeId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The account the creative belongs to.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AccountId { get; private set; }

                    /// <summary>The ID of the creative associated with the deal.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("creativeId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string CreativeId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AdExchangeBuyerII.v2beta1.Data.RemoveDealAssociationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "remove";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2beta1/accounts/{accountId}/creatives/{creativeId}/dealAssociations:remove";

                    /// <summary>Initializes Remove parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("creativeId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "creativeId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Creates a creative.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">
            /// The account that this creative belongs to. Can be used to filter the response of the creatives.list
            /// method.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.AdExchangeBuyerII.v2beta1.Data.Creative body, string accountId)
            {
                return new CreateRequest(service, body, accountId);
            }

            /// <summary>Creates a creative.</summary>
            public class CreateRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.Creative>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyerII.v2beta1.Data.Creative body, string accountId) : base(service)
                {
                    AccountId = accountId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The account that this creative belongs to. Can be used to filter the response of the creatives.list
                /// method.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>
                /// Indicates if multiple creatives can share an ID or not. Default is NO_DUPLICATES (one ID per
                /// creative).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("duplicateIdMode", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<DuplicateIdModeEnum> DuplicateIdMode { get; set; }

                /// <summary>
                /// Indicates if multiple creatives can share an ID or not. Default is NO_DUPLICATES (one ID per
                /// creative).
                /// </summary>
                public enum DuplicateIdModeEnum
                {
                    /// <summary>
                    /// Recommended. This means that an ID will be unique to a single creative. Multiple creatives will
                    /// not share an ID.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("NO_DUPLICATES")]
                    NODUPLICATES = 0,

                    /// <summary>
                    /// Not recommended. Using this option will allow multiple creatives to share the same ID. Get and
                    /// Update requests will not be possible for any ID that has more than one creative associated.
                    /// (List will still function.) This is only intended for backwards compatibility in cases where a
                    /// single ID is already shared by multiple creatives from previous APIs.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("FORCE_ENABLE_DUPLICATE_IDS")]
                    FORCEENABLEDUPLICATEIDS = 1,
                }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AdExchangeBuyerII.v2beta1.Data.Creative Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta1/accounts/{accountId}/creatives";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("duplicateIdMode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "duplicateIdMode",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Gets a creative.</summary>
            /// <param name="accountId">The account the creative belongs to.</param>
            /// <param name="creativeId">The ID of the creative to retrieve.</param>
            public virtual GetRequest Get(string accountId, string creativeId)
            {
                return new GetRequest(service, accountId, creativeId);
            }

            /// <summary>Gets a creative.</summary>
            public class GetRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.Creative>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string accountId, string creativeId) : base(service)
                {
                    AccountId = accountId;
                    CreativeId = creativeId;
                    InitParameters();
                }

                /// <summary>The account the creative belongs to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>The ID of the creative to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("creativeId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CreativeId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta1/accounts/{accountId}/creatives/{creativeId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("creativeId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "creativeId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists creatives.</summary>
            /// <param name="accountId">
            /// The account to list the creatives from. Specify "-" to list all creatives the current user has access
            /// to.
            /// </param>
            public virtual ListRequest List(string accountId)
            {
                return new ListRequest(service, accountId);
            }

            /// <summary>Lists creatives.</summary>
            public class ListRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.ListCreativesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string accountId) : base(service)
                {
                    AccountId = accountId;
                    InitParameters();
                }

                /// <summary>
                /// The account to list the creatives from. Specify "-" to list all creatives the current user has
                /// access to.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>
                /// Requested page size. The server may return fewer creatives than requested (due to timeout
                /// constraint) even if more are available via another call. If unspecified, server will pick an
                /// appropriate default. Acceptable values are 1 to 1000, inclusive.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A token identifying a page of results the server should return. Typically, this is the value of
                /// ListCreativesResponse.next_page_token returned from the previous call to 'ListCreatives' method.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// An optional query string to filter creatives. If no filter is specified, all active creatives will
                /// be returned. Supported queries are: - accountId=*account_id_string* -
                /// creativeId=*creative_id_string* - dealsStatus: {approved, conditionally_approved, disapproved,
                /// not_checked} - openAuctionStatus: {approved, conditionally_approved, disapproved, not_checked} -
                /// attribute: {a numeric attribute from the list of attributes} - disapprovalReason: {a reason from
                /// DisapprovalReason} Example: 'accountId=12345 AND (dealsStatus:disapproved AND
                /// disapprovalReason:unacceptable_content) OR attribute:47'
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Query { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta1/accounts/{accountId}/creatives";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
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

            /// <summary>
            /// Stops watching a creative. Will stop push notifications being sent to the topics when the creative
            /// changes status.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">The account of the creative to stop notifications for.</param>
            /// <param name="creativeId">
            /// The creative ID of the creative to stop notifications for. Specify "-" to specify stopping account level
            /// notifications.
            /// </param>
            public virtual StopWatchingRequest StopWatching(Google.Apis.AdExchangeBuyerII.v2beta1.Data.StopWatchingCreativeRequest body, string accountId, string creativeId)
            {
                return new StopWatchingRequest(service, body, accountId, creativeId);
            }

            /// <summary>
            /// Stops watching a creative. Will stop push notifications being sent to the topics when the creative
            /// changes status.
            /// </summary>
            public class StopWatchingRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.Empty>
            {
                /// <summary>Constructs a new StopWatching request.</summary>
                public StopWatchingRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyerII.v2beta1.Data.StopWatchingCreativeRequest body, string accountId, string creativeId) : base(service)
                {
                    AccountId = accountId;
                    CreativeId = creativeId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The account of the creative to stop notifications for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>
                /// The creative ID of the creative to stop notifications for. Specify "-" to specify stopping account
                /// level notifications.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("creativeId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CreativeId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AdExchangeBuyerII.v2beta1.Data.StopWatchingCreativeRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "stopWatching";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta1/accounts/{accountId}/creatives/{creativeId}:stopWatching";

                /// <summary>Initializes StopWatching parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("creativeId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "creativeId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates a creative.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">
            /// The account that this creative belongs to. Can be used to filter the response of the creatives.list
            /// method.
            /// </param>
            /// <param name="creativeId">
            /// The buyer-defined creative ID of this creative. Can be used to filter the response of the creatives.list
            /// method.
            /// </param>
            public virtual UpdateRequest Update(Google.Apis.AdExchangeBuyerII.v2beta1.Data.Creative body, string accountId, string creativeId)
            {
                return new UpdateRequest(service, body, accountId, creativeId);
            }

            /// <summary>Updates a creative.</summary>
            public class UpdateRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.Creative>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyerII.v2beta1.Data.Creative body, string accountId, string creativeId) : base(service)
                {
                    AccountId = accountId;
                    CreativeId = creativeId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The account that this creative belongs to. Can be used to filter the response of the creatives.list
                /// method.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>
                /// The buyer-defined creative ID of this creative. Can be used to filter the response of the
                /// creatives.list method.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("creativeId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CreativeId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AdExchangeBuyerII.v2beta1.Data.Creative Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta1/accounts/{accountId}/creatives/{creativeId}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("creativeId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "creativeId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Watches a creative. Will result in push notifications being sent to the topic when the creative changes
            /// status.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">The account of the creative to watch.</param>
            /// <param name="creativeId">
            /// The creative ID to watch for status changes. Specify "-" to watch all creatives under the above account.
            /// If both creative-level and account-level notifications are sent, only a single notification will be sent
            /// to the creative-level notification topic.
            /// </param>
            public virtual WatchRequest Watch(Google.Apis.AdExchangeBuyerII.v2beta1.Data.WatchCreativeRequest body, string accountId, string creativeId)
            {
                return new WatchRequest(service, body, accountId, creativeId);
            }

            /// <summary>
            /// Watches a creative. Will result in push notifications being sent to the topic when the creative changes
            /// status.
            /// </summary>
            public class WatchRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.Empty>
            {
                /// <summary>Constructs a new Watch request.</summary>
                public WatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyerII.v2beta1.Data.WatchCreativeRequest body, string accountId, string creativeId) : base(service)
                {
                    AccountId = accountId;
                    CreativeId = creativeId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The account of the creative to watch.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>
                /// The creative ID to watch for status changes. Specify "-" to watch all creatives under the above
                /// account. If both creative-level and account-level notifications are sent, only a single notification
                /// will be sent to the creative-level notification topic.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("creativeId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CreativeId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AdExchangeBuyerII.v2beta1.Data.WatchCreativeRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "watch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta1/accounts/{accountId}/creatives/{creativeId}:watch";

                /// <summary>Initializes Watch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("creativeId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "creativeId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the FinalizedProposals resource.</summary>
        public virtual FinalizedProposalsResource FinalizedProposals { get; }

        /// <summary>The "finalizedProposals" collection of methods.</summary>
        public class FinalizedProposalsResource
        {
            private const string Resource = "finalizedProposals";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public FinalizedProposalsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// List finalized proposals, regardless if a proposal is being renegotiated. A filter expression (PQL
            /// query) may be specified to filter the results. The notes will not be returned.
            /// </summary>
            /// <param name="accountId">Account ID of the buyer.</param>
            public virtual ListRequest List(string accountId)
            {
                return new ListRequest(service, accountId);
            }

            /// <summary>
            /// List finalized proposals, regardless if a proposal is being renegotiated. A filter expression (PQL
            /// query) may be specified to filter the results. The notes will not be returned.
            /// </summary>
            public class ListRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.ListProposalsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string accountId) : base(service)
                {
                    AccountId = accountId;
                    InitParameters();
                }

                /// <summary>Account ID of the buyer.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>
                /// An optional PQL filter query used to query for proposals. Nested repeated fields, such as
                /// proposal.deals.targetingCriterion, cannot be filtered.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Syntax the filter is written in. Current implementation defaults to PQL but in the future it will be
                /// LIST_FILTER.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filterSyntax", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<FilterSyntaxEnum> FilterSyntax { get; set; }

                /// <summary>
                /// Syntax the filter is written in. Current implementation defaults to PQL but in the future it will be
                /// LIST_FILTER.
                /// </summary>
                public enum FilterSyntaxEnum
                {
                    /// <summary>A placeholder for an undefined filter syntax.</summary>
                    [Google.Apis.Util.StringValueAttribute("FILTER_SYNTAX_UNSPECIFIED")]
                    FILTERSYNTAXUNSPECIFIED = 0,

                    /// <summary>
                    /// PQL query syntax. Visit https://developers.google.com/ad-manager/api/pqlreference for PQL
                    /// documentation and examples.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("PQL")]
                    PQL = 1,

                    /// <summary>
                    /// API list filtering syntax. Read about syntax and usage at
                    /// https://developers.google.com/authorized-buyers/apis/guides/v2/list-filters.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("LIST_FILTER")]
                    LISTFILTER = 2,
                }

                /// <summary>
                /// Requested page size. The server may return fewer results than requested. If unspecified, the server
                /// will pick an appropriate default.
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
                public override string RestPath => "v2beta1/accounts/{accountId}/finalizedProposals";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("filterSyntax", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filterSyntax",
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
            /// Update given deals to pause serving. This method will set the
            /// `DealServingMetadata.DealPauseStatus.has_buyer_paused` bit to true for all listed deals in the request.
            /// Currently, this method only applies to PG and PD deals. For PA deals, please call
            /// accounts.proposals.pause endpoint. It is a no-op to pause already-paused deals. It is an error to call
            /// PauseProposalDeals for deals which are not part of the proposal of proposal_id or which are not
            /// finalized or renegotiating.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID of the buyer.</param>
            /// <param name="proposalId">The proposal_id of the proposal containing the deals.</param>
            public virtual PauseRequest Pause(Google.Apis.AdExchangeBuyerII.v2beta1.Data.PauseProposalDealsRequest body, string accountId, string proposalId)
            {
                return new PauseRequest(service, body, accountId, proposalId);
            }

            /// <summary>
            /// Update given deals to pause serving. This method will set the
            /// `DealServingMetadata.DealPauseStatus.has_buyer_paused` bit to true for all listed deals in the request.
            /// Currently, this method only applies to PG and PD deals. For PA deals, please call
            /// accounts.proposals.pause endpoint. It is a no-op to pause already-paused deals. It is an error to call
            /// PauseProposalDeals for deals which are not part of the proposal of proposal_id or which are not
            /// finalized or renegotiating.
            /// </summary>
            public class PauseRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.Proposal>
            {
                /// <summary>Constructs a new Pause request.</summary>
                public PauseRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyerII.v2beta1.Data.PauseProposalDealsRequest body, string accountId, string proposalId) : base(service)
                {
                    AccountId = accountId;
                    ProposalId = proposalId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID of the buyer.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>The proposal_id of the proposal containing the deals.</summary>
                [Google.Apis.Util.RequestParameterAttribute("proposalId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProposalId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AdExchangeBuyerII.v2beta1.Data.PauseProposalDealsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "pause";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta1/accounts/{accountId}/finalizedProposals/{proposalId}:pause";

                /// <summary>Initializes Pause parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("proposalId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "proposalId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Update given deals to resume serving. This method will set the
            /// `DealServingMetadata.DealPauseStatus.has_buyer_paused` bit to false for all listed deals in the request.
            /// Currently, this method only applies to PG and PD deals. For PA deals, please call
            /// accounts.proposals.resume endpoint. It is a no-op to resume running deals or deals paused by the other
            /// party. It is an error to call ResumeProposalDeals for deals which are not part of the proposal of
            /// proposal_id or which are not finalized or renegotiating.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID of the buyer.</param>
            /// <param name="proposalId">The proposal_id of the proposal containing the deals.</param>
            public virtual ResumeRequest Resume(Google.Apis.AdExchangeBuyerII.v2beta1.Data.ResumeProposalDealsRequest body, string accountId, string proposalId)
            {
                return new ResumeRequest(service, body, accountId, proposalId);
            }

            /// <summary>
            /// Update given deals to resume serving. This method will set the
            /// `DealServingMetadata.DealPauseStatus.has_buyer_paused` bit to false for all listed deals in the request.
            /// Currently, this method only applies to PG and PD deals. For PA deals, please call
            /// accounts.proposals.resume endpoint. It is a no-op to resume running deals or deals paused by the other
            /// party. It is an error to call ResumeProposalDeals for deals which are not part of the proposal of
            /// proposal_id or which are not finalized or renegotiating.
            /// </summary>
            public class ResumeRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.Proposal>
            {
                /// <summary>Constructs a new Resume request.</summary>
                public ResumeRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyerII.v2beta1.Data.ResumeProposalDealsRequest body, string accountId, string proposalId) : base(service)
                {
                    AccountId = accountId;
                    ProposalId = proposalId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID of the buyer.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>The proposal_id of the proposal containing the deals.</summary>
                [Google.Apis.Util.RequestParameterAttribute("proposalId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProposalId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AdExchangeBuyerII.v2beta1.Data.ResumeProposalDealsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "resume";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta1/accounts/{accountId}/finalizedProposals/{proposalId}:resume";

                /// <summary>Initializes Resume parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("proposalId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "proposalId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Products resource.</summary>
        public virtual ProductsResource Products { get; }

        /// <summary>The "products" collection of methods.</summary>
        public class ProductsResource
        {
            private const string Resource = "products";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ProductsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Gets the requested product by ID.</summary>
            /// <param name="accountId">Account ID of the buyer.</param>
            /// <param name="productId">The ID for the product to get the head revision for.</param>
            public virtual GetRequest Get(string accountId, string productId)
            {
                return new GetRequest(service, accountId, productId);
            }

            /// <summary>Gets the requested product by ID.</summary>
            public class GetRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.Product>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string accountId, string productId) : base(service)
                {
                    AccountId = accountId;
                    ProductId = productId;
                    InitParameters();
                }

                /// <summary>Account ID of the buyer.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>The ID for the product to get the head revision for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProductId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta1/accounts/{accountId}/products/{productId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "productId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// List all products visible to the buyer (optionally filtered by the specified PQL query).
            /// </summary>
            /// <param name="accountId">Account ID of the buyer.</param>
            public virtual ListRequest List(string accountId)
            {
                return new ListRequest(service, accountId);
            }

            /// <summary>
            /// List all products visible to the buyer (optionally filtered by the specified PQL query).
            /// </summary>
            public class ListRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.ListProductsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string accountId) : base(service)
                {
                    AccountId = accountId;
                    InitParameters();
                }

                /// <summary>Account ID of the buyer.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>
                /// An optional PQL query used to query for products. See
                /// https://developers.google.com/ad-manager/docs/pqlreference for documentation about PQL and examples.
                /// Nested repeated fields, such as product.targetingCriterion.inclusions, cannot be filtered.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Requested page size. The server may return fewer results than requested. If unspecified, the server
                /// will pick an appropriate default.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>The page token as returned from ListProductsResponse.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta1/accounts/{accountId}/products";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
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
            }

            /// <summary>
            /// Mark the proposal as accepted at the given revision number. If the number does not match the server's
            /// revision number an `ABORTED` error message will be returned. This call updates the proposal_state from
            /// `PROPOSED` to `BUYER_ACCEPTED`, or from `SELLER_ACCEPTED` to `FINALIZED`. Upon calling this endpoint,
            /// the buyer implicitly agrees to the terms and conditions optionally set within the proposal by the
            /// publisher.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID of the buyer.</param>
            /// <param name="proposalId">The ID of the proposal to accept.</param>
            public virtual AcceptRequest Accept(Google.Apis.AdExchangeBuyerII.v2beta1.Data.AcceptProposalRequest body, string accountId, string proposalId)
            {
                return new AcceptRequest(service, body, accountId, proposalId);
            }

            /// <summary>
            /// Mark the proposal as accepted at the given revision number. If the number does not match the server's
            /// revision number an `ABORTED` error message will be returned. This call updates the proposal_state from
            /// `PROPOSED` to `BUYER_ACCEPTED`, or from `SELLER_ACCEPTED` to `FINALIZED`. Upon calling this endpoint,
            /// the buyer implicitly agrees to the terms and conditions optionally set within the proposal by the
            /// publisher.
            /// </summary>
            public class AcceptRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.Proposal>
            {
                /// <summary>Constructs a new Accept request.</summary>
                public AcceptRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyerII.v2beta1.Data.AcceptProposalRequest body, string accountId, string proposalId) : base(service)
                {
                    AccountId = accountId;
                    ProposalId = proposalId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID of the buyer.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>The ID of the proposal to accept.</summary>
                [Google.Apis.Util.RequestParameterAttribute("proposalId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProposalId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AdExchangeBuyerII.v2beta1.Data.AcceptProposalRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "accept";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta1/accounts/{accountId}/proposals/{proposalId}:accept";

                /// <summary>Initializes Accept parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("proposalId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "proposalId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Create a new note and attach it to the proposal. The note is assigned a unique ID by the server. The
            /// proposal revision number will not increase when associated with a new note.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID of the buyer.</param>
            /// <param name="proposalId">The ID of the proposal to attach the note to.</param>
            public virtual AddNoteRequest AddNote(Google.Apis.AdExchangeBuyerII.v2beta1.Data.AddNoteRequest body, string accountId, string proposalId)
            {
                return new AddNoteRequest(service, body, accountId, proposalId);
            }

            /// <summary>
            /// Create a new note and attach it to the proposal. The note is assigned a unique ID by the server. The
            /// proposal revision number will not increase when associated with a new note.
            /// </summary>
            public class AddNoteRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.Note>
            {
                /// <summary>Constructs a new AddNote request.</summary>
                public AddNoteRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyerII.v2beta1.Data.AddNoteRequest body, string accountId, string proposalId) : base(service)
                {
                    AccountId = accountId;
                    ProposalId = proposalId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID of the buyer.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>The ID of the proposal to attach the note to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("proposalId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProposalId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AdExchangeBuyerII.v2beta1.Data.AddNoteRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "addNote";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta1/accounts/{accountId}/proposals/{proposalId}:addNote";

                /// <summary>Initializes AddNote parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("proposalId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "proposalId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Cancel an ongoing negotiation on a proposal. This does not cancel or end serving for the deals if the
            /// proposal has been finalized, but only cancels a negotiation unilaterally.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID of the buyer.</param>
            /// <param name="proposalId">The ID of the proposal to cancel negotiation for.</param>
            public virtual CancelNegotiationRequest CancelNegotiation(Google.Apis.AdExchangeBuyerII.v2beta1.Data.CancelNegotiationRequest body, string accountId, string proposalId)
            {
                return new CancelNegotiationRequest(service, body, accountId, proposalId);
            }

            /// <summary>
            /// Cancel an ongoing negotiation on a proposal. This does not cancel or end serving for the deals if the
            /// proposal has been finalized, but only cancels a negotiation unilaterally.
            /// </summary>
            public class CancelNegotiationRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.Proposal>
            {
                /// <summary>Constructs a new CancelNegotiation request.</summary>
                public CancelNegotiationRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyerII.v2beta1.Data.CancelNegotiationRequest body, string accountId, string proposalId) : base(service)
                {
                    AccountId = accountId;
                    ProposalId = proposalId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID of the buyer.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>The ID of the proposal to cancel negotiation for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("proposalId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProposalId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AdExchangeBuyerII.v2beta1.Data.CancelNegotiationRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "cancelNegotiation";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta1/accounts/{accountId}/proposals/{proposalId}:cancelNegotiation";

                /// <summary>Initializes CancelNegotiation parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("proposalId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "proposalId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Update the given proposal to indicate that setup has been completed. This method is called by the buyer
            /// when the line items have been created on their end for a finalized proposal and all the required
            /// creatives have been uploaded using the creatives API. This call updates the `is_setup_completed` bit on
            /// the proposal and also notifies the seller. The server will advance the revision number of the most
            /// recent proposal.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID of the buyer.</param>
            /// <param name="proposalId">The ID of the proposal to mark as setup completed.</param>
            public virtual CompleteSetupRequest CompleteSetup(Google.Apis.AdExchangeBuyerII.v2beta1.Data.CompleteSetupRequest body, string accountId, string proposalId)
            {
                return new CompleteSetupRequest(service, body, accountId, proposalId);
            }

            /// <summary>
            /// Update the given proposal to indicate that setup has been completed. This method is called by the buyer
            /// when the line items have been created on their end for a finalized proposal and all the required
            /// creatives have been uploaded using the creatives API. This call updates the `is_setup_completed` bit on
            /// the proposal and also notifies the seller. The server will advance the revision number of the most
            /// recent proposal.
            /// </summary>
            public class CompleteSetupRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.Proposal>
            {
                /// <summary>Constructs a new CompleteSetup request.</summary>
                public CompleteSetupRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyerII.v2beta1.Data.CompleteSetupRequest body, string accountId, string proposalId) : base(service)
                {
                    AccountId = accountId;
                    ProposalId = proposalId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID of the buyer.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>The ID of the proposal to mark as setup completed.</summary>
                [Google.Apis.Util.RequestParameterAttribute("proposalId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProposalId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AdExchangeBuyerII.v2beta1.Data.CompleteSetupRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "completeSetup";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta1/accounts/{accountId}/proposals/{proposalId}:completeSetup";

                /// <summary>Initializes CompleteSetup parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("proposalId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "proposalId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Create the given proposal. Each created proposal and any deals it contains are assigned a unique ID by
            /// the server.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID of the buyer.</param>
            public virtual CreateRequest Create(Google.Apis.AdExchangeBuyerII.v2beta1.Data.Proposal body, string accountId)
            {
                return new CreateRequest(service, body, accountId);
            }

            /// <summary>
            /// Create the given proposal. Each created proposal and any deals it contains are assigned a unique ID by
            /// the server.
            /// </summary>
            public class CreateRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.Proposal>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyerII.v2beta1.Data.Proposal body, string accountId) : base(service)
                {
                    AccountId = accountId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID of the buyer.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AdExchangeBuyerII.v2beta1.Data.Proposal Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta1/accounts/{accountId}/proposals";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Gets a proposal given its ID. The proposal is returned at its head revision.</summary>
            /// <param name="accountId">Account ID of the buyer.</param>
            /// <param name="proposalId">The unique ID of the proposal</param>
            public virtual GetRequest Get(string accountId, string proposalId)
            {
                return new GetRequest(service, accountId, proposalId);
            }

            /// <summary>Gets a proposal given its ID. The proposal is returned at its head revision.</summary>
            public class GetRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.Proposal>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string accountId, string proposalId) : base(service)
                {
                    AccountId = accountId;
                    ProposalId = proposalId;
                    InitParameters();
                }

                /// <summary>Account ID of the buyer.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>The unique ID of the proposal</summary>
                [Google.Apis.Util.RequestParameterAttribute("proposalId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProposalId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta1/accounts/{accountId}/proposals/{proposalId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("proposalId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "proposalId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// List proposals. A filter expression (PQL query) may be specified to filter the results. To retrieve all
            /// finalized proposals, regardless if a proposal is being renegotiated, see the FinalizedProposals
            /// resource. Note that Bidder/ChildSeat relationships differ from the usual behavior. A Bidder account can
            /// only see its child seats' proposals by specifying the ChildSeat's accountId in the request path.
            /// </summary>
            /// <param name="accountId">Account ID of the buyer.</param>
            public virtual ListRequest List(string accountId)
            {
                return new ListRequest(service, accountId);
            }

            /// <summary>
            /// List proposals. A filter expression (PQL query) may be specified to filter the results. To retrieve all
            /// finalized proposals, regardless if a proposal is being renegotiated, see the FinalizedProposals
            /// resource. Note that Bidder/ChildSeat relationships differ from the usual behavior. A Bidder account can
            /// only see its child seats' proposals by specifying the ChildSeat's accountId in the request path.
            /// </summary>
            public class ListRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.ListProposalsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string accountId) : base(service)
                {
                    AccountId = accountId;
                    InitParameters();
                }

                /// <summary>Account ID of the buyer.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>
                /// An optional PQL filter query used to query for proposals. Nested repeated fields, such as
                /// proposal.deals.targetingCriterion, cannot be filtered.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Syntax the filter is written in. Current implementation defaults to PQL but in the future it will be
                /// LIST_FILTER.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filterSyntax", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<FilterSyntaxEnum> FilterSyntax { get; set; }

                /// <summary>
                /// Syntax the filter is written in. Current implementation defaults to PQL but in the future it will be
                /// LIST_FILTER.
                /// </summary>
                public enum FilterSyntaxEnum
                {
                    /// <summary>A placeholder for an undefined filter syntax.</summary>
                    [Google.Apis.Util.StringValueAttribute("FILTER_SYNTAX_UNSPECIFIED")]
                    FILTERSYNTAXUNSPECIFIED = 0,

                    /// <summary>
                    /// PQL query syntax. Visit https://developers.google.com/ad-manager/api/pqlreference for PQL
                    /// documentation and examples.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("PQL")]
                    PQL = 1,

                    /// <summary>
                    /// API list filtering syntax. Read about syntax and usage at
                    /// https://developers.google.com/authorized-buyers/apis/guides/v2/list-filters.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("LIST_FILTER")]
                    LISTFILTER = 2,
                }

                /// <summary>
                /// Requested page size. The server may return fewer results than requested. If unspecified, the server
                /// will pick an appropriate default.
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
                public override string RestPath => "v2beta1/accounts/{accountId}/proposals";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("filterSyntax", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filterSyntax",
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
            /// Update the given proposal to pause serving. This method will set the
            /// `DealServingMetadata.DealPauseStatus.has_buyer_paused` bit to true for all deals in the proposal. It is
            /// a no-op to pause an already-paused proposal. It is an error to call PauseProposal for a proposal that is
            /// not finalized or renegotiating.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID of the buyer.</param>
            /// <param name="proposalId">The ID of the proposal to pause.</param>
            public virtual PauseRequest Pause(Google.Apis.AdExchangeBuyerII.v2beta1.Data.PauseProposalRequest body, string accountId, string proposalId)
            {
                return new PauseRequest(service, body, accountId, proposalId);
            }

            /// <summary>
            /// Update the given proposal to pause serving. This method will set the
            /// `DealServingMetadata.DealPauseStatus.has_buyer_paused` bit to true for all deals in the proposal. It is
            /// a no-op to pause an already-paused proposal. It is an error to call PauseProposal for a proposal that is
            /// not finalized or renegotiating.
            /// </summary>
            public class PauseRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.Proposal>
            {
                /// <summary>Constructs a new Pause request.</summary>
                public PauseRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyerII.v2beta1.Data.PauseProposalRequest body, string accountId, string proposalId) : base(service)
                {
                    AccountId = accountId;
                    ProposalId = proposalId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID of the buyer.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>The ID of the proposal to pause.</summary>
                [Google.Apis.Util.RequestParameterAttribute("proposalId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProposalId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AdExchangeBuyerII.v2beta1.Data.PauseProposalRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "pause";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta1/accounts/{accountId}/proposals/{proposalId}:pause";

                /// <summary>Initializes Pause parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("proposalId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "proposalId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Update the given proposal to resume serving. This method will set the
            /// `DealServingMetadata.DealPauseStatus.has_buyer_paused` bit to false for all deals in the proposal. Note
            /// that if the `has_seller_paused` bit is also set, serving will not resume until the seller also resumes.
            /// It is a no-op to resume an already-running proposal. It is an error to call ResumeProposal for a
            /// proposal that is not finalized or renegotiating.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID of the buyer.</param>
            /// <param name="proposalId">The ID of the proposal to resume.</param>
            public virtual ResumeRequest Resume(Google.Apis.AdExchangeBuyerII.v2beta1.Data.ResumeProposalRequest body, string accountId, string proposalId)
            {
                return new ResumeRequest(service, body, accountId, proposalId);
            }

            /// <summary>
            /// Update the given proposal to resume serving. This method will set the
            /// `DealServingMetadata.DealPauseStatus.has_buyer_paused` bit to false for all deals in the proposal. Note
            /// that if the `has_seller_paused` bit is also set, serving will not resume until the seller also resumes.
            /// It is a no-op to resume an already-running proposal. It is an error to call ResumeProposal for a
            /// proposal that is not finalized or renegotiating.
            /// </summary>
            public class ResumeRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.Proposal>
            {
                /// <summary>Constructs a new Resume request.</summary>
                public ResumeRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyerII.v2beta1.Data.ResumeProposalRequest body, string accountId, string proposalId) : base(service)
                {
                    AccountId = accountId;
                    ProposalId = proposalId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID of the buyer.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>The ID of the proposal to resume.</summary>
                [Google.Apis.Util.RequestParameterAttribute("proposalId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProposalId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AdExchangeBuyerII.v2beta1.Data.ResumeProposalRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "resume";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta1/accounts/{accountId}/proposals/{proposalId}:resume";

                /// <summary>Initializes Resume parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("proposalId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "proposalId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Update the given proposal at the client known revision number. If the server revision has advanced since
            /// the passed-in `proposal.proposal_revision`, an `ABORTED` error message will be returned. Only the
            /// buyer-modifiable fields of the proposal will be updated. Note that the deals in the proposal will be
            /// updated to match the passed-in copy. If a passed-in deal does not have a `deal_id`, the server will
            /// assign a new unique ID and create the deal. If passed-in deal has a `deal_id`, it will be updated to
            /// match the passed-in copy. Any existing deals not present in the passed-in proposal will be deleted. It
            /// is an error to pass in a deal with a `deal_id` not present at head.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account ID of the buyer.</param>
            /// <param name="proposalId">The unique ID of the proposal.</param>
            public virtual UpdateRequest Update(Google.Apis.AdExchangeBuyerII.v2beta1.Data.Proposal body, string accountId, string proposalId)
            {
                return new UpdateRequest(service, body, accountId, proposalId);
            }

            /// <summary>
            /// Update the given proposal at the client known revision number. If the server revision has advanced since
            /// the passed-in `proposal.proposal_revision`, an `ABORTED` error message will be returned. Only the
            /// buyer-modifiable fields of the proposal will be updated. Note that the deals in the proposal will be
            /// updated to match the passed-in copy. If a passed-in deal does not have a `deal_id`, the server will
            /// assign a new unique ID and create the deal. If passed-in deal has a `deal_id`, it will be updated to
            /// match the passed-in copy. Any existing deals not present in the passed-in proposal will be deleted. It
            /// is an error to pass in a deal with a `deal_id` not present at head.
            /// </summary>
            public class UpdateRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.Proposal>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyerII.v2beta1.Data.Proposal body, string accountId, string proposalId) : base(service)
                {
                    AccountId = accountId;
                    ProposalId = proposalId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account ID of the buyer.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>The unique ID of the proposal.</summary>
                [Google.Apis.Util.RequestParameterAttribute("proposalId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProposalId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AdExchangeBuyerII.v2beta1.Data.Proposal Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta1/accounts/{accountId}/proposals/{proposalId}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("proposalId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "proposalId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
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

            /// <summary>Gets the requested publisher profile by id.</summary>
            /// <param name="accountId">Account ID of the buyer.</param>
            /// <param name="publisherProfileId">The id for the publisher profile to get.</param>
            public virtual GetRequest Get(string accountId, string publisherProfileId)
            {
                return new GetRequest(service, accountId, publisherProfileId);
            }

            /// <summary>Gets the requested publisher profile by id.</summary>
            public class GetRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.PublisherProfile>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string accountId, string publisherProfileId) : base(service)
                {
                    AccountId = accountId;
                    PublisherProfileId = publisherProfileId;
                    InitParameters();
                }

                /// <summary>Account ID of the buyer.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>The id for the publisher profile to get.</summary>
                [Google.Apis.Util.RequestParameterAttribute("publisherProfileId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PublisherProfileId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta1/accounts/{accountId}/publisherProfiles/{publisherProfileId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("publisherProfileId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "publisherProfileId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>List all publisher profiles visible to the buyer</summary>
            /// <param name="accountId">Account ID of the buyer.</param>
            public virtual ListRequest List(string accountId)
            {
                return new ListRequest(service, accountId);
            }

            /// <summary>List all publisher profiles visible to the buyer</summary>
            public class ListRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.ListPublisherProfilesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string accountId) : base(service)
                {
                    AccountId = accountId;
                    InitParameters();
                }

                /// <summary>Account ID of the buyer.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Specify the number of results to include per page.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>The page token as return from ListPublisherProfilesResponse.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta1/accounts/{accountId}/publisherProfiles";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
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
            Accounts = new AccountsResource(service);
            FilterSets = new FilterSetsResource(service);
        }

        /// <summary>Gets the Accounts resource.</summary>
        public virtual AccountsResource Accounts { get; }

        /// <summary>The "accounts" collection of methods.</summary>
        public class AccountsResource
        {
            private const string Resource = "accounts";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AccountsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                FilterSets = new FilterSetsResource(service);
            }

            /// <summary>Gets the FilterSets resource.</summary>
            public virtual FilterSetsResource FilterSets { get; }

            /// <summary>The "filterSets" collection of methods.</summary>
            public class FilterSetsResource
            {
                private const string Resource = "filterSets";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public FilterSetsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    BidMetrics = new BidMetricsResource(service);
                    BidResponseErrors = new BidResponseErrorsResource(service);
                    BidResponsesWithoutBids = new BidResponsesWithoutBidsResource(service);
                    FilteredBidRequests = new FilteredBidRequestsResource(service);
                    FilteredBids = new FilteredBidsResource(service);
                    ImpressionMetrics = new ImpressionMetricsResource(service);
                    LosingBids = new LosingBidsResource(service);
                    NonBillableWinningBids = new NonBillableWinningBidsResource(service);
                }

                /// <summary>Gets the BidMetrics resource.</summary>
                public virtual BidMetricsResource BidMetrics { get; }

                /// <summary>The "bidMetrics" collection of methods.</summary>
                public class BidMetricsResource
                {
                    private const string Resource = "bidMetrics";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public BidMetricsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Lists all metrics that are measured in terms of number of bids.</summary>
                    /// <param name="filterSetName">
                    /// Name of the filter set that should be applied to the requested metrics. For example: - For a
                    /// bidder-level filter set for bidder 123: `bidders/123/filterSets/abc` - For an account-level
                    /// filter set for the buyer account representing bidder 123:
                    /// `bidders/123/accounts/123/filterSets/abc` - For an account-level filter set for the child seat
                    /// buyer account 456 whose bidder is 123: `bidders/123/accounts/456/filterSets/abc`
                    /// </param>
                    public virtual ListRequest List(string filterSetName)
                    {
                        return new ListRequest(service, filterSetName);
                    }

                    /// <summary>Lists all metrics that are measured in terms of number of bids.</summary>
                    public class ListRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.ListBidMetricsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string filterSetName) : base(service)
                        {
                            FilterSetName = filterSetName;
                            InitParameters();
                        }

                        /// <summary>
                        /// Name of the filter set that should be applied to the requested metrics. For example: - For a
                        /// bidder-level filter set for bidder 123: `bidders/123/filterSets/abc` - For an account-level
                        /// filter set for the buyer account representing bidder 123:
                        /// `bidders/123/accounts/123/filterSets/abc` - For an account-level filter set for the child
                        /// seat buyer account 456 whose bidder is 123: `bidders/123/accounts/456/filterSets/abc`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filterSetName", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string FilterSetName { get; private set; }

                        /// <summary>
                        /// Requested page size. The server may return fewer results than requested. If unspecified, the
                        /// server will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A token identifying a page of results the server should return. Typically, this is the value
                        /// of ListBidMetricsResponse.nextPageToken returned from the previous call to the
                        /// bidMetrics.list method.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2beta1/{+filterSetName}/bidMetrics";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("filterSetName", new Google.Apis.Discovery.Parameter
                            {
                                Name = "filterSetName",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^bidders/[^/]+/accounts/[^/]+/filterSets/[^/]+$",
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

                /// <summary>Gets the BidResponseErrors resource.</summary>
                public virtual BidResponseErrorsResource BidResponseErrors { get; }

                /// <summary>The "bidResponseErrors" collection of methods.</summary>
                public class BidResponseErrorsResource
                {
                    private const string Resource = "bidResponseErrors";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public BidResponseErrorsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// List all errors that occurred in bid responses, with the number of bid responses affected for
                    /// each reason.
                    /// </summary>
                    /// <param name="filterSetName">
                    /// Name of the filter set that should be applied to the requested metrics. For example: - For a
                    /// bidder-level filter set for bidder 123: `bidders/123/filterSets/abc` - For an account-level
                    /// filter set for the buyer account representing bidder 123:
                    /// `bidders/123/accounts/123/filterSets/abc` - For an account-level filter set for the child seat
                    /// buyer account 456 whose bidder is 123: `bidders/123/accounts/456/filterSets/abc`
                    /// </param>
                    public virtual ListRequest List(string filterSetName)
                    {
                        return new ListRequest(service, filterSetName);
                    }

                    /// <summary>
                    /// List all errors that occurred in bid responses, with the number of bid responses affected for
                    /// each reason.
                    /// </summary>
                    public class ListRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.ListBidResponseErrorsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string filterSetName) : base(service)
                        {
                            FilterSetName = filterSetName;
                            InitParameters();
                        }

                        /// <summary>
                        /// Name of the filter set that should be applied to the requested metrics. For example: - For a
                        /// bidder-level filter set for bidder 123: `bidders/123/filterSets/abc` - For an account-level
                        /// filter set for the buyer account representing bidder 123:
                        /// `bidders/123/accounts/123/filterSets/abc` - For an account-level filter set for the child
                        /// seat buyer account 456 whose bidder is 123: `bidders/123/accounts/456/filterSets/abc`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filterSetName", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string FilterSetName { get; private set; }

                        /// <summary>
                        /// Requested page size. The server may return fewer results than requested. If unspecified, the
                        /// server will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A token identifying a page of results the server should return. Typically, this is the value
                        /// of ListBidResponseErrorsResponse.nextPageToken returned from the previous call to the
                        /// bidResponseErrors.list method.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2beta1/{+filterSetName}/bidResponseErrors";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("filterSetName", new Google.Apis.Discovery.Parameter
                            {
                                Name = "filterSetName",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^bidders/[^/]+/accounts/[^/]+/filterSets/[^/]+$",
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

                /// <summary>Gets the BidResponsesWithoutBids resource.</summary>
                public virtual BidResponsesWithoutBidsResource BidResponsesWithoutBids { get; }

                /// <summary>The "bidResponsesWithoutBids" collection of methods.</summary>
                public class BidResponsesWithoutBidsResource
                {
                    private const string Resource = "bidResponsesWithoutBids";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public BidResponsesWithoutBidsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// List all reasons for which bid responses were considered to have no applicable bids, with the
                    /// number of bid responses affected for each reason.
                    /// </summary>
                    /// <param name="filterSetName">
                    /// Name of the filter set that should be applied to the requested metrics. For example: - For a
                    /// bidder-level filter set for bidder 123: `bidders/123/filterSets/abc` - For an account-level
                    /// filter set for the buyer account representing bidder 123:
                    /// `bidders/123/accounts/123/filterSets/abc` - For an account-level filter set for the child seat
                    /// buyer account 456 whose bidder is 123: `bidders/123/accounts/456/filterSets/abc`
                    /// </param>
                    public virtual ListRequest List(string filterSetName)
                    {
                        return new ListRequest(service, filterSetName);
                    }

                    /// <summary>
                    /// List all reasons for which bid responses were considered to have no applicable bids, with the
                    /// number of bid responses affected for each reason.
                    /// </summary>
                    public class ListRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.ListBidResponsesWithoutBidsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string filterSetName) : base(service)
                        {
                            FilterSetName = filterSetName;
                            InitParameters();
                        }

                        /// <summary>
                        /// Name of the filter set that should be applied to the requested metrics. For example: - For a
                        /// bidder-level filter set for bidder 123: `bidders/123/filterSets/abc` - For an account-level
                        /// filter set for the buyer account representing bidder 123:
                        /// `bidders/123/accounts/123/filterSets/abc` - For an account-level filter set for the child
                        /// seat buyer account 456 whose bidder is 123: `bidders/123/accounts/456/filterSets/abc`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filterSetName", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string FilterSetName { get; private set; }

                        /// <summary>
                        /// Requested page size. The server may return fewer results than requested. If unspecified, the
                        /// server will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A token identifying a page of results the server should return. Typically, this is the value
                        /// of ListBidResponsesWithoutBidsResponse.nextPageToken returned from the previous call to the
                        /// bidResponsesWithoutBids.list method.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2beta1/{+filterSetName}/bidResponsesWithoutBids";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("filterSetName", new Google.Apis.Discovery.Parameter
                            {
                                Name = "filterSetName",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^bidders/[^/]+/accounts/[^/]+/filterSets/[^/]+$",
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

                /// <summary>Gets the FilteredBidRequests resource.</summary>
                public virtual FilteredBidRequestsResource FilteredBidRequests { get; }

                /// <summary>The "filteredBidRequests" collection of methods.</summary>
                public class FilteredBidRequestsResource
                {
                    private const string Resource = "filteredBidRequests";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public FilteredBidRequestsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// List all reasons that caused a bid request not to be sent for an impression, with the number of
                    /// bid requests not sent for each reason.
                    /// </summary>
                    /// <param name="filterSetName">
                    /// Name of the filter set that should be applied to the requested metrics. For example: - For a
                    /// bidder-level filter set for bidder 123: `bidders/123/filterSets/abc` - For an account-level
                    /// filter set for the buyer account representing bidder 123:
                    /// `bidders/123/accounts/123/filterSets/abc` - For an account-level filter set for the child seat
                    /// buyer account 456 whose bidder is 123: `bidders/123/accounts/456/filterSets/abc`
                    /// </param>
                    public virtual ListRequest List(string filterSetName)
                    {
                        return new ListRequest(service, filterSetName);
                    }

                    /// <summary>
                    /// List all reasons that caused a bid request not to be sent for an impression, with the number of
                    /// bid requests not sent for each reason.
                    /// </summary>
                    public class ListRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.ListFilteredBidRequestsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string filterSetName) : base(service)
                        {
                            FilterSetName = filterSetName;
                            InitParameters();
                        }

                        /// <summary>
                        /// Name of the filter set that should be applied to the requested metrics. For example: - For a
                        /// bidder-level filter set for bidder 123: `bidders/123/filterSets/abc` - For an account-level
                        /// filter set for the buyer account representing bidder 123:
                        /// `bidders/123/accounts/123/filterSets/abc` - For an account-level filter set for the child
                        /// seat buyer account 456 whose bidder is 123: `bidders/123/accounts/456/filterSets/abc`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filterSetName", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string FilterSetName { get; private set; }

                        /// <summary>
                        /// Requested page size. The server may return fewer results than requested. If unspecified, the
                        /// server will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A token identifying a page of results the server should return. Typically, this is the value
                        /// of ListFilteredBidRequestsResponse.nextPageToken returned from the previous call to the
                        /// filteredBidRequests.list method.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2beta1/{+filterSetName}/filteredBidRequests";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("filterSetName", new Google.Apis.Discovery.Parameter
                            {
                                Name = "filterSetName",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^bidders/[^/]+/accounts/[^/]+/filterSets/[^/]+$",
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

                /// <summary>Gets the FilteredBids resource.</summary>
                public virtual FilteredBidsResource FilteredBids { get; }

                /// <summary>The "filteredBids" collection of methods.</summary>
                public class FilteredBidsResource
                {
                    private const string Resource = "filteredBids";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public FilteredBidsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        Creatives = new CreativesResource(service);
                        Details = new DetailsResource(service);
                    }

                    /// <summary>Gets the Creatives resource.</summary>
                    public virtual CreativesResource Creatives { get; }

                    /// <summary>The "creatives" collection of methods.</summary>
                    public class CreativesResource
                    {
                        private const string Resource = "creatives";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public CreativesResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>
                        /// List all creatives associated with a specific reason for which bids were filtered, with the
                        /// number of bids filtered for each creative.
                        /// </summary>
                        /// <param name="filterSetName">
                        /// Name of the filter set that should be applied to the requested metrics. For example: - For a
                        /// bidder-level filter set for bidder 123: `bidders/123/filterSets/abc` - For an account-level
                        /// filter set for the buyer account representing bidder 123:
                        /// `bidders/123/accounts/123/filterSets/abc` - For an account-level filter set for the child
                        /// seat buyer account 456 whose bidder is 123: `bidders/123/accounts/456/filterSets/abc`
                        /// </param>
                        /// <param name="creativeStatusId">
                        /// The ID of the creative status for which to retrieve a breakdown by creative. See
                        /// [creative-status-codes](https://developers.google.com/authorized-buyers/rtb/downloads/creative-status-codes).
                        /// </param>
                        public virtual ListRequest List(string filterSetName, int creativeStatusId)
                        {
                            return new ListRequest(service, filterSetName, creativeStatusId);
                        }

                        /// <summary>
                        /// List all creatives associated with a specific reason for which bids were filtered, with the
                        /// number of bids filtered for each creative.
                        /// </summary>
                        public class ListRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.ListCreativeStatusBreakdownByCreativeResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string filterSetName, int creativeStatusId) : base(service)
                            {
                                FilterSetName = filterSetName;
                                CreativeStatusId = creativeStatusId;
                                InitParameters();
                            }

                            /// <summary>
                            /// Name of the filter set that should be applied to the requested metrics. For example: -
                            /// For a bidder-level filter set for bidder 123: `bidders/123/filterSets/abc` - For an
                            /// account-level filter set for the buyer account representing bidder 123:
                            /// `bidders/123/accounts/123/filterSets/abc` - For an account-level filter set for the
                            /// child seat buyer account 456 whose bidder is 123:
                            /// `bidders/123/accounts/456/filterSets/abc`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("filterSetName", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string FilterSetName { get; private set; }

                            /// <summary>
                            /// The ID of the creative status for which to retrieve a breakdown by creative. See
                            /// [creative-status-codes](https://developers.google.com/authorized-buyers/rtb/downloads/creative-status-codes).
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("creativeStatusId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual int CreativeStatusId { get; private set; }

                            /// <summary>
                            /// Requested page size. The server may return fewer results than requested. If unspecified,
                            /// the server will pick an appropriate default.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// A token identifying a page of results the server should return. Typically, this is the
                            /// value of ListCreativeStatusBreakdownByCreativeResponse.nextPageToken returned from the
                            /// previous call to the filteredBids.creatives.list method.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v2beta1/{+filterSetName}/filteredBids/{creativeStatusId}/creatives";

                            /// <summary>Initializes List parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("filterSetName", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "filterSetName",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^bidders/[^/]+/accounts/[^/]+/filterSets/[^/]+$",
                                });
                                RequestParameters.Add("creativeStatusId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "creativeStatusId",
                                    IsRequired = true,
                                    ParameterType = "path",
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

                    /// <summary>Gets the Details resource.</summary>
                    public virtual DetailsResource Details { get; }

                    /// <summary>The "details" collection of methods.</summary>
                    public class DetailsResource
                    {
                        private const string Resource = "details";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public DetailsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>
                        /// List all details associated with a specific reason for which bids were filtered, with the
                        /// number of bids filtered for each detail.
                        /// </summary>
                        /// <param name="filterSetName">
                        /// Name of the filter set that should be applied to the requested metrics. For example: - For a
                        /// bidder-level filter set for bidder 123: `bidders/123/filterSets/abc` - For an account-level
                        /// filter set for the buyer account representing bidder 123:
                        /// `bidders/123/accounts/123/filterSets/abc` - For an account-level filter set for the child
                        /// seat buyer account 456 whose bidder is 123: `bidders/123/accounts/456/filterSets/abc`
                        /// </param>
                        /// <param name="creativeStatusId">
                        /// The ID of the creative status for which to retrieve a breakdown by detail. See
                        /// [creative-status-codes](https://developers.google.com/authorized-buyers/rtb/downloads/creative-status-codes).
                        /// Details are only available for statuses 10, 14, 15, 17, 18, 19, 86, and 87.
                        /// </param>
                        public virtual ListRequest List(string filterSetName, int creativeStatusId)
                        {
                            return new ListRequest(service, filterSetName, creativeStatusId);
                        }

                        /// <summary>
                        /// List all details associated with a specific reason for which bids were filtered, with the
                        /// number of bids filtered for each detail.
                        /// </summary>
                        public class ListRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.ListCreativeStatusBreakdownByDetailResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string filterSetName, int creativeStatusId) : base(service)
                            {
                                FilterSetName = filterSetName;
                                CreativeStatusId = creativeStatusId;
                                InitParameters();
                            }

                            /// <summary>
                            /// Name of the filter set that should be applied to the requested metrics. For example: -
                            /// For a bidder-level filter set for bidder 123: `bidders/123/filterSets/abc` - For an
                            /// account-level filter set for the buyer account representing bidder 123:
                            /// `bidders/123/accounts/123/filterSets/abc` - For an account-level filter set for the
                            /// child seat buyer account 456 whose bidder is 123:
                            /// `bidders/123/accounts/456/filterSets/abc`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("filterSetName", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string FilterSetName { get; private set; }

                            /// <summary>
                            /// The ID of the creative status for which to retrieve a breakdown by detail. See
                            /// [creative-status-codes](https://developers.google.com/authorized-buyers/rtb/downloads/creative-status-codes).
                            /// Details are only available for statuses 10, 14, 15, 17, 18, 19, 86, and 87.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("creativeStatusId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual int CreativeStatusId { get; private set; }

                            /// <summary>
                            /// Requested page size. The server may return fewer results than requested. If unspecified,
                            /// the server will pick an appropriate default.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// A token identifying a page of results the server should return. Typically, this is the
                            /// value of ListCreativeStatusBreakdownByDetailResponse.nextPageToken returned from the
                            /// previous call to the filteredBids.details.list method.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v2beta1/{+filterSetName}/filteredBids/{creativeStatusId}/details";

                            /// <summary>Initializes List parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("filterSetName", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "filterSetName",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^bidders/[^/]+/accounts/[^/]+/filterSets/[^/]+$",
                                });
                                RequestParameters.Add("creativeStatusId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "creativeStatusId",
                                    IsRequired = true,
                                    ParameterType = "path",
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

                    /// <summary>
                    /// List all reasons for which bids were filtered, with the number of bids filtered for each reason.
                    /// </summary>
                    /// <param name="filterSetName">
                    /// Name of the filter set that should be applied to the requested metrics. For example: - For a
                    /// bidder-level filter set for bidder 123: `bidders/123/filterSets/abc` - For an account-level
                    /// filter set for the buyer account representing bidder 123:
                    /// `bidders/123/accounts/123/filterSets/abc` - For an account-level filter set for the child seat
                    /// buyer account 456 whose bidder is 123: `bidders/123/accounts/456/filterSets/abc`
                    /// </param>
                    public virtual ListRequest List(string filterSetName)
                    {
                        return new ListRequest(service, filterSetName);
                    }

                    /// <summary>
                    /// List all reasons for which bids were filtered, with the number of bids filtered for each reason.
                    /// </summary>
                    public class ListRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.ListFilteredBidsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string filterSetName) : base(service)
                        {
                            FilterSetName = filterSetName;
                            InitParameters();
                        }

                        /// <summary>
                        /// Name of the filter set that should be applied to the requested metrics. For example: - For a
                        /// bidder-level filter set for bidder 123: `bidders/123/filterSets/abc` - For an account-level
                        /// filter set for the buyer account representing bidder 123:
                        /// `bidders/123/accounts/123/filterSets/abc` - For an account-level filter set for the child
                        /// seat buyer account 456 whose bidder is 123: `bidders/123/accounts/456/filterSets/abc`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filterSetName", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string FilterSetName { get; private set; }

                        /// <summary>
                        /// Requested page size. The server may return fewer results than requested. If unspecified, the
                        /// server will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A token identifying a page of results the server should return. Typically, this is the value
                        /// of ListFilteredBidsResponse.nextPageToken returned from the previous call to the
                        /// filteredBids.list method.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2beta1/{+filterSetName}/filteredBids";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("filterSetName", new Google.Apis.Discovery.Parameter
                            {
                                Name = "filterSetName",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^bidders/[^/]+/accounts/[^/]+/filterSets/[^/]+$",
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

                /// <summary>Gets the ImpressionMetrics resource.</summary>
                public virtual ImpressionMetricsResource ImpressionMetrics { get; }

                /// <summary>The "impressionMetrics" collection of methods.</summary>
                public class ImpressionMetricsResource
                {
                    private const string Resource = "impressionMetrics";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ImpressionMetricsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Lists all metrics that are measured in terms of number of impressions.</summary>
                    /// <param name="filterSetName">
                    /// Name of the filter set that should be applied to the requested metrics. For example: - For a
                    /// bidder-level filter set for bidder 123: `bidders/123/filterSets/abc` - For an account-level
                    /// filter set for the buyer account representing bidder 123:
                    /// `bidders/123/accounts/123/filterSets/abc` - For an account-level filter set for the child seat
                    /// buyer account 456 whose bidder is 123: `bidders/123/accounts/456/filterSets/abc`
                    /// </param>
                    public virtual ListRequest List(string filterSetName)
                    {
                        return new ListRequest(service, filterSetName);
                    }

                    /// <summary>Lists all metrics that are measured in terms of number of impressions.</summary>
                    public class ListRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.ListImpressionMetricsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string filterSetName) : base(service)
                        {
                            FilterSetName = filterSetName;
                            InitParameters();
                        }

                        /// <summary>
                        /// Name of the filter set that should be applied to the requested metrics. For example: - For a
                        /// bidder-level filter set for bidder 123: `bidders/123/filterSets/abc` - For an account-level
                        /// filter set for the buyer account representing bidder 123:
                        /// `bidders/123/accounts/123/filterSets/abc` - For an account-level filter set for the child
                        /// seat buyer account 456 whose bidder is 123: `bidders/123/accounts/456/filterSets/abc`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filterSetName", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string FilterSetName { get; private set; }

                        /// <summary>
                        /// Requested page size. The server may return fewer results than requested. If unspecified, the
                        /// server will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A token identifying a page of results the server should return. Typically, this is the value
                        /// of ListImpressionMetricsResponse.nextPageToken returned from the previous call to the
                        /// impressionMetrics.list method.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2beta1/{+filterSetName}/impressionMetrics";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("filterSetName", new Google.Apis.Discovery.Parameter
                            {
                                Name = "filterSetName",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^bidders/[^/]+/accounts/[^/]+/filterSets/[^/]+$",
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

                /// <summary>Gets the LosingBids resource.</summary>
                public virtual LosingBidsResource LosingBids { get; }

                /// <summary>The "losingBids" collection of methods.</summary>
                public class LosingBidsResource
                {
                    private const string Resource = "losingBids";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public LosingBidsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// List all reasons for which bids lost in the auction, with the number of bids that lost for each
                    /// reason.
                    /// </summary>
                    /// <param name="filterSetName">
                    /// Name of the filter set that should be applied to the requested metrics. For example: - For a
                    /// bidder-level filter set for bidder 123: `bidders/123/filterSets/abc` - For an account-level
                    /// filter set for the buyer account representing bidder 123:
                    /// `bidders/123/accounts/123/filterSets/abc` - For an account-level filter set for the child seat
                    /// buyer account 456 whose bidder is 123: `bidders/123/accounts/456/filterSets/abc`
                    /// </param>
                    public virtual ListRequest List(string filterSetName)
                    {
                        return new ListRequest(service, filterSetName);
                    }

                    /// <summary>
                    /// List all reasons for which bids lost in the auction, with the number of bids that lost for each
                    /// reason.
                    /// </summary>
                    public class ListRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.ListLosingBidsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string filterSetName) : base(service)
                        {
                            FilterSetName = filterSetName;
                            InitParameters();
                        }

                        /// <summary>
                        /// Name of the filter set that should be applied to the requested metrics. For example: - For a
                        /// bidder-level filter set for bidder 123: `bidders/123/filterSets/abc` - For an account-level
                        /// filter set for the buyer account representing bidder 123:
                        /// `bidders/123/accounts/123/filterSets/abc` - For an account-level filter set for the child
                        /// seat buyer account 456 whose bidder is 123: `bidders/123/accounts/456/filterSets/abc`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filterSetName", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string FilterSetName { get; private set; }

                        /// <summary>
                        /// Requested page size. The server may return fewer results than requested. If unspecified, the
                        /// server will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A token identifying a page of results the server should return. Typically, this is the value
                        /// of ListLosingBidsResponse.nextPageToken returned from the previous call to the
                        /// losingBids.list method.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2beta1/{+filterSetName}/losingBids";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("filterSetName", new Google.Apis.Discovery.Parameter
                            {
                                Name = "filterSetName",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^bidders/[^/]+/accounts/[^/]+/filterSets/[^/]+$",
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

                /// <summary>Gets the NonBillableWinningBids resource.</summary>
                public virtual NonBillableWinningBidsResource NonBillableWinningBids { get; }

                /// <summary>The "nonBillableWinningBids" collection of methods.</summary>
                public class NonBillableWinningBidsResource
                {
                    private const string Resource = "nonBillableWinningBids";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public NonBillableWinningBidsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// List all reasons for which winning bids were not billable, with the number of bids not billed
                    /// for each reason.
                    /// </summary>
                    /// <param name="filterSetName">
                    /// Name of the filter set that should be applied to the requested metrics. For example: - For a
                    /// bidder-level filter set for bidder 123: `bidders/123/filterSets/abc` - For an account-level
                    /// filter set for the buyer account representing bidder 123:
                    /// `bidders/123/accounts/123/filterSets/abc` - For an account-level filter set for the child seat
                    /// buyer account 456 whose bidder is 123: `bidders/123/accounts/456/filterSets/abc`
                    /// </param>
                    public virtual ListRequest List(string filterSetName)
                    {
                        return new ListRequest(service, filterSetName);
                    }

                    /// <summary>
                    /// List all reasons for which winning bids were not billable, with the number of bids not billed
                    /// for each reason.
                    /// </summary>
                    public class ListRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.ListNonBillableWinningBidsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string filterSetName) : base(service)
                        {
                            FilterSetName = filterSetName;
                            InitParameters();
                        }

                        /// <summary>
                        /// Name of the filter set that should be applied to the requested metrics. For example: - For a
                        /// bidder-level filter set for bidder 123: `bidders/123/filterSets/abc` - For an account-level
                        /// filter set for the buyer account representing bidder 123:
                        /// `bidders/123/accounts/123/filterSets/abc` - For an account-level filter set for the child
                        /// seat buyer account 456 whose bidder is 123: `bidders/123/accounts/456/filterSets/abc`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filterSetName", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string FilterSetName { get; private set; }

                        /// <summary>
                        /// Requested page size. The server may return fewer results than requested. If unspecified, the
                        /// server will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A token identifying a page of results the server should return. Typically, this is the value
                        /// of ListNonBillableWinningBidsResponse.nextPageToken returned from the previous call to the
                        /// nonBillableWinningBids.list method.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2beta1/{+filterSetName}/nonBillableWinningBids";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("filterSetName", new Google.Apis.Discovery.Parameter
                            {
                                Name = "filterSetName",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^bidders/[^/]+/accounts/[^/]+/filterSets/[^/]+$",
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

                /// <summary>Creates the specified filter set for the account with the given account ID.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="ownerName">
                /// Name of the owner (bidder or account) of the filter set to be created. For example: - For a
                /// bidder-level filter set for bidder 123: `bidders/123` - For an account-level filter set for the
                /// buyer account representing bidder 123: `bidders/123/accounts/123` - For an account-level filter set
                /// for the child seat buyer account 456 whose bidder is 123: `bidders/123/accounts/456`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.AdExchangeBuyerII.v2beta1.Data.FilterSet body, string ownerName)
                {
                    return new CreateRequest(service, body, ownerName);
                }

                /// <summary>Creates the specified filter set for the account with the given account ID.</summary>
                public class CreateRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.FilterSet>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyerII.v2beta1.Data.FilterSet body, string ownerName) : base(service)
                    {
                        OwnerName = ownerName;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Name of the owner (bidder or account) of the filter set to be created. For example: - For a
                    /// bidder-level filter set for bidder 123: `bidders/123` - For an account-level filter set for the
                    /// buyer account representing bidder 123: `bidders/123/accounts/123` - For an account-level filter
                    /// set for the child seat buyer account 456 whose bidder is 123: `bidders/123/accounts/456`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("ownerName", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string OwnerName { get; private set; }

                    /// <summary>
                    /// Whether the filter set is transient, or should be persisted indefinitely. By default, filter
                    /// sets are not transient. If transient, it will be available for at least 1 hour after creation.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("isTransient", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> IsTransient { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AdExchangeBuyerII.v2beta1.Data.FilterSet Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2beta1/{+ownerName}/filterSets";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("ownerName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "ownerName",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^bidders/[^/]+/accounts/[^/]+$",
                        });
                        RequestParameters.Add("isTransient", new Google.Apis.Discovery.Parameter
                        {
                            Name = "isTransient",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes the requested filter set from the account with the given account ID.</summary>
                /// <param name="name">
                /// Full name of the resource to delete. For example: - For a bidder-level filter set for bidder 123:
                /// `bidders/123/filterSets/abc` - For an account-level filter set for the buyer account representing
                /// bidder 123: `bidders/123/accounts/123/filterSets/abc` - For an account-level filter set for the
                /// child seat buyer account 456 whose bidder is 123: `bidders/123/accounts/456/filterSets/abc`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes the requested filter set from the account with the given account ID.</summary>
                public class DeleteRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Full name of the resource to delete. For example: - For a bidder-level filter set for bidder
                    /// 123: `bidders/123/filterSets/abc` - For an account-level filter set for the buyer account
                    /// representing bidder 123: `bidders/123/accounts/123/filterSets/abc` - For an account-level filter
                    /// set for the child seat buyer account 456 whose bidder is 123:
                    /// `bidders/123/accounts/456/filterSets/abc`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2beta1/{+name}";

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
                            Pattern = @"^bidders/[^/]+/accounts/[^/]+/filterSets/[^/]+$",
                        });
                    }
                }

                /// <summary>Retrieves the requested filter set for the account with the given account ID.</summary>
                /// <param name="name">
                /// Full name of the resource being requested. For example: - For a bidder-level filter set for bidder
                /// 123: `bidders/123/filterSets/abc` - For an account-level filter set for the buyer account
                /// representing bidder 123: `bidders/123/accounts/123/filterSets/abc` - For an account-level filter set
                /// for the child seat buyer account 456 whose bidder is 123: `bidders/123/accounts/456/filterSets/abc`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Retrieves the requested filter set for the account with the given account ID.</summary>
                public class GetRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.FilterSet>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Full name of the resource being requested. For example: - For a bidder-level filter set for
                    /// bidder 123: `bidders/123/filterSets/abc` - For an account-level filter set for the buyer account
                    /// representing bidder 123: `bidders/123/accounts/123/filterSets/abc` - For an account-level filter
                    /// set for the child seat buyer account 456 whose bidder is 123:
                    /// `bidders/123/accounts/456/filterSets/abc`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2beta1/{+name}";

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
                            Pattern = @"^bidders/[^/]+/accounts/[^/]+/filterSets/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists all filter sets for the account with the given account ID.</summary>
                /// <param name="ownerName">
                /// Name of the owner (bidder or account) of the filter sets to be listed. For example: - For a
                /// bidder-level filter set for bidder 123: `bidders/123` - For an account-level filter set for the
                /// buyer account representing bidder 123: `bidders/123/accounts/123` - For an account-level filter set
                /// for the child seat buyer account 456 whose bidder is 123: `bidders/123/accounts/456`
                /// </param>
                public virtual ListRequest List(string ownerName)
                {
                    return new ListRequest(service, ownerName);
                }

                /// <summary>Lists all filter sets for the account with the given account ID.</summary>
                public class ListRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.ListFilterSetsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string ownerName) : base(service)
                    {
                        OwnerName = ownerName;
                        InitParameters();
                    }

                    /// <summary>
                    /// Name of the owner (bidder or account) of the filter sets to be listed. For example: - For a
                    /// bidder-level filter set for bidder 123: `bidders/123` - For an account-level filter set for the
                    /// buyer account representing bidder 123: `bidders/123/accounts/123` - For an account-level filter
                    /// set for the child seat buyer account 456 whose bidder is 123: `bidders/123/accounts/456`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("ownerName", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string OwnerName { get; private set; }

                    /// <summary>
                    /// Requested page size. The server may return fewer results than requested. If unspecified, the
                    /// server will pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A token identifying a page of results the server should return. Typically, this is the value of
                    /// ListFilterSetsResponse.nextPageToken returned from the previous call to the
                    /// accounts.filterSets.list method.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2beta1/{+ownerName}/filterSets";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("ownerName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "ownerName",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^bidders/[^/]+/accounts/[^/]+$",
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

        /// <summary>Gets the FilterSets resource.</summary>
        public virtual FilterSetsResource FilterSets { get; }

        /// <summary>The "filterSets" collection of methods.</summary>
        public class FilterSetsResource
        {
            private const string Resource = "filterSets";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public FilterSetsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                BidMetrics = new BidMetricsResource(service);
                BidResponseErrors = new BidResponseErrorsResource(service);
                BidResponsesWithoutBids = new BidResponsesWithoutBidsResource(service);
                FilteredBidRequests = new FilteredBidRequestsResource(service);
                FilteredBids = new FilteredBidsResource(service);
                ImpressionMetrics = new ImpressionMetricsResource(service);
                LosingBids = new LosingBidsResource(service);
                NonBillableWinningBids = new NonBillableWinningBidsResource(service);
            }

            /// <summary>Gets the BidMetrics resource.</summary>
            public virtual BidMetricsResource BidMetrics { get; }

            /// <summary>The "bidMetrics" collection of methods.</summary>
            public class BidMetricsResource
            {
                private const string Resource = "bidMetrics";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public BidMetricsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Lists all metrics that are measured in terms of number of bids.</summary>
                /// <param name="filterSetName">
                /// Name of the filter set that should be applied to the requested metrics. For example: - For a
                /// bidder-level filter set for bidder 123: `bidders/123/filterSets/abc` - For an account-level filter
                /// set for the buyer account representing bidder 123: `bidders/123/accounts/123/filterSets/abc` - For
                /// an account-level filter set for the child seat buyer account 456 whose bidder is 123:
                /// `bidders/123/accounts/456/filterSets/abc`
                /// </param>
                public virtual ListRequest List(string filterSetName)
                {
                    return new ListRequest(service, filterSetName);
                }

                /// <summary>Lists all metrics that are measured in terms of number of bids.</summary>
                public class ListRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.ListBidMetricsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string filterSetName) : base(service)
                    {
                        FilterSetName = filterSetName;
                        InitParameters();
                    }

                    /// <summary>
                    /// Name of the filter set that should be applied to the requested metrics. For example: - For a
                    /// bidder-level filter set for bidder 123: `bidders/123/filterSets/abc` - For an account-level
                    /// filter set for the buyer account representing bidder 123:
                    /// `bidders/123/accounts/123/filterSets/abc` - For an account-level filter set for the child seat
                    /// buyer account 456 whose bidder is 123: `bidders/123/accounts/456/filterSets/abc`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filterSetName", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string FilterSetName { get; private set; }

                    /// <summary>
                    /// Requested page size. The server may return fewer results than requested. If unspecified, the
                    /// server will pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A token identifying a page of results the server should return. Typically, this is the value of
                    /// ListBidMetricsResponse.nextPageToken returned from the previous call to the bidMetrics.list
                    /// method.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2beta1/{+filterSetName}/bidMetrics";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("filterSetName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filterSetName",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^bidders/[^/]+/filterSets/[^/]+$",
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

            /// <summary>Gets the BidResponseErrors resource.</summary>
            public virtual BidResponseErrorsResource BidResponseErrors { get; }

            /// <summary>The "bidResponseErrors" collection of methods.</summary>
            public class BidResponseErrorsResource
            {
                private const string Resource = "bidResponseErrors";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public BidResponseErrorsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// List all errors that occurred in bid responses, with the number of bid responses affected for each
                /// reason.
                /// </summary>
                /// <param name="filterSetName">
                /// Name of the filter set that should be applied to the requested metrics. For example: - For a
                /// bidder-level filter set for bidder 123: `bidders/123/filterSets/abc` - For an account-level filter
                /// set for the buyer account representing bidder 123: `bidders/123/accounts/123/filterSets/abc` - For
                /// an account-level filter set for the child seat buyer account 456 whose bidder is 123:
                /// `bidders/123/accounts/456/filterSets/abc`
                /// </param>
                public virtual ListRequest List(string filterSetName)
                {
                    return new ListRequest(service, filterSetName);
                }

                /// <summary>
                /// List all errors that occurred in bid responses, with the number of bid responses affected for each
                /// reason.
                /// </summary>
                public class ListRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.ListBidResponseErrorsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string filterSetName) : base(service)
                    {
                        FilterSetName = filterSetName;
                        InitParameters();
                    }

                    /// <summary>
                    /// Name of the filter set that should be applied to the requested metrics. For example: - For a
                    /// bidder-level filter set for bidder 123: `bidders/123/filterSets/abc` - For an account-level
                    /// filter set for the buyer account representing bidder 123:
                    /// `bidders/123/accounts/123/filterSets/abc` - For an account-level filter set for the child seat
                    /// buyer account 456 whose bidder is 123: `bidders/123/accounts/456/filterSets/abc`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filterSetName", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string FilterSetName { get; private set; }

                    /// <summary>
                    /// Requested page size. The server may return fewer results than requested. If unspecified, the
                    /// server will pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A token identifying a page of results the server should return. Typically, this is the value of
                    /// ListBidResponseErrorsResponse.nextPageToken returned from the previous call to the
                    /// bidResponseErrors.list method.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2beta1/{+filterSetName}/bidResponseErrors";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("filterSetName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filterSetName",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^bidders/[^/]+/filterSets/[^/]+$",
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

            /// <summary>Gets the BidResponsesWithoutBids resource.</summary>
            public virtual BidResponsesWithoutBidsResource BidResponsesWithoutBids { get; }

            /// <summary>The "bidResponsesWithoutBids" collection of methods.</summary>
            public class BidResponsesWithoutBidsResource
            {
                private const string Resource = "bidResponsesWithoutBids";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public BidResponsesWithoutBidsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// List all reasons for which bid responses were considered to have no applicable bids, with the number
                /// of bid responses affected for each reason.
                /// </summary>
                /// <param name="filterSetName">
                /// Name of the filter set that should be applied to the requested metrics. For example: - For a
                /// bidder-level filter set for bidder 123: `bidders/123/filterSets/abc` - For an account-level filter
                /// set for the buyer account representing bidder 123: `bidders/123/accounts/123/filterSets/abc` - For
                /// an account-level filter set for the child seat buyer account 456 whose bidder is 123:
                /// `bidders/123/accounts/456/filterSets/abc`
                /// </param>
                public virtual ListRequest List(string filterSetName)
                {
                    return new ListRequest(service, filterSetName);
                }

                /// <summary>
                /// List all reasons for which bid responses were considered to have no applicable bids, with the number
                /// of bid responses affected for each reason.
                /// </summary>
                public class ListRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.ListBidResponsesWithoutBidsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string filterSetName) : base(service)
                    {
                        FilterSetName = filterSetName;
                        InitParameters();
                    }

                    /// <summary>
                    /// Name of the filter set that should be applied to the requested metrics. For example: - For a
                    /// bidder-level filter set for bidder 123: `bidders/123/filterSets/abc` - For an account-level
                    /// filter set for the buyer account representing bidder 123:
                    /// `bidders/123/accounts/123/filterSets/abc` - For an account-level filter set for the child seat
                    /// buyer account 456 whose bidder is 123: `bidders/123/accounts/456/filterSets/abc`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filterSetName", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string FilterSetName { get; private set; }

                    /// <summary>
                    /// Requested page size. The server may return fewer results than requested. If unspecified, the
                    /// server will pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A token identifying a page of results the server should return. Typically, this is the value of
                    /// ListBidResponsesWithoutBidsResponse.nextPageToken returned from the previous call to the
                    /// bidResponsesWithoutBids.list method.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2beta1/{+filterSetName}/bidResponsesWithoutBids";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("filterSetName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filterSetName",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^bidders/[^/]+/filterSets/[^/]+$",
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

            /// <summary>Gets the FilteredBidRequests resource.</summary>
            public virtual FilteredBidRequestsResource FilteredBidRequests { get; }

            /// <summary>The "filteredBidRequests" collection of methods.</summary>
            public class FilteredBidRequestsResource
            {
                private const string Resource = "filteredBidRequests";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public FilteredBidRequestsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// List all reasons that caused a bid request not to be sent for an impression, with the number of bid
                /// requests not sent for each reason.
                /// </summary>
                /// <param name="filterSetName">
                /// Name of the filter set that should be applied to the requested metrics. For example: - For a
                /// bidder-level filter set for bidder 123: `bidders/123/filterSets/abc` - For an account-level filter
                /// set for the buyer account representing bidder 123: `bidders/123/accounts/123/filterSets/abc` - For
                /// an account-level filter set for the child seat buyer account 456 whose bidder is 123:
                /// `bidders/123/accounts/456/filterSets/abc`
                /// </param>
                public virtual ListRequest List(string filterSetName)
                {
                    return new ListRequest(service, filterSetName);
                }

                /// <summary>
                /// List all reasons that caused a bid request not to be sent for an impression, with the number of bid
                /// requests not sent for each reason.
                /// </summary>
                public class ListRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.ListFilteredBidRequestsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string filterSetName) : base(service)
                    {
                        FilterSetName = filterSetName;
                        InitParameters();
                    }

                    /// <summary>
                    /// Name of the filter set that should be applied to the requested metrics. For example: - For a
                    /// bidder-level filter set for bidder 123: `bidders/123/filterSets/abc` - For an account-level
                    /// filter set for the buyer account representing bidder 123:
                    /// `bidders/123/accounts/123/filterSets/abc` - For an account-level filter set for the child seat
                    /// buyer account 456 whose bidder is 123: `bidders/123/accounts/456/filterSets/abc`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filterSetName", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string FilterSetName { get; private set; }

                    /// <summary>
                    /// Requested page size. The server may return fewer results than requested. If unspecified, the
                    /// server will pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A token identifying a page of results the server should return. Typically, this is the value of
                    /// ListFilteredBidRequestsResponse.nextPageToken returned from the previous call to the
                    /// filteredBidRequests.list method.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2beta1/{+filterSetName}/filteredBidRequests";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("filterSetName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filterSetName",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^bidders/[^/]+/filterSets/[^/]+$",
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

            /// <summary>Gets the FilteredBids resource.</summary>
            public virtual FilteredBidsResource FilteredBids { get; }

            /// <summary>The "filteredBids" collection of methods.</summary>
            public class FilteredBidsResource
            {
                private const string Resource = "filteredBids";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public FilteredBidsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Creatives = new CreativesResource(service);
                    Details = new DetailsResource(service);
                }

                /// <summary>Gets the Creatives resource.</summary>
                public virtual CreativesResource Creatives { get; }

                /// <summary>The "creatives" collection of methods.</summary>
                public class CreativesResource
                {
                    private const string Resource = "creatives";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public CreativesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// List all creatives associated with a specific reason for which bids were filtered, with the
                    /// number of bids filtered for each creative.
                    /// </summary>
                    /// <param name="filterSetName">
                    /// Name of the filter set that should be applied to the requested metrics. For example: - For a
                    /// bidder-level filter set for bidder 123: `bidders/123/filterSets/abc` - For an account-level
                    /// filter set for the buyer account representing bidder 123:
                    /// `bidders/123/accounts/123/filterSets/abc` - For an account-level filter set for the child seat
                    /// buyer account 456 whose bidder is 123: `bidders/123/accounts/456/filterSets/abc`
                    /// </param>
                    /// <param name="creativeStatusId">
                    /// The ID of the creative status for which to retrieve a breakdown by creative. See
                    /// [creative-status-codes](https://developers.google.com/authorized-buyers/rtb/downloads/creative-status-codes).
                    /// </param>
                    public virtual ListRequest List(string filterSetName, int creativeStatusId)
                    {
                        return new ListRequest(service, filterSetName, creativeStatusId);
                    }

                    /// <summary>
                    /// List all creatives associated with a specific reason for which bids were filtered, with the
                    /// number of bids filtered for each creative.
                    /// </summary>
                    public class ListRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.ListCreativeStatusBreakdownByCreativeResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string filterSetName, int creativeStatusId) : base(service)
                        {
                            FilterSetName = filterSetName;
                            CreativeStatusId = creativeStatusId;
                            InitParameters();
                        }

                        /// <summary>
                        /// Name of the filter set that should be applied to the requested metrics. For example: - For a
                        /// bidder-level filter set for bidder 123: `bidders/123/filterSets/abc` - For an account-level
                        /// filter set for the buyer account representing bidder 123:
                        /// `bidders/123/accounts/123/filterSets/abc` - For an account-level filter set for the child
                        /// seat buyer account 456 whose bidder is 123: `bidders/123/accounts/456/filterSets/abc`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filterSetName", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string FilterSetName { get; private set; }

                        /// <summary>
                        /// The ID of the creative status for which to retrieve a breakdown by creative. See
                        /// [creative-status-codes](https://developers.google.com/authorized-buyers/rtb/downloads/creative-status-codes).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("creativeStatusId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual int CreativeStatusId { get; private set; }

                        /// <summary>
                        /// Requested page size. The server may return fewer results than requested. If unspecified, the
                        /// server will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A token identifying a page of results the server should return. Typically, this is the value
                        /// of ListCreativeStatusBreakdownByCreativeResponse.nextPageToken returned from the previous
                        /// call to the filteredBids.creatives.list method.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2beta1/{+filterSetName}/filteredBids/{creativeStatusId}/creatives";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("filterSetName", new Google.Apis.Discovery.Parameter
                            {
                                Name = "filterSetName",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^bidders/[^/]+/filterSets/[^/]+$",
                            });
                            RequestParameters.Add("creativeStatusId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "creativeStatusId",
                                IsRequired = true,
                                ParameterType = "path",
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

                /// <summary>Gets the Details resource.</summary>
                public virtual DetailsResource Details { get; }

                /// <summary>The "details" collection of methods.</summary>
                public class DetailsResource
                {
                    private const string Resource = "details";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public DetailsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// List all details associated with a specific reason for which bids were filtered, with the number
                    /// of bids filtered for each detail.
                    /// </summary>
                    /// <param name="filterSetName">
                    /// Name of the filter set that should be applied to the requested metrics. For example: - For a
                    /// bidder-level filter set for bidder 123: `bidders/123/filterSets/abc` - For an account-level
                    /// filter set for the buyer account representing bidder 123:
                    /// `bidders/123/accounts/123/filterSets/abc` - For an account-level filter set for the child seat
                    /// buyer account 456 whose bidder is 123: `bidders/123/accounts/456/filterSets/abc`
                    /// </param>
                    /// <param name="creativeStatusId">
                    /// The ID of the creative status for which to retrieve a breakdown by detail. See
                    /// [creative-status-codes](https://developers.google.com/authorized-buyers/rtb/downloads/creative-status-codes).
                    /// Details are only available for statuses 10, 14, 15, 17, 18, 19, 86, and 87.
                    /// </param>
                    public virtual ListRequest List(string filterSetName, int creativeStatusId)
                    {
                        return new ListRequest(service, filterSetName, creativeStatusId);
                    }

                    /// <summary>
                    /// List all details associated with a specific reason for which bids were filtered, with the number
                    /// of bids filtered for each detail.
                    /// </summary>
                    public class ListRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.ListCreativeStatusBreakdownByDetailResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string filterSetName, int creativeStatusId) : base(service)
                        {
                            FilterSetName = filterSetName;
                            CreativeStatusId = creativeStatusId;
                            InitParameters();
                        }

                        /// <summary>
                        /// Name of the filter set that should be applied to the requested metrics. For example: - For a
                        /// bidder-level filter set for bidder 123: `bidders/123/filterSets/abc` - For an account-level
                        /// filter set for the buyer account representing bidder 123:
                        /// `bidders/123/accounts/123/filterSets/abc` - For an account-level filter set for the child
                        /// seat buyer account 456 whose bidder is 123: `bidders/123/accounts/456/filterSets/abc`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filterSetName", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string FilterSetName { get; private set; }

                        /// <summary>
                        /// The ID of the creative status for which to retrieve a breakdown by detail. See
                        /// [creative-status-codes](https://developers.google.com/authorized-buyers/rtb/downloads/creative-status-codes).
                        /// Details are only available for statuses 10, 14, 15, 17, 18, 19, 86, and 87.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("creativeStatusId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual int CreativeStatusId { get; private set; }

                        /// <summary>
                        /// Requested page size. The server may return fewer results than requested. If unspecified, the
                        /// server will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A token identifying a page of results the server should return. Typically, this is the value
                        /// of ListCreativeStatusBreakdownByDetailResponse.nextPageToken returned from the previous call
                        /// to the filteredBids.details.list method.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2beta1/{+filterSetName}/filteredBids/{creativeStatusId}/details";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("filterSetName", new Google.Apis.Discovery.Parameter
                            {
                                Name = "filterSetName",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^bidders/[^/]+/filterSets/[^/]+$",
                            });
                            RequestParameters.Add("creativeStatusId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "creativeStatusId",
                                IsRequired = true,
                                ParameterType = "path",
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

                /// <summary>
                /// List all reasons for which bids were filtered, with the number of bids filtered for each reason.
                /// </summary>
                /// <param name="filterSetName">
                /// Name of the filter set that should be applied to the requested metrics. For example: - For a
                /// bidder-level filter set for bidder 123: `bidders/123/filterSets/abc` - For an account-level filter
                /// set for the buyer account representing bidder 123: `bidders/123/accounts/123/filterSets/abc` - For
                /// an account-level filter set for the child seat buyer account 456 whose bidder is 123:
                /// `bidders/123/accounts/456/filterSets/abc`
                /// </param>
                public virtual ListRequest List(string filterSetName)
                {
                    return new ListRequest(service, filterSetName);
                }

                /// <summary>
                /// List all reasons for which bids were filtered, with the number of bids filtered for each reason.
                /// </summary>
                public class ListRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.ListFilteredBidsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string filterSetName) : base(service)
                    {
                        FilterSetName = filterSetName;
                        InitParameters();
                    }

                    /// <summary>
                    /// Name of the filter set that should be applied to the requested metrics. For example: - For a
                    /// bidder-level filter set for bidder 123: `bidders/123/filterSets/abc` - For an account-level
                    /// filter set for the buyer account representing bidder 123:
                    /// `bidders/123/accounts/123/filterSets/abc` - For an account-level filter set for the child seat
                    /// buyer account 456 whose bidder is 123: `bidders/123/accounts/456/filterSets/abc`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filterSetName", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string FilterSetName { get; private set; }

                    /// <summary>
                    /// Requested page size. The server may return fewer results than requested. If unspecified, the
                    /// server will pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A token identifying a page of results the server should return. Typically, this is the value of
                    /// ListFilteredBidsResponse.nextPageToken returned from the previous call to the filteredBids.list
                    /// method.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2beta1/{+filterSetName}/filteredBids";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("filterSetName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filterSetName",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^bidders/[^/]+/filterSets/[^/]+$",
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

            /// <summary>Gets the ImpressionMetrics resource.</summary>
            public virtual ImpressionMetricsResource ImpressionMetrics { get; }

            /// <summary>The "impressionMetrics" collection of methods.</summary>
            public class ImpressionMetricsResource
            {
                private const string Resource = "impressionMetrics";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ImpressionMetricsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Lists all metrics that are measured in terms of number of impressions.</summary>
                /// <param name="filterSetName">
                /// Name of the filter set that should be applied to the requested metrics. For example: - For a
                /// bidder-level filter set for bidder 123: `bidders/123/filterSets/abc` - For an account-level filter
                /// set for the buyer account representing bidder 123: `bidders/123/accounts/123/filterSets/abc` - For
                /// an account-level filter set for the child seat buyer account 456 whose bidder is 123:
                /// `bidders/123/accounts/456/filterSets/abc`
                /// </param>
                public virtual ListRequest List(string filterSetName)
                {
                    return new ListRequest(service, filterSetName);
                }

                /// <summary>Lists all metrics that are measured in terms of number of impressions.</summary>
                public class ListRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.ListImpressionMetricsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string filterSetName) : base(service)
                    {
                        FilterSetName = filterSetName;
                        InitParameters();
                    }

                    /// <summary>
                    /// Name of the filter set that should be applied to the requested metrics. For example: - For a
                    /// bidder-level filter set for bidder 123: `bidders/123/filterSets/abc` - For an account-level
                    /// filter set for the buyer account representing bidder 123:
                    /// `bidders/123/accounts/123/filterSets/abc` - For an account-level filter set for the child seat
                    /// buyer account 456 whose bidder is 123: `bidders/123/accounts/456/filterSets/abc`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filterSetName", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string FilterSetName { get; private set; }

                    /// <summary>
                    /// Requested page size. The server may return fewer results than requested. If unspecified, the
                    /// server will pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A token identifying a page of results the server should return. Typically, this is the value of
                    /// ListImpressionMetricsResponse.nextPageToken returned from the previous call to the
                    /// impressionMetrics.list method.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2beta1/{+filterSetName}/impressionMetrics";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("filterSetName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filterSetName",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^bidders/[^/]+/filterSets/[^/]+$",
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

            /// <summary>Gets the LosingBids resource.</summary>
            public virtual LosingBidsResource LosingBids { get; }

            /// <summary>The "losingBids" collection of methods.</summary>
            public class LosingBidsResource
            {
                private const string Resource = "losingBids";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public LosingBidsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// List all reasons for which bids lost in the auction, with the number of bids that lost for each
                /// reason.
                /// </summary>
                /// <param name="filterSetName">
                /// Name of the filter set that should be applied to the requested metrics. For example: - For a
                /// bidder-level filter set for bidder 123: `bidders/123/filterSets/abc` - For an account-level filter
                /// set for the buyer account representing bidder 123: `bidders/123/accounts/123/filterSets/abc` - For
                /// an account-level filter set for the child seat buyer account 456 whose bidder is 123:
                /// `bidders/123/accounts/456/filterSets/abc`
                /// </param>
                public virtual ListRequest List(string filterSetName)
                {
                    return new ListRequest(service, filterSetName);
                }

                /// <summary>
                /// List all reasons for which bids lost in the auction, with the number of bids that lost for each
                /// reason.
                /// </summary>
                public class ListRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.ListLosingBidsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string filterSetName) : base(service)
                    {
                        FilterSetName = filterSetName;
                        InitParameters();
                    }

                    /// <summary>
                    /// Name of the filter set that should be applied to the requested metrics. For example: - For a
                    /// bidder-level filter set for bidder 123: `bidders/123/filterSets/abc` - For an account-level
                    /// filter set for the buyer account representing bidder 123:
                    /// `bidders/123/accounts/123/filterSets/abc` - For an account-level filter set for the child seat
                    /// buyer account 456 whose bidder is 123: `bidders/123/accounts/456/filterSets/abc`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filterSetName", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string FilterSetName { get; private set; }

                    /// <summary>
                    /// Requested page size. The server may return fewer results than requested. If unspecified, the
                    /// server will pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A token identifying a page of results the server should return. Typically, this is the value of
                    /// ListLosingBidsResponse.nextPageToken returned from the previous call to the losingBids.list
                    /// method.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2beta1/{+filterSetName}/losingBids";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("filterSetName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filterSetName",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^bidders/[^/]+/filterSets/[^/]+$",
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

            /// <summary>Gets the NonBillableWinningBids resource.</summary>
            public virtual NonBillableWinningBidsResource NonBillableWinningBids { get; }

            /// <summary>The "nonBillableWinningBids" collection of methods.</summary>
            public class NonBillableWinningBidsResource
            {
                private const string Resource = "nonBillableWinningBids";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public NonBillableWinningBidsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// List all reasons for which winning bids were not billable, with the number of bids not billed for
                /// each reason.
                /// </summary>
                /// <param name="filterSetName">
                /// Name of the filter set that should be applied to the requested metrics. For example: - For a
                /// bidder-level filter set for bidder 123: `bidders/123/filterSets/abc` - For an account-level filter
                /// set for the buyer account representing bidder 123: `bidders/123/accounts/123/filterSets/abc` - For
                /// an account-level filter set for the child seat buyer account 456 whose bidder is 123:
                /// `bidders/123/accounts/456/filterSets/abc`
                /// </param>
                public virtual ListRequest List(string filterSetName)
                {
                    return new ListRequest(service, filterSetName);
                }

                /// <summary>
                /// List all reasons for which winning bids were not billable, with the number of bids not billed for
                /// each reason.
                /// </summary>
                public class ListRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.ListNonBillableWinningBidsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string filterSetName) : base(service)
                    {
                        FilterSetName = filterSetName;
                        InitParameters();
                    }

                    /// <summary>
                    /// Name of the filter set that should be applied to the requested metrics. For example: - For a
                    /// bidder-level filter set for bidder 123: `bidders/123/filterSets/abc` - For an account-level
                    /// filter set for the buyer account representing bidder 123:
                    /// `bidders/123/accounts/123/filterSets/abc` - For an account-level filter set for the child seat
                    /// buyer account 456 whose bidder is 123: `bidders/123/accounts/456/filterSets/abc`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filterSetName", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string FilterSetName { get; private set; }

                    /// <summary>
                    /// Requested page size. The server may return fewer results than requested. If unspecified, the
                    /// server will pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A token identifying a page of results the server should return. Typically, this is the value of
                    /// ListNonBillableWinningBidsResponse.nextPageToken returned from the previous call to the
                    /// nonBillableWinningBids.list method.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2beta1/{+filterSetName}/nonBillableWinningBids";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("filterSetName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filterSetName",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^bidders/[^/]+/filterSets/[^/]+$",
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

            /// <summary>Creates the specified filter set for the account with the given account ID.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="ownerName">
            /// Name of the owner (bidder or account) of the filter set to be created. For example: - For a bidder-level
            /// filter set for bidder 123: `bidders/123` - For an account-level filter set for the buyer account
            /// representing bidder 123: `bidders/123/accounts/123` - For an account-level filter set for the child seat
            /// buyer account 456 whose bidder is 123: `bidders/123/accounts/456`
            /// </param>
            public virtual CreateRequest Create(Google.Apis.AdExchangeBuyerII.v2beta1.Data.FilterSet body, string ownerName)
            {
                return new CreateRequest(service, body, ownerName);
            }

            /// <summary>Creates the specified filter set for the account with the given account ID.</summary>
            public class CreateRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.FilterSet>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyerII.v2beta1.Data.FilterSet body, string ownerName) : base(service)
                {
                    OwnerName = ownerName;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Name of the owner (bidder or account) of the filter set to be created. For example: - For a
                /// bidder-level filter set for bidder 123: `bidders/123` - For an account-level filter set for the
                /// buyer account representing bidder 123: `bidders/123/accounts/123` - For an account-level filter set
                /// for the child seat buyer account 456 whose bidder is 123: `bidders/123/accounts/456`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("ownerName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string OwnerName { get; private set; }

                /// <summary>
                /// Whether the filter set is transient, or should be persisted indefinitely. By default, filter sets
                /// are not transient. If transient, it will be available for at least 1 hour after creation.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("isTransient", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> IsTransient { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AdExchangeBuyerII.v2beta1.Data.FilterSet Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta1/{+ownerName}/filterSets";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("ownerName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "ownerName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^bidders/[^/]+$",
                    });
                    RequestParameters.Add("isTransient", new Google.Apis.Discovery.Parameter
                    {
                        Name = "isTransient",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Deletes the requested filter set from the account with the given account ID.</summary>
            /// <param name="name">
            /// Full name of the resource to delete. For example: - For a bidder-level filter set for bidder 123:
            /// `bidders/123/filterSets/abc` - For an account-level filter set for the buyer account representing bidder
            /// 123: `bidders/123/accounts/123/filterSets/abc` - For an account-level filter set for the child seat
            /// buyer account 456 whose bidder is 123: `bidders/123/accounts/456/filterSets/abc`
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes the requested filter set from the account with the given account ID.</summary>
            public class DeleteRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Full name of the resource to delete. For example: - For a bidder-level filter set for bidder 123:
                /// `bidders/123/filterSets/abc` - For an account-level filter set for the buyer account representing
                /// bidder 123: `bidders/123/accounts/123/filterSets/abc` - For an account-level filter set for the
                /// child seat buyer account 456 whose bidder is 123: `bidders/123/accounts/456/filterSets/abc`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta1/{+name}";

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
                        Pattern = @"^bidders/[^/]+/filterSets/[^/]+$",
                    });
                }
            }

            /// <summary>Retrieves the requested filter set for the account with the given account ID.</summary>
            /// <param name="name">
            /// Full name of the resource being requested. For example: - For a bidder-level filter set for bidder 123:
            /// `bidders/123/filterSets/abc` - For an account-level filter set for the buyer account representing bidder
            /// 123: `bidders/123/accounts/123/filterSets/abc` - For an account-level filter set for the child seat
            /// buyer account 456 whose bidder is 123: `bidders/123/accounts/456/filterSets/abc`
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Retrieves the requested filter set for the account with the given account ID.</summary>
            public class GetRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.FilterSet>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Full name of the resource being requested. For example: - For a bidder-level filter set for bidder
                /// 123: `bidders/123/filterSets/abc` - For an account-level filter set for the buyer account
                /// representing bidder 123: `bidders/123/accounts/123/filterSets/abc` - For an account-level filter set
                /// for the child seat buyer account 456 whose bidder is 123: `bidders/123/accounts/456/filterSets/abc`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta1/{+name}";

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
                        Pattern = @"^bidders/[^/]+/filterSets/[^/]+$",
                    });
                }
            }

            /// <summary>Lists all filter sets for the account with the given account ID.</summary>
            /// <param name="ownerName">
            /// Name of the owner (bidder or account) of the filter sets to be listed. For example: - For a bidder-level
            /// filter set for bidder 123: `bidders/123` - For an account-level filter set for the buyer account
            /// representing bidder 123: `bidders/123/accounts/123` - For an account-level filter set for the child seat
            /// buyer account 456 whose bidder is 123: `bidders/123/accounts/456`
            /// </param>
            public virtual ListRequest List(string ownerName)
            {
                return new ListRequest(service, ownerName);
            }

            /// <summary>Lists all filter sets for the account with the given account ID.</summary>
            public class ListRequest : AdExchangeBuyerIIBaseServiceRequest<Google.Apis.AdExchangeBuyerII.v2beta1.Data.ListFilterSetsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string ownerName) : base(service)
                {
                    OwnerName = ownerName;
                    InitParameters();
                }

                /// <summary>
                /// Name of the owner (bidder or account) of the filter sets to be listed. For example: - For a
                /// bidder-level filter set for bidder 123: `bidders/123` - For an account-level filter set for the
                /// buyer account representing bidder 123: `bidders/123/accounts/123` - For an account-level filter set
                /// for the child seat buyer account 456 whose bidder is 123: `bidders/123/accounts/456`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("ownerName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string OwnerName { get; private set; }

                /// <summary>
                /// Requested page size. The server may return fewer results than requested. If unspecified, the server
                /// will pick an appropriate default.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A token identifying a page of results the server should return. Typically, this is the value of
                /// ListFilterSetsResponse.nextPageToken returned from the previous call to the accounts.filterSets.list
                /// method.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta1/{+ownerName}/filterSets";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("ownerName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "ownerName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^bidders/[^/]+$",
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
namespace Google.Apis.AdExchangeBuyerII.v2beta1.Data
{
    /// <summary>
    /// An absolute date range, specified by its start date and end date. The supported range of dates begins 30 days
    /// before today and ends today. Validity checked upon filter set creation. If a filter set with an absolute date
    /// range is run at a later date more than 30 days after start_date, it will fail.
    /// </summary>
    public class AbsoluteDateRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The end date of the range (inclusive). Must be within the 30 days leading up to current date, and must be
        /// equal to or after start_date.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual Date EndDate { get; set; }

        /// <summary>
        /// The start date of the range (inclusive). Must be within the 30 days leading up to current date, and must be
        /// equal to or before end_date.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual Date StartDate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to accept a proposal.</summary>
    public class AcceptProposalRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The last known client revision number of the proposal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proposalRevision")]
        public virtual System.Nullable<long> ProposalRevision { get; set; }

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

        /// <summary>The size type of the ad slot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeType")]
        public virtual string SizeType { get; set; }

        /// <summary>
        /// The width of the ad slot in pixels. This field will be present only when size type is `PIXEL`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<long> Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detected ad technology provider information.</summary>
    public class AdTechnologyProviders : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The detected ad technology provider IDs for this creative. See
        /// https://storage.googleapis.com/adx-rtb-dictionaries/providers.csv for mapping of provider ID to provided
        /// name, a privacy policy URL, and a list of domains which can be attributed to the provider. If the creative
        /// contains provider IDs that are outside of those listed in the
        /// `BidRequest.adslot.consented_providers_settings.consented_providers` field on the (Google bid
        /// protocol)[https://developers.google.com/authorized-buyers/rtb/downloads/realtime-bidding-proto] and the
        /// `BidRequest.user.ext.consented_providers_settings.consented_providers` field on the (OpenRTB
        /// protocol)[https://developers.google.com/authorized-buyers/rtb/downloads/openrtb-adx-proto], and a bid is
        /// submitted with that creative for an impression that will serve to an EEA user, the bid will be filtered
        /// before the auction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedProviderIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> DetectedProviderIds { get; set; }

        /// <summary>
        /// Whether the creative contains an unidentified ad technology provider. If true for a given creative, any bid
        /// submitted with that creative for an impression that will serve to an EEA user will be filtered before the
        /// auction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasUnidentifiedProvider")]
        public virtual System.Nullable<bool> HasUnidentifiedProvider { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request for associating a deal and a creative.</summary>
    public class AddDealAssociationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The association between a creative and a deal that should be added.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("association")]
        public virtual CreativeDealAssociation Association { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for adding a note to a given proposal.</summary>
    public class AddNoteRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Details of the note to add.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("note")]
        public virtual Note Note { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Output only. The app type the restriction applies to for mobile device.</summary>
    public class AppContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The app types this restriction applies to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appTypes")]
        public virtual System.Collections.Generic.IList<string> AppTypes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Output only. The auction type the restriction applies to.</summary>
    public class AuctionContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The auction types this restriction applies to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auctionTypes")]
        public virtual System.Collections.Generic.IList<string> AuctionTypes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The set of metrics that are measured in numbers of bids, representing how many bids with the specified dimension
    /// values were considered eligible at each stage of the bidding funnel;
    /// </summary>
    public class BidMetricsRow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of bids that Ad Exchange received from the buyer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bids")]
        public virtual MetricValue Bids { get; set; }

        /// <summary>The number of bids that were permitted to compete in the auction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bidsInAuction")]
        public virtual MetricValue BidsInAuction { get; set; }

        /// <summary>The number of bids for which the buyer was billed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billedImpressions")]
        public virtual MetricValue BilledImpressions { get; set; }

        /// <summary>The number of bids that won the auction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("impressionsWon")]
        public virtual MetricValue ImpressionsWon { get; set; }

        /// <summary>
        /// The number of bids for which the corresponding impression was measurable for viewability (as defined by
        /// Active View).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("measurableImpressions")]
        public virtual MetricValue MeasurableImpressions { get; set; }

        /// <summary>The number of bids that won the auction and also won the mediation waterfall (if any).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reachedQueries")]
        public virtual MetricValue ReachedQueries { get; set; }

        /// <summary>The values of all dimensions associated with metric values in this row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowDimensions")]
        public virtual RowDimensions RowDimensions { get; set; }

        /// <summary>
        /// The number of bids for which the corresponding impression was viewable (as defined by Active View).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewableImpressions")]
        public virtual MetricValue ViewableImpressions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The number of impressions with the specified dimension values that were considered to have no applicable bids,
    /// as described by the specified status.
    /// </summary>
    public class BidResponseWithoutBidsStatusRow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of impressions for which there was a bid response with the specified status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("impressionCount")]
        public virtual MetricValue ImpressionCount { get; set; }

        /// <summary>The values of all dimensions associated with metric values in this row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowDimensions")]
        public virtual RowDimensions RowDimensions { get; set; }

        /// <summary>The status specifying why the bid responses were considered to have no applicable bids.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a buyer of inventory. Each buyer is identified by a unique Authorized Buyers account ID.
    /// </summary>
    public class Buyer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Authorized Buyers account ID of the buyer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The number of impressions with the specified dimension values where the corresponding bid request or bid
    /// response was not successful, as described by the specified callout status.
    /// </summary>
    public class CalloutStatusRow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The ID of the callout status. See
        /// [callout-status-codes](https://developers.google.com/authorized-buyers/rtb/downloads/callout-status-codes).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("calloutStatusId")]
        public virtual System.Nullable<int> CalloutStatusId { get; set; }

        /// <summary>
        /// The number of impressions for which there was a bid request or bid response with the specified callout
        /// status.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("impressionCount")]
        public virtual MetricValue ImpressionCount { get; set; }

        /// <summary>The values of all dimensions associated with metric values in this row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowDimensions")]
        public virtual RowDimensions RowDimensions { get; set; }

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
    /// A client resource represents a client buyer—an agency, a brand, or an advertiser customer of the sponsor buyer.
    /// Users associated with the client buyer have restricted access to the Marketplace and certain other sections of
    /// the Authorized Buyers UI based on the role granted to the client buyer. All fields are required unless otherwise
    /// specified.
    /// </summary>
    public class Client : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The globally-unique numerical ID of the client. The value of this field is ignored in create and update
        /// operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientAccountId")]
        public virtual System.Nullable<long> ClientAccountId { get; set; }

        /// <summary>
        /// Name used to represent this client to publishers. You may have multiple clients that map to the same entity,
        /// but for each client the combination of `clientName` and entity must be unique. You can specify this field as
        /// empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientName")]
        public virtual string ClientName { get; set; }

        /// <summary>
        /// Numerical identifier of the client entity. The entity can be an advertiser, a brand, or an agency. This
        /// identifier is unique among all the entities with the same type. The value of this field is ignored if the
        /// entity type is not provided. A list of all known advertisers with their identifiers is available in the
        /// [advertisers.txt](https://storage.googleapis.com/adx-rtb-dictionaries/advertisers.txt) file. A list of all
        /// known brands with their identifiers is available in the
        /// [brands.txt](https://storage.googleapis.com/adx-rtb-dictionaries/brands.txt) file. A list of all known
        /// agencies with their identifiers is available in the
        /// [agencies.txt](https://storage.googleapis.com/adx-rtb-dictionaries/agencies.txt) file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityId")]
        public virtual System.Nullable<long> EntityId { get; set; }

        /// <summary>
        /// The name of the entity. This field is automatically fetched based on the type and ID. The value of this
        /// field is ignored in create and update operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityName")]
        public virtual string EntityName { get; set; }

        /// <summary>
        /// An optional field for specifying the type of the client entity: `ADVERTISER`, `BRAND`, or `AGENCY`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityType")]
        public virtual string EntityType { get; set; }

        /// <summary>
        /// Optional arbitrary unique identifier of this client buyer from the standpoint of its Ad Exchange sponsor
        /// buyer. This field can be used to associate a client buyer with the identifier in the namespace of its
        /// sponsor buyer, lookup client buyers by that identifier and verify whether an Ad Exchange counterpart of a
        /// given client buyer already exists. If present, must be unique among all the client buyers for its Ad
        /// Exchange sponsor buyer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partnerClientId")]
        public virtual string PartnerClientId { get; set; }

        /// <summary>
        /// The role which is assigned to the client buyer. Each role implies a set of permissions granted to the
        /// client. Must be one of `CLIENT_DEAL_VIEWER`, `CLIENT_DEAL_NEGOTIATOR` or `CLIENT_DEAL_APPROVER`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The status of the client buyer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>Whether the client buyer will be visible to sellers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visibleToSeller")]
        public virtual System.Nullable<bool> VisibleToSeller { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A client user is created under a client buyer and has restricted access to the Marketplace and certain other
    /// sections of the Authorized Buyers UI based on the role granted to the associated client buyer. The only way a
    /// new client user can be created is via accepting an email invitation (see the accounts.clients.invitations.create
    /// method). All fields are required unless otherwise specified.
    /// </summary>
    public class ClientUser : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Numerical account ID of the client buyer with which the user is associated; the buyer must be a client of
        /// the current sponsor buyer. The value of this field is ignored in an update operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientAccountId")]
        public virtual System.Nullable<long> ClientAccountId { get; set; }

        /// <summary>User's email address. The value of this field is ignored in an update operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>The status of the client user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>
        /// The unique numerical ID of the client user that has accepted an invitation. The value of this field is
        /// ignored in an update operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual System.Nullable<long> UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An invitation for a new client user to get access to the Authorized Buyers UI. All fields are required unless
    /// otherwise specified.
    /// </summary>
    public class ClientUserInvitation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Numerical account ID of the client buyer that the invited user is associated with. The value of this field
        /// is ignored in create operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientAccountId")]
        public virtual System.Nullable<long> ClientAccountId { get; set; }

        /// <summary>
        /// The email address to which the invitation is sent. Email addresses should be unique among all client users
        /// under each sponsor buyer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>
        /// The unique numerical ID of the invitation that is sent to the user. The value of this field is ignored in
        /// create operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invitationId")]
        public virtual System.Nullable<long> InvitationId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for indicating that the proposal's setup step is complete.</summary>
    public class CompleteSetupRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains information on how a buyer or seller can be reached.</summary>
    public class ContactInformation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Email address for the contact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>The name of the contact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Output only. Shows any corrections that were applied to this creative.</summary>
    public class Correction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The contexts for the correction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contexts")]
        public virtual System.Collections.Generic.IList<ServingContext> Contexts { get; set; }

        /// <summary>Additional details about what was corrected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<string> Details { get; set; }

        /// <summary>The type of correction that was applied to the creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A creative and its classification data.</summary>
    public class Creative : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The account that this creative belongs to. Can be used to filter the response of the creatives.list method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        /// <summary>The link to AdChoices destination page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adChoicesDestinationUrl")]
        public virtual string AdChoicesDestinationUrl { get; set; }

        /// <summary>Output only. The detected ad technology providers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adTechnologyProviders")]
        public virtual AdTechnologyProviders AdTechnologyProviders { get; set; }

        /// <summary>The name of the company being advertised in the creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserName")]
        public virtual string AdvertiserName { get; set; }

        /// <summary>The agency ID for this creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agencyId")]
        public virtual System.Nullable<long> AgencyId { get; set; }

        /// <summary>Output only. The last update timestamp of the creative via API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiUpdateTime")]
        public virtual object ApiUpdateTime { get; set; }

        /// <summary>
        /// All attributes for the ads that may be shown from this creative. Can be used to filter the response of the
        /// creatives.list method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IList<string> Attributes { get; set; }

        /// <summary>The set of destination URLs for the creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clickThroughUrls")]
        public virtual System.Collections.Generic.IList<string> ClickThroughUrls { get; set; }

        /// <summary>Output only. Shows any corrections that were applied to this creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("corrections")]
        public virtual System.Collections.Generic.IList<Correction> Corrections { get; set; }

        /// <summary>
        /// The buyer-defined creative ID of this creative. Can be used to filter the response of the creatives.list
        /// method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativeId")]
        public virtual string CreativeId { get; set; }

        /// <summary>
        /// Output only. The top-level deals status of this creative. If disapproved, an entry for
        /// 'auctionType=DIRECT_DEALS' (or 'ALL') in serving_restrictions will also exist. Note that this may be nuanced
        /// with other contextual restrictions, in which case, it may be preferable to read from serving_restrictions
        /// directly. Can be used to filter the response of the creatives.list method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dealsStatus")]
        public virtual string DealsStatus { get; set; }

        /// <summary>The set of declared destination URLs for the creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("declaredClickThroughUrls")]
        public virtual System.Collections.Generic.IList<string> DeclaredClickThroughUrls { get; set; }

        /// <summary>Output only. Detected advertiser IDs, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedAdvertiserIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> DetectedAdvertiserIds { get; set; }

        /// <summary>Output only. The detected domains for this creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedDomains")]
        public virtual System.Collections.Generic.IList<string> DetectedDomains { get; set; }

        /// <summary>
        /// Output only. The detected languages for this creative. The order is arbitrary. The codes are 2 or 5
        /// characters and are documented at https://developers.google.com/adwords/api/docs/appendix/languagecodes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<string> DetectedLanguages { get; set; }

        /// <summary>
        /// Output only. Detected product categories, if any. See the ad-product-categories.txt file in the technical
        /// documentation for a list of IDs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedProductCategories")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> DetectedProductCategories { get; set; }

        /// <summary>
        /// Output only. Detected sensitive categories, if any. See the ad-sensitive-categories.txt file in the
        /// technical documentation for a list of IDs. You should use these IDs along with the
        /// excluded-sensitive-category field in the bid request to filter your bids.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedSensitiveCategories")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> DetectedSensitiveCategories { get; set; }

        /// <summary>An HTML creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("html")]
        public virtual HtmlContent Html { get; set; }

        /// <summary>The set of URLs to be called to record an impression.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("impressionTrackingUrls")]
        public virtual System.Collections.Generic.IList<string> ImpressionTrackingUrls { get; set; }

        /// <summary>A native creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("native")]
        public virtual NativeContent Native { get; set; }

        /// <summary>
        /// Output only. The top-level open auction status of this creative. If disapproved, an entry for 'auctionType =
        /// OPEN_AUCTION' (or 'ALL') in serving_restrictions will also exist. Note that this may be nuanced with other
        /// contextual restrictions, in which case, it may be preferable to read from serving_restrictions directly. Can
        /// be used to filter the response of the creatives.list method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openAuctionStatus")]
        public virtual string OpenAuctionStatus { get; set; }

        /// <summary>All restricted categories for the ads that may be shown from this creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictedCategories")]
        public virtual System.Collections.Generic.IList<string> RestrictedCategories { get; set; }

        /// <summary>
        /// Output only. The granular status of this ad in specific contexts. A context here relates to where something
        /// ultimately serves (for example, a physical location, a platform, an HTTPS vs HTTP request, or the type of
        /// auction).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servingRestrictions")]
        public virtual System.Collections.Generic.IList<ServingRestriction> ServingRestrictions { get; set; }

        /// <summary>
        /// All vendor IDs for the ads that may be shown from this creative. See
        /// https://storage.googleapis.com/adx-rtb-dictionaries/vendors.txt for possible values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vendorIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> VendorIds { get; set; }

        /// <summary>Output only. The version of this creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<int> Version { get; set; }

        /// <summary>A video creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("video")]
        public virtual VideoContent Video { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The association between a creative and a deal.</summary>
    public class CreativeDealAssociation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The account the creative belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        /// <summary>The ID of the creative associated with the deal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativeId")]
        public virtual string CreativeId { get; set; }

        /// <summary>The externalDealId for the deal associated with the creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dealsId")]
        public virtual string DealsId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents creative restrictions associated to Programmatic Guaranteed/ Preferred Deal in Ad Manager. This
    /// doesn't apply to Private Auction and AdX Preferred Deals.
    /// </summary>
    public class CreativeRestrictions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The format of the environment that the creatives will be displayed in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativeFormat")]
        public virtual string CreativeFormat { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("creativeSpecifications")]
        public virtual System.Collections.Generic.IList<CreativeSpecification> CreativeSpecifications { get; set; }

        /// <summary>Skippable video ads allow viewers to skip ads after 5 seconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skippableAdType")]
        public virtual string SkippableAdType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the size of the creative.</summary>
    public class CreativeSize : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// What formats are allowed by the publisher. If this repeated field is empty then all formats are allowed. For
        /// example, if this field contains AllowedFormatType.AUDIO then the publisher only allows an audio ad (without
        /// any video).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedFormats")]
        public virtual System.Collections.Generic.IList<string> AllowedFormats { get; set; }

        /// <summary>
        /// For video creatives specifies the sizes of companion ads (if present). Companion sizes may be filled in only
        /// when creative_size_type = VIDEO
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("companionSizes")]
        public virtual System.Collections.Generic.IList<Size> CompanionSizes { get; set; }

        /// <summary>The creative size type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativeSizeType")]
        public virtual string CreativeSizeType { get; set; }

        /// <summary>
        /// Output only. The native template for this creative. It will have a value only if creative_size_type =
        /// CreativeSizeType.NATIVE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nativeTemplate")]
        public virtual string NativeTemplate { get; set; }

        /// <summary>For regular or video creative size type, specifies the size of the creative</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("size")]
        public virtual Size Size { get; set; }

        /// <summary>
        /// The type of skippable ad for this creative. It will have a value only if creative_size_type =
        /// CreativeSizeType.VIDEO.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skippableAdType")]
        public virtual string SkippableAdType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents information for a creative that is associated with a Programmatic Guaranteed/Preferred Deal in Ad
    /// Manager.
    /// </summary>
    public class CreativeSpecification : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Companion sizes may be filled in only when this is a video creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativeCompanionSizes")]
        public virtual System.Collections.Generic.IList<AdSize> CreativeCompanionSizes { get; set; }

        /// <summary>The size of the creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativeSize")]
        public virtual AdSize CreativeSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The number of bids with the specified dimension values that did not win the auction (either were filtered
    /// pre-auction or lost the auction), as described by the specified creative status.
    /// </summary>
    public class CreativeStatusRow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of bids with the specified status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bidCount")]
        public virtual MetricValue BidCount { get; set; }

        /// <summary>
        /// The ID of the creative status. See
        /// [creative-status-codes](https://developers.google.com/authorized-buyers/rtb/downloads/creative-status-codes).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativeStatusId")]
        public virtual System.Nullable<int> CreativeStatusId { get; set; }

        /// <summary>The values of all dimensions associated with metric values in this row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowDimensions")]
        public virtual RowDimensions RowDimensions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Generic targeting used for targeting dimensions that contains a list of included and excluded numeric IDs.
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

    /// <summary>
    /// Represents a whole or partial calendar date, such as a birthday. The time of day and time zone are either
    /// specified elsewhere or are insignificant. The date is relative to the Gregorian Calendar. This can represent one
    /// of the following: * A full date, with non-zero year, month, and day values * A month and day value, with a zero
    /// year, such as an anniversary * A year on its own, with zero month and day values * A year and month value, with
    /// a zero day, such as a credit card expiration date Related types are google.type.TimeOfDay and
    /// `google.protobuf.Timestamp`.
    /// </summary>
    public class Date : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a
        /// year and month where the day isn't significant.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual System.Nullable<int> Day { get; set; }

        /// <summary>Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("month")]
        public virtual System.Nullable<int> Month { get; set; }

        /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("year")]
        public virtual System.Nullable<int> Year { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Daypart targeting message that specifies if the ad can be shown only during certain parts of a day/week.
    /// </summary>
    public class DayPart : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The day of the week to target. If unspecified, applicable to all days.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dayOfWeek")]
        public virtual string DayOfWeek { get; set; }

        /// <summary>
        /// The ending time of the day for the ad to show (minute level granularity). The end time is exclusive. This
        /// field is not available for filtering in PQL queries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual TimeOfDay EndTime { get; set; }

        /// <summary>
        /// The starting time of day for the ad to show (minute level granularity). The start time is inclusive. This
        /// field is not available for filtering in PQL queries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual TimeOfDay StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the day part targeting criteria.</summary>
    public class DayPartTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of day part targeting criterion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dayParts")]
        public virtual System.Collections.Generic.IList<DayPart> DayParts { get; set; }

        /// <summary>The timezone to use for interpreting the day part targeting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZoneType")]
        public virtual string TimeZoneType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A deal represents a segment of inventory for displaying ads on. A proposal can contain multiple deals. A deal
    /// contains the terms and targeting information that is used for serving.
    /// </summary>
    public class Deal : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Proposed flight end time of the deal. This will generally be stored in a granularity of a second. A value is
        /// not required for Private Auction deals or Preferred Deals.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableEndTime")]
        public virtual object AvailableEndTime { get; set; }

        /// <summary>
        /// Optional. Proposed flight start time of the deal. This will generally be stored in the granularity of one
        /// second since deal serving starts at seconds boundary. Any time specified with more granularity (e.g., in
        /// milliseconds) will be truncated towards the start of time in seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableStartTime")]
        public virtual object AvailableStartTime { get; set; }

        /// <summary>Buyer private data (hidden from seller).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buyerPrivateData")]
        public virtual PrivateData BuyerPrivateData { get; set; }

        /// <summary>
        /// The product ID from which this deal was created. Note: This field may be set only when creating the
        /// resource. Modifying this field while updating the resource will result in an error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createProductId")]
        public virtual string CreateProductId { get; set; }

        /// <summary>
        /// Optional. Revision number of the product that the deal was created from. If present on create, and the
        /// server `product_revision` has advanced since the passed-in `create_product_revision`, an `ABORTED` error
        /// will be returned. Note: This field may be set only when creating the resource. Modifying this field while
        /// updating the resource will result in an error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createProductRevision")]
        public virtual System.Nullable<long> CreateProductRevision { get; set; }

        /// <summary>Output only. The time of the deal creation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. Specifies the creative pre-approval policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativePreApprovalPolicy")]
        public virtual string CreativePreApprovalPolicy { get; set; }

        /// <summary>
        /// Output only. Restricitions about the creatives associated with the deal (i.e., size) This is available for
        /// Programmatic Guaranteed/Preferred Deals in Ad Manager.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativeRestrictions")]
        public virtual CreativeRestrictions CreativeRestrictions { get; set; }

        /// <summary>Output only. Specifies whether the creative is safeFrame compatible.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativeSafeFrameCompatibility")]
        public virtual string CreativeSafeFrameCompatibility { get; set; }

        /// <summary>Output only. A unique deal ID for the deal (server-assigned).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dealId")]
        public virtual string DealId { get; set; }

        /// <summary>Output only. Metadata about the serving status of this deal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dealServingMetadata")]
        public virtual DealServingMetadata DealServingMetadata { get; set; }

        /// <summary>The negotiable terms of the deal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dealTerms")]
        public virtual DealTerms DealTerms { get; set; }

        /// <summary>
        /// The set of fields around delivery control that are interesting for a buyer to see but are non-negotiable.
        /// These are set by the publisher.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliveryControl")]
        public virtual DeliveryControl DeliveryControl { get; set; }

        /// <summary>Description for the deal terms.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The name of the deal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. The external deal ID assigned to this deal once the deal is finalized. This is the deal ID that
        /// shows up in serving/reporting etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalDealId")]
        public virtual string ExternalDealId { get; set; }

        /// <summary>Output only. True, if the buyside inventory setup is complete for this deal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isSetupComplete")]
        public virtual System.Nullable<bool> IsSetupComplete { get; set; }

        /// <summary>
        /// Output only. Specifies the creative source for programmatic deals. PUBLISHER means creative is provided by
        /// seller and ADVERTISER means creative is provided by buyer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("programmaticCreativeSource")]
        public virtual string ProgrammaticCreativeSource { get; set; }

        /// <summary>Output only. ID of the proposal that this deal is part of.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proposalId")]
        public virtual string ProposalId { get; set; }

        /// <summary>Output only. Seller contact information for the deal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sellerContacts")]
        public virtual System.Collections.Generic.IList<ContactInformation> SellerContacts { get; set; }

        /// <summary>
        /// The syndication product associated with the deal. Note: This field may be set only when creating the
        /// resource. Modifying this field while updating the resource will result in an error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syndicationProduct")]
        public virtual string SyndicationProduct { get; set; }

        /// <summary>Output only. Specifies the subset of inventory targeted by the deal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targeting")]
        public virtual MarketplaceTargeting Targeting { get; set; }

        /// <summary>
        /// The shared targeting visible to buyers and sellers. Each shared targeting entity is AND'd together.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetingCriterion")]
        public virtual System.Collections.Generic.IList<TargetingCriteria> TargetingCriterion { get; set; }

        /// <summary>Output only. The time when the deal was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The web property code for the seller copied over from the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webPropertyCode")]
        public virtual string WebPropertyCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Tracks which parties (if any) have paused a deal. The deal is considered paused if either hasBuyerPaused or
    /// hasSellPaused is true.
    /// </summary>
    public class DealPauseStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The buyer's reason for pausing, if the buyer paused the deal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buyerPauseReason")]
        public virtual string BuyerPauseReason { get; set; }

        /// <summary>The role of the person who first paused this deal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstPausedBy")]
        public virtual string FirstPausedBy { get; set; }

        /// <summary>True, if the buyer has paused the deal unilaterally.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasBuyerPaused")]
        public virtual System.Nullable<bool> HasBuyerPaused { get; set; }

        /// <summary>True, if the seller has paused the deal unilaterally.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasSellerPaused")]
        public virtual System.Nullable<bool> HasSellerPaused { get; set; }

        /// <summary>The seller's reason for pausing, if the seller paused the deal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sellerPauseReason")]
        public virtual string SellerPauseReason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message captures metadata about the serving status of a deal.</summary>
    public class DealServingMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Tracks which parties (if any) have paused a deal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dealPauseStatus")]
        public virtual DealPauseStatus DealPauseStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The deal terms specify the details of a Product/deal. They specify things like price per buyer, the type of
    /// pricing model (e.g., fixed price, auction) and expected impressions from the publisher.
    /// </summary>
    public class DealTerms : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Visibility of the URL in bid requests. (default: BRANDED)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("brandingType")]
        public virtual string BrandingType { get; set; }

        /// <summary>Publisher provided description for the terms.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Non-binding estimate of the estimated gross spend for this deal. Can be set by buyer or seller.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("estimatedGrossSpend")]
        public virtual Price EstimatedGrossSpend { get; set; }

        /// <summary>Non-binding estimate of the impressions served per day. Can be set by buyer or seller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("estimatedImpressionsPerDay")]
        public virtual System.Nullable<long> EstimatedImpressionsPerDay { get; set; }

        /// <summary>The terms for guaranteed fixed price deals.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("guaranteedFixedPriceTerms")]
        public virtual GuaranteedFixedPriceTerms GuaranteedFixedPriceTerms { get; set; }

        /// <summary>The terms for non-guaranteed auction deals.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nonGuaranteedAuctionTerms")]
        public virtual NonGuaranteedAuctionTerms NonGuaranteedAuctionTerms { get; set; }

        /// <summary>The terms for non-guaranteed fixed price deals.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nonGuaranteedFixedPriceTerms")]
        public virtual NonGuaranteedFixedPriceTerms NonGuaranteedFixedPriceTerms { get; set; }

        /// <summary>
        /// The time zone name. For deals with Cost Per Day billing, defines the time zone used to mark the boundaries
        /// of a day. It should be an IANA TZ name, such as "America/Los_Angeles". For more information, see
        /// https://en.wikipedia.org/wiki/List_of_tz_database_time_zones.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sellerTimeZone")]
        public virtual string SellerTimeZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message contains details about how the deals will be paced.</summary>
    public class DeliveryControl : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Specified the creative blocking levels to be applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativeBlockingLevel")]
        public virtual string CreativeBlockingLevel { get; set; }

        /// <summary>Output only. Specifies how the impression delivery will be paced.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliveryRateType")]
        public virtual string DeliveryRateType { get; set; }

        /// <summary>Output only. Specifies any frequency caps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frequencyCaps")]
        public virtual System.Collections.Generic.IList<FrequencyCap> FrequencyCaps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Output only. The reason and details for a disapproval.</summary>
    public class Disapproval : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional details about the reason for disapproval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<string> Details { get; set; }

        /// <summary>The categorized reason for disapproval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); } The JSON representation for `Empty` is empty JSON
    /// object `{}`.
    /// </summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A set of filters that is applied to a request for data. Within a filter set, an AND operation is performed
    /// across the filters represented by each field. An OR operation is performed across the filters represented by the
    /// multiple values of a repeated field, e.g., "format=VIDEO AND deal_id=12 AND (seller_network_id=34 OR
    /// seller_network_id=56)".
    /// </summary>
    public class FilterSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An absolute date range, defined by a start date and an end date. Interpreted relative to Pacific time zone.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("absoluteDateRange")]
        public virtual AbsoluteDateRange AbsoluteDateRange { get; set; }

        /// <summary>
        /// The set of dimensions along which to break down the response; may be empty. If multiple dimensions are
        /// requested, the breakdown is along the Cartesian product of the requested dimensions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("breakdownDimensions")]
        public virtual System.Collections.Generic.IList<string> BreakdownDimensions { get; set; }

        /// <summary>
        /// The ID of the creative on which to filter; optional. This field may be set only for a filter set that
        /// accesses account-level troubleshooting data, i.e., one whose name matches the
        /// `bidders/*/accounts/*/filterSets/*` pattern.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativeId")]
        public virtual string CreativeId { get; set; }

        /// <summary>
        /// The ID of the deal on which to filter; optional. This field may be set only for a filter set that accesses
        /// account-level troubleshooting data, i.e., one whose name matches the `bidders/*/accounts/*/filterSets/*`
        /// pattern.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dealId")]
        public virtual System.Nullable<long> DealId { get; set; }

        /// <summary>The environment on which to filter; optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environment")]
        public virtual string Environment { get; set; }

        /// <summary>Creative format bidded on or allowed to bid on, can be empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("format")]
        public virtual string Format { get; set; }

        /// <summary>
        /// Creative formats bidded on or allowed to bid on, can be empty. Although this field is a list, it can only be
        /// populated with a single item. A HTTP 400 bad request error will be returned in the response if you specify
        /// multiple items.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formats")]
        public virtual System.Collections.Generic.IList<string> Formats { get; set; }

        /// <summary>
        /// A user-defined name of the filter set. Filter set names must be unique globally and match one of the
        /// patterns: - `bidders/*/filterSets/*` (for accessing bidder-level troubleshooting data) -
        /// `bidders/*/accounts/*/filterSets/*` (for accessing account-level troubleshooting data) This field is
        /// required in create operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The list of platforms on which to filter; may be empty. The filters represented by multiple platforms are
        /// ORed together (i.e., if non-empty, results must match any one of the platforms).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platforms")]
        public virtual System.Collections.Generic.IList<string> Platforms { get; set; }

        /// <summary>
        /// For Open Bidding partners only. The list of publisher identifiers on which to filter; may be empty. The
        /// filters represented by multiple publisher identifiers are ORed together.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publisherIdentifiers")]
        public virtual System.Collections.Generic.IList<string> PublisherIdentifiers { get; set; }

        /// <summary>An open-ended realtime time range, defined by the aggregation start timestamp.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("realtimeTimeRange")]
        public virtual RealtimeTimeRange RealtimeTimeRange { get; set; }

        /// <summary>
        /// A relative date range, defined by an offset from today and a duration. Interpreted relative to Pacific time
        /// zone.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relativeDateRange")]
        public virtual RelativeDateRange RelativeDateRange { get; set; }

        /// <summary>
        /// For Authorized Buyers only. The list of IDs of the seller (publisher) networks on which to filter; may be
        /// empty. The filters represented by multiple seller network IDs are ORed together (i.e., if non-empty, results
        /// must match any one of the publisher networks). See
        /// [seller-network-ids](https://developers.google.com/authorized-buyers/rtb/downloads/seller-network-ids) file
        /// for the set of existing seller network IDs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sellerNetworkIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> SellerNetworkIds { get; set; }

        /// <summary>The granularity of time intervals if a time series breakdown is desired; optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeSeriesGranularity")]
        public virtual string TimeSeriesGranularity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The number of filtered bids with the specified dimension values that have the specified creative.
    /// </summary>
    public class FilteredBidCreativeRow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of bids with the specified creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bidCount")]
        public virtual MetricValue BidCount { get; set; }

        /// <summary>The ID of the creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativeId")]
        public virtual string CreativeId { get; set; }

        /// <summary>The values of all dimensions associated with metric values in this row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowDimensions")]
        public virtual RowDimensions RowDimensions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The number of filtered bids with the specified dimension values, among those filtered due to the requested
    /// filtering reason (i.e. creative status), that have the specified detail.
    /// </summary>
    public class FilteredBidDetailRow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of bids with the specified detail.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bidCount")]
        public virtual MetricValue BidCount { get; set; }

        /// <summary>
        /// The ID of the detail, can be numeric or text. The associated value can be looked up in the dictionary file
        /// corresponding to the DetailType in the response message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detail")]
        public virtual string Detail { get; set; }

        /// <summary>
        /// Note: this field will be deprecated, use "detail" field instead. When "detail" field represents an integer
        /// value, this field is populated as the same integer value "detail" field represents, otherwise this field
        /// will be 0. The ID of the detail. The associated value can be looked up in the dictionary file corresponding
        /// to the DetailType in the response message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detailId")]
        public virtual System.Nullable<int> DetailId { get; set; }

        /// <summary>The values of all dimensions associated with metric values in this row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowDimensions")]
        public virtual RowDimensions RowDimensions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a list of targeted and excluded mobile application IDs that publishers own. Mobile application IDs
    /// are from App Store and Google Play Store. Android App ID, for example, com.google.android.apps.maps, can be
    /// found in Google Play Store URL. iOS App ID (which is a number) can be found at the end of iTunes store URL.
    /// First party mobile applications is either included or excluded.
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

    /// <summary>Frequency cap.</summary>
    public class FrequencyCap : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The maximum number of impressions that can be served to a user within the specified time period.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxImpressions")]
        public virtual System.Nullable<int> MaxImpressions { get; set; }

        /// <summary>
        /// The amount of time, in the units specified by time_unit_type. Defines the amount of time over which
        /// impressions per user are counted and capped.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numTimeUnits")]
        public virtual System.Nullable<int> NumTimeUnits { get; set; }

        /// <summary>
        /// The time unit. Along with num_time_units defines the amount of time over which impressions per user are
        /// counted and capped.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeUnitType")]
        public virtual string TimeUnitType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Terms for Programmatic Guaranteed Deals.</summary>
    public class GuaranteedFixedPriceTerms : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Fixed price for the specified buyer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixedPrices")]
        public virtual System.Collections.Generic.IList<PricePerBuyer> FixedPrices { get; set; }

        /// <summary>
        /// Guaranteed impressions as a percentage. This is the percentage of guaranteed looks that the buyer is
        /// guaranteeing to buy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("guaranteedImpressions")]
        public virtual System.Nullable<long> GuaranteedImpressions { get; set; }

        /// <summary>Count of guaranteed looks. Required for deal, optional for product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("guaranteedLooks")]
        public virtual System.Nullable<long> GuaranteedLooks { get; set; }

        /// <summary>
        /// The lifetime impression cap for CPM sponsorship deals. The deal will stop serving when the cap is reached.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("impressionCap")]
        public virtual System.Nullable<long> ImpressionCap { get; set; }

        /// <summary>Daily minimum looks for CPD deal types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumDailyLooks")]
        public virtual System.Nullable<long> MinimumDailyLooks { get; set; }

        /// <summary>
        /// For sponsorship deals, this is the percentage of the seller's eligible impressions that the deal will serve
        /// until the cap is reached.
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

    /// <summary>HTML content for a creative.</summary>
    public class HtmlContent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The height of the HTML snippet in pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual System.Nullable<int> Height { get; set; }

        /// <summary>The HTML snippet that displays the ad when inserted in the web page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
        public virtual string Snippet { get; set; }

        /// <summary>The width of the HTML snippet in pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<int> Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An image resource. You may provide a larger image than was requested, so long as the aspect ratio is preserved.
    /// </summary>
    public class Image : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Image height in pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual System.Nullable<int> Height { get; set; }

        /// <summary>The URL of the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>Image width in pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<int> Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The set of metrics that are measured in numbers of impressions, representing how many impressions with the
    /// specified dimension values were considered eligible at each stage of the bidding funnel.
    /// </summary>
    public class ImpressionMetricsRow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The number of impressions available to the buyer on Ad Exchange. In some cases this value may be
        /// unavailable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableImpressions")]
        public virtual MetricValue AvailableImpressions { get; set; }

        /// <summary>The number of impressions for which Ad Exchange sent the buyer a bid request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bidRequests")]
        public virtual MetricValue BidRequests { get; set; }

        /// <summary>The number of impressions that match the buyer's inventory pretargeting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inventoryMatches")]
        public virtual MetricValue InventoryMatches { get; set; }

        /// <summary>
        /// The number of impressions for which Ad Exchange received a response from the buyer that contained at least
        /// one applicable bid.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responsesWithBids")]
        public virtual MetricValue ResponsesWithBids { get; set; }

        /// <summary>The values of all dimensions associated with metric values in this row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowDimensions")]
        public virtual RowDimensions RowDimensions { get; set; }

        /// <summary>
        /// The number of impressions for which the buyer successfully sent a response to Ad Exchange.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("successfulResponses")]
        public virtual MetricValue SuccessfulResponses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents the size of an ad unit that can be targeted on an ad request. It only applies to Private Auction, AdX
    /// Preferred Deals and Auction Packages. This targeting does not apply to Programmatic Guaranteed and Preferred
    /// Deals in Ad Manager.
    /// </summary>
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

    /// <summary>Response message for listing the metrics that are measured in number of bids.</summary>
    public class ListBidMetricsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of rows, each containing a set of bid metrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bidMetricsRows")]
        public virtual System.Collections.Generic.IList<BidMetricsRow> BidMetricsRows { get; set; }

        /// <summary>
        /// A token to retrieve the next page of results. Pass this value in the ListBidMetricsRequest.pageToken field
        /// in the subsequent call to the bidMetrics.list method to retrieve the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing all reasons that bid responses resulted in an error.</summary>
    public class ListBidResponseErrorsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of rows, with counts of bid responses aggregated by callout status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("calloutStatusRows")]
        public virtual System.Collections.Generic.IList<CalloutStatusRow> CalloutStatusRows { get; set; }

        /// <summary>
        /// A token to retrieve the next page of results. Pass this value in the ListBidResponseErrorsRequest.pageToken
        /// field in the subsequent call to the bidResponseErrors.list method to retrieve the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response message for listing all reasons that bid responses were considered to have no applicable bids.
    /// </summary>
    public class ListBidResponsesWithoutBidsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of rows, with counts of bid responses without bids aggregated by status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bidResponseWithoutBidsStatusRows")]
        public virtual System.Collections.Generic.IList<BidResponseWithoutBidsStatusRow> BidResponseWithoutBidsStatusRows { get; set; }

        /// <summary>
        /// A token to retrieve the next page of results. Pass this value in the
        /// ListBidResponsesWithoutBidsRequest.pageToken field in the subsequent call to the
        /// bidResponsesWithoutBids.list method to retrieve the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListClientUserInvitationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The returned list of client users.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invitations")]
        public virtual System.Collections.Generic.IList<ClientUserInvitation> Invitations { get; set; }

        /// <summary>
        /// A token to retrieve the next page of results. Pass this value in the
        /// ListClientUserInvitationsRequest.pageToken field in the subsequent call to the clients.invitations.list
        /// method to retrieve the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListClientUsersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token to retrieve the next page of results. Pass this value in the ListClientUsersRequest.pageToken field
        /// in the subsequent call to the clients.invitations.list method to retrieve the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The returned list of client users.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("users")]
        public virtual System.Collections.Generic.IList<ClientUser> Users { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListClientsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The returned list of clients.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clients")]
        public virtual System.Collections.Generic.IList<Client> Clients { get; set; }

        /// <summary>
        /// A token to retrieve the next page of results. Pass this value in the ListClientsRequest.pageToken field in
        /// the subsequent call to the accounts.clients.list method to retrieve the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing all creatives associated with a given filtered bid reason.</summary>
    public class ListCreativeStatusBreakdownByCreativeResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of rows, with counts of bids with a given creative status aggregated by creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filteredBidCreativeRows")]
        public virtual System.Collections.Generic.IList<FilteredBidCreativeRow> FilteredBidCreativeRows { get; set; }

        /// <summary>
        /// A token to retrieve the next page of results. Pass this value in the
        /// ListCreativeStatusBreakdownByCreativeRequest.pageToken field in the subsequent call to the
        /// filteredBids.creatives.list method to retrieve the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing all details associated with a given filtered bid reason.</summary>
    public class ListCreativeStatusBreakdownByDetailResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of detail that the detail IDs represent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detailType")]
        public virtual string DetailType { get; set; }

        /// <summary>List of rows, with counts of bids with a given creative status aggregated by detail.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filteredBidDetailRows")]
        public virtual System.Collections.Generic.IList<FilteredBidDetailRow> FilteredBidDetailRows { get; set; }

        /// <summary>
        /// A token to retrieve the next page of results. Pass this value in the
        /// ListCreativeStatusBreakdownByDetailRequest.pageToken field in the subsequent call to the
        /// filteredBids.details.list method to retrieve the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response for listing creatives.</summary>
    public class ListCreativesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of creatives.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creatives")]
        public virtual System.Collections.Generic.IList<Creative> Creatives { get; set; }

        /// <summary>
        /// A token to retrieve the next page of results. Pass this value in the ListCreativesRequest.page_token field
        /// in the subsequent call to `ListCreatives` method to retrieve the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response for listing creative and deal associations</summary>
    public class ListDealAssociationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of associations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("associations")]
        public virtual System.Collections.Generic.IList<CreativeDealAssociation> Associations { get; set; }

        /// <summary>
        /// A token to retrieve the next page of results. Pass this value in the ListDealAssociationsRequest.page_token
        /// field in the subsequent call to 'ListDealAssociation' method to retrieve the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing filter sets.</summary>
    public class ListFilterSetsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The filter sets belonging to the buyer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterSets")]
        public virtual System.Collections.Generic.IList<FilterSet> FilterSets { get; set; }

        /// <summary>
        /// A token to retrieve the next page of results. Pass this value in the ListFilterSetsRequest.pageToken field
        /// in the subsequent call to the accounts.filterSets.list method to retrieve the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response message for listing all reasons that bid requests were filtered and not sent to the buyer.
    /// </summary>
    public class ListFilteredBidRequestsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of rows, with counts of filtered bid requests aggregated by callout status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("calloutStatusRows")]
        public virtual System.Collections.Generic.IList<CalloutStatusRow> CalloutStatusRows { get; set; }

        /// <summary>
        /// A token to retrieve the next page of results. Pass this value in the
        /// ListFilteredBidRequestsRequest.pageToken field in the subsequent call to the filteredBidRequests.list method
        /// to retrieve the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing all reasons that bids were filtered from the auction.</summary>
    public class ListFilteredBidsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of rows, with counts of filtered bids aggregated by filtering reason (i.e. creative status).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativeStatusRows")]
        public virtual System.Collections.Generic.IList<CreativeStatusRow> CreativeStatusRows { get; set; }

        /// <summary>
        /// A token to retrieve the next page of results. Pass this value in the ListFilteredBidsRequest.pageToken field
        /// in the subsequent call to the filteredBids.list method to retrieve the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing the metrics that are measured in number of impressions.</summary>
    public class ListImpressionMetricsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of rows, each containing a set of impression metrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("impressionMetricsRows")]
        public virtual System.Collections.Generic.IList<ImpressionMetricsRow> ImpressionMetricsRows { get; set; }

        /// <summary>
        /// A token to retrieve the next page of results. Pass this value in the ListImpressionMetricsRequest.pageToken
        /// field in the subsequent call to the impressionMetrics.list method to retrieve the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing all reasons that bids lost in the auction.</summary>
    public class ListLosingBidsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of rows, with counts of losing bids aggregated by loss reason (i.e. creative status).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativeStatusRows")]
        public virtual System.Collections.Generic.IList<CreativeStatusRow> CreativeStatusRows { get; set; }

        /// <summary>
        /// A token to retrieve the next page of results. Pass this value in the ListLosingBidsRequest.pageToken field
        /// in the subsequent call to the losingBids.list method to retrieve the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing all reasons for which a buyer was not billed for a winning bid.</summary>
    public class ListNonBillableWinningBidsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token to retrieve the next page of results. Pass this value in the
        /// ListNonBillableWinningBidsRequest.pageToken field in the subsequent call to the nonBillableWinningBids.list
        /// method to retrieve the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of rows, with counts of bids not billed aggregated by reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nonBillableWinningBidStatusRows")]
        public virtual System.Collections.Generic.IList<NonBillableWinningBidStatusRow> NonBillableWinningBidStatusRows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing products visible to the buyer.</summary>
    public class ListProductsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List pagination support.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of matching products at their head revision number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("products")]
        public virtual System.Collections.Generic.IList<Product> Products { get; set; }

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
        /// <summary>List pagination support</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of matching publisher profiles.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publisherProfiles")]
        public virtual System.Collections.Generic.IList<PublisherProfile> PublisherProfiles { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Output only. The Geo criteria the restriction applies to.</summary>
    public class LocationContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// IDs representing the geo location for this context. Please refer to the
        /// [geo-table.csv](https://storage.googleapis.com/adx-rtb-dictionaries/geo-table.csv) file for different geo
        /// criteria IDs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("geoCriteriaIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> GeoCriteriaIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Targeting represents different criteria that can be used by advertisers to target ad inventory. For example,
    /// they can choose to target ad requests only if the user is in the US. Multiple types of targeting are always
    /// applied as a logical AND, unless noted otherwise.
    /// </summary>
    public class MarketplaceTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Geo criteria IDs to be included/excluded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("geoTargeting")]
        public virtual CriteriaTargeting GeoTargeting { get; set; }

        /// <summary>Inventory sizes to be included/excluded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inventorySizeTargeting")]
        public virtual InventorySizeTargeting InventorySizeTargeting { get; set; }

        /// <summary>Placement targeting information, e.g., URL, mobile applications.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placementTargeting")]
        public virtual PlacementTargeting PlacementTargeting { get; set; }

        /// <summary>Technology targeting information, e.g., operating system, device category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("technologyTargeting")]
        public virtual TechnologyTargeting TechnologyTargeting { get; set; }

        /// <summary>Video targeting information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoTargeting")]
        public virtual VideoTargeting VideoTargeting { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A metric value, with an expected value and a variance; represents a count that may be either exact or estimated
    /// (i.e. when sampled).
    /// </summary>
    public class MetricValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The expected value of the metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<long> Value { get; set; }

        /// <summary>
        /// The variance (i.e. square of the standard deviation) of the metric value. If value is exact, variance is 0.
        /// Can be used to calculate margin of error as a percentage of value, using the following formula, where Z is
        /// the standard constant that depends on the desired size of the confidence interval (e.g. for 90% confidence
        /// interval, use Z = 1.645): marginOfError = 100 * Z * sqrt(variance) / value
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variance")]
        public virtual System.Nullable<long> Variance { get; set; }

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

    /// <summary>Native content for a creative.</summary>
    public class NativeContent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the advertiser or sponsor, to be displayed in the ad creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserName")]
        public virtual string AdvertiserName { get; set; }

        /// <summary>The app icon, for app download ads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appIcon")]
        public virtual Image AppIcon { get; set; }

        /// <summary>A long description of the ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("body")]
        public virtual string Body { get; set; }

        /// <summary>A label for the button that the user is supposed to click.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callToAction")]
        public virtual string CallToAction { get; set; }

        /// <summary>The URL that the browser/SDK will load when the user clicks the ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clickLinkUrl")]
        public virtual string ClickLinkUrl { get; set; }

        /// <summary>The URL to use for click tracking.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clickTrackingUrl")]
        public virtual string ClickTrackingUrl { get; set; }

        /// <summary>A short title for the ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headline")]
        public virtual string Headline { get; set; }

        /// <summary>A large image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual Image Image { get; set; }

        /// <summary>A smaller image, for the advertiser's logo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logo")]
        public virtual Image Logo { get; set; }

        /// <summary>The price of the promoted app including currency info.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceDisplayText")]
        public virtual string PriceDisplayText { get; set; }

        /// <summary>The app rating in the app store. Must be in the range [0-5].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("starRating")]
        public virtual System.Nullable<double> StarRating { get; set; }

        /// <summary>The URL to the app store to purchase/download the promoted app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storeUrl")]
        public virtual string StoreUrl { get; set; }

        /// <summary>The URL to fetch a native video ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoUrl")]
        public virtual string VideoUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The number of winning bids with the specified dimension values for which the buyer was not billed, as described
    /// by the specified status.
    /// </summary>
    public class NonBillableWinningBidStatusRow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of bids with the specified status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bidCount")]
        public virtual MetricValue BidCount { get; set; }

        /// <summary>The values of all dimensions associated with metric values in this row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowDimensions")]
        public virtual RowDimensions RowDimensions { get; set; }

        /// <summary>The status specifying why the winning bids were not billed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Terms for Private Auctions. Note that Private Auctions can be created only by the seller, but they can be
    /// returned in a get or list request.
    /// </summary>
    public class NonGuaranteedAuctionTerms : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// True if open auction buyers are allowed to compete with invited buyers in this private auction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoOptimizePrivateAuction")]
        public virtual System.Nullable<bool> AutoOptimizePrivateAuction { get; set; }

        /// <summary>Reserve price for the specified buyer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reservePricesPerBuyer")]
        public virtual System.Collections.Generic.IList<PricePerBuyer> ReservePricesPerBuyer { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Terms for Preferred Deals.</summary>
    public class NonGuaranteedFixedPriceTerms : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Fixed price for the specified buyer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixedPrices")]
        public virtual System.Collections.Generic.IList<PricePerBuyer> FixedPrices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A proposal may be associated to several notes.</summary>
    public class Note : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The timestamp for when this note was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The role of the person (buyer/seller) creating the note.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creatorRole")]
        public virtual string CreatorRole { get; set; }

        /// <summary>
        /// The actual note to attach. (max-length: 1024 unicode code units) Note: This field may be set only when
        /// creating the resource. Modifying this field while updating the resource will result in an error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("note")]
        public virtual string NoteValue { get; set; }

        /// <summary>Output only. The unique ID for the note.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noteId")]
        public virtual string NoteId { get; set; }

        /// <summary>Output only. The revision number of the proposal when the note is created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proposalRevision")]
        public virtual System.Nullable<long> ProposalRevision { get; set; }

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

    /// <summary>Request message to pause serving for finalized deals.</summary>
    public class PauseProposalDealsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The external_deal_id's of the deals to be paused. If empty, all the deals in the proposal will be paused.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalDealIds")]
        public virtual System.Collections.Generic.IList<string> ExternalDealIds { get; set; }

        /// <summary>
        /// The reason why the deals are being paused. This human readable message will be displayed in the seller's UI.
        /// (Max length: 1000 unicode code units.)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message to pause serving for an already-finalized proposal.</summary>
    public class PauseProposalRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The reason why the proposal is being paused. This human readable message will be displayed in the seller's
        /// UI. (Max length: 1000 unicode code units.)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents targeting about where the ads can appear, e.g., certain sites or mobile applications. Different
    /// placement targeting types will be logically OR'ed.
    /// </summary>
    public class PlacementTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Mobile application targeting information in a deal. This doesn't apply to Auction Packages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileApplicationTargeting")]
        public virtual MobileApplicationTargeting MobileApplicationTargeting { get; set; }

        /// <summary>URLs to be included/excluded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("urlTargeting")]
        public virtual UrlTargeting UrlTargeting { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Output only. The type of platform the restriction applies to.</summary>
    public class PlatformContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The platforms this restriction applies to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platforms")]
        public virtual System.Collections.Generic.IList<string> Platforms { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a price and a pricing type for a product / deal.</summary>
    public class Price : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The actual price with currency specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amount")]
        public virtual Money Amount { get; set; }

        /// <summary>The pricing type for the deal/product. (default: CPM)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pricingType")]
        public virtual string PricingType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Used to specify pricing rules for buyers/advertisers. Each PricePerBuyer in a product can become 0 or 1 deals.
    /// To check if there is a PricePerBuyer for a particular buyer or buyer/advertiser pair, we look for the most
    /// specific matching rule - we first look for a rule matching the buyer and advertiser, next a rule with the buyer
    /// but an empty advertiser list, and otherwise look for a matching rule where no buyer is set.
    /// </summary>
    public class PricePerBuyer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of advertisers for this price when associated with this buyer. If empty, all advertisers with this
        /// buyer pay this price.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserIds")]
        public virtual System.Collections.Generic.IList<string> AdvertiserIds { get; set; }

        /// <summary>
        /// The buyer who will pay this price. If unset, all buyers can pay this price (if the advertisers match, and
        /// there's no more specific rule matching the buyer).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buyer")]
        public virtual Buyer Buyer { get; set; }

        /// <summary>The specified price.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("price")]
        public virtual Price Price { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Buyers are allowed to store certain types of private data in a proposal/deal.</summary>
    public class PrivateData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A buyer or seller specified reference ID. This can be queried in the list operations (max-length: 1024
        /// unicode code units).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referenceId")]
        public virtual string ReferenceId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A product is a segment of inventory that a seller wishes to sell. It is associated with certain terms and
    /// targeting information which helps the buyer know more about the inventory.
    /// </summary>
    public class Product : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The proposed end time for the deal. The field will be truncated to the order of seconds during serving.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableEndTime")]
        public virtual object AvailableEndTime { get; set; }

        /// <summary>
        /// Inventory availability dates. The start time will be truncated to seconds during serving. Thus, a field
        /// specified as 3:23:34.456 (HH:mm:ss.SSS) will be truncated to 3:23:34 when serving.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableStartTime")]
        public virtual object AvailableStartTime { get; set; }

        /// <summary>Creation time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Optional contact information for the creator of this product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creatorContacts")]
        public virtual System.Collections.Generic.IList<ContactInformation> CreatorContacts { get; set; }

        /// <summary>The display name for this product as set by the seller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// If the creator has already signed off on the product, then the buyer can finalize the deal by accepting the
        /// product as is. When copying to a proposal, if any of the terms are changed, then auto_finalize is
        /// automatically set to false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasCreatorSignedOff")]
        public virtual System.Nullable<bool> HasCreatorSignedOff { get; set; }

        /// <summary>The unique ID for the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; }

        /// <summary>The revision number of the product (auto-assigned by Marketplace).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productRevision")]
        public virtual System.Nullable<long> ProductRevision { get; set; }

        /// <summary>
        /// An ID which can be used by the Publisher Profile API to get more information about the seller that created
        /// this product.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publisherProfileId")]
        public virtual string PublisherProfileId { get; set; }

        /// <summary>Information about the seller that created this product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seller")]
        public virtual Seller Seller { get; set; }

        /// <summary>The syndication product associated with the deal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syndicationProduct")]
        public virtual string SyndicationProduct { get; set; }

        /// <summary>
        /// Targeting that is shared between the buyer and the seller. Each targeting criterion has a specified key and
        /// for each key there is a list of inclusion value or exclusion values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetingCriterion")]
        public virtual System.Collections.Generic.IList<TargetingCriteria> TargetingCriterion { get; set; }

        /// <summary>The negotiable terms of the deal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("terms")]
        public virtual DealTerms Terms { get; set; }

        /// <summary>Time of last update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>
        /// The web-property code for the seller. This needs to be copied as is when adding a new deal to a proposal.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webPropertyCode")]
        public virtual string WebPropertyCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a proposal in the Marketplace. A proposal is the unit of negotiation between a seller and a buyer and
    /// contains deals which are served. Note: You can't update, create, or otherwise modify Private Auction deals
    /// through the API. Fields are updatable unless noted otherwise.
    /// </summary>
    public class Proposal : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Reference to the buyer that will get billed for this proposal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billedBuyer")]
        public virtual Buyer BilledBuyer { get; set; }

        /// <summary>
        /// Reference to the buyer on the proposal. Note: This field may be set only when creating the resource.
        /// Modifying this field while updating the resource will result in an error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buyer")]
        public virtual Buyer Buyer { get; set; }

        /// <summary>Contact information for the buyer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buyerContacts")]
        public virtual System.Collections.Generic.IList<ContactInformation> BuyerContacts { get; set; }

        /// <summary>Private data for buyer. (hidden from seller).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buyerPrivateData")]
        public virtual PrivateData BuyerPrivateData { get; set; }

        /// <summary>
        /// The deals associated with this proposal. For Private Auction proposals (whose deals have
        /// NonGuaranteedAuctionTerms), there will only be one deal.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deals")]
        public virtual System.Collections.Generic.IList<Deal> Deals { get; set; }

        /// <summary>The name for the proposal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. True if the proposal is being renegotiated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isRenegotiating")]
        public virtual System.Nullable<bool> IsRenegotiating { get; set; }

        /// <summary>Output only. True, if the buyside inventory setup is complete for this proposal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isSetupComplete")]
        public virtual System.Nullable<bool> IsSetupComplete { get; set; }

        /// <summary>
        /// Output only. The role of the last user that either updated the proposal or left a comment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdaterOrCommentorRole")]
        public virtual string LastUpdaterOrCommentorRole { get; set; }

        /// <summary>Output only. The notes associated with this proposal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notes")]
        public virtual System.Collections.Generic.IList<Note> Notes { get; set; }

        /// <summary>Output only. Indicates whether the buyer/seller created the proposal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originatorRole")]
        public virtual string OriginatorRole { get; set; }

        /// <summary>Output only. Private auction ID if this proposal is a private auction proposal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateAuctionId")]
        public virtual string PrivateAuctionId { get; set; }

        /// <summary>Output only. The unique ID of the proposal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proposalId")]
        public virtual string ProposalId { get; set; }

        /// <summary>
        /// Output only. The revision number for the proposal. Each update to the proposal or the deal causes the
        /// proposal revision number to auto-increment. The buyer keeps track of the last revision number they know of
        /// and pass it in when making an update. If the head revision number on the server has since incremented, then
        /// an ABORTED error is returned during the update operation to let the buyer know that a subsequent update was
        /// made.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proposalRevision")]
        public virtual System.Nullable<long> ProposalRevision { get; set; }

        /// <summary>Output only. The current state of the proposal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proposalState")]
        public virtual string ProposalState { get; set; }

        /// <summary>
        /// Reference to the seller on the proposal. Note: This field may be set only when creating the resource.
        /// Modifying this field while updating the resource will result in an error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seller")]
        public virtual Seller Seller { get; set; }

        /// <summary>Output only. Contact information for the seller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sellerContacts")]
        public virtual System.Collections.Generic.IList<ContactInformation> SellerContacts { get; set; }

        /// <summary>Output only. The terms and conditions set by the publisher for this proposal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("termsAndConditions")]
        public virtual string TermsAndConditions { get; set; }

        /// <summary>Output only. The time when the proposal was last revised.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a publisher profile (https://support.google.com/admanager/answer/6035806) in Marketplace. All fields
    /// are read only. All string fields are free-form text entered by the publisher unless noted otherwise.
    /// </summary>
    public class PublisherProfile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description on the publisher's audience.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audienceDescription")]
        public virtual string AudienceDescription { get; set; }

        /// <summary>
        /// Statement explaining what's unique about publisher's business, and why buyers should partner with the
        /// publisher.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buyerPitchStatement")]
        public virtual string BuyerPitchStatement { get; set; }

        /// <summary>
        /// Contact information for direct reservation deals. This is free text entered by the publisher and may include
        /// information like names, phone numbers and email addresses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("directDealsContact")]
        public virtual string DirectDealsContact { get; set; }

        /// <summary>Name of the publisher profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The list of domains represented in this publisher profile. Empty if this is a parent profile. These are top
        /// private domains, meaning that these will not contain a string like "photos.google.co.uk/123", but will
        /// instead contain "google.co.uk".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domains")]
        public virtual System.Collections.Generic.IList<string> Domains { get; set; }

        /// <summary>URL to publisher's Google+ page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googlePlusUrl")]
        public virtual string GooglePlusUrl { get; set; }

        /// <summary>
        /// Indicates if this profile is the parent profile of the seller. A parent profile represents all the inventory
        /// from the seller, as opposed to child profile that is created to brand a portion of inventory. One seller
        /// should have only one parent publisher profile, and can have multiple child profiles. Publisher profiles for
        /// the same seller will have same value of field google.ads.adexchange.buyer.v2beta1.PublisherProfile.seller.
        /// See https://support.google.com/admanager/answer/6035806 for details.
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

        /// <summary>Overview of the publisher.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overview")]
        public virtual string Overview { get; set; }

        /// <summary>
        /// Contact information for programmatic deals. This is free text entered by the publisher and may include
        /// information like names, phone numbers and email addresses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("programmaticDealsContact")]
        public virtual string ProgrammaticDealsContact { get; set; }

        /// <summary>Unique ID for publisher profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publisherProfileId")]
        public virtual string PublisherProfileId { get; set; }

        /// <summary>URL to a publisher rate card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rateCardInfoUrl")]
        public virtual string RateCardInfoUrl { get; set; }

        /// <summary>URL to a sample content page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("samplePageUrl")]
        public virtual string SamplePageUrl { get; set; }

        /// <summary>Seller of the publisher profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seller")]
        public virtual Seller Seller { get; set; }

        /// <summary>
        /// Up to three key metrics and rankings. Max 100 characters each. For example "#1 Mobile News Site for 20
        /// Straight Months".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topHeadlines")]
        public virtual System.Collections.Generic.IList<string> TopHeadlines { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A mobile application that contains a external app ID, name, and app store.</summary>
    public class PublisherProfileMobileApplication : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The app store the app belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appStore")]
        public virtual string AppStore { get; set; }

        /// <summary>The external ID for the app from its app store.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalAppId")]
        public virtual string ExternalAppId { get; set; }

        /// <summary>The name of the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An open-ended realtime time range specified by the start timestamp. For filter sets that specify a realtime time
    /// range RTB metrics continue to be aggregated throughout the lifetime of the filter set.
    /// </summary>
    public class RealtimeTimeRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The start timestamp of the real-time RTB metrics aggregation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTimestamp")]
        public virtual object StartTimestamp { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A relative date range, specified by an offset and a duration. The supported range of dates begins 30 days before
    /// today and ends today, i.e., the limits for these values are: offset_days &amp;gt;= 0 duration_days &amp;gt;= 1
    /// offset_days + duration_days &amp;lt;= 30
    /// </summary>
    public class RelativeDateRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The number of days in the requested date range, e.g., for a range spanning today: 1. For a range spanning
        /// the last 7 days: 7.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("durationDays")]
        public virtual System.Nullable<int> DurationDays { get; set; }

        /// <summary>
        /// The end date of the filter set, specified as the number of days before today, e.g., for a range where the
        /// last date is today: 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offsetDays")]
        public virtual System.Nullable<int> OffsetDays { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request for removing the association between a deal and a creative.</summary>
    public class RemoveDealAssociationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The association between a creative and a deal that should be removed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("association")]
        public virtual CreativeDealAssociation Association { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message to resume (unpause) serving for already-finalized deals.</summary>
    public class ResumeProposalDealsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The external_deal_id's of the deals to resume. If empty, all the deals in the proposal will be resumed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalDealIds")]
        public virtual System.Collections.Generic.IList<string> ExternalDealIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message to resume (unpause) serving for an already-finalized proposal.</summary>
    public class ResumeProposalRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A response may include multiple rows, breaking down along various dimensions. Encapsulates the values of all
    /// dimensions for a given row.
    /// </summary>
    public class RowDimensions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The publisher identifier for this row, if a breakdown by
        /// [BreakdownDimension.PUBLISHER_IDENTIFIER](https://developers.google.com/authorized-buyers/apis/reference/rest/v2beta1/bidders.accounts.filterSets#FilterSet.BreakdownDimension)
        /// was requested.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publisherIdentifier")]
        public virtual string PublisherIdentifier { get; set; }

        /// <summary>The time interval that this row represents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeInterval")]
        public virtual TimeInterval TimeInterval { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Output only. A security context.</summary>
    public class SecurityContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The security types in this context.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securities")]
        public virtual System.Collections.Generic.IList<string> Securities { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a seller of inventory. Each seller is identified by a unique Ad Manager account ID.
    /// </summary>
    public class Seller : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The unique ID for the seller. The seller fills in this field. The seller account ID is then available to
        /// buyer in the product.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        /// <summary>Optional sub-account ID for the seller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subAccountId")]
        public virtual string SubAccountId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The serving context for this restriction.</summary>
    public class ServingContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Matches all contexts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("all")]
        public virtual string All { get; set; }

        /// <summary>Matches impressions for a particular app type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appType")]
        public virtual AppContext AppType { get; set; }

        /// <summary>Matches impressions for a particular auction type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auctionType")]
        public virtual AuctionContext AuctionType { get; set; }

        /// <summary>Matches impressions coming from users *or* publishers in a specific location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual LocationContext Location { get; set; }

        /// <summary>Matches impressions coming from a particular platform.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platform")]
        public virtual PlatformContext Platform { get; set; }

        /// <summary>Matches impressions for a particular security type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityType")]
        public virtual SecurityContext SecurityType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Output only. A representation of the status of an ad in a specific context. A context here relates to where
    /// something ultimately serves (for example, a user or publisher geo, a platform, an HTTPS vs HTTP request, or the
    /// type of auction).
    /// </summary>
    public class ServingRestriction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The contexts for the restriction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contexts")]
        public virtual System.Collections.Generic.IList<ServingContext> Contexts { get; set; }

        /// <summary>
        /// Disapproval bound to this restriction. Only present if status=DISAPPROVED. Can be used to filter the
        /// response of the creatives.list method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disapproval")]
        public virtual Disapproval Disapproval { get; set; }

        /// <summary>
        /// Any disapprovals bound to this restriction. Only present if status=DISAPPROVED. Can be used to filter the
        /// response of the creatives.list method. Deprecated; please use disapproval field instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disapprovalReasons")]
        public virtual System.Collections.Generic.IList<Disapproval> DisapprovalReasons { get; set; }

        /// <summary>
        /// The status of the creative in this context (for example, it has been explicitly disapproved or is pending
        /// review).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Message depicting the size of the creative. The units of width and height depend on the type of the targeting.
    /// </summary>
    public class Size : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The height of the creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual System.Nullable<int> Height { get; set; }

        /// <summary>The width of the creative</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<int> Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request for stopping notifications for changes to creative Status.</summary>
    public class StopWatchingCreativeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Advertisers can target different attributes of an ad slot. For example, they can choose to show ads only if the
    /// user is in the U.S. Such targeting criteria can be specified as part of Shared Targeting.
    /// </summary>
    public class TargetingCriteria : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of values to exclude from targeting. Each value is AND'd together.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exclusions")]
        public virtual System.Collections.Generic.IList<TargetingValue> Exclusions { get; set; }

        /// <summary>The list of value to include as part of the targeting. Each value is OR'd together.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inclusions")]
        public virtual System.Collections.Generic.IList<TargetingValue> Inclusions { get; set; }

        /// <summary>
        /// The key representing the shared targeting criterion. Targeting criteria defined by Google ad servers will
        /// begin with GOOG_. Third parties may define their own keys. A list of permissible keys along with the
        /// acceptable values will be provided as part of the external documentation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A polymorphic targeting value used as part of Shared Targeting.</summary>
    public class TargetingValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The creative size value to include/exclude. Filled in when key = GOOG_CREATIVE_SIZE</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativeSizeValue")]
        public virtual CreativeSize CreativeSizeValue { get; set; }

        /// <summary>
        /// The daypart targeting to include / exclude. Filled in when the key is GOOG_DAYPART_TARGETING. The definition
        /// of this targeting is derived from the structure used by Ad Manager.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dayPartTargetingValue")]
        public virtual DayPartTargeting DayPartTargetingValue { get; set; }

        /// <summary>The long value to include/exclude.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longValue")]
        public virtual System.Nullable<long> LongValue { get; set; }

        /// <summary>The string value to include/exclude.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

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

    /// <summary>An interval of time, with an absolute start and end.</summary>
    public class TimeInterval : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The timestamp marking the end of the range (exclusive) for which data is included.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>The timestamp marking the start of the range (inclusive) for which data is included.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

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

    /// <summary>
    /// Represents a list of targeted and excluded URLs (e.g., google.com). For Private Auction and AdX Preferred Deals,
    /// URLs are either included or excluded. For Programmatic Guaranteed and Preferred Deals, this doesn't apply.
    /// </summary>
    public class UrlTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of URLs to be excluded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedUrls")]
        public virtual System.Collections.Generic.IList<string> ExcludedUrls { get; set; }

        /// <summary>A list of URLs to be included.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetedUrls")]
        public virtual System.Collections.Generic.IList<string> TargetedUrls { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Video content for a creative.</summary>
    public class VideoContent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The URL to fetch a video ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoUrl")]
        public virtual string VideoUrl { get; set; }

        /// <summary>
        /// The contents of a VAST document for a video ad. This document should conform to the VAST 2.0 or 3.0
        /// standard.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoVastXml")]
        public virtual string VideoVastXml { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents targeting information about video.</summary>
    public class VideoTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of video positions to be excluded. Position types can either be included or excluded (XOR).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedPositionTypes")]
        public virtual System.Collections.Generic.IList<string> ExcludedPositionTypes { get; set; }

        /// <summary>
        /// A list of video positions to be included. When the included list is present, the excluded list must be
        /// empty. When the excluded list is present, the included list must be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetedPositionTypes")]
        public virtual System.Collections.Generic.IList<string> TargetedPositionTypes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request for watching changes to creative Status.</summary>
    public class WatchCreativeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The Pub/Sub topic to publish notifications to. This topic must already exist and must give permission to
        /// ad-exchange-buyside-reports@google.com to write to the topic. This should be the full resource name in
        /// "projects/{project_id}/topics/{topic_id}" format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topic")]
        public virtual string Topic { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
