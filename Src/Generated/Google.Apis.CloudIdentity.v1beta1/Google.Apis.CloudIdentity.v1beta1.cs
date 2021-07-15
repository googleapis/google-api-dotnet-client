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

namespace Google.Apis.CloudIdentity.v1beta1
{
    /// <summary>The CloudIdentity Service.</summary>
    public class CloudIdentityService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudIdentityService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudIdentityService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Customers = new CustomersResource(this);
            Devices = new DevicesResource(this);
            Groups = new GroupsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "cloudidentity";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://cloudidentity.googleapis.com/";
        #else
            "https://cloudidentity.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://cloudidentity.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Identity API.</summary>
        public class Scope
        {
            /// <summary>See your device details</summary>
            public static string CloudIdentityDevicesLookup = "https://www.googleapis.com/auth/cloud-identity.devices.lookup";

            /// <summary>
            /// See, change, create, and delete any of the Cloud Identity Groups that you can access, including the
            /// members of each group
            /// </summary>
            public static string CloudIdentityGroups = "https://www.googleapis.com/auth/cloud-identity.groups";

            /// <summary>
            /// See any Cloud Identity Groups that you can access, including group members and their emails
            /// </summary>
            public static string CloudIdentityGroupsReadonly = "https://www.googleapis.com/auth/cloud-identity.groups.readonly";

            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Identity API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See your device details</summary>
            public const string CloudIdentityDevicesLookup = "https://www.googleapis.com/auth/cloud-identity.devices.lookup";

            /// <summary>
            /// See, change, create, and delete any of the Cloud Identity Groups that you can access, including the
            /// members of each group
            /// </summary>
            public const string CloudIdentityGroups = "https://www.googleapis.com/auth/cloud-identity.groups";

            /// <summary>
            /// See any Cloud Identity Groups that you can access, including group members and their emails
            /// </summary>
            public const string CloudIdentityGroupsReadonly = "https://www.googleapis.com/auth/cloud-identity.groups.readonly";

            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Customers resource.</summary>
        public virtual CustomersResource Customers { get; }

        /// <summary>Gets the Devices resource.</summary>
        public virtual DevicesResource Devices { get; }

        /// <summary>Gets the Groups resource.</summary>
        public virtual GroupsResource Groups { get; }
    }

    /// <summary>A base abstract class for CloudIdentity requests.</summary>
    public abstract class CloudIdentityBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudIdentityBaseServiceRequest instance.</summary>
        protected CloudIdentityBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CloudIdentity parameter list.</summary>
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

    /// <summary>The "customers" collection of methods.</summary>
    public class CustomersResource
    {
        private const string Resource = "customers";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public CustomersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Userinvitations = new UserinvitationsResource(service);
        }

        /// <summary>Gets the Userinvitations resource.</summary>
        public virtual UserinvitationsResource Userinvitations { get; }

        /// <summary>The "userinvitations" collection of methods.</summary>
        public class UserinvitationsResource
        {
            private const string Resource = "userinvitations";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public UserinvitationsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Cancels a UserInvitation that was already sent.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. `UserInvitation` name in the format
            /// `customers/{customer}/userinvitations/{user_email_address}`
            /// </param>
            public virtual CancelRequest Cancel(Google.Apis.CloudIdentity.v1beta1.Data.CancelUserInvitationRequest body, string name)
            {
                return new CancelRequest(service, body, name);
            }

            /// <summary>Cancels a UserInvitation that was already sent.</summary>
            public class CancelRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1beta1.Data.Operation>
            {
                /// <summary>Constructs a new Cancel request.</summary>
                public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudIdentity.v1beta1.Data.CancelUserInvitationRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. `UserInvitation` name in the format
                /// `customers/{customer}/userinvitations/{user_email_address}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudIdentity.v1beta1.Data.CancelUserInvitationRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "cancel";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}:cancel";

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
                        Pattern = @"^customers/[^/]+/userinvitations/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Retrieves a UserInvitation resource. **Note:** New consumer accounts with the customer's verified domain
            /// created within the previous 48 hours will not appear in the result. This delay also applies to
            /// newly-verified domains.
            /// </summary>
            /// <param name="name">
            /// Required. `UserInvitation` name in the format
            /// `customers/{customer}/userinvitations/{user_email_address}`
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>
            /// Retrieves a UserInvitation resource. **Note:** New consumer accounts with the customer's verified domain
            /// created within the previous 48 hours will not appear in the result. This delay also applies to
            /// newly-verified domains.
            /// </summary>
            public class GetRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1beta1.Data.UserInvitation>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. `UserInvitation` name in the format
                /// `customers/{customer}/userinvitations/{user_email_address}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}";

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
                        Pattern = @"^customers/[^/]+/userinvitations/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Verifies whether a user account is eligible to receive a UserInvitation (is an unmanaged account).
            /// Eligibility is based on the following criteria: * the email address is a consumer account and it's the
            /// primary email address of the account, and * the domain of the email address matches an existing verified
            /// Google Workspace or Cloud Identity domain If both conditions are met, the user is eligible. **Note:**
            /// This method is not supported for Workspace Essentials customers.
            /// </summary>
            /// <param name="name">
            /// Required. `UserInvitation` name in the format
            /// `customers/{customer}/userinvitations/{user_email_address}`
            /// </param>
            public virtual IsInvitableUserRequest IsInvitableUser(string name)
            {
                return new IsInvitableUserRequest(service, name);
            }

            /// <summary>
            /// Verifies whether a user account is eligible to receive a UserInvitation (is an unmanaged account).
            /// Eligibility is based on the following criteria: * the email address is a consumer account and it's the
            /// primary email address of the account, and * the domain of the email address matches an existing verified
            /// Google Workspace or Cloud Identity domain If both conditions are met, the user is eligible. **Note:**
            /// This method is not supported for Workspace Essentials customers.
            /// </summary>
            public class IsInvitableUserRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1beta1.Data.IsInvitableUserResponse>
            {
                /// <summary>Constructs a new IsInvitableUser request.</summary>
                public IsInvitableUserRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. `UserInvitation` name in the format
                /// `customers/{customer}/userinvitations/{user_email_address}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "isInvitableUser";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}:isInvitableUser";

                /// <summary>Initializes IsInvitableUser parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^customers/[^/]+/userinvitations/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Retrieves a list of UserInvitation resources. **Note:** New consumer accounts with the customer's
            /// verified domain created within the previous 48 hours will not appear in the result. This delay also
            /// applies to newly-verified domains.
            /// </summary>
            /// <param name="parent">
            /// Required. The customer ID of the Google Workspace or Cloud Identity account the UserInvitation resources
            /// are associated with.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Retrieves a list of UserInvitation resources. **Note:** New consumer accounts with the customer's
            /// verified domain created within the previous 48 hours will not appear in the result. This delay also
            /// applies to newly-verified domains.
            /// </summary>
            public class ListRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1beta1.Data.ListUserInvitationsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The customer ID of the Google Workspace or Cloud Identity account the UserInvitation
                /// resources are associated with.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. A query string for filtering `UserInvitation` results by their current state, in the
                /// format: `"state=='invited'"`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Optional. The sort order of the list results. You can sort the results in descending order based on
                /// either email or last update timestamp but not both, using `order_by="email desc"`. Currently,
                /// sorting is supported for `update_time asc`, `update_time desc`, `email asc`, and `email desc`. If
                /// not specified, results will be returned based on `email asc` order.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>
                /// Optional. The maximum number of UserInvitation resources to return. If unspecified, at most 100
                /// resources will be returned. The maximum value is 200; values above 200 will be set to 200.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A page token, received from a previous `ListUserInvitations` call. Provide this to
                /// retrieve the subsequent page. When paginating, all other parameters provided to `ListBooks` must
                /// match the call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/userinvitations";

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
                        Pattern = @"^customers/[^/]+$",
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
            /// Sends a UserInvitation to email. If the `UserInvitation` does not exist for this request and it is a
            /// valid request, the request creates a `UserInvitation`. **Note:** The `get` and `list` methods have a
            /// 48-hour delay where newly-created consumer accounts will not appear in the results. You can still send a
            /// `UserInvitation` to those accounts if you know the unmanaged email address and IsInvitableUser==True.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. `UserInvitation` name in the format
            /// `customers/{customer}/userinvitations/{user_email_address}`
            /// </param>
            public virtual SendRequest Send(Google.Apis.CloudIdentity.v1beta1.Data.SendUserInvitationRequest body, string name)
            {
                return new SendRequest(service, body, name);
            }

            /// <summary>
            /// Sends a UserInvitation to email. If the `UserInvitation` does not exist for this request and it is a
            /// valid request, the request creates a `UserInvitation`. **Note:** The `get` and `list` methods have a
            /// 48-hour delay where newly-created consumer accounts will not appear in the results. You can still send a
            /// `UserInvitation` to those accounts if you know the unmanaged email address and IsInvitableUser==True.
            /// </summary>
            public class SendRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1beta1.Data.Operation>
            {
                /// <summary>Constructs a new Send request.</summary>
                public SendRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudIdentity.v1beta1.Data.SendUserInvitationRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. `UserInvitation` name in the format
                /// `customers/{customer}/userinvitations/{user_email_address}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudIdentity.v1beta1.Data.SendUserInvitationRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "send";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}:send";

