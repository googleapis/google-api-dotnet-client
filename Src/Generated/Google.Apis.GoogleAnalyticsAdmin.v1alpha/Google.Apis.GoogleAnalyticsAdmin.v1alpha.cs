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

namespace Google.Apis.GoogleAnalyticsAdmin.v1alpha
{
    /// <summary>The GoogleAnalyticsAdmin Service.</summary>
    public class GoogleAnalyticsAdminService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1alpha";

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
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "analyticsadmin";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://analyticsadmin.googleapis.com/";
        #else
            "https://analyticsadmin.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://analyticsadmin.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Google Analytics Admin API.</summary>
        public class Scope
        {
            /// <summary>Edit Google Analytics management entities</summary>
            public static string AnalyticsEdit = "https://www.googleapis.com/auth/analytics.edit";

            /// <summary>Manage Google Analytics Account users by email address</summary>
            public static string AnalyticsManageUsers = "https://www.googleapis.com/auth/analytics.manage.users";

            /// <summary>View Google Analytics user permissions</summary>
            public static string AnalyticsManageUsersReadonly = "https://www.googleapis.com/auth/analytics.manage.users.readonly";

            /// <summary>See and download your Google Analytics data</summary>
            public static string AnalyticsReadonly = "https://www.googleapis.com/auth/analytics.readonly";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Google Analytics Admin API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Edit Google Analytics management entities</summary>
            public const string AnalyticsEdit = "https://www.googleapis.com/auth/analytics.edit";

            /// <summary>Manage Google Analytics Account users by email address</summary>
            public const string AnalyticsManageUsers = "https://www.googleapis.com/auth/analytics.manage.users";

            /// <summary>View Google Analytics user permissions</summary>
            public const string AnalyticsManageUsersReadonly = "https://www.googleapis.com/auth/analytics.manage.users.readonly";

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
            return new ListRequest(service);
        }

