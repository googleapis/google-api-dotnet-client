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

namespace Google.Apis.Cloudbilling.v1beta
{
    /// <summary>The Cloudbilling Service.</summary>
    public class CloudbillingService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudbillingService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudbillingService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            BillingAccounts = new BillingAccountsResource(this);
            SkuGroups = new SkuGroupsResource(this);
            Skus = new SkusResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://cloudbilling.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://cloudbilling.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "cloudbilling";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Billing API.</summary>
        public class Scope
        {
            /// <summary>View and manage your Google Cloud Platform billing accounts</summary>
            public static string CloudBilling = "https://www.googleapis.com/auth/cloud-billing";

            /// <summary>View your Google Cloud Platform billing accounts</summary>
            public static string CloudBillingReadonly = "https://www.googleapis.com/auth/cloud-billing.readonly";

            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Billing API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your Google Cloud Platform billing accounts</summary>
            public const string CloudBilling = "https://www.googleapis.com/auth/cloud-billing";

            /// <summary>View your Google Cloud Platform billing accounts</summary>
            public const string CloudBillingReadonly = "https://www.googleapis.com/auth/cloud-billing.readonly";

            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the BillingAccounts resource.</summary>
        public virtual BillingAccountsResource BillingAccounts { get; }

        /// <summary>Gets the SkuGroups resource.</summary>
        public virtual SkuGroupsResource SkuGroups { get; }

        /// <summary>Gets the Skus resource.</summary>
        public virtual SkusResource Skus { get; }
    }

    /// <summary>A base abstract class for Cloudbilling requests.</summary>
    public abstract class CloudbillingBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudbillingBaseServiceRequest instance.</summary>
        protected CloudbillingBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Cloudbilling parameter list.</summary>
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

    /// <summary>The "billingAccounts" collection of methods.</summary>
    public class BillingAccountsResource
    {
        private const string Resource = "billingAccounts";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public BillingAccountsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Services = new ServicesResource(service);
            SkuGroups = new SkuGroupsResource(service);
            Skus = new SkusResource(service);
        }

        /// <summary>Gets the Services resource.</summary>
        public virtual ServicesResource Services { get; }

