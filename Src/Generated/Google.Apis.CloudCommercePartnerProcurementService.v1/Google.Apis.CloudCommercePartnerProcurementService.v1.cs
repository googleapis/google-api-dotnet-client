// Copyright 2024 Google LLC
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

namespace Google.Apis.CloudCommercePartnerProcurementService.v1
{
    /// <summary>The CloudCommercePartnerProcurementService Service.</summary>
    public class CloudCommercePartnerProcurementServiceService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudCommercePartnerProcurementServiceService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudCommercePartnerProcurementServiceService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Providers = new ProvidersResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://cloudcommerceprocurement.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://cloudcommerceprocurement.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "cloudcommerceprocurement";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Commerce Partner Procurement API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>
        /// Available OAuth 2.0 scope constants for use with the Cloud Commerce Partner Procurement API.
        /// </summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Providers resource.</summary>
        public virtual ProvidersResource Providers { get; }
    }

    /// <summary>A base abstract class for CloudCommercePartnerProcurementService requests.</summary>
    public abstract class CloudCommercePartnerProcurementServiceBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudCommercePartnerProcurementServiceBaseServiceRequest instance.</summary>
        protected CloudCommercePartnerProcurementServiceBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CloudCommercePartnerProcurementService parameter list.</summary>
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

    /// <summary>The "providers" collection of methods.</summary>
    public class ProvidersResource
    {
        private const string Resource = "providers";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ProvidersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Accounts = new AccountsResource(service);
            Entitlements = new EntitlementsResource(service);
        }

        /// <summary>Gets the Accounts resource.</summary>
        public virtual AccountsResource Accounts { get; }

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
            }

            /// <summary>Grants an approval on an Account.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The resource name of the account, with the format
            /// `providers/{providerId}/accounts/{accountId}`.
            /// </param>
            public virtual ApproveRequest Approve(Google.Apis.CloudCommercePartnerProcurementService.v1.Data.ApproveAccountRequest body, string name)
            {
                return new ApproveRequest(this.service, body, name);
            }

            /// <summary>Grants an approval on an Account.</summary>
            public class ApproveRequest : CloudCommercePartnerProcurementServiceBaseServiceRequest<Google.Apis.CloudCommercePartnerProcurementService.v1.Data.Empty>
            {
                /// <summary>Constructs a new Approve request.</summary>
                public ApproveRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudCommercePartnerProcurementService.v1.Data.ApproveAccountRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the account, with the format
                /// `providers/{providerId}/accounts/{accountId}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudCommercePartnerProcurementService.v1.Data.ApproveAccountRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "approve";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:approve";

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
                        Pattern = @"^providers/[^/]+/accounts/[^/]+$",
                    });
                }
            }

            /// <summary>Gets a requested Account resource.</summary>
            /// <param name="name">Required. The name of the account to retrieve.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets a requested Account resource.</summary>
            public class GetRequest : CloudCommercePartnerProcurementServiceBaseServiceRequest<Google.Apis.CloudCommercePartnerProcurementService.v1.Data.Account>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. The name of the account to retrieve.</summary>
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
                        Pattern = @"^providers/[^/]+/accounts/[^/]+$",
                    });
                }
            }

            /// <summary>Lists Accounts that the provider has access to.</summary>
            /// <param name="parent">Required. The parent resource name.</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists Accounts that the provider has access to.</summary>
            public class ListRequest : CloudCommercePartnerProcurementServiceBaseServiceRequest<Google.Apis.CloudCommercePartnerProcurementService.v1.Data.ListAccountsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. The parent resource name.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of entries that are requested. The default page size is 25 and the maximum page
                /// size is 200.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>The token for fetching the next page.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/accounts";

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
                        Pattern = @"^providers/[^/]+$",
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

            /// <summary>Rejects an approval on an Account.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. The resource name of the account.</param>
            public virtual RejectRequest Reject(Google.Apis.CloudCommercePartnerProcurementService.v1.Data.RejectAccountRequest body, string name)
            {
                return new RejectRequest(this.service, body, name);
            }

            /// <summary>Rejects an approval on an Account.</summary>
            public class RejectRequest : CloudCommercePartnerProcurementServiceBaseServiceRequest<Google.Apis.CloudCommercePartnerProcurementService.v1.Data.Empty>
            {
                /// <summary>Constructs a new Reject request.</summary>
                public RejectRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudCommercePartnerProcurementService.v1.Data.RejectAccountRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The resource name of the account.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudCommercePartnerProcurementService.v1.Data.RejectAccountRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "reject";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:reject";

                /// <summary>Initializes Reject parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^providers/[^/]+/accounts/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Resets an Account and cancels all associated Entitlements. Partner can only reset accounts they own
            /// rather than customer accounts.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. The resource name of the account.</param>
            public virtual ResetRequest Reset(Google.Apis.CloudCommercePartnerProcurementService.v1.Data.ResetAccountRequest body, string name)
            {
                return new ResetRequest(this.service, body, name);
            }

            /// <summary>
            /// Resets an Account and cancels all associated Entitlements. Partner can only reset accounts they own
            /// rather than customer accounts.
            /// </summary>
            public class ResetRequest : CloudCommercePartnerProcurementServiceBaseServiceRequest<Google.Apis.CloudCommercePartnerProcurementService.v1.Data.Empty>
            {
                /// <summary>Constructs a new Reset request.</summary>
                public ResetRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudCommercePartnerProcurementService.v1.Data.ResetAccountRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The resource name of the account.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudCommercePartnerProcurementService.v1.Data.ResetAccountRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "reset";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:reset";

                /// <summary>Initializes Reset parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^providers/[^/]+/accounts/[^/]+$",
                    });
                }
            }
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
            /// Approves an entitlement that is in the EntitlementState.ENTITLEMENT_ACTIVATION_REQUESTED state. This
            /// method is invoked by the provider to approve the creation of the entitlement resource.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The resource name of the entitlement, with the format
            /// `providers/{providerId}/entitlements/{entitlementId}`.
            /// </param>
            public virtual ApproveRequest Approve(Google.Apis.CloudCommercePartnerProcurementService.v1.Data.ApproveEntitlementRequest body, string name)
            {
                return new ApproveRequest(this.service, body, name);
            }

            /// <summary>
            /// Approves an entitlement that is in the EntitlementState.ENTITLEMENT_ACTIVATION_REQUESTED state. This
            /// method is invoked by the provider to approve the creation of the entitlement resource.
            /// </summary>
            public class ApproveRequest : CloudCommercePartnerProcurementServiceBaseServiceRequest<Google.Apis.CloudCommercePartnerProcurementService.v1.Data.Empty>
            {
                /// <summary>Constructs a new Approve request.</summary>
                public ApproveRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudCommercePartnerProcurementService.v1.Data.ApproveEntitlementRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the entitlement, with the format
                /// `providers/{providerId}/entitlements/{entitlementId}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudCommercePartnerProcurementService.v1.Data.ApproveEntitlementRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "approve";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:approve";

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
                        Pattern = @"^providers/[^/]+/entitlements/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Approves an entitlement plan change that is in the
            /// EntitlementState.ENTITLEMENT_PENDING_PLAN_CHANGE_APPROVAL state. This method is invoked by the provider
            /// to approve the plan change on the entitlement resource.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. The resource name of the entitlement.</param>
            public virtual ApprovePlanChangeRequest ApprovePlanChange(Google.Apis.CloudCommercePartnerProcurementService.v1.Data.ApproveEntitlementPlanChangeRequest body, string name)
            {
                return new ApprovePlanChangeRequest(this.service, body, name);
            }

            /// <summary>
            /// Approves an entitlement plan change that is in the
            /// EntitlementState.ENTITLEMENT_PENDING_PLAN_CHANGE_APPROVAL state. This method is invoked by the provider
            /// to approve the plan change on the entitlement resource.
            /// </summary>
            public class ApprovePlanChangeRequest : CloudCommercePartnerProcurementServiceBaseServiceRequest<Google.Apis.CloudCommercePartnerProcurementService.v1.Data.Empty>
            {
                /// <summary>Constructs a new ApprovePlanChange request.</summary>
                public ApprovePlanChangeRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudCommercePartnerProcurementService.v1.Data.ApproveEntitlementPlanChangeRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The resource name of the entitlement.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudCommercePartnerProcurementService.v1.Data.ApproveEntitlementPlanChangeRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "approvePlanChange";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:approvePlanChange";

                /// <summary>Initializes ApprovePlanChange parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^providers/[^/]+/entitlements/[^/]+$",
                    });
                }
            }

            /// <summary>Gets a requested Entitlement resource.</summary>
            /// <param name="name">Required. The name of the entitlement to retrieve.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets a requested Entitlement resource.</summary>
            public class GetRequest : CloudCommercePartnerProcurementServiceBaseServiceRequest<Google.Apis.CloudCommercePartnerProcurementService.v1.Data.Entitlement>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. The name of the entitlement to retrieve.</summary>
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
                        Pattern = @"^providers/[^/]+/entitlements/[^/]+$",
                    });
                }
            }

            /// <summary>Lists Entitlements for which the provider has read access.</summary>
            /// <param name="parent">Required. The parent resource name.</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists Entitlements for which the provider has read access.</summary>
            public class ListRequest : CloudCommercePartnerProcurementServiceBaseServiceRequest<Google.Apis.CloudCommercePartnerProcurementService.v1.Data.ListEntitlementsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. The parent resource name.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The filter that can be used to limit the list request. The filter is a query string that can match a
                /// selected set of attributes with string values. For example `account=E-1234-5678-ABCD-EFGH`,
                /// `state=pending_cancellation`, and `plan!=foo-plan`. Supported query attributes are * `account` *
                /// `customer_billing_account` with value in the format of: `billingAccounts/{id}` *
                /// `product_external_name` * `quote_external_name` * `offer` * `new_pending_offer` * `plan` *
                /// `newPendingPlan` or `new_pending_plan` * `state` * `consumers.project` * `change_history.new_offer`
                /// Note that the consumers and change_history.new_offer match works on repeated structures, so equality
                /// (`consumers.project=projects/123456789`) is not supported. Set membership can be expressed with the
                /// `:` operator. For example, `consumers.project:projects/123456789` finds entitlements with at least
                /// one consumer with project field equal to `projects/123456789`. `change_history.new_offer` retrieves
                /// all entitlements that were once associated or are currently active with the offer. Also note that
                /// the state name match is case-insensitive and query can omit the prefix "ENTITLEMENT_". For example,
                /// `state=active` is equivalent to `state=ENTITLEMENT_ACTIVE`. If the query contains some special
                /// characters other than letters, underscore, or digits, the phrase must be quoted with double quotes.
                /// For example, `product="providerId:productId"`, where the product name needs to be quoted because it
                /// contains special character colon. Queries can be combined with `AND`, `OR`, and `NOT` to form more
                /// complex queries. They can also be grouped to force a desired evaluation order. For example,
                /// `state=active AND (account=E-1234 OR account=5678) AND NOT (product=foo-product)`. Connective `AND`
                /// can be omitted between two predicates. For example `account=E-1234 state=active` is equivalent to
                /// `account=E-1234 AND state=active`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>The maximum number of entries that are requested. The default page size is 200.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>The token for fetching the next page.</summary>
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
                        Pattern = @"^providers/[^/]+$",
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

            /// <summary>Updates an existing Entitlement.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. The name of the entitlement to update.</param>
            public virtual PatchRequest Patch(Google.Apis.CloudCommercePartnerProcurementService.v1.Data.Entitlement body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>Updates an existing Entitlement.</summary>
            public class PatchRequest : CloudCommercePartnerProcurementServiceBaseServiceRequest<Google.Apis.CloudCommercePartnerProcurementService.v1.Data.Entitlement>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudCommercePartnerProcurementService.v1.Data.Entitlement body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The name of the entitlement to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// The update mask that applies to the resource. See the [FieldMask definition]
                /// (https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask) for more
                /// details.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudCommercePartnerProcurementService.v1.Data.Entitlement Body { get; set; }

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
                        Pattern = @"^providers/[^/]+/entitlements/[^/]+$",
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
            /// Rejects an entitlement that is in the EntitlementState.ENTITLEMENT_ACTIVATION_REQUESTED state. This
            /// method is invoked by the provider to reject the creation of the entitlement resource.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. The resource name of the entitlement.</param>
            public virtual RejectRequest Reject(Google.Apis.CloudCommercePartnerProcurementService.v1.Data.RejectEntitlementRequest body, string name)
            {
                return new RejectRequest(this.service, body, name);
            }

            /// <summary>
            /// Rejects an entitlement that is in the EntitlementState.ENTITLEMENT_ACTIVATION_REQUESTED state. This
            /// method is invoked by the provider to reject the creation of the entitlement resource.
            /// </summary>
            public class RejectRequest : CloudCommercePartnerProcurementServiceBaseServiceRequest<Google.Apis.CloudCommercePartnerProcurementService.v1.Data.Empty>
            {
                /// <summary>Constructs a new Reject request.</summary>
                public RejectRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudCommercePartnerProcurementService.v1.Data.RejectEntitlementRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The resource name of the entitlement.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudCommercePartnerProcurementService.v1.Data.RejectEntitlementRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "reject";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:reject";

                /// <summary>Initializes Reject parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^providers/[^/]+/entitlements/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Rejects an entitlement plan change that is in the
            /// EntitlementState.ENTITLEMENT_PENDING_PLAN_CHANGE_APPROVAL state. This method is invoked by the provider
            /// to reject the plan change on the entitlement resource.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. The resource name of the entitlement.</param>
            public virtual RejectPlanChangeRequest RejectPlanChange(Google.Apis.CloudCommercePartnerProcurementService.v1.Data.RejectEntitlementPlanChangeRequest body, string name)
            {
                return new RejectPlanChangeRequest(this.service, body, name);
            }

            /// <summary>
            /// Rejects an entitlement plan change that is in the
            /// EntitlementState.ENTITLEMENT_PENDING_PLAN_CHANGE_APPROVAL state. This method is invoked by the provider
            /// to reject the plan change on the entitlement resource.
            /// </summary>
            public class RejectPlanChangeRequest : CloudCommercePartnerProcurementServiceBaseServiceRequest<Google.Apis.CloudCommercePartnerProcurementService.v1.Data.Empty>
            {
                /// <summary>Constructs a new RejectPlanChange request.</summary>
                public RejectPlanChangeRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudCommercePartnerProcurementService.v1.Data.RejectEntitlementPlanChangeRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The resource name of the entitlement.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudCommercePartnerProcurementService.v1.Data.RejectEntitlementPlanChangeRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "rejectPlanChange";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:rejectPlanChange";

                /// <summary>Initializes RejectPlanChange parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^providers/[^/]+/entitlements/[^/]+$",
                    });
                }
            }

            /// <summary>Requests suspension of an active Entitlement. This is not yet supported.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. The name of the entitlement to suspend.</param>
            public virtual SuspendRequest Suspend(Google.Apis.CloudCommercePartnerProcurementService.v1.Data.SuspendEntitlementRequest body, string name)
            {
                return new SuspendRequest(this.service, body, name);
            }

            /// <summary>Requests suspension of an active Entitlement. This is not yet supported.</summary>
            public class SuspendRequest : CloudCommercePartnerProcurementServiceBaseServiceRequest<Google.Apis.CloudCommercePartnerProcurementService.v1.Data.Empty>
            {
                /// <summary>Constructs a new Suspend request.</summary>
                public SuspendRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudCommercePartnerProcurementService.v1.Data.SuspendEntitlementRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The name of the entitlement to suspend.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudCommercePartnerProcurementService.v1.Data.SuspendEntitlementRequest Body { get; set; }

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
                        Pattern = @"^providers/[^/]+/entitlements/[^/]+$",
                    });
                }
            }
        }
    }
}
namespace Google.Apis.CloudCommercePartnerProcurementService.v1.Data
{
    /// <summary>Represents an account that was established by the customer on the service provider's system.</summary>
    public class Account : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The approvals for this account. These approvals are used to track actions that are permitted or
        /// have been completed by a customer within the context of the provider. This might include a sign up flow or a
        /// provisioning step, for example, that the provider can admit to having happened.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approvals")]
        public virtual System.Collections.Generic.IList<Approval> Approvals { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The creation timestamp.</summary>
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
        /// Output only. The custom properties that were collected from the user to create this account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputProperties")]
        public virtual System.Collections.Generic.IDictionary<string, object> InputProperties { get; set; }

        /// <summary>
        /// Output only. The resource name of the account. Account names have the form `accounts/{account_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The identifier of the service provider that this account was created against. Each service
        /// provider is assigned a unique provider value when they onboard with Cloud Commerce platform.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provider")]
        public virtual string Provider { get; set; }

        /// <summary>
        /// Output only. The state of the account. This is used to decide whether the customer is in good standing with
        /// the provider and is able to make purchases. An account might not be able to make a purchase if the billing
        /// account is suspended, for example.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The last update timestamp.</summary>
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

    /// <summary>An approval for some action on an account.</summary>
    public class Approval : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The name of the approval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. An explanation for the state of the approval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>Output only. The state of the approval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Optional. The last update timestamp of the approval.</summary>
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

    /// <summary>Request message for PartnerProcurementService.ApproveAccount.</summary>
    public class ApproveAccountRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the approval being approved. If absent and there is only one approval possible, that approval
        /// will be granted. If absent and there are many approvals possible, the request will fail with a 400 Bad
        /// Request. Optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approvalName")]
        public virtual string ApprovalName { get; set; }

        /// <summary>Set of properties that should be associated with the account. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IDictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Free form text string explaining the approval reason. Optional. Max allowed length: 256 bytes. Longer
        /// strings will be truncated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for [PartnerProcurementService.ApproveEntitlementPlanChange[].</summary>
    public class ApproveEntitlementPlanChangeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Name of the pending plan that is being approved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pendingPlanName")]
        public virtual string PendingPlanName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for [PartnerProcurementService.ApproveEntitlement[].</summary>
    public class ApproveEntitlementRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The resource name of the entitlement that was migrated, with the format
        /// `providers/{provider_id}/entitlements/{entitlement_id}`. Should only be sent when resources have been
        /// migrated from entitlement_migrated to the new entitlement. Optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entitlementMigrated")]
        public virtual string EntitlementMigrated { get; set; }

        /// <summary>Set of properties that should be associated with the entitlement. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IDictionary<string, string> Properties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource using (consuming) this entitlement.</summary>
    public class Consumer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A project name with format `projects/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

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

    /// <summary>Represents a procured product of a customer.</summary>
    public class Entitlement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The resource name of the account that this entitlement is based on, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("account")]
        public virtual string Account { get; set; }

        /// <summary>
        /// Output only. The reason the entitlement was cancelled. If this entitlement was not cancelled, this field
        /// will be empty. Possible values include "unknown", "expired", "user-cancelled", "account-closed",
        /// "billing-disabled" (if the customer has manually disabled billing to their resources), "user-aborted", and
        /// "migrated" (if the entitlement has migrated across products). Values of this field are subject to change and
        /// should not be relied upon for technical integration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancellationReason")]
        public virtual string CancellationReason { get; set; }

        /// <summary>Output only. The resources using this entitlement, if applicable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumers")]
        public virtual System.Collections.Generic.IList<Consumer> Consumers { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The creation timestamp.</summary>
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

        /// <summary>Output only. The entitlement benefit IDs associated with the purchase.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entitlementBenefitIds")]
        public virtual System.Collections.Generic.IList<string> EntitlementBenefitIds { get; set; }

        /// <summary>
        /// Output only. The custom properties that were collected from the user to create this entitlement.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputProperties")]
        public virtual System.Collections.Generic.IDictionary<string, object> InputProperties { get; set; }

        /// <summary>
        /// Provider-supplied message that is displayed to the end user. Currently this is used to communicate progress
        /// and ETA for provisioning. This field can be updated only when a user is waiting for an action from the
        /// provider, i.e. entitlement state is EntitlementState.ENTITLEMENT_ACTIVATION_REQUESTED or
        /// EntitlementState.ENTITLEMENT_PENDING_PLAN_CHANGE_APPROVAL. This field is cleared automatically when the
        /// entitlement state changes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageToUser")]
        public virtual string MessageToUser { get; set; }

        /// <summary>
        /// Output only. The resource name of the entitlement. Entitlement names have the form
        /// `providers/{provider_id}/entitlements/{entitlement_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _newOfferEndTimeRaw;

        private object _newOfferEndTime;

        /// <summary>
        /// Output only. The end time of the new offer. If the offer was created with a term instead of a specified end
        /// date, this field is empty. This field will be populated even if the entitlement is not active yet. If there
        /// is no upcoming offer, the field will be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newOfferEndTime")]
        public virtual string NewOfferEndTimeRaw
        {
            get => _newOfferEndTimeRaw;
            set
            {
                _newOfferEndTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _newOfferEndTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="NewOfferEndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use NewOfferEndTimeDateTimeOffset instead.")]
        public virtual object NewOfferEndTime
        {
            get => _newOfferEndTime;
            set
            {
                _newOfferEndTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _newOfferEndTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="NewOfferEndTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? NewOfferEndTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(NewOfferEndTimeRaw);
            set => NewOfferEndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _newOfferStartTimeRaw;

        private object _newOfferStartTime;

        /// <summary>
        /// Output only. The timestamp when the new offer will become effective. This field will be populated even if
        /// the entitlement is not active yet. If there is no upcoming offer, the field will be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newOfferStartTime")]
        public virtual string NewOfferStartTimeRaw
        {
            get => _newOfferStartTimeRaw;
            set
            {
                _newOfferStartTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _newOfferStartTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="NewOfferStartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use NewOfferStartTimeDateTimeOffset instead.")]
        public virtual object NewOfferStartTime
        {
            get => _newOfferStartTime;
            set
            {
                _newOfferStartTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _newOfferStartTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="NewOfferStartTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? NewOfferStartTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(NewOfferStartTimeRaw);
            set => NewOfferStartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. The name of the offer the entitlement is switching to upon a pending plan change. Only exists
        /// if the pending plan change is moving to an offer. This field is not populated for entitlements which are not
        /// active yet. Format: 'projects/{project}/services/{service}/privateOffers/{offer-id}' OR
        /// 'projects/{project}/services/{service}/standardOffers/{offer-id}', depending on whether the offer is private
        /// or public. The {service} in the name is the listing service of the offer. It could be either the product
        /// service that the offer is referencing, or a generic private offer parent service. We recommend that you
        /// don't build your integration to rely on the meaning of this {service} part.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newPendingOffer")]
        public virtual string NewPendingOffer { get; set; }

        /// <summary>
        /// Output only. The offer duration of the new offer in ISO 8601 duration format. This field is not populated
        /// for entitlements which are not active yet, only for pending offer changes. If the offer was created with a
        /// specified end date instead of a duration, this field is empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newPendingOfferDuration")]
        public virtual string NewPendingOfferDuration { get; set; }

        /// <summary>
        /// Output only. The identifier of the pending new plan. Required if the product has plans and the entitlement
        /// has a pending plan change.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newPendingPlan")]
        public virtual string NewPendingPlan { get; set; }

        /// <summary>
        /// Output only. The name of the offer that was procured. Field is empty if order was not made using an offer.
        /// Format: 'projects/{project}/services/{service}/privateOffers/{offer-id}' OR
        /// 'projects/{project}/services/{service}/standardOffers/{offer-id}', depending on whether the offer is private
        /// or public. The {service} in the name is the listing service of the offer. It could be either the product
        /// service that the offer is referencing, or a generic private offer parent service. We recommend that you
        /// don't build your integration to rely on the meaning of this {service} part.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offer")]
        public virtual string Offer { get; set; }

        /// <summary>
        /// Output only. The offer duration of the current offer in ISO 8601 duration format. Field is empty if
        /// entitlement was not made using an offer. If the offer was created with a specified end date instead of a
        /// duration, this field is empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offerDuration")]
        public virtual string OfferDuration { get; set; }

        private string _offerEndTimeRaw;

        private object _offerEndTime;

        /// <summary>
        /// Output only. End time for the Offer association corresponding to this entitlement. The field is only
        /// populated if the entitlement is currently associated with an Offer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offerEndTime")]
        public virtual string OfferEndTimeRaw
        {
            get => _offerEndTimeRaw;
            set
            {
                _offerEndTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _offerEndTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="OfferEndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use OfferEndTimeDateTimeOffset instead.")]
        public virtual object OfferEndTime
        {
            get => _offerEndTime;
            set
            {
                _offerEndTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _offerEndTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="OfferEndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? OfferEndTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(OfferEndTimeRaw);
            set => OfferEndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. The order ID of this entitlement, without any `orders/` resource name prefix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderId")]
        public virtual string OrderId { get; set; }

        /// <summary>
        /// Output only. The identifier of the plan that was procured. Required if the product has plans.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plan")]
        public virtual string Plan { get; set; }

        /// <summary>
        /// Output only. The identifier of the entity that was purchased. This may actually represent a product, quote,
        /// or offer. We strongly recommend that you use the following more explicit fields: productExternalName,
        /// quoteExternalName, or offer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("product")]
        public virtual string Product { get; set; }

        /// <summary>Output only. The identifier of the product that was procured.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productExternalName")]
        public virtual string ProductExternalName { get; set; }

        /// <summary>
        /// Output only. The identifier of the service provider that this entitlement was created against. Each service
        /// provider is assigned a unique provider value when they onboard with Cloud Commerce platform.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provider")]
        public virtual string Provider { get; set; }

        /// <summary>
        /// Output only. The identifier of the quote that was used to procure. Empty if the order is not purchased using
        /// a quote.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quoteExternalName")]
        public virtual string QuoteExternalName { get; set; }

        /// <summary>Output only. The state of the entitlement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _subscriptionEndTimeRaw;

        private object _subscriptionEndTime;

        /// <summary>Output only. End time for the subscription corresponding to this entitlement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriptionEndTime")]
        public virtual string SubscriptionEndTimeRaw
        {
            get => _subscriptionEndTimeRaw;
            set
            {
                _subscriptionEndTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _subscriptionEndTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="SubscriptionEndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use SubscriptionEndTimeDateTimeOffset instead.")]
        public virtual object SubscriptionEndTime
        {
            get => _subscriptionEndTime;
            set
            {
                _subscriptionEndTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _subscriptionEndTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="SubscriptionEndTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? SubscriptionEndTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(SubscriptionEndTimeRaw);
            set => SubscriptionEndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The last update timestamp.</summary>
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

        /// <summary>
        /// Output only. The consumerId to use when reporting usage through the Service Control API. See the consumerId
        /// field at [Reporting Metrics](https://cloud.google.com/service-control/reporting-metrics) for more details.
        /// This field is present only if the product has usage-based billing configured.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usageReportingId")]
        public virtual string UsageReportingId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for [PartnerProcurementService.ListAccounts[].</summary>
    public class ListAccountsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of accounts in this response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accounts")]
        public virtual System.Collections.Generic.IList<Account> Accounts { get; set; }

        /// <summary>The token for fetching the next page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for PartnerProcurementService.ListEntitlements.</summary>
    public class ListEntitlementsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of entitlements in this response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entitlements")]
        public virtual System.Collections.Generic.IList<Entitlement> Entitlements { get; set; }

        /// <summary>The token for fetching the next page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for PartnerProcurementService.RejectAccount.</summary>
    public class RejectAccountRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the approval being rejected. If absent and there is only one approval possible, that approval
        /// will be rejected. If absent and there are many approvals possible, the request will fail with a 400 Bad
        /// Request. Optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approvalName")]
        public virtual string ApprovalName { get; set; }

        /// <summary>
        /// Free form text string explaining the rejection reason. Max allowed length: 256 bytes. Longer strings will be
        /// truncated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for PartnerProcurementService.RejectEntitlementPlanChange.</summary>
    public class RejectEntitlementPlanChangeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Name of the pending plan that is being rejected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pendingPlanName")]
        public virtual string PendingPlanName { get; set; }

        /// <summary>
        /// Free form text string explaining the rejection reason. Max allowed length: 256 bytes. Longer strings will be
        /// truncated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for PartnerProcurementService.RejectEntitlement.</summary>
    public class RejectEntitlementRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Free form text string explaining the rejection reason. Max allowed length: 256 bytes. Longer strings will be
        /// truncated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for PartnerProcurementService.ResetAccount.</summary>
    public class ResetAccountRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ParterProcurementService.SuspendEntitlement. This is not yet supported.</summary>
    public class SuspendEntitlementRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A free-form reason string, explaining the reason for suspension request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
