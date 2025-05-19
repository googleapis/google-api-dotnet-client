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

namespace Google.Apis.PeopleService.v1
{
    /// <summary>The PeopleService Service.</summary>
    public class PeopleServiceService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public PeopleServiceService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public PeopleServiceService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            ContactGroups = new ContactGroupsResource(this);
            OtherContacts = new OtherContactsResource(this);
            People = new PeopleResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://people.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://people.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "people";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the People API.</summary>
        public class Scope
        {
            /// <summary>See, edit, download, and permanently delete your contacts</summary>
            public static string Contacts = "https://www.googleapis.com/auth/contacts";

            /// <summary>See and download contact info automatically saved in your "Other contacts"</summary>
            public static string ContactsOtherReadonly = "https://www.googleapis.com/auth/contacts.other.readonly";

            /// <summary>See and download your contacts</summary>
            public static string ContactsReadonly = "https://www.googleapis.com/auth/contacts.readonly";

            /// <summary>See and download your organization's GSuite directory</summary>
            public static string DirectoryReadonly = "https://www.googleapis.com/auth/directory.readonly";

            /// <summary>View your street addresses</summary>
            public static string UserAddressesRead = "https://www.googleapis.com/auth/user.addresses.read";

            /// <summary>See and download your exact date of birth</summary>
            public static string UserBirthdayRead = "https://www.googleapis.com/auth/user.birthday.read";

            /// <summary>See and download all of your Google Account email addresses</summary>
            public static string UserEmailsRead = "https://www.googleapis.com/auth/user.emails.read";

            /// <summary>See your gender</summary>
            public static string UserGenderRead = "https://www.googleapis.com/auth/user.gender.read";

            /// <summary>See your education, work history and org info</summary>
            public static string UserOrganizationRead = "https://www.googleapis.com/auth/user.organization.read";

            /// <summary>See and download your personal phone numbers</summary>
            public static string UserPhonenumbersRead = "https://www.googleapis.com/auth/user.phonenumbers.read";

            /// <summary>See your primary Google Account email address</summary>
            public static string UserinfoEmail = "https://www.googleapis.com/auth/userinfo.email";

            /// <summary>See your personal info, including any personal info you've made publicly available</summary>
            public static string UserinfoProfile = "https://www.googleapis.com/auth/userinfo.profile";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the People API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, download, and permanently delete your contacts</summary>
            public const string Contacts = "https://www.googleapis.com/auth/contacts";

            /// <summary>See and download contact info automatically saved in your "Other contacts"</summary>
            public const string ContactsOtherReadonly = "https://www.googleapis.com/auth/contacts.other.readonly";

            /// <summary>See and download your contacts</summary>
            public const string ContactsReadonly = "https://www.googleapis.com/auth/contacts.readonly";

            /// <summary>See and download your organization's GSuite directory</summary>
            public const string DirectoryReadonly = "https://www.googleapis.com/auth/directory.readonly";

            /// <summary>View your street addresses</summary>
            public const string UserAddressesRead = "https://www.googleapis.com/auth/user.addresses.read";

            /// <summary>See and download your exact date of birth</summary>
            public const string UserBirthdayRead = "https://www.googleapis.com/auth/user.birthday.read";

            /// <summary>See and download all of your Google Account email addresses</summary>
            public const string UserEmailsRead = "https://www.googleapis.com/auth/user.emails.read";

            /// <summary>See your gender</summary>
            public const string UserGenderRead = "https://www.googleapis.com/auth/user.gender.read";

            /// <summary>See your education, work history and org info</summary>
            public const string UserOrganizationRead = "https://www.googleapis.com/auth/user.organization.read";

            /// <summary>See and download your personal phone numbers</summary>
            public const string UserPhonenumbersRead = "https://www.googleapis.com/auth/user.phonenumbers.read";

            /// <summary>See your primary Google Account email address</summary>
            public const string UserinfoEmail = "https://www.googleapis.com/auth/userinfo.email";

            /// <summary>See your personal info, including any personal info you've made publicly available</summary>
            public const string UserinfoProfile = "https://www.googleapis.com/auth/userinfo.profile";
        }

        /// <summary>Gets the ContactGroups resource.</summary>
        public virtual ContactGroupsResource ContactGroups { get; }

        /// <summary>Gets the OtherContacts resource.</summary>
        public virtual OtherContactsResource OtherContacts { get; }

