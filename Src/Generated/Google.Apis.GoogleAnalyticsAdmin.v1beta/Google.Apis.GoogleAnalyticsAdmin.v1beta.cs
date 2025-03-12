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

namespace Google.Apis.GoogleAnalyticsAdmin.v1beta
{
    /// <summary>The GoogleAnalyticsAdmin Service.</summary>
    public class GoogleAnalyticsAdminService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public GoogleAnalyticsAdminService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public GoogleAnalyticsAdminService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            AccountSummaries = new AccountSummariesResource(this);
            Accounts = new AccountsResource(this);
            Properties = new PropertiesResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://analyticsadmin.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://analyticsadmin.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "analyticsadmin";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Google Analytics Admin API.</summary>
        public class Scope
        {
            /// <summary>Edit Google Analytics management entities</summary>
            public static string AnalyticsEdit = "https://www.googleapis.com/auth/analytics.edit";

            /// <summary>See and download your Google Analytics data</summary>
            public static string AnalyticsReadonly = "https://www.googleapis.com/auth/analytics.readonly";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Google Analytics Admin API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Edit Google Analytics management entities</summary>
            public const string AnalyticsEdit = "https://www.googleapis.com/auth/analytics.edit";

            /// <summary>See and download your Google Analytics data</summary>
            public const string AnalyticsReadonly = "https://www.googleapis.com/auth/analytics.readonly";
        }

        /// <summary>Gets the AccountSummaries resource.</summary>
        public virtual AccountSummariesResource AccountSummaries { get; }

        /// <summary>Gets the Accounts resource.</summary>
        public virtual AccountsResource Accounts { get; }

