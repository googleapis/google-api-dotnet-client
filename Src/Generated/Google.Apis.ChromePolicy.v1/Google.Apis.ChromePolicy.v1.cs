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
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://chromepolicy.googleapis.com/";
        #else
            "https://chromepolicy.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://chromepolicy.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

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
                Orgunits = new OrgunitsResource(service);
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
                /// `additionalTargetKeyNames`. On failure the request will return the error details as part of the
                /// google.rpc.Status.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="customer">
                /// ID of the G Suite account or literal "my_customer" for the customer associated to the request.
                /// </param>
                public virtual BatchInheritRequest BatchInherit(Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyV1BatchInheritOrgUnitPoliciesRequest body, string customer)
                {
                    return new BatchInheritRequest(service, body, customer);
                }

                /// <summary>
                /// Modify multiple policy values that are applied to a specific org unit so that they now inherit the
                /// value from a parent (if applicable). All targets must have the same target format. That is to say
                /// that they must point to the same target resource and must have the same keys specified in
                /// `additionalTargetKeyNames`. On failure the request will return the error details as part of the
                /// google.rpc.Status.
                /// </summary>
                public class BatchInheritRequest : ChromePolicyBaseServiceRequest<Google.Apis.ChromePolicy.v1.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new BatchInherit request.</summary>
                    public BatchInheritRequest(Google.Apis.Services.IClientService service, Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyV1BatchInheritOrgUnitPoliciesRequest body, string customer) : base(service)
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
                    Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyV1BatchInheritOrgUnitPoliciesRequest Body { get; set; }

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
                /// the same keys specified in `additionalTargetKeyNames`. On failure the request will return the error
                /// details as part of the google.rpc.Status.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="customer">
                /// ID of the G Suite account or literal "my_customer" for the customer associated to the request.
                /// </param>
                public virtual BatchModifyRequest BatchModify(Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyV1BatchModifyOrgUnitPoliciesRequest body, string customer)
                {
                    return new BatchModifyRequest(service, body, customer);
                }

                /// <summary>
                /// Modify multiple policy values that are applied to a specific org unit. All targets must have the
                /// same target format. That is to say that they must point to the same target resource and must have
                /// the same keys specified in `additionalTargetKeyNames`. On failure the request will return the error
                /// details as part of the google.rpc.Status.
                /// </summary>
                public class BatchModifyRequest : ChromePolicyBaseServiceRequest<Google.Apis.ChromePolicy.v1.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new BatchModify request.</summary>
                    public BatchModifyRequest(Google.Apis.Services.IClientService service, Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyV1BatchModifyOrgUnitPoliciesRequest body, string customer) : base(service)
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
                    Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyV1BatchModifyOrgUnitPoliciesRequest Body { get; set; }

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
            public virtual ResolveRequest Resolve(Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyV1ResolveRequest body, string customer)
            {
                return new ResolveRequest(service, body, customer);
            }

            /// <summary>Gets the resolved policy values for a list of policies that match a search query.</summary>
            public class ResolveRequest : ChromePolicyBaseServiceRequest<Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyV1ResolveResponse>
            {
                /// <summary>Constructs a new Resolve request.</summary>
                public ResolveRequest(Google.Apis.Services.IClientService service, Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyV1ResolveRequest body, string customer) : base(service)
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
                Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyV1ResolveRequest Body { get; set; }

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
            public class GetRequest : ChromePolicyBaseServiceRequest<Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyV1PolicySchema>
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
            public class ListRequest : ChromePolicyBaseServiceRequest<Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyV1ListPolicySchemasResponse>
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

                /// <summary>The maximum number of policy schemas to return.</summary>
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
        public virtual UploadRequest Upload(Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyV1UploadPolicyFileRequest body, string customer)
        {
            return new UploadRequest(service, body, customer);
        }

        /// <summary>
        /// Creates an enterprise file from the content provided by user. Returns a public download url for end user.
        /// </summary>
        public class UploadRequest : ChromePolicyBaseServiceRequest<Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyV1UploadPolicyFileResponse>
        {
            /// <summary>Constructs a new Upload request.</summary>
            public UploadRequest(Google.Apis.Services.IClientService service, Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyV1UploadPolicyFileRequest body, string customer) : base(service)
            {
                Customer = customer;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The customer for which the file upload will apply.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyV1UploadPolicyFileRequest Body { get; set; }

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
        public virtual UploadMediaUpload Upload(Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyV1UploadPolicyFileRequest body, string customer, System.IO.Stream stream, string contentType)
        {
            return new UploadMediaUpload(service, body, customer, stream, contentType);
        }

        /// <summary>Upload media upload which supports resumable upload.</summary>
        public class UploadMediaUpload : Google.Apis.Upload.ResumableUpload<Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyV1UploadPolicyFileRequest, Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyV1UploadPolicyFileResponse>
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
            public UploadMediaUpload(Google.Apis.Services.IClientService service, Google.Apis.ChromePolicy.v1.Data.GoogleChromePolicyV1UploadPolicyFileRequest body, string customer, System.IO.Stream stream, string contentType)
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
    /// <summary>Additional key names that will be used to identify the target of the policy value.</summary>
    public class GoogleChromePolicyV1AdditionalTargetKeyName : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>
    /// Request message for specifying that multiple policy values inherit their value from their parents.
    /// </summary>
    public class GoogleChromePolicyV1BatchInheritOrgUnitPoliciesRequest : Google.Apis.Requests.IDirectResponseSchema
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
        public virtual System.Collections.Generic.IList<GoogleChromePolicyV1InheritOrgUnitPolicyRequest> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for modifying multiple policy values for a specific target.</summary>
    public class GoogleChromePolicyV1BatchModifyOrgUnitPoliciesRequest : Google.Apis.Requests.IDirectResponseSchema
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
        public virtual System.Collections.Generic.IList<GoogleChromePolicyV1ModifyOrgUnitPolicyRequest> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Request parameters for inheriting policy value of a specific org unit target from the policy value of its parent
    /// org unit.
    /// </summary>
    public class GoogleChromePolicyV1InheritOrgUnitPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The fully qualified name of the policy schema that is being inherited.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policySchema")]
        public virtual string PolicySchema { get; set; }

        /// <summary>
        /// Required. The key of the target for which we want to modify a policy. The target resource must point to an
        /// Org Unit.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyTargetKey")]
        public virtual GoogleChromePolicyV1PolicyTargetKey PolicyTargetKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing policy schemas that match a filter.</summary>
    public class GoogleChromePolicyV1ListPolicySchemasResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The page token used to get the next page of policy schemas.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of policy schemas that match the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policySchemas")]
        public virtual System.Collections.Generic.IList<GoogleChromePolicyV1PolicySchema> PolicySchemas { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request parameters for modifying a policy value for a specific org unit target.</summary>
    public class GoogleChromePolicyV1ModifyOrgUnitPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The key of the target for which we want to modify a policy. The target resource must point to an
        /// Org Unit.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyTargetKey")]
        public virtual GoogleChromePolicyV1PolicyTargetKey PolicyTargetKey { get; set; }

        /// <summary>The new value for the policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyValue")]
        public virtual GoogleChromePolicyV1PolicyValue PolicyValue { get; set; }

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

    /// <summary>Resource representing a policy schema. Next ID: 10</summary>
    public class GoogleChromePolicyV1PolicySchema : Google.Apis.Requests.IDirectResponseSchema
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
        public virtual System.Collections.Generic.IList<GoogleChromePolicyV1AdditionalTargetKeyName> AdditionalTargetKeyNames { get; set; }

        /// <summary>Schema definition using proto descriptor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("definition")]
        public virtual Proto2FileDescriptorProto Definition { get; set; }

        /// <summary>Output only. Detailed description of each field that is part of the schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldDescriptions")]
        public virtual System.Collections.Generic.IList<GoogleChromePolicyV1PolicySchemaFieldDescription> FieldDescriptions { get; set; }

        /// <summary>Format: name=customers/{customer}/policySchemas/{schema_namespace}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Special notice messages related to setting certain values in certain fields in the schema.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notices")]
        public virtual System.Collections.Generic.IList<GoogleChromePolicyV1PolicySchemaNoticeDescription> Notices { get; set; }

        /// <summary>Output only. Description about the policy schema for user consumption.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyDescription")]
        public virtual string PolicyDescription { get; set; }

        /// <summary>
        /// Output only. The full qualified name of the policy schema. This value is used to fill the field
        /// `policy_schema` in PolicyValue when calling BatchInheritOrgUnitPolicies or BatchModifyOrgUnitPolicies.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemaName")]
        public virtual string SchemaName { get; set; }

        /// <summary>Output only. URI to related support article for this schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportUri")]
        public virtual string SupportUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Provides detailed information for a particular field that is part of a PolicySchema.</summary>
    public class GoogleChromePolicyV1PolicySchemaFieldDescription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The description for the field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Output only. The name of the field for associated with this description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual string Field { get; set; }

        /// <summary>Output only. Any input constraints associated on the values for the field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputConstraint")]
        public virtual string InputConstraint { get; set; }

        /// <summary>
        /// Output only. If the field has a set of know values, this field will provide a description for these values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("knownValueDescriptions")]
        public virtual System.Collections.Generic.IList<GoogleChromePolicyV1PolicySchemaFieldKnownValueDescription> KnownValueDescriptions { get; set; }

        /// <summary>
        /// Output only. Provides the description of the fields nested in this field, if the field is a message type
        /// that defines multiple fields.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nestedFieldDescriptions")]
        public virtual System.Collections.Generic.IList<GoogleChromePolicyV1PolicySchemaFieldDescription> NestedFieldDescriptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Provides detailed information about a known value that is allowed for a particular field in a PolicySchema.
    /// </summary>
    public class GoogleChromePolicyV1PolicySchemaFieldKnownValueDescription : Google.Apis.Requests.IDirectResponseSchema
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
    public class GoogleChromePolicyV1PolicySchemaNoticeDescription : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>The key used to identify the target on which the policy will be applied.</summary>
    public class GoogleChromePolicyV1PolicyTargetKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Map containing the additional target key name and value pairs used to further identify the target of the
        /// policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalTargetKeys")]
        public virtual System.Collections.Generic.IDictionary<string, string> AdditionalTargetKeys { get; set; }

        /// <summary>
        /// The target resource on which this policy is applied. The following resources are supported: * Organizational
        /// Unit ("orgunits/{orgunit_id}")
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetResource")]
        public virtual string TargetResource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A particular value for a policy managed by the service.</summary>
    public class GoogleChromePolicyV1PolicyValue : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Request message for getting the resolved policy value for a specific target.</summary>
    public class GoogleChromePolicyV1ResolveRequest : Google.Apis.Requests.IDirectResponseSchema
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
        /// https://developers.google.com/chrome/chrome-management/guides/policyapi for details on schema namepsaces.
        /// For example: Valid: "chrome.users.*", "chrome.users.apps.*", "chrome.printers.*" Invalid: "*", "*.users",
        /// "chrome.*", "chrome.*.apps.*"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policySchemaFilter")]
        public virtual string PolicySchemaFilter { get; set; }

        /// <summary>
        /// Required. The key of the target resource on which the policies should be resolved. The target resource must
        /// point to an Org Unit.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyTargetKey")]
        public virtual GoogleChromePolicyV1PolicyTargetKey PolicyTargetKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for getting the resolved policy value for a specific target.</summary>
    public class GoogleChromePolicyV1ResolveResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The page token used to get the next set of resolved policies found by the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of resolved policies found by the resolve request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolvedPolicies")]
        public virtual System.Collections.Generic.IList<GoogleChromePolicyV1ResolvedPolicy> ResolvedPolicies { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The resolved value of a policy for a given target.</summary>
    public class GoogleChromePolicyV1ResolvedPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The source resource from which this policy value is obtained. May be the same as `targetKey` if
        /// the policy is directly modified on the target, otherwise it would be another resource from which the policy
        /// gets its value (if applicable). If not present, the source is the default value for the customer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceKey")]
        public virtual GoogleChromePolicyV1PolicyTargetKey SourceKey { get; set; }

        /// <summary>Output only. The target resource for which the resolved policy value applies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetKey")]
        public virtual GoogleChromePolicyV1PolicyTargetKey TargetKey { get; set; }

        /// <summary>Output only. The resolved value of the policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual GoogleChromePolicyV1PolicyValue Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for uploading a file for a policy. Next ID: 5</summary>
    public class GoogleChromePolicyV1UploadPolicyFileRequest : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Response message for downloading an uploaded file. Next ID: 2</summary>
    public class GoogleChromePolicyV1UploadPolicyFileResponse : Google.Apis.Requests.IDirectResponseSchema
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
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); } The JSON representation for `Empty` is empty JSON
    /// object `{}`.
    /// </summary>
    public class GoogleProtobufEmpty : Google.Apis.Requests.IDirectResponseSchema
    {
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

        /// <summary>The syntax of the proto file. The supported values are "proto2" and "proto3".</summary>
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