        /// <summary>Returns summaries of all accounts accessible by the caller.</summary>
        public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaListAccountSummariesResponse>
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
            public override string RestPath => "v1alpha/accountSummaries";

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
            UserLinks = new UserLinksResource(service);
        }

        /// <summary>Gets the UserLinks resource.</summary>
        public virtual UserLinksResource UserLinks { get; }

        /// <summary>The "userLinks" collection of methods.</summary>
        public class UserLinksResource
        {
            private const string Resource = "userLinks";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public UserLinksResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Lists all user links on an account or property, including implicit ones that come from effective
            /// permissions granted by groups or organization admin roles. If a returned user link does not have direct
            /// permissions, they cannot be removed from the account or property directly with the DeleteUserLink
            /// command. They have to be removed from the group/etc that gives them permissions, which is currently only
            /// usable/discoverable in the GA or GMP UIs.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. Example format: accounts/1234</param>
            public virtual AuditRequest Audit(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAuditUserLinksRequest body, string parent)
            {
                return new AuditRequest(service, body, parent);
            }

            /// <summary>
            /// Lists all user links on an account or property, including implicit ones that come from effective
            /// permissions granted by groups or organization admin roles. If a returned user link does not have direct
            /// permissions, they cannot be removed from the account or property directly with the DeleteUserLink
            /// command. They have to be removed from the group/etc that gives them permissions, which is currently only
            /// usable/discoverable in the GA or GMP UIs.
            /// </summary>
            public class AuditRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAuditUserLinksResponse>
            {
                /// <summary>Constructs a new Audit request.</summary>
                public AuditRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAuditUserLinksRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Example format: accounts/1234</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAuditUserLinksRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "audit";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/userLinks:audit";

                /// <summary>Initializes Audit parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Creates information about multiple users' links to an account or property. This method is transactional.
            /// If any UserLink cannot be created, none of the UserLinks will be created.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The account or property that all user links in the request are for. This field is required.
            /// The parent field in the CreateUserLinkRequest messages must either be empty or match this field. Example
            /// format: accounts/1234
            /// </param>
            public virtual BatchCreateRequest BatchCreate(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchCreateUserLinksRequest body, string parent)
            {
                return new BatchCreateRequest(service, body, parent);
            }

            /// <summary>
            /// Creates information about multiple users' links to an account or property. This method is transactional.
            /// If any UserLink cannot be created, none of the UserLinks will be created.
            /// </summary>
            public class BatchCreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchCreateUserLinksResponse>
            {
                /// <summary>Constructs a new BatchCreate request.</summary>
                public BatchCreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchCreateUserLinksRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The account or property that all user links in the request are for. This field is
                /// required. The parent field in the CreateUserLinkRequest messages must either be empty or match this
                /// field. Example format: accounts/1234
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchCreateUserLinksRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchCreate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/userLinks:batchCreate";

                /// <summary>Initializes BatchCreate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+$",
                    });
                }
            }

            /// <summary>Deletes information about multiple users' links to an account or property.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The account or property that all user links in the request are for. The parent of all values
            /// for user link names to delete must match this field. Example format: accounts/1234
            /// </param>
            public virtual BatchDeleteRequest BatchDelete(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchDeleteUserLinksRequest body, string parent)
            {
                return new BatchDeleteRequest(service, body, parent);
            }

            /// <summary>Deletes information about multiple users' links to an account or property.</summary>
            public class BatchDeleteRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new BatchDelete request.</summary>
                public BatchDeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchDeleteUserLinksRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The account or property that all user links in the request are for. The parent of all
                /// values for user link names to delete must match this field. Example format: accounts/1234
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchDeleteUserLinksRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchDelete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/userLinks:batchDelete";

                /// <summary>Initializes BatchDelete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+$",
                    });
                }
            }

            /// <summary>Gets information about multiple users' links to an account or property.</summary>
            /// <param name="parent">
            /// Required. The account or property that all user links in the request are for. The parent of all provided
            /// values for the 'names' field must match this field. Example format: accounts/1234
            /// </param>
            public virtual BatchGetRequest BatchGet(string parent)
            {
                return new BatchGetRequest(service, parent);
            }

            /// <summary>Gets information about multiple users' links to an account or property.</summary>
            public class BatchGetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchGetUserLinksResponse>
            {
                /// <summary>Constructs a new BatchGet request.</summary>
                public BatchGetRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The account or property that all user links in the request are for. The parent of all
                /// provided values for the 'names' field must match this field. Example format: accounts/1234
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Required. The names of the user links to retrieve. A maximum of 1000 user links can be retrieved in
                /// a batch. Format: accounts/{accountId}/userLinks/{userLinkId}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("names", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> Names { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchGet";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/userLinks:batchGet";

                /// <summary>Initializes BatchGet parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+$",
                    });
                    RequestParameters.Add("names", new Google.Apis.Discovery.Parameter
                    {
                        Name = "names",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates information about multiple users' links to an account or property.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The account or property that all user links in the request are for. The parent field in the
            /// UpdateUserLinkRequest messages must either be empty or match this field. Example format: accounts/1234
            /// </param>
            public virtual BatchUpdateRequest BatchUpdate(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchUpdateUserLinksRequest body, string parent)
            {
                return new BatchUpdateRequest(service, body, parent);
            }

            /// <summary>Updates information about multiple users' links to an account or property.</summary>
            public class BatchUpdateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchUpdateUserLinksResponse>
            {
                /// <summary>Constructs a new BatchUpdate request.</summary>
                public BatchUpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchUpdateUserLinksRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The account or property that all user links in the request are for. The parent field in
                /// the UpdateUserLinkRequest messages must either be empty or match this field. Example format:
                /// accounts/1234
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchUpdateUserLinksRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchUpdate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/userLinks:batchUpdate";

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
                        Pattern = @"^accounts/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Creates a user link on an account or property. If the user with the specified email already has
            /// permissions on the account or property, then the user's existing permissions will be unioned with the
            /// permissions specified in the new UserLink.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. Example format: accounts/1234</param>
            public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaUserLink body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Creates a user link on an account or property. If the user with the specified email already has
            /// permissions on the account or property, then the user's existing permissions will be unioned with the
            /// permissions specified in the new UserLink.
            /// </summary>
            public class CreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaUserLink>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaUserLink body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Example format: accounts/1234</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. If set, then email the new user notifying them that they've been granted permissions to
                /// the resource.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("notifyNewUser", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> NotifyNewUser { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaUserLink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/userLinks";

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
                        Pattern = @"^accounts/[^/]+$",
                    });
                    RequestParameters.Add("notifyNewUser", new Google.Apis.Discovery.Parameter
                    {
                        Name = "notifyNewUser",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Deletes a user link on an account or property.</summary>
            /// <param name="name">Required. Example format: accounts/1234/userLinks/5678</param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes a user link on an account or property.</summary>
            public class DeleteRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. Example format: accounts/1234/userLinks/5678</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}";

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
                        Pattern = @"^accounts/[^/]+/userLinks/[^/]+$",
                    });
                }
            }

            /// <summary>Gets information about a user's link to an account or property.</summary>
            /// <param name="name">Required. Example format: accounts/1234/userLinks/5678</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets information about a user's link to an account or property.</summary>
            public class GetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaUserLink>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. Example format: accounts/1234/userLinks/5678</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}";

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
                        Pattern = @"^accounts/[^/]+/userLinks/[^/]+$",
                    });
                }
            }

            /// <summary>Lists all user links on an account or property.</summary>
            /// <param name="parent">Required. Example format: accounts/1234</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists all user links on an account or property.</summary>
            public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaListUserLinksResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. Example format: accounts/1234</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of user links to return. The service may return fewer than this value. If
                /// unspecified, at most 200 user links will be returned. The maximum value is 500; values above 500
                /// will be coerced to 500.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token, received from a previous `ListUserLinks` call. Provide this to retrieve the subsequent
                /// page. When paginating, all other parameters provided to `ListUserLinks` must match the call that
                /// provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/userLinks";

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
                        Pattern = @"^accounts/[^/]+$",
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

            /// <summary>Updates a user link on an account or property.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Example format: properties/1234/userLinks/5678</param>
            public virtual PatchRequest Patch(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaUserLink body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates a user link on an account or property.</summary>
            public class PatchRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaUserLink>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaUserLink body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Example format: properties/1234/userLinks/5678</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaUserLink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}";

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
                        Pattern = @"^accounts/[^/]+/userLinks/[^/]+$",
                    });
                }
            }
        }

        /// <summary>
        /// Marks target Account as soft-deleted (ie: "trashed") and returns it. This API does not have a method to
        /// restore soft-deleted accounts. However, they can be restored using the Trash Can UI. If the accounts are not
        /// restored before the expiration time, the account and all child resources (eg: Properties, GoogleAdsLinks,
        /// Streams, UserLinks) will be permanently purged. https://support.google.com/analytics/answer/6154772 Returns
        /// an error if the target is not found.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Account to soft-delete. Format: accounts/{account} Example: "accounts/100"
        /// </param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(service, name);
        }

        /// <summary>
        /// Marks target Account as soft-deleted (ie: "trashed") and returns it. This API does not have a method to
        /// restore soft-deleted accounts. However, they can be restored using the Trash Can UI. If the accounts are not
        /// restored before the expiration time, the account and all child resources (eg: Properties, GoogleAdsLinks,
        /// Streams, UserLinks) will be permanently purged. https://support.google.com/analytics/answer/6154772 Returns
        /// an error if the target is not found.
        /// </summary>
        public class DeleteRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleProtobufEmpty>
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
            public override string RestPath => "v1alpha/{+name}";

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
            return new GetRequest(service, name);
        }

        /// <summary>Lookup for a single Account.</summary>
        public class GetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAccount>
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
            public override string RestPath => "v1alpha/{+name}";

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
        /// "accounts/1000/dataSharingSettings"
        /// </param>
        public virtual GetDataSharingSettingsRequest GetDataSharingSettings(string name)
        {
            return new GetDataSharingSettingsRequest(service, name);
        }

        /// <summary>Get data sharing settings on an account. Data sharing settings are singletons.</summary>
        public class GetDataSharingSettingsRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaDataSharingSettings>
        {
            /// <summary>Constructs a new GetDataSharingSettings request.</summary>
            public GetDataSharingSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the settings to lookup. Format: accounts/{account}/dataSharingSettings Example:
            /// "accounts/1000/dataSharingSettings"
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getDataSharingSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/{+name}";

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
        /// Returns all accounts accessible by the caller. Note that these accounts might not currently have GA4
        /// properties. Soft-deleted (ie: "trashed") accounts are excluded by default. Returns an empty list if no
        /// relevant accounts are found.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>
        /// Returns all accounts accessible by the caller. Note that these accounts might not currently have GA4
        /// properties. Soft-deleted (ie: "trashed") accounts are excluded by default. Returns an empty list if no
        /// relevant accounts are found.
        /// </summary>
        public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaListAccountsResponse>
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
            public override string RestPath => "v1alpha/accounts";

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
        public virtual PatchRequest Patch(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAccount body, string name)
        {
            return new PatchRequest(service, body, name);
        }

        /// <summary>Updates an account.</summary>
        public class PatchRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAccount>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAccount body, string name) : base(service)
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
            /// Required. The list of fields to be updated. Field names must be in snake case (e.g., "field_to_update").
            /// Omitted fields will not be updated. To replace the entire entity, use one path with the string "*" to
            /// match all fields.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAccount Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/{+name}";

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
        public virtual ProvisionAccountTicketRequest ProvisionAccountTicket(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaProvisionAccountTicketRequest body)
        {
            return new ProvisionAccountTicketRequest(service, body);
        }

        /// <summary>Requests a ticket for creating an account.</summary>
        public class ProvisionAccountTicketRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaProvisionAccountTicketResponse>
        {
            /// <summary>Constructs a new ProvisionAccountTicket request.</summary>
            public ProvisionAccountTicketRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaProvisionAccountTicketRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaProvisionAccountTicketRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "provisionAccountTicket";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/accounts:provisionAccountTicket";

            /// <summary>Initializes ProvisionAccountTicket parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Searches through all changes to an account or its children given the specified set of filters.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="account">Required. The account resource for which to return change history resources.</param>
        public virtual SearchChangeHistoryEventsRequest SearchChangeHistoryEvents(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSearchChangeHistoryEventsRequest body, string account)
        {
            return new SearchChangeHistoryEventsRequest(service, body, account);
        }

        /// <summary>
        /// Searches through all changes to an account or its children given the specified set of filters.
        /// </summary>
        public class SearchChangeHistoryEventsRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSearchChangeHistoryEventsResponse>
        {
            /// <summary>Constructs a new SearchChangeHistoryEvents request.</summary>
            public SearchChangeHistoryEventsRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSearchChangeHistoryEventsRequest body, string account) : base(service)
            {
                Account = account;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The account resource for which to return change history resources.</summary>
            [Google.Apis.Util.RequestParameterAttribute("account", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Account { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSearchChangeHistoryEventsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "searchChangeHistoryEvents";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/{+account}:searchChangeHistoryEvents";

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
            AndroidAppDataStreams = new AndroidAppDataStreamsResource(service);
            FirebaseLinks = new FirebaseLinksResource(service);
            GoogleAdsLinks = new GoogleAdsLinksResource(service);
            IosAppDataStreams = new IosAppDataStreamsResource(service);
            UserLinks = new UserLinksResource(service);
            WebDataStreams = new WebDataStreamsResource(service);
        }

        /// <summary>Gets the AndroidAppDataStreams resource.</summary>
        public virtual AndroidAppDataStreamsResource AndroidAppDataStreams { get; }

        /// <summary>The "androidAppDataStreams" collection of methods.</summary>
        public class AndroidAppDataStreamsResource
        {
            private const string Resource = "androidAppDataStreams";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AndroidAppDataStreamsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates an Android app stream with the specified location and attributes. Note that an Android app
            /// stream must be linked to a Firebase app to receive traffic. To create a working app stream, make sure
            /// your property is linked to a Firebase project. Then, use the Firebase API to create a Firebase app,
            /// which will also create an appropriate data stream in Analytics (may take up to 24 hours).
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The parent resource where this android app data stream will be created. Format: properties/123
            /// </param>
            public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAndroidAppDataStream body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Creates an Android app stream with the specified location and attributes. Note that an Android app
            /// stream must be linked to a Firebase app to receive traffic. To create a working app stream, make sure
            /// your property is linked to a Firebase project. Then, use the Firebase API to create a Firebase app,
            /// which will also create an appropriate data stream in Analytics (may take up to 24 hours).
            /// </summary>
            public class CreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAndroidAppDataStream>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAndroidAppDataStream body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent resource where this android app data stream will be created. Format:
                /// properties/123
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAndroidAppDataStream Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/androidAppDataStreams";

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

            /// <summary>Deletes an android app stream on a property.</summary>
            /// <param name="name">
            /// Required. The name of the android app data stream to delete. Format:
            /// properties/{property_id}/androidAppDataStreams/{stream_id} Example:
            /// "properties/123/androidAppDataStreams/456"
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes an android app stream on a property.</summary>
            public class DeleteRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the android app data stream to delete. Format:
                /// properties/{property_id}/androidAppDataStreams/{stream_id} Example:
                /// "properties/123/androidAppDataStreams/456"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}";

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
                        Pattern = @"^properties/[^/]+/androidAppDataStreams/[^/]+$",
                    });
                }
            }

            /// <summary>Lookup for a single AndroidAppDataStream</summary>
            /// <param name="name">
            /// Required. The name of the android app data stream to lookup. Format:
            /// properties/{property_id}/androidAppDataStreams/{stream_id} Example:
            /// "properties/123/androidAppDataStreams/456"
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Lookup for a single AndroidAppDataStream</summary>
            public class GetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAndroidAppDataStream>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the android app data stream to lookup. Format:
                /// properties/{property_id}/androidAppDataStreams/{stream_id} Example:
                /// "properties/123/androidAppDataStreams/456"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}";

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
                        Pattern = @"^properties/[^/]+/androidAppDataStreams/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Returns child android app streams under the specified parent property. Android app streams will be
            /// excluded if the caller does not have access. Returns an empty list if no relevant android app streams
            /// are found.
            /// </summary>
            /// <param name="parent">
            /// Required. The name of the parent property. For example, to limit results to app streams under the
            /// property with Id 123: "properties/123"
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Returns child android app streams under the specified parent property. Android app streams will be
            /// excluded if the caller does not have access. Returns an empty list if no relevant android app streams
            /// are found.
            /// </summary>
            public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaListAndroidAppDataStreamsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the parent property. For example, to limit results to app streams under the
                /// property with Id 123: "properties/123"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of resources to return. If unspecified, at most 50 resources will be returned.
                /// The maximum value is 200; (higher values will be coerced to the maximum)
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token, received from a previous call. Provide this to retrieve the subsequent page. When
                /// paginating, all other parameters provided to `ListAndroidAppDataStreams` must match the call that
                /// provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/androidAppDataStreams";

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

            /// <summary>Updates an android app stream on a property.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Output only. Resource name of this Data Stream. Format:
            /// properties/{property_id}/androidAppDataStreams/{stream_id} Example:
            /// "properties/1000/androidAppDataStreams/2000"
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAndroidAppDataStream body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates an android app stream on a property.</summary>
            public class PatchRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAndroidAppDataStream>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAndroidAppDataStream body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Output only. Resource name of this Data Stream. Format:
                /// properties/{property_id}/androidAppDataStreams/{stream_id} Example:
                /// "properties/1000/androidAppDataStreams/2000"
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
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAndroidAppDataStream Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}";

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
                        Pattern = @"^properties/[^/]+/androidAppDataStreams/[^/]+$",
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
            /// <param name="parent">Required. Format: properties/{property_id} Example: properties/1234</param>
            public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaFirebaseLink body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a FirebaseLink. Properties can have at most one FirebaseLink.</summary>
            public class CreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaFirebaseLink>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaFirebaseLink body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Format: properties/{property_id} Example: properties/1234</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaFirebaseLink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/firebaseLinks";

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
            /// properties/1234/firebaseLinks/5678
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes a FirebaseLink on a property</summary>
            public class DeleteRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Format: properties/{property_id}/firebaseLinks/{firebase_link_id} Example:
                /// properties/1234/firebaseLinks/5678
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}";

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
            /// <param name="parent">Required. Format: properties/{property_id} Example: properties/1234</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists FirebaseLinks on a property. Properties can have at most one FirebaseLink.</summary>
            public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaListFirebaseLinksResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. Format: properties/{property_id} Example: properties/1234</summary>
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
                /// subsequent page. When paginating, all other parameters provided to `ListProperties` must match the
                /// call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/firebaseLinks";

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

            /// <summary>Updates a FirebaseLink on a property</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Output only. Example format: properties/1234/firebaseLinks/5678</param>
            public virtual PatchRequest Patch(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaFirebaseLink body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates a FirebaseLink on a property</summary>
            public class PatchRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaFirebaseLink>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaFirebaseLink body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Output only. Example format: properties/1234/firebaseLinks/5678</summary>
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
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaFirebaseLink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}";

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
                        Pattern = @"^properties/[^/]+/firebaseLinks/[^/]+$",
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
            public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaGoogleAdsLink body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a GoogleAdsLink.</summary>
            public class CreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaGoogleAdsLink>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaGoogleAdsLink body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Example format: properties/1234</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaGoogleAdsLink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/googleAdsLinks";

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
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes a GoogleAdsLink on a property</summary>
            public class DeleteRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleProtobufEmpty>
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
                public override string RestPath => "v1alpha/{+name}";

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
                return new ListRequest(service, parent);
            }

            /// <summary>Lists GoogleAdsLinks on a property.</summary>
            public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaListGoogleAdsLinksResponse>
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
                public override string RestPath => "v1alpha/{+parent}/googleAdsLinks";

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
            public virtual PatchRequest Patch(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaGoogleAdsLink body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates a GoogleAdsLink on a property</summary>
            public class PatchRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaGoogleAdsLink>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaGoogleAdsLink body, string name) : base(service)
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
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaGoogleAdsLink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}";

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

        /// <summary>Gets the IosAppDataStreams resource.</summary>
        public virtual IosAppDataStreamsResource IosAppDataStreams { get; }

        /// <summary>The "iosAppDataStreams" collection of methods.</summary>
        public class IosAppDataStreamsResource
        {
            private const string Resource = "iosAppDataStreams";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public IosAppDataStreamsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates an iOS app stream with the specified location and attributes. Note that an iOS app stream must
            /// be linked to a Firebase app to receive traffic. To create a working app stream, make sure your property
            /// is linked to a Firebase project. Then, use the Firebase API to create a Firebase app, which will also
            /// create an appropriate data stream in Analytics (may take up to 24 hours).
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The parent resource where this ios app data stream will be created. Format: properties/123
            /// </param>
            public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaIosAppDataStream body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Creates an iOS app stream with the specified location and attributes. Note that an iOS app stream must
            /// be linked to a Firebase app to receive traffic. To create a working app stream, make sure your property
            /// is linked to a Firebase project. Then, use the Firebase API to create a Firebase app, which will also
            /// create an appropriate data stream in Analytics (may take up to 24 hours).
            /// </summary>
            public class CreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaIosAppDataStream>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaIosAppDataStream body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent resource where this ios app data stream will be created. Format: properties/123
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaIosAppDataStream Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/iosAppDataStreams";

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

            /// <summary>Deletes an iOS app stream on a property.</summary>
            /// <param name="name">
            /// Required. The name of the iOS app data stream to delete. Format:
            /// properties/{property_id}/iosAppDataStreams/{stream_id} Example: "properties/123/iosAppDataStreams/456"
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes an iOS app stream on a property.</summary>
            public class DeleteRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the iOS app data stream to delete. Format:
                /// properties/{property_id}/iosAppDataStreams/{stream_id} Example:
                /// "properties/123/iosAppDataStreams/456"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}";

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
                        Pattern = @"^properties/[^/]+/iosAppDataStreams/[^/]+$",
                    });
                }
            }

            /// <summary>Lookup for a single IosAppDataStream</summary>
            /// <param name="name">
            /// Required. The name of the iOS app data stream to lookup. Format:
            /// properties/{property_id}/iosAppDataStreams/{stream_id} Example: "properties/123/iosAppDataStreams/456"
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Lookup for a single IosAppDataStream</summary>
            public class GetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaIosAppDataStream>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the iOS app data stream to lookup. Format:
                /// properties/{property_id}/iosAppDataStreams/{stream_id} Example:
                /// "properties/123/iosAppDataStreams/456"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}";

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
                        Pattern = @"^properties/[^/]+/iosAppDataStreams/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Returns child iOS app data streams under the specified parent property. iOS app data streams will be
            /// excluded if the caller does not have access. Returns an empty list if no relevant iOS app data streams
            /// are found.
            /// </summary>
            /// <param name="parent">
            /// Required. The name of the parent property. For example, to list results of app streams under the
            /// property with Id 123: "properties/123"
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Returns child iOS app data streams under the specified parent property. iOS app data streams will be
            /// excluded if the caller does not have access. Returns an empty list if no relevant iOS app data streams
            /// are found.
            /// </summary>
            public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaListIosAppDataStreamsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the parent property. For example, to list results of app streams under the
                /// property with Id 123: "properties/123"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of resources to return. If unspecified, at most 50 resources will be returned.
                /// The maximum value is 200; (higher values will be coerced to the maximum)
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token, received from a previous `ListIosAppDataStreams` call. Provide this to retrieve the
                /// subsequent page. When paginating, all other parameters provided to `ListIosAppDataStreams` must
                /// match the call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/iosAppDataStreams";

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

            /// <summary>Updates an iOS app stream on a property.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Output only. Resource name of this Data Stream. Format:
            /// properties/{property_id}/iosAppDataStreams/{stream_id} Example: "properties/1000/iosAppDataStreams/2000"
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaIosAppDataStream body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates an iOS app stream on a property.</summary>
            public class PatchRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaIosAppDataStream>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaIosAppDataStream body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Output only. Resource name of this Data Stream. Format:
                /// properties/{property_id}/iosAppDataStreams/{stream_id} Example:
                /// "properties/1000/iosAppDataStreams/2000"
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
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaIosAppDataStream Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}";

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
                        Pattern = @"^properties/[^/]+/iosAppDataStreams/[^/]+$",
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

        /// <summary>Gets the UserLinks resource.</summary>
        public virtual UserLinksResource UserLinks { get; }

        /// <summary>The "userLinks" collection of methods.</summary>
        public class UserLinksResource
        {
            private const string Resource = "userLinks";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public UserLinksResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Lists all user links on an account or property, including implicit ones that come from effective
            /// permissions granted by groups or organization admin roles. If a returned user link does not have direct
            /// permissions, they cannot be removed from the account or property directly with the DeleteUserLink
            /// command. They have to be removed from the group/etc that gives them permissions, which is currently only
            /// usable/discoverable in the GA or GMP UIs.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. Example format: accounts/1234</param>
            public virtual AuditRequest Audit(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAuditUserLinksRequest body, string parent)
            {
                return new AuditRequest(service, body, parent);
            }

            /// <summary>
            /// Lists all user links on an account or property, including implicit ones that come from effective
            /// permissions granted by groups or organization admin roles. If a returned user link does not have direct
            /// permissions, they cannot be removed from the account or property directly with the DeleteUserLink
            /// command. They have to be removed from the group/etc that gives them permissions, which is currently only
            /// usable/discoverable in the GA or GMP UIs.
            /// </summary>
            public class AuditRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAuditUserLinksResponse>
            {
                /// <summary>Constructs a new Audit request.</summary>
                public AuditRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAuditUserLinksRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Example format: accounts/1234</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAuditUserLinksRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "audit";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/userLinks:audit";

                /// <summary>Initializes Audit parameter list.</summary>
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

            /// <summary>
            /// Creates information about multiple users' links to an account or property. This method is transactional.
            /// If any UserLink cannot be created, none of the UserLinks will be created.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The account or property that all user links in the request are for. This field is required.
            /// The parent field in the CreateUserLinkRequest messages must either be empty or match this field. Example
            /// format: accounts/1234
            /// </param>
            public virtual BatchCreateRequest BatchCreate(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchCreateUserLinksRequest body, string parent)
            {
                return new BatchCreateRequest(service, body, parent);
            }

            /// <summary>
            /// Creates information about multiple users' links to an account or property. This method is transactional.
            /// If any UserLink cannot be created, none of the UserLinks will be created.
            /// </summary>
            public class BatchCreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchCreateUserLinksResponse>
            {
                /// <summary>Constructs a new BatchCreate request.</summary>
                public BatchCreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchCreateUserLinksRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The account or property that all user links in the request are for. This field is
                /// required. The parent field in the CreateUserLinkRequest messages must either be empty or match this
                /// field. Example format: accounts/1234
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchCreateUserLinksRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchCreate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/userLinks:batchCreate";

                /// <summary>Initializes BatchCreate parameter list.</summary>
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

            /// <summary>Deletes information about multiple users' links to an account or property.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The account or property that all user links in the request are for. The parent of all values
            /// for user link names to delete must match this field. Example format: accounts/1234
            /// </param>
            public virtual BatchDeleteRequest BatchDelete(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchDeleteUserLinksRequest body, string parent)
            {
                return new BatchDeleteRequest(service, body, parent);
            }

            /// <summary>Deletes information about multiple users' links to an account or property.</summary>
            public class BatchDeleteRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new BatchDelete request.</summary>
                public BatchDeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchDeleteUserLinksRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The account or property that all user links in the request are for. The parent of all
                /// values for user link names to delete must match this field. Example format: accounts/1234
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchDeleteUserLinksRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchDelete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/userLinks:batchDelete";

                /// <summary>Initializes BatchDelete parameter list.</summary>
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

            /// <summary>Gets information about multiple users' links to an account or property.</summary>
            /// <param name="parent">
            /// Required. The account or property that all user links in the request are for. The parent of all provided
            /// values for the 'names' field must match this field. Example format: accounts/1234
            /// </param>
            public virtual BatchGetRequest BatchGet(string parent)
            {
                return new BatchGetRequest(service, parent);
            }

            /// <summary>Gets information about multiple users' links to an account or property.</summary>
            public class BatchGetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchGetUserLinksResponse>
            {
                /// <summary>Constructs a new BatchGet request.</summary>
                public BatchGetRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The account or property that all user links in the request are for. The parent of all
                /// provided values for the 'names' field must match this field. Example format: accounts/1234
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Required. The names of the user links to retrieve. A maximum of 1000 user links can be retrieved in
                /// a batch. Format: accounts/{accountId}/userLinks/{userLinkId}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("names", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> Names { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchGet";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/userLinks:batchGet";

                /// <summary>Initializes BatchGet parameter list.</summary>
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
                    RequestParameters.Add("names", new Google.Apis.Discovery.Parameter
                    {
                        Name = "names",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates information about multiple users' links to an account or property.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The account or property that all user links in the request are for. The parent field in the
            /// UpdateUserLinkRequest messages must either be empty or match this field. Example format: accounts/1234
            /// </param>
            public virtual BatchUpdateRequest BatchUpdate(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchUpdateUserLinksRequest body, string parent)
            {
                return new BatchUpdateRequest(service, body, parent);
            }

            /// <summary>Updates information about multiple users' links to an account or property.</summary>
            public class BatchUpdateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchUpdateUserLinksResponse>
            {
                /// <summary>Constructs a new BatchUpdate request.</summary>
                public BatchUpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchUpdateUserLinksRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The account or property that all user links in the request are for. The parent field in
                /// the UpdateUserLinkRequest messages must either be empty or match this field. Example format:
                /// accounts/1234
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchUpdateUserLinksRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchUpdate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/userLinks:batchUpdate";

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
                        Pattern = @"^properties/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Creates a user link on an account or property. If the user with the specified email already has
            /// permissions on the account or property, then the user's existing permissions will be unioned with the
            /// permissions specified in the new UserLink.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. Example format: accounts/1234</param>
            public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaUserLink body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Creates a user link on an account or property. If the user with the specified email already has
            /// permissions on the account or property, then the user's existing permissions will be unioned with the
            /// permissions specified in the new UserLink.
            /// </summary>
            public class CreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaUserLink>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaUserLink body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Example format: accounts/1234</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. If set, then email the new user notifying them that they've been granted permissions to
                /// the resource.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("notifyNewUser", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> NotifyNewUser { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaUserLink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/userLinks";

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
                    RequestParameters.Add("notifyNewUser", new Google.Apis.Discovery.Parameter
                    {
                        Name = "notifyNewUser",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Deletes a user link on an account or property.</summary>
            /// <param name="name">Required. Example format: accounts/1234/userLinks/5678</param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes a user link on an account or property.</summary>
            public class DeleteRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. Example format: accounts/1234/userLinks/5678</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}";

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
                        Pattern = @"^properties/[^/]+/userLinks/[^/]+$",
                    });
                }
            }

            /// <summary>Gets information about a user's link to an account or property.</summary>
            /// <param name="name">Required. Example format: accounts/1234/userLinks/5678</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets information about a user's link to an account or property.</summary>
            public class GetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaUserLink>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. Example format: accounts/1234/userLinks/5678</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}";

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
                        Pattern = @"^properties/[^/]+/userLinks/[^/]+$",
                    });
                }
            }

            /// <summary>Lists all user links on an account or property.</summary>
            /// <param name="parent">Required. Example format: accounts/1234</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists all user links on an account or property.</summary>
            public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaListUserLinksResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. Example format: accounts/1234</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of user links to return. The service may return fewer than this value. If
                /// unspecified, at most 200 user links will be returned. The maximum value is 500; values above 500
                /// will be coerced to 500.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token, received from a previous `ListUserLinks` call. Provide this to retrieve the subsequent
                /// page. When paginating, all other parameters provided to `ListUserLinks` must match the call that
                /// provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/userLinks";

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

            /// <summary>Updates a user link on an account or property.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Example format: properties/1234/userLinks/5678</param>
            public virtual PatchRequest Patch(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaUserLink body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates a user link on an account or property.</summary>
            public class PatchRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaUserLink>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaUserLink body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Example format: properties/1234/userLinks/5678</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaUserLink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}";

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
                        Pattern = @"^properties/[^/]+/userLinks/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the WebDataStreams resource.</summary>
        public virtual WebDataStreamsResource WebDataStreams { get; }

        /// <summary>The "webDataStreams" collection of methods.</summary>
        public class WebDataStreamsResource
        {
            private const string Resource = "webDataStreams";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public WebDataStreamsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a web stream with the specified location and attributes.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The parent resource where this web data stream will be created. Format: properties/123
            /// </param>
            public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaWebDataStream body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a web stream with the specified location and attributes.</summary>
            public class CreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaWebDataStream>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaWebDataStream body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent resource where this web data stream will be created. Format: properties/123
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaWebDataStream Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/webDataStreams";

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

            /// <summary>Deletes a web stream on a property.</summary>
            /// <param name="name">
            /// Required. The name of the web data stream to delete. Format:
            /// properties/{property_id}/webDataStreams/{stream_id} Example: "properties/123/webDataStreams/456"
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes a web stream on a property.</summary>
            public class DeleteRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the web data stream to delete. Format:
                /// properties/{property_id}/webDataStreams/{stream_id} Example: "properties/123/webDataStreams/456"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}";

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
                        Pattern = @"^properties/[^/]+/webDataStreams/[^/]+$",
                    });
                }
            }

            /// <summary>Lookup for a single WebDataStream</summary>
            /// <param name="name">
            /// Required. The name of the web data stream to lookup. Format:
            /// properties/{property_id}/webDataStreams/{stream_id} Example: "properties/123/webDataStreams/456"
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Lookup for a single WebDataStream</summary>
            public class GetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaWebDataStream>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the web data stream to lookup. Format:
                /// properties/{property_id}/webDataStreams/{stream_id} Example: "properties/123/webDataStreams/456"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}";

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
                        Pattern = @"^properties/[^/]+/webDataStreams/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Returns the singleton enhanced measurement settings for this web stream. Note that the stream must
            /// enable enhanced measurement for these settings to take effect.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the settings to lookup. Format:
            /// properties/{property_id}/webDataStreams/{stream_id}/enhancedMeasurementSettings Example:
            /// "properties/1000/webDataStreams/2000/enhancedMeasurementSettings"
            /// </param>
            public virtual GetEnhancedMeasurementSettingsRequest GetEnhancedMeasurementSettings(string name)
            {
                return new GetEnhancedMeasurementSettingsRequest(service, name);
            }

            /// <summary>
            /// Returns the singleton enhanced measurement settings for this web stream. Note that the stream must
            /// enable enhanced measurement for these settings to take effect.
            /// </summary>
            public class GetEnhancedMeasurementSettingsRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaEnhancedMeasurementSettings>
            {
                /// <summary>Constructs a new GetEnhancedMeasurementSettings request.</summary>
                public GetEnhancedMeasurementSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the settings to lookup. Format:
                /// properties/{property_id}/webDataStreams/{stream_id}/enhancedMeasurementSettings Example:
                /// "properties/1000/webDataStreams/2000/enhancedMeasurementSettings"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getEnhancedMeasurementSettings";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}";

                /// <summary>Initializes GetEnhancedMeasurementSettings parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^properties/[^/]+/webDataStreams/[^/]+/enhancedMeasurementSettings$",
                    });
                }
            }

            /// <summary>
            /// Returns the Site Tag for the specified web stream. Site Tags are immutable singletons.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the site tag to lookup. Note that site tags are singletons and do not have unique
            /// IDs. Format: properties/{property_id}/webDataStreams/{stream_id}/globalSiteTag Example:
            /// "properties/123/webDataStreams/456/globalSiteTag"
            /// </param>
            public virtual GetGlobalSiteTagRequest GetGlobalSiteTag(string name)
            {
                return new GetGlobalSiteTagRequest(service, name);
            }

            /// <summary>
            /// Returns the Site Tag for the specified web stream. Site Tags are immutable singletons.
            /// </summary>
            public class GetGlobalSiteTagRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaGlobalSiteTag>
            {
                /// <summary>Constructs a new GetGlobalSiteTag request.</summary>
                public GetGlobalSiteTagRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the site tag to lookup. Note that site tags are singletons and do not have
                /// unique IDs. Format: properties/{property_id}/webDataStreams/{stream_id}/globalSiteTag Example:
                /// "properties/123/webDataStreams/456/globalSiteTag"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getGlobalSiteTag";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}";

                /// <summary>Initializes GetGlobalSiteTag parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^properties/[^/]+/webDataStreams/[^/]+/globalSiteTag$",
                    });
                }
            }

            /// <summary>
            /// Returns child web data streams under the specified parent property. Web data streams will be excluded if
            /// the caller does not have access. Returns an empty list if no relevant web data streams are found.
            /// </summary>
            /// <param name="parent">
            /// Required. The name of the parent property. For example, to list results of web streams under the
            /// property with Id 123: "properties/123"
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Returns child web data streams under the specified parent property. Web data streams will be excluded if
            /// the caller does not have access. Returns an empty list if no relevant web data streams are found.
            /// </summary>
            public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaListWebDataStreamsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the parent property. For example, to list results of web streams under the
                /// property with Id 123: "properties/123"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of resources to return. If unspecified, at most 50 resources will be returned.
                /// The maximum value is 200; (higher values will be coerced to the maximum)
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token, received from a previous `ListWebDataStreams` call. Provide this to retrieve the
                /// subsequent page. When paginating, all other parameters provided to `ListWebDataStreams` must match
                /// the call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/webDataStreams";

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

            /// <summary>Updates a web stream on a property.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Output only. Resource name of this Data Stream. Format:
            /// properties/{property_id}/webDataStreams/{stream_id} Example: "properties/1000/webDataStreams/2000"
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaWebDataStream body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates a web stream on a property.</summary>
            public class PatchRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaWebDataStream>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaWebDataStream body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Output only. Resource name of this Data Stream. Format:
                /// properties/{property_id}/webDataStreams/{stream_id} Example: "properties/1000/webDataStreams/2000"
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
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaWebDataStream Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}";

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
                        Pattern = @"^properties/[^/]+/webDataStreams/[^/]+$",
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
            /// Updates the singleton enhanced measurement settings for this web stream. Note that the stream must
            /// enable enhanced measurement for these settings to take effect.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Output only. Resource name of this Data Stream. Format:
            /// properties/{property_id}/webDataStreams/{stream_id}/enhancedMeasurementSettings Example:
            /// "properties/1000/webDataStreams/2000/enhancedMeasurementSettings"
            /// </param>
            public virtual UpdateEnhancedMeasurementSettingsRequest UpdateEnhancedMeasurementSettings(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaEnhancedMeasurementSettings body, string name)
            {
                return new UpdateEnhancedMeasurementSettingsRequest(service, body, name);
            }

            /// <summary>
            /// Updates the singleton enhanced measurement settings for this web stream. Note that the stream must
            /// enable enhanced measurement for these settings to take effect.
            /// </summary>
            public class UpdateEnhancedMeasurementSettingsRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaEnhancedMeasurementSettings>
            {
                /// <summary>Constructs a new UpdateEnhancedMeasurementSettings request.</summary>
                public UpdateEnhancedMeasurementSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaEnhancedMeasurementSettings body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Output only. Resource name of this Data Stream. Format:
                /// properties/{property_id}/webDataStreams/{stream_id}/enhancedMeasurementSettings Example:
                /// "properties/1000/webDataStreams/2000/enhancedMeasurementSettings"
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
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaEnhancedMeasurementSettings Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "updateEnhancedMeasurementSettings";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}";

                /// <summary>Initializes UpdateEnhancedMeasurementSettings parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^properties/[^/]+/webDataStreams/[^/]+/enhancedMeasurementSettings$",
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

        /// <summary>Creates an "GA4" property with the specified location and attributes.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaProperty body)
        {
            return new CreateRequest(service, body);
        }

        /// <summary>Creates an "GA4" property with the specified location and attributes.</summary>
        public class CreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaProperty>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaProperty body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaProperty Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/properties";

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
        /// UserLinks) will be permanently purged. https://support.google.com/analytics/answer/6154772 Returns an error
        /// if the target is not found, or is not an GA4 Property.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Property to soft-delete. Format: properties/{property_id} Example:
        /// "properties/1000"
        /// </param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(service, name);
        }

        /// <summary>
        /// Marks target Property as soft-deleted (ie: "trashed") and returns it. This API does not have a method to
        /// restore soft-deleted properties. However, they can be restored using the Trash Can UI. If the properties are
        /// not restored before the expiration time, the Property and all child resources (eg: GoogleAdsLinks, Streams,
        /// UserLinks) will be permanently purged. https://support.google.com/analytics/answer/6154772 Returns an error
        /// if the target is not found, or is not an GA4 Property.
        /// </summary>
        public class DeleteRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaProperty>
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
            public override string RestPath => "v1alpha/{+name}";

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

        /// <summary>Lookup for a single "GA4" Property.</summary>
        /// <param name="name">
        /// Required. The name of the property to lookup. Format: properties/{property_id} Example: "properties/1000"
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>Lookup for a single "GA4" Property.</summary>
        public class GetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaProperty>
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
            public override string RestPath => "v1alpha/{+name}";

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

        /// <summary>
        /// Returns child Properties under the specified parent Account. Only "GA4" properties will be returned.
        /// Properties will be excluded if the caller does not have access. Soft-deleted (ie: "trashed") properties are
        /// excluded by default. Returns an empty list if no relevant properties are found.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>
        /// Returns child Properties under the specified parent Account. Only "GA4" properties will be returned.
        /// Properties will be excluded if the caller does not have access. Soft-deleted (ie: "trashed") properties are
        /// excluded by default. Returns an empty list if no relevant properties are found.
        /// </summary>
        public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaListPropertiesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Required. An expression for filtering the results of the request. Fields eligible for filtering are:
            /// `parent:`(The resource name of the parent account) or `firebase_project:`(The id or number of the linked
            /// firebase project). Some examples of filters: ``` | Filter | Description |
            /// |-----------------------------|-------------------------------------------| | parent:accounts/123 | The
            /// account with account id: 123. | | firebase_project:project-id | The firebase project with id:
            /// project-id. | | firebase_project:123 | The firebase project with number: 123. | ```
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
            public override string RestPath => "v1alpha/properties";

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
        public virtual PatchRequest Patch(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaProperty body, string name)
        {
            return new PatchRequest(service, body, name);
        }

        /// <summary>Updates a property.</summary>
        public class PatchRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaProperty>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaProperty body, string name) : base(service)
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
            Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaProperty Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/{+name}";

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
    }
}
namespace Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data
{
    /// <summary>A resource message representing a Google Analytics account.</summary>
    public class GoogleAnalyticsAdminV1alphaAccount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Time when this account was originally created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

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
        /// Output only. Resource name of this account. Format: accounts/{account} Example: "accounts/100"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Country of business. Must be a Unicode CLDR region code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>Output only. Time when account payload fields were last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A virtual resource representing an overview of an account and all its child GA4 properties.</summary>
    public class GoogleAnalyticsAdminV1alphaAccountSummary : Google.Apis.Requests.IDirectResponseSchema
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
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaPropertySummary> PropertySummaries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource message representing a Google Analytics Android app stream.</summary>
    public class GoogleAnalyticsAdminV1alphaAndroidAppDataStream : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Time when this stream was originally created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Human-readable display name for the Data Stream. The max allowed display name length is 255 UTF-16 code
        /// units.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. ID of the corresponding Android app in Firebase, if any. This ID can change if the Android app
        /// is deleted and recreated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firebaseAppId")]
        public virtual string FirebaseAppId { get; set; }