        /// <summary>Gets the Properties resource.</summary>
        public virtual PropertiesResource Properties { get; }
    }

    /// <summary>A base abstract class for GoogleAnalyticsAdmin requests.</summary>
    public abstract class GoogleAnalyticsAdminBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new GoogleAnalyticsAdminBaseServiceRequest instance.</summary>
        protected GoogleAnalyticsAdminBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes GoogleAnalyticsAdmin parameter list.</summary>
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

    /// <summary>The "accountSummaries" collection of methods.</summary>
    public class AccountSummariesResource
    {
        private const string Resource = "accountSummaries";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AccountSummariesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Returns summaries of all accounts accessible by the caller.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Returns summaries of all accounts accessible by the caller.</summary>
        public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaListAccountSummariesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// The maximum number of AccountSummary resources to return. The service may return fewer than this value,
            /// even if there are additional pages. If unspecified, at most 50 resources will be returned. The maximum
            /// value is 200; (higher values will be coerced to the maximum)
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// A page token, received from a previous `ListAccountSummaries` call. Provide this to retrieve the
            /// subsequent page. When paginating, all other parameters provided to `ListAccountSummaries` must match the
            /// call that provided the page token.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/accountSummaries";

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
        }

        /// <summary>
        /// Marks target Account as soft-deleted (ie: "trashed") and returns it. This API does not have a method to
        /// restore soft-deleted accounts. However, they can be restored using the Trash Can UI. If the accounts are not
        /// restored before the expiration time, the account and all child resources (eg: Properties, GoogleAdsLinks,
        /// Streams, AccessBindings) will be permanently purged. https://support.google.com/analytics/answer/6154772
        /// Returns an error if the target is not found.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Account to soft-delete. Format: accounts/{account} Example: "accounts/100"
        /// </param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(this.service, name);
        }

        /// <summary>
        /// Marks target Account as soft-deleted (ie: "trashed") and returns it. This API does not have a method to
        /// restore soft-deleted accounts. However, they can be restored using the Trash Can UI. If the accounts are not
        /// restored before the expiration time, the account and all child resources (eg: Properties, GoogleAdsLinks,
        /// Streams, AccessBindings) will be permanently purged. https://support.google.com/analytics/answer/6154772
        /// Returns an error if the target is not found.
        /// </summary>
        public class DeleteRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleProtobufEmpty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the Account to soft-delete. Format: accounts/{account} Example: "accounts/100"
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/{+name}";

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
                    Pattern = @"^accounts/[^/]+$",
                });
            }
        }

        /// <summary>Lookup for a single Account.</summary>
        /// <param name="name">
        /// Required. The name of the account to lookup. Format: accounts/{account} Example: "accounts/100"
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(this.service, name);
        }

        /// <summary>Lookup for a single Account.</summary>
        public class GetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaAccount>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the account to lookup. Format: accounts/{account} Example: "accounts/100"
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/{+name}";

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
                    Pattern = @"^accounts/[^/]+$",
                });
            }
        }

        /// <summary>Get data sharing settings on an account. Data sharing settings are singletons.</summary>
        /// <param name="name">
        /// Required. The name of the settings to lookup. Format: accounts/{account}/dataSharingSettings Example:
        /// `accounts/1000/dataSharingSettings`
        /// </param>
        public virtual GetDataSharingSettingsRequest GetDataSharingSettings(string name)
        {
            return new GetDataSharingSettingsRequest(this.service, name);
        }

        /// <summary>Get data sharing settings on an account. Data sharing settings are singletons.</summary>
        public class GetDataSharingSettingsRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaDataSharingSettings>
        {
            /// <summary>Constructs a new GetDataSharingSettings request.</summary>
            public GetDataSharingSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the settings to lookup. Format: accounts/{account}/dataSharingSettings Example:
            /// `accounts/1000/dataSharingSettings`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getDataSharingSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/{+name}";

            /// <summary>Initializes GetDataSharingSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^accounts/[^/]+/dataSharingSettings$",
                });
            }
        }

        /// <summary>
        /// Returns all accounts accessible by the caller. Note that these accounts might not currently have GA
        /// properties. Soft-deleted (ie: "trashed") accounts are excluded by default. Returns an empty list if no
        /// relevant accounts are found.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>
        /// Returns all accounts accessible by the caller. Note that these accounts might not currently have GA
        /// properties. Soft-deleted (ie: "trashed") accounts are excluded by default. Returns an empty list if no
        /// relevant accounts are found.
        /// </summary>
        public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaListAccountsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// The maximum number of resources to return. The service may return fewer than this value, even if there
            /// are additional pages. If unspecified, at most 50 resources will be returned. The maximum value is 200;
            /// (higher values will be coerced to the maximum)
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// A page token, received from a previous `ListAccounts` call. Provide this to retrieve the subsequent
            /// page. When paginating, all other parameters provided to `ListAccounts` must match the call that provided
            /// the page token.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Whether to include soft-deleted (ie: "trashed") Accounts in the results. Accounts can be inspected to
            /// determine whether they are deleted or not.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ShowDeleted { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/accounts";

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
                RequestParameters.Add("showDeleted", new Google.Apis.Discovery.Parameter
                {
                    Name = "showDeleted",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates an account.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Output only. Resource name of this account. Format: accounts/{account} Example: "accounts/100"
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaAccount body, string name)
        {
            return new PatchRequest(this.service, body, name);
        }

        /// <summary>Updates an account.</summary>
        public class PatchRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaAccount>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaAccount body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Output only. Resource name of this account. Format: accounts/{account} Example: "accounts/100"
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// Required. The list of fields to be updated. Field names must be in snake case (for example,
            /// "field_to_update"). Omitted fields will not be updated. To replace the entire entity, use one path with
            /// the string "*" to match all fields.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaAccount Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/{+name}";

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
                    Pattern = @"^accounts/[^/]+$",
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

        /// <summary>Requests a ticket for creating an account.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual ProvisionAccountTicketRequest ProvisionAccountTicket(Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaProvisionAccountTicketRequest body)
        {
            return new ProvisionAccountTicketRequest(this.service, body);
        }

        /// <summary>Requests a ticket for creating an account.</summary>
        public class ProvisionAccountTicketRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaProvisionAccountTicketResponse>
        {
            /// <summary>Constructs a new ProvisionAccountTicket request.</summary>
            public ProvisionAccountTicketRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaProvisionAccountTicketRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaProvisionAccountTicketRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "provisionAccountTicket";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/accounts:provisionAccountTicket";

            /// <summary>Initializes ProvisionAccountTicket parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Returns a customized report of data access records. The report provides records of each time a user reads
        /// Google Analytics reporting data. Access records are retained for up to 2 years. Data Access Reports can be
        /// requested for a property. Reports may be requested for any property, but dimensions that aren't related to
        /// quota can only be requested on Google Analytics 360 properties. This method is only available to
        /// Administrators. These data access records include GA UI Reporting, GA UI Explorations, GA Data API, and
        /// other products like Firebase &amp;amp; Admob that can retrieve data from Google Analytics through a linkage.
        /// These records don't include property configuration changes like adding a stream or changing a property's
        /// time zone. For configuration change history, see
        /// [searchChangeHistoryEvents](https://developers.google.com/analytics/devguides/config/admin/v1/rest/v1alpha/accounts/searchChangeHistoryEvents).
        /// To give your feedback on this API, complete the [Google Analytics Access Reports
        /// feedback](https://docs.google.com/forms/d/e/1FAIpQLSdmEBUrMzAEdiEKk5TV5dEHvDUZDRlgWYdQdAeSdtR4hVjEhw/viewform)
        /// form.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="entity">
        /// The Data Access Report supports requesting at the property level or account level. If requested at the
        /// account level, Data Access Reports include all access for all properties under that account. To request at
        /// the property level, entity should be for example 'properties/123' if "123" is your Google Analytics property
        /// ID. To request at the account level, entity should be for example 'accounts/1234' if "1234" is your Google
        /// Analytics Account ID.
        /// </param>
        public virtual RunAccessReportRequest RunAccessReport(Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaRunAccessReportRequest body, string entity)
        {
            return new RunAccessReportRequest(this.service, body, entity);
        }

        /// <summary>
        /// Returns a customized report of data access records. The report provides records of each time a user reads
        /// Google Analytics reporting data. Access records are retained for up to 2 years. Data Access Reports can be
        /// requested for a property. Reports may be requested for any property, but dimensions that aren't related to
        /// quota can only be requested on Google Analytics 360 properties. This method is only available to
        /// Administrators. These data access records include GA UI Reporting, GA UI Explorations, GA Data API, and
        /// other products like Firebase &amp;amp; Admob that can retrieve data from Google Analytics through a linkage.
        /// These records don't include property configuration changes like adding a stream or changing a property's
        /// time zone. For configuration change history, see
        /// [searchChangeHistoryEvents](https://developers.google.com/analytics/devguides/config/admin/v1/rest/v1alpha/accounts/searchChangeHistoryEvents).
        /// To give your feedback on this API, complete the [Google Analytics Access Reports
        /// feedback](https://docs.google.com/forms/d/e/1FAIpQLSdmEBUrMzAEdiEKk5TV5dEHvDUZDRlgWYdQdAeSdtR4hVjEhw/viewform)
        /// form.
        /// </summary>
        public class RunAccessReportRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaRunAccessReportResponse>
        {
            /// <summary>Constructs a new RunAccessReport request.</summary>
            public RunAccessReportRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaRunAccessReportRequest body, string entity) : base(service)
            {
                Entity = entity;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The Data Access Report supports requesting at the property level or account level. If requested at the
            /// account level, Data Access Reports include all access for all properties under that account. To request
            /// at the property level, entity should be for example 'properties/123' if "123" is your Google Analytics
            /// property ID. To request at the account level, entity should be for example 'accounts/1234' if "1234" is
            /// your Google Analytics Account ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("entity", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Entity { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaRunAccessReportRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "runAccessReport";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/{+entity}:runAccessReport";

            /// <summary>Initializes RunAccessReport parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("entity", new Google.Apis.Discovery.Parameter
                {
                    Name = "entity",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^accounts/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Searches through all changes to an account or its children given the specified set of filters. Only returns
        /// the subset of changes supported by the API. The UI may return additional changes.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="account">
        /// Required. The account resource for which to return change history resources. Format: accounts/{account}
        /// Example: `accounts/100`
        /// </param>
        public virtual SearchChangeHistoryEventsRequest SearchChangeHistoryEvents(Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaSearchChangeHistoryEventsRequest body, string account)
        {
            return new SearchChangeHistoryEventsRequest(this.service, body, account);
        }

        /// <summary>
        /// Searches through all changes to an account or its children given the specified set of filters. Only returns
        /// the subset of changes supported by the API. The UI may return additional changes.
        /// </summary>
        public class SearchChangeHistoryEventsRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaSearchChangeHistoryEventsResponse>
        {
            /// <summary>Constructs a new SearchChangeHistoryEvents request.</summary>
            public SearchChangeHistoryEventsRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaSearchChangeHistoryEventsRequest body, string account) : base(service)
            {
                Account = account;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. The account resource for which to return change history resources. Format: accounts/{account}
            /// Example: `accounts/100`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("account", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Account { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaSearchChangeHistoryEventsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "searchChangeHistoryEvents";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/{+account}:searchChangeHistoryEvents";

            /// <summary>Initializes SearchChangeHistoryEvents parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("account", new Google.Apis.Discovery.Parameter
                {
                    Name = "account",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^accounts/[^/]+$",
                });
            }
        }
    }

    /// <summary>The "properties" collection of methods.</summary>
    public class PropertiesResource
    {
        private const string Resource = "properties";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PropertiesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            ConversionEvents = new ConversionEventsResource(service);
            CustomDimensions = new CustomDimensionsResource(service);
            CustomMetrics = new CustomMetricsResource(service);
            DataStreams = new DataStreamsResource(service);
            FirebaseLinks = new FirebaseLinksResource(service);
            GoogleAdsLinks = new GoogleAdsLinksResource(service);
            KeyEvents = new KeyEventsResource(service);
        }

        /// <summary>Gets the ConversionEvents resource.</summary>
        public virtual ConversionEventsResource ConversionEvents { get; }

        /// <summary>The "conversionEvents" collection of methods.</summary>
        public class ConversionEventsResource
        {
            private const string Resource = "conversionEvents";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ConversionEventsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Deprecated: Use `CreateKeyEvent` instead. Creates a conversion event with the specified attributes.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The resource name of the parent property where this conversion event will be created. Format:
            /// properties/123
            /// </param>
            public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaConversionEvent body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Deprecated: Use `CreateKeyEvent` instead. Creates a conversion event with the specified attributes.
            /// </summary>
            public class CreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaConversionEvent>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaConversionEvent body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the parent property where this conversion event will be created.
                /// Format: properties/123
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaConversionEvent Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/conversionEvents";

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
                        Pattern = @"^properties/[^/]+$",
                    });
                }
            }

            /// <summary>Deprecated: Use `DeleteKeyEvent` instead. Deletes a conversion event in a property.</summary>
            /// <param name="name">
            /// Required. The resource name of the conversion event to delete. Format:
            /// properties/{property}/conversionEvents/{conversion_event} Example: "properties/123/conversionEvents/456"
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>Deprecated: Use `DeleteKeyEvent` instead. Deletes a conversion event in a property.</summary>
            public class DeleteRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the conversion event to delete. Format:
                /// properties/{property}/conversionEvents/{conversion_event} Example:
                /// "properties/123/conversionEvents/456"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}";

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
                        Pattern = @"^properties/[^/]+/conversionEvents/[^/]+$",
                    });
                }
            }

            /// <summary>Deprecated: Use `GetKeyEvent` instead. Retrieve a single conversion event.</summary>
            /// <param name="name">
            /// Required. The resource name of the conversion event to retrieve. Format:
            /// properties/{property}/conversionEvents/{conversion_event} Example: "properties/123/conversionEvents/456"
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Deprecated: Use `GetKeyEvent` instead. Retrieve a single conversion event.</summary>
            public class GetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaConversionEvent>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the conversion event to retrieve. Format:
                /// properties/{property}/conversionEvents/{conversion_event} Example:
                /// "properties/123/conversionEvents/456"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}";

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
                        Pattern = @"^properties/[^/]+/conversionEvents/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Deprecated: Use `ListKeyEvents` instead. Returns a list of conversion events in the specified parent
            /// property. Returns an empty list if no conversion events are found.
            /// </summary>
            /// <param name="parent">
            /// Required. The resource name of the parent property. Example: 'properties/123'
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>
            /// Deprecated: Use `ListKeyEvents` instead. Returns a list of conversion events in the specified parent
            /// property. Returns an empty list if no conversion events are found.
            /// </summary>
            public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaListConversionEventsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. The resource name of the parent property. Example: 'properties/123'</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of resources to return. If unspecified, at most 50 resources will be returned.
                /// The maximum value is 200; (higher values will be coerced to the maximum)
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token, received from a previous `ListConversionEvents` call. Provide this to retrieve the
                /// subsequent page. When paginating, all other parameters provided to `ListConversionEvents` must match
                /// the call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/conversionEvents";

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
                        Pattern = @"^properties/[^/]+$",
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
            /// Deprecated: Use `UpdateKeyEvent` instead. Updates a conversion event with the specified attributes.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Output only. Resource name of this conversion event. Format:
            /// properties/{property}/conversionEvents/{conversion_event}
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaConversionEvent body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>
            /// Deprecated: Use `UpdateKeyEvent` instead. Updates a conversion event with the specified attributes.
            /// </summary>
            public class PatchRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaConversionEvent>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaConversionEvent body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Output only. Resource name of this conversion event. Format:
                /// properties/{property}/conversionEvents/{conversion_event}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Required. The list of fields to be updated. Field names must be in snake case (e.g.,
                /// "field_to_update"). Omitted fields will not be updated. To replace the entire entity, use one path
                /// with the string "*" to match all fields.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaConversionEvent Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}";

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
                        Pattern = @"^properties/[^/]+/conversionEvents/[^/]+$",
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

        /// <summary>Gets the CustomDimensions resource.</summary>
        public virtual CustomDimensionsResource CustomDimensions { get; }

        /// <summary>The "customDimensions" collection of methods.</summary>
        public class CustomDimensionsResource
        {
            private const string Resource = "customDimensions";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public CustomDimensionsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Archives a CustomDimension on a property.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The name of the CustomDimension to archive. Example format:
            /// properties/1234/customDimensions/5678
            /// </param>
            public virtual ArchiveRequest Archive(Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaArchiveCustomDimensionRequest body, string name)
            {
                return new ArchiveRequest(this.service, body, name);
            }

            /// <summary>Archives a CustomDimension on a property.</summary>
            public class ArchiveRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Archive request.</summary>
                public ArchiveRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaArchiveCustomDimensionRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the CustomDimension to archive. Example format:
                /// properties/1234/customDimensions/5678
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaArchiveCustomDimensionRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "archive";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}:archive";

                /// <summary>Initializes Archive parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^properties/[^/]+/customDimensions/[^/]+$",
                    });
                }
            }

            /// <summary>Creates a CustomDimension.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. Example format: properties/1234</param>
            public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaCustomDimension body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>Creates a CustomDimension.</summary>
            public class CreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaCustomDimension>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaCustomDimension body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Example format: properties/1234</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaCustomDimension Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/customDimensions";

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
                        Pattern = @"^properties/[^/]+$",
                    });
                }
            }

            /// <summary>Lookup for a single CustomDimension.</summary>
            /// <param name="name">
            /// Required. The name of the CustomDimension to get. Example format: properties/1234/customDimensions/5678
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Lookup for a single CustomDimension.</summary>
            public class GetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaCustomDimension>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the CustomDimension to get. Example format:
                /// properties/1234/customDimensions/5678
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}";

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
                        Pattern = @"^properties/[^/]+/customDimensions/[^/]+$",
                    });
                }
            }

            /// <summary>Lists CustomDimensions on a property.</summary>
            /// <param name="parent">Required. Example format: properties/1234</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists CustomDimensions on a property.</summary>
            public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaListCustomDimensionsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. Example format: properties/1234</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of resources to return. If unspecified, at most 50 resources will be returned.
                /// The maximum value is 200 (higher values will be coerced to the maximum).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token, received from a previous `ListCustomDimensions` call. Provide this to retrieve the
                /// subsequent page. When paginating, all other parameters provided to `ListCustomDimensions` must match
                /// the call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/customDimensions";

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
                        Pattern = @"^properties/[^/]+$",
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

            /// <summary>Updates a CustomDimension on a property.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Output only. Resource name for this CustomDimension resource. Format:
            /// properties/{property}/customDimensions/{customDimension}
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaCustomDimension body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>Updates a CustomDimension on a property.</summary>
            public class PatchRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaCustomDimension>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaCustomDimension body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Output only. Resource name for this CustomDimension resource. Format:
                /// properties/{property}/customDimensions/{customDimension}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Required. The list of fields to be updated. Omitted fields will not be updated. To replace the
                /// entire entity, use one path with the string "*" to match all fields.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaCustomDimension Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}";

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
                        Pattern = @"^properties/[^/]+/customDimensions/[^/]+$",
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

        /// <summary>Gets the CustomMetrics resource.</summary>
        public virtual CustomMetricsResource CustomMetrics { get; }

        /// <summary>The "customMetrics" collection of methods.</summary>
        public class CustomMetricsResource
        {
            private const string Resource = "customMetrics";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public CustomMetricsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Archives a CustomMetric on a property.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The name of the CustomMetric to archive. Example format: properties/1234/customMetrics/5678
            /// </param>
            public virtual ArchiveRequest Archive(Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaArchiveCustomMetricRequest body, string name)
            {
                return new ArchiveRequest(this.service, body, name);
            }

            /// <summary>Archives a CustomMetric on a property.</summary>
            public class ArchiveRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Archive request.</summary>
                public ArchiveRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaArchiveCustomMetricRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the CustomMetric to archive. Example format:
                /// properties/1234/customMetrics/5678
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaArchiveCustomMetricRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "archive";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}:archive";

                /// <summary>Initializes Archive parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^properties/[^/]+/customMetrics/[^/]+$",
                    });
                }
            }

            /// <summary>Creates a CustomMetric.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. Example format: properties/1234</param>
            public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaCustomMetric body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>Creates a CustomMetric.</summary>
            public class CreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaCustomMetric>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaCustomMetric body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Example format: properties/1234</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaCustomMetric Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/customMetrics";

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
                        Pattern = @"^properties/[^/]+$",
                    });
                }
            }

            /// <summary>Lookup for a single CustomMetric.</summary>
            /// <param name="name">
            /// Required. The name of the CustomMetric to get. Example format: properties/1234/customMetrics/5678
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Lookup for a single CustomMetric.</summary>
            public class GetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaCustomMetric>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the CustomMetric to get. Example format: properties/1234/customMetrics/5678
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}";

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
                        Pattern = @"^properties/[^/]+/customMetrics/[^/]+$",
                    });
                }
            }

            /// <summary>Lists CustomMetrics on a property.</summary>
            /// <param name="parent">Required. Example format: properties/1234</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists CustomMetrics on a property.</summary>
            public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaListCustomMetricsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. Example format: properties/1234</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of resources to return. If unspecified, at most 50 resources will be returned.
                /// The maximum value is 200 (higher values will be coerced to the maximum).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token, received from a previous `ListCustomMetrics` call. Provide this to retrieve the
                /// subsequent page. When paginating, all other parameters provided to `ListCustomMetrics` must match
                /// the call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/customMetrics";

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
                        Pattern = @"^properties/[^/]+$",
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

            /// <summary>Updates a CustomMetric on a property.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Output only. Resource name for this CustomMetric resource. Format:
            /// properties/{property}/customMetrics/{customMetric}
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaCustomMetric body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>Updates a CustomMetric on a property.</summary>
            public class PatchRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaCustomMetric>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaCustomMetric body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Output only. Resource name for this CustomMetric resource. Format:
                /// properties/{property}/customMetrics/{customMetric}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Required. The list of fields to be updated. Omitted fields will not be updated. To replace the
                /// entire entity, use one path with the string "*" to match all fields.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaCustomMetric Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}";

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
                        Pattern = @"^properties/[^/]+/customMetrics/[^/]+$",
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

        /// <summary>Gets the DataStreams resource.</summary>
        public virtual DataStreamsResource DataStreams { get; }

        /// <summary>The "dataStreams" collection of methods.</summary>
        public class DataStreamsResource
        {
            private const string Resource = "dataStreams";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public DataStreamsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                MeasurementProtocolSecrets = new MeasurementProtocolSecretsResource(service);
            }

            /// <summary>Gets the MeasurementProtocolSecrets resource.</summary>
            public virtual MeasurementProtocolSecretsResource MeasurementProtocolSecrets { get; }

            /// <summary>The "measurementProtocolSecrets" collection of methods.</summary>
            public class MeasurementProtocolSecretsResource
            {
                private const string Resource = "measurementProtocolSecrets";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public MeasurementProtocolSecretsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a measurement protocol secret.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource where this secret will be created. Format:
                /// properties/{property}/dataStreams/{dataStream}
                /// </param>
                public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaMeasurementProtocolSecret body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a measurement protocol secret.</summary>
                public class CreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaMeasurementProtocolSecret>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaMeasurementProtocolSecret body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource where this secret will be created. Format:
                    /// properties/{property}/dataStreams/{dataStream}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaMeasurementProtocolSecret Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+parent}/measurementProtocolSecrets";

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
                            Pattern = @"^properties/[^/]+/dataStreams/[^/]+$",
                        });
                    }
                }

                /// <summary>Deletes target MeasurementProtocolSecret.</summary>
                /// <param name="name">
                /// Required. The name of the MeasurementProtocolSecret to delete. Format:
                /// properties/{property}/dataStreams/{dataStream}/measurementProtocolSecrets/{measurementProtocolSecret}
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes target MeasurementProtocolSecret.</summary>
                public class DeleteRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the MeasurementProtocolSecret to delete. Format:
                    /// properties/{property}/dataStreams/{dataStream}/measurementProtocolSecrets/{measurementProtocolSecret}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}";

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
                            Pattern = @"^properties/[^/]+/dataStreams/[^/]+/measurementProtocolSecrets/[^/]+$",
                        });
                    }
                }

                /// <summary>Lookup for a single MeasurementProtocolSecret.</summary>
                /// <param name="name">
                /// Required. The name of the measurement protocol secret to lookup. Format:
                /// properties/{property}/dataStreams/{dataStream}/measurementProtocolSecrets/{measurementProtocolSecret}
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Lookup for a single MeasurementProtocolSecret.</summary>
                public class GetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaMeasurementProtocolSecret>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the measurement protocol secret to lookup. Format:
                    /// properties/{property}/dataStreams/{dataStream}/measurementProtocolSecrets/{measurementProtocolSecret}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}";

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
                            Pattern = @"^properties/[^/]+/dataStreams/[^/]+/measurementProtocolSecrets/[^/]+$",
                        });
                    }
                }

                /// <summary>Returns child MeasurementProtocolSecrets under the specified parent Property.</summary>
                /// <param name="parent">
                /// Required. The resource name of the parent stream. Format:
                /// properties/{property}/dataStreams/{dataStream}/measurementProtocolSecrets
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Returns child MeasurementProtocolSecrets under the specified parent Property.</summary>
                public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaListMeasurementProtocolSecretsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the parent stream. Format:
                    /// properties/{property}/dataStreams/{dataStream}/measurementProtocolSecrets
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of resources to return. If unspecified, at most 10 resources will be
                    /// returned. The maximum value is 10. Higher values will be coerced to the maximum.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `ListMeasurementProtocolSecrets` call. Provide this to
                    /// retrieve the subsequent page. When paginating, all other parameters provided to
                    /// `ListMeasurementProtocolSecrets` must match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+parent}/measurementProtocolSecrets";

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
                            Pattern = @"^properties/[^/]+/dataStreams/[^/]+$",
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

                /// <summary>Updates a measurement protocol secret.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. Resource name of this secret. This secret may be a child of any type of stream. Format:
                /// properties/{property}/dataStreams/{dataStream}/measurementProtocolSecrets/{measurementProtocolSecret}
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaMeasurementProtocolSecret body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates a measurement protocol secret.</summary>
                public class PatchRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaMeasurementProtocolSecret>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaMeasurementProtocolSecret body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. Resource name of this secret. This secret may be a child of any type of stream.
                    /// Format:
                    /// properties/{property}/dataStreams/{dataStream}/measurementProtocolSecrets/{measurementProtocolSecret}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. The list of fields to be updated. Omitted fields will not be updated.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaMeasurementProtocolSecret Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}";

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
                            Pattern = @"^properties/[^/]+/dataStreams/[^/]+/measurementProtocolSecrets/[^/]+$",
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

            /// <summary>Creates a DataStream.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. Example format: properties/1234</param>
            public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaDataStream body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>Creates a DataStream.</summary>
            public class CreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaDataStream>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaDataStream body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Example format: properties/1234</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaDataStream Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/dataStreams";

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
                        Pattern = @"^properties/[^/]+$",
                    });
                }
            }

            /// <summary>Deletes a DataStream on a property.</summary>
            /// <param name="name">
            /// Required. The name of the DataStream to delete. Example format: properties/1234/dataStreams/5678
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>Deletes a DataStream on a property.</summary>
            public class DeleteRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the DataStream to delete. Example format: properties/1234/dataStreams/5678
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}";

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
                        Pattern = @"^properties/[^/]+/dataStreams/[^/]+$",
                    });
                }
            }

            /// <summary>Lookup for a single DataStream.</summary>
            /// <param name="name">
            /// Required. The name of the DataStream to get. Example format: properties/1234/dataStreams/5678
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Lookup for a single DataStream.</summary>
            public class GetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaDataStream>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the DataStream to get. Example format: properties/1234/dataStreams/5678
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}";

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
                        Pattern = @"^properties/[^/]+/dataStreams/[^/]+$",
                    });
                }
            }

            /// <summary>Lists DataStreams on a property.</summary>
            /// <param name="parent">Required. Example format: properties/1234</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists DataStreams on a property.</summary>
            public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaListDataStreamsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. Example format: properties/1234</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of resources to return. If unspecified, at most 50 resources will be returned.
                /// The maximum value is 200 (higher values will be coerced to the maximum).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token, received from a previous `ListDataStreams` call. Provide this to retrieve the
                /// subsequent page. When paginating, all other parameters provided to `ListDataStreams` must match the
                /// call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/dataStreams";

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
                        Pattern = @"^properties/[^/]+$",
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

            /// <summary>Updates a DataStream on a property.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Output only. Resource name of this Data Stream. Format: properties/{property_id}/dataStreams/{stream_id}
            /// Example: "properties/1000/dataStreams/2000"
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaDataStream body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>Updates a DataStream on a property.</summary>
            public class PatchRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaDataStream>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaDataStream body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Output only. Resource name of this Data Stream. Format:
                /// properties/{property_id}/dataStreams/{stream_id} Example: "properties/1000/dataStreams/2000"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Required. The list of fields to be updated. Omitted fields will not be updated. To replace the
                /// entire entity, use one path with the string "*" to match all fields.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaDataStream Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}";

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
                        Pattern = @"^properties/[^/]+/dataStreams/[^/]+$",
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

        /// <summary>Gets the FirebaseLinks resource.</summary>
        public virtual FirebaseLinksResource FirebaseLinks { get; }

        /// <summary>The "firebaseLinks" collection of methods.</summary>
        public class FirebaseLinksResource
        {
            private const string Resource = "firebaseLinks";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public FirebaseLinksResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a FirebaseLink. Properties can have at most one FirebaseLink.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. Format: properties/{property_id} Example: `properties/1234`</param>
            public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaFirebaseLink body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>Creates a FirebaseLink. Properties can have at most one FirebaseLink.</summary>
            public class CreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaFirebaseLink>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaFirebaseLink body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Format: properties/{property_id} Example: `properties/1234`</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaFirebaseLink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/firebaseLinks";

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
                        Pattern = @"^properties/[^/]+$",
                    });
                }
            }

            /// <summary>Deletes a FirebaseLink on a property</summary>
            /// <param name="name">
            /// Required. Format: properties/{property_id}/firebaseLinks/{firebase_link_id} Example:
            /// `properties/1234/firebaseLinks/5678`
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>Deletes a FirebaseLink on a property</summary>
            public class DeleteRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Format: properties/{property_id}/firebaseLinks/{firebase_link_id} Example:
                /// `properties/1234/firebaseLinks/5678`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}";

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
                        Pattern = @"^properties/[^/]+/firebaseLinks/[^/]+$",
                    });
                }
            }

            /// <summary>Lists FirebaseLinks on a property. Properties can have at most one FirebaseLink.</summary>
            /// <param name="parent">Required. Format: properties/{property_id} Example: `properties/1234`</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists FirebaseLinks on a property. Properties can have at most one FirebaseLink.</summary>
            public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaListFirebaseLinksResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. Format: properties/{property_id} Example: `properties/1234`</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of resources to return. The service may return fewer than this value, even if
                /// there are additional pages. If unspecified, at most 50 resources will be returned. The maximum value
                /// is 200; (higher values will be coerced to the maximum)
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token, received from a previous `ListFirebaseLinks` call. Provide this to retrieve the
                /// subsequent page. When paginating, all other parameters provided to `ListFirebaseLinks` must match
                /// the call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/firebaseLinks";

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
                        Pattern = @"^properties/[^/]+$",
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

        /// <summary>Gets the GoogleAdsLinks resource.</summary>
        public virtual GoogleAdsLinksResource GoogleAdsLinks { get; }

        /// <summary>The "googleAdsLinks" collection of methods.</summary>
        public class GoogleAdsLinksResource
        {
            private const string Resource = "googleAdsLinks";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public GoogleAdsLinksResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a GoogleAdsLink.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. Example format: properties/1234</param>
            public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaGoogleAdsLink body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>Creates a GoogleAdsLink.</summary>
            public class CreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaGoogleAdsLink>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaGoogleAdsLink body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Example format: properties/1234</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaGoogleAdsLink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/googleAdsLinks";

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
                        Pattern = @"^properties/[^/]+$",
                    });
                }
            }

            /// <summary>Deletes a GoogleAdsLink on a property</summary>
            /// <param name="name">Required. Example format: properties/1234/googleAdsLinks/5678</param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>Deletes a GoogleAdsLink on a property</summary>
            public class DeleteRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. Example format: properties/1234/googleAdsLinks/5678</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}";

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
                        Pattern = @"^properties/[^/]+/googleAdsLinks/[^/]+$",
                    });
                }
            }

            /// <summary>Lists GoogleAdsLinks on a property.</summary>
            /// <param name="parent">Required. Example format: properties/1234</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists GoogleAdsLinks on a property.</summary>
            public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaListGoogleAdsLinksResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. Example format: properties/1234</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of resources to return. If unspecified, at most 50 resources will be returned.
                /// The maximum value is 200 (higher values will be coerced to the maximum).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token, received from a previous `ListGoogleAdsLinks` call. Provide this to retrieve the
                /// subsequent page. When paginating, all other parameters provided to `ListGoogleAdsLinks` must match
                /// the call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/googleAdsLinks";

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
                        Pattern = @"^properties/[^/]+$",
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

            /// <summary>Updates a GoogleAdsLink on a property</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Output only. Format: properties/{propertyId}/googleAdsLinks/{googleAdsLinkId} Note: googleAdsLinkId is
            /// not the Google Ads customer ID.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaGoogleAdsLink body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>Updates a GoogleAdsLink on a property</summary>
            public class PatchRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaGoogleAdsLink>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaGoogleAdsLink body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Output only. Format: properties/{propertyId}/googleAdsLinks/{googleAdsLinkId} Note: googleAdsLinkId
                /// is not the Google Ads customer ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Required. The list of fields to be updated. Field names must be in snake case (e.g.,
                /// "field_to_update"). Omitted fields will not be updated. To replace the entire entity, use one path
                /// with the string "*" to match all fields.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaGoogleAdsLink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}";

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
                        Pattern = @"^properties/[^/]+/googleAdsLinks/[^/]+$",
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

        /// <summary>Gets the KeyEvents resource.</summary>
        public virtual KeyEventsResource KeyEvents { get; }

        /// <summary>The "keyEvents" collection of methods.</summary>
        public class KeyEventsResource
        {
            private const string Resource = "keyEvents";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public KeyEventsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a Key Event.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The resource name of the parent property where this Key Event will be created. Format:
            /// properties/123
            /// </param>
            public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaKeyEvent body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>Creates a Key Event.</summary>
            public class CreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaKeyEvent>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaKeyEvent body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the parent property where this Key Event will be created. Format:
                /// properties/123
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaKeyEvent Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/keyEvents";

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
                        Pattern = @"^properties/[^/]+$",
                    });
                }
            }

            /// <summary>Deletes a Key Event.</summary>
            /// <param name="name">
            /// Required. The resource name of the Key Event to delete. Format:
            /// properties/{property}/keyEvents/{key_event} Example: "properties/123/keyEvents/456"
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>Deletes a Key Event.</summary>
            public class DeleteRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the Key Event to delete. Format:
                /// properties/{property}/keyEvents/{key_event} Example: "properties/123/keyEvents/456"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}";

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
                        Pattern = @"^properties/[^/]+/keyEvents/[^/]+$",
                    });
                }
            }

            /// <summary>Retrieve a single Key Event.</summary>
            /// <param name="name">
            /// Required. The resource name of the Key Event to retrieve. Format:
            /// properties/{property}/keyEvents/{key_event} Example: "properties/123/keyEvents/456"
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Retrieve a single Key Event.</summary>
            public class GetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaKeyEvent>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the Key Event to retrieve. Format:
                /// properties/{property}/keyEvents/{key_event} Example: "properties/123/keyEvents/456"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}";

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
                        Pattern = @"^properties/[^/]+/keyEvents/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Returns a list of Key Events in the specified parent property. Returns an empty list if no Key Events
            /// are found.
            /// </summary>
            /// <param name="parent">
            /// Required. The resource name of the parent property. Example: 'properties/123'
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>
            /// Returns a list of Key Events in the specified parent property. Returns an empty list if no Key Events
            /// are found.
            /// </summary>
            public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaListKeyEventsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. The resource name of the parent property. Example: 'properties/123'</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of resources to return. If unspecified, at most 50 resources will be returned.
                /// The maximum value is 200; (higher values will be coerced to the maximum)
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token, received from a previous `ListKeyEvents` call. Provide this to retrieve the subsequent
                /// page. When paginating, all other parameters provided to `ListKeyEvents` must match the call that
                /// provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/keyEvents";

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
                        Pattern = @"^properties/[^/]+$",
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

            /// <summary>Updates a Key Event.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Output only. Resource name of this key event. Format: properties/{property}/keyEvents/{key_event}
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaKeyEvent body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>Updates a Key Event.</summary>
            public class PatchRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaKeyEvent>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaKeyEvent body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Output only. Resource name of this key event. Format: properties/{property}/keyEvents/{key_event}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Required. The list of fields to be updated. Field names must be in snake case (e.g.,
                /// "field_to_update"). Omitted fields will not be updated. To replace the entire entity, use one path
                /// with the string "*" to match all fields.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaKeyEvent Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}";

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
                        Pattern = @"^properties/[^/]+/keyEvents/[^/]+$",
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
        /// Acknowledges the terms of user data collection for the specified property. This acknowledgement must be
        /// completed (either in the Google Analytics UI or through this API) before MeasurementProtocolSecret resources
        /// may be created.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="property">Required. The property for which to acknowledge user data collection.</param>
        public virtual AcknowledgeUserDataCollectionRequest AcknowledgeUserDataCollection(Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaAcknowledgeUserDataCollectionRequest body, string property)
        {
            return new AcknowledgeUserDataCollectionRequest(this.service, body, property);
        }

        /// <summary>
        /// Acknowledges the terms of user data collection for the specified property. This acknowledgement must be
        /// completed (either in the Google Analytics UI or through this API) before MeasurementProtocolSecret resources
        /// may be created.
        /// </summary>
        public class AcknowledgeUserDataCollectionRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaAcknowledgeUserDataCollectionResponse>
        {
            /// <summary>Constructs a new AcknowledgeUserDataCollection request.</summary>
            public AcknowledgeUserDataCollectionRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaAcknowledgeUserDataCollectionRequest body, string property) : base(service)
            {
                Property = property;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The property for which to acknowledge user data collection.</summary>
            [Google.Apis.Util.RequestParameterAttribute("property", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Property { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaAcknowledgeUserDataCollectionRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "acknowledgeUserDataCollection";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/{+property}:acknowledgeUserDataCollection";

            /// <summary>Initializes AcknowledgeUserDataCollection parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("property", new Google.Apis.Discovery.Parameter
                {
                    Name = "property",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^properties/[^/]+$",
                });
            }
        }

        /// <summary>Creates a Google Analytics property with the specified location and attributes.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaProperty body)
        {
            return new CreateRequest(this.service, body);
        }

        /// <summary>Creates a Google Analytics property with the specified location and attributes.</summary>
        public class CreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaProperty>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaProperty body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaProperty Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/properties";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Marks target Property as soft-deleted (ie: "trashed") and returns it. This API does not have a method to
        /// restore soft-deleted properties. However, they can be restored using the Trash Can UI. If the properties are
        /// not restored before the expiration time, the Property and all child resources (eg: GoogleAdsLinks, Streams,
        /// AccessBindings) will be permanently purged. https://support.google.com/analytics/answer/6154772 Returns an
        /// error if the target is not found.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Property to soft-delete. Format: properties/{property_id} Example:
        /// "properties/1000"
        /// </param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(this.service, name);
        }

        /// <summary>
        /// Marks target Property as soft-deleted (ie: "trashed") and returns it. This API does not have a method to
        /// restore soft-deleted properties. However, they can be restored using the Trash Can UI. If the properties are
        /// not restored before the expiration time, the Property and all child resources (eg: GoogleAdsLinks, Streams,
        /// AccessBindings) will be permanently purged. https://support.google.com/analytics/answer/6154772 Returns an
        /// error if the target is not found.
        /// </summary>
        public class DeleteRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaProperty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the Property to soft-delete. Format: properties/{property_id} Example:
            /// "properties/1000"
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/{+name}";

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
                    Pattern = @"^properties/[^/]+$",
                });
            }
        }

        /// <summary>Lookup for a single GA Property.</summary>
        /// <param name="name">
        /// Required. The name of the property to lookup. Format: properties/{property_id} Example: "properties/1000"
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(this.service, name);
        }

        /// <summary>Lookup for a single GA Property.</summary>
        public class GetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaProperty>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the property to lookup. Format: properties/{property_id} Example:
            /// "properties/1000"
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/{+name}";

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
                    Pattern = @"^properties/[^/]+$",
                });
            }
        }

        /// <summary>Returns the singleton data retention settings for this property.</summary>
        /// <param name="name">
        /// Required. The name of the settings to lookup. Format: properties/{property}/dataRetentionSettings Example:
        /// "properties/1000/dataRetentionSettings"
        /// </param>
        public virtual GetDataRetentionSettingsRequest GetDataRetentionSettings(string name)
        {
            return new GetDataRetentionSettingsRequest(this.service, name);
        }

        /// <summary>Returns the singleton data retention settings for this property.</summary>
        public class GetDataRetentionSettingsRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaDataRetentionSettings>
        {
            /// <summary>Constructs a new GetDataRetentionSettings request.</summary>
            public GetDataRetentionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the settings to lookup. Format: properties/{property}/dataRetentionSettings
            /// Example: "properties/1000/dataRetentionSettings"
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getDataRetentionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/{+name}";

            /// <summary>Initializes GetDataRetentionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^properties/[^/]+/dataRetentionSettings$",
                });
            }
        }

        /// <summary>
        /// Returns child Properties under the specified parent Account. Properties will be excluded if the caller does
        /// not have access. Soft-deleted (ie: "trashed") properties are excluded by default. Returns an empty list if
        /// no relevant properties are found.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>
        /// Returns child Properties under the specified parent Account. Properties will be excluded if the caller does
        /// not have access. Soft-deleted (ie: "trashed") properties are excluded by default. Returns an empty list if
        /// no relevant properties are found.
        /// </summary>
        public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaListPropertiesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Required. An expression for filtering the results of the request. Fields eligible for filtering are:
            /// `parent:`(The resource name of the parent account/property) or `ancestor:`(The resource name of the
            /// parent account) or `firebase_project:`(The id or number of the linked firebase project). Some examples
            /// of filters:
            /// ```
            /// | Filter | Description |
            /// |-----------------------------|-------------------------------------------| | parent:accounts/123 | The
            /// account with account id: 123. | | parent:properties/123 | The property with property id: 123. | |
            /// ancestor:accounts/123 | The account with account id: 123. | | firebase_project:project-id | The firebase
            /// project with id: project-id. | | firebase_project:123 | The firebase project with number: 123. |
            /// ```
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>
            /// The maximum number of resources to return. The service may return fewer than this value, even if there
            /// are additional pages. If unspecified, at most 50 resources will be returned. The maximum value is 200;
            /// (higher values will be coerced to the maximum)
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// A page token, received from a previous `ListProperties` call. Provide this to retrieve the subsequent
            /// page. When paginating, all other parameters provided to `ListProperties` must match the call that
            /// provided the page token.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Whether to include soft-deleted (ie: "trashed") Properties in the results. Properties can be inspected
            /// to determine whether they are deleted or not.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ShowDeleted { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/properties";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
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
                RequestParameters.Add("showDeleted", new Google.Apis.Discovery.Parameter
                {
                    Name = "showDeleted",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates a property.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Output only. Resource name of this property. Format: properties/{property_id} Example: "properties/1000"
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaProperty body, string name)
        {
            return new PatchRequest(this.service, body, name);
        }

        /// <summary>Updates a property.</summary>
        public class PatchRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaProperty>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaProperty body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Output only. Resource name of this property. Format: properties/{property_id} Example: "properties/1000"
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// Required. The list of fields to be updated. Field names must be in snake case (e.g., "field_to_update").
            /// Omitted fields will not be updated. To replace the entire entity, use one path with the string "*" to
            /// match all fields.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaProperty Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/{+name}";

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
                    Pattern = @"^properties/[^/]+$",
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
        /// Returns a customized report of data access records. The report provides records of each time a user reads
        /// Google Analytics reporting data. Access records are retained for up to 2 years. Data Access Reports can be
        /// requested for a property. Reports may be requested for any property, but dimensions that aren't related to
        /// quota can only be requested on Google Analytics 360 properties. This method is only available to
        /// Administrators. These data access records include GA UI Reporting, GA UI Explorations, GA Data API, and
        /// other products like Firebase &amp;amp; Admob that can retrieve data from Google Analytics through a linkage.
        /// These records don't include property configuration changes like adding a stream or changing a property's
        /// time zone. For configuration change history, see
        /// [searchChangeHistoryEvents](https://developers.google.com/analytics/devguides/config/admin/v1/rest/v1alpha/accounts/searchChangeHistoryEvents).
        /// To give your feedback on this API, complete the [Google Analytics Access Reports
        /// feedback](https://docs.google.com/forms/d/e/1FAIpQLSdmEBUrMzAEdiEKk5TV5dEHvDUZDRlgWYdQdAeSdtR4hVjEhw/viewform)
        /// form.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="entity">
        /// The Data Access Report supports requesting at the property level or account level. If requested at the
        /// account level, Data Access Reports include all access for all properties under that account. To request at
        /// the property level, entity should be for example 'properties/123' if "123" is your Google Analytics property
        /// ID. To request at the account level, entity should be for example 'accounts/1234' if "1234" is your Google
        /// Analytics Account ID.
        /// </param>
        public virtual RunAccessReportRequest RunAccessReport(Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaRunAccessReportRequest body, string entity)
        {
            return new RunAccessReportRequest(this.service, body, entity);
        }

        /// <summary>
        /// Returns a customized report of data access records. The report provides records of each time a user reads
        /// Google Analytics reporting data. Access records are retained for up to 2 years. Data Access Reports can be
        /// requested for a property. Reports may be requested for any property, but dimensions that aren't related to
        /// quota can only be requested on Google Analytics 360 properties. This method is only available to
        /// Administrators. These data access records include GA UI Reporting, GA UI Explorations, GA Data API, and
        /// other products like Firebase &amp;amp; Admob that can retrieve data from Google Analytics through a linkage.
        /// These records don't include property configuration changes like adding a stream or changing a property's
        /// time zone. For configuration change history, see
        /// [searchChangeHistoryEvents](https://developers.google.com/analytics/devguides/config/admin/v1/rest/v1alpha/accounts/searchChangeHistoryEvents).
        /// To give your feedback on this API, complete the [Google Analytics Access Reports
        /// feedback](https://docs.google.com/forms/d/e/1FAIpQLSdmEBUrMzAEdiEKk5TV5dEHvDUZDRlgWYdQdAeSdtR4hVjEhw/viewform)
        /// form.
        /// </summary>
        public class RunAccessReportRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaRunAccessReportResponse>
        {
            /// <summary>Constructs a new RunAccessReport request.</summary>
            public RunAccessReportRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaRunAccessReportRequest body, string entity) : base(service)
            {
                Entity = entity;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The Data Access Report supports requesting at the property level or account level. If requested at the
            /// account level, Data Access Reports include all access for all properties under that account. To request
            /// at the property level, entity should be for example 'properties/123' if "123" is your Google Analytics
            /// property ID. To request at the account level, entity should be for example 'accounts/1234' if "1234" is
            /// your Google Analytics Account ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("entity", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Entity { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaRunAccessReportRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "runAccessReport";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/{+entity}:runAccessReport";

            /// <summary>Initializes RunAccessReport parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("entity", new Google.Apis.Discovery.Parameter
                {
                    Name = "entity",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^properties/[^/]+$",
                });
            }
        }

        /// <summary>Updates the singleton data retention settings for this property.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Output only. Resource name for this DataRetentionSetting resource. Format:
        /// properties/{property}/dataRetentionSettings
        /// </param>
        public virtual UpdateDataRetentionSettingsRequest UpdateDataRetentionSettings(Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaDataRetentionSettings body, string name)
        {
            return new UpdateDataRetentionSettingsRequest(this.service, body, name);
        }

        /// <summary>Updates the singleton data retention settings for this property.</summary>
        public class UpdateDataRetentionSettingsRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaDataRetentionSettings>
        {
            /// <summary>Constructs a new UpdateDataRetentionSettings request.</summary>
            public UpdateDataRetentionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaDataRetentionSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Output only. Resource name for this DataRetentionSetting resource. Format:
            /// properties/{property}/dataRetentionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// Required. The list of fields to be updated. Field names must be in snake case (e.g., "field_to_update").
            /// Omitted fields will not be updated. To replace the entire entity, use one path with the string "*" to
            /// match all fields.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.GoogleAnalyticsAdmin.v1beta.Data.GoogleAnalyticsAdminV1betaDataRetentionSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateDataRetentionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/{+name}";

            /// <summary>Initializes UpdateDataRetentionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^properties/[^/]+/dataRetentionSettings$",
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
}
namespace Google.Apis.GoogleAnalyticsAdmin.v1beta.Data
{
    /// <summary>To express that the result needs to be between two numbers (inclusive).</summary>
    public class GoogleAnalyticsAdminV1betaAccessBetweenFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Begins with this number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fromValue")]
        public virtual GoogleAnalyticsAdminV1betaNumericValue FromValue { get; set; }

