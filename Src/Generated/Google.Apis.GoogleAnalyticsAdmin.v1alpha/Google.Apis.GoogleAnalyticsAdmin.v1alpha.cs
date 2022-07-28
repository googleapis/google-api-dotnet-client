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
            /// <param name="name">Output only. Example format: properties/1234/userLinks/5678</param>
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

                /// <summary>Output only. Example format: properties/1234/userLinks/5678</summary>
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
            Audiences = new AudiencesResource(service);
            ConversionEvents = new ConversionEventsResource(service);
            CustomDimensions = new CustomDimensionsResource(service);
            CustomMetrics = new CustomMetricsResource(service);
            DataStreams = new DataStreamsResource(service);
            DisplayVideo360AdvertiserLinkProposals = new DisplayVideo360AdvertiserLinkProposalsResource(service);
            DisplayVideo360AdvertiserLinks = new DisplayVideo360AdvertiserLinksResource(service);
            FirebaseLinks = new FirebaseLinksResource(service);
            GoogleAdsLinks = new GoogleAdsLinksResource(service);
            UserLinks = new UserLinksResource(service);
        }

        /// <summary>Gets the Audiences resource.</summary>
        public virtual AudiencesResource Audiences { get; }

        /// <summary>The "audiences" collection of methods.</summary>
        public class AudiencesResource
        {
            private const string Resource = "audiences";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AudiencesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Archives an Audience on a property.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. Example format: properties/1234/audiences/5678</param>
            public virtual ArchiveRequest Archive(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaArchiveAudienceRequest body, string name)
            {
                return new ArchiveRequest(service, body, name);
            }

            /// <summary>Archives an Audience on a property.</summary>
            public class ArchiveRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Archive request.</summary>
                public ArchiveRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaArchiveAudienceRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Example format: properties/1234/audiences/5678</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaArchiveAudienceRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "archive";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}:archive";

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
                        Pattern = @"^properties/[^/]+/audiences/[^/]+$",
                    });
                }
            }

            /// <summary>Creates an Audience.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. Example format: properties/1234</param>
            public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAudience body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates an Audience.</summary>
            public class CreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAudience>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAudience body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Example format: properties/1234</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAudience Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/audiences";

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

            /// <summary>Lookup for a single Audience.</summary>
            /// <param name="name">
            /// Required. The name of the Audience to get. Example format: properties/1234/audiences/5678
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Lookup for a single Audience.</summary>
            public class GetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAudience>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the Audience to get. Example format: properties/1234/audiences/5678
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
                        Pattern = @"^properties/[^/]+/audiences/[^/]+$",
                    });
                }
            }

            /// <summary>Lists Audiences on a property.</summary>
            /// <param name="parent">Required. Example format: properties/1234</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists Audiences on a property.</summary>
            public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaListAudiencesResponse>
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
                /// A page token, received from a previous `ListAudiences` call. Provide this to retrieve the subsequent
                /// page. When paginating, all other parameters provided to `ListAudiences` must match the call that
                /// provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/audiences";

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

            /// <summary>Updates an Audience on a property.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Output only. The resource name for this Audience resource. Format:
            /// properties/{propertyId}/audiences/{audienceId}
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAudience body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates an Audience on a property.</summary>
            public class PatchRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAudience>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAudience body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Output only. The resource name for this Audience resource. Format:
                /// properties/{propertyId}/audiences/{audienceId}
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
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAudience Body { get; set; }

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
                        Pattern = @"^properties/[^/]+/audiences/[^/]+$",
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

            /// <summary>Creates a conversion event with the specified attributes.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The resource name of the parent property where this conversion event will be created. Format:
            /// properties/123
            /// </param>
            public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaConversionEvent body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a conversion event with the specified attributes.</summary>
            public class CreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaConversionEvent>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaConversionEvent body, string parent) : base(service)
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
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaConversionEvent Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/conversionEvents";

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

            /// <summary>Deletes a conversion event in a property.</summary>
            /// <param name="name">
            /// Required. The resource name of the conversion event to delete. Format:
            /// properties/{property}/conversionEvents/{conversion_event} Example: "properties/123/conversionEvents/456"
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes a conversion event in a property.</summary>
            public class DeleteRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleProtobufEmpty>
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
                        Pattern = @"^properties/[^/]+/conversionEvents/[^/]+$",
                    });
                }
            }

            /// <summary>Retrieve a single conversion event.</summary>
            /// <param name="name">
            /// Required. The resource name of the conversion event to retrieve. Format:
            /// properties/{property}/conversionEvents/{conversion_event} Example: "properties/123/conversionEvents/456"
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Retrieve a single conversion event.</summary>
            public class GetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaConversionEvent>
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
                        Pattern = @"^properties/[^/]+/conversionEvents/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Returns a list of conversion events in the specified parent property. Returns an empty list if no
            /// conversion events are found.
            /// </summary>
            /// <param name="parent">
            /// Required. The resource name of the parent property. Example: 'properties/123'
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Returns a list of conversion events in the specified parent property. Returns an empty list if no
            /// conversion events are found.
            /// </summary>
            public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaListConversionEventsResponse>
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
                public override string RestPath => "v1alpha/{+parent}/conversionEvents";

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
            public virtual ArchiveRequest Archive(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaArchiveCustomDimensionRequest body, string name)
            {
                return new ArchiveRequest(service, body, name);
            }

            /// <summary>Archives a CustomDimension on a property.</summary>
            public class ArchiveRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Archive request.</summary>
                public ArchiveRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaArchiveCustomDimensionRequest body, string name) : base(service)
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
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaArchiveCustomDimensionRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "archive";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}:archive";

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
            public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaCustomDimension body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a CustomDimension.</summary>
            public class CreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaCustomDimension>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaCustomDimension body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Example format: properties/1234</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaCustomDimension Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/customDimensions";

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
                return new GetRequest(service, name);
            }

            /// <summary>Lookup for a single CustomDimension.</summary>
            public class GetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaCustomDimension>
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
                        Pattern = @"^properties/[^/]+/customDimensions/[^/]+$",
                    });
                }
            }

            /// <summary>Lists CustomDimensions on a property.</summary>
            /// <param name="parent">Required. Example format: properties/1234</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists CustomDimensions on a property.</summary>
            public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaListCustomDimensionsResponse>
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
                public override string RestPath => "v1alpha/{+parent}/customDimensions";

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
            public virtual PatchRequest Patch(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaCustomDimension body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates a CustomDimension on a property.</summary>
            public class PatchRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaCustomDimension>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaCustomDimension body, string name) : base(service)
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
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaCustomDimension Body { get; set; }

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
            public virtual ArchiveRequest Archive(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaArchiveCustomMetricRequest body, string name)
            {
                return new ArchiveRequest(service, body, name);
            }

            /// <summary>Archives a CustomMetric on a property.</summary>
            public class ArchiveRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Archive request.</summary>
                public ArchiveRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaArchiveCustomMetricRequest body, string name) : base(service)
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
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaArchiveCustomMetricRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "archive";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}:archive";

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
            public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaCustomMetric body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a CustomMetric.</summary>
            public class CreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaCustomMetric>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaCustomMetric body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Example format: properties/1234</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaCustomMetric Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/customMetrics";

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
                return new GetRequest(service, name);
            }

            /// <summary>Lookup for a single CustomMetric.</summary>
            public class GetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaCustomMetric>
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
                        Pattern = @"^properties/[^/]+/customMetrics/[^/]+$",
                    });
                }
            }

            /// <summary>Lists CustomMetrics on a property.</summary>
            /// <param name="parent">Required. Example format: properties/1234</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists CustomMetrics on a property.</summary>
            public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaListCustomMetricsResponse>
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
                public override string RestPath => "v1alpha/{+parent}/customMetrics";

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
            public virtual PatchRequest Patch(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaCustomMetric body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates a CustomMetric on a property.</summary>
            public class PatchRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaCustomMetric>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaCustomMetric body, string name) : base(service)
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
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaCustomMetric Body { get; set; }

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
                public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaMeasurementProtocolSecret body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a measurement protocol secret.</summary>
                public class CreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaMeasurementProtocolSecret>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaMeasurementProtocolSecret body, string parent) : base(service)
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
                    Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaMeasurementProtocolSecret Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/measurementProtocolSecrets";

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
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes target MeasurementProtocolSecret.</summary>
                public class DeleteRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleProtobufEmpty>
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
                            Pattern = @"^properties/[^/]+/dataStreams/[^/]+/measurementProtocolSecrets/[^/]+$",
                        });
                    }
                }

                /// <summary>Lookup for a single "GA4" MeasurementProtocolSecret.</summary>
                /// <param name="name">
                /// Required. The name of the measurement protocol secret to lookup. Format:
                /// properties/{property}/dataStreams/{dataStream}/measurementProtocolSecrets/{measurementProtocolSecret}
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Lookup for a single "GA4" MeasurementProtocolSecret.</summary>
                public class GetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaMeasurementProtocolSecret>
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
                    return new ListRequest(service, parent);
                }

                /// <summary>Returns child MeasurementProtocolSecrets under the specified parent Property.</summary>
                public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaListMeasurementProtocolSecretsResponse>
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
                    public override string RestPath => "v1alpha/{+parent}/measurementProtocolSecrets";

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
                public virtual PatchRequest Patch(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaMeasurementProtocolSecret body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Updates a measurement protocol secret.</summary>
                public class PatchRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaMeasurementProtocolSecret>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaMeasurementProtocolSecret body, string name) : base(service)
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

                    /// <summary>The list of fields to be updated. Omitted fields will not be updated.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaMeasurementProtocolSecret Body { get; set; }

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
            public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaDataStream body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a DataStream.</summary>
            public class CreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaDataStream>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaDataStream body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Example format: properties/1234</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaDataStream Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/dataStreams";

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
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes a DataStream on a property.</summary>
            public class DeleteRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleProtobufEmpty>
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
                return new GetRequest(service, name);
            }

            /// <summary>Lookup for a single DataStream.</summary>
            public class GetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaDataStream>
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
                        Pattern = @"^properties/[^/]+/dataStreams/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Returns the Site Tag for the specified web stream. Site Tags are immutable singletons.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the site tag to lookup. Note that site tags are singletons and do not have unique
            /// IDs. Format: properties/{property_id}/dataStreams/{stream_id}/globalSiteTag Example:
            /// "properties/123/dataStreams/456/globalSiteTag"
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
                /// unique IDs. Format: properties/{property_id}/dataStreams/{stream_id}/globalSiteTag Example:
                /// "properties/123/dataStreams/456/globalSiteTag"
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
                        Pattern = @"^properties/[^/]+/dataStreams/[^/]+/globalSiteTag$",
                    });
                }
            }

            /// <summary>Lists DataStreams on a property.</summary>
            /// <param name="parent">Required. Example format: properties/1234</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists DataStreams on a property.</summary>
            public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaListDataStreamsResponse>
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
                public override string RestPath => "v1alpha/{+parent}/dataStreams";

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
            public virtual PatchRequest Patch(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaDataStream body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates a DataStream on a property.</summary>
            public class PatchRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaDataStream>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaDataStream body, string name) : base(service)
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
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaDataStream Body { get; set; }

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

        /// <summary>Gets the DisplayVideo360AdvertiserLinkProposals resource.</summary>
        public virtual DisplayVideo360AdvertiserLinkProposalsResource DisplayVideo360AdvertiserLinkProposals { get; }

        /// <summary>The "displayVideo360AdvertiserLinkProposals" collection of methods.</summary>
        public class DisplayVideo360AdvertiserLinkProposalsResource
        {
            private const string Resource = "displayVideo360AdvertiserLinkProposals";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public DisplayVideo360AdvertiserLinkProposalsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Approves a DisplayVideo360AdvertiserLinkProposal. The DisplayVideo360AdvertiserLinkProposal will be
            /// deleted and a new DisplayVideo360AdvertiserLink will be created.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The name of the DisplayVideo360AdvertiserLinkProposal to approve. Example format:
            /// properties/1234/displayVideo360AdvertiserLinkProposals/5678
            /// </param>
            public virtual ApproveRequest Approve(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaApproveDisplayVideo360AdvertiserLinkProposalRequest body, string name)
            {
                return new ApproveRequest(service, body, name);
            }

            /// <summary>
            /// Approves a DisplayVideo360AdvertiserLinkProposal. The DisplayVideo360AdvertiserLinkProposal will be
            /// deleted and a new DisplayVideo360AdvertiserLink will be created.
            /// </summary>
            public class ApproveRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaApproveDisplayVideo360AdvertiserLinkProposalResponse>
            {
                /// <summary>Constructs a new Approve request.</summary>
                public ApproveRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaApproveDisplayVideo360AdvertiserLinkProposalRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the DisplayVideo360AdvertiserLinkProposal to approve. Example format:
                /// properties/1234/displayVideo360AdvertiserLinkProposals/5678
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaApproveDisplayVideo360AdvertiserLinkProposalRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "approve";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}:approve";

                /// <summary>Initializes Approve parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^properties/[^/]+/displayVideo360AdvertiserLinkProposals/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Cancels a DisplayVideo360AdvertiserLinkProposal. Cancelling can mean either: - Declining a proposal
            /// initiated from Display &amp;amp; Video 360 - Withdrawing a proposal initiated from Google Analytics
            /// After being cancelled, a proposal will eventually be deleted automatically.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The name of the DisplayVideo360AdvertiserLinkProposal to cancel. Example format:
            /// properties/1234/displayVideo360AdvertiserLinkProposals/5678
            /// </param>
            public virtual CancelRequest Cancel(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaCancelDisplayVideo360AdvertiserLinkProposalRequest body, string name)
            {
                return new CancelRequest(service, body, name);
            }

            /// <summary>
            /// Cancels a DisplayVideo360AdvertiserLinkProposal. Cancelling can mean either: - Declining a proposal
            /// initiated from Display &amp;amp; Video 360 - Withdrawing a proposal initiated from Google Analytics
            /// After being cancelled, a proposal will eventually be deleted automatically.
            /// </summary>
            public class CancelRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaDisplayVideo360AdvertiserLinkProposal>
            {
                /// <summary>Constructs a new Cancel request.</summary>
                public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaCancelDisplayVideo360AdvertiserLinkProposalRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the DisplayVideo360AdvertiserLinkProposal to cancel. Example format:
                /// properties/1234/displayVideo360AdvertiserLinkProposals/5678
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaCancelDisplayVideo360AdvertiserLinkProposalRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "cancel";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}:cancel";

                /// <summary>Initializes Cancel parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^properties/[^/]+/displayVideo360AdvertiserLinkProposals/[^/]+$",
                    });
                }
            }

            /// <summary>Creates a DisplayVideo360AdvertiserLinkProposal.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. Example format: properties/1234</param>
            public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaDisplayVideo360AdvertiserLinkProposal body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a DisplayVideo360AdvertiserLinkProposal.</summary>
            public class CreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaDisplayVideo360AdvertiserLinkProposal>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaDisplayVideo360AdvertiserLinkProposal body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Example format: properties/1234</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaDisplayVideo360AdvertiserLinkProposal Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/displayVideo360AdvertiserLinkProposals";

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

            /// <summary>
            /// Deletes a DisplayVideo360AdvertiserLinkProposal on a property. This can only be used on cancelled
            /// proposals.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the DisplayVideo360AdvertiserLinkProposal to delete. Example format:
            /// properties/1234/displayVideo360AdvertiserLinkProposals/5678
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>
            /// Deletes a DisplayVideo360AdvertiserLinkProposal on a property. This can only be used on cancelled
            /// proposals.
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
                /// Required. The name of the DisplayVideo360AdvertiserLinkProposal to delete. Example format:
                /// properties/1234/displayVideo360AdvertiserLinkProposals/5678
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
                        Pattern = @"^properties/[^/]+/displayVideo360AdvertiserLinkProposals/[^/]+$",
                    });
                }
            }

            /// <summary>Lookup for a single DisplayVideo360AdvertiserLinkProposal.</summary>
            /// <param name="name">
            /// Required. The name of the DisplayVideo360AdvertiserLinkProposal to get. Example format:
            /// properties/1234/displayVideo360AdvertiserLinkProposals/5678
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Lookup for a single DisplayVideo360AdvertiserLinkProposal.</summary>
            public class GetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaDisplayVideo360AdvertiserLinkProposal>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the DisplayVideo360AdvertiserLinkProposal to get. Example format:
                /// properties/1234/displayVideo360AdvertiserLinkProposals/5678
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
                        Pattern = @"^properties/[^/]+/displayVideo360AdvertiserLinkProposals/[^/]+$",
                    });
                }
            }

            /// <summary>Lists DisplayVideo360AdvertiserLinkProposals on a property.</summary>
            /// <param name="parent">Required. Example format: properties/1234</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists DisplayVideo360AdvertiserLinkProposals on a property.</summary>
            public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaListDisplayVideo360AdvertiserLinkProposalsResponse>
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
                /// A page token, received from a previous `ListDisplayVideo360AdvertiserLinkProposals` call. Provide
                /// this to retrieve the subsequent page. When paginating, all other parameters provided to
                /// `ListDisplayVideo360AdvertiserLinkProposals` must match the call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/displayVideo360AdvertiserLinkProposals";

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

        /// <summary>Gets the DisplayVideo360AdvertiserLinks resource.</summary>
        public virtual DisplayVideo360AdvertiserLinksResource DisplayVideo360AdvertiserLinks { get; }

        /// <summary>The "displayVideo360AdvertiserLinks" collection of methods.</summary>
        public class DisplayVideo360AdvertiserLinksResource
        {
            private const string Resource = "displayVideo360AdvertiserLinks";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public DisplayVideo360AdvertiserLinksResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a DisplayVideo360AdvertiserLink. This can only be utilized by users who have proper
            /// authorization both on the Google Analytics property and on the Display &amp;amp; Video 360 advertiser.
            /// Users who do not have access to the Display &amp;amp; Video 360 advertiser should instead seek to create
            /// a DisplayVideo360LinkProposal.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. Example format: properties/1234</param>
            public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaDisplayVideo360AdvertiserLink body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Creates a DisplayVideo360AdvertiserLink. This can only be utilized by users who have proper
            /// authorization both on the Google Analytics property and on the Display &amp;amp; Video 360 advertiser.
            /// Users who do not have access to the Display &amp;amp; Video 360 advertiser should instead seek to create
            /// a DisplayVideo360LinkProposal.
            /// </summary>
            public class CreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaDisplayVideo360AdvertiserLink>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaDisplayVideo360AdvertiserLink body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Example format: properties/1234</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaDisplayVideo360AdvertiserLink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/displayVideo360AdvertiserLinks";

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

            /// <summary>Deletes a DisplayVideo360AdvertiserLink on a property.</summary>
            /// <param name="name">
            /// Required. The name of the DisplayVideo360AdvertiserLink to delete. Example format:
            /// properties/1234/displayVideo360AdvertiserLinks/5678
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes a DisplayVideo360AdvertiserLink on a property.</summary>
            public class DeleteRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the DisplayVideo360AdvertiserLink to delete. Example format:
                /// properties/1234/displayVideo360AdvertiserLinks/5678
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
                        Pattern = @"^properties/[^/]+/displayVideo360AdvertiserLinks/[^/]+$",
                    });
                }
            }

            /// <summary>Look up a single DisplayVideo360AdvertiserLink</summary>
            /// <param name="name">
            /// Required. The name of the DisplayVideo360AdvertiserLink to get. Example format:
            /// properties/1234/displayVideo360AdvertiserLink/5678
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Look up a single DisplayVideo360AdvertiserLink</summary>
            public class GetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaDisplayVideo360AdvertiserLink>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the DisplayVideo360AdvertiserLink to get. Example format:
                /// properties/1234/displayVideo360AdvertiserLink/5678
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
                        Pattern = @"^properties/[^/]+/displayVideo360AdvertiserLinks/[^/]+$",
                    });
                }
            }

            /// <summary>Lists all DisplayVideo360AdvertiserLinks on a property.</summary>
            /// <param name="parent">Required. Example format: properties/1234</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists all DisplayVideo360AdvertiserLinks on a property.</summary>
            public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaListDisplayVideo360AdvertiserLinksResponse>
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
                /// A page token, received from a previous `ListDisplayVideo360AdvertiserLinks` call. Provide this to
                /// retrieve the subsequent page. When paginating, all other parameters provided to
                /// `ListDisplayVideo360AdvertiserLinks` must match the call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/displayVideo360AdvertiserLinks";

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

            /// <summary>Updates a DisplayVideo360AdvertiserLink on a property.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Output only. The resource name for this DisplayVideo360AdvertiserLink resource. Format:
            /// properties/{propertyId}/displayVideo360AdvertiserLinks/{linkId} Note: linkId is not the Display
            /// &amp;amp; Video 360 Advertiser ID
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaDisplayVideo360AdvertiserLink body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates a DisplayVideo360AdvertiserLink on a property.</summary>
            public class PatchRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaDisplayVideo360AdvertiserLink>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaDisplayVideo360AdvertiserLink body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Output only. The resource name for this DisplayVideo360AdvertiserLink resource. Format:
                /// properties/{propertyId}/displayVideo360AdvertiserLinks/{linkId} Note: linkId is not the Display
                /// &amp;amp; Video 360 Advertiser ID
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
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaDisplayVideo360AdvertiserLink Body { get; set; }

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
                        Pattern = @"^properties/[^/]+/displayVideo360AdvertiserLinks/[^/]+$",
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
            /// <param name="name">Output only. Example format: properties/1234/userLinks/5678</param>
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

                /// <summary>Output only. Example format: properties/1234/userLinks/5678</summary>
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

        /// <summary>
        /// Acknowledges the terms of user data collection for the specified property. This acknowledgement must be
        /// completed (either in the Google Analytics UI or via this API) before MeasurementProtocolSecret resources may
        /// be created.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="property">Required. The property for which to acknowledge user data collection.</param>
        public virtual AcknowledgeUserDataCollectionRequest AcknowledgeUserDataCollection(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAcknowledgeUserDataCollectionRequest body, string property)
        {
            return new AcknowledgeUserDataCollectionRequest(service, body, property);
        }

        /// <summary>
        /// Acknowledges the terms of user data collection for the specified property. This acknowledgement must be
        /// completed (either in the Google Analytics UI or via this API) before MeasurementProtocolSecret resources may
        /// be created.
        /// </summary>
        public class AcknowledgeUserDataCollectionRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAcknowledgeUserDataCollectionResponse>
        {
            /// <summary>Constructs a new AcknowledgeUserDataCollection request.</summary>
            public AcknowledgeUserDataCollectionRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAcknowledgeUserDataCollectionRequest body, string property) : base(service)
            {
                Property = property;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The property for which to acknowledge user data collection.</summary>
            [Google.Apis.Util.RequestParameterAttribute("property", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Property { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAcknowledgeUserDataCollectionRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "acknowledgeUserDataCollection";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/{+property}:acknowledgeUserDataCollection";

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

        /// <summary>Lookup for a AttributionSettings singleton.</summary>
        /// <param name="name">
        /// Required. The name of the attribution settings to retrieve. Format:
        /// properties/{property}/attributionSettings
        /// </param>
        public virtual GetAttributionSettingsRequest GetAttributionSettings(string name)
        {
            return new GetAttributionSettingsRequest(service, name);
        }

        /// <summary>Lookup for a AttributionSettings singleton.</summary>
        public class GetAttributionSettingsRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAttributionSettings>
        {
            /// <summary>Constructs a new GetAttributionSettings request.</summary>
            public GetAttributionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the attribution settings to retrieve. Format:
            /// properties/{property}/attributionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getAttributionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/{+name}";

            /// <summary>Initializes GetAttributionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^properties/[^/]+/attributionSettings$",
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
            return new GetDataRetentionSettingsRequest(service, name);
        }

        /// <summary>Returns the singleton data retention settings for this property.</summary>
        public class GetDataRetentionSettingsRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaDataRetentionSettings>
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
            public override string RestPath => "v1alpha/{+name}";

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

        /// <summary>Lookup for Google Signals settings for a property.</summary>
        /// <param name="name">
        /// Required. The name of the google signals settings to retrieve. Format:
        /// properties/{property}/googleSignalsSettings
        /// </param>
        public virtual GetGoogleSignalsSettingsRequest GetGoogleSignalsSettings(string name)
        {
            return new GetGoogleSignalsSettingsRequest(service, name);
        }

        /// <summary>Lookup for Google Signals settings for a property.</summary>
        public class GetGoogleSignalsSettingsRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaGoogleSignalsSettings>
        {
            /// <summary>Constructs a new GetGoogleSignalsSettings request.</summary>
            public GetGoogleSignalsSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the google signals settings to retrieve. Format:
            /// properties/{property}/googleSignalsSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getGoogleSignalsSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/{+name}";

            /// <summary>Initializes GetGoogleSignalsSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^properties/[^/]+/googleSignalsSettings$",
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
            /// `parent:`(The resource name of the parent account/property) or `ancestor:`(The resource name of the
            /// parent account) or `firebase_project:`(The id or number of the linked firebase project). Some examples
            /// of filters: ``` | Filter | Description |
            /// |-----------------------------|-------------------------------------------| | parent:accounts/123 | The
            /// account with account id: 123. | | parent:properties/123 | The property with property id: 123. | |
            /// ancestor:accounts/123 | The account with account id: 123. | | firebase_project:project-id | The firebase
            /// project with id: project-id. | | firebase_project:123 | The firebase project with number: 123. | ```
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

        /// <summary>Updates attribution settings on a property.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Output only. Resource name of this attribution settings resource. Format:
        /// properties/{property_id}/attributionSettings Example: "properties/1000/attributionSettings"
        /// </param>
        public virtual UpdateAttributionSettingsRequest UpdateAttributionSettings(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAttributionSettings body, string name)
        {
            return new UpdateAttributionSettingsRequest(service, body, name);
        }

        /// <summary>Updates attribution settings on a property.</summary>
        public class UpdateAttributionSettingsRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAttributionSettings>
        {
            /// <summary>Constructs a new UpdateAttributionSettings request.</summary>
            public UpdateAttributionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAttributionSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Output only. Resource name of this attribution settings resource. Format:
            /// properties/{property_id}/attributionSettings Example: "properties/1000/attributionSettings"
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
            Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAttributionSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateAttributionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/{+name}";

            /// <summary>Initializes UpdateAttributionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^properties/[^/]+/attributionSettings$",
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

        /// <summary>Updates the singleton data retention settings for this property.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Output only. Resource name for this DataRetentionSetting resource. Format:
        /// properties/{property}/dataRetentionSettings
        /// </param>
        public virtual UpdateDataRetentionSettingsRequest UpdateDataRetentionSettings(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaDataRetentionSettings body, string name)
        {
            return new UpdateDataRetentionSettingsRequest(service, body, name);
        }

        /// <summary>Updates the singleton data retention settings for this property.</summary>
        public class UpdateDataRetentionSettingsRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaDataRetentionSettings>
        {
            /// <summary>Constructs a new UpdateDataRetentionSettings request.</summary>
            public UpdateDataRetentionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaDataRetentionSettings body, string name) : base(service)
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
            Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaDataRetentionSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateDataRetentionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/{+name}";

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

        /// <summary>Updates Google Signals settings for a property.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Output only. Resource name of this setting. Format: properties/{property_id}/googleSignalsSettings Example:
        /// "properties/1000/googleSignalsSettings"
        /// </param>
        public virtual UpdateGoogleSignalsSettingsRequest UpdateGoogleSignalsSettings(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaGoogleSignalsSettings body, string name)
        {
            return new UpdateGoogleSignalsSettingsRequest(service, body, name);
        }

        /// <summary>Updates Google Signals settings for a property.</summary>
        public class UpdateGoogleSignalsSettingsRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaGoogleSignalsSettings>
        {
            /// <summary>Constructs a new UpdateGoogleSignalsSettings request.</summary>
            public UpdateGoogleSignalsSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaGoogleSignalsSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Output only. Resource name of this setting. Format: properties/{property_id}/googleSignalsSettings
            /// Example: "properties/1000/googleSignalsSettings"
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
            Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaGoogleSignalsSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateGoogleSignalsSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/{+name}";

            /// <summary>Initializes UpdateGoogleSignalsSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^properties/[^/]+/googleSignalsSettings$",
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

    /// <summary>Request message for AcknowledgeUserDataCollection RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaAcknowledgeUserDataCollectionRequest : Google.Apis.Requests.IDirectResponseSchema
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
    public class GoogleAnalyticsAdminV1alphaAcknowledgeUserDataCollectionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ApproveDisplayVideo360AdvertiserLinkProposal RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaApproveDisplayVideo360AdvertiserLinkProposalRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ApproveDisplayVideo360AdvertiserLinkProposal RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaApproveDisplayVideo360AdvertiserLinkProposalResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The DisplayVideo360AdvertiserLink created as a result of approving the proposal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayVideo360AdvertiserLink")]
        public virtual GoogleAnalyticsAdminV1alphaDisplayVideo360AdvertiserLink DisplayVideo360AdvertiserLink { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ArchiveAudience RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaArchiveAudienceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ArchiveCustomDimension RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaArchiveCustomDimensionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ArchiveCustomMetric RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaArchiveCustomMetricRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The attribution settings used for a given property. This is a singleton resource.</summary>
    public class GoogleAnalyticsAdminV1alphaAttributionSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The lookback window configuration for acquisition conversion events. The default window size is 30
        /// days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acquisitionConversionEventLookbackWindow")]
        public virtual string AcquisitionConversionEventLookbackWindow { get; set; }

        /// <summary>
        /// Output only. Resource name of this attribution settings resource. Format:
        /// properties/{property_id}/attributionSettings Example: "properties/1000/attributionSettings"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. The lookback window for all other, non-acquisition conversion events. The default window size is
        /// 90 days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("otherConversionEventLookbackWindow")]
        public virtual string OtherConversionEventLookbackWindow { get; set; }

        /// <summary>
        /// Required. The reporting attribution model used to calculate conversion credit in this property's reports.
        /// Changing the attribution model will apply to both historical and future data. These changes will be
        /// reflected in reports with conversion and revenue data. User and session data will be unaffected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportingAttributionModel")]
        public virtual string ReportingAttributionModel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource message representing a GA4 Audience.</summary>
    public class GoogleAnalyticsAdminV1alphaAudience : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. It is automatically set by GA to false if this is an NPA Audience and is excluded from ads
        /// personalization.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adsPersonalizationEnabled")]
        public virtual System.Nullable<bool> AdsPersonalizationEnabled { get; set; }

        /// <summary>Required. The description of the Audience.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. The display name of the Audience.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Optional. Specifies an event to log when a user joins the Audience. If not set, no event is logged when a
        /// user joins the Audience.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTrigger")]
        public virtual GoogleAnalyticsAdminV1alphaAudienceEventTrigger EventTrigger { get; set; }

        /// <summary>
        /// Immutable. Specifies how long an exclusion lasts for users that meet the exclusion filter. It is applied to
        /// all EXCLUDE filter clauses and is ignored when there is no EXCLUDE filter clause in the Audience.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exclusionDurationMode")]
        public virtual string ExclusionDurationMode { get; set; }

        /// <summary>
        /// Required. Immutable. null Filter clauses that define the Audience. All clauses will be AND’ed together.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterClauses")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaAudienceFilterClause> FilterClauses { get; set; }

        /// <summary>
        /// Required. Immutable. The duration a user should stay in an Audience. It cannot be set to more than 540 days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membershipDurationDays")]
        public virtual System.Nullable<int> MembershipDurationDays { get; set; }

        /// <summary>
        /// Output only. The resource name for this Audience resource. Format:
        /// properties/{propertyId}/audiences/{audienceId}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A specific filter for a single dimension or metric.</summary>
    public class GoogleAnalyticsAdminV1alphaAudienceDimensionOrMetricFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Indicates whether this filter needs dynamic evaluation or not. If set to true, users join the
        /// Audience if they ever met the condition (static evaluation). If unset or set to false, user evaluation for
        /// an Audience is dynamic; users are added to an Audience when they meet the conditions and then removed when
        /// they no longer meet them. This can only be set when Audience scope is ACROSS_ALL_SESSIONS.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("atAnyPointInTime")]
        public virtual System.Nullable<bool> AtAnyPointInTime { get; set; }

        /// <summary>A filter for numeric or date values between certain values on a dimension or metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("betweenFilter")]
        public virtual GoogleAnalyticsAdminV1alphaAudienceDimensionOrMetricFilterBetweenFilter BetweenFilter { get; set; }

        /// <summary>Required. Immutable. The dimension name or metric name to filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldName")]
        public virtual string FieldName { get; set; }

        /// <summary>
        /// Optional. If set, specifies the time window for which to evaluate data in number of days. If not set, then
        /// audience data is evaluated against lifetime data (i.e., infinite time window). For example, if set to 1 day,
        /// only the current day's data is evaluated. The reference point is the current day when at_any_point_in_time
        /// is unset or false. It can only be set when Audience scope is ACROSS_ALL_SESSIONS and cannot be greater than
        /// 60 days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inAnyNDayPeriod")]
        public virtual System.Nullable<int> InAnyNDayPeriod { get; set; }

        /// <summary>A filter for a string dimension that matches a particular list of options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inListFilter")]
        public virtual GoogleAnalyticsAdminV1alphaAudienceDimensionOrMetricFilterInListFilter InListFilter { get; set; }

        /// <summary>A filter for numeric or date values on a dimension or metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numericFilter")]
        public virtual GoogleAnalyticsAdminV1alphaAudienceDimensionOrMetricFilterNumericFilter NumericFilter { get; set; }

        /// <summary>A filter for a string-type dimension that matches a particular pattern.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringFilter")]
        public virtual GoogleAnalyticsAdminV1alphaAudienceDimensionOrMetricFilterStringFilter StringFilter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A filter for numeric or date values between certain values on a dimension or metric.</summary>
    public class GoogleAnalyticsAdminV1alphaAudienceDimensionOrMetricFilterBetweenFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Begins with this number, inclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fromValue")]
        public virtual GoogleAnalyticsAdminV1alphaAudienceDimensionOrMetricFilterNumericValue FromValue { get; set; }

        /// <summary>Required. Ends with this number, inclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toValue")]
        public virtual GoogleAnalyticsAdminV1alphaAudienceDimensionOrMetricFilterNumericValue ToValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A filter for a string dimension that matches a particular list of options.</summary>
    public class GoogleAnalyticsAdminV1alphaAudienceDimensionOrMetricFilterInListFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. If true, the match is case-sensitive. If false, the match is case-insensitive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caseSensitive")]
        public virtual System.Nullable<bool> CaseSensitive { get; set; }

        /// <summary>Required. The list of possible string values to match against. Must be non-empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A filter for numeric or date values on a dimension or metric.</summary>
    public class GoogleAnalyticsAdminV1alphaAudienceDimensionOrMetricFilterNumericFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The operation applied to a numeric filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual string Operation { get; set; }

        /// <summary>Required. The numeric or date value to match against.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual GoogleAnalyticsAdminV1alphaAudienceDimensionOrMetricFilterNumericValue Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>To represent a number.</summary>
    public class GoogleAnalyticsAdminV1alphaAudienceDimensionOrMetricFilterNumericValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Double value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doubleValue")]
        public virtual System.Nullable<double> DoubleValue { get; set; }

        /// <summary>Integer value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("int64Value")]
        public virtual System.Nullable<long> Int64Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A filter for a string-type dimension that matches a particular pattern.</summary>
    public class GoogleAnalyticsAdminV1alphaAudienceDimensionOrMetricFilterStringFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. If true, the match is case-sensitive. If false, the match is case-insensitive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caseSensitive")]
        public virtual System.Nullable<bool> CaseSensitive { get; set; }

        /// <summary>Required. The match type for the string filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchType")]
        public virtual string MatchType { get; set; }

        /// <summary>Required. The string value to be matched against.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A filter that matches events of a single event name. If an event parameter is specified, only the subset of
    /// events that match both the single event name and the parameter filter expressions match this event filter.
    /// </summary>
    public class GoogleAnalyticsAdminV1alphaAudienceEventFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Immutable. The name of the event to match against.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventName")]
        public virtual string EventName { get; set; }

        /// <summary>
        /// Optional. If specified, this filter matches events that match both the single event name and the parameter
        /// filter expressions. AudienceEventFilter inside the parameter filter expression cannot be set (i.e., nested
        /// event filters are not supported). This should be a single and_group of dimension_or_metric_filter or
        /// not_expression; ANDs of ORs are not supported. Also, if it includes a filter for "eventCount", only that one
        /// will be considered; all the other filters will be ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventParameterFilterExpression")]
        public virtual GoogleAnalyticsAdminV1alphaAudienceFilterExpression EventParameterFilterExpression { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies an event to log when a user joins the Audience.</summary>
    public class GoogleAnalyticsAdminV1alphaAudienceEventTrigger : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The event name that will be logged.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventName")]
        public virtual string EventName { get; set; }

        /// <summary>Required. When to log the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logCondition")]
        public virtual string LogCondition { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A clause for defining either a simple or sequence filter. A filter can be inclusive (i.e., users satisfying the
    /// filter clause are included in the Audience) or exclusive (i.e., users satisfying the filter clause are excluded
    /// from the Audience).
    /// </summary>
    public class GoogleAnalyticsAdminV1alphaAudienceFilterClause : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Specifies whether this is an include or exclude filter clause.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clauseType")]
        public virtual string ClauseType { get; set; }

        /// <summary>Filters that must occur in a specific order for the user to be a member of the Audience.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sequenceFilter")]
        public virtual GoogleAnalyticsAdminV1alphaAudienceSequenceFilter SequenceFilter { get; set; }

        /// <summary>A simple filter that a user must satisfy to be a member of the Audience.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("simpleFilter")]
        public virtual GoogleAnalyticsAdminV1alphaAudienceSimpleFilter SimpleFilter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A logical expression of Audience dimension, metric, or event filters.</summary>
    public class GoogleAnalyticsAdminV1alphaAudienceFilterExpression : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of expressions to be AND’ed together. It can only contain AudienceFilterExpressions with or_group.
        /// This must be set for the top level AudienceFilterExpression.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("andGroup")]
        public virtual GoogleAnalyticsAdminV1alphaAudienceFilterExpressionList AndGroup { get; set; }

        /// <summary>
        /// A filter on a single dimension or metric. This cannot be set on the top level AudienceFilterExpression.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionOrMetricFilter")]
        public virtual GoogleAnalyticsAdminV1alphaAudienceDimensionOrMetricFilter DimensionOrMetricFilter { get; set; }

        /// <summary>
        /// Creates a filter that matches a specific event. This cannot be set on the top level
        /// AudienceFilterExpression.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventFilter")]
        public virtual GoogleAnalyticsAdminV1alphaAudienceEventFilter EventFilter { get; set; }

        /// <summary>
        /// A filter expression to be NOT'ed (i.e., inverted, complemented). It can only include a
        /// dimension_or_metric_filter. This cannot be set on the top level AudienceFilterExpression.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notExpression")]
        public virtual GoogleAnalyticsAdminV1alphaAudienceFilterExpression NotExpression { get; set; }

        /// <summary>
        /// A list of expressions to OR’ed together. It cannot contain AudienceFilterExpressions with and_group or
        /// or_group.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orGroup")]
        public virtual GoogleAnalyticsAdminV1alphaAudienceFilterExpressionList OrGroup { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of Audience filter expressions.</summary>
    public class GoogleAnalyticsAdminV1alphaAudienceFilterExpressionList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of Audience filter expressions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterExpressions")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaAudienceFilterExpression> FilterExpressions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines filters that must occur in a specific order for the user to be a member of the Audience.
    /// </summary>
    public class GoogleAnalyticsAdminV1alphaAudienceSequenceFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Immutable. Specifies the scope for this filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>Optional. Defines the time period in which the whole sequence must occur.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sequenceMaximumDuration")]
        public virtual object SequenceMaximumDuration { get; set; }

        /// <summary>
        /// Required. An ordered sequence of steps. A user must complete each step in order to join the sequence filter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sequenceSteps")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaAudienceSequenceFilterAudienceSequenceStep> SequenceSteps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A condition that must occur in the specified step order for this user to match the sequence.</summary>
    public class GoogleAnalyticsAdminV1alphaAudienceSequenceFilterAudienceSequenceStep : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. When set, this step must be satisfied within the constraint_duration of the previous step (i.e.,
        /// t[i] - t[i-1] &amp;lt;= constraint_duration). If not set, there is no duration requirement (the duration is
        /// effectively unlimited). It is ignored for the first step.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("constraintDuration")]
        public virtual object ConstraintDuration { get; set; }

        /// <summary>
        /// Required. Immutable. A logical expression of Audience dimension, metric, or event filters in each step.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterExpression")]
        public virtual GoogleAnalyticsAdminV1alphaAudienceFilterExpression FilterExpression { get; set; }

        /// <summary>
        /// Optional. If true, the event satisfying this step must be the very next event after the event satisfying the
        /// last step. If unset or false, this step indirectly follows the prior step; for example, there may be events
        /// between the prior step and this step. It is ignored for the first step.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("immediatelyFollows")]
        public virtual System.Nullable<bool> ImmediatelyFollows { get; set; }

        /// <summary>Required. Immutable. Specifies the scope for this step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines a simple filter that a user must satisfy to be a member of the Audience.</summary>
    public class GoogleAnalyticsAdminV1alphaAudienceSimpleFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Immutable. A logical expression of Audience dimension, metric, or event filters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterExpression")]
        public virtual GoogleAnalyticsAdminV1alphaAudienceFilterExpression FilterExpression { get; set; }

        /// <summary>Required. Immutable. Specifies the scope for this filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Read-only resource used to summarize a principal's effective roles.</summary>
    public class GoogleAnalyticsAdminV1alphaAuditUserLink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Roles directly assigned to this user for this entity. Format: predefinedRoles/viewer Excludes roles that are
        /// inherited from an account (if this is for a property), group, or organization admin role.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("directRoles")]
        public virtual System.Collections.Generic.IList<string> DirectRoles { get; set; }

        /// <summary>
        /// Union of all permissions a user has at this account or property (includes direct permissions,
        /// group-inherited permissions, etc.). Format: predefinedRoles/viewer
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

    /// <summary>Request message for CancelDisplayVideo360AdvertiserLinkProposal RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaCancelDisplayVideo360AdvertiserLinkProposalRequest : Google.Apis.Requests.IDirectResponseSchema
    {
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

        /// <summary>A snapshot of AttributionSettings resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributionSettings")]
        public virtual GoogleAnalyticsAdminV1alphaAttributionSettings AttributionSettings { get; set; }

        /// <summary>A snapshot of a ConversionEvent resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionEvent")]
        public virtual GoogleAnalyticsAdminV1alphaConversionEvent ConversionEvent { get; set; }

        /// <summary>A snapshot of a CustomDimension resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customDimension")]
        public virtual GoogleAnalyticsAdminV1alphaCustomDimension CustomDimension { get; set; }

        /// <summary>A snapshot of a CustomMetric resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customMetric")]
        public virtual GoogleAnalyticsAdminV1alphaCustomMetric CustomMetric { get; set; }

        /// <summary>A snapshot of a data retention settings resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataRetentionSettings")]
        public virtual GoogleAnalyticsAdminV1alphaDataRetentionSettings DataRetentionSettings { get; set; }

        /// <summary>A snapshot of a DataStream resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataStream")]
        public virtual GoogleAnalyticsAdminV1alphaDataStream DataStream { get; set; }

        /// <summary>A snapshot of a DisplayVideo360AdvertiserLink resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayVideo360AdvertiserLink")]
        public virtual GoogleAnalyticsAdminV1alphaDisplayVideo360AdvertiserLink DisplayVideo360AdvertiserLink { get; set; }

        /// <summary>A snapshot of a DisplayVideo360AdvertiserLinkProposal resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayVideo360AdvertiserLinkProposal")]
        public virtual GoogleAnalyticsAdminV1alphaDisplayVideo360AdvertiserLinkProposal DisplayVideo360AdvertiserLinkProposal { get; set; }

        /// <summary>A snapshot of a FirebaseLink resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firebaseLink")]
        public virtual GoogleAnalyticsAdminV1alphaFirebaseLink FirebaseLink { get; set; }

        /// <summary>A snapshot of a GoogleAdsLink resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleAdsLink")]
        public virtual GoogleAnalyticsAdminV1alphaGoogleAdsLink GoogleAdsLink { get; set; }

        /// <summary>A snapshot of a GoogleSignalsSettings resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleSignalsSettings")]
        public virtual GoogleAnalyticsAdminV1alphaGoogleSignalsSettings GoogleSignalsSettings { get; set; }

        /// <summary>A snapshot of a MeasurementProtocolSecret resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("measurementProtocolSecret")]
        public virtual GoogleAnalyticsAdminV1alphaMeasurementProtocolSecret MeasurementProtocolSecret { get; set; }

        /// <summary>A snapshot of a Property resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual GoogleAnalyticsAdminV1alphaProperty Property { get; set; }

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

    /// <summary>A conversion event in a Google Analytics property.</summary>
    public class GoogleAnalyticsAdminV1alphaConversionEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Time when this conversion event was created in the property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Output only. If set to true, this conversion event refers to a custom event. If set to false, this
        /// conversion event refers to a default event in GA. Default events typically have special meaning in GA.
        /// Default events are usually created for you by the GA system, but in some cases can be created by property
        /// admins. Custom events count towards the maximum number of custom conversion events that may be created per
        /// property.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("custom")]
        public virtual System.Nullable<bool> Custom { get; set; }

        /// <summary>Output only. If set, this event can currently be deleted via DeleteConversionEvent.</summary>
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

    /// <summary>A definition for a CustomDimension.</summary>
    public class GoogleAnalyticsAdminV1alphaCustomDimension : Google.Apis.Requests.IDirectResponseSchema
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
        /// name. May only contain alphanumeric and underscore characters, starting with a letter. Max length of 24
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
    public class GoogleAnalyticsAdminV1alphaCustomMetric : Google.Apis.Requests.IDirectResponseSchema
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
    public class GoogleAnalyticsAdminV1alphaDataRetentionSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The length of time that event-level data is retained.</summary>
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

    /// <summary>A resource message representing a data stream.</summary>
    public class GoogleAnalyticsAdminV1alphaDataStream : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Data specific to Android app streams. Must be populated if type is ANDROID_APP_DATA_STREAM.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidAppStreamData")]
        public virtual GoogleAnalyticsAdminV1alphaDataStreamAndroidAppStreamData AndroidAppStreamData { get; set; }

        /// <summary>Output only. Time when this stream was originally created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Human-readable display name for the Data Stream. Required for web data streams. The max allowed display name
        /// length is 255 UTF-16 code units.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Data specific to iOS app streams. Must be populated if type is IOS_APP_DATA_STREAM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosAppStreamData")]
        public virtual GoogleAnalyticsAdminV1alphaDataStreamIosAppStreamData IosAppStreamData { get; set; }

        /// <summary>
        /// Output only. Resource name of this Data Stream. Format: properties/{property_id}/dataStreams/{stream_id}
        /// Example: "properties/1000/dataStreams/2000"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. Immutable. The type of this DataStream resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Output only. Time when stream payload fields were last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>Data specific to web streams. Must be populated if type is WEB_DATA_STREAM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webStreamData")]
        public virtual GoogleAnalyticsAdminV1alphaDataStreamWebStreamData WebStreamData { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data specific to Android app streams.</summary>
    public class GoogleAnalyticsAdminV1alphaDataStreamAndroidAppStreamData : Google.Apis.Requests.IDirectResponseSchema
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
    public class GoogleAnalyticsAdminV1alphaDataStreamIosAppStreamData : Google.Apis.Requests.IDirectResponseSchema
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
    public class GoogleAnalyticsAdminV1alphaDataStreamWebStreamData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Immutable. Domain name of the web app being measured, or empty. Example: "http://www.google.com",
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

        /// <summary>
        /// Output only. Analytics "Measurement ID", without the "G-" prefix. Example: "G-1A2BCD345E" would just be
        /// "1A2BCD345E"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("measurementId")]
        public virtual string MeasurementId { get; set; }

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

    /// <summary>A link between a GA4 property and a Display &amp; Video 360 advertiser.</summary>
    public class GoogleAnalyticsAdminV1alphaDisplayVideo360AdvertiserLink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Enables personalized advertising features with this integration. If this field is not set on create/update,
        /// it will be defaulted to true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adsPersonalizationEnabled")]
        public virtual System.Nullable<bool> AdsPersonalizationEnabled { get; set; }

        /// <summary>Output only. The display name of the Display &amp; Video 360 Advertiser.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserDisplayName")]
        public virtual string AdvertiserDisplayName { get; set; }

        /// <summary>Immutable. The Display &amp; Video 360 Advertiser's advertiser ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserId")]
        public virtual string AdvertiserId { get; set; }

        /// <summary>
        /// Immutable. Enables the import of campaign data from Display &amp;amp; Video 360 into the GA4 property. After
        /// link creation, this can only be updated from the Display &amp;amp; Video 360 product. If this field is not
        /// set on create, it will be defaulted to true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("campaignDataSharingEnabled")]
        public virtual System.Nullable<bool> CampaignDataSharingEnabled { get; set; }

        /// <summary>
        /// Immutable. Enables the import of cost data from Display &amp;amp; Video 360 into the GA4 property. This can
        /// only be enabled if campaign_data_sharing_enabled is enabled. After link creation, this can only be updated
        /// from the Display &amp;amp; Video 360 product. If this field is not set on create, it will be defaulted to
        /// true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("costDataSharingEnabled")]
        public virtual System.Nullable<bool> CostDataSharingEnabled { get; set; }

        /// <summary>
        /// Output only. The resource name for this DisplayVideo360AdvertiserLink resource. Format:
        /// properties/{propertyId}/displayVideo360AdvertiserLinks/{linkId} Note: linkId is not the Display &amp;amp;
        /// Video 360 Advertiser ID
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A proposal for a link between a GA4 property and a Display &amp;amp; Video 360 advertiser. A proposal is
    /// converted to a DisplayVideo360AdvertiserLink once approved. Google Analytics admins approve inbound proposals
    /// while Display &amp;amp; Video 360 admins approve outbound proposals.
    /// </summary>
    public class GoogleAnalyticsAdminV1alphaDisplayVideo360AdvertiserLinkProposal : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Immutable. Enables personalized advertising features with this integration. If this field is not set on
        /// create, it will be defaulted to true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adsPersonalizationEnabled")]
        public virtual System.Nullable<bool> AdsPersonalizationEnabled { get; set; }

        /// <summary>
        /// Output only. The display name of the Display &amp;amp; Video Advertiser. Only populated for proposals that
        /// originated from Display &amp;amp; Video 360.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserDisplayName")]
        public virtual string AdvertiserDisplayName { get; set; }

        /// <summary>Immutable. The Display &amp; Video 360 Advertiser's advertiser ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserId")]
        public virtual string AdvertiserId { get; set; }

        /// <summary>
        /// Immutable. Enables the import of campaign data from Display &amp;amp; Video 360. If this field is not set on
        /// create, it will be defaulted to true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("campaignDataSharingEnabled")]
        public virtual System.Nullable<bool> CampaignDataSharingEnabled { get; set; }

        /// <summary>
        /// Immutable. Enables the import of cost data from Display &amp;amp; Video 360. This can only be enabled if
        /// campaign_data_sharing_enabled is enabled. If this field is not set on create, it will be defaulted to true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("costDataSharingEnabled")]
        public virtual System.Nullable<bool> CostDataSharingEnabled { get; set; }

        /// <summary>Output only. The status information for this link proposal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkProposalStatusDetails")]
        public virtual GoogleAnalyticsAdminV1alphaLinkProposalStatusDetails LinkProposalStatusDetails { get; set; }

        /// <summary>
        /// Output only. The resource name for this DisplayVideo360AdvertiserLinkProposal resource. Format:
        /// properties/{propertyId}/displayVideo360AdvertiserLinkProposals/{proposalId} Note: proposalId is not the
        /// Display &amp;amp; Video 360 Advertiser ID
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Input only. On a proposal being sent to Display &amp;amp; Video 360, this field must be set to the email
        /// address of an admin on the target advertiser. This is used to verify that the Google Analytics admin is
        /// aware of at least one admin on the Display &amp;amp; Video 360 Advertiser. This does not restrict approval
        /// of the proposal to a single user. Any admin on the Display &amp;amp; Video 360 Advertiser may approve the
        /// proposal.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validationEmail")]
        public virtual string ValidationEmail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A link between a GA4 property and a Firebase project.</summary>
    public class GoogleAnalyticsAdminV1alphaFirebaseLink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Time when this FirebaseLink was originally created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

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

    /// <summary>
    /// Read-only resource with the tag for sending data from a website to a DataStream. Only present for web DataStream
    /// resources.
    /// </summary>
    public class GoogleAnalyticsAdminV1alphaGlobalSiteTag : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Resource name for this GlobalSiteTag resource. Format:
        /// properties/{property_id}/dataStreams/{stream_id}/globalSiteTag Example:
        /// "properties/123/dataStreams/456/globalSiteTag"
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

    /// <summary>A link between a GA4 property and a Google Ads account.</summary>
    public class GoogleAnalyticsAdminV1alphaGoogleAdsLink : Google.Apis.Requests.IDirectResponseSchema
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

        /// <summary>Output only. Time when this link was originally created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

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

        /// <summary>Output only. Time when this link was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings values for Google Signals. This is a singleton resource.</summary>
    public class GoogleAnalyticsAdminV1alphaGoogleSignalsSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Terms of Service acceptance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consent")]
        public virtual string Consent { get; set; }

        /// <summary>
        /// Output only. Resource name of this setting. Format: properties/{property_id}/googleSignalsSettings Example:
        /// "properties/1000/googleSignalsSettings"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Status of this setting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Status information for a link proposal.</summary>
    public class GoogleAnalyticsAdminV1alphaLinkProposalStatusDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The source of this proposal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkProposalInitiatingProduct")]
        public virtual string LinkProposalInitiatingProduct { get; set; }

        /// <summary>Output only. The state of this proposal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkProposalState")]
        public virtual string LinkProposalState { get; set; }

        /// <summary>Output only. The email address of the user that proposed this linkage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestorEmail")]
        public virtual string RequestorEmail { get; set; }

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

    /// <summary>Response message for ListAudiences RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaListAudiencesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of Audiences.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audiences")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaAudience> Audiences { get; set; }

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
    public class GoogleAnalyticsAdminV1alphaListConversionEventsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The requested conversion events</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionEvents")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaConversionEvent> ConversionEvents { get; set; }

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
    public class GoogleAnalyticsAdminV1alphaListCustomDimensionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of CustomDimensions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customDimensions")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaCustomDimension> CustomDimensions { get; set; }

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
    public class GoogleAnalyticsAdminV1alphaListCustomMetricsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of CustomMetrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customMetrics")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaCustomMetric> CustomMetrics { get; set; }

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
    public class GoogleAnalyticsAdminV1alphaListDataStreamsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of DataStreams.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataStreams")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaDataStream> DataStreams { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListDisplayVideo360AdvertiserLinkProposals RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaListDisplayVideo360AdvertiserLinkProposalsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of DisplayVideo360AdvertiserLinkProposals.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayVideo360AdvertiserLinkProposals")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaDisplayVideo360AdvertiserLinkProposal> DisplayVideo360AdvertiserLinkProposals { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListDisplayVideo360AdvertiserLinks RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaListDisplayVideo360AdvertiserLinksResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of DisplayVideo360AdvertiserLinks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayVideo360AdvertiserLinks")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaDisplayVideo360AdvertiserLink> DisplayVideo360AdvertiserLinks { get; set; }

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

    /// <summary>Response message for ListMeasurementProtocolSecret RPC</summary>
    public class GoogleAnalyticsAdminV1alphaListMeasurementProtocolSecretsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of secrets for the parent stream specified in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("measurementProtocolSecrets")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaMeasurementProtocolSecret> MeasurementProtocolSecrets { get; set; }

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

    /// <summary>A secret value used for sending hits to Measurement Protocol.</summary>
    public class GoogleAnalyticsAdminV1alphaMeasurementProtocolSecret : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>A resource message representing a Google Analytics GA4 property.</summary>
    public class GoogleAnalyticsAdminV1alphaProperty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Immutable. The resource name of the parent account Format: accounts/{account_id} Example: "accounts/123"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("account")]
        public virtual string Account { get; set; }

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
        /// change the parent. Format: accounts/{account}, properties/{property} Example: "accounts/100",
        /// "properties/101"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>
        /// Immutable. The property type for this Property resource. When creating a property, if the type is
        /// "PROPERTY_TYPE_UNSPECIFIED", then "ORDINARY_PROPERTY" will be implied. "SUBPROPERTY" and "ROLLUP_PROPERTY"
        /// types cannot yet be created via Google Analytics Admin API.
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

        /// <summary>Output only. Time when entity payload fields were last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A virtual resource representing metadata for a GA4 property.</summary>
    public class GoogleAnalyticsAdminV1alphaPropertySummary : Google.Apis.Requests.IDirectResponseSchema
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
        /// Roles directly assigned to this user for this account or property. Valid values: predefinedRoles/viewer
        /// predefinedRoles/analyst predefinedRoles/editor predefinedRoles/admin predefinedRoles/no-cost-data
        /// predefinedRoles/no-revenue-data Excludes roles that are inherited from a higher-level entity, group, or
        /// organization admin role. A UserLink that is updated to have an empty list of direct_roles will be deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("directRoles")]
        public virtual System.Collections.Generic.IList<string> DirectRoles { get; set; }

        /// <summary>Immutable. Email address of the user to link</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailAddress")]
        public virtual string EmailAddress { get; set; }

        /// <summary>Output only. Example format: properties/1234/userLinks/5678</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

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