        /// <summary>
        /// Output only. Resource name of this Data Stream. Format:
        /// properties/{property_id}/androidAppDataStreams/{stream_id} Example:
        /// "properties/1000/androidAppDataStreams/2000"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Immutable. The package name for the app being measured. Example: "com.example.myandroidapp"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>Output only. Time when stream payload fields were last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Read-only resource used to summarize a principal's effective roles.</summary>
    public class GoogleAnalyticsAdminV1alphaAuditUserLink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Roles directly assigned to this user for this entity. Format: predefinedRoles/read Excludes roles that are
        /// inherited from an account (if this is for a property), group, or organization admin role.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("directRoles")]
        public virtual System.Collections.Generic.IList<string> DirectRoles { get; set; }

        /// <summary>
        /// Union of all permissions a user has at this account or property (includes direct permissions,
        /// group-inherited permissions, etc.). Format: predefinedRoles/read
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectiveRoles")]
        public virtual System.Collections.Generic.IList<string> EffectiveRoles { get; set; }

        /// <summary>Email address of the linked user</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailAddress")]
        public virtual string EmailAddress { get; set; }

        /// <summary>Example format: properties/1234/userLinks/5678</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for AuditUserLinks RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaAuditUserLinksRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The maximum number of user links to return. The service may return fewer than this value. If unspecified, at
        /// most 1000 user links will be returned. The maximum value is 5000; values above 5000 will be coerced to 5000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// A page token, received from a previous `AuditUserLinks` call. Provide this to retrieve the subsequent page.
        /// When paginating, all other parameters provided to `AuditUserLinks` must match the call that provided the
        /// page token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for AuditUserLinks RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaAuditUserLinksResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of AuditUserLinks. These will be ordered stably, but in an arbitrary order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userLinks")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaAuditUserLink> UserLinks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for BatchCreateUserLinks RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaBatchCreateUserLinksRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If set, then email the new users notifying them that they've been granted permissions to the
        /// resource. Regardless of whether this is set or not, notify_new_user field inside each individual request is
        /// ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notifyNewUsers")]
        public virtual System.Nullable<bool> NotifyNewUsers { get; set; }