        /// <summary>Gets the People resource.</summary>
        public virtual PeopleResource People { get; }
    }

    /// <summary>A base abstract class for PeopleService requests.</summary>
    public abstract class PeopleServiceBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new PeopleServiceBaseServiceRequest instance.</summary>
        protected PeopleServiceBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes PeopleService parameter list.</summary>
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

    /// <summary>The "contactGroups" collection of methods.</summary>
    public class ContactGroupsResource
    {
        private const string Resource = "contactGroups";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ContactGroupsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Members = new MembersResource(service);
        }

        /// <summary>Gets the Members resource.</summary>
        public virtual MembersResource Members { get; }

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

            /// <summary>
            /// Modify the members of a contact group owned by the authenticated user. The only system contact groups
            /// that can have members added are `contactGroups/myContacts` and `contactGroups/starred`. Other system
            /// contact groups are deprecated and can only have contacts removed.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resourceName">Required. The resource name of the contact group to modify.</param>
            public virtual ModifyRequest Modify(Google.Apis.PeopleService.v1.Data.ModifyContactGroupMembersRequest body, string resourceName)
            {
                return new ModifyRequest(this.service, body, resourceName);
            }

            /// <summary>
            /// Modify the members of a contact group owned by the authenticated user. The only system contact groups
            /// that can have members added are `contactGroups/myContacts` and `contactGroups/starred`. Other system
            /// contact groups are deprecated and can only have contacts removed.
            /// </summary>
            public class ModifyRequest : PeopleServiceBaseServiceRequest<Google.Apis.PeopleService.v1.Data.ModifyContactGroupMembersResponse>
            {
                /// <summary>Constructs a new Modify request.</summary>
                public ModifyRequest(Google.Apis.Services.IClientService service, Google.Apis.PeopleService.v1.Data.ModifyContactGroupMembersRequest body, string resourceName) : base(service)
                {
                    ResourceName = resourceName;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The resource name of the contact group to modify.</summary>
                [Google.Apis.Util.RequestParameterAttribute("resourceName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ResourceName { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.PeopleService.v1.Data.ModifyContactGroupMembersRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "modify";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+resourceName}/members:modify";

                /// <summary>Initializes Modify parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("resourceName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resourceName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^contactGroups/[^/]+$",
                    });
                }
            }
        }

        /// <summary>
        /// Get a list of contact groups owned by the authenticated user by specifying a list of contact group resource
        /// names.
        /// </summary>
        public virtual BatchGetRequest BatchGet()
        {
            return new BatchGetRequest(this.service);
        }

        /// <summary>
        /// Get a list of contact groups owned by the authenticated user by specifying a list of contact group resource
        /// names.
        /// </summary>
        public class BatchGetRequest : PeopleServiceBaseServiceRequest<Google.Apis.PeopleService.v1.Data.BatchGetContactGroupsResponse>
        {
            /// <summary>Constructs a new BatchGet request.</summary>
            public BatchGetRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional. A field mask to restrict which fields on the group are returned. Defaults to `metadata`,
            /// `groupType`, `memberCount`, and `name` if not set or set to empty. Valid fields are: * clientData *
            /// groupType * memberCount * metadata * name
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("groupFields", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object GroupFields { get; set; }

            /// <summary>
            /// Optional. Specifies the maximum number of members to return for each group. Defaults to 0 if not set,
            /// which will return zero members.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxMembers", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxMembers { get; set; }

            /// <summary>
            /// Required. The resource names of the contact groups to get. There is a maximum of 200 resource names.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceNames", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> ResourceNames { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "batchGet";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/contactGroups:batchGet";

            /// <summary>Initializes BatchGet parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("groupFields", new Google.Apis.Discovery.Parameter
                {
                    Name = "groupFields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxMembers", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxMembers",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("resourceNames", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceNames",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Create a new contact group owned by the authenticated user. Created contact group names must be unique to
        /// the users contact groups. Attempting to create a group with a duplicate name will return a HTTP 409 error.
        /// Mutate requests for the same user should be sent sequentially to avoid increased latency and failures.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.PeopleService.v1.Data.CreateContactGroupRequest body)
        {
            return new CreateRequest(this.service, body);
        }

        /// <summary>
        /// Create a new contact group owned by the authenticated user. Created contact group names must be unique to
        /// the users contact groups. Attempting to create a group with a duplicate name will return a HTTP 409 error.
        /// Mutate requests for the same user should be sent sequentially to avoid increased latency and failures.
        /// </summary>
        public class CreateRequest : PeopleServiceBaseServiceRequest<Google.Apis.PeopleService.v1.Data.ContactGroup>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.PeopleService.v1.Data.CreateContactGroupRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.PeopleService.v1.Data.CreateContactGroupRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/contactGroups";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Delete an existing contact group owned by the authenticated user by specifying a contact group resource
        /// name. Mutate requests for the same user should be sent sequentially to avoid increased latency and failures.
        /// </summary>
        /// <param name="resourceName">Required. The resource name of the contact group to delete.</param>
        public virtual DeleteRequest Delete(string resourceName)
        {
            return new DeleteRequest(this.service, resourceName);
        }

        /// <summary>
        /// Delete an existing contact group owned by the authenticated user by specifying a contact group resource
        /// name. Mutate requests for the same user should be sent sequentially to avoid increased latency and failures.
        /// </summary>
        public class DeleteRequest : PeopleServiceBaseServiceRequest<Google.Apis.PeopleService.v1.Data.Empty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string resourceName) : base(service)
            {
                ResourceName = resourceName;
                InitParameters();
            }

            /// <summary>Required. The resource name of the contact group to delete.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceName { get; private set; }

            /// <summary>Optional. Set to true to also delete the contacts in the specified group.</summary>
            [Google.Apis.Util.RequestParameterAttribute("deleteContacts", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> DeleteContacts { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+resourceName}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceName", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^contactGroups/[^/]+$",
                });
                RequestParameters.Add("deleteContacts", new Google.Apis.Discovery.Parameter
                {
                    Name = "deleteContacts",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Get a specific contact group owned by the authenticated user by specifying a contact group resource name.
        /// </summary>
        /// <param name="resourceName">Required. The resource name of the contact group to get.</param>
        public virtual GetRequest Get(string resourceName)
        {
            return new GetRequest(this.service, resourceName);
        }

        /// <summary>
        /// Get a specific contact group owned by the authenticated user by specifying a contact group resource name.
        /// </summary>
        public class GetRequest : PeopleServiceBaseServiceRequest<Google.Apis.PeopleService.v1.Data.ContactGroup>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string resourceName) : base(service)
            {
                ResourceName = resourceName;
                InitParameters();
            }

            /// <summary>Required. The resource name of the contact group to get.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceName { get; private set; }

            /// <summary>
            /// Optional. A field mask to restrict which fields on the group are returned. Defaults to `metadata`,
            /// `groupType`, `memberCount`, and `name` if not set or set to empty. Valid fields are: * clientData *
            /// groupType * memberCount * metadata * name
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("groupFields", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object GroupFields { get; set; }

            /// <summary>
            /// Optional. Specifies the maximum number of members to return. Defaults to 0 if not set, which will return
            /// zero members.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxMembers", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxMembers { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+resourceName}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceName", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^contactGroups/[^/]+$",
                });
                RequestParameters.Add("groupFields", new Google.Apis.Discovery.Parameter
                {
                    Name = "groupFields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxMembers", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxMembers",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// List all contact groups owned by the authenticated user. Members of the contact groups are not populated.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>
        /// List all contact groups owned by the authenticated user. Members of the contact groups are not populated.
        /// </summary>
        public class ListRequest : PeopleServiceBaseServiceRequest<Google.Apis.PeopleService.v1.Data.ListContactGroupsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional. A field mask to restrict which fields on the group are returned. Defaults to `metadata`,
            /// `groupType`, `memberCount`, and `name` if not set or set to empty. Valid fields are: * clientData *
            /// groupType * memberCount * metadata * name
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("groupFields", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object GroupFields { get; set; }

            /// <summary>
            /// Optional. The maximum number of resources to return. Valid values are between 1 and 1000, inclusive.
            /// Defaults to 30 if not set or set to 0.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. The next_page_token value returned from a previous call to
            /// [ListContactGroups](/people/api/rest/v1/contactgroups/list). Requests the next page of resources.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Optional. A sync token, returned by a previous call to `contactgroups.list`. Only resources changed
            /// since the sync token was created will be returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("syncToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string SyncToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/contactGroups";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("groupFields", new Google.Apis.Discovery.Parameter
                {
                    Name = "groupFields",
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
                RequestParameters.Add("syncToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "syncToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Update the name of an existing contact group owned by the authenticated user. Updated contact group names
        /// must be unique to the users contact groups. Attempting to create a group with a duplicate name will return a
        /// HTTP 409 error. Mutate requests for the same user should be sent sequentially to avoid increased latency and
        /// failures.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceName">
        /// The resource name for the contact group, assigned by the server. An ASCII string, in the form of
        /// `contactGroups/{contact_group_id}`.
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.PeopleService.v1.Data.UpdateContactGroupRequest body, string resourceName)
        {
            return new UpdateRequest(this.service, body, resourceName);
        }

        /// <summary>
        /// Update the name of an existing contact group owned by the authenticated user. Updated contact group names
        /// must be unique to the users contact groups. Attempting to create a group with a duplicate name will return a
        /// HTTP 409 error. Mutate requests for the same user should be sent sequentially to avoid increased latency and
        /// failures.
        /// </summary>
        public class UpdateRequest : PeopleServiceBaseServiceRequest<Google.Apis.PeopleService.v1.Data.ContactGroup>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.PeopleService.v1.Data.UpdateContactGroupRequest body, string resourceName) : base(service)
            {
                ResourceName = resourceName;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name for the contact group, assigned by the server. An ASCII string, in the form of
            /// `contactGroups/{contact_group_id}`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceName { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.PeopleService.v1.Data.UpdateContactGroupRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+resourceName}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceName", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^contactGroups/[^/]+$",
                });
            }
        }
    }

    /// <summary>The "otherContacts" collection of methods.</summary>
    public class OtherContactsResource
    {
        private const string Resource = "otherContacts";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public OtherContactsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Copies an "Other contact" to a new contact in the user's "myContacts" group Mutate requests for the same
        /// user should be sent sequentially to avoid increased latency and failures.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceName">Required. The resource name of the "Other contact" to copy.</param>
        public virtual CopyOtherContactToMyContactsGroupRequest CopyOtherContactToMyContactsGroup(Google.Apis.PeopleService.v1.Data.CopyOtherContactToMyContactsGroupRequest body, string resourceName)
        {
            return new CopyOtherContactToMyContactsGroupRequest(this.service, body, resourceName);
        }

        /// <summary>
        /// Copies an "Other contact" to a new contact in the user's "myContacts" group Mutate requests for the same
        /// user should be sent sequentially to avoid increased latency and failures.
        /// </summary>
        public class CopyOtherContactToMyContactsGroupRequest : PeopleServiceBaseServiceRequest<Google.Apis.PeopleService.v1.Data.Person>
        {
            /// <summary>Constructs a new CopyOtherContactToMyContactsGroup request.</summary>
            public CopyOtherContactToMyContactsGroupRequest(Google.Apis.Services.IClientService service, Google.Apis.PeopleService.v1.Data.CopyOtherContactToMyContactsGroupRequest body, string resourceName) : base(service)
            {
                ResourceName = resourceName;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The resource name of the "Other contact" to copy.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceName { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.PeopleService.v1.Data.CopyOtherContactToMyContactsGroupRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "copyOtherContactToMyContactsGroup";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+resourceName}:copyOtherContactToMyContactsGroup";

            /// <summary>Initializes CopyOtherContactToMyContactsGroup parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceName", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^otherContacts/[^/]+$",
                });
            }
        }

        /// <summary>
        /// List all "Other contacts", that is contacts that are not in a contact group. "Other contacts" are typically
        /// auto created contacts from interactions. Sync tokens expire 7 days after the full sync. A request with an
        /// expired sync token will get an error with an
        /// [google.rpc.ErrorInfo](https://cloud.google.com/apis/design/errors#error_info) with reason
        /// "EXPIRED_SYNC_TOKEN". In the case of such an error clients should make a full sync request without a
        /// `sync_token`. The first page of a full sync request has an additional quota. If the quota is exceeded, a 429
        /// error will be returned. This quota is fixed and can not be increased. When the `sync_token` is specified,
        /// resources deleted since the last sync will be returned as a person with `PersonMetadata.deleted` set to
        /// true. When the `page_token` or `sync_token` is specified, all other request parameters must match the first
        /// call. Writes may have a propagation delay of several minutes for sync requests. Incremental syncs are not
        /// intended for read-after-write use cases. See example usage at [List the user's other contacts that have
        /// changed](/people/v1/other-contacts#list_the_users_other_contacts_that_have_changed).
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>
        /// List all "Other contacts", that is contacts that are not in a contact group. "Other contacts" are typically
        /// auto created contacts from interactions. Sync tokens expire 7 days after the full sync. A request with an
        /// expired sync token will get an error with an
        /// [google.rpc.ErrorInfo](https://cloud.google.com/apis/design/errors#error_info) with reason
        /// "EXPIRED_SYNC_TOKEN". In the case of such an error clients should make a full sync request without a
        /// `sync_token`. The first page of a full sync request has an additional quota. If the quota is exceeded, a 429
        /// error will be returned. This quota is fixed and can not be increased. When the `sync_token` is specified,
        /// resources deleted since the last sync will be returned as a person with `PersonMetadata.deleted` set to
        /// true. When the `page_token` or `sync_token` is specified, all other request parameters must match the first
        /// call. Writes may have a propagation delay of several minutes for sync requests. Incremental syncs are not
        /// intended for read-after-write use cases. See example usage at [List the user's other contacts that have
        /// changed](/people/v1/other-contacts#list_the_users_other_contacts_that_have_changed).
        /// </summary>
        public class ListRequest : PeopleServiceBaseServiceRequest<Google.Apis.PeopleService.v1.Data.ListOtherContactsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional. The number of "Other contacts" to include in the response. Valid values are between 1 and
            /// 1000, inclusive. Defaults to 100 if not set or set to 0.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. A page token, received from a previous response `next_page_token`. Provide this to retrieve
            /// the subsequent page. When paginating, all other parameters provided to `otherContacts.list` must match
            /// the first call that provided the page token.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Required. A field mask to restrict which fields on each person are returned. Multiple fields can be
            /// specified by separating them with commas. What values are valid depend on what ReadSourceType is used.
            /// If READ_SOURCE_TYPE_CONTACT is used, valid values are: * emailAddresses * metadata * names *
            /// phoneNumbers * photos If READ_SOURCE_TYPE_PROFILE is used, valid values are: * addresses * ageRanges *
            /// biographies * birthdays * calendarUrls * clientData * coverPhotos * emailAddresses * events *
            /// externalIds * genders * imClients * interests * locales * locations * memberships * metadata *
            /// miscKeywords * names * nicknames * occupations * organizations * phoneNumbers * photos * relations *
            /// sipAddresses * skills * urls * userDefined
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("readMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object ReadMask { get; set; }

            /// <summary>
            /// Optional. Whether the response should return `next_sync_token` on the last page of results. It can be
            /// used to get incremental changes since the last request by setting it on the request `sync_token`. More
            /// details about sync behavior at `otherContacts.list`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("requestSyncToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> RequestSyncToken { get; set; }

            /// <summary>
            /// Optional. A mask of what source types to return. Defaults to READ_SOURCE_TYPE_CONTACT if not set.
            /// Possible values for this field are: * READ_SOURCE_TYPE_CONTACT *
            /// READ_SOURCE_TYPE_CONTACT,READ_SOURCE_TYPE_PROFILE Specifying READ_SOURCE_TYPE_PROFILE without specifying
            /// READ_SOURCE_TYPE_CONTACT is not permitted.
            /// </summary>
            /// <remarks>
            /// Use this property to set a single value for the parameter, or <see cref="SourcesList"/> to set multiple
            /// values. Do not set both properties.
            /// </remarks>
            [Google.Apis.Util.RequestParameterAttribute("sources", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<SourcesEnum> Sources { get; set; }

            /// <summary>
            /// Optional. A mask of what source types to return. Defaults to READ_SOURCE_TYPE_CONTACT if not set.
            /// Possible values for this field are: * READ_SOURCE_TYPE_CONTACT *
            /// READ_SOURCE_TYPE_CONTACT,READ_SOURCE_TYPE_PROFILE Specifying READ_SOURCE_TYPE_PROFILE without specifying
            /// READ_SOURCE_TYPE_CONTACT is not permitted.
            /// </summary>
            /// <remarks>
            /// Use this property to set one or more values for the parameter. Do not set both this property and
            /// <see cref="Sources"/>.
            /// </remarks>
            [Google.Apis.Util.RequestParameterAttribute("sources", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<SourcesEnum> SourcesList { get; set; }

            /// <summary>
            /// Optional. A mask of what source types to return. Defaults to READ_SOURCE_TYPE_CONTACT if not set.
            /// Possible values for this field are: * READ_SOURCE_TYPE_CONTACT *
            /// READ_SOURCE_TYPE_CONTACT,READ_SOURCE_TYPE_PROFILE Specifying READ_SOURCE_TYPE_PROFILE without specifying
            /// READ_SOURCE_TYPE_CONTACT is not permitted.
            /// </summary>
            public enum SourcesEnum
            {
                /// <summary>Unspecified.</summary>
                [Google.Apis.Util.StringValueAttribute("READ_SOURCE_TYPE_UNSPECIFIED")]
                READSOURCETYPEUNSPECIFIED = 0,

                /// <summary>Returns SourceType.ACCOUNT, SourceType.DOMAIN_PROFILE, and SourceType.PROFILE.</summary>
                [Google.Apis.Util.StringValueAttribute("READ_SOURCE_TYPE_PROFILE")]
                READSOURCETYPEPROFILE = 1,

                /// <summary>Returns SourceType.CONTACT.</summary>
                [Google.Apis.Util.StringValueAttribute("READ_SOURCE_TYPE_CONTACT")]
                READSOURCETYPECONTACT = 2,

                /// <summary>Returns SourceType.DOMAIN_CONTACT.</summary>
                [Google.Apis.Util.StringValueAttribute("READ_SOURCE_TYPE_DOMAIN_CONTACT")]
                READSOURCETYPEDOMAINCONTACT = 3,

                /// <summary>Returns SourceType.OTHER_CONTACT.</summary>
                [Google.Apis.Util.StringValueAttribute("READ_SOURCE_TYPE_OTHER_CONTACT")]
                READSOURCETYPEOTHERCONTACT = 4,
            }

            /// <summary>
            /// Optional. A sync token, received from a previous response `next_sync_token` Provide this to retrieve
            /// only the resources changed since the last request. When syncing, all other parameters provided to
            /// `otherContacts.list` must match the first call that provided the sync token. More details about sync
            /// behavior at `otherContacts.list`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("syncToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string SyncToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/otherContacts";

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
                RequestParameters.Add("readMask", new Google.Apis.Discovery.Parameter
                {
                    Name = "readMask",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("requestSyncToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "requestSyncToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sources", new Google.Apis.Discovery.Parameter
                {
                    Name = "sources",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("syncToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "syncToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Provides a list of contacts in the authenticated user's other contacts that matches the search query. The
        /// query matches on a contact's `names`, `emailAddresses`, and `phoneNumbers` fields that are from the
        /// OTHER_CONTACT source. **IMPORTANT**: Before searching, clients should send a warmup request with an empty
        /// query to update the cache. See
        /// https://developers.google.com/people/v1/other-contacts#search_the_users_other_contacts
        /// </summary>
        public virtual SearchRequest Search()
        {
            return new SearchRequest(this.service);
        }

        /// <summary>
        /// Provides a list of contacts in the authenticated user's other contacts that matches the search query. The
        /// query matches on a contact's `names`, `emailAddresses`, and `phoneNumbers` fields that are from the
        /// OTHER_CONTACT source. **IMPORTANT**: Before searching, clients should send a warmup request with an empty
        /// query to update the cache. See
        /// https://developers.google.com/people/v1/other-contacts#search_the_users_other_contacts
        /// </summary>
        public class SearchRequest : PeopleServiceBaseServiceRequest<Google.Apis.PeopleService.v1.Data.SearchResponse>
        {
            /// <summary>Constructs a new Search request.</summary>
            public SearchRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional. The number of results to return. Defaults to 10 if field is not set, or set to 0. Values
            /// greater than 30 will be capped to 30.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Required. The plain-text query for the request. The query is used to match prefix phrases of the fields
            /// on a person. For example, a person with name "foo name" matches queries such as "f", "fo", "foo", "foo
            /// n", "nam", etc., but not "oo n".
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query { get; set; }

            /// <summary>
            /// Required. A field mask to restrict which fields on each person are returned. Multiple fields can be
            /// specified by separating them with commas. Valid values are: * emailAddresses * metadata * names *
            /// phoneNumbers
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("readMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object ReadMask { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "search";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/otherContacts:search";

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
                RequestParameters.Add("query", new Google.Apis.Discovery.Parameter
                {
                    Name = "query",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("readMask", new Google.Apis.Discovery.Parameter
                {
                    Name = "readMask",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "people" collection of methods.</summary>
    public class PeopleResource
    {
        private const string Resource = "people";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PeopleResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Connections = new ConnectionsResource(service);
        }

        /// <summary>Gets the Connections resource.</summary>
        public virtual ConnectionsResource Connections { get; }

        /// <summary>The "connections" collection of methods.</summary>
        public class ConnectionsResource
        {
            private const string Resource = "connections";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ConnectionsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Provides a list of the authenticated user's contacts. Sync tokens expire 7 days after the full sync. A
            /// request with an expired sync token will get an error with an
            /// [google.rpc.ErrorInfo](https://cloud.google.com/apis/design/errors#error_info) with reason
            /// "EXPIRED_SYNC_TOKEN". In the case of such an error clients should make a full sync request without a
            /// `sync_token`. The first page of a full sync request has an additional quota. If the quota is exceeded, a
            /// 429 error will be returned. This quota is fixed and can not be increased. When the `sync_token` is
            /// specified, resources deleted since the last sync will be returned as a person with
            /// `PersonMetadata.deleted` set to true. When the `page_token` or `sync_token` is specified, all other
            /// request parameters must match the first call. Writes may have a propagation delay of several minutes for
            /// sync requests. Incremental syncs are not intended for read-after-write use cases. See example usage at
            /// [List the user's contacts that have
            /// changed](/people/v1/contacts#list_the_users_contacts_that_have_changed).
            /// </summary>
            /// <param name="resourceName">
            /// Required. The resource name to return connections for. Only `people/me` is valid.
            /// </param>
            public virtual ListRequest List(string resourceName)
            {
                return new ListRequest(this.service, resourceName);
            }

            /// <summary>
            /// Provides a list of the authenticated user's contacts. Sync tokens expire 7 days after the full sync. A
            /// request with an expired sync token will get an error with an
            /// [google.rpc.ErrorInfo](https://cloud.google.com/apis/design/errors#error_info) with reason
            /// "EXPIRED_SYNC_TOKEN". In the case of such an error clients should make a full sync request without a
            /// `sync_token`. The first page of a full sync request has an additional quota. If the quota is exceeded, a
            /// 429 error will be returned. This quota is fixed and can not be increased. When the `sync_token` is
            /// specified, resources deleted since the last sync will be returned as a person with
            /// `PersonMetadata.deleted` set to true. When the `page_token` or `sync_token` is specified, all other
            /// request parameters must match the first call. Writes may have a propagation delay of several minutes for
            /// sync requests. Incremental syncs are not intended for read-after-write use cases. See example usage at
            /// [List the user's contacts that have
            /// changed](/people/v1/contacts#list_the_users_contacts_that_have_changed).
            /// </summary>
            public class ListRequest : PeopleServiceBaseServiceRequest<Google.Apis.PeopleService.v1.Data.ListConnectionsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string resourceName) : base(service)
                {
                    ResourceName = resourceName;
                    InitParameters();
                }

                /// <summary>Required. The resource name to return connections for. Only `people/me` is valid.</summary>
                [Google.Apis.Util.RequestParameterAttribute("resourceName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ResourceName { get; private set; }

                /// <summary>
                /// Optional. The number of connections to include in the response. Valid values are between 1 and 1000,
                /// inclusive. Defaults to 100 if not set or set to 0.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A page token, received from a previous response `next_page_token`. Provide this to
                /// retrieve the subsequent page. When paginating, all other parameters provided to
                /// `people.connections.list` must match the first call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// Required. A field mask to restrict which fields on each person are returned. Multiple fields can be
                /// specified by separating them with commas. Valid values are: * addresses * ageRanges * biographies *
                /// birthdays * calendarUrls * clientData * coverPhotos * emailAddresses * events * externalIds *
                /// genders * imClients * interests * locales * locations * memberships * metadata * miscKeywords *
                /// names * nicknames * occupations * organizations * phoneNumbers * photos * relations * sipAddresses *
                /// skills * urls * userDefined
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("personFields", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object PersonFields { get; set; }

                /// <summary>
                /// Required. Comma-separated list of person fields to be included in the response. Each path should
                /// start with `person.`: for example, `person.names` or `person.photos`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("requestMask.includeField", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object RequestMaskIncludeField { get; set; }

                /// <summary>
                /// Optional. Whether the response should return `next_sync_token` on the last page of results. It can
                /// be used to get incremental changes since the last request by setting it on the request `sync_token`.
                /// More details about sync behavior at `people.connections.list`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("requestSyncToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> RequestSyncToken { get; set; }

                /// <summary>
                /// Optional. The order in which the connections should be sorted. Defaults to
                /// `LAST_MODIFIED_ASCENDING`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("sortOrder", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<SortOrderEnum> SortOrder { get; set; }

                /// <summary>
                /// Optional. The order in which the connections should be sorted. Defaults to
                /// `LAST_MODIFIED_ASCENDING`.
                /// </summary>
                public enum SortOrderEnum
                {
                    /// <summary>Sort people by when they were changed; older entries first.</summary>
                    [Google.Apis.Util.StringValueAttribute("LAST_MODIFIED_ASCENDING")]
                    LASTMODIFIEDASCENDING = 0,

                    /// <summary>Sort people by when they were changed; newer entries first.</summary>
                    [Google.Apis.Util.StringValueAttribute("LAST_MODIFIED_DESCENDING")]
                    LASTMODIFIEDDESCENDING = 1,

                    /// <summary>Sort people by first name.</summary>
                    [Google.Apis.Util.StringValueAttribute("FIRST_NAME_ASCENDING")]
                    FIRSTNAMEASCENDING = 2,

                    /// <summary>Sort people by last name.</summary>
                    [Google.Apis.Util.StringValueAttribute("LAST_NAME_ASCENDING")]
                    LASTNAMEASCENDING = 3,
                }

                /// <summary>
                /// Optional. A mask of what source types to return. Defaults to READ_SOURCE_TYPE_CONTACT and
                /// READ_SOURCE_TYPE_PROFILE if not set.
                /// </summary>
                /// <remarks>
                /// Use this property to set a single value for the parameter, or <see cref="SourcesList"/> to set
                /// multiple values. Do not set both properties.
                /// </remarks>
                [Google.Apis.Util.RequestParameterAttribute("sources", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<SourcesEnum> Sources { get; set; }

                /// <summary>
                /// Optional. A mask of what source types to return. Defaults to READ_SOURCE_TYPE_CONTACT and
                /// READ_SOURCE_TYPE_PROFILE if not set.
                /// </summary>
                /// <remarks>
                /// Use this property to set one or more values for the parameter. Do not set both this property and
                /// <see cref="Sources"/>.
                /// </remarks>
                [Google.Apis.Util.RequestParameterAttribute("sources", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<SourcesEnum> SourcesList { get; set; }

                /// <summary>
                /// Optional. A mask of what source types to return. Defaults to READ_SOURCE_TYPE_CONTACT and
                /// READ_SOURCE_TYPE_PROFILE if not set.
                /// </summary>
                public enum SourcesEnum
                {
                    /// <summary>Unspecified.</summary>
                    [Google.Apis.Util.StringValueAttribute("READ_SOURCE_TYPE_UNSPECIFIED")]
                    READSOURCETYPEUNSPECIFIED = 0,

                    /// <summary>
                    /// Returns SourceType.ACCOUNT, SourceType.DOMAIN_PROFILE, and SourceType.PROFILE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("READ_SOURCE_TYPE_PROFILE")]
                    READSOURCETYPEPROFILE = 1,

                    /// <summary>Returns SourceType.CONTACT.</summary>
                    [Google.Apis.Util.StringValueAttribute("READ_SOURCE_TYPE_CONTACT")]
                    READSOURCETYPECONTACT = 2,

                    /// <summary>Returns SourceType.DOMAIN_CONTACT.</summary>
                    [Google.Apis.Util.StringValueAttribute("READ_SOURCE_TYPE_DOMAIN_CONTACT")]
                    READSOURCETYPEDOMAINCONTACT = 3,

                    /// <summary>Returns SourceType.OTHER_CONTACT.</summary>
                    [Google.Apis.Util.StringValueAttribute("READ_SOURCE_TYPE_OTHER_CONTACT")]
                    READSOURCETYPEOTHERCONTACT = 4,
                }

                /// <summary>
                /// Optional. A sync token, received from a previous response `next_sync_token` Provide this to retrieve
                /// only the resources changed since the last request. When syncing, all other parameters provided to
                /// `people.connections.list` must match the first call that provided the sync token. More details about
                /// sync behavior at `people.connections.list`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("syncToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string SyncToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+resourceName}/connections";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("resourceName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resourceName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^people/[^/]+$",
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
                    RequestParameters.Add("personFields", new Google.Apis.Discovery.Parameter
                    {
                        Name = "personFields",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("requestMask.includeField", new Google.Apis.Discovery.Parameter
                    {
                        Name = "requestMask.includeField",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("requestSyncToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "requestSyncToken",
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
                    RequestParameters.Add("sources", new Google.Apis.Discovery.Parameter
                    {
                        Name = "sources",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("syncToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "syncToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>
        /// Create a batch of new contacts and return the PersonResponses for the newly Mutate requests for the same
        /// user should be sent sequentially to avoid increased latency and failures.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual BatchCreateContactsRequest BatchCreateContacts(Google.Apis.PeopleService.v1.Data.BatchCreateContactsRequest body)
        {
            return new BatchCreateContactsRequest(this.service, body);
        }

        /// <summary>
        /// Create a batch of new contacts and return the PersonResponses for the newly Mutate requests for the same
        /// user should be sent sequentially to avoid increased latency and failures.
        /// </summary>
        public class BatchCreateContactsRequest : PeopleServiceBaseServiceRequest<Google.Apis.PeopleService.v1.Data.BatchCreateContactsResponse>
        {
            /// <summary>Constructs a new BatchCreateContacts request.</summary>
            public BatchCreateContactsRequest(Google.Apis.Services.IClientService service, Google.Apis.PeopleService.v1.Data.BatchCreateContactsRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.PeopleService.v1.Data.BatchCreateContactsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "batchCreateContacts";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/people:batchCreateContacts";

            /// <summary>Initializes BatchCreateContacts parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Delete a batch of contacts. Any non-contact data will not be deleted. Mutate requests for the same user
        /// should be sent sequentially to avoid increased latency and failures.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual BatchDeleteContactsRequest BatchDeleteContacts(Google.Apis.PeopleService.v1.Data.BatchDeleteContactsRequest body)
        {
            return new BatchDeleteContactsRequest(this.service, body);
        }

        /// <summary>
        /// Delete a batch of contacts. Any non-contact data will not be deleted. Mutate requests for the same user
        /// should be sent sequentially to avoid increased latency and failures.
        /// </summary>
        public class BatchDeleteContactsRequest : PeopleServiceBaseServiceRequest<Google.Apis.PeopleService.v1.Data.Empty>
        {
            /// <summary>Constructs a new BatchDeleteContacts request.</summary>
            public BatchDeleteContactsRequest(Google.Apis.Services.IClientService service, Google.Apis.PeopleService.v1.Data.BatchDeleteContactsRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.PeopleService.v1.Data.BatchDeleteContactsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "batchDeleteContacts";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/people:batchDeleteContacts";

            /// <summary>Initializes BatchDeleteContacts parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Update a batch of contacts and return a map of resource names to PersonResponses for the updated contacts.
        /// Mutate requests for the same user should be sent sequentially to avoid increased latency and failures.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual BatchUpdateContactsRequest BatchUpdateContacts(Google.Apis.PeopleService.v1.Data.BatchUpdateContactsRequest body)
        {
            return new BatchUpdateContactsRequest(this.service, body);
        }

        /// <summary>
        /// Update a batch of contacts and return a map of resource names to PersonResponses for the updated contacts.
        /// Mutate requests for the same user should be sent sequentially to avoid increased latency and failures.
        /// </summary>
        public class BatchUpdateContactsRequest : PeopleServiceBaseServiceRequest<Google.Apis.PeopleService.v1.Data.BatchUpdateContactsResponse>
        {
            /// <summary>Constructs a new BatchUpdateContacts request.</summary>
            public BatchUpdateContactsRequest(Google.Apis.Services.IClientService service, Google.Apis.PeopleService.v1.Data.BatchUpdateContactsRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.PeopleService.v1.Data.BatchUpdateContactsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "batchUpdateContacts";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/people:batchUpdateContacts";

            /// <summary>Initializes BatchUpdateContacts parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Create a new contact and return the person resource for that contact. The request returns a 400 error if
        /// more than one field is specified on a field that is a singleton for contact sources: * biographies *
        /// birthdays * genders * names Mutate requests for the same user should be sent sequentially to avoid increased
        /// latency and failures.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateContactRequest CreateContact(Google.Apis.PeopleService.v1.Data.Person body)
        {
            return new CreateContactRequest(this.service, body);
        }

        /// <summary>
        /// Create a new contact and return the person resource for that contact. The request returns a 400 error if
        /// more than one field is specified on a field that is a singleton for contact sources: * biographies *
        /// birthdays * genders * names Mutate requests for the same user should be sent sequentially to avoid increased
        /// latency and failures.
        /// </summary>
        public class CreateContactRequest : PeopleServiceBaseServiceRequest<Google.Apis.PeopleService.v1.Data.Person>
        {
            /// <summary>Constructs a new CreateContact request.</summary>
            public CreateContactRequest(Google.Apis.Services.IClientService service, Google.Apis.PeopleService.v1.Data.Person body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. A field mask to restrict which fields on each person are returned. Multiple fields can be
            /// specified by separating them with commas. Defaults to all fields if not set. Valid values are: *
            /// addresses * ageRanges * biographies * birthdays * calendarUrls * clientData * coverPhotos *
            /// emailAddresses * events * externalIds * genders * imClients * interests * locales * locations *
            /// memberships * metadata * miscKeywords * names * nicknames * occupations * organizations * phoneNumbers *
            /// photos * relations * sipAddresses * skills * urls * userDefined
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("personFields", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object PersonFields { get; set; }

            /// <summary>
            /// Optional. A mask of what source types to return. Defaults to READ_SOURCE_TYPE_CONTACT and
            /// READ_SOURCE_TYPE_PROFILE if not set.
            /// </summary>
            /// <remarks>
            /// Use this property to set a single value for the parameter, or <see cref="SourcesList"/> to set multiple
            /// values. Do not set both properties.
            /// </remarks>
            [Google.Apis.Util.RequestParameterAttribute("sources", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<SourcesEnum> Sources { get; set; }

            /// <summary>
            /// Optional. A mask of what source types to return. Defaults to READ_SOURCE_TYPE_CONTACT and
            /// READ_SOURCE_TYPE_PROFILE if not set.
            /// </summary>
            /// <remarks>
            /// Use this property to set one or more values for the parameter. Do not set both this property and
            /// <see cref="Sources"/>.
            /// </remarks>
            [Google.Apis.Util.RequestParameterAttribute("sources", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<SourcesEnum> SourcesList { get; set; }

            /// <summary>
            /// Optional. A mask of what source types to return. Defaults to READ_SOURCE_TYPE_CONTACT and
            /// READ_SOURCE_TYPE_PROFILE if not set.
            /// </summary>
            public enum SourcesEnum
            {
                /// <summary>Unspecified.</summary>
                [Google.Apis.Util.StringValueAttribute("READ_SOURCE_TYPE_UNSPECIFIED")]
                READSOURCETYPEUNSPECIFIED = 0,

                /// <summary>Returns SourceType.ACCOUNT, SourceType.DOMAIN_PROFILE, and SourceType.PROFILE.</summary>
                [Google.Apis.Util.StringValueAttribute("READ_SOURCE_TYPE_PROFILE")]
                READSOURCETYPEPROFILE = 1,

                /// <summary>Returns SourceType.CONTACT.</summary>
                [Google.Apis.Util.StringValueAttribute("READ_SOURCE_TYPE_CONTACT")]
                READSOURCETYPECONTACT = 2,

                /// <summary>Returns SourceType.DOMAIN_CONTACT.</summary>
                [Google.Apis.Util.StringValueAttribute("READ_SOURCE_TYPE_DOMAIN_CONTACT")]
                READSOURCETYPEDOMAINCONTACT = 3,

                /// <summary>Returns SourceType.OTHER_CONTACT.</summary>
                [Google.Apis.Util.StringValueAttribute("READ_SOURCE_TYPE_OTHER_CONTACT")]
                READSOURCETYPEOTHERCONTACT = 4,
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.PeopleService.v1.Data.Person Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "createContact";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/people:createContact";

            /// <summary>Initializes CreateContact parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("personFields", new Google.Apis.Discovery.Parameter
                {
                    Name = "personFields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sources", new Google.Apis.Discovery.Parameter
                {
                    Name = "sources",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Delete a contact person. Any non-contact data will not be deleted. Mutate requests for the same user should
        /// be sent sequentially to avoid increased latency and failures.
        /// </summary>
        /// <param name="resourceName">Required. The resource name of the contact to delete.</param>
        public virtual DeleteContactRequest DeleteContact(string resourceName)
        {
            return new DeleteContactRequest(this.service, resourceName);
        }

        /// <summary>
        /// Delete a contact person. Any non-contact data will not be deleted. Mutate requests for the same user should
        /// be sent sequentially to avoid increased latency and failures.
        /// </summary>
        public class DeleteContactRequest : PeopleServiceBaseServiceRequest<Google.Apis.PeopleService.v1.Data.Empty>
        {
            /// <summary>Constructs a new DeleteContact request.</summary>
            public DeleteContactRequest(Google.Apis.Services.IClientService service, string resourceName) : base(service)
            {
                ResourceName = resourceName;
                InitParameters();
            }

            /// <summary>Required. The resource name of the contact to delete.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceName { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "deleteContact";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+resourceName}:deleteContact";

            /// <summary>Initializes DeleteContact parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceName", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^people/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Delete a contact's photo. Mutate requests for the same user should be done sequentially to avoid // lock
        /// contention.
        /// </summary>
        /// <param name="resourceName">Required. The resource name of the contact whose photo will be deleted.</param>
        public virtual DeleteContactPhotoRequest DeleteContactPhoto(string resourceName)
        {
            return new DeleteContactPhotoRequest(this.service, resourceName);
        }

        /// <summary>
        /// Delete a contact's photo. Mutate requests for the same user should be done sequentially to avoid // lock
        /// contention.
        /// </summary>
        public class DeleteContactPhotoRequest : PeopleServiceBaseServiceRequest<Google.Apis.PeopleService.v1.Data.DeleteContactPhotoResponse>
        {
            /// <summary>Constructs a new DeleteContactPhoto request.</summary>
            public DeleteContactPhotoRequest(Google.Apis.Services.IClientService service, string resourceName) : base(service)
            {
                ResourceName = resourceName;
                InitParameters();
            }

            /// <summary>Required. The resource name of the contact whose photo will be deleted.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceName { get; private set; }

            /// <summary>
            /// Optional. A field mask to restrict which fields on the person are returned. Multiple fields can be
            /// specified by separating them with commas. Defaults to empty if not set, which will skip the post mutate
            /// get. Valid values are: * addresses * ageRanges * biographies * birthdays * calendarUrls * clientData *
            /// coverPhotos * emailAddresses * events * externalIds * genders * imClients * interests * locales *
            /// locations * memberships * metadata * miscKeywords * names * nicknames * occupations * organizations *
            /// phoneNumbers * photos * relations * sipAddresses * skills * urls * userDefined
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("personFields", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object PersonFields { get; set; }

            /// <summary>
            /// Optional. A mask of what source types to return. Defaults to READ_SOURCE_TYPE_CONTACT and
            /// READ_SOURCE_TYPE_PROFILE if not set.
            /// </summary>
            /// <remarks>
            /// Use this property to set a single value for the parameter, or <see cref="SourcesList"/> to set multiple
            /// values. Do not set both properties.
            /// </remarks>
            [Google.Apis.Util.RequestParameterAttribute("sources", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<SourcesEnum> Sources { get; set; }

            /// <summary>
            /// Optional. A mask of what source types to return. Defaults to READ_SOURCE_TYPE_CONTACT and
            /// READ_SOURCE_TYPE_PROFILE if not set.
            /// </summary>
            /// <remarks>
            /// Use this property to set one or more values for the parameter. Do not set both this property and
            /// <see cref="Sources"/>.
            /// </remarks>
            [Google.Apis.Util.RequestParameterAttribute("sources", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<SourcesEnum> SourcesList { get; set; }

            /// <summary>
            /// Optional. A mask of what source types to return. Defaults to READ_SOURCE_TYPE_CONTACT and
            /// READ_SOURCE_TYPE_PROFILE if not set.
            /// </summary>
            public enum SourcesEnum
            {
                /// <summary>Unspecified.</summary>
                [Google.Apis.Util.StringValueAttribute("READ_SOURCE_TYPE_UNSPECIFIED")]
                READSOURCETYPEUNSPECIFIED = 0,

                /// <summary>Returns SourceType.ACCOUNT, SourceType.DOMAIN_PROFILE, and SourceType.PROFILE.</summary>
                [Google.Apis.Util.StringValueAttribute("READ_SOURCE_TYPE_PROFILE")]
                READSOURCETYPEPROFILE = 1,

                /// <summary>Returns SourceType.CONTACT.</summary>
                [Google.Apis.Util.StringValueAttribute("READ_SOURCE_TYPE_CONTACT")]
                READSOURCETYPECONTACT = 2,

                /// <summary>Returns SourceType.DOMAIN_CONTACT.</summary>
                [Google.Apis.Util.StringValueAttribute("READ_SOURCE_TYPE_DOMAIN_CONTACT")]
                READSOURCETYPEDOMAINCONTACT = 3,

                /// <summary>Returns SourceType.OTHER_CONTACT.</summary>
                [Google.Apis.Util.StringValueAttribute("READ_SOURCE_TYPE_OTHER_CONTACT")]
                READSOURCETYPEOTHERCONTACT = 4,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "deleteContactPhoto";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+resourceName}:deleteContactPhoto";

            /// <summary>Initializes DeleteContactPhoto parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceName", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^people/[^/]+$",
                });
                RequestParameters.Add("personFields", new Google.Apis.Discovery.Parameter
                {
                    Name = "personFields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sources", new Google.Apis.Discovery.Parameter
                {
                    Name = "sources",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Provides information about a person by specifying a resource name. Use `people/me` to indicate the
        /// authenticated user. The request returns a 400 error if 'personFields' is not specified.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the person to provide information about. - To get information about the
        /// authenticated user, specify `people/me`. - To get information about a google account, specify
        /// `people/{account_id}`. - To get information about a contact, specify the resource name that identifies the
        /// contact as returned by `people.connections.list`.
        /// </param>
        public virtual GetRequest Get(string resourceName)
        {
            return new GetRequest(this.service, resourceName);
        }

        /// <summary>
        /// Provides information about a person by specifying a resource name. Use `people/me` to indicate the
        /// authenticated user. The request returns a 400 error if 'personFields' is not specified.
        /// </summary>
        public class GetRequest : PeopleServiceBaseServiceRequest<Google.Apis.PeopleService.v1.Data.Person>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string resourceName) : base(service)
            {
                ResourceName = resourceName;
                InitParameters();
            }

            /// <summary>
            /// Required. The resource name of the person to provide information about. - To get information about the
            /// authenticated user, specify `people/me`. - To get information about a google account, specify
            /// `people/{account_id}`. - To get information about a contact, specify the resource name that identifies
            /// the contact as returned by `people.connections.list`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceName { get; private set; }

            /// <summary>
            /// Required. A field mask to restrict which fields on the person are returned. Multiple fields can be
            /// specified by separating them with commas. Valid values are: * addresses * ageRanges * biographies *
            /// birthdays * calendarUrls * clientData * coverPhotos * emailAddresses * events * externalIds * genders *
            /// imClients * interests * locales * locations * memberships * metadata * miscKeywords * names * nicknames
            /// * occupations * organizations * phoneNumbers * photos * relations * sipAddresses * skills * urls *
            /// userDefined
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("personFields", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object PersonFields { get; set; }

            /// <summary>
            /// Required. Comma-separated list of person fields to be included in the response. Each path should start
            /// with `person.`: for example, `person.names` or `person.photos`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("requestMask.includeField", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object RequestMaskIncludeField { get; set; }

            /// <summary>
            /// Optional. A mask of what source types to return. Defaults to READ_SOURCE_TYPE_PROFILE and
            /// READ_SOURCE_TYPE_CONTACT if not set.
            /// </summary>
            /// <remarks>
            /// Use this property to set a single value for the parameter, or <see cref="SourcesList"/> to set multiple
            /// values. Do not set both properties.
            /// </remarks>
            [Google.Apis.Util.RequestParameterAttribute("sources", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<SourcesEnum> Sources { get; set; }

            /// <summary>
            /// Optional. A mask of what source types to return. Defaults to READ_SOURCE_TYPE_PROFILE and
            /// READ_SOURCE_TYPE_CONTACT if not set.
            /// </summary>
            /// <remarks>
            /// Use this property to set one or more values for the parameter. Do not set both this property and
            /// <see cref="Sources"/>.
            /// </remarks>
            [Google.Apis.Util.RequestParameterAttribute("sources", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<SourcesEnum> SourcesList { get; set; }

            /// <summary>
            /// Optional. A mask of what source types to return. Defaults to READ_SOURCE_TYPE_PROFILE and
            /// READ_SOURCE_TYPE_CONTACT if not set.
            /// </summary>
            public enum SourcesEnum
            {
                /// <summary>Unspecified.</summary>
                [Google.Apis.Util.StringValueAttribute("READ_SOURCE_TYPE_UNSPECIFIED")]
                READSOURCETYPEUNSPECIFIED = 0,

                /// <summary>Returns SourceType.ACCOUNT, SourceType.DOMAIN_PROFILE, and SourceType.PROFILE.</summary>
                [Google.Apis.Util.StringValueAttribute("READ_SOURCE_TYPE_PROFILE")]
                READSOURCETYPEPROFILE = 1,

                /// <summary>Returns SourceType.CONTACT.</summary>
                [Google.Apis.Util.StringValueAttribute("READ_SOURCE_TYPE_CONTACT")]
                READSOURCETYPECONTACT = 2,

                /// <summary>Returns SourceType.DOMAIN_CONTACT.</summary>
                [Google.Apis.Util.StringValueAttribute("READ_SOURCE_TYPE_DOMAIN_CONTACT")]
                READSOURCETYPEDOMAINCONTACT = 3,

                /// <summary>Returns SourceType.OTHER_CONTACT.</summary>
                [Google.Apis.Util.StringValueAttribute("READ_SOURCE_TYPE_OTHER_CONTACT")]
                READSOURCETYPEOTHERCONTACT = 4,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+resourceName}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceName", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^people/[^/]+$",
                });
                RequestParameters.Add("personFields", new Google.Apis.Discovery.Parameter
                {
                    Name = "personFields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("requestMask.includeField", new Google.Apis.Discovery.Parameter
                {
                    Name = "requestMask.includeField",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sources", new Google.Apis.Discovery.Parameter
                {
                    Name = "sources",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Provides information about a list of specific people by specifying a list of requested resource names. Use
        /// `people/me` to indicate the authenticated user. The request returns a 400 error if 'personFields' is not
        /// specified.
        /// </summary>
        public virtual GetBatchGetRequest GetBatchGet()
        {
            return new GetBatchGetRequest(this.service);
        }

        /// <summary>
        /// Provides information about a list of specific people by specifying a list of requested resource names. Use
        /// `people/me` to indicate the authenticated user. The request returns a 400 error if 'personFields' is not
        /// specified.
        /// </summary>
        public class GetBatchGetRequest : PeopleServiceBaseServiceRequest<Google.Apis.PeopleService.v1.Data.GetPeopleResponse>
        {
            /// <summary>Constructs a new GetBatchGet request.</summary>
            public GetBatchGetRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Required. A field mask to restrict which fields on each person are returned. Multiple fields can be
            /// specified by separating them with commas. Valid values are: * addresses * ageRanges * biographies *
            /// birthdays * calendarUrls * clientData * coverPhotos * emailAddresses * events * externalIds * genders *
            /// imClients * interests * locales * locations * memberships * metadata * miscKeywords * names * nicknames
            /// * occupations * organizations * phoneNumbers * photos * relations * sipAddresses * skills * urls *
            /// userDefined
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("personFields", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object PersonFields { get; set; }

            /// <summary>
            /// Required. Comma-separated list of person fields to be included in the response. Each path should start
            /// with `person.`: for example, `person.names` or `person.photos`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("requestMask.includeField", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object RequestMaskIncludeField { get; set; }

            /// <summary>
            /// Required. The resource names of the people to provide information about. It's repeatable. The URL query
            /// parameter should be
            /// resourceNames=&amp;lt;name1&amp;gt;&amp;amp;resourceNames=&amp;lt;name2&amp;gt;&amp;amp;... - To get
            /// information about the authenticated user, specify `people/me`. - To get information about a google
            /// account, specify `people/{account_id}`. - To get information about a contact, specify the resource name
            /// that identifies the contact as returned by `people.connections.list`. There is a maximum of 200 resource
            /// names.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceNames", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> ResourceNames { get; set; }

            /// <summary>
            /// Optional. A mask of what source types to return. Defaults to READ_SOURCE_TYPE_CONTACT and
            /// READ_SOURCE_TYPE_PROFILE if not set.
            /// </summary>
            /// <remarks>
            /// Use this property to set a single value for the parameter, or <see cref="SourcesList"/> to set multiple
            /// values. Do not set both properties.
            /// </remarks>
            [Google.Apis.Util.RequestParameterAttribute("sources", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<SourcesEnum> Sources { get; set; }

            /// <summary>
            /// Optional. A mask of what source types to return. Defaults to READ_SOURCE_TYPE_CONTACT and
            /// READ_SOURCE_TYPE_PROFILE if not set.
            /// </summary>
            /// <remarks>
            /// Use this property to set one or more values for the parameter. Do not set both this property and
            /// <see cref="Sources"/>.
            /// </remarks>
            [Google.Apis.Util.RequestParameterAttribute("sources", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<SourcesEnum> SourcesList { get; set; }

            /// <summary>
            /// Optional. A mask of what source types to return. Defaults to READ_SOURCE_TYPE_CONTACT and
            /// READ_SOURCE_TYPE_PROFILE if not set.
            /// </summary>
            public enum SourcesEnum
            {
                /// <summary>Unspecified.</summary>
                [Google.Apis.Util.StringValueAttribute("READ_SOURCE_TYPE_UNSPECIFIED")]
                READSOURCETYPEUNSPECIFIED = 0,

                /// <summary>Returns SourceType.ACCOUNT, SourceType.DOMAIN_PROFILE, and SourceType.PROFILE.</summary>
                [Google.Apis.Util.StringValueAttribute("READ_SOURCE_TYPE_PROFILE")]
                READSOURCETYPEPROFILE = 1,

                /// <summary>Returns SourceType.CONTACT.</summary>
                [Google.Apis.Util.StringValueAttribute("READ_SOURCE_TYPE_CONTACT")]
                READSOURCETYPECONTACT = 2,

                /// <summary>Returns SourceType.DOMAIN_CONTACT.</summary>
                [Google.Apis.Util.StringValueAttribute("READ_SOURCE_TYPE_DOMAIN_CONTACT")]
                READSOURCETYPEDOMAINCONTACT = 3,

                /// <summary>Returns SourceType.OTHER_CONTACT.</summary>
                [Google.Apis.Util.StringValueAttribute("READ_SOURCE_TYPE_OTHER_CONTACT")]
                READSOURCETYPEOTHERCONTACT = 4,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getBatchGet";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/people:batchGet";

            /// <summary>Initializes GetBatchGet parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("personFields", new Google.Apis.Discovery.Parameter
                {
                    Name = "personFields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("requestMask.includeField", new Google.Apis.Discovery.Parameter
                {
                    Name = "requestMask.includeField",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("resourceNames", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceNames",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sources", new Google.Apis.Discovery.Parameter
                {
                    Name = "sources",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Provides a list of domain profiles and domain contacts in the authenticated user's domain directory. When
        /// the `sync_token` is specified, resources deleted since the last sync will be returned as a person with
        /// `PersonMetadata.deleted` set to true. When the `page_token` or `sync_token` is specified, all other request
        /// parameters must match the first call. Writes may have a propagation delay of several minutes for sync
        /// requests. Incremental syncs are not intended for read-after-write use cases. See example usage at [List the
        /// directory people that have changed](/people/v1/directory#list_the_directory_people_that_have_changed).
        /// </summary>
        public virtual ListDirectoryPeopleRequest ListDirectoryPeople()
        {
            return new ListDirectoryPeopleRequest(this.service);
        }

        /// <summary>
        /// Provides a list of domain profiles and domain contacts in the authenticated user's domain directory. When
        /// the `sync_token` is specified, resources deleted since the last sync will be returned as a person with
        /// `PersonMetadata.deleted` set to true. When the `page_token` or `sync_token` is specified, all other request
        /// parameters must match the first call. Writes may have a propagation delay of several minutes for sync
        /// requests. Incremental syncs are not intended for read-after-write use cases. See example usage at [List the
        /// directory people that have changed](/people/v1/directory#list_the_directory_people_that_have_changed).
        /// </summary>
        public class ListDirectoryPeopleRequest : PeopleServiceBaseServiceRequest<Google.Apis.PeopleService.v1.Data.ListDirectoryPeopleResponse>
        {
            /// <summary>Constructs a new ListDirectoryPeople request.</summary>
            public ListDirectoryPeopleRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional. Additional data to merge into the directory sources if they are connected through verified
            /// join keys such as email addresses or phone numbers.
            /// </summary>
            /// <remarks>
            /// Use this property to set a single value for the parameter, or <see cref="MergeSourcesList"/> to set
            /// multiple values. Do not set both properties.
            /// </remarks>
            [Google.Apis.Util.RequestParameterAttribute("mergeSources", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<MergeSourcesEnum> MergeSources { get; set; }

            /// <summary>
            /// Optional. Additional data to merge into the directory sources if they are connected through verified
            /// join keys such as email addresses or phone numbers.
            /// </summary>
            /// <remarks>
            /// Use this property to set one or more values for the parameter. Do not set both this property and
            /// <see cref="MergeSources"/>.
            /// </remarks>
            [Google.Apis.Util.RequestParameterAttribute("mergeSources", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<MergeSourcesEnum> MergeSourcesList { get; set; }

            /// <summary>
            /// Optional. Additional data to merge into the directory sources if they are connected through verified
            /// join keys such as email addresses or phone numbers.
            /// </summary>
            public enum MergeSourcesEnum
            {
                /// <summary>Unspecified.</summary>
                [Google.Apis.Util.StringValueAttribute("DIRECTORY_MERGE_SOURCE_TYPE_UNSPECIFIED")]
                DIRECTORYMERGESOURCETYPEUNSPECIFIED = 0,

                /// <summary>User owned contact.</summary>
                [Google.Apis.Util.StringValueAttribute("DIRECTORY_MERGE_SOURCE_TYPE_CONTACT")]
                DIRECTORYMERGESOURCETYPECONTACT = 1,
            }

            /// <summary>
            /// Optional. The number of people to include in the response. Valid values are between 1 and 1000,
            /// inclusive. Defaults to 100 if not set or set to 0.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. A page token, received from a previous response `next_page_token`. Provide this to retrieve
            /// the subsequent page. When paginating, all other parameters provided to `people.listDirectoryPeople` must
            /// match the first call that provided the page token.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Required. A field mask to restrict which fields on each person are returned. Multiple fields can be
            /// specified by separating them with commas. Valid values are: * addresses * ageRanges * biographies *
            /// birthdays * calendarUrls * clientData * coverPhotos * emailAddresses * events * externalIds * genders *
            /// imClients * interests * locales * locations * memberships * metadata * miscKeywords * names * nicknames
            /// * occupations * organizations * phoneNumbers * photos * relations * sipAddresses * skills * urls *
            /// userDefined
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("readMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object ReadMask { get; set; }

            /// <summary>
            /// Optional. Whether the response should return `next_sync_token`. It can be used to get incremental
            /// changes since the last request by setting it on the request `sync_token`. More details about sync
            /// behavior at `people.listDirectoryPeople`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("requestSyncToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> RequestSyncToken { get; set; }

            /// <summary>Required. Directory sources to return.</summary>
            /// <remarks>
            /// Use this property to set a single value for the parameter, or <see cref="SourcesList"/> to set multiple
            /// values. Do not set both properties.
            /// </remarks>
            [Google.Apis.Util.RequestParameterAttribute("sources", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<SourcesEnum> Sources { get; set; }

            /// <summary>Required. Directory sources to return.</summary>
            /// <remarks>
            /// Use this property to set one or more values for the parameter. Do not set both this property and
            /// <see cref="Sources"/>.
            /// </remarks>
            [Google.Apis.Util.RequestParameterAttribute("sources", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<SourcesEnum> SourcesList { get; set; }

            /// <summary>Required. Directory sources to return.</summary>
            public enum SourcesEnum
            {
                /// <summary>Unspecified.</summary>
                [Google.Apis.Util.StringValueAttribute("DIRECTORY_SOURCE_TYPE_UNSPECIFIED")]
                DIRECTORYSOURCETYPEUNSPECIFIED = 0,

                /// <summary>Google Workspace domain shared contact.</summary>
                [Google.Apis.Util.StringValueAttribute("DIRECTORY_SOURCE_TYPE_DOMAIN_CONTACT")]
                DIRECTORYSOURCETYPEDOMAINCONTACT = 1,

                /// <summary>Google Workspace domain profile.</summary>
                [Google.Apis.Util.StringValueAttribute("DIRECTORY_SOURCE_TYPE_DOMAIN_PROFILE")]
                DIRECTORYSOURCETYPEDOMAINPROFILE = 2,
            }

            /// <summary>
            /// Optional. A sync token, received from a previous response `next_sync_token` Provide this to retrieve
            /// only the resources changed since the last request. When syncing, all other parameters provided to
            /// `people.listDirectoryPeople` must match the first call that provided the sync token. More details about
            /// sync behavior at `people.listDirectoryPeople`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("syncToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string SyncToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "listDirectoryPeople";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/people:listDirectoryPeople";

            /// <summary>Initializes ListDirectoryPeople parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("mergeSources", new Google.Apis.Discovery.Parameter
                {
                    Name = "mergeSources",
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
                RequestParameters.Add("readMask", new Google.Apis.Discovery.Parameter
                {
                    Name = "readMask",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("requestSyncToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "requestSyncToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sources", new Google.Apis.Discovery.Parameter
                {
                    Name = "sources",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("syncToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "syncToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Provides a list of contacts in the authenticated user's grouped contacts that matches the search query. The
        /// query matches on a contact's `names`, `nickNames`, `emailAddresses`, `phoneNumbers`, and `organizations`
        /// fields that are from the CONTACT source. **IMPORTANT**: Before searching, clients should send a warmup
        /// request with an empty query to update the cache. See
        /// https://developers.google.com/people/v1/contacts#search_the_users_contacts
        /// </summary>
        public virtual SearchContactsRequest SearchContacts()
        {
            return new SearchContactsRequest(this.service);
        }

        /// <summary>
        /// Provides a list of contacts in the authenticated user's grouped contacts that matches the search query. The
        /// query matches on a contact's `names`, `nickNames`, `emailAddresses`, `phoneNumbers`, and `organizations`
        /// fields that are from the CONTACT source. **IMPORTANT**: Before searching, clients should send a warmup
        /// request with an empty query to update the cache. See
        /// https://developers.google.com/people/v1/contacts#search_the_users_contacts
        /// </summary>
        public class SearchContactsRequest : PeopleServiceBaseServiceRequest<Google.Apis.PeopleService.v1.Data.SearchResponse>
        {
            /// <summary>Constructs a new SearchContacts request.</summary>
            public SearchContactsRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional. The number of results to return. Defaults to 10 if field is not set, or set to 0. Values
            /// greater than 30 will be capped to 30.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Required. The plain-text query for the request. The query is used to match prefix phrases of the fields
            /// on a person. For example, a person with name "foo name" matches queries such as "f", "fo", "foo", "foo
            /// n", "nam", etc., but not "oo n".
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query { get; set; }

            /// <summary>
            /// Required. A field mask to restrict which fields on each person are returned. Multiple fields can be
            /// specified by separating them with commas. Valid values are: * addresses * ageRanges * biographies *
            /// birthdays * calendarUrls * clientData * coverPhotos * emailAddresses * events * externalIds * genders *
            /// imClients * interests * locales * locations * memberships * metadata * miscKeywords * names * nicknames
            /// * occupations * organizations * phoneNumbers * photos * relations * sipAddresses * skills * urls *
            /// userDefined
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("readMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object ReadMask { get; set; }

            /// <summary>
            /// Optional. A mask of what source types to return. Defaults to READ_SOURCE_TYPE_CONTACT if not set.
            /// </summary>
            /// <remarks>
            /// Use this property to set a single value for the parameter, or <see cref="SourcesList"/> to set multiple
            /// values. Do not set both properties.
            /// </remarks>
            [Google.Apis.Util.RequestParameterAttribute("sources", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<SourcesEnum> Sources { get; set; }

            /// <summary>
            /// Optional. A mask of what source types to return. Defaults to READ_SOURCE_TYPE_CONTACT if not set.
            /// </summary>
            /// <remarks>
            /// Use this property to set one or more values for the parameter. Do not set both this property and
            /// <see cref="Sources"/>.
            /// </remarks>
            [Google.Apis.Util.RequestParameterAttribute("sources", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<SourcesEnum> SourcesList { get; set; }

            /// <summary>
            /// Optional. A mask of what source types to return. Defaults to READ_SOURCE_TYPE_CONTACT if not set.
            /// </summary>
            public enum SourcesEnum
            {
                /// <summary>Unspecified.</summary>
                [Google.Apis.Util.StringValueAttribute("READ_SOURCE_TYPE_UNSPECIFIED")]
                READSOURCETYPEUNSPECIFIED = 0,

                /// <summary>Returns SourceType.ACCOUNT, SourceType.DOMAIN_PROFILE, and SourceType.PROFILE.</summary>
                [Google.Apis.Util.StringValueAttribute("READ_SOURCE_TYPE_PROFILE")]
                READSOURCETYPEPROFILE = 1,

                /// <summary>Returns SourceType.CONTACT.</summary>
                [Google.Apis.Util.StringValueAttribute("READ_SOURCE_TYPE_CONTACT")]
                READSOURCETYPECONTACT = 2,

                /// <summary>Returns SourceType.DOMAIN_CONTACT.</summary>
                [Google.Apis.Util.StringValueAttribute("READ_SOURCE_TYPE_DOMAIN_CONTACT")]
                READSOURCETYPEDOMAINCONTACT = 3,

                /// <summary>Returns SourceType.OTHER_CONTACT.</summary>
                [Google.Apis.Util.StringValueAttribute("READ_SOURCE_TYPE_OTHER_CONTACT")]
                READSOURCETYPEOTHERCONTACT = 4,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "searchContacts";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/people:searchContacts";

            /// <summary>Initializes SearchContacts parameter list.</summary>
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
                RequestParameters.Add("query", new Google.Apis.Discovery.Parameter
                {
                    Name = "query",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("readMask", new Google.Apis.Discovery.Parameter
                {
                    Name = "readMask",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sources", new Google.Apis.Discovery.Parameter
                {
                    Name = "sources",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Provides a list of domain profiles and domain contacts in the authenticated user's domain directory that
        /// match the search query.
        /// </summary>
        public virtual SearchDirectoryPeopleRequest SearchDirectoryPeople()
        {
            return new SearchDirectoryPeopleRequest(this.service);
        }

        /// <summary>
        /// Provides a list of domain profiles and domain contacts in the authenticated user's domain directory that
        /// match the search query.
        /// </summary>
        public class SearchDirectoryPeopleRequest : PeopleServiceBaseServiceRequest<Google.Apis.PeopleService.v1.Data.SearchDirectoryPeopleResponse>
        {
            /// <summary>Constructs a new SearchDirectoryPeople request.</summary>
            public SearchDirectoryPeopleRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional. Additional data to merge into the directory sources if they are connected through verified
            /// join keys such as email addresses or phone numbers.
            /// </summary>
            /// <remarks>
            /// Use this property to set a single value for the parameter, or <see cref="MergeSourcesList"/> to set
            /// multiple values. Do not set both properties.
            /// </remarks>
            [Google.Apis.Util.RequestParameterAttribute("mergeSources", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<MergeSourcesEnum> MergeSources { get; set; }

            /// <summary>
            /// Optional. Additional data to merge into the directory sources if they are connected through verified
            /// join keys such as email addresses or phone numbers.
            /// </summary>
            /// <remarks>
            /// Use this property to set one or more values for the parameter. Do not set both this property and
            /// <see cref="MergeSources"/>.
            /// </remarks>
            [Google.Apis.Util.RequestParameterAttribute("mergeSources", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<MergeSourcesEnum> MergeSourcesList { get; set; }

            /// <summary>
            /// Optional. Additional data to merge into the directory sources if they are connected through verified
            /// join keys such as email addresses or phone numbers.
            /// </summary>
            public enum MergeSourcesEnum
            {
                /// <summary>Unspecified.</summary>
                [Google.Apis.Util.StringValueAttribute("DIRECTORY_MERGE_SOURCE_TYPE_UNSPECIFIED")]
                DIRECTORYMERGESOURCETYPEUNSPECIFIED = 0,

                /// <summary>User owned contact.</summary>
                [Google.Apis.Util.StringValueAttribute("DIRECTORY_MERGE_SOURCE_TYPE_CONTACT")]
                DIRECTORYMERGESOURCETYPECONTACT = 1,
            }

            /// <summary>
            /// Optional. The number of people to include in the response. Valid values are between 1 and 500,
            /// inclusive. Defaults to 100 if not set or set to 0.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. A page token, received from a previous response `next_page_token`. Provide this to retrieve
            /// the subsequent page. When paginating, all other parameters provided to `SearchDirectoryPeople` must
            /// match the first call that provided the page token.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Required. Prefix query that matches fields in the person. Does NOT use the read_mask for determining
            /// what fields to match.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query { get; set; }

            /// <summary>
            /// Required. A field mask to restrict which fields on each person are returned. Multiple fields can be
            /// specified by separating them with commas. Valid values are: * addresses * ageRanges * biographies *
            /// birthdays * calendarUrls * clientData * coverPhotos * emailAddresses * events * externalIds * genders *
            /// imClients * interests * locales * locations * memberships * metadata * miscKeywords * names * nicknames
            /// * occupations * organizations * phoneNumbers * photos * relations * sipAddresses * skills * urls *
            /// userDefined
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("readMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object ReadMask { get; set; }

            /// <summary>Required. Directory sources to return.</summary>
            /// <remarks>
            /// Use this property to set a single value for the parameter, or <see cref="SourcesList"/> to set multiple
            /// values. Do not set both properties.
            /// </remarks>
            [Google.Apis.Util.RequestParameterAttribute("sources", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<SourcesEnum> Sources { get; set; }

            /// <summary>Required. Directory sources to return.</summary>
            /// <remarks>
            /// Use this property to set one or more values for the parameter. Do not set both this property and
            /// <see cref="Sources"/>.
            /// </remarks>
            [Google.Apis.Util.RequestParameterAttribute("sources", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<SourcesEnum> SourcesList { get; set; }

            /// <summary>Required. Directory sources to return.</summary>
            public enum SourcesEnum
            {
                /// <summary>Unspecified.</summary>
                [Google.Apis.Util.StringValueAttribute("DIRECTORY_SOURCE_TYPE_UNSPECIFIED")]
                DIRECTORYSOURCETYPEUNSPECIFIED = 0,

                /// <summary>Google Workspace domain shared contact.</summary>
                [Google.Apis.Util.StringValueAttribute("DIRECTORY_SOURCE_TYPE_DOMAIN_CONTACT")]
                DIRECTORYSOURCETYPEDOMAINCONTACT = 1,

                /// <summary>Google Workspace domain profile.</summary>
                [Google.Apis.Util.StringValueAttribute("DIRECTORY_SOURCE_TYPE_DOMAIN_PROFILE")]
                DIRECTORYSOURCETYPEDOMAINPROFILE = 2,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "searchDirectoryPeople";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/people:searchDirectoryPeople";

            /// <summary>Initializes SearchDirectoryPeople parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("mergeSources", new Google.Apis.Discovery.Parameter
                {
                    Name = "mergeSources",
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
                RequestParameters.Add("query", new Google.Apis.Discovery.Parameter
                {
                    Name = "query",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("readMask", new Google.Apis.Discovery.Parameter
                {
                    Name = "readMask",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sources", new Google.Apis.Discovery.Parameter
                {
                    Name = "sources",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Update contact data for an existing contact person. Any non-contact data will not be modified. Any
        /// non-contact data in the person to update will be ignored. All fields specified in the `update_mask` will be
        /// replaced. The server returns a 400 error if `person.metadata.sources` is not specified for the contact to be
        /// updated or if there is no contact source. The server returns a 400 error with reason `"failedPrecondition"`
        /// if `person.metadata.sources.etag` is different than the contact's etag, which indicates the contact has
        /// changed since its data was read. Clients should get the latest person and merge their updates into the
        /// latest person. If making sequential updates to the same person, the etag from the `updateContact` response
        /// should be used to avoid failures. The server returns a 400 error if `memberships` are being updated and
        /// there are no contact group memberships specified on the person. The server returns a 400 error if more than
        /// one field is specified on a field that is a singleton for contact sources: * biographies * birthdays *
        /// genders * names Mutate requests for the same user should be sent sequentially to avoid increased latency and
        /// failures.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceName">
        /// The resource name for the person, assigned by the server. An ASCII string in the form of
        /// `people/{person_id}`.
        /// </param>
        public virtual UpdateContactRequest UpdateContact(Google.Apis.PeopleService.v1.Data.Person body, string resourceName)
        {
            return new UpdateContactRequest(this.service, body, resourceName);
        }

        /// <summary>
        /// Update contact data for an existing contact person. Any non-contact data will not be modified. Any
        /// non-contact data in the person to update will be ignored. All fields specified in the `update_mask` will be
        /// replaced. The server returns a 400 error if `person.metadata.sources` is not specified for the contact to be
        /// updated or if there is no contact source. The server returns a 400 error with reason `"failedPrecondition"`
        /// if `person.metadata.sources.etag` is different than the contact's etag, which indicates the contact has
        /// changed since its data was read. Clients should get the latest person and merge their updates into the
        /// latest person. If making sequential updates to the same person, the etag from the `updateContact` response
        /// should be used to avoid failures. The server returns a 400 error if `memberships` are being updated and
        /// there are no contact group memberships specified on the person. The server returns a 400 error if more than
        /// one field is specified on a field that is a singleton for contact sources: * biographies * birthdays *
        /// genders * names Mutate requests for the same user should be sent sequentially to avoid increased latency and
        /// failures.
        /// </summary>
        public class UpdateContactRequest : PeopleServiceBaseServiceRequest<Google.Apis.PeopleService.v1.Data.Person>
        {
            /// <summary>Constructs a new UpdateContact request.</summary>
            public UpdateContactRequest(Google.Apis.Services.IClientService service, Google.Apis.PeopleService.v1.Data.Person body, string resourceName) : base(service)
            {
                ResourceName = resourceName;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name for the person, assigned by the server. An ASCII string in the form of
            /// `people/{person_id}`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceName { get; private set; }

            /// <summary>
            /// Optional. A field mask to restrict which fields on each person are returned. Multiple fields can be
            /// specified by separating them with commas. Defaults to all fields if not set. Valid values are: *
            /// addresses * ageRanges * biographies * birthdays * calendarUrls * clientData * coverPhotos *
            /// emailAddresses * events * externalIds * genders * imClients * interests * locales * locations *
            /// memberships * metadata * miscKeywords * names * nicknames * occupations * organizations * phoneNumbers *
            /// photos * relations * sipAddresses * skills * urls * userDefined
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("personFields", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object PersonFields { get; set; }

            /// <summary>
            /// Optional. A mask of what source types to return. Defaults to READ_SOURCE_TYPE_CONTACT and
            /// READ_SOURCE_TYPE_PROFILE if not set.
            /// </summary>
            /// <remarks>
            /// Use this property to set a single value for the parameter, or <see cref="SourcesList"/> to set multiple
            /// values. Do not set both properties.
            /// </remarks>
            [Google.Apis.Util.RequestParameterAttribute("sources", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<SourcesEnum> Sources { get; set; }

            /// <summary>
            /// Optional. A mask of what source types to return. Defaults to READ_SOURCE_TYPE_CONTACT and
            /// READ_SOURCE_TYPE_PROFILE if not set.
            /// </summary>
            /// <remarks>
            /// Use this property to set one or more values for the parameter. Do not set both this property and
            /// <see cref="Sources"/>.
            /// </remarks>
            [Google.Apis.Util.RequestParameterAttribute("sources", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<SourcesEnum> SourcesList { get; set; }

            /// <summary>
            /// Optional. A mask of what source types to return. Defaults to READ_SOURCE_TYPE_CONTACT and
            /// READ_SOURCE_TYPE_PROFILE if not set.
            /// </summary>
            public enum SourcesEnum
            {
                /// <summary>Unspecified.</summary>
                [Google.Apis.Util.StringValueAttribute("READ_SOURCE_TYPE_UNSPECIFIED")]
                READSOURCETYPEUNSPECIFIED = 0,

                /// <summary>Returns SourceType.ACCOUNT, SourceType.DOMAIN_PROFILE, and SourceType.PROFILE.</summary>
                [Google.Apis.Util.StringValueAttribute("READ_SOURCE_TYPE_PROFILE")]
                READSOURCETYPEPROFILE = 1,

                /// <summary>Returns SourceType.CONTACT.</summary>
                [Google.Apis.Util.StringValueAttribute("READ_SOURCE_TYPE_CONTACT")]
                READSOURCETYPECONTACT = 2,

                /// <summary>Returns SourceType.DOMAIN_CONTACT.</summary>
                [Google.Apis.Util.StringValueAttribute("READ_SOURCE_TYPE_DOMAIN_CONTACT")]
                READSOURCETYPEDOMAINCONTACT = 3,

                /// <summary>Returns SourceType.OTHER_CONTACT.</summary>
                [Google.Apis.Util.StringValueAttribute("READ_SOURCE_TYPE_OTHER_CONTACT")]
                READSOURCETYPEOTHERCONTACT = 4,
            }

            /// <summary>
            /// Required. A field mask to restrict which fields on the person are updated. Multiple fields can be
            /// specified by separating them with commas. All updated fields will be replaced. Valid values are: *
            /// addresses * biographies * birthdays * calendarUrls * clientData * emailAddresses * events * externalIds
            /// * genders * imClients * interests * locales * locations * memberships * miscKeywords * names * nicknames
            /// * occupations * organizations * phoneNumbers * relations * sipAddresses * urls * userDefined
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updatePersonFields", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdatePersonFields { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.PeopleService.v1.Data.Person Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateContact";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+resourceName}:updateContact";

            /// <summary>Initializes UpdateContact parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceName", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^people/[^/]+$",
                });
                RequestParameters.Add("personFields", new Google.Apis.Discovery.Parameter
                {
                    Name = "personFields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sources", new Google.Apis.Discovery.Parameter
                {
                    Name = "sources",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("updatePersonFields", new Google.Apis.Discovery.Parameter
                {
                    Name = "updatePersonFields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Update a contact's photo. Mutate requests for the same user should be sent sequentially to avoid increased
        /// latency and failures.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resourceName">Required. Person resource name</param>
        public virtual UpdateContactPhotoRequest UpdateContactPhoto(Google.Apis.PeopleService.v1.Data.UpdateContactPhotoRequest body, string resourceName)
        {
            return new UpdateContactPhotoRequest(this.service, body, resourceName);
        }

        /// <summary>
        /// Update a contact's photo. Mutate requests for the same user should be sent sequentially to avoid increased
        /// latency and failures.
        /// </summary>
        public class UpdateContactPhotoRequest : PeopleServiceBaseServiceRequest<Google.Apis.PeopleService.v1.Data.UpdateContactPhotoResponse>
        {
            /// <summary>Constructs a new UpdateContactPhoto request.</summary>
            public UpdateContactPhotoRequest(Google.Apis.Services.IClientService service, Google.Apis.PeopleService.v1.Data.UpdateContactPhotoRequest body, string resourceName) : base(service)
            {
                ResourceName = resourceName;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Person resource name</summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceName { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.PeopleService.v1.Data.UpdateContactPhotoRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateContactPhoto";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+resourceName}:updateContactPhoto";

            /// <summary>Initializes UpdateContactPhoto parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceName", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^people/[^/]+$",
                });
            }
        }
    }
}
namespace Google.Apis.PeopleService.v1.Data
{
    /// <summary>A person's physical address. May be a P.O. box or street address. All fields are optional.</summary>
    public class Address : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The city of the address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("city")]
        public virtual string City { get; set; }

        /// <summary>The country of the address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("country")]
        public virtual string Country { get; set; }

        /// <summary>
        /// The [ISO 3166-1 alpha-2](http://www.iso.org/iso/country_codes.htm) country code of the address.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countryCode")]
        public virtual string CountryCode { get; set; }

        /// <summary>The extended address of the address; for example, the apartment number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extendedAddress")]
        public virtual string ExtendedAddress { get; set; }

        /// <summary>
        /// Output only. The type of the address translated and formatted in the viewer's account locale or the
        /// `Accept-Language` HTTP header locale.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedType")]
        public virtual string FormattedType { get; set; }

        /// <summary>
        /// The unstructured value of the address. If this is not set by the user it will be automatically constructed
        /// from structured values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedValue")]
        public virtual string FormattedValue { get; set; }

        /// <summary>Metadata about the address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual FieldMetadata Metadata { get; set; }

        /// <summary>The P.O. box of the address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("poBox")]
        public virtual string PoBox { get; set; }

        /// <summary>The postal code of the address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCode")]
        public virtual string PostalCode { get; set; }

        /// <summary>The region of the address; for example, the state or province.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>The street address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("streetAddress")]
        public virtual string StreetAddress { get; set; }

        /// <summary>
        /// The type of the address. The type can be custom or one of these predefined values: * `home` * `work` *
        /// `other`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A person's age range.</summary>
    public class AgeRangeType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The age range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ageRange")]
        public virtual string AgeRange { get; set; }

        /// <summary>Metadata about the age range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual FieldMetadata Metadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to create a batch of contacts.</summary>
    public class BatchCreateContactsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The contact to create. Allows up to 200 contacts in a single request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contacts")]
        public virtual System.Collections.Generic.IList<ContactToCreate> Contacts { get; set; }

        /// <summary>
        /// Required. A field mask to restrict which fields on each person are returned in the response. Multiple fields
        /// can be specified by separating them with commas. If read mask is left empty, the post-mutate-get is skipped
        /// and no data will be returned in the response. Valid values are: * addresses * ageRanges * biographies *
        /// birthdays * calendarUrls * clientData * coverPhotos * emailAddresses * events * externalIds * genders *
        /// imClients * interests * locales * locations * memberships * metadata * miscKeywords * names * nicknames *
        /// occupations * organizations * phoneNumbers * photos * relations * sipAddresses * skills * urls * userDefined
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readMask")]
        public virtual object ReadMask { get; set; }

        /// <summary>
        /// Optional. A mask of what source types to return in the post mutate read. Defaults to
        /// READ_SOURCE_TYPE_CONTACT and READ_SOURCE_TYPE_PROFILE if not set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sources")]
        public virtual System.Collections.Generic.IList<string> Sources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// If not successful, returns BatchCreateContactsErrorDetails which contains a list of errors for each invalid
    /// contact. The response to a request to create a batch of contacts.
    /// </summary>
    public class BatchCreateContactsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The contacts that were created, unless the request `read_mask` is empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createdPeople")]
        public virtual System.Collections.Generic.IList<PersonResponse> CreatedPeople { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to delete a batch of existing contacts.</summary>
    public class BatchDeleteContactsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The resource names of the contact to delete. It's repeatable. Allows up to 500 resource names in a
        /// single request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceNames")]
        public virtual System.Collections.Generic.IList<string> ResourceNames { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response to a batch get contact groups request.</summary>
    public class BatchGetContactGroupsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of responses for each requested contact group resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responses")]
        public virtual System.Collections.Generic.IList<ContactGroupResponse> Responses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to update a batch of contacts.</summary>
    public class BatchUpdateContactsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A map of resource names to the person data to be updated. Allows up to 200 contacts in a single
        /// request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contacts")]
        public virtual System.Collections.Generic.IDictionary<string, Person> Contacts { get; set; }

        /// <summary>
        /// Required. A field mask to restrict which fields on each person are returned. Multiple fields can be
        /// specified by separating them with commas. If read mask is left empty, the post-mutate-get is skipped and no
        /// data will be returned in the response. Valid values are: * addresses * ageRanges * biographies * birthdays *
        /// calendarUrls * clientData * coverPhotos * emailAddresses * events * externalIds * genders * imClients *
        /// interests * locales * locations * memberships * metadata * miscKeywords * names * nicknames * occupations *
        /// organizations * phoneNumbers * photos * relations * sipAddresses * skills * urls * userDefined
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readMask")]
        public virtual object ReadMask { get; set; }

        /// <summary>
        /// Optional. A mask of what source types to return. Defaults to READ_SOURCE_TYPE_CONTACT and
        /// READ_SOURCE_TYPE_PROFILE if not set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sources")]
        public virtual System.Collections.Generic.IList<string> Sources { get; set; }

        /// <summary>
        /// Required. A field mask to restrict which fields on the person are updated. Multiple fields can be specified
        /// by separating them with commas. All specified fields will be replaced, or cleared if left empty for each
        /// person. Valid values are: * addresses * biographies * birthdays * calendarUrls * clientData * emailAddresses
        /// * events * externalIds * genders * imClients * interests * locales * locations * memberships * miscKeywords
        /// * names * nicknames * occupations * organizations * phoneNumbers * relations * sipAddresses * urls *
        /// userDefined
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// If not successful, returns BatchUpdateContactsErrorDetails, a list of errors corresponding to each contact. The
    /// response to a request to update a batch of contacts.
    /// </summary>
    public class BatchUpdateContactsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A map of resource names to the contacts that were updated, unless the request `read_mask` is empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateResult")]
        public virtual System.Collections.Generic.IDictionary<string, PersonResponse> UpdateResult { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A person's short biography.</summary>
    public class Biography : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The content type of the biography.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentType")]
        public virtual string ContentType { get; set; }

        /// <summary>Metadata about the biography.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual FieldMetadata Metadata { get; set; }

        /// <summary>The short biography.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A person's birthday. At least one of the `date` and `text` fields are specified. The `date` and `text` fields
    /// typically represent the same date, but are not guaranteed to. Clients should always set the `date` field when
    /// mutating birthdays.
    /// </summary>
    public class Birthday : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The structured date of the birthday.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual Date Date { get; set; }

        /// <summary>Metadata about the birthday.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual FieldMetadata Metadata { get; set; }

        /// <summary>
        /// Prefer to use the `date` field if set. A free-form string representing the user's birthday. This value is
        /// not validated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>**DEPRECATED**: No data will be returned A person's bragging rights.</summary>
    public class BraggingRights : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Metadata about the bragging rights.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual FieldMetadata Metadata { get; set; }

        /// <summary>The bragging rights; for example, `climbed mount everest`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A person's calendar URL.</summary>
    public class CalendarUrl : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The type of the calendar URL translated and formatted in the viewer's account locale or the
        /// `Accept-Language` HTTP header locale.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedType")]
        public virtual string FormattedType { get; set; }

        /// <summary>Metadata about the calendar URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual FieldMetadata Metadata { get; set; }

        /// <summary>
        /// The type of the calendar URL. The type can be custom or one of these predefined values: * `home` *
        /// `freeBusy` * `work`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The calendar URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Arbitrary client data that is populated by clients. Duplicate keys and values are allowed.</summary>
    public class ClientData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The client specified key of the client data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Metadata about the client data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual FieldMetadata Metadata { get; set; }

        /// <summary>The client specified value of the client data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A contact group.</summary>
    public class ContactGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The group's client data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientData")]
        public virtual System.Collections.Generic.IList<GroupClientData> ClientData { get; set; }

        /// <summary>
        /// The [HTTP entity tag](https://en.wikipedia.org/wiki/HTTP_ETag) of the resource. Used for web cache
        /// validation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Output only. The name translated and formatted in the viewer's account locale or the `Accept-Language` HTTP
        /// header locale for system groups names. Group names set by the owner are the same as name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedName")]
        public virtual string FormattedName { get; set; }

        /// <summary>Output only. The contact group type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupType")]
        public virtual string GroupType { get; set; }

        /// <summary>
        /// Output only. The total number of contacts in the group irrespective of max members in specified in the
        /// request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memberCount")]
        public virtual System.Nullable<int> MemberCount { get; set; }

        /// <summary>
        /// Output only. The list of contact person resource names that are members of the contact group. The field is
        /// only populated for GET requests and will only return as many members as `maxMembers` in the get request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memberResourceNames")]
        public virtual System.Collections.Generic.IList<string> MemberResourceNames { get; set; }

        /// <summary>Output only. Metadata about the contact group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ContactGroupMetadata Metadata { get; set; }

        /// <summary>
        /// The contact group name set by the group owner or a system provided name for system groups. For
        /// [`contactGroups.create`](/people/api/rest/v1/contactGroups/create) or
        /// [`contactGroups.update`](/people/api/rest/v1/contactGroups/update) the name must be unique to the users
        /// contact groups. Attempting to create a group with a duplicate name will return a HTTP 409 error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The resource name for the contact group, assigned by the server. An ASCII string, in the form of
        /// `contactGroups/{contact_group_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }
    }

    /// <summary>A Google contact group membership.</summary>
    public class ContactGroupMembership : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The contact group ID for the contact group membership.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactGroupId")]
        public virtual string ContactGroupId { get; set; }

        /// <summary>
        /// The resource name for the contact group, assigned by the server. An ASCII string, in the form of
        /// `contactGroups/{contact_group_id}`. Only contact_group_resource_name can be used for modifying memberships.
        /// Any contact group membership can be removed, but only user group or "myContacts" or "starred" system groups
        /// memberships can be added. A contact must always have at least one contact group membership.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactGroupResourceName")]
        public virtual string ContactGroupResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metadata about a contact group.</summary>
    public class ContactGroupMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. True if the contact group resource has been deleted. Populated only for
        /// [`ListContactGroups`](/people/api/rest/v1/contactgroups/list) requests that include a sync token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleted")]
        public virtual System.Nullable<bool> Deleted { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time the group was last updated.</summary>
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

    /// <summary>The response for a specific contact group.</summary>
    public class ContactGroupResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The contact group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactGroup")]
        public virtual ContactGroup ContactGroup { get; set; }

        /// <summary>The original requested resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedResourceName")]
        public virtual string RequestedResourceName { get; set; }

        /// <summary>The status of the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual Status Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A wrapper that contains the person data to populate a newly created source.</summary>
    public class ContactToCreate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The person data to populate a newly created source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactPerson")]
        public virtual Person ContactPerson { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to copy an "Other contact" to my contacts group.</summary>
    public class CopyOtherContactToMyContactsGroupRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A field mask to restrict which fields are copied into the new contact. Valid values are: *
        /// emailAddresses * names * phoneNumbers
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("copyMask")]
        public virtual object CopyMask { get; set; }

        /// <summary>
        /// Optional. A field mask to restrict which fields on the person are returned. Multiple fields can be specified
        /// by separating them with commas. Defaults to the copy mask with metadata and membership fields if not set.
        /// Valid values are: * addresses * ageRanges * biographies * birthdays * calendarUrls * clientData *
        /// coverPhotos * emailAddresses * events * externalIds * genders * imClients * interests * locales * locations
        /// * memberships * metadata * miscKeywords * names * nicknames * occupations * organizations * phoneNumbers *
        /// photos * relations * sipAddresses * skills * urls * userDefined
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readMask")]
        public virtual object ReadMask { get; set; }

        /// <summary>
        /// Optional. A mask of what source types to return. Defaults to READ_SOURCE_TYPE_CONTACT and
        /// READ_SOURCE_TYPE_PROFILE if not set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sources")]
        public virtual System.Collections.Generic.IList<string> Sources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A person's cover photo. A large image shown on the person's profile page that represents who they are or what
    /// they care about.
    /// </summary>
    public class CoverPhoto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// True if the cover photo is the default cover photo; false if the cover photo is a user-provided cover photo.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("default")]
        public virtual System.Nullable<bool> Default__ { get; set; }

        /// <summary>Metadata about the cover photo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual FieldMetadata Metadata { get; set; }

        /// <summary>The URL of the cover photo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to create a new contact group.</summary>
    public class CreateContactGroupRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The contact group to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactGroup")]
        public virtual ContactGroup ContactGroup { get; set; }

        /// <summary>
        /// Optional. A field mask to restrict which fields on the group are returned. Defaults to `metadata`,
        /// `groupType`, and `name` if not set or set to empty. Valid fields are: * clientData * groupType * metadata *
        /// name
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readGroupFields")]
        public virtual object ReadGroupFields { get; set; }

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

    /// <summary>The response for deleting a contact's photo.</summary>
    public class DeleteContactPhotoResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The updated person, if person_fields is set in the DeleteContactPhotoRequest; otherwise this will be unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("person")]
        public virtual Person Person { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Google Workspace Domain membership.</summary>
    public class DomainMembership : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>True if the person is in the viewer's Google Workspace domain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inViewerDomain")]
        public virtual System.Nullable<bool> InViewerDomain { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A person's email address.</summary>
    public class EmailAddress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The display name of the email.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. The type of the email address translated and formatted in the viewer's account locale or the
        /// `Accept-Language` HTTP header locale.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedType")]
        public virtual string FormattedType { get; set; }

        /// <summary>Metadata about the email address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual FieldMetadata Metadata { get; set; }

        /// <summary>
        /// The type of the email address. The type can be custom or one of these predefined values: * `home` * `work` *
        /// `other`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The email address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

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

    /// <summary>An event related to the person.</summary>
    public class Event : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The date of the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual Date Date { get; set; }

        /// <summary>
        /// Output only. The type of the event translated and formatted in the viewer's account locale or the
        /// `Accept-Language` HTTP header locale.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedType")]
        public virtual string FormattedType { get; set; }

        /// <summary>Metadata about the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual FieldMetadata Metadata { get; set; }

        /// <summary>
        /// The type of the event. The type can be custom or one of these predefined values: * `anniversary` * `other`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An identifier from an external entity related to the person.</summary>
    public class ExternalId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The type of the event translated and formatted in the viewer's account locale or the
        /// `Accept-Language` HTTP header locale.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedType")]
        public virtual string FormattedType { get; set; }

        /// <summary>Metadata about the external ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual FieldMetadata Metadata { get; set; }

        /// <summary>
        /// The type of the external ID. The type can be custom or one of these predefined values: * `account` *
        /// `customer` * `loginId` * `network` * `organization`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The value of the external ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata about a field.</summary>
    public class FieldMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. True if the field is the primary field for all sources in the person. Each person will have at
        /// most one field with `primary` set to true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primary")]
        public virtual System.Nullable<bool> Primary { get; set; }

        /// <summary>The source of the field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual Source Source { get; set; }

        /// <summary>
        /// True if the field is the primary field for the source. Each source must have at most one field with
        /// `source_primary` set to true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourcePrimary")]
        public virtual System.Nullable<bool> SourcePrimary { get; set; }

        /// <summary>
        /// Output only. True if the field is verified; false if the field is unverified. A verified field is typically
        /// a name, email address, phone number, or website that has been confirmed to be owned by the person.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verified")]
        public virtual System.Nullable<bool> Verified { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The name that should be used to sort the person in a list.</summary>
    public class FileAs : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Metadata about the file-as.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual FieldMetadata Metadata { get; set; }

        /// <summary>The file-as value</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A person's gender.</summary>
    public class Gender : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Free form text field for pronouns that should be used to address the person. Common values are: * `he`/`him`
        /// * `she`/`her` * `they`/`them`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addressMeAs")]
        public virtual string AddressMeAs { get; set; }

        /// <summary>
        /// Output only. The value of the gender translated and formatted in the viewer's account locale or the
        /// `Accept-Language` HTTP header locale. Unspecified or custom value are not localized.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedValue")]
        public virtual string FormattedValue { get; set; }

        /// <summary>Metadata about the gender.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual FieldMetadata Metadata { get; set; }

        /// <summary>
        /// The gender for the person. The gender can be custom or one of these predefined values: * `male` * `female` *
        /// `unspecified`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response to a get request for a list of people by resource name.</summary>
    public class GetPeopleResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The response for each requested resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responses")]
        public virtual System.Collections.Generic.IList<PersonResponse> Responses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Arbitrary client data that is populated by clients. Duplicate keys and values are allowed.</summary>
    public class GroupClientData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The client specified key of the client data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The client specified value of the client data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A person's instant messaging client.</summary>
    public class ImClient : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The protocol of the IM client formatted in the viewer's account locale or the `Accept-Language`
        /// HTTP header locale.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedProtocol")]
        public virtual string FormattedProtocol { get; set; }

        /// <summary>
        /// Output only. The type of the IM client translated and formatted in the viewer's account locale or the
        /// `Accept-Language` HTTP header locale.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedType")]
        public virtual string FormattedType { get; set; }

        /// <summary>Metadata about the IM client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual FieldMetadata Metadata { get; set; }

        /// <summary>
        /// The protocol of the IM client. The protocol can be custom or one of these predefined values: * `aim` * `msn`
        /// * `yahoo` * `skype` * `qq` * `googleTalk` * `icq` * `jabber` * `netMeeting`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protocol")]
        public virtual string Protocol { get; set; }

        /// <summary>
        /// The type of the IM client. The type can be custom or one of these predefined values: * `home` * `work` *
        /// `other`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The user name used in the IM client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>One of the person's interests.</summary>
    public class Interest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Metadata about the interest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual FieldMetadata Metadata { get; set; }

        /// <summary>The interest; for example, `stargazing`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response to a request for the authenticated user's connections.</summary>
    public class ListConnectionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of people that the requestor is connected to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connections")]
        public virtual System.Collections.Generic.IList<Person> Connections { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// A token, which can be sent as `sync_token` to retrieve changes since the last request. Request must set
        /// `request_sync_token` to return the sync token. When the response is paginated, only the last page will
        /// contain `nextSyncToken`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextSyncToken")]
        public virtual string NextSyncToken { get; set; }

        /// <summary>The total number of items in the list without pagination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalItems")]
        public virtual System.Nullable<int> TotalItems { get; set; }

        /// <summary>
        /// **DEPRECATED** (Please use totalItems) The total number of people in the list without pagination.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalPeople")]
        public virtual System.Nullable<int> TotalPeople { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response to a list contact groups request.</summary>
    public class ListContactGroupsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of contact groups. Members of the contact groups are not populated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactGroups")]
        public virtual System.Collections.Generic.IList<ContactGroup> ContactGroups { get; set; }

        /// <summary>The token that can be used to retrieve the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The token that can be used to retrieve changes since the last request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextSyncToken")]
        public virtual string NextSyncToken { get; set; }

        /// <summary>The total number of items in the list without pagination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalItems")]
        public virtual System.Nullable<int> TotalItems { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response to a request for the authenticated user's domain directory.</summary>
    public class ListDirectoryPeopleResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// A token, which can be sent as `sync_token` to retrieve changes since the last request. Request must set
        /// `request_sync_token` to return the sync token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextSyncToken")]
        public virtual string NextSyncToken { get; set; }

        /// <summary>The list of people in the domain directory.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("people")]
        public virtual System.Collections.Generic.IList<Person> People { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response to a request for the authenticated user's "Other contacts".</summary>
    public class ListOtherContactsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// A token, which can be sent as `sync_token` to retrieve changes since the last request. Request must set
        /// `request_sync_token` to return the sync token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextSyncToken")]
        public virtual string NextSyncToken { get; set; }

        /// <summary>
        /// The list of "Other contacts" returned as Person resources. "Other contacts" support a limited subset of
        /// fields. See ListOtherContactsRequest.request_mask for more detailed information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("otherContacts")]
        public virtual System.Collections.Generic.IList<Person> OtherContacts { get; set; }

        /// <summary>The total number of other contacts in the list without pagination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A person's locale preference.</summary>
    public class Locale : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Metadata about the locale.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual FieldMetadata Metadata { get; set; }

        /// <summary>
        /// The well-formed [IETF BCP 47](https://tools.ietf.org/html/bcp47) language tag representing the locale.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A person's location.</summary>
    public class Location : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The building identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildingId")]
        public virtual string BuildingId { get; set; }

        /// <summary>Whether the location is the current location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("current")]
        public virtual System.Nullable<bool> Current { get; set; }

        /// <summary>The individual desk location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deskCode")]
        public virtual string DeskCode { get; set; }

        /// <summary>The floor name or number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floor")]
        public virtual string Floor { get; set; }

        /// <summary>The floor section in `floor_name`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floorSection")]
        public virtual string FloorSection { get; set; }

        /// <summary>Metadata about the location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual FieldMetadata Metadata { get; set; }

        /// <summary>
        /// The type of the location. The type can be custom or one of these predefined values: * `desk` * `grewUp`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The free-form value of the location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A person's membership in a group. Only contact group memberships can be modified.</summary>
    public class Membership : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The contact group membership.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactGroupMembership")]
        public virtual ContactGroupMembership ContactGroupMembership { get; set; }

        /// <summary>Output only. The domain membership.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainMembership")]
        public virtual DomainMembership DomainMembership { get; set; }

        /// <summary>Metadata about the membership.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual FieldMetadata Metadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A person's miscellaneous keyword.</summary>
    public class MiscKeyword : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The type of the miscellaneous keyword translated and formatted in the viewer's account locale
        /// or the `Accept-Language` HTTP header locale.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedType")]
        public virtual string FormattedType { get; set; }

        /// <summary>Metadata about the miscellaneous keyword.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual FieldMetadata Metadata { get; set; }

        /// <summary>The miscellaneous keyword type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The value of the miscellaneous keyword.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A request to modify an existing contact group's members. Contacts can be removed from any group but they can
    /// only be added to a user group or "myContacts" or "starred" system groups.
    /// </summary>
    public class ModifyContactGroupMembersRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The resource names of the contact people to add in the form of `people/{person_id}`. The total
        /// number of resource names in `resource_names_to_add` and `resource_names_to_remove` must be less than or
        /// equal to 1000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceNamesToAdd")]
        public virtual System.Collections.Generic.IList<string> ResourceNamesToAdd { get; set; }

        /// <summary>
        /// Optional. The resource names of the contact people to remove in the form of `people/{person_id}`. The total
        /// number of resource names in `resource_names_to_add` and `resource_names_to_remove` must be less than or
        /// equal to 1000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceNamesToRemove")]
        public virtual System.Collections.Generic.IList<string> ResourceNamesToRemove { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response to a modify contact group members request.</summary>
    public class ModifyContactGroupMembersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The contact people resource names that cannot be removed from their last contact group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canNotRemoveLastContactGroupResourceNames")]
        public virtual System.Collections.Generic.IList<string> CanNotRemoveLastContactGroupResourceNames { get; set; }

        /// <summary>The contact people resource names that were not found.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notFoundResourceNames")]
        public virtual System.Collections.Generic.IList<string> NotFoundResourceNames { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A person's name. If the name is a mononym, the family name is empty.</summary>
    public class Name : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The display name formatted according to the locale specified by the viewer's account or the
        /// `Accept-Language` HTTP header.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. The display name with the last name first formatted according to the locale specified by the
        /// viewer's account or the `Accept-Language` HTTP header.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayNameLastFirst")]
        public virtual string DisplayNameLastFirst { get; set; }

        /// <summary>The family name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("familyName")]
        public virtual string FamilyName { get; set; }

        /// <summary>The given name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("givenName")]
        public virtual string GivenName { get; set; }

        /// <summary>The honorific prefixes, such as `Mrs.` or `Dr.`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("honorificPrefix")]
        public virtual string HonorificPrefix { get; set; }

        /// <summary>The honorific suffixes, such as `Jr.`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("honorificSuffix")]
        public virtual string HonorificSuffix { get; set; }

        /// <summary>Metadata about the name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual FieldMetadata Metadata { get; set; }

        /// <summary>The middle name(s).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("middleName")]
        public virtual string MiddleName { get; set; }

        /// <summary>The family name spelled as it sounds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneticFamilyName")]
        public virtual string PhoneticFamilyName { get; set; }

        /// <summary>The full name spelled as it sounds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneticFullName")]
        public virtual string PhoneticFullName { get; set; }

        /// <summary>The given name spelled as it sounds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneticGivenName")]
        public virtual string PhoneticGivenName { get; set; }

        /// <summary>The honorific prefixes spelled as they sound.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneticHonorificPrefix")]
        public virtual string PhoneticHonorificPrefix { get; set; }

        /// <summary>The honorific suffixes spelled as they sound.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneticHonorificSuffix")]
        public virtual string PhoneticHonorificSuffix { get; set; }

        /// <summary>The middle name(s) spelled as they sound.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneticMiddleName")]
        public virtual string PhoneticMiddleName { get; set; }

        /// <summary>The free form name value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unstructuredName")]
        public virtual string UnstructuredName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A person's nickname.</summary>
    public class Nickname : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Metadata about the nickname.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual FieldMetadata Metadata { get; set; }

        /// <summary>The type of the nickname.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The nickname.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A person's occupation.</summary>
    public class Occupation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Metadata about the occupation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual FieldMetadata Metadata { get; set; }

        /// <summary>The occupation; for example, `carpenter`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A person's past or current organization. Overlapping date ranges are permitted.</summary>
    public class Organization : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The person's cost center at the organization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("costCenter")]
        public virtual string CostCenter { get; set; }

        /// <summary>
        /// True if the organization is the person's current organization; false if the organization is a past
        /// organization.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("current")]
        public virtual System.Nullable<bool> Current { get; set; }

        /// <summary>The person's department at the organization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("department")]
        public virtual string Department { get; set; }

        /// <summary>The domain name associated with the organization; for example, `google.com`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>The end date when the person left the organization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual Date EndDate { get; set; }

        /// <summary>
        /// Output only. The type of the organization translated and formatted in the viewer's account locale or the
        /// `Accept-Language` HTTP header locale.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedType")]
        public virtual string FormattedType { get; set; }

        /// <summary>The person's full-time equivalent millipercent within the organization (100000 = 100%).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullTimeEquivalentMillipercent")]
        public virtual System.Nullable<int> FullTimeEquivalentMillipercent { get; set; }

        /// <summary>The person's job description at the organization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobDescription")]
        public virtual string JobDescription { get; set; }

        /// <summary>The location of the organization office the person works at.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>Metadata about the organization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual FieldMetadata Metadata { get; set; }

        /// <summary>The name of the organization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The phonetic name of the organization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneticName")]
        public virtual string PhoneticName { get; set; }

        /// <summary>The start date when the person joined the organization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual Date StartDate { get; set; }

        /// <summary>
        /// The symbol associated with the organization; for example, a stock ticker symbol, abbreviation, or acronym.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("symbol")]
        public virtual string Symbol { get; set; }

        /// <summary>The person's job title at the organization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>
        /// The type of the organization. The type can be custom or one of these predefined values: * `work` * `school`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information about a person merged from various data sources such as the authenticated user's contacts and
    /// profile data. Most fields can have multiple items. The items in a field have no guaranteed order, but each
    /// non-empty field is guaranteed to have exactly one field with `metadata.primary` set to true.
    /// </summary>
    public class Person : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The person's street addresses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addresses")]
        public virtual System.Collections.Generic.IList<Address> Addresses { get; set; }

        /// <summary>
        /// Output only. **DEPRECATED** (Please use `person.ageRanges` instead) The person's age range.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ageRange")]
        public virtual string AgeRange { get; set; }

        /// <summary>Output only. The person's age ranges.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ageRanges")]
        public virtual System.Collections.Generic.IList<AgeRangeType> AgeRanges { get; set; }

        /// <summary>The person's biographies. This field is a singleton for contact sources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("biographies")]
        public virtual System.Collections.Generic.IList<Biography> Biographies { get; set; }

        /// <summary>The person's birthdays. This field is a singleton for contact sources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("birthdays")]
        public virtual System.Collections.Generic.IList<Birthday> Birthdays { get; set; }

        /// <summary>**DEPRECATED**: No data will be returned The person's bragging rights.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("braggingRights")]
        public virtual System.Collections.Generic.IList<BraggingRights> BraggingRights { get; set; }

        /// <summary>The person's calendar URLs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("calendarUrls")]
        public virtual System.Collections.Generic.IList<CalendarUrl> CalendarUrls { get; set; }

        /// <summary>The person's client data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientData")]
        public virtual System.Collections.Generic.IList<ClientData> ClientData { get; set; }

        /// <summary>Output only. The person's cover photos.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("coverPhotos")]
        public virtual System.Collections.Generic.IList<CoverPhoto> CoverPhotos { get; set; }

        /// <summary>
        /// The person's email addresses. For `people.connections.list` and `otherContacts.list` the number of email
        /// addresses is limited to 100. If a Person has more email addresses the entire set can be obtained by calling
        /// GetPeople.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailAddresses")]
        public virtual System.Collections.Generic.IList<EmailAddress> EmailAddresses { get; set; }

        /// <summary>
        /// The [HTTP entity tag](https://en.wikipedia.org/wiki/HTTP_ETag) of the resource. Used for web cache
        /// validation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The person's events.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("events")]
        public virtual System.Collections.Generic.IList<Event> Events { get; set; }

        /// <summary>The person's external IDs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalIds")]
        public virtual System.Collections.Generic.IList<ExternalId> ExternalIds { get; set; }

        /// <summary>The person's file-ases.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileAses")]
        public virtual System.Collections.Generic.IList<FileAs> FileAses { get; set; }

        /// <summary>The person's genders. This field is a singleton for contact sources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("genders")]
        public virtual System.Collections.Generic.IList<Gender> Genders { get; set; }

        /// <summary>The person's instant messaging clients.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imClients")]
        public virtual System.Collections.Generic.IList<ImClient> ImClients { get; set; }

        /// <summary>The person's interests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interests")]
        public virtual System.Collections.Generic.IList<Interest> Interests { get; set; }

        /// <summary>The person's locale preferences.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locales")]
        public virtual System.Collections.Generic.IList<Locale> Locales { get; set; }

        /// <summary>The person's locations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<Location> Locations { get; set; }

        /// <summary>The person's group memberships.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memberships")]
        public virtual System.Collections.Generic.IList<Membership> Memberships { get; set; }

        /// <summary>Output only. Metadata about the person.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual PersonMetadata Metadata { get; set; }

        /// <summary>The person's miscellaneous keywords.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("miscKeywords")]
        public virtual System.Collections.Generic.IList<MiscKeyword> MiscKeywords { get; set; }

        /// <summary>The person's names. This field is a singleton for contact sources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("names")]
        public virtual System.Collections.Generic.IList<Name> Names { get; set; }

        /// <summary>The person's nicknames.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nicknames")]
        public virtual System.Collections.Generic.IList<Nickname> Nicknames { get; set; }

        /// <summary>The person's occupations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("occupations")]
        public virtual System.Collections.Generic.IList<Occupation> Occupations { get; set; }

        /// <summary>The person's past or current organizations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organizations")]
        public virtual System.Collections.Generic.IList<Organization> Organizations { get; set; }

        /// <summary>
        /// The person's phone numbers. For `people.connections.list` and `otherContacts.list` the number of phone
        /// numbers is limited to 100. If a Person has more phone numbers the entire set can be obtained by calling
        /// GetPeople.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneNumbers")]
        public virtual System.Collections.Generic.IList<PhoneNumber> PhoneNumbers { get; set; }

        /// <summary>Output only. The person's photos.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("photos")]
        public virtual System.Collections.Generic.IList<Photo> Photos { get; set; }

        /// <summary>The person's relations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relations")]
        public virtual System.Collections.Generic.IList<Relation> Relations { get; set; }

        /// <summary>
        /// Output only. **DEPRECATED**: No data will be returned The person's relationship interests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relationshipInterests")]
        public virtual System.Collections.Generic.IList<RelationshipInterest> RelationshipInterests { get; set; }

        /// <summary>Output only. **DEPRECATED**: No data will be returned The person's relationship statuses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relationshipStatuses")]
        public virtual System.Collections.Generic.IList<RelationshipStatus> RelationshipStatuses { get; set; }

        /// <summary>**DEPRECATED**: (Please use `person.locations` instead) The person's residences.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("residences")]
        public virtual System.Collections.Generic.IList<Residence> Residences { get; set; }

        /// <summary>
        /// The resource name for the person, assigned by the server. An ASCII string in the form of
        /// `people/{person_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The person's SIP addresses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sipAddresses")]
        public virtual System.Collections.Generic.IList<SipAddress> SipAddresses { get; set; }

        /// <summary>The person's skills.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skills")]
        public virtual System.Collections.Generic.IList<Skill> Skills { get; set; }

        /// <summary>Output only. **DEPRECATED**: No data will be returned The person's taglines.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taglines")]
        public virtual System.Collections.Generic.IList<Tagline> Taglines { get; set; }

        /// <summary>The person's associated URLs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("urls")]
        public virtual System.Collections.Generic.IList<Url> Urls { get; set; }

        /// <summary>The person's user defined data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userDefined")]
        public virtual System.Collections.Generic.IList<UserDefined> UserDefined { get; set; }
    }

    /// <summary>The metadata about a person.</summary>
    public class PersonMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. True if the person resource has been deleted. Populated only for `people.connections.list` and
        /// `otherContacts.list` sync requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleted")]
        public virtual System.Nullable<bool> Deleted { get; set; }

        /// <summary>Output only. Resource names of people linked to this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkedPeopleResourceNames")]
        public virtual System.Collections.Generic.IList<string> LinkedPeopleResourceNames { get; set; }

        /// <summary>
        /// Output only. **DEPRECATED** (Please use `person.metadata.sources.profileMetadata.objectType` instead) The
        /// type of the person object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectType")]
        public virtual string ObjectType { get; set; }

        /// <summary>
        /// Output only. Any former resource names this person has had. Populated only for `people.connections.list`
        /// requests that include a sync token. The resource name may change when adding or removing fields that link a
        /// contact and profile such as a verified email, verified phone number, or profile URL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousResourceNames")]
        public virtual System.Collections.Generic.IList<string> PreviousResourceNames { get; set; }

        /// <summary>The sources of data for the person.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sources")]
        public virtual System.Collections.Generic.IList<Source> Sources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for a single person</summary>
    public class PersonResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// **DEPRECATED** (Please use status instead) [HTTP 1.1 status code]
        /// (http://www.w3.org/Protocols/rfc2616/rfc2616-sec10.html).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpStatusCode")]
        public virtual System.Nullable<int> HttpStatusCode { get; set; }

        /// <summary>The person.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("person")]
        public virtual Person Person { get; set; }

        /// <summary>
        /// The original requested resource name. May be different than the resource name on the returned person. The
        /// resource name can change when adding or removing fields that link a contact and profile such as a verified
        /// email, verified phone number, or a profile URL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedResourceName")]
        public virtual string RequestedResourceName { get; set; }

        /// <summary>The status of the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual Status Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A person's phone number.</summary>
    public class PhoneNumber : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The canonicalized [ITU-T
        /// E.164](https://law.resource.org/pub/us/cfr/ibr/004/itu-t.E.164.1.2008.pdf) form of the phone number.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalForm")]
        public virtual string CanonicalForm { get; set; }

        /// <summary>
        /// Output only. The type of the phone number translated and formatted in the viewer's account locale or the
        /// `Accept-Language` HTTP header locale.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedType")]
        public virtual string FormattedType { get; set; }

        /// <summary>Metadata about the phone number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual FieldMetadata Metadata { get; set; }

        /// <summary>
        /// The type of the phone number. The type can be custom or one of these predefined values: * `home` * `work` *
        /// `mobile` * `homeFax` * `workFax` * `otherFax` * `pager` * `workMobile` * `workPager` * `main` *
        /// `googleVoice` * `other`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The phone number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A person's photo. A picture shown next to the person's name to help others recognize the person.
    /// </summary>
    public class Photo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>True if the photo is a default photo; false if the photo is a user-provided photo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("default")]
        public virtual System.Nullable<bool> Default__ { get; set; }

        /// <summary>Metadata about the photo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual FieldMetadata Metadata { get; set; }

        /// <summary>
        /// The URL of the photo. You can change the desired size by appending a query parameter `sz={size}` at the end
        /// of the url, where {size} is the size in pixels. Example:
        /// https://lh3.googleusercontent.com/-T_wVWLlmg7w/AAAAAAAAAAI/AAAAAAAABa8/00gzXvDBYqw/s100/photo.jpg?sz=50
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metadata about a profile.</summary>
    public class ProfileMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The profile object type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectType")]
        public virtual string ObjectType { get; set; }

        /// <summary>Output only. The user types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userTypes")]
        public virtual System.Collections.Generic.IList<string> UserTypes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A person's relation to another person.</summary>
    public class Relation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The type of the relation translated and formatted in the viewer's account locale or the locale
        /// specified in the Accept-Language HTTP header.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedType")]
        public virtual string FormattedType { get; set; }

        /// <summary>Metadata about the relation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual FieldMetadata Metadata { get; set; }

        /// <summary>The name of the other person this relation refers to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("person")]
        public virtual string Person { get; set; }

        /// <summary>
        /// The person's relation to the other person. The type can be custom or one of these predefined values: *
        /// `spouse` * `child` * `mother` * `father` * `parent` * `brother` * `sister` * `friend` * `relative` *
        /// `domesticPartner` * `manager` * `assistant` * `referredBy` * `partner`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>**DEPRECATED**: No data will be returned A person's relationship interest .</summary>
    public class RelationshipInterest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The value of the relationship interest translated and formatted in the viewer's account locale
        /// or the locale specified in the Accept-Language HTTP header.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedValue")]
        public virtual string FormattedValue { get; set; }

        /// <summary>Metadata about the relationship interest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual FieldMetadata Metadata { get; set; }

        /// <summary>
        /// The kind of relationship the person is looking for. The value can be custom or one of these predefined
        /// values: * `friend` * `date` * `relationship` * `networking`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>**DEPRECATED**: No data will be returned A person's relationship status.</summary>
    public class RelationshipStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The value of the relationship status translated and formatted in the viewer's account locale or
        /// the `Accept-Language` HTTP header locale.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedValue")]
        public virtual string FormattedValue { get; set; }

        /// <summary>Metadata about the relationship status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual FieldMetadata Metadata { get; set; }

        /// <summary>
        /// The relationship status. The value can be custom or one of these predefined values: * `single` *
        /// `inARelationship` * `engaged` * `married` * `itsComplicated` * `openRelationship` * `widowed` *
        /// `inDomesticPartnership` * `inCivilUnion`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>**DEPRECATED**: Please use `person.locations` instead. A person's past or current residence.</summary>
    public class Residence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// True if the residence is the person's current residence; false if the residence is a past residence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("current")]
        public virtual System.Nullable<bool> Current { get; set; }

        /// <summary>Metadata about the residence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual FieldMetadata Metadata { get; set; }

        /// <summary>The address of the residence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The response to a request for people in the authenticated user's domain directory that match the specified
    /// query.
    /// </summary>
    public class SearchDirectoryPeopleResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of people in the domain directory that match the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("people")]
        public virtual System.Collections.Generic.IList<Person> People { get; set; }

        /// <summary>The total number of items in the list without pagination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response to a search request for the authenticated user, given a query.</summary>
    public class SearchResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The results of the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<SearchResult> Results { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A result of a search query.</summary>
    public class SearchResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The matched Person.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("person")]
        public virtual Person Person { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A person's SIP address. Session Initial Protocol addresses are used for VoIP communications to make voice or
    /// video calls over the internet.
    /// </summary>
    public class SipAddress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The type of the SIP address translated and formatted in the viewer's account locale or the
        /// `Accept-Language` HTTP header locale.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedType")]
        public virtual string FormattedType { get; set; }

        /// <summary>Metadata about the SIP address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual FieldMetadata Metadata { get; set; }

        /// <summary>
        /// The type of the SIP address. The type can be custom or or one of these predefined values: * `home` * `work`
        /// * `mobile` * `other`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// The SIP address in the [RFC 3261 19.1](https://tools.ietf.org/html/rfc3261#section-19.1) SIP URI format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A skill that the person has.</summary>
    public class Skill : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Metadata about the skill.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual FieldMetadata Metadata { get; set; }

        /// <summary>The skill; for example, `underwater basket weaving`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The source of a field.</summary>
    public class Source : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// **Only populated in `person.metadata.sources`.** The [HTTP entity
        /// tag](https://en.wikipedia.org/wiki/HTTP_ETag) of the source. Used for web cache validation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The unique identifier within the source type generated by the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Output only. **Only populated in `person.metadata.sources`.** Metadata about a source of type PROFILE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profileMetadata")]
        public virtual ProfileMetadata ProfileMetadata { get; set; }

        /// <summary>The source type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// Output only. **Only populated in `person.metadata.sources`.** Last update timestamp of this source.
        /// </summary>
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

    /// <summary>**DEPRECATED**: No data will be returned A brief one-line description of the person.</summary>
    public class Tagline : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Metadata about the tagline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual FieldMetadata Metadata { get; set; }

        /// <summary>The tagline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to update an existing user contact group. All updated fields will be replaced.</summary>
    public class UpdateContactGroupRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The contact group to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactGroup")]
        public virtual ContactGroup ContactGroup { get; set; }

        /// <summary>
        /// Optional. A field mask to restrict which fields on the group are returned. Defaults to `metadata`,
        /// `groupType`, and `name` if not set or set to empty. Valid fields are: * clientData * groupType * memberCount
        /// * metadata * name
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readGroupFields")]
        public virtual object ReadGroupFields { get; set; }

        /// <summary>
        /// Optional. A field mask to restrict which fields on the group are updated. Multiple fields can be specified
        /// by separating them with commas. Defaults to `name` if not set or set to empty. Updated fields are replaced.
        /// Valid values are: * clientData * name
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateGroupFields")]
        public virtual object UpdateGroupFields { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A request to update an existing contact's photo. All requests must have a valid photo format: JPEG or PNG.
    /// </summary>
    public class UpdateContactPhotoRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A field mask to restrict which fields on the person are returned. Multiple fields can be specified
        /// by separating them with commas. Defaults to empty if not set, which will skip the post mutate get. Valid
        /// values are: * addresses * ageRanges * biographies * birthdays * calendarUrls * clientData * coverPhotos *
        /// emailAddresses * events * externalIds * genders * imClients * interests * locales * locations * memberships
        /// * metadata * miscKeywords * names * nicknames * occupations * organizations * phoneNumbers * photos *
        /// relations * sipAddresses * skills * urls * userDefined
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("personFields")]
        public virtual object PersonFields { get; set; }

        /// <summary>Required. Raw photo bytes</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("photoBytes")]
        public virtual string PhotoBytes { get; set; }

        /// <summary>
        /// Optional. A mask of what source types to return. Defaults to READ_SOURCE_TYPE_CONTACT and
        /// READ_SOURCE_TYPE_PROFILE if not set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sources")]
        public virtual System.Collections.Generic.IList<string> Sources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for updating a contact's photo.</summary>
    public class UpdateContactPhotoResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The updated person, if person_fields is set in the UpdateContactPhotoRequest; otherwise this will be unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("person")]
        public virtual Person Person { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A person's associated URLs.</summary>
    public class Url : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The type of the URL translated and formatted in the viewer's account locale or the
        /// `Accept-Language` HTTP header locale.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedType")]
        public virtual string FormattedType { get; set; }

        /// <summary>Metadata about the URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual FieldMetadata Metadata { get; set; }

        /// <summary>
        /// The type of the URL. The type can be custom or one of these predefined values: * `home` * `work` * `blog` *
        /// `profile` * `homePage` * `ftp` * `reservations` * `appInstallPage`: website for a Currents application. *
        /// `other`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Arbitrary user data that is populated by the end users.</summary>
    public class UserDefined : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The end user specified key of the user defined data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Metadata about the user defined data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual FieldMetadata Metadata { get; set; }

        /// <summary>The end user specified value of the user defined data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
