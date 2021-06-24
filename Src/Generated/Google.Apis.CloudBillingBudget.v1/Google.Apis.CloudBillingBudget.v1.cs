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

namespace Google.Apis.CloudBillingBudget.v1
{
    /// <summary>The CloudBillingBudget Service.</summary>
    public class CloudBillingBudgetService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudBillingBudgetService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudBillingBudgetService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            BillingAccounts = new BillingAccountsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "billingbudgets";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://billingbudgets.googleapis.com/";
        #else
            "https://billingbudgets.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://billingbudgets.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Billing Budget API.</summary>
        public class Scope
        {
            /// <summary>View and manage your Google Cloud Platform billing accounts</summary>
            public static string CloudBilling = "https://www.googleapis.com/auth/cloud-billing";

            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Billing Budget API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your Google Cloud Platform billing accounts</summary>
            public const string CloudBilling = "https://www.googleapis.com/auth/cloud-billing";

            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the BillingAccounts resource.</summary>
        public virtual BillingAccountsResource BillingAccounts { get; }
    }

    /// <summary>A base abstract class for CloudBillingBudget requests.</summary>
    public abstract class CloudBillingBudgetBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudBillingBudgetBaseServiceRequest instance.</summary>
        protected CloudBillingBudgetBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CloudBillingBudget parameter list.</summary>
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
            Budgets = new BudgetsResource(service);
        }

        /// <summary>Gets the Budgets resource.</summary>
        public virtual BudgetsResource Budgets { get; }

        /// <summary>The "budgets" collection of methods.</summary>
        public class BudgetsResource
        {
            private const string Resource = "budgets";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public BudgetsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a new budget. See [Quotas and limits](https://cloud.google.com/billing/quotas) for more
            /// information on the limits of the number of budgets you can create.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The name of the billing account to create the budget in. Values are of the form
            /// `billingAccounts/{billingAccountId}`.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.CloudBillingBudget.v1.Data.GoogleCloudBillingBudgetsV1Budget body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Creates a new budget. See [Quotas and limits](https://cloud.google.com/billing/quotas) for more
            /// information on the limits of the number of budgets you can create.
            /// </summary>
            public class CreateRequest : CloudBillingBudgetBaseServiceRequest<Google.Apis.CloudBillingBudget.v1.Data.GoogleCloudBillingBudgetsV1Budget>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudBillingBudget.v1.Data.GoogleCloudBillingBudgetsV1Budget body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the billing account to create the budget in. Values are of the form
                /// `billingAccounts/{billingAccountId}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudBillingBudget.v1.Data.GoogleCloudBillingBudgetsV1Budget Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/budgets";

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
                        Pattern = @"^billingAccounts/[^/]+$",
                    });
                }
            }

            /// <summary>Deletes a budget. Returns successfully if already deleted.</summary>
            /// <param name="name">
            /// Required. Name of the budget to delete. Values are of the form
            /// `billingAccounts/{billingAccountId}/budgets/{budgetId}`.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes a budget. Returns successfully if already deleted.</summary>
            public class DeleteRequest : CloudBillingBudgetBaseServiceRequest<Google.Apis.CloudBillingBudget.v1.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the budget to delete. Values are of the form
                /// `billingAccounts/{billingAccountId}/budgets/{budgetId}`.
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
                        Pattern = @"^billingAccounts/[^/]+/budgets/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Returns a budget. WARNING: There are some fields exposed on the Google Cloud Console that aren't
            /// available on this API. When reading from the API, you will not see these fields in the return value,
            /// though they may have been set in the Cloud Console.
            /// </summary>
            /// <param name="name">
            /// Required. Name of budget to get. Values are of the form
            /// `billingAccounts/{billingAccountId}/budgets/{budgetId}`.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>
            /// Returns a budget. WARNING: There are some fields exposed on the Google Cloud Console that aren't
            /// available on this API. When reading from the API, you will not see these fields in the return value,
            /// though they may have been set in the Cloud Console.
            /// </summary>
            public class GetRequest : CloudBillingBudgetBaseServiceRequest<Google.Apis.CloudBillingBudget.v1.Data.GoogleCloudBillingBudgetsV1Budget>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of budget to get. Values are of the form
                /// `billingAccounts/{billingAccountId}/budgets/{budgetId}`.
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
                        Pattern = @"^billingAccounts/[^/]+/budgets/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Returns a list of budgets for a billing account. WARNING: There are some fields exposed on the Google
            /// Cloud Console that aren't available on this API. When reading from the API, you will not see these
            /// fields in the return value, though they may have been set in the Cloud Console.
            /// </summary>
            /// <param name="parent">
            /// Required. Name of billing account to list budgets under. Values are of the form
            /// `billingAccounts/{billingAccountId}`.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Returns a list of budgets for a billing account. WARNING: There are some fields exposed on the Google
            /// Cloud Console that aren't available on this API. When reading from the API, you will not see these
            /// fields in the return value, though they may have been set in the Cloud Console.
            /// </summary>
            public class ListRequest : CloudBillingBudgetBaseServiceRequest<Google.Apis.CloudBillingBudget.v1.Data.GoogleCloudBillingBudgetsV1ListBudgetsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of billing account to list budgets under. Values are of the form
                /// `billingAccounts/{billingAccountId}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of budgets to return per page. The default and maximum value are 100.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. The value returned by the last `ListBudgetsResponse` which indicates that this is a
                /// continuation of a prior `ListBudgets` call, and that the system should return the next page of data.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/budgets";

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

            /// <summary>
            /// Updates a budget and returns the updated budget. WARNING: There are some fields exposed on the Google
            /// Cloud Console that aren't available on this API. Budget fields that are not exposed in this API will not
            /// be changed by this method.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Output only. Resource name of the budget. The resource name implies the scope of a budget. Values are of
            /// the form `billingAccounts/{billingAccountId}/budgets/{budgetId}`.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.CloudBillingBudget.v1.Data.GoogleCloudBillingBudgetsV1Budget body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>
            /// Updates a budget and returns the updated budget. WARNING: There are some fields exposed on the Google
            /// Cloud Console that aren't available on this API. Budget fields that are not exposed in this API will not
            /// be changed by this method.
            /// </summary>
            public class PatchRequest : CloudBillingBudgetBaseServiceRequest<Google.Apis.CloudBillingBudget.v1.Data.GoogleCloudBillingBudgetsV1Budget>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudBillingBudget.v1.Data.GoogleCloudBillingBudgetsV1Budget body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Output only. Resource name of the budget. The resource name implies the scope of a budget. Values
                /// are of the form `billingAccounts/{billingAccountId}/budgets/{budgetId}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. Indicates which fields in the provided budget to update. Read-only fields (such as `name`)
                /// cannot be changed. If this is not provided, then only fields with non-default values from the
                /// request are updated. See https://developers.google.com/protocol-buffers/docs/proto3#default for more
                /// details about default values.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudBillingBudget.v1.Data.GoogleCloudBillingBudgetsV1Budget Body { get; set; }

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
                        Pattern = @"^billingAccounts/[^/]+/budgets/[^/]+$",
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
}
namespace Google.Apis.CloudBillingBudget.v1.Data
{
    /// <summary>
    /// A budget is a plan that describes what you expect to spend on Cloud projects, plus the rules to execute as spend
    /// is tracked against that plan, (for example, send an alert when 90% of the target spend is met). The budget time
    /// period is configurable, with options such as month (default), quarter, year, or custom time period.
    /// </summary>
    public class GoogleCloudBillingBudgetsV1Budget : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Budgeted amount.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amount")]
        public virtual GoogleCloudBillingBudgetsV1BudgetAmount Amount { get; set; }

