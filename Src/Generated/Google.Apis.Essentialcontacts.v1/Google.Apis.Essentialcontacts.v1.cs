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

namespace Google.Apis.Essentialcontacts.v1
{
    /// <summary>The Essentialcontacts Service.</summary>
    public class EssentialcontactsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public EssentialcontactsService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public EssentialcontactsService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Folders = new FoldersResource(this);
            Organizations = new OrganizationsResource(this);
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "essentialcontacts";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://essentialcontacts.googleapis.com/";
        #else
            "https://essentialcontacts.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://essentialcontacts.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Essential Contacts API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Essential Contacts API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Folders resource.</summary>
        public virtual FoldersResource Folders { get; }

        /// <summary>Gets the Organizations resource.</summary>
        public virtual OrganizationsResource Organizations { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for Essentialcontacts requests.</summary>
    public abstract class EssentialcontactsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new EssentialcontactsBaseServiceRequest instance.</summary>
        protected EssentialcontactsBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Essentialcontacts parameter list.</summary>
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

    /// <summary>The "folders" collection of methods.</summary>
    public class FoldersResource
    {
        private const string Resource = "folders";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public FoldersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Contacts = new ContactsResource(service);
        }

        /// <summary>Gets the Contacts resource.</summary>
        public virtual ContactsResource Contacts { get; }

        /// <summary>The "contacts" collection of methods.</summary>
        public class ContactsResource
        {
            private const string Resource = "contacts";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ContactsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Lists all contacts for the resource that are subscribed to the specified notification categories,
            /// including contacts inherited from any parent resources.
            /// </summary>
            /// <param name="parent">
            /// Required. The name of the resource to compute contacts for. Format: organizations/{organization_id},
            /// folders/{folder_id} or projects/{project_id}
            /// </param>
            public virtual ComputeRequest Compute(string parent)
            {
                return new ComputeRequest(service, parent);
            }

            /// <summary>
            /// Lists all contacts for the resource that are subscribed to the specified notification categories,
            /// including contacts inherited from any parent resources.
            /// </summary>
            public class ComputeRequest : EssentialcontactsBaseServiceRequest<Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1ComputeContactsResponse>
            {
                /// <summary>Constructs a new Compute request.</summary>
                public ComputeRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the resource to compute contacts for. Format: organizations/{organization_id},
                /// folders/{folder_id} or projects/{project_id}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The categories of notifications to compute contacts for. If ALL is included in this list, contacts
                /// subscribed to any notification category will be returned.
                /// </summary>
                /// <remarks>
                /// Use this property to set a single value for the parameter, or
                /// <see cref="NotificationCategoriesList"/> to set multiple values. Do not set both properties.
                /// </remarks>
                [Google.Apis.Util.RequestParameterAttribute("notificationCategories", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<NotificationCategoriesEnum> NotificationCategories { get; set; }

                /// <summary>
                /// The categories of notifications to compute contacts for. If ALL is included in this list, contacts
                /// subscribed to any notification category will be returned.
                /// </summary>
                /// <remarks>
                /// Use this property to set one or more values for the parameter. Do not set both this property and
                /// <see cref="NotificationCategories"/>.
                /// </remarks>
                [Google.Apis.Util.RequestParameterAttribute("notificationCategories", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<NotificationCategoriesEnum> NotificationCategoriesList { get; set; }

                /// <summary>
                /// The categories of notifications to compute contacts for. If ALL is included in this list, contacts
                /// subscribed to any notification category will be returned.
                /// </summary>
                public enum NotificationCategoriesEnum
                {
                    /// <summary>Notification category is unrecognized or unspecified.</summary>
                    [Google.Apis.Util.StringValueAttribute("NOTIFICATION_CATEGORY_UNSPECIFIED")]
                    NOTIFICATIONCATEGORYUNSPECIFIED = 0,

                    /// <summary>
                    /// All notifications related to the resource, including notifications pertaining to categories
                    /// added in the future.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALL")]
                    ALL = 1,

                    /// <summary>Notifications related to imminent account suspension.</summary>
                    [Google.Apis.Util.StringValueAttribute("SUSPENSION")]
                    SUSPENSION = 2,

                    /// <summary>
                    /// Notifications related to security/privacy incidents, notifications, and vulnerabilities.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("SECURITY")]
                    SECURITY = 3,

                    /// <summary>
                    /// Notifications related to technical events and issues such as outages, errors, or bugs.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("TECHNICAL")]
                    TECHNICAL = 4,

                    /// <summary>
                    /// Notifications related to billing and payments notifications, price updates, errors, or credits.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("BILLING")]
                    BILLING = 5,

                    /// <summary>
                    /// Notifications related to enforcement actions, regulatory compliance, or government notices.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("LEGAL")]
                    LEGAL = 6,

                    /// <summary>
                    /// Notifications related to new versions, product terms updates, or deprecations.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("PRODUCT_UPDATES")]
                    PRODUCTUPDATES = 7,

                    /// <summary>
                    /// Child category of TECHNICAL. If assigned, technical incident notifications will go to these
                    /// contacts instead of TECHNICAL.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("TECHNICAL_INCIDENTS")]
                    TECHNICALINCIDENTS = 8,
                }

                /// <summary>
                /// Optional. The maximum number of results to return from this request. Non-positive values are
                /// ignored. The presence of `next_page_token` in the response indicates that more results might be
                /// available. If not specified, the default page_size is 100.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. If present, retrieves the next batch of results from the preceding call to this method.
                /// `page_token` must be the value of `next_page_token` from the previous response. The values of other
                /// method parameters should be identical to those in the previous call.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "compute";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/contacts:compute";

                /// <summary>Initializes Compute parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^folders/[^/]+$",
                    });
                    RequestParameters.Add("notificationCategories", new Google.Apis.Discovery.Parameter
                    {
                        Name = "notificationCategories",
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

            /// <summary>Adds a new contact for a resource.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The resource to save this contact for. Format: organizations/{organization_id},
            /// folders/{folder_id} or projects/{project_id}
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1Contact body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Adds a new contact for a resource.</summary>
            public class CreateRequest : EssentialcontactsBaseServiceRequest<Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1Contact>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1Contact body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource to save this contact for. Format: organizations/{organization_id},
                /// folders/{folder_id} or projects/{project_id}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1Contact Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/contacts";

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
                        Pattern = @"^folders/[^/]+$",
                    });
                }
            }

            /// <summary>Deletes a contact.</summary>
            /// <param name="name">
            /// Required. The name of the contact to delete. Format:
            /// organizations/{organization_id}/contacts/{contact_id}, folders/{folder_id}/contacts/{contact_id} or
            /// projects/{project_id}/contacts/{contact_id}
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes a contact.</summary>
            public class DeleteRequest : EssentialcontactsBaseServiceRequest<Google.Apis.Essentialcontacts.v1.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the contact to delete. Format:
                /// organizations/{organization_id}/contacts/{contact_id}, folders/{folder_id}/contacts/{contact_id} or
                /// projects/{project_id}/contacts/{contact_id}
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
                        Pattern = @"^folders/[^/]+/contacts/[^/]+$",
                    });
                }
            }

            /// <summary>Gets a single contact.</summary>
            /// <param name="name">
            /// Required. The name of the contact to retrieve. Format:
            /// organizations/{organization_id}/contacts/{contact_id}, folders/{folder_id}/contacts/{contact_id} or
            /// projects/{project_id}/contacts/{contact_id}
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets a single contact.</summary>
            public class GetRequest : EssentialcontactsBaseServiceRequest<Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1Contact>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the contact to retrieve. Format:
                /// organizations/{organization_id}/contacts/{contact_id}, folders/{folder_id}/contacts/{contact_id} or
                /// projects/{project_id}/contacts/{contact_id}
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
                        Pattern = @"^folders/[^/]+/contacts/[^/]+$",
                    });
                }
            }

            /// <summary>Lists the contacts that have been set on a resource.</summary>
            /// <param name="parent">
            /// Required. The parent resource name. Format: organizations/{organization_id}, folders/{folder_id} or
            /// projects/{project_id}
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists the contacts that have been set on a resource.</summary>
            public class ListRequest : EssentialcontactsBaseServiceRequest<Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1ListContactsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent resource name. Format: organizations/{organization_id}, folders/{folder_id} or
                /// projects/{project_id}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of results to return from this request. Non-positive values are
                /// ignored. The presence of `next_page_token` in the response indicates that more results might be
                /// available. If not specified, the default page_size is 100.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. If present, retrieves the next batch of results from the preceding call to this method.
                /// `page_token` must be the value of `next_page_token` from the previous response. The values of other
                /// method parameters should be identical to those in the previous call.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/contacts";

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
                        Pattern = @"^folders/[^/]+$",
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

            /// <summary>Updates a contact. Note: A contact's email address cannot be changed.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Output only. The identifier for the contact. Format: {resource_type}/{resource_id}/contacts/{contact_id}
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1Contact body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates a contact. Note: A contact's email address cannot be changed.</summary>
            public class PatchRequest : EssentialcontactsBaseServiceRequest<Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1Contact>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1Contact body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Output only. The identifier for the contact. Format:
                /// {resource_type}/{resource_id}/contacts/{contact_id}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. The update mask applied to the resource. For the `FieldMask` definition, see
                /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1Contact Body { get; set; }

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
                        Pattern = @"^folders/[^/]+/contacts/[^/]+$",
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
            /// Allows a contact admin to send a test message to contact to verify that it has been configured
            /// correctly.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// Required. The name of the resource to send the test message for. All contacts must either be set
            /// directly on this resource or inherited from another resource that is an ancestor of this one. Format:
            /// organizations/{organization_id}, folders/{folder_id} or projects/{project_id}
            /// </param>
            public virtual SendTestMessageRequest SendTestMessage(Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1SendTestMessageRequest body, string resource)
            {
                return new SendTestMessageRequest(service, body, resource);
            }

            /// <summary>
            /// Allows a contact admin to send a test message to contact to verify that it has been configured
            /// correctly.
            /// </summary>
            public class SendTestMessageRequest : EssentialcontactsBaseServiceRequest<Google.Apis.Essentialcontacts.v1.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new SendTestMessage request.</summary>
                public SendTestMessageRequest(Google.Apis.Services.IClientService service, Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1SendTestMessageRequest body, string resource) : base(service)
                {
                    Resource = resource;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the resource to send the test message for. All contacts must either be set
                /// directly on this resource or inherited from another resource that is an ancestor of this one.
                /// Format: organizations/{organization_id}, folders/{folder_id} or projects/{project_id}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1SendTestMessageRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "sendTestMessage";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+resource}/contacts:sendTestMessage";

                /// <summary>Initializes SendTestMessage parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resource",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^folders/[^/]+$",
                    });
                }
            }
        }
    }

    /// <summary>The "organizations" collection of methods.</summary>
    public class OrganizationsResource
    {
        private const string Resource = "organizations";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public OrganizationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Contacts = new ContactsResource(service);
        }

        /// <summary>Gets the Contacts resource.</summary>
        public virtual ContactsResource Contacts { get; }

        /// <summary>The "contacts" collection of methods.</summary>
        public class ContactsResource
        {
            private const string Resource = "contacts";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ContactsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Lists all contacts for the resource that are subscribed to the specified notification categories,
            /// including contacts inherited from any parent resources.
            /// </summary>
            /// <param name="parent">
            /// Required. The name of the resource to compute contacts for. Format: organizations/{organization_id},
            /// folders/{folder_id} or projects/{project_id}
            /// </param>
            public virtual ComputeRequest Compute(string parent)
            {
                return new ComputeRequest(service, parent);
            }

            /// <summary>
            /// Lists all contacts for the resource that are subscribed to the specified notification categories,
            /// including contacts inherited from any parent resources.
            /// </summary>
            public class ComputeRequest : EssentialcontactsBaseServiceRequest<Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1ComputeContactsResponse>
            {
                /// <summary>Constructs a new Compute request.</summary>
                public ComputeRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the resource to compute contacts for. Format: organizations/{organization_id},
                /// folders/{folder_id} or projects/{project_id}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The categories of notifications to compute contacts for. If ALL is included in this list, contacts
                /// subscribed to any notification category will be returned.
                /// </summary>
                /// <remarks>
                /// Use this property to set a single value for the parameter, or
                /// <see cref="NotificationCategoriesList"/> to set multiple values. Do not set both properties.
                /// </remarks>
                [Google.Apis.Util.RequestParameterAttribute("notificationCategories", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<NotificationCategoriesEnum> NotificationCategories { get; set; }

                /// <summary>
                /// The categories of notifications to compute contacts for. If ALL is included in this list, contacts
                /// subscribed to any notification category will be returned.
                /// </summary>
                /// <remarks>
                /// Use this property to set one or more values for the parameter. Do not set both this property and
                /// <see cref="NotificationCategories"/>.
                /// </remarks>
                [Google.Apis.Util.RequestParameterAttribute("notificationCategories", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<NotificationCategoriesEnum> NotificationCategoriesList { get; set; }

                /// <summary>
                /// The categories of notifications to compute contacts for. If ALL is included in this list, contacts
                /// subscribed to any notification category will be returned.
                /// </summary>
                public enum NotificationCategoriesEnum
                {
                    /// <summary>Notification category is unrecognized or unspecified.</summary>
                    [Google.Apis.Util.StringValueAttribute("NOTIFICATION_CATEGORY_UNSPECIFIED")]
                    NOTIFICATIONCATEGORYUNSPECIFIED = 0,

                    /// <summary>
                    /// All notifications related to the resource, including notifications pertaining to categories
                    /// added in the future.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALL")]
                    ALL = 1,

                    /// <summary>Notifications related to imminent account suspension.</summary>
                    [Google.Apis.Util.StringValueAttribute("SUSPENSION")]
                    SUSPENSION = 2,

                    /// <summary>
                    /// Notifications related to security/privacy incidents, notifications, and vulnerabilities.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("SECURITY")]
                    SECURITY = 3,

                    /// <summary>
                    /// Notifications related to technical events and issues such as outages, errors, or bugs.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("TECHNICAL")]
                    TECHNICAL = 4,

                    /// <summary>
                    /// Notifications related to billing and payments notifications, price updates, errors, or credits.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("BILLING")]
                    BILLING = 5,

                    /// <summary>
                    /// Notifications related to enforcement actions, regulatory compliance, or government notices.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("LEGAL")]
                    LEGAL = 6,

                    /// <summary>
                    /// Notifications related to new versions, product terms updates, or deprecations.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("PRODUCT_UPDATES")]
                    PRODUCTUPDATES = 7,

                    /// <summary>
                    /// Child category of TECHNICAL. If assigned, technical incident notifications will go to these
                    /// contacts instead of TECHNICAL.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("TECHNICAL_INCIDENTS")]
                    TECHNICALINCIDENTS = 8,
                }

                /// <summary>
                /// Optional. The maximum number of results to return from this request. Non-positive values are
                /// ignored. The presence of `next_page_token` in the response indicates that more results might be
                /// available. If not specified, the default page_size is 100.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. If present, retrieves the next batch of results from the preceding call to this method.
                /// `page_token` must be the value of `next_page_token` from the previous response. The values of other
                /// method parameters should be identical to those in the previous call.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "compute";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/contacts:compute";

                /// <summary>Initializes Compute parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^organizations/[^/]+$",
                    });
                    RequestParameters.Add("notificationCategories", new Google.Apis.Discovery.Parameter
                    {
                        Name = "notificationCategories",
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

            /// <summary>Adds a new contact for a resource.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The resource to save this contact for. Format: organizations/{organization_id},
            /// folders/{folder_id} or projects/{project_id}
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1Contact body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Adds a new contact for a resource.</summary>
            public class CreateRequest : EssentialcontactsBaseServiceRequest<Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1Contact>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1Contact body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource to save this contact for. Format: organizations/{organization_id},
                /// folders/{folder_id} or projects/{project_id}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1Contact Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/contacts";

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
                        Pattern = @"^organizations/[^/]+$",
                    });
                }
            }

            /// <summary>Deletes a contact.</summary>
            /// <param name="name">
            /// Required. The name of the contact to delete. Format:
            /// organizations/{organization_id}/contacts/{contact_id}, folders/{folder_id}/contacts/{contact_id} or
            /// projects/{project_id}/contacts/{contact_id}
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes a contact.</summary>
            public class DeleteRequest : EssentialcontactsBaseServiceRequest<Google.Apis.Essentialcontacts.v1.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the contact to delete. Format:
                /// organizations/{organization_id}/contacts/{contact_id}, folders/{folder_id}/contacts/{contact_id} or
                /// projects/{project_id}/contacts/{contact_id}
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
                        Pattern = @"^organizations/[^/]+/contacts/[^/]+$",
                    });
                }
            }

            /// <summary>Gets a single contact.</summary>
            /// <param name="name">
            /// Required. The name of the contact to retrieve. Format:
            /// organizations/{organization_id}/contacts/{contact_id}, folders/{folder_id}/contacts/{contact_id} or
            /// projects/{project_id}/contacts/{contact_id}
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets a single contact.</summary>
            public class GetRequest : EssentialcontactsBaseServiceRequest<Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1Contact>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the contact to retrieve. Format:
                /// organizations/{organization_id}/contacts/{contact_id}, folders/{folder_id}/contacts/{contact_id} or
                /// projects/{project_id}/contacts/{contact_id}
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
                        Pattern = @"^organizations/[^/]+/contacts/[^/]+$",
                    });
                }
            }

            /// <summary>Lists the contacts that have been set on a resource.</summary>
            /// <param name="parent">
            /// Required. The parent resource name. Format: organizations/{organization_id}, folders/{folder_id} or
            /// projects/{project_id}
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists the contacts that have been set on a resource.</summary>
            public class ListRequest : EssentialcontactsBaseServiceRequest<Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1ListContactsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent resource name. Format: organizations/{organization_id}, folders/{folder_id} or
                /// projects/{project_id}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of results to return from this request. Non-positive values are
                /// ignored. The presence of `next_page_token` in the response indicates that more results might be
                /// available. If not specified, the default page_size is 100.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. If present, retrieves the next batch of results from the preceding call to this method.
                /// `page_token` must be the value of `next_page_token` from the previous response. The values of other
                /// method parameters should be identical to those in the previous call.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/contacts";

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
                        Pattern = @"^organizations/[^/]+$",
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

            /// <summary>Updates a contact. Note: A contact's email address cannot be changed.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Output only. The identifier for the contact. Format: {resource_type}/{resource_id}/contacts/{contact_id}
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1Contact body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates a contact. Note: A contact's email address cannot be changed.</summary>
            public class PatchRequest : EssentialcontactsBaseServiceRequest<Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1Contact>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1Contact body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Output only. The identifier for the contact. Format:
                /// {resource_type}/{resource_id}/contacts/{contact_id}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. The update mask applied to the resource. For the `FieldMask` definition, see
                /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1Contact Body { get; set; }

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
                        Pattern = @"^organizations/[^/]+/contacts/[^/]+$",
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
            /// Allows a contact admin to send a test message to contact to verify that it has been configured
            /// correctly.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// Required. The name of the resource to send the test message for. All contacts must either be set
            /// directly on this resource or inherited from another resource that is an ancestor of this one. Format:
            /// organizations/{organization_id}, folders/{folder_id} or projects/{project_id}
            /// </param>
            public virtual SendTestMessageRequest SendTestMessage(Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1SendTestMessageRequest body, string resource)
            {
                return new SendTestMessageRequest(service, body, resource);
            }

            /// <summary>
            /// Allows a contact admin to send a test message to contact to verify that it has been configured
            /// correctly.
            /// </summary>
            public class SendTestMessageRequest : EssentialcontactsBaseServiceRequest<Google.Apis.Essentialcontacts.v1.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new SendTestMessage request.</summary>
                public SendTestMessageRequest(Google.Apis.Services.IClientService service, Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1SendTestMessageRequest body, string resource) : base(service)
                {
                    Resource = resource;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the resource to send the test message for. All contacts must either be set
                /// directly on this resource or inherited from another resource that is an ancestor of this one.
                /// Format: organizations/{organization_id}, folders/{folder_id} or projects/{project_id}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1SendTestMessageRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "sendTestMessage";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+resource}/contacts:sendTestMessage";

                /// <summary>Initializes SendTestMessage parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resource",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^organizations/[^/]+$",
                    });
                }
            }
        }
    }

    /// <summary>The "projects" collection of methods.</summary>
    public class ProjectsResource
    {
        private const string Resource = "projects";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ProjectsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Contacts = new ContactsResource(service);
        }

        /// <summary>Gets the Contacts resource.</summary>
        public virtual ContactsResource Contacts { get; }

        /// <summary>The "contacts" collection of methods.</summary>
        public class ContactsResource
        {
            private const string Resource = "contacts";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ContactsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Lists all contacts for the resource that are subscribed to the specified notification categories,
            /// including contacts inherited from any parent resources.
            /// </summary>
            /// <param name="parent">
            /// Required. The name of the resource to compute contacts for. Format: organizations/{organization_id},
            /// folders/{folder_id} or projects/{project_id}
            /// </param>
            public virtual ComputeRequest Compute(string parent)
            {
                return new ComputeRequest(service, parent);
            }

            /// <summary>
            /// Lists all contacts for the resource that are subscribed to the specified notification categories,
            /// including contacts inherited from any parent resources.
            /// </summary>
            public class ComputeRequest : EssentialcontactsBaseServiceRequest<Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1ComputeContactsResponse>
            {
                /// <summary>Constructs a new Compute request.</summary>
                public ComputeRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the resource to compute contacts for. Format: organizations/{organization_id},
                /// folders/{folder_id} or projects/{project_id}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The categories of notifications to compute contacts for. If ALL is included in this list, contacts
                /// subscribed to any notification category will be returned.
                /// </summary>
                /// <remarks>
                /// Use this property to set a single value for the parameter, or
                /// <see cref="NotificationCategoriesList"/> to set multiple values. Do not set both properties.
                /// </remarks>
                [Google.Apis.Util.RequestParameterAttribute("notificationCategories", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<NotificationCategoriesEnum> NotificationCategories { get; set; }

                /// <summary>
                /// The categories of notifications to compute contacts for. If ALL is included in this list, contacts
                /// subscribed to any notification category will be returned.
                /// </summary>
                /// <remarks>
                /// Use this property to set one or more values for the parameter. Do not set both this property and
                /// <see cref="NotificationCategories"/>.
                /// </remarks>
                [Google.Apis.Util.RequestParameterAttribute("notificationCategories", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<NotificationCategoriesEnum> NotificationCategoriesList { get; set; }

                /// <summary>
                /// The categories of notifications to compute contacts for. If ALL is included in this list, contacts
                /// subscribed to any notification category will be returned.
                /// </summary>
                public enum NotificationCategoriesEnum
                {
                    /// <summary>Notification category is unrecognized or unspecified.</summary>
                    [Google.Apis.Util.StringValueAttribute("NOTIFICATION_CATEGORY_UNSPECIFIED")]
                    NOTIFICATIONCATEGORYUNSPECIFIED = 0,

                    /// <summary>
                    /// All notifications related to the resource, including notifications pertaining to categories
                    /// added in the future.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALL")]
                    ALL = 1,

                    /// <summary>Notifications related to imminent account suspension.</summary>
                    [Google.Apis.Util.StringValueAttribute("SUSPENSION")]
                    SUSPENSION = 2,

                    /// <summary>
                    /// Notifications related to security/privacy incidents, notifications, and vulnerabilities.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("SECURITY")]
                    SECURITY = 3,

                    /// <summary>
                    /// Notifications related to technical events and issues such as outages, errors, or bugs.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("TECHNICAL")]
                    TECHNICAL = 4,

                    /// <summary>
                    /// Notifications related to billing and payments notifications, price updates, errors, or credits.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("BILLING")]
                    BILLING = 5,

                    /// <summary>
                    /// Notifications related to enforcement actions, regulatory compliance, or government notices.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("LEGAL")]
                    LEGAL = 6,

                    /// <summary>
                    /// Notifications related to new versions, product terms updates, or deprecations.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("PRODUCT_UPDATES")]
                    PRODUCTUPDATES = 7,

                    /// <summary>
                    /// Child category of TECHNICAL. If assigned, technical incident notifications will go to these
                    /// contacts instead of TECHNICAL.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("TECHNICAL_INCIDENTS")]
                    TECHNICALINCIDENTS = 8,
                }

                /// <summary>
                /// Optional. The maximum number of results to return from this request. Non-positive values are
                /// ignored. The presence of `next_page_token` in the response indicates that more results might be
                /// available. If not specified, the default page_size is 100.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. If present, retrieves the next batch of results from the preceding call to this method.
                /// `page_token` must be the value of `next_page_token` from the previous response. The values of other
                /// method parameters should be identical to those in the previous call.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "compute";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/contacts:compute";

                /// <summary>Initializes Compute parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                    RequestParameters.Add("notificationCategories", new Google.Apis.Discovery.Parameter
                    {
                        Name = "notificationCategories",
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

            /// <summary>Adds a new contact for a resource.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The resource to save this contact for. Format: organizations/{organization_id},
            /// folders/{folder_id} or projects/{project_id}
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1Contact body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Adds a new contact for a resource.</summary>
            public class CreateRequest : EssentialcontactsBaseServiceRequest<Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1Contact>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1Contact body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource to save this contact for. Format: organizations/{organization_id},
                /// folders/{folder_id} or projects/{project_id}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1Contact Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/contacts";

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
                        Pattern = @"^projects/[^/]+$",
                    });
                }
            }

            /// <summary>Deletes a contact.</summary>
            /// <param name="name">
            /// Required. The name of the contact to delete. Format:
            /// organizations/{organization_id}/contacts/{contact_id}, folders/{folder_id}/contacts/{contact_id} or
            /// projects/{project_id}/contacts/{contact_id}
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes a contact.</summary>
            public class DeleteRequest : EssentialcontactsBaseServiceRequest<Google.Apis.Essentialcontacts.v1.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the contact to delete. Format:
                /// organizations/{organization_id}/contacts/{contact_id}, folders/{folder_id}/contacts/{contact_id} or
                /// projects/{project_id}/contacts/{contact_id}
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
                        Pattern = @"^projects/[^/]+/contacts/[^/]+$",
                    });
                }
            }

            /// <summary>Gets a single contact.</summary>
            /// <param name="name">
            /// Required. The name of the contact to retrieve. Format:
            /// organizations/{organization_id}/contacts/{contact_id}, folders/{folder_id}/contacts/{contact_id} or
            /// projects/{project_id}/contacts/{contact_id}
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets a single contact.</summary>
            public class GetRequest : EssentialcontactsBaseServiceRequest<Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1Contact>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the contact to retrieve. Format:
                /// organizations/{organization_id}/contacts/{contact_id}, folders/{folder_id}/contacts/{contact_id} or
                /// projects/{project_id}/contacts/{contact_id}
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
                        Pattern = @"^projects/[^/]+/contacts/[^/]+$",
                    });
                }
            }

            /// <summary>Lists the contacts that have been set on a resource.</summary>
            /// <param name="parent">
            /// Required. The parent resource name. Format: organizations/{organization_id}, folders/{folder_id} or
            /// projects/{project_id}
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists the contacts that have been set on a resource.</summary>
            public class ListRequest : EssentialcontactsBaseServiceRequest<Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1ListContactsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent resource name. Format: organizations/{organization_id}, folders/{folder_id} or
                /// projects/{project_id}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of results to return from this request. Non-positive values are
                /// ignored. The presence of `next_page_token` in the response indicates that more results might be
                /// available. If not specified, the default page_size is 100.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. If present, retrieves the next batch of results from the preceding call to this method.
                /// `page_token` must be the value of `next_page_token` from the previous response. The values of other
                /// method parameters should be identical to those in the previous call.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/contacts";

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
                        Pattern = @"^projects/[^/]+$",
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

            /// <summary>Updates a contact. Note: A contact's email address cannot be changed.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Output only. The identifier for the contact. Format: {resource_type}/{resource_id}/contacts/{contact_id}
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1Contact body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates a contact. Note: A contact's email address cannot be changed.</summary>
            public class PatchRequest : EssentialcontactsBaseServiceRequest<Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1Contact>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1Contact body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Output only. The identifier for the contact. Format:
                /// {resource_type}/{resource_id}/contacts/{contact_id}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. The update mask applied to the resource. For the `FieldMask` definition, see
                /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1Contact Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/contacts/[^/]+$",
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
            /// Allows a contact admin to send a test message to contact to verify that it has been configured
            /// correctly.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// Required. The name of the resource to send the test message for. All contacts must either be set
            /// directly on this resource or inherited from another resource that is an ancestor of this one. Format:
            /// organizations/{organization_id}, folders/{folder_id} or projects/{project_id}
            /// </param>
            public virtual SendTestMessageRequest SendTestMessage(Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1SendTestMessageRequest body, string resource)
            {
                return new SendTestMessageRequest(service, body, resource);
            }

            /// <summary>
            /// Allows a contact admin to send a test message to contact to verify that it has been configured
            /// correctly.
            /// </summary>
            public class SendTestMessageRequest : EssentialcontactsBaseServiceRequest<Google.Apis.Essentialcontacts.v1.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new SendTestMessage request.</summary>
                public SendTestMessageRequest(Google.Apis.Services.IClientService service, Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1SendTestMessageRequest body, string resource) : base(service)
                {
                    Resource = resource;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the resource to send the test message for. All contacts must either be set
                /// directly on this resource or inherited from another resource that is an ancestor of this one.
                /// Format: organizations/{organization_id}, folders/{folder_id} or projects/{project_id}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Essentialcontacts.v1.Data.GoogleCloudEssentialcontactsV1SendTestMessageRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "sendTestMessage";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+resource}/contacts:sendTestMessage";

                /// <summary>Initializes SendTestMessage parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resource",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                }
            }
        }
    }
}
namespace Google.Apis.Essentialcontacts.v1.Data
{
    /// <summary>Response message for the ComputeContacts method.</summary>
    public class GoogleCloudEssentialcontactsV1ComputeContactsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// All contacts for the resource that are subscribed to the specified notification categories, including
        /// contacts inherited from any parent resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contacts")]
        public virtual System.Collections.Generic.IList<GoogleCloudEssentialcontactsV1Contact> Contacts { get; set; }

