// Copyright 2026 Google LLC
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

namespace Google.Apis.DataManager.v1
{
    /// <summary>The DataManager Service.</summary>
    public class DataManagerService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DataManagerService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DataManagerService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            AccountTypes = new AccountTypesResource(this);
            AudienceMembers = new AudienceMembersResource(this);
            Events = new EventsResource(this);
            RequestStatus = new RequestStatusResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://datamanager.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://datamanager.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "datamanager";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Data Manager API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, create, import, or delete your customer data in Google Ads, Google Marketing Platform
            /// (Campaign Manager 360, Search Ads 360, Display &amp;amp; Video 360), and Google Analytics
            /// </summary>
            public static string Datamanager = "https://www.googleapis.com/auth/datamanager";

            /// <summary>
            /// View, create, or delete your partner links in Google Ads, Marketing Platform (Campaign Manager 360,
            /// Search Ads 360, Display &amp;amp; Video 360), and Analytics
            /// </summary>
            public static string DatamanagerPartnerlink = "https://www.googleapis.com/auth/datamanager.partnerlink";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Data Manager API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, create, import, or delete your customer data in Google Ads, Google Marketing Platform
            /// (Campaign Manager 360, Search Ads 360, Display &amp;amp; Video 360), and Google Analytics
            /// </summary>
            public const string Datamanager = "https://www.googleapis.com/auth/datamanager";