                /// <summary>Initializes Send parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^customers/[^/]+/userinvitations/[^/]+$",
                    });
                }
            }
        }
    }

    /// <summary>The "devices" collection of methods.</summary>
    public class DevicesResource
    {
        private const string Resource = "devices";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public DevicesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            DeviceUsers = new DeviceUsersResource(service);
        }

        /// <summary>Gets the DeviceUsers resource.</summary>
        public virtual DeviceUsersResource DeviceUsers { get; }

        /// <summary>The "deviceUsers" collection of methods.</summary>
        public class DeviceUsersResource
        {
            private const string Resource = "deviceUsers";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public DeviceUsersResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                ClientStates = new ClientStatesResource(service);
            }

            /// <summary>Gets the ClientStates resource.</summary>
            public virtual ClientStatesResource ClientStates { get; }

            /// <summary>The "clientStates" collection of methods.</summary>
            public class ClientStatesResource
            {
                private const string Resource = "clientStates";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ClientStatesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Gets the client state for the device user</summary>
                /// <param name="name">
                /// Required. [Resource name](https://cloud.google.com/apis/design/resource_names) of the ClientState in
                /// format: `devices/{device_id}/deviceUsers/{device_user_id}/clientStates/{partner_id}`, where
                /// `device_id` is the unique ID assigned to the Device, `device_user_id` is the unique ID assigned to
                /// the User and `partner_id` identifies the partner storing the data. To get the client state for
                /// devices belonging to your own organization, the `partnerId` is in the format:
                /// `customerId-*anystring*`. Where the `customerId` is your organization's customer ID and `anystring`
                /// is any suffix. This suffix is used in setting up Custom Access Levels in Context-Aware Access. You
                /// may use `my_customer` instead of the customer ID for devices managed by your own organization. You
                /// may specify `-` in place of the `{device_id}`, so the ClientState resource name can be:
                /// `devices/-/deviceUsers/{device_user_resource_id}/clientStates/{partner_id}`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets the client state for the device user</summary>
                public class GetRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1beta1.Data.ClientState>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. [Resource name](https://cloud.google.com/apis/design/resource_names) of the
                    /// ClientState in format:
                    /// `devices/{device_id}/deviceUsers/{device_user_id}/clientStates/{partner_id}`, where `device_id`
                    /// is the unique ID assigned to the Device, `device_user_id` is the unique ID assigned to the User
                    /// and `partner_id` identifies the partner storing the data. To get the client state for devices
                    /// belonging to your own organization, the `partnerId` is in the format: `customerId-*anystring*`.
                    /// Where the `customerId` is your organization's customer ID and `anystring` is any suffix. This
                    /// suffix is used in setting up Custom Access Levels in Context-Aware Access. You may use
                    /// `my_customer` instead of the customer ID for devices managed by your own organization. You may
                    /// specify `-` in place of the `{device_id}`, so the ClientState resource name can be:
                    /// `devices/-/deviceUsers/{device_user_resource_id}/clientStates/{partner_id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. [Resource name](https://cloud.google.com/apis/design/resource_names) of the customer.
                    /// If you're using this API for your own organization, use `customers/my_customer` If you're using
                    /// this API to manage another organization, use `customers/{customer_id}`, where customer_id is the
                    /// customer to whom the device belongs.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Customer { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}";

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
                            Pattern = @"^devices/[^/]+/deviceUsers/[^/]+/clientStates/[^/]+$",
                        });
                        RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                        {
                            Name = "customer",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Updates the client state for the device user **Note**: This method is available only to customers
                /// who have one of the following SKUs: Enterprise Standard, Enterprise Plus, Enterprise for Education,
                /// and Cloud Identity Premium
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. [Resource name](https://cloud.google.com/apis/design/resource_names) of the ClientState
                /// in format: `devices/{device_id}/deviceUsers/{device_user_id}/clientState/{partner_id}`, where
                /// partner_id corresponds to the partner storing the data.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.CloudIdentity.v1beta1.Data.ClientState body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Updates the client state for the device user **Note**: This method is available only to customers
                /// who have one of the following SKUs: Enterprise Standard, Enterprise Plus, Enterprise for Education,
                /// and Cloud Identity Premium
                /// </summary>
                public class PatchRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudIdentity.v1beta1.Data.ClientState body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. [Resource name](https://cloud.google.com/apis/design/resource_names) of the
                    /// ClientState in format:
                    /// `devices/{device_id}/deviceUsers/{device_user_id}/clientState/{partner_id}`, where partner_id
                    /// corresponds to the partner storing the data.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. [Resource name](https://cloud.google.com/apis/design/resource_names) of the customer.
                    /// If you're using this API for your own organization, use `customers/my_customer` If you're using
                    /// this API to manage another organization, use `customers/{customer_id}`, where customer_id is the
                    /// customer to whom the device belongs.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Customer { get; set; }

                    /// <summary>
                    /// Optional. Comma-separated list of fully qualified names of fields to be updated. If not
                    /// specified, all updatable fields in ClientState are updated.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudIdentity.v1beta1.Data.ClientState Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}";

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
                            Pattern = @"^devices/[^/]+/deviceUsers/[^/]+/clientStates/[^/]+$",
                        });
                        RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                        {
                            Name = "customer",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
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

            /// <summary>Approves device to access user data.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. [Resource name](https://cloud.google.com/apis/design/resource_names) of the Device in format:
            /// `devices/{device_id}/deviceUsers/{device_user_id}`, where device_id is the unique ID assigned to the
            /// Device, and device_user_id is the unique ID assigned to the User.
            /// </param>
            public virtual ApproveRequest Approve(Google.Apis.CloudIdentity.v1beta1.Data.ApproveDeviceUserRequest body, string name)
            {
                return new ApproveRequest(service, body, name);
            }

            /// <summary>Approves device to access user data.</summary>
            public class ApproveRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1beta1.Data.Operation>
            {
                /// <summary>Constructs a new Approve request.</summary>
                public ApproveRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudIdentity.v1beta1.Data.ApproveDeviceUserRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. [Resource name](https://cloud.google.com/apis/design/resource_names) of the Device in
                /// format: `devices/{device_id}/deviceUsers/{device_user_id}`, where device_id is the unique ID
                /// assigned to the Device, and device_user_id is the unique ID assigned to the User.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudIdentity.v1beta1.Data.ApproveDeviceUserRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "approve";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}:approve";

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
                        Pattern = @"^devices/[^/]+/deviceUsers/[^/]+$",
                    });
                }
            }

            /// <summary>Blocks device from accessing user data</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. [Resource name](https://cloud.google.com/apis/design/resource_names) of the Device in format:
            /// `devices/{device_id}/deviceUsers/{device_user_id}`, where device_id is the unique ID assigned to the
            /// Device, and device_user_id is the unique ID assigned to the User.
            /// </param>
            public virtual BlockRequest Block(Google.Apis.CloudIdentity.v1beta1.Data.BlockDeviceUserRequest body, string name)
            {
                return new BlockRequest(service, body, name);
            }

            /// <summary>Blocks device from accessing user data</summary>
            public class BlockRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1beta1.Data.Operation>
            {
                /// <summary>Constructs a new Block request.</summary>
                public BlockRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudIdentity.v1beta1.Data.BlockDeviceUserRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. [Resource name](https://cloud.google.com/apis/design/resource_names) of the Device in
                /// format: `devices/{device_id}/deviceUsers/{device_user_id}`, where device_id is the unique ID
                /// assigned to the Device, and device_user_id is the unique ID assigned to the User.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudIdentity.v1beta1.Data.BlockDeviceUserRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "block";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}:block";

                /// <summary>Initializes Block parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^devices/[^/]+/deviceUsers/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Cancels an unfinished user account wipe. This operation can be used to cancel device wipe in the gap
            /// between the wipe operation returning success and the device being wiped.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. [Resource name](https://cloud.google.com/apis/design/resource_names) of the Device in format:
            /// `devices/{device_id}/deviceUsers/{device_user_id}`, where device_id is the unique ID assigned to the
            /// Device, and device_user_id is the unique ID assigned to the User.
            /// </param>
            public virtual CancelWipeRequest CancelWipe(Google.Apis.CloudIdentity.v1beta1.Data.CancelWipeDeviceUserRequest body, string name)
            {
                return new CancelWipeRequest(service, body, name);
            }

            /// <summary>
            /// Cancels an unfinished user account wipe. This operation can be used to cancel device wipe in the gap
            /// between the wipe operation returning success and the device being wiped.
            /// </summary>
            public class CancelWipeRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1beta1.Data.Operation>
            {
                /// <summary>Constructs a new CancelWipe request.</summary>
                public CancelWipeRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudIdentity.v1beta1.Data.CancelWipeDeviceUserRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. [Resource name](https://cloud.google.com/apis/design/resource_names) of the Device in
                /// format: `devices/{device_id}/deviceUsers/{device_user_id}`, where device_id is the unique ID
                /// assigned to the Device, and device_user_id is the unique ID assigned to the User.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudIdentity.v1beta1.Data.CancelWipeDeviceUserRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "cancelWipe";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}:cancelWipe";

                /// <summary>Initializes CancelWipe parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^devices/[^/]+/deviceUsers/[^/]+$",
                    });
                }
            }

            /// <summary>Deletes the specified DeviceUser. This also revokes the user's access to device data.</summary>
            /// <param name="name">
            /// Required. [Resource name](https://cloud.google.com/apis/design/resource_names) of the Device in format:
            /// `devices/{device_id}/deviceUsers/{device_user_id}`, where device_id is the unique ID assigned to the
            /// Device, and device_user_id is the unique ID assigned to the User.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes the specified DeviceUser. This also revokes the user's access to device data.</summary>
            public class DeleteRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1beta1.Data.Operation>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. [Resource name](https://cloud.google.com/apis/design/resource_names) of the Device in
                /// format: `devices/{device_id}/deviceUsers/{device_user_id}`, where device_id is the unique ID
                /// assigned to the Device, and device_user_id is the unique ID assigned to the User.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}";

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
                        Pattern = @"^devices/[^/]+/deviceUsers/[^/]+$",
                    });
                }
            }

            /// <summary>Retrieves the specified DeviceUser</summary>
            /// <param name="name">
            /// Required. [Resource name](https://cloud.google.com/apis/design/resource_names) of the Device in format:
            /// `devices/{device_id}/deviceUsers/{device_user_id}`, where device_id is the unique ID assigned to the
            /// Device, and device_user_id is the unique ID assigned to the User.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Retrieves the specified DeviceUser</summary>
            public class GetRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1beta1.Data.DeviceUser>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. [Resource name](https://cloud.google.com/apis/design/resource_names) of the Device in
                /// format: `devices/{device_id}/deviceUsers/{device_user_id}`, where device_id is the unique ID
                /// assigned to the Device, and device_user_id is the unique ID assigned to the User.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}";

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
                        Pattern = @"^devices/[^/]+/deviceUsers/[^/]+$",
                    });
                }
            }

            /// <summary>Lists/Searches DeviceUsers.</summary>
            /// <param name="parent">
            /// Required. To list all DeviceUsers, set this to "devices/-". To list all DeviceUsers owned by a device,
            /// set this to the resource name of the device. Format: devices/{device}
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists/Searches DeviceUsers.</summary>
            public class ListRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1beta1.Data.ListDeviceUsersResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. To list all DeviceUsers, set this to "devices/-". To list all DeviceUsers owned by a
                /// device, set this to the resource name of the device. Format: devices/{device}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. Additional restrictions when fetching list of devices. For a list of search fields, refer
                /// to [Mobile device search
                /// fields](https://developers.google.com/admin-sdk/directory/v1/search-operators). Multiple search
                /// fields are separated by the space character.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>Optional. Order specification for devices in the response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>
                /// Optional. The maximum number of DeviceUsers to return. If unspecified, at most 5 DeviceUsers will be
                /// returned. The maximum value is 20; values above 20 will be coerced to 20.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A page token, received from a previous `ListDeviceUsers` call. Provide this to retrieve
                /// the subsequent page. When paginating, all other parameters provided to `ListBooks` must match the
                /// call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/deviceUsers";

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
                        Pattern = @"^devices/[^/]+$",
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
            /// Looks up resource names of the DeviceUsers associated with the caller's credentials, as well as the
            /// properties provided in the request. This method must be called with end-user credentials with the scope:
            /// https://www.googleapis.com/auth/cloud-identity.devices.lookup If multiple properties are provided, only
            /// DeviceUsers having all of these properties are considered as matches - i.e. the query behaves like an
            /// AND. Different platforms require different amounts of information from the caller to ensure that the
            /// DeviceUser is uniquely identified. - iOS: No properties need to be passed, the caller's credentials are
            /// sufficient to identify the corresponding DeviceUser. - Android: Specifying the 'android_id' field is
            /// required. - Desktop: Specifying the 'raw_resource_id' field is required.
            /// </summary>
            /// <param name="parent">
            /// Must be set to "devices/-/deviceUsers" to search across all DeviceUser belonging to the user.
            /// </param>
            public virtual LookupRequest Lookup(string parent)
            {
                return new LookupRequest(service, parent);
            }

            /// <summary>
            /// Looks up resource names of the DeviceUsers associated with the caller's credentials, as well as the
            /// properties provided in the request. This method must be called with end-user credentials with the scope:
            /// https://www.googleapis.com/auth/cloud-identity.devices.lookup If multiple properties are provided, only
            /// DeviceUsers having all of these properties are considered as matches - i.e. the query behaves like an
            /// AND. Different platforms require different amounts of information from the caller to ensure that the
            /// DeviceUser is uniquely identified. - iOS: No properties need to be passed, the caller's credentials are
            /// sufficient to identify the corresponding DeviceUser. - Android: Specifying the 'android_id' field is
            /// required. - Desktop: Specifying the 'raw_resource_id' field is required.
            /// </summary>
            public class LookupRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1beta1.Data.LookupSelfDeviceUsersResponse>
            {
                /// <summary>Constructs a new Lookup request.</summary>
                public LookupRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Must be set to "devices/-/deviceUsers" to search across all DeviceUser belonging to the user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Android Id returned by
                /// [Settings.Secure#ANDROID_ID](https://developer.android.com/reference/android/provider/Settings.Secure.html#ANDROID_ID).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("androidId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string AndroidId { get; set; }

                /// <summary>
                /// The maximum number of DeviceUsers to return. If unspecified, at most 20 DeviceUsers will be
                /// returned. The maximum value is 20; values above 20 will be coerced to 20.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token, received from a previous `LookupDeviceUsers` call. Provide this to retrieve the
                /// subsequent page. When paginating, all other parameters provided to `LookupDeviceUsers` must match
                /// the call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// Raw Resource Id used by Google Endpoint Verification. If the user is enrolled into Google Endpoint
                /// Verification, this id will be saved as the 'device_resource_id' field in the following platform
                /// dependent files. Mac: ~/.secureConnect/context_aware_config.json Windows:
                /// C:\Users\%USERPROFILE%\.secureConnect\context_aware_config.json Linux:
                /// ~/.secureConnect/context_aware_config.json
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("rawResourceId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string RawResourceId { get; set; }

                /// <summary>
                /// The user whose DeviceUser's resource name will be fetched. Must be set to 'me' to fetch the
                /// DeviceUser's resource name for the calling user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UserId { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "lookup";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}:lookup";

                /// <summary>Initializes Lookup parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^devices/[^/]+/deviceUsers$",
                    });
                    RequestParameters.Add("androidId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "androidId",
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
                    RequestParameters.Add("rawResourceId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "rawResourceId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Wipes the user's account on a device.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. [Resource name](https://cloud.google.com/apis/design/resource_names) of the Device in format:
            /// `devices/{device_id}/deviceUsers/{device_user_id}`, where device_id is the unique ID assigned to the
            /// Device, and device_user_id is the unique ID assigned to the User.
            /// </param>
            public virtual WipeRequest Wipe(Google.Apis.CloudIdentity.v1beta1.Data.WipeDeviceUserRequest body, string name)
            {
                return new WipeRequest(service, body, name);
            }

            /// <summary>Wipes the user's account on a device.</summary>
            public class WipeRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1beta1.Data.Operation>
            {
                /// <summary>Constructs a new Wipe request.</summary>
                public WipeRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudIdentity.v1beta1.Data.WipeDeviceUserRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. [Resource name](https://cloud.google.com/apis/design/resource_names) of the Device in
                /// format: `devices/{device_id}/deviceUsers/{device_user_id}`, where device_id is the unique ID
                /// assigned to the Device, and device_user_id is the unique ID assigned to the User.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudIdentity.v1beta1.Data.WipeDeviceUserRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "wipe";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}:wipe";

                /// <summary>Initializes Wipe parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^devices/[^/]+/deviceUsers/[^/]+$",
                    });
                }
            }
        }

        /// <summary>
        /// Cancels an unfinished device wipe. This operation can be used to cancel device wipe in the gap between the
        /// wipe operation returning success and the device being wiped.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Required. [Resource name](https://cloud.google.com/apis/design/resource_names) of the Device in format:
        /// `devices/{device_id}`, where device_id is the unique ID assigned to the Device.
        /// </param>
        public virtual CancelWipeRequest CancelWipe(Google.Apis.CloudIdentity.v1beta1.Data.CancelWipeDeviceRequest body, string name)
        {
            return new CancelWipeRequest(service, body, name);
        }

        /// <summary>
        /// Cancels an unfinished device wipe. This operation can be used to cancel device wipe in the gap between the
        /// wipe operation returning success and the device being wiped.
        /// </summary>
        public class CancelWipeRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1beta1.Data.Operation>
        {
            /// <summary>Constructs a new CancelWipe request.</summary>
            public CancelWipeRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudIdentity.v1beta1.Data.CancelWipeDeviceRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. [Resource name](https://cloud.google.com/apis/design/resource_names) of the Device in format:
            /// `devices/{device_id}`, where device_id is the unique ID assigned to the Device.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudIdentity.v1beta1.Data.CancelWipeDeviceRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "cancelWipe";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/{+name}:cancelWipe";

            /// <summary>Initializes CancelWipe parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^devices/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Creates a device. Only company-owned device may be created. **Note**: This method is available only to
        /// customers who have one of the following SKUs: Enterprise Standard, Enterprise Plus, Enterprise for
        /// Education, and Cloud Identity Premium
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.CloudIdentity.v1beta1.Data.CreateDeviceRequest body)
        {
            return new CreateRequest(service, body);
        }

        /// <summary>
        /// Creates a device. Only company-owned device may be created. **Note**: This method is available only to
        /// customers who have one of the following SKUs: Enterprise Standard, Enterprise Plus, Enterprise for
        /// Education, and Cloud Identity Premium
        /// </summary>
        public class CreateRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1beta1.Data.Operation>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudIdentity.v1beta1.Data.CreateDeviceRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudIdentity.v1beta1.Data.CreateDeviceRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/devices";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Deletes the specified device.</summary>
        /// <param name="name">
        /// Required. [Resource name](https://cloud.google.com/apis/design/resource_names) of the Device in format:
        /// `devices/{device_id}`, where device_id is the unique ID assigned to the Device.
        /// </param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(service, name);
        }

        /// <summary>Deletes the specified device.</summary>
        public class DeleteRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1beta1.Data.Operation>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. [Resource name](https://cloud.google.com/apis/design/resource_names) of the Device in format:
            /// `devices/{device_id}`, where device_id is the unique ID assigned to the Device.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/{+name}";

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
                    Pattern = @"^devices/[^/]+$",
                });
            }
        }

        /// <summary>Retrieves the specified device.</summary>
        /// <param name="name">
        /// Required. [Resource name](https://cloud.google.com/apis/design/resource_names) of the Device in format:
        /// `devices/{device_id}`, where device_id is the unique ID assigned to the Device.
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>Retrieves the specified device.</summary>
        public class GetRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1beta1.Data.Device>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. [Resource name](https://cloud.google.com/apis/design/resource_names) of the Device in format:
            /// `devices/{device_id}`, where device_id is the unique ID assigned to the Device.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/{+name}";

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
                    Pattern = @"^devices/[^/]+$",
                });
            }
        }

        /// <summary>Lists/Searches devices.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Lists/Searches devices.</summary>
        public class ListRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1beta1.Data.ListDevicesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional. Additional restrictions when fetching list of devices. For a list of search fields, refer to
            /// [Mobile device search fields](https://developers.google.com/admin-sdk/directory/v1/search-operators).
            /// Multiple search fields are separated by the space character.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>
            /// Optional. Order specification for devices in the response. Only one of the following field names may be
            /// used to specify the order: `create_time`, `last_sync_time`, `model`, `os_version`, `device_type` and
            /// `serial_number`. `desc` may be specified optionally to specify results to be sorted in descending order.
            /// Default order is ascending.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>
            /// Optional. The maximum number of Devices to return. If unspecified, at most 20 Devices will be returned.
            /// The maximum value is 100; values above 100 will be coerced to 100.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. A page token, received from a previous `ListDevices` call. Provide this to retrieve the
            /// subsequent page. When paginating, all other parameters provided to `ListDevices` must match the call
            /// that provided the page token.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Optional. The view to use for the List request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewEnum> View { get; set; }

            /// <summary>Optional. The view to use for the List request.</summary>
            public enum ViewEnum
            {
                /// <summary>Default value. The value is unused.</summary>
                [Google.Apis.Util.StringValueAttribute("VIEW_UNSPECIFIED")]
                VIEWUNSPECIFIED = 0,

                /// <summary>
                /// This view contains all devices imported by the company admin. Each device in the response contains
                /// all information specified by the company admin when importing the device (i.e. asset tags).
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("COMPANY_INVENTORY")]
                COMPANYINVENTORY = 1,

                /// <summary>
                /// This view contains all devices with at least one user registered on the device. Each device in the
                /// response contains all device information, except for asset tags.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("USER_ASSIGNED_DEVICES")]
                USERASSIGNEDDEVICES = 2,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/devices";

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
                RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                {
                    Name = "view",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Wipes all data on the specified device.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Required. [Resource name](https://cloud.google.com/apis/design/resource_names) of the Device in format:
        /// `devices/{device_id}/deviceUsers/{device_user_id}`, where device_id is the unique ID assigned to the Device,
        /// and device_user_id is the unique ID assigned to the User.
        /// </param>
        public virtual WipeRequest Wipe(Google.Apis.CloudIdentity.v1beta1.Data.WipeDeviceRequest body, string name)
        {
            return new WipeRequest(service, body, name);
        }

        /// <summary>Wipes all data on the specified device.</summary>
        public class WipeRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1beta1.Data.Operation>
        {
            /// <summary>Constructs a new Wipe request.</summary>
            public WipeRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudIdentity.v1beta1.Data.WipeDeviceRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. [Resource name](https://cloud.google.com/apis/design/resource_names) of the Device in format:
            /// `devices/{device_id}/deviceUsers/{device_user_id}`, where device_id is the unique ID assigned to the
            /// Device, and device_user_id is the unique ID assigned to the User.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudIdentity.v1beta1.Data.WipeDeviceRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "wipe";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/{+name}:wipe";

            /// <summary>Initializes Wipe parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^devices/[^/]+$",
                });
            }
        }
    }

    /// <summary>The "groups" collection of methods.</summary>
    public class GroupsResource
    {
        private const string Resource = "groups";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public GroupsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Memberships = new MembershipsResource(service);
        }

        /// <summary>Gets the Memberships resource.</summary>
        public virtual MembershipsResource Memberships { get; }

        /// <summary>The "memberships" collection of methods.</summary>
        public class MembershipsResource
        {
            private const string Resource = "memberships";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public MembershipsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Check a potential member for membership in a group. **Note:** This feature is only available to Google
            /// Workspace Enterprise Standard, Enterprise Plus, and Enterprise for Education; and Cloud Identity Premium
            /// accounts. A member has membership to a group as long as there is a single viewable transitive membership
            /// between the group and the member. The actor must have view permissions to at least one transitive
            /// membership between the member and group.
            /// </summary>
            /// <param name="parent">
            /// [Resource name](https://cloud.google.com/apis/design/resource_names) of the group to check the
            /// transitive membership in. Format: `groups/{group_id}`, where `group_id` is the unique id assigned to the
            /// Group to which the Membership belongs to.
            /// </param>
            public virtual CheckTransitiveMembershipRequest CheckTransitiveMembership(string parent)
            {
                return new CheckTransitiveMembershipRequest(service, parent);
            }

            /// <summary>
            /// Check a potential member for membership in a group. **Note:** This feature is only available to Google
            /// Workspace Enterprise Standard, Enterprise Plus, and Enterprise for Education; and Cloud Identity Premium
            /// accounts. A member has membership to a group as long as there is a single viewable transitive membership
            /// between the group and the member. The actor must have view permissions to at least one transitive
            /// membership between the member and group.
            /// </summary>
            public class CheckTransitiveMembershipRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1beta1.Data.CheckTransitiveMembershipResponse>
            {
                /// <summary>Constructs a new CheckTransitiveMembership request.</summary>
                public CheckTransitiveMembershipRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// [Resource name](https://cloud.google.com/apis/design/resource_names) of the group to check the
                /// transitive membership in. Format: `groups/{group_id}`, where `group_id` is the unique id assigned to
                /// the Group to which the Membership belongs to.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Required. A CEL expression that MUST include member specification. This is a `required` field.
                /// Certain groups are uniquely identified by both a 'member_key_id' and a 'member_key_namespace', which
                /// requires an additional query input: 'member_key_namespace'. Example query: `member_key_id ==
                /// 'member_key_id_value'`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Query { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "checkTransitiveMembership";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/memberships:checkTransitiveMembership";

                /// <summary>Initializes CheckTransitiveMembership parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^groups/[^/]+$",
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

            /// <summary>Creates a `Membership`.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The parent `Group` resource under which to create the `Membership`. Must be of the form
            /// `groups/{group_id}`.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.CloudIdentity.v1beta1.Data.Membership body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a `Membership`.</summary>
            public class CreateRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1beta1.Data.Operation>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudIdentity.v1beta1.Data.Membership body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent `Group` resource under which to create the `Membership`. Must be of the form
                /// `groups/{group_id}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudIdentity.v1beta1.Data.Membership Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/memberships";

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
                        Pattern = @"^groups/[^/]+$",
                    });
                }
            }

            /// <summary>Deletes a `Membership`.</summary>
            /// <param name="name">
            /// Required. The [resource name](https://cloud.google.com/apis/design/resource_names) of the `Membership`
            /// to delete. Must be of the form `groups/{group_id}/memberships/{membership_id}`.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes a `Membership`.</summary>
            public class DeleteRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1beta1.Data.Operation>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The [resource name](https://cloud.google.com/apis/design/resource_names) of the
                /// `Membership` to delete. Must be of the form `groups/{group_id}/memberships/{membership_id}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}";

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
                        Pattern = @"^groups/[^/]+/memberships/[^/]+$",
                    });
                }
            }

            /// <summary>Retrieves a `Membership`.</summary>
            /// <param name="name">
            /// Required. The [resource name](https://cloud.google.com/apis/design/resource_names) of the `Membership`
            /// to retrieve. Must be of the form `groups/{group_id}/memberships/{membership_id}`.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Retrieves a `Membership`.</summary>
            public class GetRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1beta1.Data.Membership>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The [resource name](https://cloud.google.com/apis/design/resource_names) of the
                /// `Membership` to retrieve. Must be of the form `groups/{group_id}/memberships/{membership_id}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}";

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
                        Pattern = @"^groups/[^/]+/memberships/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Get a membership graph of just a member or both a member and a group. **Note:** This feature is only
            /// available to Google Workspace Enterprise Standard, Enterprise Plus, and Enterprise for Education; and
            /// Cloud Identity Premium accounts. Given a member, the response will contain all membership paths from the
            /// member. Given both a group and a member, the response will contain all membership paths between the
            /// group and the member.
            /// </summary>
            /// <param name="parent">
            /// Required. [Resource name](https://cloud.google.com/apis/design/resource_names) of the group to search
            /// transitive memberships in. Format: `groups/{group_id}`, where `group_id` is the unique ID assigned to
            /// the Group to which the Membership belongs to. group_id can be a wildcard collection id "-". When a
            /// group_id is specified, the membership graph will be constrained to paths between the member (defined in
            /// the query) and the parent. If a wildcard collection is provided, all membership paths connected to the
            /// member will be returned.
            /// </param>
            public virtual GetMembershipGraphRequest GetMembershipGraph(string parent)
            {
                return new GetMembershipGraphRequest(service, parent);
            }

            /// <summary>
            /// Get a membership graph of just a member or both a member and a group. **Note:** This feature is only
            /// available to Google Workspace Enterprise Standard, Enterprise Plus, and Enterprise for Education; and
            /// Cloud Identity Premium accounts. Given a member, the response will contain all membership paths from the
            /// member. Given both a group and a member, the response will contain all membership paths between the
            /// group and the member.
            /// </summary>
            public class GetMembershipGraphRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1beta1.Data.Operation>
            {
                /// <summary>Constructs a new GetMembershipGraph request.</summary>
                public GetMembershipGraphRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. [Resource name](https://cloud.google.com/apis/design/resource_names) of the group to
                /// search transitive memberships in. Format: `groups/{group_id}`, where `group_id` is the unique ID
                /// assigned to the Group to which the Membership belongs to. group_id can be a wildcard collection id
                /// "-". When a group_id is specified, the membership graph will be constrained to paths between the
                /// member (defined in the query) and the parent. If a wildcard collection is provided, all membership
                /// paths connected to the member will be returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Required. A CEL expression that MUST include member specification AND label(s). Certain groups are
                /// uniquely identified by both a 'member_key_id' and a 'member_key_namespace', which requires an
                /// additional query input: 'member_key_namespace'. Example query: `member_key_id ==
                /// 'member_key_id_value' &amp;amp;&amp;amp; in labels`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Query { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getMembershipGraph";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/memberships:getMembershipGraph";

                /// <summary>Initializes GetMembershipGraph parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^groups/[^/]+$",
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

            /// <summary>Lists the `Membership`s within a `Group`.</summary>
            /// <param name="parent">
            /// Required. The parent `Group` resource under which to lookup the `Membership` name. Must be of the form
            /// `groups/{group_id}`.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists the `Membership`s within a `Group`.</summary>
            public class ListRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1beta1.Data.ListMembershipsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent `Group` resource under which to lookup the `Membership` name. Must be of the
                /// form `groups/{group_id}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of results to return. Note that the number of results returned may be less than
                /// this value even if there are more available results. To fetch all results, clients must continue
                /// calling this method repeatedly until the response no longer contains a `next_page_token`. If
                /// unspecified, defaults to 200 for `GroupView.BASIC` and to 50 for `GroupView.FULL`. Must not be
                /// greater than 1000 for `GroupView.BASIC` or 500 for `GroupView.FULL`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>The `next_page_token` value returned from a previous search request, if any.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// The level of detail to be returned. If unspecified, defaults to `MembershipView.BASIC`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ViewEnum> View { get; set; }

                /// <summary>
                /// The level of detail to be returned. If unspecified, defaults to `MembershipView.BASIC`.
                /// </summary>
                public enum ViewEnum
                {
                    /// <summary>Default. Only basic resource information is returned.</summary>
                    [Google.Apis.Util.StringValueAttribute("BASIC")]
                    BASIC = 0,

                    /// <summary>All resource information is returned.</summary>
                    [Google.Apis.Util.StringValueAttribute("FULL")]
                    FULL = 1,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/memberships";

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
                        Pattern = @"^groups/[^/]+$",
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
                    RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                    {
                        Name = "view",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Looks up the [resource name](https://cloud.google.com/apis/design/resource_names) of a `Membership` by
            /// its `EntityKey`.
            /// </summary>
            /// <param name="parent">
            /// Required. The parent `Group` resource under which to lookup the `Membership` name. Must be of the form
            /// `groups/{group_id}`.
            /// </param>
            public virtual LookupRequest Lookup(string parent)
            {
                return new LookupRequest(service, parent);
            }

            /// <summary>
            /// Looks up the [resource name](https://cloud.google.com/apis/design/resource_names) of a `Membership` by
            /// its `EntityKey`.
            /// </summary>
            public class LookupRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1beta1.Data.LookupMembershipNameResponse>
            {
                /// <summary>Constructs a new Lookup request.</summary>
                public LookupRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent `Group` resource under which to lookup the `Membership` name. Must be of the
                /// form `groups/{group_id}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The ID of the entity. For Google-managed entities, the `id` must be the email address of an existing
                /// group or user. For external-identity-mapped entities, the `id` must be a string conforming to the
                /// Identity Source's requirements. Must be unique within a `namespace`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("memberKey.id", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string MemberKeyId { get; set; }

                /// <summary>
                /// The namespace in which the entity exists. If not specified, the `EntityKey` represents a
                /// Google-managed entity such as a Google user or a Google Group. If specified, the `EntityKey`
                /// represents an external-identity-mapped group. The namespace must correspond to an identity source
                /// created in Admin Console and must be in the form of `identitysources/{identity_source_id}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("memberKey.namespace", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string MemberKeyNamespace { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "lookup";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/memberships:lookup";

                /// <summary>Initializes Lookup parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^groups/[^/]+$",
                    });
                    RequestParameters.Add("memberKey.id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "memberKey.id",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("memberKey.namespace", new Google.Apis.Discovery.Parameter
                    {
                        Name = "memberKey.namespace",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Modifies the `MembershipRole`s of a `Membership`.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The [resource name](https://cloud.google.com/apis/design/resource_names) of the `Membership`
            /// whose roles are to be modified. Must be of the form `groups/{group_id}/memberships/{membership_id}`.
            /// </param>
            public virtual ModifyMembershipRolesRequest ModifyMembershipRoles(Google.Apis.CloudIdentity.v1beta1.Data.ModifyMembershipRolesRequest body, string name)
            {
                return new ModifyMembershipRolesRequest(service, body, name);
            }

            /// <summary>Modifies the `MembershipRole`s of a `Membership`.</summary>
            public class ModifyMembershipRolesRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1beta1.Data.ModifyMembershipRolesResponse>
            {
                /// <summary>Constructs a new ModifyMembershipRoles request.</summary>
                public ModifyMembershipRolesRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudIdentity.v1beta1.Data.ModifyMembershipRolesRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The [resource name](https://cloud.google.com/apis/design/resource_names) of the
                /// `Membership` whose roles are to be modified. Must be of the form
                /// `groups/{group_id}/memberships/{membership_id}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudIdentity.v1beta1.Data.ModifyMembershipRolesRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "modifyMembershipRoles";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}:modifyMembershipRoles";

                /// <summary>Initializes ModifyMembershipRoles parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^groups/[^/]+/memberships/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Search transitive groups of a member. **Note:** This feature is only available to Google Workspace
            /// Enterprise Standard, Enterprise Plus, and Enterprise for Education; and Cloud Identity Premium accounts.
            /// A transitive group is any group that has a direct or indirect membership to the member. Actor must have
            /// view permissions all transitive groups.
            /// </summary>
            /// <param name="parent">
            /// [Resource name](https://cloud.google.com/apis/design/resource_names) of the group to search transitive
            /// memberships in. Format: `groups/{group_id}`, where `group_id` is always '-' as this API will search
            /// across all groups for a given member.
            /// </param>
            public virtual SearchTransitiveGroupsRequest SearchTransitiveGroups(string parent)
            {
                return new SearchTransitiveGroupsRequest(service, parent);
            }

            /// <summary>
            /// Search transitive groups of a member. **Note:** This feature is only available to Google Workspace
            /// Enterprise Standard, Enterprise Plus, and Enterprise for Education; and Cloud Identity Premium accounts.
            /// A transitive group is any group that has a direct or indirect membership to the member. Actor must have
            /// view permissions all transitive groups.
            /// </summary>
            public class SearchTransitiveGroupsRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1beta1.Data.SearchTransitiveGroupsResponse>
            {
                /// <summary>Constructs a new SearchTransitiveGroups request.</summary>
                public SearchTransitiveGroupsRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// [Resource name](https://cloud.google.com/apis/design/resource_names) of the group to search
                /// transitive memberships in. Format: `groups/{group_id}`, where `group_id` is always '-' as this API
                /// will search across all groups for a given member.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>The default page size is 200 (max 1000).</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>The next_page_token value returned from a previous list request, if any.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// Required. A CEL expression that MUST include member specification AND label(s). This is a `required`
                /// field. Users can search on label attributes of groups. CONTAINS match ('in') is supported on labels.
                /// Identity-mapped groups are uniquely identified by both a `member_key_id` and a
                /// `member_key_namespace`, which requires an additional query input: `member_key_namespace`. Example
                /// query: `member_key_id == 'member_key_id_value' &amp;amp;&amp;amp; in labels`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Query { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "searchTransitiveGroups";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/memberships:searchTransitiveGroups";

                /// <summary>Initializes SearchTransitiveGroups parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^groups/[^/]+$",
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
            /// Search transitive memberships of a group. **Note:** This feature is only available to Google Workspace
            /// Enterprise Standard, Enterprise Plus, and Enterprise for Education; and Cloud Identity Premium accounts.
            /// A transitive membership is any direct or indirect membership of a group. Actor must have view
            /// permissions to all transitive memberships.
            /// </summary>
            /// <param name="parent">
            /// [Resource name](https://cloud.google.com/apis/design/resource_names) of the group to search transitive
            /// memberships in. Format: `groups/{group_id}`, where `group_id` is the unique ID assigned to the Group.
            /// </param>
            public virtual SearchTransitiveMembershipsRequest SearchTransitiveMemberships(string parent)
            {
                return new SearchTransitiveMembershipsRequest(service, parent);
            }

            /// <summary>
            /// Search transitive memberships of a group. **Note:** This feature is only available to Google Workspace
            /// Enterprise Standard, Enterprise Plus, and Enterprise for Education; and Cloud Identity Premium accounts.
            /// A transitive membership is any direct or indirect membership of a group. Actor must have view
            /// permissions to all transitive memberships.
            /// </summary>
            public class SearchTransitiveMembershipsRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1beta1.Data.SearchTransitiveMembershipsResponse>
            {
                /// <summary>Constructs a new SearchTransitiveMemberships request.</summary>
                public SearchTransitiveMembershipsRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// [Resource name](https://cloud.google.com/apis/design/resource_names) of the group to search
                /// transitive memberships in. Format: `groups/{group_id}`, where `group_id` is the unique ID assigned
                /// to the Group.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>The default page size is 200 (max 1000).</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>The next_page_token value returned from a previous list request, if any.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "searchTransitiveMemberships";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/memberships:searchTransitiveMemberships";

                /// <summary>Initializes SearchTransitiveMemberships parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^groups/[^/]+$",
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

        /// <summary>Creates a `Group`.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.CloudIdentity.v1beta1.Data.Group body)
        {
            return new CreateRequest(service, body);
        }

        /// <summary>Creates a `Group`.</summary>
        public class CreateRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1beta1.Data.Operation>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudIdentity.v1beta1.Data.Group body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The initial configuration option for the `Group`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("initialGroupConfig", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<InitialGroupConfigEnum> InitialGroupConfig { get; set; }

            /// <summary>Required. The initial configuration option for the `Group`.</summary>
            public enum InitialGroupConfigEnum
            {
                /// <summary>Default. Should not be used.</summary>
                [Google.Apis.Util.StringValueAttribute("INITIAL_GROUP_CONFIG_UNSPECIFIED")]
                INITIALGROUPCONFIGUNSPECIFIED = 0,

                /// <summary>
                /// The end user making the request will be added as the initial owner of the `Group`.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("WITH_INITIAL_OWNER")]
                WITHINITIALOWNER = 1,

                /// <summary>
                /// An empty group is created without any initial owners. This can only be used by admins of the domain.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("EMPTY")]
                EMPTY = 2,
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudIdentity.v1beta1.Data.Group Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/groups";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("initialGroupConfig", new Google.Apis.Discovery.Parameter
                {
                    Name = "initialGroupConfig",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Deletes a `Group`.</summary>
        /// <param name="name">
        /// Required. The [resource name](https://cloud.google.com/apis/design/resource_names) of the `Group` to
        /// retrieve. Must be of the form `groups/{group_id}`.
        /// </param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(service, name);
        }

        /// <summary>Deletes a `Group`.</summary>
        public class DeleteRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1beta1.Data.Operation>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The [resource name](https://cloud.google.com/apis/design/resource_names) of the `Group` to
            /// retrieve. Must be of the form `groups/{group_id}`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/{+name}";

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
                    Pattern = @"^groups/[^/]+$",
                });
            }
        }

        /// <summary>Retrieves a `Group`.</summary>
        /// <param name="name">
        /// Required. The [resource name](https://cloud.google.com/apis/design/resource_names) of the `Group` to
        /// retrieve. Must be of the form `groups/{group_id}`.
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>Retrieves a `Group`.</summary>
        public class GetRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1beta1.Data.Group>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The [resource name](https://cloud.google.com/apis/design/resource_names) of the `Group` to
            /// retrieve. Must be of the form `groups/{group_id}`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/{+name}";

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
                    Pattern = @"^groups/[^/]+$",
                });
            }
        }

        /// <summary>Lists the `Group` resources under a customer or namespace.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Lists the `Group` resources under a customer or namespace.</summary>
        public class ListRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1beta1.Data.ListGroupsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// The maximum number of results to return. Note that the number of results returned may be less than this
            /// value even if there are more available results. To fetch all results, clients must continue calling this
            /// method repeatedly until the response no longer contains a `next_page_token`. If unspecified, defaults to
            /// 200 for `View.BASIC` and to 50 for `View.FULL`. Must not be greater than 1000 for `View.BASIC` or 500
            /// for `View.FULL`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>The `next_page_token` value returned from a previous list request, if any.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Required. The parent resource under which to list all `Group` resources. Must be of the form
            /// `identitysources/{identity_source_id}` for external- identity-mapped groups or `customers/{customer_id}`
            /// for Google Groups. The `customer_id` must begin with "C" (for example, 'C046psxkn').
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Parent { get; set; }

            /// <summary>The level of detail to be returned. If unspecified, defaults to `View.BASIC`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewEnum> View { get; set; }

            /// <summary>The level of detail to be returned. If unspecified, defaults to `View.BASIC`.</summary>
            public enum ViewEnum
            {
                /// <summary>Default. Should not be used.</summary>
                [Google.Apis.Util.StringValueAttribute("VIEW_UNSPECIFIED")]
                VIEWUNSPECIFIED = 0,

                /// <summary>Only basic resource information is returned.</summary>
                [Google.Apis.Util.StringValueAttribute("BASIC")]
                BASIC = 1,

                /// <summary>All resource information is returned.</summary>
                [Google.Apis.Util.StringValueAttribute("FULL")]
                FULL = 2,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/groups";

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
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                {
                    Name = "view",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Looks up the [resource name](https://cloud.google.com/apis/design/resource_names) of a `Group` by its
        /// `EntityKey`.
        /// </summary>
        public virtual LookupRequest Lookup()
        {
            return new LookupRequest(service);
        }

        /// <summary>
        /// Looks up the [resource name](https://cloud.google.com/apis/design/resource_names) of a `Group` by its
        /// `EntityKey`.
        /// </summary>
        public class LookupRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1beta1.Data.LookupGroupNameResponse>
        {
            /// <summary>Constructs a new Lookup request.</summary>
            public LookupRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// The ID of the entity. For Google-managed entities, the `id` must be the email address of an existing
            /// group or user. For external-identity-mapped entities, the `id` must be a string conforming to the
            /// Identity Source's requirements. Must be unique within a `namespace`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("groupKey.id", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string GroupKeyId { get; set; }

            /// <summary>
            /// The namespace in which the entity exists. If not specified, the `EntityKey` represents a Google-managed
            /// entity such as a Google user or a Google Group. If specified, the `EntityKey` represents an
            /// external-identity-mapped group. The namespace must correspond to an identity source created in Admin
            /// Console and must be in the form of `identitysources/{identity_source_id}`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("groupKey.namespace", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string GroupKeyNamespace { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "lookup";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/groups:lookup";

            /// <summary>Initializes Lookup parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("groupKey.id", new Google.Apis.Discovery.Parameter
                {
                    Name = "groupKey.id",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("groupKey.namespace", new Google.Apis.Discovery.Parameter
                {
                    Name = "groupKey.namespace",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates a `Group`.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Output only. The [resource name](https://cloud.google.com/apis/design/resource_names) of the `Group`. Shall
        /// be of the form `groups/{group_id}`.
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.CloudIdentity.v1beta1.Data.Group body, string name)
        {
            return new PatchRequest(service, body, name);
        }

        /// <summary>Updates a `Group`.</summary>
        public class PatchRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1beta1.Data.Operation>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudIdentity.v1beta1.Data.Group body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Output only. The [resource name](https://cloud.google.com/apis/design/resource_names) of the `Group`.
            /// Shall be of the form `groups/{group_id}`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// Required. The names of fields to update. May only contain the following fields: `display_name`,
            /// `description`, `labels`, `dynamic_group_metadata`, `posix_groups`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudIdentity.v1beta1.Data.Group Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/{+name}";

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
                    Pattern = @"^groups/[^/]+$",
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

        /// <summary>Searches for `Group` resources matching a specified query.</summary>
        public virtual SearchRequest Search()
        {
            return new SearchRequest(service);
        }

        /// <summary>Searches for `Group` resources matching a specified query.</summary>
        public class SearchRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1beta1.Data.SearchGroupsResponse>
        {
            /// <summary>Constructs a new Search request.</summary>
            public SearchRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// The maximum number of results to return. Note that the number of results returned may be less than this
            /// value even if there are more available results. To fetch all results, clients must continue calling this
            /// method repeatedly until the response no longer contains a `next_page_token`. If unspecified, defaults to
            /// 200 for `GroupView.BASIC` and to 50 for `GroupView.FULL`. Must not be greater than 1000 for
            /// `GroupView.BASIC` or 500 for `GroupView.FULL`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>The `next_page_token` value returned from a previous search request, if any.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Required. The search query. Must be specified in [Common Expression
            /// Language](https://opensource.google/projects/cel). May only contain equality operators on the parent and
            /// inclusion operators on labels (e.g., `parent == 'customers/{customer_id}' &amp;amp;&amp;amp;
            /// 'cloudidentity.googleapis.com/groups.discussion_forum' in labels`). The `customer_id` must begin with
            /// "C" (for example, 'C046psxkn').
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query { get; set; }

            /// <summary>The level of detail to be returned. If unspecified, defaults to `View.BASIC`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewEnum> View { get; set; }

            /// <summary>The level of detail to be returned. If unspecified, defaults to `View.BASIC`.</summary>
            public enum ViewEnum
            {
                /// <summary>Default. Only basic resource information is returned.</summary>
                [Google.Apis.Util.StringValueAttribute("BASIC")]
                BASIC = 0,

                /// <summary>All resource information is returned.</summary>
                [Google.Apis.Util.StringValueAttribute("FULL")]
                FULL = 1,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "search";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/groups:search";

            /// <summary>Initializes Search parameter list.</summary>
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
                RequestParameters.Add("query", new Google.Apis.Discovery.Parameter
                {
                    Name = "query",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                {
                    Name = "view",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.CloudIdentity.v1beta1.Data
{
    /// <summary>Resource representing the Android specific attributes of a Device.</summary>
    public class AndroidAttributes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether applications from unknown sources can be installed on device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabledUnknownSources")]
        public virtual System.Nullable<bool> EnabledUnknownSources { get; set; }

        /// <summary>
        /// Whether this account is on an owner/primary profile. For phones, only true for owner profiles. Android 4+
        /// devices can have secondary or restricted user profiles.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerProfileAccount")]
        public virtual System.Nullable<bool> OwnerProfileAccount { get; set; }

        /// <summary>Ownership privileges on device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownershipPrivilege")]
        public virtual string OwnershipPrivilege { get; set; }

        /// <summary>
        /// Whether device supports Android work profiles. If false, this service will not block access to corp data
        /// even if an administrator turns on the "Enforce Work Profile" policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportsWorkProfile")]
        public virtual System.Nullable<bool> SupportsWorkProfile { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for approving the device to access user data.</summary>
    public class ApproveDeviceUserRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for approving the device to access user data.</summary>
    public class ApproveDeviceUserResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resultant DeviceUser object for the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceUser")]
        public virtual DeviceUser DeviceUser { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for blocking account on device.</summary>
    public class BlockDeviceUserRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for blocking the device from accessing user data.</summary>
    public class BlockDeviceUserResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resultant DeviceUser object for the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceUser")]
        public virtual DeviceUser DeviceUser { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to cancel sent invitation for target email in UserInvitation.</summary>
    public class CancelUserInvitationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for cancelling an unfinished device wipe.</summary>
    public class CancelWipeDeviceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for cancelling an unfinished device wipe.</summary>
    public class CancelWipeDeviceResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Resultant Device object for the action. Note that asset tags will not be returned in the device object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("device")]
        public virtual Device Device { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for cancelling an unfinished user account wipe.</summary>
    public class CancelWipeDeviceUserRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for cancelling an unfinished user account wipe.</summary>
    public class CancelWipeDeviceUserResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resultant DeviceUser object for the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceUser")]
        public virtual DeviceUser DeviceUser { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for MembershipsService.CheckTransitiveMembership.</summary>
    public class CheckTransitiveMembershipResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Response does not include the possible roles of a member since the behavior of this rpc is not
        /// all-or-nothing unlike the other rpcs. So, it may not be possible to list all the roles definitively, due to
        /// possible lack of authorization in some of the paths.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasMembership")]
        public virtual System.Nullable<bool> HasMembership { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents the state associated with an API client calling the Devices API. Resource representing ClientState
    /// and supports updates from API users
    /// </summary>
    public class ClientState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The caller can specify asset tags for this resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetTags")]
        public virtual System.Collections.Generic.IList<string> AssetTags { get; set; }

        /// <summary>The compliance state of the resource as specified by the API client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("complianceState")]
        public virtual string ComplianceState { get; set; }

        /// <summary>Output only. The time the client state data was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// This field may be used to store a unique identifier for the API resource within which these CustomAttributes
        /// are a field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customId")]
        public virtual string CustomId { get; set; }

        /// <summary>
        /// The token that needs to be passed back for concurrency control in updates. Token needs to be passed back in
        /// UpdateRequest
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The Health score of the resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthScore")]
        public virtual string HealthScore { get; set; }

        /// <summary>
        /// The map of key-value attributes stored by callers specific to a device. The total serialized length of this
        /// map may not exceed 10KB. No limit is placed on the number of attributes in a map.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyValuePairs")]
        public virtual System.Collections.Generic.IDictionary<string, CustomAttributeValue> KeyValuePairs { get; set; }

        /// <summary>Output only. The time the client state data was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdateTime")]
        public virtual object LastUpdateTime { get; set; }

        /// <summary>The management state of the resource as specified by the API client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managed")]
        public virtual string Managed { get; set; }

        /// <summary>
        /// Output only. [Resource name](https://cloud.google.com/apis/design/resource_names) of the ClientState in
        /// format: `devices/{device_id}/deviceUsers/{device_user_id}/clientState/{partner_id}`, where partner_id
        /// corresponds to the partner storing the data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The owner of the ClientState</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerType")]
        public virtual string OwnerType { get; set; }

        /// <summary>A descriptive cause of the health score.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scoreReason")]
        public virtual string ScoreReason { get; set; }
    }

    /// <summary>Request message for creating a Company Owned device.</summary>
    public class CreateDeviceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The device to be created. The name field within this device is ignored in the create method. A new
        /// name is created by the method, and returned within the response. Only the fields `device_type`,
        /// `serial_number` and `asset_tag` (if present) are used to create the device. All other fields are ignored.
        /// The `device_type` and `serial_number` fields are required.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("device")]
        public virtual Device Device { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional custom attribute values may be one of these types</summary>
    public class CustomAttributeValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Represents a boolean value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boolValue")]
        public virtual System.Nullable<bool> BoolValue { get; set; }

        /// <summary>Represents a double value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numberValue")]
        public virtual System.Nullable<double> NumberValue { get; set; }

        /// <summary>Represents a string value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Device within the Cloud Identity Devices API. Represents a Device known to Google Cloud, independent of the
    /// device ownership, type, and whether it is assigned or in use by a user.
    /// </summary>
    public class Device : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Attributes specific to Android devices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidSpecificAttributes")]
        public virtual AndroidAttributes AndroidSpecificAttributes { get; set; }

        /// <summary>Asset tag of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetTag")]
        public virtual string AssetTag { get; set; }

        /// <summary>Output only. Baseband version of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basebandVersion")]
        public virtual string BasebandVersion { get; set; }

        /// <summary>Output only. Device bootloader version. Example: 0.6.7.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootloaderVersion")]
        public virtual string BootloaderVersion { get; set; }

        /// <summary>Output only. Device brand. Example: Samsung.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("brand")]
        public virtual string Brand { get; set; }

        /// <summary>Output only. Build number of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildNumber")]
        public virtual string BuildNumber { get; set; }

        /// <summary>Output only. Represents whether the Device is compromised.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compromisedState")]
        public virtual string CompromisedState { get; set; }

        /// <summary>
        /// Output only. When the Company-Owned device was imported. This field is empty for BYOD devices.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. Type of device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceType")]
        public virtual string DeviceType { get; set; }

        /// <summary>Output only. Whether developer options is enabled on device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabledDeveloperOptions")]
        public virtual System.Nullable<bool> EnabledDeveloperOptions { get; set; }

        /// <summary>Output only. Whether USB debugging is enabled on device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabledUsbDebugging")]
        public virtual System.Nullable<bool> EnabledUsbDebugging { get; set; }

        /// <summary>Output only. Device encryption state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionState")]
        public virtual string EncryptionState { get; set; }

        /// <summary>Output only. IMEI number of device if GSM device; empty otherwise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imei")]
        public virtual string Imei { get; set; }

        /// <summary>Output only. Kernel version of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kernelVersion")]
        public virtual string KernelVersion { get; set; }

        /// <summary>Most recent time when device synced with this service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastSyncTime")]
        public virtual object LastSyncTime { get; set; }

        /// <summary>Output only. Management state of the device</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managementState")]
        public virtual string ManagementState { get; set; }

        /// <summary>Output only. Device manufacturer. Example: Motorola.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manufacturer")]
        public virtual string Manufacturer { get; set; }

        /// <summary>Output only. MEID number of device if CDMA device; empty otherwise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meid")]
        public virtual string Meid { get; set; }

        /// <summary>Output only. Model name of device. Example: Pixel 3.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; }

        /// <summary>
        /// Output only. [Resource name](https://cloud.google.com/apis/design/resource_names) of the Device in format:
        /// `devices/{device_id}`, where device_id is the unique id assigned to the Device.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Mobile or network operator of device, if available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkOperator")]
        public virtual string NetworkOperator { get; set; }

        /// <summary>Output only. OS version of the device. Example: Android 8.1.0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osVersion")]
        public virtual string OsVersion { get; set; }

        /// <summary>
        /// Output only. Domain name for Google accounts on device. Type for other accounts on device. On Android, will
        /// only be populated if |ownership_privilege| is |PROFILE_OWNER| or |DEVICE_OWNER|. Does not include the
        /// account signed in to the device policy app if that account's domain has only one account. Examples:
        /// "com.example", "xyz.com".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("otherAccounts")]
        public virtual System.Collections.Generic.IList<string> OtherAccounts { get; set; }

        /// <summary>Output only. Whether the device is owned by the company or an individual</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerType")]
        public virtual string OwnerType { get; set; }

        /// <summary>Output only. OS release version. Example: 6.0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseVersion")]
        public virtual string ReleaseVersion { get; set; }

        /// <summary>Output only. OS security patch update time on device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityPatchTime")]
        public virtual object SecurityPatchTime { get; set; }

        /// <summary>Serial Number of device. Example: HT82V1A01076.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serialNumber")]
        public virtual string SerialNumber { get; set; }

        /// <summary>WiFi MAC addresses of device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wifiMacAddresses")]
        public virtual System.Collections.Generic.IList<string> WifiMacAddresses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a user's use of a Device in the Cloud Identity Devices API. A DeviceUser is a resource representing a
    /// user's use of a Device
    /// </summary>
    public class DeviceUser : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Compromised State of the DeviceUser object</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compromisedState")]
        public virtual string CompromisedState { get; set; }

        /// <summary>When the user first signed in to the device</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. Most recent time when user registered with this service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstSyncTime")]
        public virtual object FirstSyncTime { get; set; }

        /// <summary>Output only. Default locale used on device, in IETF BCP-47 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>Output only. Last time when user synced with policies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastSyncTime")]
        public virtual object LastSyncTime { get; set; }

        /// <summary>Output only. Management state of the user on the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managementState")]
        public virtual string ManagementState { get; set; }

        /// <summary>
        /// Output only. [Resource name](https://cloud.google.com/apis/design/resource_names) of the DeviceUser in
        /// format: `devices/{device_id}/deviceUsers/{device_user_id}`, where `device_user_id` uniquely identifies a
        /// user's use of a device.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Password state of the DeviceUser object</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordState")]
        public virtual string PasswordState { get; set; }

        /// <summary>Output only. User agent on the device for this specific user</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userAgent")]
        public virtual string UserAgent { get; set; }

        /// <summary>Email address of the user registered on the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userEmail")]
        public virtual string UserEmail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Dynamic group metadata like queries and status.</summary>
    public class DynamicGroupMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Memberships will be the union of all queries. Only one entry with USER resource is currently supported.
        /// Customers can create up to 100 dynamic groups.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queries")]
        public virtual System.Collections.Generic.IList<DynamicGroupQuery> Queries { get; set; }

        /// <summary>Output only. Status of the dynamic group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual DynamicGroupStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines a query on a resource.</summary>
    public class DynamicGroupQuery : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Query that determines the memberships of the dynamic group. Examples: All users with at least one
        /// `organizations.department` of engineering. `user.organizations.exists(org, org.department=='engineering')`
        /// All users with at least one location that has `area` of `foo` and `building_id` of `bar`.
        /// `user.locations.exists(loc, loc.area=='foo' &amp;amp;&amp;amp; loc.building_id=='bar')`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The current status of a dynamic group along with timestamp.</summary>
    public class DynamicGroupStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Status of the dynamic group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>
        /// The latest time at which the dynamic group is guaranteed to be in the given status. If status is
        /// `UP_TO_DATE`, the latest time at which the dynamic group was confirmed to be up-to-date. If status is
        /// `UPDATING_MEMBERSHIPS`, the time at which dynamic group was created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusTime")]
        public virtual object StatusTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A unique identifier for an entity in the Cloud Identity Groups API. An entity can represent either a group with
    /// an optional `namespace` or a user without a `namespace`. The combination of `id` and `namespace` must be unique;
    /// however, the same `id` can be used with different `namespace`s.
    /// </summary>
    public class EntityKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The ID of the entity. For Google-managed entities, the `id` must be the email address of an existing group
        /// or user. For external-identity-mapped entities, the `id` must be a string conforming to the Identity
        /// Source's requirements. Must be unique within a `namespace`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// The namespace in which the entity exists. If not specified, the `EntityKey` represents a Google-managed
        /// entity such as a Google user or a Google Group. If specified, the `EntityKey` represents an
        /// external-identity-mapped group. The namespace must correspond to an identity source created in Admin Console
        /// and must be in the form of `identitysources/{identity_source_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespace")]
        public virtual string Namespace__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The `MembershipRole` expiry details.</summary>
    public class ExpiryDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time at which the `MembershipRole` will expire.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual object ExpireTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for MembershipsService.GetMembershipGraph.</summary>
    public class GetMembershipGraphResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The membership graph's path information represented as an adjacency list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adjacencyList")]
        public virtual System.Collections.Generic.IList<MembershipAdjacencyList> AdjacencyList { get; set; }

        /// <summary>
        /// The resources representing each group in the adjacency list. Each group in this list can be correlated to a
        /// 'group' of the MembershipAdjacencyList using the 'name' of the Group resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groups")]
        public virtual System.Collections.Generic.IList<Group> Groups { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource representing the Android specific attributes of a Device.</summary>
    public class GoogleAppsCloudidentityDevicesV1AndroidAttributes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether applications from unknown sources can be installed on device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabledUnknownSources")]
        public virtual System.Nullable<bool> EnabledUnknownSources { get; set; }

        /// <summary>
        /// Whether this account is on an owner/primary profile. For phones, only true for owner profiles. Android 4+
        /// devices can have secondary or restricted user profiles.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerProfileAccount")]
        public virtual System.Nullable<bool> OwnerProfileAccount { get; set; }

        /// <summary>Ownership privileges on device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownershipPrivilege")]
        public virtual string OwnershipPrivilege { get; set; }

        /// <summary>
        /// Whether device supports Android work profiles. If false, this service will not block access to corp data
        /// even if an administrator turns on the "Enforce Work Profile" policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportsWorkProfile")]
        public virtual System.Nullable<bool> SupportsWorkProfile { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for approving the device to access user data.</summary>
    public class GoogleAppsCloudidentityDevicesV1ApproveDeviceUserResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resultant DeviceUser object for the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceUser")]
        public virtual GoogleAppsCloudidentityDevicesV1DeviceUser DeviceUser { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for blocking the device from accessing user data.</summary>
    public class GoogleAppsCloudidentityDevicesV1BlockDeviceUserResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resultant DeviceUser object for the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceUser")]
        public virtual GoogleAppsCloudidentityDevicesV1DeviceUser DeviceUser { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for cancelling an unfinished device wipe.</summary>
    public class GoogleAppsCloudidentityDevicesV1CancelWipeDeviceResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Resultant Device object for the action. Note that asset tags will not be returned in the device object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("device")]
        public virtual GoogleAppsCloudidentityDevicesV1Device Device { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for cancelling an unfinished user account wipe.</summary>
    public class GoogleAppsCloudidentityDevicesV1CancelWipeDeviceUserResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resultant DeviceUser object for the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceUser")]
        public virtual GoogleAppsCloudidentityDevicesV1DeviceUser DeviceUser { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents the state associated with an API client calling the Devices API. Resource representing ClientState
    /// and supports updates from API users
    /// </summary>
    public class GoogleAppsCloudidentityDevicesV1ClientState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The caller can specify asset tags for this resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetTags")]
        public virtual System.Collections.Generic.IList<string> AssetTags { get; set; }

        /// <summary>The compliance state of the resource as specified by the API client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("complianceState")]
        public virtual string ComplianceState { get; set; }

        /// <summary>Output only. The time the client state data was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// This field may be used to store a unique identifier for the API resource within which these CustomAttributes
        /// are a field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customId")]
        public virtual string CustomId { get; set; }

        /// <summary>
        /// The token that needs to be passed back for concurrency control in updates. Token needs to be passed back in
        /// UpdateRequest
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// The Health score of the resource. The Health score is the callers specification of the condition of the
        /// device from a usability point of view. For example, a third-party device management provider may specify a
        /// health score based on its compliance with organizational policies.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthScore")]
        public virtual string HealthScore { get; set; }

        /// <summary>
        /// The map of key-value attributes stored by callers specific to a device. The total serialized length of this
        /// map may not exceed 10KB. No limit is placed on the number of attributes in a map.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyValuePairs")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleAppsCloudidentityDevicesV1CustomAttributeValue> KeyValuePairs { get; set; }

        /// <summary>Output only. The time the client state data was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdateTime")]
        public virtual object LastUpdateTime { get; set; }

        /// <summary>The management state of the resource as specified by the API client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managed")]
        public virtual string Managed { get; set; }

        /// <summary>
        /// Output only. [Resource name](https://cloud.google.com/apis/design/resource_names) of the ClientState in
        /// format: `devices/{device_id}/deviceUsers/{device_user_id}/clientState/{partner_id}`, where partner_id
        /// corresponds to the partner storing the data. For partners belonging to the "BeyondCorp Alliance", this is
        /// the partner ID specified to you by Google. For all other callers, this is a string of the form:
        /// `{customer_id}-suffix`, where `customer_id` is your customer ID. The *suffix* is any string the caller
        /// specifies. This string will be displayed verbatim in the administration console. This suffix is used in
        /// setting up Custom Access Levels in Context-Aware Access. Your organization's customer ID can be obtained
        /// from the URL: `GET https://www.googleapis.com/admin/directory/v1/customers/my_customer` The `id` field in
        /// the response contains the customer ID starting with the letter 'C'. The customer ID to be used in this API
        /// is the string after the letter 'C' (not including 'C')
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The owner of the ClientState</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerType")]
        public virtual string OwnerType { get; set; }

        /// <summary>A descriptive cause of the health score.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scoreReason")]
        public virtual string ScoreReason { get; set; }
    }

    /// <summary>Additional custom attribute values may be one of these types</summary>
    public class GoogleAppsCloudidentityDevicesV1CustomAttributeValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Represents a boolean value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boolValue")]
        public virtual System.Nullable<bool> BoolValue { get; set; }

        /// <summary>Represents a double value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numberValue")]
        public virtual System.Nullable<double> NumberValue { get; set; }

        /// <summary>Represents a string value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    ///  A Device within the Cloud Identity Devices API. Represents a Device known to Google Cloud, independent of the
    /// device ownership, type, and whether it is assigned or in use by a user.
    /// </summary>
    public class GoogleAppsCloudidentityDevicesV1Device : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Attributes specific to Android devices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidSpecificAttributes")]
        public virtual GoogleAppsCloudidentityDevicesV1AndroidAttributes AndroidSpecificAttributes { get; set; }

        /// <summary>Asset tag of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetTag")]
        public virtual string AssetTag { get; set; }

        /// <summary>Output only. Baseband version of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basebandVersion")]
        public virtual string BasebandVersion { get; set; }

        /// <summary>Output only. Device bootloader version. Example: 0.6.7.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootloaderVersion")]
        public virtual string BootloaderVersion { get; set; }

        /// <summary>Output only. Device brand. Example: Samsung.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("brand")]
        public virtual string Brand { get; set; }

        /// <summary>Output only. Build number of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildNumber")]
        public virtual string BuildNumber { get; set; }

        /// <summary>Output only. Represents whether the Device is compromised.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compromisedState")]
        public virtual string CompromisedState { get; set; }

        /// <summary>
        /// Output only. When the Company-Owned device was imported. This field is empty for BYOD devices.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. Type of device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceType")]
        public virtual string DeviceType { get; set; }

        /// <summary>Output only. Whether developer options is enabled on device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabledDeveloperOptions")]
        public virtual System.Nullable<bool> EnabledDeveloperOptions { get; set; }

        /// <summary>Output only. Whether USB debugging is enabled on device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabledUsbDebugging")]
        public virtual System.Nullable<bool> EnabledUsbDebugging { get; set; }

        /// <summary>Output only. Device encryption state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionState")]
        public virtual string EncryptionState { get; set; }

        /// <summary>Output only. IMEI number of device if GSM device; empty otherwise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imei")]
        public virtual string Imei { get; set; }

        /// <summary>Output only. Kernel version of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kernelVersion")]
        public virtual string KernelVersion { get; set; }

        /// <summary>Most recent time when device synced with this service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastSyncTime")]
        public virtual object LastSyncTime { get; set; }

        /// <summary>Output only. Management state of the device</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managementState")]
        public virtual string ManagementState { get; set; }

        /// <summary>Output only. Device manufacturer. Example: Motorola.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manufacturer")]
        public virtual string Manufacturer { get; set; }

        /// <summary>Output only. MEID number of device if CDMA device; empty otherwise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meid")]
        public virtual string Meid { get; set; }

        /// <summary>Output only. Model name of device. Example: Pixel 3.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; }

        /// <summary>
        /// Output only. [Resource name](https://cloud.google.com/apis/design/resource_names) of the Device in format:
        /// `devices/{device_id}`, where device_id is the unique id assigned to the Device.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Mobile or network operator of device, if available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkOperator")]
        public virtual string NetworkOperator { get; set; }

        /// <summary>Output only. OS version of the device. Example: Android 8.1.0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osVersion")]
        public virtual string OsVersion { get; set; }

        /// <summary>
        /// Output only. Domain name for Google accounts on device. Type for other accounts on device. On Android, will
        /// only be populated if |ownership_privilege| is |PROFILE_OWNER| or |DEVICE_OWNER|. Does not include the
        /// account signed in to the device policy app if that account's domain has only one account. Examples:
        /// "com.example", "xyz.com".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("otherAccounts")]
        public virtual System.Collections.Generic.IList<string> OtherAccounts { get; set; }

        /// <summary>Output only. Whether the device is owned by the company or an individual</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerType")]
        public virtual string OwnerType { get; set; }

        /// <summary>Output only. OS release version. Example: 6.0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseVersion")]
        public virtual string ReleaseVersion { get; set; }

        /// <summary>Output only. OS security patch update time on device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityPatchTime")]
        public virtual object SecurityPatchTime { get; set; }

        /// <summary>Serial Number of device. Example: HT82V1A01076.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serialNumber")]
        public virtual string SerialNumber { get; set; }

        /// <summary>WiFi MAC addresses of device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wifiMacAddresses")]
        public virtual System.Collections.Generic.IList<string> WifiMacAddresses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a user's use of a Device in the Cloud Identity Devices API. A DeviceUser is a resource representing a
    /// user's use of a Device
    /// </summary>
    public class GoogleAppsCloudidentityDevicesV1DeviceUser : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Compromised State of the DeviceUser object</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compromisedState")]
        public virtual string CompromisedState { get; set; }

        /// <summary>When the user first signed in to the device</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. Most recent time when user registered with this service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstSyncTime")]
        public virtual object FirstSyncTime { get; set; }

        /// <summary>Output only. Default locale used on device, in IETF BCP-47 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>Output only. Last time when user synced with policies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastSyncTime")]
        public virtual object LastSyncTime { get; set; }

        /// <summary>Output only. Management state of the user on the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managementState")]
        public virtual string ManagementState { get; set; }

        /// <summary>
        /// Output only. [Resource name](https://cloud.google.com/apis/design/resource_names) of the DeviceUser in
        /// format: `devices/{device_id}/deviceUsers/{device_user_id}`, where `device_user_id` uniquely identifies a
        /// user's use of a device.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Password state of the DeviceUser object</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordState")]
        public virtual string PasswordState { get; set; }

        /// <summary>Output only. User agent on the device for this specific user</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userAgent")]
        public virtual string UserAgent { get; set; }

        /// <summary>Email address of the user registered on the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userEmail")]
        public virtual string UserEmail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for wiping all data on the device.</summary>
    public class GoogleAppsCloudidentityDevicesV1WipeDeviceResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Resultant Device object for the action. Note that asset tags will not be returned in the device object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("device")]
        public virtual GoogleAppsCloudidentityDevicesV1Device Device { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for wiping the user's account from the device.</summary>
    public class GoogleAppsCloudidentityDevicesV1WipeDeviceUserResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resultant DeviceUser object for the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceUser")]
        public virtual GoogleAppsCloudidentityDevicesV1DeviceUser DeviceUser { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A group within the Cloud Identity Groups API. A `Group` is a collection of entities, where each entity is either
    /// a user, another group, or a service account.
    /// </summary>
    public class Group : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional entity key aliases for a Group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalGroupKeys")]
        public virtual System.Collections.Generic.IList<EntityKey> AdditionalGroupKeys { get; set; }

        /// <summary>Output only. The time when the `Group` was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// An extended description to help users determine the purpose of a `Group`. Must not be longer than 4,096
        /// characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The display name of the `Group`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Optional. Dynamic group metadata like queries and status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dynamicGroupMetadata")]
        public virtual DynamicGroupMetadata DynamicGroupMetadata { get; set; }

        /// <summary>Required. Immutable. The `EntityKey` of the `Group`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupKey")]
        public virtual EntityKey GroupKey { get; set; }

        /// <summary>
        /// Required. One or more label entries that apply to the Group. Currently supported labels contain a key with
        /// an empty value. Google Groups are the default type of group and have a label with a key of
        /// `cloudidentity.googleapis.com/groups.discussion_forum` and an empty value. Existing Google Groups can have
        /// an additional label with a key of `cloudidentity.googleapis.com/groups.security` and an empty value added to
        /// them. **This is an immutable change and the security label cannot be removed once added.** Dynamic groups
        /// have a label with a key of `cloudidentity.googleapis.com/groups.dynamic`. Identity-mapped groups for Cloud
        /// Search have a label with a key of `system/groups/external` and an empty value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Output only. The [resource name](https://cloud.google.com/apis/design/resource_names) of the `Group`. Shall
        /// be of the form `groups/{group_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. Immutable. The resource name of the entity under which this `Group` resides in the Cloud Identity
        /// resource hierarchy. Must be of the form `identitysources/{identity_source_id}` for external- identity-mapped
        /// groups or `customers/{customer_id}` for Google Groups. The `customer_id` must begin with "C" (for example,
        /// 'C046psxkn').
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>Optional. The POSIX groups associated with the `Group`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("posixGroups")]
        public virtual System.Collections.Generic.IList<PosixGroup> PosixGroups { get; set; }

        /// <summary>Output only. The time when the `Group` was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message representing a transitive group of a user or a group.</summary>
    public class GroupRelation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Display name for this group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Resource name for this group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("group")]
        public virtual string Group { get; set; }

        /// <summary>
        /// Entity key has an id and a namespace. In case of discussion forums, the id will be an email address without
        /// a namespace.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupKey")]
        public virtual EntityKey GroupKey { get; set; }

        /// <summary>Labels for Group resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The relation between the member and the transitive group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relationType")]
        public virtual string RelationType { get; set; }

        /// <summary>Membership roles of the member for the group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roles")]
        public virtual System.Collections.Generic.IList<TransitiveMembershipRole> Roles { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for IsInvitableUser RPC.</summary>
    public class IsInvitableUserResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Returns true if the email address is invitable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isInvitableUser")]
        public virtual System.Nullable<bool> IsInvitableUser { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message that is returned in LRO result of ListClientStates Operation.</summary>
    public class ListClientStatesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Client states meeting the list restrictions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientStates")]
        public virtual System.Collections.Generic.IList<ClientState> ClientStates { get; set; }

        /// <summary>Token to retrieve the next page of results. Empty if there are no more results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message that is returned from the ListDeviceUsers method.</summary>
    public class ListDeviceUsersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Devices meeting the list restrictions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceUsers")]
        public virtual System.Collections.Generic.IList<DeviceUser> DeviceUsers { get; set; }

        /// <summary>Token to retrieve the next page of results. Empty if there are no more results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message that is returned from the ListDevices method.</summary>
    public class ListDevicesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Devices meeting the list restrictions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("devices")]
        public virtual System.Collections.Generic.IList<Device> Devices { get; set; }

        /// <summary>Token to retrieve the next page of results. Empty if there are no more results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for GroupsService.ListGroups.</summary>
    public class ListGroupsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The `Group` resources under the specified `parent`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groups")]
        public virtual System.Collections.Generic.IList<Group> Groups { get; set; }

        /// <summary>
        /// A continuation token to retrieve the next page of results, or empty if there are no more results available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for MembershipsService.ListMemberships.</summary>
    public class ListMembershipsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The `Membership`s under the specified `parent`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memberships")]
        public virtual System.Collections.Generic.IList<Membership> Memberships { get; set; }

        /// <summary>
        /// A continuation token to retrieve the next page of results, or empty if there are no more results available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for UserInvitation listing request.</summary>
    public class ListUserInvitationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The token for the next page. If not empty, indicates that there may be more `UserInvitation` resources that
        /// match the listing request; this value can be used in a subsequent ListUserInvitationsRequest to get
        /// continued results with the current list call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of UserInvitation resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userInvitations")]
        public virtual System.Collections.Generic.IList<UserInvitation> UserInvitations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for GroupsService.LookupGroupName.</summary>
    public class LookupGroupNameResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The [resource name](https://cloud.google.com/apis/design/resource_names) of the looked-up
        /// `Group`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for MembershipsService.LookupMembershipName.</summary>
    public class LookupMembershipNameResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The [resource name](https://cloud.google.com/apis/design/resource_names) of the looked-up `Membership`. Must
        /// be of the form `groups/{group_id}/memberships/{membership_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response containing resource names of the DeviceUsers associated with the caller's credentials.
    /// </summary>
    public class LookupSelfDeviceUsersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The obfuscated customer Id that may be passed back to other Devices API methods such as List, Get, etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customer")]
        public virtual string Customer { get; set; }

        /// <summary>
        /// [Resource names](https://cloud.google.com/apis/design/resource_names) of the DeviceUsers in the format:
        /// `devices/{device_id}/deviceUsers/{user_resource_id}`, where device_id is the unique ID assigned to a Device
        /// and user_resource_id is the unique user ID
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("names")]
        public virtual System.Collections.Generic.IList<string> Names { get; set; }

        /// <summary>Token to retrieve the next page of results. Empty if there are no more results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message representing a transitive membership of a group.</summary>
    public class MemberRelation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resource name for this member.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("member")]
        public virtual string Member { get; set; }

        /// <summary>
        /// Entity key has an id and a namespace. In case of discussion forums, the id will be an email address without
        /// a namespace.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preferredMemberKey")]
        public virtual System.Collections.Generic.IList<EntityKey> PreferredMemberKey { get; set; }

        /// <summary>The relation between the group and the transitive member.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relationType")]
        public virtual string RelationType { get; set; }

        /// <summary>The membership role details (i.e name of role and expiry time).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roles")]
        public virtual System.Collections.Generic.IList<TransitiveMembershipRole> Roles { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A membership within the Cloud Identity Groups API. A `Membership` defines a relationship between a `Group` and
    /// an entity belonging to that `Group`, referred to as a "member".
    /// </summary>
    public class Membership : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time when the `Membership` was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Immutable. The `EntityKey` of the member. Either `member_key` or `preferred_member_key` must be set when
        /// calling MembershipsService.CreateMembership but not both; both shall be set when returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memberKey")]
        public virtual EntityKey MemberKey { get; set; }

        /// <summary>
        /// Output only. The [resource name](https://cloud.google.com/apis/design/resource_names) of the `Membership`.
        /// Shall be of the form `groups/{group_id}/memberships/{membership_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. Immutable. The `EntityKey` of the member. Either `member_key` or `preferred_member_key` must be
        /// set when calling MembershipsService.CreateMembership but not both; both shall be set when returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preferredMemberKey")]
        public virtual EntityKey PreferredMemberKey { get; set; }

        /// <summary>
        /// The `MembershipRole`s that apply to the `Membership`. If unspecified, defaults to a single `MembershipRole`
        /// with `name` `MEMBER`. Must not contain duplicate `MembershipRole`s with the same `name`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roles")]
        public virtual System.Collections.Generic.IList<MembershipRole> Roles { get; set; }

        /// <summary>Output only. The type of the membership.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Output only. The time when the `Membership` was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Membership graph's path information as an adjacency list.</summary>
    public class MembershipAdjacencyList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Each edge contains information about the member that belongs to this group. Note: Fields returned here will
        /// help identify the specific Membership resource (e.g name, preferred_member_key and role), but may not be a
        /// comprehensive list of all fields.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("edges")]
        public virtual System.Collections.Generic.IList<Membership> Edges { get; set; }

        /// <summary>Resource name of the group that the members belong to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("group")]
        public virtual string Group { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A membership role within the Cloud Identity Groups API. A `MembershipRole` defines the privileges granted to a
    /// `Membership`.
    /// </summary>
    public class MembershipRole : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The expiry details of the `MembershipRole`. Expiry details are only supported for `MEMBER`
        /// `MembershipRoles`. May be set if `name` is `MEMBER`. Must not be set if `name` is any other value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expiryDetail")]
        public virtual ExpiryDetail ExpiryDetail { get; set; }

        /// <summary>The name of the `MembershipRole`. Must be one of `OWNER`, `MANAGER`, `MEMBER`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for MembershipsService.ModifyMembershipRoles.</summary>
    public class ModifyMembershipRolesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The `MembershipRole`s to be added. Adding or removing roles in the same request as updating roles is not
        /// supported. Must not be set if `update_roles_params` is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addRoles")]
        public virtual System.Collections.Generic.IList<MembershipRole> AddRoles { get; set; }

        /// <summary>
        /// The `name`s of the `MembershipRole`s to be removed. Adding or removing roles in the same request as updating
        /// roles is not supported. It is not possible to remove the `MEMBER` `MembershipRole`. If you wish to delete a
        /// `Membership`, call MembershipsService.DeleteMembership instead. Must not contain `MEMBER`. Must not be set
        /// if `update_roles_params` is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("removeRoles")]
        public virtual System.Collections.Generic.IList<string> RemoveRoles { get; set; }

        /// <summary>
        /// The `MembershipRole`s to be updated. Updating roles in the same request as adding or removing roles is not
        /// supported. Must not be set if either `add_roles` or `remove_roles` is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateRolesParams")]
        public virtual System.Collections.Generic.IList<UpdateMembershipRolesParams> UpdateRolesParams { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for MembershipsService.ModifyMembershipRoles.</summary>
    public class ModifyMembershipRolesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The `Membership` resource after modifying its `MembershipRole`s.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membership")]
        public virtual Membership Membership { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This resource represents a long-running operation that is the result of a network API call.</summary>
    public class Operation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the value is `false`, it means the operation is still in progress. If `true`, the operation is completed,
        /// and either `error` or `response` is available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("done")]
        public virtual System.Nullable<bool> Done { get; set; }

        /// <summary>The error result of the operation in case of failure or cancellation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>
        /// Service-specific metadata associated with the operation. It typically contains progress information and
        /// common metadata such as create time. Some services might not provide such metadata. Any method that returns
        /// a long-running operation should document the metadata type, if any.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// The server-assigned name, which is only unique within the same service that originally returns it. If you
        /// use the default HTTP mapping, the `name` should be a resource name ending with `operations/{unique_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The normal response of the operation in case of success. If the original method returns no data on success,
        /// such as `Delete`, the response is `google.protobuf.Empty`. If the original method is standard
        /// `Get`/`Create`/`Update`, the response should be the resource. For other methods, the response should have
        /// the type `XxxResponse`, where `Xxx` is the original method name. For example, if the original method name is
        /// `TakeSnapshot()`, the inferred response type is `TakeSnapshotResponse`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string, object> Response { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>POSIX Group definition to represent a group in a POSIX compliant system.</summary>
    public class PosixGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>GID of the POSIX group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gid")]
        public virtual System.Nullable<ulong> Gid { get; set; }

        /// <summary>Name of the POSIX group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// System identifier for which group name and gid apply to. If not specified it will default to empty value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemId")]
        public virtual string SystemId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for GroupsService.SearchGroups.</summary>
    public class SearchGroupsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The `Group` resources that match the search query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groups")]
        public virtual System.Collections.Generic.IList<Group> Groups { get; set; }

        /// <summary>
        /// A continuation token to retrieve the next page of results, or empty if there are no more results available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for MembershipsService.SearchTransitiveGroups.</summary>
    public class SearchTransitiveGroupsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of transitive groups satisfying the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memberships")]
        public virtual System.Collections.Generic.IList<GroupRelation> Memberships { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results available for listing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for MembershipsService.SearchTransitiveMemberships.</summary>
    public class SearchTransitiveMembershipsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of transitive members satisfying the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memberships")]
        public virtual System.Collections.Generic.IList<MemberRelation> Memberships { get; set; }

        /// <summary>Token to retrieve the next page of results, or empty if there are no more results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to send email for inviting target user corresponding to the UserInvitation.</summary>
    public class SendUserInvitationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
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

    /// <summary>Message representing the role of a TransitiveMembership.</summary>
    public class TransitiveMembershipRole : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// TransitiveMembershipRole in string format. Currently supported TransitiveMembershipRoles: `"MEMBER"`,
        /// `"OWNER"`, and `"MANAGER"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The details of an update to a `MembershipRole`.</summary>
    public class UpdateMembershipRolesParams : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fully-qualified names of fields to update. May only contain the field `expiry_detail.expire_time`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldMask")]
        public virtual object FieldMask { get; set; }

        /// <summary>
        /// The `MembershipRole`s to be updated. Only `MEMBER` `MembershipRoles` can currently be updated. May only
        /// contain a `MembershipRole` with `name` `MEMBER`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membershipRole")]
        public virtual MembershipRole MembershipRole { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The `UserInvitation` resource represents an email that can be sent to an unmanaged user account inviting them to
    /// join the customer’s Google Workspace or Cloud Identity account. An unmanaged account shares an email address
    /// domain with the Google Workspace or Cloud Identity account but is not managed by it yet. If the user accepts the
    /// `UserInvitation`, the user account will become managed.
    /// </summary>
    public class UserInvitation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of invitation emails sent to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mailsSentCount")]
        public virtual System.Nullable<long> MailsSentCount { get; set; }

        /// <summary>Shall be of the form `customers/{customer}/userinvitations/{user_email_address}`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>State of the `UserInvitation`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Time when the `UserInvitation` was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for wiping all data on the device.</summary>
    public class WipeDeviceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Specifies if a user is able to factory reset a device after a Device Wipe. On iOS, this is called
        /// "Activation Lock", while on Android, this is known as "Factory Reset Protection". If true, this protection
        /// will be removed from the device, so that a user can successfully factory reset. If false, the setting is
        /// untouched on the device.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("removeResetLock")]
        public virtual System.Nullable<bool> RemoveResetLock { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for wiping all data on the device.</summary>
    public class WipeDeviceResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Resultant Device object for the action. Note that asset tags will not be returned in the device object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("device")]
        public virtual Device Device { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for starting an account wipe on device.</summary>
    public class WipeDeviceUserRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for wiping the user's account from the device.</summary>
    public class WipeDeviceUserResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resultant DeviceUser object for the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceUser")]
        public virtual DeviceUser DeviceUser { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