        /// <summary>Ends with this number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toValue")]
        public virtual GoogleAnalyticsAdminV1betaNumericValue ToValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A contiguous range of days: startDate, startDate + 1, ..., endDate.</summary>
    public class GoogleAnalyticsAdminV1betaAccessDateRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The inclusive end date for the query in the format `YYYY-MM-DD`. Cannot be before `startDate`. The format
        /// `NdaysAgo`, `yesterday`, or `today` is also accepted, and in that case, the date is inferred based on the
        /// current time in the request's time zone.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual string EndDate { get; set; }

        /// <summary>
        /// The inclusive start date for the query in the format `YYYY-MM-DD`. Cannot be after `endDate`. The format
        /// `NdaysAgo`, `yesterday`, or `today` is also accepted, and in that case, the date is inferred based on the
        /// current time in the request's time zone.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual string StartDate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Dimensions are attributes of your data. For example, the dimension `userEmail` indicates the email of the user
    /// that accessed reporting data. Dimension values in report responses are strings.
    /// </summary>
    public class GoogleAnalyticsAdminV1betaAccessDimension : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The API name of the dimension. See [Data Access
        /// Schema](https://developers.google.com/analytics/devguides/config/admin/v1/access-api-schema) for the list of
        /// dimensions supported in this API. Dimensions are referenced by name in `dimensionFilter` and `orderBys`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionName")]
        public virtual string DimensionName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Describes a dimension column in the report. Dimensions requested in a report produce column entries within rows
    /// and DimensionHeaders. However, dimensions used exclusively within filters or expressions do not produce columns
    /// in a report; correspondingly, those dimensions do not produce headers.
    /// </summary>
    public class GoogleAnalyticsAdminV1betaAccessDimensionHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The dimension's name; for example 'userEmail'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionName")]
        public virtual string DimensionName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The value of a dimension.</summary>
    public class GoogleAnalyticsAdminV1betaAccessDimensionValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The dimension value. For example, this value may be 'France' for the 'country' dimension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An expression to filter dimension or metric values.</summary>
    public class GoogleAnalyticsAdminV1betaAccessFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A filter for two values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("betweenFilter")]
        public virtual GoogleAnalyticsAdminV1betaAccessBetweenFilter BetweenFilter { get; set; }