        /// <summary>
        /// Required. The requests specifying the user links to create. A maximum of 1000 user links can be created in a
        /// batch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaCreateUserLinkRequest> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for BatchCreateUserLinks RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaBatchCreateUserLinksResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The user links created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userLinks")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaUserLink> UserLinks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for BatchDeleteUserLinks RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaBatchDeleteUserLinksRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The requests specifying the user links to update. A maximum of 1000 user links can be updated in a
        /// batch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaDeleteUserLinkRequest> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for BatchGetUserLinks RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaBatchGetUserLinksResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The requested user links.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userLinks")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaUserLink> UserLinks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for BatchUpdateUserLinks RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaBatchUpdateUserLinksRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The requests specifying the user links to update. A maximum of 1000 user links can be updated in a
        /// batch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaUpdateUserLinkRequest> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for BatchUpdateUserLinks RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaBatchUpdateUserLinksResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The user links updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userLinks")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaUserLink> UserLinks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A description of a change to a single Google Analytics resource.</summary>
    public class GoogleAnalyticsAdminV1alphaChangeHistoryChange : Google.Apis.Requests.IDirectResponseSchema
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
        public virtual GoogleAnalyticsAdminV1alphaChangeHistoryChangeChangeHistoryResource ResourceAfterChange { get; set; }

