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

namespace Google.Apis.MyBusinessAccountManagement.v1
{
    /// <summary>The MyBusinessAccountManagement Service.</summary>
    public class MyBusinessAccountManagementService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public MyBusinessAccountManagementService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public MyBusinessAccountManagementService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Accounts = new AccountsResource(this);
            Locations = new LocationsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "mybusinessaccountmanagement";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://mybusinessaccountmanagement.googleapis.com/";
        #else
            "https://mybusinessaccountmanagement.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://mybusinessaccountmanagement.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Gets the Accounts resource.</summary>
        public virtual AccountsResource Accounts { get; }

        /// <summary>Gets the Locations resource.</summary>
        public virtual LocationsResource Locations { get; }
    }

    /// <summary>A base abstract class for MyBusinessAccountManagement requests.</summary>
    public abstract class MyBusinessAccountManagementBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new MyBusinessAccountManagementBaseServiceRequest instance.</summary>
        protected MyBusinessAccountManagementBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes MyBusinessAccountManagement parameter list.</summary>
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
            Admins = new AdminsResource(service);
            Invitations = new InvitationsResource(service);
        }

        /// <summary>Gets the Admins resource.</summary>
        public virtual AdminsResource Admins { get; }

        /// <summary>The "admins" collection of methods.</summary>
        public class AdminsResource
        {
            private const string Resource = "admins";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AdminsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Invites the specified user to become an administrator for the specified account. The invitee must accept
            /// the invitation in order to be granted access to the account. See AcceptInvitation to programmatically
            /// accept an invitation.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The resource name of the account this admin is created for. `accounts/{account_id}`.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.MyBusinessAccountManagement.v1.Data.Admin body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Invites the specified user to become an administrator for the specified account. The invitee must accept
            /// the invitation in order to be granted access to the account. See AcceptInvitation to programmatically
            /// accept an invitation.
            /// </summary>
            public class CreateRequest : MyBusinessAccountManagementBaseServiceRequest<Google.Apis.MyBusinessAccountManagement.v1.Data.Admin>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.MyBusinessAccountManagement.v1.Data.Admin body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the account this admin is created for. `accounts/{account_id}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.MyBusinessAccountManagement.v1.Data.Admin Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/admins";

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

            /// <summary>Removes the specified admin from the specified account.</summary>
            /// <param name="name">
            /// Required. The resource name of the admin to remove from the account.
            /// `accounts/{account_id}/admins/{admin_id}`.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Removes the specified admin from the specified account.</summary>
            public class DeleteRequest : MyBusinessAccountManagementBaseServiceRequest<Google.Apis.MyBusinessAccountManagement.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the admin to remove from the account.
                /// `accounts/{account_id}/admins/{admin_id}`.
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
                        Pattern = @"^accounts/[^/]+/admins/[^/]+$",
                    });
                }
            }

            /// <summary>Lists the admins for the specified account.</summary>
            /// <param name="parent">
            /// Required. The name of the account from which to retrieve a list of admins.
            /// `accounts/{account_id}/admins`.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists the admins for the specified account.</summary>
            public class ListRequest : MyBusinessAccountManagementBaseServiceRequest<Google.Apis.MyBusinessAccountManagement.v1.Data.ListAccountAdminsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the account from which to retrieve a list of admins.
                /// `accounts/{account_id}/admins`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/admins";

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
                }
            }

            /// <summary>Updates the Admin for the specified Account Admin.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Immutable. The resource name. For account admins, this is in the form:
            /// `accounts/{account_id}/admins/{admin_id}` For location admins, this is in the form:
            /// `locations/{location_id}/admins/{admin_id}` This field will be ignored if set during admin creation.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.MyBusinessAccountManagement.v1.Data.Admin body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates the Admin for the specified Account Admin.</summary>
            public class PatchRequest : MyBusinessAccountManagementBaseServiceRequest<Google.Apis.MyBusinessAccountManagement.v1.Data.Admin>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.MyBusinessAccountManagement.v1.Data.Admin body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Immutable. The resource name. For account admins, this is in the form:
                /// `accounts/{account_id}/admins/{admin_id}` For location admins, this is in the form:
                /// `locations/{location_id}/admins/{admin_id}` This field will be ignored if set during admin creation.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Required. The specific fields that should be updated. The only editable field is role.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.MyBusinessAccountManagement.v1.Data.Admin Body { get; set; }

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
                        Pattern = @"^accounts/[^/]+/admins/[^/]+$",
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

            /// <summary>Accepts the specified invitation.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The name of the invitation that is being accepted.
            /// `accounts/{account_id}/invitations/{invitation_id}`
            /// </param>
            public virtual AcceptRequest Accept(Google.Apis.MyBusinessAccountManagement.v1.Data.AcceptInvitationRequest body, string name)
            {
                return new AcceptRequest(service, body, name);
            }

            /// <summary>Accepts the specified invitation.</summary>
            public class AcceptRequest : MyBusinessAccountManagementBaseServiceRequest<Google.Apis.MyBusinessAccountManagement.v1.Data.Empty>
            {
                /// <summary>Constructs a new Accept request.</summary>
                public AcceptRequest(Google.Apis.Services.IClientService service, Google.Apis.MyBusinessAccountManagement.v1.Data.AcceptInvitationRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the invitation that is being accepted.
                /// `accounts/{account_id}/invitations/{invitation_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.MyBusinessAccountManagement.v1.Data.AcceptInvitationRequest Body { get; set; }

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
                        Pattern = @"^accounts/[^/]+/invitations/[^/]+$",
                    });
                }
            }

            /// <summary>Declines the specified invitation.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The name of the account invitation that is being declined.
            /// `accounts/{account_id}/invitations/{invitation_id}`
            /// </param>
            public virtual DeclineRequest Decline(Google.Apis.MyBusinessAccountManagement.v1.Data.DeclineInvitationRequest body, string name)
            {
                return new DeclineRequest(service, body, name);
            }

            /// <summary>Declines the specified invitation.</summary>
            public class DeclineRequest : MyBusinessAccountManagementBaseServiceRequest<Google.Apis.MyBusinessAccountManagement.v1.Data.Empty>
            {
                /// <summary>Constructs a new Decline request.</summary>
                public DeclineRequest(Google.Apis.Services.IClientService service, Google.Apis.MyBusinessAccountManagement.v1.Data.DeclineInvitationRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the account invitation that is being declined.
                /// `accounts/{account_id}/invitations/{invitation_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.MyBusinessAccountManagement.v1.Data.DeclineInvitationRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "decline";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:decline";

                /// <summary>Initializes Decline parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+/invitations/[^/]+$",
                    });
                }
            }

            /// <summary>Lists pending invitations for the specified account.</summary>
            /// <param name="parent">
            /// Required. The name of the account from which the list of invitations is being retrieved.
            /// `accounts/{account_id}/invitations`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists pending invitations for the specified account.</summary>
            public class ListRequest : MyBusinessAccountManagementBaseServiceRequest<Google.Apis.MyBusinessAccountManagement.v1.Data.ListInvitationsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the account from which the list of invitations is being retrieved.
                /// `accounts/{account_id}/invitations`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. Filtering the response is supported via the Invitation.target_type field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/invitations";

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
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>
        /// Creates an account with the specified name and type under the given parent. - Personal accounts and
        /// Organizations cannot be created. - User Groups cannot be created with a Personal account as primary owner. -
        /// Location Groups cannot be created with a primary owner of a Personal account if the Personal account is in
        /// an Organization. - Location Groups cannot own Location Groups.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.MyBusinessAccountManagement.v1.Data.Account body)
        {
            return new CreateRequest(service, body);
        }

        /// <summary>
        /// Creates an account with the specified name and type under the given parent. - Personal accounts and
        /// Organizations cannot be created. - User Groups cannot be created with a Personal account as primary owner. -
        /// Location Groups cannot be created with a primary owner of a Personal account if the Personal account is in
        /// an Organization. - Location Groups cannot own Location Groups.
        /// </summary>
        public class CreateRequest : MyBusinessAccountManagementBaseServiceRequest<Google.Apis.MyBusinessAccountManagement.v1.Data.Account>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.MyBusinessAccountManagement.v1.Data.Account body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.MyBusinessAccountManagement.v1.Data.Account Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/accounts";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Gets the specified account. Returns `NOT_FOUND` if the account does not exist or if the caller does not have
        /// access rights to it.
        /// </summary>
        /// <param name="name">Required. The name of the account to fetch.</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>
        /// Gets the specified account. Returns `NOT_FOUND` if the account does not exist or if the caller does not have
        /// access rights to it.
        /// </summary>
        public class GetRequest : MyBusinessAccountManagementBaseServiceRequest<Google.Apis.MyBusinessAccountManagement.v1.Data.Account>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. The name of the account to fetch.</summary>
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
                    Pattern = @"^accounts/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Lists all of the accounts for the authenticated user. This includes all accounts that the user owns, as well
        /// as any accounts for which the user has management rights.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>
        /// Lists all of the accounts for the authenticated user. This includes all accounts that the user owns, as well
        /// as any accounts for which the user has management rights.
        /// </summary>
        public class ListRequest : MyBusinessAccountManagementBaseServiceRequest<Google.Apis.MyBusinessAccountManagement.v1.Data.ListAccountsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional. A filter constraining the accounts to return. The response includes only entries that match
            /// the filter. If `filter` is empty, then no constraints are applied and all accounts (paginated) are
            /// retrieved for the requested account. For example, a request with the filter `type=USER_GROUP` will only
            /// return user groups. The `type` field is the only supported filter.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>
            /// Optional. How many accounts to fetch per page. The minimum supported page_size is 2. The default and
            /// maximum is 20.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. If specified, the next page of accounts is retrieved. The `pageToken` is returned when a call
            /// to `accounts.list` returns more results than can fit into the requested page size.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Optional. The resource name of the account for which the list of directly accessible accounts is to be
            /// retrieved. This only makes sense for Organizations and User Groups. If empty, will return `ListAccounts`
            /// for the authenticated user. `accounts/{account_id}`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parentAccount", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ParentAccount { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/accounts";

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
                RequestParameters.Add("parentAccount", new Google.Apis.Discovery.Parameter
                {
                    Name = "parentAccount",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates the specified business account. Personal accounts cannot be updated using this method.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">Immutable. The resource name, in the format `accounts/{account_id}`.</param>
        public virtual PatchRequest Patch(Google.Apis.MyBusinessAccountManagement.v1.Data.Account body, string name)
        {
            return new PatchRequest(service, body, name);
        }

        /// <summary>
        /// Updates the specified business account. Personal accounts cannot be updated using this method.
        /// </summary>
        public class PatchRequest : MyBusinessAccountManagementBaseServiceRequest<Google.Apis.MyBusinessAccountManagement.v1.Data.Account>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.MyBusinessAccountManagement.v1.Data.Account body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>Immutable. The resource name, in the format `accounts/{account_id}`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// Required. The specific fields that should be updated. The only editable field is `accountName`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Optional. If true, the request is validated without actually updating the account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ValidateOnly { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.MyBusinessAccountManagement.v1.Data.Account Body { get; set; }

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

    /// <summary>The "locations" collection of methods.</summary>
    public class LocationsResource
    {
        private const string Resource = "locations";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public LocationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Admins = new AdminsResource(service);
        }

        /// <summary>Gets the Admins resource.</summary>
        public virtual AdminsResource Admins { get; }

        /// <summary>The "admins" collection of methods.</summary>
        public class AdminsResource
        {
            private const string Resource = "admins";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AdminsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Invites the specified user to become an administrator for the specified location. The invitee must
            /// accept the invitation in order to be granted access to the location. See AcceptInvitation to
            /// programmatically accept an invitation.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The resource name of the location this admin is created for. `locations/{location_id}/admins`.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.MyBusinessAccountManagement.v1.Data.Admin body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Invites the specified user to become an administrator for the specified location. The invitee must
            /// accept the invitation in order to be granted access to the location. See AcceptInvitation to
            /// programmatically accept an invitation.
            /// </summary>
            public class CreateRequest : MyBusinessAccountManagementBaseServiceRequest<Google.Apis.MyBusinessAccountManagement.v1.Data.Admin>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.MyBusinessAccountManagement.v1.Data.Admin body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the location this admin is created for.
                /// `locations/{location_id}/admins`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.MyBusinessAccountManagement.v1.Data.Admin Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/admins";

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
                        Pattern = @"^locations/[^/]+$",
                    });
                }
            }

            /// <summary>Removes the specified admin as a manager of the specified location.</summary>
            /// <param name="name">Required. The resource name of the admin to remove from the location.</param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Removes the specified admin as a manager of the specified location.</summary>
            public class DeleteRequest : MyBusinessAccountManagementBaseServiceRequest<Google.Apis.MyBusinessAccountManagement.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. The resource name of the admin to remove from the location.</summary>
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
                        Pattern = @"^locations/[^/]+/admins/[^/]+$",
                    });
                }
            }

            /// <summary>Lists all of the admins for the specified location.</summary>
            /// <param name="parent">
            /// Required. The name of the location to list admins of. `locations/{location_id}/admins`.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists all of the admins for the specified location.</summary>
            public class ListRequest : MyBusinessAccountManagementBaseServiceRequest<Google.Apis.MyBusinessAccountManagement.v1.Data.ListLocationAdminsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the location to list admins of. `locations/{location_id}/admins`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/admins";

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
                        Pattern = @"^locations/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Updates the Admin for the specified location. Only the AdminRole of the Admin can be updated.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Immutable. The resource name. For account admins, this is in the form:
            /// `accounts/{account_id}/admins/{admin_id}` For location admins, this is in the form:
            /// `locations/{location_id}/admins/{admin_id}` This field will be ignored if set during admin creation.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.MyBusinessAccountManagement.v1.Data.Admin body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>
            /// Updates the Admin for the specified location. Only the AdminRole of the Admin can be updated.
            /// </summary>
            public class PatchRequest : MyBusinessAccountManagementBaseServiceRequest<Google.Apis.MyBusinessAccountManagement.v1.Data.Admin>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.MyBusinessAccountManagement.v1.Data.Admin body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Immutable. The resource name. For account admins, this is in the form:
                /// `accounts/{account_id}/admins/{admin_id}` For location admins, this is in the form:
                /// `locations/{location_id}/admins/{admin_id}` This field will be ignored if set during admin creation.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Required. The specific fields that should be updated. The only editable field is role.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.MyBusinessAccountManagement.v1.Data.Admin Body { get; set; }

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
                        Pattern = @"^locations/[^/]+/admins/[^/]+$",
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
        /// Moves a location from an account that the user owns to another account that the same user administers. The
        /// user must be an owner of the account the location is currently associated with and must also be at least a
        /// manager of the destination account.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">Required. The name of the location to transfer. `locations/{location_id}`.</param>
        public virtual TransferRequest Transfer(Google.Apis.MyBusinessAccountManagement.v1.Data.TransferLocationRequest body, string name)
        {
            return new TransferRequest(service, body, name);
        }

        /// <summary>
        /// Moves a location from an account that the user owns to another account that the same user administers. The
        /// user must be an owner of the account the location is currently associated with and must also be at least a
        /// manager of the destination account.
        /// </summary>
        public class TransferRequest : MyBusinessAccountManagementBaseServiceRequest<Google.Apis.MyBusinessAccountManagement.v1.Data.Empty>
        {
            /// <summary>Constructs a new Transfer request.</summary>
            public TransferRequest(Google.Apis.Services.IClientService service, Google.Apis.MyBusinessAccountManagement.v1.Data.TransferLocationRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The name of the location to transfer. `locations/{location_id}`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.MyBusinessAccountManagement.v1.Data.TransferLocationRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "transfer";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}:transfer";

            /// <summary>Initializes Transfer parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^locations/[^/]+$",
                });
            }
        }
    }
}
namespace Google.Apis.MyBusinessAccountManagement.v1.Data
{
    /// <summary>Request message for AccessControl.AcceptInvitation.</summary>
    public class AcceptInvitationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An account is a container for your location. If you are the only user who manages locations for your business,
    /// you can use your personal Google Account. To share management of locations with multiple users, [create a
    /// business account] (https://support.google.com/business/answer/6085339?ref_topic=6085325).
    /// </summary>
    public class Account : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The name of the account. For an account of type `PERSONAL`, this is the first and last name of the
        /// user account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountName")]
        public virtual string AccountName { get; set; }

