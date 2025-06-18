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
            return new ListRequest(this.service);
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
            AccessBindings = new AccessBindingsResource(service);
        }

        /// <summary>Gets the AccessBindings resource.</summary>
        public virtual AccessBindingsResource AccessBindings { get; }

        /// <summary>The "accessBindings" collection of methods.</summary>
        public class AccessBindingsResource
        {
            private const string Resource = "accessBindings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AccessBindingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates information about multiple access bindings to an account or property. This method is
            /// transactional. If any AccessBinding cannot be created, none of the AccessBindings will be created.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The account or property that owns the access bindings. The parent field in the
            /// CreateAccessBindingRequest messages must either be empty or match this field. Formats: -
            /// accounts/{account} - properties/{property}
            /// </param>
            public virtual BatchCreateRequest BatchCreate(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchCreateAccessBindingsRequest body, string parent)
            {
                return new BatchCreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Creates information about multiple access bindings to an account or property. This method is
            /// transactional. If any AccessBinding cannot be created, none of the AccessBindings will be created.
            /// </summary>
            public class BatchCreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchCreateAccessBindingsResponse>
            {
                /// <summary>Constructs a new BatchCreate request.</summary>
                public BatchCreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchCreateAccessBindingsRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The account or property that owns the access bindings. The parent field in the
                /// CreateAccessBindingRequest messages must either be empty or match this field. Formats: -
                /// accounts/{account} - properties/{property}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchCreateAccessBindingsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchCreate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/accessBindings:batchCreate";

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
            /// Required. The account or property that owns the access bindings. The parent of all provided values for
            /// the 'names' field in DeleteAccessBindingRequest messages must match this field. Formats: -
            /// accounts/{account} - properties/{property}
            /// </param>
            public virtual BatchDeleteRequest BatchDelete(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchDeleteAccessBindingsRequest body, string parent)
            {
                return new BatchDeleteRequest(this.service, body, parent);
            }

            /// <summary>Deletes information about multiple users' links to an account or property.</summary>
            public class BatchDeleteRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new BatchDelete request.</summary>
                public BatchDeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchDeleteAccessBindingsRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The account or property that owns the access bindings. The parent of all provided values
                /// for the 'names' field in DeleteAccessBindingRequest messages must match this field. Formats: -
                /// accounts/{account} - properties/{property}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchDeleteAccessBindingsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchDelete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/accessBindings:batchDelete";

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

            /// <summary>Gets information about multiple access bindings to an account or property.</summary>
            /// <param name="parent">
            /// Required. The account or property that owns the access bindings. The parent of all provided values for
            /// the 'names' field must match this field. Formats: - accounts/{account} - properties/{property}
            /// </param>
            public virtual BatchGetRequest BatchGet(string parent)
            {
                return new BatchGetRequest(this.service, parent);
            }

            /// <summary>Gets information about multiple access bindings to an account or property.</summary>
            public class BatchGetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchGetAccessBindingsResponse>
            {
                /// <summary>Constructs a new BatchGet request.</summary>
                public BatchGetRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The account or property that owns the access bindings. The parent of all provided values
                /// for the 'names' field must match this field. Formats: - accounts/{account} - properties/{property}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Required. The names of the access bindings to retrieve. A maximum of 1000 access bindings can be
                /// retrieved in a batch. Formats: - accounts/{account}/accessBindings/{accessBinding} -
                /// properties/{property}/accessBindings/{accessBinding}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("names", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> Names { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchGet";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/accessBindings:batchGet";

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

            /// <summary>Updates information about multiple access bindings to an account or property.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The account or property that owns the access bindings. The parent of all provided
            /// AccessBinding in UpdateAccessBindingRequest messages must match this field. Formats: -
            /// accounts/{account} - properties/{property}
            /// </param>
            public virtual BatchUpdateRequest BatchUpdate(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchUpdateAccessBindingsRequest body, string parent)
            {
                return new BatchUpdateRequest(this.service, body, parent);
            }

            /// <summary>Updates information about multiple access bindings to an account or property.</summary>
            public class BatchUpdateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchUpdateAccessBindingsResponse>
            {
                /// <summary>Constructs a new BatchUpdate request.</summary>
                public BatchUpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchUpdateAccessBindingsRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The account or property that owns the access bindings. The parent of all provided
                /// AccessBinding in UpdateAccessBindingRequest messages must match this field. Formats: -
                /// accounts/{account} - properties/{property}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchUpdateAccessBindingsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchUpdate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/accessBindings:batchUpdate";

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

            /// <summary>Creates an access binding on an account or property.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. Formats: - accounts/{account} - properties/{property}</param>
            public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAccessBinding body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>Creates an access binding on an account or property.</summary>
            public class CreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAccessBinding>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAccessBinding body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Formats: - accounts/{account} - properties/{property}</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAccessBinding Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/accessBindings";

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
                }
            }

            /// <summary>Deletes an access binding on an account or property.</summary>
            /// <param name="name">
            /// Required. Formats: - accounts/{account}/accessBindings/{accessBinding} -
            /// properties/{property}/accessBindings/{accessBinding}
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>Deletes an access binding on an account or property.</summary>
            public class DeleteRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Formats: - accounts/{account}/accessBindings/{accessBinding} -
                /// properties/{property}/accessBindings/{accessBinding}
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
                        Pattern = @"^accounts/[^/]+/accessBindings/[^/]+$",
                    });
                }
            }

            /// <summary>Gets information about an access binding.</summary>
            /// <param name="name">
            /// Required. The name of the access binding to retrieve. Formats: -
            /// accounts/{account}/accessBindings/{accessBinding} - properties/{property}/accessBindings/{accessBinding}
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets information about an access binding.</summary>
            public class GetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAccessBinding>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the access binding to retrieve. Formats: -
                /// accounts/{account}/accessBindings/{accessBinding} -
                /// properties/{property}/accessBindings/{accessBinding}
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
                        Pattern = @"^accounts/[^/]+/accessBindings/[^/]+$",
                    });
                }
            }

            /// <summary>Lists all access bindings on an account or property.</summary>
            /// <param name="parent">Required. Formats: - accounts/{account} - properties/{property}</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists all access bindings on an account or property.</summary>
            public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaListAccessBindingsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. Formats: - accounts/{account} - properties/{property}</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of access bindings to return. The service may return fewer than this value. If
                /// unspecified, at most 200 access bindings will be returned. The maximum value is 500; values above
                /// 500 will be coerced to 500.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token, received from a previous `ListAccessBindings` call. Provide this to retrieve the
                /// subsequent page. When paginating, all other parameters provided to `ListAccessBindings` must match
                /// the call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/accessBindings";

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

            /// <summary>Updates an access binding on an account or property.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Output only. Resource name of this binding. Format: accounts/{account}/accessBindings/{access_binding}
            /// or properties/{property}/accessBindings/{access_binding} Example: "accounts/100/accessBindings/200"
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAccessBinding body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>Updates an access binding on an account or property.</summary>
            public class PatchRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAccessBinding>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAccessBinding body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Output only. Resource name of this binding. Format:
                /// accounts/{account}/accessBindings/{access_binding} or
                /// properties/{property}/accessBindings/{access_binding} Example: "accounts/100/accessBindings/200"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAccessBinding Body { get; set; }

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
                        Pattern = @"^accounts/[^/]+/accessBindings/[^/]+$",
                    });
                }
            }
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
            return new GetRequest(this.service, name);
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
        /// `accounts/1000/dataSharingSettings`
        /// </param>
        public virtual GetDataSharingSettingsRequest GetDataSharingSettings(string name)
        {
            return new GetDataSharingSettingsRequest(this.service, name);
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
            /// `accounts/1000/dataSharingSettings`
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
            return new PatchRequest(this.service, body, name);
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
            /// Required. The list of fields to be updated. Field names must be in snake case (for example,
            /// "field_to_update"). Omitted fields will not be updated. To replace the entire entity, use one path with
            /// the string "*" to match all fields.
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
            return new ProvisionAccountTicketRequest(this.service, body);
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
        public virtual RunAccessReportRequest RunAccessReport(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaRunAccessReportRequest body, string entity)
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
        public class RunAccessReportRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaRunAccessReportResponse>
        {
            /// <summary>Constructs a new RunAccessReport request.</summary>
            public RunAccessReportRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaRunAccessReportRequest body, string entity) : base(service)
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
            Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaRunAccessReportRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "runAccessReport";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/{+entity}:runAccessReport";

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
        public virtual SearchChangeHistoryEventsRequest SearchChangeHistoryEvents(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSearchChangeHistoryEventsRequest body, string account)
        {
            return new SearchChangeHistoryEventsRequest(this.service, body, account);
        }

        /// <summary>
        /// Searches through all changes to an account or its children given the specified set of filters. Only returns
        /// the subset of changes supported by the API. The UI may return additional changes.
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

            /// <summary>
            /// Required. The account resource for which to return change history resources. Format: accounts/{account}
            /// Example: `accounts/100`
            /// </summary>
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
            AccessBindings = new AccessBindingsResource(service);
            AdSenseLinks = new AdSenseLinksResource(service);
            Audiences = new AudiencesResource(service);
            BigQueryLinks = new BigQueryLinksResource(service);
            CalculatedMetrics = new CalculatedMetricsResource(service);
            ChannelGroups = new ChannelGroupsResource(service);
            ConversionEvents = new ConversionEventsResource(service);
            CustomDimensions = new CustomDimensionsResource(service);
            CustomMetrics = new CustomMetricsResource(service);
            DataStreams = new DataStreamsResource(service);
            DisplayVideo360AdvertiserLinkProposals = new DisplayVideo360AdvertiserLinkProposalsResource(service);
            DisplayVideo360AdvertiserLinks = new DisplayVideo360AdvertiserLinksResource(service);
            ExpandedDataSets = new ExpandedDataSetsResource(service);
            FirebaseLinks = new FirebaseLinksResource(service);
            GoogleAdsLinks = new GoogleAdsLinksResource(service);
            KeyEvents = new KeyEventsResource(service);
            ReportingDataAnnotations = new ReportingDataAnnotationsResource(service);
            RollupPropertySourceLinks = new RollupPropertySourceLinksResource(service);
            SearchAds360Links = new SearchAds360LinksResource(service);
            SubpropertyEventFilters = new SubpropertyEventFiltersResource(service);
            SubpropertySyncConfigs = new SubpropertySyncConfigsResource(service);
        }

        /// <summary>Gets the AccessBindings resource.</summary>
        public virtual AccessBindingsResource AccessBindings { get; }

        /// <summary>The "accessBindings" collection of methods.</summary>
        public class AccessBindingsResource
        {
            private const string Resource = "accessBindings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AccessBindingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates information about multiple access bindings to an account or property. This method is
            /// transactional. If any AccessBinding cannot be created, none of the AccessBindings will be created.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The account or property that owns the access bindings. The parent field in the
            /// CreateAccessBindingRequest messages must either be empty or match this field. Formats: -
            /// accounts/{account} - properties/{property}
            /// </param>
            public virtual BatchCreateRequest BatchCreate(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchCreateAccessBindingsRequest body, string parent)
            {
                return new BatchCreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Creates information about multiple access bindings to an account or property. This method is
            /// transactional. If any AccessBinding cannot be created, none of the AccessBindings will be created.
            /// </summary>
            public class BatchCreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchCreateAccessBindingsResponse>
            {
                /// <summary>Constructs a new BatchCreate request.</summary>
                public BatchCreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchCreateAccessBindingsRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The account or property that owns the access bindings. The parent field in the
                /// CreateAccessBindingRequest messages must either be empty or match this field. Formats: -
                /// accounts/{account} - properties/{property}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchCreateAccessBindingsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchCreate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/accessBindings:batchCreate";

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
            /// Required. The account or property that owns the access bindings. The parent of all provided values for
            /// the 'names' field in DeleteAccessBindingRequest messages must match this field. Formats: -
            /// accounts/{account} - properties/{property}
            /// </param>
            public virtual BatchDeleteRequest BatchDelete(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchDeleteAccessBindingsRequest body, string parent)
            {
                return new BatchDeleteRequest(this.service, body, parent);
            }

            /// <summary>Deletes information about multiple users' links to an account or property.</summary>
            public class BatchDeleteRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new BatchDelete request.</summary>
                public BatchDeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchDeleteAccessBindingsRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The account or property that owns the access bindings. The parent of all provided values
                /// for the 'names' field in DeleteAccessBindingRequest messages must match this field. Formats: -
                /// accounts/{account} - properties/{property}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchDeleteAccessBindingsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchDelete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/accessBindings:batchDelete";

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

            /// <summary>Gets information about multiple access bindings to an account or property.</summary>
            /// <param name="parent">
            /// Required. The account or property that owns the access bindings. The parent of all provided values for
            /// the 'names' field must match this field. Formats: - accounts/{account} - properties/{property}
            /// </param>
            public virtual BatchGetRequest BatchGet(string parent)
            {
                return new BatchGetRequest(this.service, parent);
            }

            /// <summary>Gets information about multiple access bindings to an account or property.</summary>
            public class BatchGetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchGetAccessBindingsResponse>
            {
                /// <summary>Constructs a new BatchGet request.</summary>
                public BatchGetRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The account or property that owns the access bindings. The parent of all provided values
                /// for the 'names' field must match this field. Formats: - accounts/{account} - properties/{property}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Required. The names of the access bindings to retrieve. A maximum of 1000 access bindings can be
                /// retrieved in a batch. Formats: - accounts/{account}/accessBindings/{accessBinding} -
                /// properties/{property}/accessBindings/{accessBinding}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("names", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> Names { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchGet";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/accessBindings:batchGet";

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

            /// <summary>Updates information about multiple access bindings to an account or property.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The account or property that owns the access bindings. The parent of all provided
            /// AccessBinding in UpdateAccessBindingRequest messages must match this field. Formats: -
            /// accounts/{account} - properties/{property}
            /// </param>
            public virtual BatchUpdateRequest BatchUpdate(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchUpdateAccessBindingsRequest body, string parent)
            {
                return new BatchUpdateRequest(this.service, body, parent);
            }

            /// <summary>Updates information about multiple access bindings to an account or property.</summary>
            public class BatchUpdateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchUpdateAccessBindingsResponse>
            {
                /// <summary>Constructs a new BatchUpdate request.</summary>
                public BatchUpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchUpdateAccessBindingsRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The account or property that owns the access bindings. The parent of all provided
                /// AccessBinding in UpdateAccessBindingRequest messages must match this field. Formats: -
                /// accounts/{account} - properties/{property}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBatchUpdateAccessBindingsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchUpdate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/accessBindings:batchUpdate";

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

            /// <summary>Creates an access binding on an account or property.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. Formats: - accounts/{account} - properties/{property}</param>
            public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAccessBinding body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>Creates an access binding on an account or property.</summary>
            public class CreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAccessBinding>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAccessBinding body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Formats: - accounts/{account} - properties/{property}</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAccessBinding Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/accessBindings";

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

            /// <summary>Deletes an access binding on an account or property.</summary>
            /// <param name="name">
            /// Required. Formats: - accounts/{account}/accessBindings/{accessBinding} -
            /// properties/{property}/accessBindings/{accessBinding}
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>Deletes an access binding on an account or property.</summary>
            public class DeleteRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Formats: - accounts/{account}/accessBindings/{accessBinding} -
                /// properties/{property}/accessBindings/{accessBinding}
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
                        Pattern = @"^properties/[^/]+/accessBindings/[^/]+$",
                    });
                }
            }

            /// <summary>Gets information about an access binding.</summary>
            /// <param name="name">
            /// Required. The name of the access binding to retrieve. Formats: -
            /// accounts/{account}/accessBindings/{accessBinding} - properties/{property}/accessBindings/{accessBinding}
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets information about an access binding.</summary>
            public class GetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAccessBinding>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the access binding to retrieve. Formats: -
                /// accounts/{account}/accessBindings/{accessBinding} -
                /// properties/{property}/accessBindings/{accessBinding}
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
                        Pattern = @"^properties/[^/]+/accessBindings/[^/]+$",
                    });
                }
            }

            /// <summary>Lists all access bindings on an account or property.</summary>
            /// <param name="parent">Required. Formats: - accounts/{account} - properties/{property}</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists all access bindings on an account or property.</summary>
            public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaListAccessBindingsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. Formats: - accounts/{account} - properties/{property}</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of access bindings to return. The service may return fewer than this value. If
                /// unspecified, at most 200 access bindings will be returned. The maximum value is 500; values above
                /// 500 will be coerced to 500.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token, received from a previous `ListAccessBindings` call. Provide this to retrieve the
                /// subsequent page. When paginating, all other parameters provided to `ListAccessBindings` must match
                /// the call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/accessBindings";

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

            /// <summary>Updates an access binding on an account or property.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Output only. Resource name of this binding. Format: accounts/{account}/accessBindings/{access_binding}
            /// or properties/{property}/accessBindings/{access_binding} Example: "accounts/100/accessBindings/200"
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAccessBinding body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>Updates an access binding on an account or property.</summary>
            public class PatchRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAccessBinding>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAccessBinding body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Output only. Resource name of this binding. Format:
                /// accounts/{account}/accessBindings/{access_binding} or
                /// properties/{property}/accessBindings/{access_binding} Example: "accounts/100/accessBindings/200"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAccessBinding Body { get; set; }

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
                        Pattern = @"^properties/[^/]+/accessBindings/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the AdSenseLinks resource.</summary>
        public virtual AdSenseLinksResource AdSenseLinks { get; }

        /// <summary>The "adSenseLinks" collection of methods.</summary>
        public class AdSenseLinksResource
        {
            private const string Resource = "adSenseLinks";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AdSenseLinksResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates an AdSenseLink.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The property for which to create an AdSense Link. Format: properties/{propertyId} Example:
            /// properties/1234
            /// </param>
            public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAdSenseLink body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>Creates an AdSenseLink.</summary>
            public class CreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAdSenseLink>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAdSenseLink body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The property for which to create an AdSense Link. Format: properties/{propertyId} Example:
                /// properties/1234
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAdSenseLink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/adSenseLinks";

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

            /// <summary>Deletes an AdSenseLink.</summary>
            /// <param name="name">
            /// Required. Unique identifier for the AdSense Link to be deleted. Format:
            /// properties/{propertyId}/adSenseLinks/{linkId} Example: properties/1234/adSenseLinks/5678
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>Deletes an AdSenseLink.</summary>
            public class DeleteRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Unique identifier for the AdSense Link to be deleted. Format:
                /// properties/{propertyId}/adSenseLinks/{linkId} Example: properties/1234/adSenseLinks/5678
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
                        Pattern = @"^properties/[^/]+/adSenseLinks/[^/]+$",
                    });
                }
            }

            /// <summary>Looks up a single AdSenseLink.</summary>
            /// <param name="name">
            /// Required. Unique identifier for the AdSense Link requested. Format:
            /// properties/{propertyId}/adSenseLinks/{linkId} Example: properties/1234/adSenseLinks/5678
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Looks up a single AdSenseLink.</summary>
            public class GetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAdSenseLink>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Unique identifier for the AdSense Link requested. Format:
                /// properties/{propertyId}/adSenseLinks/{linkId} Example: properties/1234/adSenseLinks/5678
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
                        Pattern = @"^properties/[^/]+/adSenseLinks/[^/]+$",
                    });
                }
            }

            /// <summary>Lists AdSenseLinks on a property.</summary>
            /// <param name="parent">
            /// Required. Resource name of the parent property. Format: properties/{propertyId} Example: properties/1234
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists AdSenseLinks on a property.</summary>
            public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaListAdSenseLinksResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the parent property. Format: properties/{propertyId} Example:
                /// properties/1234
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of resources to return. If unspecified, at most 50 resources will be returned.
                /// The maximum value is 200 (higher values will be coerced to the maximum).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token received from a previous `ListAdSenseLinks` call. Provide this to retrieve the
                /// subsequent page. When paginating, all other parameters provided to `ListAdSenseLinks` must match the
                /// call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/adSenseLinks";

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
                return new ArchiveRequest(this.service, body, name);
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
                return new CreateRequest(this.service, body, parent);
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

            /// <summary>
            /// Lookup for a single Audience. Audiences created before 2020 may not be supported. Default audiences will
            /// not show filter definitions.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the Audience to get. Example format: properties/1234/audiences/5678
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>
            /// Lookup for a single Audience. Audiences created before 2020 may not be supported. Default audiences will
            /// not show filter definitions.
            /// </summary>
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

            /// <summary>
            /// Lists Audiences on a property. Audiences created before 2020 may not be supported. Default audiences
            /// will not show filter definitions.
            /// </summary>
            /// <param name="parent">Required. Example format: properties/1234</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>
            /// Lists Audiences on a property. Audiences created before 2020 may not be supported. Default audiences
            /// will not show filter definitions.
            /// </summary>
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
                return new PatchRequest(this.service, body, name);
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

        /// <summary>Gets the BigQueryLinks resource.</summary>
        public virtual BigQueryLinksResource BigQueryLinks { get; }

        /// <summary>The "bigQueryLinks" collection of methods.</summary>
        public class BigQueryLinksResource
        {
            private const string Resource = "bigQueryLinks";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public BigQueryLinksResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a BigQueryLink.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. Example format: properties/1234</param>
            public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBigQueryLink body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>Creates a BigQueryLink.</summary>
            public class CreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBigQueryLink>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBigQueryLink body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Example format: properties/1234</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBigQueryLink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/bigQueryLinks";

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

            /// <summary>Deletes a BigQueryLink on a property.</summary>
            /// <param name="name">
            /// Required. The BigQueryLink to delete. Example format: properties/1234/bigQueryLinks/5678
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>Deletes a BigQueryLink on a property.</summary>
            public class DeleteRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The BigQueryLink to delete. Example format: properties/1234/bigQueryLinks/5678
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
                        Pattern = @"^properties/[^/]+/bigQueryLinks/[^/]+$",
                    });
                }
            }

            /// <summary>Lookup for a single BigQuery Link.</summary>
            /// <param name="name">
            /// Required. The name of the BigQuery link to lookup. Format:
            /// properties/{property_id}/bigQueryLinks/{bigquery_link_id} Example: properties/123/bigQueryLinks/456
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Lookup for a single BigQuery Link.</summary>
            public class GetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBigQueryLink>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the BigQuery link to lookup. Format:
                /// properties/{property_id}/bigQueryLinks/{bigquery_link_id} Example: properties/123/bigQueryLinks/456
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
                        Pattern = @"^properties/[^/]+/bigQueryLinks/[^/]+$",
                    });
                }
            }

            /// <summary>Lists BigQuery Links on a property.</summary>
            /// <param name="parent">
            /// Required. The name of the property to list BigQuery links under. Format: properties/{property_id}
            /// Example: properties/1234
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists BigQuery Links on a property.</summary>
            public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaListBigQueryLinksResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the property to list BigQuery links under. Format: properties/{property_id}
                /// Example: properties/1234
                /// </summary>
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
                /// A page token, received from a previous `ListBigQueryLinks` call. Provide this to retrieve the
                /// subsequent page. When paginating, all other parameters provided to `ListBigQueryLinks` must match
                /// the call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/bigQueryLinks";

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

            /// <summary>Updates a BigQueryLink.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Output only. Resource name of this BigQuery link. Format:
            /// 'properties/{property_id}/bigQueryLinks/{bigquery_link_id}' Format:
            /// 'properties/1234/bigQueryLinks/abc567'
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBigQueryLink body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>Updates a BigQueryLink.</summary>
            public class PatchRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBigQueryLink>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBigQueryLink body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Output only. Resource name of this BigQuery link. Format:
                /// 'properties/{property_id}/bigQueryLinks/{bigquery_link_id}' Format:
                /// 'properties/1234/bigQueryLinks/abc567'
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
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaBigQueryLink Body { get; set; }

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
                        Pattern = @"^properties/[^/]+/bigQueryLinks/[^/]+$",
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

        /// <summary>Gets the CalculatedMetrics resource.</summary>
        public virtual CalculatedMetricsResource CalculatedMetrics { get; }

        /// <summary>The "calculatedMetrics" collection of methods.</summary>
        public class CalculatedMetricsResource
        {
            private const string Resource = "calculatedMetrics";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public CalculatedMetricsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a CalculatedMetric.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. Format: properties/{property_id} Example: properties/1234</param>
            public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaCalculatedMetric body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>Creates a CalculatedMetric.</summary>
            public class CreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaCalculatedMetric>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaCalculatedMetric body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Format: properties/{property_id} Example: properties/1234</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Required. The ID to use for the calculated metric which will become the final component of the
                /// calculated metric's resource name. This value should be 1-80 characters and valid characters are
                /// /[a-zA-Z0-9_]/, no spaces allowed. calculated_metric_id must be unique between all calculated
                /// metrics under a property. The calculated_metric_id is used when referencing this calculated metric
                /// from external APIs, for example, "calcMetric:{calculated_metric_id}".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("calculatedMetricId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string CalculatedMetricId { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaCalculatedMetric Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/calculatedMetrics";

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
                    RequestParameters.Add("calculatedMetricId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "calculatedMetricId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Deletes a CalculatedMetric on a property.</summary>
            /// <param name="name">
            /// Required. The name of the CalculatedMetric to delete. Format:
            /// properties/{property_id}/calculatedMetrics/{calculated_metric_id} Example:
            /// properties/1234/calculatedMetrics/Metric01
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>Deletes a CalculatedMetric on a property.</summary>
            public class DeleteRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the CalculatedMetric to delete. Format:
                /// properties/{property_id}/calculatedMetrics/{calculated_metric_id} Example:
                /// properties/1234/calculatedMetrics/Metric01
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
                        Pattern = @"^properties/[^/]+/calculatedMetrics/[^/]+$",
                    });
                }
            }

            /// <summary>Lookup for a single CalculatedMetric.</summary>
            /// <param name="name">
            /// Required. The name of the CalculatedMetric to get. Format:
            /// properties/{property_id}/calculatedMetrics/{calculated_metric_id} Example:
            /// properties/1234/calculatedMetrics/Metric01
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Lookup for a single CalculatedMetric.</summary>
            public class GetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaCalculatedMetric>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the CalculatedMetric to get. Format:
                /// properties/{property_id}/calculatedMetrics/{calculated_metric_id} Example:
                /// properties/1234/calculatedMetrics/Metric01
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
                        Pattern = @"^properties/[^/]+/calculatedMetrics/[^/]+$",
                    });
                }
            }

            /// <summary>Lists CalculatedMetrics on a property.</summary>
            /// <param name="parent">Required. Example format: properties/1234</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists CalculatedMetrics on a property.</summary>
            public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaListCalculatedMetricsResponse>
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
                /// Optional. The maximum number of resources to return. If unspecified, at most 50 resources will be
                /// returned. The maximum value is 200 (higher values will be coerced to the maximum).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A page token, received from a previous `ListCalculatedMetrics` call. Provide this to
                /// retrieve the subsequent page. When paginating, all other parameters provided to
                /// `ListCalculatedMetrics` must match the call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/calculatedMetrics";

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

            /// <summary>Updates a CalculatedMetric on a property.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Output only. Resource name for this CalculatedMetric. Format:
            /// 'properties/{property_id}/calculatedMetrics/{calculated_metric_id}'
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaCalculatedMetric body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>Updates a CalculatedMetric on a property.</summary>
            public class PatchRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaCalculatedMetric>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaCalculatedMetric body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Output only. Resource name for this CalculatedMetric. Format:
                /// 'properties/{property_id}/calculatedMetrics/{calculated_metric_id}'
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
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaCalculatedMetric Body { get; set; }

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
                        Pattern = @"^properties/[^/]+/calculatedMetrics/[^/]+$",
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

        /// <summary>Gets the ChannelGroups resource.</summary>
        public virtual ChannelGroupsResource ChannelGroups { get; }

        /// <summary>The "channelGroups" collection of methods.</summary>
        public class ChannelGroupsResource
        {
            private const string Resource = "channelGroups";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ChannelGroupsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a ChannelGroup.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The property for which to create a ChannelGroup. Example format: properties/1234
            /// </param>
            public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaChannelGroup body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>Creates a ChannelGroup.</summary>
            public class CreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaChannelGroup>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaChannelGroup body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The property for which to create a ChannelGroup. Example format: properties/1234
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaChannelGroup Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/channelGroups";

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

            /// <summary>Deletes a ChannelGroup on a property.</summary>
            /// <param name="name">
            /// Required. The ChannelGroup to delete. Example format: properties/1234/channelGroups/5678
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>Deletes a ChannelGroup on a property.</summary>
            public class DeleteRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The ChannelGroup to delete. Example format: properties/1234/channelGroups/5678
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
                        Pattern = @"^properties/[^/]+/channelGroups/[^/]+$",
                    });
                }
            }

            /// <summary>Lookup for a single ChannelGroup.</summary>
            /// <param name="name">
            /// Required. The ChannelGroup to get. Example format: properties/1234/channelGroups/5678
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Lookup for a single ChannelGroup.</summary>
            public class GetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaChannelGroup>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The ChannelGroup to get. Example format: properties/1234/channelGroups/5678
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
                        Pattern = @"^properties/[^/]+/channelGroups/[^/]+$",
                    });
                }
            }

            /// <summary>Lists ChannelGroups on a property.</summary>
            /// <param name="parent">
            /// Required. The property for which to list ChannelGroups. Example format: properties/1234
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists ChannelGroups on a property.</summary>
            public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaListChannelGroupsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The property for which to list ChannelGroups. Example format: properties/1234
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of resources to return. If unspecified, at most 50 resources will be returned.
                /// The maximum value is 200 (higher values will be coerced to the maximum).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token, received from a previous `ListChannelGroups` call. Provide this to retrieve the
                /// subsequent page. When paginating, all other parameters provided to `ListChannelGroups` must match
                /// the call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/channelGroups";

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

            /// <summary>Updates a ChannelGroup.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Output only. The resource name for this Channel Group resource. Format:
            /// properties/{property}/channelGroups/{channel_group}
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaChannelGroup body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>Updates a ChannelGroup.</summary>
            public class PatchRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaChannelGroup>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaChannelGroup body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Output only. The resource name for this Channel Group resource. Format:
                /// properties/{property}/channelGroups/{channel_group}
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
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaChannelGroup Body { get; set; }

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
                        Pattern = @"^properties/[^/]+/channelGroups/[^/]+$",
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

            /// <summary>
            /// Deprecated: Use `CreateKeyEvent` instead. Creates a conversion event with the specified attributes.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The resource name of the parent property where this conversion event will be created. Format:
            /// properties/123
            /// </param>
            public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaConversionEvent body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Deprecated: Use `CreateKeyEvent` instead. Creates a conversion event with the specified attributes.
            /// </summary>
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

            /// <summary>
            /// Deprecated: Use `UpdateKeyEvent` instead. Updates a conversion event with the specified attributes.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Output only. Resource name of this conversion event. Format:
            /// properties/{property}/conversionEvents/{conversion_event}
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaConversionEvent body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>
            /// Deprecated: Use `UpdateKeyEvent` instead. Updates a conversion event with the specified attributes.
            /// </summary>
            public class PatchRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaConversionEvent>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaConversionEvent body, string name) : base(service)
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
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaConversionEvent Body { get; set; }

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
            public virtual ArchiveRequest Archive(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaArchiveCustomDimensionRequest body, string name)
            {
                return new ArchiveRequest(this.service, body, name);
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
                return new CreateRequest(this.service, body, parent);
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
                return new GetRequest(this.service, name);
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
                return new ListRequest(this.service, parent);
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
                return new PatchRequest(this.service, body, name);
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
                return new ArchiveRequest(this.service, body, name);
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
                return new CreateRequest(this.service, body, parent);
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
                return new GetRequest(this.service, name);
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
                return new ListRequest(this.service, parent);
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
                return new PatchRequest(this.service, body, name);
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
                EventCreateRules = new EventCreateRulesResource(service);
                EventEditRules = new EventEditRulesResource(service);
                MeasurementProtocolSecrets = new MeasurementProtocolSecretsResource(service);
                SKAdNetworkConversionValueSchema = new SKAdNetworkConversionValueSchemaResource(service);
            }

            /// <summary>Gets the EventCreateRules resource.</summary>
            public virtual EventCreateRulesResource EventCreateRules { get; }

            /// <summary>The "eventCreateRules" collection of methods.</summary>
            public class EventCreateRulesResource
            {
                private const string Resource = "eventCreateRules";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public EventCreateRulesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates an EventCreateRule.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. Example format: properties/123/dataStreams/456</param>
                public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaEventCreateRule body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates an EventCreateRule.</summary>
                public class CreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaEventCreateRule>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaEventCreateRule body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Example format: properties/123/dataStreams/456</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaEventCreateRule Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/eventCreateRules";

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

                /// <summary>Deletes an EventCreateRule.</summary>
                /// <param name="name">
                /// Required. Example format: properties/123/dataStreams/456/eventCreateRules/789
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes an EventCreateRule.</summary>
                public class DeleteRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Example format: properties/123/dataStreams/456/eventCreateRules/789</summary>
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
                            Pattern = @"^properties/[^/]+/dataStreams/[^/]+/eventCreateRules/[^/]+$",
                        });
                    }
                }

                /// <summary>Lookup for a single EventCreateRule.</summary>
                /// <param name="name">
                /// Required. The name of the EventCreateRule to get. Example format:
                /// properties/123/dataStreams/456/eventCreateRules/789
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Lookup for a single EventCreateRule.</summary>
                public class GetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaEventCreateRule>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the EventCreateRule to get. Example format:
                    /// properties/123/dataStreams/456/eventCreateRules/789
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
                            Pattern = @"^properties/[^/]+/dataStreams/[^/]+/eventCreateRules/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists EventCreateRules on a web data stream.</summary>
                /// <param name="parent">Required. Example format: properties/123/dataStreams/456</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists EventCreateRules on a web data stream.</summary>
                public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaListEventCreateRulesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Example format: properties/123/dataStreams/456</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of resources to return. If unspecified, at most 50 resources will be
                    /// returned. The maximum value is 200 (higher values will be coerced to the maximum).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `ListEventCreateRules` call. Provide this to retrieve the
                    /// subsequent page. When paginating, all other parameters provided to `ListEventCreateRules` must
                    /// match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/eventCreateRules";

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

                /// <summary>Updates an EventCreateRule.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. Resource name for this EventCreateRule resource. Format:
                /// properties/{property}/dataStreams/{data_stream}/eventCreateRules/{event_create_rule}
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaEventCreateRule body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates an EventCreateRule.</summary>
                public class PatchRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaEventCreateRule>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaEventCreateRule body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. Resource name for this EventCreateRule resource. Format:
                    /// properties/{property}/dataStreams/{data_stream}/eventCreateRules/{event_create_rule}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. The list of fields to be updated. Field names must be in snake case (e.g.,
                    /// "field_to_update"). Omitted fields will not be updated. To replace the entire entity, use one
                    /// path with the string "*" to match all fields.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaEventCreateRule Body { get; set; }

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
                            Pattern = @"^properties/[^/]+/dataStreams/[^/]+/eventCreateRules/[^/]+$",
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

            /// <summary>Gets the EventEditRules resource.</summary>
            public virtual EventEditRulesResource EventEditRules { get; }

            /// <summary>The "eventEditRules" collection of methods.</summary>
            public class EventEditRulesResource
            {
                private const string Resource = "eventEditRules";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public EventEditRulesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates an EventEditRule.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. Example format: properties/123/dataStreams/456</param>
                public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaEventEditRule body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates an EventEditRule.</summary>
                public class CreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaEventEditRule>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaEventEditRule body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Example format: properties/123/dataStreams/456</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaEventEditRule Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/eventEditRules";

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

                /// <summary>Deletes an EventEditRule.</summary>
                /// <param name="name">
                /// Required. Example format: properties/123/dataStreams/456/eventEditRules/789
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes an EventEditRule.</summary>
                public class DeleteRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Example format: properties/123/dataStreams/456/eventEditRules/789</summary>
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
                            Pattern = @"^properties/[^/]+/dataStreams/[^/]+/eventEditRules/[^/]+$",
                        });
                    }
                }

                /// <summary>Lookup for a single EventEditRule.</summary>
                /// <param name="name">
                /// Required. The name of the EventEditRule to get. Example format:
                /// properties/123/dataStreams/456/eventEditRules/789
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Lookup for a single EventEditRule.</summary>
                public class GetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaEventEditRule>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the EventEditRule to get. Example format:
                    /// properties/123/dataStreams/456/eventEditRules/789
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
                            Pattern = @"^properties/[^/]+/dataStreams/[^/]+/eventEditRules/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists EventEditRules on a web data stream.</summary>
                /// <param name="parent">Required. Example format: properties/123/dataStreams/456</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists EventEditRules on a web data stream.</summary>
                public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaListEventEditRulesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Example format: properties/123/dataStreams/456</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The maximum number of resources to return. If unspecified, at most 50 resources will
                    /// be returned. The maximum value is 200 (higher values will be coerced to the maximum).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `ListEventEditRules` call. Provide this to
                    /// retrieve the subsequent page. When paginating, all other parameters provided to
                    /// `ListEventEditRules` must match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/eventEditRules";

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

                /// <summary>Updates an EventEditRule.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. Resource name for this EventEditRule resource. Format:
                /// properties/{property}/dataStreams/{data_stream}/eventEditRules/{event_edit_rule}
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaEventEditRule body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates an EventEditRule.</summary>
                public class PatchRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaEventEditRule>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaEventEditRule body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. Resource name for this EventEditRule resource. Format:
                    /// properties/{property}/dataStreams/{data_stream}/eventEditRules/{event_edit_rule}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. The list of fields to be updated. Field names must be in snake case (e.g.,
                    /// "field_to_update"). Omitted fields will not be updated. To replace the entire entity, use one
                    /// path with the string "*" to match all fields.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaEventEditRule Body { get; set; }

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
                            Pattern = @"^properties/[^/]+/dataStreams/[^/]+/eventEditRules/[^/]+$",
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

                /// <summary>Changes the processing order of event edit rules on the specified stream.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. Example format: properties/123/dataStreams/456</param>
                public virtual ReorderRequest Reorder(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaReorderEventEditRulesRequest body, string parent)
                {
                    return new ReorderRequest(this.service, body, parent);
                }

                /// <summary>Changes the processing order of event edit rules on the specified stream.</summary>
                public class ReorderRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Reorder request.</summary>
                    public ReorderRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaReorderEventEditRulesRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Example format: properties/123/dataStreams/456</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaReorderEventEditRulesRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "reorder";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/eventEditRules:reorder";

                    /// <summary>Initializes Reorder parameter list.</summary>
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
                    return new CreateRequest(this.service, body, parent);
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
                    return new DeleteRequest(this.service, name);
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
                    return new ListRequest(this.service, parent);
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
                    return new PatchRequest(this.service, body, name);
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

                    /// <summary>
                    /// Required. The list of fields to be updated. Omitted fields will not be updated.
                    /// </summary>
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

            /// <summary>Gets the SKAdNetworkConversionValueSchema resource.</summary>
            public virtual SKAdNetworkConversionValueSchemaResource SKAdNetworkConversionValueSchema { get; }

            /// <summary>The "sKAdNetworkConversionValueSchema" collection of methods.</summary>
            public class SKAdNetworkConversionValueSchemaResource
            {
                private const string Resource = "sKAdNetworkConversionValueSchema";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public SKAdNetworkConversionValueSchemaResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a SKAdNetworkConversionValueSchema.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource where this schema will be created. Format:
                /// properties/{property}/dataStreams/{dataStream}
                /// </param>
                public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSKAdNetworkConversionValueSchema body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a SKAdNetworkConversionValueSchema.</summary>
                public class CreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSKAdNetworkConversionValueSchema>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSKAdNetworkConversionValueSchema body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource where this schema will be created. Format:
                    /// properties/{property}/dataStreams/{dataStream}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSKAdNetworkConversionValueSchema Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/sKAdNetworkConversionValueSchema";

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

                /// <summary>Deletes target SKAdNetworkConversionValueSchema.</summary>
                /// <param name="name">
                /// Required. The name of the SKAdNetworkConversionValueSchema to delete. Format:
                /// properties/{property}/dataStreams/{dataStream}/sKAdNetworkConversionValueSchema/{skadnetwork_conversion_value_schema}
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes target SKAdNetworkConversionValueSchema.</summary>
                public class DeleteRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the SKAdNetworkConversionValueSchema to delete. Format:
                    /// properties/{property}/dataStreams/{dataStream}/sKAdNetworkConversionValueSchema/{skadnetwork_conversion_value_schema}
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
                            Pattern = @"^properties/[^/]+/dataStreams/[^/]+/sKAdNetworkConversionValueSchema/[^/]+$",
                        });
                    }
                }

                /// <summary>Looks up a single SKAdNetworkConversionValueSchema.</summary>
                /// <param name="name">
                /// Required. The resource name of SKAdNetwork conversion value schema to look up. Format:
                /// properties/{property}/dataStreams/{dataStream}/sKAdNetworkConversionValueSchema/{skadnetwork_conversion_value_schema}
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Looks up a single SKAdNetworkConversionValueSchema.</summary>
                public class GetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSKAdNetworkConversionValueSchema>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of SKAdNetwork conversion value schema to look up. Format:
                    /// properties/{property}/dataStreams/{dataStream}/sKAdNetworkConversionValueSchema/{skadnetwork_conversion_value_schema}
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
                            Pattern = @"^properties/[^/]+/dataStreams/[^/]+/sKAdNetworkConversionValueSchema/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists SKAdNetworkConversionValueSchema on a stream. Properties can have at most one
                /// SKAdNetworkConversionValueSchema.
                /// </summary>
                /// <param name="parent">
                /// Required. The DataStream resource to list schemas for. Format:
                /// properties/{property_id}/dataStreams/{dataStream} Example: properties/1234/dataStreams/5678
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// Lists SKAdNetworkConversionValueSchema on a stream. Properties can have at most one
                /// SKAdNetworkConversionValueSchema.
                /// </summary>
                public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaListSKAdNetworkConversionValueSchemasResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The DataStream resource to list schemas for. Format:
                    /// properties/{property_id}/dataStreams/{dataStream} Example: properties/1234/dataStreams/5678
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of resources to return. The service may return fewer than this value, even if
                    /// there are additional pages. If unspecified, at most 50 resources will be returned. The maximum
                    /// value is 200; (higher values will be coerced to the maximum)
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `ListSKAdNetworkConversionValueSchemas` call. Provide
                    /// this to retrieve the subsequent page. When paginating, all other parameters provided to
                    /// `ListSKAdNetworkConversionValueSchema` must match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/sKAdNetworkConversionValueSchema";

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

                /// <summary>Updates a SKAdNetworkConversionValueSchema.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. Resource name of the schema. This will be child of ONLY an iOS stream, and there can be
                /// at most one such child under an iOS stream. Format:
                /// properties/{property}/dataStreams/{dataStream}/sKAdNetworkConversionValueSchema
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSKAdNetworkConversionValueSchema body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates a SKAdNetworkConversionValueSchema.</summary>
                public class PatchRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSKAdNetworkConversionValueSchema>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSKAdNetworkConversionValueSchema body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. Resource name of the schema. This will be child of ONLY an iOS stream, and there
                    /// can be at most one such child under an iOS stream. Format:
                    /// properties/{property}/dataStreams/{dataStream}/sKAdNetworkConversionValueSchema
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. The list of fields to be updated. Omitted fields will not be updated.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSKAdNetworkConversionValueSchema Body { get; set; }

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
                            Pattern = @"^properties/[^/]+/dataStreams/[^/]+/sKAdNetworkConversionValueSchema/[^/]+$",
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
                return new CreateRequest(this.service, body, parent);
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
                return new DeleteRequest(this.service, name);
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
                return new GetRequest(this.service, name);
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

            /// <summary>Lookup for a single DataRedactionSettings.</summary>
            /// <param name="name">
            /// Required. The name of the settings to lookup. Format:
            /// properties/{property}/dataStreams/{data_stream}/dataRedactionSettings Example:
            /// "properties/1000/dataStreams/2000/dataRedactionSettings"
            /// </param>
            public virtual GetDataRedactionSettingsRequest GetDataRedactionSettings(string name)
            {
                return new GetDataRedactionSettingsRequest(this.service, name);
            }

            /// <summary>Lookup for a single DataRedactionSettings.</summary>
            public class GetDataRedactionSettingsRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaDataRedactionSettings>
            {
                /// <summary>Constructs a new GetDataRedactionSettings request.</summary>
                public GetDataRedactionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the settings to lookup. Format:
                /// properties/{property}/dataStreams/{data_stream}/dataRedactionSettings Example:
                /// "properties/1000/dataStreams/2000/dataRedactionSettings"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getDataRedactionSettings";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}";

                /// <summary>Initializes GetDataRedactionSettings parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^properties/[^/]+/dataStreams/[^/]+/dataRedactionSettings$",
                    });
                }
            }

            /// <summary>
            /// Returns the enhanced measurement settings for this data stream. Note that the stream must enable
            /// enhanced measurement for these settings to take effect.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the settings to lookup. Format:
            /// properties/{property}/dataStreams/{data_stream}/enhancedMeasurementSettings Example:
            /// "properties/1000/dataStreams/2000/enhancedMeasurementSettings"
            /// </param>
            public virtual GetEnhancedMeasurementSettingsRequest GetEnhancedMeasurementSettings(string name)
            {
                return new GetEnhancedMeasurementSettingsRequest(this.service, name);
            }

            /// <summary>
            /// Returns the enhanced measurement settings for this data stream. Note that the stream must enable
            /// enhanced measurement for these settings to take effect.
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
                /// properties/{property}/dataStreams/{data_stream}/enhancedMeasurementSettings Example:
                /// "properties/1000/dataStreams/2000/enhancedMeasurementSettings"
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
                        Pattern = @"^properties/[^/]+/dataStreams/[^/]+/enhancedMeasurementSettings$",
                    });
                }
            }

            /// <summary>
            /// Returns the Site Tag for the specified web stream. Site Tags are immutable singletons.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the site tag to lookup. Note that site tags are singletons and do not have unique
            /// IDs. Format: properties/{property_id}/dataStreams/{stream_id}/globalSiteTag Example:
            /// `properties/123/dataStreams/456/globalSiteTag`
            /// </param>
            public virtual GetGlobalSiteTagRequest GetGlobalSiteTag(string name)
            {
                return new GetGlobalSiteTagRequest(this.service, name);
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
                /// `properties/123/dataStreams/456/globalSiteTag`
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
                return new ListRequest(this.service, parent);
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
                return new PatchRequest(this.service, body, name);
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

            /// <summary>Updates a DataRedactionSettings on a property.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Output only. Name of this Data Redaction Settings resource. Format:
            /// properties/{property_id}/dataStreams/{data_stream}/dataRedactionSettings Example:
            /// "properties/1000/dataStreams/2000/dataRedactionSettings"
            /// </param>
            public virtual UpdateDataRedactionSettingsRequest UpdateDataRedactionSettings(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaDataRedactionSettings body, string name)
            {
                return new UpdateDataRedactionSettingsRequest(this.service, body, name);
            }

            /// <summary>Updates a DataRedactionSettings on a property.</summary>
            public class UpdateDataRedactionSettingsRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaDataRedactionSettings>
            {
                /// <summary>Constructs a new UpdateDataRedactionSettings request.</summary>
                public UpdateDataRedactionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaDataRedactionSettings body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Output only. Name of this Data Redaction Settings resource. Format:
                /// properties/{property_id}/dataStreams/{data_stream}/dataRedactionSettings Example:
                /// "properties/1000/dataStreams/2000/dataRedactionSettings"
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
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaDataRedactionSettings Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "updateDataRedactionSettings";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}";

                /// <summary>Initializes UpdateDataRedactionSettings parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^properties/[^/]+/dataStreams/[^/]+/dataRedactionSettings$",
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
            /// Updates the enhanced measurement settings for this data stream. Note that the stream must enable
            /// enhanced measurement for these settings to take effect.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Output only. Resource name of the Enhanced Measurement Settings. Format:
            /// properties/{property_id}/dataStreams/{data_stream}/enhancedMeasurementSettings Example:
            /// "properties/1000/dataStreams/2000/enhancedMeasurementSettings"
            /// </param>
            public virtual UpdateEnhancedMeasurementSettingsRequest UpdateEnhancedMeasurementSettings(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaEnhancedMeasurementSettings body, string name)
            {
                return new UpdateEnhancedMeasurementSettingsRequest(this.service, body, name);
            }

            /// <summary>
            /// Updates the enhanced measurement settings for this data stream. Note that the stream must enable
            /// enhanced measurement for these settings to take effect.
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
                /// Output only. Resource name of the Enhanced Measurement Settings. Format:
                /// properties/{property_id}/dataStreams/{data_stream}/enhancedMeasurementSettings Example:
                /// "properties/1000/dataStreams/2000/enhancedMeasurementSettings"
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
                        Pattern = @"^properties/[^/]+/dataStreams/[^/]+/enhancedMeasurementSettings$",
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
                return new ApproveRequest(this.service, body, name);
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
                return new CancelRequest(this.service, body, name);
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
                return new CreateRequest(this.service, body, parent);
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
                return new DeleteRequest(this.service, name);
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
                return new GetRequest(this.service, name);
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
                return new ListRequest(this.service, parent);
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
                return new CreateRequest(this.service, body, parent);
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
                return new DeleteRequest(this.service, name);
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
                return new GetRequest(this.service, name);
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
                return new ListRequest(this.service, parent);
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
                return new PatchRequest(this.service, body, name);
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

        /// <summary>Gets the ExpandedDataSets resource.</summary>
        public virtual ExpandedDataSetsResource ExpandedDataSets { get; }

        /// <summary>The "expandedDataSets" collection of methods.</summary>
        public class ExpandedDataSetsResource
        {
            private const string Resource = "expandedDataSets";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ExpandedDataSetsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a ExpandedDataSet.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. Example format: properties/1234</param>
            public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaExpandedDataSet body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>Creates a ExpandedDataSet.</summary>
            public class CreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaExpandedDataSet>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaExpandedDataSet body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Example format: properties/1234</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaExpandedDataSet Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/expandedDataSets";

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

            /// <summary>Deletes a ExpandedDataSet on a property.</summary>
            /// <param name="name">Required. Example format: properties/1234/expandedDataSets/5678</param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>Deletes a ExpandedDataSet on a property.</summary>
            public class DeleteRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. Example format: properties/1234/expandedDataSets/5678</summary>
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
                        Pattern = @"^properties/[^/]+/expandedDataSets/[^/]+$",
                    });
                }
            }

            /// <summary>Lookup for a single ExpandedDataSet.</summary>
            /// <param name="name">
            /// Required. The name of the ExpandedDataSet to get. Example format: properties/1234/expandedDataSets/5678
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Lookup for a single ExpandedDataSet.</summary>
            public class GetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaExpandedDataSet>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the ExpandedDataSet to get. Example format:
                /// properties/1234/expandedDataSets/5678
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
                        Pattern = @"^properties/[^/]+/expandedDataSets/[^/]+$",
                    });
                }
            }

            /// <summary>Lists ExpandedDataSets on a property.</summary>
            /// <param name="parent">Required. Example format: properties/1234</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists ExpandedDataSets on a property.</summary>
            public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaListExpandedDataSetsResponse>
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
                /// A page token, received from a previous `ListExpandedDataSets` call. Provide this to retrieve the
                /// subsequent page. When paginating, all other parameters provided to `ListExpandedDataSet` must match
                /// the call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/expandedDataSets";

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

            /// <summary>Updates a ExpandedDataSet on a property.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Output only. The resource name for this ExpandedDataSet resource. Format:
            /// properties/{property_id}/expandedDataSets/{expanded_data_set}
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaExpandedDataSet body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>Updates a ExpandedDataSet on a property.</summary>
            public class PatchRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaExpandedDataSet>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaExpandedDataSet body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Output only. The resource name for this ExpandedDataSet resource. Format:
                /// properties/{property_id}/expandedDataSets/{expanded_data_set}
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
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaExpandedDataSet Body { get; set; }

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
                        Pattern = @"^properties/[^/]+/expandedDataSets/[^/]+$",
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
            public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaFirebaseLink body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
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

                /// <summary>Required. Format: properties/{property_id} Example: `properties/1234`</summary>
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
            /// `properties/1234/firebaseLinks/5678`
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
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
                /// `properties/1234/firebaseLinks/5678`
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
            /// <param name="parent">Required. Format: properties/{property_id} Example: `properties/1234`</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
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
                return new CreateRequest(this.service, body, parent);
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
                return new DeleteRequest(this.service, name);
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
                return new ListRequest(this.service, parent);
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
                return new PatchRequest(this.service, body, name);
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
            public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaKeyEvent body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>Creates a Key Event.</summary>
            public class CreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaKeyEvent>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaKeyEvent body, string parent) : base(service)
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
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaKeyEvent Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/keyEvents";

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
            public class DeleteRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleProtobufEmpty>
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
            public class GetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaKeyEvent>
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
            public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaListKeyEventsResponse>
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
                public override string RestPath => "v1alpha/{+parent}/keyEvents";

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
            public virtual PatchRequest Patch(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaKeyEvent body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>Updates a Key Event.</summary>
            public class PatchRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaKeyEvent>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaKeyEvent body, string name) : base(service)
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
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaKeyEvent Body { get; set; }

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

        /// <summary>Gets the ReportingDataAnnotations resource.</summary>
        public virtual ReportingDataAnnotationsResource ReportingDataAnnotations { get; }

        /// <summary>The "reportingDataAnnotations" collection of methods.</summary>
        public class ReportingDataAnnotationsResource
        {
            private const string Resource = "reportingDataAnnotations";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ReportingDataAnnotationsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a Reporting Data Annotation.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The property for which to create a Reporting Data Annotation. Format: properties/property_id
            /// Example: properties/123
            /// </param>
            public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaReportingDataAnnotation body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>Creates a Reporting Data Annotation.</summary>
            public class CreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaReportingDataAnnotation>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaReportingDataAnnotation body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The property for which to create a Reporting Data Annotation. Format:
                /// properties/property_id Example: properties/123
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaReportingDataAnnotation Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/reportingDataAnnotations";

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

            /// <summary>Deletes a Reporting Data Annotation.</summary>
            /// <param name="name">
            /// Required. Resource name of the Reporting Data Annotation to delete. Format:
            /// properties/property_id/reportingDataAnnotations/reporting_data_annotation Example:
            /// properties/123/reportingDataAnnotations/456
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>Deletes a Reporting Data Annotation.</summary>
            public class DeleteRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the Reporting Data Annotation to delete. Format:
                /// properties/property_id/reportingDataAnnotations/reporting_data_annotation Example:
                /// properties/123/reportingDataAnnotations/456
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
                        Pattern = @"^properties/[^/]+/reportingDataAnnotations/[^/]+$",
                    });
                }
            }

            /// <summary>Lookup a single Reporting Data Annotation.</summary>
            /// <param name="name">
            /// Required. Resource name of the Reporting Data Annotation to lookup. Format:
            /// properties/property_id/reportingDataAnnotations/reportingDataAnnotation Example:
            /// properties/123/reportingDataAnnotations/456
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Lookup a single Reporting Data Annotation.</summary>
            public class GetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaReportingDataAnnotation>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the Reporting Data Annotation to lookup. Format:
                /// properties/property_id/reportingDataAnnotations/reportingDataAnnotation Example:
                /// properties/123/reportingDataAnnotations/456
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
                        Pattern = @"^properties/[^/]+/reportingDataAnnotations/[^/]+$",
                    });
                }
            }

            /// <summary>List all Reporting Data Annotations on a property.</summary>
            /// <param name="parent">
            /// Required. Resource name of the property. Format: properties/property_id Example: properties/123
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>List all Reporting Data Annotations on a property.</summary>
            public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaListReportingDataAnnotationsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the property. Format: properties/property_id Example: properties/123
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. Filter that restricts which reporting data annotations under the parent property are
                /// listed. Supported fields are: * 'name' * `title` * `description` * `annotation_date` *
                /// `annotation_date_range` * `color` Additionally, this API provides the following helper functions: *
                /// annotation_duration() : the duration that this annotation marks,
                /// [durations](https://github.com/protocolbuffers/protobuf/blob/main/src/google/protobuf/duration.proto).
                /// expect a numeric representation of seconds followed by an `s` suffix. *
                /// is_annotation_in_range(start_date, end_date) : if the annotation is in the range specified by the
                /// `start_date` and `end_date`. The dates are in ISO-8601 format, for example `2031-06-28`. Supported
                /// operations: * `=` : equals * `!=` : not equals * `&amp;lt;` : less than * `&amp;gt;` : greater than
                /// * `&amp;lt;=` : less than or equals * `&amp;gt;=` : greater than or equals * `:` : has operator *
                /// `=~` : [regular expression](https://github.com/google/re2/wiki/Syntax) match * `!~` : [regular
                /// expression](https://github.com/google/re2/wiki/Syntax) does not match * `NOT` : Logical not * `AND`
                /// : Logical and * `OR` : Logical or Examples: 1. `title="Holiday Sale"` 2. `description=~"[Bb]ig
                /// [Gg]ame.*[Ss]ale"` 3. `is_annotation_in_range("2025-12-25", "2026-01-16") = true` 4.
                /// `annotation_duration() &amp;gt;= 172800s AND title:BOGO`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Optional. The maximum number of resources to return. The service may return fewer than this value,
                /// even if there are additional pages. If unspecified, at most 50 resources will be returned. The
                /// maximum value is 200; (higher values will be coerced to the maximum)
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A page token, received from a previous `ListReportingDataAnnotations` call. Provide this
                /// to retrieve the subsequent page. When paginating, all other parameters provided to
                /// `ListReportingDataAnnotations` must match the call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/reportingDataAnnotations";

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

            /// <summary>Updates a Reporting Data Annotation.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Identifier. Resource name of this Reporting Data Annotation. Format:
            /// 'properties/{property_id}/reportingDataAnnotations/{reporting_data_annotation}' Format:
            /// 'properties/123/reportingDataAnnotations/456'
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaReportingDataAnnotation body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>Updates a Reporting Data Annotation.</summary>
            public class PatchRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaReportingDataAnnotation>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaReportingDataAnnotation body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Identifier. Resource name of this Reporting Data Annotation. Format:
                /// 'properties/{property_id}/reportingDataAnnotations/{reporting_data_annotation}' Format:
                /// 'properties/123/reportingDataAnnotations/456'
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. The list of fields to update. Field names must be in snake case (for example,
                /// "field_to_update"). Omitted fields will not be updated. To replace the entire entity, use one path
                /// with the string "*" to match all fields.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaReportingDataAnnotation Body { get; set; }

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
                        Pattern = @"^properties/[^/]+/reportingDataAnnotations/[^/]+$",
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

        /// <summary>Gets the RollupPropertySourceLinks resource.</summary>
        public virtual RollupPropertySourceLinksResource RollupPropertySourceLinks { get; }

        /// <summary>The "rollupPropertySourceLinks" collection of methods.</summary>
        public class RollupPropertySourceLinksResource
        {
            private const string Resource = "rollupPropertySourceLinks";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public RollupPropertySourceLinksResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a roll-up property source link. Only roll-up properties can have source links, so this method
            /// will throw an error if used on other types of properties.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. Format: properties/{property_id} Example: properties/1234</param>
            public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaRollupPropertySourceLink body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Creates a roll-up property source link. Only roll-up properties can have source links, so this method
            /// will throw an error if used on other types of properties.
            /// </summary>
            public class CreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaRollupPropertySourceLink>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaRollupPropertySourceLink body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Format: properties/{property_id} Example: properties/1234</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaRollupPropertySourceLink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/rollupPropertySourceLinks";

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
            /// Deletes a roll-up property source link. Only roll-up properties can have source links, so this method
            /// will throw an error if used on other types of properties.
            /// </summary>
            /// <param name="name">
            /// Required. Format: properties/{property_id}/rollupPropertySourceLinks/{rollup_property_source_link_id}
            /// Example: properties/1234/rollupPropertySourceLinks/5678
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>
            /// Deletes a roll-up property source link. Only roll-up properties can have source links, so this method
            /// will throw an error if used on other types of properties.
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
                /// Required. Format:
                /// properties/{property_id}/rollupPropertySourceLinks/{rollup_property_source_link_id} Example:
                /// properties/1234/rollupPropertySourceLinks/5678
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
                        Pattern = @"^properties/[^/]+/rollupPropertySourceLinks/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lookup for a single roll-up property source Link. Only roll-up properties can have source links, so this
            /// method will throw an error if used on other types of properties.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the roll-up property source link to lookup. Format:
            /// properties/{property_id}/rollupPropertySourceLinks/{rollup_property_source_link_id} Example:
            /// properties/123/rollupPropertySourceLinks/456
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>
            /// Lookup for a single roll-up property source Link. Only roll-up properties can have source links, so this
            /// method will throw an error if used on other types of properties.
            /// </summary>
            public class GetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaRollupPropertySourceLink>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the roll-up property source link to lookup. Format:
                /// properties/{property_id}/rollupPropertySourceLinks/{rollup_property_source_link_id} Example:
                /// properties/123/rollupPropertySourceLinks/456
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
                        Pattern = @"^properties/[^/]+/rollupPropertySourceLinks/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists roll-up property source Links on a property. Only roll-up properties can have source links, so
            /// this method will throw an error if used on other types of properties.
            /// </summary>
            /// <param name="parent">
            /// Required. The name of the roll-up property to list roll-up property source links under. Format:
            /// properties/{property_id} Example: properties/1234
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>
            /// Lists roll-up property source Links on a property. Only roll-up properties can have source links, so
            /// this method will throw an error if used on other types of properties.
            /// </summary>
            public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaListRollupPropertySourceLinksResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the roll-up property to list roll-up property source links under. Format:
                /// properties/{property_id} Example: properties/1234
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of resources to return. The service may return fewer than this value,
                /// even if there are additional pages. If unspecified, at most 50 resources will be returned. The
                /// maximum value is 200; (higher values will be coerced to the maximum)
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A page token, received from a previous `ListRollupPropertySourceLinks` call. Provide this
                /// to retrieve the subsequent page. When paginating, all other parameters provided to
                /// `ListRollupPropertySourceLinks` must match the call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/rollupPropertySourceLinks";

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

        /// <summary>Gets the SearchAds360Links resource.</summary>
        public virtual SearchAds360LinksResource SearchAds360Links { get; }

        /// <summary>The "searchAds360Links" collection of methods.</summary>
        public class SearchAds360LinksResource
        {
            private const string Resource = "searchAds360Links";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SearchAds360LinksResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a SearchAds360Link.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. Example format: properties/1234</param>
            public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSearchAds360Link body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>Creates a SearchAds360Link.</summary>
            public class CreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSearchAds360Link>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSearchAds360Link body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Example format: properties/1234</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSearchAds360Link Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/searchAds360Links";

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

            /// <summary>Deletes a SearchAds360Link on a property.</summary>
            /// <param name="name">
            /// Required. The name of the SearchAds360Link to delete. Example format:
            /// properties/1234/SearchAds360Links/5678
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>Deletes a SearchAds360Link on a property.</summary>
            public class DeleteRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the SearchAds360Link to delete. Example format:
                /// properties/1234/SearchAds360Links/5678
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
                        Pattern = @"^properties/[^/]+/searchAds360Links/[^/]+$",
                    });
                }
            }

            /// <summary>Look up a single SearchAds360Link</summary>
            /// <param name="name">
            /// Required. The name of the SearchAds360Link to get. Example format: properties/1234/SearchAds360Link/5678
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Look up a single SearchAds360Link</summary>
            public class GetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSearchAds360Link>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the SearchAds360Link to get. Example format:
                /// properties/1234/SearchAds360Link/5678
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
                        Pattern = @"^properties/[^/]+/searchAds360Links/[^/]+$",
                    });
                }
            }

            /// <summary>Lists all SearchAds360Links on a property.</summary>
            /// <param name="parent">Required. Example format: properties/1234</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists all SearchAds360Links on a property.</summary>
            public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaListSearchAds360LinksResponse>
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
                /// A page token, received from a previous `ListSearchAds360Links` call. Provide this to retrieve the
                /// subsequent page. When paginating, all other parameters provided to `ListSearchAds360Links` must
                /// match the call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/searchAds360Links";

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

            /// <summary>Updates a SearchAds360Link on a property.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Output only. The resource name for this SearchAds360Link resource. Format:
            /// properties/{propertyId}/searchAds360Links/{linkId} Note: linkId is not the Search Ads 360 advertiser ID
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSearchAds360Link body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>Updates a SearchAds360Link on a property.</summary>
            public class PatchRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSearchAds360Link>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSearchAds360Link body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Output only. The resource name for this SearchAds360Link resource. Format:
                /// properties/{propertyId}/searchAds360Links/{linkId} Note: linkId is not the Search Ads 360 advertiser
                /// ID
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
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSearchAds360Link Body { get; set; }

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
                        Pattern = @"^properties/[^/]+/searchAds360Links/[^/]+$",
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

        /// <summary>Gets the SubpropertyEventFilters resource.</summary>
        public virtual SubpropertyEventFiltersResource SubpropertyEventFilters { get; }

        /// <summary>The "subpropertyEventFilters" collection of methods.</summary>
        public class SubpropertyEventFiltersResource
        {
            private const string Resource = "subpropertyEventFilters";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SubpropertyEventFiltersResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a subproperty Event Filter.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The ordinary property for which to create a subproperty event filter. Format:
            /// properties/property_id Example: properties/123
            /// </param>
            public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSubpropertyEventFilter body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>Creates a subproperty Event Filter.</summary>
            public class CreateRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSubpropertyEventFilter>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSubpropertyEventFilter body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The ordinary property for which to create a subproperty event filter. Format:
                /// properties/property_id Example: properties/123
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSubpropertyEventFilter Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/subpropertyEventFilters";

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

            /// <summary>Deletes a subproperty event filter.</summary>
            /// <param name="name">
            /// Required. Resource name of the subproperty event filter to delete. Format:
            /// properties/property_id/subpropertyEventFilters/subproperty_event_filter Example:
            /// properties/123/subpropertyEventFilters/456
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>Deletes a subproperty event filter.</summary>
            public class DeleteRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the subproperty event filter to delete. Format:
                /// properties/property_id/subpropertyEventFilters/subproperty_event_filter Example:
                /// properties/123/subpropertyEventFilters/456
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
                        Pattern = @"^properties/[^/]+/subpropertyEventFilters/[^/]+$",
                    });
                }
            }

            /// <summary>Lookup for a single subproperty Event Filter.</summary>
            /// <param name="name">
            /// Required. Resource name of the subproperty event filter to lookup. Format:
            /// properties/property_id/subpropertyEventFilters/subproperty_event_filter Example:
            /// properties/123/subpropertyEventFilters/456
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Lookup for a single subproperty Event Filter.</summary>
            public class GetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSubpropertyEventFilter>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the subproperty event filter to lookup. Format:
                /// properties/property_id/subpropertyEventFilters/subproperty_event_filter Example:
                /// properties/123/subpropertyEventFilters/456
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
                        Pattern = @"^properties/[^/]+/subpropertyEventFilters/[^/]+$",
                    });
                }
            }

            /// <summary>List all subproperty Event Filters on a property.</summary>
            /// <param name="parent">
            /// Required. Resource name of the ordinary property. Format: properties/property_id Example: properties/123
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>List all subproperty Event Filters on a property.</summary>
            public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaListSubpropertyEventFiltersResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the ordinary property. Format: properties/property_id Example:
                /// properties/123
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of resources to return. The service may return fewer than this value,
                /// even if there are additional pages. If unspecified, at most 50 resources will be returned. The
                /// maximum value is 200; (higher values will be coerced to the maximum)
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A page token, received from a previous `ListSubpropertyEventFilters` call. Provide this to
                /// retrieve the subsequent page. When paginating, all other parameters provided to
                /// `ListSubpropertyEventFilters` must match the call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/subpropertyEventFilters";

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

            /// <summary>Updates a subproperty Event Filter.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Output only. Format:
            /// properties/{ordinary_property_id}/subpropertyEventFilters/{sub_property_event_filter} Example:
            /// properties/1234/subpropertyEventFilters/5678
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSubpropertyEventFilter body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>Updates a subproperty Event Filter.</summary>
            public class PatchRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSubpropertyEventFilter>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSubpropertyEventFilter body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Output only. Format:
                /// properties/{ordinary_property_id}/subpropertyEventFilters/{sub_property_event_filter} Example:
                /// properties/1234/subpropertyEventFilters/5678
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Required. The list of fields to update. Field names must be in snake case (for example,
                /// "field_to_update"). Omitted fields will not be updated. To replace the entire entity, use one path
                /// with the string "*" to match all fields.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSubpropertyEventFilter Body { get; set; }

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
                        Pattern = @"^properties/[^/]+/subpropertyEventFilters/[^/]+$",
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

        /// <summary>Gets the SubpropertySyncConfigs resource.</summary>
        public virtual SubpropertySyncConfigsResource SubpropertySyncConfigs { get; }

        /// <summary>The "subpropertySyncConfigs" collection of methods.</summary>
        public class SubpropertySyncConfigsResource
        {
            private const string Resource = "subpropertySyncConfigs";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SubpropertySyncConfigsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Lookup for a single `SubpropertySyncConfig`.</summary>
            /// <param name="name">
            /// Required. Resource name of the SubpropertySyncConfig to lookup. Format:
            /// properties/{ordinary_property_id}/subpropertySyncConfigs/{subproperty_id} Example:
            /// properties/1234/subpropertySyncConfigs/5678
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Lookup for a single `SubpropertySyncConfig`.</summary>
            public class GetRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSubpropertySyncConfig>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the SubpropertySyncConfig to lookup. Format:
                /// properties/{ordinary_property_id}/subpropertySyncConfigs/{subproperty_id} Example:
                /// properties/1234/subpropertySyncConfigs/5678
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
                        Pattern = @"^properties/[^/]+/subpropertySyncConfigs/[^/]+$",
                    });
                }
            }

            /// <summary>List all `SubpropertySyncConfig` resources for a property.</summary>
            /// <param name="parent">
            /// Required. Resource name of the property. Format: properties/property_id Example: properties/123
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>List all `SubpropertySyncConfig` resources for a property.</summary>
            public class ListRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaListSubpropertySyncConfigsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the property. Format: properties/property_id Example: properties/123
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of resources to return. The service may return fewer than this value,
                /// even if there are additional pages. If unspecified, at most 50 resources will be returned. The
                /// maximum value is 200; (higher values will be coerced to the maximum)
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A page token, received from a previous `ListSubpropertySyncConfig` call. Provide this to
                /// retrieve the subsequent page. When paginating, all other parameters provided to
                /// `ListSubpropertySyncConfig` must match the call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/subpropertySyncConfigs";

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

            /// <summary>Updates a `SubpropertySyncConfig`.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Output only. Identifier. Format:
            /// properties/{ordinary_property_id}/subpropertySyncConfigs/{subproperty_id} Example:
            /// properties/1234/subpropertySyncConfigs/5678
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSubpropertySyncConfig body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>Updates a `SubpropertySyncConfig`.</summary>
            public class PatchRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSubpropertySyncConfig>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSubpropertySyncConfig body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Output only. Identifier. Format:
                /// properties/{ordinary_property_id}/subpropertySyncConfigs/{subproperty_id} Example:
                /// properties/1234/subpropertySyncConfigs/5678
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. The list of fields to update. Field names must be in snake case (for example,
                /// "field_to_update"). Omitted fields will not be updated. To replace the entire entity, use one path
                /// with the string "*" to match all fields.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSubpropertySyncConfig Body { get; set; }

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
                        Pattern = @"^properties/[^/]+/subpropertySyncConfigs/[^/]+$",
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
        public virtual AcknowledgeUserDataCollectionRequest AcknowledgeUserDataCollection(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaAcknowledgeUserDataCollectionRequest body, string property)
        {
            return new AcknowledgeUserDataCollectionRequest(this.service, body, property);
        }

        /// <summary>
        /// Acknowledges the terms of user data collection for the specified property. This acknowledgement must be
        /// completed (either in the Google Analytics UI or through this API) before MeasurementProtocolSecret resources
        /// may be created.
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

        /// <summary>Creates a Google Analytics property with the specified location and attributes.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaProperty body)
        {
            return new CreateRequest(this.service, body);
        }

        /// <summary>Creates a Google Analytics property with the specified location and attributes.</summary>
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
        /// Creates a connected site tag for a Universal Analytics property. You can create a maximum of 20 connected
        /// site tags per property. Note: This API cannot be used on GA4 properties.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateConnectedSiteTagRequest CreateConnectedSiteTag(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaCreateConnectedSiteTagRequest body)
        {
            return new CreateConnectedSiteTagRequest(this.service, body);
        }

        /// <summary>
        /// Creates a connected site tag for a Universal Analytics property. You can create a maximum of 20 connected
        /// site tags per property. Note: This API cannot be used on GA4 properties.
        /// </summary>
        public class CreateConnectedSiteTagRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaCreateConnectedSiteTagResponse>
        {
            /// <summary>Constructs a new CreateConnectedSiteTag request.</summary>
            public CreateConnectedSiteTagRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaCreateConnectedSiteTagRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaCreateConnectedSiteTagRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "createConnectedSiteTag";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/properties:createConnectedSiteTag";

            /// <summary>Initializes CreateConnectedSiteTag parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Create a roll-up property and all roll-up property source links.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRollupPropertyRequest CreateRollupProperty(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaCreateRollupPropertyRequest body)
        {
            return new CreateRollupPropertyRequest(this.service, body);
        }

        /// <summary>Create a roll-up property and all roll-up property source links.</summary>
        public class CreateRollupPropertyRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaCreateRollupPropertyResponse>
        {
            /// <summary>Constructs a new CreateRollupProperty request.</summary>
            public CreateRollupPropertyRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaCreateRollupPropertyRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaCreateRollupPropertyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "createRollupProperty";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/properties:createRollupProperty";

            /// <summary>Initializes CreateRollupProperty parameter list.</summary>
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

        /// <summary>
        /// Deletes a connected site tag for a Universal Analytics property. Note: this has no effect on GA4 properties.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual DeleteConnectedSiteTagRequest DeleteConnectedSiteTag(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaDeleteConnectedSiteTagRequest body)
        {
            return new DeleteConnectedSiteTagRequest(this.service, body);
        }

        /// <summary>
        /// Deletes a connected site tag for a Universal Analytics property. Note: this has no effect on GA4 properties.
        /// </summary>
        public class DeleteConnectedSiteTagRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleProtobufEmpty>
        {
            /// <summary>Constructs a new DeleteConnectedSiteTag request.</summary>
            public DeleteConnectedSiteTagRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaDeleteConnectedSiteTagRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaDeleteConnectedSiteTagRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "deleteConnectedSiteTag";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/properties:deleteConnectedSiteTag";

            /// <summary>Initializes DeleteConnectedSiteTag parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Fetches the opt out status for the automated GA4 setup process for a UA property. Note: this has no effect
        /// on GA4 property.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual FetchAutomatedGa4ConfigurationOptOutRequest FetchAutomatedGa4ConfigurationOptOut(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaFetchAutomatedGa4ConfigurationOptOutRequest body)
        {
            return new FetchAutomatedGa4ConfigurationOptOutRequest(this.service, body);
        }

        /// <summary>
        /// Fetches the opt out status for the automated GA4 setup process for a UA property. Note: this has no effect
        /// on GA4 property.
        /// </summary>
        public class FetchAutomatedGa4ConfigurationOptOutRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaFetchAutomatedGa4ConfigurationOptOutResponse>
        {
            /// <summary>Constructs a new FetchAutomatedGa4ConfigurationOptOut request.</summary>
            public FetchAutomatedGa4ConfigurationOptOutRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaFetchAutomatedGa4ConfigurationOptOutRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaFetchAutomatedGa4ConfigurationOptOutRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "fetchAutomatedGa4ConfigurationOptOut";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/properties:fetchAutomatedGa4ConfigurationOptOut";

            /// <summary>Initializes FetchAutomatedGa4ConfigurationOptOut parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Given a specified UA property, looks up the GA4 property connected to it. Note: this cannot be used with GA4
        /// properties.
        /// </summary>
        public virtual FetchConnectedGa4PropertyRequest FetchConnectedGa4Property()
        {
            return new FetchConnectedGa4PropertyRequest(this.service);
        }

        /// <summary>
        /// Given a specified UA property, looks up the GA4 property connected to it. Note: this cannot be used with GA4
        /// properties.
        /// </summary>
        public class FetchConnectedGa4PropertyRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaFetchConnectedGa4PropertyResponse>
        {
            /// <summary>Constructs a new FetchConnectedGa4Property request.</summary>
            public FetchConnectedGa4PropertyRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Required. The UA property for which to look up the connected GA4 property. Note this request uses the
            /// internal property ID, not the tracking ID of the form UA-XXXXXX-YY. Format:
            /// properties/{internal_web_property_id} Example: properties/1234
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("property", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Property { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "fetchConnectedGa4Property";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/properties:fetchConnectedGa4Property";

            /// <summary>Initializes FetchConnectedGa4Property parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("property", new Google.Apis.Discovery.Parameter
                {
                    Name = "property",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
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
            return new GetAttributionSettingsRequest(this.service, name);
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
            return new GetDataRetentionSettingsRequest(this.service, name);
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
            return new GetGoogleSignalsSettingsRequest(this.service, name);
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

        /// <summary>
        /// Lists the connected site tags for a Universal Analytics property. A maximum of 20 connected site tags will
        /// be returned. Note: this has no effect on GA4 property.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual ListConnectedSiteTagsRequest ListConnectedSiteTags(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaListConnectedSiteTagsRequest body)
        {
            return new ListConnectedSiteTagsRequest(this.service, body);
        }

        /// <summary>
        /// Lists the connected site tags for a Universal Analytics property. A maximum of 20 connected site tags will
        /// be returned. Note: this has no effect on GA4 property.
        /// </summary>
        public class ListConnectedSiteTagsRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaListConnectedSiteTagsResponse>
        {
            /// <summary>Constructs a new ListConnectedSiteTags request.</summary>
            public ListConnectedSiteTagsRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaListConnectedSiteTagsRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaListConnectedSiteTagsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "listConnectedSiteTags";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/properties:listConnectedSiteTags";

            /// <summary>Initializes ListConnectedSiteTags parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Updates a property.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Output only. Resource name of this property. Format: properties/{property_id} Example: "properties/1000"
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaProperty body, string name)
        {
            return new PatchRequest(this.service, body, name);
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

        /// <summary>
        /// Create a subproperty and a subproperty event filter that applies to the created subproperty.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual ProvisionSubpropertyRequest ProvisionSubproperty(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaProvisionSubpropertyRequest body)
        {
            return new ProvisionSubpropertyRequest(this.service, body);
        }

        /// <summary>
        /// Create a subproperty and a subproperty event filter that applies to the created subproperty.
        /// </summary>
        public class ProvisionSubpropertyRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaProvisionSubpropertyResponse>
        {
            /// <summary>Constructs a new ProvisionSubproperty request.</summary>
            public ProvisionSubpropertyRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaProvisionSubpropertyRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaProvisionSubpropertyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "provisionSubproperty";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/properties:provisionSubproperty";

            /// <summary>Initializes ProvisionSubproperty parameter list.</summary>
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
        public virtual RunAccessReportRequest RunAccessReport(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaRunAccessReportRequest body, string entity)
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
        public class RunAccessReportRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaRunAccessReportResponse>
        {
            /// <summary>Constructs a new RunAccessReport request.</summary>
            public RunAccessReportRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaRunAccessReportRequest body, string entity) : base(service)
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
            Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaRunAccessReportRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "runAccessReport";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/{+entity}:runAccessReport";

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

        /// <summary>
        /// Sets the opt out status for the automated GA4 setup process for a UA property. Note: this has no effect on
        /// GA4 property.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual SetAutomatedGa4ConfigurationOptOutRequest SetAutomatedGa4ConfigurationOptOut(Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSetAutomatedGa4ConfigurationOptOutRequest body)
        {
            return new SetAutomatedGa4ConfigurationOptOutRequest(this.service, body);
        }

        /// <summary>
        /// Sets the opt out status for the automated GA4 setup process for a UA property. Note: this has no effect on
        /// GA4 property.
        /// </summary>
        public class SetAutomatedGa4ConfigurationOptOutRequest : GoogleAnalyticsAdminBaseServiceRequest<Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSetAutomatedGa4ConfigurationOptOutResponse>
        {
            /// <summary>Constructs a new SetAutomatedGa4ConfigurationOptOut request.</summary>
            public SetAutomatedGa4ConfigurationOptOutRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSetAutomatedGa4ConfigurationOptOutRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.GoogleAnalyticsAdmin.v1alpha.Data.GoogleAnalyticsAdminV1alphaSetAutomatedGa4ConfigurationOptOutRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "setAutomatedGa4ConfigurationOptOut";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/properties:setAutomatedGa4ConfigurationOptOut";

            /// <summary>Initializes SetAutomatedGa4ConfigurationOptOut parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
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
            return new UpdateAttributionSettingsRequest(this.service, body, name);
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
            return new UpdateDataRetentionSettingsRequest(this.service, body, name);
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
            return new UpdateGoogleSignalsSettingsRequest(this.service, body, name);
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
    /// <summary>To express that the result needs to be between two numbers (inclusive).</summary>
    public class GoogleAnalyticsAdminV1alphaAccessBetweenFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Begins with this number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fromValue")]
        public virtual GoogleAnalyticsAdminV1alphaNumericValue FromValue { get; set; }

        /// <summary>Ends with this number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toValue")]
        public virtual GoogleAnalyticsAdminV1alphaNumericValue ToValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A binding of a user to a set of roles.</summary>
    public class GoogleAnalyticsAdminV1alphaAccessBinding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Resource name of this binding. Format: accounts/{account}/accessBindings/{access_binding} or
        /// properties/{property}/accessBindings/{access_binding} Example: "accounts/100/accessBindings/200"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// A list of roles for to grant to the parent resource. Valid values: predefinedRoles/viewer
        /// predefinedRoles/analyst predefinedRoles/editor predefinedRoles/admin predefinedRoles/no-cost-data
        /// predefinedRoles/no-revenue-data For users, if an empty list of roles is set, this AccessBinding will be
        /// deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roles")]
        public virtual System.Collections.Generic.IList<string> Roles { get; set; }

        /// <summary>If set, the email address of the user to set roles for. Format: "someuser@gmail.com"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual string User { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A contiguous range of days: startDate, startDate + 1, ..., endDate.</summary>
    public class GoogleAnalyticsAdminV1alphaAccessDateRange : Google.Apis.Requests.IDirectResponseSchema
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
    public class GoogleAnalyticsAdminV1alphaAccessDimension : Google.Apis.Requests.IDirectResponseSchema
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
    public class GoogleAnalyticsAdminV1alphaAccessDimensionHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The dimension's name; for example 'userEmail'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionName")]
        public virtual string DimensionName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The value of a dimension.</summary>
    public class GoogleAnalyticsAdminV1alphaAccessDimensionValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The dimension value. For example, this value may be 'France' for the 'country' dimension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An expression to filter dimension or metric values.</summary>
    public class GoogleAnalyticsAdminV1alphaAccessFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A filter for two values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("betweenFilter")]
        public virtual GoogleAnalyticsAdminV1alphaAccessBetweenFilter BetweenFilter { get; set; }

        /// <summary>The dimension name or metric name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldName")]
        public virtual string FieldName { get; set; }

        /// <summary>A filter for in list values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inListFilter")]
        public virtual GoogleAnalyticsAdminV1alphaAccessInListFilter InListFilter { get; set; }

        /// <summary>A filter for numeric or date values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numericFilter")]
        public virtual GoogleAnalyticsAdminV1alphaAccessNumericFilter NumericFilter { get; set; }

        /// <summary>Strings related filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringFilter")]
        public virtual GoogleAnalyticsAdminV1alphaAccessStringFilter StringFilter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Expresses dimension or metric filters. The fields in the same expression need to be either all dimensions or all
    /// metrics.
    /// </summary>
    public class GoogleAnalyticsAdminV1alphaAccessFilterExpression : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A primitive filter. In the same FilterExpression, all of the filter's field names need to be either all
        /// dimensions or all metrics.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessFilter")]
        public virtual GoogleAnalyticsAdminV1alphaAccessFilter AccessFilter { get; set; }

        /// <summary>Each of the FilterExpressions in the and_group has an AND relationship.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("andGroup")]
        public virtual GoogleAnalyticsAdminV1alphaAccessFilterExpressionList AndGroup { get; set; }

        /// <summary>The FilterExpression is NOT of not_expression.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notExpression")]
        public virtual GoogleAnalyticsAdminV1alphaAccessFilterExpression NotExpression { get; set; }

        /// <summary>Each of the FilterExpressions in the or_group has an OR relationship.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orGroup")]
        public virtual GoogleAnalyticsAdminV1alphaAccessFilterExpressionList OrGroup { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of filter expressions.</summary>
    public class GoogleAnalyticsAdminV1alphaAccessFilterExpressionList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of filter expressions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expressions")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaAccessFilterExpression> Expressions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result needs to be in a list of string values.</summary>
    public class GoogleAnalyticsAdminV1alphaAccessInListFilter : Google.Apis.Requests.IDirectResponseSchema
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
    public class GoogleAnalyticsAdminV1alphaAccessMetric : Google.Apis.Requests.IDirectResponseSchema
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
    public class GoogleAnalyticsAdminV1alphaAccessMetricHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The metric's name; for example 'accessCount'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricName")]
        public virtual string MetricName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The value of a metric.</summary>
    public class GoogleAnalyticsAdminV1alphaAccessMetricValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The measurement value. For example, this value may be '13'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Filters for numeric or date values.</summary>
    public class GoogleAnalyticsAdminV1alphaAccessNumericFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The operation type for this filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual string Operation { get; set; }

        /// <summary>A numeric value or a date value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual GoogleAnalyticsAdminV1alphaNumericValue Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Order bys define how rows will be sorted in the response. For example, ordering rows by descending access count
    /// is one ordering, and ordering rows by the country string is a different ordering.
    /// </summary>
    public class GoogleAnalyticsAdminV1alphaAccessOrderBy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If true, sorts by descending order. If false or unspecified, sorts in ascending order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desc")]
        public virtual System.Nullable<bool> Desc { get; set; }

        /// <summary>Sorts results by a dimension's values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimension")]
        public virtual GoogleAnalyticsAdminV1alphaAccessOrderByDimensionOrderBy Dimension { get; set; }

        /// <summary>Sorts results by a metric's values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metric")]
        public virtual GoogleAnalyticsAdminV1alphaAccessOrderByMetricOrderBy Metric { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Sorts by dimension values.</summary>
    public class GoogleAnalyticsAdminV1alphaAccessOrderByDimensionOrderBy : Google.Apis.Requests.IDirectResponseSchema
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
    public class GoogleAnalyticsAdminV1alphaAccessOrderByMetricOrderBy : Google.Apis.Requests.IDirectResponseSchema
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
    public class GoogleAnalyticsAdminV1alphaAccessQuota : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Properties can use up to 50 concurrent requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("concurrentRequests")]
        public virtual GoogleAnalyticsAdminV1alphaAccessQuotaStatus ConcurrentRequests { get; set; }

        /// <summary>Properties and cloud project pairs can have up to 50 server errors per hour.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serverErrorsPerProjectPerHour")]
        public virtual GoogleAnalyticsAdminV1alphaAccessQuotaStatus ServerErrorsPerProjectPerHour { get; set; }

        /// <summary>Properties can use 250,000 tokens per day. Most requests consume fewer than 10 tokens.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokensPerDay")]
        public virtual GoogleAnalyticsAdminV1alphaAccessQuotaStatus TokensPerDay { get; set; }

        /// <summary>
        /// Properties can use 50,000 tokens per hour. An API request consumes a single number of tokens, and that
        /// number is deducted from all of the hourly, daily, and per project hourly quotas.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokensPerHour")]
        public virtual GoogleAnalyticsAdminV1alphaAccessQuotaStatus TokensPerHour { get; set; }

        /// <summary>
        /// Properties can use up to 25% of their tokens per project per hour. This amounts to Analytics 360 Properties
        /// can use 12,500 tokens per project per hour. An API request consumes a single number of tokens, and that
        /// number is deducted from all of the hourly, daily, and per project hourly quotas.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokensPerProjectPerHour")]
        public virtual GoogleAnalyticsAdminV1alphaAccessQuotaStatus TokensPerProjectPerHour { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Current state for a particular quota group.</summary>
    public class GoogleAnalyticsAdminV1alphaAccessQuotaStatus : Google.Apis.Requests.IDirectResponseSchema
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
    public class GoogleAnalyticsAdminV1alphaAccessRow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of dimension values. These values are in the same order as specified in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionValues")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaAccessDimensionValue> DimensionValues { get; set; }

        /// <summary>List of metric values. These values are in the same order as specified in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricValues")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaAccessMetricValue> MetricValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The filter for strings.</summary>
    public class GoogleAnalyticsAdminV1alphaAccessStringFilter : Google.Apis.Requests.IDirectResponseSchema
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
    public class GoogleAnalyticsAdminV1alphaAccount : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>A link between a Google Analytics property and an AdSense for Content ad client.</summary>
    public class GoogleAnalyticsAdminV1alphaAdSenseLink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Immutable. The AdSense ad client code that the Google Analytics property is linked to. Example format:
        /// "ca-pub-1234567890"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adClientCode")]
        public virtual string AdClientCode { get; set; }

        /// <summary>
        /// Output only. The resource name for this AdSense Link resource. Format:
        /// properties/{propertyId}/adSenseLinks/{linkId} Example: properties/1234/adSenseLinks/6789
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

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

        /// <summary>Required. The Conversion Export Scope for data exported to linked Ads Accounts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adsWebConversionDataExportScope")]
        public virtual string AdsWebConversionDataExportScope { get; set; }

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

    /// <summary>A resource message representing an Audience.</summary>
    public class GoogleAnalyticsAdminV1alphaAudience : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. It is automatically set by GA to false if this is an NPA Audience and is excluded from ads
        /// personalization.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adsPersonalizationEnabled")]
        public virtual System.Nullable<bool> AdsPersonalizationEnabled { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time when the Audience was created.</summary>
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
        /// Required. Immutable. Unordered list. Filter clauses that define the Audience. All clauses will be AND’ed
        /// together.
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

        /// <summary>
        /// Required. Immutable. The dimension name or metric name to filter. If the field name refers to a custom
        /// dimension or metric, a scope prefix will be added to the front of the custom dimensions or metric name. For
        /// more on scope prefixes or custom dimensions/metrics, reference the [Google Analytics Data API documentation]
        /// (https://developers.google.com/analytics/devguides/reporting/data/v1/api-schema#custom_dimensions).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldName")]
        public virtual string FieldName { get; set; }

        /// <summary>
        /// Optional. If set, specifies the time window for which to evaluate data in number of days. If not set, then
        /// audience data is evaluated against lifetime data (For example, infinite time window). For example, if set to
        /// 1 day, only the current day's data is evaluated. The reference point is the current day when
        /// at_any_point_in_time is unset or false. It can only be set when Audience scope is ACROSS_ALL_SESSIONS and
        /// cannot be greater than 60 days.
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
        /// filter expressions. AudienceEventFilter inside the parameter filter expression cannot be set (For example,
        /// nested event filters are not supported). This should be a single and_group of dimension_or_metric_filter or
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
    /// A clause for defining either a simple or sequence filter. A filter can be inclusive (For example, users
    /// satisfying the filter clause are included in the Audience) or exclusive (For example, users satisfying the
    /// filter clause are excluded from the Audience).
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
        /// A filter expression to be NOT'ed (For example, inverted, complemented). It can only include a
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
        /// Optional. When set, this step must be satisfied within the constraint_duration of the previous step (For
        /// example, t[i] - t[i-1] &amp;lt;= constraint_duration). If not set, there is no duration requirement (the
        /// duration is effectively unlimited). It is ignored for the first step.
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

    /// <summary>Request message for BatchCreateAccessBindings RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaBatchCreateAccessBindingsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The requests specifying the access bindings to create. A maximum of 1000 access bindings can be
        /// created in a batch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaCreateAccessBindingRequest> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for BatchCreateAccessBindings RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaBatchCreateAccessBindingsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The access bindings created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessBindings")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaAccessBinding> AccessBindings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for BatchDeleteAccessBindings RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaBatchDeleteAccessBindingsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The requests specifying the access bindings to delete. A maximum of 1000 access bindings can be
        /// deleted in a batch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaDeleteAccessBindingRequest> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for BatchGetAccessBindings RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaBatchGetAccessBindingsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The requested access bindings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessBindings")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaAccessBinding> AccessBindings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for BatchUpdateAccessBindings RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaBatchUpdateAccessBindingsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The requests specifying the access bindings to update. A maximum of 1000 access bindings can be
        /// updated in a batch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaUpdateAccessBindingRequest> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for BatchUpdateAccessBindings RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaBatchUpdateAccessBindingsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The access bindings updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessBindings")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaAccessBinding> AccessBindings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A link between a Google Analytics property and BigQuery project.</summary>
    public class GoogleAnalyticsAdminV1alphaBigQueryLink : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time when the link was created.</summary>
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

        /// <summary>If set true, enables daily data export to the linked Google Cloud project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dailyExportEnabled")]
        public virtual System.Nullable<bool> DailyExportEnabled { get; set; }

        /// <summary>
        /// Required. Immutable. The geographic location where the created BigQuery dataset should reside. See
        /// https://cloud.google.com/bigquery/docs/locations for supported locations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetLocation")]
        public virtual string DatasetLocation { get; set; }

        /// <summary>The list of event names that will be excluded from exports.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedEvents")]
        public virtual System.Collections.Generic.IList<string> ExcludedEvents { get; set; }

        /// <summary>
        /// The list of streams under the parent property for which data will be exported. Format:
        /// properties/{property_id}/dataStreams/{stream_id} Example: ['properties/1000/dataStreams/2000']
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exportStreams")]
        public virtual System.Collections.Generic.IList<string> ExportStreams { get; set; }

        /// <summary>If set true, enables fresh daily export to the linked Google Cloud project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freshDailyExportEnabled")]
        public virtual System.Nullable<bool> FreshDailyExportEnabled { get; set; }

        /// <summary>If set true, exported data will include advertising identifiers for mobile app streams.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeAdvertisingId")]
        public virtual System.Nullable<bool> IncludeAdvertisingId { get; set; }

        /// <summary>
        /// Output only. Resource name of this BigQuery link. Format:
        /// 'properties/{property_id}/bigQueryLinks/{bigquery_link_id}' Format: 'properties/1234/bigQueryLinks/abc567'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Immutable. The linked Google Cloud project. When creating a BigQueryLink, you may provide this resource name
        /// using either a project number or project ID. Once this resource has been created, the returned project will
        /// always have a project that contains a project number. Format: 'projects/{project number}' Example:
        /// 'projects/1234'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

        /// <summary>If set true, enables streaming export to the linked Google Cloud project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("streamingExportEnabled")]
        public virtual System.Nullable<bool> StreamingExportEnabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A definition for a calculated metric.</summary>
    public class GoogleAnalyticsAdminV1alphaCalculatedMetric : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The ID to use for the calculated metric. In the UI, this is referred to as the "API name." The
        /// calculated_metric_id is used when referencing this calculated metric from external APIs. For example,
        /// "calcMetric:{calculated_metric_id}".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("calculatedMetricId")]
        public virtual string CalculatedMetricId { get; set; }

        /// <summary>Optional. Description for this calculated metric. Max length of 4096 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Required. Display name for this calculated metric as shown in the Google Analytics UI. Max length 82
        /// characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Required. The calculated metric's definition. Maximum number of unique referenced custom metrics is 5.
        /// Formulas supports the following operations: + (addition), - (subtraction), - (negative), * (multiplication),
        /// / (division), () (parenthesis). Any valid real numbers are acceptable that fit in a Long (64bit integer) or
        /// a Double (64 bit floating point number). Example formula: "( customEvent:parameter_name +
        /// cartPurchaseQuantity ) / 2.0"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formula")]
        public virtual string Formula { get; set; }

        /// <summary>
        /// Output only. If true, this calculated metric has a invalid metric reference. Anything using a calculated
        /// metric with invalid_metric_reference set to true may fail, produce warnings, or produce unexpected results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invalidMetricReference")]
        public virtual System.Nullable<bool> InvalidMetricReference { get; set; }

        /// <summary>Required. The type for the calculated metric's value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricUnit")]
        public virtual string MetricUnit { get; set; }

        /// <summary>
        /// Output only. Resource name for this CalculatedMetric. Format:
        /// 'properties/{property_id}/calculatedMetrics/{calculated_metric_id}'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Types of restricted data that this metric contains.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictedMetricType")]
        public virtual System.Collections.Generic.IList<string> RestrictedMetricType { get; set; }

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

        /// <summary>A snapshot of an AdSenseLink resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adsenseLink")]
        public virtual GoogleAnalyticsAdminV1alphaAdSenseLink AdsenseLink { get; set; }

        /// <summary>A snapshot of AttributionSettings resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributionSettings")]
        public virtual GoogleAnalyticsAdminV1alphaAttributionSettings AttributionSettings { get; set; }

        /// <summary>A snapshot of an Audience resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audience")]
        public virtual GoogleAnalyticsAdminV1alphaAudience Audience { get; set; }

        /// <summary>A snapshot of a BigQuery link resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigqueryLink")]
        public virtual GoogleAnalyticsAdminV1alphaBigQueryLink BigqueryLink { get; set; }

        /// <summary>A snapshot of a CalculatedMetric resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("calculatedMetric")]
        public virtual GoogleAnalyticsAdminV1alphaCalculatedMetric CalculatedMetric { get; set; }

        /// <summary>A snapshot of a ChannelGroup resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelGroup")]
        public virtual GoogleAnalyticsAdminV1alphaChannelGroup ChannelGroup { get; set; }

        /// <summary>A snapshot of a ConversionEvent resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionEvent")]
        public virtual GoogleAnalyticsAdminV1alphaConversionEvent ConversionEvent { get; set; }

        /// <summary>A snapshot of a CustomDimension resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customDimension")]
        public virtual GoogleAnalyticsAdminV1alphaCustomDimension CustomDimension { get; set; }

        /// <summary>A snapshot of a CustomMetric resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customMetric")]
        public virtual GoogleAnalyticsAdminV1alphaCustomMetric CustomMetric { get; set; }

        /// <summary>A snapshot of DataRedactionSettings resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataRedactionSettings")]
        public virtual GoogleAnalyticsAdminV1alphaDataRedactionSettings DataRedactionSettings { get; set; }

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

        /// <summary>A snapshot of EnhancedMeasurementSettings resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enhancedMeasurementSettings")]
        public virtual GoogleAnalyticsAdminV1alphaEnhancedMeasurementSettings EnhancedMeasurementSettings { get; set; }

        /// <summary>A snapshot of an EventCreateRule resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventCreateRule")]
        public virtual GoogleAnalyticsAdminV1alphaEventCreateRule EventCreateRule { get; set; }

        /// <summary>A snapshot of an ExpandedDataSet resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expandedDataSet")]
        public virtual GoogleAnalyticsAdminV1alphaExpandedDataSet ExpandedDataSet { get; set; }

        /// <summary>A snapshot of a FirebaseLink resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firebaseLink")]
        public virtual GoogleAnalyticsAdminV1alphaFirebaseLink FirebaseLink { get; set; }

        /// <summary>A snapshot of a GoogleAdsLink resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleAdsLink")]
        public virtual GoogleAnalyticsAdminV1alphaGoogleAdsLink GoogleAdsLink { get; set; }

        /// <summary>A snapshot of a GoogleSignalsSettings resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleSignalsSettings")]
        public virtual GoogleAnalyticsAdminV1alphaGoogleSignalsSettings GoogleSignalsSettings { get; set; }

        /// <summary>A snapshot of a KeyEvent resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyEvent")]
        public virtual GoogleAnalyticsAdminV1alphaKeyEvent KeyEvent { get; set; }

        /// <summary>A snapshot of a MeasurementProtocolSecret resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("measurementProtocolSecret")]
        public virtual GoogleAnalyticsAdminV1alphaMeasurementProtocolSecret MeasurementProtocolSecret { get; set; }

        /// <summary>A snapshot of a Property resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual GoogleAnalyticsAdminV1alphaProperty Property { get; set; }

        /// <summary>A snapshot of a ReportingDataAnnotation resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportingDataAnnotation")]
        public virtual GoogleAnalyticsAdminV1alphaReportingDataAnnotation ReportingDataAnnotation { get; set; }

        /// <summary>A snapshot of a SearchAds360Link resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchAds360Link")]
        public virtual GoogleAnalyticsAdminV1alphaSearchAds360Link SearchAds360Link { get; set; }

        /// <summary>A snapshot of SKAdNetworkConversionValueSchema resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skadnetworkConversionValueSchema")]
        public virtual GoogleAnalyticsAdminV1alphaSKAdNetworkConversionValueSchema SkadnetworkConversionValueSchema { get; set; }

        /// <summary>A snapshot of a SubpropertySyncConfig resource in change history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subpropertySyncConfig")]
        public virtual GoogleAnalyticsAdminV1alphaSubpropertySyncConfig SubpropertySyncConfig { get; set; }

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

    /// <summary>A resource message representing a Channel Group.</summary>
    public class GoogleAnalyticsAdminV1alphaChannelGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The description of the Channel Group. Max length of 256 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. The display name of the Channel Group. Max length of 80 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Required. The grouping rules of channels. Maximum number of rules is 50.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupingRule")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaGroupingRule> GroupingRule { get; set; }

        /// <summary>
        /// Output only. The resource name for this Channel Group resource. Format:
        /// properties/{property}/channelGroups/{channel_group}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. If true, this channel group will be used as the default channel group for reports. Only one
        /// channel group can be set as `primary` at any time. If the `primary` field gets set on a channel group, it
        /// will get unset on the previous primary channel group. The Google Analytics predefined channel group is the
        /// primary by default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primary")]
        public virtual System.Nullable<bool> Primary { get; set; }

        /// <summary>
        /// Output only. If true, then this channel group is the Default Channel Group predefined by Google Analytics.
        /// Display name and grouping rules cannot be updated for this channel group.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemDefined")]
        public virtual System.Nullable<bool> SystemDefined { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A specific filter for a single dimension.</summary>
    public class GoogleAnalyticsAdminV1alphaChannelGroupFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Immutable. The dimension name to filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldName")]
        public virtual string FieldName { get; set; }

        /// <summary>A filter for a string dimension that matches a particular list of options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inListFilter")]
        public virtual GoogleAnalyticsAdminV1alphaChannelGroupFilterInListFilter InListFilter { get; set; }

        /// <summary>A filter for a string-type dimension that matches a particular pattern.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringFilter")]
        public virtual GoogleAnalyticsAdminV1alphaChannelGroupFilterStringFilter StringFilter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A logical expression of Channel Group dimension filters.</summary>
    public class GoogleAnalyticsAdminV1alphaChannelGroupFilterExpression : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of expressions to be AND’ed together. It can only contain ChannelGroupFilterExpressions with
        /// or_group. This must be set for the top level ChannelGroupFilterExpression.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("andGroup")]
        public virtual GoogleAnalyticsAdminV1alphaChannelGroupFilterExpressionList AndGroup { get; set; }

        /// <summary>
        /// A filter on a single dimension. This cannot be set on the top level ChannelGroupFilterExpression.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual GoogleAnalyticsAdminV1alphaChannelGroupFilter Filter { get; set; }

        /// <summary>
        /// A filter expression to be NOT'ed (that is inverted, complemented). It can only include a
        /// dimension_or_metric_filter. This cannot be set on the top level ChannelGroupFilterExpression.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notExpression")]
        public virtual GoogleAnalyticsAdminV1alphaChannelGroupFilterExpression NotExpression { get; set; }

        /// <summary>
        /// A list of expressions to OR’ed together. It cannot contain ChannelGroupFilterExpressions with and_group or
        /// or_group.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orGroup")]
        public virtual GoogleAnalyticsAdminV1alphaChannelGroupFilterExpressionList OrGroup { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of Channel Group filter expressions.</summary>
    public class GoogleAnalyticsAdminV1alphaChannelGroupFilterExpressionList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of Channel Group filter expressions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterExpressions")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaChannelGroupFilterExpression> FilterExpressions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A filter for a string dimension that matches a particular list of options. The match is case insensitive.
    /// </summary>
    public class GoogleAnalyticsAdminV1alphaChannelGroupFilterInListFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The list of possible string values to match against. Must be non-empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Filter where the field value is a String. The match is case insensitive.</summary>
    public class GoogleAnalyticsAdminV1alphaChannelGroupFilterStringFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The match type for the string filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchType")]
        public virtual string MatchType { get; set; }

        /// <summary>Required. The string value to be matched against.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for a specific Connected Site Tag.</summary>
    public class GoogleAnalyticsAdminV1alphaConnectedSiteTag : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. User-provided display name for the connected site tag. Must be less than 256 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Required. "Tag ID to forward events to. Also known as the Measurement ID, or the "G-ID" (For example:
        /// G-12345).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagId")]
        public virtual string TagId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A conversion event in a Google Analytics property.</summary>
    public class GoogleAnalyticsAdminV1alphaConversionEvent : Google.Apis.Requests.IDirectResponseSchema
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
        public virtual GoogleAnalyticsAdminV1alphaConversionEventDefaultConversionValue DefaultConversionValue { get; set; }

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
    public class GoogleAnalyticsAdminV1alphaConversionEventDefaultConversionValue : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Conversion value settings for a postback window for SKAdNetwork conversion value schema.</summary>
    public class GoogleAnalyticsAdminV1alphaConversionValues : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. A coarse grained conversion value. This value is not guaranteed to be unique.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("coarseValue")]
        public virtual string CoarseValue { get; set; }

        /// <summary>
        /// Display name of the SKAdNetwork conversion value. The max allowed display name length is 50 UTF-16 code
        /// units.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Event conditions that must be met for this Conversion Value to be achieved. The conditions in this list are
        /// ANDed together. It must have minimum of 1 entry and maximum of 3 entries, if the postback window is enabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventMappings")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaEventMapping> EventMappings { get; set; }

        /// <summary>
        /// The fine-grained conversion value. This is applicable only to the first postback window. Its valid values
        /// are [0,63], both inclusive. It must be set for postback window 1, and must not be set for postback window 2
        /// &amp;amp; 3. This value is not guaranteed to be unique. If the configuration for the first postback window
        /// is re-used for second or third postback windows this field has no effect.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fineValue")]
        public virtual System.Nullable<int> FineValue { get; set; }

        /// <summary>If true, the SDK should lock to this conversion value for the current postback window.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lockEnabled")]
        public virtual System.Nullable<bool> LockEnabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for CreateAccessBinding RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaCreateAccessBindingRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The access binding to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessBinding")]
        public virtual GoogleAnalyticsAdminV1alphaAccessBinding AccessBinding { get; set; }

        /// <summary>Required. Formats: - accounts/{account} - properties/{property}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for CreateConnectedSiteTag RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaCreateConnectedSiteTagRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The tag to add to the Universal Analytics property</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectedSiteTag")]
        public virtual GoogleAnalyticsAdminV1alphaConnectedSiteTag ConnectedSiteTag { get; set; }

        /// <summary>
        /// The Universal Analytics property to create connected site tags for. This API does not support GA4
        /// properties. Format: properties/{universalAnalyticsPropertyId} Example: properties/1234
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual string Property { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for CreateConnectedSiteTag RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaCreateConnectedSiteTagResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for CreateRollupProperty RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaCreateRollupPropertyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The roll-up property to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollupProperty")]
        public virtual GoogleAnalyticsAdminV1alphaProperty RollupProperty { get; set; }

        /// <summary>
        /// Optional. The resource names of properties that will be sources to the created roll-up property.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceProperties")]
        public virtual System.Collections.Generic.IList<string> SourceProperties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for CreateRollupProperty RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaCreateRollupPropertyResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The created roll-up property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollupProperty")]
        public virtual GoogleAnalyticsAdminV1alphaProperty RollupProperty { get; set; }

        /// <summary>The created roll-up property source links.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollupPropertySourceLinks")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaRollupPropertySourceLink> RollupPropertySourceLinks { get; set; }

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

    /// <summary>Settings for client-side data redaction. Singleton resource under a Web Stream.</summary>
    public class GoogleAnalyticsAdminV1alphaDataRedactionSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If enabled, any event parameter or user property values that look like an email will be redacted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailRedactionEnabled")]
        public virtual System.Nullable<bool> EmailRedactionEnabled { get; set; }

        /// <summary>
        /// Output only. Name of this Data Redaction Settings resource. Format:
        /// properties/{property_id}/dataStreams/{data_stream}/dataRedactionSettings Example:
        /// "properties/1000/dataStreams/2000/dataRedactionSettings"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The query parameter keys to apply redaction logic to if present in the URL. Query parameter matching is
        /// case-insensitive. Must contain at least one element if query_parameter_replacement_enabled is true. Keys
        /// cannot contain commas.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryParameterKeys")]
        public virtual System.Collections.Generic.IList<string> QueryParameterKeys { get; set; }

        /// <summary>
        /// Query Parameter redaction removes the key and value portions of a query parameter if it is in the configured
        /// set of query parameters. If enabled, URL query replacement logic will be run for the Stream. Any query
        /// parameters defined in query_parameter_keys will be redacted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryParameterRedactionEnabled")]
        public virtual System.Nullable<bool> QueryParameterRedactionEnabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings values for data retention. This is a singleton resource.</summary>
    public class GoogleAnalyticsAdminV1alphaDataRetentionSettings : Google.Apis.Requests.IDirectResponseSchema
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
    public class GoogleAnalyticsAdminV1alphaDataSharingSettings : Google.Apis.Requests.IDirectResponseSchema
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
    public class GoogleAnalyticsAdminV1alphaDataStream : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Data specific to Android app streams. Must be populated if type is ANDROID_APP_DATA_STREAM.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidAppStreamData")]
        public virtual GoogleAnalyticsAdminV1alphaDataStreamAndroidAppStreamData AndroidAppStreamData { get; set; }

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

    /// <summary>Request message for DeleteAccessBinding RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaDeleteAccessBindingRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Formats: - accounts/{account}/accessBindings/{accessBinding} -
        /// properties/{property}/accessBindings/{accessBinding}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DeleteConnectedSiteTag RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaDeleteConnectedSiteTagRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The Universal Analytics property to delete connected site tags for. This API does not support GA4
        /// properties. Format: properties/{universalAnalyticsPropertyId} Example: properties/1234
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual string Property { get; set; }

        /// <summary>
        /// Tag ID to forward events to. Also known as the Measurement ID, or the "G-ID" (For example: G-12345).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagId")]
        public virtual string TagId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A link between a Google Analytics property and a Display &amp; Video 360 advertiser.</summary>
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
        /// Immutable. Enables the import of campaign data from Display &amp;amp; Video 360 into the Google Analytics
        /// property. After link creation, this can only be updated from the Display &amp;amp; Video 360 product. If
        /// this field is not set on create, it will be defaulted to true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("campaignDataSharingEnabled")]
        public virtual System.Nullable<bool> CampaignDataSharingEnabled { get; set; }

        /// <summary>
        /// Immutable. Enables the import of cost data from Display &amp;amp; Video 360 into the Google Analytics
        /// property. This can only be enabled if `campaign_data_sharing_enabled` is true. After link creation, this can
        /// only be updated from the Display &amp;amp; Video 360 product. If this field is not set on create, it will be
        /// defaulted to true.
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
    /// A proposal for a link between a Google Analytics property and a Display &amp;amp; Video 360 advertiser. A
    /// proposal is converted to a DisplayVideo360AdvertiserLink once approved. Google Analytics admins approve inbound
    /// proposals while Display &amp;amp; Video 360 admins approve outbound proposals.
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

    /// <summary>
    /// Singleton resource under a web DataStream, configuring measurement of additional site interactions and content.
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
        /// If enabled, capture a form interaction event each time a visitor interacts with a form on your website.
        /// False by default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formInteractionsEnabled")]
        public virtual System.Nullable<bool> FormInteractionsEnabled { get; set; }

        /// <summary>
        /// Output only. Resource name of the Enhanced Measurement Settings. Format:
        /// properties/{property_id}/dataStreams/{data_stream}/enhancedMeasurementSettings Example:
        /// "properties/1000/dataStreams/2000/enhancedMeasurementSettings"
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

    /// <summary>
    /// An Event Create Rule defines conditions that will trigger the creation of an entirely new event based upon
    /// matched criteria of a source event. Additional mutations of the parameters from the source event can be defined.
    /// Unlike Event Edit rules, Event Creation Rules have no defined order. They will all be run independently. Event
    /// Edit and Event Create rules can't be used to modify an event created from an Event Create rule.
    /// </summary>
    public class GoogleAnalyticsAdminV1alphaEventCreateRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The name of the new event to be created. This value must: * be less than 40 characters * consist
        /// only of letters, digits or _ (underscores) * start with a letter
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationEvent")]
        public virtual string DestinationEvent { get; set; }

        /// <summary>
        /// Required. Must have at least one condition, and can have up to 10 max. Conditions on the source event must
        /// match for this rule to be applied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventConditions")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaMatchingCondition> EventConditions { get; set; }

        /// <summary>
        /// Output only. Resource name for this EventCreateRule resource. Format:
        /// properties/{property}/dataStreams/{data_stream}/eventCreateRules/{event_create_rule}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Parameter mutations define parameter behavior on the new event, and are applied in order. A maximum of 20
        /// mutations can be applied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameterMutations")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaParameterMutation> ParameterMutations { get; set; }

        /// <summary>
        /// If true, the source parameters are copied to the new event. If false, or unset, all non-internal parameters
        /// are not copied from the source event. Parameter mutations are applied after the parameters have been copied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceCopyParameters")]
        public virtual System.Nullable<bool> SourceCopyParameters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An Event Edit Rule defines conditions that will trigger the creation of an entirely new event based upon matched
    /// criteria of a source event. Additional mutations of the parameters from the source event can be defined. Unlike
    /// Event Create rules, Event Edit Rules are applied in their defined order. Event Edit rules can't be used to
    /// modify an event created from an Event Create rule.
    /// </summary>
    public class GoogleAnalyticsAdminV1alphaEventEditRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The display name of this event edit rule. Maximum of 255 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Required. Conditions on the source event must match for this rule to be applied. Must have at least one
        /// condition, and can have up to 10 max.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventConditions")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaMatchingCondition> EventConditions { get; set; }

        /// <summary>
        /// Identifier. Resource name for this EventEditRule resource. Format:
        /// properties/{property}/dataStreams/{data_stream}/eventEditRules/{event_edit_rule}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. Parameter mutations define parameter behavior on the new event, and are applied in order. A
        /// maximum of 20 mutations can be applied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameterMutations")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaParameterMutation> ParameterMutations { get; set; }

        /// <summary>
        /// Output only. The order for which this rule will be processed. Rules with an order value lower than this will
        /// be processed before this rule, rules with an order value higher than this will be processed after this rule.
        /// New event edit rules will be assigned an order value at the end of the order. This value does not apply to
        /// event create rules.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processingOrder")]
        public virtual System.Nullable<long> ProcessingOrder { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Event setting conditions to match an event.</summary>
    public class GoogleAnalyticsAdminV1alphaEventMapping : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Name of the Google Analytics event. It must always be set. The max allowed display name length is
        /// 40 UTF-16 code units.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventName")]
        public virtual string EventName { get; set; }

        /// <summary>
        /// The maximum number of times the event occurred. If not set, maximum event count won't be checked.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxEventCount")]
        public virtual System.Nullable<long> MaxEventCount { get; set; }

        /// <summary>
        /// The maximum revenue generated due to the event. Revenue currency will be defined at the property level. If
        /// not set, maximum event value won't be checked.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxEventValue")]
        public virtual System.Nullable<double> MaxEventValue { get; set; }

        /// <summary>
        /// At least one of the following four min/max values must be set. The values set will be ANDed together to
        /// qualify an event. The minimum number of times the event occurred. If not set, minimum event count won't be
        /// checked.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minEventCount")]
        public virtual System.Nullable<long> MinEventCount { get; set; }

        /// <summary>
        /// The minimum revenue generated due to the event. Revenue currency will be defined at the property level. If
        /// not set, minimum event value won't be checked.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minEventValue")]
        public virtual System.Nullable<double> MinEventValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource message representing an `ExpandedDataSet`.</summary>
    public class GoogleAnalyticsAdminV1alphaExpandedDataSet : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _dataCollectionStartTimeRaw;

        private object _dataCollectionStartTime;

        /// <summary>Output only. Time when expanded data set began (or will begin) collecing data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataCollectionStartTime")]
        public virtual string DataCollectionStartTimeRaw
        {
            get => _dataCollectionStartTimeRaw;
            set
            {
                _dataCollectionStartTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _dataCollectionStartTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DataCollectionStartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DataCollectionStartTimeDateTimeOffset instead.")]
        public virtual object DataCollectionStartTime
        {
            get => _dataCollectionStartTime;
            set
            {
                _dataCollectionStartTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _dataCollectionStartTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="DataCollectionStartTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DataCollectionStartTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DataCollectionStartTimeRaw);
            set => DataCollectionStartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Optional. The description of the ExpandedDataSet. Max 50 chars.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Immutable. A logical expression of ExpandedDataSet filters applied to dimension included in the
        /// ExpandedDataSet. This filter is used to reduce the number of rows and thus the chance of encountering
        /// `other` row.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionFilterExpression")]
        public virtual GoogleAnalyticsAdminV1alphaExpandedDataSetFilterExpression DimensionFilterExpression { get; set; }

        /// <summary>
        /// Immutable. The list of dimensions included in the ExpandedDataSet. See the [API
        /// Dimensions](https://developers.google.com/analytics/devguides/reporting/data/v1/api-schema#dimensions) for
        /// the list of dimension names.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionNames")]
        public virtual System.Collections.Generic.IList<string> DimensionNames { get; set; }

        /// <summary>Required. The display name of the ExpandedDataSet. Max 200 chars.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Immutable. The list of metrics included in the ExpandedDataSet. See the [API
        /// Metrics](https://developers.google.com/analytics/devguides/reporting/data/v1/api-schema#metrics) for the
        /// list of dimension names.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricNames")]
        public virtual System.Collections.Generic.IList<string> MetricNames { get; set; }

        /// <summary>
        /// Output only. The resource name for this ExpandedDataSet resource. Format:
        /// properties/{property_id}/expandedDataSets/{expanded_data_set}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A specific filter for a single dimension</summary>
    public class GoogleAnalyticsAdminV1alphaExpandedDataSetFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The dimension name to filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldName")]
        public virtual string FieldName { get; set; }

        /// <summary>A filter for a string dimension that matches a particular list of options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inListFilter")]
        public virtual GoogleAnalyticsAdminV1alphaExpandedDataSetFilterInListFilter InListFilter { get; set; }

        /// <summary>A filter for a string-type dimension that matches a particular pattern.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringFilter")]
        public virtual GoogleAnalyticsAdminV1alphaExpandedDataSetFilterStringFilter StringFilter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A logical expression of EnhancedDataSet dimension filters.</summary>
    public class GoogleAnalyticsAdminV1alphaExpandedDataSetFilterExpression : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of expressions to be AND’ed together. It must contain a ExpandedDataSetFilterExpression with either
        /// not_expression or dimension_filter. This must be set for the top level ExpandedDataSetFilterExpression.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("andGroup")]
        public virtual GoogleAnalyticsAdminV1alphaExpandedDataSetFilterExpressionList AndGroup { get; set; }

        /// <summary>
        /// A filter on a single dimension. This cannot be set on the top level ExpandedDataSetFilterExpression.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual GoogleAnalyticsAdminV1alphaExpandedDataSetFilter Filter { get; set; }

        /// <summary>
        /// A filter expression to be NOT'ed (that is, inverted, complemented). It must include a dimension_filter. This
        /// cannot be set on the top level ExpandedDataSetFilterExpression.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notExpression")]
        public virtual GoogleAnalyticsAdminV1alphaExpandedDataSetFilterExpression NotExpression { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of ExpandedDataSet filter expressions.</summary>
    public class GoogleAnalyticsAdminV1alphaExpandedDataSetFilterExpressionList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of ExpandedDataSet filter expressions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterExpressions")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaExpandedDataSetFilterExpression> FilterExpressions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A filter for a string dimension that matches a particular list of options.</summary>
    public class GoogleAnalyticsAdminV1alphaExpandedDataSetFilterInListFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If true, the match is case-sensitive. If false, the match is case-insensitive. Must be true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caseSensitive")]
        public virtual System.Nullable<bool> CaseSensitive { get; set; }

        /// <summary>Required. The list of possible string values to match against. Must be non-empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A filter for a string-type dimension that matches a particular pattern.</summary>
    public class GoogleAnalyticsAdminV1alphaExpandedDataSetFilterStringFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If true, the match is case-sensitive. If false, the match is case-insensitive. Must be true when
        /// match_type is EXACT. Must be false when match_type is CONTAINS.
        /// </summary>
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

    /// <summary>Request for fetching the opt out status for the automated GA4 setup process.</summary>
    public class GoogleAnalyticsAdminV1alphaFetchAutomatedGa4ConfigurationOptOutRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The UA property to get the opt out status. Note this request uses the internal property ID, not
        /// the tracking ID of the form UA-XXXXXX-YY. Format: properties/{internalWebPropertyId} Example:
        /// properties/1234
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual string Property { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for fetching the opt out status for the automated GA4 setup process.</summary>
    public class GoogleAnalyticsAdminV1alphaFetchAutomatedGa4ConfigurationOptOutResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The opt out status for the UA property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optOut")]
        public virtual System.Nullable<bool> OptOut { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for looking up GA4 property connected to a UA property.</summary>
    public class GoogleAnalyticsAdminV1alphaFetchConnectedGa4PropertyResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The GA4 property connected to the UA property. An empty string is returned when there is no connected GA4
        /// property. Format: properties/{property_id} Example: properties/1234
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual string Property { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A link between a Google Analytics property and a Firebase project.</summary>
    public class GoogleAnalyticsAdminV1alphaFirebaseLink : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>A link between a Google Analytics property and a Google Ads account.</summary>
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

    /// <summary>The rules that govern how traffic is grouped into one channel.</summary>
    public class GoogleAnalyticsAdminV1alphaGroupingRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Customer defined display name for the channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Required. The Filter Expression that defines the Grouping Rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expression")]
        public virtual GoogleAnalyticsAdminV1alphaChannelGroupFilterExpression Expression { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A key event in a Google Analytics property.</summary>
    public class GoogleAnalyticsAdminV1alphaKeyEvent : Google.Apis.Requests.IDirectResponseSchema
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
        public virtual GoogleAnalyticsAdminV1alphaKeyEventDefaultValue DefaultValue { get; set; }

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
    public class GoogleAnalyticsAdminV1alphaKeyEventDefaultValue : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Response message for ListAccessBindings RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaListAccessBindingsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of AccessBindings. These will be ordered stably, but in an arbitrary order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessBindings")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaAccessBinding> AccessBindings { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

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

    /// <summary>Response message for ListAdSenseLinks method.</summary>
    public class GoogleAnalyticsAdminV1alphaListAdSenseLinksResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of AdSenseLinks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adsenseLinks")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaAdSenseLink> AdsenseLinks { get; set; }

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

    /// <summary>Response message for ListBigQueryLinks RPC</summary>
    public class GoogleAnalyticsAdminV1alphaListBigQueryLinksResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of BigQueryLinks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigqueryLinks")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaBigQueryLink> BigqueryLinks { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListCalculatedMetrics RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaListCalculatedMetricsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of CalculatedMetrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("calculatedMetrics")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaCalculatedMetric> CalculatedMetrics { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListChannelGroups RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaListChannelGroupsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of ChannelGroup. These will be ordered stably, but in an arbitrary order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelGroups")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaChannelGroup> ChannelGroups { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ListConnectedSiteTags RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaListConnectedSiteTagsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The Universal Analytics property to fetch connected site tags for. This does not work on GA4 properties. A
        /// maximum of 20 connected site tags will be returned. Example Format: `properties/1234`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual string Property { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListConnectedSiteTags RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaListConnectedSiteTagsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The site tags for the Universal Analytics property. A maximum of 20 connected site tags will be returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectedSiteTags")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaConnectedSiteTag> ConnectedSiteTags { get; set; }

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

    /// <summary>Response message for ListEventCreateRules RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaListEventCreateRulesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of EventCreateRules. These will be ordered stably, but in an arbitrary order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventCreateRules")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaEventCreateRule> EventCreateRules { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListEventEditRules RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaListEventEditRulesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of EventEditRules. These will be ordered stably, but in an arbitrary order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventEditRules")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaEventEditRule> EventEditRules { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListExpandedDataSets RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaListExpandedDataSetsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of ExpandedDataSet. These will be ordered stably, but in an arbitrary order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expandedDataSets")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaExpandedDataSet> ExpandedDataSets { get; set; }

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

    /// <summary>Response message for ListKeyEvents RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaListKeyEventsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The requested Key Events</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyEvents")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaKeyEvent> KeyEvents { get; set; }

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

    /// <summary>Response message for ListReportingDataAnnotation RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaListReportingDataAnnotationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of Reporting Data Annotations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportingDataAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaReportingDataAnnotation> ReportingDataAnnotations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListRollupPropertySourceLinks RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaListRollupPropertySourceLinksResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of RollupPropertySourceLinks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollupPropertySourceLinks")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaRollupPropertySourceLink> RollupPropertySourceLinks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListSKAdNetworkConversionValueSchemas RPC</summary>
    public class GoogleAnalyticsAdminV1alphaListSKAdNetworkConversionValueSchemasResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages. Currently, Google Analytics supports only one SKAdNetworkConversionValueSchema per
        /// dataStream, so this will never be populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of SKAdNetworkConversionValueSchemas. This will have at most one value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skadnetworkConversionValueSchemas")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaSKAdNetworkConversionValueSchema> SkadnetworkConversionValueSchemas { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListSearchAds360Links RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaListSearchAds360LinksResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of SearchAds360Links.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchAds360Links")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaSearchAds360Link> SearchAds360Links { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListSubpropertyEventFilter RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaListSubpropertyEventFiltersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of subproperty event filters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subpropertyEventFilters")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaSubpropertyEventFilter> SubpropertyEventFilters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListSubpropertySyncConfigs RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaListSubpropertySyncConfigsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of `SubpropertySyncConfig` resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subpropertySyncConfigs")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaSubpropertySyncConfig> SubpropertySyncConfigs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines a condition for when an Event Edit or Event Creation rule applies to an event.</summary>
    public class GoogleAnalyticsAdminV1alphaMatchingCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The type of comparison to be applied to the value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("comparisonType")]
        public virtual string ComparisonType { get; set; }

        /// <summary>
        /// Required. The name of the field that is compared against for the condition. If 'event_name' is specified
        /// this condition will apply to the name of the event. Otherwise the condition will apply to a parameter with
        /// the specified name. This value cannot contain spaces.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual string Field { get; set; }

        /// <summary>
        /// Whether or not the result of the comparison should be negated. For example, if `negated` is true, then
        /// 'equals' comparisons would function as 'not equals'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("negated")]
        public virtual System.Nullable<bool> Negated { get; set; }

        /// <summary>
        /// Required. The value being compared against for this condition. The runtime implementation may perform type
        /// coercion of this value to evaluate this condition based on the type of the parameter value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

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

    /// <summary>To represent a number.</summary>
    public class GoogleAnalyticsAdminV1alphaNumericValue : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Defines an event parameter to mutate.</summary>
    public class GoogleAnalyticsAdminV1alphaParameterMutation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The name of the parameter to mutate. This value must: * be less than 40 characters. * be unique
        /// across across all mutations within the rule * consist only of letters, digits or _ (underscores) For event
        /// edit rules, the name may also be set to 'event_name' to modify the event_name in place.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameter")]
        public virtual string Parameter { get; set; }

        /// <summary>
        /// Required. The value mutation to perform. * Must be less than 100 characters. * To specify a constant value
        /// for the param, use the value's string. * To copy value from another parameter, use syntax like
        /// "[[other_parameter]]" For more details, see this [help center
        /// article](https://support.google.com/analytics/answer/10085872#modify-an-event&amp;amp;zippy=%2Cin-this-article%2Cmodify-parameters).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameterValue")]
        public virtual string ParameterValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings for a SKAdNetwork conversion postback window.</summary>
    public class GoogleAnalyticsAdminV1alphaPostbackWindow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Ordering of the repeated field will be used to prioritize the conversion value settings. Lower indexed
        /// entries are prioritized higher. The first conversion value setting that evaluates to true will be selected.
        /// It must have at least one entry if enable_postback_window_settings is set to true. It can have maximum of
        /// 128 entries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionValues")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaConversionValues> ConversionValues { get; set; }

        /// <summary>
        /// If enable_postback_window_settings is true, conversion_values must be populated and will be used for
        /// determining when and how to set the Conversion Value on a client device and exporting schema to linked Ads
        /// accounts. If false, the settings are not used, but are retained in case they may be used in the future. This
        /// must always be true for postback_window_one.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postbackWindowSettingsEnabled")]
        public virtual System.Nullable<bool> PostbackWindowSettingsEnabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource message representing a Google Analytics property.</summary>
    public class GoogleAnalyticsAdminV1alphaProperty : Google.Apis.Requests.IDirectResponseSchema
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
        /// Redirect URI where the user will be sent after accepting Terms of Service. Must be configured in Cloud
        /// Console as a Redirect URI.
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

    /// <summary>Request message for CreateSubproperty RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaProvisionSubpropertyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The subproperty feature synchronization mode for Custom Dimensions and Metrics</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customDimensionAndMetricSynchronizationMode")]
        public virtual string CustomDimensionAndMetricSynchronizationMode { get; set; }

        /// <summary>Required. The subproperty to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subproperty")]
        public virtual GoogleAnalyticsAdminV1alphaProperty Subproperty { get; set; }

        /// <summary>Optional. The subproperty event filter to create on an ordinary property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subpropertyEventFilter")]
        public virtual GoogleAnalyticsAdminV1alphaSubpropertyEventFilter SubpropertyEventFilter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ProvisionSubproperty RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaProvisionSubpropertyResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The created subproperty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subproperty")]
        public virtual GoogleAnalyticsAdminV1alphaProperty Subproperty { get; set; }

        /// <summary>The created subproperty event filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subpropertyEventFilter")]
        public virtual GoogleAnalyticsAdminV1alphaSubpropertyEventFilter SubpropertyEventFilter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ReorderEventEditRules RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaReorderEventEditRulesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. EventEditRule resource names for the specified data stream, in the needed processing order. All
        /// EventEditRules for the stream must be present in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventEditRules")]
        public virtual System.Collections.Generic.IList<string> EventEditRules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Reporting Data Annotation is a comment connected to certain dates for reporting data.</summary>
    public class GoogleAnalyticsAdminV1alphaReportingDataAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If set, the Reporting Data Annotation is for a specific date represented by this field. The date must be a
        /// valid date with year, month and day set. The date may be in the past, present, or future.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationDate")]
        public virtual GoogleTypeDate AnnotationDate { get; set; }

        /// <summary>If set, the Reporting Data Annotation is for a range of dates represented by this field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationDateRange")]
        public virtual GoogleAnalyticsAdminV1alphaReportingDataAnnotationDateRange AnnotationDateRange { get; set; }

        /// <summary>Required. The color used for display of this Reporting Data Annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual string Color { get; set; }

        /// <summary>Optional. Description for this Reporting Data Annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Required. Identifier. Resource name of this Reporting Data Annotation. Format:
        /// 'properties/{property_id}/reportingDataAnnotations/{reporting_data_annotation}' Format:
        /// 'properties/123/reportingDataAnnotations/456'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. If true, this annotation was generated by the Google Analytics system. System-generated
        /// annotations cannot be updated or deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemGenerated")]
        public virtual System.Nullable<bool> SystemGenerated { get; set; }

        /// <summary>Required. Human-readable title for this Reporting Data Annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a Reporting Data Annotation's date range, both start and end dates are inclusive. Time zones are
    /// based on the parent property.
    /// </summary>
    public class GoogleAnalyticsAdminV1alphaReportingDataAnnotationDateRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The end date for this range. Must be a valid date with year, month, and day set. This date must be
        /// greater than or equal to the start date.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual GoogleTypeDate EndDate { get; set; }

        /// <summary>
        /// Required. The start date for this range. Must be a valid date with year, month, and day set. The date may be
        /// in the past, present, or future.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual GoogleTypeDate StartDate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A link that references a source property under the parent rollup property.</summary>
    public class GoogleAnalyticsAdminV1alphaRollupPropertySourceLink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Resource name of this RollupPropertySourceLink. Format:
        /// 'properties/{property_id}/rollupPropertySourceLinks/{rollup_property_source_link}' Format:
        /// 'properties/123/rollupPropertySourceLinks/456'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Immutable. Resource name of the source property. Format: properties/{property_id} Example: "properties/789"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceProperty")]
        public virtual string SourceProperty { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for a Data Access Record Report.</summary>
    public class GoogleAnalyticsAdminV1alphaRunAccessReportRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Date ranges of access records to read. If multiple date ranges are requested, each response row will contain
        /// a zero based date range index. If two date ranges overlap, the access records for the overlapping days is
        /// included in the response rows for both date ranges. Requests are allowed up to 2 date ranges.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateRanges")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaAccessDateRange> DateRanges { get; set; }

        /// <summary>
        /// Dimension filters let you restrict report response to specific dimension values which match the filter. For
        /// example, filtering on access records of a single user. To learn more, see [Fundamentals of Dimension
        /// Filters](https://developers.google.com/analytics/devguides/reporting/data/v1/basics#dimension_filters) for
        /// examples. Metrics cannot be used in this filter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionFilter")]
        public virtual GoogleAnalyticsAdminV1alphaAccessFilterExpression DimensionFilter { get; set; }

        /// <summary>
        /// The dimensions requested and displayed in the response. Requests are allowed up to 9 dimensions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaAccessDimension> Dimensions { get; set; }

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
        public virtual GoogleAnalyticsAdminV1alphaAccessFilterExpression MetricFilter { get; set; }

        /// <summary>
        /// The metrics requested and displayed in the response. Requests are allowed up to 10 metrics.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaAccessMetric> Metrics { get; set; }

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
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaAccessOrderBy> OrderBys { get; set; }

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
    public class GoogleAnalyticsAdminV1alphaRunAccessReportResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The header for a column in the report that corresponds to a specific dimension. The number of
        /// DimensionHeaders and ordering of DimensionHeaders matches the dimensions present in rows.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionHeaders")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaAccessDimensionHeader> DimensionHeaders { get; set; }

        /// <summary>
        /// The header for a column in the report that corresponds to a specific metric. The number of MetricHeaders and
        /// ordering of MetricHeaders matches the metrics present in rows.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricHeaders")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaAccessMetricHeader> MetricHeaders { get; set; }

        /// <summary>
        /// The quota state for this Analytics property including this request. This field doesn't work with
        /// account-level requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quota")]
        public virtual GoogleAnalyticsAdminV1alphaAccessQuota Quota { get; set; }

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
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaAccessRow> Rows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SKAdNetwork conversion value schema of an iOS stream.</summary>
    public class GoogleAnalyticsAdminV1alphaSKAdNetworkConversionValueSchema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If enabled, the GA SDK will set conversion values using this schema definition, and schema will be exported
        /// to any Google Ads accounts linked to this property. If disabled, the GA SDK will not automatically set
        /// conversion values, and also the schema will not be exported to Ads.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applyConversionValues")]
        public virtual System.Nullable<bool> ApplyConversionValues { get; set; }

        /// <summary>
        /// Output only. Resource name of the schema. This will be child of ONLY an iOS stream, and there can be at most
        /// one such child under an iOS stream. Format:
        /// properties/{property}/dataStreams/{dataStream}/sKAdNetworkConversionValueSchema
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. The conversion value settings for the first postback window. These differ from values for postback
        /// window two and three in that they contain a "Fine" grained conversion value (a numeric value). Conversion
        /// values for this postback window must be set. The other windows are optional and may inherit this window's
        /// settings if unset or disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postbackWindowOne")]
        public virtual GoogleAnalyticsAdminV1alphaPostbackWindow PostbackWindowOne { get; set; }

        /// <summary>
        /// The conversion value settings for the third postback window. This field should only be set if the user chose
        /// to define different conversion values for this postback window. It is allowed to configure window 3 without
        /// setting window 2. In case window 1 &amp;amp; 2 settings are set and enable_postback_window_settings for this
        /// postback window is set to false, the schema will inherit settings from postback_window_two.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postbackWindowThree")]
        public virtual GoogleAnalyticsAdminV1alphaPostbackWindow PostbackWindowThree { get; set; }

        /// <summary>
        /// The conversion value settings for the second postback window. This field should only be configured if there
        /// is a need to define different conversion values for this postback window. If enable_postback_window_settings
        /// is set to false for this postback window, the values from postback_window_one will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postbackWindowTwo")]
        public virtual GoogleAnalyticsAdminV1alphaPostbackWindow PostbackWindowTwo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A link between a Google Analytics property and a Search Ads 360 entity.</summary>
    public class GoogleAnalyticsAdminV1alphaSearchAds360Link : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Enables personalized advertising features with this integration. If this field is not set on create, it will
        /// be defaulted to true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adsPersonalizationEnabled")]
        public virtual System.Nullable<bool> AdsPersonalizationEnabled { get; set; }

        /// <summary>
        /// Output only. The display name of the Search Ads 360 Advertiser. Allows users to easily identify the linked
        /// resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserDisplayName")]
        public virtual string AdvertiserDisplayName { get; set; }

        /// <summary>
        /// Immutable. This field represents the Advertiser ID of the Search Ads 360 Advertiser. that has been linked.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserId")]
        public virtual string AdvertiserId { get; set; }

        /// <summary>
        /// Immutable. Enables the import of campaign data from Search Ads 360 into the Google Analytics property. After
        /// link creation, this can only be updated from the Search Ads 360 product. If this field is not set on create,
        /// it will be defaulted to true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("campaignDataSharingEnabled")]
        public virtual System.Nullable<bool> CampaignDataSharingEnabled { get; set; }

        /// <summary>
        /// Immutable. Enables the import of cost data from Search Ads 360 to the Google Analytics property. This can
        /// only be enabled if campaign_data_sharing_enabled is enabled. After link creation, this can only be updated
        /// from the Search Ads 360 product. If this field is not set on create, it will be defaulted to true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("costDataSharingEnabled")]
        public virtual System.Nullable<bool> CostDataSharingEnabled { get; set; }

        /// <summary>
        /// Output only. The resource name for this SearchAds360Link resource. Format:
        /// properties/{propertyId}/searchAds360Links/{linkId} Note: linkId is not the Search Ads 360 advertiser ID
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Enables export of site stats with this integration. If this field is not set on create, it will be defaulted
        /// to true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("siteStatsSharingEnabled")]
        public virtual System.Nullable<bool> SiteStatsSharingEnabled { get; set; }

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

    /// <summary>Request for setting the opt out status for the automated GA4 setup process.</summary>
    public class GoogleAnalyticsAdminV1alphaSetAutomatedGa4ConfigurationOptOutRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status to set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optOut")]
        public virtual System.Nullable<bool> OptOut { get; set; }

        /// <summary>
        /// Required. The UA property to set the opt out status. Note this request uses the internal property ID, not
        /// the tracking ID of the form UA-XXXXXX-YY. Format: properties/{internalWebPropertyId} Example:
        /// properties/1234
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual string Property { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for setting the opt out status for the automated GA4 setup process.</summary>
    public class GoogleAnalyticsAdminV1alphaSetAutomatedGa4ConfigurationOptOutResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource message representing a Google Analytics subproperty event filter.</summary>
    public class GoogleAnalyticsAdminV1alphaSubpropertyEventFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Immutable. Resource name of the Subproperty that uses this filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applyToProperty")]
        public virtual string ApplyToProperty { get; set; }

        /// <summary>
        /// Required. Unordered list. Filter clauses that define the SubpropertyEventFilter. All clauses are AND'ed
        /// together to determine what data is sent to the subproperty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterClauses")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaSubpropertyEventFilterClause> FilterClauses { get; set; }

        /// <summary>
        /// Output only. Format: properties/{ordinary_property_id}/subpropertyEventFilters/{sub_property_event_filter}
        /// Example: properties/1234/subpropertyEventFilters/5678
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A clause for defining a filter. A filter may be inclusive (events satisfying the filter clause are included in
    /// the subproperty's data) or exclusive (events satisfying the filter clause are excluded from the subproperty's
    /// data).
    /// </summary>
    public class GoogleAnalyticsAdminV1alphaSubpropertyEventFilterClause : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The type for the filter clause.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterClauseType")]
        public virtual string FilterClauseType { get; set; }

        /// <summary>Required. The logical expression for what events are sent to the subproperty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterExpression")]
        public virtual GoogleAnalyticsAdminV1alphaSubpropertyEventFilterExpression FilterExpression { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A specific filter expression</summary>
    public class GoogleAnalyticsAdminV1alphaSubpropertyEventFilterCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The field that is being filtered.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldName")]
        public virtual string FieldName { get; set; }

        /// <summary>A filter for null values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nullFilter")]
        public virtual System.Nullable<bool> NullFilter { get; set; }

        /// <summary>A filter for a string-type dimension that matches a particular pattern.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringFilter")]
        public virtual GoogleAnalyticsAdminV1alphaSubpropertyEventFilterConditionStringFilter StringFilter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A filter for a string-type dimension that matches a particular pattern.</summary>
    public class GoogleAnalyticsAdminV1alphaSubpropertyEventFilterConditionStringFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If true, the string value is case sensitive. If false, the match is case-insensitive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caseSensitive")]
        public virtual System.Nullable<bool> CaseSensitive { get; set; }

        /// <summary>Required. The match type for the string filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchType")]
        public virtual string MatchType { get; set; }

        /// <summary>Required. The string value used for the matching.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A logical expression of Subproperty event filters.</summary>
    public class GoogleAnalyticsAdminV1alphaSubpropertyEventFilterExpression : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Creates a filter that matches a specific event. This cannot be set on the top level
        /// SubpropertyEventFilterExpression.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterCondition")]
        public virtual GoogleAnalyticsAdminV1alphaSubpropertyEventFilterCondition FilterCondition { get; set; }

        /// <summary>
        /// A filter expression to be NOT'ed (inverted, complemented). It can only include a filter. This cannot be set
        /// on the top level SubpropertyEventFilterExpression.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notExpression")]
        public virtual GoogleAnalyticsAdminV1alphaSubpropertyEventFilterExpression NotExpression { get; set; }

        /// <summary>
        /// A list of expressions to OR’ed together. Must only contain not_expression or filter_condition expressions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orGroup")]
        public virtual GoogleAnalyticsAdminV1alphaSubpropertyEventFilterExpressionList OrGroup { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of Subproperty event filter expressions.</summary>
    public class GoogleAnalyticsAdminV1alphaSubpropertyEventFilterExpressionList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Unordered list. A list of Subproperty event filter expressions</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterExpressions")]
        public virtual System.Collections.Generic.IList<GoogleAnalyticsAdminV1alphaSubpropertyEventFilterExpression> FilterExpressions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Subproperty synchronization configuration controls how ordinary property configurations are synchronized to
    /// subproperties. This resource is provisioned automatically for each subproperty.
    /// </summary>
    public class GoogleAnalyticsAdminV1alphaSubpropertySyncConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Immutable. Resource name of the subproperty that these settings apply to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applyToProperty")]
        public virtual string ApplyToProperty { get; set; }

        /// <summary>
        /// Required. Specifies the Custom Dimension / Metric synchronization mode for the subproperty. If set to ALL,
        /// Custom Dimension / Metric synchronization will be immediately enabled. Local configuration of Custom
        /// Dimensions / Metrics will not be allowed on the subproperty so long as the synchronization mode is set to
        /// ALL. If set to NONE, Custom Dimensions / Metric synchronization is disabled. Custom Dimensions / Metrics
        /// must be configured explicitly on the Subproperty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customDimensionAndMetricSyncMode")]
        public virtual string CustomDimensionAndMetricSyncMode { get; set; }

        /// <summary>
        /// Output only. Identifier. Format: properties/{ordinary_property_id}/subpropertySyncConfigs/{subproperty_id}
        /// Example: properties/1234/subpropertySyncConfigs/5678
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for UpdateAccessBinding RPC.</summary>
    public class GoogleAnalyticsAdminV1alphaUpdateAccessBindingRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The access binding to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessBinding")]
        public virtual GoogleAnalyticsAdminV1alphaAccessBinding AccessBinding { get; set; }

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

    /// <summary>
    /// Represents a whole or partial calendar date, such as a birthday. The time of day and time zone are either
    /// specified elsewhere or are insignificant. The date is relative to the Gregorian Calendar. This can represent one
    /// of the following: * A full date, with non-zero year, month, and day values. * A month and day, with a zero year
    /// (for example, an anniversary). * A year on its own, with a zero month and a zero day. * A year and month, with a
    /// zero day (for example, a credit card expiration date). Related types: * google.type.TimeOfDay *
    /// google.type.DateTime * google.protobuf.Timestamp
    /// </summary>
    public class GoogleTypeDate : Google.Apis.Requests.IDirectResponseSchema
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
}
