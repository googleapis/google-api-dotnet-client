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

namespace Google.Apis.Admin.Directory.directory_v1
{
    /// <summary>The Directory Service.</summary>
    public class DirectoryService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "directory_v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DirectoryService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DirectoryService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Asps = new AspsResource(this);
            Channels = new ChannelsResource(this);
            Chromeosdevices = new ChromeosdevicesResource(this);
            Customer = new CustomerResource(this);
            Customers = new CustomersResource(this);
            DomainAliases = new DomainAliasesResource(this);
            Domains = new DomainsResource(this);
            Groups = new GroupsResource(this);
            Members = new MembersResource(this);
            Mobiledevices = new MobiledevicesResource(this);
            Orgunits = new OrgunitsResource(this);
            Privileges = new PrivilegesResource(this);
            Resources = new ResourcesResource(this);
            RoleAssignments = new RoleAssignmentsResource(this);
            Roles = new RolesResource(this);
            Schemas = new SchemasResource(this);
            Tokens = new TokensResource(this);
            TwoStepVerification = new TwoStepVerificationResource(this);
            Users = new UsersResource(this);
            VerificationCodes = new VerificationCodesResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "admin";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://admin.googleapis.com/";
        #else
            "https://admin.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://admin.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Admin SDK API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, add, edit, and permanently delete the printers that your organization can use with Chrome
            /// </summary>
            public static string AdminChromePrinters = "https://www.googleapis.com/auth/admin.chrome.printers";

            /// <summary>See the printers that your organization can use with Chrome</summary>
            public static string AdminChromePrintersReadonly = "https://www.googleapis.com/auth/admin.chrome.printers.readonly";

            /// <summary>View and manage customer related information</summary>
            public static string AdminDirectoryCustomer = "https://www.googleapis.com/auth/admin.directory.customer";

            /// <summary>View customer related information</summary>
            public static string AdminDirectoryCustomerReadonly = "https://www.googleapis.com/auth/admin.directory.customer.readonly";

            /// <summary>View and manage your Chrome OS devices' metadata</summary>
            public static string AdminDirectoryDeviceChromeos = "https://www.googleapis.com/auth/admin.directory.device.chromeos";

            /// <summary>View your Chrome OS devices' metadata</summary>
            public static string AdminDirectoryDeviceChromeosReadonly = "https://www.googleapis.com/auth/admin.directory.device.chromeos.readonly";

            /// <summary>View and manage your mobile devices' metadata</summary>
            public static string AdminDirectoryDeviceMobile = "https://www.googleapis.com/auth/admin.directory.device.mobile";

            /// <summary>Manage your mobile devices by performing administrative tasks</summary>
            public static string AdminDirectoryDeviceMobileAction = "https://www.googleapis.com/auth/admin.directory.device.mobile.action";

            /// <summary>View your mobile devices' metadata</summary>
            public static string AdminDirectoryDeviceMobileReadonly = "https://www.googleapis.com/auth/admin.directory.device.mobile.readonly";

            /// <summary>View and manage the provisioning of domains for your customers</summary>
            public static string AdminDirectoryDomain = "https://www.googleapis.com/auth/admin.directory.domain";

            /// <summary>View domains related to your customers</summary>
            public static string AdminDirectoryDomainReadonly = "https://www.googleapis.com/auth/admin.directory.domain.readonly";

            /// <summary>View and manage the provisioning of groups on your domain</summary>
            public static string AdminDirectoryGroup = "https://www.googleapis.com/auth/admin.directory.group";

            /// <summary>View and manage group subscriptions on your domain</summary>
            public static string AdminDirectoryGroupMember = "https://www.googleapis.com/auth/admin.directory.group.member";

            /// <summary>View group subscriptions on your domain</summary>
            public static string AdminDirectoryGroupMemberReadonly = "https://www.googleapis.com/auth/admin.directory.group.member.readonly";

            /// <summary>View groups on your domain</summary>
            public static string AdminDirectoryGroupReadonly = "https://www.googleapis.com/auth/admin.directory.group.readonly";

            /// <summary>View and manage organization units on your domain</summary>
            public static string AdminDirectoryOrgunit = "https://www.googleapis.com/auth/admin.directory.orgunit";

            /// <summary>View organization units on your domain</summary>
            public static string AdminDirectoryOrgunitReadonly = "https://www.googleapis.com/auth/admin.directory.orgunit.readonly";

            /// <summary>View and manage the provisioning of calendar resources on your domain</summary>
            public static string AdminDirectoryResourceCalendar = "https://www.googleapis.com/auth/admin.directory.resource.calendar";

            /// <summary>View calendar resources on your domain</summary>
            public static string AdminDirectoryResourceCalendarReadonly = "https://www.googleapis.com/auth/admin.directory.resource.calendar.readonly";

            /// <summary>Manage delegated admin roles for your domain</summary>
            public static string AdminDirectoryRolemanagement = "https://www.googleapis.com/auth/admin.directory.rolemanagement";

            /// <summary>View delegated admin roles for your domain</summary>
            public static string AdminDirectoryRolemanagementReadonly = "https://www.googleapis.com/auth/admin.directory.rolemanagement.readonly";

            /// <summary>View and manage the provisioning of users on your domain</summary>
            public static string AdminDirectoryUser = "https://www.googleapis.com/auth/admin.directory.user";

            /// <summary>View and manage user aliases on your domain</summary>
            public static string AdminDirectoryUserAlias = "https://www.googleapis.com/auth/admin.directory.user.alias";

            /// <summary>View user aliases on your domain</summary>
            public static string AdminDirectoryUserAliasReadonly = "https://www.googleapis.com/auth/admin.directory.user.alias.readonly";

            /// <summary>See info about users on your domain</summary>
            public static string AdminDirectoryUserReadonly = "https://www.googleapis.com/auth/admin.directory.user.readonly";

            /// <summary>Manage data access permissions for users on your domain</summary>
            public static string AdminDirectoryUserSecurity = "https://www.googleapis.com/auth/admin.directory.user.security";

            /// <summary>View and manage the provisioning of user schemas on your domain</summary>
            public static string AdminDirectoryUserschema = "https://www.googleapis.com/auth/admin.directory.userschema";

            /// <summary>View user schemas on your domain</summary>
            public static string AdminDirectoryUserschemaReadonly = "https://www.googleapis.com/auth/admin.directory.userschema.readonly";

            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Admin SDK API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, add, edit, and permanently delete the printers that your organization can use with Chrome
            /// </summary>
            public const string AdminChromePrinters = "https://www.googleapis.com/auth/admin.chrome.printers";

            /// <summary>See the printers that your organization can use with Chrome</summary>
            public const string AdminChromePrintersReadonly = "https://www.googleapis.com/auth/admin.chrome.printers.readonly";

            /// <summary>View and manage customer related information</summary>
            public const string AdminDirectoryCustomer = "https://www.googleapis.com/auth/admin.directory.customer";

            /// <summary>View customer related information</summary>
            public const string AdminDirectoryCustomerReadonly = "https://www.googleapis.com/auth/admin.directory.customer.readonly";

            /// <summary>View and manage your Chrome OS devices' metadata</summary>
            public const string AdminDirectoryDeviceChromeos = "https://www.googleapis.com/auth/admin.directory.device.chromeos";

            /// <summary>View your Chrome OS devices' metadata</summary>
            public const string AdminDirectoryDeviceChromeosReadonly = "https://www.googleapis.com/auth/admin.directory.device.chromeos.readonly";

            /// <summary>View and manage your mobile devices' metadata</summary>
            public const string AdminDirectoryDeviceMobile = "https://www.googleapis.com/auth/admin.directory.device.mobile";

            /// <summary>Manage your mobile devices by performing administrative tasks</summary>
            public const string AdminDirectoryDeviceMobileAction = "https://www.googleapis.com/auth/admin.directory.device.mobile.action";

            /// <summary>View your mobile devices' metadata</summary>
            public const string AdminDirectoryDeviceMobileReadonly = "https://www.googleapis.com/auth/admin.directory.device.mobile.readonly";

            /// <summary>View and manage the provisioning of domains for your customers</summary>
            public const string AdminDirectoryDomain = "https://www.googleapis.com/auth/admin.directory.domain";

            /// <summary>View domains related to your customers</summary>
            public const string AdminDirectoryDomainReadonly = "https://www.googleapis.com/auth/admin.directory.domain.readonly";

            /// <summary>View and manage the provisioning of groups on your domain</summary>
            public const string AdminDirectoryGroup = "https://www.googleapis.com/auth/admin.directory.group";

            /// <summary>View and manage group subscriptions on your domain</summary>
            public const string AdminDirectoryGroupMember = "https://www.googleapis.com/auth/admin.directory.group.member";

            /// <summary>View group subscriptions on your domain</summary>
            public const string AdminDirectoryGroupMemberReadonly = "https://www.googleapis.com/auth/admin.directory.group.member.readonly";

            /// <summary>View groups on your domain</summary>
            public const string AdminDirectoryGroupReadonly = "https://www.googleapis.com/auth/admin.directory.group.readonly";

            /// <summary>View and manage organization units on your domain</summary>
            public const string AdminDirectoryOrgunit = "https://www.googleapis.com/auth/admin.directory.orgunit";

            /// <summary>View organization units on your domain</summary>
            public const string AdminDirectoryOrgunitReadonly = "https://www.googleapis.com/auth/admin.directory.orgunit.readonly";

            /// <summary>View and manage the provisioning of calendar resources on your domain</summary>
            public const string AdminDirectoryResourceCalendar = "https://www.googleapis.com/auth/admin.directory.resource.calendar";

            /// <summary>View calendar resources on your domain</summary>
            public const string AdminDirectoryResourceCalendarReadonly = "https://www.googleapis.com/auth/admin.directory.resource.calendar.readonly";

            /// <summary>Manage delegated admin roles for your domain</summary>
            public const string AdminDirectoryRolemanagement = "https://www.googleapis.com/auth/admin.directory.rolemanagement";

            /// <summary>View delegated admin roles for your domain</summary>
            public const string AdminDirectoryRolemanagementReadonly = "https://www.googleapis.com/auth/admin.directory.rolemanagement.readonly";

            /// <summary>View and manage the provisioning of users on your domain</summary>
            public const string AdminDirectoryUser = "https://www.googleapis.com/auth/admin.directory.user";

            /// <summary>View and manage user aliases on your domain</summary>
            public const string AdminDirectoryUserAlias = "https://www.googleapis.com/auth/admin.directory.user.alias";

            /// <summary>View user aliases on your domain</summary>
            public const string AdminDirectoryUserAliasReadonly = "https://www.googleapis.com/auth/admin.directory.user.alias.readonly";

            /// <summary>See info about users on your domain</summary>
            public const string AdminDirectoryUserReadonly = "https://www.googleapis.com/auth/admin.directory.user.readonly";

            /// <summary>Manage data access permissions for users on your domain</summary>
            public const string AdminDirectoryUserSecurity = "https://www.googleapis.com/auth/admin.directory.user.security";

            /// <summary>View and manage the provisioning of user schemas on your domain</summary>
            public const string AdminDirectoryUserschema = "https://www.googleapis.com/auth/admin.directory.userschema";

            /// <summary>View user schemas on your domain</summary>
            public const string AdminDirectoryUserschemaReadonly = "https://www.googleapis.com/auth/admin.directory.userschema.readonly";

            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Asps resource.</summary>
        public virtual AspsResource Asps { get; }

        /// <summary>Gets the Channels resource.</summary>
        public virtual ChannelsResource Channels { get; }

        /// <summary>Gets the Chromeosdevices resource.</summary>
        public virtual ChromeosdevicesResource Chromeosdevices { get; }

        /// <summary>Gets the Customer resource.</summary>
        public virtual CustomerResource Customer { get; }

        /// <summary>Gets the Customers resource.</summary>
        public virtual CustomersResource Customers { get; }

        /// <summary>Gets the DomainAliases resource.</summary>
        public virtual DomainAliasesResource DomainAliases { get; }

        /// <summary>Gets the Domains resource.</summary>
        public virtual DomainsResource Domains { get; }

        /// <summary>Gets the Groups resource.</summary>
        public virtual GroupsResource Groups { get; }

        /// <summary>Gets the Members resource.</summary>
        public virtual MembersResource Members { get; }

        /// <summary>Gets the Mobiledevices resource.</summary>
        public virtual MobiledevicesResource Mobiledevices { get; }

        /// <summary>Gets the Orgunits resource.</summary>
        public virtual OrgunitsResource Orgunits { get; }

        /// <summary>Gets the Privileges resource.</summary>
        public virtual PrivilegesResource Privileges { get; }

        /// <summary>Gets the Resources resource.</summary>
        public virtual ResourcesResource Resources { get; }

        /// <summary>Gets the RoleAssignments resource.</summary>
        public virtual RoleAssignmentsResource RoleAssignments { get; }

        /// <summary>Gets the Roles resource.</summary>
        public virtual RolesResource Roles { get; }

        /// <summary>Gets the Schemas resource.</summary>
        public virtual SchemasResource Schemas { get; }

        /// <summary>Gets the Tokens resource.</summary>
        public virtual TokensResource Tokens { get; }

        /// <summary>Gets the TwoStepVerification resource.</summary>
        public virtual TwoStepVerificationResource TwoStepVerification { get; }

        /// <summary>Gets the Users resource.</summary>
        public virtual UsersResource Users { get; }

