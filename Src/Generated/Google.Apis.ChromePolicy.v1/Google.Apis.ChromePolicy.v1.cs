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

namespace Google.Apis.ChromePolicy.v1
{
    /// <summary>The ChromePolicy Service.</summary>
    public class ChromePolicyService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public ChromePolicyService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public ChromePolicyService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Customers = new CustomersResource(this);
            Media = new MediaResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "chromepolicy";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri => BaseUriOverride ?? "https://chromepolicy.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://chromepolicy.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Chrome Policy API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, create or delete policies applied to Chrome OS and Chrome Browsers managed within your
            /// organization
            /// </summary>
            public static string ChromeManagementPolicy = "https://www.googleapis.com/auth/chrome.management.policy";

            /// <summary>
            /// See policies applied to Chrome OS and Chrome Browsers managed within your organization
            /// </summary>
            public static string ChromeManagementPolicyReadonly = "https://www.googleapis.com/auth/chrome.management.policy.readonly";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Chrome Policy API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, create or delete policies applied to Chrome OS and Chrome Browsers managed within your
            /// organization
            /// </summary>
            public const string ChromeManagementPolicy = "https://www.googleapis.com/auth/chrome.management.policy";

            /// <summary>
            /// See policies applied to Chrome OS and Chrome Browsers managed within your organization
            /// </summary>
            public const string ChromeManagementPolicyReadonly = "https://www.googleapis.com/auth/chrome.management.policy.readonly";
        }

        /// <summary>Gets the Customers resource.</summary>
        public virtual CustomersResource Customers { get; }

        /// <summary>Gets the Media resource.</summary>
        public virtual MediaResource Media { get; }
    }

    /// <summary>A base abstract class for ChromePolicy requests.</summary>
    public abstract class ChromePolicyBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new ChromePolicyBaseServiceRequest instance.</summary>
        protected ChromePolicyBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes ChromePolicy parameter list.</summary>
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
            Policies = new PoliciesResource(service);
            PolicySchemas = new PolicySchemasResource(service);
        }

        /// <summary>Gets the Policies resource.</summary>
        public virtual PoliciesResource Policies { get; }

        /// <summary>The "policies" collection of methods.</summary>
        public class PoliciesResource
        {
            private const string Resource = "policies";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public PoliciesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Groups = new GroupsResource(service);
                Networks = new NetworksResource(service);
                Orgunits = new OrgunitsResource(service);
            }

            /// <summary>Gets the Groups resource.</summary>
            public virtual GroupsResource Groups { get; }

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
                }

                /// <summary>
                /// Delete multiple policy values that are applied to a specific group. All targets must have the same
                /// target format. That is to say that they must point to the same target resource and must have the
                /// same keys specified in `additionalTargetKeyNames`, though the values for those keys may be
                /// different. On failure the request will return the error details as part of the google.rpc.Status.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="customer">
                /// ID of the Google Workspace account or literal "my_customer" for the customer associated to the
                /// request.
                /// </param>
                public virtual BatchDeleteRequest BatchDelete(Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1BatchDeleteGroupPoliciesRequest body, string customer)
                {
                    return new BatchDeleteRequest(service, body, customer);
                }

                /// <summary>
                /// Delete multiple policy values that are applied to a specific group. All targets must have the same
                /// target format. That is to say that they must point to the same target resource and must have the
                /// same keys specified in `additionalTargetKeyNames`, though the values for those keys may be
                /// different. On failure the request will return the error details as part of the google.rpc.Status.
                /// </summary>
                public class BatchDeleteRequest : ChromePolicyBaseServiceRequest<Google.Apis.ChromePolicy.v1.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new BatchDelete request.</summary>
                    public BatchDeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1BatchDeleteGroupPoliciesRequest body, string customer) : base(service)
                    {
                        Customer = customer;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// ID of the Google Workspace account or literal "my_customer" for the customer associated to the
                    /// request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Customer { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1BatchDeleteGroupPoliciesRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "batchDelete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+customer}/policies/groups:batchDelete";

                    /// <summary>Initializes BatchDelete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                        {
                            Name = "customer",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^customers/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Modify multiple policy values that are applied to a specific group. All targets must have the same
                /// target format. That is to say that they must point to the same target resource and must have the
                /// same keys specified in `additionalTargetKeyNames`, though the values for those keys may be
                /// different. On failure the request will return the error details as part of the google.rpc.Status.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="customer">
                /// ID of the Google Workspace account or literal "my_customer" for the customer associated to the
                /// request.
                /// </param>
                public virtual BatchModifyRequest BatchModify(Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1BatchModifyGroupPoliciesRequest body, string customer)
                {
                    return new BatchModifyRequest(service, body, customer);
                }

                /// <summary>
                /// Modify multiple policy values that are applied to a specific group. All targets must have the same
                /// target format. That is to say that they must point to the same target resource and must have the
                /// same keys specified in `additionalTargetKeyNames`, though the values for those keys may be
                /// different. On failure the request will return the error details as part of the google.rpc.Status.
                /// </summary>
                public class BatchModifyRequest : ChromePolicyBaseServiceRequest<Google.Apis.ChromePolicy.v1.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new BatchModify request.</summary>
                    public BatchModifyRequest(Google.Apis.Services.IClientService service, Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1BatchModifyGroupPoliciesRequest body, string customer) : base(service)
                    {
                        Customer = customer;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// ID of the Google Workspace account or literal "my_customer" for the customer associated to the
                    /// request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Customer { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1BatchModifyGroupPoliciesRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "batchModify";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+customer}/policies/groups:batchModify";

                    /// <summary>Initializes BatchModify parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                        {
                            Name = "customer",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^customers/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Retrieve a group priority ordering for an app. The target app must be supplied in
                /// `additionalTargetKeyNames` in the PolicyTargetKey. On failure the request will return the error
                /// details as part of the google.rpc.Status.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="customer">
                /// Required. ID of the Google Workspace account or literal "my_customer" for the customer associated to
                /// the request.
                /// </param>
                public virtual ListGroupPriorityOrderingRequest ListGroupPriorityOrdering(Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1ListGroupPriorityOrderingRequest body, string customer)
                {
                    return new ListGroupPriorityOrderingRequest(service, body, customer);
                }

                /// <summary>
                /// Retrieve a group priority ordering for an app. The target app must be supplied in
                /// `additionalTargetKeyNames` in the PolicyTargetKey. On failure the request will return the error
                /// details as part of the google.rpc.Status.
                /// </summary>
                public class ListGroupPriorityOrderingRequest : ChromePolicyBaseServiceRequest<Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1ListGroupPriorityOrderingResponse>
                {
                    /// <summary>Constructs a new ListGroupPriorityOrdering request.</summary>
                    public ListGroupPriorityOrderingRequest(Google.Apis.Services.IClientService service, Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1ListGroupPriorityOrderingRequest body, string customer) : base(service)
                    {
                        Customer = customer;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. ID of the Google Workspace account or literal "my_customer" for the customer
                    /// associated to the request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Customer { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1ListGroupPriorityOrderingRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "listGroupPriorityOrdering";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+customer}/policies/groups:listGroupPriorityOrdering";

                    /// <summary>Initializes ListGroupPriorityOrdering parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                        {
                            Name = "customer",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^customers/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Update a group priority ordering for an app. The target app must be supplied in
                /// `additionalTargetKeyNames` in the PolicyTargetKey. On failure the request will return the error
                /// details as part of the google.rpc.Status.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="customer">
                /// Required. ID of the Google Workspace account or literal "my_customer" for the customer associated to
                /// the request.
                /// </param>
                public virtual UpdateGroupPriorityOrderingRequest UpdateGroupPriorityOrdering(Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1UpdateGroupPriorityOrderingRequest body, string customer)
                {
                    return new UpdateGroupPriorityOrderingRequest(service, body, customer);
                }

                /// <summary>
                /// Update a group priority ordering for an app. The target app must be supplied in
                /// `additionalTargetKeyNames` in the PolicyTargetKey. On failure the request will return the error
                /// details as part of the google.rpc.Status.
                /// </summary>
                public class UpdateGroupPriorityOrderingRequest : ChromePolicyBaseServiceRequest<Google.Apis.ChromePolicy.v1.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new UpdateGroupPriorityOrdering request.</summary>
                    public UpdateGroupPriorityOrderingRequest(Google.Apis.Services.IClientService service, Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1UpdateGroupPriorityOrderingRequest body, string customer) : base(service)
                    {
                        Customer = customer;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. ID of the Google Workspace account or literal "my_customer" for the customer
                    /// associated to the request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Customer { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1UpdateGroupPriorityOrderingRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "updateGroupPriorityOrdering";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+customer}/policies/groups:updateGroupPriorityOrdering";

                    /// <summary>Initializes UpdateGroupPriorityOrdering parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                        {
                            Name = "customer",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^customers/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the Networks resource.</summary>
            public virtual NetworksResource Networks { get; }

            /// <summary>The "networks" collection of methods.</summary>
            public class NetworksResource
            {
                private const string Resource = "networks";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public NetworksResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a certificate at a specified OU for a customer.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="customer">Required. The customer for which the certificate will apply.</param>
                public virtual DefineCertificateRequest DefineCertificate(Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1DefineCertificateRequest body, string customer)
                {
                    return new DefineCertificateRequest(service, body, customer);
                }

                /// <summary>Creates a certificate at a specified OU for a customer.</summary>
                public class DefineCertificateRequest : ChromePolicyBaseServiceRequest<Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1DefineCertificateResponse>
                {
                    /// <summary>Constructs a new DefineCertificate request.</summary>
                    public DefineCertificateRequest(Google.Apis.Services.IClientService service, Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1DefineCertificateRequest body, string customer) : base(service)
                    {
                        Customer = customer;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The customer for which the certificate will apply.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Customer { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1DefineCertificateRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "defineCertificate";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+customer}/policies/networks:defineCertificate";

                    /// <summary>Initializes DefineCertificate parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                        {
                            Name = "customer",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^customers/[^/]+$",
                        });
                    }
                }

                /// <summary>Define a new network.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="customer">Required. The customer who will own this new network.</param>
                public virtual DefineNetworkRequest DefineNetwork(Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1DefineNetworkRequest body, string customer)
                {
                    return new DefineNetworkRequest(service, body, customer);
                }

                /// <summary>Define a new network.</summary>
                public class DefineNetworkRequest : ChromePolicyBaseServiceRequest<Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1DefineNetworkResponse>
                {
                    /// <summary>Constructs a new DefineNetwork request.</summary>
                    public DefineNetworkRequest(Google.Apis.Services.IClientService service, Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1DefineNetworkRequest body, string customer) : base(service)
                    {
                        Customer = customer;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The customer who will own this new network.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Customer { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1DefineNetworkRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "defineNetwork";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+customer}/policies/networks:defineNetwork";

                    /// <summary>Initializes DefineNetwork parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                        {
                            Name = "customer",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^customers/[^/]+$",
                        });
                    }
                }

                /// <summary>Remove an existing certificate by guid.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="customer">Required. The customer whose certificate will be removed.</param>
                public virtual RemoveCertificateRequest RemoveCertificate(Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1RemoveCertificateRequest body, string customer)
                {
                    return new RemoveCertificateRequest(service, body, customer);
                }

                /// <summary>Remove an existing certificate by guid.</summary>
                public class RemoveCertificateRequest : ChromePolicyBaseServiceRequest<Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1RemoveCertificateResponse>
                {
                    /// <summary>Constructs a new RemoveCertificate request.</summary>
                    public RemoveCertificateRequest(Google.Apis.Services.IClientService service, Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1RemoveCertificateRequest body, string customer) : base(service)
                    {
                        Customer = customer;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The customer whose certificate will be removed.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Customer { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1RemoveCertificateRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "removeCertificate";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+customer}/policies/networks:removeCertificate";

                    /// <summary>Initializes RemoveCertificate parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                        {
                            Name = "customer",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^customers/[^/]+$",
                        });
                    }
                }

                /// <summary>Remove an existing network by guid.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="customer">Required. The customer whose network will be removed.</param>
                public virtual RemoveNetworkRequest RemoveNetwork(Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1RemoveNetworkRequest body, string customer)
                {
                    return new RemoveNetworkRequest(service, body, customer);
                }

                /// <summary>Remove an existing network by guid.</summary>
                public class RemoveNetworkRequest : ChromePolicyBaseServiceRequest<Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1RemoveNetworkResponse>
                {
                    /// <summary>Constructs a new RemoveNetwork request.</summary>
                    public RemoveNetworkRequest(Google.Apis.Services.IClientService service, Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1RemoveNetworkRequest body, string customer) : base(service)
                    {
                        Customer = customer;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The customer whose network will be removed.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Customer { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1RemoveNetworkRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "removeNetwork";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+customer}/policies/networks:removeNetwork";

                    /// <summary>Initializes RemoveNetwork parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                        {
                            Name = "customer",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^customers/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the Orgunits resource.</summary>
            public virtual OrgunitsResource Orgunits { get; }

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

                /// <summary>
                /// Modify multiple policy values that are applied to a specific org unit so that they now inherit the
                /// value from a parent (if applicable). All targets must have the same target format. That is to say
                /// that they must point to the same target resource and must have the same keys specified in
                /// `additionalTargetKeyNames`, though the values for those keys may be different. On failure the
                /// request will return the error details as part of the google.rpc.Status.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="customer">
                /// ID of the G Suite account or literal "my_customer" for the customer associated to the request.
                /// </param>
                public virtual BatchInheritRequest BatchInherit(Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1BatchInheritOrgUnitPoliciesRequest body, string customer)
                {
                    return new BatchInheritRequest(service, body, customer);
                }

                /// <summary>
                /// Modify multiple policy values that are applied to a specific org unit so that they now inherit the
                /// value from a parent (if applicable). All targets must have the same target format. That is to say
                /// that they must point to the same target resource and must have the same keys specified in
                /// `additionalTargetKeyNames`, though the values for those keys may be different. On failure the
                /// request will return the error details as part of the google.rpc.Status.
                /// </summary>
                public class BatchInheritRequest : ChromePolicyBaseServiceRequest<Google.Apis.ChromePolicy.v1.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new BatchInherit request.</summary>
                    public BatchInheritRequest(Google.Apis.Services.IClientService service, Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1BatchInheritOrgUnitPoliciesRequest body, string customer) : base(service)
                    {
                        Customer = customer;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// ID of the G Suite account or literal "my_customer" for the customer associated to the request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Customer { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1BatchInheritOrgUnitPoliciesRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "batchInherit";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+customer}/policies/orgunits:batchInherit";

                    /// <summary>Initializes BatchInherit parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                        {
                            Name = "customer",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^customers/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Modify multiple policy values that are applied to a specific org unit. All targets must have the
                /// same target format. That is to say that they must point to the same target resource and must have
                /// the same keys specified in `additionalTargetKeyNames`, though the values for those keys may be
                /// different. On failure the request will return the error details as part of the google.rpc.Status.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="customer">
                /// ID of the G Suite account or literal "my_customer" for the customer associated to the request.
                /// </param>
                public virtual BatchModifyRequest BatchModify(Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1BatchModifyOrgUnitPoliciesRequest body, string customer)
                {
                    return new BatchModifyRequest(service, body, customer);
                }

                /// <summary>
                /// Modify multiple policy values that are applied to a specific org unit. All targets must have the
                /// same target format. That is to say that they must point to the same target resource and must have
                /// the same keys specified in `additionalTargetKeyNames`, though the values for those keys may be
                /// different. On failure the request will return the error details as part of the google.rpc.Status.
                /// </summary>
                public class BatchModifyRequest : ChromePolicyBaseServiceRequest<Google.Apis.ChromePolicy.v1.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new BatchModify request.</summary>
                    public BatchModifyRequest(Google.Apis.Services.IClientService service, Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1BatchModifyOrgUnitPoliciesRequest body, string customer) : base(service)
                    {
                        Customer = customer;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// ID of the G Suite account or literal "my_customer" for the customer associated to the request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Customer { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1BatchModifyOrgUnitPoliciesRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "batchModify";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+customer}/policies/orgunits:batchModify";

                    /// <summary>Initializes BatchModify parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                        {
                            Name = "customer",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^customers/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the resolved policy values for a list of policies that match a search query.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="customer">
            /// ID of the G Suite account or literal "my_customer" for the customer associated to the request.
            /// </param>
            public virtual ResolveRequest Resolve(Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1ResolveRequest body, string customer)
            {
                return new ResolveRequest(service, body, customer);
            }

            /// <summary>Gets the resolved policy values for a list of policies that match a search query.</summary>
            public class ResolveRequest : ChromePolicyBaseServiceRequest<Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1ResolveResponse>
            {
                /// <summary>Constructs a new Resolve request.</summary>
                public ResolveRequest(Google.Apis.Services.IClientService service, Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1ResolveRequest body, string customer) : base(service)
                {
                    Customer = customer;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// ID of the G Suite account or literal "my_customer" for the customer associated to the request.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1ResolveRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "resolve";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+customer}/policies:resolve";

                /// <summary>Initializes Resolve parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^customers/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the PolicySchemas resource.</summary>
        public virtual PolicySchemasResource PolicySchemas { get; }

        /// <summary>The "policySchemas" collection of methods.</summary>
        public class PolicySchemasResource
        {
            private const string Resource = "policySchemas";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public PolicySchemasResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Get a specific policy schema for a customer by its resource name.</summary>
            /// <param name="name">Required. The policy schema resource name to query.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Get a specific policy schema for a customer by its resource name.</summary>
            public class GetRequest : ChromePolicyBaseServiceRequest<Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1PolicySchema>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. The policy schema resource name to query.</summary>
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
                        Pattern = @"^customers/[^/]+/policySchemas/.*$",
                    });
                }
            }

            /// <summary>
            /// Gets a list of policy schemas that match a specified filter value for a given customer.
            /// </summary>
            /// <param name="parent">Required. The customer for which the listing request will apply.</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Gets a list of policy schemas that match a specified filter value for a given customer.
            /// </summary>
            public class ListRequest : ChromePolicyBaseServiceRequest<Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1ListPolicySchemasResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. The customer for which the listing request will apply.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The schema filter used to find a particular schema based on fields like its resource name,
                /// description and `additionalTargetKeyNames`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// The maximum number of policy schemas to return, defaults to 100 and has a maximum of 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>The page token used to retrieve a specific page of the listing request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/policySchemas";

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

    /// <summary>The "media" collection of methods.</summary>
    public class MediaResource
    {
        private const string Resource = "media";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public MediaResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Creates an enterprise file from the content provided by user. Returns a public download url for end user.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customer">Required. The customer for which the file upload will apply.</param>
        public virtual UploadRequest Upload(Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1UploadPolicyFileRequest body, string customer)
        {
            return new UploadRequest(service, body, customer);
        }

        /// <summary>
        /// Creates an enterprise file from the content provided by user. Returns a public download url for end user.
        /// </summary>
        public class UploadRequest : ChromePolicyBaseServiceRequest<Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1UploadPolicyFileResponse>
        {
            /// <summary>Constructs a new Upload request.</summary>
            public UploadRequest(Google.Apis.Services.IClientService service, Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1UploadPolicyFileRequest body, string customer) : base(service)
            {
                Customer = customer;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The customer for which the file upload will apply.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1UploadPolicyFileRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "upload";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+customer}/policies/files:uploadPolicyFile";

            /// <summary>Initializes Upload parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                {
                    Name = "customer",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^customers/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Creates an enterprise file from the content provided by user. Returns a public download url for end user.
        /// </summary>
        /// <remarks>
        /// Considerations regarding <paramref name="stream"/>:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before reading
        /// commences. If <paramref name="stream"/> is not seekable, then it will be read from its current position
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is completed
        /// </description>
        /// </item>
        /// <item><description>Caller is responsible for closing the <paramref name="stream"/></description></item>
        /// </list>
        /// </remarks>
        /// <param name="body">The body of the request.</param>
        /// <param name="customer">Required. The customer for which the file upload will apply.</param>
        /// <param name="stream">The stream to upload. See remarks for further information.</param>
        /// <param name="contentType">The content type of the stream to upload.</param>
        public virtual UploadMediaUpload Upload(Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1UploadPolicyFileRequest body, string customer, System.IO.Stream stream, string contentType)
        {
            return new UploadMediaUpload(service, body, customer, stream, contentType);
        }

        /// <summary>Upload media upload which supports resumable upload.</summary>
        public class UploadMediaUpload : Google.Apis.Upload.ResumableUpload<Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1UploadPolicyFileRequest, Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1UploadPolicyFileResponse>
        {
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
            /// API key. Your API key identifies your project and provides you with API access, quota, and reports.
            /// Required unless you provide an OAuth 2.0 token.
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
            /// Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned
            /// to a user, but should not exceed 40 characters.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string QuotaUser { get; set; }

            /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
            [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UploadType { get; set; }

            /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
            [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UploadProtocol { get; set; }

            /// <summary>Required. The customer for which the file upload will apply.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }

            /// <summary>Constructs a new Upload media upload instance.</summary>
            /// <remarks>
            /// Considerations regarding <paramref name="stream"/>:
            /// <list type="bullet">
            /// <item>
            /// <description>
            /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before
            /// reading commences. If <paramref name="stream"/> is not seekable, then it will be read from its current
            /// position
            /// </description>
            /// </item>
            /// <item>
            /// <description>
            /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is completed
            /// </description>
            /// </item>
            /// <item><description>Caller is responsible for closing the <paramref name="stream"/></description></item>
            /// </list>
            /// </remarks>
            public UploadMediaUpload(Google.Apis.Services.IClientService service, Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyVersionsV1UploadPolicyFileRequest body, string customer, System.IO.Stream stream, string contentType)
                : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "v1/{+customer}/policies/files:uploadPolicyFile"), "POST", stream, contentType)
            {
                Customer = customer;
                Body = body;
            }
        }
    }
}
namespace Google.Apis.ChromePolicy.v1.Data
{
    public class ChromeCrosDpanelAutosettingsProtoPolicyApiLifecycle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description about current life cycle.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>End supporting date for current policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endSupport")]
        public virtual GoogleTypeDate EndSupport { get; set; }

        /// <summary>Indicate current life cycle stage of the policy API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyApiLifecycleStage")]
        public virtual string PolicyApiLifecycleStage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional key names that will be used to identify the target of the policy value.</summary>
    public class GoogleChromePolicyVersionsV1AdditionalTargetKeyName : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Key name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Key description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyDescription")]
        public virtual string KeyDescription { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for specifying that multiple policy values will be deleted.</summary>
    public class GoogleChromePolicyVersionsV1BatchDeleteGroupPoliciesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of policies that will be deleted as defined by the `requests`. All requests in the list must follow
        /// these restrictions: 1. All schemas in the list must have the same root namespace. 2. All
        /// `policyTargetKey.targetResource` values must point to a group resource. 3. All `policyTargetKey` values must
        /// have the same `app_id` key name in the `additionalTargetKeys`. 4. No two modification requests can reference
        /// the same `policySchema` + ` policyTargetKey` pair.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<GoogleChromePolicyVersionsV1DeleteGroupPolicyRequest> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Request message for specifying that multiple policy values inherit their value from their parents.
    /// </summary>
    public class GoogleChromePolicyVersionsV1BatchInheritOrgUnitPoliciesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of policies that have to inherit their values as defined by the `requests`. All requests in the list
        /// must follow these restrictions: 1. All schemas in the list must have the same root namespace. 2. All
        /// `policyTargetKey.targetResource` values must point to an org unit resource. 3. All `policyTargetKey` values
        /// must have the same key names in the ` additionalTargetKeys`. This also means if one of the targets has an
        /// empty `additionalTargetKeys` map, all of the targets must have an empty `additionalTargetKeys` map. 4. No
        /// two modification requests can reference the same `policySchema` + ` policyTargetKey` pair.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<GoogleChromePolicyVersionsV1InheritOrgUnitPolicyRequest> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for modifying multiple policy values for a specific group-based target.</summary>
    public class GoogleChromePolicyVersionsV1BatchModifyGroupPoliciesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of policies to modify as defined by the `requests`. All requests in the list must follow these
        /// restrictions: 1. All schemas in the list must have the same root namespace. 2. All
        /// `policyTargetKey.targetResource` values must point to a group resource. 3. All `policyTargetKey` values must
        /// have the same `app_id` key name in the `additionalTargetKeys`. 4. No two modification requests can reference
        /// the same `policySchema` + ` policyTargetKey` pair.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<GoogleChromePolicyVersionsV1ModifyGroupPolicyRequest> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for modifying multiple policy values for a specific target.</summary>
    public class GoogleChromePolicyVersionsV1BatchModifyOrgUnitPoliciesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of policies to modify as defined by the `requests`. All requests in the list must follow these
        /// restrictions: 1. All schemas in the list must have the same root namespace. 2. All
        /// `policyTargetKey.targetResource` values must point to an org unit resource. 3. All `policyTargetKey` values
        /// must have the same key names in the ` additionalTargetKeys`. This also means if one of the targets has an
        /// empty `additionalTargetKeys` map, all of the targets must have an empty `additionalTargetKeys` map. 4. No
        /// two modification requests can reference the same `policySchema` + ` policyTargetKey` pair.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<GoogleChromePolicyVersionsV1ModifyOrgUnitPolicyRequest> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Error information for removing of a specific certificate on a specific target. A reference to a certificate.
    /// </summary>
    public class GoogleChromePolicyVersionsV1CertificateReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The name of the referencing network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>Output only. The obfuscated id of the org unit the referencing network is in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgUnitId")]
        public virtual string OrgUnitId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request object for creating a certificate.</summary>
    public class GoogleChromePolicyVersionsV1DefineCertificateRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The optional name of the certificate. If not specified, the certificate issuer will be used as the
        /// name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ceritificateName")]
        public virtual string CeritificateName { get; set; }

        /// <summary>Required. The raw contents of the .PEM, .CRT, or .CER file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificate")]
        public virtual string Certificate { get; set; }

        /// <summary>Optional. Certificate settings within the chrome.networks.certificates namespace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("settings")]
        public virtual System.Collections.Generic.IList<GoogleChromePolicyVersionsV1NetworkSetting> Settings { get; set; }

        /// <summary>
        /// Required. The target resource on which this certificate is applied. The following resources are supported: *
        /// Organizational Unit ("orgunits/{orgunit_id}")
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetResource")]
        public virtual string TargetResource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response object for creating a certificate.</summary>
    public class GoogleChromePolicyVersionsV1DefineCertificateResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The guid of the certificate created by the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkId")]
        public virtual string NetworkId { get; set; }

        /// <summary>the affiliated settings of the certificate (NOT IMPLEMENTED)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("settings")]
        public virtual System.Collections.Generic.IList<GoogleChromePolicyVersionsV1NetworkSetting> Settings { get; set; }

        /// <summary>the resource at which the certificate is defined.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetResource")]
        public virtual string TargetResource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request object for creating a new network.</summary>
    public class GoogleChromePolicyVersionsV1DefineNetworkRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Name of the new created network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. Detailed network settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("settings")]
        public virtual System.Collections.Generic.IList<GoogleChromePolicyVersionsV1NetworkSetting> Settings { get; set; }

        /// <summary>
        /// Required. The target resource on which this new network will be defined. The following resources are
        /// supported: * Organizational Unit ("orgunits/{orgunit_id}")
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetResource")]
        public virtual string TargetResource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response object for creating a network.</summary>
    public class GoogleChromePolicyVersionsV1DefineNetworkResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Network ID of the new created network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkId")]
        public virtual string NetworkId { get; set; }

        /// <summary>Detailed network settings of the new created network</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("settings")]
        public virtual System.Collections.Generic.IList<GoogleChromePolicyVersionsV1NetworkSetting> Settings { get; set; }

        /// <summary>
        /// The target resource on which this new network will be defined. The following resources are supported: *
        /// Organizational Unit ("orgunits/{orgunit_id}")
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetResource")]
        public virtual string TargetResource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request parameters for deleting the policy value of a specific group target.</summary>
    public class GoogleChromePolicyVersionsV1DeleteGroupPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The fully qualified name of the policy schema that is being inherited.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policySchema")]
        public virtual string PolicySchema { get; set; }

        /// <summary>
        /// Required. The key of the target for which we want to modify a policy. The target resource must point to a
        /// Group.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyTargetKey")]
        public virtual GoogleChromePolicyVersionsV1PolicyTargetKey PolicyTargetKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Request parameters for inheriting policy value of a specific org unit target from the policy value of its parent
    /// org unit.
    /// </summary>
    public class GoogleChromePolicyVersionsV1InheritOrgUnitPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The fully qualified name of the policy schema that is being inherited.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policySchema")]
        public virtual string PolicySchema { get; set; }

        /// <summary>
        /// Required. The key of the target for which we want to modify a policy. The target resource must point to an
        /// Org Unit.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyTargetKey")]
        public virtual GoogleChromePolicyVersionsV1PolicyTargetKey PolicyTargetKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for listing the group priority ordering of an app.</summary>
    public class GoogleChromePolicyVersionsV1ListGroupPriorityOrderingRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The namespace of the policy type for the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyNamespace")]
        public virtual string PolicyNamespace { get; set; }

        /// <summary>
        /// Required. The key of the target for which we want to retrieve the group priority ordering. The target
        /// resource must point to an app.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyTargetKey")]
        public virtual GoogleChromePolicyVersionsV1PolicyTargetKey PolicyTargetKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing the group priority ordering of an app.</summary>
    public class GoogleChromePolicyVersionsV1ListGroupPriorityOrderingResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The group IDs, in priority ordering.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupIds")]
        public virtual System.Collections.Generic.IList<string> GroupIds { get; set; }

        /// <summary>Output only. The namespace of the policy type of the group IDs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyNamespace")]
        public virtual string PolicyNamespace { get; set; }

        /// <summary>
        /// Output only. The target resource for which the group priority ordering has been retrieved.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyTargetKey")]
        public virtual GoogleChromePolicyVersionsV1PolicyTargetKey PolicyTargetKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing policy schemas that match a filter.</summary>
    public class GoogleChromePolicyVersionsV1ListPolicySchemasResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The page token used to get the next page of policy schemas.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of policy schemas that match the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policySchemas")]
        public virtual System.Collections.Generic.IList<GoogleChromePolicyVersionsV1PolicySchema> PolicySchemas { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request parameters for modifying a policy value for a specific group target.</summary>
    public class GoogleChromePolicyVersionsV1ModifyGroupPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The key of the target for which we want to modify a policy. The target resource must point to a
        /// Group.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyTargetKey")]
        public virtual GoogleChromePolicyVersionsV1PolicyTargetKey PolicyTargetKey { get; set; }

        /// <summary>The new value for the policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyValue")]
        public virtual GoogleChromePolicyVersionsV1PolicyValue PolicyValue { get; set; }

        /// <summary>
        /// Required. Policy fields to update. Only fields in this mask will be updated; other fields in `policy_value`
        /// will be ignored (even if they have values). If a field is in this list it must have a value in
        /// 'policy_value'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request parameters for modifying a policy value for a specific org unit target.</summary>
    public class GoogleChromePolicyVersionsV1ModifyOrgUnitPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The key of the target for which we want to modify a policy. The target resource must point to an
        /// Org Unit.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyTargetKey")]
        public virtual GoogleChromePolicyVersionsV1PolicyTargetKey PolicyTargetKey { get; set; }

        /// <summary>The new value for the policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyValue")]
        public virtual GoogleChromePolicyVersionsV1PolicyValue PolicyValue { get; set; }

        /// <summary>
        /// Required. Policy fields to update. Only fields in this mask will be updated; other fields in `policy_value`
        /// will be ignored (even if they have values). If a field is in this list it must have a value in
        /// 'policy_value'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A network setting contains network configurations.</summary>
    public class GoogleChromePolicyVersionsV1NetworkSetting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The fully qualified name of the network setting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policySchema")]
        public virtual string PolicySchema { get; set; }

        /// <summary>The value of the network setting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Collections.Generic.IDictionary<string, object> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Error information for a modification request of a specific field on a specific policy.</summary>
    public class GoogleChromePolicyVersionsV1PolicyModificationFieldError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The error message related to the field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual string Error { get; set; }

        /// <summary>Output only. The name of the field with the error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual string Field { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource representing a policy schema.</summary>
    public class GoogleChromePolicyVersionsV1PolicySchema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Specific access restrictions related to this policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessRestrictions")]
        public virtual System.Collections.Generic.IList<string> AccessRestrictions { get; set; }

        /// <summary>
        /// Output only. Additional key names that will be used to identify the target of the policy value. When
        /// specifying a `policyTargetKey`, each of the additional keys specified here will have to be included in the
        /// `additionalTargetKeys` map.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalTargetKeyNames")]
        public virtual System.Collections.Generic.IList<GoogleChromePolicyVersionsV1AdditionalTargetKeyName> AdditionalTargetKeyNames { get; set; }

        /// <summary>Title of the category in which a setting belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryTitle")]
        public virtual string CategoryTitle { get; set; }

        /// <summary>Schema definition using proto descriptor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("definition")]
        public virtual Proto2FileDescriptorProto Definition { get; set; }

        /// <summary>Output only. Detailed description of each field that is part of the schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldDescriptions")]
        public virtual System.Collections.Generic.IList<GoogleChromePolicyVersionsV1PolicySchemaFieldDescription> FieldDescriptions { get; set; }

        /// <summary>Format: name=customers/{customer}/policySchemas/{schema_namespace}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Special notice messages related to setting certain values in certain fields in the schema.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notices")]
        public virtual System.Collections.Generic.IList<GoogleChromePolicyVersionsV1PolicySchemaNoticeDescription> Notices { get; set; }

        /// <summary>Output only. Current lifecycle information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyApiLifecycle")]
        public virtual ChromeCrosDpanelAutosettingsProtoPolicyApiLifecycle PolicyApiLifecycle { get; set; }

        /// <summary>Deprecated field because of typo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyApiLifeycle")]
        public virtual ChromeCrosDpanelAutosettingsProtoPolicyApiLifecycle PolicyApiLifeycle { get; set; }

        /// <summary>Output only. Description about the policy schema for user consumption.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyDescription")]
        public virtual string PolicyDescription { get; set; }

        /// <summary>
        /// Output only. The fully qualified name of the policy schema. This value is used to fill the field
        /// `policy_schema` in PolicyValue when calling BatchInheritOrgUnitPolicies BatchModifyOrgUnitPolicies
        /// BatchModifyGroupPolicies or BatchDeleteGroupPolicies.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemaName")]
        public virtual string SchemaName { get; set; }

        /// <summary>Output only. URI to related support article for this schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportUri")]
        public virtual string SupportUri { get; set; }

        /// <summary>Output only. Information about applicable target resources for the policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validTargetResources")]
        public virtual System.Collections.Generic.IList<string> ValidTargetResources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The field and the value it must have for another field to be allowed to be set.</summary>
    public class GoogleChromePolicyVersionsV1PolicySchemaFieldDependencies : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The source field which this field depends on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceField")]
        public virtual string SourceField { get; set; }

        /// <summary>The value which the source field must have for this field to be allowed to be set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceFieldValue")]
        public virtual string SourceFieldValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Provides detailed information for a particular field that is part of a PolicySchema.</summary>
    public class GoogleChromePolicyVersionsV1PolicySchemaFieldDescription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Client default if the policy is unset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultValue")]
        public virtual object DefaultValue { get; set; }

        /// <summary>Deprecated. Use name and field_description instead. The description for the field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Output only. The name of the field for associated with this description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual string Field { get; set; }

        /// <summary>
        /// Output only. Provides a list of fields and values. At least one of the fields must have the corresponding
        /// value in order for this field to be allowed to be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldDependencies")]
        public virtual System.Collections.Generic.IList<GoogleChromePolicyVersionsV1PolicySchemaFieldDependencies> FieldDependencies { get; set; }

        /// <summary>Output only. The description of the field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldDescription")]
        public virtual string FieldDescription { get; set; }

        /// <summary>Output only. Any input constraints associated on the values for the field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputConstraint")]
        public virtual string InputConstraint { get; set; }

        /// <summary>
        /// Output only. If the field has a set of known values, this field will provide a description for these values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("knownValueDescriptions")]
        public virtual System.Collections.Generic.IList<GoogleChromePolicyVersionsV1PolicySchemaFieldKnownValueDescription> KnownValueDescriptions { get; set; }

        /// <summary>Output only. The name of the field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Provides the description of the fields nested in this field, if the field is a message type
        /// that defines multiple fields.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nestedFieldDescriptions")]
        public virtual System.Collections.Generic.IList<GoogleChromePolicyVersionsV1PolicySchemaFieldDescription> NestedFieldDescriptions { get; set; }

        /// <summary>
        /// Output only. Provides a list of fields that are required to be set if this field has a certain value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requiredItems")]
        public virtual System.Collections.Generic.IList<GoogleChromePolicyVersionsV1PolicySchemaRequiredItems> RequiredItems { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Provides detailed information about a known value that is allowed for a particular field in a PolicySchema.
    /// </summary>
    public class GoogleChromePolicyVersionsV1PolicySchemaFieldKnownValueDescription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Additional description for this value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Output only. The string represenstation of the value that can be set for the field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Provides special notice messages related to a particular value in a field that is part of a PolicySchema.
    /// </summary>
    public class GoogleChromePolicyVersionsV1PolicySchemaNoticeDescription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Whether the user needs to acknowledge the notice message before the value can be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acknowledgementRequired")]
        public virtual System.Nullable<bool> AcknowledgementRequired { get; set; }

        /// <summary>Output only. The field name associated with the notice.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual string Field { get; set; }

        /// <summary>Output only. The notice message associate with the value of the field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noticeMessage")]
        public virtual string NoticeMessage { get; set; }

        /// <summary>
        /// Output only. The value of the field that has a notice. When setting the field to this value, the user may be
        /// required to acknowledge the notice message in order for the value to be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noticeValue")]
        public virtual string NoticeValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The fields that will become required based on the value of this field.</summary>
    public class GoogleChromePolicyVersionsV1PolicySchemaRequiredItems : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The value(s) of the field that provoke required field enforcement. An empty field_conditions implies that
        /// any value assigned to this field will provoke required field enforcement.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldConditions")]
        public virtual System.Collections.Generic.IList<string> FieldConditions { get; set; }

        /// <summary>The fields that are required as a consequence of the field conditions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requiredFields")]
        public virtual System.Collections.Generic.IList<string> RequiredFields { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The key used to identify the target on which the policy will be applied.</summary>
    public class GoogleChromePolicyVersionsV1PolicyTargetKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Map containing the additional target key name and value pairs used to further identify the target of the
        /// policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalTargetKeys")]
        public virtual System.Collections.Generic.IDictionary<string, string> AdditionalTargetKeys { get; set; }

        /// <summary>
        /// The target resource on which this policy is applied. The following resources are supported: * Organizational
        /// Unit ("orgunits/{orgunit_id}") * Group ("groups/{group_id}")
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetResource")]
        public virtual string TargetResource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A particular value for a policy managed by the service.</summary>
    public class GoogleChromePolicyVersionsV1PolicyValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The fully qualified name of the policy schema associated with this policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policySchema")]
        public virtual string PolicySchema { get; set; }

        /// <summary>The value of the policy that is compatible with the schema that it is associated with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Collections.Generic.IDictionary<string, object> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details of the errors encountered during a remove certificate request. This message will be returned as part of
    /// the details of a google.rpc.Status returned to the user when there is an error in their request.
    /// </summary>
    public class GoogleChromePolicyVersionsV1RemoveCertificateErrorDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. If the certificate was not removed, a list of references to the certificate that prevented it
        /// from being removed. Only unreferenced certificates can be removed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificateReferences")]
        public virtual System.Collections.Generic.IList<GoogleChromePolicyVersionsV1CertificateReference> CertificateReferences { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request object for removing a certificate.</summary>
    public class GoogleChromePolicyVersionsV1RemoveCertificateRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The GUID of the certificate to remove.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkId")]
        public virtual string NetworkId { get; set; }

        /// <summary>
        /// Required. The target resource on which this certificate will be removed. The following resources are
        /// supported: * Organizational Unit ("orgunits/{orgunit_id}")
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetResource")]
        public virtual string TargetResource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response object for removing a certificate.</summary>
    public class GoogleChromePolicyVersionsV1RemoveCertificateResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request object for removing a network</summary>
    public class GoogleChromePolicyVersionsV1RemoveNetworkRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The GUID of the network to remove.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkId")]
        public virtual string NetworkId { get; set; }

        /// <summary>
        /// Required. The target resource on which this network will be removed. The following resources are supported:
        /// * Organizational Unit ("orgunits/{orgunit_id}")
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetResource")]
        public virtual string TargetResource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response object for removing a network.</summary>
    public class GoogleChromePolicyVersionsV1RemoveNetworkResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for getting the resolved policy value for a specific target.</summary>
    public class GoogleChromePolicyVersionsV1ResolveRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The maximum number of policies to return, defaults to 100 and has a maximum of 1000.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>The page token used to retrieve a specific page of the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>
        /// The schema filter to apply to the resolve request. Specify a schema name to view a particular schema, for
        /// example: chrome.users.ShowLogoutButton Wildcards are supported, but only in the leaf portion of the schema
        /// name. Wildcards cannot be used in namespace directly. Please read
        /// https://developers.google.com/chrome/policy/guides/policy-schemas for details on schema namespaces. For
        /// example: Valid: "chrome.users.*", "chrome.users.apps.*", "chrome.printers.*" Invalid: "*", "*.users",
        /// "chrome.*", "chrome.*.apps.*"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policySchemaFilter")]
        public virtual string PolicySchemaFilter { get; set; }

        /// <summary>
        /// Required. The key of the target resource on which the policies should be resolved. The target resource must
        /// point to an Org Unit.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyTargetKey")]
        public virtual GoogleChromePolicyVersionsV1PolicyTargetKey PolicyTargetKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for getting the resolved policy value for a specific target.</summary>
    public class GoogleChromePolicyVersionsV1ResolveResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The page token used to get the next set of resolved policies found by the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of resolved policies found by the resolve request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolvedPolicies")]
        public virtual System.Collections.Generic.IList<GoogleChromePolicyVersionsV1ResolvedPolicy> ResolvedPolicies { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The resolved value of a policy for a given target.</summary>
    public class GoogleChromePolicyVersionsV1ResolvedPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The added source key establishes at which level an entity was explicitly added for management.
        /// This is useful for certain type of policies that are only applied if they are explicitly added for
        /// management. For example: apps and networks. An entity can only be deleted from management in an
        /// Organizational Unit that it was explicitly added to. If this is not present it means that the policy is
        /// managed without the need to explicitly add an entity, for example: standard user or device policies.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addedSourceKey")]
        public virtual GoogleChromePolicyVersionsV1PolicyTargetKey AddedSourceKey { get; set; }

        /// <summary>
        /// Output only. The source resource from which this policy value is obtained. May be the same as `targetKey` if
        /// the policy is directly modified on the target, otherwise it would be another resource from which the policy
        /// gets its value (if applicable). If not present, the source is the default value for the customer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceKey")]
        public virtual GoogleChromePolicyVersionsV1PolicyTargetKey SourceKey { get; set; }

        /// <summary>Output only. The target resource for which the resolved policy value applies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetKey")]
        public virtual GoogleChromePolicyVersionsV1PolicyTargetKey TargetKey { get; set; }

        /// <summary>Output only. The resolved value of the policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual GoogleChromePolicyVersionsV1PolicyValue Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for updating the group priority ordering of an app.</summary>
    public class GoogleChromePolicyVersionsV1UpdateGroupPriorityOrderingRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The group IDs, in desired priority ordering.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupIds")]
        public virtual System.Collections.Generic.IList<string> GroupIds { get; set; }

        /// <summary>Required. The namespace of the policy type for the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyNamespace")]
        public virtual string PolicyNamespace { get; set; }

        /// <summary>
        /// Required. The key of the target for which we want to update the group priority ordering. The target resource
        /// must point to an app.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyTargetKey")]
        public virtual GoogleChromePolicyVersionsV1PolicyTargetKey PolicyTargetKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for uploading a file for a policy.</summary>
    public class GoogleChromePolicyVersionsV1UploadPolicyFileRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The fully qualified policy schema and field name this file is uploaded for. This information will
        /// be used to validate the content type of the file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyField")]
        public virtual string PolicyField { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for downloading an uploaded file.</summary>
    public class GoogleChromePolicyVersionsV1UploadPolicyFileResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The uri for end user to download the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downloadUri")]
        public virtual string DownloadUri { get; set; }

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

    /// <summary>Describes a message type.</summary>
    public class Proto2DescriptorProto : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("enumType")]
        public virtual System.Collections.Generic.IList<Proto2EnumDescriptorProto> EnumType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual System.Collections.Generic.IList<Proto2FieldDescriptorProto> Field { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("nestedType")]
        public virtual System.Collections.Generic.IList<Proto2DescriptorProto> NestedType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("oneofDecl")]
        public virtual System.Collections.Generic.IList<Proto2OneofDescriptorProto> OneofDecl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes an enum type.</summary>
    public class Proto2EnumDescriptorProto : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Collections.Generic.IList<Proto2EnumValueDescriptorProto> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a value within an enum.</summary>
    public class Proto2EnumValueDescriptorProto : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("number")]
        public virtual System.Nullable<int> Number { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a field within a message.</summary>
    public class Proto2FieldDescriptorProto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// For numeric types, contains the original text representation of the value. For booleans, "true" or "false".
        /// For strings, contains the default text contents (not escaped in any way). For bytes, contains the C escaped
        /// value. All bytes &amp;gt;= 128 are escaped.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultValue")]
        public virtual string DefaultValue { get; set; }

        /// <summary>
        /// JSON name of this field. The value is set by protocol compiler. If the user has set a "json_name" option on
        /// this field, that option's value will be used. Otherwise, it's deduced from the field's name by converting it
        /// to camelCase.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonName")]
        public virtual string JsonName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("number")]
        public virtual System.Nullable<int> Number { get; set; }

        /// <summary>
        /// If set, gives the index of a oneof in the containing type's oneof_decl list. This field is a member of that
        /// oneof.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oneofIndex")]
        public virtual System.Nullable<int> OneofIndex { get; set; }

        /// <summary>
        /// If true, this is a proto3 "optional". When a proto3 field is optional, it tracks presence regardless of
        /// field type. When proto3_optional is true, this field must be belong to a oneof to signal to old proto3
        /// clients that presence is tracked for this field. This oneof is known as a "synthetic" oneof, and this field
        /// must be its sole member (each proto3 optional field gets its own synthetic oneof). Synthetic oneofs exist in
        /// the descriptor only, and do not generate any API. Synthetic oneofs must be ordered after all "real" oneofs.
        /// For message fields, proto3_optional doesn't create any semantic change, since non-repeated message fields
        /// always track presence. However it still indicates the semantic detail of whether the user wrote "optional"
        /// or not. This can be useful for round-tripping the .proto file. For consistency we give message fields a
        /// synthetic oneof also, even though it is not required to track presence. This is especially important because
        /// the parser can't tell if a field is a message or an enum, so it must always create a synthetic oneof. Proto2
        /// optional fields do not set this flag, because they already indicate optional with `LABEL_OPTIONAL`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proto3Optional")]
        public virtual System.Nullable<bool> Proto3Optional { get; set; }

        /// <summary>
        /// If type_name is set, this need not be set. If both this and type_name are set, this must be one of
        /// TYPE_ENUM, TYPE_MESSAGE or TYPE_GROUP.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// For message and enum types, this is the name of the type. If the name starts with a '.', it is
        /// fully-qualified. Otherwise, C++-like scoping rules are used to find the type (i.e. first the nested types
        /// within this message are searched, then within the parent, on up to the root namespace).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("typeName")]
        public virtual string TypeName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a complete .proto file.</summary>
    public class Proto2FileDescriptorProto : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("enumType")]
        public virtual System.Collections.Generic.IList<Proto2EnumDescriptorProto> EnumType { get; set; }

        /// <summary>All top-level definitions in this file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageType")]
        public virtual System.Collections.Generic.IList<Proto2DescriptorProto> MessageType { get; set; }

        /// <summary>file name, relative to root of source tree</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>e.g. "foo", "foo.bar", etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("package")]
        public virtual string Package { get; set; }

        /// <summary>
        /// The syntax of the proto file. The supported values are "proto2", "proto3", and "editions". If `edition` is
        /// present, this value must be "editions".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syntax")]
        public virtual string Syntax { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a oneof.</summary>
    public class Proto2OneofDescriptorProto : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