        /// <summary>The dimension name or metric name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldName")]
        public virtual string FieldName { get; set; }

        /// <summary>A filter for in list values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inListFilter")]
        public virtual GoogleAnalyticsAdminV1betaAccessInListFilter InListFilter { get; set; }

        /// <summary>A filter for numeric or date values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numericFilter")]
        public virtual GoogleAnalyticsAdminV1betaAccessNumericFilter NumericFilter { get; set; }

        /// <summary>Strings related filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringFilter")]
        public virtual GoogleAnalyticsAdminV1betaAccessStringFilter StringFilter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Expresses dimension or metric filters. The fields in the same expression need to be either all dimensions or all
    /// metrics.
    /// </summary>
    public class GoogleAnalyticsAdminV1betaAccessFilterExpression : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A primitive filter. In the same FilterExpression, all of the filter's field names need to be either all
        /// dimensions or all metrics.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessFilter")]
        public virtual GoogleAnalyticsAdminV1betaAccessFilter AccessFilter { get; set; }

        /// <summary>Each of the FilterExpressions in the and_group has an AND relationship.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("andGroup")]
        public virtual GoogleAnalyticsAdminV1betaAccessFilterExpressionList AndGroup { get; set; }

        /// <summary>The FilterExpression is NOT of not_expression.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notExpression")]
        public virtual GoogleAnalyticsAdminV1betaAccessFilterExpression NotExpression { get; set; }