        /// <summary>Gets the VerificationCodes resource.</summary>
        public virtual VerificationCodesResource VerificationCodes { get; }
    }

    /// <summary>A base abstract class for Directory requests.</summary>
    public abstract class DirectoryBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new DirectoryBaseServiceRequest instance.</summary>
        protected DirectoryBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Directory parameter list.</summary>
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

    /// <summary>The "asps" collection of methods.</summary>
    public class AspsResource
    {
        private const string Resource = "asps";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AspsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Delete an ASP issued by a user.</summary>
        /// <param name="userKey">
        /// Identifies the user in the API request. The value can be the user's primary email address, alias email
        /// address, or unique user ID.
        /// </param>
        /// <param name="codeId">The unique ID of the ASP to be deleted.</param>
        public virtual DeleteRequest Delete(string userKey, int codeId)
        {
            return new DeleteRequest(service, userKey, codeId);
        }

        /// <summary>Delete an ASP issued by a user.</summary>
        public class DeleteRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string userKey, int codeId) : base(service)
            {
                UserKey = userKey;
                CodeId = codeId;
                InitParameters();
            }

            /// <summary>
            /// Identifies the user in the API request. The value can be the user's primary email address, alias email
            /// address, or unique user ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserKey { get; private set; }

            /// <summary>The unique ID of the ASP to be deleted.</summary>
            [Google.Apis.Util.RequestParameterAttribute("codeId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual int CodeId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/users/{userKey}/asps/{codeId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("userKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "userKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("codeId", new Google.Apis.Discovery.Parameter
                {
                    Name = "codeId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Get information about an ASP issued by a user.</summary>
        /// <param name="userKey">
        /// Identifies the user in the API request. The value can be the user's primary email address, alias email
        /// address, or unique user ID.
        /// </param>
        /// <param name="codeId">The unique ID of the ASP.</param>
        public virtual GetRequest Get(string userKey, int codeId)
        {
            return new GetRequest(service, userKey, codeId);
        }

        /// <summary>Get information about an ASP issued by a user.</summary>
        public class GetRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Asp>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string userKey, int codeId) : base(service)
            {
                UserKey = userKey;
                CodeId = codeId;
                InitParameters();
            }

            /// <summary>
            /// Identifies the user in the API request. The value can be the user's primary email address, alias email
            /// address, or unique user ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserKey { get; private set; }

            /// <summary>The unique ID of the ASP.</summary>
            [Google.Apis.Util.RequestParameterAttribute("codeId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual int CodeId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/users/{userKey}/asps/{codeId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("userKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "userKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("codeId", new Google.Apis.Discovery.Parameter
                {
                    Name = "codeId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>List the ASPs issued by a user.</summary>
        /// <param name="userKey">
        /// Identifies the user in the API request. The value can be the user's primary email address, alias email
        /// address, or unique user ID.
        /// </param>
        public virtual ListRequest List(string userKey)
        {
            return new ListRequest(service, userKey);
        }

        /// <summary>List the ASPs issued by a user.</summary>
        public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Asps>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string userKey) : base(service)
            {
                UserKey = userKey;
                InitParameters();
            }

            /// <summary>
            /// Identifies the user in the API request. The value can be the user's primary email address, alias email
            /// address, or unique user ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserKey { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/users/{userKey}/asps";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("userKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "userKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "channels" collection of methods.</summary>
    public class ChannelsResource
    {
        private const string Resource = "channels";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ChannelsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Stop watching resources through this channel.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual StopRequest Stop(Google.Apis.Admin.Directory.directory_v1.Data.Channel body)
        {
            return new StopRequest(service, body);
        }

        /// <summary>Stop watching resources through this channel.</summary>
        public class StopRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Stop request.</summary>
            public StopRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Channel body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.Channel Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "stop";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory_v1/channels/stop";

            /// <summary>Initializes Stop parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "chromeosdevices" collection of methods.</summary>
    public class ChromeosdevicesResource
    {
        private const string Resource = "chromeosdevices";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ChromeosdevicesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Takes an action that affects a Chrome OS Device. This includes deprovisioning, disabling, and re-enabling
        /// devices. *Warning:* * Deprovisioning a device will stop device policy syncing and remove device-level
        /// printers. After a device is deprovisioned, it must be wiped before it can be re-enrolled. * Lost or stolen
        /// devices should use the disable action. * Re-enabling a disabled device will consume a device license. If you
        /// do not have sufficient licenses available when completing the re-enable action, you will receive an error.
        /// For more information about deprovisioning and disabling devices, visit the [help
        /// center](https://support.google.com/chrome/a/answer/3523633).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customerId">
        /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use the
        /// `my_customer` alias to represent your account's `customerId`. The `customerId` is also returned as part of
        /// the [Users resource](/admin-sdk/directory/v1/reference/users).
        /// </param>
        /// <param name="resourceId">
        /// The unique ID of the device. The `resourceId`s are returned in the response from the
        /// [chromeosdevices.list](/admin-sdk/directory/v1/reference/chromeosdevices/list) method.
        /// </param>
        public virtual ActionRequest Action(Google.Apis.Admin.Directory.directory_v1.Data.ChromeOsDeviceAction body, string customerId, string resourceId)
        {
            return new ActionRequest(service, body, customerId, resourceId);
        }

        /// <summary>
        /// Takes an action that affects a Chrome OS Device. This includes deprovisioning, disabling, and re-enabling
        /// devices. *Warning:* * Deprovisioning a device will stop device policy syncing and remove device-level
        /// printers. After a device is deprovisioned, it must be wiped before it can be re-enrolled. * Lost or stolen
        /// devices should use the disable action. * Re-enabling a disabled device will consume a device license. If you
        /// do not have sufficient licenses available when completing the re-enable action, you will receive an error.
        /// For more information about deprovisioning and disabling devices, visit the [help
        /// center](https://support.google.com/chrome/a/answer/3523633).
        /// </summary>
        public class ActionRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Action request.</summary>
            public ActionRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.ChromeOsDeviceAction body, string customerId, string resourceId) : base(service)
            {
                CustomerId = customerId;
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use
            /// the `my_customer` alias to represent your account's `customerId`. The `customerId` is also returned as
            /// part of the [Users resource](/admin-sdk/directory/v1/reference/users).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>
            /// The unique ID of the device. The `resourceId`s are returned in the response from the
            /// [chromeosdevices.list](/admin-sdk/directory/v1/reference/chromeosdevices/list) method.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.ChromeOsDeviceAction Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "action";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/devices/chromeos/{resourceId}/action";

            /// <summary>Initializes Action parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves a Chrome OS device's properties.</summary>
        /// <param name="customerId">
        /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use the
        /// `my_customer` alias to represent your account's `customerId`. The `customerId` is also returned as part of
        /// the [Users resource](/admin-sdk/directory/v1/reference/users).
        /// </param>
        /// <param name="deviceId">
        /// The unique ID of the device. The `deviceId`s are returned in the response from the
        /// [chromeosdevices.list](/admin-sdk/directory/v1/reference/chromeosdevices/list) method.
        /// </param>
        public virtual GetRequest Get(string customerId, string deviceId)
        {
            return new GetRequest(service, customerId, deviceId);
        }

        /// <summary>Retrieves a Chrome OS device's properties.</summary>
        public class GetRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.ChromeOsDevice>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string customerId, string deviceId) : base(service)
            {
                CustomerId = customerId;
                DeviceId = deviceId;
                InitParameters();
            }

            /// <summary>
            /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use
            /// the `my_customer` alias to represent your account's `customerId`. The `customerId` is also returned as
            /// part of the [Users resource](/admin-sdk/directory/v1/reference/users).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>
            /// The unique ID of the device. The `deviceId`s are returned in the response from the
            /// [chromeosdevices.list](/admin-sdk/directory/v1/reference/chromeosdevices/list) method.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("deviceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DeviceId { get; private set; }

            /// <summary>
            /// Determines whether the response contains the full list of properties or only a subset.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>
            /// Determines whether the response contains the full list of properties or only a subset.
            /// </summary>
            public enum ProjectionEnum
            {
                /// <summary>
                /// Includes only the basic metadata fields (e.g., deviceId, serialNumber, status, and user)
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("BASIC")]
                BASIC = 0,

                /// <summary>Includes all metadata fields</summary>
                [Google.Apis.Util.StringValueAttribute("FULL")]
                FULL = 1,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/devices/chromeos/{deviceId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("deviceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "deviceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("projection", new Google.Apis.Discovery.Parameter
                {
                    Name = "projection",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves a paginated list of Chrome OS devices within an account.</summary>
        /// <param name="customerId">
        /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use the
        /// `my_customer` alias to represent your account's `customerId`. The `customerId` is also returned as part of
        /// the [Users resource](/admin-sdk/directory/v1/reference/users).
        /// </param>
        public virtual ListRequest List(string customerId)
        {
            return new ListRequest(service, customerId);
        }

        /// <summary>Retrieves a paginated list of Chrome OS devices within an account.</summary>
        public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.ChromeOsDevices>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string customerId) : base(service)
            {
                CustomerId = customerId;
                InitParameters();
            }

            /// <summary>
            /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use
            /// the `my_customer` alias to represent your account's `customerId`. The `customerId` is also returned as
            /// part of the [Users resource](/admin-sdk/directory/v1/reference/users).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>Maximum number of results to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>Device property to use for sorting results.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<OrderByEnum> OrderBy { get; set; }

            /// <summary>Device property to use for sorting results.</summary>
            public enum OrderByEnum
            {
                /// <summary>Chrome device location as annotated by the administrator.</summary>
                [Google.Apis.Util.StringValueAttribute("annotatedLocation")]
                AnnotatedLocation = 0,

                /// <summary>Chromebook user as annotated by administrator.</summary>
                [Google.Apis.Util.StringValueAttribute("annotatedUser")]
                AnnotatedUser = 1,

                /// <summary>
                /// The date and time the Chrome device was last synchronized with the policy settings in the Admin
                /// console.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("lastSync")]
                LastSync = 2,

                /// <summary>Chrome device notes as annotated by the administrator.</summary>
                [Google.Apis.Util.StringValueAttribute("notes")]
                Notes = 3,

                /// <summary>The Chrome device serial number entered when the device was enabled.</summary>
                [Google.Apis.Util.StringValueAttribute("serialNumber")]
                SerialNumber = 4,

                /// <summary>
                /// Chrome device status. For more information, see the &amp;lt;a
                /// [chromeosdevices](/admin-sdk/directory/v1/reference/chromeosdevices.html).
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("status")]
                Status = 5,

                /// <summary>
                /// Chrome device support end date. This is applicable only for devices purchased directly from Google.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("supportEndDate")]
                SupportEndDate = 6,
            }

            /// <summary>The full path of the organizational unit or its unique ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orgUnitPath", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrgUnitPath { get; set; }

            /// <summary>
            /// The `pageToken` query parameter is used to request the next page of query results. The follow-on
            /// request's `pageToken` query parameter is the `nextPageToken` from your previous response.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Restrict information returned to a set of selected fields.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>Restrict information returned to a set of selected fields.</summary>
            public enum ProjectionEnum
            {
                /// <summary>
                /// Includes only the basic metadata fields (e.g., deviceId, serialNumber, status, and user)
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("BASIC")]
                BASIC = 0,

                /// <summary>Includes all metadata fields</summary>
                [Google.Apis.Util.StringValueAttribute("FULL")]
                FULL = 1,
            }

            /// <summary>
            /// Search string in the format given at http://support.google.com/chromeos/a/bin/answer.py?answer=1698333
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query { get; set; }

            /// <summary>
            /// Whether to return results in ascending or descending order. Must be used with the `orderBy` parameter.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("sortOrder", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<SortOrderEnum> SortOrder { get; set; }

            /// <summary>
            /// Whether to return results in ascending or descending order. Must be used with the `orderBy` parameter.
            /// </summary>
            public enum SortOrderEnum
            {
                /// <summary>Ascending order.</summary>
                [Google.Apis.Util.StringValueAttribute("ASCENDING")]
                ASCENDING = 0,

                /// <summary>Descending order.</summary>
                [Google.Apis.Util.StringValueAttribute("DESCENDING")]
                DESCENDING = 1,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/devices/chromeos";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "100",
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
                RequestParameters.Add("orgUnitPath", new Google.Apis.Discovery.Parameter
                {
                    Name = "orgUnitPath",
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
                RequestParameters.Add("projection", new Google.Apis.Discovery.Parameter
                {
                    Name = "projection",
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
                RequestParameters.Add("sortOrder", new Google.Apis.Discovery.Parameter
                {
                    Name = "sortOrder",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Move or insert multiple Chrome OS devices to an organizational unit. You can move up to 50 devices at once.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customerId">Immutable ID of the Google Workspace account</param>
        /// <param name="orgUnitPath">Full path of the target organizational unit or its ID</param>
        public virtual MoveDevicesToOuRequest MoveDevicesToOu(Google.Apis.Admin.Directory.directory_v1.Data.ChromeOsMoveDevicesToOu body, string customerId, string orgUnitPath)
        {
            return new MoveDevicesToOuRequest(service, body, customerId, orgUnitPath);
        }

        /// <summary>
        /// Move or insert multiple Chrome OS devices to an organizational unit. You can move up to 50 devices at once.
        /// </summary>
        public class MoveDevicesToOuRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new MoveDevicesToOu request.</summary>
            public MoveDevicesToOuRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.ChromeOsMoveDevicesToOu body, string customerId, string orgUnitPath) : base(service)
            {
                CustomerId = customerId;
                OrgUnitPath = orgUnitPath;
                Body = body;
                InitParameters();
            }

            /// <summary>Immutable ID of the Google Workspace account</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>Full path of the target organizational unit or its ID</summary>
            [Google.Apis.Util.RequestParameterAttribute("orgUnitPath", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrgUnitPath { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.ChromeOsMoveDevicesToOu Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "moveDevicesToOu";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/devices/chromeos/moveDevicesToOu";

            /// <summary>Initializes MoveDevicesToOu parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("orgUnitPath", new Google.Apis.Discovery.Parameter
                {
                    Name = "orgUnitPath",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates a device's updatable properties, such as `annotatedUser`, `annotatedLocation`, `notes`,
        /// `orgUnitPath`, or `annotatedAssetId`. This method supports [patch
        /// semantics](/admin-sdk/directory/v1/guides/performance#patch).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customerId">
        /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use the
        /// `my_customer` alias to represent your account's `customerId`. The `customerId` is also returned as part of
        /// the [Users resource](/admin-sdk/directory/v1/reference/users).
        /// </param>
        /// <param name="deviceId">
        /// The unique ID of the device. The `deviceId`s are returned in the response from the
        /// [chromeosdevices.list](/admin-sdk/v1/reference/chromeosdevices/list) method.
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.Admin.Directory.directory_v1.Data.ChromeOsDevice body, string customerId, string deviceId)
        {
            return new PatchRequest(service, body, customerId, deviceId);
        }

        /// <summary>
        /// Updates a device's updatable properties, such as `annotatedUser`, `annotatedLocation`, `notes`,
        /// `orgUnitPath`, or `annotatedAssetId`. This method supports [patch
        /// semantics](/admin-sdk/directory/v1/guides/performance#patch).
        /// </summary>
        public class PatchRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.ChromeOsDevice>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.ChromeOsDevice body, string customerId, string deviceId) : base(service)
            {
                CustomerId = customerId;
                DeviceId = deviceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use
            /// the `my_customer` alias to represent your account's `customerId`. The `customerId` is also returned as
            /// part of the [Users resource](/admin-sdk/directory/v1/reference/users).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>
            /// The unique ID of the device. The `deviceId`s are returned in the response from the
            /// [chromeosdevices.list](/admin-sdk/v1/reference/chromeosdevices/list) method.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("deviceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DeviceId { get; private set; }

            /// <summary>Restrict information returned to a set of selected fields.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>Restrict information returned to a set of selected fields.</summary>
            public enum ProjectionEnum
            {
                /// <summary>
                /// Includes only the basic metadata fields (e.g., deviceId, serialNumber, status, and user)
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("BASIC")]
                BASIC = 0,

                /// <summary>Includes all metadata fields</summary>
                [Google.Apis.Util.StringValueAttribute("FULL")]
                FULL = 1,
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.ChromeOsDevice Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/devices/chromeos/{deviceId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("deviceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "deviceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("projection", new Google.Apis.Discovery.Parameter
                {
                    Name = "projection",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates a device's updatable properties, such as `annotatedUser`, `annotatedLocation`, `notes`,
        /// `orgUnitPath`, or `annotatedAssetId`.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customerId">
        /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use the
        /// `my_customer` alias to represent your account's `customerId`. The `customerId` is also returned as part of
        /// the [Users resource](/admin-sdk/directory/v1/reference/users).
        /// </param>
        /// <param name="deviceId">
        /// The unique ID of the device. The `deviceId`s are returned in the response from the
        /// [chromeosdevices.list](/admin-sdk/v1/reference/chromeosdevices/list) method.
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.Admin.Directory.directory_v1.Data.ChromeOsDevice body, string customerId, string deviceId)
        {
            return new UpdateRequest(service, body, customerId, deviceId);
        }

        /// <summary>
        /// Updates a device's updatable properties, such as `annotatedUser`, `annotatedLocation`, `notes`,
        /// `orgUnitPath`, or `annotatedAssetId`.
        /// </summary>
        public class UpdateRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.ChromeOsDevice>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.ChromeOsDevice body, string customerId, string deviceId) : base(service)
            {
                CustomerId = customerId;
                DeviceId = deviceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use
            /// the `my_customer` alias to represent your account's `customerId`. The `customerId` is also returned as
            /// part of the [Users resource](/admin-sdk/directory/v1/reference/users).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>
            /// The unique ID of the device. The `deviceId`s are returned in the response from the
            /// [chromeosdevices.list](/admin-sdk/v1/reference/chromeosdevices/list) method.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("deviceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DeviceId { get; private set; }

            /// <summary>Restrict information returned to a set of selected fields.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>Restrict information returned to a set of selected fields.</summary>
            public enum ProjectionEnum
            {
                /// <summary>
                /// Includes only the basic metadata fields (e.g., deviceId, serialNumber, status, and user)
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("BASIC")]
                BASIC = 0,

                /// <summary>Includes all metadata fields</summary>
                [Google.Apis.Util.StringValueAttribute("FULL")]
                FULL = 1,
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.ChromeOsDevice Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/devices/chromeos/{deviceId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("deviceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "deviceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("projection", new Google.Apis.Discovery.Parameter
                {
                    Name = "projection",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "customer" collection of methods.</summary>
    public class CustomerResource
    {
        private const string Resource = "customer";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public CustomerResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Devices = new DevicesResource(service);
        }

        /// <summary>Gets the Devices resource.</summary>
        public virtual DevicesResource Devices { get; }

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
                Chromeos = new ChromeosResource(service);
            }

            /// <summary>Gets the Chromeos resource.</summary>
            public virtual ChromeosResource Chromeos { get; }

            /// <summary>The "chromeos" collection of methods.</summary>
            public class ChromeosResource
            {
                private const string Resource = "chromeos";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ChromeosResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Commands = new CommandsResource(service);
                }

                /// <summary>Gets the Commands resource.</summary>
                public virtual CommandsResource Commands { get; }

                /// <summary>The "commands" collection of methods.</summary>
                public class CommandsResource
                {
                    private const string Resource = "commands";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public CommandsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Gets command data a specific command issued to the device.</summary>
                    /// <param name="customerId">Immutable. Immutable ID of the Google Workspace account.</param>
                    /// <param name="deviceId">Immutable. Immutable ID of Chrome OS Device.</param>
                    /// <param name="commandId">Immutable. Immutable ID of Chrome OS Device Command.</param>
                    public virtual GetRequest Get(string customerId, string deviceId, long commandId)
                    {
                        return new GetRequest(service, customerId, deviceId, commandId);
                    }

                    /// <summary>Gets command data a specific command issued to the device.</summary>
                    public class GetRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.DirectoryChromeosdevicesCommand>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string customerId, string deviceId, long commandId) : base(service)
                        {
                            CustomerId = customerId;
                            DeviceId = deviceId;
                            CommandId = commandId;
                            InitParameters();
                        }

                        /// <summary>Immutable. Immutable ID of the Google Workspace account.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string CustomerId { get; private set; }

                        /// <summary>Immutable. Immutable ID of Chrome OS Device.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("deviceId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string DeviceId { get; private set; }

                        /// <summary>Immutable. Immutable ID of Chrome OS Device Command.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("commandId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual long CommandId { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "admin/directory/v1/customer/{customerId}/devices/chromeos/{deviceId}/commands/{commandId}";

                        /// <summary>Initializes Get parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "customerId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("deviceId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "deviceId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("commandId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "commandId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }
                }

                /// <summary>Issues a command for the device to execute.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="customerId">Immutable. Immutable ID of the Google Workspace account.</param>
                /// <param name="deviceId">Immutable. Immutable ID of Chrome OS Device.</param>
                public virtual IssueCommandRequest IssueCommand(Google.Apis.Admin.Directory.directory_v1.Data.DirectoryChromeosdevicesIssueCommandRequest body, string customerId, string deviceId)
                {
                    return new IssueCommandRequest(service, body, customerId, deviceId);
                }

                /// <summary>Issues a command for the device to execute.</summary>
                public class IssueCommandRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.DirectoryChromeosdevicesIssueCommandResponse>
                {
                    /// <summary>Constructs a new IssueCommand request.</summary>
                    public IssueCommandRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.DirectoryChromeosdevicesIssueCommandRequest body, string customerId, string deviceId) : base(service)
                    {
                        CustomerId = customerId;
                        DeviceId = deviceId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Immutable. Immutable ID of the Google Workspace account.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string CustomerId { get; private set; }

                    /// <summary>Immutable. Immutable ID of Chrome OS Device.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("deviceId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string DeviceId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Admin.Directory.directory_v1.Data.DirectoryChromeosdevicesIssueCommandRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "issueCommand";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "admin/directory/v1/customer/{customerId}/devices/chromeos/{deviceId}:issueCommand";

                    /// <summary>Initializes IssueCommand parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "customerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("deviceId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "deviceId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }
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
            Chrome = new ChromeResource(service);
        }

        /// <summary>Gets the Chrome resource.</summary>
        public virtual ChromeResource Chrome { get; }

        /// <summary>The "chrome" collection of methods.</summary>
        public class ChromeResource
        {
            private const string Resource = "chrome";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ChromeResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Printers = new PrintersResource(service);
            }

            /// <summary>Gets the Printers resource.</summary>
            public virtual PrintersResource Printers { get; }

            /// <summary>The "printers" collection of methods.</summary>
            public class PrintersResource
            {
                private const string Resource = "printers";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public PrintersResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates printers under given Organization Unit.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The name of the customer. Format: customers/{customer_id}</param>
                public virtual BatchCreatePrintersRequest BatchCreatePrinters(Google.Apis.Admin.Directory.directory_v1.Data.BatchCreatePrintersRequest body, string parent)
                {
                    return new BatchCreatePrintersRequest(service, body, parent);
                }

                /// <summary>Creates printers under given Organization Unit.</summary>
                public class BatchCreatePrintersRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.BatchCreatePrintersResponse>
                {
                    /// <summary>Constructs a new BatchCreatePrinters request.</summary>
                    public BatchCreatePrintersRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.BatchCreatePrintersRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the customer. Format: customers/{customer_id}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Admin.Directory.directory_v1.Data.BatchCreatePrintersRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "batchCreatePrinters";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "admin/directory/v1/{+parent}/chrome/printers:batchCreatePrinters";

                    /// <summary>Initializes BatchCreatePrinters parameter list.</summary>
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
                    }
                }

                /// <summary>Deletes printers in batch.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The name of the customer. Format: customers/{customer_id}</param>
                public virtual BatchDeletePrintersRequest BatchDeletePrinters(Google.Apis.Admin.Directory.directory_v1.Data.BatchDeletePrintersRequest body, string parent)
                {
                    return new BatchDeletePrintersRequest(service, body, parent);
                }

                /// <summary>Deletes printers in batch.</summary>
                public class BatchDeletePrintersRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.BatchDeletePrintersResponse>
                {
                    /// <summary>Constructs a new BatchDeletePrinters request.</summary>
                    public BatchDeletePrintersRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.BatchDeletePrintersRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the customer. Format: customers/{customer_id}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Admin.Directory.directory_v1.Data.BatchDeletePrintersRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "batchDeletePrinters";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "admin/directory/v1/{+parent}/chrome/printers:batchDeletePrinters";

                    /// <summary>Initializes BatchDeletePrinters parameter list.</summary>
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
                    }
                }

                /// <summary>Creates a printer under given Organization Unit.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The name of the customer. Format: customers/{customer_id}</param>
                public virtual CreateRequest Create(Google.Apis.Admin.Directory.directory_v1.Data.Printer body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a printer under given Organization Unit.</summary>
                public class CreateRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Printer>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Printer body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the customer. Format: customers/{customer_id}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Admin.Directory.directory_v1.Data.Printer Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "admin/directory/v1/{+parent}/chrome/printers";

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
                            Pattern = @"^customers/[^/]+$",
                        });
                    }
                }

                /// <summary>Deletes a `Printer`.</summary>
                /// <param name="name">
                /// Required. The name of the printer to be updated. Format:
                /// customers/{customer_id}/chrome/printers/{printer_id}
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes a `Printer`.</summary>
                public class DeleteRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the printer to be updated. Format:
                    /// customers/{customer_id}/chrome/printers/{printer_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "admin/directory/v1/{+name}";

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
                            Pattern = @"^customers/[^/]+/chrome/printers/[^/]+$",
                        });
                    }
                }

                /// <summary>Returns a `Printer` resource (printer's config).</summary>
                /// <param name="name">
                /// Required. The name of the printer to retrieve. Format:
                /// customers/{customer_id}/chrome/printers/{printer_id}
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Returns a `Printer` resource (printer's config).</summary>
                public class GetRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Printer>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the printer to retrieve. Format:
                    /// customers/{customer_id}/chrome/printers/{printer_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "admin/directory/v1/{+name}";

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
                            Pattern = @"^customers/[^/]+/chrome/printers/[^/]+$",
                        });
                    }
                }

                /// <summary>List printers configs.</summary>
                /// <param name="parent">
                /// Required. The name of the customer who owns this collection of printers. Format:
                /// customers/{customer_id}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>List printers configs.</summary>
                public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.ListPrintersResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the customer who owns this collection of printers. Format:
                    /// customers/{customer_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Search query. Search syntax is shared between this api and Admin Console printers pages.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Organization Unit that we want to list the printers for. When org_unit is not present in the
                    /// request then all printers of the customer are returned (or filtered). When org_unit is present
                    /// in the request then only printers available to this OU will be returned (owned or inherited).
                    /// You may see if printer is owned or inherited for this OU by looking at Printer.org_unit_id.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orgUnitId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrgUnitId { get; set; }

                    /// <summary>
                    /// The maximum number of objects to return. The service may return fewer than this value.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>A page token, received from a previous call.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "admin/directory/v1/{+parent}/chrome/printers";

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
                        RequestParameters.Add("orgUnitId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "orgUnitId",
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

                /// <summary>Lists the supported printer models.</summary>
                /// <param name="parent">
                /// Required. The name of the customer who owns this collection of printers. Format:
                /// customers/{customer_id}
                /// </param>
                public virtual ListPrinterModelsRequest ListPrinterModels(string parent)
                {
                    return new ListPrinterModelsRequest(service, parent);
                }

                /// <summary>Lists the supported printer models.</summary>
                public class ListPrinterModelsRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.ListPrinterModelsResponse>
                {
                    /// <summary>Constructs a new ListPrinterModels request.</summary>
                    public ListPrinterModelsRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the customer who owns this collection of printers. Format:
                    /// customers/{customer_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Filer to list only models by a given manufacturer in format: "manufacturer:Brother". Search
                    /// syntax is shared between this api and Admin Console printers pages.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// The maximum number of objects to return. The service may return fewer than this value.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>A page token, received from a previous call.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "listPrinterModels";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "admin/directory/v1/{+parent}/chrome/printers:listPrinterModels";

                    /// <summary>Initializes ListPrinterModels parameter list.</summary>
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

                /// <summary>Updates a `Printer` resource.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The resource name of the Printer object, in the format customers/{customer-id}/printers/{printer-id}
                /// (During printer creation leave empty)
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Admin.Directory.directory_v1.Data.Printer body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Updates a `Printer` resource.</summary>
                public class PatchRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Printer>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Printer body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The resource name of the Printer object, in the format
                    /// customers/{customer-id}/printers/{printer-id} (During printer creation leave empty)
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The list of fields to be cleared. Note, some of the fields are read only and cannot be updated.
                    /// Values for not specified fields will be patched.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clearMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object ClearMask { get; set; }

                    /// <summary>
                    /// The list of fields to be updated. Note, some of the fields are read only and cannot be updated.
                    /// Values for not specified fields will be patched.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Admin.Directory.directory_v1.Data.Printer Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "admin/directory/v1/{+name}";

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
                            Pattern = @"^customers/[^/]+/chrome/printers/[^/]+$",
                        });
                        RequestParameters.Add("clearMask", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clearMask",
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
        }

        /// <summary>Retrieves a customer.</summary>
        /// <param name="customerKey">Id of the customer to be retrieved</param>
        public virtual GetRequest Get(string customerKey)
        {
            return new GetRequest(service, customerKey);
        }

        /// <summary>Retrieves a customer.</summary>
        public class GetRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Customer>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string customerKey) : base(service)
            {
                CustomerKey = customerKey;
                InitParameters();
            }

            /// <summary>Id of the customer to be retrieved</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerKey { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customers/{customerKey}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Patch Customers via Apiary Patch Orchestration</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customerKey">Id of the customer to be updated</param>
        public virtual PatchRequest Patch(Google.Apis.Admin.Directory.directory_v1.Data.Customer body, string customerKey)
        {
            return new PatchRequest(service, body, customerKey);
        }

        /// <summary>Patch Customers via Apiary Patch Orchestration</summary>
        public class PatchRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Customer>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Customer body, string customerKey) : base(service)
            {
                CustomerKey = customerKey;
                Body = body;
                InitParameters();
            }

            /// <summary>Id of the customer to be updated</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerKey { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.Customer Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customers/{customerKey}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates a customer.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customerKey">Id of the customer to be updated</param>
        public virtual UpdateRequest Update(Google.Apis.Admin.Directory.directory_v1.Data.Customer body, string customerKey)
        {
            return new UpdateRequest(service, body, customerKey);
        }

        /// <summary>Updates a customer.</summary>
        public class UpdateRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Customer>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Customer body, string customerKey) : base(service)
            {
                CustomerKey = customerKey;
                Body = body;
                InitParameters();
            }

            /// <summary>Id of the customer to be updated</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerKey { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.Customer Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customers/{customerKey}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "domainAliases" collection of methods.</summary>
    public class DomainAliasesResource
    {
        private const string Resource = "domainAliases";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public DomainAliasesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Deletes a domain Alias of the customer.</summary>
        /// <param name="customer">Immutable ID of the Google Workspace account.</param>
        /// <param name="domainAliasName">Name of domain alias to be retrieved.</param>
        public virtual DeleteRequest Delete(string customer, string domainAliasName)
        {
            return new DeleteRequest(service, customer, domainAliasName);
        }

        /// <summary>Deletes a domain Alias of the customer.</summary>
        public class DeleteRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string customer, string domainAliasName) : base(service)
            {
                Customer = customer;
                DomainAliasName = domainAliasName;
                InitParameters();
            }

            /// <summary>Immutable ID of the Google Workspace account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }

            /// <summary>Name of domain alias to be retrieved.</summary>
            [Google.Apis.Util.RequestParameterAttribute("domainAliasName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DomainAliasName { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customer}/domainaliases/{domainAliasName}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                {
                    Name = "customer",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("domainAliasName", new Google.Apis.Discovery.Parameter
                {
                    Name = "domainAliasName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves a domain alias of the customer.</summary>
        /// <param name="customer">Immutable ID of the Google Workspace account.</param>
        /// <param name="domainAliasName">Name of domain alias to be retrieved.</param>
        public virtual GetRequest Get(string customer, string domainAliasName)
        {
            return new GetRequest(service, customer, domainAliasName);
        }

        /// <summary>Retrieves a domain alias of the customer.</summary>
        public class GetRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.DomainAlias>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string customer, string domainAliasName) : base(service)
            {
                Customer = customer;
                DomainAliasName = domainAliasName;
                InitParameters();
            }

            /// <summary>Immutable ID of the Google Workspace account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }

            /// <summary>Name of domain alias to be retrieved.</summary>
            [Google.Apis.Util.RequestParameterAttribute("domainAliasName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DomainAliasName { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customer}/domainaliases/{domainAliasName}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                {
                    Name = "customer",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("domainAliasName", new Google.Apis.Discovery.Parameter
                {
                    Name = "domainAliasName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts a domain alias of the customer.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customer">Immutable ID of the Google Workspace account.</param>
        public virtual InsertRequest Insert(Google.Apis.Admin.Directory.directory_v1.Data.DomainAlias body, string customer)
        {
            return new InsertRequest(service, body, customer);
        }

        /// <summary>Inserts a domain alias of the customer.</summary>
        public class InsertRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.DomainAlias>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.DomainAlias body, string customer) : base(service)
            {
                Customer = customer;
                Body = body;
                InitParameters();
            }

            /// <summary>Immutable ID of the Google Workspace account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.DomainAlias Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customer}/domainaliases";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                {
                    Name = "customer",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists the domain aliases of the customer.</summary>
        /// <param name="customer">Immutable ID of the Google Workspace account.</param>
        public virtual ListRequest List(string customer)
        {
            return new ListRequest(service, customer);
        }

        /// <summary>Lists the domain aliases of the customer.</summary>
        public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.DomainAliases>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string customer) : base(service)
            {
                Customer = customer;
                InitParameters();
            }

            /// <summary>Immutable ID of the Google Workspace account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }

            /// <summary>Name of the parent domain for which domain aliases are to be fetched.</summary>
            [Google.Apis.Util.RequestParameterAttribute("parentDomainName", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ParentDomainName { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customer}/domainaliases";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                {
                    Name = "customer",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("parentDomainName", new Google.Apis.Discovery.Parameter
                {
                    Name = "parentDomainName",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "domains" collection of methods.</summary>
    public class DomainsResource
    {
        private const string Resource = "domains";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public DomainsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Deletes a domain of the customer.</summary>
        /// <param name="customer">Immutable ID of the Google Workspace account.</param>
        /// <param name="domainName">Name of domain to be deleted</param>
        public virtual DeleteRequest Delete(string customer, string domainName)
        {
            return new DeleteRequest(service, customer, domainName);
        }

        /// <summary>Deletes a domain of the customer.</summary>
        public class DeleteRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string customer, string domainName) : base(service)
            {
                Customer = customer;
                DomainName = domainName;
                InitParameters();
            }

            /// <summary>Immutable ID of the Google Workspace account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }

            /// <summary>Name of domain to be deleted</summary>
            [Google.Apis.Util.RequestParameterAttribute("domainName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DomainName { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customer}/domains/{domainName}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                {
                    Name = "customer",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("domainName", new Google.Apis.Discovery.Parameter
                {
                    Name = "domainName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves a domain of the customer.</summary>
        /// <param name="customer">Immutable ID of the Google Workspace account.</param>
        /// <param name="domainName">Name of domain to be retrieved</param>
        public virtual GetRequest Get(string customer, string domainName)
        {
            return new GetRequest(service, customer, domainName);
        }

        /// <summary>Retrieves a domain of the customer.</summary>
        public class GetRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Domains>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string customer, string domainName) : base(service)
            {
                Customer = customer;
                DomainName = domainName;
                InitParameters();
            }

            /// <summary>Immutable ID of the Google Workspace account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }

            /// <summary>Name of domain to be retrieved</summary>
            [Google.Apis.Util.RequestParameterAttribute("domainName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DomainName { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customer}/domains/{domainName}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                {
                    Name = "customer",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("domainName", new Google.Apis.Discovery.Parameter
                {
                    Name = "domainName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts a domain of the customer.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customer">Immutable ID of the Google Workspace account.</param>
        public virtual InsertRequest Insert(Google.Apis.Admin.Directory.directory_v1.Data.Domains body, string customer)
        {
            return new InsertRequest(service, body, customer);
        }

        /// <summary>Inserts a domain of the customer.</summary>
        public class InsertRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Domains>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Domains body, string customer) : base(service)
            {
                Customer = customer;
                Body = body;
                InitParameters();
            }

            /// <summary>Immutable ID of the Google Workspace account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.Domains Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customer}/domains";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                {
                    Name = "customer",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists the domains of the customer.</summary>
        /// <param name="customer">Immutable ID of the Google Workspace account.</param>
        public virtual ListRequest List(string customer)
        {
            return new ListRequest(service, customer);
        }

        /// <summary>Lists the domains of the customer.</summary>
        public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Domains2>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string customer) : base(service)
            {
                Customer = customer;
                InitParameters();
            }

            /// <summary>Immutable ID of the Google Workspace account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customer}/domains";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                {
                    Name = "customer",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
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
            Aliases = new AliasesResource(service);
        }

        /// <summary>Gets the Aliases resource.</summary>
        public virtual AliasesResource Aliases { get; }

        /// <summary>The "aliases" collection of methods.</summary>
        public class AliasesResource
        {
            private const string Resource = "aliases";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AliasesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Removes an alias.</summary>
            /// <param name="groupKey">
            /// Identifies the group in the API request. The value can be the group's email address, group alias, or the
            /// unique group ID.
            /// </param>
            /// <param name="alias">The alias to be removed</param>
            public virtual DeleteRequest Delete(string groupKey, string alias)
            {
                return new DeleteRequest(service, groupKey, alias);
            }

            /// <summary>Removes an alias.</summary>
            public class DeleteRequest : DirectoryBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string groupKey, string alias) : base(service)
                {
                    GroupKey = groupKey;
                    Alias = alias;
                    InitParameters();
                }

                /// <summary>
                /// Identifies the group in the API request. The value can be the group's email address, group alias, or
                /// the unique group ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("groupKey", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string GroupKey { get; private set; }

                /// <summary>The alias to be removed</summary>
                [Google.Apis.Util.RequestParameterAttribute("alias", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Alias { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/groups/{groupKey}/aliases/{alias}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("groupKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "groupKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("alias", new Google.Apis.Discovery.Parameter
                    {
                        Name = "alias",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Adds an alias for the group.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="groupKey">
            /// Identifies the group in the API request. The value can be the group's email address, group alias, or the
            /// unique group ID.
            /// </param>
            public virtual InsertRequest Insert(Google.Apis.Admin.Directory.directory_v1.Data.Alias body, string groupKey)
            {
                return new InsertRequest(service, body, groupKey);
            }

            /// <summary>Adds an alias for the group.</summary>
            public class InsertRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Alias>
            {
                /// <summary>Constructs a new Insert request.</summary>
                public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Alias body, string groupKey) : base(service)
                {
                    GroupKey = groupKey;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifies the group in the API request. The value can be the group's email address, group alias, or
                /// the unique group ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("groupKey", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string GroupKey { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Admin.Directory.directory_v1.Data.Alias Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "insert";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/groups/{groupKey}/aliases";

                /// <summary>Initializes Insert parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("groupKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "groupKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists all aliases for a group.</summary>
            /// <param name="groupKey">
            /// Identifies the group in the API request. The value can be the group's email address, group alias, or the
            /// unique group ID.
            /// </param>
            public virtual ListRequest List(string groupKey)
            {
                return new ListRequest(service, groupKey);
            }

            /// <summary>Lists all aliases for a group.</summary>
            public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Aliases>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string groupKey) : base(service)
                {
                    GroupKey = groupKey;
                    InitParameters();
                }

                /// <summary>
                /// Identifies the group in the API request. The value can be the group's email address, group alias, or
                /// the unique group ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("groupKey", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string GroupKey { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/groups/{groupKey}/aliases";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("groupKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "groupKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Deletes a group.</summary>
        /// <param name="groupKey">
        /// Identifies the group in the API request. The value can be the group's email address, group alias, or the
        /// unique group ID.
        /// </param>
        public virtual DeleteRequest Delete(string groupKey)
        {
            return new DeleteRequest(service, groupKey);
        }

        /// <summary>Deletes a group.</summary>
        public class DeleteRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string groupKey) : base(service)
            {
                GroupKey = groupKey;
                InitParameters();
            }

            /// <summary>
            /// Identifies the group in the API request. The value can be the group's email address, group alias, or the
            /// unique group ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("groupKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string GroupKey { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/groups/{groupKey}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("groupKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "groupKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves a group's properties.</summary>
        /// <param name="groupKey">
        /// Identifies the group in the API request. The value can be the group's email address, group alias, or the
        /// unique group ID.
        /// </param>
        public virtual GetRequest Get(string groupKey)
        {
            return new GetRequest(service, groupKey);
        }

        /// <summary>Retrieves a group's properties.</summary>
        public class GetRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Group>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string groupKey) : base(service)
            {
                GroupKey = groupKey;
                InitParameters();
            }

            /// <summary>
            /// Identifies the group in the API request. The value can be the group's email address, group alias, or the
            /// unique group ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("groupKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string GroupKey { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/groups/{groupKey}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("groupKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "groupKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Creates a group.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual InsertRequest Insert(Google.Apis.Admin.Directory.directory_v1.Data.Group body)
        {
            return new InsertRequest(service, body);
        }

        /// <summary>Creates a group.</summary>
        public class InsertRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Group>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Group body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.Group Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/groups";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Retrieve all groups of a domain or of a user given a userKey (paginated)</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Retrieve all groups of a domain or of a user given a userKey (paginated)</summary>
        public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Groups>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// The unique ID for the customer's Google Workspace account. In case of a multi-domain account, to fetch
            /// all groups for a customer, fill this field instead of domain. As an account administrator, you can also
            /// use the `my_customer` alias to represent your account's `customerId`. The `customerId` is also returned
            /// as part of the [Users](/admin-sdk/directory/v1/reference/users)
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Customer { get; set; }

            /// <summary>
            /// The domain name. Use this field to get fields from only one domain. To return all domains for a customer
            /// account, use the `customer` query parameter instead.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("domain", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Domain { get; set; }

            /// <summary>Maximum number of results to return. Max allowed value is 200.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>Column to use for sorting results</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<OrderByEnum> OrderBy { get; set; }

            /// <summary>Column to use for sorting results</summary>
            public enum OrderByEnum
            {
                /// <summary>Email of the group.</summary>
                [Google.Apis.Util.StringValueAttribute("email")]
                Email = 0,
            }

            /// <summary>Token to specify next page in the list</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Query string search. Should be of the form "". Complete documentation is at https:
            /// //developers.google.com/admin-sdk/directory/v1/guides/search-groups
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query { get; set; }

            /// <summary>
            /// Whether to return results in ascending or descending order. Only of use when orderBy is also used
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("sortOrder", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<SortOrderEnum> SortOrder { get; set; }

            /// <summary>
            /// Whether to return results in ascending or descending order. Only of use when orderBy is also used
            /// </summary>
            public enum SortOrderEnum
            {
                /// <summary>Ascending order.</summary>
                [Google.Apis.Util.StringValueAttribute("ASCENDING")]
                ASCENDING = 0,

                /// <summary>Descending order.</summary>
                [Google.Apis.Util.StringValueAttribute("DESCENDING")]
                DESCENDING = 1,
            }

            /// <summary>
            /// Email or immutable ID of the user if only those groups are to be listed, the given user is a member of.
            /// If it's an ID, it should match with the ID of the user object.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserKey { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/groups";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                {
                    Name = "customer",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("domain", new Google.Apis.Discovery.Parameter
                {
                    Name = "domain",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "200",
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
                RequestParameters.Add("sortOrder", new Google.Apis.Discovery.Parameter
                {
                    Name = "sortOrder",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "userKey",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates a group's properties. This method supports [patch
        /// semantics](/admin-sdk/directory/v1/guides/performance#patch).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="groupKey">
        /// Identifies the group in the API request. The value can be the group's email address, group alias, or the
        /// unique group ID.
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.Admin.Directory.directory_v1.Data.Group body, string groupKey)
        {
            return new PatchRequest(service, body, groupKey);
        }

        /// <summary>
        /// Updates a group's properties. This method supports [patch
        /// semantics](/admin-sdk/directory/v1/guides/performance#patch).
        /// </summary>
        public class PatchRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Group>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Group body, string groupKey) : base(service)
            {
                GroupKey = groupKey;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Identifies the group in the API request. The value can be the group's email address, group alias, or the
            /// unique group ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("groupKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string GroupKey { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.Group Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/groups/{groupKey}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("groupKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "groupKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates a group's properties.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="groupKey">
        /// Identifies the group in the API request. The value can be the group's email address, group alias, or the
        /// unique group ID.
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.Admin.Directory.directory_v1.Data.Group body, string groupKey)
        {
            return new UpdateRequest(service, body, groupKey);
        }

        /// <summary>Updates a group's properties.</summary>
        public class UpdateRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Group>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Group body, string groupKey) : base(service)
            {
                GroupKey = groupKey;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Identifies the group in the API request. The value can be the group's email address, group alias, or the
            /// unique group ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("groupKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string GroupKey { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.Group Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/groups/{groupKey}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("groupKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "groupKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "members" collection of methods.</summary>
    public class MembersResource
    {
        private const string Resource = "members";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public MembersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Removes a member from a group.</summary>
        /// <param name="groupKey">
        /// Identifies the group in the API request. The value can be the group's email address, group alias, or the
        /// unique group ID.
        /// </param>
        /// <param name="memberKey">
        /// Identifies the group member in the API request. A group member can be a user or another group. The value can
        /// be the member's (group or user) primary email address, alias, or unique ID.
        /// </param>
        public virtual DeleteRequest Delete(string groupKey, string memberKey)
        {
            return new DeleteRequest(service, groupKey, memberKey);
        }

        /// <summary>Removes a member from a group.</summary>
        public class DeleteRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string groupKey, string memberKey) : base(service)
            {
                GroupKey = groupKey;
                MemberKey = memberKey;
                InitParameters();
            }

            /// <summary>
            /// Identifies the group in the API request. The value can be the group's email address, group alias, or the
            /// unique group ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("groupKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string GroupKey { get; private set; }

            /// <summary>
            /// Identifies the group member in the API request. A group member can be a user or another group. The value
            /// can be the member's (group or user) primary email address, alias, or unique ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("memberKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string MemberKey { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/groups/{groupKey}/members/{memberKey}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("groupKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "groupKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("memberKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "memberKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves a group member's properties.</summary>
        /// <param name="groupKey">
        /// Identifies the group in the API request. The value can be the group's email address, group alias, or the
        /// unique group ID.
        /// </param>
        /// <param name="memberKey">
        /// Identifies the group member in the API request. A group member can be a user or another group. The value can
        /// be the member's (group or user) primary email address, alias, or unique ID.
        /// </param>
        public virtual GetRequest Get(string groupKey, string memberKey)
        {
            return new GetRequest(service, groupKey, memberKey);
        }

        /// <summary>Retrieves a group member's properties.</summary>
        public class GetRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Member>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string groupKey, string memberKey) : base(service)
            {
                GroupKey = groupKey;
                MemberKey = memberKey;
                InitParameters();
            }

            /// <summary>
            /// Identifies the group in the API request. The value can be the group's email address, group alias, or the
            /// unique group ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("groupKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string GroupKey { get; private set; }

            /// <summary>
            /// Identifies the group member in the API request. A group member can be a user or another group. The value
            /// can be the member's (group or user) primary email address, alias, or unique ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("memberKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string MemberKey { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/groups/{groupKey}/members/{memberKey}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("groupKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "groupKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("memberKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "memberKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Checks whether the given user is a member of the group. Membership can be direct or nested.
        /// </summary>
        /// <param name="groupKey">
        /// Identifies the group in the API request. The value can be the group's email address, group alias, or the
        /// unique group ID.
        /// </param>
        /// <param name="memberKey">
        /// Identifies the user member in the API request. The value can be the user's primary email address, alias, or
        /// unique ID.
        /// </param>
        public virtual HasMemberRequest HasMember(string groupKey, string memberKey)
        {
            return new HasMemberRequest(service, groupKey, memberKey);
        }

        /// <summary>
        /// Checks whether the given user is a member of the group. Membership can be direct or nested.
        /// </summary>
        public class HasMemberRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.MembersHasMember>
        {
            /// <summary>Constructs a new HasMember request.</summary>
            public HasMemberRequest(Google.Apis.Services.IClientService service, string groupKey, string memberKey) : base(service)
            {
                GroupKey = groupKey;
                MemberKey = memberKey;
                InitParameters();
            }

            /// <summary>
            /// Identifies the group in the API request. The value can be the group's email address, group alias, or the
            /// unique group ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("groupKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string GroupKey { get; private set; }

            /// <summary>
            /// Identifies the user member in the API request. The value can be the user's primary email address, alias,
            /// or unique ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("memberKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string MemberKey { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "hasMember";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/groups/{groupKey}/hasMember/{memberKey}";

            /// <summary>Initializes HasMember parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("groupKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "groupKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("memberKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "memberKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Adds a user to the specified group.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="groupKey">
        /// Identifies the group in the API request. The value can be the group's email address, group alias, or the
        /// unique group ID.
        /// </param>
        public virtual InsertRequest Insert(Google.Apis.Admin.Directory.directory_v1.Data.Member body, string groupKey)
        {
            return new InsertRequest(service, body, groupKey);
        }

        /// <summary>Adds a user to the specified group.</summary>
        public class InsertRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Member>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Member body, string groupKey) : base(service)
            {
                GroupKey = groupKey;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Identifies the group in the API request. The value can be the group's email address, group alias, or the
            /// unique group ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("groupKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string GroupKey { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.Member Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/groups/{groupKey}/members";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("groupKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "groupKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves a paginated list of all members in a group.</summary>
        /// <param name="groupKey">
        /// Identifies the group in the API request. The value can be the group's email address, group alias, or the
        /// unique group ID.
        /// </param>
        public virtual ListRequest List(string groupKey)
        {
            return new ListRequest(service, groupKey);
        }

        /// <summary>Retrieves a paginated list of all members in a group.</summary>
        public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Members>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string groupKey) : base(service)
            {
                GroupKey = groupKey;
                InitParameters();
            }

            /// <summary>
            /// Identifies the group in the API request. The value can be the group's email address, group alias, or the
            /// unique group ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("groupKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string GroupKey { get; private set; }

            /// <summary>Whether to list indirect memberships. Default: false.</summary>
            [Google.Apis.Util.RequestParameterAttribute("includeDerivedMembership", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> IncludeDerivedMembership { get; set; }

            /// <summary>Maximum number of results to return. Max allowed value is 200.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>Token to specify next page in the list.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// The `roles` query parameter allows you to retrieve group members by role. Allowed values are `OWNER`,
            /// `MANAGER`, and `MEMBER`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("roles", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Roles { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/groups/{groupKey}/members";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("groupKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "groupKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("includeDerivedMembership", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeDerivedMembership",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "200",
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
                RequestParameters.Add("roles", new Google.Apis.Discovery.Parameter
                {
                    Name = "roles",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates the membership properties of a user in the specified group. This method supports [patch
        /// semantics](/admin-sdk/directory/v1/guides/performance#patch).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="groupKey">
        /// Identifies the group in the API request. The value can be the group's email address, group alias, or the
        /// unique group ID.
        /// </param>
        /// <param name="memberKey">
        /// Identifies the group member in the API request. A group member can be a user or another group. The value can
        /// be the member's (group or user) primary email address, alias, or unique ID.
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.Admin.Directory.directory_v1.Data.Member body, string groupKey, string memberKey)
        {
            return new PatchRequest(service, body, groupKey, memberKey);
        }

        /// <summary>
        /// Updates the membership properties of a user in the specified group. This method supports [patch
        /// semantics](/admin-sdk/directory/v1/guides/performance#patch).
        /// </summary>
        public class PatchRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Member>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Member body, string groupKey, string memberKey) : base(service)
            {
                GroupKey = groupKey;
                MemberKey = memberKey;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Identifies the group in the API request. The value can be the group's email address, group alias, or the
            /// unique group ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("groupKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string GroupKey { get; private set; }

            /// <summary>
            /// Identifies the group member in the API request. A group member can be a user or another group. The value
            /// can be the member's (group or user) primary email address, alias, or unique ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("memberKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string MemberKey { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.Member Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/groups/{groupKey}/members/{memberKey}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("groupKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "groupKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("memberKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "memberKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates the membership of a user in the specified group.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="groupKey">
        /// Identifies the group in the API request. The value can be the group's email address, group alias, or the
        /// unique group ID.
        /// </param>
        /// <param name="memberKey">
        /// Identifies the group member in the API request. A group member can be a user or another group. The value can
        /// be the member's (group or user) primary email address, alias, or unique ID.
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.Admin.Directory.directory_v1.Data.Member body, string groupKey, string memberKey)
        {
            return new UpdateRequest(service, body, groupKey, memberKey);
        }

        /// <summary>Updates the membership of a user in the specified group.</summary>
        public class UpdateRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Member>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Member body, string groupKey, string memberKey) : base(service)
            {
                GroupKey = groupKey;
                MemberKey = memberKey;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Identifies the group in the API request. The value can be the group's email address, group alias, or the
            /// unique group ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("groupKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string GroupKey { get; private set; }

            /// <summary>
            /// Identifies the group member in the API request. A group member can be a user or another group. The value
            /// can be the member's (group or user) primary email address, alias, or unique ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("memberKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string MemberKey { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.Member Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/groups/{groupKey}/members/{memberKey}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("groupKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "groupKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("memberKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "memberKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "mobiledevices" collection of methods.</summary>
    public class MobiledevicesResource
    {
        private const string Resource = "mobiledevices";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public MobiledevicesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Takes an action that affects a mobile device. For example, remotely wiping a device.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customerId">
        /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use the
        /// `my_customer` alias to represent your account's `customerId`. The `customerId` is also returned as part of
        /// the [Users resource](/admin-sdk/directory/v1/reference/users).
        /// </param>
        /// <param name="resourceId">The unique ID the API service uses to identify the mobile device.</param>
        public virtual ActionRequest Action(Google.Apis.Admin.Directory.directory_v1.Data.MobileDeviceAction body, string customerId, string resourceId)
        {
            return new ActionRequest(service, body, customerId, resourceId);
        }

        /// <summary>Takes an action that affects a mobile device. For example, remotely wiping a device.</summary>
        public class ActionRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Action request.</summary>
            public ActionRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.MobileDeviceAction body, string customerId, string resourceId) : base(service)
            {
                CustomerId = customerId;
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use
            /// the `my_customer` alias to represent your account's `customerId`. The `customerId` is also returned as
            /// part of the [Users resource](/admin-sdk/directory/v1/reference/users).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>The unique ID the API service uses to identify the mobile device.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.MobileDeviceAction Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "action";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/devices/mobile/{resourceId}/action";

            /// <summary>Initializes Action parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Removes a mobile device.</summary>
        /// <param name="customerId">
        /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use the
        /// `my_customer` alias to represent your account's `customerId`. The `customerId` is also returned as part of
        /// the [Users resource](/admin-sdk/directory/v1/reference/users).
        /// </param>
        /// <param name="resourceId">The unique ID the API service uses to identify the mobile device.</param>
        public virtual DeleteRequest Delete(string customerId, string resourceId)
        {
            return new DeleteRequest(service, customerId, resourceId);
        }

        /// <summary>Removes a mobile device.</summary>
        public class DeleteRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string customerId, string resourceId) : base(service)
            {
                CustomerId = customerId;
                ResourceId = resourceId;
                InitParameters();
            }

            /// <summary>
            /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use
            /// the `my_customer` alias to represent your account's `customerId`. The `customerId` is also returned as
            /// part of the [Users resource](/admin-sdk/directory/v1/reference/users).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>The unique ID the API service uses to identify the mobile device.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/devices/mobile/{resourceId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves a mobile device's properties.</summary>
        /// <param name="customerId">
        /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use the
        /// `my_customer` alias to represent your account's `customerId`. The `customerId` is also returned as part of
        /// the [Users resource](/admin-sdk/directory/v1/reference/users).
        /// </param>
        /// <param name="resourceId">The unique ID the API service uses to identify the mobile device.</param>
        public virtual GetRequest Get(string customerId, string resourceId)
        {
            return new GetRequest(service, customerId, resourceId);
        }

        /// <summary>Retrieves a mobile device's properties.</summary>
        public class GetRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.MobileDevice>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string customerId, string resourceId) : base(service)
            {
                CustomerId = customerId;
                ResourceId = resourceId;
                InitParameters();
            }

            /// <summary>
            /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use
            /// the `my_customer` alias to represent your account's `customerId`. The `customerId` is also returned as
            /// part of the [Users resource](/admin-sdk/directory/v1/reference/users).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>The unique ID the API service uses to identify the mobile device.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Restrict information returned to a set of selected fields.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>Restrict information returned to a set of selected fields.</summary>
            public enum ProjectionEnum
            {
                /// <summary>
                /// Includes only the basic metadata fields (e.g., deviceId, model, status, type, and status)
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("BASIC")]
                BASIC = 0,

                /// <summary>Includes all metadata fields</summary>
                [Google.Apis.Util.StringValueAttribute("FULL")]
                FULL = 1,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/devices/mobile/{resourceId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("resourceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("projection", new Google.Apis.Discovery.Parameter
                {
                    Name = "projection",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves a paginated list of all mobile devices for an account.</summary>
        /// <param name="customerId">
        /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use the
        /// `my_customer` alias to represent your account's `customerId`. The `customerId` is also returned as part of
        /// the [Users resource](/admin-sdk/directory/v1/reference/users).
        /// </param>
        public virtual ListRequest List(string customerId)
        {
            return new ListRequest(service, customerId);
        }

        /// <summary>Retrieves a paginated list of all mobile devices for an account.</summary>
        public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.MobileDevices>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string customerId) : base(service)
            {
                CustomerId = customerId;
                InitParameters();
            }

            /// <summary>
            /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use
            /// the `my_customer` alias to represent your account's `customerId`. The `customerId` is also returned as
            /// part of the [Users resource](/admin-sdk/directory/v1/reference/users).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>Maximum number of results to return. Max allowed value is 100.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>Device property to use for sorting results.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<OrderByEnum> OrderBy { get; set; }

            /// <summary>Device property to use for sorting results.</summary>
            public enum OrderByEnum
            {
                /// <summary>
                /// The serial number for a Google Sync mobile device. For Android devices, this is a software generated
                /// unique identifier.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("deviceId")]
                DeviceId = 0,

                /// <summary>The device owner's email address.</summary>
                [Google.Apis.Util.StringValueAttribute("email")]
                Email = 1,

                /// <summary>Last policy settings sync date time of the device.</summary>
                [Google.Apis.Util.StringValueAttribute("lastSync")]
                LastSync = 2,

                /// <summary>The mobile device's model.</summary>
                [Google.Apis.Util.StringValueAttribute("model")]
                Model = 3,

                /// <summary>The device owner's user name.</summary>
                [Google.Apis.Util.StringValueAttribute("name")]
                Name = 4,

                /// <summary>The device's operating system.</summary>
                [Google.Apis.Util.StringValueAttribute("os")]
                Os = 5,

                /// <summary>The device status.</summary>
                [Google.Apis.Util.StringValueAttribute("status")]
                Status = 6,

                /// <summary>Type of the device.</summary>
                [Google.Apis.Util.StringValueAttribute("type")]
                Type = 7,
            }

            /// <summary>Token to specify next page in the list</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Restrict information returned to a set of selected fields.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>Restrict information returned to a set of selected fields.</summary>
            public enum ProjectionEnum
            {
                /// <summary>
                /// Includes only the basic metadata fields (e.g., deviceId, model, status, type, and status)
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("BASIC")]
                BASIC = 0,

                /// <summary>Includes all metadata fields</summary>
                [Google.Apis.Util.StringValueAttribute("FULL")]
                FULL = 1,
            }

            /// <summary>
            /// Search string in the format given at
            /// https://developers.google.com/admin-sdk/directory/v1/search-operators
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query { get; set; }

            /// <summary>
            /// Whether to return results in ascending or descending order. Must be used with the `orderBy` parameter.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("sortOrder", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<SortOrderEnum> SortOrder { get; set; }

            /// <summary>
            /// Whether to return results in ascending or descending order. Must be used with the `orderBy` parameter.
            /// </summary>
            public enum SortOrderEnum
            {
                /// <summary>Ascending order.</summary>
                [Google.Apis.Util.StringValueAttribute("ASCENDING")]
                ASCENDING = 0,

                /// <summary>Descending order.</summary>
                [Google.Apis.Util.StringValueAttribute("DESCENDING")]
                DESCENDING = 1,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/devices/mobile";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "100",
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
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("projection", new Google.Apis.Discovery.Parameter
                {
                    Name = "projection",
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
                RequestParameters.Add("sortOrder", new Google.Apis.Discovery.Parameter
                {
                    Name = "sortOrder",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "orgunits" collection of methods.</summary>
    public class OrgunitsResource
    {
        private const string Resource = "orgunits";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public OrgunitsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Removes an organizational unit.</summary>
        /// <param name="customerId">
        /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use the
        /// `my_customer` alias to represent your account's `customerId`. The `customerId` is also returned as part of
        /// the [Users resource](/admin-sdk/directory/v1/reference/users).
        /// </param>
        /// <param name="orgUnitPath">The full path of the organizational unit or its unique ID.</param>
        public virtual DeleteRequest Delete(string customerId, string orgUnitPath)
        {
            return new DeleteRequest(service, customerId, orgUnitPath);
        }

        /// <summary>Removes an organizational unit.</summary>
        public class DeleteRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string customerId, string orgUnitPath) : base(service)
            {
                CustomerId = customerId;
                OrgUnitPath = orgUnitPath;
                InitParameters();
            }

            /// <summary>
            /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use
            /// the `my_customer` alias to represent your account's `customerId`. The `customerId` is also returned as
            /// part of the [Users resource](/admin-sdk/directory/v1/reference/users).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>The full path of the organizational unit or its unique ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orgUnitPath", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string OrgUnitPath { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/orgunits/{+orgUnitPath}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("orgUnitPath", new Google.Apis.Discovery.Parameter
                {
                    Name = "orgUnitPath",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^.*$",
                });
            }
        }

        /// <summary>Retrieves an organizational unit.</summary>
        /// <param name="customerId">
        /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use the
        /// `my_customer` alias to represent your account's `customerId`. The `customerId` is also returned as part of
        /// the [Users resource](/admin-sdk/directory/v1/reference/users).
        /// </param>
        /// <param name="orgUnitPath">The full path of the organizational unit or its unique ID.</param>
        public virtual GetRequest Get(string customerId, string orgUnitPath)
        {
            return new GetRequest(service, customerId, orgUnitPath);
        }

        /// <summary>Retrieves an organizational unit.</summary>
        public class GetRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.OrgUnit>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string customerId, string orgUnitPath) : base(service)
            {
                CustomerId = customerId;
                OrgUnitPath = orgUnitPath;
                InitParameters();
            }

            /// <summary>
            /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use
            /// the `my_customer` alias to represent your account's `customerId`. The `customerId` is also returned as
            /// part of the [Users resource](/admin-sdk/directory/v1/reference/users).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>The full path of the organizational unit or its unique ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orgUnitPath", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string OrgUnitPath { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/orgunits/{+orgUnitPath}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("orgUnitPath", new Google.Apis.Discovery.Parameter
                {
                    Name = "orgUnitPath",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^.*$",
                });
            }
        }

        /// <summary>Adds an organizational unit.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customerId">
        /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use the
        /// `my_customer` alias to represent your account's `customerId`. The `customerId` is also returned as part of
        /// the [Users resource](/admin-sdk/directory/v1/reference/users).
        /// </param>
        public virtual InsertRequest Insert(Google.Apis.Admin.Directory.directory_v1.Data.OrgUnit body, string customerId)
        {
            return new InsertRequest(service, body, customerId);
        }

        /// <summary>Adds an organizational unit.</summary>
        public class InsertRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.OrgUnit>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.OrgUnit body, string customerId) : base(service)
            {
                CustomerId = customerId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use
            /// the `my_customer` alias to represent your account's `customerId`. The `customerId` is also returned as
            /// part of the [Users resource](/admin-sdk/directory/v1/reference/users).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.OrgUnit Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/orgunits";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves a list of all organizational units for an account.</summary>
        /// <param name="customerId">
        /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use the
        /// `my_customer` alias to represent your account's `customerId`. The `customerId` is also returned as part of
        /// the [Users resource](/admin-sdk/directory/v1/reference/users).
        /// </param>
        public virtual ListRequest List(string customerId)
        {
            return new ListRequest(service, customerId);
        }

        /// <summary>Retrieves a list of all organizational units for an account.</summary>
        public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.OrgUnits>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string customerId) : base(service)
            {
                CustomerId = customerId;
                InitParameters();
            }

            /// <summary>
            /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use
            /// the `my_customer` alias to represent your account's `customerId`. The `customerId` is also returned as
            /// part of the [Users resource](/admin-sdk/directory/v1/reference/users).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>
            /// The full path to the organizational unit or its unique ID. Returns the children of the specified
            /// organizational unit.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("orgUnitPath", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrgUnitPath { get; set; }

            /// <summary>Whether to return all sub-organizations or just immediate children.</summary>
            [Google.Apis.Util.RequestParameterAttribute("type", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<TypeEnum> Type { get; set; }

            /// <summary>Whether to return all sub-organizations or just immediate children.</summary>
            public enum TypeEnum
            {
                /// <summary>All sub-organizational units.</summary>
                [Google.Apis.Util.StringValueAttribute("all")]
                All = 0,

                /// <summary>Immediate children only (default).</summary>
                [Google.Apis.Util.StringValueAttribute("children")]
                Children = 1,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/orgunits";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("orgUnitPath", new Google.Apis.Discovery.Parameter
                {
                    Name = "orgUnitPath",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("type", new Google.Apis.Discovery.Parameter
                {
                    Name = "type",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates an organizational unit. This method supports [patch
        /// semantics](/admin-sdk/directory/v1/guides/performance#patch)
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customerId">
        /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use the
        /// `my_customer` alias to represent your account's `customerId`. The `customerId` is also returned as part of
        /// the [Users resource](/admin-sdk/directory/v1/reference/users).
        /// </param>
        /// <param name="orgUnitPath">The full path of the organizational unit or its unique ID.</param>
        public virtual PatchRequest Patch(Google.Apis.Admin.Directory.directory_v1.Data.OrgUnit body, string customerId, string orgUnitPath)
        {
            return new PatchRequest(service, body, customerId, orgUnitPath);
        }

        /// <summary>
        /// Updates an organizational unit. This method supports [patch
        /// semantics](/admin-sdk/directory/v1/guides/performance#patch)
        /// </summary>
        public class PatchRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.OrgUnit>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.OrgUnit body, string customerId, string orgUnitPath) : base(service)
            {
                CustomerId = customerId;
                OrgUnitPath = orgUnitPath;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use
            /// the `my_customer` alias to represent your account's `customerId`. The `customerId` is also returned as
            /// part of the [Users resource](/admin-sdk/directory/v1/reference/users).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>The full path of the organizational unit or its unique ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orgUnitPath", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string OrgUnitPath { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.OrgUnit Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/orgunits/{+orgUnitPath}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("orgUnitPath", new Google.Apis.Discovery.Parameter
                {
                    Name = "orgUnitPath",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^.*$",
                });
            }
        }

        /// <summary>Updates an organizational unit.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customerId">
        /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use the
        /// `my_customer` alias to represent your account's `customerId`. The `customerId` is also returned as part of
        /// the [Users resource](/admin-sdk/directory/v1/reference/users).
        /// </param>
        /// <param name="orgUnitPath">The full path of the organizational unit or its unique ID.</param>
        public virtual UpdateRequest Update(Google.Apis.Admin.Directory.directory_v1.Data.OrgUnit body, string customerId, string orgUnitPath)
        {
            return new UpdateRequest(service, body, customerId, orgUnitPath);
        }

        /// <summary>Updates an organizational unit.</summary>
        public class UpdateRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.OrgUnit>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.OrgUnit body, string customerId, string orgUnitPath) : base(service)
            {
                CustomerId = customerId;
                OrgUnitPath = orgUnitPath;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use
            /// the `my_customer` alias to represent your account's `customerId`. The `customerId` is also returned as
            /// part of the [Users resource](/admin-sdk/directory/v1/reference/users).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>The full path of the organizational unit or its unique ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orgUnitPath", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string OrgUnitPath { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.OrgUnit Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/orgunits/{+orgUnitPath}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("orgUnitPath", new Google.Apis.Discovery.Parameter
                {
                    Name = "orgUnitPath",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^.*$",
                });
            }
        }
    }

    /// <summary>The "privileges" collection of methods.</summary>
    public class PrivilegesResource
    {
        private const string Resource = "privileges";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PrivilegesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Retrieves a paginated list of all privileges for a customer.</summary>
        /// <param name="customer">Immutable ID of the Google Workspace account.</param>
        public virtual ListRequest List(string customer)
        {
            return new ListRequest(service, customer);
        }

        /// <summary>Retrieves a paginated list of all privileges for a customer.</summary>
        public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Privileges>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string customer) : base(service)
            {
                Customer = customer;
                InitParameters();
            }

            /// <summary>Immutable ID of the Google Workspace account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customer}/roles/ALL/privileges";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                {
                    Name = "customer",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "resources" collection of methods.</summary>
    public class ResourcesResource
    {
        private const string Resource = "resources";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ResourcesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Buildings = new BuildingsResource(service);
            Calendars = new CalendarsResource(service);
            Features = new FeaturesResource(service);
        }

        /// <summary>Gets the Buildings resource.</summary>
        public virtual BuildingsResource Buildings { get; }

        /// <summary>The "buildings" collection of methods.</summary>
        public class BuildingsResource
        {
            private const string Resource = "buildings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public BuildingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Deletes a building.</summary>
            /// <param name="customer">
            /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use
            /// the `my_customer` alias to represent your account's customer ID.
            /// </param>
            /// <param name="buildingId">The id of the building to delete.</param>
            public virtual DeleteRequest Delete(string customer, string buildingId)
            {
                return new DeleteRequest(service, customer, buildingId);
            }

            /// <summary>Deletes a building.</summary>
            public class DeleteRequest : DirectoryBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string customer, string buildingId) : base(service)
                {
                    Customer = customer;
                    BuildingId = buildingId;
                    InitParameters();
                }

                /// <summary>
                /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also
                /// use the `my_customer` alias to represent your account's customer ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>The id of the building to delete.</summary>
                [Google.Apis.Util.RequestParameterAttribute("buildingId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string BuildingId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/customer/{customer}/resources/buildings/{buildingId}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("buildingId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "buildingId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Retrieves a building.</summary>
            /// <param name="customer">
            /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use
            /// the `my_customer` alias to represent your account's customer ID.
            /// </param>
            /// <param name="buildingId">The unique ID of the building to retrieve.</param>
            public virtual GetRequest Get(string customer, string buildingId)
            {
                return new GetRequest(service, customer, buildingId);
            }

            /// <summary>Retrieves a building.</summary>
            public class GetRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Building>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string customer, string buildingId) : base(service)
                {
                    Customer = customer;
                    BuildingId = buildingId;
                    InitParameters();
                }

                /// <summary>
                /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also
                /// use the `my_customer` alias to represent your account's customer ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>The unique ID of the building to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("buildingId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string BuildingId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/customer/{customer}/resources/buildings/{buildingId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("buildingId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "buildingId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Inserts a building.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="customer">
            /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use
            /// the `my_customer` alias to represent your account's customer ID.
            /// </param>
            public virtual InsertRequest Insert(Google.Apis.Admin.Directory.directory_v1.Data.Building body, string customer)
            {
                return new InsertRequest(service, body, customer);
            }

            /// <summary>Inserts a building.</summary>
            public class InsertRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Building>
            {
                /// <summary>Constructs a new Insert request.</summary>
                public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Building body, string customer) : base(service)
                {
                    Customer = customer;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also
                /// use the `my_customer` alias to represent your account's customer ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>Source from which Building.coordinates are derived.</summary>
                [Google.Apis.Util.RequestParameterAttribute("coordinatesSource", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<CoordinatesSourceEnum> CoordinatesSource { get; set; }

                /// <summary>Source from which Building.coordinates are derived.</summary>
                public enum CoordinatesSourceEnum
                {
                    /// <summary>Building.coordinates are set to the coordinates included in the request.</summary>
                    [Google.Apis.Util.StringValueAttribute("CLIENT_SPECIFIED")]
                    CLIENTSPECIFIED = 0,

                    /// <summary>Building.coordinates are automatically populated based on the postal address.</summary>
                    [Google.Apis.Util.StringValueAttribute("RESOLVED_FROM_ADDRESS")]
                    RESOLVEDFROMADDRESS = 1,

                    /// <summary>
                    /// Defaults to `RESOLVED_FROM_ADDRESS` if postal address is provided. Otherwise, defaults to
                    /// `CLIENT_SPECIFIED` if coordinates are provided.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("SOURCE_UNSPECIFIED")]
                    SOURCEUNSPECIFIED = 2,
                }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Admin.Directory.directory_v1.Data.Building Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "insert";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/customer/{customer}/resources/buildings";

                /// <summary>Initializes Insert parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("coordinatesSource", new Google.Apis.Discovery.Parameter
                    {
                        Name = "coordinatesSource",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = "SOURCE_UNSPECIFIED",
                        Pattern = null,
                    });
                }
            }

            /// <summary>Retrieves a list of buildings for an account.</summary>
            /// <param name="customer">
            /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use
            /// the `my_customer` alias to represent your account's customer ID.
            /// </param>
            public virtual ListRequest List(string customer)
            {
                return new ListRequest(service, customer);
            }

            /// <summary>Retrieves a list of buildings for an account.</summary>
            public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Buildings>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string customer) : base(service)
                {
                    Customer = customer;
                    InitParameters();
                }

                /// <summary>
                /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also
                /// use the `my_customer` alias to represent your account's customer ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>Maximum number of results to return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> MaxResults { get; set; }

                /// <summary>Token to specify the next page in the list.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/customer/{customer}/resources/buildings";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                    {
                        Name = "maxResults",
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

            /// <summary>Patches a building via Apiary Patch Orchestration.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="customer">
            /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use
            /// the `my_customer` alias to represent your account's customer ID.
            /// </param>
            /// <param name="buildingId">The id of the building to update.</param>
            public virtual PatchRequest Patch(Google.Apis.Admin.Directory.directory_v1.Data.Building body, string customer, string buildingId)
            {
                return new PatchRequest(service, body, customer, buildingId);
            }

            /// <summary>Patches a building via Apiary Patch Orchestration.</summary>
            public class PatchRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Building>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Building body, string customer, string buildingId) : base(service)
                {
                    Customer = customer;
                    BuildingId = buildingId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also
                /// use the `my_customer` alias to represent your account's customer ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>The id of the building to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("buildingId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string BuildingId { get; private set; }

                /// <summary>Source from which Building.coordinates are derived.</summary>
                [Google.Apis.Util.RequestParameterAttribute("coordinatesSource", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<CoordinatesSourceEnum> CoordinatesSource { get; set; }

                /// <summary>Source from which Building.coordinates are derived.</summary>
                public enum CoordinatesSourceEnum
                {
                    /// <summary>Building.coordinates are set to the coordinates included in the request.</summary>
                    [Google.Apis.Util.StringValueAttribute("CLIENT_SPECIFIED")]
                    CLIENTSPECIFIED = 0,

                    /// <summary>Building.coordinates are automatically populated based on the postal address.</summary>
                    [Google.Apis.Util.StringValueAttribute("RESOLVED_FROM_ADDRESS")]
                    RESOLVEDFROMADDRESS = 1,

                    /// <summary>
                    /// Defaults to `RESOLVED_FROM_ADDRESS` if postal address is provided. Otherwise, defaults to
                    /// `CLIENT_SPECIFIED` if coordinates are provided.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("SOURCE_UNSPECIFIED")]
                    SOURCEUNSPECIFIED = 2,
                }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Admin.Directory.directory_v1.Data.Building Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/customer/{customer}/resources/buildings/{buildingId}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("buildingId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "buildingId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("coordinatesSource", new Google.Apis.Discovery.Parameter
                    {
                        Name = "coordinatesSource",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = "SOURCE_UNSPECIFIED",
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates a building.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="customer">
            /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use
            /// the `my_customer` alias to represent your account's customer ID.
            /// </param>
            /// <param name="buildingId">The id of the building to update.</param>
            public virtual UpdateRequest Update(Google.Apis.Admin.Directory.directory_v1.Data.Building body, string customer, string buildingId)
            {
                return new UpdateRequest(service, body, customer, buildingId);
            }

            /// <summary>Updates a building.</summary>
            public class UpdateRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Building>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Building body, string customer, string buildingId) : base(service)
                {
                    Customer = customer;
                    BuildingId = buildingId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also
                /// use the `my_customer` alias to represent your account's customer ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>The id of the building to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("buildingId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string BuildingId { get; private set; }

                /// <summary>Source from which Building.coordinates are derived.</summary>
                [Google.Apis.Util.RequestParameterAttribute("coordinatesSource", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<CoordinatesSourceEnum> CoordinatesSource { get; set; }

                /// <summary>Source from which Building.coordinates are derived.</summary>
                public enum CoordinatesSourceEnum
                {
                    /// <summary>Building.coordinates are set to the coordinates included in the request.</summary>
                    [Google.Apis.Util.StringValueAttribute("CLIENT_SPECIFIED")]
                    CLIENTSPECIFIED = 0,

                    /// <summary>Building.coordinates are automatically populated based on the postal address.</summary>
                    [Google.Apis.Util.StringValueAttribute("RESOLVED_FROM_ADDRESS")]
                    RESOLVEDFROMADDRESS = 1,

                    /// <summary>
                    /// Defaults to `RESOLVED_FROM_ADDRESS` if postal address is provided. Otherwise, defaults to
                    /// `CLIENT_SPECIFIED` if coordinates are provided.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("SOURCE_UNSPECIFIED")]
                    SOURCEUNSPECIFIED = 2,
                }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Admin.Directory.directory_v1.Data.Building Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/customer/{customer}/resources/buildings/{buildingId}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("buildingId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "buildingId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("coordinatesSource", new Google.Apis.Discovery.Parameter
                    {
                        Name = "coordinatesSource",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = "SOURCE_UNSPECIFIED",
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Calendars resource.</summary>
        public virtual CalendarsResource Calendars { get; }

        /// <summary>The "calendars" collection of methods.</summary>
        public class CalendarsResource
        {
            private const string Resource = "calendars";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public CalendarsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Deletes a calendar resource.</summary>
            /// <param name="customer">
            /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use
            /// the `my_customer` alias to represent your account's customer ID.
            /// </param>
            /// <param name="calendarResourceId">The unique ID of the calendar resource to delete.</param>
            public virtual DeleteRequest Delete(string customer, string calendarResourceId)
            {
                return new DeleteRequest(service, customer, calendarResourceId);
            }

            /// <summary>Deletes a calendar resource.</summary>
            public class DeleteRequest : DirectoryBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string customer, string calendarResourceId) : base(service)
                {
                    Customer = customer;
                    CalendarResourceId = calendarResourceId;
                    InitParameters();
                }

                /// <summary>
                /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also
                /// use the `my_customer` alias to represent your account's customer ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>The unique ID of the calendar resource to delete.</summary>
                [Google.Apis.Util.RequestParameterAttribute("calendarResourceId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CalendarResourceId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/customer/{customer}/resources/calendars/{calendarResourceId}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("calendarResourceId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "calendarResourceId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Retrieves a calendar resource.</summary>
            /// <param name="customer">
            /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use
            /// the `my_customer` alias to represent your account's customer ID.
            /// </param>
            /// <param name="calendarResourceId">The unique ID of the calendar resource to retrieve.</param>
            public virtual GetRequest Get(string customer, string calendarResourceId)
            {
                return new GetRequest(service, customer, calendarResourceId);
            }

            /// <summary>Retrieves a calendar resource.</summary>
            public class GetRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.CalendarResource>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string customer, string calendarResourceId) : base(service)
                {
                    Customer = customer;
                    CalendarResourceId = calendarResourceId;
                    InitParameters();
                }

                /// <summary>
                /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also
                /// use the `my_customer` alias to represent your account's customer ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>The unique ID of the calendar resource to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("calendarResourceId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CalendarResourceId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/customer/{customer}/resources/calendars/{calendarResourceId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("calendarResourceId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "calendarResourceId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Inserts a calendar resource.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="customer">
            /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use
            /// the `my_customer` alias to represent your account's customer ID.
            /// </param>
            public virtual InsertRequest Insert(Google.Apis.Admin.Directory.directory_v1.Data.CalendarResource body, string customer)
            {
                return new InsertRequest(service, body, customer);
            }

            /// <summary>Inserts a calendar resource.</summary>
            public class InsertRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.CalendarResource>
            {
                /// <summary>Constructs a new Insert request.</summary>
                public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.CalendarResource body, string customer) : base(service)
                {
                    Customer = customer;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also
                /// use the `my_customer` alias to represent your account's customer ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Admin.Directory.directory_v1.Data.CalendarResource Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "insert";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/customer/{customer}/resources/calendars";

                /// <summary>Initializes Insert parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Retrieves a list of calendar resources for an account.</summary>
            /// <param name="customer">
            /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use
            /// the `my_customer` alias to represent your account's customer ID.
            /// </param>
            public virtual ListRequest List(string customer)
            {
                return new ListRequest(service, customer);
            }

            /// <summary>Retrieves a list of calendar resources for an account.</summary>
            public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.CalendarResources>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string customer) : base(service)
                {
                    Customer = customer;
                    InitParameters();
                }

                /// <summary>
                /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also
                /// use the `my_customer` alias to represent your account's customer ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>Maximum number of results to return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> MaxResults { get; set; }

                /// <summary>
                /// Field(s) to sort results by in either ascending or descending order. Supported fields include
                /// `resourceId`, `resourceName`, `capacity`, `buildingId`, and `floorName`. If no order is specified,
                /// defaults to ascending. Should be of the form "field [asc|desc], field [asc|desc], ...". For example
                /// `buildingId, capacity desc` would return results sorted first by `buildingId` in ascending order
                /// then by `capacity` in descending order.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>Token to specify the next page in the list.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// String query used to filter results. Should be of the form "field operator value" where field can be
                /// any of supported fields and operators can be any of supported operations. Operators include '=' for
                /// exact match, '!=' for mismatch and ':' for prefix match or HAS match where applicable. For prefix
                /// match, the value should always be followed by a *. Logical operators NOT and AND are supported (in
                /// this order of precedence). Supported fields include `generatedResourceName`, `name`, `buildingId`,
                /// `floor_name`, `capacity`, `featureInstances.feature.name`, `resourceEmail`, `resourceCategory`. For
                /// example `buildingId=US-NYC-9TH AND featureInstances.feature.name:Phone`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Query { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/customer/{customer}/resources/calendars";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                    {
                        Name = "maxResults",
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

            /// <summary>Patches a calendar resource via Apiary Patch Orchestration.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="customer">
            /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use
            /// the `my_customer` alias to represent your account's customer ID.
            /// </param>
            /// <param name="calendarResourceId">The unique ID of the calendar resource to update.</param>
            public virtual PatchRequest Patch(Google.Apis.Admin.Directory.directory_v1.Data.CalendarResource body, string customer, string calendarResourceId)
            {
                return new PatchRequest(service, body, customer, calendarResourceId);
            }

            /// <summary>Patches a calendar resource via Apiary Patch Orchestration.</summary>
            public class PatchRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.CalendarResource>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.CalendarResource body, string customer, string calendarResourceId) : base(service)
                {
                    Customer = customer;
                    CalendarResourceId = calendarResourceId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also
                /// use the `my_customer` alias to represent your account's customer ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>The unique ID of the calendar resource to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("calendarResourceId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CalendarResourceId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Admin.Directory.directory_v1.Data.CalendarResource Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/customer/{customer}/resources/calendars/{calendarResourceId}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("calendarResourceId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "calendarResourceId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Updates a calendar resource. This method supports patch semantics, meaning you only need to include the
            /// fields you wish to update. Fields that are not present in the request will be preserved.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="customer">
            /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use
            /// the `my_customer` alias to represent your account's customer ID.
            /// </param>
            /// <param name="calendarResourceId">The unique ID of the calendar resource to update.</param>
            public virtual UpdateRequest Update(Google.Apis.Admin.Directory.directory_v1.Data.CalendarResource body, string customer, string calendarResourceId)
            {
                return new UpdateRequest(service, body, customer, calendarResourceId);
            }

            /// <summary>
            /// Updates a calendar resource. This method supports patch semantics, meaning you only need to include the
            /// fields you wish to update. Fields that are not present in the request will be preserved.
            /// </summary>
            public class UpdateRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.CalendarResource>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.CalendarResource body, string customer, string calendarResourceId) : base(service)
                {
                    Customer = customer;
                    CalendarResourceId = calendarResourceId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also
                /// use the `my_customer` alias to represent your account's customer ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>The unique ID of the calendar resource to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("calendarResourceId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CalendarResourceId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Admin.Directory.directory_v1.Data.CalendarResource Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/customer/{customer}/resources/calendars/{calendarResourceId}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("calendarResourceId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "calendarResourceId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Features resource.</summary>
        public virtual FeaturesResource Features { get; }

        /// <summary>The "features" collection of methods.</summary>
        public class FeaturesResource
        {
            private const string Resource = "features";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public FeaturesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Deletes a feature.</summary>
            /// <param name="customer">
            /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use
            /// the `my_customer` alias to represent your account's customer ID.
            /// </param>
            /// <param name="featureKey">The unique ID of the feature to delete.</param>
            public virtual DeleteRequest Delete(string customer, string featureKey)
            {
                return new DeleteRequest(service, customer, featureKey);
            }

            /// <summary>Deletes a feature.</summary>
            public class DeleteRequest : DirectoryBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string customer, string featureKey) : base(service)
                {
                    Customer = customer;
                    FeatureKey = featureKey;
                    InitParameters();
                }

                /// <summary>
                /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also
                /// use the `my_customer` alias to represent your account's customer ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>The unique ID of the feature to delete.</summary>
                [Google.Apis.Util.RequestParameterAttribute("featureKey", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string FeatureKey { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/customer/{customer}/resources/features/{featureKey}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("featureKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "featureKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Retrieves a feature.</summary>
            /// <param name="customer">
            /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use
            /// the `my_customer` alias to represent your account's customer ID.
            /// </param>
            /// <param name="featureKey">The unique ID of the feature to retrieve.</param>
            public virtual GetRequest Get(string customer, string featureKey)
            {
                return new GetRequest(service, customer, featureKey);
            }

            /// <summary>Retrieves a feature.</summary>
            public class GetRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Feature>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string customer, string featureKey) : base(service)
                {
                    Customer = customer;
                    FeatureKey = featureKey;
                    InitParameters();
                }

                /// <summary>
                /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also
                /// use the `my_customer` alias to represent your account's customer ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>The unique ID of the feature to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("featureKey", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string FeatureKey { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/customer/{customer}/resources/features/{featureKey}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("featureKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "featureKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Inserts a feature.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="customer">
            /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use
            /// the `my_customer` alias to represent your account's customer ID.
            /// </param>
            public virtual InsertRequest Insert(Google.Apis.Admin.Directory.directory_v1.Data.Feature body, string customer)
            {
                return new InsertRequest(service, body, customer);
            }

            /// <summary>Inserts a feature.</summary>
            public class InsertRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Feature>
            {
                /// <summary>Constructs a new Insert request.</summary>
                public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Feature body, string customer) : base(service)
                {
                    Customer = customer;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also
                /// use the `my_customer` alias to represent your account's customer ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Admin.Directory.directory_v1.Data.Feature Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "insert";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/customer/{customer}/resources/features";

                /// <summary>Initializes Insert parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Retrieves a list of features for an account.</summary>
            /// <param name="customer">
            /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use
            /// the `my_customer` alias to represent your account's customer ID.
            /// </param>
            public virtual ListRequest List(string customer)
            {
                return new ListRequest(service, customer);
            }

            /// <summary>Retrieves a list of features for an account.</summary>
            public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Features>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string customer) : base(service)
                {
                    Customer = customer;
                    InitParameters();
                }

                /// <summary>
                /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also
                /// use the `my_customer` alias to represent your account's customer ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>Maximum number of results to return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> MaxResults { get; set; }

                /// <summary>Token to specify the next page in the list.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/customer/{customer}/resources/features";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                    {
                        Name = "maxResults",
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

            /// <summary>Patches a feature via Apiary Patch Orchestration.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="customer">
            /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use
            /// the `my_customer` alias to represent your account's customer ID.
            /// </param>
            /// <param name="featureKey">The unique ID of the feature to update.</param>
            public virtual PatchRequest Patch(Google.Apis.Admin.Directory.directory_v1.Data.Feature body, string customer, string featureKey)
            {
                return new PatchRequest(service, body, customer, featureKey);
            }

            /// <summary>Patches a feature via Apiary Patch Orchestration.</summary>
            public class PatchRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Feature>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Feature body, string customer, string featureKey) : base(service)
                {
                    Customer = customer;
                    FeatureKey = featureKey;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also
                /// use the `my_customer` alias to represent your account's customer ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>The unique ID of the feature to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("featureKey", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string FeatureKey { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Admin.Directory.directory_v1.Data.Feature Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/customer/{customer}/resources/features/{featureKey}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("featureKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "featureKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Renames a feature.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="customer">
            /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use
            /// the `my_customer` alias to represent your account's customer ID.
            /// </param>
            /// <param name="oldName">The unique ID of the feature to rename.</param>
            public virtual RenameRequest Rename(Google.Apis.Admin.Directory.directory_v1.Data.FeatureRename body, string customer, string oldName)
            {
                return new RenameRequest(service, body, customer, oldName);
            }

            /// <summary>Renames a feature.</summary>
            public class RenameRequest : DirectoryBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Rename request.</summary>
                public RenameRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.FeatureRename body, string customer, string oldName) : base(service)
                {
                    Customer = customer;
                    OldName = oldName;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also
                /// use the `my_customer` alias to represent your account's customer ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>The unique ID of the feature to rename.</summary>
                [Google.Apis.Util.RequestParameterAttribute("oldName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string OldName { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Admin.Directory.directory_v1.Data.FeatureRename Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "rename";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/customer/{customer}/resources/features/{oldName}/rename";

                /// <summary>Initializes Rename parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("oldName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "oldName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates a feature.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="customer">
            /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also use
            /// the `my_customer` alias to represent your account's customer ID.
            /// </param>
            /// <param name="featureKey">The unique ID of the feature to update.</param>
            public virtual UpdateRequest Update(Google.Apis.Admin.Directory.directory_v1.Data.Feature body, string customer, string featureKey)
            {
                return new UpdateRequest(service, body, customer, featureKey);
            }

            /// <summary>Updates a feature.</summary>
            public class UpdateRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Feature>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Feature body, string customer, string featureKey) : base(service)
                {
                    Customer = customer;
                    FeatureKey = featureKey;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The unique ID for the customer's Google Workspace account. As an account administrator, you can also
                /// use the `my_customer` alias to represent your account's customer ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>The unique ID of the feature to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("featureKey", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string FeatureKey { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Admin.Directory.directory_v1.Data.Feature Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/customer/{customer}/resources/features/{featureKey}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("featureKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "featureKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }
    }

    /// <summary>The "roleAssignments" collection of methods.</summary>
    public class RoleAssignmentsResource
    {
        private const string Resource = "roleAssignments";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public RoleAssignmentsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Deletes a role assignment.</summary>
        /// <param name="customer">Immutable ID of the Google Workspace account.</param>
        /// <param name="roleAssignmentId">Immutable ID of the role assignment.</param>
        public virtual DeleteRequest Delete(string customer, string roleAssignmentId)
        {
            return new DeleteRequest(service, customer, roleAssignmentId);
        }

        /// <summary>Deletes a role assignment.</summary>
        public class DeleteRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string customer, string roleAssignmentId) : base(service)
            {
                Customer = customer;
                RoleAssignmentId = roleAssignmentId;
                InitParameters();
            }

            /// <summary>Immutable ID of the Google Workspace account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }

            /// <summary>Immutable ID of the role assignment.</summary>
            [Google.Apis.Util.RequestParameterAttribute("roleAssignmentId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string RoleAssignmentId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customer}/roleassignments/{roleAssignmentId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                {
                    Name = "customer",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("roleAssignmentId", new Google.Apis.Discovery.Parameter
                {
                    Name = "roleAssignmentId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieve a role assignment.</summary>
        /// <param name="customer">Immutable ID of the Google Workspace account.</param>
        /// <param name="roleAssignmentId">Immutable ID of the role assignment.</param>
        public virtual GetRequest Get(string customer, string roleAssignmentId)
        {
            return new GetRequest(service, customer, roleAssignmentId);
        }

        /// <summary>Retrieve a role assignment.</summary>
        public class GetRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.RoleAssignment>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string customer, string roleAssignmentId) : base(service)
            {
                Customer = customer;
                RoleAssignmentId = roleAssignmentId;
                InitParameters();
            }

            /// <summary>Immutable ID of the Google Workspace account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }

            /// <summary>Immutable ID of the role assignment.</summary>
            [Google.Apis.Util.RequestParameterAttribute("roleAssignmentId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string RoleAssignmentId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customer}/roleassignments/{roleAssignmentId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                {
                    Name = "customer",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("roleAssignmentId", new Google.Apis.Discovery.Parameter
                {
                    Name = "roleAssignmentId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Creates a role assignment.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customer">Immutable ID of the Google Workspace account.</param>
        public virtual InsertRequest Insert(Google.Apis.Admin.Directory.directory_v1.Data.RoleAssignment body, string customer)
        {
            return new InsertRequest(service, body, customer);
        }

        /// <summary>Creates a role assignment.</summary>
        public class InsertRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.RoleAssignment>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.RoleAssignment body, string customer) : base(service)
            {
                Customer = customer;
                Body = body;
                InitParameters();
            }

            /// <summary>Immutable ID of the Google Workspace account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.RoleAssignment Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customer}/roleassignments";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                {
                    Name = "customer",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves a paginated list of all roleAssignments.</summary>
        /// <param name="customer">Immutable ID of the Google Workspace account.</param>
        public virtual ListRequest List(string customer)
        {
            return new ListRequest(service, customer);
        }

        /// <summary>Retrieves a paginated list of all roleAssignments.</summary>
        public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.RoleAssignments>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string customer) : base(service)
            {
                Customer = customer;
                InitParameters();
            }

            /// <summary>Immutable ID of the Google Workspace account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }

            /// <summary>Maximum number of results to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>Token to specify the next page in the list.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Immutable ID of a role. If included in the request, returns only role assignments containing this role
            /// ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("roleId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string RoleId { get; set; }

            /// <summary>
            /// The user's primary email address, alias email address, or unique user ID. If included in the request,
            /// returns role assignments only for this user.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserKey { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customer}/roleassignments";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                {
                    Name = "customer",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
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
                RequestParameters.Add("roleId", new Google.Apis.Discovery.Parameter
                {
                    Name = "roleId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "userKey",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "roles" collection of methods.</summary>
    public class RolesResource
    {
        private const string Resource = "roles";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public RolesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Deletes a role.</summary>
        /// <param name="customer">Immutable ID of the Google Workspace account.</param>
        /// <param name="roleId">Immutable ID of the role.</param>
        public virtual DeleteRequest Delete(string customer, string roleId)
        {
            return new DeleteRequest(service, customer, roleId);
        }

        /// <summary>Deletes a role.</summary>
        public class DeleteRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string customer, string roleId) : base(service)
            {
                Customer = customer;
                RoleId = roleId;
                InitParameters();
            }

            /// <summary>Immutable ID of the Google Workspace account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }

            /// <summary>Immutable ID of the role.</summary>
            [Google.Apis.Util.RequestParameterAttribute("roleId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string RoleId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customer}/roles/{roleId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                {
                    Name = "customer",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("roleId", new Google.Apis.Discovery.Parameter
                {
                    Name = "roleId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves a role.</summary>
        /// <param name="customer">Immutable ID of the Google Workspace account.</param>
        /// <param name="roleId">Immutable ID of the role.</param>
        public virtual GetRequest Get(string customer, string roleId)
        {
            return new GetRequest(service, customer, roleId);
        }

        /// <summary>Retrieves a role.</summary>
        public class GetRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Role>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string customer, string roleId) : base(service)
            {
                Customer = customer;
                RoleId = roleId;
                InitParameters();
            }

            /// <summary>Immutable ID of the Google Workspace account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }

            /// <summary>Immutable ID of the role.</summary>
            [Google.Apis.Util.RequestParameterAttribute("roleId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string RoleId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customer}/roles/{roleId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                {
                    Name = "customer",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("roleId", new Google.Apis.Discovery.Parameter
                {
                    Name = "roleId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Creates a role.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customer">Immutable ID of the Google Workspace account.</param>
        public virtual InsertRequest Insert(Google.Apis.Admin.Directory.directory_v1.Data.Role body, string customer)
        {
            return new InsertRequest(service, body, customer);
        }

        /// <summary>Creates a role.</summary>
        public class InsertRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Role>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Role body, string customer) : base(service)
            {
                Customer = customer;
                Body = body;
                InitParameters();
            }

            /// <summary>Immutable ID of the Google Workspace account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.Role Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customer}/roles";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                {
                    Name = "customer",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves a paginated list of all the roles in a domain.</summary>
        /// <param name="customer">Immutable ID of the Google Workspace account.</param>
        public virtual ListRequest List(string customer)
        {
            return new ListRequest(service, customer);
        }

        /// <summary>Retrieves a paginated list of all the roles in a domain.</summary>
        public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Roles>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string customer) : base(service)
            {
                Customer = customer;
                InitParameters();
            }

            /// <summary>Immutable ID of the Google Workspace account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }

            /// <summary>Maximum number of results to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>Token to specify the next page in the list.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customer}/roles";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                {
                    Name = "customer",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
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

        /// <summary>Patch role via Apiary Patch Orchestration</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customer">Immutable ID of the Google Workspace account.</param>
        /// <param name="roleId">Immutable ID of the role.</param>
        public virtual PatchRequest Patch(Google.Apis.Admin.Directory.directory_v1.Data.Role body, string customer, string roleId)
        {
            return new PatchRequest(service, body, customer, roleId);
        }

        /// <summary>Patch role via Apiary Patch Orchestration</summary>
        public class PatchRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Role>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Role body, string customer, string roleId) : base(service)
            {
                Customer = customer;
                RoleId = roleId;
                Body = body;
                InitParameters();
            }

            /// <summary>Immutable ID of the Google Workspace account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }

            /// <summary>Immutable ID of the role.</summary>
            [Google.Apis.Util.RequestParameterAttribute("roleId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string RoleId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.Role Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customer}/roles/{roleId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                {
                    Name = "customer",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("roleId", new Google.Apis.Discovery.Parameter
                {
                    Name = "roleId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates a role.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customer">Immutable ID of the Google Workspace account.</param>
        /// <param name="roleId">Immutable ID of the role.</param>
        public virtual UpdateRequest Update(Google.Apis.Admin.Directory.directory_v1.Data.Role body, string customer, string roleId)
        {
            return new UpdateRequest(service, body, customer, roleId);
        }

        /// <summary>Updates a role.</summary>
        public class UpdateRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Role>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Role body, string customer, string roleId) : base(service)
            {
                Customer = customer;
                RoleId = roleId;
                Body = body;
                InitParameters();
            }

            /// <summary>Immutable ID of the Google Workspace account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }

            /// <summary>Immutable ID of the role.</summary>
            [Google.Apis.Util.RequestParameterAttribute("roleId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string RoleId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.Role Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customer}/roles/{roleId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                {
                    Name = "customer",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("roleId", new Google.Apis.Discovery.Parameter
                {
                    Name = "roleId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "schemas" collection of methods.</summary>
    public class SchemasResource
    {
        private const string Resource = "schemas";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public SchemasResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Delete schema</summary>
        /// <param name="customerId">Immutable ID of the Google Workspace account.</param>
        /// <param name="schemaKey">Name or immutable ID of the schema.</param>
        public virtual DeleteRequest Delete(string customerId, string schemaKey)
        {
            return new DeleteRequest(service, customerId, schemaKey);
        }

        /// <summary>Delete schema</summary>
        public class DeleteRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string customerId, string schemaKey) : base(service)
            {
                CustomerId = customerId;
                SchemaKey = schemaKey;
                InitParameters();
            }

            /// <summary>Immutable ID of the Google Workspace account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>Name or immutable ID of the schema.</summary>
            [Google.Apis.Util.RequestParameterAttribute("schemaKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SchemaKey { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/schemas/{schemaKey}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("schemaKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "schemaKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieve schema</summary>
        /// <param name="customerId">Immutable ID of the Google Workspace account.</param>
        /// <param name="schemaKey">Name or immutable ID of the schema.</param>
        public virtual GetRequest Get(string customerId, string schemaKey)
        {
            return new GetRequest(service, customerId, schemaKey);
        }

        /// <summary>Retrieve schema</summary>
        public class GetRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Schema>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string customerId, string schemaKey) : base(service)
            {
                CustomerId = customerId;
                SchemaKey = schemaKey;
                InitParameters();
            }

            /// <summary>Immutable ID of the Google Workspace account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>Name or immutable ID of the schema.</summary>
            [Google.Apis.Util.RequestParameterAttribute("schemaKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SchemaKey { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/schemas/{schemaKey}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("schemaKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "schemaKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Create schema.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customerId">Immutable ID of the Google Workspace account.</param>
        public virtual InsertRequest Insert(Google.Apis.Admin.Directory.directory_v1.Data.Schema body, string customerId)
        {
            return new InsertRequest(service, body, customerId);
        }

        /// <summary>Create schema.</summary>
        public class InsertRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Schema>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Schema body, string customerId) : base(service)
            {
                CustomerId = customerId;
                Body = body;
                InitParameters();
            }

            /// <summary>Immutable ID of the Google Workspace account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.Schema Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/schemas";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieve all schemas for a customer</summary>
        /// <param name="customerId">Immutable ID of the Google Workspace account.</param>
        public virtual ListRequest List(string customerId)
        {
            return new ListRequest(service, customerId);
        }

        /// <summary>Retrieve all schemas for a customer</summary>
        public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Schemas>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string customerId) : base(service)
            {
                CustomerId = customerId;
                InitParameters();
            }

            /// <summary>Immutable ID of the Google Workspace account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/schemas";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Patch Schema via Apiary Patch Orchestration</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customerId">Immutable ID of the Google Workspace account.</param>
        /// <param name="schemaKey">Name or immutable ID of the schema.</param>
        public virtual PatchRequest Patch(Google.Apis.Admin.Directory.directory_v1.Data.Schema body, string customerId, string schemaKey)
        {
            return new PatchRequest(service, body, customerId, schemaKey);
        }

        /// <summary>Patch Schema via Apiary Patch Orchestration</summary>
        public class PatchRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Schema>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Schema body, string customerId, string schemaKey) : base(service)
            {
                CustomerId = customerId;
                SchemaKey = schemaKey;
                Body = body;
                InitParameters();
            }

            /// <summary>Immutable ID of the Google Workspace account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>Name or immutable ID of the schema.</summary>
            [Google.Apis.Util.RequestParameterAttribute("schemaKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SchemaKey { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.Schema Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/schemas/{schemaKey}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("schemaKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "schemaKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Update schema</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customerId">Immutable ID of the Google Workspace account.</param>
        /// <param name="schemaKey">Name or immutable ID of the schema.</param>
        public virtual UpdateRequest Update(Google.Apis.Admin.Directory.directory_v1.Data.Schema body, string customerId, string schemaKey)
        {
            return new UpdateRequest(service, body, customerId, schemaKey);
        }

        /// <summary>Update schema</summary>
        public class UpdateRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Schema>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Schema body, string customerId, string schemaKey) : base(service)
            {
                CustomerId = customerId;
                SchemaKey = schemaKey;
                Body = body;
                InitParameters();
            }

            /// <summary>Immutable ID of the Google Workspace account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>Name or immutable ID of the schema.</summary>
            [Google.Apis.Util.RequestParameterAttribute("schemaKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SchemaKey { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.Schema Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/schemas/{schemaKey}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("schemaKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "schemaKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "tokens" collection of methods.</summary>
    public class TokensResource
    {
        private const string Resource = "tokens";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public TokensResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Delete all access tokens issued by a user for an application.</summary>
        /// <param name="userKey">
        /// Identifies the user in the API request. The value can be the user's primary email address, alias email
        /// address, or unique user ID.
        /// </param>
        /// <param name="clientId">The Client ID of the application the token is issued to.</param>
        public virtual DeleteRequest Delete(string userKey, string clientId)
        {
            return new DeleteRequest(service, userKey, clientId);
        }

        /// <summary>Delete all access tokens issued by a user for an application.</summary>
        public class DeleteRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string userKey, string clientId) : base(service)
            {
                UserKey = userKey;
                ClientId = clientId;
                InitParameters();
            }

            /// <summary>
            /// Identifies the user in the API request. The value can be the user's primary email address, alias email
            /// address, or unique user ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserKey { get; private set; }

            /// <summary>The Client ID of the application the token is issued to.</summary>
            [Google.Apis.Util.RequestParameterAttribute("clientId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ClientId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/users/{userKey}/tokens/{clientId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("userKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "userKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientId", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Get information about an access token issued by a user.</summary>
        /// <param name="userKey">
        /// Identifies the user in the API request. The value can be the user's primary email address, alias email
        /// address, or unique user ID.
        /// </param>
        /// <param name="clientId">The Client ID of the application the token is issued to.</param>
        public virtual GetRequest Get(string userKey, string clientId)
        {
            return new GetRequest(service, userKey, clientId);
        }

        /// <summary>Get information about an access token issued by a user.</summary>
        public class GetRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Token>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string userKey, string clientId) : base(service)
            {
                UserKey = userKey;
                ClientId = clientId;
                InitParameters();
            }

            /// <summary>
            /// Identifies the user in the API request. The value can be the user's primary email address, alias email
            /// address, or unique user ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserKey { get; private set; }

            /// <summary>The Client ID of the application the token is issued to.</summary>
            [Google.Apis.Util.RequestParameterAttribute("clientId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ClientId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/users/{userKey}/tokens/{clientId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("userKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "userKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("clientId", new Google.Apis.Discovery.Parameter
                {
                    Name = "clientId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Returns the set of tokens specified user has issued to 3rd party applications.</summary>
        /// <param name="userKey">
        /// Identifies the user in the API request. The value can be the user's primary email address, alias email
        /// address, or unique user ID.
        /// </param>
        public virtual ListRequest List(string userKey)
        {
            return new ListRequest(service, userKey);
        }

        /// <summary>Returns the set of tokens specified user has issued to 3rd party applications.</summary>
        public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Tokens>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string userKey) : base(service)
            {
                UserKey = userKey;
                InitParameters();
            }

            /// <summary>
            /// Identifies the user in the API request. The value can be the user's primary email address, alias email
            /// address, or unique user ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserKey { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/users/{userKey}/tokens";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("userKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "userKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "twoStepVerification" collection of methods.</summary>
    public class TwoStepVerificationResource
    {
        private const string Resource = "twoStepVerification";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public TwoStepVerificationResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Turn off 2-Step Verification for user.</summary>
        /// <param name="userKey">
        /// Identifies the user in the API request. The value can be the user's primary email address, alias email
        /// address, or unique user ID.
        /// </param>
        public virtual TurnOffRequest TurnOff(string userKey)
        {
            return new TurnOffRequest(service, userKey);
        }

        /// <summary>Turn off 2-Step Verification for user.</summary>
        public class TurnOffRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new TurnOff request.</summary>
            public TurnOffRequest(Google.Apis.Services.IClientService service, string userKey) : base(service)
            {
                UserKey = userKey;
                InitParameters();
            }

            /// <summary>
            /// Identifies the user in the API request. The value can be the user's primary email address, alias email
            /// address, or unique user ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserKey { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "turnOff";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/users/{userKey}/twoStepVerification/turnOff";

            /// <summary>Initializes TurnOff parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("userKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "userKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

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
            Aliases = new AliasesResource(service);
            Photos = new PhotosResource(service);
        }

        /// <summary>Gets the Aliases resource.</summary>
        public virtual AliasesResource Aliases { get; }

        /// <summary>The "aliases" collection of methods.</summary>
        public class AliasesResource
        {
            private const string Resource = "aliases";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AliasesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Removes an alias.</summary>
            /// <param name="userKey">
            /// Identifies the user in the API request. The value can be the user's primary email address, alias email
            /// address, or unique user ID.
            /// </param>
            /// <param name="alias">The alias to be removed.</param>
            public virtual DeleteRequest Delete(string userKey, string alias)
            {
                return new DeleteRequest(service, userKey, alias);
            }

            /// <summary>Removes an alias.</summary>
            public class DeleteRequest : DirectoryBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string userKey, string alias) : base(service)
                {
                    UserKey = userKey;
                    Alias = alias;
                    InitParameters();
                }

                /// <summary>
                /// Identifies the user in the API request. The value can be the user's primary email address, alias
                /// email address, or unique user ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserKey { get; private set; }

                /// <summary>The alias to be removed.</summary>
                [Google.Apis.Util.RequestParameterAttribute("alias", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Alias { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/users/{userKey}/aliases/{alias}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("alias", new Google.Apis.Discovery.Parameter
                    {
                        Name = "alias",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Adds an alias.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="userKey">
            /// Identifies the user in the API request. The value can be the user's primary email address, alias email
            /// address, or unique user ID.
            /// </param>
            public virtual InsertRequest Insert(Google.Apis.Admin.Directory.directory_v1.Data.Alias body, string userKey)
            {
                return new InsertRequest(service, body, userKey);
            }

            /// <summary>Adds an alias.</summary>
            public class InsertRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Alias>
            {
                /// <summary>Constructs a new Insert request.</summary>
                public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Alias body, string userKey) : base(service)
                {
                    UserKey = userKey;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifies the user in the API request. The value can be the user's primary email address, alias
                /// email address, or unique user ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserKey { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Admin.Directory.directory_v1.Data.Alias Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "insert";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/users/{userKey}/aliases";

                /// <summary>Initializes Insert parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists all aliases for a user.</summary>
            /// <param name="userKey">
            /// Identifies the user in the API request. The value can be the user's primary email address, alias email
            /// address, or unique user ID.
            /// </param>
            public virtual ListRequest List(string userKey)
            {
                return new ListRequest(service, userKey);
            }

            /// <summary>Lists all aliases for a user.</summary>
            public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Aliases>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string userKey) : base(service)
                {
                    UserKey = userKey;
                    InitParameters();
                }

                /// <summary>
                /// Identifies the user in the API request. The value can be the user's primary email address, alias
                /// email address, or unique user ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserKey { get; private set; }

                /// <summary>Events to watch for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("event", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<EventEnum> Event { get; set; }

                /// <summary>Events to watch for.</summary>
                public enum EventEnum
                {
                    /// <summary>Alias Created Event</summary>
                    [Google.Apis.Util.StringValueAttribute("add")]
                    Add = 0,

                    /// <summary>Alias Deleted Event</summary>
                    [Google.Apis.Util.StringValueAttribute("delete")]
                    Delete = 1,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/users/{userKey}/aliases";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("event", new Google.Apis.Discovery.Parameter
                    {
                        Name = "event",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Watch for changes in users list.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="userKey">Email or immutable ID of the user</param>
            public virtual WatchRequest Watch(Google.Apis.Admin.Directory.directory_v1.Data.Channel body, string userKey)
            {
                return new WatchRequest(service, body, userKey);
            }

            /// <summary>Watch for changes in users list.</summary>
            public class WatchRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Channel>
            {
                /// <summary>Constructs a new Watch request.</summary>
                public WatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Channel body, string userKey) : base(service)
                {
                    UserKey = userKey;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Email or immutable ID of the user</summary>
                [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserKey { get; private set; }

                /// <summary>Events to watch for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("event", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<EventEnum> Event { get; set; }

                /// <summary>Events to watch for.</summary>
                public enum EventEnum
                {
                    /// <summary>Alias Created Event</summary>
                    [Google.Apis.Util.StringValueAttribute("add")]
                    Add = 0,

                    /// <summary>Alias Deleted Event</summary>
                    [Google.Apis.Util.StringValueAttribute("delete")]
                    Delete = 1,
                }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Admin.Directory.directory_v1.Data.Channel Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "watch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/users/{userKey}/aliases/watch";

                /// <summary>Initializes Watch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("event", new Google.Apis.Discovery.Parameter
                    {
                        Name = "event",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Photos resource.</summary>
        public virtual PhotosResource Photos { get; }

        /// <summary>The "photos" collection of methods.</summary>
        public class PhotosResource
        {
            private const string Resource = "photos";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public PhotosResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Removes the user's photo.</summary>
            /// <param name="userKey">
            /// Identifies the user in the API request. The value can be the user's primary email address, alias email
            /// address, or unique user ID.
            /// </param>
            public virtual DeleteRequest Delete(string userKey)
            {
                return new DeleteRequest(service, userKey);
            }

            /// <summary>Removes the user's photo.</summary>
            public class DeleteRequest : DirectoryBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string userKey) : base(service)
                {
                    UserKey = userKey;
                    InitParameters();
                }

                /// <summary>
                /// Identifies the user in the API request. The value can be the user's primary email address, alias
                /// email address, or unique user ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserKey { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/users/{userKey}/photos/thumbnail";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Retrieves the user's photo.</summary>
            /// <param name="userKey">
            /// Identifies the user in the API request. The value can be the user's primary email address, alias email
            /// address, or unique user ID.
            /// </param>
            public virtual GetRequest Get(string userKey)
            {
                return new GetRequest(service, userKey);
            }

            /// <summary>Retrieves the user's photo.</summary>
            public class GetRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.UserPhoto>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string userKey) : base(service)
                {
                    UserKey = userKey;
                    InitParameters();
                }

                /// <summary>
                /// Identifies the user in the API request. The value can be the user's primary email address, alias
                /// email address, or unique user ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserKey { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/users/{userKey}/photos/thumbnail";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Adds a photo for the user. This method supports [patch
            /// semantics](/admin-sdk/directory/v1/guides/performance#patch).
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="userKey">
            /// Identifies the user in the API request. The value can be the user's primary email address, alias email
            /// address, or unique user ID.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.Admin.Directory.directory_v1.Data.UserPhoto body, string userKey)
            {
                return new PatchRequest(service, body, userKey);
            }

            /// <summary>
            /// Adds a photo for the user. This method supports [patch
            /// semantics](/admin-sdk/directory/v1/guides/performance#patch).
            /// </summary>
            public class PatchRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.UserPhoto>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.UserPhoto body, string userKey) : base(service)
                {
                    UserKey = userKey;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifies the user in the API request. The value can be the user's primary email address, alias
                /// email address, or unique user ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserKey { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Admin.Directory.directory_v1.Data.UserPhoto Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/users/{userKey}/photos/thumbnail";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Adds a photo for the user.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="userKey">
            /// Identifies the user in the API request. The value can be the user's primary email address, alias email
            /// address, or unique user ID.
            /// </param>
            public virtual UpdateRequest Update(Google.Apis.Admin.Directory.directory_v1.Data.UserPhoto body, string userKey)
            {
                return new UpdateRequest(service, body, userKey);
            }

            /// <summary>Adds a photo for the user.</summary>
            public class UpdateRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.UserPhoto>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.UserPhoto body, string userKey) : base(service)
                {
                    UserKey = userKey;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifies the user in the API request. The value can be the user's primary email address, alias
                /// email address, or unique user ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserKey { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Admin.Directory.directory_v1.Data.UserPhoto Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/users/{userKey}/photos/thumbnail";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("userKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Deletes a user.</summary>
        /// <param name="userKey">
        /// Identifies the user in the API request. The value can be the user's primary email address, alias email
        /// address, or unique user ID.
        /// </param>
        public virtual DeleteRequest Delete(string userKey)
        {
            return new DeleteRequest(service, userKey);
        }

        /// <summary>Deletes a user.</summary>
        public class DeleteRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string userKey) : base(service)
            {
                UserKey = userKey;
                InitParameters();
            }

            /// <summary>
            /// Identifies the user in the API request. The value can be the user's primary email address, alias email
            /// address, or unique user ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserKey { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/users/{userKey}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("userKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "userKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves a user.</summary>
        /// <param name="userKey">
        /// Identifies the user in the API request. The value can be the user's primary email address, alias email
        /// address, or unique user ID.
        /// </param>
        public virtual GetRequest Get(string userKey)
        {
            return new GetRequest(service, userKey);
        }

        /// <summary>Retrieves a user.</summary>
        public class GetRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.User>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string userKey) : base(service)
            {
                UserKey = userKey;
                InitParameters();
            }

            /// <summary>
            /// Identifies the user in the API request. The value can be the user's primary email address, alias email
            /// address, or unique user ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserKey { get; private set; }

            /// <summary>
            /// A comma-separated list of schema names. All fields from these schemas are fetched. This should only be
            /// set when `projection=custom`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customFieldMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CustomFieldMask { get; set; }

            /// <summary>What subset of fields to fetch for this user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>What subset of fields to fetch for this user.</summary>
            public enum ProjectionEnum
            {
                /// <summary>Do not include any custom fields for the user.</summary>
                [Google.Apis.Util.StringValueAttribute("basic")]
                Basic = 0,

                /// <summary>Include custom fields from schemas requested in `customFieldMask`.</summary>
                [Google.Apis.Util.StringValueAttribute("custom")]
                Custom = 1,

                /// <summary>Include all fields associated with this user.</summary>
                [Google.Apis.Util.StringValueAttribute("full")]
                Full = 2,
            }

            /// <summary>
            /// Whether to fetch the administrator-only or domain-wide public view of the user. For more information,
            /// see [Retrieve a user as a
            /// non-administrator](/admin-sdk/directory/v1/guides/manage-users#retrieve_users_non_admin).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("viewType", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewTypeEnum> ViewType { get; set; }

            /// <summary>
            /// Whether to fetch the administrator-only or domain-wide public view of the user. For more information,
            /// see [Retrieve a user as a
            /// non-administrator](/admin-sdk/directory/v1/guides/manage-users#retrieve_users_non_admin).
            /// </summary>
            public enum ViewTypeEnum
            {
                /// <summary>Results include both administrator-only and domain-public fields for the user.</summary>
                [Google.Apis.Util.StringValueAttribute("admin_view")]
                AdminView = 0,

                /// <summary>
                /// Results only include fields for the user that are publicly visible to other users in the domain.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("domain_public")]
                DomainPublic = 1,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/users/{userKey}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("userKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "userKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("customFieldMask", new Google.Apis.Discovery.Parameter
                {
                    Name = "customFieldMask",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("projection", new Google.Apis.Discovery.Parameter
                {
                    Name = "projection",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "basic",
                    Pattern = null,
                });
                RequestParameters.Add("viewType", new Google.Apis.Discovery.Parameter
                {
                    Name = "viewType",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "admin_view",
                    Pattern = null,
                });
            }
        }

        /// <summary>Creates a user.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual InsertRequest Insert(Google.Apis.Admin.Directory.directory_v1.Data.User body)
        {
            return new InsertRequest(service, body);
        }

        /// <summary>Creates a user.</summary>
        public class InsertRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.User>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.User body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.User Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/users";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Retrieves a paginated list of either deleted users or all users in a domain.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Retrieves a paginated list of either deleted users or all users in a domain.</summary>
        public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Users>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// A comma-separated list of schema names. All fields from these schemas are fetched. This should only be
            /// set when `projection=custom`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customFieldMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CustomFieldMask { get; set; }

            /// <summary>
            /// The unique ID for the customer's Google Workspace account. In case of a multi-domain account, to fetch
            /// all groups for a customer, fill this field instead of domain. You can also use the `my_customer` alias
            /// to represent your account's `customerId`. The `customerId` is also returned as part of the [Users
            /// resource](/admin-sdk/directory/v1/reference/users). Either the `customer` or the `domain` parameter must
            /// be provided.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Customer { get; set; }

            /// <summary>
            /// The domain name. Use this field to get fields from only one domain. To return all domains for a customer
            /// account, use the `customer` query parameter instead. Either the `customer` or the `domain` parameter
            /// must be provided.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("domain", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Domain { get; set; }

            /// <summary>Event on which subscription is intended (if subscribing)</summary>
            [Google.Apis.Util.RequestParameterAttribute("event", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<EventEnum> Event { get; set; }

            /// <summary>Event on which subscription is intended (if subscribing)</summary>
            public enum EventEnum
            {
                /// <summary>User Created Event</summary>
                [Google.Apis.Util.StringValueAttribute("add")]
                Add = 0,

                /// <summary>User Deleted Event</summary>
                [Google.Apis.Util.StringValueAttribute("delete")]
                Delete = 1,

                /// <summary>User Admin Status Change Event</summary>
                [Google.Apis.Util.StringValueAttribute("makeAdmin")]
                MakeAdmin = 2,

                /// <summary>User Undeleted Event</summary>
                [Google.Apis.Util.StringValueAttribute("undelete")]
                Undelete = 3,

                /// <summary>User Updated Event</summary>
                [Google.Apis.Util.StringValueAttribute("update")]
                Update = 4,
            }

            /// <summary>Maximum number of results to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>Property to use for sorting results.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<OrderByEnum> OrderBy { get; set; }

            /// <summary>Property to use for sorting results.</summary>
            public enum OrderByEnum
            {
                /// <summary>Primary email of the user.</summary>
                [Google.Apis.Util.StringValueAttribute("email")]
                Email = 0,

                /// <summary>User's family name.</summary>
                [Google.Apis.Util.StringValueAttribute("familyName")]
                FamilyName = 1,

                /// <summary>User's given name.</summary>
                [Google.Apis.Util.StringValueAttribute("givenName")]
                GivenName = 2,
            }

            /// <summary>Token to specify next page in the list</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>What subset of fields to fetch for this user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>What subset of fields to fetch for this user.</summary>
            public enum ProjectionEnum
            {
                /// <summary>Do not include any custom fields for the user.</summary>
                [Google.Apis.Util.StringValueAttribute("basic")]
                Basic = 0,

                /// <summary>Include custom fields from schemas requested in `customFieldMask`.</summary>
                [Google.Apis.Util.StringValueAttribute("custom")]
                Custom = 1,

                /// <summary>Include all fields associated with this user.</summary>
                [Google.Apis.Util.StringValueAttribute("full")]
                Full = 2,
            }

            /// <summary>
            /// Query string for searching user fields. For more information on constructing user queries, see [Search
            /// for Users](/admin-sdk/directory/v1/guides/search-users).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query { get; set; }

            /// <summary>If set to `true`, retrieves the list of deleted users. (Default: `false`)</summary>
            [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ShowDeleted { get; set; }

            /// <summary>Whether to return results in ascending or descending order.</summary>
            [Google.Apis.Util.RequestParameterAttribute("sortOrder", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<SortOrderEnum> SortOrder { get; set; }

            /// <summary>Whether to return results in ascending or descending order.</summary>
            public enum SortOrderEnum
            {
                /// <summary>Ascending order.</summary>
                [Google.Apis.Util.StringValueAttribute("ASCENDING")]
                ASCENDING = 0,

                /// <summary>Descending order.</summary>
                [Google.Apis.Util.StringValueAttribute("DESCENDING")]
                DESCENDING = 1,
            }

            /// <summary>
            /// Whether to fetch the administrator-only or domain-wide public view of the user. For more information,
            /// see [Retrieve a user as a
            /// non-administrator](/admin-sdk/directory/v1/guides/manage-users#retrieve_users_non_admin).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("viewType", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewTypeEnum> ViewType { get; set; }

            /// <summary>
            /// Whether to fetch the administrator-only or domain-wide public view of the user. For more information,
            /// see [Retrieve a user as a
            /// non-administrator](/admin-sdk/directory/v1/guides/manage-users#retrieve_users_non_admin).
            /// </summary>
            public enum ViewTypeEnum
            {
                /// <summary>Results include both administrator-only and domain-public fields for the user.</summary>
                [Google.Apis.Util.StringValueAttribute("admin_view")]
                AdminView = 0,

                /// <summary>
                /// Results only include fields for the user that are publicly visible to other users in the domain.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("domain_public")]
                DomainPublic = 1,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/users";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customFieldMask", new Google.Apis.Discovery.Parameter
                {
                    Name = "customFieldMask",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                {
                    Name = "customer",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("domain", new Google.Apis.Discovery.Parameter
                {
                    Name = "domain",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("event", new Google.Apis.Discovery.Parameter
                {
                    Name = "event",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "100",
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
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("projection", new Google.Apis.Discovery.Parameter
                {
                    Name = "projection",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "basic",
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
                RequestParameters.Add("showDeleted", new Google.Apis.Discovery.Parameter
                {
                    Name = "showDeleted",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sortOrder", new Google.Apis.Discovery.Parameter
                {
                    Name = "sortOrder",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("viewType", new Google.Apis.Discovery.Parameter
                {
                    Name = "viewType",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "admin_view",
                    Pattern = null,
                });
            }
        }

        /// <summary>Makes a user a super administrator.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="userKey">
        /// Identifies the user in the API request. The value can be the user's primary email address, alias email
        /// address, or unique user ID.
        /// </param>
        public virtual MakeAdminRequest MakeAdmin(Google.Apis.Admin.Directory.directory_v1.Data.UserMakeAdmin body, string userKey)
        {
            return new MakeAdminRequest(service, body, userKey);
        }

        /// <summary>Makes a user a super administrator.</summary>
        public class MakeAdminRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new MakeAdmin request.</summary>
            public MakeAdminRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.UserMakeAdmin body, string userKey) : base(service)
            {
                UserKey = userKey;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Identifies the user in the API request. The value can be the user's primary email address, alias email
            /// address, or unique user ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserKey { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.UserMakeAdmin Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "makeAdmin";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/users/{userKey}/makeAdmin";

            /// <summary>Initializes MakeAdmin parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("userKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "userKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates a user using patch semantics. The update method should be used instead, since it also supports patch
        /// semantics and has better performance. This method is unable to clear fields that contain repeated objects
        /// (`addresses`, `phones`, etc). Use the update method instead.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="userKey">
        /// Identifies the user in the API request. The value can be the user's primary email address, alias email
        /// address, or unique user ID.
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.Admin.Directory.directory_v1.Data.User body, string userKey)
        {
            return new PatchRequest(service, body, userKey);
        }

        /// <summary>
        /// Updates a user using patch semantics. The update method should be used instead, since it also supports patch
        /// semantics and has better performance. This method is unable to clear fields that contain repeated objects
        /// (`addresses`, `phones`, etc). Use the update method instead.
        /// </summary>
        public class PatchRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.User>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.User body, string userKey) : base(service)
            {
                UserKey = userKey;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Identifies the user in the API request. The value can be the user's primary email address, alias email
            /// address, or unique user ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserKey { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.User Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/users/{userKey}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("userKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "userKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Sign a user out of all web and device sessions and reset their sign-in cookies. User will have to sign in by
        /// authenticating again.
        /// </summary>
        /// <param name="userKey">
        /// Identifies the target user in the API request. The value can be the user's primary email address, alias
        /// email address, or unique user ID.
        /// </param>
        public virtual SignOutRequest SignOut(string userKey)
        {
            return new SignOutRequest(service, userKey);
        }

        /// <summary>
        /// Sign a user out of all web and device sessions and reset their sign-in cookies. User will have to sign in by
        /// authenticating again.
        /// </summary>
        public class SignOutRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new SignOut request.</summary>
            public SignOutRequest(Google.Apis.Services.IClientService service, string userKey) : base(service)
            {
                UserKey = userKey;
                InitParameters();
            }

            /// <summary>
            /// Identifies the target user in the API request. The value can be the user's primary email address, alias
            /// email address, or unique user ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserKey { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "signOut";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/users/{userKey}/signOut";

            /// <summary>Initializes SignOut parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("userKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "userKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Undeletes a deleted user.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="userKey">The immutable id of the user</param>
        public virtual UndeleteRequest Undelete(Google.Apis.Admin.Directory.directory_v1.Data.UserUndelete body, string userKey)
        {
            return new UndeleteRequest(service, body, userKey);
        }

        /// <summary>Undeletes a deleted user.</summary>
        public class UndeleteRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Undelete request.</summary>
            public UndeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.UserUndelete body, string userKey) : base(service)
            {
                UserKey = userKey;
                Body = body;
                InitParameters();
            }

            /// <summary>The immutable id of the user</summary>
            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserKey { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.UserUndelete Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "undelete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/users/{userKey}/undelete";

            /// <summary>Initializes Undelete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("userKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "userKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates a user. This method supports patch semantics, meaning you only need to include the fields you wish
        /// to update. Fields that are not present in the request will be preserved, and fields set to `null` will be
        /// cleared.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="userKey">
        /// Identifies the user in the API request. The value can be the user's primary email address, alias email
        /// address, or unique user ID.
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.Admin.Directory.directory_v1.Data.User body, string userKey)
        {
            return new UpdateRequest(service, body, userKey);
        }

        /// <summary>
        /// Updates a user. This method supports patch semantics, meaning you only need to include the fields you wish
        /// to update. Fields that are not present in the request will be preserved, and fields set to `null` will be
        /// cleared.
        /// </summary>
        public class UpdateRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.User>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.User body, string userKey) : base(service)
            {
                UserKey = userKey;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Identifies the user in the API request. The value can be the user's primary email address, alias email
            /// address, or unique user ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserKey { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.User Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/users/{userKey}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("userKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "userKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Watch for changes in users list</summary>
        /// <param name="body">The body of the request.</param>
        public virtual WatchRequest Watch(Google.Apis.Admin.Directory.directory_v1.Data.Channel body)
        {
            return new WatchRequest(service, body);
        }

        /// <summary>Watch for changes in users list</summary>
        public class WatchRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Channel>
        {
            /// <summary>Constructs a new Watch request.</summary>
            public WatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Channel body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Comma-separated list of schema names. All fields from these schemas are fetched. This should only be set
            /// when projection=custom.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customFieldMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CustomFieldMask { get; set; }

            /// <summary>
            /// Immutable ID of the Google Workspace account. In case of multi-domain, to fetch all users for a
            /// customer, fill this field instead of domain.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Customer { get; set; }

            /// <summary>
            /// Name of the domain. Fill this field to get users from only this domain. To return all users in a
            /// multi-domain fill customer field instead."
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("domain", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Domain { get; set; }

            /// <summary>Events to watch for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("event", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<EventEnum> Event { get; set; }

            /// <summary>Events to watch for.</summary>
            public enum EventEnum
            {
                /// <summary>User Created Event</summary>
                [Google.Apis.Util.StringValueAttribute("add")]
                Add = 0,

                /// <summary>User Deleted Event</summary>
                [Google.Apis.Util.StringValueAttribute("delete")]
                Delete = 1,

                /// <summary>User Admin Status Change Event</summary>
                [Google.Apis.Util.StringValueAttribute("makeAdmin")]
                MakeAdmin = 2,

                /// <summary>User Undeleted Event</summary>
                [Google.Apis.Util.StringValueAttribute("undelete")]
                Undelete = 3,

                /// <summary>User Updated Event</summary>
                [Google.Apis.Util.StringValueAttribute("update")]
                Update = 4,
            }

            /// <summary>Maximum number of results to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>Column to use for sorting results</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<OrderByEnum> OrderBy { get; set; }

            /// <summary>Column to use for sorting results</summary>
            public enum OrderByEnum
            {
                /// <summary>Primary email of the user.</summary>
                [Google.Apis.Util.StringValueAttribute("email")]
                Email = 0,

                /// <summary>User's family name.</summary>
                [Google.Apis.Util.StringValueAttribute("familyName")]
                FamilyName = 1,

                /// <summary>User's given name.</summary>
                [Google.Apis.Util.StringValueAttribute("givenName")]
                GivenName = 2,
            }

            /// <summary>Token to specify next page in the list</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>What subset of fields to fetch for this user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>What subset of fields to fetch for this user.</summary>
            public enum ProjectionEnum
            {
                /// <summary>Do not include any custom fields for the user.</summary>
                [Google.Apis.Util.StringValueAttribute("basic")]
                Basic = 0,

                /// <summary>Include custom fields from schemas mentioned in customFieldMask.</summary>
                [Google.Apis.Util.StringValueAttribute("custom")]
                Custom = 1,

                /// <summary>Include all fields associated with this user.</summary>
                [Google.Apis.Util.StringValueAttribute("full")]
                Full = 2,
            }

            /// <summary>
            /// Query string search. Should be of the form "". Complete documentation is at https:
            /// //developers.google.com/admin-sdk/directory/v1/guides/search-users
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query { get; set; }

            /// <summary>If set to true, retrieves the list of deleted users. (Default: false)</summary>
            [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ShowDeleted { get; set; }

            /// <summary>Whether to return results in ascending or descending order.</summary>
            [Google.Apis.Util.RequestParameterAttribute("sortOrder", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<SortOrderEnum> SortOrder { get; set; }

            /// <summary>Whether to return results in ascending or descending order.</summary>
            public enum SortOrderEnum
            {
                /// <summary>Ascending order.</summary>
                [Google.Apis.Util.StringValueAttribute("ASCENDING")]
                ASCENDING = 0,

                /// <summary>Descending order.</summary>
                [Google.Apis.Util.StringValueAttribute("DESCENDING")]
                DESCENDING = 1,
            }

            /// <summary>
            /// Whether to fetch the administrator-only or domain-wide public view of the user. For more information,
            /// see [Retrieve a user as a
            /// non-administrator](/admin-sdk/directory/v1/guides/manage-users#retrieve_users_non_admin).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("viewType", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewTypeEnum> ViewType { get; set; }

            /// <summary>
            /// Whether to fetch the administrator-only or domain-wide public view of the user. For more information,
            /// see [Retrieve a user as a
            /// non-administrator](/admin-sdk/directory/v1/guides/manage-users#retrieve_users_non_admin).
            /// </summary>
            public enum ViewTypeEnum
            {
                /// <summary>Results include both administrator-only and domain-public fields.</summary>
                [Google.Apis.Util.StringValueAttribute("admin_view")]
                AdminView = 0,

                /// <summary>
                /// Results only include fields for the user that are publicly visible to other users in the domain.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("domain_public")]
                DomainPublic = 1,
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.Channel Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "watch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/users/watch";

            /// <summary>Initializes Watch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customFieldMask", new Google.Apis.Discovery.Parameter
                {
                    Name = "customFieldMask",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                {
                    Name = "customer",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("domain", new Google.Apis.Discovery.Parameter
                {
                    Name = "domain",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("event", new Google.Apis.Discovery.Parameter
                {
                    Name = "event",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "100",
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
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("projection", new Google.Apis.Discovery.Parameter
                {
                    Name = "projection",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "basic",
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
                RequestParameters.Add("showDeleted", new Google.Apis.Discovery.Parameter
                {
                    Name = "showDeleted",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sortOrder", new Google.Apis.Discovery.Parameter
                {
                    Name = "sortOrder",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("viewType", new Google.Apis.Discovery.Parameter
                {
                    Name = "viewType",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "admin_view",
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "verificationCodes" collection of methods.</summary>
    public class VerificationCodesResource
    {
        private const string Resource = "verificationCodes";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public VerificationCodesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Generate new backup verification codes for the user.</summary>
        /// <param name="userKey">Email or immutable ID of the user</param>
        public virtual GenerateRequest Generate(string userKey)
        {
            return new GenerateRequest(service, userKey);
        }

        /// <summary>Generate new backup verification codes for the user.</summary>
        public class GenerateRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Generate request.</summary>
            public GenerateRequest(Google.Apis.Services.IClientService service, string userKey) : base(service)
            {
                UserKey = userKey;
                InitParameters();
            }

            /// <summary>Email or immutable ID of the user</summary>
            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserKey { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "generate";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/users/{userKey}/verificationCodes/generate";

            /// <summary>Initializes Generate parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("userKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "userKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Invalidate the current backup verification codes for the user.</summary>
        /// <param name="userKey">Email or immutable ID of the user</param>
        public virtual InvalidateRequest Invalidate(string userKey)
        {
            return new InvalidateRequest(service, userKey);
        }

        /// <summary>Invalidate the current backup verification codes for the user.</summary>
        public class InvalidateRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Invalidate request.</summary>
            public InvalidateRequest(Google.Apis.Services.IClientService service, string userKey) : base(service)
            {
                UserKey = userKey;
                InitParameters();
            }

            /// <summary>Email or immutable ID of the user</summary>
            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserKey { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "invalidate";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/users/{userKey}/verificationCodes/invalidate";

            /// <summary>Initializes Invalidate parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("userKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "userKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Returns the current set of valid backup verification codes for the specified user.</summary>
        /// <param name="userKey">
        /// Identifies the user in the API request. The value can be the user's primary email address, alias email
        /// address, or unique user ID.
        /// </param>
        public virtual ListRequest List(string userKey)
        {
            return new ListRequest(service, userKey);
        }

        /// <summary>Returns the current set of valid backup verification codes for the specified user.</summary>
        public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.VerificationCodes>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string userKey) : base(service)
            {
                UserKey = userKey;
                InitParameters();
            }

            /// <summary>
            /// Identifies the user in the API request. The value can be the user's primary email address, alias email
            /// address, or unique user ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserKey { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/users/{userKey}/verificationCodes";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("userKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "userKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.Admin.Directory.directory_v1.Data
{
    /// <summary>JSON template for Alias object in Directory API.</summary>
    public class Alias : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("alias")]
        public virtual string AliasValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("primaryEmail")]
        public virtual string PrimaryEmail { get; set; }
    }

    /// <summary>JSON response template to list aliases in Directory API.</summary>
    public class Aliases : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("aliases")]
        public virtual System.Collections.Generic.IList<Alias> AliasesValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }
    }

    /// <summary>
    /// An application-specific password (ASP) is used with applications that do not accept a verification code when
    /// logging into the application on certain devices. The ASP access code is used instead of the login and password
    /// you commonly use when accessing an application through a browser. For more information about ASPs and how to
    /// create one, see the [help center](https://support.google.com/a/answer/2537800#asp).
    /// </summary>
    public class Asp : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The unique ID of the ASP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("codeId")]
        public virtual System.Nullable<int> CodeId { get; set; }

        /// <summary>
        /// The time when the ASP was created. Expressed in [Unix time](https://en.wikipedia.org/wiki/Epoch_time)
        /// format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual System.Nullable<long> CreationTime { get; set; }

        /// <summary>ETag of the ASP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The type of the API resource. This is always `admin#directory#asp`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The time when the ASP was last used. Expressed in [Unix time](https://en.wikipedia.org/wiki/Epoch_time)
        /// format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastTimeUsed")]
        public virtual System.Nullable<long> LastTimeUsed { get; set; }

        /// <summary>
        /// The name of the application that the user, represented by their `userId`, entered when the ASP was created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The unique ID of the user who issued the ASP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userKey")]
        public virtual string UserKey { get; set; }
    }

    public class Asps : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>A list of ASP resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Asp> Items { get; set; }

        /// <summary>The type of the API resource. This is always `admin#directory#aspList`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }
    }

    /// <summary>
    /// Auxiliary message about issues with printers or settings. Example: {message_type:AUXILIARY_MESSAGE_WARNING,
    /// field_mask:make_and_model, message:"Given printer is invalid or no longer supported."}
    /// </summary>
    public class AuxiliaryMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Human readable message in English. Example: "Given printer is invalid or no longer supported."
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auxiliaryMessage")]
        public virtual string AuxiliaryMessageValue { get; set; }

        /// <summary>Field that this message concerns.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldMask")]
        public virtual object FieldMask { get; set; }

        /// <summary>Message severity</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for adding new printers in batch.</summary>
    public class BatchCreatePrintersRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of Printers to be created. Max 50 at a time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<CreatePrinterRequest> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for adding new printers in batch.</summary>
    public class BatchCreatePrintersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of create failures. Printer IDs are not populated, as printer were not created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failures")]
        public virtual System.Collections.Generic.IList<FailureInfo> Failures { get; set; }

        /// <summary>A list of successfully created printers with their IDs populated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("printers")]
        public virtual System.Collections.Generic.IList<Printer> Printers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for deleting existing printers in batch.</summary>
    public class BatchDeletePrintersRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of Printer.id that should be deleted. Max 100 at a time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("printerIds")]
        public virtual System.Collections.Generic.IList<string> PrinterIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for deleting existing printers in batch.</summary>
    public class BatchDeletePrintersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of update failures.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failedPrinters")]
        public virtual System.Collections.Generic.IList<FailureInfo> FailedPrinters { get; set; }

        /// <summary>A list of Printer.id that were successfully deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("printerIds")]
        public virtual System.Collections.Generic.IList<string> PrinterIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Public API: Resources.buildings</summary>
    public class Building : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The postal address of the building. See [`PostalAddress`](/my-business/reference/rest/v4/PostalAddress) for
        /// details. Note that only a single address line and region code are required.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual BuildingAddress Address { get; set; }

        /// <summary>Unique identifier for the building. The maximum length is 100 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildingId")]
        public virtual string BuildingId { get; set; }

        /// <summary>
        /// The building name as seen by users in Calendar. Must be unique for the customer. For example, "NYC-CHEL".
        /// The maximum length is 100 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildingName")]
        public virtual string BuildingName { get; set; }

        /// <summary>
        /// The geographic coordinates of the center of the building, expressed as latitude and longitude in decimal
        /// degrees.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("coordinates")]
        public virtual BuildingCoordinates Coordinates { get; set; }

        /// <summary>A brief description of the building. For example, "Chelsea Market".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etags")]
        public virtual string Etags { get; set; }

        /// <summary>
        /// The display names for all floors in this building. The floors are expected to be sorted in ascending order,
        /// from lowest floor to highest floor. For example, ["B2", "B1", "L", "1", "2", "2M", "3", "PH"] Must contain
        /// at least one entry.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floorNames")]
        public virtual System.Collections.Generic.IList<string> FloorNames { get; set; }

        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Public API: Resources.buildings</summary>
    public class BuildingAddress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Unstructured address lines describing the lower levels of an address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addressLines")]
        public virtual System.Collections.Generic.IList<string> AddressLines { get; set; }

        /// <summary>
        /// Optional. Highest administrative subdivision which is used for postal addresses of a country or region.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("administrativeArea")]
        public virtual string AdministrativeArea { get; set; }

        /// <summary>Optional. BCP-47 language code of the contents of this address (if known).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// Optional. Generally refers to the city/town portion of the address. Examples: US city, IT comune, UK post
        /// town. In regions of the world where localities are not well defined or do not fit into this structure well,
        /// leave locality empty and use addressLines.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locality")]
        public virtual string Locality { get; set; }

        /// <summary>Optional. Postal code of the address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCode")]
        public virtual string PostalCode { get; set; }

        /// <summary>Required. CLDR region code of the country/region of the address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>Optional. Sublocality of the address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sublocality")]
        public virtual string Sublocality { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Public API: Resources.buildings</summary>
    public class BuildingCoordinates : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Latitude in decimal degrees.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latitude")]
        public virtual System.Nullable<double> Latitude { get; set; }

        /// <summary>Longitude in decimal degrees.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longitude")]
        public virtual System.Nullable<double> Longitude { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Public API: Resources.buildings</summary>
    public class Buildings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Buildings in this page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildings")]
        public virtual System.Collections.Generic.IList<Building> BuildingsValue { get; set; }

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The continuation token, used to page through large result sets. Provide this value in a subsequent request
        /// to return the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }
    }

    /// <summary>Public API: Resources.calendars</summary>
    public class CalendarResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Unique ID for the building a resource is located in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildingId")]
        public virtual string BuildingId { get; set; }

        /// <summary>Capacity of a resource, number of seats in a room.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("capacity")]
        public virtual System.Nullable<int> Capacity { get; set; }

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etags")]
        public virtual string Etags { get; set; }

        /// <summary>Instances of features for the calendar resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("featureInstances")]
        public virtual object FeatureInstances { get; set; }

        /// <summary>Name of the floor a resource is located on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floorName")]
        public virtual string FloorName { get; set; }

        /// <summary>Name of the section within a floor a resource is located in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floorSection")]
        public virtual string FloorSection { get; set; }

        /// <summary>
        /// The read-only auto-generated name of the calendar resource which includes metadata about the resource such
        /// as building name, floor, capacity, etc. For example, "NYC-2-Training Room 1A (16)".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generatedResourceName")]
        public virtual string GeneratedResourceName { get; set; }

        /// <summary>
        /// The type of the resource. For calendar resources, the value is
        /// `admin#directory#resources#calendars#CalendarResource`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The category of the calendar resource. Either CONFERENCE_ROOM or OTHER. Legacy data is set to
        /// CATEGORY_UNKNOWN.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceCategory")]
        public virtual string ResourceCategory { get; set; }

        /// <summary>Description of the resource, visible only to admins.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceDescription")]
        public virtual string ResourceDescription { get; set; }

        /// <summary>
        /// The read-only email for the calendar resource. Generated as part of creating a new calendar resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceEmail")]
        public virtual string ResourceEmail { get; set; }

        /// <summary>The unique ID for the calendar resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual string ResourceId { get; set; }

        /// <summary>The name of the calendar resource. For example, "Training Room 1A".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The type of the calendar resource, intended for non-room resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>Description of the resource, visible to users and admins.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userVisibleDescription")]
        public virtual string UserVisibleDescription { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Public API: Resources.calendars</summary>
    public class CalendarResources : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The CalendarResources in this page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<CalendarResource> Items { get; set; }

        /// <summary>
        /// Identifies this as a collection of CalendarResources. This is always
        /// `admin#directory#resources#calendars#calendarResourcesList`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The continuation token, used to page through large result sets. Provide this value in a subsequent request
        /// to return the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }
    }

    /// <summary>An notification channel used to watch for resource changes.</summary>
    public class Channel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The address where notifications are delivered for this channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual string Address { get; set; }

        /// <summary>
        /// Date and time of notification channel expiration, expressed as a Unix timestamp, in milliseconds. Optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expiration")]
        public virtual System.Nullable<long> Expiration { get; set; }

        /// <summary>A UUID or similar unique string that identifies this channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Identifies this as a notification channel used to watch for changes to a resource, which is `api#channel`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Additional parameters controlling delivery channel behavior. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("params")]
        public virtual System.Collections.Generic.IDictionary<string, string> Params__ { get; set; }

        /// <summary>A Boolean value to indicate whether payload is wanted. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payload")]
        public virtual System.Nullable<bool> Payload { get; set; }

        /// <summary>
        /// An opaque ID that identifies the resource being watched on this channel. Stable across different API
        /// versions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual string ResourceId { get; set; }

        /// <summary>A version-specific identifier for the watched resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUri")]
        public virtual string ResourceUri { get; set; }

        /// <summary>
        /// An arbitrary string delivered to the target address with each notification delivered over this channel.
        /// Optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>The type of delivery mechanism used for this channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Google Chrome devices run on the [Chrome OS](https://support.google.com/chromeos). For more information about
    /// common API tasks, see the [Developer's Guide](/admin-sdk/directory/v1/guides/manage-chrome-devices).
    /// </summary>
    public class ChromeOsDevice : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of active time ranges (Read-only).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeTimeRanges")]
        public virtual System.Collections.Generic.IList<ActiveTimeRangesData> ActiveTimeRanges { get; set; }

        /// <summary>The asset identifier as noted by an administrator or specified during enrollment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotatedAssetId")]
        public virtual string AnnotatedAssetId { get; set; }

        /// <summary>
        /// The address or location of the device as noted by the administrator. Maximum length is `200` characters.
        /// Empty values are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotatedLocation")]
        public virtual string AnnotatedLocation { get; set; }

        /// <summary>
        /// The user of the device as noted by the administrator. Maximum length is 100 characters. Empty values are
        /// allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotatedUser")]
        public virtual string AnnotatedUser { get; set; }

        /// <summary>
        /// (Read-only) The timestamp after which the device will stop receiving Chrome updates or support
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoUpdateExpiration")]
        public virtual System.Nullable<long> AutoUpdateExpiration { get; set; }

        /// <summary>
        /// The boot mode for the device. The possible values are: * `Verified`: The device is running a valid version
        /// of the Chrome OS. * `Dev`: The devices's developer hardware switch is enabled. When booted, the device has a
        /// command line shell. For an example of a developer switch, see the [Chromebook developer
        /// information](https://www.chromium.org/chromium-os/developer-information-for-chrome-os-devices/samsung-series-5-chromebook#TOC-Developer-switch).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootMode")]
        public virtual string BootMode { get; set; }

        /// <summary>Reports of CPU utilization and temperature (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuStatusReports")]
        public virtual System.Collections.Generic.IList<CpuStatusReportsData> CpuStatusReports { get; set; }

        /// <summary>List of device files to download (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceFiles")]
        public virtual System.Collections.Generic.IList<DeviceFilesData> DeviceFiles { get; set; }

        /// <summary>The unique ID of the Chrome device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceId")]
        public virtual string DeviceId { get; set; }

        /// <summary>Reports of disk space and other info about mounted/connected volumes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskVolumeReports")]
        public virtual System.Collections.Generic.IList<DiskVolumeReportsData> DiskVolumeReports { get; set; }

        /// <summary>
        /// (Read-only) Built-in MAC address for the docking station that the device connected to. Factory sets Media
        /// access control address (MAC address) assigned for use by a dock. It is reserved specifically for MAC pass
        /// through device policy. The format is twelve (12) hexadecimal digits without any delimiter (uppercase
        /// letters). This is only relevant for some devices.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dockMacAddress")]
        public virtual string DockMacAddress { get; set; }

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The device's MAC address on the ethernet network interface.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ethernetMacAddress")]
        public virtual string EthernetMacAddress { get; set; }

        /// <summary>
        /// (Read-only) MAC address used by the Chromebook’s internal ethernet port, and for onboard network (ethernet)
        /// interface. The format is twelve (12) hexadecimal digits without any delimiter (uppercase letters). This is
        /// only relevant for some devices.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ethernetMacAddress0")]
        public virtual string EthernetMacAddress0 { get; set; }

        /// <summary>The Chrome device's firmware version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firmwareVersion")]
        public virtual string FirmwareVersion { get; set; }

        /// <summary>
        /// The type of resource. For the Chromeosdevices resource, the value is `admin#directory#chromeosdevice`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Date and time the device was last enrolled (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastEnrollmentTime")]
        public virtual string LastEnrollmentTimeRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="LastEnrollmentTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> LastEnrollmentTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(LastEnrollmentTimeRaw);
            set => LastEnrollmentTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>Contains last known network (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastKnownNetwork")]
        public virtual System.Collections.Generic.IList<LastKnownNetworkData> LastKnownNetwork { get; set; }

        /// <summary>
        /// Date and time the device was last synchronized with the policy settings in the G Suite administrator control
        /// panel (Read-only)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastSync")]
        public virtual string LastSyncRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="LastSyncRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> LastSync
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(LastSyncRaw);
            set => LastSyncRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// The device's wireless MAC address. If the device does not have this information, it is not included in the
        /// response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("macAddress")]
        public virtual string MacAddress { get; set; }

        /// <summary>(Read-only) The date the device was manufactured in yyyy-mm-dd format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manufactureDate")]
        public virtual string ManufactureDate { get; set; }

        /// <summary>
        /// The Mobile Equipment Identifier (MEID) or the International Mobile Equipment Identity (IMEI) for the 3G
        /// mobile card in a mobile device. A MEID/IMEI is typically used when adding a device to a wireless carrier's
        /// post-pay service plan. If the device does not have this information, this property is not included in the
        /// response. For more information on how to export a MEID/IMEI list, see the [Developer's
        /// Guide](/admin-sdk/directory/v1/guides/manage-chrome-devices.html#export_meid).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meid")]
        public virtual string Meid { get; set; }

        /// <summary>
        /// The device's model information. If the device does not have this information, this property is not included
        /// in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; }

        /// <summary>
        /// Notes about this device added by the administrator. This property can be
        /// [searched](https://support.google.com/chrome/a/answer/1698333) with the
        /// [list](/admin-sdk/directory/v1/reference/chromeosdevices/list) method's `query` parameter. Maximum length is
        /// 500 characters. Empty values are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notes")]
        public virtual string Notes { get; set; }

        /// <summary>
        /// The device's order number. Only devices directly purchased from Google have an order number.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderNumber")]
        public virtual string OrderNumber { get; set; }

        /// <summary>
        /// The full parent path with the organizational unit's name associated with the device. Path names are case
        /// insensitive. If the parent organizational unit is the top-level organization, it is represented as a forward
        /// slash, `/`. This property can be
        /// [updated](/admin-sdk/directory/v1/guides/manage-chrome-devices#update_chrome_device) using the API. For more
        /// information about how to create an organizational structure for your device, see the [administration help
        /// center](https://support.google.com/a/answer/182433).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgUnitPath")]
        public virtual string OrgUnitPath { get; set; }

        /// <summary>The Chrome device's operating system version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osVersion")]
        public virtual string OsVersion { get; set; }

        /// <summary>The Chrome device's platform version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platformVersion")]
        public virtual string PlatformVersion { get; set; }

        /// <summary>List of recent device users, in descending order, by last login time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recentUsers")]
        public virtual System.Collections.Generic.IList<RecentUsersData> RecentUsers { get; set; }

        /// <summary>List of screenshot files to download. Type is always "SCREENSHOT_FILE". (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenshotFiles")]
        public virtual System.Collections.Generic.IList<ScreenshotFilesData> ScreenshotFiles { get; set; }

        /// <summary>
        /// The Chrome device serial number entered when the device was enabled. This value is the same as the Admin
        /// console's *Serial Number* in the *Chrome OS Devices* tab.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serialNumber")]
        public virtual string SerialNumber { get; set; }

        /// <summary>The status of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>Final date the device will be supported (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportEndDate")]
        public virtual string SupportEndDateRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="SupportEndDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> SupportEndDate
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(SupportEndDateRaw);
            set => SupportEndDateRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>Reports of amounts of available RAM memory (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemRamFreeReports")]
        public virtual System.Collections.Generic.IList<SystemRamFreeReportsData> SystemRamFreeReports { get; set; }

        /// <summary>Total RAM on the device [in bytes] (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemRamTotal")]
        public virtual System.Nullable<long> SystemRamTotal { get; set; }

        /// <summary>Trusted Platform Module (TPM) (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tpmVersionInfo")]
        public virtual TpmVersionInfoData TpmVersionInfo { get; set; }

        /// <summary>
        /// Determines if the device will auto renew its support after the support end date. This is a read-only
        /// property.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("willAutoRenew")]
        public virtual System.Nullable<bool> WillAutoRenew { get; set; }

        /// <summary>List of active time ranges (Read-only).</summary>
        public class ActiveTimeRangesData
        {
            /// <summary>Duration of usage in milliseconds.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("activeTime")]
            public virtual System.Nullable<int> ActiveTime { get; set; }

            /// <summary>Date of usage</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("date")]
            public virtual string Date { get; set; }
        }

        /// <summary>Reports of CPU utilization and temperature (Read-only)</summary>
        public class CpuStatusReportsData
        {
            /// <summary>List of CPU temperature samples.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("cpuTemperatureInfo")]
            public virtual System.Collections.Generic.IList<CpuTemperatureInfoData> CpuTemperatureInfo { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("cpuUtilizationPercentageInfo")]
            public virtual System.Collections.Generic.IList<System.Nullable<int>> CpuUtilizationPercentageInfo { get; set; }

            /// <summary>Date and time the report was received.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("reportTime")]
            public virtual string ReportTimeRaw { get; set; }

            /// <summary><seealso cref="System.DateTime"/> representation of <see cref="ReportTimeRaw"/>.</summary>
            [Newtonsoft.Json.JsonIgnoreAttribute]
            public virtual System.Nullable<System.DateTime> ReportTime
            {
                get => Google.Apis.Util.Utilities.GetDateTimeFromString(ReportTimeRaw);
                set => ReportTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
            }

            /// <summary>List of CPU temperature samples.</summary>
            public class CpuTemperatureInfoData
            {
                /// <summary>CPU label</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("label")]
                public virtual string Label { get; set; }

                /// <summary>Temperature in Celsius degrees.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("temperature")]
                public virtual System.Nullable<int> Temperature { get; set; }
            }
        }

        /// <summary>List of device files to download (Read-only)</summary>
        public class DeviceFilesData
        {
            /// <summary>Date and time the file was created</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
            public virtual string CreateTimeRaw { get; set; }

            /// <summary><seealso cref="System.DateTime"/> representation of <see cref="CreateTimeRaw"/>.</summary>
            [Newtonsoft.Json.JsonIgnoreAttribute]
            public virtual System.Nullable<System.DateTime> CreateTime
            {
                get => Google.Apis.Util.Utilities.GetDateTimeFromString(CreateTimeRaw);
                set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
            }

            /// <summary>File download URL</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("downloadUrl")]
            public virtual string DownloadUrl { get; set; }

            /// <summary>File name</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("name")]
            public virtual string Name { get; set; }

            /// <summary>File type</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type { get; set; }
        }

        /// <summary>Reports of disk space and other info about mounted/connected volumes.</summary>
        public class DiskVolumeReportsData
        {
            /// <summary>Disk volumes</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("volumeInfo")]
            public virtual System.Collections.Generic.IList<VolumeInfoData> VolumeInfo { get; set; }

            /// <summary>Disk volumes</summary>
            public class VolumeInfoData
            {
                /// <summary>Free disk space [in bytes]</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("storageFree")]
                public virtual System.Nullable<long> StorageFree { get; set; }

                /// <summary>Total disk space [in bytes]</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("storageTotal")]
                public virtual System.Nullable<long> StorageTotal { get; set; }

                /// <summary>Volume id</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("volumeId")]
                public virtual string VolumeId { get; set; }
            }
        }

        /// <summary>Contains last known network (Read-only)</summary>
        public class LastKnownNetworkData
        {
            /// <summary>The IP address.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
            public virtual string IpAddress { get; set; }

            /// <summary>The WAN IP address.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("wanIpAddress")]
            public virtual string WanIpAddress { get; set; }
        }

        /// <summary>List of recent device users, in descending order, by last login time.</summary>
        public class RecentUsersData
        {
            /// <summary>
            /// The user's email address. This is only present if the user type is `USER_TYPE_MANAGED`.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("email")]
            public virtual string Email { get; set; }

            /// <summary>The type of the user.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type { get; set; }
        }

        /// <summary>List of screenshot files to download. Type is always "SCREENSHOT_FILE". (Read-only)</summary>
        public class ScreenshotFilesData
        {
            /// <summary>Date and time the file was created</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
            public virtual string CreateTimeRaw { get; set; }

            /// <summary><seealso cref="System.DateTime"/> representation of <see cref="CreateTimeRaw"/>.</summary>
            [Newtonsoft.Json.JsonIgnoreAttribute]
            public virtual System.Nullable<System.DateTime> CreateTime
            {
                get => Google.Apis.Util.Utilities.GetDateTimeFromString(CreateTimeRaw);
                set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
            }

            /// <summary>File download URL</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("downloadUrl")]
            public virtual string DownloadUrl { get; set; }

            /// <summary>File name</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("name")]
            public virtual string Name { get; set; }

            /// <summary>File type</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type { get; set; }
        }

        /// <summary>Reports of amounts of available RAM memory (Read-only)</summary>
        public class SystemRamFreeReportsData
        {
            /// <summary>Date and time the report was received.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("reportTime")]
            public virtual string ReportTimeRaw { get; set; }

            /// <summary><seealso cref="System.DateTime"/> representation of <see cref="ReportTimeRaw"/>.</summary>
            [Newtonsoft.Json.JsonIgnoreAttribute]
            public virtual System.Nullable<System.DateTime> ReportTime
            {
                get => Google.Apis.Util.Utilities.GetDateTimeFromString(ReportTimeRaw);
                set => ReportTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
            }

            [Newtonsoft.Json.JsonPropertyAttribute("systemRamFreeInfo")]
            public virtual System.Collections.Generic.IList<System.Nullable<long>> SystemRamFreeInfo { get; set; }
        }

        /// <summary>Trusted Platform Module (TPM) (Read-only)</summary>
        public class TpmVersionInfoData
        {
            /// <summary>
            /// TPM family. We use the TPM 2.0 style encoding, e.g.: TPM 1.2: "1.2" -&amp;gt; 312e3200 TPM 2.0: "2.0"
            /// -&amp;gt; 322e3000
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("family")]
            public virtual string Family { get; set; }

            /// <summary>TPM firmware version.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("firmwareVersion")]
            public virtual string FirmwareVersion { get; set; }

            /// <summary>TPM manufacturer code.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("manufacturer")]
            public virtual string Manufacturer { get; set; }

            /// <summary>
            /// TPM specification level. See Library Specification for TPM 2.0 and Main Specification for TPM 1.2.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("specLevel")]
            public virtual string SpecLevel { get; set; }

            /// <summary>TPM model number.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("tpmModel")]
            public virtual string TpmModel { get; set; }

            /// <summary>Vendor-specific information such as Vendor ID.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("vendorSpecific")]
            public virtual string VendorSpecific { get; set; }
        }
    }

    public class ChromeOsDeviceAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Action to be taken on the Chrome OS device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        /// <summary>
        /// Only used when the action is `deprovision`. With the `deprovision` action, this field is required. *Note*:
        /// The deprovision reason is audited because it might have implications on licenses for perpetual subscription
        /// customers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deprovisionReason")]
        public virtual string DeprovisionReason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ChromeOsDevices : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of Chrome OS Device objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chromeosdevices")]
        public virtual System.Collections.Generic.IList<ChromeOsDevice> Chromeosdevices { get; set; }

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Token used to access the next page of this result. To access the next page, use this token's value in the
        /// `pageToken` query string of this request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }
    }

    public class ChromeOsMoveDevicesToOu : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Chrome OS devices to be moved to OU</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceIds")]
        public virtual System.Collections.Generic.IList<string> DeviceIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for adding a new printer.</summary>
    public class CreatePrinterRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The name of the customer. Format: customers/{customer_id}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>
        /// Required. A printer to create. If you want to place the printer under particular OU then populate
        /// printer.org_unit_id filed. Otherwise the printer will be placed under root OU.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("printer")]
        public virtual Printer Printer { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Customer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The customer's secondary contact email address. This email address cannot be on the same domain as the
        /// `customerDomain`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alternateEmail")]
        public virtual string AlternateEmail { get; set; }

        /// <summary>The customer's creation time (Readonly)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerCreationTime")]
        public virtual string CustomerCreationTimeRaw { get; set; }

        /// <summary>
        /// <seealso cref="System.DateTime"/> representation of <see cref="CustomerCreationTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> CustomerCreationTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(CustomerCreationTimeRaw);
            set => CustomerCreationTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// The customer's primary domain name string. Do not include the `www` prefix when creating a new customer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerDomain")]
        public virtual string CustomerDomain { get; set; }

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The unique ID for the customer's Google Workspace account. (Readonly)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Identifies the resource as a customer. Value: `admin#directory#customer`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The customer's ISO 639-2 language code. See the [Language Codes](/admin-sdk/directory/v1/languages) page for
        /// the list of supported codes. Valid language codes outside the supported set will be accepted by the API but
        /// may lead to unexpected behavior. The default value is `en`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("language")]
        public virtual string Language { get; set; }

        /// <summary>
        /// The customer's contact phone number in [E.164](https://en.wikipedia.org/wiki/E.164) format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneNumber")]
        public virtual string PhoneNumber { get; set; }

        /// <summary>The customer's postal address information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalAddress")]
        public virtual CustomerPostalAddress PostalAddress { get; set; }
    }

    public class CustomerPostalAddress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A customer's physical address. The address can be composed of one to three lines.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addressLine1")]
        public virtual string AddressLine1 { get; set; }

        /// <summary>Address line 2 of the address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addressLine2")]
        public virtual string AddressLine2 { get; set; }

        /// <summary>Address line 3 of the address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addressLine3")]
        public virtual string AddressLine3 { get; set; }

        /// <summary>The customer contact's name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactName")]
        public virtual string ContactName { get; set; }

        /// <summary>
        /// This is a required property. For `countryCode` information see the [ISO 3166 country code
        /// elements](https://www.iso.org/iso/country_codes.htm).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countryCode")]
        public virtual string CountryCode { get; set; }

        /// <summary>Name of the locality. An example of a locality value is the city of `San Francisco`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locality")]
        public virtual string Locality { get; set; }

        /// <summary>The company or company division name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organizationName")]
        public virtual string OrganizationName { get; set; }

        /// <summary>
        /// The postal code. A postalCode example is a postal zip code such as `10009`. This is in accordance with -
        /// http: //portablecontacts.net/draft-spec.html#address_element.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCode")]
        public virtual string PostalCode { get; set; }

        /// <summary>Name of the region. An example of a region value is `NY` for the state of New York.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information regarding a command that was issued to a device.</summary>
    public class DirectoryChromeosdevicesCommand : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The time at which the command will expire. If the device doesn't execute the command within this time the
        /// command will become expired.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commandExpireTime")]
        public virtual object CommandExpireTime { get; set; }

        /// <summary>Unique ID of a device command.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commandId")]
        public virtual System.Nullable<long> CommandId { get; set; }

        /// <summary>The result of the command execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commandResult")]
        public virtual DirectoryChromeosdevicesCommandResult CommandResult { get; set; }

        /// <summary>The timestamp when the command was issued by the admin.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issueTime")]
        public virtual object IssueTime { get; set; }

        /// <summary>The payload that the command specified, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payload")]
        public virtual string Payload { get; set; }

        /// <summary>Indicates the command state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The type of the command.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of executing a command.</summary>
    public class DirectoryChromeosdevicesCommandResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The error message with a short explanation as to why the command failed. Only present if the command failed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>The time at which the command was executed or failed to execute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executeTime")]
        public virtual object ExecuteTime { get; set; }

        /// <summary>The result of the command.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("result")]
        public virtual string Result { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request for issuing a command.</summary>
    public class DirectoryChromeosdevicesIssueCommandRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of command.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commandType")]
        public virtual string CommandType { get; set; }

        /// <summary>
        /// The payload for the command, provide it only if command supports it. The following commands support adding
        /// payload: - SET_VOLUME: Payload is a stringified JSON object in the form: { "volume": 50 }. The volume has to
        /// be an integer in the range [0,100].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payload")]
        public virtual string Payload { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response for issuing a command.</summary>
    public class DirectoryChromeosdevicesIssueCommandResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The unique ID of the issued command, used to retrieve the command status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commandId")]
        public virtual System.Nullable<long> CommandId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DomainAlias : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The creation time of the domain alias. (Read-only).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual System.Nullable<long> CreationTime { get; set; }

        /// <summary>The domain alias name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainAliasName")]
        public virtual string DomainAliasName { get; set; }

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The parent domain name that the domain alias is associated with. This can either be a primary or secondary
        /// domain name within a customer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentDomainName")]
        public virtual string ParentDomainName { get; set; }

        /// <summary>Indicates the verification state of a domain alias. (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verified")]
        public virtual System.Nullable<bool> Verified { get; set; }
    }

    public class DomainAliases : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of domain alias objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainAliases")]
        public virtual System.Collections.Generic.IList<DomainAlias> DomainAliasesValue { get; set; }

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }
    }

    public class Domains : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Creation time of the domain. Expressed in [Unix time](https://en.wikipedia.org/wiki/Epoch_time) format.
        /// (Read-only).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual System.Nullable<long> CreationTime { get; set; }

        /// <summary>List of domain alias objects. (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainAliases")]
        public virtual System.Collections.Generic.IList<DomainAlias> DomainAliases { get; set; }

        /// <summary>The domain name of the customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainName")]
        public virtual string DomainName { get; set; }

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Indicates if the domain is a primary domain (Read-only).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isPrimary")]
        public virtual System.Nullable<bool> IsPrimary { get; set; }

        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Indicates the verification state of a domain. (Read-only).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verified")]
        public virtual System.Nullable<bool> Verified { get; set; }
    }

    public class Domains2 : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of domain objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domains")]
        public virtual System.Collections.Generic.IList<Domains> Domains { get; set; }

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }
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

    /// <summary>Info about failures</summary>
    public class FailureInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Canonical code for why the update failed to apply.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorCode")]
        public virtual string ErrorCode { get; set; }

        /// <summary>Failure reason message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>Failed printer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("printer")]
        public virtual Printer Printer { get; set; }

        /// <summary>Id of a failed printer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("printerId")]
        public virtual string PrinterId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for Feature object in Directory API.</summary>
    public class Feature : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etags")]
        public virtual string Etags { get; set; }

        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The name of the feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for a feature instance.</summary>
    public class FeatureInstance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The feature that this is an instance of. A calendar resource may have multiple instances of a feature.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feature")]
        public virtual Feature Feature { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class FeatureRename : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>New name of the feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newName")]
        public virtual string NewName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Public API: Resources.features</summary>
    public class Features : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The Features in this page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("features")]
        public virtual System.Collections.Generic.IList<Feature> FeaturesValue { get; set; }

        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The continuation token, used to page through large result sets. Provide this value in a subsequent request
        /// to return the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }
    }

    /// <summary>
    /// Google Groups provide your users the ability to send messages to groups of people using the group's email
    /// address. For more information about common tasks, see the [Developer's
    /// Guide](/admin-sdk/directory/v1/guides/manage-groups).
    /// </summary>
    public class Group : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Value is `true` if this group was created by an administrator rather than a user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adminCreated")]
        public virtual System.Nullable<bool> AdminCreated { get; set; }

        /// <summary>List of a group's alias email addresses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aliases")]
        public virtual System.Collections.Generic.IList<string> Aliases { get; set; }

        /// <summary>
        /// An extended description to help users determine the purpose of a group. For example, you can include
        /// information about who should join the group, the types of messages to send to the group, links to FAQs about
        /// the group, or related groups. Maximum length is `4,096` characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// The number of users that are direct members of the group. If a group is a member (child) of this group (the
        /// parent), members of the child group are not counted in the `directMembersCount` property of the parent
        /// group.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("directMembersCount")]
        public virtual System.Nullable<long> DirectMembersCount { get; set; }

        /// <summary>
        /// The group's email address. If your account has multiple domains, select the appropriate domain for the email
        /// address. The `email` must be unique. This property is required when creating a group. Group email addresses
        /// are subject to the same character usage rules as usernames, see the [help
        /// center](https://support.google.com/a/answer/9193374) for details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The unique ID of a group. A group `id` can be used as a group request URI's `groupKey`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The type of the API resource. For Groups resources, the value is `admin#directory#group`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The group's display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// List of the group's non-editable alias email addresses that are outside of the account's primary domain or
        /// subdomains. These are functioning email addresses used by the group. This is a read-only property returned
        /// in the API's response for a group. If edited in a group's POST or PUT request, the edit is ignored by the
        /// API service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nonEditableAliases")]
        public virtual System.Collections.Generic.IList<string> NonEditableAliases { get; set; }
    }

    public class Groups : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>List of group objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groups")]
        public virtual System.Collections.Generic.IList<Group> GroupsValue { get; set; }

        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Token used to access next page of this result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }
    }

    /// <summary>Response for listing allowed printer models.</summary>
    public class ListPrinterModelsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// Printer models that are currently allowed to be configured for ChromeOs. Some printers may be added or
        /// removed over time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("printerModels")]
        public virtual System.Collections.Generic.IList<PrinterModel> PrinterModels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for listing printers.</summary>
    public class ListPrintersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// List of printers. If `org_unit_id` was given in the request, then only printers visible for this OU will be
        /// returned. If `org_unit_id` was given in the request, then all printers will be returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("printers")]
        public virtual System.Collections.Generic.IList<Printer> Printers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Google Groups member can be a user or another group. This member can be inside or outside of your account's
    /// domains. For more information about common group member tasks, see the [Developer's
    /// Guide](/admin-sdk/directory/v1/guides/manage-group-members).
    /// </summary>
    public class Member : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Defines mail delivery preferences of member. This is only supported by create/update/get.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delivery_settings")]
        public virtual string DeliverySettings { get; set; }

        /// <summary>
        /// The member's email address. A member can be a user or another group. This property is required when adding a
        /// member to a group. The `email` must be unique and cannot be an alias of another group. If the email address
        /// is changed, the API automatically reflects the email address changes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// The unique ID of the group member. A member `id` can be used as a member request URI's `memberKey`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// The type of the API resource. For Members resources, the value is `admin#directory#member`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The member's role in a group. The API returns an error for cycles in group memberships. For example, if
        /// `group1` is a member of `group2`, `group2` cannot be a member of `group1`. For more information about a
        /// member's role, see the [administration help center](https://support.google.com/a/answer/167094).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>Status of member (Immutable)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The type of group member.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }
    }

    public class Members : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>List of member objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<Member> MembersValue { get; set; }

        /// <summary>Token used to access next page of this result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }
    }

    /// <summary>JSON template for Has Member response in Directory API.</summary>
    public class MembersHasMember : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Identifies whether the given user is a member of the group. Membership can be direct or nested.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isMember")]
        public virtual System.Nullable<bool> IsMember { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Google Workspace Mobile Management includes Android, [Google Sync](https://support.google.com/a/answer/135937),
    /// and iOS devices. For more information about common group mobile device API tasks, see the [Developer's
    /// Guide](/admin-sdk/directory/v1/guides/manage-mobile-devices.html).
    /// </summary>
    public class MobileDevice : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Adb (USB debugging) enabled or disabled on device (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adbStatus")]
        public virtual System.Nullable<bool> AdbStatus { get; set; }

        /// <summary>
        /// The list of applications installed on an Android mobile device. It is not applicable to Google Sync and iOS
        /// devices. The list includes any Android applications that access Google Workspace data. When updating an
        /// applications list, it is important to note that updates replace the existing list. If the Android device has
        /// two existing applications and the API updates the list with five applications, the is now the updated list
        /// of five applications.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applications")]
        public virtual System.Collections.Generic.IList<ApplicationsData> Applications { get; set; }

        /// <summary>The device's baseband version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basebandVersion")]
        public virtual string BasebandVersion { get; set; }

        /// <summary>Mobile Device Bootloader version (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootloaderVersion")]
        public virtual string BootloaderVersion { get; set; }

        /// <summary>Mobile Device Brand (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("brand")]
        public virtual string Brand { get; set; }

        /// <summary>The device's operating system build number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildNumber")]
        public virtual string BuildNumber { get; set; }

        /// <summary>The default locale used on the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultLanguage")]
        public virtual string DefaultLanguage { get; set; }

        /// <summary>Developer options enabled or disabled on device (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("developerOptionsStatus")]
        public virtual System.Nullable<bool> DeveloperOptionsStatus { get; set; }

        /// <summary>The compromised device status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceCompromisedStatus")]
        public virtual string DeviceCompromisedStatus { get; set; }

        /// <summary>
        /// The serial number for a Google Sync mobile device. For Android and iOS devices, this is a software generated
        /// unique identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceId")]
        public virtual string DeviceId { get; set; }

        /// <summary>DevicePasswordStatus (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("devicePasswordStatus")]
        public virtual string DevicePasswordStatus { get; set; }

        /// <summary>
        /// List of owner's email addresses. If your application needs the current list of user emails, use the
        /// [get](/admin-sdk/directory/v1/reference/mobiledevices/get.html) method. For additional information, see the
        /// [retrieve a user](/admin-sdk/directory/v1/guides/manage-users#get_user) method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual System.Collections.Generic.IList<string> Email { get; set; }

        /// <summary>Mobile Device Encryption Status (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionStatus")]
        public virtual string EncryptionStatus { get; set; }

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Date and time the device was first synchronized with the policy settings in the G Suite administrator
        /// control panel (Read-only)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstSync")]
        public virtual string FirstSyncRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="FirstSyncRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> FirstSync
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(FirstSyncRaw);
            set => FirstSyncRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>Mobile Device Hardware (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hardware")]
        public virtual string Hardware { get; set; }

        /// <summary>
        /// The IMEI/MEID unique identifier for Android hardware. It is not applicable to Google Sync devices. When
        /// adding an Android mobile device, this is an optional property. When updating one of these devices, this is a
        /// read-only property.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hardwareId")]
        public virtual string HardwareId { get; set; }

        /// <summary>The device's IMEI number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imei")]
        public virtual string Imei { get; set; }

        /// <summary>The device's kernel version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kernelVersion")]
        public virtual string KernelVersion { get; set; }

        /// <summary>
        /// The type of the API resource. For Mobiledevices resources, the value is `admin#directory#mobiledevice`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Date and time the device was last synchronized with the policy settings in the G Suite administrator control
        /// panel (Read-only)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastSync")]
        public virtual string LastSyncRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="LastSyncRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> LastSync
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(LastSyncRaw);
            set => LastSyncRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>Boolean indicating if this account is on owner/primary profile or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managedAccountIsOnOwnerProfile")]
        public virtual System.Nullable<bool> ManagedAccountIsOnOwnerProfile { get; set; }

        /// <summary>Mobile Device manufacturer (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manufacturer")]
        public virtual string Manufacturer { get; set; }

        /// <summary>The device's MEID number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meid")]
        public virtual string Meid { get; set; }

        /// <summary>
        /// The mobile device's model name, for example Nexus S. This property can be
        /// [updated](/admin-sdk/directory/v1/reference/mobiledevices/update.html). For more information, see the
        /// [Developer's Guide](/admin-sdk/directory/v1/guides/manage-mobile=devices#update_mobile_device).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; }

        /// <summary>
        /// List of the owner's user names. If your application needs the current list of device owner names, use the
        /// [get](/admin-sdk/directory/v1/reference/mobiledevices/get.html) method. For more information about
        /// retrieving mobile device user information, see the [Developer's
        /// Guide](/admin-sdk/directory/v1/guides/manage-users#get_user).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual System.Collections.Generic.IList<string> Name { get; set; }

        /// <summary>Mobile Device mobile or network operator (if available) (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkOperator")]
        public virtual string NetworkOperator { get; set; }

        /// <summary>
        /// The mobile device's operating system, for example IOS 4.3 or Android 2.3.5. This property can be
        /// [updated](/admin-sdk/directory/v1/reference/mobiledevices/update.html). For more information, see the
        /// [Developer's Guide](/admin-sdk/directory/v1/guides/manage-mobile-devices#update_mobile_device).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("os")]
        public virtual string Os { get; set; }

        /// <summary>List of accounts added on device (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("otherAccountsInfo")]
        public virtual System.Collections.Generic.IList<string> OtherAccountsInfo { get; set; }

        /// <summary>DMAgentPermission (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privilege")]
        public virtual string Privilege { get; set; }

        /// <summary>Mobile Device release version version (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseVersion")]
        public virtual string ReleaseVersion { get; set; }

        /// <summary>The unique ID the API service uses to identify the mobile device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual string ResourceId { get; set; }

        /// <summary>Mobile Device Security patch level (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityPatchLevel")]
        public virtual System.Nullable<long> SecurityPatchLevel { get; set; }

        /// <summary>The device's serial number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serialNumber")]
        public virtual string SerialNumber { get; set; }

        /// <summary>The device's status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>Work profile supported on device (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportsWorkProfile")]
        public virtual System.Nullable<bool> SupportsWorkProfile { get; set; }

        /// <summary>The type of mobile device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Unknown sources enabled or disabled on device (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unknownSourcesStatus")]
        public virtual System.Nullable<bool> UnknownSourcesStatus { get; set; }

        /// <summary>
        /// Gives information about the device such as `os` version. This property can be
        /// [updated](/admin-sdk/directory/v1/reference/mobiledevices/update.html). For more information, see the
        /// [Developer's Guide](/admin-sdk/directory/v1/guides/manage-mobile-devices#update_mobile_device).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userAgent")]
        public virtual string UserAgent { get; set; }

        /// <summary>The device's MAC address on Wi-Fi networks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wifiMacAddress")]
        public virtual string WifiMacAddress { get; set; }

        /// <summary>
        /// The list of applications installed on an Android mobile device. It is not applicable to Google Sync and iOS
        /// devices. The list includes any Android applications that access Google Workspace data. When updating an
        /// applications list, it is important to note that updates replace the existing list. If the Android device has
        /// two existing applications and the API updates the list with five applications, the is now the updated list
        /// of five applications.
        /// </summary>
        public class ApplicationsData
        {
            /// <summary>The application's display name. An example is `Browser`.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
            public virtual string DisplayName { get; set; }

            /// <summary>The application's package name. An example is `com.android.browser`.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
            public virtual string PackageName { get; set; }

            /// <summary>
            /// The list of permissions of this application. These can be either a standard Android permission or one
            /// defined by the application, and are found in an application's [Android
            /// manifest](https://developer.android.com/guide/topics/manifest/uses-permission-element.html). Examples of
            /// a Calendar application's permissions are `READ_CALENDAR`, or `MANAGE_ACCOUNTS`.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("permission")]
            public virtual System.Collections.Generic.IList<string> Permission { get; set; }

            /// <summary>The application's version code. An example is `13`.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("versionCode")]
            public virtual System.Nullable<int> VersionCode { get; set; }

            /// <summary>The application's version name. An example is `3.2-140714`.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("versionName")]
            public virtual string VersionName { get; set; }
        }
    }

    public class MobileDeviceAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The action to be performed on the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class MobileDevices : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>List of Mobile Device objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobiledevices")]
        public virtual System.Collections.Generic.IList<MobileDevice> Mobiledevices { get; set; }

        /// <summary>Token used to access next page of this result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }
    }

    /// <summary>
    /// Managing your account's organizational units allows you to configure your users' access to services and custom
    /// settings. For more information about common organizational unit tasks, see the [Developer's
    /// Guide](/admin-sdk/directory/v1/guides/manage-org-units.html).
    /// </summary>
    public class OrgUnit : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Determines if a sub-organizational unit can inherit the settings of the parent organization. The default
        /// value is `false`, meaning a sub-organizational unit inherits the settings of the nearest parent
        /// organizational unit. For more information on inheritance and users in an organization structure, see the
        /// [administration help center](https://support.google.com/a/answer/4352075).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockInheritance")]
        public virtual System.Nullable<bool> BlockInheritance { get; set; }

        /// <summary>Description of the organizational unit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// The type of the API resource. For Orgunits resources, the value is `admin#directory#orgUnit`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The organizational unit's path name. For example, an organizational unit's name within the
        /// /corp/support/sales_support parent path is sales_support. Required.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The unique ID of the organizational unit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgUnitId")]
        public virtual string OrgUnitId { get; set; }

        /// <summary>
        /// The full path to the organizational unit. The `orgUnitPath` is a derived property. When listed, it is
        /// derived from `parentOrgunitPath` and organizational unit's `name`. For example, for an organizational unit
        /// named 'apps' under parent organization '/engineering', the orgUnitPath is '/engineering/apps'. In order to
        /// edit an `orgUnitPath`, either update the name of the organization or the `parentOrgunitPath`. A user's
        /// organizational unit determines which Google Workspace services the user has access to. If the user is moved
        /// to a new organization, the user's access changes. For more information about organization structures, see
        /// the [administration help center](https://support.google.com/a/answer/4352075). For more information about
        /// moving a user to a different organization, see [Update a
        /// user](/admin-sdk/directory/v1/guides/manage-users.html#update_user).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgUnitPath")]
        public virtual string OrgUnitPath { get; set; }

        /// <summary>
        /// The unique ID of the parent organizational unit. Required, unless `parentOrgUnitPath` is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentOrgUnitId")]
        public virtual string ParentOrgUnitId { get; set; }

        /// <summary>
        /// The organizational unit's parent path. For example, /corp/sales is the parent path for
        /// /corp/sales/sales_support organizational unit. Required, unless `parentOrgUnitId` is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentOrgUnitPath")]
        public virtual string ParentOrgUnitPath { get; set; }
    }

    public class OrgUnits : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// The type of the API resource. For Org Unit resources, the type is `admin#directory#orgUnits`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>List of organizational unit objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organizationUnits")]
        public virtual System.Collections.Generic.IList<OrgUnit> OrganizationUnits { get; set; }
    }

    /// <summary>Printer configuration.</summary>
    public class Printer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Auxiliary messages about issues with the printer configuration if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auxiliaryMessages")]
        public virtual System.Collections.Generic.IList<AuxiliaryMessage> AuxiliaryMessages { get; set; }

        /// <summary>Output only. Time when printer was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Editable. Description of printer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Editable. Name of printer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Id of the printer. (During printer creation leave empty)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Editable. Make and model of printer. e.g. Lexmark MS610de Value must be in format as seen in
        /// ListPrinterModels response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("makeAndModel")]
        public virtual string MakeAndModel { get; set; }

        /// <summary>
        /// The resource name of the Printer object, in the format customers/{customer-id}/printers/{printer-id} (During
        /// printer creation leave empty)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Organization Unit that owns this printer (Only can be set during Printer creation)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgUnitId")]
        public virtual string OrgUnitId { get; set; }

        /// <summary>Editable. Printer URI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>
        /// Editable. flag to use driverless configuration or not. If it's set to be true, make_and_model can be ignored
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useDriverlessConfig")]
        public virtual System.Nullable<bool> UseDriverlessConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Printer manufacturer and model</summary>
    public class PrinterModel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Display name. eq. "Brother MFC-8840D"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Make and model as represented in "make_and_model" field in Printer object. eq. "brother mfc-8840d"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("makeAndModel")]
        public virtual string MakeAndModel { get; set; }

        /// <summary>Manufacturer. eq. "Brother"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manufacturer")]
        public virtual string Manufacturer { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Privilege : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of child privileges. Privileges for a service form a tree. Each privilege can have a list of child
        /// privileges; this list is empty for a leaf privilege.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("childPrivileges")]
        public virtual System.Collections.Generic.IList<Privilege> ChildPrivileges { get; set; }

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>If the privilege can be restricted to an organization unit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isOuScopable")]
        public virtual System.Nullable<bool> IsOuScopable { get; set; }

        /// <summary>The type of the API resource. This is always `admin#directory#privilege`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The name of the privilege.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privilegeName")]
        public virtual string PrivilegeName { get; set; }

        /// <summary>
        /// The obfuscated ID of the service this privilege is for. This value is returned with
        /// [`Privileges.list()`](/admin-sdk/directory/v1/reference/privileges/list).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceId")]
        public virtual string ServiceId { get; set; }

        /// <summary>The name of the service this privilege is for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceName")]
        public virtual string ServiceName { get; set; }
    }

    public class Privileges : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>A list of Privilege resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Privilege> Items { get; set; }

        /// <summary>The type of the API resource. This is always `admin#directory#privileges`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }
    }

    public class Role : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Returns `true` if the role is a super admin role.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isSuperAdminRole")]
        public virtual System.Nullable<bool> IsSuperAdminRole { get; set; }

        /// <summary>Returns `true` if this is a pre-defined system role.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isSystemRole")]
        public virtual System.Nullable<bool> IsSystemRole { get; set; }

        /// <summary>The type of the API resource. This is always `admin#directory#role`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>A short description of the role.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roleDescription")]
        public virtual string RoleDescription { get; set; }

        /// <summary>ID of the role.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roleId")]
        public virtual System.Nullable<long> RoleId { get; set; }

        /// <summary>Name of the role.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roleName")]
        public virtual string RoleName { get; set; }

        /// <summary>The set of privileges that are granted to this role.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolePrivileges")]
        public virtual System.Collections.Generic.IList<RolePrivilegesData> RolePrivileges { get; set; }

        /// <summary>The set of privileges that are granted to this role.</summary>
        public class RolePrivilegesData
        {
            /// <summary>The name of the privilege.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("privilegeName")]
            public virtual string PrivilegeName { get; set; }

            /// <summary>
            /// The obfuscated ID of the service this privilege is for. This value is returned with
            /// [`Privileges.list()`](/admin-sdk/directory/v1/reference/privileges/list).
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("serviceId")]
            public virtual string ServiceId { get; set; }
        }
    }

    /// <summary>Defines an assignment of a role.</summary>
    public class RoleAssignment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The unique ID of the user this role is assigned to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignedTo")]
        public virtual string AssignedTo { get; set; }

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The type of the API resource. This is always `admin#directory#roleAssignment`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// If the role is restricted to an organization unit, this contains the ID for the organization unit the
        /// exercise of this role is restricted to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgUnitId")]
        public virtual string OrgUnitId { get; set; }

        /// <summary>ID of this roleAssignment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roleAssignmentId")]
        public virtual System.Nullable<long> RoleAssignmentId { get; set; }

        /// <summary>The ID of the role that is assigned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roleId")]
        public virtual System.Nullable<long> RoleId { get; set; }

        /// <summary>The scope in which this role is assigned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopeType")]
        public virtual string ScopeType { get; set; }
    }

    public class RoleAssignments : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>A list of RoleAssignment resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<RoleAssignment> Items { get; set; }

        /// <summary>The type of the API resource. This is always `admin#directory#roleAssignments`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }
    }

    public class Roles : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>A list of Role resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Role> Items { get; set; }

        /// <summary>The type of the API resource. This is always `admin#directory#roles`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }
    }

    /// <summary>The type of API resource. For Schema resources, this is always `admin#directory#schema`.</summary>
    public class Schema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Display name for the schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>A list of fields in the schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IList<SchemaFieldSpec> Fields { get; set; }

        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The unique identifier of the schema (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemaId")]
        public virtual string SchemaId { get; set; }

        /// <summary>The schema's name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemaName")]
        public virtual string SchemaName { get; set; }
    }

    /// <summary>
    /// You can use schemas to add custom fields to user profiles. You can use these fields to store information such as
    /// the projects your users work on, their physical locations, their hire dates, or whatever else fits your business
    /// needs. For more information, see [Custom User Fields](/admin-sdk/directory/v1/guides/manage-schemas).
    /// </summary>
    public class SchemaFieldSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Display Name of the field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The ETag of the field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The unique identifier of the field (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldId")]
        public virtual string FieldId { get; set; }

        /// <summary>The name of the field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldName")]
        public virtual string FieldName { get; set; }

        /// <summary>The type of the field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldType")]
        public virtual string FieldType { get; set; }

        /// <summary>Boolean specifying whether the field is indexed or not. Default: `true`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexed")]
        public virtual System.Nullable<bool> Indexed { get; set; }

        /// <summary>
        /// The kind of resource this is. For schema fields this is always `admin#directory#schema#fieldspec`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>A boolean specifying whether this is a multi-valued field or not. Default: `false`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiValued")]
        public virtual System.Nullable<bool> MultiValued { get; set; }

        /// <summary>
        /// Indexing spec for a numeric field. By default, only exact match queries will be supported for numeric
        /// fields. Setting the `numericIndexingSpec` allows range queries to be supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numericIndexingSpec")]
        public virtual NumericIndexingSpecData NumericIndexingSpec { get; set; }

        /// <summary>
        /// Specifies who can view values of this field. See [Retrieve users as a
        /// non-administrator](/admin-sdk/directory/v1/guides/manage-users#retrieve_users_non_admin) for more
        /// information. Note: It may take up to 24 hours for changes to this field to be reflected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readAccessType")]
        public virtual string ReadAccessType { get; set; }

        /// <summary>
        /// Indexing spec for a numeric field. By default, only exact match queries will be supported for numeric
        /// fields. Setting the `numericIndexingSpec` allows range queries to be supported.
        /// </summary>
        public class NumericIndexingSpecData
        {
            /// <summary>
            /// Maximum value of this field. This is meant to be indicative rather than enforced. Values outside this
            /// range will still be indexed, but search may not be as performant.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("maxValue")]
            public virtual System.Nullable<double> MaxValue { get; set; }

            /// <summary>
            /// Minimum value of this field. This is meant to be indicative rather than enforced. Values outside this
            /// range will still be indexed, but search may not be as performant.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("minValue")]
            public virtual System.Nullable<double> MinValue { get; set; }
        }
    }

    /// <summary>JSON response template for List Schema operation in Directory API.</summary>
    public class Schemas : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>List of UserSchema objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemas")]
        public virtual System.Collections.Generic.IList<Schema> SchemasValue { get; set; }
    }

    /// <summary>JSON template for token resource in Directory API.</summary>
    public class Token : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether the application is registered with Google. The value is `true` if the application has an anonymous
        /// Client ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("anonymous")]
        public virtual System.Nullable<bool> Anonymous { get; set; }

        /// <summary>The Client ID of the application the token is issued to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>The displayable name of the application the token is issued to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayText")]
        public virtual string DisplayText { get; set; }

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The type of the API resource. This is always `admin#directory#token`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Whether the token is issued to an installed application. The value is `true` if the application is installed
        /// to a desktop or mobile device.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nativeApp")]
        public virtual System.Nullable<bool> NativeApp { get; set; }

        /// <summary>A list of authorization scopes the application is granted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopes")]
        public virtual System.Collections.Generic.IList<string> Scopes { get; set; }

        /// <summary>The unique ID of the user that issued the token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userKey")]
        public virtual string UserKey { get; set; }
    }

    /// <summary>JSON response template for List tokens operation in Directory API.</summary>
    public class Tokens : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>A list of Token resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Token> Items { get; set; }

        /// <summary>The type of the API resource. This is always `admin#directory#tokenList`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }
    }

    /// <summary>
    /// The Directory API allows you to create and manage your account's users, user aliases, and user Gmail chat
    /// profile photos. For more information about common tasks, see the [User Accounts Developer's
    /// Guide](/admin-sdk/directory/v1/guides/manage-users.html) and the [User Aliases Developer's
    /// Guide](/admin-sdk/directory/v1/guides/manage-user-aliases.html).
    /// </summary>
    public class User : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of the user's addresses. The maximum allowed data size for this field is 10Kb.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addresses")]
        public virtual System.Collections.Generic.IList<UserAddress> Addresses { get; set; }

        /// <summary>
        /// Output only. This property is `true` if the user has completed an initial login and accepted the Terms of
        /// Service agreement.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agreedToTerms")]
        public virtual System.Nullable<bool> AgreedToTerms { get; set; }

        /// <summary>Output only. A list of the user's alias email addresses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aliases")]
        public virtual System.Collections.Generic.IList<string> Aliases { get; set; }

        /// <summary>Indicates if user is archived.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("archived")]
        public virtual System.Nullable<bool> Archived { get; set; }

        /// <summary>
        /// Indicates if the user is forced to change their password at next login. This setting doesn't apply when [the
        /// user signs in via a third-party identity provider](https://support.google.com/a/answer/60224).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("changePasswordAtNextLogin")]
        public virtual System.Nullable<bool> ChangePasswordAtNextLogin { get; set; }

        /// <summary>User's G Suite account creation time. (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual string CreationTimeRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="CreationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> CreationTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(CreationTimeRaw);
            set => CreationTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>Custom fields of the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customSchemas")]
        public virtual System.Collections.Generic.IDictionary<string, System.Collections.Generic.IDictionary<string, object>> CustomSchemas { get; set; }

        /// <summary>
        /// Output only. The customer ID to [retrieve all account
        /// users](/admin-sdk/directory/v1/guides/manage-users.html#get_all_users). You can use the alias `my_customer`
        /// to represent your account's `customerId`. As a reseller administrator, you can use the resold customer
        /// account's `customerId`. To get a `customerId`, use the account's primary domain in the `domain` parameter of
        /// a [users.list](/admin-sdk/directory/v1/reference/users/list) request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerId")]
        public virtual string CustomerId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("deletionTime")]
        public virtual string DeletionTimeRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="DeletionTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> DeletionTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(DeletionTimeRaw);
            set => DeletionTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// A list of the user's email addresses. The maximum allowed data size for this field is 10Kb.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emails")]
        public virtual System.Collections.Generic.IList<UserEmail> Emails { get; set; }

        /// <summary>Output only. ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// A list of external IDs for the user, such as an employee or network ID. The maximum allowed data size for
        /// this field is 2Kb.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalIds")]
        public virtual System.Collections.Generic.IList<UserExternalId> ExternalIds { get; set; }

        /// <summary>The user's gender. The maximum allowed data size for this field is 1Kb.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gender")]
        public virtual object Gender { get; set; }

        /// <summary>
        /// Stores the hash format of the password property. We recommend sending the `password` property value as a
        /// base 16 bit hexadecimal-encoded hash value. Set the `hashFunction` values as either the
        /// [SHA-1](https://wikipedia.org/wiki/SHA-1), [MD5](https://wikipedia.org/wiki/MD5), or
        /// [crypt](https://en.wikipedia.org/wiki/Crypt_\(C\)) hash format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hashFunction")]
        public virtual string HashFunction { get; set; }

        /// <summary>The unique ID for the user. A user `id` can be used as a user request URI's `userKey`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// The user's Instant Messenger (IM) accounts. A user account can have multiple ims properties. But, only one
        /// of these ims properties can be the primary IM contact. The maximum allowed data size for this field is 2Kb.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ims")]
        public virtual System.Collections.Generic.IList<UserIm> Ims { get; set; }

        /// <summary>
        /// Indicates if the user's profile is visible in the Google Workspace global address list when the contact
        /// sharing feature is enabled for the domain. For more information about excluding user profiles, see the
        /// [administration help center](https://support.google.com/a/answer/1285988).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeInGlobalAddressList")]
        public virtual System.Nullable<bool> IncludeInGlobalAddressList { get; set; }

        /// <summary>
        /// If `true`, the user's IP address is [whitelisted](https://support.google.com/a/answer/60752).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipWhitelisted")]
        public virtual System.Nullable<bool> IpWhitelisted { get; set; }

        /// <summary>
        /// Output only. Indicates a user with super admininistrator privileges. The `isAdmin` property can only be
        /// edited in the [Make a user an administrator](/admin-sdk/directory/v1/guides/manage-users.html#make_admin)
        /// operation ( [makeAdmin](/admin-sdk/directory/v1/reference/users/makeAdmin.html) method). If edited in the
        /// user [insert](/admin-sdk/directory/v1/reference/users/insert.html) or
        /// [update](/admin-sdk/directory/v1/reference/users/update.html) methods, the edit is ignored by the API
        /// service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isAdmin")]
        public virtual System.Nullable<bool> IsAdmin { get; set; }

        /// <summary>
        /// Output only. Indicates if the user is a delegated administrator. Delegated administrators are supported by
        /// the API but cannot create or undelete users, or make users administrators. These requests are ignored by the
        /// API service. Roles and privileges for administrators are assigned using the [Admin
        /// console](https://support.google.com/a/answer/33325).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isDelegatedAdmin")]
        public virtual System.Nullable<bool> IsDelegatedAdmin { get; set; }

        /// <summary>Output only. Is 2-step verification enforced (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isEnforcedIn2Sv")]
        public virtual System.Nullable<bool> IsEnforcedIn2Sv { get; set; }

        /// <summary>Output only. Is enrolled in 2-step verification (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isEnrolledIn2Sv")]
        public virtual System.Nullable<bool> IsEnrolledIn2Sv { get; set; }

        /// <summary>
        /// Output only. Indicates if the user's Google mailbox is created. This property is only applicable if the user
        /// has been assigned a Gmail license.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isMailboxSetup")]
        public virtual System.Nullable<bool> IsMailboxSetup { get; set; }

        /// <summary>The user's keywords. The maximum allowed data size for this field is 1Kb.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keywords")]
        public virtual object Keywords { get; set; }

        /// <summary>
        /// Output only. The type of the API resource. For Users resources, the value is `admin#directory#user`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The user's languages. The maximum allowed data size for this field is 1Kb.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languages")]
        public virtual object Languages { get; set; }

        /// <summary>User's last login time. (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastLoginTime")]
        public virtual string LastLoginTimeRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="LastLoginTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> LastLoginTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(LastLoginTimeRaw);
            set => LastLoginTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>The user's locations. The maximum allowed data size for this field is 10Kb.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual object Locations { get; set; }

        /// <summary>
        /// Holds the given and family names of the user, and the read-only `fullName` value. The maximum number of
        /// characters in the `givenName` and in the `familyName` values is 60. In addition, name values support
        /// unicode/UTF-8 characters, and can contain spaces, letters (a-z), numbers (0-9), dashes (-), forward slashes
        /// (/), and periods (.). For more information about character usage rules, see the [administration help
        /// center](https://support.google.com/a/answer/9193374). Maximum allowed data size for this field is 1Kb.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual UserName Name { get; set; }

        /// <summary>
        /// Output only. List of the user's non-editable alias email addresses. These are typically outside the
        /// account's primary domain or sub-domain.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nonEditableAliases")]
        public virtual System.Collections.Generic.IList<string> NonEditableAliases { get; set; }

        /// <summary>Notes for the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notes")]
        public virtual object Notes { get; set; }

        /// <summary>
        /// The full path of the parent organization associated with the user. If the parent organization is the
        /// top-level, it is represented as a forward slash (`/`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgUnitPath")]
        public virtual string OrgUnitPath { get; set; }

        /// <summary>
        /// A list of organizations the user belongs to. The maximum allowed data size for this field is 10Kb.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organizations")]
        public virtual System.Collections.Generic.IList<UserOrganization> Organizations { get; set; }

        /// <summary>User's password</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>A list of the user's phone numbers. The maximum allowed data size for this field is 1Kb.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phones")]
        public virtual System.Collections.Generic.IList<UserPhone> Phones { get; set; }

        /// <summary>
        /// A list of [POSIX](https://www.opengroup.org/austin/papers/posix_faq.html) account information for the user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("posixAccounts")]
        public virtual object PosixAccounts { get; set; }

        /// <summary>
        /// The user's primary email address. This property is required in a request to create a user account. The
        /// `primaryEmail` must be unique and cannot be an alias of another user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryEmail")]
        public virtual string PrimaryEmail { get; set; }

        /// <summary>Recovery email of the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recoveryEmail")]
        public virtual string RecoveryEmail { get; set; }

        /// <summary>
        /// Recovery phone of the user. The phone number must be in the E.164 format, starting with the plus sign (+).
        /// Example: *+16506661212*.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recoveryPhone")]
        public virtual string RecoveryPhone { get; set; }

        /// <summary>
        /// A list of the user's relationships to other users. The maximum allowed data size for this field is 2Kb.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relations")]
        public virtual System.Collections.Generic.IList<UserRelation> Relations { get; set; }

        /// <summary>A list of SSH public keys.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sshPublicKeys")]
        public virtual object SshPublicKeys { get; set; }

        /// <summary>Indicates if user is suspended.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suspended")]
        public virtual System.Nullable<bool> Suspended { get; set; }

        /// <summary>
        /// Output only. Has the reason a user account is suspended either by the administrator or by Google at the time
        /// of suspension. The property is returned only if the `suspended` property is `true`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suspensionReason")]
        public virtual string SuspensionReason { get; set; }

        /// <summary>Output only. ETag of the user's photo (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnailPhotoEtag")]
        public virtual string ThumbnailPhotoEtag { get; set; }

        /// <summary>Output only. Photo Url of the user (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnailPhotoUrl")]
        public virtual string ThumbnailPhotoUrl { get; set; }

        /// <summary>The user's websites. The maximum allowed data size for this field is 2Kb.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("websites")]
        public virtual System.Collections.Generic.IList<UserWebsite> Websites { get; set; }
    }

    /// <summary>JSON template for About (notes) of a user in Directory API.</summary>
    public class UserAbout : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// About entry can have a type which indicates the content type. It can either be plain or html. By default,
        /// notes contents are assumed to contain plain text.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentType")]
        public virtual string ContentType { get; set; }

        /// <summary>Actual value of notes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for address.</summary>
    public class UserAddress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Country.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("country")]
        public virtual string Country { get; set; }

        /// <summary>Country code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countryCode")]
        public virtual string CountryCode { get; set; }

        /// <summary>Custom type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customType")]
        public virtual string CustomType { get; set; }

        /// <summary>Extended Address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extendedAddress")]
        public virtual string ExtendedAddress { get; set; }

        /// <summary>Formatted address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formatted")]
        public virtual string Formatted { get; set; }

        /// <summary>Locality.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locality")]
        public virtual string Locality { get; set; }

        /// <summary>Other parts of address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("poBox")]
        public virtual string PoBox { get; set; }

        /// <summary>Postal code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCode")]
        public virtual string PostalCode { get; set; }

        /// <summary>If this is user's primary address. Only one entry could be marked as primary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primary")]
        public virtual System.Nullable<bool> Primary { get; set; }

        /// <summary>Region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>
        /// User supplied address was structured. Structured addresses are NOT supported at this time. You might be able
        /// to write structured addresses but any values will eventually be clobbered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceIsStructured")]
        public virtual System.Nullable<bool> SourceIsStructured { get; set; }

        /// <summary>Street.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("streetAddress")]
        public virtual string StreetAddress { get; set; }

        /// <summary>
        /// Each entry can have a type which indicates standard values of that entry. For example address could be of
        /// home work etc. In addition to the standard type an entry can have a custom type and can take any value. Such
        /// type should have the CUSTOM value as type and also have a customType value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for an email.</summary>
    public class UserEmail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Email id of the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual string Address { get; set; }

        /// <summary>Custom Type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customType")]
        public virtual string CustomType { get; set; }

        /// <summary>If this is user's primary email. Only one entry could be marked as primary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primary")]
        public virtual System.Nullable<bool> Primary { get; set; }

        /// <summary>
        /// Each entry can have a type which indicates standard types of that entry. For example email could be of home,
        /// work etc. In addition to the standard type, an entry can have a custom type and can take any value Such
        /// types should have the CUSTOM value as type and also have a customType value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for an externalId entry.</summary>
    public class UserExternalId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Custom type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customType")]
        public virtual string CustomType { get; set; }

        /// <summary>The type of the Id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The value of the id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class UserGender : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// AddressMeAs. A human-readable string containing the proper way to refer to the profile owner by humans for
        /// example he/him/his or they/them/their.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addressMeAs")]
        public virtual string AddressMeAs { get; set; }

        /// <summary>Custom gender.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customGender")]
        public virtual string CustomGender { get; set; }

        /// <summary>Gender.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for instant messenger of an user.</summary>
    public class UserIm : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Custom protocol.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customProtocol")]
        public virtual string CustomProtocol { get; set; }

        /// <summary>Custom type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customType")]
        public virtual string CustomType { get; set; }

        /// <summary>Instant messenger id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("im")]
        public virtual string Im { get; set; }

        /// <summary>If this is user's primary im. Only one entry could be marked as primary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primary")]
        public virtual System.Nullable<bool> Primary { get; set; }

        /// <summary>
        /// Protocol used in the instant messenger. It should be one of the values from ImProtocolTypes map. Similar to
        /// type it can take a CUSTOM value and specify the custom name in customProtocol field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protocol")]
        public virtual string Protocol { get; set; }

        /// <summary>
        /// Each entry can have a type which indicates standard types of that entry. For example instant messengers
        /// could be of home work etc. In addition to the standard type an entry can have a custom type and can take any
        /// value. Such types should have the CUSTOM value as type and also have a customType value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for a keyword entry.</summary>
    public class UserKeyword : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Custom Type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customType")]
        public virtual string CustomType { get; set; }

        /// <summary>
        /// Each entry can have a type which indicates standard type of that entry. For example keyword could be of type
        /// occupation or outlook. In addition to the standard type an entry can have a custom type and can give it any
        /// name. Such types should have the CUSTOM value as type and also have a customType value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Keyword.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for a language entry.</summary>
    public class UserLanguage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Other language. User can provide own language name if there is no corresponding Google III language code. If
        /// this is set LanguageCode can't be set
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customLanguage")]
        public virtual string CustomLanguage { get; set; }

        /// <summary>
        /// Language Code. Should be used for storing Google III LanguageCode string representation for language.
        /// Illegal values cause SchemaException.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for a location entry.</summary>
    public class UserLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Textual location. This is most useful for display purposes to concisely describe the location. For example
        /// 'Mountain View, CA', 'Near Seattle', 'US-NYC-9TH 9A209A.''
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("area")]
        public virtual string Area { get; set; }

        /// <summary>Building Identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildingId")]
        public virtual string BuildingId { get; set; }

        /// <summary>Custom Type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customType")]
        public virtual string CustomType { get; set; }

        /// <summary>Most specific textual code of individual desk location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deskCode")]
        public virtual string DeskCode { get; set; }

        /// <summary>Floor name/number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floorName")]
        public virtual string FloorName { get; set; }

        /// <summary>
        /// Floor section. More specific location within the floor. For example if a floor is divided into sections 'A',
        /// 'B' and 'C' this field would identify one of those values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floorSection")]
        public virtual string FloorSection { get; set; }

        /// <summary>
        /// Each entry can have a type which indicates standard types of that entry. For example location could be of
        /// types default and desk. In addition to standard type an entry can have a custom type and can give it any
        /// name. Such types should have 'custom' as type and also have a customType value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class UserMakeAdmin : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates the administrator status of the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual System.Nullable<bool> Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class UserName : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The user's last name. Required when creating a user account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("familyName")]
        public virtual string FamilyName { get; set; }

        /// <summary>The user's full name formed by concatenating the first and last name values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullName")]
        public virtual string FullName { get; set; }

        /// <summary>The user's first name. Required when creating a user account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("givenName")]
        public virtual string GivenName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for an organization entry.</summary>
    public class UserOrganization : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The cost center of the users department.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("costCenter")]
        public virtual string CostCenter { get; set; }

        /// <summary>Custom type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customType")]
        public virtual string CustomType { get; set; }

        /// <summary>Department within the organization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("department")]
        public virtual string Department { get; set; }

        /// <summary>Description of the organization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The domain to which the organization belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>The full-time equivalent millipercent within the organization (100000 = 100%).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullTimeEquivalent")]
        public virtual System.Nullable<int> FullTimeEquivalent { get; set; }

        /// <summary>Location of the organization. This need not be fully qualified address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>Name of the organization</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>If it user's primary organization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primary")]
        public virtual System.Nullable<bool> Primary { get; set; }

        /// <summary>Symbol of the organization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("symbol")]
        public virtual string Symbol { get; set; }

        /// <summary>Title (designation) of the user in the organization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>
        /// Each entry can have a type which indicates standard types of that entry. For example organization could be
        /// of school work etc. In addition to the standard type an entry can have a custom type and can give it any
        /// name. Such types should have the CUSTOM value as type and also have a CustomType value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for a phone entry.</summary>
    public class UserPhone : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Custom Type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customType")]
        public virtual string CustomType { get; set; }

        /// <summary>If this is user's primary phone or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primary")]
        public virtual System.Nullable<bool> Primary { get; set; }

        /// <summary>
        /// Each entry can have a type which indicates standard types of that entry. For example phone could be of
        /// home_fax work mobile etc. In addition to the standard type an entry can have a custom type and can give it
        /// any name. Such types should have the CUSTOM value as type and also have a customType value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Phone number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class UserPhoto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Height of the photo in pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual System.Nullable<int> Height { get; set; }

        /// <summary>The ID the API uses to uniquely identify the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The type of the API resource. For Photo resources, this is `admin#directory#user#photo`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The MIME type of the photo. Allowed values are `JPEG`, `PNG`, `GIF`, `BMP`, `TIFF`, and web-safe base64
        /// encoding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>
        /// The user photo's upload data in [web-safe Base64](https://en.wikipedia.org/wiki/Base64#URL_applications)
        /// format in bytes. This means: * The slash (/) character is replaced with the underscore (_) character. * The
        /// plus sign (+) character is replaced with the hyphen (-) character. * The equals sign (=) character is
        /// replaced with the asterisk (*). * For padding, the period (.) character is used instead of the RFC-4648
        /// baseURL definition which uses the equals sign (=) for padding. This is done to simplify URL-parsing. *
        /// Whatever the size of the photo being uploaded, the API downsizes it to 96x96 pixels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("photoData")]
        public virtual string PhotoData { get; set; }

        /// <summary>The user's primary email address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryEmail")]
        public virtual string PrimaryEmail { get; set; }

        /// <summary>Width of the photo in pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<int> Width { get; set; }
    }

    /// <summary>JSON template for a POSIX account entry.</summary>
    public class UserPosixAccount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A POSIX account field identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        /// <summary>The GECOS (user information) for this account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gecos")]
        public virtual string Gecos { get; set; }

        /// <summary>The default group ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gid")]
        public virtual System.Nullable<ulong> Gid { get; set; }

        /// <summary>The path to the home directory for this account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("homeDirectory")]
        public virtual string HomeDirectory { get; set; }

        /// <summary>The operating system type for this account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatingSystemType")]
        public virtual string OperatingSystemType { get; set; }

        /// <summary>If this is user's primary account within the SystemId.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primary")]
        public virtual System.Nullable<bool> Primary { get; set; }

        /// <summary>The path to the login shell for this account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shell")]
        public virtual string Shell { get; set; }

        /// <summary>System identifier for which account Username or Uid apply to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemId")]
        public virtual string SystemId { get; set; }

        /// <summary>The POSIX compliant user ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual System.Nullable<ulong> Uid { get; set; }

        /// <summary>The username of the account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for a relation entry.</summary>
    public class UserRelation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Custom Type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customType")]
        public virtual string CustomType { get; set; }

        /// <summary>
        /// The relation of the user. Some of the possible values are mother father sister brother manager assistant
        /// partner.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The name of the relation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for a POSIX account entry.</summary>
    public class UserSshPublicKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An expiration time in microseconds since epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expirationTimeUsec")]
        public virtual System.Nullable<long> ExpirationTimeUsec { get; set; }

        /// <summary>A SHA-256 fingerprint of the SSH public key. (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual string Fingerprint { get; set; }

        /// <summary>An SSH public key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class UserUndelete : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>OrgUnit of User</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgUnitPath")]
        public virtual string OrgUnitPath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for a website entry.</summary>
    public class UserWebsite : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Custom Type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customType")]
        public virtual string CustomType { get; set; }

        /// <summary>If this is user's primary website or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primary")]
        public virtual System.Nullable<bool> Primary { get; set; }

        /// <summary>
        /// Each entry can have a type which indicates standard types of that entry. For example website could be of
        /// home work blog etc. In addition to the standard type an entry can have a custom type and can give it any
        /// name. Such types should have the CUSTOM value as type and also have a customType value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Website.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Users : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Token used to access next page of this result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Event that triggered this response (only used in case of Push Response)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trigger_event")]
        public virtual string TriggerEvent { get; set; }

        /// <summary>List of user objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("users")]
        public virtual System.Collections.Generic.IList<User> UsersValue { get; set; }
    }

    /// <summary>
    /// The Directory API allows you to view, generate, and invalidate backup verification codes for a user.
    /// </summary>
    public class VerificationCode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The type of the resource. This is always `admin#directory#verificationCode`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The obfuscated unique ID of the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        /// <summary>
        /// A current verification code for the user. Invalidated or used verification codes are not returned as part of
        /// the result.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verificationCode")]
        public virtual string VerificationCodeValue { get; set; }
    }

    /// <summary>JSON response template for List verification codes operation in Directory API.</summary>
    public class VerificationCodes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>A list of verification code resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<VerificationCode> Items { get; set; }

        /// <summary>The type of the resource. This is always `admin#directory#verificationCodesList`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }
    }
}