        /// <summary>The "services" collection of methods.</summary>
        public class ServicesResource
        {
            private const string Resource = "services";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ServicesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Gets a Google Cloud service visible to a billing account.</summary>
            /// <param name="name">
            /// Required. The name of the billing account service to retrieve. Format:
            /// billingAccounts/{billing_account}/services/{service}
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets a Google Cloud service visible to a billing account.</summary>
            public class GetRequest : CloudbillingBaseServiceRequest<Google.Apis.Cloudbilling.v1beta.Data.GoogleCloudBillingBillingaccountservicesV1betaBillingAccountService>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the billing account service to retrieve. Format:
                /// billingAccounts/{billing_account}/services/{service}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}";

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
                        Pattern = @"^billingAccounts/[^/]+/services/[^/]+$",
                    });
                }
            }

            /// <summary>Lists services visible to a billing account.</summary>
            /// <param name="parent">
            /// Required. The billing account to list billing account service from. Format:
            /// billingAccounts/{billing_account}
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists services visible to a billing account.</summary>
            public class ListRequest : CloudbillingBaseServiceRequest<Google.Apis.Cloudbilling.v1beta.Data.GoogleCloudBillingBillingaccountservicesV1betaListBillingAccountServicesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The billing account to list billing account service from. Format:
                /// billingAccounts/{billing_account}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Maximum number of billing account service to return. Results may return fewer than this value.
                /// Default value is 50 and maximum value is 5000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Page token received from a previous ListBillingAccountServices call to retrieve the next page of
                /// results. If this field is empty, the first page is returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/services";

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
                        Pattern = @"^billingAccounts/[^/]+$",
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

        /// <summary>Gets the SkuGroups resource.</summary>
        public virtual SkuGroupsResource SkuGroups { get; }

        /// <summary>The "skuGroups" collection of methods.</summary>
        public class SkuGroupsResource
        {
            private const string Resource = "skuGroups";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SkuGroupsResource(Google.Apis.Services.IClientService service)
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

                /// <summary>Gets a SKU that is part of a billing account SKU group.</summary>
                /// <param name="name">
                /// Required. The name of the billing account SKU group SKU to retrieve. Format:
                /// billingAccounts/{billing_account}/skuGroups/{sku_group}/skus/{sku}
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets a SKU that is part of a billing account SKU group.</summary>
                public class GetRequest : CloudbillingBaseServiceRequest<Google.Apis.Cloudbilling.v1beta.Data.GoogleCloudBillingBillingaccountskugroupskusV1betaBillingAccountSkuGroupSku>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the billing account SKU group SKU to retrieve. Format:
                    /// billingAccounts/{billing_account}/skuGroups/{sku_group}/skus/{sku}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}";

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
                            Pattern = @"^billingAccounts/[^/]+/skuGroups/[^/]+/skus/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists SKUs that is part of billing account SKU groups.</summary>
                /// <param name="parent">
                /// Required. The billing account SKU group to list billing account SKU group SKUs from. Format:
                /// billingAccounts/{billing_account}/skuGroups/{sku_group}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists SKUs that is part of billing account SKU groups.</summary>
                public class ListRequest : CloudbillingBaseServiceRequest<Google.Apis.Cloudbilling.v1beta.Data.GoogleCloudBillingBillingaccountskugroupskusV1betaListBillingAccountSkuGroupSkusResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The billing account SKU group to list billing account SKU group SKUs from. Format:
                    /// billingAccounts/{billing_account}/skuGroups/{sku_group}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Maximum number of billing account SKU group SKUs to return. Results may return fewer than this
                    /// value. Default value is 50 and maximum value is 5000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Page token received from a previous ListBillingAccountSkuGroupSkus call to retrieve the next
                    /// page of results. If this field is empty, the first page is returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+parent}/skus";

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
                            Pattern = @"^billingAccounts/[^/]+/skuGroups/[^/]+$",
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

            /// <summary>Gets a SKU group visible to a billing account.</summary>
            /// <param name="name">
            /// Required. The name of the BillingAccountSkuGroup to retrieve. Format:
            /// billingAccounts/{billing_account}/skuGroups/{sku_group}
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets a SKU group visible to a billing account.</summary>
            public class GetRequest : CloudbillingBaseServiceRequest<Google.Apis.Cloudbilling.v1beta.Data.GoogleCloudBillingBillingaccountskugroupsV1betaBillingAccountSkuGroup>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the BillingAccountSkuGroup to retrieve. Format:
                /// billingAccounts/{billing_account}/skuGroups/{sku_group}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}";

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
                        Pattern = @"^billingAccounts/[^/]+/skuGroups/[^/]+$",
                    });
                }
            }

            /// <summary>Lists SKU groups visible to a billing account.</summary>
            /// <param name="parent">
            /// Required. The billing account to list billing account SKU groups from. Format:
            /// billingAccounts/{billing_account}
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists SKU groups visible to a billing account.</summary>
            public class ListRequest : CloudbillingBaseServiceRequest<Google.Apis.Cloudbilling.v1beta.Data.GoogleCloudBillingBillingaccountskugroupsV1betaListBillingAccountSkuGroupsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The billing account to list billing account SKU groups from. Format:
                /// billingAccounts/{billing_account}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Maximum number of billing account SKU groups to return. Results may return fewer than this value.
                /// Default value is 50 and maximum value is 5000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Page token received from a previous ListBillingAccountSkuGroups call to retrieve the next page of
                /// results. If this field is empty, the first page is returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/skuGroups";

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
                        Pattern = @"^billingAccounts/[^/]+$",
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
                Price = new PriceResource(service);
                Prices = new PricesResource(service);
            }

            /// <summary>Gets the Price resource.</summary>
            public virtual PriceResource Price { get; }

            /// <summary>The "price" collection of methods.</summary>
            public class PriceResource
            {
                private const string Resource = "price";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public PriceResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Gets the latest price for SKUs available to your Cloud Billing account.</summary>
                /// <param name="name">
                /// Required. Name of the billing account price to retrieve. Format:
                /// billingAccounts/{billing_account}/skus/{sku}/price
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets the latest price for SKUs available to your Cloud Billing account.</summary>
                public class GetRequest : CloudbillingBaseServiceRequest<Google.Apis.Cloudbilling.v1beta.Data.GoogleCloudBillingBillingaccountpricesV1betaBillingAccountPrice>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the billing account price to retrieve. Format:
                    /// billingAccounts/{billing_account}/skus/{sku}/price
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. ISO-4217 currency code for the price. If not specified, the currency of the billing
                    /// account is used.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("currencyCode", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string CurrencyCode { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}";

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
                            Pattern = @"^billingAccounts/[^/]+/skus/[^/]+/price$",
                        });
                        RequestParameters.Add("currencyCode", new Google.Apis.Discovery.Parameter
                        {
                            Name = "currencyCode",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Gets the Prices resource.</summary>
            public virtual PricesResource Prices { get; }

            /// <summary>The "prices" collection of methods.</summary>
            public class PricesResource
            {
                private const string Resource = "prices";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public PricesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Lists the latest prices for SKUs available to your Cloud Billing account.</summary>
                /// <param name="parent">
                /// Required. To list all Billing Account SKUs, use `-` as the SKU ID. Format:
                /// `billingAccounts/{billing_account}/skus/-` Note: Specifying an actual SKU resource id will return a
                /// collection of one Billing Account Price.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists the latest prices for SKUs available to your Cloud Billing account.</summary>
                public class ListRequest : CloudbillingBaseServiceRequest<Google.Apis.Cloudbilling.v1beta.Data.GoogleCloudBillingBillingaccountpricesV1betaListBillingAccountPricesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. To list all Billing Account SKUs, use `-` as the SKU ID. Format:
                    /// `billingAccounts/{billing_account}/skus/-` Note: Specifying an actual SKU resource id will
                    /// return a collection of one Billing Account Price.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. ISO-4217 currency code for the price. If not specified, currency of billing account
                    /// will be used.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("currencyCode", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string CurrencyCode { get; set; }

                    /// <summary>
                    /// Optional. Maximum number of billing account price to return. Results may return fewer than this
                    /// value. Default value is 50 and maximum value is 5000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. Page token received from a previous ListBillingAccountPrices call to retrieve the next
                    /// page of results. If this field is empty, the first page is returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+parent}/prices";

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
                            Pattern = @"^billingAccounts/[^/]+/skus/[^/]+$",
                        });
                        RequestParameters.Add("currencyCode", new Google.Apis.Discovery.Parameter
                        {
                            Name = "currencyCode",
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

            /// <summary>Gets a SKU visible to a billing account.</summary>
            /// <param name="name">
            /// Required. The name of the billing account SKU to retrieve. Format:
            /// billingAccounts/{billing_account}/skus/{sku}
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets a SKU visible to a billing account.</summary>
            public class GetRequest : CloudbillingBaseServiceRequest<Google.Apis.Cloudbilling.v1beta.Data.GoogleCloudBillingBillingaccountskusV1betaBillingAccountSku>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the billing account SKU to retrieve. Format:
                /// billingAccounts/{billing_account}/skus/{sku}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}";

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
                        Pattern = @"^billingAccounts/[^/]+/skus/[^/]+$",
                    });
                }
            }

            /// <summary>Lists SKUs visible to a billing account.</summary>
            /// <param name="parent">
            /// Required. The billing account to list billing account SKU from. Format:
            /// billingAccounts/{billing_account}
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists SKUs visible to a billing account.</summary>
            public class ListRequest : CloudbillingBaseServiceRequest<Google.Apis.Cloudbilling.v1beta.Data.GoogleCloudBillingBillingaccountskusV1betaListBillingAccountSkusResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The billing account to list billing account SKU from. Format:
                /// billingAccounts/{billing_account}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Options for how to filter the billing account SKUs. Currently, only filter on
                /// `billing_account_service` is supported. Only !=, = operators are supported. Examples: -
                /// billing_account_service = "billingAccounts/012345-567890-ABCDEF/services/DA34-426B-A397"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Maximum number of billing account SKUs to return. Results may return fewer than this value. Default
                /// value is 50 and maximum value is 5000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Page token received from a previous ListBillingAccountSkus call to retrieve the next page of
                /// results. If this field is empty, the first page is returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/skus";

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
                        Pattern = @"^billingAccounts/[^/]+$",
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

    /// <summary>The "skuGroups" collection of methods.</summary>
    public class SkuGroupsResource
    {
        private const string Resource = "skuGroups";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public SkuGroupsResource(Google.Apis.Services.IClientService service)
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

            /// <summary>Gets a publicly listed SKU that is part of a publicly listed SKU group.</summary>
            /// <param name="name">
            /// Required. The name of the SKU group SKU to retrieve. Format: skuGroups/{sku_group}/skus/{sku}
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets a publicly listed SKU that is part of a publicly listed SKU group.</summary>
            public class GetRequest : CloudbillingBaseServiceRequest<Google.Apis.Cloudbilling.v1beta.Data.GoogleCloudBillingSkugroupskusV1betaSkuGroupSku>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the SKU group SKU to retrieve. Format: skuGroups/{sku_group}/skus/{sku}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}";

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
                        Pattern = @"^skuGroups/[^/]+/skus/[^/]+$",
                    });
                }
            }

            /// <summary>Lists all publicly listed SKUs contained by a publicly listed SKU group.</summary>
            /// <param name="parent">
            /// Required. The SkuGroup to list SkuGroupSku from. Format: skuGroups/{sku_group}
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists all publicly listed SKUs contained by a publicly listed SKU group.</summary>
            public class ListRequest : CloudbillingBaseServiceRequest<Google.Apis.Cloudbilling.v1beta.Data.GoogleCloudBillingSkugroupskusV1betaListSkuGroupSkusResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. The SkuGroup to list SkuGroupSku from. Format: skuGroups/{sku_group}</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Maximum number of SKU group SKUs to return. Results may return fewer than this value. Default value
                /// is 50 and maximum value is 5000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Page token received from a previous ListSkuGroupSkus call to retrieve the next page of results. If
                /// this field is empty, the first page is returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/skus";

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
                        Pattern = @"^skuGroups/[^/]+$",
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

        /// <summary>Gets a publicly listed SKU group.</summary>
        /// <param name="name">Required. The name of the SKU group to retrieve. Format: skuGroups/{sku_group}</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(this.service, name);
        }

        /// <summary>Gets a publicly listed SKU group.</summary>
        public class GetRequest : CloudbillingBaseServiceRequest<Google.Apis.Cloudbilling.v1beta.Data.GoogleCloudBillingSkugroupsV1betaSkuGroup>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. The name of the SKU group to retrieve. Format: skuGroups/{sku_group}</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/{+name}";

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
                    Pattern = @"^skuGroups/[^/]+$",
                });
            }
        }

        /// <summary>Lists all publicly listed SKU groups.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Lists all publicly listed SKU groups.</summary>
        public class ListRequest : CloudbillingBaseServiceRequest<Google.Apis.Cloudbilling.v1beta.Data.GoogleCloudBillingSkugroupsV1betaListSkuGroupsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Maximum number of SKU groups to return. Results may return fewer than this value. Default value is 50
            /// and maximum value is 5000.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Page token received from a previous ListSkuGroups call to retrieve the next page of results. If this
            /// field is empty, the first page is returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/skuGroups";

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
            Price = new PriceResource(service);
            Prices = new PricesResource(service);
        }

        /// <summary>Gets the Price resource.</summary>
        public virtual PriceResource Price { get; }

        /// <summary>The "price" collection of methods.</summary>
        public class PriceResource
        {
            private const string Resource = "price";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public PriceResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Gets the latest price for the given SKU.</summary>
            /// <param name="name">Required. Name of the latest price to retrieve. Format: skus/{sku}/price</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets the latest price for the given SKU.</summary>
            public class GetRequest : CloudbillingBaseServiceRequest<Google.Apis.Cloudbilling.v1beta.Data.GoogleCloudBillingPricesV1betaPrice>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. Name of the latest price to retrieve. Format: skus/{sku}/price</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. ISO-4217 currency code for the price. If not specified, USD will be used.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("currencyCode", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string CurrencyCode { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}";

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
                        Pattern = @"^skus/[^/]+/price$",
                    });
                    RequestParameters.Add("currencyCode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "currencyCode",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Prices resource.</summary>
        public virtual PricesResource Prices { get; }

        /// <summary>The "prices" collection of methods.</summary>
        public class PricesResource
        {
            private const string Resource = "prices";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public PricesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Lists the latest prices for all SKUs.</summary>
            /// <param name="parent">
            /// Required. To list the prices for all SKUs, use `-` as the SKU ID. Format: `skus/-` Specifying a specific
            /// SKU ID returns a collection with one Price object for the SKU.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists the latest prices for all SKUs.</summary>
            public class ListRequest : CloudbillingBaseServiceRequest<Google.Apis.Cloudbilling.v1beta.Data.GoogleCloudBillingPricesV1betaListPricesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. To list the prices for all SKUs, use `-` as the SKU ID. Format: `skus/-` Specifying a
                /// specific SKU ID returns a collection with one Price object for the SKU.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. ISO-4217 currency code for the price. If not specified, USD will be used.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("currencyCode", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string CurrencyCode { get; set; }

                /// <summary>
                /// Optional. Maximum number of prices to return. Results may return fewer than this value. Default
                /// value is 50 and maximum value is 5000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. Page token received from a previous ListPrices call to retrieve the next page of results.
                /// If this field is empty, the first page is returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/prices";

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
                        Pattern = @"^skus/[^/]+$",
                    });
                    RequestParameters.Add("currencyCode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "currencyCode",
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
}
namespace Google.Apis.Cloudbilling.v1beta.Data
{
    /// <summary>
    /// A representation of a decimal value, such as 2.5. Clients may convert values into language-native decimal
    /// formats, such as Java's
    /// [BigDecimal](https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html) or Python's
    /// [decimal.Decimal](https://docs.python.org/3/library/decimal.html).
    /// </summary>
    public class Decimal : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The decimal value, as a string. The string representation consists of an optional sign, `+` (`U+002B`) or
        /// `-` (`U+002D`), followed by a sequence of zero or more decimal digits ("the integer"), optionally followed
        /// by a fraction, optionally followed by an exponent. An empty string **should** be interpreted as `0`. The
        /// fraction consists of a decimal point followed by zero or more decimal digits. The string must contain at
        /// least one digit in either the integer or the fraction. The number formed by the sign, the integer and the
        /// fraction is referred to as the significand. The exponent consists of the character `e` (`U+0065`) or `E`
        /// (`U+0045`) followed by one or more decimal digits. Services **should** normalize decimal values before
        /// storing them by: - Removing an explicitly-provided `+` sign (`+2.5` -&amp;gt; `2.5`). - Replacing a
        /// zero-length integer value with `0` (`.5` -&amp;gt; `0.5`). - Coercing the exponent character to upper-case,
        /// with explicit sign (`2.5e8` -&amp;gt; `2.5E+8`). - Removing an explicitly-provided zero exponent (`2.5E0`
        /// -&amp;gt; `2.5`). Services **may** perform additional normalization based on its own needs and the internal
        /// decimal implementation selected, such as shifting the decimal point and exponent value together (example:
        /// `2.5E-1` &amp;lt;-&amp;gt; `0.25`). Additionally, services **may** preserve trailing zeroes in the fraction
        /// to indicate increased precision, but are not required to do so. Note that only the `.` character is
        /// supported to divide the integer and the fraction; `,` **should not** be supported regardless of locale.
        /// Additionally, thousand separators **should not** be supported. If a service does support them, values
        /// **must** be normalized. The ENBF grammar is: DecimalString = '' | [Sign] Significand [Exponent]; Sign = '+'
        /// | '-'; Significand = Digits '.' | [Digits] '.' Digits; Exponent = ('e' | 'E') [Sign] Digits; Digits = { '0'
        /// | '1' | '2' | '3' | '4' | '5' | '6' | '7' | '8' | '9' }; Services **should** clearly document the range of
        /// supported values, the maximum supported precision (total number of digits), and, if applicable, the scale
        /// (number of digits after the decimal point), as well as how it behaves when receiving out-of-bounds values.
        /// Services **may** choose to accept values passed as input even when the value has a higher precision or scale
        /// than the service supports, and **should** round the value to fit the supported scale. Alternatively, the
        /// service **may** error with `400 Bad Request` (`INVALID_ARGUMENT` in gRPC) if precision would be lost.
        /// Services **should** error with `400 Bad Request` (`INVALID_ARGUMENT` in gRPC) if the service receives a
        /// value outside of the supported range.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Encapsulates the aggregation information such as aggregation level and interval for a billing account price.
    /// </summary>
    public class GoogleCloudBillingBillingaccountpricesV1betaAggregationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Interval at which usage is aggregated to compute cost. Example: "MONTHLY" interval indicates that usage is
        /// aggregated every month.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interval")]
        public virtual string Interval { get; set; }