        /// <summary>Output only. Account reference number if provisioned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountNumber")]
        public virtual string AccountNumber { get; set; }

        /// <summary>Immutable. The resource name, in the format `accounts/{account_id}`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Additional info for an organization. This is populated only for an organization account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organizationInfo")]
        public virtual OrganizationInfo OrganizationInfo { get; set; }

        /// <summary>Output only. Specifies the permission level the user has for this account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissionLevel")]
        public virtual string PermissionLevel { get; set; }

        /// <summary>
        /// Required. Input only. The resource name of the account which will be the primary owner of the account being
        /// created. It should be of the form `accounts/{account_id}/`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryOwner")]
        public virtual string PrimaryOwner { get; set; }

        /// <summary>Output only. Specifies the AccountRole of this account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>
        /// Required. Contains the type of account. Accounts of type PERSONAL and ORGANIZATION cannot be created using
        /// this API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// Output only. If verified, future locations that are created are automatically connected to Google Maps, and
        /// have Google+ pages created, without requiring moderation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verificationState")]
        public virtual string VerificationState { get; set; }

        /// <summary>
        /// Output only. Indicates whether the account is vetted by Google. A vetted account is able to verify locations
        /// via the VETTED_PARTNER method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vettedState")]
        public virtual string VettedState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An administrator of an Account or a location.</summary>
    public class Admin : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The name of the admin. When making the initial invitation, this is the invitee's email address. On
        /// `GET` calls, the user's email address is returned if the invitation is still pending. Otherwise, it contains
        /// the user's first and last names. This field is only needed to be set during admin creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("admin")]
        public virtual string AdminValue { get; set; }

