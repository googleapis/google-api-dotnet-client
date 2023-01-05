// Copyright 2023 Google LLC
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
            V1beta = new V1betaResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "cloudbilling";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri => BaseUriOverride ?? "https://cloudbilling.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://cloudbilling.googleapis.com/batch";

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

        /// <summary>Gets the V1beta resource.</summary>
        public virtual V1betaResource V1beta { get; }
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
        }

        /// <summary>
        /// Use custom pricing in the estimate, using a `CostScenario` with a defined `billingAccount`.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="billingAccount">
        /// Resource name of the billing account for the cost estimate. The resource name has the form
        /// `billingAccounts/{billing_acount_id}`. For example, `billingAccounts/012345-567890-ABCDEF` is the resource
        /// name for billing account `012345-567890-ABCDEF`. Must be specified.
        /// </param>
        public virtual EstimateCostScenarioRequest EstimateCostScenario(Google.Apis.Cloudbilling.v1beta.Data.EstimateCostScenarioForBillingAccountRequest body, string billingAccount)
        {
            return new EstimateCostScenarioRequest(service, body, billingAccount);
        }

        /// <summary>
        /// Use custom pricing in the estimate, using a `CostScenario` with a defined `billingAccount`.
        /// </summary>
        public class EstimateCostScenarioRequest : CloudbillingBaseServiceRequest<Google.Apis.Cloudbilling.v1beta.Data.EstimateCostScenarioForBillingAccountResponse>
        {
            /// <summary>Constructs a new EstimateCostScenario request.</summary>
            public EstimateCostScenarioRequest(Google.Apis.Services.IClientService service, Google.Apis.Cloudbilling.v1beta.Data.EstimateCostScenarioForBillingAccountRequest body, string billingAccount) : base(service)
            {
                BillingAccount = billingAccount;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Resource name of the billing account for the cost estimate. The resource name has the form
            /// `billingAccounts/{billing_acount_id}`. For example, `billingAccounts/012345-567890-ABCDEF` is the
            /// resource name for billing account `012345-567890-ABCDEF`. Must be specified.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("billingAccount", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string BillingAccount { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Cloudbilling.v1beta.Data.EstimateCostScenarioForBillingAccountRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "estimateCostScenario";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/{+billingAccount}:estimateCostScenario";

            /// <summary>Initializes EstimateCostScenario parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("billingAccount", new Google.Apis.Discovery.Parameter
                {
                    Name = "billingAccount",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^billingAccounts/[^/]+$",
                });
            }
        }
    }

    /// <summary>The "v1beta" collection of methods.</summary>
    public class V1betaResource
    {
        private const string Resource = "v1beta";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public V1betaResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Estimate list prices using a `CostScenario` without a defined `billingAccount`.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual EstimateCostScenarioRequest EstimateCostScenario(Google.Apis.Cloudbilling.v1beta.Data.EstimateCostScenarioWithListPriceRequest body)
        {
            return new EstimateCostScenarioRequest(service, body);
        }

        /// <summary>Estimate list prices using a `CostScenario` without a defined `billingAccount`.</summary>
        public class EstimateCostScenarioRequest : CloudbillingBaseServiceRequest<Google.Apis.Cloudbilling.v1beta.Data.EstimateCostScenarioWithListPriceResponse>
        {
            /// <summary>Constructs a new EstimateCostScenario request.</summary>
            public EstimateCostScenarioRequest(Google.Apis.Services.IClientService service, Google.Apis.Cloudbilling.v1beta.Data.EstimateCostScenarioWithListPriceRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Cloudbilling.v1beta.Data.EstimateCostScenarioWithListPriceRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "estimateCostScenario";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta:estimateCostScenario";

            /// <summary>Initializes EstimateCostScenario parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }
}
namespace Google.Apis.Cloudbilling.v1beta.Data
{
    /// <summary>Specifies the regions for Cache Fill.</summary>
    public class CacheFillRegions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The destination region for cache fill.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationRegion")]
        public virtual string DestinationRegion { get; set; }

        /// <summary>The source region for cache fill.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceRegion")]
        public virtual string SourceRegion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies usage for Cloud CDN egress.</summary>
    public class CloudCdnEgressWorkload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The destination for the cache egress charges.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cacheEgressDestination")]
        public virtual string CacheEgressDestination { get; set; }

        /// <summary>
        /// Cache egress usage. The rate of data cache egressed in the destination. For example : units such as "GiBy/s"
        /// or "TBy/mo".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cacheEgressRate")]
        public virtual Usage CacheEgressRate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies usage for Cloud CDN resources.</summary>
    public class CloudCdnWorkload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The source service for the cache fill.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cacheFillOriginService")]
        public virtual string CacheFillOriginService { get; set; }

        /// <summary>
        /// Cache fill usage. The rate of data transferred between cache fill regions. For example: units such as
        /// "GiBy/s" or "TBy/mo".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cacheFillRate")]
        public virtual Usage CacheFillRate { get; set; }

        /// <summary>
        /// The regions where data is transferred from Google data locations into Google global cache servers. The SKU
        /// prices for cache fill across services are the same.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cacheFillRegions")]
        public virtual CacheFillRegions CacheFillRegions { get; set; }

        /// <summary>
        /// Cache look up requests. This is specified to indicate the number of requests. For example: units such as
        /// "1/s".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cacheLookUpRate")]
        public virtual Usage CacheLookUpRate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The interconnect egress only includes the Interconnect Egress. Please use the standard egress traffic interface
    /// to specify your standard egress usage.
    /// </summary>
    public class CloudInterconnectEgressWorkload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Data egress usage. This usage applies when you move or copy data from one Google Cloud service to another
        /// service. Expected units such as "GiBy/s, By/s, etc."
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("egressRate")]
        public virtual Usage EgressRate { get; set; }

        /// <summary>
        /// Locations in the [Interconnect connection location
        /// table](https://cloud.google.com/vpc/network-pricing#interconnect-pricing). This is the interconnect egress
        /// charges.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interconnectConnectionLocation")]
        public virtual string InterconnectConnectionLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies usage for Cloud Interconnect resources.</summary>
    public class CloudInterconnectWorkload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>VLAN attachment used for interconnect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interconnectAttachments")]
        public virtual System.Collections.Generic.IList<VlanAttachment> InterconnectAttachments { get; set; }

        /// <summary>Vlan attachment type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interconnectType")]
        public virtual string InterconnectType { get; set; }

        /// <summary>Interconnect circuit link type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkType")]
        public virtual string LinkType { get; set; }

        /// <summary>
        /// Interconnect usage. This is specified as a unitless quantity which indicates the number of circuit
        /// provisioned in interconnect.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provisionedLinkCount")]
        public virtual Usage ProvisionedLinkCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specification of a network type. Network egress within Google Cloud applies when you move or copy data from one
    /// Cloud Storage bucket to another or when another Google Cloud service accesses data in your Cloud Storage
    /// bucket.This includes the network egress within Google Cloud and the general network usage.
    /// </summary>
    public class CloudStorageEgressWorkload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Where the data is sent to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationContinent")]
        public virtual string DestinationContinent { get; set; }

        /// <summary>
        /// Egress usage rate. This usage applies when you move or copy data from one Cloud Storage bucket to another or
        /// when another Google Cloud service accesses data in your Cloud Storage bucket. Expected units such as
        /// "GiBy/s, By/s, ..."
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("egressRate")]
        public virtual Usage EgressRate { get; set; }

        /// <summary>Where the data comes from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceContinent")]
        public virtual string SourceContinent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies usage of Cloud Storage resources.</summary>
    public class CloudStorageWorkload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Data retrieval usage. A retrieval cost applies when data or metadata is read, copied, or rewritten . For
        /// example: units such as "GiBy/s" or "By/s".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataRetrieval")]
        public virtual Usage DataRetrieval { get; set; }

        /// <summary>
        /// Data storage usage. The amount of data stored in buckets. For example: units such as "GiBy/s" or "TBy/mo".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataStored")]
        public virtual Usage DataStored { get; set; }

        /// <summary>Specify dual regions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dualRegion")]
        public virtual DualRegional DualRegion { get; set; }

        /// <summary>Specify multi regions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiRegion")]
        public virtual MultiRegional MultiRegion { get; set; }

        /// <summary>
        /// Class A operation usage in Cloud Storage, such as listing the objects in buckets. See the [operations
        /// pricing](https://cloud.google.com/storage/pricing#operations-pricing) tables for a list of which operations
        /// fall into each class. For example: units such as "1/s".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationA")]
        public virtual Usage OperationA { get; set; }

        /// <summary>
        /// Class B operation usage in Cloud Storage, such as `getIamPolicy`. See the [operations
        /// pricing](https://cloud.google.com/storage/pricing#operations-pricing) tables for a list of which operations
        /// fall into each class. For example: units such as "1/s".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationB")]
        public virtual Usage OperationB { get; set; }

        /// <summary>Specify a single region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual Regional Region { get; set; }

        /// <summary>
        /// The [storage class](https://cloud.google.com/storage/docs/storage-classes#classes) of the data and
        /// operation. For example: "standard" or "nearline".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageClass")]
        public virtual string StorageClass { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Commitments give you the ability to pay a recurring fee in exchange for a benefit, such as a discount for your
    /// use. For example, this object might contain details of a [spend-based committed use discount
    /// (CUD)](https://cloud.google.com/docs/cuds#spend_based_commitments). Within a CostScenario, adding a commitment
    /// includes the cost of the commitment and any discounts.
    /// </summary>
    public class Commitment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A name for this commitment. All commitments in a CostScenario must have unique names. Each name
        /// may be at most 128 characters long.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>A resource-based committed use discount (CUD).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmResourceBasedCud")]
        public virtual VmResourceBasedCud VmResourceBasedCud { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Estimated cost for a commitment.</summary>
    public class CommitmentCostEstimate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Total estimated costs for the commitment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commitmentTotalCostEstimate")]
        public virtual CostEstimate CommitmentTotalCostEstimate { get; set; }

        /// <summary>The name of the commitment, as specified in the `CostScenario`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Estimated costs for each SKU in the commitment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skuCostEstimates")]
        public virtual System.Collections.Generic.IList<SkuCostEstimate> SkuCostEstimates { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specificies usage of a set of identical compute VM instances.</summary>
    public class ComputeVmWorkload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Defines whether each instance has confidential compute enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableConfidentialCompute")]
        public virtual System.Nullable<bool> EnableConfidentialCompute { get; set; }

        /// <summary>Guest accelerators attached to each machine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("guestAccelerator")]
        public virtual GuestAccelerator GuestAccelerator { get; set; }

        /// <summary>
        /// VM usage. This is specified as a unitless quantity which indicates the number of instances running.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instancesRunning")]
        public virtual Usage InstancesRunning { get; set; }

        /// <summary>Premium image licenses used by each instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("licenses")]
        public virtual System.Collections.Generic.IList<string> Licenses { get; set; }

        /// <summary>The machine type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual MachineType MachineType { get; set; }

        /// <summary>Persistent disks attached to each instance. Must include a boot disk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("persistentDisks")]
        public virtual System.Collections.Generic.IList<PersistentDisk> PersistentDisks { get; set; }

        /// <summary>Defines whether each instance is preemptible.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preemptible")]
        public virtual System.Nullable<bool> Preemptible { get; set; }

        /// <summary>
        /// The [region](https://cloud.google.com/compute/docs/regions-zones) where the VMs run. For example:
        /// "us-central1".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An estimated cost.</summary>
    public class CostEstimate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The estimated credits applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creditEstimates")]
        public virtual System.Collections.Generic.IList<CreditEstimate> CreditEstimates { get; set; }

        /// <summary>The estimated net cost after applying credits.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("netCostEstimate")]
        public virtual Money NetCostEstimate { get; set; }

        /// <summary>The estimated cost prior to applying credits.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preCreditCostEstimate")]
        public virtual Money PreCreditCostEstimate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of a estimating the costs of a `CostScenario`.</summary>
    public class CostEstimationResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The ISO 4217 currency code for the cost estimate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>Required. Estimated costs for each idealized month of a `CostScenario`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segmentCostEstimates")]
        public virtual System.Collections.Generic.IList<SegmentCostEstimate> SegmentCostEstimates { get; set; }

        /// <summary>Required. Information about SKUs used in the estimate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skus")]
        public virtual System.Collections.Generic.IList<Sku> Skus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Encapsulates all the information needed to perform a cost estimate. It includes a specification of the Google
    /// Cloud usage whose costs are estimated, and configuration options.
    /// </summary>
    public class CostScenario : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// New commitments to estimate the costs for. The cost of the commitments will be included in the estimate
        /// result and discounts the commitment entitles will be included in the workload cost estimates. A maximum of
        /// 100 workloads can be provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commitments")]
        public virtual System.Collections.Generic.IList<Commitment> Commitments { get; set; }

        /// <summary>Configuration for the scenario.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scenarioConfig")]
        public virtual ScenarioConfig ScenarioConfig { get; set; }

        /// <summary>
        /// The Google Cloud usage whose costs are estimated. A maximum of 100 workloads can be provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workloads")]
        public virtual System.Collections.Generic.IList<Workload> Workloads { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An estimated credit applied to the costs on a SKU.</summary>
    public class CreditEstimate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The estimated credit amount.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creditAmount")]
        public virtual Money CreditAmount { get; set; }

        /// <summary>The credit description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creditDescription")]
        public virtual string CreditDescription { get; set; }

        /// <summary>The credit type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creditType")]
        public virtual string CreditType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specification of a custom machine type.</summary>
    public class CustomMachineType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The machine series. Only certain [machine
        /// series](https://cloud.google.com/compute/docs/general-purpose-machines#custom_machine_types) support custom
        /// configurations. For example: "n1".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineSeries")]
        public virtual string MachineSeries { get; set; }

        /// <summary>
        /// Required. Memory size of the VM in GB (2^30 bytes). Must be an increment of 0.25 (256 MB). Each [machine
        /// series](https://cloud.google.com/compute/docs/machine-types#machine_type_comparison) has limitations on
        /// allowed values for the ratio of memory-to-vCPU count.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memorySizeGb")]
        public virtual System.Nullable<double> MemorySizeGb { get; set; }

        /// <summary>
        /// Required. The number of vCPUs. The allowed values depend on the [machine
        /// series](https://cloud.google.com/compute/docs/machine-types#machine_type_comparison).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("virtualCpuCount")]
        public virtual System.Nullable<long> VirtualCpuCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Area contains dual locations.</summary>
    public class DualRegional : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The [location name](https://cloud.google.com/storage/docs/locations#available-locations) where the data is
        /// stored. For example: "asia1" for dual region.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for EstimateCostScenarioForBillingAccount.</summary>
    public class EstimateCostScenarioForBillingAccountRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The scenario to estimate costs for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("costScenario")]
        public virtual CostScenario CostScenario { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for EstimateCostScenarioForBillingAccount</summary>
    public class EstimateCostScenarioForBillingAccountResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The result of the cost estimation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("costEstimationResult")]
        public virtual CostEstimationResult CostEstimationResult { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for EstimateCostScenarioWithListPrice.</summary>
    public class EstimateCostScenarioWithListPriceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The scenario to estimate costs for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("costScenario")]
        public virtual CostScenario CostScenario { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for EstimateCostScenarioWithListPrice</summary>
    public class EstimateCostScenarioWithListPriceResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The result of the cost estimation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("costEstimationResult")]
        public virtual CostEstimationResult CostEstimationResult { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a point in time.</summary>
    public class EstimationTimePoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The point in time, relative to the start of the time frame covered by the cost estimate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("estimationTimeFrameOffset")]
        public virtual object EstimationTimeFrameOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specification of a set of guest accelerators attached to a machine.</summary>
    public class GuestAccelerator : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of the guest accelerator cards exposed to each instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acceleratorCount")]
        public virtual System.Nullable<long> AcceleratorCount { get; set; }

        /// <summary>The type of the guest accelerator cards. For example: "nvidia-tesla-t4".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acceleratorType")]
        public virtual string AcceleratorType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specification of machine series, memory, and number of vCPUs.</summary>
    public class MachineType : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("customMachineType")]
        public virtual CustomMachineType CustomMachineType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("predefinedMachineType")]
        public virtual PredefinedMachineType PredefinedMachineType { get; set; }

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

    /// <summary>Area contains multiple locations.</summary>
    public class MultiRegional : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The [location name](https://cloud.google.com/storage/docs/locations#available-locations) where the data is
        /// stored. For example: "us" for multi-region.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specification of a persistent disk attached to a VM.</summary>
    public class PersistentDisk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies the size of disk. Must be at least 10 GB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskSize")]
        public virtual Usage DiskSize { get; set; }

        /// <summary>
        /// The [disk type](https://cloud.google.com/compute/docs/disks#disk-types). For example: "pd-standard".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskType")]
        public virtual string DiskType { get; set; }

        /// <summary>
        /// Indicates how many IOPS to provision for the disk for extreme persistent disks. This sets the number of I/O
        /// operations per second that the disk can handle. Values must be between 10,000 and 120,000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provisionedIops")]
        public virtual Usage ProvisionedIops { get; set; }

        /// <summary>The geographic scope of the disk. Defaults to `SCOPE_ZONAL` if not specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specification of a predefined machine type.</summary>
    public class PredefinedMachineType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The [machine type](https://cloud.google.com/compute/docs/machine-types). For example: "n1-standard1".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specify Premium Tier Internet egress networking.</summary>
    public class PremiumTierEgressWorkload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Where the data is sent to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationContinent")]
        public virtual string DestinationContinent { get; set; }

        /// <summary>Premium Tier egress usage. Expected units such as "GiBy/s, By/s, etc."</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("egressRate")]
        public virtual Usage EgressRate { get; set; }

        /// <summary>
        /// Which [region](https://cloud.google.com/compute/docs/regions-zones) the egress data comes from.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceRegion")]
        public virtual string SourceRegion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The price of a SKU at a point int time.</summary>
    public class Price : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The timestamp within the estimation time frame when the price was set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectiveTime")]
        public virtual EstimationTimePoint EffectiveTime { get; set; }

        /// <summary>The type of price. Possible values: "RATE"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceType")]
        public virtual string PriceType { get; set; }

        /// <summary>A set of tiered rates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rate")]
        public virtual Rate Rate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A SKU price consisting of tiered rates.</summary>
    public class Rate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The service tiers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tiers")]
        public virtual System.Collections.Generic.IList<RateTier> Tiers { get; set; }

        /// <summary>
        /// The SKU's pricing unit. For example, if the tier price is $1 per 1000000 Bytes, then this field will show
        /// 'By'. The `start_amount` field in each tier will be in this unit.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; }

        /// <summary>
        /// The SKU's count for the pricing unit. For example, if the tier price is $1 per 1000000 Bytes, then this
        /// column will show 1000000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unitCount")]
        public virtual System.Nullable<double> UnitCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Pricing details for a service tier.</summary>
    public class RateTier : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The price for this tier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("price")]
        public virtual Money Price { get; set; }

        /// <summary>
        /// The magnitude of usage in which the tier interval begins. Example: "From 100 GiBi the price is $1 per byte"
        /// implies `start_amount` = 100
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startAmount")]
        public virtual System.Nullable<double> StartAmount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Area contains only one location.</summary>
    public class Regional : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The [location name](https://cloud.google.com/storage/docs/locations#available-locations). For example:
        /// "us-central1" for region.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for a CostScenario. Specifies how costs are calculated.</summary>
    public class ScenarioConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Time frame for the estimate. Workloads must specify usage for this duration. Duration must be at least 1
        /// hour (3,600 seconds) and at most 10 years (315,360,000 seconds). The calculations for years and months are
        /// based on a 730-hour (2,628,000-second) month. For durations longer than one month (2,628,000 seconds), the
        /// duration is rounded up to the next month, so the estimate shows you the costs for full months. For example,
        /// a duration of 3,232,800 seconds (roughly 5 weeks) is rounded up to 2 months.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("estimateDuration")]
        public virtual object EstimateDuration { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Workload cost estimates for a single time segment.</summary>
    public class SegmentCostEstimate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Estimated costs for each commitment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commitmentCostEstimates")]
        public virtual System.Collections.Generic.IList<CommitmentCostEstimate> CommitmentCostEstimates { get; set; }

        /// <summary>Timestamp for the start of the segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segmentStartTime")]
        public virtual EstimationTimePoint SegmentStartTime { get; set; }

        /// <summary>Total estimated costs for the time segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segmentTotalCostEstimate")]
        public virtual CostEstimate SegmentTotalCostEstimate { get; set; }

        /// <summary>Estimated costs for each workload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workloadCostEstimates")]
        public virtual System.Collections.Generic.IList<WorkloadCostEstimate> WorkloadCostEstimates { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about SKUs appearing in the cost estimate.</summary>
    public class Sku : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The display name for the SKU. Example: A2 Instance Core running in Americas</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// A timeline of prices for a SKU in chronological order. Note: The API currently only supports using a
        /// constant price for the entire estimation time frame so this list will contain a single value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prices")]
        public virtual System.Collections.Generic.IList<Price> Prices { get; set; }

        /// <summary>The resource name for the SKU. Example: "services/DA34-426B-A397/skus/AA95-CD31-42FE"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sku")]
        public virtual string SkuValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Estimated cost for usage on a SKU.</summary>
    public class SkuCostEstimate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The estimated cost for the usage on this SKU.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("costEstimate")]
        public virtual CostEstimate CostEstimate { get; set; }

        /// <summary>
        /// The resource name for the SKU. Example: "services/DA34-426B-A397/skus/AA95-CD31-42FE" More information about
        /// the SKU can be found in the `skus` field of the `CostEstimationResult`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sku")]
        public virtual string Sku { get; set; }

        /// <summary>The amount of usage on this SKU.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usageAmount")]
        public virtual System.Nullable<double> UsageAmount { get; set; }

        /// <summary>The unit for the usage on this SKU.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usageUnit")]
        public virtual string UsageUnit { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specify Standard Tier Internet egress networking.</summary>
    public class StandardTierEgressWorkload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Standard tier egress usage. Expected units such as "GiBy/s, By/s, etc."</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("egressRate")]
        public virtual Usage EgressRate { get; set; }

        /// <summary>
        /// Which [region](https://cloud.google.com/compute/docs/regions-zones) the egress data comes from.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceRegion")]
        public virtual string SourceRegion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An amount of usage over a time frame.</summary>
    public class Usage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A timeline of usage rates over the estimate interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usageRateTimeline")]
        public virtual UsageRateTimeline UsageRateTimeline { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A timeline of usage rates. Consists of a series of entries, each of which specifies a constant rate of usage
    /// during a time interval. Each entry contains an effective time. The usage rate is in effect from that time until
    /// the effective time of the subsequent entry, or, for the last entry, for the remaining portion of estimation time
    /// frame. Effective times are specified as an offset into the estimation time frame. Usage is considered to be zero
    /// until the `effective_time` of the first entry. All subsequent entries must have an effective time greater than
    /// the previous entry and less than the estimate time frame. The effective time on all entries must be an integer
    /// number of hours.
    /// </summary>
    public class UsageRateTimeline : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The unit for the usage rate in each timeline entry. If you provide an incorrect unit for an instance, the
        /// correct unit is provided in the error message. The supported units are a subset of [The Unified Code for
        /// Units of Measure](https://ucum.org/ucum.html) standard: * **Time units (TIME-UNIT)** * `s` second * `min`
        /// minute * `h` hour * `d` day * `wk` week * `mo` month * `yr` year * `ms` millisecond * `us` microsecond *
        /// `ns` nanosecond * **Basic storage units (BASIC-STORAGE-UNIT)** * `bit` bit * `By` byte * **Count units
        /// (COUNT-UNIT)** * `count` count * **Prefixes (PREFIX)** * `k` kilo (10^3) * `M` mega (10^6) * `G` giga (10^9)
        /// * `T` tera (10^12) * `P` peta (10^15) * `Ki` kibi (2^10) * `Mi` mebi (2^20) * `Gi` gibi (2^30) * `Ti` tebi
        /// (2^40) * `Pi` pebi (2^50) **Grammar** The grammar also includes these connectors: * `/` division or ratio
        /// (as an infix operator). For example: `kBy/{email}` or `MiBy/10ms`. * `.` multiplication or composition (as
        /// an infix operator). For example: `GBy.d` or `k{watt}.h`. The grammar for a unit is as follows: ```
        /// Expression = Component { "." Component } { "/" Component } ; Component = ( [ PREFIX ] UNIT | "%" ) [
        /// Annotation ] | Annotation | "1" ; UNIT = TIME-UNIT | STORAGE-UNIT | DATA-UNIT | COUNT-UNIT Annotation = "{"
        /// NAME "}" ; ``` Examples: * Request per second: `1/s` or `{requests}/s` * GibiBytes: `GiBy` * GibiBytes *
        /// seconds: `GiBy.s`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; }

        /// <summary>
        /// The timeline entries. Each entry has a start time and usage rate. The start time specifies the effective
        /// time of the usage rate. The entries must be sorted by start time in an increasing order.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usageRateTimelineEntries")]
        public virtual System.Collections.Generic.IList<UsageRateTimelineEntry> UsageRateTimelineEntries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A usage rate timeline entry. Each entry specifies a constant usage rate during a time interval.
    /// </summary>
    public class UsageRateTimelineEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The effective time for this entry. The usage rate is in effect starting at this time until the effective
        /// time of the subsequent entry in the timeline. The last entry defines the usage rate until the end of the
        /// `Usage` time frame. Must correspond to an integer number of hours.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectiveTime")]
        public virtual EstimationTimePoint EffectiveTime { get; set; }

        /// <summary>The usage rate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usageRate")]
        public virtual System.Nullable<double> UsageRate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>VLAN attachment for cloud interconnect.</summary>
    public class VlanAttachment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Capacities in the [pricing table](https://cloud.google.com/vpc/network-pricing#interconnect-pricing)
        /// Examples of capacity are: 50/100/200/300/400/500-Mbps, 1/2/5/10/20/50-Gbps.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bandwidth")]
        public virtual string Bandwidth { get; set; }

        /// <summary>
        /// VLAN usage. This is specified as a unitless quantity which indicates the number of VLAN attachment used in
        /// interconnect.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vlanCount")]
        public virtual Usage VlanCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies a resource-based committed use discount (CUD).</summary>
    public class VmResourceBasedCud : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Guest accelerator, known as GPU.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("guestAccelerator")]
        public virtual GuestAccelerator GuestAccelerator { get; set; }

        /// <summary>
        /// The machine series for CUD. For example: "n1" for general purpose N1 machine type commitments. "n2" for
        /// general purpose N2 machine type commitments. "e2" for general purpose E2 machine type commitments. "n2d" for
        /// general purpose N2D machine type commitments. "t2d" for general purpose T2D machine type commitments.
        /// "c2"/"c2d" for compute-optimized commitments. "m1"/"m2" for the memory-optimized commitments. "a2' for the
        /// accelerator-optimized commitments.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineSeries")]
        public virtual string MachineSeries { get; set; }

        /// <summary>Memory size of the VM in GB (2^30 bytes). Must be an increment of 0.25 (256 MB).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memorySizeGb")]
        public virtual System.Nullable<double> MemorySizeGb { get; set; }

        /// <summary>Commitment usage plan.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plan")]
        public virtual string Plan { get; set; }

        /// <summary>The region where the VM runs. For example: "us-central1"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>
        /// The number of vCPUs. The number of vCPUs must be an integer of 0 or more and can be even or odd.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("virtualCpuCount")]
        public virtual System.Nullable<long> VirtualCpuCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies usage on a single Google Cloud product over a time frame. Each Google Cloud product has its own
    /// message, containing specific product configuration parameters of the product usage amounts along each dimension
    /// in which the product is billed.
    /// </summary>
    public class Workload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Usage on Google Cloud CDN Egress.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudCdnEgressWorkload")]
        public virtual CloudCdnEgressWorkload CloudCdnEgressWorkload { get; set; }

        /// <summary>Usage on Google Cloud CDN.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudCdnWorkload")]
        public virtual CloudCdnWorkload CloudCdnWorkload { get; set; }

        /// <summary>Usage on Google Cloud Interconnect Egress.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudInterconnectEgressWorkload")]
        public virtual CloudInterconnectEgressWorkload CloudInterconnectEgressWorkload { get; set; }

        /// <summary>Usage on Google Cloud Interconnect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudInterconnectWorkload")]
        public virtual CloudInterconnectWorkload CloudInterconnectWorkload { get; set; }

        /// <summary>Usage on a cloud storage egress.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudStorageEgressWorkload")]
        public virtual CloudStorageEgressWorkload CloudStorageEgressWorkload { get; set; }

        /// <summary>Usage on Google Cloud Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudStorageWorkload")]
        public virtual CloudStorageWorkload CloudStorageWorkload { get; set; }

        /// <summary>Usage of a Google Compute Engine Virtual Machine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computeVmWorkload")]
        public virtual ComputeVmWorkload ComputeVmWorkload { get; set; }

        /// <summary>
        /// Required. A name for this workload. All workloads in a `CostScenario` must have a unique `name`. Each `name`
        /// may be at most 128 characters long.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Usage on Premium Tier Internet Egress.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("premiumTierEgressWorkload")]
        public virtual PremiumTierEgressWorkload PremiumTierEgressWorkload { get; set; }

        /// <summary>Usage on Standard Tier Internet Egress.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("standardTierEgressWorkload")]
        public virtual StandardTierEgressWorkload StandardTierEgressWorkload { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Estimated cost for a workload.</summary>
    public class WorkloadCostEstimate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the workload, as specified in the `CostScenario`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Estimated costs for each SKU in the workload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skuCostEstimates")]
        public virtual System.Collections.Generic.IList<SkuCostEstimate> SkuCostEstimates { get; set; }

        /// <summary>Total estimated costs for the workload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workloadTotalCostEstimate")]
        public virtual CostEstimate WorkloadTotalCostEstimate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
