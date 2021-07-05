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

namespace Google.Apis.Cloudchannel.v1
{
    /// <summary>The Cloudchannel Service.</summary>
    public class CloudchannelService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudchannelService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudchannelService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Accounts = new AccountsResource(this);
            Operations = new OperationsResource(this);
            Products = new ProductsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "cloudchannel";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://cloudchannel.googleapis.com/";
        #else
            "https://cloudchannel.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://cloudchannel.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Channel API.</summary>
        public class Scope
        {
            /// <summary>Manage users on your domain</summary>
            public static string AppsOrder = "https://www.googleapis.com/auth/apps.order";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Channel API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Manage users on your domain</summary>
            public const string AppsOrder = "https://www.googleapis.com/auth/apps.order";
        }

        /// <summary>Gets the Accounts resource.</summary>
        public virtual AccountsResource Accounts { get; }

        /// <summary>Gets the Operations resource.</summary>
        public virtual OperationsResource Operations { get; }

        /// <summary>Gets the Products resource.</summary>
        public virtual ProductsResource Products { get; }
    }

    /// <summary>A base abstract class for Cloudchannel requests.</summary>
    public abstract class CloudchannelBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudchannelBaseServiceRequest instance.</summary>
        protected CloudchannelBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Cloudchannel parameter list.</summary>
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
            ChannelPartnerLinks = new ChannelPartnerLinksResource(service);
            Customers = new CustomersResource(service);
            Offers = new OffersResource(service);
        }

        /// <summary>Gets the ChannelPartnerLinks resource.</summary>
        public virtual ChannelPartnerLinksResource ChannelPartnerLinks { get; }

        /// <summary>The "channelPartnerLinks" collection of methods.</summary>
        public class ChannelPartnerLinksResource
        {
            private const string Resource = "channelPartnerLinks";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ChannelPartnerLinksResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Customers = new CustomersResource(service);
            }

            /// <summary>Gets the Customers resource.</summary>
            public virtual CustomersResource Customers { get; }

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
                }

                /// <summary>
                /// Creates a new Customer resource under the reseller or distributor account. Possible error codes: *
                /// PERMISSION_DENIED: The reseller account making the request is different from the reseller account in
                /// the API request. * INVALID_ARGUMENT: * Required request parameters are missing or invalid. * Domain
                /// field value doesn't match the primary email domain. Return value: The newly created Customer
                /// resource.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The resource name of reseller account in which to create the customer. Parent uses the
                /// format: accounts/{account_id}
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1Customer body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Creates a new Customer resource under the reseller or distributor account. Possible error codes: *
                /// PERMISSION_DENIED: The reseller account making the request is different from the reseller account in
                /// the API request. * INVALID_ARGUMENT: * Required request parameters are missing or invalid. * Domain
                /// field value doesn't match the primary email domain. Return value: The newly created Customer
                /// resource.
                /// </summary>
                public class CreateRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1Customer>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1Customer body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of reseller account in which to create the customer. Parent uses the
                    /// format: accounts/{account_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1Customer Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/customers";

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
                            Pattern = @"^accounts/[^/]+/channelPartnerLinks/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Deletes the given Customer permanently. Possible error codes: * PERMISSION_DENIED: The account
                /// making the request does not own this customer. * INVALID_ARGUMENT: Required request parameters are
                /// missing or invalid. * FAILED_PRECONDITION: The customer has existing entitlements. * NOT_FOUND: No
                /// Customer resource found for the name in the request.
                /// </summary>
                /// <param name="name">Required. The resource name of the customer to delete.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes the given Customer permanently. Possible error codes: * PERMISSION_DENIED: The account
                /// making the request does not own this customer. * INVALID_ARGUMENT: Required request parameters are
                /// missing or invalid. * FAILED_PRECONDITION: The customer has existing entitlements. * NOT_FOUND: No
                /// Customer resource found for the name in the request.
                /// </summary>
                public class DeleteRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The resource name of the customer to delete.</summary>
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
                            Pattern = @"^accounts/[^/]+/channelPartnerLinks/[^/]+/customers/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns the requested Customer resource. Possible error codes: * PERMISSION_DENIED: The reseller
                /// account making the request is different from the reseller account in the API request. *
                /// INVALID_ARGUMENT: Required request parameters are missing or invalid. * NOT_FOUND: The customer
                /// resource doesn't exist. Usually the result of an invalid name parameter. Return value: The Customer
                /// resource.
                /// </summary>
                /// <param name="name">
                /// Required. The resource name of the customer to retrieve. Name uses the format:
                /// accounts/{account_id}/customers/{customer_id}
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Returns the requested Customer resource. Possible error codes: * PERMISSION_DENIED: The reseller
                /// account making the request is different from the reseller account in the API request. *
                /// INVALID_ARGUMENT: Required request parameters are missing or invalid. * NOT_FOUND: The customer
                /// resource doesn't exist. Usually the result of an invalid name parameter. Return value: The Customer
                /// resource.
                /// </summary>
                public class GetRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1Customer>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the customer to retrieve. Name uses the format:
                    /// accounts/{account_id}/customers/{customer_id}
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
                            Pattern = @"^accounts/[^/]+/channelPartnerLinks/[^/]+/customers/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// List Customers. Possible error codes: * PERMISSION_DENIED: The reseller account making the request
                /// is different from the reseller account in the API request. * INVALID_ARGUMENT: Required request
                /// parameters are missing or invalid. Return value: List of Customers, or an empty list if there are no
                /// customers.
                /// </summary>
                /// <param name="parent">
                /// Required. The resource name of the reseller account to list customers from. Parent uses the format:
                /// accounts/{account_id}.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// List Customers. Possible error codes: * PERMISSION_DENIED: The reseller account making the request
                /// is different from the reseller account in the API request. * INVALID_ARGUMENT: Required request
                /// parameters are missing or invalid. Return value: List of Customers, or an empty list if there are no
                /// customers.
                /// </summary>
                public class ListRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1ListCustomersResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the reseller account to list customers from. Parent uses the
                    /// format: accounts/{account_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The maximum number of customers to return. The service may return fewer than this
                    /// value. If unspecified, returns at most 10 customers. The maximum value is 50.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A token identifying a page of results other than the first page. Obtained through
                    /// ListCustomersResponse.next_page_token of the previous CloudChannelService.ListCustomers call.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/customers";

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
                            Pattern = @"^accounts/[^/]+/channelPartnerLinks/[^/]+$",
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
                /// Updates an existing Customer resource for the reseller or distributor. Possible error codes: *
                /// PERMISSION_DENIED: The reseller account making the request is different from the reseller account in
                /// the API request. * INVALID_ARGUMENT: Required request parameters are missing or invalid. *
                /// NOT_FOUND: No Customer resource found for the name in the request. Return value: The updated
                /// Customer resource.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. Resource name of the customer. Format: accounts/{account_id}/customers/{customer_id}
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1Customer body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Updates an existing Customer resource for the reseller or distributor. Possible error codes: *
                /// PERMISSION_DENIED: The reseller account making the request is different from the reseller account in
                /// the API request. * INVALID_ARGUMENT: Required request parameters are missing or invalid. *
                /// NOT_FOUND: No Customer resource found for the name in the request. Return value: The updated
                /// Customer resource.
                /// </summary>
                public class PatchRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1Customer>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1Customer body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. Resource name of the customer. Format:
                    /// accounts/{account_id}/customers/{customer_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>The update mask that applies to the resource. Optional.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1Customer Body { get; set; }

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
                            Pattern = @"^accounts/[^/]+/channelPartnerLinks/[^/]+/customers/[^/]+$",
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
            /// Initiates a channel partner link between a distributor and a reseller, or between resellers in an n-tier
            /// reseller channel. Invited partners need to follow the invite_link_uri provided in the response to
            /// accept. After accepting the invitation, a link is set up between the two parties. You must be a
            /// distributor to call this method. Possible error codes: * PERMISSION_DENIED: The reseller account making
            /// the request is different from the reseller account in the API request. * INVALID_ARGUMENT: Required
            /// request parameters are missing or invalid. * ALREADY_EXISTS: The ChannelPartnerLink sent in the request
            /// already exists. * NOT_FOUND: No Cloud Identity customer exists for provided domain. * INTERNAL: Any
            /// non-user error related to a technical issue in the backend. Contact Cloud Channel support. * UNKNOWN:
            /// Any non-user error related to a technical issue in the backend. Contact Cloud Channel support. Return
            /// value: The new ChannelPartnerLink resource.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Create a channel partner link for the provided reseller account's resource name. Parent uses
            /// the format: accounts/{account_id}
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1ChannelPartnerLink body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Initiates a channel partner link between a distributor and a reseller, or between resellers in an n-tier
            /// reseller channel. Invited partners need to follow the invite_link_uri provided in the response to
            /// accept. After accepting the invitation, a link is set up between the two parties. You must be a
            /// distributor to call this method. Possible error codes: * PERMISSION_DENIED: The reseller account making
            /// the request is different from the reseller account in the API request. * INVALID_ARGUMENT: Required
            /// request parameters are missing or invalid. * ALREADY_EXISTS: The ChannelPartnerLink sent in the request
            /// already exists. * NOT_FOUND: No Cloud Identity customer exists for provided domain. * INTERNAL: Any
            /// non-user error related to a technical issue in the backend. Contact Cloud Channel support. * UNKNOWN:
            /// Any non-user error related to a technical issue in the backend. Contact Cloud Channel support. Return
            /// value: The new ChannelPartnerLink resource.
            /// </summary>
            public class CreateRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1ChannelPartnerLink>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1ChannelPartnerLink body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Create a channel partner link for the provided reseller account's resource name. Parent
                /// uses the format: accounts/{account_id}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1ChannelPartnerLink Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/channelPartnerLinks";

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

            /// <summary>
            /// Returns the requested ChannelPartnerLink resource. You must be a distributor to call this method.
            /// Possible error codes: * PERMISSION_DENIED: The reseller account making the request is different from the
            /// reseller account in the API request. * INVALID_ARGUMENT: Required request parameters are missing or
            /// invalid. * NOT_FOUND: ChannelPartnerLink resource not found because of an invalid channel partner link
            /// name. Return value: The ChannelPartnerLink resource.
            /// </summary>
            /// <param name="name">
            /// Required. The resource name of the channel partner link to retrieve. Name uses the format:
            /// accounts/{account_id}/channelPartnerLinks/{id} where {id} is the Cloud Identity ID of the partner.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>
            /// Returns the requested ChannelPartnerLink resource. You must be a distributor to call this method.
            /// Possible error codes: * PERMISSION_DENIED: The reseller account making the request is different from the
            /// reseller account in the API request. * INVALID_ARGUMENT: Required request parameters are missing or
            /// invalid. * NOT_FOUND: ChannelPartnerLink resource not found because of an invalid channel partner link
            /// name. Return value: The ChannelPartnerLink resource.
            /// </summary>
            public class GetRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1ChannelPartnerLink>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the channel partner link to retrieve. Name uses the format:
                /// accounts/{account_id}/channelPartnerLinks/{id} where {id} is the Cloud Identity ID of the partner.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Optional. The level of granularity the ChannelPartnerLink will display.</summary>
                [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ViewEnum> View { get; set; }

                /// <summary>Optional. The level of granularity the ChannelPartnerLink will display.</summary>
                public enum ViewEnum
                {
                    /// <summary>The default / unset value. The API will default to the BASIC view.</summary>
                    [Google.Apis.Util.StringValueAttribute("UNSPECIFIED")]
                    UNSPECIFIED = 0,

                    /// <summary>
                    /// Includes all fields except the ChannelPartnerLink.channel_partner_cloud_identity_info.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("BASIC")]
                    BASIC = 1,

                    /// <summary>Includes all fields.</summary>
                    [Google.Apis.Util.StringValueAttribute("FULL")]
                    FULL = 2,
                }

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
                        Pattern = @"^accounts/[^/]+/channelPartnerLinks/[^/]+$",
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
            /// List ChannelPartnerLinks belonging to a distributor. You must be a distributor to call this method.
            /// Possible error codes: * PERMISSION_DENIED: The reseller account making the request is different from the
            /// reseller account in the API request. * INVALID_ARGUMENT: Required request parameters are missing or
            /// invalid. Return value: The list of the distributor account's ChannelPartnerLink resources.
            /// </summary>
            /// <param name="parent">
            /// Required. The resource name of the reseller account for listing channel partner links. Parent uses the
            /// format: accounts/{account_id}
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// List ChannelPartnerLinks belonging to a distributor. You must be a distributor to call this method.
            /// Possible error codes: * PERMISSION_DENIED: The reseller account making the request is different from the
            /// reseller account in the API request. * INVALID_ARGUMENT: Required request parameters are missing or
            /// invalid. Return value: The list of the distributor account's ChannelPartnerLink resources.
            /// </summary>
            public class ListRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1ListChannelPartnerLinksResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the reseller account for listing channel partner links. Parent uses
                /// the format: accounts/{account_id}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. Requested page size. Server might return fewer results than requested. If unspecified,
                /// server will pick a default size (25). The maximum value is 200; the server will coerce values above
                /// 200.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A token for a page of results other than the first page. Obtained using
                /// ListChannelPartnerLinksResponse.next_page_token of the previous
                /// CloudChannelService.ListChannelPartnerLinks call.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Optional. The level of granularity the ChannelPartnerLink will display.</summary>
                [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ViewEnum> View { get; set; }

                /// <summary>Optional. The level of granularity the ChannelPartnerLink will display.</summary>
                public enum ViewEnum
                {
                    /// <summary>The default / unset value. The API will default to the BASIC view.</summary>
                    [Google.Apis.Util.StringValueAttribute("UNSPECIFIED")]
                    UNSPECIFIED = 0,

                    /// <summary>
                    /// Includes all fields except the ChannelPartnerLink.channel_partner_cloud_identity_info.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("BASIC")]
                    BASIC = 1,

                    /// <summary>Includes all fields.</summary>
                    [Google.Apis.Util.StringValueAttribute("FULL")]
                    FULL = 2,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/channelPartnerLinks";

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
            /// Updates a channel partner link. Distributors call this method to change a link's status. For example, to
            /// suspend a partner link. You must be a distributor to call this method. Possible error codes: *
            /// PERMISSION_DENIED: The reseller account making the request is different from the reseller account in the
            /// API request. * INVALID_ARGUMENT: * Required request parameters are missing or invalid. * Link state
            /// cannot change from invited to active or suspended. * Cannot send reseller_cloud_identity_id, invite_url,
            /// or name in update mask. * NOT_FOUND: ChannelPartnerLink resource not found. * INTERNAL: Any non-user
            /// error related to a technical issue in the backend. Contact Cloud Channel support. * UNKNOWN: Any
            /// non-user error related to a technical issue in the backend. Contact Cloud Channel support. Return value:
            /// The updated ChannelPartnerLink resource.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The resource name of the channel partner link to cancel. Name uses the format:
            /// accounts/{account_id}/channelPartnerLinks/{id} where {id} is the Cloud Identity ID of the partner.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1UpdateChannelPartnerLinkRequest body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>
            /// Updates a channel partner link. Distributors call this method to change a link's status. For example, to
            /// suspend a partner link. You must be a distributor to call this method. Possible error codes: *
            /// PERMISSION_DENIED: The reseller account making the request is different from the reseller account in the
            /// API request. * INVALID_ARGUMENT: * Required request parameters are missing or invalid. * Link state
            /// cannot change from invited to active or suspended. * Cannot send reseller_cloud_identity_id, invite_url,
            /// or name in update mask. * NOT_FOUND: ChannelPartnerLink resource not found. * INTERNAL: Any non-user
            /// error related to a technical issue in the backend. Contact Cloud Channel support. * UNKNOWN: Any
            /// non-user error related to a technical issue in the backend. Contact Cloud Channel support. Return value:
            /// The updated ChannelPartnerLink resource.
            /// </summary>
            public class PatchRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1ChannelPartnerLink>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1UpdateChannelPartnerLinkRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the channel partner link to cancel. Name uses the format:
                /// accounts/{account_id}/channelPartnerLinks/{id} where {id} is the Cloud Identity ID of the partner.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1UpdateChannelPartnerLinkRequest Body { get; set; }

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
                        Pattern = @"^accounts/[^/]+/channelPartnerLinks/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the Customers resource.</summary>
        public virtual CustomersResource Customers { get; }

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
                Entitlements = new EntitlementsResource(service);
            }

            /// <summary>Gets the Entitlements resource.</summary>
            public virtual EntitlementsResource Entitlements { get; }

            /// <summary>The "entitlements" collection of methods.</summary>
            public class EntitlementsResource
            {
                private const string Resource = "entitlements";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public EntitlementsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Activates a previously suspended entitlement. Entitlements suspended for pending ToS acceptance
                /// can't be activated using this method. An entitlement activation is a long-running operation and it
                /// updates the state of the customer entitlement. Possible error codes: * PERMISSION_DENIED: The
                /// reseller account making the request is different from the reseller account in the API request. *
                /// INVALID_ARGUMENT: Required request parameters are missing or invalid. * NOT_FOUND: Entitlement
                /// resource not found. * SUSPENSION_NOT_RESELLER_INITIATED: Can only activate reseller-initiated
                /// suspensions and entitlements that have accepted the TOS. * NOT_SUSPENDED: Can only activate
                /// suspended entitlements not in an ACTIVE state. * INTERNAL: Any non-user error related to a technical
                /// issue in the backend. Contact Cloud Channel support. * UNKNOWN: Any non-user error related to a
                /// technical issue in the backend. Contact Cloud Channel support. Return value: The ID of a
                /// long-running operation. To get the results of the operation, call the GetOperation method of
                /// CloudChannelOperationsService. The Operation metadata will contain an instance of OperationMetadata.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The resource name of the entitlement to activate. Name uses the format:
                /// accounts/{account_id}/customers/{customer_id}/entitlements/{entitlement_id}
                /// </param>
                public virtual ActivateRequest Activate(Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1ActivateEntitlementRequest body, string name)
                {
                    return new ActivateRequest(service, body, name);
                }

                /// <summary>
                /// Activates a previously suspended entitlement. Entitlements suspended for pending ToS acceptance
                /// can't be activated using this method. An entitlement activation is a long-running operation and it
                /// updates the state of the customer entitlement. Possible error codes: * PERMISSION_DENIED: The
                /// reseller account making the request is different from the reseller account in the API request. *
                /// INVALID_ARGUMENT: Required request parameters are missing or invalid. * NOT_FOUND: Entitlement
                /// resource not found. * SUSPENSION_NOT_RESELLER_INITIATED: Can only activate reseller-initiated
                /// suspensions and entitlements that have accepted the TOS. * NOT_SUSPENDED: Can only activate
                /// suspended entitlements not in an ACTIVE state. * INTERNAL: Any non-user error related to a technical
                /// issue in the backend. Contact Cloud Channel support. * UNKNOWN: Any non-user error related to a
                /// technical issue in the backend. Contact Cloud Channel support. Return value: The ID of a
                /// long-running operation. To get the results of the operation, call the GetOperation method of
                /// CloudChannelOperationsService. The Operation metadata will contain an instance of OperationMetadata.
                /// </summary>
                public class ActivateRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Activate request.</summary>
                    public ActivateRequest(Google.Apis.Services.IClientService service, Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1ActivateEntitlementRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the entitlement to activate. Name uses the format:
                    /// accounts/{account_id}/customers/{customer_id}/entitlements/{entitlement_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1ActivateEntitlementRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "activate";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:activate";

                    /// <summary>Initializes Activate parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^accounts/[^/]+/customers/[^/]+/entitlements/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Cancels a previously fulfilled entitlement. An entitlement cancellation is a long-running operation.
                /// Possible error codes: * PERMISSION_DENIED: The reseller account making the request is different from
                /// the reseller account in the API request. * FAILED_PRECONDITION: There are Google Cloud projects
                /// linked to the Google Cloud entitlement's Cloud Billing subaccount. * INVALID_ARGUMENT: Required
                /// request parameters are missing or invalid. * NOT_FOUND: Entitlement resource not found. *
                /// DELETION_TYPE_NOT_ALLOWED: Cancel is only allowed for Google Workspace add-ons, or entitlements for
                /// Google Cloud's development platform. * INTERNAL: Any non-user error related to a technical issue in
                /// the backend. Contact Cloud Channel support. * UNKNOWN: Any non-user error related to a technical
                /// issue in the backend. Contact Cloud Channel support. Return value: The ID of a long-running
                /// operation. To get the results of the operation, call the GetOperation method of
                /// CloudChannelOperationsService. The response will contain google.protobuf.Empty on success. The
                /// Operation metadata will contain an instance of OperationMetadata.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The resource name of the entitlement to cancel. Name uses the format:
                /// accounts/{account_id}/customers/{customer_id}/entitlements/{entitlement_id}
                /// </param>
                public virtual CancelRequest Cancel(Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1CancelEntitlementRequest body, string name)
                {
                    return new CancelRequest(service, body, name);
                }

                /// <summary>
                /// Cancels a previously fulfilled entitlement. An entitlement cancellation is a long-running operation.
                /// Possible error codes: * PERMISSION_DENIED: The reseller account making the request is different from
                /// the reseller account in the API request. * FAILED_PRECONDITION: There are Google Cloud projects
                /// linked to the Google Cloud entitlement's Cloud Billing subaccount. * INVALID_ARGUMENT: Required
                /// request parameters are missing or invalid. * NOT_FOUND: Entitlement resource not found. *
                /// DELETION_TYPE_NOT_ALLOWED: Cancel is only allowed for Google Workspace add-ons, or entitlements for
                /// Google Cloud's development platform. * INTERNAL: Any non-user error related to a technical issue in
                /// the backend. Contact Cloud Channel support. * UNKNOWN: Any non-user error related to a technical
                /// issue in the backend. Contact Cloud Channel support. Return value: The ID of a long-running
                /// operation. To get the results of the operation, call the GetOperation method of
                /// CloudChannelOperationsService. The response will contain google.protobuf.Empty on success. The
                /// Operation metadata will contain an instance of OperationMetadata.
                /// </summary>
                public class CancelRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1CancelEntitlementRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the entitlement to cancel. Name uses the format:
                    /// accounts/{account_id}/customers/{customer_id}/entitlements/{entitlement_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1CancelEntitlementRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "cancel";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:cancel";

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
                            Pattern = @"^accounts/[^/]+/customers/[^/]+/entitlements/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Updates the Offer for an existing customer entitlement. An entitlement update is a long-running
                /// operation and it updates the entitlement as a result of fulfillment. Possible error codes: *
                /// PERMISSION_DENIED: The customer doesn't belong to the reseller. * INVALID_ARGUMENT: Required request
                /// parameters are missing or invalid. * NOT_FOUND: Offer or Entitlement resource not found. * INTERNAL:
                /// Any non-user error related to a technical issue in the backend. Contact Cloud Channel support. *
                /// UNKNOWN: Any non-user error related to a technical issue in the backend. Contact Cloud Channel
                /// support. Return value: The ID of a long-running operation. To get the results of the operation, call
                /// the GetOperation method of CloudChannelOperationsService. The Operation metadata will contain an
                /// instance of OperationMetadata.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The resource name of the entitlement to update. Name uses the format:
                /// accounts/{account_id}/customers/{customer_id}/entitlements/{entitlement_id}
                /// </param>
                public virtual ChangeOfferRequest ChangeOffer(Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1ChangeOfferRequest body, string name)
                {
                    return new ChangeOfferRequest(service, body, name);
                }

                /// <summary>
                /// Updates the Offer for an existing customer entitlement. An entitlement update is a long-running
                /// operation and it updates the entitlement as a result of fulfillment. Possible error codes: *
                /// PERMISSION_DENIED: The customer doesn't belong to the reseller. * INVALID_ARGUMENT: Required request
                /// parameters are missing or invalid. * NOT_FOUND: Offer or Entitlement resource not found. * INTERNAL:
                /// Any non-user error related to a technical issue in the backend. Contact Cloud Channel support. *
                /// UNKNOWN: Any non-user error related to a technical issue in the backend. Contact Cloud Channel
                /// support. Return value: The ID of a long-running operation. To get the results of the operation, call
                /// the GetOperation method of CloudChannelOperationsService. The Operation metadata will contain an
                /// instance of OperationMetadata.
                /// </summary>
                public class ChangeOfferRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new ChangeOffer request.</summary>
                    public ChangeOfferRequest(Google.Apis.Services.IClientService service, Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1ChangeOfferRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the entitlement to update. Name uses the format:
                    /// accounts/{account_id}/customers/{customer_id}/entitlements/{entitlement_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1ChangeOfferRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "changeOffer";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:changeOffer";

                    /// <summary>Initializes ChangeOffer parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^accounts/[^/]+/customers/[^/]+/entitlements/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Change parameters of the entitlement. An entitlement update is a long-running operation and it
                /// updates the entitlement as a result of fulfillment. Possible error codes: * PERMISSION_DENIED: The
                /// customer doesn't belong to the reseller. * INVALID_ARGUMENT: Required request parameters are missing
                /// or invalid. For example, the number of seats being changed is greater than the allowed number of max
                /// seats, or decreasing seats for a commitment based plan. * NOT_FOUND: Entitlement resource not found.
                /// * INTERNAL: Any non-user error related to a technical issue in the backend. Contact Cloud Channel
                /// support. * UNKNOWN: Any non-user error related to a technical issue in the backend. Contact Cloud
                /// Channel support. Return value: The ID of a long-running operation. To get the results of the
                /// operation, call the GetOperation method of CloudChannelOperationsService. The Operation metadata
                /// will contain an instance of OperationMetadata.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the entitlement to update. Name uses the format:
                /// accounts/{account_id}/customers/{customer_id}/entitlements/{entitlement_id}
                /// </param>
                public virtual ChangeParametersRequest ChangeParameters(Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1ChangeParametersRequest body, string name)
                {
                    return new ChangeParametersRequest(service, body, name);
                }

                /// <summary>
                /// Change parameters of the entitlement. An entitlement update is a long-running operation and it
                /// updates the entitlement as a result of fulfillment. Possible error codes: * PERMISSION_DENIED: The
                /// customer doesn't belong to the reseller. * INVALID_ARGUMENT: Required request parameters are missing
                /// or invalid. For example, the number of seats being changed is greater than the allowed number of max
                /// seats, or decreasing seats for a commitment based plan. * NOT_FOUND: Entitlement resource not found.
                /// * INTERNAL: Any non-user error related to a technical issue in the backend. Contact Cloud Channel
                /// support. * UNKNOWN: Any non-user error related to a technical issue in the backend. Contact Cloud
                /// Channel support. Return value: The ID of a long-running operation. To get the results of the
                /// operation, call the GetOperation method of CloudChannelOperationsService. The Operation metadata
                /// will contain an instance of OperationMetadata.
                /// </summary>
                public class ChangeParametersRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new ChangeParameters request.</summary>
                    public ChangeParametersRequest(Google.Apis.Services.IClientService service, Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1ChangeParametersRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the entitlement to update. Name uses the format:
                    /// accounts/{account_id}/customers/{customer_id}/entitlements/{entitlement_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1ChangeParametersRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "changeParameters";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:changeParameters";

                    /// <summary>Initializes ChangeParameters parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^accounts/[^/]+/customers/[^/]+/entitlements/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Updates the renewal settings for an existing customer entitlement. An entitlement update is a
                /// long-running operation and it updates the entitlement as a result of fulfillment. Possible error
                /// codes: * PERMISSION_DENIED: The customer doesn't belong to the reseller. * INVALID_ARGUMENT:
                /// Required request parameters are missing or invalid. * NOT_FOUND: Entitlement resource not found. *
                /// NOT_COMMITMENT_PLAN: Renewal Settings are only applicable for a commitment plan. Can't enable or
                /// disable renewals for non-commitment plans. * INTERNAL: Any non-user error related to a technical
                /// issue in the backend. Contact Cloud Channel support. * UNKNOWN: Any non-user error related to a
                /// technical issue in the backend. Contact Cloud Channel support. Return value: The ID of a
                /// long-running operation. To get the results of the operation, call the GetOperation method of
                /// CloudChannelOperationsService. The Operation metadata will contain an instance of OperationMetadata.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the entitlement to update. Name uses the format:
                /// accounts/{account_id}/customers/{customer_id}/entitlements/{entitlement_id}
                /// </param>
                public virtual ChangeRenewalSettingsRequest ChangeRenewalSettings(Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1ChangeRenewalSettingsRequest body, string name)
                {
                    return new ChangeRenewalSettingsRequest(service, body, name);
                }

                /// <summary>
                /// Updates the renewal settings for an existing customer entitlement. An entitlement update is a
                /// long-running operation and it updates the entitlement as a result of fulfillment. Possible error
                /// codes: * PERMISSION_DENIED: The customer doesn't belong to the reseller. * INVALID_ARGUMENT:
                /// Required request parameters are missing or invalid. * NOT_FOUND: Entitlement resource not found. *
                /// NOT_COMMITMENT_PLAN: Renewal Settings are only applicable for a commitment plan. Can't enable or
                /// disable renewals for non-commitment plans. * INTERNAL: Any non-user error related to a technical
                /// issue in the backend. Contact Cloud Channel support. * UNKNOWN: Any non-user error related to a
                /// technical issue in the backend. Contact Cloud Channel support. Return value: The ID of a
                /// long-running operation. To get the results of the operation, call the GetOperation method of
                /// CloudChannelOperationsService. The Operation metadata will contain an instance of OperationMetadata.
                /// </summary>
                public class ChangeRenewalSettingsRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new ChangeRenewalSettings request.</summary>
                    public ChangeRenewalSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1ChangeRenewalSettingsRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the entitlement to update. Name uses the format:
                    /// accounts/{account_id}/customers/{customer_id}/entitlements/{entitlement_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1ChangeRenewalSettingsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "changeRenewalSettings";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:changeRenewalSettings";

                    /// <summary>Initializes ChangeRenewalSettings parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^accounts/[^/]+/customers/[^/]+/entitlements/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Creates an entitlement for a customer. Possible error codes: * PERMISSION_DENIED: The customer
                /// doesn't belong to the reseller. * INVALID_ARGUMENT: * Required request parameters are missing or
                /// invalid. * There is already a customer entitlement for a SKU from the same product family. *
                /// INVALID_VALUE: Make sure the OfferId is valid. If it is, contact Google Channel support for further
                /// troubleshooting. * NOT_FOUND: The customer or offer resource was not found. * ALREADY_EXISTS: * The
                /// SKU was already purchased for the customer. * The customer's primary email already exists. Retry
                /// after changing the customer's primary contact email. * CONDITION_NOT_MET or FAILED_PRECONDITION: *
                /// The domain required for purchasing a SKU has not been verified. * A pre-requisite SKU required to
                /// purchase an Add-On SKU is missing. For example, Google Workspace Business Starter is required to
                /// purchase Vault or Drive. * (Developer accounts only) Reseller and resold domain must meet the
                /// following naming requirements: * Domain names must start with goog-test. * Domain names must include
                /// the reseller domain. * INTERNAL: Any non-user error related to a technical issue in the backend.
                /// Contact Cloud Channel support. * UNKNOWN: Any non-user error related to a technical issue in the
                /// backend. Contact Cloud Channel support. Return value: The ID of a long-running operation. To get the
                /// results of the operation, call the GetOperation method of CloudChannelOperationsService. The
                /// Operation metadata will contain an instance of OperationMetadata.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The resource name of the reseller's customer account in which to create the entitlement.
                /// Parent uses the format: accounts/{account_id}/customers/{customer_id}
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1CreateEntitlementRequest body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Creates an entitlement for a customer. Possible error codes: * PERMISSION_DENIED: The customer
                /// doesn't belong to the reseller. * INVALID_ARGUMENT: * Required request parameters are missing or
                /// invalid. * There is already a customer entitlement for a SKU from the same product family. *
                /// INVALID_VALUE: Make sure the OfferId is valid. If it is, contact Google Channel support for further
                /// troubleshooting. * NOT_FOUND: The customer or offer resource was not found. * ALREADY_EXISTS: * The
                /// SKU was already purchased for the customer. * The customer's primary email already exists. Retry
                /// after changing the customer's primary contact email. * CONDITION_NOT_MET or FAILED_PRECONDITION: *
                /// The domain required for purchasing a SKU has not been verified. * A pre-requisite SKU required to
                /// purchase an Add-On SKU is missing. For example, Google Workspace Business Starter is required to
                /// purchase Vault or Drive. * (Developer accounts only) Reseller and resold domain must meet the
                /// following naming requirements: * Domain names must start with goog-test. * Domain names must include
                /// the reseller domain. * INTERNAL: Any non-user error related to a technical issue in the backend.
                /// Contact Cloud Channel support. * UNKNOWN: Any non-user error related to a technical issue in the
                /// backend. Contact Cloud Channel support. Return value: The ID of a long-running operation. To get the
                /// results of the operation, call the GetOperation method of CloudChannelOperationsService. The
                /// Operation metadata will contain an instance of OperationMetadata.
                /// </summary>
                public class CreateRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1CreateEntitlementRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the reseller's customer account in which to create the
                    /// entitlement. Parent uses the format: accounts/{account_id}/customers/{customer_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1CreateEntitlementRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/entitlements";

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
                            Pattern = @"^accounts/[^/]+/customers/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns the requested Entitlement resource. Possible error codes: * PERMISSION_DENIED: The customer
                /// doesn't belong to the reseller. * INVALID_ARGUMENT: Required request parameters are missing or
                /// invalid. * NOT_FOUND: The customer entitlement was not found. Return value: The requested
                /// Entitlement resource.
                /// </summary>
                /// <param name="name">
                /// Required. The resource name of the entitlement to retrieve. Name uses the format:
                /// accounts/{account_id}/customers/{customer_id}/entitlements/{entitlement_id}
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Returns the requested Entitlement resource. Possible error codes: * PERMISSION_DENIED: The customer
                /// doesn't belong to the reseller. * INVALID_ARGUMENT: Required request parameters are missing or
                /// invalid. * NOT_FOUND: The customer entitlement was not found. Return value: The requested
                /// Entitlement resource.
                /// </summary>
                public class GetRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1Entitlement>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the entitlement to retrieve. Name uses the format:
                    /// accounts/{account_id}/customers/{customer_id}/entitlements/{entitlement_id}
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
                            Pattern = @"^accounts/[^/]+/customers/[^/]+/entitlements/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists Entitlements belonging to a customer. Possible error codes: * PERMISSION_DENIED: The customer
                /// doesn't belong to the reseller. * INVALID_ARGUMENT: Required request parameters are missing or
                /// invalid. Return value: A list of the customer's Entitlements.
                /// </summary>
                /// <param name="parent">
                /// Required. The resource name of the reseller's customer account to list entitlements for. Parent uses
                /// the format: accounts/{account_id}/customers/{customer_id}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Lists Entitlements belonging to a customer. Possible error codes: * PERMISSION_DENIED: The customer
                /// doesn't belong to the reseller. * INVALID_ARGUMENT: Required request parameters are missing or
                /// invalid. Return value: A list of the customer's Entitlements.
                /// </summary>
                public class ListRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1ListEntitlementsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the reseller's customer account to list entitlements for. Parent
                    /// uses the format: accounts/{account_id}/customers/{customer_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. Requested page size. Server might return fewer results than requested. If unspecified,
                    /// return at most 50 entitlements. The maximum value is 100; the server will coerce values above
                    /// 100.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A token for a page of results other than the first page. Obtained using
                    /// ListEntitlementsResponse.next_page_token of the previous CloudChannelService.ListEntitlements
                    /// call.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/entitlements";

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
                            Pattern = @"^accounts/[^/]+/customers/[^/]+$",
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
                /// Returns the requested Offer resource. Possible error codes: * PERMISSION_DENIED: The entitlement
                /// doesn't belong to the reseller. * INVALID_ARGUMENT: Required request parameters are missing or
                /// invalid. * NOT_FOUND: Entitlement or offer was not found. Return value: The Offer resource.
                /// </summary>
                /// <param name="entitlement">
                /// Required. The resource name of the entitlement to retrieve the Offer. Entitlement uses the format:
                /// accounts/{account_id}/customers/{customer_id}/entitlements/{entitlement_id}
                /// </param>
                public virtual LookupOfferRequest LookupOffer(string entitlement)
                {
                    return new LookupOfferRequest(service, entitlement);
                }

                /// <summary>
                /// Returns the requested Offer resource. Possible error codes: * PERMISSION_DENIED: The entitlement
                /// doesn't belong to the reseller. * INVALID_ARGUMENT: Required request parameters are missing or
                /// invalid. * NOT_FOUND: Entitlement or offer was not found. Return value: The Offer resource.
                /// </summary>
                public class LookupOfferRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1Offer>
                {
                    /// <summary>Constructs a new LookupOffer request.</summary>
                    public LookupOfferRequest(Google.Apis.Services.IClientService service, string entitlement) : base(service)
                    {
                        Entitlement = entitlement;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the entitlement to retrieve the Offer. Entitlement uses the
                    /// format: accounts/{account_id}/customers/{customer_id}/entitlements/{entitlement_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("entitlement", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Entitlement { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "lookupOffer";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+entitlement}:lookupOffer";

                    /// <summary>Initializes LookupOffer parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("entitlement", new Google.Apis.Discovery.Parameter
                        {
                            Name = "entitlement",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^accounts/[^/]+/customers/[^/]+/entitlements/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Starts paid service for a trial entitlement. Starts paid service for a trial entitlement
                /// immediately. This method is only applicable if a plan is set up for a trial entitlement but has some
                /// trial days remaining. Possible error codes: * PERMISSION_DENIED: The customer doesn't belong to the
                /// reseller. * INVALID_ARGUMENT: Required request parameters are missing or invalid. * NOT_FOUND:
                /// Entitlement resource not found. * FAILED_PRECONDITION/NOT_IN_TRIAL: This method only works for
                /// entitlement on trial plans. * INTERNAL: Any non-user error related to a technical issue in the
                /// backend. Contact Cloud Channel support. * UNKNOWN: Any non-user error related to a technical issue
                /// in the backend. Contact Cloud Channel support. Return value: The ID of a long-running operation. To
                /// get the results of the operation, call the GetOperation method of CloudChannelOperationsService. The
                /// Operation metadata will contain an instance of OperationMetadata.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the entitlement to start a paid service for. Name uses the format:
                /// accounts/{account_id}/customers/{customer_id}/entitlements/{entitlement_id}
                /// </param>
                public virtual StartPaidServiceRequest StartPaidService(Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1StartPaidServiceRequest body, string name)
                {
                    return new StartPaidServiceRequest(service, body, name);
                }

                /// <summary>
                /// Starts paid service for a trial entitlement. Starts paid service for a trial entitlement
                /// immediately. This method is only applicable if a plan is set up for a trial entitlement but has some
                /// trial days remaining. Possible error codes: * PERMISSION_DENIED: The customer doesn't belong to the
                /// reseller. * INVALID_ARGUMENT: Required request parameters are missing or invalid. * NOT_FOUND:
                /// Entitlement resource not found. * FAILED_PRECONDITION/NOT_IN_TRIAL: This method only works for
                /// entitlement on trial plans. * INTERNAL: Any non-user error related to a technical issue in the
                /// backend. Contact Cloud Channel support. * UNKNOWN: Any non-user error related to a technical issue
                /// in the backend. Contact Cloud Channel support. Return value: The ID of a long-running operation. To
                /// get the results of the operation, call the GetOperation method of CloudChannelOperationsService. The
                /// Operation metadata will contain an instance of OperationMetadata.
                /// </summary>
                public class StartPaidServiceRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new StartPaidService request.</summary>
                    public StartPaidServiceRequest(Google.Apis.Services.IClientService service, Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1StartPaidServiceRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the entitlement to start a paid service for. Name uses the format:
                    /// accounts/{account_id}/customers/{customer_id}/entitlements/{entitlement_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1StartPaidServiceRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "startPaidService";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:startPaidService";

                    /// <summary>Initializes StartPaidService parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^accounts/[^/]+/customers/[^/]+/entitlements/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Suspends a previously fulfilled entitlement. An entitlement suspension is a long-running operation.
                /// Possible error codes: * PERMISSION_DENIED: The customer doesn't belong to the reseller. *
                /// INVALID_ARGUMENT: Required request parameters are missing or invalid. * NOT_FOUND: Entitlement
                /// resource not found. * NOT_ACTIVE: Entitlement is not active. * INTERNAL: Any non-user error related
                /// to a technical issue in the backend. Contact Cloud Channel support. * UNKNOWN: Any non-user error
                /// related to a technical issue in the backend. Contact Cloud Channel support. Return value: The ID of
                /// a long-running operation. To get the results of the operation, call the GetOperation method of
                /// CloudChannelOperationsService. The Operation metadata will contain an instance of OperationMetadata.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The resource name of the entitlement to suspend. Name uses the format:
                /// accounts/{account_id}/customers/{customer_id}/entitlements/{entitlement_id}
                /// </param>
                public virtual SuspendRequest Suspend(Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1SuspendEntitlementRequest body, string name)
                {
                    return new SuspendRequest(service, body, name);
                }

                /// <summary>
                /// Suspends a previously fulfilled entitlement. An entitlement suspension is a long-running operation.
                /// Possible error codes: * PERMISSION_DENIED: The customer doesn't belong to the reseller. *
                /// INVALID_ARGUMENT: Required request parameters are missing or invalid. * NOT_FOUND: Entitlement
                /// resource not found. * NOT_ACTIVE: Entitlement is not active. * INTERNAL: Any non-user error related
                /// to a technical issue in the backend. Contact Cloud Channel support. * UNKNOWN: Any non-user error
                /// related to a technical issue in the backend. Contact Cloud Channel support. Return value: The ID of
                /// a long-running operation. To get the results of the operation, call the GetOperation method of
                /// CloudChannelOperationsService. The Operation metadata will contain an instance of OperationMetadata.
                /// </summary>
                public class SuspendRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Suspend request.</summary>
                    public SuspendRequest(Google.Apis.Services.IClientService service, Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1SuspendEntitlementRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the entitlement to suspend. Name uses the format:
                    /// accounts/{account_id}/customers/{customer_id}/entitlements/{entitlement_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1SuspendEntitlementRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "suspend";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:suspend";

                    /// <summary>Initializes Suspend parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^accounts/[^/]+/customers/[^/]+/entitlements/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>
            /// Creates a new Customer resource under the reseller or distributor account. Possible error codes: *
            /// PERMISSION_DENIED: The reseller account making the request is different from the reseller account in the
            /// API request. * INVALID_ARGUMENT: * Required request parameters are missing or invalid. * Domain field
            /// value doesn't match the primary email domain. Return value: The newly created Customer resource.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The resource name of reseller account in which to create the customer. Parent uses the format:
            /// accounts/{account_id}
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1Customer body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Creates a new Customer resource under the reseller or distributor account. Possible error codes: *
            /// PERMISSION_DENIED: The reseller account making the request is different from the reseller account in the
            /// API request. * INVALID_ARGUMENT: * Required request parameters are missing or invalid. * Domain field
            /// value doesn't match the primary email domain. Return value: The newly created Customer resource.
            /// </summary>
            public class CreateRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1Customer>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1Customer body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of reseller account in which to create the customer. Parent uses the
                /// format: accounts/{account_id}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1Customer Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/customers";

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

            /// <summary>
            /// Deletes the given Customer permanently. Possible error codes: * PERMISSION_DENIED: The account making
            /// the request does not own this customer. * INVALID_ARGUMENT: Required request parameters are missing or
            /// invalid. * FAILED_PRECONDITION: The customer has existing entitlements. * NOT_FOUND: No Customer
            /// resource found for the name in the request.
            /// </summary>
            /// <param name="name">Required. The resource name of the customer to delete.</param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>
            /// Deletes the given Customer permanently. Possible error codes: * PERMISSION_DENIED: The account making
            /// the request does not own this customer. * INVALID_ARGUMENT: Required request parameters are missing or
            /// invalid. * FAILED_PRECONDITION: The customer has existing entitlements. * NOT_FOUND: No Customer
            /// resource found for the name in the request.
            /// </summary>
            public class DeleteRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. The resource name of the customer to delete.</summary>
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
                        Pattern = @"^accounts/[^/]+/customers/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Returns the requested Customer resource. Possible error codes: * PERMISSION_DENIED: The reseller account
            /// making the request is different from the reseller account in the API request. * INVALID_ARGUMENT:
            /// Required request parameters are missing or invalid. * NOT_FOUND: The customer resource doesn't exist.
            /// Usually the result of an invalid name parameter. Return value: The Customer resource.
            /// </summary>
            /// <param name="name">
            /// Required. The resource name of the customer to retrieve. Name uses the format:
            /// accounts/{account_id}/customers/{customer_id}
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>
            /// Returns the requested Customer resource. Possible error codes: * PERMISSION_DENIED: The reseller account
            /// making the request is different from the reseller account in the API request. * INVALID_ARGUMENT:
            /// Required request parameters are missing or invalid. * NOT_FOUND: The customer resource doesn't exist.
            /// Usually the result of an invalid name parameter. Return value: The Customer resource.
            /// </summary>
            public class GetRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1Customer>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the customer to retrieve. Name uses the format:
                /// accounts/{account_id}/customers/{customer_id}
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
                        Pattern = @"^accounts/[^/]+/customers/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// List Customers. Possible error codes: * PERMISSION_DENIED: The reseller account making the request is
            /// different from the reseller account in the API request. * INVALID_ARGUMENT: Required request parameters
            /// are missing or invalid. Return value: List of Customers, or an empty list if there are no customers.
            /// </summary>
            /// <param name="parent">
            /// Required. The resource name of the reseller account to list customers from. Parent uses the format:
            /// accounts/{account_id}.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// List Customers. Possible error codes: * PERMISSION_DENIED: The reseller account making the request is
            /// different from the reseller account in the API request. * INVALID_ARGUMENT: Required request parameters
            /// are missing or invalid. Return value: List of Customers, or an empty list if there are no customers.
            /// </summary>
            public class ListRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1ListCustomersResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the reseller account to list customers from. Parent uses the format:
                /// accounts/{account_id}.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of customers to return. The service may return fewer than this value.
                /// If unspecified, returns at most 10 customers. The maximum value is 50.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A token identifying a page of results other than the first page. Obtained through
                /// ListCustomersResponse.next_page_token of the previous CloudChannelService.ListCustomers call.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/customers";

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

            /// <summary>
            /// Lists the following: * Offers that you can purchase for a customer. * Offers that you can change for an
            /// entitlement. Possible error codes: * PERMISSION_DENIED: The customer doesn't belong to the reseller *
            /// INVALID_ARGUMENT: Required request parameters are missing or invalid.
            /// </summary>
            /// <param name="customer">
            /// Required. The resource name of the customer to list Offers for. Format:
            /// accounts/{account_id}/customers/{customer_id}.
            /// </param>
            public virtual ListPurchasableOffersRequest ListPurchasableOffers(string customer)
            {
                return new ListPurchasableOffersRequest(service, customer);
            }

            /// <summary>
            /// Lists the following: * Offers that you can purchase for a customer. * Offers that you can change for an
            /// entitlement. Possible error codes: * PERMISSION_DENIED: The customer doesn't belong to the reseller *
            /// INVALID_ARGUMENT: Required request parameters are missing or invalid.
            /// </summary>
            public class ListPurchasableOffersRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1ListPurchasableOffersResponse>
            {
                /// <summary>Constructs a new ListPurchasableOffers request.</summary>
                public ListPurchasableOffersRequest(Google.Apis.Services.IClientService service, string customer) : base(service)
                {
                    Customer = customer;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the customer to list Offers for. Format:
                /// accounts/{account_id}/customers/{customer_id}.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>
                /// Required. Resource name of the entitlement. Format:
                /// accounts/{account_id}/customers/{customer_id}/entitlements/{entitlement_id}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("changeOfferPurchase.entitlement", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ChangeOfferPurchaseEntitlement { get; set; }

                /// <summary>
                /// Optional. Resource name of the new target SKU. Provide this SKU when upgrading or downgrading an
                /// entitlement. Format: products/{product_id}/skus/{sku_id}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("changeOfferPurchase.newSku", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ChangeOfferPurchaseNewSku { get; set; }

                /// <summary>
                /// Required. SKU that the result should be restricted to. Format: products/{product_id}/skus/{sku_id}.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("createEntitlementPurchase.sku", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string CreateEntitlementPurchaseSku { get; set; }

                /// <summary>
                /// Optional. The BCP-47 language code. For example, "en-US". The response will localize in the
                /// corresponding language code, if specified. The default value is "en-US".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string LanguageCode { get; set; }

                /// <summary>
                /// Optional. Requested page size. Server might return fewer results than requested. If unspecified,
                /// returns at most 100 Offers. The maximum value is 1000; the server will coerce values above 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Optional. A token for a page of results other than the first page.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "listPurchasableOffers";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+customer}:listPurchasableOffers";

                /// <summary>Initializes ListPurchasableOffers parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+/customers/[^/]+$",
                    });
                    RequestParameters.Add("changeOfferPurchase.entitlement", new Google.Apis.Discovery.Parameter
                    {
                        Name = "changeOfferPurchase.entitlement",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("changeOfferPurchase.newSku", new Google.Apis.Discovery.Parameter
                    {
                        Name = "changeOfferPurchase.newSku",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("createEntitlementPurchase.sku", new Google.Apis.Discovery.Parameter
                    {
                        Name = "createEntitlementPurchase.sku",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("languageCode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "languageCode",
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
            /// Lists the following: * SKUs that you can purchase for a customer * SKUs that you can upgrade or
            /// downgrade for an entitlement. Possible error codes: * PERMISSION_DENIED: The customer doesn't belong to
            /// the reseller. * INVALID_ARGUMENT: Required request parameters are missing or invalid.
            /// </summary>
            /// <param name="customer">
            /// Required. The resource name of the customer to list SKUs for. Format:
            /// accounts/{account_id}/customers/{customer_id}.
            /// </param>
            public virtual ListPurchasableSkusRequest ListPurchasableSkus(string customer)
            {
                return new ListPurchasableSkusRequest(service, customer);
            }

            /// <summary>
            /// Lists the following: * SKUs that you can purchase for a customer * SKUs that you can upgrade or
            /// downgrade for an entitlement. Possible error codes: * PERMISSION_DENIED: The customer doesn't belong to
            /// the reseller. * INVALID_ARGUMENT: Required request parameters are missing or invalid.
            /// </summary>
            public class ListPurchasableSkusRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1ListPurchasableSkusResponse>
            {
                /// <summary>Constructs a new ListPurchasableSkus request.</summary>
                public ListPurchasableSkusRequest(Google.Apis.Services.IClientService service, string customer) : base(service)
                {
                    Customer = customer;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the customer to list SKUs for. Format:
                /// accounts/{account_id}/customers/{customer_id}.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>Required. Change Type for the entitlement.</summary>
                [Google.Apis.Util.RequestParameterAttribute("changeOfferPurchase.changeType", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ChangeOfferPurchaseChangeTypeEnum> ChangeOfferPurchaseChangeType { get; set; }

                /// <summary>Required. Change Type for the entitlement.</summary>
                public enum ChangeOfferPurchaseChangeTypeEnum
                {
                    /// <summary>Not used.</summary>
                    [Google.Apis.Util.StringValueAttribute("CHANGE_TYPE_UNSPECIFIED")]
                    CHANGETYPEUNSPECIFIED = 0,

                    /// <summary>SKU is an upgrade on the current entitlement.</summary>
                    [Google.Apis.Util.StringValueAttribute("UPGRADE")]
                    UPGRADE = 1,

                    /// <summary>SKU is a downgrade on the current entitlement.</summary>
                    [Google.Apis.Util.StringValueAttribute("DOWNGRADE")]
                    DOWNGRADE = 2,
                }

                /// <summary>
                /// Required. Resource name of the entitlement. Format:
                /// accounts/{account_id}/customers/{customer_id}/entitlements/{entitlement_id}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("changeOfferPurchase.entitlement", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ChangeOfferPurchaseEntitlement { get; set; }

                /// <summary>
                /// Required. List SKUs belonging to this Product. Format: products/{product_id}. Supports products/- to
                /// retrieve SKUs for all products.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("createEntitlementPurchase.product", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string CreateEntitlementPurchaseProduct { get; set; }

                /// <summary>
                /// Optional. The BCP-47 language code. For example, "en-US". The response will localize in the
                /// corresponding language code, if specified. The default value is "en-US".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string LanguageCode { get; set; }

                /// <summary>
                /// Optional. Requested page size. Server might return fewer results than requested. If unspecified,
                /// returns at most 100 SKUs. The maximum value is 1000; the server will coerce values above 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Optional. A token for a page of results other than the first page.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "listPurchasableSkus";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+customer}:listPurchasableSkus";

                /// <summary>Initializes ListPurchasableSkus parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+/customers/[^/]+$",
                    });
                    RequestParameters.Add("changeOfferPurchase.changeType", new Google.Apis.Discovery.Parameter
                    {
                        Name = "changeOfferPurchase.changeType",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("changeOfferPurchase.entitlement", new Google.Apis.Discovery.Parameter
                    {
                        Name = "changeOfferPurchase.entitlement",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("createEntitlementPurchase.product", new Google.Apis.Discovery.Parameter
                    {
                        Name = "createEntitlementPurchase.product",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("languageCode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "languageCode",
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
            /// Updates an existing Customer resource for the reseller or distributor. Possible error codes: *
            /// PERMISSION_DENIED: The reseller account making the request is different from the reseller account in the
            /// API request. * INVALID_ARGUMENT: Required request parameters are missing or invalid. * NOT_FOUND: No
            /// Customer resource found for the name in the request. Return value: The updated Customer resource.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Output only. Resource name of the customer. Format: accounts/{account_id}/customers/{customer_id}
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1Customer body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>
            /// Updates an existing Customer resource for the reseller or distributor. Possible error codes: *
            /// PERMISSION_DENIED: The reseller account making the request is different from the reseller account in the
            /// API request. * INVALID_ARGUMENT: Required request parameters are missing or invalid. * NOT_FOUND: No
            /// Customer resource found for the name in the request. Return value: The updated Customer resource.
            /// </summary>
            public class PatchRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1Customer>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1Customer body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Output only. Resource name of the customer. Format: accounts/{account_id}/customers/{customer_id}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>The update mask that applies to the resource. Optional.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1Customer Body { get; set; }

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
                        Pattern = @"^accounts/[^/]+/customers/[^/]+$",
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
            /// Creates a Cloud Identity for the given customer using the customer's information, or the information
            /// provided here. Possible error codes: * PERMISSION_DENIED: The customer doesn't belong to the reseller. *
            /// INVALID_ARGUMENT: Required request parameters are missing or invalid. * NOT_FOUND: The customer was not
            /// found. * ALREADY_EXISTS: The customer's primary email already exists. Retry after changing the
            /// customer's primary contact email. * INTERNAL: Any non-user error related to a technical issue in the
            /// backend. Contact Cloud Channel support. * UNKNOWN: Any non-user error related to a technical issue in
            /// the backend. Contact Cloud Channel support. Return value: The ID of a long-running operation. To get the
            /// results of the operation, call the GetOperation method of CloudChannelOperationsService. The Operation
            /// metadata contains an instance of OperationMetadata.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="customer">
            /// Required. Resource name of the customer. Format: accounts/{account_id}/customers/{customer_id}
            /// </param>
            public virtual ProvisionCloudIdentityRequest ProvisionCloudIdentity(Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1ProvisionCloudIdentityRequest body, string customer)
            {
                return new ProvisionCloudIdentityRequest(service, body, customer);
            }

            /// <summary>
            /// Creates a Cloud Identity for the given customer using the customer's information, or the information
            /// provided here. Possible error codes: * PERMISSION_DENIED: The customer doesn't belong to the reseller. *
            /// INVALID_ARGUMENT: Required request parameters are missing or invalid. * NOT_FOUND: The customer was not
            /// found. * ALREADY_EXISTS: The customer's primary email already exists. Retry after changing the
            /// customer's primary contact email. * INTERNAL: Any non-user error related to a technical issue in the
            /// backend. Contact Cloud Channel support. * UNKNOWN: Any non-user error related to a technical issue in
            /// the backend. Contact Cloud Channel support. Return value: The ID of a long-running operation. To get the
            /// results of the operation, call the GetOperation method of CloudChannelOperationsService. The Operation
            /// metadata contains an instance of OperationMetadata.
            /// </summary>
            public class ProvisionCloudIdentityRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleLongrunningOperation>
            {
                /// <summary>Constructs a new ProvisionCloudIdentity request.</summary>
                public ProvisionCloudIdentityRequest(Google.Apis.Services.IClientService service, Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1ProvisionCloudIdentityRequest body, string customer) : base(service)
                {
                    Customer = customer;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the customer. Format: accounts/{account_id}/customers/{customer_id}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1ProvisionCloudIdentityRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "provisionCloudIdentity";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+customer}:provisionCloudIdentity";

                /// <summary>Initializes ProvisionCloudIdentity parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+/customers/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Transfers customer entitlements to new reseller. Possible error codes: * PERMISSION_DENIED: The customer
            /// doesn't belong to the reseller. * INVALID_ARGUMENT: Required request parameters are missing or invalid.
            /// * NOT_FOUND: The customer or offer resource was not found. * ALREADY_EXISTS: The SKU was already
            /// transferred for the customer. * CONDITION_NOT_MET or FAILED_PRECONDITION: * The SKU requires domain
            /// verification to transfer, but the domain is not verified. * An Add-On SKU (example, Vault or Drive) is
            /// missing the pre-requisite SKU (example, G Suite Basic). * (Developer accounts only) Reseller and resold
            /// domain must meet the following naming requirements: * Domain names must start with goog-test. * Domain
            /// names must include the reseller domain. * Specify all transferring entitlements. * INTERNAL: Any
            /// non-user error related to a technical issue in the backend. Contact Cloud Channel support. * UNKNOWN:
            /// Any non-user error related to a technical issue in the backend. Contact Cloud Channel support. Return
            /// value: The ID of a long-running operation. To get the results of the operation, call the GetOperation
            /// method of CloudChannelOperationsService. The Operation metadata will contain an instance of
            /// OperationMetadata.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The resource name of the reseller's customer account that will receive transferred
            /// entitlements. Parent uses the format: accounts/{account_id}/customers/{customer_id}
            /// </param>
            public virtual TransferEntitlementsRequest TransferEntitlements(Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1TransferEntitlementsRequest body, string parent)
            {
                return new TransferEntitlementsRequest(service, body, parent);
            }

            /// <summary>
            /// Transfers customer entitlements to new reseller. Possible error codes: * PERMISSION_DENIED: The customer
            /// doesn't belong to the reseller. * INVALID_ARGUMENT: Required request parameters are missing or invalid.
            /// * NOT_FOUND: The customer or offer resource was not found. * ALREADY_EXISTS: The SKU was already
            /// transferred for the customer. * CONDITION_NOT_MET or FAILED_PRECONDITION: * The SKU requires domain
            /// verification to transfer, but the domain is not verified. * An Add-On SKU (example, Vault or Drive) is
            /// missing the pre-requisite SKU (example, G Suite Basic). * (Developer accounts only) Reseller and resold
            /// domain must meet the following naming requirements: * Domain names must start with goog-test. * Domain
            /// names must include the reseller domain. * Specify all transferring entitlements. * INTERNAL: Any
            /// non-user error related to a technical issue in the backend. Contact Cloud Channel support. * UNKNOWN:
            /// Any non-user error related to a technical issue in the backend. Contact Cloud Channel support. Return
            /// value: The ID of a long-running operation. To get the results of the operation, call the GetOperation
            /// method of CloudChannelOperationsService. The Operation metadata will contain an instance of
            /// OperationMetadata.
            /// </summary>
            public class TransferEntitlementsRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleLongrunningOperation>
            {
                /// <summary>Constructs a new TransferEntitlements request.</summary>
                public TransferEntitlementsRequest(Google.Apis.Services.IClientService service, Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1TransferEntitlementsRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the reseller's customer account that will receive transferred
                /// entitlements. Parent uses the format: accounts/{account_id}/customers/{customer_id}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1TransferEntitlementsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "transferEntitlements";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}:transferEntitlements";

                /// <summary>Initializes TransferEntitlements parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+/customers/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Transfers customer entitlements from their current reseller to Google. Possible error codes: *
            /// PERMISSION_DENIED: The customer doesn't belong to the reseller. * INVALID_ARGUMENT: Required request
            /// parameters are missing or invalid. * NOT_FOUND: The customer or offer resource was not found. *
            /// ALREADY_EXISTS: The SKU was already transferred for the customer. * CONDITION_NOT_MET or
            /// FAILED_PRECONDITION: * The SKU requires domain verification to transfer, but the domain is not verified.
            /// * An Add-On SKU (example, Vault or Drive) is missing the pre-requisite SKU (example, G Suite Basic). *
            /// (Developer accounts only) Reseller and resold domain must meet the following naming requirements: *
            /// Domain names must start with goog-test. * Domain names must include the reseller domain. * INTERNAL: Any
            /// non-user error related to a technical issue in the backend. Contact Cloud Channel support. * UNKNOWN:
            /// Any non-user error related to a technical issue in the backend. Contact Cloud Channel support. Return
            /// value: The ID of a long-running operation. To get the results of the operation, call the GetOperation
            /// method of CloudChannelOperationsService. The response will contain google.protobuf.Empty on success. The
            /// Operation metadata will contain an instance of OperationMetadata.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The resource name of the reseller's customer account where the entitlements transfer from.
            /// Parent uses the format: accounts/{account_id}/customers/{customer_id}
            /// </param>
            public virtual TransferEntitlementsToGoogleRequest TransferEntitlementsToGoogle(Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1TransferEntitlementsToGoogleRequest body, string parent)
            {
                return new TransferEntitlementsToGoogleRequest(service, body, parent);
            }

            /// <summary>
            /// Transfers customer entitlements from their current reseller to Google. Possible error codes: *
            /// PERMISSION_DENIED: The customer doesn't belong to the reseller. * INVALID_ARGUMENT: Required request
            /// parameters are missing or invalid. * NOT_FOUND: The customer or offer resource was not found. *
            /// ALREADY_EXISTS: The SKU was already transferred for the customer. * CONDITION_NOT_MET or
            /// FAILED_PRECONDITION: * The SKU requires domain verification to transfer, but the domain is not verified.
            /// * An Add-On SKU (example, Vault or Drive) is missing the pre-requisite SKU (example, G Suite Basic). *
            /// (Developer accounts only) Reseller and resold domain must meet the following naming requirements: *
            /// Domain names must start with goog-test. * Domain names must include the reseller domain. * INTERNAL: Any
            /// non-user error related to a technical issue in the backend. Contact Cloud Channel support. * UNKNOWN:
            /// Any non-user error related to a technical issue in the backend. Contact Cloud Channel support. Return
            /// value: The ID of a long-running operation. To get the results of the operation, call the GetOperation
            /// method of CloudChannelOperationsService. The response will contain google.protobuf.Empty on success. The
            /// Operation metadata will contain an instance of OperationMetadata.
            /// </summary>
            public class TransferEntitlementsToGoogleRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleLongrunningOperation>
            {
                /// <summary>Constructs a new TransferEntitlementsToGoogle request.</summary>
                public TransferEntitlementsToGoogleRequest(Google.Apis.Services.IClientService service, Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1TransferEntitlementsToGoogleRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the reseller's customer account where the entitlements transfer from.
                /// Parent uses the format: accounts/{account_id}/customers/{customer_id}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1TransferEntitlementsToGoogleRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "transferEntitlementsToGoogle";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}:transferEntitlementsToGoogle";

                /// <summary>Initializes TransferEntitlementsToGoogle parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+/customers/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the Offers resource.</summary>
        public virtual OffersResource Offers { get; }

        /// <summary>The "offers" collection of methods.</summary>
        public class OffersResource
        {
            private const string Resource = "offers";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public OffersResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Lists the Offers the reseller can sell. Possible error codes: * INVALID_ARGUMENT: Required request
            /// parameters are missing or invalid.
            /// </summary>
            /// <param name="parent">
            /// Required. The resource name of the reseller account from which to list Offers. Parent uses the format:
            /// accounts/{account_id}.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Lists the Offers the reseller can sell. Possible error codes: * INVALID_ARGUMENT: Required request
            /// parameters are missing or invalid.
            /// </summary>
            public class ListRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1ListOffersResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the reseller account from which to list Offers. Parent uses the
                /// format: accounts/{account_id}.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The expression to filter results by name (name of the Offer), sku.name (name of the SKU),
                /// or sku.product.name (name of the Product). Example 1: sku.product.name=products/p1 AND
                /// sku.name!=products/p1/skus/s1 Example 2: name=accounts/a1/offers/o1
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Optional. The BCP-47 language code. For example, "en-US". The response will localize in the
                /// corresponding language code, if specified. The default value is "en-US".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string LanguageCode { get; set; }

                /// <summary>
                /// Optional. Requested page size. Server might return fewer results than requested. If unspecified,
                /// returns at most 500 Offers. The maximum value is 1000; the server will coerce values above 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Optional. A token for a page of results other than the first page.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/offers";

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
                    RequestParameters.Add("languageCode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "languageCode",
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

        /// <summary>
        /// Confirms the existence of Cloud Identity accounts based on the domain and if the Cloud Identity accounts are
        /// owned by the reseller. Possible error codes: * PERMISSION_DENIED: The reseller account making the request is
        /// different from the reseller account in the API request. * INVALID_ARGUMENT: Required request parameters are
        /// missing or invalid. * INVALID_VALUE: Invalid domain value in the request. Return value: A list of
        /// CloudIdentityCustomerAccount resources for the domain (may be empty) Note: in the v1alpha1 version of the
        /// API, a NOT_FOUND error returns if no CloudIdentityCustomerAccount resources match the domain.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">
        /// Required. The reseller account's resource name. Parent uses the format: accounts/{account_id}
        /// </param>
        public virtual CheckCloudIdentityAccountsExistRequest CheckCloudIdentityAccountsExist(Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1CheckCloudIdentityAccountsExistRequest body, string parent)
        {
            return new CheckCloudIdentityAccountsExistRequest(service, body, parent);
        }

        /// <summary>
        /// Confirms the existence of Cloud Identity accounts based on the domain and if the Cloud Identity accounts are
        /// owned by the reseller. Possible error codes: * PERMISSION_DENIED: The reseller account making the request is
        /// different from the reseller account in the API request. * INVALID_ARGUMENT: Required request parameters are
        /// missing or invalid. * INVALID_VALUE: Invalid domain value in the request. Return value: A list of
        /// CloudIdentityCustomerAccount resources for the domain (may be empty) Note: in the v1alpha1 version of the
        /// API, a NOT_FOUND error returns if no CloudIdentityCustomerAccount resources match the domain.
        /// </summary>
        public class CheckCloudIdentityAccountsExistRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1CheckCloudIdentityAccountsExistResponse>
        {
            /// <summary>Constructs a new CheckCloudIdentityAccountsExist request.</summary>
            public CheckCloudIdentityAccountsExistRequest(Google.Apis.Services.IClientService service, Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1CheckCloudIdentityAccountsExistRequest body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. The reseller account's resource name. Parent uses the format: accounts/{account_id}
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1CheckCloudIdentityAccountsExistRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "checkCloudIdentityAccountsExist";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+parent}:checkCloudIdentityAccountsExist";

            /// <summary>Initializes CheckCloudIdentityAccountsExist parameter list.</summary>
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
        /// Lists service accounts with subscriber privileges on the Cloud Pub/Sub topic created for this Channel
        /// Services account. Possible error codes: * PERMISSION_DENIED: The reseller account making the request and the
        /// provided reseller account are different, or the impersonated user is not a super admin. * INVALID_ARGUMENT:
        /// Required request parameters are missing or invalid. * NOT_FOUND: The topic resource doesn't exist. *
        /// INTERNAL: Any non-user error related to a technical issue in the backend. Contact Cloud Channel support. *
        /// UNKNOWN: Any non-user error related to a technical issue in the backend. Contact Cloud Channel support.
        /// Return value: A list of service email addresses.
        /// </summary>
        /// <param name="account">Required. Resource name of the account.</param>
        public virtual ListSubscribersRequest ListSubscribers(string account)
        {
            return new ListSubscribersRequest(service, account);
        }

        /// <summary>
        /// Lists service accounts with subscriber privileges on the Cloud Pub/Sub topic created for this Channel
        /// Services account. Possible error codes: * PERMISSION_DENIED: The reseller account making the request and the
        /// provided reseller account are different, or the impersonated user is not a super admin. * INVALID_ARGUMENT:
        /// Required request parameters are missing or invalid. * NOT_FOUND: The topic resource doesn't exist. *
        /// INTERNAL: Any non-user error related to a technical issue in the backend. Contact Cloud Channel support. *
        /// UNKNOWN: Any non-user error related to a technical issue in the backend. Contact Cloud Channel support.
        /// Return value: A list of service email addresses.
        /// </summary>
        public class ListSubscribersRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1ListSubscribersResponse>
        {
            /// <summary>Constructs a new ListSubscribers request.</summary>
            public ListSubscribersRequest(Google.Apis.Services.IClientService service, string account) : base(service)
            {
                Account = account;
                InitParameters();
            }

            /// <summary>Required. Resource name of the account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("account", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Account { get; private set; }

            /// <summary>
            /// Optional. The maximum number of service accounts to return. The service may return fewer than this
            /// value. If unspecified, returns at most 100 service accounts. The maximum value is 1000; the server will
            /// coerce values above 1000.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. A page token, received from a previous `ListSubscribers` call. Provide this to retrieve the
            /// subsequent page. When paginating, all other parameters provided to `ListSubscribers` must match the call
            /// that provided the page token.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "listSubscribers";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+account}:listSubscribers";

            /// <summary>Initializes ListSubscribers parameter list.</summary>
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
        /// List TransferableOffers of a customer based on Cloud Identity ID or Customer Name in the request. Use this
        /// method when a reseller gets the entitlement information of an unowned customer. The reseller should provide
        /// the customer's Cloud Identity ID or Customer Name. Possible error codes: * PERMISSION_DENIED: * The customer
        /// doesn't belong to the reseller and has no auth token. * The supplied auth token is invalid. * The reseller
        /// account making the request is different from the reseller account in the query. * INVALID_ARGUMENT: Required
        /// request parameters are missing or invalid. Return value: List of TransferableOffer for the given customer
        /// and SKU.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">Required. The resource name of the reseller's account.</param>
        public virtual ListTransferableOffersRequest ListTransferableOffers(Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1ListTransferableOffersRequest body, string parent)
        {
            return new ListTransferableOffersRequest(service, body, parent);
        }

        /// <summary>
        /// List TransferableOffers of a customer based on Cloud Identity ID or Customer Name in the request. Use this
        /// method when a reseller gets the entitlement information of an unowned customer. The reseller should provide
        /// the customer's Cloud Identity ID or Customer Name. Possible error codes: * PERMISSION_DENIED: * The customer
        /// doesn't belong to the reseller and has no auth token. * The supplied auth token is invalid. * The reseller
        /// account making the request is different from the reseller account in the query. * INVALID_ARGUMENT: Required
        /// request parameters are missing or invalid. Return value: List of TransferableOffer for the given customer
        /// and SKU.
        /// </summary>
        public class ListTransferableOffersRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1ListTransferableOffersResponse>
        {
            /// <summary>Constructs a new ListTransferableOffers request.</summary>
            public ListTransferableOffersRequest(Google.Apis.Services.IClientService service, Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1ListTransferableOffersRequest body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The resource name of the reseller's account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1ListTransferableOffersRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "listTransferableOffers";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+parent}:listTransferableOffers";

            /// <summary>Initializes ListTransferableOffers parameter list.</summary>
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
        /// List TransferableSkus of a customer based on the Cloud Identity ID or Customer Name in the request. Use this
        /// method to list the entitlements information of an unowned customer. You should provide the customer's Cloud
        /// Identity ID or Customer Name. Possible error codes: * PERMISSION_DENIED: * The customer doesn't belong to
        /// the reseller and has no auth token. * The supplied auth token is invalid. * The reseller account making the
        /// request is different from the reseller account in the query. * INVALID_ARGUMENT: Required request parameters
        /// are missing or invalid. Return value: A list of the customer's TransferableSku.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">
        /// Required. The reseller account's resource name. Parent uses the format: accounts/{account_id}
        /// </param>
        public virtual ListTransferableSkusRequest ListTransferableSkus(Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1ListTransferableSkusRequest body, string parent)
        {
            return new ListTransferableSkusRequest(service, body, parent);
        }

        /// <summary>
        /// List TransferableSkus of a customer based on the Cloud Identity ID or Customer Name in the request. Use this
        /// method to list the entitlements information of an unowned customer. You should provide the customer's Cloud
        /// Identity ID or Customer Name. Possible error codes: * PERMISSION_DENIED: * The customer doesn't belong to
        /// the reseller and has no auth token. * The supplied auth token is invalid. * The reseller account making the
        /// request is different from the reseller account in the query. * INVALID_ARGUMENT: Required request parameters
        /// are missing or invalid. Return value: A list of the customer's TransferableSku.
        /// </summary>
        public class ListTransferableSkusRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1ListTransferableSkusResponse>
        {
            /// <summary>Constructs a new ListTransferableSkus request.</summary>
            public ListTransferableSkusRequest(Google.Apis.Services.IClientService service, Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1ListTransferableSkusRequest body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. The reseller account's resource name. Parent uses the format: accounts/{account_id}
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1ListTransferableSkusRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "listTransferableSkus";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+parent}:listTransferableSkus";

            /// <summary>Initializes ListTransferableSkus parameter list.</summary>
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
        /// Registers a service account with subscriber privileges on the Cloud Pub/Sub topic for this Channel Services
        /// account. After you create a subscriber, you get the events through SubscriberEvent Possible error codes: *
        /// PERMISSION_DENIED: The reseller account making the request and the provided reseller account are different,
        /// or the impersonated user is not a super admin. * INVALID_ARGUMENT: Required request parameters are missing
        /// or invalid. * INTERNAL: Any non-user error related to a technical issue in the backend. Contact Cloud
        /// Channel support. * UNKNOWN: Any non-user error related to a technical issue in the backend. Contact Cloud
        /// Channel support. Return value: The topic name with the registered service email address.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="account">Required. Resource name of the account.</param>
        public virtual RegisterRequest Register(Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1RegisterSubscriberRequest body, string account)
        {
            return new RegisterRequest(service, body, account);
        }

        /// <summary>
        /// Registers a service account with subscriber privileges on the Cloud Pub/Sub topic for this Channel Services
        /// account. After you create a subscriber, you get the events through SubscriberEvent Possible error codes: *
        /// PERMISSION_DENIED: The reseller account making the request and the provided reseller account are different,
        /// or the impersonated user is not a super admin. * INVALID_ARGUMENT: Required request parameters are missing
        /// or invalid. * INTERNAL: Any non-user error related to a technical issue in the backend. Contact Cloud
        /// Channel support. * UNKNOWN: Any non-user error related to a technical issue in the backend. Contact Cloud
        /// Channel support. Return value: The topic name with the registered service email address.
        /// </summary>
        public class RegisterRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1RegisterSubscriberResponse>
        {
            /// <summary>Constructs a new Register request.</summary>
            public RegisterRequest(Google.Apis.Services.IClientService service, Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1RegisterSubscriberRequest body, string account) : base(service)
            {
                Account = account;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Resource name of the account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("account", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Account { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1RegisterSubscriberRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "register";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+account}:register";

            /// <summary>Initializes Register parameter list.</summary>
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

        /// <summary>
        /// Unregisters a service account with subscriber privileges on the Cloud Pub/Sub topic created for this Channel
        /// Services account. If there are no service accounts left with subscriber privileges, this deletes the topic.
        /// You can call ListSubscribers to check for these accounts. Possible error codes: * PERMISSION_DENIED: The
        /// reseller account making the request and the provided reseller account are different, or the impersonated
        /// user is not a super admin. * INVALID_ARGUMENT: Required request parameters are missing or invalid. *
        /// NOT_FOUND: The topic resource doesn't exist. * INTERNAL: Any non-user error related to a technical issue in
        /// the backend. Contact Cloud Channel support. * UNKNOWN: Any non-user error related to a technical issue in
        /// the backend. Contact Cloud Channel support. Return value: The topic name that unregistered the service email
        /// address. Returns a success response if the service email address wasn't registered with the topic.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="account">Required. Resource name of the account.</param>
        public virtual UnregisterRequest Unregister(Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1UnregisterSubscriberRequest body, string account)
        {
            return new UnregisterRequest(service, body, account);
        }

        /// <summary>
        /// Unregisters a service account with subscriber privileges on the Cloud Pub/Sub topic created for this Channel
        /// Services account. If there are no service accounts left with subscriber privileges, this deletes the topic.
        /// You can call ListSubscribers to check for these accounts. Possible error codes: * PERMISSION_DENIED: The
        /// reseller account making the request and the provided reseller account are different, or the impersonated
        /// user is not a super admin. * INVALID_ARGUMENT: Required request parameters are missing or invalid. *
        /// NOT_FOUND: The topic resource doesn't exist. * INTERNAL: Any non-user error related to a technical issue in
        /// the backend. Contact Cloud Channel support. * UNKNOWN: Any non-user error related to a technical issue in
        /// the backend. Contact Cloud Channel support. Return value: The topic name that unregistered the service email
        /// address. Returns a success response if the service email address wasn't registered with the topic.
        /// </summary>
        public class UnregisterRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1UnregisterSubscriberResponse>
        {
            /// <summary>Constructs a new Unregister request.</summary>
            public UnregisterRequest(Google.Apis.Services.IClientService service, Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1UnregisterSubscriberRequest body, string account) : base(service)
            {
                Account = account;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Resource name of the account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("account", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Account { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1UnregisterSubscriberRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "unregister";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+account}:unregister";

            /// <summary>Initializes Unregister parameter list.</summary>
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

    /// <summary>The "operations" collection of methods.</summary>
    public class OperationsResource
    {
        private const string Resource = "operations";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public OperationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to cancel the
        /// operation, but success is not guaranteed. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to check whether
        /// the cancellation succeeded or whether the operation completed despite cancellation. On successful
        /// cancellation, the operation is not deleted; instead, it becomes an operation with an Operation.error value
        /// with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">The name of the operation resource to be cancelled.</param>
        public virtual CancelRequest Cancel(Google.Apis.Cloudchannel.v1.Data.GoogleLongrunningCancelOperationRequest body, string name)
        {
            return new CancelRequest(service, body, name);
        }

        /// <summary>
        /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to cancel the
        /// operation, but success is not guaranteed. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to check whether
        /// the cancellation succeeded or whether the operation completed despite cancellation. On successful
        /// cancellation, the operation is not deleted; instead, it becomes an operation with an Operation.error value
        /// with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
        /// </summary>
        public class CancelRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleProtobufEmpty>
        {
            /// <summary>Constructs a new Cancel request.</summary>
            public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.Cloudchannel.v1.Data.GoogleLongrunningCancelOperationRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>The name of the operation resource to be cancelled.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Cloudchannel.v1.Data.GoogleLongrunningCancelOperationRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "cancel";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}:cancel";

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
                    Pattern = @"^operations/.*$",
                });
            }
        }

        /// <summary>
        /// Deletes a long-running operation. This method indicates that the client is no longer interested in the
        /// operation result. It does not cancel the operation. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.
        /// </summary>
        /// <param name="name">The name of the operation resource to be deleted.</param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(service, name);
        }

        /// <summary>
        /// Deletes a long-running operation. This method indicates that the client is no longer interested in the
        /// operation result. It does not cancel the operation. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.
        /// </summary>
        public class DeleteRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleProtobufEmpty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>The name of the operation resource to be deleted.</summary>
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
                    Pattern = @"^operations/.*$",
                });
            }
        }

        /// <summary>
        /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation result
        /// at intervals as recommended by the API service.
        /// </summary>
        /// <param name="name">The name of the operation resource.</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>
        /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation result
        /// at intervals as recommended by the API service.
        /// </summary>
        public class GetRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleLongrunningOperation>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>The name of the operation resource.</summary>
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
                    Pattern = @"^operations/.*$",
                });
            }
        }

        /// <summary>
        /// Lists operations that match the specified filter in the request. If the server doesn't support this method,
        /// it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the binding to use
        /// different resource name schemes, such as `users/*/operations`. To override the binding, API services can add
        /// a binding such as `"/v1/{name=users/*}/operations"` to their service configuration. For backwards
        /// compatibility, the default name includes the operations collection id, however overriding users must ensure
        /// the name binding is the parent resource, without the operations collection id.
        /// </summary>
        /// <param name="name">The name of the operation's parent resource.</param>
        public virtual ListRequest List(string name)
        {
            return new ListRequest(service, name);
        }

        /// <summary>
        /// Lists operations that match the specified filter in the request. If the server doesn't support this method,
        /// it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the binding to use
        /// different resource name schemes, such as `users/*/operations`. To override the binding, API services can add
        /// a binding such as `"/v1/{name=users/*}/operations"` to their service configuration. For backwards
        /// compatibility, the default name includes the operations collection id, however overriding users must ensure
        /// the name binding is the parent resource, without the operations collection id.
        /// </summary>
        public class ListRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleLongrunningListOperationsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>The name of the operation's parent resource.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>The standard list filter.</summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>The standard list page size.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>The standard list page token.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^operations$",
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

    /// <summary>The "products" collection of methods.</summary>
    public class ProductsResource
    {
        private const string Resource = "products";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ProductsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Skus = new SkusResource(service);
        }

        /// <summary>Gets the Skus resource.</summary>
        public virtual SkusResource Skus { get; }

        /// <summary>The "skus" collection of methods.</summary>
        public class SkusResource
        {
            private const string Resource = "skus";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SkusResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Lists the SKUs for a product the reseller is authorized to sell. Possible error codes: *
            /// INVALID_ARGUMENT: Required request parameters are missing or invalid.
            /// </summary>
            /// <param name="parent">
            /// Required. The resource name of the Product to list SKUs for. Parent uses the format:
            /// products/{product_id}. Supports products/- to retrieve SKUs for all products.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Lists the SKUs for a product the reseller is authorized to sell. Possible error codes: *
            /// INVALID_ARGUMENT: Required request parameters are missing or invalid.
            /// </summary>
            public class ListRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1ListSkusResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the Product to list SKUs for. Parent uses the format:
                /// products/{product_id}. Supports products/- to retrieve SKUs for all products.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Required. Resource name of the reseller. Format: accounts/{account_id}.</summary>
                [Google.Apis.Util.RequestParameterAttribute("account", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Account { get; set; }

                /// <summary>
                /// Optional. The BCP-47 language code. For example, "en-US". The response will localize in the
                /// corresponding language code, if specified. The default value is "en-US".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string LanguageCode { get; set; }

                /// <summary>
                /// Optional. Requested page size. Server might return fewer results than requested. If unspecified,
                /// returns at most 100 SKUs. The maximum value is 1000; the server will coerce values above 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Optional. A token for a page of results other than the first page. Optional.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/skus";

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
                        Pattern = @"^products/[^/]+$",
                    });
                    RequestParameters.Add("account", new Google.Apis.Discovery.Parameter
                    {
                        Name = "account",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("languageCode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "languageCode",
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

        /// <summary>
        /// Lists the Products the reseller is authorized to sell. Possible error codes: * INVALID_ARGUMENT: Required
        /// request parameters are missing or invalid.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>
        /// Lists the Products the reseller is authorized to sell. Possible error codes: * INVALID_ARGUMENT: Required
        /// request parameters are missing or invalid.
        /// </summary>
        public class ListRequest : CloudchannelBaseServiceRequest<Google.Apis.Cloudchannel.v1.Data.GoogleCloudChannelV1ListProductsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Required. The resource name of the reseller account. Format: accounts/{account_id}.</summary>
            [Google.Apis.Util.RequestParameterAttribute("account", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Account { get; set; }

            /// <summary>
            /// Optional. The BCP-47 language code. For example, "en-US". The response will localize in the
            /// corresponding language code, if specified. The default value is "en-US".
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string LanguageCode { get; set; }

            /// <summary>
            /// Optional. Requested page size. Server might return fewer results than requested. If unspecified, returns
            /// at most 100 Products. The maximum value is 1000; the server will coerce values above 1000.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>Optional. A token for a page of results other than the first page.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/products";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("account", new Google.Apis.Discovery.Parameter
                {
                    Name = "account",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("languageCode", new Google.Apis.Discovery.Parameter
                {
                    Name = "languageCode",
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
}
namespace Google.Apis.Cloudchannel.v1.Data
{
    /// <summary>Request message for CloudChannelService.ActivateEntitlement.</summary>
    public class GoogleCloudChannelV1ActivateEntitlementRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. You can specify an optional unique request ID, and if you need to retry your request, the server
        /// will know to ignore the request if it's complete. For example, you make an initial request and the request
        /// times out. If you make the request again with the same request ID, the server can check if it received the
        /// original operation with the same request ID. If it did, it will ignore the second request. The request ID
        /// must be a valid [UUID](https://tools.ietf.org/html/rfc4122) with the exception that zero UUID is not
        /// supported (`00000000-0000-0000-0000-000000000000`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information needed to create an Admin User for Google Workspace.</summary>
    public class GoogleCloudChannelV1AdminUser : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Primary email of the admin user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>Family name of the admin user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("familyName")]
        public virtual string FamilyName { get; set; }

        /// <summary>Given name of the admin user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("givenName")]
        public virtual string GivenName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Association links that an entitlement has to other entitlements.</summary>
    public class GoogleCloudChannelV1AssociationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the base entitlement, for which this entitlement is an add-on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseEntitlement")]
        public virtual string BaseEntitlement { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for CloudChannelService.CancelEntitlement.</summary>
    public class GoogleCloudChannelV1CancelEntitlementRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. You can specify an optional unique request ID, and if you need to retry your request, the server
        /// will know to ignore the request if it's complete. For example, you make an initial request and the request
        /// times out. If you make the request again with the same request ID, the server can check if it received the
        /// original operation with the same request ID. If it did, it will ignore the second request. The request ID
        /// must be a valid [UUID](https://tools.ietf.org/html/rfc4122) with the exception that zero UUID is not
        /// supported (`00000000-0000-0000-0000-000000000000`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for CloudChannelService.ChangeOffer.</summary>
    public class GoogleCloudChannelV1ChangeOfferRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. New Offer. Format: accounts/{account_id}/offers/{offer_id}.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offer")]
        public virtual string Offer { get; set; }

        /// <summary>Optional. Parameters needed to purchase the Offer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IList<GoogleCloudChannelV1Parameter> Parameters { get; set; }

        /// <summary>Optional. Purchase order id provided by the reseller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purchaseOrderId")]
        public virtual string PurchaseOrderId { get; set; }

        /// <summary>
        /// Optional. You can specify an optional unique request ID, and if you need to retry your request, the server
        /// will know to ignore the request if it's complete. For example, you make an initial request and the request
        /// times out. If you make the request again with the same request ID, the server can check if it received the
        /// original operation with the same request ID. If it did, it will ignore the second request. The request ID
        /// must be a valid [UUID](https://tools.ietf.org/html/rfc4122) with the exception that zero UUID is not
        /// supported (`00000000-0000-0000-0000-000000000000`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for CloudChannelService.ChangeParametersRequest.</summary>
    public class GoogleCloudChannelV1ChangeParametersRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Entitlement parameters to update. You can only change editable parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IList<GoogleCloudChannelV1Parameter> Parameters { get; set; }

        /// <summary>Optional. Purchase order ID provided by the reseller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purchaseOrderId")]
        public virtual string PurchaseOrderId { get; set; }

        /// <summary>
        /// Optional. You can specify an optional unique request ID, and if you need to retry your request, the server
        /// will know to ignore the request if it's complete. For example, you make an initial request and the request
        /// times out. If you make the request again with the same request ID, the server can check if it received the
        /// original operation with the same request ID. If it did, it will ignore the second request. The request ID
        /// must be a valid [UUID](https://tools.ietf.org/html/rfc4122) with the exception that zero UUID is not
        /// supported (`00000000-0000-0000-0000-000000000000`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for CloudChannelService.ChangeRenewalSettings.</summary>
    public class GoogleCloudChannelV1ChangeRenewalSettingsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. New renewal settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("renewalSettings")]
        public virtual GoogleCloudChannelV1RenewalSettings RenewalSettings { get; set; }

        /// <summary>
        /// Optional. You can specify an optional unique request ID, and if you need to retry your request, the server
        /// will know to ignore the request if it's complete. For example, you make an initial request and the request
        /// times out. If you make the request again with the same request ID, the server can check if it received the
        /// original operation with the same request ID. If it did, it will ignore the second request. The request ID
        /// must be a valid [UUID](https://tools.ietf.org/html/rfc4122) with the exception that zero UUID is not
        /// supported (`00000000-0000-0000-0000-000000000000`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Entity representing a link between distributors and their indirect resellers in an n-tier resale channel.
    /// </summary>
    public class GoogleCloudChannelV1ChannelPartnerLink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Cloud Identity info of the channel partner (IR).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelPartnerCloudIdentityInfo")]
        public virtual GoogleCloudChannelV1CloudIdentityInfo ChannelPartnerCloudIdentityInfo { get; set; }

        /// <summary>Output only. Timestamp of when the channel partner link is created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. URI of the web page where partner accepts the link invitation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inviteLinkUri")]
        public virtual string InviteLinkUri { get; set; }

        /// <summary>Required. State of the channel partner link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkState")]
        public virtual string LinkState { get; set; }

        /// <summary>
        /// Output only. Resource name for the channel partner link, in the format
        /// accounts/{account_id}/channelPartnerLinks/{id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Public identifier that a customer must use to generate a transfer token to move to this
        /// distributor-reseller combination.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicId")]
        public virtual string PublicId { get; set; }

        /// <summary>Required. Cloud Identity ID of the linked reseller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resellerCloudIdentityId")]
        public virtual string ResellerCloudIdentityId { get; set; }

        /// <summary>Output only. Timestamp of when the channel partner link is updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for CloudChannelService.CheckCloudIdentityAccountsExist.</summary>
    public class GoogleCloudChannelV1CheckCloudIdentityAccountsExistRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Domain to fetch for Cloud Identity account customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for CloudChannelService.CheckCloudIdentityAccountsExist.</summary>
    public class GoogleCloudChannelV1CheckCloudIdentityAccountsExistResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Cloud Identity accounts associated with the domain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudIdentityAccounts")]
        public virtual System.Collections.Generic.IList<GoogleCloudChannelV1CloudIdentityCustomerAccount> CloudIdentityAccounts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Entity representing a Cloud Identity account that may be associated with a Channel Services API partner.
    /// </summary>
    public class GoogleCloudChannelV1CloudIdentityCustomerAccount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If existing = true, the Cloud Identity ID of the customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerCloudIdentityId")]
        public virtual string CustomerCloudIdentityId { get; set; }

        /// <summary>
        /// If owned = true, the name of the customer that owns the Cloud Identity account. Customer_name uses the
        /// format: accounts/{account_id}/customers/{customer_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerName")]
        public virtual string CustomerName { get; set; }

        /// <summary>Returns true if a Cloud Identity account exists for a specific domain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("existing")]
        public virtual System.Nullable<bool> Existing { get; set; }

        /// <summary>
        /// Returns true if the Cloud Identity account is associated with a customer of the Channel Services partner.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("owned")]
        public virtual System.Nullable<bool> Owned { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Cloud Identity information for the Cloud Channel Customer.</summary>
    public class GoogleCloudChannelV1CloudIdentityInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. URI of Customer's Admin console dashboard.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adminConsoleUri")]
        public virtual string AdminConsoleUri { get; set; }

        /// <summary>The alternate email.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alternateEmail")]
        public virtual string AlternateEmail { get; set; }

        /// <summary>CustomerType indicates verification type needed for using services.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerType")]
        public virtual string CustomerType { get; set; }

        /// <summary>Edu information about the customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eduData")]
        public virtual GoogleCloudChannelV1EduData EduData { get; set; }

        /// <summary>
        /// Output only. Whether the domain is verified. This field is not returned for a Customer's cloud_identity_info
        /// resource. Partners can use the domains.get() method of the Workspace SDK's Directory API, or listen to the
        /// PRIMARY_DOMAIN_VERIFIED Pub/Sub event in to track domain verification of their resolve Workspace customers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isDomainVerified")]
        public virtual System.Nullable<bool> IsDomainVerified { get; set; }

        /// <summary>Language code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>Phone number associated with the Cloud Identity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneNumber")]
        public virtual string PhoneNumber { get; set; }

        /// <summary>Output only. The primary domain name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryDomain")]
        public virtual string PrimaryDomain { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Commitment settings for commitment-based offers.</summary>
    public class GoogleCloudChannelV1CommitmentSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Commitment end timestamp.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>Optional. Renewal settings applicable for a commitment-based Offer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("renewalSettings")]
        public virtual GoogleCloudChannelV1RenewalSettings RenewalSettings { get; set; }

        /// <summary>Output only. Commitment start timestamp.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the constraints for buying the Offer.</summary>
    public class GoogleCloudChannelV1Constraints : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Represents constraints required to purchase the Offer for a customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerConstraints")]
        public virtual GoogleCloudChannelV1CustomerConstraints CustomerConstraints { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contact information for a customer account.</summary>
    public class GoogleCloudChannelV1ContactInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The customer account contact's display name, formatted as a combination of the customer's first
        /// and last name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The customer account's contact email. Required for entitlements that create admin.google.com accounts, and
        /// serves as the customer's username for those accounts. Use this email to invite Team customers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>The customer account contact's first name. Optional for Team customers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstName")]
        public virtual string FirstName { get; set; }

        /// <summary>The customer account contact's last name. Optional for Team customers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastName")]
        public virtual string LastName { get; set; }

        /// <summary>The customer account's contact phone number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phone")]
        public virtual string Phone { get; set; }

        /// <summary>Optional. The customer account contact's job title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for CloudChannelService.CreateEntitlement</summary>
    public class GoogleCloudChannelV1CreateEntitlementRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The entitlement to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entitlement")]
        public virtual GoogleCloudChannelV1Entitlement Entitlement { get; set; }

        /// <summary>
        /// Optional. You can specify an optional unique request ID, and if you need to retry your request, the server
        /// will know to ignore the request if it's complete. For example, you make an initial request and the request
        /// times out. If you make the request again with the same request ID, the server can check if it received the
        /// original operation with the same request ID. If it did, it will ignore the second request. The request ID
        /// must be a valid [UUID](https://tools.ietf.org/html/rfc4122) with the exception that zero UUID is not
        /// supported (`00000000-0000-0000-0000-000000000000`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Entity representing a customer of a reseller or distributor.</summary>
    public class GoogleCloudChannelV1Customer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Secondary contact email. You need to provide an alternate email to create different domains if a primary
        /// contact email already exists. Users will receive a notification with credentials when you create an
        /// admin.google.com account. Secondary emails are also recovery email addresses. Alternate emails are optional
        /// when you create Team customers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alternateEmail")]
        public virtual string AlternateEmail { get; set; }

        /// <summary>
        /// Cloud Identity ID of the customer's channel partner. Populated only if a channel partner exists for this
        /// customer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelPartnerId")]
        public virtual string ChannelPartnerId { get; set; }

        /// <summary>
        /// Output only. The customer's Cloud Identity ID if the customer has a Cloud Identity resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudIdentityId")]
        public virtual string CloudIdentityId { get; set; }

        /// <summary>
        /// Output only. Cloud Identity information for the customer. Populated only if a Cloud Identity account exists
        /// for this customer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudIdentityInfo")]
        public virtual GoogleCloudChannelV1CloudIdentityInfo CloudIdentityInfo { get; set; }

        /// <summary>Output only. Time when the customer was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Required. The customer's primary domain. Must match the primary contact email's domain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>
        /// Optional. The BCP-47 language code, such as "en-US" or "sr-Latn". For more information, see
        /// https://www.unicode.org/reports/tr35/#Unicode_locale_identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// Output only. Resource name of the customer. Format: accounts/{account_id}/customers/{customer_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. Name of the organization that the customer entity represents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgDisplayName")]
        public virtual string OrgDisplayName { get; set; }

        /// <summary>
        /// Required. The organization address for the customer. To enforce US laws and embargoes, we require a region
        /// and zip code. You must provide valid addresses for every customer. To set the customer's language, use the
        /// Customer-level language code.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgPostalAddress")]
        public virtual GoogleTypePostalAddress OrgPostalAddress { get; set; }

        /// <summary>Primary contact info.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryContactInfo")]
        public virtual GoogleCloudChannelV1ContactInfo PrimaryContactInfo { get; set; }

        /// <summary>Output only. Time when the customer was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents constraints required to purchase the Offer for a customer.</summary>
    public class GoogleCloudChannelV1CustomerConstraints : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Allowed Customer Type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedCustomerTypes")]
        public virtual System.Collections.Generic.IList<string> AllowedCustomerTypes { get; set; }

        /// <summary>Allowed geographical regions of the customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedRegions")]
        public virtual System.Collections.Generic.IList<string> AllowedRegions { get; set; }

        /// <summary>Allowed Promotional Order Type. Present for Promotional offers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promotionalOrderTypes")]
        public virtual System.Collections.Generic.IList<string> PromotionalOrderTypes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents Pub/Sub message content describing customer update.</summary>
    public class GoogleCloudChannelV1CustomerEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resource name of the customer. Format: accounts/{account_id}/customers/{customer_id}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customer")]
        public virtual string Customer { get; set; }

        /// <summary>Type of event which happened on the customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventType")]
        public virtual string EventType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Required Edu Attributes</summary>
    public class GoogleCloudChannelV1EduData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Size of the institute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instituteSize")]
        public virtual string InstituteSize { get; set; }

        /// <summary>Designated institute type of customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instituteType")]
        public virtual string InstituteType { get; set; }

        /// <summary>Web address for the edu customer's institution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("website")]
        public virtual string Website { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An entitlement is a representation of a customer's ability to use a service.</summary>
    public class GoogleCloudChannelV1Entitlement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Association information to other entitlements.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("associationInfo")]
        public virtual GoogleCloudChannelV1AssociationInfo AssociationInfo { get; set; }

        /// <summary>Commitment settings for a commitment-based Offer. Required for commitment based offers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commitmentSettings")]
        public virtual GoogleCloudChannelV1CommitmentSettings CommitmentSettings { get; set; }

        /// <summary>Output only. The time at which the entitlement is created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Output only. Resource name of an entitlement in the form:
        /// accounts/{account_id}/customers/{customer_id}/entitlements/{entitlement_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. The offer resource name for which the entitlement is to be created. Takes the form:
        /// accounts/{account_id}/offers/{offer_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offer")]
        public virtual string Offer { get; set; }

        /// <summary>
        /// Extended entitlement parameters. When creating an entitlement, valid parameters' names and values are
        /// defined in the offer's parameter definitions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IList<GoogleCloudChannelV1Parameter> Parameters { get; set; }

        /// <summary>Output only. Service provisioning details for the entitlement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provisionedService")]
        public virtual GoogleCloudChannelV1ProvisionedService ProvisionedService { get; set; }

        /// <summary>Output only. Current provisioning state of the entitlement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provisioningState")]
        public virtual string ProvisioningState { get; set; }

        /// <summary>
        /// Optional. This purchase order (PO) information is for resellers to use for their company tracking usage. If
        /// a purchaseOrderId value is given, it appears in the API responses and shows up in the invoice. The property
        /// accepts up to 80 plain text characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purchaseOrderId")]
        public virtual string PurchaseOrderId { get; set; }

        /// <summary>Output only. Enumerable of all current suspension reasons for an entitlement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suspensionReasons")]
        public virtual System.Collections.Generic.IList<string> SuspensionReasons { get; set; }

        /// <summary>Output only. Settings for trial offers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trialSettings")]
        public virtual GoogleCloudChannelV1TrialSettings TrialSettings { get; set; }

        /// <summary>Output only. The time at which the entitlement is updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents Pub/Sub message content describing entitlement update.</summary>
    public class GoogleCloudChannelV1EntitlementEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Resource name of an entitlement of the form:
        /// accounts/{account_id}/customers/{customer_id}/entitlements/{entitlement_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entitlement")]
        public virtual string Entitlement { get; set; }

        /// <summary>Type of event which happened on the entitlement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventType")]
        public virtual string EventType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for CloudChannelService.ListChannelPartnerLinks.</summary>
    public class GoogleCloudChannelV1ListChannelPartnerLinksResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Channel partner links for a reseller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelPartnerLinks")]
        public virtual System.Collections.Generic.IList<GoogleCloudChannelV1ChannelPartnerLink> ChannelPartnerLinks { get; set; }

        /// <summary>
        /// A token to retrieve the next page of results. Pass to ListChannelPartnerLinksRequest.page_token to obtain
        /// that page.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for CloudChannelService.ListCustomers.</summary>
    public class GoogleCloudChannelV1ListCustomersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The customers belonging to a reseller or distributor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customers")]
        public virtual System.Collections.Generic.IList<GoogleCloudChannelV1Customer> Customers { get; set; }

        /// <summary>
        /// A token to retrieve the next page of results. Pass to ListCustomersRequest.page_token to obtain that page.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for CloudChannelService.ListEntitlements.</summary>
    public class GoogleCloudChannelV1ListEntitlementsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The reseller customer's entitlements.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entitlements")]
        public virtual System.Collections.Generic.IList<GoogleCloudChannelV1Entitlement> Entitlements { get; set; }

        /// <summary>
        /// A token to list the next page of results. Pass to ListEntitlementsRequest.page_token to obtain that page.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListOffers.</summary>
    public class GoogleCloudChannelV1ListOffersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A token to retrieve the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of Offers requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offers")]
        public virtual System.Collections.Generic.IList<GoogleCloudChannelV1Offer> Offers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListProducts.</summary>
    public class GoogleCloudChannelV1ListProductsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A token to retrieve the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of Products requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("products")]
        public virtual System.Collections.Generic.IList<GoogleCloudChannelV1Product> Products { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListPurchasableOffers.</summary>
    public class GoogleCloudChannelV1ListPurchasableOffersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A token to retrieve the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of Offers requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purchasableOffers")]
        public virtual System.Collections.Generic.IList<GoogleCloudChannelV1PurchasableOffer> PurchasableOffers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListPurchasableSkus.</summary>
    public class GoogleCloudChannelV1ListPurchasableSkusResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A token to retrieve the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of SKUs requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purchasableSkus")]
        public virtual System.Collections.Generic.IList<GoogleCloudChannelV1PurchasableSku> PurchasableSkus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListSkus.</summary>
    public class GoogleCloudChannelV1ListSkusResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A token to retrieve the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of SKUs requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skus")]
        public virtual System.Collections.Generic.IList<GoogleCloudChannelV1Sku> Skus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response Message for ListSubscribers.</summary>
    public class GoogleCloudChannelV1ListSubscribersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token that can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of service accounts which have subscriber access to the topic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccounts")]
        public virtual System.Collections.Generic.IList<string> ServiceAccounts { get; set; }

        /// <summary>Name of the topic registered with the reseller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topic")]
        public virtual string Topic { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for CloudChannelService.ListTransferableOffers</summary>
    public class GoogleCloudChannelV1ListTransferableOffersRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Customer's Cloud Identity ID</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudIdentityId")]
        public virtual string CloudIdentityId { get; set; }

        /// <summary>A reseller should create a customer and use the resource name of that customer here.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerName")]
        public virtual string CustomerName { get; set; }

        /// <summary>
        /// The BCP-47 language code. For example, "en-US". The response will localize in the corresponding language
        /// code, if specified. The default value is "en-US".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// Requested page size. Server might return fewer results than requested. If unspecified, returns at most 100
        /// offers. The maximum value is 1000; the server will coerce values above 1000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// A token for a page of results other than the first page. Obtained using
        /// ListTransferableOffersResponse.next_page_token of the previous CloudChannelService.ListTransferableOffers
        /// call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>Required. The SKU to look up Offers for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sku")]
        public virtual string Sku { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for CloudChannelService.ListTransferableOffers.</summary>
    public class GoogleCloudChannelV1ListTransferableOffersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token to retrieve the next page of results. Pass to ListTransferableOffersRequest.page_token to obtain
        /// that page.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Information about Offers for a customer that can be used for transfer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transferableOffers")]
        public virtual System.Collections.Generic.IList<GoogleCloudChannelV1TransferableOffer> TransferableOffers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for CloudChannelService.ListTransferableSkus</summary>
    public class GoogleCloudChannelV1ListTransferableSkusRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The super admin of the resold customer generates this token to authorize a reseller to access their Cloud
        /// Identity and purchase entitlements on their behalf. You can omit this token after authorization. See
        /// https://support.google.com/a/answer/7643790 for more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authToken")]
        public virtual string AuthToken { get; set; }

        /// <summary>Customer's Cloud Identity ID</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudIdentityId")]
        public virtual string CloudIdentityId { get; set; }

        /// <summary>
        /// A reseller is required to create a customer and use the resource name of the created customer here.
        /// Customer_name uses the format: accounts/{account_id}/customers/{customer_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerName")]
        public virtual string CustomerName { get; set; }

        /// <summary>
        /// The BCP-47 language code. For example, "en-US". The response will localize in the corresponding language
        /// code, if specified. The default value is "en-US". Optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// The requested page size. Server might return fewer results than requested. If unspecified, returns at most
        /// 100 SKUs. The maximum value is 1000; the server will coerce values above 1000. Optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// A token for a page of results other than the first page. Obtained using
        /// ListTransferableSkusResponse.next_page_token of the previous CloudChannelService.ListTransferableSkus call.
        /// Optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for CloudChannelService.ListTransferableSkus.</summary>
    public class GoogleCloudChannelV1ListTransferableSkusResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token to retrieve the next page of results. Pass to ListTransferableSkusRequest.page_token to obtain that
        /// page.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Information about existing SKUs for a customer that needs a transfer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transferableSkus")]
        public virtual System.Collections.Generic.IList<GoogleCloudChannelV1TransferableSku> TransferableSkus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the marketing information for a Product, SKU or Offer.</summary>
    public class GoogleCloudChannelV1MarketingInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Default logo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultLogo")]
        public virtual GoogleCloudChannelV1Media DefaultLogo { get; set; }

        /// <summary>Human readable description. Description can contain HTML.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Human readable name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents media information.</summary>
    public class GoogleCloudChannelV1Media : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>URL of the media.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>Title of the media.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>Type of the media.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents an offer made to resellers for purchase. An offer is associated with a Sku, has a plan for payment, a
    /// price, and defines the constraints for buying.
    /// </summary>
    public class GoogleCloudChannelV1Offer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Constraints on transacting the Offer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("constraints")]
        public virtual GoogleCloudChannelV1Constraints Constraints { get; set; }

        /// <summary>Output only. End of the Offer validity time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>Marketing information for the Offer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marketingInfo")]
        public virtual GoogleCloudChannelV1MarketingInfo MarketingInfo { get; set; }

        /// <summary>Resource Name of the Offer. Format: accounts/{account_id}/offers/{offer_id}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Parameters required to use current Offer to purchase.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameterDefinitions")]
        public virtual System.Collections.Generic.IList<GoogleCloudChannelV1ParameterDefinition> ParameterDefinitions { get; set; }

        /// <summary>Describes the payment plan for the Offer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plan")]
        public virtual GoogleCloudChannelV1Plan Plan { get; set; }

        /// <summary>Price for each monetizable resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceByResources")]
        public virtual System.Collections.Generic.IList<GoogleCloudChannelV1PriceByResource> PriceByResources { get; set; }

        /// <summary>SKU the offer is associated with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sku")]
        public virtual GoogleCloudChannelV1Sku Sku { get; set; }

        /// <summary>Start of the Offer validity time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Provides contextual information about a google.longrunning.Operation.</summary>
    public class GoogleCloudChannelV1OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The RPC that initiated this Long Running Operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationType")]
        public virtual string OperationType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Definition for extended entitlement parameters.</summary>
    public class GoogleCloudChannelV1Parameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Specifies whether this parameter is allowed to be changed. For example, for a Google Workspace
        /// Business Starter entitlement in commitment plan, num_units is editable when entitlement is active.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("editable")]
        public virtual System.Nullable<bool> Editable { get; set; }

        /// <summary>Name of the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Value of the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual GoogleCloudChannelV1Value Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Parameter's definition. Specifies what parameter is required to use the current Offer to purchase.
    /// </summary>
    public class GoogleCloudChannelV1ParameterDefinition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If not empty, parameter values must be drawn from this list. For example, [us-west1, us-west2, ...]
        /// Applicable to STRING parameter type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedValues")]
        public virtual System.Collections.Generic.IList<GoogleCloudChannelV1Value> AllowedValues { get; set; }

        /// <summary>
        /// Maximum value of the parameter, if applicable. Inclusive. For example, maximum seats when purchasing Google
        /// Workspace Business Standard. Applicable to INT64 and DOUBLE parameter types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxValue")]
        public virtual GoogleCloudChannelV1Value MaxValue { get; set; }

        /// <summary>
        /// Minimal value of the parameter, if applicable. Inclusive. For example, minimal commitment when purchasing
        /// Anthos is 0.01. Applicable to INT64 and DOUBLE parameter types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minValue")]
        public virtual GoogleCloudChannelV1Value MinValue { get; set; }

        /// <summary>Name of the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>If set to true, parameter is optional to purchase this Offer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optional")]
        public virtual System.Nullable<bool> Optional { get; set; }

        /// <summary>
        /// Data type of the parameter. Minimal value, Maximum value and allowed values will use specified data type
        /// here.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameterType")]
        public virtual string ParameterType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents period in days/months/years.</summary>
    public class GoogleCloudChannelV1Period : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Total duration of Period Type defined.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual System.Nullable<int> Duration { get; set; }

        /// <summary>Period Type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("periodType")]
        public virtual string PeriodType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The payment plan for the Offer. Describes how to make a payment.</summary>
    public class GoogleCloudChannelV1Plan : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Reseller Billing account to charge after an offer transaction. Only present for Google Cloud Platform
        /// offers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billingAccount")]
        public virtual string BillingAccount { get; set; }

        /// <summary>Describes how frequently the reseller will be billed, such as once per month.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paymentCycle")]
        public virtual GoogleCloudChannelV1Period PaymentCycle { get; set; }

        /// <summary>Describes how a reseller will be billed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paymentPlan")]
        public virtual string PaymentPlan { get; set; }

        /// <summary>Specifies when the payment needs to happen.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paymentType")]
        public virtual string PaymentType { get; set; }

        /// <summary>
        /// Present for Offers with a trial period. For trial-only Offers, a paid service needs to start before the
        /// trial period ends for continued service. For Regular Offers with a trial period, the regular pricing goes
        /// into effect when trial period ends, or if paid service is started before the end of the trial period.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trialPeriod")]
        public virtual GoogleCloudChannelV1Period TrialPeriod { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the price of the Offer.</summary>
    public class GoogleCloudChannelV1Price : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Base price.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basePrice")]
        public virtual GoogleTypeMoney BasePrice { get; set; }

        /// <summary>
        /// Discount percentage, represented as decimal. For example, a 20% discount will be represent as 0.2.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discount")]
        public virtual System.Nullable<double> Discount { get; set; }

        /// <summary>Effective Price after applying the discounts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectivePrice")]
        public virtual GoogleTypeMoney EffectivePrice { get; set; }

        /// <summary>Link to external price list, such as link to Google Voice rate card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalPriceUri")]
        public virtual string ExternalPriceUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents price by resource type.</summary>
    public class GoogleCloudChannelV1PriceByResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Price of the Offer. Present if there are no price phases.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("price")]
        public virtual GoogleCloudChannelV1Price Price { get; set; }

        /// <summary>Specifies the price by time range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pricePhases")]
        public virtual System.Collections.Generic.IList<GoogleCloudChannelV1PricePhase> PricePhases { get; set; }

        /// <summary>Resource Type. Example: SEAT</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies the price by the duration of months. For example, a 20% discount for the first six months, then a 10%
    /// discount starting on the seventh month.
    /// </summary>
    public class GoogleCloudChannelV1PricePhase : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Defines first period for the phase.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstPeriod")]
        public virtual System.Nullable<int> FirstPeriod { get; set; }

        /// <summary>Defines first period for the phase.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastPeriod")]
        public virtual System.Nullable<int> LastPeriod { get; set; }

        /// <summary>Defines the phase period type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("periodType")]
        public virtual string PeriodType { get; set; }

        /// <summary>Price of the phase. Present if there are no price tiers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("price")]
        public virtual GoogleCloudChannelV1Price Price { get; set; }

        /// <summary>Price by the resource tiers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceTiers")]
        public virtual System.Collections.Generic.IList<GoogleCloudChannelV1PriceTier> PriceTiers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines price at resource tier level. For example, an offer with following definition : * Tier 1: Provide 25%
    /// discount for all seats between 1 and 25. * Tier 2: Provide 10% discount for all seats between 26 and 100. * Tier
    /// 3: Provide flat 15% discount for all seats above 100. Each of these tiers is represented as a PriceTier.
    /// </summary>
    public class GoogleCloudChannelV1PriceTier : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>First resource for which the tier price applies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstResource")]
        public virtual System.Nullable<int> FirstResource { get; set; }

        /// <summary>Last resource for which the tier price applies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastResource")]
        public virtual System.Nullable<int> LastResource { get; set; }

        /// <summary>Price of the tier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("price")]
        public virtual GoogleCloudChannelV1Price Price { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Product is the entity a customer uses when placing an order. For example, Google Workspace, Google Voice, etc.
    /// </summary>
    public class GoogleCloudChannelV1Product : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Marketing information for the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marketingInfo")]
        public virtual GoogleCloudChannelV1MarketingInfo MarketingInfo { get; set; }

        /// <summary>Resource Name of the Product. Format: products/{product_id}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for CloudChannelService.ProvisionCloudIdentity</summary>
    public class GoogleCloudChannelV1ProvisionCloudIdentityRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>CloudIdentity-specific customer information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudIdentityInfo")]
        public virtual GoogleCloudChannelV1CloudIdentityInfo CloudIdentityInfo { get; set; }

        /// <summary>Admin user information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual GoogleCloudChannelV1AdminUser User { get; set; }

        /// <summary>Validate the request and preview the review, but do not post it.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Service provisioned for an entitlement.</summary>
    public class GoogleCloudChannelV1ProvisionedService : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The product pertaining to the provisioning resource as specified in the Offer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; }

        /// <summary>
        /// Output only. Provisioning ID of the entitlement. For Google Workspace, this would be the underlying
        /// Subscription ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provisioningId")]
        public virtual string ProvisioningId { get; set; }

        /// <summary>Output only. The SKU pertaining to the provisioning resource as specified in the Offer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skuId")]
        public virtual string SkuId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Offer that you can purchase for a customer. This is used in the ListPurchasableOffer API response.
    /// </summary>
    public class GoogleCloudChannelV1PurchasableOffer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Offer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offer")]
        public virtual GoogleCloudChannelV1Offer Offer { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SKU that you can purchase. This is used in ListPurchasableSku API response.</summary>
    public class GoogleCloudChannelV1PurchasableSku : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>SKU</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sku")]
        public virtual GoogleCloudChannelV1Sku Sku { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request Message for RegisterSubscriber.</summary>
    public class GoogleCloudChannelV1RegisterSubscriberRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Service account that provides subscriber access to the registered topic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response Message for RegisterSubscriber.</summary>
    public class GoogleCloudChannelV1RegisterSubscriberResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the topic the subscriber will listen to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topic")]
        public virtual string Topic { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Renewal settings for renewable Offers.</summary>
    public class GoogleCloudChannelV1RenewalSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If false, the plan will be completed at the end date.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableRenewal")]
        public virtual System.Nullable<bool> EnableRenewal { get; set; }

        /// <summary>Describes how frequently the reseller will be billed, such as once per month.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paymentCycle")]
        public virtual GoogleCloudChannelV1Period PaymentCycle { get; set; }

        /// <summary>Describes how a reseller will be billed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paymentPlan")]
        public virtual string PaymentPlan { get; set; }

        /// <summary>
        /// If true and enable_renewal = true, the unit (for example seats or licenses) will be set to the number of
        /// active units at renewal time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resizeUnitCount")]
        public virtual System.Nullable<bool> ResizeUnitCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a product's purchasable Stock Keeping Unit (SKU). SKUs represent the different variations of the
    /// product. For example, Google Workspace Business Standard and Google Workspace Business Plus are Google Workspace
    /// product SKUs.
    /// </summary>
    public class GoogleCloudChannelV1Sku : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Marketing information for the SKU.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marketingInfo")]
        public virtual GoogleCloudChannelV1MarketingInfo MarketingInfo { get; set; }

        /// <summary>Resource Name of the SKU. Format: products/{product_id}/skus/{sku_id}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Product the SKU is associated with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("product")]
        public virtual GoogleCloudChannelV1Product Product { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for CloudChannelService.StartPaidService.</summary>
    public class GoogleCloudChannelV1StartPaidServiceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. You can specify an optional unique request ID, and if you need to retry your request, the server
        /// will know to ignore the request if it's complete. For example, you make an initial request and the request
        /// times out. If you make the request again with the same request ID, the server can check if it received the
        /// original operation with the same request ID. If it did, it will ignore the second request. The request ID
        /// must be a valid [UUID](https://tools.ietf.org/html/rfc4122) with the exception that zero UUID is not
        /// supported (`00000000-0000-0000-0000-000000000000`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents information which resellers will get as part of notification from Cloud Pub/Sub.</summary>
    public class GoogleCloudChannelV1SubscriberEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Customer event send as part of Pub/Sub event to partners.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerEvent")]
        public virtual GoogleCloudChannelV1CustomerEvent CustomerEvent { get; set; }

        /// <summary>Entitlement event send as part of Pub/Sub event to partners.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entitlementEvent")]
        public virtual GoogleCloudChannelV1EntitlementEvent EntitlementEvent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for CloudChannelService.SuspendEntitlement.</summary>
    public class GoogleCloudChannelV1SuspendEntitlementRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. You can specify an optional unique request ID, and if you need to retry your request, the server
        /// will know to ignore the request if it's complete. For example, you make an initial request and the request
        /// times out. If you make the request again with the same request ID, the server can check if it received the
        /// original operation with the same request ID. If it did, it will ignore the second request. The request ID
        /// must be a valid [UUID](https://tools.ietf.org/html/rfc4122) with the exception that zero UUID is not
        /// supported (`00000000-0000-0000-0000-000000000000`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies transfer eligibility of a SKU.</summary>
    public class GoogleCloudChannelV1TransferEligibility : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Localized description if reseller is not eligible to transfer the SKU.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Specified the reason for ineligibility.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ineligibilityReason")]
        public virtual string IneligibilityReason { get; set; }

        /// <summary>Whether reseller is eligible to transfer the SKU.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isEligible")]
        public virtual System.Nullable<bool> IsEligible { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for CloudChannelService.TransferEntitlements.</summary>
    public class GoogleCloudChannelV1TransferEntitlementsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The super admin of the resold customer generates this token to authorize a reseller to access their Cloud
        /// Identity and purchase entitlements on their behalf. You can omit this token after authorization. See
        /// https://support.google.com/a/answer/7643790 for more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authToken")]
        public virtual string AuthToken { get; set; }

        /// <summary>Required. The new entitlements to create or transfer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entitlements")]
        public virtual System.Collections.Generic.IList<GoogleCloudChannelV1Entitlement> Entitlements { get; set; }

        /// <summary>
        /// Optional. You can specify an optional unique request ID, and if you need to retry your request, the server
        /// will know to ignore the request if it's complete. For example, you make an initial request and the request
        /// times out. If you make the request again with the same request ID, the server can check if it received the
        /// original operation with the same request ID. If it did, it will ignore the second request. The request ID
        /// must be a valid [UUID](https://tools.ietf.org/html/rfc4122) with the exception that zero UUID is not
        /// supported (`00000000-0000-0000-0000-000000000000`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response message for CloudChannelService.TransferEntitlements. This is put in the response field of
    /// google.longrunning.Operation.
    /// </summary>
    public class GoogleCloudChannelV1TransferEntitlementsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The transferred entitlements.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entitlements")]
        public virtual System.Collections.Generic.IList<GoogleCloudChannelV1Entitlement> Entitlements { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for CloudChannelService.TransferEntitlementsToGoogle.</summary>
    public class GoogleCloudChannelV1TransferEntitlementsToGoogleRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The entitlements to transfer to Google.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entitlements")]
        public virtual System.Collections.Generic.IList<GoogleCloudChannelV1Entitlement> Entitlements { get; set; }

        /// <summary>
        /// Optional. You can specify an optional unique request ID, and if you need to retry your request, the server
        /// will know to ignore the request if it's complete. For example, you make an initial request and the request
        /// times out. If you make the request again with the same request ID, the server can check if it received the
        /// original operation with the same request ID. If it did, it will ignore the second request. The request ID
        /// must be a valid [UUID](https://tools.ietf.org/html/rfc4122) with the exception that zero UUID is not
        /// supported (`00000000-0000-0000-0000-000000000000`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>TransferableOffer represents an Offer that can be used in Transfer. Read-only.</summary>
    public class GoogleCloudChannelV1TransferableOffer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Offer with parameter constraints updated to allow the Transfer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offer")]
        public virtual GoogleCloudChannelV1Offer Offer { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// TransferableSku represents information a reseller needs to view existing provisioned services for a customer
    /// that they do not own. Read-only.
    /// </summary>
    public class GoogleCloudChannelV1TransferableSku : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The customer to transfer has an entitlement with the populated legacy SKU.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("legacySku")]
        public virtual GoogleCloudChannelV1Sku LegacySku { get; set; }

        /// <summary>The SKU pertaining to the provisioning resource as specified in the Offer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sku")]
        public virtual GoogleCloudChannelV1Sku Sku { get; set; }

        /// <summary>Describes the transfer eligibility of a SKU.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transferEligibility")]
        public virtual GoogleCloudChannelV1TransferEligibility TransferEligibility { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings for trial offers.</summary>
    public class GoogleCloudChannelV1TrialSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Date when the trial ends. The value is in milliseconds using the UNIX Epoch format. See an example [Epoch
        /// converter](https://www.epochconverter.com).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>
        /// Determines if the entitlement is in a trial or not: * `true` - The entitlement is in trial. * `false` - The
        /// entitlement is not in trial.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trial")]
        public virtual System.Nullable<bool> Trial { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request Message for UnregisterSubscriber.</summary>
    public class GoogleCloudChannelV1UnregisterSubscriberRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Service account to unregister from subscriber access to the topic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response Message for UnregisterSubscriber.</summary>
    public class GoogleCloudChannelV1UnregisterSubscriberResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the topic the service account subscriber access was removed from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topic")]
        public virtual string Topic { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for CloudChannelService.UpdateChannelPartnerLink</summary>
    public class GoogleCloudChannelV1UpdateChannelPartnerLinkRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The channel partner link to update. Only channel_partner_link.link_state is allowed for updates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelPartnerLink")]
        public virtual GoogleCloudChannelV1ChannelPartnerLink ChannelPartnerLink { get; set; }

        /// <summary>
        /// Required. The update mask that applies to the resource. The only allowable value for an update mask is
        /// channel_partner_link.link_state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data type and value of a parameter.</summary>
    public class GoogleCloudChannelV1Value : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Represents a boolean value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boolValue")]
        public virtual System.Nullable<bool> BoolValue { get; set; }

        /// <summary>Represents a double value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doubleValue")]
        public virtual System.Nullable<double> DoubleValue { get; set; }

        /// <summary>Represents an int64 value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("int64Value")]
        public virtual System.Nullable<long> Int64Value { get; set; }

        /// <summary>Represents an 'Any' proto value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protoValue")]
        public virtual System.Collections.Generic.IDictionary<string, object> ProtoValue { get; set; }

        /// <summary>Represents a string value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Association links that an entitlement has to other entitlements.</summary>
    public class GoogleCloudChannelV1alpha1AssociationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the base entitlement, for which this entitlement is an add-on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseEntitlement")]
        public virtual string BaseEntitlement { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Commitment settings for commitment-based offers.</summary>
    public class GoogleCloudChannelV1alpha1CommitmentSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Commitment end timestamp.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>Optional. Renewal settings applicable for a commitment-based Offer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("renewalSettings")]
        public virtual GoogleCloudChannelV1alpha1RenewalSettings RenewalSettings { get; set; }

        /// <summary>Output only. Commitment start timestamp.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents Pub/Sub message content describing customer update.</summary>
    public class GoogleCloudChannelV1alpha1CustomerEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resource name of the customer. Format: accounts/{account_id}/customers/{customer_id}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customer")]
        public virtual string Customer { get; set; }

        /// <summary>Type of event which happened on the customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventType")]
        public virtual string EventType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An entitlement is a representation of a customer's ability to use a service.</summary>
    public class GoogleCloudChannelV1alpha1Entitlement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The current number of users that are assigned a license for the product defined in
        /// provisioned_service.skuId. Read-only. Deprecated: Use `parameters` instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignedUnits")]
        public virtual System.Nullable<int> AssignedUnits { get; set; }

        /// <summary>Association information to other entitlements.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("associationInfo")]
        public virtual GoogleCloudChannelV1alpha1AssociationInfo AssociationInfo { get; set; }

        /// <summary>
        /// Cloud Identity ID of a channel partner who will be the direct reseller for the customer's order. This field
        /// is generally used in 2-tier ordering, where the order is placed by a top-level distributor on behalf of
        /// their channel partner or reseller. Required for distributors. Deprecated: `channel_partner_id` has been
        /// moved to the Customer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelPartnerId")]
        public virtual string ChannelPartnerId { get; set; }

        /// <summary>Commitment settings for a commitment-based Offer. Required for commitment based offers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commitmentSettings")]
        public virtual GoogleCloudChannelV1alpha1CommitmentSettings CommitmentSettings { get; set; }

        /// <summary>Output only. The time at which the entitlement is created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Maximum number of units for a non commitment-based Offer, such as Flexible, Trial or Free entitlements. For
        /// commitment-based entitlements, this is a read-only field, which only the internal support team can update.
        /// Deprecated: Use `parameters` instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxUnits")]
        public virtual System.Nullable<int> MaxUnits { get; set; }

        /// <summary>
        /// Output only. Resource name of an entitlement in the form:
        /// accounts/{account_id}/customers/{customer_id}/entitlements/{entitlement_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Number of units for a commitment-based Offer. For example, for seat-based Offers, this would be the number
        /// of seats; for license-based Offers, this would be the number of licenses. Required for creating
        /// commitment-based Offers. Deprecated: Use `parameters` instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numUnits")]
        public virtual System.Nullable<int> NumUnits { get; set; }

        /// <summary>
        /// Required. The offer resource name for which the entitlement is to be created. Takes the form:
        /// accounts/{account_id}/offers/{offer_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offer")]
        public virtual string Offer { get; set; }

        /// <summary>
        /// Extended entitlement parameters. When creating an entitlement, valid parameters' names and values are
        /// defined in the offer's parameter definitions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IList<GoogleCloudChannelV1alpha1Parameter> Parameters { get; set; }

        /// <summary>Output only. Service provisioning details for the entitlement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provisionedService")]
        public virtual GoogleCloudChannelV1alpha1ProvisionedService ProvisionedService { get; set; }

        /// <summary>Output only. Current provisioning state of the entitlement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provisioningState")]
        public virtual string ProvisioningState { get; set; }

        /// <summary>
        /// Optional. This purchase order (PO) information is for resellers to use for their company tracking usage. If
        /// a purchaseOrderId value is given, it appears in the API responses and shows up in the invoice. The property
        /// accepts up to 80 plain text characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purchaseOrderId")]
        public virtual string PurchaseOrderId { get; set; }

        /// <summary>Output only. Enumerable of all current suspension reasons for an entitlement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suspensionReasons")]
        public virtual System.Collections.Generic.IList<string> SuspensionReasons { get; set; }

        /// <summary>Output only. Settings for trial offers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trialSettings")]
        public virtual GoogleCloudChannelV1alpha1TrialSettings TrialSettings { get; set; }

        /// <summary>Output only. The time at which the entitlement is updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents Pub/Sub message content describing entitlement update.</summary>
    public class GoogleCloudChannelV1alpha1EntitlementEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Resource name of an entitlement of the form:
        /// accounts/{account_id}/customers/{customer_id}/entitlements/{entitlement_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entitlement")]
        public virtual string Entitlement { get; set; }

        /// <summary>Type of event which happened on the entitlement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventType")]
        public virtual string EventType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Provides contextual information about a google.longrunning.Operation.</summary>
    public class GoogleCloudChannelV1alpha1OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The RPC that initiated this Long Running Operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationType")]
        public virtual string OperationType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Definition for extended entitlement parameters.</summary>
    public class GoogleCloudChannelV1alpha1Parameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Specifies whether this parameter is allowed to be changed. For example, for a Google Workspace
        /// Business Starter entitlement in commitment plan, num_units is editable when entitlement is active.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("editable")]
        public virtual System.Nullable<bool> Editable { get; set; }

        /// <summary>Name of the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Value of the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual GoogleCloudChannelV1alpha1Value Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents period in days/months/years.</summary>
    public class GoogleCloudChannelV1alpha1Period : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Total duration of Period Type defined.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual System.Nullable<int> Duration { get; set; }

        /// <summary>Period Type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("periodType")]
        public virtual string PeriodType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Service provisioned for an entitlement.</summary>
    public class GoogleCloudChannelV1alpha1ProvisionedService : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The product pertaining to the provisioning resource as specified in the Offer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; }

        /// <summary>
        /// Output only. Provisioning ID of the entitlement. For Google Workspace, this would be the underlying
        /// Subscription ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provisioningId")]
        public virtual string ProvisioningId { get; set; }

        /// <summary>Output only. The SKU pertaining to the provisioning resource as specified in the Offer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skuId")]
        public virtual string SkuId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Renewal settings for renewable Offers.</summary>
    public class GoogleCloudChannelV1alpha1RenewalSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If true, disables commitment-based offer on renewal and switches to flexible or pay as you go. Deprecated:
        /// Use `payment_plan` instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableCommitment")]
        public virtual System.Nullable<bool> DisableCommitment { get; set; }

        /// <summary>If false, the plan will be completed at the end date.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableRenewal")]
        public virtual System.Nullable<bool> EnableRenewal { get; set; }

        /// <summary>Describes how frequently the reseller will be billed, such as once per month.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paymentCycle")]
        public virtual GoogleCloudChannelV1alpha1Period PaymentCycle { get; set; }

        /// <summary>Set if enable_renewal=true. Deprecated: Use `payment_cycle` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paymentOption")]
        public virtual string PaymentOption { get; set; }

        /// <summary>Describes how a reseller will be billed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paymentPlan")]
        public virtual string PaymentPlan { get; set; }

        /// <summary>
        /// If true and enable_renewal = true, the unit (for example seats or licenses) will be set to the number of
        /// active units at renewal time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resizeUnitCount")]
        public virtual System.Nullable<bool> ResizeUnitCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents information which resellers will get as part of notification from Cloud Pub/Sub.</summary>
    public class GoogleCloudChannelV1alpha1SubscriberEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Customer event send as part of Pub/Sub event to partners.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerEvent")]
        public virtual GoogleCloudChannelV1alpha1CustomerEvent CustomerEvent { get; set; }

        /// <summary>Entitlement event send as part of Pub/Sub event to partners.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entitlementEvent")]
        public virtual GoogleCloudChannelV1alpha1EntitlementEvent EntitlementEvent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response message for CloudChannelService.TransferEntitlements. This is put in the response field of
    /// google.longrunning.Operation.
    /// </summary>
    public class GoogleCloudChannelV1alpha1TransferEntitlementsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The transferred entitlements.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entitlements")]
        public virtual System.Collections.Generic.IList<GoogleCloudChannelV1alpha1Entitlement> Entitlements { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings for trial offers.</summary>
    public class GoogleCloudChannelV1alpha1TrialSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Date when the trial ends. The value is in milliseconds using the UNIX Epoch format. See an example [Epoch
        /// converter](https://www.epochconverter.com).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>
        /// Determines if the entitlement is in a trial or not: * `true` - The entitlement is in trial. * `false` - The
        /// entitlement is not in trial.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trial")]
        public virtual System.Nullable<bool> Trial { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data type and value of a parameter.</summary>
    public class GoogleCloudChannelV1alpha1Value : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Represents a boolean value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boolValue")]
        public virtual System.Nullable<bool> BoolValue { get; set; }

        /// <summary>Represents a double value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doubleValue")]
        public virtual System.Nullable<double> DoubleValue { get; set; }

        /// <summary>Represents an int64 value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("int64Value")]
        public virtual System.Nullable<long> Int64Value { get; set; }

        /// <summary>Represents an 'Any' proto value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protoValue")]
        public virtual System.Collections.Generic.IDictionary<string, object> ProtoValue { get; set; }

        /// <summary>Represents a string value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class GoogleLongrunningCancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for Operations.ListOperations.</summary>
    public class GoogleLongrunningListOperationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The standard List next-page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of operations that matches the specified filter in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<GoogleLongrunningOperation> Operations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This resource represents a long-running operation that is the result of a network API call.</summary>
    public class GoogleLongrunningOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the value is `false`, it means the operation is still in progress. If `true`, the operation is completed,
        /// and either `error` or `response` is available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("done")]
        public virtual System.Nullable<bool> Done { get; set; }

        /// <summary>The error result of the operation in case of failure or cancellation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual GoogleRpcStatus Error { get; set; }

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

    /// <summary>
    /// The `Status` type defines a logical error model that is suitable for different programming environments,
    /// including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status` message contains
    /// three pieces of data: error code, error message, and error details. You can find out more about this error model
    /// and how to work with it in the [API Design Guide](https://cloud.google.com/apis/design/errors).
    /// </summary>
    public class GoogleRpcStatus : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Represents an amount of money with its currency type.</summary>
    public class GoogleTypeMoney : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The three-letter currency code defined in ISO 4217.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>
        /// Number of nano (10^-9) units of the amount. The value must be between -999,999,999 and +999,999,999
        /// inclusive. If `units` is positive, `nanos` must be positive or zero. If `units` is zero, `nanos` can be
        /// positive, zero, or negative. If `units` is negative, `nanos` must be negative or zero. For example $-1.75 is
        /// represented as `units`=-1 and `nanos`=-750,000,000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>
        /// The whole units of the amount. For example if `currencyCode` is `"USD"`, then 1 unit is one US dollar.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("units")]
        public virtual System.Nullable<long> Units { get; set; }

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
    public class GoogleTypePostalAddress : Google.Apis.Requests.IDirectResponseSchema
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
}