        /// <summary>
        /// Immutable. The resource name. For account admins, this is in the form:
        /// `accounts/{account_id}/admins/{admin_id}` For location admins, this is in the form:
        /// `locations/{location_id}/admins/{admin_id}` This field will be ignored if set during admin creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Indicates whether this admin has a pending invitation for the specified resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pendingInvitation")]
        public virtual System.Nullable<bool> PendingInvitation { get; set; }

        /// <summary>Required. Specifies the role that this admin uses with the specified Account or Location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for AccessControl.DeclineInvitation.</summary>
    public class DeclineInvitationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
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

    /// <summary>Represents a pending invitation.</summary>
    public class Invitation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The resource name for the invitation. `accounts/{account_id}/invitations/{invitation_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The invited role on the account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The sparsely populated account this invitation is for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetAccount")]
        public virtual Account TargetAccount { get; set; }

        /// <summary>The target location this invitation is for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetLocation")]
        public virtual TargetLocation TargetLocation { get; set; }

        /// <summary>Output only. Specifies which target types should appear in the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetType")]
        public virtual string TargetType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for AccessControl.ListAccountAdmins.</summary>
    public class ListAccountAdminsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A collection of Admin instances.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountAdmins")]
        public virtual System.Collections.Generic.IList<Admin> AccountAdmins { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for Accounts.ListAccounts.</summary>
    public class ListAccountsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A collection of accounts to which the user has access. The personal account of the user doing the query will
        /// always be the first item of the result, unless it is filtered out.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accounts")]
        public virtual System.Collections.Generic.IList<Account> Accounts { get; set; }

        /// <summary>
        /// If the number of accounts exceeds the requested page size, this field is populated with a token to fetch the
        /// next page of accounts on a subsequent call to `accounts.list`. If there are no more accounts, this field is
        /// not present in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for AccessControl.ListInvitations.</summary>
    public class ListInvitationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A collection of invitations that are pending for the account. The number of invitations listed here cannot
        /// exceed 1000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invitations")]
        public virtual System.Collections.Generic.IList<Invitation> Invitations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for AccessControl.ListLocationAdmins.</summary>
    public class ListLocationAdminsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A collection of Admins.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("admins")]
        public virtual System.Collections.Generic.IList<Admin> Admins { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional information stored for an organization.</summary>
    public class OrganizationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The postal address for the account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual PostalAddress Address { get; set; }

        /// <summary>Output only. The contact number for the organization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneNumber")]
        public virtual string PhoneNumber { get; set; }

        /// <summary>Output only. The registered domain for the account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("registeredDomain")]
        public virtual string RegisteredDomain { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a postal address, e.g. for postal delivery or payments addresses. Given a postal address, a postal
    /// service can deliver items to a premise, P.O. Box or similar. It is not intended to model geographical locations
    /// (roads, towns, mountains). In typical usage an address would be created via user input or from importing
    /// existing data, depending on the type of process. Advice on address input / editing: - Use an i18n-ready address
    /// widget such as https://github.com/google/libaddressinput) - Users should not be presented with UI elements for
    /// input or editing of fields outside countries where that field is used. For more guidance on how to use this
    /// schema, please see: https://support.google.com/business/answer/6397478
    /// </summary>
    public class PostalAddress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Unstructured address lines describing the lower levels of an address. Because values in address_lines do not
        /// have type information and may sometimes contain multiple values in a single field (e.g. "Austin, TX"), it is
        /// important that the line order is clear. The order of address lines should be "envelope order" for the
        /// country/region of the address. In places where this can vary (e.g. Japan), address_language is used to make
        /// it explicit (e.g. "ja" for large-to-small ordering and "ja-Latn" or "en" for small-to-large). This way, the
        /// most specific line of an address can be selected based on the language. The minimum permitted structural
        /// representation of an address consists of a region_code with all remaining information placed in the
        /// address_lines. It would be possible to format such an address very approximately without geocoding, but no
        /// semantic reasoning could be made about any of the address components until it was at least partially
        /// resolved. Creating an address only containing a region_code and address_lines, and then geocoding is the
        /// recommended way to handle completely unstructured addresses (as opposed to guessing which parts of the
        /// address should be localities or administrative areas).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addressLines")]
        public virtual System.Collections.Generic.IList<string> AddressLines { get; set; }

        /// <summary>
        /// Optional. Highest administrative subdivision which is used for postal addresses of a country or region. For
        /// example, this can be a state, a province, an oblast, or a prefecture. Specifically, for Spain this is the
        /// province and not the autonomous community (e.g. "Barcelona" and not "Catalonia"). Many countries don't use
        /// an administrative area in postal addresses. E.g. in Switzerland this should be left unpopulated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("administrativeArea")]
        public virtual string AdministrativeArea { get; set; }

        /// <summary>
        /// Optional. BCP-47 language code of the contents of this address (if known). This is often the UI language of
        /// the input form or is expected to match one of the languages used in the address' country/region, or their
        /// transliterated equivalents. This can affect formatting in certain countries, but is not critical to the
        /// correctness of the data and will never affect any validation or other non-formatting related operations. If
        /// this value is not known, it should be omitted (rather than specifying a possibly incorrect default).
        /// Examples: "zh-Hant", "ja", "ja-Latn", "en".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// Optional. Generally refers to the city/town portion of the address. Examples: US city, IT comune, UK post
        /// town. In regions of the world where localities are not well defined or do not fit into this structure well,
        /// leave locality empty and use address_lines.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locality")]
        public virtual string Locality { get; set; }

        /// <summary>Optional. The name of the organization at the address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organization")]
        public virtual string Organization { get; set; }

        /// <summary>
        /// Optional. Postal code of the address. Not all countries use or require postal codes to be present, but where
        /// they are used, they may trigger additional validation with other parts of the address (e.g. state/zip
        /// validation in the U.S.A.).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCode")]
        public virtual string PostalCode { get; set; }

        /// <summary>
        /// Optional. The recipient at the address. This field may, under certain circumstances, contain multiline
        /// information. For example, it might contain "care of" information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recipients")]
        public virtual System.Collections.Generic.IList<string> Recipients { get; set; }

        /// <summary>
        /// Required. CLDR region code of the country/region of the address. This is never inferred and it is up to the
        /// user to ensure the value is correct. See http://cldr.unicode.org/ and
        /// http://www.unicode.org/cldr/charts/30/supplemental/territory_information.html for details. Example: "CH" for
        /// Switzerland.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>
        /// The schema revision of the `PostalAddress`. This must be set to 0, which is the latest revision. All new
        /// revisions **must** be backward compatible with old revisions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual System.Nullable<int> Revision { get; set; }

        /// <summary>
        /// Optional. Additional, country-specific, sorting code. This is not used in most regions. Where it is used,
        /// the value is either a string like "CEDEX", optionally followed by a number (e.g. "CEDEX 7"), or just a
        /// number alone, representing the "sector code" (Jamaica), "delivery area indicator" (Malawi) or "post office
        /// indicator" (e.g. Côte d'Ivoire).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sortingCode")]
        public virtual string SortingCode { get; set; }

        /// <summary>
        /// Optional. Sublocality of the address. For example, this can be neighborhoods, boroughs, districts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sublocality")]
        public virtual string Sublocality { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a target location for a pending invitation.</summary>
    public class TargetLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The address of the location to which the user is invited.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual string Address { get; set; }

        /// <summary>The name of the location to which the user is invited.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationName")]
        public virtual string LocationName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for AccessControl.TransferLocation.</summary>
    public class TransferLocationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Name of the account resource to transfer the location to (for example, "accounts/{account}").
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationAccount")]
        public virtual string DestinationAccount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