            /// <summary>
            /// View, create, or delete your partner links in Google Ads, Marketing Platform (Campaign Manager 360,
            /// Search Ads 360, Display &amp;amp; Video 360), and Analytics
            /// </summary>
            public const string DatamanagerPartnerlink = "https://www.googleapis.com/auth/datamanager.partnerlink";
        }

        /// <summary>Gets the AccountTypes resource.</summary>
        public virtual AccountTypesResource AccountTypes { get; }

        /// <summary>Gets the AudienceMembers resource.</summary>
        public virtual AudienceMembersResource AudienceMembers { get; }

        /// <summary>Gets the Events resource.</summary>
        public virtual EventsResource Events { get; }

        /// <summary>Gets the RequestStatus resource.</summary>
        public virtual RequestStatusResource RequestStatus { get; }
    }

    /// <summary>A base abstract class for DataManager requests.</summary>
    public abstract class DataManagerBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new DataManagerBaseServiceRequest instance.</summary>
        protected DataManagerBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes DataManager parameter list.</summary>
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

    /// <summary>The "accountTypes" collection of methods.</summary>
    public class AccountTypesResource
    {
        private const string Resource = "accountTypes";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AccountTypesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Accounts = new AccountsResource(service);
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
                Insights = new InsightsResource(service);
                PartnerLinks = new PartnerLinksResource(service);
                UserListDirectLicenses = new UserListDirectLicensesResource(service);
                UserListGlobalLicenses = new UserListGlobalLicensesResource(service);
                UserLists = new UserListsResource(service);
            }

            /// <summary>Gets the Insights resource.</summary>
            public virtual InsightsResource Insights { get; }

            /// <summary>The "insights" collection of methods.</summary>
            public class InsightsResource
            {
                private const string Resource = "insights";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public InsightsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Retrieves marketing data insights for a given user list. This feature is only available to data
                /// partners. Authorization Headers: This method supports the following optional headers to define how
                /// the API authorizes access for the request: * `login-account`: (Optional) The resource name of the
                /// account where the Google Account of the credentials is a user. If not set, defaults to the account
                /// of the request. Format: `accountTypes/{loginAccountType}/accounts/{loginAccountId}` *
                /// `linked-account`: (Optional) The resource name of the account with an established product link to
                /// the `login-account`. Format: `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent account that owns the user list. Format:
                /// `accountTypes/{account_type}/accounts/{account}`
                /// </param>
                public virtual RetrieveRequest Retrieve(Google.Apis.DataManager.v1.Data.RetrieveInsightsRequest body, string parent)
                {
                    return new RetrieveRequest(this.service, body, parent);
                }

                /// <summary>
                /// Retrieves marketing data insights for a given user list. This feature is only available to data
                /// partners. Authorization Headers: This method supports the following optional headers to define how
                /// the API authorizes access for the request: * `login-account`: (Optional) The resource name of the
                /// account where the Google Account of the credentials is a user. If not set, defaults to the account
                /// of the request. Format: `accountTypes/{loginAccountType}/accounts/{loginAccountId}` *
                /// `linked-account`: (Optional) The resource name of the account with an established product link to
                /// the `login-account`. Format: `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
                /// </summary>
                public class RetrieveRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.RetrieveInsightsResponse>
                {
                    /// <summary>Constructs a new Retrieve request.</summary>
                    public RetrieveRequest(Google.Apis.Services.IClientService service, Google.Apis.DataManager.v1.Data.RetrieveInsightsRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent account that owns the user list. Format:
                    /// `accountTypes/{account_type}/accounts/{account}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataManager.v1.Data.RetrieveInsightsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "retrieve";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/insights:retrieve";

                    /// <summary>Initializes Retrieve parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^accountTypes/[^/]+/accounts/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the PartnerLinks resource.</summary>
            public virtual PartnerLinksResource PartnerLinks { get; }

            /// <summary>The "partnerLinks" collection of methods.</summary>
            public class PartnerLinksResource
            {
                private const string Resource = "partnerLinks";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public PartnerLinksResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Creates a partner link for the given account. Authorization Headers: This method supports the
                /// following optional headers to define how the API authorizes access for the request: *
                /// `login-account`: (Optional) The resource name of the account where the Google Account of the
                /// credentials is a user. If not set, defaults to the account of the request. Format:
                /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent, which owns this collection of partner links. Format:
                /// accountTypes/{account_type}/accounts/{account}
                /// </param>
                public virtual CreateRequest Create(Google.Apis.DataManager.v1.Data.PartnerLink body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Creates a partner link for the given account. Authorization Headers: This method supports the
                /// following optional headers to define how the API authorizes access for the request: *
                /// `login-account`: (Optional) The resource name of the account where the Google Account of the
                /// credentials is a user. If not set, defaults to the account of the request. Format:
                /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
                /// </summary>
                public class CreateRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.PartnerLink>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DataManager.v1.Data.PartnerLink body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent, which owns this collection of partner links. Format:
                    /// accountTypes/{account_type}/accounts/{account}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataManager.v1.Data.PartnerLink Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/partnerLinks";

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
                            Pattern = @"^accountTypes/[^/]+/accounts/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Deletes a partner link for the given account. Authorization Headers: This method supports the
                /// following optional headers to define how the API authorizes access for the request: *
                /// `login-account`: (Optional) The resource name of the account where the Google Account of the
                /// credentials is a user. If not set, defaults to the account of the request. Format:
                /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
                /// </summary>
                /// <param name="name">
                /// Required. The resource name of the partner link to delete. Format:
                /// accountTypes/{account_type}/accounts/{account}/partnerLinks/{partner_link}
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes a partner link for the given account. Authorization Headers: This method supports the
                /// following optional headers to define how the API authorizes access for the request: *
                /// `login-account`: (Optional) The resource name of the account where the Google Account of the
                /// credentials is a user. If not set, defaults to the account of the request. Format:
                /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
                /// </summary>
                public class DeleteRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the partner link to delete. Format:
                    /// accountTypes/{account_type}/accounts/{account}/partnerLinks/{partner_link}
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
                            Pattern = @"^accountTypes/[^/]+/accounts/[^/]+/partnerLinks/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Searches for all partner links to and from a given account. Authorization Headers: This method
                /// supports the following optional headers to define how the API authorizes access for the request: *
                /// `login-account`: (Optional) The resource name of the account where the Google Account of the
                /// credentials is a user. If not set, defaults to the account of the request. Format:
                /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
                /// </summary>
                /// <param name="parent">
                /// Required. Account to search for partner links. If no `filter` is specified, all partner links where
                /// this account is either the `owning_account` or `partner_account` are returned. Format:
                /// `accountTypes/{account_type}/accounts/{account}`
                /// </param>
                public virtual SearchRequest Search(string parent)
                {
                    return new SearchRequest(this.service, parent);
                }

                /// <summary>
                /// Searches for all partner links to and from a given account. Authorization Headers: This method
                /// supports the following optional headers to define how the API authorizes access for the request: *
                /// `login-account`: (Optional) The resource name of the account where the Google Account of the
                /// credentials is a user. If not set, defaults to the account of the request. Format:
                /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
                /// </summary>
                public class SearchRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.SearchPartnerLinksResponse>
                {
                    /// <summary>Constructs a new Search request.</summary>
                    public SearchRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Account to search for partner links. If no `filter` is specified, all partner links
                    /// where this account is either the `owning_account` or `partner_account` are returned. Format:
                    /// `accountTypes/{account_type}/accounts/{account}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. A [filter string](https://google.aip.dev/160). All fields need to be on the left hand
                    /// side of each condition (for example: `partner_link_id = 123456789`). Fields must be specified
                    /// using either all [camel case](https://en.wikipedia.org/wiki/Camel_case) or all [snake
                    /// case](https://en.wikipedia.org/wiki/Snake_case). Don't use a combination of camel case and snake
                    /// case. Supported operations: - `AND` - `=` - `!=` Supported fields: - `partner_link_id` -
                    /// `owning_account.account_type` - `owning_account.account_id` - `partner_account.account_type` -
                    /// `partner_account.account_id` Example: `owning_account.account_type = "GOOGLE_ADS" AND
                    /// partner_account.account_id = 987654321`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// The maximum number of partner links to return. The service may return fewer than this value. If
                    /// unspecified, at most 10 partner links will be returned. The maximum value is 100; values above
                    /// 100 will be coerced to 100.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `SearchPartnerLinks` call. Provide this to retrieve the
                    /// subsequent page. When paginating, all other parameters provided to `SearchPartnerLinks` must
                    /// match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "search";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/partnerLinks:search";

                    /// <summary>Initializes Search parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^accountTypes/[^/]+/accounts/[^/]+$",
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

            /// <summary>Gets the UserListDirectLicenses resource.</summary>
            public virtual UserListDirectLicensesResource UserListDirectLicenses { get; }

            /// <summary>The "userListDirectLicenses" collection of methods.</summary>
            public class UserListDirectLicensesResource
            {
                private const string Resource = "userListDirectLicenses";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public UserListDirectLicensesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Creates a user list direct license. This feature is only available to data partners.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The account that owns the user list being licensed. Should be in the format
                /// accountTypes/{ACCOUNT_TYPE}/accounts/{ACCOUNT_ID}
                /// </param>
                public virtual CreateRequest Create(Google.Apis.DataManager.v1.Data.UserListDirectLicense body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Creates a user list direct license. This feature is only available to data partners.
                /// </summary>
                public class CreateRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.UserListDirectLicense>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DataManager.v1.Data.UserListDirectLicense body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The account that owns the user list being licensed. Should be in the format
                    /// accountTypes/{ACCOUNT_TYPE}/accounts/{ACCOUNT_ID}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataManager.v1.Data.UserListDirectLicense Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/userListDirectLicenses";

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
                            Pattern = @"^accountTypes/[^/]+/accounts/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Retrieves a user list direct license. This feature is only available to data partners.
                /// </summary>
                /// <param name="name">Required. The resource name of the user list direct license.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>
                /// Retrieves a user list direct license. This feature is only available to data partners.
                /// </summary>
                public class GetRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.UserListDirectLicense>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The resource name of the user list direct license.</summary>
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
                            Pattern = @"^accountTypes/[^/]+/accounts/[^/]+/userListDirectLicenses/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists all user list direct licenses owned by the parent account. This feature is only available to
                /// data partners.
                /// </summary>
                /// <param name="parent">
                /// Required. The account whose licenses are being queried. Should be in the format
                /// accountTypes/{ACCOUNT_TYPE}/accounts/{ACCOUNT_ID}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// Lists all user list direct licenses owned by the parent account. This feature is only available to
                /// data partners.
                /// </summary>
                public class ListRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.ListUserListDirectLicensesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The account whose licenses are being queried. Should be in the format
                    /// accountTypes/{ACCOUNT_TYPE}/accounts/{ACCOUNT_ID}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. A [filter string](https://google.aip.dev/160) to apply to the list request. All fields
                    /// need to be on the left hand side of each condition (for example: `user_list_id = 123`). Fields
                    /// must be specified using either all [camel case](https://en.wikipedia.org/wiki/Camel_case) or all
                    /// [snake case](https://en.wikipedia.org/wiki/Snake_case). Don't use a combination of camel case
                    /// and snake case. **Supported Operations:** - `AND` - `=` - `!=` - `&amp;gt;` - `&amp;gt;=` -
                    /// `&amp;lt;` - `&amp;lt;=` **Unsupported Fields:** - `name` (use get method instead) -
                    /// `historical_pricings` and all its subfields - `pricing.start_time` - `pricing.end_time`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of licenses to return per page. The service may return fewer than
                    /// this value. If unspecified, at most 50 licenses will be returned. The maximum value is 1000;
                    /// values above 1000 will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `ListUserListDirectLicense` call. Provide this
                    /// to retrieve the subsequent page. When paginating, all other parameters provided to
                    /// `ListUserListDirectLicense` must match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/userListDirectLicenses";

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
                            Pattern = @"^accountTypes/[^/]+/accounts/[^/]+$",
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
                /// Updates a user list direct license. This feature is only available to data partners.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Identifier. The resource name of the user list direct license.</param>
                public virtual PatchRequest Patch(Google.Apis.DataManager.v1.Data.UserListDirectLicense body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>
                /// Updates a user list direct license. This feature is only available to data partners.
                /// </summary>
                public class PatchRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.UserListDirectLicense>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DataManager.v1.Data.UserListDirectLicense body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Identifier. The resource name of the user list direct license.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. The list of fields to update. The special character `*` is not supported and an
                    /// `INVALID_UPDATE_MASK` error will be thrown if used.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataManager.v1.Data.UserListDirectLicense Body { get; set; }

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
                            Pattern = @"^accountTypes/[^/]+/accounts/[^/]+/userListDirectLicenses/[^/]+$",
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

            /// <summary>Gets the UserListGlobalLicenses resource.</summary>
            public virtual UserListGlobalLicensesResource UserListGlobalLicenses { get; }

            /// <summary>The "userListGlobalLicenses" collection of methods.</summary>
            public class UserListGlobalLicensesResource
            {
                private const string Resource = "userListGlobalLicenses";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public UserListGlobalLicensesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    UserListGlobalLicenseCustomerInfos = new UserListGlobalLicenseCustomerInfosResource(service);
                }

                /// <summary>Gets the UserListGlobalLicenseCustomerInfos resource.</summary>
                public virtual UserListGlobalLicenseCustomerInfosResource UserListGlobalLicenseCustomerInfos { get; }

                /// <summary>The "userListGlobalLicenseCustomerInfos" collection of methods.</summary>
                public class UserListGlobalLicenseCustomerInfosResource
                {
                    private const string Resource = "userListGlobalLicenseCustomerInfos";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public UserListGlobalLicenseCustomerInfosResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Lists all customer info for a user list global license. This feature is only available to data
                    /// partners.
                    /// </summary>
                    /// <param name="parent">
                    /// Required. The global license whose customer info are being queried. Should be in the format
                    /// `accountTypes/{ACCOUNT_TYPE}/accounts/{ACCOUNT_ID}/userListGlobalLicenses/{USER_LIST_GLOBAL_LICENSE_ID}`.
                    /// To list all global license customer info under an account, replace the user list global license
                    /// id with a '-' (for example, `accountTypes/DATA_PARTNER/accounts/123/userListGlobalLicenses/-`)
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>
                    /// Lists all customer info for a user list global license. This feature is only available to data
                    /// partners.
                    /// </summary>
                    public class ListRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.ListUserListGlobalLicenseCustomerInfosResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The global license whose customer info are being queried. Should be in the format
                        /// `accountTypes/{ACCOUNT_TYPE}/accounts/{ACCOUNT_ID}/userListGlobalLicenses/{USER_LIST_GLOBAL_LICENSE_ID}`.
                        /// To list all global license customer info under an account, replace the user list global
                        /// license id with a '-' (for example,
                        /// `accountTypes/DATA_PARTNER/accounts/123/userListGlobalLicenses/-`)
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. A [filter string](https://google.aip.dev/160) to apply to the list request. All
                        /// fields need to be on the left hand side of each condition (for example: `user_list_id =
                        /// 123`). Fields must be specified using either all [camel
                        /// case](https://en.wikipedia.org/wiki/Camel_case) or all [snake
                        /// case](https://en.wikipedia.org/wiki/Snake_case). Don't use a combination of camel case and
                        /// snake case. **Supported Operations:** - `AND` - `=` - `!=` - `&amp;gt;` - `&amp;gt;=` -
                        /// `&amp;lt;` - `&amp;lt;=` **Unsupported Fields:** - `name` (use get method instead) -
                        /// `historical_pricings` and all its subfields - `pricing.start_time` - `pricing.end_time`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. The maximum number of licenses to return. The service may return fewer than this
                        /// value. If unspecified, at most 50 licenses will be returned. The maximum value is 1000;
                        /// values above 1000 will be coerced to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. A page token, received from a previous `ListUserListDirectLicense` call. Provide
                        /// this to retrieve the subsequent page. When paginating, all other parameters provided to
                        /// `ListUserListDirectLicense` must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/userListGlobalLicenseCustomerInfos";

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
                                Pattern = @"^accountTypes/[^/]+/accounts/[^/]+/userListGlobalLicenses/[^/]+$",
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

                /// <summary>
                /// Creates a user list global license. This feature is only available to data partners.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The account that owns the user list being licensed. Should be in the format
                /// accountTypes/{ACCOUNT_TYPE}/accounts/{ACCOUNT_ID}
                /// </param>
                public virtual CreateRequest Create(Google.Apis.DataManager.v1.Data.UserListGlobalLicense body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Creates a user list global license. This feature is only available to data partners.
                /// </summary>
                public class CreateRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.UserListGlobalLicense>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DataManager.v1.Data.UserListGlobalLicense body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The account that owns the user list being licensed. Should be in the format
                    /// accountTypes/{ACCOUNT_TYPE}/accounts/{ACCOUNT_ID}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataManager.v1.Data.UserListGlobalLicense Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/userListGlobalLicenses";

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
                            Pattern = @"^accountTypes/[^/]+/accounts/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Retrieves a user list global license. This feature is only available to data partners.
                /// </summary>
                /// <param name="name">Required. The resource name of the user list global license.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>
                /// Retrieves a user list global license. This feature is only available to data partners.
                /// </summary>
                public class GetRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.UserListGlobalLicense>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The resource name of the user list global license.</summary>
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
                            Pattern = @"^accountTypes/[^/]+/accounts/[^/]+/userListGlobalLicenses/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists all user list global licenses owned by the parent account. This feature is only available to
                /// data partners.
                /// </summary>
                /// <param name="parent">
                /// Required. The account whose licenses are being queried. Should be in the format
                /// accountTypes/{ACCOUNT_TYPE}/accounts/{ACCOUNT_ID}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// Lists all user list global licenses owned by the parent account. This feature is only available to
                /// data partners.
                /// </summary>
                public class ListRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.ListUserListGlobalLicensesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The account whose licenses are being queried. Should be in the format
                    /// accountTypes/{ACCOUNT_TYPE}/accounts/{ACCOUNT_ID}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. A [filter string](https://google.aip.dev/160) to apply to the list request. All fields
                    /// need to be on the left hand side of each condition (for example: `user_list_id = 123`). Fields
                    /// must be specified using either all [camel case](https://en.wikipedia.org/wiki/Camel_case) or all
                    /// [snake case](https://en.wikipedia.org/wiki/Snake_case). Don't use a combination of camel case
                    /// and snake case. **Supported Operations:** - `AND` - `=` - `!=` - `&amp;gt;` - `&amp;gt;=` -
                    /// `&amp;lt;` - `&amp;lt;=` **Unsupported Fields:** - `name` (use get method instead) -
                    /// `historical_pricings` and all its subfields - `pricing.start_time` - `pricing.end_time`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of licenses to return. The service may return fewer than this
                    /// value. If unspecified, at most 50 licenses will be returned. The maximum value is 1000; values
                    /// above 1000 will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `ListUserListGlobalLicense` call. Provide this
                    /// to retrieve the subsequent page. When paginating, all other parameters provided to
                    /// `ListUserListDirectLicense` must match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/userListGlobalLicenses";

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
                            Pattern = @"^accountTypes/[^/]+/accounts/[^/]+$",
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
                /// Updates a user list global license. This feature is only available to data partners.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Identifier. The resource name of the user list global license.</param>
                public virtual PatchRequest Patch(Google.Apis.DataManager.v1.Data.UserListGlobalLicense body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>
                /// Updates a user list global license. This feature is only available to data partners.
                /// </summary>
                public class PatchRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.UserListGlobalLicense>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DataManager.v1.Data.UserListGlobalLicense body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Identifier. The resource name of the user list global license.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. The list of fields to update. The special character `*` is not supported and an
                    /// `INVALID_UPDATE_MASK` error will be thrown if used.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataManager.v1.Data.UserListGlobalLicense Body { get; set; }

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
                            Pattern = @"^accountTypes/[^/]+/accounts/[^/]+/userListGlobalLicenses/[^/]+$",
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

            /// <summary>Gets the UserLists resource.</summary>
            public virtual UserListsResource UserLists { get; }

            /// <summary>The "userLists" collection of methods.</summary>
            public class UserListsResource
            {
                private const string Resource = "userLists";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public UserListsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Creates a UserList. Authorization Headers: This method supports the following optional headers to
                /// define how the API authorizes access for the request: * `login-account`: (Optional) The resource
                /// name of the account where the Google Account of the credentials is a user. If not set, defaults to
                /// the account of the request. Format: `accountTypes/{loginAccountType}/accounts/{loginAccountId}` *
                /// `linked-account`: (Optional) The resource name of the account with an established product link to
                /// the `login-account`. Format: `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent account where this user list will be created. Format:
                /// accountTypes/{account_type}/accounts/{account}
                /// </param>
                public virtual CreateRequest Create(Google.Apis.DataManager.v1.Data.UserList body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Creates a UserList. Authorization Headers: This method supports the following optional headers to
                /// define how the API authorizes access for the request: * `login-account`: (Optional) The resource
                /// name of the account where the Google Account of the credentials is a user. If not set, defaults to
                /// the account of the request. Format: `accountTypes/{loginAccountType}/accounts/{loginAccountId}` *
                /// `linked-account`: (Optional) The resource name of the account with an established product link to
                /// the `login-account`. Format: `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
                /// </summary>
                public class CreateRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.UserList>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DataManager.v1.Data.UserList body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent account where this user list will be created. Format:
                    /// accountTypes/{account_type}/accounts/{account}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. If true, the request is validated but not executed.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataManager.v1.Data.UserList Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/userLists";

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
                            Pattern = @"^accountTypes/[^/]+/accounts/[^/]+$",
                        });
                        RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                        {
                            Name = "validateOnly",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Deletes a UserList. Authorization Headers: This method supports the following optional headers to
                /// define how the API authorizes access for the request: * `login-account`: (Optional) The resource
                /// name of the account where the Google Account of the credentials is a user. If not set, defaults to
                /// the account of the request. Format: `accountTypes/{loginAccountType}/accounts/{loginAccountId}` *
                /// `linked-account`: (Optional) The resource name of the account with an established product link to
                /// the `login-account`. Format: `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
                /// </summary>
                /// <param name="name">
                /// Required. The name of the user list to delete. Format:
                /// accountTypes/{account_type}/accounts/{account}/userLists/{user_list}
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes a UserList. Authorization Headers: This method supports the following optional headers to
                /// define how the API authorizes access for the request: * `login-account`: (Optional) The resource
                /// name of the account where the Google Account of the credentials is a user. If not set, defaults to
                /// the account of the request. Format: `accountTypes/{loginAccountType}/accounts/{loginAccountId}` *
                /// `linked-account`: (Optional) The resource name of the account with an established product link to
                /// the `login-account`. Format: `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
                /// </summary>
                public class DeleteRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the user list to delete. Format:
                    /// accountTypes/{account_type}/accounts/{account}/userLists/{user_list}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Optional. If true, the request is validated but not executed.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

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
                            Pattern = @"^accountTypes/[^/]+/accounts/[^/]+/userLists/[^/]+$",
                        });
                        RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                        {
                            Name = "validateOnly",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Gets a UserList. Authorization Headers: This method supports the following optional headers to
                /// define how the API authorizes access for the request: * `login-account`: (Optional) The resource
                /// name of the account where the Google Account of the credentials is a user. If not set, defaults to
                /// the account of the request. Format: `accountTypes/{loginAccountType}/accounts/{loginAccountId}` *
                /// `linked-account`: (Optional) The resource name of the account with an established product link to
                /// the `login-account`. Format: `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
                /// </summary>
                /// <param name="name">
                /// Required. The resource name of the UserList to retrieve. Format:
                /// accountTypes/{account_type}/accounts/{account}/userLists/{user_list}
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>
                /// Gets a UserList. Authorization Headers: This method supports the following optional headers to
                /// define how the API authorizes access for the request: * `login-account`: (Optional) The resource
                /// name of the account where the Google Account of the credentials is a user. If not set, defaults to
                /// the account of the request. Format: `accountTypes/{loginAccountType}/accounts/{loginAccountId}` *
                /// `linked-account`: (Optional) The resource name of the account with an established product link to
                /// the `login-account`. Format: `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
                /// </summary>
                public class GetRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.UserList>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the UserList to retrieve. Format:
                    /// accountTypes/{account_type}/accounts/{account}/userLists/{user_list}
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
                            Pattern = @"^accountTypes/[^/]+/accounts/[^/]+/userLists/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists UserLists. Authorization Headers: This method supports the following optional headers to
                /// define how the API authorizes access for the request: * `login-account`: (Optional) The resource
                /// name of the account where the Google Account of the credentials is a user. If not set, defaults to
                /// the account of the request. Format: `accountTypes/{loginAccountType}/accounts/{loginAccountId}` *
                /// `linked-account`: (Optional) The resource name of the account with an established product link to
                /// the `login-account`. Format: `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
                /// </summary>
                /// <param name="parent">
                /// Required. The parent account which owns this collection of user lists. Format:
                /// accountTypes/{account_type}/accounts/{account}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// Lists UserLists. Authorization Headers: This method supports the following optional headers to
                /// define how the API authorizes access for the request: * `login-account`: (Optional) The resource
                /// name of the account where the Google Account of the credentials is a user. If not set, defaults to
                /// the account of the request. Format: `accountTypes/{loginAccountType}/accounts/{loginAccountId}` *
                /// `linked-account`: (Optional) The resource name of the account with an established product link to
                /// the `login-account`. Format: `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
                /// </summary>
                public class ListRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.ListUserListsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent account which owns this collection of user lists. Format:
                    /// accountTypes/{account_type}/accounts/{account}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. A [filter string](https://google.aip.dev/160). All fields need to be on the left hand
                    /// side of each condition (for example: `display_name = "list 1"`). Fields must be specified using
                    /// either all [camel case](https://en.wikipedia.org/wiki/Camel_case) or all [snake
                    /// case](https://en.wikipedia.org/wiki/Snake_case). Don't use a combination of camel case and snake
                    /// case. Supported operations: - `AND` - `=` - `!=` - `&amp;gt;` - `&amp;gt;=` - `&amp;lt;` -
                    /// `&amp;lt;=` - `:` (has) Supported fields: - `id` - `display_name` - `description` -
                    /// `membership_status` - `integration_code` - `access_reason` -
                    /// `ingested_user_list_info.upload_key_types`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of user lists to return. The service may return fewer than this
                    /// value. If unspecified, at most 50 user lists will be returned. The maximum value is 1000; values
                    /// above 1000 will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `ListUserLists` call. Provide this to retrieve
                    /// the subsequent page. When paginating, all other parameters provided to `ListUserLists` must
                    /// match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/userLists";

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
                            Pattern = @"^accountTypes/[^/]+/accounts/[^/]+$",
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
                /// Updates a UserList. Authorization Headers: This method supports the following optional headers to
                /// define how the API authorizes access for the request: * `login-account`: (Optional) The resource
                /// name of the account where the Google Account of the credentials is a user. If not set, defaults to
                /// the account of the request. Format: `accountTypes/{loginAccountType}/accounts/{loginAccountId}` *
                /// `linked-account`: (Optional) The resource name of the account with an established product link to
                /// the `login-account`. Format: `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. The resource name of the user list. Format:
                /// accountTypes/{account_type}/accounts/{account}/userLists/{user_list}
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.DataManager.v1.Data.UserList body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>
                /// Updates a UserList. Authorization Headers: This method supports the following optional headers to
                /// define how the API authorizes access for the request: * `login-account`: (Optional) The resource
                /// name of the account where the Google Account of the credentials is a user. If not set, defaults to
                /// the account of the request. Format: `accountTypes/{loginAccountType}/accounts/{loginAccountId}` *
                /// `linked-account`: (Optional) The resource name of the account with an established product link to
                /// the `login-account`. Format: `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
                /// </summary>
                public class PatchRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.UserList>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DataManager.v1.Data.UserList body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. The resource name of the user list. Format:
                    /// accountTypes/{account_type}/accounts/{account}/userLists/{user_list}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Optional. The list of fields to update.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Optional. If true, the request is validated but not executed.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataManager.v1.Data.UserList Body { get; set; }

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
                            Pattern = @"^accountTypes/[^/]+/accounts/[^/]+/userLists/[^/]+$",
                        });
                        RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                        {
                            Name = "updateMask",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                        {
                            Name = "validateOnly",
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

    /// <summary>The "audienceMembers" collection of methods.</summary>
    public class AudienceMembersResource
    {
        private const string Resource = "audienceMembers";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AudienceMembersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Uploads a list of AudienceMember resources to the provided Destination.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual IngestRequest Ingest(Google.Apis.DataManager.v1.Data.IngestAudienceMembersRequest body)
        {
            return new IngestRequest(this.service, body);
        }

        /// <summary>Uploads a list of AudienceMember resources to the provided Destination.</summary>
        public class IngestRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.IngestAudienceMembersResponse>
        {
            /// <summary>Constructs a new Ingest request.</summary>
            public IngestRequest(Google.Apis.Services.IClientService service, Google.Apis.DataManager.v1.Data.IngestAudienceMembersRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DataManager.v1.Data.IngestAudienceMembersRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "ingest";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/audienceMembers:ingest";

            /// <summary>Initializes Ingest parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Removes a list of AudienceMember resources from the provided Destination.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual RemoveRequest Remove(Google.Apis.DataManager.v1.Data.RemoveAudienceMembersRequest body)
        {
            return new RemoveRequest(this.service, body);
        }

        /// <summary>Removes a list of AudienceMember resources from the provided Destination.</summary>
        public class RemoveRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.RemoveAudienceMembersResponse>
        {
            /// <summary>Constructs a new Remove request.</summary>
            public RemoveRequest(Google.Apis.Services.IClientService service, Google.Apis.DataManager.v1.Data.RemoveAudienceMembersRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DataManager.v1.Data.RemoveAudienceMembersRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "remove";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/audienceMembers:remove";

            /// <summary>Initializes Remove parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "events" collection of methods.</summary>
    public class EventsResource
    {
        private const string Resource = "events";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public EventsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Uploads a list of Event resources from the provided Destination.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual IngestRequest Ingest(Google.Apis.DataManager.v1.Data.IngestEventsRequest body)
        {
            return new IngestRequest(this.service, body);
        }

        /// <summary>Uploads a list of Event resources from the provided Destination.</summary>
        public class IngestRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.IngestEventsResponse>
        {
            /// <summary>Constructs a new Ingest request.</summary>
            public IngestRequest(Google.Apis.Services.IClientService service, Google.Apis.DataManager.v1.Data.IngestEventsRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DataManager.v1.Data.IngestEventsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "ingest";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/events:ingest";

            /// <summary>Initializes Ingest parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "requestStatus" collection of methods.</summary>
    public class RequestStatusResource
    {
        private const string Resource = "requestStatus";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public RequestStatusResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Gets the status of a request given request id.</summary>
        public virtual RetrieveRequest Retrieve()
        {
            return new RetrieveRequest(this.service);
        }

        /// <summary>Gets the status of a request given request id.</summary>
        public class RetrieveRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.RetrieveRequestStatusResponse>
        {
            /// <summary>Constructs a new Retrieve request.</summary>
            public RetrieveRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Required. Required. The request ID of the Data Manager API request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string RequestId { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "retrieve";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/requestStatus:retrieve";

            /// <summary>Initializes Retrieve parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                {
                    Name = "requestId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.DataManager.v1.Data
{
    /// <summary>
    /// Identifiers and other information used to match the conversion event with other online activity (such as ad
    /// clicks).
    /// </summary>
    public class AdIdentifiers : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The click identifier for clicks associated with app events and originating from iOS devices
        /// starting with iOS14.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gbraid")]
        public virtual string Gbraid { get; set; }

        /// <summary>Optional. The Google click ID (gclid) associated with this event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gclid")]
        public virtual string Gclid { get; set; }

        /// <summary>
        /// Optional. Information gathered about the device being used (if any) at the time of landing onto the
        /// advertiser’s site after interacting with the ad.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("landingPageDeviceInfo")]
        public virtual DeviceInfo LandingPageDeviceInfo { get; set; }

        /// <summary>Optional. Session attributes for event attribution and modeling.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionAttributes")]
        public virtual string SessionAttributes { get; set; }

        /// <summary>
        /// Optional. The click identifier for clicks associated with web events and originating from iOS devices
        /// starting with iOS14.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wbraid")]
        public virtual string Wbraid { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Address information for the user.</summary>
    public class AddressInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Family (last) name of the user, all lowercase, with no punctuation, no leading or trailing
        /// whitespace, and hashed as SHA-256.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("familyName")]
        public virtual string FamilyName { get; set; }

        /// <summary>
        /// Required. Given (first) name of the user, all lowercase, with no punctuation, no leading or trailing
        /// whitespace, and hashed as SHA-256.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("givenName")]
        public virtual string GivenName { get; set; }

        /// <summary>Required. The postal code of the user's address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCode")]
        public virtual string PostalCode { get; set; }

        /// <summary>Required. The 2-letter region code in ISO-3166-1 alpha-2 of the user's address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The audience member to be operated on.</summary>
    public class AudienceMember : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The consent setting for the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consent")]
        public virtual Consent Consent { get; set; }

        /// <summary>Optional. Defines which Destination to send the audience member to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationReferences")]
        public virtual System.Collections.Generic.IList<string> DestinationReferences { get; set; }

        /// <summary>Data identifying the user's mobile devices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileData")]
        public virtual MobileData MobileData { get; set; }

        /// <summary>
        /// [Publisher Advertiser Identity Reconciliation (PAIR) IDs](//support.google.com/admanager/answer/15067908).
        /// This feature is only available to data partners.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pairData")]
        public virtual PairData PairData { get; set; }

        /// <summary>
        /// Data related to publisher provided identifiers. This feature is only available to data partners.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ppidData")]
        public virtual PpidData PpidData { get; set; }

        /// <summary>User-provided data that identifies the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userData")]
        public virtual UserData UserData { get; set; }

        /// <summary>Data related to unique identifiers for a user, as defined by the advertiser.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userIdData")]
        public virtual UserIdData UserIdData { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A data encryption key wrapped by an AWS KMS key.</summary>
    public class AwsWrappedKeyInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The base64 encoded encrypted data encryption key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptedDek")]
        public virtual string EncryptedDek { get; set; }

        /// <summary>
        /// Required. The URI of the AWS KMS key used to decrypt the DEK. Should be in the format of
        /// `arn:{partition}:kms:{region}:{account_id}:key/{key_id}` or
        /// `aws-kms://arn:{partition}:kms:{region}:{account_id}:key/{key_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kekUri")]
        public virtual string KekUri { get; set; }

        /// <summary>Required. The type of algorithm used to encrypt the data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyType")]
        public virtual string KeyType { get; set; }

        /// <summary>
        /// Required. The Amazon Resource Name of the IAM Role to assume for KMS decryption access. Should be in the
        /// format of `arn:{partition}:iam::{account_id}:role/{role_name}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roleArn")]
        public virtual string RoleArn { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Baseline criteria against which insights are compared.</summary>
    public class Baseline : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The baseline location of the request. Baseline location is an OR-list of the requested regions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baselineLocation")]
        public virtual Location BaselineLocation { get; set; }

        /// <summary>
        /// If set to true, the service will try to automatically detect the baseline location for insights.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationAutoDetectionEnabled")]
        public virtual System.Nullable<bool> LocationAutoDetectionEnabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The cart data associated with the event.</summary>
    public class CartData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The list of items associated with the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Item> Items { get; set; }

        /// <summary>Optional. The Merchant Center feed label associated with the feed of the items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantFeedLabel")]
        public virtual string MerchantFeedLabel { get; set; }

        /// <summary>
        /// Optional. The language code in ISO 639-1 associated with the Merchant Center feed of the items.where your
        /// items are uploaded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantFeedLanguageCode")]
        public virtual string MerchantFeedLanguageCode { get; set; }

        /// <summary>Optional. The Merchant Center ID associated with the items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantId")]
        public virtual string MerchantId { get; set; }

        /// <summary>Optional. The sum of all discounts associated with the transaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transactionDiscount")]
        public virtual System.Nullable<double> TransactionDiscount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// [Digital Markets Act (DMA)](//digital-markets-act.ec.europa.eu/index_en) consent settings for the user.
    /// </summary>
    public class Consent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Represents if the user consents to ad personalization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adPersonalization")]
        public virtual string AdPersonalization { get; set; }

        /// <summary>Optional. Represents if the user consents to ad user data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adUserData")]
        public virtual string AdUserData { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional information when `CONTACT_ID` is one of the `upload_key_types`.</summary>
    public class ContactIdInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Immutable. Source of the upload data</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceType")]
        public virtual string DataSourceType { get; set; }

        /// <summary>Output only. Match rate for customer match user lists.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchRatePercentage")]
        public virtual System.Nullable<int> MatchRatePercentage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Custom variable for ads conversions.</summary>
    public class CustomVariable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Reference string used to determine which of the Event.destination_references the custom variable
        /// should be sent to. If empty, the Event.destination_references will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationReferences")]
        public virtual System.Collections.Generic.IList<string> DestinationReferences { get; set; }

        /// <summary>Optional. The value to store for the custom variable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>
        /// Optional. The name of the custom variable to set. If the variable is not found for the given destination, it
        /// will be ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variable")]
        public virtual string Variable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Google product you're sending data to. For example, a Google Ads account.</summary>
    public class Destination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. An account that the calling user's `login_account` has access to, through an established account
        /// link. For example, a data partner's `login_account` might have access to a client's `linked_account`. The
        /// partner might use this field to send data from the `linked_account` to another `operating_account`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkedAccount")]
        public virtual ProductAccount LinkedAccount { get; set; }

        /// <summary>
        /// Optional. The account used to make this API call. To add or remove data from the `operating_account`, this
        /// `login_account` must have write access to the `operating_account`. For example, a manager account of the
        /// `operating_account`, or an account with an established link to the `operating_account`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loginAccount")]
        public virtual ProductAccount LoginAccount { get; set; }

        /// <summary>Required. The account to send the data to or remove the data from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatingAccount")]
        public virtual ProductAccount OperatingAccount { get; set; }

        /// <summary>
        /// Required. The object within the product account to ingest into. For example, a Google Ads audience ID, a
        /// Display &amp;amp; Video 360 audience ID or a Google Ads conversion action ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productDestinationId")]
        public virtual string ProductDestinationId { get; set; }

        /// <summary>
        /// Optional. ID for this `Destination` resource, unique within the request. Use to reference this `Destination`
        /// in the IngestEventsRequest and IngestAudienceMembersRequest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reference")]
        public virtual string Reference { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the device being used (if any) when the event happened.</summary>
    public class DeviceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The IP address of the device for the given context. **Note:** Google Ads does not support IP
        /// address matching for end users in the European Economic Area (EEA), United Kingdom (UK), or Switzerland
        /// (CH). Add logic to conditionally exclude sharing IP addresses from users from these regions and ensure that
        /// you provide users with clear and comprehensive information about the data you collect on your sites, apps,
        /// and other properties and get consent where required by law or any applicable Google policies. See the [About
        /// offline conversion imports](https://support.google.com/google-ads/answer/2998031) page for more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
        public virtual string IpAddress { get; set; }

        /// <summary>Optional. The user-agent string of the device for the given context.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userAgent")]
        public virtual string UserAgent { get; set; }

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

    /// <summary>Encryption information for the data being ingested.</summary>
    public class EncryptionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Amazon Web Services wrapped key information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("awsWrappedKeyInfo")]
        public virtual AwsWrappedKeyInfo AwsWrappedKeyInfo { get; set; }

        /// <summary>Google Cloud Platform wrapped key information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpWrappedKeyInfo")]
        public virtual GcpWrappedKeyInfo GcpWrappedKeyInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The error count for a given error reason.</summary>
    public class ErrorCount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The error reason of the failed records.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The count of records that failed to upload for a given reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Error counts for each type of error.</summary>
    public class ErrorInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of errors and counts per error reason. May not be populated in all cases.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorCounts")]
        public virtual System.Collections.Generic.IList<ErrorCount> ErrorCounts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An event representing a user interaction with an advertiser's website or app.</summary>
    public class Event : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Identifiers and other information used to match the conversion event with other online activity
        /// (such as ad clicks).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adIdentifiers")]
        public virtual AdIdentifiers AdIdentifiers { get; set; }

        /// <summary>
        /// Optional. A bucket of any [event
        /// parameters](https://developers.google.com/analytics/devguides/collection/protocol/ga4/reference/events) to
        /// be included within the event that were not already specified using other structured fields.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalEventParameters")]
        public virtual System.Collections.Generic.IList<EventParameter> AdditionalEventParameters { get; set; }

        /// <summary>Optional. Information about the transaction and items associated with the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cartData")]
        public virtual CartData CartData { get; set; }

        /// <summary>
        /// Optional. A unique identifier for the user instance of a web client for this GA4 web stream.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>
        /// Optional. Information about whether the associated user has provided different types of consent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consent")]
        public virtual Consent Consent { get; set; }

        /// <summary>Optional. The conversion value associated with the event, for value-based conversions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionValue")]
        public virtual System.Nullable<double> ConversionValue { get; set; }

        /// <summary>Optional. The currency code associated with all monetary values within this event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currency")]
        public virtual string Currency { get; set; }

        /// <summary>
        /// Optional. Additional key/value pair information to send to the conversion containers (conversion action or
        /// FL activity).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customVariables")]
        public virtual System.Collections.Generic.IList<CustomVariable> CustomVariables { get; set; }

        /// <summary>
        /// Optional. Reference string used to determine the destination. If empty, the event will be sent to all
        /// destinations in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationReferences")]
        public virtual System.Collections.Generic.IList<string> DestinationReferences { get; set; }

        /// <summary>
        /// Optional. Information gathered about the device being used (if any) when the event happened.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventDeviceInfo")]
        public virtual DeviceInfo EventDeviceInfo { get; set; }

        /// <summary>Optional. The name of the event. Required for GA4 events.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventName")]
        public virtual string EventName { get; set; }

        /// <summary>Optional. Signal for where the event happened (web, app, in-store, etc.).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventSource")]
        public virtual string EventSource { get; set; }

        private string _eventTimestampRaw;

        private object _eventTimestamp;

        /// <summary>Required. The time the event occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTimestamp")]
        public virtual string EventTimestampRaw
        {
            get => _eventTimestampRaw;
            set
            {
                _eventTimestamp = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _eventTimestampRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EventTimestampRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EventTimestampDateTimeOffset instead.")]
        public virtual object EventTimestamp
        {
            get => _eventTimestamp;
            set
            {
                _eventTimestampRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _eventTimestamp = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="EventTimestampRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EventTimestampDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EventTimestampRaw);
            set => EventTimestampRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Optional. A list of key/value pairs for experimental fields that may eventually be promoted to be part of
        /// the API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("experimentalFields")]
        public virtual System.Collections.Generic.IList<ExperimentalField> ExperimentalFields { get; set; }

        private string _lastUpdatedTimestampRaw;

        private object _lastUpdatedTimestamp;

        /// <summary>Optional. The last time the event was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdatedTimestamp")]
        public virtual string LastUpdatedTimestampRaw
        {
            get => _lastUpdatedTimestampRaw;
            set
            {
                _lastUpdatedTimestamp = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastUpdatedTimestampRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastUpdatedTimestampRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastUpdatedTimestampDateTimeOffset instead.")]
        public virtual object LastUpdatedTimestamp
        {
            get => _lastUpdatedTimestamp;
            set
            {
                _lastUpdatedTimestampRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastUpdatedTimestamp = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastUpdatedTimestampRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastUpdatedTimestampDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastUpdatedTimestampRaw);
            set => LastUpdatedTimestampRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Optional. The unique identifier for this event. Required for conversions using multiple data sources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transactionId")]
        public virtual string TransactionId { get; set; }

        /// <summary>
        /// Optional. Pieces of user provided data, representing the user the event is associated with.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userData")]
        public virtual UserData UserData { get; set; }

        /// <summary>Optional. A unique identifier for a user, as defined by the advertiser.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        /// <summary>
        /// Optional. Advertiser-assessed information about the user at the time that the event happened.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userProperties")]
        public virtual UserProperties UserProperties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Event parameter for GA4 events.</summary>
    public class EventParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The name of the parameter to use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameterName")]
        public virtual string ParameterName { get; set; }

        /// <summary>Required. The string representation of the value of the parameter to set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Experimental field representing unofficial fields.</summary>
    public class ExperimentalField : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The name of the field to use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual string Field { get; set; }

        /// <summary>Optional. The value the field to set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the Google Cloud Platform wrapped key.</summary>
    public class GcpWrappedKeyInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The base64 encoded encrypted data encryption key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptedDek")]
        public virtual string EncryptedDek { get; set; }

        /// <summary>
        /// Required. Google Cloud Platform [Cloud Key Management Service resource
        /// ID](//cloud.google.com/kms/docs/getting-resource-ids). Should be in the format of
        /// `projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{key}` or
        /// `gcp-kms://projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{key}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kekUri")]
        public virtual string KekUri { get; set; }

        /// <summary>Required. The type of algorithm used to encrypt the data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyType")]
        public virtual string KeyType { get; set; }

        /// <summary>
        /// Required. The [Workload Identity](//cloud.google.com/iam/docs/workload-identity-federation) pool provider
        /// required to use KEK.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wipProvider")]
        public virtual string WipProvider { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Request to upload audience members to the provided destinations. Returns an IngestAudienceMembersResponse.
    /// </summary>
    public class IngestAudienceMembersRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The list of users to send to the specified destinations. At most 10000 AudienceMember resources
        /// can be sent in a single request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audienceMembers")]
        public virtual System.Collections.Generic.IList<AudienceMember> AudienceMembers { get; set; }

        /// <summary>
        /// Optional. Request-level consent to apply to all users in the request. User-level consent overrides
        /// request-level consent, and can be specified in each AudienceMember.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consent")]
        public virtual Consent Consent { get; set; }

        /// <summary>Required. The list of destinations to send the audience members to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinations")]
        public virtual System.Collections.Generic.IList<Destination> Destinations { get; set; }

        /// <summary>
        /// Optional. Required for UserData uploads. The encoding type of the user identifiers. For hashed user
        /// identifiers, this is the encoding type of the hashed string. For encrypted hashed user identifiers, this is
        /// the encoding type of the outer encrypted string, but not necessarily the inner hashed string, meaning the
        /// inner hashed string could be encoded in a different way than the outer encrypted string. For non `UserData`
        /// uploads, this field is ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encoding")]
        public virtual string Encoding { get; set; }

        /// <summary>
        /// Optional. Encryption information for UserData uploads. If not set, it's assumed that uploaded identifying
        /// information is hashed but not encrypted. For non `UserData` uploads, this field is ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionInfo")]
        public virtual EncryptionInfo EncryptionInfo { get; set; }

        /// <summary>Optional. The terms of service that the user has accepted/rejected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("termsOfService")]
        public virtual TermsOfService TermsOfService { get; set; }

        /// <summary>
        /// Optional. For testing purposes. If `true`, the request is validated but not executed. Only errors are
        /// returned, not results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response from the IngestAudienceMembersRequest.</summary>
    public class IngestAudienceMembersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The auto-generated ID of the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of the ingest audience members request.</summary>
    public class IngestAudienceMembersStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status of the mobile data ingestion to the destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileDataIngestionStatus")]
        public virtual IngestMobileDataStatus MobileDataIngestionStatus { get; set; }

        /// <summary>The status of the pair data ingestion to the destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pairDataIngestionStatus")]
        public virtual IngestPairDataStatus PairDataIngestionStatus { get; set; }

        /// <summary>The status of the ppid data ingestion to the destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ppidDataIngestionStatus")]
        public virtual IngestPpidDataStatus PpidDataIngestionStatus { get; set; }

        /// <summary>The status of the user data ingestion to the destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userDataIngestionStatus")]
        public virtual IngestUserDataStatus UserDataIngestionStatus { get; set; }

        /// <summary>The status of the user id data ingestion to the destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userIdDataIngestionStatus")]
        public virtual IngestUserIdDataStatus UserIdDataIngestionStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Request to upload audience members to the provided destinations. Returns an IngestEventsResponse.
    /// </summary>
    public class IngestEventsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Request-level consent to apply to all users in the request. User-level consent overrides
        /// request-level consent, and can be specified in each Event.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consent")]
        public virtual Consent Consent { get; set; }

        /// <summary>Required. The list of destinations to send the events to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinations")]
        public virtual System.Collections.Generic.IList<Destination> Destinations { get; set; }

        /// <summary>
        /// Optional. Required for UserData uploads. The encoding type of the user identifiers. For hashed user
        /// identifiers, this is the encoding type of the hashed string. For encrypted hashed user identifiers, this is
        /// the encoding type of the outer encrypted string, but not necessarily the inner hashed string, meaning the
        /// inner hashed string could be encoded in a different way than the outer encrypted string. For non `UserData`
        /// uploads, this field is ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encoding")]
        public virtual string Encoding { get; set; }

        /// <summary>
        /// Optional. Encryption information for UserData uploads. If not set, it's assumed that uploaded identifying
        /// information is hashed but not encrypted. For non `UserData` uploads, this field is ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionInfo")]
        public virtual EncryptionInfo EncryptionInfo { get; set; }

        /// <summary>
        /// Required. The list of events to send to the specified destinations. At most 2000 Event resources can be sent
        /// in a single request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("events")]
        public virtual System.Collections.Generic.IList<Event> Events { get; set; }

        /// <summary>
        /// Optional. For testing purposes. If `true`, the request is validated but not executed. Only errors are
        /// returned, not results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response from the IngestEventsRequest.</summary>
    public class IngestEventsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The auto-generated ID of the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of the events ingestion to the destination.</summary>
    public class IngestEventsStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The total count of events sent in the upload request. Includes all events in the request, regardless of
        /// whether they were successfully ingested or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The status of the mobile data ingestion to the destination containing stats related to the ingestion.
    /// </summary>
    public class IngestMobileDataStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The total count of mobile ids sent in the upload request for the destination. Includes all mobile ids in the
        /// request, regardless of whether they were successfully ingested or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileIdCount")]
        public virtual System.Nullable<long> MobileIdCount { get; set; }

        /// <summary>
        /// The total count of audience members sent in the upload request for the destination. Includes all audience
        /// members in the request, regardless of whether they were successfully ingested or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The status of the pair data ingestion to the destination containing stats related to the ingestion.
    /// </summary>
    public class IngestPairDataStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The total count of pair ids sent in the upload request for the destination. Includes all pair ids in the
        /// request, regardless of whether they were successfully ingested or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pairIdCount")]
        public virtual System.Nullable<long> PairIdCount { get; set; }

        /// <summary>
        /// The total count of audience members sent in the upload request for the destination. Includes all audience
        /// members in the request, regardless of whether they were successfully ingested or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The status of the ppid data ingestion to the destination containing stats related to the ingestion.
    /// </summary>
    public class IngestPpidDataStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The total count of ppids sent in the upload request for the destination. Includes all ppids in the request,
        /// regardless of whether they were successfully ingested or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ppidCount")]
        public virtual System.Nullable<long> PpidCount { get; set; }

        /// <summary>
        /// The total count of audience members sent in the upload request for the destination. Includes all audience
        /// members in the request, regardless of whether they were successfully ingested or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The status of the user data ingestion to the destination containing stats related to the ingestion.
    /// </summary>
    public class IngestUserDataStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The total count of audience members sent in the upload request for the destination. Includes all audience
        /// members in the request, regardless of whether they were successfully ingested or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        /// <summary>The match rate range of the upload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uploadMatchRateRange")]
        public virtual string UploadMatchRateRange { get; set; }

        /// <summary>
        /// The total count of user identifiers sent in the upload request for the destination. Includes all user
        /// identifiers in the request, regardless of whether they were successfully ingested or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userIdentifierCount")]
        public virtual System.Nullable<long> UserIdentifierCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The status of the user id data ingestion to the destination containing stats related to the ingestion.
    /// </summary>
    public class IngestUserIdDataStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The total count of audience members sent in the upload request for the destination. Includes all audience
        /// members in the request, regardless of whether they were successfully ingested or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        /// <summary>
        /// The total count of user ids sent in the upload request for the destination. Includes all user ids in the
        /// request, regardless of whether they were successfully ingested or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userIdCount")]
        public virtual System.Nullable<long> UserIdCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a user list that is populated by user provided data.</summary>
    public class IngestedUserListInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Additional information when `CONTACT_ID` is one of the `upload_key_types`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactIdInfo")]
        public virtual ContactIdInfo ContactIdInfo { get; set; }

        /// <summary>Optional. Additional information when `MOBILE_ID` is one of the `upload_key_types`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileIdInfo")]
        public virtual MobileIdInfo MobileIdInfo { get; set; }

        /// <summary>
        /// Optional. Additional information when `PAIR_ID` is one of the `upload_key_types`. This feature is only
        /// available to data partners.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pairIdInfo")]
        public virtual PairIdInfo PairIdInfo { get; set; }

        /// <summary>
        /// Optional. Additional information for partner audiences. This feature is only available to data partners.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partnerAudienceInfo")]
        public virtual PartnerAudienceInfo PartnerAudienceInfo { get; set; }

        /// <summary>Optional. Additional information for `PSEUDONYMOUS_ID` is one of the `upload_key_types`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pseudonymousIdInfo")]
        public virtual PseudonymousIdInfo PseudonymousIdInfo { get; set; }

        /// <summary>Required. Immutable. Upload key types of this user list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uploadKeyTypes")]
        public virtual System.Collections.Generic.IList<string> UploadKeyTypes { get; set; }

        /// <summary>Optional. Additional information when `USER_ID` is one of the `upload_key_types`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userIdInfo")]
        public virtual UserIdInfo UserIdInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an item in the cart associated with the event.</summary>
    public class Item : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A bucket of any [event parameters related to an
        /// item](https://developers.google.com/analytics/devguides/collection/protocol/ga4/reference/events) to be
        /// included within the event that were not already specified using other structured fields.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalItemParameters")]
        public virtual System.Collections.Generic.IList<ItemParameter> AdditionalItemParameters { get; set; }

        /// <summary>Optional. A unique identifier to reference the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemId")]
        public virtual string ItemId { get; set; }

        /// <summary>Optional. The product ID within the Merchant Center account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantProductId")]
        public virtual string MerchantProductId { get; set; }

        /// <summary>Optional. The number of this item associated with the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantity")]
        public virtual System.Nullable<long> Quantity { get; set; }

        /// <summary>Optional. The unit price excluding tax, shipping, and any transaction level discounts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unitPrice")]
        public virtual System.Nullable<double> UnitPrice { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A bucket of any [event parameters related to an
    /// item](https://developers.google.com/analytics/devguides/collection/protocol/ga4/reference/events) to be included
    /// within the event that were not already specified using other structured fields.
    /// </summary>
    public class ItemParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The name of the parameter to use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameterName")]
        public virtual string ParameterName { get; set; }

        /// <summary>Required. The string representation of the value of the parameter to set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response from the ListUserListDirectLicensesRequest.</summary>
    public class ListUserListDirectLicensesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The licenses for the given user list in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userListDirectLicenses")]
        public virtual System.Collections.Generic.IList<UserListDirectLicense> UserListDirectLicenses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response from the ListUserListGlobalLicensesCustomerInfoRequest.</summary>
    public class ListUserListGlobalLicenseCustomerInfosResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The customer information for the given license in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userListGlobalLicenseCustomerInfos")]
        public virtual System.Collections.Generic.IList<UserListGlobalLicenseCustomerInfo> UserListGlobalLicenseCustomerInfos { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response from the ListUserListGlobalLicensesRequest.</summary>
    public class ListUserListGlobalLicensesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The licenses for the given user list in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userListGlobalLicenses")]
        public virtual System.Collections.Generic.IList<UserListGlobalLicense> UserListGlobalLicenses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListUserLists.</summary>
    public class ListUserListsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The user lists from the specified account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userLists")]
        public virtual System.Collections.Generic.IList<UserList> UserLists { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The baseline location of the request. Baseline location is on OR-list of ISO 3166-1 alpha-2 region codes of the
    /// requested regions.
    /// </summary>
    public class Location : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of ISO 3166-1 alpha-2 region codes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCodes")]
        public virtual System.Collections.Generic.IList<string> RegionCodes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Insights for marketing data. This feature is only available to data partners.</summary>
    public class MarketingDataInsight : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Insights for values of a given dimension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IList<MarketingDataInsightsAttribute> Attributes { get; set; }

        /// <summary>The dimension to which the insight belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimension")]
        public virtual string Dimension { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Insights for a collection of related attributes of the same dimension.</summary>
    public class MarketingDataInsightsAttribute : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Age range of the audience for which the lift is provided.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ageRange")]
        public virtual string AgeRange { get; set; }

        /// <summary>Gender of the audience for which the lift is provided.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gender")]
        public virtual string Gender { get; set; }

        /// <summary>
        /// Measure of lift that the audience has for the attribute value as compared to the baseline. Range [0-1].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lift")]
        public virtual System.Nullable<float> Lift { get; set; }

        /// <summary>The user interest ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userInterestId")]
        public virtual System.Nullable<long> UserInterestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Mobile IDs for the audience. At least one mobile ID is required.</summary>
    public class MobileData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The list of mobile device IDs (advertising ID/IDFA). At most 10 `mobileIds` can be provided in a
        /// single AudienceMember.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileIds")]
        public virtual System.Collections.Generic.IList<string> MobileIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional information when `MOBILE_ID` is one of the `upload_key_types`.</summary>
    public class MobileIdInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Immutable. A string that uniquely identifies a mobile application from which the data was
        /// collected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appId")]
        public virtual string AppId { get; set; }

        /// <summary>Optional. Immutable. Source of the upload data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceType")]
        public virtual string DataSourceType { get; set; }

        /// <summary>Required. Immutable. The key space of mobile IDs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keySpace")]
        public virtual string KeySpace { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// [PAIR](//support.google.com/admanager/answer/15067908) IDs for the audience. At least one PAIR ID is required.
    /// This feature is only available to data partners.
    /// </summary>
    public class PairData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Cleanroom-provided PII data, hashed with SHA256, and encrypted with an EC commutative cipher using
        /// publisher key for the [PAIR]((//support.google.com/admanager/answer/15067908)) user list. At most 10
        /// `pairIds` can be provided in a single AudienceMember.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pairIds")]
        public virtual System.Collections.Generic.IList<string> PairIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Additional information when `PAIR_ID` is one of the `upload_key_types`. This feature is only available to data
    /// partners.
    /// </summary>
    public class PairIdInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The count of the advertiser's first party data records that have been uploaded to a clean room
        /// provider. This does not signify the size of a PAIR user list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserIdentifierCount")]
        public virtual System.Nullable<long> AdvertiserIdentifierCount { get; set; }

        /// <summary>
        /// Required. Immutable. Identifies a unique advertiser to publisher relationship with one clean room provider
        /// or across multiple clean room providers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cleanRoomIdentifier")]
        public virtual string CleanRoomIdentifier { get; set; }

        /// <summary>
        /// Required. This field denotes the percentage of membership match of this user list with the corresponding
        /// publisher's first party data. Must be between 0 and 100 inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchRatePercentage")]
        public virtual System.Nullable<int> MatchRatePercentage { get; set; }

        /// <summary>
        /// Required. Immutable. Identifies the publisher that the Publisher Advertiser Identity Reconciliation user
        /// list is reconciled with. This field is provided by the cleanroom provider and is only unique in the scope of
        /// that cleanroom. This cannot be used as a global identifier across multiple cleanrooms.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publisherId")]
        public virtual System.Nullable<long> PublisherId { get; set; }

        /// <summary>
        /// Required. Descriptive name of the publisher to be displayed in the UI for a better targeting experience.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publisherName")]
        public virtual string PublisherName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Additional information for partner audiences. This feature is only available to data partners.
    /// </summary>
    public class PartnerAudienceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The commerce partner name. Only allowed if `partner_audience_source` is `COMMERCE_AUDIENCE`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commercePartner")]
        public virtual string CommercePartner { get; set; }

        /// <summary>Required. Immutable. The source of the partner audience.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partnerAudienceSource")]
        public virtual string PartnerAudienceSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A partner link between an owning account and a partner account.</summary>
    public class PartnerLink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Identifier. The name of the partner link. Format:
        /// accountTypes/{account_type}/accounts/{account}/partnerLinks/{partner_link}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. The owning account granting access to the partner account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("owningAccount")]
        public virtual ProductAccount OwningAccount { get; set; }

        /// <summary>Required. The partner account granted access by the owning account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partnerAccount")]
        public virtual ProductAccount PartnerAccount { get; set; }

        /// <summary>Output only. The partner link ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partnerLinkId")]
        public virtual string PartnerLinkId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Publisher provided identifiers data holding the ppids. At least one ppid is required. This feature is only
    /// available to data partners.
    /// </summary>
    public class PpidData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The list of publisher provided identifiers for a user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ppids")]
        public virtual System.Collections.Generic.IList<string> Ppids { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a specific account.</summary>
    public class ProductAccount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The ID of the account. For example, your Google Ads account ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        /// <summary>
        /// Optional. The type of the account. For example, `GOOGLE_ADS`. Either `account_type` or the deprecated
        /// `product` is required. If both are set, the values must match.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountType")]
        public virtual string AccountType { get; set; }

        /// <summary>Deprecated. Use `account_type` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("product")]
        public virtual string Product { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional information when `PSEUDONYMOUS_ID` is one of the `upload_key_types`.</summary>
    public class PseudonymousIdInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Immutable. The number of billable records (e.g. uploaded or matched).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billableRecordCount")]
        public virtual System.Nullable<long> BillableRecordCount { get; set; }

        /// <summary>Output only. Sync status of the user list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syncStatus")]
        public virtual string SyncStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Request to remove users from an audience in the provided destinations. Returns a RemoveAudienceMembersResponse.
    /// </summary>
    public class RemoveAudienceMembersRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The list of users to remove.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audienceMembers")]
        public virtual System.Collections.Generic.IList<AudienceMember> AudienceMembers { get; set; }

        /// <summary>Required. The list of destinations to remove the users from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinations")]
        public virtual System.Collections.Generic.IList<Destination> Destinations { get; set; }

        /// <summary>
        /// Optional. Required for UserData uploads. The encoding type of the user identifiers. Applies to only the
        /// outer encoding for encrypted user identifiers. For non `UserData` uploads, this field is ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encoding")]
        public virtual string Encoding { get; set; }

        /// <summary>
        /// Optional. Encryption information for UserData uploads. If not set, it's assumed that uploaded identifying
        /// information is hashed but not encrypted. For non `UserData` uploads, this field is ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionInfo")]
        public virtual EncryptionInfo EncryptionInfo { get; set; }

        /// <summary>
        /// Optional. For testing purposes. If `true`, the request is validated but not executed. Only errors are
        /// returned, not results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response from the RemoveAudienceMembersRequest.</summary>
    public class RemoveAudienceMembersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The auto-generated ID of the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of the remove audience members request.</summary>
    public class RemoveAudienceMembersStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status of the mobile data removal from the destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileDataRemovalStatus")]
        public virtual RemoveMobileDataStatus MobileDataRemovalStatus { get; set; }

        /// <summary>The status of the pair data removal from the destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pairDataRemovalStatus")]
        public virtual RemovePairDataStatus PairDataRemovalStatus { get; set; }

        /// <summary>The status of the ppid data removal from the destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ppidDataRemovalStatus")]
        public virtual RemovePpidDataStatus PpidDataRemovalStatus { get; set; }

        /// <summary>The status of the user data removal from the destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userDataRemovalStatus")]
        public virtual RemoveUserDataStatus UserDataRemovalStatus { get; set; }

        /// <summary>The status of the user id data removal from the destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userIdDataRemovalStatus")]
        public virtual RemoveUserIdDataStatus UserIdDataRemovalStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of the mobile data removal from the destination.</summary>
    public class RemoveMobileDataStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The total count of mobile Ids sent in the removal request. Includes all mobile ids in the request,
        /// regardless of whether they were successfully removed or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileIdCount")]
        public virtual System.Nullable<long> MobileIdCount { get; set; }

        /// <summary>
        /// The total count of audience members sent in the removal request. Includes all audience members in the
        /// request, regardless of whether they were successfully removed or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of the pair data removal from the destination.</summary>
    public class RemovePairDataStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The total count of pair ids sent in the removal request. Includes all pair ids in the request, regardless of
        /// whether they were successfully removed or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pairIdCount")]
        public virtual System.Nullable<long> PairIdCount { get; set; }

        /// <summary>
        /// The total count of audience members sent in the removal request. Includes all audience members in the
        /// request, regardless of whether they were successfully removed or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of the ppid data removal from the destination.</summary>
    public class RemovePpidDataStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The total count of ppids sent in the removal request. Includes all ppids in the request, regardless of
        /// whether they were successfully removed or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ppidCount")]
        public virtual System.Nullable<long> PpidCount { get; set; }

        /// <summary>
        /// The total count of audience members sent in the removal request. Includes all audience members in the
        /// request, regardless of whether they were successfully removed or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of the user data removal from the destination.</summary>
    public class RemoveUserDataStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The total count of audience members sent in the removal request. Includes all audience members in the
        /// request, regardless of whether they were successfully removed or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        /// <summary>
        /// The total count of user identifiers sent in the removal request. Includes all user identifiers in the
        /// request, regardless of whether they were successfully removed or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userIdentifierCount")]
        public virtual System.Nullable<long> UserIdentifierCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of the user id data removal from the destination.</summary>
    public class RemoveUserIdDataStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The total count of audience members sent in the removal request. Includes all audience members in the
        /// request, regardless of whether they were successfully removed or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        /// <summary>
        /// The total count of user ids sent in the removal request. Includes all user ids in the request, regardless of
        /// whether they were successfully removed or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userIdCount")]
        public virtual System.Nullable<long> UserIdCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request status per destination.</summary>
    public class RequestStatusPerDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status of the ingest audience members request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audienceMembersIngestionStatus")]
        public virtual IngestAudienceMembersStatus AudienceMembersIngestionStatus { get; set; }

        /// <summary>The status of the remove audience members request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audienceMembersRemovalStatus")]
        public virtual RemoveAudienceMembersStatus AudienceMembersRemovalStatus { get; set; }

        /// <summary>A destination within a DM API request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destination")]
        public virtual Destination Destination { get; set; }

        /// <summary>An error info error containing the error reason and error counts related to the upload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorInfo")]
        public virtual ErrorInfo ErrorInfo { get; set; }

        /// <summary>The status of the ingest events request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventsIngestionStatus")]
        public virtual IngestEventsStatus EventsIngestionStatus { get; set; }

        /// <summary>The request status of the destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestStatus")]
        public virtual string RequestStatus { get; set; }

        /// <summary>A warning info containing the warning reason and warning counts related to the upload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warningInfo")]
        public virtual WarningInfo WarningInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DM API MarketingDataInsightsService.RetrieveInsights</summary>
    public class RetrieveInsightsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Baseline for the insights requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseline")]
        public virtual Baseline Baseline { get; set; }

        /// <summary>Required. The user list ID for which insights are requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userListId")]
        public virtual string UserListId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for DM API MarketingDataInsightsService.RetrieveInsights</summary>
    public class RetrieveInsightsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Contains the insights for the marketing data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marketingDataInsights")]
        public virtual System.Collections.Generic.IList<MarketingDataInsight> MarketingDataInsights { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response from the RetrieveRequestStatusRequest.</summary>
    public class RetrieveRequestStatusResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of request statuses per destination. The order of the statuses matches the order of the destinations
        /// in the original request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestStatusPerDestination")]
        public virtual System.Collections.Generic.IList<RequestStatusPerDestination> RequestStatusPerDestination { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response from the SearchPartnerLinksRequest.</summary>
    public class SearchPartnerLinksResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The partner links for the given account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partnerLinks")]
        public virtual System.Collections.Generic.IList<PartnerLink> PartnerLinks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Estimated number of members in this user list in different target networks.</summary>
    public class SizeInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Estimated number of members in this user list, on the Google Display Network.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayNetworkMembersCount")]
        public virtual System.Nullable<long> DisplayNetworkMembersCount { get; set; }

        /// <summary>
        /// Output only. Estimated number of members in this user list in the google.com domain. These are the members
        /// available for targeting in Search campaigns.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchNetworkMembersCount")]
        public virtual System.Nullable<long> SearchNetworkMembersCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The `Status` type defines a logical error model that is suitable for different programming environments,
    /// including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status` message contains
    /// three pieces of data: error code, error message, and error details. You can find out more about this error model
    /// and how to work with it in the [API Design Guide](https://cloud.google.com/apis/design/errors).
    /// </summary>
    public class Status : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status code, which should be an enum value of google.rpc.Code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<int> Code { get; set; }

        /// <summary>
        /// A list of messages that carry the error details. There is a common set of message types for APIs to use.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Details { get; set; }

        /// <summary>
        /// A developer-facing error message, which should be in English. Any user-facing error message should be
        /// localized and sent in the google.rpc.Status.details field, or localized by the client.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Eligibility information for different target networks.</summary>
    public class TargetNetworkInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Indicates this user list is eligible for Google Display Network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eligibleForDisplay")]
        public virtual System.Nullable<bool> EligibleForDisplay { get; set; }

        /// <summary>Optional. Indicates if this user list is eligible for Google Search Network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eligibleForSearch")]
        public virtual System.Nullable<bool> EligibleForSearch { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The terms of service that the user has accepted/rejected.</summary>
    public class TermsOfService : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The Customer Match terms of service: https://support.google.com/adspolicy/answer/6299717. This
        /// must be accepted when ingesting UserData or MobileData. This field is not required for Partner Match User
        /// list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerMatchTermsOfServiceStatus")]
        public virtual string CustomerMatchTermsOfServiceStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data that identifies the user. At least one identifier is required.</summary>
    public class UserData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The identifiers for the user. It's possible to provide multiple instances of the same type of data
        /// (for example, multiple email addresses). To increase the likelihood of a match, provide as many identifiers
        /// as possible. At most 10 `userIdentifiers` can be provided in a single AudienceMember or Event.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userIdentifiers")]
        public virtual System.Collections.Generic.IList<UserIdentifier> UserIdentifiers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>User id data holding the user id.</summary>
    public class UserIdData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. A unique identifier for a user, as defined by the advertiser.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional information when `USER_ID` is one of the `upload_key_types`.</summary>
    public class UserIdInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Immutable. Source of the upload data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceType")]
        public virtual string DataSourceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single identifier for the user.</summary>
    public class UserIdentifier : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The known components of a user's address. Holds a grouping of identifiers that are matched all at once.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual AddressInfo Address { get; set; }

        /// <summary>Hashed email address using SHA-256 hash function after normalization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailAddress")]
        public virtual string EmailAddress { get; set; }

        /// <summary>Hashed phone number using SHA-256 hash function after normalization (E164 standard).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneNumber")]
        public virtual string PhoneNumber { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A user list resource.</summary>
    public class UserList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The reason this account has been granted access to the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessReason")]
        public virtual string AccessReason { get; set; }

        /// <summary>
        /// Optional. Indicates if this share is still enabled. When a user list is shared with the account this field
        /// is set to `ENABLED`. Later the user list owner can decide to revoke the share and make it `DISABLED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountAccessStatus")]
        public virtual string AccountAccessStatus { get; set; }

        /// <summary>Output only. The reason why this user list membership status is closed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("closingReason")]
        public virtual string ClosingReason { get; set; }

        /// <summary>Optional. A description of the user list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. The display name of the user list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. The unique ID of the user list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>Optional. Represents a user list that is populated by user ingested data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingestedUserListInfo")]
        public virtual IngestedUserListInfo IngestedUserListInfo { get; set; }

        /// <summary>
        /// Optional. An ID from external system. It is used by user list sellers to correlate IDs on their systems.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integrationCode")]
        public virtual string IntegrationCode { get; set; }

        /// <summary>
        /// Optional. The duration a user remains in the user list. Valid durations are exact multiples of 24 hours
        /// (86400 seconds). Providing a value that is not an exact multiple of 24 hours will result in an
        /// INVALID_ARGUMENT error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membershipDuration")]
        public virtual object MembershipDuration { get; set; }

        /// <summary>Optional. Membership status of this user list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membershipStatus")]
        public virtual string MembershipStatus { get; set; }

        /// <summary>
        /// Identifier. The resource name of the user list. Format:
        /// accountTypes/{account_type}/accounts/{account}/userLists/{user_list}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. An option that indicates if a user may edit a list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readOnly")]
        public virtual System.Nullable<bool> ReadOnly__ { get; set; }

        /// <summary>Output only. Estimated number of members in this user list in different target networks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeInfo")]
        public virtual SizeInfo SizeInfo { get; set; }

        /// <summary>Optional. Eligibility information for different target networks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetNetworkInfo")]
        public virtual TargetNetworkInfo TargetNetworkInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A user list direct license. This feature is only available to data partners.</summary>
    public class UserListDirectLicense : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Name of client customer which the user list is being licensed to. This field is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientAccountDisplayName")]
        public virtual string ClientAccountDisplayName { get; set; }

        /// <summary>Immutable. ID of client customer which the user list is being licensed to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientAccountId")]
        public virtual System.Nullable<long> ClientAccountId { get; set; }

        /// <summary>Immutable. Account type of client customer which the user list is being licensed to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientAccountType")]
        public virtual string ClientAccountType { get; set; }

        /// <summary>Output only. Pricing history of this user list license. This field is read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("historicalPricings")]
        public virtual System.Collections.Generic.IList<UserListLicensePricing> HistoricalPricings { get; set; }

        /// <summary>
        /// Output only. Metrics related to this license This field is read-only and only populated if the start and end
        /// dates are set in the ListUserListDirectLicenses call
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual UserListLicenseMetrics Metrics { get; set; }

        /// <summary>Identifier. The resource name of the user list direct license.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. UserListDirectLicense pricing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pricing")]
        public virtual UserListLicensePricing Pricing { get; set; }

        /// <summary>Optional. Status of UserListDirectLicense - ENABLED or DISABLED.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>Output only. Name of the user list being licensed. This field is read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userListDisplayName")]
        public virtual string UserListDisplayName { get; set; }

        /// <summary>Immutable. ID of the user list being licensed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userListId")]
        public virtual System.Nullable<long> UserListId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A user list global license. This feature is only available to data partners.</summary>
    public class UserListGlobalLicense : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Pricing history of this user list license. This field is read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("historicalPricings")]
        public virtual System.Collections.Generic.IList<UserListLicensePricing> HistoricalPricings { get; set; }

        /// <summary>Immutable. Product type of client customer which the user list is being licensed to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("licenseType")]
        public virtual string LicenseType { get; set; }

        /// <summary>
        /// Output only. Metrics related to this license This field is read-only and only populated if the start and end
        /// dates are set in the ListUserListGlobalLicenses call
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual UserListLicenseMetrics Metrics { get; set; }

        /// <summary>Identifier. The resource name of the user list global license.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. UserListGlobalLicense pricing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pricing")]
        public virtual UserListLicensePricing Pricing { get; set; }

        /// <summary>Optional. Status of UserListGlobalLicense - ENABLED or DISABLED.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>Output only. Name of the user list being licensed. This field is read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userListDisplayName")]
        public virtual string UserListDisplayName { get; set; }

        /// <summary>Immutable. ID of the user list being licensed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userListId")]
        public virtual System.Nullable<long> UserListId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information about a customer of a user list global license. This will automatically be created by the system
    /// when a customer purchases a global license.
    /// </summary>
    public class UserListGlobalLicenseCustomerInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Name of client customer which the user list is being licensed to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientAccountDisplayName")]
        public virtual string ClientAccountDisplayName { get; set; }

        /// <summary>Output only. ID of client customer which the user list is being licensed to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientAccountId")]
        public virtual System.Nullable<long> ClientAccountId { get; set; }

        /// <summary>Output only. Product type of client customer which the user list is being licensed to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientAccountType")]
        public virtual string ClientAccountType { get; set; }

        /// <summary>Output only. Pricing history of this user list license.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("historicalPricings")]
        public virtual System.Collections.Generic.IList<UserListLicensePricing> HistoricalPricings { get; set; }

        /// <summary>Output only. Product type of client customer which the user list is being licensed to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("licenseType")]
        public virtual string LicenseType { get; set; }

        /// <summary>
        /// Output only. Metrics related to this license This field is only populated if the start and end dates are set
        /// in the ListUserListGlobalLicenseCustomerInfos call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual UserListLicenseMetrics Metrics { get; set; }

        /// <summary>Identifier. The resource name of the user list global license customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. UserListDirectLicense pricing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pricing")]
        public virtual UserListLicensePricing Pricing { get; set; }

        /// <summary>Output only. Status of UserListDirectLicense - ENABLED or DISABLED.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>Output only. Name of the user list being licensed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userListDisplayName")]
        public virtual string UserListDisplayName { get; set; }

        /// <summary>Output only. ID of the user list being licensed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userListId")]
        public virtual System.Nullable<long> UserListId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metrics related to a user list license.</summary>
    public class UserListLicenseMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The number of clicks for the user list license.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clickCount")]
        public virtual System.Nullable<long> ClickCount { get; set; }

        /// <summary>
        /// Output only. The end date (inclusive) of the metrics in the format YYYYMMDD. For example, 20260102
        /// represents January 2, 2026. If `start_date` is used in the filter, `end_date` is also required. If neither
        /// `start_date` nor `end_date` are included in the filter, the UserListLicenseMetrics fields will not be
        /// populated in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual System.Nullable<long> EndDate { get; set; }

        /// <summary>Output only. The number of impressions for the user list license.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("impressionCount")]
        public virtual System.Nullable<long> ImpressionCount { get; set; }

        /// <summary>Output only. The revenue for the user list license in USD micros.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revenueUsdMicros")]
        public virtual System.Nullable<long> RevenueUsdMicros { get; set; }

        /// <summary>
        /// Output only. The start date (inclusive) of the metrics in the format YYYYMMDD. For example, 20260102
        /// represents January 2, 2026. If `end_date` is used in the filter, `start_date` is also required. If neither
        /// `start_date` nor `end_date` are included in the filter, the UserListLicenseMetrics fields will not be
        /// populated in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual System.Nullable<long> StartDate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A user list license pricing.</summary>
    public class UserListLicensePricing : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The buyer approval state of this pricing. This field is read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buyerApprovalState")]
        public virtual string BuyerApprovalState { get; set; }

        /// <summary>
        /// Optional. The cost associated with the model, in micro units (10^-6), in the currency specified by the
        /// currency_code field. For example, 2000000 means $2 if `currency_code` is `USD`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("costMicros")]
        public virtual System.Nullable<long> CostMicros { get; set; }

        /// <summary>
        /// Immutable. The cost type of this pricing. Can be set only in the `create` operation. Can't be updated for an
        /// existing license.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("costType")]
        public virtual string CostType { get; set; }

        /// <summary>
        /// Optional. The currency in which cost and max_cost is specified. Must be a three-letter currency code defined
        /// in ISO 4217.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Optional. End time of the pricing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual string EndTimeRaw
        {
            get => _endTimeRaw;
            set
            {
                _endTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _endTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EndTimeDateTimeOffset instead.")]
        public virtual object EndTime
        {
            get => _endTime;
            set
            {
                _endTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _endTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="EndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EndTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EndTimeRaw);
            set => EndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Optional. The maximum CPM a commerce audience can be charged when the MEDIA_SHARE cost type is used. The
        /// value is in micro units (10^-6) and in the currency specified by the currency_code field. For example,
        /// 2000000 means $2 if `currency_code` is `USD`. This is only relevant when cost_type is MEDIA_SHARE. When
        /// cost_type is not MEDIA_SHARE, and this field is set, a MAX_COST_NOT_ALLOWED error will be returned. If not
        /// set or set to`0`, there is no cap.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxCostMicros")]
        public virtual System.Nullable<long> MaxCostMicros { get; set; }

        /// <summary>Output only. Whether this pricing is active.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pricingActive")]
        public virtual System.Nullable<bool> PricingActive { get; set; }

        /// <summary>Output only. The ID of this pricing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pricingId")]
        public virtual System.Nullable<long> PricingId { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Output only. Start time of the pricing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual string StartTimeRaw
        {
            get => _startTimeRaw;
            set
            {
                _startTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _startTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="StartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use StartTimeDateTimeOffset instead.")]
        public virtual object StartTime
        {
            get => _startTime;
            set
            {
                _startTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _startTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="StartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? StartTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(StartTimeRaw);
            set => StartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Advertiser-assessed information about the user at the time that the event happened. See
    /// https://support.google.com/google-ads/answer/14007601 for more details.
    /// </summary>
    public class UserProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A bucket of any additional [user
        /// properties](https://developers.google.com/analytics/devguides/collection/protocol/ga4/user-properties) for
        /// the user associated with this event.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalUserProperties")]
        public virtual System.Collections.Generic.IList<UserProperty> AdditionalUserProperties { get; set; }

        /// <summary>Optional. Type of the customer associated with the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerType")]
        public virtual string CustomerType { get; set; }

        /// <summary>Optional. The advertiser-assessed value of the customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerValueBucket")]
        public virtual string CustomerValueBucket { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A bucket of any additional [user
    /// properties](https://developers.google.com/analytics/devguides/collection/protocol/ga4/user-properties) for the
    /// user associated with this event.
    /// </summary>
    public class UserProperty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The name of the user property to use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("propertyName")]
        public virtual string PropertyName { get; set; }

        /// <summary>Required. The string representation of the value of the user property to use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The warning count for a given warning reason.</summary>
    public class WarningCount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The warning reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The count of records that have a warning.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Warning counts for each type of warning.</summary>
    public class WarningInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of warnings and counts per warning reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warningCounts")]
        public virtual System.Collections.Generic.IList<WarningCount> WarningCounts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