        /// <summary>
        /// Optional. Filters that define which resources are used to compute the actual spend against the budget
        /// amount, such as projects, services, and the budget's time period, as well as other filters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("budgetFilter")]
        public virtual GoogleCloudBillingBudgetsV1Filter BudgetFilter { get; set; }

        /// <summary>User data for display name in UI. The name must be less than or equal to 60 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Optional. Etag to validate that the object is unchanged for a read-modify-write operation. An empty etag
        /// will cause an update to overwrite other changes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Output only. Resource name of the budget. The resource name implies the scope of a budget. Values are of the
        /// form `billingAccounts/{billingAccountId}/budgets/{budgetId}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. Rules to apply to notifications sent based on budget spend and thresholds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationsRule")]
        public virtual GoogleCloudBillingBudgetsV1NotificationsRule NotificationsRule { get; set; }

        /// <summary>
        /// Optional. Rules that trigger alerts (notifications of thresholds being crossed) when spend exceeds the
        /// specified percentages of the budget. Optional for `pubsubTopic` notifications. Required if using email
        /// notifications.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thresholdRules")]
        public virtual System.Collections.Generic.IList<GoogleCloudBillingBudgetsV1ThresholdRule> ThresholdRules { get; set; }
    }

    /// <summary>The budgeted amount for each usage period.</summary>
    public class GoogleCloudBillingBudgetsV1BudgetAmount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Use the last period's actual spend as the budget for the present period. LastPeriodAmount can only be set
        /// when the budget's time period is a Filter.calendar_period. It cannot be set in combination with
        /// Filter.custom_period.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastPeriodAmount")]
        public virtual GoogleCloudBillingBudgetsV1LastPeriodAmount LastPeriodAmount { get; set; }

        /// <summary>
        /// A specified amount to use as the budget. `currency_code` is optional. If specified when creating a budget,
        /// it must match the currency of the billing account. If specified when updating a budget, it must match the
        /// currency_code of the existing budget. The `currency_code` is provided on output.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("specifiedAmount")]
        public virtual GoogleTypeMoney SpecifiedAmount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>All date times begin at 12 AM US and Canadian Pacific Time (UTC-8).</summary>
    public class GoogleCloudBillingBudgetsV1CustomPeriod : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The end date of the time period. Budgets with elapsed end date won't be processed. If unset,
        /// specifies to track all usage incurred since the start_date.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual GoogleTypeDate EndDate { get; set; }

        /// <summary>Required. The start date must be after January 1, 2017.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual GoogleTypeDate StartDate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A filter for a budget, limiting the scope of the cost to calculate.</summary>
    public class GoogleCloudBillingBudgetsV1Filter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Specifies to track usage for recurring calendar period. For example, assume that
        /// CalendarPeriod.QUARTER is set. The budget will track usage from April 1 to June 30, when the current
        /// calendar month is April, May, June. After that, it will track usage from July 1 to September 30 when the
        /// current calendar month is July, August, September, so on.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("calendarPeriod")]
        public virtual string CalendarPeriod { get; set; }

        /// <summary>
        /// Optional. If Filter.credit_types_treatment is INCLUDE_SPECIFIED_CREDITS, this is a list of credit types to
        /// be subtracted from gross cost to determine the spend for threshold calculations. See [a list of acceptable
        /// credit type values](https://cloud.google.com/billing/docs/how-to/export-data-bigquery-tables#credits-type).
        /// If Filter.credit_types_treatment is **not** INCLUDE_SPECIFIED_CREDITS, this field must be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creditTypes")]
        public virtual System.Collections.Generic.IList<string> CreditTypes { get; set; }

        /// <summary>Optional. If not set, default behavior is `INCLUDE_ALL_CREDITS`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creditTypesTreatment")]
        public virtual string CreditTypesTreatment { get; set; }

        /// <summary>
        /// Optional. Specifies to track usage from any start date (required) to any end date (optional). This time
        /// period is static, it does not recur.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customPeriod")]
        public virtual GoogleCloudBillingBudgetsV1CustomPeriod CustomPeriod { get; set; }

        /// <summary>
        /// Optional. A single label and value pair specifying that usage from only this set of labeled resources should
        /// be included in the budget. Currently, multiple entries or multiple values per entry are not allowed. If
        /// omitted, the report will include all labeled and unlabeled usage.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, System.Collections.Generic.IList<object>> Labels { get; set; }

        /// <summary>
        /// Optional. A set of projects of the form `projects/{project}`, specifying that usage from only this set of
        /// projects should be included in the budget. If omitted, the report will include all usage for the billing
        /// account, regardless of which project the usage occurred on. Only zero or one project can be specified
        /// currently.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projects")]
        public virtual System.Collections.Generic.IList<string> Projects { get; set; }

        /// <summary>
        /// Optional. A set of services of the form `services/{service_id}`, specifying that usage from only this set of
        /// services should be included in the budget. If omitted, the report will include usage for all the services.
        /// The service names are available through the Catalog API:
        /// https://cloud.google.com/billing/v1/how-tos/catalog-api.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("services")]
        public virtual System.Collections.Generic.IList<string> Services { get; set; }

        /// <summary>
        /// Optional. A set of subaccounts of the form `billingAccounts/{account_id}`, specifying that usage from only
        /// this set of subaccounts should be included in the budget. If a subaccount is set to the name of the parent
        /// account, usage from the parent account will be included. If the field is omitted, the report will include
        /// usage from the parent account and all subaccounts, if they exist.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subaccounts")]
        public virtual System.Collections.Generic.IList<string> Subaccounts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Describes a budget amount targeted to the last Filter.calendar_period spend. At this time, the amount is
    /// automatically 100% of the last calendar period's spend; that is, there are no other options yet. Future
    /// configuration options will be described here (for example, configuring a percentage of last period's spend).
    /// LastPeriodAmount cannot be set for a budget configured with a Filter.custom_period.
    /// </summary>
    public class GoogleCloudBillingBudgetsV1LastPeriodAmount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for ListBudgets</summary>
    public class GoogleCloudBillingBudgetsV1ListBudgetsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of the budgets owned by the requested billing account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("budgets")]
        public virtual System.Collections.Generic.IList<GoogleCloudBillingBudgetsV1Budget> Budgets { get; set; }

        /// <summary>
        /// If not empty, indicates that there may be more budgets that match the request; this value should be passed
        /// in a new `ListBudgetsRequest`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>NotificationsRule defines notifications that are sent based on budget spend and thresholds.</summary>
    public class GoogleCloudBillingBudgetsV1NotificationsRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. When set to true, disables default notifications sent when a threshold is exceeded. Default
        /// notifications are sent to those with Billing Account Administrator and Billing Account User IAM roles for
        /// the target account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableDefaultIamRecipients")]
        public virtual System.Nullable<bool> DisableDefaultIamRecipients { get; set; }

        /// <summary>
        /// Optional. Targets to send notifications to when a threshold is exceeded. This is in addition to default
        /// recipients who have billing account IAM roles. The value is the full REST resource name of a monitoring
        /// notification channel with the form `projects/{project_id}/notificationChannels/{channel_id}`. A maximum of 5
        /// channels are allowed. See https://cloud.google.com/billing/docs/how-to/budgets-notification-recipients for
        /// more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monitoringNotificationChannels")]
        public virtual System.Collections.Generic.IList<string> MonitoringNotificationChannels { get; set; }

        /// <summary>
        /// Optional. The name of the Pub/Sub topic where budget related messages will be published, in the form
        /// `projects/{project_id}/topics/{topic_id}`. Updates are sent at regular intervals to the topic. The topic
        /// needs to be created before the budget is created; see
        /// https://cloud.google.com/billing/docs/how-to/budgets#manage-notifications for more details. Caller is
        /// expected to have `pubsub.topics.setIamPolicy` permission on the topic when it's set for a budget, otherwise,
        /// the API call will fail with PERMISSION_DENIED. See
        /// https://cloud.google.com/billing/docs/how-to/budgets-programmatic-notifications for more details on Pub/Sub
        /// roles and permissions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pubsubTopic")]
        public virtual string PubsubTopic { get; set; }

        /// <summary>
        /// Optional. Required when NotificationsRule.pubsub_topic is set. The schema version of the notification sent
        /// to NotificationsRule.pubsub_topic. Only "1.0" is accepted. It represents the JSON schema as defined in
        /// https://cloud.google.com/billing/docs/how-to/budgets-programmatic-notifications#notification_format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemaVersion")]
        public virtual string SchemaVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ThresholdRule contains the definition of a threshold. Threshold rules define the triggering events used to
    /// generate a budget notification email. When a threshold is crossed (spend exceeds the specified percentages of
    /// the budget), budget alert emails are sent to the email recipients you specify in the
    /// [NotificationsRule](#notificationsrule). Threshold rules also affect the fields included in the [JSON data
    /// object](https://cloud.google.com/billing/docs/how-to/budgets-programmatic-notifications#notification_format)
    /// sent to a Pub/Sub topic. Threshold rules are _required_ if using email notifications. Threshold rules are
    /// _optional_ if only setting a [`pubsubTopic` NotificationsRule](#NotificationsRule), unless you want your JSON
    /// data object to include data about the thresholds you set. For more information, see [set budget threshold rules
    /// and actions](https://cloud.google.com/billing/docs/how-to/budgets#budget-actions).
    /// </summary>
    public class GoogleCloudBillingBudgetsV1ThresholdRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The type of basis used to determine if spend has passed the threshold. Behavior defaults to
        /// CURRENT_SPEND if not set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spendBasis")]
        public virtual string SpendBasis { get; set; }

        /// <summary>
        /// Required. Send an alert when this threshold is exceeded. This is a 1.0-based percentage, so 0.5 = 50%.
        /// Validation: non-negative number.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thresholdPercent")]
        public virtual System.Nullable<double> ThresholdPercent { get; set; }

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
    /// Represents a whole or partial calendar date, such as a birthday. The time of day and time zone are either
    /// specified elsewhere or are insignificant. The date is relative to the Gregorian Calendar. This can represent one
    /// of the following: * A full date, with non-zero year, month, and day values * A month and day value, with a zero
    /// year, such as an anniversary * A year on its own, with zero month and day values * A year and month value, with
    /// a zero day, such as a credit card expiration date Related types are google.type.TimeOfDay and
    /// `google.protobuf.Timestamp`.
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
}
