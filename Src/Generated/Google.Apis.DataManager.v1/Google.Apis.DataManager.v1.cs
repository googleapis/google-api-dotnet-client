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
            AdEvents = new AdEventsResource(this);
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

        /// <summary>Gets the AdEvents resource.</summary>
        public virtual AdEventsResource AdEvents { get; }

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

                /// <summary></summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent"><c>null</c></param>
                public virtual RetrieveRequest Retrieve(Google.Apis.DataManager.v1.Data.RetrieveInsightsRequest body, string parent)
                {
                    return new RetrieveRequest(this.service, body, parent);
                }

                /// <summary></summary>
                public class RetrieveRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.RetrieveInsightsResponse>
                {
                    /// <summary>Constructs a new Retrieve request.</summary>
                    public RetrieveRequest(Google.Apis.Services.IClientService service, Google.Apis.DataManager.v1.Data.RetrieveInsightsRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

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

                /// <summary></summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent"><c>null</c></param>
                public virtual CreateRequest Create(Google.Apis.DataManager.v1.Data.PartnerLink body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary></summary>
                public class CreateRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.PartnerLink>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DataManager.v1.Data.PartnerLink body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

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

                /// <summary></summary>
                /// <param name="name"><c>null</c></param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary></summary>
                public class DeleteRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

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

                /// <summary></summary>
                /// <param name="parent"><c>null</c></param>
                public virtual SearchRequest Search(string parent)
                {
                    return new SearchRequest(this.service, parent);
                }

                /// <summary></summary>
                public class SearchRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.SearchPartnerLinksResponse>
                {
                    /// <summary>Constructs a new Search request.</summary>
                    public SearchRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

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

                /// <summary></summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent"><c>null</c></param>
                public virtual CreateRequest Create(Google.Apis.DataManager.v1.Data.UserListDirectLicense body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary></summary>
                public class CreateRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.UserListDirectLicense>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DataManager.v1.Data.UserListDirectLicense body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

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

                /// <summary></summary>
                /// <param name="name"><c>null</c></param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary></summary>
                public class GetRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.UserListDirectLicense>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

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

                /// <summary></summary>
                /// <param name="parent"><c>null</c></param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary></summary>
                public class ListRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.ListUserListDirectLicensesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

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

                /// <summary></summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name"><c>null</c></param>
                public virtual PatchRequest Patch(Google.Apis.DataManager.v1.Data.UserListDirectLicense body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary></summary>
                public class PatchRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.UserListDirectLicense>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DataManager.v1.Data.UserListDirectLicense body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

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

                    /// <summary></summary>
                    /// <param name="parent"><c>null</c></param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary></summary>
                    public class ListRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.ListUserListGlobalLicenseCustomerInfosResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

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

                /// <summary></summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent"><c>null</c></param>
                public virtual CreateRequest Create(Google.Apis.DataManager.v1.Data.UserListGlobalLicense body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary></summary>
                public class CreateRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.UserListGlobalLicense>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DataManager.v1.Data.UserListGlobalLicense body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

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

                /// <summary></summary>
                /// <param name="name"><c>null</c></param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary></summary>
                public class GetRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.UserListGlobalLicense>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

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

                /// <summary></summary>
                /// <param name="parent"><c>null</c></param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary></summary>
                public class ListRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.ListUserListGlobalLicensesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

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

                /// <summary></summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name"><c>null</c></param>
                public virtual PatchRequest Patch(Google.Apis.DataManager.v1.Data.UserListGlobalLicense body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary></summary>
                public class PatchRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.UserListGlobalLicense>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DataManager.v1.Data.UserListGlobalLicense body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

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

                /// <summary></summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent"><c>null</c></param>
                public virtual CreateRequest Create(Google.Apis.DataManager.v1.Data.UserList body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary></summary>
                public class CreateRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.UserList>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DataManager.v1.Data.UserList body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

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

                /// <summary></summary>
                /// <param name="name"><c>null</c></param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary></summary>
                public class DeleteRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

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

                /// <summary></summary>
                /// <param name="name"><c>null</c></param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary></summary>
                public class GetRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.UserList>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

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

                /// <summary></summary>
                /// <param name="parent"><c>null</c></param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary></summary>
                public class ListRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.ListUserListsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

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

                /// <summary></summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name"><c>null</c></param>
                public virtual PatchRequest Patch(Google.Apis.DataManager.v1.Data.UserList body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary></summary>
                public class PatchRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.UserList>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DataManager.v1.Data.UserList body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

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

    /// <summary>The "adEvents" collection of methods.</summary>
    public class AdEventsResource
    {
        private const string Resource = "adEvents";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AdEventsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary></summary>
        /// <param name="body">The body of the request.</param>
        public virtual IngestRequest Ingest(Google.Apis.DataManager.v1.Data.IngestAdEventsRequest body)
        {
            return new IngestRequest(this.service, body);
        }

        /// <summary></summary>
        public class IngestRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.IngestAdEventsResponse>
        {
            /// <summary>Constructs a new Ingest request.</summary>
            public IngestRequest(Google.Apis.Services.IClientService service, Google.Apis.DataManager.v1.Data.IngestAdEventsRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DataManager.v1.Data.IngestAdEventsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "ingest";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/adEvents:ingest";

            /// <summary>Initializes Ingest parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
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

        /// <summary></summary>
        /// <param name="body">The body of the request.</param>
        public virtual IngestRequest Ingest(Google.Apis.DataManager.v1.Data.IngestAudienceMembersRequest body)
        {
            return new IngestRequest(this.service, body);
        }

        /// <summary></summary>
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

        /// <summary></summary>
        /// <param name="body">The body of the request.</param>
        public virtual RemoveRequest Remove(Google.Apis.DataManager.v1.Data.RemoveAudienceMembersRequest body)
        {
            return new RemoveRequest(this.service, body);
        }

        /// <summary></summary>
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

        /// <summary></summary>
        /// <param name="body">The body of the request.</param>
        public virtual RemoveAllRequest RemoveAll(Google.Apis.DataManager.v1.Data.RemoveAllAudienceMembersRequest body)
        {
            return new RemoveAllRequest(this.service, body);
        }

        /// <summary></summary>
        public class RemoveAllRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.RemoveAllAudienceMembersResponse>
        {
            /// <summary>Constructs a new RemoveAll request.</summary>
            public RemoveAllRequest(Google.Apis.Services.IClientService service, Google.Apis.DataManager.v1.Data.RemoveAllAudienceMembersRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DataManager.v1.Data.RemoveAllAudienceMembersRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "removeAll";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/audienceMembers:removeAll";

            /// <summary>Initializes RemoveAll parameter list.</summary>
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

        /// <summary></summary>
        /// <param name="body">The body of the request.</param>
        public virtual IngestRequest Ingest(Google.Apis.DataManager.v1.Data.IngestEventsRequest body)
        {
            return new IngestRequest(this.service, body);
        }

        /// <summary></summary>
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

        /// <summary></summary>
        public virtual RetrieveRequest Retrieve()
        {
            return new RetrieveRequest(this.service);
        }

        /// <summary></summary>
        public class RetrieveRequest : DataManagerBaseServiceRequest<Google.Apis.DataManager.v1.Data.RetrieveRequestStatusResponse>
        {
            /// <summary>Constructs a new Retrieve request.</summary>
            public RetrieveRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

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
    public class AdEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("adFormat")]
        public virtual string AdFormat { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("adFormatString")]
        public virtual string AdFormatString { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("adGroupId")]
        public virtual string AdGroupId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("adHeight")]
        public virtual System.Nullable<int> AdHeight { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("adId")]
        public virtual string AdId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("adPlacement")]
        public virtual string AdPlacement { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("adPlacementString")]
        public virtual string AdPlacementString { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("adType")]
        public virtual string AdType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("adTypeString")]
        public virtual string AdTypeString { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("adWidth")]
        public virtual System.Nullable<int> AdWidth { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("advertiserId")]
        public virtual string AdvertiserId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("attributionHint")]
        public virtual string AttributionHint { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("campaignId")]
        public virtual string CampaignId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("campaignName")]
        public virtual string CampaignName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("deviceInfo")]
        public virtual DeviceInfo DeviceInfo { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("eventSubtype")]
        public virtual string EventSubtype { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("eventSubtypeString")]
        public virtual string EventSubtypeString { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("eventType")]
        public virtual string EventType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
        public virtual string IpAddress { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("measurementAllowed")]
        public virtual System.Nullable<bool> MeasurementAllowed { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("medium")]
        public virtual string Medium { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("mobileDeviceId")]
        public virtual string MobileDeviceId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("platform")]
        public virtual string Platform { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("platformString")]
        public virtual string PlatformString { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("platformType")]
        public virtual string PlatformType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("platformTypeString")]
        public virtual string PlatformTypeString { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("targetingType")]
        public virtual string TargetingType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("targetingTypeString")]
        public virtual string TargetingTypeString { get; set; }

        private string _timestampRaw;

        private object _timestamp;

        [Newtonsoft.Json.JsonPropertyAttribute("timestamp")]
        public virtual string TimestampRaw
        {
            get => _timestampRaw;
            set
            {
                _timestamp = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _timestampRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="TimestampRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use TimestampDateTimeOffset instead.")]
        public virtual object Timestamp
        {
            get => _timestamp;
            set
            {
                _timestampRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _timestamp = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="TimestampRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? TimestampDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(TimestampRaw);
            set => TimestampRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        [Newtonsoft.Json.JsonPropertyAttribute("userData")]
        public virtual UserData UserData { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("viewabilityInfo")]
        public virtual ViewabilityInfo ViewabilityInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AdIdentifiers : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("dclid")]
        public virtual string Dclid { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("encryptedUserIds")]
        public virtual System.Collections.Generic.IList<EncryptedUserId> EncryptedUserIds { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("gbraid")]
        public virtual string Gbraid { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("gclid")]
        public virtual string Gclid { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("impressionId")]
        public virtual string ImpressionId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("landingPageDeviceInfo")]
        public virtual DeviceInfo LandingPageDeviceInfo { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("matchId")]
        public virtual string MatchId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("mobileDeviceId")]
        public virtual string MobileDeviceId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("ppid")]
        public virtual string Ppid { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("sessionAttributes")]
        public virtual string SessionAttributes { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("visitorPpid")]
        public virtual string VisitorPpid { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("wbraid")]
        public virtual string Wbraid { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AddressInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("addressLine")]
        public virtual string AddressLine { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("administrativeArea")]
        public virtual string AdministrativeArea { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("city")]
        public virtual string City { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("familyName")]
        public virtual string FamilyName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("givenName")]
        public virtual string GivenName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("postalCode")]
        public virtual string PostalCode { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AudienceMember : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("compositeData")]
        public virtual CompositeData CompositeData { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("consent")]
        public virtual Consent Consent { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("destinationReferences")]
        public virtual System.Collections.Generic.IList<string> DestinationReferences { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("googleUserIdData")]
        public virtual GoogleUserIdData GoogleUserIdData { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("mobileData")]
        public virtual MobileData MobileData { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("pairData")]
        public virtual PairData PairData { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("partnerProvidedIdData")]
        public virtual PartnerProvidedIdData PartnerProvidedIdData { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("ppidData")]
        public virtual PpidData PpidData { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userData")]
        public virtual UserData UserData { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userIdData")]
        public virtual UserIdData UserIdData { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AwsWrappedKeyInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("encryptedDek")]
        public virtual string EncryptedDek { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kekUri")]
        public virtual string KekUri { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("keyType")]
        public virtual string KeyType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("roleArn")]
        public virtual string RoleArn { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Baseline : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("baselineLocation")]
        public virtual Location BaselineLocation { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("locationAutoDetectionEnabled")]
        public virtual System.Nullable<bool> LocationAutoDetectionEnabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CartData : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("couponCodes")]
        public virtual System.Collections.Generic.IList<string> CouponCodes { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Item> Items { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("merchantFeedLabel")]
        public virtual string MerchantFeedLabel { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("merchantFeedLanguageCode")]
        public virtual string MerchantFeedLanguageCode { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("merchantId")]
        public virtual string MerchantId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("transactionDiscount")]
        public virtual System.Nullable<double> TransactionDiscount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CompositeData : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("ipData")]
        public virtual System.Collections.Generic.IList<IpData> IpData { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userData")]
        public virtual UserData UserData { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Consent : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("adPersonalization")]
        public virtual string AdPersonalization { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("adUserData")]
        public virtual string AdUserData { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ContactIdInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceType")]
        public virtual string DataSourceType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("matchRatePercentage")]
        public virtual System.Nullable<int> MatchRatePercentage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CoordinatorKeyInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("keyId")]
        public virtual string KeyId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CustomVariable : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("destinationReferences")]
        public virtual System.Collections.Generic.IList<string> DestinationReferences { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("variable")]
        public virtual string Variable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DataTypeCount : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Destination : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("linkedAccount")]
        public virtual ProductAccount LinkedAccount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("loginAccount")]
        public virtual ProductAccount LoginAccount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("operatingAccount")]
        public virtual ProductAccount OperatingAccount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("productDestinationId")]
        public virtual string ProductDestinationId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("reference")]
        public virtual string Reference { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DeviceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("brand")]
        public virtual string Brand { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("browser")]
        public virtual string Browser { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("browserVersion")]
        public virtual string BrowserVersion { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
        public virtual string IpAddress { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("operatingSystem")]
        public virtual string OperatingSystem { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("operatingSystemVersion")]
        public virtual string OperatingSystemVersion { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("screenHeight")]
        public virtual System.Nullable<int> ScreenHeight { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("screenWidth")]
        public virtual System.Nullable<int> ScreenWidth { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userAgent")]
        public virtual string UserAgent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EncryptedUserId : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("encryptedId")]
        public virtual string EncryptedId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("entityId")]
        public virtual System.Nullable<long> EntityId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("entityType")]
        public virtual string EntityType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EncryptionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("awsWrappedKeyInfo")]
        public virtual AwsWrappedKeyInfo AwsWrappedKeyInfo { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("coordinatorKeyInfo")]
        public virtual CoordinatorKeyInfo CoordinatorKeyInfo { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("gcpWrappedKeyInfo")]
        public virtual GcpWrappedKeyInfo GcpWrappedKeyInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ErrorCount : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ErrorInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("errorCounts")]
        public virtual System.Collections.Generic.IList<ErrorCount> ErrorCounts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Event : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("adIdentifiers")]
        public virtual AdIdentifiers AdIdentifiers { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("additionalEventParameters")]
        public virtual System.Collections.Generic.IList<EventParameter> AdditionalEventParameters { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("appInstanceId")]
        public virtual string AppInstanceId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("cartData")]
        public virtual CartData CartData { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("consent")]
        public virtual Consent Consent { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("conversionCount")]
        public virtual System.Nullable<double> ConversionCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("conversionValue")]
        public virtual System.Nullable<double> ConversionValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("currency")]
        public virtual string Currency { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("customVariables")]
        public virtual System.Collections.Generic.IList<CustomVariable> CustomVariables { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("destinationReferences")]
        public virtual System.Collections.Generic.IList<string> DestinationReferences { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("eventDeviceInfo")]
        public virtual DeviceInfo EventDeviceInfo { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("eventLocation")]
        public virtual EventLocation EventLocation { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("eventName")]
        public virtual string EventName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("eventSource")]
        public virtual string EventSource { get; set; }

        private string _eventTimestampRaw;

        private object _eventTimestamp;

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

        [Newtonsoft.Json.JsonPropertyAttribute("experimentalFields")]
        public virtual System.Collections.Generic.IList<ExperimentalField> ExperimentalFields { get; set; }

        private string _lastUpdatedTimestampRaw;

        private object _lastUpdatedTimestamp;

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

        [Newtonsoft.Json.JsonPropertyAttribute("thirdPartyUserData")]
        public virtual UserData ThirdPartyUserData { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("transactionId")]
        public virtual string TransactionId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userData")]
        public virtual UserData UserData { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userProperties")]
        public virtual UserProperties UserProperties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EventLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("city")]
        public virtual string City { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("continentCode")]
        public virtual string ContinentCode { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("storeId")]
        public virtual string StoreId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("subcontinentCode")]
        public virtual string SubcontinentCode { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("subdivisionCode")]
        public virtual string SubdivisionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EventParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("parameterName")]
        public virtual string ParameterName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ExperimentalField : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual string Field { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class FieldWarning : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual string Field { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GcpWrappedKeyInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("encryptedDek")]
        public virtual string EncryptedDek { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kekUri")]
        public virtual string KekUri { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("keyType")]
        public virtual string KeyType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("wipProvider")]
        public virtual string WipProvider { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleUserIdData : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("googleUserIds")]
        public virtual System.Collections.Generic.IList<string> GoogleUserIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class IngestAdEventsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("adEvents")]
        public virtual System.Collections.Generic.IList<AdEvent> AdEvents { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("encryptionInfo")]
        public virtual EncryptionInfo EncryptionInfo { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class IngestAdEventsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class IngestAudienceMembersRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("audienceMembers")]
        public virtual System.Collections.Generic.IList<AudienceMember> AudienceMembers { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("consent")]
        public virtual Consent Consent { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("destinations")]
        public virtual System.Collections.Generic.IList<Destination> Destinations { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("encoding")]
        public virtual string Encoding { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("encryptionInfo")]
        public virtual EncryptionInfo EncryptionInfo { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("termsOfService")]
        public virtual TermsOfService TermsOfService { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class IngestAudienceMembersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("fieldWarnings")]
        public virtual System.Collections.Generic.IList<FieldWarning> FieldWarnings { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class IngestAudienceMembersStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("compositeDataIngestionStatus")]
        public virtual IngestCompositeDataStatus CompositeDataIngestionStatus { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("googleUserIdDataIngestionStatus")]
        public virtual IngestGoogleUserIdDataStatus GoogleUserIdDataIngestionStatus { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("mobileDataIngestionStatus")]
        public virtual IngestMobileDataStatus MobileDataIngestionStatus { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("pairDataIngestionStatus")]
        public virtual IngestPairDataStatus PairDataIngestionStatus { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("partnerProvidedIdDataIngestionStatus")]
        public virtual IngestPartnerProvidedIdDataStatus PartnerProvidedIdDataIngestionStatus { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("ppidDataIngestionStatus")]
        public virtual IngestPpidDataStatus PpidDataIngestionStatus { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userDataIngestionStatus")]
        public virtual IngestUserDataStatus UserDataIngestionStatus { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userIdDataIngestionStatus")]
        public virtual IngestUserIdDataStatus UserIdDataIngestionStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class IngestCompositeDataStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("dataTypeCounts")]
        public virtual System.Collections.Generic.IList<DataTypeCount> DataTypeCounts { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("uploadMatchRateRange")]
        public virtual string UploadMatchRateRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class IngestEventsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("consent")]
        public virtual Consent Consent { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("destinations")]
        public virtual System.Collections.Generic.IList<Destination> Destinations { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("encoding")]
        public virtual string Encoding { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("encryptionInfo")]
        public virtual EncryptionInfo EncryptionInfo { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("events")]
        public virtual System.Collections.Generic.IList<Event> Events { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class IngestEventsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("fieldWarnings")]
        public virtual System.Collections.Generic.IList<FieldWarning> FieldWarnings { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class IngestEventsStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class IngestGoogleUserIdDataStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("googleUserIdCount")]
        public virtual System.Nullable<long> GoogleUserIdCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class IngestMobileDataStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("mobileIdCount")]
        public virtual System.Nullable<long> MobileIdCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class IngestPairDataStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("pairIdCount")]
        public virtual System.Nullable<long> PairIdCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class IngestPartnerProvidedIdDataStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("partnerProvidedIdCount")]
        public virtual System.Nullable<long> PartnerProvidedIdCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class IngestPpidDataStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("ppidCount")]
        public virtual System.Nullable<long> PpidCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class IngestUserDataStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("uploadMatchRateRange")]
        public virtual string UploadMatchRateRange { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userIdentifierCount")]
        public virtual System.Nullable<long> UserIdentifierCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class IngestUserIdDataStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userIdCount")]
        public virtual System.Nullable<long> UserIdCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class IngestedUserListInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("contactIdInfo")]
        public virtual ContactIdInfo ContactIdInfo { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("mobileIdInfo")]
        public virtual MobileIdInfo MobileIdInfo { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("pairIdInfo")]
        public virtual PairIdInfo PairIdInfo { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("partnerAudienceInfo")]
        public virtual PartnerAudienceInfo PartnerAudienceInfo { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("pseudonymousIdInfo")]
        public virtual PseudonymousIdInfo PseudonymousIdInfo { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("uploadKeyTypes")]
        public virtual System.Collections.Generic.IList<string> UploadKeyTypes { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userIdInfo")]
        public virtual UserIdInfo UserIdInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class IpData : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
        public virtual string IpAddress { get; set; }

        private string _observeEndTimeRaw;

        private object _observeEndTime;

        [Newtonsoft.Json.JsonPropertyAttribute("observeEndTime")]
        public virtual string ObserveEndTimeRaw
        {
            get => _observeEndTimeRaw;
            set
            {
                _observeEndTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _observeEndTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ObserveEndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ObserveEndTimeDateTimeOffset instead.")]
        public virtual object ObserveEndTime
        {
            get => _observeEndTime;
            set
            {
                _observeEndTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _observeEndTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ObserveEndTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ObserveEndTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ObserveEndTimeRaw);
            set => ObserveEndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _observeStartTimeRaw;

        private object _observeStartTime;

        [Newtonsoft.Json.JsonPropertyAttribute("observeStartTime")]
        public virtual string ObserveStartTimeRaw
        {
            get => _observeStartTimeRaw;
            set
            {
                _observeStartTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _observeStartTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ObserveStartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ObserveStartTimeDateTimeOffset instead.")]
        public virtual object ObserveStartTime
        {
            get => _observeStartTime;
            set
            {
                _observeStartTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _observeStartTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ObserveStartTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ObserveStartTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ObserveStartTimeRaw);
            set => ObserveStartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Item : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("additionalItemParameters")]
        public virtual System.Collections.Generic.IList<ItemParameter> AdditionalItemParameters { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("conversionValue")]
        public virtual System.Nullable<double> ConversionValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("customVariables")]
        public virtual System.Collections.Generic.IList<ItemCustomVariable> CustomVariables { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("itemId")]
        public virtual string ItemId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("merchantFeedLabel")]
        public virtual string MerchantFeedLabel { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("merchantFeedLanguageCode")]
        public virtual string MerchantFeedLanguageCode { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("merchantId")]
        public virtual string MerchantId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("merchantProductId")]
        public virtual string MerchantProductId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("quantity")]
        public virtual System.Nullable<long> Quantity { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("unitPrice")]
        public virtual System.Nullable<double> UnitPrice { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ItemCustomVariable : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("destinationReferences")]
        public virtual System.Collections.Generic.IList<string> DestinationReferences { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("variable")]
        public virtual string Variable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ItemParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("parameterName")]
        public virtual string ParameterName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListUserListDirectLicensesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userListDirectLicenses")]
        public virtual System.Collections.Generic.IList<UserListDirectLicense> UserListDirectLicenses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListUserListGlobalLicenseCustomerInfosResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userListGlobalLicenseCustomerInfos")]
        public virtual System.Collections.Generic.IList<UserListGlobalLicenseCustomerInfo> UserListGlobalLicenseCustomerInfos { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListUserListGlobalLicensesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userListGlobalLicenses")]
        public virtual System.Collections.Generic.IList<UserListGlobalLicense> UserListGlobalLicenses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListUserListsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userLists")]
        public virtual System.Collections.Generic.IList<UserList> UserLists { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Location : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("regionCodes")]
        public virtual System.Collections.Generic.IList<string> RegionCodes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class MarketingDataInsight : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IList<MarketingDataInsightsAttribute> Attributes { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("dimension")]
        public virtual string Dimension { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class MarketingDataInsightsAttribute : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("ageRange")]
        public virtual string AgeRange { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("gender")]
        public virtual string Gender { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("lift")]
        public virtual System.Nullable<float> Lift { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userInterestId")]
        public virtual System.Nullable<long> UserInterestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class MobileData : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("mobileIds")]
        public virtual System.Collections.Generic.IList<string> MobileIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class MobileIdInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("appId")]
        public virtual string AppId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceType")]
        public virtual string DataSourceType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("keySpace")]
        public virtual string KeySpace { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PairData : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("pairIds")]
        public virtual System.Collections.Generic.IList<string> PairIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PairIdInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserIdentifierCount")]
        public virtual System.Nullable<long> AdvertiserIdentifierCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("cleanRoomIdentifier")]
        public virtual string CleanRoomIdentifier { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("matchRatePercentage")]
        public virtual System.Nullable<int> MatchRatePercentage { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("publisherId")]
        public virtual System.Nullable<long> PublisherId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("publisherName")]
        public virtual string PublisherName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PartnerAudienceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("commercePartner")]
        public virtual string CommercePartner { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("partnerAudienceSource")]
        public virtual string PartnerAudienceSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PartnerCustomerAccount : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("accountName")]
        public virtual string AccountName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("accountType")]
        public virtual string AccountType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PartnerLink : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("featureSet")]
        public virtual string FeatureSet { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("owningAccount")]
        public virtual ProductAccount OwningAccount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("partnerAccount")]
        public virtual ProductAccount PartnerAccount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("partnerCustomerAccount")]
        public virtual PartnerCustomerAccount PartnerCustomerAccount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("partnerLinkId")]
        public virtual string PartnerLinkId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("partnerLinkMetadata")]
        public virtual PartnerLinkMetadata PartnerLinkMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PartnerLinkMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("implicitAccounts")]
        public virtual System.Collections.Generic.IList<PartnerCustomerAccount> ImplicitAccounts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PartnerProvidedIdData : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("partnerProvidedIds")]
        public virtual System.Collections.Generic.IList<string> PartnerProvidedIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PpidData : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("ppids")]
        public virtual System.Collections.Generic.IList<string> Ppids { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ProductAccount : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("accountType")]
        public virtual string AccountType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("product")]
        public virtual string Product { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PseudonymousIdInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("billableRecordCount")]
        public virtual System.Nullable<long> BillableRecordCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("syncStatus")]
        public virtual string SyncStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class RemoveAllAudienceMembersRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("destinations")]
        public virtual System.Collections.Generic.IList<Destination> Destinations { get; set; }

        private string _removeAsOfTimeRaw;

        private object _removeAsOfTime;

        [Newtonsoft.Json.JsonPropertyAttribute("removeAsOfTime")]
        public virtual string RemoveAsOfTimeRaw
        {
            get => _removeAsOfTimeRaw;
            set
            {
                _removeAsOfTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _removeAsOfTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RemoveAsOfTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RemoveAsOfTimeDateTimeOffset instead.")]
        public virtual object RemoveAsOfTime
        {
            get => _removeAsOfTime;
            set
            {
                _removeAsOfTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _removeAsOfTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="RemoveAsOfTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RemoveAsOfTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RemoveAsOfTimeRaw);
            set => RemoveAsOfTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class RemoveAllAudienceMembersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class RemoveAllAudienceMembersStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class RemoveAudienceMembersRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("audienceMembers")]
        public virtual System.Collections.Generic.IList<AudienceMember> AudienceMembers { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("destinations")]
        public virtual System.Collections.Generic.IList<Destination> Destinations { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("encoding")]
        public virtual string Encoding { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("encryptionInfo")]
        public virtual EncryptionInfo EncryptionInfo { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class RemoveAudienceMembersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class RemoveAudienceMembersStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("compositeDataRemovalStatus")]
        public virtual RemoveCompositeDataStatus CompositeDataRemovalStatus { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("googleUserIdDataRemovalStatus")]
        public virtual RemoveGoogleUserIdDataStatus GoogleUserIdDataRemovalStatus { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("mobileDataRemovalStatus")]
        public virtual RemoveMobileDataStatus MobileDataRemovalStatus { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("pairDataRemovalStatus")]
        public virtual RemovePairDataStatus PairDataRemovalStatus { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("partnerProvidedIdDataRemovalStatus")]
        public virtual RemovePartnerProvidedIdDataStatus PartnerProvidedIdDataRemovalStatus { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("ppidDataRemovalStatus")]
        public virtual RemovePpidDataStatus PpidDataRemovalStatus { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userDataRemovalStatus")]
        public virtual RemoveUserDataStatus UserDataRemovalStatus { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userIdDataRemovalStatus")]
        public virtual RemoveUserIdDataStatus UserIdDataRemovalStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class RemoveCompositeDataStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("dataTypeCounts")]
        public virtual System.Collections.Generic.IList<DataTypeCount> DataTypeCounts { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class RemoveGoogleUserIdDataStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("googleUserIdCount")]
        public virtual System.Nullable<long> GoogleUserIdCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class RemoveMobileDataStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("mobileIdCount")]
        public virtual System.Nullable<long> MobileIdCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class RemovePairDataStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("pairIdCount")]
        public virtual System.Nullable<long> PairIdCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class RemovePartnerProvidedIdDataStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("partnerProvidedIdCount")]
        public virtual System.Nullable<long> PartnerProvidedIdCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class RemovePpidDataStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("ppidCount")]
        public virtual System.Nullable<long> PpidCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class RemoveUserDataStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userIdentifierCount")]
        public virtual System.Nullable<long> UserIdentifierCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class RemoveUserIdDataStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userIdCount")]
        public virtual System.Nullable<long> UserIdCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class RequestStatusPerDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("audienceMembersIngestionStatus")]
        public virtual IngestAudienceMembersStatus AudienceMembersIngestionStatus { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("audienceMembersRemovalStatus")]
        public virtual RemoveAudienceMembersStatus AudienceMembersRemovalStatus { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("destination")]
        public virtual Destination Destination { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("errorInfo")]
        public virtual ErrorInfo ErrorInfo { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("eventsIngestionStatus")]
        public virtual IngestEventsStatus EventsIngestionStatus { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("removeAllAudienceMembersStatus")]
        public virtual RemoveAllAudienceMembersStatus RemoveAllAudienceMembersStatus { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("requestStatus")]
        public virtual string RequestStatus { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("warningInfo")]
        public virtual WarningInfo WarningInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class RetrieveInsightsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("baseline")]
        public virtual Baseline Baseline { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userListId")]
        public virtual string UserListId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class RetrieveInsightsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("marketingDataInsights")]
        public virtual System.Collections.Generic.IList<MarketingDataInsight> MarketingDataInsights { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class RetrieveRequestStatusResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("requestStatusPerDestination")]
        public virtual System.Collections.Generic.IList<RequestStatusPerDestination> RequestStatusPerDestination { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SearchPartnerLinksResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("partnerLinks")]
        public virtual System.Collections.Generic.IList<PartnerLink> PartnerLinks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SizeInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("displayNetworkMembersCount")]
        public virtual System.Nullable<long> DisplayNetworkMembersCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("gmailMembersCount")]
        public virtual System.Nullable<long> GmailMembersCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("searchNetworkMembersCount")]
        public virtual System.Nullable<long> SearchNetworkMembersCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("youtubeMembersCount")]
        public virtual System.Nullable<long> YoutubeMembersCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Status : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<int> Code { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Details { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class TargetNetworkInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("eligibleForDisplay")]
        public virtual System.Nullable<bool> EligibleForDisplay { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("eligibleForSearch")]
        public virtual System.Nullable<bool> EligibleForSearch { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class TermsOfService : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("customerMatchTermsOfServiceStatus")]
        public virtual string CustomerMatchTermsOfServiceStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class UserData : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("userIdentifiers")]
        public virtual System.Collections.Generic.IList<UserIdentifier> UserIdentifiers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class UserIdData : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class UserIdInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceType")]
        public virtual string DataSourceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class UserIdentifier : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual AddressInfo Address { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("emailAddress")]
        public virtual string EmailAddress { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("phoneNumber")]
        public virtual string PhoneNumber { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class UserList : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("accessReason")]
        public virtual string AccessReason { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("accountAccessStatus")]
        public virtual string AccountAccessStatus { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("closingReason")]
        public virtual string ClosingReason { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("ingestedUserListInfo")]
        public virtual IngestedUserListInfo IngestedUserListInfo { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("integrationCode")]
        public virtual string IntegrationCode { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("membershipDuration")]
        public virtual object MembershipDuration { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("membershipStatus")]
        public virtual string MembershipStatus { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("readOnly")]
        public virtual System.Nullable<bool> ReadOnly__ { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("sizeInfo")]
        public virtual SizeInfo SizeInfo { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("targetNetworkInfo")]
        public virtual TargetNetworkInfo TargetNetworkInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class UserListDirectLicense : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("clientAccountDisplayName")]
        public virtual string ClientAccountDisplayName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("clientAccountId")]
        public virtual System.Nullable<long> ClientAccountId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("clientAccountType")]
        public virtual string ClientAccountType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("historicalPricings")]
        public virtual System.Collections.Generic.IList<UserListLicensePricing> HistoricalPricings { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual UserListLicenseMetrics Metrics { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("pricing")]
        public virtual UserListLicensePricing Pricing { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userListDisplayName")]
        public virtual string UserListDisplayName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userListId")]
        public virtual System.Nullable<long> UserListId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class UserListGlobalLicense : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("historicalPricings")]
        public virtual System.Collections.Generic.IList<UserListLicensePricing> HistoricalPricings { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("licenseType")]
        public virtual string LicenseType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual UserListLicenseMetrics Metrics { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("pricing")]
        public virtual UserListLicensePricing Pricing { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userListDisplayName")]
        public virtual string UserListDisplayName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userListId")]
        public virtual System.Nullable<long> UserListId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class UserListGlobalLicenseCustomerInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("clientAccountDisplayName")]
        public virtual string ClientAccountDisplayName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("clientAccountId")]
        public virtual System.Nullable<long> ClientAccountId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("clientAccountType")]
        public virtual string ClientAccountType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("historicalPricings")]
        public virtual System.Collections.Generic.IList<UserListLicensePricing> HistoricalPricings { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("licenseType")]
        public virtual string LicenseType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual UserListLicenseMetrics Metrics { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("pricing")]
        public virtual UserListLicensePricing Pricing { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userListDisplayName")]
        public virtual string UserListDisplayName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userListId")]
        public virtual System.Nullable<long> UserListId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class UserListLicenseMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("clickCount")]
        public virtual System.Nullable<long> ClickCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual System.Nullable<long> EndDate { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("impressionCount")]
        public virtual System.Nullable<long> ImpressionCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("revenueUsdMicros")]
        public virtual System.Nullable<long> RevenueUsdMicros { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual System.Nullable<long> StartDate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class UserListLicensePricing : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("buyerApprovalState")]
        public virtual string BuyerApprovalState { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("costMicros")]
        public virtual System.Nullable<long> CostMicros { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("costType")]
        public virtual string CostType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        private string _endTimeRaw;

        private object _endTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("maxCostMicros")]
        public virtual System.Nullable<long> MaxCostMicros { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("pricingActive")]
        public virtual System.Nullable<bool> PricingActive { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("pricingId")]
        public virtual System.Nullable<long> PricingId { get; set; }

        private string _startTimeRaw;

        private object _startTime;

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

    public class UserProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("additionalUserProperties")]
        public virtual System.Collections.Generic.IList<UserProperty> AdditionalUserProperties { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("customerType")]
        public virtual string CustomerType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("customerValueBucket")]
        public virtual string CustomerValueBucket { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class UserProperty : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("propertyName")]
        public virtual string PropertyName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ViewabilityInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("mediaDuration")]
        public virtual object MediaDuration { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("mediaQuartile")]
        public virtual string MediaQuartile { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("mediaSkippable")]
        public virtual System.Nullable<bool> MediaSkippable { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("mediaVolumePercent")]
        public virtual System.Nullable<int> MediaVolumePercent { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("playbackDuration")]
        public virtual object PlaybackDuration { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("viewType")]
        public virtual string ViewType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("viewableDuration")]
        public virtual object ViewableDuration { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("viewablePercent")]
        public virtual System.Nullable<int> ViewablePercent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class WarningCount : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("recordCount")]
        public virtual System.Nullable<long> RecordCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class WarningInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("warningCounts")]
        public virtual System.Collections.Generic.IList<WarningCount> WarningCounts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