        /// <summary>Each of the FilterExpressions in the or_group has an OR relationship.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orGroup")]
        public virtual GoogleAnalyticsAdminV1betaAccessFilterExpressionList OrGroup { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of filter expressions.</summary>
    public class GoogleAnalyticsAdminV1betaAccessFilterExpressionList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of filter expressions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expressions")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1betaAccessFilterExpression> Expressions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result needs to be in a list of string values.</summary>
    public class GoogleAnalyticsAdminV1betaAccessInListFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If true, the string value is case sensitive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caseSensitive")]
        public virtual System.Nullable<bool> CaseSensitive { get; set; }

        /// <summary>The list of string values. Must be non-empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The quantitative measurements of a report. For example, the metric `accessCount` is the total number of data
    /// access records.
    /// </summary>
    public class GoogleAnalyticsAdminV1betaAccessMetric : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The API name of the metric. See [Data Access
        /// Schema](https://developers.google.com/analytics/devguides/config/admin/v1/access-api-schema) for the list of
        /// metrics supported in this API. Metrics are referenced by name in `metricFilter` &amp;amp; `orderBys`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricName")]
        public virtual string MetricName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Describes a metric column in the report. Visible metrics requested in a report produce column entries within
    /// rows and MetricHeaders. However, metrics used exclusively within filters or expressions do not produce columns
    /// in a report; correspondingly, those metrics do not produce headers.
    /// </summary>
    public class GoogleAnalyticsAdminV1betaAccessMetricHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The metric's name; for example 'accessCount'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricName")]
        public virtual string MetricName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The value of a metric.</summary>
    public class GoogleAnalyticsAdminV1betaAccessMetricValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The measurement value. For example, this value may be '13'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Filters for numeric or date values.</summary>
    public class GoogleAnalyticsAdminV1betaAccessNumericFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The operation type for this filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual string Operation { get; set; }

        /// <summary>A numeric value or a date value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual GoogleAnalyticsAdminV1betaNumericValue Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Order bys define how rows will be sorted in the response. For example, ordering rows by descending access count
    /// is one ordering, and ordering rows by the country string is a different ordering.
    /// </summary>
    public class GoogleAnalyticsAdminV1betaAccessOrderBy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If true, sorts by descending order. If false or unspecified, sorts in ascending order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desc")]
        public virtual System.Nullable<bool> Desc { get; set; }

        /// <summary>Sorts results by a dimension's values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimension")]
        public virtual GoogleAnalyticsAdminV1betaAccessOrderByDimensionOrderBy Dimension { get; set; }

        /// <summary>Sorts results by a metric's values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metric")]
        public virtual GoogleAnalyticsAdminV1betaAccessOrderByMetricOrderBy Metric { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Sorts by dimension values.</summary>
    public class GoogleAnalyticsAdminV1betaAccessOrderByDimensionOrderBy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A dimension name in the request to order by.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionName")]
        public virtual string DimensionName { get; set; }

        /// <summary>Controls the rule for dimension value ordering.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderType")]
        public virtual string OrderType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Sorts by metric values.</summary>
    public class GoogleAnalyticsAdminV1betaAccessOrderByMetricOrderBy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A metric name in the request to order by.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricName")]
        public virtual string MetricName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Current state of all quotas for this Analytics property. If any quota for a property is exhausted, all requests
    /// to that property will return Resource Exhausted errors.
    /// </summary>
    public class GoogleAnalyticsAdminV1betaAccessQuota : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Properties can use up to 50 concurrent requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("concurrentRequests")]
        public virtual GoogleAnalyticsAdminV1betaAccessQuotaStatus ConcurrentRequests { get; set; }

        /// <summary>Properties and cloud project pairs can have up to 50 server errors per hour.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serverErrorsPerProjectPerHour")]
        public virtual GoogleAnalyticsAdminV1betaAccessQuotaStatus ServerErrorsPerProjectPerHour { get; set; }

        /// <summary>Properties can use 250,000 tokens per day. Most requests consume fewer than 10 tokens.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokensPerDay")]
        public virtual GoogleAnalyticsAdminV1betaAccessQuotaStatus TokensPerDay { get; set; }

        /// <summary>
        /// Properties can use 50,000 tokens per hour. An API request consumes a single number of tokens, and that
        /// number is deducted from all of the hourly, daily, and per project hourly quotas.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokensPerHour")]
        public virtual GoogleAnalyticsAdminV1betaAccessQuotaStatus TokensPerHour { get; set; }

        /// <summary>
        /// Properties can use up to 25% of their tokens per project per hour. This amounts to Analytics 360 Properties
        /// can use 12,500 tokens per project per hour. An API request consumes a single number of tokens, and that
        /// number is deducted from all of the hourly, daily, and per project hourly quotas.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokensPerProjectPerHour")]
        public virtual GoogleAnalyticsAdminV1betaAccessQuotaStatus TokensPerProjectPerHour { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Current state for a particular quota group.</summary>
    public class GoogleAnalyticsAdminV1betaAccessQuotaStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Quota consumed by this request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumed")]
        public virtual System.Nullable<int> Consumed { get; set; }

        /// <summary>Quota remaining after this request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remaining")]
        public virtual System.Nullable<int> Remaining { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Access report data for each row.</summary>
    public class GoogleAnalyticsAdminV1betaAccessRow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of dimension values. These values are in the same order as specified in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionValues")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1betaAccessDimensionValue> DimensionValues { get; set; }

        /// <summary>List of metric values. These values are in the same order as specified in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricValues")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1betaAccessMetricValue> MetricValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The filter for strings.</summary>
    public class GoogleAnalyticsAdminV1betaAccessStringFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If true, the string value is case sensitive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caseSensitive")]
        public virtual System.Nullable<bool> CaseSensitive { get; set; }

        /// <summary>The match type for this filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchType")]
        public virtual string MatchType { get; set; }

        /// <summary>The string value used for the matching.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource message representing a Google Analytics account.</summary>
    public class GoogleAnalyticsAdminV1betaAccount : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time when this account was originally created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual string CreateTimeRaw
        {
            get => _createTimeRaw;
            set
            {
                _createTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _createTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreateTimeDateTimeOffset instead.")]
        public virtual object CreateTime
        {
            get => _createTime;
            set
            {
                _createTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _createTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. Indicates whether this Account is soft-deleted or not. Deleted accounts are excluded from List
        /// results unless specifically requested.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleted")]
        public virtual System.Nullable<bool> Deleted { get; set; }

        /// <summary>Required. Human-readable display name for this account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. The URI for a Google Marketing Platform organization resource. Only set when this account is
        /// connected to a GMP organization. Format: marketingplatformadmin.googleapis.com/organizations/{org_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gmpOrganization")]
        public virtual string GmpOrganization { get; set; }

        /// <summary>
        /// Output only. Resource name of this account. Format: accounts/{account} Example: "accounts/100"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Country of business. Must be a Unicode CLDR region code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Time when account payload fields were last updated.</summary>
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
    /// A virtual resource representing an overview of an account and all its child Google Analytics properties.
    /// </summary>
    public class GoogleAnalyticsAdminV1betaAccountSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Resource name of account referred to by this account summary Format: accounts/{account_id} Example:
        /// "accounts/1000"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("account")]
        public virtual string Account { get; set; }

        /// <summary>Display name for the account referred to in this account summary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Resource name for this account summary. Format: accountSummaries/{account_id} Example:
        /// "accountSummaries/1000"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>List of summaries for child accounts of this account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("propertySummaries")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1betaPropertySummary> PropertySummaries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for AcknowledgeUserDataCollection RPC.</summary>
    public class GoogleAnalyticsAdminV1betaAcknowledgeUserDataCollectionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. An acknowledgement that the caller of this method understands the terms of user data collection.
        /// This field must contain the exact value: "I acknowledge that I have the necessary privacy disclosures and
        /// rights from my end users for the collection and processing of their data, including the association of such
        /// data with the visitation information Google Analytics collects from my site and/or app property."
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acknowledgement")]
        public virtual string Acknowledgement { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for AcknowledgeUserDataCollection RPC.</summary>
    public class GoogleAnalyticsAdminV1betaAcknowledgeUserDataCollectionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ArchiveCustomDimension RPC.</summary>
    public class GoogleAnalyticsAdminV1betaArchiveCustomDimensionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ArchiveCustomMetric RPC.</summary>
    public class GoogleAnalyticsAdminV1betaArchiveCustomMetricRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A description of a change to a single Google Analytics resource.</summary>
    public class GoogleAnalyticsAdminV1betaChangeHistoryChange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of action that changed this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        /// <summary>Resource name of the resource whose changes are described by this entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        /// <summary>
        /// Resource contents from after the change was made. If this resource was deleted in this change, this field
        /// will be missing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceAfterChange")]
        public virtual GoogleAnalyticsAdminV1betaChangeHistoryChangeChangeHistoryResource ResourceAfterChange { get; set; }

        /// <summary>
        /// Resource contents from before the change was made. If this resource was created in this change, this field
        /// will be missing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceBeforeChange")]
        public virtual GoogleAnalyticsAdminV1betaChangeHistoryChangeChangeHistoryResource ResourceBeforeChange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A snapshot of a resource as before or after the result of a change in change history.</summary>
    public class GoogleAnalyticsAdminV1betaChangeHistoryChangeChangeHistoryResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A snapshot of an Account resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("account")]
        public virtual GoogleAnalyticsAdminV1betaAccount Account { get; set; }

        /// <summary>A snapshot of a ConversionEvent resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionEvent")]
        public virtual GoogleAnalyticsAdminV1betaConversionEvent ConversionEvent { get; set; }

        /// <summary>A snapshot of a data retention settings resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataRetentionSettings")]
        public virtual GoogleAnalyticsAdminV1betaDataRetentionSettings DataRetentionSettings { get; set; }

        /// <summary>A snapshot of a DataStream resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataStream")]
        public virtual GoogleAnalyticsAdminV1betaDataStream DataStream { get; set; }

        /// <summary>A snapshot of a FirebaseLink resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firebaseLink")]
        public virtual GoogleAnalyticsAdminV1betaFirebaseLink FirebaseLink { get; set; }

        /// <summary>A snapshot of a GoogleAdsLink resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleAdsLink")]
        public virtual GoogleAnalyticsAdminV1betaGoogleAdsLink GoogleAdsLink { get; set; }

        /// <summary>A snapshot of a MeasurementProtocolSecret resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("measurementProtocolSecret")]
        public virtual GoogleAnalyticsAdminV1betaMeasurementProtocolSecret MeasurementProtocolSecret { get; set; }

        /// <summary>A snapshot of a Property resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual GoogleAnalyticsAdminV1betaProperty Property { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A set of changes within a Google Analytics account or its child properties that resulted from the same cause.
    /// Common causes would be updates made in the Google Analytics UI, changes from customer support, or automatic
    /// Google Analytics system changes.
    /// </summary>
    public class GoogleAnalyticsAdminV1betaChangeHistoryEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of actor that made this change.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actorType")]
        public virtual string ActorType { get; set; }

        private string _changeTimeRaw;

        private object _changeTime;

        /// <summary>Time when change was made.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("changeTime")]
        public virtual string ChangeTimeRaw
        {
            get => _changeTimeRaw;
            set
            {
                _changeTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _changeTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ChangeTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ChangeTimeDateTimeOffset instead.")]
        public virtual object ChangeTime
        {
            get => _changeTime;
            set
            {
                _changeTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _changeTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ChangeTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ChangeTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ChangeTimeRaw);
            set => ChangeTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// A list of changes made in this change history event that fit the filters specified in
        /// SearchChangeHistoryEventsRequest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("changes")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1betaChangeHistoryChange> Changes { get; set; }

        /// <summary>
        /// If true, then the list of changes returned was filtered, and does not represent all changes that occurred in
        /// this event.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("changesFiltered")]
        public virtual System.Nullable<bool> ChangesFiltered { get; set; }

        /// <summary>ID of this change history event. This ID is unique across Google Analytics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Email address of the Google account that made the change. This will be a valid email address if the actor
        /// field is set to USER, and empty otherwise. Google accounts that have been deleted will cause an error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userActorEmail")]
        public virtual string UserActorEmail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A conversion event in a Google Analytics property.</summary>
    public class GoogleAnalyticsAdminV1betaConversionEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The method by which conversions will be counted across multiple events within a session. If this
        /// value is not provided, it will be set to `ONCE_PER_EVENT`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countingMethod")]
        public virtual string CountingMethod { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time when this conversion event was created in the property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual string CreateTimeRaw
        {
            get => _createTimeRaw;
            set
            {
                _createTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _createTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreateTimeDateTimeOffset instead.")]
        public virtual object CreateTime
        {
            get => _createTime;
            set
            {
                _createTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _createTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. If set to true, this conversion event refers to a custom event. If set to false, this
        /// conversion event refers to a default event in GA. Default events typically have special meaning in GA.
        /// Default events are usually created for you by the GA system, but in some cases can be created by property
        /// admins. Custom events count towards the maximum number of custom conversion events that may be created per
        /// property.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("custom")]
        public virtual System.Nullable<bool> Custom { get; set; }

        /// <summary>Optional. Defines a default value/currency for a conversion event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultConversionValue")]
        public virtual GoogleAnalyticsAdminV1betaConversionEventDefaultConversionValue DefaultConversionValue { get; set; }

        /// <summary>Output only. If set, this event can currently be deleted with DeleteConversionEvent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletable")]
        public virtual System.Nullable<bool> Deletable { get; set; }

        /// <summary>Immutable. The event name for this conversion event. Examples: 'click', 'purchase'</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventName")]
        public virtual string EventName { get; set; }

        /// <summary>
        /// Output only. Resource name of this conversion event. Format:
        /// properties/{property}/conversionEvents/{conversion_event}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines a default value/currency for a conversion event. Both value and currency must be provided.
    /// </summary>
    public class GoogleAnalyticsAdminV1betaConversionEventDefaultConversionValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// When a conversion event for this event_name has no set currency, this currency will be applied as the
        /// default. Must be in ISO 4217 currency code format. See https://en.wikipedia.org/wiki/ISO_4217 for more
        /// information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>
        /// This value will be used to populate the value for all conversions of the specified event_name where the
        /// event "value" parameter is unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<double> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A definition for a CustomDimension.</summary>
    public class GoogleAnalyticsAdminV1betaCustomDimension : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Description for this custom dimension. Max length of 150 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. If set to true, sets this dimension as NPA and excludes it from ads personalization. This is
        /// currently only supported by user-scoped custom dimensions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disallowAdsPersonalization")]
        public virtual System.Nullable<bool> DisallowAdsPersonalization { get; set; }

        /// <summary>
        /// Required. Display name for this custom dimension as shown in the Analytics UI. Max length of 82 characters,
        /// alphanumeric plus space and underscore starting with a letter. Legacy system-generated display names may
        /// contain square brackets, but updates to this field will never permit square brackets.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. Resource name for this CustomDimension resource. Format:
        /// properties/{property}/customDimensions/{customDimension}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. Immutable. Tagging parameter name for this custom dimension. If this is a user-scoped dimension,
        /// then this is the user property name. If this is an event-scoped dimension, then this is the event parameter
        /// name. If this is an item-scoped dimension, then this is the parameter name found in the eCommerce items
        /// array. May only contain alphanumeric and underscore characters, starting with a letter. Max length of 24
        /// characters for user-scoped dimensions, 40 characters for event-scoped dimensions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameterName")]
        public virtual string ParameterName { get; set; }

        /// <summary>Required. Immutable. The scope of this dimension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A definition for a custom metric.</summary>
    public class GoogleAnalyticsAdminV1betaCustomMetric : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Description for this custom dimension. Max length of 150 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Required. Display name for this custom metric as shown in the Analytics UI. Max length of 82 characters,
        /// alphanumeric plus space and underscore starting with a letter. Legacy system-generated display names may
        /// contain square brackets, but updates to this field will never permit square brackets.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Required. The type for the custom metric's value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("measurementUnit")]
        public virtual string MeasurementUnit { get; set; }

        /// <summary>
        /// Output only. Resource name for this CustomMetric resource. Format:
        /// properties/{property}/customMetrics/{customMetric}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. Immutable. Tagging name for this custom metric. If this is an event-scoped metric, then this is
        /// the event parameter name. May only contain alphanumeric and underscore charactes, starting with a letter.
        /// Max length of 40 characters for event-scoped metrics.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameterName")]
        public virtual string ParameterName { get; set; }

        /// <summary>
        /// Optional. Types of restricted data that this metric may contain. Required for metrics with CURRENCY
        /// measurement unit. Must be empty for metrics with a non-CURRENCY measurement unit.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictedMetricType")]
        public virtual System.Collections.Generic.IList<string> RestrictedMetricType { get; set; }

        /// <summary>Required. Immutable. The scope of this custom metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings values for data retention. This is a singleton resource.</summary>
    public class GoogleAnalyticsAdminV1betaDataRetentionSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The length of time that event-level data is retained.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventDataRetention")]
        public virtual string EventDataRetention { get; set; }

        /// <summary>
        /// Output only. Resource name for this DataRetentionSetting resource. Format:
        /// properties/{property}/dataRetentionSettings
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// If true, reset the retention period for the user identifier with every event from that user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resetUserDataOnNewActivity")]
        public virtual System.Nullable<bool> ResetUserDataOnNewActivity { get; set; }

        /// <summary>Required. The length of time that user-level data is retained.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userDataRetention")]
        public virtual string UserDataRetention { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource message representing data sharing settings of a Google Analytics account.</summary>
    public class GoogleAnalyticsAdminV1betaDataSharingSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Resource name. Format: accounts/{account}/dataSharingSettings Example:
        /// "accounts/1000/dataSharingSettings"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Deprecated. This field is no longer used and always returns false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sharingWithGoogleAnySalesEnabled")]
        public virtual System.Nullable<bool> SharingWithGoogleAnySalesEnabled { get; set; }

        /// <summary>
        /// Allows Google access to your Google Analytics account data, including account usage and configuration data,
        /// product spending, and users associated with your Google Analytics account, so that Google can help you make
        /// the most of Google products, providing you with insights, offers, recommendations, and optimization tips
        /// across Google Analytics and other Google products for business. This field maps to the "Recommendations for
        /// your business" field in the Google Analytics Admin UI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sharingWithGoogleAssignedSalesEnabled")]
        public virtual System.Nullable<bool> SharingWithGoogleAssignedSalesEnabled { get; set; }

        /// <summary>
        /// Allows Google to use the data to improve other Google products or services. This fields maps to the "Google
        /// products &amp;amp; services" field in the Google Analytics Admin UI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sharingWithGoogleProductsEnabled")]
        public virtual System.Nullable<bool> SharingWithGoogleProductsEnabled { get; set; }

        /// <summary>
        /// Allows Google technical support representatives access to your Google Analytics data and account when
        /// necessary to provide service and find solutions to technical issues. This field maps to the "Technical
        /// support" field in the Google Analytics Admin UI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sharingWithGoogleSupportEnabled")]
        public virtual System.Nullable<bool> SharingWithGoogleSupportEnabled { get; set; }

        /// <summary>
        /// Enable features like predictions, modeled data, and benchmarking that can provide you with richer business
        /// insights when you contribute aggregated measurement data. The data you share (including information about
        /// the property from which it is shared) is aggregated and de-identified before being used to generate business
        /// insights. This field maps to the "Modeling contributions &amp;amp; business insights" field in the Google
        /// Analytics Admin UI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sharingWithOthersEnabled")]
        public virtual System.Nullable<bool> SharingWithOthersEnabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource message representing a data stream.</summary>
    public class GoogleAnalyticsAdminV1betaDataStream : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Data specific to Android app streams. Must be populated if type is ANDROID_APP_DATA_STREAM.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidAppStreamData")]
        public virtual GoogleAnalyticsAdminV1betaDataStreamAndroidAppStreamData AndroidAppStreamData { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time when this stream was originally created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual string CreateTimeRaw
        {
            get => _createTimeRaw;
            set
            {
                _createTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _createTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreateTimeDateTimeOffset instead.")]
        public virtual object CreateTime
        {
            get => _createTime;
            set
            {
                _createTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _createTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Human-readable display name for the Data Stream. Required for web data streams. The max allowed display name
        /// length is 255 UTF-16 code units.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Data specific to iOS app streams. Must be populated if type is IOS_APP_DATA_STREAM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosAppStreamData")]
        public virtual GoogleAnalyticsAdminV1betaDataStreamIosAppStreamData IosAppStreamData { get; set; }

        /// <summary>
        /// Output only. Resource name of this Data Stream. Format: properties/{property_id}/dataStreams/{stream_id}
        /// Example: "properties/1000/dataStreams/2000"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. Immutable. The type of this DataStream resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Time when stream payload fields were last updated.</summary>
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

        /// <summary>Data specific to web streams. Must be populated if type is WEB_DATA_STREAM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webStreamData")]
        public virtual GoogleAnalyticsAdminV1betaDataStreamWebStreamData WebStreamData { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data specific to Android app streams.</summary>
    public class GoogleAnalyticsAdminV1betaDataStreamAndroidAppStreamData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. ID of the corresponding Android app in Firebase, if any. This ID can change if the Android app
        /// is deleted and recreated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firebaseAppId")]
        public virtual string FirebaseAppId { get; set; }

        /// <summary>
        /// Immutable. The package name for the app being measured. Example: "com.example.myandroidapp"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data specific to iOS app streams.</summary>
    public class GoogleAnalyticsAdminV1betaDataStreamIosAppStreamData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Immutable. The Apple App Store Bundle ID for the app Example: "com.example.myiosapp"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bundleId")]
        public virtual string BundleId { get; set; }

        /// <summary>
        /// Output only. ID of the corresponding iOS app in Firebase, if any. This ID can change if the iOS app is
        /// deleted and recreated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firebaseAppId")]
        public virtual string FirebaseAppId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data specific to web streams.</summary>
    public class GoogleAnalyticsAdminV1betaDataStreamWebStreamData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Domain name of the web app being measured, or empty. Example: "http://www.google.com",
        /// "https://www.google.com"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultUri")]
        public virtual string DefaultUri { get; set; }

        /// <summary>
        /// Output only. ID of the corresponding web app in Firebase, if any. This ID can change if the web app is
        /// deleted and recreated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firebaseAppId")]
        public virtual string FirebaseAppId { get; set; }

        /// <summary>Output only. Analytics Measurement ID. Example: "G-1A2BCD345E"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("measurementId")]
        public virtual string MeasurementId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A link between a Google Analytics property and a Firebase project.</summary>
    public class GoogleAnalyticsAdminV1betaFirebaseLink : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time when this FirebaseLink was originally created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual string CreateTimeRaw
        {
            get => _createTimeRaw;
            set
            {
                _createTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _createTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreateTimeDateTimeOffset instead.")]
        public virtual object CreateTime
        {
            get => _createTime;
            set
            {
                _createTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _createTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. Example format: properties/1234/firebaseLinks/5678</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Immutable. Firebase project resource name. When creating a FirebaseLink, you may provide this resource name
        /// using either a project number or project ID. Once this resource has been created, returned FirebaseLinks
        /// will always have a project_name that contains a project number. Format: 'projects/{project number}' Example:
        /// 'projects/1234'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A link between a Google Analytics property and a Google Ads account.</summary>
    public class GoogleAnalyticsAdminV1betaGoogleAdsLink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Enable personalized advertising features with this integration. Automatically publish my Google Analytics
        /// audience lists and Google Analytics remarketing events/parameters to the linked Google Ads account. If this
        /// field is not set on create/update, it will be defaulted to true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adsPersonalizationEnabled")]
        public virtual System.Nullable<bool> AdsPersonalizationEnabled { get; set; }

        /// <summary>Output only. If true, this link is for a Google Ads manager account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canManageClients")]
        public virtual System.Nullable<bool> CanManageClients { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time when this link was originally created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual string CreateTimeRaw
        {
            get => _createTimeRaw;
            set
            {
                _createTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _createTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreateTimeDateTimeOffset instead.")]
        public virtual object CreateTime
        {
            get => _createTime;
            set
            {
                _createTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _createTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. Email address of the user that created the link. An empty string will be returned if the email
        /// address can't be retrieved.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creatorEmailAddress")]
        public virtual string CreatorEmailAddress { get; set; }

        /// <summary>Immutable. Google Ads customer ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerId")]
        public virtual string CustomerId { get; set; }

        /// <summary>
        /// Output only. Format: properties/{propertyId}/googleAdsLinks/{googleAdsLinkId} Note: googleAdsLinkId is not
        /// the Google Ads customer ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Time when this link was last updated.</summary>
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

    /// <summary>A key event in a Google Analytics property.</summary>
    public class GoogleAnalyticsAdminV1betaKeyEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The method by which Key Events will be counted across multiple events within a session.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countingMethod")]
        public virtual string CountingMethod { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time when this key event was created in the property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual string CreateTimeRaw
        {
            get => _createTimeRaw;
            set
            {
                _createTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _createTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreateTimeDateTimeOffset instead.")]
        public virtual object CreateTime
        {
            get => _createTime;
            set
            {
                _createTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _createTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. If set to true, this key event refers to a custom event. If set to false, this key event refers
        /// to a default event in GA. Default events typically have special meaning in GA. Default events are usually
        /// created for you by the GA system, but in some cases can be created by property admins. Custom events count
        /// towards the maximum number of custom key events that may be created per property.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("custom")]
        public virtual System.Nullable<bool> Custom { get; set; }

        /// <summary>Optional. Defines a default value/currency for a key event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultValue")]
        public virtual GoogleAnalyticsAdminV1betaKeyEventDefaultValue DefaultValue { get; set; }

        /// <summary>Output only. If set to true, this event can be deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletable")]
        public virtual System.Nullable<bool> Deletable { get; set; }

        /// <summary>Immutable. The event name for this key event. Examples: 'click', 'purchase'</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventName")]
        public virtual string EventName { get; set; }

        /// <summary>
        /// Output only. Resource name of this key event. Format: properties/{property}/keyEvents/{key_event}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines a default value/currency for a key event.</summary>
    public class GoogleAnalyticsAdminV1betaKeyEventDefaultValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. When an occurrence of this Key Event (specified by event_name) has no set currency this currency
        /// will be applied as the default. Must be in ISO 4217 currency code format. See
        /// https://en.wikipedia.org/wiki/ISO_4217 for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>
        /// Required. This will be used to populate the "value" parameter for all occurrences of this Key Event
        /// (specified by event_name) where that parameter is unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numericValue")]
        public virtual System.Nullable<double> NumericValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListAccountSummaries RPC.</summary>
    public class GoogleAnalyticsAdminV1betaListAccountSummariesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Account summaries of all accounts the caller has access to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountSummaries")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1betaAccountSummary> AccountSummaries { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ListAccounts RPC.</summary>
    public class GoogleAnalyticsAdminV1betaListAccountsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Results that were accessible to the caller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accounts")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1betaAccount> Accounts { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListConversionEvents RPC.</summary>
    public class GoogleAnalyticsAdminV1betaListConversionEventsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The requested conversion events</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionEvents")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1betaConversionEvent> ConversionEvents { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListCustomDimensions RPC.</summary>
    public class GoogleAnalyticsAdminV1betaListCustomDimensionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of CustomDimensions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customDimensions")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1betaCustomDimension> CustomDimensions { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListCustomMetrics RPC.</summary>
    public class GoogleAnalyticsAdminV1betaListCustomMetricsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of CustomMetrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customMetrics")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1betaCustomMetric> CustomMetrics { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListDataStreams RPC.</summary>
    public class GoogleAnalyticsAdminV1betaListDataStreamsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of DataStreams.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataStreams")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1betaDataStream> DataStreams { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListFirebaseLinks RPC</summary>
    public class GoogleAnalyticsAdminV1betaListFirebaseLinksResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of FirebaseLinks. This will have at most one value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firebaseLinks")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1betaFirebaseLink> FirebaseLinks { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages. Currently, Google Analytics supports only one FirebaseLink per property, so this will
        /// never be populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListGoogleAdsLinks RPC.</summary>
    public class GoogleAnalyticsAdminV1betaListGoogleAdsLinksResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of GoogleAdsLinks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleAdsLinks")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1betaGoogleAdsLink> GoogleAdsLinks { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListKeyEvents RPC.</summary>
    public class GoogleAnalyticsAdminV1betaListKeyEventsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The requested Key Events</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyEvents")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1betaKeyEvent> KeyEvents { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListMeasurementProtocolSecret RPC</summary>
    public class GoogleAnalyticsAdminV1betaListMeasurementProtocolSecretsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of secrets for the parent stream specified in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("measurementProtocolSecrets")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1betaMeasurementProtocolSecret> MeasurementProtocolSecrets { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListProperties RPC.</summary>
    public class GoogleAnalyticsAdminV1betaListPropertiesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Results that matched the filter criteria and were accessible to the caller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1betaProperty> Properties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A secret value used for sending hits to Measurement Protocol.</summary>
    public class GoogleAnalyticsAdminV1betaMeasurementProtocolSecret : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Human-readable display name for this secret.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. Resource name of this secret. This secret may be a child of any type of stream. Format:
        /// properties/{property}/dataStreams/{dataStream}/measurementProtocolSecrets/{measurementProtocolSecret}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The measurement protocol secret value. Pass this value to the api_secret field of the
        /// Measurement Protocol API when sending hits to this secret's parent property.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretValue")]
        public virtual string SecretValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>To represent a number.</summary>
    public class GoogleAnalyticsAdminV1betaNumericValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Double value</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doubleValue")]
        public virtual System.Nullable<double> DoubleValue { get; set; }

        /// <summary>Integer value</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("int64Value")]
        public virtual System.Nullable<long> Int64Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource message representing a Google Analytics property.</summary>
    public class GoogleAnalyticsAdminV1betaProperty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Immutable. The resource name of the parent account Format: accounts/{account_id} Example: "accounts/123"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("account")]
        public virtual string Account { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time when the entity was originally created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual string CreateTimeRaw
        {
            get => _createTimeRaw;
            set
            {
                _createTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _createTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreateTimeDateTimeOffset instead.")]
        public virtual object CreateTime
        {
            get => _createTime;
            set
            {
                _createTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _createTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The currency type used in reports involving monetary values. Format: https://en.wikipedia.org/wiki/ISO_4217
        /// Examples: "USD", "EUR", "JPY"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        private string _deleteTimeRaw;

        private object _deleteTime;

        /// <summary>
        /// Output only. If set, the time at which this property was trashed. If not set, then this property is not
        /// currently in the trash can.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual string DeleteTimeRaw
        {
            get => _deleteTimeRaw;
            set
            {
                _deleteTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _deleteTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DeleteTimeDateTimeOffset instead.")]
        public virtual object DeleteTime
        {
            get => _deleteTime;
            set
            {
                _deleteTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _deleteTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DeleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DeleteTimeRaw);
            set => DeleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Required. Human-readable display name for this property. The max allowed display name length is 100 UTF-16
        /// code units.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// Output only. If set, the time at which this trashed property will be permanently deleted. If not set, then
        /// this property is not currently in the trash can and is not slated to be deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual string ExpireTimeRaw
        {
            get => _expireTimeRaw;
            set
            {
                _expireTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expireTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpireTimeDateTimeOffset instead.")]
        public virtual object ExpireTime
        {
            get => _expireTime;
            set
            {
                _expireTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expireTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpireTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpireTimeRaw);
            set => ExpireTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Industry associated with this property Example: AUTOMOTIVE, FOOD_AND_DRINK</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("industryCategory")]
        public virtual string IndustryCategory { get; set; }

        /// <summary>
        /// Output only. Resource name of this property. Format: properties/{property_id} Example: "properties/1000"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Immutable. Resource name of this property's logical parent. Note: The Property-Moving UI can be used to
        /// change the parent. Format: accounts/{account}, properties/{property} Example: "accounts/100",
        /// "properties/101"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>
        /// Immutable. The property type for this Property resource. When creating a property, if the type is
        /// "PROPERTY_TYPE_UNSPECIFIED", then "ORDINARY_PROPERTY" will be implied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("propertyType")]
        public virtual string PropertyType { get; set; }

        /// <summary>Output only. The Google Analytics service level that applies to this property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceLevel")]
        public virtual string ServiceLevel { get; set; }

        /// <summary>
        /// Required. Reporting Time Zone, used as the day boundary for reports, regardless of where the data
        /// originates. If the time zone honors DST, Analytics will automatically adjust for the changes. NOTE: Changing
        /// the time zone only affects data going forward, and is not applied retroactively. Format:
        /// https://www.iana.org/time-zones Example: "America/Los_Angeles"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Time when entity payload fields were last updated.</summary>
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

    /// <summary>A virtual resource representing metadata for a Google Analytics property.</summary>
    public class GoogleAnalyticsAdminV1betaPropertySummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Display name for the property referred to in this property summary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Resource name of this property's logical parent. Note: The Property-Moving UI can be used to change the
        /// parent. Format: accounts/{account}, properties/{property} Example: "accounts/100", "properties/200"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>
        /// Resource name of property referred to by this property summary Format: properties/{property_id} Example:
        /// "properties/1000"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual string Property { get; set; }

        /// <summary>The property's property type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("propertyType")]
        public virtual string PropertyType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ProvisionAccountTicket RPC.</summary>
    public class GoogleAnalyticsAdminV1betaProvisionAccountTicketRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The account to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("account")]
        public virtual GoogleAnalyticsAdminV1betaAccount Account { get; set; }

        /// <summary>
        /// Redirect URI where the user will be sent after accepting Terms of Service. Must be configured in Cloud
        /// Console as a Redirect URI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redirectUri")]
        public virtual string RedirectUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ProvisionAccountTicket RPC.</summary>
    public class GoogleAnalyticsAdminV1betaProvisionAccountTicketResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The param to be passed in the ToS link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountTicketId")]
        public virtual string AccountTicketId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for a Data Access Record Report.</summary>
    public class GoogleAnalyticsAdminV1betaRunAccessReportRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Date ranges of access records to read. If multiple date ranges are requested, each response row will contain
        /// a zero based date range index. If two date ranges overlap, the access records for the overlapping days is
        /// included in the response rows for both date ranges. Requests are allowed up to 2 date ranges.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateRanges")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1betaAccessDateRange> DateRanges { get; set; }

        /// <summary>
        /// Dimension filters let you restrict report response to specific dimension values which match the filter. For
        /// example, filtering on access records of a single user. To learn more, see [Fundamentals of Dimension
        /// Filters](https://developers.google.com/analytics/devguides/reporting/data/v1/basics#dimension_filters) for
        /// examples. Metrics cannot be used in this filter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionFilter")]
        public virtual GoogleAnalyticsAdminV1betaAccessFilterExpression DimensionFilter { get; set; }

        /// <summary>
        /// The dimensions requested and displayed in the response. Requests are allowed up to 9 dimensions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1betaAccessDimension> Dimensions { get; set; }

        /// <summary>
        /// Optional. Decides whether to return the users within user groups. This field works only when
        /// include_all_users is set to true. If true, it will return all users with access to the specified property or
        /// account. If false, only the users with direct access will be returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expandGroups")]
        public virtual System.Nullable<bool> ExpandGroups { get; set; }

        /// <summary>
        /// Optional. Determines whether to include users who have never made an API call in the response. If true, all
        /// users with access to the specified property or account are included in the response, regardless of whether
        /// they have made an API call or not. If false, only the users who have made an API call will be included.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeAllUsers")]
        public virtual System.Nullable<bool> IncludeAllUsers { get; set; }

        /// <summary>
        /// The number of rows to return. If unspecified, 10,000 rows are returned. The API returns a maximum of 100,000
        /// rows per request, no matter how many you ask for. `limit` must be positive. The API may return fewer rows
        /// than the requested `limit`, if there aren't as many remaining rows as the `limit`. For instance, there are
        /// fewer than 300 possible values for the dimension `country`, so when reporting on only `country`, you can't
        /// get more than 300 rows, even if you set `limit` to a higher value. To learn more about this pagination
        /// parameter, see
        /// [Pagination](https://developers.google.com/analytics/devguides/reporting/data/v1/basics#pagination).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limit")]
        public virtual System.Nullable<long> Limit { get; set; }

        /// <summary>
        /// Metric filters allow you to restrict report response to specific metric values which match the filter.
        /// Metric filters are applied after aggregating the report's rows, similar to SQL having-clause. Dimensions
        /// cannot be used in this filter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricFilter")]
        public virtual GoogleAnalyticsAdminV1betaAccessFilterExpression MetricFilter { get; set; }

        /// <summary>
        /// The metrics requested and displayed in the response. Requests are allowed up to 10 metrics.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1betaAccessMetric> Metrics { get; set; }

        /// <summary>
        /// The row count of the start row. The first row is counted as row 0. If offset is unspecified, it is treated
        /// as 0. If offset is zero, then this method will return the first page of results with `limit` entries. To
        /// learn more about this pagination parameter, see
        /// [Pagination](https://developers.google.com/analytics/devguides/reporting/data/v1/basics#pagination).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offset")]
        public virtual System.Nullable<long> Offset { get; set; }

        /// <summary>Specifies how rows are ordered in the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderBys")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1betaAccessOrderBy> OrderBys { get; set; }

        /// <summary>
        /// Toggles whether to return the current state of this Analytics Property's quota. Quota is returned in
        /// [AccessQuota](#AccessQuota). For account-level requests, this field must be false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnEntityQuota")]
        public virtual System.Nullable<bool> ReturnEntityQuota { get; set; }

        /// <summary>
        /// This request's time zone if specified. If unspecified, the property's time zone is used. The request's time
        /// zone is used to interpret the start &amp;amp; end dates of the report. Formatted as strings from the IANA
        /// Time Zone database (https://www.iana.org/time-zones); for example "America/New_York" or "Asia/Tokyo".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The customized Data Access Record Report response.</summary>
    public class GoogleAnalyticsAdminV1betaRunAccessReportResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The header for a column in the report that corresponds to a specific dimension. The number of
        /// DimensionHeaders and ordering of DimensionHeaders matches the dimensions present in rows.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionHeaders")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1betaAccessDimensionHeader> DimensionHeaders { get; set; }

        /// <summary>
        /// The header for a column in the report that corresponds to a specific metric. The number of MetricHeaders and
        /// ordering of MetricHeaders matches the metrics present in rows.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricHeaders")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1betaAccessMetricHeader> MetricHeaders { get; set; }

        /// <summary>
        /// The quota state for this Analytics property including this request. This field doesn't work with
        /// account-level requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quota")]
        public virtual GoogleAnalyticsAdminV1betaAccessQuota Quota { get; set; }

        /// <summary>
        /// The total number of rows in the query result. `rowCount` is independent of the number of rows returned in
        /// the response, the `limit` request parameter, and the `offset` request parameter. For example if a query
        /// returns 175 rows and includes `limit` of 50 in the API request, the response will contain `rowCount` of 175
        /// but only 50 rows. To learn more about this pagination parameter, see
        /// [Pagination](https://developers.google.com/analytics/devguides/reporting/data/v1/basics#pagination).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowCount")]
        public virtual System.Nullable<int> RowCount { get; set; }

        /// <summary>Rows of dimension value combinations and metric values in the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1betaAccessRow> Rows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for SearchChangeHistoryEvents RPC.</summary>
    public class GoogleAnalyticsAdminV1betaSearchChangeHistoryEventsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. If set, only return changes that match one or more of these types of actions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual System.Collections.Generic.IList<string> Action { get; set; }

        /// <summary>Optional. If set, only return changes if they are made by a user in this list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actorEmail")]
        public virtual System.Collections.Generic.IList<string> ActorEmail { get; set; }

        private string _earliestChangeTimeRaw;

        private object _earliestChangeTime;

        /// <summary>Optional. If set, only return changes made after this time (inclusive).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("earliestChangeTime")]
        public virtual string EarliestChangeTimeRaw
        {
            get => _earliestChangeTimeRaw;
            set
            {
                _earliestChangeTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _earliestChangeTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EarliestChangeTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EarliestChangeTimeDateTimeOffset instead.")]
        public virtual object EarliestChangeTime
        {
            get => _earliestChangeTime;
            set
            {
                _earliestChangeTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _earliestChangeTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="EarliestChangeTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EarliestChangeTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EarliestChangeTimeRaw);
            set => EarliestChangeTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _latestChangeTimeRaw;

        private object _latestChangeTime;

        /// <summary>Optional. If set, only return changes made before this time (inclusive).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestChangeTime")]
        public virtual string LatestChangeTimeRaw
        {
            get => _latestChangeTimeRaw;
            set
            {
                _latestChangeTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _latestChangeTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LatestChangeTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LatestChangeTimeDateTimeOffset instead.")]
        public virtual object LatestChangeTime
        {
            get => _latestChangeTime;
            set
            {
                _latestChangeTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _latestChangeTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LatestChangeTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LatestChangeTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LatestChangeTimeRaw);
            set => LatestChangeTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Optional. The maximum number of ChangeHistoryEvent items to return. If unspecified, at most 50 items will be
        /// returned. The maximum value is 200 (higher values will be coerced to the maximum). Note that the service may
        /// return a page with fewer items than this value specifies (potentially even zero), and that there still may
        /// be additional pages. If you want a particular number of items, you'll need to continue requesting additional
        /// pages using `page_token` until you get the needed number.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// Optional. A page token, received from a previous `SearchChangeHistoryEvents` call. Provide this to retrieve
        /// the subsequent page. When paginating, all other parameters provided to `SearchChangeHistoryEvents` must
        /// match the call that provided the page token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>
        /// Optional. Resource name for a child property. If set, only return changes made to this property or its child
        /// resources. Format: properties/{propertyId} Example: `properties/100`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual string Property { get; set; }

        /// <summary>
        /// Optional. If set, only return changes if they are for a resource that matches at least one of these types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual System.Collections.Generic.IList<string> ResourceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for SearchAccounts RPC.</summary>
    public class GoogleAnalyticsAdminV1betaSearchChangeHistoryEventsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Results that were accessible to the caller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("changeHistoryEvents")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1betaChangeHistoryEvent> ChangeHistoryEvents { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); }
    /// </summary>
    public class GoogleProtobufEmpty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