        /// <summary>
        /// Level at which usage is aggregated to compute cost. Example: "ACCOUNT" level indicates that usage is
        /// aggregated across all projects in a single account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("level")]
        public virtual string Level { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates the latest price for a billing account SKU.</summary>
    public class GoogleCloudBillingBillingaccountpricesV1betaBillingAccountPrice : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ISO-4217 currency code for the price.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>Resource name for the latest billing account price.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Background information on the origin of the price.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceReason")]
        public virtual GoogleCloudBillingBillingaccountpricesV1betaPriceReason PriceReason { get; set; }

        /// <summary>
        /// Rate price metadata. Billing account SKUs with `Rate` price are offered by pricing tiers. The price can have
        /// 1 or more rate pricing tiers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rate")]
        public virtual GoogleCloudBillingBillingaccountpricesV1betaRate Rate { get; set; }

        /// <summary>Type of the price. The possible values are: ["unspecified", "rate"].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueType")]
        public virtual string ValueType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates a default price which is the current list price.</summary>
    public class GoogleCloudBillingBillingaccountpricesV1betaDefaultPrice : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates a discount off the list price, anchored to the list price as of a fixed time.</summary>
    public class GoogleCloudBillingBillingaccountpricesV1betaFixedDiscount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Percentage of the fixed discount.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discountPercent")]
        public virtual Decimal DiscountPercent { get; set; }

        /// <summary>
        /// Type of the fixed discount scope which indicates the source of the discount. It can have values such as
        /// 'unspecified' and 'sku-group'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discountScopeType")]
        public virtual string DiscountScopeType { get; set; }

        private string _fixTimeRaw;

        private object _fixTime;

        /// <summary>Time that the fixed discount is anchored to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixTime")]
        public virtual string FixTimeRaw
        {
            get => _fixTimeRaw;
            set
            {
                _fixTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _fixTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="FixTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use FixTimeDateTimeOffset instead.")]
        public virtual object FixTime
        {
            get => _fixTime;
            set
            {
                _fixTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _fixTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="FixTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? FixTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(FixTimeRaw);
            set => FixTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>SKU group where the fixed discount comes from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skuGroup")]
        public virtual string SkuGroup { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates a set fixed price applicable during the terms of a contract agreement.</summary>
    public class GoogleCloudBillingBillingaccountpricesV1betaFixedPrice : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Encapsulates a discount off the current list price, not anchored to any list price as of a fixed time.
    /// </summary>
    public class GoogleCloudBillingBillingaccountpricesV1betaFloatingDiscount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Percentage of the floating discount.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discountPercent")]
        public virtual Decimal DiscountPercent { get; set; }

        /// <summary>
        /// Type of the floating discount scope which indicates the source of the discount. It can have values such as
        /// 'unspecified' and 'sku-group'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discountScopeType")]
        public virtual string DiscountScopeType { get; set; }

        /// <summary>SKU group where the floating discount comes from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skuGroup")]
        public virtual string SkuGroup { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListBillingAccountPrices.</summary>
    public class GoogleCloudBillingBillingaccountpricesV1betaListBillingAccountPricesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The returned billing account prices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billingAccountPrices")]
        public virtual System.Collections.Generic.IList<GoogleCloudBillingBillingaccountpricesV1betaBillingAccountPrice> BillingAccountPrices { get; set; }

        /// <summary>
        /// Token that can be sent as `page_token` in the subsequent request to retrieve the next page. If this field is
        /// empty, there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Encapsulates a contract feature that the list price (DefaultPrice) will be used for the price if the current
    /// list price drops lower than the custom fixed price. Available to new contracts after March 21, 2022. Applies to
    /// all fixed price SKUs in the contract, including FixedPrice, FixedDiscount, MigratedPrice, and MergedPrice.
    /// </summary>
    public class GoogleCloudBillingBillingaccountpricesV1betaListPriceAsCeiling : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Encapsulates a price after merging from multiple sources. With merged tiers, each individual tier can be from a
    /// different source with different discount types.
    /// </summary>
    public class GoogleCloudBillingBillingaccountpricesV1betaMergedPrice : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates a price migrated from other SKUs.</summary>
    public class GoogleCloudBillingBillingaccountpricesV1betaMigratedPrice : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Source SKU where the discount is migrated from. Format: billingAccounts/{billing_account}/skus/{sku}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceSku")]
        public virtual string SourceSku { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Encapsulates a price reason which contains background information about the origin of the price.
    /// </summary>
    public class GoogleCloudBillingBillingaccountpricesV1betaPriceReason : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Default price which is the current list price.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultPrice")]
        public virtual GoogleCloudBillingBillingaccountpricesV1betaDefaultPrice DefaultPrice { get; set; }

        /// <summary>Discount off the list price, anchored to the list price as of a fixed time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixedDiscount")]
        public virtual GoogleCloudBillingBillingaccountpricesV1betaFixedDiscount FixedDiscount { get; set; }

        /// <summary>Fixed price applicable during the terms of a contract agreement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixedPrice")]
        public virtual GoogleCloudBillingBillingaccountpricesV1betaFixedPrice FixedPrice { get; set; }

        /// <summary>Discount off the current list price, not anchored to any list price as of a fixed time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floatingDiscount")]
        public virtual GoogleCloudBillingBillingaccountpricesV1betaFloatingDiscount FloatingDiscount { get; set; }

        /// <summary>
        /// Contract feature that the list price (DefaultPrice) will be used for the price if the current list price
        /// drops lower than the custom fixed price. Available to new contracts after March 21, 2022. Applies to all
        /// fixed price SKUs in the contract, including FixedPrice, FixedDiscount, MigratedPrice, and MergedPrice.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listPriceAsCeiling")]
        public virtual GoogleCloudBillingBillingaccountpricesV1betaListPriceAsCeiling ListPriceAsCeiling { get; set; }

        /// <summary>Price after merging from multiple sources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mergedPrice")]
        public virtual GoogleCloudBillingBillingaccountpricesV1betaMergedPrice MergedPrice { get; set; }

        /// <summary>Price migrated from other SKUs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("migratedPrice")]
        public virtual GoogleCloudBillingBillingaccountpricesV1betaMigratedPrice MigratedPrice { get; set; }

        /// <summary>
        /// Type of the price reason. It can have values such as 'unspecified', 'default-price', 'fixed-price',
        /// 'fixed-discount', 'floating-discount', 'migrated-price', 'merged-price', 'list-price-as-ceiling'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Encapsulates a `Rate` price. Billing account SKUs with `Rate` price are offered by pricing tiers. The price have
    /// 1 or more rate pricing tiers.
    /// </summary>
    public class GoogleCloudBillingBillingaccountpricesV1betaRate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Aggregation info for tiers such as aggregation level and interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregationInfo")]
        public virtual GoogleCloudBillingBillingaccountpricesV1betaAggregationInfo AggregationInfo { get; set; }

        /// <summary>All tiers associated with the `Rate` price.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tiers")]
        public virtual System.Collections.Generic.IList<GoogleCloudBillingBillingaccountpricesV1betaRateTier> Tiers { get; set; }

        /// <summary>Unit info such as name and quantity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unitInfo")]
        public virtual GoogleCloudBillingBillingaccountpricesV1betaUnitInfo UnitInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates a rate price tier.</summary>
    public class GoogleCloudBillingBillingaccountpricesV1betaRateTier : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Negotiated contract price specific for a billing account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contractPrice")]
        public virtual Money ContractPrice { get; set; }

        /// <summary>
        /// Percentage of effective discount calculated using the current list price per pricing tier. Formula used:
        /// effective_discount_percent = (list_price - contract_price) / list_price × 100 If list_price and
        /// contract_price are zero, this field is the same as `discount_percent` of FixedDiscount and FloatingDiscount.
        /// If your contract does NOT have the feature LIST_PRICE_AS_CEILING enabled, the effective_discount_percent can
        /// be negative if the SKU has a FixedDiscount and the current list price is lower than the list price on the
        /// date of the contract agreement. See the `FixedDiscount.fix_time` on when the discount was set. If you have
        /// questions regarding pricing per SKU, contact your Account team for more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectiveDiscountPercent")]
        public virtual Decimal EffectiveDiscountPercent { get; set; }

        /// <summary>List price of one tier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listPrice")]
        public virtual Money ListPrice { get; set; }

        /// <summary>
        /// Lower bound amount for a tier. Tiers 0-100, 100-200 will be represented with two tiers with `start_amount` 0
        /// and 100.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startAmount")]
        public virtual Decimal StartAmount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates the unit information for a Rate</summary>
    public class GoogleCloudBillingBillingaccountpricesV1betaUnitInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Shorthand for the unit. Example: GiBy.mo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; }

        /// <summary>Human-readable description of the unit. Example: gibibyte month.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unitDescription")]
        public virtual string UnitDescription { get; set; }

        /// <summary>
        /// Unit quantity for the tier. Example: if the RateTier price is $1 per 1000000 Bytes, then `unit_quantity` is
        /// set to 1000000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unitQuantity")]
        public virtual Decimal UnitQuantity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates a Google Cloud service visible to a billing account.</summary>
    public class GoogleCloudBillingBillingaccountservicesV1betaBillingAccountService : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description of the BillingAccountService. Example: "BigQuery", "Compute Engine".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Resource name for the BillingAccountService. Example:
        /// "billingAccounts/012345-567890-ABCDEF/services/DA34-426B-A397".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Identifier for the service. It is the string after the collection identifier "services/". Example:
        /// "DA34-426B-A397".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceId")]
        public virtual string ServiceId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListBillingAccountServices.</summary>
    public class GoogleCloudBillingBillingaccountservicesV1betaListBillingAccountServicesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The returned billing account services.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billingAccountServices")]
        public virtual System.Collections.Generic.IList<GoogleCloudBillingBillingaccountservicesV1betaBillingAccountService> BillingAccountServices { get; set; }

        /// <summary>
        /// Token that can be sent as `page_token` in the subsequent request to retrieve the next page. If this field is
        /// empty, there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Encapsulates a stock keeping (SKU) group visible to a billing account. A SKU group represents a collection of
    /// SKUs that are related to each other. For example, the `AI Platform APIs` SKU group includes SKUs from the Cloud
    /// Dialogflow API, the Cloud Text-to-Speech API, and additional related APIs.
    /// </summary>
    public class GoogleCloudBillingBillingaccountskugroupsV1betaBillingAccountSkuGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description of the BillingAccountSkuGroup. Example: "A2 VMs (1 Year CUD)".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Resource name for the BillingAccountSkuGroup. Example:
        /// "billingAccounts/012345-567890-ABCDEF/skuGroups/0e6403d1-4694-44d2-a696-7a78b1a69301".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListBillingAccountSkuGroups.</summary>
    public class GoogleCloudBillingBillingaccountskugroupsV1betaListBillingAccountSkuGroupsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The returned publicly listed billing account SKU groups.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billingAccountSkuGroups")]
        public virtual System.Collections.Generic.IList<GoogleCloudBillingBillingaccountskugroupsV1betaBillingAccountSkuGroup> BillingAccountSkuGroups { get; set; }

        /// <summary>
        /// Token that can be sent as `page_token` in the subsequent request to retrieve the next page. If this field is
        /// empty, there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates a SKU that is part of a billing account SKU group.</summary>
    public class GoogleCloudBillingBillingaccountskugroupskusV1betaBillingAccountSkuGroupSku : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>BillingAccountService that the BillingAccountSkuGroupSku belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billingAccountService")]
        public virtual string BillingAccountService { get; set; }

        /// <summary>
        /// Description of the BillingAccountSkuGroupSku. Example: "A2 Instance Core running in Hong Kong".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Geographic metadata that applies to the BillingAccountSkuGroupSku.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("geoTaxonomy")]
        public virtual GoogleCloudBillingBillingaccountskugroupskusV1betaGeoTaxonomy GeoTaxonomy { get; set; }

        /// <summary>
        /// Resource name for the BillingAccountSkuGroupSku. Example:
        /// "billingAccounts/012345-567890-ABCDEF/skuGroups/0e6403d1-4694-44d2-a696-7a78b1a69301/skus/AA95-CD31-42FE".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>List of product categories that apply to the BillingAccountSkuGroupSku.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productTaxonomy")]
        public virtual GoogleCloudBillingBillingaccountskugroupskusV1betaProductTaxonomy ProductTaxonomy { get; set; }

        /// <summary>
        /// Unique identifier for the SKU. It is the string after the collection identifier "skus/" Example:
        /// "AA95-CD31-42FE".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skuId")]
        public virtual string SkuId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Encapsulates geographic metadata, such as regions and multi-regions like `us-east4` or `European Union`.
    /// </summary>
    public class GoogleCloudBillingBillingaccountskugroupskusV1betaGeoTaxonomy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Global geographic metadata with no regions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("globalMetadata")]
        public virtual GoogleCloudBillingBillingaccountskugroupskusV1betaGeoTaxonomyGlobal GlobalMetadata { get; set; }

        /// <summary>Multi-regional geographic metadata with 2 or more regions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiRegionalMetadata")]
        public virtual GoogleCloudBillingBillingaccountskugroupskusV1betaGeoTaxonomyMultiRegional MultiRegionalMetadata { get; set; }

        /// <summary>Regional geographic metadata with 1 region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionalMetadata")]
        public virtual GoogleCloudBillingBillingaccountskugroupskusV1betaGeoTaxonomyRegional RegionalMetadata { get; set; }

        /// <summary>Type of geographic taxonomy associated with the billing account SKU group SKU.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates a global geographic taxonomy.</summary>
    public class GoogleCloudBillingBillingaccountskugroupskusV1betaGeoTaxonomyGlobal : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates a multi-regional geographic taxonomy.</summary>
    public class GoogleCloudBillingBillingaccountskugroupskusV1betaGeoTaxonomyMultiRegional : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Google Cloud regions associated with the multi-regional geographic taxonomy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regions")]
        public virtual System.Collections.Generic.IList<GoogleCloudBillingBillingaccountskugroupskusV1betaGeoTaxonomyRegion> Regions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates a Google Cloud region.</summary>
    public class GoogleCloudBillingBillingaccountskugroupskusV1betaGeoTaxonomyRegion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description of a Google Cloud region. Example: "us-west2".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates a regional geographic taxonomy.</summary>
    public class GoogleCloudBillingBillingaccountskugroupskusV1betaGeoTaxonomyRegional : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Google Cloud region associated with the regional geographic taxonomy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual GoogleCloudBillingBillingaccountskugroupskusV1betaGeoTaxonomyRegion Region { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListBillingAccountSkuGroupSkus.</summary>
    public class GoogleCloudBillingBillingaccountskugroupskusV1betaListBillingAccountSkuGroupSkusResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The returned billing account SKU group SKUs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billingAccountSkuGroupSkus")]
        public virtual System.Collections.Generic.IList<GoogleCloudBillingBillingaccountskugroupskusV1betaBillingAccountSkuGroupSku> BillingAccountSkuGroupSkus { get; set; }

        /// <summary>
        /// Token that can be sent as `page_token` in the subsequent request to retrieve the next page. If this field is
        /// empty, there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates product categories, such as `Serverless`, `Cloud Run`, `TaskQueue`, and others.</summary>
    public class GoogleCloudBillingBillingaccountskugroupskusV1betaProductTaxonomy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All product categories that the billing account SKU group SKU belong to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taxonomyCategories")]
        public virtual System.Collections.Generic.IList<GoogleCloudBillingBillingaccountskugroupskusV1betaTaxonomyCategory> TaxonomyCategories { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates a product category.</summary>
    public class GoogleCloudBillingBillingaccountskugroupskusV1betaTaxonomyCategory : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the product category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Encapsulates a stock keeping unit (SKU) visible to a billing account. A SKU distinctly identifies a resource
    /// that you can purchase. For a list of available SKUs, see [SKUs](https://cloud.google.com/skus).
    /// </summary>
    public class GoogleCloudBillingBillingaccountskusV1betaBillingAccountSku : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>BillingAccountService that the BillingAccountSku belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billingAccountService")]
        public virtual string BillingAccountService { get; set; }

        /// <summary>Description of the BillingAccountSku. Example: "A2 Instance Core running in Hong Kong".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Geographic metadata that applies to the BillingAccountSku.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("geoTaxonomy")]
        public virtual GoogleCloudBillingBillingaccountskusV1betaGeoTaxonomy GeoTaxonomy { get; set; }

        /// <summary>
        /// Resource name for the BillingAccountSku. Example:
        /// "billingAccounts/012345-567890-ABCDEF/skus/AA95-CD31-42FE".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>List of product categories that apply to the BillingAccountSku.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productTaxonomy")]
        public virtual GoogleCloudBillingBillingaccountskusV1betaProductTaxonomy ProductTaxonomy { get; set; }

        /// <summary>
        /// Unique identifier for the SKU. It is the string after the collection identifier "skus/" Example:
        /// "AA95-CD31-42FE".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skuId")]
        public virtual string SkuId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Encapsulates geographic metadata, such as regions and multi-regions like `us-east4` or `European Union`.
    /// </summary>
    public class GoogleCloudBillingBillingaccountskusV1betaGeoTaxonomy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Global geographic metadata with no regions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("globalMetadata")]
        public virtual GoogleCloudBillingBillingaccountskusV1betaGeoTaxonomyGlobal GlobalMetadata { get; set; }

        /// <summary>Multi-regional geographic metadata with 2 or more regions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiRegionalMetadata")]
        public virtual GoogleCloudBillingBillingaccountskusV1betaGeoTaxonomyMultiRegional MultiRegionalMetadata { get; set; }

        /// <summary>Regional geographic metadata with 1 region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionalMetadata")]
        public virtual GoogleCloudBillingBillingaccountskusV1betaGeoTaxonomyRegional RegionalMetadata { get; set; }

        /// <summary>Type of geographic taxonomy associated with the billing account SKU.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates a global geographic taxonomy.</summary>
    public class GoogleCloudBillingBillingaccountskusV1betaGeoTaxonomyGlobal : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates a multi-regional geographic taxonomy.</summary>
    public class GoogleCloudBillingBillingaccountskusV1betaGeoTaxonomyMultiRegional : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Google Cloud regions associated with the multi-regional geographic taxonomy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regions")]
        public virtual System.Collections.Generic.IList<GoogleCloudBillingBillingaccountskusV1betaGeoTaxonomyRegion> Regions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates a Google Cloud region.</summary>
    public class GoogleCloudBillingBillingaccountskusV1betaGeoTaxonomyRegion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description of a Google Cloud region. Example: "us-west2".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates a regional geographic taxonomy.</summary>
    public class GoogleCloudBillingBillingaccountskusV1betaGeoTaxonomyRegional : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Google Cloud region associated with the regional geographic taxonomy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual GoogleCloudBillingBillingaccountskusV1betaGeoTaxonomyRegion Region { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListBillingAccountSkus.</summary>
    public class GoogleCloudBillingBillingaccountskusV1betaListBillingAccountSkusResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The returned billing account SKUs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billingAccountSkus")]
        public virtual System.Collections.Generic.IList<GoogleCloudBillingBillingaccountskusV1betaBillingAccountSku> BillingAccountSkus { get; set; }

        /// <summary>
        /// Token that can be sent as `page_token` in the subsequent request to retrieve the next page. If this field is
        /// empty, there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates product categories, such as `Serverless`, `Cloud Run`, `TaskQueue`, and others.</summary>
    public class GoogleCloudBillingBillingaccountskusV1betaProductTaxonomy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All product categories that the billing account SKU belong to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taxonomyCategories")]
        public virtual System.Collections.Generic.IList<GoogleCloudBillingBillingaccountskusV1betaTaxonomyCategory> TaxonomyCategories { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates a product category.</summary>
    public class GoogleCloudBillingBillingaccountskusV1betaTaxonomyCategory : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the product category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates the aggregation information such as aggregation level and interval for a price.</summary>
    public class GoogleCloudBillingPricesV1betaAggregationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Interval at which usage is aggregated to compute cost. Example: "MONTHLY" interval indicates that usage is
        /// aggregated every month.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interval")]
        public virtual string Interval { get; set; }

        /// <summary>
        /// Level at which usage is aggregated to compute cost. Example: "ACCOUNT" level indicates that usage is
        /// aggregated across all projects in a single account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("level")]
        public virtual string Level { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListPrices.</summary>
    public class GoogleCloudBillingPricesV1betaListPricesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token that can be sent as `page_token` in the subsequent request to retrieve the next page. If this field is
        /// empty, there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The returned publicly listed prices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prices")]
        public virtual System.Collections.Generic.IList<GoogleCloudBillingPricesV1betaPrice> Prices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates the latest price for a SKU.</summary>
    public class GoogleCloudBillingPricesV1betaPrice : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ISO-4217 currency code for the price.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>Resource name for the latest price.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Rate price metadata. SKUs with `Rate` price are offered by pricing tiers. The price can have 1 or more rate
        /// pricing tiers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rate")]
        public virtual GoogleCloudBillingPricesV1betaRate Rate { get; set; }

        /// <summary>Type of the price. It can have values: ["unspecified", "rate"].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueType")]
        public virtual string ValueType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Encapsulates a `Rate` price. SKUs with `Rate` price are offered by pricing tiers. The price have 1 or more rate
    /// pricing tiers.
    /// </summary>
    public class GoogleCloudBillingPricesV1betaRate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Aggregation info for tiers such as aggregation level and interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregationInfo")]
        public virtual GoogleCloudBillingPricesV1betaAggregationInfo AggregationInfo { get; set; }

        /// <summary>All tiers associated with the `Rate` price.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tiers")]
        public virtual System.Collections.Generic.IList<GoogleCloudBillingPricesV1betaRateTier> Tiers { get; set; }

        /// <summary>Unit info such as name and quantity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unitInfo")]
        public virtual GoogleCloudBillingPricesV1betaUnitInfo UnitInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates a rate price tier.</summary>
    public class GoogleCloudBillingPricesV1betaRateTier : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List price of one tier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listPrice")]
        public virtual Money ListPrice { get; set; }

        /// <summary>
        /// Lower bound amount for a tier. Tiers 0-100, 100-200 will be represented with two tiers with `start_amount` 0
        /// and 100.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startAmount")]
        public virtual Decimal StartAmount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates the unit information for a Rate</summary>
    public class GoogleCloudBillingPricesV1betaUnitInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Shorthand for the unit. Example: GiBy.mo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; }

        /// <summary>Human-readable description of the unit. Example: gibibyte month.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unitDescription")]
        public virtual string UnitDescription { get; set; }

        /// <summary>
        /// Unit quantity for the tier. Example: if the RateTier price is $1 per 1000000 Bytes, then `unit_quantity` is
        /// set to 1000000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unitQuantity")]
        public virtual Decimal UnitQuantity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListSkuGroups.</summary>
    public class GoogleCloudBillingSkugroupsV1betaListSkuGroupsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token that can be sent as `page_token` in the subsequent request to retrieve the next page. If this field is
        /// empty, there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The returned publicly listed SKU groups.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skuGroups")]
        public virtual System.Collections.Generic.IList<GoogleCloudBillingSkugroupsV1betaSkuGroup> SkuGroups { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Encapsulates a publicly listed stock keeping unit (SKU) group. A SKU group represents a collection of SKUs that
    /// are related to each other. For example, the `AI Platform APIs` SKU group includes SKUs from the Cloud Dialogflow
    /// API, the Cloud Text-to-Speech API, and additional related APIs.
    /// </summary>
    public class GoogleCloudBillingSkugroupsV1betaSkuGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description of the SKU group. Example: "A2 VMs (1 Year CUD)".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Resource name for the SKU group. Example: "skuGroups/0e6403d1-4694-44d2-a696-7a78b1a69301".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Encapsulates geographic metadata, such as regions and multi-regions like `us-east4` or `European Union`.
    /// </summary>
    public class GoogleCloudBillingSkugroupskusV1betaGeoTaxonomy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Global geographic metadata with no regions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("globalMetadata")]
        public virtual GoogleCloudBillingSkugroupskusV1betaGeoTaxonomyGlobal GlobalMetadata { get; set; }

        /// <summary>Multi-regional geographic metadata with 2 or more regions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiRegionalMetadata")]
        public virtual GoogleCloudBillingSkugroupskusV1betaGeoTaxonomyMultiRegional MultiRegionalMetadata { get; set; }

        /// <summary>Regional geographic metadata with 1 region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionalMetadata")]
        public virtual GoogleCloudBillingSkugroupskusV1betaGeoTaxonomyRegional RegionalMetadata { get; set; }

        /// <summary>Type of geographic taxonomy associated with the SKU group SKU.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates a global geographic taxonomy.</summary>
    public class GoogleCloudBillingSkugroupskusV1betaGeoTaxonomyGlobal : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates a multi-regional geographic taxonomy.</summary>
    public class GoogleCloudBillingSkugroupskusV1betaGeoTaxonomyMultiRegional : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Google Cloud regions associated with the multi-regional geographic taxonomy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regions")]
        public virtual System.Collections.Generic.IList<GoogleCloudBillingSkugroupskusV1betaGeoTaxonomyRegion> Regions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates a Google Cloud region.</summary>
    public class GoogleCloudBillingSkugroupskusV1betaGeoTaxonomyRegion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description of a Google Cloud region. Example: "us-west2".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates a regional geographic taxonomy.</summary>
    public class GoogleCloudBillingSkugroupskusV1betaGeoTaxonomyRegional : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Google Cloud region associated with the regional geographic taxonomy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual GoogleCloudBillingSkugroupskusV1betaGeoTaxonomyRegion Region { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListSkuGroupSkus.</summary>
    public class GoogleCloudBillingSkugroupskusV1betaListSkuGroupSkusResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token that can be sent as `page_token` in the subsequent request to retrieve the next page. If this field is
        /// empty, there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The returned SKU group SKUs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skuGroupSkus")]
        public virtual System.Collections.Generic.IList<GoogleCloudBillingSkugroupskusV1betaSkuGroupSku> SkuGroupSkus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates product categories, such as `Serverless`, `Cloud Run`, `TaskQueue`, and others.</summary>
    public class GoogleCloudBillingSkugroupskusV1betaProductTaxonomy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All product categories that the SKU group SKU belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taxonomyCategories")]
        public virtual System.Collections.Generic.IList<GoogleCloudBillingSkugroupskusV1betaTaxonomyCategory> TaxonomyCategories { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Encapsulates a publicly listed stock keeping unit (SKU) that is part of a publicly listed SKU group. A SKU group
    /// represents a collection of SKUs that are related to each other. For example, the `AI Platform APIs` SKU group
    /// includes SKUs from the Cloud Dialogflow API, the Cloud Text-to-Speech API, and additional related APIs.
    /// </summary>
    public class GoogleCloudBillingSkugroupskusV1betaSkuGroupSku : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description of the SkuGroupSku. Example: "A2 Instance Core running in Hong Kong".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Geographic metadata that applies to the SkuGroupSku.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("geoTaxonomy")]
        public virtual GoogleCloudBillingSkugroupskusV1betaGeoTaxonomy GeoTaxonomy { get; set; }

        /// <summary>
        /// Resource name for the SkuGroupSku. Example:
        /// "skuGroups/0e6403d1-4694-44d2-a696-7a78b1a69301/skus/AA95-CD31-42FE".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>List of product categories that apply to the SkuGroupSku.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productTaxonomy")]
        public virtual GoogleCloudBillingSkugroupskusV1betaProductTaxonomy ProductTaxonomy { get; set; }

        /// <summary>Service that the SkuGroupSku belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>
        /// Unique identifier for the SKU. It is the string after the collection identifier "skus/" Example:
        /// "AA95-CD31-42FE".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skuId")]
        public virtual string SkuId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates a product category.</summary>
    public class GoogleCloudBillingSkugroupskusV1betaTaxonomyCategory : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the product category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an amount of money with its currency type.</summary>
    public class Money : Google.Apis.Requests.IDirectResponseSchema
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
}
