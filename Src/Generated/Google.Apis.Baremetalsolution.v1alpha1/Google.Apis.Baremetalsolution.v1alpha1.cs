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

namespace Google.Apis.Baremetalsolution.v1alpha1
{
    /// <summary>The Baremetalsolution Service.</summary>
    public class BaremetalsolutionService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1alpha1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public BaremetalsolutionService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public BaremetalsolutionService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "baremetalsolution";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://baremetalsolution.googleapis.com/";
        #else
            "https://baremetalsolution.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://baremetalsolution.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Bare Metal Solution API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Bare Metal Solution API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for Baremetalsolution requests.</summary>
    public abstract class BaremetalsolutionBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new BaremetalsolutionBaseServiceRequest instance.</summary>
        protected BaremetalsolutionBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Baremetalsolution parameter list.</summary>
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
            Locations = new LocationsResource(service);
            ProvisioningQuotas = new ProvisioningQuotasResource(service);
        }

        /// <summary>Gets the Locations resource.</summary>
        public virtual LocationsResource Locations { get; }

        /// <summary>The "locations" collection of methods.</summary>
        public class LocationsResource
        {
            private const string Resource = "locations";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public LocationsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Submit a provisiong configuration for a given project.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="project">Required. The target project of the provisioning request.</param>
            /// <param name="location">Required. The target location of the provisioning request.</param>
            public virtual SubmitProvisioningConfigRequest SubmitProvisioningConfig(Google.Apis.Baremetalsolution.v1alpha1.Data.SubmitProvisioningConfigRequest body, string project, string location)
            {
                return new SubmitProvisioningConfigRequest(service, body, project, location);
            }

            /// <summary>Submit a provisiong configuration for a given project.</summary>
            public class SubmitProvisioningConfigRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v1alpha1.Data.ProvisioningConfig>
            {
                /// <summary>Constructs a new SubmitProvisioningConfig request.</summary>
                public SubmitProvisioningConfigRequest(Google.Apis.Services.IClientService service, Google.Apis.Baremetalsolution.v1alpha1.Data.SubmitProvisioningConfigRequest body, string project, string location) : base(service)
                {
                    Project = project;
                    Location = location;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The target project of the provisioning request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Project { get; private set; }

                /// <summary>Required. The target location of the provisioning request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Location { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Baremetalsolution.v1alpha1.Data.SubmitProvisioningConfigRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "submitProvisioningConfig";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha1/{+project}/{+location}:submitProvisioningConfig";

                /// <summary>Initializes SubmitProvisioningConfig parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                    {
                        Name = "project",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                    RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                    {
                        Name = "location",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^locations/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the ProvisioningQuotas resource.</summary>
        public virtual ProvisioningQuotasResource ProvisioningQuotas { get; }

        /// <summary>The "provisioningQuotas" collection of methods.</summary>
        public class ProvisioningQuotasResource
        {
            private const string Resource = "provisioningQuotas";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ProvisioningQuotasResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>List the budget details to provision resources on a given project.</summary>
            /// <param name="parent">Required. The parent project containing the provisioning quotas.</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>List the budget details to provision resources on a given project.</summary>
            public class ListRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v1alpha1.Data.ListProvisioningQuotasResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. The parent project containing the provisioning quotas.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>The maximum number of items to return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>The next_page_token value returned from a previous List request, if any.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha1/{+parent}/provisioningQuotas";

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
        }
    }
}
namespace Google.Apis.Baremetalsolution.v1alpha1.Data
{
    /// <summary>Configuration parameters for a new instance.</summary>
    public class InstanceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Client network address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientNetwork")]
        public virtual NetworkAddress ClientNetwork { get; set; }

        /// <summary>Whether the instance should be provisioned with Hyperthreading enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hyperthreading")]
        public virtual System.Nullable<bool> Hyperthreading { get; set; }

        /// <summary>
        /// A transient unique identifier to idenfity an instance within an ProvisioningConfig request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Instance type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceType")]
        public virtual string InstanceType { get; set; }

        /// <summary>Location where to deploy the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>OS image to initialize the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osImage")]
        public virtual string OsImage { get; set; }

        /// <summary>Private network address, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateNetwork")]
        public virtual NetworkAddress PrivateNetwork { get; set; }

        /// <summary>
        /// User note field, it can be used by customers to add additional information for the BMS Ops team
        /// (b/194021617).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userNote")]
        public virtual string UserNote { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource budget.</summary>
    public class InstanceQuota : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of machines than can be created for the given location and instance_type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableMachineCount")]
        public virtual System.Nullable<int> AvailableMachineCount { get; set; }

        /// <summary>Instance type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceType")]
        public virtual string InstanceType { get; set; }

        /// <summary>Location where the quota applies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for ListProvisioningQuotas.</summary>
    public class ListProvisioningQuotasResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The provisioning quotas registered in this project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provisioningQuotas")]
        public virtual System.Collections.Generic.IList<ProvisioningQuota> ProvisioningQuotas { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A LUN range.</summary>
    public class LunRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of LUNs to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantity")]
        public virtual System.Nullable<int> Quantity { get; set; }

        /// <summary>The requested size of each LUN, in GB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeGb")]
        public virtual System.Nullable<int> SizeGb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A network.</summary>
    public class NetworkAddress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>IP address to be assigned to the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual string Address { get; set; }

        /// <summary>
        /// Name of the existing network to use. Will be of the format at--vlan for pre-intake UI networks like for eg,
        /// at-123456-vlan001 or any user-defined name like for eg, my-network-name for networks provisioned using
        /// intake UI. The field is exclusively filled only in case of an already existing network. Mutually exclusive
        /// with network_id.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("existingNetworkId")]
        public virtual string ExistingNetworkId { get; set; }

        /// <summary>
        /// Name of the network to use, within the same ProvisioningConfig request. This represents a new network being
        /// provisioned in the same request. Can have any user-defined name like for eg, my-network-name. Mutually
        /// exclusive with existing_network_id.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkId")]
        public virtual string NetworkId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration parameters for a new network.</summary>
    public class NetworkConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Interconnect bandwidth. Set only when type is CLIENT.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bandwidth")]
        public virtual string Bandwidth { get; set; }

        /// <summary>CIDR range of the network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cidr")]
        public virtual string Cidr { get; set; }

        /// <summary>A transient unique identifier to identify a volume within an ProvisioningConfig request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Location where to deploy the network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>Service CIDR, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceCidr")]
        public virtual string ServiceCidr { get; set; }

        /// <summary>The type of this network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// User note field, it can be used by customers to add additional information for the BMS Ops team
        /// (b/194021617).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userNote")]
        public virtual string UserNote { get; set; }

        /// <summary>
        /// List of VLAN attachments. As of now there are always 2 attachments, but it is going to change in the future
        /// (multi vlan).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vlanAttachments")]
        public virtual System.Collections.Generic.IList<VlanAttachment> VlanAttachments { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A NFS export entry.</summary>
    public class NfsExport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Allow dev.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowDev")]
        public virtual System.Nullable<bool> AllowDev { get; set; }

        /// <summary>Allow the setuid flag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowSuid")]
        public virtual System.Nullable<bool> AllowSuid { get; set; }

        /// <summary>A CIDR range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cidr")]
        public virtual string Cidr { get; set; }

        /// <summary>Either a single machine, identified by an ID, or a comma-separated list of machine IDs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineId")]
        public virtual string MachineId { get; set; }

        /// <summary>Network to use to publish the export.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkId")]
        public virtual string NetworkId { get; set; }

        /// <summary>Disable root squashing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noRootSquash")]
        public virtual System.Nullable<bool> NoRootSquash { get; set; }

        /// <summary>Export permissions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual string Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An provisioning configuration.</summary>
    public class ProvisioningConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Instances to be created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instances")]
        public virtual System.Collections.Generic.IList<InstanceConfig> Instances { get; set; }

        /// <summary>Networks to be created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networks")]
        public virtual System.Collections.Generic.IList<NetworkConfig> Networks { get; set; }

        /// <summary>A reference to track the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ticketId")]
        public virtual string TicketId { get; set; }

        /// <summary>Volumes to be created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumes")]
        public virtual System.Collections.Generic.IList<VolumeConfig> Volumes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A provisioning quota for a given project.</summary>
    public class ProvisioningQuota : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Instance quota.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceQuota")]
        public virtual InstanceQuota InstanceQuota { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for SubmitProvisioningConfig.</summary>
    public class SubmitProvisioningConfigRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Email provided to send a confirmation with provisioning config to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>Required. The ProvisioningConfig to submit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provisioningConfig")]
        public virtual ProvisioningConfig ProvisioningConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A GCP vlan attachment.</summary>
    public class VlanAttachment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifier of the VLAN attachment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Attachment pairing key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pairingKey")]
        public virtual string PairingKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration parameters for a new volume.</summary>
    public class VolumeConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A transient unique identifier to identify a volume within an ProvisioningConfig request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Location where to deploy the volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>LUN ranges to be configured. Set only when protocol is PROTOCOL_FC.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lunRanges")]
        public virtual System.Collections.Generic.IList<LunRange> LunRanges { get; set; }

        /// <summary>Machine ids connected to this volume. Set only when protocol is PROTOCOL_FC.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineIds")]
        public virtual System.Collections.Generic.IList<string> MachineIds { get; set; }

        /// <summary>NFS exports. Set only when protocol is PROTOCOL_NFS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nfsExports")]
        public virtual System.Collections.Generic.IList<NfsExport> NfsExports { get; set; }

        /// <summary>Volume protocol.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protocol")]
        public virtual string Protocol { get; set; }

        /// <summary>
        /// The requested size of this volume, in GB. This will be updated in a later iteration with a generic size
        /// field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeGb")]
        public virtual System.Nullable<int> SizeGb { get; set; }

        /// <summary>Whether snapshots should be enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotsEnabled")]
        public virtual System.Nullable<bool> SnapshotsEnabled { get; set; }

        /// <summary>The type of this Volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// User note field, it can be used by customers to add additional information for the BMS Ops team
        /// (b/194021617).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userNote")]
        public virtual string UserNote { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