        /// <summary>
        /// If there are more results than those appearing in this response, then `next_page_token` is included. To get
        /// the next set of results, call this method again using the value of `next_page_token` as `page_token` and the
        /// rest of the parameters the same as the original request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A contact that will receive notifications from Google Cloud.</summary>
    public class GoogleCloudEssentialcontactsV1Contact : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The email address to send notifications to. The email address does not need to be a Google
        /// Account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>
        /// Required. The preferred language for notifications, as a ISO 639-1 language code. See [Supported
        /// languages](https://cloud.google.com/resource-manager/docs/managing-notification-contacts#supported-languages)
        /// for a list of supported languages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageTag")]
        public virtual string LanguageTag { get; set; }

        /// <summary>
        /// Output only. The identifier for the contact. Format: {resource_type}/{resource_id}/contacts/{contact_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. The categories of notifications that the contact will receive communications for.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationCategorySubscriptions")]
        public virtual System.Collections.Generic.IList<string> NotificationCategorySubscriptions { get; set; }

        /// <summary>
        /// The last time the validation_state was updated, either manually or automatically. A contact is considered
        /// stale if its validation state was updated more than 1 year ago.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateTime")]
        public virtual object ValidateTime { get; set; }

        /// <summary>
        /// The validity of the contact. A contact is considered valid if it is the correct recipient for notifications
        /// for a particular resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validationState")]
        public virtual string ValidationState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the ListContacts method.</summary>
    public class GoogleCloudEssentialcontactsV1ListContactsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The contacts for the specified resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contacts")]
        public virtual System.Collections.Generic.IList<GoogleCloudEssentialcontactsV1Contact> Contacts { get; set; }

        /// <summary>
        /// If there are more results than those appearing in this response, then `next_page_token` is included. To get
        /// the next set of results, call this method again using the value of `next_page_token` as `page_token` and the
        /// rest of the parameters the same as the original request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the SendTestMessage method.</summary>
    public class GoogleCloudEssentialcontactsV1SendTestMessageRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The list of names of the contacts to send a test message to. Format:
        /// organizations/{organization_id}/contacts/{contact_id}, folders/{folder_id}/contacts/{contact_id} or
        /// projects/{project_id}/contacts/{contact_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contacts")]
        public virtual System.Collections.Generic.IList<string> Contacts { get; set; }

        /// <summary>
        /// Required. The notification category to send the test message for. All contacts must be subscribed to this
        /// category.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationCategory")]
        public virtual string NotificationCategory { get; set; }

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