        /// <summary>
        /// Resource contents from before the change was made. If this resource was created in this change, this field
        /// will be missing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceBeforeChange")]
        public virtual GoogleAnalyticsAdminV1alphaChangeHistoryChangeChangeHistoryResource ResourceBeforeChange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A snapshot of a resource as before or after the result of a change in change history.</summary>
    public class GoogleAnalyticsAdminV1alphaChangeHistoryChangeChangeHistoryResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A snapshot of an Account resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("account")]
        public virtual GoogleAnalyticsAdminV1alphaAccount Account { get; set; }

        /// <summary>A snapshot of an AndroidAppDataStream resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidAppDataStream")]
        public virtual GoogleAnalyticsAdminV1alphaAndroidAppDataStream AndroidAppDataStream { get; set; }

        /// <summary>A snapshot of a FirebaseLink resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firebaseLink")]
        public virtual GoogleAnalyticsAdminV1alphaFirebaseLink FirebaseLink { get; set; }

        /// <summary>A snapshot of a GoogleAdsLink resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleAdsLink")]
        public virtual GoogleAnalyticsAdminV1alphaGoogleAdsLink GoogleAdsLink { get; set; }

        /// <summary>A snapshot of an IosAppDataStream resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosAppDataStream")]
        public virtual GoogleAnalyticsAdminV1alphaIosAppDataStream IosAppDataStream { get; set; }

        /// <summary>A snapshot of a Property resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual GoogleAnalyticsAdminV1alphaProperty Property { get; set; }

        /// <summary>A snapshot of a WebDataStream resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webDataStream")]
        public virtual GoogleAnalyticsAdminV1alphaWebDataStream WebDataStream { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A set of changes within a Google Analytics account or its child properties that resulted from the same cause.
    /// Common causes would be updates made in the Google Analytics UI, changes from customer support, or automatic
    /// Google Analytics system changes.
    /// </summary>
    public class GoogleAnalyticsAdminV1alphaChangeHistoryEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of actor that made this change.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actorType")]
        public virtual string ActorType { get; set; }

        /// <summary>Time when change was made.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("changeTime")]
        public virtual object ChangeTime { get; set; }

        /// <summary>
        /// A list of changes made in this change history event that fit the filters specified in
        /// SearchChangeHistoryEventsRequest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("changes")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaChangeHistoryChange> Changes { get; set; }

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

    /// <summary>
    /// Request message for CreateUserLink RPC. Users can have multiple email addresses associated with their Google
    /// account, and one of these email addresses is the "primary" email address. Any of the email addresses associated
    /// with a Google account may be used for a new UserLink, but the returned UserLink will always contain the
    /// "primary" email address. As a result, the input and output email address for this request may differ.
    /// </summary>
    public class GoogleAnalyticsAdminV1alphaCreateUserLinkRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If set, then email the new user notifying them that they've been granted permissions to the
        /// resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notifyNewUser")]
        public virtual System.Nullable<bool> NotifyNewUser { get; set; }

        /// <summary>Required. Example format: accounts/1234</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>Required. The user link to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userLink")]
        public virtual GoogleAnalyticsAdminV1alphaUserLink UserLink { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource message representing data sharing settings of a Google Analytics account.</summary>
    public class GoogleAnalyticsAdminV1alphaDataSharingSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Resource name. Format: accounts/{account}/dataSharingSettings Example:
        /// "accounts/1000/dataSharingSettings"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Allows any of Google sales to access the data in order to suggest configuration changes to improve results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sharingWithGoogleAnySalesEnabled")]
        public virtual System.Nullable<bool> SharingWithGoogleAnySalesEnabled { get; set; }

        /// <summary>
        /// Allows Google sales teams that are assigned to the customer to access the data in order to suggest
        /// configuration changes to improve results. Sales team restrictions still apply when enabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sharingWithGoogleAssignedSalesEnabled")]
        public virtual System.Nullable<bool> SharingWithGoogleAssignedSalesEnabled { get; set; }

        /// <summary>Allows Google to use the data to improve other Google products or services.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sharingWithGoogleProductsEnabled")]
        public virtual System.Nullable<bool> SharingWithGoogleProductsEnabled { get; set; }

        /// <summary>Allows Google support to access the data in order to help troubleshoot issues.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sharingWithGoogleSupportEnabled")]
        public virtual System.Nullable<bool> SharingWithGoogleSupportEnabled { get; set; }

        /// <summary>Allows Google to share the data anonymously in aggregate form with others.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sharingWithOthersEnabled")]
        public virtual System.Nullable<bool> SharingWithOthersEnabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DeleteUserLink RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaDeleteUserLinkRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Example format: accounts/1234/userLinks/5678</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Singleton resource under a WebDataStream, configuring measurement of additional site interactions and content.
    /// </summary>
    public class GoogleAnalyticsAdminV1alphaEnhancedMeasurementSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If enabled, capture a file download event each time a link is clicked with a common document, compressed
        /// file, application, video, or audio extension.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileDownloadsEnabled")]
        public virtual System.Nullable<bool> FileDownloadsEnabled { get; set; }

        /// <summary>
        /// Output only. Resource name of this Data Stream. Format:
        /// properties/{property_id}/webDataStreams/{stream_id}/enhancedMeasurementSettings Example:
        /// "properties/1000/webDataStreams/2000/enhancedMeasurementSettings"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// If enabled, capture an outbound click event each time a visitor clicks a link that leads them away from your
        /// domain.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outboundClicksEnabled")]
        public virtual System.Nullable<bool> OutboundClicksEnabled { get; set; }

        /// <summary>
        /// If enabled, capture a page view event each time the website changes the browser history state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageChangesEnabled")]
        public virtual System.Nullable<bool> PageChangesEnabled { get; set; }

        /// <summary>Output only. If enabled, capture a page view event each time a page loads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageLoadsEnabled")]
        public virtual System.Nullable<bool> PageLoadsEnabled { get; set; }

        /// <summary>
        /// Output only. If enabled, capture a page view event each time a page loads or the website changes the browser
        /// history state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageViewsEnabled")]
        public virtual System.Nullable<bool> PageViewsEnabled { get; set; }

        /// <summary>If enabled, capture scroll events each time a visitor gets to the bottom of a page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scrollsEnabled")]
        public virtual System.Nullable<bool> ScrollsEnabled { get; set; }

        /// <summary>
        /// Required. URL query parameters to interpret as site search parameters. Max length is 1024 characters. Must
        /// not be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchQueryParameter")]
        public virtual string SearchQueryParameter { get; set; }

        /// <summary>
        /// If enabled, capture a view search results event each time a visitor performs a search on your site (based on
        /// a query parameter).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("siteSearchEnabled")]
        public virtual System.Nullable<bool> SiteSearchEnabled { get; set; }

        /// <summary>
        /// Indicates whether Enhanced Measurement Settings will be used to automatically measure interactions and
        /// content on this web stream. Changing this value does not affect the settings themselves, but determines
        /// whether they are respected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("streamEnabled")]
        public virtual System.Nullable<bool> StreamEnabled { get; set; }

        /// <summary>Additional URL query parameters. Max length is 1024 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uriQueryParameter")]
        public virtual string UriQueryParameter { get; set; }

        /// <summary>
        /// If enabled, capture video play, progress, and complete events as visitors view embedded videos on your site.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoEngagementEnabled")]
        public virtual System.Nullable<bool> VideoEngagementEnabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A link between an GA4 property and a Firebase project.</summary>
    public class GoogleAnalyticsAdminV1alphaFirebaseLink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Time when this FirebaseLink was originally created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Maximum user access to the GA4 property allowed to admins of the linked Firebase project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximumUserAccess")]
        public virtual string MaximumUserAccess { get; set; }

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

    /// <summary>Read-only resource with the tag for sending data from a website to a WebDataStream.</summary>
    public class GoogleAnalyticsAdminV1alphaGlobalSiteTag : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Resource name for this GlobalSiteTag resource. Format: properties/{propertyId}/globalSiteTag
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Immutable. JavaScript code snippet to be pasted as the first item into the head tag of every webpage to
        /// measure.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
        public virtual string Snippet { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A link between an GA4 property and a Google Ads account.</summary>
    public class GoogleAnalyticsAdminV1alphaGoogleAdsLink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Enable personalized advertising features with this integration. Automatically publish my Google Analytics
        /// audience lists and Google Analytics remarketing events/parameters to the linked Google Ads account. If this
        /// field is not set on create/update it will be defaulted to true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adsPersonalizationEnabled")]
        public virtual System.Nullable<bool> AdsPersonalizationEnabled { get; set; }

        /// <summary>Output only. If true, this link is for a Google Ads manager account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canManageClients")]
        public virtual System.Nullable<bool> CanManageClients { get; set; }

        /// <summary>Output only. Time when this link was originally created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Immutable. Google Ads customer ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerId")]
        public virtual string CustomerId { get; set; }

        /// <summary>
        /// Output only. Email address of the user that created the link. An empty string will be returned if the email
        /// address can't be retrieved.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailAddress")]
        public virtual string EmailAddress { get; set; }

        /// <summary>
        /// Output only. Format: properties/{propertyId}/googleAdsLinks/{googleAdsLinkId} Note: googleAdsLinkId is not
        /// the Google Ads customer ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Time when this link was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource message representing a Google Analytics IOS app stream.</summary>
    public class GoogleAnalyticsAdminV1alphaIosAppDataStream : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Immutable. The Apple App Store Bundle ID for the app Example: "com.example.myiosapp"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bundleId")]
        public virtual string BundleId { get; set; }

        /// <summary>Output only. Time when this stream was originally created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Human-readable display name for the Data Stream. The max allowed display name length is 255 UTF-16 code
        /// units.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. ID of the corresponding iOS app in Firebase, if any. This ID can change if the iOS app is
        /// deleted and recreated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firebaseAppId")]
        public virtual string FirebaseAppId { get; set; }

        /// <summary>
        /// Output only. Resource name of this Data Stream. Format:
        /// properties/{property_id}/iosAppDataStreams/{stream_id} Example: "properties/1000/iosAppDataStreams/2000"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Time when stream payload fields were last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListAccountSummaries RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaListAccountSummariesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Account summaries of all accounts the caller has access to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountSummaries")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaAccountSummary> AccountSummaries { get; set; }

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
    public class GoogleAnalyticsAdminV1alphaListAccountsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Results that were accessible to the caller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accounts")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaAccount> Accounts { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ListAndroidDataStreams RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaListAndroidAppDataStreamsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Results that matched the filter criteria and were accessible to the caller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidAppDataStreams")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaAndroidAppDataStream> AndroidAppDataStreams { get; set; }

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
    public class GoogleAnalyticsAdminV1alphaListFirebaseLinksResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of FirebaseLinks. This will have at most one value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firebaseLinks")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaFirebaseLink> FirebaseLinks { get; set; }

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
    public class GoogleAnalyticsAdminV1alphaListGoogleAdsLinksResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of GoogleAdsLinks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleAdsLinks")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaGoogleAdsLink> GoogleAdsLinks { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ListIosAppDataStreams RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaListIosAppDataStreamsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Results that matched the filter criteria and were accessible to the caller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosAppDataStreams")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaIosAppDataStream> IosAppDataStreams { get; set; }

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
    public class GoogleAnalyticsAdminV1alphaListPropertiesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Results that matched the filter criteria and were accessible to the caller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaProperty> Properties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListUserLinks RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaListUserLinksResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of UserLinks. These will be ordered stably, but in an arbitrary order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userLinks")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaUserLink> UserLinks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ListWebDataStreams RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaListWebDataStreamsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Results that matched the filter criteria and were accessible to the caller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webDataStreams")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaWebDataStream> WebDataStreams { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource message representing a Google Analytics GA4 property.</summary>
    public class GoogleAnalyticsAdminV1alphaProperty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Time when the entity was originally created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// The currency type used in reports involving monetary values. Format: https://en.wikipedia.org/wiki/ISO_4217
        /// Examples: "USD", "EUR", "JPY"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>
        /// Output only. If set, the time at which this property was trashed. If not set, then this property is not
        /// currently in the trash can.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual object DeleteTime { get; set; }

        /// <summary>
        /// Required. Human-readable display name for this property. The max allowed display name length is 100 UTF-16
        /// code units.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. If set, the time at which this trashed property will be permanently deleted. If not set, then
        /// this property is not currently in the trash can and is not slated to be deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual object ExpireTime { get; set; }

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
        /// change the parent. Format: accounts/{account} Example: "accounts/100"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>
        /// Required. Reporting Time Zone, used as the day boundary for reports, regardless of where the data
        /// originates. If the time zone honors DST, Analytics will automatically adjust for the changes. NOTE: Changing
        /// the time zone only affects data going forward, and is not applied retroactively. Format:
        /// https://www.iana.org/time-zones Example: "America/Los_Angeles"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

        /// <summary>Output only. Time when entity payload fields were last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A virtual resource representing metadata for an GA4 property.</summary>
    public class GoogleAnalyticsAdminV1alphaPropertySummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Display name for the property referred to in this account summary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Resource name of property referred to by this property summary Format: properties/{property_id} Example:
        /// "properties/1000"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual string Property { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ProvisionAccountTicket RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaProvisionAccountTicketRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The account to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("account")]
        public virtual GoogleAnalyticsAdminV1alphaAccount Account { get; set; }

        /// <summary>
        /// Redirect URI where the user will be sent after accepting Terms of Service. Must be configured in Developers
        /// Console as a Redirect URI
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redirectUri")]
        public virtual string RedirectUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ProvisionAccountTicket RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaProvisionAccountTicketResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The param to be passed in the ToS link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountTicketId")]
        public virtual string AccountTicketId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for SearchChangeHistoryEvents RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaSearchChangeHistoryEventsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. If set, only return changes that match one or more of these types of actions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual System.Collections.Generic.IList<string> Action { get; set; }

        /// <summary>Optional. If set, only return changes if they are made by a user in this list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actorEmail")]
        public virtual System.Collections.Generic.IList<string> ActorEmail { get; set; }

        /// <summary>Optional. If set, only return changes made after this time (inclusive).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("earliestChangeTime")]
        public virtual object EarliestChangeTime { get; set; }

        /// <summary>Optional. If set, only return changes made before this time (inclusive).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestChangeTime")]
        public virtual object LatestChangeTime { get; set; }

        /// <summary>
        /// Optional. The maximum number of ChangeHistoryEvent items to return. The service may return fewer than this
        /// value, even if there are additional pages. If unspecified, at most 50 items will be returned. The maximum
        /// value is 200 (higher values will be coerced to the maximum).
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
        /// resources.
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
    public class GoogleAnalyticsAdminV1alphaSearchChangeHistoryEventsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Results that were accessible to the caller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("changeHistoryEvents")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaChangeHistoryEvent> ChangeHistoryEvents { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for UpdateUserLink RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaUpdateUserLinkRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The user link to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userLink")]
        public virtual GoogleAnalyticsAdminV1alphaUserLink UserLink { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource message representing a user's permissions on an Account or Property resource.</summary>
    public class GoogleAnalyticsAdminV1alphaUserLink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Roles directly assigned to this user for this account or property. Valid values: predefinedRoles/read
        /// predefinedRoles/collaborate predefinedRoles/edit predefinedRoles/manage-users Excludes roles that are
        /// inherited from a higher-level entity, group, or organization admin role. A UserLink that is updated to have
        /// an empty list of direct_roles will be deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("directRoles")]
        public virtual System.Collections.Generic.IList<string> DirectRoles { get; set; }

        /// <summary>Email address of the user to link</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailAddress")]
        public virtual string EmailAddress { get; set; }

        /// <summary>Example format: properties/1234/userLinks/5678</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource message representing a Google Analytics web stream.</summary>
    public class GoogleAnalyticsAdminV1alphaWebDataStream : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Time when this stream was originally created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Immutable. Domain name of the web app being measured, or empty. Example: "http://www.google.com",
        /// "https://www.google.com"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultUri")]
        public virtual string DefaultUri { get; set; }

        /// <summary>
        /// Required. Human-readable display name for the Data Stream. The max allowed display name length is 100 UTF-16
        /// code units.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. ID of the corresponding web app in Firebase, if any. This ID can change if the web app is
        /// deleted and recreated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firebaseAppId")]
        public virtual string FirebaseAppId { get; set; }

        /// <summary>
        /// Output only. Analytics "Measurement ID", without the "G-" prefix. Example: "G-1A2BCD345E" would just be
        /// "1A2BCD345E"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("measurementId")]
        public virtual string MeasurementId { get; set; }

        /// <summary>
        /// Output only. Resource name of this Data Stream. Format: properties/{property_id}/webDataStreams/{stream_id}
        /// Example: "properties/1000/webDataStreams/2000"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Time when stream payload fields were last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); } The JSON representation for `Empty` is empty JSON
    /// object `{}`.
    /// </summary>
    public class GoogleProtobufEmpty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
